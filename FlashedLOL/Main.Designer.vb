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
        Me.StartTest_btn = New System.Windows.Forms.Button()
        Me.listCable_cbox = New System.Windows.Forms.ComboBox()
        Me.info_text_box = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closeForm_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartTest_btn
        '
        Me.StartTest_btn.BackColor = System.Drawing.Color.White
        Me.StartTest_btn.Location = New System.Drawing.Point(516, 67)
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
        Me.info_text_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.info_text_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.info_text_box.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.info_text_box.ForeColor = System.Drawing.SystemColors.Window
        Me.info_text_box.Location = New System.Drawing.Point(0, 34)
        Me.info_text_box.Name = "info_text_box"
        Me.info_text_box.ReadOnly = True
        Me.info_text_box.Size = New System.Drawing.Size(454, 255)
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
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.Color.Transparent
        Me.clear_btn.Location = New System.Drawing.Point(381, 254)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(58, 23)
        Me.clear_btn.TabIndex = 145
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = False
        Me.clear_btn.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(530, 101)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 46)
        Me.PictureBox2.TabIndex = 146
        Me.PictureBox2.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(454, 280)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(140, 10)
        Me.ProgressBar1.TabIndex = 147
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 289)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.info_text_box)
        Me.Controls.Add(Me.listCable_cbox)
        Me.Controls.Add(Me.StartTest_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CableTester"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartTest_btn As Button
    Friend WithEvents listCable_cbox As ComboBox
    Friend WithEvents info_text_box As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents closeForm_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents clear_btn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
