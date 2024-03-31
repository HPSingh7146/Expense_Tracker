<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.balanceLbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.totalIncLbl = New System.Windows.Forms.Label()
        Me.totalExpLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UsernameLbl = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.addexpbtn = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.addincbtn = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.seeAllbtn = New System.Windows.Forms.Button()
        Me.ExpenseTrackerDataSet = New Expense_Tracker.ExpenseTrackerDataSet()
        Me.ExpenseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpenseTableAdapter1 = New Expense_Tracker.ExpenseTrackerDataSetTableAdapters.expenseTableAdapter()
        Me.Db_Expense_TrackerDataSet = New Expense_Tracker.db_Expense_TrackerDataSet()
        Me.ExpenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpenseTableAdapter = New Expense_Tracker.db_Expense_TrackerDataSetTableAdapters.ExpenseTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ExpenseTrackerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpenseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ExpenseTrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_Expense_TrackerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseTrackerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 47)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Crimson
        Me.Button1.Location = New System.Drawing.Point(988, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 48)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expense Tracker"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel2.Controls.Add(Me.balanceLbl)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.totalIncLbl)
        Me.Panel2.Controls.Add(Me.totalExpLbl)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.UsernameLbl)
        Me.Panel2.Location = New System.Drawing.Point(8, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 251)
        Me.Panel2.TabIndex = 1
        '
        'balanceLbl
        '
        Me.balanceLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLbl.ForeColor = System.Drawing.Color.White
        Me.balanceLbl.Location = New System.Drawing.Point(354, 183)
        Me.balanceLbl.Name = "balanceLbl"
        Me.balanceLbl.Size = New System.Drawing.Size(133, 25)
        Me.balanceLbl.TabIndex = 8
        Me.balanceLbl.Text = "0.00"
        Me.balanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(198, 162)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(306, 1)
        Me.Label8.TabIndex = 7
        Me.Label8.UseMnemonic = False
        '
        'totalIncLbl
        '
        Me.totalIncLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalIncLbl.ForeColor = System.Drawing.Color.White
        Me.totalIncLbl.Location = New System.Drawing.Point(351, 68)
        Me.totalIncLbl.Name = "totalIncLbl"
        Me.totalIncLbl.Size = New System.Drawing.Size(133, 25)
        Me.totalIncLbl.TabIndex = 6
        Me.totalIncLbl.Text = "0.00"
        Me.totalIncLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalExpLbl
        '
        Me.totalExpLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalExpLbl.ForeColor = System.Drawing.Color.White
        Me.totalExpLbl.Location = New System.Drawing.Point(354, 111)
        Me.totalExpLbl.Name = "totalExpLbl"
        Me.totalExpLbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.totalExpLbl.Size = New System.Drawing.Size(133, 25)
        Me.totalExpLbl.TabIndex = 5
        Me.totalExpLbl.Text = "0.00"
        Me.totalExpLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(194, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Balance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Expenses"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 1)
        Me.Label2.TabIndex = 1
        Me.Label2.UseMnemonic = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Income"
        '
        'UsernameLbl
        '
        Me.UsernameLbl.AutoSize = True
        Me.UsernameLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLbl.ForeColor = System.Drawing.Color.White
        Me.UsernameLbl.Location = New System.Drawing.Point(13, 13)
        Me.UsernameLbl.Name = "UsernameLbl"
        Me.UsernameLbl.Size = New System.Drawing.Size(187, 28)
        Me.UsernameLbl.TabIndex = 0
        Me.UsernameLbl.Text = "Harsh Pratap Singh"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Panel5.Controls.Add(Me.addexpbtn)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.addincbtn)
        Me.Panel5.Controls.Add(Me.Label24)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Location = New System.Drawing.Point(546, 72)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(516, 251)
        Me.Panel5.TabIndex = 13
        '
        'addexpbtn
        '
        Me.addexpbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addexpbtn.FlatAppearance.BorderSize = 0
        Me.addexpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addexpbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addexpbtn.ForeColor = System.Drawing.Color.White
        Me.addexpbtn.Location = New System.Drawing.Point(214, 184)
        Me.addexpbtn.Name = "addexpbtn"
        Me.addexpbtn.Size = New System.Drawing.Size(95, 34)
        Me.addexpbtn.TabIndex = 14
        Me.addexpbtn.Text = "Add"
        Me.addexpbtn.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(205, 227)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(306, 1)
        Me.Label20.TabIndex = 13
        Me.Label20.UseMnemonic = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(359, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(139, 28)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Add Expenses"
        '
        'addincbtn
        '
        Me.addincbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addincbtn.FlatAppearance.BorderSize = 0
        Me.addincbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addincbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addincbtn.ForeColor = System.Drawing.Color.White
        Me.addincbtn.Location = New System.Drawing.Point(214, 64)
        Me.addincbtn.Name = "addincbtn"
        Me.addincbtn.Size = New System.Drawing.Size(95, 34)
        Me.addincbtn.TabIndex = 11
        Me.addincbtn.Text = "Add"
        Me.addincbtn.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(3, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(306, 1)
        Me.Label24.TabIndex = 2
        Me.Label24.UseMnemonic = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(20, 72)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(123, 28)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Add Income"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 28)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Recent Expenses"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 1.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 374)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 1)
        Me.Label7.TabIndex = 16
        Me.Label7.UseMnemonic = False
        '
        'seeAllbtn
        '
        Me.seeAllbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.seeAllbtn.FlatAppearance.BorderSize = 0
        Me.seeAllbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seeAllbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seeAllbtn.ForeColor = System.Drawing.Color.White
        Me.seeAllbtn.Location = New System.Drawing.Point(964, 345)
        Me.seeAllbtn.Name = "seeAllbtn"
        Me.seeAllbtn.Size = New System.Drawing.Size(93, 30)
        Me.seeAllbtn.TabIndex = 17
        Me.seeAllbtn.Text = "See All"
        Me.seeAllbtn.UseVisualStyleBackColor = False
        '
        'ExpenseTrackerDataSet
        '
        Me.ExpenseTrackerDataSet.DataSetName = "ExpenseTrackerDataSet"
        Me.ExpenseTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpenseBindingSource1
        '
        Me.ExpenseBindingSource1.DataMember = "expense"
        Me.ExpenseBindingSource1.DataSource = Me.ExpenseTrackerDataSet
        '
        'ExpenseTableAdapter1
        '
        Me.ExpenseTableAdapter1.ClearBeforeFill = True
        '
        'Db_Expense_TrackerDataSet
        '
        Me.Db_Expense_TrackerDataSet.DataSetName = "db_Expense_TrackerDataSet"
        Me.Db_Expense_TrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpenseBindingSource
        '
        Me.ExpenseBindingSource.DataMember = "Expense"
        Me.ExpenseBindingSource.DataSource = Me.Db_Expense_TrackerDataSet
        '
        'ExpenseTableAdapter
        '
        Me.ExpenseTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 385)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(1045, 247)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(1045, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1045, 247)
        Me.DataGridView1.TabIndex = 15
        '
        'ExpenseTrackerDataSetBindingSource
        '
        Me.ExpenseTrackerDataSetBindingSource.DataSource = Me.ExpenseTrackerDataSet
        Me.ExpenseTrackerDataSetBindingSource.Position = 0
        '
        'ExpenseBindingSource2
        '
        Me.ExpenseBindingSource2.DataMember = "expense"
        Me.ExpenseBindingSource2.DataSource = Me.ExpenseTrackerDataSetBindingSource
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1074, 644)
        Me.Controls.Add(Me.seeAllbtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.ExpenseTrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_Expense_TrackerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseTrackerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UsernameLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents balanceLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents totalIncLbl As Label
    Friend WithEvents totalExpLbl As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents addincbtn As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents addexpbtn As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents seeAllbtn As Button
    Friend WithEvents Db_Expense_TrackerDataSet As db_Expense_TrackerDataSet
    Friend WithEvents ExpenseBindingSource As BindingSource
    Friend WithEvents ExpenseTableAdapter As db_Expense_TrackerDataSetTableAdapters.ExpenseTableAdapter
    Friend WithEvents ExpenseTrackerDataSet As ExpenseTrackerDataSet
    Friend WithEvents ExpenseBindingSource1 As BindingSource
    Friend WithEvents ExpenseTableAdapter1 As ExpenseTrackerDataSetTableAdapters.expenseTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ExpenseBindingSource2 As BindingSource
    Friend WithEvents ExpenseTrackerDataSetBindingSource As BindingSource
End Class
