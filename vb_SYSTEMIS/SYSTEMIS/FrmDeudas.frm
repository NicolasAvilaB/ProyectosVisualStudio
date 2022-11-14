VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmDeudas 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REPORTE DE DEUDAS DE CRÉDITOS"
   ClientHeight    =   2760
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5490
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
   Icon            =   "FrmDeudas.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2760
   ScaleWidth      =   5490
   StartUpPosition =   2  'CenterScreen
   Begin VB.OptionButton Option2 
      BackColor       =   &H00B0726D&
      Caption         =   "Por Cliente"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   2640
      TabIndex        =   10
      Top             =   120
      Width           =   1335
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H00B0726D&
      Caption         =   "Todos"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   1440
      TabIndex        =   9
      Top             =   120
      Value           =   -1  'True
      Width           =   975
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   1215
      Left            =   120
      TabIndex        =   2
      Top             =   480
      Width           =   5175
      Begin VB.TextBox Text2 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   13
         Top             =   720
         Visible         =   0   'False
         Width           =   4455
      End
      Begin VB.CommandButton cmdDUEÑO 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   4560
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmDeudas.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   12
         ToolTipText     =   "BUSCAR DUEÑO"
         Top             =   240
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.TextBox Text1 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   11
         Top             =   240
         Visible         =   0   'False
         Width           =   4455
      End
      Begin VB.TextBox txtf1 
         Height          =   375
         Left            =   1080
         TabIndex        =   4
         Tag             =   "1"
         Top             =   480
         Width           =   1215
      End
      Begin VB.TextBox txtf2 
         Height          =   375
         Left            =   3600
         TabIndex        =   3
         Tag             =   "1"
         Top             =   480
         Width           =   1215
      End
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   375
         Left            =   4800
         TabIndex        =   5
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   661
         _Version        =   393216
         Format          =   48496641
         CurrentDate     =   39283
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   375
         Left            =   2280
         TabIndex        =   6
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   661
         _Version        =   393216
         Format          =   48496641
         CurrentDate     =   39283
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
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
         Height          =   255
         Left            =   120
         TabIndex        =   8
         Top             =   480
         Width           =   975
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
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
         Height          =   255
         Left            =   2640
         TabIndex        =   7
         Top             =   480
         Width           =   975
      End
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   2880
      Picture         =   "FrmDeudas.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   1800
      Width           =   1455
   End
   Begin VB.CommandButton CmdVistaPrevia 
      BackColor       =   &H80000013&
      Caption         =   "&VISTA PREVIA"
      Height          =   855
      Left            =   1200
      Picture         =   "FrmDeudas.frx":0B46
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   1800
      Width           =   1455
   End
End
Attribute VB_Name = "FrmDeudas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdDUEÑO_Click()
frmBuscarDueño.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub CmdVistaPrevia_Click()
If Option1.Value = True Then
If txtf1 = "" Then
  MsgBox "Ingrese Fecha 1 ...!", vbExclamation
  txtf1.SetFocus
  Exit Sub
End If
If txtf2 = "" Then
  MsgBox "Ingrese Fecha 2 ...!", vbExclamation
  txtf2.SetFocus
  Exit Sub
End If

End If
If Option2.Value = True Then
If Text1 = "" Then
  MsgBox "Buscar Cliente o Dueño ...!", vbExclamation
  Exit Sub
End If
If Text2 = "" Then
  MsgBox "Ingrese  Cliente o Dueño...!", vbExclamation
  Exit Sub
End If
End If
FrmReportes.Show 1
End Sub
Private Sub DTPicker1_Change()
txtf1 = FormatDateTime(CDate(DTPicker1.Value), vbShortDate)
End Sub

Private Sub DTPicker2_Change()
txtf2 = Format$(CDate(DTPicker2.Value), "DD/MM/YYYY")
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_DEUDASS = True
DTPicker1.Value = DateSerial(Year(Date), Month(Date), 1)
txtf1 = DateSerial(Year(Date), Month(Date), 1)
DTPicker2.Value = DateSerial(Year(Date), Month(Date), 2)
txtf2 = DateSerial(Year(Date), Month(Date), 2)
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_DEUDASS = False
End Sub

Private Sub Option1_Click()
Text1.Visible = False
Text2.Visible = False
cmdDUEÑO.Visible = False
Label1.Visible = True
Label2.Visible = True
txtf1.Visible = True
txtf2.Visible = True
DTPicker1.Visible = True
DTPicker2.Visible = True
End Sub

Private Sub Option2_Click()
Text1.Visible = True
Text2.Visible = True
cmdDUEÑO.Visible = True
Label1.Visible = False
Label2.Visible = False
txtf1.Visible = False
txtf2.Visible = False
DTPicker1.Visible = False
DTPicker2.Visible = False
End Sub

Private Sub txtf1_GotFocus()
txtf1.SelStart = 0
txtf1.SelLength = Len(txtf1)

End Sub

Private Sub txtf1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtf1_LostFocus()
  If IsDate(txtf1) = False Then
    txtf1 = Empty
  Else
    txtf1 = Format(CDate(txtf1), "dd/mm/yyyy")
  End If
End Sub

Private Sub txtf2_GotFocus()
txtf2.SelStart = 0
txtf2.SelLength = Len(txtf2)
End Sub

Private Sub txtf2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, 1
End Sub

Private Sub txtf2_LostFocus()
  If IsDate(txtf2) = False Then
    txtf2 = Empty
  Else
    txtf2 = Format(CDate(txtf2), "dd/mm/yyyy")
  End If
End Sub

