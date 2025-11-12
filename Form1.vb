Imports System.IO
Imports System.Text.Json
Imports System.Media
Public Class RPGMakerDirection
    Public Property facesetPath As String = ""
    Public Property copione As List(Of Battuta) = New List(Of Battuta)
    Public Property indiceModifica As Integer = -1

    Private Sub btnCaricaImg_Click(sender As Object, e As EventArgs) Handles btnCaricaImg.Click
        Dim ofd As New OpenFileDialog With {
            .Filter = "Immagini PNG|*.png|Tutti i file|*.*"
        }
        If ofd.ShowDialog() = DialogResult.OK Then
            facesetPath = ofd.FileName
            picFaceset.Image = Image.FromFile(facesetPath)
        End If
    End Sub

    Private Sub btnCancella_Click(sender As Object, e As EventArgs) Handles btnCancella.Click, Button2.Click
        rtbDialogo.Clear()
    End Sub

    Private Sub btnInvia_Click(sender As Object, e As EventArgs) Handles btnInvia.Click
        If facesetPath = "" OrElse rtbDialogo.Text.Trim() = "" Then
            MessageBox.Show("Inserisci un faceset e del testo.")
            Return
        End If

        Dim nuovaBattuta As New Battuta With {
            .id = Guid.NewGuid(),
            .faceset = facesetPath,
            .dialogo = rtbDialogo.Text,
            .nome = txtNomePersonaggio.Text.Trim()
        }

        Dim visuale As New BattutaVisuale(nuovaBattuta, Sub(id)
                                                            flpCopione.Controls.Remove(
        flpCopione.Controls.Cast(Of Control).FirstOrDefault(Function(c) CType(c.Tag, Guid) = id)
    )
                                                        End Sub, evidenzia:=indiceModifica >= 0)

        If indiceModifica >= 0 Then
            copione.Insert(indiceModifica, nuovaBattuta)
            flpCopione.Controls.Add(visuale.Pannello)
            flpCopione.Controls.SetChildIndex(visuale.Pannello, indiceModifica)
            indiceModifica = -1
            Dim player As New SoundPlayer(Path.Combine(Application.StartupPath, "notifica.wav"))
            player.Play()
        Else
            copione.Add(nuovaBattuta)
            flpCopione.Controls.Add(visuale.Pannello)
        End If

        txtNomePersonaggio.Text = ""
        rtbDialogo.Text = ""
    End Sub

    Private Sub btnSalvaCopione_Click(sender As Object, e As EventArgs) Handles btnSalvaCopione.Click
        Dim json As String = JsonSerializer.Serialize(copione, New JsonSerializerOptions With {
            .WriteIndented = True
        })

        Dim filePath As String = Path.Combine(Application.StartupPath, "copione.json")
        File.WriteAllText(filePath, json)
        MessageBox.Show("Copione salvato in JSON!", "Salvataggio completato")
    End Sub

    Private Sub btnCaricaCopione_Click(sender As Object, e As EventArgs) Handles btnCaricaCopione.Click
        Dim filePath As String = Path.Combine(Application.StartupPath, "copione.json")
        If Not File.Exists(filePath) Then
            MessageBox.Show("Nessun file copione.json trovato.")
            Return
        End If

        Dim json As String = File.ReadAllText(filePath)
        Dim battuteCaricate As List(Of Battuta) = JsonSerializer.Deserialize(Of List(Of Battuta))(json)

        copione.Clear()
        flpCopione.Controls.Clear()

        For Each b As Battuta In battuteCaricate
            copione.Add(b)
            Dim visuale As New BattutaVisuale(b, Sub(id)
                                                     flpCopione.Controls.Remove(
                                                         flpCopione.Controls.Cast(Of Control).FirstOrDefault(Function(c) CType(c.Tag, Guid) = id)
                                                     )
                                                     copione.RemoveAll(Function(x) x.id = id)
                                                 End Sub)
            flpCopione.Controls.Add(visuale.Pannello)
        Next
    End Sub
End Class

Public Class Battuta
    Public Property id As Guid
    Public Property faceset As String
    Public Property dialogo As String
    Public Property nome As String
End Class