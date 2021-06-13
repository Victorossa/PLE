Public Class FrmConfiguracion


#Region "Procedimientos"
    Sub Cancelar_Tipos()
        'Botones Del Menu
        Nuevo_Menu_Tipos.Enabled = True
        Guardar_Menu_Tipos.Enabled = False
        Editar_Menu_Tipos.Enabled = True
        Actualizar_Menu_Tipos.Enabled = False
        Eliminar_Menu_Tipos.Enabled = False
        'Grid
        TiposDataGridView.Enabled = True
        'Cargar Datos de Tabla Actualizados
        Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
        Bloquear_Objetos_Tipos()
        Parar_Timer_Tipos()
        Timer_Ubicar_En_Fila_Tipos()
    End Sub
    'Insertar
    Private Sub SP_Tipos_EDICION_INSERTAR()
        Try
            Me.SP_Tipos_EDICION_INSERTARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tipos_EDICION_INSERTAR,
                                                 TipoTextBox.Text)
            Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
            MsgBox("El Dato Fue Guardado Exitosamente", MsgBoxStyle.Information, "Guardar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Actualizar
    Private Sub SP_Tipos_EDICION_ACTUALIZAR()
        Try
            Me.SP_Tipos_EDICION_ACTUALIZARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tipos_EDICION_ACTUALIZAR,
                                                 New System.Nullable(Of Integer)(CType(TipoIDTextBox.Text, Integer)),
                                                 TipoTextBox.Text)
            SP_ActualizaValoresDeTipos(TipoTextBox.Text, ValorActual.Text)
            Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
            MsgBox("El Dato Fue Actualizado Exitosamente", MsgBoxStyle.Information, "Actualizar Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Eliminar
    Private Sub SP_Tipos_EDICION_ELIMINAR()
        Try
            Me.SP_Tipos_EDICION_ELIMINARTableAdapter.Fill(Me.DataSetAdministracion.SP_Tipos_EDICION_ELIMINAR, New System.Nullable(Of Long)(CType(TipoIDTextBox.Text, Long)))
            Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
            MsgBox("El Dato Fue Eliminado Exitosamente de la Base de Datos", MsgBoxStyle.Information, "Eliminación de Dato")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
    End Sub
#End Region
#Region "Menus"
    'Nuevo 
    Private Sub Nuevo_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo_Menu_Tipos.Click
        Nuevo_Menu_Tipos.Enabled = False
        Editar_Menu_Tipos.Enabled = False
        TiposDataGridView.Enabled = False
        Limpiar_Objetos_Tipos()
        TipoTextBox.Enabled = True
        TipoTextBox.Focus()
    End Sub
    'Guardar
    Private Sub Guardar_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar_Menu_Tipos.Click
        Control_Nulos_Tipos()
        If ControlNulos.Text = "" Then ' Then
            SP_Tipos_EDICION_INSERTAR()
            Cancelar_Tipos()
            Parar_Timer_Tipos()
        End If
    End Sub
    'Editar
    Private Sub Editar_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Editar_Menu_Tipos.Click
        Nuevo_Menu_Tipos.Enabled = False
        Guardar_Menu_Tipos.Enabled = False
        Editar_Menu_Tipos.Enabled = False
        Actualizar_Menu_Tipos.Enabled = True
        Eliminar_Menu_Tipos.Enabled = True
        TiposDataGridView.Enabled = False
        Desbloquear_Objetos_Tipos()
        Timer_Actualizar_Tipos()
        Timer_Eliminar_Tipos()
    End Sub
    'Actualizar
    Private Sub Actualizar_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualizar_Menu_Tipos.Click
        Control_Nulos_Tipos()
        If ControlNulos.Text = "" Then ' Then
            SP_Tipos_EDICION_ACTUALIZAR()
            Cancelar_Tipos()
            Parar_Timer_Tipos()
        End If
    End Sub
    Private Sub Eliminar_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Eliminar_Menu_Tipos.Click
        If MsgBox("Desea Eliminar Este Dato?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            SP_Tipos_EDICION_ELIMINAR()
            Cancelar_Tipos()
            Parar_Timer_Tipos()
        Else
            MsgBox("Se Cancelo la Eliminación del Dato", MsgBoxStyle.Information)
            Cancelar_Tipos()
        End If
    End Sub
    'Cancelar
    Private Sub Cancelar_Menu_Tipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar_Menu_Tipos.Click
        Cancelar_Tipos()
    End Sub
    'Load de Formulario
    Private Sub FrmConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.TiposTableAdapter.Fill(Me.DataSetAdministracion.Tipos)
            Cancelar_Tipos()
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

#Region "Eventos sobre Objetos "
    'Control de Nulos
    Public Sub Control_Nulos_Tipos()
        ControlNulos.Text = "" '
        Select Case ControlNulos.Text = "" '
            Case TipoTextBox.Text = ""
                MsgBox("El nombre del campo: Tipo; Esta vacio, Favor Verificar", MsgBoxStyle.Critical)
                TipoTextBox.BackColor = Color.Beige
                ControlNulos.Text = "1"
            Case Else
                ControlNulos.Text = "" '
        End Select
    End Sub
    Private Sub TipoTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TipoTextBox.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Actualizar_Menu_Tipos.Enabled = True Then
                Actualizar_Menu_Tipos.Enabled = True
                Eliminar_Menu_Tipos.Enabled = True
            Else
                If TipoTextBox.Text = "" Then
                    MsgBox("Dato Obligatorio, Favor Verificar", MsgBoxStyle.Critical, "Validación de Datos")
                    TipoTextBox.Text = ""
                    TipoTextBox.Focus()
                Else
                    MsgBox("La Información Ya puede ser Guardada el Icono de Guardado queda habilitado", MsgBoxStyle.Information, "Guardar los Datos")
                    Guardar_Menu_Tipos.Enabled = True
                    Timer_Guardar_Tipos()
                End If
            End If
        End If
    End Sub
    Public Sub Limpiar_Objetos_Tipos()
        TipoTextBox.Text = "" ''
    End Sub
    Public Sub Desbloquear_Objetos_Tipos()
        TipoTextBox.Enabled = True
    End Sub
    Public Sub Bloquear_Objetos_Tipos()
        TipoTextBox.Enabled = False
    End Sub
#End Region

#Region "Timer de Botones"
    'Declaraciones de Timers de Botones
    Private WithEvents Timer_Guardar_Menu_Tipos As Timer
    Private WithEvents Timer_Actualizar_Menu_Tipos As Timer
    Private WithEvents Timer_Eliminar_Menu_Tipos As Timer
    'Procedimientos del Timer
    Private Sub Timer_Guardar_Tipos()
        Me.Timer_Guardar_Menu_Tipos = New Timer
        Timer_Guardar_Menu_Tipos.Interval = 250
        Timer_Guardar_Menu_Tipos.Start()
    End Sub
    Private Sub Timer_Actualizar_Tipos()
        Me.Timer_Actualizar_Menu_Tipos = New Timer
        Timer_Actualizar_Menu_Tipos.Interval = 500
        Timer_Actualizar_Menu_Tipos.Start()
    End Sub
    Private Sub Timer_Eliminar_Tipos()
        Me.Timer_Eliminar_Menu_Tipos = New Timer
        Timer_Eliminar_Menu_Tipos.Interval = 800
        Timer_Eliminar_Menu_Tipos.Start()
    End Sub
    'Eventos Tick
    Private Sub Timer_Guardar_Menu_Tipos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Guardar_Menu_Tipos.Tick
        If Guardar_Menu_Tipos.BackColor = Color.White Then
            Guardar_Menu_Tipos.BackColor = Color.Green
        Else
            Guardar_Menu_Tipos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Actualizar_Menu_Tipos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Actualizar_Menu_Tipos.Tick
        If Actualizar_Menu_Tipos.BackColor = Color.White Then
            Actualizar_Menu_Tipos.BackColor = Color.Green
        Else
            Actualizar_Menu_Tipos.BackColor = Color.White
        End If
    End Sub
    Private Sub Timer_Eliminar_Menu_Tipos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Eliminar_Menu_Tipos.Tick
        If Eliminar_Menu_Tipos.BackColor = Color.White Then
            Eliminar_Menu_Tipos.BackColor = Color.Red
        Else
            Eliminar_Menu_Tipos.BackColor = Color.White
        End If
    End Sub
    'Parar Timer
    Private Sub Parar_Timer_Tipos()
        Me.Timer_Guardar_Menu_Tipos = New Timer
        Timer_Guardar_Menu_Tipos.Stop()
        Guardar_Menu_Tipos.BackColor = Color.White
        Me.Timer_Actualizar_Menu_Tipos = New Timer
        Timer_Actualizar_Menu_Tipos.Stop()
        Actualizar_Menu_Tipos.BackColor = Color.White
        Me.Timer_Eliminar_Menu_Tipos = New Timer
        Timer_Eliminar_Menu_Tipos.Stop()
        Eliminar_Menu_Tipos.BackColor = Color.White
    End Sub
#End Region
#Region "Ubicación de Fila"
    Private WithEvents Timer_Ubicacion_Tipos As Timer
    Dim X_Tipos
    Private Sub Timer_Ubicar_En_Fila_Tipos()
        Me.Timer_Ubicacion_Tipos = New Timer
        Timer_Ubicacion_Tipos.Interval = 100
        Timer_Ubicacion_Tipos.Start()
    End Sub
    Private Sub TiposDataGridView_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TiposDataGridView.CellMouseClick
        X_Tipos = TiposDataGridView.CurrentRow.Index
    End Sub
    Private Sub Ubicar_En_Fila_Tipos()
        Try
            Me.TiposDataGridView.Rows(X_Tipos).Selected = True
            Me.TiposDataGridView.FirstDisplayedScrollingRowIndex = X_Tipos
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer_Ubicacion_Tipos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer_Ubicacion_Tipos.Tick
        Ubicar_En_Fila_Tipos()
        Timer_Ubicacion_Tipos.Stop()
    End Sub

    Private Sub SP_ActualizaValoresDeTipos(ValorNuevo As String, ValorActual As String)
        Try
            Me.SP_ActualizaValoresDeTiposTableAdapter.Fill(Me.DataSetAdministracion.SP_ActualizaValoresDeTipos, ValorNuevo, ValorActual)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region





End Class