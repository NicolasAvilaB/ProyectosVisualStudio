Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        If txtNombre.Text <> "" Then
            ListBox1.Items.Add(txtNombre.Text)
            txtNombre.Clear()
            txtNombre.Focus()
            txtCantidad1.Text = ListBox1.Items.Count
        Else
            MsgBox("Ingrese Nombre")
        End If
    End Sub

    Private Sub BtnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDerecha.Click
        If ListBox1.Text <> "" Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)

            txtCantidad1.Text = ListBox1.Items.Count
            txtCantidad2.Text = ListBox2.Items.Count
        Else
            MsgBox("Seleccionar Item")
        End If
    End Sub

    Private Sub BtnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIzquierda.Click
        If ListBox2.Text <> "" Then
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)

            txtCantidad1.Text = ListBox1.Items.Count
            txtCantidad2.Text = ListBox2.Items.Count
        Else
            MsgBox("Seleccionar Item")
        End If
    End Sub

    Private Sub BtnLimpiar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar1.Click
        ListBox1.Items.Clear()
        txtCantidad1.Text = 0
    End Sub

    Private Sub BtnLimpiar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLimpiar2.Click
        ListBox2.Items.Clear()
        txtCantidad2.Text = 0
    End Sub

    Private Sub BtnDerechaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDerechaTodos.Click
        If ListBox1.Items.Count > 0 Then
            ListBox2.Items.AddRange(ListBox1.Items)
        End If
        ListBox1.Items.Clear()
        txtCantidad1.Text = ListBox1.Items.Count
        txtCantidad2.Text = ListBox2.Items.Count

    End Sub

    Private Sub BtnIzquierdaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIzquierdaTodos.Click
        If ListBox2.Items.Count > 0 Then
            ListBox1.Items.AddRange(ListBox2.Items)
        End If
        ListBox2.Items.Clear()
        txtCantidad1.Text = ListBox1.Items.Count
        txtCantidad2.Text = ListBox2.Items.Count
    End Sub
End Class