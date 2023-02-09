Imports FlashedLOL.Peak.Can.Basic

Public Class ReciveVar_form_PLC

    Public canOpenInizialized As Boolean
    Public timerComunicationCan As New Stopwatch
    Public input1, input2, input3, input4, input5, input6, input7, input8, input9, input10,
           input11, input12, input13, input14, input15, input16, input17, input18, input19, input20 As Single
    Private latest_can_data As UInt32 = 0

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property GetIntance As ReciveVar_form_PLC

        Get
            Static varETSDN As New ReciveVar_form_PLC
            Return varETSDN

        End Get
    End Property

    Public Sub ParsingMSG(ID, Data)
        timerComunicationCan.Start()
        Try

            Select Case (ID)
                Case &H100
                    latest_can_data = Convert.ToSingle(Data(0)) + (Convert.ToSingle(Data(1)) << 8) + (Convert.ToSingle(Data(2)) << 16) + (Convert.ToSingle(Data(3)) << 24)
            End Select

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Public Function GetDataCan()
        Return latest_can_data
    End Function

    Public Function GetCurrentMillis()
        Dim temp As New DateTime(1970, 1, 1)

        Dim elapsTemp = (DateTime.Now.Millisecond - temp.Millisecond)

        Return elapsTemp
    End Function
    Public Function ScanParseMsg(Optional timeoutmilliseconds As Integer = 100)

        While True
            Dim raw_msg As New TPCANMsg()
            Dim sw As New Stopwatch

            sw.Restart()

            While sw.ElapsedMilliseconds <= timeoutmilliseconds

                If receiveCANMessage(raw_msg) Then
                    Dim ID = raw_msg.ID
                    Dim DATA = raw_msg.DATA
                End If

                ParsingMSG(raw_msg.ID, raw_msg.DATA)
            End While
        End While
    End Function

End Class
