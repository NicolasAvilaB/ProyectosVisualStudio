Imports System.Net.Mail
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mail As New MailMessage
        If TextBox1.Text = "" Then
            MsgBox("Agregue coreo")
        Else
            Try
                mail.From = New MailAddress("pruebaexamentitulo@gmail.com")
                mail.To.Add(TextBox1.Text)
                mail.Subject = (TextBox2.Text)
                mail.Body = (RichTextBox1.Text)
                mail.Priority = MailPriority.Normal
                Dim servidor As New SmtpClient("smtp.gmail.com")
                servidor.Port = "587"
                servidor.EnableSsl = True
                servidor.Credentials = New System.Net.NetworkCredential("pruebaexamentitulo@gmail.com", "SMtp11223344")
                servidor.Send(mail)
                MsgBox("Mensaje Enviado")
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
