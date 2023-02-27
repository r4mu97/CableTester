

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

        Select Case clr_str
            Case "White"
                ctrl.SelectionColor = Color.White
                ctrl.AppendText(all_str)
            Case "Red"
                ctrl.SelectionColor = Color.Red
                ctrl.AppendText(all_str)
            Case "Green"
                ctrl.SelectionColor = Color.Green
                ctrl.AppendText(all_str)
            Case "Orange"
                ctrl.SelectionColor = Color.Orange
                ctrl.AppendText(all_str)
            Case "Blue"
                ctrl.SelectionColor = Color.Blue
                ctrl.AppendText(all_str)
            Case "Gold"
                ctrl.SelectionColor = Color.Gold
                ctrl.AppendText(all_str)
        End Select

        ctrl = Nothing
        text_output = Nothing
        pin_output = Nothing
        text_input = Nothing
        pin_input = Nothing
        all_str = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles StartTest_btn.Click
        StartTest_btn.Enabled = False
        ProgressBar1.Value = 0
        info_text_box.Clear()
        ChangeControlRichText(info_text_box, "White", "Start Test" & Environment.NewLine)
        Dim cable_selected = listCable_cbox.Text & ".CSV"
        Dim task = New Task(Sub()
                                readCSV.ReadCSV(cable_selected, Me)
                            End Sub)
        task.Start()

    End Sub

    Public Sub ChangeStatebutton()
        If Me.StartTest_btn.InvokeRequired Then
            Me.StartTest_btn.Invoke(Sub() ChangeStatebutton())
        Else
            StartTest_btn.Enabled = True
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            isDragging = True
            lastLocation = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)
        If isDragging Then
            Me.Location = New Point(Me.Location.X + (e.X - lastLocation.X), Me.Location.Y + (e.Y - lastLocation.Y))
            Me.Update()
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)
        isDragging = False
    End Sub



    Public Function ChangeCtrlProgressBar(min_value As Integer, max_value As Integer, value As Integer)

        If Me.ProgressBar1.InvokeRequired Then
            Me.ProgressBar1.BeginInvoke(New Action(Of Integer)(AddressOf UpdateValueProgressBar), value)
            Me.ProgressBar1.BeginInvoke(New Action(Of Integer)(AddressOf UpdateMinProgressBar), min_value)
            Me.ProgressBar1.BeginInvoke(New Action(Of Integer)(AddressOf UpdatemaxProgressbar), max_value)
        Else
            Me.ProgressBar1.Minimum = min_value
            Me.ProgressBar1.Maximum = max_value
            Me.ProgressBar1.Value += value
        End If
    End Function

    Private Sub UpdateValueProgressBar(ByVal value As Integer)
        Me.ProgressBar1.Value += value
    End Sub
    Private Sub UpdateMinProgressBar(ByVal min_value As Integer)
        Me.ProgressBar1.Minimum = min_value
    End Sub
    Private Sub UpdatemaxProgressbar(ByVal max_value As Integer)
        Me.ProgressBar1.Maximum = max_value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        info_text_box.Clear()
    End Sub

    Private Sub listCable_cbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles listCable_cbox.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            ' Perform desired action here
            If Not listCable_cbox.Text.Contains(".CSV") Then
                Dim code_with_extension = listCable_cbox.Text + ".CSV"
                readCSV.ReadCSV(code_with_extension, Me)
            Else
                readCSV.ReadCSV(listCable_cbox.Text, Me)
            End If
        End If
    End Sub

End Class


