Imports MySql.Data.MySqlClient

Public Class Kitchen_Use

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Restaurant_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Staff_Name, Staff_ID from fosdatabase.staff where Staff_ID='" & KitchenLogin.Username_txtbox.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim full_name As String = ""
            Dim userid As String = ""
            While READER.Read
                full_name = READER.GetString("Staff_Name")
                userid = READER.GetString("Staff_ID")
            End While
            Welcome_lbl.Text = "Welcome " & full_name

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Timer1.Start()
        Label5.Text = Date.Now

        Load_table()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Date.Now
    End Sub

    Private Sub Logout_Button7_Click(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            Me.Close()
            KitchenLogin.Close()
            Kitchen_Display.Show()
        End If

    End Sub

    Private Sub Update_Button4_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        If ProductID_txtbox.Text = "" Then
            MsgBox("Enter a Product ID in the search box", vbInformation, "Search")
        Else
            If ProductStatus_CB.Text = "" Then
                MsgBox("No status entered.", vbExclamation, "Update Problem")
            Else
                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim Query As String
                    Query = "Update fosdatabase.menu set Menu_Status = '" & ProductStatus_CB.Text & "' where Menu_ID = '" & ProductID_txtbox.Text & "'"

                    COMMAND = New MySqlCommand(Query, MysqlConn)
                    READER = COMMAND.ExecuteReader

                    MessageBox.Show("Data Updated.")
                    MysqlConn.Close()

                    SearchFood_txtbox.Text = ""
                    ProductID_txtbox.Text = ""
                    ProductName_txtbox.Text = ""
                    UnitPrice_txtbox.Text = ""
                    ProductStatus_CB.Text = ""

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

                Load_table()
            End If
        End If
    End Sub

    Private Sub Load_table()
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

    Private Sub FoodDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Food_DGV.CellContentClick
        Dim i As Integer = Food_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Food_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Food_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Food_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Food_DGV.Item(3, i).Value
    End Sub

    Private Sub DrinkDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Drink_DGV.CellContentClick
        Dim i As Integer = Drink_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Drink_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Drink_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Drink_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Drink_DGV.Item(3, i).Value
    End Sub

    Private Sub DessertDGV(sender As Object, e As DataGridViewCellEventArgs) Handles Dessert_DGV.CellContentClick
        Dim i As Integer = Dessert_DGV.CurrentRow.Index
        Me.ProductID_txtbox.Text = Dessert_DGV.Item(0, i).Value
        Me.ProductName_txtbox.Text = Dessert_DGV.Item(1, i).Value
        Me.UnitPrice_txtbox.Text = Dessert_DGV.Item(2, i).Value
        Me.ProductStatus_CB.Text = Dessert_DGV.Item(3, i).Value
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
    End Sub
End Class