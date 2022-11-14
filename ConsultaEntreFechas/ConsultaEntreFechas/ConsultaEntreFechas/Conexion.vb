Imports System.Data.Sql
Imports System.Data.SqlClient

Module Conexion
    Public conexiones As SqlConnection
    Public enunciado As SqlCommand
    Public adaptador As SqlDataAdapter


    'FUNCION DE CONEXION A LA BASE DE DATOS'
    '***********************************************************************************************************************************************'

    Sub abrir()
        Try
            conexiones = New SqlConnection("Data Source=YENIER-VENEGAS;Initial Catalog=Tutorial;Integrated Security=True")
            conexiones.Open()
            MsgBox("Conexion exitosa", MsgBoxStyle.Information, "Se ha conectado correctamente") '
        Catch ex As Exception
            MsgBox("Error al realizar la conexion" & ex.Message, MsgBoxStyle.Critical, "Error de conexion")
            conexiones.Close() 'Cierra la conexion'
        End Try
    End Sub

    Sub consultarRegistrosEntreFechas(ByVal tabla As DataGridView, ByVal fechaI As Date, ByVal fechaF As Date)

        adaptador = New SqlDataAdapter("select * from Empleados where FechaNac between '" & fechaI & "' and '" & fechaF & "'", conexiones)
        Dim dataS As New DataSet
        adaptador.Fill(dataS, "Empleados")
        tabla.DataSource = dataS.Tables("Empleados")
       
    End Sub

End Module