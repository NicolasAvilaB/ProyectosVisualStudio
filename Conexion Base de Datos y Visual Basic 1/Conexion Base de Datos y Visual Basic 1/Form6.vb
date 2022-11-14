Public Class Form6

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub limpiar()
        TxtNombre.Clear()
        TxtPrecio.Clear()
        TxtCantidad.Clear()

    End Sub
    Sub Control(ByVal a As Boolean, ByVal b As Boolean)
        TxtNombre.ReadOnly = b
        TxtPrecio.ReadOnly = b
        TxtCantidad.ReadOnly = b

        BtAgregarProducto.Enabled = a
        BtQuitar.Enabled = a
        BtNuevaVenta.Enabled = b
        BtGrabarVenta.Enabled = a
        BtCancelar.Enabled = a
        BtBuscar.Enabled = b
        TxtBuscar.ReadOnly = a
    End Sub
    Sub crearnumeroventa()
        Mionsulta("select max(n_venta) as Vnventa from venta")
        If TypeOf (DS1.Tables(DT1.TableName).Rows(0).Item("Vnventa")) Is DBNull Then
            TxtNventa.Text = 1
        Else
            TxtNventa.Text = DS1.Tables(DT1.TableName).Rows(0).Item("Vnventa") + 1
        End If
        Conexion1.Close()
    End Sub
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conexion1.ConnectionString = "Data Source=NICO-PC;Initial Catalog=BASEVENTAS;user Id=sa; Password =aiep123+*;"

        TxtFecha.Text = FormatDateTime(Now, DateFormat.ShortDate)

    End Sub

    Private Sub BtNuevaVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtNuevaVenta.Click
        crearnumeroventa()
        Control(True, False)
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub BtBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtBuscar.Click

    End Sub

    Private Sub BtAgregarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAgregarProducto.Click
        If TxtNombre.Text <> "" And TxtCantidad.Text <> "" And TxtPrecio.Text <> "" Then
            DataGridView1.Rows.Add(TxtNombre.Text, TxtPrecio.Text, TxtCantidad.Text, TxtPrecio.Text * TxtCantidad.Text)

        End If
        limpiar()
        calcular_total()
    End Sub
    Sub calcular_total()
        TxtTotal.Text = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            TxtTotal.Text += DataGridView1.Item(3, i).Value
        Next
    End Sub

    Private Sub BtQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtQuitar.Click
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If
        calcular_total()
    End Sub

    Private Sub BtGrabarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGrabarVenta.Click
        grabar_venta()
        'grabar_detalle_venta()
        MsgBox("Venta Grabada")
        Control(False, True)

    End Sub
    Sub grabar_venta()
        Dim mifecha As Date
        Dim mifechaOK As String
        mifecha = TxtFecha.Text
        mifechaOK = mifecha.ToString("yyyy-MM-dd")

        MiConsulta2("Insert Into VENTA(N_VENTA,FECHA)values(" & (TxtNventa.Text) & ",'" & (mifechaOK) & "') ")
    End Sub
End Class