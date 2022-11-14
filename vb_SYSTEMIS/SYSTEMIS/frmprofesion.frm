VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form frmprofesion 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PROFESIONES"
   ClientHeight    =   5880
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7335
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
   Icon            =   "frmprofesion.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   ScaleHeight     =   5880
   ScaleWidth      =   7335
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   3960
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   1215
      Left            =   120
      TabIndex        =   7
      Top             =   0
      Width           =   5415
      Begin VB.TextBox txtcod 
         Height          =   375
         Left            =   1080
         MaxLength       =   50
         TabIndex        =   9
         Top             =   240
         Width           =   1455
      End
      Begin VB.TextBox txtdes 
         Height          =   375
         Left            =   1080
         MaxLength       =   50
         TabIndex        =   8
         Top             =   720
         Width           =   4095
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   300
         Width           =   855
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Profesión"
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   120
         TabIndex        =   10
         Top             =   720
         Width           =   855
      End
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   4920
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":091E
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   3000
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":19B0
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":227A
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   5760
      Picture         =   "frmprofesion.frx":26BC
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
   Begin VB.TextBox txtbuscar 
      Height          =   375
      Left            =   1680
      MaxLength       =   50
      TabIndex        =   0
      Top             =   1440
      Width           =   3855
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3855
      Left            =   120
      TabIndex        =   12
      Top             =   1920
      Width           =   5415
      _ExtentX        =   9551
      _ExtentY        =   6800
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
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Buscar Profesión:"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   1440
      Width           =   1815
   End
End
Attribute VB_Name = "frmprofesion"
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
  cn.Execute "delete from profesion where codprofesion='" + txtcod + "'", XEliminar
  If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    Set LIMPIAR = Me
    Mod_Prodims.P_RELLENALISTAPROFESION MSHFlexGrid1, 1
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
If Trim(txtcod) = "" Then
MsgBox "Ingrese Codigo...!", vbExclamation
Exit Sub
End If
If Trim(txtdes) = "" Then
MsgBox "Ingrese PROFESIÓN...!", vbExclamation
Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "SELECT * FROM PROFESION", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!CodProfesion = Trim(txtcod)
Else
  T.Open "SELECT * FROM PROFESION WHERE CodProfesion='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!NomProfesion = Trim(txtdes)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  P_RELLENALISTAPROFESION MSHFlexGrid1, 1
  Set LIMPIAR = Me
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdModificar_Click()
NUEVO = False
habilitar
txtcod.Locked = True
txtdes.SetFocus
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
Set LIMPIAR = Me
txtcod.Locked = False
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Mod_Prodims.P_RELLENALISTAPROFESION MSHFlexGrid1, 1
End Sub

Private Sub Form_Unload(Cancel As Integer)
SendKeys "{F5}"
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = Empty Then Exit Sub
txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
txtdes = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
End Sub

Private Sub MSHFlexGrid1_DblClick()
If V_DUEÑO = True Then
  If MSHFlexGrid1.TextMatrix(1, 1) = Empty Then Exit Sub
  frmRegistroDueño.cmbprofesion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
  Unload Me
End If
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub txtbuscar_Change()
Mod_Prodims.P_RELLENALISTAPROFESION MSHFlexGrid1, 2, Trim(txtbuscar)
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtdes_KeyPress(KeyAscii As Integer)
Mod_Prodims.xRestringir KeyAscii, Apostrofe

End Sub
