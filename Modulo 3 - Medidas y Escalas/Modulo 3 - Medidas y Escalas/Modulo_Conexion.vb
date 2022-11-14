Imports MySql.Data.MySqlClient
Module Modulo_Conexion
    Friend Conexion As New MySqlConnection("Database=modulo2notaventas;Data Source=localhost;User Id=root;Password=root")
    Friend SC As New MySqlCommand
    Friend DA As New MySqlDataAdapter
    Friend DS As New DataSet()
    Friend DT As New DataTable
    Friend SC2 As New MySqlCommand
    Friend DA2 As New MySqlDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable
    Sub Consulta(ByVal miSql As String)
        Conexion.Close()
        DS.Tables.Clear()
        DT.Rows.Clear()
        DT.Columns.Clear()
        DS.Clear()
        Conexion.Open()
        SC.Connection = Conexion
        SC.CommandText = miSql
        DA.SelectCommand = SC
        DA.Fill(DT)
        DS.Tables.Add(DT)
        Conexion.Close()
    End Sub
    Sub Consulta2(ByVal miSql2 As String)
        Conexion.Close()
        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()
        Conexion.Open()
        SC2.Connection = Conexion
        SC2.CommandText = miSql2
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        Conexion.Close()
    End Sub
End Module
