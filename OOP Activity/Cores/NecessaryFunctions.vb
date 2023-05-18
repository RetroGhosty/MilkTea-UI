Public Class NecessaryFunctions

    Public Shared Function MilkTeaPriceBasedOnSize(ByVal milkTeaNameStr As String, ByVal sizeStr As String)
        For Each eachMilkTea As MilkTeaModel In ItemStorage.MilkTeaNameList
            If milkTeaNameStr = eachMilkTea.MilkTeaName Then
                If sizeStr = "Small" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(0).SizePrice
                ElseIf sizeStr = "Medium" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(1).SizePrice
                ElseIf sizeStr = "Large" Then
                    Return eachMilkTea.MilkTeaPrice + ItemStorage.SizeList(2).SizePrice
                End If
            End If
        Next
        Return 0
    End Function

    Public Shared Function NewIdFromRandomInt()
        Return Guid.NewGuid().ToString("N").Substring(0, 15)
    End Function

End Class
