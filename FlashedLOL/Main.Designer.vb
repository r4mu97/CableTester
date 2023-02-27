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
        Me.StartTest_btn = New System.Windows.Forms.Button()
        Me.listCable_cbox = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.info_text_box = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'StartTest_btn
        '
        Me.StartTest_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StartTest_btn.BackColor = System.Drawing.Color.White
        Me.StartTest_btn.Location = New System.Drawing.Point(485, 246)
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
        Me.listCable_cbox.Location = New System.Drawing.Point(468, 12)
        Me.listCable_cbox.Name = "listCable_cbox"
        Me.listCable_cbox.Size = New System.Drawing.Size(121, 21)
        Me.listCable_cbox.Sorted = True
        Me.listCable_cbox.TabIndex = 142
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.Location = New System.Drawing.Point(455, 280)
        Me.ProgressBar1.Maximum = 20
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(138, 10)
        Me.ProgressBar1.TabIndex = 147
        '
        'info_text_box
        '
        Me.info_text_box.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.info_text_box.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.info_text_box.Location = New System.Drawing.Point(-2, 0)
        Me.info_text_box.Name = "info_text_box"
        Me.info_text_box.ReadOnly = True
        Me.info_text_box.Size = New System.Drawing.Size(451, 290)
        Me.info_text_box.TabIndex = 148
        Me.info_text_box.Text = ""
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(596, 289)
        Me.Controls.Add(Me.info_text_box)
        Me.Controls.Add(Me.listCable_cbox)
        Me.Controls.Add(Me.StartTest_btn)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CableTester"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartTest_btn As Button
    Friend WithEvents listCable_cbox As ComboBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents info_text_box As RichTextBox
End Class
