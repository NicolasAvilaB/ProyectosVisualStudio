VERSION 5.00
Begin VB.Form FrmEmpresa 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "EMPRESA"
   ClientHeight    =   2745
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7155
   ForeColor       =   &H00B0726D&
   Icon            =   "FrmEmpresa.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2745
   ScaleWidth      =   7155
   StartUpPosition =   2  'CenterScreen
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
      Height          =   780
      Left            =   5760
      Picture         =   "FrmEmpresa.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   1200
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
      Left            =   5760
      Picture         =   "FrmEmpresa.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   240
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   2655
      Left            =   120
      TabIndex        =   5
      Top             =   0
      Width           =   5535
      Begin VB.TextBox Text2 
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
         MaxLength       =   60
         TabIndex        =   13
         Top             =   2160
         Width           =   4455
      End
      Begin VB.TextBox Text1 
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
         MaxLength       =   60
         TabIndex        =   4
         Top             =   1680
         Width           =   4455
      End
      Begin VB.TextBox txtdireion 
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
         MaxLength       =   60
         TabIndex        =   3
         Top             =   1200
         Width           =   4455
      End
      Begin VB.TextBox txttelefono 
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
         Left            =   3960
         MaxLength       =   20
         TabIndex        =   2
         Top             =   720
         Width           =   1455
      End
      Begin VB.TextBox txtruc 
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
         MaxLength       =   15
         TabIndex        =   1
         Top             =   720
         Width           =   2055
      End
      Begin VB.TextBox txtnombre 
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
         TabIndex        =   0
         Top             =   240
         Width           =   4455
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "E-mail"
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
         Left            =   120
         TabIndex        =   14
         Top             =   2280
         Width           =   855
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Gerente"
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
         Left            =   120
         TabIndex        =   12
         Top             =   1800
         Width           =   855
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Dirección"
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
         Left            =   120
         TabIndex        =   11
         Top             =   1200
         Width           =   855
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Teléfono"
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
         Left            =   3120
         TabIndex        =   10
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "R.U.C"
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
         Left            =   120
         TabIndex        =   9
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Nombre"
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
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   855
      End
   End
End
Attribute VB_Name = "FrmEmpresa"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdGuardar_Click()
On Local Error GoTo L
  cn.Execute "Update EMPRESA SET NOMBRE='" + Trim$(txtnombre) + "',RUC='" + Trim$(txtruc) + "',TELEONOS='" + Trim$(txttelefono) + "', DIRECCION='" + Trim$(txtdireion) + "',dr='" + Text1 + "',email='" + Trim(Text2) + "'"
  frmMensajeEditar.Show 1
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me

End Sub

Private Sub Form_Load()
On Local Error GoTo L
  Dim rs As New ADODB.Recordset
  rs.Open "EMPRESA", cn, adOpenForwardOnly, adLockReadOnly, adCmdTable
  txtnombre = rs!Nombre
  txtruc = rs!ruc
  txttelefono = rs!TELEONOS
  txtdireion = rs!direccion
  Text1 = rs!dr
  Text2 = rs!email
  rs.Close
  Set rs = Nothing
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set FrmEmpresa = Nothing
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtdireion_GotFocus()
txtdireion.SelStart = 0
txtdireion.SelLength = Len(txtdireion)
End Sub

Private Sub txtdireion_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtnombre_GotFocus()
txtnombre.SelStart = 0
txtnombre.SelLength = Len(txtnombre)
End Sub

Private Sub TxtNombre_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtruc_GotFocus()
txtruc.SelStart = 0
txtruc.SelLength = Len(txtruc)

End Sub

Private Sub txtruc_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txttelefono_GotFocus()
txttelefono.SelStart = 0
txttelefono.SelLength = Len(txttelefono)

End Sub

Private Sub txttelefono_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, Apostrofe
End Sub
