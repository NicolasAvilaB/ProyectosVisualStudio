Public Class Bodega_User_Modo_Detallado
    Dim conta As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub vol_Click(sender As Object, e As EventArgs) Handles vol.Click
        Me.Close()
        Secciones1.Show()
    End Sub
    Private Sub borratodo_Click(sender As Object, e As EventArgs) Handles borratodo.Click
        Dim esult As String
        If Me.Grilla_Detalle.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Asegurese de Agregar Alguno e Intentelo Denuevo", vbCritical, "Error Fatal, Grilla Vacia")
            nom.Focus()
            nom.Select()
            nom.Clear()
            Agregue_Productos.Clear()
            Agregue_Productos.Enabled = False
            Agregue_Productos.ReadOnly = True
        Else
            esult = MsgBox("¿Estas Seguro de Eliminar la Transaccion Hecha Hasta El Momento?", vbOKCancel + vbQuestion, "Eliminar Transaccion")
            If esult = vbOK Then
                Grilla_Detalle.Rows.Clear()
                nom.Focus()
                nom.Select()
                nom.Clear()
                Agregue_Productos.Clear()
                Agregue_Productos.Enabled = False
                Agregue_Productos.ReadOnly = True
                guardarda.Enabled = False
                MsgBox("La Limpieza a Sido Exitosa", vbInformation, "Limpieza Exitosa")
            Else
                MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
                nom.Focus()
                nom.Select()
                nom.Clear()
                Agregue_Productos.Clear()
                Agregue_Productos.Enabled = False
                Agregue_Productos.ReadOnly = True
            End If
        End If
        nom.Focus()
        nom.Select()
        nom.Clear()
        Agregue_Productos.Clear()
        Agregue_Productos.Enabled = False
        Agregue_Productos.ReadOnly = True
        If Me.Grilla_Detalle.Rows.Count = 0 Then
            can.Enabled = False
        End If
    End Sub
    Private Sub Agregue_Productos_TextChanged(sender As Object, e As EventArgs) Handles Agregue_Productos.TextChanged
        Dim i As Integer
        Agregue_Productos.Text = StrConv(Agregue_Productos.Text, VbStrConv.ProperCase)
        i = Len(Agregue_Productos.Text)
        Agregue_Productos.SelectionStart = i

        If (Agregue_Productos.Text = "") Then
            ingreso.Enabled = False
        Else
            Consulta10("Call Nombre_Buscar ('" & (Agregue_Productos.Text) & "')")
            If DS10.Tables(DT10.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT10.Rows(0)
                ingreso.Enabled = True
            Else
                ingreso.Enabled = False
            End If
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If Me.Grilla_Detalle.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Para Eliminar, Asegurese de Ingresar y Seleccionar Uno", vbCritical, "Error Fatal, Grilla Vacia")
            nom.Focus()
            nom.Select()
            nom.Clear()
            Agregue_Productos.Clear()
            Agregue_Productos.Enabled = False
            Agregue_Productos.ReadOnly = True
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Deseas Eliminar la Fila del Producto o Articulo Seleccionado?", vbOKCancel + vbQuestion, "Eliminar Fila Seleccionada")
            If (valormensaje = vbOK) Then
                Dim loFila As DataGridViewRow = Me.Grilla_Detalle.CurrentRow()
                Grilla_Detalle.Rows.Remove(loFila)
                nom.Focus()
                nom.Select()
                nom.Clear()
                Agregue_Productos.Clear()
                Agregue_Productos.Enabled = False
                Agregue_Productos.ReadOnly = True
            Else
                MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
                nom.Focus()
                nom.Select()
                nom.Clear()
                Agregue_Productos.Clear()
                Agregue_Productos.Enabled = False
                Agregue_Productos.ReadOnly = True
            End If
        End If
        If Me.Grilla_Detalle.Rows.Count = 0 Then
            can.Enabled = False
            guardarda.Enabled = False
        End If
        nom.Focus()
        nom.Select()
        nom.Clear()
        Agregue_Productos.Clear()
        Agregue_Productos.Enabled = False
        Agregue_Productos.ReadOnly = True
    End Sub
    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles nom.TextChanged
        Dim i As Integer
        nom.Text = StrConv(nom.Text, VbStrConv.ProperCase)
        i = Len(nom.Text)
        nom.SelectionStart = i
        If (nom.Text = "") Then
            ruteeees.Text = Nothing
            depa.Text = Nothing
            Agregue_Productos.Enabled = False
            Agregue_Productos.ReadOnly = True
        Else
            Consulta10("Call Despliegue_Desdenombre('" & (nom.Text) & "')")
            If DS10.Tables(DT10.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT10.Rows(0)
                ruteeees.Text = CStr(row("Rut"))
                depa.Text = CStr(row("Departamento"))
                Agregue_Productos.Enabled = True
                Agregue_Productos.ReadOnly = False
                Agregue_Productos.Focus()
                Agregue_Productos.Select()
            Else
                ruteeees.Text = Nothing
                depa.Text = Nothing
                Agregue_Productos.Enabled = False
                Agregue_Productos.ReadOnly = True
            End If
        End If
    End Sub
    Private Sub ingreso_Click(sender As Object, e As EventArgs) Handles ingreso.Click
        If (des.Text = "" And Label2.Text = "Producto:") Then
            MsgBox("Error: No ha Descrito una Descripcion para el Producto, Para que se Usara Por Ejemplo, Etc", vbCritical, "Error, No Hay Descripcion")
            des.Focus()
            des.Select()
            can.Enabled = False
        Else
            Consulta09("Call Nombre_Buscar ('" & (Agregue_Productos.Text) & "')")
            If DS09.Tables(DT09.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT09.Rows(0)
                Grilla_Detalle.Rows.Add("1", row("Codigo"), row("Nombre_Producto"), ruteeees.Text, nom.Text, depa.Text, "1", des.Text)
                Me.Grilla_Detalle.CurrentCell = Me.Grilla_Detalle.Rows(Me.Grilla_Detalle.RowCount - 1).Cells(0)
                Me.Grilla_Detalle.Refresh()
                can.Enabled = True
                nom.Clear()
                guardarda.Enabled = True
                Agregue_Productos.Clear()
                des.Clear()
                nom.Focus()
                nom.Select()
            End If
        End If
    End Sub
    Private Sub Bodega_User_Modo_Detallado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nom.Focus()
        nom.Select()
    End Sub
    Private Sub can_Click(sender As Object, e As EventArgs) Handles can.Click
        Agregue_Productos.Enabled = True
        Agregue_Productos.ReadOnly = False
        Agregue_Productos.Focus()
        Agregue_Productos.Select()
        des.Enabled = False
        des.ReadOnly = True
        nom.Enabled = False
        nom.ReadOnly = True
        borratodo.Enabled = False
        eliminar.Enabled = False
        guardarda.Enabled = False
        Label2.Text = "Cantidad:"
        can.Text = "Modificar Cant."
        Agregue_Productos.TextAlign = 2
        conta += 1
        If ingreso.Enabled = False And can.Text = "Modificar Cant." And Label2.Text = "Cantidad:" Then
            Agregue_Productos.MaxLength = 5
        End If
        If Agregue_Productos.Text = "" And conta > 1 Then
            MsgBox("Error: No Es Posible Agregar la Cantidad Si No La A Especificado", vbCritical, "Error, Cantidad No Especifica")
            Agregue_Productos.Focus()
            Agregue_Productos.Select()
        ElseIf Label2.Text = "Cantidad:" And can.Text = "Modificar Cant." And (Len(Agregue_Productos.Text) > 0)
            Dim row1 As DataGridViewRow = Me.Grilla_Detalle.CurrentRow()
            row1.Cells(6).Value = Agregue_Productos.Text
            Agregue_Productos.Clear()
            Agregue_Productos.Focus()
            Label2.Text = "Producto:"
            Agregue_Productos.TextAlign = 0
            can.Enabled = True
            ingreso.Enabled = False
            Agregue_Productos.Enabled = False
            Agregue_Productos.ReadOnly = True
            nom.Enabled = True
            conta = 0
            nom.ReadOnly = False
            guardarda.Enabled = True
            borratodo.Enabled = True
            eliminar.Enabled = True
            des.ReadOnly = False
            des.Enabled = True
            can.Text = "Cantidad"
            nom.Focus()
            nom.Select()
            Agregue_Productos.MaxLength = 45
        End If
    End Sub
    Private Sub Agregue_Productos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Agregue_Productos.KeyPress
        If ingreso.Enabled = False And can.Text = "Modificar Cant." And Label2.Text = "Cantidad:" Then
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
                e.Handled = True
            End If
        ElseIf nom.Enabled = True And can.Text = "Cantidad;" And Label2.Text = "Producto:"
            If Char.IsNumber(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSymbol(e.KeyChar) Then
                e.Handled = False
            End If
        End If
    End Sub
    Private Sub Bodega_User_Modo_Detallado_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If (Len(nom.Text) > 0) Then
            can.Enabled = False
        ElseIf (Len(nom.Text) = 0)
            can.Enabled = True
        End If
        If (Me.Grilla_Detalle.Rows.Count = 0) Then
            can.Enabled = False
        End If
    End Sub
    Private Sub Grilla_Detalle_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Detalle.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
End Class