<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddExpenses
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addExpensesExitbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.expfield = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.expremark = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.categoriescbox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.expaddbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.addExpensesExitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 50)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add Expenses"
        '
        'addExpensesExitbtn
        '
        Me.addExpensesExitbtn.FlatAppearance.BorderSize = 0
        Me.addExpensesExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addExpensesExitbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addExpensesExitbtn.ForeColor = System.Drawing.Color.Crimson
        Me.addExpensesExitbtn.Location = New System.Drawing.Point(354, 1)
        Me.addExpensesExitbtn.Name = "addExpensesExitbtn"
        Me.addExpensesExitbtn.Size = New System.Drawing.Size(86, 48)
        Me.addExpensesExitbtn.TabIndex = 2
        Me.addExpensesExitbtn.Text = "Exit"
        Me.addExpensesExitbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(207, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 2)
        Me.Label2.TabIndex = 20
        Me.Label2.UseMnemonic = False
        '
        'expfield
        '
        Me.expfield.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.expfield.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.expfield.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expfield.ForeColor = System.Drawing.Color.White
        Me.expfield.Location = New System.Drawing.Point(208, 114)
        Me.expfield.Name = "expfield"
        Me.expfield.Size = New System.Drawing.Size(218, 24)
        Me.expfield.TabIndex = 19
        Me.expfield.Text = "0.00"
        Me.expfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(21, 111)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 28)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 494)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 2)
        Me.Label5.TabIndex = 25
        Me.Label5.UseMnemonic = False
        '
        'expremark
        '
        Me.expremark.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.expremark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.expremark.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expremark.ForeColor = System.Drawing.Color.White
        Me.expremark.Location = New System.Drawing.Point(28, 452)
        Me.expremark.Multiline = True
        Me.expremark.Name = "expremark"
        Me.expremark.Size = New System.Drawing.Size(400, 39)
        Me.expremark.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 438)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 2)
        Me.Label4.TabIndex = 23
        Me.Label4.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Remark"
        '
        'categoriescbox
        '
        Me.categoriescbox.BackColor = System.Drawing.SystemColors.Window
        Me.categoriescbox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.categoriescbox.ForeColor = System.Drawing.Color.Black
        Me.categoriescbox.FormattingEnabled = True
        Me.categoriescbox.Items.AddRange(New Object() {"Fee", "Shopping", "Food"})
        Me.categoriescbox.Location = New System.Drawing.Point(209, 244)
        Me.categoriescbox.Name = "categoriescbox"
        Me.categoriescbox.Size = New System.Drawing.Size(217, 33)
        Me.categoriescbox.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 2)
        Me.Label6.TabIndex = 28
        Me.Label6.UseMnemonic = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(21, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 28)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Categories"
        '
        'expaddbtn
        '
        Me.expaddbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expaddbtn.FlatAppearance.BorderSize = 0
        Me.expaddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expaddbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expaddbtn.Location = New System.Drawing.Point(332, 511)
        Me.expaddbtn.Name = "expaddbtn"
        Me.expaddbtn.Size = New System.Drawing.Size(95, 34)
        Me.expaddbtn.TabIndex = 29
        Me.expaddbtn.Text = "Add"
        Me.expaddbtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(350, 2)
        Me.Label8.TabIndex = 31
        Me.Label8.UseMnemonic = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 28)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Add Categories"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(253, 333)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 34)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddExpenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 558)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.expaddbtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.categoriescbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.expremark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.expfield)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddExpenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddExpenses"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addExpensesExitbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents expfield As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents expremark As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents categoriescbox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents expaddbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
