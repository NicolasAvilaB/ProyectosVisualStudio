VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Prueba"
   ClientHeight    =   1545
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   2130
   LinkTopic       =   "Form1"
   ScaleHeight     =   1545
   ScaleWidth      =   2130
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command1 
      Caption         =   "Aceptar"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   1020
      Width           =   1725
   End
   Begin VB.TextBox Text1 
      Height          =   345
      Left            =   120
      TabIndex        =   0
      Top             =   450
      Width           =   1755
   End
   Begin VB.Label Label1 
      Caption         =   "Ingresa el rut"
      Height          =   345
      Left            =   120
      TabIndex        =   2
      Top             =   30
      Width           =   1785
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
'la funcion RuT(cadena de caracteres)=boolean "te entregara un true o false"
    If RuT(Text1) = False Then
        MsgBox ("rut incorrecto")
        Text1 = Empty
        Text1.SetFocus
    Else
        MsgBox ("correcto")
        Text1 = Empty
        Text1.SetFocus
    End If
End Sub
