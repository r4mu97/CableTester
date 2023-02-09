
Imports Microsoft.VisualBasic.FileIO
Imports MongoDB.Driver
Imports PdfSharp.Charting
Imports SharpCompress.Common
Imports System.IO
Public Class ReadFile

    Dim directory_of_codeCable As String = "C:\SW\_Progetti\CableTester\FlashedLOL\CablesList\"
    Public Const i As Single = 0
    Public Sub New()

    End Sub

    Public Function Read_configCable_file(code_cable_file As String)
        code_cable_file = code_cable_file + ".txt"

        Dim lines As List(Of String) = New List(Of String)

        If File.Exists(directory_of_codeCable + code_cable_file) Then
            Dim fileLines = File.ReadAllLines(directory_of_codeCable + code_cable_file)

            For Each line In fileLines
                lines.AddRange(line.Split(","c))
                Assigne_the_lines(lines, Main)
            Next
        End If

        Return lines
    End Function

    Public Function Assigne_the_lines(list_of_data As List(Of String), gui As Main)
        Dim i As Int16 = 0
        For Each datas In list_of_data
            gui.ChangeControlRichText(gui.info_text_box, list_of_data(i), "white")
            i += 1
        Next
        list_of_data.Clear()
        Return list_of_data
    End Function

End Class



