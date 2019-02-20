<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Me.DateTime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Welcome_lbl = New System.Windows.Forms.Label()
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.DateTime_lbl = New System.Windows.Forms.Label()
        Me.System_lbl = New System.Windows.Forms.Label()
        Me.TimeIn_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Receipt_GB = New System.Windows.Forms.GroupBox()
        Me.Ordered_Product_LV = New System.Windows.Forms.ListView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Total_txtbox = New System.Windows.Forms.TextBox()
        Me.AddMeal_btn = New System.Windows.Forms.Button()
        Me.DeleteQuantity_btn = New System.Windows.Forms.Button()
        Me.AddQuantity_btn = New System.Windows.Forms.Button()
        Me.DeleteMeal_btn = New System.Windows.Forms.Button()
        Me.TimeIn_txtbox = New System.Windows.Forms.TextBox()
        Me.Date_txtbox = New System.Windows.Forms.TextBox()
        Me.WaiterID_txtbox = New System.Windows.Forms.TextBox()
        Me.CancelOrder_btn = New System.Windows.Forms.Button()
        Me.SendOrder_btn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SelectTable_btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OrderNo_txtbox = New System.Windows.Forms.TextBox()
        Me.TableNo_txtbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Previous_btn = New System.Windows.Forms.Button()
        Me.Receipt_GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTime_timer
        '
        '
        'Welcome_lbl
        '
        Me.Welcome_lbl.AutoSize = True
        Me.Welcome_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Welcome_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_lbl.ForeColor = System.Drawing.Color.Purple
        Me.Welcome_lbl.Location = New System.Drawing.Point(3, 3)
        Me.Welcome_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Welcome_lbl.Name = "Welcome_lbl"
        Me.Welcome_lbl.Size = New System.Drawing.Size(165, 18)
        Me.Welcome_lbl.TabIndex = 10
        Me.Welcome_lbl.Text = "Welcome & Full Name"
        '
        'LogOut_btn
        '
        Me.LogOut_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_btn.Location = New System.Drawing.Point(975, 566)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Size = New System.Drawing.Size(114, 33)
        Me.LogOut_btn.TabIndex = 6
        Me.LogOut_btn.Text = "Log Out"
        Me.LogOut_btn.UseVisualStyleBackColor = False
        '
        'DateTime_lbl
        '
        Me.DateTime_lbl.AutoSize = True
        Me.DateTime_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_lbl.ForeColor = System.Drawing.Color.Lime
        Me.DateTime_lbl.Location = New System.Drawing.Point(959, 617)
        Me.DateTime_lbl.Name = "DateTime_lbl"
        Me.DateTime_lbl.Size = New System.Drawing.Size(97, 16)
        Me.DateTime_lbl.TabIndex = 1
        Me.DateTime_lbl.Text = "DATE , TIME"
        '
        'System_lbl
        '
        Me.System_lbl.AutoSize = True
        Me.System_lbl.BackColor = System.Drawing.Color.Transparent
        Me.System_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.System_lbl.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.System_lbl.Location = New System.Drawing.Point(3, 617)
        Me.System_lbl.Name = "System_lbl"
        Me.System_lbl.Size = New System.Drawing.Size(119, 16)
        Me.System_lbl.TabIndex = 0
        Me.System_lbl.Text = "FOS version 10.1.4"
        '
        'TimeIn_timer
        '
        '
        'Receipt_GB
        '
        Me.Receipt_GB.Controls.Add(Me.Ordered_Product_LV)
        Me.Receipt_GB.Controls.Add(Me.Label13)
        Me.Receipt_GB.Controls.Add(Me.Total_txtbox)
        Me.Receipt_GB.Controls.Add(Me.AddMeal_btn)
        Me.Receipt_GB.Controls.Add(Me.DeleteQuantity_btn)
        Me.Receipt_GB.Controls.Add(Me.AddQuantity_btn)
        Me.Receipt_GB.Controls.Add(Me.DeleteMeal_btn)
        Me.Receipt_GB.Controls.Add(Me.TimeIn_txtbox)
        Me.Receipt_GB.Controls.Add(Me.Date_txtbox)
        Me.Receipt_GB.Controls.Add(Me.WaiterID_txtbox)
        Me.Receipt_GB.Controls.Add(Me.CancelOrder_btn)
        Me.Receipt_GB.Controls.Add(Me.SendOrder_btn)
        Me.Receipt_GB.Controls.Add(Me.Label12)
        Me.Receipt_GB.Controls.Add(Me.SelectTable_btn)
        Me.Receipt_GB.Controls.Add(Me.Label10)
        Me.Receipt_GB.Controls.Add(Me.Label7)
        Me.Receipt_GB.Controls.Add(Me.OrderNo_txtbox)
        Me.Receipt_GB.Controls.Add(Me.TableNo_txtbox)
        Me.Receipt_GB.Controls.Add(Me.Label6)
        Me.Receipt_GB.Controls.Add(Me.Label5)
        Me.Receipt_GB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Receipt_GB.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Receipt_GB.Location = New System.Drawing.Point(9, 24)
        Me.Receipt_GB.Name = "Receipt_GB"
        Me.Receipt_GB.Size = New System.Drawing.Size(1080, 533)
        Me.Receipt_GB.TabIndex = 14
        Me.Receipt_GB.TabStop = False
        '
        'Ordered_Product_LV
        '
        Me.Ordered_Product_LV.FullRowSelect = True
        Me.Ordered_Product_LV.GridLines = True
        Me.Ordered_Product_LV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Ordered_Product_LV.HideSelection = False
        Me.Ordered_Product_LV.Location = New System.Drawing.Point(15, 129)
        Me.Ordered_Product_LV.MultiSelect = False
        Me.Ordered_Product_LV.Name = "Ordered_Product_LV"
        Me.Ordered_Product_LV.Size = New System.Drawing.Size(924, 353)
        Me.Ordered_Product_LV.TabIndex = 45
        Me.Ordered_Product_LV.UseCompatibleStateImageBehavior = False
        Me.Ordered_Product_LV.View = System.Windows.Forms.View.Details
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(618, 495)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 20)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Total Due (RM) :"
        '
        'Total_txtbox
        '
        Me.Total_txtbox.Location = New System.Drawing.Point(749, 492)
        Me.Total_txtbox.Name = "Total_txtbox"
        Me.Total_txtbox.ReadOnly = True
        Me.Total_txtbox.Size = New System.Drawing.Size(190, 26)
        Me.Total_txtbox.TabIndex = 40
        '
        'AddMeal_btn
        '
        Me.AddMeal_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddMeal_btn.Location = New System.Drawing.Point(946, 234)
        Me.AddMeal_btn.Name = "AddMeal_btn"
        Me.AddMeal_btn.Size = New System.Drawing.Size(121, 37)
        Me.AddMeal_btn.TabIndex = 36
        Me.AddMeal_btn.Text = "Add Order"
        Me.AddMeal_btn.UseVisualStyleBackColor = False
        '
        'DeleteQuantity_btn
        '
        Me.DeleteQuantity_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteQuantity_btn.Location = New System.Drawing.Point(946, 313)
        Me.DeleteQuantity_btn.Name = "DeleteQuantity_btn"
        Me.DeleteQuantity_btn.Size = New System.Drawing.Size(46, 37)
        Me.DeleteQuantity_btn.TabIndex = 32
        Me.DeleteQuantity_btn.Text = "-"
        Me.DeleteQuantity_btn.UseVisualStyleBackColor = False
        '
        'AddQuantity_btn
        '
        Me.AddQuantity_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddQuantity_btn.Location = New System.Drawing.Point(946, 275)
        Me.AddQuantity_btn.Name = "AddQuantity_btn"
        Me.AddQuantity_btn.Size = New System.Drawing.Size(46, 37)
        Me.AddQuantity_btn.TabIndex = 31
        Me.AddQuantity_btn.Text = "+"
        Me.AddQuantity_btn.UseVisualStyleBackColor = False
        '
        'DeleteMeal_btn
        '
        Me.DeleteMeal_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.DeleteMeal_btn.Location = New System.Drawing.Point(946, 361)
        Me.DeleteMeal_btn.Name = "DeleteMeal_btn"
        Me.DeleteMeal_btn.Size = New System.Drawing.Size(121, 37)
        Me.DeleteMeal_btn.TabIndex = 25
        Me.DeleteMeal_btn.Text = "Delete Order"
        Me.DeleteMeal_btn.UseVisualStyleBackColor = False
        '
        'TimeIn_txtbox
        '
        Me.TimeIn_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeIn_txtbox.Location = New System.Drawing.Point(709, 56)
        Me.TimeIn_txtbox.Name = "TimeIn_txtbox"
        Me.TimeIn_txtbox.ReadOnly = True
        Me.TimeIn_txtbox.Size = New System.Drawing.Size(230, 26)
        Me.TimeIn_txtbox.TabIndex = 20
        '
        'Date_txtbox
        '
        Me.Date_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_txtbox.Location = New System.Drawing.Point(709, 20)
        Me.Date_txtbox.Name = "Date_txtbox"
        Me.Date_txtbox.ReadOnly = True
        Me.Date_txtbox.Size = New System.Drawing.Size(230, 26)
        Me.Date_txtbox.TabIndex = 19
        '
        'WaiterID_txtbox
        '
        Me.WaiterID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaiterID_txtbox.Location = New System.Drawing.Point(101, 20)
        Me.WaiterID_txtbox.Name = "WaiterID_txtbox"
        Me.WaiterID_txtbox.ReadOnly = True
        Me.WaiterID_txtbox.Size = New System.Drawing.Size(230, 26)
        Me.WaiterID_txtbox.TabIndex = 18
        '
        'CancelOrder_btn
        '
        Me.CancelOrder_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelOrder_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CancelOrder_btn.Location = New System.Drawing.Point(946, 445)
        Me.CancelOrder_btn.Name = "CancelOrder_btn"
        Me.CancelOrder_btn.Size = New System.Drawing.Size(121, 37)
        Me.CancelOrder_btn.TabIndex = 17
        Me.CancelOrder_btn.Text = "Cancel Order"
        Me.CancelOrder_btn.UseVisualStyleBackColor = False
        '
        'SendOrder_btn
        '
        Me.SendOrder_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SendOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendOrder_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SendOrder_btn.Location = New System.Drawing.Point(946, 404)
        Me.SendOrder_btn.Name = "SendOrder_btn"
        Me.SendOrder_btn.Size = New System.Drawing.Size(121, 37)
        Me.SendOrder_btn.TabIndex = 16
        Me.SendOrder_btn.Text = "Save Order"
        Me.SendOrder_btn.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(607, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Date             :"
        '
        'SelectTable_btn
        '
        Me.SelectTable_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SelectTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectTable_btn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SelectTable_btn.Location = New System.Drawing.Point(338, 55)
        Me.SelectTable_btn.Name = "SelectTable_btn"
        Me.SelectTable_btn.Size = New System.Drawing.Size(128, 31)
        Me.SelectTable_btn.TabIndex = 8
        Me.SelectTable_btn.Text = "Select Table"
        Me.SelectTable_btn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(607, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Time-in         :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Waiter ID  :"
        '
        'OrderNo_txtbox
        '
        Me.OrderNo_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderNo_txtbox.Location = New System.Drawing.Point(101, 91)
        Me.OrderNo_txtbox.Name = "OrderNo_txtbox"
        Me.OrderNo_txtbox.ReadOnly = True
        Me.OrderNo_txtbox.Size = New System.Drawing.Size(230, 26)
        Me.OrderNo_txtbox.TabIndex = 3
        '
        'TableNo_txtbox
        '
        Me.TableNo_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableNo_txtbox.Location = New System.Drawing.Point(101, 55)
        Me.TableNo_txtbox.Name = "TableNo_txtbox"
        Me.TableNo_txtbox.Size = New System.Drawing.Size(230, 26)
        Me.TableNo_txtbox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Order ID  :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(13, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Table ID   :"
        '
        'Previous_btn
        '
        Me.Previous_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Previous_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Previous_btn.Location = New System.Drawing.Point(9, 566)
        Me.Previous_btn.Name = "Previous_btn"
        Me.Previous_btn.Size = New System.Drawing.Size(114, 33)
        Me.Previous_btn.TabIndex = 26
        Me.Previous_btn.Text = "Previous"
        Me.Previous_btn.UseVisualStyleBackColor = False
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1100, 635)
        Me.Controls.Add(Me.Previous_btn)
        Me.Controls.Add(Me.Receipt_GB)
        Me.Controls.Add(Me.Welcome_lbl)
        Me.Controls.Add(Me.LogOut_btn)
        Me.Controls.Add(Me.DateTime_lbl)
        Me.Controls.Add(Me.System_lbl)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order"
        Me.Receipt_GB.ResumeLayout(False)
        Me.Receipt_GB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTime_timer As System.Windows.Forms.Timer
    Friend WithEvents TableNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeinDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents LogOut_btn As System.Windows.Forms.Button
    Friend WithEvents DateTime_lbl As System.Windows.Forms.Label
    Friend WithEvents System_lbl As System.Windows.Forms.Label
    Friend WithEvents TimeIn_timer As System.Windows.Forms.Timer
    Friend WithEvents Receipt_GB As System.Windows.Forms.GroupBox
    Friend WithEvents TimeIn_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Date_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents WaiterID_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents CancelOrder_btn As System.Windows.Forms.Button
    Friend WithEvents SendOrder_btn As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SelectTable_btn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OrderNo_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TableNo_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DeleteMeal_btn As System.Windows.Forms.Button
    Friend WithEvents Previous_btn As System.Windows.Forms.Button
    Friend WithEvents SubpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeleteQuantity_btn As System.Windows.Forms.Button
    Friend WithEvents AddQuantity_btn As System.Windows.Forms.Button
    Friend WithEvents AddMeal_btn As System.Windows.Forms.Button
    Friend WithEvents Total_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Ordered_Product_LV As System.Windows.Forms.ListView
    'Friend WithEvents FosdatabaseDataSet4 As Workshop_InProgress.fosdatabaseDataSet4
    'Friend WithEvents Fos_receipt_p2TableAdapter As Workshop_InProgress.fosdatabaseDataSet4TableAdapters.fos_receipt_p2TableAdapter
    'Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents SubpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
