Public Class FrmUtilidades
    Private Sub SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SP_Prueba_EDICION_ACTUALIZARBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetAdministracion)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Dim dato6(-1) As Byte
            Me.SP_Prueba_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Prueba_EDICION_ACTUALIZAR,
                                                             New System.Nullable(Of Boolean)(CType(Dato1ToolStripTextBox.Text, Boolean)),
                                                             New System.Nullable(Of Integer)(CType(Dato2ToolStripTextBox.Text, Integer)),
                                                             Dato3ToolStripTextBox.Text,
                                                             New System.Nullable(Of Integer)(CType(Dato4ToolStripTextBox.Text, Integer)),
                                                             New System.Nullable(Of Date)(CType(Dato5ToolStripTextBox.Text, Date)),
                                                             dato6,
                                                             New System.Nullable(Of Decimal)(CType(Dato7ToolStripTextBox.Text, Decimal)),
                                                             New System.Nullable(Of Long)(CType(Dato8ToolStripTextBox.Text, Long)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class