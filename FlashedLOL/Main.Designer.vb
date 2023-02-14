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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LInvioHR = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LTestGPS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LAccelerometro = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LCalibrazione = New System.Windows.Forms.Label()
        Me.StartTest_btn = New System.Windows.Forms.Button()
        Me.listCable_cbox = New System.Windows.Forms.ComboBox()
        Me.info_text_box = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closeForm_btn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'StartTest_btn
        '
        Me.StartTest_btn.BackColor = System.Drawing.Color.White
        Me.StartTest_btn.Location = New System.Drawing.Point(512, 255)
        Me.StartTest_btn.Name = "StartTest_btn"
        Me.StartTest_btn.Size = New System.Drawing.Size(73, 28)
        Me.StartTest_btn.TabIndex = 141
        Me.StartTest_btn.Text = "Start"
        Me.StartTest_btn.UseVisualStyleBackColor = False
        '
        'listCable_cbox
        '
        Me.listCable_cbox.BackColor = System.Drawing.Color.White
        Me.listCable_cbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.listCable_cbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listCable_cbox.FormattingEnabled = True
        Me.listCable_cbox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listCable_cbox.Location = New System.Drawing.Point(468, 40)
        Me.listCable_cbox.Name = "listCable_cbox"
        Me.listCable_cbox.Size = New System.Drawing.Size(121, 21)
        Me.listCable_cbox.Sorted = True
        Me.listCable_cbox.TabIndex = 142
        '
        'info_text_box
        '
        Me.info_text_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.info_text_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.info_text_box.ForeColor = System.Drawing.SystemColors.Window
        Me.info_text_box.Location = New System.Drawing.Point(0, 33)
        Me.info_text_box.Name = "info_text_box"
        Me.info_text_box.ReadOnly = True
        Me.info_text_box.Size = New System.Drawing.Size(265, 257)
        Me.info_text_box.TabIndex = 143
        Me.info_text_box.Text = ""
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.closeForm_btn)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 36)
        Me.Panel1.TabIndex = 144
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox1.TabIndex = 146
        Me.PictureBox1.TabStop = False
        '
        'closeForm_btn
        '
        Me.closeForm_btn.BackgroundImage = CType(resources.GetObject("closeForm_btn.BackgroundImage"), System.Drawing.Image)
        Me.closeForm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.closeForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeForm_btn.Location = New System.Drawing.Point(570, 9)
        Me.closeForm_btn.Name = "closeForm_btn"
        Me.closeForm_btn.Size = New System.Drawing.Size(19, 18)
        Me.closeForm_btn.TabIndex = 145
        Me.closeForm_btn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(193, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 23)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(591, 289)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.info_text_box)
        Me.Controls.Add(Me.listCable_cbox)
        Me.Controls.Add(Me.StartTest_btn)
        Me.Controls.Add(Me.LCalibrazione)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.LAccelerometro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LTestGPS)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LInvioHR)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CableTester"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents StartTest_btn As Button
    Friend WithEvents listCable_cbox As ComboBox
    Friend WithEvents info_text_box As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeForm_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
