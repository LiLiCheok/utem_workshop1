﻿Imports MySql.Data.MySqlClient

Public Class KitchenLogin
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub LogIn_btn_Click(sender As Object, e As EventArgs) Handles LogIn_btn.Click
        If Username_txtbox.Text = "" And Password_txtbox.Text = "" Then
            MessageBox.Show("Please insert your username and password.")
        ElseIf Username_txtbox.Text = "" Then
            MessageBox.Show("Please insert your username.")
        ElseIf Password_txtbox.Text = "" Then
            MessageBox.Show("Please insert your password.")
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

            Dim READER As MySqlDataReader

            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "select * from fosdatabase.staff where Staff_ID='" & Username_txtbox.Text & "'and Password='" & Password_txtbox.Text & "'"

                Command = New MySqlCommand(Query, MysqlConn)
                READER = Command.ExecuteReader

                Dim count As Integer
                Dim user_authority As String = ""
                count = 0

                While READER.Read
                    count = count + 1
                    user_authority = READER.GetString("Staff_Position")
                End While

                If count = 1 Then

                    If user_authority = "Kitchen" Then
                        Kitchen_Use.Show()
                        Me.Hide()
                    End If

                ElseIf count > 1 Then
                    MsgBox("Username and password are duplicate.", vbExclamation)

                Else
                    MsgBox("Username and password are wrong.", vbExclamation, "Error")
                    Username_txtbox.Text = ""
                    Password_txtbox.Text = ""
                    Warning_lbl.Visible = True
                End If
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Username_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Username_txtbox.KeyPress
        If Char.IsLower(e.KeyChar) Then
            Username_txtbox.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub Password_txtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password_txtbox.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub
End Class