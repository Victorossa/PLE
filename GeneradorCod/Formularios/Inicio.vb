Public Class Inicio
    Private Sub TecnologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecnologiasToolStripMenuItem.Click
        FrmTecnologias.Show()
        FrmTecnologias.MdiParent = Me
    End Sub

    Private Sub GeneracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneracionToolStripMenuItem.Click
        FrmReplace.Show()
        FrmReplace.MdiParent = Me
    End Sub
End Class