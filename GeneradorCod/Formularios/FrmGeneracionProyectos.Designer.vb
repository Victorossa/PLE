<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGeneracionProyectos
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
        Dim NombreProyectoLabel As System.Windows.Forms.Label
        Dim CodigoGeneradoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim ProyectoIDLabel As System.Windows.Forms.Label
        Dim TecnologiaIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel As System.Windows.Forms.Label
        Dim ProyectosYTecnologiasIDLabel As System.Windows.Forms.Label
        Dim ProyectoIDLabel1 As System.Windows.Forms.Label
        Dim TecnologiaIDLabel1 As System.Windows.Forms.Label
        Dim NombreTablaLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim TipoLabel1 As System.Windows.Forms.Label
        Dim TablaIDLabel As System.Windows.Forms.Label
        Dim NombreCampoLabel As System.Windows.Forms.Label
        Dim TipoLabel2 As System.Windows.Forms.Label
        Dim TipoLabel3 As System.Windows.Forms.Label
        Dim CampoIDLabel As System.Windows.Forms.Label
        Dim TablaIDLabel1 As System.Windows.Forms.Label
        Dim TablaIDLabel2 As System.Windows.Forms.Label
        Dim TablaIDLabel3 As System.Windows.Forms.Label
        Dim CampoIDLabel1 As System.Windows.Forms.Label
        Dim CampoIDLabel2 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim RegistroRelacionesTablasIDLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim CampoIndependienteLabel As System.Windows.Forms.Label
        Dim TablaIndependienteLabel As System.Windows.Forms.Label
        Dim CampoDependienteLabel As System.Windows.Forms.Label
        Dim TablaDependienteLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim EnunciadoLabel As System.Windows.Forms.Label
        Dim RequerimientoLabel As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim RegistroValorRequerimientoIDLabel As System.Windows.Forms.Label
        Dim PlantillaIDLabel1 As System.Windows.Forms.Label
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim CodigoDependienteLabel As System.Windows.Forms.Label
        Dim NombreComponenteLabel As System.Windows.Forms.Label
        Dim XTablaLabel As System.Windows.Forms.Label
        Dim XBaseLabel As System.Windows.Forms.Label
        Dim TablaIDLabel4 As System.Windows.Forms.Label
        Dim NombreTablaLabel1 As System.Windows.Forms.Label
        Dim RequerimientoLabel1 As System.Windows.Forms.Label
        Dim ValorRequerimientoLabel As System.Windows.Forms.Label
        Dim TextoLabel As System.Windows.Forms.Label
        Dim NombreCampoLabel1 As System.Windows.Forms.Label
        Dim RutaLabel As System.Windows.Forms.Label
        Dim ExtensionArchivoLabel As System.Windows.Forms.Label
        Dim NombreArchivoLabel As System.Windows.Forms.Label
        Dim ContenidoXTablaLabel As System.Windows.Forms.Label
        Dim MultiReplaceLabel As System.Windows.Forms.Label
        Dim SeparadorCamposLabel As System.Windows.Forms.Label
        Dim InferiorLabel As System.Windows.Forms.Label
        Dim SufijoLabel As System.Windows.Forms.Label
        Dim SuperiorLabel As System.Windows.Forms.Label
        Dim PrefijoLabel As System.Windows.Forms.Label
        Dim TipoLabel4 As System.Windows.Forms.Label
        Dim ContenidoRelacionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGeneracionProyectos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl5 = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TP_TablasYCampos = New System.Windows.Forms.TabPage()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetTablasYCampos = New GeneradorCod.DataSetTablasYCampos()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Editar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Guardar_Menu_CamposDeTablas = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTiposDatos = New System.Windows.Forms.ComboBox()
        Me.TiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetAdministracion = New GeneradorCod.DataSetAdministracion()
        Me.NombreCampoTextBox = New System.Windows.Forms.TextBox()
        Me.TipoCheckBox = New System.Windows.Forms.CheckBox()
        Me.NombreTablaTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Editar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.Guardar_Menu_TablasDeProyecto = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampoIndependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TablaDependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TablaIndependienteTextBox = New System.Windows.Forms.TextBox()
        Me.CampoDependienteTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_EliminacionPlantillas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarPlantillaSeleccionadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CM_Tecnologias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarPlantillaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarlasTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TecnologiasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CM_EnTecnologias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregarTodasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TecnologiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TP_Requerimientos = New System.Windows.Forms.TabPage()
        Me.TabControl4 = New System.Windows.Forms.TabControl()
        Me.TP_RequerimientosProyecto = New System.Windows.Forms.TabPage()
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnListarRequerimientos = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.EnunciadoEnRich = New System.Windows.Forms.RichTextBox()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistroValorRequerimientoIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnCargarRequerimiento = New System.Windows.Forms.Button()
        Me.ValorRequerimiento = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BtnLimpiarValoresRequerimientos = New System.Windows.Forms.Button()
        Me.BtnIniciaCargaRequerimientos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_RegistroValorRequerimientos = New System.Windows.Forms.Button()
        Me.Editar_Menu_RegistroValorRequerimientos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_RegistroValorRequerimientos = New System.Windows.Forms.Button()
        Me.TP_Generar = New System.Windows.Forms.TabPage()
        Me.TabControl6 = New System.Windows.Forms.TabControl()
        Me.TP_CarpetasArchivos = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCreacion = New System.Windows.Forms.Button()
        Me.ChkCreaCarpetasYArchivos = New System.Windows.Forms.CheckBox()
        Me.ChkCreaDocumentoTecnico = New System.Windows.Forms.CheckBox()
        Me.RBExistente = New System.Windows.Forms.RadioButton()
        Me.RBNuevo = New System.Windows.Forms.RadioButton()
        Me.AdmiteCreacionCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TP_Proyectos = New System.Windows.Forms.TabPage()
        Me.LblInforme = New System.Windows.Forms.Label()
        Me.ProyectosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProyectosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelAdministracion_ = New System.Windows.Forms.Panel()
        Me.Nuevo_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Cancelar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Eliminar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Editar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Actualizar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.Guardar_Menu_Proyectos = New System.Windows.Forms.Button()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.NombreProyectoTextBox = New System.Windows.Forms.TextBox()
        Me.TP_Admin = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel_Tecnologias = New System.Windows.Forms.Panel()
        Me.ContenidoRelacionTextBox = New System.Windows.Forms.TextBox()
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TipoGeneracion = New System.Windows.Forms.TextBox()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MultiReplaceTextBox = New System.Windows.Forms.TextBox()
        Me.SeparadorCamposTextBox = New System.Windows.Forms.TextBox()
        Me.InferiorTextBox = New System.Windows.Forms.TextBox()
        Me.SufijoTextBox = New System.Windows.Forms.TextBox()
        Me.SuperiorTextBox = New System.Windows.Forms.TextBox()
        Me.PrefijoTextBox = New System.Windows.Forms.TextBox()
        Me.ContenidoXTablaTextBox = New System.Windows.Forms.TextBox()
        Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NombreArchivoGeneracion = New System.Windows.Forms.TextBox()
        Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExtensionArchivoGeneracion = New System.Windows.Forms.TextBox()
        Me.RutaGeneracion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NombreCampoGeneracion = New System.Windows.Forms.TextBox()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextoTextBox = New System.Windows.Forms.TextBox()
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ValorRequerimientoGeneracion = New System.Windows.Forms.TextBox()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequerimientoGeneracion = New System.Windows.Forms.TextBox()
        Me.DGV_RequerimientosProyecto = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreTablaTextBox1 = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TablaIDGeneracion = New System.Windows.Forms.TextBox()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CodigoAProcesar = New System.Windows.Forms.TextBox()
        Me.XBaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XTablaCheckBox = New System.Windows.Forms.CheckBox()
        Me.NombreComponenteTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoDependienteTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.DGV_ComponentesGeneracion = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlantillaIDRequerimientos = New System.Windows.Forms.TextBox()
        Me.PlantillaID_Techanged_Generacion_CargaComponentes = New System.Windows.Forms.TextBox()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGV_PlantillasAplicadas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDRequerimiento = New System.Windows.Forms.TextBox()
        Me.EnunciadoTextBox = New System.Windows.Forms.TextBox()
        Me.RequerimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RegistroRelacionesTablasIDEdicion = New System.Windows.Forms.TextBox()
        Me.TipoCTI = New System.Windows.Forms.TextBox()
        Me.TipoCTD = New System.Windows.Forms.TextBox()
        Me.RegistroRelacionesTablasIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CampoID_Depend = New System.Windows.Forms.TextBox()
        Me.CampoID_Independiente = New System.Windows.Forms.TextBox()
        Me.TablaID_Independiente = New System.Windows.Forms.TextBox()
        Me.TablaID_Depend = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TablaIDRelacionados = New System.Windows.Forms.TextBox()
        Me.CampoIDTextBox = New System.Windows.Forms.TextBox()
        Me.TipoCampoDesdeTabla = New System.Windows.Forms.TextBox()
        Me.TipoCampoDesdeCombo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.TablaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectoIDTextBox = New System.Windows.Forms.TextBox()
        Me.TecnologiaIDParaEliminarPorTecnologia = New System.Windows.Forms.TextBox()
        Me.ProyectoIDParaEliminarPorTecnologia = New System.Windows.Forms.TextBox()
        Me.ControlNulos = New System.Windows.Forms.TextBox()
        Me.PlantillaIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProyectosYTecnologiasIDTextBox = New System.Windows.Forms.TextBox()
        Me.TecnologiaIDTextBox = New System.Windows.Forms.TextBox()
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosValorProvisional_TRUNCABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ChkValidacionRequerimientos = New System.Windows.Forms.CheckBox()
        Me.BtnCodigoRuta = New System.Windows.Forms.Button()
        Me.BtnRequerimientos = New System.Windows.Forms.Button()
        Me.BtnExplorar = New System.Windows.Forms.Button()
        Me.BtnAmpliar = New System.Windows.Forms.Button()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnInicioGenerar = New System.Windows.Forms.Button()
        Me.CodigoGeneradoTextBox = New System.Windows.Forms.RichTextBox()
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer_Acciones = New System.Windows.Forms.Timer(Me.components)
        Me.ProyectosTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.ProyectosTableAdapter()
        Me.TableAdapterManager = New GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager()
        Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ACTUALIZARTableAdapter()
        Me.SP_Proyectos_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ELIMINARTableAdapter()
        Me.SP_Proyectos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_INSERTARTableAdapter()
        Me.SP_Proyectos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter()
        Me.TecnologiasTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TecnologiasTableAdapter()
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter()
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter()
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter()
        Me.ELIMINA_SEGUN_PROYECTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ELIMINA_SEGUN_PROYECTOTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.ELIMINA_SEGUN_PROYECTOTableAdapter()
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter()
        Me.TableAdapterManager1 = New GeneradorCod.DataSetTablasYCamposTableAdapters.TableAdapterManager()
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter()
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter()
        Me.TiposTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.TiposTableAdapter()
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter()
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_INSERTARTableAdapter()
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter()
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter()
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter()
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter()
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter()
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter()
        Me.ToolTipGeneracion = New System.Windows.Forms.ToolTip(Me.components)
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter()
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter()
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter()
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter()
        Me.TimerRequerimientos = New System.Windows.Forms.Timer(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter()
        Me.PanelGeneracion = New System.Windows.Forms.Panel()
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter()
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter()
        Me.Timer_Genera_Archivos = New System.Windows.Forms.Timer(Me.components)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter()
        Me.SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter()
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter()
        Me.SP_RequerimientosValorProvisional_TRUNCATableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_TRUNCATableAdapter()
        Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter()
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter()
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter()
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter()
        Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter()
        Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter()
        Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter = New GeneradorCod.DataSetAdministracionTableAdapters.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter()
        Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter()
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter = New GeneradorCod.DataSetTablasYCamposTableAdapters.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter()
        NombreProyectoLabel = New System.Windows.Forms.Label()
        CodigoGeneradoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        ProyectoIDLabel = New System.Windows.Forms.Label()
        TecnologiaIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel = New System.Windows.Forms.Label()
        ProyectosYTecnologiasIDLabel = New System.Windows.Forms.Label()
        ProyectoIDLabel1 = New System.Windows.Forms.Label()
        TecnologiaIDLabel1 = New System.Windows.Forms.Label()
        NombreTablaLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        TipoLabel1 = New System.Windows.Forms.Label()
        TablaIDLabel = New System.Windows.Forms.Label()
        NombreCampoLabel = New System.Windows.Forms.Label()
        TipoLabel2 = New System.Windows.Forms.Label()
        TipoLabel3 = New System.Windows.Forms.Label()
        CampoIDLabel = New System.Windows.Forms.Label()
        TablaIDLabel1 = New System.Windows.Forms.Label()
        TablaIDLabel2 = New System.Windows.Forms.Label()
        TablaIDLabel3 = New System.Windows.Forms.Label()
        CampoIDLabel1 = New System.Windows.Forms.Label()
        CampoIDLabel2 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        RegistroRelacionesTablasIDLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CampoIndependienteLabel = New System.Windows.Forms.Label()
        TablaIndependienteLabel = New System.Windows.Forms.Label()
        CampoDependienteLabel = New System.Windows.Forms.Label()
        TablaDependienteLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        EnunciadoLabel = New System.Windows.Forms.Label()
        RequerimientoLabel = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        RegistroValorRequerimientoIDLabel = New System.Windows.Forms.Label()
        PlantillaIDLabel1 = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        CodigoDependienteLabel = New System.Windows.Forms.Label()
        NombreComponenteLabel = New System.Windows.Forms.Label()
        XTablaLabel = New System.Windows.Forms.Label()
        XBaseLabel = New System.Windows.Forms.Label()
        TablaIDLabel4 = New System.Windows.Forms.Label()
        NombreTablaLabel1 = New System.Windows.Forms.Label()
        RequerimientoLabel1 = New System.Windows.Forms.Label()
        ValorRequerimientoLabel = New System.Windows.Forms.Label()
        TextoLabel = New System.Windows.Forms.Label()
        NombreCampoLabel1 = New System.Windows.Forms.Label()
        RutaLabel = New System.Windows.Forms.Label()
        ExtensionArchivoLabel = New System.Windows.Forms.Label()
        NombreArchivoLabel = New System.Windows.Forms.Label()
        ContenidoXTablaLabel = New System.Windows.Forms.Label()
        MultiReplaceLabel = New System.Windows.Forms.Label()
        SeparadorCamposLabel = New System.Windows.Forms.Label()
        InferiorLabel = New System.Windows.Forms.Label()
        SufijoLabel = New System.Windows.Forms.Label()
        SuperiorLabel = New System.Windows.Forms.Label()
        PrefijoLabel = New System.Windows.Forms.Label()
        TipoLabel4 = New System.Windows.Forms.Label()
        ContenidoRelacionLabel = New System.Windows.Forms.Label()
        Me.TabControl5.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TP_TablasYCampos.SuspendLayout()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage10.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_EliminacionPlantillas.SuspendLayout()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_Tecnologias.SuspendLayout()
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CM_EnTecnologias.SuspendLayout()
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Requerimientos.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TP_RequerimientosProyecto.SuspendLayout()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.TP_Generar.SuspendLayout()
        Me.TabControl6.SuspendLayout()
        Me.TP_CarpetasArchivos.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TP_Proyectos.SuspendLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAdministracion_.SuspendLayout()
        Me.TP_Admin.SuspendLayout()
        Me.Panel_Tecnologias.SuspendLayout()
        CType(Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_RequerimientosProyecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_ComponentesGeneracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_PlantillasAplicadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValorProvisional_TRUNCABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGeneracion.SuspendLayout()
        CType(Me.SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreProyectoLabel
        '
        NombreProyectoLabel.AutoSize = True
        NombreProyectoLabel.Location = New System.Drawing.Point(8, 58)
        NombreProyectoLabel.Name = "NombreProyectoLabel"
        NombreProyectoLabel.Size = New System.Drawing.Size(117, 16)
        NombreProyectoLabel.TabIndex = 91
        NombreProyectoLabel.Text = "Nombre Proyecto:"
        '
        'CodigoGeneradoLabel
        '
        CodigoGeneradoLabel.AutoSize = True
        CodigoGeneradoLabel.Location = New System.Drawing.Point(685, 169)
        CodigoGeneradoLabel.Name = "CodigoGeneradoLabel"
        CodigoGeneradoLabel.Size = New System.Drawing.Size(93, 13)
        CodigoGeneradoLabel.TabIndex = 92
        CodigoGeneradoLabel.Text = "Codigo Generado:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(8, 102)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(83, 16)
        DescripcionLabel.TabIndex = 92
        DescripcionLabel.Text = "Descripcion:"
        '
        'ProyectoIDLabel
        '
        ProyectoIDLabel.AutoSize = True
        ProyectoIDLabel.Location = New System.Drawing.Point(57, 33)
        ProyectoIDLabel.Name = "ProyectoIDLabel"
        ProyectoIDLabel.Size = New System.Drawing.Size(66, 13)
        ProyectoIDLabel.TabIndex = 93
        ProyectoIDLabel.Text = "Proyecto ID:"
        '
        'TecnologiaIDLabel
        '
        TecnologiaIDLabel.AutoSize = True
        TecnologiaIDLabel.Location = New System.Drawing.Point(57, 61)
        TecnologiaIDLabel.Name = "TecnologiaIDLabel"
        TecnologiaIDLabel.Size = New System.Drawing.Size(77, 13)
        TecnologiaIDLabel.TabIndex = 0
        TecnologiaIDLabel.Text = "Tecnologia ID:"
        '
        'PlantillaIDLabel
        '
        PlantillaIDLabel.AutoSize = True
        PlantillaIDLabel.Location = New System.Drawing.Point(57, 89)
        PlantillaIDLabel.Name = "PlantillaIDLabel"
        PlantillaIDLabel.Size = New System.Drawing.Size(60, 13)
        PlantillaIDLabel.TabIndex = 2
        PlantillaIDLabel.Text = "Plantilla ID:"
        '
        'ProyectosYTecnologiasIDLabel
        '
        ProyectosYTecnologiasIDLabel.AutoSize = True
        ProyectosYTecnologiasIDLabel.Location = New System.Drawing.Point(57, 117)
        ProyectosYTecnologiasIDLabel.Name = "ProyectosYTecnologiasIDLabel"
        ProyectosYTecnologiasIDLabel.Size = New System.Drawing.Size(139, 13)
        ProyectosYTecnologiasIDLabel.TabIndex = 4
        ProyectosYTecnologiasIDLabel.Text = "Proyectos YTecnologias ID:"
        '
        'ProyectoIDLabel1
        '
        ProyectoIDLabel1.AutoSize = True
        ProyectoIDLabel1.Location = New System.Drawing.Point(57, 276)
        ProyectoIDLabel1.Name = "ProyectoIDLabel1"
        ProyectoIDLabel1.Size = New System.Drawing.Size(149, 13)
        ProyectoIDLabel1.TabIndex = 6
        ProyectoIDLabel1.Text = "Proyecto ID Elim Tecnologias:"
        '
        'TecnologiaIDLabel1
        '
        TecnologiaIDLabel1.AutoSize = True
        TecnologiaIDLabel1.Location = New System.Drawing.Point(57, 304)
        TecnologiaIDLabel1.Name = "TecnologiaIDLabel1"
        TecnologiaIDLabel1.Size = New System.Drawing.Size(160, 13)
        TecnologiaIDLabel1.TabIndex = 8
        TecnologiaIDLabel1.Text = "Tecnologia ID Elim Tecnologias:"
        '
        'NombreTablaLabel
        '
        NombreTablaLabel.AutoSize = True
        NombreTablaLabel.Location = New System.Drawing.Point(4, 54)
        NombreTablaLabel.Name = "NombreTablaLabel"
        NombreTablaLabel.Size = New System.Drawing.Size(99, 16)
        NombreTablaLabel.TabIndex = 92
        NombreTablaLabel.Text = "Nombre Tabla:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Location = New System.Drawing.Point(349, 54)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(39, 16)
        TipoLabel.TabIndex = 93
        TipoLabel.Text = "Tipo:"
        '
        'TipoLabel1
        '
        TipoLabel1.AutoSize = True
        TipoLabel1.Location = New System.Drawing.Point(57, 230)
        TipoLabel1.Name = "TipoLabel1"
        TipoLabel1.Size = New System.Drawing.Size(31, 13)
        TipoLabel1.TabIndex = 94
        TipoLabel1.Text = "Tipo:"
        '
        'TablaIDLabel
        '
        TablaIDLabel.AutoSize = True
        TablaIDLabel.Location = New System.Drawing.Point(57, 145)
        TablaIDLabel.Name = "TablaIDLabel"
        TablaIDLabel.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel.TabIndex = 94
        TablaIDLabel.Text = "Tabla ID:"
        '
        'NombreCampoLabel
        '
        NombreCampoLabel.AutoSize = True
        NombreCampoLabel.Location = New System.Drawing.Point(5, 319)
        NombreCampoLabel.Name = "NombreCampoLabel"
        NombreCampoLabel.Size = New System.Drawing.Size(107, 16)
        NombreCampoLabel.TabIndex = 94
        NombreCampoLabel.Text = "Nombre Campo:"
        '
        'TipoLabel2
        '
        TipoLabel2.AutoSize = True
        TipoLabel2.Location = New System.Drawing.Point(57, 356)
        TipoLabel2.Name = "TipoLabel2"
        TipoLabel2.Size = New System.Drawing.Size(104, 13)
        TipoLabel2.TabIndex = 99
        TipoLabel2.Text = "Tipos desde Combo:"
        '
        'TipoLabel3
        '
        TipoLabel3.AutoSize = True
        TipoLabel3.Location = New System.Drawing.Point(57, 384)
        TipoLabel3.Name = "TipoLabel3"
        TipoLabel3.Size = New System.Drawing.Size(98, 13)
        TipoLabel3.TabIndex = 100
        TipoLabel3.Text = "Tipos desde Tabla:"
        '
        'CampoIDLabel
        '
        CampoIDLabel.AutoSize = True
        CampoIDLabel.Location = New System.Drawing.Point(57, 412)
        CampoIDLabel.Name = "CampoIDLabel"
        CampoIDLabel.Size = New System.Drawing.Size(57, 13)
        CampoIDLabel.TabIndex = 101
        CampoIDLabel.Text = "Campo ID:"
        '
        'TablaIDLabel1
        '
        TablaIDLabel1.AutoSize = True
        TablaIDLabel1.Location = New System.Drawing.Point(57, 173)
        TablaIDLabel1.Name = "TablaIDLabel1"
        TablaIDLabel1.Size = New System.Drawing.Size(144, 13)
        TablaIDLabel1.TabIndex = 102
        TablaIDLabel1.Text = "Tabla ID Para Relacionados:"
        '
        'TablaIDLabel2
        '
        TablaIDLabel2.AutoSize = True
        TablaIDLabel2.Location = New System.Drawing.Point(319, 36)
        TablaIDLabel2.Name = "TablaIDLabel2"
        TablaIDLabel2.Size = New System.Drawing.Size(99, 13)
        TablaIDLabel2.TabIndex = 104
        TablaIDLabel2.Text = "Tabla ID ""Depend"""
        '
        'TablaIDLabel3
        '
        TablaIDLabel3.AutoSize = True
        TablaIDLabel3.Location = New System.Drawing.Point(319, 95)
        TablaIDLabel3.Name = "TablaIDLabel3"
        TablaIDLabel3.Size = New System.Drawing.Size(119, 13)
        TablaIDLabel3.TabIndex = 105
        TablaIDLabel3.Text = "Tabla ID Independiente"
        '
        'CampoIDLabel1
        '
        CampoIDLabel1.AutoSize = True
        CampoIDLabel1.Location = New System.Drawing.Point(319, 123)
        CampoIDLabel1.Name = "CampoIDLabel1"
        CampoIDLabel1.Size = New System.Drawing.Size(125, 13)
        CampoIDLabel1.TabIndex = 106
        CampoIDLabel1.Text = "Campo ID Independiente"
        '
        'CampoIDLabel2
        '
        CampoIDLabel2.AutoSize = True
        CampoIDLabel2.Location = New System.Drawing.Point(319, 64)
        CampoIDLabel2.Name = "CampoIDLabel2"
        CampoIDLabel2.Size = New System.Drawing.Size(108, 13)
        CampoIDLabel2.TabIndex = 107
        CampoIDLabel2.Text = "Campo ID ""Depend"":"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(539, 36)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(70, 13)
        Label8.TabIndex = 109
        Label8.Text = "Control Nulos"
        '
        'RegistroRelacionesTablasIDLabel
        '
        RegistroRelacionesTablasIDLabel.AutoSize = True
        RegistroRelacionesTablasIDLabel.Location = New System.Drawing.Point(319, 154)
        RegistroRelacionesTablasIDLabel.Name = "RegistroRelacionesTablasIDLabel"
        RegistroRelacionesTablasIDLabel.Size = New System.Drawing.Size(181, 13)
        RegistroRelacionesTablasIDLabel.TabIndex = 109
        RegistroRelacionesTablasIDLabel.Text = "Registro Relaciones Tablas ID Busq:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(319, 206)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(135, 13)
        Label9.TabIndex = 113
        Label9.Text = "Tipo CTD dato relacionado"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(319, 235)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(130, 13)
        Label10.TabIndex = 115
        Label10.Text = "Tipo CTI dato relacionado"
        '
        'CampoIndependienteLabel
        '
        CampoIndependienteLabel.AutoSize = True
        CampoIndependienteLabel.Location = New System.Drawing.Point(17, 498)
        CampoIndependienteLabel.Name = "CampoIndependienteLabel"
        CampoIndependienteLabel.Size = New System.Drawing.Size(144, 16)
        CampoIndependienteLabel.TabIndex = 196
        CampoIndependienteLabel.Text = "Campo Independiente:"
        '
        'TablaIndependienteLabel
        '
        TablaIndependienteLabel.AutoSize = True
        TablaIndependienteLabel.Location = New System.Drawing.Point(14, 454)
        TablaIndependienteLabel.Name = "TablaIndependienteLabel"
        TablaIndependienteLabel.Size = New System.Drawing.Size(136, 16)
        TablaIndependienteLabel.TabIndex = 194
        TablaIndependienteLabel.Text = "Tabla Independiente:"
        '
        'CampoDependienteLabel
        '
        CampoDependienteLabel.AutoSize = True
        CampoDependienteLabel.Location = New System.Drawing.Point(13, 361)
        CampoDependienteLabel.Name = "CampoDependienteLabel"
        CampoDependienteLabel.Size = New System.Drawing.Size(136, 16)
        CampoDependienteLabel.TabIndex = 192
        CampoDependienteLabel.Text = "Campo Dependiente:"
        '
        'TablaDependienteLabel
        '
        TablaDependienteLabel.AutoSize = True
        TablaDependienteLabel.Location = New System.Drawing.Point(13, 311)
        TablaDependienteLabel.Name = "TablaDependienteLabel"
        TablaDependienteLabel.Size = New System.Drawing.Size(128, 16)
        TablaDependienteLabel.TabIndex = 190
        TablaDependienteLabel.Text = "Tabla Dependiente:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(78, 419)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(316, 16)
        Label11.TabIndex = 199
        Label11.Text = "-----------------------------------------------------------------------------"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(319, 181)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(192, 13)
        Label12.TabIndex = 116
        Label12.Text = "Registro Relaciones Tablas ID Edicion:"
        '
        'EnunciadoLabel
        '
        EnunciadoLabel.AutoSize = True
        EnunciadoLabel.Location = New System.Drawing.Point(319, 301)
        EnunciadoLabel.Name = "EnunciadoLabel"
        EnunciadoLabel.Size = New System.Drawing.Size(61, 13)
        EnunciadoLabel.TabIndex = 207
        EnunciadoLabel.Text = "Enunciado:"
        '
        'RequerimientoLabel
        '
        RequerimientoLabel.AutoSize = True
        RequerimientoLabel.Location = New System.Drawing.Point(319, 330)
        RequerimientoLabel.Name = "RequerimientoLabel"
        RequerimientoLabel.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel.TabIndex = 209
        RequerimientoLabel.Text = "Requerimiento:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(319, 357)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(86, 13)
        Label15.TabIndex = 212
        Label15.Text = "IDRequerimiento"
        '
        'RegistroValorRequerimientoIDLabel
        '
        RegistroValorRequerimientoIDLabel.AutoSize = True
        RegistroValorRequerimientoIDLabel.Location = New System.Drawing.Point(58, 377)
        RegistroValorRequerimientoIDLabel.Name = "RegistroValorRequerimientoIDLabel"
        RegistroValorRequerimientoIDLabel.Size = New System.Drawing.Size(204, 16)
        RegistroValorRequerimientoIDLabel.TabIndex = 151
        RegistroValorRequerimientoIDLabel.Text = "Registro Valor Requerimiento ID:"
        '
        'PlantillaIDLabel1
        '
        PlantillaIDLabel1.AutoSize = True
        PlantillaIDLabel1.Location = New System.Drawing.Point(635, 184)
        PlantillaIDLabel1.Name = "PlantillaIDLabel1"
        PlantillaIDLabel1.Size = New System.Drawing.Size(118, 13)
        PlantillaIDLabel1.TabIndex = 214
        PlantillaIDLabel1.Text = "Plantilla ID Generacion:"
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(638, 212)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(114, 13)
        CodigoLabel.TabIndex = 215
        CodigoLabel.Text = "Codigo Independiente:"
        '
        'CodigoDependienteLabel
        '
        CodigoDependienteLabel.AutoSize = True
        CodigoDependienteLabel.Location = New System.Drawing.Point(884, 210)
        CodigoDependienteLabel.Name = "CodigoDependienteLabel"
        CodigoDependienteLabel.Size = New System.Drawing.Size(107, 13)
        CodigoDependienteLabel.TabIndex = 216
        CodigoDependienteLabel.Text = "Codigo Dependiente:"
        '
        'NombreComponenteLabel
        '
        NombreComponenteLabel.AutoSize = True
        NombreComponenteLabel.Location = New System.Drawing.Point(638, 274)
        NombreComponenteLabel.Name = "NombreComponenteLabel"
        NombreComponenteLabel.Size = New System.Drawing.Size(110, 13)
        NombreComponenteLabel.TabIndex = 217
        NombreComponenteLabel.Text = "Nombre Componente:"
        '
        'XTablaLabel
        '
        XTablaLabel.AutoSize = True
        XTablaLabel.Location = New System.Drawing.Point(638, 330)
        XTablaLabel.Name = "XTablaLabel"
        XTablaLabel.Size = New System.Drawing.Size(44, 13)
        XTablaLabel.TabIndex = 218
        XTablaLabel.Text = "XTabla:"
        '
        'XBaseLabel
        '
        XBaseLabel.AutoSize = True
        XBaseLabel.Location = New System.Drawing.Point(638, 357)
        XBaseLabel.Name = "XBaseLabel"
        XBaseLabel.Size = New System.Drawing.Size(41, 13)
        XBaseLabel.TabIndex = 219
        XBaseLabel.Text = "XBase:"
        '
        'TablaIDLabel4
        '
        TablaIDLabel4.AutoSize = True
        TablaIDLabel4.Location = New System.Drawing.Point(1126, 210)
        TablaIDLabel4.Name = "TablaIDLabel4"
        TablaIDLabel4.Size = New System.Drawing.Size(51, 13)
        TablaIDLabel4.TabIndex = 229
        TablaIDLabel4.Text = "Tabla ID:"
        '
        'NombreTablaLabel1
        '
        NombreTablaLabel1.AutoSize = True
        NombreTablaLabel1.Location = New System.Drawing.Point(1126, 259)
        NombreTablaLabel1.Name = "NombreTablaLabel1"
        NombreTablaLabel1.Size = New System.Drawing.Size(77, 13)
        NombreTablaLabel1.TabIndex = 230
        NombreTablaLabel1.Text = "Nombre Tabla:"
        '
        'RequerimientoLabel1
        '
        RequerimientoLabel1.AutoSize = True
        RequerimientoLabel1.Location = New System.Drawing.Point(1438, 212)
        RequerimientoLabel1.Name = "RequerimientoLabel1"
        RequerimientoLabel1.Size = New System.Drawing.Size(78, 13)
        RequerimientoLabel1.TabIndex = 231
        RequerimientoLabel1.Text = "Requerimiento:"
        '
        'ValorRequerimientoLabel
        '
        ValorRequerimientoLabel.AutoSize = True
        ValorRequerimientoLabel.Location = New System.Drawing.Point(1403, 240)
        ValorRequerimientoLabel.Name = "ValorRequerimientoLabel"
        ValorRequerimientoLabel.Size = New System.Drawing.Size(105, 13)
        ValorRequerimientoLabel.TabIndex = 232
        ValorRequerimientoLabel.Text = "Valor Requerimiento:"
        '
        'TextoLabel
        '
        TextoLabel.AutoSize = True
        TextoLabel.Location = New System.Drawing.Point(1492, 267)
        TextoLabel.Name = "TextoLabel"
        TextoLabel.Size = New System.Drawing.Size(37, 13)
        TextoLabel.TabIndex = 233
        TextoLabel.Text = "Texto:"
        '
        'NombreCampoLabel1
        '
        NombreCampoLabel1.AutoSize = True
        NombreCampoLabel1.Location = New System.Drawing.Point(1126, 454)
        NombreCampoLabel1.Name = "NombreCampoLabel1"
        NombreCampoLabel1.Size = New System.Drawing.Size(83, 13)
        NombreCampoLabel1.TabIndex = 234
        NombreCampoLabel1.Text = "Nombre Campo:"
        '
        'RutaLabel
        '
        RutaLabel.AutoSize = True
        RutaLabel.Location = New System.Drawing.Point(1786, 36)
        RutaLabel.Name = "RutaLabel"
        RutaLabel.Size = New System.Drawing.Size(33, 13)
        RutaLabel.TabIndex = 236
        RutaLabel.Text = "Ruta:"
        '
        'ExtensionArchivoLabel
        '
        ExtensionArchivoLabel.AutoSize = True
        ExtensionArchivoLabel.Location = New System.Drawing.Point(1708, 64)
        ExtensionArchivoLabel.Name = "ExtensionArchivoLabel"
        ExtensionArchivoLabel.Size = New System.Drawing.Size(95, 13)
        ExtensionArchivoLabel.TabIndex = 237
        ExtensionArchivoLabel.Text = "Extension Archivo:"
        '
        'NombreArchivoLabel
        '
        NombreArchivoLabel.AutoSize = True
        NombreArchivoLabel.Location = New System.Drawing.Point(1717, 93)
        NombreArchivoLabel.Name = "NombreArchivoLabel"
        NombreArchivoLabel.Size = New System.Drawing.Size(86, 13)
        NombreArchivoLabel.TabIndex = 238
        NombreArchivoLabel.Text = "Nombre Archivo:"
        '
        'ContenidoXTablaLabel
        '
        ContenidoXTablaLabel.AutoSize = True
        ContenidoXTablaLabel.Location = New System.Drawing.Point(1678, 259)
        ContenidoXTablaLabel.Name = "ContenidoXTablaLabel"
        ContenidoXTablaLabel.Size = New System.Drawing.Size(95, 13)
        ContenidoXTablaLabel.TabIndex = 240
        ContenidoXTablaLabel.Text = "Contenido XTabla:"
        '
        'MultiReplaceLabel
        '
        MultiReplaceLabel.AutoSize = True
        MultiReplaceLabel.Location = New System.Drawing.Point(2125, 93)
        MultiReplaceLabel.Name = "MultiReplaceLabel"
        MultiReplaceLabel.Size = New System.Drawing.Size(75, 13)
        MultiReplaceLabel.TabIndex = 251
        MultiReplaceLabel.Text = "Multi Replace:"
        '
        'SeparadorCamposLabel
        '
        SeparadorCamposLabel.AutoSize = True
        SeparadorCamposLabel.Location = New System.Drawing.Point(2118, 35)
        SeparadorCamposLabel.Name = "SeparadorCamposLabel"
        SeparadorCamposLabel.Size = New System.Drawing.Size(100, 13)
        SeparadorCamposLabel.TabIndex = 250
        SeparadorCamposLabel.Text = "Separador Campos:"
        '
        'InferiorLabel
        '
        InferiorLabel.AutoSize = True
        InferiorLabel.Location = New System.Drawing.Point(1948, 116)
        InferiorLabel.Name = "InferiorLabel"
        InferiorLabel.Size = New System.Drawing.Size(42, 13)
        InferiorLabel.TabIndex = 247
        InferiorLabel.Text = "Inferior:"
        '
        'SufijoLabel
        '
        SufijoLabel.AutoSize = True
        SufijoLabel.Location = New System.Drawing.Point(2065, 72)
        SufijoLabel.Name = "SufijoLabel"
        SufijoLabel.Size = New System.Drawing.Size(36, 13)
        SufijoLabel.TabIndex = 245
        SufijoLabel.Text = "Sufijo:"
        '
        'SuperiorLabel
        '
        SuperiorLabel.AutoSize = True
        SuperiorLabel.Location = New System.Drawing.Point(2006, 45)
        SuperiorLabel.Name = "SuperiorLabel"
        SuperiorLabel.Size = New System.Drawing.Size(49, 13)
        SuperiorLabel.TabIndex = 243
        SuperiorLabel.Text = "Superior:"
        '
        'PrefijoLabel
        '
        PrefijoLabel.AutoSize = True
        PrefijoLabel.Location = New System.Drawing.Point(1953, 74)
        PrefijoLabel.Name = "PrefijoLabel"
        PrefijoLabel.Size = New System.Drawing.Size(39, 13)
        PrefijoLabel.TabIndex = 242
        PrefijoLabel.Text = "Prefijo:"
        '
        'TipoLabel4
        '
        TipoLabel4.AutoSize = True
        TipoLabel4.Location = New System.Drawing.Point(1194, 478)
        TipoLabel4.Name = "TipoLabel4"
        TipoLabel4.Size = New System.Drawing.Size(31, 13)
        TipoLabel4.TabIndex = 253
        TipoLabel4.Text = "Tipo:"
        '
        'ContenidoRelacionLabel
        '
        ContenidoRelacionLabel.AutoSize = True
        ContenidoRelacionLabel.Location = New System.Drawing.Point(1970, 447)
        ContenidoRelacionLabel.Name = "ContenidoRelacionLabel"
        ContenidoRelacionLabel.Size = New System.Drawing.Size(103, 13)
        ContenidoRelacionLabel.TabIndex = 256
        ContenidoRelacionLabel.Text = "Contenido Relacion:"
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabPage9)
        Me.TabControl5.Controls.Add(Me.TabPage10)
        Me.TabControl5.Controls.Add(Me.TP_Requerimientos)
        Me.TabControl5.Controls.Add(Me.TP_Generar)
        Me.TabControl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TabControl5.Location = New System.Drawing.Point(467, 0)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(494, 621)
        Me.TabControl5.TabIndex = 1
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.TabControl2)
        Me.TabPage9.Location = New System.Drawing.Point(4, 25)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(486, 592)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Tablas y Campos"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TP_TablasYCampos)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(480, 586)
        Me.TabControl2.TabIndex = 0
        '
        'TP_TablasYCampos
        '
        Me.TP_TablasYCampos.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView)
        Me.TP_TablasYCampos.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView)
        Me.TP_TablasYCampos.Controls.Add(Me.Panel2)
        Me.TP_TablasYCampos.Controls.Add(Me.Label6)
        Me.TP_TablasYCampos.Controls.Add(Me.CboTiposDatos)
        Me.TP_TablasYCampos.Controls.Add(NombreCampoLabel)
        Me.TP_TablasYCampos.Controls.Add(Me.NombreCampoTextBox)
        Me.TP_TablasYCampos.Controls.Add(TipoLabel)
        Me.TP_TablasYCampos.Controls.Add(Me.TipoCheckBox)
        Me.TP_TablasYCampos.Controls.Add(NombreTablaLabel)
        Me.TP_TablasYCampos.Controls.Add(Me.NombreTablaTextBox)
        Me.TP_TablasYCampos.Controls.Add(Me.Panel1)
        Me.TP_TablasYCampos.Location = New System.Drawing.Point(4, 25)
        Me.TP_TablasYCampos.Name = "TP_TablasYCampos"
        Me.TP_TablasYCampos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_TablasYCampos.Size = New System.Drawing.Size(472, 557)
        Me.TP_TablasYCampos.TabIndex = 1
        Me.TP_TablasYCampos.Text = "Creación"
        Me.TP_TablasYCampos.UseVisualStyleBackColor = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Location = New System.Drawing.Point(2, 406)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.Size = New System.Drawing.Size(463, 148)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Nombre Campo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 360
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Tipo D."
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'DataSetTablasYCampos
        '
        Me.DataSetTablasYCampos.DataSetName = "DataSetTablasYCampos"
        Me.DataSetTablasYCampos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn2})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Location = New System.Drawing.Point(2, 98)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.Size = New System.Drawing.Size(463, 159)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView.TabIndex = 92
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tabla"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 390
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Tipo"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Ind."
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 59
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Nuevo_Menu_CamposDeTablas)
        Me.Panel2.Controls.Add(Me.Cancelar_Menu_CamposDeTablas)
        Me.Panel2.Controls.Add(Me.Eliminar_Menu_CamposDeTablas)
        Me.Panel2.Controls.Add(Me.Editar_Menu_CamposDeTablas)
        Me.Panel2.Controls.Add(Me.Actualizar_Menu_CamposDeTablas)
        Me.Panel2.Controls.Add(Me.Guardar_Menu_CamposDeTablas)
        Me.Panel2.Location = New System.Drawing.Point(5, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(460, 46)
        Me.Panel2.TabIndex = 154
        '
        'Nuevo_Menu_CamposDeTablas
        '
        Me.Nuevo_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_CamposDeTablas.Image = CType(resources.GetObject("Nuevo_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_CamposDeTablas.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_CamposDeTablas.Name = "Nuevo_Menu_CamposDeTablas"
        Me.Nuevo_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_CamposDeTablas.TabIndex = 70
        Me.Nuevo_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_CamposDeTablas
        '
        Me.Cancelar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Cancelar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_CamposDeTablas.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_CamposDeTablas.Name = "Cancelar_Menu_CamposDeTablas"
        Me.Cancelar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_CamposDeTablas.TabIndex = 75
        Me.Cancelar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_CamposDeTablas
        '
        Me.Eliminar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Eliminar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_CamposDeTablas.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_CamposDeTablas.Name = "Eliminar_Menu_CamposDeTablas"
        Me.Eliminar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_CamposDeTablas.TabIndex = 72
        Me.Eliminar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Editar_Menu_CamposDeTablas
        '
        Me.Editar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Editar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Editar_Menu_CamposDeTablas.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_CamposDeTablas.Name = "Editar_Menu_CamposDeTablas"
        Me.Editar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_CamposDeTablas.TabIndex = 74
        Me.Editar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_CamposDeTablas
        '
        Me.Actualizar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Actualizar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_CamposDeTablas.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_CamposDeTablas.Name = "Actualizar_Menu_CamposDeTablas"
        Me.Actualizar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_CamposDeTablas.TabIndex = 73
        Me.Actualizar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_CamposDeTablas
        '
        Me.Guardar_Menu_CamposDeTablas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_CamposDeTablas.Image = CType(resources.GetObject("Guardar_Menu_CamposDeTablas.Image"), System.Drawing.Image)
        Me.Guardar_Menu_CamposDeTablas.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_CamposDeTablas.Name = "Guardar_Menu_CamposDeTablas"
        Me.Guardar_Menu_CamposDeTablas.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_CamposDeTablas.TabIndex = 71
        Me.Guardar_Menu_CamposDeTablas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_CamposDeTablas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 16)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Tipo de Dato"
        '
        'CboTiposDatos
        '
        Me.CboTiposDatos.DataSource = Me.TiposBindingSource
        Me.CboTiposDatos.DisplayMember = "Tipo"
        Me.CboTiposDatos.FormattingEnabled = True
        Me.CboTiposDatos.Location = New System.Drawing.Point(5, 380)
        Me.CboTiposDatos.Name = "CboTiposDatos"
        Me.CboTiposDatos.Size = New System.Drawing.Size(460, 24)
        Me.CboTiposDatos.TabIndex = 152
        Me.CboTiposDatos.ValueMember = "Tipo"
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
        'NombreCampoTextBox
        '
        Me.NombreCampoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "NombreCampo", True))
        Me.NombreCampoTextBox.Location = New System.Drawing.Point(5, 338)
        Me.NombreCampoTextBox.Name = "NombreCampoTextBox"
        Me.NombreCampoTextBox.Size = New System.Drawing.Size(461, 22)
        Me.NombreCampoTextBox.TabIndex = 95
        '
        'TipoCheckBox
        '
        Me.TipoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "Tipo", True))
        Me.TipoCheckBox.Location = New System.Drawing.Point(349, 70)
        Me.TipoCheckBox.Name = "TipoCheckBox"
        Me.TipoCheckBox.Size = New System.Drawing.Size(116, 24)
        Me.TipoCheckBox.TabIndex = 94
        Me.TipoCheckBox.UseVisualStyleBackColor = True
        '
        'NombreTablaTextBox
        '
        Me.NombreTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox.Location = New System.Drawing.Point(8, 71)
        Me.NombreTablaTextBox.Name = "NombreTablaTextBox"
        Me.NombreTablaTextBox.Size = New System.Drawing.Size(335, 22)
        Me.NombreTablaTextBox.TabIndex = 93
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Nuevo_Menu_TablasDeProyecto)
        Me.Panel1.Controls.Add(Me.Cancelar_Menu_TablasDeProyecto)
        Me.Panel1.Controls.Add(Me.Eliminar_Menu_TablasDeProyecto)
        Me.Panel1.Controls.Add(Me.Editar_Menu_TablasDeProyecto)
        Me.Panel1.Controls.Add(Me.Actualizar_Menu_TablasDeProyecto)
        Me.Panel1.Controls.Add(Me.Guardar_Menu_TablasDeProyecto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 46)
        Me.Panel1.TabIndex = 92
        '
        'Nuevo_Menu_TablasDeProyecto
        '
        Me.Nuevo_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Nuevo_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_TablasDeProyecto.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_TablasDeProyecto.Name = "Nuevo_Menu_TablasDeProyecto"
        Me.Nuevo_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_TablasDeProyecto.TabIndex = 70
        Me.Nuevo_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_TablasDeProyecto
        '
        Me.Cancelar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Cancelar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_TablasDeProyecto.Name = "Cancelar_Menu_TablasDeProyecto"
        Me.Cancelar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_TablasDeProyecto.TabIndex = 75
        Me.Cancelar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_TablasDeProyecto
        '
        Me.Eliminar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Eliminar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_TablasDeProyecto.Name = "Eliminar_Menu_TablasDeProyecto"
        Me.Eliminar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_TablasDeProyecto.TabIndex = 72
        Me.Eliminar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Editar_Menu_TablasDeProyecto
        '
        Me.Editar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Editar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Editar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_TablasDeProyecto.Name = "Editar_Menu_TablasDeProyecto"
        Me.Editar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_TablasDeProyecto.TabIndex = 74
        Me.Editar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_TablasDeProyecto
        '
        Me.Actualizar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Actualizar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_TablasDeProyecto.Name = "Actualizar_Menu_TablasDeProyecto"
        Me.Actualizar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_TablasDeProyecto.TabIndex = 73
        Me.Actualizar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_TablasDeProyecto
        '
        Me.Guardar_Menu_TablasDeProyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_TablasDeProyecto.Image = CType(resources.GetObject("Guardar_Menu_TablasDeProyecto.Image"), System.Drawing.Image)
        Me.Guardar_Menu_TablasDeProyecto.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_TablasDeProyecto.Name = "Guardar_Menu_TablasDeProyecto"
        Me.Guardar_Menu_TablasDeProyecto.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_TablasDeProyecto.TabIndex = 71
        Me.Guardar_Menu_TablasDeProyecto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_TablasDeProyecto.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView)
        Me.TabPage1.Controls.Add(Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView)
        Me.TabPage1.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView)
        Me.TabPage1.Controls.Add(Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(472, 557)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Asignación de Relaciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn15})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Location = New System.Drawing.Point(240, 238)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.Size = New System.Drawing.Size(227, 313)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nombre Campo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 170
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 44
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView
        '
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn24})
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.DataSource = Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.Location = New System.Drawing.Point(240, 6)
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.Name = "SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView"
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.Size = New System.Drawing.Size(227, 225)
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn24.HeaderText = "TABLA ""DEP"""
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 211
        '
        'SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource
        '
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource.DataMember = "SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_Proyecto"
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn13})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Location = New System.Drawing.Point(6, 238)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.Size = New System.Drawing.Size(228, 313)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Nombre Campo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 170
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 44
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView
        '
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn27})
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.DataSource = Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.Location = New System.Drawing.Point(6, 3)
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.Name = "SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView"
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.Size = New System.Drawing.Size(228, 228)
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView.TabIndex = 95
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn27.HeaderText = "TABLA ""INDEPENDIENTE"""
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 211
        '
        'SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource
        '
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource.DataMember = "SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_Proyecto"
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Label11)
        Me.TabPage3.Controls.Add(CampoIndependienteLabel)
        Me.TabPage3.Controls.Add(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView)
        Me.TabPage3.Controls.Add(Me.CampoIndependienteTextBox)
        Me.TabPage3.Controls.Add(TablaDependienteLabel)
        Me.TabPage3.Controls.Add(TablaIndependienteLabel)
        Me.TabPage3.Controls.Add(Me.TablaDependienteTextBox)
        Me.TabPage3.Controls.Add(Me.TablaIndependienteTextBox)
        Me.TabPage3.Controls.Add(Me.CampoDependienteTextBox)
        Me.TabPage3.Controls.Add(CampoDependienteLabel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(472, 557)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Relaciones Existentes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.AllowUserToAddRows = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.AutoGenerateColumns = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn3})
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.DataSource = Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Name = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.RowHeadersVisible = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.Size = New System.Drawing.Size(466, 267)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView.TabIndex = 191
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "TablaDependiente"
        Me.DataGridViewTextBoxColumn19.HeaderText = "TablaDependiente"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 112
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "CampoDependiente"
        Me.DataGridViewTextBoxColumn20.HeaderText = "CampoDependiente"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 112
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn23.HeaderText = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        Me.DataGridViewTextBoxColumn23.Width = 112
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 112
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource.DataMember = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'CampoIndependienteTextBox
        '
        Me.CampoIndependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "CampoIndependiente", True))
        Me.CampoIndependienteTextBox.Location = New System.Drawing.Point(16, 517)
        Me.CampoIndependienteTextBox.Name = "CampoIndependienteTextBox"
        Me.CampoIndependienteTextBox.Size = New System.Drawing.Size(444, 22)
        Me.CampoIndependienteTextBox.TabIndex = 198
        '
        'TablaDependienteTextBox
        '
        Me.TablaDependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "TablaDependiente", True))
        Me.TablaDependienteTextBox.Location = New System.Drawing.Point(15, 331)
        Me.TablaDependienteTextBox.Name = "TablaDependienteTextBox"
        Me.TablaDependienteTextBox.Size = New System.Drawing.Size(444, 22)
        Me.TablaDependienteTextBox.TabIndex = 193
        '
        'TablaIndependienteTextBox
        '
        Me.TablaIndependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "TablaIndependiente", True))
        Me.TablaIndependienteTextBox.Location = New System.Drawing.Point(16, 473)
        Me.TablaIndependienteTextBox.Name = "TablaIndependienteTextBox"
        Me.TablaIndependienteTextBox.Size = New System.Drawing.Size(444, 22)
        Me.TablaIndependienteTextBox.TabIndex = 197
        '
        'CampoDependienteTextBox
        '
        Me.CampoDependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "CampoDependiente", True))
        Me.CampoDependienteTextBox.Location = New System.Drawing.Point(15, 377)
        Me.CampoDependienteTextBox.Name = "CampoDependienteTextBox"
        Me.CampoDependienteTextBox.Size = New System.Drawing.Size(444, 22)
        Me.CampoDependienteTextBox.TabIndex = 195
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.TabControl3)
        Me.TabPage10.Location = New System.Drawing.Point(4, 25)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(486, 592)
        Me.TabPage10.TabIndex = 1
        Me.TabPage10.Text = "Tecnologias"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 3)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(480, 586)
        Me.TabControl3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 557)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Aplicadas al Proyecto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29})
        Me.DataGridView1.ContextMenuStrip = Me.CM_EliminacionPlantillas
        Me.DataGridView1.DataSource = Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(466, 551)
        Me.DataGridView1.TabIndex = 193
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Tecnologia"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        Me.DataGridViewTextBoxColumn28.Width = 232
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Plantilla"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Width = 232
        '
        'CM_EliminacionPlantillas
        '
        Me.CM_EliminacionPlantillas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarPlantillaSeleccionadaToolStripMenuItem, Me.EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem, Me.EliminarTodasToolStripMenuItem})
        Me.CM_EliminacionPlantillas.Name = "CM_EliminacionPlantillas"
        Me.CM_EliminacionPlantillas.Size = New System.Drawing.Size(333, 70)
        '
        'EliminarPlantillaSeleccionadaToolStripMenuItem
        '
        Me.EliminarPlantillaSeleccionadaToolStripMenuItem.Name = "EliminarPlantillaSeleccionadaToolStripMenuItem"
        Me.EliminarPlantillaSeleccionadaToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.EliminarPlantillaSeleccionadaToolStripMenuItem.Text = "Eliminar Plantilla Seleccionada"
        '
        'EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem
        '
        Me.EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem.Name = "EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem"
        Me.EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem.Text = "Eliminar Todas las Relacionadas a esta Tecnologia"
        '
        'EliminarTodasToolStripMenuItem
        '
        Me.EliminarTodasToolStripMenuItem.Name = "EliminarTodasToolStripMenuItem"
        Me.EliminarTodasToolStripMenuItem.Size = New System.Drawing.Size(332, 22)
        Me.EliminarTodasToolStripMenuItem.Text = "Eliminar Todas"
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataMember = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView)
        Me.TabPage5.Controls.Add(Me.TecnologiasDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(472, 557)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Agregar Tecnologias"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AllowUserToAddRows = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.AutoGenerateColumns = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.ContextMenuStrip = Me.CM_Tecnologias
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.DataSource = Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Location = New System.Drawing.Point(3, 203)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Name = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.RowHeadersVisible = False
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.Size = New System.Drawing.Size(466, 351)
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Nombre Plantilla"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 414
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Orden"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn9.HeaderText = "Orden"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 50
        '
        'CM_Tecnologias
        '
        Me.CM_Tecnologias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlantillaToolStripMenuItem, Me.AgregarlasTodasToolStripMenuItem})
        Me.CM_Tecnologias.Name = "CM_Tecnologias"
        Me.CM_Tecnologias.Size = New System.Drawing.Size(164, 48)
        '
        'AgregarPlantillaToolStripMenuItem
        '
        Me.AgregarPlantillaToolStripMenuItem.Name = "AgregarPlantillaToolStripMenuItem"
        Me.AgregarPlantillaToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AgregarPlantillaToolStripMenuItem.Text = "Agregar Plantilla"
        '
        'AgregarlasTodasToolStripMenuItem
        '
        Me.AgregarlasTodasToolStripMenuItem.Name = "AgregarlasTodasToolStripMenuItem"
        Me.AgregarlasTodasToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AgregarlasTodasToolStripMenuItem.Text = "Agregarlas Todas"
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataMember = "SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_Tecnologia"
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TecnologiasDataGridView
        '
        Me.TecnologiasDataGridView.AllowUserToAddRows = False
        Me.TecnologiasDataGridView.AutoGenerateColumns = False
        Me.TecnologiasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TecnologiasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.TecnologiasDataGridView.ContextMenuStrip = Me.CM_EnTecnologias
        Me.TecnologiasDataGridView.DataSource = Me.TecnologiasBindingSource
        Me.TecnologiasDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.TecnologiasDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TecnologiasDataGridView.Name = "TecnologiasDataGridView"
        Me.TecnologiasDataGridView.RowHeadersVisible = False
        Me.TecnologiasDataGridView.Size = New System.Drawing.Size(466, 194)
        Me.TecnologiasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nombre Tecnologia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 414
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Validada"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Validada"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 50
        '
        'CM_EnTecnologias
        '
        Me.CM_EnTecnologias.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarTodasToolStripMenuItem})
        Me.CM_EnTecnologias.Name = "CM_EnTecnologias"
        Me.CM_EnTecnologias.Size = New System.Drawing.Size(252, 26)
        '
        'AgregarTodasToolStripMenuItem
        '
        Me.AgregarTodasToolStripMenuItem.Name = "AgregarTodasToolStripMenuItem"
        Me.AgregarTodasToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AgregarTodasToolStripMenuItem.Text = "Agregar Todas las de esta Plantilla"
        '
        'TecnologiasBindingSource
        '
        Me.TecnologiasBindingSource.DataMember = "Tecnologias"
        Me.TecnologiasBindingSource.DataSource = Me.DataSetAdministracion
        '
        'TP_Requerimientos
        '
        Me.TP_Requerimientos.Controls.Add(Me.TabControl4)
        Me.TP_Requerimientos.Location = New System.Drawing.Point(4, 25)
        Me.TP_Requerimientos.Name = "TP_Requerimientos"
        Me.TP_Requerimientos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Requerimientos.Size = New System.Drawing.Size(486, 592)
        Me.TP_Requerimientos.TabIndex = 2
        Me.TP_Requerimientos.Text = "Requerimientos"
        Me.TP_Requerimientos.UseVisualStyleBackColor = True
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TP_RequerimientosProyecto)
        Me.TabControl4.Controls.Add(Me.TabPage6)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Location = New System.Drawing.Point(3, 3)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(480, 586)
        Me.TabControl4.TabIndex = 0
        '
        'TP_RequerimientosProyecto
        '
        Me.TP_RequerimientosProyecto.Controls.Add(Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView)
        Me.TP_RequerimientosProyecto.Controls.Add(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView)
        Me.TP_RequerimientosProyecto.Controls.Add(Me.BtnListarRequerimientos)
        Me.TP_RequerimientosProyecto.Controls.Add(Me.Label13)
        Me.TP_RequerimientosProyecto.Location = New System.Drawing.Point(4, 25)
        Me.TP_RequerimientosProyecto.Name = "TP_RequerimientosProyecto"
        Me.TP_RequerimientosProyecto.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_RequerimientosProyecto.Size = New System.Drawing.Size(472, 557)
        Me.TP_RequerimientosProyecto.TabIndex = 0
        Me.TP_RequerimientosProyecto.Text = "Requerimientos Actuales"
        Me.TP_RequerimientosProyecto.UseVisualStyleBackColor = True
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn55})
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.DataSource = Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Location = New System.Drawing.Point(3, 58)
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Name = "SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_Proye" &
    "ctoIdDataGridView"
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.Size = New System.Drawing.Size(466, 496)
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView.TabIndex = 192
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "NombreRequerimiento"
        Me.DataGridViewTextBoxColumn55.HeaderText = "Nombre Requerimiento"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 462
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource.DataMember = "SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_Proye" &
    "ctoId"
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.AllowUserToAddRows = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.AutoGenerateColumns = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.ContextMenuStrip = Me.CM_EliminacionPlantillas
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.DataSource = Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Location = New System.Drawing.Point(15, 126)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Name = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.RowHeadersVisible = False
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.Size = New System.Drawing.Size(207, 87)
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NombreTecnologia"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tecnologia"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 232
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Plantilla"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 232
        '
        'BtnListarRequerimientos
        '
        Me.BtnListarRequerimientos.Image = CType(resources.GetObject("BtnListarRequerimientos.Image"), System.Drawing.Image)
        Me.BtnListarRequerimientos.Location = New System.Drawing.Point(419, 14)
        Me.BtnListarRequerimientos.Name = "BtnListarRequerimientos"
        Me.BtnListarRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.BtnListarRequerimientos.TabIndex = 148
        Me.ToolTipGeneracion.SetToolTip(Me.BtnListarRequerimientos, "Listar los Requerimientos del Proyecto")
        Me.BtnListarRequerimientos.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(273, 16)
        Me.Label13.TabIndex = 118
        Me.Label13.Text = "Requerimientos Actuales del Proyecto"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label20)
        Me.TabPage6.Controls.Add(Me.EnunciadoEnRich)
        Me.TabPage6.Controls.Add(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView)
        Me.TabPage6.Controls.Add(RegistroValorRequerimientoIDLabel)
        Me.TabPage6.Controls.Add(Me.RegistroValorRequerimientoIDTextBox)
        Me.TabPage6.Controls.Add(Me.Label16)
        Me.TabPage6.Controls.Add(Me.BtnCargarRequerimiento)
        Me.TabPage6.Controls.Add(Me.ValorRequerimiento)
        Me.TabPage6.Controls.Add(Me.Panel9)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(472, 557)
        Me.TabPage6.TabIndex = 1
        Me.TabPage6.Text = "Asignar Valores A Requerimientos"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(217, 20)
        Me.Label20.TabIndex = 154
        Me.Label20.Text = "Detalle del Requerimiento"
        '
        'EnunciadoEnRich
        '
        Me.EnunciadoEnRich.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource, "Enunciado", True))
        Me.EnunciadoEnRich.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnunciadoEnRich.Location = New System.Drawing.Point(7, 152)
        Me.EnunciadoEnRich.Name = "EnunciadoEnRich"
        Me.EnunciadoEnRich.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.EnunciadoEnRich.Size = New System.Drawing.Size(453, 160)
        Me.EnunciadoEnRich.TabIndex = 153
        Me.EnunciadoEnRich.Text = ""
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AllowUserToAddRows = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.AutoGenerateColumns = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.DataSource = Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Location = New System.Drawing.Point(3, 324)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Name = "SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.RowHeadersVisible = False
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.RowTemplate.Height = 27
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.Size = New System.Drawing.Size(466, 230)
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView.TabIndex = 148
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Width = 231
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "ValorRequerimiento"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Valor Requerimiento"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 231
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataMember = "SP_RegistroValorRequerimientos_SEGUN_ProyectoID"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'RegistroValorRequerimientoIDTextBox
        '
        Me.RegistroValorRequerimientoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "RegistroValorRequerimientoID", True))
        Me.RegistroValorRequerimientoIDTextBox.Location = New System.Drawing.Point(268, 374)
        Me.RegistroValorRequerimientoIDTextBox.Name = "RegistroValorRequerimientoIDTextBox"
        Me.RegistroValorRequerimientoIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RegistroValorRequerimientoIDTextBox.TabIndex = 152
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource, "NombreRequerimiento", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 20)
        Me.Label16.TabIndex = 151
        Me.Label16.Text = "Nombre del Requerimiento"
        '
        'BtnCargarRequerimiento
        '
        Me.BtnCargarRequerimiento.Enabled = False
        Me.BtnCargarRequerimiento.Image = CType(resources.GetObject("BtnCargarRequerimiento.Image"), System.Drawing.Image)
        Me.BtnCargarRequerimiento.Location = New System.Drawing.Point(418, 88)
        Me.BtnCargarRequerimiento.Name = "BtnCargarRequerimiento"
        Me.BtnCargarRequerimiento.Size = New System.Drawing.Size(40, 38)
        Me.BtnCargarRequerimiento.TabIndex = 150
        Me.BtnCargarRequerimiento.UseVisualStyleBackColor = True
        '
        'ValorRequerimiento
        '
        Me.ValorRequerimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimiento.Enabled = False
        Me.ValorRequerimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorRequerimiento.Location = New System.Drawing.Point(7, 88)
        Me.ValorRequerimiento.Multiline = True
        Me.ValorRequerimiento.Name = "ValorRequerimiento"
        Me.ValorRequerimiento.Size = New System.Drawing.Size(395, 38)
        Me.ValorRequerimiento.TabIndex = 149
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.BtnLimpiarValoresRequerimientos)
        Me.Panel9.Controls.Add(Me.BtnIniciaCargaRequerimientos)
        Me.Panel9.Controls.Add(Me.Cancelar_Menu_RegistroValorRequerimientos)
        Me.Panel9.Controls.Add(Me.Editar_Menu_RegistroValorRequerimientos)
        Me.Panel9.Controls.Add(Me.Actualizar_Menu_RegistroValorRequerimientos)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(3, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(466, 46)
        Me.Panel9.TabIndex = 147
        '
        'BtnLimpiarValoresRequerimientos
        '
        Me.BtnLimpiarValoresRequerimientos.Image = CType(resources.GetObject("BtnLimpiarValoresRequerimientos.Image"), System.Drawing.Image)
        Me.BtnLimpiarValoresRequerimientos.Location = New System.Drawing.Point(370, 3)
        Me.BtnLimpiarValoresRequerimientos.Name = "BtnLimpiarValoresRequerimientos"
        Me.BtnLimpiarValoresRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.BtnLimpiarValoresRequerimientos.TabIndex = 135
        Me.BtnLimpiarValoresRequerimientos.UseVisualStyleBackColor = True
        '
        'BtnIniciaCargaRequerimientos
        '
        Me.BtnIniciaCargaRequerimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnIniciaCargaRequerimientos.Image = CType(resources.GetObject("BtnIniciaCargaRequerimientos.Image"), System.Drawing.Image)
        Me.BtnIniciaCargaRequerimientos.Location = New System.Drawing.Point(416, 3)
        Me.BtnIniciaCargaRequerimientos.Name = "BtnIniciaCargaRequerimientos"
        Me.BtnIniciaCargaRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.BtnIniciaCargaRequerimientos.TabIndex = 76
        Me.BtnIniciaCargaRequerimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnIniciaCargaRequerimientos.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_RegistroValorRequerimientos
        '
        Me.Cancelar_Menu_RegistroValorRequerimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_RegistroValorRequerimientos.Image = CType(resources.GetObject("Cancelar_Menu_RegistroValorRequerimientos.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_RegistroValorRequerimientos.Location = New System.Drawing.Point(102, 3)
        Me.Cancelar_Menu_RegistroValorRequerimientos.Name = "Cancelar_Menu_RegistroValorRequerimientos"
        Me.Cancelar_Menu_RegistroValorRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_RegistroValorRequerimientos.TabIndex = 75
        Me.Cancelar_Menu_RegistroValorRequerimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_RegistroValorRequerimientos.UseVisualStyleBackColor = True
        '
        'Editar_Menu_RegistroValorRequerimientos
        '
        Me.Editar_Menu_RegistroValorRequerimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_RegistroValorRequerimientos.Image = CType(resources.GetObject("Editar_Menu_RegistroValorRequerimientos.Image"), System.Drawing.Image)
        Me.Editar_Menu_RegistroValorRequerimientos.Location = New System.Drawing.Point(11, 3)
        Me.Editar_Menu_RegistroValorRequerimientos.Name = "Editar_Menu_RegistroValorRequerimientos"
        Me.Editar_Menu_RegistroValorRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_RegistroValorRequerimientos.TabIndex = 74
        Me.Editar_Menu_RegistroValorRequerimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_RegistroValorRequerimientos.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_RegistroValorRequerimientos
        '
        Me.Actualizar_Menu_RegistroValorRequerimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_RegistroValorRequerimientos.Image = CType(resources.GetObject("Actualizar_Menu_RegistroValorRequerimientos.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_RegistroValorRequerimientos.Location = New System.Drawing.Point(57, 3)
        Me.Actualizar_Menu_RegistroValorRequerimientos.Name = "Actualizar_Menu_RegistroValorRequerimientos"
        Me.Actualizar_Menu_RegistroValorRequerimientos.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_RegistroValorRequerimientos.TabIndex = 73
        Me.Actualizar_Menu_RegistroValorRequerimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_RegistroValorRequerimientos.UseVisualStyleBackColor = True
        '
        'TP_Generar
        '
        Me.TP_Generar.Controls.Add(Me.TabControl6)
        Me.TP_Generar.Location = New System.Drawing.Point(4, 25)
        Me.TP_Generar.Name = "TP_Generar"
        Me.TP_Generar.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Generar.Size = New System.Drawing.Size(486, 592)
        Me.TP_Generar.TabIndex = 3
        Me.TP_Generar.Text = "Generación"
        Me.TP_Generar.UseVisualStyleBackColor = True
        '
        'TabControl6
        '
        Me.TabControl6.Controls.Add(Me.TP_CarpetasArchivos)
        Me.TabControl6.Controls.Add(Me.TabPage7)
        Me.TabControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl6.Location = New System.Drawing.Point(3, 3)
        Me.TabControl6.Name = "TabControl6"
        Me.TabControl6.SelectedIndex = 0
        Me.TabControl6.Size = New System.Drawing.Size(480, 586)
        Me.TabControl6.TabIndex = 0
        '
        'TP_CarpetasArchivos
        '
        Me.TP_CarpetasArchivos.Controls.Add(Me.Panel4)
        Me.TP_CarpetasArchivos.Location = New System.Drawing.Point(4, 25)
        Me.TP_CarpetasArchivos.Name = "TP_CarpetasArchivos"
        Me.TP_CarpetasArchivos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_CarpetasArchivos.Size = New System.Drawing.Size(472, 557)
        Me.TP_CarpetasArchivos.TabIndex = 0
        Me.TP_CarpetasArchivos.Text = "Crear Carpetas Archivos"
        Me.TP_CarpetasArchivos.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BtnCreacion)
        Me.Panel4.Controls.Add(Me.ChkCreaCarpetasYArchivos)
        Me.Panel4.Controls.Add(Me.ChkCreaDocumentoTecnico)
        Me.Panel4.Controls.Add(Me.RBExistente)
        Me.Panel4.Controls.Add(Me.RBNuevo)
        Me.Panel4.Controls.Add(Me.AdmiteCreacionCheckBox)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(466, 94)
        Me.Panel4.TabIndex = 228
        '
        'BtnCreacion
        '
        Me.BtnCreacion.BackColor = System.Drawing.Color.White
        Me.BtnCreacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreacion.Image = CType(resources.GetObject("BtnCreacion.Image"), System.Drawing.Image)
        Me.BtnCreacion.Location = New System.Drawing.Point(428, 3)
        Me.BtnCreacion.Name = "BtnCreacion"
        Me.BtnCreacion.Size = New System.Drawing.Size(33, 44)
        Me.BtnCreacion.TabIndex = 228
        Me.BtnCreacion.Text = " V"
        Me.BtnCreacion.UseVisualStyleBackColor = False
        '
        'ChkCreaCarpetasYArchivos
        '
        Me.ChkCreaCarpetasYArchivos.AutoSize = True
        Me.ChkCreaCarpetasYArchivos.Location = New System.Drawing.Point(3, 3)
        Me.ChkCreaCarpetasYArchivos.Name = "ChkCreaCarpetasYArchivos"
        Me.ChkCreaCarpetasYArchivos.Size = New System.Drawing.Size(275, 20)
        Me.ChkCreaCarpetasYArchivos.TabIndex = 223
        Me.ChkCreaCarpetasYArchivos.Text = "Generar Carpetas y Archivos de Proyecto"
        Me.ChkCreaCarpetasYArchivos.UseVisualStyleBackColor = True
        '
        'ChkCreaDocumentoTecnico
        '
        Me.ChkCreaDocumentoTecnico.AutoSize = True
        Me.ChkCreaDocumentoTecnico.Location = New System.Drawing.Point(3, 22)
        Me.ChkCreaDocumentoTecnico.Name = "ChkCreaDocumentoTecnico"
        Me.ChkCreaDocumentoTecnico.Size = New System.Drawing.Size(204, 20)
        Me.ChkCreaDocumentoTecnico.TabIndex = 224
        Me.ChkCreaDocumentoTecnico.Text = "Crear Un Documento Tecnico"
        Me.ChkCreaDocumentoTecnico.UseVisualStyleBackColor = True
        '
        'RBExistente
        '
        Me.RBExistente.AutoSize = True
        Me.RBExistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBExistente.ForeColor = System.Drawing.Color.ForestGreen
        Me.RBExistente.Location = New System.Drawing.Point(207, 68)
        Me.RBExistente.Name = "RBExistente"
        Me.RBExistente.Size = New System.Drawing.Size(231, 17)
        Me.RBExistente.TabIndex = 227
        Me.RBExistente.TabStop = True
        Me.RBExistente.Text = "Crear Sobre Proyecto ""EXISTENTE"""
        Me.RBExistente.UseVisualStyleBackColor = True
        '
        'RBNuevo
        '
        Me.RBNuevo.AutoSize = True
        Me.RBNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBNuevo.ForeColor = System.Drawing.Color.Blue
        Me.RBNuevo.Location = New System.Drawing.Point(3, 68)
        Me.RBNuevo.Name = "RBNuevo"
        Me.RBNuevo.Size = New System.Drawing.Size(168, 17)
        Me.RBNuevo.TabIndex = 226
        Me.RBNuevo.TabStop = True
        Me.RBNuevo.Text = "Crear Proyecto ""NUEVO"""
        Me.RBNuevo.UseVisualStyleBackColor = True
        '
        'AdmiteCreacionCheckBox
        '
        Me.AdmiteCreacionCheckBox.AutoSize = True
        Me.AdmiteCreacionCheckBox.Enabled = False
        Me.AdmiteCreacionCheckBox.Location = New System.Drawing.Point(3, 42)
        Me.AdmiteCreacionCheckBox.Name = "AdmiteCreacionCheckBox"
        Me.AdmiteCreacionCheckBox.Size = New System.Drawing.Size(126, 20)
        Me.AdmiteCreacionCheckBox.TabIndex = 225
        Me.AdmiteCreacionCheckBox.Text = "Admite Creación"
        Me.AdmiteCreacionCheckBox.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 25)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(472, 557)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TP_Proyectos)
        Me.TabControl1.Controls.Add(Me.TP_Admin)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(467, 621)
        Me.TabControl1.TabIndex = 0
        '
        'TP_Proyectos
        '
        Me.TP_Proyectos.Controls.Add(Me.LblInforme)
        Me.TP_Proyectos.Controls.Add(Me.ProyectosDataGridView)
        Me.TP_Proyectos.Controls.Add(Me.PanelAdministracion_)
        Me.TP_Proyectos.Controls.Add(DescripcionLabel)
        Me.TP_Proyectos.Controls.Add(NombreProyectoLabel)
        Me.TP_Proyectos.Controls.Add(Me.DescripcionTextBox)
        Me.TP_Proyectos.Controls.Add(Me.NombreProyectoTextBox)
        Me.TP_Proyectos.Location = New System.Drawing.Point(4, 25)
        Me.TP_Proyectos.Name = "TP_Proyectos"
        Me.TP_Proyectos.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Proyectos.Size = New System.Drawing.Size(459, 592)
        Me.TP_Proyectos.TabIndex = 0
        Me.TP_Proyectos.Text = "Proyectos"
        Me.TP_Proyectos.UseVisualStyleBackColor = True
        '
        'LblInforme
        '
        Me.LblInforme.BackColor = System.Drawing.Color.Chartreuse
        Me.LblInforme.Font = New System.Drawing.Font("Candara", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforme.Location = New System.Drawing.Point(48, 157)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(350, 64)
        Me.LblInforme.TabIndex = 0
        Me.LblInforme.Text = "..."
        Me.LblInforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblInforme.Visible = False
        '
        'ProyectosDataGridView
        '
        Me.ProyectosDataGridView.AllowUserToAddRows = False
        Me.ProyectosDataGridView.AutoGenerateColumns = False
        Me.ProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProyectosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ProyectosDataGridView.DataSource = Me.ProyectosBindingSource
        Me.ProyectosDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProyectosDataGridView.Location = New System.Drawing.Point(3, 266)
        Me.ProyectosDataGridView.Name = "ProyectosDataGridView"
        Me.ProyectosDataGridView.RowHeadersVisible = False
        Me.ProyectosDataGridView.Size = New System.Drawing.Size(453, 323)
        Me.ProyectosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProyectoID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cod"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreProyecto"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Proyecto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 416
        '
        'ProyectosBindingSource
        '
        Me.ProyectosBindingSource.DataMember = "Proyectos"
        Me.ProyectosBindingSource.DataSource = Me.DataSetAdministracion
        '
        'PanelAdministracion_
        '
        Me.PanelAdministracion_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelAdministracion_.Controls.Add(Me.Nuevo_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Cancelar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Eliminar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Editar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Actualizar_Menu_Proyectos)
        Me.PanelAdministracion_.Controls.Add(Me.Guardar_Menu_Proyectos)
        Me.PanelAdministracion_.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdministracion_.Location = New System.Drawing.Point(3, 3)
        Me.PanelAdministracion_.Name = "PanelAdministracion_"
        Me.PanelAdministracion_.Size = New System.Drawing.Size(453, 46)
        Me.PanelAdministracion_.TabIndex = 91
        '
        'Nuevo_Menu_Proyectos
        '
        Me.Nuevo_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Nuevo_Menu_Proyectos.Image = CType(resources.GetObject("Nuevo_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Nuevo_Menu_Proyectos.Location = New System.Drawing.Point(4, 3)
        Me.Nuevo_Menu_Proyectos.Name = "Nuevo_Menu_Proyectos"
        Me.Nuevo_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Nuevo_Menu_Proyectos.TabIndex = 70
        Me.Nuevo_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Cancelar_Menu_Proyectos
        '
        Me.Cancelar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancelar_Menu_Proyectos.Image = CType(resources.GetObject("Cancelar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Cancelar_Menu_Proyectos.Location = New System.Drawing.Point(233, 3)
        Me.Cancelar_Menu_Proyectos.Name = "Cancelar_Menu_Proyectos"
        Me.Cancelar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Cancelar_Menu_Proyectos.TabIndex = 75
        Me.Cancelar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Cancelar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Eliminar_Menu_Proyectos
        '
        Me.Eliminar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Eliminar_Menu_Proyectos.Image = CType(resources.GetObject("Eliminar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Eliminar_Menu_Proyectos.Location = New System.Drawing.Point(188, 3)
        Me.Eliminar_Menu_Proyectos.Name = "Eliminar_Menu_Proyectos"
        Me.Eliminar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Eliminar_Menu_Proyectos.TabIndex = 72
        Me.Eliminar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Editar_Menu_Proyectos
        '
        Me.Editar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Editar_Menu_Proyectos.Image = CType(resources.GetObject("Editar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Editar_Menu_Proyectos.Location = New System.Drawing.Point(96, 3)
        Me.Editar_Menu_Proyectos.Name = "Editar_Menu_Proyectos"
        Me.Editar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Editar_Menu_Proyectos.TabIndex = 74
        Me.Editar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Editar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Actualizar_Menu_Proyectos
        '
        Me.Actualizar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Actualizar_Menu_Proyectos.Image = CType(resources.GetObject("Actualizar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Actualizar_Menu_Proyectos.Location = New System.Drawing.Point(142, 3)
        Me.Actualizar_Menu_Proyectos.Name = "Actualizar_Menu_Proyectos"
        Me.Actualizar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Actualizar_Menu_Proyectos.TabIndex = 73
        Me.Actualizar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Actualizar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'Guardar_Menu_Proyectos
        '
        Me.Guardar_Menu_Proyectos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar_Menu_Proyectos.Image = CType(resources.GetObject("Guardar_Menu_Proyectos.Image"), System.Drawing.Image)
        Me.Guardar_Menu_Proyectos.Location = New System.Drawing.Point(50, 3)
        Me.Guardar_Menu_Proyectos.Name = "Guardar_Menu_Proyectos"
        Me.Guardar_Menu_Proyectos.Size = New System.Drawing.Size(40, 38)
        Me.Guardar_Menu_Proyectos.TabIndex = 71
        Me.Guardar_Menu_Proyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Guardar_Menu_Proyectos.UseVisualStyleBackColor = True
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(7, 121)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(445, 138)
        Me.DescripcionTextBox.TabIndex = 93
        '
        'NombreProyectoTextBox
        '
        Me.NombreProyectoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "NombreProyecto", True))
        Me.NombreProyectoTextBox.Location = New System.Drawing.Point(7, 77)
        Me.NombreProyectoTextBox.Name = "NombreProyectoTextBox"
        Me.NombreProyectoTextBox.Size = New System.Drawing.Size(445, 22)
        Me.NombreProyectoTextBox.TabIndex = 92
        '
        'TP_Admin
        '
        Me.TP_Admin.Controls.Add(Me.Button2)
        Me.TP_Admin.Location = New System.Drawing.Point(4, 25)
        Me.TP_Admin.Name = "TP_Admin"
        Me.TP_Admin.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Admin.Size = New System.Drawing.Size(459, 592)
        Me.TP_Admin.TabIndex = 3
        Me.TP_Admin.Text = "Admin"
        Me.TP_Admin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 32)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Ver Tablas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel_Tecnologias
        '
        Me.Panel_Tecnologias.AutoScroll = True
        Me.Panel_Tecnologias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Tecnologias.Controls.Add(ContenidoRelacionLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.ContenidoRelacionTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView)
        Me.Panel_Tecnologias.Controls.Add(Me.Label21)
        Me.Panel_Tecnologias.Controls.Add(Me.Label19)
        Me.Panel_Tecnologias.Controls.Add(TipoLabel4)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(MultiReplaceLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.MultiReplaceTextBox)
        Me.Panel_Tecnologias.Controls.Add(SeparadorCamposLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.SeparadorCamposTextBox)
        Me.Panel_Tecnologias.Controls.Add(InferiorLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.InferiorTextBox)
        Me.Panel_Tecnologias.Controls.Add(SufijoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.SufijoTextBox)
        Me.Panel_Tecnologias.Controls.Add(SuperiorLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.SuperiorTextBox)
        Me.Panel_Tecnologias.Controls.Add(PrefijoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.PrefijoTextBox)
        Me.Panel_Tecnologias.Controls.Add(ContenidoXTablaLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.ContenidoXTablaTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.Label18)
        Me.Panel_Tecnologias.Controls.Add(NombreArchivoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.NombreArchivoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(ExtensionArchivoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.ExtensionArchivoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(RutaLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.RutaGeneracion)
        Me.Panel_Tecnologias.Controls.Add(Me.Label17)
        Me.Panel_Tecnologias.Controls.Add(NombreCampoLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.NombreCampoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView)
        Me.Panel_Tecnologias.Controls.Add(TextoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.TextoTextBox)
        Me.Panel_Tecnologias.Controls.Add(ValorRequerimientoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.ValorRequerimientoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(RequerimientoLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.RequerimientoGeneracion)
        Me.Panel_Tecnologias.Controls.Add(Me.DGV_RequerimientosProyecto)
        Me.Panel_Tecnologias.Controls.Add(NombreTablaLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.NombreTablaTextBox1)
        Me.Panel_Tecnologias.Controls.Add(TablaIDLabel4)
        Me.Panel_Tecnologias.Controls.Add(Me.TablaIDGeneracion)
        Me.Panel_Tecnologias.Controls.Add(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView)
        Me.Panel_Tecnologias.Controls.Add(Me.CodigoAProcesar)
        Me.Panel_Tecnologias.Controls.Add(XBaseLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.XBaseCheckBox)
        Me.Panel_Tecnologias.Controls.Add(XTablaLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.XTablaCheckBox)
        Me.Panel_Tecnologias.Controls.Add(NombreComponenteLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.NombreComponenteTextBox)
        Me.Panel_Tecnologias.Controls.Add(CodigoDependienteLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.CodigoDependienteTextBox)
        Me.Panel_Tecnologias.Controls.Add(CodigoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.CodigoTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.DGV_ComponentesGeneracion)
        Me.Panel_Tecnologias.Controls.Add(Me.Label1)
        Me.Panel_Tecnologias.Controls.Add(PlantillaIDLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.PlantillaIDRequerimientos)
        Me.Panel_Tecnologias.Controls.Add(Me.PlantillaID_Techanged_Generacion_CargaComponentes)
        Me.Panel_Tecnologias.Controls.Add(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView)
        Me.Panel_Tecnologias.Controls.Add(Me.DGV_PlantillasAplicadas)
        Me.Panel_Tecnologias.Controls.Add(Label15)
        Me.Panel_Tecnologias.Controls.Add(Me.IDRequerimiento)
        Me.Panel_Tecnologias.Controls.Add(Me.EnunciadoTextBox)
        Me.Panel_Tecnologias.Controls.Add(EnunciadoLabel)
        Me.Panel_Tecnologias.Controls.Add(RequerimientoLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.RequerimientoTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.Label14)
        Me.Panel_Tecnologias.Controls.Add(Label12)
        Me.Panel_Tecnologias.Controls.Add(Me.RegistroRelacionesTablasIDEdicion)
        Me.Panel_Tecnologias.Controls.Add(Label10)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoCTI)
        Me.Panel_Tecnologias.Controls.Add(Label9)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoCTD)
        Me.Panel_Tecnologias.Controls.Add(RegistroRelacionesTablasIDLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.RegistroRelacionesTablasIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(Label8)
        Me.Panel_Tecnologias.Controls.Add(CampoIDLabel2)
        Me.Panel_Tecnologias.Controls.Add(Me.CampoID_Depend)
        Me.Panel_Tecnologias.Controls.Add(CampoIDLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.CampoID_Independiente)
        Me.Panel_Tecnologias.Controls.Add(TablaIDLabel3)
        Me.Panel_Tecnologias.Controls.Add(Me.TablaID_Independiente)
        Me.Panel_Tecnologias.Controls.Add(TablaIDLabel2)
        Me.Panel_Tecnologias.Controls.Add(Me.TablaID_Depend)
        Me.Panel_Tecnologias.Controls.Add(Me.Label7)
        Me.Panel_Tecnologias.Controls.Add(TablaIDLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.TablaIDRelacionados)
        Me.Panel_Tecnologias.Controls.Add(CampoIDLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.CampoIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(TipoLabel3)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoCampoDesdeTabla)
        Me.Panel_Tecnologias.Controls.Add(TipoLabel2)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoCampoDesdeCombo)
        Me.Panel_Tecnologias.Controls.Add(Me.Label5)
        Me.Panel_Tecnologias.Controls.Add(Me.Label4)
        Me.Panel_Tecnologias.Controls.Add(Me.Label3)
        Me.Panel_Tecnologias.Controls.Add(Me.Label2)
        Me.Panel_Tecnologias.Controls.Add(TipoLabel1)
        Me.Panel_Tecnologias.Controls.Add(TablaIDLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.TipoTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.TablaIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.ProyectoIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(ProyectoIDLabel)
        Me.Panel_Tecnologias.Controls.Add(TecnologiaIDLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.TecnologiaIDParaEliminarPorTecnologia)
        Me.Panel_Tecnologias.Controls.Add(ProyectoIDLabel1)
        Me.Panel_Tecnologias.Controls.Add(Me.ProyectoIDParaEliminarPorTecnologia)
        Me.Panel_Tecnologias.Controls.Add(ProyectosYTecnologiasIDLabel)
        Me.Panel_Tecnologias.Controls.Add(PlantillaIDLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.ControlNulos)
        Me.Panel_Tecnologias.Controls.Add(Me.PlantillaIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(Me.ProyectosYTecnologiasIDTextBox)
        Me.Panel_Tecnologias.Controls.Add(TecnologiaIDLabel)
        Me.Panel_Tecnologias.Controls.Add(Me.TecnologiaIDTextBox)
        Me.Panel_Tecnologias.Location = New System.Drawing.Point(1013, 259)
        Me.Panel_Tecnologias.Name = "Panel_Tecnologias"
        Me.Panel_Tecnologias.Size = New System.Drawing.Size(184, 216)
        Me.Panel_Tecnologias.TabIndex = 1
        '
        'ContenidoRelacionTextBox
        '
        Me.ContenidoRelacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, "ContenidoRelacion", True))
        Me.ContenidoRelacionTextBox.Location = New System.Drawing.Point(2105, 444)
        Me.ContenidoRelacionTextBox.Name = "ContenidoRelacionTextBox"
        Me.ContenidoRelacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContenidoRelacionTextBox.TabIndex = 257
        '
        'SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource
        '
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource.DataMember = "SP_CARGA_TablasRelacionadas_SEGUN_PlantillaID"
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.AllowUserToAddRows = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.AutoGenerateColumns = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.DataGridViewTextBoxColumn50, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn56})
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.DataSource = Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Location = New System.Drawing.Point(1944, 278)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Name = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.RowHeadersVisible = False
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.Size = New System.Drawing.Size(300, 149)
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView.TabIndex = 256
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "TablaDependiente"
        Me.DataGridViewTextBoxColumn47.HeaderText = "TablaDependiente"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "CampoDependiente"
        Me.DataGridViewTextBoxColumn48.HeaderText = "CampoDependiente"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn49.HeaderText = "TablaIndependiente"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn50.HeaderText = "CampoIndependiente"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "RegistroRelacionesTablasID"
        Me.DataGridViewTextBoxColumn51.HeaderText = "RegistroRelacionesTablasID"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "ID_TD"
        Me.DataGridViewTextBoxColumn52.HeaderText = "ID_TD"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "ID_CTD"
        Me.DataGridViewTextBoxColumn53.HeaderText = "ID_CTD"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "ID_TI"
        Me.DataGridViewTextBoxColumn54.HeaderText = "ID_TI"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "ID_CTI"
        Me.DataGridViewTextBoxColumn56.HeaderText = "ID_CTI"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1953, 248)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(268, 16)
        Me.Label21.TabIndex = 256
        Me.Label21.Text = "TABLAS Y CAMPOS RELACIONADOS"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1953, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(209, 16)
        Me.Label19.TabIndex = 255
        Me.Label19.Text = "TRATAMIENTO DE CAMPOS"
        '
        'TipoGeneracion
        '
        Me.TipoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource, "Tipo", True))
        Me.TipoGeneracion.Location = New System.Drawing.Point(1239, 475)
        Me.TipoGeneracion.Name = "TipoGeneracion"
        Me.TipoGeneracion.Size = New System.Drawing.Size(124, 20)
        Me.TipoGeneracion.TabIndex = 254
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource.DataMember = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'MultiReplaceTextBox
        '
        Me.MultiReplaceTextBox.Location = New System.Drawing.Point(2121, 109)
        Me.MultiReplaceTextBox.Multiline = True
        Me.MultiReplaceTextBox.Name = "MultiReplaceTextBox"
        Me.MultiReplaceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MultiReplaceTextBox.TabIndex = 253
        '
        'SeparadorCamposTextBox
        '
        Me.SeparadorCamposTextBox.Location = New System.Drawing.Point(2121, 55)
        Me.SeparadorCamposTextBox.Name = "SeparadorCamposTextBox"
        Me.SeparadorCamposTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SeparadorCamposTextBox.TabIndex = 252
        '
        'InferiorTextBox
        '
        Me.InferiorTextBox.Location = New System.Drawing.Point(2002, 113)
        Me.InferiorTextBox.Name = "InferiorTextBox"
        Me.InferiorTextBox.Size = New System.Drawing.Size(57, 20)
        Me.InferiorTextBox.TabIndex = 249
        '
        'SufijoTextBox
        '
        Me.SufijoTextBox.Location = New System.Drawing.Point(2062, 90)
        Me.SufijoTextBox.Name = "SufijoTextBox"
        Me.SufijoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SufijoTextBox.TabIndex = 248
        '
        'SuperiorTextBox
        '
        Me.SuperiorTextBox.Location = New System.Drawing.Point(2002, 64)
        Me.SuperiorTextBox.Name = "SuperiorTextBox"
        Me.SuperiorTextBox.Size = New System.Drawing.Size(57, 20)
        Me.SuperiorTextBox.TabIndex = 246
        '
        'PrefijoTextBox
        '
        Me.PrefijoTextBox.Location = New System.Drawing.Point(1944, 90)
        Me.PrefijoTextBox.Name = "PrefijoTextBox"
        Me.PrefijoTextBox.Size = New System.Drawing.Size(57, 20)
        Me.PrefijoTextBox.TabIndex = 244
        '
        'ContenidoXTablaTextBox
        '
        Me.ContenidoXTablaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "ContenidoXTabla", True))
        Me.ContenidoXTablaTextBox.Location = New System.Drawing.Point(1681, 278)
        Me.ContenidoXTablaTextBox.Multiline = True
        Me.ContenidoXTablaTextBox.Name = "ContenidoXTablaTextBox"
        Me.ContenidoXTablaTextBox.Size = New System.Drawing.Size(250, 88)
        Me.ContenidoXTablaTextBox.TabIndex = 241
        '
        'SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource
        '
        Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataMember = "SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID"
        Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1678, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(231, 16)
        Me.Label18.TabIndex = 240
        Me.Label18.Text = "COMPONENTES PARA TABLAS"
        '
        'NombreArchivoGeneracion
        '
        Me.NombreArchivoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "NombreArchivo", True))
        Me.NombreArchivoGeneracion.Location = New System.Drawing.Point(1831, 90)
        Me.NombreArchivoGeneracion.Name = "NombreArchivoGeneracion"
        Me.NombreArchivoGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.NombreArchivoGeneracion.TabIndex = 239
        '
        'SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource
        '
        Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataMember = "SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteID"
        Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'ExtensionArchivoGeneracion
        '
        Me.ExtensionArchivoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "ExtensionArchivo", True))
        Me.ExtensionArchivoGeneracion.Location = New System.Drawing.Point(1831, 61)
        Me.ExtensionArchivoGeneracion.Name = "ExtensionArchivoGeneracion"
        Me.ExtensionArchivoGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.ExtensionArchivoGeneracion.TabIndex = 238
        '
        'RutaGeneracion
        '
        Me.RutaGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, "Ruta", True))
        Me.RutaGeneracion.Location = New System.Drawing.Point(1831, 33)
        Me.RutaGeneracion.Name = "RutaGeneracion"
        Me.RutaGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.RutaGeneracion.TabIndex = 237
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1678, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(265, 16)
        Me.Label17.TabIndex = 236
        Me.Label17.Text = "RUTAS DE ARCHIVOS GENERADOS"
        '
        'NombreCampoGeneracion
        '
        Me.NombreCampoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource, "NombreCampo", True))
        Me.NombreCampoGeneracion.Location = New System.Drawing.Point(1239, 451)
        Me.NombreCampoGeneracion.Name = "NombreCampoGeneracion"
        Me.NombreCampoGeneracion.Size = New System.Drawing.Size(124, 20)
        Me.NombreCampoGeneracion.TabIndex = 235
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.AllowUserToAddRows = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.AutoGenerateColumns = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn43, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn46})
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.DataSource = Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.Location = New System.Drawing.Point(1126, 306)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.Name = "SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView"
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.RowHeadersVisible = False
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.Size = New System.Drawing.Size(237, 139)
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView.TabIndex = 234
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "CampoID"
        Me.DataGridViewTextBoxColumn43.HeaderText = "CampoID"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.ReadOnly = True
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "TablaID"
        Me.DataGridViewTextBoxColumn44.HeaderText = "TablaID"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn45.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "NombreCampo"
        Me.DataGridViewTextBoxColumn46.HeaderText = "NombreCampo"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'TextoTextBox
        '
        Me.TextoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource, "Texto", True))
        Me.TextoTextBox.Location = New System.Drawing.Point(1543, 264)
        Me.TextoTextBox.Name = "TextoTextBox"
        Me.TextoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TextoTextBox.TabIndex = 234
        '
        'SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource
        '
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource.DataMember = "SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_"
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'ValorRequerimientoGeneracion
        '
        Me.ValorRequerimientoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource, "ValorRequerimiento", True))
        Me.ValorRequerimientoGeneracion.Location = New System.Drawing.Point(1543, 237)
        Me.ValorRequerimientoGeneracion.Name = "ValorRequerimientoGeneracion"
        Me.ValorRequerimientoGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.ValorRequerimientoGeneracion.TabIndex = 233
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource.DataMember = "SP_RegistroValorRequerimientos_SEGUN_ProyectoID1"
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'RequerimientoGeneracion
        '
        Me.RequerimientoGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource, "Requerimiento", True))
        Me.RequerimientoGeneracion.Location = New System.Drawing.Point(1543, 209)
        Me.RequerimientoGeneracion.Name = "RequerimientoGeneracion"
        Me.RequerimientoGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.RequerimientoGeneracion.TabIndex = 232
        '
        'DGV_RequerimientosProyecto
        '
        Me.DGV_RequerimientosProyecto.AllowUserToAddRows = False
        Me.DGV_RequerimientosProyecto.AutoGenerateColumns = False
        Me.DGV_RequerimientosProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_RequerimientosProyecto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42})
        Me.DGV_RequerimientosProyecto.DataSource = Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource
        Me.DGV_RequerimientosProyecto.Location = New System.Drawing.Point(1369, 33)
        Me.DGV_RequerimientosProyecto.Name = "DGV_RequerimientosProyecto"
        Me.DGV_RequerimientosProyecto.RowHeadersVisible = False
        Me.DGV_RequerimientosProyecto.Size = New System.Drawing.Size(300, 170)
        Me.DGV_RequerimientosProyecto.TabIndex = 231
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "RegistroValorRequerimientoID"
        Me.DataGridViewTextBoxColumn39.HeaderText = "RegistroValorRequerimientoID"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.ReadOnly = True
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "ProyectoID"
        Me.DataGridViewTextBoxColumn40.HeaderText = "ProyectoID"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "ValorRequerimiento"
        Me.DataGridViewTextBoxColumn42.HeaderText = "ValorRequerimiento"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'NombreTablaTextBox1
        '
        Me.NombreTablaTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, "NombreTabla", True))
        Me.NombreTablaTextBox1.Location = New System.Drawing.Point(1126, 278)
        Me.NombreTablaTextBox1.Name = "NombreTablaTextBox1"
        Me.NombreTablaTextBox1.Size = New System.Drawing.Size(234, 20)
        Me.NombreTablaTextBox1.TabIndex = 231
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource.DataMember = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'TablaIDGeneracion
        '
        Me.TablaIDGeneracion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, "TablaID", True))
        Me.TablaIDGeneracion.Location = New System.Drawing.Point(1126, 229)
        Me.TablaIDGeneracion.Name = "TablaIDGeneracion"
        Me.TablaIDGeneracion.Size = New System.Drawing.Size(100, 20)
        Me.TablaIDGeneracion.TabIndex = 230
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.AllowUserToAddRows = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.AutoGenerateColumns = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewCheckBoxColumn5})
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.DataSource = Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Location = New System.Drawing.Point(1126, 33)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Name = "SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView"
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.RowHeadersVisible = False
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.Size = New System.Drawing.Size(237, 170)
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView.TabIndex = 229
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "TablaID"
        Me.DataGridViewTextBoxColumn36.HeaderText = "TablaID"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "ProyectoID"
        Me.DataGridViewTextBoxColumn37.HeaderText = "ProyectoID"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "NombreTabla"
        Me.DataGridViewTextBoxColumn38.HeaderText = "NombreTabla"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Tipo"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Tipo"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'CodigoAProcesar
        '
        Me.CodigoAProcesar.Location = New System.Drawing.Point(638, 416)
        Me.CodigoAProcesar.Multiline = True
        Me.CodigoAProcesar.Name = "CodigoAProcesar"
        Me.CodigoAProcesar.Size = New System.Drawing.Size(442, 89)
        Me.CodigoAProcesar.TabIndex = 229
        '
        'XBaseCheckBox
        '
        Me.XBaseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XBase", True))
        Me.XBaseCheckBox.Location = New System.Drawing.Point(699, 353)
        Me.XBaseCheckBox.Name = "XBaseCheckBox"
        Me.XBaseCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.XBaseCheckBox.TabIndex = 220
        Me.XBaseCheckBox.UseVisualStyleBackColor = True
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'XTablaCheckBox
        '
        Me.XTablaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "XTabla", True))
        Me.XTablaCheckBox.Location = New System.Drawing.Point(699, 326)
        Me.XTablaCheckBox.Name = "XTablaCheckBox"
        Me.XTablaCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.XTablaCheckBox.TabIndex = 219
        Me.XTablaCheckBox.UseVisualStyleBackColor = True
        '
        'NombreComponenteTextBox
        '
        Me.NombreComponenteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "NombreComponente", True))
        Me.NombreComponenteTextBox.Location = New System.Drawing.Point(638, 293)
        Me.NombreComponenteTextBox.Name = "NombreComponenteTextBox"
        Me.NombreComponenteTextBox.Size = New System.Drawing.Size(442, 20)
        Me.NombreComponenteTextBox.TabIndex = 218
        '
        'CodigoDependienteTextBox
        '
        Me.CodigoDependienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "CodigoDependiente", True))
        Me.CodigoDependienteTextBox.Location = New System.Drawing.Point(884, 229)
        Me.CodigoDependienteTextBox.Multiline = True
        Me.CodigoDependienteTextBox.Name = "CodigoDependienteTextBox"
        Me.CodigoDependienteTextBox.Size = New System.Drawing.Size(236, 38)
        Me.CodigoDependienteTextBox.TabIndex = 217
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Codigo", True))
        Me.CodigoTextBox.Location = New System.Drawing.Point(638, 231)
        Me.CodigoTextBox.Multiline = True
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(236, 36)
        Me.CodigoTextBox.TabIndex = 216
        '
        'DGV_ComponentesGeneracion
        '
        Me.DGV_ComponentesGeneracion.AllowUserToAddRows = False
        Me.DGV_ComponentesGeneracion.AutoGenerateColumns = False
        Me.DGV_ComponentesGeneracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ComponentesGeneracion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewTextBoxColumn35})
        Me.DGV_ComponentesGeneracion.DataSource = Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.DGV_ComponentesGeneracion.Location = New System.Drawing.Point(877, 33)
        Me.DGV_ComponentesGeneracion.Name = "DGV_ComponentesGeneracion"
        Me.DGV_ComponentesGeneracion.RowHeadersVisible = False
        Me.DGV_ComponentesGeneracion.Size = New System.Drawing.Size(239, 170)
        Me.DGV_ComponentesGeneracion.TabIndex = 215
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "ComponenteID"
        Me.DataGridViewTextBoxColumn30.HeaderText = "ComponenteID"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "PlantillaID"
        Me.DataGridViewTextBoxColumn32.HeaderText = "PlantillaID"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "NombreComponente"
        Me.DataGridViewTextBoxColumn33.HeaderText = "NombreComponente"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Codigo"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "XTabla"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "XTabla"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "XBase"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "XBase"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "CodigoDependiente"
        Me.DataGridViewTextBoxColumn35.HeaderText = "CodigoDependiente"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(632, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 16)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "GENERACION ARCHIVOS"
        '
        'PlantillaIDRequerimientos
        '
        Me.PlantillaIDRequerimientos.BackColor = System.Drawing.Color.Turquoise
        Me.PlantillaIDRequerimientos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "PlantillaID", True))
        Me.PlantillaIDRequerimientos.Location = New System.Drawing.Point(110, 200)
        Me.PlantillaIDRequerimientos.Name = "PlantillaIDRequerimientos"
        Me.PlantillaIDRequerimientos.Size = New System.Drawing.Size(82, 20)
        Me.PlantillaIDRequerimientos.TabIndex = 213
        '
        'PlantillaID_Techanged_Generacion_CargaComponentes
        '
        Me.PlantillaID_Techanged_Generacion_CargaComponentes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource, "PlantillaID", True))
        Me.PlantillaID_Techanged_Generacion_CargaComponentes.Location = New System.Drawing.Point(788, 181)
        Me.PlantillaID_Techanged_Generacion_CargaComponentes.Name = "PlantillaID_Techanged_Generacion_CargaComponentes"
        Me.PlantillaID_Techanged_Generacion_CargaComponentes.Size = New System.Drawing.Size(83, 20)
        Me.PlantillaID_Techanged_Generacion_CargaComponentes.TabIndex = 215
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource.DataMember = "SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1"
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AllowUserToAddRows = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.AutoGenerateColumns = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.DataSource = Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Location = New System.Drawing.Point(272, 382)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Name = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.RowHeadersVisible = False
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.Size = New System.Drawing.Size(41, 19)
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView.TabIndex = 192
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RequerimientoPlantillaID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RequerimientoPlantillaID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "PlantillaID"
        Me.DataGridViewTextBoxColumn17.HeaderText = "PlantillaID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Enunciado"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Enunciado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Requerimiento"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Requerimiento"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "OrdenDePeticion"
        Me.DataGridViewTextBoxColumn22.HeaderText = "OrdenDePeticion"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataMember = "SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaID"
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource.DataSource = Me.DataSetAdministracion
        '
        'DGV_PlantillasAplicadas
        '
        Me.DGV_PlantillasAplicadas.AllowUserToAddRows = False
        Me.DGV_PlantillasAplicadas.AutoGenerateColumns = False
        Me.DGV_PlantillasAplicadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PlantillasAplicadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn31})
        Me.DGV_PlantillasAplicadas.ContextMenuStrip = Me.CM_EliminacionPlantillas
        Me.DGV_PlantillasAplicadas.DataSource = Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource
        Me.DGV_PlantillasAplicadas.Location = New System.Drawing.Point(635, 33)
        Me.DGV_PlantillasAplicadas.Name = "DGV_PlantillasAplicadas"
        Me.DGV_PlantillasAplicadas.RowHeadersVisible = False
        Me.DGV_PlantillasAplicadas.Size = New System.Drawing.Size(239, 142)
        Me.DGV_PlantillasAplicadas.TabIndex = 214
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "NombrePlantilla"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Plantilla"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.ReadOnly = True
        Me.DataGridViewTextBoxColumn31.Width = 232
        '
        'IDRequerimiento
        '
        Me.IDRequerimiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "RequerimientoPlantillaID", True))
        Me.IDRequerimiento.Location = New System.Drawing.Point(272, 354)
        Me.IDRequerimiento.Name = "IDRequerimiento"
        Me.IDRequerimiento.Size = New System.Drawing.Size(41, 20)
        Me.IDRequerimiento.TabIndex = 211
        '
        'EnunciadoTextBox
        '
        Me.EnunciadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Enunciado", True))
        Me.EnunciadoTextBox.Location = New System.Drawing.Point(272, 298)
        Me.EnunciadoTextBox.Name = "EnunciadoTextBox"
        Me.EnunciadoTextBox.Size = New System.Drawing.Size(40, 20)
        Me.EnunciadoTextBox.TabIndex = 208
        '
        'RequerimientoTextBox
        '
        Me.RequerimientoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, "Requerimiento", True))
        Me.RequerimientoTextBox.Location = New System.Drawing.Point(272, 326)
        Me.RequerimientoTextBox.Name = "RequerimientoTextBox"
        Me.RequerimientoTextBox.Size = New System.Drawing.Size(41, 20)
        Me.RequerimientoTextBox.TabIndex = 210
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(269, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 16)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "REQUERIMIENTOS"
        '
        'RegistroRelacionesTablasIDEdicion
        '
        Me.RegistroRelacionesTablasIDEdicion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, "RegistroRelacionesTablasID", True))
        Me.RegistroRelacionesTablasIDEdicion.Location = New System.Drawing.Point(272, 178)
        Me.RegistroRelacionesTablasIDEdicion.Name = "RegistroRelacionesTablasIDEdicion"
        Me.RegistroRelacionesTablasIDEdicion.Size = New System.Drawing.Size(41, 20)
        Me.RegistroRelacionesTablasIDEdicion.TabIndex = 117
        '
        'TipoCTI
        '
        Me.TipoCTI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, "Tipo", True))
        Me.TipoCTI.Location = New System.Drawing.Point(272, 231)
        Me.TipoCTI.Name = "TipoCTI"
        Me.TipoCTI.Size = New System.Drawing.Size(41, 20)
        Me.TipoCTI.TabIndex = 114
        '
        'TipoCTD
        '
        Me.TipoCTD.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, "Tipo", True))
        Me.TipoCTD.Location = New System.Drawing.Point(272, 203)
        Me.TipoCTD.Name = "TipoCTD"
        Me.TipoCTD.Size = New System.Drawing.Size(41, 20)
        Me.TipoCTD.TabIndex = 112
        '
        'RegistroRelacionesTablasIDTextBox
        '
        Me.RegistroRelacionesTablasIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, "RegistroRelacionesTablasID", True))
        Me.RegistroRelacionesTablasIDTextBox.Location = New System.Drawing.Point(272, 151)
        Me.RegistroRelacionesTablasIDTextBox.Name = "RegistroRelacionesTablasIDTextBox"
        Me.RegistroRelacionesTablasIDTextBox.Size = New System.Drawing.Size(41, 20)
        Me.RegistroRelacionesTablasIDTextBox.TabIndex = 110
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource.DataMember = "SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTI"
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'CampoID_Depend
        '
        Me.CampoID_Depend.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, "CampoID", True))
        Me.CampoID_Depend.Location = New System.Drawing.Point(272, 61)
        Me.CampoID_Depend.Name = "CampoID_Depend"
        Me.CampoID_Depend.Size = New System.Drawing.Size(41, 20)
        Me.CampoID_Depend.TabIndex = 108
        '
        'CampoID_Independiente
        '
        Me.CampoID_Independiente.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.CampoID_Independiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, "CampoID", True))
        Me.CampoID_Independiente.Location = New System.Drawing.Point(272, 120)
        Me.CampoID_Independiente.Name = "CampoID_Independiente"
        Me.CampoID_Independiente.Size = New System.Drawing.Size(41, 20)
        Me.CampoID_Independiente.TabIndex = 107
        '
        'TablaID_Independiente
        '
        Me.TablaID_Independiente.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TablaID_Independiente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource, "TablaID", True))
        Me.TablaID_Independiente.Location = New System.Drawing.Point(272, 92)
        Me.TablaID_Independiente.Name = "TablaID_Independiente"
        Me.TablaID_Independiente.Size = New System.Drawing.Size(41, 20)
        Me.TablaID_Independiente.TabIndex = 106
        '
        'TablaID_Depend
        '
        Me.TablaID_Depend.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TablaID_Depend.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource, "TablaID", True))
        Me.TablaID_Depend.Location = New System.Drawing.Point(272, 33)
        Me.TablaID_Depend.Name = "TablaID_Depend"
        Me.TablaID_Depend.Size = New System.Drawing.Size(41, 20)
        Me.TablaID_Depend.TabIndex = 105
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 16)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "CAMPOS RELACIONADOS"
        '
        'TablaIDRelacionados
        '
        Me.TablaIDRelacionados.BackColor = System.Drawing.Color.Turquoise
        Me.TablaIDRelacionados.Location = New System.Drawing.Point(8, 170)
        Me.TablaIDRelacionados.Name = "TablaIDRelacionados"
        Me.TablaIDRelacionados.Size = New System.Drawing.Size(43, 20)
        Me.TablaIDRelacionados.TabIndex = 103
        '
        'CampoIDTextBox
        '
        Me.CampoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "CampoID", True))
        Me.CampoIDTextBox.Location = New System.Drawing.Point(8, 407)
        Me.CampoIDTextBox.Name = "CampoIDTextBox"
        Me.CampoIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.CampoIDTextBox.TabIndex = 102
        '
        'TipoCampoDesdeTabla
        '
        Me.TipoCampoDesdeTabla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, "Tipo", True))
        Me.TipoCampoDesdeTabla.Location = New System.Drawing.Point(8, 379)
        Me.TipoCampoDesdeTabla.Name = "TipoCampoDesdeTabla"
        Me.TipoCampoDesdeTabla.Size = New System.Drawing.Size(43, 20)
        Me.TipoCampoDesdeTabla.TabIndex = 101
        '
        'TipoCampoDesdeCombo
        '
        Me.TipoCampoDesdeCombo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TiposBindingSource, "Tipo", True))
        Me.TipoCampoDesdeCombo.Location = New System.Drawing.Point(8, 351)
        Me.TipoCampoDesdeCombo.Name = "TipoCampoDesdeCombo"
        Me.TipoCampoDesdeCombo.Size = New System.Drawing.Size(43, 20)
        Me.TipoCampoDesdeCombo.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 331)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 16)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "CAMPOS DE TABLAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 16)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "ID TEXCHANGED"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "PROYECTOS Y TECNO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "TABLAS"
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(8, 227)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TipoTextBox.TabIndex = 95
        '
        'TablaIDTextBox
        '
        Me.TablaIDTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.TablaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, "TablaID", True))
        Me.TablaIDTextBox.Location = New System.Drawing.Point(8, 142)
        Me.TablaIDTextBox.Name = "TablaIDTextBox"
        Me.TablaIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TablaIDTextBox.TabIndex = 95
        '
        'ProyectoIDTextBox
        '
        Me.ProyectoIDTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.ProyectoIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "ProyectoID", True))
        Me.ProyectoIDTextBox.Location = New System.Drawing.Point(8, 30)
        Me.ProyectoIDTextBox.Name = "ProyectoIDTextBox"
        Me.ProyectoIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.ProyectoIDTextBox.TabIndex = 94
        '
        'TecnologiaIDParaEliminarPorTecnologia
        '
        Me.TecnologiaIDParaEliminarPorTecnologia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDParaEliminarPorTecnologia.Location = New System.Drawing.Point(8, 301)
        Me.TecnologiaIDParaEliminarPorTecnologia.Name = "TecnologiaIDParaEliminarPorTecnologia"
        Me.TecnologiaIDParaEliminarPorTecnologia.Size = New System.Drawing.Size(43, 20)
        Me.TecnologiaIDParaEliminarPorTecnologia.TabIndex = 9
        '
        'ProyectoIDParaEliminarPorTecnologia
        '
        Me.ProyectoIDParaEliminarPorTecnologia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "ProyectoID", True))
        Me.ProyectoIDParaEliminarPorTecnologia.Location = New System.Drawing.Point(8, 273)
        Me.ProyectoIDParaEliminarPorTecnologia.Name = "ProyectoIDParaEliminarPorTecnologia"
        Me.ProyectoIDParaEliminarPorTecnologia.Size = New System.Drawing.Size(43, 20)
        Me.ProyectoIDParaEliminarPorTecnologia.TabIndex = 7
        '
        'ControlNulos
        '
        Me.ControlNulos.Location = New System.Drawing.Point(492, 33)
        Me.ControlNulos.Name = "ControlNulos"
        Me.ControlNulos.Size = New System.Drawing.Size(41, 20)
        Me.ControlNulos.TabIndex = 94
        '
        'PlantillaIDTextBox
        '
        Me.PlantillaIDTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.PlantillaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, "PlantillaID", True))
        Me.PlantillaIDTextBox.Location = New System.Drawing.Point(8, 86)
        Me.PlantillaIDTextBox.Name = "PlantillaIDTextBox"
        Me.PlantillaIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.PlantillaIDTextBox.TabIndex = 3
        '
        'ProyectosYTecnologiasIDTextBox
        '
        Me.ProyectosYTecnologiasIDTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.ProyectosYTecnologiasIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, "ProyectosYTecnologiasID", True))
        Me.ProyectosYTecnologiasIDTextBox.Location = New System.Drawing.Point(8, 114)
        Me.ProyectosYTecnologiasIDTextBox.Name = "ProyectosYTecnologiasIDTextBox"
        Me.ProyectosYTecnologiasIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.ProyectosYTecnologiasIDTextBox.TabIndex = 5
        '
        'TecnologiaIDTextBox
        '
        Me.TecnologiaIDTextBox.BackColor = System.Drawing.Color.Turquoise
        Me.TecnologiaIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TecnologiasBindingSource, "TecnologiaID", True))
        Me.TecnologiaIDTextBox.Location = New System.Drawing.Point(8, 58)
        Me.TecnologiaIDTextBox.Name = "TecnologiaIDTextBox"
        Me.TecnologiaIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TecnologiaIDTextBox.TabIndex = 1
        '
        'SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource
        '
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource.DataSource = Me.DataSetTablasYCampos
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource.Position = 0
        '
        'SP_RequerimientosValorProvisional_TRUNCABindingSource
        '
        Me.SP_RequerimientosValorProvisional_TRUNCABindingSource.DataMember = "SP_RequerimientosValorProvisional_TRUNCA"
        Me.SP_RequerimientosValorProvisional_TRUNCABindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ChkValidacionRequerimientos)
        Me.Panel5.Controls.Add(Me.BtnCodigoRuta)
        Me.Panel5.Controls.Add(Me.BtnRequerimientos)
        Me.Panel5.Controls.Add(Me.BtnExplorar)
        Me.Panel5.Controls.Add(Me.BtnAmpliar)
        Me.Panel5.Controls.Add(Me.BtnCopiar)
        Me.Panel5.Controls.Add(Me.BtnLimpiar)
        Me.Panel5.Controls.Add(Me.BtnInicioGenerar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 63)
        Me.Panel5.TabIndex = 191
        '
        'ChkValidacionRequerimientos
        '
        Me.ChkValidacionRequerimientos.AutoSize = True
        Me.ChkValidacionRequerimientos.Location = New System.Drawing.Point(292, 17)
        Me.ChkValidacionRequerimientos.Name = "ChkValidacionRequerimientos"
        Me.ChkValidacionRequerimientos.Size = New System.Drawing.Size(15, 14)
        Me.ChkValidacionRequerimientos.TabIndex = 190
        Me.ChkValidacionRequerimientos.UseVisualStyleBackColor = True
        '
        'BtnCodigoRuta
        '
        Me.BtnCodigoRuta.BackColor = System.Drawing.Color.White
        Me.BtnCodigoRuta.Location = New System.Drawing.Point(201, 8)
        Me.BtnCodigoRuta.Name = "BtnCodigoRuta"
        Me.BtnCodigoRuta.Size = New System.Drawing.Size(34, 43)
        Me.BtnCodigoRuta.TabIndex = 193
        Me.BtnCodigoRuta.Text = "C"
        Me.BtnCodigoRuta.UseVisualStyleBackColor = False
        '
        'BtnRequerimientos
        '
        Me.BtnRequerimientos.BackColor = System.Drawing.Color.White
        Me.BtnRequerimientos.Location = New System.Drawing.Point(122, 9)
        Me.BtnRequerimientos.Name = "BtnRequerimientos"
        Me.BtnRequerimientos.Size = New System.Drawing.Size(34, 43)
        Me.BtnRequerimientos.TabIndex = 191
        Me.BtnRequerimientos.Text = "R"
        Me.BtnRequerimientos.UseVisualStyleBackColor = False
        '
        'BtnExplorar
        '
        Me.BtnExplorar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnExplorar.Location = New System.Drawing.Point(246, 12)
        Me.BtnExplorar.Name = "BtnExplorar"
        Me.BtnExplorar.Size = New System.Drawing.Size(29, 23)
        Me.BtnExplorar.TabIndex = 190
        Me.BtnExplorar.UseVisualStyleBackColor = False
        '
        'BtnAmpliar
        '
        Me.BtnAmpliar.BackColor = System.Drawing.Color.White
        Me.BtnAmpliar.Location = New System.Drawing.Point(162, 8)
        Me.BtnAmpliar.Name = "BtnAmpliar"
        Me.BtnAmpliar.Size = New System.Drawing.Size(33, 44)
        Me.BtnAmpliar.TabIndex = 132
        Me.BtnAmpliar.Text = "<>"
        Me.BtnAmpliar.UseVisualStyleBackColor = False
        '
        'BtnCopiar
        '
        Me.BtnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCopiar.Image = CType(resources.GetObject("BtnCopiar.Image"), System.Drawing.Image)
        Me.BtnCopiar.Location = New System.Drawing.Point(82, 9)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(34, 43)
        Me.BtnCopiar.TabIndex = 171
        Me.BtnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Image = CType(resources.GetObject("BtnLimpiar.Image"), System.Drawing.Image)
        Me.BtnLimpiar.Location = New System.Drawing.Point(43, 8)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(33, 43)
        Me.BtnLimpiar.TabIndex = 172
        Me.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnInicioGenerar
        '
        Me.BtnInicioGenerar.BackColor = System.Drawing.Color.White
        Me.BtnInicioGenerar.Image = CType(resources.GetObject("BtnInicioGenerar.Image"), System.Drawing.Image)
        Me.BtnInicioGenerar.Location = New System.Drawing.Point(3, 8)
        Me.BtnInicioGenerar.Name = "BtnInicioGenerar"
        Me.BtnInicioGenerar.Size = New System.Drawing.Size(34, 44)
        Me.BtnInicioGenerar.TabIndex = 173
        Me.BtnInicioGenerar.UseVisualStyleBackColor = False
        '
        'CodigoGeneradoTextBox
        '
        Me.CodigoGeneradoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProyectosBindingSource, "CodigoGenerado", True))
        Me.CodigoGeneradoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoGeneradoTextBox.Location = New System.Drawing.Point(0, 66)
        Me.CodigoGeneradoTextBox.Name = "CodigoGeneradoTextBox"
        Me.CodigoGeneradoTextBox.Size = New System.Drawing.Size(76, 243)
        Me.CodigoGeneradoTextBox.TabIndex = 186
        Me.CodigoGeneradoTextBox.Text = ""
        '
        'SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_ACTUALIZAR"
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'Timer_Acciones
        '
        '
        'ProyectosTableAdapter
        '
        Me.ProyectosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ELIMINA_SEGUN_PROYECTOTableAdapter = Nothing
        Me.TableAdapterManager.ProyectosTableAdapter = Me.ProyectosTableAdapter
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
        Me.TableAdapterManager.SP_Proyectos_EDICION_ACTUALIZARTableAdapter = Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter
        Me.TableAdapterManager.SP_Proyectos_EDICION_ELIMINARTableAdapter = Me.SP_Proyectos_EDICION_ELIMINARTableAdapter
        Me.TableAdapterManager.SP_Proyectos_EDICION_INSERTARTableAdapter = Me.SP_Proyectos_EDICION_INSERTARTableAdapter
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
        Me.TableAdapterManager.TiposTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = GeneradorCod.DataSetAdministracionTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SP_Proyectos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_Proyectos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_ELIMINARTableAdapter
        '
        Me.SP_Proyectos_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_INSERTARTableAdapter
        '
        Me.SP_Proyectos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_Proyectos_EDICION_INSERTARBindingSource
        '
        Me.SP_Proyectos_EDICION_INSERTARBindingSource.DataMember = "SP_Proyectos_EDICION_INSERTAR"
        Me.SP_Proyectos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Proyectos_EDICION_ELIMINARBindingSource
        '
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource.DataMember = "SP_Proyectos_EDICION_ELIMINAR"
        Me.SP_Proyectos_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_Proyectos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_Proyectos_EDICION_ACTUALIZAR"
        Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter.ClearBeforeFill = True
        '
        'TecnologiasTableAdapter
        '
        Me.TecnologiasTableAdapter.ClearBeforeFill = True
        '
        'SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
        '
        Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource
        '
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource.DataMember = "SP_ProyectosYTecnologias_EDICION_INSERTAR"
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter
        '
        Me.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource
        '
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource.DataMember = "SP_ProyectosYTecnologias_EDICION_ELIMINAR"
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter
        '
        Me.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'ELIMINA_SEGUN_PROYECTOBindingSource
        '
        Me.ELIMINA_SEGUN_PROYECTOBindingSource.DataMember = "ELIMINA_SEGUN_PROYECTO"
        Me.ELIMINA_SEGUN_PROYECTOBindingSource.DataSource = Me.DataSetAdministracion
        '
        'ELIMINA_SEGUN_PROYECTOTableAdapter
        '
        Me.ELIMINA_SEGUN_PROYECTOTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter.ClearBeforeFill = True
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
        'SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_EDICION_ELIMINARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_ELIMINAR"
        Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_EDICION_INSERTARBindingSource
        '
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource.DataMember = "SP_TablasDeProyecto_EDICION_INSERTAR"
        Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_TablasDeProyecto_EDICION_INSERTARTableAdapter
        '
        Me.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter.ClearBeforeFill = True
        '
        'TiposTableAdapter
        '
        Me.TiposTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_ACTUALIZAR"
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_ELIMINARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_ELIMINAR"
        Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_EDICION_INSERTARBindingSource
        '
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource.DataMember = "SP_CamposDeTablas_EDICION_INSERTAR"
        Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_CamposDeTablas_EDICION_INSERTARTableAdapter
        '
        Me.SP_CamposDeTablas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter
        '
        Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter.ClearBeforeFill = True
        '
        'SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter
        '
        Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource
        '
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource.DataMember = "SP_RegistroRelacionesTablas_EDICION_INSERTAR"
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource
        '
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource.DataMember = "SP_RegistroRelacionesTablas_EDICION_ELIMINAR"
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter
        '
        Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource.DataMember = "SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATE"
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource.DataMember = "SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTAR"
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter
        '
        Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter.ClearBeforeFill = True
        '
        'SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource
        '
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource.DataMember = "SP_ELIMINA_RegistroValorRequerimientos_SegunID"
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter
        '
        Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource
        '
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource.DataMember = "SP_RegistroValorRequerimientos_EDICION_INSERTAR"
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'TimerRequerimientos
        '
        '
        'SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource.DataMember = "SP_RegistroValorRequerimientos_EDICION_ACTUALIZAR"
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'PanelGeneracion
        '
        Me.PanelGeneracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGeneracion.Controls.Add(Me.Panel5)
        Me.PanelGeneracion.Controls.Add(Me.CodigoGeneradoTextBox)
        Me.PanelGeneracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.PanelGeneracion.Location = New System.Drawing.Point(1022, 107)
        Me.PanelGeneracion.Name = "PanelGeneracion"
        Me.PanelGeneracion.Size = New System.Drawing.Size(141, 133)
        Me.PanelGeneracion.TabIndex = 192
        '
        'SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
        '
        Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter
        '
        Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter.ClearBeforeFill = True
        '
        'Timer_Genera_Archivos
        '
        Me.Timer_Genera_Archivos.Interval = 1000
        '
        'SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter
        '
        Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource
        '
        Me.SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource.DataMember = "SP_RequerimientosValorProvisional_EDICION_INSERTAR"
        Me.SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter
        '
        Me.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter
        '
        Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValorProvisional_TRUNCATableAdapter
        '
        Me.SP_RequerimientosValorProvisional_TRUNCATableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource
        '
        Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource.DataMember = "SP_RequerimientosValorProvisional_EDICION_ACTUALIZAR"
        Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter
        '
        Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter
        '
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter.ClearBeforeFill = True
        '
        'SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter
        '
        Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter.ClearBeforeFill = True
        '
        'SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter
        '
        Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter.ClearBeforeFill = True
        '
        'SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource
        '
        Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource.DataMember = "SP_ComponentesContenidoProvisional_EDICION_INSERTAR"
        Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource.DataSource = Me.DataSetTablasYCampos
        '
        'SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter
        '
        Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
        '
        Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.ClearBeforeFill = True
        '
        'SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource
        '
        Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource.DataMember = "SP_ProyectoCarpetasArchivos_EDICION_INSERTAR"
        Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource.DataSource = Me.DataSetAdministracion
        '
        'SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter
        '
        Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
        '
        Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter.ClearBeforeFill = True
        '
        'SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter
        '
        Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter.ClearBeforeFill = True
        '
        'FrmGeneracionProyectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 621)
        Me.Controls.Add(Me.Panel_Tecnologias)
        Me.Controls.Add(Me.PanelGeneracion)
        Me.Controls.Add(Me.TabControl5)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(CodigoGeneradoLabel)
        Me.Name = "FrmGeneracionProyectos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Co"
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TP_TablasYCampos.ResumeLayout(False)
        Me.TP_TablasYCampos.PerformLayout()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTablasYCampos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.TiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetAdministracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage10.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_EliminacionPlantillas.ResumeLayout(False)
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_Tecnologias.ResumeLayout(False)
        CType(Me.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TecnologiasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CM_EnTecnologias.ResumeLayout(False)
        CType(Me.TecnologiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Requerimientos.ResumeLayout(False)
        Me.TabControl4.ResumeLayout(False)
        Me.TP_RequerimientosProyecto.ResumeLayout(False)
        Me.TP_RequerimientosProyecto.PerformLayout()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.TP_Generar.ResumeLayout(False)
        Me.TabControl6.ResumeLayout(False)
        Me.TP_CarpetasArchivos.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TP_Proyectos.ResumeLayout(False)
        Me.TP_Proyectos.PerformLayout()
        CType(Me.ProyectosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAdministracion_.ResumeLayout(False)
        Me.TP_Admin.ResumeLayout(False)
        Me.Panel_Tecnologias.ResumeLayout(False)
        Me.Panel_Tecnologias.PerformLayout()
        CType(Me.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_RequerimientosProyecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_ComponentesGeneracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_PlantillasAplicadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValorProvisional_TRUNCABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_Proyectos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ELIMINA_SEGUN_PROYECTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_TablasDeProyecto_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CamposDeTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGeneracion.ResumeLayout(False)
        CType(Me.SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TP_Proyectos As TabPage
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TP_TablasYCampos As TabPage
    Friend WithEvents TP_Admin As TabPage
    Friend WithEvents DataSetAdministracion As DataSetAdministracion
    Friend WithEvents ProyectosBindingSource As BindingSource
    Friend WithEvents ProyectosTableAdapter As DataSetAdministracionTableAdapters.ProyectosTableAdapter
    Friend WithEvents TableAdapterManager As DataSetAdministracionTableAdapters.TableAdapterManager
    Friend WithEvents ProyectosDataGridView As DataGridView
    Friend WithEvents PanelAdministracion_ As Panel
    Friend WithEvents Nuevo_Menu_Proyectos As Button
    Friend WithEvents Cancelar_Menu_Proyectos As Button
    Friend WithEvents Eliminar_Menu_Proyectos As Button
    Friend WithEvents Editar_Menu_Proyectos As Button
    Friend WithEvents Actualizar_Menu_Proyectos As Button
    Friend WithEvents Guardar_Menu_Proyectos As Button
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents NombreProyectoTextBox As TextBox
    Friend WithEvents ProyectoIDTextBox As TextBox
    Friend WithEvents SP_Proyectos_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_INSERTARTableAdapter
    Friend WithEvents SP_Proyectos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_Proyectos_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_Proyectos_EDICION_ACTUALIZARTableAdapter As DataSetAdministracionTableAdapters.SP_Proyectos_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_Proyectos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents ControlNulos As TextBox
    Friend WithEvents CodigoGeneradoTextBox As RichTextBox
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOBindingSource As BindingSource
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter As DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTOTableAdapter
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTODataGridView As DataGridView
    Friend WithEvents TecnologiasBindingSource As BindingSource
    Friend WithEvents TecnologiasTableAdapter As DataSetAdministracionTableAdapters.TecnologiasTableAdapter
    Friend WithEvents Panel_Tecnologias As Panel
    Friend WithEvents TecnologiaIDTextBox As TextBox
    Friend WithEvents TecnologiasDataGridView As DataGridView
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaBindingSource As BindingSource
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter As DataSetAdministracionTableAdapters.SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaTableAdapter
    Friend WithEvents SP_Plantillas_BUSQUEDA_SEGUN_PARAMETRO_TecnologiaDataGridView As DataGridView
    Friend WithEvents CM_Tecnologias As ContextMenuStrip
    Friend WithEvents AgregarPlantillaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarlasTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_INSERTARTableAdapter
    Friend WithEvents PlantillaIDTextBox As TextBox
    Friend WithEvents LblInforme As Label
    Friend WithEvents Timer_Acciones As Timer
    Friend WithEvents CM_EliminacionPlantillas As ContextMenuStrip
    Friend WithEvents EliminarPlantillaSeleccionadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarTodasLasRelacionadasAEstaTecnologiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectosYTecnologias_EDICION_ELIMINARTableAdapter
    Friend WithEvents ProyectosYTecnologiasIDTextBox As TextBox
    Friend WithEvents ELIMINA_SEGUN_PROYECTOBindingSource As BindingSource
    Friend WithEvents ELIMINA_SEGUN_PROYECTOTableAdapter As DataSetAdministracionTableAdapters.ELIMINA_SEGUN_PROYECTOTableAdapter
    Friend WithEvents TecnologiaIDParaEliminarPorTecnologia As TextBox
    Friend WithEvents ProyectoIDParaEliminarPorTecnologia As TextBox
    Friend WithEvents CM_EnTecnologias As ContextMenuStrip
    Friend WithEvents AgregarTodasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ChkValidacionRequerimientos As CheckBox
    Friend WithEvents BtnCodigoRuta As Button
    Friend WithEvents BtnRequerimientos As Button
    Friend WithEvents BtnExplorar As Button
    Friend WithEvents BtnAmpliar As Button
    Friend WithEvents BtnCopiar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnInicioGenerar As Button
    Friend WithEvents Nuevo_Menu_TablasDeProyecto As Button
    Friend WithEvents Cancelar_Menu_TablasDeProyecto As Button
    Friend WithEvents Eliminar_Menu_TablasDeProyecto As Button
    Friend WithEvents Editar_Menu_TablasDeProyecto As Button
    Friend WithEvents Actualizar_Menu_TablasDeProyecto As Button
    Friend WithEvents Guardar_Menu_TablasDeProyecto As Button
    Friend WithEvents DataSetTablasYCampos As DataSetTablasYCampos
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDTableAdapter
    Friend WithEvents TableAdapterManager1 As DataSetTablasYCamposTableAdapters.TableAdapterManager
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents TipoCheckBox As CheckBox
    Friend WithEvents NombreTablaTextBox As TextBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIDDataGridView As DataGridView
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_EDICION_INSERTARTableAdapter
    Friend WithEvents TablaIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDTableAdapter
    Friend WithEvents NombreCampoTextBox As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaIDDataGridView As DataGridView
    Friend WithEvents TiposBindingSource As BindingSource
    Friend WithEvents TiposTableAdapter As DataSetAdministracionTableAdapters.TiposTableAdapter
    Friend WithEvents TipoCampoDesdeCombo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboTiposDatos As ComboBox
    Friend WithEvents TipoCampoDesdeTabla As TextBox
    Friend WithEvents Nuevo_Menu_CamposDeTablas As Button
    Friend WithEvents Cancelar_Menu_CamposDeTablas As Button
    Friend WithEvents Eliminar_Menu_CamposDeTablas As Button
    Friend WithEvents Editar_Menu_CamposDeTablas As Button
    Friend WithEvents Actualizar_Menu_CamposDeTablas As Button
    Friend WithEvents Guardar_Menu_CamposDeTablas As Button
    Friend WithEvents CampoIDTextBox As TextBox
    Friend WithEvents SP_CamposDeTablas_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_CamposDeTablas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_ELIMINARTableAdapter
    Friend WithEvents SP_CamposDeTablas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_EDICION_INSERTARTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TablaIDRelacionados As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoTableAdapter
    Friend WithEvents SP_TablasDeProyecto_DEPEND_SEGUN_Tipo_ProyectoDataGridView As DataGridView
    Friend WithEvents SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoBindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoTableAdapter
    Friend WithEvents SP_TablasDeProyecto_INDEPENDIENTES_SEGUN_Tipo_ProyectoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents TablaID_Independiente As TextBox
    Friend WithEvents TablaID_Depend As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1BindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1TableAdapter
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID1DataGridView As DataGridView
    Friend WithEvents CampoID_Independiente As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2BindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2TableAdapter
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID2DataGridView As DataGridView
    Friend WithEvents CampoID_Depend As TextBox
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTIBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD_CTD_TI_CTITableAdapter
    Friend WithEvents RegistroRelacionesTablasIDTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents TipoCTD As TextBox
    Friend WithEvents TipoCTI As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_INSERTARTableAdapter
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDTableAdapter
    Friend WithEvents CampoIndependienteTextBox As TextBox
    Friend WithEvents TablaIndependienteTextBox As TextBox
    Friend WithEvents CampoDependienteTextBox As TextBox
    Friend WithEvents TablaDependienteTextBox As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TDDataGridView As DataGridView
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_ELIMINARBindingSource As BindingSource
    Friend WithEvents SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroRelacionesTablas_EDICION_ELIMINARTableAdapter
    Friend WithEvents TabControl5 As TabControl
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents TabPage10 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents RegistroRelacionesTablasIDEdicion As TextBox
    Friend WithEvents TP_Requerimientos As TabPage
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnIniciaCargaRequerimientos As Button
    Friend WithEvents Cancelar_Menu_RegistroValorRequerimientos As Button
    Friend WithEvents Editar_Menu_RegistroValorRequerimientos As Button
    Friend WithEvents Actualizar_Menu_RegistroValorRequerimientos As Button
    Friend WithEvents BtnLimpiarValoresRequerimientos As Button
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdTableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_BUSQUEDA_SEGUN_PARAMETRO_ProyectoIdDataGridView As DataGridView
    Friend WithEvents BtnListarRequerimientos As Button
    Friend WithEvents ToolTipGeneracion As ToolTip
    Friend WithEvents TabControl4 As TabControl
    Friend WithEvents TP_RequerimientosProyecto As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATEBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_TRUNCATETableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents SP_RequerimientosPlantillas_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_RequerimientosValidacionPorProyecto_Provisional_EDICION_INSERTARTableAdapter
    Friend WithEvents Label14 As Label
    Friend WithEvents IDRequerimiento As TextBox
    Friend WithEvents EnunciadoTextBox As TextBox
    Friend WithEvents RequerimientoTextBox As TextBox
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoIDTableAdapter
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoIDDataGridView As DataGridView
    Friend WithEvents SP_ELIMINA_RegistroValorRequerimientos_SegunIDBindingSource As BindingSource
    Friend WithEvents SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_ELIMINA_RegistroValorRequerimientos_SegunIDTableAdapter
    Friend WithEvents BtnCargarRequerimiento As Button
    Friend WithEvents ValorRequerimiento As TextBox
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents PlantillaIDRequerimientos As TextBox
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_INSERTARTableAdapter
    Friend WithEvents Label16 As Label
    Friend WithEvents TimerRequerimientos As Timer
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents RegistroValorRequerimientoIDTextBox As TextBox
    Friend WithEvents EnunciadoEnRich As RichTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelGeneracion As Panel
    Friend WithEvents TP_Generar As TabPage
    Friend WithEvents TabControl6 As TabControl
    Friend WithEvents TP_CarpetasArchivos As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents RBExistente As RadioButton
    Friend WithEvents RBNuevo As RadioButton
    Friend WithEvents ChkCreaCarpetasYArchivos As CheckBox
    Friend WithEvents AdmiteCreacionCheckBox As CheckBox
    Friend WithEvents ChkCreaDocumentoTecnico As CheckBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnCreacion As Button
    Friend WithEvents PlantillaID_Techanged_Generacion_CargaComponentes As TextBox
    Friend WithEvents DGV_PlantillasAplicadas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter As DataSetAdministracionTableAdapters.SP_Componentes_BUSQUEDA_SEGUN_PARAMETRO_PlantillaIDTableAdapter
    Friend WithEvents DGV_ComponentesGeneracion As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1BindingSource As BindingSource
    Friend WithEvents SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter As DataSetAdministracionTableAdapters.SP_CARGA_TECNOLOGIAS_APLICADAS_A_PROYECTO1TableAdapter
    Friend WithEvents Timer_Genera_Archivos As Timer
    Friend WithEvents CodigoDependienteTextBox As TextBox
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents XBaseCheckBox As CheckBox
    Friend WithEvents XTablaCheckBox As CheckBox
    Friend WithEvents NombreComponenteTextBox As TextBox
    Friend WithEvents CodigoAProcesar As TextBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1BindingSource As BindingSource
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter As DataSetTablasYCamposTableAdapters.SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1TableAdapter
    Friend WithEvents NombreTablaTextBox1 As TextBox
    Friend WithEvents TablaIDGeneracion As TextBox
    Friend WithEvents SP_TablasDeProyecto_BUSQUEDA_SEGUN_PARAMETRO_ProyectoID1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents SP_RequerimientosValorProvisional_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_EDICION_INSERTARTableAdapter
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoID1BindingSource As BindingSource
    Friend WithEvents SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter As DataSetTablasYCamposTableAdapters.SP_RegistroValorRequerimientos_SEGUN_ProyectoID1TableAdapter
    Friend WithEvents ValorRequerimientoGeneracion As TextBox
    Friend WithEvents RequerimientoGeneracion As TextBox
    Friend WithEvents DGV_RequerimientosProyecto As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents SP_RequerimientosValorProvisional_TRUNCABindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValorProvisional_TRUNCATableAdapter As DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_TRUNCATableAdapter
    Friend WithEvents SP_RequerimientosValorProvisional_EDICION_ACTUALIZARBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter As DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_EDICION_ACTUALIZARTableAdapter
    Friend WithEvents SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoBindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter As DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_ID_ProyectoTableAdapter
    Friend WithEvents SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_BindingSource As BindingSource
    Friend WithEvents SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter As DataSetTablasYCamposTableAdapters.SP_RequerimientosValorProvisional_BUSQUEDA_SEGUN_PARAMETRO_TableAdapter
    Friend WithEvents TextoTextBox As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3BindingSource As BindingSource
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter As DataSetTablasYCamposTableAdapters.SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3TableAdapter
    Friend WithEvents NombreCampoGeneracion As TextBox
    Friend WithEvents SP_CamposDeTablas_BUSQUEDA_SEGUN_PARAMETRO_TablaID3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents SP_ComponentesContenidoProvisional_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter As DataSetTablasYCamposTableAdapters.SP_ComponentesContenidoProvisional_EDICION_INSERTARTableAdapter
    Friend WithEvents Label17 As Label
    Friend WithEvents SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource As BindingSource
    Friend WithEvents SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter As DataSetAdministracionTableAdapters.SP_PlantillasCreacionDeArchivos_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
    Friend WithEvents RutaGeneracion As TextBox
    Friend WithEvents ExtensionArchivoGeneracion As TextBox
    Friend WithEvents NombreArchivoGeneracion As TextBox
    Friend WithEvents SP_ProyectoCarpetasArchivos_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter As DataSetAdministracionTableAdapters.SP_ProyectoCarpetasArchivos_EDICION_INSERTARTableAdapter
    Friend WithEvents Label18 As Label
    Friend WithEvents SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDBindingSource As BindingSource
    Friend WithEvents SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_ComponentesParaTablas_BUSQUEDA_SEGUN_PARAMETRO_ComponenteIDTableAdapter
    Friend WithEvents ContenidoXTablaTextBox As TextBox
    Friend WithEvents MultiReplaceTextBox As TextBox
    Friend WithEvents SeparadorCamposTextBox As TextBox
    Friend WithEvents InferiorTextBox As TextBox
    Friend WithEvents SufijoTextBox As TextBox
    Friend WithEvents SuperiorTextBox As TextBox
    Friend WithEvents PrefijoTextBox As TextBox
    Friend WithEvents TipoGeneracion As TextBox
    Friend WithEvents SP_RegistroRelacionesTablas_Vista_BUSQUEDA_SEGUN_PARAMETRO_TD1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDBindingSource As BindingSource
    Friend WithEvents SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter As DataSetTablasYCamposTableAdapters.SP_CARGA_TablasRelacionadas_SEGUN_PlantillaIDTableAdapter
    Friend WithEvents ContenidoRelacionTextBox As TextBox
End Class
