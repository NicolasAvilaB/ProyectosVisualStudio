Public Class Devolver_Articulo
    Dim Dato1, Dato2, Dato3, Dato4, Dato5, Dato6, Dato7 As String
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Private Sub devuelta_Click(sender As Object, e As EventArgs) Handles devuelta.Click
        despliegue.Text = "Ver Grilla ->"
        Me.Close()
        articode.Clear()
        ruut.Clear()
        departamen.Clear()
        cantided.Clear()
        busque_code_arti.Enabled = False
        busque_code_arti.ReadOnly = True
        Bodega_User.Actualizacion_Tabla()
        Bodega_User.Mostrar_Grilla()
        Bodega_User.Mostrar()
    End Sub
    Private Sub despliegue_Click(sender As Object, e As EventArgs) Handles despliegue.Click
        If (despliegue.Text = "Ver Grilla ->") Then
            Me.Width = 1097
            Mostrar()
            despliegue.Text = "Ocultar Grilla <-"
            busque_code_arti.Enabled = True
            busque_code_arti.ReadOnly = False
        Else
            despliegue.Text = "Ver Grilla ->"
            Me.Width = 497
            articode.Clear()
            ruut.Clear()
            departamen.Clear()
            cantided.Clear()
            busque_code_arti.Enabled = False
            busque_code_arti.ReadOnly = True
        End If
    End Sub
    Private Sub Devolver_Articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Me.Width = 497
    End Sub
    Private Sub devolver_Click(sender As Object, e As EventArgs) Handles devolver.Click
        If Me.Grilla_Devolucion.Rows.Count = 0 Then
            MsgBox("Error: No hay Articulos existentes a Devolver", vbCritical, "Error, No hay Articulos")
        Else
            Dim valormensaje As Integer
            valormensaje = MsgBox("¿Desea Devolver a Stock el Codigo: " + articode.Text + " De Articulo ?", vbYesNo + vbQuestion, "¿Devolver a Stock?")
            If valormensaje = vbYes And devolver.Text = "Devolución" Then
                busque_code_arti.Enabled = False
                busque_code_arti.ReadOnly = True
                CD_DEVO.Enabled = True
                CD_DEVO.ReadOnly = False
                CD_DEVO.Focus()
                CD_DEVO.Select()
                Acept.Enabled = True
                Acept.Visible = True
                devolver.Enabled = False
                devolver.Visible = False
                Grilla_Devolucion.ReadOnly = True
                Grilla_Devolucion.Enabled = False
            Else
                MsgBox("Se Ha Cancelado la Operacion", vbExclamation, "Operacion Cancelada")
                devolver.Focus()
                devolver.Select()
            End If
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        despliegue.Text = "Ver Grilla ->"
        Me.Width = 497
        articode.Clear()
        ruut.Clear()
        departamen.Clear()
        cantided.Clear()
        busque_code_arti.Enabled = False
        busque_code_arti.ReadOnly = True
        CD_DEVO.Clear()
        Acept.Visible = False
        Acept.Enabled = False
        devolver.Visible = True
        devolver.Enabled = True
        CD_DEVO.Enabled = False
        CD_DEVO.ReadOnly = True
        Grilla_Devolucion.ReadOnly = False
        Grilla_Devolucion.Enabled = True
    End Sub
    Private Sub busque_code_arti_TextChanged(sender As Object, e As EventArgs) Handles busque_code_arti.TextChanged
        If (busque_code_arti.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta3("Call Buscar_Devolucion ('" & (busque_code_arti.Text) & "')")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Grilla_Devolucion.DataSource = DS3.Tables(DT3.TableName)
                Mostrar()
            Else
                articode.Clear()
                ruut.Clear()
                departamen.Clear()
                cantided.Clear()
            End If
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub
    Private Sub history_Click(sender As Object, e As EventArgs) Handles history.Click
        Historial_Bodega.Owner = Me
        Historial_Bodega.ShowDialog()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta3("Call Grilla_Devolucion")
    End Sub
    Sub Mostrar()
        If (DS3.Tables(DT3.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Devolucion.CurrentRow.Cells(0).EditedFormattedValue.ToString
            Dato2 = Grilla_Devolucion.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato3 = Grilla_Devolucion.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato4 = Grilla_Devolucion.CurrentRow.Cells(3).EditedFormattedValue.ToString
            Dato5 = Grilla_Devolucion.CurrentRow.Cells(4).EditedFormattedValue.ToString
            articode.Text = Dato1
            ruut.Text = Dato2
            departamen.Text = Dato3
            cantided.Text = Dato4
        Else
            articode.Clear()
            ruut.Clear()
            departamen.Clear()
            cantided.Clear()
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Devolucion.DataSource = DS3.Tables(DT3.TableName)
        Conexion.Close()
    End Sub
    Private Sub Grilla_Devolucion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Devolucion.CellClick
        Mostrar()
    End Sub
    Private Sub Devolver_Articulo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        despliegue.Text = "Ver Grilla ->"
        articode.Clear()
        ruut.Clear()
        departamen.Clear()
        cantided.Clear()
        busque_code_arti.Enabled = False
        busque_code_arti.ReadOnly = True
        Bodega_User.Actualizacion_Tabla()
        Bodega_User.Mostrar_Grilla()
        Bodega_User.Mostrar()
    End Sub
    Private Sub articode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles articode.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub ruut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ruut.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub cantided_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantided.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub busque_code_arti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busque_code_arti.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Error: Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub
    Private Sub Grilla_Devolucion_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Devolucion.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Acept.Click
        Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        If (CD_DEVO.Text = "") Then
            MsgBox("Error: Digite el Codigo Correspondiente a la Devolucion", vbCritical, "Error de Campo Vacio")
            CD_DEVO.Focus()
            CD_DEVO.Select()
        Else
            Consulta3("Call Verifica_Codig ('" & (CD_DEVO.Text) & "','" & (articode.Text) & "','" & (ruut.Text) & "')")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                Try
                    Consulta3("Call Devolucion_Stock ('" & (cantided.Text) & "','" & (articode.Text) & "')")
                    Consulta3("Call Ingreso_Historial ('" & (articode.Text) & "','" & (ruut.Text) & "','" & (departamen.Text) & "','" & (cantided.Text) & "','" & (mifecha2) & "','" & (Now.ToLongTimeString) & "')")
                    Consulta3("Call Eliminar_Prestado ('" & (ruut.Text) & "','" & (articode.Text) & "','" & (Dato5) & "')")
                    Consulta3("Call Borrar_Codigo('" & (CD_DEVO.Text) & "','" & (articode.Text) & "','" & (ruut.Text) & "')")
                Catch ex As Exception
                    DA3.SelectCommand = SC3
                    DA3.Fill(DT3)
                End Try
                MsgBox("Stock Repuesto Satisfactoriamente", vbInformation, "Stock Repuesto")
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
                CD_DEVO.Clear()
                Acept.Visible = False
                Acept.Enabled = False
                devolver.Visible = True
                devolver.Enabled = True
                CD_DEVO.Enabled = False
                CD_DEVO.ReadOnly = True
                Grilla_Devolucion.ReadOnly = False
                Grilla_Devolucion.Enabled = True
            Else
                Actualizacion_Tabla()
                Mostrar_Grilla()
                MsgBox("Error: No se ha Encontrado el Codigo Especifico", vbCritical, "Error de Codigo")
                CD_DEVO.Clear()
                CD_DEVO.Focus()
                CD_DEVO.Select()
            End If
        End If
    End Sub
    Private Sub CD_DEVO_TextChanged(sender As Object, e As EventArgs) Handles CD_DEVO.TextChanged
        If (CD_DEVO.Text = "'") Then
            CD_DEVO.Focus()
            CD_DEVO.Select()
            SendKeys.Send("{BACKSPACE}")
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
    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Label6.MouseDown
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
    Private Sub Label6_MouseMove(sender As Object, e As MouseEventArgs) Handles Label6.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label6_MouseUp(sender As Object, e As MouseEventArgs) Handles Label6.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
End Class