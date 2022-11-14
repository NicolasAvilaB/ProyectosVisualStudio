Public Class Ayuda_Dinamica
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
    Private Sub Ayuda_Dinamica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Consulta16("Call LlamandoTipoPlato")
            tipo_platillos.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("platos")
            DA16.Fill(dt)
            With tipo_platillos
                .DataSource = dt
                .DisplayMember = "Tipo_Plato"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        tipo_platillos.SelectedIndex = -1
        Try
            Consulta17("Call LlamandoTipoBebestibles")
            tipo_bebestible.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("bebestibles")
            DA17.Fill(dt)
            With tipo_bebestible
                .DataSource = dt
                .DisplayMember = "Tipo"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        tipo_bebestible.SelectedIndex = -1
        Actualizacion_Tabla_Bebestibles()
        Mostrar_Grilla_Bebestibles()
        Actualizacion_Tabla_Platos()
        Mostrar_Grilla_Platos()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Sub Actualizacion_Tabla_Bebestibles()
        Consulta17("Call AyudaBebestibles")
    End Sub
    Sub Actualizacion_Tabla_Platos()
        Consulta16("Call AyudaPlatos")
    End Sub
    Sub Mostrar_Grilla_Platos()
        Grilla_Platos.DataSource = DS16.Tables(DT16.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Bebestibles()
        Grilla_Bebestible.DataSource = DS17.Tables(DT17.TableName)
        Conexion.Close()
    End Sub
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub tipo_platillos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_platillos.SelectedIndexChanged
        If tipo_platillos.SelectedIndex = -1 Then
            cancelacion.Enabled = False
        Else
            Consulta16("Call FiltroTipoPLatos('" & (tipo_platillos.Text) & "')")
            Mostrar_Grilla_Platos()
            cancelacion.Enabled = True
        End If
    End Sub
    Private Sub tipo_bebestible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipo_bebestible.SelectedIndexChanged
        If tipo_bebestible.SelectedIndex = -1 Then
            cancelacion.Enabled = False
        Else
            Consulta17("Call FiltrosTipoBebestibles('" & (tipo_bebestible.Text) & "')")
            Mostrar_Grilla_Bebestibles()
            cancelacion.Enabled = True
        End If
    End Sub
    Private Sub Grilla_Platos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Platos.CellContentClick
        Grilla_Platos.ReadOnly = True
    End Sub
    Private Sub Grilla_Platos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Platos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub Grilla_Bebestible_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bebestible.CellContentClick
        Grilla_Bebestible.ReadOnly = True
    End Sub
    Private Sub Grilla_Bebestible_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Bebestible.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub cancelacion_Click(sender As Object, e As EventArgs) Handles cancelacion.Click
        tipo_bebestible.SelectedIndex = -1
        tipo_platillos.SelectedIndex = -1
        Actualizacion_Tabla_Bebestibles()
        Mostrar_Grilla_Bebestibles()
        Actualizacion_Tabla_Platos()
        Mostrar_Grilla_Platos()
        cancelacion.Enabled = False
    End Sub
    Private Sub Grilla_Platos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Platos.CellDoubleClick
        Dim row As DataGridViewRow = Grilla_Platos.Rows(e.RowIndex)
        Transacciones.plato_bebesti.Text = (CStr(row.Cells(0).Value))
        Me.Close()
        Transacciones.aceptar.Focus()
        Transacciones.aceptar.Select()
    End Sub
    Private Sub Grilla_Bebestible_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Bebestible.CellDoubleClick
        Dim row As DataGridViewRow = Grilla_Bebestible.Rows(e.RowIndex)
        Transacciones.plato_bebesti.Text = (CStr(row.Cells(0).Value))
        Me.Close()
        Transacciones.aceptar.Focus()
        Transacciones.aceptar.Select()
    End Sub
    Private Sub busqueda_platillos_TextChanged(sender As Object, e As EventArgs) Handles busqueda_platillos.TextChanged
        Dim i As Integer
        busqueda_platillos.Text = StrConv(busqueda_platillos.Text, VbStrConv.ProperCase)
        i = Len(busqueda_platillos.Text)
        busqueda_platillos.SelectionStart = i
        If busqueda_platillos.Text = "" Then
            tipo_bebestible.SelectedIndex = -1
            tipo_platillos.SelectedIndex = -1
            Actualizacion_Tabla_Bebestibles()
            Mostrar_Grilla_Bebestibles()
            Actualizacion_Tabla_Platos()
            Mostrar_Grilla_Platos()
        Else
            tipo_bebestible.SelectedIndex = -1
            tipo_platillos.SelectedIndex = -1
            Actualizacion_Tabla_Bebestibles()
            Mostrar_Grilla_Bebestibles()
            Consulta16("Call Buscar_PlatoDinamico('" & (busqueda_platillos.Text & "%") & "')")
            Mostrar_Grilla_Platos()
        End If
    End Sub
    Private Sub busqueda_bebestible_TextChanged(sender As Object, e As EventArgs) Handles busqueda_bebestible.TextChanged
        Dim i As Integer
        busqueda_bebestible.Text = StrConv(busqueda_bebestible.Text, VbStrConv.ProperCase)
        i = Len(busqueda_bebestible.Text)
        busqueda_bebestible.SelectionStart = i
        If busqueda_bebestible.Text = "" Then
            tipo_bebestible.SelectedIndex = -1
            tipo_platillos.SelectedIndex = -1
            Actualizacion_Tabla_Bebestibles()
            Mostrar_Grilla_Bebestibles()
            Actualizacion_Tabla_Platos()
            Mostrar_Grilla_Platos()
        Else
            tipo_bebestible.SelectedIndex = -1
            tipo_platillos.SelectedIndex = -1
            Actualizacion_Tabla_Platos()
            Mostrar_Grilla_Platos()
            Consulta17("Call Buscar_BebestiblesDinamico('" & (busqueda_bebestible.Text & "%") & "')")
            Mostrar_Grilla_Bebestibles()
        End If
    End Sub
End Class