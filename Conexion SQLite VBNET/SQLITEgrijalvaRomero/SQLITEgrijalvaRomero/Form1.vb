Imports Finisar.SQLite
Public Class Form1
    Const cadena_conexion As String = "Data Source=articulos.db;Version=3;"
    Sub crearBD()
        Dim objCon As SQLiteConnection
        Dim objCoomand As SQLiteCommand
        Try
            objCon = New SQLiteConnection(cadena_conexion & "New=True;")
            objCon.Open()
            objCoomand = objCon.CreateCommand()
            objCoomand.CommandText = "CREATE TABLE productos (id integer Primary KEY, nombre TEXT);"
            objCoomand.ExecuteNonQuery()
            objCoomand.CommandText = "Insert into productos(id, nombre)values(1,'TV');"
            objCoomand.ExecuteNonQuery()
            objCoomand.CommandText = "Insert into productos(id, nombre)values(2,'Telefono');"
            objCoomand.ExecuteNonQuery()
        Finally
            If Not IsNothing(objCon) Then
                objCon.Close()
            End If
        End Try
    End Sub
    Sub leerDatos()
        Dim objConn As SQLiteConnection
        Dim objcommand As SQLiteCommand
        Dim objReader As SQLiteDataReader

        Try
            objConn = New SQLiteConnection(cadena_conexion)
            objConn.Open()
            objcommand = objConn.CreateCommand()
            objcommand.CommandText = "SELECT * from productos"
            objReader = objcommand.ExecuteReader()
            ListBox1.Items.Clear()
            While (objReader.Read())
                ListBox1.Items.Add(objReader("nombre"))
            End While




        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not IsNothing(objConn) Then
                objConn.Close()
            End If
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call crearBD()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call leerDatos()

    End Sub
End Class
