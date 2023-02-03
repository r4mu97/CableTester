Imports MongoDB.Bson.Serialization.IdGenerators

Public Class Cab_C002080
    Inherits PrototypTest
    Dim stepcase As Integer
    Dim tmr_step As New Stopwatch
    Dim tmr_step_treshold As Integer
    Dim tmr_test_treshold As Integer

    Public Sub New(tmr_test_treshold As Integer, tmr_step_treshold As Integer)
        MyBase.New()
        Me.tmr_test_treshold = tmr_test_treshold
        Me.tmr_step_treshold = tmr_step_treshold
    End Sub
    Public Overrides Function Execute(gui As Main) As TestResult

        tmrTest.Start()

        Do

            Select Case stepcase
                Case 0
                    varTx.SetStateOut1(1)
                    If tmr_step.ElapsedMilliseconds > tmr_step_treshold Then
                        tmr_step.Restart()
                        varTx.SetStateOut1(0)
                        stepcase = stepcase + 1
                    End If
                Case 1
                    varTx.SetStateOut2(1)
                    If tmr_step.ElapsedMilliseconds > tmr_step_treshold Then
                        tmr_step.Restart()
                        varTx.SetStateOut2(0)
                        stepcase = stepcase + 1
                    End If
                Case 2
                    varTx.SetStateOut3(1)
                    If tmr_step.ElapsedMilliseconds > tmr_step_treshold Then
                        tmr_step.Restart()
                        varTx.SetStateOut3(0)
                        stepcase = stepcase + 1
                    End If
                Case 3
                    varTx.SetStateOut4(1)
                    If tmr_step.ElapsedMilliseconds > tmr_step_treshold Then
                        tmr_step.Restart()
                        varTx.SetStateOut4(0)
                        stepcase = 0
                    End If
            End Select
        Loop While tmrTest.ElapsedMilliseconds < tmr_test_treshold



    End Function

End Class
