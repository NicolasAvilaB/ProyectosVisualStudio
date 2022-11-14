Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles calculador.Click
        If (num1.Text = "") Then
            MsgBox("Error: No Existe un Numero Ingresado en el Campo Numero", vbCritical, "Error, Campo Vacio")
            num1.Focus()
            num1.Select()
        Else
            Dim a As Integer = 0
            For i As Integer = 1 To Convert.ToInt64(num1.Text) + 1
                If (Convert.ToInt64(num1.Text) Mod i = 0) Then
                    a = a + 1
                End If
            Next i
            If (a <> 2) Then
                MsgBox("El Numero " + num1.Text + " No es Primo", vbInformation, "Numero No Primo")
                num1.Clear()
                num1.Focus()
                num1.Select()
            Else
                MsgBox("El Numero " + num1.Text + " Si es Primo", vbInformation, "Numero Primo")
                num1.Clear()
                num1.Focus()
                num1.Select()
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
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
