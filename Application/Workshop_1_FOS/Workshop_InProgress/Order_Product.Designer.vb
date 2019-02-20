<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Product
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
        Me.SaveExit_btn = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AddDessert_btn1 = New System.Windows.Forms.Button()
        Me.SearchDessert_btn = New System.Windows.Forms.Button()
        Me.SearchDessert_txtbox = New System.Windows.Forms.TextBox()
        Me.AddDessert_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DessertQuantity_NUD = New System.Windows.Forms.NumericUpDown()
        Me.Dessert_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FosdatabaseDataSet = New Workshop_InProgress.fosdatabaseDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.AddDrink_btn1 = New System.Windows.Forms.Button()
        Me.SearchDrink_btn = New System.Windows.Forms.Button()
        Me.SearchDrink_txtbox = New System.Windows.Forms.TextBox()
        Me.AddDrink_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DrinkQuantity_NUD = New System.Windows.Forms.NumericUpDown()
        Me.Drink_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AddFood_btn1 = New System.Windows.Forms.Button()
        Me.SearchFood_btn = New System.Windows.Forms.Button()
        Me.SearchFood_txtbox = New System.Windows.Forms.TextBox()
        Me.AddFood_btn = New System.Windows.Forms.Button()
        Me.Food_DGV = New System.Windows.Forms.DataGridView()
        Me.MenuIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity_lb = New System.Windows.Forms.Label()
        Me.FoodQuantity_NUD = New System.Windows.Forms.NumericUpDown()
        Me.Menu_TC = New System.Windows.Forms.TabControl()
        Me.MenuTableAdapter = New Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter()
        Me.SaveExit_btn1 = New System.Windows.Forms.Button()
        Me.TabPage3.SuspendLayout()
        CType(Me.DessertQuantity_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DrinkQuantity_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodQuantity_NUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_TC.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveExit_btn
        '
        Me.SaveExit_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SaveExit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveExit_btn.Location = New System.Drawing.Point(625, 558)
        Me.SaveExit_btn.Name = "SaveExit_btn"
        Me.SaveExit_btn.Size = New System.Drawing.Size(111, 32)
        Me.SaveExit_btn.TabIndex = 35
        Me.SaveExit_btn.Text = "Exit"
        Me.SaveExit_btn.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AddDessert_btn1)
        Me.TabPage3.Controls.Add(Me.SearchDessert_btn)
        Me.TabPage3.Controls.Add(Me.SearchDessert_txtbox)
        Me.TabPage3.Controls.Add(Me.AddDessert_btn)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.DessertQuantity_NUD)
        Me.TabPage3.Controls.Add(Me.Dessert_DGV)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(726, 511)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Desserts"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AddDessert_btn1
        '
        Me.AddDessert_btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddDessert_btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDessert_btn1.Location = New System.Drawing.Point(609, 473)
        Me.AddDessert_btn1.Name = "AddDessert_btn1"
        Me.AddDessert_btn1.Size = New System.Drawing.Size(111, 32)
        Me.AddDessert_btn1.TabIndex = 43
        Me.AddDessert_btn1.Text = "Add Order"
        Me.AddDessert_btn1.UseVisualStyleBackColor = False
        '
        'SearchDessert_btn
        '
        Me.SearchDessert_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchDessert_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDessert_btn.Location = New System.Drawing.Point(636, 6)
        Me.SearchDessert_btn.Name = "SearchDessert_btn"
        Me.SearchDessert_btn.Size = New System.Drawing.Size(84, 28)
        Me.SearchDessert_btn.TabIndex = 42
        Me.SearchDessert_btn.Text = "Search"
        Me.SearchDessert_btn.UseVisualStyleBackColor = False
        '
        'SearchDessert_txtbox
        '
        Me.SearchDessert_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchDessert_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchDessert_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDessert_txtbox.Location = New System.Drawing.Point(452, 6)
        Me.SearchDessert_txtbox.Name = "SearchDessert_txtbox"
        Me.SearchDessert_txtbox.Size = New System.Drawing.Size(173, 26)
        Me.SearchDessert_txtbox.TabIndex = 41
        '
        'AddDessert_btn
        '
        Me.AddDessert_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddDessert_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDessert_btn.Location = New System.Drawing.Point(609, 473)
        Me.AddDessert_btn.Name = "AddDessert_btn"
        Me.AddDessert_btn.Size = New System.Drawing.Size(111, 32)
        Me.AddDessert_btn.TabIndex = 40
        Me.AddDessert_btn.Text = "Add Order"
        Me.AddDessert_btn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 479)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Quantity :"
        '
        'DessertQuantity_NUD
        '
        Me.DessertQuantity_NUD.BackColor = System.Drawing.SystemColors.Window
        Me.DessertQuantity_NUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DessertQuantity_NUD.Location = New System.Drawing.Point(85, 477)
        Me.DessertQuantity_NUD.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.DessertQuantity_NUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DessertQuantity_NUD.Name = "DessertQuantity_NUD"
        Me.DessertQuantity_NUD.Size = New System.Drawing.Size(76, 26)
        Me.DessertQuantity_NUD.TabIndex = 38
        Me.DessertQuantity_NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DessertQuantity_NUD.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.DessertQuantity_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Dessert_DGV
        '
        Me.Dessert_DGV.AllowUserToAddRows = False
        Me.Dessert_DGV.AllowUserToDeleteRows = False
        Me.Dessert_DGV.AutoGenerateColumns = False
        Me.Dessert_DGV.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.Dessert_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dessert_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn2, Me.MenuNameDataGridViewTextBoxColumn2, Me.UnitPriceDataGridViewTextBoxColumn2, Me.MenuStatusDataGridViewTextBoxColumn2})
        Me.Dessert_DGV.DataSource = Me.MenuBindingSource
        Me.Dessert_DGV.Location = New System.Drawing.Point(5, 40)
        Me.Dessert_DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.Dessert_DGV.MultiSelect = False
        Me.Dessert_DGV.Name = "Dessert_DGV"
        Me.Dessert_DGV.ReadOnly = True
        Me.Dessert_DGV.RowHeadersVisible = False
        Me.Dessert_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dessert_DGV.Size = New System.Drawing.Size(715, 426)
        Me.Dessert_DGV.TabIndex = 3
        '
        'MenuIDDataGridViewTextBoxColumn2
        '
        Me.MenuIDDataGridViewTextBoxColumn2.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn2.HeaderText = "Dessert ID"
        Me.MenuIDDataGridViewTextBoxColumn2.Name = "MenuIDDataGridViewTextBoxColumn2"
        Me.MenuIDDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn2.Width = 135
        '
        'MenuNameDataGridViewTextBoxColumn2
        '
        Me.MenuNameDataGridViewTextBoxColumn2.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn2.HeaderText = "Dessert Name"
        Me.MenuNameDataGridViewTextBoxColumn2.Name = "MenuNameDataGridViewTextBoxColumn2"
        Me.MenuNameDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn2.Width = 257
        '
        'UnitPriceDataGridViewTextBoxColumn2
        '
        Me.UnitPriceDataGridViewTextBoxColumn2.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn2.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn2.Name = "UnitPriceDataGridViewTextBoxColumn2"
        Me.UnitPriceDataGridViewTextBoxColumn2.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn2.Width = 165
        '
        'MenuStatusDataGridViewTextBoxColumn2
        '
        Me.MenuStatusDataGridViewTextBoxColumn2.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn2.HeaderText = "Dessert Status"
        Me.MenuStatusDataGridViewTextBoxColumn2.Name = "MenuStatusDataGridViewTextBoxColumn2"
        Me.MenuStatusDataGridViewTextBoxColumn2.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn2.Width = 155
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.AddDrink_btn1)
        Me.TabPage2.Controls.Add(Me.SearchDrink_btn)
        Me.TabPage2.Controls.Add(Me.SearchDrink_txtbox)
        Me.TabPage2.Controls.Add(Me.AddDrink_btn)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DrinkQuantity_NUD)
        Me.TabPage2.Controls.Add(Me.Drink_DGV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(726, 511)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Drinks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'AddDrink_btn1
        '
        Me.AddDrink_btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddDrink_btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrink_btn1.Location = New System.Drawing.Point(609, 473)
        Me.AddDrink_btn1.Name = "AddDrink_btn1"
        Me.AddDrink_btn1.Size = New System.Drawing.Size(111, 32)
        Me.AddDrink_btn1.TabIndex = 43
        Me.AddDrink_btn1.Text = "Add Order"
        Me.AddDrink_btn1.UseVisualStyleBackColor = False
        '
        'SearchDrink_btn
        '
        Me.SearchDrink_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchDrink_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrink_btn.Location = New System.Drawing.Point(636, 6)
        Me.SearchDrink_btn.Name = "SearchDrink_btn"
        Me.SearchDrink_btn.Size = New System.Drawing.Size(84, 28)
        Me.SearchDrink_btn.TabIndex = 42
        Me.SearchDrink_btn.Text = "Search"
        Me.SearchDrink_btn.UseVisualStyleBackColor = False
        '
        'SearchDrink_txtbox
        '
        Me.SearchDrink_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchDrink_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchDrink_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDrink_txtbox.Location = New System.Drawing.Point(452, 6)
        Me.SearchDrink_txtbox.Name = "SearchDrink_txtbox"
        Me.SearchDrink_txtbox.Size = New System.Drawing.Size(173, 26)
        Me.SearchDrink_txtbox.TabIndex = 41
        '
        'AddDrink_btn
        '
        Me.AddDrink_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddDrink_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrink_btn.Location = New System.Drawing.Point(609, 473)
        Me.AddDrink_btn.Name = "AddDrink_btn"
        Me.AddDrink_btn.Size = New System.Drawing.Size(111, 32)
        Me.AddDrink_btn.TabIndex = 40
        Me.AddDrink_btn.Text = "Add Order"
        Me.AddDrink_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 479)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Quantity :"
        '
        'DrinkQuantity_NUD
        '
        Me.DrinkQuantity_NUD.BackColor = System.Drawing.SystemColors.Window
        Me.DrinkQuantity_NUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DrinkQuantity_NUD.Location = New System.Drawing.Point(85, 477)
        Me.DrinkQuantity_NUD.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.DrinkQuantity_NUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DrinkQuantity_NUD.Name = "DrinkQuantity_NUD"
        Me.DrinkQuantity_NUD.Size = New System.Drawing.Size(76, 26)
        Me.DrinkQuantity_NUD.TabIndex = 38
        Me.DrinkQuantity_NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DrinkQuantity_NUD.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.DrinkQuantity_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Drink_DGV
        '
        Me.Drink_DGV.AllowUserToAddRows = False
        Me.Drink_DGV.AllowUserToDeleteRows = False
        Me.Drink_DGV.AutoGenerateColumns = False
        Me.Drink_DGV.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.Drink_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Drink_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn1, Me.MenuNameDataGridViewTextBoxColumn1, Me.UnitPriceDataGridViewTextBoxColumn1, Me.MenuStatusDataGridViewTextBoxColumn1})
        Me.Drink_DGV.DataSource = Me.MenuBindingSource
        Me.Drink_DGV.Location = New System.Drawing.Point(5, 40)
        Me.Drink_DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.Drink_DGV.MultiSelect = False
        Me.Drink_DGV.Name = "Drink_DGV"
        Me.Drink_DGV.ReadOnly = True
        Me.Drink_DGV.RowHeadersVisible = False
        Me.Drink_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Drink_DGV.Size = New System.Drawing.Size(715, 426)
        Me.Drink_DGV.TabIndex = 3
        '
        'MenuIDDataGridViewTextBoxColumn1
        '
        Me.MenuIDDataGridViewTextBoxColumn1.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn1.FillWeight = 0.1290517!
        Me.MenuIDDataGridViewTextBoxColumn1.HeaderText = "Drink ID"
        Me.MenuIDDataGridViewTextBoxColumn1.Name = "MenuIDDataGridViewTextBoxColumn1"
        Me.MenuIDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn1.Width = 135
        '
        'MenuNameDataGridViewTextBoxColumn1
        '
        Me.MenuNameDataGridViewTextBoxColumn1.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn1.FillWeight = 2.167106!
        Me.MenuNameDataGridViewTextBoxColumn1.HeaderText = "Drink Name"
        Me.MenuNameDataGridViewTextBoxColumn1.Name = "MenuNameDataGridViewTextBoxColumn1"
        Me.MenuNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn1.Width = 257
        '
        'UnitPriceDataGridViewTextBoxColumn1
        '
        Me.UnitPriceDataGridViewTextBoxColumn1.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn1.FillWeight = 369.5432!
        Me.UnitPriceDataGridViewTextBoxColumn1.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn1.Name = "UnitPriceDataGridViewTextBoxColumn1"
        Me.UnitPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn1.Width = 165
        '
        'MenuStatusDataGridViewTextBoxColumn1
        '
        Me.MenuStatusDataGridViewTextBoxColumn1.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn1.FillWeight = 28.16069!
        Me.MenuStatusDataGridViewTextBoxColumn1.HeaderText = "Drink Status"
        Me.MenuStatusDataGridViewTextBoxColumn1.Name = "MenuStatusDataGridViewTextBoxColumn1"
        Me.MenuStatusDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn1.Width = 155
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AddFood_btn1)
        Me.TabPage1.Controls.Add(Me.SearchFood_btn)
        Me.TabPage1.Controls.Add(Me.SearchFood_txtbox)
        Me.TabPage1.Controls.Add(Me.AddFood_btn)
        Me.TabPage1.Controls.Add(Me.Food_DGV)
        Me.TabPage1.Controls.Add(Me.Quantity_lb)
        Me.TabPage1.Controls.Add(Me.FoodQuantity_NUD)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(726, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Foods"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AddFood_btn1
        '
        Me.AddFood_btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddFood_btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFood_btn1.Location = New System.Drawing.Point(609, 473)
        Me.AddFood_btn1.Name = "AddFood_btn1"
        Me.AddFood_btn1.Size = New System.Drawing.Size(111, 32)
        Me.AddFood_btn1.TabIndex = 39
        Me.AddFood_btn1.Text = "Add Order"
        Me.AddFood_btn1.UseVisualStyleBackColor = False
        '
        'SearchFood_btn
        '
        Me.SearchFood_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SearchFood_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFood_btn.Location = New System.Drawing.Point(636, 6)
        Me.SearchFood_btn.Name = "SearchFood_btn"
        Me.SearchFood_btn.Size = New System.Drawing.Size(84, 28)
        Me.SearchFood_btn.TabIndex = 38
        Me.SearchFood_btn.Text = "Search"
        Me.SearchFood_btn.UseVisualStyleBackColor = False
        '
        'SearchFood_txtbox
        '
        Me.SearchFood_txtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SearchFood_txtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchFood_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFood_txtbox.Location = New System.Drawing.Point(452, 6)
        Me.SearchFood_txtbox.Name = "SearchFood_txtbox"
        Me.SearchFood_txtbox.Size = New System.Drawing.Size(173, 26)
        Me.SearchFood_txtbox.TabIndex = 37
        '
        'AddFood_btn
        '
        Me.AddFood_btn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.AddFood_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFood_btn.Location = New System.Drawing.Point(609, 473)
        Me.AddFood_btn.Name = "AddFood_btn"
        Me.AddFood_btn.Size = New System.Drawing.Size(111, 32)
        Me.AddFood_btn.TabIndex = 36
        Me.AddFood_btn.Text = "Add Order"
        Me.AddFood_btn.UseVisualStyleBackColor = False
        '
        'Food_DGV
        '
        Me.Food_DGV.AllowUserToAddRows = False
        Me.Food_DGV.AllowUserToDeleteRows = False
        Me.Food_DGV.AutoGenerateColumns = False
        Me.Food_DGV.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.Food_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Food_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuIDDataGridViewTextBoxColumn, Me.MenuNameDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn, Me.MenuStatusDataGridViewTextBoxColumn})
        Me.Food_DGV.DataSource = Me.MenuBindingSource
        Me.Food_DGV.Location = New System.Drawing.Point(5, 40)
        Me.Food_DGV.Margin = New System.Windows.Forms.Padding(4)
        Me.Food_DGV.MultiSelect = False
        Me.Food_DGV.Name = "Food_DGV"
        Me.Food_DGV.ReadOnly = True
        Me.Food_DGV.RowHeadersVisible = False
        Me.Food_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Food_DGV.Size = New System.Drawing.Size(715, 426)
        Me.Food_DGV.TabIndex = 3
        '
        'MenuIDDataGridViewTextBoxColumn
        '
        Me.MenuIDDataGridViewTextBoxColumn.DataPropertyName = "Menu_ID"
        Me.MenuIDDataGridViewTextBoxColumn.FillWeight = 22.00639!
        Me.MenuIDDataGridViewTextBoxColumn.HeaderText = "Food ID"
        Me.MenuIDDataGridViewTextBoxColumn.Name = "MenuIDDataGridViewTextBoxColumn"
        Me.MenuIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuIDDataGridViewTextBoxColumn.Width = 135
        '
        'MenuNameDataGridViewTextBoxColumn
        '
        Me.MenuNameDataGridViewTextBoxColumn.DataPropertyName = "Menu_Name"
        Me.MenuNameDataGridViewTextBoxColumn.FillWeight = 369.5432!
        Me.MenuNameDataGridViewTextBoxColumn.HeaderText = "Food Name"
        Me.MenuNameDataGridViewTextBoxColumn.Name = "MenuNameDataGridViewTextBoxColumn"
        Me.MenuNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuNameDataGridViewTextBoxColumn.Width = 257
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_Price"
        Me.UnitPriceDataGridViewTextBoxColumn.FillWeight = 4.225227!
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price (RM)"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        Me.UnitPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.UnitPriceDataGridViewTextBoxColumn.Width = 165
        '
        'MenuStatusDataGridViewTextBoxColumn
        '
        Me.MenuStatusDataGridViewTextBoxColumn.DataPropertyName = "Menu_Status"
        Me.MenuStatusDataGridViewTextBoxColumn.FillWeight = 4.225227!
        Me.MenuStatusDataGridViewTextBoxColumn.HeaderText = "Food Status"
        Me.MenuStatusDataGridViewTextBoxColumn.Name = "MenuStatusDataGridViewTextBoxColumn"
        Me.MenuStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuStatusDataGridViewTextBoxColumn.Width = 155
        '
        'Quantity_lb
        '
        Me.Quantity_lb.AutoSize = True
        Me.Quantity_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity_lb.Location = New System.Drawing.Point(6, 479)
        Me.Quantity_lb.Name = "Quantity_lb"
        Me.Quantity_lb.Size = New System.Drawing.Size(76, 20)
        Me.Quantity_lb.TabIndex = 29
        Me.Quantity_lb.Text = "Quantity :"
        '
        'FoodQuantity_NUD
        '
        Me.FoodQuantity_NUD.BackColor = System.Drawing.SystemColors.Window
        Me.FoodQuantity_NUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodQuantity_NUD.Location = New System.Drawing.Point(85, 477)
        Me.FoodQuantity_NUD.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.FoodQuantity_NUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.FoodQuantity_NUD.Name = "FoodQuantity_NUD"
        Me.FoodQuantity_NUD.Size = New System.Drawing.Size(76, 26)
        Me.FoodQuantity_NUD.TabIndex = 30
        Me.FoodQuantity_NUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.FoodQuantity_NUD.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.FoodQuantity_NUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Menu_TC
        '
        Me.Menu_TC.Controls.Add(Me.TabPage1)
        Me.Menu_TC.Controls.Add(Me.TabPage2)
        Me.Menu_TC.Controls.Add(Me.TabPage3)
        Me.Menu_TC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_TC.Location = New System.Drawing.Point(12, 12)
        Me.Menu_TC.Name = "Menu_TC"
        Me.Menu_TC.SelectedIndex = 0
        Me.Menu_TC.Size = New System.Drawing.Size(734, 544)
        Me.Menu_TC.TabIndex = 31
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'SaveExit_btn1
        '
        Me.SaveExit_btn1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SaveExit_btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveExit_btn1.Location = New System.Drawing.Point(625, 558)
        Me.SaveExit_btn1.Name = "SaveExit_btn1"
        Me.SaveExit_btn1.Size = New System.Drawing.Size(111, 32)
        Me.SaveExit_btn1.TabIndex = 36
        Me.SaveExit_btn1.Text = "Exit"
        Me.SaveExit_btn1.UseVisualStyleBackColor = False
        '
        'Order_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(758, 598)
        Me.Controls.Add(Me.SaveExit_btn1)
        Me.Controls.Add(Me.SaveExit_btn)
        Me.Controls.Add(Me.Menu_TC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Order_Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Product"
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DessertQuantity_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dessert_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FosdatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DrinkQuantity_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drink_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Food_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodQuantity_NUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_TC.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveExit_btn As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents SearchDessert_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDessert_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents AddDessert_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DessertQuantity_NUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Dessert_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SearchDrink_btn As System.Windows.Forms.Button
    Friend WithEvents SearchDrink_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents AddDrink_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DrinkQuantity_NUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Drink_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SearchFood_btn As System.Windows.Forms.Button
    Friend WithEvents SearchFood_txtbox As System.Windows.Forms.TextBox
    Friend WithEvents AddFood_btn As System.Windows.Forms.Button
    Friend WithEvents Food_DGV As System.Windows.Forms.DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity_lb As System.Windows.Forms.Label
    Friend WithEvents FoodQuantity_NUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents Menu_TC As System.Windows.Forms.TabControl
    Friend WithEvents FosdatabaseDataSet As Workshop_InProgress.fosdatabaseDataSet
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As Workshop_InProgress.fosdatabaseDataSetTableAdapters.menuTableAdapter
    Friend WithEvents AddFood_btn1 As System.Windows.Forms.Button
    Friend WithEvents AddDrink_btn1 As System.Windows.Forms.Button
    Friend WithEvents AddDessert_btn1 As System.Windows.Forms.Button
    Friend WithEvents SaveExit_btn1 As System.Windows.Forms.Button
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
