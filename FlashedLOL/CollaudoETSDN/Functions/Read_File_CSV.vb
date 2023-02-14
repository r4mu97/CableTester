Imports System.IO
Imports System.Collections.Generic
Public Class Read_File_CSV
    Dim can_tx As New SendVar_to_PLC
    Dim path_of_codeCable As String = Application.StartupPath & "\\CablesList\\"


    Const MAX_OUTPUTS As Integer = 20
    Const MAX_INPUTS As Integer = 20

    Const OUTPUT_PIN_INDEX As Integer = 0
    Const OUTPUT_LABEL_INDEX As Integer = 1

    Const INPUT_PIN_INDEX As Integer = 2
    Const INPUT_LABEL_INDEX As Integer = 3


    Public Function ReadCSV(code_cable_file As String, gui As Main)

        If File.Exists(path_of_codeCable & code_cable_file) Then

            Dim map_output As New Dictionary(Of Integer, String)
            Dim map_input As New Dictionary(Of Integer, String)
            Dim map_connection As New Dictionary(Of Integer, BitArray)

            For index = 1 To MAX_OUTPUTS
                Dim initial_bitarray As New BitArray(MAX_INPUTS)
                map_connection.Add(index, initial_bitarray)
            Next


            Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser((path_of_codeCable + code_cable_file))
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
        Else
            If Not code_cable_file = Nothing Then
                MsgBox(code_cable_file.ToString & " not found")
            End If
        End If
    End Function

End Class
