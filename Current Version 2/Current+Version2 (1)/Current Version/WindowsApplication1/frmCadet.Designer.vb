<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbID = New System.Windows.Forms.ComboBox()
        Me.CadetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjectData1DataSet = New UniformInventory.ProjectData1DataSet()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.btnCadet = New System.Windows.Forms.Button()
        Me.CadetTableAdapter = New UniformInventory.ProjectData1DataSetTableAdapters.CadetTableAdapter()
        Me.TableAdapterManager = New UniformInventory.ProjectData1DataSetTableAdapters.TableAdapterManager()
        Me.Clothing_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Clothing_TypeTableAdapter = New UniformInventory.ProjectData1DataSetTableAdapters.Clothing_TypeTableAdapter()
        Me.Clothing_TypeDataGridView = New System.Windows.Forms.DataGridView()
        Me.backPicture = New System.Windows.Forms.PictureBox()
        Me.editOrSaveButton = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CadetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectData1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clothing_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Clothing_TypeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(448, 302)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(445, 54)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New Cadet"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(276, 302)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 54)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(276, 261)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(121, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(276, 235)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(121, 20)
        Me.txtPhone.TabIndex = 5
        '
        'txtLName
        '
        Me.txtLName.Location = New System.Drawing.Point(276, 178)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(121, 20)
        Me.txtLName.TabIndex = 6
        '
        'txtFName
        '
        Me.txtFName.Location = New System.Drawing.Point(276, 150)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.ReadOnly = True
        Me.txtFName.Size = New System.Drawing.Size(121, 20)
        Me.txtFName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "School ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Phone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(133, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Texas State Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Rank"
        '
        'cmbID
        '
        Me.cmbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CadetBindingSource, "CadetID", True))
        Me.cmbID.DataSource = Me.ProjectData1DataSet
        Me.cmbID.DisplayMember = "Cadet.CadetID"
        Me.cmbID.FormattingEnabled = True
        Me.cmbID.Location = New System.Drawing.Point(276, 56)
        Me.cmbID.Name = "cmbID"
        Me.cmbID.Size = New System.Drawing.Size(121, 21)
        Me.cmbID.TabIndex = 0
        Me.cmbID.ValueMember = "Cadet.CadetID"
        '
        'CadetBindingSource
        '
        Me.CadetBindingSource.DataMember = "Cadet"
        Me.CadetBindingSource.DataSource = Me.ProjectData1DataSet
        '
        'ProjectData1DataSet
        '
        Me.ProjectData1DataSet.DataSetName = "ProjectData1DataSet"
        Me.ProjectData1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(276, 209)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.ReadOnly = True
        Me.txtRank.Size = New System.Drawing.Size(121, 20)
        Me.txtRank.TabIndex = 8
        '
        'btnCadet
        '
        Me.btnCadet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadet.Location = New System.Drawing.Point(276, 83)
        Me.btnCadet.Name = "btnCadet"
        Me.btnCadet.Size = New System.Drawing.Size(121, 37)
        Me.btnCadet.TabIndex = 21
        Me.btnCadet.Text = "Get Info"
        Me.btnCadet.UseVisualStyleBackColor = True
        '
        'CadetTableAdapter
        '
        Me.CadetTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadetTableAdapter = Me.CadetTableAdapter
        Me.TableAdapterManager.Clothing_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Clothing_StyleTableAdapter = Nothing
        Me.TableAdapterManager.Clothing_TypeTableAdapter = Nothing
        Me.TableAdapterManager.Inventory_ModificationsTableAdapter = Nothing
        Me.TableAdapterManager.Rental_ItemTableAdapter = Nothing
        Me.TableAdapterManager.Rental_StatusTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = UniformInventory.ProjectData1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Clothing_TypeBindingSource
        '
        Me.Clothing_TypeBindingSource.DataMember = "Clothing Type"
        Me.Clothing_TypeBindingSource.DataSource = Me.ProjectData1DataSet
        '
        'Clothing_TypeTableAdapter
        '
        Me.Clothing_TypeTableAdapter.ClearBeforeFill = True
        '
        'Clothing_TypeDataGridView
        '
        Me.Clothing_TypeDataGridView.AutoGenerateColumns = False
        Me.Clothing_TypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Clothing_TypeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Quantity})
        Me.Clothing_TypeDataGridView.DataSource = Me.Clothing_TypeBindingSource
        Me.Clothing_TypeDataGridView.Location = New System.Drawing.Point(448, 83)
        Me.Clothing_TypeDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.Clothing_TypeDataGridView.Name = "Clothing_TypeDataGridView"
        Me.Clothing_TypeDataGridView.RowTemplate.Height = 24
        Me.Clothing_TypeDataGridView.Size = New System.Drawing.Size(445, 198)
        Me.Clothing_TypeDataGridView.TabIndex = 21
        '
        'backPicture
        '
        Me.backPicture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backPicture.Image = Global.UniformInventory.My.Resources.Resources.back_button2
        Me.backPicture.Location = New System.Drawing.Point(12, 12)
        Me.backPicture.Name = "backPicture"
        Me.backPicture.Size = New System.Drawing.Size(51, 51)
        Me.backPicture.TabIndex = 22
        Me.backPicture.TabStop = False
        '
        'editOrSaveButton
        '
        Me.editOrSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editOrSaveButton.Location = New System.Drawing.Point(137, 302)
        Me.editOrSaveButton.Name = "editOrSaveButton"
        Me.editOrSaveButton.Size = New System.Drawing.Size(121, 54)
        Me.editOrSaveButton.TabIndex = 23
        Me.editOrSaveButton.Text = "Edit"
        Me.editOrSaveButton.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UniformType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Uniform Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Size"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "TypeID"
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        '
        'frmCadet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 462)
        Me.Controls.Add(Me.editOrSaveButton)
        Me.Controls.Add(Me.backPicture)
        Me.Controls.Add(Me.Clothing_TypeDataGridView)
        Me.Controls.Add(Me.btnCadet)
        Me.Controls.Add(Me.cmbID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRank)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmCadet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadet"
        CType(Me.CadetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectData1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clothing_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Clothing_TypeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbID As System.Windows.Forms.ComboBox
    Friend WithEvents txtRank As System.Windows.Forms.TextBox
    Friend WithEvents btnCadet As System.Windows.Forms.Button
    Friend WithEvents ProjectData1DataSet As UniformInventory.ProjectData1DataSet
    Friend WithEvents CadetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CadetTableAdapter As UniformInventory.ProjectData1DataSetTableAdapters.CadetTableAdapter
    Friend WithEvents TableAdapterManager As UniformInventory.ProjectData1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Clothing_TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Clothing_TypeTableAdapter As UniformInventory.ProjectData1DataSetTableAdapters.Clothing_TypeTableAdapter
    Friend WithEvents Clothing_TypeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents backPicture As System.Windows.Forms.PictureBox
    Friend WithEvents editOrSaveButton As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
