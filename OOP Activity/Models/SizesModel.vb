Public Class SizesModel
    Public Property SizeName As String
    Public Property SizePrice As Integer

    Public Sub New(ByVal _sizeName As String, ByVal _sizePrice As Integer)
        SizeName = _sizeName
        SizePrice = _sizePrice
    End Sub
End Class
