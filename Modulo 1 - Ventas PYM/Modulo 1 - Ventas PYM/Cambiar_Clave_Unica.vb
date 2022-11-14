Public Class Cambiar_Clave_Unica
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
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
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        clave1.Clear()
        clave2.Clear()
        clave1.PasswordChar = "●"
        clave2.PasswordChar = "●"
        ver1.Text = "●"
        ver2.Text = "●"
        Close()
    End Sub
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ver1.Click
        If clave1.Text = "" Then
            MsgBox("Error: No has ingresado tu clave antigua", vbCritical, "Error Clave Antigua Vacia")
            clave1.Focus()
            clave1.Select()
        ElseIf ver1.Text = "●" Then
            clave1.PasswordChar = ""
            ver1.Text = "Ø"
        Else
            clave1.PasswordChar = "●"
            ver1.Text = "●"
            '•
        End If
    End Sub

    Private Sub ver2_Click(sender As Object, e As EventArgs) Handles ver2.Click
        If clave2.Text = "" Then
            MsgBox("Error: No has ingresado tu clave nueva", vbCritical, "Error Clave Nueva Vacia")
            clave2.Focus()
            clave2.Select()
        ElseIf ver2.Text = "●" Then
            clave2.PasswordChar = ""
            ver2.Text = "Ø"
        Else
            clave2.PasswordChar = "●"
            ver2.Text = "●"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        clave1.Clear()
        clave2.Clear()
        clave1.PasswordChar = "●"
        clave2.PasswordChar = "●"
        ver1.Text = "●"
        ver2.Text = "●"
        Close()
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If (Len(clave2.Text) < 4) Then
            MsgBox("Su clave nueva debe contener minimo 4 letras o numeros", vbExclamation, "Minimos Letras o Numeros")
            clave2.Clear()
            clave2.Focus()
            clave2.Select()
        ElseIf (clave2.Text = clave1.Text) Then
            MsgBox("Su clave nueva es la misma que la clave antigua", vbExclamation, "Clave Repetida")
            clave2.Clear()
            clave2.Focus()
            clave2.Select()
        Else
            Consulta7("Call Verifica_Clave_Antigua('" & (clave1.Text) & "')")
            If (DS7.Tables(DT7.TableName).Rows.Count > 0) Then
                Dim row As DataRow = DT7.Rows(0)
                Dim iddd As Integer = CStr(row("ID"))
                Try
                    Comprobador_Modificador.Show()
                    Consulta7("Call Modificar_Clave_Unica('" & (clave2.Text) & "'," & (iddd) & ")")
                    Comprobador_Modificador.Close()
                    MsgBox("Su clave unica a sido modificada exitosamente", vbInformation, "Clave Unica Modificada")
                    clave1.Clear()
                    clave2.Clear()
                    Close()
                Catch ex As Exception
                    Dim a As String = Convert.ToString(ex)
                    MsgBox(a, vbExclamation, "Advertencia, Posible Error")
                End Try
            Else
                MsgBox("Error: Su clave antigua es incorrecta", vbCritical, "Error, Clave Antigua Invalida")
                clave1.Clear()
                clave1.Focus()
                clave1.Select()
            End If
        End If
    End Sub
    Private Sub cerrar_MouseMove(sender As Object, e As MouseEventArgs) Handles cerrar.MouseMove
        cerrar.BackColor = Color.FromArgb(237, 237, 237)
        cerrar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub cerrar_MouseLeave(sender As Object, e As EventArgs) Handles cerrar.MouseLeave
        cerrar.BackColor = Color.FromArgb(29, 49, 74)
        cerrar.ForeColor = Color.White
    End Sub
    Private Sub guardar_MouseMove(sender As Object, e As MouseEventArgs) Handles guardar.MouseMove
        guardar.BackColor = Color.FromArgb(237, 237, 237)
        guardar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub guardar_MouseLeave(sender As Object, e As EventArgs) Handles guardar.MouseLeave
        guardar.BackColor = Color.FromArgb(9, 29, 54)
        guardar.ForeColor = Color.White
    End Sub
    Private Sub cancelar_MouseMove(sender As Object, e As MouseEventArgs) Handles cancelar.MouseMove
        cancelar.BackColor = Color.FromArgb(237, 237, 237)
        cancelar.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub cancelar_MouseLeave(sender As Object, e As EventArgs) Handles cancelar.MouseLeave
        cancelar.BackColor = Color.FromArgb(9, 29, 54)
        cancelar.ForeColor = Color.White
    End Sub
    Private Sub minimizar_MouseMove(sender As Object, e As MouseEventArgs) Handles minimizar.MouseMove
        minimizar.BackColor = Color.FromArgb(237, 237, 237)
        minimizar.ForeColor = Color.FromArgb(29, 49, 74)
    End Sub
    Private Sub minimizar_MouseLeave(sender As Object, e As EventArgs) Handles minimizar.MouseLeave
        minimizar.BackColor = Color.FromArgb(29, 49, 74)
        minimizar.ForeColor = Color.White
    End Sub
    Private Sub ver1_MouseMove(sender As Object, e As MouseEventArgs) Handles ver1.MouseMove
        ver1.BackColor = Color.FromArgb(237, 237, 237)
        ver1.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub ver1_MouseLeave(sender As Object, e As EventArgs) Handles ver1.MouseLeave
        ver1.BackColor = Color.FromArgb(9, 29, 54)
        ver1.ForeColor = Color.White
    End Sub
    Private Sub ver2_MouseMove(sender As Object, e As MouseEventArgs) Handles ver2.MouseMove
        ver2.BackColor = Color.FromArgb(237, 237, 237)
        ver2.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub ver2_MouseLeave(sender As Object, e As EventArgs) Handles ver2.MouseLeave
        ver2.BackColor = Color.FromArgb(9, 29, 54)
        ver2.ForeColor = Color.White
    End Sub
    Private Sub Cambiar_Clave_Unica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clave_Modificar.status.Visible = False
        clave1.Focus()
        clave1.Select()
    End Sub
End Class