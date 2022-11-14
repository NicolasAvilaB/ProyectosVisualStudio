Public Class Secciones1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Principal.Height = 607
        Principal.Show()
        Principal.nombre.Clear()
        Principal.clave.Clear()
        Principal.Ver.Text = "Mostrar"
        Principal.clave.PasswordChar = "*"
        Principal.nombre.Focus()
        Principal.nombre.Select()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Usuarios.Show()
        Usuarios.nuevo.Focus()
        Usuarios.nuevo.Select()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Bodega_User.Show()
        Bodega_User.Mostrar_Grilla()
        Bodega_User.Actualizacion_Tabla()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Gestion_Clave_Acceso.Owner = Me
        Gestion_Clave_Acceso.ShowDialog()
        Gestion_Clave_Acceso.nombre.Focus()
        Gestion_Clave_Acceso.nombre.Select()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Principal.Height = 607
        Principal.Show()
        Principal.nombre.Clear()
        Principal.clave.Clear()
        Principal.Ver.Text = "Mostrar"
        Principal.clave.PasswordChar = "*"
        Principal.nombre.Focus()
        Principal.nombre.Select()
    End Sub
End Class