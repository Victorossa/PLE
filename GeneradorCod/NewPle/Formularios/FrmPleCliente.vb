Public Class FrmPleCliente



    'Crear formulario FrmPleCliente
    'Tipo de letra : Microsoft Tai Le; 12pt
    'Autoscroll : True
    'FormBorderStyle = None
    'Traer de utilidades los botones y validadores, copiarlos y pegarlos y poner los nombres
    'Nuevo_Menu_PleCliente
    'Guardar_Menu_PleCliente
    'Editar_Menu_PleCliente
    'Actualizar_Menu_PleCliente
    'Eliminar_Menu_PleCliente
    'Cancelar_Menu_PleCliente
    'Salir_Menu_PleCliente
    'ForeColor: 37; 46; 56
    'ControlBox: False

    'Grid con Anchor Top, Left, Right

    '--=== INICIO

#Region "TODO PleCliente"

    '--==============================================================--
    Private Sub FrmPleCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PleTipoDeDocumentoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDeDocumento)
        Metodo_Aviso_Acciones(2, "Bienvenido a la Creación de PleCliente")
        Me.PleClienteViewTableAdapter.Fill(Me.DataSetMaestros.PleClienteView)
        Cancelar_PleCliente()
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

    Sub Cancelar_PleCliente()
        'Botones Del Menu
        Nuevo_Menu_PleCliente.Enabled = True
        Guardar_Menu_PleCliente.Enabled = False
        Editar_Menu_PleCliente.Enabled = True
        Actualizar_Menu_PleCliente.Enabled = False
        Eliminar_Menu_PleCliente.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleClienteViewDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleClienteViewTableAdapter.Fill(Me.DataSetMaestros.PleClienteView)
        Bloquear_Objetos_PleCliente()
        Parar_Timer_PleCliente()
        Timer_Ubicar_En_Fila_PleCliente()
    End Sub

    '--=== INSERTAR 

    'Insertar PleCliente
    Private Sub SP_PleCliente_EDICION_INSERTAR(NombreCliente As String,
TipoDocumento As Integer,
Documento As String,
Contacto As String,
Telefono As String,
Celular As String,
PrecioCobrarPorHora As Integer,
PorcentajeIncrementoTiempo As Integer,
FechaCreacion As DateTime,
UltimaFechaMod As DateTime
)
        Try
            Me.SP_PleCliente_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCliente_EDICION_INSERTAR,
                                                            NombreCliente,
                                                            New System.Nullable(Of Integer)(CType(TipoDocumento, Integer)),
                                                            Documento,
                                                            Contacto,
                                                            Telefono,
                                                            Celular,
                                                            New System.Nullable(Of Integer)(CType(PrecioCobrarPorHora, Integer)),
                                                            New System.Nullable(Of Integer)(CType(PorcentajeIncrementoTiempo, Integer)),
                                                            New System.Nullable(Of Date)(CType(FechaCreacion, Date)),
                                                            New System.Nullable(Of Date)(CType(UltimaFechaMod, Date))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleCliente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleCliente
    Private Sub SP_PleCliente_EDICION_ACTUALIZAR(ClienteId As Integer,
NombreCliente As String,
TipoDocumento As Integer,
Documento As String,
Contacto As String,
Telefono As String,
Celular As String,
PrecioCobrarPorHora As Integer,
PorcentajeIncrementoTiempo As Integer,
FechaCreacion As DateTime,
UltimaFechaMod As DateTime
)

        Try
            Me.SP_PleCliente_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCliente_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(ClienteId, Integer)),
                                                            NombreCliente,
                                                            New System.Nullable(Of Integer)(CType(TipoDocumento, Integer)),
                                                            Documento,
                                                            Contacto,
                                                            Telefono,
                                                            Celular,
                                                            New System.Nullable(Of Integer)(CType(PrecioCobrarPorHora, Integer)),
                                                            New System.Nullable(Of Integer)(CType(PorcentajeIncrementoTiempo, Integer)),
                                                            New System.Nullable(Of Date)(CType(FechaCreacion, Date)),
                                                            New System.Nullable(Of Date)(CType(UltimaFechaMod, Date))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleCliente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleCliente_EDICION_ELIMINAR(ClienteId As Integer)
        Try
            Me.SP_PleCliente_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleCliente_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(ClienteId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleCliente Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleCliente()
        NombreClienteTextBox.Enabled = False
        CboTipoDocumentoTextBox.Enabled = False
        DocumentoTextBox.Enabled = False
        ContactoTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        CelularTextBox.Enabled = False
        PrecioCobrarPorHoraTextBox.Enabled = False
        PorcentajeIncrementoTiempoTextBox.Enabled = False
        FechaCreacionDateTimePicker.Enabled = False
        UltimaFechaModDateTimePicker.Enabled = False

    End Sub

    Public Sub Desbloquear_Objetos_PleCliente()
        NombreClienteTextBox.Enabled = True
        CboTipoDocumentoTextBox.Enabled = True
        DocumentoTextBox.Enabled = True
        ContactoTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        CelularTextBox.Enabled = True
        PrecioCobrarPorHoraTextBox.Enabled = True
        PorcentajeIncrementoTiempoTextBox.Enabled = True
        FechaCreacionDateTimePicker.Enabled = True
        UltimaFechaModDateTimePicker.Enabled = True

    End Sub

    Public Sub Limpiar_Objetos_PleCliente()
        NombreClienteTextBox.Text = ""
        CboTipoDocumentoTextBox.Text = ""
        DocumentoTextBox.Text = ""
        ContactoTextBox.Text = ""
        TelefonoTextBox.Text = ""
        CelularTextBox.Text = ""
        PrecioCobrarPorHoraTextBox.Text = ""
        PorcentajeIncrementoTiempoTextBox.Text = ""
        FechaCreacionDateTimePicker.Text = ""
        UltimaFechaModDateTimePicker.Text = ""

    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleCliente()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreClienteTextBox.Text = ""
                MsgBox("El nombre del campo: NombreCliente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreClienteTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case CboTipoDocumentoTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo de Documento del Cliente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDocumentoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case DocumentoTextBox.Text = ""
                MsgBox("El nombre del campo: Documento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DocumentoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case ContactoTextBox.Text = ""
                MsgBox("El nombre del campo: Contacto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContactoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case TelefonoTextBox.Text = ""
                MsgBox("El nombre del campo: Telefono; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TelefonoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case CelularTextBox.Text = ""
                MsgBox("El nombre del campo: Celular; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CelularTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case PrecioCobrarPorHoraTextBox.Text = ""
                MsgBox("El nombre del campo: Precio Cobrar Por Hora; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PrecioCobrarPorHoraTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case PorcentajeIncrementoTiempoTextBox.Text = ""
                MsgBox("El nombre del campo: PorcentajeIncrementoTiempo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PorcentajeIncrementoTiempoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case FechaCreacionDateTimePicker.Text = ""
                MsgBox("El nombre del campo: Fecha Creacion ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                FechaCreacionDateTimePicker.BackColor = Color.White
                ControlNulos.Text = "1"
            Case UltimaFechaModDateTimePicker.Text = ""
                MsgBox("El nombre del campo: Ultima Fecha Modificacion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                UltimaFechaModDateTimePicker.BackColor = Color.White
                ControlNulos.Text = "1"

            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleCliente.Click
        Nuevo_Menu_PleCliente.Enabled = False
        Editar_Menu_PleCliente.Enabled = False
        ValidarCierre.Text = 1
        PleClienteViewDataGridView.Enabled = False
        Limpiar_Objetos_PleCliente()
        NombreClienteTextBox.Enabled = True
        NombreClienteTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleCliente.Click
        Control_Nulos_PleCliente()

        If ControlNulos.Text = "" Then
            SP_PleCliente_EDICION_INSERTAR(NombreClienteTextBox.Text,
        TipoDocumentoIdTextBoxBase.Text,
        DocumentoTextBox.Text,
        ContactoTextBox.Text,
        TelefonoTextBox.Text,
        CelularTextBox.Text,
        PrecioCobrarPorHoraTextBox.Text,
        PorcentajeIncrementoTiempoTextBox.Text,
        FechaCreacionDateTimePicker.Text,
        UltimaFechaModDateTimePicker.Text
)
            Cancelar_PleCliente()
            Parar_Timer_PleCliente()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleCliente.Click
        Nuevo_Menu_PleCliente.Enabled = False
        Guardar_Menu_PleCliente.Enabled = False
        Editar_Menu_PleCliente.Enabled = False
        Actualizar_Menu_PleCliente.Enabled = True
        Eliminar_Menu_PleCliente.Enabled = True
        PleClienteViewDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleCliente()
        Timer_Actualizar_PleCliente()
        Timer_Eliminar_PleCliente()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleCliente.Click
        Control_Nulos_PleCliente()

        If ControlNulos.Text = "" Then
            SP_PleCliente_EDICION_ACTUALIZAR(ClienteIdTextBox.Text,
        NombreClienteTextBox.Text,
        TipoDocumentoIdTextBoxBase.Text,
        DocumentoTextBox.Text,
        ContactoTextBox.Text,
        TelefonoTextBox.Text,
        CelularTextBox.Text,
        PrecioCobrarPorHoraTextBox.Text,
        PorcentajeIncrementoTiempoTextBox.Text,
        FechaCreacionDateTimePicker.Text,
        UltimaFechaModDateTimePicker.Text
)
            Cancelar_PleCliente()
            Parar_Timer_PleCliente()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleCliente.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleCliente_EDICION_ELIMINAR(ClienteIdTextBox.Text)
            Cancelar_PleCliente()
            Parar_Timer_PleCliente()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleCliente()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleCliente.Click
        Cancelar_PleCliente()
    End Sub

    '--=== SALIR

    'Salir
    Private Sub Salir_Menu_PleCliente_Click(sender As Object, e As EventArgs) Handles Salir_Menu_PleCliente.Click
        If ValidarCierre.Text = "" Then
            Me.Close()
        Else
            Metodo_Aviso_Acciones(3, "Accion en proceso")
        End If
    End Sub

    '--=== NAVEGACIÓN

    Private Sub NombreClienteTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreClienteTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreClienteTextBox.Text = "" Then
                MsgBox("El Dato: NombreCliente es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreClienteTextBox.Focus()
            Else
                CboTipoDocumentoTextBox.Enabled = True
                CboTipoDocumentoTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'CASOS ESPECIALES EN NAVEGACION
        ' Primera en mayuscula
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreClienteTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreClienteTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreClienteTextBox.Text = ""
            NombreClienteTextBox.Text = Caracter
            NombreClienteTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreClienteTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreClienteTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreClienteTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreClienteTextBox.Text = ""
            NombreClienteTextBox.Text = Temp + Caracter
            NombreClienteTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    Private Sub CboTipoDocumentoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDocumentoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDocumentoTextBox.Text = "" Then
                MsgBox("El Dato: Tipo de Documento del Cliente es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                CboTipoDocumentoTextBox.Focus()
            Else
                DocumentoTextBox.Enabled = True
                DocumentoTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub DocumentoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DocumentoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If DocumentoTextBox.Text = "" Then
                MsgBox("El Dato: Documento es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                DocumentoTextBox.Focus()
            Else
                ContactoTextBox.Enabled = True
                ContactoTextBox.Focus()
            End If
        End If
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub ContactoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContactoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ContactoTextBox.Text = "" Then
                MsgBox("El Dato: Contacto es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                ContactoTextBox.Focus()
            Else
                TelefonoTextBox.Enabled = True
                TelefonoTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'CASOS ESPECIALES EN NAVEGACION
        ' Primera en mayuscula
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (ContactoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(ContactoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            ContactoTextBox.Text = ""
            ContactoTextBox.Text = Caracter
            ContactoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(ContactoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(ContactoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(ContactoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            ContactoTextBox.Text = ""
            ContactoTextBox.Text = Temp + Caracter
            ContactoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TelefonoTextBox.Text = "" Then
                MsgBox("El Dato: Telefono es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                TelefonoTextBox.Focus()
            Else
                CelularTextBox.Enabled = True
                CelularTextBox.Focus()
            End If
        End If
        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub CelularTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CelularTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CelularTextBox.Text = "" Then
                MsgBox("El Dato: Celular es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                CelularTextBox.Focus()
            Else
                PrecioCobrarPorHoraTextBox.Enabled = True
                PrecioCobrarPorHoraTextBox.Focus()
            End If
        End If
        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub PrecioCobrarPorHoraTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioCobrarPorHoraTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If PrecioCobrarPorHoraTextBox.Text = "" Then
                MsgBox("El Dato: Precio Cobrar Por Hora es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                PrecioCobrarPorHoraTextBox.Focus()
            Else
                PorcentajeIncrementoTiempoTextBox.Enabled = True
                PorcentajeIncrementoTiempoTextBox.Focus()
            End If
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub PorcentajeIncrementoTiempoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PorcentajeIncrementoTiempoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleCliente.Enabled = True Then
                Actualizar_Menu_PleCliente.Enabled = True
                Eliminar_Menu_PleCliente.Enabled = True
            Else
                If PorcentajeIncrementoTiempoTextBox.Text = "" Then
                    MsgBox("El Dato: Ultima Fecha Modificacion es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    PorcentajeIncrementoTiempoTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleCliente.Enabled = True
                    Timer_Guardar_PleCliente()
                End If
            End If
        End If
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    '--=== ESPECIALES

    'Elementos de transferencia de datos entre combos y textbox --==================================

    Private Sub TipoDocumentoTextBoxTabla_TextChanged(sender As Object, e As EventArgs) Handles TipoDocumentoTextBoxTabla.TextChanged
        TipoDocumentoIdTextBoxBase.Text = TipoDocumentoTextBoxTabla.Text
    End Sub

    Private Sub CboTipoDocumentoTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoDocumentoTextBox.SelectedIndexChanged
        If TipoDocumentoIdTextBoxBase.Text = "" Then
            TipoDocumentoIdTextBoxBase.Text = TipoDocumentoTextBoxTabla.Text
        End If
    End Sub

    Private Sub NombreTipoDocumentoBase_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoDocumentoBase.TextChanged
        CboTipoDocumentoTextBox.Text = NombreTipoDocumentoBase.Text
    End Sub
    '--========================================================================




    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleCliente As Timer
    Private WithEvents Timer_Actualizar_Menu_PleCliente As Timer
    Private WithEvents Timer_Eliminar_Menu_PleCliente As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleCliente()
        Me.Timer_Guardar_Menu_PleCliente = New Timer
        Timer_Guardar_Menu_PleCliente.Interval = 250
        Timer_Guardar_Menu_PleCliente.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleCliente()
        Me.Timer_Actualizar_Menu_PleCliente = New Timer
        Timer_Actualizar_Menu_PleCliente.Interval = 500
        Timer_Actualizar_Menu_PleCliente.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleCliente()
        Me.Timer_Eliminar_Menu_PleCliente = New Timer
        Timer_Eliminar_Menu_PleCliente.Interval = 800
        Timer_Eliminar_Menu_PleCliente.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleCliente.Tick
        If Guardar_Menu_PleCliente.BackColor = Color.White Then
            Guardar_Menu_PleCliente.BackColor = Color.Green
        Else
            Guardar_Menu_PleCliente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleCliente.Tick
        If Actualizar_Menu_PleCliente.BackColor = Color.White Then
            Actualizar_Menu_PleCliente.BackColor = Color.Green
        Else
            Actualizar_Menu_PleCliente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleCliente.Tick
        If Eliminar_Menu_PleCliente.BackColor = Color.White Then
            Eliminar_Menu_PleCliente.BackColor = Color.Red
        Else
            Eliminar_Menu_PleCliente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleCliente()
        Me.Timer_Guardar_Menu_PleCliente = New Timer
        Timer_Guardar_Menu_PleCliente.Stop()
        Guardar_Menu_PleCliente.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleCliente = New Timer
        Timer_Actualizar_Menu_PleCliente.Stop()
        Actualizar_Menu_PleCliente.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleCliente = New Timer
        Timer_Eliminar_Menu_PleCliente.Stop()
        Eliminar_Menu_PleCliente.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleCliente As Timer
    Dim X_PleCliente
    Private Sub Timer_Ubicar_En_Fila_PleCliente()
        Me.Timer_Ubicacion_PleCliente = New Timer
        Timer_Ubicacion_PleCliente.Interval = 100
        Timer_Ubicacion_PleCliente.Start()
    End Sub

    '--==============================================================--

    Private Sub PleClienteViewDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleClienteViewDataGridView.CellMouseClick
        X_PleCliente = PleClienteViewDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleCliente()
        Try
            Me.PleClienteViewDataGridView.Rows(X_PleCliente).Selected = True
            Me.PleClienteViewDataGridView.FirstDisplayedScrollingRowIndex = X_PleCliente
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleCliente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleCliente.Tick
        Ubicar_En_Fila_PleCliente()
        Timer_Ubicacion_PleCliente.Stop()
    End Sub




#End Region

#End Region

#End Region



    '--=============================================FIN==================================================--



End Class