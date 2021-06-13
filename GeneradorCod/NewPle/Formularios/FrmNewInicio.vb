Imports System.Runtime.InteropServices
Public Class FrmNewInicio
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.FixedSingle
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()

    End Sub

    Private Sub tmOCULTAR_Tick(sender As Object, e As EventArgs) Handles tmOCULTAR.Tick
        If PanelMenu.Width <= 60 Then
            Me.tmOCULTAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 5
        End If
    End Sub

    Private Sub tmMOSTRAR_Tick(sender As Object, e As EventArgs) Handles tmMOSTRAR.Tick
        If PanelMenu.Width >= 220 Then
            Me.tmMOSTRAR.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 5
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            tmOCULTAR.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            tmMOSTRAR.Enabled = True
        End If
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirFormEnPanel(New FrmNewReplace)
    End Sub
    Private Sub btnDashBoard_Click(sender As Object, e As EventArgs) Handles btnDashBoard.Click
        AbrirFormEnPanel(New FrmPlantillasTecnologiasYComponentes)
    End Sub
    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormEnPanel(New FrmPleCliente)
    End Sub
    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        AbrirFormEnPanel(New FrmPleEmpresa)
    End Sub
    Private Sub BtnTipoDocumento_Click(sender As Object, e As EventArgs) Handles BtnTipoDocumento.Click
        AbrirFormEnPanel(New FrmPleTiposDocumentos)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    'Private Sub btnMaximizar_Click(sender As Object, e As EventArgs)
    '    btnMaximizar.Visible = False
    '    btnRestaurar.Visible = True
    '    Me.WindowState = FormWindowState.Maximized

    'End Sub
    'Private Sub btnRestaurar_Click(sender As Object, e As EventArgs)
    '    Me.WindowState = FormWindowState.Normal
    '    btnRestaurar.Visible = False
    '    btnMaximizar.Visible = True
    'End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub




    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        BtnTipoDocumento.PerformClick()
    End Sub

    Private Sub FrmNewInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmOCULTAR.Enabled = True
    End Sub


End Class
