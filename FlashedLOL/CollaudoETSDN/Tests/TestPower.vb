﻿Imports System.Threading
Imports FlashedLOL.MainEtsdn

Public Class TestPowerEtsdn
    Inherits PrototypTest

    'soglie impostate nel mainEtsdn
    Dim tmrTest_threshold As Integer
    Dim minimum_threshold_plc As Integer
    Dim maximum_threshold_plc As Integer

    Public Overrides Function Execute(gui As MainEtsdn) As TestResult
        nameOftest = "TestPower"
        testSuccess = False    'setto la variabile a false per i test successivi 
        testCompleted = False  'setto la variabile a false per i test successivi 
        tmrTest.Start()        'starto il timer del test 
        Dim errorResult As New TestError
        'gui.ChangeControlLocation(gui.StatoTestAlimentazione, 197, 0)
        gui.StatoTestAlimentazione.Image = My.Resources.Res.load

        Do

            'scannerrizo la ricezione di nuovi messaggi 
            ReciveVar_form_PLC.GetIntance.ScanParseMsg()
            gui.ChangeControlText(gui.lblPower, ReciveVar_form_PLC.GetIntance.rSupplyVoltageEtsdn / 10 & "V")
            'controllo

            If (ReciveVar_form_PLC.GetIntance.plcPowerCurr < minimum_threshold_plc) Or (ReciveVar_form_PLC.GetIntance.plcPowerCurr > maximum_threshold_plc) Or
                (ReciveVar_form_PLC.GetIntance.rSupplyVoltageEtsdn < ReciveVar_form_PLC.GetIntance.plcEcuK15 - 10) Or
                (ReciveVar_form_PLC.GetIntance.rSupplyVoltageEtsdn > ReciveVar_form_PLC.GetIntance.plcEcuK15 + 10) Then

                viewError = errorResult.GetError(0, ReciveVar_form_PLC.GetIntance.rSupplyVoltageEtsdn)
            Else
                'test passato 

                'setto il test completato a true
                testCompleted = True
                'setto che il test ha avuto successo 
                testSuccess = True
                'gui.ChangeControlLocation(gui.StatoTestAlimentazione, 197, 0)
                gui.StatoTestAlimentazione.Image = My.Resources.Correct
                viewError = ""
                'esco dal loop
                Exit Do
            End If
            canEtsdnVar.SendCmdToAncor(varTxEtsdn.MsgComposer(), 20)
            'loppa fino a quando il timer non supera il limite che ho impostato nel MainEtsdn
        Loop While tmrTest.ElapsedMilliseconds <= tmrTest_threshold

        If Not testSuccess Then
            'gui.ChangeControlLocation(gui.StatoTestAlimentazione, 0, 42)
            gui.StatoTestAlimentazione.Image = My.Resources.Res.error_FILL
        End If

        'resetto il timer del test 
        tmrTest.Reset()
        'creo l'oggetto del risultato del test passandogli il completamento e l'esito 
        Dim result As New TestResultPower(testCompleted, testSuccess, nameOftest, viewError, ReciveVar_form_PLC.GetIntance.etsdnSN, gui.ckBox_Pwr.Checked)
        'ritorno il valore che verrà gestito all'esterno
        Return result

    End Function



    Public Sub New(tmrTest_Threshold As Integer, minimum_threshold_plc As Integer, maximum_threshold_plc As Integer)
        MyBase.New()
        Me.tmrTest = tmrTest
        Me.tmrTest_threshold = tmrTest_Threshold
        Me.minimum_threshold_plc = minimum_threshold_plc
        Me.maximum_threshold_plc = maximum_threshold_plc
    End Sub

End Class
