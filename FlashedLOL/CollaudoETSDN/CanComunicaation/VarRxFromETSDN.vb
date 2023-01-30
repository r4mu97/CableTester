Imports FlashedLOL.Peak.Can.Basic

Public Class VarRxFromETSDN
    Public vTensione As Single
    Public xStatoRL1, xStatoRL2, xStatoRL3 As Boolean
    Public xStatoIP1, xStatoIP2, xStatoIN1, xStatoIN2 As Single
    Public rANA5, rANA10, r5V, rSupplyANA10v, rSupplyANA5v As Single
    Public axisX, axisY, axisZ As Single
    Public plcEcuK15, plcPowerCurr, plc5V As Double
    Public vCurrentRL1, vCurrentRL2, vCurrentRL3 As Single
    Public rSupplyVoltageEtsdn As UInteger
    Public MsgCanPLC As Single
    Public etsdnOnline As Boolean
    Public etsdnSN As String = ""
    Public pos1, pos2, pos3 As UInt32
    Public canOpenInizialized As Boolean
    Public timerComunicationCan As New Stopwatch
    Public oldpos1, oldpos2, oldpos3 As UInt32
    Dim triangle As New Form2
    Public stOperation As Boolean
    Public tmr1, tmr2, tmr3 As New Stopwatch
    Public cycleTm1, cycleTm2, cycleTm3

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property GetIntance As VarRxFromETSDN

        Get
            Static varETSDN As New VarRxFromETSDN
            Return varETSDN

        End Get
    End Property

    Public Sub ParsingMSG(ID, Data)

        Static Dim etsdnSN01 As String
        Static Dim etsdnSN02 As String
        Static Dim etsdnSN03 As String
        timerComunicationCan.Start()
        Try


            Select Case (ID)

                Case &H381
                    Dim tagID
                    tagID = Convert.ToUInt32(Data(0)) + (Convert.ToUInt32(Data(1)) << 8) + (Convert.ToUInt32(Data(2)) << 16) + (Convert.ToUInt32(Data(3)) << 24)

                    If tagID = &H48C20833 Then
                        pos1 = Convert.ToUInt32(Data(4)) + (Convert.ToUInt32(Data(5)) << 8) + (Convert.ToUInt32(Data(6)) << 16) + (Convert.ToUInt32(Data(7)) << 24)
                        If pos1 <> oldpos1 Then
                            oldpos1 = pos1
                            Console.WriteLine("pos1=" & pos1)
                        End If
                        cycleTm1 = GetCurrentMillis()
                    End If
                Case &H382
                    Dim tagID
                    tagID = Convert.ToUInt32(Data(0)) + (Convert.ToUInt32(Data(1)) << 8) + (Convert.ToUInt32(Data(2)) << 16) + (Convert.ToUInt32(Data(3)) << 24)
                    If tagID = &H48C20833 Then
                        pos2 = Convert.ToUInt32(Data(4)) + (Convert.ToUInt32(Data(5)) << 8) + (Convert.ToUInt32(Data(6)) << 16) + (Convert.ToUInt32(Data(7)) << 24)
                        If pos2 <> oldpos2 Then
                            oldpos2 = pos2
                            Console.WriteLine("pos2=" & pos2)
                        End If
                        cycleTm2 = GetCurrentMillis()
                    End If
                Case &H383
                    Dim tagID
                    tagID = Convert.ToUInt32(Data(0)) + (Convert.ToUInt32(Data(1)) << 8) + (Convert.ToUInt32(Data(2)) << 16) + (Convert.ToUInt32(Data(3)) << 24)
                    If tagID = &H48C20833 Then
                        pos3 = Convert.ToUInt32(Data(4)) + (Convert.ToUInt32(Data(5)) << 8) + (Convert.ToUInt32(Data(6)) << 16) + (Convert.ToUInt32(Data(7)) << 24)
                        If pos3 <> oldpos3 Then
                            oldpos3 = pos3
                            Console.WriteLine("pos3=" & pos3)
                        End If
                        cycleTm3 = GetCurrentMillis()
                    End If
                    Console.WriteLine(cycleTm3)
            End Select


        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Public Function GetCurrentMillis()
        Dim temp As New DateTime(1970, 1, 1)

        Dim elapsTemp = (DateTime.Now.Millisecond - temp.Millisecond)

        Return elapsTemp
    End Function
    Public Function ScanParseMsg(Optional timeoutmilliseconds As Integer = 100)

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
    End Function

End Class
