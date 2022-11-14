Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=dbb;Uid=root;pwd=root;"
            Dim comando As New MySqlCommand("select * from usuarios where Login='" & TextBox1.Text & "' and Password='" & TextBox2.Text & "'", conexion)
            conexion.Open()
            Dim datareader As MySqlDataReader
            datareader = comando.ExecuteReader()
            While datareader.Read()
                'Ejemplo con variable de sesion 
                Me.Session("usuario") = datareader("Login")
                'Ejemplo con cookie 
                Dim cookie1 As New HttpCookie("Codigo", datareader("Cod_usuario"))
                cookie1.Expires = #1/30/2015#
                Me.Response.Cookies.Add(cookie1)
                'en caso de que el usuario sea correcto se redirecciona a la siguiente pagina
                Response.Redirect("WebForm2.aspx")
            End While
            conexion.Close()
        Catch ex As Exception
            Response.Write("Error con conexion a Base de Datos")
        End Try
    End Sub
End Class