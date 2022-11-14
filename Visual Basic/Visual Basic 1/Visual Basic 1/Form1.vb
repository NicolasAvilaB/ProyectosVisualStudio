Public Class Form1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
        If txtNum1.Text <> "" And txtNum2.Text <> "" Then

            If rdSumar.Checked = True Then
                txtResultado.Text = CInt(txtNum1.Text) + CInt(txtNum2.Text)
            ElseIf rdResta.Checked = True Then
                txtResultado.Text = CInt(txtNum1.Text) - CInt(txtNum2.Text)
            ElseIf rdMultiplicar.Checked = True Then
                txtResultado.Text = CInt(txtNum1.Text) * CInt(txtNum2.Text)
            ElseIf rdDividir.Checked = True Then
                txtResultado.Text = CInt(txtNum1.Text) / CInt(txtNum2.Text)
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
