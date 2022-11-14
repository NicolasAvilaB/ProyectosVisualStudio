Public Class Form1
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim cadena, cadena_transformada, prueba As String
    Dim nodos, aristas, nodos_pred, comprobar_codigo, comprobar_linea, contar_if, progreso As Integer
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        TextBox1.Clear()
        txt_arisMenoN.Text = "0"
        txt_aristas.Text = "0"
        txt_cnp.Text = "0"
        txt_nodos.Text = "0"
        txt_nopre.Text = "0"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nodos = 0
        aristas = -1
        nodos_pred = 0
    End Sub
    Sub buscar_inicio_final_de_linea()
        nodos = 0
        Dim s As String = TextBox1.Text
        Dim parts As String() = s.Split(New Char() {"" & vbCrLf & ""})
        Dim part As String
        Dim k As Boolean
        Dim nro_caracteres As Integer
        Dim var_inicio, var_final As Integer
        k = True
        If TextBox1.Text <> "" Then
            For Each part In parts
                If k = True Then
                    cadena_transformada = cadena_transformada & part.Length + 1 & ","
                    nro_caracteres = part.Length + 1
                    k = False
                    buscar_linea(0, part.Length, part)
                    var_final = part.Length
                Else
                    cadena_transformada = cadena_transformada & part.Length & ","
                    nro_caracteres = part.Length
                    var_inicio = var_final + 1
                    var_final = var_final + part.Length
                    buscar_linea(var_inicio, var_final, part)
                End If
            Next
        Else
            MsgBox("El campo se encuentra vacio", MsgBoxStyle.Information, "Escriba Codigo Porfavor")
        End If
        If comprobar_codigo = 0 Then
            If TextBox1.Lines.Count <= 0 Then
            Else
                TextBox1.Clear()
                txt_arisMenoN.Text = "0"
                txt_aristas.Text = "0"
                txt_cnp.Text = "0"
                txt_nodos.Text = "0"
                txt_nopre.Text = "0"
                MsgBox("Error: Escriba un Codigo Valido", vbCritical, "Error, Escriba el Codigo")
            End If
        End If
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
    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        If mover Then
            ' establecer la nueva posición  
            Me.Location = New Point((Me.Left + e.X - x), (Me.Top + e.Y - y))
        End If
    End Sub
    Private Sub Label5_MouseUp(sender As Object, e As MouseEventArgs) Handles Label5.MouseUp
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
    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        contar_if = 0
        nodos = 0
        aristas = 0
        nodos_pred = 0
        comprobar_codigo = 0
        buscar_inicio_final_de_linea()
        If TextBox1.Lines.Count > 0 Then
            txt_nodos.Text = nodos
            txt_aristas.Text = aristas
            txt_nopre.Text = nodos_pred
            txt_arisMenoN.Text = (aristas - nodos + 2)
            txt_cnp.Text = nodos_pred + 1
        Else
            TextBox1.Clear()
            txt_arisMenoN.Text = "0"
            txt_aristas.Text = "0"
            txt_cnp.Text = "0"
            txt_nodos.Text = "0"
            txt_nopre.Text = "0"
        End If
    End Sub
    Sub buscar_linea(ByVal inicio As Integer, ByVal final As Integer, ByVal cadenilla As String)
        comprobar_linea = 0
        If cadenilla <> "" Then
            If Len(cadenilla) > 1 Then
                If final - inicio > 3 Then
                    For n As Integer = 0 To (final - inicio) - 3
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2)
                        If prueba = "If " Or prueba = "if " Then
                            nodos = nodos + 1
                            aristas = aristas + 1
                            comprobar_codigo = comprobar_codigo + 1
                            comprobar_linea = comprobar_linea + 1
                            contar_if = contar_if + 1
                            If contar_if > 0 Then
                                nodos_pred = nodos_pred + 1
                            End If
                        End If
                    Next
                End If
                If final - inicio > 4 Then
                    For n As Integer = 0 To (final - inicio) - 4
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2) & cadenilla.Chars(n + 3)
                        If prueba = "For " Or prueba = "for " Then
                            aristas = aristas + 2
                            comprobar_codigo = comprobar_codigo + 1
                            nodos_pred = nodos_pred + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
                If final - inicio > 4 Then
                    For n As Integer = 0 To (final - inicio) - 4
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2) & cadenilla.Chars(n + 3)
                        If prueba = "And " Or prueba = "and " Then
                            nodos = nodos + 1
                            comprobar_codigo = comprobar_codigo + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
                If final - inicio > 4 Then
                    For n As Integer = 0 To (final - inicio) - 4
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2) & cadenilla.Chars(n + 3)
                        If prueba = "&& " Or prueba = "&& " Then
                            nodos = nodos + 1
                            comprobar_codigo = comprobar_codigo + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
                If final - inicio > 4 Then
                    For n As Integer = 0 To (final - inicio) - 4
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2) & cadenilla.Chars(n + 3)
                        If prueba = "Else" Or prueba = "else" Then
                            nodos_pred = nodos_pred + 1
                            aristas = aristas + 2
                            comprobar_codigo = comprobar_codigo + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
                If final - inicio > 6 Then
                    For n As Integer = 0 To (final - inicio) - 6
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2) & cadenilla.Chars(n + 3) & cadenilla.Chars(n + 4) & cadenilla.Chars(n + 5)
                        If prueba = "While" Or prueba = "while" Then
                            aristas = aristas + 1
                            comprobar_codigo = comprobar_codigo + 1
                            nodos_pred = nodos_pred + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
                If final - inicio > 3 Then
                    For n As Integer = 0 To (final - inicio) - 3
                        prueba = cadenilla.Chars(n) & cadenilla.Chars(n + 1) & cadenilla.Chars(n + 2)
                        If prueba = "Or" Or prueba = "or" Then
                            nodos = nodos + 1
                            comprobar_codigo = comprobar_codigo + 1
                            comprobar_linea = comprobar_linea + 1
                        End If
                    Next
                End If
            End If
            If comprobar_linea = 0 Then
                nodos = nodos + 1
                aristas = aristas + 1
            End If
        End If
    End Sub
End Class
