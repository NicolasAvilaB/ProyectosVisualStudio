Public Class Form4

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        DataGridView1.Rows.Add(txtProducto.Text, txtPrecio.Text, txtCantidad.Text, txtPrecio.Text * txtCantidad.Text)
        txtTotal.Text += CInt(txtCantidad.Text) * CInt(txtPrecio.Text)
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        txtProducto.Focus()
    End Sub

    Private Sub BtnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar.Click
        DataGridView1.Rows.Clear()
        txtTotal.Text = 0
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtProducto.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
    End Sub
End Class
