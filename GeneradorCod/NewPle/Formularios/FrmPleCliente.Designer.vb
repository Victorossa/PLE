<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPleCliente
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
        Dim NombreClienteLabel As System.Windows.Forms.Label
        Dim NombreTipoDocumentoLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim PrecioCobrarPorHoraLabel As System.Windows.Forms.Label
        Dim PorcentajeIncrementoTiempoLabel As System.Windows.Forms.Label
        Dim FechaCreacionLabel As System.Windows.Forms.Label
        Dim UltimaFechaModLabel As System.Windows.Forms.Label
        Dim ClienteIdLabel As System.Windows.Forms.Label
        Dim TipoDeDocumentoIdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim TipoDeDocumentoIdLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPleCliente))
        Me.PleClienteViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PleClienteViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetMaestros = New GeneradorCod.DataSetMaestros()
        Me.NombreClienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTipoDocumentoBase = New System.Windows.Forms.TextBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioCobrarPorHoraTextBox = New System.Windows.Forms.TextBox()
        Me.PorcentajeIncrementoTiempoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoIdTextBoxBase = New System.Windows.Forms.TextBox()
        Me.FechaCreacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UltimaFechaModDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ClienteIdTextBox = New System.Windows.Forms.TextBox()
        Me.CboTipoDocumentoTextBox = New System.Windows.Forms.ComboBox()
        Me.PleTipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Salir_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Editar_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.Guardar_Menu_PleCliente = New System.Windows.Forms.Button()
        Me.ValidarCierre = New System.Windows.Forms.TextBox()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.TipoDocumentoTextBoxTabla = New System.Windows.Forms.TextBox()
        Me.PleClienteViewTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.PleClienteViewTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetMaestrosTableAdapters.TableAdapterManager()
        Me.PleTipoDeDocumentoTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter()
        Me.SP_PleCliente_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleCliente_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_ACTUALIZARTableAdapter()
        Me.SP_PleCliente_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleCliente_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_ELIMINARTableAdapter()
        Me.SP_PleCliente_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleCliente_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_INSERTARTableAdapter()
        NombreClienteLabel = New System.Windows.Forms.Label()
        NombreTipoDocumentoLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        PrecioCobrarPorHoraLabel = New System.Windows.Forms.Label()
        PorcentajeIncrementoTiempoLabel = New System.Windows.Forms.Label()
        FechaCreacionLabel = New System.Windows.Forms.Label()
        UltimaFechaModLabel = New System.Windows.Forms.Label()
        ClienteIdLabel = New System.Windows.Forms.Label()
        TipoDeDocumentoIdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        TipoDeDocumentoIdLabel1 = New System.Windows.Forms.Label()
        CType(Me.PleClienteViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleClienteViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.SP_PleCliente_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleCliente_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleCliente_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreClienteLabel
        '
        NombreClienteLabel.AutoSize = True
        NombreClienteLabel.Location = New System.Drawing.Point(8, 67)
        NombreClienteLabel.Name = "NombreClienteLabel"
        NombreClienteLabel.Size = New System.Drawing.Size(123, 21)
        NombreClienteLabel.TabIndex = 1
        NombreClienteLabel.Text = "Nombre Cliente:"
        '
        'NombreTipoDocumentoLabel
        '
        NombreTipoDocumentoLabel.AutoSize = True
        NombreTipoDocumentoLabel.Location = New System.Drawing.Point(655, 387)
        NombreTipoDocumentoLabel.Name = "NombreTipoDocumentoLabel"
        NombreTipoDocumentoLabel.Size = New System.Drawing.Size(190, 21)
        NombreTipoDocumentoLabel.TabIndex = 3
        NombreTipoDocumentoLabel.Text = "Nombre Tipo Documento:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(8, 135)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(94, 21)
        DocumentoLabel.TabIndex = 5
        DocumentoLabel.Text = "Documento:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(8, 169)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(75, 21)
        ContactoLabel.TabIndex = 7
        ContactoLabel.Text = "Contacto:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(8, 203)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(73, 21)
        TelefonoLabel.TabIndex = 9
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(8, 237)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(62, 21)
        CelularLabel.TabIndex = 11
        CelularLabel.Text = "Celular:"
        '
        'PrecioCobrarPorHoraLabel
        '
        PrecioCobrarPorHoraLabel.AutoSize = True
        PrecioCobrarPorHoraLabel.Location = New System.Drawing.Point(8, 271)
        PrecioCobrarPorHoraLabel.Name = "PrecioCobrarPorHoraLabel"
        PrecioCobrarPorHoraLabel.Size = New System.Drawing.Size(174, 21)
        PrecioCobrarPorHoraLabel.TabIndex = 13
        PrecioCobrarPorHoraLabel.Text = "Precio Cobrar Por Hora:"
        '
        'PorcentajeIncrementoTiempoLabel
        '
        PorcentajeIncrementoTiempoLabel.AutoSize = True
        PorcentajeIncrementoTiempoLabel.Location = New System.Drawing.Point(8, 305)
        PorcentajeIncrementoTiempoLabel.Name = "PorcentajeIncrementoTiempoLabel"
        PorcentajeIncrementoTiempoLabel.Size = New System.Drawing.Size(225, 21)
        PorcentajeIncrementoTiempoLabel.TabIndex = 15
        PorcentajeIncrementoTiempoLabel.Text = "Porcentaje Incremento Tiempo:"
        '
        'FechaCreacionLabel
        '
        FechaCreacionLabel.AutoSize = True
        FechaCreacionLabel.Location = New System.Drawing.Point(8, 340)
        FechaCreacionLabel.Name = "FechaCreacionLabel"
        FechaCreacionLabel.Size = New System.Drawing.Size(118, 21)
        FechaCreacionLabel.TabIndex = 19
        FechaCreacionLabel.Text = "Fecha Creacion:"
        '
        'UltimaFechaModLabel
        '
        UltimaFechaModLabel.AutoSize = True
        UltimaFechaModLabel.Location = New System.Drawing.Point(8, 374)
        UltimaFechaModLabel.Name = "UltimaFechaModLabel"
        UltimaFechaModLabel.Size = New System.Drawing.Size(139, 21)
        UltimaFechaModLabel.TabIndex = 21
        UltimaFechaModLabel.Text = "Ultima Fecha Mod:"
        '
        'ClienteIdLabel
        '
        ClienteIdLabel.AutoSize = True
        ClienteIdLabel.Location = New System.Drawing.Point(767, 353)
        ClienteIdLabel.Name = "ClienteIdLabel"
        ClienteIdLabel.Size = New System.Drawing.Size(78, 21)
        ClienteIdLabel.TabIndex = 23
        ClienteIdLabel.Text = "Cliente Id:"
        '
        'TipoDeDocumentoIdLabel
        '
        TipoDeDocumentoIdLabel.AutoSize = True
        TipoDeDocumentoIdLabel.Location = New System.Drawing.Point(682, 319)
        TipoDeDocumentoIdLabel.Name = "TipoDeDocumentoIdLabel"
        TipoDeDocumentoIdLabel.Size = New System.Drawing.Size(204, 21)
        TipoDeDocumentoIdLabel.TabIndex = 25
        TipoDeDocumentoIdLabel.Text = "Tipo De Documento Id Base:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 100)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(128, 21)
        Label1.TabIndex = 106
        Label1.Text = "Tipo Documento:"
        '
        'TipoDeDocumentoIdLabel1
        '
        TipoDeDocumentoIdLabel1.AutoSize = True
        TipoDeDocumentoIdLabel1.Location = New System.Drawing.Point(677, 285)
        TipoDeDocumentoIdLabel1.Name = "TipoDeDocumentoIdLabel1"
        TipoDeDocumentoIdLabel1.Size = New System.Drawing.Size(209, 21)
        TipoDeDocumentoIdLabel1.TabIndex = 106
        TipoDeDocumentoIdLabel1.Text = "Tipo De Documento Id Tabla:"
        '
        'PleClienteViewDataGridView
        '
        Me.PleClienteViewDataGridView.AllowUserToAddRows = False
        Me.PleClienteViewDataGridView.AutoGenerateColumns = False
        Me.PleClienteViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PleClienteViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.PleClienteViewDataGridView.DataSource = Me.PleClienteViewBindingSource
        Me.PleClienteViewDataGridView.Location = New System.Drawing.Point(560, 12)
        Me.PleClienteViewDataGridView.Name = "PleClienteViewDataGridView"
        Me.PleClienteViewDataGridView.RowHeadersVisible = False
        Me.PleClienteViewDataGridView.Size = New System.Drawing.Size(517, 408)
        Me.PleClienteViewDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NombreCliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 513
        '
        'PleClienteViewBindingSource
        '
        Me.PleClienteViewBindingSource.DataMember = "PleClienteView"
        Me.PleClienteViewBindingSource.DataSource = Me.DataSetMaestros
        '
        'DataSetMaestros
        '
        Me.DataSetMaestros.DataSetName = "DataSetMaestros"
        Me.DataSetMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NombreClienteTextBox
        '
        Me.NombreClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "NombreCliente", True))
        Me.NombreClienteTextBox.Location = New System.Drawing.Point(239, 64)
        Me.NombreClienteTextBox.Name = "NombreClienteTextBox"
        Me.NombreClienteTextBox.Size = New System.Drawing.Size(315, 28)
        Me.NombreClienteTextBox.TabIndex = 2
        '
        'NombreTipoDocumentoBase
        '
        Me.NombreTipoDocumentoBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "NombreTipoDocumento", True))
        Me.NombreTipoDocumentoBase.Location = New System.Drawing.Point(851, 384)
        Me.NombreTipoDocumentoBase.Name = "NombreTipoDocumentoBase"
        Me.NombreTipoDocumentoBase.Size = New System.Drawing.Size(200, 28)
        Me.NombreTipoDocumentoBase.TabIndex = 4
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(239, 132)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(315, 28)
        Me.DocumentoTextBox.TabIndex = 6
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "Contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(239, 166)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(315, 28)
        Me.ContactoTextBox.TabIndex = 8
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(239, 200)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(315, 28)
        Me.TelefonoTextBox.TabIndex = 10
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(239, 234)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(315, 28)
        Me.CelularTextBox.TabIndex = 12
        '
        'PrecioCobrarPorHoraTextBox
        '
        Me.PrecioCobrarPorHoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "PrecioCobrarPorHora", True))
        Me.PrecioCobrarPorHoraTextBox.Location = New System.Drawing.Point(239, 268)
        Me.PrecioCobrarPorHoraTextBox.Name = "PrecioCobrarPorHoraTextBox"
        Me.PrecioCobrarPorHoraTextBox.Size = New System.Drawing.Size(158, 28)
        Me.PrecioCobrarPorHoraTextBox.TabIndex = 14
        '
        'PorcentajeIncrementoTiempoTextBox
        '
        Me.PorcentajeIncrementoTiempoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "PorcentajeIncrementoTiempo", True))
        Me.PorcentajeIncrementoTiempoTextBox.Location = New System.Drawing.Point(239, 302)
        Me.PorcentajeIncrementoTiempoTextBox.Name = "PorcentajeIncrementoTiempoTextBox"
        Me.PorcentajeIncrementoTiempoTextBox.Size = New System.Drawing.Size(158, 28)
        Me.PorcentajeIncrementoTiempoTextBox.TabIndex = 16
        '
        'TipoDocumentoIdTextBoxBase
        '
        Me.TipoDocumentoIdTextBoxBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "TipoDocumento", True))
        Me.TipoDocumentoIdTextBoxBase.Location = New System.Drawing.Point(892, 316)
        Me.TipoDocumentoIdTextBoxBase.Name = "TipoDocumentoIdTextBoxBase"
        Me.TipoDocumentoIdTextBoxBase.Size = New System.Drawing.Size(159, 28)
        Me.TipoDocumentoIdTextBoxBase.TabIndex = 18
        '
        'FechaCreacionDateTimePicker
        '
        Me.FechaCreacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PleClienteViewBindingSource, "FechaCreacion", True))
        Me.FechaCreacionDateTimePicker.Location = New System.Drawing.Point(239, 336)
        Me.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker"
        Me.FechaCreacionDateTimePicker.Size = New System.Drawing.Size(315, 28)
        Me.FechaCreacionDateTimePicker.TabIndex = 20
        '
        'UltimaFechaModDateTimePicker
        '
        Me.UltimaFechaModDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PleClienteViewBindingSource, "UltimaFechaMod", True))
        Me.UltimaFechaModDateTimePicker.Location = New System.Drawing.Point(239, 370)
        Me.UltimaFechaModDateTimePicker.Name = "UltimaFechaModDateTimePicker"
        Me.UltimaFechaModDateTimePicker.Size = New System.Drawing.Size(315, 28)
        Me.UltimaFechaModDateTimePicker.TabIndex = 22
        '
        'ClienteIdTextBox
        '
        Me.ClienteIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleClienteViewBindingSource, "ClienteId", True))
        Me.ClienteIdTextBox.Location = New System.Drawing.Point(851, 350)
        Me.ClienteIdTextBox.Name = "ClienteIdTextBox"
        Me.ClienteIdTextBox.Size = New System.Drawing.Size(200, 28)
        Me.ClienteIdTextBox.TabIndex = 24
        '
        'CboTipoDocumentoTextBox
        '
        Me.CboTipoDocumentoTextBox.DataSource = Me.PleTipoDeDocumentoBindingSource
        Me.CboTipoDocumentoTextBox.DisplayMember = "NombreTipoDocumento"
        Me.CboTipoDocumentoTextBox.FormattingEnabled = True
        Me.CboTipoDocumentoTextBox.Location = New System.Drawing.Point(239, 97)
        Me.CboTipoDocumentoTextBox.Name = "CboTipoDocumentoTextBox"
        Me.CboTipoDocumentoTextBox.Size = New System.Drawing.Size(315, 29)
        Me.CboTipoDocumentoTextBox.TabIndex = 27
        Me.CboTipoDocumentoTextBox.ValueMember = "NombreTipoDocumento"
        '
        'PleTipoDeDocumentoBindingSource
        '
        Me.PleTipoDeDocumentoBindingSource.DataMember = "PleTipoDeDocumento"
        Me.PleTipoDeDocumentoBindingSource.DataSource = Me.DataSetMaestros
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Salir_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_PleCliente)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_PleCliente)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(12, 12)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(542, 46)
        Me.PanelAdministracion_.TabIndex = 92
        '
        'Salir_Menu_PleCliente
        '
        Me.Salir_Menu_PleCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir_Menu_PleCliente.BackColor = System.Drawing.Color.Transparent
        Me.Salir_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir_Menu_PleCliente.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Menu_PleCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir_Menu_PleCliente.Image = CType(resources.GetObject("Salir_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Salir_Menu_PleCliente.Location = New System.Drawing.Point(497, 3)
        Me.Salir_Menu_PleCliente.Name = "Salir_Menu_PleCliente"
        Me.Salir_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Salir_Menu_PleCliente.TabIndex = 76
        Me.Salir_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Salir_Menu_PleCliente.UseVisualStyleBackColor = False
        '
        'Nuevo_Menu_PleCliente
        '
        Me.Nuevo_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo_Menu_PleCliente.Image = CType(resources.GetObject("Nuevo_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_PleCliente.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_PleCliente.Name = "Nuevo_Menu_PleCliente"
        Me.Nuevo_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_PleCliente.TabIndex = 70
        Me.Nuevo_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_PleCliente
        '
        Me.Cancelar_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Menu_PleCliente.Image = CType(resources.GetObject("Cancelar_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_PleCliente.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_PleCliente.Name = "Cancelar_Menu_PleCliente"
        Me.Cancelar_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_PleCliente.TabIndex = 75
        Me.Cancelar_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_PleCliente
        '
        Me.Eliminar_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar_Menu_PleCliente.Image = CType(resources.GetObject("Eliminar_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_PleCliente.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_PleCliente.Name = "Eliminar_Menu_PleCliente"
        Me.Eliminar_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_PleCliente.TabIndex = 72
        Me.Eliminar_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'Editar_Menu_PleCliente
        '
        Me.Editar_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_Menu_PleCliente.Image = CType(resources.GetObject("Editar_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Editar_Menu_PleCliente.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_PleCliente.Name = "Editar_Menu_PleCliente"
        Me.Editar_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_PleCliente.TabIndex = 74
        Me.Editar_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_PleCliente
        '
        Me.Actualizar_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualizar_Menu_PleCliente.Image = CType(resources.GetObject("Actualizar_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_PleCliente.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_PleCliente.Name = "Actualizar_Menu_PleCliente"
        Me.Actualizar_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_PleCliente.TabIndex = 73
        Me.Actualizar_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_PleCliente
        '
        Me.Guardar_Menu_PleCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_PleCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Menu_PleCliente.Image = CType(resources.GetObject("Guardar_Menu_PleCliente.Image"), System.Drawing.Image)
        Me.Guardar_Menu_PleCliente.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_PleCliente.Name = "Guardar_Menu_PleCliente"
        Me.Guardar_Menu_PleCliente.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_PleCliente.TabIndex = 71
        Me.Guardar_Menu_PleCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_PleCliente.UseVisualStyleBackColor = True
        '
        'ValidarCierre
        '
        Me.ValidarCierre.Location = New System.Drawing.Point(851, 109)
        Me.ValidarCierre.Name = "ValidarCierre"
        Me.ValidarCierre.Size = New System.Drawing.Size(110, 28)
        Me.ValidarCierre.TabIndex = 105
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(851, 158)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(110, 36)
        Me.LblInforme.TabIndex = 104
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInforme.Visible = False
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(851, 135)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(110, 28)
        Me.ControlNulos.TabIndex = 103
        '
        'TipoDocumentoTextBoxTabla
        '
        Me.TipoDocumentoTextBoxTabla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleTipoDeDocumentoBindingSource, "TipoDeDocumentoId", True))
        Me.TipoDocumentoTextBoxTabla.Location = New System.Drawing.Point(892, 282)
        Me.TipoDocumentoTextBoxTabla.Name = "TipoDocumentoTextBoxTabla"
        Me.TipoDocumentoTextBoxTabla.Size = New System.Drawing.Size(159, 28)
        Me.TipoDocumentoTextBoxTabla.TabIndex = 107
        '
        'PleClienteViewTableAdapter
        '
        Me.PleClienteViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.PleCampDeTablasFormatoTableAdapter = Nothing
        Me.TableAdapterManager.PleClienteTableAdapter = Nothing
        Me.TableAdapterManager.PleRequerimientosTableAdapter = Nothing
        Me.TableAdapterManager.PleTecnologiasTableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo1TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo2TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo3TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo4TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupoTableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDeDocumentoTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCampDeTablas_EDICION_ACTUALIZAR_OrdenTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCampDeTablas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCampDeTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCampDeTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCliente_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCliente_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleCliente_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleComponentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleComponentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleComponentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleComponentesConBase_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleContenidoEstandar_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleContenidoEstandar_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleEmpresa_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleEmpresa_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleMetricas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleMetricas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleMetricas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlePlantilla_EDICION_ACTUALIZAR_SOLO_SELECCIONADATableAdapter = Nothing
        Me.TableAdapterManager.SP_PlePlantilla_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlePlantilla_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlePlantilla_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectos_EDICION_ACTUALIZAR_CodigoGeneradoTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectos_EDICION_ACTUALIZAR_TIEMPO_ESTIMADOTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectosYTecnologias_EDICION_ELIMINAR_Segun_ProyectoYTecnologiaTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectosYTecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleProyectosYTecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosComponentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosComponentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosComponentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosCompRegistro_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosCompRegistro_EDICION_ELIMINAR_ProyectoIdTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosCompRegistro_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRequerimientosCompRegistro_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologias_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZAR_Segun_SeleccionadoTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINAR_Segun_ProyectoIdTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologiasRegistro_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleRutasArchivosTecnologiasRegistro_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasComponentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasComponentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasComponentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasDeProyecto_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasDeProyecto_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasDeProyecto_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasRelacionadas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasRelacionadas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasRelacionadas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasRelacionadasRegistro_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTablasRelacionadasRegistro_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTecnologias_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDato_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDato_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDato_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteCampo_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINAR_PorComponenteTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteCampo_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteCampo_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteEspeciales_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteEspeciales_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoComponenteEspeciales_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoGrupo_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoGrupo_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDatoGrupo_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetMaestrosTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PleTipoDeDocumentoTableAdapter
        '
        Me.PleTipoDeDocumentoTableAdapter.ClearBeforeFill = True
        '
        'SP_PleCliente_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_PleCliente_EDICION_ACTUALIZARBindingSource.DataMember = "SP_PleCliente_EDICION_ACTUALIZAR"
        Me.SP_PleCliente_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleCliente_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_PleCliente_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleCliente_EDICION_ELIMINARBindingSource
        '
        Me.SP_PleCliente_EDICION_ELIMINARBindingSource.DataMember = "SP_PleCliente_EDICION_ELIMINAR"
        Me.SP_PleCliente_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleCliente_EDICION_ELIMINARTableAdapter
        '
        Me.SP_PleCliente_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleCliente_EDICION_INSERTARBindingSource
        '
        Me.SP_PleCliente_EDICION_INSERTARBindingSource.DataMember = "SP_PleCliente_EDICION_INSERTAR"
        Me.SP_PleCliente_EDICION_INSERTARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleCliente_EDICION_INSERTARTableAdapter
        '
        Me.SP_PleCliente_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'FrmPleCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1088, 432)
        Me.Controls.Add(Me.PleClienteViewDataGridView)
        Me.Controls.Add(TipoDeDocumentoIdLabel1)
        Me.Controls.Add(Me.TipoDocumentoTextBoxTabla)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ValidarCierre)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Controls.Add(Me.CboTipoDocumentoTextBox)
        Me.Controls.Add(NombreClienteLabel)
        Me.Controls.Add(Me.NombreClienteTextBox)
        Me.Controls.Add(NombreTipoDocumentoLabel)
        Me.Controls.Add(Me.NombreTipoDocumentoBase)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(PrecioCobrarPorHoraLabel)
        Me.Controls.Add(Me.PrecioCobrarPorHoraTextBox)
        Me.Controls.Add(PorcentajeIncrementoTiempoLabel)
        Me.Controls.Add(Me.PorcentajeIncrementoTiempoTextBox)
        Me.Controls.Add(Me.TipoDocumentoIdTextBoxBase)
        Me.Controls.Add(FechaCreacionLabel)
        Me.Controls.Add(Me.FechaCreacionDateTimePicker)
        Me.Controls.Add(UltimaFechaModLabel)
        Me.Controls.Add(Me.UltimaFechaModDateTimePicker)
        Me.Controls.Add(ClienteIdLabel)
        Me.Controls.Add(Me.ClienteIdTextBox)
        Me.Controls.Add(TipoDeDocumentoIdLabel)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPleCliente"
        Me.Text = "FrmPleCliente"
        CType(Me.PleClienteViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleClienteViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.SP_PleCliente_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleCliente_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleCliente_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetMaestros As DataSetMaestros
    Friend WithEvents PleClienteViewBindingSource As BindingSource
    Friend WithEvents PleClienteViewTableAdapter As DataSetMaestrosTableAdapters.PleClienteViewTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMaestrosTableAdapters.TableAdapterManager
    Friend WithEvents PleClienteViewDataGridView As DataGridView
    Friend WithEvents NombreClienteTextBox As TextBox
    Friend WithEvents NombreTipoDocumentoBase As TextBox
    Friend WithEvents DocumentoTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents PrecioCobrarPorHoraTextBox As TextBox
    Friend WithEvents PorcentajeIncrementoTiempoTextBox As TextBox
    Friend WithEvents TipoDocumentoIdTextBoxBase As TextBox
    Friend WithEvents FechaCreacionDateTimePicker As DateTimePicker
    Friend WithEvents UltimaFechaModDateTimePicker As DateTimePicker
    Friend WithEvents ClienteIdTextBox As TextBox
    Friend WithEvents CboTipoDocumentoTextBox As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Salir_Menu_PleCliente As Button
    Friend WithEvents Nuevo_Menu_PleCliente As Button
    Friend WithEvents Cancelar_Menu_PleCliente As Button
    Friend WithEvents Eliminar_Menu_PleCliente As Button
    Friend WithEvents Editar_Menu_PleCliente As Button
    Friend WithEvents Actualizar_Menu_PleCliente As Button
    Friend WithEvents Guardar_Menu_PleCliente As Button
    Friend WithEvents ValidarCierre As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents PleTipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents PleTipoDeDocumentoTableAdapter As DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter
    Friend WithEvents TipoDocumentoTextBoxTabla As TextBox
    Friend WithEvents SP_PleCliente_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_PleCliente_EDICION_ACTUALIZARTableAdapter As DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_PleCliente_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_PleCliente_EDICION_ELIMINARTableAdapter As DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_PleCliente_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_PleCliente_EDICION_INSERTARTableAdapter As DataSetMaestrosTableAdapters.SP_PleCliente_EDICION_INSERTARTableAdapter
End Class
