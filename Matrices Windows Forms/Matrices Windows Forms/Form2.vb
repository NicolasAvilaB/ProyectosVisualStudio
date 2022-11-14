Public Class Form2

    Private Sub BtnMatriz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatriz.Click
        Dim Matriz(3, 3) As Integer
        Dim fil, col As Integer
        Dim minumero As Integer
        DataGridView1.RowCount = 3
        DataGridView1.ColumnCount = 3
        'Ingreso de Valores a Matrices'
        For col = 0 To 2
            For fil = 0 To 2
                minumero = InputBox("Ingrese Numero para Columna:" & col & "Fila:" & fil)
                Matriz(fil, col) = minumero
            Next
        Next
        'Mostrar a Matris'
        For col = 0 To 2
            For fil = 0 To 2
                DataGridView1.Item(col, fil).Value = Matriz(col, fil)
            Next
        Next
    End Sub
End Class