Imports Npgsql
Module Modulo_Conexion
    Friend Conexion_Mysql As New NpgsqlConnection
    Friend SC As New NpgsqlCommand
    Friend DA As New NpgsqlDataAdapter
    Friend DS As New DataSet()
    Friend DT As New DataTable

    Friend SC2 As New NpgsqlCommand
    Friend DA2 As New NpgsqlDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable
End Module
