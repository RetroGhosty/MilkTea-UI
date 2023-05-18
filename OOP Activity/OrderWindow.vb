Imports Newtonsoft.Json

Public Class OrderWindow
    Public milkTeaPrice As New Menu()
    Dim tempMilkTeaPrice As Integer
    Public AddOnList As New List(Of AddOns)
    Public cart As ShoppingCart

    Private Sub ClearFields()
        Check_CocoJelly.CheckState = False
        Check_CreamCheese.CheckState = False
        Check_CreamPuff.CheckState = False
        Check_Pearl.CheckState = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load ColorSetter class as object colorSet
        Dim colorSet As New ColorSetter()
        'Set if True f
        colorSet.IsDarkMode = True
        colorSet.DarkModeSetter()
        'Setting UI color
        TopPanel.BackColor = colorSet.PrimaryColor
        TopPanelHeader_Text.ForeColor = colorSet.PrimaryText
        checkoutPnl.BackColor = colorSet.SecondaryBtnColor

        milkTeaPrice.setAListOfMilkName()

    End Sub
    Private Sub checkOut_Btn_Click(sender As Object, e As EventArgs) Handles checkOut_Btn.Click
        Dim stringID = Guid.NewGuid.ToString("N").Substring(0, 15)
        Dim getMilkTeaName = ComboBox1.SelectedText
        Dim getMilkSize = ComboBox2.SelectedText
        If cart Is Nothing Then
            cart = New ShoppingCart()
            cart.ShoppingItem = New List(Of OrderModel)
        End If
        cart.ShoppingItem.Add(New OrderModel(stringID, getMilkTeaName, tempMilkTeaPrice, getMilkSize, AddOnList))

        Label4.Text = cart.ShoppingItem(0).MilkTeaPrice

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        tempMilkTeaPrice = milkTeaPrice.milkTeaPriceBasedOnSize(ComboBox1.SelectedItem, ComboBox2.SelectedItem)
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        tempMilkTeaPrice = milkTeaPrice.milkTeaPriceBasedOnSize(ComboBox1.SelectedItem, ComboBox2.SelectedItem)
        Check_CocoJelly.Checked = False
        Check_CreamCheese.Checked = False
        Check_CreamPuff.Checked = False
        Check_Pearl.Checked = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalPrice_Value.Text = tempMilkTeaPrice
        checkoutPnl.Visible = True

    End Sub


    Private Sub Check_CreamCheese_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CreamCheese.CheckedChanged
        If Check_CreamCheese.Checked = True Then
            tempMilkTeaPrice += milkTeaPrice.XtraCreamcheese
            AddOnList.Add(New AddOns("Hello"))
        Else
            If tempMilkTeaPrice >= milkTeaPrice.XtraCreamcheese Then
                tempMilkTeaPrice -= milkTeaPrice.XtraCreamcheese
            End If
        End If
    End Sub

    Private Sub Check_Pearl_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Pearl.CheckedChanged
        If Check_Pearl.Checked = True Then
            tempMilkTeaPrice += milkTeaPrice.XtraPearl
            AddOnList.Add(New AddOns("Hello"))
        Else
            If tempMilkTeaPrice >= milkTeaPrice.XtraPearl Then
                tempMilkTeaPrice -= milkTeaPrice.XtraPearl
            End If
        End If

    End Sub

    Private Sub Check_CocoJelly_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CocoJelly.CheckedChanged
        If Check_CocoJelly.Checked = True Then
            tempMilkTeaPrice += milkTeaPrice.XtraCocoJelly
            AddOnList.Add(New AddOns("Hello"))
        Else
            If tempMilkTeaPrice >= milkTeaPrice.XtraCocoJelly Then
                tempMilkTeaPrice -= milkTeaPrice.XtraCocoJelly
            End If
        End If

    End Sub


    Private Sub Check_CreamPuff_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CreamPuff.CheckedChanged
        If Check_CreamPuff.Checked = True Then
            tempMilkTeaPrice += milkTeaPrice.XtraCreamPuff
            AddOnList.Add(New AddOns("Hello"))
        Else
            If tempMilkTeaPrice >= milkTeaPrice.XtraCreamPuff Then
                tempMilkTeaPrice -= milkTeaPrice.XtraCreamPuff
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearFields()
    End Sub
End Class
