Imports MySql.Data.MySqlClient

Public Class Manager_Use
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim MenuID_COMMAND As MySqlCommand
    Dim OrderMenu_COMMAND As MySqlCommand
    Dim Amount_COMMAND As MySqlCommand
    Dim Show_COMMAND As MySqlCommand

    Dim charactersAllowed As String = "T1234567890"
    Dim charactersAllowed1 As String = "KCSMNGWT1234567890"
    Dim charactersAllowed2 As String = "FDS1234567890"

    Private Sub Manager_Use_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTime_timer.Start()
        DateTime_lbl.Text = Date.Now

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Staff_Name from fosdatabase.staff where Staff_ID='" & Login_Page.Username_txtbox.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim full_name As String = ""

            While READER.Read
                full_name = READER.GetString("Staff_Name")
            End While

            Welcome_lbl.Text = "Welcome " & full_name

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Load_Login()
        Load_MenuTable()
        Load_RTable()
    End Sub

    Private Sub Load_RTable()
        'TODO: This line of code loads data into the 'FosdatabaseDataSet.table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.FosdatabaseDataSet.table)
        Dim tableinfo As DataRow
        SearchTable_txtbox.AutoCompleteCustomSource.Clear()
        For Each tableinfo In FosdatabaseDataSet.table.Rows
            SearchTable_txtbox.AutoCompleteCustomSource.Add(tableinfo.Item("Table_ID").ToString)
        Next
    End Sub

    Private Sub Load_Login()
        'TODO: This line of code loads data into the 'FosdatabaseDataSet.staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.FosdatabaseDataSet.staff)
        Dim logininfo As DataRow
        SearchAccount_txtbox.AutoCompleteCustomSource.Clear()
        For Each logininfo In FosdatabaseDataSet.staff.Rows
            SearchAccount_txtbox.AutoCompleteCustomSource.Add(logininfo.Item("Staff_ID").ToString)
        Next
    End Sub

    Private Sub Load_MenuTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim FoodDataSet As New DataTable
        Dim DrinkDataSet As New DataTable
        Dim DessertDataSet As New DataTable

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Dim SDA1 As New MySqlDataAdapter
        Dim bSource1 As New BindingSource

        Dim SDA2 As New MySqlDataAdapter
        Dim bSource2 As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from fosdatabase.menu where Menu_ID Like 'F%'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(FoodDataSet)
            bSource.DataSource = FoodDataSet
            Food_DGV.DataSource = bSource
            SDA.Update(FoodDataSet)
            MysqlConn.Close()

            MysqlConn.Open()
            Dim Query1 As String
            Query1 = "select * from fosdatabase.menu where Menu_ID Like 'D%'"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            SDA1.SelectCommand = COMMAND
            SDA1.Fill(DrinkDataSet)
            bSource1.DataSource = DrinkDataSet
            Drink_DGV.DataSource = bSource1
            SDA1.Update(DrinkDataSet)
            MysqlConn.Close()

            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "select * from fosdatabase.menu where Menu_ID Like 'S%'"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            SDA2.SelectCommand = COMMAND
            SDA2.Fill(DessertDataSet)
            bSource2.DataSource = DessertDataSet
            Dessert_DGV.DataSource = bSource2
            SDA2.Update(DessertDataSet)
            MysqlConn.Close()

            Dim r As DataRow
            Dim s As DataRow
            Dim t As DataRow
            SearchFood_txtbox.AutoCompleteCustomSource.Clear()
            SearchDrink_txtbox.AutoCompleteCustomSource.Clear()
            SearchDessert_txtbox.AutoCompleteCustomSource.Clear()
            For Each t In FoodDataSet.Rows
                SearchFood_txtbox.AutoCompleteCustomSource.Add(t.Item("Menu_ID").ToString)
            Next
            For Each s In DrinkDataSet.Rows
                SearchDrink_txtbox.AutoCompleteCustomSource.Add(s.Item("Menu_ID").ToString)
            Next
            For Each r In DessertDataSet.Rows
                SearchDessert_txtbox.AutoCompleteCustomSource.Add(r.Item("Menu_ID").ToString)
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub DateTimeTimer(sender As Object, e As EventArgs) Handles DateTime_timer.Tick
        DateTime_lbl.Text = Date.Now
    End Sub

    Private Sub LogOutButton(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            Me.Close()
            Login_Page.Show()
            Login_Page.Username_txtbox.Text = Nothing
            Login_Page.Password_txtbox.Text = Nothing
        End If
    End Sub

    Private Sub CreateButton(sender As Object, e As EventArgs) Handles CreateAccount_btn.Click
        If UserTypeLvl_CB.SelectedIndex = -1 And FullName_txtbox.Text = "" And Username_txtbox.Text = "" And Password_txtbox.Text = "" Then
            MsgBox("Some data is missing. Please check again.", vbEmpty, "Problem Occur")
        ElseIf UserTypeLvl_CB.SelectedIndex = -1 Or FullName_txtbox.Text = "" Or Username_txtbox.Text = "" Or Password_txtbox.Text = "" Then
            MsgBox("Some data is missing. Please check again.", vbEmpty, "Problem Occur")
        Else
            If Password_txtbox.Text = Retype_txtbox.Text Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader
                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Insert into fosdatabase.staff (Staff_ID,Staff_Name,Staff_Position,Password) values ('" & Username_txtbox.Text & "' , '" & FullName_txtbox.Text & "' , '" & UserTypeLvl_CB.Text & "' , '" & Password_txtbox.Text & "')"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Data Saved.")
                    MysqlConn.Close()

                    UserTypeLvl_CB.SelectedIndex = -1
                    FullName_txtbox.Text = ""
                    Username_txtbox.Text = ""
                    Password_txtbox.Text = ""
                    ShowHidePassword_CheckBox.Checked = False
                    ShowHidePassword_CheckBox1.Checked = False

                Catch ex As MySqlException
                    MsgBox("The Staff ID already exist.", vbExclamation, "Checked")
                    Username_txtbox.Text = ""
                Finally
                    MysqlConn.Dispose()
                End Try

                Load_Login()
                Wrong_lbl.Visible = False
                Retype_txtbox.BackColor = Color.White
                Retype_txtbox.Clear()
            Else
                MsgBox("Password not match.", vbEmpty, "Problem Occur")
                Wrong_lbl.Visible = True
                Retype_txtbox.BackColor = Color.Red
                Retype_txtbox.Clear()
            End If
        End If
    End Sub

    Private Sub ClearButton(sender As Object, e As EventArgs) Handles ClearAccount_btn.Click
        If UserTypeLvl_CB.SelectedIndex = -1 Or FullName_txtbox.Text = "" Or Username_txtbox.Text = "" Or Password_txtbox.Text = "" Or Retype_txtbox.Text = "" Then
            'do ntg
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Confirm clear the data?", "Clear", MessageBoxButtons.OKCancel)
            If ask = DialogResult.OK Then
                UserTypeLvl_CB.SelectedIndex = -1
                FullName_txtbox.Text = ""
                Username_txtbox.Text = ""
                Password_txtbox.Text = ""
                Retype_txtbox.Text = ""
            End If
        End If
    End Sub

    Private Sub UpdateButton(sender As Object, e As EventArgs) Handles UpdateAccount_btn.Click
        If Username_txtbox2.Text = "" Then
            MsgBox("Enter a Staff ID in search box.", vbEmpty, "Problem Occur")
        Else
            If FullName_txtbox2.Text = "" Or Password_txtbox2.Text = "" Or Retype_txtbox1.Text = "" Then
                MsgBox("Some data is missing. Please check again.", vbEmpty, "Problem Occur")
            Else
                If Password_txtbox2.Text = Retype_txtbox1.Text Then
                    MysqlConn = New MySqlConnection
                    MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                    Dim READER As MySqlDataReader

                    Try
                        MysqlConn.Open()
                        Dim Query As String
                        Query = "Update fosdatabase.staff set Staff_Name = '" & FullName_txtbox2.Text & "', Password = '" & Password_txtbox2.Text & "' where Staff_ID = '" & Username_txtbox2.Text & "'"

                        COMMAND = New MySqlCommand(Query, MysqlConn)
                        READER = COMMAND.ExecuteReader

                        MessageBox.Show("Data Updated.")
                        MysqlConn.Close()

                        SearchAccount_txtbox.Text = ""
                        UserTypeLvl_txtbox2.Text = ""
                        FullName_txtbox2.Text = ""
                        Username_txtbox2.Text = ""
                        Password_txtbox2.Text = ""
                        ShowHidePasssword_CheckBox2.Checked = False
                        ShowHidePasssword_CheckBox3.Checked = False

                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message)
                    Finally
                        MysqlConn.Dispose()
                    End Try

                    Me.StaffTableAdapter.Fill(Me.FosdatabaseDataSet.staff)
                    Wrong_lbl1.Visible = False
                    Retype_txtbox1.BackColor = Color.White
                    Retype_txtbox1.Clear()
                Else
                    MsgBox("Password not match.", vbEmpty, "Problem Occur")
                    Wrong_lbl1.Visible = True
                    Retype_txtbox1.BackColor = Color.Red
                    Retype_txtbox1.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub DeleteButton(sender As Object, e As EventArgs) Handles DeleteAccount_btn.Click
        If Username_txtbox2.Text = "" Then
            MsgBox("Enter a Staff ID in search box.", vbEmpty, "Problem Occur")
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.OKCancel)

            If ask = DialogResult.OK Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Delete from fosdatabase.staff where Staff_ID = '" & Username_txtbox2.Text & "'"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Data Deleted.")
                    MysqlConn.Close()

                    SearchAccount_txtbox.Text = ""
                    UserTypeLvl_txtbox2.Text = ""
                    FullName_txtbox2.Text = ""
                    Username_txtbox2.Text = ""
                    Password_txtbox2.Text = ""

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

                Me.StaffTableAdapter.Fill(Me.FosdatabaseDataSet.staff)
            End If
        End If
    End Sub

    Private Sub SearchButton(sender As Object, e As EventArgs) Handles SearchAccount_btn.Click
        If SearchAccount_txtbox.Text = "" Then
            MsgBox("Enter a Staff ID.", vbInformation, "Search")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String

                Query = "Select *from fosdatabase.staff where Staff_ID ='" & SearchAccount_txtbox.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                While READER.Read
                    UserTypeLvl_txtbox2.Text = READER.GetString("Staff_Position")
                    FullName_txtbox2.Text = READER.GetString("Staff_Name")
                    Username_txtbox2.Text = READER.GetString("Staff_ID")
                    Password_txtbox2.Text = READER.GetInt32("Password")
                End While
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub AccountListDGV(sender As Object, e As DataGridViewCellEventArgs) Handles AccountList_DGV.CellContentClick
        Dim i As Integer = AccountList_DGV.CurrentRow.Index
        Me.UserTypeLvl_txtbox2.Text = AccountList_DGV.Item(2, i).Value
        Me.FullName_txtbox2.Text = AccountList_DGV.Item(1, i).Value
        Me.Username_txtbox2.Text = AccountList_DGV.Item(0, i).Value
        Me.Password_txtbox2.Text = AccountList_DGV.Item(3, i).Value
    End Sub

    Private Sub ShowHidePasswordCheckBox(sender As Object, e As EventArgs) Handles ShowHidePassword_CheckBox.CheckedChanged
        If ShowHidePassword_CheckBox.CheckState = CheckState.Checked Then
            Password_txtbox.PasswordChar = ""
        Else
            Password_txtbox.PasswordChar = "*"
        End If
    End Sub

    Private Sub ShowHidePasswordCheckBox2(sender As Object, e As EventArgs) Handles ShowHidePasssword_CheckBox2.CheckedChanged
        If ShowHidePasssword_CheckBox2.CheckState = CheckState.Checked Then
            Password_txtbox2.PasswordChar = ""
        Else
            Password_txtbox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub AddProductButton(sender As Object, e As EventArgs) Handles AddProduct_btn.Click
        If ProductID_txtbox.Text = "" Or ProductName_txtbox.Text = "" Or UnitPrice_txtbox.Text = "" Or ProductStatus_CB.SelectedIndex = -1 Then
            MsgBox("Some data is missing. Please check again.", vbEmpty, "Problem Occur")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into fosdatabase.menu (Menu_ID, Menu_Name, Unit_Price, Menu_Status) values ('" & ProductID_txtbox.Text & "' , '" & ProductName_txtbox.Text & "' , '" & UnitPrice_txtbox.Text & "' , '" & ProductStatus_CB.Text & "')"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data Saved.")
                MysqlConn.Close()

                ProductID_txtbox.Text = ""
                ProductName_txtbox.Text = ""
                UnitPrice_txtbox.Text = ""
                ProductStatus_CB.SelectedIndex = -1
                SearchFood_txtbox.Text = ""
                SearchDrink_txtbox.Text = ""
                SearchDessert_txtbox.Text = ""

            Catch ex As MySqlException
                MsgBox("The Product ID already exist.", vbExclamation, "Checked")
                ProductID_txtbox.Text = ""
            Finally
                MysqlConn.Dispose()
            End Try

            Load_MenuTable()
        End If
    End Sub

    Private Sub ClearProductButton(sender As Object, e As EventArgs) Handles ClearProduct_btn.Click
        If ProductID_txtbox.Text = "" Or ProductName_txtbox.Text = "" Or UnitPrice_txtbox.Text = "" Or ProductStatus_CB.SelectedIndex = -1 Then
            'do ntg
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Confirm clear the data?", "Clear", MessageBoxButtons.OKCancel)
            If ask = DialogResult.OK Then
                ProductID_txtbox.Text = ""
                ProductName_txtbox.Text = ""
                UnitPrice_txtbox.Text = ""
                ProductStatus_CB.SelectedIndex = -1
            End If
        End If

        If ProductID_txtbox.Text = "" Then
            AddProduct_btn.Visible = True
            UpdateProduct_btn.Visible = False
            DeleteProduct_btn.Visible = False
        End If
    End Sub

    Private Sub UpdateProductButton(sender As Object, e As EventArgs) Handles UpdateProduct_btn.Click
        If ProductID_txtbox.Text = "" Then
            MsgBox("Enter a Product ID in search box.", vbEmpty, "Problem Occur")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update fosdatabase.menu set Menu_ID = '" & ProductID_txtbox.Text & "', Menu_Name = '" & ProductName_txtbox.Text & "', Unit_Price = '" & UnitPrice_txtbox.Text & "', Menu_Status = '" & ProductStatus_CB.Text & "' where Menu_ID = '" & ProductID_txtbox.Text & "'"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data Updated.")
                MysqlConn.Close()

                ProductID_txtbox.Text = ""
                ProductName_txtbox.Text = ""
                UnitPrice_txtbox.Text = ""
                ProductStatus_CB.SelectedIndex = -1
                SearchFood_txtbox.Text = ""
                SearchDrink_txtbox.Text = ""
                SearchDessert_txtbox.Text = ""

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Load_MenuTable()

            UpdateProduct_btn.Visible = False
            DeleteProduct_btn.Visible = False
            AddProduct_btn.Visible = True
        End If
    End Sub

    Private Sub DeleteProductButton(sender As Object, e As EventArgs) Handles DeleteProduct_btn.Click
        If ProductID_txtbox.Text = "" Then
            MsgBox("Enter a Product ID in search box.", vbEmpty, "Problem Occur")
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.OKCancel)

            If ask = DialogResult.OK Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Delete from fosdatabase.menu where Menu_ID = '" & ProductID_txtbox.Text & "'"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Data Deleted.")
                    MysqlConn.Close()

                    ProductID_txtbox.Text = ""
                    ProductName_txtbox.Text = ""
                    UnitPrice_txtbox.Text = ""
                    ProductStatus_CB.SelectedIndex = -1
                    SearchFood_txtbox.Text = ""
                    SearchDrink_txtbox.Text = ""
                    SearchDessert_txtbox.Text = ""

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

                Load_MenuTable()

                UpdateProduct_btn.Visible = False
                DeleteProduct_btn.Visible = False
                AddProduct_btn.Visible = True
            End If
        End If
    End Sub

    Private Sub FoodDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Food_DGV.CellContentClick
        Dim i As Integer = Food_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Food_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Food_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Food_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Food_DGV.Item(3, i).Value

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = False
    End Sub

    Private Sub DrinkDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Drink_DGV.CellContentClick
        Dim i As Integer = Drink_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Drink_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Drink_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Drink_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Drink_DGV.Item(3, i).Value

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = False
    End Sub

    Private Sub DessertDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Dessert_DGV.CellContentClick
        Dim i As Integer = Dessert_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Dessert_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Dessert_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Dessert_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Dessert_DGV.Item(3, i).Value

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = False
    End Sub

    Private Sub SearchFoodButton(sender As Object, e As EventArgs) Handles SearchFood_btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select *from fosdatabase.menu where Menu_ID ='" & SearchFood_txtbox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                ProductID_txtbox.Text = READER.GetString("Menu_ID")
                ProductName_txtbox.Text = READER.GetString("Menu_Name")
                UnitPrice_txtbox.Text = READER.GetDecimal("Unit_Price")
                ProductStatus_CB.Text = READER.GetString("Menu_Status")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = True
    End Sub

    Private Sub SearchDrink_btn_Click(sender As Object, e As EventArgs) Handles SearchDrink_btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select *from fosdatabase.menu where Menu_ID ='" & SearchDrink_txtbox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                ProductID_txtbox.Text = READER.GetString("Menu_ID")
                ProductName_txtbox.Text = READER.GetString("Menu_Name")
                UnitPrice_txtbox.Text = READER.GetDecimal("Unit_Price")
                ProductStatus_CB.Text = READER.GetString("Menu_Status")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = True
    End Sub

    Private Sub SearchDessert_btn_Click(sender As Object, e As EventArgs) Handles SearchDessert_btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select *from fosdatabase.menu where Menu_ID ='" & SearchDessert_txtbox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                ProductID_txtbox.Text = READER.GetString("Menu_ID")
                ProductName_txtbox.Text = READER.GetString("Menu_Name")
                UnitPrice_txtbox.Text = READER.GetDecimal("Unit_Price")
                ProductStatus_CB.Text = READER.GetString("Menu_Status")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        UpdateProduct_btn.Visible = True
        DeleteProduct_btn.Visible = True
        AddProduct_btn.Visible = True
    End Sub

    Private Sub AddTableButton(sender As Object, e As EventArgs) Handles AddTable_btn.Click
        If TableNo_txtbox.Text = "" Or Capacity_txtbox.Text = "" Or TableStatus_CB.SelectedIndex = -1 Then
            MsgBox("Some data is missing. Please check again.", vbEmpty, "Problem Occur")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Insert into fosdatabase.table (Table_ID, Capacity, Table_Status) values ('" & TableNo_txtbox.Text & "' , '" & Capacity_txtbox.Text & "' , '" & TableStatus_CB.Text & "')"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data Saved.")
                MysqlConn.Close()

                TableNo_txtbox.Text = ""
                Capacity_txtbox.Text = ""
                TableStatus_CB.SelectedIndex = -1

            Catch ex As MySqlException
                MsgBox("The Table ID already exist.", vbExclamation, "Checked")
                TableNo_txtbox.Text = ""
            Finally
                MysqlConn.Dispose()
            End Try

            Load_RTable()
        End If
    End Sub

    Private Sub UpdateTableButton(sender As Object, e As EventArgs) Handles UpdateTable_btn.Click
        If TableNo_txtbox.Text = "" Then
            MsgBox("Enter a Product ID in search box.", vbEmpty, "Problem Occur")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update fosdatabase.table set Table_ID = '" & TableNo_txtbox.Text & "', Capacity = '" & Capacity_txtbox.Text & "', Table_Status = '" & TableStatus_CB.Text & "' where Table_ID = '" & TableNo_txtbox.Text & "'"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Data Updated.")
                MysqlConn.Close()

                SearchTable_txtbox.Text = ""
                TableNo_txtbox.Text = ""
                Capacity_txtbox.Text = ""
                TableStatus_CB.SelectedIndex = -1

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Me.TableTableAdapter.Fill(Me.FosdatabaseDataSet.table)

            UpdateTable_btn.Visible = False
            DeleteTable_btn.Visible = False
            AddTable_btn.Visible = True
        End If
    End Sub

    Private Sub DeleteTableButton(sender As Object, e As EventArgs) Handles DeleteTable_btn.Click
        If TableNo_txtbox.Text = "" Then
            MsgBox("Enter a Product ID in search box.", vbEmpty, "Problem Occur")
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.OKCancel)

            If ask = DialogResult.OK Then
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Delete from fosdatabase.table where Table_ID = '" & TableNo_txtbox.Text & "'"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Data Deleted.")
                    MysqlConn.Close()

                    SearchTable_txtbox.Text = ""
                    TableNo_txtbox.Text = ""
                    Capacity_txtbox.Text = ""
                    TableStatus_CB.SelectedIndex = -1

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

                Me.TableTableAdapter.Fill(Me.FosdatabaseDataSet.table)

                UpdateTable_btn.Visible = False
                DeleteTable_btn.Visible = False
                AddTable_btn.Visible = True
            End If
        End If
    End Sub

    Private Sub SearchTableButton(sender As Object, e As EventArgs) Handles SearchTable_btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "Select *from fosdatabase.table where Table_ID='" & SearchTable_txtbox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                TableNo_txtbox.Text = READER.GetString("Table_ID")
                Capacity_txtbox.Text = READER.GetInt32("Capacity")
                TableStatus_CB.Text = READER.GetString("Table_Status")
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        UpdateTable_btn.Visible = True
        DeleteTable_btn.Visible = True
        AddTable_btn.Visible = False
    End Sub

    Private Sub TableDetailDGV(sender As Object, e As DataGridViewCellEventArgs) Handles TableDetail_DGV.CellContentClick
        Dim i As Integer = TableDetail_DGV.CurrentRow.Index
        Me.TableNo_txtbox.Text = TableDetail_DGV.Item(0, i).Value
        Me.Capacity_txtbox.Text = TableDetail_DGV.Item(1, i).Value
        Me.TableStatus_CB.Text = TableDetail_DGV.Item(2, i).Value

        UpdateTable_btn.Visible = True
        DeleteTable_btn.Visible = True
        AddTable_btn.Visible = False
    End Sub

    Private Sub ClearTableButton(sender As Object, e As EventArgs) Handles ClearTable_btn.Click
        If TableNo_txtbox.Text = "" Or Capacity_txtbox.Text = "" Or TableStatus_CB.SelectedIndex = -1 Then
            'do ntg
        Else
            Dim ask As DialogResult
            ask = MessageBox.Show("Confirm clear the data?", "Clear", MessageBoxButtons.OKCancel)
            If ask = DialogResult.OK Then
                TableNo_txtbox.Text = ""
                Capacity_txtbox.Text = ""
                TableStatus_CB.SelectedIndex = -1
            End If
        End If

        If TableNo_txtbox.Text = "" Then
            AddTable_btn.Visible = True
            UpdateTable_btn.Visible = False
            DeleteTable_btn.Visible = False
        End If
    End Sub

    Private Sub Load_BestSellingMenu_Table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim BSM_DataSet As New DataTable
        Dim BSM_SDA As New MySqlDataAdapter
        Dim BSM_bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select o.Table_ID as 'Table ID' , o.Order_ID as 'Order ID' , od.Order_Quantity as 'Quantity' , m.Unit_Price*od.Order_Quantity as 'Subprice' from fosdatabase.order o , fosdatabase.order_detail od , fosdatabase.menu m where o.order_ID = od.Order_ID and m.menu_ID=od.Menu_ID and o.date='" & Calender_DTP.Text & "' and o.Order_Status='Paid' and od.Menu_ID='" & PopularMenuID_txtbox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            BSM_SDA.SelectCommand = COMMAND
            BSM_SDA.Fill(BSM_DataSet)
            BSM_bSource.DataSource = BSM_DataSet
            BestSellingMenuDetail_DGV.DataSource = BSM_bSource
            BSM_SDA.Update(BSM_DataSet)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub sumAmount()
        Dim MysqlConn As New MySqlConnection
        Dim Amount_COMMAND As New MySqlCommand
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"
        Amount_COMMAND.Connection = MysqlConn
        Try

            MysqlConn.Open()
            Amount_COMMAND.CommandText = "select SUM(m.Unit_Price*od.Order_Quantity) from fosdatabase.order o , fosdatabase.order_detail od , fosdatabase.menu m where o.order_ID = od.Order_ID and m.menu_ID=od.Menu_ID and o.date='" & Calender_DTP.Text & "' and o.Order_Status='Paid' and od.Menu_ID='" & PopularMenuID_txtbox.Text & "'"

            If IsDBNull(Amount_COMMAND.ExecuteScalar) Then

            Else
                Dim Subtotal_SHOW As Decimal = Amount_COMMAND.ExecuteScalar()
                TotalAmount_txtbox.Text = "RM " + Subtotal_SHOW.ToString()
            End If
            MysqlConn.Close()
            Amount_COMMAND.Dispose()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BestSellingMenuGraph()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader
        Dim Graph_COMMAND As MySqlCommand

        Try
            MysqlConn.Open()
            Dim Graph_Query As String
            Graph_Query = "SELECT distinct Menu_ID, sum(Order_Quantity) FROM fosdatabase.order_detail od , fosdatabase.order o WHERE od.Order_ID = o.Order_ID And o.Date = '" & Calender_DTP.Text & "' And o.Order_Status = 'Paid' GROUP BY od.Menu_ID order by sum(Order_Quantity) desc limit 5;"
            Graph_COMMAND = New MySqlCommand(Graph_Query, MysqlConn)
            READER = Graph_COMMAND.ExecuteReader
            While READER.Read
                BestSelling_C.Series("Quantity_VS_MenuID").Points.AddXY(READER.GetString("Menu_ID"), READER.GetInt32("sum(Order_Quantity)"))
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CalenderDTP(sender As Object, e As EventArgs) Handles Calender_DTP.ValueChanged
        BestSelling_C.Series("Quantity_VS_MenuID").Points.Clear()
        TotalAmount_txtbox.Text = Format(TotalAmount_txtbox.Text, "0.0")

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim MenuID_Query As String
            MenuID_Query = "SELECT od.Menu_ID, m.Menu_Name, sum(od.Order_Quantity) FROM fosdatabase.order_detail od , fosdatabase.order o , fosdatabase.menu m WHERE od.Order_ID = o.Order_ID And od.Menu_ID = m.Menu_ID And o.Date = '" & Calender_DTP.Text & "' And o.Order_Status = 'Paid' GROUP BY od.Menu_ID Order BY sum(Order_Quantity) desc limit 1 "
            MenuID_COMMAND = New MySqlCommand(MenuID_Query, MysqlConn)
            READER = MenuID_COMMAND.ExecuteReader
            Dim MenuID As String = Nothing
            Dim MenuName As String = Nothing
            Dim Quantity As Integer
            While READER.Read
                MenuID = READER.GetString("Menu_ID")
                MenuName = READER.GetString("Menu_Name")
                Quantity = READER.GetInt32("sum(od.Order_Quantity)")
            End While
            MysqlConn.Close()
            PopularMenuID_txtbox.Text = MenuID
            MenuName_txtbox.Text = MenuName
            TotalQuantity_txtbox.Text = Quantity

            sumAmount()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Load_BestSellingMenu_Table()
        BestSellingMenuGraph()
    End Sub

    Private Sub DailySalesButton(sender As Object, e As EventArgs) Handles DailySales_btn.Click
        Daily_Sales_Report.Show()
    End Sub

    Private Sub Username_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Username_txtbox.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Username_txtbox.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub ProductID_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProductID_txtbox.KeyPress
        If Char.IsLower(e.KeyChar) Then
            ProductID_txtbox.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub TableNo_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TableNo_txtbox.KeyPress
        If Char.IsLower(e.KeyChar) Then
            TableNo_txtbox.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub TableNo_txtbox_TextChanged(sender As Object, e As EventArgs) Handles TableNo_txtbox.TextChanged
        Dim theText As String = TableNo_txtbox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = TableNo_txtbox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To TableNo_txtbox.Text.Length - 1
            Letter = TableNo_txtbox.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        TableNo_txtbox.Text = theText
        TableNo_txtbox.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Username_txtbox_TextChanged(sender As Object, e As EventArgs) Handles Username_txtbox.TextChanged
        Dim theText As String = Username_txtbox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = Username_txtbox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To Username_txtbox.Text.Length - 1
            Letter = Username_txtbox.Text.Substring(x, 1)
            If charactersAllowed1.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        Username_txtbox.Text = theText
        Username_txtbox.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub ProductID_txtbox_TextChanged(sender As Object, e As EventArgs) Handles ProductID_txtbox.TextChanged
        Dim theText As String = ProductID_txtbox.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = ProductID_txtbox.SelectionStart
        Dim Change As Integer

        For x As Integer = 0 To ProductID_txtbox.Text.Length - 1
            Letter = ProductID_txtbox.Text.Substring(x, 1)
            If charactersAllowed2.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                Change = 1
            End If
        Next

        ProductID_txtbox.Text = theText
        ProductID_txtbox.Select(SelectionIndex - Change, 0)
    End Sub

    Private Sub Password_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub UnitPrice_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UnitPrice_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub Capacity_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Capacity_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub ShowHidePassword_CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHidePassword_CheckBox1.CheckedChanged
        If ShowHidePassword_CheckBox1.CheckState = CheckState.Checked Then
            Retype_txtbox.PasswordChar = ""
        Else
            Retype_txtbox.PasswordChar = "*"
        End If
    End Sub

    Private Sub Retype_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Retype_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub ShowHidePasssword_CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles ShowHidePasssword_CheckBox3.CheckedChanged
        If ShowHidePasssword_CheckBox2.CheckState = CheckState.Checked Then
            Retype_txtbox1.PasswordChar = ""
        Else
            Retype_txtbox1.PasswordChar = "*"
        End If
    End Sub

    Private Sub Password_txtbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password_txtbox2.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub Retype_txtbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Retype_txtbox1.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

End Class