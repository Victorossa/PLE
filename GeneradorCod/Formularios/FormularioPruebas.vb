Public Class FormularioPruebas
    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click
        Dim myText As TextBox = New TextBox()
        myText.Location = New Point(25, 250)
        myText.Multiline = True
        myText.Width = 600
        myText.Height = 200
        Me.Controls.Add(myText)
    End Sub
    Dim fso As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.CreateDirectory("C:\Users\victor.ossa\Desktop\ImagenesPLE")
    End Sub

    Private Sub PlantillasImagenesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlantillasImagenesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlantillasImagenesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetReportes)
    End Sub

    Private Sub FormularioPruebas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        My.Computer.FileSystem.CreateDirectory("C:\Users\victor.ossa\Desktop\ImagenesPLE")
        OpenFileDialog1.InitialDirectory = "C:\Users\victor.ossa\Desktop\ImagenesPLE"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ImagenPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ImagenIdTextBox_TextChanged(sender As Object, e As EventArgs) Handles ImagenIdTextBox.TextChanged
        ImagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub



    Private Sub SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID()
        Try
            Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetReportes.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
            Me.PlantillasImagenesTableAdapter.Fill(Me.DataSetReportes.PlantillasImagenes)
            Me.ReportViewer1.RefreshReport()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID()
    End Sub

    Private Sub Ejecutar_Click(sender As Object, e As EventArgs) Handles Ejecutar.Click
        'My.Computer.FileSystem.WriteAllText(RutaCarpeta.Text, ContenidoArchivo.Text, True)
        GenerarArchivo(RutaCarpeta.Text, ArchivoCreado.Text, ContenidoArchivo.Text)
    End Sub

    Private Sub GenerarArchivo(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String)

        My.Computer.FileSystem.WriteAllText(Ruta + "\" + Archivo, Contenido, True)

    End Sub
    'My.Computer.FileSystem.CreateDirectory("C:\Users\victor.ossa\Desktop\ImagenesPLE")

End Class