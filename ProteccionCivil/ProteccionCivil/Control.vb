Public Class Control
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
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
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        InicioSesion.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        InicioSesion.Show()
        InicioSesion.clave.Focus()
        InicioSesion.clave.Select()
    End Sub
    ' Sub Actualizacion_Tabla_Base_Bodega()
    '     Consulta0("Call Grilla_Admin")
    ' End Sub

    ' Sub Mostrar_Grilla_Bodega()
    '     Grilla_Bodega.DataSource = DS0.Tables(DT0.TableName)
    '     Conexion.Close()
    ' End Sub

    Private Sub Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion0.ConnectionString = "Database=bodega;Data Source=200.113.181.53;User Id=root;Password=lacomunagana; port=2030"
        Conexion1.ConnectionString = "Database=fichas;Data Source=200.113.181.53;User Id=root;Password=lacomunagana; port=2030"
    End Sub
    Private Sub DatosLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosLoginToolStripMenuItem.Click
        Me.Hide()
        DatosLoginFichas.Show()
    End Sub
    Private Sub DatosRegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosRegistrosToolStripMenuItem.Click
        Me.Hide()
        DatosRegistrosFichas.Show()
    End Sub
End Class