VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmComosiones 
   BackColor       =   &H00B0726D&
   Caption         =   "Comisiones"
   ClientHeight    =   5850
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8160
   BeginProperty Font 
      Name            =   "MS Sans Serif"
      Size            =   8.25
      Charset         =   0
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "FrmComosiones.frx":0000
   LinkTopic       =   "Form2"
   ScaleHeight     =   5850
   ScaleWidth      =   8160
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":074C
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":0B8E
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":1458
      Style           =   1  'Graphical
      TabIndex        =   9
      Top             =   3000
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":24EA
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   4920
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   1215
      Left            =   120
      TabIndex        =   4
      Top             =   0
      Width           =   6255
      Begin VB.ComboBox cmbcomision 
         Height          =   315
         ItemData        =   "FrmComosiones.frx":27F4
         Left            =   4920
         List            =   "FrmComosiones.frx":2807
         TabIndex        =   2
         Top             =   720
         Width           =   1215
      End
      Begin VB.TextBox TXTA 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   2640
         MaxLength       =   50
         TabIndex        =   1
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txtde 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   840
         MaxLength       =   50
         TabIndex        =   0
         Top             =   720
         Width           =   1095
      End
      Begin VB.TextBox txtcod 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   840
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   5
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Comisión %"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   3840
         TabIndex        =   15
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Hasta"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   2040
         TabIndex        =   14
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Desde"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   7
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   300
         Width           =   855
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   6600
      Picture         =   "FrmComosiones.frx":281E
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   3960
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   4455
      Left            =   120
      TabIndex        =   13
      Top             =   1320
      Width           =   6375
      _ExtentX        =   11245
      _ExtentY        =   7858
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
Attribute VB_Name = "FrmComosiones"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean
Friend Sub habilitar()
  MSHFlexGrid1.Enabled = Not MSHFlexGrid1.Enabled
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Frame1.Enabled = Not Frame1.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub
Private Sub cmbcomision_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Moneda
End Sub
Private Sub cmbcomision_LostFocus()
If Not (Val(cmbcomision) >= 0 And Val(cmbcomision) <= 100) Then
    cmbcomision = "0"
End If
End Sub
Private Sub CmdAnular_Click()
  habilitar
  Set LIMPIAR = Me
End Sub
Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcod) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  If EliminarTabla(txtcod, "comisiones", "idcomision") > 0 Then
    frmMensajeEliminado.Show 1
    Set LIMPIAR = Me
    P_RELLENALISTAcomisiones MSHFlexGrid1
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
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "comisiones", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!idcomision = Trim$(txtcod)
Else
  T.Open "SELECT * FROM comisiones WHERE idcomision='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!rango1 = Val(txtde.Text)
  T!rango2 = Val(TXTA.Text)
  T!comision = Val(cmbcomision.Text)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  P_RELLENALISTAcomisiones MSHFlexGrid1
  Set LIMPIAR = Me
  Exit Sub
L:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub CmdModificar_Click()
If txtcod = "" Then
  MsgBox "Buscar Comisión ...!", vbInformation
  Exit Sub
End If
NUEVO = False
habilitar
TXTA.SetFocus
End Sub
Private Sub CmdNuevo_Click()
  NUEVO = True
  habilitar
  Set LIMPIAR = Me
  txtcod.Text = GenerarCodigo("select max(idcomision) from comisiones", 5)
  On Error Resume Next
  txtde.SetFocus
  On Error GoTo 0
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
P_RELLENALISTAcomisiones MSHFlexGrid1
End Sub
Private Sub MSHFlexGrid1_Click()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
  txtde = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  TXTA = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3)
  cmbcomision = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
End Sub
Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub
Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub
Private Sub TXTA_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Moneda
End Sub
Private Sub txtde_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Moneda
End Sub
