VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmbuscarboleta 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR BOLETA"
   ClientHeight    =   8625
   ClientLeft      =   45
   ClientTop       =   540
   ClientWidth     =   12765
   ForeColor       =   &H00B0726D&
   Icon            =   "frmbuscarboleta.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8625
   ScaleWidth      =   12765
   Begin VB.CommandButton CMD1 
      BackColor       =   &H80000017&
      Height          =   350
      Left            =   3720
      MaskColor       =   &H00FFFFFF&
      Picture         =   "frmbuscarboleta.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   9
      ToolTipText     =   "BUSCAR DUEÑO"
      Top             =   720
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.TextBox txtnboleta 
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   350
      Left            =   1920
      TabIndex        =   8
      Top             =   720
      Width           =   1815
   End
   Begin VB.OptionButton optduenio 
      BackColor       =   &H00B0726D&
      Caption         =   "Dueño"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   4680
      TabIndex        =   7
      Top             =   240
      Width           =   1095
   End
   Begin MSComCtl2.DTPicker DTPicker1 
      Height          =   350
      Left            =   3720
      TabIndex        =   6
      Top             =   720
      Visible         =   0   'False
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   609
      _Version        =   393216
      Format          =   20840449
      CurrentDate     =   39284
   End
   Begin VB.OptionButton optanulado 
      BackColor       =   &H00B0726D&
      Caption         =   "Anulados"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   3360
      TabIndex        =   4
      Top             =   240
      Width           =   1215
   End
   Begin VB.OptionButton optfemision 
      BackColor       =   &H00B0726D&
      Caption         =   "Fecha Emisión"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1560
      TabIndex        =   3
      Top             =   240
      Width           =   1575
   End
   Begin VB.OptionButton optnboleta 
      BackColor       =   &H00B0726D&
      Caption         =   "Nº Boleta"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   240
      Value           =   -1  'True
      Width           =   1215
   End
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&Buscar"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   6360
      Picture         =   "frmbuscarboleta.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   855
      Left            =   11160
      Picture         =   "frmbuscarboleta.frx":0B46
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   120
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   7335
      Left            =   120
      TabIndex        =   5
      Top             =   1200
      Width           =   12495
      _ExtentX        =   22040
      _ExtentY        =   12938
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
End
Attribute VB_Name = "frmbuscarboleta"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CMD1_Click()
frmBuscarDueño.Show 1
End Sub
Private Sub CmdBuscar_Click()
If V_CANCELACION = True Then
  If optnboleta.Value = True Then
    BuscarBoleta MSHFlexGrid1, 5, txtnboleta
  End If
  If optfemision.Value = True Then
    BuscarBoleta MSHFlexGrid1, 6, txtnboleta
  End If
  If optanulado.Value = True Then
    BuscarBoleta MSHFlexGrid1, 7
  End If
  If optduenio.Value = True Then
    BuscarBoleta MSHFlexGrid1, 8, txtnboleta
  End If
  Exit Sub
End If
If optnboleta.Value = True Then
  BuscarBoleta MSHFlexGrid1, 1, txtnboleta
End If
If optfemision.Value = True Then
  BuscarBoleta MSHFlexGrid1, 2, txtnboleta
End If
If optanulado.Value = True Then
  BuscarBoleta MSHFlexGrid1, 3
End If
If optduenio.Value = True Then
  BuscarBoleta MSHFlexGrid1, 4, txtnboleta
End If
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub DTPicker1_Change()
txtnboleta = Format(CDate(DTPicker1.Value), "dd/mm/yyyy")
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_KeyPress(KeyAscii As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_BUSCARBOLETA = 1
Centrar_Objeto Me
End Sub
Private Sub Form_Unload(Cancel As Integer)
V_BUSCARBOLETA = 0
Set frmbuscarboleta = Nothing
End Sub
Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
  MSHFlexGrid1_DblClick
    Exit Sub
End If
End Sub
Private Sub MSHFlexGrid1_DblClick()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If V_PAGO = True Then
  With FrmRegistrarPago
          .txtnboleta = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
          .txtcoddueño = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
          .txtcodmasota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
          .FecEmi = CDate(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4))
          If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Credito" Then
            .optcredito.Value = True
          End If
          If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "Contado" Then
            .optcontado.Value = True
          End If
          .txtechainicio = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
          .txtfechapago = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
          .txtechatermino = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
                    .txtacuenta = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
          .txtsaldo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
          .txtcuotas = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)
          .txtsaldoporcuota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 13)
          Mod_Prodims.P_RELLENALISTADETALLEPAGO .MSHFlexGrid1, MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
          .NUEVO = False
          .subtotales
          .LBLCLIENTE = NOMBREC(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2))
          .LBLMASCOTA = NOMBREM(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3))
          .txtacuenta_Change
  End With
  Unload Me
  Exit Sub
End If
End Sub
Private Sub optanulado_Click()
CMD1.Visible = False
DTPicker1.Visible = False
End Sub
Private Sub optduenio_Click()
CMD1.Visible = True
End Sub
Private Sub optfemision_Click()
CMD1.Visible = False
DTPicker1.Visible = True
txtnboleta = Format$(Date, "DD/MM/YYYY")
txtnboleta.SetFocus
End Sub
Private Sub optnboleta_Click()
txtnboleta.SetFocus
txtnboleta = ""
DTPicker1.Visible = False
CMD1.Visible = False
End Sub
Private Sub txtnboleta_GotFocus()
txtnboleta.SelStart = 0
txtnboleta.SelLength = Len(txtnboleta)
End Sub
Private Sub txtnboleta_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
  CmdBuscar_Click
    Exit Sub
End If
End Sub
Private Sub txtnboleta_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
xRestringir KeyAscii, 6
End Sub
Private Sub txtnboleta_LostFocus()
If optfemision.Value = True Then
  txtnboleta = Format$(CDate(txtnboleta), "DD/MM/YYYY")
End If
End Sub
