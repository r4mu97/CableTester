
Imports Microsoft.VisualBasic.FileIO
Imports MongoDB.Driver
Imports System.IO
Public Class ReadFile

    Dim path As String = Application.StartupPath + "\CablesList\"
    'Dim FILE_NAME As String = "C:\SW\_Progetti\CableTester\newFile.txt"
    'Dim lines = File.ReadAllLines(FILE_NAME)
    'Dim numbers(lines.Length - 1) As Single
    'Dim index As Integer
    Public Sub New()
        'generateData = IO.File.AppendText(path)
    End Sub

    Public Function Read_all_file(name_of_file As String)

        Dim myFileLines As List(Of String) = IO.File.ReadAllLines(path + name_of_file).ToList
        Dim value As String

        For Each strLineOfTheFile As String In myFileLines

            value &= strLineOfTheFile & "."

        Next
        Console.WriteLine(value.ToString)
        'For Each s As String In lines
        '    Dim fields = s.Split(","c)
        '    'numbers(index) = CSng(fields(1))
        '    'index += 1
        'Next
        'For Each n As Single In numbers
        '    Console.WriteLine(n.ToString)
        'Next
    End Function







    'Public Function WriteCSVfile(gui As MainEtsdn)
    '    Dim generateData As New System.IO.StreamWriter(Application.StartupPath & "\\log\\Etsdn\\RaccoltaDati.csv")
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim text As String
    '    For i = 0 To gui.DataGridView1.Rows.Count - 2

    '        text = ""
    '        For j = 0 To 2
    '            text = text & gui.DataGridView1.Rows(i).Cells(j).Value & ";"
    '        Next
    '        generateData.WriteLine(text)
    '    Next
    '    generateData.Close()
    'End Function
    'Public Function WriteDate(today As String)
    '    generateData.Write(today)
    'End Function
    'Public Function WriteStructure(nameOfTest As String)
    '    generateData.Write(nameOfTest)
    'End Function

    'Public Function WriteSerialDevice(serial As String)
    '    generateData.Write(serial & ";")
    'End Function

    'Public Function WriteResult(result As String)
    '    generateData.Write(result & ";")
    'End Function

    'Public Function WriteError(errorInfo As String)
    '    generateData.Write(errorInfo & ";")
    'End Function

    'Public Function OpenCSVfile()
    '    'generateData = IO.File.AppendText(path)
    'End Function

    'Public Function CloseCSVfile()
    '    generateData.Close()
    'End Function

End Class
