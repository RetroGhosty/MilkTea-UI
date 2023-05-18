Public Class Menu
    'Default value


    Public milkteaList As New List(Of TypeOfMilkTea)

    Public Sub SetAListOfMilkName()
        milkteaList.Add(New TypeOfMilkTea("Classic Milk Tea", 60))
        milkteaList.Add(New TypeOfMilkTea("Pearl Milk Tea", 65))
        milkteaList.Add(New TypeOfMilkTea("Honey Milk Tea", 80))
        milkteaList.Add(New TypeOfMilkTea("Grass Jelly Milk Tea", 95))
        milkteaList.Add(New TypeOfMilkTea("Pudding Milk Tea", 80))
        milkteaList.Add(New TypeOfMilkTea("Red Bean Milk Tea", 90))
        milkteaList.Add(New TypeOfMilkTea("Aloe Vera Milk Tea", 100))
    End Sub

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
