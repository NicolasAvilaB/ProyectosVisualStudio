Public Class FiltrosProductos
    Private Sub FiltrosProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mostrar_Grilla_Lacteos()
        Mostrar_Grilla_Carne()
        Mostrar_Grilla_Abarrotes()

        Mostrar_Grilla_Aseo()
        Mostrar_Grilla_Coctel()
        Mostrar_Grilla_Confites()

        Mostrar_Grilla_Gaseosas()
        Mostrar_Grilla_Rotiseria()
        Mostrar_Grilla_Tabaco()

        Mostrar_Grilla_Panaderia()
        Mostrar_Grilla_Higiene()
        Mostrar_Grilla_Conservas()


    End Sub

    Sub Mostrar_Grilla_Lacteos()
        Consulta("select productos.codigo, productos.nombre from productos where categorias= 'Lacteos'")
        GrillaLacteos.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub

    Sub Mostrar_Grilla_Carne()
        Consulta1("select productos.codigo, productos.nombre from productos where categorias= 'Carnes'")
        GrillaCarne.DataSource = DS2.Tables(DT2.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Panaderia()
        Consulta2("select productos.codigo, productos.nombre from productos where categorias= 'Panaderia'")
        GrillaPanaderia.DataSource = DS3.Tables(DT3.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Abarrotes()
        Consulta3("select productos.codigo, productos.nombre from productos where categorias= 'Abarrotes'")
        GrillaAbarrotes.DataSource = DS4.Tables(DT4.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Coctel()
        Consulta4("select productos.codigo, productos.nombre from productos where categorias= 'Coctel'")
        GrillaCoctel.DataSource = DS5.Tables(DT5.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Gaseosas()
        Consulta5("select productos.codigo, productos.nombre from productos where categorias= 'Gaseosas y Otros'")
        GrillaGaseosas.DataSource = DS6.Tables(DT6.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Confites()
        Consulta6("select productos.codigo, productos.nombre from productos where categorias= 'Confites'")
        GrillaConfites.DataSource = DS7.Tables(DT7.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Tabaco()
        Consulta7("select productos.codigo, productos.nombre from productos where categorias= 'Tabaco'")
        GrillaTabaco.DataSource = DS8.Tables(DT8.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Aseo()
        Consulta8("select productos.codigo, productos.nombre from productos where categorias= 'Aseo'")
        GrillaAseo.DataSource = DS9.Tables(DT9.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Conservas()
        Consulta9("select productos.codigo, productos.nombre from productos where categorias= 'Conservas y Otros'")
        GrillaConservas.DataSource = DS10.Tables(DT10.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Higiene()
        Consulta10("select productos.codigo, productos.nombre from productos where categorias= 'Higiene'")
        GrillaHigiene.DataSource = DS11.Tables(DT11.TableName)
        Conexion.Close()
    End Sub
    Sub Mostrar_Grilla_Rotiseria()
        Consulta11("select productos.codigo, productos.nombre from productos where categorias= 'Rotiseria'")
        GrillaRotiseria.DataSource = DS12.Tables(DT12.TableName)
        Conexion.Close()
    End Sub
    Private Sub GrillaLacteos_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaLacteos.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaCarne_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaCarne.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaPanaderia_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaPanaderia.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaRotiseria_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaRotiseria.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaConservas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaConservas.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaAbarrotes_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaAbarrotes.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaCoctel_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaCoctel.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaTabaco_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaTabaco.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaGaseosas_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaGaseosas.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaHigiene_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaHigiene.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaAseo_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaAseo.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub GrillaConfites_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles GrillaConfites.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub GrillaLacteos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaLacteos.CellDoubleClick
        Dim row As DataGridViewRow = GrillaLacteos.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Lacteos.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()

    End Sub

    Private Sub GrillaCarne_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCarne.CellDoubleClick
        Dim row As DataGridViewRow = GrillaCarne.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Carnes.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaPanaderia_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaPanaderia.CellDoubleClick
        Dim row As DataGridViewRow = GrillaPanaderia.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Panaderia.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaRotiseria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRotiseria.CellDoubleClick
        Dim row As DataGridViewRow = GrillaRotiseria.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Rotiseria.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaConservas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaConservas.CellDoubleClick
        Dim row As DataGridViewRow = GrillaConservas.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Conservas.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaAbarrotes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAbarrotes.CellDoubleClick
        Dim row As DataGridViewRow = GrillaAbarrotes.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Abarrotes.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaCoctel_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCoctel.CellDoubleClick
        Dim row As DataGridViewRow = GrillaCoctel.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Coctel.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaTabaco_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaTabaco.CellDoubleClick
        Dim row As DataGridViewRow = GrillaTabaco.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Tabaco.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaGaseosas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaGaseosas.CellDoubleClick
        Dim row As DataGridViewRow = GrillaGaseosas.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Gaseosas.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaHigiene_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaHigiene.CellDoubleClick
        Dim row As DataGridViewRow = GrillaHigiene.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Higiene.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaAseo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAseo.CellDoubleClick
        Dim row As DataGridViewRow = GrillaAseo.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Aseo.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub GrillaConfites_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaConfites.CellDoubleClick
        Dim row As DataGridViewRow = GrillaConfites.Rows(e.RowIndex)

        EmitirBoletas.Agregue_Productos.Text = (Val(row.Cells(0).Value))
        SendKeys.Send("{ENTER}")
        Bus_Confites.Clear()
        EmitirBoletas.Agregue_Productos.Focus()
        EmitirBoletas.Agregue_Productos.Select()
        Me.Close()
    End Sub

    Private Sub Bus_Lacteos_TextChanged(sender As Object, e As EventArgs) Handles Bus_Lacteos.TextChanged
        If (Bus_Lacteos.Text = "") Then
            Mostrar_Grilla_Lacteos()
        Else
            Consulta("select productos.codigo, productos.nombre from productos where categorias = 'Lacteos' and nombre Like '" & (Bus_Lacteos.Text & "%") & "' ")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                GrillaLacteos.DataSource = DS.Tables(DT.TableName)

            End If
        End If

    End Sub
    Private Sub Bus_Carnes_TextChanged(sender As Object, e As EventArgs) Handles Bus_Carnes.TextChanged
        If (Bus_Carnes.Text = "") Then
            Mostrar_Grilla_Carne()
        Else
            Consulta1("select productos.codigo, productos.nombre from productos where categorias = 'Carnes' and nombre Like '" & (Bus_Carnes.Text & "%") & "' ")
            If DS2.Tables(DT2.TableName).Rows.Count > 0 Then
                GrillaCarne.DataSource = DS2.Tables(DT2.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Panaderia_TextChanged(sender As Object, e As EventArgs) Handles Bus_Panaderia.TextChanged
        If (Bus_Panaderia.Text = "") Then
            Mostrar_Grilla_Panaderia()
        Else
            Consulta2("select productos.codigo, productos.nombre from productos where categorias = 'Panaderia' and nombre Like '" & (Bus_Panaderia.Text & "%") & "' ")
            If DS3.Tables(DT3.TableName).Rows.Count > 0 Then
                GrillaPanaderia.DataSource = DS3.Tables(DT3.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Rotiseria_TextChanged(sender As Object, e As EventArgs) Handles Bus_Rotiseria.TextChanged
        If (Bus_Rotiseria.Text = "") Then
            Mostrar_Grilla_Rotiseria()
        Else
            Consulta11("select productos.codigo, productos.nombre from productos where categorias = 'Rotiseria' and nombre Like '" & (Bus_Rotiseria.Text & "%") & "' ")
            If DS12.Tables(DT12.TableName).Rows.Count > 0 Then
                GrillaRotiseria.DataSource = DS12.Tables(DT12.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Conservas_TextChanged(sender As Object, e As EventArgs) Handles Bus_Conservas.TextChanged
        If (Bus_Conservas.Text = "") Then
            Mostrar_Grilla_Conservas()
        Else
            Consulta9("select productos.codigo, productos.nombre from productos where categorias = 'Conservas y Otros' and nombre Like '" & (Bus_Conservas.Text & "%") & "' ")
            If DS10.Tables(DT10.TableName).Rows.Count > 0 Then
                GrillaConservas.DataSource = DS10.Tables(DT10.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Abarrotes_TextChanged(sender As Object, e As EventArgs) Handles Bus_Abarrotes.TextChanged
        If (Bus_Abarrotes.Text = "") Then
            Mostrar_Grilla_Abarrotes()
        Else
            Consulta3("select productos.codigo, productos.nombre from productos where categorias = 'Abarrotes' and nombre Like '" & (Bus_Abarrotes.Text & "%") & "' ")
            If DS4.Tables(DT4.TableName).Rows.Count > 0 Then
                GrillaAbarrotes.DataSource = DS4.Tables(DT4.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Coctel_TextChanged(sender As Object, e As EventArgs) Handles Bus_Coctel.TextChanged
        If (Bus_Coctel.Text = "") Then
            Mostrar_Grilla_Coctel()
        Else
            Consulta4("select productos.codigo, productos.nombre from productos where categorias = 'Coctel' and nombre Like '" & (Bus_Coctel.Text & "%") & "' ")
            If DS5.Tables(DT5.TableName).Rows.Count > 0 Then
                GrillaCoctel.DataSource = DS5.Tables(DT5.TableName)

            End If
        End If
    End Sub

    Private Sub Bus_Tabaco_TextChanged(sender As Object, e As EventArgs) Handles Bus_Tabaco.TextChanged
        If (Bus_Tabaco.Text = "") Then
            Mostrar_Grilla_Tabaco()
        Else
            Consulta7("select productos.codigo, productos.nombre from productos where categorias = 'Tabaco' and nombre Like '" & (Bus_Tabaco.Text & "%") & "' ")
            If DS8.Tables(DT8.TableName).Rows.Count > 0 Then
                GrillaTabaco.DataSource = DS8.Tables(DT8.TableName)
            End If
        End If
    End Sub

    Private Sub Bus_Gaseosas_TextChanged(sender As Object, e As EventArgs) Handles Bus_Gaseosas.TextChanged
        If (Bus_Gaseosas.Text = "") Then
            Mostrar_Grilla_Gaseosas()
        Else
            Consulta5("select productos.codigo, productos.nombre from productos where categorias = 'Gaseosas y Otros' and nombre Like '" & (Bus_Gaseosas.Text & "%") & "' ")
            If DS6.Tables(DT6.TableName).Rows.Count > 0 Then
                GrillaGaseosas.DataSource = DS6.Tables(DT6.TableName)
            End If
        End If
    End Sub

    Private Sub Bus_Higiene_TextChanged(sender As Object, e As EventArgs) Handles Bus_Higiene.TextChanged
        If (Bus_Higiene.Text = "") Then
            Mostrar_Grilla_Higiene()
        Else
            Consulta10("select productos.codigo, productos.nombre from productos where categorias = 'Higiene' and nombre Like '" & (Bus_Higiene.Text & "%") & "' ")
            If DS11.Tables(DT11.TableName).Rows.Count > 0 Then
                GrillaHigiene.DataSource = DS11.Tables(DT11.TableName)
            End If
        End If
    End Sub

    Private Sub Bus_Aseo_TextChanged(sender As Object, e As EventArgs) Handles Bus_Aseo.TextChanged
        If (Bus_Aseo.Text = "") Then
            Mostrar_Grilla_Aseo()
        Else
            Consulta8("select productos.codigo, productos.nombre from productos where categorias = 'Aseo' and nombre Like '" & (Bus_Aseo.Text & "%") & "' ")
            If DS9.Tables(DT9.TableName).Rows.Count > 0 Then
                GrillaAseo.DataSource = DS9.Tables(DT9.TableName)
            End If
        End If
    End Sub

    Private Sub Bus_Confites_TextChanged(sender As Object, e As EventArgs) Handles Bus_Confites.TextChanged
        If (Bus_Confites.Text = "") Then
            Mostrar_Grilla_Confites()
        Else
            Consulta6("select productos.codigo, productos.nombre from productos where categorias = 'Confites' and nombre Like '" & (Bus_Confites.Text & "%") & "' ")
            If DS7.Tables(DT7.TableName).Rows.Count > 0 Then
                GrillaConfites.DataSource = DS7.Tables(DT7.TableName)
            End If
        End If
    End Sub
    Private Sub Volver_Click_1(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
    End Sub
    Private Sub FiltrosProductos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        GrillaLacteos.Columns(0).Width = 1
        GrillaCarne.Columns(0).Width = 1
        GrillaPanaderia.Columns(0).Width = 1
        GrillaRotiseria.Columns(0).Width = 1

        GrillaConservas.Columns(0).Width = 1
        GrillaAbarrotes.Columns(0).Width = 1
        GrillaCoctel.Columns(0).Width = 1
        GrillaTabaco.Columns(0).Width = 1

        GrillaGaseosas.Columns(0).Width = 1
        GrillaHigiene.Columns(0).Width = 1
        GrillaAseo.Columns(0).Width = 1
        GrillaConfites.Columns(0).Width = 1
    End Sub
End Class