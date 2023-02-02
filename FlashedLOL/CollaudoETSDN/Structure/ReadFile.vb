
Imports Microsoft.VisualBasic.FileIO
Imports MongoDB.Driver
Imports PdfSharp.Charting
Imports System.IO
Public Class ReadFile

    Dim directory_of_codeCable As String = "C:\SW\_Progetti\CableTester\FlashedLOL\CablesList\"
    Public Const i As Single = 0
    Public Sub New()

    End Sub

    Public Function Read_configCable_file(code_cable_file As String)

        Dim myFileLines As List(Of String) = File.ReadAllLines(directory_of_codeCable + code_cable_file).ToList
        Dim lines As String() = IO.File.ReadAllLines(directory_of_codeCable + code_cable_file)
        Dim list_of_data As New List(Of String())

        If Not lines Is Nothing Then
            For Each line In lines
                list_of_data.Add(line.Split(" "c))
            Next
        End If

        Return list_of_data
    End Function

End Class



