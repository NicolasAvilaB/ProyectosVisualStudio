VERSION 5.00
Begin VB.Form Frmestadiscliexdist 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "ESTADÍSTICAS DE CLIENTES POR DISTRITOS"
   ClientHeight    =   1905
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5400
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
   Icon            =   "Frmestadiscliexdist.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   1905
   ScaleWidth      =   5400
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton CMD2 
      BackColor       =   &H80000013&
      Caption         =   "GRAFICO TARTA"
      Height          =   1455
      Left            =   2880
      Picture         =   "Frmestadiscliexdist.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   240
      Width           =   1935
   End
   Begin VB.CommandButton CMD1 
      BackColor       =   &H80000013&
      Caption         =   "GRAFICO BARRAS"
      Height          =   1455
      Left            =   600
      Picture         =   "Frmestadiscliexdist.frx":5CFC
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   240
      Width           =   1935
   End
End
Attribute VB_Name = "Frmestadiscliexdist"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CMD1_Click()
V_GRAFICO = 1
FrmReportes.Show 1
End Sub

Private Sub CMD2_Click()
V_GRAFICO = 2
FrmReportes.Show 1
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
V_GRAFICO = 0
End Sub
