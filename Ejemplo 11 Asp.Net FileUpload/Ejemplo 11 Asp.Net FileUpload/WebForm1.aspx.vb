Imports System.IO
Public Class WebForm1

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Subir_Click(sender As Object, e As EventArgs) Handles Subir.Click

        Dim rutaarchivo As String
        Dim extension As String

        img.Width = 0

        img.ImageUrl = ""

        If FileUpload1.HasFile Then
            rutaarchivo = FileUpload1.FileName
            extension = Path.GetExtension(rutaarchivo)

            If validaextension(extension) Then
                FileUpload1.SaveAs(MapPath("~/imagenes/" & rutaarchivo))
                img.Width = 300
                img.Width = 300
                img.ImageUrl = "/imagenes/" & rutaarchivo
                Label1.Text = "Archivo Cargado Correctamente"
                DropDownList1.Items.Add(FileUpload1.FileName)
            Else
                Label1.Text = "El Archivo no es una IMagen"
            End If
        Else
            Label1.Text = "Seleccione Archivo"
        End If
    End Sub
    Private Function validaextension(ByVal extension As String) As Boolean
        Select Case extension
            Case ".jpg", ".jpeg", ".png", ".gif", ".bmp"
                Return True
            Case Else
                Return False
        End Select

    End Function

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub

    Private Sub DropDownList1_TextChanged(sender As Object, e As EventArgs) Handles DropDownList1.TextChanged
        img.ImageUrl = "/imagenes/" & DropDownList1.SelectedValue
    End Sub
End Class