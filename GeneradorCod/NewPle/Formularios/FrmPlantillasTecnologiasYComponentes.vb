Imports System.IO
Imports System.Text

Public Class FrmPlantillasTecnologiasYComponentes

    '--========================GENERALES==================================--

#Region "Generales"
    Dim VALIDACION_BASE As String = ""
#End Region
    '--========================MAESTROS==================================--

#Region "TODO PleTecnologias"

    '--==============================================================--
    Private Sub FrmPleTecnologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetMaestros.PleBBakup' Puede moverla o quitarla según sea necesario.
        Me.PleBBakupTableAdapter.Fill(Me.DataSetMaestros.PleBBakup)
        Metodo_Aviso_Acciones(2, "Bienvenido a la Creación de PleTecnologias")

        Me.PleTecnologiasTableAdapter.Fill(Me.DataSetMaestros.PleTecnologias)
        Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
        Me.PleTipoDatoGrupo1TableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo1)
        Me.PleTipoDatoGrupo2TableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo2)
        Me.PleTipoDatoGrupo4TableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo4)
        Me.PleRequerimientosTableAdapter.Fill(Me.DataSetMaestros.PleRequerimientos)
        Me.PleCampDeTablasFormatoTableAdapter.Fill(Me.DataSetMaestros.PleCampDeTablasFormato)


        LimpiarColorBotones()
        CodUnoTextBox.BringToFront()
        CodUnoTextBox.Dock = DockStyle.Fill
        BtnArchivoUno.BackColor = Color.Green

        Cancelar_PleTecnologias()
        Cancelar_PlePlantilla()
        Cancelar_PleComponentes()
        Cancelar_PleTipoDatoGrupo()
        Cancelar_PleTipoDato()
        Cancelar_PleTablasRelacionadas()
        Cancelar_PleTipoDatoComponenteCampo()
        Cancelar_PleRequerimientos()
        Cancelar_PleRequerimientosComponentes()
        Cancelar_PleTablasComponentes()
        Cancelar_PleTipoDatoComponenteEspeciales()
        Cancelar_PleRutasArchivosTecnologias()
        Cancelar_PleMetricas()
        Cancelar_PleAnkis()
        Cancelar_PleAnkisImagenes()
        Cancelar_PleBBakup()
        Cancelar_PleDocumentacionComponente()
        'vbCrLf heigt 579
    End Sub
    '--==============================================================--



    '--==============================================================--

    Sub Cancelar_PleTecnologias()
        'Botones Del Menu
        Nuevo_Menu_PleTecnologias.Enabled = True
        Guardar_Menu_PleTecnologias.Enabled = False
        Editar_Menu_PleTecnologias.Enabled = True
        Actualizar_Menu_PleTecnologias.Enabled = False
        Eliminar_Menu_PleTecnologias.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleTecnologiasDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleTecnologiasTableAdapter.Fill(Me.DataSetMaestros.PleTecnologias)
        Bloquear_Objetos_PleTecnologias()
        Parar_Timer_PleTecnologias()
        Timer_Ubicar_En_Fila_PleTecnologias()
    End Sub

    '--==============================================================--

    'Insertar PleTecnologias
    '--=== INSERTAR 

    'Insertar PleTecnologias
    Private Sub SP_PleTecnologias_EDICION_INSERTAR(NombreTecnologia As String,
Validada As Boolean,
NombreCarpetaTecnologia As String,
ByVal ImagenTecnologia As Byte(),
DescripcionTecnologia As String
)
        Try
            Me.SP_PleTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTecnologias_EDICION_INSERTAR,
                                                            NombreTecnologia,
                                                            New System.Nullable(Of Integer)(CType(Validada, Integer)),
                                                            NombreCarpetaTecnologia,
                                                            ImagenTecnologia,
                                                            DescripcionTecnologia
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTecnologias")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    '--===  ACTUALIZAR 

    'Actualizar PleTecnologias
    Private Sub SP_PleTecnologias_EDICION_ACTUALIZAR(TecnologiaId As Integer,
NombreTecnologia As String,
Validada As Boolean,
NombreCarpetaTecnologia As String,
ByVal ImagenTecnologia As Byte(),
DescripcionTecnologia As String
)

        Try
            Me.SP_PleTecnologias_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTecnologias_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)),
                                                            NombreTecnologia,
                                                            New System.Nullable(Of Integer)(CType(Validada, Integer)),
                                                            NombreCarpetaTecnologia,
                                                            ImagenTecnologia,
                                                            DescripcionTecnologia
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTecnologias")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTecnologias_EDICION_ELIMINAR(TecnologiaId As Integer)
        Try
            Me.SP_PleTecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTecnologias_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)))
            Me.PleTecnologiasTableAdapter.Fill(Me.DataSetMaestros.PleTecnologias)
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTecnologias Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTecnologias()
        NombreTecnologiaTextBox.Enabled = False
        ValidadaCheckBox.Enabled = False
        NombreCarpetaTecnologiaTextBox.Enabled = False
        DescripcionTecnologiaRichTextBox.Enabled = False
        BtnCargarImagen.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTecnologias()
        NombreTecnologiaTextBox.Enabled = True
        ValidadaCheckBox.Enabled = True
        NombreCarpetaTecnologiaTextBox.Enabled = True
        DescripcionTecnologiaRichTextBox.Enabled = True
        BtnCargarImagen.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTecnologias()
        NombreTecnologiaTextBox.Text = ""
        'ValidadaTextBox.Text = ""
        NombreCarpetaTecnologiaTextBox.Text = ""
        DescripcionTecnologiaRichTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTecnologias()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreTecnologiaTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre Tecnologia; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTecnologiaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case NombreCarpetaTecnologiaTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre CarpetaTecnologia; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreCarpetaTecnologiaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTecnologias.Click
        Nuevo_Menu_PleTecnologias.Enabled = False
        Editar_Menu_PleTecnologias.Enabled = False
        ValidarCierre.Text = 1
        PleTecnologiasDataGridView.Enabled = False
        Limpiar_Objetos_PleTecnologias()
        NombreTecnologiaTextBox.Enabled = True
        NombreTecnologiaTextBox.Focus()
    End Sub

    '--==============================================================--
    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTecnologias.Click
        Control_Nulos_PleTecnologias()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox.Image
            SP_PleTecnologias_EDICION_INSERTAR(NombreTecnologiaTextBox.Text,
        ValidadaTextBox.Text,
        NombreCarpetaTecnologiaTextBox.Text,
        (ImagenToBytes(myImg)),
        DescripcionTecnologiaRichTextBox.Text
)
            Cancelar_PleTecnologias()
            Parar_Timer_PleTecnologias()
        End If
    End Sub


    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTecnologias.Click
        Nuevo_Menu_PleTecnologias.Enabled = False
        Guardar_Menu_PleTecnologias.Enabled = False
        Editar_Menu_PleTecnologias.Enabled = False
        Actualizar_Menu_PleTecnologias.Enabled = True
        Eliminar_Menu_PleTecnologias.Enabled = True
        PleTecnologiasDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTecnologias()
        Timer_Actualizar_PleTecnologias()
        Timer_Eliminar_PleTecnologias()
    End Sub

    '--==============================================================--
    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTecnologias.Click
        Control_Nulos_PleTecnologias()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox.Image
            SP_PleTecnologias_EDICION_ACTUALIZAR(TecnologiaIdTextBox.Text,
        NombreTecnologiaTextBox.Text,
        ValidadaTextBox.Text,
        NombreCarpetaTecnologiaTextBox.Text,
        (ImagenToBytes(myImg)),
        DescripcionTecnologiaRichTextBox.Text
)
            Cancelar_PleTecnologias()
            Parar_Timer_PleTecnologias()
        End If
    End Sub


    '--==============================================================--

    Private Sub Eliminar_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTecnologias.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTecnologias_EDICION_ELIMINAR(TecnologiaIdTextBox.Text)
            Cancelar_PleTecnologias()
            Parar_Timer_PleTecnologias()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTecnologias()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTecnologias.Click
        Cancelar_PleTecnologias()
    End Sub

    '--==============================================================--

    'Salir
    Private Sub Salir_Menu_PleTecnologias_Click(sender As Object, e As EventArgs) Handles Salir_Menu_PleTecnologias.Click
        If ValidarCierre.Text = "" Then
            Me.Close()
        Else
            Metodo_Aviso_Acciones(3, "Accion en proceso")
        End If
    End Sub

    '--==============================================================--
    'Navegacion

    Private Sub NombreTecnologiaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTecnologiaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreTecnologiaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                NombreTecnologiaTextBox.Text = ""
                NombreTecnologiaTextBox.Focus()
            Else
                NombreCarpetaTecnologiaTextBox.Enabled = True
                NombreCarpetaTecnologiaTextBox.Focus()
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (NombreTecnologiaTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(NombreTecnologiaTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreTecnologiaTextBox.Text = ""
            NombreTecnologiaTextBox.Text = Caracter
            NombreTecnologiaTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(NombreTecnologiaTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(NombreTecnologiaTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(NombreTecnologiaTextBox.Text, 1)
            Caracter = UCase(Caracter)
            NombreTecnologiaTextBox.Text = ""
            NombreTecnologiaTextBox.Text = Temp + Caracter
            NombreTecnologiaTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    '--==============================================================--
    Private Sub NombreCarpetaTecnologiaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreCarpetaTecnologiaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTecnologias.Enabled = True Then
                Actualizar_Menu_PleTecnologias.Enabled = True
                Eliminar_Menu_PleTecnologias.Enabled = True
            Else
                If NombreCarpetaTecnologiaTextBox.Text = "" Then
                    MsgBox("Validada Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    NombreCarpetaTecnologiaTextBox.Text = ""
                    NombreCarpetaTecnologiaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTecnologias.Enabled = True
                    Timer_Guardar_PleTecnologias()
                End If
            End If
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales

    Private Sub ValidadaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValidadaCheckBox.CheckedChanged
        If ValidadaCheckBox.Checked = True Then
            ValidadaCheckBox.Text = "Activo"
            ValidadaTextBox.Text = "True"
        Else
            ValidadaCheckBox.Text = "Inactivo"
            ValidadaTextBox.Text = "False"
        End If
    End Sub

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
    'Agregar un Picturebox y darle por nombre ImagenPictureBox
    'Agregar un boton y darle por nombre BtnCargarImagen
    Dim IMAGEN As String
    Dim OpenFileDialogTecno As New OpenFileDialog
    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        ImagenPictureBox.Image = Nothing
        Try
            Me.OpenFileDialogTecno.ShowDialog()
            If Me.OpenFileDialogTecno.FileName <> "" Then
                IMAGEN = OpenFileDialogTecno.FileName
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

    Private Sub RbNormal_CheckedChanged(sender As Object, e As EventArgs) Handles RbNormal.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.Normal
    End Sub

    Private Sub RbAjustado_CheckedChanged(sender As Object, e As EventArgs) Handles RbAjustado.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub RbCentrada_CheckedChanged(sender As Object, e As EventArgs) Handles RbCentrada.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub

    Private Sub RbZoom_CheckedChanged(sender As Object, e As EventArgs) Handles RbZoom.CheckedChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTecnologias As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTecnologias As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTecnologias As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTecnologias()
        Me.Timer_Guardar_Menu_PleTecnologias = New Timer
        Timer_Guardar_Menu_PleTecnologias.Interval = 250
        Timer_Guardar_Menu_PleTecnologias.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTecnologias()
        Me.Timer_Actualizar_Menu_PleTecnologias = New Timer
        Timer_Actualizar_Menu_PleTecnologias.Interval = 500
        Timer_Actualizar_Menu_PleTecnologias.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTecnologias()
        Me.Timer_Eliminar_Menu_PleTecnologias = New Timer
        Timer_Eliminar_Menu_PleTecnologias.Interval = 800
        Timer_Eliminar_Menu_PleTecnologias.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTecnologias.Tick
        If Guardar_Menu_PleTecnologias.BackColor = Color.White Then
            Guardar_Menu_PleTecnologias.BackColor = Color.Green
        Else
            Guardar_Menu_PleTecnologias.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTecnologias.Tick
        If Actualizar_Menu_PleTecnologias.BackColor = Color.White Then
            Actualizar_Menu_PleTecnologias.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTecnologias.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTecnologias.Tick
        If Eliminar_Menu_PleTecnologias.BackColor = Color.White Then
            Eliminar_Menu_PleTecnologias.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTecnologias.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTecnologias()
        Me.Timer_Guardar_Menu_PleTecnologias = New Timer
        Timer_Guardar_Menu_PleTecnologias.Stop()
        Guardar_Menu_PleTecnologias.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTecnologias = New Timer
        Timer_Actualizar_Menu_PleTecnologias.Stop()
        Actualizar_Menu_PleTecnologias.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTecnologias = New Timer
        Timer_Eliminar_Menu_PleTecnologias.Stop()
        Eliminar_Menu_PleTecnologias.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTecnologias As Timer
    Dim X_PleTecnologias
    Private Sub Timer_Ubicar_En_Fila_PleTecnologias()
        Me.Timer_Ubicacion_PleTecnologias = New Timer
        Timer_Ubicacion_PleTecnologias.Interval = 100
        Timer_Ubicacion_PleTecnologias.Start()
    End Sub

    '--==============================================================--

    Private Sub PleTecnologiasDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleTecnologiasDataGridView.CellMouseClick
        X_PleTecnologias = PleTecnologiasDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTecnologias()
        Try
            Me.PleTecnologiasDataGridView.Rows(X_PleTecnologias).Selected = True
            Me.PleTecnologiasDataGridView.FirstDisplayedScrollingRowIndex = X_PleTecnologias
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTecnologias.Tick
        Ubicar_En_Fila_PleTecnologias()
        Timer_Ubicacion_PleTecnologias.Stop()
    End Sub



#End Region

#End Region

#End Region

#Region "TODO PlePlantilla"

    '--==============================================================--

    Sub Cancelar_PlePlantilla()
        'Botones Del Menu
        Nuevo_Menu_PlePlantilla.Enabled = True
        Guardar_Menu_PlePlantilla.Enabled = False
        Editar_Menu_PlePlantilla.Enabled = True
        Actualizar_Menu_PlePlantilla.Enabled = False
        Eliminar_Menu_PlePlantilla.Enabled = False
        BtnSubirFila.Enabled = False
        BtnBajarFila.Enabled = False
        DGVEdicionPosicion.Visible = False
        ValidarCierre.Text = ""
        ChkMover.Checked = False
        'Grid
        SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If TecnologiaIdTextBox.Text <> "" Then
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
        End If
        Bloquear_Objetos_PlePlantilla()
        Parar_Timer_PlePlantilla()
        Timer_Ubicar_En_Fila_PlePlantilla()
    End Sub

    '--==============================================================--

    'Insertar PlePlantilla
    Private Sub SP_PlePlantilla_EDICION_INSERTAR(TecnologiaId As Integer,
NombrePlantilla As String,
Orden As Integer,
Seleccionada As Boolean
)
        Try
            Me.SP_PlePlantilla_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)),
                                                 NombrePlantilla,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(Seleccionada, Boolean)))
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PlePlantilla")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PlePlantilla
    Private Sub SP_PlePlantilla_EDICION_ACTUALIZAR(PlantillaId As Integer,
TecnologiaId As Integer,
NombrePlantilla As String,
Orden As Integer,
Seleccionada As Boolean
)

        Try
            Me.SP_PlePlantilla_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PlantillaId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)),
                                                 NombrePlantilla,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(Seleccionada, Boolean))
)
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PlePlantilla")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PlePlantilla_EDICION_ACTUALIZAR_Ordenamiento(PlantillaId As Integer,
TecnologiaId As Integer,
NombrePlantilla As String,
Orden As Integer,
Seleccionada As Boolean
)

        Try
            Me.SP_PlePlantilla_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PlantillaId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)),
                                                 NombrePlantilla,
                                                 New System.Nullable(Of Integer)(CType(Orden, Integer)),
                                                 New System.Nullable(Of Boolean)(CType(Seleccionada, Boolean)))
            'Metodo_Aviso_Acciones(1, "Actualizado")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PlePlantilla_EDICION_ELIMINAR(PlantillaId As Integer)
        Try
            Me.SP_PlePlantilla_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
            Metodo_Aviso_Acciones(3, "Registro de la tabla PlePlantilla Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PlePlantilla()
        TecnologiaIdTextBox.Enabled = False
        NombrePlantillaTextBox.Enabled = False
        OrdenTextBox.Enabled = False
        SeleccionadaTextBox.Enabled = False

    End Sub

    Public Sub Desbloquear_Objetos_PlePlantilla()
        TecnologiaIdTextBox.Enabled = True
        NombrePlantillaTextBox.Enabled = True
        OrdenTextBox.Enabled = True
        SeleccionadaTextBox.Enabled = True

    End Sub

    Public Sub Limpiar_Objetos_PlePlantilla()
        NombrePlantillaTextBox.Text = ""
        SeleccionadaTextBox.Text = "False"
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PlePlantilla()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombrePlantillaTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre Plantilla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombrePlantillaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case OrdenTextBox.Text = ""
                MsgBox("El nombre del campo: Orden en plantilla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                OrdenTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PlePlantilla.Click
        Nuevo_Menu_PlePlantilla.Enabled = False
        Editar_Menu_PlePlantilla.Enabled = False
        OrdenTextBox.Text = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count + 1
        ValidarCierre.Text = 1
        SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = False
        Limpiar_Objetos_PlePlantilla()
        OrdenTextBox.Enabled = True
        NombrePlantillaTextBox.Enabled = True
        NombrePlantillaTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PlePlantilla.Click
        Control_Nulos_PlePlantilla()

        If ControlNulos.Text = "" Then
            SP_PlePlantilla_EDICION_INSERTAR(
        TecnologiaIdTextBox.Text,
        NombrePlantillaTextBox.Text,
        OrdenTextBox.Text,
        SeleccionadaTextBox.Text
)
            Cancelar_PlePlantilla()
            ActualizarItems1()
            Parar_Timer_PlePlantilla()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PlePlantilla.Click
        Nuevo_Menu_PlePlantilla.Enabled = False
        Guardar_Menu_PlePlantilla.Enabled = False
        Editar_Menu_PlePlantilla.Enabled = False
        Actualizar_Menu_PlePlantilla.Enabled = True
        Eliminar_Menu_PlePlantilla.Enabled = True
        SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PlePlantilla()
        Timer_Actualizar_PlePlantilla()
        Timer_Eliminar_PlePlantilla()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PlePlantilla.Click
        Control_Nulos_PlePlantilla()

        If ControlNulos.Text = "" Then
            SP_PlePlantilla_EDICION_ACTUALIZAR(
        PlantillaIdTextBox.Text,
        TecnologiaIdTextBox.Text,
        NombrePlantillaTextBox.Text,
        OrdenTextBox.Text,
        SeleccionadaTextBox.Text)
            Cancelar_PlePlantilla()
            Parar_Timer_PlePlantilla()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PlePlantilla.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PlePlantilla_EDICION_ELIMINAR(PlantillaIdTextBox.Text)
            Cancelar_PlePlantilla()
            ActualizarItems1()
            Parar_Timer_PlePlantilla()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PlePlantilla()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PlePlantilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PlePlantilla.Click
        Cancelar_PlePlantilla()
    End Sub

    '--==============================================================--
    'Navegacion

    Private Sub OrdenTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OrdenTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PlePlantilla.Enabled = True Then
                Actualizar_Menu_PlePlantilla.Enabled = True
                Eliminar_Menu_PlePlantilla.Enabled = True
            Else
                If OrdenTextBox.Text = "" Then
                    MsgBox("Seleccionada Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    OrdenTextBox.Text = ""
                    OrdenTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PlePlantilla.Enabled = True
                    Timer_Guardar_PlePlantilla()
                End If
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub NombrePlantillaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombrePlantillaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PlePlantilla.Enabled = True Then
                Actualizar_Menu_PlePlantilla.Enabled = True
                Eliminar_Menu_PlePlantilla.Enabled = True
            Else
                If NombrePlantillaTextBox.Text = "" Then
                    MsgBox("Seleccionada Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    NombrePlantillaTextBox.Text = ""
                    NombrePlantillaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PlePlantilla.Enabled = True
                    Timer_Guardar_PlePlantilla()
                End If
            End If
        End If
    End Sub


    '--==============================================================--
    ' Especiales

    Private Sub SeleccionadaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If SeleccionadaCheckBox.Checked = True Then
        '    SeleccionadaCheckBox.Text = "Activo"
        '    SeleccionadaTextBox.Text = "True"
        'Else
        '    SeleccionadaCheckBox.Text = "Inactivo"
        '    SeleccionadaTextBox.Text = "False"
        'End If
    End Sub


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PlePlantilla As Timer
    Private WithEvents Timer_Actualizar_Menu_PlePlantilla As Timer
    Private WithEvents Timer_Eliminar_Menu_PlePlantilla As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PlePlantilla()
        Me.Timer_Guardar_Menu_PlePlantilla = New Timer
        Timer_Guardar_Menu_PlePlantilla.Interval = 250
        Timer_Guardar_Menu_PlePlantilla.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PlePlantilla()
        Me.Timer_Actualizar_Menu_PlePlantilla = New Timer
        Timer_Actualizar_Menu_PlePlantilla.Interval = 500
        Timer_Actualizar_Menu_PlePlantilla.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PlePlantilla()
        Me.Timer_Eliminar_Menu_PlePlantilla = New Timer
        Timer_Eliminar_Menu_PlePlantilla.Interval = 800
        Timer_Eliminar_Menu_PlePlantilla.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PlePlantilla_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PlePlantilla.Tick
        If Guardar_Menu_PlePlantilla.BackColor = Color.White Then
            Guardar_Menu_PlePlantilla.BackColor = Color.Green
        Else
            Guardar_Menu_PlePlantilla.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PlePlantilla_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PlePlantilla.Tick
        If Actualizar_Menu_PlePlantilla.BackColor = Color.White Then
            Actualizar_Menu_PlePlantilla.BackColor = Color.Green
        Else
            Actualizar_Menu_PlePlantilla.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PlePlantilla_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PlePlantilla.Tick
        If Eliminar_Menu_PlePlantilla.BackColor = Color.White Then
            Eliminar_Menu_PlePlantilla.BackColor = Color.Red
        Else
            Eliminar_Menu_PlePlantilla.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PlePlantilla()
        Me.Timer_Guardar_Menu_PlePlantilla = New Timer
        Timer_Guardar_Menu_PlePlantilla.Stop()
        Guardar_Menu_PlePlantilla.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PlePlantilla = New Timer
        Timer_Actualizar_Menu_PlePlantilla.Stop()
        Actualizar_Menu_PlePlantilla.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PlePlantilla = New Timer
        Timer_Eliminar_Menu_PlePlantilla.Stop()
        Eliminar_Menu_PlePlantilla.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PlePlantilla As Timer
    Dim X_PlePlantilla
    Private Sub Timer_Ubicar_En_Fila_PlePlantilla()
        Me.Timer_Ubicacion_PlePlantilla = New Timer
        Timer_Ubicacion_PlePlantilla.Interval = 100
        Timer_Ubicacion_PlePlantilla.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CellMouseClick
        X_PlePlantilla = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CurrentRow.Index
        lblCantTecn.Text = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PlePlantilla()
        Try
            Me.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows(X_PlePlantilla).Selected = True
            Me.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.FirstDisplayedScrollingRowIndex = X_PlePlantilla
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PlePlantilla_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PlePlantilla.Tick
        Ubicar_En_Fila_PlePlantilla()
        Timer_Ubicacion_PlePlantilla.Stop()
    End Sub


#End Region

    '--==============================================================--

#Region "Tabla de Seleccion Orden"
    Dim table As New DataTable
    Dim rowIndex As Integer
    Private Sub ChkMover_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMover.CheckedChanged
        If ChkMover.Checked = True Then
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = False
            DGVEdicionPosicion.Visible = True
            CargarGridEdicion()
            BtnSubirFila.Enabled = True
            BtnBajarFila.Enabled = True
            Nuevo_Menu_PlePlantilla.Enabled = False
            Editar_Menu_PlePlantilla.Enabled = False
            'Cancelar_Menu_PlePlantilla.Enabled = False
        Else
            ActualizarItems2()
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Enabled = True
            DGVEdicionPosicion.Visible = False
            CargarGridEdicion()
            BtnSubirFila.Enabled = False
            BtnBajarFila.Enabled = False
            Nuevo_Menu_PlePlantilla.Enabled = True
            Editar_Menu_PlePlantilla.Enabled = True
            Cancelar_Menu_PlePlantilla.Enabled = True
        End If
    End Sub
    Private Sub ActualizarItems2()
        Dim orden As Integer = 1

        Dim contador As Integer = DGVEdicionPosicion.Rows.Count
        While contador > 0
            'Se ubica en la primera fila
            DGVEdicionPosicion.CurrentCell = DGVEdicionPosicion.Rows(0).Cells(0)
            Try
                SP_PlePlantilla_EDICION_ACTUALIZAR_Ordenamiento(Convert.ToString(DGVEdicionPosicion.CurrentRow.Cells(2).Value), TecnologiaIdTextBox.Text, Convert.ToString(DGVEdicionPosicion.CurrentRow.Cells(1).Value), orden, False)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            DGVEdicionPosicion.Rows.RemoveAt(0)
            contador -= 1
            orden += 1
        End While
        Cancelar_PlePlantilla()
    End Sub
    Private Sub ActualizarItems1()
        Dim orden As Integer = 1

        Dim contador As Integer = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count
        While contador > 0

            'Se ubica en la primera fila
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.CurrentCell = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows(0).Cells(0)
            Try
                SP_PlePlantilla_EDICION_ACTUALIZAR_Ordenamiento(PlantillaIdTextBox.Text, TecnologiaIdTextBox.Text, NombrePlantillaTextBox.Text, orden, False)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.RemoveAt(0)
            contador -= 1
            orden += 1
        End While
        Cancelar_PlePlantilla()
    End Sub
    Private Sub ActualizarItem(PlantillaID As Integer, Nombre As String, item As Integer)
        Try
            PlantillaIdTextBox.Text = PlantillaID
            NombrePlantillaTextBox.Text = Nombre
            OrdenTextBox.Text = item
            SP_PlePlantilla_EDICION_ACTUALIZAR(PlantillaIdTextBox.Text, TecnologiaIdTextBox.Text, Nombre, item, False)
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
                DGVEdicionPosicion.Columns(1).Width = 319
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

    '--==============================================================--

#End Region

#End Region

#Region "TODO PleComponentes"

    Private Sub SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaId As Integer)
        Try
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId,
                                                                                       New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub Cancelar_PleComponentes()
        'Botones Del Menu
        Nuevo_Menu_PleComponentes.Enabled = True
        Guardar_Menu_PleComponentes.Enabled = False
        Editar_Menu_PleComponentes.Enabled = True
        Actualizar_Menu_PleComponentes.Enabled = False
        Eliminar_Menu_PleComponentes.Enabled = False
        ValidarCierre.Text = ""
        BtnLLenarCampos.Enabled = False
        'Grid
        SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If PlantillaIdTextBox.Text <> "" Then
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBox.Text)
        End If
        Bloquear_Objetos_PleComponentes()
        Parar_Timer_PleComponentes()
        Timer_Ubicar_En_Fila_PleComponentes()
    End Sub

    '--==============================================================--

    'Insertar PleComponentes
    Private Sub SP_PleComponentes_EDICION_INSERTAR(PlantillaId As Integer,
NombreComponente As String,
XTabla As Boolean,
Base As Boolean,
CodUno As String,
CodDos As String,
CodTres As String,
CodCuatro As String,
CodCinco As String,
CodSeis As String
)
        Try
            Me.SP_PleComponentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(PlantillaId, Integer)),
                                                 NombreComponente,
                                                 New System.Nullable(Of Boolean)(CType(XTabla, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(Base, Boolean)),
                                                 CodUno,
                                                 CodDos,
                                                 CodTres,
                                                 CodCuatro,
                                                 CodCinco,
                                                 CodSeis
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleComponentes
    Private Sub SP_PleComponentes_EDICION_ACTUALIZAR(ComponenteId As Integer,
PlantillaId As Integer,
NombreComponente As String,
XTabla As Boolean,
Base As Boolean,
CodUno As String,
CodDos As String,
CodTres As String,
CodCuatro As String,
CodCinco As String,
CodSeis As String
)

        Try
            Me.SP_PleComponentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaId, Integer)),
                                                 NombreComponente,
                                                 New System.Nullable(Of Boolean)(CType(XTabla, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(Base, Boolean)),
                                                 CodUno,
                                                 CodDos,
                                                 CodTres,
                                                 CodCuatro,
                                                 CodCinco,
                                                 CodSeis
)
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaId)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleComponentes_EDICION_ELIMINAR(ComponenteId As Integer)
        Try
            Me.SP_PleComponentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBox.Text)
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleComponentes Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleComponentes()
        PlantillaIdTextBox.Enabled = False
        NombreComponenteTextBox.Enabled = False
        XTablaCheckBox.Enabled = False
        BaseCheckBox.Enabled = False
        'CodUnoTextBox.Enabled = False
        'CodDosTextBox.Enabled = False
        'CodTresTextBox.Enabled = False
        'CodCuatroTextBox.Enabled = False
        'CodCincoTextBox.Enabled = False
        'CodSeisTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleComponentes()
        PlantillaIdTextBox.Enabled = True
        NombreComponenteTextBox.Enabled = True
        XTablaCheckBox.Enabled = True
        BaseCheckBox.Enabled = True
        'CodUnoTextBox.Enabled = True
        'CodDosTextBox.Enabled = True
        'CodTresTextBox.Enabled = True
        'CodCuatroTextBox.Enabled = True
        'CodCincoTextBox.Enabled = True
        'CodSeisTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleComponentes()
        NombreComponenteTextBox.Text = ""
        XTablaTextBox.Text = ""
        BaseTextBox.Text = ""
        CodUnoTextBox.Text = ""
        CodDosTextBox.Text = ""
        CodTresTextBox.Text = ""
        CodCuatroTextBox.Text = ""
        CodCincoTextBox.Text = ""
        CodSeisTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleComponentes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreComponenteTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre Componente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreComponenteTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case XTablaTextBox.Text = ""
                MsgBox("El nombre del campo: Componente por tabla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                XTablaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case BaseTextBox.Text = ""
                MsgBox("El nombre del campo: Es componete base; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                BaseTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodUnoTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo uno; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodUnoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodDosTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo dos; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodDosTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodTresTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo tres; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodTresTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodCuatroTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo cuatro; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodCuatroTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodCincoTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo cinco; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodCincoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodSeisTextBox.Text = ""
                MsgBox("El nombre del campo: Codigo tipo seis; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodSeisTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleComponentes.Click
        If SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows.Count = 1 Then
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId_Base(PlantillaIdTextBox.Text)
            If ValorBaseCheckBox.Checked = True Then
                Nuevo_Menu_PleComponentes.Enabled = False
                Editar_Menu_PleComponentes.Enabled = False
                BtnLLenarCampos.Enabled = True
                ValidarCierre.Text = 1
                SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Enabled = False
                Limpiar_Objetos_PleComponentes()
                NombreComponenteTextBox.Enabled = True
                NombreComponenteTextBox.Focus()
                BaseTextBox.Text = False
            Else
                MsgBox("Este no es un componente base para poder crear otro componente, favor verificar", MsgBoxStyle.Critical)
            End If
        Else
            Nuevo_Menu_PleComponentes.Enabled = False
            Editar_Menu_PleComponentes.Enabled = False
            BtnLLenarCampos.Enabled = True
            ValidarCierre.Text = 1
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Enabled = False
            Limpiar_Objetos_PleComponentes()
            NombreComponenteTextBox.Enabled = True
            NombreComponenteTextBox.Focus()
            BaseTextBox.Text = False
        End If
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleComponentes.Click
        Control_Nulos_PleComponentes()
        NombreComponenteTextBox.Text = quitarSaltosLinea(NombreComponenteTextBox.Text, "")
        If ControlNulos.Text = "" Then
            SP_PleComponentes_EDICION_INSERTAR(
        PlantillaIdTextBox.Text,
        NombreComponenteTextBox.Text,
        XTablaTextBox.Text,
        BaseTextBox.Text,
        CodUnoTextBox.Text,
        CodDosTextBox.Text,
        CodTresTextBox.Text,
        CodCuatroTextBox.Text,
        CodCincoTextBox.Text,
        CodSeisTextBox.Text
)
            Cancelar_PleComponentes()
            Parar_Timer_PleComponentes()
        End If
    End Sub
    Public Function quitarSaltosLinea(ByVal texto As String, caracterReemplazar As String) As String
        quitarSaltosLinea = Replace(Replace(texto, Chr(10), caracterReemplazar), Chr(13), caracterReemplazar)
        Return quitarSaltosLinea
    End Function
    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleComponentes.Click
        Nuevo_Menu_PleComponentes.Enabled = False
        Guardar_Menu_PleComponentes.Enabled = False
        Editar_Menu_PleComponentes.Enabled = False
        Actualizar_Menu_PleComponentes.Enabled = True
        Eliminar_Menu_PleComponentes.Enabled = True
        SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleComponentes()
        Timer_Actualizar_PleComponentes()
        Timer_Eliminar_PleComponentes()
        VALIDACION_BASE = BaseTextBox.Text
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleComponentes.Click
        Control_Nulos_PleComponentes()
        NombreComponenteTextBox.Text = quitarSaltosLinea(NombreComponenteTextBox.Text, "")
        If ControlNulos.Text = "" Then
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId_Base(PlantillaIdTextBox.Text)
            If ValorBaseCheckBox.Checked = True And VALIDACION_BASE <> BaseTextBox.Text Then
                MsgBox("Ya existe un compomente base para esta plantilla, favor verificar", MsgBoxStyle.Exclamation)
                Cancelar_PleComponentes()
                Parar_Timer_PleComponentes()
            Else
                SP_PleComponentes_EDICION_ACTUALIZAR(
ComponenteIdTextBox.Text,
PlantillaIdTextBox.Text,
NombreComponenteTextBox.Text,
XTablaTextBox.Text,
BaseTextBox.Text,
CodUnoTextBox.Text,
CodDosTextBox.Text,
CodTresTextBox.Text,
CodCuatroTextBox.Text,
CodCincoTextBox.Text,
CodSeisTextBox.Text
)
                Cancelar_PleComponentes()
                Parar_Timer_PleComponentes()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleComponentes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleComponentes_EDICION_ELIMINAR(ComponenteIdTextBox.Text)
            Cancelar_PleComponentes()
            Parar_Timer_PleComponentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleComponentes()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleComponentes.Click
        Cancelar_PleComponentes()
    End Sub


    '--==============================================================--
    'Navegacion

    '--==============================================================--
    Private Sub NombreComponenteTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreComponenteTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreComponenteTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                NombreComponenteTextBox.Text = ""
                NombreComponenteTextBox.Focus()
            Else
                XTablaCheckBox.Enabled = True
                XTablaCheckBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub XTablaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles XTablaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If XTablaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                XTablaTextBox.Text = ""
                XTablaCheckBox.Focus()
            Else
                CodUnoTextBox.Enabled = True
                CodUnoTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CodUnoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodUnoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If BtnArchivoUno.BackColor = Color.Transparent Then
                If Actualizar_Menu_PleComponentes.Enabled = True Then
                    Actualizar_Menu_PleComponentes.Enabled = True
                    Eliminar_Menu_PleComponentes.Enabled = True
                Else
                    If CodUnoTextBox.Text = "  " Then
                        MsgBox("Codigo tipo Uno Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                        CodUnoTextBox.Text = ""
                        CodUnoTextBox.Focus()
                    Else
                        MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                        Guardar_Menu_PleComponentes.Enabled = True
                        Timer_Guardar_PleComponentes()
                    End If
                End If
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CodDosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodDosTextBox.KeyPress
        If BtnArchivoDos.BackColor = Color.Transparent Then
            If Asc(e.KeyChar) = 13 Then
                If CodDosTextBox.Text = "" Then
                    MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                    CodDosTextBox.Text = ""
                    CodDosTextBox.Focus()
                Else
                    CodTresTextBox.Enabled = True
                    CodTresTextBox.Focus()
                End If
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CodTresTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodTresTextBox.KeyPress
        If BtnArchivoTres.BackColor = Color.Transparent Then
            If Asc(e.KeyChar) = 13 Then
                If CodTresTextBox.Text = "" Then
                    MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                    CodTresTextBox.Text = ""
                    CodTresTextBox.Focus()
                Else
                    CodCuatroTextBox.Enabled = True
                    CodCuatroTextBox.Focus()
                End If
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CodCuatroTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodCuatroTextBox.KeyPress
        If BtnArchivoCuatro.BackColor = Color.Transparent Then
            If Asc(e.KeyChar) = 13 Then
                If CodCuatroTextBox.Text = "" Then
                    MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                    CodCuatroTextBox.Text = ""
                    CodCuatroTextBox.Focus()
                Else
                    CodCincoTextBox.Enabled = True
                    CodCincoTextBox.Focus()
                End If
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CodCincoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodCincoTextBox.KeyPress
        If BtnArchivoCinco.BackColor = Color.Transparent Then
            If Asc(e.KeyChar) = 13 Then
                If CodCincoTextBox.Text = "" Then
                    MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreDelProyecto")
                    CodCincoTextBox.Text = ""
                    CodCincoTextBox.Focus()
                Else
                    CodSeisTextBox.Enabled = True
                    CodSeisTextBox.Focus()
                End If
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub CodSeisTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodSeisTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If BtnArchivoUno.BackColor = Color.Transparent Then
                If Actualizar_Menu_PleComponentes.Enabled = True Then
                    Actualizar_Menu_PleComponentes.Enabled = True
                    Eliminar_Menu_PleComponentes.Enabled = True
                Else
                    If CodSeisTextBox.Text = "  " Then
                        MsgBox("Codigo tipo Uno Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                        CodSeisTextBox.Text = ""
                        CodSeisTextBox.Focus()
                    Else
                        MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                        Guardar_Menu_PleComponentes.Enabled = True
                        Timer_Guardar_PleComponentes()
                    End If
                End If
            End If
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales

    Private Sub BaseCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BaseCheckBox.CheckedChanged
        If BaseCheckBox.Checked = True Then
            'Valida si existe un componente base
            BaseCheckBox.Text = "Es Base"
            BaseTextBox.Text = "True"

        Else
            BaseCheckBox.Text = ""
            BaseTextBox.Text = "False"

        End If
    End Sub

    Private Sub XTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTablaCheckBox.CheckedChanged
        If XTablaCheckBox.Checked = True Then
            XTablaCheckBox.Text = "x Tabla"
            XTablaTextBox.Text = "True"
        Else
            XTablaCheckBox.Text = "No"
            XTablaTextBox.Text = "False"
        End If
    End Sub

    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleComponentes As Timer
    Private WithEvents Timer_Actualizar_Menu_PleComponentes As Timer
    Private WithEvents Timer_Eliminar_Menu_PleComponentes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleComponentes()
        Me.Timer_Guardar_Menu_PleComponentes = New Timer
        Timer_Guardar_Menu_PleComponentes.Interval = 250
        Timer_Guardar_Menu_PleComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleComponentes()
        Me.Timer_Actualizar_Menu_PleComponentes = New Timer
        Timer_Actualizar_Menu_PleComponentes.Interval = 500
        Timer_Actualizar_Menu_PleComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleComponentes()
        Me.Timer_Eliminar_Menu_PleComponentes = New Timer
        Timer_Eliminar_Menu_PleComponentes.Interval = 800
        Timer_Eliminar_Menu_PleComponentes.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleComponentes.Tick
        If Guardar_Menu_PleComponentes.BackColor = Color.White Then
            Guardar_Menu_PleComponentes.BackColor = Color.Green
        Else
            Guardar_Menu_PleComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleComponentes.Tick
        If Actualizar_Menu_PleComponentes.BackColor = Color.White Then
            Actualizar_Menu_PleComponentes.BackColor = Color.Green
        Else
            Actualizar_Menu_PleComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleComponentes.Tick
        If Eliminar_Menu_PleComponentes.BackColor = Color.White Then
            Eliminar_Menu_PleComponentes.BackColor = Color.Red
        Else
            Eliminar_Menu_PleComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleComponentes()
        Me.Timer_Guardar_Menu_PleComponentes = New Timer
        Timer_Guardar_Menu_PleComponentes.Stop()
        Guardar_Menu_PleComponentes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleComponentes = New Timer
        Timer_Actualizar_Menu_PleComponentes.Stop()
        Actualizar_Menu_PleComponentes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleComponentes = New Timer
        Timer_Eliminar_Menu_PleComponentes.Stop()
        Eliminar_Menu_PleComponentes.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleComponentes As Timer
    Dim X_PleComponentes
    Private Sub Timer_Ubicar_En_Fila_PleComponentes()
        Me.Timer_Ubicacion_PleComponentes = New Timer
        Timer_Ubicacion_PleComponentes.Interval = 100
        Timer_Ubicacion_PleComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.CellMouseClick
        X_PleComponentes = SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleComponentes()
        Try
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.Rows(X_PleComponentes).Selected = True
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleComponentes
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleComponentes.Tick
        Ubicar_En_Fila_PleComponentes()
        Timer_Ubicacion_PleComponentes.Stop()
    End Sub

    Private Sub SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId_Base(PlantillaId As Integer)
        Try
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId_BaseTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId_Base,
                                                                                            New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


#End Region

#End Region

#End Region

#Region "TODO PleTipoDato"

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId,
                                                                                        New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId1(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId1TableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId1,
                                                                                         New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--
    Sub Cancelar_PleTipoDato()
        'Botones Del Menu
        Nuevo_Menu_PleTipoDato.Enabled = True
        Guardar_Menu_PleTipoDato.Enabled = False
        Editar_Menu_PleTipoDato.Enabled = True
        Actualizar_Menu_PleTipoDato.Enabled = False
        Eliminar_Menu_PleTipoDato.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If TipoDatoGrupoIdPosUno.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoIdPosUno.Text)
        End If
        Bloquear_Objetos_PleTipoDato()
        Parar_Timer_PleTipoDato()
        Timer_Ubicar_En_Fila_PleTipoDato()
    End Sub

    '--==============================================================--

    'Insertar PleTipoDato
    Private Sub SP_PleTipoDato_EDICION_INSERTAR(NombreTipo As String,
Descripcion As String,
TipoDatoGrupoId As Integer
)
        Try
            Me.SP_PleTipoDato_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_EDICION_INSERTAR,
                                                 NombreTipo,
                                                 Descripcion,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTipoDato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTipoDato
    Private Sub SP_PleTipoDato_EDICION_ACTUALIZAR(TipoDatoId As Integer,
NombreTipo As String,
Descripcion As String,
TipoDatoGrupoId As Integer
)

        Try
            Me.SP_PleTipoDato_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 NombreTipo,
                                                 Descripcion,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTipoDato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTipoDato_EDICION_ELIMINAR(TipoDatoId As Integer)
        Try
            Me.SP_PleTipoDato_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTipoDato Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTipoDato()
        NombreTipoTextBox.Enabled = False
        DescripcionTextBox1.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTipoDato()
        NombreTipoTextBox.Enabled = True
        DescripcionTextBox1.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTipoDato()
        NombreTipoTextBox.Text = ""
        DescripcionTextBox1.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTipoDato()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreTipoTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion tipo documeto; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreTipoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionTextBox1.Text = ""
                MsgBox("El nombre del campo: Descripcion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionTextBox1.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTipoDato.Click
        Nuevo_Menu_PleTipoDato.Enabled = False
        Editar_Menu_PleTipoDato.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTipoDato()
        NombreTipoTextBox.Enabled = True
        NombreTipoTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTipoDato.Click
        Control_Nulos_PleTipoDato()

        If ControlNulos.Text = "" Then
            SP_PleTipoDato_EDICION_INSERTAR(
        NombreTipoTextBox.Text,
        DescripcionTextBox1.Text,
        TipoDatoGrupoIdPosUno.Text
)
            Cancelar_PleTipoDato()
            Parar_Timer_PleTipoDato()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTipoDato.Click
        Nuevo_Menu_PleTipoDato.Enabled = False
        Guardar_Menu_PleTipoDato.Enabled = False
        Editar_Menu_PleTipoDato.Enabled = False
        Actualizar_Menu_PleTipoDato.Enabled = True
        Eliminar_Menu_PleTipoDato.Enabled = True
        SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTipoDato()
        Timer_Actualizar_PleTipoDato()
        Timer_Eliminar_PleTipoDato()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTipoDato.Click
        Control_Nulos_PleTipoDato()

        If ControlNulos.Text = "" Then
            SP_PleTipoDato_EDICION_ACTUALIZAR(
        TipoDatoIdPosUno.Text,
        NombreTipoTextBox.Text,
        DescripcionTextBox1.Text,
        TipoDatoGrupoIdPosUno.Text
)
            Cancelar_PleTipoDato()
            Parar_Timer_PleTipoDato()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTipoDato.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTipoDato_EDICION_ELIMINAR(TipoDatoIdPosUno.Text)
            Cancelar_PleTipoDato()
            Parar_Timer_PleTipoDato()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTipoDato()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTipoDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTipoDato.Click
        Cancelar_PleTipoDato()
    End Sub


    '--==============================================================--
    'Navegacion

    Private Sub NombreTipoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTipoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreTipoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "proyecto")
                NombreTipoTextBox.Text = ""
                NombreTipoTextBox.Focus()
            Else
                DescripcionTextBox1.Enabled = True
                DescripcionTextBox1.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub DescripcionTextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTipoDato.Enabled = True Then
                Actualizar_Menu_PleTipoDato.Enabled = True
                Eliminar_Menu_PleTipoDato.Enabled = True
            Else
                If DescripcionTextBox1.Text = "" Then
                    MsgBox("Grupo del tipo de dato Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    DescripcionTextBox1.Text = ""
                    DescripcionTextBox1.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTipoDato.Enabled = True
                    Timer_Guardar_PleTipoDato()
                End If
            End If
        End If
    End Sub


    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTipoDato As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTipoDato As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTipoDato As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTipoDato()
        Me.Timer_Guardar_Menu_PleTipoDato = New Timer
        Timer_Guardar_Menu_PleTipoDato.Interval = 250
        Timer_Guardar_Menu_PleTipoDato.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTipoDato()
        Me.Timer_Actualizar_Menu_PleTipoDato = New Timer
        Timer_Actualizar_Menu_PleTipoDato.Interval = 500
        Timer_Actualizar_Menu_PleTipoDato.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTipoDato()
        Me.Timer_Eliminar_Menu_PleTipoDato = New Timer
        Timer_Eliminar_Menu_PleTipoDato.Interval = 800
        Timer_Eliminar_Menu_PleTipoDato.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTipoDato_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTipoDato.Tick
        If Guardar_Menu_PleTipoDato.BackColor = Color.White Then
            Guardar_Menu_PleTipoDato.BackColor = Color.Green
        Else
            Guardar_Menu_PleTipoDato.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTipoDato_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTipoDato.Tick
        If Actualizar_Menu_PleTipoDato.BackColor = Color.White Then
            Actualizar_Menu_PleTipoDato.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTipoDato.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTipoDato_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTipoDato.Tick
        If Eliminar_Menu_PleTipoDato.BackColor = Color.White Then
            Eliminar_Menu_PleTipoDato.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTipoDato.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTipoDato()
        Me.Timer_Guardar_Menu_PleTipoDato = New Timer
        Timer_Guardar_Menu_PleTipoDato.Stop()
        Guardar_Menu_PleTipoDato.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTipoDato = New Timer
        Timer_Actualizar_Menu_PleTipoDato.Stop()
        Actualizar_Menu_PleTipoDato.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTipoDato = New Timer
        Timer_Eliminar_Menu_PleTipoDato.Stop()
        Eliminar_Menu_PleTipoDato.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTipoDato As Timer
    Dim X_PleTipoDato
    Private Sub Timer_Ubicar_En_Fila_PleTipoDato()
        Me.Timer_Ubicacion_PleTipoDato = New Timer
        Timer_Ubicacion_PleTipoDato.Interval = 100
        Timer_Ubicacion_PleTipoDato.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.CellMouseClick
        X_PleTipoDato = SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTipoDato()
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.Rows(X_PleTipoDato).Selected = True
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTipoDato
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTipoDato_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTipoDato.Tick
        Ubicar_En_Fila_PleTipoDato()
        Timer_Ubicacion_PleTipoDato.Stop()
    End Sub

#End Region

#End Region

#End Region

#Region "TODO PleTipoDatoGrupo"

    '--==============================================================--

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
        LblInforme.Width = 108
        LblInforme.Height = 50
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

    Sub Cancelar_PleTipoDatoGrupo()
        'Botones Del Menu
        Nuevo_Menu_PleTipoDatoGrupo.Enabled = True
        Guardar_Menu_PleTipoDatoGrupo.Enabled = False
        Editar_Menu_PleTipoDatoGrupo.Enabled = True
        Actualizar_Menu_PleTipoDatoGrupo.Enabled = False
        Eliminar_Menu_PleTipoDatoGrupo.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleTipoDatoGrupoDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
        Bloquear_Objetos_PleTipoDatoGrupo()
        Parar_Timer_PleTipoDatoGrupo()
        Timer_Ubicar_En_Fila_PleTipoDatoGrupo()
    End Sub

    '--==============================================================--

    'Insertar PleTipoDatoGrupo
    Private Sub SP_PleTipoDatoGrupo_EDICION_INSERTAR(NombreGrupo As String,
Descripcion As String
)
        Try
            Me.SP_PleTipoDatoGrupo_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoGrupo_EDICION_INSERTAR,
                                                 NombreGrupo,
                                                 Descripcion
)
            Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTipoDatoGrupo")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTipoDatoGrupo
    Private Sub SP_PleTipoDatoGrupo_EDICION_ACTUALIZAR(TipoDatoGrupoId As Integer,
NombreGrupo As String,
Descripcion As String
)

        Try
            Me.SP_PleTipoDatoGrupo_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoGrupo_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)),
                                                 NombreGrupo,
                                                 Descripcion
)
            Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTipoDatoGrupo")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTipoDatoGrupo_EDICION_ELIMINAR(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDatoGrupo_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoGrupo_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
            Me.PleTipoDatoGrupoTableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo)
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTipoDatoGrupo Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTipoDatoGrupo()
        NombreGrupoTextBox.Enabled = False
        DescripcionTextBox.Enabled = False

    End Sub

    Public Sub Desbloquear_Objetos_PleTipoDatoGrupo()
        NombreGrupoTextBox.Enabled = True
        DescripcionTextBox.Enabled = True

    End Sub

    Public Sub Limpiar_Objetos_PleTipoDatoGrupo()
        NombreGrupoTextBox.Text = ""
        DescripcionTextBox.Text = ""

    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTipoDatoGrupo()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreGrupoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreGrupoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTipoDatoGrupo.Click
        Nuevo_Menu_PleTipoDatoGrupo.Enabled = False
        Editar_Menu_PleTipoDatoGrupo.Enabled = False
        ValidarCierre.Text = 1
        PleTipoDatoGrupoDataGridView.Enabled = False
        Limpiar_Objetos_PleTipoDatoGrupo()
        NombreGrupoTextBox.Enabled = True
        NombreGrupoTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTipoDatoGrupo.Click
        Control_Nulos_PleTipoDatoGrupo()

        If ControlNulos.Text = "" Then
            SP_PleTipoDatoGrupo_EDICION_INSERTAR(
        NombreGrupoTextBox.Text,
        DescripcionTextBox.Text
)
            Cancelar_PleTipoDatoGrupo()
            Parar_Timer_PleTipoDatoGrupo()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTipoDatoGrupo.Click
        Nuevo_Menu_PleTipoDatoGrupo.Enabled = False
        Guardar_Menu_PleTipoDatoGrupo.Enabled = False
        Editar_Menu_PleTipoDatoGrupo.Enabled = False
        Actualizar_Menu_PleTipoDatoGrupo.Enabled = True
        Eliminar_Menu_PleTipoDatoGrupo.Enabled = True
        PleTipoDatoGrupoDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTipoDatoGrupo()
        Timer_Actualizar_PleTipoDatoGrupo()
        Timer_Eliminar_PleTipoDatoGrupo()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTipoDatoGrupo.Click
        Control_Nulos_PleTipoDatoGrupo()

        If ControlNulos.Text = "" Then
            SP_PleTipoDatoGrupo_EDICION_ACTUALIZAR(
        TipoDatoGrupoIdPosUno.Text,
        NombreGrupoTextBox.Text,
        DescripcionTextBox.Text
)
            Cancelar_PleTipoDatoGrupo()
            Parar_Timer_PleTipoDatoGrupo()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTipoDatoGrupo.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTipoDatoGrupo_EDICION_ELIMINAR(TipoDatoGrupoIdPosUno.Text)
            Cancelar_PleTipoDatoGrupo()
            Parar_Timer_PleTipoDatoGrupo()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTipoDatoGrupo()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTipoDatoGrupo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTipoDatoGrupo.Click
        Cancelar_PleTipoDatoGrupo()
    End Sub


    '--==============================================================--
    'Navegacion


    Private Sub TipoDatoGrupoIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoDatoGrupoIdPosUno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TipoDatoGrupoIdPosUno.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "miproyecto")
                TipoDatoGrupoIdPosUno.Text = ""
                TipoDatoGrupoIdPosUno.Focus()
            Else
                NombreGrupoTextBox.Enabled = True
                NombreGrupoTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub NombreGrupoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreGrupoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreGrupoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "miproyecto")
                NombreGrupoTextBox.Text = ""
                NombreGrupoTextBox.Focus()
            Else
                DescripcionTextBox.Enabled = True
                DescripcionTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub DescripcionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTipoDatoGrupo.Enabled = True Then
                Actualizar_Menu_PleTipoDatoGrupo.Enabled = True
                Eliminar_Menu_PleTipoDatoGrupo.Enabled = True
            Else
                If DescripcionTextBox.Text = "" Then
                    MsgBox("Descripcion Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    DescripcionTextBox.Text = ""
                    DescripcionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTipoDatoGrupo.Enabled = True
                    Timer_Guardar_PleTipoDatoGrupo()
                End If
            End If
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTipoDatoGrupo As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTipoDatoGrupo As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTipoDatoGrupo As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTipoDatoGrupo()
        Me.Timer_Guardar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Guardar_Menu_PleTipoDatoGrupo.Interval = 250
        Timer_Guardar_Menu_PleTipoDatoGrupo.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTipoDatoGrupo()
        Me.Timer_Actualizar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Actualizar_Menu_PleTipoDatoGrupo.Interval = 500
        Timer_Actualizar_Menu_PleTipoDatoGrupo.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTipoDatoGrupo()
        Me.Timer_Eliminar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Eliminar_Menu_PleTipoDatoGrupo.Interval = 800
        Timer_Eliminar_Menu_PleTipoDatoGrupo.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTipoDatoGrupo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTipoDatoGrupo.Tick
        If Guardar_Menu_PleTipoDatoGrupo.BackColor = Color.White Then
            Guardar_Menu_PleTipoDatoGrupo.BackColor = Color.Green
        Else
            Guardar_Menu_PleTipoDatoGrupo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTipoDatoGrupo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTipoDatoGrupo.Tick
        If Actualizar_Menu_PleTipoDatoGrupo.BackColor = Color.White Then
            Actualizar_Menu_PleTipoDatoGrupo.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTipoDatoGrupo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTipoDatoGrupo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTipoDatoGrupo.Tick
        If Eliminar_Menu_PleTipoDatoGrupo.BackColor = Color.White Then
            Eliminar_Menu_PleTipoDatoGrupo.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTipoDatoGrupo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTipoDatoGrupo()
        Me.Timer_Guardar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Guardar_Menu_PleTipoDatoGrupo.Stop()
        Guardar_Menu_PleTipoDatoGrupo.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Actualizar_Menu_PleTipoDatoGrupo.Stop()
        Actualizar_Menu_PleTipoDatoGrupo.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTipoDatoGrupo = New Timer
        Timer_Eliminar_Menu_PleTipoDatoGrupo.Stop()
        Eliminar_Menu_PleTipoDatoGrupo.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTipoDatoGrupo As Timer
    Dim X_PleTipoDatoGrupo
    Private Sub Timer_Ubicar_En_Fila_PleTipoDatoGrupo()
        Me.Timer_Ubicacion_PleTipoDatoGrupo = New Timer
        Timer_Ubicacion_PleTipoDatoGrupo.Interval = 100
        Timer_Ubicacion_PleTipoDatoGrupo.Start()
    End Sub

    '--==============================================================--

    Private Sub PleTipoDatoGrupoDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleTipoDatoGrupoDataGridView.CellMouseClick
        X_PleTipoDatoGrupo = PleTipoDatoGrupoDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTipoDatoGrupo()
        Try
            Me.PleTipoDatoGrupoDataGridView.Rows(X_PleTipoDatoGrupo).Selected = True
            Me.PleTipoDatoGrupoDataGridView.FirstDisplayedScrollingRowIndex = X_PleTipoDatoGrupo
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTipoDatoGrupo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTipoDatoGrupo.Tick
        Ubicar_En_Fila_PleTipoDatoGrupo()
        Timer_Ubicacion_PleTipoDatoGrupo.Stop()
    End Sub



#End Region

#End Region

#End Region

#Region "TODO PleTablasRelacionadas"
    Private Sub SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                               New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Sub Cancelar_PleTablasRelacionadas()
        'Botones Del Menu
        Nuevo_Menu_PleTablasRelacionadas.Enabled = True
        Guardar_Menu_PleTablasRelacionadas.Enabled = False
        Editar_Menu_PleTablasRelacionadas.Enabled = True
        Actualizar_Menu_PleTablasRelacionadas.Enabled = False
        Eliminar_Menu_PleTablasRelacionadas.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleTablasRelacionadas()
        Parar_Timer_PleTablasRelacionadas()
        Timer_Ubicar_En_Fila_PleTablasRelacionadas()
    End Sub

    '--==============================================================--

    'Insertar PleTablasRelacionadas
    Private Sub SP_PleTablasRelacionadas_EDICION_INSERTAR(
ContenidoPosicionUno As String,
ContenidoPosicionDos As String,
ComponenteId As Integer,
TipoCodigoComponentePosUno As String,
TipoCodigoComponentePosDos As String,
TipoDatoIdPosUno As Integer,
TipoDatoIdPosDos As Integer,
DescripcionRelacion As String
)
        Try
            Me.SP_PleTablasRelacionadas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_EDICION_INSERTAR,
                                                 ContenidoPosicionUno,
                                                 ContenidoPosicionDos,
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 TipoCodigoComponentePosUno,
                                                 TipoCodigoComponentePosDos,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoIdPosUno, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TipoDatoIdPosDos, Integer)),
                                                 DescripcionRelacion
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTablasRelacionadas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTablasRelacionadas
    Private Sub SP_PleTablasRelacionadas_EDICION_ACTUALIZAR(TablasRelacionadasId As Integer,
ContenidoPosicionUno As String,
ContenidoPosicionDos As String,
ComponenteId As Integer,
TipoCodigoComponentePosUno As String,
TipoCodigoComponentePosDos As String,
TipoDatoIdPosUno As Integer,
TipoDatoIdPosDos As Integer,
DescripcionRelacion As String
)

        Try
            Me.SP_PleTablasRelacionadas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(TablasRelacionadasId, Integer)),
                                                 ContenidoPosicionUno,
                                                 ContenidoPosicionDos,
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 TipoCodigoComponentePosUno,
                                                 TipoCodigoComponentePosDos,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoIdPosUno, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TipoDatoIdPosDos, Integer)),
                                                 DescripcionRelacion
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTablasRelacionadas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTablasRelacionadas_EDICION_ELIMINAR(TablasRelacionadasId As Integer)
        Try
            Me.SP_PleTablasRelacionadas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasRelacionadas_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(TablasRelacionadasId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTablasRelacionadas Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTablasRelacionadas()
        CboGrupoTipoDatoPosUno.Enabled = False
        CboGrupoTipoDatoPosDos.Enabled = False
        CboTipoDatoIdPosUnoTextBox.Enabled = False
        CboTipoDatoIdPosDosTextBox.Enabled = False
        CboTipoCodigoComponentePosUnoTextBox.Enabled = False
        CboTipoCodigoComponentePosDosTextBox.Enabled = False
        RbContenidoPosicionUno.Enabled = False
        RbContenidoPosicionDos.Enabled = False
        ContenidoPosicionUnoTextBox.Enabled = False
        ContenidoPosicionDosTextBox.Enabled = False
        DescripcionRelacionTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTablasRelacionadas()
        CboGrupoTipoDatoPosUno.Enabled = True
        CboGrupoTipoDatoPosDos.Enabled = True
        CboTipoDatoIdPosUnoTextBox.Enabled = True
        CboTipoDatoIdPosDosTextBox.Enabled = True
        CboTipoCodigoComponentePosUnoTextBox.Enabled = True
        CboTipoCodigoComponentePosDosTextBox.Enabled = True
        RbContenidoPosicionUno.Enabled = True
        RbContenidoPosicionDos.Enabled = True
        DescripcionRelacionTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTablasRelacionadas()
        CboGrupoTipoDatoPosUno.Text = ""
        CboGrupoTipoDatoPosDos.Text = ""
        CboTipoDatoIdPosUnoTextBox.Text = ""
        CboTipoDatoIdPosDosTextBox.Text = ""
        CboTipoCodigoComponentePosUnoTextBox.Text = ""
        CboTipoCodigoComponentePosDosTextBox.Text = ""
        ContenidoPosicionUnoTextBox.Text = ""
        ContenidoPosicionDosTextBox.Text = ""
        DescripcionRelacionTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTablasRelacionadas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ContenidoPosicionUnoTextBox.Text = ""
                MsgBox("El nombre del Contenido Posicion Uno: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContenidoPosicionUnoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ContenidoPosicionDosTextBox.Text = ""
                MsgBox("El nombre del Contenido Posicion Dos: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContenidoPosicionDosTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoCodigoComponentePosUnoTextBox.Text = ""
                MsgBox("El nombre del Tipo Posición uno: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoCodigoComponentePosUnoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoCodigoComponentePosDosTextBox.Text = ""
                MsgBox("El nombre del Tipo Posición dos: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoCodigoComponentePosDosTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoDatoIdPosUnoTextBox.Text = ""
                MsgBox("El nombre del Tipo de dato posición uno: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoIdPosUnoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoDatoIdPosDosTextBox.Text = ""
                MsgBox("El nombre del Tipo codigo posición dos: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoIdPosDosTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionRelacionTextBox.Text = ""
                MsgBox("El nombre del Descripción de la relación: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionRelacionTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTablasRelacionadas.Click
        Nuevo_Menu_PleTablasRelacionadas.Enabled = False
        Editar_Menu_PleTablasRelacionadas.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTablasRelacionadas()
        CboGrupoTipoDatoPosUno.Enabled = True
        CboGrupoTipoDatoPosUno.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTablasRelacionadas.Click
        Control_Nulos_PleTablasRelacionadas()

        If ControlNulos.Text = "" Then
            SP_PleTablasRelacionadas_EDICION_INSERTAR(
        ContenidoPosicionUnoTextBox.Text,
        ContenidoPosicionDosTextBox.Text,
        ComponenteIdTextBox.Text,
        CboTipoCodigoComponentePosUnoTextBox.Text,
        CboTipoCodigoComponentePosDosTextBox.Text,
        TipoDatoIdPosUnoTextBox.Text,
        TipoDatoIdPosDosTextBox.Text,
        DescripcionRelacionTextBox.Text
)
            Cancelar_PleTablasRelacionadas()
            Parar_Timer_PleTablasRelacionadas()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTablasRelacionadas.Click
        Nuevo_Menu_PleTablasRelacionadas.Enabled = False
        Guardar_Menu_PleTablasRelacionadas.Enabled = False
        Editar_Menu_PleTablasRelacionadas.Enabled = False
        Actualizar_Menu_PleTablasRelacionadas.Enabled = True
        Eliminar_Menu_PleTablasRelacionadas.Enabled = True
        SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTablasRelacionadas()
        Timer_Actualizar_PleTablasRelacionadas()
        Timer_Eliminar_PleTablasRelacionadas()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTablasRelacionadas.Click
        Control_Nulos_PleTablasRelacionadas()

        If ControlNulos.Text = "" Then
            SP_PleTablasRelacionadas_EDICION_ACTUALIZAR(
        TablasRelacionadasIdTextBox.Text,
        ContenidoPosicionUnoTextBox.Text,
        ContenidoPosicionDosTextBox.Text,
        ComponenteIdTextBox.Text,
        CboTipoCodigoComponentePosUnoTextBox.Text,
        CboTipoCodigoComponentePosDosTextBox.Text,
        TipoDatoIdPosUnoTextBox.Text,
        TipoDatoIdPosDosTextBox.Text,
        DescripcionRelacionTextBox.Text
)
            Cancelar_PleTablasRelacionadas()
            Parar_Timer_PleTablasRelacionadas()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTablasRelacionadas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTablasRelacionadas_EDICION_ELIMINAR(TablasRelacionadasIdTextBox.Text)
            Cancelar_PleTablasRelacionadas()
            Parar_Timer_PleTablasRelacionadas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTablasRelacionadas()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTablasRelacionadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTablasRelacionadas.Click
        Cancelar_PleTablasRelacionadas()
    End Sub

    '--==============================================================--



    '--==============================================================--
    'Navegacion

    Private Sub CboGrupoTipoDatoPosUno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboGrupoTipoDatoPosUno.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboGrupoTipoDatoPosUno.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboGrupoTipoDatoPosUno.Text = ""
                CboGrupoTipoDatoPosUno.Focus()
            Else
                CboTipoDatoIdPosUnoTextBox.Enabled = True
                CboTipoDatoIdPosUnoTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CboTipoDatoIdPosUnoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDatoIdPosUnoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDatoIdPosUnoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboTipoDatoIdPosUnoTextBox.Text = ""
                CboTipoDatoIdPosUnoTextBox.Focus()
            Else
                CboTipoCodigoComponentePosUnoTextBox.Enabled = True
                CboTipoCodigoComponentePosUnoTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CboTipoCodigoComponentePosUnoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoCodigoComponentePosUnoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoCodigoComponentePosUnoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboTipoCodigoComponentePosUnoTextBox.Text = ""
                CboTipoCodigoComponentePosUnoTextBox.Focus()
            Else
                'ContenidoPosicionUnoTextBox.Enabled = True
                RbContenidoPosicionUno.Checked = True
                ContenidoPosicionUnoTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub ContenidoPosicionUnoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContenidoPosicionUnoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ContenidoPosicionUnoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                ContenidoPosicionUnoTextBox.Text = ""
                ContenidoPosicionUnoTextBox.Focus()
            Else
                CboGrupoTipoDatoPosDos.Enabled = True
                CboGrupoTipoDatoPosDos.Focus()
            End If
        End If
    End Sub



    Private Sub CboGrupoTipoDatoPosDos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CboGrupoTipoDatoPosDos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboGrupoTipoDatoPosDos.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboGrupoTipoDatoPosDos.Text = ""
                CboGrupoTipoDatoPosDos.Focus()
            Else
                CboTipoDatoIdPosDosTextBox.Enabled = True
                CboTipoDatoIdPosDosTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CboTipoDatoIdPosDosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDatoIdPosDosTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDatoIdPosDosTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboTipoDatoIdPosDosTextBox.Text = ""
                CboTipoDatoIdPosDosTextBox.Focus()
            Else
                CboTipoCodigoComponentePosDosTextBox.Enabled = True
                CboTipoCodigoComponentePosDosTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub CboTipoCodigoComponentePosDosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoCodigoComponentePosDosTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoCodigoComponentePosDosTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                CboTipoCodigoComponentePosDosTextBox.Text = ""
                CboTipoCodigoComponentePosDosTextBox.Focus()
            Else
                'ContenidoPosicionDosTextBox.Enabled = True
                RbContenidoPosicionDos.Checked = True
                ContenidoPosicionDosTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    '--==============================================================--
    Private Sub ContenidoPosicionDosTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContenidoPosicionDosTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ContenidoPosicionDosTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "ple")
                ContenidoPosicionDosTextBox.Text = ""
                ContenidoPosicionDosTextBox.Focus()
            Else
                DescripcionRelacionTextBox.Enabled = True
                DescripcionRelacionTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub DescripcionRelacionTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionRelacionTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTablasRelacionadas.Enabled = True Then
                Actualizar_Menu_PleTablasRelacionadas.Enabled = True
                Eliminar_Menu_PleTablasRelacionadas.Enabled = True
            Else
                If DescripcionRelacionTextBox.Text = "" Then
                    MsgBox("Tipo de dato de relacion Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    DescripcionRelacionTextBox.Text = ""
                    DescripcionRelacionTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTablasRelacionadas.Enabled = True
                    Timer_Guardar_PleTablasRelacionadas()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------



    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTablasRelacionadas As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTablasRelacionadas As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTablasRelacionadas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTablasRelacionadas()
        Me.Timer_Guardar_Menu_PleTablasRelacionadas = New Timer
        Timer_Guardar_Menu_PleTablasRelacionadas.Interval = 250
        Timer_Guardar_Menu_PleTablasRelacionadas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTablasRelacionadas()
        Me.Timer_Actualizar_Menu_PleTablasRelacionadas = New Timer
        Timer_Actualizar_Menu_PleTablasRelacionadas.Interval = 500
        Timer_Actualizar_Menu_PleTablasRelacionadas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTablasRelacionadas()
        Me.Timer_Eliminar_Menu_PleTablasRelacionadas = New Timer
        Timer_Eliminar_Menu_PleTablasRelacionadas.Interval = 800
        Timer_Eliminar_Menu_PleTablasRelacionadas.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTablasRelacionadas.Tick
        If Guardar_Menu_PleTablasRelacionadas.BackColor = Color.White Then
            Guardar_Menu_PleTablasRelacionadas.BackColor = Color.Green
        Else
            Guardar_Menu_PleTablasRelacionadas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTablasRelacionadas.Tick
        If Actualizar_Menu_PleTablasRelacionadas.BackColor = Color.White Then
            Actualizar_Menu_PleTablasRelacionadas.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTablasRelacionadas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTablasRelacionadas.Tick
        If Eliminar_Menu_PleTablasRelacionadas.BackColor = Color.White Then
            Eliminar_Menu_PleTablasRelacionadas.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTablasRelacionadas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTablasRelacionadas()
        Me.Timer_Guardar_Menu_PleTablasRelacionadas = New Timer
        Timer_Guardar_Menu_PleTablasRelacionadas.Stop()
        Guardar_Menu_PleTablasRelacionadas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTablasRelacionadas = New Timer
        Timer_Actualizar_Menu_PleTablasRelacionadas.Stop()
        Actualizar_Menu_PleTablasRelacionadas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTablasRelacionadas = New Timer
        Timer_Eliminar_Menu_PleTablasRelacionadas.Stop()
        Eliminar_Menu_PleTablasRelacionadas.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTablasRelacionadas As Timer
    Dim X_PleTablasRelacionadas
    Private Sub Timer_Ubicar_En_Fila_PleTablasRelacionadas()
        Me.Timer_Ubicacion_PleTablasRelacionadas = New Timer
        Timer_Ubicacion_PleTablasRelacionadas.Interval = 100
        Timer_Ubicacion_PleTablasRelacionadas.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleTablasRelacionadas = SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTablasRelacionadas()
        Try
            Me.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleTablasRelacionadas).Selected = True
            Me.SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTablasRelacionadas
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTablasRelacionadas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTablasRelacionadas.Tick
        Ubicar_En_Fila_PleTablasRelacionadas()
        Timer_Ubicacion_PleTablasRelacionadas.Stop()
    End Sub

#End Region

#End Region

#End Region

#Region "TODO PleTipoDatoComponenteCampo"

    '--==============================================================--

    Private Sub SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                        New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '--==============================================================--

    Sub Cancelar_PleTipoDatoComponenteCampo()
        'Botones Del Menu
        Nuevo_Menu_PleTipoDatoComponenteCampo.Enabled = True
        Guardar_Menu_PleTipoDatoComponenteCampo.Enabled = False
        Editar_Menu_PleTipoDatoComponenteCampo.Enabled = True
        Actualizar_Menu_PleTipoDatoComponenteCampo.Enabled = False
        Eliminar_Menu_PleTipoDatoComponenteCampo.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleTipoDatoComponenteCampo()
        Parar_Timer_PleTipoDatoComponenteCampo()
        Timer_Ubicar_En_Fila_PleTipoDatoComponenteCampo()
        BtnCambiaFormatoTodos.Enabled = False
        BtnCambiarSeparadorTodos.Enabled = False
        BtnCambioSaltoLinea.Enabled = False
        BtnCambioSeparadorTodos.Enabled = False
        BtnEsSecuencial.Enabled = False
        BtnCodigoSecuencial.Enabled = False
    End Sub

    '--==============================================================--

    'Insertar PleTipoDatoComponenteCampo
    Private Sub SP_PleTipoDatoComponenteCampo_EDICION_INSERTAR(ComponenteId As Integer,
TipoDatoId As Integer,
CampDeTablasFormatoId As Integer,
CodigoReplace As String,
SeparadorCampos As String,
SaltoDeLinea As Boolean,
OmiteSeparadorFinal As Boolean,
EsSecuencial As Boolean,
CodigoReplaceSecuencial As String
)
        Try
            Me.SP_PleTipoDatoComponenteCampo_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampo_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(CampDeTablasFormatoId, Integer)),
                                                 CodigoReplace,
                                                 SeparadorCampos,
                                                 New System.Nullable(Of Boolean)(CType(SaltoDeLinea, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(OmiteSeparadorFinal, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(EsSecuencial, Boolean)),
                                                 CodigoReplaceSecuencial
)
            Metodo_Aviso_Acciones(1, "Registro Guardado Existosamente en la tabla PleTipoDatoComponenteCampo")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTipoDatoComponenteCampo
    Private Sub SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(PleTipoDatoComponenteCampoId As Integer,
ComponenteId As Integer,
TipoDatoId As Integer,
CampDeTablasFormatoId As Integer,
CodigoReplace As String,
SeparadorCampos As String,
SaltoDeLinea As Boolean,
OmiteSeparadorFinal As Boolean,
EsSecuencial As Boolean,
CodigoReplaceSecuencial As String
)

        Try
            Me.SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleTipoDatoComponenteCampoId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(CampDeTablasFormatoId, Integer)),
                                                 CodigoReplace,
                                                 SeparadorCampos,
                                                 New System.Nullable(Of Boolean)(CType(SaltoDeLinea, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(OmiteSeparadorFinal, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(EsSecuencial, Boolean)),
                                                 CodigoReplaceSecuencial
)
            Metodo_Aviso_Acciones(1, "Registro Actualizado Existosamente en la tabla PleTipoDatoComponenteCampo")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR(PleTipoDatoComponenteCampoId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleTipoDatoComponenteCampoId, Integer)))
            Metodo_Aviso_Acciones(1, "Registro de la tabla PleTipoDatoComponenteCampo Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTipoDatoComponenteCampo()
        CboGrupoTipoDato.Enabled = False
        CboTipoDatoIdTextBox.Enabled = False
        CboCampDeTablasFormatoIdTextBox.Enabled = False
        'CodigoReplaceRichTextBox.Enabled = False
        SeparadorCamposTextBox.Enabled = False
        SaltoDeLineaCheckBox.Enabled = False
        OmiteSeparadorFinalCheckBox.Enabled = False
        EsSecuencialTextBox.Enabled = False
        EsSecuencialCheckBox.Enabled = False
        CodigoReplaceSecuencialRichTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTipoDatoComponenteCampo()
        CboGrupoTipoDato.Enabled = True
        CboTipoDatoIdTextBox.Enabled = True
        CboCampDeTablasFormatoIdTextBox.Enabled = True
        CodigoReplaceRichTextBox.Enabled = True
        SeparadorCamposTextBox.Enabled = True
        SaltoDeLineaCheckBox.Enabled = True
        OmiteSeparadorFinalCheckBox.Enabled = True
        EsSecuencialTextBox.Enabled = True
        EsSecuencialCheckBox.Enabled = True
        CodigoReplaceSecuencialRichTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTipoDatoComponenteCampo()
        CboGrupoTipoDato.Text = ""
        CboTipoDatoIdTextBox.Text = ""
        CboCampDeTablasFormatoIdTextBox.Text = ""
        CodigoReplaceRichTextBox.Text = ""
        SeparadorCamposTextBox.Text = ""
        SaltoDeLineaCheckBox.Text = ""
        OmiteSeparadorFinalCheckBox.Text = ""
        EsSecuencialTextBox.Text = ""
        CodigoReplaceSecuencialRichTextBox.Text = ""
        CodigoReplaceSecuencialRichTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTipoDatoComponenteCampo()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case CboTipoDatoIdTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoIdTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboCampDeTablasFormatoIdTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboCampDeTablasFormatoIdTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CodigoReplaceRichTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodigoReplaceRichTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTipoDatoComponenteCampo.Click
        Nuevo_Menu_PleTipoDatoComponenteCampo.Enabled = False
        Editar_Menu_PleTipoDatoComponenteCampo.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTipoDatoComponenteCampo()
        CboGrupoTipoDato.Enabled = True
        CboGrupoTipoDato.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTipoDatoComponenteCampo.Click
        Control_Nulos_PleTipoDatoComponenteCampo()

        If ControlNulos.Text = "" Then
            SP_PleTipoDatoComponenteCampo_EDICION_INSERTAR(
        ComponenteIdTextBox.Text,
        TipoDatoIdCamp.Text,
        CampDeTablasFormatoIdTextBox.Text,
        CodigoReplaceRichTextBox.Text,
        SeparadorCamposTextBox.Text,
        SaltoDeLineaTextBox.Text,
        OmiteSeparadorFinalTextBox.Text,
        EsSecuencialTextBox.Text,
        CodigoReplaceSecuencialRichTextBox.Text
)
            Cancelar_PleTipoDatoComponenteCampo()
            Parar_Timer_PleTipoDatoComponenteCampo()
        End If
    End Sub


    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTipoDatoComponenteCampo.Click
        If CodigoReplaceRichTextBox.Text <> RichTextBox1.Text Then
            If MsgBox("El codigo ha cambiado, desea continuar actualizando?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Nuevo_Menu_PleTipoDatoComponenteCampo.Enabled = False
                Guardar_Menu_PleTipoDatoComponenteCampo.Enabled = False
                Editar_Menu_PleTipoDatoComponenteCampo.Enabled = False
                Actualizar_Menu_PleTipoDatoComponenteCampo.Enabled = True
                Eliminar_Menu_PleTipoDatoComponenteCampo.Enabled = True
                BtnCambiaFormatoTodos.Enabled = True
                BtnCambiarSeparadorTodos.Enabled = True
                BtnCambioSaltoLinea.Enabled = True
                BtnCambioSeparadorTodos.Enabled = True
                BtnEsSecuencial.Enabled = True
                BtnCodigoSecuencial.Enabled = True
                SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
                ValidarCierre.Text = 1
                Desbloquear_Objetos_PleTipoDatoComponenteCampo()
                Timer_Actualizar_PleTipoDatoComponenteCampo()
                Timer_Eliminar_PleTipoDatoComponenteCampo()
            Else
                MsgBox("Se cancelo la instrucción", MsgBoxStyle.Information)
            End If
        Else
            Nuevo_Menu_PleTipoDatoComponenteCampo.Enabled = False
            Guardar_Menu_PleTipoDatoComponenteCampo.Enabled = False
            Editar_Menu_PleTipoDatoComponenteCampo.Enabled = False
            Actualizar_Menu_PleTipoDatoComponenteCampo.Enabled = True
            Eliminar_Menu_PleTipoDatoComponenteCampo.Enabled = True
            BtnCambiaFormatoTodos.Enabled = True
            BtnCambiarSeparadorTodos.Enabled = True
            BtnCambioSaltoLinea.Enabled = True
            BtnCambioSeparadorTodos.Enabled = True
            BtnEsSecuencial.Enabled = True
            BtnCodigoSecuencial.Enabled = True
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
            ValidarCierre.Text = 1
            Desbloquear_Objetos_PleTipoDatoComponenteCampo()
            Timer_Actualizar_PleTipoDatoComponenteCampo()
            Timer_Eliminar_PleTipoDatoComponenteCampo()
        End If
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTipoDatoComponenteCampo.Click
        Control_Nulos_PleTipoDatoComponenteCampo()
        If ControlNulos.Text = "" Then
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            Cancelar_PleTipoDatoComponenteCampo()
            Parar_Timer_PleTipoDatoComponenteCampo()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTipoDatoComponenteCampo.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR(PleTipoDatoComponenteCampoIdTextBox.Text)
            Cancelar_PleTipoDatoComponenteCampo()
            Parar_Timer_PleTipoDatoComponenteCampo()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTipoDatoComponenteCampo()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTipoDatoComponenteCampo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTipoDatoComponenteCampo.Click
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub

    Private Sub BtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles BtnPrevisualizar.Click
        CodigoReplaceRichTextBox.Text = TratamientoPorDatoConPSSI()
    End Sub

    Private Sub BtnUpdateCodigoReplace_Click(sender As Object, e As EventArgs) Handles BtnUpdateCodigoReplace.Click
        If PleTipoDatoComponenteCampoIdTextBox.Text <> "" Then
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                   PleTipoDatoComponenteCampoIdTextBox.Text,
                   ComponenteIdTextBox.Text,
                   TipoDatoIdCamp.Text,
                   CampDeTablasFormatoIdTextBox.Text,
                   CodigoReplaceRichTextBox.Text,
                   SeparadorCamposTextBox.Text,
                   SaltoDeLineaTextBox.Text,
                   OmiteSeparadorFinalTextBox.Text,
                   EsSecuencialTextBox.Text,
                   CodigoReplaceSecuencialRichTextBox.Text)
        Else
            MsgBox("No hay un dato para Actualizar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar2_Click(sender As Object, e As EventArgs) Handles BtnCancelar2.Click
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub

    Function TratamientoPorDatoConPSSI()
        '-1-=========================================================--
        'Declaracion de variables
        Dim CampoConFormato As String = "CAMPO"
        Dim CampoSecuencialConFormato As String = "CAMPO_SECUENCIAL"
        Dim CampoMascara As String = "MASCARA"

        '-3-=========================================================--
        'Remplazos para visualizacion
        If CampoRemplazo.Text <> "" Then
            CampoConFormato = CampoRemplazo.Text
        Else
            CampoConFormato = CampoConFormato
        End If

        'Remplazos para visualizacion
        If SecuencialRemplazo.Text <> "" Then
            CampoSecuencialConFormato = SecuencialRemplazo.Text
        Else
            CampoSecuencialConFormato = CampoSecuencialConFormato
        End If

        'Remplazos para visualizacion
        If MascaraRemplazo.Text <> "" Then
            CampoMascara = MascaraRemplazo.Text
        Else
            CampoMascara = CampoMascara
        End If
        '-4-=========================================================--
        'Ajuste de formatos
        CampoConFormato = TratamientoFormatoCampo(CampoConFormato, CboCampDeTablasFormatoIdTextBox.Text)
        CampoSecuencialConFormato = TratamientoFormatoCampo(CampoSecuencialConFormato, CboCampDeTablasFormatoIdTextBox.Text)

        If CantidadRepeticiones.Text <> "" Then

            CampoConFormato = ReproducirCantidad(CantidadRepeticiones.Text,
                                                 CampoConFormato,
                                                 CampoSecuencialConFormato,
                                                 CampoMascara,
                                                 SaltoDeLineaCheckBox.Checked,
                                                 SeparadorCamposTextBox.Text,
                                                 OmiteSeparadorFinalCheckBox.Checked,
                                                 EsSecuencialCheckBox.Checked,
                                                 CodigoReplaceRichTextBox.Text,
                                                 CodigoReplaceSecuencialRichTextBox.Text)
        Else
            If SeparadorCamposTextBox.Text <> "" Then
                CampoConFormato = CodigoReplaceRichTextBox.Text.Replace("Campo", CampoConFormato)
                CampoConFormato = GuardaRetornaActualizado(CampoConFormato)
                CampoConFormato = CampoConFormato.Replace("CamMasc", CampoMascara) & SeparadorCamposTextBox.Text
            Else
                CampoConFormato = CodigoReplaceRichTextBox.Text.Replace("Campo", CampoConFormato)
                CampoConFormato = GuardaRetornaActualizado(CampoConFormato)
                CampoConFormato = CampoConFormato.Replace("CamMasc", CampoMascara)
            End If
        End If

        Return CampoConFormato
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
        While CantidadRepeticiones > 0
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
            CantidadRepeticiones -= 1
        End While
        Return CodigoGenerado
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

#End Region

    Private Sub BtnCrearParaTodos_Click(sender As Object, e As EventArgs) Handles BtnCrearParaTodos.Click
        Dim BaseTipo As String = ""
        If ChkIncluyeTipo.Checked = True Then
            BaseTipo = CodigoReplaceRichTextBox.Text
        End If

        Me.PleTipoDatoGrupo3TableAdapter.Fill(Me.DataSetMaestros.PleTipoDatoGrupo3)
        Dim Contador As Integer = DGVTipoDatoGrupoGeneracion.Rows.Count
        While Contador > 0
            DGVTipoDatoGrupoGeneracion.CurrentCell = DGVTipoDatoGrupoGeneracion.Rows(0).Cells(0)
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId3_Generacion(TipoDatoGrupoIdGeneracionTodos.Text)
            Dim Contador2 As Integer = DGV_PleTipoDato_SEGUN_TipoDatoGrupoIdGeneracion.Rows.Count
            While Contador2 > 0
                DGV_PleTipoDato_SEGUN_TipoDatoGrupoIdGeneracion.CurrentCell = DGV_PleTipoDato_SEGUN_TipoDatoGrupoIdGeneracion.Rows(0).Cells(0)
                If ChkIncluyeTipo.Checked = True Then
                    CodigoReplaceRichTextBox.Text = BaseTipo.Replace("TipoDato", NombreTipoReplace.Text)
                End If
                'Insertar
                SP_PleTipoDatoComponenteCampo_EDICION_INSERTAR(
        ComponenteIdTextBox.Text,
        TipoDatoIdGeneracionTodos.Text,
        CampDeTablasFormatoIdTextBox.Text,
        CodigoReplaceRichTextBox.Text,
        SeparadorCamposTextBox.Text,
        SaltoDeLineaTextBox.Text,
        OmiteSeparadorFinalTextBox.Text,
        EsSecuencialTextBox.Text,
        CodigoReplaceSecuencialRichTextBox.Text
)
                DGV_PleTipoDato_SEGUN_TipoDatoGrupoIdGeneracion.Rows.RemoveAt(0)
                Contador2 -= 1
            End While
            DGVTipoDatoGrupoGeneracion.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
        Metodo_Aviso_Acciones(1, "Campos Generados para los tipos existentes")
    End Sub

    Private Sub BtnPasarCamposCoponente_Click(sender As Object, e As EventArgs) Handles BtnPasarCamposCoponente.Click
        If ComponenteAPasar.Text = "" Then
            MsgBox("Debes ingresar un numero de componente, favor vericar", MsgBoxStyle.Critical)
        Else
            'Valida existencia del componente
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteAPasar.Text)

            If ComponenteIdBuscado.Text = "" Then
                MsgBox("Este componente no se encuentra en el sistema, favor verificar", MsgBoxStyle.Critical)
            Else
                SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteId(ComponenteIdActual.Text)

                Dim Contador As Integer = SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteIdDataGridView.Rows.Count
                While Contador > 0
                    SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteIdDataGridView.Rows(0).Cells(0)
                    'Insertar
                    SP_PleTipoDatoComponenteCampo_EDICION_INSERTAR(
            ComponenteAPasar.Text,
            TipoDatoIdCopiado.Text,
            CampDeTablasFormatoIdCopiado.Text,
            CodigoReplaceCopiado.Text,
            SeparadorCamposCopiado.Text,
            SaltoDeLineaCopiado.Text,
            OmiteSeparadorFinalCopiado.Text,
            EsSecuencialCopiado.Text,
            CodigoReplaceSecuencialCopiado.Text
    )
                    SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteIdDataGridView.Rows.RemoveAt(0)
                    Contador -= 1
                End While
                Cancelar_PleTipoDatoComponenteCampo()
                Metodo_Aviso_Acciones(1, "Se copiaron los datos a otro componente")
            End If
        End If
    End Sub
    Private Sub SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampo_CARGA_DATOS_PARA_COPIA_SEGUN_ComponenteId,
                                                                                                        New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ComponenteAPasar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComponenteAPasar.KeyPress
        'Solo numeros
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                        New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId3_Generacion(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId3TableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId3,
                                                                                         New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminarTodos_Click(sender As Object, e As EventArgs) Handles BtnEliminarTodos.Click
        If MsgBox("Tenga en cuenta que esta acción !!BORRARA!! la configuración actual ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
            While Contador > 1
                SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
                'Eliminar
                SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR_PorComponente(ComponenteIdTextBox.Text, TipoDatoIdEliminacion.Text)
                SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
                Contador -= 1
            End While
            Cancelar_PleTipoDatoComponenteCampo()
            Metodo_Aviso_Acciones(1, "Se eliminaron los registros dejando solo 1")
        Else
            MsgBox("Se cancelo la instrucción", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BtnCambiaFormatoTodos_Click(sender As Object, e As EventArgs) Handles BtnCambiaFormatoTodos.Click
        Dim FormatoCampoId As Integer = CampDeTablasFormatoIdTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    FormatoCampoId,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub
    Private Sub BtnCambiarSeparadorTodos_Click(sender As Object, e As EventArgs) Handles BtnCambiarSeparadorTodos.Click
        Dim SeparadorCapmpo As String = SeparadorCamposTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCapmpo,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub
    Private Sub BtnCambioSaltoLinea_Click(sender As Object, e As EventArgs) Handles BtnCambioSaltoLinea.Click
        Dim SaltoDeLinea As String = SaltoDeLineaTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLinea,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub
    Private Sub BtnCambioSeparadorTodos_Click(sender As Object, e As EventArgs) Handles BtnCambioSeparadorTodos.Click
        Dim OmiteSeparador As String = OmiteSeparadorFinalTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparador,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub

    Private Sub BtnEsSecuencial_Click(sender As Object, e As EventArgs) Handles BtnEsSecuencial.Click
        Dim EsSecuencial As String = EsSecuencialTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencial,
                    CodigoReplaceSecuencialRichTextBox.Text
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub

    Private Sub BtnCodigoSecuencial_Click(sender As Object, e As EventArgs) Handles BtnCodigoSecuencial.Click
        Dim CodigoReplaceSecuencial As String = CodigoReplaceSecuencialRichTextBox.Text
        Dim Contador As Integer = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.Count
        While Contador > 0
            'Se ubica en la primera fila
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentCell = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(0).Cells(0)
            SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZAR(
                    PleTipoDatoComponenteCampoIdTextBox.Text,
                    ComponenteIdTextBox.Text,
                    TipoDatoIdCamp.Text,
                    CampDeTablasFormatoIdTextBox.Text,
                    CodigoReplaceRichTextBox.Text,
                    SeparadorCamposTextBox.Text,
                    SaltoDeLineaTextBox.Text,
                    OmiteSeparadorFinalTextBox.Text,
                    EsSecuencialTextBox.Text,
                    CodigoReplaceSecuencial
)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows.RemoveAt(0)
            Contador -= 1
        End While
        Cancelar_PleTipoDatoComponenteCampo()
    End Sub

    Private Sub CodigoReplaceSecuencialRichTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles CodigoReplaceSecuencialRichTextBox.MouseDoubleClick
        If CodigoReplaceSecuencialRichTextBox.Dock = DockStyle.None Then
            CodigoReplaceSecuencialRichTextBox.BringToFront()
            CodigoReplaceSecuencialRichTextBox.Dock = DockStyle.Fill
        Else
            CodigoReplaceSecuencialRichTextBox.Dock = DockStyle.None
        End If
    End Sub


    Private Sub SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR_PorComponente(ComponenteId As Integer, TipoDatoId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR_PorComponenteTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR_PorComponente,
                                                                                             New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                             New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnImprimeCampo_Click(sender As Object, e As EventArgs) Handles BtnImprimeCampo.Click
        If CodigoReplaceRichTextBox.Enabled = True Then
            Me.CodigoReplaceRichTextBox.Text = Me.CodigoReplaceRichTextBox.Text.Insert(Me.CodigoReplaceRichTextBox.SelectionStart, "Campo")
        End If
    End Sub

    Private Sub BtnTipoDato_Click(sender As Object, e As EventArgs) Handles BtnTipoDato.Click
        If CodigoReplaceRichTextBox.Enabled = True Then
            Me.CodigoReplaceRichTextBox.Text = Me.CodigoReplaceRichTextBox.Text.Insert(Me.CodigoReplaceRichTextBox.SelectionStart, "TipoDato")
        End If
    End Sub

    Private Sub BtnImprimeMascara_Click(sender As Object, e As EventArgs) Handles BtnImprimeMascara.Click
        If CodigoReplaceRichTextBox.Enabled = True Then
            Me.CodigoReplaceRichTextBox.Text = Me.CodigoReplaceRichTextBox.Text.Insert(Me.CodigoReplaceRichTextBox.SelectionStart, "CamMasc")
        End If
    End Sub

    Private Sub BtnImprimirSecuenciaRemplazo_Click(sender As Object, e As EventArgs) Handles BtnImprimirSecuenciaRemplazo.Click
        If CodigoReplaceRichTextBox.Enabled = True Then
            Me.CodigoReplaceRichTextBox.Text = Me.CodigoReplaceRichTextBox.Text.Insert(Me.CodigoReplaceRichTextBox.SelectionStart, "SeCuenRem")
        End If
    End Sub



    '--==============================================================--
    'Navegacion

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
                CboCampDeTablasFormatoIdTextBox.Enabled = True
                CboCampDeTablasFormatoIdTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub CboCampDeTablasFormatoIdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboCampDeTablasFormatoIdTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboCampDeTablasFormatoIdTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                CboCampDeTablasFormatoIdTextBox.Text = ""
                CboCampDeTablasFormatoIdTextBox.Focus()
            Else
                SeparadorCamposTextBox.Enabled = True
                SeparadorCamposTextBox.Focus()
            End If
        End If
        If InStr(1, "" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub SeparadorCamposTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SeparadorCamposTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            OmiteSeparadorFinalCheckBox.Enabled = True
            OmiteSeparadorFinalCheckBox.Focus()
        End If
        If InStr(1, ",;-*:+/&^()^%$#! " & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub OmiteSeparadorFinalTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OmiteSeparadorFinalCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If OmiteSeparadorFinalCheckBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                OmiteSeparadorFinalCheckBox.Text = ""
                OmiteSeparadorFinalCheckBox.Focus()
            Else
                SaltoDeLineaCheckBox.Enabled = True
                SaltoDeLineaCheckBox.Focus()
            End If
        End If
    End Sub

    Private Sub SaltoDeLineaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SaltoDeLineaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If SaltoDeLineaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                SaltoDeLineaCheckBox.Text = ""
                SaltoDeLineaCheckBox.Focus()
            Else
                EsSecuencialCheckBox.Enabled = True
                EsSecuencialCheckBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--



    Private Sub EsSecuencialCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EsSecuencialCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If EsSecuencialCheckBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Ple")
                EsSecuencialCheckBox.Text = ""
                EsSecuencialCheckBox.Focus()
            Else
                CodigoReplaceRichTextBox.Enabled = True
                CodigoReplaceRichTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub CodigoReplaceRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoReplaceRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTipoDatoComponenteCampo.Enabled = True Then
                Actualizar_Menu_PleTipoDatoComponenteCampo.Enabled = True
                Eliminar_Menu_PleTipoDatoComponenteCampo.Enabled = True
            Else
                If CodigoReplaceRichTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    CodigoReplaceRichTextBox.Text = ""
                    CodigoReplaceRichTextBox.Focus()
                Else
                    If Nuevo_Menu_PleTipoDatoComponenteCampo.Enabled = False Then
                        MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                        Guardar_Menu_PleTipoDatoComponenteCampo.Enabled = True
                        Timer_Guardar_PleTipoDatoComponenteCampo()
                    End If
                End If
            End If
        End If
    End Sub

    '--==============================================================--
    ' Especiales
    Private Sub SaltoDeLineaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaltoDeLineaCheckBox.CheckedChanged
        If SaltoDeLineaCheckBox.Checked = True Then
            SaltoDeLineaCheckBox.Text = "Con Salto"
            SaltoDeLineaTextBox.Text = "True"
        Else
            SaltoDeLineaCheckBox.Text = "Sin Salto"
            SaltoDeLineaTextBox.Text = "False"
        End If
    End Sub

    Private Sub OmiteSeparadorFinalCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OmiteSeparadorFinalCheckBox.CheckedChanged
        If OmiteSeparadorFinalCheckBox.Checked = True Then
            OmiteSeparadorFinalCheckBox.Text = "No"
            OmiteSeparadorFinalTextBox.Text = "True"
        Else
            OmiteSeparadorFinalCheckBox.Text = "Si"
            OmiteSeparadorFinalTextBox.Text = "False"
        End If
    End Sub

    Private Sub EsSecuencialCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsSecuencialCheckBox.CheckedChanged
        If EsSecuencialCheckBox.Checked = True Then
            EsSecuencialCheckBox.Text = "Si"
            EsSecuencialTextBox.Text = "True"
        Else
            EsSecuencialCheckBox.Text = "No"
            EsSecuencialTextBox.Text = "False"
        End If
    End Sub
    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTipoDatoComponenteCampo As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTipoDatoComponenteCampo As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTipoDatoComponenteCampo As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTipoDatoComponenteCampo()
        Me.Timer_Guardar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Guardar_Menu_PleTipoDatoComponenteCampo.Interval = 250
        Timer_Guardar_Menu_PleTipoDatoComponenteCampo.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTipoDatoComponenteCampo()
        Me.Timer_Actualizar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Actualizar_Menu_PleTipoDatoComponenteCampo.Interval = 500
        Timer_Actualizar_Menu_PleTipoDatoComponenteCampo.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTipoDatoComponenteCampo()
        Me.Timer_Eliminar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Eliminar_Menu_PleTipoDatoComponenteCampo.Interval = 800
        Timer_Eliminar_Menu_PleTipoDatoComponenteCampo.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTipoDatoComponenteCampo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTipoDatoComponenteCampo.Tick
        If Guardar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White Then
            Guardar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.Green
        Else
            Guardar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTipoDatoComponenteCampo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTipoDatoComponenteCampo.Tick
        If Actualizar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White Then
            Actualizar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTipoDatoComponenteCampo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTipoDatoComponenteCampo.Tick
        If Eliminar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White Then
            Eliminar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTipoDatoComponenteCampo()
        Me.Timer_Guardar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Guardar_Menu_PleTipoDatoComponenteCampo.Stop()
        Guardar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Actualizar_Menu_PleTipoDatoComponenteCampo.Stop()
        Actualizar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTipoDatoComponenteCampo = New Timer
        Timer_Eliminar_Menu_PleTipoDatoComponenteCampo.Stop()
        Eliminar_Menu_PleTipoDatoComponenteCampo.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTipoDatoComponenteCampo As Timer
    Dim X_PleTipoDatoComponenteCampo
    Private Sub Timer_Ubicar_En_Fila_PleTipoDatoComponenteCampo()
        Me.Timer_Ubicacion_PleTipoDatoComponenteCampo = New Timer
        Timer_Ubicacion_PleTipoDatoComponenteCampo.Interval = 100
        Timer_Ubicacion_PleTipoDatoComponenteCampo.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleTipoDatoComponenteCampo = SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTipoDatoComponenteCampo()
        Try
            Me.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleTipoDatoComponenteCampo).Selected = True
            Me.SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTipoDatoComponenteCampo
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTipoDatoComponenteCampo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTipoDatoComponenteCampo.Tick
        Ubicar_En_Fila_PleTipoDatoComponenteCampo()
        Timer_Ubicacion_PleTipoDatoComponenteCampo.Stop()
    End Sub

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId2_Camp(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId2TableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId2,
                                                                                         New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CantidadRepeticiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CantidadRepeticiones.KeyPress
        If InStr(1, "1234567890" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "TODO PleRequerimientos"

    '--==============================================================--

    Sub Cancelar_PleRequerimientos()
        'Botones Del Menu
        Nuevo_Menu_PleRequerimientos.Enabled = True
        Guardar_Menu_PleRequerimientos.Enabled = False
        Editar_Menu_PleRequerimientos.Enabled = True
        Actualizar_Menu_PleRequerimientos.Enabled = False
        Eliminar_Menu_PleRequerimientos.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleRequerimientosDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleRequerimientosTableAdapter.Fill(Me.DataSetMaestros.PleRequerimientos)
        Bloquear_Objetos_PleRequerimientos()
        Parar_Timer_PleRequerimientos()
        Timer_Ubicar_En_Fila_PleRequerimientos()
    End Sub

    '--==============================================================--

    'Insertar PleRequerimientos
    Private Sub SP_PleRequerimientos_EDICION_INSERTAR(NombreRequerimiento As String,
DescripcionRequerimiento As String
)
        Try
            Me.SP_PleRequerimientos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientos_EDICION_INSERTAR,
                                                 NombreRequerimiento,
                                                 DescripcionRequerimiento
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleRequerimientos")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleRequerimientos
    Private Sub SP_PleRequerimientos_EDICION_ACTUALIZAR(PleRequerimientos As Integer,
NombreRequerimiento As String,
DescripcionRequerimiento As String
)

        Try
            Me.SP_PleRequerimientos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientos_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleRequerimientos, Integer)),
                                                 NombreRequerimiento,
                                                 DescripcionRequerimiento
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleRequerimientos")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleRequerimientos_EDICION_ELIMINAR(PleRequerimientos As Integer)
        Try
            Me.SP_PleRequerimientos_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientos_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleRequerimientos, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleRequerimientos Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleRequerimientos()
        NombreRequerimientoTextBox.Enabled = False
        DescripcionRequerimientoTextBox.Enabled = False

    End Sub

    Public Sub Desbloquear_Objetos_PleRequerimientos()
        NombreRequerimientoTextBox.Enabled = True
        DescripcionRequerimientoTextBox.Enabled = True

    End Sub

    Public Sub Limpiar_Objetos_PleRequerimientos()
        NombreRequerimientoTextBox.Text = ""
        DescripcionRequerimientoTextBox.Text = ""

    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleRequerimientos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case NombreRequerimientoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreRequerimientoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case DescripcionRequerimientoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionRequerimientoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"

            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleRequerimientos.Click
        Nuevo_Menu_PleRequerimientos.Enabled = False
        Editar_Menu_PleRequerimientos.Enabled = False
        ValidarCierre.Text = 1
        PleRequerimientosDataGridView.Enabled = False
        Limpiar_Objetos_PleRequerimientos()
        NombreRequerimientoTextBox.Enabled = True
        NombreRequerimientoTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleRequerimientos.Click
        Control_Nulos_PleRequerimientos()

        If ControlNulos.Text = "" Then
            SP_PleRequerimientos_EDICION_INSERTAR(
        NombreRequerimientoTextBox.Text,
        DescripcionRequerimientoTextBox.Text
)
            Cancelar_PleRequerimientos()
            Parar_Timer_PleRequerimientos()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleRequerimientos.Click
        Nuevo_Menu_PleRequerimientos.Enabled = False
        Guardar_Menu_PleRequerimientos.Enabled = False
        Editar_Menu_PleRequerimientos.Enabled = False
        Actualizar_Menu_PleRequerimientos.Enabled = True
        Eliminar_Menu_PleRequerimientos.Enabled = True
        PleRequerimientosDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleRequerimientos()
        Timer_Actualizar_PleRequerimientos()
        Timer_Eliminar_PleRequerimientos()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleRequerimientos.Click
        Control_Nulos_PleRequerimientos()

        If ControlNulos.Text = "" Then
            SP_PleRequerimientos_EDICION_ACTUALIZAR(
        PleRequerimientosIdTextBox.Text,
        NombreRequerimientoTextBox.Text,
        DescripcionRequerimientoTextBox.Text
)
            Cancelar_PleRequerimientos()
            Parar_Timer_PleRequerimientos()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRequerimientos.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRequerimientos_EDICION_ELIMINAR(PleRequerimientosIdTextBox.Text)
            Cancelar_PleRequerimientos()
            Parar_Timer_PleRequerimientos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRequerimientos()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleRequerimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleRequerimientos.Click
        Cancelar_PleRequerimientos()
    End Sub

    '--==============================================================--
    'Navegacion

    '--==============================================================--

    Private Sub NombreRequerimientoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreRequerimientoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreRequerimientoTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "tools")
                NombreRequerimientoTextBox.Text = ""
                NombreRequerimientoTextBox.Focus()
            Else
                DescripcionRequerimientoTextBox.Enabled = True
                DescripcionRequerimientoTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub DescripcionRequerimientoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionRequerimientoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleRequerimientos.Enabled = True Then
                Actualizar_Menu_PleRequerimientos.Enabled = True
                Eliminar_Menu_PleRequerimientos.Enabled = True
            Else
                If DescripcionRequerimientoTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    DescripcionRequerimientoTextBox.Text = ""
                    DescripcionRequerimientoTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleRequerimientos.Enabled = True
                    Timer_Guardar_PleRequerimientos()
                End If
            End If
        End If
        'CASOS ESPECIALES EN NAVEGACION

        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (DescripcionRequerimientoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(DescripcionRequerimientoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            DescripcionRequerimientoTextBox.Text = ""
            DescripcionRequerimientoTextBox.Text = Caracter
            DescripcionRequerimientoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(DescripcionRequerimientoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(DescripcionRequerimientoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(DescripcionRequerimientoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            DescripcionRequerimientoTextBox.Text = ""
            DescripcionRequerimientoTextBox.Text = Temp + Caracter
            DescripcionRequerimientoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleRequerimientos As Timer
    Private WithEvents Timer_Actualizar_Menu_PleRequerimientos As Timer
    Private WithEvents Timer_Eliminar_Menu_PleRequerimientos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleRequerimientos()
        Me.Timer_Guardar_Menu_PleRequerimientos = New Timer
        Timer_Guardar_Menu_PleRequerimientos.Interval = 250
        Timer_Guardar_Menu_PleRequerimientos.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleRequerimientos()
        Me.Timer_Actualizar_Menu_PleRequerimientos = New Timer
        Timer_Actualizar_Menu_PleRequerimientos.Interval = 500
        Timer_Actualizar_Menu_PleRequerimientos.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleRequerimientos()
        Me.Timer_Eliminar_Menu_PleRequerimientos = New Timer
        Timer_Eliminar_Menu_PleRequerimientos.Interval = 800
        Timer_Eliminar_Menu_PleRequerimientos.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleRequerimientos.Tick
        If Guardar_Menu_PleRequerimientos.BackColor = Color.White Then
            Guardar_Menu_PleRequerimientos.BackColor = Color.Green
        Else
            Guardar_Menu_PleRequerimientos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleRequerimientos.Tick
        If Actualizar_Menu_PleRequerimientos.BackColor = Color.White Then
            Actualizar_Menu_PleRequerimientos.BackColor = Color.Green
        Else
            Actualizar_Menu_PleRequerimientos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleRequerimientos.Tick
        If Eliminar_Menu_PleRequerimientos.BackColor = Color.White Then
            Eliminar_Menu_PleRequerimientos.BackColor = Color.Red
        Else
            Eliminar_Menu_PleRequerimientos.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleRequerimientos()
        Me.Timer_Guardar_Menu_PleRequerimientos = New Timer
        Timer_Guardar_Menu_PleRequerimientos.Stop()
        Guardar_Menu_PleRequerimientos.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleRequerimientos = New Timer
        Timer_Actualizar_Menu_PleRequerimientos.Stop()
        Actualizar_Menu_PleRequerimientos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleRequerimientos = New Timer
        Timer_Eliminar_Menu_PleRequerimientos.Stop()
        Eliminar_Menu_PleRequerimientos.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleRequerimientos As Timer
    Dim X_PleRequerimientos
    Private Sub Timer_Ubicar_En_Fila_PleRequerimientos()
        Me.Timer_Ubicacion_PleRequerimientos = New Timer
        Timer_Ubicacion_PleRequerimientos.Interval = 100
        Timer_Ubicacion_PleRequerimientos.Start()
    End Sub

    '--==============================================================--

    Private Sub PleRequerimientosDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleRequerimientosDataGridView.CellMouseClick
        X_PleRequerimientos = PleRequerimientosDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleRequerimientos()
        Try
            Me.PleRequerimientosDataGridView.Rows(X_PleRequerimientos).Selected = True
            Me.PleRequerimientosDataGridView.FirstDisplayedScrollingRowIndex = X_PleRequerimientos
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleRequerimientos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleRequerimientos.Tick
        Ubicar_En_Fila_PleRequerimientos()
        Timer_Ubicacion_PleRequerimientos.Stop()
    End Sub

#End Region

#End Region

#End Region

#Region "TODO PleRequerimientosComponentes"

    Private Sub SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                          New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Cancelar_PleRequerimientosComponentes()
        'Botones Del Menu
        Nuevo_Menu_PleRequerimientosComponentes.Enabled = True
        Guardar_Menu_PleRequerimientosComponentes.Enabled = False
        Editar_Menu_PleRequerimientosComponentes.Enabled = True
        Actualizar_Menu_PleRequerimientosComponentes.Enabled = False
        Eliminar_Menu_PleRequerimientosComponentes.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleRequerimientosComponentes()
        Parar_Timer_PleRequerimientosComponentes()
        Timer_Ubicar_En_Fila_PleRequerimientosComponentes()
    End Sub

    '--==============================================================--

    'Insertar PleRequerimientosComponentes
    Private Sub SP_PleRequerimientosComponentes_EDICION_INSERTAR(ComponenteId As Integer,
PleRequerimientosId As Integer,
RazonDeUso As String
)
        Try
            Me.SP_PleRequerimientosComponentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosComponentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PleRequerimientosId, Integer)),
                                                 RazonDeUso
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleRequerimientosComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleRequerimientosComponentes
    Private Sub SP_PleRequerimientosComponentes_EDICION_ACTUALIZAR(PleRequerimientosComponentesId As Integer,
ComponenteId As Integer,
PleRequerimientosId As Integer,
RazonDeUso As String
)

        Try
            Me.SP_PleRequerimientosComponentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosComponentes_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleRequerimientosComponentesId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PleRequerimientosId, Integer)),
                                                 RazonDeUso
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleRequerimientosComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleRequerimientosComponentes_EDICION_ELIMINAR(PleRequerimientosComponentesId As Integer)
        Try
            Me.SP_PleRequerimientosComponentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRequerimientosComponentes_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleRequerimientosComponentesId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleRequerimientosComponentes Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleRequerimientosComponentes()
        RazonDeUsoTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleRequerimientosComponentes()
        RazonDeUsoTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleRequerimientosComponentes()
        RazonDeUsoTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleRequerimientosComponentes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case RazonDeUsoTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RazonDeUsoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleRequerimientosComponentes.Click
        Nuevo_Menu_PleRequerimientosComponentes.Enabled = False
        Editar_Menu_PleRequerimientosComponentes.Enabled = False
        ValidarCierre.Text = 1
        SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleRequerimientosComponentes()
        RazonDeUsoTextBox.Enabled = True
        RazonDeUsoTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleRequerimientosComponentes.Click
        Control_Nulos_PleRequerimientosComponentes()

        If ControlNulos.Text = "" Then
            SP_PleRequerimientosComponentes_EDICION_INSERTAR(
        ComponenteIdTextBox.Text,
        PleRequerimientosIdTextBox.Text,
        RazonDeUsoTextBox.Text
)
            Cancelar_PleRequerimientosComponentes()
            Parar_Timer_PleRequerimientosComponentes()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleRequerimientosComponentes.Click
        Nuevo_Menu_PleRequerimientosComponentes.Enabled = False
        Guardar_Menu_PleRequerimientosComponentes.Enabled = False
        Editar_Menu_PleRequerimientosComponentes.Enabled = False
        Actualizar_Menu_PleRequerimientosComponentes.Enabled = True
        Eliminar_Menu_PleRequerimientosComponentes.Enabled = True
        SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleRequerimientosComponentes()
        Timer_Actualizar_PleRequerimientosComponentes()
        Timer_Eliminar_PleRequerimientosComponentes()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleRequerimientosComponentes.Click
        Control_Nulos_PleRequerimientosComponentes()
        If ControlNulos.Text = "" Then
            SP_PleRequerimientosComponentes_EDICION_ACTUALIZAR(
        PleRequerimientosComponentesIdTextBox.Text,
        ComponenteIdTextBox.Text,
        PleRequerimientosIdTextBox.Text,
        RazonDeUsoTextBox.Text
)
            Cancelar_PleRequerimientosComponentes()
            Parar_Timer_PleRequerimientosComponentes()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRequerimientosComponentes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRequerimientosComponentes_EDICION_ELIMINAR(PleRequerimientosComponentesIdTextBox.Text)
            Cancelar_PleRequerimientosComponentes()
            Parar_Timer_PleRequerimientosComponentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRequerimientosComponentes()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleRequerimientosComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleRequerimientosComponentes.Click
        Cancelar_PleRequerimientosComponentes()
    End Sub
    Private Sub BtnCopiar_Click(sender As Object, e As EventArgs) Handles BtnCopiar.Click
        If NombreRequerimientoTextBox1.Text <> "" Then
            Clipboard.SetText(NombreRequerimientoTextBox1.Text)
        End If
        Metodo_Aviso_Acciones(1, "Copiado al portapapeles")
    End Sub


    '--==============================================================--
    'Navegacion

    '--==============================================================--

    Private Sub RazonDeUsoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RazonDeUsoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleRequerimientosComponentes.Enabled = True Then
                Actualizar_Menu_PleRequerimientosComponentes.Enabled = True
                Eliminar_Menu_PleRequerimientosComponentes.Enabled = True
            Else
                If RazonDeUsoTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    RazonDeUsoTextBox.Text = ""
                    RazonDeUsoTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleRequerimientosComponentes.Enabled = True
                    Timer_Guardar_PleRequerimientosComponentes()
                End If
            End If
        End If
        Dim Longitud, Ascii As Integer
        Dim Temp As String
        Dim Caracter As Char
        Longitud = (RazonDeUsoTextBox.TextLength) - 1
        If Longitud < 1 Then
            Longitud = Longitud + 1
            Caracter = Microsoft.VisualBasic.Right(RazonDeUsoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            RazonDeUsoTextBox.Text = ""
            RazonDeUsoTextBox.Text = Caracter
            RazonDeUsoTextBox.SelectionStart = Longitud + 1
            Exit Sub
        End If
        Caracter = Mid(RazonDeUsoTextBox.Text, Longitud, Longitud)
        Ascii = Asc(Caracter)
        If Ascii = 32 Then
            Temp = Microsoft.VisualBasic.Left(RazonDeUsoTextBox.Text, Longitud)
            Caracter = Microsoft.VisualBasic.Right(RazonDeUsoTextBox.Text, 1)
            Caracter = UCase(Caracter)
            RazonDeUsoTextBox.Text = ""
            RazonDeUsoTextBox.Text = Temp + Caracter
            RazonDeUsoTextBox.SelectionStart = Longitud + 1
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleRequerimientosComponentes As Timer
    Private WithEvents Timer_Actualizar_Menu_PleRequerimientosComponentes As Timer
    Private WithEvents Timer_Eliminar_Menu_PleRequerimientosComponentes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleRequerimientosComponentes()
        Me.Timer_Guardar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Guardar_Menu_PleRequerimientosComponentes.Interval = 250
        Timer_Guardar_Menu_PleRequerimientosComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleRequerimientosComponentes()
        Me.Timer_Actualizar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Actualizar_Menu_PleRequerimientosComponentes.Interval = 500
        Timer_Actualizar_Menu_PleRequerimientosComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleRequerimientosComponentes()
        Me.Timer_Eliminar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Eliminar_Menu_PleRequerimientosComponentes.Interval = 800
        Timer_Eliminar_Menu_PleRequerimientosComponentes.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleRequerimientosComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleRequerimientosComponentes.Tick
        If Guardar_Menu_PleRequerimientosComponentes.BackColor = Color.White Then
            Guardar_Menu_PleRequerimientosComponentes.BackColor = Color.Green
        Else
            Guardar_Menu_PleRequerimientosComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleRequerimientosComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleRequerimientosComponentes.Tick
        If Actualizar_Menu_PleRequerimientosComponentes.BackColor = Color.White Then
            Actualizar_Menu_PleRequerimientosComponentes.BackColor = Color.Green
        Else
            Actualizar_Menu_PleRequerimientosComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleRequerimientosComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleRequerimientosComponentes.Tick
        If Eliminar_Menu_PleRequerimientosComponentes.BackColor = Color.White Then
            Eliminar_Menu_PleRequerimientosComponentes.BackColor = Color.Red
        Else
            Eliminar_Menu_PleRequerimientosComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleRequerimientosComponentes()
        Me.Timer_Guardar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Guardar_Menu_PleRequerimientosComponentes.Stop()
        Guardar_Menu_PleRequerimientosComponentes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Actualizar_Menu_PleRequerimientosComponentes.Stop()
        Actualizar_Menu_PleRequerimientosComponentes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleRequerimientosComponentes = New Timer
        Timer_Eliminar_Menu_PleRequerimientosComponentes.Stop()
        Eliminar_Menu_PleRequerimientosComponentes.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleRequerimientosComponentes As Timer
    Dim X_PleRequerimientosComponentes
    Private Sub Timer_Ubicar_En_Fila_PleRequerimientosComponentes()
        Me.Timer_Ubicacion_PleRequerimientosComponentes = New Timer
        Timer_Ubicacion_PleRequerimientosComponentes.Interval = 100
        Timer_Ubicacion_PleRequerimientosComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleRequerimientosComponentes = SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleRequerimientosComponentes()
        Try
            Me.SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleRequerimientosComponentes).Selected = True
            Me.SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleRequerimientosComponentes
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleRequerimientosComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleRequerimientosComponentes.Tick
        Ubicar_En_Fila_PleRequerimientosComponentes()
        Timer_Ubicacion_PleRequerimientosComponentes.Stop()
    End Sub

    Private Sub PleRequerimientosDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PleRequerimientosDataGridView.CellMouseDoubleClick

        RazonDeUsoTextBox.Text = DescripcionRequerimientoTextBox.Text
        SP_PleRequerimientosComponentes_EDICION_INSERTAR(
    ComponenteIdTextBox.Text,
    PleRequerimientosIdTextBox.Text,
    RazonDeUsoTextBox.Text)
        Cancelar_PleRequerimientosComponentes()

    End Sub


    Private Sub SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseDoubleClick
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRequerimientosComponentes_EDICION_ELIMINAR(PleRequerimientosComponentesIdTextBox.Text)
            Cancelar_PleRequerimientosComponentes()
            Parar_Timer_PleRequerimientosComponentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRequerimientosComponentes()
        End If
    End Sub





#End Region

#End Region

#End Region

#Region "TODO PleTablasComponentes"

    '--==============================================================--

    Private Sub SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                              New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Sub Cancelar_PleTablasComponentes()
        'Botones Del Menu
        Nuevo_Menu_PleTablasComponentes.Enabled = True
        Guardar_Menu_PleTablasComponentes.Enabled = False
        Editar_Menu_PleTablasComponentes.Enabled = True
        Actualizar_Menu_PleTablasComponentes.Enabled = False
        Eliminar_Menu_PleTablasComponentes.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleTablasComponentes()
        Parar_Timer_PleTablasComponentes()
        Timer_Ubicar_En_Fila_PleTablasComponentes()
    End Sub

    '--==============================================================--

    'Insertar PleTablasComponentes
    Private Sub SP_PleTablasComponentes_EDICION_INSERTAR(ComponenteId As Integer,
CodigoReplaceXTabla As String,
SeparadorTablas As String,
SaltoDeLineaTabla As Boolean,
OmiteSeparadorFinalTabla As Boolean
)
        Try
            Me.SP_PleTablasComponentes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasComponentes_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 CodigoReplaceXTabla,
                                                 SeparadorTablas,
                                                 New System.Nullable(Of Boolean)(CType(SaltoDeLineaTabla, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(OmiteSeparadorFinalTabla, Boolean))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTablasComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTablasComponentes
    Private Sub SP_PleTablasComponentes_EDICION_ACTUALIZAR(PleTablasComponentesId As Integer,
ComponenteId As Integer,
CodigoReplaceXTabla As String,
SeparadorTablas As String,
SaltoDeLineaTabla As Boolean,
OmiteSeparadorFinalTabla As Boolean
)

        Try
            Me.SP_PleTablasComponentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasComponentes_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleTablasComponentesId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 CodigoReplaceXTabla,
                                                 SeparadorTablas,
                                                 New System.Nullable(Of Boolean)(CType(SaltoDeLineaTabla, Boolean)),
                                                 New System.Nullable(Of Boolean)(CType(OmiteSeparadorFinalTabla, Boolean))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTablasComponentes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTablasComponentes_EDICION_ELIMINAR(PleTablasComponentesId As Integer)
        Try
            Me.SP_PleTablasComponentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTablasComponentes_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleTablasComponentesId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTablasComponentes Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTablasComponentes()
        CodigoReplaceXTablaTextBox.Enabled = False
        SeparadorTablasTextBox.Enabled = False
        SaltoDeLineaTablaCheckBox.Enabled = False
        OmiteSeparadorFinalTablaCheckBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTablasComponentes()
        CodigoReplaceXTablaTextBox.Enabled = True
        SeparadorTablasTextBox.Enabled = True
        SaltoDeLineaTablaCheckBox.Enabled = True
        OmiteSeparadorFinalTablaCheckBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTablasComponentes()
        CodigoReplaceXTablaTextBox.Text = ""
        SeparadorTablasTextBox.Text = ""
        SaltoDeLineaTablaTextBox.Text = ""
        OmiteSeparadorFinalTablaTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTablasComponentes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case CodigoReplaceXTablaTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CodigoReplaceXTablaTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTablasComponentes.Click
        Nuevo_Menu_PleTablasComponentes.Enabled = False
        Editar_Menu_PleTablasComponentes.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTablasComponentes()
        SeparadorTablasTextBox.Enabled = True
        SeparadorTablasTextBox.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTablasComponentes.Click
        Control_Nulos_PleTablasComponentes()

        If ControlNulos.Text = "" Then
            SP_PleTablasComponentes_EDICION_INSERTAR(
        ComponenteIdTextBox.Text,
        CodigoReplaceXTablaTextBox.Text,
        SeparadorTablasTextBox.Text,
        SaltoDeLineaTablaTextBox.Text,
        OmiteSeparadorFinalTablaTextBox.Text
)
            Cancelar_PleTablasComponentes()
            Parar_Timer_PleTablasComponentes()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTablasComponentes.Click
        Nuevo_Menu_PleTablasComponentes.Enabled = False
        Guardar_Menu_PleTablasComponentes.Enabled = False
        Editar_Menu_PleTablasComponentes.Enabled = False
        Actualizar_Menu_PleTablasComponentes.Enabled = True
        Eliminar_Menu_PleTablasComponentes.Enabled = True
        SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTablasComponentes()
        Timer_Actualizar_PleTablasComponentes()
        Timer_Eliminar_PleTablasComponentes()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTablasComponentes.Click
        Control_Nulos_PleTablasComponentes()

        If ControlNulos.Text = "" Then
            SP_PleTablasComponentes_EDICION_ACTUALIZAR(
        PleTablasComponentesIdTextBox.Text,
        ComponenteIdTextBox.Text,
        CodigoReplaceXTablaTextBox.Text,
        SeparadorTablasTextBox.Text,
        SaltoDeLineaTablaTextBox.Text,
        OmiteSeparadorFinalTablaTextBox.Text
)
            Cancelar_PleTablasComponentes()
            Parar_Timer_PleTablasComponentes()
        End If
    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTablasComponentes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTablasComponentes_EDICION_ELIMINAR(PleTablasComponentesIdTextBox.Text)
            Cancelar_PleTablasComponentes()
            Parar_Timer_PleTablasComponentes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTablasComponentes()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTablasComponentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTablasComponentes.Click
        Cancelar_PleTablasComponentes()
    End Sub

    '--==============================================================--
    'Navegacion

    '--==============================================================--



    '--==============================================================--

    Private Sub SeparadorTablasTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SeparadorTablasTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SaltoDeLineaTablaCheckBox.Enabled = True
            SaltoDeLineaTablaCheckBox.Focus()
        End If
        If InStr(1, ",;-*:+/&^()^%$#! " & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    '--==============================================================--

    Private Sub SaltoDeLineaTablaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SaltoDeLineaTablaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If SaltoDeLineaTablaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "tools")
                SaltoDeLineaTablaCheckBox.Text = ""
                SaltoDeLineaTablaCheckBox.Focus()
            Else
                OmiteSeparadorFinalTablaCheckBox.Enabled = True
                OmiteSeparadorFinalTablaCheckBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub OmiteSeparadorFinalTablaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OmiteSeparadorFinalTablaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If OmiteSeparadorFinalTablaTextBox.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "tools")
                OmiteSeparadorFinalTablaCheckBox.Text = ""
                OmiteSeparadorFinalTablaCheckBox.Focus()
            Else
                CodigoReplaceXTablaTextBox.Enabled = True
                CodigoReplaceXTablaTextBox.Focus()
            End If
        End If
    End Sub


    Private Sub CodigoReplaceXTablaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoReplaceXTablaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTablasComponentes.Enabled = True Then
                Actualizar_Menu_PleTablasComponentes.Enabled = True
                Eliminar_Menu_PleTablasComponentes.Enabled = True
            Else
                If CodigoReplaceXTablaTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    CodigoReplaceXTablaTextBox.Text = ""
                    CodigoReplaceXTablaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTablasComponentes.Enabled = True
                    Timer_Guardar_PleTablasComponentes()
                End If
            End If
        End If
    End Sub
    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales

    Private Sub SaltoDeLineaTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaltoDeLineaTablaCheckBox.CheckedChanged
        If SaltoDeLineaTablaCheckBox.Checked = True Then
            SaltoDeLineaTablaCheckBox.Text = "Tiene"
            SaltoDeLineaTablaTextBox.Text = "True"
        Else
            SaltoDeLineaTablaCheckBox.Text = "Inactivo"
            SaltoDeLineaTablaTextBox.Text = "False"
        End If
    End Sub

    Private Sub OmiteSeparadorFinalTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OmiteSeparadorFinalTablaCheckBox.CheckedChanged
        If OmiteSeparadorFinalTablaCheckBox.Checked = True Then
            OmiteSeparadorFinalTablaCheckBox.Text = "Activo"
            OmiteSeparadorFinalTablaTextBox.Text = "True"
        Else
            OmiteSeparadorFinalTablaCheckBox.Text = "Inactivo"
            OmiteSeparadorFinalTablaTextBox.Text = "False"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.CodigoReplaceXTablaTextBox.Text = Me.CodigoReplaceXTablaTextBox.Text.Insert(Me.CodigoReplaceXTablaTextBox.SelectionStart, "{{{Tabla}}}")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.CodigoReplaceXTablaTextBox.Text = Me.CodigoReplaceXTablaTextBox.Text.Insert(Me.CodigoReplaceXTablaTextBox.SelectionStart, "{{{Tmin}}}")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.CodigoReplaceXTablaTextBox.Text = Me.CodigoReplaceXTablaTextBox.Text.Insert(Me.CodigoReplaceXTablaTextBox.SelectionStart, "{{{A=>-a}}}")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.CodigoReplaceXTablaTextBox.Text = Me.CodigoReplaceXTablaTextBox.Text.Insert(Me.CodigoReplaceXTablaTextBox.SelectionStart, "{{{Tbl-Camel}}}")
    End Sub
    Private Sub BtnMascaraTabla_Click(sender As Object, e As EventArgs) Handles BtnMascaraTabla.Click
        Me.CodigoReplaceXTablaTextBox.Text = Me.CodigoReplaceXTablaTextBox.Text.Insert(Me.CodigoReplaceXTablaTextBox.SelectionStart, "TblMasc")
    End Sub

    Private Sub BtnPrevisualizarGenTablaCte_Click(sender As Object, e As EventArgs) Handles BtnPrevisualizarGenTablaCte.Click
        PrevisualizarRichTextBox.Text = TratamientoTabla()
    End Sub
    Private Sub BtnTablaPrevisualizarTabla_Click(sender As Object, e As EventArgs)
        Me.PrevisualizarRichTextBox.Text = Me.PrevisualizarRichTextBox.Text.Insert(Me.PrevisualizarRichTextBox.SelectionStart, "Tabla")
    End Sub

    Private Sub BtnPrevisualizarMascara_Click(sender As Object, e As EventArgs)
        Me.PrevisualizarRichTextBox.Text = Me.PrevisualizarRichTextBox.Text.Insert(Me.PrevisualizarRichTextBox.SelectionStart, "TblMasc")
    End Sub

    Function TratamientoTabla()

        Dim Tabla As String = "TABLA"
        Dim TablaMin As String = "tabla"
        Dim TablaPrimeramin As String = "tABLA"
        Dim TablaCamel As String = "tA_Bla"
        Dim Mascara As String = "MASCARA"
        Dim CampoFormato As String = CodigoReplaceXTablaTextBox.Text

        CampoFormato = CampoFormato.Replace("{{{Tabla}}}", Tabla)
        CampoFormato = CampoFormato.Replace("{{{Tmin}}}", TablaMin)
        CampoFormato = CampoFormato.Replace("{{{A=>-a}}}", TablaPrimeramin)
        CampoFormato = CampoFormato.Replace("{{{Tbl-Camel}}}", TablaCamel)
        CampoFormato = CampoFormato.Replace("TblMasc", Mascara)

        If CuentaVeces.Text <> "" Then
            CampoFormato = TratamientoTablasConfiguracion(CampoFormato, CuentaVeces.Text, SaltoDeLineaTablaCheckBox.Checked, SeparadorTablasTextBox.Text, OmiteSeparadorFinalTablaCheckBox.Checked)
        End If

        Return CampoFormato
    End Function

    Private Function TratamientoTablasConfiguracion(Texto As String, Contador As Integer, ConSalto As Boolean, Separador As String, OmitirSeparadorFinal As Boolean) As String
        Dim CampoFormato As String = ""
        While Contador > 0
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
            Contador -= 1
        End While
        Return CampoFormato
    End Function



    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTablasComponentes As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTablasComponentes As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTablasComponentes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTablasComponentes()
        Me.Timer_Guardar_Menu_PleTablasComponentes = New Timer
        Timer_Guardar_Menu_PleTablasComponentes.Interval = 250
        Timer_Guardar_Menu_PleTablasComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTablasComponentes()
        Me.Timer_Actualizar_Menu_PleTablasComponentes = New Timer
        Timer_Actualizar_Menu_PleTablasComponentes.Interval = 500
        Timer_Actualizar_Menu_PleTablasComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTablasComponentes()
        Me.Timer_Eliminar_Menu_PleTablasComponentes = New Timer
        Timer_Eliminar_Menu_PleTablasComponentes.Interval = 800
        Timer_Eliminar_Menu_PleTablasComponentes.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTablasComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTablasComponentes.Tick
        If Guardar_Menu_PleTablasComponentes.BackColor = Color.White Then
            Guardar_Menu_PleTablasComponentes.BackColor = Color.Green
        Else
            Guardar_Menu_PleTablasComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTablasComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTablasComponentes.Tick
        If Actualizar_Menu_PleTablasComponentes.BackColor = Color.White Then
            Actualizar_Menu_PleTablasComponentes.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTablasComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTablasComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTablasComponentes.Tick
        If Eliminar_Menu_PleTablasComponentes.BackColor = Color.White Then
            Eliminar_Menu_PleTablasComponentes.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTablasComponentes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTablasComponentes()
        Me.Timer_Guardar_Menu_PleTablasComponentes = New Timer
        Timer_Guardar_Menu_PleTablasComponentes.Stop()
        Guardar_Menu_PleTablasComponentes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTablasComponentes = New Timer
        Timer_Actualizar_Menu_PleTablasComponentes.Stop()
        Actualizar_Menu_PleTablasComponentes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTablasComponentes = New Timer
        Timer_Eliminar_Menu_PleTablasComponentes.Stop()
        Eliminar_Menu_PleTablasComponentes.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTablasComponentes As Timer
    Dim X_PleTablasComponentes
    Private Sub Timer_Ubicar_En_Fila_PleTablasComponentes()
        Me.Timer_Ubicacion_PleTablasComponentes = New Timer
        Timer_Ubicacion_PleTablasComponentes.Interval = 100
        Timer_Ubicacion_PleTablasComponentes.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleTablasComponentes = SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTablasComponentes()
        Try
            Me.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleTablasComponentes).Selected = True
            Me.SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTablasComponentes
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTablasComponentes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTablasComponentes.Tick
        Ubicar_En_Fila_PleTablasComponentes()
        Timer_Ubicacion_PleTablasComponentes.Stop()
    End Sub

#End Region

#End Region

#End Region

#Region "TODO PleTipoDatoComponenteEspeciales"

    '--==============================================================--

    Private Sub SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId_Especiales(ComponenteId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                             New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId4(TipoDatoGrupoId As Integer)
        Try
            Me.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId4TableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId4,
                                                                                         New System.Nullable(Of Integer)(CType(TipoDatoGrupoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Sub Cancelar_PleTipoDatoComponenteEspeciales()
        'Botones Del Menu
        Nuevo_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
        Guardar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Editar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
        Actualizar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Eliminar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId_Especiales(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleTipoDatoComponenteEspeciales()
        Parar_Timer_PleTipoDatoComponenteEspeciales()
        Timer_Ubicar_En_Fila_PleTipoDatoComponenteEspeciales()
    End Sub

    '--==============================================================--

    'Insertar PleTipoDatoComponenteEspeciales
    Private Sub SP_PleTipoDatoComponenteEspeciales_EDICION_INSERTAR(TipoDatoId As Integer,
ComponenteId As Integer,
ContenidoCampoEspecial As String
)
        Try
            Me.SP_PleTipoDatoComponenteEspeciales_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspeciales_EDICION_INSERTAR,
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 ContenidoCampoEspecial
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleTipoDatoComponenteEspeciales")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Actualizar PleTipoDatoComponenteEspeciales
    Private Sub SP_PleTipoDatoComponenteEspeciales_EDICION_ACTUALIZAR(PleTipoDatoComponenteEspecialesId As Integer,
TipoDatoId As Integer,
ComponenteId As Integer,
ContenidoCampoEspecial As String
)

        Try
            Me.SP_PleTipoDatoComponenteEspeciales_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspeciales_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleTipoDatoComponenteEspecialesId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)),
                                                 New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                 ContenidoCampoEspecial
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleTipoDatoComponenteEspeciales")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    'Eliminar
    Private Sub SP_PleTipoDatoComponenteEspeciales_EDICION_ELIMINAR(PleTipoDatoComponenteEspecialesId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteEspeciales_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspeciales_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleTipoDatoComponenteEspecialesId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleTipoDatoComponenteEspeciales Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--==============================================================--

    Public Sub Bloquear_Objetos_PleTipoDatoComponenteEspeciales()
        CboTipoDatoGrupoEspeciales.Enabled = False
        CboTipoDatoIdEspeciales.Enabled = False
        ContenidoCampoEspecialRichTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleTipoDatoComponenteEspeciales()
        CboTipoDatoGrupoEspeciales.Enabled = True
        CboTipoDatoIdEspeciales.Enabled = True
        ContenidoCampoEspecialRichTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleTipoDatoComponenteEspeciales()
        CboTipoDatoGrupoEspeciales.Text = ""
        CboTipoDatoIdEspeciales.Text = ""
        ContenidoCampoEspecialRichTextBox.Text = ""
    End Sub

    '--==============================================================--

    'Control de Nulos
    Public Sub Control_Nulos_PleTipoDatoComponenteEspeciales()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case CboTipoDatoGrupoEspeciales.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoGrupoEspeciales.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case CboTipoDatoIdEspeciales.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                CboTipoDatoIdEspeciales.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case ContenidoCampoEspecialRichTextBox.Text = ""
                MsgBox("El nombre del campo: ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ContenidoCampoEspecialRichTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--==============================================================--

    Private Sub Nuevo_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleTipoDatoComponenteEspeciales.Click
        Nuevo_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Editar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        ValidarCierre.Text = 1
        SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleTipoDatoComponenteEspeciales()
        CboTipoDatoGrupoEspeciales.Enabled = True
        CboTipoDatoGrupoEspeciales.Focus()
    End Sub

    '--==============================================================--
    'Guardar
    Private Sub Guardar_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleTipoDatoComponenteEspeciales.Click
        Control_Nulos_PleTipoDatoComponenteEspeciales()

        If ControlNulos.Text = "" Then
            SP_PleTipoDatoComponenteEspeciales_EDICION_INSERTAR(
        TipoDatoIdEspeciales.Text,
        ComponenteIdTextBox.Text,
        ContenidoCampoEspecialRichTextBox.Text
)
            Cancelar_PleTipoDatoComponenteEspeciales()
            Parar_Timer_PleTipoDatoComponenteEspeciales()
        End If
    End Sub

    '--==============================================================--

    'Editar
    Private Sub Editar_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleTipoDatoComponenteEspeciales.Click
        Nuevo_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Guardar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Editar_Menu_PleTipoDatoComponenteEspeciales.Enabled = False
        Actualizar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
        Eliminar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
        SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleTipoDatoComponenteEspeciales()
        Timer_Actualizar_PleTipoDatoComponenteEspeciales()
        Timer_Eliminar_PleTipoDatoComponenteEspeciales()
    End Sub

    '--==============================================================--

    'Actualizar
    Private Sub Actualizar_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleTipoDatoComponenteEspeciales.Click
        Control_Nulos_PleTipoDatoComponenteEspeciales()
        SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo(ComponenteIdTextBox.Text, TipoDatoIdEspeciales.Text)
        If PleTipoDatoComponenteEspecialesIdVerificacion.Text = "" Then
            If ControlNulos.Text = "" Then
                SP_PleTipoDatoComponenteEspeciales_EDICION_ACTUALIZAR(
            PleTipoDatoComponenteEspecialesIdTextBox.Text,
            TipoDatoIdEspeciales.Text,
            ComponenteIdTextBox.Text,
            ContenidoCampoEspecialRichTextBox.Text
    )
                Cancelar_PleTipoDatoComponenteEspeciales()
                Parar_Timer_PleTipoDatoComponenteEspeciales()
            End If
        Else
            MsgBox("Para este tipo de dato ya existe en este componente un Campo especial, favor verificar", MsgBoxStyle.Exclamation)
        End If
    End Sub
    '--==============================================================--
    Private Sub SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo(ComponenteId As Integer, TipoDatoId As Integer)
        Try
            Me.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipoTableAdapter.Fill(Me.DataSetMaestros.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteYTipo,
                                                                                                                New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                                                                                New System.Nullable(Of Integer)(CType(TipoDatoId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '--==============================================================--

    Private Sub Eliminar_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleTipoDatoComponenteEspeciales.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleTipoDatoComponenteEspeciales_EDICION_ELIMINAR(PleTipoDatoComponenteEspecialesIdTextBox.Text)
            Cancelar_PleTipoDatoComponenteEspeciales()
            Parar_Timer_PleTipoDatoComponenteEspeciales()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleTipoDatoComponenteEspeciales()
        End If
    End Sub

    '--==============================================================--

    'Cancelar
    Private Sub Cancelar_Menu_PleTipoDatoComponenteEspeciales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleTipoDatoComponenteEspeciales.Click
        Cancelar_PleTipoDatoComponenteEspeciales()
    End Sub

    Private Sub BtnImprimeTablaEspeciales_Click(sender As Object, e As EventArgs) Handles BtnImprimeTablaEspeciales.Click
        If ContenidoCampoEspecialRichTextBox.Enabled = True Then
            Me.ContenidoCampoEspecialRichTextBox.Text = Me.ContenidoCampoEspecialRichTextBox.Text.Insert(Me.ContenidoCampoEspecialRichTextBox.SelectionStart, "{{{Tabla}}}")
        End If
    End Sub

    Private Sub BtnImprimeTablaMinusculaEspeciales_Click(sender As Object, e As EventArgs) Handles BtnImprimeTablaMinusculaEspeciales.Click
        If ContenidoCampoEspecialRichTextBox.Enabled = True Then
            Me.ContenidoCampoEspecialRichTextBox.Text = Me.ContenidoCampoEspecialRichTextBox.Text.Insert(Me.ContenidoCampoEspecialRichTextBox.SelectionStart, "{{{Tmin}}}")
        End If
    End Sub

    Private Sub BtnImprimeTablaPrimeraMin_Click(sender As Object, e As EventArgs) Handles BtnImprimeTablaPrimeraMin.Click
        If ContenidoCampoEspecialRichTextBox.Enabled = True Then
            Me.ContenidoCampoEspecialRichTextBox.Text = Me.ContenidoCampoEspecialRichTextBox.Text.Insert(Me.ContenidoCampoEspecialRichTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
    End Sub

    Private Sub BtnImprimeTablaCamel_Click(sender As Object, e As EventArgs) Handles BtnImprimeTablaCamel.Click
        If ContenidoCampoEspecialRichTextBox.Enabled = True Then
            Me.ContenidoCampoEspecialRichTextBox.Text = Me.ContenidoCampoEspecialRichTextBox.Text.Insert(Me.ContenidoCampoEspecialRichTextBox.SelectionStart, "{{{Tbl-Camel}}}")

        End If
    End Sub
    '--==============================================================--
    'Navegacion

    Private Sub CboTipoDatoGrupoEspeciales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDatoGrupoEspeciales.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDatoGrupoEspeciales.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "tools")
                CboTipoDatoGrupoEspeciales.Text = ""
                CboTipoDatoGrupoEspeciales.Focus()
            Else
                CboTipoDatoIdEspeciales.Enabled = True
                CboTipoDatoIdEspeciales.Focus()
            End If
        End If
    End Sub

    '--==============================================================--

    Private Sub CboTipoDatoIdEspeciales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CboTipoDatoIdEspeciales.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If CboTipoDatoIdEspeciales.Text = "" Then
                MsgBox("Dato CamMasc1 es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "tools")
                CboTipoDatoIdEspeciales.Text = ""
                CboTipoDatoIdEspeciales.Focus()
            Else
                ContenidoCampoEspecialRichTextBox.Enabled = True
                ContenidoCampoEspecialRichTextBox.Focus()
            End If
        End If
    End Sub

    '--==============================================================--
    Private Sub ContenidoCampoEspecialRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContenidoCampoEspecialRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True Then
                Actualizar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
                Eliminar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
            Else
                If ContenidoCampoEspecialRichTextBox.Text = "" Then
                    MsgBox(" Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "NombreProyecto")
                    ContenidoCampoEspecialRichTextBox.Text = ""
                    ContenidoCampoEspecialRichTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleTipoDatoComponenteEspeciales.Enabled = True
                    Timer_Guardar_PleTipoDatoComponenteEspeciales()
                End If
            End If
        End If
    End Sub

    '---------------------------------------------------------------------------


    '--==============================================================--
    ' Especiales


    '--==============================================================--
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales As Timer
    Private WithEvents Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales As Timer
    Private WithEvents Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleTipoDatoComponenteEspeciales()
        Me.Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales.Interval = 250
        Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleTipoDatoComponenteEspeciales()
        Me.Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales.Interval = 500
        Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleTipoDatoComponenteEspeciales()
        Me.Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales.Interval = 800
        Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales.Tick
        If Guardar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White Then
            Guardar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.Green
        Else
            Guardar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales.Tick
        If Actualizar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White Then
            Actualizar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.Green
        Else
            Actualizar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales.Tick
        If Eliminar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White Then
            Eliminar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.Red
        Else
            Eliminar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleTipoDatoComponenteEspeciales()
        Me.Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Guardar_Menu_PleTipoDatoComponenteEspeciales.Stop()
        Guardar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Actualizar_Menu_PleTipoDatoComponenteEspeciales.Stop()
        Actualizar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Eliminar_Menu_PleTipoDatoComponenteEspeciales.Stop()
        Eliminar_Menu_PleTipoDatoComponenteEspeciales.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleTipoDatoComponenteEspeciales As Timer
    Dim X_PleTipoDatoComponenteEspeciales
    Private Sub Timer_Ubicar_En_Fila_PleTipoDatoComponenteEspeciales()
        Me.Timer_Ubicacion_PleTipoDatoComponenteEspeciales = New Timer
        Timer_Ubicacion_PleTipoDatoComponenteEspeciales.Interval = 100
        Timer_Ubicacion_PleTipoDatoComponenteEspeciales.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleTipoDatoComponenteEspeciales = SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleTipoDatoComponenteEspeciales()
        Try
            Me.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleTipoDatoComponenteEspeciales).Selected = True
            Me.SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleTipoDatoComponenteEspeciales
        Catch ex As Exception
        End Try
    End Sub





    '--==============================================================--

    Private Sub Timer_Ubicacion_PleTipoDatoComponenteEspeciales_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleTipoDatoComponenteEspeciales.Tick
        Ubicar_En_Fila_PleTipoDatoComponenteEspeciales()
        Timer_Ubicacion_PleTipoDatoComponenteEspeciales.Stop()
    End Sub





#End Region

#End Region

#End Region

#Region "TODO PleProyectoTecnologiaArchivos"

    Private Sub BtnAgregarCarpeta_Click(sender As Object, e As EventArgs) Handles BtnAgregarCarpeta.Click
        GeneraraArchivosDeProyecto()
    End Sub
    Private Sub GeneraraArchivosDeProyecto()
        If ChkCreaCarpetasYArchivos.Checked = False Then
            MsgBox("Debes seleccionar la creacion de carpetas y archivos, favor verificar", MsgBoxStyle.Exclamation)
        Else
            If ProyectoPrueba.Text = "" Then
                MsgBox("No has definido un proyecto", MsgBoxStyle.Exclamation)
            Else
                If RutaBaseTextBox.Text = "" Then
                    MsgBox("No tienes una ruta definida, favor verificar", MsgBoxStyle.Exclamation)
                Else
                    If NombreArchivoTextBox.Text = "" Then
                        MsgBox("Debes definir un nombre de archivo, favor verificar", MsgBoxStyle.Exclamation)
                    Else
                        If ExtensionArchivoComboBox.Text = "" Then
                            MsgBox("Debes de definir una extension para el archivo, favor verificar", MsgBoxStyle.Exclamation)
                        Else
                            If ContenidoRich.Text = "" Then
                                If MsgBox("No tiene contenido el Archivo, Desea guardarlo vacio", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    ValidarExistenciaArchivos(RutaBaseTextBox.Text, NombreArchivoTextBox.Text, ContenidoRich.Text, ExtensionArchivoComboBox.Text, ProyectoPrueba.Text)
                                Else
                                    MsgBox("Se cancelo la instrucción", MsgBoxStyle.Information)
                                End If
                            Else
                                ValidarExistenciaArchivos(RutaBaseTextBox.Text, NombreArchivoTextBox.Text, ContenidoRich.Text, ExtensionArchivoComboBox.Text, ProyectoPrueba.Text)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub ValidarExistenciaArchivos(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String, Extension As String, Proyecto As String)
        Ruta = ReplaceRuta(Ruta)
        If My.Computer.FileSystem.FileExists(Ruta) Then
            My.Computer.FileSystem.WriteAllText(Ruta + "\" + Archivo, Contenido, True)
            Metodo_Aviso_Acciones(5, "Archivo ya existe")
        Else
            My.Computer.FileSystem.CreateDirectory(Ruta)
            Dim MiArchivo As String = Archivo
            MiArchivo = ReplaceRuta(MiArchivo)
            Dim path As String = Ruta + "\" + MiArchivo + Extension
            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)
            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(Contenido)
            fs.Write(info, 0, info.Length)
            fs.Close()
            Metodo_Aviso_Acciones(2, "Archivo creado exitosamente")
            ListFiles(Ruta, Extension)
        End If
    End Sub

    Function ReplaceRuta(Ruta As String)
        Dim RutaResultado As String = ""

        If ProyectoPrueba.Text <> "" Then
            If InStr(Ruta, "ProyectoTrabajado") Then
                RutaResultado = Ruta.Replace("ProyectoTrabajado", ProyectoPrueba.Text)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            Else
                RutaResultado = Ruta
            End If
        End If

        If TablaPrueba.Text <> "" Then
            If InStr(Ruta, "{{{Tabla}}}") Then
                RutaResultado = RutaResultado.Replace("{{{Tabla}}}", TablaPrueba.Text)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{Tbl-Camel}}}") Then
                Dim formato As String = "Camel-Case"
                Dim TablaCamel = TratamientoFormatoCampo(TablaPrueba.Text, formato)
                RutaResultado = RutaResultado.Replace("{{{Tbl-Camel}}}", TablaCamel)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{Tmin}}}") Then
                Dim Tablamin As String
                Tablamin = LCase(TablaPrueba.Text)
                RutaResultado = RutaResultado.Replace("{{{Tmin}}}", Tablamin)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If

            If InStr(Ruta, "{{{A=>-a}}}") Then
                RutaResultado = FrmNewReplace.ConvertirMayusculasMinSeparadasPorGuion(Ruta, TablaPrueba.Text, 1)
                RutaResultado = GuardaRetornaActualizado(RutaResultado)
            End If
        End If

        Return RutaResultado
    End Function

    Private Sub tratamientoRuta(ByVal ruta As String, ByVal rutaBase As String)
        Dim Directorio() As String
        Dim rutaVerificar As String = rutaBase
        Directorio = ruta.Split("\")
        For i = 0 To Directorio.Length - 1
            rutaVerificar = rutaVerificar & "\" & Directorio(i)
            If (My.Computer.FileSystem.DirectoryExists(rutaVerificar) = False) Then
                My.Computer.FileSystem.CreateDirectory(rutaVerificar)
            End If
        Next
    End Sub




    Private Sub BtnCargaRuta_Click(sender As Object, e As EventArgs) Handles BtnCargaRuta.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            RutaBaseTextBox.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub BotonPasa1_Click(sender As Object, e As EventArgs) Handles BotonPasa1.Click
        ContenidoRich.Text = CodUnoTextBox.Text
    End Sub

    Private Sub BotonPasa2_Click(sender As Object, e As EventArgs) Handles BotonPasa2.Click
        ContenidoRich.Text = CodDosTextBox.Text
    End Sub

    Private Sub BotonPasa3_Click(sender As Object, e As EventArgs) Handles BotonPasa3.Click
        ContenidoRich.Text = CodTresTextBox.Text
    End Sub

    Private Sub BotonPasa4_Click(sender As Object, e As EventArgs) Handles BotonPasa4.Click
        ContenidoRich.Text = CodCuatroTextBox.Text
    End Sub

    Private Sub BotonPasa5_Click(sender As Object, e As EventArgs) Handles BotonPasa5.Click
        ContenidoRich.Text = CodCincoTextBox.Text
    End Sub

    Private Sub BotonPasa6_Click(sender As Object, e As EventArgs) Handles BotonPasa6.Click
        ContenidoRich.Text = CodSeisTextBox.Text
    End Sub

    Private Sub BtnTablaRuta_Click(sender As Object, e As EventArgs) Handles BtnTablaRuta.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "{{{Tabla}}}")
    End Sub

    Private Sub BtnTablaCamelRuta_Click(sender As Object, e As EventArgs) Handles BtnTablaCamelRuta.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "{{{Tbl-Camel}}}")
    End Sub

    Private Sub BtnTablaMinusculaRuta_Click(sender As Object, e As EventArgs) Handles BtnTablaMinusculaRuta.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "{{{Tmin}}}")
    End Sub

    Private Sub BtnTablaPrimeraMinRuta_Click(sender As Object, e As EventArgs) Handles BtnTablaPrimeraMinRuta.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "{{{A=>-a}}}")
    End Sub

    Private Sub ListFiles(ByVal folderPath As String, ByVal Extension As String)
        filesListBox.Items.Clear()
        Dim fileNames = My.Computer.FileSystem.GetFiles(
            folderPath, FileIO.SearchOption.SearchTopLevelOnly, "*" + Extension)
        For Each fileName As String In fileNames
            filesListBox.Items.Add(fileName)
        Next
    End Sub

    Private Sub BtnVisualizarRuta_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSlach_Click(sender As Object, e As EventArgs) Handles BtnSlach.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "\")
        RutaBaseTextBox.Focus()
    End Sub

    Private Sub BtnProyecto_Click(sender As Object, e As EventArgs) Handles BtnProyecto.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, "ProyectoTrabajado")
        RutaBaseTextBox.Focus()
    End Sub

    Private Sub BtnTecnologia_Click(sender As Object, e As EventArgs) Handles BtnTecnologia.Click
        Me.RutaBaseTextBox.Text = Me.RutaBaseTextBox.Text.Insert(Me.RutaBaseTextBox.SelectionStart, NombreCarpetaTecnologiaTextBox.Text)
        RutaBaseTextBox.Focus()
    End Sub

    Private Sub BtnCopiarRuta_Click(sender As Object, e As EventArgs) Handles BtnCopiarRuta.Click
        If RutaBaseTextBox.Text <> "" Then
            Clipboard.SetText(RutaBaseTextBox.Text)
        End If
        Metodo_Aviso_Acciones(2, "Ruta copiada exitosamente")
    End Sub





#End Region

#Region "TODO PleRutasArchivosTecnologias"

    Private Sub SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                     New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExtensionTextBox_TextChanged(sender As Object, e As EventArgs) Handles ExtensionTextBox.TextChanged
        ExtensionArchivoComboBox.Text = ExtensionTextBox.Text
    End Sub

    '--=== CANCELACIÓN 

    Sub Cancelar_PleRutasArchivosTecnologias()
        'Botones Del Menu
        Nuevo_Menu_PleRutasArchivosTecnologias.Enabled = True
        Guardar_Menu_PleRutasArchivosTecnologias.Enabled = False
        Editar_Menu_PleRutasArchivosTecnologias.Enabled = True
        Actualizar_Menu_PleRutasArchivosTecnologias.Enabled = False
        Eliminar_Menu_PleRutasArchivosTecnologias.Enabled = False
        ValidarCierre.Text = ""
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleRutasArchivosTecnologias()
        Parar_Timer_PleRutasArchivosTecnologias()
    End Sub

    '--=== INSERTAR 

    'Insertar PleRutasArchivosTecnologias
    Private Sub SP_PleRutasArchivosTecnologias_EDICION_INSERTAR(RutaBase As String,
NombreArchivo As String,
Extension As String,
ComponenteId As Integer
)
        Try
            Me.SP_PleRutasArchivosTecnologias_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologias_EDICION_INSERTAR,
                                                            RutaBase,
                                                            NombreArchivo,
                                                            Extension,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleRutasArchivosTecnologias")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleRutasArchivosTecnologias
    Private Sub SP_PleRutasArchivosTecnologias_EDICION_ACTUALIZAR(PleRutasArchivosTecnologiasId As Integer,
RutaBase As String,
NombreArchivo As String,
Extension As String,
ComponenteId As Integer
)

        Try
            Me.SP_PleRutasArchivosTecnologias_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologias_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleRutasArchivosTecnologiasId, Integer)),
                                                            RutaBase,
                                                            NombreArchivo,
                                                            Extension,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleRutasArchivosTecnologias")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleRutasArchivosTecnologias_EDICION_ELIMINAR(PleRutasArchivosTecnologiasId As Integer)
        Try
            Me.SP_PleRutasArchivosTecnologias_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleRutasArchivosTecnologias_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleRutasArchivosTecnologiasId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleRutasArchivosTecnologias Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleRutasArchivosTecnologias()
        RutaBaseTextBox.Enabled = False
        NombreArchivoTextBox.Enabled = False
        ExtensionArchivoComboBox.Enabled = False
        BtnCargaRuta.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleRutasArchivosTecnologias()
        RutaBaseTextBox.Enabled = True
        NombreArchivoTextBox.Enabled = True
        ExtensionArchivoComboBox.Enabled = True
        BtnCargaRuta.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleRutasArchivosTecnologias()
        RutaBaseTextBox.Text = ""
        NombreArchivoTextBox.Text = ""
        ExtensionArchivoComboBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleRutasArchivosTecnologias()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case RutaBaseTextBox.Text = ""
                MsgBox("El nombre del campo: ruta del archivo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RutaBaseTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case NombreArchivoTextBox.Text = ""
                MsgBox("El nombre del campo: Nombre del archivo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                NombreArchivoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case ExtensionArchivoComboBox.Text = ""
                MsgBox("El nombre del campo: Extension de archivo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ExtensionArchivoComboBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleRutasArchivosTecnologias.Click
        If RutaBaseTextBox.Text = "" Then
            Nuevo_Menu_PleRutasArchivosTecnologias.Enabled = False
            Editar_Menu_PleRutasArchivosTecnologias.Enabled = False
            BtnCargaRuta.Enabled = True
            ValidarCierre.Text = 1
            Limpiar_Objetos_PleRutasArchivosTecnologias()
            RutaBaseTextBox.Enabled = True
            RutaBaseTextBox.Focus()
        Else
            MsgBox("Ya existe una ruta para este componente, favor verificar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleRutasArchivosTecnologias.Click
        Control_Nulos_PleRutasArchivosTecnologias()

        If ControlNulos.Text = "" Then
            'Validar que la ruta incluya tanto el proyecto como la tecnologia
            If InStr(RutaBaseTextBox.Text, "ProyectoTrabajado") Then
                If InStr(RutaBaseTextBox.Text, NombreCarpetaTecnologiaTextBox.Text) Then
                    SP_PleRutasArchivosTecnologias_EDICION_INSERTAR(RutaBaseTextBox.Text, NombreArchivoTextBox.Text, ExtensionArchivoComboBox.Text, ComponenteIdTextBox.Text)
                    Cancelar_PleRutasArchivosTecnologias()
                    Parar_Timer_PleRutasArchivosTecnologias()
                Else
                    MsgBox("Se debe de crear una carpeta de la tecnologia implementada y tu Ruta no la tiene, favor verificar", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("No ha definido un proyecto en el cual implementar este componente, Favor verificar", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleRutasArchivosTecnologias.Click
        Nuevo_Menu_PleRutasArchivosTecnologias.Enabled = False
        Guardar_Menu_PleRutasArchivosTecnologias.Enabled = False
        Editar_Menu_PleRutasArchivosTecnologias.Enabled = False
        Actualizar_Menu_PleRutasArchivosTecnologias.Enabled = True
        Eliminar_Menu_PleRutasArchivosTecnologias.Enabled = True
        BtnCargaRuta.Enabled = True
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleRutasArchivosTecnologias()
        Timer_Actualizar_PleRutasArchivosTecnologias()
        Timer_Eliminar_PleRutasArchivosTecnologias()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleRutasArchivosTecnologias.Click
        Control_Nulos_PleRutasArchivosTecnologias()

        If ControlNulos.Text = "" Then
            If InStr(RutaBaseTextBox.Text, "ProyectoTrabajado") Then
                If InStr(RutaBaseTextBox.Text, NombreCarpetaTecnologiaTextBox.Text) Then
                    SP_PleRutasArchivosTecnologias_EDICION_ACTUALIZAR(PleRutasArchivosTecnologiasIdTextBox.Text, RutaBaseTextBox.Text, NombreArchivoTextBox.Text, ExtensionArchivoComboBox.Text, ComponenteIdTextBox.Text)
                    Cancelar_PleRutasArchivosTecnologias()
                    Parar_Timer_PleRutasArchivosTecnologias()
                Else
                    MsgBox("Se debe de crear una carpeta de la tecnologia implementada y tu Ruta no la tiene, favor verificar", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("No ha definido un proyecto en el cual implementar este componente, Favor verificar", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleRutasArchivosTecnologias.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleRutasArchivosTecnologias_EDICION_ELIMINAR(PleRutasArchivosTecnologiasIdTextBox.Text)
            Cancelar_PleRutasArchivosTecnologias()
            Parar_Timer_PleRutasArchivosTecnologias()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleRutasArchivosTecnologias()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleRutasArchivosTecnologias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleRutasArchivosTecnologias.Click
        Cancelar_PleRutasArchivosTecnologias()
    End Sub



    '--=== NAVEGACIÓN

    Private Sub RutaBaseTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RutaBaseTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If RutaBaseTextBox.Text = "" Then
                MsgBox("El Dato: ruta del archivo es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                RutaBaseTextBox.Focus()
            Else
                NombreArchivoTextBox.Enabled = True
                NombreArchivoTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub NombreArchivoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NombreArchivoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If NombreArchivoTextBox.Text = "" Then
                MsgBox("El Dato: Nombre del archivo es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                NombreArchivoTextBox.Focus()
            Else
                ExtensionArchivoComboBox.Enabled = True
                ExtensionArchivoComboBox.Focus()
            End If
        End If
    End Sub

    Private Sub ExtensionArchivoComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ExtensionArchivoComboBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleRutasArchivosTecnologias.Enabled = True Then
                Actualizar_Menu_PleRutasArchivosTecnologias.Enabled = True
                Eliminar_Menu_PleRutasArchivosTecnologias.Enabled = True
            Else
                If ExtensionArchivoComboBox.Text = "" Then
                    MsgBox("El Dato: Extensión de archivo es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    ExtensionArchivoComboBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleRutasArchivosTecnologias.Enabled = True
                    Timer_Guardar_PleRutasArchivosTecnologias()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES



    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleRutasArchivosTecnologias As Timer
    Private WithEvents Timer_Actualizar_Menu_PleRutasArchivosTecnologias As Timer
    Private WithEvents Timer_Eliminar_Menu_PleRutasArchivosTecnologias As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleRutasArchivosTecnologias()
        Me.Timer_Guardar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Guardar_Menu_PleRutasArchivosTecnologias.Interval = 250
        Timer_Guardar_Menu_PleRutasArchivosTecnologias.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleRutasArchivosTecnologias()
        Me.Timer_Actualizar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Actualizar_Menu_PleRutasArchivosTecnologias.Interval = 500
        Timer_Actualizar_Menu_PleRutasArchivosTecnologias.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleRutasArchivosTecnologias()
        Me.Timer_Eliminar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Eliminar_Menu_PleRutasArchivosTecnologias.Interval = 800
        Timer_Eliminar_Menu_PleRutasArchivosTecnologias.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleRutasArchivosTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleRutasArchivosTecnologias.Tick
        If Guardar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White Then
            Guardar_Menu_PleRutasArchivosTecnologias.BackColor = Color.Green
        Else
            Guardar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleRutasArchivosTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleRutasArchivosTecnologias.Tick
        If Actualizar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White Then
            Actualizar_Menu_PleRutasArchivosTecnologias.BackColor = Color.Green
        Else
            Actualizar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleRutasArchivosTecnologias_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleRutasArchivosTecnologias.Tick
        If Eliminar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White Then
            Eliminar_Menu_PleRutasArchivosTecnologias.BackColor = Color.Red
        Else
            Eliminar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
        End If
    End Sub



    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleRutasArchivosTecnologias()
        Me.Timer_Guardar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Guardar_Menu_PleRutasArchivosTecnologias.Stop()
        Guardar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Actualizar_Menu_PleRutasArchivosTecnologias.Stop()
        Actualizar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleRutasArchivosTecnologias = New Timer
        Timer_Eliminar_Menu_PleRutasArchivosTecnologias.Stop()
        Eliminar_Menu_PleRutasArchivosTecnologias.BackColor = Color.White
    End Sub



    '--==============================================================--



#End Region

#End Region

#Region "TODO PleMetricas"

    '--==============================================================--

    Private Sub SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId)
        Try
            Me.SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                     New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '--==============================================================--



    '--=== CANCELACIÓN 

    Sub Cancelar_PleMetricas()
        'Botones Del Menu
        Nuevo_Menu_PleMetricas.Enabled = True
        Guardar_Menu_PleMetricas.Enabled = False
        Editar_Menu_PleMetricas.Enabled = True
        Actualizar_Menu_PleMetricas.Enabled = False
        Eliminar_Menu_PleMetricas.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleMetricas()
        Parar_Timer_PleMetricas()
    End Sub

    '--=== INSERTAR 

    'Insertar PleMetricas
    Private Sub SP_PleMetricas_EDICION_INSERTAR(ComponenteId As Integer,
Tiempo As Integer,
PorTabla As Boolean
)
        Try
            Me.SP_PleMetricas_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleMetricas_EDICION_INSERTAR,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(Tiempo, Integer)),
                                                            New System.Nullable(Of Integer)(CType(PorTabla, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleMetricas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleMetricas
    Private Sub SP_PleMetricas_EDICION_ACTUALIZAR(PleMetricasId As Integer,
ComponenteId As Integer,
Tiempo As Integer,
PorTabla As Boolean
)

        Try
            Me.SP_PleMetricas_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleMetricas_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleMetricasId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(Tiempo, Integer)),
                                                            New System.Nullable(Of Integer)(CType(PorTabla, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleMetricas")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleMetricas_EDICION_ELIMINAR(PleMetricasId As Integer)
        Try
            Me.SP_PleMetricas_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleMetricas_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleMetricasId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleMetricas Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleMetricas()
        TiempoTextBox.Enabled = False
        PorTablaCheckBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleMetricas()
        TiempoTextBox.Enabled = True
        PorTablaCheckBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleMetricas()
        TiempoTextBox.Text = ""
        PorTablaTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleMetricas()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case TiempoTextBox.Text = ""
                MsgBox("El nombre del campo: Tiempo por componente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TiempoTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case PorTablaTextBox.Text = ""
                MsgBox("El nombre del campo: Registro de tiempo por tabla; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PorTablaTextBox.BackColor = Color.White
                ControlNulos.Text = "1"

            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleMetricas.Click
        Nuevo_Menu_PleMetricas.Enabled = False
        Editar_Menu_PleMetricas.Enabled = False
        ValidarCierre.Text = 1
        Limpiar_Objetos_PleMetricas()
        TiempoTextBox.Enabled = True
        TiempoTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleMetricas.Click
        Control_Nulos_PleMetricas()

        If ControlNulos.Text = "" Then
            SP_PleMetricas_EDICION_INSERTAR(ComponenteIdTextBox.Text,
        TiempoTextBox.Text,
        PorTablaTextBox.Text
)
            Cancelar_PleMetricas()
            Parar_Timer_PleMetricas()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleMetricas.Click
        Nuevo_Menu_PleMetricas.Enabled = False
        Guardar_Menu_PleMetricas.Enabled = False
        Editar_Menu_PleMetricas.Enabled = False
        Actualizar_Menu_PleMetricas.Enabled = True
        Eliminar_Menu_PleMetricas.Enabled = True
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleMetricas()
        Timer_Actualizar_PleMetricas()
        Timer_Eliminar_PleMetricas()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleMetricas.Click
        Control_Nulos_PleMetricas()

        If ControlNulos.Text = "" Then
            SP_PleMetricas_EDICION_ACTUALIZAR(PleMetricasIdTextBox.Text,
        ComponenteIdTextBox.Text,
        TiempoTextBox.Text,
        PorTablaTextBox.Text
)
            Cancelar_PleMetricas()
            Parar_Timer_PleMetricas()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleMetricas.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleMetricas_EDICION_ELIMINAR(PleMetricasIdTextBox.Text)
            Cancelar_PleMetricas()
            Parar_Timer_PleMetricas()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleMetricas()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleMetricas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleMetricas.Click
        Cancelar_PleMetricas()
    End Sub

    '--=== NAVEGACIÓN

    Private Sub TiempoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TiempoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TiempoTextBox.Text = "" Then
                MsgBox("El Dato: Tiempo por componente es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                TiempoTextBox.Focus()
            Else
                PorTablaCheckBox.Enabled = True
                PorTablaCheckBox.Focus()
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

    Private Sub PorTablaCheckBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PorTablaCheckBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleMetricas.Enabled = True Then
                Actualizar_Menu_PleMetricas.Enabled = True
                Eliminar_Menu_PleMetricas.Enabled = True
            Else
                If PorTablaTextBox.Text = "" Then
                    MsgBox("El Dato: Registro de tiempo por tabla es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    PorTablaCheckBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleMetricas.Enabled = True
                    Timer_Guardar_PleMetricas()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES

    ' Para elementos ChecBox
    '--==================================================================================================
    Private Sub PorTablaCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorTablaCheckBox.CheckedChanged
        If PorTablaCheckBox.Checked = True Then
            PorTablaCheckBox.Text = "Tiempo de creación de componente aplicado por Tabla"
            If XTablaCheckBox.Checked = False Then
                If Nuevo_Menu_PleMetricas.Enabled = False Then
                    If MsgBox("Este componente esta configurado para no trabajarlo por tablas, desea continuar con esta selección?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        PorTablaCheckBox.Text = "Tiempo de creación de componente aplicado por Tabla"
                        PorTablaTextBox.Text = "True"
                    Else
                        PorTablaCheckBox.Text = "Solo para el componete"
                        PorTablaCheckBox.Checked = False
                        PorTablaTextBox.Text = "False"
                    End If
                End If
            Else
                PorTablaCheckBox.Text = "Tiempo de creación de componente aplicado por Tabla"
                PorTablaTextBox.Text = "True"
            End If
        Else
            PorTablaCheckBox.Text = "Solo para el componete"
            PorTablaTextBox.Text = "False"
        End If
    End Sub


    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleMetricas As Timer
    Private WithEvents Timer_Actualizar_Menu_PleMetricas As Timer
    Private WithEvents Timer_Eliminar_Menu_PleMetricas As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleMetricas()
        Me.Timer_Guardar_Menu_PleMetricas = New Timer
        Timer_Guardar_Menu_PleMetricas.Interval = 250
        Timer_Guardar_Menu_PleMetricas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleMetricas()
        Me.Timer_Actualizar_Menu_PleMetricas = New Timer
        Timer_Actualizar_Menu_PleMetricas.Interval = 500
        Timer_Actualizar_Menu_PleMetricas.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleMetricas()
        Me.Timer_Eliminar_Menu_PleMetricas = New Timer
        Timer_Eliminar_Menu_PleMetricas.Interval = 800
        Timer_Eliminar_Menu_PleMetricas.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleMetricas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleMetricas.Tick
        If Guardar_Menu_PleMetricas.BackColor = Color.White Then
            Guardar_Menu_PleMetricas.BackColor = Color.Green
        Else
            Guardar_Menu_PleMetricas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleMetricas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleMetricas.Tick
        If Actualizar_Menu_PleMetricas.BackColor = Color.White Then
            Actualizar_Menu_PleMetricas.BackColor = Color.Green
        Else
            Actualizar_Menu_PleMetricas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleMetricas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleMetricas.Tick
        If Eliminar_Menu_PleMetricas.BackColor = Color.White Then
            Eliminar_Menu_PleMetricas.BackColor = Color.Red
        Else
            Eliminar_Menu_PleMetricas.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleMetricas()
        Me.Timer_Guardar_Menu_PleMetricas = New Timer
        Timer_Guardar_Menu_PleMetricas.Stop()
        Guardar_Menu_PleMetricas.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleMetricas = New Timer
        Timer_Actualizar_Menu_PleMetricas.Stop()
        Actualizar_Menu_PleMetricas.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleMetricas = New Timer
        Timer_Eliminar_Menu_PleMetricas.Stop()
        Eliminar_Menu_PleMetricas.BackColor = Color.White
    End Sub



    '--==============================================================--



#End Region

#End Region

#Region "TODO PleAnkis"

    Private Sub SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                  New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    '--=== CANCELACIÓN 

    Sub Cancelar_PleAnkis()
        'Botones Del Menu
        Nuevo_Menu_PleAnkis.Enabled = True
        Guardar_Menu_PleAnkis.Enabled = False
        Editar_Menu_PleAnkis.Enabled = True
        Actualizar_Menu_PleAnkis.Enabled = False
        Eliminar_Menu_PleAnkis.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleAnkis()
        Parar_Timer_PleAnkis()
        Timer_Ubicar_En_Fila_PleAnkis()
    End Sub

    '--=== INSERTAR 

    'Insertar PleAnkis
    Private Sub SP_PleAnkis_EDICION_INSERTAR(Pregunta As String,
Respuesta As String,
ComponenteId As Integer
)
        Try
            Me.SP_PleAnkis_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkis_EDICION_INSERTAR,
                                                            Pregunta,
                                                            Respuesta,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleAnkis")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleAnkis
    Private Sub SP_PleAnkis_EDICION_ACTUALIZAR(AnkisId As Integer,
Pregunta As String,
Respuesta As String,
ComponenteId As Integer
)

        Try
            Me.SP_PleAnkis_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkis_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(AnkisId, Integer)),
                                                            Pregunta,
                                                            Respuesta,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer))
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleAnkis")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleAnkis_EDICION_ELIMINAR(AnkisId As Integer)
        Try
            Me.SP_PleAnkis_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkis_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(AnkisId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleAnkis Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleAnkis()
        PreguntaTextBox.Enabled = False
        RespuestaTextBox.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleAnkis()
        PreguntaTextBox.Enabled = True
        RespuestaTextBox.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleAnkis()
        PreguntaTextBox.Text = ""
        RespuestaTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleAnkis()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case PreguntaTextBox.Text = ""
                MsgBox("El nombre del campo: Pregunta; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                PreguntaTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case RespuestaTextBox.Text = ""
                MsgBox("El nombre del campo: Respuesta; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RespuestaTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleAnkis.Click
        Nuevo_Menu_PleAnkis.Enabled = False
        Editar_Menu_PleAnkis.Enabled = False
        ValidarCierre.Text = 1
        SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleAnkis()
        PreguntaTextBox.Enabled = True
        PreguntaTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleAnkis.Click
        Control_Nulos_PleAnkis()

        If ControlNulos.Text = "" Then
            SP_PleAnkis_EDICION_INSERTAR(PreguntaTextBox.Text,
        RespuestaTextBox.Text,
        ComponenteIdTextBox.Text
)
            Cancelar_PleAnkis()
            Parar_Timer_PleAnkis()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleAnkis.Click
        Nuevo_Menu_PleAnkis.Enabled = False
        Guardar_Menu_PleAnkis.Enabled = False
        Editar_Menu_PleAnkis.Enabled = False
        Actualizar_Menu_PleAnkis.Enabled = True
        Eliminar_Menu_PleAnkis.Enabled = True
        SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleAnkis()
        Timer_Actualizar_PleAnkis()
        Timer_Eliminar_PleAnkis()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleAnkis.Click
        Control_Nulos_PleAnkis()

        If ControlNulos.Text = "" Then
            SP_PleAnkis_EDICION_ACTUALIZAR(AnkisIdTextBox.Text,
        PreguntaTextBox.Text,
        RespuestaTextBox.Text,
        ComponenteIdTextBox.Text
)
            Cancelar_PleAnkis()
            Parar_Timer_PleAnkis()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleAnkis.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleAnkis_EDICION_ELIMINAR(AnkisIdTextBox.Text)
            Cancelar_PleAnkis()
            Parar_Timer_PleAnkis()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleAnkis()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleAnkis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleAnkis.Click
        Cancelar_PleAnkis()
    End Sub



    '--=== NAVEGACIÓN

    Private Sub PreguntaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PreguntaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If PreguntaTextBox.Text = "" Then
                MsgBox("El Dato: Pregunta es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                PreguntaTextBox.Focus()
            Else
                RespuestaTextBox.Enabled = True
                RespuestaTextBox.Focus()
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

    Private Sub RespuestaTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RespuestaTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleAnkis.Enabled = True Then
                Actualizar_Menu_PleAnkis.Enabled = True
                Eliminar_Menu_PleAnkis.Enabled = True
            Else
                If RespuestaTextBox.Text = "" Then
                    MsgBox("El Dato: ComponenteId es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    RespuestaTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleAnkis.Enabled = True
                    Timer_Guardar_PleAnkis()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES



    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleAnkis As Timer
    Private WithEvents Timer_Actualizar_Menu_PleAnkis As Timer
    Private WithEvents Timer_Eliminar_Menu_PleAnkis As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleAnkis()
        Me.Timer_Guardar_Menu_PleAnkis = New Timer
        Timer_Guardar_Menu_PleAnkis.Interval = 250
        Timer_Guardar_Menu_PleAnkis.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleAnkis()
        Me.Timer_Actualizar_Menu_PleAnkis = New Timer
        Timer_Actualizar_Menu_PleAnkis.Interval = 500
        Timer_Actualizar_Menu_PleAnkis.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleAnkis()
        Me.Timer_Eliminar_Menu_PleAnkis = New Timer
        Timer_Eliminar_Menu_PleAnkis.Interval = 800
        Timer_Eliminar_Menu_PleAnkis.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleAnkis_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleAnkis.Tick
        If Guardar_Menu_PleAnkis.BackColor = Color.White Then
            Guardar_Menu_PleAnkis.BackColor = Color.Green
        Else
            Guardar_Menu_PleAnkis.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleAnkis_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleAnkis.Tick
        If Actualizar_Menu_PleAnkis.BackColor = Color.White Then
            Actualizar_Menu_PleAnkis.BackColor = Color.Green
        Else
            Actualizar_Menu_PleAnkis.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleAnkis_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleAnkis.Tick
        If Eliminar_Menu_PleAnkis.BackColor = Color.White Then
            Eliminar_Menu_PleAnkis.BackColor = Color.Red
        Else
            Eliminar_Menu_PleAnkis.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleAnkis()
        Me.Timer_Guardar_Menu_PleAnkis = New Timer
        Timer_Guardar_Menu_PleAnkis.Stop()
        Guardar_Menu_PleAnkis.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleAnkis = New Timer
        Timer_Actualizar_Menu_PleAnkis.Stop()
        Actualizar_Menu_PleAnkis.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleAnkis = New Timer
        Timer_Eliminar_Menu_PleAnkis.Stop()
        Eliminar_Menu_PleAnkis.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleAnkis As Timer
    Dim X_PleAnkis
    Private Sub Timer_Ubicar_En_Fila_PleAnkis()
        Me.Timer_Ubicacion_PleAnkis = New Timer
        Timer_Ubicacion_PleAnkis.Interval = 100
        Timer_Ubicacion_PleAnkis.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleAnkis = SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleAnkis()
        Try
            Me.SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleAnkis).Selected = True
            Me.SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleAnkis
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleAnkis_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleAnkis.Tick
        Ubicar_En_Fila_PleAnkis()
        Timer_Ubicacion_PleAnkis.Stop()
    End Sub


#End Region

#End Region

#End Region

#Region "TODO PleAnkisImagenes"

    Private Sub SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisId(AnkisId As Integer)
        Try
            Me.SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisId,
                                                                                     New System.Nullable(Of Integer)(CType(AnkisId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    '--==============================================================--






    '--=== CANCELACIÓN 

    Sub Cancelar_PleAnkisImagenes()
        'Botones Del Menu
        Nuevo_Menu_PleAnkisImagenes.Enabled = True
        Guardar_Menu_PleAnkisImagenes.Enabled = False
        Editar_Menu_PleAnkisImagenes.Enabled = True
        Actualizar_Menu_PleAnkisImagenes.Enabled = False
        Eliminar_Menu_PleAnkisImagenes.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If AnkisIdTextBox.Text <> "" Then
            SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisId(AnkisIdTextBox.Text)
        End If
        Bloquear_Objetos_PleAnkisImagenes()
        Parar_Timer_PleAnkisImagenes()
        Timer_Ubicar_En_Fila_PleAnkisImagenes()
    End Sub

    '--=== INSERTAR 

    'Insertar PleAnkisImagenes
    Private Sub SP_PleAnkisImagenes_EDICION_INSERTAR(AnkisId As Integer,
ReferenciaImagen As String,
ByVal ImagenAnki As Byte()
)
        Try
            Me.SP_PleAnkisImagenes_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkisImagenes_EDICION_INSERTAR,
                                                            New System.Nullable(Of Integer)(CType(AnkisId, Integer)),
                                                            ReferenciaImagen,
                                                            ImagenAnki
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleAnkisImagenes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleAnkisImagenes
    Private Sub SP_PleAnkisImagenes_EDICION_ACTUALIZAR(ImagenAnkiId As Integer,
AnkisId As Integer,
ReferenciaImagen As String,
ByVal ImagenAnki As Byte()
)

        Try
            Me.SP_PleAnkisImagenes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkisImagenes_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(ImagenAnkiId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(AnkisId, Integer)),
                                                            ReferenciaImagen,
                                                            ImagenAnki
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleAnkisImagenes")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleAnkisImagenes_EDICION_ELIMINAR(ImagenAnkiId As Integer)
        Try
            Me.SP_PleAnkisImagenes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleAnkisImagenes_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(ImagenAnkiId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleAnkisImagenes Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleAnkisImagenes()
        ReferenciaImagenTextBox.Enabled = False
        BtnCargarImagenAnki.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleAnkisImagenes()
        AnkisIdTextBox.Enabled = True
        ReferenciaImagenTextBox.Enabled = True
        BtnCargarImagenAnki.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleAnkisImagenes()
        ReferenciaImagenTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleAnkisImagenes()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ReferenciaImagenTextBox.Text = ""
                MsgBox("El nombre del campo: Referencia Imagen ; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ReferenciaImagenTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleAnkisImagenes.Click
        If AnkisIdTextBox.Text = "" Then
            MsgBox("No existe una , Favor Verificar", MsgBoxStyle.Critical)
        Else
            Nuevo_Menu_PleAnkisImagenes.Enabled = False
            Editar_Menu_PleAnkisImagenes.Enabled = False
            BtnCargarImagenAnki.Enabled = True
            ValidarCierre.Text = 1
            SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.Enabled = False
            Limpiar_Objetos_PleAnkisImagenes()
            ReferenciaImagenTextBox.Enabled = True
            ReferenciaImagenTextBox.Focus()
        End If
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleAnkisImagenes.Click
        Control_Nulos_PleAnkisImagenes()
        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox2.Image
            SP_PleAnkisImagenes_EDICION_INSERTAR(AnkisIdTextBox.Text,
        ReferenciaImagenTextBox.Text,
        (ImagenToBytes2(myImg))
)
            Cancelar_PleAnkisImagenes()
            Parar_Timer_PleAnkisImagenes()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleAnkisImagenes.Click
        Nuevo_Menu_PleAnkisImagenes.Enabled = False
        Guardar_Menu_PleAnkisImagenes.Enabled = False
        Editar_Menu_PleAnkisImagenes.Enabled = False
        Actualizar_Menu_PleAnkisImagenes.Enabled = True
        Eliminar_Menu_PleAnkisImagenes.Enabled = True
        SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleAnkisImagenes()
        Timer_Actualizar_PleAnkisImagenes()
        Timer_Eliminar_PleAnkisImagenes()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleAnkisImagenes.Click
        Control_Nulos_PleAnkisImagenes()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBox2.Image
            SP_PleAnkisImagenes_EDICION_ACTUALIZAR(ImagenAnkiIdTextBox.Text,
        AnkisIdTextBox.Text,
        ReferenciaImagenTextBox.Text,
        (ImagenToBytes2(myImg))
)
            Cancelar_PleAnkisImagenes()
            Parar_Timer_PleAnkisImagenes()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleAnkisImagenes.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleAnkisImagenes_EDICION_ELIMINAR(ImagenAnkiIdTextBox.Text)
            Cancelar_PleAnkisImagenes()
            Parar_Timer_PleAnkisImagenes()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleAnkisImagenes()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleAnkisImagenes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleAnkisImagenes.Click
        Cancelar_PleAnkisImagenes()
    End Sub


    '--=== NAVEGACIÓN

    Private Sub ReferenciaImagenTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReferenciaImagenTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleAnkisImagenes.Enabled = True Then
                Actualizar_Menu_PleAnkisImagenes.Enabled = True
                Eliminar_Menu_PleAnkisImagenes.Enabled = True
            Else
                If ReferenciaImagenTextBox.Text = "" Then
                    MsgBox("El Dato: Imagen es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    ReferenciaImagenTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleAnkisImagenes.Enabled = True
                    Timer_Guardar_PleAnkisImagenes()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES

    'Conversion de imagen
    Public Function ImagenToBytes2(ByVal Imagen As Image) As Byte()
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
    Dim IMAGEN4 As String
    Dim OpenFileDialog2 As New OpenFileDialog
    Private Sub BtnCargarImagenAnki_Click(sender As Object, e As EventArgs) Handles BtnCargarImagenAnki.Click
        ImagenPictureBox2.Image = Nothing
        Try
            Me.OpenFileDialog2.ShowDialog()
            If Me.OpenFileDialog2.FileName <> "" Then
                IMAGEN4 = OpenFileDialog2.FileName
                Dim largo As Integer = IMAGEN4.Length
                Dim imagen3 As String
                imagen3 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN4), largo - 2, largo))
                If imagen3 <> "gif" And
                    imagen3 <> "bmp" And
                    imagen3 <> "jpg" And
                    imagen3 <> "jpeg" And
                    imagen3 <> "GIF" And
                    imagen3 <> "BMP" And
                    imagen3 <> "JPG" And
                    imagen3 <> "JPEG" And
                    imagen3 <> "PNG" And
                    imagen3 <> "png" Then
                    imagen3 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGEN4), largo - 3, largo))
                    If imagen3 <> "jpeg" And imagen3 <> "JPEG" And imagen3 <> "log1" Then
                        MsgBox("Formato no valido") : Exit Sub
                        If imagen3 <> "log1" Then Exit Sub
                    End If
                End If
            End If
            ImagenPictureBox2.Load(IMAGEN4)
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
    '      2- En su propiedad imagenLayout ponerla en Stretch
    'Visualizar imagen normal
    Private Sub RbNormal1_CheckedChanged(sender As Object, e As EventArgs) Handles RbNormal1.CheckedChanged
        ImagenPictureBox2.SizeMode = PictureBoxSizeMode.Normal
    End Sub
    'Visualizar Ajustado al picturebox
    Private Sub RbAjustado1_CheckedChanged(sender As Object, e As EventArgs) Handles RbAjustado1.CheckedChanged
        ImagenPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    'Visualizar Imagen original centrada
    Private Sub RbCentrada1_CheckedChanged(sender As Object, e As EventArgs) Handles RbCentrada1.CheckedChanged
        ImagenPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub
    'Visualizar imagen en el picture box con zoom
    Private Sub RbZoom1_CheckedChanged(sender As Object, e As EventArgs) Handles RbZoom1.CheckedChanged
        ImagenPictureBox2.SizeMode = PictureBoxSizeMode.Zoom
    End Sub


    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleAnkisImagenes As Timer
    Private WithEvents Timer_Actualizar_Menu_PleAnkisImagenes As Timer
    Private WithEvents Timer_Eliminar_Menu_PleAnkisImagenes As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleAnkisImagenes()
        Me.Timer_Guardar_Menu_PleAnkisImagenes = New Timer
        Timer_Guardar_Menu_PleAnkisImagenes.Interval = 250
        Timer_Guardar_Menu_PleAnkisImagenes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleAnkisImagenes()
        Me.Timer_Actualizar_Menu_PleAnkisImagenes = New Timer
        Timer_Actualizar_Menu_PleAnkisImagenes.Interval = 500
        Timer_Actualizar_Menu_PleAnkisImagenes.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleAnkisImagenes()
        Me.Timer_Eliminar_Menu_PleAnkisImagenes = New Timer
        Timer_Eliminar_Menu_PleAnkisImagenes.Interval = 800
        Timer_Eliminar_Menu_PleAnkisImagenes.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleAnkisImagenes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleAnkisImagenes.Tick
        If Guardar_Menu_PleAnkisImagenes.BackColor = Color.White Then
            Guardar_Menu_PleAnkisImagenes.BackColor = Color.Green
        Else
            Guardar_Menu_PleAnkisImagenes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleAnkisImagenes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleAnkisImagenes.Tick
        If Actualizar_Menu_PleAnkisImagenes.BackColor = Color.White Then
            Actualizar_Menu_PleAnkisImagenes.BackColor = Color.Green
        Else
            Actualizar_Menu_PleAnkisImagenes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleAnkisImagenes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleAnkisImagenes.Tick
        If Eliminar_Menu_PleAnkisImagenes.BackColor = Color.White Then
            Eliminar_Menu_PleAnkisImagenes.BackColor = Color.Red
        Else
            Eliminar_Menu_PleAnkisImagenes.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleAnkisImagenes()
        Me.Timer_Guardar_Menu_PleAnkisImagenes = New Timer
        Timer_Guardar_Menu_PleAnkisImagenes.Stop()
        Guardar_Menu_PleAnkisImagenes.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleAnkisImagenes = New Timer
        Timer_Actualizar_Menu_PleAnkisImagenes.Stop()
        Actualizar_Menu_PleAnkisImagenes.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleAnkisImagenes = New Timer
        Timer_Eliminar_Menu_PleAnkisImagenes.Stop()
        Eliminar_Menu_PleAnkisImagenes.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleAnkisImagenes As Timer
    Dim X_PleAnkisImagenes
    Private Sub Timer_Ubicar_En_Fila_PleAnkisImagenes()
        Me.Timer_Ubicacion_PleAnkisImagenes = New Timer
        Timer_Ubicacion_PleAnkisImagenes.Interval = 100
        Timer_Ubicacion_PleAnkisImagenes.Start()
    End Sub

    '--==============================================================--

    Private Sub SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.CellMouseClick
        X_PleAnkisImagenes = SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleAnkisImagenes()
        Try
            Me.SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.Rows(X_PleAnkisImagenes).Selected = True
            Me.SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleAnkisImagenes
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleAnkisImagenes_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleAnkisImagenes.Tick
        Ubicar_En_Fila_PleAnkisImagenes()
        Timer_Ubicacion_PleAnkisImagenes.Stop()
    End Sub

#End Region

#End Region

#End Region

    '--========================FUNCIONALIDADES=======================--

#Region "Paneles"

    Public Sub OcultarPaneles()
        Panel0UIds.Width = 10
        Panel0UIds.Height = 10
        PanelElementos.Width = 10
        PanelElementos.Height = 10
    End Sub
    Private Sub BtnIds_Click(sender As Object, e As EventArgs) Handles BtnIds.Click
        If BtnIds.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            Panel0UIds.BringToFront()
            Panel0UIds.Dock = DockStyle.Fill
            BtnIds.BackColor = Color.Green
        Else
            Panel0UIds.SendToBack()
            Panel0UIds.Dock = DockStyle.None
            BtnIds.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnElementos_Click(sender As Object, e As EventArgs) Handles BtnElementos.Click
        OcultarPaneles()
        '90
        PanelElementos.BringToFront()
        PanelElementos.Dock = DockStyle.Fill
        PanelElementos.Width = 948
        PanelElementos.Height = 662
    End Sub


#End Region

#Region "Texchaged"
    Private Sub TecnologiaIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIdTextBox.TextChanged
        If TecnologiaIdTextBox.Text <> "" Then
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaIdTextBox.Text)
            lblCantTecn.Text = SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Rows.Count
        End If
    End Sub
    Private Sub PlantillaIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIdTextBox.TextChanged
        If PlantillaIdTextBox.Text <> "" Then
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(PlantillaIdTextBox.Text)
        Else
            SP_PleComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaId(0)
        End If
    End Sub
    Private Sub ComponenteIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComponenteIdTextBox.TextChanged
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId_Especiales(ComponenteIdTextBox.Text)
            SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
            SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        Else
            SP_PleTablasRelacionadas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleTipoDatoComponenteCampoView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleRequerimientosComponentesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleTablasComponentes_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleTipoDatoComponenteEspecialesView_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId_Especiales(0)
            SP_PleRutasArchivosTecnologias_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleMetricas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleAnkis_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
            SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(0)
        End If
    End Sub
    Private Sub TipoDatoGrupoIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoGrupoIdPosUno.TextChanged
        If TipoDatoGrupoIdPosUno.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId(TipoDatoGrupoIdPosUno.Text)
        End If
    End Sub
    Private Sub TipoDatoGrupoIdTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoGrupoIdPosDos.TextChanged
        If TipoDatoGrupoIdPosDos.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId1(TipoDatoGrupoIdPosDos.Text)
        End If
    End Sub

    Private Sub NombreGrupoTipoDatoPosUnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoTipoDatoPosUnoTextBox.TextChanged
        CboGrupoTipoDatoPosUno.Text = NombreGrupoTipoDatoPosUnoTextBox.Text
    End Sub

    Private Sub NombreTipoPosUnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoPosUnoTextBox.TextChanged
        CboTipoDatoIdPosUnoTextBox.Text = NombreTipoPosUnoTextBox.Text
        TextBox1.Text = TipoDatoIdPosUnoTextBox.Text
        TextBox2.Text = TipoDatoIdPosDos.Text
    End Sub

    Private Sub TipoCodigoComponentePosUnoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoCodigoComponentePosUnoTextBox.TextChanged
        CboTipoCodigoComponentePosUnoTextBox.Text = TipoCodigoComponentePosUnoTextBox.Text
    End Sub

    Private Sub TipoDatoGrupoIdCreacionTipDat_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoGrupoIdCreacionTipDat.TextChanged
        If TipoDatoGrupoIdCreacionTipDat.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId2_Camp(TipoDatoGrupoIdCreacionTipDat.Text)
        End If
    End Sub
    Private Sub TipoDatoIdBaseCamp_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoIdBaseCamp.TextChanged
        TipoDatoIdCamp.Text = TipoDatoIdBaseCamp.Text
    End Sub

    Private Sub CampDeTablasFormatoIdBase_TextChanged(sender As Object, e As EventArgs) Handles CampDeTablasFormatoIdBase.TextChanged
        CampDeTablasFormatoIdTextBox.Text = CampDeTablasFormatoIdBase.Text
    End Sub
    Private Sub NombreGrupoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoTextBox1.TextChanged
        CboGrupoTipoDato.Text = NombreGrupoTextBox1.Text
    End Sub

    Private Sub NombreTipoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoTextBox1.TextChanged
        CboTipoDatoIdTextBox.Text = NombreTipoTextBox1.Text
    End Sub
    Private Sub NombreFormatoTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreFormatoTextBox.TextChanged
        CboCampDeTablasFormatoIdTextBox.Text = NombreFormatoTextBox.Text
    End Sub


    Private Sub NombreGrupoTipoDatoPosDosTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoTipoDatoPosDosTextBox.TextChanged
        CboGrupoTipoDatoPosDos.Text = NombreGrupoTipoDatoPosDosTextBox.Text
    End Sub
    Private Sub NombreTipoPosDosTextBox_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoPosDosTextBox.TextChanged
        CboTipoDatoIdPosDosTextBox.Text = NombreTipoPosDosTextBox.Text

    End Sub
    Private Sub TipoCodigoComponentePosDosTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoCodigoComponentePosDosTextBox.TextChanged
        CboTipoCodigoComponentePosDosTextBox.Text = TipoCodigoComponentePosDosTextBox.Text
    End Sub


    Private Sub TipoDatoIdPosUno_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoIdPosUno.TextChanged
        TipoDatoIdPosUnoTextBox.Text = TipoDatoIdPosUno.Text
    End Sub
    Private Sub TipoDatoIdPosDos_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoIdPosDos.TextChanged
        TipoDatoIdPosDosTextBox.Text = TipoDatoIdPosDos.Text
    End Sub
    Private Sub TipoDatoGrupoIdEspeciales_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoGrupoIdEspeciales.TextChanged
        If TipoDatoGrupoIdEspeciales.Text <> "" Then
            SP_PleTipoDato_BUSQUEDA_SEGUN_PARAMETRO_TipoDatoGrupoId4(TipoDatoGrupoIdEspeciales.Text)
        End If
    End Sub
    Private Sub TipoDatoIdEspecialesBase_TextChanged(sender As Object, e As EventArgs) Handles TipoDatoIdEspecialesBase.TextChanged
        If TipoDatoIdEspecialesBase.Text <> "" Then
            TipoDatoIdEspeciales.Text = TipoDatoIdEspecialesBase.Text
        End If
    End Sub

    Private Sub NombreGrupoEspeciales_TextChanged(sender As Object, e As EventArgs) Handles NombreGrupoEspeciales.TextChanged
        CboTipoDatoGrupoEspeciales.Text = NombreGrupoEspeciales.Text
    End Sub
    Private Sub NombreTipoEspeciales_TextChanged(sender As Object, e As EventArgs) Handles NombreTipoEspeciales.TextChanged
        CboTipoDatoIdEspeciales.Text = NombreTipoEspeciales.Text
    End Sub

    Private Sub AnkisIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles AnkisIdTextBox.TextChanged
        If AnkisIdTextBox.Text <> "" Then
            SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisId(AnkisIdTextBox.Text)
        Else
            SP_PleAnkisImagenes_BUSQUEDA_SEGUN_PARAMETRO_AnkisId(0)
        End If
    End Sub

#Region "Metodos de carga por Techanged"
    Private Sub SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId(TecnologiaId As Integer)
        Try
            Me.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdTableAdapter.Fill(Me.DataSetMaestros.SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaId,
                                                                                      New System.Nullable(Of Integer)(CType(TecnologiaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#End Region

#Region "Botones Comunes"
    Private Sub BtnMaximizarTecnologia_Click(sender As Object, e As EventArgs) Handles BtnMaximizarTecnologia.Click
        If BtnMaximizarTecnologia.BackColor = Color.Transparent Then
            BtnMaximizarTecnologia.BackColor = Color.Blue
            PleTecnologiasDataGridView.Height = 512
            PanelTecnologia.Height = 660
            PanelTecnologia.BringToFront()
        Else
            BtnMaximizarTecnologia.BackColor = Color.Transparent
            PleTecnologiasDataGridView.Height = 147
            PanelTecnologia.Height = 297
            PanelTecnologia.SendToBack()
        End If
    End Sub
    Private Sub BtnMaximizarPlantilla_Click(sender As Object, e As EventArgs) Handles BtnMaximizarPlantilla.Click
        If BtnMaximizarPlantilla.BackColor = Color.Transparent Then
            PanelPanelPlantillas.BringToFront()
            BtnMaximizarPlantilla.BackColor = Color.Blue
            PanelPanelPlantillas.Location = New Point(9, 7)
            PanelPanelPlantillas.Height = 660
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Height = 531
            DGVEdicionPosicion.Height = 501
        Else
            PanelPanelPlantillas.Location = New Point(9, 310)
            PanelPanelPlantillas.SendToBack()
            BtnMaximizarPlantilla.BackColor = Color.Transparent
            PanelPanelPlantillas.Height = 305
            SP_PlePlantilla_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaIdDataGridView.Height = 173
            DGVEdicionPosicion.Height = 143
        End If
    End Sub


    Private Sub BtnVerTecnologiasYPlantillas_Click(sender As Object, e As EventArgs) Handles BtnVerTecnologiasYPlantillas.Click
        If Panel01VTecnologiasYPlantillas.Width = 411 Then
            tmOCULTARTecnologias.Enabled = True
            BtnVerTecnologiasYPlantillas.BackColor = Color.Transparent
        ElseIf Panel01VTecnologiasYPlantillas.Width = 1 Then
            tmMOSTRARTecnologias.Enabled = True
            BtnVerTecnologiasYPlantillas.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmOCULTARPanelV01Proyectos_Tick(sender As Object, e As EventArgs) Handles tmOCULTARTecnologias.Tick
        If Panel01VTecnologiasYPlantillas.Width <= 1 Then
            Me.tmOCULTARTecnologias.Enabled = False
        Else
            Me.Panel01VTecnologiasYPlantillas.Width = Panel01VTecnologiasYPlantillas.Width - 41
        End If
    End Sub
    Private Sub tmMOSTRARPanelV01Proyectos_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARTecnologias.Tick
        If Panel01VTecnologiasYPlantillas.Width >= 411 Then
            Me.tmMOSTRARTecnologias.Enabled = False
        Else
            Me.Panel01VTecnologiasYPlantillas.Width = Panel01VTecnologiasYPlantillas.Width + 41
        End If
    End Sub


    Private Sub BtnVerComponentes_Click(sender As Object, e As EventArgs) Handles BtnVerComponentes.Click
        If Panel02VComponentes.Width = 201 Then
            tmOCULTARCreacionComponentes.Enabled = True
            BtnVerComponentes.BackColor = Color.Transparent
        ElseIf Panel02VComponentes.Width = 1 Then
            tmMOSTRARCreacionComponentes.Enabled = True
            BtnVerComponentes.BackColor = Color.LawnGreen
        End If
    End Sub
    Private Sub tmOCULTARCreacionComponentes_Tick(sender As Object, e As EventArgs) Handles tmOCULTARCreacionComponentes.Tick
        If Panel02VComponentes.Width <= 1 Then
            Me.tmOCULTARCreacionComponentes.Enabled = False
        Else
            Me.Panel02VComponentes.Width = Panel02VComponentes.Width - 20
        End If
    End Sub
    Private Sub tmMOSTRARCreacionComponentes_Tick(sender As Object, e As EventArgs) Handles tmMOSTRARCreacionComponentes.Tick
        If Panel02VComponentes.Width >= 201 Then
            Me.tmMOSTRARCreacionComponentes.Enabled = False
        Else
            Me.Panel02VComponentes.Width = Panel02VComponentes.Width + 20
        End If
    End Sub








    Private Sub BtnArchivoUno_Click(sender As Object, e As EventArgs) Handles BtnArchivoUno.Click
        If BtnArchivoUno.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodUnoTextBox.BringToFront()
            CodUnoTextBox.Dock = DockStyle.Fill
            BtnArchivoUno.BackColor = Color.Green
        Else
            CodUnoTextBox.SendToBack()
            CodUnoTextBox.Dock = DockStyle.None
            BtnArchivoUno.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnArchivoDos_Click(sender As Object, e As EventArgs) Handles BtnArchivoDos.Click
        If BtnArchivoDos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodDosTextBox.BringToFront()
            CodDosTextBox.Dock = DockStyle.Fill
            BtnArchivoDos.BackColor = Color.Green
        Else
            CodDosTextBox.SendToBack()
            CodDosTextBox.Dock = DockStyle.None
            BtnArchivoDos.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnArchivoTres_Click(sender As Object, e As EventArgs) Handles BtnArchivoTres.Click
        If BtnArchivoTres.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodTresTextBox.BringToFront()
            CodTresTextBox.Dock = DockStyle.Fill
            BtnArchivoTres.BackColor = Color.Green
        Else
            CodTresTextBox.SendToBack()
            CodTresTextBox.Dock = DockStyle.None
            BtnArchivoTres.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnArchivoCuatro_Click(sender As Object, e As EventArgs) Handles BtnArchivoCuatro.Click
        If BtnArchivoCuatro.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodCuatroTextBox.BringToFront()
            CodCuatroTextBox.Dock = DockStyle.Fill
            BtnArchivoCuatro.BackColor = Color.Green
        Else
            CodCuatroTextBox.SendToBack()
            CodCuatroTextBox.Dock = DockStyle.None
            BtnArchivoCuatro.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnArchivoCinco_Click(sender As Object, e As EventArgs) Handles BtnArchivoCinco.Click
        If BtnArchivoCinco.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodCincoTextBox.BringToFront()
            CodCincoTextBox.Dock = DockStyle.Fill
            BtnArchivoCinco.BackColor = Color.Green
        Else
            CodCincoTextBox.SendToBack()
            CodCincoTextBox.Dock = DockStyle.None
            BtnArchivoCinco.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnArchivoSeis_Click(sender As Object, e As EventArgs) Handles BtnArchivoSeis.Click
        If BtnArchivoSeis.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            CodSeisTextBox.BringToFront()
            CodSeisTextBox.Dock = DockStyle.Fill
            BtnArchivoSeis.BackColor = Color.Green
        Else
            CodSeisTextBox.SendToBack()
            CodSeisTextBox.Dock = DockStyle.None
            BtnArchivoSeis.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnTodos_Click(sender As Object, e As EventArgs) Handles BtnTodos.Click
        LimpiarColorBotones()
        BtnTodos.BackColor = Color.Green
        CodUnoTextBox.Dock = DockStyle.None
        CodDosTextBox.Dock = DockStyle.None
        CodTresTextBox.Dock = DockStyle.None
        CodCuatroTextBox.Dock = DockStyle.None
        CodCincoTextBox.Dock = DockStyle.None
        CodSeisTextBox.Dock = DockStyle.None

        CodUnoTextBox.BringToFront()
        CodDosTextBox.BringToFront()
        CodTresTextBox.BringToFront()
        CodCuatroTextBox.BringToFront()
        CodCincoTextBox.BringToFront()
        CodSeisTextBox.BringToFront()

        CodUnoTextBox.Width = 180
        CodUnoTextBox.Height = 530
        CodUnoTextBox.Location = New Point(10, 10)
        CodUnoTextBox.BringToFront()

        CodDosTextBox.Width = 180
        CodDosTextBox.Height = 530
        CodDosTextBox.Location = New Point(200, 10)
        CodDosTextBox.BringToFront()

        CodTresTextBox.Width = 180
        CodTresTextBox.Height = 530
        CodTresTextBox.Location = New Point(390, 10)
        CodTresTextBox.BringToFront()

        CodCuatroTextBox.Width = 180
        CodCuatroTextBox.Height = 530
        CodCuatroTextBox.Location = New Point(580, 10)
        CodCuatroTextBox.BringToFront()

        CodCincoTextBox.Width = 180
        CodCincoTextBox.Height = 530
        CodCincoTextBox.Location = New Point(770, 10)
        CodCincoTextBox.BringToFront()

        CodSeisTextBox.Width = 180
        CodSeisTextBox.Height = 530
        CodSeisTextBox.Location = New Point(960, 10)
        CodSeisTextBox.BringToFront()

    End Sub

    Private Sub BtnActualizacionRapida_Click(sender As Object, e As EventArgs) Handles BtnActualizacionRapida.Click
        Control_Nulos_PleComponentes()
        If ControlNulos.Text = "" Then
            SP_PleComponentes_EDICION_ACTUALIZAR(
        ComponenteIdTextBox.Text,
        PlantillaIdTextBox.Text,
        NombreComponenteTextBox.Text,
        XTablaTextBox.Text,
        BaseTextBox.Text,
        CodUnoTextBox.Text,
        CodDosTextBox.Text,
        CodTresTextBox.Text,
        CodCuatroTextBox.Text,
        CodCincoTextBox.Text,
        CodSeisTextBox.Text
)
            Metodo_Aviso_Acciones(1, "Actualizado!!!")
        End If

    End Sub

    Public Sub LimpiarColorBotones()
        PanelContenidos.BringToFront()
        PanelContenidos.Dock = DockStyle.Fill
        BtnGruposYTiposDatos.BackColor = Color.Transparent
        BtnTodos.BackColor = Color.Transparent
        BtnArchivoUno.BackColor = Color.Transparent
        BtnArchivoDos.BackColor = Color.Transparent
        BtnArchivoTres.BackColor = Color.Transparent
        BtnArchivoCuatro.BackColor = Color.Transparent
        BtnArchivoCinco.BackColor = Color.Transparent
        BtnArchivoSeis.BackColor = Color.Transparent
        BtnRelacionesEntreTablas.BackColor = Color.Transparent
        BtnIds.BackColor = Color.Transparent
        BtnCampos.BackColor = Color.Transparent
        BtnRequerimientos.BackColor = Color.Transparent
        BtnTrabajoConTablas.BackColor = Color.Transparent
        BtnCamposEspeciales.BackColor = Color.Transparent
        BtnGenerarArchivos.BackColor = Color.Transparent
        BtnMetricas.BackColor = Color.Transparent
        BtnDocumentacion.BackColor = Color.Transparent
        BtnAnki.BackColor = Color.Transparent
        BtnBackupBaseDeDatos.BackColor = Color.Transparent
    End Sub

#End Region

#Region "Botones de Marcas"
    Private Sub BtnMarcas_Click(sender As Object, e As EventArgs) Handles BtnMarcas.Click
        If PanelMarcas.Height = 165 Then
            tmOCULTAR_PanelMarcas.Enabled = True
            BtnMarcas.BackColor = Color.Transparent
        ElseIf PanelMarcas.Height = 5 Then
            tmMOSTRAR_PanelMarcas.Enabled = True
            BtnMarcas.BackColor = Color.LawnGreen
        End If
    End Sub

    Private Sub tmMOSTRAR_PanelMarcas_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR_PanelMarcas.Tick
        If PanelMarcas.Height >= 165 Then
            Me.tmMOSTRAR_PanelMarcas.Enabled = False
        Else
            Me.PanelMarcas.Height = PanelMarcas.Height + 5
        End If
    End Sub

    Private Sub tmOCULTAR_PanelMarcas_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR_PanelMarcas.Tick
        If PanelMarcas.Height <= 5 Then
            Me.tmOCULTAR_PanelMarcas.Enabled = False
        Else
            Me.PanelMarcas.Height = PanelMarcas.Height - 5
        End If
    End Sub

    Private Sub BtnImprimeTabla_Click(sender As Object, e As EventArgs) Handles BtnImprimeTabla.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Tabla}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{Tabla}}}")
        End If
    End Sub

    Private Sub BtnTablaPluralMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaPluralMinuscula.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{TPlurMin}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{TPlurMin}}}")
        End If
    End Sub

    Private Sub BtnTodasLasTablas_Click(sender As Object, e As EventArgs) Handles BtnTodasLasTablas.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Tbl-Camel}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{Tbl-Camel}}}")
        End If
    End Sub

    Private Sub BtnTablaPlural_Click(sender As Object, e As EventArgs) Handles BtnTablaPlural.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{TPlur}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{TPlur}}}")
        End If
    End Sub

    Private Sub BtnTablaMinuscula_Click(sender As Object, e As EventArgs) Handles BtnTablaMinuscula.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Tmin}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{Tmin}}}")
        End If
    End Sub

    Private Sub BtnMayusculaAMinuscula_Click(sender As Object, e As EventArgs) Handles BtnMayusculaAMinuscula.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{A=>-a}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{A=>-a}}}")
        End If
    End Sub

    Private Sub BtnGeneraTablas_Click(sender As Object, e As EventArgs) Handles BtnGeneraTablas.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Tabla-G}}}")
        End If
        If BtnGruposYTiposDatos.BackColor = Color.Green Then
            Me.TxtRemplazarPor.Text = Me.TxtRemplazarPor.Text.Insert(Me.TxtRemplazarPor.SelectionStart, "{{{Tabla-G}}}")
        End If
    End Sub

    Private Sub BtnImprimeClavePrincipal_Click(sender As Object, e As EventArgs) Handles BtnImprimeClavePrincipal.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Clave}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Clave}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Clave}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Clave}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Clave}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Clave}}}")
        End If
    End Sub

    Private Sub BtnImprimeCampos_Click(sender As Object, e As EventArgs) Handles BtnImprimeCampos.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Campos}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Campos}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Campos}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Campos}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Campos}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Campos}}}")
        End If
    End Sub

    Private Sub BtnImprimeCamposSinID_Click(sender As Object, e As EventArgs) Handles BtnImprimeCamposSinID.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{TCampos-ID}}}")
        End If
    End Sub

    Private Sub BtnImprimeCamposSinRelacion_Click(sender As Object, e As EventArgs) Handles BtnImprimeCamposSinRelacion.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{TCampos-R}}}")
        End If
    End Sub

    Private Sub BtnCamposRelacionados_Click(sender As Object, e As EventArgs) Handles BtnCamposRelacionados.Click
        If XTablaTextBox.Text = "True" Then
            If BtnArchivoUno.BackColor = Color.Green Then
                Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
            If BtnArchivoDos.BackColor = Color.Green Then
                Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
            If BtnArchivoTres.BackColor = Color.Green Then
                Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
            If BtnArchivoCuatro.BackColor = Color.Green Then
                Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
            If BtnArchivoCinco.BackColor = Color.Green Then
                Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
            If BtnArchivoSeis.BackColor = Color.Green Then
                Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Camp-Rel}}}")
            End If
        Else
            MsgBox("Esta es una funcionalidad que se implementa por tablas, este componente no cumple esta condición, favor verificar", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnImprimeCamposSinIDYSinRelaciones_Click(sender As Object, e As EventArgs) Handles BtnImprimeCamposSinIDYSinRelaciones.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Camp-R-ID}}}")
        End If
    End Sub

    Private Sub BtnCampoEspecial_Click(sender As Object, e As EventArgs) Handles BtnCampoEspecial.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Camp-Esp}}}")
        End If
    End Sub

    Private Sub BtnCamposNav_Click(sender As Object, e As EventArgs) Handles BtnCamposNav.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            Me.CodUnoTextBox.Text = Me.CodUnoTextBox.Text.Insert(Me.CodUnoTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            Me.CodDosTextBox.Text = Me.CodDosTextBox.Text.Insert(Me.CodDosTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            Me.CodTresTextBox.Text = Me.CodTresTextBox.Text.Insert(Me.CodTresTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            Me.CodCuatroTextBox.Text = Me.CodCuatroTextBox.Text.Insert(Me.CodCuatroTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            Me.CodCincoTextBox.Text = Me.CodCincoTextBox.Text.Insert(Me.CodCincoTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            Me.CodSeisTextBox.Text = Me.CodSeisTextBox.Text.Insert(Me.CodSeisTextBox.SelectionStart, "{{{Camp-Nav}}}")
        End If
    End Sub

    Private Sub BtnDesplegarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnDesplegarBusqueda.Click
        If PanelBusquedaTexto.Height = 50 Then
            tmOCULTAR_PanelBusqueda.Enabled = True
        ElseIf PanelBusquedaTexto.Height = 5 Then
            tmMOSTRAR_PanelBusqueda.Enabled = True
        End If
    End Sub
    Private Sub BtnLLenarCampos_Click(sender As Object, e As EventArgs) Handles BtnLLenarCampos.Click
        If Nuevo_Menu_PleComponentes.Enabled = False Then
            CodUnoTextBox.Text = "  "
            CodDosTextBox.Text = "  "
            CodTresTextBox.Text = "  "
            CodCuatroTextBox.Text = "  "
            CodCincoTextBox.Text = "  "
            CodSeisTextBox.Text = "  "
            MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
            Guardar_Menu_PleComponentes.Enabled = True
            Timer_Guardar_PleComponentes()
        End If
    End Sub

    Private Sub tmMOSTRAR_PanelBusqueda_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR_PanelBusqueda.Tick
        If PanelBusquedaTexto.Height >= 50 Then
            Me.tmMOSTRAR_PanelBusqueda.Enabled = False
        Else
            Me.PanelBusquedaTexto.Height = PanelBusquedaTexto.Height + 5
        End If
    End Sub

    Private Sub tmOCULTAR_PanelBusqueda_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR_PanelBusqueda.Tick
        If PanelBusquedaTexto.Height <= 5 Then
            Me.tmOCULTAR_PanelBusqueda.Enabled = False
        Else
            Me.PanelBusquedaTexto.Height = PanelBusquedaTexto.Height - 5
        End If
    End Sub


    Private Sub RbContenidoPosicionUno_CheckedChanged(sender As Object, e As EventArgs) Handles RbContenidoPosicionUno.CheckedChanged
        If RbContenidoPosicionUno.Checked = True Then
            ContenidoPosicionUnoTextBox.Enabled = True
            ContenidoPosicionUnoTextBox.Focus()
        Else
            ContenidoPosicionUnoTextBox.Enabled = False
        End If
    End Sub

    Private Sub RbContenidoPosicionDos_CheckedChanged(sender As Object, e As EventArgs) Handles RbContenidoPosicionDos.CheckedChanged
        If RbContenidoPosicionDos.Checked = True Then
            ContenidoPosicionDosTextBox.Enabled = True
            ContenidoPosicionDosTextBox.Focus()
        Else
            ContenidoPosicionDosTextBox.Enabled = False
        End If
    End Sub
#Region "Marcas Posicion Uno"

    Private Sub BtnTD_Click(sender As Object, e As EventArgs) Handles BtnTD.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tabla_P1}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tabla_P1}}}")
        End If
    End Sub
    Private Sub BtnTD_Min_Click(sender As Object, e As EventArgs) Handles BtnTD_Min.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tabla_Min_P1}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tabla_Min_P1}}}")
        End If
    End Sub

    Private Sub BtnTablaCamelCaseDep_Click(sender As Object, e As EventArgs) Handles BtnTablaCamelCaseDep.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tbl-Camel-P1}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tbl-Camel-P1}}}")
        End If
    End Sub

    Private Sub BtnCTD_Click(sender As Object, e As EventArgs) Handles BtnCTD.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Campo_P1}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Campo_P1}}}")
        End If
    End Sub

    Private Sub BtnMayusculaAMinuscula_Dep_Click(sender As Object, e As EventArgs) Handles BtnMayusculaAMinuscula_Dep.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{A=>-a P1}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{A=>-a P1}}}")
        End If
    End Sub

    Private Sub BtnImprimeMascaraPosUno_Click(sender As Object, e As EventArgs) Handles BtnImprimeMascaraPosUno.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "CamMasc")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "CamMasc")
        End If
    End Sub

#End Region

#Region "Marcas Posicion Dos"
    Private Sub BtnTI_Click(sender As Object, e As EventArgs) Handles BtnTI.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tabla_P2}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tabla_P2}}}")
        End If
    End Sub

    Private Sub BtnTI_Min_Click(sender As Object, e As EventArgs) Handles BtnTI_Min.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tabla_Min_P2}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tabla_Min_P2}}}")
        End If
    End Sub

    Private Sub BtnCamelCaseInd_Click(sender As Object, e As EventArgs) Handles BtnCamelCaseInd.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Tbl-Camel-P2}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Tbl-Camel-P2}}}")
        End If
    End Sub

    Private Sub BtnCTI_Click(sender As Object, e As EventArgs) Handles BtnCTI.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{Campo_P2}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{Campo_P2}}}")
        End If
    End Sub

    Private Sub BtnMayusculaAMinuscula_Indep_Click(sender As Object, e As EventArgs) Handles BtnMayusculaAMinuscula_Indep.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "{{{A=>-a P2}}}")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "{{{A=>-a P2}}}")
        End If
    End Sub

    Private Sub BtnImprimeMascaraPosDos_Click(sender As Object, e As EventArgs) Handles BtnImprimeMascaraPosDos.Click
        If RbContenidoPosicionUno.Checked = True Then
            Me.ContenidoPosicionUnoTextBox.Text = Me.ContenidoPosicionUnoTextBox.Text.Insert(Me.ContenidoPosicionUnoTextBox.SelectionStart, "CamMasc")
        End If
        If RbContenidoPosicionDos.Checked = True Then
            Me.ContenidoPosicionDosTextBox.Text = Me.ContenidoPosicionDosTextBox.Text.Insert(Me.ContenidoPosicionDosTextBox.SelectionStart, "CamMasc")
        End If
    End Sub
#End Region


#End Region

#Region "Busqueda"
    Private Sub BtnBuscarYPintar_Click(sender As Object, e As EventArgs) Handles BtnBuscarYPintar.Click
        If TxtBuscado.Text <> "" Then
            Try
                If BtnArchivoUno.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodUnoTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodUnoTextBox.Find(TxtBuscado.Text, index, CodUnoTextBox.TextLength, RichTextBoxFinds.None)
                        CodUnoTextBox.SelectionBackColor = Color.Yellow
                        index = CodUnoTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try

            Try
                If BtnArchivoDos.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodDosTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodDosTextBox.Find(TxtBuscado.Text, index, CodDosTextBox.TextLength, RichTextBoxFinds.None)
                        CodDosTextBox.SelectionBackColor = Color.Yellow
                        index = CodDosTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try

            Try
                If BtnArchivoTres.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodTresTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodTresTextBox.Find(TxtBuscado.Text, index, CodTresTextBox.TextLength, RichTextBoxFinds.None)
                        CodTresTextBox.SelectionBackColor = Color.Yellow
                        index = CodTresTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try

            Try
                If BtnArchivoCuatro.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodCuatroTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodCuatroTextBox.Find(TxtBuscado.Text, index, CodCuatroTextBox.TextLength, RichTextBoxFinds.None)
                        CodCuatroTextBox.SelectionBackColor = Color.Yellow
                        index = CodCuatroTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try

            Try
                If BtnArchivoCinco.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodCincoTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodCincoTextBox.Find(TxtBuscado.Text, index, CodCincoTextBox.TextLength, RichTextBoxFinds.None)
                        CodCincoTextBox.SelectionBackColor = Color.Yellow
                        index = CodCincoTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try

            Try
                If BtnArchivoSeis.BackColor = Color.Green Then
                    Dim index As Integer = 0
                    While index < CodSeisTextBox.Text.LastIndexOf(TxtBuscado.Text)
                        CodSeisTextBox.Find(TxtBuscado.Text, index, CodSeisTextBox.TextLength, RichTextBoxFinds.None)
                        CodSeisTextBox.SelectionBackColor = Color.Yellow
                        index = CodSeisTextBox.Text.IndexOf(TxtBuscado.Text, index) + 1
                    End While
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub BtnRemplazar_Click(sender As Object, e As EventArgs) Handles BtnRemplazar.Click
        If BtnArchivoUno.BackColor = Color.Green Then
            CodUnoTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodUnoTextBox.Text)
        End If
        If BtnArchivoDos.BackColor = Color.Green Then
            CodDosTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodDosTextBox.Text)
        End If
        If BtnArchivoTres.BackColor = Color.Green Then
            CodTresTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodTresTextBox.Text)
        End If
        If BtnArchivoCuatro.BackColor = Color.Green Then
            CodCuatroTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodCuatroTextBox.Text)
        End If
        If BtnArchivoCinco.BackColor = Color.Green Then
            CodCincoTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodCincoTextBox.Text)
        End If
        If BtnArchivoSeis.BackColor = Color.Green Then
            CodSeisTextBox.Text = RemplazarTexto(TxtBuscado.Text, TxtRemplazarPor.Text, CodSeisTextBox.Text)
        End If
    End Sub
    Shared Function RemplazarTexto(TextoBuscado As String, TextoParaRemplazo As String, TextoBase As String) As String
        Dim resultado As String
        TextoParaRemplazo = TextoParaRemplazo.Replace(" "c, String.Empty)
        resultado = TextoBase.Replace(TextoBuscado, TextoParaRemplazo)
        Return resultado
    End Function
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtBuscado.Text = ""
        TxtBuscado.Focus()
    End Sub



#End Region

#Region "Relaciones entre Tablas"
    Private Sub BtnGruposYTiposDatos_Click(sender As Object, e As EventArgs) Handles BtnGruposYTiposDatos.Click
        If BtnGruposYTiposDatos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelGruposTiposDatos.BringToFront()
            PanelGruposTiposDatos.BackColor = Color.Gainsboro
            PanelGruposTiposDatos.Dock = DockStyle.Fill
            BtnGruposYTiposDatos.BackColor = Color.Green
        Else
            PanelGruposTiposDatos.SendToBack()
            PanelGruposTiposDatos.Dock = DockStyle.None
            BtnGruposYTiposDatos.BackColor = Color.Transparent
            PanelGruposTiposDatos.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnCampos_Click(sender As Object, e As EventArgs) Handles BtnCampos.Click
        If BtnCampos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelCampos.BringToFront()
            PanelCampos.BackColor = Color.Gainsboro
            PanelCampos.Dock = DockStyle.Fill
            BtnCampos.BackColor = Color.Green
        Else
            PanelCampos.SendToBack()
            PanelCampos.Dock = DockStyle.None
            BtnCampos.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnRelacionesEntreTablas_Click(sender As Object, e As EventArgs) Handles BtnRelacionesEntreTablas.Click
        If BtnRelacionesEntreTablas.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelRelacionesEntreTablas.BringToFront()
            PanelRelacionesEntreTablas.BackColor = Color.Gainsboro
            PanelRelacionesEntreTablas.Dock = DockStyle.Fill
            BtnRelacionesEntreTablas.BackColor = Color.Green
        Else
            PanelRelacionesEntreTablas.SendToBack()
            PanelRelacionesEntreTablas.Dock = DockStyle.None
            BtnRelacionesEntreTablas.BackColor = Color.Transparent
            PanelRelacionesEntreTablas.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnRequerimientos_Click(sender As Object, e As EventArgs) Handles BtnRequerimientos.Click
        If BtnRequerimientos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelRequerimientos.BringToFront()
            PanelRequerimientos.BackColor = Color.Gainsboro
            PanelRequerimientos.Dock = DockStyle.Fill
            BtnRequerimientos.BackColor = Color.Green
        Else
            PanelRequerimientos.SendToBack()
            PanelRequerimientos.Dock = DockStyle.None
            BtnRequerimientos.BackColor = Color.Transparent
            PanelRequerimientos.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnTrabajoConTablas_Click(sender As Object, e As EventArgs) Handles BtnTrabajoConTablas.Click
        If BtnTrabajoConTablas.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelTablas.BringToFront()
            PanelTablas.BackColor = Color.Gainsboro
            PanelTablas.Dock = DockStyle.Fill
            BtnTrabajoConTablas.BackColor = Color.Green
        Else
            PanelTablas.SendToBack()
            PanelTablas.Dock = DockStyle.None
            BtnTrabajoConTablas.BackColor = Color.Transparent
            PanelTablas.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub BtnCamposEspeciales_Click(sender As Object, e As EventArgs) Handles BtnCamposEspeciales.Click
        If BtnCamposEspeciales.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelCampEspeciales.BringToFront()
            PanelCampEspeciales.BackColor = Color.Gainsboro
            PanelCampEspeciales.Dock = DockStyle.Fill
            BtnCamposEspeciales.BackColor = Color.Green
        Else
            PanelCampEspeciales.SendToBack()
            PanelCampEspeciales.Dock = DockStyle.None
            BtnCamposEspeciales.BackColor = Color.Transparent
            PanelCampEspeciales.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnGenerarArchivos_Click(sender As Object, e As EventArgs) Handles BtnGenerarArchivos.Click
        If BtnGenerarArchivos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelGenerarArchivos.BringToFront()
            PanelGenerarArchivos.BackColor = Color.Gainsboro
            PanelGenerarArchivos.Dock = DockStyle.Fill
            BtnGenerarArchivos.BackColor = Color.Green
        Else
            PanelGenerarArchivos.SendToBack()
            PanelGenerarArchivos.Dock = DockStyle.None
            BtnGenerarArchivos.BackColor = Color.Transparent
            PanelGenerarArchivos.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnMetricas_Click(sender As Object, e As EventArgs) Handles BtnMetricas.Click
        If BtnMetricas.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelMetricas.BringToFront()
            PanelMetricas.BackColor = Color.Gainsboro
            PanelMetricas.Dock = DockStyle.Fill
            BtnMetricas.BackColor = Color.Green
        Else
            PanelMetricas.SendToBack()
            PanelMetricas.Dock = DockStyle.None
            BtnMetricas.BackColor = Color.Transparent
            PanelMetricas.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnDocumentacion_Click(sender As Object, e As EventArgs) Handles BtnDocumentacion.Click
        If BtnDocumentacion.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelDocumentacion.BringToFront()
            PanelDocumentacion.BackColor = Color.Gainsboro
            PanelDocumentacion.Dock = DockStyle.Fill
            BtnDocumentacion.BackColor = Color.Green
        Else
            PanelDocumentacion.SendToBack()
            PanelDocumentacion.Dock = DockStyle.None
            BtnDocumentacion.BackColor = Color.Transparent
            PanelDocumentacion.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnAnki_Click(sender As Object, e As EventArgs) Handles BtnAnki.Click
        If BtnAnki.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelAnki.BringToFront()
            PanelAnki.BackColor = Color.Gainsboro
            PanelAnki.Dock = DockStyle.Fill
            BtnAnki.BackColor = Color.Green
        Else
            PanelAnki.SendToBack()
            PanelAnki.Dock = DockStyle.None
            BtnAnki.BackColor = Color.Transparent
            PanelAnki.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub BtnBackupBaseDeDatos_Click(sender As Object, e As EventArgs) Handles BtnBackupBaseDeDatos.Click
        If BtnBackupBaseDeDatos.BackColor = Color.Transparent Then
            LimpiarColorBotones()
            PanelBackup.BringToFront()
            PanelBackup.BackColor = Color.Gainsboro
            PanelBackup.Dock = DockStyle.Fill
            BtnBackupBaseDeDatos.BackColor = Color.Green
        Else
            PanelBackup.SendToBack()
            PanelBackup.Dock = DockStyle.None
            BtnBackupBaseDeDatos.BackColor = Color.Transparent
            PanelBackup.BackColor = Color.Transparent
        End If
    End Sub
#End Region

#Region "TODO PleBBakup"

    '--==============================================================--

    '--=== CANCELACIÓN 

    Sub Cancelar_PleBBakup()
        'Botones Del Menu
        Nuevo_Menu_PleBBakup.Enabled = True
        Guardar_Menu_PleBBakup.Enabled = False
        Editar_Menu_PleBBakup.Enabled = True
        Actualizar_Menu_PleBBakup.Enabled = False
        Eliminar_Menu_PleBBakup.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        PleBBakupDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.PleBBakupTableAdapter.Fill(Me.DataSetMaestros.PleBBakup)
        Bloquear_Objetos_PleBBakup()
        Parar_Timer_PleBBakup()
        Timer_Ubicar_En_Fila_PleBBakup()
    End Sub

    '--=== INSERTAR 

    'Insertar PleBBakup
    Private Sub SP_PleBBakup_EDICION_INSERTAR(ReferenciaBackup As String,
Fecha As DateTime,
RutaUbicacionBackup As String
)
        Fecha = Now
        Try
            Me.SP_PleBBakup_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleBBakup_EDICION_INSERTAR,
                                                            ReferenciaBackup,
                                                            New System.Nullable(Of Date)(CType(Fecha, Date)),
                                                            RutaUbicacionBackup
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleBBakup")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ACTUALIZAR 

    'Actualizar PleBBakup
    Private Sub SP_PleBBakup_EDICION_ACTUALIZAR(PleBakupId As Integer,
ReferenciaBackup As String,
Fecha As DateTime,
RutaUbicacionBackup As String
)

        Try
            Me.SP_PleBBakup_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleBBakup_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleBakupId, Integer)),
                                                            ReferenciaBackup,
                                                            New System.Nullable(Of Date)(CType(Fecha, Date)),
                                                            RutaUbicacionBackup
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleBBakup")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleBBakup_EDICION_ELIMINAR(PleBakupId As Integer)
        Try
            Me.SP_PleBBakup_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleBBakup_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleBakupId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleBBakup Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleBBakup()
        ReferenciaBackupTextBox.Enabled = False
        FechaDateTimePicker.Enabled = False
        RutaUbicacionBackupTextBox.Enabled = False
        BtnCargarRutaBackup.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleBBakup()
        ReferenciaBackupTextBox.Enabled = True
        'FechaDateTimePicker.Enabled = True
        RutaUbicacionBackupTextBox.Enabled = True
        BtnCargarRutaBackup.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleBBakup()
        ReferenciaBackupTextBox.Text = ""
        FechaDateTimePicker.Text = ""
        RutaUbicacionBackupTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleBBakup()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ReferenciaBackupTextBox.Text = ""
                MsgBox("El nombre del campo: Referencia del backup; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ReferenciaBackupTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case RutaUbicacionBackupTextBox.Text = ""
                MsgBox("El nombre del campo: Ruta de la ubicacion; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                RutaUbicacionBackupTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleBBakup.Click
        Nuevo_Menu_PleBBakup.Enabled = False
        Editar_Menu_PleBBakup.Enabled = False
        ValidarCierre.Text = 1
        PleBBakupDataGridView.Enabled = False
        BtnCargarRutaBackup.Enabled = True
        Limpiar_Objetos_PleBBakup()
        ReferenciaBackupTextBox.Enabled = True
        ReferenciaBackupTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleBBakup.Click
        Control_Nulos_PleBBakup()
        If ControlNulos.Text = "" Then
            SP_PleBBakup_EDICION_INSERTAR(ReferenciaBackupTextBox.Text,
        FechaDateTimePicker.Text,
        RutaUbicacionBackupTextBox.Text + "\"
)
            Cancelar_PleBBakup()
            Parar_Timer_PleBBakup()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleBBakup.Click
        Nuevo_Menu_PleBBakup.Enabled = False
        Guardar_Menu_PleBBakup.Enabled = False
        Editar_Menu_PleBBakup.Enabled = False
        Actualizar_Menu_PleBBakup.Enabled = True
        Eliminar_Menu_PleBBakup.Enabled = True
        PleBBakupDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleBBakup()
        Timer_Actualizar_PleBBakup()
        Timer_Eliminar_PleBBakup()
    End Sub

    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleBBakup.Click
        Control_Nulos_PleBBakup()

        If ControlNulos.Text = "" Then
            SP_PleBBakup_EDICION_ACTUALIZAR(PleBakupIdTextBox.Text,
        ReferenciaBackupTextBox.Text,
        FechaDateTimePicker.Text,
        RutaUbicacionBackupTextBox.Text
)
            Cancelar_PleBBakup()
            Parar_Timer_PleBBakup()
        End If
    End Sub

    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleBBakup.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleBBakup_EDICION_ELIMINAR(PleBakupIdTextBox.Text)
            Cancelar_PleBBakup()
            Parar_Timer_PleBBakup()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleBBakup()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleBBakup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleBBakup.Click
        Cancelar_PleBBakup()
    End Sub
    Private Sub BtnCargarRutaBackup_Click(sender As Object, e As EventArgs) Handles BtnCargarRutaBackup.Click
        If FolderBrowserDialog2.ShowDialog = DialogResult.OK Then
            RutaUbicacionBackupTextBox.Text = FolderBrowserDialog2.SelectedPath
        End If
    End Sub

    Private Sub BtnEjecutarBackup_Click(sender As Object, e As EventArgs) Handles BtnEjecutarBackup.Click
        SP_GENERA_BACKUP(RutaUbicacionBackupTextBox.Text, ReferenciaBackupTextBox.Text)
        SP_PleBBakup_EDICION_INSERTAR(ReferenciaBackupTextBox.Text, FechaDateTimePicker.Text, RutaUbicacionBackupTextBox.Text)
        Metodo_Aviso_Acciones(2, "Backup Generado Existosamente")
    End Sub

    Private Sub SP_GENERA_BACKUP(Ruta As String, Archivo As String)
        Try
            Me.SP_GENERA_BACKUPTableAdapter.Fill(Me.DataSetMaestros.SP_GENERA_BACKUP, Ruta, Archivo)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    '--=== NAVEGACIÓN


    Private Sub ReferenciaBackupTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReferenciaBackupTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ReferenciaBackupTextBox.Text = "" Then
                MsgBox("Se asignara un valor a la referencia por defecto", MsgBoxStyle.Exclamation, "Ple")
                Dim sGUID As String
                sGUID = System.Guid.NewGuid.ToString
                ReferenciaBackupTextBox.Text = "Backup" & "-" & sGUID
            Else
                RutaUbicacionBackupTextBox.Enabled = True
                RutaUbicacionBackupTextBox.Focus()
            End If
        End If
    End Sub

    Private Sub RutaUbicacionBackupTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RutaUbicacionBackupTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleBBakup.Enabled = True Then
                Actualizar_Menu_PleBBakup.Enabled = True
                Eliminar_Menu_PleBBakup.Enabled = True
            Else
                If RutaUbicacionBackupTextBox.Text = "" Then
                    MsgBox("El Dato: Ruta de la ubicacion es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    RutaUbicacionBackupTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleBBakup.Enabled = True
                    Timer_Guardar_PleBBakup()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES



    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleBBakup As Timer
    Private WithEvents Timer_Actualizar_Menu_PleBBakup As Timer
    Private WithEvents Timer_Eliminar_Menu_PleBBakup As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleBBakup()
        Me.Timer_Guardar_Menu_PleBBakup = New Timer
        Timer_Guardar_Menu_PleBBakup.Interval = 250
        Timer_Guardar_Menu_PleBBakup.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleBBakup()
        Me.Timer_Actualizar_Menu_PleBBakup = New Timer
        Timer_Actualizar_Menu_PleBBakup.Interval = 500
        Timer_Actualizar_Menu_PleBBakup.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleBBakup()
        Me.Timer_Eliminar_Menu_PleBBakup = New Timer
        Timer_Eliminar_Menu_PleBBakup.Interval = 800
        Timer_Eliminar_Menu_PleBBakup.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleBBakup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleBBakup.Tick
        If Guardar_Menu_PleBBakup.BackColor = Color.White Then
            Guardar_Menu_PleBBakup.BackColor = Color.Green
        Else
            Guardar_Menu_PleBBakup.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleBBakup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleBBakup.Tick
        If Actualizar_Menu_PleBBakup.BackColor = Color.White Then
            Actualizar_Menu_PleBBakup.BackColor = Color.Green
        Else
            Actualizar_Menu_PleBBakup.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleBBakup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleBBakup.Tick
        If Eliminar_Menu_PleBBakup.BackColor = Color.White Then
            Eliminar_Menu_PleBBakup.BackColor = Color.Red
        Else
            Eliminar_Menu_PleBBakup.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleBBakup()
        Me.Timer_Guardar_Menu_PleBBakup = New Timer
        Timer_Guardar_Menu_PleBBakup.Stop()
        Guardar_Menu_PleBBakup.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleBBakup = New Timer
        Timer_Actualizar_Menu_PleBBakup.Stop()
        Actualizar_Menu_PleBBakup.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleBBakup = New Timer
        Timer_Eliminar_Menu_PleBBakup.Stop()
        Eliminar_Menu_PleBBakup.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleBBakup As Timer
    Dim X_PleBBakup
    Private Sub Timer_Ubicar_En_Fila_PleBBakup()
        Me.Timer_Ubicacion_PleBBakup = New Timer
        Timer_Ubicacion_PleBBakup.Interval = 100
        Timer_Ubicacion_PleBBakup.Start()
    End Sub

    '--==============================================================--

    Private Sub PleBBakupDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles PleBBakupDataGridView.CellMouseClick
        X_PleBBakup = PleBBakupDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleBBakup()
        Try
            Me.PleBBakupDataGridView.Rows(X_PleBBakup).Selected = True
            Me.PleBBakupDataGridView.FirstDisplayedScrollingRowIndex = X_PleBBakup
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleBBakup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleBBakup.Tick
        Ubicar_En_Fila_PleBBakup()
        Timer_Ubicacion_PleBBakup.Stop()
    End Sub





#End Region

#End Region

#End Region

    'Crear formulario FrmPleDocumentacionComponente
    'Tipo de letra : Microsoft Tai Le; 12pt
    'Autoscroll : True
    'FormBorderStyle = None
    'Traer de utilidades los botones y validadores, copiarlos y pegarlos y poner los nombres
    'Nuevo_Menu_PleDocumentacionComponente
    'Guardar_Menu_PleDocumentacionComponente
    'Editar_Menu_PleDocumentacionComponente
    'Actualizar_Menu_PleDocumentacionComponente
    'Eliminar_Menu_PleDocumentacionComponente
    'Cancelar_Menu_PleDocumentacionComponente
    'Salir_Menu_PleDocumentacionComponente
    'ForeColor: 37; 46; 56
    'ControlBox: False

    'Grid con Anchor Top, Left, Right

    '--=== INICIO

#Region "TODO PleDocumentacionComponente"

    '--==============================================================--

    Private Sub SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteId As Integer)
        Try
            Me.SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdTableAdapter.Fill(Me.DataSetMaestros.SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId,
                                                                                                    New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


    '--=== CANCELACIÓN 

    Sub Cancelar_PleDocumentacionComponente()
        'Botones Del Menu
        Nuevo_Menu_PleDocumentacionComponente.Enabled = True
        Guardar_Menu_PleDocumentacionComponente.Enabled = False
        Editar_Menu_PleDocumentacionComponente.Enabled = True
        Actualizar_Menu_PleDocumentacionComponente.Enabled = False
        Eliminar_Menu_PleDocumentacionComponente.Enabled = False
        ValidarCierre.Text = ""
        'Grid
        SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        If ComponenteIdTextBox.Text <> "" Then
            SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteId(ComponenteIdTextBox.Text)
        End If
        Bloquear_Objetos_PleDocumentacionComponente()
        Parar_Timer_PleDocumentacionComponente()
        Timer_Ubicar_En_Fila_PleDocumentacionComponente()
    End Sub

    '--=== INSERTAR 

    'Insertar PleDocumentacionComponente
    Private Sub SP_PleDocumentacionComponente_EDICION_INSERTAR(ComponenteId As Integer,
ByVal ImagenComponente As Byte(),
ReferenciaDocComponente As String,
DescripcionDocComponente As String
)
        Try
            Me.SP_PleDocumentacionComponente_EDICION_INSERTARTableAdapter.Fill(Me.DataSetMaestros.SP_PleDocumentacionComponente_EDICION_INSERTAR,
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                            ImagenComponente,
                                                            ReferenciaDocComponente,
                                                            DescripcionDocComponente
)
            Metodo_Aviso_Acciones(3, "Registro Guardado Existosamente en la tabla PleDocumentacionComponente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    '--===  ACTUALIZAR 

    'Actualizar PleDocumentacionComponente
    Private Sub SP_PleDocumentacionComponente_EDICION_ACTUALIZAR(PleDocumentacionComponenteId As Integer,
ComponenteId As Integer,
ByVal ImagenComponente As Byte(),
ReferenciaDocComponente As String,
DescripcionDocComponente As String
)

        Try
            Me.SP_PleDocumentacionComponente_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetMaestros.SP_PleDocumentacionComponente_EDICION_ACTUALIZAR, New System.Nullable(Of Integer)(CType(PleDocumentacionComponenteId, Integer)),
                                                            New System.Nullable(Of Integer)(CType(ComponenteId, Integer)),
                                                            ImagenComponente,
                                                            ReferenciaDocComponente,
                                                            DescripcionDocComponente
)
            Metodo_Aviso_Acciones(3, "Registro Actualizado Existosamente en la tabla PleDocumentacionComponente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    '--===  ELIMINAR 

    'Eliminar
    Private Sub SP_PleDocumentacionComponente_EDICION_ELIMINAR(PleDocumentacionComponenteId As Integer)
        Try
            Me.SP_PleDocumentacionComponente_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetMaestros.SP_PleDocumentacionComponente_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(PleDocumentacionComponenteId, Integer)))
            Metodo_Aviso_Acciones(3, "Registro de la tabla PleDocumentacionComponente Eliminado Existosamente")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    '--=== TRATAMIENTO DE CAMPOS 

    Public Sub Bloquear_Objetos_PleDocumentacionComponente()
        ReferenciaDocComponenteRichTextBox.Enabled = False
        DescripcionDocComponenteRichTextBox.Enabled = False
        BtnCargarImagenPleDocumentacionComponente.Enabled = False
    End Sub

    Public Sub Desbloquear_Objetos_PleDocumentacionComponente()
        ReferenciaDocComponenteRichTextBox.Enabled = True
        DescripcionDocComponenteRichTextBox.Enabled = True
        BtnCargarImagenPleDocumentacionComponente.Enabled = True
    End Sub

    Public Sub Limpiar_Objetos_PleDocumentacionComponente()
        ReferenciaDocComponenteRichTextBox.Text = ""
        DescripcionDocComponenteRichTextBox.Text = ""
    End Sub

    '--===  CONTROL DE NULOS 

    'Control de Nulos
    Public Sub Control_Nulos_PleDocumentacionComponente()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case ComponenteIdTextBox.Text = ""
                MsgBox("No se ha creado un componente para asignarle esta documentación; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ComponenteIdTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case ImagenPictureBoxPleDocumentacionComponente.Image Is Nothing
                MsgBox("No existe una imagen para guardar, favor cargarla abriendo el cuadro de dialogo desde el boton cargar imágen", MsgBoxStyle.Critical)
                ControlNulos.Text = "1"
            Case ReferenciaDocComponenteRichTextBox.Text = ""
                MsgBox("El nombre del campo: Referencia Documento Componente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                ReferenciaDocComponenteRichTextBox.BackColor = Color.White
                ControlNulos.Text = "1"
            Case DescripcionDocComponenteRichTextBox.Text = ""
                MsgBox("El nombre del campo: Descripcion Documentacion Componente; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                DescripcionDocComponenteRichTextBox.BackColor = Color.White
                ControlNulos.Text = "1"

            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub

    '--===  BOTONES  DE EJECUCIÓN

    '--=== NUEVO  
    Private Sub Nuevo_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_PleDocumentacionComponente.Click
        Nuevo_Menu_PleDocumentacionComponente.Enabled = False
        Editar_Menu_PleDocumentacionComponente.Enabled = False
        ValidarCierre.Text = 1
        BtnCargarImagenPleDocumentacionComponente.Enabled = True
        SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        Limpiar_Objetos_PleDocumentacionComponente()
        ReferenciaDocComponenteRichTextBox.Enabled = True
        ReferenciaDocComponenteRichTextBox.Focus()
    End Sub

    '--=== GUARDAR  

    'Guardar
    Private Sub Guardar_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_PleDocumentacionComponente.Click
        Control_Nulos_PleDocumentacionComponente()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBoxPleDocumentacionComponente.Image
            SP_PleDocumentacionComponente_EDICION_INSERTAR(ComponenteIdTextBox.Text,
        (ImagenToBytesPleDocumentacionComponente(myImg)),
        ReferenciaDocComponenteRichTextBox.Text,
        DescripcionDocComponenteRichTextBox.Text
)
            Cancelar_PleDocumentacionComponente()
            Parar_Timer_PleDocumentacionComponente()
        End If
    End Sub

    '--=== EDITAR

    'Editar
    Private Sub Editar_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_PleDocumentacionComponente.Click
        Nuevo_Menu_PleDocumentacionComponente.Enabled = False
        Guardar_Menu_PleDocumentacionComponente.Enabled = False
        Editar_Menu_PleDocumentacionComponente.Enabled = False
        Actualizar_Menu_PleDocumentacionComponente.Enabled = True
        Eliminar_Menu_PleDocumentacionComponente.Enabled = True
        SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Enabled = False
        ValidarCierre.Text = 1
        Desbloquear_Objetos_PleDocumentacionComponente()
        Timer_Actualizar_PleDocumentacionComponente()
        Timer_Eliminar_PleDocumentacionComponente()
    End Sub


    '--=== ACTUALIZAR

    'Actualizar
    Private Sub Actualizar_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_PleDocumentacionComponente.Click
        Control_Nulos_PleDocumentacionComponente()

        If ControlNulos.Text = "" Then
            Dim myImg As Image
            myImg = ImagenPictureBoxPleDocumentacionComponente.Image
            SP_PleDocumentacionComponente_EDICION_ACTUALIZAR(PleDocumentacionComponenteIdTextBox.Text,
        ComponenteIdTextBox.Text,
        (ImagenToBytesPleDocumentacionComponente(myImg)),
        ReferenciaDocComponenteRichTextBox.Text,
        DescripcionDocComponenteRichTextBox.Text
)
            Cancelar_PleDocumentacionComponente()
            Parar_Timer_PleDocumentacionComponente()
        End If
    End Sub


    '--=== ELIMINAR

    Private Sub Eliminar_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_PleDocumentacionComponente.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_PleDocumentacionComponente_EDICION_ELIMINAR(PleDocumentacionComponenteIdTextBox.Text)
            Cancelar_PleDocumentacionComponente()
            Parar_Timer_PleDocumentacionComponente()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_PleDocumentacionComponente()
        End If
    End Sub

    '--=== CANCELAR

    'Cancelar
    Private Sub Cancelar_Menu_PleDocumentacionComponente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_PleDocumentacionComponente.Click
        Cancelar_PleDocumentacionComponente()
    End Sub


    '--=== NAVEGACIÓN

    Private Sub ReferenciaDocComponenteRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ReferenciaDocComponenteRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If ReferenciaDocComponenteRichTextBox.Text = "" Then
                MsgBox("El Dato: Referencia Documento Componente es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                ReferenciaDocComponenteRichTextBox.Focus()
            Else
                DescripcionDocComponenteRichTextBox.Enabled = True
                DescripcionDocComponenteRichTextBox.Focus()
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

    Private Sub DescripcionDocComponenteRichTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DescripcionDocComponenteRichTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_PleDocumentacionComponente.Enabled = True Then
                Actualizar_Menu_PleDocumentacionComponente.Enabled = True
                Eliminar_Menu_PleDocumentacionComponente.Enabled = True
            Else
                If DescripcionDocComponenteRichTextBox.Text = "" Then
                    MsgBox("El Dato: Descripcion Documentacion Componente es Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    DescripcionDocComponenteRichTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada, el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_PleDocumentacionComponente.Enabled = True
                    Timer_Guardar_PleDocumentacionComponente()
                End If
            End If
        End If
    End Sub


    '--=== ESPECIALES





    '--=== ESPECIALES

    'Conversion de imagen PleDocumentacionComponente
    Public Function ImagenToBytesPleDocumentacionComponente(ByVal Imagen As Image) As Byte()
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
    ' Agregar un Picturebox y darle por nombre ImagenPictureBoxPleDocumentacionComponente
    'Agregar un boton y darle por nombre BtnCargarImagenPleDocumentacionComponente
    Dim IMAGENpledocumentacioncomponente As String
    Dim OpenFileDialogPleDocumentacionComponente As New OpenFileDialog
    Private Sub BtnCargarImagenPleDocumentacionComponente_Click(sender As Object, e As EventArgs) Handles BtnCargarImagenPleDocumentacionComponente.Click
        ImagenPictureBoxPleDocumentacionComponente.Image = Nothing
        Try
            Me.OpenFileDialogPleDocumentacionComponente.ShowDialog()
            If Me.OpenFileDialogPleDocumentacionComponente.FileName <> "" Then
                IMAGENpledocumentacioncomponente = OpenFileDialogPleDocumentacionComponente.FileName
                Dim largo As Integer = IMAGENpledocumentacioncomponente.Length
                Dim imagen2 As String
                imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGENpledocumentacioncomponente), largo - 2, largo))
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
                    imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(IMAGENpledocumentacioncomponente), largo - 3, largo))
                    If imagen2 <> "jpeg" And imagen2 <> "JPEG" And imagen2 <> "log1" Then
                        MsgBox("Formato de imagen no valido") : Exit Sub
                        If imagen2 <> "log1" Then Exit Sub
                    End If
                End If
            End If
            ImagenPictureBoxPleDocumentacionComponente.Load(IMAGENpledocumentacioncomponente)
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
    '      2- En su propiedad imagenLayout ponerla en Stretch
    'Visualizar imagen normal
    Private Sub RbNormalpledocumentacioncomponente_CheckedChanged(sender As Object, e As EventArgs) Handles RbNormalpledocumentacioncomponente.CheckedChanged
        ImagenPictureBoxPleDocumentacionComponente.SizeMode = PictureBoxSizeMode.Normal
    End Sub
    'Visualizar Ajustado al picturebox
    Private Sub RbAjustadopledocumentacioncomponente_CheckedChanged(sender As Object, e As EventArgs) Handles RbAjustadopledocumentacioncomponente.CheckedChanged
        ImagenPictureBoxPleDocumentacionComponente.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
    'Visualizar Imagen original centrada
    Private Sub RbCentradapledocumentacioncomponente_CheckedChanged(sender As Object, e As EventArgs) Handles RbCentradapledocumentacioncomponente.CheckedChanged
        ImagenPictureBoxPleDocumentacionComponente.SizeMode = PictureBoxSizeMode.CenterImage
    End Sub
    'Visualizar imagen en el picture box con zoom
    Private Sub RbZoompledocumentacioncomponente_CheckedChanged(sender As Object, e As EventArgs) Handles RbZoompledocumentacioncomponente.CheckedChanged
        ImagenPictureBoxPleDocumentacionComponente.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
    '--=== TIMER DE BOTONES 
#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_PleDocumentacionComponente As Timer
    Private WithEvents Timer_Actualizar_Menu_PleDocumentacionComponente As Timer
    Private WithEvents Timer_Eliminar_Menu_PleDocumentacionComponente As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_PleDocumentacionComponente()
        Me.Timer_Guardar_Menu_PleDocumentacionComponente = New Timer
        Timer_Guardar_Menu_PleDocumentacionComponente.Interval = 250
        Timer_Guardar_Menu_PleDocumentacionComponente.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_PleDocumentacionComponente()
        Me.Timer_Actualizar_Menu_PleDocumentacionComponente = New Timer
        Timer_Actualizar_Menu_PleDocumentacionComponente.Interval = 500
        Timer_Actualizar_Menu_PleDocumentacionComponente.Start()
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_PleDocumentacionComponente()
        Me.Timer_Eliminar_Menu_PleDocumentacionComponente = New Timer
        Timer_Eliminar_Menu_PleDocumentacionComponente.Interval = 800
        Timer_Eliminar_Menu_PleDocumentacionComponente.Start()
    End Sub

    '--==============================================================--

    'Eventos Tick
    Private Sub Timer_Guardar_Menu_PleDocumentacionComponente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_PleDocumentacionComponente.Tick
        If Guardar_Menu_PleDocumentacionComponente.BackColor = Color.White Then
            Guardar_Menu_PleDocumentacionComponente.BackColor = Color.Green
        Else
            Guardar_Menu_PleDocumentacionComponente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Actualizar_Menu_PleDocumentacionComponente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_PleDocumentacionComponente.Tick
        If Actualizar_Menu_PleDocumentacionComponente.BackColor = Color.White Then
            Actualizar_Menu_PleDocumentacionComponente.BackColor = Color.Green
        Else
            Actualizar_Menu_PleDocumentacionComponente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    Private Sub Timer_Eliminar_Menu_PleDocumentacionComponente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_PleDocumentacionComponente.Tick
        If Eliminar_Menu_PleDocumentacionComponente.BackColor = Color.White Then
            Eliminar_Menu_PleDocumentacionComponente.BackColor = Color.Red
        Else
            Eliminar_Menu_PleDocumentacionComponente.BackColor = Color.White
        End If
    End Sub

    '--==============================================================--

    'Parar Timer
    Private Sub Parar_Timer_PleDocumentacionComponente()
        Me.Timer_Guardar_Menu_PleDocumentacionComponente = New Timer
        Timer_Guardar_Menu_PleDocumentacionComponente.Stop()
        Guardar_Menu_PleDocumentacionComponente.BackColor = Color.White
        Me.Timer_Actualizar_Menu_PleDocumentacionComponente = New Timer
        Timer_Actualizar_Menu_PleDocumentacionComponente.Stop()
        Actualizar_Menu_PleDocumentacionComponente.BackColor = Color.White
        Me.Timer_Eliminar_Menu_PleDocumentacionComponente = New Timer
        Timer_Eliminar_Menu_PleDocumentacionComponente.Stop()
        Eliminar_Menu_PleDocumentacionComponente.BackColor = Color.White
    End Sub

    '--==============================================================--

#Region "Ubicación de Fila"

    Private WithEvents Timer_Ubicacion_PleDocumentacionComponente As Timer
    Dim X_PleDocumentacionComponente
    Private Sub Timer_Ubicar_En_Fila_PleDocumentacionComponente()
        Me.Timer_Ubicacion_PleDocumentacionComponente = New Timer
        Timer_Ubicacion_PleDocumentacionComponente.Interval = 100
        Timer_Ubicacion_PleDocumentacionComponente.Start()
    End Sub

    '--==============================================================--

    Private Sub PleDocumentacionComponenteDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CellMouseClick
        X_PleDocumentacionComponente = SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.CurrentRow.Index
    End Sub

    '--==============================================================--

    Private Sub Ubicar_En_Fila_PleDocumentacionComponente()
        Try
            Me.SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.Rows(X_PleDocumentacionComponente).Selected = True
            Me.SP_PleDocumentacionComponente_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIdDataGridView.FirstDisplayedScrollingRowIndex = X_PleDocumentacionComponente
        Catch ex As Exception
        End Try
    End Sub

    '--==============================================================--

    Private Sub Timer_Ubicacion_PleDocumentacionComponente_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_PleDocumentacionComponente.Tick
        Ubicar_En_Fila_PleDocumentacionComponente()
        Timer_Ubicacion_PleDocumentacionComponente.Stop()
    End Sub



#End Region

#End Region

#End Region



End Class