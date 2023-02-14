Imports System.IO
Imports System.Collections.Generic
Public Class Read_File_CSV
    Dim directory_of_codeCable As String = "C:\SW\_Progetti\CableTester\FlashedLOL\CablesList\"
    Dim can_tx As New SendVar_to_PLC

    Public Function ReadCSV(code_cable_file As String, gui As Main)
        code_cable_file = code_cable_file + ".CSV"

        Dim map_output As New Dictionary(Of Integer, String)
        Dim map_input As New Dictionary(Of Integer, String)

        Const MAX_OUTPUTS As Integer = 20
        Const MAX_INPUTS As Integer = 20

        Const OUTPUT_PIN_INDEX As Integer = 0
        Const OUTPUT_LABEL_INDEX As Integer = 1
        Const INPUT_PIN_INDEX As Integer = 2
        Const INPUT_LABEL_INDEX As Integer = 3

        Dim map_connection As New Dictionary(Of Integer, BitArray)
        For index = 1 To MAX_OUTPUTS
            Dim initial_bitarray As New BitArray(MAX_INPUTS)
            map_connection.Add(index, initial_bitarray)
        Next

        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser((directory_of_codeCable + code_cable_file))
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(";")

        Dim currentRow As String()

        While Not TextFileReader.EndOfData

            Try
                currentRow = TextFileReader.ReadFields()
                Dim output_pin As Integer = currentRow(OUTPUT_PIN_INDEX)
                Dim output_label As String = currentRow(OUTPUT_LABEL_INDEX)
                Dim input_pin As Integer = currentRow(INPUT_PIN_INDEX)
                Dim input_label As String = currentRow(INPUT_LABEL_INDEX)

                If Not map_output.ContainsKey(output_pin) Then
                    map_output.Add(output_pin, output_label)
                End If

                If Not map_input.ContainsKey(input_pin) Then
                    map_input.Add(input_pin, input_label)
                End If

                If map_connection.ContainsKey(output_pin) Then
                    Dim pin_connections As BitArray = map_connection(output_pin)
                    pin_connections(input_pin - 1) = True
                    map_connection(output_pin) = pin_connections
                End If

            Catch ex As Exception
                gui.ChangeControlRichText(gui.info_text_box, "red", ex.ToString)

            End Try
        End While

        For Each entry In map_output
            Dim connections = map_connection(entry.Key)
            'invio alla centralina il pin da alzare 
            can_tx.SetOutput(entry.Key)
            Threading.Thread.Sleep(1000)
            'leggo i messaggi can 
            Dim can_data = ReciveVar_form_PLC.GetIntance.GetDataCan()

            For i = 0 To MAX_INPUTS - 1

                If (((can_data >> i) And &B1) = 1) = connections(i) Then
                    'gui.ChangeControlRichText(gui.info_text_box, "Green", "OK")
                Else
                    If map_input.ContainsKey(i + 1) Then
                        If connections(i) = True Then
                            gui.ChangeControlRichText(gui.info_text_box, "Red", "Alimentato ", entry.Key.ToString, " Non ", map_input(i + 1))
                        Else
                            gui.ChangeControlRichText(gui.info_text_box, "Red", "Alimentato ", entry.Key.ToString, " Alzato ", map_input(i + 1))
                        End If
                    End If
                End If
            Next

        Next
        Return map_connection
        'ReciveVar_form_PLC.GetIntance.GetDataCan()

    End Function




















    'code_cable_file = code_cable_file + ".CSV"

    'Dim lines_of_Output As List(Of String) = New List(Of String) '//creo la lista degli output del file
    'Dim lines_of_Input As List(Of String) = New List(Of String)  '//creo la lista degli input del file

    'Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser((directory_of_codeCable + code_cable_file))
    'TextFileReader.TextFieldType = FileIO.FieldType.Delimited
    'TextFileReader.SetDelimiters(";")

    'Dim currentRow As String()
    'Dim i As Int16 = 0
    'Dim y As Int16 = 0

    'While Not TextFileReader.EndOfData
    '    Try
    '        currentRow = TextFileReader.ReadFields()                                    '//funzione che mi permette di leggere tutta la riga di una colonna 
    '        If Not lines_of_Output.Contains(currentRow(0) & currentRow(1)) Then         '//check per scartare valori uguali 
    '            lines_of_Output.Add(currentRow(0) & currentRow(1))                      '//aggiungo solo la casella che mi interessa e l'associo 
    '            Console.WriteLine(lines_of_Output(y))
    '            y += 1
    '        End If
    '        lines_of_Input.Add(currentRow(2) & currentRow(3))
    '    Catch ex As Exception

    '    End Try
    '    Console.WriteLine(lines_of_Input(i))
    '    i += 1
    'End While









































    'Function ReadCSV(filePath As String) As Dictionary(Of String, List(Of String()))
    '        Dim result As New Dictionary(Of String, List(Of String()))
    '    filePath = filePath + ".CSV"
    '    Using reader As StreamReader = New StreamReader(directory_of_codeCable + filePath)

    '        Dim headerLine = reader.ReadLine()
    '        Dim headers = headerLine.Split(","c)

    '        While Not reader.EndOfStream
    '            Dim line = reader.ReadLine()
    '            Dim values = line.Split(","c)
    '            Dim row = headers.Zip(values, Function(h, v) New String() {h, v}).ToArray()

    '            For Each header In headers
    '                If Not result.ContainsKey(header) Then
    '                    result(header) = New List(Of String())
    '                End If
    '            Next

    '            For Each r In row
    '                result(r(0)).Add(r)
    '            Next
    '        End While
    '    End Using

    '    Return result
    '    End Function

    'Sub Main()
    '    Dim data = ReadCSV("data.csv")

    '    For Each key In data.Keys
    '        Console.WriteLine(key)
    '        For Each value In data(key)
    '            Console.WriteLine("  " & value.ToString)
    '        Next
    '    Next

    '    Console.ReadLine()
    'End Sub

End Class
