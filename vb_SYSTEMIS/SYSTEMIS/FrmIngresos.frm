VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmIngresos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "REPORTE DE INGRESOS"
   ClientHeight    =   2385
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5400
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmIngresos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2385
   ScaleWidth      =   5400
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CmdVistaPrevia 
      BackColor       =   &H80000013&
      Caption         =   "&VISTA PREVIA"
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
      Left            =   1200
      Picture         =   "FrmIngresos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1440
      Width           =   1455
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
      Left            =   2880
      Picture         =   "FrmIngresos.frx":074C
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   1440
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   5175
      Begin VB.TextBox txtf2 
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
         Left            =   3600
         TabIndex        =   2
         Tag             =   "1"
         Top             =   480
         Width           =   1215
      End
      Begin VB.TextBox txtf1 
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
         Left            =   1080
         TabIndex        =   1
         Tag             =   "1"
         Top             =   480
         Width           =   1215
      End
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   375
         Left            =   4800
         TabIndex        =   3
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   661
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39283
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   375
         Left            =   2280
         TabIndex        =   4
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   661
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39283
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
         TabIndex        =   6
         Top             =   480
         Width           =   975
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
         TabIndex        =   5
         Top             =   480
         Width           =   975
      End
   End
End
Attribute VB_Name = "FrmIngresos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub CmdVistaPrevia_Click()
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
V_INGRESOS = True
DTPicker1.Value = DateSerial(Year(Date), Month(Date), 1)
txtf1 = DateSerial(Year(Date), Month(Date), 1)
DTPicker2.Value = DateSerial(Year(Date), Month(Date), 2)
txtf2 = DateSerial(Year(Date), Month(Date), 2)
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_INGRESOS = False
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
