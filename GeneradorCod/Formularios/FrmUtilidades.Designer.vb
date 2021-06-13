<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtilidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUtilidades))
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Salir_Menu_ = New System.Windows.Forms.Button()
        Me.Nuevo_Menu_ = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_ = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_ = New System.Windows.Forms.Button()
        Me.Editar_Menu_ = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_ = New System.Windows.Forms.Button()
        Me.Guardar_Menu_ = New System.Windows.Forms.Button()
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.SP_Prueba_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Prueba_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Prueba_EDICION_ACTUALIZARTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Dato1ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato1ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato2ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato2ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato3ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato3ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato4ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato4ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato5ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato5ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato7ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato7ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Dato8ToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Dato8ToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView = New System.Windows.Forms.DataGridView()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.ValidarCierre = New System.Windows.Forms.TextBox()
        Me.PanelAdministracion_.SuspendLayout()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelAdministracion_.Location = New System.Drawing.Point(251, 382)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(351, 46)
        Me.PanelAdministracion_.TabIndex = 90
        '
        'Salir_Menu_
        '
        Me.Salir_Menu_.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir_Menu_.BackColor = System.Drawing.Color.Red
        Me.Salir_Menu_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Salir_Menu_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir_Menu_.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir_Menu_.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Salir_Menu_.Location = New System.Drawing.Point(306, 3)
        Me.Salir_Menu_.Name = "Salir_Menu_"
        Me.Salir_Menu_.Size = New System.Drawing.Size(40, 38)
        Me.Salir_Menu_.TabIndex = 76
        Me.Salir_Menu_.Text = "X"
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
        'DataSetAdministracion
        '
        Me.DataSetAdministracion.DataSetName = "DataSetAdministracion"
        Me.DataSetAdministracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_Prueba_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Prueba_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Prueba_EDICION_ACTUALIZAR"
        Me.SP_Prueba_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Prueba_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Prueba_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SP_Prueba_EDICION_ACTUALIZARTableAdapter = Me.SP_Prueba_EDICION_ACTUALIZARTableAdapter
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
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_Prueba_EDICION_ACTUALIZARBindingNavigator
        '
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.BindingSource = Me.SP_Prueba_EDICION_ACTUALIZARBindingSource
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem})
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.Name = "SP_Prueba_EDICION_ACTUALIZARBindingNavigator"
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.TabIndex = 91
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.Text = "BindingNavigator1"
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
        'SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem
        '
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Image = CType(resources.GetObject("SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Name = "SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem"
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Dato1ToolStripLabel, Me.Dato1ToolStripTextBox, Me.Dato2ToolStripLabel, Me.Dato2ToolStripTextBox, Me.Dato3ToolStripLabel, Me.Dato3ToolStripTextBox, Me.Dato4ToolStripLabel, Me.Dato4ToolStripTextBox, Me.Dato5ToolStripLabel, Me.Dato5ToolStripTextBox, Me.Dato7ToolStripLabel, Me.Dato7ToolStripTextBox, Me.Dato8ToolStripLabel, Me.Dato8ToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillToolStrip.TabIndex = 92
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'Dato1ToolStripLabel
        '
        Me.Dato1ToolStripLabel.Name = "Dato1ToolStripLabel"
        Me.Dato1ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato1ToolStripLabel.Text = "dato1:"
        '
        'Dato1ToolStripTextBox
        '
        Me.Dato1ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato1ToolStripTextBox.Name = "Dato1ToolStripTextBox"
        Me.Dato1ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Dato2ToolStripLabel
        '
        Me.Dato2ToolStripLabel.Name = "Dato2ToolStripLabel"
        Me.Dato2ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato2ToolStripLabel.Text = "dato2:"
        '
        'Dato2ToolStripTextBox
        '
        Me.Dato2ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato2ToolStripTextBox.Name = "Dato2ToolStripTextBox"
        Me.Dato2ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Dato3ToolStripLabel
        '
        Me.Dato3ToolStripLabel.Name = "Dato3ToolStripLabel"
        Me.Dato3ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato3ToolStripLabel.Text = "dato3:"
        '
        'Dato3ToolStripTextBox
        '
        Me.Dato3ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato3ToolStripTextBox.Name = "Dato3ToolStripTextBox"
        Me.Dato3ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Dato4ToolStripLabel
        '
        Me.Dato4ToolStripLabel.Name = "Dato4ToolStripLabel"
        Me.Dato4ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato4ToolStripLabel.Text = "dato4:"
        '
        'Dato4ToolStripTextBox
        '
        Me.Dato4ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato4ToolStripTextBox.Name = "Dato4ToolStripTextBox"
        Me.Dato4ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Dato5ToolStripLabel
        '
        Me.Dato5ToolStripLabel.Name = "Dato5ToolStripLabel"
        Me.Dato5ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato5ToolStripLabel.Text = "dato5:"
        '
        'Dato5ToolStripTextBox
        '
        Me.Dato5ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato5ToolStripTextBox.Name = "Dato5ToolStripTextBox"
        Me.Dato5ToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'Dato7ToolStripLabel
        '
        Me.Dato7ToolStripLabel.Name = "Dato7ToolStripLabel"
        Me.Dato7ToolStripLabel.Size = New System.Drawing.Size(40, 22)
        Me.Dato7ToolStripLabel.Text = "dato7:"
        '
        'Dato7ToolStripTextBox
        '
        Me.Dato7ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato7ToolStripTextBox.Name = "Dato7ToolStripTextBox"
        Me.Dato7ToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'Dato8ToolStripLabel
        '
        Me.Dato8ToolStripLabel.Name = "Dato8ToolStripLabel"
        Me.Dato8ToolStripLabel.Size = New System.Drawing.Size(40, 15)
        Me.Dato8ToolStripLabel.Text = "dato8:"
        '
        'Dato8ToolStripTextBox
        '
        Me.Dato8ToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Dato8ToolStripTextBox.Name = "Dato8ToolStripTextBox"
        Me.Dato8ToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 19)
        Me.FillToolStripButton.Text = "Fill"
        '
        'SP_Prueba_EDICION_ACTUALIZARDataGridView
        '
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.AutoGenerateColumns = False
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.DataSource = Me.SP_Prueba_EDICION_ACTUALIZARBindingSource
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.Location = New System.Drawing.Point(130, 81)
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.Name = "SP_Prueba_EDICION_ACTUALIZARDataGridView"
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.SP_Prueba_EDICION_ACTUALIZARDataGridView.TabIndex = 92
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(608, 372)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(110, 20)
        Me.ControlNulos.TabIndex = 93
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(608, 395)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(110, 36)
        Me.LblInforme.TabIndex = 101
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblInforme.Visible = False
        '
        'ValidarCierre
        '
        Me.ValidarCierre.Location = New System.Drawing.Point(608, 346)
        Me.ValidarCierre.Name = "ValidarCierre"
        Me.ValidarCierre.Size = New System.Drawing.Size(110, 20)
        Me.ValidarCierre.TabIndex = 102
        '
        'FrmUtilidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ValidarCierre)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.ControlNulos)
        Me.Controls.Add(Me.SP_Prueba_EDICION_ACTUALIZARDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator)
        Me.Controls.Add(Me.PanelAdministracion_)
        Me.Name = "FrmUtilidades"
        Me.Text = "FrmUtilidades"
        Me.PanelAdministracion_.ResumeLayout(False)
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.ResumeLayout(False)
        Me.SP_Prueba_EDICION_ACTUALIZARBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.SP_Prueba_EDICION_ACTUALIZARDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_ As Button
    Friend WithEvents Cancelar_Menu_ As Button
    Friend WithEvents Eliminar_Menu_ As Button
    Friend WithEvents Editar_Menu_ As Button
    Friend WithEvents Actualizar_Menu_ As Button
    Friend WithEvents Guardar_Menu_ As Button
    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents SP_Prueba_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_Prueba_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Prueba_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents SP_Prueba_EDICION_ACTUALIZARBindingNavigator As BindingNavigator
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
    Friend WithEvents SP_Prueba_EDICION_ACTUALIZARBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents Dato1ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato1ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato2ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato2ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato3ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato3ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato4ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato4ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato5ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato5ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato7ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato7ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Dato8ToolStripLabel As ToolStripLabel
    Friend WithEvents Dato8ToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents SP_Prueba_EDICION_ACTUALIZARDataGridView As DataGridView
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents Salir_Menu_ As Button
    Friend WithEvents ValidarCierre As TextBox
End Class
