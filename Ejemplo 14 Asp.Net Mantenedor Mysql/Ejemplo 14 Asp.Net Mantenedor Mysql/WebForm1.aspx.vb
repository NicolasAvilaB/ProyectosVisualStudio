Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      
    End Sub

    Protected Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Try
            'Crear la Conexion
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=dbb;Uid=root;pwd=root;"

            'Crear SQL
            Dim sql As String
            sql = "INSERT INTO usuarios2 (usuarios2.rut, usuarios2.nombre, usuarios2.login, usuarios2.password, usuarios2.tipo, usuarios2.carrera) VALUES('" & Rut.Text & "','" & Nombre.Text & "','" & Login.Text & "','" & Password.Text & "','" & Tipo.Text & "','" & Carrera.Text & "')"

            Dim comando As New MySqlCommand(sql, conexion)
            Dim Resultado As Integer

            conexion.Open()

            Resultado = comando.ExecuteNonQuery()

            conexion.Close()

            Estado.Text = "Datos Guardados Correctamente"

            Rut.Text = ""
            Nombre.Text = ""
            Login.Text = ""
            Password.Text = ""
            Tipo.Text = ""
            Carrera.Text = ""


            Nombre.Enabled = False
            Login.Enabled = False
            Password.Enabled = False
            Tipo.Enabled = False
            Carrera.Enabled = False


            Nombre.ReadOnly = True
            Login.ReadOnly = True
            Password.ReadOnly = True
            Tipo.ReadOnly = True
            Carrera.ReadOnly = True

            NUevo.Enabled = True
            Guardar.Enabled = False


            Buscar.Enabled = True

            Page_Load(True, Nothing)

        Catch ex As Exception

            Page_Load(True, Nothing)

            Estado.Text = "Error en el ingreso de los Datos"
        End Try
    End Sub

    Protected Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
      

        Try
            'Crea Conexion
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=dbb;Uid=root;pwd=root;"

            'Crear Sql
            Dim sql As String
            sql = "SELECT * FROM usuarios2 where usuarios2.rut='" & Rut.Text & "'"

            Dim comando As New MySqlCommand(sql, conexion)

            ' crear DataReader

            Dim DataReader As MySqlDataReader
            conexion.Open()
            DataReader = comando.ExecuteReader() 'obtener DataReader
            ' recorrer filas
            Rut.Text = ""

            While DataReader.Read()
                Rut.Text = DataReader("rut")
                Nombre.Text = DataReader("nombre")
                Login.Text = DataReader("login")
                Password.Text = DataReader("password")
                Tipo.Text = DataReader("tipo")
                Carrera.Text = DataReader("carrera")
            End While

            DataReader.Close()
            conexion.Close()
            Estado.Text = "Registro(s) encontrados Satisfactoriamente "
            MosTrarDatos()
            GridView1.Visible = True
            NUevo.Enabled = False
            'fin de la conexion de consulta

            Rut.Focus()
            Elimianr.Enabled = True
            Editar.Enabled = True
            If Rut.Text = "" Then
                Rut.Text = ""
                Nombre.Text = ""
                Login.Text = ""
                Password.Text = ""
                Tipo.Text = ""
                Carrera.Text = ""
                Elimianr.Enabled = False
                Editar.Enabled = False
                NUevo.Enabled = True
                Estado.Text = "No se encontro ningún registro(s) asociado(s) al código solicitado"
                GridView1.DataSource = Nothing
                GridView1.Visible = False
            End If

            Page_Load(True, Nothing)

        Catch ex As Exception

            Page_Load(True, Nothing)

            Estado.Text = "Existe un Problema en la Busqueda"

        End Try
        
    End Sub

    Protected Sub NUevo_Click(sender As Object, e As EventArgs) Handles NUevo.Click
        Rut.Text = ""
        Nombre.Text = ""
        Login.Text = ""
        Password.Text = ""
        Tipo.Text = ""
        Carrera.Text = ""

        Rut.Enabled = True
        Nombre.Enabled = True
        Login.Enabled = True
        Password.Enabled = True
        Tipo.Enabled = True
        Carrera.Enabled = True

        Rut.ReadOnly = False
        Nombre.ReadOnly = False
        Login.ReadOnly = False
        Password.ReadOnly = False
        Tipo.ReadOnly = False
        Carrera.ReadOnly = False

        NUevo.Enabled = False
        Guardar.Enabled = True
        Editar.Enabled = False
        Elimianr.Enabled = False
        Buscar.Enabled = False
    End Sub
    Function MosTrarDatos()

        Dim Con As New MySqlConnection("Server=Localhost;Database=dbb;Uid=root;pwd=root;")
        Dim Tabla As New DataTable

        Dim Da As New MySqlDataAdapter("select * from usuarios2 ", Con)

        Try

            Dim Cmd As New MySqlCommandBuilder(Da)

            'llenamos la tabla desde la base de Datos

            Da.Fill(Tabla)

            'Pasamos los datos al GridView

            GridView1.DataSource = Tabla

            GridView1.DataBind()

        Catch ex As MySqlException

            MsgBox(ex.Message)

        Finally

        End Try

    End Function

    Protected Sub Elimianr_Click(sender As Object, e As EventArgs) Handles Elimianr.Click
        Dim valormensaje As Integer
        valormensaje = MsgBox("¿Desea Eliminar el Registro?", vbYesNo + vbExclamation, "Eliminar")
        If valormensaje = vbNo Then


        Else

            Try
                'Crear la Conexion
                Dim conexion As MySqlConnection
                conexion = New MySqlConnection
                conexion.ConnectionString = "Server=Localhost;Database=dbb;Uid=root;pwd=root;"

                'Crear SQL
                Dim sql As String
                sql = "delete from usuarios2 where usuarios2.rut='" & Rut.Text & "'"

                Dim comando As New MySqlCommand(sql, conexion)
                Dim Resultado As Integer

                conexion.Open()

                Resultado = comando.ExecuteNonQuery()

                conexion.Close()

                Estado.Text = "Datos Borrados Correctamente"
                NUevo.Enabled = True
                Rut.Text = ""
                Nombre.Text = ""
                Login.Text = ""
                Password.Text = ""
                Tipo.Text = ""
                Carrera.Text = ""

                GridView1.DataSource = Nothing
                GridView1.Visible = False
                Nombre.Enabled = False
                Login.Enabled = False
                Password.Enabled = False
                Tipo.Enabled = False
                Carrera.Enabled = False
                Editar.Enabled = False

                Nombre.ReadOnly = True
                Login.ReadOnly = True
                Password.ReadOnly = True
                Tipo.ReadOnly = True
                Carrera.ReadOnly = True
                Elimianr.Enabled = False
                Page_Load(True, Nothing)

            Catch ex As Exception

                Page_Load(True, Nothing)

                Estado.Text = "Error al Borrar Datos"
            End Try
        End If
    End Sub

    Protected Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        Rut.Enabled = True
        Nombre.Enabled = True
        Login.Enabled = True
        Password.Enabled = True
        Tipo.Enabled = True
        Carrera.Enabled = True

        Rut.ReadOnly = False
        Nombre.ReadOnly = False
        Login.ReadOnly = False
        Password.ReadOnly = False
        Tipo.ReadOnly = False
        Carrera.ReadOnly = False
        Actualizar.Enabled = True
        NUevo.Enabled = False
        Guardar.Enabled = False
        Editar.Enabled = False
        Elimianr.Enabled = False
        Buscar.Enabled = False
        Estado.Text = ""
    End Sub

    Protected Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Try
            'Crear la Conexion
            Dim conexion As MySqlConnection
            conexion = New MySqlConnection
            conexion.ConnectionString = "Server=Localhost;Database=dbb;Uid=root;pwd=root;"

            'Crear SQL
            Dim sql As String
            sql = "UPDATE usuarios2 SET nombre='" & (Nombre.Text) & "', login='" & (Login.Text) & "', password='" & (Password.Text) & "', tipo='" & (Tipo.Text) & "', carrera='" & (Carrera.Text) & "' where RUT='" & (Rut.Text) & "'"

            Dim comando As New MySqlCommand(sql, conexion)
            Dim Resultado As Integer

            conexion.Open()

            Resultado = comando.ExecuteNonQuery()

            conexion.Close()

            Estado.Text = "Datos Modificados Correctamente"


            Nombre.Enabled = False
            Login.Enabled = False
            Password.Enabled = False
            Tipo.Enabled = False
            Carrera.Enabled = False


            Nombre.ReadOnly = True
            Login.ReadOnly = True
            Password.ReadOnly = True
            Tipo.ReadOnly = True
            Carrera.ReadOnly = True
            Actualizar.Enabled = False
            NUevo.Enabled = True
            Guardar.Enabled = False


            Buscar.Enabled = True

            Page_Load(True, Nothing)

        Catch ex As Exception

            Page_Load(True, Nothing)

            Estado.Text = "Error al Modificar los Datos"
        End Try
    End Sub
End Class