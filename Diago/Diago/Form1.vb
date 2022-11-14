Public Class Form1
    Dim Vall1 As Integer
    Dim Va2l2 As Integer
    Dim mult As Integer
    Dim ult As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=diagnostico;Data Source=localhost;User Id=root;Password=root"
        Vall1 = 0
        Timer1.Enabled = True
        Timer1.Interval = 100
        fecha.Text = FormatDateTime(Now, DateFormat.ShortDate)
        
        'Crea Numero de Venta y suma cuando realizas la venta'
        numero_venta()
        

    End Sub
    Sub numero_venta()
        Consulta("select max(n_venta)as n_venta from detalle_venta")

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("n_venta")) Is DBNull Then
            nventa.Text = 1

        Else
            nventa.Text = DS.Tables(DT.TableName).Rows(0).Item("n_venta") + 1
            Conexion.Close()
        End If
    End Sub
    Sub Borrar_Grilla()
        grilla.DataSource = Nothing
        Conexion.Close()
    End Sub
    Sub Borrar_Grilla2()
        bu.DataSource = Nothing
        Conexion.Close()
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        producto.Enabled = True

        limpia.Enabled = False

        grilla.Enabled = True
        Guardar.Enabled = True
        Imprimir.Enabled = True
        Cancelar.Enabled = True
        Nuevo.Enabled = False
        quitar.Enabled = True

        producto.Focus()

        producto.Clear()
        ve.Clear()
        Precio.Clear()
    End Sub
    Sub limpiar()
        producto.Clear()
        ve.Clear()
        Precio.Clear()
    End Sub

    Private Sub agre_Click(sender As Object, e As EventArgs) Handles agre.Click

        ult = Convert.ToInt32(ve.Text) * Convert.ToInt32(Precio.Text)

        grilla.Rows.Add(producto.Text, Precio.Text, ve.Text, ult)

        Me.grilla.CurrentCell = Me.grilla.Rows(Me.grilla.RowCount - 1).Cells(0)
        Me.grilla.Refresh()

        producto.Enabled = False
        Precio.Enabled = False
        ve.Enabled = False
        agre.Enabled = False
        grilla.Enabled = False
        limpia.Enabled = True
        Imprimir.Enabled = False
        Cancelar.Enabled = False
        Nuevo.Enabled = True
        limpiar()
        tot.Enabled = False


    End Sub

    'Sub controles(ByVal a As Boolean, ByVal b As Boolean)
    '   producto.ReadOnly = b
    '  Precio.ReadOnly = b
    ' ve.ReadOnly = b
    '
    '   agre.Enabled = a
    '  quitar.Enabled = a
    ' Nuevo.Enabled = b
    'Guardar.Enabled = a
    ' Cancelar.Enabled = a
    'Buscarrr.ReadOnly = a


    'End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub
    'sub grabar_detalle_venta()

    'for i = 0 to datagridview1.rows.count -1
    'consulta("insert into detalle_venta (n_venta,nombre_producto,precio,cantidad,total) values ("& (nventa.text) & ",'" & (datagridview1.item(0, i).value) & "'," & (datagridview1.item(1, i).value) & ", " & (datagridview1.item(2, i).value) & ", " & (datagridview1.item(3, i).value) & ") ")


    'next

    'end sub

    '
    '
    Private Sub grilla_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles grilla.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Vall1 = Vall1 + 1
        Va2l2 = Va2l2 + 1

        Dim suma As Integer = 0.0

        For Each row As DataGridViewRow In grilla.Rows
            suma += Val(row.Cells(3).Value)

        Next

        tot.Text = Convert.ToInt32(suma)
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim mifecha As Date = fecha.Text
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")

        If Me.grilla.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Agregados, Porfavor Agregue alguno Para Continuar", vbCritical, "Error Fatal")
        Else
            For Each row As DataGridViewRow In grilla.Rows

                Try
                    Consulta("Call InsertarProductos ('" & (nventa.Text) & "','" & (CStr(row.Cells(0).Value)) & "','" & (Val(row.Cells(1).Value)) & "','" & (Val(row.Cells(2).Value)) & "','" & (Val(row.Cells(3).Value)) & "')")



                Catch ex As Exception


                    DA.SelectCommand = SC
                    DA.Fill(DT)

                End Try

            Next
            MsgBox("Datos Ingresados Correctamente!!!", vbInformation, "Felicidades")
            Try
                Consulta("Call InsertVenta ('" & (nventa.Text) & "','" & (mifecha2) & "')")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try


        End If

        Application.Restart()

        'grabar_venta()
        'grabar_detalle_venta()


    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Borrar_Grilla()
        producto.Enabled = False
        Precio.Enabled = False
        ve.Enabled = False
        agre.Enabled = False
        grilla.Enabled = False

        Imprimir.Enabled = False
        Cancelar.Enabled = False
        Nuevo.Enabled = True

        tot.Enabled = False
        ve.Clear()
        producto.Clear()
        Precio.Clear()
        Borrar_Grilla()
    End Sub

    Private Sub quitar_Click(sender As Object, e As EventArgs) Handles quitar.Click
        If Me.grilla.Rows.Count = 0 Then
            MsgBox("Error: No Hay Productos Para Eliminar", vbCritical, "Error Fatal")
            agre.Focus()
        Else
            Dim loFila As DataGridViewRow = Me.grilla.CurrentRow()

            grilla.Rows.Remove(loFila)

        End If
    End Sub

    Private Sub producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles producto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If (Precio.Text = "") Then
                MsgBox("Error el Campo Precio esta Vacio!!!", vbCritical, "Error")
                ve.Focus()
            End If
        End If
    End Sub

    Private Sub producto_TextChanged(sender As Object, e As EventArgs) Handles producto.TextChanged
        If (producto.Text = "") Then

            Precio.Enabled = False

        ElseIf (Len(producto.Text) = 2) Then

            Precio.Enabled = True
        ElseIf (Len(producto.Text) = 1) Then
            Precio.Enabled = False
        End If
    End Sub
    '  Sub calculo()
    '     tot.Text = 0
    'for i = 0 to datagridview1.rows.count -1 
    'dim totalgrilla as integer = datagridview1.item(3,i).value
    'tot.text += totalgrilla
    'next   
    'End Sub

    Private Sub Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Precio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If (ve.Text = "") Then
                MsgBox("Error el Campo Cantidad esta Vacio!!!", vbCritical, "Error")
                ve.Focus()
            End If
        End If
    End Sub

    Private Sub Precio_TextChanged(sender As Object, e As EventArgs) Handles Precio.TextChanged
        If (Precio.Text = "") Then

            ve.Enabled = False

        ElseIf (Len(Precio.Text) = 2) Then

            ve.Enabled = True
        ElseIf (Len(Precio.Text) = 1) Then
            ve.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ve_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ve.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            If (ve.Text = "") Then
                MsgBox("Error el Campo Cantidad esta Vacio!!!", vbCritical, "Error")
                ve.Focus()
            Else
                grilla.Rows.Add(producto.Text, Precio.Text, ve.Text)
                Me.grilla.CurrentCell = Me.grilla.Rows(Me.grilla.RowCount - 1).Cells(0)
                Me.grilla.Refresh()
                producto.Enabled = False
                Precio.Enabled = False
                ve.Enabled = False
                agre.Enabled = False
                grilla.Enabled = False

                Imprimir.Enabled = False
                Cancelar.Enabled = False
                Nuevo.Enabled = True
                limpia.Enabled = True
                tot.Enabled = False

            End If
        End If
    End Sub

    Private Sub ve_TextChanged(sender As Object, e As EventArgs) Handles ve.TextChanged
        If (ve.Text = "") Then
            agre.Enabled = False
        Else
            agre.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles limpia.Click
        Consulta("Call Borra")
        Consulta("Call BorraVenta")
        MsgBox(" Exito: Ventas Borradas Con Exito", vbInformation, "Limpieza Exitosa")
        Application.Restart()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub bu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bu.CellContentClick

    End Sub

    Private Sub bu_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles bu.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Buscarrr_TextChanged(sender As Object, e As EventArgs) Handles Buscarrr.TextChanged
        If (Buscarrr.Text = "") Then
            Borrar_Grilla2()

        Else
            Consulta("select  from detalle_venta where n_venta = " & (Buscarrr.Text) & " ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                bu.DataSource = DS.Tables(DT.TableName)

            End If
        End If

        'datagridview1.rows.clear()
        'consulta("select * from detalle_venta where n_venta =" & (Buscarrr.text) & "' ")
        'Dim cantidadregistros as integer = ds.tables(dt.tablename).rows.count
        'if cantidadregistro > 0 then

        'for i = 0 to cantidadregistros -1
        'Datagridview1.rows.add(Ds.table(dt.tablename).rows(i).item("producto"), Ds.table(dt.tablename).rows(i).item("precio"), Ds.table(dt.tablename).rows(i).item("cantidad"), Ds.table(dt.tablename).rows(i).item("total") )
        'next

        'calcular_total()
        'end if
    End Sub

    Private Sub tot_TextChanged(sender As Object, e As EventArgs) Handles tot.TextChanged

    End Sub

    Private Sub fecha_TextChanged(sender As Object, e As EventArgs) Handles fecha.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Consulta("select * from detalle_venta")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            bu.DataSource = DS.Tables(DT.TableName)

        End If
    End Sub
End Class
