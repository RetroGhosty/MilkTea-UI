Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Newtonsoft.Json

Public Class OrderWindow
    Public milkTeaPrice As New Menu()
    Dim tempMilkTeaPrice As Integer
    Public AddOnList As New List(Of AddOns)
    Private Sub ClearFields()
        Check_CocoJelly.CheckState = False
        Check_CreamCheese.CheckState = False
        Check_CreamPuff.CheckState = False
        Check_Pearl.CheckState = False
        AddOnList.Clear()
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

        Dim ViewModelOrder As ItemStorage = New ItemStorage()
        Dim milkTeaNames As List(Of TypeOfMilkTea) = ViewModelOrder.MilkTeaNameList
        'milkTeaNames.Add(New TypeOfMilkTea("Bro", 50))
        ViewModelOrder.MilkTeaNameList = milkTeaNames

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainWindow.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    ''START CODING BELOW THIS LINE
    ''testttssss

End Class
