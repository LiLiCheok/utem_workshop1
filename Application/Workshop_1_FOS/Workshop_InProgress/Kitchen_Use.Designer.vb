<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kitchen_Use
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogOut_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Welcome_lbl = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchDessert_btn = New System.Windows.Forms.Button()
        Me.SearchDessert_txtbox = New System.Windows.Forms.TextBox()
        Me.Dessert_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FosdatabaseDataSet = New Workshop_InProgress.fosdatabaseDataSet()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SearchDrink_btn = New System.Windows.Forms.Button()
        Me.SearchDrink_txtbox = New System.Windows.Forms.TextBox()
        Me.Drink_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SearchFood_btn = New System.Windows.Forms.Button()
        Me.SearchFood_txtbox = New System.Windows.Forms.TextBox()
        Me.Food_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ProductStatus_CB = New System.Windows.Forms.ComboBox()
        Me.UnitPrice_txtbox = New System.Windows.Forms.TextBox()
        Me.ProductName_txtbox = New System.Windows.Forms.TextBox()
        Me.ProductID_txtbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Update_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MenuTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter()
        Me.TabPage5.SuspendLayout()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightGreen
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label4.Location = New System.Drawing.Point(3, 711)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "FOS version 10.1.4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(1210, 711)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "DATE , TIME"
        '
        'LogOut_btn
        '
        Me.LogOut_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.LogOut_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOut_btn.Location = New System.Drawing.Point(1215, 649)
        Me.LogOut_btn.Name = "LogOut_btn"
        Me.LogOut_btn.Size = New System.Drawing.Size(114, 39)
        Me.LogOut_btn.TabIndex = 32
        Me.LogOut_btn.Text = "Log Out"
        Me.LogOut_btn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(528, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 25)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "WaterLily Restaurant Menu List"
        '
        'Welcome_lbl
        '
        Me.Welcome_lbl.AutoSize = True
        Me.Welcome_lbl.BackColor = System.Drawing.Color.LightGreen
        Me.Welcome_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Welcome_lbl.ForeColor = System.Drawing.Color.Purple
        Me.Welcome_lbl.Location = New System.Drawing.Point(3, 3)
        Me.Welcome_lbl.Name = "Welcome_lbl"
        Me.Welcome_lbl.Size = New System.Drawing.Size(160, 18)
        Me.Welcome_lbl.TabIndex = 49
        Me.Welcome_lbl.Text = "Welcome Full Name"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.LightGreen
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(505, 730)
        Me.Splitter1.TabIndex = 50
        Me.Splitter1.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage5.Controls.Add(Me.Label10)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(450, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Search your data by using Dessert ID."
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
        Me.MenuIDDataGridViewTextBoxColumn2.HeaderText = "Dessert_ID"
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
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "menu"
        Me.MenuBindingSource.DataSource = Me.FosdatabaseDataSet
        '
        'FosdatabaseDataSet
        '
        Me.FosdatabaseDataSet.DataSetName = "fosdatabaseDataSet"
        Me.FosdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage4.Controls.Add(Me.Label2)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(450, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Search your data by using Drink ID."
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
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Honeydew
        Me.TabPage3.Controls.Add(Me.Label9)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(450, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(217, 16)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Search your data by using Food ID."
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
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(529, 50)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(800, 572)
        Me.TabControl2.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LightGreen
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(313, 25)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Information of Restaurant Menu"
        '
        'ProductStatus_CB
        '
        Me.ProductStatus_CB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductStatus_CB.FormattingEnabled = True
        Me.ProductStatus_CB.Items.AddRange(New Object() {"Available", "Not Available"})
        Me.ProductStatus_CB.Location = New System.Drawing.Point(28, 382)
        Me.ProductStatus_CB.Name = "ProductStatus_CB"
        Me.ProductStatus_CB.Size = New System.Drawing.Size(449, 26)
        Me.ProductStatus_CB.TabIndex = 68
        '
        'UnitPrice_txtbox
        '
        Me.UnitPrice_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitPrice_txtbox.Location = New System.Drawing.Point(28, 302)
        Me.UnitPrice_txtbox.Name = "UnitPrice_txtbox"
        Me.UnitPrice_txtbox.ReadOnly = True
        Me.UnitPrice_txtbox.Size = New System.Drawing.Size(449, 24)
        Me.UnitPrice_txtbox.TabIndex = 67
        '
        'ProductName_txtbox
        '
        Me.ProductName_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName_txtbox.Location = New System.Drawing.Point(28, 219)
        Me.ProductName_txtbox.Name = "ProductName_txtbox"
        Me.ProductName_txtbox.ReadOnly = True
        Me.ProductName_txtbox.Size = New System.Drawing.Size(449, 24)
        Me.ProductName_txtbox.TabIndex = 66
        '
        'ProductID_txtbox
        '
        Me.ProductID_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductID_txtbox.Location = New System.Drawing.Point(28, 139)
        Me.ProductID_txtbox.Name = "ProductID_txtbox"
        Me.ProductID_txtbox.ReadOnly = True
        Me.ProductID_txtbox.Size = New System.Drawing.Size(449, 24)
        Me.ProductID_txtbox.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.LightGreen
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 18)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "4. Product Status"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGreen
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 18)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "3. Product Unit Price (RM)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightGreen
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "2. Product Name"
        '
        'Update_btn
        '
        Me.Update_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Update_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_btn.Location = New System.Drawing.Point(373, 543)
        Me.Update_btn.Name = "Update_btn"
        Me.Update_btn.Size = New System.Drawing.Size(104, 34)
        Me.Update_btn.TabIndex = 69
        Me.Update_btn.Text = "Update"
        Me.Update_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGreen
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "1. Product ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LightGreen
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(24, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(411, 60)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Note :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You are not allowed to modify/update Menu's Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "except Product S" & _
    "tatus."
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'Kitchen_Use
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ProductStatus_CB)
        Me.Controls.Add(Me.UnitPrice_txtbox)
        Me.Controls.Add(Me.ProductName_txtbox)
        Me.Controls.Add(Me.ProductID_txtbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Update_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Welcome_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LogOut_btn)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Kitchen_Use"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant_Menu"
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LogOut_btn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Welcome_lbl As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SearchDessert_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDessert_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Dessert_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SearchDrink_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDrink_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Drink_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SearchFood_btn As System.Windows.Forms.Button
    Friend WithEvents SearchFood_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Food_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ProductStatus_CB As System.Windows.Forms.ComboBox
    Friend WithEvents UnitPrice_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents ProductName_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents ProductID_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Update_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FosdatabaseDataSet As Workshop_InProgress.fosdatabaseDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter
    Friend WithEvents MenuIDDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
