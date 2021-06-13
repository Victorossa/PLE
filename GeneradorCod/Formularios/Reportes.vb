Public Class Reportes
    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReportViewer1.BringToFront()
        Me.ProyectosTableAdapter.Fill(Me.DataSetAdministracion.Proyectos)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub SP_Proyectos_SEGUN_ProyectoID()
        Try
            Me.SP_Proyectos_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetReportes.SP_Proyectos_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProyectoIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProyectoIDTextBox.TextChanged
        If RbEstimacion.Checked = True Then
            SP_Proyectos_SEGUN_ProyectoID()
            SP_TOTALIZA_TIEMPO_POR_PROYECTO()
            SP_TablasDeProyecto_Cant_Tablas_Proyecto()
            SP_Vista_Para_Metricas_Suma_False()
            SP_Vista_Para_Metricas_Suma_True()
            SP_View_ProyectosYTecnologias_TecnologiasAplicacadasXProy()
            SP_Vista_Ventajas_TecnologicasXProy_xProy()
            Me.ReportViewer1.RefreshReport()
        End If
        If RBDocumentoTecn.Checked = True Then
            SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID()
            Me.ReportViewer2.RefreshReport()
        End If
    End Sub

    Private Sub RbEstimacion_CheckedChanged(sender As Object, e As EventArgs) Handles RbEstimacion.CheckedChanged
        ReportViewer1.Visible = True
        ReportViewer2.Visible = False
    End Sub

    Private Sub RBDocumentoTecn_CheckedChanged(sender As Object, e As EventArgs) Handles RBDocumentoTecn.CheckedChanged
        ReportViewer1.Visible = False
        ReportViewer2.Visible = True
    End Sub

    Private Sub SP_TablasDeProyecto_Cant_Tablas_Proyecto()
        Try
            Me.SP_TablasDeProyecto_Cant_Tablas_ProyectoTableAdapter.Fill(Me.DataSetReportes.SP_TablasDeProyecto_Cant_Tablas_Proyecto, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_Vista_Para_Metricas_Suma_False()
        Try
            Me.SP_Vista_Para_Metricas_Suma_FalseTableAdapter.Fill(Me.DataSetReportes.SP_Vista_Para_Metricas_Suma_False, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_Vista_Para_Metricas_Suma_True()
        Try
            Me.SP_Vista_Para_Metricas_Suma_TrueTableAdapter.Fill(Me.DataSetReportes.SP_Vista_Para_Metricas_Suma_True, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SP_TOTALIZA_TIEMPO_POR_PROYECTO()
        Try
            Me.SP_TOTALIZA_TIEMPO_POR_PROYECTOTableAdapter.Fill(Me.DataSetReportes.SP_TOTALIZA_TIEMPO_POR_PROYECTO, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SP_View_ProyectosYTecnologias_TecnologiasAplicacadasXProy()
        Try
            Me.SP_View_ProyectosYTecnologias_TecnologiasAplicacadasXProyTableAdapter.Fill(Me.DataSetReportes.SP_View_ProyectosYTecnologias_TecnologiasAplicacadasXProy, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_Vista_Ventajas_TecnologicasXProy_xProy()
        Try
            Me.SP_Vista_Ventajas_TecnologicasXProy_xProyTableAdapter.Fill(Me.DataSetReportes.SP_Vista_Ventajas_TecnologicasXProy_xProy, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID()
        Try
            Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter.Fill(Me.DataSetReportes.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID, New System.Nullable(Of Integer)(CType(ProyectoIDTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class