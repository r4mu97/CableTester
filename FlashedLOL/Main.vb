

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
    Dim readCSV As New Read_File_CSV
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

    Private Delegate Sub ChangeControlRichTextDelegate(ByVal ctrl As RichTextBox, clr_str As String, text_output As String, ByVal pin_output As String, text_input As String, pin_input As String)
    Public Sub ChangeControlRichText(ctrl As RichTextBox, clr_str As String, text_output As String, Optional pin_output As String = Nothing, Optional text_input As String = Nothing, Optional pin_input As String = Nothing)
        If InvokeRequired Then
            Try
                Invoke(New ChangeControlRichTextDelegate(AddressOf ChangeControlRichText), New Object() {ctrl, clr_str, text_output, pin_output, text_input, pin_input})
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try

            Return
        End If
        Dim all_str = text_output & pin_output & text_input & pin_input

        If clr_str = "White" Then
            ctrl.SelectionColor = Color.White
            ctrl.AppendText(all_str & Environment.NewLine)
        ElseIf clr_str = "Red" Then
            ctrl.SelectionColor = Color.Red
            ctrl.AppendText(all_str & Environment.NewLine)
        ElseIf clr_str = "Green" Then
            ctrl.SelectionColor = Color.Green
            ctrl.AppendText(all_str & Environment.NewLine)
        ElseIf clr_str = "Orange" Then
            ctrl.SelectionColor = Color.Orange
            ctrl.AppendText(all_str & Environment.NewLine)
        ElseIf clr_str = "Blue" Then
            ctrl.SelectionColor = Color.SteelBlue
            ctrl.AppendText(all_str & Environment.NewLine)
        End If
        ctrl = Nothing
        text_output = Nothing
        pin_output = Nothing
        text_input = Nothing
        pin_input = Nothing
        all_str = Nothing
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Data = readCSV.ReadCSV(cbox_list_cables.SelectedItem, Me)
    End Sub
End Class
