Module Modulo_Consulte1
    Sub Consulta1(ByVal miSql As String)

        Conexion.Close()
        DS2.Tables.Clear()
        DT2.Rows.Clear()
        DT2.Columns.Clear()
        DS2.Clear()

        Conexion.Open()
        SC2.Connection = Conexion
        SC2.CommandText = miSql
        DA2.SelectCommand = SC2
        DA2.Fill(DT2)
        DS2.Tables.Add(DT2)
        Conexion.Close()

    End Sub

    Sub Consulta2(ByVal miSql As String)

        Conexion.Close()
        DS3.Tables.Clear()
        DT3.Rows.Clear()
        DT3.Columns.Clear()
        DS3.Clear()

        Conexion.Open()
        SC3.Connection = Conexion
        SC3.CommandText = miSql
        DA3.SelectCommand = SC3
        DA3.Fill(DT3)
        DS3.Tables.Add(DT3)
        Conexion.Close()

    End Sub

    Sub Consulta3(ByVal miSql As String)

        Conexion.Close()
        DS4.Tables.Clear()
        DT4.Rows.Clear()
        DT4.Columns.Clear()
        DS4.Clear()

        Conexion.Open()
        SC4.Connection = Conexion
        SC4.CommandText = miSql
        DA4.SelectCommand = SC4
        DA4.Fill(DT4)
        DS4.Tables.Add(DT4)
        Conexion.Close()

    End Sub

    Sub Consulta4(ByVal miSql As String)

        Conexion.Close()
        DS5.Tables.Clear()
        DT5.Rows.Clear()
        DT5.Columns.Clear()
        DS5.Clear()

        Conexion.Open()
        SC5.Connection = Conexion
        SC5.CommandText = miSql
        DA5.SelectCommand = SC5
        DA5.Fill(DT5)
        DS5.Tables.Add(DT5)
        Conexion.Close()

    End Sub

    Sub Consulta5(ByVal miSql As String)

        Conexion.Close()
        DS6.Tables.Clear()
        DT6.Rows.Clear()
        DT6.Columns.Clear()
        DS6.Clear()

        Conexion.Open()
        SC6.Connection = Conexion
        SC6.CommandText = miSql
        DA6.SelectCommand = SC6
        DA6.Fill(DT6)
        DS6.Tables.Add(DT6)
        Conexion.Close()

    End Sub

    Sub Consulta6(ByVal miSql As String)

        Conexion.Close()
        DS7.Tables.Clear()
        DT7.Rows.Clear()
        DT7.Columns.Clear()
        DS7.Clear()

        Conexion.Open()
        SC7.Connection = Conexion
        SC7.CommandText = miSql
        DA7.SelectCommand = SC7
        DA7.Fill(DT7)
        DS7.Tables.Add(DT7)
        Conexion.Close()

    End Sub

    Sub Consulta7(ByVal miSql As String)

        Conexion.Close()
        DS8.Tables.Clear()
        DT8.Rows.Clear()
        DT8.Columns.Clear()
        DS8.Clear()

        Conexion.Open()
        SC8.Connection = Conexion
        SC8.CommandText = miSql
        DA8.SelectCommand = SC8
        DA8.Fill(DT8)
        DS8.Tables.Add(DT8)
        Conexion.Close()

    End Sub

    Sub Consulta8(ByVal miSql As String)

        Conexion.Close()
        DS9.Tables.Clear()
        DT9.Rows.Clear()
        DT9.Columns.Clear()
        DS9.Clear()

        Conexion.Open()
        SC9.Connection = Conexion
        SC9.CommandText = miSql
        DA9.SelectCommand = SC9
        DA9.Fill(DT9)
        DS9.Tables.Add(DT9)
        Conexion.Close()

    End Sub

    Sub Consulta9(ByVal miSql As String)

        Conexion.Close()
        DS10.Tables.Clear()
        DT10.Rows.Clear()
        DT10.Columns.Clear()
        DS10.Clear()

        Conexion.Open()
        SC10.Connection = Conexion
        SC10.CommandText = miSql
        DA10.SelectCommand = SC10
        DA10.Fill(DT10)
        DS10.Tables.Add(DT10)
        Conexion.Close()

    End Sub

    Sub Consulta10(ByVal miSql As String)

        Conexion.Close()
        DS11.Tables.Clear()
        DT11.Rows.Clear()
        DT11.Columns.Clear()
        DS11.Clear()

        Conexion.Open()
        SC11.Connection = Conexion
        SC11.CommandText = miSql
        DA11.SelectCommand = SC11
        DA11.Fill(DT11)
        DS11.Tables.Add(DT11)
        Conexion.Close()

    End Sub

    Sub Consulta11(ByVal miSql As String)

        Conexion.Close()
        DS12.Tables.Clear()
        DT12.Rows.Clear()
        DT12.Columns.Clear()
        DS12.Clear()

        Conexion.Open()
        SC12.Connection = Conexion
        SC12.CommandText = miSql
        DA12.SelectCommand = SC12
        DA12.Fill(DT12)
        DS12.Tables.Add(DT12)
        Conexion.Close()

    End Sub

    Sub Consulta12(ByVal miSql As String)

        Conexion.Close()
        DS13.Tables.Clear()
        DT13.Rows.Clear()
        DT13.Columns.Clear()
        DS13.Clear()

        Conexion.Open()
        SC13.Connection = Conexion
        SC13.CommandText = miSql
        DA13.SelectCommand = SC13
        DA13.Fill(DT13)
        DS13.Tables.Add(DT13)
        Conexion.Close()

    End Sub

    Sub Consulta13(ByVal miSql As String)

        Conexion.Close()
        DS15.Tables.Clear()
        DT15.Rows.Clear()
        DT15.Columns.Clear()
        DS15.Clear()

        Conexion.Open()
        SC15.Connection = Conexion
        SC15.CommandText = miSql
        DA15.SelectCommand = SC15
        DA15.Fill(DT15)
        DS15.Tables.Add(DT15)
        Conexion.Close()

    End Sub
End Module
