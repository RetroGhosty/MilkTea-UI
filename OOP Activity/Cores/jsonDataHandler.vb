Imports Newtonsoft.Json

Public Class jsonDataHandler
    Public Sub AppendHand(ByVal milkteaModel As MilkTea)
        Dim serialized As String = JsonConvert.SerializeObject(milkteaModel, Formatting.Indented)
        Dim file As IO.StreamWriter
        Dim dirPath As String = My.Computer.FileSystem.CurrentDirectory
        file = My.Computer.FileSystem.OpenTextFileWriter("datalogs.json", True)
        file.WriteLine(serialized)
        file.Close()
    End Sub

End Class
