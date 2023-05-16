Imports Newtonsoft.Json

Public Class Form1
    Dim milkTeaModel As MilkTea
    Dim addOnsModel As AddOns = New AddOns()
    Dim jsonData As New jsonDataHandler()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load ColorSetter class as object colorSet
        Dim colorSet As New ColorSetter()
        'Set if True
        colorSet.IsDarkMode = True
        colorSet.DarkModeSetter()
        'Setting UI color
        TopPanel.BackColor = colorSet.PrimaryColor
        TopPanelHeader_Text.ForeColor = colorSet.PrimaryText
        checkoutPnl.BackColor = colorSet.SecondaryBtnColor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stringID = Guid.NewGuid.ToString("N").Substring(0, 15)

        Dim getMilkTeaName = ComboBox1.SelectedItem
        Dim getMilkPrice = ComboBox2.SelectedItem

        milkTeaModel = New MilkTea(stringID, getMilkTeaName, 0, getMilkPrice, addOnsModel)
        checkoutPnl.Visible = True

        jsonData.AppendHand(milkTeaModel)

    End Sub

    Private Sub Check_CreamCheese_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CreamCheese.CheckedChanged
        If Check_CreamCheese.Checked = True Then
            addOnsModel.xtraCreamcheese = Check_CreamCheese.Text
        Else
            addOnsModel.xtraCreamcheese = Nothing
        End If
    End Sub

    Private Sub Check_Pearl_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Pearl.CheckedChanged
        If Check_Pearl.Checked = True Then
            addOnsModel.xtraPearl = Check_Pearl.Text
        Else
            addOnsModel.xtraPearl = Nothing
        End If
    End Sub

    Private Sub Check_CocoJelly_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CocoJelly.CheckedChanged
        If Check_CocoJelly.Checked = True Then
            addOnsModel.xtraCocoJelly = Check_CocoJelly.Text
        Else
            addOnsModel.xtraCocoJelly = Nothing
        End If
    End Sub

    Private Sub Check_CreamPuff_CheckedChanged(sender As Object, e As EventArgs) Handles Check_CreamPuff.CheckedChanged
        If Check_CreamPuff.Checked = True Then
            addOnsModel.xtraCreamPuff = Check_CreamPuff.Text
        Else
            addOnsModel.xtraCreamPuff = Nothing
        End If
    End Sub
End Class
