<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete_Entries
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.overviewExitbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeleteExp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExpId = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DeleteInc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IncId = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.overviewExitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 50)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Delete Entries"
        '
        'overviewExitbtn
        '
        Me.overviewExitbtn.FlatAppearance.BorderSize = 0
        Me.overviewExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overviewExitbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overviewExitbtn.ForeColor = System.Drawing.Color.Crimson
        Me.overviewExitbtn.Location = New System.Drawing.Point(365, 1)
        Me.overviewExitbtn.Name = "overviewExitbtn"
        Me.overviewExitbtn.Size = New System.Drawing.Size(86, 48)
        Me.overviewExitbtn.TabIndex = 2
        Me.overviewExitbtn.Text = "Exit"
        Me.overviewExitbtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(445, 230)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.DeleteExp)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.ExpId)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(437, 194)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Expense"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(110, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 2)
        Me.Label7.TabIndex = 21
        Me.Label7.UseMnemonic = False
        '
        'DeleteExp
        '
        Me.DeleteExp.BackColor = System.Drawing.Color.Red
        Me.DeleteExp.FlatAppearance.BorderSize = 0
        Me.DeleteExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteExp.Location = New System.Drawing.Point(327, 156)
        Me.DeleteExp.Name = "DeleteExp"
        Me.DeleteExp.Size = New System.Drawing.Size(102, 30)
        Me.DeleteExp.TabIndex = 11
        Me.DeleteExp.Text = "Delete"
        Me.DeleteExp.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 28)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Id :"
        '
        'ExpId
        '
        Me.ExpId.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ExpId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExpId.ForeColor = System.Drawing.Color.White
        Me.ExpId.Location = New System.Drawing.Point(114, 113)
        Me.ExpId.Name = "ExpId"
        Me.ExpId.Size = New System.Drawing.Size(100, 23)
        Me.ExpId.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(413, 2)
        Me.Label8.TabIndex = 8
        Me.Label8.UseMnemonic = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Enter the ID of Expense You Want to Delete"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.DeleteInc)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.IncId)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(437, 194)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Income"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 2)
        Me.Label9.TabIndex = 22
        Me.Label9.UseMnemonic = False
        '
        'DeleteInc
        '
        Me.DeleteInc.BackColor = System.Drawing.Color.Red
        Me.DeleteInc.FlatAppearance.BorderSize = 0
        Me.DeleteInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteInc.Location = New System.Drawing.Point(327, 156)
        Me.DeleteInc.Name = "DeleteInc"
        Me.DeleteInc.Size = New System.Drawing.Size(102, 30)
        Me.DeleteInc.TabIndex = 16
        Me.DeleteInc.Text = "Delete"
        Me.DeleteInc.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Id :"
        '
        'IncId
        '
        Me.IncId.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.IncId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IncId.ForeColor = System.Drawing.Color.White
        Me.IncId.Location = New System.Drawing.Point(113, 113)
        Me.IncId.Name = "IncId"
        Me.IncId.Size = New System.Drawing.Size(100, 23)
        Me.IncId.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(413, 2)
        Me.Label5.TabIndex = 13
        Me.Label5.UseMnemonic = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(365, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Enter the ID of Income You Want to Delete"
        '
        'Delete_Entries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(445, 280)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Delete_Entries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete_Entries"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents overviewExitbtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents DeleteExp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ExpId As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DeleteInc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents IncId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
End Class
