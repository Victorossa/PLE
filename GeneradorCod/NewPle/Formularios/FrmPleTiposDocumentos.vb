Public Class FrmPleTiposDocumentos

    'Crear formulario FrmPleTipoDeDocumento
    'Tipo de letra : Microsoft Tai Le; 12pt
    'Autoscroll : True
    'FormBorderStyle = None
    'Traer de utilidades los botones y validadores, copiarlos y pegarlos y poner los nombres
    'Nuevo_Menu_PleTipoDeDocumento
    'Guardar_Menu_PleTipoDeDocumento
    'Editar_Menu_PleTipoDeDocumento
    'Actualizar_Menu_PleTipoDeDocumento
    'Eliminar_Menu_PleTipoDeDocumento
    'Cancelar_Menu_PleTipoDeDocumento
    'Salir_Menu_PleTipoDeDocumento
    'ForeColor: 37; 46; 56

    'Grid con Anchor Top, Left, Right

    '--=== INICIO

#Region "TODO PleTipoDeDocumento"

    '--==============================================================--
    Private Sub FrmPleTipoDeDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Metodo_Aviso_Acciones(2, "Bienvenido a la Creación de PleTipoDeDocumento")
        Me.PleTipoDeDocumentoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDeDocumento)
        Cancelar_PleTipoDeDocumento()
    End Sub
    '--==============================================================--

#Region "Mensajeria"

    '--=== MENSAJERIA 

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

    '--=== CANCELACIÓN 

    Sub Cancelar_PleTipoDeDocumento()
        'Botones Del Menu
        Nuevo_Menu_PleTipoDeDocumento.Enabled = True
        Guardar_Menu_PleTipoDeDocumento.Enabled = False
        Editar_Menu_PleTipoDeDocumento.Enabled = True
        Actualizar_Menu_PleTipoDeDocumento.Enabled = False
        Eliminar_Menu_PleTipoDeDocumento.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleTipoDeDocumentoDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleTipoDeDocumentoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDeDocumento)
        Bloquear_Objetos_PleTipoDeDocumento()
        Parar_Timer_PleTipoDeDocumento()
        Timer_Ubicar_En_Fila_PleTipoDeDocumento()
    End Sub

    '--=== INSERTAR 

    'Insertar PleTipoDeDocumento
    Private Sub SP_PleTipoDeDocumento_EDICION_INSERTAR(NombreTipoDocumento As String
)
        Try
            Me.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDeDocumento_EDICION_INSERTAR,
                                                            NombreTipoDocumento
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTipoDeDocumento")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleTipoDeDocumento
    Private Sub SP_PleTipoDeDocumento_EDICION_ACTUALIZAR(TipoDeDocumentoId As Integer,
NombreTipoDocumento As String
)

        Try
            Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDeDocumento_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TipoDeDocumentoId, Integer)),
                                                            NombreTipoDocumento
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTipoDeDocumento")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleTipoDeDocumento_EDICION_ELIMINAR(TipoDeDocumentoId As Integer)
        Try
            Me.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDeDocumento_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TipoDeDocumentoId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTipoDeDocumento Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleTipoDeDocumento()
        NombreTipoDocumentoTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTipoDeDocumento()
        NombreTipoDocumentoTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTipoDeDocumento()
        NombreTipoDocumentoTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleTipoDeDocumento()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreTipoDocumentoTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo de documento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTipoDocumentoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTipoDeDocumento.Click
        Nuevo_Menu_PleTipoDeDocumento.Enabled = False
        Editar_Menu_PleTipoDeDocumento.Enabled = False
        ValidarCierre.Text = 1
        PleTipoDeDocumentoDataGridView.Enabled = False
        Limpiar_Objetos_PleTipoDeDocumento()
        NombreTipoDocumentoTextBox.Enabled = True
        NombreTipoDocumentoTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTipoDeDocumento.Click
        Control_Nulos_PleTipoDeDocumento()

        If ControlNulos.Text = "" Then
            SP_PleTipoDeDocumento_EDICION_INSERTAR(NombreTipoDocumentoTextBox.Text
)
            Cancelar_PleTipoDeDocumento()
            Parar_Timer_PleTipoDeDocumento()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTipoDeDocumento.Click
        Nuevo_Menu_PleTipoDeDocumento.Enabled = False
        Guardar_Menu_PleTipoDeDocumento.Enabled = False
        Editar_Menu_PleTipoDeDocumento.Enabled = False
        Actualizar_Menu_PleTipoDeDocumento.Enabled = True
        Eliminar_Menu_PleTipoDeDocumento.Enabled = True
        PleTipoDeDocumentoDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTipoDeDocumento()
        Timer_Actualizar_PleTipoDeDocumento()
        Timer_Eliminar_PleTipoDeDocumento()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTipoDeDocumento.Click
        Control_Nulos_PleTipoDeDocumento()

        If ControlNulos.Text = "" Then
            SP_PleTipoDeDocumento_EDICION_ACTUALIZAR(TipoDeDocumentoIdTextBox.Text,
        NombreTipoDocumentoTextBox.Text
)
            Cancelar_PleTipoDeDocumento()
            Parar_Timer_PleTipoDeDocumento()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTipoDeDocumento.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTipoDeDocumento_EDICION_ELIMINAR(TipoDeDocumentoIdTextBox.Text)
            Cancelar_PleTipoDeDocumento()
            Parar_Timer_PleTipoDeDocumento()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTipoDeDocumento()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleTipoDeDocumento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTipoDeDocumento.Click
        Cancelar_PleTipoDeDocumento()
    End Sub

    '--=== SALIR

    'Salir
    Private Sub Salir_Menu_PleTipoDeDocumento_Click(sender As Object, e As EventArgs) Handles Salir_Menu_PleTipoDeDocumento.Click
        If ValidarCierre.Text = "" Then
            Me.Close()
        Else
            Metodo_Aviso_Acciones(3, "Accion en proceso")
        End If
    End Sub

    '--=== NAVEGACIÓN

    Private Sub NombreTipoDocumentoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTipoDocumentoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTipoDeDocumento.Enabled = True Then
                Actualizar_Menu_PleTipoDeDocumento.Enabled = True
                Eliminar_Menu_PleTipoDeDocumento.Enabled = True
            Else
                If NombreTipoDocumentoTextBox.Text = "" Then
                    MsgBox("El Dato: Tipo de documento es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    NombreTipoDocumentoTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTipoDeDocumento.Enabled = True
                    Timer_Guardar_PleTipoDeDocumento()
                End If
            End If
        End If
        ' Primera en mayuscula
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreTipoDocumentoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreTipoDocumentoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreTipoDocumentoTextBox.Text = ""
            NombreTipoDocumentoTextBox.Text = Caracter
            NombreTipoDocumentoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreTipoDocumentoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreTipoDocumentoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreTipoDocumentoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreTipoDocumentoTextBox.Text = ""
            NombreTipoDocumentoTextBox.Text = Temp + Caracter
            NombreTipoDocumentoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub


    '--=== ESPECIALES



    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTipoDeDocumento As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTipoDeDocumento As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTipoDeDocumento As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTipoDeDocumento()
        Me.Timer_Guardar_Menu_PleTipoDeDocumento = New Timer
        Timer_Guardar_Menu_PleTipoDeDocumento.Interval = 250
        Timer_Guardar_Menu_PleTipoDeDocumento.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTipoDeDocumento()
        Me.Timer_Actualizar_Menu_PleTipoDeDocumento = New Timer
        Timer_Actualizar_Menu_PleTipoDeDocumento.Interval = 500
        Timer_Actualizar_Menu_PleTipoDeDocumento.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTipoDeDocumento()
        Me.Timer_Eliminar_Menu_PleTipoDeDocumento = New Timer
        Timer_Eliminar_Menu_PleTipoDeDocumento.Interval = 800
        Timer_Eliminar_Menu_PleTipoDeDocumento.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTipoDeDocumento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTipoDeDocumento.Tick
        If Guardar_Menu_PleTipoDeDocumento.BackColor = Color.White Then
            Guardar_Menu_PleTipoDeDocumento.BackColor = Color.Green
        Else
            Guardar_Menu_PleTipoDeDocumento.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTipoDeDocumento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTipoDeDocumento.Tick
        If Actualizar_Menu_PleTipoDeDocumento.BackColor = Color.White Then
            Actualizar_Menu_PleTipoDeDocumento.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTipoDeDocumento.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTipoDeDocumento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTipoDeDocumento.Tick
        If Eliminar_Menu_PleTipoDeDocumento.BackColor = Color.White Then
            Eliminar_Menu_PleTipoDeDocumento.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTipoDeDocumento.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTipoDeDocumento()
        Me.Timer_Guardar_Menu_PleTipoDeDocumento = New Timer
        Timer_Guardar_Menu_PleTipoDeDocumento.Stop()
        Guardar_Menu_PleTipoDeDocumento.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTipoDeDocumento = New Timer
        Timer_Actualizar_Menu_PleTipoDeDocumento.Stop()
        Actualizar_Menu_PleTipoDeDocumento.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTipoDeDocumento = New Timer
        Timer_Eliminar_Menu_PleTipoDeDocumento.Stop()
        Eliminar_Menu_PleTipoDeDocumento.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTipoDeDocumento As Timer
    Dim X_PleTipoDeDocumento
    Private Sub Timer_Ubicar_En_Fila_PleTipoDeDocumento()
        Me.Timer_Ubicacion_PleTipoDeDocumento = New Timer
        Timer_Ubicacion_PleTipoDeDocumento.Interval = 100
        Timer_Ubicacion_PleTipoDeDocumento.Start()
    End Sub

    '--==============================================================--

    Private Sub PleTipoDeDocumentoDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleTipoDeDocumentoDataGridView.CellMouseClick
        X_PleTipoDeDocumento = PleTipoDeDocumentoDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTipoDeDocumento()
        Try
            Me.PleTipoDeDocumentoDataGridView.Rows(X_PleTipoDeDocumento).Selected = True
            Me.PleTipoDeDocumentoDataGridView.FirstDisplayedScrollingRowIndex = X_PleTipoDeDocumento
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTipoDeDocumento_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTipoDeDocumento.Tick
        Ubicar_En_Fila_PleTipoDeDocumento()
        Timer_Ubicacion_PleTipoDeDocumento.Stop()
    End Sub



#End Region

#End Region

#End Region


    'CASOS ESPECIALES EN NAVEGACION

    '--=============================================FIN==================================================--


End Class