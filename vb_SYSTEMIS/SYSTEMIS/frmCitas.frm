VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmCitas 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CITAS"
   ClientHeight    =   6735
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10305
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
   Icon            =   "frmCitas.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form4"
   MaxButton       =   0   'False
   ScaleHeight     =   6735
   ScaleWidth      =   10305
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame12 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   2415
      Left            =   120
      TabIndex        =   9
      Top             =   0
      Width           =   8535
      Begin VB.TextBox txtteleono 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   1680
         MaxLength       =   9
         TabIndex        =   16
         Top             =   240
         Width           =   1695
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   375
         Left            =   3240
         TabIndex        =   15
         Top             =   720
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   661
         _Version        =   393216
         Format          =   48496641
         CurrentDate     =   39283
      End
      Begin VB.TextBox txtiD 
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
         Left            =   6360
         TabIndex        =   11
         Top             =   720
         Visible         =   0   'False
         Width           =   975
      End
      Begin VB.TextBox txtmotivo 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   1095
         Left            =   1680
         MaxLength       =   255
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   2
         Top             =   1200
         Width           =   6615
      End
      Begin VB.TextBox txthora 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   4440
         MaxLength       =   14
         TabIndex        =   1
         Top             =   720
         Width           =   1335
      End
      Begin VB.TextBox txtfecha 
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   360
         Left            =   1680
         MaxLength       =   10
         TabIndex        =   0
         Top             =   720
         Width           =   1575
      End
      Begin VB.Label Label1 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Teléfono :"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   240
         Left            =   240
         TabIndex        =   17
         Top             =   240
         Width           =   1065
      End
      Begin VB.Label Label5 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha Cita::"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   240
         Left            =   240
         TabIndex        =   14
         Top             =   720
         Width           =   1245
      End
      Begin VB.Label Label6 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Motivo:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   240
         Left            =   240
         TabIndex        =   13
         Top             =   1200
         Width           =   765
      End
      Begin VB.Label Label7 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Hora:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FFFFFF&
         Height          =   240
         Left            =   3720
         TabIndex        =   12
         Top             =   720
         Width           =   585
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   3960
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   5760
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":091E
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   3000
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":19B0
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":227A
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   8760
      Picture         =   "frmCitas.frx":26BC
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   120
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   4095
      Left            =   120
      TabIndex        =   10
      Top             =   2520
      Width           =   8535
      _ExtentX        =   15055
      _ExtentY        =   7223
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
Attribute VB_Name = "frmCitas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean

Private Sub CmdAnular_Click()
habilitar
LIMPIARTEXTO
txtteleono = FrmHojaActualizada.txttelefono
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(TXTID) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  cn.Execute "delete from CITAS where ID='" + TXTID + "' and [Nº HISTORIA]='" + FrmHojaActualizada.TxtNHistoria + "'", XEliminar
If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    LIMPIARTEXTO
  txtteleono = FrmHojaActualizada.txttelefono
    P_RELLENALISTADETALLE_CITAS MSHFlexGrid1, 1, FrmHojaActualizada.TxtNHistoria
  End If
Exit Sub
Errlinea:
    If Err.Number = -2147467259 Then
      MsgBox "No Se Puede Eliminar El Registro Porque Esta Relacionado Con Una o Más Tablas...!", vbInformation
      Exit Sub
    End If
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical

End Sub

Private Sub CmdGuardar_Click()
On Local Error GoTo L
If Trim(txtteleono) = "" Then
MsgBox "Ingrese Teléfono...!", vbExclamation
txtteleono.SetFocus
Exit Sub
End If
If Trim(txtFECHA) = "" Then
MsgBox "Buscar Fecha...!", vbExclamation
txtFECHA.SetFocus
Exit Sub
End If
If Val(txthora) = 0 Then
MsgBox "Ingrese Hora...!", vbExclamation
txthora.SetFocus
Exit Sub
End If
If Trim(txtmotivo) = "" Then
MsgBox "Ingrese Motivo...!", vbExclamation
txtmotivo.SetFocus
Exit Sub
End If

Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "SELECT * from CITAS", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!id = Trim(TXTID)
  T("Nº Historia") = FrmHojaActualizada.TxtNHistoria
Else
  T.Open "SELECT * FROM CITAS WHERE [nº historia]='" + FrmHojaActualizada.TxtNHistoria + "' and ID='" + TXTID + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!FechaCita = CDate(txtFECHA)
  T!HoraCita = CDate(txthora)
  T!MotivoCita = txtmotivo
  T.Update
  Set T = Nothing
  If NUEVO = True Then
    frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  P_RELLENALISTADETALLE_CITAS MSHFlexGrid1, 1, FrmHojaActualizada.TxtNHistoria
  LIMPIARTEXTO
  txtteleono = FrmHojaActualizada.txttelefono
  Exit Sub
L:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub

Private Sub CmdModificar_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
  MsgBox "No Hay Registro Para Modificar...!", vbInformation
  Exit Sub
End If
If txtmotivo = "" Then
  MsgBox "Seleccione Un Registro de La Lista...?", vbInformation
  Exit Sub
End If
NUEVO = False
habilitar
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
LIMPIARTEXTO
TXTID = codigodetalleCITA(FrmHojaActualizada.TxtNHistoria)
txtteleono = FrmHojaActualizada.txttelefono
End Sub
Sub LIMPIARTEXTO()
txtteleono = ""
txtFECHA = ""
TXTID = ""
txtmotivo = ""
txthora = ""
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub DTPicker1_Change()
txtFECHA = Format(CDate(DTPicker1.Value), "dd/mm/yyyy")
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Friend Sub habilitar()
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Frame12.Enabled = Not Frame12.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
  MSHFlexGrid1.Enabled = Not MSHFlexGrid1.Enabled
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
P_RELLENALISTADETALLE_CITAS MSHFlexGrid1, 1, FrmHojaActualizada.TxtNHistoria
DTPicker1.Value = DateSerial(Year(Date), Month(Date), 1)
txtteleono = FrmHojaActualizada.txttelefono
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set frmCitas = Nothing
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = empy Then Exit Sub
  txtFECHA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  txthora = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  txtmotivo = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
  TXTID = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
End Sub
Private Sub MSHFlexGrid1_DblClick()
If MSHFlexGrid1.TextMatrix(1, 1) = empy Then Exit Sub
 FrmDetalleHC.TXTFECHACITA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  FrmDetalleHC.TXTHORACITA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  FrmDetalleHC.TXTID = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5)
  Unload Me
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub txtfecha_GotFocus()
txtFECHA.SelStart = 0
txtFECHA.SelLength = Len(txtFECHA)
End Sub

Private Sub txtfecha_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtfecha_LostFocus()
  If IsDate(txtFECHA) = True Then
    txtFECHA = Format(CDate(txtFECHA), "dd/mm/yyyy")
  Else
    txtFECHA = Empty
  End If
End Sub

Private Sub txthora_GotFocus()
txthora.SelStart = 0
txthora.SelLength = Len(txthora)
End Sub

Private Sub txthora_KeyPress(KeyAscii As Integer)
  If InStr(1, "0123456789:", Chr(KeyAscii)) = 0 And KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub txthora_LostFocus()
If IsDate(txthora) = True Then
txthora = Format$(CDate(txthora), "hh:mm:ss AMPM")
Else
txthora = ""
End If
End Sub

Private Sub txtmotivo_GotFocus()
txtmotivo.SelStart = 0
txtmotivo.SelLength = Len(txtmotivo)

End Sub

Private Sub txtmotivo_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, Apostrofe

End Sub
