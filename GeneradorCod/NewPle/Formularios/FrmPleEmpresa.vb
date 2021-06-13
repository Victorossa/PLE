Imports System.IO
Imports System.Text
Public Class FrmPleEmpresa

    'Crear formulario FrmPleEmpresa
    'Tipo de letra : Microsoft Tai Le; 12pt
    'Autoscroll : True
    'FormBorderStyle = None
    'Traer de utilidades los botones y validadores, copiarlos y pegarlos y poner los nombres
    'Nuevo_Menu_PleEmpresa
    'Guardar_Menu_PleEmpresa
    'Editar_Menu_PleEmpresa
    'Actualizar_Menu_PleEmpresa
    'Eliminar_Menu_PleEmpresa
    'Cancelar_Menu_PleEmpresa
    'Salir_Menu_PleEmpresa
    'ForeColor: 37; 46; 56
    'ControlBox: False

    'Grid con Anchor Top, Left, Right

    '--=== INICIO

#Region "TODO PleEmpresa"

    '--==============================================================--
    Private Sub FrmPleEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMaestros.PleTipoDeDocumento' Puede moverla o quitarla según sea necesario.
        Me.PleTipoDeDocumentoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDeDocumento)
        'TODO: esta línea de código carga datos en la tabla 'DataSetMaestros.PleEmpresaView' Puede moverla o quitarla según sea necesario.
        Me.PleEmpresaViewTableAdapter.Fill(Me.DataSetMaestros.PleEmpresaView)
        Metodo_Aviso_Acciones(2, "Bienvenido a la Creación de PleEmpresa")

        Cancelar_PleEmpresa()
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

    Sub Cancelar_PleEmpresa()
        'Botones Del Menu
        Nuevo_Menu_PleEmpresa.Enabled = True
        Guardar_Menu_PleEmpresa.Enabled = False
        Editar_Menu_PleEmpresa.Enabled = True
        Actualizar_Menu_PleEmpresa.Enabled = False
        Eliminar_Menu_PleEmpresa.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleEmpresaViewDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleTipoDeDocumentoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDeDocumento)
        Bloquear_Objetos_PleEmpresa()
        Parar_Timer_PleEmpresa()
        Timer_Ubicar_En_Fila_PleEmpresa()
    End Sub

    '--=== INSERTAR 

    'Insertar PleEmpresa
    Private Sub SP_PleEmpresa_EDICION_INSERTAR(ByVal ImagenEmpresa As Byte(),
NombreEmpresa As String,
TipoDeDocumentoId As Integer,
Documento As String,
Email As String,
Telefono As String,
Celular As String,
Eslogan As String,
Servicios As String,
Mision As String,
Vision As String
)
        Try
            Me.SP_PleEmpresa_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleEmpresa_EDICION_INSERTAR,
                                                            ImagenEmpresa,
                                                            NombreEmpresa,
                                                            New System.Nullable(Of Integer)(CType(TipoDeDocumentoId, Integer)),
                                                            Documento,
                                                            Email,
                                                            Telefono,
                                                            Celular,
                                                            Eslogan,
                                                            Servicios,
                                                            Mision,
                                                            Vision
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleEmpresa")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleEmpresa
    Private Sub SP_PleEmpresa_EDICION_ACTUALIZAR(EmpresaId As Integer,
ByVal ImagenEmpresa As Byte(),
NombreEmpresa As String,
TipoDeDocumentoId As Integer,
Documento As String,
Email As String,
Telefono As String,
Celular As String,
Eslogan As String,
Servicios As String,
Mision As String,
Vision As String
)

        Try
            Me.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleEmpresa_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(EmpresaId, Integer)),
                                                            ImagenEmpresa,
                                                            NombreEmpresa,
                                                            New System.Nullable(Of Integer)(CType(TipoDeDocumentoId, Integer)),
                                                            Documento,
                                                            Email,
                                                            Telefono,
                                                            Celular,
                                                            Eslogan,
                                                            Servicios,
                                                            Mision,
                                                            Vision
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleEmpresa")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleEmpresa_EDICION_ELIMINAR(EmpresaId As Integer)
        Try
            Me.SP_PleEmpresa_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleEmpresa_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(EmpresaId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleEmpresa Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleEmpresa()
        BtnCargarImagen.Enabled = False
        NombreEmpresaTextBox.Enabled = False
        CboTipoDeDocumentoIdTextBox.Enabled = False
        DocumentoTextBox.Enabled = False
        EmailTextBox.Enabled = False
        TelefonoTextBox.Enabled = False
        CelularTextBox.Enabled = False
        EsloganTextBox.Enabled = False
        ServiciosTextBox.Enabled = False
        MisionTextBox.Enabled = False
        VisionTextBox.Enabled = False

    End Sub

    Public Sub Desbloquear_Objetos_PleEmpresa()
        BtnCargarImagen.Enabled = True
        NombreEmpresaTextBox.Enabled = True
        CboTipoDeDocumentoIdTextBox.Enabled = True
        DocumentoTextBox.Enabled = True
        EmailTextBox.Enabled = True
        TelefonoTextBox.Enabled = True
        CelularTextBox.Enabled = True
        EsloganTextBox.Enabled = True
        ServiciosTextBox.Enabled = True
        MisionTextBox.Enabled = True
        VisionTextBox.Enabled = True

    End Sub

    Public Sub Limpiar_Objetos_PleEmpresa()
        NombreEmpresaTextBox.Text = ""
        CboTipoDeDocumentoIdTextBox.Text = ""
        DocumentoTextBox.Text = ""
        EmailTextBox.Text = ""
        TelefonoTextBox.Text = ""
        CelularTextBox.Text = ""
        EsloganTextBox.Text = ""
        ServiciosTextBox.Text = ""
        MisionTextBox.Text = ""
        VisionTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleEmpresa()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreEmpresaTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre Empresa; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreEmpresaTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case CboTipoDeDocumentoIdTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo Tipo De Documento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDeDocumentoIdTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case DocumentoTextBox.Text = ""
                MsgBox("El nombre del campo: Documento; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DocumentoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case EmailTextBox.Text = ""
                MsgBox("El nombre del campo: Email; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                EmailTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case TelefonoTextBox.Text = ""
                MsgBox("El nombre del campo: Teléfono; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TelefonoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case CelularTextBox.Text = ""
                MsgBox("El nombre del campo: Celular; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CelularTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case EsloganTextBox.Text = ""
                MsgBox("El nombre del campo: Eslogan; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                EsloganTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case ServiciosTextBox.Text = ""
                MsgBox("El nombre del campo: Servicios; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ServiciosTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case MisionTextBox.Text = ""
                MsgBox("El nombre del campo: Misión; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                MisionTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case VisionTextBox.Text = ""
                MsgBox("El nombre del campo: Visión; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                VisionTextBox.BackColor = Color.White
                ControlNulos.Text = "1"

            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleEmpresa.Click
        Nuevo_Menu_PleEmpresa.Enabled = False
        Editar_Menu_PleEmpresa.Enabled = False
        ValidarCierre.Text = 1
        PleEmpresaViewDataGridView.Enabled = False
        Limpiar_Objetos_PleEmpresa()
        NombreEmpresaTextBox.Enabled = True
        NombreEmpresaTextBox.Focus()
        BtnCargarImagen.Enabled = True
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleEmpresa.Click
        Control_Nulos_PleEmpresa()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox.Image
            SP_PleEmpresa_EDICION_INSERTAR((ImagenToBytes(myImg)),
        NombreEmpresaTextBox.Text,
        TipoDeDocumentoIdTextBoxBase.Text,
        DocumentoTextBox.Text,
        EmailTextBox.Text,
        TelefonoTextBox.Text,
        CelularTextBox.Text,
        EsloganTextBox.Text,
        ServiciosTextBox.Text,
        MisionTextBox.Text,
        VisionTextBox.Text
)
            Cancelar_PleEmpresa()
            Parar_Timer_PleEmpresa()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleEmpresa.Click
        Nuevo_Menu_PleEmpresa.Enabled = False
        Guardar_Menu_PleEmpresa.Enabled = False
        Editar_Menu_PleEmpresa.Enabled = False
        Actualizar_Menu_PleEmpresa.Enabled = True
        Eliminar_Menu_PleEmpresa.Enabled = True
        PleEmpresaViewDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleEmpresa()
        Timer_Actualizar_PleEmpresa()
        Timer_Eliminar_PleEmpresa()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleEmpresa.Click
        Control_Nulos_PleEmpresa()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox.Image
            SP_PleEmpresa_EDICION_ACTUALIZAR(EmpresaIdTextBox.Text, (ImagenToBytes(myImg)),
        NombreEmpresaTextBox.Text,
        TipoDeDocumentoIdTextBoxBase.Text,
        DocumentoTextBox.Text,
        EmailTextBox.Text,
        TelefonoTextBox.Text,
        CelularTextBox.Text,
        EsloganTextBox.Text,
        ServiciosTextBox.Text,
        MisionTextBox.Text,
        VisionTextBox.Text
)
            Cancelar_PleEmpresa()
            Parar_Timer_PleEmpresa()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleEmpresa.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleEmpresa_EDICION_ELIMINAR(EmpresaIdTextBox.Text)
            Cancelar_PleEmpresa()
            Parar_Timer_PleEmpresa()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleEmpresa()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleEmpresa.Click
        Cancelar_PleEmpresa()
    End Sub

    '--=== SALIR
    'Salir
    Private Sub Salir_Menu_PleEmpresa_Click(sender As Object, e As EventArgs) Handles Salir_Menu_PleEmpresa.Click
        If ValidarCierre.Text = "" Then
            Me.Close()
        Else
            Metodo_Aviso_Acciones(3, "Accion en proceso")
        End If
    End Sub

    '--=== NAVEGACIÓN

    Private Sub NombreEmpresaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreEmpresaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreEmpresaTextBox.Text = "" Then
                MsgBox("El Dato: Nombre Empresa es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreEmpresaTextBox.Focus()
            Else
                CboTipoDeDocumentoIdTextBox.Enabled = True
                CboTipoDeDocumentoIdTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub CboTipoDeDocumentoIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDeDocumentoIdTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDeDocumentoIdTextBox.Text = "" Then
                MsgBox("El Dato: Codigo Tipo De Documento es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                CboTipoDeDocumentoIdTextBox.Focus()
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
                EmailTextBox.Enabled = True
                EmailTextBox.Focus()
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

    Private Sub EmailTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmailTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If EmailTextBox.Text = "" Then
                MsgBox("El Dato: Email es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                EmailTextBox.Focus()
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
    End Sub

    Private Sub TelefonoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefonoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TelefonoTextBox.Text = "" Then
                MsgBox("El Dato: Teléfono es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
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
                EsloganTextBox.Enabled = True
                EsloganTextBox.Focus()
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

    Private Sub EsloganTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EsloganTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If EsloganTextBox.Text = "" Then
                MsgBox("El Dato: Eslogan es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                EsloganTextBox.Focus()
            Else
                ServiciosTextBox.Enabled = True
                ServiciosTextBox.Focus()
            End If
        End If
        'Primera en mayuscula
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (EsloganTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(EsloganTextBox.Text, 1)
            Caracter = UCase(Caracter)
            EsloganTextBox.Text = ""
            EsloganTextBox.Text = Caracter
            EsloganTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(EsloganTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(EsloganTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(EsloganTextBox.Text, 1)
            Caracter = UCase(Caracter)
            EsloganTextBox.Text = ""
            EsloganTextBox.Text = Temp + Caracter
            EsloganTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    Private Sub ServiciosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ServiciosTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ServiciosTextBox.Text = "" Then
                MsgBox("El Dato: Servicios es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                ServiciosTextBox.Focus()
            Else
                MisionTextBox.Enabled = True
                MisionTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
    End Sub

    Private Sub MisionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MisionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If MisionTextBox.Text = "" Then
                MsgBox("El Dato: Misión es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                MisionTextBox.Focus()
            Else
                VisionTextBox.Enabled = True
                VisionTextBox.Focus()
            End If
        End If
        'If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If
        'Solo lectura
        'If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
        '       e.KeyChar = ""
        'End If

    End Sub

    Private Sub VisionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VisionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleEmpresa.Enabled = True Then
                Actualizar_Menu_PleEmpresa.Enabled = True
                Eliminar_Menu_PleEmpresa.Enabled = True
            Else
                If VisionTextBox.Text = "" Then
                    MsgBox("El Dato: Visión es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    VisionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleEmpresa.Enabled = True
                    Timer_Guardar_PleEmpresa()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES

    'Conversion de imagen
    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                'variable de datos binarios en stream(flujo)
                Dim Bin As New MemoryStream
                'convertir a bytes
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                'retorna binario
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function


    'Carga de imagen 
    ' Agregar un Picturebox y darle por nombre ImagenPictureBox
    'Agregar un boton y darle por nombre BtnCargarImagen
    Dim IMAGEN As String
    Dim OpenFileDialog1 As New OpenFileDialog
    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        ImagenPictureBox.Image = Nothing
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                IMAGEN = OpenFileDialog1.FileName
                Dim largo As Integer = IMAGEN.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 2, largo))
                If imagen2 <> "gif" And
                    imagen2 <> "bmp" And
                    imagen2 <> "jpg" And
                    imagen2 <> "jpeg" And
                    imagen2 <> "GIF" And
                    imagen2 <> "BMP" And
                    imagen2 <> "JPG" And
                    imagen2 <> "JPEG" And
                    imagen2 <> "PNG" And
                    imagen2 <> "png" Then
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                End If
            End If
            ImagenPictureBox.Load(IMAGEN)
        Catch ex As Exception

        End Try

    End Sub
    'Radiobutton visualizacion de imagen
    'Si es para imagenes que se capturan
    '1 - Montarlas primero
    '2 - Verlas en el picturebox en ajustado (StretchImage)
    '3 - Volverlas a capturar pero del picture box
    '4 - si se van a visualizar en un datagridview se recomienda para la celda que lleva la imagen
    '5 - 1 - debe ser del tipo (ColumnType) DataGridViewImageColumn 
    '    2- En su propiedad imagenLayout ponerla en Stretch

    'Visualizar imagen normal
    Private Sub RbNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RbNormal.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.Normal
    End Sub
    'Visualizar Ajustado al picturebox
    Private Sub RbAjustado_CheckedChanged(sender As Object, e As EventArgs) Handles RbAjustado.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    'Visualizar Imagen original centrada
    Private Sub RbCentrada_CheckedChanged(sender As Object, e As EventArgs) Handles RbCentrada.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub
    'Visualizar imagen en el picture box con zoom
    Private Sub RbZoom_CheckedChanged(sender As Object, e As EventArgs) Handles RbZoom.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    'Elementos de transferencia de datos entre combos y textbox --==================================

    Private Sub TipoDeDocumentoIdTextBoxTabla_TextChanged(sender As Object, e As EventArgs) Handles TipoDeDocumentoIdTextBoxTabla.TextChanged
        TipoDeDocumentoIdTextBoxBase.Text = TipoDeDocumentoIdTextBoxTabla.Text
    End Sub

    Private Sub CboTipoDeDocumentoIdTextBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoDeDocumentoIdTextBox.SelectedIndexChanged
        If TipoDeDocumentoIdTextBoxBase.Text = "" Then
            TipoDeDocumentoIdTextBoxBase.Text = TipoDeDocumentoIdTextBoxTabla.Text
        End If
    End Sub

    Private Sub NombreTipoDeDocumentoIdBase_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoDeDocumentoIdBase.TextChanged
        CboTipoDeDocumentoIdTextBox.Text = NombreTipoDeDocumentoIdBase.Text
    End Sub
    '--========================================================================




    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleEmpresa As Timer
    Private WithEvents Timer_Actualizar_Menu_PleEmpresa As Timer
    Private WithEvents Timer_Eliminar_Menu_PleEmpresa As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleEmpresa()
        Me.Timer_Guardar_Menu_PleEmpresa = New Timer
        Timer_Guardar_Menu_PleEmpresa.Interval = 250
        Timer_Guardar_Menu_PleEmpresa.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleEmpresa()
        Me.Timer_Actualizar_Menu_PleEmpresa = New Timer
        Timer_Actualizar_Menu_PleEmpresa.Interval = 500
        Timer_Actualizar_Menu_PleEmpresa.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleEmpresa()
        Me.Timer_Eliminar_Menu_PleEmpresa = New Timer
        Timer_Eliminar_Menu_PleEmpresa.Interval = 800
        Timer_Eliminar_Menu_PleEmpresa.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleEmpresa_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleEmpresa.Tick
        If Guardar_Menu_PleEmpresa.BackColor = Color.White Then
            Guardar_Menu_PleEmpresa.BackColor = Color.Green
        Else
            Guardar_Menu_PleEmpresa.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleEmpresa_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleEmpresa.Tick
        If Actualizar_Menu_PleEmpresa.BackColor = Color.White Then
            Actualizar_Menu_PleEmpresa.BackColor = Color.Green
        Else
            Actualizar_Menu_PleEmpresa.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleEmpresa_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleEmpresa.Tick
        If Eliminar_Menu_PleEmpresa.BackColor = Color.White Then
            Eliminar_Menu_PleEmpresa.BackColor = Color.Red
        Else
            Eliminar_Menu_PleEmpresa.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleEmpresa()
        Me.Timer_Guardar_Menu_PleEmpresa = New Timer
        Timer_Guardar_Menu_PleEmpresa.Stop()
        Guardar_Menu_PleEmpresa.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleEmpresa = New Timer
        Timer_Actualizar_Menu_PleEmpresa.Stop()
        Actualizar_Menu_PleEmpresa.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleEmpresa = New Timer
        Timer_Eliminar_Menu_PleEmpresa.Stop()
        Eliminar_Menu_PleEmpresa.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleEmpresa As Timer
    Dim X_PleEmpresa
    Private Sub Timer_Ubicar_En_Fila_PleEmpresa()
        Me.Timer_Ubicacion_PleEmpresa = New Timer
        Timer_Ubicacion_PleEmpresa.Interval = 100
        Timer_Ubicacion_PleEmpresa.Start()
    End Sub

    '--==============================================================--

    Private Sub PleEmpresaViewDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleEmpresaViewDataGridView.CellMouseClick
        X_PleEmpresa = PleEmpresaViewDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleEmpresa()
        Try
            Me.PleEmpresaViewDataGridView.Rows(X_PleEmpresa).Selected = True
            Me.PleEmpresaViewDataGridView.FirstDisplayedScrollingRowIndex = X_PleEmpresa
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleEmpresa_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleEmpresa.Tick
        Ubicar_En_Fila_PleEmpresa()
        Timer_Ubicacion_PleEmpresa.Stop()
    End Sub

#End Region

#End Region

#End Region


    'CASOS ESPECIALES EN NAVEGACION
    ' Primera en mayuscula
    'Dim Longitud, Ascii As Integer
    '    Dim Temp As String
    '    Dim Caracter As Char
    '    Longitud = (Campo.TextLength) - 1
    '    If Longitud < 1 Then
    '        Longitud = Longitud + 1
    '        Caracter = Microsoft.VisualBasic.Right(Campo.Text, 1)
    '        Caracter = UCase(Caracter)
    '        Campo.Text = ""
    '        Campo.Text = Caracter
    '        Campo.SelectionStart = Longitud + 1
    '        Exit Sub
    '    End If
    '    Caracter = Mid(Campo.Text, Longitud, Longitud)
    '    Ascii = Asc(Caracter)
    '    If Ascii = 32 Then
    '        Temp = Microsoft.VisualBasic.Left(Campo.Text, Longitud)
    '        Caracter = Microsoft.VisualBasic.Right(Campo.Text, 1)
    '        Caracter = UCase(Caracter)
    '        Campo.Text = ""
    '        Campo.Text = Temp + Caracter
    '        Campo.SelectionStart = Longitud + 1
    '    End If
    '--=============================================FIN==================================================--

End Class