VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmCuentaCorriente 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CUENTA CORRIENTE"
   ClientHeight    =   6375
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   10590
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Form2.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   6375
   ScaleWidth      =   10590
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text1 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   5400
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   17
      Top             =   720
      Width           =   975
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   120
      Picture         =   "Form2.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   5400
      Width           =   1455
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   1680
      Picture         =   "Form2.frx":074C
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   5400
      Width           =   1455
   End
   Begin VB.TextBox txtpagado 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   9240
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   13
      Top             =   5400
      Width           =   1215
   End
   Begin VB.TextBox txtdeuda 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3360
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   11
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtcredito 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   1080
      Locked          =   -1  'True
      MaxLength       =   50
      TabIndex        =   9
      Top             =   720
      Width           =   1335
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   3240
      Picture         =   "Form2.frx":0A56
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   5400
      Width           =   1455
   End
   Begin VB.ComboBox cmbndocumento 
      Height          =   315
      ItemData        =   "Form2.frx":0D60
      Left            =   7920
      List            =   "Form2.frx":0D62
      Sorted          =   -1  'True
      TabIndex        =   6
      Top             =   600
      Width           =   2535
   End
   Begin VB.ComboBox cmbdocumento 
      Height          =   315
      ItemData        =   "Form2.frx":0D64
      Left            =   7920
      List            =   "Form2.frx":0D71
      Sorted          =   -1  'True
      TabIndex        =   4
      Top             =   240
      Width           =   2535
   End
   Begin VB.CommandButton cmdcliente 
      BackColor       =   &H80000017&
      Height          =   315
      Left            =   5160
      MaskColor       =   &H00FFFFFF&
      Picture         =   "Form2.frx":0D88
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "BUSCAR CLIENTE"
      Top             =   240
      Width           =   375
   End
   Begin VB.TextBox TxtCLIEWNTE 
      BackColor       =   &H80000018&
      DataField       =   "Nº Historia"
      DataMember      =   "EmisionHC"
      DataSource      =   "DataEnvironment1"
      ForeColor       =   &H80000007&
      Height          =   315
      Left            =   1080
      Locked          =   -1  'True
      TabIndex        =   1
      Top             =   240
      Width           =   4095
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3975
      Left            =   120
      TabIndex        =   0
      Top             =   1320
      Width           =   10335
      _ExtentX        =   18230
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
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Cuotas"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   4680
      TabIndex        =   18
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Total Pagado"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7920
      TabIndex        =   14
      Top             =   5400
      Width           =   1575
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Deuda"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   2640
      TabIndex        =   12
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label9 
      BackStyle       =   0  'Transparent
      Caption         =   "Credito"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   10
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Nº Documento"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   6600
      TabIndex        =   7
      Top             =   600
      Width           =   1335
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Documento"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   6600
      TabIndex        =   5
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label8 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Cliente:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000005&
      Height          =   240
      Left            =   120
      TabIndex        =   2
      Top             =   240
      Width           =   795
   End
End
Attribute VB_Name = "FrmCuentaCorriente"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub PRESA(DOCDES As String)
Dim T As New ADODB.Recordset
T.Open ""
End Sub

Private Sub cmbdocumento_Click()
If cmbdocumento = "" Then Exit Sub
x = Devuelve_IdCliente(TxtCLIEWNTE)
RELLENACOMBOXX x, cmbdocumento
End Sub

Private Sub cmbdocumento_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbdocumento, KeyAscii
End Sub

Private Sub cmbdocumento_LostFocus()
BuscarEnCombito cmbdocumento
If cmbdocumento = "" Then cmbndocumento.Clear
End Sub

Private Sub cmbndocumento_Click()
  If cmbndocumento = "" Then Exit Sub
  Dim tot As String
  p_RellenoCUENTACORRIENTESSS FrmCuentaCorriente.MSHFlexGrid1, FrmCuentaCorriente.cmbdocumento, FrmCuentaCorriente.cmbndocumento, Devuelve_IdCliente(FrmCuentaCorriente.TxtCLIEWNTE), FrmCuentaCorriente.txtcredito, FrmCuentaCorriente.txtdeuda, FrmCuentaCorriente.txtpagado
  tot = MSHFlexGrid1.Rows - 1
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then tot = "0"
    If MSHFlexGrid1.TextMatrix(1, 1) <> "" Then
            Dim T As New ADODB.Recordset
            T.Open "select count(*) from fechaxcuotas where idpago='" + MSHFlexGrid1.TextMatrix(1, 16) + "' AND RESTRUCTURACION='No'", cn, adOpenForwardOnly, adLockReadOnly
            REFRESCAR T
            If T.RecordCount > 0 Then
                Text1 = CStr(T(0)) + "/" + CStr(tot)
            End If
        Else
        Text1 = p_devuelvevcresditos(FrmCuentaCorriente.cmbdocumento, FrmCuentaCorriente.cmbndocumento, Devuelve_IdCliente(FrmCuentaCorriente.TxtCLIEWNTE), FrmCuentaCorriente.txtcredito, FrmCuentaCorriente.txtdeuda, FrmCuentaCorriente.txtpagado) + "/0"
            
    End If
  Set T = Nothing
  
End Sub

Private Sub cmbndocumento_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbndocumento, KeyAscii
End Sub

Private Sub cmbndocumento_LostFocus()
BuscarEnCombito cmbndocumento
End Sub

Private Sub cmdcliente_Click()
frmBuscarDueño.Show 1
End Sub

Private Sub CmdNuevo_Click()
Set LIMPIAR = Me
MSHFlexGrid1.Clear
cmbndocumento.Clear
MSHFlexGrid1.Rows = 2
MSHFlexGrid1.Cols = 2
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub CmdVImprimir_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
FrmReportes.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass

V_CUENTACORRIENTESSSS = True
End Sub

Sub RELLENACOMBOXX(IDCLIENTE, DOCUMENTO)
On Local Error GoTo L
Dim T As New ADODB.Recordset
T.Open "SELECT * FROM NDOCSCTACORRIENTE WHERE DESDOCUMENTO='" + DOCUMENTO + "' AND CODDUEÑO='" + IDCLIENTE + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR T
cmbndocumento.Clear
If T.RecordCount = 0 Then
  cmbndocumento.Clear
  Set T = Nothing
  Exit Sub
End If
cmbndocumento.AddItem ""
Do While T.EOF = False
  cmbndocumento.AddItem T!ndocumento
  T.MoveNext
Loop
Set T = Nothing
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_CUENTACORRIENTESSSS = False
End Sub


Private Sub TxtCLIEWNTE_Change()
cmbdocumento = ""
cmbndocumento = ""
txtcredito = ""
txtdeuda = ""
Text1 = ""
MSHFlexGrid1.Clear
txtpagado = ""
cmbndocumento.Clear
End Sub
