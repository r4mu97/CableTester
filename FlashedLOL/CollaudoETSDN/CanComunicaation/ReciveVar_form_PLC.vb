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

                    input1 = (Data(0) >> 0) And &B1
                    input2 = (Data(0) >> 1) And &B1
                    input3 = (Data(0) >> 2) And &B1
                    input4 = (Data(0) >> 3) And &B1
                    input5 = (Data(0) >> 4) And &B1
                    input6 = (Data(0) >> 5) And &B1
                    input7 = (Data(0) >> 6) And &B1
                    input8 = (Data(0) >> 7) And &B1

                    input9 = (Data(1) >> 0) And &B1
                    input10 = (Data(1) >> 1) And &B1
                    input11 = (Data(1) >> 2) And &B1
                    input12 = (Data(1) >> 3) And &B1
                    input13 = (Data(1) >> 4) And &B1
                    input14 = (Data(1) >> 5) And &B1
                    input15 = (Data(1) >> 6) And &B1
                    input16 = (Data(1) >> 7) And &B1

                    input17 = (Data(2) >> 0) And &B1
                    input18 = (Data(2) >> 1) And &B1
                    input19 = (Data(2) >> 2) And &B1
                    input20 = (Data(2) >> 3) And &B1

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
