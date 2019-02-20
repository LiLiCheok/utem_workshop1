<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily_Sales_Report
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
        Me.DailySales_DGV = New System.Windows.Forms.DataGridView()
        Me.TotalOrder_lbl = New System.Windows.Forms.Label()
        Me.TotalOrder_txtbox = New System.Windows.Forms.TextBox()
        Me.TotalEarn_lbl = New System.Windows.Forms.Label()
        Me.TotalEarn_txtbox = New System.Windows.Forms.TextBox()
        Me.DailySales_DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Print_btn = New System.Windows.Forms.Button()
        Me.Cancel_btn = New System.Windows.Forms.Button()
        Me.NetPrice_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        CType(Me.DailySales_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DailySales_DGV
        '
        Me.DailySales_DGV.AllowUserToAddRows = False
        Me.DailySales_DGV.AllowUserToDeleteRows = False
        Me.DailySales_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DailySales_DGV.BackgroundColor = System.Drawing.Color.MediumAquamarine
        Me.DailySales_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DailySales_DGV.Location = New System.Drawing.Point(17, 156)
        Me.DailySales_DGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DailySales_DGV.Name = "DailySales_DGV"
        Me.DailySales_DGV.ReadOnly = True
        Me.DailySales_DGV.RowHeadersVisible = False
        Me.DailySales_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DailySales_DGV.Size = New System.Drawing.Size(723, 284)
        Me.DailySales_DGV.TabIndex = 24
        '
        'TotalOrder_lbl
        '
        Me.TotalOrder_lbl.AutoSize = True
        Me.TotalOrder_lbl.Location = New System.Drawing.Point(13, 123)
        Me.TotalOrder_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalOrder_lbl.Name = "TotalOrder_lbl"
        Me.TotalOrder_lbl.Size = New System.Drawing.Size(96, 20)
        Me.TotalOrder_lbl.TabIndex = 25
        Me.TotalOrder_lbl.Text = "Total Order :"
        '
        'TotalOrder_txtbox
        '
        Me.TotalOrder_txtbox.Location = New System.Drawing.Point(115, 120)
        Me.TotalOrder_txtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalOrder_txtbox.Name = "TotalOrder_txtbox"
        Me.TotalOrder_txtbox.ReadOnly = True
        Me.TotalOrder_txtbox.Size = New System.Drawing.Size(122, 26)
        Me.TotalOrder_txtbox.TabIndex = 26
        '
        'TotalEarn_lbl
        '
        Me.TotalEarn_lbl.AutoSize = True
        Me.TotalEarn_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEarn_lbl.Location = New System.Drawing.Point(417, 455)
        Me.TotalEarn_lbl.Name = "TotalEarn_lbl"
        Me.TotalEarn_lbl.Size = New System.Drawing.Size(146, 20)
        Me.TotalEarn_lbl.TabIndex = 31
        Me.TotalEarn_lbl.Text = "Total Earn (RM) :"
        '
        'TotalEarn_txtbox
        '
        Me.TotalEarn_txtbox.Location = New System.Drawing.Point(569, 452)
        Me.TotalEarn_txtbox.Name = "TotalEarn_txtbox"
        Me.TotalEarn_txtbox.ReadOnly = True
        Me.TotalEarn_txtbox.Size = New System.Drawing.Size(171, 26)
        Me.TotalEarn_txtbox.TabIndex = 32
        '
        'DailySales_DTP
        '
        Me.DailySales_DTP.CalendarMonthBackground = System.Drawing.Color.White
        Me.DailySales_DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DailySales_DTP.Location = New System.Drawing.Point(71, 86)
        Me.DailySales_DTP.Name = "DailySales_DTP"
        Me.DailySales_DTP.Size = New System.Drawing.Size(122, 26)
        Me.DailySales_DTP.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(267, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 24)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "WaterLily Restaurant"
        '
        'Print_btn
        '
        Me.Print_btn.Location = New System.Drawing.Point(564, 493)
        Me.Print_btn.Name = "Print_btn"
        Me.Print_btn.Size = New System.Drawing.Size(85, 32)
        Me.Print_btn.TabIndex = 35
        Me.Print_btn.Text = "Print"
        Me.Print_btn.UseVisualStyleBackColor = True
        '
        'Cancel_btn
        '
        Me.Cancel_btn.Location = New System.Drawing.Point(655, 493)
        Me.Cancel_btn.Name = "Cancel_btn"
        Me.Cancel_btn.Size = New System.Drawing.Size(85, 32)
        Me.Cancel_btn.TabIndex = 36
        Me.Cancel_btn.Text = "Cancel"
        Me.Cancel_btn.UseVisualStyleBackColor = True
        '
        'NetPrice_TT
        '
        Me.NetPrice_TT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NetPrice_TT.ToolTipTitle = "Total of..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 40)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "20, Jalan Sri Parit, 71010 Port Dickson, N.Sembilan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Tel : 606-3365428       " & _
    "             Fax : 606-9930421"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.PaleGreen
        Me.Label31.Location = New System.Drawing.Point(13, 87)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(52, 20)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Date :"
        '
        'Daily_Sales_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(753, 535)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cancel_btn)
        Me.Controls.Add(Me.Print_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DailySales_DTP)
        Me.Controls.Add(Me.TotalEarn_txtbox)
        Me.Controls.Add(Me.TotalEarn_lbl)
        Me.Controls.Add(Me.TotalOrder_txtbox)
        Me.Controls.Add(Me.TotalOrder_lbl)
        Me.Controls.Add(Me.DailySales_DGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Daily_Sales_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily_Sales_Report"
        CType(Me.DailySales_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DailySales_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TotalOrder_lbl As System.Windows.Forms.Label
    Friend WithEvents TotalOrder_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TotalEarn_lbl As System.Windows.Forms.Label
    Friend WithEvents TotalEarn_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents DailySales_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Print_btn As System.Windows.Forms.Button
    Friend WithEvents Cancel_btn As System.Windows.Forms.Button
    Friend WithEvents NetPrice_TT As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
End Class
