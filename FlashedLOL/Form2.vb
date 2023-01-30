Imports System.Threading
Imports System.Threading.Tasks
Imports PdfSharp.Charting


Public Class Form2
    Public xTag As Double, yTag As Double
    Public X1 As Double = -90, X2 As Double = 90, X3 As Double = 0
    Public Y1 As Double = 0, Y2 As Double = 0, Y3 As Double = 225
    Public AreaX As Double, AreaY As Double
    Dim r1 As Double, r2 As Double, r3 As Double
    Public enable = False
    Dim thread As Thread
    Dim canEtsdnVar As New CanEtsdn

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Chart1.Series("Ancora1").Points.Clear()
        Chart1.Series("Ancora1").Points.AddXY(X1, Y1)

        Chart1.Series("Ancora2").Points.Clear()
        Chart1.Series("Ancora2").Points.AddXY(X2, Y2)

        Chart1.Series("Ancora3").Points.Clear()
        Chart1.Series("Ancora3").Points.AddXY(X3, Y3)
        InitializeBasicComponents()
        unInit_CANOPEN()
        Do
            canEtsdnVar.InitCanOpen()
        Loop While Not canEtsdnVar.is_Inizialized()

    End Sub

    Public Function Triangolazione()

        While True

            VarRxFromETSDN.GetIntance.ScanParseMsg()

            r1 = VarRxFromETSDN.GetIntance.pos1

            r2 = VarRxFromETSDN.GetIntance.pos2

            r3 = VarRxFromETSDN.GetIntance.pos3

            xTag = Double.Parse((X1 ^ 2 + r2 ^ 2 - X2 ^ 2 - r1 ^ 2) / (-2 * X2 + 2 * X1))
            yTag = Double.Parse((-2 * X1 * xTag - Y3 ^ 2 + r3 ^ 2 + X1 ^ 2 - r1 ^ 2) / (-2 * Y3))
            sethart(Chart1, xTag, yTag)

            If xTag > 0 And yTag > 0 Then
                AreaX = 50
                AreaY = 50
                Chart1.Series("Area").Points.Clear()
                Chart1.Series("Area").Points.AddXY(AreaX, AreaY)
            ElseIf xTag < 0 And yTag > 0 Then
                AreaX = -50
                AreaY = 50
                Chart1.Series("Area").Points.Clear()
                Chart1.Series("Area").Points.AddXY(AreaX, AreaY)
            ElseIf xTag > 0 And yTag < 0 Then
                AreaX = 50
                AreaY = -50
                Chart1.Series("Area").Points.Clear()
                Chart1.Series("Area").Points.AddXY(AreaX, AreaY)
            ElseIf xTag < 0 And yTag < 0 Then
                AreaX = -50
                AreaY = -50
                Chart1.Series("Area").Points.Clear()
                Chart1.Series("Area").Points.AddXY(AreaX, AreaY)
            End If

        End While
    End Function

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If enable = True Then
            enable = False
        Else
            enable = True
            Dim task = New Task(Sub()
                                    Triangolazione()
                                End Sub)
            task.Start()
        End If
    End Sub


End Class