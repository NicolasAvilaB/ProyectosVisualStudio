VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmCuotas 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CUOTAS A PAGAR - RESTRUCTURACIÓN DE CUOTAS"
   ClientHeight    =   6570
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   12135
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmCuotas.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6570
   ScaleWidth      =   12135
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox cmbfechapago 
      BackColor       =   &H80000014&
      Height          =   315
      ItemData        =   "FrmCuotas.frx":030A
      Left            =   4440
      List            =   "FrmCuotas.frx":031A
      Style           =   2  'Dropdown List
      TabIndex        =   33
      Top             =   120
      Width           =   2415
   End
   Begin VB.TextBox txtidpago 
      Alignment       =   2  'Center
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   11760
      Locked          =   -1  'True
      MaxLength       =   15
      TabIndex        =   31
      Top             =   1080
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.CommandButton cmdrestructuracion 
      BackColor       =   &H80000013&
      Caption         =   "&RESTRUCTURACIÓN"
      Height          =   855
      Left            =   480
      Picture         =   "FrmCuotas.frx":033D
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   5640
      Width           =   2175
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   10560
      Picture         =   "FrmCuotas.frx":0647
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   5640
      Width           =   1455
   End
   Begin VB.CommandButton cmbreporte 
      BackColor       =   &H80000013&
      Caption         =   "&REPORTE"
      Height          =   855
      Left            =   1680
      Picture         =   "FrmCuotas.frx":0951
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   4680
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Height          =   855
      Left            =   1680
      Picture         =   "FrmCuotas.frx":0C5B
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   3720
      Width           =   1455
   End
   Begin VB.CommandButton CmdRecibo 
      BackColor       =   &H80000013&
      Caption         =   "&RECIBO"
      Height          =   855
      Left            =   120
      Picture         =   "FrmCuotas.frx":1CED
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   4680
      Width           =   1455
   End
   Begin VB.TextBox txtinteres 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   1560
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   23
      Top             =   2805
      Width           =   1455
   End
   Begin VB.TextBox txtvalorcuota 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   1560
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   21
      Top             =   2440
      Width           =   1455
   End
   Begin VB.VScrollBar VScroll1 
      Height          =   350
      Left            =   3000
      Max             =   -1
      Min             =   -36
      TabIndex        =   19
      Top             =   2085
      Value           =   -1
      Width           =   255
   End
   Begin VB.TextBox txcantidadcuota 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000014&
      Height          =   315
      Left            =   1560
      MaxLength       =   50
      TabIndex        =   18
      Top             =   2085
      Width           =   1455
   End
   Begin VB.TextBox txttotalcredito 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   1560
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   16
      Top             =   1725
      Width           =   1455
   End
   Begin VB.TextBox txtadelanto 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000014&
      Height          =   315
      Left            =   6960
      MaxLength       =   50
      TabIndex        =   14
      Text            =   "0.00"
      Top             =   1005
      Width           =   1335
   End
   Begin VB.TextBox txtmontocredito 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   4680
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   12
      Top             =   1005
      Width           =   1215
   End
   Begin VB.Frame frmopciones 
      BackColor       =   &H00B0726D&
      Height          =   615
      Left            =   120
      TabIndex        =   8
      Top             =   885
      Width           =   3015
      Begin VB.OptionButton opsinadelanto 
         BackColor       =   &H00B0726D&
         Caption         =   "Sin Adelanto"
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   1440
         TabIndex        =   10
         Top             =   240
         Width           =   1455
      End
      Begin VB.OptionButton optadelanto 
         BackColor       =   &H00B0726D&
         Caption         =   "Adelanto"
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   240
         TabIndex        =   9
         Top             =   240
         Value           =   -1  'True
         Width           =   1215
      End
   End
   Begin VB.TextBox txtcliente 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   960
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   7
      Top             =   480
      Width           =   4215
   End
   Begin VB.TextBox txtFecha 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   7800
      Locked          =   -1  'True
      MaxLength       =   20
      TabIndex        =   3
      Top             =   135
      Width           =   1335
   End
   Begin VB.TextBox txtNDocumento 
      Alignment       =   2  'Center
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   960
      Locked          =   -1  'True
      MaxLength       =   15
      TabIndex        =   2
      Top             =   120
      Width           =   1935
   End
   Begin VB.TextBox txttotalapagar 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   1560
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   1
      Top             =   3180
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3975
      Left            =   3360
      TabIndex        =   24
      Top             =   1560
      Width           =   8655
      _ExtentX        =   15266
      _ExtentY        =   7011
      _Version        =   393216
      BackColor       =   -2147483629
      ForeColor       =   -2147483647
      BackColorFixed  =   11563629
      ForeColorFixed  =   -2147483628
      BackColorSel    =   11563629
      ForeColorSel    =   65535
      BackColorBkg    =   -2147483629
      BackColorUnpopulated=   -2147483629
      GridColor       =   11563629
      FocusRect       =   0
      FillStyle       =   1
      SelectionMode   =   1
      AllowUserResizing=   3
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty FontFixed {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Height          =   855
      Left            =   120
      Picture         =   "FrmCuotas.frx":1FF7
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   3720
      Width           =   1455
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "Forma de Pago:"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3000
      TabIndex        =   32
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Interés"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   22
      Top             =   2805
      Width           =   735
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Valor Por Cuota"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   20
      Top             =   2445
      Width           =   1455
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad Cuota"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   17
      Top             =   2085
      Width           =   1455
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Total Crédito"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   15
      Top             =   1725
      Width           =   1215
   End
   Begin VB.Label lbladelanto 
      BackStyle       =   0  'Transparent
      Caption         =   "Adelanto"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   6120
      TabIndex        =   13
      Top             =   1005
      Width           =   975
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Monto Crédito"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3360
      TabIndex        =   11
      Top             =   1005
      Width           =   1215
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7080
      TabIndex        =   6
      Top             =   165
      Width           =   735
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Nº Doc."
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   5
      Top             =   180
      Width           =   855
   End
   Begin VB.Label Label14 
      BackStyle       =   0  'Transparent
      Caption         =   "Cliente"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   4
      Top             =   480
      Width           =   1215
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Total a Pagar"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   3180
      Width           =   1455
   End
End
Attribute VB_Name = "FrmCuotas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text

Private Const Crema = &H80000018
Const TB_Deuda As String = "SELECT Dueño.NomDueño,Dueño.ApeDueño, TB_Deuda.idpago, TB_Deuda.ndocumento, TB_Deuda.monto, TB_Deuda.ncuota,TB_deuda.adelanto,TB_Deuda.montoadelanto,TB_Deuda.totalcredito,TB_Deuda.valorxcuota,TB_Deuda.interes,TB_Deuda.totalapagar, TB_Deuda.observacion,tb_deuda.fechaxpago,TB_Deuda.moneda,TB_Deuda.tipcam FROM Dueño INNER JOIN TB_Deuda ON Dueño.CodDueño = TB_Deuda.CodDueño"
Const IDDEUDAST = "SELECT MAX(IDPAGO) FROM TB_DEUDA"
Friend Sub Montito()
  If optadelanto.Value = True Then
    txttotalcredito = Format$(Val(txtmontocredito) - Val(txtadelanto), "###.00")
  ElseIf opsinadelanto.Value = True Then
    txttotalcredito = Format$(Val(txtmontocredito), "###.00")
  End If
End Sub
Private Function DD(IDPAGO) As Double
On Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT COUNT(*) FROM FechaxCuotas WHERE IDPAGO='" + IDPAGO + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Exit Function
  End If
  D = T(0)
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Sub PELIMJ(S)
On Local Error GoTo L
 cn.Execute "DELETE * FROM TB_DEUDA WHERE IDPAGO='" + S + "'"
L:
End Sub
Friend Sub MuestraDatos()
  txtFECHA = FrmFacturacion.txtFECHA
  Dim T As New ADODB.Recordset
  T.Open TB_Deuda + " Where Dueño.NomDueño+' '+Dueño.ApeDueño ='" + FrmFacturacion.cmbcliente + "' AND TB_Deuda.ndocumento='" + FrmFacturacion.txtndocumento + "' AND TB_Deuda.IDDOCUMENTO='" + DevuelveIdDocumento(IIf(FrmFacturacion.OPTBOLETA.Value = True, "Boleta", "Factura")) + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    GoTo j
  End If
  DDDDDD = IIf(IsNull(T(2)) = True, "", T(2))
j:
  If T.State = adStateOpen Then T.Close
  If DD(DDDDDD) = 0 Then
  PELIMJ DDDDDD
  End If
  T.Open TB_Deuda + " Where Dueño.NomDueño+' '+Dueño.ApeDueño ='" + FrmFacturacion.cmbcliente + "' AND TB_Deuda.ndocumento='" + FrmFacturacion.txtndocumento + "' AND TB_Deuda.IDDOCUMENTO='" + DevuelveIdDocumento(IIf(FrmFacturacion.OPTBOLETA.Value = True, "Boleta", "Factura")) + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
      Set T = Nothing
      optadelanto.Value = True
      txtndocumento = FrmFacturacion.txtndocumento
      txtcliente = FrmFacturacion.cmbcliente
      txtidpago = GenerarCodigo(IDDEUDAST, 10)
      txtmontocredito = FrmFacturacion.TTOTAL
      txtadelanto = "0.00"
      txttotalcredito = FrmFacturacion.TTOTAL
      txcantidadcuota = 1
      VScroll1.Value = -1
      With MSHFlexGrid1
        .Cols = 7
        .Rows = 2
        .FormatString = "|<IdPago|<Cuotas|<Fecha a Pagar|>Monto|<Estado|<Restructuración"
        .ColWidth(0) = 0
        .ColWidth(1) = 0
        .ColWidth(2) = 900
        .ColWidth(3) = 1500
        .ColWidth(4) = 1500
        .ColWidth(5) = 1500
        .ColWidth(6) = 1500
      End With
      Call GuardarDatoNuevo
  ElseIf T.RecordCount > 0 Then
      txtcliente = T!NomDueño + " " + T!ApeDueño
      txtidpago = T!IDPAGO
      txtndocumento = T!ndocumento
      txtmontocredito = Format$(T!MONTO, "###.00")
      If T!adelanto = "Si" Then
        txtadelanto = Format$(T!montoadelanto, "###.00")
      ElseIf T!adelanto = "No" Then
        txtadelanto = "0.00"
      End If
      txttotalcredito = Format$(T!totalcredito, "###.00")
      txcantidadcuota = T!ncuota
      cmbfechapago = T!fechaxpago
      VScroll1.Value = T!ncuota * -1
      txtInteres = Format$(T!interes, "###.00")
      txttotalapagar = Format$(T!totalapagar, "###.00")
      Set T = Nothing
      Call p_RellenoDeta(MSHFlexGrid1, txtidpago)
  End If
  Call DesactivaT
End Sub

Private Sub cmbreporte_Click()
FrmReportes.Show 1
End Sub

Private Sub CmdAnular_Click()
  MuestraDatos
End Sub
Friend Function DesactivaT() As Double
On Local Error GoTo K
  If MSHFlexGrid1.TextMatrix(1, 1) <> "" Then
    DesactivaT = 1
  End If
  
  
  If DesactivaT > 0 Then
    frmopciones.Enabled = False
    txcantidadcuota.Locked = True
    txcantidadcuota.BackColor = Crema
    cmbfechapago.Locked = True
    cmbfechapago.BackColor = Crema
    VScroll1.Enabled = False
    txtadelanto.BackColor = Crema
    txtadelanto.Locked = True
  Else
    frmopciones.Enabled = True
    txcantidadcuota.Locked = False
    cmbfechapago.Locked = False
    cmbfechapago.BackColor = vbWhite
    txcantidadcuota.BackColor = vbWhite
    VScroll1.Enabled = True
    txtadelanto.BackColor = vbWhite
    txtadelanto.Locked = False
  End If
Exit Function
K:
MsgBox Err.Description, vbCritical
End Function

Friend Sub GuardarDatoNuevo()
On Local Error GoTo K
  Dim T As New ADODB.Recordset
  T.CursorType = adOpenDynamic
  T.LockType = adLockOptimistic
  T.Open "TB_DEUDA", cn, , , adCmdTable
  T.AddNew
  T!IDPAGO = txtidpago
  T!CodDueño = Devuelve_IdCliente(txtcliente)
  T!iddocumento = DevuelveIdDocumento(IIf(FrmFacturacion.OPTBOLETA.Value = True, "Boleta", "Factura"))
  T!ndocumento = txtndocumento
  T!MONTO = Val(txtmontocredito)
  T!ncuota = Val(txcantidadcuota)
  T!adelanto = IIf(opsinadelanto.Value = True, "No", "Si")
  T!montoadelanto = Val(txtadelanto)
  T!totalcredito = Val(txttotalcredito)
  T!valorxcuota = Val(txtvalorcuota)
  T!interes = Val(txtInteres)
  T!totalapagar = Val(txttotalapagar)
  T!moneda = IIf(FrmFacturacion.optsoles.Value = True, "1", "2")
  T!tipcam = Val(FrmFacturacion.txttipocambio)
  T!anulado = 0
  T.Update
  If T.State = adStateOpen Then T.Close
Exit Sub
K:
MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdGuardar_Click()
  If optadelanto.Value = True Then
    If Val(txtadelanto) <= 0 Then
      MsgBox "Ingresar Adelanto ...!", vbInformation
      Exit Sub
    End If
  End If
  If cmbfechapago = "" Then
    MsgBox "Ingrese Forma de Pago ...!", vbInformation
    cmbfechapago.SetFocus
    Exit Sub
  End If
  Call GuardarDatoEditado
  Call MuestraDatos
End Sub
Friend Sub GuardarDatoEditado()
On Local Error GoTo K
  Dim T As New ADODB.Recordset, SiCuotas As Double
  T.Open "Select idpago from fechaxcuotas where (estado='Cancelado' or restructuracion='Si') and idpago='" + txtidpago + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  SiCuotas = T.RecordCount
  'T.Clone
  If T.State = adStateOpen Then T.Close
  T.Open "select * from TB_DEUDA where idpago='" + txtidpago + "'", cn, adOpenDynamic, adLockOptimistic
  T!IDPAGO = txtidpago
  T!CodDueño = Devuelve_IdCliente(txtcliente)
  T!iddocumento = DevuelveIdDocumento(IIf(FrmFacturacion.OPTBOLETA.Value = True, "Boleta", "Factura"))
  T!ndocumento = txtndocumento
  T!MONTO = Val(txtmontocredito)
  If SiCuotas = 0 Then
    T!ncuota = Val(txcantidadcuota)
    T!adelanto = IIf(opsinadelanto.Value = True, "No", "Si")
    T!montoadelanto = Val(txtadelanto)
  End If
  T!totalcredito = Val(txttotalcredito)
  T!valorxcuota = Val(txtvalorcuota)
  T!interes = Val(txtInteres)
  T!totalapagar = Val(txttotalapagar)
  T!fechaxpago = cmbfechapago
  T!moneda = IIf(FrmFacturacion.optsoles.Value = True, "1", "2")
  T!tipcam = Val(FrmFacturacion.txttipocambio)
  T!anulado = 0
  T.Update
  If T.State = adStateOpen Then T.Close
  T.Open "Select count(idpago) from fechaxcuotas where idpago='" + txtidpago + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  TOtl = T(0)
  If T.State = adStateOpen Then T.Close
  Dim Fechita As Date
  
  If SiCuotas = 0 Then
    If TOtl > 0 Then
        x = EliminarTabla(txtidpago, "fechaxcuotas", "idpago")
    End If
    T.Open "Select * from fechaxcuotas where idpago='" + txtidpago + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
    Fechita = CDate(txtFECHA)
    For I% = 1 To Val(txcantidadcuota) Step 1
        T.AddNew
        T!IDPAGO = txtidpago
        T!CUOTA = GenerarCodigo("SELECT MAX(CUOTA) FROM fechaxcuotas WHERE IDPAGO='" + txtidpago + "'", 2)
        T!valorxcuota = Val(txttotalapagar)
        If cmbfechapago = "Semanal" Then
            Fechita = DateAdd("ww", 1, Fechita)   ' 1 SEMANA
        ElseIf cmbfechapago = "Quincenal" Then
            Fechita = DateAdd("w", 15, Fechita)   ' 15 DIAS
        ElseIf cmbfechapago = "Mensual" Then
            Fechita = DateAdd("m", 1, Fechita)   ' 1 MES
        End If
        T!fechaapagar = Fechita
        T!estado = "Sin Cancelar"
        T!restructuracion = "No"
        T.Update
    Next I
  End If
  If T.State = adStateOpen Then T.Close
Set T = Nothing
Exit Sub
K:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdRecibo_Click()
If optadelanto.Value = False Then Exit Sub
If MsgBox("¿Desea Emitir Recibo ...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
  DtRecibo.Show 1
End If
End Sub

Private Sub cmdrestructuracion_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
'  For I = 1 To MSHFlexGrid1.Rows - 1
'    If MSHFlexGrid1.TextMatrix(I, 6) = "Si" Then
'      MsgBox "Ya Se Ha Realizado Una Restructuración ...!", vbInformation
'      Exit Sub
'    End If
'  Next
  Dim SINCAN As Double, CONCAN As Double
  For I = 1 To MSHFlexGrid1.Rows - 1
    If MSHFlexGrid1.TextMatrix(I, 5) = "Sin Cancelar" Then
      SINCAN = SINCAN + 1
    End If
  Next
  For I = 1 To MSHFlexGrid1.Rows - 1
    If MSHFlexGrid1.TextMatrix(I, 5) = "Cancelado" Then
      CONCAN = CONCAN + 1
    End If
  Next
  If Not (CONCAN > 0 And SINCAN > 0) Then Exit Sub
  If MsgBox("¿Desea Realizar La Restructuración De La Deuda ...?", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then Exit Sub
  FrmCuotasRes.Show 1
End Sub


Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
Call MuestraDatos
V_CUOTASRESTRUCTURACION = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_CUOTASRESTRUCTURACION = False
End Sub

Private Sub opsinadelanto_Click()
  If opsinadelanto.Value = True Then
    txtadelanto.BackColor = Crema
    txtadelanto.Locked = True
    txtadelanto = "0.00"
    Montito
  End If
End Sub
Private Sub optadelanto_Click()
  If optadelanto.Value = True Then
    txtadelanto.Locked = False
    txtadelanto.BackColor = vbWhite
    Montito
  End If
End Sub
Private Sub txcantidadcuota_Change()
  txtvalorcuota = Format$(Val(txttotalcredito) / Val(txcantidadcuota), "###.00")
  txtInteres = Format$(DevuelveInteres * Val(txtvalorcuota) / 100, "###.00")
  txttotalapagar = Format$(Val(txtvalorcuota) + Val(txtInteres), "###.00")
  If Strings.Left(txtInteres, 1) = "." Then txtInteres = "0" + txtInteres
End Sub

Private Sub txcantidadcuota_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, SoloNumero
End Sub

Private Sub txcantidadcuota_LostFocus()
If Not (Val(txcantidadcuota) >= 1 And Val(txcantidadcuota) <= 36) Then
  txcantidadcuota = 1
  VScroll1.Value = -1
End If
End Sub

Private Sub txtadelanto_Change()
Call Montito
End Sub
Private Sub txtadelanto_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
End Sub

Private Sub VScroll1_Change()
txcantidadcuota = Val(VScroll1.Value) * -1
End Sub
