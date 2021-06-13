Public Class FrmInicio
    Private Sub TecnologiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TecnologiasToolStripMenuItem.Click
        FrmTecnologias.Show()
        FrmTecnologias.MdiParent = Me
        FrmTecnologias.BringToFront()
    End Sub
End Class