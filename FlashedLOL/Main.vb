

Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Main

    Dim can_var As New CanCommunication
    Dim varCan_Tx As New SendVar_to_PLC
    Dim suite As New TestSuite
    Dim read As New ReadFile()
    Dim find As New FindFiles()
    Dim C002080 As New Cab_C002080(3000, 500)

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeBasicComponents()
        unInit_CANOPEN()
        Do
            can_var.InitCanOpen()
        Loop While Not can_var.is_Inizialized()

        'can_var.SendCmdToAncor(varCan_Tx.MsgComposer(), 20)
        Dim task = New Task(Sub()
                                ReciveVar_form_PLC.GetIntance.ScanParseMsg()
                            End Sub)
        task.Start()
    End Sub

    Private Sub cbox_list_cables_DropDown(sender As Object, e As EventArgs) Handles cbox_list_cables.DropDown
        find.Find_Files(Me)
    End Sub
    Private Sub cbox_list_cables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_list_cables.SelectedIndexChanged
        read.Read_configCable_file(cbox_list_cables.SelectedItem)
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
        C002080.Execute(Me)
    End Sub
End Class
