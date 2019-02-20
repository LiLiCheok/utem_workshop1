<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen_Display
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
        Me.OrderInfo_DGV = New System.Windows.Forms.DataGridView()
        Me.Done_btn = New System.Windows.Forms.Button()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Logout_btn = New System.Windows.Forms.Button()
        Me.CurrTime = New System.Windows.Forms.Timer(Me.components)
        Me.CurrTime_lbl = New System.Windows.Forms.Label()
        Me.Welcome_lbl = New System.Windows.Forms.Label()
        Me.CurrDate_lbl = New System.Windows.Forms.Label()
        CType(Me.OrderInfo_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderInfo_DGV
        '
        Me.OrderInfo_DGV.AllowUserToAddRows = False
        Me.OrderInfo_DGV.AllowUserToDeleteRows = False
        Me.OrderInfo_DGV.AllowUserToResizeColumns = False
        Me.OrderInfo_DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OrderInfo_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderInfo_DGV.Location = New System.Drawing.Point(13, 50)
        Me.OrderInfo_DGV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OrderInfo_DGV.Name = "OrderInfo_DGV"
        Me.OrderInfo_DGV.ReadOnly = True
        Me.OrderInfo_DGV.RowHeadersVisible = False
        Me.OrderInfo_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderInfo_DGV.Size = New System.Drawing.Size(1129, 485)
        Me.OrderInfo_DGV.TabIndex = 0
        '
        'Done_btn
        '
        Me.Done_btn.BackColor = System.Drawing.Color.MistyRose
        Me.Done_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Done_btn.Location = New System.Drawing.Point(853, 545)
        Me.Done_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Done_btn.Name = "Done_btn"
        Me.Done_btn.Size = New System.Drawing.Size(91, 39)
        Me.Done_btn.TabIndex = 1
        Me.Done_btn.Text = "Done"
        Me.Done_btn.UseVisualStyleBackColor = False
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.Color.MistyRose
        Me.Update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.Location = New System.Drawing.Point(952, 545)
        Me.Update_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(91, 39)
        Me.Update_btn.TabIndex = 2
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'Logout_btn
        '
        Me.Logout_btn.BackColor = System.Drawing.Color.MistyRose
        Me.Logout_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout_btn.Location = New System.Drawing.Point(1051, 545)
        Me.Logout_btn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Logout_btn.Name = "Logout_btn"
        Me.Logout_btn.Size = New System.Drawing.Size(91, 39)
        Me.Logout_btn.TabIndex = 3
        Me.Logout_btn.Text = "Log Out"
        Me.Logout_btn.UseVisualStyleBackColor = False
        '
        'CurrTime
        '
        '
        'CurrTime_lbl
        '
        Me.CurrTime_lbl.AutoSize = True
        Me.CurrTime_lbl.BackColor = System.Drawing.Color.MistyRose
        Me.CurrTime_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrTime_lbl.Location = New System.Drawing.Point(1043, 14)
        Me.CurrTime_lbl.Name = "CurrTime_lbl"
        Me.CurrTime_lbl.Size = New System.Drawing.Size(100, 25)
        Me.CurrTime_lbl.TabIndex = 4
        Me.CurrTime_lbl.Text = "CurrTime"
        '
        'Welcome_lbl
        '
        Me.Welcome_lbl.AutoSize = True
        Me.Welcome_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_lbl.ForeColor = System.Drawing.Color.Snow
        Me.Welcome_lbl.Location = New System.Drawing.Point(12, 14)
        Me.Welcome_lbl.Name = "Welcome_lbl"
        Me.Welcome_lbl.Size = New System.Drawing.Size(97, 20)
        Me.Welcome_lbl.TabIndex = 5
        Me.Welcome_lbl.Text = "Welcome..."
        '
        'CurrDate_lbl
        '
        Me.CurrDate_lbl.AutoSize = True
        Me.CurrDate_lbl.BackColor = System.Drawing.Color.MistyRose
        Me.CurrDate_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrDate_lbl.Location = New System.Drawing.Point(910, 14)
        Me.CurrDate_lbl.Name = "CurrDate_lbl"
        Me.CurrDate_lbl.Size = New System.Drawing.Size(98, 25)
        Me.CurrDate_lbl.TabIndex = 6
        Me.CurrDate_lbl.Text = "CurrDate"
        '
        'Kitchen_Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(1155, 598)
        Me.Controls.Add(Me.CurrDate_lbl)
        Me.Controls.Add(Me.Welcome_lbl)
        Me.Controls.Add(Me.CurrTime_lbl)
        Me.Controls.Add(Me.Logout_btn)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Done_btn)
        Me.Controls.Add(Me.OrderInfo_DGV)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Kitchen_Display"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kitchen_Display"
        CType(Me.OrderInfo_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderInfo_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Done_btn As System.Windows.Forms.Button
    Friend WithEvents Update_btn As System.Windows.Forms.Button
    Friend WithEvents Logout_btn As System.Windows.Forms.Button
    Friend WithEvents CurrTime As System.Windows.Forms.Timer
    Friend WithEvents CurrTime_lbl As System.Windows.Forms.Label
    Friend WithEvents Welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents CurrDate_lbl As System.Windows.Forms.Label
End Class
