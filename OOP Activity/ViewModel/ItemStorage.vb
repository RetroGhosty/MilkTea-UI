Public Class ItemStorage
    ''Listing all menu / Declaring list from AllClassCollection class''
    Dim MilkCollection As AllClassCollection = New AllClassCollection()
    Private Shared _MilkTeaNameList As List(Of TypeOfMilkTea)
    Public Shared Property MilkTeaNameList() As List(Of TypeOfMilkTea)
        Get
            Return _MilkTeaNameList
        End Get
        Set(ByVal value As List(Of TypeOfMilkTea))
            _MilkTeaNameList = value
        End Set
    End Property

    Private Shared _AddOnsList As List(Of AddOns)
    Public Shared Property AddOnsList() As List(Of AddOns)
        Get
            Return _AddOnsList
        End Get
        Set(ByVal value As List(Of AddOns))
            _AddOnsList = value
        End Set
    End Property

    Private Shared _OrderList As List(Of OrderModel)
    Public Shared Property OrderList() As List(Of OrderModel)
        Get
            Return _OrderList
        End Get
        Set(ByVal value As List(Of OrderModel))
            _OrderList = value
        End Set
    End Property

End Class
