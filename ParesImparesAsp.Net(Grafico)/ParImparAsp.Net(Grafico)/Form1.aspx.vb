Public Class Form1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub calculador_Click(sender As Object, e As EventArgs) Handles calculador.Click
        If (numero1.Text = "") Then
            MsgBox("Error: No Existe Ingreso de Datos en el Campo Numero", vbCritical, "Error, Campo Vacio")
            numero1.Text = ""
            numero1.Focus()
        Else
            If (Convert.ToInt64(numero1.Text) Mod 2 = 0) Then
                MsgBox("El Numero " + numero1.Text + " Es Par", vbInformation, "Numero Par")
                numero1.Text = ""
                numero1.Focus()
            Else
                MsgBox("El Numero " + numero1.Text + " Es Impar", vbInformation, "Numero Impar")
                numero1.Text = ""
                numero1.Focus()
            End If
        End If
    End Sub
End Class