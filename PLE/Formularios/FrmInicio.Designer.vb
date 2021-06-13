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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministraciònToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreaciònDePlantillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GeneraciònDeProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaestrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecnologiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlantillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvensionesRequerimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelacionesTablasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministraciònToolStripMenuItem, Me.MaestrosToolStripMenuItem, Me.ProyectosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 29)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministraciònToolStripMenuItem
        '
        Me.AdministraciònToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreaciònDePlantillasToolStripMenuItem, Me.ToolStripSeparator1, Me.GeneraciònDeProyectosToolStripMenuItem, Me.ToolStripSeparator2})
        Me.AdministraciònToolStripMenuItem.Name = "AdministraciònToolStripMenuItem"
        Me.AdministraciònToolStripMenuItem.Size = New System.Drawing.Size(127, 25)
        Me.AdministraciònToolStripMenuItem.Text = "Administración"
        '
        'CreaciònDePlantillasToolStripMenuItem
        '
        Me.CreaciònDePlantillasToolStripMenuItem.Name = "CreaciònDePlantillasToolStripMenuItem"
        Me.CreaciònDePlantillasToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.CreaciònDePlantillasToolStripMenuItem.Text = "Empresa"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(137, 6)
        '
        'GeneraciònDeProyectosToolStripMenuItem
        '
        Me.GeneraciònDeProyectosToolStripMenuItem.Name = "GeneraciònDeProyectosToolStripMenuItem"
        Me.GeneraciònDeProyectosToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.GeneraciònDeProyectosToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'MaestrosToolStripMenuItem
        '
        Me.MaestrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TecnologiasToolStripMenuItem, Me.PlantillasToolStripMenuItem, Me.TiposDeDatosToolStripMenuItem, Me.ConvensionesRequerimientosToolStripMenuItem, Me.PruebasToolStripMenuItem})
        Me.MaestrosToolStripMenuItem.Name = "MaestrosToolStripMenuItem"
        Me.MaestrosToolStripMenuItem.Size = New System.Drawing.Size(86, 25)
        Me.MaestrosToolStripMenuItem.Text = "Maestros"
        '
        'TecnologiasToolStripMenuItem
        '
        Me.TecnologiasToolStripMenuItem.Name = "TecnologiasToolStripMenuItem"
        Me.TecnologiasToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.TecnologiasToolStripMenuItem.Text = "Tecnologias"
        '
        'PlantillasToolStripMenuItem
        '
        Me.PlantillasToolStripMenuItem.Name = "PlantillasToolStripMenuItem"
        Me.PlantillasToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.PlantillasToolStripMenuItem.Text = "Plantillas"
        '
        'TiposDeDatosToolStripMenuItem
        '
        Me.TiposDeDatosToolStripMenuItem.Name = "TiposDeDatosToolStripMenuItem"
        Me.TiposDeDatosToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.TiposDeDatosToolStripMenuItem.Text = "Tipos de Datos"
        '
        'ConvensionesRequerimientosToolStripMenuItem
        '
        Me.ConvensionesRequerimientosToolStripMenuItem.Name = "ConvensionesRequerimientosToolStripMenuItem"
        Me.ConvensionesRequerimientosToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.ConvensionesRequerimientosToolStripMenuItem.Text = "Convensiones Requerimientos"
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(291, 26)
        Me.PruebasToolStripMenuItem.Text = "Pruebas"
        '
        'ProyectosToolStripMenuItem
        '
        Me.ProyectosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreacionToolStripMenuItem, Me.RelacionesTablasToolStripMenuItem})
        Me.ProyectosToolStripMenuItem.Name = "ProyectosToolStripMenuItem"
        Me.ProyectosToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.ProyectosToolStripMenuItem.Text = "Proyectos"
        '
        'CreacionToolStripMenuItem
        '
        Me.CreacionToolStripMenuItem.Name = "CreacionToolStripMenuItem"
        Me.CreacionToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.CreacionToolStripMenuItem.Text = "Creacion"
        '
        'RelacionesTablasToolStripMenuItem
        '
        Me.RelacionesTablasToolStripMenuItem.Name = "RelacionesTablasToolStripMenuItem"
        Me.RelacionesTablasToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.RelacionesTablasToolStripMenuItem.Text = "Relaciones Tablas"
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 563)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PLE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministraciònToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreaciònDePlantillasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GeneraciònDeProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents MaestrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TecnologiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlantillasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConvensionesRequerimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProyectosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelacionesTablasToolStripMenuItem As ToolStripMenuItem
End Class
