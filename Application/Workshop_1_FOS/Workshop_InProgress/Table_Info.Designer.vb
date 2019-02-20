<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table_Info
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
        Me.TableAvailable_DGV = New System.Windows.Forms.DataGridView()
        Me.TableIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FosdatabaseDataSet = New Workshop_InProgress.fosdatabaseDataSet()
        Me.OK_btn = New System.Windows.Forms.Button()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.TableTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.tableTableAdapter()
        Me.TableUnavailable_DGV = New System.Windows.Forms.DataGridView()
        Me.TableIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapacityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TableAvailable_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableUnavailable_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableAvailable_DGV
        '
        Me.TableAvailable_DGV.AllowUserToAddRows = False
        Me.TableAvailable_DGV.AllowUserToDeleteRows = False
        Me.TableAvailable_DGV.AutoGenerateColumns = False
        Me.TableAvailable_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableAvailable_DGV.BackgroundColor = System.Drawing.Color.Honeydew
        Me.TableAvailable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableAvailable_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableIDDataGridViewTextBoxColumn, Me.CapacityDataGridViewTextBoxColumn, Me.TableStatusDataGridViewTextBoxColumn})
        Me.TableAvailable_DGV.DataSource = Me.TableBindingSource
        Me.TableAvailable_DGV.Location = New System.Drawing.Point(11, 11)
        Me.TableAvailable_DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.TableAvailable_DGV.MultiSelect = False
        Me.TableAvailable_DGV.Name = "TableAvailable_DGV"
        Me.TableAvailable_DGV.ReadOnly = True
        Me.TableAvailable_DGV.RowHeadersVisible = False
        Me.TableAvailable_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableAvailable_DGV.Size = New System.Drawing.Size(383, 279)
        Me.TableAvailable_DGV.TabIndex = 0
        '
        'TableIDDataGridViewTextBoxColumn
        '
        Me.TableIDDataGridViewTextBoxColumn.DataPropertyName = "Table_ID"
        Me.TableIDDataGridViewTextBoxColumn.HeaderText = "Table ID"
        Me.TableIDDataGridViewTextBoxColumn.Name = "TableIDDataGridViewTextBoxColumn"
        Me.TableIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CapacityDataGridViewTextBoxColumn
        '
        Me.CapacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.HeaderText = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn.Name = "CapacityDataGridViewTextBoxColumn"
        Me.CapacityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableStatusDataGridViewTextBoxColumn
        '
        Me.TableStatusDataGridViewTextBoxColumn.DataPropertyName = "Table_Status"
        Me.TableStatusDataGridViewTextBoxColumn.HeaderText = "Table Status"
        Me.TableStatusDataGridViewTextBoxColumn.Name = "TableStatusDataGridViewTextBoxColumn"
        Me.TableStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "table"
        Me.TableBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'FosdatabaseDataSet
        '
        Me.FosdatabaseDataSet.DataSetName = "fosdatabaseDataSet"
        Me.FosdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OK_btn
        '
        Me.OK_btn.Location = New System.Drawing.Point(317, 297)
        Me.OK_btn.Name = "OK_btn"
        Me.OK_btn.Size = New System.Drawing.Size(75, 29)
        Me.OK_btn.TabIndex = 1
        Me.OK_btn.Text = "OK"
        Me.OK_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Location = New System.Drawing.Point(317, 490)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(75, 29)
        Me.Cancel_btn.TabIndex = 2
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'TableUnavailable_DGV
        '
        Me.TableUnavailable_DGV.AllowUserToAddRows = False
        Me.TableUnavailable_DGV.AllowUserToDeleteRows = False
        Me.TableUnavailable_DGV.AutoGenerateColumns = False
        Me.TableUnavailable_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableUnavailable_DGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableUnavailable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableUnavailable_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableIDDataGridViewTextBoxColumn1, Me.CapacityDataGridViewTextBoxColumn1, Me.TableStatusDataGridViewTextBoxColumn1})
        Me.TableUnavailable_DGV.DataSource = Me.TableBindingSource
        Me.TableUnavailable_DGV.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableUnavailable_DGV.Location = New System.Drawing.Point(13, 334)
        Me.TableUnavailable_DGV.Name = "TableUnavailable_DGV"
        Me.TableUnavailable_DGV.ReadOnly = True
        Me.TableUnavailable_DGV.RowHeadersVisible = False
        Me.TableUnavailable_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableUnavailable_DGV.Size = New System.Drawing.Size(379, 150)
        Me.TableUnavailable_DGV.TabIndex = 3
        '
        'TableIDDataGridViewTextBoxColumn1
        '
        Me.TableIDDataGridViewTextBoxColumn1.DataPropertyName = "Table_ID"
        Me.TableIDDataGridViewTextBoxColumn1.HeaderText = "Table ID"
        Me.TableIDDataGridViewTextBoxColumn1.Name = "TableIDDataGridViewTextBoxColumn1"
        Me.TableIDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CapacityDataGridViewTextBoxColumn1
        '
        Me.CapacityDataGridViewTextBoxColumn1.DataPropertyName = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn1.HeaderText = "Capacity"
        Me.CapacityDataGridViewTextBoxColumn1.Name = "CapacityDataGridViewTextBoxColumn1"
        Me.CapacityDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TableStatusDataGridViewTextBoxColumn1
        '
        Me.TableStatusDataGridViewTextBoxColumn1.DataPropertyName = "Table_Status"
        Me.TableStatusDataGridViewTextBoxColumn1.HeaderText = "Table Status"
        Me.TableStatusDataGridViewTextBoxColumn1.Name = "TableStatusDataGridViewTextBoxColumn1"
        Me.TableStatusDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Table_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ClientSize = New System.Drawing.Size(404, 525)
        Me.Controls.Add(Me.TableUnavailable_DGV)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.OK_btn)
        Me.Controls.Add(Me.TableAvailable_DGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Table_Info"
        Me.Text = "Table_Info"
        CType(Me.TableAvailable_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableUnavailable_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAvailable_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents OK_btn As System.Windows.Forms.Button
    Friend WithEvents Cancel_btn As System.Windows.Forms.Button
    Friend WithEvents FosdatabaseDataSet As Workshop_InProgress.fosdatabaseDataSet
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.tableTableAdapter
    Friend WithEvents TableIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableUnavailable_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TableIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
