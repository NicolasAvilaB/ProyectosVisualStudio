Imports MySql.Data.MySqlClient
Module Modulo_Conexion_Consulta
    Public valor_ventana As Integer
    Public valor_cancelar_busqueda As Integer
    Public valordgv As Integer
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
    Friend SC7 As New MySqlCommand
    Friend DA7 As New MySqlDataAdapter
    Friend DS7 As New DataSet()
    Friend DT7 As New DataTable
    Friend SC8 As New MySqlCommand
    Friend DA8 As New MySqlDataAdapter
    Friend DS8 As New DataSet()
    Friend DT8 As New DataTable
    Friend SC9 As New MySqlCommand
    Friend DA9 As New MySqlDataAdapter
    Friend DS9 As New DataSet()
    Friend DT9 As New DataTable
    Friend SC0 As New MySqlCommand
    Friend DA0 As New MySqlDataAdapter
    Friend DS0 As New DataSet()
    Friend DT0 As New DataTable
    Friend SC00 As New MySqlCommand
    Friend DA00 As New MySqlDataAdapter
    Friend DS00 As New DataSet()
    Friend DT00 As New DataTable
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
    Sub Consulta7(ByVal miSql7 As String)
        Conexion.Close()
        DS7.Tables.Clear()
        DT7.Rows.Clear()
        DT7.Columns.Clear()
        DS7.Clear()
        Conexion.Open()
        SC7.Connection = Conexion
        SC7.CommandText = miSql7
        DA7.SelectCommand = SC7
        DA7.Fill(DT7)
        DS7.Tables.Add(DT7)
        Conexion.Close()
    End Sub
    Sub Consulta8(ByVal miSql8 As String)
        Conexion.Close()
        DS8.Tables.Clear()
        DT8.Rows.Clear()
        DT8.Columns.Clear()
        DS8.Clear()
        Conexion.Open()
        SC8.Connection = Conexion
        SC8.CommandText = miSql8
        DA8.SelectCommand = SC8
        DA8.Fill(DT8)
        DS8.Tables.Add(DT8)
        Conexion.Close()
    End Sub
    Sub Consulta9(ByVal miSql9 As String)
        Conexion.Close()
        DS9.Tables.Clear()
        DT9.Rows.Clear()
        DT9.Columns.Clear()
        DS9.Clear()
        Conexion.Open()
        SC9.Connection = Conexion
        SC9.CommandText = miSql9
        DA9.SelectCommand = SC9
        DA9.Fill(DT9)
        DS9.Tables.Add(DT9)
        Conexion.Close()
    End Sub
    Sub Consulta0(ByVal miSql0 As String)
        Conexion.Close()
        DS0.Tables.Clear()
        DT0.Rows.Clear()
        DT0.Columns.Clear()
        DS0.Clear()
        Conexion.Open()
        SC0.Connection = Conexion
        SC0.CommandText = miSql0
        DA0.SelectCommand = SC0
        DA0.Fill(DT0)
        DS0.Tables.Add(DT0)
        Conexion.Close()
    End Sub
    Sub Consulta00(ByVal miSql00 As String)
        Conexion.Close()
        DS00.Tables.Clear()
        DT00.Rows.Clear()
        DT00.Columns.Clear()
        DS00.Clear()
        Conexion.Open()
        SC00.Connection = Conexion
        SC00.CommandText = miSql00
        DA00.SelectCommand = SC00
        DA00.Fill(DT00)
        DS00.Tables.Add(DT00)
        Conexion.Close()
    End Sub
End Module
