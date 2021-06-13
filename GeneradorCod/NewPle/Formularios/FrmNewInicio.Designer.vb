<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewInicio))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnTipoDocumento = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnEmpresa = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnTecnologias = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btnDashBoard = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.tmOCULTAR = New System.Windows.Forms.Timer(Me.components)
        Me.tmMOSTRAR = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1354, 11)
        Me.PanelBarraTitulo.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel7)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.PictureBox5)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.BtnTipoDocumento)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.BtnEmpresa)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.BtnClientes)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.BtnTecnologias)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btnProductos)
        Me.PanelMenu.Controls.Add(Me.Panel10)
        Me.PanelMenu.Controls.Add(Me.btnDashBoard)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 11)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 724)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(54, 65)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 2
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(176, 5)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.GeneradorCod.My.Resources.Resources.logo
        Me.PictureBox5.Location = New System.Drawing.Point(6, 65)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(46, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 401)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 11
        '
        'BtnTipoDocumento
        '
        Me.BtnTipoDocumento.FlatAppearance.BorderSize = 0
        Me.BtnTipoDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnTipoDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnTipoDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTipoDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTipoDocumento.ForeColor = System.Drawing.Color.White
        Me.BtnTipoDocumento.Image = Global.GeneradorCod.My.Resources.Resources.System_Security_Card_icon
        Me.BtnTipoDocumento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTipoDocumento.Location = New System.Drawing.Point(0, 401)
        Me.BtnTipoDocumento.Name = "BtnTipoDocumento"
        Me.BtnTipoDocumento.Size = New System.Drawing.Size(220, 50)
        Me.BtnTipoDocumento.TabIndex = 10
        Me.BtnTipoDocumento.Text = "  Tipos de Documento"
        Me.BtnTipoDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTipoDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTipoDocumento.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 345)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 9
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.FlatAppearance.BorderSize = 0
        Me.BtnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.ForeColor = System.Drawing.Color.White
        Me.BtnEmpresa.Image = Global.GeneradorCod.My.Resources.Resources.university_icon
        Me.BtnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpresa.Location = New System.Drawing.Point(3, 345)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(220, 50)
        Me.BtnEmpresa.TabIndex = 8
        Me.BtnEmpresa.Text = "  Empresa"
        Me.BtnEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmpresa.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 7
        '
        'BtnClientes
        '
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(0, 289)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(220, 50)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "  Clientes"
        Me.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 5
        '
        'BtnTecnologias
        '
        Me.BtnTecnologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTecnologias.FlatAppearance.BorderSize = 0
        Me.BtnTecnologias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.BtnTecnologias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.BtnTecnologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTecnologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTecnologias.ForeColor = System.Drawing.Color.White
        Me.BtnTecnologias.Image = Global.GeneradorCod.My.Resources.Resources.technology_icon3
        Me.BtnTecnologias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTecnologias.Location = New System.Drawing.Point(2, 233)
        Me.BtnTecnologias.Name = "BtnTecnologias"
        Me.BtnTecnologias.Size = New System.Drawing.Size(220, 50)
        Me.BtnTecnologias.TabIndex = 4
        Me.BtnTecnologias.Text = "  Tecnologias"
        Me.BtnTecnologias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTecnologias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnTecnologias.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 3
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"), System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(0, 177)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(220, 50)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "  Generacion"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnProductos, "Generacion de proyectos")
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.Panel10.Location = New System.Drawing.Point(0, 121)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 50)
        Me.Panel10.TabIndex = 1
        '
        'btnDashBoard
        '
        Me.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashBoard.FlatAppearance.BorderSize = 0
        Me.btnDashBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(21, Byte), Integer))
        Me.btnDashBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashBoard.ForeColor = System.Drawing.Color.White
        Me.btnDashBoard.Image = CType(resources.GetObject("btnDashBoard.Image"), System.Drawing.Image)
        Me.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashBoard.Location = New System.Drawing.Point(0, 121)
        Me.btnDashBoard.Name = "btnDashBoard"
        Me.btnDashBoard.Size = New System.Drawing.Size(220, 50)
        Me.btnDashBoard.TabIndex = 0
        Me.btnDashBoard.Text = "     Configuracion"
        Me.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnDashBoard, "Configuracion de plantillas")
        Me.btnDashBoard.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.AutoScroll = True
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.Control
        Me.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(220, 11)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1134, 724)
        Me.PanelContenedor.TabIndex = 2
        '
        'tmOCULTAR
        '
        Me.tmOCULTAR.Interval = 15
        '
        'tmMOSTRAR
        '
        Me.tmMOSTRAR.Interval = 15
        '
        'FrmNewInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 735)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmNewInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBarraTitulo As System.Windows.Forms.Panel
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents PanelContenedor As System.Windows.Forms.Panel
    Friend WithEvents btnDashBoard As System.Windows.Forms.Button
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnTecnologias As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnTipoDocumento As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents BtnEmpresa As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnClientes As System.Windows.Forms.Button
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents tmOCULTAR As System.Windows.Forms.Timer
    Friend WithEvents tmMOSTRAR As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ToolTip1 As ToolTip
End Class
