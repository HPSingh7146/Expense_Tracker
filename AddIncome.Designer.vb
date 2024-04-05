<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddIncome
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
        Me.addIncomeExitbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.incaddbtn = New System.Windows.Forms.Button()
        Me.incfield = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addincremark = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.addIncomeExitbtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 47)
        Me.Panel1.TabIndex = 0
        '
        'addIncomeExitbtn
        '
        Me.addIncomeExitbtn.FlatAppearance.BorderSize = 0
        Me.addIncomeExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addIncomeExitbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addIncomeExitbtn.ForeColor = System.Drawing.Color.Crimson
        Me.addIncomeExitbtn.Location = New System.Drawing.Point(362, 1)
        Me.addIncomeExitbtn.Name = "addIncomeExitbtn"
        Me.addIncomeExitbtn.Size = New System.Drawing.Size(69, 48)
        Me.addIncomeExitbtn.TabIndex = 2
        Me.addIncomeExitbtn.Text = "Back"
        Me.addIncomeExitbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Income"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(12, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(86, 28)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Amount"
        '
        'incaddbtn
        '
        Me.incaddbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.incaddbtn.FlatAppearance.BorderSize = 0
        Me.incaddbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.incaddbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incaddbtn.Location = New System.Drawing.Point(322, 414)
        Me.incaddbtn.Name = "incaddbtn"
        Me.incaddbtn.Size = New System.Drawing.Size(95, 34)
        Me.incaddbtn.TabIndex = 15
        Me.incaddbtn.Text = "Add"
        Me.incaddbtn.UseVisualStyleBackColor = False
        '
        'incfield
        '
        Me.incfield.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.incfield.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.incfield.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incfield.ForeColor = System.Drawing.Color.White
        Me.incfield.Location = New System.Drawing.Point(199, 97)
        Me.incfield.Name = "incfield"
        Me.incfield.Size = New System.Drawing.Size(218, 24)
        Me.incfield.TabIndex = 16
        Me.incfield.Text = "0.00"
        Me.incfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(198, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 2)
        Me.Label2.TabIndex = 17
        Me.Label2.UseMnemonic = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Remark"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 2)
        Me.Label4.TabIndex = 19
        Me.Label4.UseMnemonic = False
        '
        'addincremark
        '
        Me.addincremark.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.addincremark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addincremark.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addincremark.ForeColor = System.Drawing.Color.White
        Me.addincremark.Location = New System.Drawing.Point(17, 336)
        Me.addincremark.Multiline = True
        Me.addincremark.Name = "addincremark"
        Me.addincremark.Size = New System.Drawing.Size(400, 41)
        Me.addincremark.TabIndex = 20
        Me.addincremark.Text = "Type here"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 380)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 2)
        Me.Label5.TabIndex = 21
        Me.Label5.UseMnemonic = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(225, 192)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 27)
        Me.DateTimePicker1.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(350, 2)
        Me.Label8.TabIndex = 34
        Me.Label8.UseMnemonic = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 28)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Date"
        '
        'AddIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(431, 466)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.addincremark)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.incfield)
        Me.Controls.Add(Me.incaddbtn)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddIncome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddIncome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents addIncomeExitbtn As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents incaddbtn As Button
    Friend WithEvents incfield As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents addincremark As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
