<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConfiguracion
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
        Dim TipoLabel As System.Windows.Forms.Label
        Dim TipoIDLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ValorActual = New System.Windows.Forms.TextBox()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.TiposDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoIDTextBox = New System.Windows.Forms.TextBox()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Tipos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Tipos = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Tipos = New System.Windows.Forms.Button()
        Me.Editar_Menu_Tipos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Tipos = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Tipos = New System.Windows.Forms.Button()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TiposTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TiposTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.SP_Tipos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tipos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tipos_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Tipos_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tipos_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tipos_EDICION_ELIMINARTableAdapter()
        Me.SP_Tipos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Tipos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Tipos_EDICION_INSERTARTableAdapter()
        Me.SP_ActualizaValoresDeTiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ActualizaValoresDeTiposTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ActualizaValoresDeTiposTableAdapter()
        TipoLabel = New System.Windows.Forms.Label()
        TipoIDLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiposDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.SP_Tipos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Tipos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Tipos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ActualizaValoresDeTiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        TipoLabel.Location = New System.Drawing.Point(6, 61)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(43, 21)
        TipoLabel.TabIndex = 1
        TipoLabel.Text = "Tipo:"
        '
        'TipoIDLabel
        '
        TipoIDLabel.AutoSize = True
        TipoIDLabel.Location = New System.Drawing.Point(411, 399)
        TipoIDLabel.Name = "TipoIDLabel"
        TipoIDLabel.Size = New System.Drawing.Size(41, 13)
        TipoIDLabel.TabIndex = 93
        TipoIDLabel.Text = "tipo ID:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(632, 538)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.TiposDataGridView)
        Me.TabPage1.Controls.Add(Me.ValorActual)
        Me.TabPage1.Controls.Add(TipoIDLabel)
        Me.TabPage1.Controls.Add(Me.TipoIDTextBox)
        Me.TabPage1.Controls.Add(Me.ControlNulos)
        Me.TabPage1.Controls.Add(Me.PanelAdministracion_)
        Me.TabPage1.Controls.Add(TipoLabel)
        Me.TabPage1.Controls.Add(Me.TipoTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(624, 512)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tipos de Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ValorActual
        '
        Me.ValorActual.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Tipo", True))
        Me.ValorActual.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.ValorActual.Location = New System.Drawing.Point(54, 91)
        Me.ValorActual.Name = "ValorActual"
        Me.ValorActual.Size = New System.Drawing.Size(564, 28)
        Me.ValorActual.TabIndex = 95
        '
        'TiposBindingSource
        '
        Me.TiposBindingSource.DataMember = "Tipos"
        Me.TiposBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TiposDataGridView
        '
        Me.TiposDataGridView.AllowUserToAddRows = False
        Me.TiposDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TiposDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TiposDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TiposDataGridView.DataSource = Me.TiposBindingSource
        Me.TiposDataGridView.Location = New System.Drawing.Point(6, 91)
        Me.TiposDataGridView.Name = "TiposDataGridView"
        Me.TiposDataGridView.RowHeadersVisible = False
        Me.TiposDataGridView.Size = New System.Drawing.Size(612, 415)
        Me.TiposDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tipo"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 608
        '
        'TipoIDTextBox
        '
        Me.TipoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "tipoID", True))
        Me.TipoIDTextBox.Location = New System.Drawing.Point(458, 396)
        Me.TipoIDTextBox.Name = "TipoIDTextBox"
        Me.TipoIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TipoIDTextBox.TabIndex = 94
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(458, 422)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(100, 20)
        Me.ControlNulos.TabIndex = 93
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_Tipos)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_Tipos)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_Tipos)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_Tipos)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_Tipos)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_Tipos)
        Me.PanelAdministracion_.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdministracion_.Location = New System.Drawing.Point(3, 3)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(618, 46)
        Me.PanelAdministracion_.TabIndex = 91
        '
        'Nuevo_Menu_Tipos
        '
        Me.Nuevo_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Tipos.Image = CType(resources.GetObject("Nuevo_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Tipos.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_Tipos.Name = "Nuevo_Menu_Tipos"
        Me.Nuevo_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Tipos.TabIndex = 70
        Me.Nuevo_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Tipos
        '
        Me.Cancelar_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Tipos.Image = CType(resources.GetObject("Cancelar_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Tipos.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_Tipos.Name = "Cancelar_Menu_Tipos"
        Me.Cancelar_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Tipos.TabIndex = 75
        Me.Cancelar_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Tipos
        '
        Me.Eliminar_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Tipos.Image = CType(resources.GetObject("Eliminar_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Tipos.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_Tipos.Name = "Eliminar_Menu_Tipos"
        Me.Eliminar_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Tipos.TabIndex = 72
        Me.Eliminar_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Tipos
        '
        Me.Editar_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Tipos.Image = CType(resources.GetObject("Editar_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Editar_Menu_Tipos.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_Tipos.Name = "Editar_Menu_Tipos"
        Me.Editar_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Tipos.TabIndex = 74
        Me.Editar_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Tipos
        '
        Me.Actualizar_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Tipos.Image = CType(resources.GetObject("Actualizar_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Tipos.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_Tipos.Name = "Actualizar_Menu_Tipos"
        Me.Actualizar_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Tipos.TabIndex = 73
        Me.Actualizar_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Tipos
        '
        Me.Guardar_Menu_Tipos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Tipos.Image = CType(resources.GetObject("Guardar_Menu_Tipos.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Tipos.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_Tipos.Name = "Guardar_Menu_Tipos"
        Me.Guardar_Menu_Tipos.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Tipos.TabIndex = 71
        Me.Guardar_Menu_Tipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Tipos.UseVisualStyleBackColor = True
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Tipo", True))
        Me.TipoTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.TipoTextBox.Location = New System.Drawing.Point(54, 57)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(564, 28)
        Me.TipoTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipos de Datos"
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TecnologiasTableAdapter = Nothing
        Me.TableAdapterManager.TiposTableAdapter = Me.TiposTableAdapter
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_Tipos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Tipos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Tipos_EDICION_ACTUALIZAR"
        Me.SP_Tipos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tipos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Tipos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tipos_EDICION_ELIMINARBindingSource
        '
        Me.SP_Tipos_EDICION_ELIMINARBindingSource.DataMember = "SP_Tipos_EDICION_ELIMINAR"
        Me.SP_Tipos_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tipos_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Tipos_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Tipos_EDICION_INSERTARBindingSource
        '
        Me.SP_Tipos_EDICION_INSERTARBindingSource.DataMember = "SP_Tipos_EDICION_INSERTAR"
        Me.SP_Tipos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Tipos_EDICION_INSERTARTableAdapter
        '
        Me.SP_Tipos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_ActualizaValoresDeTiposBindingSource
        '
        Me.SP_ActualizaValoresDeTiposBindingSource.DataMember = "SP_ActualizaValoresDeTipos"
        Me.SP_ActualizaValoresDeTiposBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ActualizaValoresDeTiposTableAdapter
        '
        Me.SP_ActualizaValoresDeTiposTableAdapter.ClearBeforeFill = True
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 595)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipos de Datos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiposDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.SP_Tipos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Tipos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Tipos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ActualizaValoresDeTiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As DataSetAdministracionTableAdapters.TiposTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents TiposDataGridView As DataGridView
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_Tipos As Button
    Friend WithEvents Cancelar_Menu_Tipos As Button
    Friend WithEvents Eliminar_Menu_Tipos As Button
    Friend WithEvents Editar_Menu_Tipos As Button
    Friend WithEvents Actualizar_Menu_Tipos As Button
    Friend WithEvents Guardar_Menu_Tipos As Button
    Friend WithEvents SP_Tipos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Tipos_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Tipos_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Tipos_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Tipos_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Tipos_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Tipos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Tipos_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Tipos_EDICION_INSERTARTableAdapter
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents TipoIDTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ValorActual As TextBox
    Friend WithEvents SP_ActualizaValoresDeTiposBindingSource As BindingSource
    Friend WithEvents SP_ActualizaValoresDeTiposTableAdapter As DataSetAdministracionTableAdapters.SP_ActualizaValoresDeTiposTableAdapter
End Class
