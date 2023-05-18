Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class NecessaryFunctions

    Public Shared Function MilkTeaPriceBasedOnSize(ByVal milkTeaNameStr As String, ByVal sizeStr As String)
        For Each eachMilkTea As MilkTeaModel In ItemStorage.MilkTeaNameList
            If milkTeaNameStr = eachMilkTea.MilkTeaName Then
                If sizeStr = "Small" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(0).SizePrice
                ElseIf sizeStr = "Medium" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(1).SizePrice
                ElseIf sizeStr = "Large" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(2).SizePrice
                End If
            End If
        Next
        Return 0
    End Function

    Public Shared Function NewIdFromRandomInt()
        Return Guid.NewGuid().ToString("N").Substring(0, 15)
    End Function

    Public Shared Sub ListThis()
        OrderWindow.UserAddOnsOrder = New List(Of String)

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
            OrderWindow.ComboBox1.Items.Add(eachMilkTea.MilkTeaName)
        Next

        'Adding the list item to Combobox2
        For Each eachSize As SizesModel In ThemilkTeaSizes
            OrderWindow.ComboBox2.Items.Add(eachSize.SizeName)
        Next

        'Modifying checkbox text from AddOn lists
        OrderWindow.CheckBox1.Text = ItemStorage.AddOnsList(0).NameOfAddOns
        OrderWindow.CheckBox2.Text = ItemStorage.AddOnsList(1).NameOfAddOns
        OrderWindow.CheckBox3.Text = ItemStorage.AddOnsList(2).NameOfAddOns
        OrderWindow.CheckBox4.Text = ItemStorage.AddOnsList(3).NameOfAddOns
        OrderWindow.CheckBox5.Text = ItemStorage.AddOnsList(4).NameOfAddOns

        'Modifying checkbox text from Sweetener Lists
        OrderWindow.RadioButton1.Text = ItemStorage.SweetnessList(0).SweetNessText
        OrderWindow.RadioButton2.Text = ItemStorage.SweetnessList(1).SweetNessText
        OrderWindow.RadioButton3.Text = ItemStorage.SweetnessList(2).SweetNessText
        OrderWindow.RadioButton4.Text = ItemStorage.SweetnessList(3).SweetNessText
        OrderWindow.RadioButton5.Text = ItemStorage.SweetnessList(4).SweetNessText

    End Sub

    Public Shared Sub SetMenuValue()
        'Menu Flavor
        OrderWindow.Label6.Text = ItemStorage.MilkTeaNameList(0).MilkTeaName
        OrderWindow.Label7.Text = ItemStorage.MilkTeaNameList(1).MilkTeaName
        OrderWindow.Label8.Text = ItemStorage.MilkTeaNameList(2).MilkTeaName
        OrderWindow.Label9.Text = ItemStorage.MilkTeaNameList(3).MilkTeaName
        OrderWindow.Label10.Text = ItemStorage.MilkTeaNameList(4).MilkTeaName
        OrderWindow.Label11.Text = ItemStorage.MilkTeaNameList(5).MilkTeaName
        OrderWindow.Label12.Text = ItemStorage.MilkTeaNameList(6).MilkTeaName
        'Menu Flavor Price
        OrderWindow.Label13.Text = ItemStorage.MilkTeaNameList(0).MilkTeaPrice
        OrderWindow.Label14.Text = ItemStorage.MilkTeaNameList(1).MilkTeaPrice
        OrderWindow.Label15.Text = ItemStorage.MilkTeaNameList(2).MilkTeaPrice
        OrderWindow.Label16.Text = ItemStorage.MilkTeaNameList(3).MilkTeaPrice
        OrderWindow.Label17.Text = ItemStorage.MilkTeaNameList(4).MilkTeaPrice
        OrderWindow.Label18.Text = ItemStorage.MilkTeaNameList(5).MilkTeaPrice
        OrderWindow.Label19.Text = ItemStorage.MilkTeaNameList(6).MilkTeaPrice
        'Menu Sizes
        OrderWindow.Label21.Text = ItemStorage.SizeList(0).SizeName
        OrderWindow.Label22.Text = ItemStorage.SizeList(1).SizeName
        OrderWindow.Label23.Text = ItemStorage.SizeList(2).SizeName
        'Menu Sizes Price
        OrderWindow.Label24.Text = ItemStorage.SizeList(0).SizePrice
        OrderWindow.Label25.Text = ItemStorage.SizeList(1).SizePrice
        OrderWindow.Label26.Text = ItemStorage.SizeList(2).SizePrice
        'Sweetness Level
        OrderWindow.Label28.Text = ItemStorage.SweetnessList(0).SweetNessText
        OrderWindow.Label29.Text = ItemStorage.SweetnessList(1).SweetNessText
        OrderWindow.Label30.Text = ItemStorage.SweetnessList(2).SweetNessText
        OrderWindow.Label31.Text = ItemStorage.SweetnessList(3).SweetNessText
        OrderWindow.Label32.Text = ItemStorage.SweetnessList(4).SweetNessText
        'Sweetness Level Price
        OrderWindow.Label33.Text = ItemStorage.SweetnessList(0).SweetNessPrice
        OrderWindow.Label34.Text = ItemStorage.SweetnessList(1).SweetNessPrice
        OrderWindow.Label35.Text = ItemStorage.SweetnessList(2).SweetNessPrice
        OrderWindow.Label36.Text = ItemStorage.SweetnessList(3).SweetNessPrice
        OrderWindow.Label37.Text = ItemStorage.SweetnessList(4).SweetNessPrice
        'AddOns
        OrderWindow.Label39.Text = ItemStorage.AddOnsList(0).NameOfAddOns
        OrderWindow.Label40.Text = ItemStorage.AddOnsList(1).NameOfAddOns
        OrderWindow.Label41.Text = ItemStorage.AddOnsList(2).NameOfAddOns
        OrderWindow.Label42.Text = ItemStorage.AddOnsList(3).NameOfAddOns
        OrderWindow.Label43.Text = ItemStorage.AddOnsList(4).NameOfAddOns
        'AddOns Prices
        OrderWindow.Label44.Text = ItemStorage.AddOnsList(0).PriceOfAddOns
        OrderWindow.Label45.Text = ItemStorage.AddOnsList(1).PriceOfAddOns
        OrderWindow.Label46.Text = ItemStorage.AddOnsList(2).PriceOfAddOns
        OrderWindow.Label47.Text = ItemStorage.AddOnsList(3).PriceOfAddOns
        OrderWindow.Label48.Text = ItemStorage.AddOnsList(4).PriceOfAddOns


    End Sub

End Class
