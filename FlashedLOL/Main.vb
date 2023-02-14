

Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class Main

    Dim can_var As New CanCommunication
    Dim varCan_Tx As New SendVar_to_PLC
    Dim suite As New TestSuite
    Dim read As New ReadFile()
    Dim find As New FindFiles()
    Dim readCSV As New Read_File_CSV
    Dim C002080 As New Cab_C002080(3000, 500)
    Private isDragging As Boolean = False
    Private lastLocation As Point

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

    Private Sub cbox_list_cables_DropDown(sender As Object, e As EventArgs) Handles listCable_cbox.DropDown
        find.Find_Files(Me)
    End Sub
    Private Sub cbox_list_cables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCable_cbox.SelectedIndexChanged
        read.Read_configCable_file(listCable_cbox.SelectedItem)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartTest_btn.Click
        Dim Data = readCSV.ReadCSV(listCable_cbox.SelectedItem, Me)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            isDragging = True
            lastLocation = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isDragging Then
            Me.Location = New Point(Me.Location.X + (e.X - lastLocation.X), Me.Location.Y + (e.Y - lastLocation.Y))
            Me.Update()
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        isDragging = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        closeForm_btn.FlatStyle = FlatStyle.Flat
        closeForm_btn.FlatAppearance.BorderSize = 0
        closeForm_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(71, 66, 163)
        closeForm_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(49, 106, 197)
        closeForm_btn.ForeColor = Color.White
        closeForm_btn.Font = New Font("Segoe UI", 11, FontStyle.Bold)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBarCircular.Value += 1
        If ProgressBarCircular.Value >= ProgressBarCircular.Maximum Then
            ProgressBarCircular.Value = 0
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles closeForm_btn.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        info_text_box.Clear()
    End Sub

    Private Sub ProgressBarCircular_ValueChanged(sender As Object, e As EventArgs) Handles Me.
        Invalidate()
    End Sub

End Class


