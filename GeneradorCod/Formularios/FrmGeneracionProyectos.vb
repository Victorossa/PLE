Public Class FrmGeneracionProyectos

#Region "Variables y Metodos Globales"

    'Aviso_Acciones(10, "Eliminado...")
    Dim ProyectoID As Integer
    Dim TecnologiaID As Integer
    Dim PlantillaID As Integer
    Dim TiempoDuracionAviso As Integer = 0
    Dim TiempoPararAviso As Integer = 0
    Dim ProyectosYTecnologiasID As Integer
    Dim TablaID As Integer
    'Variable para controlar que se cumpla con los requerimientos para el proyecto trabajado
    Dim VariableValidacionRequerimientos As Boolean
    'Define si se crea o no un documento tecnico del proyecto
    Dim CreaDocumentoTecnico As Boolean
    'Define si se crean o no un Carpetas y archivos creados en las rutas indicadas segun archivo
    Dim CreaCarpetasYArchivos As Boolean
    'Indica que es un componente base para aplicar a todas las tablas del proyecto
    Dim ComponenteBasePorTablas As Boolean
    'Indica que la plantilla tiene un componente con base
    Dim TieneComponenteConBase As Boolean
    'Es el codigo que se genera apartir de una plantilla que tiene un componente base
    Dim CODIGO_GENERADO_PLE_ORIGEN_BASE As String
    'Cuenta las tecnologias aplicadas al proyecto en proceso
    Dim contadorTecnologiasAplicadas As Integer = 0
    Dim EsBase As Boolean = False
    Dim PorTablas As Boolean = False
    Dim NombreArchivoACrear As String
    Dim RutaProcesada As String

    'CARGAS POR TEXCHANGED
    Private Sub ProyectoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIDTextBox.TextChanged
        Try
            ProyectoID = ProyectoIDTextBox.Text
            'Cargas
            CargasPorProyectoID()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CargasPorProyectoID()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoID)
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ProyectoID)
        'Cargas Tablas dependientes he independientes por proyecto
        SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_Proyecto(ProyectoID)
        SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_Proyecto(ProyectoID)
        SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoID)
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ProyectoID)
    End Sub
    'Asigna valor a variable global y ejecuta carga
    Private Sub TecnologiaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        Try
            TecnologiaID = TecnologiaIDTextBox.Text
            'Cargas
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia(TecnologiaID)
        Catch ex As Exception

        End Try
    End Sub
    'Asigna valor a variable global
    Private Sub PlantillaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox.TextChanged
        Try
            PlantillaID = PlantillaIDTextBox.Text
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaID)

        Catch ex As Exception

        End Try
    End Sub
    'Asigna valor a variable global
    Private Sub ProyectosYTecnologiasIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProyectosYTecnologiasIDTextBox.TextChanged
        Try
            ProyectosYTecnologiasID = ProyectosYTecnologiasIDTextBox.Text
        Catch ex As System.Exception

        End Try
    End Sub
    'Tabla ID principal
    Private Sub TablaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TablaIDTextBox.TextChanged
        Try
            TablaID = TablaIDTextBox.Text
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(TablaID)
        Catch ex As System.Exception

        End Try
    End Sub
    'Tablas Independientes y dependientes
    Private Sub TablaID_Depend_TextChanged(sender As Object, e As EventArgs) Handles TablaID_Depend.TextChanged
        Try
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2(TablaID_Depend.Text)
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
            If SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Rows.Count > 0 Then
                TP_TablasYCampos.BackColor = Color.Cornsilk
            Else
                TP_TablasYCampos.BackColor = Color.Transparent
            End If
        Catch ex As System.Exception

        End Try
    End Sub
    Private Sub TablaID_Independiente_TextChanged(sender As Object, e As EventArgs) Handles TablaID_Independiente.TextChanged
        Try
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(TablaID_Independiente.Text)
        Catch ex As System.Exception

        End Try
    End Sub
    'Por Requerimientos de Proyectos
    Private Sub PlantillaIDRequerimientos_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDRequerimientos.TextChanged
        Try
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaIDRequerimientos.Text)
        Catch ex As Exception

        End Try
    End Sub

    'Mensajeria
    Public Sub Aviso_Acciones(ByVal tiempo As Integer, ByVal aviso As String)
        Timer_Acciones.Start()
        TiempoPararAviso = tiempo
        LblInforme.Visible = True
        LblInforme.Text = aviso
    End Sub
    Private Sub Timer_Acciones_Tick(sender As Object, e As EventArgs) Handles Timer_Acciones.Tick
        TiempoDuracionAviso = TiempoDuracionAviso + 1
        If TiempoDuracionAviso = TiempoPararAviso Then
            Timer_Acciones.Stop()
            TiempoDuracionAviso = 0
            TiempoPararAviso = 0
            LblInforme.Text = "..."
            LblInforme.Visible = False
            LblInforme.BringToFront()
        End If
    End Sub




#End Region

#Region "Load de Formulario"
    Private Sub FrmGeneracionProyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
        'Cargas
        Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaID)
        'Cancelaciones
        Cancelar_Proyectos()
        Cancelar_TablasDeProyecto()
        Cancelar_CamposDeTablas()
        Cancelar_RegistroValorRequerimientos()
    End Sub
#End Region

#Region "Proyectos"
#Region "Procedimientos"
    Sub Cancelar_Proyectos()
        'Botones Del Menu
        Nuevo_Menu_Proyectos.Enabled = True
        Guardar_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = True
        Actualizar_Menu_Proyectos.Enabled = False
        Eliminar_Menu_Proyectos.Enabled = False
        'Grid
        ProyectosDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Bloquear_Objetos_Proyectos()
        Parar_Timer_Proyectos()
        Timer_Ubicar_En_Fila_Proyectos()
    End Sub
    'Insertar
    Private Sub SP_Proyectos_EDICION_INSERTAR()
        Try
            Me.SP_Proyectos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_INSERTAR,
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoTextBox.Text,
                                                 DescripcionTextBox.Text)
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            Aviso_Acciones(10, "Guardado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_Proyectos_EDICION_ACTUALIZAR()
        Try
            Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoTextBox.Text,
                                                 DescripcionTextBox.Text)
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            Aviso_Acciones(10, "Actualizado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_Proyectos_EDICION_ELIMINAR()
        Try
            Me.SP_Proyectos_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(ProyectoIDTextBox.Text, Long)))
            Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
            Aviso_Acciones(10, "Eliminado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Proyectos.Click
        Nuevo_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = False
        ProyectosDataGridView.Enabled = False
        Limpiar_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = True
        NombreProyectoTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Proyectos.Click
        Control_Nulos_Proyectos()
        If ControlNulos.Text = "" Then ' Then
            SP_Proyectos_EDICION_INSERTAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Proyectos.Click
        Nuevo_Menu_Proyectos.Enabled = False
        Guardar_Menu_Proyectos.Enabled = False
        Editar_Menu_Proyectos.Enabled = False
        Actualizar_Menu_Proyectos.Enabled = True
        Eliminar_Menu_Proyectos.Enabled = True
        ProyectosDataGridView.Enabled = False
        Desbloquear_Objetos_Proyectos()
        Timer_Actualizar_Proyectos()
        Timer_Eliminar_Proyectos()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Proyectos.Click
        Control_Nulos_Proyectos()
        If ControlNulos.Text = "" Then ' Then
            SP_Proyectos_EDICION_ACTUALIZAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        End If
    End Sub
    Private Sub Eliminar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Proyectos.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Proyectos_EDICION_ELIMINAR()
            Cancelar_Proyectos()
            Parar_Timer_Proyectos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Proyectos()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Proyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Proyectos.Click
        Cancelar_Proyectos()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_Proyectos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreProyectoTextBox.Text = ""
                MsgBox("El nombre del campo: NombreProyecto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreProyectoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreProyectoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreProyectoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreProyectoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreProyectoTextBox.Text = ""
                NombreProyectoTextBox.Focus()
            Else
                DescripcionTextBox.Enabled = True
                DescripcionTextBox.Focus()
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreProyectoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreProyectoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreProyectoTextBox.Text = ""
            NombreProyectoTextBox.Text = Caracter
            NombreProyectoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreProyectoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreProyectoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreProyectoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreProyectoTextBox.Text = ""
            NombreProyectoTextBox.Text = Temp + Caracter
            NombreProyectoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub
    Private Sub DescripcionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Proyectos.Enabled = True Then
                Actualizar_Menu_Proyectos.Enabled = True
                Eliminar_Menu_Proyectos.Enabled = True
            Else
                If DescripcionTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    DescripcionTextBox.Text = ""
                    DescripcionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Proyectos.Enabled = True
                    Timer_Guardar_Proyectos()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_Proyectos()
        NombreProyectoTextBox.Text = "" ''
        DescripcionTextBox.Text = "" ''
        CodigoGeneradoTextBox.Text = ""
    End Sub
    Public Sub Desbloquear_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = True
        DescripcionTextBox.Enabled = True
        'CodigoGeneradoTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Proyectos()
        NombreProyectoTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        'CodigoGeneradoTextBox.Enabled = False
    End Sub

#End Region
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Proyectos As Timer
    Private WithEvents Timer_Actualizar_Menu_Proyectos As Timer
    Private WithEvents Timer_Eliminar_Menu_Proyectos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Proyectos()
        Me.Timer_Guardar_Menu_Proyectos = New Timer
        Timer_Guardar_Menu_Proyectos.Interval = 250
        Timer_Guardar_Menu_Proyectos.Start()
    End Sub
    Private Sub Timer_Actualizar_Proyectos()
        Me.Timer_Actualizar_Menu_Proyectos = New Timer
        Timer_Actualizar_Menu_Proyectos.Interval = 500
        Timer_Actualizar_Menu_Proyectos.Start()
    End Sub
    Private Sub Timer_Eliminar_Proyectos()
        Me.Timer_Eliminar_Menu_Proyectos = New Timer
        Timer_Eliminar_Menu_Proyectos.Interval = 800
        Timer_Eliminar_Menu_Proyectos.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Proyectos.Tick
        If Guardar_Menu_Proyectos.BackColor = Color.White Then
            Guardar_Menu_Proyectos.BackColor = Color.Green
        Else
            Guardar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Proyectos.Tick
        If Actualizar_Menu_Proyectos.BackColor = Color.White Then
            Actualizar_Menu_Proyectos.BackColor = Color.Green
        Else
            Actualizar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Proyectos.Tick
        If Eliminar_Menu_Proyectos.BackColor = Color.White Then
            Eliminar_Menu_Proyectos.BackColor = Color.Red
        Else
            Eliminar_Menu_Proyectos.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Proyectos()
        Me.Timer_Guardar_Menu_Proyectos = New Timer
        Timer_Guardar_Menu_Proyectos.Stop()
        Guardar_Menu_Proyectos.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Proyectos = New Timer
        Timer_Actualizar_Menu_Proyectos.Stop()
        Actualizar_Menu_Proyectos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Proyectos = New Timer
        Timer_Eliminar_Menu_Proyectos.Stop()
        Eliminar_Menu_Proyectos.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Proyectos As Timer
    Dim X_Proyectos
    Private Sub Timer_Ubicar_En_Fila_Proyectos()
        Me.Timer_Ubicacion_Proyectos = New Timer
        Timer_Ubicacion_Proyectos.Interval = 100
        Timer_Ubicacion_Proyectos.Start()
    End Sub
    Private Sub ProyectosDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles ProyectosDataGridView.CellMouseClick
        X_Proyectos = ProyectosDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_Proyectos()
        Try
            Me.ProyectosDataGridView.Rows(X_Proyectos).Selected = True
            Me.ProyectosDataGridView.FirstDisplayedScrollingRowIndex = X_Proyectos
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Proyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Proyectos.Tick
        Ubicar_En_Fila_Proyectos()
        Timer_Ubicacion_Proyectos.Stop()
    End Sub


#End Region
#End Region

#Region "Tecnologias Aplicadas"
    'Carga tecnologias segun proyecto
    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ByVal ProyectoID As Integer)
        Try
            Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter.Fill(Me.DataSetAdministracion.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    'Carga Plantillas Segun Tecnologia
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia(ByVal TecnologiaID As Integer)
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia,
                                                                                  New System.Nullable(Of Integer)(CType(TecnologiaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Asignacion"
    'Asignacion de una por CM
    Private Sub AgregarPlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlantillaToolStripMenuItem.Click
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoIDTextBox.Text)
        Aviso_Acciones(10, "Agregado")
    End Sub
    'Asignacion de una por Doble Click
    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CellMouseDoubleClick
        SP_ProyectosYTecnologias_EDICION_INSERTAR()
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoIDTextBox.Text)
        Aviso_Acciones(10, "Agregado")
    End Sub
    'Asignacion de todas Tecnologias
    Private Sub AgregarlasTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarlasTodasToolStripMenuItem.Click
        AgregandoTecnologias()
    End Sub
    Private Sub AgregarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarTodasToolStripMenuItem.Click
        AgregandoTecnologias()
    End Sub
    Private Sub AgregandoTecnologias()
        Dim contadorTecnologiasAplicadas = SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.CurrentCell = SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows(0).Cells(0)
            SP_ProyectosYTecnologias_EDICION_INSERTAR()
            SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoIDTextBox.Text)
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia(TecnologiaIDTextBox.Text)
        Aviso_Acciones(15, "Se agregaron todas las plantillas")
    End Sub


    'Inserta relacion tecnologia proyecto y plantilla
    Private Sub SP_ProyectosYTecnologias_EDICION_INSERTAR()
        Try
            Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectosYTecnologias_EDICION_INSERTAR,
                                                                          New System.Nullable(Of Integer)(CType(ProyectoID, Integer)),
                                                                          New System.Nullable(Of Integer)(CType(TecnologiaID, Integer)),
                                                                          New System.Nullable(Of Integer)(CType(PlantillaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Eliminacion"
    'Eliminacion CM
    Private Sub EliminarPlantillaSeleccionadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPlantillaSeleccionadaToolStripMenuItem.Click
        SP_ProyectosYTecnologias_EDICION_ELIMINAR(ProyectosYTecnologiasID)
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoID)
        Aviso_Acciones(10, "Eliminado...")
    End Sub
    'Eliminacion doble click
    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.CellMouseDoubleClick
        SP_ProyectosYTecnologias_EDICION_ELIMINAR(ProyectosYTecnologiasIDTextBox.Text)
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoIDTextBox.Text)
        Aviso_Acciones(10, "Eliminado...")
    End Sub
    Private Sub EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem.Click
        ELIMINA_SEGUN_PROYECTO(ProyectoIDParaEliminarPorTecnologia.Text, TecnologiaIDParaEliminarPorTecnologia.Text)
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoIDTextBox.Text)
        Aviso_Acciones(10, "Eliminado...")
    End Sub
    'Eliminacion de Todas
    Private Sub EliminarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodasToolStripMenuItem.Click

    End Sub

    Private Sub SP_ProyectosYTecnologias_EDICION_ELIMINAR(ByVal ProyectosYTecnologiasID As Integer)
        Try
            Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectosYTecnologias_EDICION_ELIMINAR,
                                                                          New System.Nullable(Of Integer)(CType(ProyectosYTecnologiasID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ELIMINA_SEGUN_PROYECTO(ByVal ProyectoID As Integer, ByVal TecnologiaID As Integer)
        Try
            Me.ELIMINA_SEGUN_PROYECTOTableAdapter.Fill(Me.DataSetAdministracion.ELIMINA_SEGUN_PROYECTO,
                                                       New System.Nullable(Of Integer)(CType(ProyectoID, Integer)),
                                                       New System.Nullable(Of Integer)(CType(TecnologiaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

#End Region

#Region "Tablas"
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ByVal ProyectoID As Integer)
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


#Region "Procedimientos"
    Sub Cancelar_TablasDeProyecto()
        'Botones Del Menu
        Nuevo_Menu_TablasDeProyecto.Enabled = True
        Guardar_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = True
        Actualizar_Menu_TablasDeProyecto.Enabled = False
        Eliminar_Menu_TablasDeProyecto.Enabled = False
        'Grid
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ProyectoID)
        CargasPorProyectoID()
        Bloquear_Objetos_TablasDeProyecto()
        Parar_Timer_TablasDeProyecto()
        Timer_Ubicar_En_Fila_TablasDeProyecto()
    End Sub
    'Insertar
    Private Sub SP_TablasDeProyecto_EDICION_INSERTAR()
        Try
            Dim mascara As String = ""
            Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreTablaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(TipoTextBox.Text, Boolean)),
                                                 mascara)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ProyectoID)
            Aviso_Acciones(10, "Guardado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_TablasDeProyecto_EDICION_ACTUALIZAR()
        Dim mascara As String = ""
        Try
            Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreTablaTextBox.Text,
                                                 New System.Nullable(Of Boolean)(CType(TipoTextBox.Text, Boolean)),
                                                 mascara)
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ProyectoID)
            Aviso_Acciones(10, "Actualizado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_TablasDeProyecto_EDICION_ELIMINAR()
        Try
            Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TablaIDTextBox.Text, Long)))
            SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID(ProyectoID)
            Aviso_Acciones(10, "Eliminado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_TablasDeProyecto.Click
        Nuevo_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = False
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Limpiar_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = True
        NombreTablaTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_TablasDeProyecto.Click
        Control_Nulos_TablasDeProyecto()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasDeProyecto_EDICION_INSERTAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_TablasDeProyecto.Click
        Nuevo_Menu_TablasDeProyecto.Enabled = False
        Guardar_Menu_TablasDeProyecto.Enabled = False
        Editar_Menu_TablasDeProyecto.Enabled = False
        Actualizar_Menu_TablasDeProyecto.Enabled = True
        Eliminar_Menu_TablasDeProyecto.Enabled = True
        SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Enabled = False
        Desbloquear_Objetos_TablasDeProyecto()
        Timer_Actualizar_TablasDeProyecto()
        Timer_Eliminar_TablasDeProyecto()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_TablasDeProyecto.Click
        Control_Nulos_TablasDeProyecto()

        If ControlNulos.Text = "" Then ' Then
            SP_TablasDeProyecto_EDICION_ACTUALIZAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        End If
    End Sub
    Private Sub Eliminar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_TablasDeProyecto.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_TablasDeProyecto_EDICION_ELIMINAR()
            Cancelar_TablasDeProyecto()
            Parar_Timer_TablasDeProyecto()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_TablasDeProyecto()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_TablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_TablasDeProyecto.Click
        Cancelar_TablasDeProyecto()
    End Sub
#End Region
#Region "Eventos sobre Objetos "
    Private Sub TipoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCheckBox.CheckedChanged
        If TipoCheckBox.Checked = True Then
            TipoCheckBox.Text = "Independiente"
            TipoTextBox.Text = "True"
            TP_TablasYCampos.BackColor = Color.Transparent

        Else
            TipoCheckBox.Text = "Dependiente"
            TipoTextBox.Text = "False"
            TP_TablasYCampos.BackColor = Color.Cornsilk
        End If
    End Sub
    'Control de Nulos
    Public Sub Control_Nulos_TablasDeProyecto()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ProyectoIDTextBox.Text = ""
                MsgBox("El nombre del campo: ProyectoID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ProyectoIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreTablaTextBox.Text = ""
                MsgBox("El nombre del campo: NombreTabla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTablaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case TipoTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TipoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreTablaTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreTablaTextBox.Text = ""
                NombreTablaTextBox.Focus()
            Else
                TipoCheckBox.Enabled = True
                TipoCheckBox.Focus()
            End If
        End If
    End Sub
    Private Sub TipoCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_TablasDeProyecto.Enabled = True Then
                Actualizar_Menu_TablasDeProyecto.Enabled = True
                Eliminar_Menu_TablasDeProyecto.Enabled = True
            Else
                If TipoCheckBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    TipoCheckBox.Text = ""
                    TipoCheckBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_TablasDeProyecto.Enabled = True
                    Timer_Guardar_TablasDeProyecto()
                End If
            End If
        End If
    End Sub

    Public Sub Limpiar_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Text = "" ''
        TipoCheckBox.Text = "" ''

    End Sub
    Public Sub Desbloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = True
        TipoCheckBox.Enabled = True
        ProyectoIDTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_TablasDeProyecto()
        NombreTablaTextBox.Enabled = False
        TipoCheckBox.Enabled = False
        ProyectoIDTextBox.Enabled = False
    End Sub

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_TablasDeProyecto As Timer
    Private WithEvents Timer_Actualizar_Menu_TablasDeProyecto As Timer
    Private WithEvents Timer_Eliminar_Menu_TablasDeProyecto As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_TablasDeProyecto()
        Me.Timer_Guardar_Menu_TablasDeProyecto = New Timer
        Timer_Guardar_Menu_TablasDeProyecto.Interval = 250
        Timer_Guardar_Menu_TablasDeProyecto.Start()
    End Sub
    Private Sub Timer_Actualizar_TablasDeProyecto()
        Me.Timer_Actualizar_Menu_TablasDeProyecto = New Timer
        Timer_Actualizar_Menu_TablasDeProyecto.Interval = 500
        Timer_Actualizar_Menu_TablasDeProyecto.Start()
    End Sub
    Private Sub Timer_Eliminar_TablasDeProyecto()
        Me.Timer_Eliminar_Menu_TablasDeProyecto = New Timer
        Timer_Eliminar_Menu_TablasDeProyecto.Interval = 800
        Timer_Eliminar_Menu_TablasDeProyecto.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_TablasDeProyecto.Tick
        If Guardar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Guardar_Menu_TablasDeProyecto.BackColor = Color.Green
        Else
            Guardar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_TablasDeProyecto.Tick
        If Actualizar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Actualizar_Menu_TablasDeProyecto.BackColor = Color.Green
        Else
            Actualizar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_TablasDeProyecto.Tick
        If Eliminar_Menu_TablasDeProyecto.BackColor = Color.White Then
            Eliminar_Menu_TablasDeProyecto.BackColor = Color.Red
        Else
            Eliminar_Menu_TablasDeProyecto.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_TablasDeProyecto()
        Me.Timer_Guardar_Menu_TablasDeProyecto = New Timer
        Timer_Guardar_Menu_TablasDeProyecto.Stop()
        Guardar_Menu_TablasDeProyecto.BackColor = Color.White
        Me.Timer_Actualizar_Menu_TablasDeProyecto = New Timer
        Timer_Actualizar_Menu_TablasDeProyecto.Stop()
        Actualizar_Menu_TablasDeProyecto.BackColor = Color.White
        Me.Timer_Eliminar_Menu_TablasDeProyecto = New Timer
        Timer_Eliminar_Menu_TablasDeProyecto.Stop()
        Eliminar_Menu_TablasDeProyecto.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_TablasDeProyecto As Timer
    Dim X_TablasDeProyecto
    Private Sub Timer_Ubicar_En_Fila_TablasDeProyecto()
        Me.Timer_Ubicacion_TablasDeProyecto = New Timer
        Timer_Ubicacion_TablasDeProyecto.Interval = 100
        Timer_Ubicacion_TablasDeProyecto.Start()
    End Sub
    Private Sub SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CellMouseClick
        X_TablasDeProyecto = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_TablasDeProyecto()
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows(X_TablasDeProyecto).Selected = True
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.FirstDisplayedScrollingRowIndex = X_TablasDeProyecto
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_TablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_TablasDeProyecto.Tick
        Ubicar_En_Fila_TablasDeProyecto()
        Timer_Ubicacion_TablasDeProyecto.Stop()
    End Sub


#End Region

#End Region

#End Region

#Region "Campos"
#Region "Procedimientos"
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(ByVal TablaID As Integer)
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID,
                                                                                   New System.Nullable(Of Integer)(CType(TablaID, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region
    Sub Cancelar_CamposDeTablas()
        'Botones Del Menu
        Nuevo_Menu_CamposDeTablas.Enabled = True
        Guardar_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = True
        Actualizar_Menu_CamposDeTablas.Enabled = False
        Eliminar_Menu_CamposDeTablas.Enabled = False
        'Grid
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(TablaID)
        CargasPorProyectoID()
        Bloquear_Objetos_CamposDeTablas()
        Parar_Timer_CamposDeTablas()
        Timer_Ubicar_En_Fila_CamposDeTablas()
    End Sub
    'Insertar
    Private Sub SP_CamposDeTablas_EDICION_INSERTAR()
        Try
            Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 CboTiposDatos.Text,
                                                 NombreCampoTextBox.Text,
                                                 NombreCampoTextBox.Text)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(TablaID)
            Aviso_Acciones(10, "Guardado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Actualizar
    Private Sub SP_CamposDeTablas_EDICION_ACTUALIZAR()
        Try
            Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(CampoIDTextBox.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TablaIDTextBox.Text, Integer)),
                                                 CboTiposDatos.Text,
                                                 NombreCampoTextBox.Text,
                                                 NombreCampoTextBox.Text)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(TablaID)
            Aviso_Acciones(10, "Actualizado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Eliminar
    Private Sub SP_CamposDeTablas_EDICION_ELIMINAR()
        Try
            Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(CampoIDTextBox.Text, Long)))
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID(TablaID)
            Aviso_Acciones(10, "Eliminado...")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_CamposDeTablas.Click
        Nuevo_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = False
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = False
        Limpiar_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = True
        NombreCampoTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_CamposDeTablas.Click
        Control_Nulos_CamposDeTablas()
        If ControlNulos.Text = "" Then ' Then
            SP_CamposDeTablas_EDICION_INSERTAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_CamposDeTablas.Click
        Nuevo_Menu_CamposDeTablas.Enabled = False
        Guardar_Menu_CamposDeTablas.Enabled = False
        Editar_Menu_CamposDeTablas.Enabled = False
        Actualizar_Menu_CamposDeTablas.Enabled = True
        Eliminar_Menu_CamposDeTablas.Enabled = True
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Enabled = False
        Desbloquear_Objetos_CamposDeTablas()
        Timer_Actualizar_CamposDeTablas()
        Timer_Eliminar_CamposDeTablas()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_CamposDeTablas.Click
        Control_Nulos_CamposDeTablas()
        If ControlNulos.Text = "" Then ' Then
            SP_CamposDeTablas_EDICION_ACTUALIZAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        End If
    End Sub
    Private Sub Eliminar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_CamposDeTablas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_CamposDeTablas_EDICION_ELIMINAR()
            Cancelar_CamposDeTablas()
            Parar_Timer_CamposDeTablas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_CamposDeTablas()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_CamposDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_CamposDeTablas.Click
        Cancelar_CamposDeTablas()
    End Sub
#End Region

#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_CamposDeTablas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case TablaIDTextBox.Text = ""
                MsgBox("El nombre del campo: TablaID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TablaIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case TipoTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TipoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreCampoTextBox.Text = ""
                MsgBox("El nombre del campo: NombreCampo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreCampoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub NombreCampoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCampoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreCampoTextBox.Text = "" Then
                MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreCampoTextBox.Text = ""
                NombreCampoTextBox.Focus()
            Else
                CboTiposDatos.Enabled = True
                CboTiposDatos.Focus()
            End If
        End If
    End Sub
    Private Sub CboTiposDatos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTiposDatos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_CamposDeTablas.Enabled = True Then
                Actualizar_Menu_CamposDeTablas.Enabled = True
                Eliminar_Menu_CamposDeTablas.Enabled = True
            Else
                If CboTiposDatos.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    CboTiposDatos.Text = ""
                    CboTiposDatos.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_CamposDeTablas.Enabled = True
                    Timer_Guardar_CamposDeTablas()
                End If
            End If
        End If
    End Sub

    Public Sub Limpiar_Objetos_CamposDeTablas()
        NombreCampoTextBox.Text = "" ''
        CboTiposDatos.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = True
        CboTiposDatos.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_CamposDeTablas()
        NombreCampoTextBox.Enabled = False
        CboTiposDatos.Enabled = False
    End Sub
    'Asigna el valor guardado al combo
    Private Sub TipoCampoDesdeTabla_TextChanged(sender As Object, e As EventArgs) Handles TipoCampoDesdeTabla.TextChanged
        CboTiposDatos.Text = TipoCampoDesdeTabla.Text
    End Sub

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_CamposDeTablas As Timer
    Private WithEvents Timer_Actualizar_Menu_CamposDeTablas As Timer
    Private WithEvents Timer_Eliminar_Menu_CamposDeTablas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_CamposDeTablas()
        Me.Timer_Guardar_Menu_CamposDeTablas = New Timer
        Timer_Guardar_Menu_CamposDeTablas.Interval = 250
        Timer_Guardar_Menu_CamposDeTablas.Start()
    End Sub
    Private Sub Timer_Actualizar_CamposDeTablas()
        Me.Timer_Actualizar_Menu_CamposDeTablas = New Timer
        Timer_Actualizar_Menu_CamposDeTablas.Interval = 500
        Timer_Actualizar_Menu_CamposDeTablas.Start()
    End Sub
    Private Sub Timer_Eliminar_CamposDeTablas()
        Me.Timer_Eliminar_Menu_CamposDeTablas = New Timer
        Timer_Eliminar_Menu_CamposDeTablas.Interval = 800
        Timer_Eliminar_Menu_CamposDeTablas.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_CamposDeTablas.Tick
        If Guardar_Menu_CamposDeTablas.BackColor = Color.White Then
            Guardar_Menu_CamposDeTablas.BackColor = Color.Green
        Else
            Guardar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_CamposDeTablas.Tick
        If Actualizar_Menu_CamposDeTablas.BackColor = Color.White Then
            Actualizar_Menu_CamposDeTablas.BackColor = Color.Green
        Else
            Actualizar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_CamposDeTablas.Tick
        If Eliminar_Menu_CamposDeTablas.BackColor = Color.White Then
            Eliminar_Menu_CamposDeTablas.BackColor = Color.Red
        Else
            Eliminar_Menu_CamposDeTablas.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_CamposDeTablas()
        Me.Timer_Guardar_Menu_CamposDeTablas = New Timer
        Timer_Guardar_Menu_CamposDeTablas.Stop()
        Guardar_Menu_CamposDeTablas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_CamposDeTablas = New Timer
        Timer_Actualizar_Menu_CamposDeTablas.Stop()
        Actualizar_Menu_CamposDeTablas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_CamposDeTablas = New Timer
        Timer_Eliminar_Menu_CamposDeTablas.Stop()
        Eliminar_Menu_CamposDeTablas.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_CamposDeTablas As Timer
    Dim X_CamposDeTablas
    Private Sub Timer_Ubicar_En_Fila_CamposDeTablas()
        Me.Timer_Ubicacion_CamposDeTablas = New Timer
        Timer_Ubicacion_CamposDeTablas.Interval = 100
        Timer_Ubicacion_CamposDeTablas.Start()
    End Sub
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.CellMouseClick
        X_CamposDeTablas = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_CamposDeTablas()
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Rows(X_CamposDeTablas).Selected = True
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.FirstDisplayedScrollingRowIndex = X_CamposDeTablas
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_CamposDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_CamposDeTablas.Tick
        Ubicar_En_Fila_CamposDeTablas()
        Timer_Ubicacion_CamposDeTablas.Stop()
    End Sub

#End Region

#End Region

#End Region

#Region "Tablas Relacionadas"

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CellMouseDoubleClick
        ValidandoRelacion()
    End Sub
    Private Sub ValidandoRelacion()

        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI()
        If RegistroRelacionesTablasIDTextBox.Text = "" Then
            '        'TODO: Pendiente definir cuando se tenga la administracion de los tipos de datos
            If TipoCTD.Text = "numeric" Or TipoCTD.Text = "Clave - numeric (Clave)" Or TipoCTD.Text = "numeric (Relacionado)" Or TipoCTD.Text = "Relaciones - int(Relacionado)" Or TipoCTD.Text = "Relaciones - int(Rel 1-0, 1-1)" Or TipoCTD.Text = "Relaciones - int(Rel 1-0, 1-Muchos)" Then
                If TipoCTI.Text = "numeric" Or TipoCTI.Text = "Clave - numeric (Clave)" Or TipoCTI.Text = "numeric (Relacionado)" Or TipoCTD.Text = "int(Relacionado)" Or TipoCTD.Text = "Relaciones - int(Rel 1-0, 1-1)" Or TipoCTD.Text = "Relaciones - int(Rel 1-0, 1-Muchos)" Then
                    SP_RegistroRelacionesTablas_EDICION_INSERTAR()
                    MsgBox("Relacion entre las dos Tablas Creada Exitosamente", MsgBoxStyle.Information)
                    SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
                End If
            Else
                MsgBox("Los tipos de datos de los campos de esta relación no son correctos, verifica el tipo de dato", MsgBoxStyle.Exclamation)
            End If
        Else
            MsgBox("Esta Relación entre tablas ya fue creada", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_Proyecto(ByVal ProyectoID As Integer)
        Try
            Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_Proyecto,
                                                                               New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_Proyecto(ByVal ProyectoID As Integer)
        Try
            Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_Proyecto,
                                                                                       New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(ByVal TablaID As Integer)
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1, New System.Nullable(Of Integer)(CType(TablaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2(ByVal TablaID As Integer)
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2, New System.Nullable(Of Integer)(CType(TablaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI()
        Try
            Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI,
                                                                                                         New System.Nullable(Of Integer)(CType(TablaID_Depend.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(CampoID_Depend.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(TablaID_Independiente.Text, Integer)),
                                                                                                         New System.Nullable(Of Integer)(CType(CampoID_Independiente.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_EDICION_INSERTAR()
        Try
            Dim tipoidprovisional As Integer = 0
            Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_EDICION_INSERTAR,
                                                                             New System.Nullable(Of Integer)(CType(TablaID_Depend.Text, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(CampoID_Depend.Text, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(TablaID_Independiente.Text, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(CampoID_Independiente.Text, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(tipoidprovisional, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        Try
            Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD, New System.Nullable(Of Integer)(CType(TablaID_Depend.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.CellMouseDoubleClick
        SP_RegistroRelacionesTablas_EDICION_ELIMINAR()
        MsgBox("Relación Eliminada Exitosamente!!!", MsgBoxStyle.Exclamation)
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        TabPage3.BackColor = Color.Transparent
    End Sub

    Private Sub SP_RegistroRelacionesTablas_EDICION_ELIMINAR()
        Try
            Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroRelacionesTablas_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(RegistroRelacionesTablasIDEdicion.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


#End Region

#Region "Requerimientos"

#Region "Genera los requerimientos actuales del proyecto"
    Private Sub BtnListarRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnListarRequerimientos.Click
        ValidarRequerimientosAlGenerarProyecto()
    End Sub
    Public Sub ValidarRequerimientosAlGenerarProyecto()
        'Trunca la tabla de requerimientos
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATE)
        Dim ContadorRequerimientosNecesarios As Integer
        ContadorRequerimientosNecesarios = SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.Count

        While ContadorRequerimientosNecesarios > 0
            If SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count > 0 Then
                RecorreRequerimientosPorPlantilla()
            End If
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Rows.RemoveAt(0)
            ContadorRequerimientosNecesarios = ContadorRequerimientosNecesarios - 1
        End While
        'Carga de nuevo 
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO(ProyectoID)
        'Cuenta y compara los requerimientos
        Dim RequerimientosNecesarios As Integer = SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count
        Dim RequerimientosCargados = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows.Count
        'Valida para dar concepto de la variable de control de requierimientos
        If RequerimientosNecesarios = RequerimientosCargados Then
            VariableValidacionRequerimientos = True
            MsgBox("Requerimientos validados correctamente", MsgBoxStyle.Information)
        Else
            VariableValidacionRequerimientos = False
            MsgBox("Los requerimientos cargados para este proyecto no coinciden con los esperados, favor verificar", MsgBoxStyle.Exclamation)
        End If
        'Habilita o deshabilita el boton de generar
        If VariableValidacionRequerimientos = False Then
            BtnInicioGenerar.Enabled = False
        Else
            BtnInicioGenerar.Enabled = True
        End If
    End Sub
    'Recorre todos los componentes
    Public Sub RecorreRequerimientosPorPlantilla()
        Dim ContadorRequerimientoPorPlantilla As Integer
        ContadorRequerimientoPorPlantilla = SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.Count
        While ContadorRequerimientoPorPlantilla > 0
            SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTAR()
            SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Rows.RemoveAt(0)
            ContadorRequerimientoPorPlantilla = ContadorRequerimientoPorPlantilla - 1
        End While
        SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoID)
    End Sub
    'Carga los requerimientos segun el proyecto
    Private Sub SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ByVal ProyectoID As Integer)
        Try
            Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId,
                                                                                                                       New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Inserta los requerimientos en la tabla provisional
    Private Sub SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTAR()
        Try
            Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTAR,
                                                                                                    New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                                                    RequerimientoTextBox.Text,
                                                                                                    New System.Nullable(Of Integer)(CType(IDRequerimiento.Text, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Elimina los valores registrados de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_ELIMINA_RegistroValorRequerimientos_SegunID()
        Try
            Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ELIMINA_RegistroValorRequerimientos_SegunID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(ByVal PlantillaID As Integer)
        Try
            Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Carga los requerimientos segun el proyecto
    Private Sub SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ByVal ProyectoID As Integer)
        Try
            Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "Agrega valores a los requerimientos del proyecto"
    Private Sub BtnIniciaCargaRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnIniciaCargaRequerimientos.Click
        If SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count > 0 Then
            If MsgBox("Esta acción cargara de nuevo los requerimientos de este proyecto, desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SP_ELIMINA_RegistroValorRequerimientos_SegunID()
                SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ProyectoID)
                BtnListarRequerimientos.Enabled = True
                ValorRequerimiento.Text = ""
                ValorRequerimiento.Enabled = True
                ValorRequerimiento.Focus()
                BtnIniciaCargaRequerimientos.Enabled = False
            Else
                MsgBox("Se cancelo la instrucciòn", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Debera cargar primero los requerimientos actuales del proyecto, debera ejecutar la generación de codigo con el check de validar requerimientos activado", MsgBoxStyle.Information)
        End If
    End Sub

    'Guarda valor requerimiento
    'Private Sub BtnCargarRequerimiento_Click(sender As Object, e As EventArgs) Handles BtnCargarRequerimiento.Click
    '    If ValorRequerimiento.Text = "" Then
    '        MsgBox("El Requerimiento no puede ser un valor vacio... Favor verificar", MsgBoxStyle.Critical)
    '        ValorRequerimiento.Text = ""
    '        ValorRequerimiento.Focus()
    '    Else
    '        RegistrarValoresRequerimiento()
    '    End If
    'End Sub
    'Guarda valor requerimiento
    Private Sub ValorRequerimiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ValorRequerimiento.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ValorRequerimiento.Text = "" Then
                MsgBox("El Requerimiento no puede ser un valor vacio... Favor verificar", MsgBoxStyle.Critical)
                ValorRequerimiento.Text = ""
                ValorRequerimiento.Focus()
            Else
                RegistrarValoresRequerimiento()
            End If
        End If
    End Sub
    Private Sub RegistrarValoresRequerimiento()
        If ValorRequerimiento.Text = "" Then
            MsgBox("El Requerimiento no puede ser un valor vacio... Favor verificar", MsgBoxStyle.Critical)
            ValorRequerimiento.Text = ""
            ValorRequerimiento.Focus()
        Else
            ValorRequerimiento.Text = ValorRequerimiento.Text.Trim
            'Hace el registro del requerimiento
            SP_RegistroValorRequerimientos_EDICION_INSERTAR(ValorRequerimiento.Text)
            'Carga el registro en el grid
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ProyectoID)
            'Vacea la caja
            ValorRequerimiento.Text = ""
            'Bloquea la caja
            ValorRequerimiento.Enabled = False
            'Elimina la fila
            SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.RemoveAt(0)

            BtnCargarRequerimiento.Enabled = True
            'Arranca timer
            TimerRequerimientos.Start()
        End If
    End Sub
    'Inserta valores de los requerimientos de las plantillas de la tecnologia asignada al proyecto
    Private Sub SP_RegistroValorRequerimientos_EDICION_INSERTAR(ByVal Valor As String)

        Try

            If Valor <> "" Then
                Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_EDICION_INSERTAR,
                                                                               New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                                               Label16.Text,
                                                                               Valor)
            Else
                MsgBox("El Requerimiento no puede ser un valor vacio... Favor verificar", MsgBoxStyle.Critical)
                ValorRequerimiento.Text = ""
                ValorRequerimiento.Focus()
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub TimerRequerimientos_Tick(sender As Object, e As EventArgs) Handles TimerRequerimientos.Tick
        Try
            If SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count > 0 Then
                ValorRequerimiento.Enabled = True
                BtnCargarRequerimiento.Enabled = True
                ValorRequerimiento.Focus()
                TimerRequerimientos.Stop()
            Else
                TimerRequerimientos.Stop()
                SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoID)
                ValorRequerimiento.Text = ""
                ValorRequerimiento.Enabled = False
                BtnCargarRequerimiento.Enabled = False
                MsgBox("Valores de Requerimientos cargados Exitosamente!!!", MsgBoxStyle.Information)
                SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoID)
                BtnCargarRequerimiento.Enabled = False
                BtnIniciaCargaRequerimientos.Enabled = True
                Cancelar_RegistroValorRequerimientos()
            End If
        Catch ex As Exception

        End Try
    End Sub





#Region "Procedimientos"
    Sub Cancelar_RegistroValorRequerimientos()
        'Botones Del Menu
        Editar_Menu_RegistroValorRequerimientos.Enabled = True
        Actualizar_Menu_RegistroValorRequerimientos.Enabled = False
        BtnIniciaCargaRequerimientos.Enabled = True
        'Eliminar_Menu_RegistroValorRequerimientos.Enabled = False
        'Grid
        SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ProyectoID)
        Bloquear_Objetos_RegistroValorRequerimientos()
        Parar_Timer_RegistroValorRequerimientos()
        Timer_Ubicar_En_Fila_RegistroValorRequerimientos()
    End Sub
    'Actualizar
    Private Sub SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR()
        Try
            Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Long)(CType(RegistroValorRequerimientoIDTextBox.Text, Long)),
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 Label16.Text,
                                                 ValorRequerimiento.Text)
            SP_RegistroValorRequerimientos_SEGUN_ProyectoID(ProyectoID)
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

    'Editar
    Private Sub Editar_Menu_RegistroValorRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_RegistroValorRequerimientos.Click
        Editar_Menu_RegistroValorRequerimientos.Enabled = False
        Actualizar_Menu_RegistroValorRequerimientos.Enabled = True
        SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Enabled = False
        Desbloquear_Objetos_RegistroValorRequerimientos()
        ValorRequerimiento.Focus()
        Timer_Actualizar_RegistroValorRequerimientos()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_RegistroValorRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_RegistroValorRequerimientos.Click
        Control_Nulos_RegistroValorRequerimientos()
        If ControlNulos.Text = "" Then ' Then
            SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR()
            Cancelar_RegistroValorRequerimientos()
            Parar_Timer_RegistroValorRequerimientos()
        End If
    End Sub
    Private Sub Eliminar_Menu_RegistroValorRequerimientos_Click(sender As Object, e As EventArgs)
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Cancelar_RegistroValorRequerimientos()
            Parar_Timer_Proyectos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Proyectos()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_RegistroValorRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_RegistroValorRequerimientos.Click
        Cancelar_RegistroValorRequerimientos()
    End Sub
    'Control de Nulos
    Public Sub Control_Nulos_RegistroValorRequerimientos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ProyectoIDTextBox.Text = ""
                MsgBox("El nombre del campo: ProyectoID; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ProyectoIDTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ValorRequerimiento.Text = ""
                MsgBox("El nombre del campo: Valor Requerimiento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ValorRequerimiento.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ValorRequerimiento.Text = ""
                MsgBox("El nombre del campo: Valor Requerimiento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ValorRequerimiento.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    Public Sub Limpiar_Objetos_RegistroValorRequerimientos()
        ValorRequerimiento.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_RegistroValorRequerimientos()
        ValorRequerimiento.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_RegistroValorRequerimientos()
        ValorRequerimiento.Enabled = False
    End Sub
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_RegistroValorRequerimientos As Timer
    Private WithEvents Timer_Actualizar_Menu_RegistroValorRequerimientos As Timer
    Private WithEvents Timer_Eliminar_Menu_RegistroValorRequerimientos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_RegistroValorRequerimientos()
        Me.Timer_Guardar_Menu_RegistroValorRequerimientos = New Timer
        Timer_Guardar_Menu_RegistroValorRequerimientos.Interval = 250
        Timer_Guardar_Menu_RegistroValorRequerimientos.Start()
    End Sub
    Private Sub Timer_Actualizar_RegistroValorRequerimientos()
        Me.Timer_Actualizar_Menu_RegistroValorRequerimientos = New Timer
        Timer_Actualizar_Menu_RegistroValorRequerimientos.Interval = 500
        Timer_Actualizar_Menu_RegistroValorRequerimientos.Start()
    End Sub
    Private Sub Timer_Actualizar_Menu_RegistroValorRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_RegistroValorRequerimientos.Tick
        If Actualizar_Menu_RegistroValorRequerimientos.BackColor = Color.White Then
            Actualizar_Menu_RegistroValorRequerimientos.BackColor = Color.Green
        Else
            Actualizar_Menu_RegistroValorRequerimientos.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_RegistroValorRequerimientos()
        Me.Timer_Guardar_Menu_RegistroValorRequerimientos = New Timer
        Timer_Guardar_Menu_RegistroValorRequerimientos.Stop()
        Me.Timer_Actualizar_Menu_RegistroValorRequerimientos = New Timer
        Timer_Actualizar_Menu_RegistroValorRequerimientos.Stop()
        Actualizar_Menu_RegistroValorRequerimientos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_RegistroValorRequerimientos = New Timer
        Timer_Eliminar_Menu_RegistroValorRequerimientos.Stop()
        'Eliminar_Menu_RegistroValorRequerimientos.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_RegistroValorRequerimientos As Timer
    Dim X_RegistroValorRequerimientos
    Private Sub Timer_Ubicar_En_Fila_RegistroValorRequerimientos()
        Me.Timer_Ubicacion_RegistroValorRequerimientos = New Timer
        Timer_Ubicacion_RegistroValorRequerimientos.Interval = 100
        Timer_Ubicacion_RegistroValorRequerimientos.Start()
    End Sub
    Private Sub SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CellMouseClick
        X_RegistroValorRequerimientos = SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_RegistroValorRequerimientos()
        Try
            Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Rows(X_RegistroValorRequerimientos).Selected = True
            Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.FirstDisplayedScrollingRowIndex = X_RegistroValorRequerimientos
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_RegistroValorRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_RegistroValorRequerimientos.Tick
        Ubicar_En_Fila_RegistroValorRequerimientos()
        Timer_Ubicacion_RegistroValorRequerimientos.Stop()
    End Sub

    Private Sub BtnLimpiarValoresRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnLimpiarValoresRequerimientos.Click
        If MsgBox("Esta acción eliminara todos los valores registrados", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_ELIMINA_RegistroValorRequerimientos_SegunID()
            Cancelar_RegistroValorRequerimientos()
        Else
            MsgBox("Se canceló la instrucción", MsgBoxStyle.Information)
        End If
    End Sub



#End Region

#End Region
#End Region

#Region "Tratamiento de Texto"

#Region "Limpiar Codigo Generado"
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CodigoGeneradoTextBox.Text = ""
        SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
    End Sub
    Private Sub SP_Proyectos_EDICION_ACTUALIZAR_CodigoRemplazado()
        Try
            Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Proyectos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)),
                                                 NombreProyectoTextBox.Text,
                                                 CodigoGeneradoTextBox.Text,
                                                 DescripcionTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Copiar Codigo Generado"
    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If CodigoGeneradoTextBox.Text <> "" Then
            Clipboard.SetText(CodigoGeneradoTextBox.Text)
        End If
    End Sub
#End Region

#Region "Tratamiento de Codigo"
    Private Sub BtnInicioGenerar_Click(sender As Object, e As EventArgs) Handles BtnInicioGenerar.Click
        If ChkCreaCarpetasYArchivos.Checked = True Then
            CreaCarpetasYArchivos = True
        Else
            CreaCarpetasYArchivos = False
        End If

        If ChkCreaDocumentoTecnico.Checked = True Then
            CreaDocumentoTecnico = True
        Else
            CreaDocumentoTecnico = False
        End If

        RECORRER_PLANTILLAS_CARGADAS_AL_PROYECTO(CreaDocumentoTecnico, CreaCarpetasYArchivos)

    End Sub

    Public Sub RECORRER_PLANTILLAS_CARGADAS_AL_PROYECTO(ByVal CreaDocumentoTecnico As Boolean, ByVal CreaCarpetasYArchivos As Boolean)
        'Carga las tecnologias aplicadas al proyecto seleccionadas
        SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO_ParaGenreacion(ProyectoID)
        'Inicia el contador global
        contadorTecnologiasAplicadas = DGV_PlantillasAplicadas.Rows.Count()
        'Arrranca el timer
        Timer_Genera_Archivos.Start()
    End Sub
    Private Sub Timer_Genera_Archivos_Tick(sender As Object, e As EventArgs) Handles Timer_Genera_Archivos.Tick
        If contadorTecnologiasAplicadas > 0 Then
            'Se ubica en la primera fila
            DGV_PlantillasAplicadas.CurrentCell = DGV_PlantillasAplicadas.Rows(0).Cells(0)
            GenerarCodigo(CreaDocumentoTecnico, CreaCarpetasYArchivos)
            'GENERAR_CODIGO_PLE(CreaDocumentoTecnico, CreaCarpetasYArchivos)

            DGV_PlantillasAplicadas.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        Else
            Timer_Genera_Archivos.Stop()
            SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO_ParaGenreacion(ProyectoID)
        End If
    End Sub



    Private Sub GenerarCodigo(ByVal CreaDocumentoTecnico As Boolean, ByVal CreaCarpetasYArchivos As Boolean)
        If DGV_ComponentesGeneracion.Rows.Count > 0 Then
            'Busca si existe por lo menos un componente que indique que es por tabla
            PorTablas = False
            EsBase = False
            BuscaSiExisteComponenteAplicadoATablas()
            BuscaSiExisteComponenteQueSeaBase()
            If PorTablas = True Then
                TratamientoPorTablas(EsBase, CreaDocumentoTecnico, CreaCarpetasYArchivos)
            Else
                TratamientoNormal(EsBase, CreaDocumentoTecnico, CreaCarpetasYArchivos)
            End If
        End If
    End Sub


    Public Sub TratamientoNormal(ByVal EsBase As Boolean, ByVal CreaDocumentoTecnico As Boolean, ByVal CreaCarpetasYArchivos As Boolean)
        If EsBase = True Then
            'Asigno el valor a 
            CodigoAProcesar.Text = CodigoTextBox.Text
            CodigoAProcesar.Text = TratamientoComponenteConBase(CodigoAProcesar.Text, CreaDocumentoTecnico, CreaCarpetasYArchivos)
        Else
            'Asigno el valor a 
            CodigoAProcesar.Text = CodigoTextBox.Text
            'Tratamiento para Remplazar requerimientos
            CodigoAProcesar.Text = TratamientoRequerimientos(CodigoAProcesar.Text)
            'Tratamiento de codigo
            CodigoGeneradoTextBox.Text = CodigoGeneradoTextBox.Text & vbCrLf & CodigoAProcesar.Text
        End If
    End Sub
    Public Sub TratamientoPorTablas(ByVal EsBase As Boolean, ByVal CreaDocumentoTecnico As Boolean, ByVal CreaCarpetasYArchivos As Boolean)

    End Sub

#Region "Procesos de validacion por tablas y base"
    Private Sub BuscaSiExisteComponenteAplicadoATablas()
        Dim contador = DGV_ComponentesGeneracion.Rows.Count
        While contador > 0
            DGV_ComponentesGeneracion.CurrentCell = DGV_ComponentesGeneracion.Rows(0).Cells(0)
            'Lo unico que define es si la plantilla se aplica por tablas o no
            If XTablaCheckBox.Checked = True Then
                PorTablas = True
            End If
            DGV_ComponentesGeneracion.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        CargaComponentesPporPlantillaGeneracion(PlantillaID_Techanged_Generacion_CargaComponentes.Text)
    End Sub

    Private Sub BuscaSiExisteComponenteQueSeaBase()
        Dim contador = DGV_ComponentesGeneracion.Rows.Count
        While contador > 0
            DGV_ComponentesGeneracion.CurrentCell = DGV_ComponentesGeneracion.Rows(0).Cells(0)
            'Lo unico que define es si existe en la lista un componente Base
            If XBaseCheckBox.Checked = True Then
                EsBase = True
            End If
            DGV_ComponentesGeneracion.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        CargaComponentesPporPlantillaGeneracion(PlantillaID_Techanged_Generacion_CargaComponentes.Text)
    End Sub
#End Region

#Region "Cargas para generacion"
    '1 - CARGA LAS TECNOLOGIAS APLICADAS AL PROYECTO
    Private Sub SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO_ParaGenreacion(ByVal ProyectoID_Generacion As Integer)
        Try
            Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter.Fill(Me.DataSetAdministracion.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1, New System.Nullable(Of Integer)(CType(ProyectoID_Generacion, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '2 - Carga por texchanged los componentes de la plantilla TECHANGED
    Private Sub PlantillaID_Techanged_Generacion_CargaComponentes_TextChanged(sender As Object, e As EventArgs) Handles PlantillaID_Techanged_Generacion_CargaComponentes.TextChanged
        If PlantillaID_Techanged_Generacion_CargaComponentes.Text = "" Then
            PlantillaID_Techanged_Generacion_CargaComponentes.Text = 0
        End If
        CargaComponentesPporPlantillaGeneracion(PlantillaID_Techanged_Generacion_CargaComponentes.Text)
    End Sub
    '3 - Carga componentes por plantilla para analisis
    Private Sub CargaComponentesPporPlantillaGeneracion(ByVal PlantillaID As Integer)
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID,
                                                                                    New System.Nullable(Of Integer)(CType(PlantillaID, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '4 - Carga las tablas del proyecto en proyecto
    Private Sub SP_TablasDeProyecto_Generacion(ProyectoID)
        Try
            Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1,
                                                                                         New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga el texto para tablas que se creo para el componente
    Private Sub SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(ByVal ComponenteID As Integer)
        Try
            Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID, New System.Nullable(Of Integer)(CType(ComponenteID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Insersiones y Actualizaciones"
    'Carga los requerimientos del proyecto
    Private Sub CargaLosRequerimientosDelProyecto(ByVal ProyectoID As Integer)
        Try
            Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1, New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Inserta valor provisional
    Private Sub SP_RequerimientosValorProvisional_EDICION_INSERTAR(ByVal Texto As String)
        Try
            Me.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_EDICION_INSERTAR, Texto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga texto guardado
    Private Sub CargaTextoGuardado()
        Try
            Dim parametro As Integer = 1
            Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_, New System.Nullable(Of Integer)(CType(parametro, Integer)))
            'Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_1TableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_1, New System.Nullable(Of Integer)(CType(1, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Actualiza valor provisional
    Private Sub SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR(ByVal Texto As String)
        Try
            Dim parametro As Integer = 1
            Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(parametro, Integer)), Texto)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Realiza insercion de registro a tabla provisional para componentes con base
    Private Sub SP_ComponentesContenidoProvisional_EDICION_INSERTAR(ByVal ID_TABLA As Integer,
                                                                    ByVal PLANTILLA_ID As Integer,
                                                                    ByVal TIPO_X_BASE As Boolean,
                                                                    ByVal NOMBRE_COMPONENTE_O_REFERENCIA As String,
                                                                    ByVal ORIGINAL_MODIFICADO As String)
        Try
            Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_ComponentesContenidoProvisional_EDICION_INSERTAR,
                                                                                    New System.Nullable(Of Integer)(CType(ID_TABLA, Integer)),
                                                                                    New System.Nullable(Of Integer)(CType(PLANTILLA_ID, Integer)),
                                                                                    New System.Nullable(Of Boolean)(CType(TIPO_X_BASE, Boolean)),
                                                                                    NOMBRE_COMPONENTE_O_REFERENCIA,
                                                                                    ORIGINAL_MODIFICADO)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Agrega el archivo con contenido y ruta de la plantilla
    Public Sub GenerarArchivos(ByVal PROYECTO_ID As Integer, ByVal ARCHIVO As String, ByVal RUTA As String, ByVal CONTENIDO As String)
        SP_ProyectoCarpetasArchivos_EDICION_INSERTAR(PROYECTO_ID, ARCHIVO, RUTA, CONTENIDO)
    End Sub
    Private Sub SP_ProyectoCarpetasArchivos_EDICION_INSERTAR(ByVal PROYECTO_ID As Integer,
                                                             ByVal RUTA As String,
                                                             ByVal NOMBRE_ARCHIVO As String,
                                                             ByVal CONTENIDO_ARCHIVO As String)
        Dim SeleccionadaG As Boolean = False
        Try
            Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_EDICION_INSERTAR,
                                                                             New System.Nullable(Of Integer)(CType(PROYECTO_ID, Integer)),
                                                                             RUTA,
                                                                             NOMBRE_ARCHIVO,
                                                                             CONTENIDO_ARCHIVO,
                                                                             SeleccionadaG)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga Campos de tablas para Generacion
    Private Sub SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3(ByVal TablaIDGeneracion As Integer)
        Try
            Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter.Fill(Me.DataSetTablasYCampos.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3,
                                                                                    New System.Nullable(Of Integer)(CType(TablaIDGeneracion, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Ejecuta carga de campos para generacion
    Private Sub TablaIDGeneracion_TextChanged(sender As Object, e As EventArgs) Handles TablaIDGeneracion.TextChanged
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3(TablaIDGeneracion.Text)
    End Sub
#End Region

#Region "Tratamiento de Texto"
    Function PROCESAMIENTO_GENERAL_TEXTO(ByVal CONTENIDO_ORIGINAL As String,
                                         ByVal NOMBRE_TABLA As String,
                                         ByVal ID_TABLA As Integer,
                                         ByVal COMPONENTE_ID_TRABAJADO As Integer,
                                         ByVal PLANTILLA_ID As Integer,
                                         ByVal TIPO_X_BASE As Boolean,
                                         ByVal NOMBRE_COMPONENTE_O_REFERENCIA As String,
                                         ByVal CreaCarpetasYArchivos As Boolean,
                                         ByVal PROYECTO_ID As Integer)

        Dim ORIGINAL_MODIFICADO As String = CONTENIDO_ORIGINAL
        Dim ObjContenido As String = ""

        'TRATAMIENTO DE TABLAS

        'Remplaza el nombre de la tabla en el contenido
        If InStr(CONTENIDO_ORIGINAL, "{{{Tabla}}}") Then
            ORIGINAL_MODIFICADO = CargarTabla(CONTENIDO_ORIGINAL, NOMBRE_TABLA)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula
        If InStr(CONTENIDO_ORIGINAL, "{{{Tmin}}}") Then
            ORIGINAL_MODIFICADO = CargarTablaMinuscula(ORIGINAL_MODIFICADO, NOMBRE_TABLA)
        End If
        'Remplaza el nombre de la tabla poniendola en plorual
        If InStr(CONTENIDO_ORIGINAL, "{{{TPlur}}}") Then
            ORIGINAL_MODIFICADO = CargarTablaEnPlural(ORIGINAL_MODIFICADO, NOMBRE_TABLA)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula y en plural
        If InStr(CONTENIDO_ORIGINAL, "{{{TPlurMin}}}") Then
            ORIGINAL_MODIFICADO = CargarTablaEnPluralMinus(ORIGINAL_MODIFICADO, NOMBRE_TABLA)
        End If
        'Remplaza el nombre de la tabla poniendola en minusculas y donde encuentre una mayuscula la remplaza por un guion poniendo la letra que sigue en minuscula
        If InStr(CONTENIDO_ORIGINAL, "{{{A=>-a}}}") Then
            ORIGINAL_MODIFICADO = ConvertirMayusculasMinSeparadasPorGuion(ORIGINAL_MODIFICADO, NOMBRE_TABLA)
        End If
        'Remplaza el nombre de la tabla poniendola en
        If InStr(CONTENIDO_ORIGINAL, "{{{Tbl-Camel}}}") And ComponenteBasePorTablas = True Then
            ORIGINAL_MODIFICADO = ucaseCamelCase(ORIGINAL_MODIFICADO, NOMBRE_TABLA)
        End If

        If InStr(CONTENIDO_ORIGINAL, "{{{Tabla-G}}}") Then
            ORIGINAL_MODIFICADO = validarProcesoTablas(CONTENIDO_ORIGINAL, COMPONENTE_ID_TRABAJADO)
        End If

        'TRATAMIENTO DE CAMPOS --================================================--

        If InStr(CONTENIDO_ORIGINAL, "{{{Clave}}}") Then
            Dim Clave = GenerarClave()
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Clave}}}", Clave)
        End If


        If Not InStr(CONTENIDO_ORIGINAL, "{{{Campos}}}") Then
            Dim Campos = GenerarCampos(NOMBRE_TABLA)
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Campos}}}", Campos)
            If InStr(ORIGINAL_MODIFICADO, "{{{Tabla}}}") Then
                ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Tabla}}}", NOMBRE_TABLA)
            End If
        End If


        If Not InStr(CONTENIDO_ORIGINAL, "{{{TCampos-ID}}}") Then
            Dim Campos = GenerarCampos_Sin_ID(NOMBRE_TABLA)
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{TCampos-ID}}}", Campos)
            If InStr(ORIGINAL_MODIFICADO, "{{{Tabla}}}") Then
                ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Tabla}}}", NOMBRE_TABLA)
            End If
        End If

        If Not InStr(CONTENIDO_ORIGINAL, "{{{TCampos-R}}}") Then
            Dim Campos = GenerarCampos_Sin_Relacionados(NOMBRE_TABLA)
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{TCampos-R}}}", Campos)
            If InStr(ORIGINAL_MODIFICADO, "{{{Tabla}}}") Then
                ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Tabla}}}", NOMBRE_TABLA)
            End If
        End If


        If Not InStr(CONTENIDO_ORIGINAL, "{{{Camp-R-ID}}}") Then
            Dim Campos = GenerarCampos_Sin_RelacionadosYSinID(NOMBRE_TABLA)
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Camp-R-ID}}}", Campos)
            If InStr(ORIGINAL_MODIFICADO, "{{{Tabla}}}") Then
                ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Tabla}}}", NOMBRE_TABLA)
            End If
        End If


        If InStr(CONTENIDO_ORIGINAL, "{{{Camp-Rel}}}") Then
            Dim CamposRel = RecorreTablasRelacionadas()
            CONTENIDO_ORIGINAL = CONTENIDO_ORIGINAL.Replace("{{{Camp-Rel}}}", CamposRel)
        End If


        If InStr(CONTENIDO_ORIGINAL, "{{{Camp-Esp}}}") Then
            Dim CampoEsp = RecorrerTablaBuscandoCampoEspecial()
            ORIGINAL_MODIFICADO = ORIGINAL_MODIFICADO.Replace("{{{Camp-Esp}}}", CampoEsp)
        End If


        If TieneComponenteConBase = True Then
            ' --2.6.4.1-- INSERTA EN BASE DE DATOS LAS PARTES DEL COMPONENTE BASE
            If ComponenteBasePorTablas = False Then
                ID_TABLA = 0
            End If
            SP_ComponentesContenidoProvisional_EDICION_INSERTAR(ID_TABLA, PLANTILLA_ID, TIPO_X_BASE, NOMBRE_COMPONENTE_O_REFERENCIA, ORIGINAL_MODIFICADO)
        End If

        'CREARA ARCHIVOS Y CARPETAS 
        If CreaCarpetasYArchivos = True And TIPO_X_BASE <> True Then
            'Carga los datos de ruta de la plantilla
            SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(COMPONENTE_ID_TRABAJADO)
            'Carga la ruta de la plantilla si existe en base de datos
            If RutaGeneracion.Text <> "" Then
                'Carga lo necesario para crear el registro del archivo 
                NombreArchivoACrear = RemplazosDeTabla(NombreArchivoGeneracion.Text, NOMBRE_TABLA) & ExtensionArchivoGeneracion.Text
                RutaProcesada = TratamientoRequerimientos(RutaGeneracion.Text)
                RutaProcesada = RemplazosDeTabla(RutaProcesada, NOMBRE_TABLA)
                ORIGINAL_MODIFICADO = TratamientoRequerimientos(ORIGINAL_MODIFICADO)
                GenerarArchivos(PROYECTO_ID, NombreArchivoACrear, RutaProcesada, ORIGINAL_MODIFICADO)
            End If
        End If
        Return ORIGINAL_MODIFICADO
    End Function
#Region "Funciones de Tratamiento de Tablas"
    'Reciben el texto y buscan en el la especificacion y lo remplazan por el nombre de la tabla
    Function CargarTabla(textoBase As String, NombreTabla As String)
        Dim CodigoGenerado = textoBase.Replace("{{{Tabla}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function CargarTablaMinuscula(textoBase As String, NombreTabla As String)
        NombreTabla = LCase(NombreTabla)
        Dim CodigoGenerado = textoBase.Replace("{{{Tmin}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function CargarTablaEnPlural(textoBase As String, NombreTabla As String)
        NombreTabla = NombreTabla + "s"
        Dim CodigoGenerado = textoBase.Replace("{{{TPlur}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function CargarTablaEnPluralMinus(textoBase As String, NombreTabla As String)
        NombreTabla = NombreTabla + "s"
        NombreTabla = LCase(NombreTabla)
        Dim CodigoGenerado = textoBase.Replace("{{{TPlurMin}}}", NombreTabla)
        Return CodigoGenerado
    End Function
    Function ConvertirMayusculasMinSeparadasPorGuion(textoBase As String, NombreTabla As String)
        Dim cadena As String = NombreTabla
        Dim myChar As String = ""
        Dim fChar As String = ""
        Dim otra As String = ""
        For i = 1 To Len(cadena)
            'Evalua si es mayuscula
            If Asc(Mid(cadena, i, 1)) >= 65 And Asc(Mid(cadena, i, 1)) <= 90 Then
                myChar = cadena.Chars(i - 1)
                myChar = LCase(myChar)
                If i = 1 Then
                    fChar = fChar + myChar
                Else
                    fChar = fChar + "-" & myChar
                End If
                myChar = ""
            Else
                fChar = fChar + myChar + Mid(cadena, i, 1)
                myChar = ""
            End If
        Next
        Dim CodigoGenerado = textoBase.Replace("{{{A=>-a}}}", fChar)
        NombreTablaTextBox1.Text = NombreTablaTextBox.Text
        Return CodigoGenerado
    End Function
    Function ucaseCamelCase(textoBase As String, NombreTabla As String)
        Dim cadena As String = NombreTabla
        Dim primera As String = cadena.Substring(0, 1)
        Dim resto As String = cadena.Substring(1)
        Dim myChar As String = ""
        Dim fChar As String = ""
        Dim i As Integer = Len(cadena)
        Dim valor As Integer = Asc((cadena.Substring(0, 1)))
        If valor >= 65 And valor <= 90 Then
            primera = LCase(primera)
            primera = primera + resto
        End If
        Dim CodigoGenerado = textoBase.Replace("{{{Tbl-Camel}}}", primera)
        Return CodigoGenerado
    End Function
    Function validarProcesoTablas(ByVal Texto As String, ByVal COMPONENTE_ID As Integer)
        Dim contenido As String = ""
        Dim contadorTablas As Integer = 0
        Dim ContenidoGenerado As String = ""

        If InStr(Texto, "{{{Tabla-G}}}") Then
            'Carga el contenido que hara replace el creado para este componente
            SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(COMPONENTE_ID)
            'Carga las tablas del proyecto para generar el contenido
            SP_TablasDeProyecto_Generacion(ProyectoID)
            'Recorre Tablas
            contadorTablas = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows.Count
            While contadorTablas > 0
                SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.CurrentCell = SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows(0).Cells(0)
                contenido = contenido & vbCrLf & remplazoUnicamenteTablas(ContenidoXTablaTextBox.Text, NombreTablaTextBox1.Text)
                SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Rows.RemoveAt(0)
                contadorTablas = contadorTablas - 1
            End While
            SP_TablasDeProyecto_Generacion(ProyectoID)
            ContenidoGenerado = Texto.Replace("{{{Tabla-G}}}", contenido)
        Else
            ContenidoGenerado = Texto
        End If
        Return ContenidoGenerado
    End Function
    Function RemplazosDeTabla(ByVal Contenido As String, ByVal Tabla As String)
        Dim ContenidoGenerado As String = Contenido
        Dim ObjContenido As String = ""
        If InStr(Contenido, "{{{Tabla}}}") Then
            Contenido = Contenido.Replace("{{{Tabla}}}", Tabla)
        End If
        Return Contenido
    End Function
    Function remplazoUnicamenteTablas(ByVal Contenido As String, ByVal Tabla As String)
        Dim ContenidoGenerado As String = Contenido
        'Remplaza el nombre de la tabla en el contenido
        If InStr(Contenido, "{{{Tabla}}}") Then
            ContenidoGenerado = CargarTabla(Contenido, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula
        If InStr(Contenido, "{{{Tmin}}}") Then
            ContenidoGenerado = CargarTablaMinuscula(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en plorual
        If InStr(Contenido, "{{{TPlur}}}") Then
            ContenidoGenerado = CargarTablaEnPlural(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minuscula y en plural
        If InStr(Contenido, "{{{TPlurMin}}}") Then
            ContenidoGenerado = CargarTablaEnPluralMinus(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en minusculas y donde encuentre una mayuscula la remplaza por un guion poniendo la letra que sigue en minuscula
        If InStr(Contenido, "{{{A=>-a}}}") Then
            ContenidoGenerado = ConvertirMayusculasMinSeparadasPorGuion(ContenidoGenerado, Tabla)
        End If
        'Remplaza el nombre de la tabla poniendola en
        If InStr(Contenido, "{{{Tbl-Camel}}}") Then
            ContenidoGenerado = ucaseCamelCase(ContenidoGenerado, Tabla)
        End If
        Return ContenidoGenerado
    End Function
    Function GenerarRelacionTabla(contenido As String)
        Dim ContenidoGenerado As String = contenido
        'If InStr(ContenidoRelacionTextBox.Text, "{{{Tabla_Dep}}}") Then
        '    ContenidoGenerado = contenido.Replace("{{{Tabla_Dep}}}", TablaDependienteTextBox1.Text)
        'End If
        'If InStr(ContenidoRelacionTextBox.Text, "{{{Campo_Dep}}}") Then
        '    ContenidoGenerado = ContenidoGenerado.Replace("{{{Campo_Dep}}}", CampoDependienteTextBox1.Text)
        'End If
        'If InStr(ContenidoRelacionTextBox.Text, "{{{Tabla_Ind}}}") Then
        '    ContenidoGenerado = ContenidoGenerado.Replace("{{{Tabla_Ind}}}", TablaIndependienteTextBox1.Text)
        'End If
        'If InStr(ContenidoRelacionTextBox.Text, "{{{Campo_Ind}}}") Then
        '    ContenidoGenerado = ContenidoGenerado.Replace("{{{Campo_Ind}}}", CampoIndependienteTextBox1.Text)
        'End If
        Return ContenidoGenerado
    End Function
#End Region

#Region "Funciones de Tratamiento de Campos"
    Function GenerarClave()
        Dim Clave = CapturaClavePrincipal()
        Return Clave
    End Function
    Function CapturaClavePrincipal()
        'Se ubica en la primera fila
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
        Dim Clave = NombreCampoGeneracion.Text
        Return Clave
    End Function
    Function GenerarCampos(ByVal Tabla As String)
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            Campos = Campos + TratamientoCampos(NombreCampoGeneracion.Text, contadorCampos, Tabla) & vbCrLf
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
            contadorCampos = contadorCampos - 1
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(ProyectoID)
        Return Campos
    End Function
    Function GenerarCampos_Sin_ID(ByVal Tabla As String)
        If SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count > 0 Then
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
        End If
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            Campos = Campos + TratamientoCampos(NombreCampoGeneracion.Text, contadorCampos, Tabla) & vbCrLf
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
            contadorCampos = contadorCampos - 1
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(TablaID)
        Return Campos
    End Function
    Function GenerarCampos_Sin_Relacionados(ByRef Tabla As String)
        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            If TipoGeneracion.Text = "numeric (Relacionado)" Or TipoGeneracion.Text = "Relaciones - int(Relacionado)" Or TipoGeneracion.Text = "Relaciones - int(Relacionado)" Or TipoGeneracion.Text = "Relaciones - int(Rel 1-0, 1-1)" Or TipoGeneracion.Text = "Relaciones - int(Rel 1-0, 1-Muchos)" Then

                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            Else
                Campos = Campos + TratamientoCampos(NombreCampoGeneracion.Text, contadorCampos, Tabla) & vbCrLf
                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            End If
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(TablaID)
        Return Campos
    End Function
    Function GenerarCampos_Sin_RelacionadosYSinID(ByRef Tabla As String)

        If SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count > 0 Then
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
        End If

        Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        While contadorCampos > 0
            'Se ubica en la primera fila
            SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
            If TipoGeneracion.Text = "numeric (Relacionado)" Or TipoGeneracion.Text = "Relaciones - int(Relacionado)" Or TipoGeneracion.Text = "Relaciones - int(Rel 1-0, 1-1)" Or TipoGeneracion.Text = "Relaciones - int(Rel 1-0, 1-Muchos)" Then
                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            Else
                Campos = Campos + TratamientoCampos(NombreCampoGeneracion.Text, contadorCampos, Tabla) & vbCrLf
                SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
                contadorCampos = contadorCampos - 1
            End If
        End While
        SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(TablaID)
        Return Campos
    End Function
    Function RecorreTablasRelacionadas()
        Dim CamposRelacionados As String = ""
        Dim contadorTablasRelacionadas = SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTablasRelacionadas > 0
            'Se ubica en la primera fila
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.CurrentCell = SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows(0).Cells(0)
            CamposRelacionados = CamposRelacionados & GenerarRelacionTabla(ContenidoRelacionTextBox.Text) & vbCrLf
            SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Rows.RemoveAt(0)
            contadorTablasRelacionadas = contadorTablasRelacionadas - 1
        End While
        'Vuelve y carga las tecnologias aplicadas
        SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD()
        Return CamposRelacionados
    End Function
    'Recorrera la tabla buscando el campo que se asigno como especial, si lo encuentra devolvera en donde esta la etiqueta triple llave lo que tenga de contenido
    Function RecorrerTablaBuscandoCampoEspecial()
        'TODO
        'Dim contadorCampos = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count
        Dim Campos As String = ""
        'While contadorCampos > 0
        '    'Se ubica en la primera fila
        '    SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.CurrentCell = SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows(0).Cells(0)
        '    SP_CampoEspecial_BUSQUEDA_SEGUN_Tipo_Componente(TipoGeneracion.Text, ComponenteIDTextBox.Text)
        '    If ContenidoTextBoxTipoCampoEspecial.Text <> "" Then

        '        'Campos = Campos & " Contenido Especial => " & ContenidoTextBoxTipoCampoEspecial.Text & TipoTextBox1.Text & " Componente => " & ComponenteIDTextBox.Text & " Campo => " & NombreCampoTextBox1.Text & " Tabla => " & NombreTablaTextBox2.Text & vbCrLf

        '        ContenidoTextBoxTipoCampoEspecial.Text = ContenidoTextBoxTipoCampoEspecial.Text.Replace("Campo", NombreCampoTextBox1.Text)

        '        ContenidoTextBoxTipoCampoEspecial.Text = remplazoUnicamenteTablas(ContenidoTextBoxTipoCampoEspecial.Text, NombreTablaTextBox2.Text)

        '        ContenidoTextBoxTipoCampoEspecial.Text = RemplazaRequerimientos(ContenidoTextBoxTipoCampoEspecial.Text)

        '        Campos = ContenidoTextBoxTipoCampoEspecial.Text

        '    End If
        '    SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.RemoveAt(0)
        '    contadorCampos = contadorCampos - 1
        'End While
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1(TablaID)
        Return Campos
    End Function
    Function TratamientoCampos(campoConComplemento As String, contadorCampos As Integer, ByVal Tabla As String) As String
        Dim Campo As String = "Campo"
        Dim Objeto As String = ""

        If MultiReplaceTextBox.Text = "" Then
            'Poner Prefijo
            If PrefijoTextBox.Text <> "" Then
                Campo = PrefijoTextBox.Text & Campo
            End If
            'Poner Sufijo con separador
            If contadorCampos > 1 Then
                Campo = Campo & SufijoTextBox.Text & SeparadorCamposTextBox.Text
            Else
                Campo = Campo & SufijoTextBox.Text
            End If
            'Poner Superior
            If SuperiorTextBox.Text <> "" Then
                Campo = SuperiorTextBox.Text & vbCrLf & Campo
            End If
            'Poner Inferior
            If InferiorTextBox.Text <> "" Then
                Campo = Campo & vbCrLf & InferiorTextBox.Text
            End If
            Objeto = Campo.Replace("Campo", campoConComplemento)
        Else
            Objeto = MultiReplaceTextBox.Text.Replace("Campo", campoConComplemento)
            Objeto = remplazoUnicamenteTablas(Objeto, Tabla)
            If SeparadorCamposTextBox.Text <> "" And SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Rows.Count <> 1 Then
                Objeto = Objeto & SeparadorCamposTextBox.Text
            Else
                Objeto = Objeto
            End If
        End If
        Return Objeto
    End Function

#End Region

#Region "Funcion de tratamiento de Requerimientos"
    'Registra valores de requerimientos
    Function TratamientoRequerimientos(ByVal Texto As String)
        'Carga los requerimientos del proyecto
        CargaLosRequerimientosDelProyecto(ProyectoID)
        Dim contenido As String = ""
        'Inserta en provisional
        SP_RequerimientosValorProvisional_EDICION_INSERTAR(Texto)
        'Cuenta los requerimientos del proyecto
        Dim contadorRequerimientos = DGV_RequerimientosProyecto.Rows.Count
        'En caso de que no se hallan agregado requerimientos
        If contadorRequerimientos = 0 Then
            contenido = Texto
        Else
            While contadorRequerimientos > 0
                'Se ubica en la primera fila
                DGV_RequerimientosProyecto.CurrentCell = DGV_RequerimientosProyecto.Rows(0).Cells(0)
                'Carga lo que hay en provisional
                CargaTextoGuardado()
                contenido = TextoTextBox.Text.Replace(RequerimientoGeneracion.Text, ValorRequerimientoGeneracion.Text)
                'Actualiza valor en provisional
                SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR(contenido)
                DGV_RequerimientosProyecto.Rows.RemoveAt(0)
                contadorRequerimientos = contadorRequerimientos - 1
            End While
            CargaLosRequerimientosDelProyecto(ProyectoID)
            'Trunca Tabla del provisional
            Me.SP_RequerimientosValorProvisional_TRUNCATableAdapter.Fill(Me.DataSetTablasYCampos.SP_RequerimientosValorProvisional_TRUNCA)
        End If
        Return contenido
    End Function
#End Region






#End Region

    Function TratamientoComponenteConBase(ByVal Texto As String, ByVal CreaDocumentoTecnico As Boolean, ByVal CreaCarpetasYArchivos As Boolean)
        Dim contenido As String = ""
        Dim contador As Integer = 0
        contador = DGV_ComponentesGeneracion.Rows.Count
        While contador > 0
            'Se ubica en la primera fila
            DGV_ComponentesGeneracion.CurrentCell = DGV_ComponentesGeneracion.Rows(0).Cells(0)

            DGV_ComponentesGeneracion.Rows.RemoveAt(0)
            contador = contador - 1
        End While
        'Carga de nuevo el componente
        CargaComponentesPporPlantillaGeneracion(PlantillaID_Techanged_Generacion_CargaComponentes.Text)
        Return contenido
    End Function


    Private Sub SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID(ByVal ComponenteID As Integer)
        Try
            Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.Fill(Me.DataSetAdministracion.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID, New System.Nullable(Of Integer)(CType(ComponenteID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID(ByVal ComponenteID As Integer)
        'Esta consulta era por plantilla y cambio a componente
        Try
            Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID, New System.Nullable(Of Integer)(CType(ComponenteID, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub






#End Region

#End Region

End Class