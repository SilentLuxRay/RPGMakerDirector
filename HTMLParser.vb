Public Class HTMLParser
    Public Shared Sub InterpretaHTML(rtb As RichTextBox, html As String)
        rtb.SelectionStart = rtb.TextLength
        Dim pos As Integer = 0
        Dim currentFont As Font = rtb.Font
        Dim currentColor As Color = Color.Black
        Dim currentBackColor As Color = rtb.BackColor

        While pos < html.Length
            If html.Substring(pos).StartsWith("<b>") Then
                currentFont = New Font(currentFont, FontStyle.Bold)
                pos += 3
            ElseIf html.Substring(pos).StartsWith("</b>") Then
                currentFont = New Font(rtb.Font, FontStyle.Regular)
                pos += 4
            ElseIf html.Substring(pos).StartsWith("<i>") Then
                currentFont = New Font(currentFont, FontStyle.Italic)
                pos += 3
            ElseIf html.Substring(pos).StartsWith("</i>") Then
                currentFont = New Font(rtb.Font, FontStyle.Regular)
                pos += 4
            ElseIf html.Substring(pos).StartsWith("<u>") Then
                currentFont = New Font(currentFont, FontStyle.Underline)
                pos += 3
            ElseIf html.Substring(pos).StartsWith("</u>") Then
                currentFont = New Font(rtb.Font, FontStyle.Regular)
                pos += 4
            ElseIf html.Substring(pos).StartsWith("<s>") Then
                currentFont = New Font(currentFont, FontStyle.Strikeout)
                pos += 3
            ElseIf html.Substring(pos).StartsWith("</s>") Then
                currentFont = New Font(rtb.Font, FontStyle.Regular)
                pos += 4
            ElseIf html.Substring(pos).StartsWith("<color=") Then
                Dim endTag = html.IndexOf(">", pos)
                If endTag > pos Then
                    Dim colore = html.Substring(pos + 7, endTag - pos - 7)
                    currentColor = Color.FromName(colore)
                    pos = endTag + 1
                Else
                    pos += 1
                End If
            ElseIf html.Substring(pos).StartsWith("</color>") Then
                currentColor = Color.Black
                pos += 9
            ElseIf html.Substring(pos).StartsWith("<bgcolor=") Then
                Dim endTag = html.IndexOf(">", pos)
                If endTag > pos Then
                    Dim colore = html.Substring(pos + 9, endTag - pos - 9)
                    currentBackColor = Color.FromName(colore)
                    pos = endTag + 1
                Else
                    pos += 1
                End If
            ElseIf html.Substring(pos).StartsWith("</bgcolor>") Then
                currentBackColor = rtb.BackColor
                pos += 11
            ElseIf html.Substring(pos).StartsWith("<size=") Then
                Dim endTag = html.IndexOf(">", pos)
                If endTag > pos Then
                    Dim sizeStr = html.Substring(pos + 6, endTag - pos - 6)
                    Dim size As Single = Single.Parse(sizeStr)
                    currentFont = New Font(currentFont.FontFamily, size, currentFont.Style)
                    pos = endTag + 1
                Else
                    pos += 1
                End If
            ElseIf html.Substring(pos).StartsWith("</size>") Then
                currentFont = rtb.Font
                pos += 7
            ElseIf html.Substring(pos).StartsWith("<font=") Then
                Dim endTag = html.IndexOf(">", pos)
                If endTag > pos Then
                    Dim fontName = html.Substring(pos + 6, endTag - pos - 6)
                    currentFont = New Font(fontName, currentFont.Size, currentFont.Style)
                    pos = endTag + 1
                Else
                    pos += 1
                End If
            ElseIf html.Substring(pos).StartsWith("</font>") Then
                currentFont = rtb.Font
                pos += 7
            Else
                rtb.SelectionFont = currentFont
                rtb.SelectionColor = currentColor
                rtb.SelectionBackColor = currentBackColor
                rtb.AppendText(html(pos).ToString())
                pos += 1
            End If
        End While
    End Sub
End Class
