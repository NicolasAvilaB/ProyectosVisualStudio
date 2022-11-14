Imports System.Data.OracleClient
Module Modulo_Conexiones
    Friend conexion As New OracleConnection
    Friend SC As New OracleCommand
    Friend DA As New OracleDataAdapter
    Friend DS As New DataSet()
    Friend DT As New DataTable

    Friend SC2 As New OracleCommand
    Friend DA2 As New OracleDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable
End Module
