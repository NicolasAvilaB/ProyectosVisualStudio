Public Class Concretar_Ventas
    Private x As Integer
    Private y As Integer
    Private mover As Boolean
    Dim usuario1 As String
    Dim producto1 As String
    Dim precio1 As Int64
    Dim cantidad1 As Int64
    Dim tipo1 As String
    Dim ita As Integer
    Dim mult As Integer
    Dim mult1 As Integer
    Dim descuento As Integer
    Dim b As Integer
    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Grilla_Venta_Final.Rows.Clear()
        subtotales.Clear()
        propineichon.SelectedIndex = -1
        Me.Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Grilla_Venta_Final.Rows.Clear()
        subtotales.Clear()
        propineichon.SelectedIndex = -1
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
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
    Private Sub Concretar_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each row As DataGridViewRow In Transacciones.Grilla_Transaccion.Rows
            usuario1 = CStr(row.Cells(0).Value)
            producto1 = CStr(row.Cells(1).Value)
            cantidad1 = Val(row.Cells(3).Value)
            tipo1 = CStr(row.Cells(4).Value)
            Grilla_Venta_Final.Rows.Add(usuario1, producto1, cantidad1, tipo1)
        Next
        subtotales.Text = Transacciones.totales.Text
        boletadeconcreta.Text = Transacciones.boleteichon.Text
        Timer2.Interval = 100
        Timer2.Enabled = True
        ita = 0
        Try
            Consulta14("Call LlamandoGanso")
            listaganso.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("trabajadores")
            DA14.Fill(dt)
            With listaganso
                .DataSource = dt
                .DisplayMember = "Nombre"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        If listaganso.SelectedIndex = -1 Then
            propineichon.Enabled = False
            pagando.Enabled = True
            desc.Enabled = True
        End If
        totalmente.Text = subtotales.Text
        listaganso.SelectedIndex = -1
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ita = ita + 1
        Dim cantidad1 As Integer = 0.0
        For i = 1 To Grilla_Venta_Final.Rows.Count
            cantidad1 = i
        Next
        Items.Text = Convert.ToInt64(cantidad1)
    End Sub
    Private Sub listaganso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaganso.SelectedIndexChanged
        If listaganso.SelectedIndex = -1 Then
            propineichon.Enabled = False
            pagando.Enabled = True
            desc.Enabled = True
            cancelar.Enabled = False
        Else
            propineichon.Enabled = True
            pagando.Enabled = False
            desc.Enabled = False
            desc.SelectedIndex = -1
            cancelar.Enabled = True
            subtotales.Text = Transacciones.totales.Text
        End If
    End Sub
    Private Sub propineichon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles propineichon.SelectedIndexChanged
        If propineichon.SelectedIndex = -1 Then
            pagando.Enabled = False
            desc.Enabled = False
            cancelar.Enabled = True
        Else
            pagando.Enabled = True
            desc.Enabled = True
            cancelar.Enabled = True
        End If
        Dim a As Int64 = Convert.ToInt64(Transacciones.totales.Text)
        If propineichon.Text = "5%" Then
            mult = a * 0.05
            subtotales.Clear()
            subtotales.Text = Convert.ToInt64(Transacciones.totales.Text) + mult
            cancelar.Enabled = True
        ElseIf propineichon.Text = "10%"
            mult = a * 0.1
            subtotales.Clear()
            subtotales.Text = Convert.ToInt64(Transacciones.totales.Text) + mult
            cancelar.Enabled = True
        ElseIf propineichon.Text = "15%"
            mult = a * 0.15
            subtotales.Clear()
            subtotales.Text = Convert.ToInt64(Transacciones.totales.Text) + mult
            cancelar.Enabled = True
        End If
    End Sub
    Private Sub Grilla_Venta_Final_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Venta_Final.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub subtotales_TextChanged(sender As Object, e As EventArgs) Handles subtotales.TextChanged
        totalmente.Clear()
        totalmente.Text = subtotales.Text
    End Sub
    Private Sub desc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles desc.SelectedIndexChanged
        If (propineichon.Enabled = True) Then
            Dim a As Int64 = Convert.ToInt64(subtotales.Text)
            If desc.Text = "5%" Then
                mult1 = a * 0.05
                b = a - mult1
                totalmente.Clear()
                totalmente.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "10%"
                mult1 = a * 0.1
                b = a - mult1
                totalmente.Clear()
                totalmente.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "15%"
                mult1 = a * 0.15
                b = a - mult1
                totalmente.Clear()
                totalmente.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "20%"
                mult1 = a * 0.2
                b = a - mult1
                totalmente.Clear()
                totalmente.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "25%"
                mult1 = a * 0.25
                b = a - mult1
                totalmente.Clear()
                totalmente.Text = b
                cancelar.Enabled = True
            ElseIf desc.SelectedIndex = -1
                totalmente.Text = a
                cancelar.Enabled = False
            End If
        Else
            Dim a As Int64 = Convert.ToInt64(Transacciones.totales.Text)
            If desc.Text = "5%" Then
                mult1 = a * 0.05
                b = a - mult1
                subtotales.Clear()
                subtotales.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "10%"
                mult1 = a * 0.1
                b = a - mult1
                subtotales.Clear()
                subtotales.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "15%"
                mult1 = a * 0.15
                b = a - mult1
                subtotales.Clear()
                subtotales.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "20%"
                mult1 = a * 0.2
                b = a - mult1
                subtotales.Clear()
                subtotales.Text = b
                cancelar.Enabled = True
            ElseIf desc.Text = "25%"
                mult1 = a * 0.25
                b = a - mult1
                subtotales.Clear()
                subtotales.Text = b
                cancelar.Enabled = True
            ElseIf desc.SelectedIndex = -1
                subtotales.Text = a
                cancelar.Enabled = False
            End If
        End If
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        listaganso.SelectedIndex = -1
        desc.SelectedIndex = -1
        propineichon.SelectedIndex = -1
        subtotales.Clear()
        totalmente.Clear()
        subtotales.Text = Transacciones.totales.Text
        desc.Enabled = True
        listaganso.Enabled = True
        pagando.Enabled = True
        propineichon.Enabled = False
        cancelar.Enabled = False
    End Sub
    Private Sub pagando_Click(sender As Object, e As EventArgs) Handles pagando.Click
        Consulta18("Call GeneradorIDautomatico7")
        Dim i As Integer
        If TypeOf (DS18.Tables(DT18.TableName).Rows(0).Item("ID")) Is DBNull Then
            i = 1
        Else
            i = DS18.Tables(DT18.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        If (desc.Enabled = True And propineichon.Enabled = False) Then
            If (desc.SelectedIndex = -1) Then
                Dim mifecha3 As Date = Transacciones.fecha.Text
                Dim mifecha4 As String = mifecha3.ToString("yyyy-MM-dd")
                For Each row As DataGridViewRow In Grilla_Venta_Final.Rows
                    Consulta18("Call GuardarHistorialPedido('" & (i) & "','" & (boletadeconcreta.Text) & "','" & (CStr(row.Cells(0).Value)) & "','" & (CStr(row.Cells(1).Value)) & "','" & (Val(row.Cells(2).Value)) & "','" & (CStr(row.Cells(3).Value)) & "','" & "-------" & "','" & "-------" & "','" & "-------" & "','" & (totalmente.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha4) & "','" & (Transacciones.nomesa.Text) & "')")
                Next
                MsgBox("Compra Realizada con Exito", vbInformation, "Compra Exitosa")
                MsgBox("Gracias por Preferir Restaurante Hermanos 'Mario e Luigi' ", vbInformation, "Compra Exitosa")
                Me.Close()
                Consulta18("Call ActualizaDisponible ('" & (Transacciones.nomesa.Text) & "')")
                Transacciones.Close()
                MenuMesas.Close()
                MenuMesas.Show()
            Else
                Dim mifecha3 As Date = Transacciones.fecha.Text
                Dim mifecha4 As String = mifecha3.ToString("yyyy-MM-dd")
                For Each row As DataGridViewRow In Grilla_Venta_Final.Rows
                    Consulta18("Call GuardarHistorialPedido('" & (i) & "','" & (boletadeconcreta.Text) & "','" & (CStr(row.Cells(0).Value)) & "','" & (CStr(row.Cells(1).Value)) & "','" & (Val(row.Cells(2).Value)) & "','" & (CStr(row.Cells(3).Value)) & "','" & "-------" & "','" & "-------" & "','" & (mult1) & "','" & (totalmente.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha4) & "','" & (Transacciones.nomesa.Text) & "')")
                Next
                MsgBox("Compra Realizada con Exito", vbInformation, "Compra Exitosa")
                MsgBox("Gracias por Preferir Restaurante Hermanos 'Mario e Luigi' ", vbInformation, "Compra Exitosa")
                Me.Close()
                Consulta18("Call ActualizaDisponible ('" & (Transacciones.nomesa.Text) & "')")
                Transacciones.Close()
                MenuMesas.Close()
                MenuMesas.Show()
            End If
        ElseIf (desc.Enabled = True And propineichon.Enabled = True And listaganso.Enabled = True)
            Dim mifecha3 As Date = Transacciones.fecha.Text
            Dim mifecha4 As String = mifecha3.ToString("yyyy-MM-dd")
            For Each row As DataGridViewRow In Grilla_Venta_Final.Rows
                Consulta18("Call GuardarHistorialPedido('" & (i) & "','" & (boletadeconcreta.Text) & "','" & (CStr(row.Cells(0).Value)) & "','" & (CStr(row.Cells(1).Value)) & "','" & (Val(row.Cells(2).Value)) & "','" & (CStr(row.Cells(3).Value)) & "','" & (mult) & "','" & (listaganso.Text) & "','" & (mult1) & "','" & (totalmente.Text) & "','" & (Now.ToLongTimeString) & "','" & (mifecha4) & "','" & (Transacciones.nomesa.Text) & "')")
            Next
            MsgBox("Compra Realizada con Exito", vbInformation, "Compra Exitosa")
            MsgBox("Gracias por Preferir Restaurante Hermanos 'Mario e Luigi' ", vbInformation, "Compra Exitosa")
            Me.Close()
            Consulta18("Call ActualizaDisponible ('" & (Transacciones.nomesa.Text) & "')")
            Transacciones.Close()
            MenuMesas.Close()
            MenuMesas.Show()
        End If
    End Sub
End Class