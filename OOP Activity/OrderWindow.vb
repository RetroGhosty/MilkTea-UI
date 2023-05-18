Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Newtonsoft.Json



Public Class OrderWindow
    Public ReturnPriceFunc As NecessaryFunctions

    Dim temp_TotalPrice
    Public UserOrder As List(Of OrderModel)
    Public UserAddOnsOrder As List(Of String)
    Public SweetenerPicked As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load ColorSetter class as object colorSet
        'Set if True f
        Dim colorSet As New ColorSetter With {
            .IsDarkMode = True
        }
        colorSet.DarkModeSetter()
        'Setting UI color
        TopPanel.BackColor = colorSet.PrimaryColor
        TopPanelHeader_Text.ForeColor = colorSet.PrimaryText
        Label1.ForeColor = colorSet.PrimaryText
        Label2.ForeColor = colorSet.PrimaryText
        Label3.ForeColor = colorSet.PrimaryText
        Label4.ForeColor = colorSet.PrimaryText
        Panel1.BackColor = colorSet.SecondaryColor

        CheckBox1.ForeColor = colorSet.PrimaryText
        CheckBox2.ForeColor = colorSet.PrimaryText
        CheckBox3.ForeColor = colorSet.PrimaryText
        CheckBox4.ForeColor = colorSet.PrimaryText
        CheckBox5.ForeColor = colorSet.PrimaryText

        RadioButton1.ForeColor = colorSet.PrimaryText
        RadioButton2.ForeColor = colorSet.PrimaryText
        RadioButton3.ForeColor = colorSet.PrimaryText
        RadioButton4.ForeColor = colorSet.PrimaryText
        RadioButton5.ForeColor = colorSet.PrimaryText

        CreateMilkTea_Btn.BackColor = colorSet.PrimaryBtnColor
        CreateMilkTea_Btn.ForeColor = colorSet.PrimaryText
        ShowShoppingCart_Btn.BackColor = colorSet.SecondaryBtnColor
        ShowShoppingCart_Btn.ForeColor = colorSet.SecondaryText


        Label5.ForeColor = colorSet.SecondaryText
        Label20.ForeColor = colorSet.SecondaryText
        Label27.ForeColor = colorSet.SecondaryText
        Label38.ForeColor = colorSet.SecondaryText


        NecessaryFunctions.ListThis()
        NecessaryFunctions.SetMenuValue()

        UserOrder = New List(Of OrderModel)
    End Sub





    Private Sub CreateMilkTea_Btn_Click(sender As Object, e As EventArgs) Handles CreateMilkTea_Btn.Click

        Dim concatenatedString As String = String.Join(", ", UserAddOnsOrder)

        UserOrder.Add(New OrderModel(NecessaryFunctions.NewIdFromRandomInt,
                                     ComboBox1.SelectedItem,
                                     temp_TotalPrice,
                                     ComboBox2.SelectedItem,
                                     concatenatedString,
                                     SweetenerPicked))

        ItemStorage.OrderList = UserOrder

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowShoppingCart_Btn.Click
        If UserOrder IsNot Nothing Then
            Checkout_Form.Show()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            temp_TotalPrice += ItemStorage.AddOnsList(0).PriceOfAddOns
            UserAddOnsOrder.Add(ItemStorage.AddOnsList(0).NameOfAddOns)

        Else
            If temp_TotalPrice >= ItemStorage.AddOnsList(0).PriceOfAddOns Then
                temp_TotalPrice -= ItemStorage.AddOnsList(0).PriceOfAddOns
            End If
            UserAddOnsOrder.Remove(ItemStorage.AddOnsList(0).NameOfAddOns)
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            temp_TotalPrice += ItemStorage.AddOnsList(1).PriceOfAddOns
            UserAddOnsOrder.Add(ItemStorage.AddOnsList(1).NameOfAddOns)

        Else
            If temp_TotalPrice >= ItemStorage.AddOnsList(1).PriceOfAddOns Then
                temp_TotalPrice -= ItemStorage.AddOnsList(1).PriceOfAddOns
            End If
            UserAddOnsOrder.Remove(ItemStorage.AddOnsList(1).NameOfAddOns)
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            temp_TotalPrice += ItemStorage.AddOnsList(2).PriceOfAddOns
            UserAddOnsOrder.Add(ItemStorage.AddOnsList(2).NameOfAddOns)

        Else
            If temp_TotalPrice >= ItemStorage.AddOnsList(2).PriceOfAddOns Then
                temp_TotalPrice -= ItemStorage.AddOnsList(2).PriceOfAddOns
            End If
            UserAddOnsOrder.Remove(ItemStorage.AddOnsList(2).NameOfAddOns)
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            temp_TotalPrice += ItemStorage.AddOnsList(3).PriceOfAddOns
            UserAddOnsOrder.Add(ItemStorage.AddOnsList(3).NameOfAddOns)

        Else
            If temp_TotalPrice >= ItemStorage.AddOnsList(3).PriceOfAddOns Then
                temp_TotalPrice -= ItemStorage.AddOnsList(3).PriceOfAddOns
            End If
            UserAddOnsOrder.Remove(ItemStorage.AddOnsList(3).NameOfAddOns)
        End If

    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            temp_TotalPrice += ItemStorage.AddOnsList(4).PriceOfAddOns
            UserAddOnsOrder.Add(ItemStorage.AddOnsList(4).NameOfAddOns)

        Else
            If temp_TotalPrice >= ItemStorage.AddOnsList(4).PriceOfAddOns Then
                temp_TotalPrice -= ItemStorage.AddOnsList(4).PriceOfAddOns
            End If
            UserAddOnsOrder.Remove(ItemStorage.AddOnsList(4).NameOfAddOns)
        End If

    End Sub






    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            temp_TotalPrice += ItemStorage.SweetnessList(0).SweetNessPrice
            SweetenerPicked = ItemStorage.SweetnessList(0).SweetNessText
        Else
            If temp_TotalPrice >= ItemStorage.SweetnessList(0).SweetNessPrice Then
                temp_TotalPrice -= ItemStorage.SweetnessList(0).SweetNessPrice
            End If
            SweetenerPicked = ItemStorage.SweetnessList(0).SweetNessText
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            temp_TotalPrice += ItemStorage.SweetnessList(1).SweetNessPrice
            SweetenerPicked = ItemStorage.SweetnessList(1).SweetNessText
        Else
            If temp_TotalPrice >= ItemStorage.SweetnessList(1).SweetNessPrice Then
                temp_TotalPrice -= ItemStorage.SweetnessList(1).SweetNessPrice
            End If
            SweetenerPicked = ItemStorage.SweetnessList(1).SweetNessText
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            temp_TotalPrice += ItemStorage.SweetnessList(2).SweetNessPrice
            SweetenerPicked = ItemStorage.SweetnessList(2).SweetNessText
        Else
            If temp_TotalPrice >= ItemStorage.SweetnessList(2).SweetNessPrice Then
                temp_TotalPrice -= ItemStorage.SweetnessList(2).SweetNessPrice
            End If
            SweetenerPicked = ItemStorage.SweetnessList(2).SweetNessText
        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            temp_TotalPrice += ItemStorage.SweetnessList(3).SweetNessPrice
            SweetenerPicked = ItemStorage.SweetnessList(3).SweetNessText
        Else
            If temp_TotalPrice >= ItemStorage.SweetnessList(3).SweetNessPrice Then
                temp_TotalPrice -= ItemStorage.SweetnessList(3).SweetNessPrice
            End If
            SweetenerPicked = ItemStorage.SweetnessList(3).SweetNessText
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            temp_TotalPrice += ItemStorage.SweetnessList(4).SweetNessPrice
            SweetenerPicked = ItemStorage.SweetnessList(4).SweetNessText
        Else
            If temp_TotalPrice >= ItemStorage.SweetnessList(4).SweetNessPrice Then
                temp_TotalPrice -= ItemStorage.SweetnessList(4).SweetNessPrice
            End If
            SweetenerPicked = ItemStorage.SweetnessList(4).SweetNessText
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        temp_TotalPrice = NecessaryFunctions.MilkTeaPriceBasedOnSize(ComboBox1.SelectedItem, ComboBox2.SelectedItem)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        temp_TotalPrice = NecessaryFunctions.MilkTeaPriceBasedOnSize(ComboBox1.SelectedItem, ComboBox2.SelectedItem)
    End Sub

End Class
