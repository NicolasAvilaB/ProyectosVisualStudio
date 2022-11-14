Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Mostrar_Click(sender As Object, e As EventArgs) Handles Mostrar.Click
        Label3.Text = TextBox1.Text & " " & TextBox2.Text



    End Sub

    Protected Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        Lista1.Items.Add(TextBox1.Text & " " & TextBox2.Text)
    End Sub
End Class