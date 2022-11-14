Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oConexion = New MySqlConnection
        oConexion.ConnectionString = "Server=Localhost;Database=biblioteca;Uid=root;pwd=root;"
        If Not IsPostBack Then
            Dim sSel As String = "SELECT * FROM usuario ORDER BY rut"
            Try
                da = New MySqlDataAdapter(sSel,
oConexion)
                dt = New DataTable
                da.Fill(dt)
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
            ddlRut.DataSource = dt
            ddlRut.DataTextField = "rut"
            ddlRut.DataValueField = "nombre"
            ddlRut.DataBind()
            txtnombre.Text =
            ddlrut.SelectedValue.ToString
        End If
    End Sub

    Protected Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click

    End Sub

    Protected Sub ddlrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlrut.SelectedIndexChanged

        ddlrut.DataBind()
        txtnombre.Text =
        ddlrut.SelectedValue.ToString

    End Sub

    Protected Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click
        Dim Con As New MySqlConnection("Server=Localhost;Database=biblioteca;Uid=root;pwd=root;")
        Dim Tabla As New DataTable
        Dim Da As New MySqlDataAdapter("Select * from libros where nombre like '%" & txtitulo.Text & "%'",
        Con)
        Try
            Dim Cmd As New MySqlCommandBuilder(Da)
            Da.Fill(Tabla)
            GridView1.DataSource = Tabla
            GridView1.DataBind()
            ddlcodigo.DataSource = Tabla
            ddlcodigo.DataTextField = "codigo"
            ddlcodigo.DataBind()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Protected Sub reserva_Click(sender As Object, e As EventArgs) Handles reserva.Click
        Dim hoy, FechaDevolucion As Date
        hoy = DateTime.Now.Date
        FechaDevolucion = DateTime.Now.Date
        If ddlcodigo.SelectedValue.ToString = "" Or
        ddldias.SelectedValue.ToString = "" Then
            Label1.Text = "Ingrese Rut y Codigo para ingresar el Registro"
        Else
            Try
                FechaDevolucion =
                FechaDevolucion.AddDays(ddldias.SelectedValue)
                Dim conexion As MySqlConnection
                conexion = New MySqlConnection
                conexion.ConnectionString =
                "Server=Localhost;Database=Biblioteca;Uid=root;pwd=123;"
                Dim sql As String
                sql = "INSERT INTO reservas (usuario_rut, libros_codigo, fecha_devolucion, fecha_prestamo) VALUES('" & ddlrut.SelectedItem.ToString & "','" & ddlcodigo.SelectedItem.ToString & "','" & FechaDevolucion.ToString("yyyy/MM/dd") & "','" & hoy.ToString("yyyy/MM/dd") & "')"
                Dim comando As New MySqlCommand(sql, conexion)
                Dim Resultado As Integer
                conexion.Open()
                Resultado = comando.ExecuteNonQuery()
                conexion.Close()
                Label1.Text = "Datos Guardados"
            Catch ex As Exception
                Label1.Text = "Error en el ingreso de los Datos"
            End Try
        End If
    End Sub
End Class