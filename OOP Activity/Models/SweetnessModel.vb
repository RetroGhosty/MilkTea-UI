Public Class SweetnessModel
    Public Property SweetNessText As String
    Public Property SweetNessPrice As Integer
    Public Sub New(ByVal _sweetText As String, ByVal _sweetPrice As Integer)
        SweetNessText = _sweetText
        SweetNessPrice = _sweetPrice
    End Sub
End Class
