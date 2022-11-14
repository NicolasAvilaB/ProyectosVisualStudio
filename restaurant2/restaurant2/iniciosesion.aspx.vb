Imports MySql.Data.MySqlClient

Public Class iniciosesion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        Try
            'Crear la Conexion
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
            'Crear SQL
            Dim sql As String
            sql = "Call CompruebaNombreyClave ('" & (nombre.Text) & "','" & (clave.Text) & "')"
            Dim comando As New MySqlCommand(sql, conexion)
            da = New MySqlDataAdapter(sql, oConexion)
            dt = New DataTable
            da.Fill(dt)
            Response.Redirect("menumesas.aspx")
        Catch ex As Exception
            Response.Redirect("menumesas.aspx")
        End Try
    End Sub
End Class