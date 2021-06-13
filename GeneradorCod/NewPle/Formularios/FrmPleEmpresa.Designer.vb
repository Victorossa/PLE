<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPleEmpresa
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
        Dim NombreEmpresaLabel As System.Windows.Forms.Label
        Dim NombreTipoDocumentoLabel As System.Windows.Forms.Label
        Dim DocumentoLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CelularLabel As System.Windows.Forms.Label
        Dim EsloganLabel As System.Windows.Forms.Label
        Dim ServiciosLabel As System.Windows.Forms.Label
        Dim MisionLabel As System.Windows.Forms.Label
        Dim VisionLabel As System.Windows.Forms.Label
        Dim EmpresaIdLabel As System.Windows.Forms.Label
        Dim TipoDeDocumentoIdLabel As System.Windows.Forms.Label
        Dim ImagenEmpresaLabel As System.Windows.Forms.Label
        Dim TipoDeDocumentoIdLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPleEmpresa))
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Salir_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Editar_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.Guardar_Menu_PleEmpresa = New System.Windows.Forms.Button()
        Me.ValidarCierre = New System.Windows.Forms.TextBox()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.DataSetMaestros = New GeneradorCod.DataSetMaestros()
        Me.PleEmpresaViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PleEmpresaViewTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.PleEmpresaViewTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetMaestrosTableAdapters.TableAdapterManager()
        Me.PleTipoDeDocumentoTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter()
        Me.PleEmpresaViewDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NombreEmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTipoDeDocumentoIdBase = New System.Windows.Forms.TextBox()
        Me.DocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CelularTextBox = New System.Windows.Forms.TextBox()
        Me.EsloganTextBox = New System.Windows.Forms.TextBox()
        Me.ServiciosTextBox = New System.Windows.Forms.TextBox()
        Me.MisionTextBox = New System.Windows.Forms.TextBox()
        Me.VisionTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaIdTextBox = New System.Windows.Forms.TextBox()
        Me.TipoDeDocumentoIdTextBoxBase = New System.Windows.Forms.TextBox()
        Me.ImagenPictureBox = New System.Windows.Forms.PictureBox()
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.CboTipoDeDocumentoIdTextBox = New System.Windows.Forms.ComboBox()
        Me.PleTipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoDeDocumentoIdTextBoxTabla = New System.Windows.Forms.TextBox()
        Me.SP_PleEmpresa_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter()
        Me.SP_PleEmpresa_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleEmpresa_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_ELIMINARTableAdapter()
        Me.SP_PleEmpresa_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleEmpresa_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_INSERTARTableAdapter()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.RbZoom = New System.Windows.Forms.RadioButton()
        Me.RbCentrada = New System.Windows.Forms.RadioButton()
        Me.RbAjustado = New System.Windows.Forms.RadioButton()
        Me.RbNormal = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreEmpresaLabel = New System.Windows.Forms.Label()
        NombreTipoDocumentoLabel = New System.Windows.Forms.Label()
        DocumentoLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CelularLabel = New System.Windows.Forms.Label()
        EsloganLabel = New System.Windows.Forms.Label()
        ServiciosLabel = New System.Windows.Forms.Label()
        MisionLabel = New System.Windows.Forms.Label()
        VisionLabel = New System.Windows.Forms.Label()
        EmpresaIdLabel = New System.Windows.Forms.Label()
        TipoDeDocumentoIdLabel = New System.Windows.Forms.Label()
        ImagenEmpresaLabel = New System.Windows.Forms.Label()
        TipoDeDocumentoIdLabel1 = New System.Windows.Forms.Label()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleEmpresaViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleEmpresaViewDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleEmpresa_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleEmpresa_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleEmpresa_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreEmpresaLabel
        '
        NombreEmpresaLabel.AutoSize = True
        NombreEmpresaLabel.Location = New System.Drawing.Point(12, 70)
        NombreEmpresaLabel.Name = "NombreEmpresaLabel"
        NombreEmpresaLabel.Size = New System.Drawing.Size(135, 21)
        NombreEmpresaLabel.TabIndex = 106
        NombreEmpresaLabel.Text = "Nombre Empresa:"
        '
        'NombreTipoDocumentoLabel
        '
        NombreTipoDocumentoLabel.AutoSize = True
        NombreTipoDocumentoLabel.Location = New System.Drawing.Point(757, 240)
        NombreTipoDocumentoLabel.Name = "NombreTipoDocumentoLabel"
        NombreTipoDocumentoLabel.Size = New System.Drawing.Size(190, 21)
        NombreTipoDocumentoLabel.TabIndex = 108
        NombreTipoDocumentoLabel.Text = "Nombre Tipo Documento:"
        '
        'DocumentoLabel
        '
        DocumentoLabel.AutoSize = True
        DocumentoLabel.Location = New System.Drawing.Point(12, 180)
        DocumentoLabel.Name = "DocumentoLabel"
        DocumentoLabel.Size = New System.Drawing.Size(94, 21)
        DocumentoLabel.TabIndex = 110
        DocumentoLabel.Text = "Documento:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 351)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(51, 21)
        EmailLabel.TabIndex = 112
        EmailLabel.Text = "Email:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(12, 241)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(73, 21)
        TelefonoLabel.TabIndex = 114
        TelefonoLabel.Text = "Telefono:"
        '
        'CelularLabel
        '
        CelularLabel.AutoSize = True
        CelularLabel.Location = New System.Drawing.Point(12, 297)
        CelularLabel.Name = "CelularLabel"
        CelularLabel.Size = New System.Drawing.Size(62, 21)
        CelularLabel.TabIndex = 116
        CelularLabel.Text = "Celular:"
        '
        'EsloganLabel
        '
        EsloganLabel.AutoSize = True
        EsloganLabel.Location = New System.Drawing.Point(8, 406)
        EsloganLabel.Name = "EsloganLabel"
        EsloganLabel.Size = New System.Drawing.Size(67, 21)
        EsloganLabel.TabIndex = 118
        EsloganLabel.Text = "Eslogan:"
        '
        'ServiciosLabel
        '
        ServiciosLabel.AutoSize = True
        ServiciosLabel.Location = New System.Drawing.Point(8, 516)
        ServiciosLabel.Name = "ServiciosLabel"
        ServiciosLabel.Size = New System.Drawing.Size(75, 21)
        ServiciosLabel.TabIndex = 120
        ServiciosLabel.Text = "Servicios:"
        '
        'MisionLabel
        '
        MisionLabel.AutoSize = True
        MisionLabel.Location = New System.Drawing.Point(364, 70)
        MisionLabel.Name = "MisionLabel"
        MisionLabel.Size = New System.Drawing.Size(60, 21)
        MisionLabel.TabIndex = 122
        MisionLabel.Text = "Mision:"
        '
        'VisionLabel
        '
        VisionLabel.AutoSize = True
        VisionLabel.Location = New System.Drawing.Point(364, 241)
        VisionLabel.Name = "VisionLabel"
        VisionLabel.Size = New System.Drawing.Size(56, 21)
        VisionLabel.TabIndex = 124
        VisionLabel.Text = "Vision:"
        '
        'EmpresaIdLabel
        '
        EmpresaIdLabel.AutoSize = True
        EmpresaIdLabel.Location = New System.Drawing.Point(754, 207)
        EmpresaIdLabel.Name = "EmpresaIdLabel"
        EmpresaIdLabel.Size = New System.Drawing.Size(90, 21)
        EmpresaIdLabel.TabIndex = 126
        EmpresaIdLabel.Text = "Empresa Id:"
        '
        'TipoDeDocumentoIdLabel
        '
        TipoDeDocumentoIdLabel.AutoSize = True
        TipoDeDocumentoIdLabel.Location = New System.Drawing.Point(779, 273)
        TipoDeDocumentoIdLabel.Name = "TipoDeDocumentoIdLabel"
        TipoDeDocumentoIdLabel.Size = New System.Drawing.Size(168, 21)
        TipoDeDocumentoIdLabel.TabIndex = 128
        TipoDeDocumentoIdLabel.Text = "Tipo De Documento Id:"
        '
        'ImagenEmpresaLabel
        '
        ImagenEmpresaLabel.AutoSize = True
        ImagenEmpresaLabel.Location = New System.Drawing.Point(364, 406)
        ImagenEmpresaLabel.Name = "ImagenEmpresaLabel"
        ImagenEmpresaLabel.Size = New System.Drawing.Size(129, 21)
        ImagenEmpresaLabel.TabIndex = 129
        ImagenEmpresaLabel.Text = "Imagen Empresa:"
        '
        'TipoDeDocumentoIdLabel1
        '
        TipoDeDocumentoIdLabel1.AutoSize = True
        TipoDeDocumentoIdLabel1.Location = New System.Drawing.Point(779, 307)
        TipoDeDocumentoIdLabel1.Name = "TipoDeDocumentoIdLabel1"
        TipoDeDocumentoIdLabel1.Size = New System.Drawing.Size(168, 21)
        TipoDeDocumentoIdLabel1.TabIndex = 132
        TipoDeDocumentoIdLabel1.Text = "Tipo De Documento Id:"
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Salir_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_PleEmpresa)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_PleEmpresa)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(12, 12)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(1061, 46)
        Me.PanelAdministracion_.TabIndex = 92
        '
        'Salir_Menu_PleEmpresa
        '
        Me.Salir_Menu_PleEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir_Menu_PleEmpresa.BackColor = System.Drawing.Color.Transparent
        Me.Salir_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir_Menu_PleEmpresa.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Menu_PleEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir_Menu_PleEmpresa.Image = CType(resources.GetObject("Salir_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Salir_Menu_PleEmpresa.Location = New System.Drawing.Point(1016, 3)
        Me.Salir_Menu_PleEmpresa.Name = "Salir_Menu_PleEmpresa"
        Me.Salir_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Salir_Menu_PleEmpresa.TabIndex = 76
        Me.Salir_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Salir_Menu_PleEmpresa.UseVisualStyleBackColor = False
        '
        'Nuevo_Menu_PleEmpresa
        '
        Me.Nuevo_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo_Menu_PleEmpresa.Image = CType(resources.GetObject("Nuevo_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_PleEmpresa.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_PleEmpresa.Name = "Nuevo_Menu_PleEmpresa"
        Me.Nuevo_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_PleEmpresa.TabIndex = 70
        Me.Nuevo_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_PleEmpresa
        '
        Me.Cancelar_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Menu_PleEmpresa.Image = CType(resources.GetObject("Cancelar_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_PleEmpresa.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_PleEmpresa.Name = "Cancelar_Menu_PleEmpresa"
        Me.Cancelar_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_PleEmpresa.TabIndex = 75
        Me.Cancelar_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_PleEmpresa
        '
        Me.Eliminar_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar_Menu_PleEmpresa.Image = CType(resources.GetObject("Eliminar_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_PleEmpresa.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_PleEmpresa.Name = "Eliminar_Menu_PleEmpresa"
        Me.Eliminar_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_PleEmpresa.TabIndex = 72
        Me.Eliminar_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'Editar_Menu_PleEmpresa
        '
        Me.Editar_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_Menu_PleEmpresa.Image = CType(resources.GetObject("Editar_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Editar_Menu_PleEmpresa.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_PleEmpresa.Name = "Editar_Menu_PleEmpresa"
        Me.Editar_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_PleEmpresa.TabIndex = 74
        Me.Editar_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_PleEmpresa
        '
        Me.Actualizar_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualizar_Menu_PleEmpresa.Image = CType(resources.GetObject("Actualizar_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_PleEmpresa.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_PleEmpresa.Name = "Actualizar_Menu_PleEmpresa"
        Me.Actualizar_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_PleEmpresa.TabIndex = 73
        Me.Actualizar_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_PleEmpresa
        '
        Me.Guardar_Menu_PleEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_PleEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Menu_PleEmpresa.Image = CType(resources.GetObject("Guardar_Menu_PleEmpresa.Image"), System.Drawing.Image)
        Me.Guardar_Menu_PleEmpresa.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_PleEmpresa.Name = "Guardar_Menu_PleEmpresa"
        Me.Guardar_Menu_PleEmpresa.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_PleEmpresa.TabIndex = 71
        Me.Guardar_Menu_PleEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_PleEmpresa.UseVisualStyleBackColor = True
        '
        'ValidarCierre
        '
        Me.ValidarCierre.Location = New System.Drawing.Point(802, 478)
        Me.ValidarCierre.Name = "ValidarCierre"
        Me.ValidarCierre.Size = New System.Drawing.Size(110, 28)
        Me.ValidarCierre.TabIndex = 105
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(802, 543)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(110, 36)
        Me.LblInforme.TabIndex = 104
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInforme.Visible = False
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(802, 512)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(110, 28)
        Me.ControlNulos.TabIndex = 103
        '
        'DataSetMaestros
        '
        Me.DataSetMaestros.DataSetName = "DataSetMaestros"
        Me.DataSetMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PleEmpresaViewBindingSource
        '
        Me.PleEmpresaViewBindingSource.DataMember = "PleEmpresaView"
        Me.PleEmpresaViewBindingSource.DataSource = Me.DataSetMaestros
        '
        'PleEmpresaViewTableAdapter
        '
        Me.PleEmpresaViewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PleCampDeTablasFormatoTableAdapter = Nothing
        Me.TableAdapterManager.PleClienteTableAdapter = Nothing
        Me.TableAdapterManager.PleRequerimientosTableAdapter = Nothing
        Me.TableAdapterManager.PleTecnologiasTableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo1TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo2TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo3TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupo4TableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDatoGrupoTableAdapter = Nothing
        Me.TableAdapterManager.PleTipoDeDocumentoTableAdapter = Me.PleTipoDeDocumentoTableAdapter
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
        'PleEmpresaViewDataGridView
        '
        Me.PleEmpresaViewDataGridView.AllowUserToAddRows = False
        Me.PleEmpresaViewDataGridView.AutoGenerateColumns = False
        Me.PleEmpresaViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PleEmpresaViewDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEmpresa, Me.DataGridViewImageColumn1})
        Me.PleEmpresaViewDataGridView.DataSource = Me.PleEmpresaViewBindingSource
        Me.PleEmpresaViewDataGridView.Location = New System.Drawing.Point(719, 70)
        Me.PleEmpresaViewDataGridView.Name = "PleEmpresaViewDataGridView"
        Me.PleEmpresaViewDataGridView.RowHeadersVisible = False
        Me.PleEmpresaViewDataGridView.RowTemplate.Height = 120
        Me.PleEmpresaViewDataGridView.Size = New System.Drawing.Size(354, 559)
        Me.PleEmpresaViewDataGridView.TabIndex = 106
        '
        'NombreEmpresa
        '
        Me.NombreEmpresa.DataPropertyName = "NombreEmpresa"
        Me.NombreEmpresa.HeaderText = "Empresa"
        Me.NombreEmpresa.Name = "NombreEmpresa"
        Me.NombreEmpresa.Width = 230
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ImagenEmpresa"
        Me.DataGridViewImageColumn1.HeaderText = "Imagen"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 120
        '
        'NombreEmpresaTextBox
        '
        Me.NombreEmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "NombreEmpresa", True))
        Me.NombreEmpresaTextBox.Location = New System.Drawing.Point(12, 94)
        Me.NombreEmpresaTextBox.Name = "NombreEmpresaTextBox"
        Me.NombreEmpresaTextBox.Size = New System.Drawing.Size(346, 28)
        Me.NombreEmpresaTextBox.TabIndex = 107
        '
        'NombreTipoDeDocumentoIdBase
        '
        Me.NombreTipoDeDocumentoIdBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "NombreTipoDocumento", True))
        Me.NombreTipoDeDocumentoIdBase.Location = New System.Drawing.Point(950, 236)
        Me.NombreTipoDeDocumentoIdBase.Name = "NombreTipoDeDocumentoIdBase"
        Me.NombreTipoDeDocumentoIdBase.Size = New System.Drawing.Size(100, 28)
        Me.NombreTipoDeDocumentoIdBase.TabIndex = 109
        '
        'DocumentoTextBox
        '
        Me.DocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Documento", True))
        Me.DocumentoTextBox.Location = New System.Drawing.Point(12, 204)
        Me.DocumentoTextBox.Name = "DocumentoTextBox"
        Me.DocumentoTextBox.Size = New System.Drawing.Size(345, 28)
        Me.DocumentoTextBox.TabIndex = 111
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(12, 375)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(345, 28)
        Me.EmailTextBox.TabIndex = 113
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(12, 265)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(345, 28)
        Me.TelefonoTextBox.TabIndex = 115
        '
        'CelularTextBox
        '
        Me.CelularTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Celular", True))
        Me.CelularTextBox.Location = New System.Drawing.Point(12, 321)
        Me.CelularTextBox.Name = "CelularTextBox"
        Me.CelularTextBox.Size = New System.Drawing.Size(345, 28)
        Me.CelularTextBox.TabIndex = 117
        '
        'EsloganTextBox
        '
        Me.EsloganTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Eslogan", True))
        Me.EsloganTextBox.Location = New System.Drawing.Point(12, 430)
        Me.EsloganTextBox.Multiline = True
        Me.EsloganTextBox.Name = "EsloganTextBox"
        Me.EsloganTextBox.Size = New System.Drawing.Size(346, 85)
        Me.EsloganTextBox.TabIndex = 119
        '
        'ServiciosTextBox
        '
        Me.ServiciosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Servicios", True))
        Me.ServiciosTextBox.Location = New System.Drawing.Point(12, 540)
        Me.ServiciosTextBox.Multiline = True
        Me.ServiciosTextBox.Name = "ServiciosTextBox"
        Me.ServiciosTextBox.Size = New System.Drawing.Size(346, 89)
        Me.ServiciosTextBox.TabIndex = 121
        '
        'MisionTextBox
        '
        Me.MisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Mision", True))
        Me.MisionTextBox.Location = New System.Drawing.Point(364, 94)
        Me.MisionTextBox.Multiline = True
        Me.MisionTextBox.Name = "MisionTextBox"
        Me.MisionTextBox.Size = New System.Drawing.Size(349, 138)
        Me.MisionTextBox.TabIndex = 123
        '
        'VisionTextBox
        '
        Me.VisionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "Vision", True))
        Me.VisionTextBox.Location = New System.Drawing.Point(364, 265)
        Me.VisionTextBox.Multiline = True
        Me.VisionTextBox.Name = "VisionTextBox"
        Me.VisionTextBox.Size = New System.Drawing.Size(349, 138)
        Me.VisionTextBox.TabIndex = 125
        '
        'EmpresaIdTextBox
        '
        Me.EmpresaIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "EmpresaId", True))
        Me.EmpresaIdTextBox.Location = New System.Drawing.Point(950, 204)
        Me.EmpresaIdTextBox.Name = "EmpresaIdTextBox"
        Me.EmpresaIdTextBox.Size = New System.Drawing.Size(100, 28)
        Me.EmpresaIdTextBox.TabIndex = 127
        '
        'TipoDeDocumentoIdTextBoxBase
        '
        Me.TipoDeDocumentoIdTextBoxBase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleEmpresaViewBindingSource, "TipoDeDocumentoId", True))
        Me.TipoDeDocumentoIdTextBoxBase.Location = New System.Drawing.Point(950, 270)
        Me.TipoDeDocumentoIdTextBoxBase.Name = "TipoDeDocumentoIdTextBoxBase"
        Me.TipoDeDocumentoIdTextBoxBase.Size = New System.Drawing.Size(100, 28)
        Me.TipoDeDocumentoIdTextBoxBase.TabIndex = 129
        '
        'ImagenPictureBox
        '
        Me.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImagenPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.PleEmpresaViewBindingSource, "ImagenEmpresa", True))
        Me.ImagenPictureBox.Location = New System.Drawing.Point(364, 430)
        Me.ImagenPictureBox.Name = "ImagenPictureBox"
        Me.ImagenPictureBox.Size = New System.Drawing.Size(212, 199)
        Me.ImagenPictureBox.TabIndex = 130
        Me.ImagenPictureBox.TabStop = False
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.Image = Global.GeneradorCod.My.Resources.Resources.System_pictures_icon
        Me.BtnCargarImagen.Location = New System.Drawing.Point(586, 430)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(48, 40)
        Me.BtnCargarImagen.TabIndex = 131
        Me.BtnCargarImagen.UseVisualStyleBackColor = True
        '
        'CboTipoDeDocumentoIdTextBox
        '
        Me.CboTipoDeDocumentoIdTextBox.DataSource = Me.PleTipoDeDocumentoBindingSource
        Me.CboTipoDeDocumentoIdTextBox.DisplayMember = "NombreTipoDocumento"
        Me.CboTipoDeDocumentoIdTextBox.FormattingEnabled = True
        Me.CboTipoDeDocumentoIdTextBox.Location = New System.Drawing.Point(12, 150)
        Me.CboTipoDeDocumentoIdTextBox.Name = "CboTipoDeDocumentoIdTextBox"
        Me.CboTipoDeDocumentoIdTextBox.Size = New System.Drawing.Size(345, 29)
        Me.CboTipoDeDocumentoIdTextBox.TabIndex = 132
        Me.CboTipoDeDocumentoIdTextBox.ValueMember = "NombreTipoDocumento"
        '
        'PleTipoDeDocumentoBindingSource
        '
        Me.PleTipoDeDocumentoBindingSource.DataMember = "PleTipoDeDocumento"
        Me.PleTipoDeDocumentoBindingSource.DataSource = Me.DataSetMaestros
        '
        'TipoDeDocumentoIdTextBoxTabla
        '
        Me.TipoDeDocumentoIdTextBoxTabla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleTipoDeDocumentoBindingSource, "TipoDeDocumentoId", True))
        Me.TipoDeDocumentoIdTextBoxTabla.Location = New System.Drawing.Point(950, 304)
        Me.TipoDeDocumentoIdTextBoxTabla.Name = "TipoDeDocumentoIdTextBoxTabla"
        Me.TipoDeDocumentoIdTextBoxTabla.Size = New System.Drawing.Size(100, 28)
        Me.TipoDeDocumentoIdTextBoxTabla.TabIndex = 133
        '
        'SP_PleEmpresa_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_PleEmpresa_EDICION_ACTUALIZARBindingSource.DataMember = "SP_PleEmpresa_EDICION_ACTUALIZAR"
        Me.SP_PleEmpresa_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleEmpresa_EDICION_ELIMINARBindingSource
        '
        Me.SP_PleEmpresa_EDICION_ELIMINARBindingSource.DataMember = "SP_PleEmpresa_EDICION_ELIMINAR"
        Me.SP_PleEmpresa_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleEmpresa_EDICION_ELIMINARTableAdapter
        '
        Me.SP_PleEmpresa_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleEmpresa_EDICION_INSERTARBindingSource
        '
        Me.SP_PleEmpresa_EDICION_INSERTARBindingSource.DataMember = "SP_PleEmpresa_EDICION_INSERTAR"
        Me.SP_PleEmpresa_EDICION_INSERTARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleEmpresa_EDICION_INSERTARTableAdapter
        '
        Me.SP_PleEmpresa_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'Panel24
        '
        Me.Panel24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel24.Controls.Add(Me.RbZoom)
        Me.Panel24.Controls.Add(Me.RbCentrada)
        Me.Panel24.Controls.Add(Me.RbAjustado)
        Me.Panel24.Controls.Add(Me.RbNormal)
        Me.Panel24.Location = New System.Drawing.Point(586, 491)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(127, 138)
        Me.Panel24.TabIndex = 147
        '
        'RbZoom
        '
        Me.RbZoom.AutoSize = True
        Me.RbZoom.Location = New System.Drawing.Point(17, 98)
        Me.RbZoom.Name = "RbZoom"
        Me.RbZoom.Size = New System.Drawing.Size(69, 25)
        Me.RbZoom.TabIndex = 147
        Me.RbZoom.Text = "Zoom"
        Me.RbZoom.UseVisualStyleBackColor = True
        '
        'RbCentrada
        '
        Me.RbCentrada.AutoSize = True
        Me.RbCentrada.Location = New System.Drawing.Point(17, 67)
        Me.RbCentrada.Name = "RbCentrada"
        Me.RbCentrada.Size = New System.Drawing.Size(91, 25)
        Me.RbCentrada.TabIndex = 145
        Me.RbCentrada.Text = "Centrada"
        Me.RbCentrada.UseVisualStyleBackColor = True
        '
        'RbAjustado
        '
        Me.RbAjustado.AutoSize = True
        Me.RbAjustado.Checked = True
        Me.RbAjustado.Location = New System.Drawing.Point(17, 40)
        Me.RbAjustado.Name = "RbAjustado"
        Me.RbAjustado.Size = New System.Drawing.Size(89, 25)
        Me.RbAjustado.TabIndex = 144
        Me.RbAjustado.TabStop = True
        Me.RbAjustado.Text = "Ajustado"
        Me.RbAjustado.UseVisualStyleBackColor = True
        '
        'RbNormal
        '
        Me.RbNormal.AutoSize = True
        Me.RbNormal.Location = New System.Drawing.Point(17, 13)
        Me.RbNormal.Name = "RbNormal"
        Me.RbNormal.Size = New System.Drawing.Size(81, 25)
        Me.RbNormal.TabIndex = 143
        Me.RbNormal.Text = "Normal"
        Me.RbNormal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 21)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Tipo de documento"
        '
        'FrmPleEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1088, 640)
        Me.Controls.Add(Me.PleEmpresaViewDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(TipoDeDocumentoIdLabel1)
        Me.Controls.Add(Me.TipoDeDocumentoIdTextBoxTabla)
        Me.Controls.Add(Me.CboTipoDeDocumentoIdTextBox)
        Me.Controls.Add(Me.BtnCargarImagen)
        Me.Controls.Add(ImagenEmpresaLabel)
        Me.Controls.Add(Me.ImagenPictureBox)
        Me.Controls.Add(NombreEmpresaLabel)
        Me.Controls.Add(Me.NombreEmpresaTextBox)
        Me.Controls.Add(NombreTipoDocumentoLabel)
        Me.Controls.Add(Me.NombreTipoDeDocumentoIdBase)
        Me.Controls.Add(DocumentoLabel)
        Me.Controls.Add(Me.DocumentoTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.TelefonoTextBox)
        Me.Controls.Add(CelularLabel)
        Me.Controls.Add(Me.CelularTextBox)
        Me.Controls.Add(EsloganLabel)
        Me.Controls.Add(Me.EsloganTextBox)
        Me.Controls.Add(ServiciosLabel)
        Me.Controls.Add(Me.ServiciosTextBox)
        Me.Controls.Add(MisionLabel)
        Me.Controls.Add(Me.MisionTextBox)
        Me.Controls.Add(VisionLabel)
        Me.Controls.Add(Me.VisionTextBox)
        Me.Controls.Add(EmpresaIdLabel)
        Me.Controls.Add(Me.EmpresaIdTextBox)
        Me.Controls.Add(TipoDeDocumentoIdLabel)
        Me.Controls.Add(Me.TipoDeDocumentoIdTextBoxBase)
        Me.Controls.Add(Me.ValidarCierre)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPleEmpresa"
        Me.Text = "FrmPleEmpresa"
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleEmpresaViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleEmpresaViewDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleEmpresa_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleEmpresa_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleEmpresa_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Salir_Menu_PleEmpresa As Button
    Friend WithEvents Nuevo_Menu_PleEmpresa As Button
    Friend WithEvents Cancelar_Menu_PleEmpresa As Button
    Friend WithEvents Eliminar_Menu_PleEmpresa As Button
    Friend WithEvents Editar_Menu_PleEmpresa As Button
    Friend WithEvents Actualizar_Menu_PleEmpresa As Button
    Friend WithEvents Guardar_Menu_PleEmpresa As Button
    Friend WithEvents ValidarCierre As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents DataSetMaestros As DataSetMaestros
    Friend WithEvents PleEmpresaViewBindingSource As BindingSource
    Friend WithEvents PleEmpresaViewTableAdapter As DataSetMaestrosTableAdapters.PleEmpresaViewTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMaestrosTableAdapters.TableAdapterManager
    Friend WithEvents PleTipoDeDocumentoTableAdapter As DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter
    Friend WithEvents PleEmpresaViewDataGridView As DataGridView
    Friend WithEvents NombreEmpresaTextBox As TextBox
    Friend WithEvents NombreTipoDeDocumentoIdBase As TextBox
    Friend WithEvents DocumentoTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CelularTextBox As TextBox
    Friend WithEvents EsloganTextBox As TextBox
    Friend WithEvents ServiciosTextBox As TextBox
    Friend WithEvents MisionTextBox As TextBox
    Friend WithEvents VisionTextBox As TextBox
    Friend WithEvents EmpresaIdTextBox As TextBox
    Friend WithEvents TipoDeDocumentoIdTextBoxBase As TextBox
    Friend WithEvents ImagenPictureBox As PictureBox
    Friend WithEvents BtnCargarImagen As Button
    Friend WithEvents CboTipoDeDocumentoIdTextBox As ComboBox
    Friend WithEvents PleTipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents TipoDeDocumentoIdTextBoxTabla As TextBox
    Friend WithEvents SP_PleEmpresa_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter As DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_PleEmpresa_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_PleEmpresa_EDICION_ELIMINARTableAdapter As DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_PleEmpresa_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_PleEmpresa_EDICION_INSERTARTableAdapter As DataSetMaestrosTableAdapters.SP_PleEmpresa_EDICION_INSERTARTableAdapter
    Friend WithEvents Panel24 As Panel
    Friend WithEvents RbZoom As RadioButton
    Friend WithEvents RbCentrada As RadioButton
    Friend WithEvents RbAjustado As RadioButton
    Friend WithEvents RbNormal As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
