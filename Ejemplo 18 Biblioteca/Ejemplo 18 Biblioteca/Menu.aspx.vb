
Public Class Menu
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then
            Label1.Text = "Bienvenido " & Me.Session("usuario")

        End If
        Label2.Text = DateTime.Now.ToLongDateString
    End Sub

    Protected Sub Usuarios_Click(sender As Object, e As EventArgs) Handles Usuarios.Click
        Response.Redirect("Mant_Usua.aspx")
    End Sub

    Protected Sub Libros_Click(sender As Object, e As EventArgs) Handles Libros.Click
        Response.Redirect("Mant_Libros.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Busc_Libro.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Busc_Usuar.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Prest_Libro.aspx")
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Response.Redirect("Regre_Libro.aspx")
    End Sub
End Class