VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmDocumentos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "DOCUMENTOS"
   ClientHeight    =   5925
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7860
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
   Icon            =   "FrmDocumentos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   5925
   ScaleWidth      =   7860
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   6240
      Picture         =   "FrmDocumentos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3000
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   1335
      Left            =   120
      TabIndex        =   6
      Top             =   0
      Width           =   6015
      Begin VB.TextBox txtcod 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   1200
         Locked          =   -1  'True
         MaxLength       =   5
         TabIndex        =   8
         Top             =   240
         Width           =   1455
      End
      Begin VB.TextBox txtdes 
         Height          =   375
         Left            =   1200
         MaxLength       =   60
         TabIndex        =   7
         Top             =   720
         Width           =   4215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   360
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Documento"
         ForeColor       =   &H8000000E&
         Height          =   495
         Left            =   120
         TabIndex        =   9
         Top             =   720
         Width           =   1575
      End
   End
   Begin VB.TextBox txtbuscar 
      Height          =   375
      Left            =   1920
      MaxLength       =   50
      TabIndex        =   5
      Top             =   1440
      Width           =   4095
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   6240
      Picture         =   "FrmDocumentos.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   7800
      Picture         =   "FrmDocumentos.frx":0A56
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1080
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   6240
      Picture         =   "FrmDocumentos.frx":0E98
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   6240
      Picture         =   "FrmDocumentos.frx":1762
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   6240
      Picture         =   "FrmDocumentos.frx":27F4
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   3960
      Width           =   1455
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3855
      Left            =   120
      TabIndex        =   12
      Top             =   1920
      Width           =   5895
      _ExtentX        =   10398
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
      Caption         =   "Buscar Documento:"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   13
      Top             =   1440
      Width           =   1815
   End
End
Attribute VB_Name = "FrmDocumentos"
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
Friend Sub prellenadocumentos(Optional ByVal I As Integer = 0, Optional ByVal x As String)
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  If I = 0 Then
    rs.Open "documentos", cn, adOpenForwardOnly, adLockReadOnly, adCmdTable
  ElseIf I = 1 Then
    rs.Open "select * from documentos where desdocumento like '%" + Trim$(x) + "%'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  End If
  If rs.RecordCount = 0 Then
    MSHFlexGrid1.Clear
    MSHFlexGrid1.Cols = 2
    MSHFlexGrid1.Rows = 2
    Set rs = Nothing
    Exit Sub
  End If
  Set MSHFlexGrid1.Recordset = rs
  Set rs = Nothing
  MSHFlexGrid1.FormatString = "|<Código|<Documento"
  MSHFlexGrid1.ColWidth(0) = 0
  MSHFlexGrid1.ColWidth(1) = 900 'Código
  MSHFlexGrid1.ColWidth(2) = 5000 'Documento
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdAnular_Click()
  habilitar
  Set LIMPIAR = Me
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If txtcod = "00001" Or txtcod = "00002" Or txtcod = "00003" Or txtcod = "00004" Then
    MsgBox "No Esta permitido Eliminar los 4 primeros Documentos ...!", vbInformation
    Exit Sub
  End If
  If Trim$(txtcod) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  If EliminarTabla(txtcod, "Documentos", "iddocumento") > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    Set LIMPIAR = Me
    prellenadocumentos 1
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
MsgBox "Ingrese Cargo...!", vbExclamation
Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "SELECT * FROM Documentos", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!iddocumento = Trim(txtcod)
Else
  T.Open "SELECT * FROM Documentos WHERE iddocumento='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!desdocumento = Trim(txtdes)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  prellenadocumentos
  Set LIMPIAR = Me
  Exit Sub
L:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub

Private Sub CmdModificar_Click()
NUEVO = False
habilitar
txtdes.SetFocus
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
Set LIMPIAR = Me
txtcod = GenerarCodigo(s_IDDOCUMENTOS, 5)
txtdes.SetFocus
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
Call prellenadocumentos
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
txtdes = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub txtbuscar_Change()
  Call prellenadocumentos(1, txtbuscar)
End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
If Chr(KeyAscii) = "'" Then Exit Sub
End Sub

