<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager_Use
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DateTime_lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTime_timer = New System.Windows.Forms.Timer(Me.components)
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.ManagerWorks_TC = New System.Windows.Forms.TabControl()
        Me.StaffAccount_TP = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AccountList_DGV = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FosdatabaseDataSet = New Workshop_InProgress.fosdatabaseDataSet()
        Me.Account_TC = New System.Windows.Forms.TabControl()
        Me.AddAccount_TP = New System.Windows.Forms.TabPage()
        Me.ShowHidePassword_CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Wrong_lbl = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Retype_txtbox = New System.Windows.Forms.TextBox()
        Me.ShowHidePassword_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FullName_txtbox = New System.Windows.Forms.TextBox()
        Me.Username_txtbox = New System.Windows.Forms.TextBox()
        Me.Password_txtbox = New System.Windows.Forms.TextBox()
        Me.ClearAccount_btn = New System.Windows.Forms.Button()
        Me.UserTypeLvl_CB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CreateAccount_btn = New System.Windows.Forms.Button()
        Me.UpdateDeleteAccount_TP = New System.Windows.Forms.TabPage()
        Me.ShowHidePasssword_CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Wrong_lbl1 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Retype_txtbox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ShowHidePasssword_CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Password_txtbox2 = New System.Windows.Forms.TextBox()
        Me.UserTypeLvl_txtbox2 = New System.Windows.Forms.TextBox()
        Me.FullName_txtbox2 = New System.Windows.Forms.TextBox()
        Me.Username_txtbox2 = New System.Windows.Forms.TextBox()
        Me.SearchAccount_txtbox = New System.Windows.Forms.TextBox()
        Me.SearchAccount_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeleteAccount_btn = New System.Windows.Forms.Button()
        Me.UpdateAccount_btn = New System.Windows.Forms.Button()
        Me.RestaurantMenu_TP = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchFood_btn = New System.Windows.Forms.Button()
        Me.SearchFood_txtbox = New System.Windows.Forms.TextBox()
        Me.Food_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SearchDrink_btn = New System.Windows.Forms.Button()
        Me.SearchDrink_txtbox = New System.Windows.Forms.TextBox()
        Me.Drink_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SearchDessert_btn = New System.Windows.Forms.Button()
        Me.SearchDessert_txtbox = New System.Windows.Forms.TextBox()
        Me.Dessert_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UpdateProduct_btn = New System.Windows.Forms.Button()
        Me.AddProduct_btn = New System.Windows.Forms.Button()
        Me.DeleteProduct_btn = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductStatus_CB = New System.Windows.Forms.ComboBox()
        Me.UnitPrice_txtbox = New System.Windows.Forms.TextBox()
        Me.ProductName_txtbox = New System.Windows.Forms.TextBox()
        Me.ProductID_txtbox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ClearProduct_btn = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.RestaurantTableInfo_TP = New System.Windows.Forms.TabPage()
        Me.SearchTable_txtbox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.SearchTable_btn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableStatus_CB = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Capacity_txtbox = New System.Windows.Forms.TextBox()
        Me.TableNo_txtbox = New System.Windows.Forms.TextBox()
        Me.ClearTable_btn = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TableDetail_DGV = New System.Windows.Forms.DataGridView()
        Me.TableIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeleteTable_btn = New System.Windows.Forms.Button()
        Me.AddTable_btn = New System.Windows.Forms.Button()
        Me.UpdateTable_btn = New System.Windows.Forms.Button()
        Me.DailyReport_TP = New System.Windows.Forms.TabPage()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MenuName_txtbox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DailySales_btn = New System.Windows.Forms.Button()
        Me.TotalAmount_txtbox = New System.Windows.Forms.TextBox()
        Me.TotalQuantity_txtbox = New System.Windows.Forms.TextBox()
        Me.TotalAmount_lbl = New System.Windows.Forms.Label()
        Me.BestSellingMenuTitle = New System.Windows.Forms.Label()
        Me.BestSelling_C = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TotalQuantity_lbl = New System.Windows.Forms.Label()
        Me.PopularMenuID_txtbox = New System.Windows.Forms.TextBox()
        Me.PopularMenuID_lbl = New System.Windows.Forms.Label()
        Me.BestSellingMenuDetail_DGV = New System.Windows.Forms.DataGridView()
        Me.Calender_DTP = New System.Windows.Forms.DateTimePicker()
        Me.ReportInformation_S = New System.Windows.Forms.Splitter()
        Me.Welcome_lbl = New System.Windows.Forms.Label()
        Me.Product_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.tableTableAdapter()
        Me.MenuTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter()
        Me.DSR_TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.StaffTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.staffTableAdapter()
        Me.ManagerWorks_TC.SuspendLayout()
        Me.StaffAccount_TP.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AccountList_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Account_TC.SuspendLayout()
        Me.AddAccount_TP.SuspendLayout()
        Me.UpdateDeleteAccount_TP.SuspendLayout()
        Me.RestaurantMenu_TP.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.RestaurantTableInfo_TP.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TableDetail_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DailyReport_TP.SuspendLayout()
        CType(Me.BestSelling_C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BestSellingMenuDetail_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTime_lbl
        '
        Me.DateTime_lbl.AutoSize = True
        Me.DateTime_lbl.BackColor = System.Drawing.Color.Transparent
        Me.DateTime_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_lbl.ForeColor = System.Drawing.Color.Lime
        Me.DateTime_lbl.Location = New System.Drawing.Point(1211, 713)
        Me.DateTime_lbl.Name = "DateTime_lbl"
        Me.DateTime_lbl.Size = New System.Drawing.Size(97, 16)
        Me.DateTime_lbl.TabIndex = 2
        Me.DateTime_lbl.Text = "DATE , TIME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(3, 713)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FOS version 10.1.4"
        '
        'DateTime_timer
        '
        '
        'LogOut_btn
        '
        Me.LogOut_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_btn.Location = New System.Drawing.Point(1224, 668)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Size = New System.Drawing.Size(114, 33)
        Me.LogOut_btn.TabIndex = 4
        Me.LogOut_btn.Text = "Log Out"
        Me.LogOut_btn.UseVisualStyleBackColor = False
        '
        'ManagerWorks_TC
        '
        Me.ManagerWorks_TC.Controls.Add(Me.StaffAccount_TP)
        Me.ManagerWorks_TC.Controls.Add(Me.RestaurantMenu_TP)
        Me.ManagerWorks_TC.Controls.Add(Me.RestaurantTableInfo_TP)
        Me.ManagerWorks_TC.Controls.Add(Me.DailyReport_TP)
        Me.ManagerWorks_TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManagerWorks_TC.Location = New System.Drawing.Point(12, 12)
        Me.ManagerWorks_TC.Name = "ManagerWorks_TC"
        Me.ManagerWorks_TC.SelectedIndex = 0
        Me.ManagerWorks_TC.Size = New System.Drawing.Size(1326, 652)
        Me.ManagerWorks_TC.TabIndex = 5
        '
        'StaffAccount_TP
        '
        Me.StaffAccount_TP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.StaffAccount_TP.Controls.Add(Me.GroupBox1)
        Me.StaffAccount_TP.Controls.Add(Me.Account_TC)
        Me.StaffAccount_TP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffAccount_TP.Location = New System.Drawing.Point(4, 29)
        Me.StaffAccount_TP.Name = "StaffAccount_TP"
        Me.StaffAccount_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.StaffAccount_TP.Size = New System.Drawing.Size(1318, 619)
        Me.StaffAccount_TP.TabIndex = 1
        Me.StaffAccount_TP.Text = "Staff Account"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.AccountList_DGV)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(594, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 584)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Staff Login Account"
        '
        'AccountList_DGV
        '
        Me.AccountList_DGV.AllowUserToAddRows = False
        Me.AccountList_DGV.AllowUserToDeleteRows = False
        Me.AccountList_DGV.AllowUserToOrderColumns = True
        Me.AccountList_DGV.AutoGenerateColumns = False
        Me.AccountList_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.AccountList_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccountList_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.StaffPositionDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.AccountList_DGV.DataSource = Me.StaffBindingSource
        Me.AccountList_DGV.Location = New System.Drawing.Point(16, 34)
        Me.AccountList_DGV.MultiSelect = False
        Me.AccountList_DGV.Name = "AccountList_DGV"
        Me.AccountList_DGV.ReadOnly = True
        Me.AccountList_DGV.RowHeadersVisible = False
        Me.AccountList_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AccountList_DGV.Size = New System.Drawing.Size(692, 540)
        Me.AccountList_DGV.TabIndex = 0
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Width = 155
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffNameDataGridViewTextBoxColumn.Width = 303
        '
        'StaffPositionDataGridViewTextBoxColumn
        '
        Me.StaffPositionDataGridViewTextBoxColumn.DataPropertyName = "Staff_Position"
        Me.StaffPositionDataGridViewTextBoxColumn.HeaderText = "Staff Position"
        Me.StaffPositionDataGridViewTextBoxColumn.Name = "StaffPositionDataGridViewTextBoxColumn"
        Me.StaffPositionDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffPositionDataGridViewTextBoxColumn.Width = 230
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "staff"
        Me.StaffBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'FosdatabaseDataSet
        '
        Me.FosdatabaseDataSet.DataSetName = "fosdatabaseDataSet"
        Me.FosdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Account_TC
        '
        Me.Account_TC.Controls.Add(Me.AddAccount_TP)
        Me.Account_TC.Controls.Add(Me.UpdateDeleteAccount_TP)
        Me.Account_TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Account_TC.Location = New System.Drawing.Point(6, 21)
        Me.Account_TC.Name = "Account_TC"
        Me.Account_TC.SelectedIndex = 0
        Me.Account_TC.Size = New System.Drawing.Size(564, 584)
        Me.Account_TC.TabIndex = 30
        '
        'AddAccount_TP
        '
        Me.AddAccount_TP.BackColor = System.Drawing.Color.Honeydew
        Me.AddAccount_TP.Controls.Add(Me.ShowHidePassword_CheckBox1)
        Me.AddAccount_TP.Controls.Add(Me.Wrong_lbl)
        Me.AddAccount_TP.Controls.Add(Me.Label32)
        Me.AddAccount_TP.Controls.Add(Me.Retype_txtbox)
        Me.AddAccount_TP.Controls.Add(Me.ShowHidePassword_CheckBox)
        Me.AddAccount_TP.Controls.Add(Me.Label12)
        Me.AddAccount_TP.Controls.Add(Me.Label11)
        Me.AddAccount_TP.Controls.Add(Me.Label10)
        Me.AddAccount_TP.Controls.Add(Me.Label9)
        Me.AddAccount_TP.Controls.Add(Me.Label8)
        Me.AddAccount_TP.Controls.Add(Me.Label3)
        Me.AddAccount_TP.Controls.Add(Me.FullName_txtbox)
        Me.AddAccount_TP.Controls.Add(Me.Username_txtbox)
        Me.AddAccount_TP.Controls.Add(Me.Password_txtbox)
        Me.AddAccount_TP.Controls.Add(Me.ClearAccount_btn)
        Me.AddAccount_TP.Controls.Add(Me.UserTypeLvl_CB)
        Me.AddAccount_TP.Controls.Add(Me.Label4)
        Me.AddAccount_TP.Controls.Add(Me.Label5)
        Me.AddAccount_TP.Controls.Add(Me.CreateAccount_btn)
        Me.AddAccount_TP.Location = New System.Drawing.Point(4, 29)
        Me.AddAccount_TP.Name = "AddAccount_TP"
        Me.AddAccount_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.AddAccount_TP.Size = New System.Drawing.Size(556, 551)
        Me.AddAccount_TP.TabIndex = 0
        Me.AddAccount_TP.Text = "Add a Staff Login Account"
        '
        'ShowHidePassword_CheckBox1
        '
        Me.ShowHidePassword_CheckBox1.AutoSize = True
        Me.ShowHidePassword_CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHidePassword_CheckBox1.Location = New System.Drawing.Point(164, 409)
        Me.ShowHidePassword_CheckBox1.Name = "ShowHidePassword_CheckBox1"
        Me.ShowHidePassword_CheckBox1.Size = New System.Drawing.Size(155, 20)
        Me.ShowHidePassword_CheckBox1.TabIndex = 40
        Me.ShowHidePassword_CheckBox1.Text = "Show/Hide password"
        Me.ShowHidePassword_CheckBox1.UseVisualStyleBackColor = True
        '
        'Wrong_lbl
        '
        Me.Wrong_lbl.AutoSize = True
        Me.Wrong_lbl.ForeColor = System.Drawing.Color.Red
        Me.Wrong_lbl.Location = New System.Drawing.Point(514, 380)
        Me.Wrong_lbl.Name = "Wrong_lbl"
        Me.Wrong_lbl.Size = New System.Drawing.Size(20, 20)
        Me.Wrong_lbl.TabIndex = 39
        Me.Wrong_lbl.Text = "X"
        Me.Wrong_lbl.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(27, 381)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(133, 18)
        Me.Label32.TabIndex = 38
        Me.Label32.Text = "Retype Password :"
        '
        'Retype_txtbox
        '
        Me.Retype_txtbox.Location = New System.Drawing.Point(164, 377)
        Me.Retype_txtbox.Name = "Retype_txtbox"
        Me.Retype_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Retype_txtbox.Size = New System.Drawing.Size(347, 26)
        Me.Retype_txtbox.TabIndex = 37
        '
        'ShowHidePassword_CheckBox
        '
        Me.ShowHidePassword_CheckBox.AutoSize = True
        Me.ShowHidePassword_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHidePassword_CheckBox.Location = New System.Drawing.Point(164, 341)
        Me.ShowHidePassword_CheckBox.Name = "ShowHidePassword_CheckBox"
        Me.ShowHidePassword_CheckBox.Size = New System.Drawing.Size(155, 20)
        Me.ShowHidePassword_CheckBox.TabIndex = 36
        Me.ShowHidePassword_CheckBox.Text = "Show/Hide password"
        Me.ShowHidePassword_CheckBox.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(364, 20)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Information for create a Staff Login Account"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(161, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(350, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "*Please enter the Staff 's Name as shown in their IC."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 273)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Password             :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 18)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Staff ID                  :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Staff Position        :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Staff Name            :"
        '
        'FullName_txtbox
        '
        Me.FullName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_txtbox.Location = New System.Drawing.Point(164, 115)
        Me.FullName_txtbox.Name = "FullName_txtbox"
        Me.FullName_txtbox.Size = New System.Drawing.Size(348, 24)
        Me.FullName_txtbox.TabIndex = 29
        '
        'Username_txtbox
        '
        Me.Username_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txtbox.Location = New System.Drawing.Point(164, 185)
        Me.Username_txtbox.MaxLength = 6
        Me.Username_txtbox.Name = "Username_txtbox"
        Me.Username_txtbox.Size = New System.Drawing.Size(348, 24)
        Me.Username_txtbox.TabIndex = 22
        '
        'Password_txtbox
        '
        Me.Password_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtbox.Location = New System.Drawing.Point(164, 273)
        Me.Password_txtbox.Name = "Password_txtbox"
        Me.Password_txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_txtbox.Size = New System.Drawing.Size(348, 24)
        Me.Password_txtbox.TabIndex = 23
        '
        'ClearAccount_btn
        '
        Me.ClearAccount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAccount_btn.Location = New System.Drawing.Point(417, 486)
        Me.ClearAccount_btn.Name = "ClearAccount_btn"
        Me.ClearAccount_btn.Size = New System.Drawing.Size(114, 39)
        Me.ClearAccount_btn.TabIndex = 27
        Me.ClearAccount_btn.Text = "Clear"
        Me.ClearAccount_btn.UseVisualStyleBackColor = True
        '
        'UserTypeLvl_CB
        '
        Me.UserTypeLvl_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.UserTypeLvl_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeLvl_CB.FormattingEnabled = True
        Me.UserTypeLvl_CB.Items.AddRange(New Object() {"Manager", "Waiter", "Kitchen", "Cashier"})
        Me.UserTypeLvl_CB.Location = New System.Drawing.Point(164, 65)
        Me.UserTypeLvl_CB.Name = "UserTypeLvl_CB"
        Me.UserTypeLvl_CB.Size = New System.Drawing.Size(348, 26)
        Me.UserTypeLvl_CB.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(161, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 36)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "*Please enter his/her Staff ID number as their username." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Note: Username cannot" & _
    " be repeated.)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(161, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 36)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "*Please enter a password for the new user." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (Note: Password can be repeated.)"
        '
        'CreateAccount_btn
        '
        Me.CreateAccount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccount_btn.Location = New System.Drawing.Point(22, 486)
        Me.CreateAccount_btn.Name = "CreateAccount_btn"
        Me.CreateAccount_btn.Size = New System.Drawing.Size(114, 39)
        Me.CreateAccount_btn.TabIndex = 24
        Me.CreateAccount_btn.Text = "Create"
        Me.CreateAccount_btn.UseVisualStyleBackColor = True
        '
        'UpdateDeleteAccount_TP
        '
        Me.UpdateDeleteAccount_TP.BackColor = System.Drawing.Color.Honeydew
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.ShowHidePasssword_CheckBox3)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Wrong_lbl1)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label34)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Retype_txtbox1)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label23)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label27)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label28)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label29)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label30)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.ShowHidePasssword_CheckBox2)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label13)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Password_txtbox2)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.UserTypeLvl_txtbox2)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.FullName_txtbox2)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Username_txtbox2)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.SearchAccount_txtbox)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.SearchAccount_btn)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.Label6)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.DeleteAccount_btn)
        Me.UpdateDeleteAccount_TP.Controls.Add(Me.UpdateAccount_btn)
        Me.UpdateDeleteAccount_TP.Location = New System.Drawing.Point(4, 29)
        Me.UpdateDeleteAccount_TP.Name = "UpdateDeleteAccount_TP"
        Me.UpdateDeleteAccount_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.UpdateDeleteAccount_TP.Size = New System.Drawing.Size(556, 551)
        Me.UpdateDeleteAccount_TP.TabIndex = 1
        Me.UpdateDeleteAccount_TP.Text = "Update/Delete a Staff Login Account"
        '
        'ShowHidePasssword_CheckBox3
        '
        Me.ShowHidePasssword_CheckBox3.AutoSize = True
        Me.ShowHidePasssword_CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHidePasssword_CheckBox3.Location = New System.Drawing.Point(157, 337)
        Me.ShowHidePasssword_CheckBox3.Name = "ShowHidePasssword_CheckBox3"
        Me.ShowHidePasssword_CheckBox3.Size = New System.Drawing.Size(155, 20)
        Me.ShowHidePasssword_CheckBox3.TabIndex = 57
        Me.ShowHidePasssword_CheckBox3.Text = "Show/Hide password"
        Me.ShowHidePasssword_CheckBox3.UseVisualStyleBackColor = True
        '
        'Wrong_lbl1
        '
        Me.Wrong_lbl1.AutoSize = True
        Me.Wrong_lbl1.ForeColor = System.Drawing.Color.Red
        Me.Wrong_lbl1.Location = New System.Drawing.Point(524, 308)
        Me.Wrong_lbl1.Name = "Wrong_lbl1"
        Me.Wrong_lbl1.Size = New System.Drawing.Size(20, 20)
        Me.Wrong_lbl1.TabIndex = 56
        Me.Wrong_lbl1.Text = "X"
        Me.Wrong_lbl1.Visible = False
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(20, 309)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(133, 18)
        Me.Label34.TabIndex = 55
        Me.Label34.Text = "Retype Password :"
        '
        'Retype_txtbox1
        '
        Me.Retype_txtbox1.Location = New System.Drawing.Point(157, 305)
        Me.Retype_txtbox1.Name = "Retype_txtbox1"
        Me.Retype_txtbox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Retype_txtbox1.Size = New System.Drawing.Size(365, 26)
        Me.Retype_txtbox1.TabIndex = 54
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(345, 589)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 18)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Account Status     :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(20, 245)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(131, 18)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Password             :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(19, 209)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(132, 18)
        Me.Label28.TabIndex = 51
        Me.Label28.Text = "Staff ID                  :"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(20, 136)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(132, 18)
        Me.Label29.TabIndex = 50
        Me.Label29.Text = "Staff Position        :"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(19, 172)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(134, 18)
        Me.Label30.TabIndex = 49
        Me.Label30.Text = "Staff Name            :"
        '
        'ShowHidePasssword_CheckBox2
        '
        Me.ShowHidePasssword_CheckBox2.AutoSize = True
        Me.ShowHidePasssword_CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowHidePasssword_CheckBox2.Location = New System.Drawing.Point(158, 277)
        Me.ShowHidePasssword_CheckBox2.Name = "ShowHidePasssword_CheckBox2"
        Me.ShowHidePasssword_CheckBox2.Size = New System.Drawing.Size(154, 20)
        Me.ShowHidePasssword_CheckBox2.TabIndex = 48
        Me.ShowHidePasssword_CheckBox2.Text = "Show/Hide Character"
        Me.ShowHidePasssword_CheckBox2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(19, 400)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(484, 20)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Note : You are not allowed to modify the Staff Position and Staff ID."
        '
        'Password_txtbox2
        '
        Me.Password_txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password_txtbox2.Location = New System.Drawing.Point(158, 245)
        Me.Password_txtbox2.Name = "Password_txtbox2"
        Me.Password_txtbox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password_txtbox2.Size = New System.Drawing.Size(364, 26)
        Me.Password_txtbox2.TabIndex = 46
        '
        'UserTypeLvl_txtbox2
        '
        Me.UserTypeLvl_txtbox2.BackColor = System.Drawing.Color.White
        Me.UserTypeLvl_txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserTypeLvl_txtbox2.ForeColor = System.Drawing.Color.DarkGray
        Me.UserTypeLvl_txtbox2.Location = New System.Drawing.Point(158, 136)
        Me.UserTypeLvl_txtbox2.Name = "UserTypeLvl_txtbox2"
        Me.UserTypeLvl_txtbox2.ReadOnly = True
        Me.UserTypeLvl_txtbox2.Size = New System.Drawing.Size(364, 26)
        Me.UserTypeLvl_txtbox2.TabIndex = 41
        '
        'FullName_txtbox2
        '
        Me.FullName_txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullName_txtbox2.Location = New System.Drawing.Point(158, 172)
        Me.FullName_txtbox2.Name = "FullName_txtbox2"
        Me.FullName_txtbox2.Size = New System.Drawing.Size(364, 26)
        Me.FullName_txtbox2.TabIndex = 37
        '
        'Username_txtbox2
        '
        Me.Username_txtbox2.BackColor = System.Drawing.Color.White
        Me.Username_txtbox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username_txtbox2.ForeColor = System.Drawing.Color.DarkGray
        Me.Username_txtbox2.Location = New System.Drawing.Point(158, 209)
        Me.Username_txtbox2.Name = "Username_txtbox2"
        Me.Username_txtbox2.ReadOnly = True
        Me.Username_txtbox2.Size = New System.Drawing.Size(364, 26)
        Me.Username_txtbox2.TabIndex = 38
        '
        'SearchAccount_txtbox
        '
        Me.SearchAccount_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchAccount_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchAccount_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchAccount_txtbox.Location = New System.Drawing.Point(22, 37)
        Me.SearchAccount_txtbox.Name = "SearchAccount_txtbox"
        Me.SearchAccount_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchAccount_txtbox.Size = New System.Drawing.Size(389, 26)
        Me.SearchAccount_txtbox.TabIndex = 20
        '
        'SearchAccount_btn
        '
        Me.SearchAccount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.SearchAccount_btn.Location = New System.Drawing.Point(417, 29)
        Me.SearchAccount_btn.Name = "SearchAccount_btn"
        Me.SearchAccount_btn.Size = New System.Drawing.Size(114, 39)
        Me.SearchAccount_btn.TabIndex = 19
        Me.SearchAccount_btn.Text = "Search"
        Me.SearchAccount_btn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(23, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 18)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Search your data by using Staff ID."
        '
        'DeleteAccount_btn
        '
        Me.DeleteAccount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DeleteAccount_btn.Location = New System.Drawing.Point(417, 486)
        Me.DeleteAccount_btn.Name = "DeleteAccount_btn"
        Me.DeleteAccount_btn.Size = New System.Drawing.Size(114, 39)
        Me.DeleteAccount_btn.TabIndex = 16
        Me.DeleteAccount_btn.Text = "Delete"
        Me.DeleteAccount_btn.UseVisualStyleBackColor = True
        '
        'UpdateAccount_btn
        '
        Me.UpdateAccount_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.UpdateAccount_btn.Location = New System.Drawing.Point(22, 486)
        Me.UpdateAccount_btn.Name = "UpdateAccount_btn"
        Me.UpdateAccount_btn.Size = New System.Drawing.Size(114, 39)
        Me.UpdateAccount_btn.TabIndex = 15
        Me.UpdateAccount_btn.Text = "Update"
        Me.UpdateAccount_btn.UseVisualStyleBackColor = True
        '
        'RestaurantMenu_TP
        '
        Me.RestaurantMenu_TP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.RestaurantMenu_TP.Controls.Add(Me.TabControl2)
        Me.RestaurantMenu_TP.Controls.Add(Me.UpdateProduct_btn)
        Me.RestaurantMenu_TP.Controls.Add(Me.AddProduct_btn)
        Me.RestaurantMenu_TP.Controls.Add(Me.DeleteProduct_btn)
        Me.RestaurantMenu_TP.Controls.Add(Me.Label18)
        Me.RestaurantMenu_TP.Controls.Add(Me.GroupBox2)
        Me.RestaurantMenu_TP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestaurantMenu_TP.Location = New System.Drawing.Point(4, 29)
        Me.RestaurantMenu_TP.Name = "RestaurantMenu_TP"
        Me.RestaurantMenu_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.RestaurantMenu_TP.Size = New System.Drawing.Size(1318, 619)
        Me.RestaurantMenu_TP.TabIndex = 5
        Me.RestaurantMenu_TP.Text = "Restaurant Menu"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(507, 26)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(800, 572)
        Me.TabControl2.TabIndex = 58
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.SearchFood_btn)
        Me.TabPage3.Controls.Add(Me.SearchFood_txtbox)
        Me.TabPage3.Controls.Add(Me.Food_DGV)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 539)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Foods"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(450, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 16)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Search your data by using Food ID."
        '
        'SearchFood_btn
        '
        Me.SearchFood_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchFood_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFood_btn.Location = New System.Drawing.Point(692, 16)
        Me.SearchFood_btn.Name = "SearchFood_btn"
        Me.SearchFood_btn.Size = New System.Drawing.Size(94, 30)
        Me.SearchFood_btn.TabIndex = 49
        Me.SearchFood_btn.Text = "Search"
        Me.SearchFood_btn.UseVisualStyleBackColor = False
        '
        'SearchFood_txtbox
        '
        Me.SearchFood_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchFood_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchFood_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFood_txtbox.Location = New System.Drawing.Point(453, 18)
        Me.SearchFood_txtbox.Name = "SearchFood_txtbox"
        Me.SearchFood_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchFood_txtbox.Size = New System.Drawing.Size(233, 26)
        Me.SearchFood_txtbox.TabIndex = 50
        '
        'Food_DGV
        '
        Me.Food_DGV.AllowUserToAddRows = False
        Me.Food_DGV.AllowUserToDeleteRows = False
        Me.Food_DGV.AllowUserToOrderColumns = True
        Me.Food_DGV.AutoGenerateColumns = False
        Me.Food_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.Food_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Food_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.MenuNameDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.MenuStatusDataGridViewTextBoxColumn})
        Me.Food_DGV.DataSource = Me.MenuBindingSource
        Me.Food_DGV.GridColor = System.Drawing.Color.MintCream
        Me.Food_DGV.Location = New System.Drawing.Point(6, 73)
        Me.Food_DGV.MultiSelect = False
        Me.Food_DGV.Name = "Food_DGV"
        Me.Food_DGV.ReadOnly = True
        Me.Food_DGV.RowHeadersVisible = False
        Me.Food_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Food_DGV.Size = New System.Drawing.Size(780, 455)
        Me.Food_DGV.TabIndex = 0
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "Food ID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn.Width = 136
        '
        'MenuNameDataGridViewTextBoxColumn
        '
        Me.MenuNameDataGridViewTextBoxColumn.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn.HeaderText = "Food Name"
        Me.MenuNameDataGridViewTextBoxColumn.Name = "MenuNameDataGridViewTextBoxColumn"
        Me.MenuNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn.Width = 280
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 183
        '
        'MenuStatusDataGridViewTextBoxColumn
        '
        Me.MenuStatusDataGridViewTextBoxColumn.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn.HeaderText = "Food Status"
        Me.MenuStatusDataGridViewTextBoxColumn.Name = "MenuStatusDataGridViewTextBoxColumn"
        Me.MenuStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn.Width = 178
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.SearchDrink_btn)
        Me.TabPage4.Controls.Add(Me.SearchDrink_txtbox)
        Me.TabPage4.Controls.Add(Me.Drink_DGV)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(792, 539)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Drinks"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DimGray
        Me.Label16.Location = New System.Drawing.Point(450, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(216, 16)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Search your data by using Drink ID."
        '
        'SearchDrink_btn
        '
        Me.SearchDrink_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchDrink_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrink_btn.Location = New System.Drawing.Point(692, 16)
        Me.SearchDrink_btn.Name = "SearchDrink_btn"
        Me.SearchDrink_btn.Size = New System.Drawing.Size(94, 30)
        Me.SearchDrink_btn.TabIndex = 52
        Me.SearchDrink_btn.Text = "Search"
        Me.SearchDrink_btn.UseVisualStyleBackColor = False
        '
        'SearchDrink_txtbox
        '
        Me.SearchDrink_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchDrink_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchDrink_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrink_txtbox.Location = New System.Drawing.Point(453, 18)
        Me.SearchDrink_txtbox.Name = "SearchDrink_txtbox"
        Me.SearchDrink_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchDrink_txtbox.Size = New System.Drawing.Size(233, 26)
        Me.SearchDrink_txtbox.TabIndex = 53
        '
        'Drink_DGV
        '
        Me.Drink_DGV.AllowUserToAddRows = False
        Me.Drink_DGV.AllowUserToDeleteRows = False
        Me.Drink_DGV.AutoGenerateColumns = False
        Me.Drink_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.Drink_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Drink_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn1, Me.MenuNameDataGridViewTextBoxColumn1, Me.UnitPriceDataGridViewTextBoxColumn1, Me.MenuStatusDataGridViewTextBoxColumn1})
        Me.Drink_DGV.DataSource = Me.MenuBindingSource
        Me.Drink_DGV.Location = New System.Drawing.Point(6, 73)
        Me.Drink_DGV.Name = "Drink_DGV"
        Me.Drink_DGV.ReadOnly = True
        Me.Drink_DGV.RowHeadersVisible = False
        Me.Drink_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Drink_DGV.Size = New System.Drawing.Size(780, 455)
        Me.Drink_DGV.TabIndex = 0
        '
        'MenuIDDataGridViewTextBoxColumn1
        '
        Me.MenuIDDataGridViewTextBoxColumn1.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn1.HeaderText = "Drink ID"
        Me.MenuIDDataGridViewTextBoxColumn1.Name = "MenuIDDataGridViewTextBoxColumn1"
        Me.MenuIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn1.Width = 136
        '
        'MenuNameDataGridViewTextBoxColumn1
        '
        Me.MenuNameDataGridViewTextBoxColumn1.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn1.HeaderText = "Drink Name"
        Me.MenuNameDataGridViewTextBoxColumn1.Name = "MenuNameDataGridViewTextBoxColumn1"
        Me.MenuNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn1.Width = 280
        '
        'UnitPriceDataGridViewTextBoxColumn1
        '
        Me.UnitPriceDataGridViewTextBoxColumn1.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn1.Name = "UnitPriceDataGridViewTextBoxColumn1"
        Me.UnitPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn1.Width = 183
        '
        'MenuStatusDataGridViewTextBoxColumn1
        '
        Me.MenuStatusDataGridViewTextBoxColumn1.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn1.HeaderText = "Drink Status"
        Me.MenuStatusDataGridViewTextBoxColumn1.Name = "MenuStatusDataGridViewTextBoxColumn1"
        Me.MenuStatusDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn1.Width = 178
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.SearchDessert_btn)
        Me.TabPage5.Controls.Add(Me.SearchDessert_txtbox)
        Me.TabPage5.Controls.Add(Me.Dessert_DGV)
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(792, 539)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Desserts"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DimGray
        Me.Label17.Location = New System.Drawing.Point(450, 47)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(232, 16)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Search your data by using Dessert ID."
        '
        'SearchDessert_btn
        '
        Me.SearchDessert_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchDessert_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDessert_btn.Location = New System.Drawing.Point(692, 16)
        Me.SearchDessert_btn.Name = "SearchDessert_btn"
        Me.SearchDessert_btn.Size = New System.Drawing.Size(94, 30)
        Me.SearchDessert_btn.TabIndex = 52
        Me.SearchDessert_btn.Text = "Search"
        Me.SearchDessert_btn.UseVisualStyleBackColor = False
        '
        'SearchDessert_txtbox
        '
        Me.SearchDessert_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SearchDessert_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchDessert_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDessert_txtbox.Location = New System.Drawing.Point(453, 18)
        Me.SearchDessert_txtbox.Name = "SearchDessert_txtbox"
        Me.SearchDessert_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchDessert_txtbox.Size = New System.Drawing.Size(233, 26)
        Me.SearchDessert_txtbox.TabIndex = 53
        '
        'Dessert_DGV
        '
        Me.Dessert_DGV.AllowUserToAddRows = False
        Me.Dessert_DGV.AllowUserToDeleteRows = False
        Me.Dessert_DGV.AutoGenerateColumns = False
        Me.Dessert_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.Dessert_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dessert_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn2, Me.MenuNameDataGridViewTextBoxColumn2, Me.UnitPriceDataGridViewTextBoxColumn2, Me.MenuStatusDataGridViewTextBoxColumn2})
        Me.Dessert_DGV.DataSource = Me.MenuBindingSource
        Me.Dessert_DGV.Location = New System.Drawing.Point(6, 73)
        Me.Dessert_DGV.Name = "Dessert_DGV"
        Me.Dessert_DGV.ReadOnly = True
        Me.Dessert_DGV.RowHeadersVisible = False
        Me.Dessert_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dessert_DGV.Size = New System.Drawing.Size(780, 455)
        Me.Dessert_DGV.TabIndex = 0
        '
        'MenuIDDataGridViewTextBoxColumn2
        '
        Me.MenuIDDataGridViewTextBoxColumn2.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn2.HeaderText = "Dessert ID"
        Me.MenuIDDataGridViewTextBoxColumn2.Name = "MenuIDDataGridViewTextBoxColumn2"
        Me.MenuIDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn2.Width = 136
        '
        'MenuNameDataGridViewTextBoxColumn2
        '
        Me.MenuNameDataGridViewTextBoxColumn2.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn2.HeaderText = "Dessert Name"
        Me.MenuNameDataGridViewTextBoxColumn2.Name = "MenuNameDataGridViewTextBoxColumn2"
        Me.MenuNameDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn2.Width = 280
        '
        'UnitPriceDataGridViewTextBoxColumn2
        '
        Me.UnitPriceDataGridViewTextBoxColumn2.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn2.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn2.Name = "UnitPriceDataGridViewTextBoxColumn2"
        Me.UnitPriceDataGridViewTextBoxColumn2.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn2.Width = 183
        '
        'MenuStatusDataGridViewTextBoxColumn2
        '
        Me.MenuStatusDataGridViewTextBoxColumn2.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn2.HeaderText = "Dessert Status"
        Me.MenuStatusDataGridViewTextBoxColumn2.Name = "MenuStatusDataGridViewTextBoxColumn2"
        Me.MenuStatusDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn2.Width = 178
        '
        'UpdateProduct_btn
        '
        Me.UpdateProduct_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateProduct_btn.Location = New System.Drawing.Point(28, 468)
        Me.UpdateProduct_btn.Name = "UpdateProduct_btn"
        Me.UpdateProduct_btn.Size = New System.Drawing.Size(104, 30)
        Me.UpdateProduct_btn.TabIndex = 56
        Me.UpdateProduct_btn.Text = "Update"
        Me.UpdateProduct_btn.UseVisualStyleBackColor = True
        Me.UpdateProduct_btn.Visible = False
        '
        'AddProduct_btn
        '
        Me.AddProduct_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddProduct_btn.Location = New System.Drawing.Point(28, 468)
        Me.AddProduct_btn.Name = "AddProduct_btn"
        Me.AddProduct_btn.Size = New System.Drawing.Size(104, 30)
        Me.AddProduct_btn.TabIndex = 55
        Me.AddProduct_btn.Text = "Add"
        Me.AddProduct_btn.UseVisualStyleBackColor = True
        '
        'DeleteProduct_btn
        '
        Me.DeleteProduct_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteProduct_btn.Location = New System.Drawing.Point(28, 504)
        Me.DeleteProduct_btn.Name = "DeleteProduct_btn"
        Me.DeleteProduct_btn.Size = New System.Drawing.Size(104, 30)
        Me.DeleteProduct_btn.TabIndex = 57
        Me.DeleteProduct_btn.Text = "Delete"
        Me.DeleteProduct_btn.UseVisualStyleBackColor = True
        Me.DeleteProduct_btn.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Indigo
        Me.Label18.Location = New System.Drawing.Point(23, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(313, 25)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "WaterLily Restaurant Menu List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProductStatus_CB)
        Me.GroupBox2.Controls.Add(Me.UnitPrice_txtbox)
        Me.GroupBox2.Controls.Add(Me.ProductName_txtbox)
        Me.GroupBox2.Controls.Add(Me.ProductID_txtbox)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.ClearProduct_btn)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(28, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 348)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information of Restaurant Menu's Item"
        '
        'ProductStatus_CB
        '
        Me.ProductStatus_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductStatus_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductStatus_CB.FormattingEnabled = True
        Me.ProductStatus_CB.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.ProductStatus_CB.Location = New System.Drawing.Point(13, 246)
        Me.ProductStatus_CB.Name = "ProductStatus_CB"
        Me.ProductStatus_CB.Size = New System.Drawing.Size(433, 26)
        Me.ProductStatus_CB.TabIndex = 9
        '
        'UnitPrice_txtbox
        '
        Me.UnitPrice_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_txtbox.Location = New System.Drawing.Point(12, 185)
        Me.UnitPrice_txtbox.Name = "UnitPrice_txtbox"
        Me.UnitPrice_txtbox.Size = New System.Drawing.Size(434, 24)
        Me.UnitPrice_txtbox.TabIndex = 7
        '
        'ProductName_txtbox
        '
        Me.ProductName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName_txtbox.Location = New System.Drawing.Point(12, 124)
        Me.ProductName_txtbox.Name = "ProductName_txtbox"
        Me.ProductName_txtbox.Size = New System.Drawing.Size(434, 24)
        Me.ProductName_txtbox.TabIndex = 6
        '
        'ProductID_txtbox
        '
        Me.ProductID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductID_txtbox.Location = New System.Drawing.Point(12, 65)
        Me.ProductID_txtbox.MaxLength = 5
        Me.ProductID_txtbox.Name = "ProductID_txtbox"
        Me.ProductID_txtbox.Size = New System.Drawing.Size(434, 24)
        Me.ProductID_txtbox.TabIndex = 5
        Me.Product_TT.SetToolTip(Me.ProductID_txtbox, "Insert using ""F"" represents Food, ""D"" represents Drink, ""S"" represents Dessert.")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(10, 225)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(122, 18)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "4. Product Status"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(10, 164)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(228, 18)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "3. Product Price per serving (RM)"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 103)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 18)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "2. Product Name"
        '
        'ClearProduct_btn
        '
        Me.ClearProduct_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearProduct_btn.Location = New System.Drawing.Point(344, 289)
        Me.ClearProduct_btn.Name = "ClearProduct_btn"
        Me.ClearProduct_btn.Size = New System.Drawing.Size(102, 31)
        Me.ClearProduct_btn.TabIndex = 24
        Me.ClearProduct_btn.Text = "Clear"
        Me.ClearProduct_btn.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(10, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 18)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "1. Product ID"
        '
        'RestaurantTableInfo_TP
        '
        Me.RestaurantTableInfo_TP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.RestaurantTableInfo_TP.Controls.Add(Me.SearchTable_txtbox)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.Label26)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.SearchTable_btn)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.GroupBox3)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.TableDetail_DGV)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.DeleteTable_btn)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.AddTable_btn)
        Me.RestaurantTableInfo_TP.Controls.Add(Me.UpdateTable_btn)
        Me.RestaurantTableInfo_TP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestaurantTableInfo_TP.Location = New System.Drawing.Point(4, 29)
        Me.RestaurantTableInfo_TP.Name = "RestaurantTableInfo_TP"
        Me.RestaurantTableInfo_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.RestaurantTableInfo_TP.Size = New System.Drawing.Size(1318, 619)
        Me.RestaurantTableInfo_TP.TabIndex = 6
        Me.RestaurantTableInfo_TP.Text = "Restaurant Table"
        '
        'SearchTable_txtbox
        '
        Me.SearchTable_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchTable_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchTable_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchTable_txtbox.Location = New System.Drawing.Point(88, 40)
        Me.SearchTable_txtbox.Name = "SearchTable_txtbox"
        Me.SearchTable_txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchTable_txtbox.Size = New System.Drawing.Size(303, 26)
        Me.SearchTable_txtbox.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DimGray
        Me.Label26.Location = New System.Drawing.Point(85, 69)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(240, 18)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Search your data by using Table ID."
        '
        'SearchTable_btn
        '
        Me.SearchTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.SearchTable_btn.Location = New System.Drawing.Point(397, 38)
        Me.SearchTable_btn.Name = "SearchTable_btn"
        Me.SearchTable_btn.Size = New System.Drawing.Size(94, 31)
        Me.SearchTable_btn.TabIndex = 6
        Me.SearchTable_btn.Text = "Search"
        Me.SearchTable_btn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableStatus_CB)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Capacity_txtbox)
        Me.GroupBox3.Controls.Add(Me.TableNo_txtbox)
        Me.GroupBox3.Controls.Add(Me.ClearTable_btn)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(51, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(440, 256)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Restaurant Information"
        '
        'TableStatus_CB
        '
        Me.TableStatus_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TableStatus_CB.FormattingEnabled = True
        Me.TableStatus_CB.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.TableStatus_CB.Location = New System.Drawing.Point(137, 135)
        Me.TableStatus_CB.Name = "TableStatus_CB"
        Me.TableStatus_CB.Size = New System.Drawing.Size(283, 28)
        Me.TableStatus_CB.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 135)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 20)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Table Status  :"
        '
        'Capacity_txtbox
        '
        Me.Capacity_txtbox.Location = New System.Drawing.Point(137, 100)
        Me.Capacity_txtbox.Name = "Capacity_txtbox"
        Me.Capacity_txtbox.Size = New System.Drawing.Size(283, 26)
        Me.Capacity_txtbox.TabIndex = 3
        '
        'TableNo_txtbox
        '
        Me.TableNo_txtbox.Location = New System.Drawing.Point(137, 62)
        Me.TableNo_txtbox.MaxLength = 3
        Me.TableNo_txtbox.Name = "TableNo_txtbox"
        Me.TableNo_txtbox.Size = New System.Drawing.Size(283, 26)
        Me.TableNo_txtbox.TabIndex = 2
        '
        'ClearTable_btn
        '
        Me.ClearTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.ClearTable_btn.Location = New System.Drawing.Point(321, 182)
        Me.ClearTable_btn.Name = "ClearTable_btn"
        Me.ClearTable_btn.Size = New System.Drawing.Size(99, 34)
        Me.ClearTable_btn.TabIndex = 3
        Me.ClearTable_btn.Text = "Clear"
        Me.ClearTable_btn.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 20)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Table ID         :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(18, 100)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 20)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Capacity         :"
        '
        'TableDetail_DGV
        '
        Me.TableDetail_DGV.AllowUserToAddRows = False
        Me.TableDetail_DGV.AllowUserToDeleteRows = False
        Me.TableDetail_DGV.AllowUserToOrderColumns = True
        Me.TableDetail_DGV.AutoGenerateColumns = False
        Me.TableDetail_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TableDetail_DGV.BackgroundColor = System.Drawing.Color.MintCream
        Me.TableDetail_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDetail_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.TableStatusDataGridViewTextBoxColumn})
        Me.TableDetail_DGV.DataSource = Me.TableBindingSource
        Me.TableDetail_DGV.Location = New System.Drawing.Point(568, 38)
        Me.TableDetail_DGV.MultiSelect = False
        Me.TableDetail_DGV.Name = "TableDetail_DGV"
        Me.TableDetail_DGV.ReadOnly = True
        Me.TableDetail_DGV.RowHeadersVisible = False
        Me.TableDetail_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TableDetail_DGV.Size = New System.Drawing.Size(698, 551)
        Me.TableDetail_DGV.TabIndex = 4
        '
        'TableIDDataGridViewTextBoxColumn
        '
        Me.TableIDDataGridViewTextBoxColumn.DataPropertyName = "Table_ID"
        Me.TableIDDataGridViewTextBoxColumn.HeaderText = "Table ID"
        Me.TableIDDataGridViewTextBoxColumn.Name = "TableIDDataGridViewTextBoxColumn"
        Me.TableIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TableStatusDataGridViewTextBoxColumn
        '
        Me.TableStatusDataGridViewTextBoxColumn.DataPropertyName = "Table_Status"
        Me.TableStatusDataGridViewTextBoxColumn.HeaderText = "Table Status"
        Me.TableStatusDataGridViewTextBoxColumn.Name = "TableStatusDataGridViewTextBoxColumn"
        Me.TableStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "table"
        Me.TableBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'DeleteTable_btn
        '
        Me.DeleteTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.DeleteTable_btn.Location = New System.Drawing.Point(51, 457)
        Me.DeleteTable_btn.Name = "DeleteTable_btn"
        Me.DeleteTable_btn.Size = New System.Drawing.Size(114, 39)
        Me.DeleteTable_btn.TabIndex = 2
        Me.DeleteTable_btn.Text = "Delete"
        Me.DeleteTable_btn.UseVisualStyleBackColor = True
        Me.DeleteTable_btn.Visible = False
        '
        'AddTable_btn
        '
        Me.AddTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.AddTable_btn.Location = New System.Drawing.Point(51, 406)
        Me.AddTable_btn.Name = "AddTable_btn"
        Me.AddTable_btn.Size = New System.Drawing.Size(114, 39)
        Me.AddTable_btn.TabIndex = 0
        Me.AddTable_btn.Text = "Add"
        Me.AddTable_btn.UseVisualStyleBackColor = True
        '
        'UpdateTable_btn
        '
        Me.UpdateTable_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!)
        Me.UpdateTable_btn.Location = New System.Drawing.Point(51, 406)
        Me.UpdateTable_btn.Name = "UpdateTable_btn"
        Me.UpdateTable_btn.Size = New System.Drawing.Size(114, 39)
        Me.UpdateTable_btn.TabIndex = 1
        Me.UpdateTable_btn.Text = "Update"
        Me.UpdateTable_btn.UseVisualStyleBackColor = True
        Me.UpdateTable_btn.Visible = False
        '
        'DailyReport_TP
        '
        Me.DailyReport_TP.BackColor = System.Drawing.Color.PaleTurquoise
        Me.DailyReport_TP.Controls.Add(Me.Label31)
        Me.DailyReport_TP.Controls.Add(Me.MenuName_txtbox)
        Me.DailyReport_TP.Controls.Add(Me.Label14)
        Me.DailyReport_TP.Controls.Add(Me.Label1)
        Me.DailyReport_TP.Controls.Add(Me.DailySales_btn)
        Me.DailyReport_TP.Controls.Add(Me.TotalAmount_txtbox)
        Me.DailyReport_TP.Controls.Add(Me.TotalQuantity_txtbox)
        Me.DailyReport_TP.Controls.Add(Me.TotalAmount_lbl)
        Me.DailyReport_TP.Controls.Add(Me.BestSellingMenuTitle)
        Me.DailyReport_TP.Controls.Add(Me.BestSelling_C)
        Me.DailyReport_TP.Controls.Add(Me.TotalQuantity_lbl)
        Me.DailyReport_TP.Controls.Add(Me.PopularMenuID_txtbox)
        Me.DailyReport_TP.Controls.Add(Me.PopularMenuID_lbl)
        Me.DailyReport_TP.Controls.Add(Me.BestSellingMenuDetail_DGV)
        Me.DailyReport_TP.Controls.Add(Me.Calender_DTP)
        Me.DailyReport_TP.Controls.Add(Me.ReportInformation_S)
        Me.DailyReport_TP.Location = New System.Drawing.Point(4, 29)
        Me.DailyReport_TP.Name = "DailyReport_TP"
        Me.DailyReport_TP.Padding = New System.Windows.Forms.Padding(3)
        Me.DailyReport_TP.Size = New System.Drawing.Size(1318, 619)
        Me.DailyReport_TP.TabIndex = 7
        Me.DailyReport_TP.Text = "Daily Report"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label31.Location = New System.Drawing.Point(545, 96)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(52, 20)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "Date :"
        '
        'MenuName_txtbox
        '
        Me.MenuName_txtbox.Location = New System.Drawing.Point(128, 93)
        Me.MenuName_txtbox.Name = "MenuName_txtbox"
        Me.MenuName_txtbox.ReadOnly = True
        Me.MenuName_txtbox.Size = New System.Drawing.Size(279, 26)
        Me.MenuName_txtbox.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label14.Location = New System.Drawing.Point(19, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 20)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Menu Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "The Best Selling Menu"
        '
        'DailySales_btn
        '
        Me.DailySales_btn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.DailySales_btn.Location = New System.Drawing.Point(571, 17)
        Me.DailySales_btn.Name = "DailySales_btn"
        Me.DailySales_btn.Size = New System.Drawing.Size(157, 37)
        Me.DailySales_btn.TabIndex = 22
        Me.DailySales_btn.Text = "Daily Sales Report"
        Me.DSR_TT.SetToolTip(Me.DailySales_btn, "View Daily Sales Report.")
        Me.DailySales_btn.UseVisualStyleBackColor = False
        '
        'TotalAmount_txtbox
        '
        Me.TotalAmount_txtbox.Location = New System.Drawing.Point(141, 576)
        Me.TotalAmount_txtbox.Name = "TotalAmount_txtbox"
        Me.TotalAmount_txtbox.ReadOnly = True
        Me.TotalAmount_txtbox.Size = New System.Drawing.Size(171, 26)
        Me.TotalAmount_txtbox.TabIndex = 21
        '
        'TotalQuantity_txtbox
        '
        Me.TotalQuantity_txtbox.Location = New System.Drawing.Point(141, 544)
        Me.TotalQuantity_txtbox.Name = "TotalQuantity_txtbox"
        Me.TotalQuantity_txtbox.ReadOnly = True
        Me.TotalQuantity_txtbox.Size = New System.Drawing.Size(131, 26)
        Me.TotalQuantity_txtbox.TabIndex = 20
        '
        'TotalAmount_lbl
        '
        Me.TotalAmount_lbl.AutoSize = True
        Me.TotalAmount_lbl.BackColor = System.Drawing.Color.MediumTurquoise
        Me.TotalAmount_lbl.Location = New System.Drawing.Point(19, 579)
        Me.TotalAmount_lbl.Name = "TotalAmount_lbl"
        Me.TotalAmount_lbl.Size = New System.Drawing.Size(116, 20)
        Me.TotalAmount_lbl.TabIndex = 19
        Me.TotalAmount_lbl.Text = "Total Amount  :"
        '
        'BestSellingMenuTitle
        '
        Me.BestSellingMenuTitle.AutoSize = True
        Me.BestSellingMenuTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestSellingMenuTitle.Location = New System.Drawing.Point(926, 17)
        Me.BestSellingMenuTitle.Name = "BestSellingMenuTitle"
        Me.BestSellingMenuTitle.Size = New System.Drawing.Size(256, 20)
        Me.BestSellingMenuTitle.TabIndex = 18
        Me.BestSellingMenuTitle.Text = "Total Ordered against Menu ID"
        '
        'BestSelling_C
        '
        ChartArea1.AxisX.Interval = 1.0R
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.Name = "ChartArea1"
        Me.BestSelling_C.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.BestSelling_C.Legends.Add(Legend1)
        Me.BestSelling_C.Location = New System.Drawing.Point(760, 45)
        Me.BestSelling_C.Name = "BestSelling_C"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Quantity_VS_MenuID"
        Me.BestSelling_C.Series.Add(Series1)
        Me.BestSelling_C.Size = New System.Drawing.Size(542, 554)
        Me.BestSelling_C.TabIndex = 17
        Me.BestSelling_C.Text = "Chart1"
        '
        'TotalQuantity_lbl
        '
        Me.TotalQuantity_lbl.AutoSize = True
        Me.TotalQuantity_lbl.BackColor = System.Drawing.Color.MediumTurquoise
        Me.TotalQuantity_lbl.Location = New System.Drawing.Point(20, 547)
        Me.TotalQuantity_lbl.Name = "TotalQuantity_lbl"
        Me.TotalQuantity_lbl.Size = New System.Drawing.Size(115, 20)
        Me.TotalQuantity_lbl.TabIndex = 16
        Me.TotalQuantity_lbl.Text = "Total Quantity :"
        '
        'PopularMenuID_txtbox
        '
        Me.PopularMenuID_txtbox.Location = New System.Drawing.Point(128, 64)
        Me.PopularMenuID_txtbox.Name = "PopularMenuID_txtbox"
        Me.PopularMenuID_txtbox.ReadOnly = True
        Me.PopularMenuID_txtbox.Size = New System.Drawing.Size(171, 26)
        Me.PopularMenuID_txtbox.TabIndex = 15
        '
        'PopularMenuID_lbl
        '
        Me.PopularMenuID_lbl.AutoSize = True
        Me.PopularMenuID_lbl.BackColor = System.Drawing.Color.MediumTurquoise
        Me.PopularMenuID_lbl.Location = New System.Drawing.Point(20, 67)
        Me.PopularMenuID_lbl.Name = "PopularMenuID_lbl"
        Me.PopularMenuID_lbl.Size = New System.Drawing.Size(102, 20)
        Me.PopularMenuID_lbl.TabIndex = 13
        Me.PopularMenuID_lbl.Text = "Menu ID       :"
        '
        'BestSellingMenuDetail_DGV
        '
        Me.BestSellingMenuDetail_DGV.AllowUserToAddRows = False
        Me.BestSellingMenuDetail_DGV.AllowUserToDeleteRows = False
        Me.BestSellingMenuDetail_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BestSellingMenuDetail_DGV.BackgroundColor = System.Drawing.Color.Honeydew
        Me.BestSellingMenuDetail_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BestSellingMenuDetail_DGV.Location = New System.Drawing.Point(23, 136)
        Me.BestSellingMenuDetail_DGV.MultiSelect = False
        Me.BestSellingMenuDetail_DGV.Name = "BestSellingMenuDetail_DGV"
        Me.BestSellingMenuDetail_DGV.ReadOnly = True
        Me.BestSellingMenuDetail_DGV.RowHeadersVisible = False
        Me.BestSellingMenuDetail_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BestSellingMenuDetail_DGV.Size = New System.Drawing.Size(705, 392)
        Me.BestSellingMenuDetail_DGV.TabIndex = 12
        '
        'Calender_DTP
        '
        Me.Calender_DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Calender_DTP.Location = New System.Drawing.Point(603, 93)
        Me.Calender_DTP.Name = "Calender_DTP"
        Me.Calender_DTP.Size = New System.Drawing.Size(125, 26)
        Me.Calender_DTP.TabIndex = 11
        '
        'ReportInformation_S
        '
        Me.ReportInformation_S.BackColor = System.Drawing.Color.MediumTurquoise
        Me.ReportInformation_S.Location = New System.Drawing.Point(3, 3)
        Me.ReportInformation_S.Name = "ReportInformation_S"
        Me.ReportInformation_S.Size = New System.Drawing.Size(739, 613)
        Me.ReportInformation_S.TabIndex = 14
        Me.ReportInformation_S.TabStop = False
        '
        'Welcome_lbl
        '
        Me.Welcome_lbl.AutoSize = True
        Me.Welcome_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_lbl.ForeColor = System.Drawing.Color.Purple
        Me.Welcome_lbl.Location = New System.Drawing.Point(1159, 5)
        Me.Welcome_lbl.Name = "Welcome_lbl"
        Me.Welcome_lbl.Size = New System.Drawing.Size(151, 16)
        Me.Welcome_lbl.TabIndex = 6
        Me.Welcome_lbl.Text = "Welcome & Full Name"
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'DSR_TT
        '
        Me.DSR_TT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.DSR_TT.ToolTipTitle = "View/Print"
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Manager_Use
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.Welcome_lbl)
        Me.Controls.Add(Me.ManagerWorks_TC)
        Me.Controls.Add(Me.LogOut_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTime_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Manager_Use"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manager_Use"
        Me.ManagerWorks_TC.ResumeLayout(False)
        Me.StaffAccount_TP.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.AccountList_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Account_TC.ResumeLayout(False)
        Me.AddAccount_TP.ResumeLayout(False)
        Me.AddAccount_TP.PerformLayout()
        Me.UpdateDeleteAccount_TP.ResumeLayout(False)
        Me.UpdateDeleteAccount_TP.PerformLayout()
        Me.RestaurantMenu_TP.ResumeLayout(False)
        Me.RestaurantMenu_TP.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.RestaurantTableInfo_TP.ResumeLayout(False)
        Me.RestaurantTableInfo_TP.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TableDetail_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DailyReport_TP.ResumeLayout(False)
        Me.DailyReport_TP.PerformLayout()
        CType(Me.BestSelling_C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BestSellingMenuDetail_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTime_lbl As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTime_timer As System.Windows.Forms.Timer
    Friend WithEvents LogOut_btn As System.Windows.Forms.Button
    Friend WithEvents ManagerWorks_TC As System.Windows.Forms.TabControl
    Friend WithEvents StaffAccount_TP As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AccountList_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Account_TC As System.Windows.Forms.TabControl
    Friend WithEvents AddAccount_TP As System.Windows.Forms.TabPage
    Friend WithEvents ShowHidePassword_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FullName_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Username_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Password_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents ClearAccount_btn As System.Windows.Forms.Button
    Friend WithEvents UserTypeLvl_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CreateAccount_btn As System.Windows.Forms.Button
    Friend WithEvents UpdateDeleteAccount_TP As System.Windows.Forms.TabPage
    Friend WithEvents ShowHidePasssword_CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Password_txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents UserTypeLvl_txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents FullName_txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents Username_txtbox2 As System.Windows.Forms.TextBox
    Friend WithEvents SearchAccount_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents SearchAccount_btn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DeleteAccount_btn As System.Windows.Forms.Button
    Friend WithEvents UpdateAccount_btn As System.Windows.Forms.Button
    Friend WithEvents RestaurantMenu_TP As System.Windows.Forms.TabPage
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ProductStatus_CB As System.Windows.Forms.ComboBox
    Friend WithEvents UnitPrice_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents ProductName_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents ProductID_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ClearProduct_btn As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents RestaurantTableInfo_TP As System.Windows.Forms.TabPage
    Friend WithEvents DailyReport_TP As System.Windows.Forms.TabPage
    Friend WithEvents ClearTable_btn As System.Windows.Forms.Button
    Friend WithEvents DeleteTable_btn As System.Windows.Forms.Button
    Friend WithEvents UpdateTable_btn As System.Windows.Forms.Button
    Friend WithEvents AddTable_btn As System.Windows.Forms.Button
    Friend WithEvents TableDetail_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents SearchTable_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents SearchTable_btn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Capacity_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TableNo_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents TableNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UpdateProduct_btn As System.Windows.Forms.Button
    Friend WithEvents AddProduct_btn As System.Windows.Forms.Button
    Friend WithEvents DeleteProduct_btn As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TableStatus_CB As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Product_TT As System.Windows.Forms.ToolTip
    Friend WithEvents FosdatabaseDataSet As Workshop_InProgress.fosdatabaseDataSet
    Friend WithEvents TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.tableTableAdapter
    Friend WithEvents TableIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Calender_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SearchFood_btn As System.Windows.Forms.Button
    Friend WithEvents SearchFood_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Food_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SearchDrink_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDrink_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Drink_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SearchDessert_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDessert_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Dessert_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter
    Friend WithEvents BestSellingMenuDetail_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TotalAmount_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TotalQuantity_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents TotalAmount_lbl As System.Windows.Forms.Label
    Friend WithEvents BestSellingMenuTitle As System.Windows.Forms.Label
    Friend WithEvents BestSelling_C As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TotalQuantity_lbl As System.Windows.Forms.Label
    Friend WithEvents PopularMenuID_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents PopularMenuID_lbl As System.Windows.Forms.Label
    Friend WithEvents ReportInformation_S As System.Windows.Forms.Splitter
    Friend WithEvents DailySales_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuName_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DSR_TT As System.Windows.Forms.ToolTip
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents StaffBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StaffTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.staffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StaffPositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Retype_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Wrong_lbl As System.Windows.Forms.Label
    Friend WithEvents ShowHidePassword_CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ShowHidePasssword_CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Wrong_lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Retype_txtbox1 As System.Windows.Forms.TextBox
End Class
