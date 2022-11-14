VERSION 5.00
Begin VB.Form FrmIGV 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "I.G.V"
   ClientHeight    =   1065
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5985
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmIGV.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   1065
   ScaleWidth      =   5985
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   855
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   3015
      Begin VB.TextBox txtIGV 
         Alignment       =   1  'Right Justify
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
         Left            =   960
         MaxLength       =   50
         TabIndex        =   3
         Top             =   240
         Width           =   1815
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "I.G.V %"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   240
         TabIndex        =   4
         Top             =   280
         Width           =   735
      End
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
      Height          =   900
      Left            =   4680
      Picture         =   "FrmIGV.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   120
      Width           =   1215
   End
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
      Left            =   3360
      Picture         =   "FrmIGV.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   1215
   End
End
Attribute VB_Name = "FrmIGV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdGuardar_Click()
If Val(txtIGV) < 0 Then
MsgBox "Ingrese I.G.V ...!", vbExclamation
  txtIGV.SetFocus
Exit Sub
End If
If Val(txtIGV) > 100 Then
  MsgBox "Ingrese Una Cantidad entre 1 y 100 ...!", vbInformation
  Exit Sub
End If
If GuardaIGV(txtIGV) > 0 Then
  frmMensajeEditar.Show 1
End If
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then CmdSalir_Click
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
txtIGV = DevuelveIGV()
End Sub

Private Sub txtIGV_GotFocus()
txtIGV.SelStart = 0
txtIGV.SelLength = Len(txtIGV)
End Sub

Private Sub txtIGV_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Moneda
End Sub
