<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Page
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
        Me.DateTime_lbl = New System.Windows.Forms.Label()
        Me.LogIn_btn = New System.Windows.Forms.Button()
        Me.Greeting_lbl = New System.Windows.Forms.Label()
        Me.DateTime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.System_lbl = New System.Windows.Forms.Label()
        Me.Password_txtbox = New System.Windows.Forms.TextBox()
        Me.Password_lbl = New System.Windows.Forms.Label()
        Me.Username_lbl = New System.Windows.Forms.Label()
        Me.Warning_lbl = New System.Windows.Forms.Label()
        Me.Username_txtbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTime_lbl
        '
        Me.DateTime_lbl.AutoSize = True
        Me.DateTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.DateTime_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_lbl.ForeColor = System.Drawing.Color.Lime
        Me.DateTime_lbl.Location = New System.Drawing.Point(341, 454)
        Me.DateTime_lbl.Name = "DateTime_lbl"
        Me.DateTime_lbl.Size = New System.Drawing.Size(97, 16)
        Me.DateTime_lbl.TabIndex = 17
        Me.DateTime_lbl.Text = "DATE , TIME"
        '
        'LogIn_btn
        '
        Me.LogIn_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogIn_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn_btn.ForeColor = System.Drawing.Color.Black
        Me.LogIn_btn.Location = New System.Drawing.Point(343, 372)
        Me.LogIn_btn.Name = "LogIn_btn"
        Me.LogIn_btn.Size = New System.Drawing.Size(99, 38)
        Me.LogIn_btn.TabIndex = 13
        Me.LogIn_btn.Text = " Login"
        Me.LogIn_btn.UseVisualStyleBackColor = False
        '
        'Greeting_lbl
        '
        Me.Greeting_lbl.AutoSize = True
        Me.Greeting_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Greeting_lbl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Greeting_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Greeting_lbl.ForeColor = System.Drawing.Color.Yellow
        Me.Greeting_lbl.Location = New System.Drawing.Point(12, 10)
        Me.Greeting_lbl.Name = "Greeting_lbl"
        Me.Greeting_lbl.Size = New System.Drawing.Size(447, 31)
        Me.Greeting_lbl.TabIndex = 10
        Me.Greeting_lbl.Text = "~ Serve customer with a SMILE ~"
        Me.Greeting_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DateTime_timer
        '
        Me.DateTime_timer.Interval = 500
        '
        'System_lbl
        '
        Me.System_lbl.AutoSize = True
        Me.System_lbl.BackColor = System.Drawing.Color.Transparent
        Me.System_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.System_lbl.ForeColor = System.Drawing.Color.Lime
        Me.System_lbl.Location = New System.Drawing.Point(3, 454)
        Me.System_lbl.Name = "System_lbl"
        Me.System_lbl.Size = New System.Drawing.Size(119, 16)
        Me.System_lbl.TabIndex = 19
        Me.System_lbl.Text = "FOS version 10.1.4"
        '
        'Password_txtbox
        '
        Me.Password_txtbox.BackColor = System.Drawing.Color.Snow
        Me.Password_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtbox.ForeColor = System.Drawing.Color.Black
        Me.Password_txtbox.Location = New System.Drawing.Point(162, 308)
        Me.Password_txtbox.Name = "Password_txtbox"
        Me.Password_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_txtbox.Size = New System.Drawing.Size(280, 31)
        Me.Password_txtbox.TabIndex = 22
        '
        'Password_lbl
        '
        Me.Password_lbl.AutoSize = True
        Me.Password_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Password_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_lbl.ForeColor = System.Drawing.Color.Gold
        Me.Password_lbl.Location = New System.Drawing.Point(23, 311)
        Me.Password_lbl.Name = "Password_lbl"
        Me.Password_lbl.Size = New System.Drawing.Size(138, 25)
        Me.Password_lbl.TabIndex = 20
        Me.Password_lbl.Text = "Password  * :"
        '
        'Username_lbl
        '
        Me.Username_lbl.AutoSize = True
        Me.Username_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Username_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_lbl.ForeColor = System.Drawing.Color.Gold
        Me.Username_lbl.Location = New System.Drawing.Point(24, 272)
        Me.Username_lbl.Name = "Username_lbl"
        Me.Username_lbl.Size = New System.Drawing.Size(136, 25)
        Me.Username_lbl.TabIndex = 19
        Me.Username_lbl.Text = "Username * :"
        '
        'Warning_lbl
        '
        Me.Warning_lbl.AutoSize = True
        Me.Warning_lbl.BackColor = System.Drawing.Color.MistyRose
        Me.Warning_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warning_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Warning_lbl.Location = New System.Drawing.Point(28, 347)
        Me.Warning_lbl.Name = "Warning_lbl"
        Me.Warning_lbl.Size = New System.Drawing.Size(286, 16)
        Me.Warning_lbl.TabIndex = 23
        Me.Warning_lbl.Text = "*Please enter a valid username and password."
        Me.Warning_lbl.Visible = False
        '
        'Username_txtbox
        '
        Me.Username_txtbox.BackColor = System.Drawing.Color.Snow
        Me.Username_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txtbox.ForeColor = System.Drawing.Color.Black
        Me.Username_txtbox.Location = New System.Drawing.Point(162, 272)
        Me.Username_txtbox.Name = "Username_txtbox"
        Me.Username_txtbox.Size = New System.Drawing.Size(280, 31)
        Me.Username_txtbox.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Workshop_InProgress.My.Resources.Resources.waiter_smile
        Me.PictureBox1.Location = New System.Drawing.Point(18, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(441, 338)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Buxton Sketch", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(61, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Welcome to WaterLily Restaurant"
        '
        'Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(482, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Password_txtbox)
        Me.Controls.Add(Me.System_lbl)
        Me.Controls.Add(Me.Password_lbl)
        Me.Controls.Add(Me.DateTime_lbl)
        Me.Controls.Add(Me.Username_lbl)
        Me.Controls.Add(Me.Greeting_lbl)
        Me.Controls.Add(Me.LogIn_btn)
        Me.Controls.Add(Me.Warning_lbl)
        Me.Controls.Add(Me.Username_txtbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Page"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTime_lbl As System.Windows.Forms.Label
    Friend WithEvents LogIn_btn As System.Windows.Forms.Button
    Friend WithEvents Greeting_lbl As System.Windows.Forms.Label
    Friend WithEvents DateTime_timer As System.Windows.Forms.Timer
    Friend WithEvents System_lbl As System.Windows.Forms.Label
    Friend WithEvents Password_lbl As System.Windows.Forms.Label
    Friend WithEvents Username_lbl As System.Windows.Forms.Label
    Friend WithEvents Password_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Warning_lbl As System.Windows.Forms.Label
    Friend WithEvents Username_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
