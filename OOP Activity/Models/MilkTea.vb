Public Class MilkTea

    Public Property Orderid As String
    Public Property TypeOfMilkTea As String
    Public Property MilkTeaPrice As Integer
    Public Property Size As String
    Public Property AddOns As AddOns
    Public Sub New(ByVal _Orderid As String,
                   ByVal _milkTeaName As String,
                   ByVal _milkTeaPrice As Integer,
                   ByVal _Size As String,
                   ByVal _AddOns As AddOns)
        Orderid = _Orderid
        TypeOfMilkTea = _milkTeaName
        MilkTeaPrice = _milkTeaPrice
        Size = _Size
        AddOns = _AddOns

    End Sub

End Class
