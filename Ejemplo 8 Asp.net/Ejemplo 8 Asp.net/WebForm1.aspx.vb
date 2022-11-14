Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label1.Text = ""
        Dim i As ListItem
        For Each i In CheckBoxList1.Items
            If i.Selected Then
                Label1.Text &= i.Text & ","
            End If
        Next

    End Sub

    Protected Sub CheckBoxList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckBoxList1.SelectedIndexChanged

    End Sub
End Class