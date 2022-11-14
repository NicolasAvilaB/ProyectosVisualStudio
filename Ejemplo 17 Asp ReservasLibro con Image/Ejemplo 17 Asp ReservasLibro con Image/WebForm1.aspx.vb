Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub mostrar_Click(sender As Object, e As EventArgs) Handles mostrar.Click
        SqlDataSource1.SelectCommand = "Select * from libros where nombre like '%" & TextBox1.Text & "%'"
    End Sub
End Class