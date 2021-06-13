<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEdicionCampos
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
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim ComponenteIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel1 As System.Windows.Forms.Label
        Dim SeparadorCamposLabel As System.Windows.Forms.Label
        Dim FormatoCampoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TecnologiasTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TecnologiasTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.RbMultiReplace = New System.Windows.Forms.RadioButton()
        Me.RbSufijo = New System.Windows.Forms.RadioButton()
        Me.RbInferior = New System.Windows.Forms.RadioButton()
        Me.RbPrefijo = New System.Windows.Forms.RadioButton()
        Me.RBSuperior = New System.Windows.Forms.RadioButton()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnCarga = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.FormatoCampoTextBox = New System.Windows.Forms.TextBox()
        Me.MultiReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.SeparadorCamposTextBox = New System.Windows.Forms.TextBox()
        Me.InferiorTextBox = New System.Windows.Forms.TextBox()
        Me.SufijoTextBox = New System.Windows.Forms.TextBox()
        Me.SuperiorTextBox = New System.Windows.Forms.TextBox()
        Me.PrefijoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CampoComponenteID = New System.Windows.Forms.TextBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.ComponenteIDTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter()
        Me.Timer_Acciones = New System.Windows.Forms.Timer(Me.components)
        Me.BtnImprimeCampo = New System.Windows.Forms.Button()
        Me.BtnImprimeMascara = New System.Windows.Forms.Button()
        Me.BtnUpdateCer = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ELIMINARTableAdapter()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        ComponenteIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel1 = New System.Windows.Forms.Label()
        SeparadorCamposLabel = New System.Windows.Forms.Label()
        FormatoCampoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(208, 9)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(105, 21)
        TecnologiaIDLabel.TabIndex = 2
        TecnologiaIDLabel.Text = "Tecnologia ID:"
        '
        'ComponenteIDLabel
        '
        ComponenteIDLabel.AutoSize = True
        ComponenteIDLabel.Location = New System.Drawing.Point(425, 9)
        ComponenteIDLabel.Name = "ComponenteIDLabel"
        ComponenteIDLabel.Size = New System.Drawing.Size(122, 21)
        ComponenteIDLabel.TabIndex = 4
        ComponenteIDLabel.Text = "Componente ID:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(659, 9)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(87, 21)
        PlantillaIDLabel.TabIndex = 5
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'PlantillaIDLabel1
        '
        PlantillaIDLabel1.AutoSize = True
        PlantillaIDLabel1.Location = New System.Drawing.Point(9, 9)
        PlantillaIDLabel1.Name = "PlantillaIDLabel1"
        PlantillaIDLabel1.Size = New System.Drawing.Size(87, 21)
        PlantillaIDLabel1.TabIndex = 7
        PlantillaIDLabel1.Text = "Plantilla ID:"
        '
        'SeparadorCamposLabel
        '
        SeparadorCamposLabel.AutoSize = True
        SeparadorCamposLabel.Location = New System.Drawing.Point(650, 53)
        SeparadorCamposLabel.Name = "SeparadorCamposLabel"
        SeparadorCamposLabel.Size = New System.Drawing.Size(146, 21)
        SeparadorCamposLabel.TabIndex = 9
        SeparadorCamposLabel.Text = "Separador Campos:"
        '
        'FormatoCampoLabel
        '
        FormatoCampoLabel.AutoSize = True
        FormatoCampoLabel.Location = New System.Drawing.Point(933, 53)
        FormatoCampoLabel.Name = "FormatoCampoLabel"
        FormatoCampoLabel.Size = New System.Drawing.Size(126, 21)
        FormatoCampoLabel.TabIndex = 13
        FormatoCampoLabel.Text = "Formato Campo:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(293, 53)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(43, 21)
        TipoLabel.TabIndex = 15
        TipoLabel.Text = "Tipo:"
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TecnologiasTableAdapter
        '
        Me.TecnologiasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ELIMINA_SEGUN_PROYECTOTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Nothing
        Me.TableAdapterManager.SP_ActualizaValoresDeTiposTableAdapter = Nothing
        Me.TableAdapterManager.SP_ComponenteArchivoEliminar_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ComponenteArchivoEliminar_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ComponenteArchivoEliminar_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantilla_PoneTrueTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZAR_XBase_PorPlantillaTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Componentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ACTUALIZAR_SOLO_SELECCIONADATableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Plantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasCreacionDeArchivos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasCreacionDeArchivos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasCreacionDeArchivos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasMetricas_EDICION_EDITAR_SEGUN_PLANTILLATableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasMetricas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasMetricas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasVentajasTecnologicas_EDICION_EDITARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasVentajasTecnologicas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_PlantillasVentajasTecnologicas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZAR_SOLO_SELECCIONADATableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoCarpetasArchivos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoCarpetasArchivos_EDICION_ELIMINAR_SEGUN_ProyectoIDTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoCarpetasArchivos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Proyectos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Prueba_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosPlantillas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tecnologias_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_TecnologiasConCreacion_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_TecnologiasConCreacion_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_TecnologiaVideo_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_TecnologiaVideo_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_TecnologiaVideo_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_Tipos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.TecnologiasTableAdapter = Me.TecnologiasTableAdapter
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(7, 8)
        Me.TecnologiasDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(481, 537)
        Me.TecnologiasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 477
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(495, 8)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(671, 271)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Orden"
        Me.DataGridViewTextBoxColumn5.HeaderText = "#"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 567
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(319, 6)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.ReadOnly = True
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.TecnologiaIDTextBox.TabIndex = 3
        Me.TecnologiaIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 80)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1180, 537)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.TabPage1.Controls.Add(Me.TecnologiasDataGridView)
        Me.TabPage1.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1172, 503)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tecnologias"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(495, 285)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(671, 212)
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ComponenteID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Componente ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre Componente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 517
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LblInforme)
        Me.TabPage2.Controls.Add(Me.RbMultiReplace)
        Me.TabPage2.Controls.Add(Me.RbSufijo)
        Me.TabPage2.Controls.Add(Me.RbInferior)
        Me.TabPage2.Controls.Add(Me.RbPrefijo)
        Me.TabPage2.Controls.Add(Me.RBSuperior)
        Me.TabPage2.Controls.Add(TipoLabel)
        Me.TabPage2.Controls.Add(Me.TipoTextBox)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.FormatoCampoTextBox)
        Me.TabPage2.Controls.Add(Me.MultiReplaceTextBox)
        Me.TabPage2.Controls.Add(SeparadorCamposLabel)
        Me.TabPage2.Controls.Add(Me.SeparadorCamposTextBox)
        Me.TabPage2.Controls.Add(FormatoCampoLabel)
        Me.TabPage2.Controls.Add(Me.InferiorTextBox)
        Me.TabPage2.Controls.Add(Me.SufijoTextBox)
        Me.TabPage2.Controls.Add(Me.SuperiorTextBox)
        Me.TabPage2.Controls.Add(Me.PrefijoTextBox)
        Me.TabPage2.Controls.Add(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1172, 503)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contenido Campos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(562, 219)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(284, 64)
        Me.LblInforme.TabIndex = 17
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInforme.Visible = False
        '
        'RbMultiReplace
        '
        Me.RbMultiReplace.AutoSize = True
        Me.RbMultiReplace.Location = New System.Drawing.Point(923, 87)
        Me.RbMultiReplace.Name = "RbMultiReplace"
        Me.RbMultiReplace.Size = New System.Drawing.Size(122, 25)
        Me.RbMultiReplace.TabIndex = 22
        Me.RbMultiReplace.TabStop = True
        Me.RbMultiReplace.Text = "Multi Replace"
        Me.RbMultiReplace.UseVisualStyleBackColor = True
        '
        'RbSufijo
        '
        Me.RbSufijo.AutoSize = True
        Me.RbSufijo.Location = New System.Drawing.Point(704, 211)
        Me.RbSufijo.Name = "RbSufijo"
        Me.RbSufijo.Size = New System.Drawing.Size(68, 25)
        Me.RbSufijo.TabIndex = 21
        Me.RbSufijo.TabStop = True
        Me.RbSufijo.Text = "Sufijo"
        Me.RbSufijo.UseVisualStyleBackColor = True
        '
        'RbInferior
        '
        Me.RbInferior.AutoSize = True
        Me.RbInferior.Location = New System.Drawing.Point(499, 472)
        Me.RbInferior.Name = "RbInferior"
        Me.RbInferior.Size = New System.Drawing.Size(79, 25)
        Me.RbInferior.TabIndex = 20
        Me.RbInferior.TabStop = True
        Me.RbInferior.Text = "Inferior"
        Me.RbInferior.UseVisualStyleBackColor = True
        '
        'RbPrefijo
        '
        Me.RbPrefijo.AutoSize = True
        Me.RbPrefijo.Location = New System.Drawing.Point(290, 211)
        Me.RbPrefijo.Name = "RbPrefijo"
        Me.RbPrefijo.Size = New System.Drawing.Size(73, 25)
        Me.RbPrefijo.TabIndex = 19
        Me.RbPrefijo.TabStop = True
        Me.RbPrefijo.Text = "Prefijo"
        Me.RbPrefijo.UseVisualStyleBackColor = True
        '
        'RBSuperior
        '
        Me.RBSuperior.AutoSize = True
        Me.RBSuperior.Location = New System.Drawing.Point(499, 88)
        Me.RBSuperior.Name = "RBSuperior"
        Me.RBSuperior.Size = New System.Drawing.Size(88, 25)
        Me.RBSuperior.TabIndex = 18
        Me.RBSuperior.TabStop = True
        Me.RBSuperior.Text = "Superior"
        Me.RBSuperior.UseVisualStyleBackColor = True
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(342, 49)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(302, 29)
        Me.TipoTextBox.TabIndex = 16
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource.DataMember = "SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteID"
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Controls.Add(Me.BtnCarga)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(281, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 41)
        Me.Panel1.TabIndex = 15
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnUpdate.Location = New System.Drawing.Point(15, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(762, 33)
        Me.BtnUpdate.TabIndex = 18
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnCarga
        '
        Me.BtnCarga.BackColor = System.Drawing.Color.Gold
        Me.BtnCarga.Location = New System.Drawing.Point(783, 2)
        Me.BtnCarga.Name = "BtnCarga"
        Me.BtnCarga.Size = New System.Drawing.Size(47, 33)
        Me.BtnCarga.TabIndex = 17
        Me.BtnCarga.Text = "Car"
        Me.BtnCarga.UseVisualStyleBackColor = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.GreenYellow
        Me.BtnMinimizar.Location = New System.Drawing.Point(836, 3)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(47, 33)
        Me.BtnMinimizar.TabIndex = 16
        Me.BtnMinimizar.Text = "Min"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'FormatoCampoTextBox
        '
        Me.FormatoCampoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "FormatoCampo", True))
        Me.FormatoCampoTextBox.Location = New System.Drawing.Point(1065, 49)
        Me.FormatoCampoTextBox.Name = "FormatoCampoTextBox"
        Me.FormatoCampoTextBox.ReadOnly = True
        Me.FormatoCampoTextBox.Size = New System.Drawing.Size(100, 29)
        Me.FormatoCampoTextBox.TabIndex = 14
        Me.FormatoCampoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MultiReplaceTextBox
        '
        Me.MultiReplaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "MultiReplace", True))
        Me.MultiReplaceTextBox.Location = New System.Drawing.Point(778, 115)
        Me.MultiReplaceTextBox.Multiline = True
        Me.MultiReplaceTextBox.Name = "MultiReplaceTextBox"
        Me.MultiReplaceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MultiReplaceTextBox.Size = New System.Drawing.Size(387, 379)
        Me.MultiReplaceTextBox.TabIndex = 12
        '
        'SeparadorCamposTextBox
        '
        Me.SeparadorCamposTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "SeparadorCampos", True))
        Me.SeparadorCamposTextBox.Location = New System.Drawing.Point(802, 49)
        Me.SeparadorCamposTextBox.Name = "SeparadorCamposTextBox"
        Me.SeparadorCamposTextBox.Size = New System.Drawing.Size(100, 29)
        Me.SeparadorCamposTextBox.TabIndex = 10
        '
        'InferiorTextBox
        '
        Me.InferiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Inferior", True))
        Me.InferiorTextBox.Location = New System.Drawing.Point(416, 370)
        Me.InferiorTextBox.Multiline = True
        Me.InferiorTextBox.Name = "InferiorTextBox"
        Me.InferiorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InferiorTextBox.Size = New System.Drawing.Size(228, 100)
        Me.InferiorTextBox.TabIndex = 8
        '
        'SufijoTextBox
        '
        Me.SufijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Sufijo", True))
        Me.SufijoTextBox.Location = New System.Drawing.Point(544, 239)
        Me.SufijoTextBox.Multiline = True
        Me.SufijoTextBox.Name = "SufijoTextBox"
        Me.SufijoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SufijoTextBox.Size = New System.Drawing.Size(228, 100)
        Me.SufijoTextBox.TabIndex = 6
        '
        'SuperiorTextBox
        '
        Me.SuperiorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Superior", True))
        Me.SuperiorTextBox.Location = New System.Drawing.Point(416, 116)
        Me.SuperiorTextBox.Multiline = True
        Me.SuperiorTextBox.Name = "SuperiorTextBox"
        Me.SuperiorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SuperiorTextBox.Size = New System.Drawing.Size(228, 100)
        Me.SuperiorTextBox.TabIndex = 4
        '
        'PrefijoTextBox
        '
        Me.PrefijoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "Prefijo", True))
        Me.PrefijoTextBox.Location = New System.Drawing.Point(290, 239)
        Me.PrefijoTextBox.Multiline = True
        Me.PrefijoTextBox.Name = "PrefijoTextBox"
        Me.PrefijoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrefijoTextBox.Size = New System.Drawing.Size(228, 100)
        Me.PrefijoTextBox.TabIndex = 2
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.AllowUserToAddRows = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.AutoGenerateColumns = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.DataSource = Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.Dock = System.Windows.Forms.DockStyle.Left
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.Name = "SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView" &
    ""
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.RowHeadersVisible = False
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.Size = New System.Drawing.Size(278, 497)
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 274
        '
        'CampoComponenteID
        '
        Me.CampoComponenteID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, "CampoComponenteID", True))
        Me.CampoComponenteID.Location = New System.Drawing.Point(858, 6)
        Me.CampoComponenteID.Name = "CampoComponenteID"
        Me.CampoComponenteID.Size = New System.Drawing.Size(61, 29)
        Me.CampoComponenteID.TabIndex = 17
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'ComponenteIDTextBox
        '
        Me.ComponenteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "ComponenteID", True))
        Me.ComponenteIDTextBox.Location = New System.Drawing.Point(553, 6)
        Me.ComponenteIDTextBox.Name = "ComponenteIDTextBox"
        Me.ComponenteIDTextBox.ReadOnly = True
        Me.ComponenteIDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.ComponenteIDTextBox.TabIndex = 5
        Me.ComponenteIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(752, 6)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.ReadOnly = True
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.PlantillaIDTextBox.TabIndex = 6
        Me.PlantillaIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlantillaIDTextBox1
        '
        Me.PlantillaIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox1.Location = New System.Drawing.Point(102, 6)
        Me.PlantillaIDTextBox1.Name = "PlantillaIDTextBox1"
        Me.PlantillaIDTextBox1.ReadOnly = True
        Me.PlantillaIDTextBox1.Size = New System.Drawing.Size(100, 29)
        Me.PlantillaIDTextBox1.TabIndex = 8
        Me.PlantillaIDTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter
        '
        Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_INSERTAR_PARA_DUPLICADOTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoComponentes_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoEspecial_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoEspecial_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CampoEspecial_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesContenidoProvisional_Base_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesContenidoProvisional_Base_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesParaTablas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesParaTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ComponentesParaTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TablasRelacionadas_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager1.SP_TextoEnriquecido_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager1.TablasRelacionadasTiposTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_CampoComponentes_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource.DataMember = "SP_CampoComponentes_EDICION_ACTUALIZAR"
        Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'Timer_Acciones
        '
        '
        'BtnImprimeCampo
        '
        Me.BtnImprimeCampo.BackColor = System.Drawing.Color.White
        Me.BtnImprimeCampo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnImprimeCampo.ForeColor = System.Drawing.Color.Chocolate
        Me.BtnImprimeCampo.Location = New System.Drawing.Point(983, 5)
        Me.BtnImprimeCampo.Name = "BtnImprimeCampo"
        Me.BtnImprimeCampo.Size = New System.Drawing.Size(100, 30)
        Me.BtnImprimeCampo.TabIndex = 126
        Me.BtnImprimeCampo.Text = "Campo"
        Me.BtnImprimeCampo.UseVisualStyleBackColor = False
        '
        'BtnImprimeMascara
        '
        Me.BtnImprimeMascara.BackColor = System.Drawing.Color.White
        Me.BtnImprimeMascara.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnImprimeMascara.ForeColor = System.Drawing.Color.Chocolate
        Me.BtnImprimeMascara.Location = New System.Drawing.Point(1089, 6)
        Me.BtnImprimeMascara.Name = "BtnImprimeMascara"
        Me.BtnImprimeMascara.Size = New System.Drawing.Size(100, 30)
        Me.BtnImprimeMascara.TabIndex = 127
        Me.BtnImprimeMascara.Text = "CamMasc"
        Me.BtnImprimeMascara.UseVisualStyleBackColor = False
        '
        'BtnUpdateCer
        '
        Me.BtnUpdateCer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnUpdateCer.Location = New System.Drawing.Point(983, 41)
        Me.BtnUpdateCer.Name = "BtnUpdateCer"
        Me.BtnUpdateCer.Size = New System.Drawing.Size(205, 33)
        Me.BtnUpdateCer.TabIndex = 23
        Me.BtnUpdateCer.Text = "Update"
        Me.BtnUpdateCer.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Red
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnEliminar.Location = New System.Drawing.Point(925, 6)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(52, 29)
        Me.BtnEliminar.TabIndex = 128
        Me.BtnEliminar.Text = "X"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'SP_CampoComponentes_EDICION_ELIMINARBindingSource
        '
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource.DataMember = "SP_CampoComponentes_EDICION_ELIMINAR"
        Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CampoComponentes_EDICION_ELIMINARTableAdapter
        '
        Me.SP_CampoComponentes_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'FrmEdicionCampos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 627)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnUpdateCer)
        Me.Controls.Add(Me.BtnImprimeMascara)
        Me.Controls.Add(Me.BtnImprimeCampo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(PlantillaIDLabel1)
        Me.Controls.Add(Me.PlantillaIDTextBox)
        Me.Controls.Add(Me.CampoComponenteID)
        Me.Controls.Add(Me.PlantillaIDTextBox1)
        Me.Controls.Add(TecnologiaIDLabel)
        Me.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Controls.Add(ComponenteIDLabel)
        Me.Controls.Add(Me.ComponenteIDTextBox)
        Me.Controls.Add(PlantillaIDLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmEdicionCampos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edición Campos"
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CampoComponentes_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents TecnologiasBindingSource As BindingSource
    Friend WithEvents TecnologiasTableAdapter As DataSetAdministracionTableAdapters.TecnologiasTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents TecnologiasDataGridView As DataGridView
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView As DataGridView
    Friend WithEvents TecnologiaIDTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents ComponenteIDTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents PlantillaIDTextBox1 As TextBox
    Friend WithEvents DataSetTablasYCampos As DataSetTablasYCampos
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetTablasYCamposTableAdapters.TableAdapterManager
    Friend WithEvents FormatoCampoTextBox As TextBox
    Friend WithEvents MultiReplaceTextBox As TextBox
    Friend WithEvents SeparadorCamposTextBox As TextBox
    Friend WithEvents InferiorTextBox As TextBox
    Friend WithEvents SufijoTextBox As TextBox
    Friend WithEvents SuperiorTextBox As TextBox
    Friend WithEvents PrefijoTextBox As TextBox
    Friend WithEvents SP_CampoComponentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID_ComponenteIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCarga As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents SP_CampoComponentes_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents Timer_Acciones As Timer
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CampoComponenteID As TextBox
    Friend WithEvents BtnImprimeCampo As Button
    Friend WithEvents BtnImprimeMascara As Button
    Friend WithEvents RBSuperior As RadioButton
    Friend WithEvents RbMultiReplace As RadioButton
    Friend WithEvents RbSufijo As RadioButton
    Friend WithEvents RbInferior As RadioButton
    Friend WithEvents RbPrefijo As RadioButton
    Friend WithEvents BtnUpdateCer As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents SP_CampoComponentes_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_CampoComponentes_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CampoComponentes_EDICION_ELIMINARTableAdapter
End Class
