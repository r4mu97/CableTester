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

    End Function

End Class
