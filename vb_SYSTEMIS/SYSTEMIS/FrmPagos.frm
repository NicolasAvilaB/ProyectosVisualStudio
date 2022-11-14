VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmPagos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PAGOS"
   ClientHeight    =   6060
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   12150
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
   Icon            =   "FrmPagos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   6060
   ScaleWidth      =   12150
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox TXTNRECIBO 
      Alignment       =   2  'Center
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   10320
      Locked          =   -1  'True
      MaxLength       =   15
      TabIndex        =   21
      Top             =   120
      Visible         =   0   'False
      Width           =   1620
   End
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      BorderStyle     =   0  'None
      Height          =   1335
      Left            =   0
      ScaleHeight     =   1335
      ScaleWidth      =   12135
      TabIndex        =   18
      Top             =   4800
      Width           =   12135
      Begin VB.CommandButton Command2 
         BackColor       =   &H80000013&
         Caption         =   "&ANULAR RECIBO"
         Height          =   855
         Left            =   240
         Picture         =   "FrmPagos.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   20
         Top             =   120
         Visible         =   0   'False
         Width           =   2295
      End
      Begin VB.CommandButton CmdSalir 
         BackColor       =   &H80000013&
         Cancel          =   -1  'True
         Caption         =   "&SALIR"
         Height          =   855
         Left            =   10560
         Picture         =   "FrmPagos.frx":0614
         Style           =   1  'Graphical
         TabIndex        =   19
         Top             =   120
         Width           =   1455
      End
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      BorderStyle     =   0  'None
      Height          =   5535
      Left            =   120
      ScaleHeight     =   5535
      ScaleWidth      =   11895
      TabIndex        =   0
      Top             =   120
      Width           =   11895
      Begin VB.TextBox txtidpago 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   5640
         Locked          =   -1  'True
         MaxLength       =   15
         TabIndex        =   10
         Top             =   0
         Visible         =   0   'False
         Width           =   1620
      End
      Begin VB.CommandButton CmdRecibo 
         BackColor       =   &H80000013&
         Caption         =   "&RECIBO"
         Height          =   855
         Left            =   1560
         Picture         =   "FrmPagos.frx":091E
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   3720
         Width           =   1455
      End
      Begin VB.TextBox txtmora 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   8
         Text            =   "0.00"
         Top             =   1680
         Width           =   1455
      End
      Begin VB.TextBox txNcuota 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   7
         Top             =   600
         Width           =   1455
      End
      Begin VB.TextBox txtcliente 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   840
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   6
         Top             =   0
         Width           =   4215
      End
      Begin VB.TextBox txttotalapagar 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   5
         Text            =   "0.00"
         Top             =   2040
         Width           =   1455
      End
      Begin VB.CommandButton Cmdcancelardeuda 
         BackColor       =   &H80000013&
         Caption         =   "&CANCELAR DEUDA"
         Height          =   855
         Left            =   0
         Picture         =   "FrmPagos.frx":0C28
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   3720
         Width           =   1455
      End
      Begin VB.TextBox TXTPAGOPORCUOTA 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   3
         Text            =   "0.00"
         Top             =   1320
         Width           =   1455
      End
      Begin VB.CommandButton cmdclicente 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   5040
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmPagos.frx":0F32
         Style           =   1  'Graphical
         TabIndex        =   2
         ToolTipText     =   "BUSCAR CLIENTE"
         Top             =   0
         Width           =   375
      End
      Begin VB.TextBox txtefchacuota 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   1
         Top             =   960
         Width           =   1455
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   3975
         Left            =   3120
         TabIndex        =   11
         Top             =   600
         Width           =   8775
         _ExtentX        =   15478
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
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Mora"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   17
         Top             =   1725
         Width           =   1455
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Cuota"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   16
         Top             =   600
         Width           =   1455
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "Cliente"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   15
         Top             =   0
         Width           =   1215
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Total a Pagar"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   14
         Top             =   2100
         Width           =   1455
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Pago de Cuota"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   13
         Top             =   1320
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha Cuota"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   0
         TabIndex        =   12
         Top             =   980
         Width           =   1215
      End
   End
End
Attribute VB_Name = "FrmPagos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim IDPAGO As String, CUOTA As String
Private Sub Cmdcancelardeuda_Click()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  If txtcliente = "" Then
    MsgBox "Buscar Cliente ...!", vbInformation
    Exit Sub
  End If
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Cancelado" Then
    Exit Sub
  End If
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) = "Si" Then
    Exit Sub
  End If
  If txNcuota = "" Then Exit Sub
  If MsgBox("¿Desea Cancelar La Deuda Nº Cuota " + txNcuota + " ....?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
    cn.Execute "UPDATE FECHAXCUOTAS SET estado='Cancelado' where idpago='" + txtidpago + "' and cuota='" + txNcuota + "'", I
    If I > 0 Then FrmMensajeDeuda.Show 1
    nrecibo = GenerarNRECIBO
    cn.Execute "INSERT INTO TB_PAGOS VALUES('" + txtidpago + "',#" + txtefchacuota + "#,=" + txtmora + "," + txttotalapagar + ",'" + nrecibo + "',#" + Format$(Date, "DD/MM/YYYY") + "#,'" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "',0)", j
    If j > 0 Then cn.Execute "UPDATE TABSERIES SET serie2='" + nrecibo + "' WHERE Documento='Recibo'"
    p_RellenoDeta MSHFlexGrid1, txtidpago
    txtefchacuota = ""
    txtmora = "0.00"
    TXTPAGOPORCUOTA = "0.00"
    txttotalapagar = "0.00"
    txNcuota = ""
  End If
End Sub

Private Sub cmdclicente_Click()
frmBuscarDueño.Show 1
End Sub

Private Sub CmdRecibo_Click()
If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Sin Cancelar" Then Exit Sub
If Val(txttotalapagar) = 0 Then Exit Sub
dtrecibo2.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Command2_Click()
If MsgBox("¿Desea Anular Recibo ....!?", vbQuestion + vbDefaultButton2 + vbYesNo) = vbYes Then
  cn.Execute "UPDATE TB_PAGOS SET ANULADO=1 WHERE IDPAGO='" + IDPAGO + "' AND CUOTA='" + CUOTA + "'", I
  cn.Execute "UPDATE FECHAXCUOTAS SET ESTADO='Sin Cancelar' WHERE IDPAGO='" + IDPAGO + "' AND CUOTA='" + CUOTA + "' AND RESTRUCTURACION='No'", I
  If I > 0 Then
    DEVUELVEIDPAGO TXTNRECIBO, IDPAGO, CUOTA
  p_RellenoDeta MSHFlexGrid1, IDPAGO
  FrmMensajeAnulado.Show 1
  Command2.Enabled = False
  End If
End If
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
  Screen.MousePointer = vbHourglass
  If V_ANULAR = True Then
  Picture1.Enabled = False
  Command2.Visible = True
  TXTNRECIBO.Visible = True
  TXTNRECIBO.Text = Form1.Text1
  DEVUELVEIDPAGO TXTNRECIBO, IDPAGO, CUOTA
  p_RellenoDeta MSHFlexGrid1, IDPAGO
  Exit Sub
    End If
  V_PAGOCREDITOSVENTAS = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
  V_PAGOCREDITOSVENTAS = False
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  txNcuota.Text = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  txtefchacuota.Text = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  TXTPAGOPORCUOTA.Text = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)), "###.00")
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Sin Cancelar" Then
    If CDate(txtefchacuota) < Date Then
      txtmora.Text = Format$((Date - CDate(txtefchacuota)) * DevuelveMora, "###.00")
      Else
      txtmora = "0.00"
    End If
  ElseIf MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Cancelado" Then
      txtmora = DevuelveMorass(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1), MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3))
  End If
  txttotalapagar = Format$(Val(TXTPAGOPORCUOTA) + Val(txtmora), "###.00")
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub TXTNRECIBO_Change()
If TXTNRECIBO = "" Then Exit Sub
On Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT TB_Pagos.idpago, TB_Pagos.fechacuota, TB_Pagos.moraxc, TB_Pagos.totalcuota, TB_Pagos.nrecibo, TB_Pagos.fechapago, TB_Pagos.cuota, TB_Pagos.anulado, Dueño.NomDueño, Dueño.ApeDueño FROM (Dueño INNER JOIN TB_Deuda ON Dueño.CodDueño = TB_Deuda.CodDueño) INNER JOIN TB_Pagos ON TB_Deuda.idpago = TB_Pagos.idpago WHERE TB_PAGOS.NRECIBO='" + TXTNRECIBO + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    Exit Sub
  End If
  txtefchacuota = T!FECHACUOTA
  TXTPAGOPORCUOTA = T!totalcuota - T!moraxc
  txtmora = T!moraxc
  txttotalapagar = T!totalcuota
  txNcuota = T!CUOTA
  txtcliente = T!NomDueño + " " + T!ApeDueño
  Set T = Nothing
Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
