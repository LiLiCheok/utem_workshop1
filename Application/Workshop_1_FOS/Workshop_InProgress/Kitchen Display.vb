Imports MySql.Data.MySqlClient

Public Class Kitchen_Display
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Done_btn_Click(sender As Object, e As EventArgs) Handles Done_btn.Click
        If OrderInfo_DGV.SelectedRows.Count > 0 Then
            My.Computer.Audio.Play(My.Resources.DoneRing, AudioPlayMode.Background)

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader
            Dim i As Integer = OrderInfo_DGV.CurrentRow.Index

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Update fosdatabase.order_detail set Order_Menu_Status = 'Done' where Order_ID = '" & OrderInfo_DGV.Item(2, i).Value & "' and Menu_ID = '" & OrderInfo_DGV.Item(5, i).Value & "'"

                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

            Load_KDisplayTable()
        Else
            MsgBox("No Order Selected.", vbEmpty, "Information")
        End If
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles Logout_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            Me.Close()
            Login_Page.Show()
            Login_Page.Username_txtbox.Text = Nothing
            Login_Page.Password_txtbox.Text = Nothing
        End If
    End Sub

    Private Sub Kitchen_Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrTime.Start()
        CurrTime_lbl.Text = TimeOfDay

        Dim theDate As Date
        theDate = Format(Now(), "short date")
        CurrDate_lbl.Text = theDate

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select Staff_Name from fosdatabase.staff where Staff_ID='" & Login_Page.Username_txtbox.Text & "'"

            Command = New MySqlCommand(Query, MysqlConn)
            READER = Command.ExecuteReader

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

        Load_KDisplayTable()
    End Sub

    Public Sub Load_KDisplayTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim OrderInfo_COMMAND As New MySqlCommand

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select o.Time_In as 'Time In', o.Table_ID as 'Table ID', od.Order_ID as 'Order ID', m.Menu_Name as 'Product Name', od.Order_Quantity as 'Quantity' , od.Menu_ID as 'Menu ID' from fosdatabase.order o , fosdatabase.order_detail od , fosdatabase.menu m where od.Order_ID=o.Order_ID and m.Menu_ID=od.Menu_ID and o.date='" & CurrDate_lbl.Text & "' and Order_Menu_Status='Waiting'"
            OrderInfo_COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = OrderInfo_COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            OrderInfo_DGV.DataSource = bSource

            Me.OrderInfo_DGV.Columns(0).Width = 175
            Me.OrderInfo_DGV.Columns(1).Width = 175
            Me.OrderInfo_DGV.Columns(2).Width = 175
            Me.OrderInfo_DGV.Columns(3).Width = 450
            Me.OrderInfo_DGV.Columns(4).Width = 145
            Me.OrderInfo_DGV.Columns(5).Width = 0

            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CurrTime_Tick(sender As Object, e As EventArgs) Handles CurrTime.Tick
        CurrTime_lbl.Text = TimeOfDay
    End Sub

    Private Sub Update_btn_Click(sender As Object, e As EventArgs) Handles Update_btn.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Confirm to update menu status?", "Update", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            KitchenLogin.Show()
        End If
    End Sub
End Class