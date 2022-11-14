Imports System.Drawing.Drawing2D
Public Class InicioSesion
    Private Declare Function AnimateWindow Lib "user32" (
    ByVal hwnd As Long,
    ByVal dwTime As Long,
    ByVal dwFlags As Long) As Long
    Private Const AW_ACTIVATE = &H20000 'Activa la ventana cuando finaliza el efecto  
    Private Const AW_BLEND = &H80000
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ret As Long
        ret = AnimateWindow(Me.Handle, 150, AW_BLEND Or AW_ACTIVATE)
        nombre.Focus()
        nombre.Select()
    End Sub
    Sub prcCambiaColorBorde(ByRef _Control As Control, ByVal _Color As Color)
        ' Variables para metodos graficos
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(_Color, 2.0)
        ' Cambia el borde
        g.DrawRectangle(pen, New Rectangle(_Control.Location, _Control.Size))
        ' Libera los recursos
        pen.Dispose()
        g = Nothing
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        'crea el form redondo
        'creamos un objeto de la clase GraphicsPath
        ' Dim figura As GraphicsPath = New GraphicsPath
        'manipulando las variables que se corresponden con los puntos x e y, el ancho y el alto de la figura, podemos variar su aspecto
        'Dim x, y, ancho, alto As Integer
        'anchura y altura de la figura (círculo en este caso)
        'ancho = 663
        'alto = 165
        'posiciones x e y de la figura (centrada en el control PictureBox)
        'x = (Panel2.Width - ancho) / 2
        'y = (Panel2.Height - alto) / 2
        'usamos el método AddEllipse para conseguir la figura de un círculo,
        'que aplicaremos sobre el control PictureBox.
        'figura.AddEllipse(New Rectangle(x, y, ancho, alto))
        'en el control PictureBox creamos una región que se corresponde
        'con la figura del objeto GraphicsPath
        'Panel2.Region = New Region(figura)
        'e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs)
        If (clave.BackColor = Color.FromArgb(9, 29, 54)) Then
            clave.BackColor = Color.White
            clave.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs)
        If (clave.BackColor = Color.White) Then
            clave.BackColor = Color.FromArgb(9, 29, 54)
            clave.ForeColor = Color.White
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Const AW_HIDE = &H10000
        Const AW_BLEND = &H80000
        AnimateWindow(Me.Handle, 150, AW_HIDE Or AW_BLEND)
        Me.Close()
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' If nombre.Focused = True Then 'Cuando el TextBox recibe el Foco Cambia de color el Borde
        'prcCambiaColorBorde(nombre, Color.SteelBlue)
        'Else 'Cuando el TextBox pierde el Foco Vuelve a cambiar el Borde de otro Color
        'prcCambiaColorBorde(nombre, Color.FromArgb(24, 40, 74))
        'End If
        'If clave.Focused = True Then 'Cuando el TextBox recibe el Foco Cambia de color el Borde
        'prcCambiaColorBorde(clave, Color.SteelBlue)
        'Else 'Cuando el TextBox pierde el Foco Vuelve a cambiar el Borde de otro Color
        'prcCambiaColorBorde(clave, Color.FromArgb(24, 40, 74))
        'End If
    End Sub
    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Const AW_HIDE = &H10000
        Const AW_BLEND = &H80000
        AnimateWindow(Me.Handle, 150, AW_HIDE Or AW_BLEND)
        Me.Close()
    End Sub
    Private Sub aceptar_Click(sender As Object, e As EventArgs) Handles aceptar.Click
        Const AW_HIDE = &H10000
        Const AW_BLEND = &H80000
        AnimateWindow(Me.Handle, 150, AW_HIDE Or AW_BLEND)
        nombre.Clear()
        clave.Clear()
        Form2.Show()
    End Sub
    Private Sub ver_Click(sender As Object, e As EventArgs) Handles ver.Click
        If clave.Text = "" Then
            MsgBox("Error: No Existe un Ingreso de Datos en el Campo Clave", vbCritical, "¡Error, Campo Clave Vacio!")
            clave.Focus()
            clave.Select()
        ElseIf ver.Text = "•" Then
            clave.PasswordChar = ""
            ver.Text = "Ø"
        Else
            clave.PasswordChar = "•"
            ver.Text = "•"
        End If
    End Sub
    Private Sub ver_MouseMove(sender As Object, e As MouseEventArgs) Handles ver.MouseMove
        ver.BackColor = Color.White
        ver.ForeColor = Color.Black
    End Sub
    Private Sub ver_MouseLeave(sender As Object, e As EventArgs) Handles ver.MouseLeave
        ver.BackColor = Color.FromArgb(9, 29, 54)
        ver.ForeColor = Color.White
    End Sub
    Private Sub salir_MouseMove(sender As Object, e As MouseEventArgs) Handles salir.MouseMove
        salir.BackColor = Color.White
        salir.ForeColor = Color.Black
    End Sub
    Private Sub salir_MouseLeave(sender As Object, e As EventArgs) Handles salir.MouseLeave
        salir.BackColor = Color.FromArgb(9, 29, 54)
        salir.ForeColor = Color.White
    End Sub
    Private Sub aceptar_MouseMove(sender As Object, e As MouseEventArgs) Handles aceptar.MouseMove
        aceptar.BackColor = Color.White
        aceptar.ForeColor = Color.Black
    End Sub
    Private Sub aceptar_MouseLeave(sender As Object, e As EventArgs) Handles aceptar.MouseLeave
        aceptar.BackColor = Color.FromArgb(9, 29, 54)
        aceptar.ForeColor = Color.White
    End Sub
    Private Sub clave_TextChanged(sender As Object, e As EventArgs) Handles clave.TextChanged
        Consulta("Call Login2 ('" & (nombre.Text) & "','" & (clave.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            aceptar.Enabled = False
            While (Me.Height > 473)
                Me.Height -= 1
                Me.Top += 1
            End While
        Else
            aceptar.Enabled = True
            While (Me.Height < 519)
                Me.Height += 1
                Me.Top -= 1
            End While
        End If
    End Sub
    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        nombre.Text = UCase(nombre.Text)
        nombre.SelectionStart = nombre.TextLength + 1
        Consulta("Call Login('" & (nombre.Text) & "')")
        If DS.Tables(DT.TableName).Rows.Count = 0 Then
            clave.Clear()
            clave.Enabled = False
            ver.BackColor = Color.White
            ver.Text = "•"
            clave.PasswordChar = "•"
        Else
            clave.Enabled = True
            ver.Enabled = True
            clave.Focus()
            clave.Select()
            ver.BackColor = Color.FromArgb(9, 29, 54)
            ver.Text = "•"
            clave.PasswordChar = "•"
        End If
    End Sub
    Private Sub nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button6_MouseMove(sender As Object, e As MouseEventArgs) Handles Button6.MouseMove
        Button6.BackColor = Color.FromArgb(237, 237, 237)
        Button6.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.BackColor = Color.FromArgb(9, 29, 54)
        Button6.ForeColor = Color.White
    End Sub
    Private Sub Button5_MouseMove(sender As Object, e As MouseEventArgs) Handles Button5.MouseMove
        Button5.BackColor = Color.FromArgb(237, 237, 237)
        Button5.ForeColor = Color.FromArgb(9, 29, 54)
    End Sub
    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.BackColor = Color.FromArgb(9, 29, 54)
        Button5.ForeColor = Color.White
    End Sub

    Private Sub nombre_Click(sender As Object, e As EventArgs) Handles nombre.Click

    End Sub

    Private Sub nombre_MouseWheel(sender As Object, e As MouseEventArgs) Handles nombre.MouseWheel

    End Sub
End Class
