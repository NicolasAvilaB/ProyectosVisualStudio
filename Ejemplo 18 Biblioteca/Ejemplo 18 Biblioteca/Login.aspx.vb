Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Try

            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=biblio;Uid=root;pwd=root;"
            Dim comando As New MySqlCommand("select * from usuarios where nombre='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", conexion)
            conexion.Open()
            Dim DataReader As MySqlDataReader
            DataReader = comando.ExecuteReader()
            While DataReader.Read()
                Me.Session("usuario") = DataReader("nombre")
                Dim cookie1 As New HttpCookie("rut", DataReader("rut"))
                cookie1.Expires = #1/30/2017#
                Me.Response.Cookies.Add(cookie1)
                Response.Redirect("Menu.aspx")
            End While
            conexion.Close()
        Catch ex As Exception
            Response.Write("Error de conexion a la Base de Datos")
        End Try
    End Sub
End Class