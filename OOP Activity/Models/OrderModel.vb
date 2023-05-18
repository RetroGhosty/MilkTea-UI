Public Class OrderModel

    Public Property Orderid As String
    Public Property TypeOfMilkTeam As String
    Public Property MilkTeaPrice As Integer
    Public Property Size As String
    Public Property AddOns As List(Of String)
    Public Property ChosenSweetener As String

    Public Sub New(ByVal _orderID As String, ByVal _TypeOfMilkTea As String, ByVal _MilkTeaPrice As Integer, ByVal _Size As String, ByVal _AddOns As List(Of String), ByVal _ChosenSweetener As String)
        Orderid = _orderID
        TypeOfMilkTeam = _TypeOfMilkTea
        MilkTeaPrice = _MilkTeaPrice
        Size = _Size
        AddOns = _AddOns
        ChosenSweetener = _ChosenSweetener
    End Sub
End Class
