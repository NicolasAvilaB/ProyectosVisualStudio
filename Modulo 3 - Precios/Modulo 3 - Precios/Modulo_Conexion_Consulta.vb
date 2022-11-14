Imports MySql.Data.MySqlClient
Module Modulo_Conexion_Consulta
    Friend Conexion As New MySqlConnection("Database=modulo2notaventas;Data Source=localhost;User Id=root;Password=root")
    Friend SC As New MySqlCommand
    Friend DA As New MySqlDataAdapter
    Friend DS As New DataSet()
    Friend DT As New DataTable
    Friend SC2 As New MySqlCommand
    Friend DA2 As New MySqlDataAdapter
    Friend DS2 As New DataSet()
    Friend DT2 As New DataTable
    Friend SC3 As New MySqlCommand
    Friend DA3 As New MySqlDataAdapter
    Friend DS3 As New DataSet()
    Friend DT3 As New DataTable
    Friend SC4 As New MySqlCommand
    Friend DA4 As New MySqlDataAdapter
    Friend DS4 As New DataSet()
    Friend DT4 As New DataTable
    Friend SC5 As New MySqlCommand
    Friend DA5 As New MySqlDataAdapter
    Friend DS5 As New DataSet()
    Friend DT5 As New DataTable
    Friend SC6 As New MySqlCommand
    Friend DA6 As New MySqlDataAdapter
    Friend DS6 As New DataSet()
    Friend DT6 As New DataTable
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
    Sub Consulta3(ByVal miSql3 As String)
        Conexion.Close()
        DS3.Tables.Clear()
        DT3.Rows.Clear()
        DT3.Columns.Clear()
        DS3.Clear()
        Conexion.Open()
        SC3.Connection = Conexion
        SC3.CommandText = miSql3
        DA3.SelectCommand = SC3
        DA3.Fill(DT3)
        DS3.Tables.Add(DT3)
        Conexion.Close()
    End Sub
    Sub Consulta4(ByVal miSql4 As String)
        Conexion.Close()
        DS4.Tables.Clear()
        DT4.Rows.Clear()
        DT4.Columns.Clear()
        DS4.Clear()
        Conexion.Open()
        SC4.Connection = Conexion
        SC4.CommandText = miSql4
        DA4.SelectCommand = SC4
        DA4.Fill(DT4)
        DS4.Tables.Add(DT4)
        Conexion.Close()
    End Sub
    Sub Consulta5(ByVal miSql5 As String)
        Conexion.Close()
        DS5.Tables.Clear()
        DT5.Rows.Clear()
        DT5.Columns.Clear()
        DS5.Clear()
        Conexion.Open()
        SC5.Connection = Conexion
        SC5.CommandText = miSql5
        DA5.SelectCommand = SC5
        DA5.Fill(DT5)
        DS5.Tables.Add(DT5)
        Conexion.Close()
    End Sub
    Sub Consulta6(ByVal miSql6 As String)
        Conexion.Close()
        DS6.Tables.Clear()
        DT6.Rows.Clear()
        DT6.Columns.Clear()
        DS6.Clear()
        Conexion.Open()
        SC6.Connection = Conexion
        SC6.CommandText = miSql6
        DA6.SelectCommand = SC6
        DA6.Fill(DT6)
        DS6.Tables.Add(DT6)
        Conexion.Close()
    End Sub
End Module
