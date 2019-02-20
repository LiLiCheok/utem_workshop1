Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Data
Imports System.Reflection

Public Class Order
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim COMMAND1 As MySqlCommand

    Public Sub TimeIn()
        TimeIn_timer.Start()
        TimeIn_txtbox.Text = TimeOfDay
    End Sub

    Public Sub calculate()
        Dim total As Decimal = 0
        For Each lv As ListViewItem In Ordered_Product_LV.Items
            total += CDec(lv.SubItems(3).Text)
        Next
        Total_txtbox.Text = total
    End Sub

    Private Sub Waiter_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()

            Dim Query As String
            Query = "select Staff_Name, Staff_ID from fosdatabase.staff where Staff_ID ='" & Login_Page.Username_txtbox.Text & "'"

            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            Dim full_name As String = ""
            Dim userid As String = ""
            While READER.Read
                full_name = READER.GetString("Staff_Name")
                userid = READER.GetString("Staff_ID")
            End While
            Welcome_lbl.Text = "Welcome " & full_name
            WaiterID_txtbox.Text = userid

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        DateTime_timer.Start()
        DateTime_lbl.Text = Date.Now

        TimeIn()

        Dim theDate As Date
        theDate = Format(Now(), "short date")
        Date_txtbox.Text = theDate

        autogenerate_no()

        Ordered_Product_LV.Columns.Add("Menu ID", 200, HorizontalAlignment.Left)
        Ordered_Product_LV.Columns.Add("Menu Name", 262, HorizontalAlignment.Left)
        Ordered_Product_LV.Columns.Add("Quantity", 200, HorizontalAlignment.Left)
        Ordered_Product_LV.Columns.Add("Sub-price (RM)", 262, HorizontalAlignment.Left)
    End Sub

    Private Sub DateTimeTime(sender As Object, e As EventArgs) Handles DateTime_timer.Tick
        DateTime_lbl.Text = Date.Now
    End Sub

    Private Sub TimeInTimerTick(sender As Object, e As EventArgs) Handles TimeIn_timer.Tick
        TimeIn_txtbox.Text = TimeOfDay
    End Sub

    Public Sub StopTimeInTimerTextBoxTextChanged(sender As Object, e As EventArgs) Handles TimeIn_txtbox.TextChanged
        If TableNo_txtbox.Text = "" Then
            TimeIn()
        Else
            TimeIn_timer.Stop()
        End If
    End Sub

    Public Sub autogenerate_no()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select MAX(Order_ID) from fosdatabase.order"

            COMMAND = New MySqlCommand(Query, MysqlConn)

            Dim Onumber As Integer

            If IsDBNull(COMMAND.ExecuteScalar) Then
                Onumber = 1000001
                OrderNo_txtbox.Text = Onumber
            Else
                Onumber = COMMAND.ExecuteScalar + 1
                OrderNo_txtbox.Text = Onumber
            End If

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PreviousButton(sender As Object, e As EventArgs) Handles Previous_btn.Click
        Me.Close()
        WaiterCashier_Use.Show()
        WaiterCashier_Use.Load_DineIntable()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader
        Dim Order_COMMAND As MySqlCommand

        Try
            MysqlConn.Open()
            Dim Order_Query As String
            Order_Query = "select count(*) from fosdatabase.order where Order_Status = 'Unpaid'"
            Order_COMMAND = New MySqlCommand(Order_Query, MysqlConn)
            READER = Order_COMMAND.ExecuteReader
            Dim NoTa As Integer
            While READER.Read
                NoTa = READER.GetInt32("count(*)")
            End While
            WaiterCashier_Use.NoOrder_lbl.Text = NoTa
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub LogoutButton(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            WaiterCashier_Use.Close()
            Me.Close()

            Login_Page.Show()
            Login_Page.Username_txtbox.Text = Nothing
            Login_Page.Password_txtbox.Text = Nothing
        End If
    End Sub

    Private Sub SelectTableButton(sender As Object, e As EventArgs) Handles SelectTable_btn.Click
        If TableNo_txtbox.Text = "" Then
            Table_Info.Show()
        Else
            MessageBox.Show("Please send your current order before take a new order.")
        End If
    End Sub

    Private Sub AddMealButton(sender As Object, e As EventArgs) Handles AddMeal_btn.Click
        If TableNo_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before add meal.")
        Else
            Order_Product.Show()
            Order_Product.AddFood_btn.Visible = True
            Order_Product.AddFood_btn1.Visible = False
            Order_Product.AddDrink_btn.Visible = True
            Order_Product.AddDrink_btn1.Visible = False
            Order_Product.AddDessert_btn.Visible = True
            Order_Product.AddDessert_btn1.Visible = False
            Order_Product.SaveExit_btn1.Visible = False
            Order_Product.SaveExit_btn.Visible = True
        End If
    End Sub

    Private Sub AddQuantity_btn_Click(sender As Object, e As EventArgs) Handles AddQuantity_btn.Click
        If Ordered_Product_LV.SelectedItems.Count > 0 Then
            For Each list As ListViewItem In Ordered_Product_LV.SelectedItems
                Dim newSubprice As Decimal
                newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                list.SubItems(2).Text += 1
                list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")
            Next

            calculate()
        Else
            MessageBox.Show("No meal selected.")
        End If
    End Sub

    Private Sub DeleteQuantity_btn_Click(sender As Object, e As EventArgs) Handles DeleteQuantity_btn.Click
        If Ordered_Product_LV.SelectedItems.Count > 0 Then
            For Each list As ListViewItem In Ordered_Product_LV.SelectedItems
                If list.SubItems(2).Text = 1 Then
                    Dim newSubprice As Decimal
                    newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                    list.SubItems(2).Text = 1
                    list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")
                Else
                    Dim newSubprice As Decimal
                    newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                    list.SubItems(2).Text -= 1
                    list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")
                End If
            Next

            calculate()
        Else
            MessageBox.Show("No meal selected.")
        End If
    End Sub

    Private Sub DeleteOrderButton(sender As Object, e As EventArgs) Handles DeleteMeal_btn.Click
        If Ordered_Product_LV.SelectedItems.Count > 0 Then
            Dim ask As DialogResult
            ask = MessageBox.Show("Confirm delete the selected order?", "Delete", MessageBoxButtons.OKCancel)
            If ask = DialogResult.OK Then
                For Each list As ListViewItem In Ordered_Product_LV.SelectedItems
                    list.Remove()
                    Total_txtbox.Text = Format(Total_txtbox.Text - Val(list.SubItems(3).Text), "0.00")
                Next
            End If
        Else
            MessageBox.Show("No order selected.")
        End If
    End Sub

    Private Sub CancelOrderButton(sender As Object, e As EventArgs) Handles CancelOrder_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to cancel this order?", "Cancel", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            TableNo_txtbox.Clear()
            TimeIn()
            Ordered_Product_LV.Items.Clear()
            Total_txtbox.Clear()
        End If
    End Sub

    Private Sub SendOrderButton(sender As Object, e As EventArgs) Handles SendOrder_btn.Click
        If TableNo_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before add meal.")
        ElseIf Ordered_Product_LV.Items.Count = 0 Then
            MessageBox.Show("No meal added.")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader
            Dim iloop As Integer

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into fosdatabase.order (Table_ID, Order_ID, Staff_ID, Date, Time_In, Order_Status, Cashier_ID, Amount) values ('" & TableNo_txtbox.Text & "', '" & OrderNo_txtbox.Text & "', '" & WaiterID_txtbox.Text & "', '" & Date_txtbox.Text & "', '" & TimeIn_txtbox.Text & "', 'Unpaid', 'CS0000', '" & Total_txtbox.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MysqlConn.Close()

                MysqlConn.Open()
                For iloop = 0 To Ordered_Product_LV.Items.Count - 1
                    Dim Query1 As String
                    Query1 = "insert into fosdatabase.order_detail (Order_ID, Menu_ID, Order_Quantity, Order_Menu_Status) values ('" & OrderNo_txtbox.Text & "', '" & Ordered_Product_LV.Items(iloop).Text & "', '" & Ordered_Product_LV.Items(iloop).SubItems(2).Text & "', 'Waiting')"
                    COMMAND = New MySqlCommand(Query1, MysqlConn)
                    READER = COMMAND.ExecuteReader
                    READER.Close()
                Next
                MysqlConn.Close()

                MysqlConn.Open()
                Dim Query2 As String
                Query2 = "update fosdatabase.table set Table_Status = 'Unavailable' where Table_ID = '" & TableNo_txtbox.Text & "'"
                COMMAND = New MySqlCommand(Query2, MysqlConn)
                READER = COMMAND.ExecuteReader
                MysqlConn.Close()

                MsgBox("Order Save.", vbInformation, "Order Information")
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            TableNo_txtbox.Text = ""
            Ordered_Product_LV.Items.Clear()
            Total_txtbox.Text = ""

            autogenerate_no()

            If TableNo_txtbox.Text = "" Then
                TimeIn_timer.Start()
                TimeIn_txtbox.Text = TimeOfDay
            Else
                TimeIn_timer.Stop()
            End If
        End If
    End Sub
End Class