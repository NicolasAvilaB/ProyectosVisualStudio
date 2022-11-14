Public Class Form3

    Private Sub BtnMatriz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMatriz.Click
        Dim Matriz(txtFilas.Text, txtColumnas.Text) As Integer
        Dim fil, col As Integer
        Dim minumero As Integer
        
        DataGridView1.RowCount = txtFilas.Text
        DataGridView1.ColumnCount = txtColumnas.Text
    
        'Ingreso de Valores a Matrices'
        For col = 0 To txtColumnas.Text - 1
            For fil = 0 To txtFilas.Text - 1

                minumero = InputBox("Ingrese Numero para Columna:" & col & "Fila:" & fil)
                Matriz(fil, col) = minumero


            Next
        Next
        'Mostrar la Matris'
        For col = 0 To txtColumnas.Text - 1
            For fil = 0 To txtFilas.Text - 1
                DataGridView1.Item(col, fil).Value = Matriz(fil, col)
               

            Next
        Next
    End Sub
End Class