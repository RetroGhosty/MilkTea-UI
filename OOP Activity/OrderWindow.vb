Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Newtonsoft.Json



Public Class OrderWindow
    Public ReturnPriceFunc As NecessaryFunctions

    Dim temp_TotalPrice
    Public TheMenu As NecessaryFunctions
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


        UserAddOnsOrder = New List(Of String)



        'Listing Different Milk Tea
        Dim ThemilkTeaNames As New List(Of MilkTeaModel) From {
            New MilkTeaModel("Classic Milk Tea", 50),
            New MilkTeaModel("Pearl Milk Tea", 90),
            New MilkTeaModel("Honey Milk Tea", 70),
            New MilkTeaModel("Grass Jelly Milk Tea", 70),
            New MilkTeaModel("Pudding Milk Tea", 40),
            New MilkTeaModel("Red Bean Milk Tea", 50),
            New MilkTeaModel("Aloe Vera Milk Tea", 90)
        }

        'Listing Different Sizes
        Dim ThemilkTeaSizes As New List(Of SizesModel) From {
            New SizesModel("Small", 20),
            New SizesModel("Medium", 40),
            New SizesModel("Large", 50)
        }

        'Listing Different Add-ons
        Dim TheAddOns As New List(Of AddOnsMOdel) From {
            New AddOnsMOdel("Cream cheese", 10),
            New AddOnsMOdel("Boba Pearl", 10),
            New AddOnsMOdel("Coco Jelly", 10),
            New AddOnsMOdel("Cream Puff", 20),
            New AddOnsMOdel("Nata de Coco", 30)
        }

        'Listing Different Sweetness
        Dim SweetValue As New List(Of SweetnessModel) From {
            New SweetnessModel("0%", 0),
            New SweetnessModel("25%", 5),
            New SweetnessModel("50%", 10),
            New SweetnessModel("75%", 15),
            New SweetnessModel("100%", 20)
        }

        'Store the lists to ItemStorage
        ItemStorage.MilkTeaNameList = ThemilkTeaNames
        ItemStorage.SizeList = ThemilkTeaSizes
        ItemStorage.AddOnsList = TheAddOns
        ItemStorage.SweetnessList = SweetValue

        'Adding the list item to Combobox1
        For Each eachMilkTea As MilkTeaModel In ThemilkTeaNames
            ComboBox1.Items.Add(eachMilkTea.MilkTeaName)
        Next

        'Adding the list item to Combobox2
        For Each eachSize As SizesModel In ThemilkTeaSizes
            ComboBox2.Items.Add(eachSize.SizeName)
        Next

        'Modifying checkbox text from AddOn lists
        CheckBox1.Text = ItemStorage.AddOnsList(0).NameOfAddOns
        CheckBox2.Text = ItemStorage.AddOnsList(1).NameOfAddOns
        CheckBox3.Text = ItemStorage.AddOnsList(2).NameOfAddOns
        CheckBox4.Text = ItemStorage.AddOnsList(3).NameOfAddOns
        CheckBox5.Text = ItemStorage.AddOnsList(4).NameOfAddOns

        'Modifying checkbox text from Sweetener Lists
        RadioButton1.Text = ItemStorage.SweetnessList(0).SweetNessText
        RadioButton2.Text = ItemStorage.SweetnessList(1).SweetNessText
        RadioButton3.Text = ItemStorage.SweetnessList(2).SweetNessText
        RadioButton4.Text = ItemStorage.SweetnessList(3).SweetNessText
        RadioButton5.Text = ItemStorage.SweetnessList(4).SweetNessText

    End Sub





    Private Sub CreateMilkTea_Btn_Click(sender As Object, e As EventArgs) Handles CreateMilkTea_Btn.Click
        UserOrder = New List(Of OrderModel)

        UserOrder.Add(New OrderModel(NecessaryFunctions.NewIdFromRandomInt,
                                     ComboBox1.SelectedItem,
                                     temp_TotalPrice,
                                     ComboBox2.SelectedItem,
                                     UserAddOnsOrder,
                                     SweetenerPicked))

        ItemStorage.OrderList = UserOrder
        Checkout_Form.Show()
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
