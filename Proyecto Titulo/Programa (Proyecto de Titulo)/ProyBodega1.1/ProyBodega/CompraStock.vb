Public Class CompraStock
    Dim Dato00, Dato11, Dato22, Dato33 As String
    Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
    Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
    Dim i As String
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
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
    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel2.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
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
    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles vuo.Click
        Me.Close()
    End Sub
    Private Sub CompraStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_ar.Text = ""
        cd_ar.Clear()
        nm_ar.Clear()
        cn_a.Clear()
        n_can.Clear()
        n_can.Focus()
        n_can.Select()
        Dato00 = Reponer_Stock.Grilla_Stock.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Dato11 = Reponer_Stock.Grilla_Stock.CurrentRow.Cells(1).EditedFormattedValue.ToString
        Dato22 = Reponer_Stock.Grilla_Stock.CurrentRow.Cells(2).EditedFormattedValue.ToString
        Dato33 = Reponer_Stock.Grilla_Stock.CurrentRow.Cells(6).EditedFormattedValue.ToString
        id_ar.Text = Dato00
        cd_ar.Text = Dato11
        nm_ar.Text = Dato22
        cn_a.Text = Dato33
    End Sub
    Private Sub n_can_TextChanged(sender As Object, e As EventArgs) Handles n_can.TextChanged
        If (n_can.Text = "") Then
            gr.Enabled = False
        Else
            gr.Enabled = True
        End If
    End Sub
    Private Sub gr_Click(sender As Object, e As EventArgs) Handles gr.Click
        Consulta7("Call GeneradorIDautomatico11")
        If TypeOf (DS7.Tables(DT7.TableName).Rows(0).Item("ID")) Is DBNull Then
            i = 1
        Else
            i = DS7.Tables(DT7.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        If (n_can.Text = "0") Then
            MsgBox("Error: No Puedes Indicar una Cantidad 0, Indica Otra Cantidad", vbCritical, "Error, Cantidad No Puede ser 0")
            n_can.Clear()
            n_can.Focus()
        Else
            Consulta7("Call CompraStock('" & (n_can.Text) & "','" & (nm_ar.Text) & "')")
            Consulta7("Call GrabarHistorial_Modificacion_Stock('" & (i) & "','" & (id_ar.Text) & "','" & (cd_ar.Text) & "','" & (nm_ar.Text) & "','" & (Principal.nombre.Text) & "','" & (n_can.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "')")
            MsgBox("Cantidad Repuesta y/o Modificada Correctamente", vbInformation, "Guardado Stock")
            Reponer_Stock.Actualizar_Tabla()
            Reponer_Stock.Mostrar_Grilla()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub n_can_KeyPress(sender As Object, e As KeyPressEventArgs) Handles n_can.KeyPress
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
End Class