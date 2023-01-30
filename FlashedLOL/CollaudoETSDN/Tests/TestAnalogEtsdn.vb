Public Class TestAnalogEtsdn
    Inherits PrototypTest

    Dim resultAna5v As Boolean
    Dim resultAna10v As Boolean
    Dim cFailANA5 As Integer = 0
    Dim cFailANA10 As Integer = 0
    'soglie impostate nel mainEtsdn
    Dim tmrTest_threshold As Integer
    Dim minimum_threshold_gap As Integer
    Dim maximum_threshold_gap As Integer
    Dim minimum_threshold_fail As Integer
    Dim maximum_threshold_fail As Integer



    Public Overrides Function Execute(gui As MainEtsdn) As TestResult

        nameOftest = "Test Analog"
        testSuccess = False
        testCompleted = False
        varTxEtsdn.SetState10V(1)
        varTxEtsdn.SetState5V(1)
        'gui.ChangeControlLocation(gui.StatoTestAnalog, 197, 0)
        gui.StatoTestAnalog.Image = My.Resources.Res.load

        Dim errorResult As New TestError

        'timer test analog
        tmrTest.Start()
        'timer durata test 
        Do
            gui.ChangeControlText(gui.ANAVolt5, ReciveVar_form_PLC.GetIntance.rANA5 / 10 & "V")
            gui.ChangeControlText(gui.ANAVolt10, ReciveVar_form_PLC.GetIntance.rSupplyANA10v / 10 & "V")
            'scannerrizzo se ci sono nuovi messaggi dal can 
            ReciveVar_form_PLC.GetIntance.ScanParseMsg()
            'controllo fail deve stare sotto la soglia impostata 
            Dim gapAnalog5V = ReciveVar_form_PLC.GetIntance.rANA5 - ReciveVar_form_PLC.GetIntance.rSupplyANA5v
            If (cFailANA5 >= minimum_threshold_fail And cFailANA5 < maximum_threshold_fail) Then
                resultAna5v = True
                'aumento fail se il gap supera la soglia                 
                If Math.Abs(gapAnalog5V) > maximum_threshold_gap Then
                    cFailANA5 += 3
                Else
                    'decremento fail se il gap non supera la soglia
                    If cFailANA5 >= minimum_threshold_gap Then
                        cFailANA5 -= 2
                    End If
                End If
            Else
                resultAna5v = False
                viewError = errorResult.GetError(12, ReciveVar_form_PLC.GetIntance.rANA5)
            End If

            Dim gapAnalog10V = ReciveVar_form_PLC.GetIntance.rANA10 - ReciveVar_form_PLC.GetIntance.rSupplyANA10v
            'controllo fail deve stare sotto la soglia impostata 
            If (cFailANA10 >= minimum_threshold_fail And cFailANA10 < maximum_threshold_fail) Then
                resultAna10v = True
                'aumento fail se il gap supera la soglia 
                If Math.Abs(gapAnalog10V) > maximum_threshold_gap Then
                    cFailANA10 += 3
                Else
                    'decremento fail se la soglia non viene superata
                    If cFailANA10 >= minimum_threshold_gap Then
                        cFailANA10 -= 2
                    End If
                End If
            Else
                resultAna10v = False
                viewError = errorResult.GetError(13, ReciveVar_form_PLC.GetIntance.rSupplyANA10v)
            End If

            If tmrTest.ElapsedMilliseconds >= 6000 Then
                If resultAna5v And resultAna10v Then
                    testCompleted = True
                    testSuccess = True
                    gui.StatoTestAnalog.Image = My.Resources.Correct
                    Exit Do
                End If
            End If
            canEtsdnVar.SendCmdToAncor(varTxEtsdn.MsgComposer(), 20)
        Loop While tmrTest.ElapsedMilliseconds <= tmrTest_threshold

        If Not testSuccess Then
            gui.StatoTestAnalog.Image = My.Resources.Res.error_FILL
            'gui.ChangeControlLocation(gui.StatoTestAnalog, 0, 42)
        End If
        tmrTest.Reset()
        varTxEtsdn.SetState10V(0)
        varTxEtsdn.SetState5V(0)

        Dim result As New TestResultAnalog(testCompleted, testSuccess, resultAna5v, resultAna10v, nameOftest, viewError, ReciveVar_form_PLC.GetIntance.etsdnSN, gui.ckBox_Ana.Checked)
        Return result

    End Function


    Public Sub New(tmrTest_threshold As Integer, minimum_threshold_gap As Integer, maximum_threshold_gap As Integer,
                   minimum_threshold_fail As Integer, maximum_threshold_fail As Integer)
        MyBase.New()
        Me.tmrTest_threshold = tmrTest_threshold
        Me.minimum_threshold_gap = minimum_threshold_gap
        Me.maximum_threshold_gap = maximum_threshold_gap
        Me.minimum_threshold_fail = minimum_threshold_fail
        Me.maximum_threshold_fail = maximum_threshold_fail
    End Sub
End Class

'max gap 10 min 10 
'max fail 50 min 0
'ana10 min -2 max 50
'