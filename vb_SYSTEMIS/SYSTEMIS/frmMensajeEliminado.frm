VERSION 5.00
Begin VB.Form frmMensajeEliminado 
   BackColor       =   &H00B0726D&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   810
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   3885
   ForeColor       =   &H00B0726D&
   Icon            =   "frmMensajeEliminado.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   810
   ScaleWidth      =   3885
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.Timer Timer1 
      Interval        =   500
      Left            =   840
      Top             =   120
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "ELIMINADO"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   19.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000009&
      Height          =   495
      Left            =   -120
      TabIndex        =   0
      Top             =   120
      Width           =   3975
   End
End
Attribute VB_Name = "frmMensajeEliminado"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Click()
  Unload Me
End Sub

Private Sub Form_Deactivate()
  Unload Me
End Sub

Private Sub Form_KeyPress(KeyAscii As Integer)
  If KeyAscii = 27 Then Unload Me
End Sub

Private Sub Form_Load()
Top = 0
Left = 0
End Sub

Private Sub Label1_Click()
  Unload Me
End Sub

Private Sub Timer1_Timer()
Unload Me
End Sub
