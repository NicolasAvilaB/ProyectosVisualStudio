Imports MySql.Data.MySqlClient
Module Modulo_Conexion
    Friend Conexion As New MySqlConnection
    Friend SC As New MySqlCommand
    Friend DA As New MySqlDataAdapter
    Friend DS As New DataSet()
    Friend DT As New DataTable

    Friend SC2 As New MySqlCommand
    Friend DA2 As New MySqlDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable
End Module
