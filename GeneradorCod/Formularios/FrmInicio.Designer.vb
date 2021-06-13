<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciònToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaciònDePlantillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EdicionCamposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GeneraciònDeProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelecciónDeArchivosParaIntegracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GeneraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 450)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciònToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 29)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciònToolStripMenuItem
        '
        Me.AdministraciònToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreaciònDePlantillasToolStripMenuItem, Me.ToolStripSeparator1, Me.GeneraciònDeProyectosToolStripMenuItem, Me.ToolStripSeparator2, Me.GeneraciónToolStripMenuItem, Me.ToolStripSeparator5, Me.ConfiguraciónToolStripMenuItem, Me.ToolStripSeparator3, Me.ReportesToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.AdministraciònToolStripMenuItem.Name = "AdministraciònToolStripMenuItem"
        Me.AdministraciònToolStripMenuItem.Size = New System.Drawing.Size(127, 25)
        Me.AdministraciònToolStripMenuItem.Text = "Administraciòn"
        '
        'CreaciònDePlantillasToolStripMenuItem
        '
        Me.CreaciònDePlantillasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionToolStripMenuItem, Me.ToolStripSeparator6, Me.EdicionCamposToolStripMenuItem})
        Me.CreaciònDePlantillasToolStripMenuItem.Name = "CreaciònDePlantillasToolStripMenuItem"
        Me.CreaciònDePlantillasToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.CreaciònDePlantillasToolStripMenuItem.Text = "Creaciòn de Plantillas"
        '
        'CreacionToolStripMenuItem
        '
        Me.CreacionToolStripMenuItem.Name = "CreacionToolStripMenuItem"
        Me.CreacionToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.CreacionToolStripMenuItem.Text = "Creacion"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(188, 6)
        '
        'EdicionCamposToolStripMenuItem
        '
        Me.EdicionCamposToolStripMenuItem.Name = "EdicionCamposToolStripMenuItem"
        Me.EdicionCamposToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.EdicionCamposToolStripMenuItem.Text = "Edicion Campos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(249, 6)
        '
        'GeneraciònDeProyectosToolStripMenuItem
        '
        Me.GeneraciònDeProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneraciónToolStripMenuItem1, Me.SelecciónDeArchivosParaIntegracionToolStripMenuItem})
        Me.GeneraciònDeProyectosToolStripMenuItem.Name = "GeneraciònDeProyectosToolStripMenuItem"
        Me.GeneraciònDeProyectosToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.GeneraciònDeProyectosToolStripMenuItem.Text = "Generaciòn de Proyectos"
        '
        'GeneraciónToolStripMenuItem1
        '
        Me.GeneraciónToolStripMenuItem1.Name = "GeneraciónToolStripMenuItem1"
        Me.GeneraciónToolStripMenuItem1.Size = New System.Drawing.Size(346, 26)
        Me.GeneraciónToolStripMenuItem1.Text = "Generación"
        '
        'SelecciónDeArchivosParaIntegracionToolStripMenuItem
        '
        Me.SelecciónDeArchivosParaIntegracionToolStripMenuItem.Name = "SelecciónDeArchivosParaIntegracionToolStripMenuItem"
        Me.SelecciónDeArchivosParaIntegracionToolStripMenuItem.Size = New System.Drawing.Size(346, 26)
        Me.SelecciónDeArchivosParaIntegracionToolStripMenuItem.Text = "Selección de Archivos Para Integracion"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(249, 6)
        '
        'GeneraciónToolStripMenuItem
        '
        Me.GeneraciónToolStripMenuItem.Name = "GeneraciónToolStripMenuItem"
        Me.GeneraciónToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.GeneraciónToolStripMenuItem.Text = "Configuraciones"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(249, 6)
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ConfiguraciónToolStripMenuItem.Text = "Tipos de Datos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(249, 6)
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(252, 26)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(249, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(252, 26)
        Me.ToolStripMenuItem1.Text = "Pruebas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(252, 26)
        Me.ToolStripMenuItem2.Text = "New Replace"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLE ~ Programing Easy And Listen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministraciònToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreaciònDePlantillasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GeneraciònDeProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents GeneraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents EdicionCamposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents GeneraciónToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelecciónDeArchivosParaIntegracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
