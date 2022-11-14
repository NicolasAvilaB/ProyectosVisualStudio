Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        List.Items.Remove(List.Text)
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        List.Items.Add(TextBox1.Text)
    End Sub

    Protected Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        List.Items.Clear()
    End Sub
End Class