VERSION 5.00
Begin VB.Form frmverificador 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Verificador de Rut"
   ClientHeight    =   1575
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5295
   Icon            =   "verificador.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   Picture         =   "verificador.frx":0ECA
   ScaleHeight     =   1575
   ScaleWidth      =   5295
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame Frame1 
      Appearance      =   0  'Flat
      BackColor       =   &H00A5EFFA&
      ForeColor       =   &H80000008&
      Height          =   975
      Left            =   1320
      TabIndex        =   2
      Top             =   240
      Width           =   3855
      Begin VB.TextBox txtrut 
         Alignment       =   1  'Right Justify
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   540
         Left            =   1080
         MaxLength       =   8
         TabIndex        =   0
         Top             =   240
         Width           =   1755
      End
      Begin VB.TextBox txtdigito 
         Alignment       =   2  'Center
         Appearance      =   0  'Flat
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   525
         Left            =   3120
         Locked          =   -1  'True
         MaxLength       =   1
         TabIndex        =   1
         TabStop         =   0   'False
         Text            =   "?"
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "-"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   18
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   495
         Left            =   2880
         TabIndex        =   4
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblRut 
         BackStyle       =   0  'Transparent
         Caption         =   "RUN : "
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   13.5
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   120
         TabIndex        =   3
         Top             =   360
         Width           =   795
      End
   End
   Begin VB.Shape Shape1 
      Height          =   1335
      Left            =   120
      Top             =   120
      Width           =   1095
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "www.Lnss@gmail.com"
      ForeColor       =   &H80000004&
      Height          =   255
      Left            =   0
      TabIndex        =   7
      Top             =   6120
      Width           =   1695
   End
   Begin VB.Label Label3 
      Caption         =   "www.Lnss@gmail.com"
      Height          =   255
      Left            =   5280
      TabIndex        =   6
      Top             =   6000
      Width           =   1695
   End
   Begin VB.Label Label2 
      Alignment       =   1  'Right Justify
      BackStyle       =   0  'Transparent
      Caption         =   "www.Lnss@gmail.com"
      Height          =   255
      Left            =   1320
      TabIndex        =   5
      Top             =   1320
      Width           =   3855
   End
   Begin VB.Image Image1 
      Height          =   1275
      Left            =   120
      Picture         =   "verificador.frx":28734
      Stretch         =   -1  'True
      Top             =   120
      Width           =   1095
   End
End
Attribute VB_Name = "frmverificador"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'========================================'
'||     DISEÑADO POR NICOLAS SANFELIU  ||'
'||           IQUIQUE - CHILE          ||'
'||          VERSION: SEP-2008         ||'
'========================================'


Private Sub txtrut_Change()

    If txtRut.Text = "" Then
        txtDigito.Text = "?"
    End If
    
    Dim CAL1, CAL2, CAL3 As Integer
        CAL3 = 2
    
    For I = 0 To Len(txtRut) - 1
    
        CAL1 = CAL1 + Left(Right(txtRut, I + 1), 1) * CAL3
        CAL2 = CAL1 Mod 11
        
            Select Case CAL2
                 Case 0
                  txtDigito.Text = "0"
                 Case 1
                  txtDigito.Text = "K"
                 Case Else
                  txtDigito.Text = 11 - CAL2
            End Select
            
            If CAL3 = 7 Then
                CAL3 = 2
            Else
                CAL3 = CAL3 + 1
            End If
    Next
    
End Sub

Private Sub txtrut_KeyPress(KeyAscii As Integer)

    If IsNumeric(Chr(KeyAscii)) = False And KeyAscii <> 8 Then KeyAscii = 0

End Sub

