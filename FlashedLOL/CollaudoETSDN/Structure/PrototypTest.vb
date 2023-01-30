
Imports FlashedLOL.MainEtsdn

Public Class PrototypTest
    Protected tmrTest As Stopwatch
    Protected testSuccess As Boolean
    Protected testCompleted As Boolean
    Protected nameOftest As String
    Protected viewError
    Protected varTxEtsdn As New VarTxToETSDN
    Protected canEtsdnVar As New CanCommunication
    Protected tmrSlidePanel As Stopwatch

    Public Sub New()
        Me.tmrTest = New Stopwatch
        Me.varTxEtsdn = New VarTxToETSDN
        Me.canEtsdnVar = New CanCommunication
        Me.testSuccess = False
        Me.testCompleted = False
        Me.tmrSlidePanel = New Stopwatch
    End Sub


    Public Overridable Function Execute(gui As MainEtsdn) As TestResult
        Return Nothing
    End Function

End Class
