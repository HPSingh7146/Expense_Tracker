<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.logpnl = New System.Windows.Forms.Panel()
        Me.regpnl = New System.Windows.Forms.Panel()
        Me.register = New System.Windows.Forms.Button()
        Me.loginnow = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.regnametxtbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.regpasstxtbox = New System.Windows.Forms.TextBox()
        Me.regunametxtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.regbtn = New System.Windows.Forms.Button()
        Me.logbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTxtbox = New System.Windows.Forms.TextBox()
        Me.UsernameTxtbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.logpnl.SuspendLayout()
        Me.regpnl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'logpnl
        '
        Me.logpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.logpnl.Controls.Add(Me.regpnl)
        Me.logpnl.Controls.Add(Me.Label4)
        Me.logpnl.Controls.Add(Me.Label24)
        Me.logpnl.Controls.Add(Me.regbtn)
        Me.logpnl.Controls.Add(Me.logbtn)
        Me.logpnl.Controls.Add(Me.Label3)
        Me.logpnl.Controls.Add(Me.Label2)
        Me.logpnl.Controls.Add(Me.PasswordTxtbox)
        Me.logpnl.Controls.Add(Me.UsernameTxtbox)
        Me.logpnl.Controls.Add(Me.PictureBox1)
        Me.logpnl.Location = New System.Drawing.Point(51, 86)
        Me.logpnl.Name = "logpnl"
        Me.logpnl.Size = New System.Drawing.Size(513, 438)
        Me.logpnl.TabIndex = 0
        '
        'regpnl
        '
        Me.regpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.regpnl.Controls.Add(Me.register)
        Me.regpnl.Controls.Add(Me.loginnow)
        Me.regpnl.Controls.Add(Me.Label9)
        Me.regpnl.Controls.Add(Me.Label10)
        Me.regpnl.Controls.Add(Me.regnametxtbox)
        Me.regpnl.Controls.Add(Me.Label5)
        Me.regpnl.Controls.Add(Me.Label6)
        Me.regpnl.Controls.Add(Me.Label7)
        Me.regpnl.Controls.Add(Me.Label8)
        Me.regpnl.Controls.Add(Me.regpasstxtbox)
        Me.regpnl.Controls.Add(Me.regunametxtbox)
        Me.regpnl.Location = New System.Drawing.Point(3, 3)
        Me.regpnl.Name = "regpnl"
        Me.regpnl.Size = New System.Drawing.Size(507, 432)
        Me.regpnl.TabIndex = 9
        '
        'register
        '
        Me.register.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.register.FlatAppearance.BorderSize = 0
        Me.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.register.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.Color.White
        Me.register.Location = New System.Drawing.Point(257, 358)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(197, 55)
        Me.register.TabIndex = 11
        Me.register.Text = "Register"
        Me.register.UseVisualStyleBackColor = False
        '
        'loginnow
        '
        Me.loginnow.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginnow.FlatAppearance.BorderSize = 0
        Me.loginnow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginnow.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginnow.ForeColor = System.Drawing.Color.White
        Me.loginnow.Location = New System.Drawing.Point(55, 358)
        Me.loginnow.Name = "loginnow"
        Me.loginnow.Size = New System.Drawing.Size(184, 55)
        Me.loginnow.TabIndex = 10
        Me.loginnow.Text = "Login Page"
        Me.loginnow.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 2)
        Me.Label9.TabIndex = 17
        Me.Label9.UseMnemonic = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(220, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Name"
        '
        'regnametxtbox
        '
        Me.regnametxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.regnametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regnametxtbox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regnametxtbox.ForeColor = System.Drawing.Color.White
        Me.regnametxtbox.Location = New System.Drawing.Point(59, 122)
        Me.regnametxtbox.Multiline = True
        Me.regnametxtbox.Name = "regnametxtbox"
        Me.regnametxtbox.Size = New System.Drawing.Size(399, 35)
        Me.regnametxtbox.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 2)
        Me.Label5.TabIndex = 14
        Me.Label5.UseMnemonic = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(400, 2)
        Me.Label6.TabIndex = 13
        Me.Label6.UseMnemonic = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(208, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(208, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Username"
        '
        'regpasstxtbox
        '
        Me.regpasstxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.regpasstxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regpasstxtbox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regpasstxtbox.ForeColor = System.Drawing.Color.White
        Me.regpasstxtbox.Location = New System.Drawing.Point(59, 297)
        Me.regpasstxtbox.Multiline = True
        Me.regpasstxtbox.Name = "regpasstxtbox"
        Me.regpasstxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.regpasstxtbox.Size = New System.Drawing.Size(399, 35)
        Me.regpasstxtbox.TabIndex = 10
        '
        'regunametxtbox
        '
        Me.regunametxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.regunametxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.regunametxtbox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regunametxtbox.ForeColor = System.Drawing.Color.White
        Me.regunametxtbox.Location = New System.Drawing.Point(59, 213)
        Me.regunametxtbox.Multiline = True
        Me.regunametxtbox.Name = "regunametxtbox"
        Me.regunametxtbox.Size = New System.Drawing.Size(399, 35)
        Me.regunametxtbox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(400, 2)
        Me.Label4.TabIndex = 8
        Me.Label4.UseMnemonic = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(57, 240)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(400, 2)
        Me.Label24.TabIndex = 7
        Me.Label24.UseMnemonic = False
        '
        'regbtn
        '
        Me.regbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.regbtn.FlatAppearance.BorderSize = 0
        Me.regbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.regbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regbtn.ForeColor = System.Drawing.Color.White
        Me.regbtn.Location = New System.Drawing.Point(260, 361)
        Me.regbtn.Name = "regbtn"
        Me.regbtn.Size = New System.Drawing.Size(197, 55)
        Me.regbtn.TabIndex = 6
        Me.regbtn.Text = "Register Page"
        Me.regbtn.UseVisualStyleBackColor = False
        '
        'logbtn
        '
        Me.logbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.logbtn.FlatAppearance.BorderSize = 0
        Me.logbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logbtn.ForeColor = System.Drawing.Color.White
        Me.logbtn.Location = New System.Drawing.Point(58, 361)
        Me.logbtn.Name = "logbtn"
        Me.logbtn.Size = New System.Drawing.Size(184, 55)
        Me.logbtn.TabIndex = 5
        Me.logbtn.Text = "Login"
        Me.logbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(207, 266)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(207, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Username"
        '
        'PasswordTxtbox
        '
        Me.PasswordTxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PasswordTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PasswordTxtbox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTxtbox.ForeColor = System.Drawing.Color.White
        Me.PasswordTxtbox.Location = New System.Drawing.Point(58, 292)
        Me.PasswordTxtbox.Multiline = True
        Me.PasswordTxtbox.Name = "PasswordTxtbox"
        Me.PasswordTxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTxtbox.Size = New System.Drawing.Size(399, 35)
        Me.PasswordTxtbox.TabIndex = 2
        '
        'UsernameTxtbox
        '
        Me.UsernameTxtbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.UsernameTxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsernameTxtbox.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTxtbox.ForeColor = System.Drawing.Color.White
        Me.UsernameTxtbox.Location = New System.Drawing.Point(58, 208)
        Me.UsernameTxtbox.Multiline = True
        Me.UsernameTxtbox.Name = "UsernameTxtbox"
        Me.UsernameTxtbox.Size = New System.Drawing.Size(399, 35)
        Me.UsernameTxtbox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Expense_Tracker.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(175, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 127)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(198, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login/Register"
        '
        'logExit
        '
        Me.logExit.FlatAppearance.BorderSize = 0
        Me.logExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logExit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logExit.ForeColor = System.Drawing.Color.Crimson
        Me.logExit.Location = New System.Drawing.Point(499, 0)
        Me.logExit.Name = "logExit"
        Me.logExit.Size = New System.Drawing.Size(119, 60)
        Me.logExit.TabIndex = 1
        Me.logExit.Text = "Exit"
        Me.logExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.logExit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 80)
        Me.Panel1.TabIndex = 0
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 536)
        Me.Controls.Add(Me.logpnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoginPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPage"
        Me.logpnl.ResumeLayout(False)
        Me.logpnl.PerformLayout()
        Me.regpnl.ResumeLayout(False)
        Me.regpnl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents logpnl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UsernameTxtbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTxtbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents regbtn As Button
    Friend WithEvents logbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents logExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents regpnl As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents regpasstxtbox As TextBox
    Friend WithEvents regunametxtbox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents regnametxtbox As TextBox
    Friend WithEvents register As Button
    Friend WithEvents loginnow As Button
End Class
