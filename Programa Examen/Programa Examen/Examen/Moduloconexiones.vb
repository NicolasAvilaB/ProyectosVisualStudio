Imports System.Data.SqlClient
Module Moduloconexiones
    Friend conexion As New SqlConnection
    Friend sc As New SqlCommand
    Friend da As New SqlDataAdapter
    Friend ds As New DataSet()
    Friend dt As New DataTable

    Friend sc2 As New SqlCommand
    Friend da2 As New SqlDataAdapter
    Friend ds2 As New DataSet()
    Friend dt2 As New DataTable

    Friend sc3 As New SqlCommand
    Friend da3 As New SqlDataAdapter
    Friend ds3 As New DataSet()
    Friend dt3 As New DataTable
End Module
