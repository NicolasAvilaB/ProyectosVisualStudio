VERSION 5.00
Begin VB.Form frmRut 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Digito verificador..."
   ClientHeight    =   795
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   2550
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   795
   ScaleWidth      =   2550
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtDigito 
      Alignment       =   2  'Center
      Height          =   285
      Left            =   1950
      Locked          =   -1  'True
      MaxLength       =   1
      TabIndex        =   9
      TabStop         =   0   'False
      Top             =   60
      Width           =   255
   End
   Begin VB.PictureBox picLimpiar 
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   2
      Left            =   30
      Picture         =   "Rut.frx":0000
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   6
      Top             =   1200
      Visible         =   0   'False
      Width           =   1230
   End
   Begin VB.PictureBox picSalir 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   2
      Left            =   1290
      Picture         =   "Rut.frx":149A
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   5
      Top             =   1200
      Visible         =   0   'False
      Width           =   1230
   End
   Begin VB.PictureBox picLimpiar 
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   1
      Left            =   30
      Picture         =   "Rut.frx":2934
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   4
      Top             =   840
      Visible         =   0   'False
      Width           =   1230
   End
   Begin VB.PictureBox picSalir 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   1
      Left            =   1290
      Picture         =   "Rut.frx":3DCE
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   3
      Top             =   840
      Visible         =   0   'False
      Width           =   1230
   End
   Begin VB.PictureBox picLimpiar 
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   0
      Left            =   30
      Picture         =   "Rut.frx":5268
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   2
      Top             =   420
      Width           =   1230
   End
   Begin VB.PictureBox picSalir 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   315
      Index           =   0
      Left            =   1290
      Picture         =   "Rut.frx":6702
      ScaleHeight     =   315
      ScaleWidth      =   1230
      TabIndex        =   1
      Top             =   420
      Width           =   1230
   End
   Begin VB.TextBox txtRut 
      Alignment       =   1  'Right Justify
      Height          =   285
      Left            =   848
      MaxLength       =   11
      TabIndex        =   0
      Top             =   60
      Width           =   1035
   End
   Begin VB.Label lblRut 
      Caption         =   ":"
      Height          =   195
      Index           =   1
      Left            =   720
      TabIndex        =   8
      Top             =   120
      Width           =   75
   End
   Begin VB.Label lblRut 
      Caption         =   "Rut"
      Height          =   195
      Index           =   0
      Left            =   360
      TabIndex        =   7
      Top             =   120
      Width           =   315
   End
End
Attribute VB_Name = "frmRut"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    Static varMostrarMenu As Boolean
    Dim Ya_Existe As Integer
    Ya_Existe = App.PrevInstance
    Call funcHookText(txtRut)
    Call funcHookText(txtDigito)
    varMostrarMenu = True
    If Ya_Existe <> 0 Then
     End
    End If
End Sub

Private Sub Form_QueryUnload(Cancel As Integer, UnloadMode As Integer)
    Call funcUnHookText
End Sub

Private Sub picLimpiar_Click(Index As Integer)
    txtRut.Text = ""
    txtDigito.Text = ""
    txtRut.SetFocus
End Sub

Private Sub picLimpiar_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    picLimpiar(0).Picture = picLimpiar(2).Picture
End Sub

Private Sub picLimpiar_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    picLimpiar(0).Picture = picLimpiar(1).Picture
End Sub

Private Sub picSalir_Click(Index As Integer)
    End
End Sub

Private Sub picSalir_MouseDown(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    picSalir(0).Picture = picSalir(2).Picture
End Sub

Private Sub picSalir_MouseUp(Index As Integer, Button As Integer, Shift As Integer, X As Single, Y As Single)
    picSalir(0).Picture = picSalir(1).Picture
End Sub

Private Sub txtRut_Change()
    If txtRut.Text = "" Then
     txtDigito.Text = ""
    End If
    Dim Vari1, Vari2, Vari3 As Integer
    Vari3 = 2
    For I = 0 To Len(txtRut) - 1
     If Left(Right(txtRut, I + 1), 1) <> "." Then
      Vari1 = Vari1 + Left(Right(txtRut, I + 1), 1) * Vari3
      Vari2 = Vari1 Mod 11
      Select Case Vari2
       Case 0
        txtDigito.Text = "0"
       Case 1
        txtDigito.Text = "K"
       Case Else
        txtDigito.Text = 11 - Vari2
      End Select
      If Vari3 = 7 Then
       Vari3 = 2
      Else
       Vari3 = Vari3 + 1
      End If
     End If
    Next
End Sub

Private Sub txtRut_KeyPress(KeyAscii As Integer)
    If (KeyAscii < Asc(0) Or KeyAscii > Asc(9)) And KeyAscii <> 8 And KeyAscii <> 46 Then
     KeyAscii = 0
    End If
End Sub
