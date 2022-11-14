VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmCuotasRes 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "RESTRUCTURACIÓN"
   ClientHeight    =   2505
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5160
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
   Icon            =   "FrmCuotasRes.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2505
   ScaleWidth      =   5160
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtfecha 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000014&
      Height          =   315
      Left            =   2280
      MaxLength       =   50
      TabIndex        =   6
      Top             =   1080
      Width           =   1335
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Height          =   855
      Left            =   1200
      Picture         =   "FrmCuotasRes.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1560
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   2880
      Picture         =   "FrmCuotasRes.frx":0BD4
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1560
      Width           =   1455
   End
   Begin VB.TextBox txcantidadcuota 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000014&
      Height          =   315
      Left            =   2280
      MaxLength       =   50
      TabIndex        =   1
      Text            =   "1"
      Top             =   720
      Width           =   1335
   End
   Begin VB.VScrollBar VScroll1 
      Height          =   350
      Left            =   3600
      Max             =   -1
      Min             =   -36
      TabIndex        =   0
      Top             =   720
      Value           =   -1
      Width           =   255
   End
   Begin MSComCtl2.DTPicker dtm1 
      Height          =   315
      Left            =   3600
      TabIndex        =   8
      Top             =   1080
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   556
      _Version        =   393216
      Format          =   48496641
      CurrentDate     =   39318
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   840
      TabIndex        =   7
      Top             =   1080
      Width           =   1455
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackColor       =   &H80000008&
      BorderStyle     =   1  'Fixed Single
      Caption         =   "INGRESAR CUOTAS NUEVAS DE RESTRUTURACIÓN"
      ForeColor       =   &H8000000E&
      Height          =   495
      Left            =   240
      TabIndex        =   5
      Top             =   120
      Width           =   4695
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad Cuota"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   840
      TabIndex        =   2
      Top             =   720
      Width           =   1455
   End
End
Attribute VB_Name = "FrmCuotasRes"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub CmdGuardar_Click()
  Dim xidpago  As String
  Dim xdeuda As Double
  If txtFECHA = "" Then Exit Sub
  If MsgBox("Los Cambios No Podran Ser Modificados Desea Continuar ...!", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
    Restructura FrmCuotas.txtcliente, xidpago
    Call p_RellenoDeta(FrmCuotas.MSHFlexGrid1, xidpago)
    CmdGuardar.Enabled = False
  End If
End Sub

Function MontoMORAS() As Double
On Local Error GoTo L
  Dim x As Date
  For I = 1 To FrmCuotas.MSHFlexGrid1.Rows - 1
    If FrmCuotas.MSHFlexGrid1.TextMatrix(I, 5) = "Sin Cancelar" And FrmCuotas.MSHFlexGrid1.TextMatrix(I, 6) = "No" Then
      If CDate(FrmCuotas.MSHFlexGrid1.TextMatrix(I, 3)) < Date Then
        MontoMORAS = MontoMORAS + (CDate(FrmCuotas.MSHFlexGrid1.TextMatrix(I, 3)) - Date)
      End If
    End If
  Next
  MontoMORAS = MontoMORAS * DevuelveMora
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function


Public Sub Restructura(ByVal xcliente As String, ByRef xidpago As String)
On Local Error GoTo L

  Dim T As New ADODB.Recordset, totalapagar As Double, deudi As Double
  T.Open "SELECT FechaxCuotas.idpago, FechaxCuotas.estado, Dueño.NomDueño, Dueño.ApeDueño FROM Dueño INNER JOIN (TB_Deuda INNER JOIN FechaxCuotas ON TB_Deuda.idpago = FechaxCuotas.idpago) ON Dueño.CodDueño = TB_Deuda.CodDueño where Dueño.NomDueño+' '+Dueño.ApeDueño='" + xcliente + "' and FechaxCuotas.estado='Sin Cancelar' and FechaxCuotas.restructuracion='No'", cn, adOpenDynamic, adLockOptimistic, adCmdText
  REFRESCAR T
  xidpago = T!IDPAGO
  If T.State = adStateOpen Then T.Close
  deudi = 0
  For I = 1 To FrmCuotas.MSHFlexGrid1.Rows - 1
    If FrmCuotas.MSHFlexGrid1.TextMatrix(I, 5) = "Sin Cancelar" And FrmCuotas.MSHFlexGrid1.TextMatrix(I, 6) = "No" Then
      deudi = deudi + Val(FrmCuotas.MSHFlexGrid1.TextMatrix(I, 4))
    End If
  Next
  XX = MontoMORAS
  If XX < 0 Then XX = XX * -1
  totalapagar = Round(Val(Format$(deudi + XX, "###.00")) / Val(txcantidadcuota.Text), 2)
  cn.Execute "UPDATE FechaxCuotas set restructuracion='Si' where idpago='" + xidpago + "' and estado='Sin Cancelar' and FechaxCuotas.restructuracion='no'"
  T.Open "select * from FechaxCuotas", cn, adOpenDynamic, adLockOptimistic
  Fechita = CDate(txtFECHA) 'FECHA ACTUAL
  For j% = 1 To Val(txcantidadcuota) Step 1
        T.AddNew
        T!IDPAGO = xidpago
        T!CUOTA = GenerarCodigo("SELECT MAX(CUOTA) FROM fechaxcuotas WHERE IDPAGO='" + xidpago + "'", 2)
        T!valorxcuota = totalapagar
        T!fechaapagar = Fechita
        Fechita = DateAdd("ww", 1, Fechita)   'AGREGA 1 SEMANA
        T!estado = "Sin Cancelar"
        T!restructuracion = "No"
        T.Update
  Next j
  Set T = Nothing
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub dtm1_Change()
txtFECHA = FormatDateTime(CDate(dtm1.Value), vbShortDate)
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
End Sub

Private Sub txcantidadcuota_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, SoloNumero
End Sub

Private Sub txcantidadcuota_LostFocus()
  If Not (Val(txcantidadcuota) >= 1 And Val(txcantidadcuota) <= 36) Then
    txcantidadcuota = 1
    VScroll1.Value = 1
  End If
End Sub

Private Sub txtfecha_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtfecha_LostFocus()
If IsDate(txtFECHA) = False Then
txtFECHA = ""
Else
txtFECHA = Format(CDate(txtFECHA), "dd/mm/yyyy")
End If
End Sub

Private Sub VScroll1_Change()
txcantidadcuota = Val(VScroll1.Value) * -1
End Sub
