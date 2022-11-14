VERSION 5.00
Object = "{8767A745-088E-4CA6-8594-073D6D2DE57A}#9.2#0"; "crviewer9.dll"
Begin VB.Form FrmReportes 
   BackColor       =   &H00B0726D&
   ClientHeight    =   2265
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   3795
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmReportes.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   2265
   ScaleWidth      =   3795
   StartUpPosition =   2  'CenterScreen
   WindowState     =   2  'Maximized
   Begin VB.Timer Timer1 
      Interval        =   10000
      Left            =   2040
      Top             =   600
   End
   Begin CRVIEWER9LibCtl.CRViewer9 CRViewer91 
      Height          =   1335
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   1575
      lastProp        =   500
      _cx             =   2778
      _cy             =   2355
      DisplayGroupTree=   -1  'True
      DisplayToolbar  =   -1  'True
      EnableGroupTree =   -1  'True
      EnableNavigationControls=   -1  'True
      EnableStopButton=   -1  'True
      EnablePrintButton=   -1  'True
      EnableZoomControl=   -1  'True
      EnableCloseButton=   -1  'True
      EnableProgressControl=   -1  'True
      EnableSearchControl=   -1  'True
      EnableRefreshButton=   -1  'True
      EnableDrillDown =   -1  'True
      EnableAnimationControl=   -1  'True
      EnableSelectExpertButton=   0   'False
      EnableToolbar   =   -1  'True
      DisplayBorder   =   -1  'True
      DisplayTabs     =   -1  'True
      DisplayBackgroundEdge=   -1  'True
      SelectionFormula=   ""
      EnablePopupMenu =   -1  'True
      EnableExportButton=   0   'False
      EnableSearchExpertButton=   0   'False
      EnableHelpButton=   0   'False
      LaunchHTTPHyperlinksInNewBrowser=   -1  'True
   End
End
Attribute VB_Name = "FrmReportes"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Reporte As New CRAXDRT.Report
Dim Aplicacion As New CRAXDRT.Application
Dim Parametro As CRAXDRT.ParameterFieldDefinition
Dim Parametros As CRAXDRT.ParameterFieldDefinitions
Dim DATO(0 To 5) As String
Dim Valo(0 To 5) As Double
Dim fec(0 To 1) As Date
Sub Muestra_Reporte()
On Error GoTo L
If V_INFORMCITAS = True Then
   Caption = "REPORTE DE LISTA DE CITAS"
   If FrmInformeListaCitas.optmasota.Value = True Then
    Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcitas.rpt", 1)
    Set Parametros = Reporte.ParameterFields
    For Each Parametro In Parametros
        Select Case Parametro.ParameterFieldName
            Case "codmascota"
                 DATO(0) = FrmInformeListaCitas.txtcodd
                 Parametro.AddCurrentValue DATO(0)
            Case "fecha1"
               fec(0) = CDate(FrmInformeListaCitas.txtf1)
               Parametro.AddCurrentValue fec(0)
            Case "fecha2"
               fec(1) = CDate(FrmInformeListaCitas.txtf2)
               Parametro.AddCurrentValue fec(1)
        End Select
    Next
   Else
       Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcitasfecha.rpt", 1)
    Set Parametros = Reporte.ParameterFields
    For Each Parametro In Parametros
        Select Case Parametro.ParameterFieldName
            Case "fecha1"
               fec(0) = CDate(FrmInformeListaCitas.txtf1)
               Parametro.AddCurrentValue fec(0)
            Case "fecha2"
               fec(1) = CDate(FrmInformeListaCitas.txtf2)
               Parametro.AddCurrentValue fec(1)
        End Select
    Next
   End If
End If
If V_INFORMDEMASCOTAS = True Then
  Caption = "REPORTE DE LISTA DE MASCOTAS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptlistamascotas.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "codmascota"
              DATO(0) = FRMlisademascotasavacuna.txtcodd
              Parametro.AddCurrentValue DATO(0)
           Case "fecha1"
              fec(0) = CDate(FRMlisademascotasavacuna.txtf1)
              Parametro.AddCurrentValue fec(0)
           Case "fecha2"
              fec(1) = CDate(FRMlisademascotasavacuna.txtf2)
              Parametro.AddCurrentValue fec(1)
           Case "descripcion"
              DATO(0) = FRMlisademascotasavacuna.cmbexamcom
              Parametro.AddCurrentValue DATO(0)
       End Select
   Next
End If
If V_INFORMDEENFERMEDEDAS = True Then
  Caption = "REPORTE DE ENFERMEDADES"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptenfermedades.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If

If V_GRAFICO = 1 Then
  Caption = "ESTADÍSTICA DE CLIENTES POR DISTRITOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcliexdisbarras.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If

If V_GRAFICO = 2 Then
  Caption = "ESTADÍSTICA DE CLIENTES POR DISTRITOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcliexdistarta.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If

If V_GRAFICOINGRESS = 1 Then
  Caption = "ESTADÍSTICA DE INGRESOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptingresosbarras.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If
If V_GRAFICOINGRESS = 2 Then
  Caption = "ESTADÍSTICA DE INGRESOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptingresostarta.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If
If V_INGRESOS = True Then
  Caption = "REPORTE DE INGRESOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptingresos.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "fecha1"
              fec(0) = CDate(FrmIngresos.txtf1)
              Parametro.AddCurrentValue fec(0)
           Case "fecha2"
              fec(1) = CDate(FrmIngresos.txtf2)
              Parametro.AddCurrentValue fec(1)
       End Select
   Next
End If
If V_DEUDASS = True Then
  Caption = "REPORTE DE DEUDAS DE CRÉDITOS"
     If FrmDeudas.Option1.Value = True Then
    Set Reporte = Aplicacion.OpenReport(App.Path + "\rptdeuditas.rpt", 1)
    
    Set Parametros = Reporte.ParameterFields
    For Each Parametro In Parametros
        Select Case Parametro.ParameterFieldName
            Case "fecha1"
               fec(0) = CDate(FrmDeudas.txtf1)
               Parametro.AddCurrentValue fec(0)
            Case "fecha2"
               fec(1) = CDate(FrmDeudas.txtf2)
               Parametro.AddCurrentValue fec(1)
        End Select
    Next
    End If
      If FrmDeudas.Option2.Value = True Then
    Set Reporte = Aplicacion.OpenReport(App.Path + "\rptdeuditasporcliente.rpt", 1)
    
    Set Parametros = Reporte.ParameterFields
    For Each Parametro In Parametros
        Select Case Parametro.ParameterFieldName
              Case "nom"
                            DATO(1) = FrmDeudas.Text1
               Parametro.AddCurrentValue DATO(1)
             Case "ape"
                            DATO(1) = FrmDeudas.Text2
               Parametro.AddCurrentValue DATO(1)
        End Select
    Next
    End If
   
End If

If V_MOROS = 1 Then
  Caption = "LISTA DE CLIENTES MOROSOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptmorosos.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "fecha1"
              Parametro.AddCurrentValue Date
       End Select
   Next
End If
If V_EXAMEN = True Then
  Caption = "LISTA DE EXÁMENES COMPLEMENTARIOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptexamenes.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If
If V_SERVICIOS = True Then
  Caption = "LISTA DE SERVICIOS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptservicios.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If
If V_CLIENE = True Then
  Caption = "LISTA DE CLIENTES"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptlistaclientes.rpt", 1)
    CRViewer91.Refresh
    CRViewer91.RefreshEx True
End If
If V_NOTAINGR = True Then
  Caption = "NOTA DE INGRESO"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptnotaingre.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "nnota"
              DATO(0) = "I" + FrmNotaIngreso.txtNK
              Parametro.AddCurrentValue DATO(0)
           Case "subtotal"
              Valo(0) = Val(FrmNotaIngreso.txtsubtotal)
              Parametro.AddCurrentValue Valo(0)
           Case "igv"
              Valo(0) = Val(FrmNotaIngreso.txtIGV)
              Parametro.AddCurrentValue Valo(0)
           Case "total"
              Valo(0) = Val(FrmNotaIngreso.txttotal)
              Parametro.AddCurrentValue Valo(0)
          Case "digv"
              DATO(0) = CStr(Val(FrmNotaIngreso.txtDescuento))
              Parametro.AddCurrentValue DATO(0)
          Case "letras"
              DATO(0) = FrmNotaIngreso.lblletras.Caption
              Parametro.AddCurrentValue DATO(0)
       End Select
   Next
End If
If V_NOTASALI = True Then
  Caption = "NOTA DE SALIDA"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptnotasali.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "nnota"
              DATO(0) = "S" + FrmNotaSalida.txtNK
              Parametro.AddCurrentValue DATO(0)
           Case "subtotal"
              Valo(0) = Val(FrmNotaSalida.txtsubtotal)
              Parametro.AddCurrentValue Valo(0)
          Case "letras"
              DATO(0) = FrmNotaSalida.lblletras.Caption
              Parametro.AddCurrentValue DATO(0)
       End Select
   Next
End If
If V_FACTURACION = True Then
  Caption = "FACTURACIÓN"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptfactura.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "ndoc"
              DATO(0) = FrmFacturacion.txtndocumento
              Parametro.AddCurrentValue DATO(0)
           Case "subtotal"
              Valo(0) = Val(FrmFacturacion.TSUBTOTAL)
              Parametro.AddCurrentValue Valo(0)
          Case "letras"
              DATO(0) = FrmFacturacion.lblletras.Caption
              Parametro.AddCurrentValue DATO(0)
          Case "descuento"
              Valo(0) = Val(FrmFacturacion.TDESCUENTO)
              Parametro.AddCurrentValue Valo(0)
          Case "igv"
              Valo(0) = Val(FrmFacturacion.TIGV)
              Parametro.AddCurrentValue Valo(0)
          Case "total"
              Valo(0) = Val(FrmFacturacion.TTOTAL)
              Parametro.AddCurrentValue Valo(0)
          Case "desdoc"
              DATO(0) = IIf(FrmFacturacion.OPTBOLETA.Value = True, "BOLETA", "FACTURA")
              Parametro.AddCurrentValue DATO(0)
       End Select
   Next
End If
If V_CUOTASRESTRUCTURACION = True Then
  Caption = "REPORTE DE CUOTAS"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptReporteCuotas.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "idpago"
              DATO(0) = FrmCuotas.txtidpago
              Parametro.AddCurrentValue DATO(0)
           Case "deudatotal"
              f = 0
              For I = 1 To FrmCuotas.MSHFlexGrid1.Rows - 1
                If FrmCuotas.MSHFlexGrid1.TextMatrix(I, 5) = "Sin Cancelar" And FrmCuotas.MSHFlexGrid1.TextMatrix(I, 6) = "No" Then
                  f = f + Val(FrmCuotas.MSHFlexGrid1.TextMatrix(I, 4))
                  End If
              Next
              Parametro.AddCurrentValue f
              Case "tol"
               f = 0
              For I = 1 To FrmCuotas.MSHFlexGrid1.Rows - 1
                If FrmCuotas.MSHFlexGrid1.TextMatrix(I, 5) = "Sin Cancelar" And FrmCuotas.MSHFlexGrid1.TextMatrix(I, 6) = "No" Then
                  f = f + 1
                  End If
              Next
              Parametro.AddCurrentValue CStr(f)
       End Select
   Next
End If
If V_PAGOCREDITOSVENTAS Then
  Caption = "RECIBO"
   Set Reporte = Aplicacion.OpenReport(App.Path + "\rptRecibo.rpt", 1)
   Set Parametros = Reporte.ParameterFields
   For Each Parametro In Parametros
       Select Case Parametro.ParameterFieldName
           Case "idpago"
              DATO(0) = FrmPagos.txtidpago
              Parametro.AddCurrentValue DATO(0)
           Case "fechacuota"
              fec(0) = CDate(FrmPagos.txtefchacuota)
              Parametro.AddCurrentValue fec(0)
           Case "pagocuota"
              Valo(0) = Val(FrmPagos.TXTPAGOPORCUOTA)
              Parametro.AddCurrentValue Valo(0)
           Case "mora"
              Valo(0) = Val(FrmPagos.txtmora)
              Parametro.AddCurrentValue Valo(0)
           Case "total"
              Valo(0) = Val(FrmPagos.txttotalapagar)
              Parametro.AddCurrentValue Valo(0)
          Case "ncuota"
               DATO(0) = FrmPagos.txNcuota
              Parametro.AddCurrentValue DATO(0)
          Case "simbolo"
              DATO(0) = Devuelve_simbolo_de_TB_DEUDA(FrmPagos.txtidpago)
              Parametro.AddCurrentValue DATO(0)
       End Select
   Next
End If
If V_FrmCatalogodeProductos = True Then

  If FrmCatalogodeProductos.opttodos.Value = True Then
      Caption = "CATÁLOGO DE PRODUCTOS"
      Set Reporte = Aplicacion.OpenReport(App.Path + "\rptproductos.rpt", 1)
  End If
  If FrmCatalogodeProductos.optporcategoria.Value = True Then
       Caption = "PRODUCTOS POR CATEGORÍA"
      Set Reporte = Aplicacion.OpenReport(App.Path + "\rptproductosxcategoria.rpt", 1)
      Set Parametros = Reporte.ParameterFields
      For Each Parametro In Parametros
          Select Case Parametro.ParameterFieldName
              Case "categoria"
                 DATO(0) = FrmCatalogodeProductos.txtcategoria
                 Parametro.AddCurrentValue DATO(0)
          End Select
      Next
  End If

  If FrmCatalogodeProductos.optporsubcategoria.Value = True Then
       Caption = "PRODUCTOS POR SUB-CATEGORÍA"
      Set Reporte = Aplicacion.OpenReport(App.Path + "\rptproductosxsubcategoria.rpt", 1)
      Set Parametros = Reporte.ParameterFields
      For Each Parametro In Parametros
          Select Case Parametro.ParameterFieldName
              Case "subcategoria"
                 DATO(0) = FrmCatalogodeProductos.txtsubcategoria
                 Parametro.AddCurrentValue DATO(0)
          End Select
      Next
  End If
  If FrmCatalogodeProductos.optpomarca.Value = True Then
       Caption = "PRODUCTOS POR MARCA"
      Set Reporte = Aplicacion.OpenReport(App.Path + "\rptproductosxmarca.rpt", 1)
      Set Parametros = Reporte.ParameterFields
      For Each Parametro In Parametros
          Select Case Parametro.ParameterFieldName
              Case "marca"
                 DATO(0) = FrmCatalogodeProductos.txtmarca
                 Parametro.AddCurrentValue DATO(0)
          End Select
      Next
  End If
  
  If FrmCatalogodeProductos.optporproveedor.Value = True Then
       Caption = "PRODUCTOS POR PROVEEDOR"
      Set Reporte = Aplicacion.OpenReport(App.Path + "\rptproductosxproveedor.rpt", 1)
      Set Parametros = Reporte.ParameterFields
      For Each Parametro In Parametros
          Select Case Parametro.ParameterFieldName
              Case "proveedor"
                 DATO(0) = FrmCatalogodeProductos.txtproveedor
                 Parametro.AddCurrentValue DATO(0)
          End Select
      Next
  End If
End If

  If V_KARDEX = True Then
      If FrmKardex.opttodos.Value = True Then
            Caption = "KARDEX DE ALMACÉN"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptKardex.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmKardex.txtfecha1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmKardex.txtfecha2)
                        Parametro.AddCurrentValue fec(0)
                 End Select
             Next
      End If
      If FrmKardex.optporcategoria.Value = True Then
            Caption = "KARDEX DE ALMACÉN POR CATEGORÍA"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptKardexxcategoria.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmKardex.txtf1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmKardex.txtf2)
                        Parametro.AddCurrentValue fec(0)
                    Case "categoria"
                        DATO(0) = FrmKardex.txtcategoria
                        Parametro.AddCurrentValue DATO(0)
                  End Select
             Next
      End If
      If FrmKardex.optporsubcategoria.Value = True Then
            Caption = "KARDEX DE ALMACÉN POR SUB-CATEGORÍA"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptKardexxsubcategoria.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmKardex.t1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmKardex.t2)
                        Parametro.AddCurrentValue fec(0)
                    Case "subcategoria"
                        DATO(0) = FrmKardex.txtsubcategoria
                        Parametro.AddCurrentValue DATO(0)
                  End Select
             Next
      End If
      If FrmKardex.optpomarca.Value = True Then
            Caption = "KARDEX DE ALMACÉN POR MARCA"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptKardexxmarca.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmKardex.tm1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmKardex.tm2)
                        Parametro.AddCurrentValue fec(0)
                    Case "marca"
                        DATO(0) = FrmKardex.txtmarca
                        Parametro.AddCurrentValue DATO(0)
                  End Select
             Next
      End If
  End If
  If V_REGISTRODECOMPRAS = True Then
             Caption = "REGISTRO DE COMPRAS"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptregistrocompras.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmRegCompras.tm1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmRegCompras.tm2)
                        Parametro.AddCurrentValue fec(0)
                  End Select
             Next
  End If
  If V_REGISTRODEVENTAS = True Then
             Caption = "REGISTRO DE VENTAS"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptregistroventas.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        fec(0) = CDate(FrmRegVentas.tm1)
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        fec(0) = CDate(FrmRegVentas.tm2)
                        Parametro.AddCurrentValue fec(0)
                  End Select
             Next
  End If
  If V_CUENTASPORCOBRARCLIENTES = True Then
    Caption = "CUENTAS POR COBRAR (CLIENTES)"
    Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcuentasxcobrar.rpt", 1)
   End If
   
   If V_CUENTACORRIENTESSSS = True Then
                Caption = "CUENTA CORRIENTE"
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptcuentacorriente.rpt", 1)
             Set Parametros = Reporte.ParameterFields
             For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "credito"
                        DATO(0) = FrmCuentaCorriente.txtcredito
                        Parametro.AddCurrentValue DATO(0)
                     Case "deuda"
                        DATO(0) = FrmCuentaCorriente.txtdeuda
                        Parametro.AddCurrentValue DATO(0)
                      Case "desdocumento"
                        DATO(0) = FrmCuentaCorriente.cmbdocumento
                        Parametro.AddCurrentValue DATO(0)
                      Case "ndocumento"
                        DATO(0) = FrmCuentaCorriente.cmbndocumento
                        Parametro.AddCurrentValue DATO(0)
                      Case "cliente"
                        DATO(0) = FrmCuentaCorriente.TxtCLIEWNTE
                        Parametro.AddCurrentValue DATO(0)
                       Case "cuot"
                        DATO(0) = FrmCuentaCorriente.Text1
                        Parametro.AddCurrentValue DATO(0)
                  End Select
             Next
   End If
     If V_PROMOTORVENTAS = True Then
             Caption = "VENTAS POR PROMOTOR"
        If frmventasporpromotor.Option1.Value = True Then
            fec(0) = CDate(frmventasporpromotor.txtf1.Text)
            fec(1) = CDate(frmventasporpromotor.txtf2.Text)
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptVentasporpromotor.rpt", 1)
             Set Parametros = Reporte.ParameterFields
              For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        Parametro.AddCurrentValue fec(1)
                  End Select
             Next
        ElseIf frmventasporpromotor.Option2.Value = True Then
            fec(0) = CDate(frmventasporpromotor.txtfecha1.Text)
            fec(1) = CDate(frmventasporpromotor.txtfecha2.Text)
            DATO(0) = frmventasporpromotor.cmbpromotor
             Set Reporte = Aplicacion.OpenReport(App.Path + "\rptVentasporpromotor2.rpt", 1)
             Set Parametros = Reporte.ParameterFields
               For Each Parametro In Parametros
                 Select Case Parametro.ParameterFieldName
                     Case "fecha1"
                        Parametro.AddCurrentValue fec(0)
                     Case "fecha2"
                        Parametro.AddCurrentValue fec(1)
                      Case "promotor"
                        Parametro.AddCurrentValue DATO(0)
                  End Select
             Next
        End If
  End If
With CRViewer91
    .ReportSource = Reporte
    .EnableGroupTree = False
    .EnableExportButton = True
    .EnableRefreshButton = True
    .ViewReport
End With
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Private Sub Form_Activate()
  Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me

End Sub

Private Sub Form_Load()
  Screen.MousePointer = vbHourglass
  Call Muestra_Reporte
End Sub
Private Sub Form_Resize()
  CRViewer91.Width = ScaleWidth
  CRViewer91.Height = ScaleHeight
End Sub
Private Sub Form_Unload(Cancel As Integer)
  V_SERVICIOS = False
  V_EXAMEN = False
  V_CLIENE = False
  V_CUENTASPORCOBRARCLIENTES = False
  V_MOROS = 0
  V_INFORMDEENFERMEDEDAS = False
  Set FrmReportes = Nothing
End Sub

Private Sub Timer1_Timer()
If V_GRAFICOINGRESS = 1 Or V_GRAFICOINGRESS = 2 Then
CRViewer91.RefreshEx True
End If
Timer1.Enabled = False
End Sub
