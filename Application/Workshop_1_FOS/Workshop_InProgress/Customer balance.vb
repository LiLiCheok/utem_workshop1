Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Data
Imports System.Reflection

Public Class Customer_balance
    Dim MysqlConn As MySqlConnection
    Dim Order_COMMAND As MySqlCommand

    Private Sub print()

        Try
            Dim pdfTable As New PdfPTable(WaiterCashier_Use.OrderDetail_DGV.ColumnCount)
            pdfTable.DefaultCell.Padding = 5
            pdfTable.WidthPercentage = 100
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
            pdfTable.DefaultCell.BorderWidth = 0.5

            For Each column As DataGridViewColumn In WaiterCashier_Use.OrderDetail_DGV.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
                pdfTable.AddCell(cell)
            Next

            For Each row As DataGridViewRow In WaiterCashier_Use.OrderDetail_DGV.Rows
                For Each cell As DataGridViewCell In row.Cells
                    pdfTable.AddCell(cell.Value.ToString())
                Next
            Next

            Dim Receipt_pdfDoc As New Document()
            Dim Receipt_pdfWrite As PdfWriter = PdfWriter.GetInstance(Receipt_pdfDoc, New FileStream("" & WaiterCashier_Use.Order_ID_lbl.Text & " Receipt.pdf", FileMode.Create))

            Receipt_pdfDoc.Open()
            Receipt_pdfDoc.Add(New Paragraph("                                                              WaterLily Restaurant"))
            Receipt_pdfDoc.Add(New Paragraph("                                       20, Jalan Sri Parit, 71010 Port Dickson, N.Sembilan"))
            Receipt_pdfDoc.Add(New Paragraph("                                             Tel : 606-3365428          Fax : 606-9930421"))
            Receipt_pdfDoc.Add(New Paragraph("                                                     Welcome to WaterLily Restaurant"))
            Receipt_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            Receipt_pdfDoc.Add(New Paragraph("Server : " & WaiterCashier_Use.Server_lbl.Text & "                                                                                                Date : " & WaiterCashier_Use.TodayDate_lbl.Text & ""))
            Receipt_pdfDoc.Add(New Paragraph("Table ID : " & WaiterCashier_Use.Table_ID_lbl.Text & "                                                                                                    Time : " & WaiterCashier_Use.TimeIn_lbl.Text & ""))
            Receipt_pdfDoc.Add(New Paragraph("Order ID : " & WaiterCashier_Use.Order_ID_lbl.Text & "                                                                                            Cashier ID : " & WaiterCashier_Use.CashierID_lbl.Text & ""))
            Receipt_pdfDoc.Add(New Paragraph(" "))
            Receipt_pdfDoc.Add(pdfTable)
            Receipt_pdfDoc.Add(New Paragraph(" "))
            Receipt_pdfDoc.Add(New Paragraph("                                                                                                                          Total Due : RM " & WaiterCashier_Use.Total_txtbox.Text & ""))
            Receipt_pdfDoc.Add(New Paragraph("                                                                                                          " & WaiterCashier_Use.TimeOut_lbl.Text & "  Cash : RM " & Format(Val(WaiterCashier_Use.Cash_txtbox.Text), "0.00") & ""))
            Receipt_pdfDoc.Add(New Paragraph("                                                                                                                          Change : RM " & WaiterCashier_Use.Change_txtbox.Text & ""))
            Receipt_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            Receipt_pdfDoc.Add(New Paragraph("                                                               Thank You Very Much"))
            Receipt_pdfDoc.Add(New Paragraph("                                                                   Come Back Again"))
            Receipt_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            Receipt_pdfDoc.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub back()
        Me.Close()
        WaiterCashier_Use.Show()
        WaiterCashier_Use.TableID_txtbox.Text = ""
        WaiterCashier_Use.Server_lbl.Text = ""
        WaiterCashier_Use.Table_ID_lbl.Text = ""
        WaiterCashier_Use.Order_ID_lbl.Text = ""
        WaiterCashier_Use.TodayDate_lbl.Text = ""
        WaiterCashier_Use.TimeIn_lbl.Text = ""
        WaiterCashier_Use.CashierID_lbl.Text = ""

        WaiterCashier_Use.Total_txtbox.Text = ""
        WaiterCashier_Use.Cash_txtbox.Text = ""
        WaiterCashier_Use.Change_txtbox.Text = ""

        WaiterCashier_Use.Cash_txtbox.ReadOnly = True

        WaiterCashier_Use.TimeOut()
        WaiterCashier_Use.Load_DineIntable()
        WaiterCashier_Use.ClearTable()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

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

    Private Sub Confirm_btn(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim ask As DialogResult
        ask = MessageBox.Show("Do you want to print receipt?", "Print Receipt", MessageBoxButtons.OKCancel)
        If ask = DialogResult.OK Then
            print()
            back()
        Else
            back()
        End If
    End Sub
End Class