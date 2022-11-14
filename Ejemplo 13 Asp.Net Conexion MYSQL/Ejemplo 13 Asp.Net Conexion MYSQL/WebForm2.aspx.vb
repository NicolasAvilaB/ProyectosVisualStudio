Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then
            'MOstramos Variables de Sesion
            IdUsuario.Text = "Bienvenido " & Me.Session("Usuario")
            If Me.Resquest.cookie1 Is Nothing Then
                Idclave.Text = "No existe la cookie codigo"
            Else
                Idclave.Text = "Su codigo es: " & Me.Resquest.cookie1("Codigo").value

            End If
        End If
    End Sub

End Class