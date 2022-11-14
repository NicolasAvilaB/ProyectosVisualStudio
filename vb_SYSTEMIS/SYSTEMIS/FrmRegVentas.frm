VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmRegVentas 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REGISTRO DE VENTAS"
   ClientHeight    =   2505
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4080
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
   Icon            =   "FrmRegVentas.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2505
   ScaleWidth      =   4080
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   2040
      Picture         =   "FrmRegVentas.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1560
      Width           =   1455
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   480
      Picture         =   "FrmRegVentas.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   1560
      Width           =   1455
   End
   Begin VB.PictureBox Picture4 
      BackColor       =   &H00B0726D&
      Height          =   1335
      Left            =   120
      ScaleHeight     =   1275
      ScaleWidth      =   3795
      TabIndex        =   0
      Top             =   120
      Width           =   3855
      Begin VB.TextBox tm2 
         Height          =   315
         Left            =   1440
         MaxLength       =   10
         TabIndex        =   2
         Top             =   600
         Width           =   1455
      End
      Begin VB.TextBox tm1 
         Height          =   315
         Left            =   1440
         MaxLength       =   10
         TabIndex        =   1
         Top             =   240
         Width           =   1455
      End
      Begin MSComCtl2.DTPicker dtm1 
         Height          =   315
         Left            =   2880
         TabIndex        =   3
         Top             =   240
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   47841281
         CurrentDate     =   39318
      End
      Begin MSComCtl2.DTPicker dtm2 
         Height          =   315
         Left            =   2880
         TabIndex        =   4
         Top             =   600
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   47841281
         CurrentDate     =   39318
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   480
         TabIndex        =   6
         Top             =   600
         Width           =   1095
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   480
         TabIndex        =   5
         Top             =   240
         Width           =   1095
      End
   End
End
Attribute VB_Name = "FrmRegVentas"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdSalir_Click()
Unload Me
End Sub
Private Sub CmdVImprimir_Click()
If tm1 = "" Then
    MsgBox "Ingrese Fecha 1 ...!", vbInformation
    Exit Sub
End If
If tm2 = "" Then
    MsgBox "Ingrese Fecha 2 ...!", vbInformation
    Exit Sub
End If
FrmReportes.Show 1
End Sub
Private Sub dtm2_Change()
tm2 = Format$(CDate(dtm2.Value), "dd/mm/yyyy")
End Sub
Private Sub dtm1_Change()
tm1 = Format$(CDate(dtm1.Value), "dd/mm/yyyy")
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
dtm1.Value = DateAdd("d", -1, CDate(dtm1.Value))
dtm2.Value = DateAdd("d", 1, CDate(dtm2.Value))
tm1 = Format$(CDate(dtm1.Value), "dd/mm/yyyy")
tm2 = Format$(CDate(dtm2.Value), "dd/mm/yyyy")
V_REGISTRODEVENTAS = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_REGISTRODEVENTAS = False
End Sub

Private Sub tm1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub tm1_LostFocus()
If IsDate(tm1) = True Then
  tm1 = FormatDateTime(CDate(tm1), vbShortDate)
  Else
  tm1 = ""
End If
End Sub
Private Sub tm2_LostFocus()
If IsDate(tm2) = True Then
  tm2 = FormatDateTime(CDate(tm2), vbShortDate)
  Else
  tm2 = ""
End If
End Sub
Private Sub tm2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

