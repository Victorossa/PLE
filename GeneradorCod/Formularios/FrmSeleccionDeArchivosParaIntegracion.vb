Public Class FrmSeleccionDeArchivosParaIntegracion
    Private Sub SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKE()
        Try
            Me.SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKETableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKE, TxtBusquedaArchivosRuta.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKE()
        Try
            Me.SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKETableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKE, TxtBusquedaArchivosRuta.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TxtBusquedaArchivosRuta_TextChanged(sender As Object, e As EventArgs) Handles TxtBusquedaArchivosRuta.TextChanged
        If RbPorArchivo.Checked = True Then
            SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKE()
        End If
        If RbBusquedaRuta.Checked = True Then
            SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKE()
        End If
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKEDataGridView.CellContentClick
        Dim seleccionada As Boolean
        If e.ColumnIndex = 0 Then
            If Convert.ToBoolean(SP_ProyectoCarpetasArchivos_BUSQUEDA_ARCHIVO_SEGUN_PARAMETRO_LIKEDataGridView.Rows(e.RowIndex).Cells(0).EditedFormattedValue) = True Then
                seleccionada = True
                SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(ProyectoCarpetasArchivosIdARCHIVO.Text, seleccionada)
            Else
                seleccionada = False
                SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(ProyectoCarpetasArchivosIdARCHIVO.Text, seleccionada)
            End If
        End If
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKEDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKEDataGridView.CellContentClick
        Dim seleccionada As Boolean
        If e.ColumnIndex = 0 Then
            If Convert.ToBoolean(SP_ProyectoCarpetasArchivos_BUSQUEDA_RUTA_SEGUN_PARAMETRO_LIKEDataGridView.Rows(e.RowIndex).Cells(0).EditedFormattedValue) = True Then
                seleccionada = True
                SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(ProyectoCarpetasArchivosIdRUTA.Text, seleccionada)
            Else
                seleccionada = False
                SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(ProyectoCarpetasArchivosIdRUTA.Text, seleccionada)
            End If
        End If
    End Sub

    Private Sub SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA(ProyectoCarpetasArchivosId As Integer, SeleccionadaG As Boolean)
        Try
            Me.SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADATableAdapter.Fill(Me.DataSetAdministracion.SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADA,
                                                                                                 New System.Nullable(Of Integer)(CType(ProyectoCarpetasArchivosId, Integer)),
                                                                                                 New System.Nullable(Of Boolean)(CType(SeleccionadaG, Boolean)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class