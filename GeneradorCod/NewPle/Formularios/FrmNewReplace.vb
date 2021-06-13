Imports System.IO
Imports System.Text
Public Class FrmNewReplace

#Region "Load Formulario"
    Private Sub FrmNewReplace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Metodo_Aviso_Acciones(2, "Bienvenido a la Creación de PleProyectos")
        Me.PleProyectosViewTableAdapter.Fill(Me.DataSetMaestros.PleProyectosView)
        Me.PleEmpresaViewTableAdapter.Fill(Me.DataSetMaestros.PleEmpresaView)
        Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
        Me.PleTecnologiasTableAdapter.Fill(Me.DataSetMaestros.PleTecnologias)
        Me.PleClienteTableAdapter.Fill(Me.DataSetMaestros.PleCliente)


        CodigoGeneradoRichTextBox.Dock = DockStyle.Fill
        CodigoGeneradoRichTextBox.BringToFront()
        BtnCodigo.BackColor = Color.YellowGreen

        tmMOSTRARPanelV01Proyectos.Enabled = True
        BtnVerProyectos.BackColor = Color.LawnGreen

        Cancelar_PleProyectos()
        Cancelar_PleTablasDeProyecto()
        Cancelar_PleCampDeTablas()
        Cancelar_PleRequerimientosCompRegistro()
        Cancelar_PleRutasArchivosTecnologiasRegistro()
        'Panel01VProyectos 460
        'Panel02Tecnologias 446
        'PanelTablas 364
        'PanelV04Campos 396
        'PanelV5RelacionesTablas 400
        'vbCrLf
    End Sub
#End Region
    '--========================CRUDS================================--

#Region "TODO PleProyectos"

    '--==============================================================--

#Region "Mensajeria"
    'Mensajeria
    '--==============================================================--
    Public WithEvents Timer_Aviso As Timer
    Dim TiempoDuracionAviso As Integer = 0
    Dim TiempoPararAviso As Integer = 0
    Public Sub Metodo_Aviso_Acciones(TiempoDuracion As Integer, ByVal InformacionMensaje As String)
        Me.Timer_Aviso = New Timer
        Timer_Aviso.Interval = 1000
        Me.Timer_Aviso.Start()
        TiempoPararAviso = TiempoDuracion
        LblInforme.Visible = True
        LblInforme.Dock = DockStyle.Top
        LblInforme.Width = 58
        LblInforme.BringToFront()
        LblInforme.Text = InformacionMensaje
    End Sub
    Private Sub Timer_Aviso_Tick(sender As Object, e As EventArgs) Handles Timer_Aviso.Tick
        TiempoDuracionAviso = TiempoDuracionAviso + 1
        If TiempoDuracionAviso = TiempoPararAviso Then
            Timer_Aviso.Stop()
            TiempoDuracionAviso = 0
            TiempoPararAviso = 0
            LblInforme.Text = "..."
            LblInforme.Visible = False
            LblInforme.BringToFront()
        End If
    End Sub
    Private Sub LblInforme_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LblInforme.MouseDoubleClick
        LblInforme.Text = "..."
        LblInforme.Visible = False
    End Sub
#End Region

    '--==============================================================--

    Sub Cancelar_PleProyectos()
        'Botones Del Menu
        Nuevo_Menu_PleProyectos.Enabled = True
        Guardar_Menu_PleProyectos.Enabled = False
        Editar_Menu_PleProyectos.Enabled = True
        Actualizar_Menu_PleProyectos.Enabled = False
        Eliminar_Menu_PleProyectos.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleProyectosViewDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleProyectosViewTableAdapter.Fill(Me.DataSetMaestros.PleProyectosView)
        Bloquear_Objetos_PleProyectos()
        Parar_Timer_PleProyectos()
        Timer_Ubicar_En_Fila_PleProyectos()
    End Sub

    '--=== INSERTAR 

    'Insertar PleProyectos
    Private Sub SP_PleProyectos_EDICION_INSERTAR(EmpresaId As Integer,
NombreProyecto As String,
ClienteId As Integer,
Descripcion As String,
CodigoGenerado As String,
TiempoEstimado As Integer
)
        Try
            Me.SP_PleProyectos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectos_EDICION_INSERTAR,
                                                            New System.Nullable(Of Integer)(CType(EmpresaId, Integer)),
                                                            NombreProyecto,
                                                            New System.Nullable(Of Integer)(CType(ClienteId, Integer)),
                                                            Descripcion,
                                                            CodigoGenerado,
                                                            New System.Nullable(Of Integer)(CType(TiempoEstimado, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleProyectos")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    '--===  ACTUALIZAR 

    'Actualizar PleProyectos
    Private Sub SP_PleProyectos_EDICION_ACTUALIZAR(ProyectoId As Integer,
EmpresaId As Integer,
NombreProyecto As String,
ClienteId As Integer,
Descripcion As String,
CodigoGenerado As String,
TiempoEstimado As Integer
)

        Try
            Me.SP_PleProyectos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectos_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(EmpresaId, Integer)),
                                                            NombreProyecto,
                                                            New System.Nullable(Of Integer)(CType(ClienteId, Integer)),
                                                            Descripcion,
                                                            CodigoGenerado,
                                                            New System.Nullable(Of Integer)(CType(TiempoEstimado, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleProyectos")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGenerado(CodigoGenerado As String, ProyectoId As Integer)
        Try
            Me.SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGeneradoTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGenerado,
                                                                                  New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                  CodigoGenerado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    '--==============================================================--

    'Eliminar
    Private Sub SP_PleProyectos_EDICION_ELIMINAR(ProyectoId As Integer)
        Try
            Me.SP_PleProyectos_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectos_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleProyectos Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleProyectos()
        CboEmpresaIdTextBox.Enabled = False
        NombreProyectoTextBox.Enabled = False
        DescripcionTextBox.Enabled = False
        CboClienteIdTextBox.Enabled = False
        CostoTextBox.Enabled = False
        TiempoEstimadoTextBox.Enabled = False
    End Sub
    Public Sub Desbloquear_Objetos_PleProyectos()
        CboEmpresaIdTextBox.Enabled = True
        NombreProyectoTextBox.Enabled = True
        DescripcionTextBox.Enabled = True
        CboClienteIdTextBox.Enabled = True
    End Sub
    Public Sub Limpiar_Objetos_PleProyectos()
        CboEmpresaIdTextBox.Text = ""
        NombreProyectoTextBox.Text = ""
        DescripcionTextBox.Text = ""
        CboClienteIdTextBox.Text = ""
        CodigoGeneradoRichTextBox.Text = ""
        CostoTextBox.Text = ""
        TiempoEstimadoTextBox.Text = 0
    End Sub


    '--==============================================================--

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleProyectos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case CboEmpresaIdTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo Empresa; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboEmpresaIdTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case NombreProyectoTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre del proyecto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreProyectoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case CboClienteIdTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo cliente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboClienteIdTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case DescripcionTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion del proyecto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case TiempoEstimadoTextBox.Text = ""
                MsgBox("El nombre del campo: Tiempo estimado del proyecto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TiempoEstimadoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub


    '--==============================================================--

    '--===  BOTONES  DE EJECUCIÓN

    Private Sub Nuevo_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleProyectos.Click
        Nuevo_Menu_PleProyectos.Enabled = False
        Editar_Menu_PleProyectos.Enabled = False
        ValidarCierre.Text = 1
        PleProyectosViewDataGridView.Enabled = False
        Limpiar_Objetos_PleProyectos()
        CboEmpresaIdTextBox.Enabled = True
        CboEmpresaIdTextBox.Focus()
    End Sub

    '--==============================================================--

    '--=== GUARDAR  
    'Guardar
    Private Sub Guardar_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleProyectos.Click
        Control_Nulos_PleProyectos()
        If ControlNulos.Text = "" Then
            SP_PleProyectos_EDICION_INSERTAR(EmpresaIdTextBoxBase.Text,
        NombreProyectoTextBox.Text,
        ClienteIdTextBoxBase.Text,
        DescripcionTextBox.Text,
        CodigoGeneradoRichTextBox.Text,
        TiempoEstimadoTextBox.Text
)
            Cancelar_PleProyectos()
            Parar_Timer_PleProyectos()
        End If
    End Sub


    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleProyectos.Click
        Nuevo_Menu_PleProyectos.Enabled = False
        Guardar_Menu_PleProyectos.Enabled = False
        Editar_Menu_PleProyectos.Enabled = False
        Actualizar_Menu_PleProyectos.Enabled = True
        Eliminar_Menu_PleProyectos.Enabled = True
        PleProyectosViewDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleProyectos()
        Timer_Actualizar_PleProyectos()
        Timer_Eliminar_PleProyectos()
    End Sub

    '--==============================================================--

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleProyectos.Click
        Control_Nulos_PleProyectos()

        If ControlNulos.Text = "" Then
            SP_PleProyectos_EDICION_ACTUALIZAR(ProyectoIdTextBoxBase.Text,
        EmpresaIdTextBoxBase.Text,
        NombreProyectoTextBox.Text,
        ClienteIdTextBoxBase.Text,
        DescripcionTextBox.Text,
        CodigoGeneradoRichTextBox.Text,
        TiempoEstimadoTextBox.Text
)
            Cancelar_PleProyectos()
            Parar_Timer_PleProyectos()
        End If
    End Sub




    '--==============================================================--

    Private Sub Eliminar_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleProyectos.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleProyectos_EDICION_ELIMINAR(ProyectoIdTextBoxBase.Text)
            Cancelar_PleProyectos()
            Parar_Timer_PleProyectos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleProyectos()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleProyectos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleProyectos.Click
        Cancelar_PleProyectos()
    End Sub

    '--==============================================================--

    'Salir
    Private Sub Salir_Menu_PleProyectos_Click(sender As Object, e As EventArgs) Handles Salir_Menu_PleProyectos.Click
        If ValidarCierre.Text = "" Then
            Me.Close()
        Else
            Metodo_Aviso_Acciones(3, "Accion en proceso")
        End If
    End Sub

    '--==============================================================--
    'Navegacion

    '--==============================================================--

    Private Sub CboEmpresaIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboEmpresaIdTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboEmpresaIdTextBox.Text = "" Then
                MsgBox("El Dato Empresa es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboEmpresaIdTextBox.Text = ""
                CboEmpresaIdTextBox.Focus()
            Else
                NombreProyectoTextBox.Enabled = True
                NombreProyectoTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub NombreProyectoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreProyectoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreProyectoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                NombreProyectoTextBox.Text = ""
                NombreProyectoTextBox.Focus()
            Else
                CboClienteIdTextBox.Enabled = True
                CboClienteIdTextBox.Focus()
            End If
        End If
        ' Primera en mayuscula
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

    Private Sub CboClienteIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboClienteIdTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboClienteIdTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboClienteIdTextBox.Text = ""
                CboClienteIdTextBox.Focus()
            Else
                DescripcionTextBox.Enabled = True
                DescripcionTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    '--==============================================================--

    Private Sub DescripcionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleProyectos.Enabled = True Then
                Actualizar_Menu_PleProyectos.Enabled = True
                Eliminar_Menu_PleProyectos.Enabled = True
            Else
                If DescripcionTextBox.Text = "" Then
                    MsgBox("CodigoGenerado Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    DescripcionTextBox.Text = ""
                    DescripcionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleProyectos.Enabled = True
                    Timer_Guardar_PleProyectos()
                End If
            End If
        End If
        ' Primera en mayuscula
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (DescripcionTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(DescripcionTextBox.Text, 1)
            Caracter = UCase(Caracter)
            DescripcionTextBox.Text = ""
            DescripcionTextBox.Text = Caracter
            DescripcionTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(DescripcionTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(DescripcionTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(DescripcionTextBox.Text, 1)
            Caracter = UCase(Caracter)
            DescripcionTextBox.Text = ""
            DescripcionTextBox.Text = Temp + Caracter
            DescripcionTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    '--==============================================================--
    Private Sub SP_PleProyectosView_SEGUN_EmpresaId(EmpresaId As Integer)
        Try
            Me.SP_PleProyectosView_SEGUN_EmpresaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosView_SEGUN_EmpresaId,
                                                                    New System.Nullable(Of Integer)(CType(EmpresaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    '--=== ESPECIALES

    'Elementos de transferencia de datos entre combos y textbox --==================================

    Private Sub EmpresaIdTextBoxTabla_TextChanged(sender As Object, e As EventArgs) Handles EmpresaIdTextBoxTabla.TextChanged
        EmpresaIdTextBoxBase.Text = EmpresaIdTextBoxTabla.Text
    End Sub

    Private Sub CboEmpresaIdTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEmpresaIdTextBox.SelectedIndexChanged
        If EmpresaIdTextBoxBase.Text = "" Then
            EmpresaIdTextBoxBase.Text = EmpresaIdTextBoxTabla.Text
        End If
    End Sub

    Private Sub NombreEmpresaIdBase_TextChanged(sender As Object, e As EventArgs) Handles NombreEmpresaIdBase.TextChanged
        CboEmpresaIdTextBox.Text = NombreEmpresaIdBase.Text
    End Sub
    '--========================================================================


    'Elementos de transferencia de datos entre combos y textbox --==================================


    Private Sub ClienteIdTextBoxDeTabla_TextChanged(sender As Object, e As EventArgs) Handles ClienteIdTextBoxDeTabla.TextChanged
        ClienteIdTextBoxBase.Text = ClienteIdTextBoxDeTabla.Text
    End Sub

    Private Sub CboClienteIdTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboClienteIdTextBox.SelectedIndexChanged
        If ClienteIdTextBoxBase.Text = "" Then
            ClienteIdTextBoxBase.Text = ClienteIdTextBoxDeTabla.Text
        End If
    End Sub

    Private Sub NombreClienteTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreClienteTextBox.TextChanged
        CboClienteIdTextBox.Text = NombreClienteTextBox.Text
    End Sub
    '--========================================================================






    '--========================================================================
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleProyectos As Timer
    Private WithEvents Timer_Actualizar_Menu_PleProyectos As Timer
    Private WithEvents Timer_Eliminar_Menu_PleProyectos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleProyectos()
        Me.Timer_Guardar_Menu_PleProyectos = New Timer
        Timer_Guardar_Menu_PleProyectos.Interval = 250
        Timer_Guardar_Menu_PleProyectos.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleProyectos()
        Me.Timer_Actualizar_Menu_PleProyectos = New Timer
        Timer_Actualizar_Menu_PleProyectos.Interval = 500
        Timer_Actualizar_Menu_PleProyectos.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleProyectos()
        Me.Timer_Eliminar_Menu_PleProyectos = New Timer
        Timer_Eliminar_Menu_PleProyectos.Interval = 800
        Timer_Eliminar_Menu_PleProyectos.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleProyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleProyectos.Tick
        If Guardar_Menu_PleProyectos.BackColor = Color.White Then
            Guardar_Menu_PleProyectos.BackColor = Color.Green
        Else
            Guardar_Menu_PleProyectos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleProyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleProyectos.Tick
        If Actualizar_Menu_PleProyectos.BackColor = Color.White Then
            Actualizar_Menu_PleProyectos.BackColor = Color.Green
        Else
            Actualizar_Menu_PleProyectos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleProyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleProyectos.Tick
        If Eliminar_Menu_PleProyectos.BackColor = Color.White Then
            Eliminar_Menu_PleProyectos.BackColor = Color.Red
        Else
            Eliminar_Menu_PleProyectos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleProyectos()
        Me.Timer_Guardar_Menu_PleProyectos = New Timer
        Timer_Guardar_Menu_PleProyectos.Stop()
        Guardar_Menu_PleProyectos.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleProyectos = New Timer
        Timer_Actualizar_Menu_PleProyectos.Stop()
        Actualizar_Menu_PleProyectos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleProyectos = New Timer
        Timer_Eliminar_Menu_PleProyectos.Stop()
        Eliminar_Menu_PleProyectos.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleProyectos As Timer
    Dim X_PleProyectos
    Private Sub Timer_Ubicar_En_Fila_PleProyectos()
        Me.Timer_Ubicacion_PleProyectos = New Timer
        Timer_Ubicacion_PleProyectos.Interval = 100
        Timer_Ubicacion_PleProyectos.Start()
    End Sub

    '--==============================================================--

    Private Sub PleProyectosViewDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleProyectosViewDataGridView.CellMouseClick
        X_PleProyectos = PleProyectosViewDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleProyectos()
        Try
            Me.PleProyectosViewDataGridView.Rows(X_PleProyectos).Selected = True
            Me.PleProyectosViewDataGridView.FirstDisplayedScrollingRowIndex = X_PleProyectos
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleProyectos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleProyectos.Tick
        Ubicar_En_Fila_PleProyectos()
        Timer_Ubicacion_PleProyectos.Stop()
    End Sub




#End Region

#End Region

#End Region

#Region "TODO PleTablasDeProyecto"

    '--==============================================================--
    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId,
                                                                                           New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    '--==============================================================--



    '--==============================================================--

    Sub Cancelar_PleTablasDeProyecto()
        'Botones Del Menu
        Nuevo_Menu_PleTablasDeProyecto.Enabled = True
        Guardar_Menu_PleTablasDeProyecto.Enabled = False
        Editar_Menu_PleTablasDeProyecto.Enabled = True
        Actualizar_Menu_PleTablasDeProyecto.Enabled = False
        Eliminar_Menu_PleTablasDeProyecto.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ProyectoIdTextBoxBase.Text <> "" Then
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        Else
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
        End If
        Bloquear_Objetos_PleTablasDeProyecto()
        Parar_Timer_PleTablasDeProyecto()
        Timer_Ubicar_En_Fila_PleTablasDeProyecto()
    End Sub

    '--==============================================================--

    'Insertar PleTablasDeProyecto
    Private Sub SP_PleTablasDeProyecto_EDICION_INSERTAR(ProyectoId As Integer,
NombreTabla As String,
Tipo As String,
MascaraTabla As String,
SeleccionadaTabla As Boolean
)
        Try
            Me.SP_PleTablasDeProyecto_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                 NombreTabla,
                                                 Tipo,
                                                 MascaraTabla,
                                                 New System.Nullable(Of Boolean)(CType(SeleccionadaTabla, Boolean))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTablasDeProyecto")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTablasDeProyecto
    Private Sub SP_PleTablasDeProyecto_EDICION_ACTUALIZAR(TablaId As Integer,
ProyectoId As Integer,
NombreTabla As String,
Tipo As String,
MascaraTabla As String,
SeleccionadaTabla As Boolean
)

        Try
            Me.SP_PleTablasDeProyecto_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TablaId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                 NombreTabla,
                                                 Tipo,
                                                 MascaraTabla,
                                                 New System.Nullable(Of Boolean)(CType(SeleccionadaTabla, Boolean))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTablasDeProyecto")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTablasDeProyecto_EDICION_ELIMINAR(TablaId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TablaId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTablasDeProyecto Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTablasDeProyecto()
        ProyectoIdTextBoxBase.Enabled = False
        NombreTablaTextBox.Enabled = False
        CboTipoTextBox.Enabled = False
        MascaraTablaTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTablasDeProyecto()
        ProyectoIdTextBoxBase.Enabled = True
        NombreTablaTextBox.Enabled = True
        CboTipoTextBox.Enabled = True
        MascaraTablaTextBox.Enabled = True


    End Sub

    Public Sub Limpiar_Objetos_PleTablasDeProyecto()
        NombreTablaTextBox.Text = ""
        CboTipoTextBox.Text = ""
        MascaraTablaTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTablasDeProyecto()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreTablaTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTablaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTablasDeProyecto.Click
        Nuevo_Menu_PleTablasDeProyecto.Enabled = False
        Editar_Menu_PleTablasDeProyecto.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTablasDeProyecto()
        NombreTablaTextBox.Enabled = True
        NombreTablaTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTablasDeProyecto.Click
        Control_Nulos_PleTablasDeProyecto()

        If ControlNulos.Text = "" Then
            SP_PleTablasDeProyecto_EDICION_INSERTAR(
        ProyectoIdTextBoxBase.Text,
        NombreTablaTextBox.Text,
        CboTipoTextBox.Text,
        MascaraTablaTextBox.Text,
        SeleccionadaTablaTextBox.Text = "False"
)
            Cancelar_PleTablasDeProyecto()
            Parar_Timer_PleTablasDeProyecto()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTablasDeProyecto.Click
        Nuevo_Menu_PleTablasDeProyecto.Enabled = False
        Guardar_Menu_PleTablasDeProyecto.Enabled = False
        Editar_Menu_PleTablasDeProyecto.Enabled = False
        Actualizar_Menu_PleTablasDeProyecto.Enabled = True
        Eliminar_Menu_PleTablasDeProyecto.Enabled = True
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTablasDeProyecto()
        Timer_Actualizar_PleTablasDeProyecto()
        Timer_Eliminar_PleTablasDeProyecto()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTablasDeProyecto.Click
        Control_Nulos_PleTablasDeProyecto()

        If ControlNulos.Text = "" Then
            SP_PleTablasDeProyecto_EDICION_ACTUALIZAR(
        TablaIdTextBox.Text,
        ProyectoIdTextBoxBase.Text,
        NombreTablaTextBox.Text,
        CboTipoTextBox.Text,
        MascaraTablaTextBox.Text,
        SeleccionadaTablaTextBox.Text
)
            Cancelar_PleTablasDeProyecto()
            Parar_Timer_PleTablasDeProyecto()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTablasDeProyecto.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTablasDeProyecto_EDICION_ELIMINAR(TablaIdTextBox.Text)
            Cancelar_PleTablasDeProyecto()
            Parar_Timer_PleTablasDeProyecto()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTablasDeProyecto()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTablasDeProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTablasDeProyecto.Click
        Cancelar_PleTablasDeProyecto()
    End Sub

    '--==============================================================--

    'Navegacion

    Private Sub NombreTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreTablaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                NombreTablaTextBox.Text = ""
                NombreTablaTextBox.Focus()
            Else
                CboTipoTextBox.Enabled = True
                CboTipoTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CboTipoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboTipoTextBox.Text = ""
                CboTipoTextBox.Focus()
            Else
                MascaraTablaTextBox.Enabled = True
                MascaraTablaTextBox.Focus()
            End If
        End If
        'Solo lectura
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub MascaraTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MascaraTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTablasDeProyecto.Enabled = True Then
                Actualizar_Menu_PleTablasDeProyecto.Enabled = True
                Eliminar_Menu_PleTablasDeProyecto.Enabled = True
            Else
                MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                Guardar_Menu_PleTablasDeProyecto.Enabled = True
                Timer_Guardar_PleTablasDeProyecto()
            End If
        End If
    End Sub


    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales

    'Private Sub SeleccionadaTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionadaTablaCheckBox.CheckedChanged
    '    If SeleccionadaTablaCheckBox.Checked = True Then
    '        SeleccionadaTablaCheckBox.Text = "Activo"
    '        SeleccionadaTablaTextBox.Text = "True"
    '    Else
    '        SeleccionadaTablaCheckBox.Text = "Inactivo"
    '        SeleccionadaTablaTextBox.Text = "False"
    '    End If
    'End Sub


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTablasDeProyecto As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTablasDeProyecto As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTablasDeProyecto As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTablasDeProyecto()
        Me.Timer_Guardar_Menu_PleTablasDeProyecto = New Timer
        Timer_Guardar_Menu_PleTablasDeProyecto.Interval = 250
        Timer_Guardar_Menu_PleTablasDeProyecto.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTablasDeProyecto()
        Me.Timer_Actualizar_Menu_PleTablasDeProyecto = New Timer
        Timer_Actualizar_Menu_PleTablasDeProyecto.Interval = 500
        Timer_Actualizar_Menu_PleTablasDeProyecto.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTablasDeProyecto()
        Me.Timer_Eliminar_Menu_PleTablasDeProyecto = New Timer
        Timer_Eliminar_Menu_PleTablasDeProyecto.Interval = 800
        Timer_Eliminar_Menu_PleTablasDeProyecto.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTablasDeProyecto.Tick
        If Guardar_Menu_PleTablasDeProyecto.BackColor = Color.White Then
            Guardar_Menu_PleTablasDeProyecto.BackColor = Color.Green
        Else
            Guardar_Menu_PleTablasDeProyecto.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTablasDeProyecto.Tick
        If Actualizar_Menu_PleTablasDeProyecto.BackColor = Color.White Then
            Actualizar_Menu_PleTablasDeProyecto.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTablasDeProyecto.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTablasDeProyecto.Tick
        If Eliminar_Menu_PleTablasDeProyecto.BackColor = Color.White Then
            Eliminar_Menu_PleTablasDeProyecto.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTablasDeProyecto.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTablasDeProyecto()
        Me.Timer_Guardar_Menu_PleTablasDeProyecto = New Timer
        Timer_Guardar_Menu_PleTablasDeProyecto.Stop()
        Guardar_Menu_PleTablasDeProyecto.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTablasDeProyecto = New Timer
        Timer_Actualizar_Menu_PleTablasDeProyecto.Stop()
        Actualizar_Menu_PleTablasDeProyecto.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTablasDeProyecto = New Timer
        Timer_Eliminar_Menu_PleTablasDeProyecto.Stop()
        Eliminar_Menu_PleTablasDeProyecto.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTablasDeProyecto As Timer
    Dim X_PleTablasDeProyecto
    Private Sub Timer_Ubicar_En_Fila_PleTablasDeProyecto()
        Me.Timer_Ubicacion_PleTablasDeProyecto = New Timer
        Timer_Ubicacion_PleTablasDeProyecto.Interval = 100
        Timer_Ubicacion_PleTablasDeProyecto.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CellMouseClick
        X_PleTablasDeProyecto = SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTablasDeProyecto()
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(X_PleTablasDeProyecto).Selected = True
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTablasDeProyecto
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTablasDeProyecto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTablasDeProyecto.Tick
        Ubicar_En_Fila_PleTablasDeProyecto()
        Timer_Ubicacion_PleTablasDeProyecto.Stop()
    End Sub
#End Region

#End Region

#End Region

#Region "TODO PleCampDeTablas"


    '--==============================================================--

    Sub Cancelar_PleCampDeTablas()
        'Botones Del Menu
        Nuevo_Menu_PleCampDeTablas.Enabled = True
        Guardar_Menu_PleCampDeTablas.Enabled = False
        Editar_Menu_PleCampDeTablas.Enabled = True
        Actualizar_Menu_PleCampDeTablas.Enabled = False
        Eliminar_Menu_PleCampDeTablas.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If TablaIdTextBox.Text <> "" Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId(TablaIdTextBox.Text)
        End If
        Bloquear_Objetos_PleCampDeTablas()
        Parar_Timer_PleCampDeTablas()
        Timer_Ubicar_En_Fila_PleCampDeTablas()
    End Sub

    '--==============================================================--

    'Insertar PleCampDeTablas
    Private Sub SP_PleCampDeTablas_EDICION_INSERTAR(NombreCampo As String,
MascaraCampo As String,
TipoDatoId As Integer,
TipoDatoEspecial As String,
Orden As Integer,
SeleccionadoCampo As Boolean,
TablaId As Integer
)
        Try
            Me.SP_PleCampDeTablas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_EDICION_INSERTAR,
                                                 NombreCampo,
                                                 MascaraCampo,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 TipoDatoEspecial,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(SeleccionadoCampo, Boolean)),
                                                 New System.Nullable(Of Integer)(CType(TablaId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleCampDeTablas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleCampDeTablas
    Private Sub SP_PleCampDeTablas_EDICION_ACTUALIZAR(CampoId As Integer,
NombreCampo As String,
MascaraCampo As String,
TipoDatoId As Integer,
TipoDatoEspecial As String,
Orden As Integer,
SeleccionadoCampo As Boolean,
TablaId As Integer
)

        Try
            Me.SP_PleCampDeTablas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(CampoId, Integer)),
                                                 NombreCampo,
                                                 MascaraCampo,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 TipoDatoEspecial,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(SeleccionadoCampo, Boolean)),
                                                 New System.Nullable(Of Integer)(CType(TablaId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleCampDeTablas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PleCampDeTablas_EDICION_ACTUALIZAR_Ordenamiento(CampoId As Integer,
NombreCampo As String,
MascaraCampo As String,
TipoDatoId As Integer,
TipoDatoEspecial As String,
Orden As Integer,
SeleccionadoCampo As Boolean,
TablaId As Integer
)
        Try
            Me.SP_PleCampDeTablas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(CampoId, Integer)),
                                                 NombreCampo,
                                                 MascaraCampo,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 TipoDatoEspecial,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(SeleccionadoCampo, Boolean)),
                                                 New System.Nullable(Of Integer)(CType(TablaId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleCampDeTablas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleCampDeTablas_EDICION_ELIMINAR(CampoId As Integer)
        Try
            Me.SP_PleCampDeTablas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(CampoId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleCampDeTablas Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleCampDeTablas()
        NombreCampoTextBox.Enabled = False
        MascaraCampoTextBox.Enabled = False
        CboGrupoTipoDato.Enabled = False
        CboTipoDatoIdTextBox.Enabled = False
        TipoDatoEspecialTextBox.Enabled = False
        OrdenTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleCampDeTablas()
        NombreCampoTextBox.Enabled = True
        MascaraCampoTextBox.Enabled = True
        CboGrupoTipoDato.Enabled = True
        CboTipoDatoIdTextBox.Enabled = True
        TipoDatoEspecialTextBox.Enabled = True
        OrdenTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleCampDeTablas()
        NombreCampoTextBox.Text = ""
        MascaraCampoTextBox.Text = ""
        CboGrupoTipoDato.Text = ""
        CboTipoDatoIdTextBox.Text = ""
        TipoDatoEspecialTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleCampDeTablas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreCampoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreCampoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case MascaraCampoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                MascaraCampoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboGrupoTipoDato.Text = ""
                MsgBox("El nombre del campo: Tipo de Grupo de dato; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboGrupoTipoDato.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoDatoIdTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo de dato; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoIdTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case OrdenTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                OrdenTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleCampDeTablas.Click
        Nuevo_Menu_PleCampDeTablas.Enabled = False
        Editar_Menu_PleCampDeTablas.Enabled = False
        OrdenTextBox.Text = SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.Rows.Count + 1
        ValidarCierre.Text = 1
        SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.Enabled = False
        Limpiar_Objetos_PleCampDeTablas()
        NombreCampoTextBox.Enabled = True
        NombreCampoTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleCampDeTablas.Click
        Control_Nulos_PleCampDeTablas()

        If ControlNulos.Text = "" Then
            SP_PleCampDeTablas_EDICION_INSERTAR(
        NombreCampoTextBox.Text,
        MascaraCampoTextBox.Text,
        TipoDatoIdTextBox.Text,
        TipoDatoEspecialTextBox.Text,
        OrdenTextBox.Text,
        SeleccionadoCampoTextBox.Text = "False",
        TablaIdTextBox.Text
)
            Cancelar_PleCampDeTablas()
            Parar_Timer_PleCampDeTablas()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleCampDeTablas.Click
        Nuevo_Menu_PleCampDeTablas.Enabled = False
        Guardar_Menu_PleCampDeTablas.Enabled = False
        Editar_Menu_PleCampDeTablas.Enabled = False
        Actualizar_Menu_PleCampDeTablas.Enabled = True
        Eliminar_Menu_PleCampDeTablas.Enabled = True
        SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleCampDeTablas()
        Timer_Actualizar_PleCampDeTablas()
        Timer_Eliminar_PleCampDeTablas()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleCampDeTablas.Click
        Control_Nulos_PleCampDeTablas()

        If ControlNulos.Text = "" Then
            SP_PleCampDeTablas_EDICION_ACTUALIZAR(
        CampoIdTextBox.Text,
        NombreCampoTextBox.Text,
        MascaraCampoTextBox.Text,
        TipoDatoIdTextBox.Text,
        TipoDatoEspecialTextBox.Text,
        OrdenTextBox.Text,
        SeleccionadoCampoTextBox.Text,
        TablaIdTextBox.Text
)
            Cancelar_PleCampDeTablas()
            Parar_Timer_PleCampDeTablas()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleCampDeTablas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleCampDeTablas_EDICION_ELIMINAR(CampoIdTextBox.Text)
            Cancelar_PleCampDeTablas()
            Parar_Timer_PleCampDeTablas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleCampDeTablas()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleCampDeTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleCampDeTablas.Click
        Cancelar_PleCampDeTablas()
    End Sub

    '--==============================================================--
    'Navegacion




    '--==============================================================--

    Private Sub NombreCampoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCampoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreCampoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                NombreCampoTextBox.Text = ""
                NombreCampoTextBox.Focus()
            Else
                MascaraCampoTextBox.Enabled = True
                MascaraCampoTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub MascaraCampoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MascaraCampoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If MascaraCampoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                MascaraCampoTextBox.Text = ""
                MascaraCampoTextBox.Focus()
            Else
                CboGrupoTipoDato.Enabled = True
                CboGrupoTipoDato.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CboGrupoTipoDato_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboGrupoTipoDato.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboGrupoTipoDato.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboGrupoTipoDato.Text = ""
                CboGrupoTipoDato.Focus()
            Else
                CboTipoDatoIdTextBox.Enabled = True
                CboTipoDatoIdTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub CboTipoDatoIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDatoIdTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDatoIdTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboTipoDatoIdTextBox.Text = ""
                CboTipoDatoIdTextBox.Focus()
            Else
                TipoDatoEspecialTextBox.Enabled = True
                TipoDatoEspecialTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub TipoDatoEspecialTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoDatoEspecialTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            OrdenTextBox.Enabled = True
            OrdenTextBox.Focus()
        End If
    End Sub

    '--==============================================================--

    Private Sub OrdenTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OrdenTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleCampDeTablas.Enabled = True Then
                Actualizar_Menu_PleCampDeTablas.Enabled = True
                Eliminar_Menu_PleCampDeTablas.Enabled = True
            Else
                If OrdenTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    OrdenTextBox.Text = ""
                    OrdenTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleCampDeTablas.Enabled = True
                    Timer_Guardar_PleCampDeTablas()
                End If
            End If
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    'Especiales

    Private Sub SeleccionadoCampoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionadoCampoCheckBox.CheckedChanged
        If SeleccionadoCampoCheckBox.Checked = True Then
            SeleccionadoCampoCheckBox.Text = "Activo"
            SeleccionadoCampoTextBox.Text = "True"
        Else
            SeleccionadoCampoCheckBox.Text = "Inactivo"
            SeleccionadoCampoTextBox.Text = "False"
        End If
    End Sub

    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleCampDeTablas As Timer
    Private WithEvents Timer_Actualizar_Menu_PleCampDeTablas As Timer
    Private WithEvents Timer_Eliminar_Menu_PleCampDeTablas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleCampDeTablas()
        Me.Timer_Guardar_Menu_PleCampDeTablas = New Timer
        Timer_Guardar_Menu_PleCampDeTablas.Interval = 250
        Timer_Guardar_Menu_PleCampDeTablas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleCampDeTablas()
        Me.Timer_Actualizar_Menu_PleCampDeTablas = New Timer
        Timer_Actualizar_Menu_PleCampDeTablas.Interval = 500
        Timer_Actualizar_Menu_PleCampDeTablas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleCampDeTablas()
        Me.Timer_Eliminar_Menu_PleCampDeTablas = New Timer
        Timer_Eliminar_Menu_PleCampDeTablas.Interval = 800
        Timer_Eliminar_Menu_PleCampDeTablas.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleCampDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleCampDeTablas.Tick
        If Guardar_Menu_PleCampDeTablas.BackColor = Color.White Then
            Guardar_Menu_PleCampDeTablas.BackColor = Color.Green
        Else
            Guardar_Menu_PleCampDeTablas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleCampDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleCampDeTablas.Tick
        If Actualizar_Menu_PleCampDeTablas.BackColor = Color.White Then
            Actualizar_Menu_PleCampDeTablas.BackColor = Color.Green
        Else
            Actualizar_Menu_PleCampDeTablas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleCampDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleCampDeTablas.Tick
        If Eliminar_Menu_PleCampDeTablas.BackColor = Color.White Then
            Eliminar_Menu_PleCampDeTablas.BackColor = Color.Red
        Else
            Eliminar_Menu_PleCampDeTablas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleCampDeTablas()
        Me.Timer_Guardar_Menu_PleCampDeTablas = New Timer
        Timer_Guardar_Menu_PleCampDeTablas.Stop()
        Guardar_Menu_PleCampDeTablas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleCampDeTablas = New Timer
        Timer_Actualizar_Menu_PleCampDeTablas.Stop()
        Actualizar_Menu_PleCampDeTablas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleCampDeTablas = New Timer
        Timer_Eliminar_Menu_PleCampDeTablas.Stop()
        Eliminar_Menu_PleCampDeTablas.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleCampDeTablas As Timer
    Dim X_PleCampDeTablas
    Private Sub Timer_Ubicar_En_Fila_PleCampDeTablas()
        Me.Timer_Ubicacion_PleCampDeTablas = New Timer
        Timer_Ubicacion_PleCampDeTablas.Interval = 100
        Timer_Ubicacion_PleCampDeTablas.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.CellMouseClick
        X_PleCampDeTablas = SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleCampDeTablas()
        Try
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.Rows(X_PleCampDeTablas).Selected = True
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleCampDeTablas
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleCampDeTablas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleCampDeTablas.Tick
        Ubicar_En_Fila_PleCampDeTablas()
        Timer_Ubicacion_PleCampDeTablas.Stop()
    End Sub



#End Region

#End Region

#End Region

#Region "TODO Relaciones entre tablas"
    Private Sub BtnCrearRelacion_Click(sender As Object, e As EventArgs) Handles BtnCrearRelacion.Click
        SP_PleTablasRelacionadasRegistro_VALIDA_EXISTENCIA(ComponenteIdRelacionesPosibles.Text, TablaIdPos1.Text, TablaIdPos2.Text, CampoIdTextBox1.Text, CampoIdTextBox2.Text, ProyectoIdTextBoxBase.Text)
        If ComponenteIdValidacionExistencia.Text = "" Then
            If ComponenteIdRelacionesPosibles.Text <> "" Then
                SP_PleTablasRelacionadasRegistro_EDICION_INSERTAR(ComponenteIdRelacionesPosibles.Text,
                                                              TablaIdPos1.Text,
                                                              TablaIdPos2.Text,
                                                              CampoIdTextBox1.Text,
                                                              CampoIdTextBox2.Text,
                                                              TipoTablaPosUno.Text,
                                                              TipoTablaPosDos.Text,
                                                              TipoDatoIdPosUno.Text,
                                                              TipoDatoIdPosDos.Text,
                                                              ProyectoIdTextBoxBase.Text)
                SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO(TablaIdTextBox.Text)
            Else
                MsgBox("No existe una relacion posible entre estas dos tablas que se halla creado, favor verificar", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Ya esta relación existe, favor verificar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub SP_PleTablasRelacionadasRegistro_VALIDA_EXISTENCIA(ComponenteId As Integer,
                                                                   TablaIdPosUno As Integer,
                                                                   TablaIdPosDos As Integer,
                                                                   CampoIdPosUno As Integer,
                                                                   CampoIdPosDos As Integer,
                                                                   ProyectoId As Integer)
        Try
            Me.SP_PleTablasRelacionadasRegistro_VALIDA_EXISTENCIATableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistro_VALIDA_EXISTENCIA,
                                                                                   New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(TablaIdPosUno, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(TablaIdPosDos, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(CampoIdPosUno, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(CampoIdPosDos, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasRelacionadasRegistro_EDICION_INSERTAR(ComponenteId As Integer,
                                                                  TablaIdPosUno As Integer,
                                                                  TablaIdPosDos As Integer,
                                                                  CampoIdPosUno As Integer,
                                                                  CampoIdPosDos As Integer,
                                                                  TipoCodigoComponentePosUno As String,
                                                                  TipoCodigoComponentePosDos As String,
                                                                  TipoDatoIdPosUno As Integer,
                                                                  TipoDatoIdPosDos As Integer,
                                                                  ProyectoId As Integer)
        Try
            Me.SP_PleTablasRelacionadasRegistro_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistro_EDICION_INSERTAR,
                                                                                  New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(TablaIdPosUno, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(TablaIdPosDos, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(CampoIdPosUno, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(CampoIdPosDos, Integer)),
                                                                                  TipoCodigoComponentePosUno,
                                                                                  TipoCodigoComponentePosDos,
                                                                                  New System.Nullable(Of Integer)(CType(TipoDatoIdPosUno, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(TipoDatoIdPosDos, Integer)),
                                                                                  New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
            Metodo_Aviso_Acciones(3, "Relación creada Exitosamente!!!")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasRelacionadasRegistro_EDICION_ELIMINAR()
        Try
            Me.SP_PleTablasRelacionadasRegistro_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistro_EDICION_ELIMINAR,
                                                                                  New System.Nullable(Of Integer)(CType(PleTablasRelacionadasRegistroIdTextBox.Text, Integer)))
            Metodo_Aviso_Acciones(3, "Relación Eliminada Exitosamente!!!")

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PleTablasRelacionadas_BUSCA_RELACIONES_POSIBLES(TipoCodigoComponentePosUno As String,
                                                                   TipoCodigoComponentePosDos As String,
                                                                   TipoDatoIdPosUno As String,
                                                                   TipoDatoIdPosDos As String)
        Try
            Me.SP_PleTablasRelacionadas_BUSCA_RELACIONES_POSIBLESTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_BUSCA_RELACIONES_POSIBLES,
                                                                                   TipoCodigoComponentePosUno,
                                                                                   TipoCodigoComponentePosDos,
                                                                                   New System.Nullable(Of Integer)(CType(TipoDatoIdPosUno, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(TipoDatoIdPosDos, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1DataGridView.CellMouseClick
        HabilitarBotonRelacion()
    End Sub

    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2DataGridView.CellMouseClick
        HabilitarBotonRelacion()
    End Sub

    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1DataGridView.CellMouseClick
        HabilitarBotonRelacion()
    End Sub

    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2DataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2DataGridView.CellMouseClick
        HabilitarBotonRelacion()
    End Sub

    Private Sub HabilitarBotonRelacion()
        SP_PleTablasRelacionadas_BUSCA_RELACIONES_POSIBLES(TipoTablaPosUno.Text, TipoTablaPosDos.Text, TipoDatoIdPosUno.Text, TipoDatoIdPosDos.Text)
        If SP_PleTablasRelacionadas_BUSCA_RELACIONES_POSIBLESDataGridView.Rows.Count > 0 Then
            BtnCrearRelacion.Enabled = True
        Else
            BtnCrearRelacion.Enabled = False
        End If
    End Sub

    Private Sub SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO(TablaIdPosUno As Integer)
        Try
            Me.SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNOTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO,
                                                                                                  New System.Nullable(Of Integer)(CType(TablaIdPosUno, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminarRelacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarRelacion.Click
        If MsgBox("Desea Eliminar Esta Relacion de Tablas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTablasRelacionadasRegistro_EDICION_ELIMINAR()
            SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO(TablaIdTextBox.Text)
        Else
            MsgBox("Se Cancelo la Eliminación de la Relación", MsgBoxStyle.Information)
            SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO(TablaIdTextBox.Text)
        End If
    End Sub

#End Region

    '--========================FIN==================================--

    '--========================FUNCIONES============================--

#Region "Variables Globales"
    'Define si se crea o no un documento tecnico del proyecto
    Dim CREAR_DOC_TECNICO As Boolean
    'Define si se crean o no un Carpetas y archivos creados en las rutas indicadas segun archivo
    Dim CREAR_CARPETAS_ARCHIVOS As Boolean
    'Constante para el progres bar
    Dim ConstanteProgress As Integer = 0
#End Region

#Region "Texchaged"

    Private Sub ProyectoIdTextBoxBase_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIdTextBoxBase.TextChanged
        If ProyectoIdTextBoxBase.Text <> "" Then
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1(ProyectoIdTextBoxBase.Text)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2(ProyectoIdTextBoxBase.Text)
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(ProyectoIdTextBoxBase.Text)
            SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
            CargaReporteSegunProyecto(ProyectoIdTextBoxBase.Text)
            CargaTecnologiaProyecto(ProyectoIdTextBoxBase.Text)
            CargaCodigoGenerado(ProyectoIdTextBoxBase.Text)
        Else
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1(0)
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2(0)
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(0)
            SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(0)
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
            CargaReporteSegunProyecto(0)
            CargaTecnologiaProyecto(0)
            CargaCodigoGenerado(0)
        End If
    End Sub
    Private Sub ProyectoIdTextBoxTabla_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIdTextBoxTabla.TextChanged
        ProyectoIdTextBoxBase.Text = ProyectoIdTextBoxTabla.Text
    End Sub
    Private Sub TecnologiaIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIdTextBox.TextChanged
        If TecnologiaIdTextBox.Text <> "" Then
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
        Else
            TecnologiaIdTextBox.Text = 0
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
        End If
    End Sub
    Private Sub PlantillaIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIdTextBox.TextChanged
        If PlantillaIdTextBox.Text <> "" Then
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        Else
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
        End If
    End Sub
    Private Sub TipoDatoGrupoIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoGrupoIdTextBox.TextChanged
        If TipoDatoGrupoIdTextBox.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoIdTextBox.Text)
        Else
            TipoDatoGrupoIdTextBox.Text = 0
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoIdTextBox.Text)
        End If
    End Sub
    Private Sub TablaIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TablaIdTextBox.TextChanged
        If TablaIdTextBox.Text <> "" Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId(TablaIdTextBox.Text)
            SP_PleTablasRelacionadasRegistroView_BUSQUEDA_SEGUN_TABAL_POS_UNO(TablaIdTextBox.Text)
        End If
    End Sub
    Private Sub TablaIdTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TablaIdPos1.TextChanged
        If TablaIdPos1.Text <> "" Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1(TablaIdPos1.Text)
            HabilitarBotonRelacion()
        End If
    End Sub
    Private Sub TablaIdTextBox2_TextChanged(sender As Object, e As EventArgs) Handles TablaIdPos2.TextChanged
        If TablaIdPos2.Text <> "" Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2(TablaIdPos2.Text)
            HabilitarBotonRelacion()
        End If
    End Sub
    Private Sub PlantillaIdTextBoxGeneracion_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIdTextBoxGeneracion.TextChanged
        If PlantillaIdTextBoxGeneracion.Text <> "" Then
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBoxGeneracion.Text)
        Else
            PlantillaIdTextBoxGeneracion.Text = 0
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBoxGeneracion.Text)
        End If
    End Sub
    Private Sub TipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoTextBox.TextChanged
        CboTipoTextBox.Text = TipoTextBox.Text
    End Sub
    Private Sub NombreTipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoTextBox.TextChanged
        CboTipoDatoIdTextBox.Text = NombreTipoTextBox.Text
    End Sub
    Private Sub NombreGrupoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoTextBox.TextChanged
        CboGrupoTipoDato.Text = NombreGrupoTextBox.Text
    End Sub
    Private Sub TipoDatoIdDeGrupo_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoIdDeGrupo.TextChanged
        TipoDatoIdTextBox.Text = TipoDatoIdDeGrupo.Text
    End Sub
    'Carga tecnologias seleccionadas   


#Region "Metodos de carga por Techanged"
    Private Sub SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaId As Integer)
        Try
            Me.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId,
                                                                                      New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId, New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId(TablaId As Integer)
        Try
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId, New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub OcultarReports()
        RVEstimacion.Visible = False
        RVTecnologias.Visible = False
        RVCodigoGenerado.Visible = False
        RVDetallesAplicacion.Visible = False
    End Sub
    Private Sub CboSeleccionConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboSeleccionConsulta.SelectedIndexChanged
        If CboSeleccionConsulta.Text = "Estimación del Proyecto Seleccionado" Then
            OcultarReports()
            RVEstimacion.Visible = True
            RVEstimacion.Width = 718
            RVEstimacion.Height = 565
            RVEstimacion.Location = New Point(0, 48)
            Me.EncabezadoReporteViewTableAdapter.Fill(Me.DataSetMaestros.EncabezadoReporteView, ProyectoIdTextBoxBase.Text)
            Me.RVEstimacion.RefreshReport()
        End If
        If CboSeleccionConsulta.Text = "Tecnologias Aplicadas al Proyecto" Then
            OcultarReports()
            RVTecnologias.Visible = True
            RVTecnologias.Width = 718
            RVTecnologias.Height = 565
            RVTecnologias.Location = New Point(0, 48)
            Me.PleTecnologiasAplicadasImagenesViewTableAdapter.Fill(Me.DataSetMaestros.PleTecnologiasAplicadasImagenesView, ProyectoIdTextBoxBase.Text)
            Me.RVTecnologias.RefreshReport()
        End If
        If CboSeleccionConsulta.Text = "Codigo Generado" Then
            OcultarReports()
            RVCodigoGenerado.Width = 718
            RVCodigoGenerado.Height = 565
            RVCodigoGenerado.Location = New Point(0, 48)
            Me.PleCodigoRealizadoTableAdapter.Fill(Me.DataSetMaestros.PleCodigoRealizado, ProyectoIdTextBoxBase.Text)
            RVCodigoGenerado.Visible = True
            Me.RVCodigoGenerado.RefreshReport()
        End If

        If CboSeleccionConsulta.Text = "Detalles Aplicación" Then
            OcultarReports()
            RVDetallesAplicacion.Width = 718
            RVDetallesAplicacion.Height = 565
            RVDetallesAplicacion.Location = New Point(0, 48)
            Me.ReporteDetallesAplicacionTableAdapter.Fill(Me.DataSetMaestros.ReporteDetallesAplicacion, ProyectoIdTextBoxBase.Text)
            RVDetallesAplicacion.Visible = True
            Me.RVCodigoGenerado.RefreshReport()
            RVDetallesAplicacion.RefreshReport()
        End If
    End Sub
    Public Sub CargaReporteSegunProyecto(ProyectoId As Integer)
        Me.EncabezadoReporteViewTableAdapter.Fill(Me.DataSetMaestros.EncabezadoReporteView, ProyectoId)
        Me.RVEstimacion.RefreshReport()
    End Sub
    Public Sub CargaTecnologiaProyecto(ProyectoId As Integer)
        Me.PleTecnologiasAplicadasImagenesViewTableAdapter.Fill(Me.DataSetMaestros.PleTecnologiasAplicadasImagenesView, ProyectoId)
        Me.RVTecnologias.RefreshReport()
    End Sub
    Public Sub CargaCodigoGenerado(ProyectoId As Integer)
        Me.PleCodigoRealizadoTableAdapter.Fill(Me.DataSetMaestros.PleCodigoRealizado, ProyectoId)
        Me.RVCodigoGenerado.RefreshReport()
    End Sub
    Public Sub CargaDetallesAplicacion(ProyectoId As Integer)
        Me.ReporteDetallesAplicacionTableAdapter.Fill(Me.DataSetMaestros.ReporteDetallesAplicacion, ProyectoId)
    End Sub
#End Region

#End Region

#Region "Context Menu"
    Private Sub AgregarSeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarSeleccionadasToolStripMenuItem.Click
        Dim contadorTecnologiasAplicadas = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CurrentCell = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows(0).Cells(0)
            If SeleccionadaCheckBox.Checked = True Then
                SP_PleProyectosYTecnologias_EDICION_INSERTAR(ProyectoIdTextBoxBase.Text, TecnologiaIdTextBox.Text, PlantillaIdTextBox.Text)
            End If
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        Metodo_Aviso_Acciones(1, "Se agregan las Seleccionadas!!!")
        SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
    Private Sub AgregarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarTodasToolStripMenuItem.Click
        Dim contadorTecnologiasAplicadas = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count()
        'Carga las tecnologias aplicadas y segun pide los requerimientos de de las plantillas de dichas tecnologias
        While contadorTecnologiasAplicadas > 0
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CurrentCell = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows(0).Cells(0)
            SP_PleProyectosYTecnologias_EDICION_INSERTAR(ProyectoIdTextBoxBase.Text, TecnologiaIdTextBox.Text, PlantillaIdTextBox.Text)
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.RemoveAt(0)
            contadorTecnologiasAplicadas = contadorTecnologiasAplicadas - 1
        End While
        SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
        Metodo_Aviso_Acciones(1, "Se agregan todas las Plantillas!!!")
    End Sub
    Private Sub AgregarPlantillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlantillaToolStripMenuItem.Click
        SP_PleProyectosYTecnologias_EDICION_INSERTAR(ProyectoIdTextBoxBase.Text, TecnologiaIdTextBox.Text, PlantillaIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
    Private Sub SeleccionarTodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodasToolStripMenuItem.Click
        For Each fila As DataGridViewRow In SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows
            fila.Cells(1).Value = True
        Next
        SeleccionadaCheckBox.Checked = True
    End Sub
    Private Sub EliminarUna_Click(sender As Object, e As EventArgs) Handles EliminarUna.Click
        SP_PleProyectosYTecnologias_EDICION_ELIMINAR(ProyectosYTecnologiasIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
    Private Sub EliminarTodas_Click(sender As Object, e As EventArgs) Handles EliminarTodas.Click
        SP_PleProyectosYTecnologias_EDICION_ELIMINAR_Segun_ProyectoYTecnologia(ProyectoIdTextBoxBase.Text, TecnologiaIdTextBox1.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
    Private Sub CalcularTiempoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularTiempoToolStripMenuItem.Click
        MetricaDeTiempo()
    End Sub
#End Region

#Region "Metodos Comunes"
    Private Sub SP_PleProyectosYTecnologias_EDICION_INSERTAR(ProyectoId As Integer, TecnologiaId As Integer, PlantillaId As Integer)
        Try
            Me.SP_PleProyectosYTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosYTecnologias_EDICION_INSERTAR,
                                                                             New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)),
                                                                             New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
            Metodo_Aviso_Acciones(1, "Agregado!!!")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleProyectosYTecnologias_EDICION_ELIMINAR(ProyectosYTecnologiasId As Integer)
        Try
            Me.SP_PleProyectosYTecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosYTecnologias_EDICION_ELIMINAR,
                                                                             New System.Nullable(Of Integer)(CType(ProyectosYTecnologiasId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoID As Integer)
        Try
            Me.SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId,
                                                                                                    New System.Nullable(Of Integer)(CType(ProyectoID, Integer)))
            If ProyectoIdTextBoxBase.Text <> "" Then
                SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(ProyectoIdTextBoxBase.Text)
            Else
                SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(0)
            End If
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(PlantillaID As Integer, Seleccionada As Boolean)
        Try
            Me.SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADATableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADA,
                                                                                     New System.Nullable(Of Integer)(CType(PlantillaID, Integer)),
                                                                                     New System.Nullable(Of Boolean)(CType(Seleccionada, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_PleProyectosYTecnologias_EDICION_ELIMINAR_Segun_ProyectoYTecnologia(ProyectoId As Integer, TecnologiaId As Integer)
        Try
            Me.SP_PleProyectosYTecnologias_EDICION_ELIMINAR_Segun_ProyectoYTecnologiaTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosYTecnologias_EDICION_ELIMINAR_Segun_ProyectoYTecnologia,
                                                                                                       New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                                       New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "CellContentClick"
    Private Sub SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CellContentClick
        Dim seleccionada As Boolean
        If e.ColumnIndex = 1 Then
            If Convert.ToBoolean(SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows(e.RowIndex).Cells(1).EditedFormattedValue) = True Then
                seleccionada = True
                SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(PlantillaIdTextBox.Text, seleccionada)
            Else
                seleccionada = False
                SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(PlantillaIdTextBox.Text, seleccionada)
            End If
        End If
    End Sub

    Private Sub SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CellContentClick
        Dim Seleccionado As Boolean
        If e.ColumnIndex = 0 Then
            If Convert.ToBoolean(SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(e.RowIndex).Cells(0).EditedFormattedValue) = True Then
                Seleccionado = True
                SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR(PleRutasArchivosTecnologiasRegistroIdTextBox.Text, Seleccionado)
            Else
                Seleccionado = False
                SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR(PleRutasArchivosTecnologiasRegistroIdTextBox.Text, Seleccionado)
            End If
        End If
    End Sub



#End Region

#Region "CellMouseDoubleClick"
    Private Sub SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CellMouseDoubleClick
        SP_PleProyectosYTecnologias_EDICION_INSERTAR(ProyectoIdTextBoxBase.Text, TecnologiaIdTextBox.Text, PlantillaIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
    Private Sub SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CellMouseDoubleClick
        SP_PleProyectosYTecnologias_EDICION_ELIMINAR(ProyectosYTecnologiasIdTextBox.Text)
        SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        MetricaDeTiempo()
    End Sub
#End Region

#Region "Campos Seleccion Orden"
    Dim table As New DataTable
    Dim rowIndex As Integer
    Private Sub ChkMover_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMover.CheckedChanged
        If ChkMover.Checked = True Then
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = False
            DGVEdicionPosicion.Visible = True
            CargarGridEdicion()
            BtnSubirFila.Enabled = True
            BtnBajarFila.Enabled = True
            Nuevo_Menu_PleCampDeTablas.Enabled = False
            Editar_Menu_PleCampDeTablas.Enabled = False
            Cancelar_Menu_PleCampDeTablas.Enabled = False
        Else
            ActualizarItems()
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = True
            DGVEdicionPosicion.Visible = False
            CargarGridEdicion()
            BtnSubirFila.Enabled = False
            BtnBajarFila.Enabled = False
            Nuevo_Menu_PleCampDeTablas.Enabled = True
            Editar_Menu_PleCampDeTablas.Enabled = True
            Cancelar_Menu_PleCampDeTablas.Enabled = True
            Cancelar_PleCampDeTablas()
        End If
    End Sub
    Private Sub ActualizarItems()
        Dim orden As Integer = 1

        Dim contador As Integer = DGVEdicionPosicion.Rows.Count
        While contador > 0
            '    'Se ubica en la primera fila
            DGVEdicionPosicion.CurrentCell = DGVEdicionPosicion.Rows(0).Cells(0)
            Try
                SP_PleCampDeTablas_EDICION_ACTUALIZAR_Orden(Convert.ToString(DGVEdicionPosicion.CurrentRow.Cells(2).Value), orden)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            DGVEdicionPosicion.Rows.RemoveAt(0)
            contador -= 1
            orden += 1
        End While
        'Cancelar_PleCampDeTablas()
    End Sub
    Private Sub SP_PleCampDeTablas_EDICION_ACTUALIZAR_Orden(CampoId As Integer, Orden As Integer)
        Try
            Me.SP_PleCampDeTablas_EDICION_ACTUALIZAR_OrdenTableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_EDICION_ACTUALIZAR_Orden,
                                                                            New System.Nullable(Of Integer)(CType(CampoId, Integer)),
                                                                            New System.Nullable(Of Integer)(CType(Orden, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CargarGridEdicion()
        CargarGridSeleccion()
        With DGVEdicionPosicion
            For Each columna As DataGridViewColumn In .Columns
                'Ajustado
                'columna.MinimumWidth = Int((.Width - .RowHeadersWidth) / .ColumnCount)
                'columna.Width = Int((.Width - .RowHeadersWidth) / .ColumnCount)
                DGVEdicionPosicion.RowHeadersVisible = False
                DGVEdicionPosicion.Columns(0).Width = 30
                DGVEdicionPosicion.Columns(1).Width = 320
                DGVEdicionPosicion.Columns(2).Width = 30
                DGVEdicionPosicion.Columns(3).Visible = False
                DGVEdicionPosicion.Columns(5).Visible = False
                DGVEdicionPosicion.Columns(4).Visible = False
                DGVEdicionPosicion.Columns(6).Visible = False
                DGVEdicionPosicion.Columns(7).Visible = False
                DGVEdicionPosicion.Columns(8).Visible = False
                DGVEdicionPosicion.Columns(9).Visible = False
            Next
        End With
        DGVEdicionPosicion.AllowUserToAddRows = False
        DGVEdicionPosicion.ColumnHeadersVisible = False
    End Sub
    Private Sub CargarGridSeleccion()

        Try
            ' Obtenemos un objeto DataTable con los datos
            ' existentes en el control DataGridView.
            '
            table = Me.DataGridViewToDataTable(Me.DataGridView1)

            'MessageBox.Show(String.Format("Nº de filas añadidas: {0}", table.Rows.Count))

            DGVEdicionPosicion.DataSource = table

        Catch ex As Exception
            ' Se ha producido un error.
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable

        ' Si no es válido el control DataGridView,
        ' devolvemos el valor Nothing.
        '
        If (dgv Is Nothing) Then Return Nothing

        ' Creamos un nuevo objeto DataTable.
        '
        Dim dt As New DataTable()

        ' Conforme recorremos las columnas existentes
        ' en el control DataGridView, vamos creando
        ' nuevas columnas en el objeto DataTable.
        '
        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next

        ' Una vez creada la estructura del objeto DataTable,
        ' recorremos las filas del control DataGridView para
        ' rellenar de datos el objeto DataTable.
        '
        For Each viewRow As DataGridViewRow In dgv.Rows

            ' Creamos una nueva fila en el objeto DataTable;
            ' un objeto DataRow.
            '
            Dim row As DataRow = dt.NewRow()

            For Each col As DataGridViewColumn In dgv.Columns

                ' Valor de la celda actual del control DataGridView1.
                '
                Dim value As Object = viewRow.Cells(col.Name).Value

                ' Si el valor es Nothing, le asignamos un valor NULL a la
                ' columna del objeto DataTable; en caso contrario le asignamos
                ' el valor de la celda del control DataGridView.
                '
                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)

            Next col        ' Siguiente columna

            ' Añadimos la fila al objeto DataTable.
            '
            dt.Rows.Add(row)

        Next viewRow ' Siguiente fila

        ' Por último devolvemos el objeto DataTable creado.
        '
        Return dt

    End Function
    Private Sub BtnSubirFila_Click(sender As Object, e As EventArgs) Handles BtnSubirFila.Click
        Try
            rowIndex = DGVEdicionPosicion.SelectedCells(0).OwningRow.Index
            Dim row As DataRow
            row = table.NewRow()

            row(0) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(0).Value.ToString())
            row(1) = DGVEdicionPosicion.Rows(rowIndex).Cells(1).Value.ToString()
            row(2) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(2).Value.ToString())

            'row(2) = DataGridView1.Rows(rowIndex).Cells(2).Value.ToString()
            'row(3) = Integer.Parse(DataGridView1.Rows(rowIndex).Cells(3).Value.ToString())

            If rowIndex > 0 Then
                table.Rows.RemoveAt(rowIndex)

                table.Rows.InsertAt(row, rowIndex - 1)
                DGVEdicionPosicion.ClearSelection()

                DGVEdicionPosicion.Rows(rowIndex - 1).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnBajarFila_Click(sender As Object, e As EventArgs) Handles BtnBajarFila.Click
        Try
            rowIndex = DGVEdicionPosicion.SelectedCells(0).OwningRow.Index
            Dim row As DataRow
            row = table.NewRow()

            row(0) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(0).Value.ToString())
            row(1) = DGVEdicionPosicion.Rows(rowIndex).Cells(1).Value.ToString()
            row(2) = Integer.Parse(DGVEdicionPosicion.Rows(rowIndex).Cells(2).Value.ToString())
            If rowIndex < DGVEdicionPosicion.Rows.Count Then
                table.Rows.RemoveAt(rowIndex)

                table.Rows.InsertAt(row, rowIndex + 1)
                DGVEdicionPosicion.ClearSelection()

                DGVEdicionPosicion.Rows(rowIndex + 1).Selected = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Botones de Control"
    Private Sub BtnVerProyectos_Click(sender As Object, e As EventArgs) Handles BtnVerProyectos.Click
        If PanelV03Tablas.Width = 451 Then
            tmOCULTARPanelV01Proyectos.Enabled = True
            BtnVerProyectos.BackColor = Color.Transparent
        ElseIf PanelV03Tablas.Width = 1 Then
            tmMOSTRARPanelV01Proyectos.Enabled = True
            BtnVerProyectos.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmOCULTARPanelV01Proyectos_Tick(sender As Object, e As EventArgs) Handles tmOCULTARPanelV01Proyectos.Tick
        If PanelV03Tablas.Width <= 1 Then
            Me.tmOCULTARPanelV01Proyectos.Enabled = False
        Else
            Me.PanelV03Tablas.Width = PanelV03Tablas.Width - 50
        End If
    End Sub
    Private Sub tmMOSTRARPanelV01Proyectos_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARPanelV01Proyectos.Tick
        If PanelV03Tablas.Width >= 451 Then
            Me.tmMOSTRARPanelV01Proyectos.Enabled = False
        Else
            Me.PanelV03Tablas.Width = PanelV03Tablas.Width + 50
        End If
    End Sub

    Private Sub BtnVerTecnologias_Click(sender As Object, e As EventArgs) Handles BtnVerTecnologias.Click
        If PanelV02Tecnologias.Width = 441 Then
            tmOCULTARTecnologias.Enabled = True
            BtnVerTecnologias.BackColor = Color.Transparent
        ElseIf PanelV02Tecnologias.Width = 1 Then
            tmMOSTRARTecnologias.Enabled = True
            BtnVerTecnologias.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmOCULTARTecnologias_Tick(sender As Object, e As EventArgs) Handles tmOCULTARTecnologias.Tick
        If PanelV02Tecnologias.Width <= 1 Then
            Me.tmOCULTARTecnologias.Enabled = False
        Else
            Me.PanelV02Tecnologias.Width = PanelV02Tecnologias.Width - 44
        End If
    End Sub
    Private Sub tmMOSTRARTecnologias_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARTecnologias.Tick
        If PanelV02Tecnologias.Width >= 441 Then
            Me.tmMOSTRARTecnologias.Enabled = False
        Else
            Me.PanelV02Tecnologias.Width = PanelV02Tecnologias.Width + 44
        End If
    End Sub

    Private Sub BtnVerTablas_Click(sender As Object, e As EventArgs) Handles BtnVerTablas.Click
        If PanelV04Campos.Width = 361 Then
            tmOCULTARTablas.Enabled = True
            BtnVerTablas.BackColor = Color.Transparent
        ElseIf PanelV04Campos.Width = 1 Then
            tmMOSTRARTablas.Enabled = True
            BtnVerTablas.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmMOSTRARTablas_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARTablas.Tick
        If PanelV04Campos.Width >= 361 Then
            Me.tmMOSTRARTablas.Enabled = False
        Else
            Me.PanelV04Campos.Width = PanelV04Campos.Width + 36
        End If
    End Sub
    Private Sub tmOCULTARTablas_Tick(sender As Object, e As EventArgs) Handles tmOCULTARTablas.Tick
        If PanelV04Campos.Width <= 1 Then
            Me.tmOCULTARTablas.Enabled = False
        Else
            Me.PanelV04Campos.Width = PanelV04Campos.Width - 36
        End If
    End Sub

    Private Sub BtnVerCampos_Click(sender As Object, e As EventArgs) Handles BtnVerCampos.Click
        If PanelV6CargarRequerimientos.Width = 391 Then
            tmOCULTARCampos.Enabled = True
            BtnVerCampos.BackColor = Color.Transparent
        ElseIf PanelV6CargarRequerimientos.Width = 1 Then
            tmMOSTRARCampos.Enabled = True
            BtnVerCampos.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmMOSTRARCampos_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARCampos.Tick
        If PanelV6CargarRequerimientos.Width >= 391 Then
            Me.tmMOSTRARCampos.Enabled = False
        Else
            Me.PanelV6CargarRequerimientos.Width = PanelV6CargarRequerimientos.Width + 39
        End If
    End Sub
    Private Sub tmOCULTARCampos_Tick(sender As Object, e As EventArgs) Handles tmOCULTARCampos.Tick
        If PanelV6CargarRequerimientos.Width <= 1 Then
            Me.tmOCULTARCampos.Enabled = False
        Else
            Me.PanelV6CargarRequerimientos.Width = PanelV6CargarRequerimientos.Width - 39
        End If
    End Sub

    Private Sub BtnVerRelacionesTablas_Click(sender As Object, e As EventArgs) Handles BtnVerRelacionesTablas.Click
        If PanelV5RelacionesTablas.Width = 401 Then
            tmOCULTARRelacionesTablas.Enabled = True
            BtnVerRelacionesTablas.BackColor = Color.Transparent
        ElseIf PanelV5RelacionesTablas.Width = 1 Then
            tmMOSTRARRelacionesTablas.Enabled = True
            BtnVerRelacionesTablas.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmMOSTRARRelacionesTablas_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARRelacionesTablas.Tick
        If PanelV5RelacionesTablas.Width >= 401 Then
            Me.tmMOSTRARRelacionesTablas.Enabled = False
        Else
            Me.PanelV5RelacionesTablas.Width = PanelV5RelacionesTablas.Width + 40
        End If
    End Sub
    Private Sub tmOCULTARRelacionesTablas_Tick(sender As Object, e As EventArgs) Handles tmOCULTARRelacionesTablas.Tick
        If PanelV5RelacionesTablas.Width <= 1 Then
            Me.tmOCULTARRelacionesTablas.Enabled = False
        Else
            Me.PanelV5RelacionesTablas.Width = PanelV5RelacionesTablas.Width - 40
        End If
    End Sub

    Private Sub BtnCargarRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnCargarRequerimientos.Click
        If PanelV01Proyectos.Width = 621 Then
            tmOCULTARCargarRequerimientos.Enabled = True
            BtnCargarRequerimientos.BackColor = Color.Transparent
        ElseIf PanelV01Proyectos.Width = 1 Then
            tmMOSTRARCargarRequerimientos.Enabled = True
            BtnCargarRequerimientos.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub tmMOSTRARCargarRequerimientos_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARCargarRequerimientos.Tick
        If PanelV01Proyectos.Width >= 621 Then
            Me.tmMOSTRARCargarRequerimientos.Enabled = False
        Else
            Me.PanelV01Proyectos.Width = PanelV01Proyectos.Width + 62
        End If
    End Sub
    Private Sub tmOCULTARCargarRequerimientos_Tick(sender As Object, e As EventArgs) Handles tmOCULTARCargarRequerimientos.Tick
        If PanelV01Proyectos.Width <= 1 Then
            Me.tmOCULTARCargarRequerimientos.Enabled = False
        Else
            Me.PanelV01Proyectos.Width = PanelV01Proyectos.Width - 62
        End If
    End Sub

    Private Sub BtnRecogerAmpliar_Click(sender As Object, e As EventArgs) Handles BtnRecogerAmpliar.Click
        If BtnRecogerAmpliar.BackColor = Color.Transparent Then
            BtnRecogerAmpliar.BackColor = Color.LawnGreen
            tmMOSTRARRelacionesTablas.Enabled = True
            tmMOSTRARCampos.Enabled = True
            tmMOSTRARTablas.Enabled = True
            tmMOSTRARTecnologias.Enabled = True
            tmMOSTRARCargarRequerimientos.Enabled = True
        Else
            BtnRecogerAmpliar.BackColor = Color.Transparent
            tmOCULTARTablas.Enabled = True
            tmOCULTARCampos.Enabled = True
            tmOCULTARRelacionesTablas.Enabled = True
            tmOCULTARTecnologias.Enabled = True
            tmOCULTARCargarRequerimientos.Enabled = True
        End If
    End Sub

    Public Sub OcultarPaneles()
        CodigoGeneradoRichTextBox.SendToBack()
        PanelElementos.SendToBack()
        Panel0UIds.SendToBack()
        BtnCodigo.BackColor = Color.Transparent
        BtnElementos.BackColor = Color.Transparent
        BtnIds.BackColor = Color.Transparent
    End Sub


    Private Sub BtnCodigo_Click(sender As Object, e As EventArgs) Handles BtnCodigo.Click
        OcultarPaneles()
        If BtnCodigo.BackColor = Color.Transparent Then
            CodigoGeneradoRichTextBox.Dock = DockStyle.Fill
            CodigoGeneradoRichTextBox.BringToFront()
            BtnCodigo.BackColor = Color.YellowGreen
        Else
            CodigoGeneradoRichTextBox.Dock = DockStyle.None
            BtnCodigo.BackColor = Color.YellowGreen
        End If
    End Sub
    Private Sub BtnElementos_Click(sender As Object, e As EventArgs) Handles BtnElementos.Click
        OcultarPaneles()

        If BtnElementos.BackColor = Color.Transparent Then
            PanelElementos.Dock = DockStyle.Fill
            PanelElementos.BringToFront()
            BtnElementos.BackColor = Color.YellowGreen
        Else
            PanelElementos.Dock = DockStyle.None
            BtnElementos.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnIds_Click(sender As Object, e As EventArgs) Handles BtnIds.Click
        OcultarPaneles()

        If BtnIds.BackColor = Color.Transparent Then
            Panel0UIds.Dock = DockStyle.Fill
            Panel0UIds.BringToFront()
            BtnIds.BackColor = Color.YellowGreen
        Else
            Panel0UIds.Dock = DockStyle.None
            BtnIds.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnGeneracionArchivos_Click(sender As Object, e As EventArgs) Handles BtnGeneracionArchivos.Click
        If PanelV07.Width = 631 Then
            tmOCULTARV07.Enabled = True
            BtnGeneracionArchivos.BackColor = Color.Transparent
        ElseIf PanelV07.Width = 1 Then
            tmMOSTRARV07.Enabled = True
            BtnGeneracionArchivos.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub tmMOSTRARV07_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARV07.Tick
        If PanelV07.Width >= 631 Then
            Me.tmMOSTRARV07.Enabled = False
        Else
            Me.PanelV07.Width = PanelV07.Width + 63
        End If
    End Sub
    Private Sub tmOCULTARV07_Tick(sender As Object, e As EventArgs) Handles tmOCULTARV07.Tick
        If PanelV07.Width <= 1 Then
            Me.tmOCULTARV07.Enabled = False
        Else
            Me.PanelV07.Width = PanelV07.Width - 63
        End If
    End Sub



    Private Sub BtnReportesProyecto_Click(sender As Object, e As EventArgs) Handles BtnReportesProyecto.Click
        If PanelReportes.Width = 721 Then
            tmOCULTARPanelReportes.Enabled = True
            BtnReportesProyecto.BackColor = Color.Transparent
        ElseIf PanelReportes.Width = 1 Then
            tmMOSTRARPanelReportes.Enabled = True
            BtnReportesProyecto.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub tmMOSTRARPanelReportes_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARPanelReportes.Tick
        If PanelReportes.Width >= 721 Then
            Me.tmMOSTRARPanelReportes.Enabled = False
            RVEstimacion.Visible = True
            RVEstimacion.Width = 718
            RVEstimacion.Height = 565
            RVEstimacion.Location = New Point(0, 48)
            Me.EncabezadoReporteViewTableAdapter.Fill(Me.DataSetMaestros.EncabezadoReporteView, ProyectoIdTextBoxBase.Text)
        Else
            Me.PanelReportes.Width = PanelReportes.Width + 72
        End If
    End Sub
    Private Sub tmOCULTARPanelReportes_Tick(sender As Object, e As EventArgs) Handles tmOCULTARPanelReportes.Tick
        If PanelReportes.Width <= 1 Then
            Me.tmOCULTARPanelReportes.Enabled = False
        Else
            Me.PanelReportes.Width = PanelReportes.Width - 72
        End If
    End Sub




#End Region

#Region "Relaciones entre tablas"
    Private Sub BtnCrearRelaciones_Click(sender As Object, e As EventArgs) Handles BtnCrearRelaciones.Click
        PanelV5RelacionesTablas.Width = 500
    End Sub
    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1(ProyectoId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1TableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1,
                                                                                            New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2(ProyectoId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2TableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId2,
                                                                                            New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1(TablaId As Integer)
        Try
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1TableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId1,
                                                                                     New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2(TablaId As Integer)
        Try
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2TableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId2,
                                                                                     New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

    '--========================FIN===================================--

#Region "Funciones de Edicion de Codigo"
    'Implementacion de funciones
    Public Function ProcesarCodigo(Codigo As String,
                                   NombreTabla As String,
                                   TipoArchivo As String,
                                   ComponenteId As Integer,
                                   TablaId As Integer,
                                   ProyectoId As Integer,
                                   MascaraTabla As String)
        If InStr(Codigo, "{{{Tabla}}}") Then
            Codigo = Codigo.Replace("{{{Tabla}}}", NombreTabla)
        End If

        If InStr(Codigo, "{{{Tmin}}}") Then
            Codigo = PasarAMinuscula(Codigo, NombreTabla)
        End If

        'Remplaza el nombre de la tabla poniendola en minusculas y donde encuentre una mayuscula la remplaza por un guion poniendo la letra que sigue en minuscula
        If InStr(Codigo, "{{{A=>-a}}}") Then
            Codigo = ConvertirMayusculasMinSeparadasPorGuion(Codigo, NombreTabla, 1)
        End If

        'Remplaza el nombre de la tabla poniendola en
        If InStr(Codigo, "{{{Tbl-Camel}}}") Then
            Codigo = ucaseCamelCase(Codigo, NombreTabla)
        End If

        If InStr(Codigo, "{{{Clave}}}") Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId)
            DGVCamposTablaTrabajada.CurrentCell = DGVCamposTablaTrabajada.Rows(0).Cells(0)
            Codigo = Codigo.Replace("{{{Clave}}}", NombreCampoTextBox1.Text)
        End If

        If InStr(Codigo, "{{{Campos}}}") Then
            Dim CodigoGenerado As String = ""
            CodigoGenerado = TratamientoCampos(TablaId, ComponenteId, True)
            Codigo = Codigo.Replace("{{{Campos}}}", CodigoGenerado)
        End If

        If InStr(Codigo, "{{{Camp-Esp}}}") Then
            Dim CodigoGenerado As String = ""
            CodigoGenerado = TratamientoCamposEspeciales(TablaId, ComponenteId, NombreTabla)
            Codigo = Codigo.Replace("{{{Camp-Esp}}}", CodigoGenerado)
        End If

        If InStr(Codigo, "{{{TCampos-ID}}}") Then
            Dim CodigoGenerado As String = ""
            CodigoGenerado = TratamientoCampos(TablaId, ComponenteId, False)
            Codigo = Codigo.Replace("{{{TCampos-ID}}}", CodigoGenerado)
        End If

        If InStr(Codigo, "{{{TCampos-R}}}") Then

        End If

        If InStr(Codigo, "{{{TCampos-R}}}") Then

        End If

        If InStr(Codigo, "{{{Camp-R-ID}}}") Then

        End If

        If InStr(Codigo, "TblMasc") Then
            Codigo = Codigo.Replace("TblMasc", MascaraTabla)
        End If

        'Remplaza el nombre de la tabla poniendola en
        If InStr(Codigo, "{{{Camp-Rel}}}") Then
            Dim CodigoConRelacionado As String = ""
            Dim CodigoGenerado As String = ""
            SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_UNO(ComponenteId, ProyectoIdTextBoxBase.Text, TipoArchivo)
            If TipoEsperadoPosUnoTextBox.Text <> "" Then
                'POSICION UNO EN LA RELACION DE TABLAS
                SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNO(ComponenteId, ProyectoIdTextBoxBase.Text, TipoArchivo, TablaId)
                'MsgBox("Tabla ID posicion UNO --> " & TablaId)
                Dim Contador As Integer
                Contador = SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNODataGridView.Rows.Count
                'MsgBox("Cantidad de relaciones de la tabla --> " & Contador)
                While Contador
                    SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNODataGridView.CurrentCell = SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNODataGridView.Rows(0).Cells(0)
                    CodigoGenerado = TablasRelacionadas(ContenidoPosicionReplaceUno.Text,
                                                TablaPosUnoReplace.Text,
                                                TablaPosDosReplace.Text,
                                                CampoPosUnoReplace.Text,
                                                CampoPosDosReplace.Text,
                                                MascaraCampoPosUnoReplace.Text,
                                                MascaraCampoPosDosReplace.Text)
                    CodigoConRelacionado = CodigoConRelacionado & vbCrLf & CodigoGenerado
                    SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNODataGridView.Rows.RemoveAt(0)
                    Contador -= 1
                End While
            Else
                SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_DOS(ComponenteId, ProyectoIdTextBoxBase.Text, TipoArchivo)
                If TipoEsperadoPosDosTextBox.Text <> "" Then
                    'POSICION DOS EN LA RELACION DE TABLAS
                    SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOS(ComponenteId, ProyectoIdTextBoxBase.Text, TipoArchivo, TablaId)
                    'MsgBox("Tabla ID posicion DOS --> " & TablaId)
                    Dim Contador As Integer
                    Contador = SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOSDataGridView.Rows.Count
                    'MsgBox("Cantidad de relaciones de la tabla --> " & Contador)
                    While Contador
                        SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOSDataGridView.CurrentCell = SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOSDataGridView.Rows(0).Cells(0)
                        CodigoGenerado = TablasRelacionadas(ContenidoPosicionReplaceDos.Text,
                                                TablaPosUnoReplaceDos.Text,
                                                TablaPosDosReplaceDos.Text,
                                                CampoPosUnoReplaceDos.Text,
                                                CampoPosDosReplaceDos.Text,
                                                MascaraCampoPosUnoReplaceDos.Text,
                                                MascaraCampoPosDosReplaceDos.Text)
                        CodigoConRelacionado = CodigoConRelacionado & vbCrLf & CodigoGenerado
                        SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOSDataGridView.Rows.RemoveAt(0)
                        Contador -= 1
                    End While
                End If
            End If
            Codigo = Codigo.Replace("{{{Camp-Rel}}}", CodigoConRelacionado)
        End If

        Return Codigo
    End Function

    Function TratamientoCampos(TablaId As Integer, ComponenteId As Integer, ConID As Boolean)
        'Campos con id o sin id
        If ConID = True Then
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId)
        Else
            SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId)
            DGVCamposTablaTrabajada.Rows.RemoveAt(0)
        End If

        'Declaracion de variables
        Dim CodigoGenerado As String = ""
        Dim nombreCampoSiguiente As String = ""
        Dim CampoFormato As String = ""
        Dim Codigo As String = ""
        Dim contador As Integer = DGVCamposTablaTrabajada.Rows.Count
        'Recorre los campos de la tabla en proceso
        While contador
            DGVCamposTablaTrabajada.CurrentCell = DGVCamposTablaTrabajada.Rows(0).Cells(0)
            'Busca la estructuracion del campo segun el componente
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdANDTipoDatoId(ComponenteId, TipoDatoIdCampos.Text)
            'Tratamiento de campo por formato
            If NombreFormatoReferenciaCte.Text <> "" Then
                CampoFormato = TratamientoFormatoCampo(NombreCampoTextBox1.Text, NombreFormatoReferenciaCte.Text)
            Else
                CampoFormato = NombreCampoTextBox1.Text
            End If

            If contador > 1 Then
                nombreCampoSiguiente = DGVCamposTablaTrabajada.Rows(1).Cells(1).Value.ToString()
                If nombreCampoSiguiente <> "" Then
                    nombreCampoSiguiente = TratamientoFormatoCampo(nombreCampoSiguiente, NombreFormatoReferenciaCte.Text)
                Else
                    nombreCampoSiguiente = nombreCampoSiguiente
                End If
            Else
                nombreCampoSiguiente = CampoFormato
            End If

            Codigo = ReproducirCantidad(contador,
                                        CampoFormato,
                                        nombreCampoSiguiente,
                                        MascaraCampoTextBox1.Text,
                                        SaltoDeLineaCheckBoxReferenciaCte.Checked,
                                        SeparadorCamposReferenciaCte.Text,
                                        OmiteSeparadorFinalCheckBoxReferenciaCte.Checked,
                                        EsSecuencialCheckBoxReferenciaCte.Checked,
                                        CodigoReplaceReferenciaCte.Text,
                                        CodigoReplaceSecuencialTextBoxReferenciaCte.Text)
            Codigo = GuardaRetornaActualizado(Codigo)


            CodigoGenerado = CodigoGenerado & Codigo

            DGVCamposTablaTrabajada.Rows.RemoveAt(0)
            contador -= 1
        End While
        Return CodigoGenerado
    End Function
    Private Function ReproducirCantidad(CantidadRepeticiones As Integer,
                                        CampoConFormato As String,
                                        CampoSecuencialConFormato As String,
                                        CampoMascara As String,
                                        SaltoDeLinea As Boolean,
                                        Separador As String,
                                        OmitirSeparadorAlFinal As Boolean,
                                        EsSecuencial As Boolean,
                                        CodigoReplace As String,
                                        CodigoSecuencial As String) As String

        CodigoReplace = CodigoReplace.Replace("Campo", CampoConFormato)
        CodigoReplace = CodigoReplace.Replace("SeCuenRem", CampoSecuencialConFormato)
        CodigoReplace = CodigoReplace.Replace("CamMasc", CampoMascara)

        CodigoSecuencial = CodigoSecuencial.Replace("Campo", CampoConFormato)
        CodigoSecuencial = CodigoSecuencial.Replace("SeCuenRem", CampoSecuencialConFormato)
        CodigoSecuencial = CodigoSecuencial.Replace("CamMasc", CampoMascara)

        Dim CodigoGenerado As String = ""

        If SaltoDeLinea = True Then
            If Separador = "" Then
                If CantidadRepeticiones = 1 Then
                    If EsSecuencial = True Then
                        CodigoGenerado = CodigoGenerado & CodigoSecuencial & vbCrLf
                    Else
                        CodigoGenerado = CodigoGenerado & CodigoReplace & vbCrLf
                    End If
                Else
                    CodigoGenerado = CodigoGenerado & CodigoReplace & vbCrLf
                End If
            Else
                If OmitirSeparadorAlFinal = True Then
                    If CantidadRepeticiones = 1 Then
                        If EsSecuencial = True Then
                            CodigoGenerado = CodigoGenerado & CodigoSecuencial & vbCrLf
                        Else
                            CodigoGenerado = CodigoGenerado & CodigoReplace & vbCrLf
                        End If
                    Else
                        CodigoGenerado = CodigoGenerado & CodigoReplace & Separador & vbCrLf
                    End If
                Else
                    If CantidadRepeticiones = 1 Then
                        If EsSecuencial = True Then
                            CodigoGenerado = CodigoGenerado & CodigoSecuencial & Separador & vbCrLf
                        Else
                            CodigoGenerado = CodigoGenerado & CodigoReplace & Separador & vbCrLf
                        End If
                    Else
                        CodigoGenerado = CodigoGenerado & CodigoReplace & Separador & vbCrLf
                    End If
                End If
            End If
        Else
            If Separador = "" Then
                If CantidadRepeticiones = 1 Then
                    If EsSecuencial = True Then
                        CodigoGenerado = CodigoGenerado & CodigoSecuencial
                    Else
                        CodigoGenerado = CodigoGenerado & CodigoReplace
                    End If
                Else
                    CodigoGenerado = CodigoGenerado & CodigoReplace & Separador
                End If
            Else
                If OmitirSeparadorAlFinal = True Then
                    If CantidadRepeticiones = 1 Then
                        If EsSecuencial = True Then
                            CodigoGenerado = CodigoGenerado & CodigoSecuencial
                        Else
                            CodigoGenerado = CodigoGenerado & CodigoReplace
                        End If
                    Else
                        CodigoGenerado = CodigoGenerado & CodigoReplace & Separador
                    End If
                Else
                    CodigoGenerado = CodigoGenerado & CodigoReplace & Separador
                End If
            End If
        End If

        Return CodigoGenerado
    End Function

    Private Function TratamientoIndividualCampo(Contador As Integer, Texto As String, ConSalto As Boolean, Separador As String, OmitirSeparadorFinal As Boolean) As String
        Dim CampoFormato As String = ""
        If ConSalto = True Then
            If Separador = "" Then
                CampoFormato = CampoFormato & vbCrLf & Texto
            Else
                If OmitirSeparadorFinal = False Then
                    CampoFormato = CampoFormato & vbCrLf & Texto & Separador
                Else
                    If Contador = 1 Then
                        CampoFormato = CampoFormato & vbCrLf & Texto
                    Else
                        CampoFormato = CampoFormato & vbCrLf & Texto & Separador
                    End If
                End If
            End If
        Else
            If Separador = "" Then
                CampoFormato = CampoFormato & Texto
            Else
                If OmitirSeparadorFinal = False Then
                    CampoFormato = CampoFormato & Texto & Separador
                Else
                    If Contador = 1 Then
                        CampoFormato = CampoFormato & Texto
                    Else
                        CampoFormato = CampoFormato & Texto & Separador
                    End If
                End If
            End If
        End If
        Return CampoFormato
    End Function

    Private Sub SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdANDTipoDatoId(ComponenteId As Integer, TipoDatoId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdANDTipoDatoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdANDTipoDatoId,
                                                                                                                     New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                                     New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Función para quitar los saltos de línea de un texto
    Public Function quitarSaltosLinea(ByVal texto As String, caracterReemplazar As String) As String
        quitarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
        Return quitarSaltosLinea
    End Function

    Function TratamientoFormatoCampo(NombreCampo As String, NombreFormatoReferencia As String)
        If NombreFormatoReferencia = "Original" Then
            NombreCampo = NombreCampo
        End If
        If NombreFormatoReferencia = "Mayusculas" Then
            NombreCampo = UCase(NombreCampo)
        End If
        If NombreFormatoReferencia = "Minusculas" Then
            NombreCampo = LCase(NombreCampo)
        End If
        If NombreFormatoReferencia = "Camel-Case" Then
            NombreCampo = ucaseCamelCaseFormatoCampo(NombreCampo)
        End If
        Return NombreCampo
    End Function

    Function ucaseCamelCaseFormatoCampo(Campo As String)
        Dim cadena As String = Campo
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
        Dim CampoGenerado = primera
        Return CampoGenerado
    End Function

    Function TratamientoCamposEspeciales(TablaId As Integer, ComponenteId As Integer, NombreTabla As String)
        'Campos con id o sin id
        SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId)

        'Declaracion de variables
        Dim CodigoGenerado As String = ""
        Dim nombreCampoSiguiente As String = ""
        Dim CampoFormato As String = ""
        Dim Codigo As String = ""
        Dim contador As Integer = DGVCamposTablaTrabajada.Rows.Count
        'Recorre los campos de la tabla en proceso
        While contador
            DGVCamposTablaTrabajada.CurrentCell = DGVCamposTablaTrabajada.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo(ComponenteId, TipoDatoIdCampos.Text)
            If ContenidoCampoEspecialTextBox.Text <> "" Then
                Codigo = ProcesarCodigo(ContenidoCampoEspecialTextBox.Text, NombreTabla, "", ComponenteId, TablaId, ProyectoIdTextBoxBase.Text, "")
                Codigo = AgregaRequerimientos(Codigo, ComponenteId, ProyectoIdTextBoxBase.Text)
                Codigo = Codigo.Replace("Campo", NombreCampoTextBox1.Text)
                CodigoGenerado = CodigoGenerado & Codigo & vbCrLf
            End If
            DGVCamposTablaTrabajada.Rows.RemoveAt(0)
            contador -= 1
        End While
        SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId)
        Return CodigoGenerado
    End Function

    Private Sub SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo(ComponenteId As Integer, TipoDatoId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipoTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo,
                                                                                                                New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                                New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

#Region "Carga tablas relacionadas por tipos"
    Private Sub SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                               New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Carga codigos segun tipo de relacion"
    Private Sub SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_UNO(ComponenteId As Integer, ProyectoId As Integer, TipoEsperado As String)
        Try
            Me.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_UNOTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_UNO,
                                                                                                        New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                        New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                                        TipoEsperado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_DOS(ComponenteId As Integer, ProyectoId As Integer, TipoEsperado As String)
        Try
            Me.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_DOSTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_DOS,
                                                                                                        New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                        New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                                        TipoEsperado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNO(ComponenteId As Integer, ProyectoId As Integer, TipoEsperado As String, TablaId As Integer)
        Try
            Me.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNOTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_UNO,
                                                                                                              New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                              New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                                              TipoEsperado,
                                                                                                              New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOS(ComponenteId As Integer, ProyectoId As Integer, TipoEsperado As String, TablaId As Integer)
        Try
            Me.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOSTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadasRegistroView_CARGA_RELACION_TABLAS_POSICION_tabla_DOS,
                                                                                                              New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                              New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                                              TipoEsperado,
                                                                                                              New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

#End Region

#Region "Pasa Texto a Minuscula"
    Function PasarAMinuscula(textoBase As String, NombreTabla As String)
        NombreTabla = LCase(NombreTabla)
        Dim CodigoGenerado = textoBase.Replace("{{{Tmin}}}", NombreTabla)
        Return CodigoGenerado
    End Function
#End Region

#Region "Texto como camel-case en tabla"
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

    Function ucaseCamelCaseRelaciones(textoBase As String, NombreTabla As String, posicion As Integer)
        Dim CodigoGenerado As String = ""
        Dim CodigoProvisional As String = ""
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
        Else
            primera = primera + resto
        End If
        If posicion = 1 Then
            CodigoProvisional = textoBase.Replace("{{{Tbl-Camel-P1}}}", primera)
        End If
        If posicion = 2 Then
            CodigoProvisional = textoBase.Replace("{{{Tbl-Camel-P2}}}", primera)
        End If
        CodigoGenerado = CodigoProvisional
        Return CodigoGenerado
    End Function
#End Region

#Region "Convertir Mayusculas Minusculas Separadas Por Guion"
    Function ConvertirMayusculasMinSeparadasPorGuion(textoBase As String, NombreTabla As String, Tipo As Integer)
        Dim CodigoGenerado As String = ""
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
        If Tipo = 1 Then
            CodigoGenerado = textoBase.Replace("{{{A=>-a}}}", fChar)
        End If
        If Tipo = 2 Then
            CodigoGenerado = textoBase.Replace("{{{A=>-a P1}}}", fChar)
        End If
        If Tipo = 3 Then
            CodigoGenerado = textoBase.Replace("{{{A=>-a P2}}}", fChar)
        End If
        Return CodigoGenerado
    End Function
#End Region

#Region "Entrega codigo Tablas relacionadas"
    Function TablasRelacionadas(CodigoOrigen As String,
                                NombreTablaPosUno As String,
                                NombreTablaPosDos As String,
                                CampoPosUno As String,
                                CampoPosDos As String,
                                MascaraCampoPosUno As String,
                                MascaraCampoPosDos As String)
        If InStr(CodigoOrigen, "{{{Tabla_P1}}}") Then
            CodigoOrigen = CodigoOrigen.Replace("{{{Tabla_P1}}}", NombreTablaPosUno)
        End If
        If InStr(CodigoOrigen, "{{{Tabla_P2}}}") Then
            CodigoOrigen = CodigoOrigen.Replace("{{{Tabla_P2}}}", NombreTablaPosDos)
        End If


        If InStr(CodigoOrigen, "{{{Tabla_Min_P1}}}") Then
            NombreTablaPosUno = LCase(NombreTablaPosUno)
            CodigoOrigen = CodigoOrigen.Replace("{{{Tabla_Min_P1}}}", NombreTablaPosUno)
        End If
        If InStr(CodigoOrigen, "{{{Tabla_Min_P2}}}") Then
            NombreTablaPosUno = LCase(NombreTablaPosUno)
            CodigoOrigen = CodigoOrigen.Replace("{{{Tabla_Min_P2}}}", NombreTablaPosDos)
        End If


        If InStr(CodigoOrigen, "{{{Tbl-Camel-P1}}}") Then
            CodigoOrigen = ucaseCamelCaseRelaciones(CodigoOrigen, NombreTablaPosUno, 1)
        End If
        If InStr(CodigoOrigen, "{{{Tbl-Camel-P2}}}") Then
            CodigoOrigen = ucaseCamelCaseRelaciones(CodigoOrigen, NombreTablaPosDos, 2)
        End If


        If InStr(CodigoOrigen, "{{{A=>-a P1}}}") Then
            CodigoOrigen = ConvertirMayusculasMinSeparadasPorGuion(CodigoOrigen, NombreTablaPosUno, 2)
        End If
        If InStr(CodigoOrigen, "{{{A=>-a P2}}}") Then
            CodigoOrigen = ConvertirMayusculasMinSeparadasPorGuion(CodigoOrigen, NombreTablaPosDos, 3)
        End If


        If InStr(CodigoOrigen, "{{{Campo_P1}}}") Then
            CodigoOrigen = CodigoOrigen.Replace("{{{Campo_P1}}}", CampoPosUno)
        End If
        If InStr(CodigoOrigen, "{{{Campo_P2}}}") Then
            CodigoOrigen = CodigoOrigen.Replace("{{{Campo_P2}}}", CampoPosDos)
        End If


        If InStr(CodigoOrigen, "CamMasc") Then
            CodigoOrigen = CodigoOrigen.Replace("CamMasc", MascaraCampoPosUno)
        End If
        If InStr(CodigoOrigen, "CamMasc") Then
            CodigoOrigen = CodigoOrigen.Replace("CamMasc", MascaraCampoPosDos)
        End If

        Return CodigoOrigen
    End Function




#End Region

#Region ""

#End Region
    Function ValidarProcesoTablas(ByVal Texto As String, ByVal ComponenteID As Integer, ProyectoId As Integer)
        Dim CodigoGenerado As String = ""
        Dim Codigo As String = ""
        'Carga tablas
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4_TratamientoTablas(ProyectoId)
        Dim Contador As Integer = SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4DataGridView.Rows.Count
        'Carga contenido segun el componente de tablas 
        SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteID)

        While Contador > 0
            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4DataGridView.CurrentCell = SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4DataGridView.Rows(0).Cells(0)

            Codigo = ProcesarCodigo(CodigoReplaceXTablaTratamientoTablas.Text, NombreTablaTratamientoTablas.Text, 0, 0, 0, 0, MascaraTablaTratamientoTablas.Text)
            Codigo = TratamientoTablasConfiguracion(Codigo, Contador, SaltoDeLineaTablaTratamientoTablas.Checked, SeparadorTablasTratamientoTablas.Text, OmiteSeparadorFinalTabla.Checked)
            CodigoGenerado = CodigoGenerado & Codigo

            SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4DataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While

        Return CodigoGenerado
    End Function

    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4_TratamientoTablas(ProyectoId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4TableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId4,
                                                                                            New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function TratamientoTablasConfiguracion(Texto As String, Contador As Integer, ConSalto As Boolean, Separador As String, OmitirSeparadorFinal As Boolean) As String
        Dim CampoFormato As String = ""

        If ConSalto = True Then
            If Separador = "" Then
                CampoFormato = CampoFormato & vbCrLf & Texto
            Else
                If OmitirSeparadorFinal = False Then
                    CampoFormato = CampoFormato & vbCrLf & Texto & Separador
                Else
                    If Contador = 1 Then
                        CampoFormato = CampoFormato & vbCrLf & Texto
                    Else
                        CampoFormato = CampoFormato & vbCrLf & Texto & Separador
                    End If
                End If
            End If
        Else
            If Separador = "" Then
                CampoFormato = CampoFormato & Texto
            Else
                If OmitirSeparadorFinal = False Then
                    CampoFormato = CampoFormato & Texto & Separador
                Else
                    If Contador = 1 Then
                        CampoFormato = CampoFormato & Texto
                    Else
                        CampoFormato = CampoFormato & Texto & Separador
                    End If
                End If
            End If
        End If

        Return CampoFormato
    End Function

    Private Sub SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                              New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


#End Region
    '--========================FUNCIONALIDADES  OPERACIONALES========--
#Region "Botones Generacion"
    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs) Handles BtnEjecutar.Click
        CodigoGeneradoRichTextBox.Enabled = False
        'Limpiar codigo generado
        CodigoGeneradoRichTextBox.Text = ""
        'Verifica si se crearan archivos y carpetas de proyecto
        If ChkCreaCarpetasYArchivos.Checked = True Then
            CREAR_CARPETAS_ARCHIVOS = True
        Else
            CREAR_CARPETAS_ARCHIVOS = False
        End If
        'Verifica si se creara documento tecnico
        'If ChkCreaDocumentoTecnico.Checked = True Then
        CREAR_DOC_TECNICO = True
        'Else
        '    CREAR_DOC_TECNICO = False
        'End If
        Recorrer_Tecnologias_Aplicadas(CREAR_CARPETAS_ARCHIVOS, CREAR_DOC_TECNICO, ProyectoIdTextBoxBase.Text)
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CodigoGeneradoRichTextBox.Text = ""
        ProgressBarAvance.Value = 0
        SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGenerado(CodigoGeneradoRichTextBox.Text, ProyectoIdTextBoxBase.Text)
    End Sub
    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If CodigoGeneradoRichTextBox.Text <> "" Then
            Clipboard.SetText(CodigoGeneradoRichTextBox.Text)
        End If
        Metodo_Aviso_Acciones(2, "Copiado al portapapeles!!!")
    End Sub

#End Region

#Region "Procedimientos Generacion"
    'Recorre plantillas de implementacion tecnologica por proyecto
    Public Sub Recorrer_Tecnologias_Aplicadas(Crear_Archivos As Boolean, Crear_Documento_Tecnico As Boolean, ProyectoId As Integer)

        Dim contador As Integer = DGVpProyectosTecnologGeneracion.Rows.Count
        If contador = 0 Then
            MsgBox("No se han asignado tecnologias a este proyecto, favor revizar", MsgBoxStyle.Critical)
        Else
            'Barra progresos
            ProgressBarAvance.Value = 0
            Dim barra As Integer = 100 / contador
            Dim ModuloBarra As Integer = 100 Mod contador
            ConstanteProgress = 0
            While contador > 0
                DGVpProyectosTecnologGeneracion.CurrentCell = DGVpProyectosTecnologGeneracion.Rows(0).Cells(0)
                Asignar_Plantilla(Crear_Archivos, Crear_Documento_Tecnico, ProyectoId)
                DGVpProyectosTecnologGeneracion.Rows.RemoveAt(0)
                'Barra progresos
                ConstanteProgress = ConstanteProgress + barra
                If ConstanteProgress <= 100 Then
                    ProgressBarAvance.Value = ConstanteProgress
                Else
                    ProgressBarAvance.Value = 100
                End If
                If ModuloBarra > 0 And contador = 1 Then
                    ProgressBarAvance.Value = 100
                End If
                contador -= 1
            End While
            SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGenerado(CodigoGeneradoRichTextBox.Text, ProyectoIdTextBoxBase.Text)
            SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(ProyectoIdTextBoxBase.Text)
        End If
        Metodo_Aviso_Acciones(2, "Proceso Terminado con Exito!!!")
        If Crear_Archivos = True Then
            Cancelar_PleRutasArchivosTecnologiasRegistro()
            Metodo_Aviso_Acciones(2, "Creación de archivos realizada correctamente")
        End If
        CodigoGeneradoRichTextBox.Enabled = True
    End Sub

    Public Sub Asignar_Plantilla(Crear_Archivos As Boolean, Crear_Documento_Tecnico As Boolean, ProyectoId As Integer)        '
        If XTablaCheckBox.Checked = False And BaseCheckBox.Checked = False Then
            Ruta_Uno(Crear_Archivos)
        ElseIf XTablaCheckBox.Checked = True And BaseCheckBox.Checked = False Then
            Ruta_Dos(ProyectoIdTextBoxBase.Text, Crear_Archivos)
        ElseIf XTablaCheckBox.Checked = False And BaseCheckBox.Checked = True Then
            'ES UN COMPONENTE CON BASE --NO-- LLEVA NADA DE TABLAS NI DE CAMPOS
            Ruta_Tres(Crear_Archivos)
        ElseIf XTablaCheckBox.Checked = True And BaseCheckBox.Checked = True Then
            Ruta_Cuatro(Crear_Archivos)
        End If
    End Sub
    Private Sub Ruta_Uno(Crear_Archivos As Boolean)
        Dim Codigo As String = CodUnoTextBox.Text
        Dim CodigoGenerado As String = CodigoGeneradoRichTextBox.Text
        Dim ComponenteId As Integer = ComponenteIdTextBox.Text
        Dim ProyectoId As Integer = ProyectoIdTextBoxBase.Text

        Codigo = AgregaRequerimientos(Codigo, ComponenteId, ProyectoId)
        CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & NombreComponenteTextBox.Text & vbCrLf & Codigo & vbCrLf
        'CodigoGeneradoRichTextBox.Text = AgregaRequerimientos(CodigoGeneradoRichTextBox.Text, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
        If Crear_Archivos = True Then
            CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, "")
        End If
    End Sub

    Private Sub CreacionDeArchivosYRutas(Codigo As String, ComponenteId As Integer, ProyectoId As Integer, NombreTabla As String)
        'Cargar Ruta componente, esto carga RutaBaseTextBox.Text
        SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId)
        'Procesa la ruta - poner proyecto y 
        RutaBaseTextBox.Text = ReplaceRuta(RutaBaseTextBox.Text, NombreProyectoTextBox.Text, "")
        RutaBaseTextBox.Text = AgregaRequerimientos(RutaBaseTextBox.Text, ComponenteId, ProyectoId)
        RutaBaseTextBox.Text = ProcesarCodigo(RutaBaseTextBox.Text, NombreTabla, "", 0, 0, 0, "")
        'Procesa el archivo - pone extension, reviza requerimientos - reviza si hay nombres de tablas
        NombreArchivoTextBox.Text = ReplaceRuta(NombreArchivoTextBox.Text, NombreProyectoTextBox.Text, "") & ExtensionTextBox.Text
        NombreArchivoTextBox.Text = AgregaRequerimientos(NombreArchivoTextBox.Text, ComponenteId, ProyectoId)
        NombreArchivoTextBox.Text = ProcesarCodigo(NombreArchivoTextBox.Text, NombreTabla, "", 0, 0, 0, "")
        'Guarda
        SP_PleRutasArchivosTecnologiasRegistro_EDICION_INSERTAR(ProyectoId, RutaBaseTextBox.Text, NombreArchivoTextBox.Text, ExtensionTextBox.Text, Codigo, False)
    End Sub

    Private Sub Ruta_Dos(ProyectoId As Integer, Crear_Archivos As Boolean)
        Dim Codigo As String = CodUnoTextBox.Text
        Dim CodigoGenerado As String = CodigoGeneradoRichTextBox.Text
        Dim ComponenteId As Integer = ComponenteIdTextBox.Text

        'Carga las tablas
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generacion(ProyectoId)
        Dim contador As Integer = DGVTablasDeProyecto.Rows.Count
        If contador > 0 Then
            While contador > 0
                DGVTablasDeProyecto.CurrentCell = DGVTablasDeProyecto.Rows(0).Cells(0)
                If TipoTextBox_Generacion.Text = "Tipo 1" Then
                    Codigo = ProcesarCodigo(CodUnoTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 2" Then
                    Codigo = ProcesarCodigo(CodDosTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 3" Then
                    Codigo = ProcesarCodigo(CodTresTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 4" Then
                    Codigo = ProcesarCodigo(CodCuatroTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 5" Then
                    Codigo = ProcesarCodigo(CodCincoTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 6" Then
                    Codigo = ProcesarCodigo(CodSeisTextBox.Text, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteIdTextBox.Text, TablaId_Generacion.Text, ProyectoId, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoId)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteId, ProyectoId, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                DGVTablasDeProyecto.Rows.RemoveAt(0)
                contador -= 1
            End While
        Else
            MsgBox("Este proyecto no tiene Tablas Asignadas", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Ruta_Tres(Crear_Archivos As Boolean)
        Dim CodigoGenerado = ProcesarCodigoConBase(0)
        CodigoGenerado = AgregaRequerimientos(CodigoGenerado, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
        If Crear_Archivos = True Then
            CreacionDeArchivosYRutas(CodigoGenerado, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
        End If
        CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & CodigoGenerado
    End Sub
    Private Sub Ruta_Cuatro(Crear_Archivos As Boolean)

        'Variables para la captura de la informacion
        Dim Codigo As String
        'Carga las tablas
        SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generacion(ProyectoIdTextBoxBase.Text)
        Dim contador As Integer = DGVTablasDeProyecto.Rows.Count
        If contador > 0 Then
            While contador > 0
                DGVTablasDeProyecto.CurrentCell = DGVTablasDeProyecto.Rows(0).Cells(0)
                If TipoTextBox_Generacion.Text = "Tipo 1" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 2" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 3" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 4" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 5" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                If TipoTextBox_Generacion.Text = "Tipo 6" Then
                    Codigo = ProcesarCodigoConBase(TablaId_Generacion.Text)
                    Codigo = ProcesarCodigo(Codigo, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, 0, TablaId_Generacion.Text, ProyectoIdTextBoxBase.Text, MascaraTablaTextBox_Generacion.Text)
                    Codigo = AgregaRequerimientos(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text)
                    If Crear_Archivos = True Then
                        CreacionDeArchivosYRutas(Codigo, ComponenteIdTextBox.Text, ProyectoIdTextBoxBase.Text, NombreTablaTextBox_Generacion.Text)
                    End If
                    CodigoGeneradoRichTextBox.Text = CodigoGeneradoRichTextBox.Text & vbCrLf & Codigo
                End If
                DGVTablasDeProyecto.Rows.RemoveAt(0)
                contador -= 1
            End While
        End If
    End Sub
    Function ProcesarCodigoConBase(TablaId As Integer)

        Dim CodigoGenerado As String = ""
        Dim Contenido As String = ""
        Dim ContenidoAnalizar As String = ""
        Dim comparador As Integer = SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows.Count
        Dim contador As Integer = SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows.Count
        Me.SP_PleComponentesConBase_TruncateTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentesConBase_Truncate)
        While contador > 0
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.CurrentCell = SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows(0).Cells(0)
            If contador = comparador Then
                Contenido = CodUnoTextBox.Text
                SP_PleComponentesConBase_EDICION_INSERTAR(0, PlantillaIdTextBoxGeneracion.Text, True, NombreComponenteTextBox.Text, Contenido, ComponenteIdTextBox.Text)
            Else
                Contenido = CodUnoTextBox.Text
                SP_PleComponentesConBase_EDICION_INSERTAR(0, PlantillaIdTextBoxGeneracion.Text, False, NombreComponenteTextBox.Text, Contenido, ComponenteIdTextBox.Text)
            End If
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows.RemoveAt(0)
            contador -= 1
        End While
        'Carga el componente base insertado
        SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_Base(PlantillaIdTextBoxGeneracion.Text)
        GuardaRetornaActualizado(ContenidoCompBase.Text)
        'Carga los complementos del base
        SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_Base(PlantillaIdTextBoxGeneracion.Text)

        ContenidoAnalizar = ContenidoCompBase.Text
        'Recorre los complementos
        Dim ContadorCteBase = SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_BaseDataGridView.Rows.Count
        While ContadorCteBase > 0

            SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_BaseDataGridView.CurrentCell = SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_BaseDataGridView.Rows(0).Cells(0)
            'Recupera guardada de la base Informacion
            Me.SP_PleContenidoEstandar_CargaTableAdapter.Fill(Me.DataSetMaestros.SP_PleContenidoEstandar_Carga)
            'Remplaza en esta los no base
            CodigoGenerado = ContenidoStandardTextBox.Text.Replace(ReferenciaComplementoTextBox.Text, ContenidoCompBaseComplemento.Text)
            'Remplaza componentes
            CodigoGenerado = ProcesarCodigo(CodigoGenerado, NombreTablaTextBox_Generacion.Text, TipoTextBox_Generacion.Text, ComponenteId_No_Base.Text, TablaId, 0, MascaraTablaTextBox_Generacion.Text)
            'Guarda lo remplazado
            CodigoGenerado = GuardaRetornaActualizado(CodigoGenerado)
            SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_BaseDataGridView.Rows.RemoveAt(0)
            ContadorCteBase -= 1
        End While
        SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBoxGeneracion.Text)

        Return CodigoGenerado
    End Function

    Function AgregaRequerimientos(Contenido As String, ComponenteId As Integer, ProyectoId As Integer)
        Dim ContenidoGeneral As String = ""
        Dim Contador As Integer = SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count
        While Contador > 0
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentCell = SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(0).Cells(0)
            If InStr(Contenido, NombreRequerimientoTextBox1.Text) Then
                ContenidoGeneral = Contenido.Replace(NombreRequerimientoTextBox1.Text, ValorRequerimientoTextBox.Text)
                ContenidoGeneral = GuardaRetornaActualizado(ContenidoGeneral)
                Contenido = ContenidoStandardTextBox.Text
            End If
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleRequerimientosCompRegistro()

        If InStr(Contenido, "{{{Tabla-G}}}") Then
            Dim CodigoGenerado As String = ValidarProcesoTablas(Contenido, ComponenteId, ProyectoId)
            Contenido = Contenido.Replace("{{{Tabla-G}}}", CodigoGenerado)
        End If

        Return Contenido
    End Function

#End Region

#Region "Metodos"
    'Carga los componentes segun plantilla
    Private Sub SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaId As Integer)
        Try
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId,
                                                                                       New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga proyectos y tecnologias segun proyecto
    Private Sub SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generar(ProyectoId As Integer)
        Try
            Me.SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1TableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectosYTecnologiasView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId1,
                                                                                                     New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga las tablas del proyecto
    Private Sub SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId_Generacion(ProyectoId As Integer)
        Try
            Me.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId3TableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId3,
                                                                                            New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Guarda los componentes con base y sin base
    Private Sub SP_PleComponentesConBase_EDICION_INSERTAR(TablaId As Integer,
                                                          PlantillaId As Integer,
                                                          Base As Boolean,
                                                          ReferenciaComplemento As String,
                                                          ContenidoCompBase As String,
                                                          ComponenteId As Integer)
        Try
            Me.SP_PleComponentesConBase_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentesConBase_EDICION_INSERTAR,
                                                                          New System.Nullable(Of Integer)(CType(TablaId, Integer)),
                                                                          New System.Nullable(Of Integer)(CType(PlantillaId, Integer)),
                                                                          New System.Nullable(Of Boolean)(CType(Base, Boolean)),
                                                                          ReferenciaComplemento,
                                                                          ContenidoCompBase,
                                                                          ComponenteId)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Busca el componente con base
    Private Sub SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_Base(PlantillaId As Integer)
        Try
            Me.SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_BaseTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_Base,
                                                                                       New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    'Busca los componentes que no son base
    Private Sub SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_Base(PlantillaId As Integer)
        Try
            Me.SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_BaseTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentesConBase_BUSQUEDA_SEGUN_PARAMETRO_No_Base,
                                                                                          New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region
    '--========================FIN===================================--

    '--========================GENERICAS=============================--
#Region "Funciones Genericas"
    Function GuardaRetornaActualizado(Contenido As String)
        Dim ContenidoGenerado As String
        'Trunca la tabla
        Me.SP_PleContenidoEstandar_TruncarTableAdapter.Fill(Me.DataSetMaestros.SP_PleContenidoEstandar_Truncar)
        'Guarda Informacion
        SP_PleContenidoEstandar_EDICION_INSERTAR(Contenido)
        'Recupera Informacion
        Me.SP_PleContenidoEstandar_CargaTableAdapter.Fill(Me.DataSetMaestros.SP_PleContenidoEstandar_Carga)
        'Retorna la informacion
        ContenidoGenerado = ContenidoStandardTextBox.Text
        Return ContenidoGenerado
    End Function
    Private Sub SP_PleContenidoEstandar_EDICION_INSERTAR(ContenidoStandard As String)
        Try
            Me.SP_PleContenidoEstandar_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleContenidoEstandar_EDICION_INSERTAR, ContenidoStandard)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PleContenidoEstandar_EDICION_ACTUALIZAR(Id As Integer, ContenidoStandard As String)
        Try
            Me.SP_PleContenidoEstandar_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleContenidoEstandar_EDICION_ACTUALIZAR,
                                                                           New System.Nullable(Of Integer)(CType(Id, Integer)),
                                                                           ContenidoStandard)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId_CAMPOS_DE_TABLA(TablaId As Integer)
        Try
            Me.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId3TableAdapter.Fill(Me.DataSetMaestros.SP_PleCampDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaId3,
                                                                                     New System.Nullable(Of Integer)(CType(TablaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub




#End Region
    '--========================FIN===================================--


    Private Sub SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId,
                                                                                                               New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--========================INICIO==================================--

#Region "TODO PleRequerimientosCompRegistro"

    '--==============================================================--


    Private Sub SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId, New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '--==============================================================--

    Sub Cancelar_PleRequerimientosCompRegistro()
        'Botones Del Menu
        Nuevo_Menu_PleRequerimientosCompRegistro.Enabled = True
        Guardar_Menu_PleRequerimientosCompRegistro.Enabled = False
        Editar_Menu_PleRequerimientosCompRegistro.Enabled = True
        Actualizar_Menu_PleRequerimientosCompRegistro.Enabled = False
        Eliminar_Menu_PleRequerimientosCompRegistro.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ProyectoIdTextBoxBase.Text <> "" Then
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        Else
            SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
        End If
        Bloquear_Objetos_PleRequerimientosCompRegistro()
        Parar_Timer_PleRequerimientosCompRegistro()
        Timer_Ubicar_En_Fila_PleRequerimientosCompRegistro()
    End Sub

    '--==============================================================--

    'Insertar PleRequerimientosCompRegistro
    Private Sub SP_PleRequerimientosCompRegistro_EDICION_INSERTAR(PleRequerimientosId As Integer,
ValorRequerimiento As String,
ProyectoId As Integer
)
        Try
            Me.SP_PleRequerimientosCompRegistro_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosCompRegistro_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PleRequerimientosId, Integer)),
                                                 ValorRequerimiento,
                                                 New System.Nullable(Of Integer)(CType(ProyectoId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleRequerimientosCompRegistro")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleRequerimientosCompRegistro
    Private Sub SP_PleRequerimientosCompRegistro_EDICION_ACTUALIZAR(PleRequerimientosCompRegistroId As Integer,
PleRequerimientosId As Integer,
ValorRequerimiento As String,
ProyectoId As Integer
)

        Try
            Me.SP_PleRequerimientosCompRegistro_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosCompRegistro_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleRequerimientosCompRegistroId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PleRequerimientosId, Integer)),
                                                 ValorRequerimiento,
                                                 New System.Nullable(Of Integer)(CType(ProyectoId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleRequerimientosCompRegistro")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR(PleRequerimientosCompRegistroId As Integer)
        Try
            Me.SP_PleRequerimientosCompRegistro_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleRequerimientosCompRegistroId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleRequerimientosCompRegistro Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleRequerimientosCompRegistro()
        ValorRequerimientoTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleRequerimientosCompRegistro()
        ValorRequerimientoTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleRequerimientosCompRegistro()
        ValorRequerimientoTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleRequerimientosCompRegistro()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleRequerimientosCompRegistro.Click
        Nuevo_Menu_PleRequerimientosCompRegistro.Enabled = False
        Editar_Menu_PleRequerimientosCompRegistro.Enabled = False
        ValidarCierre.Text = 1
        SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = False
        Limpiar_Objetos_PleRequerimientosCompRegistro()
        ValorRequerimientoTextBox.Enabled = True
        ValorRequerimientoTextBox.Focus()
    End Sub

    Private Sub BtnSolicitarRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnSolicitarRequerimientos.Click
        Dim Contador As Integer = SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoIdDataGridView.Rows.Count
        While Contador
            SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoIdDataGridView.CurrentCell = SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoIdDataGridView.Rows(0).Cells(0)
            ValorRequerimientoTextBox.Text = InputBox("Ingresa:= " & NombreRequerimientoTextBox.Text, Title:="INGRESO VALORES DE REQUERIMIENTOS")
            SP_PleRequerimientosCompRegistro_EDICION_INSERTAR(PleRequerimientosIdTextBox.Text, ValorRequerimientoTextBox.Text, ProyectoIdTextBoxBase.Text)
            SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        SP_PleCargaRequerimientosTecnologiasAplicadasPorProyectosView_SEGUN_ProyectoId(ProyectoIdTextBoxBase.Text)
        Cancelar_PleRequerimientosCompRegistro()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleRequerimientosCompRegistro.Click
        Control_Nulos_PleRequerimientosCompRegistro()

        If ControlNulos.Text = "" Then
            SP_PleRequerimientosCompRegistro_EDICION_INSERTAR(
        PleRequerimientosIdTextBox.Text,
        ValorRequerimientoTextBox.Text,
        ProyectoIdTextBoxBase.Text
)
            Cancelar_PleRequerimientosCompRegistro()
            Parar_Timer_PleRequerimientosCompRegistro()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleRequerimientosCompRegistro.Click
        Nuevo_Menu_PleRequerimientosCompRegistro.Enabled = False
        Guardar_Menu_PleRequerimientosCompRegistro.Enabled = False
        Editar_Menu_PleRequerimientosCompRegistro.Enabled = False
        Actualizar_Menu_PleRequerimientosCompRegistro.Enabled = True
        Eliminar_Menu_PleRequerimientosCompRegistro.Enabled = True
        SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleRequerimientosCompRegistro()
        Timer_Actualizar_PleRequerimientosCompRegistro()
        Timer_Eliminar_PleRequerimientosCompRegistro()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleRequerimientosCompRegistro.Click
        Control_Nulos_PleRequerimientosCompRegistro()

        If ControlNulos.Text = "" Then
            SP_PleRequerimientosCompRegistro_EDICION_ACTUALIZAR(
        PleRequerimientosCompRegistroIdTextBox.Text,
        PleRequerimientosIdTextBox.Text,
        ValorRequerimientoTextBox.Text,
        ProyectoIdTextBoxBase.Text
)
            Cancelar_PleRequerimientosCompRegistro()
            Parar_Timer_PleRequerimientosCompRegistro()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRequerimientosCompRegistro.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR(PleRequerimientosCompRegistroIdTextBox.Text)
            Cancelar_PleRequerimientosCompRegistro()
            Parar_Timer_PleRequerimientosCompRegistro()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRequerimientosCompRegistro()
        End If
    End Sub

    Private Sub SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR_ProyectoId,
                                                                                             New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleRequerimientosCompRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleRequerimientosCompRegistro.Click
        Cancelar_PleRequerimientosCompRegistro()
    End Sub

    Private Sub BtnEliminarTodosRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodosRequerimientos.Click
        If SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count > 0 Then
            If MsgBox("Desea eliminar todos los requerimientos para este proyecto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR_ProyectoId(ProyectoIdTextBoxBase.Text)
                Cancelar_PleRequerimientosCompRegistro()
                Metodo_Aviso_Acciones(2, "Se eliminan todos los requerimientos para este proyecto Existosamente")
            Else
                MsgBox("Se cancelo la instrucción", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    '--==============================================================--
    'Navegacion

    Private Sub ValorRequerimientoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ValorRequerimientoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleRequerimientosCompRegistro.Enabled = True Then
                Actualizar_Menu_PleRequerimientosCompRegistro.Enabled = True
                Eliminar_Menu_PleRequerimientosCompRegistro.Enabled = True
            Else
                'If ProyectoIdTextBox.Text = "" Then
                '    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                '    ProyectoIdTextBox.Text = ""
                '    ProyectoIdTextBox.Focus()
                'Else
                MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                Guardar_Menu_PleRequerimientosCompRegistro.Enabled = True
                Timer_Guardar_PleRequerimientosCompRegistro()
                'End If
            End If
        End If
    End Sub



    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleRequerimientosCompRegistro As Timer
    Private WithEvents Timer_Actualizar_Menu_PleRequerimientosCompRegistro As Timer
    Private WithEvents Timer_Eliminar_Menu_PleRequerimientosCompRegistro As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleRequerimientosCompRegistro()
        Me.Timer_Guardar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Guardar_Menu_PleRequerimientosCompRegistro.Interval = 250
        Timer_Guardar_Menu_PleRequerimientosCompRegistro.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleRequerimientosCompRegistro()
        Me.Timer_Actualizar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Actualizar_Menu_PleRequerimientosCompRegistro.Interval = 500
        Timer_Actualizar_Menu_PleRequerimientosCompRegistro.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleRequerimientosCompRegistro()
        Me.Timer_Eliminar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Eliminar_Menu_PleRequerimientosCompRegistro.Interval = 800
        Timer_Eliminar_Menu_PleRequerimientosCompRegistro.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleRequerimientosCompRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleRequerimientosCompRegistro.Tick
        If Guardar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White Then
            Guardar_Menu_PleRequerimientosCompRegistro.BackColor = Color.Green
        Else
            Guardar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleRequerimientosCompRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleRequerimientosCompRegistro.Tick
        If Actualizar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White Then
            Actualizar_Menu_PleRequerimientosCompRegistro.BackColor = Color.Green
        Else
            Actualizar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleRequerimientosCompRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleRequerimientosCompRegistro.Tick
        If Eliminar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White Then
            Eliminar_Menu_PleRequerimientosCompRegistro.BackColor = Color.Red
        Else
            Eliminar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleRequerimientosCompRegistro()
        Me.Timer_Guardar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Guardar_Menu_PleRequerimientosCompRegistro.Stop()
        Guardar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Actualizar_Menu_PleRequerimientosCompRegistro.Stop()
        Actualizar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleRequerimientosCompRegistro = New Timer
        Timer_Eliminar_Menu_PleRequerimientosCompRegistro.Stop()
        Eliminar_Menu_PleRequerimientosCompRegistro.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleRequerimientosCompRegistro As Timer
    Dim X_PleRequerimientosCompRegistro
    Private Sub Timer_Ubicar_En_Fila_PleRequerimientosCompRegistro()
        Me.Timer_Ubicacion_PleRequerimientosCompRegistro = New Timer
        Timer_Ubicacion_PleRequerimientosCompRegistro.Interval = 100
        Timer_Ubicacion_PleRequerimientosCompRegistro.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CellMouseClick
        X_PleRequerimientosCompRegistro = SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleRequerimientosCompRegistro()
        Try
            Me.SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(X_PleRequerimientosCompRegistro).Selected = True
            Me.SP_PleRequerimientosCompRegistroView_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleRequerimientosCompRegistro
        Catch ex As Exception
        End Try
    End Sub


    '--==============================================================--

    Private Sub Timer_Ubicacion_PleRequerimientosCompRegistro_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleRequerimientosCompRegistro.Tick
        Ubicar_En_Fila_PleRequerimientosCompRegistro()
        Timer_Ubicacion_PleRequerimientosCompRegistro.Stop()
    End Sub









#End Region

#End Region

#End Region


    Private Sub BtnGenerarArchivos_Click(sender As Object, e As EventArgs) Handles BtnGenerarArchivos.Click
        Dim Contador = SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count()
        While Contador > 0
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentCell = SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(0).Cells(0)
            CreacionDeArchivos(RutaBaseRegistro.Text, NombreArchivoRegistro.Text, ContenidoArchivoRichTextBoxRegistro.Text)
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleRutasArchivosTecnologiasRegistro()
    End Sub
    Private Sub BtnSoloSeleccionados_Click(sender As Object, e As EventArgs) Handles BtnSoloSeleccionados.Click
        Dim Contador = SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count()
        While Contador > 0
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentCell = SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(0).Cells(0)
            If SeleccionadoCheckBoxRegistro.Checked = True Then
                CreacionDeArchivos(RutaBaseRegistro.Text, NombreArchivoRegistro.Text, ContenidoArchivoRichTextBoxRegistro.Text)
            End If
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleRutasArchivosTecnologiasRegistro()
    End Sub
    Private Sub BtnCopiarGenerado_Click(sender As Object, e As EventArgs) Handles BtnCopiarGenerado.Click
        If ContenidoArchivoRichTextBoxRegistro.Text <> "" Then
            Clipboard.SetText(ContenidoArchivoRichTextBoxRegistro.Text)
        End If
        Metodo_Aviso_Acciones(2, "Copiado al portapapeles!!!")
    End Sub
    'Carga rutas y archivos segun proyecto
    Private Sub SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId, New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Carga 
    Private Sub SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                     New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ContenidoArchivoRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ContenidoArchivoRichTextBoxRegistro.MouseDoubleClick
        If ContenidoArchivoRichTextBoxRegistro.Dock = DockStyle.None Then
            ContenidoArchivoRichTextBoxRegistro.Dock = DockStyle.Fill
            ContenidoArchivoRichTextBoxRegistro.BringToFront()
        Else
            ContenidoArchivoRichTextBoxRegistro.Dock = DockStyle.None
            ContenidoArchivoRichTextBoxRegistro.SendToBack()
        End If
    End Sub

    '--=== INICIO

#Region "TODO PleRutasArchivosTecnologiasRegistro"




    '--=== CANCELACIÓN 

    Sub Cancelar_PleRutasArchivosTecnologiasRegistro()
        If ProyectoIdTextBoxBase.Text <> "" Then
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        Else
            SP_PleRutasArchivosTecnologiasRegistro_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(0)
        End If
    End Sub

    '--=== INSERTAR 

    'Insertar PleRutasArchivosTecnologiasRegistro
    Private Sub SP_PleRutasArchivosTecnologiasRegistro_EDICION_INSERTAR(ProyectoId As Integer,
RutaBase As String,
NombreArchivo As String,
Extension As String,
ContenidoArchivo As String,
Seleccionado As Boolean
)
        Try
            Me.SP_PleRutasArchivosTecnologiasRegistro_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologiasRegistro_EDICION_INSERTAR,
                                                            New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                            RutaBase,
                                                            NombreArchivo,
                                                            Extension,
                                                            ContenidoArchivo,
                                                            New System.Nullable(Of Integer)(CType(Seleccionado, Integer))
)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleRutasArchivosTecnologiasRegistro
    Private Sub SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR(PleRutasArchivosTecnologiasRegistroId As Integer, Seleccionado As Boolean)
        Try
            Me.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR_Segun_SeleccionadoTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR_Segun_Seleccionado,
                                                                                                               New System.Nullable(Of Integer)(CType(PleRutasArchivosTecnologiasRegistroId, Integer)), New System.Nullable(Of Boolean)(CType(Seleccionado, Boolean)))
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleRutasArchivosTecnologiasRegistro")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR(PleRutasArchivosTecnologiasRegistroId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleRutasArchivosTecnologiasRegistroId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleRutasArchivosTecnologiasRegistro Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub









    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleRutasArchivosTecnologiasRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRutasArchivosTecnologiasRegistro.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR(PleRutasArchivosTecnologiasRegistroIdTextBox.Text)
            Cancelar_PleRutasArchivosTecnologiasRegistro()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRutasArchivosTecnologiasRegistro()
        End If
    End Sub

    Private Sub Eliminar_Menu_PleRutasArchivosTecnologiasRegistroAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRutasArchivosTecnologiasRegistroAll.Click
        If MsgBox("Desea Eliminar Todos los registros de este proyecto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR_Segun_ProyectoId(ProyectoIdTextBoxBase.Text)
            Cancelar_PleRutasArchivosTecnologiasRegistro()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRutasArchivosTecnologiasRegistro()
        End If
    End Sub

    Private Sub SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR_Segun_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR_Segun_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR_Segun_ProyectoId,
                                                                                                         New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub CreacionDeArchivos(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String)

        If My.Computer.FileSystem.FileExists(Ruta) Then
            My.Computer.FileSystem.WriteAllText(Ruta + "\" + Archivo, Contenido, True)
            Metodo_Aviso_Acciones(5, "Archivo ya existe")
        Else
            My.Computer.FileSystem.CreateDirectory(Ruta)
            Dim path As String = Ruta + "\" + Archivo
            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)
            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Contenido)
            fs.Write(info, 0, info.Length)
            fs.Close()
        End If
    End Sub



    Function ReplaceRuta(Ruta As String, Proyecto As String, Tabla As String)
        Dim RutaResultado As String = ""

        If Proyecto <> "" Then
            If InStr(Ruta, "ProyectoTrabajado") Then
                RutaResultado = Ruta.Replace("ProyectoTrabajado", Proyecto)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            Else
                RutaResultado = Ruta
            End If
        End If

        If Tabla <> "" Then
            If InStr(Ruta, "{{{Tabla}}}") Then
                RutaResultado = RutaResultado.Replace("{{{Tabla}}}", Tabla)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{Tbl-Camel}}}") Then
                Dim formato As String = "Camel-Case"
                Dim TablaCamel = TratamientoFormatoCampo(Tabla, formato)
                RutaResultado = RutaResultado.Replace("{{{Tbl-Camel}}}", TablaCamel)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{Tmin}}}") Then
                Dim Tablamin As String
                Tablamin = LCase(Tabla)
                RutaResultado = RutaResultado.Replace("{{{Tmin}}}", Tablamin)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{A=>-a}}}") Then
                RutaResultado = ConvertirMayusculasMinSeparadasPorGuion(Ruta, Tabla, 1)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If
        End If

        Return RutaResultado
    End Function






#End Region


#Region "Metricas De Proyecto"

    Public Sub MetricaDeTiempo()
        SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
        Dim Contador As Integer = SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count
        Dim Tiempo As Integer = 0
        Dim TiempoHoras As Integer = 0
        While Contador > 0
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.CurrentCell = SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows(0).Cells(0)
            If PorTablaCheckBox.Checked = True Then
                Tiempo = Tiempo + (TiempoTextBox.Text * SP_PleTablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.Count)
            Else
                Tiempo = Tiempo + TiempoTextBox.Text
            End If
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        TiempoHoras = Tiempo / 60
        TiempoEstimadoTextBox.Text = TiempoHoras
        SP_PleProyectos_EDICION_ACTUALIZAR_TIEMPO_ESTIMADO(ProyectoIdTextBoxBase.Text, TiempoHoras)
        SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoIdTextBoxBase.Text)
    End Sub

    Private Sub SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId(ProyectoId As Integer)
        Try
            Me.SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ProyectoId,
                                                                                   New System.Nullable(Of Integer)(CType(ProyectoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PleProyectos_EDICION_ACTUALIZAR_TIEMPO_ESTIMADO(ProyectoId As Integer, TiempoEstimado As Integer)
        Try
            Me.SP_PleProyectos_EDICION_ACTUALIZAR_TIEMPO_ESTIMADOTableAdapter.Fill(Me.DataSetMaestros.SP_PleProyectos_EDICION_ACTUALIZAR_TIEMPO_ESTIMADO,
                                                                                   New System.Nullable(Of Integer)(CType(ProyectoId, Integer)),
                                                                                   New System.Nullable(Of Integer)(CType(TiempoEstimado, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnCrearCarpetaProyecto_Click(sender As Object, e As EventArgs) Handles BtnCrearCarpetaProyecto.Click

    End Sub

#End Region






End Class