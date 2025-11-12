Public Class BattutaVisuale
    Public ReadOnly Property Pannello As Panel
    Public ReadOnly Property Battuta As Battuta

    Public Sub New(b As Battuta, eliminaCallback As Action(Of Guid), Optional evidenzia As Boolean = False)
        Battuta = b

        Pannello = New Panel With {
            .Height = 100,
            .Width = 900,
            .BackColor = Color.White,
            .Margin = New Padding(5),
            .Tag = b.id
        }
        If evidenzia Then
            Pannello.BackColor = Color.LightGoldenrodYellow
            Dim timer As New Timer With {.Interval = 1500}
            AddHandler timer.Tick, Sub()
                                       Pannello.BackColor = Color.White
                                       timer.Stop()
                                       timer.Dispose()
                                   End Sub
            timer.Start()
        End If
        If b.nome <> "" Then
            Dim lblNome As New Label With {
                .Text = b.nome,
                .Font = New Font("Georgia", 11, FontStyle.Bold),
                .ForeColor = Color.White,
                .BackColor = Color.DarkSlateBlue,
                .AutoSize = False,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Size = New Size(96, 20),
                .Location = New Point(5, 5),
                .BorderStyle = BorderStyle.FixedSingle
            }
            Pannello.Controls.Add(lblNome)
        End If

        Dim imgY As Integer = If(b.nome <> "", 30, 5)
        Dim testoY As Integer = If(b.nome <> "", 30, 5)

        Dim img As New PictureBox With {
            .Image = Image.FromFile(b.faceset),
            .SizeMode = PictureBoxSizeMode.StretchImage,
            .Size = New Size(96, 96),
            .Location = New Point(5, imgY)
        }

        Dim testo As New RichTextBox With {
            .ReadOnly = True,
            .BorderStyle = BorderStyle.None,
            .BackColor = Color.White,
            .Location = New Point(110, testoY),
            .Size = New Size(Pannello.Width - 120, 65)
        }

        Dim menu As New ContextMenuStrip()
        Dim eliminaVoce As New ToolStripMenuItem("Elimina")
        Dim modificaVoce As New ToolStripMenuItem("Modifica")
        menu.Items.Add(eliminaVoce)
        menu.Items.Add(modificaVoce)

        AddHandler eliminaVoce.Click, Sub()
                                          eliminaCallback.Invoke(b.id)
                                      End Sub

        AddHandler modificaVoce.Click, Sub()
                                           Dim form = CType(Application.OpenForms(0), RPGMakerDirection)

                                           form.txtNomePersonaggio.Text = b.nome
                                           form.rtbDialogo.Text = b.dialogo
                                           form.picFaceset.Image = Image.FromFile(b.faceset)
                                           form.facesetPath = b.faceset

                                           form.indiceModifica = form.copione.FindIndex(Function(x) x.id = b.id)
                                           form.flpCopione.Controls.Remove(Pannello)
                                           form.copione.RemoveAt(form.indiceModifica)
                                       End Sub

        Pannello.ContextMenuStrip = menu
        Pannello.Controls.Add(img)
        Pannello.Controls.Add(testo)

        HTMLParser.InterpretaHTML(testo, b.dialogo)
    End Sub
End Class