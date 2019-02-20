<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WaiterCashier_Use
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
        Me.Welcome_lbl = New System.Windows.Forms.Label()
        Me.DateTime_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.DateTime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableID_txtbox = New System.Windows.Forms.TextBox()
        Me.View_btn = New System.Windows.Forms.Button()
        Me.DineInTable_DGV = New System.Windows.Forms.DataGridView()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FosdatabaseDataSet = New Workshop_InProgress.fosdatabaseDataSet()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.NoOrder_lbl = New System.Windows.Forms.Label()
        Me.TotalOrder_lbl = New System.Windows.Forms.Label()
        Me.DineIn_lbl = New System.Windows.Forms.Label()
        Me.Confirm_btn = New System.Windows.Forms.Button()
        Me.NewOrder_btn = New System.Windows.Forms.Button()
        Me.AddMeal_btn = New System.Windows.Forms.Button()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.SendUpdateOrder_btn = New System.Windows.Forms.Button()
        Me.Minus_btn = New System.Windows.Forms.Button()
        Me.CancelPurchase_btn = New System.Windows.Forms.Button()
        Me.TimeOut_timer = New System.Windows.Forms.Timer(Me.components)
        Me.OrderTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.orderTableAdapter()
        Me.Load_btn = New System.Windows.Forms.Button()
        Me.Edit_btn = New System.Windows.Forms.Button()
        Me.Info_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.UpdateOrdered_Product_LV = New System.Windows.Forms.ListView()
        Me.InfoDGV_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.OrderDetail_DGV = New System.Windows.Forms.DataGridView()
        Me.DeleteMeal_btn = New System.Windows.Forms.Button()
        Me.CancelOrder_btn = New System.Windows.Forms.Button()
        Me.Total_txtbox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cash_txtbox = New System.Windows.Forms.TextBox()
        Me.Change_txtbox = New System.Windows.Forms.TextBox()
        Me.TimeOut_lbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Server_lbl = New System.Windows.Forms.Label()
        Me.Order_ID_lbl = New System.Windows.Forms.Label()
        Me.Table_ID_lbl = New System.Windows.Forms.Label()
        Me.TodayDate_lbl = New System.Windows.Forms.Label()
        Me.TimeIn_lbl = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CID_lbl = New System.Windows.Forms.Label()
        Me.CashierID_lbl = New System.Windows.Forms.Label()
        Me.Receipt_GB = New System.Windows.Forms.GroupBox()
        CType(Me.DineInTable_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetail_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Receipt_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Welcome_lbl
        '
        Me.Welcome_lbl.AutoSize = True
        Me.Welcome_lbl.BackColor = System.Drawing.Color.Aquamarine
        Me.Welcome_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_lbl.ForeColor = System.Drawing.Color.Purple
        Me.Welcome_lbl.Location = New System.Drawing.Point(3, 3)
        Me.Welcome_lbl.Name = "Welcome_lbl"
        Me.Welcome_lbl.Size = New System.Drawing.Size(165, 18)
        Me.Welcome_lbl.TabIndex = 0
        Me.Welcome_lbl.Text = "Welcome & Full Name"
        '
        'DateTime_lbl
        '
        Me.DateTime_lbl.AutoSize = True
        Me.DateTime_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_lbl.ForeColor = System.Drawing.Color.Lime
        Me.DateTime_lbl.Location = New System.Drawing.Point(1210, 716)
        Me.DateTime_lbl.Name = "DateTime_lbl"
        Me.DateTime_lbl.Size = New System.Drawing.Size(97, 16)
        Me.DateTime_lbl.TabIndex = 1
        Me.DateTime_lbl.Text = "DATE , TIME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Aquamarine
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(3, 715)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FOS version 10.1.4"
        '
        'LogOut_btn
        '
        Me.LogOut_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_btn.Location = New System.Drawing.Point(1228, 666)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Size = New System.Drawing.Size(99, 31)
        Me.LogOut_btn.TabIndex = 3
        Me.LogOut_btn.Text = "Log Out"
        Me.LogOut_btn.UseVisualStyleBackColor = False
        '
        'DateTime_timer
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightPink
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(461, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Table ID :"
        '
        'TableID_txtbox
        '
        Me.TableID_txtbox.BackColor = System.Drawing.Color.LightPink
        Me.TableID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableID_txtbox.Location = New System.Drawing.Point(544, 16)
        Me.TableID_txtbox.Name = "TableID_txtbox"
        Me.TableID_txtbox.Size = New System.Drawing.Size(183, 26)
        Me.TableID_txtbox.TabIndex = 5
        '
        'View_btn
        '
        Me.View_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.View_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.View_btn.Location = New System.Drawing.Point(128, 667)
        Me.View_btn.Name = "View_btn"
        Me.View_btn.Size = New System.Drawing.Size(110, 30)
        Me.View_btn.TabIndex = 7
        Me.View_btn.Text = "View Order"
        Me.View_btn.UseVisualStyleBackColor = False
        '
        'DineInTable_DGV
        '
        Me.DineInTable_DGV.AllowUserToAddRows = False
        Me.DineInTable_DGV.AllowUserToDeleteRows = False
        Me.DineInTable_DGV.AutoGenerateColumns = False
        Me.DineInTable_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DineInTable_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.DineInTable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DineInTable_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderIDDataGridViewTextBoxColumn, Me.TableIDDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.OrderStatusDataGridViewTextBoxColumn})
        Me.DineInTable_DGV.DataSource = Me.OrderBindingSource
        Me.DineInTable_DGV.Location = New System.Drawing.Point(12, 99)
        Me.DineInTable_DGV.MultiSelect = False
        Me.DineInTable_DGV.Name = "DineInTable_DGV"
        Me.DineInTable_DGV.ReadOnly = True
        Me.DineInTable_DGV.RowHeadersVisible = False
        Me.DineInTable_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DineInTable_DGV.Size = New System.Drawing.Size(416, 544)
        Me.DineInTable_DGV.TabIndex = 16
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableIDDataGridViewTextBoxColumn
        '
        Me.TableIDDataGridViewTextBoxColumn.DataPropertyName = "Table_ID"
        Me.TableIDDataGridViewTextBoxColumn.HeaderText = "Table ID"
        Me.TableIDDataGridViewTextBoxColumn.Name = "TableIDDataGridViewTextBoxColumn"
        Me.TableIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeInDataGridViewTextBoxColumn
        '
        Me.TimeInDataGridViewTextBoxColumn.DataPropertyName = "Time_In"
        Me.TimeInDataGridViewTextBoxColumn.HeaderText = "Time In"
        Me.TimeInDataGridViewTextBoxColumn.Name = "TimeInDataGridViewTextBoxColumn"
        Me.TimeInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderStatusDataGridViewTextBoxColumn
        '
        Me.OrderStatusDataGridViewTextBoxColumn.DataPropertyName = "Order_Status"
        Me.OrderStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.OrderStatusDataGridViewTextBoxColumn.Name = "OrderStatusDataGridViewTextBoxColumn"
        Me.OrderStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "order"
        Me.OrderBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'FosdatabaseDataSet
        '
        Me.FosdatabaseDataSet.DataSetName = "fosdatabaseDataSet"
        Me.FosdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.Aquamarine
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(443, 734)
        Me.Splitter1.TabIndex = 17
        Me.Splitter1.TabStop = False
        '
        'NoOrder_lbl
        '
        Me.NoOrder_lbl.AutoSize = True
        Me.NoOrder_lbl.BackColor = System.Drawing.Color.Aquamarine
        Me.NoOrder_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOrder_lbl.ForeColor = System.Drawing.Color.Black
        Me.NoOrder_lbl.Location = New System.Drawing.Point(114, 73)
        Me.NoOrder_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoOrder_lbl.Name = "NoOrder_lbl"
        Me.NoOrder_lbl.Size = New System.Drawing.Size(18, 20)
        Me.NoOrder_lbl.TabIndex = 20
        Me.NoOrder_lbl.Text = "0"
        '
        'TotalOrder_lbl
        '
        Me.TotalOrder_lbl.AutoSize = True
        Me.TotalOrder_lbl.BackColor = System.Drawing.Color.Aquamarine
        Me.TotalOrder_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalOrder_lbl.ForeColor = System.Drawing.Color.Black
        Me.TotalOrder_lbl.Location = New System.Drawing.Point(13, 73)
        Me.TotalOrder_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalOrder_lbl.Name = "TotalOrder_lbl"
        Me.TotalOrder_lbl.Size = New System.Drawing.Size(93, 20)
        Me.TotalOrder_lbl.TabIndex = 19
        Me.TotalOrder_lbl.Text = "Total order :"
        '
        'DineIn_lbl
        '
        Me.DineIn_lbl.AutoSize = True
        Me.DineIn_lbl.BackColor = System.Drawing.Color.Aquamarine
        Me.DineIn_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DineIn_lbl.ForeColor = System.Drawing.Color.Black
        Me.DineIn_lbl.Location = New System.Drawing.Point(13, 44)
        Me.DineIn_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DineIn_lbl.Name = "DineIn_lbl"
        Me.DineIn_lbl.Size = New System.Drawing.Size(59, 20)
        Me.DineIn_lbl.TabIndex = 18
        Me.DineIn_lbl.Text = "Dine-in"
        '
        'Confirm_btn
        '
        Me.Confirm_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Confirm_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confirm_btn.Location = New System.Drawing.Point(1228, 552)
        Me.Confirm_btn.Name = "Confirm_btn"
        Me.Confirm_btn.Size = New System.Drawing.Size(68, 31)
        Me.Confirm_btn.TabIndex = 21
        Me.Confirm_btn.Text = "Enter"
        Me.Confirm_btn.UseVisualStyleBackColor = False
        '
        'NewOrder_btn
        '
        Me.NewOrder_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NewOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewOrder_btn.Location = New System.Drawing.Point(12, 667)
        Me.NewOrder_btn.Name = "NewOrder_btn"
        Me.NewOrder_btn.Size = New System.Drawing.Size(110, 30)
        Me.NewOrder_btn.TabIndex = 22
        Me.NewOrder_btn.Text = "New Order"
        Me.NewOrder_btn.UseVisualStyleBackColor = False
        '
        'AddMeal_btn
        '
        Me.AddMeal_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddMeal_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMeal_btn.Location = New System.Drawing.Point(1228, 56)
        Me.AddMeal_btn.Name = "AddMeal_btn"
        Me.AddMeal_btn.Size = New System.Drawing.Size(110, 31)
        Me.AddMeal_btn.TabIndex = 24
        Me.AddMeal_btn.Text = "Add Order"
        Me.AddMeal_btn.UseVisualStyleBackColor = False
        '
        'Add_btn
        '
        Me.Add_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.Location = New System.Drawing.Point(1228, 91)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(43, 31)
        Me.Add_btn.TabIndex = 25
        Me.Add_btn.Text = "+"
        Me.Add_btn.UseVisualStyleBackColor = False
        '
        'SendUpdateOrder_btn
        '
        Me.SendUpdateOrder_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SendUpdateOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendUpdateOrder_btn.Location = New System.Drawing.Point(1228, 202)
        Me.SendUpdateOrder_btn.Name = "SendUpdateOrder_btn"
        Me.SendUpdateOrder_btn.Size = New System.Drawing.Size(110, 31)
        Me.SendUpdateOrder_btn.TabIndex = 26
        Me.SendUpdateOrder_btn.Text = "Save Order"
        Me.SendUpdateOrder_btn.UseVisualStyleBackColor = False
        '
        'Minus_btn
        '
        Me.Minus_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Minus_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus_btn.Location = New System.Drawing.Point(1228, 128)
        Me.Minus_btn.Name = "Minus_btn"
        Me.Minus_btn.Size = New System.Drawing.Size(43, 31)
        Me.Minus_btn.TabIndex = 27
        Me.Minus_btn.Text = "-"
        Me.Minus_btn.UseVisualStyleBackColor = False
        '
        'CancelPurchase_btn
        '
        Me.CancelPurchase_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelPurchase_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelPurchase_btn.Location = New System.Drawing.Point(1302, 552)
        Me.CancelPurchase_btn.Name = "CancelPurchase_btn"
        Me.CancelPurchase_btn.Size = New System.Drawing.Size(44, 31)
        Me.CancelPurchase_btn.TabIndex = 28
        Me.CancelPurchase_btn.Text = "AC"
        Me.CancelPurchase_btn.UseVisualStyleBackColor = False
        '
        'TimeOut_timer
        '
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        'Load_btn
        '
        Me.Load_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_btn.Location = New System.Drawing.Point(733, 19)
        Me.Load_btn.Name = "Load_btn"
        Me.Load_btn.Size = New System.Drawing.Size(75, 23)
        Me.Load_btn.TabIndex = 30
        Me.Load_btn.Text = "Load"
        Me.Load_btn.UseVisualStyleBackColor = True
        '
        'Edit_btn
        '
        Me.Edit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edit_btn.Location = New System.Drawing.Point(814, 19)
        Me.Edit_btn.Name = "Edit_btn"
        Me.Edit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Edit_btn.TabIndex = 31
        Me.Edit_btn.Text = "Edit"
        Me.Edit_btn.UseVisualStyleBackColor = True
        Me.Edit_btn.Visible = False
        '
        'Info_TT
        '
        Me.Info_TT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Info_TT.ToolTipTitle = "New Added Order"
        '
        'UpdateOrdered_Product_LV
        '
        Me.UpdateOrdered_Product_LV.FullRowSelect = True
        Me.UpdateOrdered_Product_LV.GridLines = True
        Me.UpdateOrdered_Product_LV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.UpdateOrdered_Product_LV.HideSelection = False
        Me.UpdateOrdered_Product_LV.Location = New System.Drawing.Point(16, 320)
        Me.UpdateOrdered_Product_LV.MultiSelect = False
        Me.UpdateOrdered_Product_LV.Name = "UpdateOrdered_Product_LV"
        Me.UpdateOrdered_Product_LV.Size = New System.Drawing.Size(713, 167)
        Me.UpdateOrdered_Product_LV.TabIndex = 73
        Me.Info_TT.SetToolTip(Me.UpdateOrdered_Product_LV, "Update/Delete Available.")
        Me.UpdateOrdered_Product_LV.UseCompatibleStateImageBehavior = False
        Me.UpdateOrdered_Product_LV.View = System.Windows.Forms.View.Details
        '
        'InfoDGV_TT
        '
        Me.InfoDGV_TT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.InfoDGV_TT.ToolTipTitle = "Current Order"
        '
        'OrderDetail_DGV
        '
        Me.OrderDetail_DGV.AllowUserToAddRows = False
        Me.OrderDetail_DGV.AllowUserToDeleteRows = False
        Me.OrderDetail_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderDetail_DGV.BackgroundColor = System.Drawing.Color.Linen
        Me.OrderDetail_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDetail_DGV.ColumnHeadersVisible = False
        Me.OrderDetail_DGV.Location = New System.Drawing.Point(16, 148)
        Me.OrderDetail_DGV.MultiSelect = False
        Me.OrderDetail_DGV.Name = "OrderDetail_DGV"
        Me.OrderDetail_DGV.ReadOnly = True
        Me.OrderDetail_DGV.RowHeadersVisible = False
        Me.OrderDetail_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderDetail_DGV.Size = New System.Drawing.Size(713, 168)
        Me.OrderDetail_DGV.TabIndex = 48
        Me.InfoDGV_TT.SetToolTip(Me.OrderDetail_DGV, "Update/Delete Unavailable")
        '
        'DeleteMeal_btn
        '
        Me.DeleteMeal_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteMeal_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteMeal_btn.Location = New System.Drawing.Point(1228, 165)
        Me.DeleteMeal_btn.Name = "DeleteMeal_btn"
        Me.DeleteMeal_btn.Size = New System.Drawing.Size(110, 31)
        Me.DeleteMeal_btn.TabIndex = 32
        Me.DeleteMeal_btn.Text = "Delete Order"
        Me.DeleteMeal_btn.UseVisualStyleBackColor = False
        '
        'CancelOrder_btn
        '
        Me.CancelOrder_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelOrder_btn.Location = New System.Drawing.Point(1228, 239)
        Me.CancelOrder_btn.Name = "CancelOrder_btn"
        Me.CancelOrder_btn.Size = New System.Drawing.Size(110, 31)
        Me.CancelOrder_btn.TabIndex = 33
        Me.CancelOrder_btn.Text = "Cancel Order"
        Me.CancelOrder_btn.UseVisualStyleBackColor = False
        '
        'Total_txtbox
        '
        Me.Total_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Total_txtbox.Location = New System.Drawing.Point(569, 507)
        Me.Total_txtbox.Name = "Total_txtbox"
        Me.Total_txtbox.ReadOnly = True
        Me.Total_txtbox.Size = New System.Drawing.Size(160, 15)
        Me.Total_txtbox.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(486, 507)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Total (RM) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(475, 535)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Cash (RM) :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Change (RM) :"
        '
        'Cash_txtbox
        '
        Me.Cash_txtbox.BackColor = System.Drawing.Color.LightPink
        Me.Cash_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cash_txtbox.Location = New System.Drawing.Point(569, 532)
        Me.Cash_txtbox.Name = "Cash_txtbox"
        Me.Cash_txtbox.ReadOnly = True
        Me.Cash_txtbox.Size = New System.Drawing.Size(160, 22)
        Me.Cash_txtbox.TabIndex = 60
        '
        'Change_txtbox
        '
        Me.Change_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Change_txtbox.Location = New System.Drawing.Point(569, 563)
        Me.Change_txtbox.Name = "Change_txtbox"
        Me.Change_txtbox.ReadOnly = True
        Me.Change_txtbox.Size = New System.Drawing.Size(160, 15)
        Me.Change_txtbox.TabIndex = 61
        '
        'TimeOut_lbl
        '
        Me.TimeOut_lbl.AutoSize = True
        Me.TimeOut_lbl.Location = New System.Drawing.Point(403, 535)
        Me.TimeOut_lbl.Name = "TimeOut_lbl"
        Me.TimeOut_lbl.Size = New System.Drawing.Size(66, 16)
        Me.TimeOut_lbl.TabIndex = 62
        Me.TimeOut_lbl.Text = "Time_Out"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(306, 48)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "20, Jalan Sri Parit, 71010 Port Dickson, N.Sembilan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Tel : 606-3365428       " & _
    "             Fax : 606-9930421" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                 Welcome to WaterLily Restaurant" & _
    ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(282, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 22)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "WaterLily Restaurant"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 585)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 32)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Thank You Very Much" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Come Back Again"
        '
        'Server_lbl
        '
        Me.Server_lbl.AutoSize = True
        Me.Server_lbl.Location = New System.Drawing.Point(80, 94)
        Me.Server_lbl.Name = "Server_lbl"
        Me.Server_lbl.Size = New System.Drawing.Size(12, 16)
        Me.Server_lbl.TabIndex = 67
        Me.Server_lbl.Text = "-"
        '
        'Order_ID_lbl
        '
        Me.Order_ID_lbl.AutoSize = True
        Me.Order_ID_lbl.Location = New System.Drawing.Point(80, 126)
        Me.Order_ID_lbl.Name = "Order_ID_lbl"
        Me.Order_ID_lbl.Size = New System.Drawing.Size(12, 16)
        Me.Order_ID_lbl.TabIndex = 69
        Me.Order_ID_lbl.Text = "-"
        '
        'Table_ID_lbl
        '
        Me.Table_ID_lbl.AutoSize = True
        Me.Table_ID_lbl.Location = New System.Drawing.Point(80, 110)
        Me.Table_ID_lbl.Name = "Table_ID_lbl"
        Me.Table_ID_lbl.Size = New System.Drawing.Size(12, 16)
        Me.Table_ID_lbl.TabIndex = 70
        Me.Table_ID_lbl.Text = "-"
        '
        'TodayDate_lbl
        '
        Me.TodayDate_lbl.AutoSize = True
        Me.TodayDate_lbl.Location = New System.Drawing.Point(623, 94)
        Me.TodayDate_lbl.Name = "TodayDate_lbl"
        Me.TodayDate_lbl.Size = New System.Drawing.Size(12, 16)
        Me.TodayDate_lbl.TabIndex = 71
        Me.TodayDate_lbl.Text = "-"
        '
        'TimeIn_lbl
        '
        Me.TimeIn_lbl.AutoSize = True
        Me.TimeIn_lbl.Location = New System.Drawing.Point(623, 110)
        Me.TimeIn_lbl.Name = "TimeIn_lbl"
        Me.TimeIn_lbl.Size = New System.Drawing.Size(12, 16)
        Me.TimeIn_lbl.TabIndex = 72
        Me.TimeIn_lbl.Text = "-"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Server"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Order ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Table ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(547, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 16)
        Me.Label16.TabIndex = 77
        Me.Label16.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(547, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 16)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Time"
        '
        'CID_lbl
        '
        Me.CID_lbl.AutoSize = True
        Me.CID_lbl.Location = New System.Drawing.Point(547, 127)
        Me.CID_lbl.Name = "CID_lbl"
        Me.CID_lbl.Size = New System.Drawing.Size(70, 16)
        Me.CID_lbl.TabIndex = 79
        Me.CID_lbl.Text = "Cashier ID"
        '
        'CashierID_lbl
        '
        Me.CashierID_lbl.AutoSize = True
        Me.CashierID_lbl.Location = New System.Drawing.Point(623, 127)
        Me.CashierID_lbl.Name = "CashierID_lbl"
        Me.CashierID_lbl.Size = New System.Drawing.Size(12, 16)
        Me.CashierID_lbl.TabIndex = 80
        Me.CashierID_lbl.Text = "-"
        '
        'Receipt_GB
        '
        Me.Receipt_GB.BackColor = System.Drawing.Color.Snow
        Me.Receipt_GB.Controls.Add(Me.CashierID_lbl)
        Me.Receipt_GB.Controls.Add(Me.CID_lbl)
        Me.Receipt_GB.Controls.Add(Me.Label15)
        Me.Receipt_GB.Controls.Add(Me.Label16)
        Me.Receipt_GB.Controls.Add(Me.Label7)
        Me.Receipt_GB.Controls.Add(Me.Label8)
        Me.Receipt_GB.Controls.Add(Me.Label14)
        Me.Receipt_GB.Controls.Add(Me.UpdateOrdered_Product_LV)
        Me.Receipt_GB.Controls.Add(Me.TimeIn_lbl)
        Me.Receipt_GB.Controls.Add(Me.TodayDate_lbl)
        Me.Receipt_GB.Controls.Add(Me.Table_ID_lbl)
        Me.Receipt_GB.Controls.Add(Me.Order_ID_lbl)
        Me.Receipt_GB.Controls.Add(Me.Server_lbl)
        Me.Receipt_GB.Controls.Add(Me.Label12)
        Me.Receipt_GB.Controls.Add(Me.Label10)
        Me.Receipt_GB.Controls.Add(Me.Label9)
        Me.Receipt_GB.Controls.Add(Me.TimeOut_lbl)
        Me.Receipt_GB.Controls.Add(Me.Change_txtbox)
        Me.Receipt_GB.Controls.Add(Me.Cash_txtbox)
        Me.Receipt_GB.Controls.Add(Me.Label6)
        Me.Receipt_GB.Controls.Add(Me.Label5)
        Me.Receipt_GB.Controls.Add(Me.Label13)
        Me.Receipt_GB.Controls.Add(Me.Total_txtbox)
        Me.Receipt_GB.Controls.Add(Me.OrderDetail_DGV)
        Me.Receipt_GB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_GB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Receipt_GB.Location = New System.Drawing.Point(465, 56)
        Me.Receipt_GB.Name = "Receipt_GB"
        Me.Receipt_GB.Size = New System.Drawing.Size(747, 624)
        Me.Receipt_GB.TabIndex = 15
        Me.Receipt_GB.TabStop = False
        Me.Receipt_GB.Text = "Receipt"
        '
        'WaiterCashier_Use
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.DineInTable_DGV)
        Me.Controls.Add(Me.CancelOrder_btn)
        Me.Controls.Add(Me.DeleteMeal_btn)
        Me.Controls.Add(Me.Edit_btn)
        Me.Controls.Add(Me.Load_btn)
        Me.Controls.Add(Me.View_btn)
        Me.Controls.Add(Me.CancelPurchase_btn)
        Me.Controls.Add(Me.Minus_btn)
        Me.Controls.Add(Me.SendUpdateOrder_btn)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.AddMeal_btn)
        Me.Controls.Add(Me.NewOrder_btn)
        Me.Controls.Add(Me.Confirm_btn)
        Me.Controls.Add(Me.NoOrder_lbl)
        Me.Controls.Add(Me.TotalOrder_lbl)
        Me.Controls.Add(Me.DineIn_lbl)
        Me.Controls.Add(Me.Receipt_GB)
        Me.Controls.Add(Me.TableID_txtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogOut_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTime_lbl)
        Me.Controls.Add(Me.Welcome_lbl)
        Me.Controls.Add(Me.Splitter1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "WaiterCashier_Use"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WaiterCashier_Use"
        CType(Me.DineInTable_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetail_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Receipt_GB.ResumeLayout(False)
        Me.Receipt_GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents DateTime_lbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LogOut_btn As System.Windows.Forms.Button
    Friend WithEvents DateTime_timer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableID_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents View_btn As System.Windows.Forms.Button
    Friend WithEvents DineInTable_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents NoOrder_lbl As System.Windows.Forms.Label
    Friend WithEvents TotalOrder_lbl As System.Windows.Forms.Label
    Friend WithEvents DineIn_lbl As System.Windows.Forms.Label
    Friend WithEvents Confirm_btn As System.Windows.Forms.Button
    Friend WithEvents NewOrder_btn As System.Windows.Forms.Button
    Friend WithEvents AddMeal_btn As System.Windows.Forms.Button
    Friend WithEvents Add_btn As System.Windows.Forms.Button
    Friend WithEvents SendUpdateOrder_btn As System.Windows.Forms.Button
    Friend WithEvents Minus_btn As System.Windows.Forms.Button
    Friend WithEvents CancelPurchase_btn As System.Windows.Forms.Button
    Friend WithEvents TimeOut_timer As System.Windows.Forms.Timer
    Friend WithEvents FosdatabaseDataSet As Workshop_InProgress.fosdatabaseDataSet
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.orderTableAdapter
    Friend WithEvents Load_btn As System.Windows.Forms.Button
    Friend WithEvents Edit_btn As System.Windows.Forms.Button
    Friend WithEvents Info_TT As System.Windows.Forms.ToolTip
    Friend WithEvents InfoDGV_TT As System.Windows.Forms.ToolTip
    Friend WithEvents DeleteMeal_btn As System.Windows.Forms.Button
    Friend WithEvents CancelOrder_btn As System.Windows.Forms.Button
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderDetail_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Total_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cash_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Change_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TimeOut_lbl As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Server_lbl As System.Windows.Forms.Label
    Friend WithEvents Order_ID_lbl As System.Windows.Forms.Label
    Friend WithEvents Table_ID_lbl As System.Windows.Forms.Label
    Friend WithEvents TodayDate_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeIn_lbl As System.Windows.Forms.Label
    Friend WithEvents UpdateOrdered_Product_LV As System.Windows.Forms.ListView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CID_lbl As System.Windows.Forms.Label
    Friend WithEvents CashierID_lbl As System.Windows.Forms.Label
    Friend WithEvents Receipt_GB As System.Windows.Forms.GroupBox
End Class
