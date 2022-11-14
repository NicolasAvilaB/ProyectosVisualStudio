Imports System.Net

Public Class Form1
    Dim INFORMACION As String
    Dim PAGINA As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.facebook.com/")
    End Sub

    Private Sub ButtonINICIAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonINICIAR.Click
        Try
            ButtonINICIAR.Visible = False
            TextBoxUSER.Visible = False
            TextBoxPASS.Visible = False
            Me.WebBrowser1.Document.GetElementById("email").InnerText = TextBoxUSER.Text
            Me.WebBrowser1.Document.GetElementById("pass").InnerText = TextBoxPASS.Text
            Me.WebBrowser1.Document.GetElementById("u_0_l").InvokeMember("click")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonVER_Click(sender As System.Object, e As System.EventArgs) Handles ButtonVER.Click
        WebBrowser1.Navigate("https://www.facebook.com/" & TextBoxUSUARIO.Text)
        Timer1.Interval = 3000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        INFORMACION = WebBrowser1.Url.ToString
        TextBoxAPELLIDOS.Clear()
        TextBoxNOMBRE.Clear()
        TextBoxID.Clear()
        TextBoxSEXO.Clear()
        If INFORMACION.Contains("?") Then
            INFORMACION = INFORMACION.Substring(0, INFORMACION.IndexOf("?"))
        End If
        Try
            Dim IMAGEN As String = WebBrowser1.DocumentText
            IMAGEN = IMAGEN.Remove(0, IMAGEN.IndexOf("profilePic img") + 21)
            Dim NOMBRE1 As String = IMAGEN.Substring(0, IMAGEN.IndexOf(""""))
            IMAGEN = IMAGEN.Remove(0, IMAGEN.IndexOf("src=") + 5)
            IMAGEN = IMAGEN.Substring(0, IMAGEN.IndexOf("jpg") + 3)
            IMAGEN = IMAGEN.Replace("/v", "")
            WebBrowser2.Navigate(IMAGEN)
            TextBoxNOMBRE.Text = NOMBRE1
            Dim CLIENTE As New WebClient
            Dim CONTACTO As String = INFORMACION.Remove(0, INFORMACION.LastIndexOf("/") + 1)
            PAGINA = CLIENTE.DownloadString("https://graph.facebook.com/" & INFORMACION)
            Timer1.Stop()
            Timer2.Interval = 3000
            Timer2.Start()
        Catch ex As Exception
            Timer1.Stop()
            MsgBox("NO EXISTE")
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Try
            If PAGINA.Contains("id") Then
                Dim ID As String = PAGINA
                ID = ID.Remove(0, ID.IndexOf("id") + 5)
                ID = ID.Substring(0, ID.IndexOf(",") - 1)
                TextBoxID.Text = ID
            End If
            If PAGINA.Contains("gender") Then
                Dim SEXO As String = PAGINA
                SEXO = SEXO.Remove(0, SEXO.IndexOf("gender") + 9)
                SEXO = SEXO.Substring(0, SEXO.IndexOf(",") - 1)
                If SEXO = "female" Then
                    TextBoxSEXO.Text = "MUJER"
                ElseIf SEXO = "male" Then
                    TextBoxSEXO.Text = "HOMBRE"
                Else
                    TextBoxSEXO.Text = "DESCONOCIDO"
                End If
            End If
            If PAGINA.Contains("first_name") Then
                Dim NOMBRE As String = PAGINA
                NOMBRE = NOMBRE.Remove(0, NOMBRE.IndexOf("first_name") + 13)
                NOMBRE = NOMBRE.Substring(0, NOMBRE.IndexOf(",") - 1)
                TextBoxNOMBRE.Text = NOMBRE
            End If
            If PAGINA.Contains("last_name") Then
                Dim APELLIDOS As String = PAGINA
                APELLIDOS = APELLIDOS.Remove(0, APELLIDOS.IndexOf("last_name") + 12)
                APELLIDOS = APELLIDOS.Substring(0, APELLIDOS.IndexOf(",") - 1)
                TextBoxAPELLIDOS.Text = APELLIDOS
            End If
        Catch ex As Exception
            Timer2.Stop()
            MsgBox("NO EXISTE")
        End Try
        Timer2.Stop()
    End Sub
End Class
