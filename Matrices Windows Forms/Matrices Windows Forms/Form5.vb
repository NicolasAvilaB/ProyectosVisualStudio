Public Class Form5
    Dim suma As Integer
    Dim MatrizA(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
    Dim MatrizB(,) As Integer = {{9, 8, 7}, {6, 5, 4}, {3, 2, 1}}
    Dim Sumar As Integer
    Dim fil, col As Integer


    Private Sub BtnMatriz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatriz.Click
      

        DataGridView1.RowCount = 3
        DataGridView1.ColumnCount = 3

        'Mostrar la Matris'
        For col = 0 To 2
            For fil = 0 To 2
                DataGridView1.Item(col, fil).Value = MatrizA(fil, col)

            Next
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        DataGridView2.RowCount = 3
        DataGridView2.ColumnCount = 3

       
        'Mostrar la Matris'
        For col = 0 To 2
            For fil = 0 To 2
                DataGridView2.Item(col, fil).Value = MatrizB(fil, col)

            Next
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView3.RowCount = 3
        DataGridView3.ColumnCount = 3
        For col = 0 To 2
            For fil = 0 To 2
                Sumar = MatrizA(fil, col) + MatrizB(fil, col)
                DataGridView3.Item(col, fil).Value = Sumar
            Next
        Next

    End Sub
End Class