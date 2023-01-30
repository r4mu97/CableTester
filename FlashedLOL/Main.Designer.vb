<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LInvioHR = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LTestGPS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LAccelerometro = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LCalibrazione = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtX3 = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.txtY3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblXtag = New System.Windows.Forms.Label()
        Me.lblYtag = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_StartWrite = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblDegrees = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbox_A1 = New System.Windows.Forms.Label()
        Me.tbox_A2 = New System.Windows.Forms.Label()
        Me.tbox_A3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1460, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Test invio HR"
        '
        'LInvioHR
        '
        Me.LInvioHR.AutoSize = True
        Me.LInvioHR.Location = New System.Drawing.Point(1598, 153)
        Me.LInvioHR.Name = "LInvioHR"
        Me.LInvioHR.Size = New System.Drawing.Size(83, 13)
        Me.LInvioHR.TabIndex = 102
        Me.LInvioHR.Text = "Test completato"
        Me.LInvioHR.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1460, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 104
        Me.Label13.Text = "Test GPS"
        '
        'LTestGPS
        '
        Me.LTestGPS.AutoSize = True
        Me.LTestGPS.Location = New System.Drawing.Point(1598, 182)
        Me.LTestGPS.Name = "LTestGPS"
        Me.LTestGPS.Size = New System.Drawing.Size(83, 13)
        Me.LTestGPS.TabIndex = 105
        Me.LTestGPS.Text = "Test completato"
        Me.LTestGPS.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1460, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Test Accelerometro"
        '
        'LAccelerometro
        '
        Me.LAccelerometro.AutoSize = True
        Me.LAccelerometro.Location = New System.Drawing.Point(1598, 209)
        Me.LAccelerometro.Name = "LAccelerometro"
        Me.LAccelerometro.Size = New System.Drawing.Size(83, 13)
        Me.LAccelerometro.TabIndex = 112
        Me.LAccelerometro.Text = "Test completato"
        Me.LAccelerometro.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(1460, 266)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 13)
        Me.Label23.TabIndex = 139
        Me.Label23.Text = "Calibrazione"
        '
        'LCalibrazione
        '
        Me.LCalibrazione.AutoSize = True
        Me.LCalibrazione.Location = New System.Drawing.Point(1598, 267)
        Me.LCalibrazione.Name = "LCalibrazione"
        Me.LCalibrazione.Size = New System.Drawing.Size(83, 13)
        Me.LCalibrazione.TabIndex = 140
        Me.LCalibrazione.Text = "Test completato"
        Me.LCalibrazione.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button1.Location = New System.Drawing.Point(1088, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "Triangolazione"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1110, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Ancora1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1110, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Ancora2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1110, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Ancora3"
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(1090, 234)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(100, 20)
        Me.txtY1.TabIndex = 147
        Me.txtY1.Text = "0"
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(1091, 269)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(100, 20)
        Me.txtX2.TabIndex = 148
        Me.txtX2.Text = "27,5"
        '
        'txtX3
        '
        Me.txtX3.Location = New System.Drawing.Point(1092, 333)
        Me.txtX3.Name = "txtX3"
        Me.txtX3.Size = New System.Drawing.Size(100, 20)
        Me.txtX3.TabIndex = 149
        Me.txtX3.Text = "0"
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(1090, 208)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(100, 20)
        Me.txtX1.TabIndex = 150
        Me.txtX1.Text = "-31,5"
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(1091, 295)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(100, 20)
        Me.txtY2.TabIndex = 151
        Me.txtY2.Text = "0"
        '
        'txtY3
        '
        Me.txtY3.Location = New System.Drawing.Point(1092, 359)
        Me.txtY3.Name = "txtY3"
        Me.txtY3.Size = New System.Drawing.Size(100, 20)
        Me.txtY3.TabIndex = 152
        Me.txtY3.Text = "71"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1071, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 153
        Me.Label5.Text = "X"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1071, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1072, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 13)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "X"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1071, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 13)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1072, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = "Y"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1072, 362)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 13)
        Me.Label10.TabIndex = 158
        Me.Label10.Text = "Y"
        '
        'lblXtag
        '
        Me.lblXtag.AutoSize = True
        Me.lblXtag.Location = New System.Drawing.Point(1053, 417)
        Me.lblXtag.Name = "lblXtag"
        Me.lblXtag.Size = New System.Drawing.Size(31, 13)
        Me.lblXtag.TabIndex = 161
        Me.lblXtag.Text = "xTag"
        '
        'lblYtag
        '
        Me.lblYtag.AutoSize = True
        Me.lblYtag.Location = New System.Drawing.Point(1054, 439)
        Me.lblYtag.Name = "lblYtag"
        Me.lblYtag.Size = New System.Drawing.Size(31, 13)
        Me.lblYtag.TabIndex = 162
        Me.lblYtag.Text = "yTag"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(1043, 482)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 166
        Me.Label11.Text = "Dist.A1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1043, 508)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 167
        Me.Label14.Text = "Dist.A2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1043, 534)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 168
        Me.Label15.Text = "Dist.A3"
        '
        'btn_StartWrite
        '
        Me.btn_StartWrite.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btn_StartWrite.Location = New System.Drawing.Point(1075, 644)
        Me.btn_StartWrite.Name = "btn_StartWrite"
        Me.btn_StartWrite.Size = New System.Drawing.Size(121, 42)
        Me.btn_StartWrite.TabIndex = 169
        Me.btn_StartWrite.Text = "StartWrite"
        Me.btn_StartWrite.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.Maximum = 5000.0R
        ChartArea1.AxisX.Minimum = -5000.0R
        ChartArea1.AxisY.Maximum = 5000.0R
        ChartArea1.AxisY.Minimum = -5000.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(-62, 1)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(1)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.MarkerSize = 10
        Series1.Name = "Ancora1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.MarkerSize = 10
        Series2.Name = "Ancora2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series3.Legend = "Legend1"
        Series3.MarkerSize = 10
        Series3.Name = "Ancora3"
        Series3.YValuesPerPoint = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series4.Color = System.Drawing.Color.Lime
        Series4.Legend = "Legend1"
        Series4.MarkerSize = 8
        Series4.Name = "Tag"
        Series5.BorderWidth = 5
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series5.Legend = "Legend1"
        Series5.Name = "Series5"
        Series5.ShadowColor = System.Drawing.Color.Orange
        Series5.XValueMember = "0"
        Series5.YValueMembers = "0"
        Series6.BorderWidth = 5
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.Legend = "Legend1"
        Series6.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.MarkerSize = 1
        Series6.Name = "Series6"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(1276, 800)
        Me.Chart1.TabIndex = 170
        Me.Chart1.Text = " "
        '
        'lblDegrees
        '
        Me.lblDegrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDegrees.Location = New System.Drawing.Point(1092, 577)
        Me.lblDegrees.Name = "lblDegrees"
        Me.lblDegrees.Size = New System.Drawing.Size(52, 18)
        Me.lblDegrees.TabIndex = 171
        Me.lblDegrees.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1037, 577)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 172
        Me.Label16.Text = "Degrees"
        '
        'tbox_A1
        '
        Me.tbox_A1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_A1.Location = New System.Drawing.Point(1092, 481)
        Me.tbox_A1.Name = "tbox_A1"
        Me.tbox_A1.Size = New System.Drawing.Size(52, 18)
        Me.tbox_A1.TabIndex = 173
        Me.tbox_A1.Text = "0"
        '
        'tbox_A2
        '
        Me.tbox_A2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_A2.Location = New System.Drawing.Point(1092, 507)
        Me.tbox_A2.Name = "tbox_A2"
        Me.tbox_A2.Size = New System.Drawing.Size(52, 18)
        Me.tbox_A2.TabIndex = 174
        Me.tbox_A2.Text = "0"
        '
        'tbox_A3
        '
        Me.tbox_A3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_A3.Location = New System.Drawing.Point(1092, 534)
        Me.tbox_A3.Name = "tbox_A3"
        Me.tbox_A3.Size = New System.Drawing.Size(52, 18)
        Me.tbox_A3.TabIndex = 175
        Me.tbox_A3.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(1092, 416)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 18)
        Me.TextBox1.TabIndex = 176
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(1092, 438)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(52, 18)
        Me.TextBox2.TabIndex = 177
        Me.TextBox2.Text = "0"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 741)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.tbox_A3)
        Me.Controls.Add(Me.tbox_A2)
        Me.Controls.Add(Me.tbox_A1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblDegrees)
        Me.Controls.Add(Me.btn_StartWrite)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblYtag)
        Me.Controls.Add(Me.lblXtag)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtY3)
        Me.Controls.Add(Me.txtY2)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.txtX3)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtY1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LCalibrazione)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.LAccelerometro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LTestGPS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LInvioHR)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Chart1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.Text = "Testing MDT!"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LInvioHR As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LTestGPS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LAccelerometro As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents LCalibrazione As System.Windows.Forms.Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtY1 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents txtX3 As TextBox
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents txtY2 As TextBox
    Friend WithEvents txtY3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblXtag As Label
    Friend WithEvents lblYtag As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_StartWrite As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lblDegrees As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents tbox_A1 As Label
    Friend WithEvents tbox_A2 As Label
    Friend WithEvents tbox_A3 As Label
    Friend WithEvents TextBox1 As Label
    Friend WithEvents TextBox2 As Label
End Class
