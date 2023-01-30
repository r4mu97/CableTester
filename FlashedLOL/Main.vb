

Imports System.IO
Imports System.Threading.Tasks
Imports System.Windows.Forms.DataVisualization.Charting


Public Class Main
    Dim enable As Boolean = True
    Dim canEtsdnVar As New CanEtsdn
    Dim varTxEtsdn As New VarTxToETSDN
    Dim xTag As Double = 0, YTag As Double = -0
    Dim X1 As Double = -90, X2 As Double = 90, X3 As Double = 0
    Dim Y1 As Double = 0, Y2 As Double = 0, Y3 As Double = 225
    Dim r1 As Double, r2 As Double, r3 As Double
    Dim p1 As Point, p2 As Point, p3 As Point
    Dim enableWriting As Boolean = False
    Public path = Application.StartupPath & "\\log\\Distance.csv"
    Protected generateData As StreamWriter
    Dim alpha As Double
    Private Const angleWidth As Double = 5 * (Math.PI / 180)


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        canEtsdnVar.SendCmdToAncor(varTxEtsdn.MsgComposer(), 20)

        Dim task = New Task(Sub()
                                Triangolazione()
                            End Sub)
        task.Start()
    End Sub

    Private Sub btn_StartWrite_Click(sender As Object, e As EventArgs) Handles btn_StartWrite.Click

        If Not enableWriting Then
            enableWriting = True
            Dim sss As FileStream = IO.File.Create(path)
            generateData = New StreamWriter(sss)
            ChangeControlText(btn_StartWrite, "Stop Writing")
        Else
            ChangeControlText(btn_StartWrite, "Start Write")
            enableWriting = False
            generateData.Close()
        End If

    End Sub




    Public Function Triangolazione()

        While enable
            X1 = CDbl(txtX1.Text)
            Y1 = CDbl(txtY1.Text)

            X2 = CDbl(txtX2.Text)
            Y2 = CDbl(txtY2.Text)

            X3 = CDbl(txtX3.Text)
            Y3 = CDbl(txtY3.Text)

            VarRxFromETSDN.GetIntance.ScanParseMsg()

            r1 = VarRxFromETSDN.GetIntance.pos1 / 10
            ChangeControlText(tbox_A1, r1)

            r2 = VarRxFromETSDN.GetIntance.pos2 / 10
            ChangeControlText(tbox_A2, r2)


            r3 = VarRxFromETSDN.GetIntance.pos3 / 10
            ChangeControlText(tbox_A3, r3)

            'xTag = Double.Parse((X1 ^ 2 + r2 ^ 2 - X2 ^ 2 - r1 ^ 2) / (-2 * X2 + 2 * X1))
            'YTag = Double.Parse((-2 * X1 * xTag - Y3 ^ 2 + r3 ^ 2 + X1 ^ 2 - r1 ^ 2) / (-2 * Y3))

            Dim a As Double = X1
            Dim b As Double = Y1
            Dim c As Double = X2
            Dim d As Double = Y2
            Dim e As Double = X3
            Dim f As Double = Y3

            Dim A1 As Double = 2 * (c - a)
            Dim B1 As Double = 2 * (d - b)
            Dim C1 As Double = r1 * r1 - r2 * r2 - a * a + c * c - b * b + d * d
            Dim D1 As Double = 2 * (e - a)
            Dim E1 As Double = 2 * (f - b)
            Dim F1 As Double = r1 * r1 - r3 * r3 - a * a + e * e - b * b + f * f

            xTag = Double.Parse(C1 * E1 - F1 * B1) / (E1 * A1 - B1 * D1)
            YTag = Double.Parse(C1 * D1 - A1 * F1) / (B1 * D1 - A1 * E1)

            sethart(Chart1, xTag, YTag)

            ChangeControlText(TextBox1, Math.Truncate(xTag))
            ChangeControlText(TextBox2, Math.Truncate(YTag))

            If enableWriting Then
                Dim delimiter As New String(";")
                generateData.Write(r1 & delimiter)
                generateData.Write(r2 & delimiter)
                generateData.Write(r3 & delimiter)
                generateData.Write(Math.Truncate(xTag) & delimiter)
                generateData.Write(Math.Truncate(YTag) & Environment.NewLine)
            End If

            alpha = get_angle()
            Dim leftPoint As PointSegment = get_segment_endpoint(1000, alpha - angleWidth)
            Dim rightPoint As PointSegment = get_segment_endpoint(1000, alpha + angleWidth)

            sethart2(Chart1, leftPoint.x, leftPoint.y, "Series5")
            sethart2(Chart1, rightPoint.x, rightPoint.y, "Series6")


        End While

    End Function

    Private Function get_segment_endpoint(lenght, alpha)
        Dim x As Double = lenght * Math.Cos(alpha)
        Dim y As Double = lenght * Math.Sin(alpha)

        Return New PointSegment(x, y)

    End Function

    Public Class PointSegment
        Public x, y
        Sub New(x As Double, y As Double)
            Me.x = x
            Me.y = y
        End Sub

    End Class
    Private Function get_angle()
        Dim dblRatio As Double
        Dim dblAtangent As Double
        Dim dblDeg As Double
        Dim adjustment As Double = 0

        If xTag < 0 Then
            adjustment = Math.PI
        End If

        dblRatio = YTag / xTag
        dblAtangent = Math.Atan(dblRatio)
        dblAtangent += adjustment
        dblDeg = dblAtangent * (180 / 3.142)
        If dblDeg > 180 Then
            dblDeg = -(dblDeg - 180)
        End If
        ChangeControlText(lblDegrees, Math.Truncate(dblDeg) & "°")
        Return dblAtangent

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If enable Then
            enable = False
        Else
            enable = True
            Triangolazione()
        End If
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



    'Public Function WriteOnFile(a As ReportInfoTestEtsdn)
    '    Try
    '        Dim val = My.Computer.FileSystem.OpenTextFileWriter(path & serialdevice, True)
    '        val.WriteLine(a.line)
    '        val.WriteLine(a.dayn)
    '        val.WriteLine(a.sn)
    '        val.WriteLine(a.nameOperator)
    '        val.Close()
    '    Catch ex As Exception
    '        Console.WriteLine(ex)
    '    End Try

    'End Function
End Class
