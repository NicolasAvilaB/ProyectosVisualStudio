Public Class Traspaso_Datos
    Dim va As Integer = 0
    Dim va2 As Integer = 0
    Dim a As Integer
    Dim b As Integer
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim d1, d2, d3, d4
    Dim i As Integer
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
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
        ' reestablecer  
        mover = False
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
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
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.White
        cerrar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(98, 117, 127)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.White
        minimizar.ForeColor = Color.FromArgb(98, 117, 127)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(98, 117, 127)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        If (fcc.Text = "" And fcc.Enabled = True) Then
            Advertencia.texto.Text = "Seleccione valor final o crece"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            fcc.Focus()
            fcc.Select()
        ElseIf (anc.Text = "")
            Advertencia.texto.Text = "Valor de anchura vacio"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            anc.Focus()
            anc.Select()
        ElseIf (alt.Text = "")
            Advertencia.texto.Text = "Valor de altura vacio"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            alt.Focus()
            alt.Select()
        ElseIf (lm.Text = "")
            Advertencia.texto.Text = "Seleccione un tipo de lama"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            lm.Focus()
            lm.Select()
        ElseIf (col.Text = "")
            Advertencia.texto.Text = "Seleccione un color de persiana"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            col.Focus()
            col.Select()
        ElseIf (Len(anc.Text) < 4)
            Advertencia.texto.Text = "Valor de ancho no valido"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            anc.Focus()
            anc.Select()
        ElseIf (Len(alt.Text) < 4)
            Advertencia.texto.Text = "Valor de alto no valido"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            alt.Focus()
            alt.Select()
        Else
            Carga_Datos.Show()
            Dim i As Integer
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(0).Value = fcc.Text
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(1).Value = n.Text
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(2).Value = anc.Text
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(3).Value = alt.Text
            If (fcc.Text = "F") Then
                If (anc.Text < "1000") Then
                    redondeo1_ancho_bajo_1000()
                Else
                    redondeo1_ancho()
                End If
                If (alt.Text < "1000") Then
                    redondeo1_alto_bajo_1000()
                Else
                    redondeo1_alto()
                End If
            ElseIf (fcc.Text = "C")
                If (a < "1000") Then
                    redondeo1_ancho_crece_bajo_1000()
                Else
                    redondeo1_ancho_crece()
                End If
                If (b < "1000") Then
                    redondeo1_alto_crece_bajo_1000()
                Else
                    redondeo1_alto_crece()
                End If
            End If
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(6).Value = lm.Text
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(7).Value = col.Text
            Cotizador.Timer1.Start()
            Cotizador.Timer1.Interval = 10
            fcc.Enabled = False
            fcc.SelectedIndex = -1
            n.Text = "1"
            anc.Text = ""
            alt.Text = ""
            lm.SelectedIndex = -1
            col.SelectedIndex = -1
            va = 0
            va2 = 0
            Carga_Datos.Close()
            Close()
        End If
    End Sub
    Sub redondeo1_ancho()
        d1 = Val(Mid(anc.Text, 1, 1))
        d2 = Val(Mid(anc.Text, 2, 1))
        d3 = Val(Mid(anc.Text, 3, 1))
        d4 = Val(Mid(anc.Text, 4, 1))
        If (d3 = 0 And d4 >= 1) Then
            anc.Text = d1 & d2 & d3 + 6 & d4
        ElseIf (d3 = 1)
            anc.Text = d1 & d2 & d3 + 5 & d4
        ElseIf (d3 = 2)
            anc.Text = d1 & d2 & d3 + 4 & d4
        ElseIf (d3 = 3)
            anc.Text = d1 & d2 & d3 + 3 & d4
        ElseIf (d3 = 4)
            anc.Text = d1 & d2 & d3 + 2 & d4
        ElseIf (d3 = 5)
            anc.Text = d1 & d2 & d3 + 1 & d4
        End If
        Dim numeroARedondear As Integer = anc.Text
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(4).Value = resultado
    End Sub
    Sub redondeo1_alto()
        d1 = Val(Mid(alt.Text, 1, 1))
        d2 = Val(Mid(alt.Text, 2, 1))
        d3 = Val(Mid(alt.Text, 3, 1))
        d4 = Val(Mid(alt.Text, 4, 1))
        If (d3 = 0 And d4 >= 1) Then
            alt.Text = d1 & d2 & d3 + 6 & d4
        ElseIf (d3 = 1)
            alt.Text = d1 & d2 & d3 + 5 & d4
        ElseIf (d3 = 2)
            alt.Text = d1 & d2 & d3 + 4 & d4
        ElseIf (d3 = 3)
            alt.Text = d1 & d2 & d3 + 3 & d4
        ElseIf (d3 = 4)
            alt.Text = d1 & d2 & d3 + 2 & d4
        ElseIf (d3 = 5)
            alt.Text = d1 & d2 & d3 + 1 & d4
        End If
        Dim numeroARedondear As Integer = alt.Text
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(5).Value = resultado
    End Sub
    Sub redondeo1_ancho_crece()
        d1 = Val(Mid(a, 1, 1))
        d2 = Val(Mid(a, 2, 1))
        d3 = Val(Mid(a, 3, 1))
        d4 = Val(Mid(a, 4, 1))
        If (d3 = 0 And d4 >= 1) Then
            a = d1 & d2 & d3 + 6 & d4
        ElseIf (d3 = 1)
            a = d1 & d2 & d3 + 5 & d4
        ElseIf (d3 = 2)
            a = d1 & d2 & d3 + 4 & d4
        ElseIf (d3 = 3)
            a = d1 & d2 & d3 + 3 & d4
        ElseIf (d3 = 4)
            a = d1 & d2 & d3 + 2 & d4
        ElseIf (d3 = 5)
            a = d1 & d2 & d3 + 1 & d4
        End If
        Dim numeroARedondear As Integer = a
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(4).Value = resultado
    End Sub
    Sub redondeo1_alto_crece()
        d1 = Val(Mid(b, 1, 1))
        d2 = Val(Mid(b, 2, 1))
        d3 = Val(Mid(b, 3, 1))
        d4 = Val(Mid(b, 4, 1))
        If (d3 = 0 And d4 >= 1) Then
            b = d1 & d2 & d3 + 6 & d4
        ElseIf (d3 = 1)
            b = d1 & d2 & d3 + 5 & d4
        ElseIf (d3 = 2)
            b = d1 & d2 & d3 + 4 & d4
        ElseIf (d3 = 3)
            b = d1 & d2 & d3 + 3 & d4
        ElseIf (d3 = 4)
            b = d1 & d2 & d3 + 2 & d4
        ElseIf (d3 = 5)
            b = d1 & d2 & d3 + 1 & d4
        End If
        Dim numeroARedondear As Integer = b
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(5).Value = resultado
    End Sub
    Sub redondeo1_ancho_crece_bajo_1000()
        d1 = Val(Mid(a, 1, 1))
        d2 = Val(Mid(a, 2, 1))
        d3 = Val(Mid(a, 3, 1))
        If (d2 = 0 And d3 >= 1) Then
            a = d1 & d2 + 6 & d3
        ElseIf (d2 = 1)
            a = d1 & d2 + 5 & d3
        ElseIf (d2 = 2)
            a = d1 & d2 + 4 & d3
        ElseIf (d2 = 3)
            a = d1 & d2 + 3 & d3
        ElseIf (d2 = 4)
            a = d1 & d2 + 2 & d3
        ElseIf (d2 = 5)
            a = d1 & d2 + 1 & d3
        End If
        Dim numeroARedondear As Integer = a
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(4).Value = "0" & resultado
    End Sub
    Sub redondeo1_alto_crece_bajo_1000()
        d1 = Val(Mid(b, 1, 1))
        d2 = Val(Mid(b, 2, 1))
        d3 = Val(Mid(b, 3, 1))
        If (d2 = 0 And d3 >= 1) Then
            b = d1 & d2 + 6 & d3
        ElseIf (d2 = 1)
            b = d1 & d2 + 5 & d3
        ElseIf (d2 = 2)
            b = d1 & d2 + 4 & d3
        ElseIf (d2 = 3)
            b = d1 & d2 + 3 & d3
        ElseIf (d2 = 4)
            b = d1 & d2 + 2 & d3
        ElseIf (d2 = 5)
            b = d1 & d2 + 1 & d3
        End If
        Dim numeroARedondear As Integer = b
        Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
        Cotizador.Tabla_Nota.SelectedRows(i).Cells(5).Value = "0" & resultado
    End Sub
    Sub redondeo1_ancho_bajo_1000()
        Dim valor_ancho As Integer = Convert.ToInt32(anc.Text)
        If (valor_ancho < 100) Then
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(4).Value = "0100"
        ElseIf (valor_ancho >= 100)
            d1 = Val(Mid(valor_ancho, 1, 1))
            d2 = Val(Mid(valor_ancho, 2, 1))
            d3 = Val(Mid(valor_ancho, 3, 1))
            If (d2 = 0 And d3 >= 1) Then
                valor_ancho = d1 & d2 + 6 & d3
            ElseIf (d2 = 1)
                valor_ancho = d1 & d2 + 5 & d3
            ElseIf (d2 = 2)
                valor_ancho = d1 & d2 + 4 & d3
            ElseIf (d2 = 3)
                valor_ancho = d1 & d2 + 3 & d3
            ElseIf (d2 = 4)
                valor_ancho = d1 & d2 + 2 & d3
            ElseIf (d2 = 5)
                valor_ancho = d1 & d2 + 1 & d3
            End If
            Dim numeroARedondear As Integer = valor_ancho
            Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(4).Value = "0" & resultado
        End If
    End Sub
    Sub redondeo1_alto_bajo_1000()
        Dim valor_alto As Integer = Convert.ToInt32(alt.Text)
        If (valor_alto < 100) Then
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(5).Value = "0100"
        ElseIf (valor_alto >= 100)
            d1 = Val(Mid(valor_alto, 1, 1))
            d2 = Val(Mid(valor_alto, 2, 1))
            d3 = Val(Mid(valor_alto, 3, 1))
            If (d2 = 0 And d3 >= 1) Then
                valor_alto = d1 & d2 + 6 & d3
            ElseIf (d2 = 1)
                valor_alto = d1 & d2 + 5 & d3
            ElseIf (d2 = 2)
                valor_alto = d1 & d2 + 4 & d3
            ElseIf (d2 = 3)
                valor_alto = d1 & d2 + 3 & d3
            ElseIf (d2 = 4)
                valor_alto = d1 & d2 + 2 & d3
            ElseIf (d2 = 5)
                valor_alto = d1 & d2 + 1 & d3
            End If
            Dim numeroARedondear As Integer = valor_alto
            Dim resultado As String = Val(Math.Round(numeroARedondear / 100) * 100)
            Cotizador.Tabla_Nota.SelectedRows(i).Cells(5).Value = "0" & resultado
        End If
    End Sub
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
    Private Sub anc_TextChanged(sender As Object, e As EventArgs) Handles anc.TextChanged
        If (anc.Text > "0000" And alt.Text > "0000" And Len(lm.Text) > 1 And Len(col.Text) > 1) Then
            fcc.Enabled = True
        End If
    End Sub
    Private Sub alt_TextChanged(sender As Object, e As EventArgs) Handles alt.TextChanged
        If (anc.Text > "0000" And alt.Text > "0000" And Len(lm.Text) > 1 And Len(col.Text) > 1) Then
            fcc.Enabled = True
        End If
    End Sub
    Private Sub lm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lm.SelectedIndexChanged
        If (anc.Text > "0000" And alt.Text > "0000" And Len(lm.Text) > 1 And Len(col.Text) > 1) Then
            fcc.Enabled = True
        End If
    End Sub
    Private Sub col_SelectedIndexChanged(sender As Object, e As EventArgs) Handles col.SelectedIndexChanged
        If (anc.Text > "0000" And alt.Text > "0000" And Len(lm.Text) > 1 And Len(col.Text) > 1) Then
            fcc.Enabled = True
        End If
    End Sub
    Private Sub Traspaso_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cotizador.Timer1.Stop()
    End Sub
    Private Sub fcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fcc.SelectedIndexChanged
        If (fcc.Text = "C" And lm.Text = "45 MM") Then
            a = Convert.ToInt32(anc.Text) + 150
            b = Convert.ToInt32(alt.Text) + 250
            va = 1
        ElseIf (fcc.Text = "F" And lm.Text = "45 MM" And va = 1)
            a = Convert.ToInt32(anc.Text) - 150
            b = Convert.ToInt32(alt.Text) - 250
            va = 0
        ElseIf (fcc.Text = "C" And lm.Text = "55 MM")
            a = Convert.ToInt32(anc.Text) + 250
            b = Convert.ToInt32(alt.Text) + 350
            va2 = 2
        ElseIf (fcc.Text = "F" And lm.Text = "55 MM" And va2 = 2)
            a = Convert.ToInt32(anc.Text) - 250
            b = Convert.ToInt32(alt.Text) - 350
            va2 = 0
        End If
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub volver_Click(sender As Object, e As EventArgs) Handles volver.Click
        Close()
    End Sub
    Private Sub agregar_MouseMove(sender As Object, e As MouseEventArgs) Handles agregar.MouseMove
        agregar.BackColor = Color.FromArgb(75, 131, 13)
        agregar.ForeColor = Color.White
    End Sub
    Private Sub agregar_MouseLeave(sender As Object, e As EventArgs) Handles agregar.MouseLeave
        agregar.BackColor = Color.White
        agregar.ForeColor = Color.FromArgb(75, 131, 13)
    End Sub
    Private Sub volver_MouseMove(sender As Object, e As MouseEventArgs) Handles volver.MouseMove
        volver.BackColor = Color.FromArgb(75, 131, 13)
        volver.ForeColor = Color.White
    End Sub
    Private Sub volver_MouseLeave(sender As Object, e As EventArgs) Handles volver.MouseLeave
        volver.BackColor = Color.White
        volver.ForeColor = Color.FromArgb(75, 131, 13)
    End Sub
    Private Sub anc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles anc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            Advertencia.texto.Text = "Solo se admite numeros no letras ni espacios"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub alt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alt.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            Advertencia.texto.Text = "Solo se admite numeros no letras ni espacios"
            Advertencia.Owner = Me
            Advertencia.ShowDialog()
            e.Handled = True
        End If
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class