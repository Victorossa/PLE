Public Class FrmEdicionCampos


    Private Sub FrmEdicionCampos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DataSetAdministracion.Tecnologias' Puede moverla o quitarla según sea necesario.
        Me.TecnologiasTableAdapter.Fill(Me.DataSetAdministracion.Tecnologias)
        bloquear()
    End Sub

#Region "Mensajeria"
    'Mensajeria
    '--==================================================================--
    Public WithEvents Timer_Aviso As Timer
    Dim TiempoDuracionAviso As Integer = 0
    Dim TiempoPararAviso As Integer = 0
    Public Sub Metodo_Aviso_Acciones(TiempoDuracion As Integer, ByVal InformacionMensaje As String)
        Me.Timer_Aviso = New Timer
        Timer_Aviso.Interval = 1000
        Me.Timer_Aviso.Start()
        TiempoPararAviso = TiempoDuracion
        LblInforme.Visible = True
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
#End Region

    Private Sub SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia(TecnologiaIDTextBox As String)
        Try
            Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.Fill(Me.DataSetAdministracion.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia, New System.Nullable(Of Integer)(CType(TecnologiaIDTextBox, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TecnologiaIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles TecnologiaIDTextBox.TextChanged
        SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia(TecnologiaIDTextBox.Text)
    End Sub

    Private Sub SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaId As Integer)
        Try
            Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.Fill(Me.DataSetAdministracion.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID, New System.Nullable(Of Integer)(CType(PlantillaId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PlantillaIDTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PlantillaIDTextBox1.TextChanged
        SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaIDTextBox1.Text)
    End Sub

    Private Sub SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaID As Integer, ComponenteId As Integer)
        Try
            Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteID, New System.Nullable(Of Integer)(CType(PlantillaID, Integer)), New System.Nullable(Of Integer)(CType(ComponenteId, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComponenteIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ComponenteIDTextBox.TextChanged
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaIDTextBox.Text, ComponenteIDTextBox.Text)
    End Sub

    Private Sub SuperiorTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SuperiorTextBox.MouseDoubleClick
        SuperiorTextBox.Dock = DockStyle.Fill
        SuperiorTextBox.BringToFront()
    End Sub

    Private Sub PrefijoTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PrefijoTextBox.MouseDoubleClick
        PrefijoTextBox.Dock = DockStyle.Fill
        PrefijoTextBox.BringToFront()
    End Sub

    Private Sub SufijoTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SufijoTextBox.MouseDoubleClick
        SufijoTextBox.Dock = DockStyle.Fill
        SufijoTextBox.BringToFront()
    End Sub

    Private Sub InferiorTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles InferiorTextBox.MouseDoubleClick
        InferiorTextBox.Dock = DockStyle.Fill
        InferiorTextBox.BringToFront()
    End Sub

    Private Sub MultiReplaceTextBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MultiReplaceTextBox.MouseDoubleClick
        MultiReplaceTextBox.Dock = DockStyle.Fill
        MultiReplaceTextBox.BringToFront()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        SuperiorTextBox.Dock = DockStyle.None
        SuperiorTextBox.SendToBack()
        PrefijoTextBox.Dock = DockStyle.None
        PrefijoTextBox.BringToFront()
        SufijoTextBox.Dock = DockStyle.None
        SufijoTextBox.BringToFront()
        InferiorTextBox.Dock = DockStyle.None
        InferiorTextBox.BringToFront()
        MultiReplaceTextBox.Dock = DockStyle.None
        MultiReplaceTextBox.BringToFront()
    End Sub
    Private Sub BtnCarga_Click(sender As Object, e As EventArgs) Handles BtnCarga.Click
        SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaIDTextBox.Text, ComponenteIDTextBox.Text)
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        SP_CampoComponentes_EDICION_ACTUALIZAR()
    End Sub
    Private Sub BtnUpdateCer_Click(sender As Object, e As EventArgs) Handles BtnUpdateCer.Click
        SP_CampoComponentes_EDICION_ACTUALIZAR()
    End Sub

    Private Sub SP_CampoComponentes_EDICION_ACTUALIZAR()
        Try
            Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(CampoComponenteID.Text, Integer)),
                                                 New System.Nullable(Of Integer)(CType(PlantillaIDTextBox.Text, Integer)),
                                                 TipoTextBox.Text,
                                                 PrefijoTextBox.Text,
                                                 SuperiorTextBox.Text,
                                                 SufijoTextBox.Text,
                                                 InferiorTextBox.Text,
                                                 SeparadorCamposTextBox.Text,
                                                 MultiReplaceTextBox.Text,
                                                 ComponenteIDTextBox.Text,
                                                 FormatoCampoTextBox.Text)
            Aviso_Acciones(10, "Actualizado")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Aviso_Acciones(ByVal tiempo As Integer, ByVal aviso As String)
        Timer_Acciones.Start()
        TiempoPararAviso = tiempo
        LblInforme.Visible = True
        LblInforme.Text = aviso
    End Sub

    Private Sub Timer_Acciones_Tick(sender As Object, e As EventArgs) Handles Timer_Acciones.Tick
        TiempoDuracionAviso = TiempoDuracionAviso + 1
        If TiempoDuracionAviso = TiempoPararAviso Then
            Timer_Acciones.Stop()
            TiempoDuracionAviso = 0
            TiempoPararAviso = 0
            LblInforme.Text = "..."
            LblInforme.Visible = False
            LblInforme.BringToFront()
        End If
    End Sub

    Private Sub BtnImprimeCampo_Click(sender As Object, e As EventArgs) Handles BtnImprimeCampo.Click
        If RBSuperior.Checked = True Then
            Me.SuperiorTextBox.Text = Me.SuperiorTextBox.Text.Insert(Me.SuperiorTextBox.SelectionStart, "Campo")
        End If
        If RbInferior.Checked = True Then
            Me.InferiorTextBox.Text = Me.InferiorTextBox.Text.Insert(Me.InferiorTextBox.SelectionStart, "Campo")
        End If
        If RbSufijo.Checked = True Then
            Me.SufijoTextBox.Text = Me.SufijoTextBox.Text.Insert(Me.SufijoTextBox.SelectionStart, "Campo")
        End If
        If RbPrefijo.Checked = True Then
            Me.PrefijoTextBox.Text = Me.PrefijoTextBox.Text.Insert(Me.PrefijoTextBox.SelectionStart, "Campo")
        End If
        If RbMultiReplace.Checked = True Then
            Me.MultiReplaceTextBox.Text = Me.MultiReplaceTextBox.Text.Insert(Me.MultiReplaceTextBox.SelectionStart, "Campo")
        End If

    End Sub

    Private Sub BtnImprimeMascara_Click(sender As Object, e As EventArgs) Handles BtnImprimeMascara.Click
        If RBSuperior.Checked = True Then
            Me.SuperiorTextBox.Text = Me.SuperiorTextBox.Text.Insert(Me.SuperiorTextBox.SelectionStart, "CamMasc")
        End If
        If RbInferior.Checked = True Then
            Me.InferiorTextBox.Text = Me.InferiorTextBox.Text.Insert(Me.InferiorTextBox.SelectionStart, "CamMasc")
        End If
        If RbSufijo.Checked = True Then
            Me.SufijoTextBox.Text = Me.SufijoTextBox.Text.Insert(Me.SufijoTextBox.SelectionStart, "CamMasc")
        End If
        If RbPrefijo.Checked = True Then
            Me.PrefijoTextBox.Text = Me.PrefijoTextBox.Text.Insert(Me.PrefijoTextBox.SelectionStart, "CamMasc")
        End If
        If RbMultiReplace.Checked = True Then
            Me.MultiReplaceTextBox.Text = Me.MultiReplaceTextBox.Text.Insert(Me.MultiReplaceTextBox.SelectionStart, "CamMasc")
        End If
    End Sub

    Private Sub RBSuperior_CheckedChanged(sender As Object, e As EventArgs) Handles RBSuperior.CheckedChanged
        bloquear()
        SuperiorTextBox.Enabled = True
    End Sub

    Private Sub RbSufijo_CheckedChanged(sender As Object, e As EventArgs) Handles RbSufijo.CheckedChanged
        bloquear()
        SufijoTextBox.Enabled = True
    End Sub
    Private Sub RbMultiReplace_CheckedChanged(sender As Object, e As EventArgs) Handles RbMultiReplace.CheckedChanged
        bloquear()
        MultiReplaceTextBox.Enabled = True
    End Sub
    Private Sub RbPrefijo_CheckedChanged(sender As Object, e As EventArgs) Handles RbPrefijo.CheckedChanged
        bloquear()
        PrefijoTextBox.Enabled = True
    End Sub

    Private Sub RbInferior_CheckedChanged(sender As Object, e As EventArgs) Handles RbInferior.CheckedChanged
        bloquear()
        InferiorTextBox.Enabled = True
    End Sub

    Public Sub bloquear()
        SuperiorTextBox.Enabled = False
        InferiorTextBox.Enabled = False
        SufijoTextBox.Enabled = False
        PrefijoTextBox.Enabled = False
        MultiReplaceTextBox.Enabled = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        SP_CampoComponentes_EDICION_ELIMINAR()
    End Sub

    Private Sub SP_CampoComponentes_EDICION_ELIMINAR()
        If CampoComponenteID.Text <> "" Then
            Try
                Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetTablasYCampos.SP_CampoComponentes_EDICION_ELIMINAR, New System.Nullable(Of Integer)(CType(CampoComponenteID.Text, Integer)))
                SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID(PlantillaIDTextBox.Text, ComponenteIDTextBox.Text)
                Metodo_Aviso_Acciones(3, "Se elimino Campo")
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub
End Class