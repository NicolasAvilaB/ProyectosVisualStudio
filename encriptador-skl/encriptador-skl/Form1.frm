VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   4  'Fixed ToolWindow
   Caption         =   "Encriptador"
   ClientHeight    =   2295
   ClientLeft      =   45
   ClientTop       =   315
   ClientWidth     =   3480
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2295
   ScaleWidth      =   3480
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton Command2 
      Caption         =   "Desencriptar"
      Height          =   495
      Left            =   1800
      TabIndex        =   3
      Top             =   1560
      Width           =   1335
   End
   Begin VB.TextBox Text2 
      Height          =   375
      Left            =   480
      TabIndex        =   2
      Top             =   840
      Width           =   2535
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Encriptar SKL"
      Height          =   495
      Left            =   360
      TabIndex        =   1
      Top             =   1560
      Width           =   1335
   End
   Begin VB.TextBox Text1 
      Height          =   285
      Left            =   480
      TabIndex        =   0
      Text            =   "HOLA"
      Top             =   360
      Width           =   2535
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command1_Click()
Dim s As String
s = UCase(Text1)
Text2 = ""
For i = 1 To Len(s)
Text2 = Text2 & "0" & Asc(Mid(s, i, 1))
Next
End Sub

Private Sub Command2_Click()
Dim s As String
s = Text2
Text2 = ""
For i = 1 To Len(s) Step 3
Text2 = Text2 & Chr(Val(Mid(s, i, 3)))
Next
End Sub
