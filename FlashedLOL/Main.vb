

Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Main
    Dim enable As Boolean = True
    Dim canEtsdnVar As New CanEtsdn
    Dim varTxEtsdn As New VarTxToETSDN


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Do
            canEtsdnVar.InitCanOpen()
        Loop While Not canEtsdnVar.is_Inizialized()

        canEtsdnVar.SendCmdToAncor(varTxEtsdn.MsgComposer(), 20)


    End Sub

    Private Sub btn_StartWrite_Click(sender As Object, e As EventArgs)


    End Sub



    Private Delegate Sub ChangeControlTextDelegate(ByVal ctrl As Control, ByVal text As String)
        Public Sub ChangeControlText(ByVal ctrl As Control, ByVal text As String)
            If Me.InvokeRequired Then
                Try
                    Me.Invoke(New ChangeControlTextDelegate(AddressOf ChangeControlText), New Object() {ctrl, text})
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

                Return
            End If
            ctrl.Text = text
        End Sub



        Private Delegate Sub delegalanonna(ByVal ctrl As DataVisualization.Charting.Chart, ByVal x As Integer, y As Integer)
        Public Sub sethart(ByVal ctrl As DataVisualization.Charting.Chart, ByVal x As Integer, y As Integer)
            If Me.InvokeRequired Then
                Try
                    Me.Invoke(New delegalanonna(AddressOf sethart), New Object() {ctrl, x, y})
                Catch ex As Exception
                    Console.WriteLine(ex)
                End Try

                Return
            Else
                ctrl.Series("Tag").Points.Clear()
                ctrl.Series("Tag").Points.AddXY(x, y)
                ctrl.Update()
            End If
        End Sub

    Private Delegate Sub delegalanonna2(ByVal ctrl As DataVisualization.Charting.Chart, ByVal x As Integer, y As Integer, name As String)
    Public Sub sethart2(ByVal ctrl As DataVisualization.Charting.Chart, ByVal x As Integer, y As Integer, name As String)
        If Me.InvokeRequired Then
            Try
                Me.Invoke(New delegalanonna2(AddressOf sethart2), New Object() {ctrl, x, y, name})
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try

            Return
        Else
            ctrl.Series(name).Points.Clear()
            ctrl.Series(name).Points.AddXY(0, 0)
            ctrl.Series(name).Points.AddXY(x, y)
            ctrl.Update()
        End If
    End Sub

End Class
