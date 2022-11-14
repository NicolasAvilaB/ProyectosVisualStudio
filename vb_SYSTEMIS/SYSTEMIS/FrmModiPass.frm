VERSION 5.00
Begin VB.Form FrmModiPass 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "MODIFICACIÓN DE PASSWORD"
   ClientHeight    =   2445
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5370
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmModiPass.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2445
   ScaleWidth      =   5370
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
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
      Left            =   2160
      Picture         =   "FrmModiPass.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   1440
      Width           =   1335
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
      Left            =   3720
      Picture         =   "FrmModiPass.frx":0BD4
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   1440
      Width           =   1335
   End
   Begin VB.TextBox txtanterior 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2640
      PasswordChar    =   "*"
      TabIndex        =   0
      Top             =   120
      Width           =   2535
   End
   Begin VB.TextBox txtnuevo 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2640
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   480
      Width           =   2535
   End
   Begin VB.TextBox txtconfirma 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2640
      PasswordChar    =   "*"
      TabIndex        =   2
      Top             =   840
      Width           =   2535
   End
   Begin VB.Image Image1 
      Height          =   840
      Left            =   360
      Picture         =   "FrmModiPass.frx":0EDE
      Stretch         =   -1  'True
      Top             =   1440
      Width           =   960
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Ingresar Clave Actual"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   360
      TabIndex        =   5
      Top             =   120
      Width           =   3135
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Ingresar Nueva Clave"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   360
      TabIndex        =   4
      Top             =   480
      Width           =   3255
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Conirmar Nueva Clave"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   360
      TabIndex        =   3
      Top             =   840
      Width           =   3255
   End
End
Attribute VB_Name = "FrmModiPass"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Dim Cuenta As Integer
Private Sub CmdGuardar_Click()
If Trim(txtanterior) = "" Then
  MsgBox "Ingrese Clave Actual...!", vbExclamation
  txtanterior.SetFocus
  Exit Sub
End If
If Trim(txtnuevo) = "" Then
  MsgBox "Ingrese Nueva Clave...!", vbExclamation
  txtnuevo.SetFocus
  Exit Sub
End If
If Trim(txtconfirma) = "" Then
  MsgBox "Confirmar Clave...!", vbExclamation
  txtconfirma.SetFocus
  Exit Sub
End If
If Trim(txtnuevo) <> Trim(txtconfirma) Then
  MsgBox "Las Claves No Coinciden...!", vbExclamation
  txtnuevo = ""
  txtconfirma = ""
  txtnuevo.SetFocus
  Exit Sub
End If
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "select * from clave where passwo='" + Trim(txtanterior) + "'", cn, adOpenDynamic, adLockOptimistic
REFRESCAR rs
If rs.RecordCount = 0 Then
  Set rs = Nothing
  Cuenta = Cuenta + 1
  MsgBox "La Clave Es Incorrecta...!"
  If Cuenta = 3 Then Unload Me
  Exit Sub
End If
rs!passwo = Trim(txtnuevo)
rs.Update
Set rs = Nothing
frmMensajeEditar.Show 1
Set LIMPIAR = Me
Exit Sub
L:
MsgBox Err.Description, vbCritical
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
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set FrmModiPass = Nothing
End Sub

Private Sub txtanterior_GotFocus()
txtanterior.SelStart = 0
txtanterior.SelLength = Len(txtanterior)
End Sub

Private Sub txtconfirma_GotFocus()
txtconfirma.SelStart = 0
txtconfirma.SelLength = Len(txtconfirma)
End Sub

Private Sub txtnuevo_GotFocus()
txtnuevo.SelStart = 0
txtnuevo.SelLength = Len(txtnuevo)
End Sub
