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
        Me.cbox_list_cables = New System.Windows.Forms.ComboBox()
        Me.info_text_box = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(506, 67)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbox_list_cables
        '
        Me.cbox_list_cables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_list_cables.FormattingEnabled = True
        Me.cbox_list_cables.Location = New System.Drawing.Point(466, 40)
        Me.cbox_list_cables.Name = "cbox_list_cables"
        Me.cbox_list_cables.Size = New System.Drawing.Size(121, 21)
        Me.cbox_list_cables.TabIndex = 142
        '
        'info_text_box
        '
        Me.info_text_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.info_text_box.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 36)
        Me.Panel1.TabIndex = 144
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(570, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(19, 18)
        Me.Button2.TabIndex = 145
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(591, 289)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.info_text_box)
        Me.Controls.Add(Me.cbox_list_cables)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents cbox_list_cables As ComboBox
    Friend WithEvents info_text_box As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
