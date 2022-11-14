VERSION 5.00
Begin VB.Form FrmExamenesCom 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "EXAMENES COMPLEMENTARIOS"
   ClientHeight    =   4320
   ClientLeft      =   45
   ClientTop       =   540
   ClientWidth     =   7455
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
   Icon            =   "FrmExamenesCom.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   4320
   ScaleWidth      =   7455
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&BUSCAR"
      Height          =   855
      Left            =   3240
      Picture         =   "FrmExamenesCom.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   16
      Top             =   2400
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   120
      Picture         =   "FrmExamenesCom.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   15
      Top             =   2400
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   1680
      Picture         =   "FrmExamenesCom.frx":0A56
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   2400
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   1680
      Picture         =   "FrmExamenesCom.frx":0E98
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   3360
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   120
      Picture         =   "FrmExamenesCom.frx":1762
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   3360
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   4800
      Picture         =   "FrmExamenesCom.frx":27F4
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3360
      Width           =   1455
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   3240
      Picture         =   "FrmExamenesCom.frx":2AFE
      Style           =   1  'Graphical
      TabIndex        =   10
      Top             =   3360
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      Height          =   2175
      Left            =   120
      TabIndex        =   4
      Top             =   120
      Width           =   7215
      Begin VB.OptionButton optno 
         BackColor       =   &H00B0726D&
         Caption         =   "NO"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   2400
         TabIndex        =   3
         Top             =   1680
         Width           =   975
      End
      Begin VB.OptionButton optsi 
         BackColor       =   &H00B0726D&
         Caption         =   "SI"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   1320
         TabIndex        =   2
         Top             =   1680
         Value           =   -1  'True
         Width           =   975
      End
      Begin VB.TextBox txtcodexa 
         Height          =   375
         Left            =   1320
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   5
         Top             =   240
         Width           =   1575
      End
      Begin VB.TextBox txtdescripcion 
         Height          =   375
         Left            =   1320
         MaxLength       =   60
         TabIndex        =   0
         Top             =   720
         Width           =   5655
      End
      Begin VB.TextBox txtcosto 
         Height          =   375
         Left            =   1320
         MaxLength       =   10
         TabIndex        =   1
         Top             =   1200
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Código Exa."
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   240
         Width           =   1215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Descripción"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   720
         Width           =   1215
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Costo"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   7
         Top             =   1200
         Width           =   855
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Propio"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   1680
         Width           =   855
      End
   End
End
Attribute VB_Name = "FrmExamenesCom"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean
Friend Sub habilitar()
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Frame1.Enabled = Not Frame1.Enabled
  CmdBuscar.Enabled = Not CmdBuscar.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub

Private Sub CmdAnular_Click()
habilitar
Set LIMPIAR = Me
End Sub

Private Sub CmdBuscar_Click()
FrmBuscarExamenescom.Show 1
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcodexa.Text) = "" Then
    MsgBox "Para Eliminar Debe Buscar Registro..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  If EliminarTabla(txtcodexa, "[EXAMEN COMPLEMENTARIO]", "codexamcompl") > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    Set LIMPIAR = Me
    NUEVO = False
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
If Trim(txtdescripcion) = "" Then
MsgBox "Ingrese Descripción...!", vbExclamation
Exit Sub
End If
If optno.Value = False And optsi.Value = False Then
MsgBox "Seleccione Una Opción SI/NO del campo Propio...!", vbExclamation
Exit Sub
End If
If Val(txtcosto) = 0 Then
MsgBox "Ingrese Costo...!", vbExclamation
Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  T.Open "SELECT * FROM [EXAMEN COMPLEMENTARIO]", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!codexamcompl = Trim(txtcodexa)
Else
  T.Open "SELECT * FROM [EXAMEN COMPLEMENTARIO] WHERE codexamcompl='" + txtcodexa + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!descripcion = Trim(txtdescripcion)
  T!COSTO = Val(txtcosto)
  If optsi.Value = True Then T!PROPIO = "SI"
  If optno.Value = True Then T!PROPIO = "NO"
  
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  Set LIMPIAR = Me
  Exit Sub
L:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub

Private Sub CmdModificar_Click()
If Trim(txtcodexa) = "" Then
MsgBox "BUSCAR REGISTRO...!", vbExclamation
Exit Sub
End If
NUEVO = False
habilitar
txtdescripcion.SetFocus
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
Set LIMPIAR = Me
optsi.Value = True
txtcodexa = codigoEXAcomplem
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
EXAMENCOMPL = True
End Sub

Private Sub Label6_Click()
End Sub

Private Sub Form_Unload(Cancel As Integer)
EXAMENCOMPL = False
Set FrmExamenesCom = Nothing
End Sub

Private Sub txtcosto_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 3
End Sub

Private Sub txtcosto_LostFocus()
txtcosto = Format$(Val(txtcosto), "###.00")
End Sub

Private Sub txtdescripcion_GotFocus()
txtdescripcion.SelStart = 0
txtdescripcion.SelLength = Len(txtdescripcion)

End Sub

Private Sub txtdescripcion_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub
