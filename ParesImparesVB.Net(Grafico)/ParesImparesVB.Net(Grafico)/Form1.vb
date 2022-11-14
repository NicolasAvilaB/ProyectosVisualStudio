Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub calculator_Click(sender As Object, e As EventArgs) Handles calculator.Click
        If (num1.Text = "") Then
            MsgBox("Error: No Existe un Numero Ingresado en el Campo Numero", vbCritical, "Error, Campo Vacio")
            num1.Focus()
            num1.Select()
        Else
            If (Convert.ToInt64(num1.Text) Mod 2 = 0) Then
                MsgBox("El Numero " + num1.Text + " Es Par", vbInformation, "Numero Par")
                num1.Clear()
                num1.Focus()
                num1.Select()
            Else
                MsgBox("El Numero " + num1.Text + " Es Impar", vbInformation, "Numero Impar")
                num1.Clear()
                num1.Focus()
                num1.Select()
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num1.Focus()
        num1.Select()
    End Sub

    Private Sub num1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles num1.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
End Class
