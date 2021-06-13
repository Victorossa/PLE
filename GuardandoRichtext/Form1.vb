Imports System.Data.SqlClient
Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub BtnFuente_Click(sender As Object, e As EventArgs) Handles BtnFuente.Click
        Dim f As New FontDialog
        f.ShowDialog()
        Me.TextoEnriquezidoRichTextBox.SelectionFont = f.Font
    End Sub
    Private Sub BtnIzquierda_Click(sender As Object, e As EventArgs) Handles BtnIzquierda.Click
        Me.TextoEnriquezidoRichTextBox.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub BtnCentro_Click(sender As Object, e As EventArgs) Handles BtnCentro.Click
        Me.TextoEnriquezidoRichTextBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub BtnDerecha_Click(sender As Object, e As EventArgs) Handles BtnDerecha.Click
        Me.TextoEnriquezidoRichTextBox.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub BtnColor_Click(sender As Object, e As EventArgs) Handles BtnColor.Click
        Dim c As New ColorDialog
        c.ShowDialog()
        Me.TextoEnriquezidoRichTextBox.SelectionColor = c.Color
    End Sub
    Dim Datos As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim opfd As New OpenFileDialog
        If opfd.ShowDialog = DialogResult.OK Then
            TextoEnriquezidoRichTextBox.LoadFile(opfd.FileName)
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TextoEnriquezidoRichTextBox.Rtf = Datos
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSet1.tablaPrueba' Puede moverla o quitarla según sea necesario.
        Me.TablaPruebaTableAdapter.Fill(Me.DataSet1.tablaPrueba)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SP_tablaPrueba_EDICION_INSERTAR()
    End Sub

    Private Sub SP_tablaPrueba_EDICION_INSERTAR()
        Try

            Me.SP_tablaPrueba_EDICION_INSERTARTableAdapter.Fill(Me.DataSet1.SP_tablaPrueba_EDICION_INSERTAR, TextoEnriquezidoRichTextBox.Text)
            Me.TablaPruebaTableAdapter.Fill(Me.DataSet1.tablaPrueba)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
    Dim Buffer() As Byte
    Public Sub GuardarTextoEnriquezido()
        'Creamos un memoryStream al que guardar nuestro texto
        Dim MemContent As New System.IO.MemoryStream()
        TextoEnriquezidoRichTextBox.SaveFile(MemContent, RichTextBoxStreamType.RichText)
        'Creamos un array de bytes al que guardar la info de nuestro MemoryStream
        Dim Buffer(MemContent.Length) As Byte
        Buffer = MemContent.GetBuffer()
        Me.SP_tablaPrueba_EDICION_INSERTARTableAdapter.Fill(Me.DataSet1.SP_tablaPrueba_EDICION_INSERTAR, TextoEnriquezidoRichTextBox.Rtf)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            GuardarTextoEnriquezido()
            Me.TablaPruebaTableAdapter.Fill(Me.DataSet1.tablaPrueba)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnLeer_Click(sender As Object, e As EventArgs) Handles BtnLeer.Click
        Try
            TextoEnriquezidoRichTextBox.Rtf = TextoEnriquezidoRichTextBox.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IdTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdTextBox.TextChanged
        Try
            TextoEnriquezidoRichTextBox.Rtf = TextoEnriquezidoRichTextBox.Text
        Catch ex As Exception

        End Try

    End Sub
End Class


