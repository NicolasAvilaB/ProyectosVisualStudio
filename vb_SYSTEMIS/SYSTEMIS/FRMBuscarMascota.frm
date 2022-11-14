VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmBuscarMascota 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR MASCOTA"
   ClientHeight    =   10065
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   15270
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
   Icon            =   "FRMBuscarMascota.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   10065
   ScaleWidth      =   15270
   Begin VB.ComboBox cmbnomb 
      Height          =   315
      Left            =   2160
      Sorted          =   -1  'True
      TabIndex        =   6
      Top             =   120
      Width           =   3735
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   13560
      Picture         =   "FRMBuscarMascota.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   120
      Width           =   1575
   End
   Begin VB.CommandButton CmdBuscarD 
      BackColor       =   &H80000013&
      Caption         =   "&Buscar Nombre de Mascota"
      Height          =   375
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   120
      Width           =   2655
   End
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&Buscar"
      Height          =   375
      Left            =   6000
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   645
      Width           =   2655
   End
   Begin VB.TextBox TxtNom 
      Height          =   285
      Left            =   2160
      TabIndex        =   0
      Top             =   645
      Width           =   3735
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   8895
      Left            =   120
      TabIndex        =   7
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
   Begin VB.Label Label1 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Buscar Nombre:"
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
      Left            =   360
      TabIndex        =   5
      Top             =   120
      Width           =   1680
   End
   Begin VB.Label Label3 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "Nombre:"
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
      Index           =   0
      Left            =   1080
      TabIndex        =   4
      Top             =   645
      Width           =   900
   End
End
Attribute VB_Name = "frmBuscarMascota"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdBuscar_Click()
If V_DUEÑO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, Trim(TxtNom), frmRegistroMascota.txtcoddueño
End If
If V_PAGO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, Trim(TxtNom), FrmRegistrarPago.txtcoddueño
End If
If V_HISTCLIN = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, Trim(TxtNom)
End If
If V_INFORMCITAS = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, Trim(TxtNom)
End If
If V_HOJAACTUALIZADA = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, Trim(TxtNom), FrmHojaActualizada.txtcoddueño
End If
If V_INFORMDEMASCOTAS Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, Trim(TxtNom)
End If
If V_INFORMDEENFERMEDEDAS Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, Trim(TxtNom)
End If
End Sub
Private Sub CmdBuscarD_Click()
If V_DUEÑO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 3, cmbnomb, frmRegistroMascota.txtcoddueño
End If
If V_PAGO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 3, cmbnomb, FrmRegistrarPago.txtcoddueño
End If
If V_HISTCLIN = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 1, cmbnomb
End If
If V_HOJAACTUALIZADA = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 3, cmbnomb, FrmHojaActualizada.txtcoddueño
End If
If V_INFORMCITAS = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 1, cmbnomb
End If
If V_INFORMDEMASCOTAS Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 1, cmbnomb
End If
If V_INFORMDEENFERMEDEDAS Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 1, cmbnomb
End If
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me

End Sub
Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
  MSHFlexGrid1_DblClick
    Exit Sub
End If
End Sub
Private Sub Form_Load()
P_RellenaCombo "MAS", cmbnomb
If V_DUEÑO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, "", frmRegistroMascota.txtcoddueño
End If
If V_PAGO = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, "", FrmRegistrarPago.txtcoddueño
End If
If V_HISTCLIN = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, ""
End If
If V_HOJAACTUALIZADA = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 4, "", FrmHojaActualizada.txtcoddueño
End If
If V_INFORMCITAS = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, ""
End If
If V_INFORMDEMASCOTAS = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, ""
End If
If V_INFORMDEENFERMEDEDAS = True Then
  P_RELLENALISTAMASCOTA MSHFlexGrid1, 2, ""
End If
Centrar_Objeto Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set frmBuscarMascota = Nothing
End Sub

Private Sub MSHFlexGrid1_DblClick()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If V_MASCOTA = True Or V_DUEÑO = True Then
  With frmRegistroMascota
  .txtcodigo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  .txtnombre = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  .TxtAños = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  .TxtMeses = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "H" Then
  .opth.Value = True
  End If
  If MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5) = "M" Then
  .optm.Value = True
  End If
  .NUEVO = False
  .TxtFechaNac = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
  .TXTPESO = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 7)
  .TxtPelaje = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
  .TxtAlergia = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
  .CMBespecie = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
  .cmbraza = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
  On Error GoTo P
  .Image1.Picture = LoadPicture(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12))
  .Image1.Tag = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)
  End With
  Unload Me
End If
If V_PAGO = True Then
  FrmRegistrarPago.txtcodmasota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  FrmRegistrarPago.LBLMASCOTA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
If V_HISTCLIN = True Then
  FrmBuscarHistoriaClinica.TXTCOMASCOTA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  Unload Me
End If
If V_HOJAACTUALIZADA = True Then
  FrmHojaActualizada.txtcodmascota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  FrmHojaActualizada.txtedad = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  FrmHojaActualizada.txtdireccion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 15)
  FrmHojaActualizada.txtraza = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
  FrmHojaActualizada.txtespecie = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
  FrmHojaActualizada.txttelefono = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 16)
  FrmHojaActualizada.txtfecnac = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
  FrmHojaActualizada.txtsexo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
    FrmHojaActualizada.txtnommascota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)

  Unload Me
End If
If V_INFORMCITAS = True Then
  FrmInformeListaCitas.txtcodd = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  FrmInformeListaCitas.lblnommasota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
If V_INFORMDEMASCOTAS = True Then
  FRMlisademascotasavacuna.txtcodd = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  FRMlisademascotasavacuna.lblnommasota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
If V_INFORMDEENFERMEDEDAS = True Then
  Frmlistaenfermedades.txtcodd = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  Frmlistaenfermedades.lblnommasota = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If

  Exit Sub
P:
  frmRegistroDueño.Image1.Picture = LoadPicture("")
  Unload Me
End Sub

Private Sub MSHFlexGrid1_KeyPress(KeyAscii As Integer)
MSHFlexGrid1_DblClick
End Sub

Private Sub TxtApeDueño_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, Apostrofe
End Sub

Private Sub TxtNom_GotFocus()
TxtNom.SelStart = 0
TxtNom.SelLength = Len(TxtNom)
End Sub

Private Sub TxtNom_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
