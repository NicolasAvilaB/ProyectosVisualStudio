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
    Sub Consulta2(ByVal miSql As String)
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
    Sub Consulta3(ByVal miSql As String)
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
    Sub Consulta4(ByVal miSql As String)
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
    Sub Consulta5(ByVal miSql As String)
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
    Sub Consulta7(ByVal miSql As String)
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
    Sub Consulta8(ByVal miSql As String)
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
    Sub Consulta9(ByVal miSql As String)
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
    Sub Consulta01(ByVal miSql As String)
        Conexion.Close()
        DS01.Tables.Clear()
        DT01.Rows.Clear()
        DT01.Columns.Clear()
        DS01.Clear()
        Conexion.Open()
        SC01.Connection = Conexion
        SC01.CommandText = miSql
        DA01.SelectCommand = SC01
        DA01.Fill(DT01)
        DS01.Tables.Add(DT01)
        Conexion.Close()
    End Sub
    Sub Consulta02(ByVal miSql As String)
        Conexion.Close()
        DS02.Tables.Clear()
        DT02.Rows.Clear()
        DT02.Columns.Clear()
        DS02.Clear()
        Conexion.Open()
        SC02.Connection = Conexion
        SC02.CommandText = miSql
        DA02.SelectCommand = SC02
        DA02.Fill(DT02)
        DS02.Tables.Add(DT02)
        Conexion.Close()
    End Sub
    Sub Consulta03(ByVal miSql As String)
        Conexion.Close()
        DS03.Tables.Clear()
        DT03.Rows.Clear()
        DT03.Columns.Clear()
        DS03.Clear()
        Conexion.Open()
        SC03.Connection = Conexion
        SC03.CommandText = miSql
        DA03.SelectCommand = SC03
        DA03.Fill(DT03)
        DS03.Tables.Add(DT03)
        Conexion.Close()
    End Sub
    Sub Consulta04(ByVal miSql As String)
        Conexion.Close()
        DS04.Tables.Clear()
        DT04.Rows.Clear()
        DT04.Columns.Clear()
        DS04.Clear()
        Conexion.Open()
        SC04.Connection = Conexion
        SC04.CommandText = miSql
        DA04.SelectCommand = SC04
        DA04.Fill(DT04)
        DS04.Tables.Add(DT04)
        Conexion.Close()
    End Sub
    Sub Consulta05(ByVal miSql As String)
        Conexion.Close()
        DS05.Tables.Clear()
        DT05.Rows.Clear()
        DT05.Columns.Clear()
        DS05.Clear()
        Conexion.Open()
        SC05.Connection = Conexion
        SC05.CommandText = miSql
        DA05.SelectCommand = SC05
        DA05.Fill(DT05)
        DS05.Tables.Add(DT05)
        Conexion.Close()
    End Sub
    Sub Consulta06(ByVal miSql As String)
        Conexion.Close()
        DS06.Tables.Clear()
        DT06.Rows.Clear()
        DT06.Columns.Clear()
        DS06.Clear()
        Conexion.Open()
        SC06.Connection = Conexion
        SC06.CommandText = miSql
        DA06.SelectCommand = SC06
        DA06.Fill(DT06)
        DS06.Tables.Add(DT06)
        Conexion.Close()
    End Sub
    Sub Consulta07(ByVal miSql As String)
        Conexion.Close()
        DS07.Tables.Clear()
        DT07.Rows.Clear()
        DT07.Columns.Clear()
        DS07.Clear()
        Conexion.Open()
        SC07.Connection = Conexion
        SC07.CommandText = miSql
        DA07.SelectCommand = SC07
        DA07.Fill(DT07)
        DS07.Tables.Add(DT07)
        Conexion.Close()
    End Sub
    Sub Consulta08(ByVal miSql As String)
        Conexion.Close()
        DS08.Tables.Clear()
        DT08.Rows.Clear()
        DT08.Columns.Clear()
        DS08.Clear()
        Conexion.Open()
        SC08.Connection = Conexion
        SC08.CommandText = miSql
        DA08.SelectCommand = SC08
        DA08.Fill(DT08)
        DS08.Tables.Add(DT08)
        Conexion.Close()
    End Sub
    Sub Consulta09(ByVal miSql As String)
        Conexion.Close()
        DS09.Tables.Clear()
        DT09.Rows.Clear()
        DT09.Columns.Clear()
        DS09.Clear()
        Conexion.Open()
        SC09.Connection = Conexion
        SC09.CommandText = miSql
        DA09.SelectCommand = SC09
        DA09.Fill(DT09)
        DS09.Tables.Add(DT09)
        Conexion.Close()
    End Sub
    Sub Consulta10(ByVal miSql As String)
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
    Sub Consulta11(ByVal miSql As String)
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
    Sub Consulta12(ByVal miSql As String)
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
    Sub Consulta13(ByVal miSql As String)
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
    Sub Consulta14(ByVal miSql As String)
        Conexion.Close()
        DS14.Tables.Clear()
        DT14.Rows.Clear()
        DT14.Columns.Clear()
        DS14.Clear()
        Conexion.Open()
        SC14.Connection = Conexion
        SC14.CommandText = miSql
        DA14.SelectCommand = SC14
        DA14.Fill(DT14)
        DS14.Tables.Add(DT14)
        Conexion.Close()
    End Sub
End Module
