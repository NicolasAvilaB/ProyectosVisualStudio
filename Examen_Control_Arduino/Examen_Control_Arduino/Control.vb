Public Class Control
    Dim SerialPort As New IO.Ports.SerialPort
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub abrir_Click(sender As Object, e As EventArgs) Handles abrir.Click
        SerialPort.Open()
        SerialPort.Write("2")
        SerialPort.Close()
        abrir.Enabled = False
        cerrando.Enabled = True
        verificar_botones_ena()
    End Sub
    Private Sub Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        SerialPort.StopBits = IO.Ports.StopBits.Two
        SerialPort.Close()
        SerialPort.PortName = "COM4"
    End Sub
    Private Sub cerrando_Click(sender As Object, e As EventArgs) Handles cerrando.Click
        SerialPort.Open()
        SerialPort.Write("3")
        SerialPort.Close()
        abrir.Enabled = True
        cerrando.Enabled = False
        verificar_botones_ena()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
        'Dim a As Integer
        'a = TrackBar1.Value
        'SerialPort.Open()
        'Threading.Thread.Sleep(2)
        'SerialPort.Write(a)
        'SerialPort.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort.Open()
        SerialPort.Write("5")
        SerialPort.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SerialPort.Open()
        SerialPort.Write("4")
        SerialPort.Close()
        Button2.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SerialPort.Open()
        If SerialPort.ReadLine = "-1" Then
            abrir.Enabled = False
            cerrando.Enabled = True
            verificar_botones_ena()
        ElseIf SerialPort.ReadLine = "0"
            abrir.Enabled = True
            cerrando.Enabled = False
            verificar_botones_ena()
        End If
        SerialPort.Close()
    End Sub
    Sub verificar_botones_ena()
        If (abrir.Enabled = True) Then
            abrir.BackColor = Color.FromArgb(0, 131, 143)
        ElseIf (abrir.Enabled = False)
            abrir.BackColor = Color.White
        End If
        If (cerrando.Enabled = True) Then
            cerrando.BackColor = Color.FromArgb(0, 131, 143)
        ElseIf (cerrando.Enabled = False)
            cerrando.BackColor = Color.White
        End If
    End Sub
    Private Sub Button2_MouseMove(sender As Object, e As MouseEventArgs) Handles Button2.MouseMove
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.FromArgb(0, 131, 143)
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(0, 131, 143)
        Button2.ForeColor = Color.White
    End Sub
    Private Sub Button3_MouseMove(sender As Object, e As MouseEventArgs) Handles Button3.MouseMove
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.FromArgb(0, 131, 143)
    End Sub
    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(0, 131, 143)
        Button3.ForeColor = Color.White
    End Sub

    Private Sub abrir_MouseMove(sender As Object, e As MouseEventArgs) Handles abrir.MouseMove
        abrir.BackColor = Color.White
        abrir.ForeColor = Color.FromArgb(0, 131, 143)
    End Sub

    Private Sub abrir_MouseLeave(sender As Object, e As EventArgs) Handles abrir.MouseLeave
        abrir.BackColor = Color.FromArgb(0, 131, 143)
        abrir.ForeColor = Color.White
    End Sub

    Private Sub cerrando_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrando.MouseMove
        cerrando.BackColor = Color.White
        cerrando.ForeColor = Color.FromArgb(0, 131, 143)
    End Sub

    Private Sub cerrando_MouseLeave(sender As Object, e As EventArgs) Handles cerrando.MouseLeave
        cerrando.BackColor = Color.FromArgb(0, 131, 143)
        cerrando.ForeColor = Color.White
    End Sub

    Private Sub TrackBar1_Scroll_1(sender As Object, e As EventArgs)
        SerialPort.Open()
        SerialPort.Write("6")
        SerialPort.Close()
        Dim a As Integer
        'a = TrackBar1.Value
        SerialPort.Open()
        Threading.Thread.Sleep(2)
        SerialPort.Write(a)
        SerialPort.Close()
    End Sub
    Private Sub TrackBar1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
