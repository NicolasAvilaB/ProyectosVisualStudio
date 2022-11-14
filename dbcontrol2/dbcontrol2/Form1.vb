Public Class Form1
    Dim cantidad1 As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=bdcontrol2;DataSource=localhost;User Id=root;Password=root"
        controles(True, False)
    End Sub
    Sub controles(ByVal a As Boolean, ByVal b As Boolean)
        GroupBox1.Enabled = b
        GroupBox3.Enabled = a
        GroupBox4.Enabled = b
        Guardar.Enabled = b
        IMp.Enabled = b

    End Sub
    Sub limpiar()
        Cod_Pizza.Clear()
        Nom_Pizza.Clear()
        Nombre_Ingre.Clear()
        Nom_Pizza.Clear()

    End Sub
    Sub crear_codigo_pizza()

        Consulta("select max(codigo) as codigo from pizzas")
      

        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("codigo")) Is DBNull Then
            Cod_Pizza.Text = 1
        Else
            Dim varnumfactura As Integer = DS.Tables(DT.TableName).Rows(0).Item("codigo") + 1
            Cod_Pizza.Text = varnumfactura

        End If


    End Sub
    Private Sub Nueva_Click(sender As Object, e As EventArgs) Handles Nueva.Click
        grilla.DataSource = Nothing

        DataGridView1.Visible = False
        If (Nueva.Text = "Nueva Pizza") Then
            limpiar()


            GroupBox1.Enabled = True
            GroupBox3.Enabled = False
            GroupBox4.Enabled = True
            Guardar.Enabled = True
            IMp.Enabled = True

            Nueva.Text = "Cancelar"
            crear_codigo_pizza()
        ElseIf (Nueva.Text = "Cancelar") Then

            limpiar()



            GroupBox1.Enabled = False
            GroupBox3.Enabled = True
            GroupBox4.Enabled = False
            Guardar.Enabled = False
            IMp.Enabled = False
            Nueva.Text = "Nueva Pizza"
        End If
       

        
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        DataGridView1.Visible = False
        If (Nombre_Ingre.Text = "") Then
            MsgBox("Se debe agregar un Ingrediente", vbCritical, "ERROR")
        Else
            grilla.Rows.Add(Nombre_Ingre.Text)

            For i = 1 To grilla.Rows.Count
                cantidad1 = i

            Next

            Cantidad.Text = cantidad1

            Nombre_Ingre.Clear()
            Nombre_Ingre.Focus()



        End If
    End Sub

    Private Sub Quitar_Click(sender As Object, e As EventArgs) Handles Quitar.Click
        If grilla.Rows.Count > 0 Then
            grilla.Rows.Remove(grilla.CurrentRow)

            For i = 0 To grilla.Rows.Count
                cantidad1 = i

            Next
            Cantidad.Text = cantidad1
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        
        If (Nom_Pizza.Text = "") Then
            MsgBox("Agrege Cantidad de Pizza", vbCritical, "ERROR")
        ElseIf DS.Tables(DT.TableName).Rows.Count > 0 Then
            Consulta("insert into pizzas(codigo,nombre,cantidad_ingredientes) values ('" & (Cod_Pizza.Text) & "','" & (Nom_Pizza.Text) & "','" & (Cantidad.Text) & "')")

            agregar_ingredientes()
            MsgBox("Datos Guardados Correctamente", vbInformation, "Felicidades")
            controles(True, False)


            limpiar()
            grilla.Rows.Clear()
            DataGridView1.Visible = False
            Nueva.Text = "Nueva Pizza"
        Else
            MsgBox("Agrege Ingredientes de Pizza", vbCritical, "ERROR")
        End If



    End Sub
    Sub agregar_ingredientes()
        Dim ingrediente As String
        For i = 0 To grilla.Rows.Count - 1
            ingrediente = grilla.Item(0, i).Value
            Consulta("insert into pizzas_ingredientes(codigo_pizza,nombre_ingrediente) values ('" & (Cod_Pizza.Text) & "','" & (ingrediente) & "')")
        Next
    End Sub

    Private Sub BUsca_Click(sender As Object, e As EventArgs) Handles BUsca.Click
        DataGridView1.Visible = False
        Dim i As Integer
        Consulta("select nombre_ingrediente from pizzas_ingredientes where codigo_pizza='" & (Busca_Cos.Text) & "'")
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            grilla.DataSource = DS.Tables(DT.TableName)

        End If


    End Sub
    Sub MostrarDatos()
        Dim i As Integer
        

        
        Consulta("SELECT pizzas.codigo,pizzas.nombre from pizzas where codigo= " & (Busca_Cos.Text) & " ")
        
        If DS.Tables(DT.TableName).Rows.Count > 0 Then
            Cod_Pizza.Text = DS.Tables(DT.TableName).Rows(i).Item("codigo")
            Nom_Pizza.Text = DS.Tables(DT.TableName).Rows(i).Item("nombre")
           
        End If
        'DataGridView1.DataSource = DS.Tables(DT.TableName)
        
    End Sub

    Private Sub Busca_Cos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Busca_Cos.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Busca_Cos_TextChanged(sender As Object, e As EventArgs) Handles Busca_Cos.TextChanged

    End Sub

    Private Sub Cod_Pizza_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cod_Pizza.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Numeros, No Letras ni Espacios", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Cod_Pizza_TextChanged(sender As Object, e As EventArgs) Handles Cod_Pizza.TextChanged

    End Sub

    Private Sub Nombre_Ingre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nombre_Ingre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MsgBox("Solo Se Admite Letras", vbCritical, "Error")
            e.Handled = True
        End If
    End Sub

    Private Sub Nombre_Ingre_TextChanged(sender As Object, e As EventArgs) Handles Nombre_Ingre.TextChanged

    End Sub

    Private Sub Nom_Pizza_TextChanged(sender As Object, e As EventArgs) Handles Nom_Pizza.TextChanged

    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Consulta("delete from pizzas")
        Consulta("delete from pizzas_ingredientes")
        Application.Restart()
    End Sub
End Class
