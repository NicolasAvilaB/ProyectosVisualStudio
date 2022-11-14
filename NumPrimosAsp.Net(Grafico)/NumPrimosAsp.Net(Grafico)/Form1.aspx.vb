Public Class Form1
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        num1.Focus()
    End Sub
    Protected Sub calculador_Click(sender As Object, e As EventArgs) Handles calculador.Click
        If (num1.Text = "") Then
            MsgBox("Error: No Existe un Numero Ingresado en el Campo Numero", vbCritical, "Error, Campo Vacio")
            num1.Focus()
        Else
            Dim a As Integer = 0
            For i As Integer = 1 To Convert.ToInt64(num1.Text) + 1
                If (Convert.ToInt64(num1.Text) Mod i = 0) Then
                    a = a + 1
                End If
            Next i
            If (a <> 2) Then
                MsgBox("El Numero " + num1.Text + " No es Primo", vbInformation, "Numero No Primo")
                num1.Text = ""
                num1.Focus()

            Else
                MsgBox("El Numero " + num1.Text + " Si es Primo", vbInformation, "Numero Primo")
                num1.Text = ""
                num1.Focus()
            End If
        End If
    End Sub
End Class