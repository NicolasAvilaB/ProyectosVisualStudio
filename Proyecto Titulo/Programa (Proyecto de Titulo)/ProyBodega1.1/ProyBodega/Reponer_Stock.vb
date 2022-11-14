Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Public Class Reponer_Stock
    Dim Dato1, Dato2, Dato3, Dato4 As String
    Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
    Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
    Dim co, no, ma As String
    Dim i, i2 As String
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Buscar_Articulo_Nom.TextChanged
        Dim i As Integer
        Buscar_Articulo_Nom.Text = StrConv(Buscar_Articulo_Nom.Text, VbStrConv.ProperCase)
        i = Len(Buscar_Articulo_Nom.Text)
        Buscar_Articulo_Nom.SelectionStart = i
        If (Buscar_Articulo_Nom.Text = "") Then
            Guardar.Enabled = False
            Cod.Text = Nothing
            Marc.Text = Nothing
            T_D.Enabled = False
            T_D.SelectedIndex = -1
            N_D.Enabled = False
            N_D.ReadOnly = True
            N_D.Clear()
            Can.Enabled = False
            Can.ReadOnly = True
            Can.Clear()
        Else
            Consulta14("Call Buscador_Articulos_Nombre ('" & (Buscar_Articulo_Nom.Text) & "')")
            If DS14.Tables(DT14.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT14.Rows(0)
                Cod.Text = CStr(row("Codigo"))
                Marc.Text = CStr(row("Marca"))
                Guardar.Enabled = True
                T_D.Enabled = True
                T_D.SelectedIndex = -1
                N_D.Enabled = True
                N_D.ReadOnly = False
                N_D.Clear()
                Can.Enabled = True
                Can.ReadOnly = False
                Can.Clear()
            Else
                Guardar.Enabled = False
                Cod.Text = Nothing
                Marc.Text = Nothing
                T_D.Enabled = False
                T_D.SelectedIndex = -1
                N_D.Enabled = False
                N_D.ReadOnly = True
                N_D.Clear()
                Can.Enabled = False
                Can.ReadOnly = True
                Can.Clear()
            End If
        End If
    End Sub
    Sub Borrar_Grilla()
        Grilla_Stock.DataSource = Nothing
        Conexion.Close()
    End Sub
    Sub Actualizar_Tabla()
        Consulta7("Call Grilla_Validador_Stock")
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Stock.DataSource = DS7.Tables(DT7.TableName)
        Conexion.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Buscar_Articulo_Nom.Clear()
        Me.Close()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (T_D.SelectedIndex = -1) Then
            MsgBox("Error: No Ha Seleccionado Ningun Tipo de Documento, Asegurese de Haberlo Hecho e Intente Nuevamente", vbCritical, "Error de Seleccion Tipo de Documento")
            T_D.Focus()
            T_D.Select()
        ElseIf (N_D.Text = "") Then
            MsgBox("Error: No Ha Digitado Ningun Numero de Documento, Asegurese de Haberlo Hecho e Intente Nuevamente", vbCritical, "Error de Escritura Numero de Documento")
            N_D.Focus()
            N_D.Select()
        ElseIf (Can.Text = "") Then
            MsgBox("Error: No Ha Digitado Ninguna Cantidad Acorde del Producto a Ingresar al Sistema, Asegurese de Haberlo Hecho e Intente Nuevamente", vbCritical, "Error de Escritura Cantidad del Producto")
            Can.Focus()
            Can.Select()
        Else
            If (Me.Grilla_Stock.Rows.Count = 0) Then
                Dato1 = Nothing
                Dato2 = Nothing
            Else
                Dato1 = Grilla_Stock.CurrentRow.Cells(1).EditedFormattedValue.ToString
                Dato2 = Grilla_Stock.CurrentRow.Cells(2).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Stock.Rows
                co = row.Cells(1).Value
                no = row.Cells(2).Value
            Next
            If (co = Cod.Text) Then
                MsgBox("El Codigo : " + Cod.Text + " Ya Existe En El Registro con el Articulo Especificado.", vbCritical, "Error, Codigo Ya Existente")
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
                Buscar_Articulo_Nom.Clear()
            ElseIf (no = Buscar_Articulo_Nom.Text) Then
                MsgBox("El Nombre del Articulo : " + Buscar_Articulo_Nom.Text + " Ya Existe En El Registro.", vbCritical, "Error, Articulo Ya Existente")
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
                Buscar_Articulo_Nom.Clear()
            ElseIf (Dato1 = Cod.Text) Then
                MsgBox("El Codigo Seleccionado : " + Cod.Text + " Ya Existe En El Registro con el Articulo Especificado.", vbCritical, "Error, Codigo Ya Existente")
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
                Buscar_Articulo_Nom.Clear()
            ElseIf (Dato2 = Buscar_Articulo_Nom.Text) Then
                MsgBox("El Nombre del Articulo Seleccionado : " + Buscar_Articulo_Nom.Text + " Ya Existe En El Registro.", vbCritical, "Error, Articulo Ya Existente")
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
                Buscar_Articulo_Nom.Clear()
            Else
                Consulta7("Call GeneradorIDautomatico10")
                If TypeOf (DS7.Tables(DT7.TableName).Rows(0).Item("ID")) Is DBNull Then
                    i = 1
                Else
                    i = DS7.Tables(DT7.TableName).Rows(0).Item("ID") + 1
                    Conexion.Close()
                End If
                Consulta7("Call GeneradorIDautomatico9")
                If TypeOf (DS7.Tables(DT7.TableName).Rows(0).Item("ID")) Is DBNull Then
                    i2 = 1
                Else
                    i2 = DS7.Tables(DT7.TableName).Rows(0).Item("ID") + 1
                    Conexion.Close()
                End If
                Consulta7("Call Insertar_Producto_Validado('" & (i) & "','" & (Cod.Text) & "','" & (Buscar_Articulo_Nom.Text) & "','" & (Marc.Text) & "','" & (T_D.Text) & "','" & (N_D.Text) & "','" & (Can.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                Consulta7("Call Inserto_Entrada('" & (i2) & "','" & (Cod.Text) & "','" & (Buscar_Articulo_Nom.Text) & "','" & (Marc.Text) & "','" & (T_D.Text) & "','" & (N_D.Text) & "','" & (Can.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "','" & "------" & "')")
                MsgBox("Datos Ingresados Correctamente al Sistema", vbInformation, "Ingreso de Datos Existoso")
                Borrar_Grilla()
                Actualizar_Tabla()
                Mostrar_Grilla()
                Buscar_Articulo_Nom.Clear()
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Grilla_Stock_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Stock.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' habilitar el flag  
            mover = True
            ' guardar las coordenadas  
            x = e.X
            y = e.Y
            ' cambiar el cursor del mouse  
            Me.Cursor = Cursors.NoMove2D
        End If
    End Sub
    Private Sub Historial_In_Click(sender As Object, e As EventArgs) Handles Historial_In.Click
        Historial_Stock.Owner = Me
        Historial_Stock.ShowDialog()
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub elimina4_Click(sender As Object, e As EventArgs) Handles elimina4.Click
        If (Me.Grilla_Stock.Rows.Count = 0) Then
            Dato3 = Nothing
            MsgBox("Error: No Existe Ningun Articulo a Eliminar en la Grilla, Asegurese de Agregarlos e Intentelo Denuevo", vbCritical, "Error, Grilla Vacia")
            Buscar_Articulo_Nom.Clear()
            Buscar_Articulo_Nom.Focus()
            Buscar_Articulo_Nom.Select()
        Else
            Dato3 = Grilla_Stock.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato4 = Grilla_Stock.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Eliminar del Registro El Siguiente Codigo: " + Dato3 + " Asociado al Articulo: " + Dato4 + " ?", vbYesNo + vbQuestion, "¿Eliminar Codigo?")
            If valormensaje = vbYes Then
                Consulta7("Call EliminarStock_Completo ('" & (Dato3) & "')")
                Consulta7("Call Modifica_Estado_Articulo ('" & (Dato3) & "')")
                MsgBox("El Codigo: " + Dato3 + " y/o Articulo " + Dato4 + " Se ha Eliminado Exitosamente", vbInformation, "Limpieza Exitosa")
                Borrar_Grilla()
                Actualizar_Tabla()
                Mostrar_Grilla()
                Productos.Actualizacion_Tabla()
                Productos.Mostrar_Grilla()
                Productos.Mostrar()
                Buscar_Articulo_Nom.Clear()
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                Buscar_Articulo_Nom.Clear()
                Buscar_Articulo_Nom.Focus()
                Buscar_Articulo_Nom.Select()
            End If
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Reponer_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar_Tabla()
        Mostrar_Grilla()
        Buscar_Articulo_Nom.Focus()
        Buscar_Articulo_Nom.Select()
    End Sub
    Private Sub informe_stock_Click(sender As Object, e As EventArgs) Handles informe_stock.Click
        Impresion_IngresoStock.Owner = Me
        Impresion_IngresoStock.ShowDialog()
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Reponer_Stock_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Buscar_Articulo_Nom.Clear()
        Productos.codigo.Enabled = False
        Productos.codigo.ReadOnly = True
        Productos.Nombre.Enabled = False
        Productos.Nombre.ReadOnly = True
        Productos.Marca.Enabled = False
        Productos.Marca.ReadOnly = True
        Productos.guardar.Enabled = False
        Productos.nuevo.Enabled = True
        Productos.eliminar.Enabled = True
        Productos.modificar.Enabled = True
        Productos.busqueda_productos.Enabled = True
        Productos.busqueda_productos.ReadOnly = False
        Productos.Grilla_Productos.Enabled = True
        Productos.Grilla_Productos.ReadOnly = True
        Productos.cancelar.Enabled = False
        Productos.codigo.Enabled = False
        Productos.codigo.ReadOnly = True
        Productos.nuevo.Focus()
        Productos.nuevo.Select()
        Productos.Actualizacion_Tabla()
        Productos.Mostrar_Grilla()
        Productos.Mostrar()
        If (Productos.Grilla_Productos.Rows.Count = 0) Then
            Productos.codigo.Clear()
        End If
    End Sub
    Private Sub Can_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Can.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub N_D_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_D.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error, Se permiten solo Numeros")
            e.Handled = True
        End If
    End Sub
    Private Sub Grilla_Stock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Stock.CellDoubleClick
        CompraStock.Owner = Me
        CompraStock.ShowDialog()
    End Sub
    Private Sub Buscar_Articulo_Nom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Buscar_Articulo_Nom.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class