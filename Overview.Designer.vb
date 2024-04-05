<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Overview
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.overviewExitbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.expreset = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.exptotal = New System.Windows.Forms.Label()
        Me.expFilter = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EndDateexp = New System.Windows.Forms.DateTimePicker()
        Me.startDateexp = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.increset = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.incFilter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.endDateinc = New System.Windows.Forms.DateTimePicker()
        Me.startDateinc = New System.Windows.Forms.DateTimePicker()
        Me.inctotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.overviewExitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1120, 50)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(899, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete Entries"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "OverView"
        '
        'overviewExitbtn
        '
        Me.overviewExitbtn.FlatAppearance.BorderSize = 0
        Me.overviewExitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overviewExitbtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overviewExitbtn.ForeColor = System.Drawing.Color.Crimson
        Me.overviewExitbtn.Location = New System.Drawing.Point(1034, 1)
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
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 50)
        Me.TabControl1.Location = New System.Drawing.Point(0, 50)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(15, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1120, 546)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 54)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1112, 488)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Expenses"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1104, 363)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel2.Controls.Add(Me.expreset)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.exptotal)
        Me.Panel2.Controls.Add(Me.expFilter)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.EndDateexp)
        Me.Panel2.Controls.Add(Me.startDateexp)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1106, 108)
        Me.Panel2.TabIndex = 0
        '
        'expreset
        '
        Me.expreset.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expreset.FlatAppearance.BorderSize = 0
        Me.expreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expreset.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expreset.ForeColor = System.Drawing.Color.White
        Me.expreset.Location = New System.Drawing.Point(798, 30)
        Me.expreset.Name = "expreset"
        Me.expreset.Size = New System.Drawing.Size(95, 34)
        Me.expreset.TabIndex = 29
        Me.expreset.Text = "Reset"
        Me.expreset.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Fee", "Shopping", "Food", "Education", "Entertainment", "Transportation", "Saving,Investment", "Medical and Healthcare", "Utilities", "Housing", "Insurance"})
        Me.ComboBox1.Location = New System.Drawing.Point(60, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 31)
        Me.ComboBox1.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(363, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 23)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Filter By Date "
        '
        'exptotal
        '
        Me.exptotal.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exptotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.exptotal.Location = New System.Drawing.Point(942, 35)
        Me.exptotal.Name = "exptotal"
        Me.exptotal.Size = New System.Drawing.Size(159, 51)
        Me.exptotal.TabIndex = 20
        Me.exptotal.Text = "0.00"
        Me.exptotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'expFilter
        '
        Me.expFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expFilter.FlatAppearance.BorderSize = 0
        Me.expFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.expFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expFilter.ForeColor = System.Drawing.Color.White
        Me.expFilter.Location = New System.Drawing.Point(663, 30)
        Me.expFilter.Name = "expFilter"
        Me.expFilter.Size = New System.Drawing.Size(95, 34)
        Me.expFilter.TabIndex = 17
        Me.expFilter.Text = "Filter"
        Me.expFilter.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(560, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "To"
        '
        'EndDateexp
        '
        Me.EndDateexp.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateexp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndDateexp.Location = New System.Drawing.Point(515, 67)
        Me.EndDateexp.Name = "EndDateexp"
        Me.EndDateexp.Size = New System.Drawing.Size(122, 31)
        Me.EndDateexp.TabIndex = 15
        '
        'startDateexp
        '
        Me.startDateexp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateexp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.startDateexp.Location = New System.Drawing.Point(515, 7)
        Me.startDateexp.Name = "startDateexp"
        Me.startDateexp.Size = New System.Drawing.Size(122, 30)
        Me.startDateexp.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Search By Categories"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 54)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1112, 488)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Income"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 104)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1112, 381)
        Me.DataGridView2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel3.Controls.Add(Me.increset)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.incFilter)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.endDateinc)
        Me.Panel3.Controls.Add(Me.startDateinc)
        Me.Panel3.Controls.Add(Me.inctotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1106, 100)
        Me.Panel3.TabIndex = 0
        '
        'increset
        '
        Me.increset.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.increset.FlatAppearance.BorderSize = 0
        Me.increset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.increset.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.increset.ForeColor = System.Drawing.Color.White
        Me.increset.Location = New System.Drawing.Point(523, 29)
        Me.increset.Name = "increset"
        Me.increset.Size = New System.Drawing.Size(95, 34)
        Me.increset.TabIndex = 30
        Me.increset.Text = "Reset"
        Me.increset.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(86, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Filter By Date "
        '
        'incFilter
        '
        Me.incFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.incFilter.FlatAppearance.BorderSize = 0
        Me.incFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.incFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.incFilter.ForeColor = System.Drawing.Color.White
        Me.incFilter.Location = New System.Drawing.Point(406, 29)
        Me.incFilter.Name = "incFilter"
        Me.incFilter.Size = New System.Drawing.Size(95, 34)
        Me.incFilter.TabIndex = 25
        Me.incFilter.Text = "Filter"
        Me.incFilter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(311, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 23)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To"
        '
        'endDateinc
        '
        Me.endDateinc.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endDateinc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.endDateinc.Location = New System.Drawing.Point(266, 61)
        Me.endDateinc.Name = "endDateinc"
        Me.endDateinc.Size = New System.Drawing.Size(122, 31)
        Me.endDateinc.TabIndex = 23
        '
        'startDateinc
        '
        Me.startDateinc.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startDateinc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.startDateinc.Location = New System.Drawing.Point(266, 1)
        Me.startDateinc.Name = "startDateinc"
        Me.startDateinc.Size = New System.Drawing.Size(122, 30)
        Me.startDateinc.TabIndex = 22
        '
        'inctotal
        '
        Me.inctotal.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inctotal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.inctotal.Location = New System.Drawing.Point(944, 35)
        Me.inctotal.Name = "inctotal"
        Me.inctotal.Size = New System.Drawing.Size(159, 51)
        Me.inctotal.TabIndex = 21
        Me.inctotal.Text = "0.00"
        Me.inctotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Overview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1120, 596)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Overview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents overviewExitbtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents EndDateexp As DateTimePicker
    Friend WithEvents startDateexp As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents expFilter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents exptotal As Label
    Friend WithEvents inctotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents incFilter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents endDateinc As DateTimePicker
    Friend WithEvents startDateinc As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents expreset As Button
    Friend WithEvents increset As Button
    Friend WithEvents Button1 As Button
End Class
