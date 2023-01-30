
Imports FlashedLOL.MainEtsdn

Public Class PrototypTest
    Protected tmrTest As Stopwatch
    Protected testSuccess As Boolean
    Protected testCompleted As Boolean
    Protected nameOftest As String
    Protected viewError
    Protected varTx As New SendVar_to_PLC
    Protected canVar As New CanCommunication

    Public Sub New()
        Me.tmrTest = New Stopwatch
        Me.varTx = New SendVar_to_PLC
        Me.canVar = New CanCommunication
        Me.testSuccess = False
        Me.testCompleted = False
    End Sub


    Public Overridable Function Execute(gui As Main) As TestResult
        Return Nothing
    End Function

End Class
