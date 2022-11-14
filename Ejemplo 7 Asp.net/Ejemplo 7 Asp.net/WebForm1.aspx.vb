Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub RadioButtonList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList2.SelectedIndexChanged
        If RadioButtonList2.SelectedValue = "Si" Then
            RadioButtonList3.Visible = True
        Else
            RadioButtonList3.Visible = False
        End If
    End Sub

    Protected Sub RadioButtonList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioButtonList3.SelectedIndexChanged
        Label2.Text = "Su Civil es:" & RadioButtonList3.SelectedItem.Text
    End Sub
End Class