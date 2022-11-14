Imports MySql.Data.MySqlClient
Public Class Transacciones
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        nomesa.Text = mesaseleccionada
        fecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Response.Redirect("menumesas.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles fabrica_transaccion.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
        'Crear SQL
        Dim sql As String
        sql = "Call ActualizaOcupado ('" & (nomesa.Text) & "')"
        Dim comando As New MySqlCommand(sql, conexion)
        da = New MySqlDataAdapter(sql, oConexion)
        dt = New DataTable
        da.Fill(dt)
        Me.Focus()
        fabrica_transaccion.Visible = False
        canc_pedido.Visible = True
        Grilla_Transaccion.Enabled = True
        Label6.Text = "PLATO:"
        cambio.Enabled = True
        cambio.Text = "CAMBIAR"
        nomesa.Enabled = False
        nomesa.ReadOnly = True
    End Sub

    Protected Sub canc_pedido_Click(sender As Object, e As EventArgs) Handles canc_pedido.Click
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
        'Crear SQL
        Dim sql As String
        sql = "Call ActualizaDisponible ('" & (nomesa.Text) & "')"
        Dim comando As New MySqlCommand(sql, conexion)
        da = New MySqlDataAdapter(sql, oConexion)
        dt = New DataTable
        da.Fill(dt)
        Me.Focus()
        canc_pedido.Visible = False
        fabrica_transaccion.Visible = True
        fabrica_transaccion.Focus()
        Grilla_Transaccion.Enabled = True
        Grilla_Transaccion.Enabled = False
        Label6.Text = "PLATO:"
        cambio.Enabled = False
        cambio.Text = "CAMBIAR"
        nomesa.Enabled = False
        nomesa.ReadOnly = True

    End Sub
    Protected Sub bor_seleccion0_Click(sender As Object, e As EventArgs) Handles bor_seleccion0.Click
        Dim dt As New DataTable()
        Dim row1 As DataRow
        Dim row2 As DataRow
        dt.Columns.Add(New DataColumn("Producto", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("Precio", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("Cantidad", System.Type.GetType("System.String")))
        row1 = dt.NewRow()
        row1("Producto") = TextBox9.Text
        row1("Precio") = TextBox10.Text
        row1("Cantidad") = TextBox11.Text
        dt.Rows.Add(row1)
        Grilla_Transaccion.DataSource = dt
        Grilla_Transaccion.DataBind()
    End Sub
    Protected Sub Button2_Click1(sender As Object, e As EventArgs) Handles Button2.Click
        grabar_detalle_factura()
        MsgBox("Factura grabada con exito")
    End Sub
    Sub grabar_detalle_factura()
        Dim conexion As MySqlConnection
        conexion = New MySqlConnection
        conexion.ConnectionString = "Server=Localhost;Database=marioluigi;Uid=root;pwd=root;"
        'Crear SQL

        For i = 0 To Grilla_Transaccion.Rows.Count - 1
            Dim sql As String
            sql = "insert into historial_pedidos(Producto,Precio,Cantidad) values('" & (Grilla_Transaccion.DataSource(0, i).Value) & "'," & (Grilla_Transaccion.DataSource(1, i).Value) & "," & (Grilla_Transaccion.DataSource(2, i).Value) & "')"
            Dim comando As New MySqlCommand(sql, conexion)
            da = New MySqlDataAdapter(sql, oConexion)
            dt = New DataTable
            da.Fill(dt)
        Next
    End Sub
End Class