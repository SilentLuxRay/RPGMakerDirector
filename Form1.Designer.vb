<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RPGMakerDirection
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
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rtbDialogo = New System.Windows.Forms.RichTextBox()
        Me.picFaceset = New System.Windows.Forms.PictureBox()
        Me.btnCaricaImg = New System.Windows.Forms.Button()
        Me.btnInvia = New System.Windows.Forms.Button()
        Me.btnCancella = New System.Windows.Forms.Button()
        Me.flpCopione = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSalvaCopione = New System.Windows.Forms.Button()
        Me.txtNomePersonaggio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCaricaCopione = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.picFaceset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rtbDialogo
        '
        Me.rtbDialogo.Location = New System.Drawing.Point(273, 864)
        Me.rtbDialogo.Name = "rtbDialogo"
        Me.rtbDialogo.Size = New System.Drawing.Size(1006, 255)
        Me.rtbDialogo.TabIndex = 0
        Me.rtbDialogo.Text = ""
        '
        'picFaceset
        '
        Me.picFaceset.Location = New System.Drawing.Point(12, 864)
        Me.picFaceset.Name = "picFaceset"
        Me.picFaceset.Size = New System.Drawing.Size(255, 255)
        Me.picFaceset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFaceset.TabIndex = 1
        Me.picFaceset.TabStop = False
        '
        'btnCaricaImg
        '
        Me.btnCaricaImg.BackColor = System.Drawing.SystemColors.Control
        Me.btnCaricaImg.Location = New System.Drawing.Point(12, 818)
        Me.btnCaricaImg.Name = "btnCaricaImg"
        Me.btnCaricaImg.Size = New System.Drawing.Size(120, 40)
        Me.btnCaricaImg.TabIndex = 2
        Me.btnCaricaImg.Text = "Carica Face"
        Me.btnCaricaImg.UseVisualStyleBackColor = False
        '
        'btnInvia
        '
        Me.btnInvia.BackColor = System.Drawing.SystemColors.Control
        Me.btnInvia.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnInvia.Location = New System.Drawing.Point(1285, 864)
        Me.btnInvia.Name = "btnInvia"
        Me.btnInvia.Size = New System.Drawing.Size(120, 80)
        Me.btnInvia.TabIndex = 2
        Me.btnInvia.Text = "Invia"
        Me.btnInvia.UseVisualStyleBackColor = False
        '
        'btnCancella
        '
        Me.btnCancella.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancella.ForeColor = System.Drawing.Color.Maroon
        Me.btnCancella.Location = New System.Drawing.Point(1285, 950)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(120, 40)
        Me.btnCancella.TabIndex = 2
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.UseVisualStyleBackColor = False
        '
        'flpCopione
        '
        Me.flpCopione.AutoScroll = True
        Me.flpCopione.BackColor = System.Drawing.SystemColors.Control
        Me.flpCopione.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCopione.Location = New System.Drawing.Point(12, 12)
        Me.flpCopione.Name = "flpCopione"
        Me.flpCopione.Size = New System.Drawing.Size(1396, 800)
        Me.flpCopione.TabIndex = 4
        Me.flpCopione.WrapContents = False
        '
        'btnSalvaCopione
        '
        Me.btnSalvaCopione.BackColor = System.Drawing.Color.LightGreen
        Me.btnSalvaCopione.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSalvaCopione.Location = New System.Drawing.Point(1285, 1054)
        Me.btnSalvaCopione.Name = "btnSalvaCopione"
        Me.btnSalvaCopione.Size = New System.Drawing.Size(120, 65)
        Me.btnSalvaCopione.TabIndex = 5
        Me.btnSalvaCopione.Text = "Salva Copione"
        Me.btnSalvaCopione.UseVisualStyleBackColor = False
        '
        'txtNomePersonaggio
        '
        Me.txtNomePersonaggio.Location = New System.Drawing.Point(317, 829)
        Me.txtNomePersonaggio.Name = "txtNomePersonaggio"
        Me.txtNomePersonaggio.Size = New System.Drawing.Size(133, 26)
        Me.txtNomePersonaggio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 832)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 832)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "(Opzionale)"
        '
        'btnCaricaCopione
        '
        Me.btnCaricaCopione.BackColor = System.Drawing.SystemColors.Control
        Me.btnCaricaCopione.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCaricaCopione.Location = New System.Drawing.Point(1285, 996)
        Me.btnCaricaCopione.Name = "btnCaricaCopione"
        Me.btnCaricaCopione.Size = New System.Drawing.Size(120, 52)
        Me.btnCaricaCopione.TabIndex = 8
        Me.btnCaricaCopione.Text = "Carica Copione"
        Me.btnCaricaCopione.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MistyRose
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(1285, 950)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancella"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RPGMakerDirection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 1131)
        Me.Controls.Add(Me.btnSalvaCopione)
        Me.Controls.Add(Me.btnCaricaCopione)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomePersonaggio)
        Me.Controls.Add(Me.flpCopione)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnCancella)
        Me.Controls.Add(Me.btnInvia)
        Me.Controls.Add(Me.btnCaricaImg)
        Me.Controls.Add(Me.picFaceset)
        Me.Controls.Add(Me.rtbDialogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RPGMakerDirection"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "RPG Maker Direction"
        CType(Me.picFaceset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rtbDialogo As RichTextBox
    Friend WithEvents picFaceset As PictureBox
    Friend WithEvents btnCaricaImg As Button
    Friend WithEvents btnInvia As Button
    Friend WithEvents btnCancella As Button
    Friend WithEvents flpCopione As FlowLayoutPanel
    Friend WithEvents btnSalvaCopione As Button
    Friend WithEvents txtNomePersonaggio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCaricaCopione As Button
    Friend WithEvents Button2 As Button
End Class
