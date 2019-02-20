Imports MySql.Data.MySqlClient

Public Class Order_Product
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim FoodDataSet As New DataTable
    Dim DrinkDataSet As New DataTable
    Dim DessertDataSet As New DataTable

    Dim subtotal As Decimal = 0
    Dim lv As New ListViewItem
    Dim total As Decimal
    Dim multiply As Decimal

    Private Sub Load_Menutable()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=1212;database=fosdatabase"

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

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Order_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Menutable()

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
    End Sub

    Private Sub SaveExitButton(sender As Object, e As EventArgs) Handles SaveExit_btn.Click
        Me.Close()
        Order.Show()
    End Sub

    Private Sub AddFoodButton(sender As Object, e As EventArgs) Handles AddFood_btn.Click
        Dim fooditems() As String = Array.ConvertAll(Food_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve fooditems(fooditems.GetUpperBound(0) - 2)

        lv = Order.Ordered_Product_LV.Items.Add(New ListViewItem(fooditems))
        lv.SubItems.Add(FoodQuantity_NUD.Text)

        Dim i As Integer
        i = Food_DGV.CurrentRow.Index

        multiply = Val(FoodQuantity_NUD.Text) * Val(Food_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        Order.calculate()
    End Sub

    Private Sub AddDrinkButton(sender As Object, e As EventArgs) Handles AddDrink_btn.Click
        Dim drinkitems() As String = Array.ConvertAll(Drink_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve drinkitems(drinkitems.GetUpperBound(0) - 2)

        lv = Order.Ordered_Product_LV.Items.Add(New ListViewItem(drinkitems))
        lv.SubItems.Add(DrinkQuantity_NUD.Text)

        Dim i As Integer
        i = Drink_DGV.CurrentRow.Index

        multiply = Val(DrinkQuantity_NUD.Text) * Val(Drink_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        Order.calculate()
    End Sub

    Private Sub AddDessertButton(sender As Object, e As EventArgs) Handles AddDessert_btn.Click
        Dim dessertitems() As String = Array.ConvertAll(Dessert_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve dessertitems(dessertitems.GetUpperBound(0) - 2)

        lv = Order.Ordered_Product_LV.Items.Add(New ListViewItem(dessertitems))
        lv.SubItems.Add(DessertQuantity_NUD.Text)

        Dim i As Integer
        i = Dessert_DGV.CurrentRow.Index

        multiply = Val(DessertQuantity_NUD.Text) * Val(Dessert_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        Order.calculate()
    End Sub

    Private Sub SearchFoodButton(sender As Object, e As EventArgs) Handles SearchFood_btn.Click
        Dim DV = New DataView(FoodDataSet)
        DV.RowFilter = String.Format("Menu_ID LIKE '%{0}%'", SearchFood_txtbox.Text)
        Food_DGV.DataSource = DV
    End Sub

    Private Sub SearchDrink_btn_Click(sender As Object, e As EventArgs) Handles SearchDrink_btn.Click
        Dim DV = New DataView(DrinkDataSet)
        DV.RowFilter = String.Format("Menu_ID LIKE '%{0}%'", SearchDrink_txtbox.Text)
        Drink_DGV.DataSource = DV
    End Sub

    Private Sub SearchDessert_btn_Click(sender As Object, e As EventArgs) Handles SearchDessert_btn.Click
        Dim DV = New DataView(DessertDataSet)
        DV.RowFilter = String.Format("Menu_ID LIKE '%{0}%'", SearchDessert_txtbox.Text)
        Dessert_DGV.DataSource = DV
    End Sub

    Private Sub AddFoodButton1(sender As Object, e As EventArgs) Handles AddFood_btn1.Click
        Dim fooditems() As String = Array.ConvertAll(Food_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve fooditems(fooditems.GetUpperBound(0) - 2)

        lv = WaiterCashier_Use.UpdateOrdered_Product_LV.Items.Add(New ListViewItem(fooditems))
        lv.SubItems.Add(FoodQuantity_NUD.Text)

        Dim i As Integer
        i = Food_DGV.CurrentRow.Index

        multiply = Val(FoodQuantity_NUD.Text) * Val(Food_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        WaiterCashier_Use.calculateHIDE()
    End Sub

    Private Sub AddDrinkButton1(sender As Object, e As EventArgs) Handles AddDrink_btn1.Click
        Dim drinkitems() As String = Array.ConvertAll(Drink_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve drinkitems(drinkitems.GetUpperBound(0) - 2)

        lv = WaiterCashier_Use.UpdateOrdered_Product_LV.Items.Add(New ListViewItem(drinkitems))
        lv.SubItems.Add(DrinkQuantity_NUD.Text)

        Dim i As Integer
        i = Drink_DGV.CurrentRow.Index

        multiply = Val(DrinkQuantity_NUD.Text) * Val(Drink_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        WaiterCashier_Use.calculateHIDE()
    End Sub

    Private Sub AddDessertButton1(sender As Object, e As EventArgs) Handles AddDessert_btn1.Click
        DessertQuantity_NUD.BackColor = Color.White

        Dim dessertitems() As String = Array.ConvertAll(Dessert_DGV.CurrentRow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c As DataGridViewCell) c.Value.ToString)
        ReDim Preserve dessertitems(dessertitems.GetUpperBound(0) - 2)

        lv = WaiterCashier_Use.UpdateOrdered_Product_LV.Items.Add(New ListViewItem(dessertitems))
        lv.SubItems.Add(DessertQuantity_NUD.Text)

        Dim i As Integer
        i = Dessert_DGV.CurrentRow.Index

        multiply = Val(DessertQuantity_NUD.Text) * Val(Dessert_DGV.Item(2, i).Value)
        lv.SubItems.Add(Format(multiply, "0.00"))

        WaiterCashier_Use.calculateHIDE()
    End Sub

    Private Sub SaveExitButton1(sender As Object, e As EventArgs) Handles SaveExit_btn1.Click
        Me.Close()
        WaiterCashier_Use.Show()
    End Sub

    Private Sub FoodQuantity_NUD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FoodQuantity_NUD.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub DrinkQuantity_NUD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DrinkQuantity_NUD.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub DessertQuantity_NUD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DessertQuantity_NUD.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

End Class
