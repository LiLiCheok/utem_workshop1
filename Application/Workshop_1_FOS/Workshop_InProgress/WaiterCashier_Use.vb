Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Data
Imports System.Reflection

Public Class WaiterCashier_Use
    Dim MysqlConn As MySqlConnection
    Dim StaffName_COMMAND As MySqlCommand
    Dim Table_COMMAND As MySqlCommand
    Dim Order_COMMAND As MySqlCommand
    Dim Load_COMMAND As MySqlCommand
    Dim UpdateO_COMMAND As MySqlCommand
    Dim InsertA_COMMAND As MySqlCommand
    Dim InsertC_COMMAND As MySqlCommand
    Dim UpdateT_COMMAND As MySqlCommand
    Dim StaffID_COMMAND As MySqlCommand
    Dim Subtotal_COMMAND As MySqlCommand
    Dim GovTax_COMMAND As MySqlCommand
    Dim ServiceCharge_COMMAND As MySqlCommand
    Dim TotalDue_COMMAND As MySqlCommand

    Public Sub TimeOut()
        TimeOut_timer.Start()
        TimeOut_lbl.Text = TimeOfDay
    End Sub

    Public Sub calculateHIDE()
        Dim subtotal_LV As Decimal = 0
        For Each lv As ListViewItem In UpdateOrdered_Product_LV.Items
            subtotal_LV = CDec(lv.SubItems(3).Text)
        Next
        Total_txtbox.Text = Format(Val(Total_txtbox.Text) + Val(subtotal_LV), "0.00")
    End Sub

    Private Sub Cashier_Use_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimeOut()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim StaffName_Query As String
            StaffName_Query = "select Staff_Name, Staff_ID, Staff_Position from fosdatabase.staff where Staff_ID ='" & Login_Page.Username_txtbox.Text & "'"
            StaffName_COMMAND = New MySqlCommand(StaffName_Query, MysqlConn)
            READER = StaffName_COMMAND.ExecuteReader
            Dim full_name As String = ""
            Dim userid As String = ""
            Dim post As String = ""
            While READER.Read
                full_name = READER.GetString("Staff_Name")
                userid = READER.GetString("Staff_ID")
                post = READER.GetString("Staff_position")
            End While
            Welcome_lbl.Text = "Welcome " & full_name

            If post = "Waiter" Then
                Cash_txtbox.ReadOnly = True
                Confirm_btn.Visible = False
                CancelPurchase_btn.Visible = False
            Else
                Cash_txtbox.ReadOnly = False
                Confirm_btn.Visible = True
                CancelPurchase_btn.Visible = True
            End If
            MysqlConn.Close()

            MysqlConn.Open()
            Dim Order_Query As String
            Order_Query = "select count(*) from fosdatabase.order where Order_Status = 'Unpaid'"
            Order_COMMAND = New MySqlCommand(Order_Query, MysqlConn)
            READER = Order_COMMAND.ExecuteReader
            Dim NoTa As Integer
            While READER.Read
                NoTa = READER.GetInt32("count(*)")
            End While
            NoOrder_lbl.Text = NoTa
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        DateTime_timer.Start()
        DateTime_lbl.Text = Date.Now

        Load_DineIntable()
        'TODO: This line of code loads data into the 'FosdatabaseDataSet.order' table. You can move, or remove it, as needed.
        'Me.OrderTableAdapter.Fill(Me.FosdatabaseDataSet.order)

        UpdateOrdered_Product_LV.Columns.Add("Menu ID", 160, HorizontalAlignment.Left)
        UpdateOrdered_Product_LV.Columns.Add("Menu Name", 250, HorizontalAlignment.Left)
        UpdateOrdered_Product_LV.Columns.Add("Quantity", 140, HorizontalAlignment.Left)
        UpdateOrdered_Product_LV.Columns.Add("Sub-price (RM)", 160, HorizontalAlignment.Left)
    End Sub

    Private Sub TimeOut(sender As Object, e As EventArgs) Handles TimeOut_timer.Tick
        TimeOut_lbl.Text = TimeOfDay
    End Sub

    Private Sub LogOut_btn_Click(sender As Object, e As EventArgs) Handles LogOut_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            Me.Close()

            Login_Page.Show()
            Login_Page.Username_txtbox.Text = Nothing
            Login_Page.Password_txtbox.Text = Nothing
        End If
    End Sub

    Private Sub DateTime_timer_Tick(sender As Object, e As EventArgs) Handles DateTime_timer.Tick
        DateTime_lbl.Text = Date.Now
    End Sub

    Public Sub ClearTable()
        Dim dbDataSet As New DataTable
        dbDataSet.Clear()
        OrderDetail_DGV.DataSource = dbDataSet
        OrderDetail_DGV.DataSource = Nothing
    End Sub

    Public Sub Load_DineIntable()
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Try
            MysqlConn.Open()
            Dim Table_Query As String
            Table_Query = "select Table_ID, Order_ID, Time_IN, Order_Status from fosdatabase.order where Order_Status='Unpaid' order by Order_ID"
            Table_COMMAND = New MySqlCommand(Table_Query, MysqlConn)
            SDA.SelectCommand = Table_COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DineInTable_DGV.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Public Sub Load_OrderDetailTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim COMMAND As New MySqlCommand

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select od.Menu_ID , m.Menu_Name , od.Order_Quantity , m.Unit_Price*od.Order_Quantity as Subprice from fosdatabase.menu m , fosdatabase.order_detail od , fosdatabase.order o where m.Menu_ID=od.Menu_ID and od.Order_ID=o.Order_ID and o.Table_ID='" & TableID_txtbox.Text & "' and o.Order_Status='Unpaid'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            OrderDetail_DGV.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub NewOrderButton(sender As Object, e As EventArgs) Handles NewOrder_btn.Click
        Order.Show()
        Order.TableNo_txtbox.Text = ""
        Order.Total_txtbox.Text = ""
        Order.autogenerate_no()
        If Order.TableNo_txtbox.Text = "" Then
            Order.TimeIn_timer.Start()
            Order.TimeIn_txtbox.Text = TimeOfDay
        Else
            Order.TimeIn_timer.Stop()
        End If
        Me.Hide()
    End Sub

    Private Sub AddMealButton(sender As Object, e As EventArgs) Handles AddMeal_btn.Click
        If TableID_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before add meal.")
        Else
            Order_Product.Show()
            Order_Product.AddFood_btn1.Visible = True
            Order_Product.AddFood_btn.Visible = False
            Order_Product.AddDrink_btn1.Visible = True
            Order_Product.AddDrink_btn.Visible = False
            Order_Product.AddDessert_btn1.Visible = True
            Order_Product.AddDessert_btn.Visible = False
            Order_Product.SaveExit_btn1.Visible = True
            Order_Product.SaveExit_btn.Visible = False
        End If
    End Sub

    Private Sub DeleteMeal_btn_Click(sender As Object, e As EventArgs) Handles DeleteMeal_btn.Click
        If UpdateOrdered_Product_LV.SelectedItems.Count > 0 Then
            Dim ask As DialogResult
            ask = MessageBox.Show("Confirm delete the selected order?", "Delete", MessageBoxButtons.OKCancel)
            If ask = DialogResult.OK Then
                For Each list As ListViewItem In UpdateOrdered_Product_LV.SelectedItems
                    list.Remove()
                    Total_txtbox.Text = Format(Total_txtbox.Text - Val(list.SubItems(3).Text), "0.00")
                Next
            End If
        Else
            MessageBox.Show("No order selected.")
        End If
    End Sub

    Private Sub SendUpdateOrderButton(sender As Object, e As EventArgs) Handles SendUpdateOrder_btn.Click
        If TableID_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before add meal.")
        ElseIf UpdateOrdered_Product_LV.Items.Count = 0 Then
            MessageBox.Show("No meal added.")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader
            Dim Command As MySqlCommand
            Dim iloop As Integer

            Try
                MysqlConn.Open()
                For iloop = 0 To UpdateOrdered_Product_LV.Items.Count - 1
                    Dim Query As String
                    Query = "insert into fosdatabase.order_detail (Order_ID, Menu_ID, Order_Quantity, Order_Menu_Status) values ('" & Order_ID_lbl.Text & "', '" & UpdateOrdered_Product_LV.Items(iloop).Text & "', '" & UpdateOrdered_Product_LV.Items(iloop).SubItems(2).Text & "', 'Waiting')"
                    Command = New MySqlCommand(Query, MysqlConn)
                    READER = Command.ExecuteReader
                    READER.Close()
                Next
                MysqlConn.Close()

                MysqlConn.Open()
                Dim InsertA_Query As String
                InsertA_Query = "Update fosdatabase.order set Amount = '" & Total_txtbox.Text & "' where Table_ID='" & TableID_txtbox.Text & "'"
                InsertA_COMMAND = New MySqlCommand(InsertA_Query, MysqlConn)
                READER = InsertA_COMMAND.ExecuteReader
                MysqlConn.Close()

                MsgBox("Order Save.", vbInformation)
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            TableID_txtbox.Text = ""
            Server_lbl.Text = ""
            Table_ID_lbl.Text = ""
            Order_ID_lbl.Text = ""
            TodayDate_lbl.Text = ""
            TimeIn_lbl.Text = ""

            ClearTable()

            Total_txtbox.Text = ""

            UpdateOrdered_Product_LV.Clear()
            TimeOut()
        End If
    End Sub

    Private Sub AddButton(sender As Object, e As EventArgs) Handles Add_btn.Click
        If UpdateOrdered_Product_LV.SelectedItems.Count > 0 Then
            For Each list As ListViewItem In UpdateOrdered_Product_LV.SelectedItems
                Dim newSubprice As Decimal
                newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                list.SubItems(2).Text += 1
                list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")

                Dim subtotal_LV As Decimal = 0
                subtotal_LV += CDec(newSubprice)
                Total_txtbox.Text = Format(Val(Total_txtbox.Text) + Val(subtotal_LV), "0.00")
            Next
        Else
            MessageBox.Show("No meal selected.")
        End If
    End Sub

    Private Sub MinusButton(sender As Object, e As EventArgs) Handles Minus_btn.Click
        If UpdateOrdered_Product_LV.SelectedItems.Count > 0 Then
            For Each list As ListViewItem In UpdateOrdered_Product_LV.SelectedItems
                If list.SubItems(2).Text = 1 Then
                    Dim newSubprice As Decimal
                    newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                    list.SubItems(2).Text = 1
                    list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")

                    Dim subtotal_LV As Decimal = 0
                    subtotal_LV -= CDec(newSubprice)
                    Total_txtbox.Text = Format(Val(Total_txtbox.Text) + Val(subtotal_LV), "0.00")
                Else
                    Dim newSubprice As Decimal
                    newSubprice = list.SubItems(3).Text / list.SubItems(2).Text
                    list.SubItems(2).Text -= 1
                    list.SubItems(3).Text = Format(list.SubItems(2).Text * newSubprice, "0.00")

                    Dim subtotal_LV As Decimal = 0
                    subtotal_LV -= CDec(newSubprice)
                    Total_txtbox.Text = Format(Val(Total_txtbox.Text) + Val(subtotal_LV), "0.00")
                End If
            Next
        Else
            MessageBox.Show("No meal selected.")
        End If
    End Sub

    Private Sub CancelOrder_btn_Click(sender As Object, e As EventArgs) Handles CancelOrder_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to cancel this order?", "Cancel", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            UpdateOrdered_Product_LV.Items.Clear()
        End If
    End Sub

    Private Sub ViewButton(sender As Object, e As EventArgs) Handles View_btn.Click
        If DineInTable_DGV.SelectedRows.Count > 0 Then
            Dim i As Integer = DineInTable_DGV.CurrentRow.Index
            Me.TableID_txtbox.Text = DineInTable_DGV.Item(1, i).Value
        Else
            MsgBox("No Order Selected.", vbEmpty, "Information")
        End If
    End Sub

    Private Sub ConfirmButton(sender As Object, e As EventArgs) Handles Confirm_btn.Click
        If Cash_txtbox.Text = Nothing Then
            MsgBox("Please insert the Cash Amount", vbExclamation)
        Else
            TimeOut_timer.Stop()

            If Val(Cash_txtbox.Text) > Val(Total_txtbox.Text) Then

                Change_txtbox.Text = Format(Val(Cash_txtbox.Text) - Val(Total_txtbox.Text), "0.00")
                Customer_balance.Show()
                Customer_balance.ChangeAmount_lbl.Text = "RM " + Change_txtbox.Text

                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim UpdateO_Query As String
                    UpdateO_Query = "Update fosdatabase.order set Order_Status = 'Paid', Cashier_ID='" & CashierID_lbl.Text & "' where Order_ID='" & Order_ID_lbl.Text & "'"
                    UpdateO_COMMAND = New MySqlCommand(UpdateO_Query, MysqlConn)
                    READER = UpdateO_COMMAND.ExecuteReader
                    MysqlConn.Close()

                    MysqlConn.Open()
                    Dim UpdateT_Query As String
                    UpdateT_Query = "Update fosdatabase.table set Table_Status = 'Available' where Table_ID='" & TableID_txtbox.Text & "'"
                    UpdateT_COMMAND = New MySqlCommand(UpdateT_Query, MysqlConn)
                    READER = UpdateT_COMMAND.ExecuteReader
                    MysqlConn.Close()

                    MysqlConn.Open()
                    Dim InsertA_Query As String
                    InsertA_Query = "Update fosdatabase.order set Amount = '" & Total_txtbox.Text & "' where Table_ID='" & TableID_txtbox.Text & "'"
                    InsertA_COMMAND = New MySqlCommand(InsertA_Query, MysqlConn)
                    READER = InsertA_COMMAND.ExecuteReader
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

            ElseIf Val(Cash_txtbox.Text) < Val(Total_txtbox.Text) Then
                Dim amount As Decimal
                amount = Format(Val(Total_txtbox.Text) - Val(Cash_txtbox.Text), "0.00")
                MsgBox("Not enough Cash, RM" + Format(amount, "0.00") + " more.", vbExclamation)

            ElseIf Val(Cash_txtbox.Text) = Val(Total_txtbox.Text) Then

                Change_txtbox.Text = Format(Val(Cash_txtbox.Text) - Val(Total_txtbox.Text), "0.00")
                Customer_balance.Show()
                Customer_balance.ChangeAmount_lbl.Text = "RM " + Change_txtbox.Text

                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

                Dim READER As MySqlDataReader

                Try
                    MysqlConn.Open()
                    Dim UpdateO_Query As String
                    UpdateO_Query = "Update fosdatabase.order set Order_Status = 'Paid' where Table_ID='" & TableID_txtbox.Text & "'"
                    UpdateO_COMMAND = New MySqlCommand(UpdateO_Query, MysqlConn)
                    READER = UpdateO_COMMAND.ExecuteReader
                    MysqlConn.Close()

                    MysqlConn.Open()
                    Dim UpdateT_Query As String
                    UpdateT_Query = "Update fosdatabase.table set Table_Status = 'Available' where Table_ID='" & TableID_txtbox.Text & "'"
                    UpdateT_COMMAND = New MySqlCommand(UpdateT_Query, MysqlConn)
                    READER = UpdateT_COMMAND.ExecuteReader
                    MysqlConn.Close()

                    MysqlConn.Open()
                    Dim InsertA_Query As String
                    InsertA_Query = "Update fosdatabase.order set Amount = '" & Total_txtbox.Text & "' where Table_ID='" & TableID_txtbox.Text & "'"
                    InsertA_COMMAND = New MySqlCommand(InsertA_Query, MysqlConn)
                    READER = InsertA_COMMAND.ExecuteReader
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

            End If
        End If
    End Sub

    Private Sub CancelPurchaseButton(sender As Object, e As EventArgs) Handles CancelPurchase_btn.Click
        Cash_txtbox.Clear()
    End Sub

    Private Sub LoadButton(sender As Object, e As EventArgs) Handles Load_btn.Click
        If TableID_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before view order.")
        Else
            Edit_btn.Visible = True

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            MysqlConn.Open()
            Try
                Dim Load_Query = "select Order_ID, Table_ID, Staff_ID, Date, Time_In from fosdatabase.order where Table_ID = '" & TableID_txtbox.Text & "'"
                Load_COMMAND = New MySqlCommand(Load_Query, MysqlConn)
                READER = Load_COMMAND.ExecuteReader

                Dim OrderID As String = Nothing
                Dim TableID As String = Nothing
                Dim WaiterID As String = Nothing
                Dim CurrDate As DateTime
                Dim CurrTime As DateTime

                While READER.Read
                    OrderID = READER.GetString("Order_ID")
                    TableID = READER.GetString("Table_ID")
                    WaiterID = READER.GetString("Staff_ID")
                    CurrDate = READER.GetString("Date")
                    CurrTime = READER.GetString("Time_In")
                End While

                Order_ID_lbl.Text = OrderID
                Table_ID_lbl.Text = TableID
                Server_lbl.Text = WaiterID
                TodayDate_lbl.Text = CurrDate
                TimeIn_lbl.Text = CurrTime
                MysqlConn.Close()

                MysqlConn.Open()
                Dim StaffID_Query As String
                StaffID_Query = "select Staff_ID from fosdatabase.staff where Staff_ID ='" & Login_Page.Username_txtbox.Text & "'"
                StaffID_COMMAND = New MySqlCommand(StaffID_Query, MysqlConn)
                READER = StaffID_COMMAND.ExecuteReader
                Dim userid As String = ""
                While READER.Read
                    userid = READER.GetString("Staff_ID")
                End While
                CashierID_lbl.Text = userid
                MysqlConn.Close()

                MysqlConn.Open()
                Dim TotalDue_Query = "select Sum(m.Unit_Price*od.Order_Quantity) from fosdatabase.menu m , fosdatabase.order_detail od, fosdatabase.order o where m.Menu_ID=od.Menu_ID and od.Order_ID=o.Order_ID and o.Table_ID ='" & TableID_txtbox.Text & "' and o.Order_Status='Unpaid'"

                TotalDue_COMMAND = New MySqlCommand(TotalDue_Query, MysqlConn)

                Dim TotalDue_SHOW As Decimal = TotalDue_COMMAND.ExecuteScalar()

                Total_txtbox.Text = TotalDue_SHOW.ToString("F")
                MysqlConn.Close()

                MysqlConn.Open()
                Dim StaffPost_Query As String
                StaffPost_Query = "select Staff_Position from fosdatabase.staff where Staff_ID ='" & Login_Page.Username_txtbox.Text & "'"
                Dim StaffPost_COMMAND As New MySqlCommand
                StaffPost_COMMAND = New MySqlCommand(StaffPost_Query, MysqlConn)
                READER = StaffPost_COMMAND.ExecuteReader
                Dim post As String = ""
                While READER.Read
                    post = READER.GetString("Staff_position")
                End While

                If post = "Waiter" Then
                    Cash_txtbox.ReadOnly = True
                    Confirm_btn.Visible = False
                    CancelPurchase_btn.Visible = False
                Else
                    Cash_txtbox.ReadOnly = False
                    Confirm_btn.Visible = True
                    CancelPurchase_btn.Visible = True
                End If
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            AddMeal_btn.Visible = False
            Add_btn.Visible = False
            Minus_btn.Visible = False
            DeleteMeal_btn.Visible = False
            SendUpdateOrder_btn.Visible = False
            CancelOrder_btn.Visible = False

            Load_DineIntable()
            Load_OrderDetailTable()

        End If
    End Sub

    Private Sub CashKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cash_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub EditButton(sender As Object, e As EventArgs) Handles Edit_btn.Click
        If TableID_txtbox.Text = "" Then
            MessageBox.Show("Please select a Table ID before view order.")
        Else
            AddMeal_btn.Visible = True
            Add_btn.Visible = True
            Minus_btn.Visible = True
            DeleteMeal_btn.Visible = True
            SendUpdateOrder_btn.Visible = True
            CancelOrder_btn.Visible = True

            Cash_txtbox.ReadOnly = True
            Confirm_btn.Visible = False
            CancelPurchase_btn.Visible = False
        End If
    End Sub

End Class