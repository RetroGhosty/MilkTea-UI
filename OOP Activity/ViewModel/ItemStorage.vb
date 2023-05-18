Public Class ItemStorage
    ''Listing all menu / Declaring list from AllClassCollection class''
    Private Shared _MilkTeaNameList As List(Of MilkTeaModel)
    Public Shared Property MilkTeaNameList() As List(Of MilkTeaModel)
        Get
            Return _MilkTeaNameList
        End Get
        Set(ByVal value As List(Of MilkTeaModel))
            _MilkTeaNameList = value
        End Set
    End Property

    Private Shared _SizeList As List(Of SizesModel)
    Public Shared Property SizeList() As List(Of SizesModel)
        Get
            Return _SizeList
        End Get
        Set(ByVal value As List(Of SizesModel))
            _SizeList = value
        End Set
    End Property

    Private Shared _AddOnsList As List(Of AddOnsMOdel)
    Public Shared Property AddOnsList() As List(Of AddOnsMOdel)
        Get
            Return _AddOnsList
        End Get
        Set(ByVal value As List(Of AddOnsMOdel))
            _AddOnsList = value
        End Set
    End Property

    Private Shared _SweetnessList As List(Of SweetnessModel)
    Public Shared Property SweetnessList() As List(Of SweetnessModel)
        Get
            Return _SweetnessList
        End Get
        Set(ByVal value As List(Of SweetnessModel))
            _SweetnessList = value
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
