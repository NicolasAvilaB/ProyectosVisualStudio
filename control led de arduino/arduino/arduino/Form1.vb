
Public Class Form1
    Dim SerialPort As New IO.Ports.SerialPort
    Dim valor As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SerialPort.StopBits = IO.Ports.StopBits.Two
        SerialPort.Close()
        SerialPort.PortName = "COM4"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SerialPort.Open()
        SerialPort.Write("255")
        SerialPort.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SerialPort.Open()
        SerialPort.Write("0")
        SerialPort.Close()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim a As Integer
        a = TrackBar1.Value
        SerialPort.Open()
        Threading.Thread.Sleep(2)
        SerialPort.Write(a)
        SerialPort.Close()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text = "") Then
            valor = 0
            luminosidadled_textbox()
        Else
            valor = Convert.ToInt32(TextBox1.Text)
        End If
        If (valor > 255) Then
            valor = 255
            TextBox1.Text = "255"
            luminosidadled_textbox()
        Else
            luminosidadled_textbox()
        End If
    End Sub
    Sub luminosidadled_textbox()
        Dim a As Integer
        a = valor
        SerialPort.Open()
        Threading.Thread.Sleep(2)
        SerialPort.Write(a)
        SerialPort.Close()
    End Sub
End Class
