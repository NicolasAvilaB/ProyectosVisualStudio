Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_listar_Click(sender As Object, e As EventArgs) Handles btn_listar.Click
        Dim d As New DataTable("dtlistado")
        d.Columns.Add("item")
        d.Columns.Add("nombre")
        Dim a As String = (Replace(Application.StartupPath.ToString, "\bin\Debug", "") + "\archivos")

        Dim dr As DataRow
        dr = d.NewRow()
        For Each fi As FileInfo In New DirectoryInfo(a).GetFiles()
            dr = d.NewRow()
            dr("item") = fi.Name
            dr("nombre") = fi.Name
            d.Rows.Add(dr)
        Next

        Dim dr2 As DataRow
        dr2 = d.NewRow()
        dr2.Item(0) = "0"
        dr2.Item(1) = "- SELECCIONE -"
        d.Rows.InsertAt(dr2, 0)

        cbo_archivos.DataSource = d
        cbo_archivos.ValueMember = d.Columns(0).ToString.Trim
        cbo_archivos.DisplayMember = d.Columns(1).ToString.Trim
    End Sub

    Private Sub cbo_archivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_archivos.SelectedIndexChanged
        Dim strFileName As String
        If cbo_archivos.SelectedIndex <> 0 Then
            strFileName = (Replace(Application.StartupPath.ToString, "\bin\Debug", "") + "\archivos\" + cbo_archivos.Text)
            CargarWord(strFileName)

        Else
            RichTextBox1.Text = ""
        End If

    End Sub

    Sub CargarWord(ByVal File As Object)
        Dim doc As New Microsoft.Office.Interop.Word.Document
        Dim wordApp As New Microsoft.Office.Interop.Word.Application
        Dim Nothingobj As Object = System.Reflection.Missing.Value

        doc = wordApp.Documents.Open(File, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj, Nothingobj)
        doc.ActiveWindow.Selection.WholeStory()
        doc.ActiveWindow.Selection.Copy()
        Dim data As IDataObject = Clipboard.GetDataObject()
        RichTextBox1.Rtf = data.GetData(DataFormats.Rtf).ToString()
        doc.Close()
    End Sub

End Class
