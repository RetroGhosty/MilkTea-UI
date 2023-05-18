Public Class OrderModel

    Public Property Orderid As String
    Public Property TypeOfMilkTeam As String
    Public Property MilkTeaPrice As Integer
    Public Property Size As String
    Public Property AddOns As List(Of AddOns)

    Public Sub New(ByVal _orderID As String, ByVal _TypeOfMilkTea As String, ByVal _MilkTeaPrice As Integer, ByVal _Size As String, ByVal _AddOns As IEnumerable(Of AddOns))
        Orderid = _orderID
        TypeOfMilkTeam = _TypeOfMilkTea
        MilkTeaPrice = _MilkTeaPrice
        Size = _Size
        AddOns = _AddOns
    End Sub
End Class
