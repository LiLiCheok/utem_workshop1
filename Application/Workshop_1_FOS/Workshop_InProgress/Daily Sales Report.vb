Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Imports System.Data
Imports System.Reflection

Public Class Daily_Sales_Report
    Dim MysqlConn As MySqlConnection
    Dim TOrder_COMMAND As MySqlCommand
    Dim DS_COMMAND As MySqlCommand

    Private Sub Cancel_btn_Click(sender As Object, e As EventArgs) Handles Cancel_btn.Click
        Me.Close()
    End Sub

    Private Sub Load_DailySales_Table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim DS_DataSet As New DataTable
        Dim DS_SDA As New MySqlDataAdapter
        Dim DS_bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select od.Menu_ID as 'Menu ID', m.Menu_Name as 'Menu Name', m.Unit_Price as 'Unit Price (RM)', sum(od.Order_Quantity) as 'Order Quantity', sum(od.Order_Quantity*m.Unit_Price) as 'Subprice (RM)' from fosdatabase.order o , fosdatabase.order_detail od , fosdatabase.menu m where o.order_ID = od.Order_ID and m.Menu_ID=od.Menu_ID and o.date='" & DailySales_DTP.Text & "' and o.Order_Status='Paid' Group by od.Menu_ID"
            DS_COMMAND = New MySqlCommand(Query, MysqlConn)
            DS_SDA.SelectCommand = DS_COMMAND
            DS_SDA.Fill(DS_DataSet)
            DS_bSource.DataSource = DS_DataSet
            DailySales_DGV.DataSource = DS_bSource
            DS_SDA.Update(DS_DataSet)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Calculate()
        Dim MysqlConn As New MySqlConnection
        Dim DSTotal_COMMAND As New MySqlCommand

        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"
        DSTotal_COMMAND.Connection = MysqlConn

        Try
            MysqlConn.Open()
            DSTotal_COMMAND.CommandText = "select Sum(m.Unit_Price*od.Order_Quantity) from fosdatabase.menu m , fosdatabase.order_detail od, fosdatabase.order o where m.Menu_ID=od.Menu_ID and od.Order_ID=o.Order_ID and  o.date='" & DailySales_DTP.Text & "' and o.Order_Status='Paid'"

            If IsDBNull(DSTotal_COMMAND.ExecuteScalar) Then
                'Do Nothing
            Else
                Dim DSTotal_SHOW As Decimal = DSTotal_COMMAND.ExecuteScalar()
                TotalEarn_txtbox.Text = DSTotal_SHOW.ToString("F")
            End If
            MysqlConn.Close()

            DSTotal_COMMAND.Dispose()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub DailySalesDTP(sender As Object, e As EventArgs) Handles DailySales_DTP.ValueChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim TOrder_Query As String
            TOrder_Query = "select count(Order_ID) from fosdatabase.order where Date='" & DailySales_DTP.Text & "' and Order_Status='Paid'"
            TOrder_COMMAND = New MySqlCommand(TOrder_Query, MysqlConn)
            READER = TOrder_COMMAND.ExecuteReader
            Dim Oid As Integer
            While READER.Read
                Oid = READER.GetInt32("count(Order_ID)")
            End While
            TotalOrder_txtbox.Text = Oid
            MysqlConn.Close()

            TotalEarn_txtbox.Text = Format("0.00")
            Calculate()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Load_DailySales_Table()
    End Sub

    Private Sub PrintButton(sender As Object, e As EventArgs) Handles Print_btn.Click
        Try
            Dim pdfTable As New PdfPTable(DailySales_DGV.ColumnCount)
            pdfTable.DefaultCell.Padding = 5
            pdfTable.WidthPercentage = 100
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
            pdfTable.DefaultCell.BorderWidth = 0.5

            For Each column As DataGridViewColumn In DailySales_DGV.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
                pdfTable.AddCell(cell)
            Next

            For Each row As DataGridViewRow In DailySales_DGV.Rows
                For Each cell As DataGridViewCell In row.Cells
                    pdfTable.AddCell(cell.Value.ToString())
                Next
            Next

            Dim DailySales_pdfDoc As New Document()
            Dim DailySales_pdfWrite As PdfWriter = PdfWriter.GetInstance(DailySales_pdfDoc, New FileStream("" & DailySales_DTP.Text & " Report.pdf", FileMode.Create))

            DailySales_pdfDoc.Open()
            DailySales_pdfDoc.Add(New Paragraph("                                                              WaterLily Restaurant"))
            DailySales_pdfDoc.Add(New Paragraph("                                       20, Jalan Sri Parit, 71010 Port Dickson, N.Sembilan"))
            DailySales_pdfDoc.Add(New Paragraph("                                             Tel : 606-3365428          Fax : 606-9930421"))
            DailySales_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            DailySales_pdfDoc.Add(New Paragraph("Date : " & DailySales_DTP.Text & ""))
            DailySales_pdfDoc.Add(New Paragraph("Total Order : " & TotalOrder_txtbox.Text & ""))
            DailySales_pdfDoc.Add(New Paragraph(" "))

            DailySales_pdfDoc.Add(pdfTable)

            DailySales_pdfDoc.Add(New Paragraph(" "))
            DailySales_pdfDoc.Add(New Paragraph("Total Earn : RM " & TotalEarn_txtbox.Text & ""))
            DailySales_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))
            DailySales_pdfDoc.Add(New Paragraph("----------------------------------------------------------------------------------------------------------------------------------"))

            DailySales_pdfDoc.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MsgBox("Report Printed.", vbInformation, "Print Info.")
    End Sub
End Class