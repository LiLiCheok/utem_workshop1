<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitchenLogin
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
        Me.Password_txtbox = New System.Windows.Forms.TextBox()
        Me.Username_txtbox = New System.Windows.Forms.TextBox()
        Me.Warning_lbl = New System.Windows.Forms.Label()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.Username_lbl = New System.Windows.Forms.Label()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Password_txtbox
        '
        Me.Password_txtbox.BackColor = System.Drawing.Color.Snow
        Me.Password_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtbox.ForeColor = System.Drawing.Color.Black
        Me.Password_txtbox.Location = New System.Drawing.Point(152, 48)
        Me.Password_txtbox.Name = "Password_txtbox"
        Me.Password_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_txtbox.Size = New System.Drawing.Size(280, 31)
        Me.Password_txtbox.TabIndex = 29
        '
        'Username_txtbox
        '
        Me.Username_txtbox.BackColor = System.Drawing.Color.Snow
        Me.Username_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txtbox.ForeColor = System.Drawing.Color.Black
        Me.Username_txtbox.Location = New System.Drawing.Point(152, 12)
        Me.Username_txtbox.Name = "Username_txtbox"
        Me.Username_txtbox.Size = New System.Drawing.Size(280, 31)
        Me.Username_txtbox.TabIndex = 27
        '
        'Warning_lbl
        '
        Me.Warning_lbl.AutoSize = True
        Me.Warning_lbl.BackColor = System.Drawing.Color.MistyRose
        Me.Warning_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warning_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Warning_lbl.Location = New System.Drawing.Point(18, 87)
        Me.Warning_lbl.Name = "Warning_lbl"
        Me.Warning_lbl.Size = New System.Drawing.Size(286, 16)
        Me.Warning_lbl.TabIndex = 30
        Me.Warning_lbl.Text = "*Please enter a valid username and password."
        Me.Warning_lbl.Visible = False
        '
        'LogIn_btn
        '
        Me.LogIn_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogIn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn_btn.ForeColor = System.Drawing.Color.Black
        Me.LogIn_btn.Location = New System.Drawing.Point(320, 87)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(112, 37)
        Me.LogIn_btn.TabIndex = 24
        Me.LogIn_btn.Text = " Login"
        Me.LogIn_btn.UseVisualStyleBackColor = False
        '
        'Username_lbl
        '
        Me.Username_lbl.AutoSize = True
        Me.Username_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Username_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_lbl.ForeColor = System.Drawing.Color.Gold
        Me.Username_lbl.Location = New System.Drawing.Point(14, 12)
        Me.Username_lbl.Name = "Username_lbl"
        Me.Username_lbl.Size = New System.Drawing.Size(136, 25)
        Me.Username_lbl.TabIndex = 25
        Me.Username_lbl.Text = "Username * :"
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Password_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_lbl.ForeColor = System.Drawing.Color.Gold
        Me.Password_lbl.Location = New System.Drawing.Point(13, 51)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(138, 25)
        Me.Password_lbl.TabIndex = 26
        Me.Password_lbl.Text = "Password  * :"
        '
        'KitchenLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(452, 137)
        Me.Controls.Add(Me.Password_txtbox)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.Username_lbl)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Warning_lbl)
        Me.Controls.Add(Me.Username_txtbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "KitchenLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KitchenLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Password_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Username_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Warning_lbl As System.Windows.Forms.Label
    Friend WithEvents LogIn_btn As System.Windows.Forms.Button
    Friend WithEvents Username_lbl As System.Windows.Forms.Label
    Friend WithEvents Password_lbl As System.Windows.Forms.Label
End Class
