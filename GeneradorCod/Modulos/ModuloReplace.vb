Imports System.IO
Imports System.Text
Module ModuloReplace
    Public Sub GeneraRepositorio(ByVal ubicacionGeneral As String)
        My.Computer.FileSystem.CreateDirectory(ubicacionGeneral)
    End Sub

    Public Sub GenerarYRemplazar(ByVal Ruta As String, ByVal Archivo As String, ByVal Contenido As String)
        Dim path As String = Ruta + "\" + Archivo
        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)
        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Contenido)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Sub

End Module
