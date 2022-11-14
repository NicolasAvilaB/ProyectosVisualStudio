Public Class Form1
    Dim mipos As Integer

    Sub limpiar()
        txtPatente.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtBuscar.Clear()


    End Sub
    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        txtPatente.Enabled = a
        txtMarca.Enabled = a
        txtModelo.Enabled = a
        btnGuardar.Enabled = a

        txtBuscar.Enabled = b
        btnNuevo.Enabled = b
        btnAnterior.Enabled = b
        btnSiguiente.Enabled = b
        btnBuscar.Enabled = b
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = " Data Source=NICO-PC;Initial Catalog=BDVEHICULOS1;user Id=sa;Password=aiep123+*;"
        verificartabla()
        mostrar(0)
        mostrardatagrid()
        controles(False, True)
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiar()
        controles(True, False)
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        MiConsulta("insert into Table_1 (patente,Marca,Modelo) values ('" & (txtPatente.Text) & "' , '" & (txtMarca.Text) & "' , '" & (txtModelo.Text) & "')")
        MsgBox("Datos ingresados correctamente")
        verificartabla()
        controles(False, True)
        mostrardatagrid()
        limpiar()
    End Sub
    Sub verificartabla()
        MiConsulta("select * from Table_1")
    End Sub
    Sub mostrar(ByVal i As Integer)
        If ds.Tables(dt.TableName).Rows.Count > 0 Then
            txtPatente.Text = DS.Tables(DT.TableName).Rows(i).Item("patente")
            txtMarca.Text = DS.Tables(DT.TableName).Rows(i).Item("Marca")
            txtModelo.Text = DS.Tables(DT.TableName).Rows(i).Item("Modelo")

        End If
    End Sub
    Sub buscar()
        MiConsulta("select * from Table_1 where patente Like '" & (txtBuscar.Text & "%") & "' ")
        DataGridView1.DataSource = DS.Tables(DT.TableName)
    End Sub
    Sub mostrardatagrid()
        DataGridView1.DataSource = DS.Tables(DT.TableName)
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        buscar()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        If mipos > 0 Then
            mipos -= 1
            mostrar(mipos)
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        If mipos < DT.Rows.Count - 1 Then
            mipos += 1
            mostrar(mipos)
        End If
    End Sub
End Class
