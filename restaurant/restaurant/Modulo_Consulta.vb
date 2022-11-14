Module Modulo_Consulta
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
    Sub Consulta10(ByVal miSql10 As String)
        Conexion.Close()
        DS10.Tables.Clear()
        DT10.Rows.Clear()
        DT10.Columns.Clear()
        DS10.Clear()
        Conexion.Open()
        SC10.Connection = Conexion
        SC10.CommandText = miSql10
        DA10.SelectCommand = SC10
        DA10.Fill(DT10)
        DS10.Tables.Add(DT10)
        Conexion.Close()
    End Sub
    Sub Consulta11(ByVal miSql11 As String)
        Conexion.Close()
        DS11.Tables.Clear()
        DT11.Rows.Clear()
        DT11.Columns.Clear()
        DS11.Clear()
        Conexion.Open()
        SC11.Connection = Conexion
        SC11.CommandText = miSql11
        DA11.SelectCommand = SC11
        DA11.Fill(DT11)
        DS11.Tables.Add(DT11)
        Conexion.Close()
    End Sub
    Sub Consulta12(ByVal miSql12 As String)
        Conexion.Close()
        DS12.Tables.Clear()
        DT12.Rows.Clear()
        DT12.Columns.Clear()
        DS12.Clear()
        Conexion.Open()
        SC12.Connection = Conexion
        SC12.CommandText = miSql12
        DA12.SelectCommand = SC12
        DA12.Fill(DT12)
        DS12.Tables.Add(DT12)
        Conexion.Close()
    End Sub
    Sub Consulta13(ByVal miSql13 As String)
        Conexion.Close()
        DS13.Tables.Clear()
        DT13.Rows.Clear()
        DT13.Columns.Clear()
        DS13.Clear()
        Conexion.Open()
        SC13.Connection = Conexion
        SC13.CommandText = miSql13
        DA13.SelectCommand = SC13
        DA13.Fill(DT13)
        DS13.Tables.Add(DT13)
        Conexion.Close()
    End Sub
    Sub Consulta14(ByVal miSql14 As String)
        Conexion.Close()
        DS14.Tables.Clear()
        DT14.Rows.Clear()
        DT14.Columns.Clear()
        DS14.Clear()
        Conexion.Open()
        SC14.Connection = Conexion
        SC14.CommandText = miSql14
        DA14.SelectCommand = SC14
        DA14.Fill(DT14)
        DS14.Tables.Add(DT14)
        Conexion.Close()
    End Sub
    Sub Consulta15(ByVal miSql15 As String)
        Conexion.Close()
        DS15.Tables.Clear()
        DT15.Rows.Clear()
        DT15.Columns.Clear()
        DS15.Clear()
        Conexion.Open()
        SC15.Connection = Conexion
        SC15.CommandText = miSql15
        DA15.SelectCommand = SC15
        DA15.Fill(DT15)
        DS15.Tables.Add(DT15)
        Conexion.Close()
    End Sub
    Sub Consulta16(ByVal miSql16 As String)
        Conexion.Close()
        DS16.Tables.Clear()
        DT16.Rows.Clear()
        DT16.Columns.Clear()
        DS16.Clear()
        Conexion.Open()
        SC16.Connection = Conexion
        SC16.CommandText = miSql16
        DA16.SelectCommand = SC16
        DA16.Fill(DT16)
        DS16.Tables.Add(DT16)
        Conexion.Close()
    End Sub
    Sub Consulta17(ByVal miSql17 As String)
        Conexion.Close()
        DS17.Tables.Clear()
        DT17.Rows.Clear()
        DT17.Columns.Clear()
        DS17.Clear()
        Conexion.Open()
        SC17.Connection = Conexion
        SC17.CommandText = miSql17
        DA17.SelectCommand = SC17
        DA17.Fill(DT17)
        DS17.Tables.Add(DT17)
        Conexion.Close()
    End Sub
    Sub Consulta18(ByVal miSql18 As String)
        Conexion.Close()
        DS18.Tables.Clear()
        DT18.Rows.Clear()
        DT18.Columns.Clear()
        DS18.Clear()
        Conexion.Open()
        SC18.Connection = Conexion
        SC18.CommandText = miSql18
        DA18.SelectCommand = SC18
        DA18.Fill(DT18)
        DS18.Tables.Add(DT18)
        Conexion.Close()
    End Sub
    Sub Consulta19(ByVal miSql19 As String)
        Conexion.Close()
        DS19.Tables.Clear()
        DT19.Rows.Clear()
        DT19.Columns.Clear()
        DS19.Clear()
        Conexion.Open()
        SC19.Connection = Conexion
        SC19.CommandText = miSql19
        DA19.SelectCommand = SC19
        DA19.Fill(DT19)
        DS19.Tables.Add(DT19)
        Conexion.Close()
    End Sub
    Sub Consulta20(ByVal miSql20 As String)
        Conexion.Close()
        DS20.Tables.Clear()
        DT20.Rows.Clear()
        DT20.Columns.Clear()
        DS20.Clear()
        Conexion.Open()
        SC20.Connection = Conexion
        SC20.CommandText = miSql20
        DA20.SelectCommand = SC20
        DA20.Fill(DT20)
        DS20.Tables.Add(DT20)
        Conexion.Close()
    End Sub
    Sub Consulta21(ByVal miSql21 As String)
        Conexion.Close()
        DS21.Tables.Clear()
        DT21.Rows.Clear()
        DT21.Columns.Clear()
        DS21.Clear()
        Conexion.Open()
        SC21.Connection = Conexion
        SC21.CommandText = miSql21
        DA21.SelectCommand = SC21
        DA21.Fill(DT21)
        DS21.Tables.Add(DT21)
        Conexion.Close()
    End Sub
    Sub Consulta22(ByVal miSql22 As String)
        Conexion.Close()
        DS22.Tables.Clear()
        DT22.Rows.Clear()
        DT22.Columns.Clear()
        DS22.Clear()
        Conexion.Open()
        SC22.Connection = Conexion
        SC22.CommandText = miSql22
        DA22.SelectCommand = SC22
        DA22.Fill(DT22)
        DS22.Tables.Add(DT22)
        Conexion.Close()
    End Sub
End Module
