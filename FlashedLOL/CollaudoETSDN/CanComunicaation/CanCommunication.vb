Public Class CanCommunication

    Protected tmr As New Stopwatch

    '       Public byteToSend As Byte

    Function InitCanOpen()
        Try
            'timer per la connessione CAN
            tmr.Start()
            'imposto un limite di 5s' per stabilire la connessione
            If tmr.ElapsedMilliseconds < 5000 And Not ReciveVar_form_PLC.GetIntance.canOpenInizialized Then

                Dim canChannels = getAvailableCanChannels()
                ReciveVar_form_PLC.GetIntance.canOpenInizialized = False

                If init_CANOPEN(canChannels(0), TPCANOPENBaudrate.PCANOPENBAUD_250K, False) Then
                    'resetto il timer 
                    tmr.Reset()
                    ReciveVar_form_PLC.GetIntance.canOpenInizialized = True
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error during init Can")
        End Try

    End Function

    '\\Function per fornire all'esterno l'inizializzazione del CAN
    Public Function is_Inizialized()
        Return ReciveVar_form_PLC.GetIntance.canOpenInizialized
    End Function



    Function SendCmdToPLC(bytesToSend As UInt32, Optional timeoutmilliseconds As Integer = 50)

        If ReciveVar_form_PLC.GetIntance.canOpenInizialized Then

            Dim canMsg As New TPCANOPENMsg()

            canMsg.ID = &H400
            canMsg.LEN = 8
            canMsg.DATA = New Byte() {0, 0, 0, 0, 0, 0, 0, 0}

            canMsg.DATA(0) = Convert.ToByte(bytesToSend And &HFF)
            canMsg.DATA(1) = Convert.ToByte((bytesToSend >> 8) And &HFF)
            canMsg.DATA(2) = Convert.ToByte((bytesToSend >> 16) And &HFF)
            canMsg.DATA(3) = Convert.ToByte((bytesToSend >> 24) And &HFF)

            sendCANMessage(canMsg)

        End If



    End Function

End Class
