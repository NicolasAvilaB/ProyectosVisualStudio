Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

    Private dtabla As DataTable
    Private data As MySqlDataAdapter
    Dim fila As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=biblioteca;Uid=root;pwd=root;"
            Dim SQL As String = "SELECT * FROM usuario ORDER BY nombre"

            Try
                data = New MySqlDataAdapter(SQL, conexion)
                dtabla = New DataTable
                data.Fill(dtabla)
            Catch ex As Exception
                MsgBox("ERROR")
            End Try
            DropDownList1.DataSource = dtabla
            DropDownList1.DataTextField = "nombre" 'Campo

            DropDownList1.DataValueField = "rut"
            '....Campo que se captura para la consulta siguiente.....
            DropDownList1.DataBind()
        End If
    End Sub

    Protected Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Dim Conexion2 As New MySqlConnection("Server=Localhost;Database=biblioteca;Uid=root;pwd=root;")
        Dim DataS As New DataSet
        Dim Tabla As New DataTable
        Dim data As New MySqlDataAdapter("select libros.nombre, reservas.fecha_prestamo, reservas.fecha_devolucion from reservas, libros where reservas.libros_codigo = libros.codigo and usuario_rut='" & DropDownList1.SelectedValue.ToString & "'", Conexion2)

        Try
            Dim Cmd As New MySqlCommandBuilder(data)

            'llenamos la tabla desde la BD
            data.Fill(Tabla)
            'mostramos datos en el GridView
            GridView1.DataSource = Tabla
            GridView1.DataBind()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            Conexion2 = Nothing
            DataS = Nothing
            Tabla = Nothing
            data = Nothing
        End Try
    End Sub
End Class