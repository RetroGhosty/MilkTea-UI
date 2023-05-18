Imports System.ComponentModel

Public Class Checkout_Form
    Public ComingOrder As ItemStorage
    Private Sub Checkout_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim colorSet As New ColorSetter With {
            .IsDarkMode = True
        }
        colorSet.DarkModeSetter()
        ClearCart_Btn.BackColor = colorSet.PrimaryBtnColor
        ClearCart_Btn.ForeColor = colorSet.PrimaryText

        ListView1.View = View.Details
        ListView1.Columns.Add("Order ID", 120)
        ListView1.Columns.Add("Milk Tea", 120)
        ListView1.Columns.Add("Size", 70)
        ListView1.Columns.Add("Sweetener Level", 100)
        ListView1.Columns.Add("Add ons", 220)
        ListView1.Columns.Add("Total price", 70)

        Dim TotalPrice As Integer = 0

        If ItemStorage.OrderList IsNot Nothing Then
            For Each eachOrder In ItemStorage.OrderList
                Dim item As New ListViewItem(eachOrder.Orderid)

                item.SubItems.Add(eachOrder.TypeOfMilkTeam)
                item.SubItems.Add(eachOrder.Size)
                item.SubItems.Add(eachOrder.ChosenSweetener)
                item.SubItems.Add(eachOrder.AddOns)
                item.SubItems.Add($"₱{eachOrder.MilkTeaPrice}.00")
                ListView1.Items.Add(item)
                TotalPrice += eachOrder.MilkTeaPrice
            Next
        End If
        totalPriceLbl_Value.Text = $"₱{TotalPrice}.00"
    End Sub

    Private Sub ClearCart_Btn_Click(sender As Object, e As EventArgs) Handles ClearCart_Btn.Click
        If ItemStorage.OrderList IsNot Nothing Then
            ItemStorage.OrderList.Clear()
            Me.Close()
        End If
    End Sub
End Class