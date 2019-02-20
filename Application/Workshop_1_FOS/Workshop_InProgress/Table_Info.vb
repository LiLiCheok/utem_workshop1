Imports MySql.Data.MySqlClient

Public Class Table_Info
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Table_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_URTtable()
        Load_ARTtable()

        'TODO: This line of code loads data into the 'FosdatabaseDataSet.table' table. You can move, or remove it, as needed.
        'Me.TableTableAdapter.Fill(Me.FosdatabaseDataSet.table)
    End Sub

    Private Sub Load_ARTtable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim SDA1 As New MySqlDataAdapter
        Dim dbDataSet1 As New DataTable
        Dim bSource1 As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from fosdatabase.table where Table_Status = 'Available'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA1.SelectCommand = COMMAND
            SDA1.Fill(dbDataSet1)
            bSource1.DataSource = dbDataSet1
            TableAvailable_DGV.DataSource = bSource1
            SDA1.Update(dbDataSet1)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Load_URTtable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim SDA1 As New MySqlDataAdapter
        Dim dbDataSet1 As New DataTable
        Dim bSource1 As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from fosdatabase.table where Table_Status = 'Unavailable'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA1.SelectCommand = COMMAND
            SDA1.Fill(dbDataSet1)
            bSource1.DataSource = dbDataSet1
            TableUnavailable_DGV.DataSource = bSource1
            SDA1.Update(dbDataSet1)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub CancelTableButton(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub OkButton(sender As Object, e As EventArgs) Handles OK_btn.Click
        Dim i As Integer = TableAvailable_DGV.CurrentRow.Index
        Order.TableNo_txtbox.Text = TableAvailable_DGV.Item(0, i).Value
        Me.Close()
    End Sub

    Private Sub TableUnavailable_DGV_Click(sender As Object, e As EventArgs) Handles TableUnavailable_DGV.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"
        Dim READER As MySqlDataReader
        Dim i As Integer = TableUnavailable_DGV.CurrentRow.Index
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from fosdatabase.table where Table_Status = 'Unavailable'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                If TableUnavailable_DGV.Item(0, i).Value = READER.GetString("Table_ID") Then
                    MsgBox("Please select the Available Table.", vbInformation)
                End If
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class