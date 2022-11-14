Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        exportar()
    End Sub
    Sub exportar()
        Dim dset As New DataSet
        dset.Tables.Add()
        For i As Integer = 0 To Grilla.ColumnCount - 1
            dset.Tables(0).Columns.Add(Grilla.Columns(i).HeaderText)
        Next
        Dim dr1 As DataRow
        For i As Integer = 0 To Grilla.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To Grilla.Columns.Count - 1
                dr1(j) = Grilla.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next
        Dim excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet
        wBook = excel.Workbooks.Add
        wSheet = wBook.ActiveSheet()
        wSheet.Name = "Ejemplo"
        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colindex As Integer = 0
        Dim rowindex As Integer = 0
        For Each dc In dt.Columns
            colindex = colindex + 1
            excel.Cells(1, colindex) = dc.ColumnName
        Next
        For Each dr In dt.Rows
            rowindex = rowindex + 1
            colindex = 0
            For Each dc In dt.Columns
                colindex = colindex + 1
                excel.Cells(rowindex + 1, colindex) = dr(dc.ColumnName)
            Next
        Next
        wSheet.Columns.AutoFit()
        Dim blnFileOpen As Boolean = False
        Try
        Catch ex As Exception
            blnFileOpen = False
        End Try
        excel.Visible = True
    End Sub
End Class
