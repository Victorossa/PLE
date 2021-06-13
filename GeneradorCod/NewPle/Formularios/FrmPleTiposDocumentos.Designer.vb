<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPleTiposDocumentos
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
        Dim TipoDeDocumentoIdLabel As System.Windows.Forms.Label
        Dim NombreTipoDocumentoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPleTiposDocumentos))
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Salir_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Editar_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.Guardar_Menu_PleTipoDeDocumento = New System.Windows.Forms.Button()
        Me.ValidarCierre = New System.Windows.Forms.TextBox()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.DataSetMaestros = New GeneradorCod.DataSetMaestros()
        Me.PleTipoDeDocumentoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PleTipoDeDocumentoTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetMaestrosTableAdapters.TableAdapterManager()
        Me.PleTipoDeDocumentoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDeDocumentoIdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTipoDocumentoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter()
        Me.SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter()
        Me.SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter()
        TipoDeDocumentoIdLabel = New System.Windows.Forms.Label()
        NombreTipoDocumentoLabel = New System.Windows.Forms.Label()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PleTipoDeDocumentoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TipoDeDocumentoIdLabel
        '
        TipoDeDocumentoIdLabel.AutoSize = True
        TipoDeDocumentoIdLabel.Location = New System.Drawing.Point(416, 158)
        TipoDeDocumentoIdLabel.Name = "TipoDeDocumentoIdLabel"
        TipoDeDocumentoIdLabel.Size = New System.Drawing.Size(168, 21)
        TipoDeDocumentoIdLabel.TabIndex = 106
        TipoDeDocumentoIdLabel.Text = "Tipo De Documento Id:"
        '
        'NombreTipoDocumentoLabel
        '
        NombreTipoDocumentoLabel.AutoSize = True
        NombreTipoDocumentoLabel.Location = New System.Drawing.Point(14, 70)
        NombreTipoDocumentoLabel.Name = "NombreTipoDocumentoLabel"
        NombreTipoDocumentoLabel.Size = New System.Drawing.Size(190, 21)
        NombreTipoDocumentoLabel.TabIndex = 107
        NombreTipoDocumentoLabel.Text = "Nombre Tipo Documento:"
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Salir_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_PleTipoDeDocumento)
        Me.PanelAdministracion_.Location = New System.Drawing.Point(12, 12)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(351, 46)
        Me.PanelAdministracion_.TabIndex = 92
        '
        'Salir_Menu_PleTipoDeDocumento
        '
        Me.Salir_Menu_PleTipoDeDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir_Menu_PleTipoDeDocumento.BackColor = System.Drawing.Color.Transparent
        Me.Salir_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir_Menu_PleTipoDeDocumento.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Menu_PleTipoDeDocumento.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Salir_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Salir_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(306, 3)
        Me.Salir_Menu_PleTipoDeDocumento.Name = "Salir_Menu_PleTipoDeDocumento"
        Me.Salir_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Salir_Menu_PleTipoDeDocumento.TabIndex = 76
        Me.Salir_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Salir_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = False
        '
        'Nuevo_Menu_PleTipoDeDocumento
        '
        Me.Nuevo_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Nuevo_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Nuevo_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_PleTipoDeDocumento.Name = "Nuevo_Menu_PleTipoDeDocumento"
        Me.Nuevo_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_PleTipoDeDocumento.TabIndex = 70
        Me.Nuevo_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_PleTipoDeDocumento
        '
        Me.Cancelar_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancelar_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Cancelar_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_PleTipoDeDocumento.Name = "Cancelar_Menu_PleTipoDeDocumento"
        Me.Cancelar_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_PleTipoDeDocumento.TabIndex = 75
        Me.Cancelar_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_PleTipoDeDocumento
        '
        Me.Eliminar_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Eliminar_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_PleTipoDeDocumento.Name = "Eliminar_Menu_PleTipoDeDocumento"
        Me.Eliminar_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_PleTipoDeDocumento.TabIndex = 72
        Me.Eliminar_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'Editar_Menu_PleTipoDeDocumento
        '
        Me.Editar_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Editar_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Editar_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Editar_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_PleTipoDeDocumento.Name = "Editar_Menu_PleTipoDeDocumento"
        Me.Editar_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_PleTipoDeDocumento.TabIndex = 74
        Me.Editar_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_PleTipoDeDocumento
        '
        Me.Actualizar_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Actualizar_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Actualizar_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_PleTipoDeDocumento.Name = "Actualizar_Menu_PleTipoDeDocumento"
        Me.Actualizar_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_PleTipoDeDocumento.TabIndex = 73
        Me.Actualizar_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_PleTipoDeDocumento
        '
        Me.Guardar_Menu_PleTipoDeDocumento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_PleTipoDeDocumento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar_Menu_PleTipoDeDocumento.Image = CType(resources.GetObject("Guardar_Menu_PleTipoDeDocumento.Image"), System.Drawing.Image)
        Me.Guardar_Menu_PleTipoDeDocumento.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_PleTipoDeDocumento.Name = "Guardar_Menu_PleTipoDeDocumento"
        Me.Guardar_Menu_PleTipoDeDocumento.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_PleTipoDeDocumento.TabIndex = 71
        Me.Guardar_Menu_PleTipoDeDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_PleTipoDeDocumento.UseVisualStyleBackColor = True
        '
        'ValidarCierre
        '
        Me.ValidarCierre.Location = New System.Drawing.Point(590, 189)
        Me.ValidarCierre.Name = "ValidarCierre"
        Me.ValidarCierre.Size = New System.Drawing.Size(110, 28)
        Me.ValidarCierre.TabIndex = 105
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(590, 254)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(110, 36)
        Me.LblInforme.TabIndex = 104
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInforme.Visible = False
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(590, 223)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(110, 28)
        Me.ControlNulos.TabIndex = 103
        '
        'DataSetMaestros
        '
        Me.DataSetMaestros.DataSetName = "DataSetMaestros"
        Me.DataSetMaestros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PleTipoDeDocumentoBindingSource
        '
        Me.PleTipoDeDocumentoBindingSource.DataMember = "PleTipoDeDocumento"
        Me.PleTipoDeDocumentoBindingSource.DataSource = Me.DataSetMaestros
        '
        'PleTipoDeDocumentoTableAdapter
        '
        Me.PleTipoDeDocumentoTableAdapter.ClearBeforeFill = True
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
        'PleTipoDeDocumentoDataGridView
        '
        Me.PleTipoDeDocumentoDataGridView.AllowUserToAddRows = False
        Me.PleTipoDeDocumentoDataGridView.AutoGenerateColumns = False
        Me.PleTipoDeDocumentoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.PleTipoDeDocumentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PleTipoDeDocumentoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.PleTipoDeDocumentoDataGridView.DataSource = Me.PleTipoDeDocumentoBindingSource
        Me.PleTipoDeDocumentoDataGridView.Location = New System.Drawing.Point(369, 12)
        Me.PleTipoDeDocumentoDataGridView.Name = "PleTipoDeDocumentoDataGridView"
        Me.PleTipoDeDocumentoDataGridView.RowHeadersVisible = False
        Me.PleTipoDeDocumentoDataGridView.Size = New System.Drawing.Size(342, 278)
        Me.PleTipoDeDocumentoDataGridView.TabIndex = 106
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreTipoDocumento"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Tipo Documento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 338
        '
        'TipoDeDocumentoIdTextBox
        '
        Me.TipoDeDocumentoIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleTipoDeDocumentoBindingSource, "TipoDeDocumentoId", True))
        Me.TipoDeDocumentoIdTextBox.Location = New System.Drawing.Point(590, 155)
        Me.TipoDeDocumentoIdTextBox.Name = "TipoDeDocumentoIdTextBox"
        Me.TipoDeDocumentoIdTextBox.Size = New System.Drawing.Size(110, 28)
        Me.TipoDeDocumentoIdTextBox.TabIndex = 107
        '
        'NombreTipoDocumentoTextBox
        '
        Me.NombreTipoDocumentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PleTipoDeDocumentoBindingSource, "NombreTipoDocumento", True))
        Me.NombreTipoDocumentoTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.NombreTipoDocumentoTextBox.Location = New System.Drawing.Point(12, 94)
        Me.NombreTipoDocumentoTextBox.Name = "NombreTipoDocumentoTextBox"
        Me.NombreTipoDocumentoTextBox.Size = New System.Drawing.Size(351, 28)
        Me.NombreTipoDocumentoTextBox.TabIndex = 108
        '
        'SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource.DataMember = "SP_PleTipoDeDocumento_EDICION_ACTUALIZAR"
        Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource
        '
        Me.SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource.DataMember = "SP_PleTipoDeDocumento_EDICION_ELIMINAR"
        Me.SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter
        '
        Me.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource
        '
        Me.SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource.DataMember = "SP_PleTipoDeDocumento_EDICION_INSERTAR"
        Me.SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource.DataSource = Me.DataSetMaestros
        '
        'SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter
        '
        Me.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'FrmPleTiposDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(721, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.PleTipoDeDocumentoDataGridView)
        Me.Controls.Add(NombreTipoDocumentoLabel)
        Me.Controls.Add(Me.NombreTipoDocumentoTextBox)
        Me.Controls.Add(TipoDeDocumentoIdLabel)
        Me.Controls.Add(Me.TipoDeDocumentoIdTextBox)
        Me.Controls.Add(Me.ValidarCierre)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmPleTiposDocumentos"
        Me.Text = "FrmPleTiposDocumentos"
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.DataSetMaestros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleTipoDeDocumentoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PleTipoDeDocumentoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Salir_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Nuevo_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Cancelar_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Eliminar_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Editar_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Actualizar_Menu_PleTipoDeDocumento As Button
    Friend WithEvents Guardar_Menu_PleTipoDeDocumento As Button
    Friend WithEvents ValidarCierre As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents DataSetMaestros As DataSetMaestros
    Friend WithEvents PleTipoDeDocumentoBindingSource As BindingSource
    Friend WithEvents PleTipoDeDocumentoTableAdapter As DataSetMaestrosTableAdapters.PleTipoDeDocumentoTableAdapter
    Friend WithEvents TableAdapterManager As DataSetMaestrosTableAdapters.TableAdapterManager
    Friend WithEvents PleTipoDeDocumentoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TipoDeDocumentoIdTextBox As TextBox
    Friend WithEvents NombreTipoDocumentoTextBox As TextBox
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter As DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter As DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter As DataSetMaestrosTableAdapters.SP_PleTipoDeDocumento_EDICION_INSERTARTableAdapter
End Class
