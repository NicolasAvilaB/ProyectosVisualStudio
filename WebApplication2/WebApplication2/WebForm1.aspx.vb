Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        conexion.ConnectionString = "server= localhost;database=base_trabajo;Uid=root;pwd=manuel"
        crear_codigo_encuesta()
        crear_objetos()
    End Sub
    Sub crear_objetos()
        Panel1.Controls.Clear()
        Dim i As Integer
        Dim x As Integer
        Dim y As Integer
        Dim j As Integer
        Dim estado As String
        Dim cant_mesas As Integer = CInt(txtnmesa.Text)


        x = 10
        y = 10

        For i = 1 To cant_mesas
            Dim mibutton As Button = New Button
            mibutton.ID = " btnmesa" & i
            mibutton.Text = "mesa N " & i
            mibutton.Width = 100
            mibutton.Height = 50
            mibutton.BackColor = Drawing.Color.Olive

            Panel1.Controls.Add(mibutton)
            AddHandler mibutton.Click, AddressOf Me.Button_Click
            miconsulta("Select * from mesa where n_mesas='" & ("mesa N " & i) & "'")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                estado = DS.Tables(DT.TableName).Rows(0).Item("estado")
            End If
            If estado = "libre" Then
                mibutton.BackColor = Drawing.Color.Olive
            End If
            If estado = "ocupada" Then
                mibutton.BackColor = Drawing.Color.Red

            End If
            y += 60

            If y >= 300 Then
                y = 10
                x += 100

            End If


        Next

    End Sub
    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender
        selectedBtn.BackColor = Drawing.Color.Red

        Response.Redirect("WebForm2.aspx")






    End Sub
    Sub crear_codigo_encuesta()
        miconsulta("select count(n_mesas) as min_mesas from mesa")

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("min_mesas")) Is DBNull Then
            txtnmesa.Text = 0
        Else
            txtnmesa.Text = DS.Tables(DT.TableName).Rows(0).Item("min_mesas")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsalir.Click

    End Sub
End Class