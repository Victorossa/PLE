<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim IdLabel As System.Windows.Forms.Label
        Me.BtnFuente = New System.Windows.Forms.Button()
        Me.BtnIzquierda = New System.Windows.Forms.Button()
        Me.BtnCentro = New System.Windows.Forms.Button()
        Me.BtnDerecha = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnColor = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TablaPruebaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New GuardandoRichtext.DataSet1()
        Me.TextoEnriquezidoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TablaPruebaTableAdapter = New GuardandoRichtext.DataSet1TableAdapters.tablaPruebaTableAdapter()
        Me.TableAdapterManager = New GuardandoRichtext.DataSet1TableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TablaPruebaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_tablaPrueba_EDICION_INSERTARBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_tablaPrueba_EDICION_INSERTARTableAdapter = New GuardandoRichtext.DataSet1TableAdapters.SP_tablaPrueba_EDICION_INSERTARTableAdapter()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnLeer = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.TablaPruebaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TablaPruebaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_tablaPrueba_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(35, 458)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 8
        IdLabel.Text = "id:"
        '
        'BtnFuente
        '
        Me.BtnFuente.Location = New System.Drawing.Point(12, 12)
        Me.BtnFuente.Name = "BtnFuente"
        Me.BtnFuente.Size = New System.Drawing.Size(163, 23)
        Me.BtnFuente.TabIndex = 0
        Me.BtnFuente.Text = "Fuente"
        Me.BtnFuente.UseVisualStyleBackColor = True
        '
        'BtnIzquierda
        '
        Me.BtnIzquierda.Location = New System.Drawing.Point(215, 444)
        Me.BtnIzquierda.Name = "BtnIzquierda"
        Me.BtnIzquierda.Size = New System.Drawing.Size(163, 23)
        Me.BtnIzquierda.TabIndex = 1
        Me.BtnIzquierda.Text = "Derecha"
        Me.BtnIzquierda.UseVisualStyleBackColor = True
        '
        'BtnCentro
        '
        Me.BtnCentro.Location = New System.Drawing.Point(384, 444)
        Me.BtnCentro.Name = "BtnCentro"
        Me.BtnCentro.Size = New System.Drawing.Size(163, 23)
        Me.BtnCentro.TabIndex = 3
        Me.BtnCentro.Text = "Centro"
        Me.BtnCentro.UseVisualStyleBackColor = True
        '
        'BtnDerecha
        '
        Me.BtnDerecha.Location = New System.Drawing.Point(553, 444)
        Me.BtnDerecha.Name = "BtnDerecha"
        Me.BtnDerecha.Size = New System.Drawing.Size(163, 23)
        Me.BtnDerecha.TabIndex = 2
        Me.BtnDerecha.Text = "Derecha"
        Me.BtnDerecha.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 315)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(163, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Datos que debo Guardar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 286)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 23)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Cargar String"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'BtnColor
        '
        Me.BtnColor.Location = New System.Drawing.Point(12, 41)
        Me.BtnColor.Name = "BtnColor"
        Me.BtnColor.Size = New System.Drawing.Size(163, 23)
        Me.BtnColor.TabIndex = 4
        Me.BtnColor.Text = "Color"
        Me.BtnColor.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaPruebaBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(59, 455)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(59, 20)
        Me.IdTextBox.TabIndex = 9
        '
        'TablaPruebaBindingSource
        '
        Me.TablaPruebaBindingSource.DataMember = "tablaPrueba"
        Me.TablaPruebaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextoEnriquezidoRichTextBox
        '
        Me.TextoEnriquezidoRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TablaPruebaBindingSource, "TextoEnriquezido", True))
        Me.TextoEnriquezidoRichTextBox.Location = New System.Drawing.Point(181, 12)
        Me.TextoEnriquezidoRichTextBox.Name = "TextoEnriquezidoRichTextBox"
        Me.TextoEnriquezidoRichTextBox.Size = New System.Drawing.Size(607, 271)
        Me.TextoEnriquezidoRichTextBox.TabIndex = 10
        Me.TextoEnriquezidoRichTextBox.Text = ""
        '
        'TablaPruebaTableAdapter
        '
        Me.TablaPruebaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SP_tablaPrueba_EDICION_ACTUALIZARTableAdapter = Nothing
        Me.TableAdapterManager.SP_tablaPrueba_EDICION_ELIMINARTableAdapter = Nothing
        Me.TableAdapterManager.SP_tablaPrueba_EDICION_INSERTARTableAdapter = Nothing
        Me.TableAdapterManager.tablaPruebaTableAdapter = Me.TablaPruebaTableAdapter
        Me.TableAdapterManager.UpdateOrder = GuardandoRichtext.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(43, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(43, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TablaPruebaDataGridView
        '
        Me.TablaPruebaDataGridView.AllowUserToAddRows = False
        Me.TablaPruebaDataGridView.AutoGenerateColumns = False
        Me.TablaPruebaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaPruebaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.TablaPruebaDataGridView.DataSource = Me.TablaPruebaBindingSource
        Me.TablaPruebaDataGridView.Location = New System.Drawing.Point(12, 70)
        Me.TablaPruebaDataGridView.Name = "TablaPruebaDataGridView"
        Me.TablaPruebaDataGridView.RowHeadersVisible = False
        Me.TablaPruebaDataGridView.Size = New System.Drawing.Size(163, 175)
        Me.TablaPruebaDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TextoEnriquezido"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TextoEnriquezido"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SP_tablaPrueba_EDICION_INSERTARBindingSource
        '
        Me.SP_tablaPrueba_EDICION_INSERTARBindingSource.DataMember = "SP_tablaPrueba_EDICION_INSERTAR"
        Me.SP_tablaPrueba_EDICION_INSERTARBindingSource.DataSource = Me.DataSet1
        '
        'SP_tablaPrueba_EDICION_INSERTARTableAdapter
        '
        Me.SP_tablaPrueba_EDICION_INSERTARTableAdapter.ClearBeforeFill = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(181, 289)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(163, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'BtnLeer
        '
        Me.BtnLeer.Location = New System.Drawing.Point(350, 289)
        Me.BtnLeer.Name = "BtnLeer"
        Me.BtnLeer.Size = New System.Drawing.Size(163, 23)
        Me.BtnLeer.TabIndex = 16
        Me.BtnLeer.Text = "Leer"
        Me.BtnLeer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 495)
        Me.Controls.Add(Me.BtnLeer)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TablaPruebaDataGridView)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextoEnriquezidoRichTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.BtnColor)
        Me.Controls.Add(Me.BtnCentro)
        Me.Controls.Add(Me.BtnDerecha)
        Me.Controls.Add(Me.BtnIzquierda)
        Me.Controls.Add(Me.BtnFuente)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.TablaPruebaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TablaPruebaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_tablaPrueba_EDICION_INSERTARBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFuente As Button
    Friend WithEvents BtnIzquierda As Button
    Friend WithEvents BtnCentro As Button
    Friend WithEvents BtnDerecha As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents BtnColor As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TablaPruebaBindingSource As BindingSource
    Friend WithEvents TablaPruebaTableAdapter As DataSet1TableAdapters.tablaPruebaTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TextoEnriquezidoRichTextBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TablaPruebaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents SP_tablaPrueba_EDICION_INSERTARBindingSource As BindingSource
    Friend WithEvents SP_tablaPrueba_EDICION_INSERTARTableAdapter As DataSet1TableAdapters.SP_tablaPrueba_EDICION_INSERTARTableAdapter
    Friend WithEvents btnSave As Button
    Friend WithEvents BtnLeer As Button
End Class
