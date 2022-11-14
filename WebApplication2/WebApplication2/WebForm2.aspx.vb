Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim totalRegistros As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.ConnectionString = "database=base_trabajo2;data source=localhost;user id=root;password=manuel"
        lbl_fecha.Text = FormatDateTime(Now, DateFormat.ShortDate)

    End Sub
    Sub limpiar()
        txttotal.Text = 0

    End Sub
    Sub grabar_factura()
        Dim mifecha As Date
        Dim mifecha2 As String
        mifecha = lbl_fecha.Text
        mifecha2 = mifecha.ToString("yyyy-MM-dd")

        miconsulta("INSERT INTO historial_compra (id_pedido,fecha,total) VALUES ('" & (txtfactura.Text) & "','" & (mifecha2) & "','" & (txttotal.Text) & "')")

    End Sub

    Sub llenar_combo_platos()
        txtcodigo.Items.Clear()
        miconsulta("select * from platos")
        totalRegistros = DS.Tables(DT.TableName).Rows.Count

        If totalRegistros > 0 Then
            For i = 0 To totalRegistros - 1
                txtcodigo.Items.Add(DS.Tables(DT.TableName).Rows(i).Item("codigo"))
            Next
        End If
    End Sub
    Sub mostrar_datos_platos()

        If txtcodigo.Text <> "" Then
            miconsulta("select * from platos where codigo='" & (txtcodigo.Text) & "'")

            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                txtnombre.Text = DS.Tables(DT.TableName).Rows(0).Item("nombre")

                txtprecio.Text = DS.Tables(DT.TableName).Rows(0).Item("precio")


            End If
        End If
    End Sub
    Sub llenar_combo_bebidas()
        txtcodigo2.Items.Clear()
        miconsulta("select * from bebidas")
        totalRegistros = DS.Tables(DT.TableName).Rows.Count

        If totalRegistros > 0 Then
            For i = 0 To totalRegistros - 1
                txtcodigo2.Items.Add(DS.Tables(DT.TableName).Rows(i).Item("codigo"))
            Next
        End If
    End Sub
    Sub mostrar_datos_bebidas()
        If txtcodigo2.Text <> "" Then
            miconsulta("select * from bebidas where codigo='" & (txtcodigo2.Text) & "'")

            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Txtnombre2.Text = DS.Tables(DT.TableName).Rows(0).Item("nombre")
                txtprecio2.Text = DS.Tables(DT.TableName).Rows(0).Item("precio")

            End If
        End If
    End Sub
    Sub crear_numero_factura()
        miconsulta("select max(id_pedido) as Vnventa from historial_compra")

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("Vnventa")) Is DBNull Then
            txtfactura.Text = 1
        Else
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Dim VarNumFactura As Integer = DS.Tables(DT.TableName).Rows(0).Item("Vnventa") + 1
                txtfactura.Text = VarNumFactura
            End If
        End If
    End Sub

    Protected Sub txtcodigo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcodigo.SelectedIndexChanged

        mostrar_datos_platos()
    End Sub

    Protected Sub txtcodigo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcodigo2.SelectedIndexChanged

        mostrar_datos_bebidas()
    End Sub

    Protected Sub Btnuevo_Click(sender As Object, e As EventArgs) Handles Btnuevo.Click
        crear_numero_factura()
        limpiar()
    End Sub

    Protected Sub Btnpagada_Click(sender As Object, e As EventArgs) Handles Btnpagada.Click
        miconsulta("update mesa set estado='libre' where n_mesas='" & (txtmesa.Text) & "'")


    End Sub

    Protected Sub Btnagregarplato_Click(sender As Object, e As EventArgs) Handles Btnagregarplato.Click
        Dim dt As New DataTable()
        Dim row1 As DataRow
        Dim row2 As DataRow


        dt.Columns.Add(New DataColumn("codigo", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("nombre", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("precio", System.Type.GetType("System.String")))
        row1 = dt.NewRow()

        row1("codigo") = Me.txtcodigo.Text
        row1("nombre") = Me.txtnombre.Text
        row1("precio") = Me.txtprecio.Text
        dt.Rows.Add(row1)

        row2 = dt.NewRow()

        row2("codigo") = Me.txtcodigo2.Text
        row2("nombre") = Me.Txtnombre2.Text
        row2("precio") = Me.txtprecio2.Text
        dt.Rows.Add(row2)


        GridView2.DataSource = dt
        GridView2.DataBind()


    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Response.Redirect("WebForm1.aspx")
    End Sub

    Protected Sub Btnbebida_Click(sender As Object, e As EventArgs) Handles Btnbebida.Click
        Dim dt As New DataTable()
        Dim row1 As DataRow
        Dim row2 As DataRow

        dt.Columns.Add(New DataColumn("codigo", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("nombre", System.Type.GetType("System.String")))
        dt.Columns.Add(New DataColumn("precio", System.Type.GetType("System.String")))
        row1 = dt.NewRow()

        row1("codigo") = Me.txtcodigo.Text
        row1("nombre") = Me.txtnombre.Text
        row1("precio") = Me.txtprecio.Text
        dt.Rows.Add(row1)


        row2 = dt.NewRow()

        row2("codigo") = Me.txtcodigo2.Text
        row2("nombre") = Me.Txtnombre2.Text
        row2("precio") = Me.txtprecio2.Text
        dt.Rows.Add(row2)



        GridView2.DataSource = dt
        GridView2.DataBind()

    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txtfactura.Text = "" Then
            MsgBox("aprete nuevo")
        Else
            grabar_factura()
            'grabar_detalle_factura()
            MsgBox("Factura grabada con exito")
        End If
    End Sub
    Sub grabar_detalle_factura()

        For i = 0 To GridView2.Rows.Count - 1

            miconsulta("insert into detalle_orden(id_pedido,id_nombre,nombre,precio) values('" & (txtfactura.Text) & "," _
                                    & (GridView2.DataSource(0, i).Value) & ",'" _
                                    & (GridView2.DataSource(1, i).Value) & "'," _
                                    & (GridView2.DataSource(2, i).Value) & ")")

        Next
    End Sub

    Protected Sub Btnocupar_Click(sender As Object, e As EventArgs) Handles Btnocupar.Click
        miconsulta("update mesa set estado='ocupada'  where n_mesas='" & (txtmesa.Text) & "'")
    End Sub
End Class
