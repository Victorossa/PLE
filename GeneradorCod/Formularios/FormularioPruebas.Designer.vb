<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPruebas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ImagenIdLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim ReferenciaLabel As System.Windows.Forms.Label
        Dim ImagenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPruebas))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetReportes = New GeneradorCod.DataSetReportes()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlantillasImagenesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PlantillasImagenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlantillasImagenesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PlantillasImagenesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ImagenIdTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ReferenciaTextBox = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PlantillaIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PlantillaIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ReferenciaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ReferenciaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ProyectoIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ImagenPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ejecutar = New System.Windows.Forms.Button()
        Me.ContenidoArchivo = New System.Windows.Forms.TextBox()
        Me.ArchivoCreado = New System.Windows.Forms.TextBox()
        Me.RutaCarpeta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreCarpeta = New System.Windows.Forms.TextBox()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Salir_Menu_ = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_ = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_ = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_ = New System.Windows.Forms.Button()
        Me.Editar_Menu_ = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_ = New System.Windows.Forms.Button()
        Me.Guardar_Menu_ = New System.Windows.Forms.Button()
        Me.PlantillasImagenesTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.PlantillasImagenesTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetReportesTableAdapters.TableAdapterManager()
        Me.SP_PlantillasImagenes_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PlantillasImagenes_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_PlantillasImagenes_EDICION_INSERTARTableAdapter()
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter = New GeneradorCod.DataSetReportesTableAdapters.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.RbZoom = New System.Windows.Forms.RadioButton()
        Me.RbCentrada = New System.Windows.Forms.RadioButton()
        Me.RbAjustado = New System.Windows.Forms.RadioButton()
        Me.RbNormal = New System.Windows.Forms.RadioButton()
        ImagenIdLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        ReferenciaLabel = New System.Windows.Forms.Label()
        ImagenLabel = New System.Windows.Forms.Label()
        CType(Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantillasImagenesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlantillasImagenesBindingNavigator.SuspendLayout()
        CType(Me.PlantillasImagenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlantillasImagenesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.SP_PlantillasImagenes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImagenIdLabel
        '
        ImagenIdLabel.AutoSize = True
        ImagenIdLabel.Location = New System.Drawing.Point(324, 61)
        ImagenIdLabel.Name = "ImagenIdLabel"
        ImagenIdLabel.Size = New System.Drawing.Size(57, 13)
        ImagenIdLabel.TabIndex = 4
        ImagenIdLabel.Text = "Imagen Id:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(324, 87)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel.TabIndex = 6
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'ReferenciaLabel
        '
        ReferenciaLabel.AutoSize = True
        ReferenciaLabel.Location = New System.Drawing.Point(324, 113)
        ReferenciaLabel.Name = "ReferenciaLabel"
        ReferenciaLabel.Size = New System.Drawing.Size(62, 13)
        ReferenciaLabel.TabIndex = 8
        ReferenciaLabel.Text = "Referencia:"
        '
        'ImagenLabel
        '
        ImagenLabel.AutoSize = True
        ImagenLabel.Location = New System.Drawing.Point(341, 136)
        ImagenLabel.Name = "ImagenLabel"
        ImagenLabel.Size = New System.Drawing.Size(45, 13)
        ImagenLabel.TabIndex = 10
        ImagenLabel.Text = "Imagen:"
        '
        'SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource
        '
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource.DataMember = "SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoID"
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource.DataSource = Me.DataSetReportes
        '
        'DataSetReportes
        '
        Me.DataSetReportes.DataSetName = "DataSetReportes"
        Me.DataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(12, 12)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(109, 26)
        Me.BtnGenerar.TabIndex = 0
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Crear Carpeta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlantillasImagenesBindingNavigator
        '
        Me.PlantillasImagenesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlantillasImagenesBindingNavigator.BindingSource = Me.PlantillasImagenesBindingSource
        Me.PlantillasImagenesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlantillasImagenesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlantillasImagenesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlantillasImagenesBindingNavigatorSaveItem})
        Me.PlantillasImagenesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlantillasImagenesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlantillasImagenesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlantillasImagenesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlantillasImagenesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlantillasImagenesBindingNavigator.Name = "PlantillasImagenesBindingNavigator"
        Me.PlantillasImagenesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlantillasImagenesBindingNavigator.Size = New System.Drawing.Size(1074, 25)
        Me.PlantillasImagenesBindingNavigator.TabIndex = 2
        Me.PlantillasImagenesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'PlantillasImagenesBindingSource
        '
        Me.PlantillasImagenesBindingSource.DataMember = "PlantillasImagenes"
        Me.PlantillasImagenesBindingSource.DataSource = Me.DataSetReportes
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PlantillasImagenesBindingNavigatorSaveItem
        '
        Me.PlantillasImagenesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlantillasImagenesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlantillasImagenesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlantillasImagenesBindingNavigatorSaveItem.Name = "PlantillasImagenesBindingNavigatorSaveItem"
        Me.PlantillasImagenesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PlantillasImagenesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PlantillasImagenesDataGridView
        '
        Me.PlantillasImagenesDataGridView.AllowUserToAddRows = False
        Me.PlantillasImagenesDataGridView.AutoGenerateColumns = False
        Me.PlantillasImagenesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlantillasImagenesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewImageColumn1})
        Me.PlantillasImagenesDataGridView.DataSource = Me.PlantillasImagenesBindingSource
        Me.PlantillasImagenesDataGridView.Location = New System.Drawing.Point(12, 58)
        Me.PlantillasImagenesDataGridView.Name = "PlantillasImagenesDataGridView"
        Me.PlantillasImagenesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PlantillasImagenesDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ImagenId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ImagenId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PlantillaID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PlantillaID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Referencia"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Referencia"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "Imagen"
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ImagenIdTextBox
        '
        Me.ImagenIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlantillasImagenesBindingSource, "ImagenId", True))
        Me.ImagenIdTextBox.Location = New System.Drawing.Point(392, 58)
        Me.ImagenIdTextBox.Name = "ImagenIdTextBox"
        Me.ImagenIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ImagenIdTextBox.TabIndex = 5
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlantillasImagenesBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(392, 84)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PlantillaIDTextBox.TabIndex = 7
        '
        'ReferenciaTextBox
        '
        Me.ReferenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PlantillasImagenesBindingSource, "Referencia", True))
        Me.ReferenciaTextBox.Location = New System.Drawing.Point(392, 110)
        Me.ReferenciaTextBox.Name = "ReferenciaTextBox"
        Me.ReferenciaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReferenciaTextBox.TabIndex = 9
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PlantillasImagenesBindingSource, "Imagen", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(392, 136)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(169, 142)
        Me.ImagenPictureBox.TabIndex = 11
        Me.ImagenPictureBox.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(439, 284)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCargar.TabIndex = 12
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlantillaIDToolStripLabel, Me.PlantillaIDToolStripTextBox, Me.ReferenciaToolStripLabel, Me.ReferenciaToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(1074, 25)
        Me.FillToolStrip.TabIndex = 13
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'PlantillaIDToolStripLabel
        '
        Me.PlantillaIDToolStripLabel.Name = "PlantillaIDToolStripLabel"
        Me.PlantillaIDToolStripLabel.Size = New System.Drawing.Size(63, 22)
        Me.PlantillaIDToolStripLabel.Text = "PlantillaID:"
        '
        'PlantillaIDToolStripTextBox
        '
        Me.PlantillaIDToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlantillaIDToolStripTextBox.Name = "PlantillaIDToolStripTextBox"
        Me.PlantillaIDToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'ReferenciaToolStripLabel
        '
        Me.ReferenciaToolStripLabel.Name = "ReferenciaToolStripLabel"
        Me.ReferenciaToolStripLabel.Size = New System.Drawing.Size(65, 22)
        Me.ReferenciaToolStripLabel.Text = "Referencia:"
        '
        'ReferenciaToolStripTextBox
        '
        Me.ReferenciaToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReferenciaToolStripTextBox.Name = "ReferenciaToolStripTextBox"
        Me.ReferenciaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DS_DocTecnico"
        ReportDataSource1.Value = Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "GeneradorCod.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(580, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(474, 77)
        Me.ReportViewer1.TabIndex = 14
        '
        'SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView
        '
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn2})
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.DataSource = Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.Location = New System.Drawing.Point(12, 307)
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.Name = "SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView"
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProyectoDocTecnicoId"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProyectoDocTecnicoId"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ProyectoID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ProyectoID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.DataPropertyName = "Imagen"
        Me.DataGridViewImageColumn2.HeaderText = "Imagen"
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'ProyectoIDTextBox
        '
        Me.ProyectoIDTextBox.Location = New System.Drawing.Point(392, 328)
        Me.ProyectoIDTextBox.Name = "ProyectoIDTextBox"
        Me.ProyectoIDTextBox.Size = New System.Drawing.Size(90, 20)
        Me.ProyectoIDTextBox.TabIndex = 17
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(488, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ImagenPictureBox1
        '
        Me.ImagenPictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource, "Imagen", True))
        Me.ImagenPictureBox1.Location = New System.Drawing.Point(392, 378)
        Me.ImagenPictureBox1.Name = "ImagenPictureBox1"
        Me.ImagenPictureBox1.Size = New System.Drawing.Size(169, 149)
        Me.ImagenPictureBox1.TabIndex = 19
        Me.ImagenPictureBox1.TabStop = False
        '
        'Ejecutar
        '
        Me.Ejecutar.Location = New System.Drawing.Point(580, 236)
        Me.Ejecutar.Name = "Ejecutar"
        Me.Ejecutar.Size = New System.Drawing.Size(75, 23)
        Me.Ejecutar.TabIndex = 20
        Me.Ejecutar.Text = "Ejecutar"
        Me.Ejecutar.UseVisualStyleBackColor = True
        '
        'ContenidoArchivo
        '
        Me.ContenidoArchivo.Location = New System.Drawing.Point(580, 343)
        Me.ContenidoArchivo.Multiline = True
        Me.ContenidoArchivo.Name = "ContenidoArchivo"
        Me.ContenidoArchivo.Size = New System.Drawing.Size(474, 192)
        Me.ContenidoArchivo.TabIndex = 21
        '
        'ArchivoCreado
        '
        Me.ArchivoCreado.Location = New System.Drawing.Point(665, 317)
        Me.ArchivoCreado.Name = "ArchivoCreado"
        Me.ArchivoCreado.Size = New System.Drawing.Size(389, 20)
        Me.ArchivoCreado.TabIndex = 22
        '
        'RutaCarpeta
        '
        Me.RutaCarpeta.Location = New System.Drawing.Point(665, 265)
        Me.RutaCarpeta.Name = "RutaCarpeta"
        Me.RutaCarpeta.Size = New System.Drawing.Size(389, 20)
        Me.RutaCarpeta.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(577, 269)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Ruta Carpeta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(577, 318)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre Archivo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(577, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Nombre Carpeta"
        '
        'NombreCarpeta
        '
        Me.NombreCarpeta.Location = New System.Drawing.Point(665, 291)
        Me.NombreCarpeta.Name = "NombreCarpeta"
        Me.NombreCarpeta.Size = New System.Drawing.Size(389, 20)
        Me.NombreCarpeta.TabIndex = 26
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Salir_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(580, 136)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(351, 46)
        Me.PanelAdministracion_.TabIndex = 91
        '
        'Salir_Menu_
        '
        Me.Salir_Menu_.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir_Menu_.BackColor = System.Drawing.Color.Transparent
        Me.Salir_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir_Menu_.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Menu_.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir_Menu_.Image = CType(resources.GetObject("Salir_Menu_.Image"), System.Drawing.Image)
        Me.Salir_Menu_.Location = New System.Drawing.Point(306, 3)
        Me.Salir_Menu_.Name = "Salir_Menu_"
        Me.Salir_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Salir_Menu_.TabIndex = 76
        Me.Salir_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Salir_Menu_.UseVisualStyleBackColor = False
        '
        'Nuevo_Menu_
        '
        Me.Nuevo_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo_Menu_.Image = CType(resources.GetObject("Nuevo_Menu_.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_.Name = "Nuevo_Menu_"
        Me.Nuevo_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_.TabIndex = 70
        Me.Nuevo_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_
        '
        Me.Cancelar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Menu_.Image = CType(resources.GetObject("Cancelar_Menu_.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_.Name = "Cancelar_Menu_"
        Me.Cancelar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_.TabIndex = 75
        Me.Cancelar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_
        '
        Me.Eliminar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar_Menu_.Image = CType(resources.GetObject("Eliminar_Menu_.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_.Name = "Eliminar_Menu_"
        Me.Eliminar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_.TabIndex = 72
        Me.Eliminar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_.UseVisualStyleBackColor = True
        '
        'Editar_Menu_
        '
        Me.Editar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_Menu_.Image = CType(resources.GetObject("Editar_Menu_.Image"), System.Drawing.Image)
        Me.Editar_Menu_.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_.Name = "Editar_Menu_"
        Me.Editar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_.TabIndex = 74
        Me.Editar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_
        '
        Me.Actualizar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualizar_Menu_.Image = CType(resources.GetObject("Actualizar_Menu_.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_.Name = "Actualizar_Menu_"
        Me.Actualizar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_.TabIndex = 73
        Me.Actualizar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_
        '
        Me.Guardar_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Menu_.Image = CType(resources.GetObject("Guardar_Menu_.Image"), System.Drawing.Image)
        Me.Guardar_Menu_.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_.Name = "Guardar_Menu_"
        Me.Guardar_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_.TabIndex = 71
        Me.Guardar_Menu_.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_.UseVisualStyleBackColor = True
        '
        'PlantillasImagenesTableAdapter
        '
        Me.PlantillasImagenesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PlantillasImagenesTableAdapter = Me.PlantillasImagenesTableAdapter
        Me.TableAdapterManager.SP_PlantillasImagenes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasImagenes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasImagenes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoDocumentoTecnico_EDICION_ELIMINAR_SEGUN_ProyectoIDTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoDocumentoTecnico_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetReportesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_PlantillasImagenes_EDICION_INSERTARBindingSource
        '
        Me.SP_PlantillasImagenes_EDICION_INSERTARBindingSource.DataMember = "SP_PlantillasImagenes_EDICION_INSERTAR"
        Me.SP_PlantillasImagenes_EDICION_INSERTARBindingSource.DataSource = Me.DataSetReportes
        '
        'SP_PlantillasImagenes_EDICION_INSERTARTableAdapter
        '
        Me.SP_PlantillasImagenes_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter
        '
        Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.RbZoom)
        Me.Panel24.Controls.Add(Me.RbCentrada)
        Me.Panel24.Controls.Add(Me.RbAjustado)
        Me.Panel24.Controls.Add(Me.RbNormal)
        Me.Panel24.Location = New System.Drawing.Point(580, 188)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(460, 28)
        Me.Panel24.TabIndex = 146
        '
        'RbZoom
        '
        Me.RbZoom.AutoSize = True
        Me.RbZoom.Location = New System.Drawing.Point(264, 1)
        Me.RbZoom.Name = "RbZoom"
        Me.RbZoom.Size = New System.Drawing.Size(52, 17)
        Me.RbZoom.TabIndex = 147
        Me.RbZoom.Text = "Zoom"
        Me.RbZoom.UseVisualStyleBackColor = True
        '
        'RbCentrada
        '
        Me.RbCentrada.AutoSize = True
        Me.RbCentrada.Location = New System.Drawing.Point(174, 1)
        Me.RbCentrada.Name = "RbCentrada"
        Me.RbCentrada.Size = New System.Drawing.Size(68, 17)
        Me.RbCentrada.TabIndex = 145
        Me.RbCentrada.Text = "Centrada"
        Me.RbCentrada.UseVisualStyleBackColor = True
        '
        'RbAjustado
        '
        Me.RbAjustado.AutoSize = True
        Me.RbAjustado.Checked = True
        Me.RbAjustado.Location = New System.Drawing.Point(86, 1)
        Me.RbAjustado.Name = "RbAjustado"
        Me.RbAjustado.Size = New System.Drawing.Size(66, 17)
        Me.RbAjustado.TabIndex = 144
        Me.RbAjustado.TabStop = True
        Me.RbAjustado.Text = "Ajustado"
        Me.RbAjustado.UseVisualStyleBackColor = True
        '
        'RbNormal
        '
        Me.RbNormal.AutoSize = True
        Me.RbNormal.Location = New System.Drawing.Point(4, 1)
        Me.RbNormal.Name = "RbNormal"
        Me.RbNormal.Size = New System.Drawing.Size(58, 17)
        Me.RbNormal.TabIndex = 143
        Me.RbNormal.Text = "Normal"
        Me.RbNormal.UseVisualStyleBackColor = True
        '
        'FormularioPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 547)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NombreCarpeta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RutaCarpeta)
        Me.Controls.Add(Me.ArchivoCreado)
        Me.Controls.Add(Me.ContenidoArchivo)
        Me.Controls.Add(Me.Ejecutar)
        Me.Controls.Add(Me.ImagenPictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProyectoIDTextBox)
        Me.Controls.Add(Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(ImagenLabel)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(ImagenIdLabel)
        Me.Controls.Add(Me.ImagenIdTextBox)
        Me.Controls.Add(PlantillaIDLabel)
        Me.Controls.Add(Me.PlantillaIDTextBox)
        Me.Controls.Add(ReferenciaLabel)
        Me.Controls.Add(Me.ReferenciaTextBox)
        Me.Controls.Add(Me.PlantillasImagenesDataGridView)
        Me.Controls.Add(Me.PlantillasImagenesBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Name = "FormularioPruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioPruebas"
        CType(Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantillasImagenesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlantillasImagenesBindingNavigator.ResumeLayout(False)
        Me.PlantillasImagenesBindingNavigator.PerformLayout()
        CType(Me.PlantillasImagenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlantillasImagenesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.SP_PlantillasImagenes_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGenerar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataSetReportes As DataSetReportes
    Friend WithEvents PlantillasImagenesBindingSource As BindingSource
    Friend WithEvents PlantillasImagenesTableAdapter As DataSetReportesTableAdapters.PlantillasImagenesTableAdapter
    Friend WithEvents TableAdapterManager As DataSetReportesTableAdapters.TableAdapterManager
    Friend WithEvents PlantillasImagenesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PlantillasImagenesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PlantillasImagenesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ImagenIdTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents ReferenciaTextBox As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnCargar As Button
    Friend WithEvents SP_PlantillasImagenes_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_PlantillasImagenes_EDICION_INSERTARTableAdapter As DataSetReportesTableAdapters.SP_PlantillasImagenes_EDICION_INSERTARTableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents PlantillaIDToolStripLabel As ToolStripLabel
    Friend WithEvents PlantillaIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents ReferenciaToolStripLabel As ToolStripLabel
    Friend WithEvents ReferenciaToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter As DataSetReportesTableAdapters.SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDTableAdapter
    Friend WithEvents SP_ProyectoDocumentoTecnico_BUSCA_SEGUN_ProyectoIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ProyectoIDTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ImagenPictureBox1 As PictureBox
    Friend WithEvents Ejecutar As Button
    Friend WithEvents ContenidoArchivo As TextBox
    Friend WithEvents ArchivoCreado As TextBox
    Friend WithEvents RutaCarpeta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NombreCarpeta As TextBox
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Salir_Menu_ As Button
    Friend WithEvents Nuevo_Menu_ As Button
    Friend WithEvents Cancelar_Menu_ As Button
    Friend WithEvents Eliminar_Menu_ As Button
    Friend WithEvents Editar_Menu_ As Button
    Friend WithEvents Actualizar_Menu_ As Button
    Friend WithEvents Guardar_Menu_ As Button
    Friend WithEvents Panel24 As Panel
    Friend WithEvents RbZoom As RadioButton
    Friend WithEvents RbCentrada As RadioButton
    Friend WithEvents RbAjustado As RadioButton
    Friend WithEvents RbNormal As RadioButton
End Class
