Public Class MenuMesas
    Friend WithEvents botones As System.Windows.Forms.Button
    Dim estado As String
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
        Beep()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles salir.Click
        Application.Exit()
        Beep()
    End Sub
    Private Sub admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        Me.Hide()
        Administracion.Show()
    End Sub
    Private Sub MenuMesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=restaurantlapicada;Data Source=localhost;User Id=root;Password=root"
        Dim i As Integer
        Dim x As Integer
        Dim y As Integer
        x = 190
        y = 24
        Actualizacion_Tabla()
        For Each row As DataRow In DT.Rows
            botones = New System.Windows.Forms.Button
            botones.Text = CStr(row("NumeroMesa"))
            botones.Location = New Point(x, y)
            botones.Height = 37
            y += 43
            If y >= 283 Then
                y = 24
                x += 100
            End If
            For i = 1 To DT2.Rows.Count
                botones.Name = "sele_mesa" & i
                botones.Cursor = Cursors.Hand
                botones.BackColor = Color.White
                GroupBox1.Controls.Add(botones)
                mesas_dispo_ocup()
            Next
            AddHandler botones.Click, AddressOf boton1_Click
        Next
    End Sub
    Sub Actualizacion_Tabla()
        Consulta("Call GeneracionBotones")
    End Sub
    Sub mesas_dispo_ocup()
        Consulta2("Call CambiarColor ('" & (botones.Text) & "')")
        If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
            estado = DS2.Tables(DT2.TableName).Rows(0).Item("Estado")
        End If
        If estado = "Disponible" Then
            botones.BackColor = Color.White
            botones.ForeColor = Color.Black
        End If
        If estado = "Ocupado" Then
            botones.BackColor = Color.DarkRed
            botones.ForeColor = Color.White
        End If
    End Sub
    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles botones.Click
        mesaseleccionada = sender.text
        Pedidos.Show()
    End Sub
End Class
