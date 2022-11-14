VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmFacturacionBuscar 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR FACTURAS / BOLETAS"
   ClientHeight    =   10080
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   15270
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmFacturacionBuscar.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10080
   ScaleWidth      =   15270
   StartUpPosition =   3  'Windows Default
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
      Picture         =   "FrmFacturacionBuscar.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   4
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
      Left            =   3120
      TabIndex        =   3
      Top             =   600
      Width           =   4215
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
      Left            =   6240
      TabIndex        =   2
      Top             =   240
      Width           =   1095
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
      Left            =   3120
      TabIndex        =   1
      Top             =   240
      Value           =   -1  'True
      Width           =   1815
   End
   Begin VB.OptionButton optcliente 
      BackColor       =   &H00B0726D&
      Caption         =   "Cliente"
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
      Left            =   5040
      TabIndex        =   0
      Top             =   240
      Width           =   1215
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   8895
      Left            =   120
      TabIndex        =   5
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
      Caption         =   "Buscar Nota de Salida Por:"
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
      TabIndex        =   6
      Top             =   210
      Width           =   2835
   End
End
Attribute VB_Name = "FrmFacturacionBuscar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text

Dim capaf As New ClsFacturacion

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
Centrar_Objeto Me
capaf.P_VENTASBUSQUEDA MSHFlexGrid1
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set capaf = Nothing
End Sub

Private Sub MSHFlexGrid1_DblClick()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  With FrmFacturacion
    .txtidventa = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
    .cmbcliente = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
    .txtusuario = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
    .txtFecha = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
    If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) = "Contado" Then
      .optcontado.Value = True
    Else: MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) = "Credito"
      .optcredito.Value = True
    End If
    If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7) = "Boleta" Then
      .optboleta.Value = True
    Else: MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7) = "Factura"
      .optfactura.Value = True
    End If
    .txtNDocumento = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
    .cmbpromotor = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 13)
    .txtDescuento = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
    .TSUBTOTAL.Text = capaf.P_RellenarListaDetalle(.MSHFlexGrid1, MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1), cn)
    If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "1" Then .optsoles.Value = True
    If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14) = "2" Then .optdolares.Value = True
    .txttipocambio = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 15)
    .ACTIVAR True
    .CMDNUEVO1_Click
    .NUEVO = False
  End With
  Unload Me
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
MSHFlexGrid1_DblClick
End If
End Sub

Private Sub txtbuscar_Change()
If optcliente.Value = True Then
  capaf.P_VENTASBUSQUEDA MSHFlexGrid1, 2, txtbuscar
End If
If optfecha.Value = True Then
  capaf.P_VENTASBUSQUEDA MSHFlexGrid1, 3, txtbuscar
End If
If optdocumento.Value = True Then
  capaf.P_VENTASBUSQUEDA MSHFlexGrid1, 4, txtbuscar
End If
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
