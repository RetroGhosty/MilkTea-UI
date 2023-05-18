Imports Newtonsoft.Json

Public Class OrderWindow
    Public milkTeaPrice As New Menu()
    Dim tempMilkTeaPrice As Integer
    Public AddOnList As New List(Of AddOns)
    Public cart As ShoppingCart

    Private Sub ClearFields()
        If cart Is Nothing Then
            cart = New ShoppingCart()
            cart.ShoppingItem = New List(Of OrderModel)
        End If

        Check_CocoJelly.CheckState = False
        Check_CreamCheese.CheckState = False
        Check_CreamPuff.CheckState = False
        Check_Pearl.CheckState = False
        AddOnList.Clear()
        cart.ShoppingItem.Clear()

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
        milkTeaPrice.SetAListOfMilkName()
    End Sub

    ''START CODING BELOW

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''


End Class
