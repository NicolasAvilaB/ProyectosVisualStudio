Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If (DropDownList1.Text = "Chile") Then
            DropDownList2.Items.Clear()
            DropDownList2.Items.Add("Santiago")
            DropDownList2.Items.Add("Rancagua")
            DropDownList2.Items.Add("Puerto Montt")
        ElseIf (DropDownList1.Text = "Argentina") Then
            DropDownList2.Items.Clear()
            DropDownList2.Items.Add("Buenos Aires")
            DropDownList2.Items.Add("Esperanza")
            DropDownList2.Items.Add("Cordova")
        ElseIf (DropDownList1.Text = "Mexico") Then
            DropDownList2.Items.Clear()
            DropDownList2.Items.Add("Mexico DF")
            DropDownList2.Items.Add("Acapulco")
            DropDownList2.Items.Add("La Becindad del Chavo")
        End If

        ' DropDownList2.items.clear()
        'select case pais.selecteditem.text
        'case "argentina"
        '  DropDownList2.items.add(new listitem("buenos aires"))
        '  DropDownList2.items.add(new listitem("Cordova"))
        '  DropDownList2.items.add(new listitem("Esperanza"))
        'case "Mexico"
        '  DropDownList2.items.add(new listitem("ciudad mexico"))
        '  DropDownList2.items.add(new listitem("becindad del chavo"))
        '  DropDownList2.items.add(new listitem("mexico df"))
        'case "Chile"
        '  DropDownList2.items.add(new listitem("Arica"))
        '  DropDownList2.items.add(new listitem("Santiago"))
        '  DropDownList2.items.add(new listitem("rancagua"))
        'end select



    End Sub
End Class