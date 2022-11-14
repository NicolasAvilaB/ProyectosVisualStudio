VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmNotaIngresoBuscar 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR NOTA DE INGRESO"
   ClientHeight    =   10095
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   15270
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmNotaIngresoBuscar.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10095
   ScaleWidth      =   15270
   StartUpPosition =   3  'Windows Default
   Begin VB.OptionButton optproveedor 
      BackColor       =   &H00B0726D&
      Caption         =   "Poveedor"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   9000
      TabIndex        =   8
      Top             =   270
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
      Left            =   13680
      Picture         =   "FrmNotaIngresoBuscar.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   120
      Width           =   1455
   End
   Begin VB.TextBox txtbuscar 
      DataField       =   "E-mail"
      DataMember      =   "RegistroDueño"
      DataSource      =   "DataEnvironment1"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   3240
      TabIndex        =   4
      Top             =   600
      Width           =   7095
   End
   Begin VB.OptionButton optfecha 
      BackColor       =   &H00B0726D&
      Caption         =   "Fecha"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   7920
      TabIndex        =   3
      Top             =   270
      Width           =   1095
   End
   Begin VB.OptionButton optningreso 
      BackColor       =   &H00B0726D&
      Caption         =   "Nº Ingreso"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   3240
      TabIndex        =   2
      Top             =   270
      Value           =   -1  'True
      Width           =   1455
   End
   Begin VB.OptionButton optdocumento 
      BackColor       =   &H00B0726D&
      Caption         =   "Nº Documento"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   6000
      TabIndex        =   1
      Top             =   270
      Width           =   1815
   End
   Begin VB.OptionButton optmotivo 
      BackColor       =   &H00B0726D&
      Caption         =   "Motivo"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   4800
      TabIndex        =   0
      Top             =   270
      Width           =   1095
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   8895
      Left            =   120
      TabIndex        =   6
      Top             =   1080
      Width           =   15015
      _ExtentX        =   26485
      _ExtentY        =   15690
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
   Begin VB.Label Label13 
      AutoSize        =   -1  'True
      BackColor       =   &H80000013&
      BackStyle       =   0  'Transparent
      Caption         =   "Buscar Nota de Ingreso Por:"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   240
      Left            =   120
      TabIndex        =   7
      Top             =   270
      Width           =   2940
   End
End
Attribute VB_Name = "FrmNotaIngresoBuscar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_Activate()
Screen.MousePointer = ccDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = ccHourglass
Centrar_Objeto Me
P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 1
End Sub

Private Sub MSHFlexGrid1_DblClick()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
With FrmNotaIngreso
  .txtNK = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  .CMBMOTIVO = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  .cmbdocumento = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  .txtndocumento = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
  .txtFECHA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
  .txtGUIA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
  .cmbproveedor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
  .txtDescuento = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
  .txtsubtotal = Format$(P_RELLENADETALLEKARDEX(.MSHFlexGrid1, "I" + .txtNK), "###.00")
  .Nuevok = True
  .CMDNUEVO1_Click
  .cmdagregar.Enabled = True
  .cmdquitar.Enabled = True
  .CMDNUEVO1.Enabled = True
  Unload Me
End With
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
MSHFlexGrid1_DblClick
  Exit Sub
End If
End Sub

Private Sub optdocumento_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optfecha_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optmotivo_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optningreso_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub optproveedor_Click()
txtbuscar = ""
txtbuscar.SetFocus
End Sub

Private Sub txtbuscar_Change()
If optningreso.Value = True Then
  P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 2, Trim$(txtbuscar)
  Exit Sub
End If
If optmotivo.Value = True Then
  P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 3, Trim$(txtbuscar)
  Exit Sub
End If
If optdocumento.Value = True Then
  P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 4, Trim$(txtbuscar)
  Exit Sub
End If
If optfecha.Value = True Then
  P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 5, Trim$(txtbuscar)
  Exit Sub
End If
If optproveedor.Value = True Then
  P_KARDEXBUSQUEDANOTAINGR MSHFlexGrid1, 6, Trim$(txtbuscar)
  Exit Sub
End If
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
If optfecha.Value = True Then
  txtbuscar = Format(CDate(txtbuscar), "dd/mm/yyyy")
End If
End Sub
