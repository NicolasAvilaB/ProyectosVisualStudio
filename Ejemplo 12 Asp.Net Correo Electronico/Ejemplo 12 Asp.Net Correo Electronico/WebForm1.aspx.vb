Imports System.Web.Mail
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BTNENVIAR_Click(sender As Object, e As EventArgs) Handles BTNENVIAR.Click
        Dim correo As New System.Net.Mail.MailMessage()

        correo.From = New System.Net.Mail.MailAddress("CorreodeEnvio@aiep.cl")
        correo.To.Add(Trim(TextBox1.Text))
        correo.Subject = TextBox2.Text
        correo.Body = "<HTML><BODY><i>" & TextBox3.Text & "</i></BODY></HTML>"

        correo.IsBodyHtml = True

        correo.Priority = System.Net.Mail.MailPriority.Normal
        Dim smtp As New System.Net.Mail.SmtpClient

        smtp.Host = "smtp.gmail.com"

        'indicar el puerto en caso de que no se a el standard (25)
        smtp.Port = "465" 'caso de que uses otro puerto como gmail se utiliza el 465

        smtp.Credentials = New System.Net.NetworkCredential("nicolasrodavila@gmail.com", "195144443")
        'Establecer a true cuando el servidor requiere una conexion segura SSL
        smtp.EnableSsl = True
        Try
            smtp.Send(correo)
            Label1.Text = "Mensaje Enviado"
        Catch ex As Exception
            Label1.Text = "Error " & ex.Message
        End Try
    End Sub
End Class