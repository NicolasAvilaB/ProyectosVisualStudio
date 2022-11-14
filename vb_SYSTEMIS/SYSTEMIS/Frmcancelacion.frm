VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form Frmcancelacion 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CANCELACION DE DEUDAS"
   ClientHeight    =   4890
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   10320
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
   Icon            =   "Frmcancelacion.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   4890
   ScaleWidth      =   10320
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text1 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      BorderStyle     =   0  'None
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2160
      Locked          =   -1  'True
      TabIndex        =   7
      Top             =   4440
      Width           =   1335
   End
   Begin VB.TextBox txtcoddueño 
      Height          =   375
      Left            =   1320
      Locked          =   -1  'True
      TabIndex        =   3
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton cmdDUEÑO 
      BackColor       =   &H80000017&
      Height          =   350
      Left            =   2520
      MaskColor       =   &H00FFFFFF&
      Picture         =   "Frmcancelacion.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   2
      ToolTipText     =   "BUSCAR DUEÑO"
      Top             =   120
      Width           =   375
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   8760
      Picture         =   "Frmcancelacion.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2400
      Width           =   1455
   End
   Begin VB.CommandButton Cmdcancelar 
      BackColor       =   &H80000013&
      Caption         =   "Cancelar Deuda"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   8760
      Picture         =   "Frmcancelacion.frx":0B46
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   1320
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3735
      Left            =   120
      TabIndex        =   5
      Top             =   600
      Width           =   8535
      _ExtentX        =   15055
      _ExtentY        =   6588
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
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "S/."
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1800
      TabIndex        =   9
      Top             =   4440
      Width           =   495
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Deuda Total:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   4440
      Width           =   1815
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3000
      TabIndex        =   6
      Top             =   120
      Width           =   4455
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Dueño:"
      BeginProperty Font 
         Name            =   "Monotype Corsiva"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   -1  'True
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "Frmcancelacion"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NBOLE As String
Private Sub Cmdcancelar_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If MsgBox("¿Usted Desea Cancelar La Deuda del Cliente...?" + Chr(13) + "Fecha de Pago: " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + Chr(13) + "Deuda: " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3), vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then Exit Sub
cn.Execute "updatE DEUDAS SET cancelado=1,FecCancelacion=#" + Format(Date, "DD/MM/YYYY") + "# where [Nº Boleta]='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1) + "' and format(FecPago,'dd/mm/yyyy')='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "'", I
If I > 0 Then
  If MsgBox("¿Desea Imprimir Recibo...?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
    ImprimeRecibo
  End If
  relle txtcoddueño
  FrmMensajeDeuda.Show 1
End If

End Sub
Sub ImprimeRecibo()
On Error GoTo L   ' Configura controlador de errores.
  MousePointer = vbHourglass
  DoEvents
  Printer.CurrentY = 1440
  Printer.CurrentX = 1440
  Printer.Font.Bold = True
  Printer.Print "Recibo del:" + Space(2) + Format$(Now, "dd/mm/yyyy hh:mm:ss AMPM")
  Printer.CurrentX = 1440
  Printer.Font.Bold = False
  Printer.Print "----------"
  Printer.CurrentX = 1440
  Printer.Print "Nº Boleta" + vbTab + ":" + Space(2) + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  Printer.CurrentX = 1440
  Printer.Print "Fecha Pago:" + Space(2) + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Printer.CurrentX = 1440
  Printer.Print "Deuda" + vbTab + ":" + Space(2) + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  Printer.CurrentX = 1440
  Printer.Print "Cliente " + vbTab + ":" + Space(2) + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  Printer.CurrentX = 1440
  Printer.Print "Mascota" + vbTab + ":" + Space(2) + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
  Printer.CurrentX = 1440
  Printer.Print "----------"
  Printer.CurrentX = 1440
  Printer.Print "Cancelado"
  Printer.EndDoc
  MousePointer = vbDefault
  Exit Sub
L:
   MsgBox Err.Description + Chr(13) + "Hubo un problema al imprimir en su impresora...!", vbCritical
End Sub
Private Sub cmdDUEÑO_Click()
frmBuscarDueño.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_CANCELACION = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_CANCELACION = False
End Sub
Public Sub relle(coddue As String)
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "select * from RegistroDeuda where [CodDueño]='" + coddue + "'", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR rs
  If rs.RecordCount = 0 Then
    MSHFlexGrid1.Clear
    MSHFlexGrid1.Cols = 2
    MSHFlexGrid1.Rows = 2
    Set rs = Nothing
    If NBOLE <> "" Then
      cn.Execute "UPDATE PAGO SET CANCELADO=1 WHERE [Nº Boleta]='" + NBOLE + "'"
      NBOLE = ""
    End If
    Exit Sub
  End If
  Set MSHFlexGrid1.Recordset = rs
  rs.MoveFirst
  Text1 = 0
  While rs.EOF = False
    Text1 = Val(Text1) + rs!MONTO
    rs.MoveNext
  Wend
  Set rs = Nothing
  MSHFlexGrid1.FormatString = "|<Nº Boleta|<Fecha Pago|<Deuda|<Dueño|<Mascota|<CodDueño"
  MSHFlexGrid1.ColWidth(0) = 0
  MSHFlexGrid1.ColWidth(1) = 1000 'Nº Boleta
  MSHFlexGrid1.ColWidth(2) = 1200 'Fecha Pago
  MSHFlexGrid1.ColWidth(3) = 1200 'Deuda
  MSHFlexGrid1.ColWidth(4) = 2600 'Dueño
  MSHFlexGrid1.ColWidth(5) = 2600 'Mascota
  MSHFlexGrid1.ColWidth(6) = 0
Exit Sub
L:
MsgBox Err.Description, 64
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
NBOLE = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
End Sub
