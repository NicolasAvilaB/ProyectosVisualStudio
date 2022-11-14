
Public Class Form2

    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        txtRut.Enabled = a
        txtNombre.Enabled = a
        txtDireccion.Enabled = a
        txtCiudad.Enabled = a
        txtTelefono.Enabled = a
        txtClaveAcceso.Enabled = a
        txtCantidadBloques.Enabled = a

        Bt_Aceptar.Enabled = a
        Bt_Cancelar.Enabled = a

        Bt_Nuevo.Enabled = b
        Bt_Modificar.Enabled = b
        Bt_Eliminar.Enabled = b
        Bt_Buscar.Enabled = b
        Bt_Imprimir.Enabled = b


    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Bt_Todos_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Nuevo.MouseLeave, Bt_Aceptar.MouseLeave, Bt_Eliminar.MouseLeave, Bt_Modificar.MouseLeave, Bt_Imprimir.MouseLeave, Bt_Buscar.MouseLeave, Bt_Salir.MouseLeave, Bt_Cancelar.MouseLeave, Bt_Primero.MouseLeave, Bt_Anterior.MouseLeave, Bt_Siguiente.MouseLeave, Bt_Ultimo.MouseLeave
        sender.BackColor = Color.LimeGreen
    End Sub

    Private Sub Bt_Todos_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Bt_Nuevo.MouseMove, Bt_Aceptar.MouseMove, Bt_Eliminar.MouseMove, Bt_Modificar.MouseMove, Bt_Imprimir.MouseMove, Bt_Buscar.MouseMove, Bt_Salir.MouseMove, Bt_Cancelar.MouseMove, Bt_Primero.MouseMove, Bt_Anterior.MouseMove, Bt_Siguiente.MouseMove, Bt_Ultimo.MouseMove
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub txtRut_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRut.GotFocus, txtNombre.GotFocus, txtDireccion.GotFocus, txtCiudad.GotFocus, txtTelefono.GotFocus, txtClaveAcceso.GotFocus, txtCantidadBloques.GotFocus
        sender.BackColor = Color.Aqua
    End Sub

    Private Sub txtRut_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRut.LostFocus, txtNombre.LostFocus, txtDireccion.LostFocus, txtCiudad.LostFocus, txtTelefono.LostFocus, txtClaveAcceso.LostFocus, txtCantidadBloques.LostFocus
        sender.BackColor = Color.White
    End Sub

    Private Sub Bt_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Nuevo.Click
        controles(True, False)
    End Sub

    Private Sub Bt_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Modificar.Click
        controles(True, False)
    End Sub

    Private Sub Bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Aceptar.Click
        controles(False, True)
    End Sub

    Private Sub Bt_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cancelar.Click
        controles(False, True)
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

