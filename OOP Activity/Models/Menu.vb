Public Class Menu
    'Default value


    Public milkteaList As New List(Of TypeOfMilkTea)


    Public Function MilkTeaPriceBasedOnSize(ByVal milkTeaNameStr As String, ByVal sizeStr As String)
        For Each eachMilkTea As TypeOfMilkTea In milkteaList
            If milkTeaNameStr = eachMilkTea.MilkTeaName Then
                If sizeStr = "Small" Then
                    Return eachMilkTea.MilkTeaPrice + Small
                ElseIf sizeStr = "Medium" Then
                    Return eachMilkTea.MilkTeaPrice + Medium
                ElseIf sizeStr = "Large" Then
                    Return eachMilkTea.MilkTeaPrice + Large
                End If
            End If
        Next
        Return 0
    End Function


    Const Small As Integer = 30
    Const Medium As Integer = 50
    Const Large As Integer = 60

    ReadOnly Property XtraPearl As Integer = 20
    ReadOnly Property XtraCreamcheese As Integer = 50
    ReadOnly Property XtraCocoJelly As Integer = 50
    ReadOnly Property XtraCreamPuff As Integer = 50
End Class
