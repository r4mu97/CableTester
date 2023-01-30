

Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Main

    Dim can_var As New CanCommunication
    Dim varCan_Tx As New SendVar_to_PLC
    Dim read As New ReadFile(Me)


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Do
        '    can_var.InitCanOpen()
        'Loop While Not can_var.is_Inizialized()

        can_var.SendCmdToAncor(varCan_Tx.MsgComposer(), 20)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        read.Read_all_file()
    End Sub
End Class
