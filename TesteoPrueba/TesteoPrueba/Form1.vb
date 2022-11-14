Public Class Form1
    Dim MiPos As Integer
    Dim VarSeleccion As Integer
   
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion.ConnectionString = "Data Source=NICO-PC;Initial Catalog=BDPRUEBA3;user Id=sa; Password =aiep123+*;"
        limpiar()
        Mostrar(0)
        VerificarTabla()


    End Sub
    Sub Controles(ByVal a As Boolean, ByVal b As Boolean)
        TxtRUT.ReadOnly = b
        TxtNOMBRE.ReadOnly = b
        TxtTELEFONO.ReadOnly = b
        TxtDireccion.ReadOnly = b
        BTELIMINAR.Enabled = a
        BTACEPTAR.Enabled = a
        BTCANCELAR.Enabled = a
        BTSALIR.Enabled = a
        CHBHABILITADO.Enabled = a
        RDBTHOMBRE.Enabled = a
        RDBTMUJER.Enabled = a
        BTPRIMER.Enabled = a
        BTSIGUIENTE.Enabled = a
        BTULTIMO.Enabled = a
        BTANTERIOR.Enabled = a


    End Sub
    Sub Mostrar(ByVal i As Integer)
        MiConsulta("select * from Personal")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            TxtRUT.Text = DS.Tables(DT.TableName).Rows(i).Item("Rut")
            TxtNOMBRE.Text = DS.Tables(DT.TableName).Rows(i).Item("Nombre")
            TxtDireccion.Text = DS.Tables(DT.TableName).Rows(i).Item("Telefono")
            TxtTELEFONO.Text = DS.Tables(DT.TableName).Rows(i).Item("Direccion")
        End If
    End Sub
    Sub limpiar()
        TxtNOMBRE.Clear()
        TxtTELEFONO.Clear()
        TxtRUT.Clear()
        TxtDireccion.Clear()


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAgregar.Click
        limpiar()
        Controles(True, False)
        VarSeleccion = 1

    End Sub

    Private Sub BTACEPTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTACEPTAR.Click
        If VarSeleccion = 1 Then
            MiConsulta("Insert into Personal(Rut ,Nombre ,Telefono, Direccion, Sexo, Estado ) values ('" & (TxtRUT.Text) & "', '" & (TxtNOMBRE.Text) & "', '" & (TxtTELEFONO.Text) & "', '" & (TxtDireccion.Text) & "', '" & (RDBTHOMBRE.Text) & "', '" & (RDBTMUJER.Text) & "') ")
            MsgBox("Datos Ingresados Correctamente")
        ElseIf VarSeleccion = 2 Then
            MiConsulta("Update Personal SET NOMBRE='" & (TxtNOMBRE.Text) & "', DIRECCION='" & (TxtDireccion.Text) & "', TELEFONO=" & (TxtTELEFONO.Text) & " Where RUT='" & (TxtRUT.Text) & "'")
            MsgBox("Datos MOdificados Correctamente")
            Controles(False, True)
            limpiar()

            End If
    End Sub
    Sub VerificarTabla()
        MiConsulta("select * From Personal")
    End Sub

    Private Sub BTANTERIOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANTERIOR.Click
        If MiPos > 0 Then
            MiPos -= 1
            Mostrar(MiPos)
        End If
    End Sub

    Private Sub BTSIGUIENTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSIGUIENTE.Click
        If MiPos < DT.Rows.Count - 1 Then
            MiPos += 1
            Mostrar(MiPos)

        End If
    End Sub

    Private Sub BTModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTModificar.Click
        Controles(True, False)
        VarSeleccion = 2

    End Sub

    Private Sub BTULTIMO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTULTIMO.Click
        MiPos = DT.Rows.Count - 1
        Mostrar(MiPos)
    End Sub

    Private Sub BTPRIMER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRIMER.Click
        Mostrar(0)
    End Sub

    Private Sub BTELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTELIMINAR.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿DESEA ELIMINAR?", vbYesNo + vbQuestion, "ELIMINACION COMPLETA CON EXITO")
        If valormensaje = vbYes Then
            MiConsulta("Delete From Personal where rut ='" & (TxtRUT.Text) & "' ")

        End If

        VerificarTabla()
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Mostrar(0)
        Else
            limpiar()
        End If
    End Sub

    Private Sub BTSALIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSALIR.Click
        Application.Exit()
    End Sub

    Private Sub BTCANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCANCELAR.Click
        Controles(False, True)
    End Sub
End Class
