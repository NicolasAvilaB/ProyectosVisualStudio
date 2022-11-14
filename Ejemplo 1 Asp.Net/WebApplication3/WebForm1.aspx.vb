Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Write("Hola Mundo")



        If (Button2.Text = "Cambiar") Then

            TextBox1.BackColor = Drawing.Color.Red
            Button2.Text = "Volver"
            TextBox1.BorderColor = Drawing.Color.Blue
            TextBox1.ForeColor = Drawing.Color.Blue

        Else

            TextBox1.BackColor = Drawing.Color.White
            Button2.Text = "Cambiar"
            TextBox1.BorderColor = Drawing.Color.Gray
            TextBox1.ForeColor = Drawing.Color.Black


        End If
    End Sub

   

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click

    End Sub
End Class