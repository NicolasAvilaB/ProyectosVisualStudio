VERSION 5.00
Begin VB.Form FrmClave 
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "CLAVE DEL SISTEMA"
   ClientHeight    =   3345
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   5760
   Icon            =   "FrmClave.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   ScaleHeight     =   3345
   ScaleWidth      =   5760
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox Text2 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2760
      TabIndex        =   0
      Top             =   840
      Width           =   2535
   End
   Begin VB.TextBox Text1 
      Alignment       =   2  'Center
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2760
      PasswordChar    =   "*"
      TabIndex        =   1
      Top             =   1200
      Width           =   2535
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
      Left            =   3960
      Picture         =   "FrmClave.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   4
      Top             =   1680
      Width           =   1335
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&ACEPTAR"
      Default         =   -1  'True
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
      Left            =   2520
      Picture         =   "FrmClave.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   3
      Top             =   1680
      Width           =   1335
   End
   Begin VB.Timer Timer2 
      Interval        =   22
      Left            =   4920
      Top             =   2760
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      BorderStyle     =   0  'None
      DrawStyle       =   5  'Transparent
      FillStyle       =   0  'Solid
      ForeColor       =   &H80000009&
      Height          =   330
      Left            =   1200
      ScaleHeight     =   330
      ScaleWidth      =   3645
      TabIndex        =   2
      Top             =   360
      Width           =   3645
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   0
      Top             =   0
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Usuario"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   1800
      TabIndex        =   9
      Top             =   840
      Width           =   2655
   End
   Begin VB.Label lblTiempo 
      AutoSize        =   -1  'True
      BackStyle       =   0  'Transparent
      Caption         =   "20 segundo(s)"
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
      Height          =   240
      Left            =   2520
      TabIndex        =   8
      Top             =   2640
      Width           =   1485
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      BackStyle       =   0  'Transparent
      Caption         =   "-"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5160
      TabIndex        =   7
      ToolTipText     =   "Minimizar"
      Top             =   -35
      Width           =   495
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "SYSTEMIS V. 1.0"
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
      Left            =   480
      TabIndex        =   6
      Top             =   2640
      Width           =   1935
   End
   Begin VB.Image Image1 
      Height          =   840
      Left            =   480
      Picture         =   "FrmClave.frx":091E
      Stretch         =   -1  'True
      Top             =   1800
      Width           =   960
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Clave "
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H80000014&
      Height          =   255
      Left            =   1800
      TabIndex        =   5
      Top             =   1200
      Width           =   2655
   End
   Begin VB.Shape Shape1 
      BackColor       =   &H80000012&
      BorderColor     =   &H80000012&
      BorderStyle     =   6  'Inside Solid
      BorderWidth     =   2
      FillColor       =   &H00B0726D&
      FillStyle       =   0  'Solid
      Height          =   2835
      Left            =   240
      Shape           =   4  'Rounded Rectangle
      Top             =   240
      Width           =   5370
   End
   Begin VB.Image Image2 
      Height          =   300
      Left            =   1440
      Picture         =   "FrmClave.frx":0C28
      Stretch         =   -1  'True
      Top             =   255
      Width           =   540
   End
End
Attribute VB_Name = "FrmClave"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Long, ByVal hRgn As Long, ByVal bRedraw As Boolean) As Long
Private Declare Function CreateRoundRectRgn Lib "gdi32" (ByVal X1 As Long, ByVal Y1 As Long, ByVal X2 As Long, ByVal Y2 As Long, ByVal X3 As Long, ByVal Y3 As Long) As Long
Friend Sub RedondearVentanita(ByRef Frm As Object, _
                              ByVal x As Long, _
                              ByVal Y As Long)
On Local Error GoTo Errlinea
  Dim xs As Long, ys As Long
  xs = Frm.Width / Screen.TwipsPerPixelX
  ys = Frm.Height / Screen.TwipsPerPixelY
  SetWindowRgn Frm.hwnd, CreateRoundRectRgn(0, 0, xs, ys, x, Y), True
Exit Sub
Errlinea:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical, "SIGECO"
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then CmdSalir_Click
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set FrmClave = Nothing
End Sub

Private Sub Text1_GotFocus()
Text1.SelStart = 0
Text1.SelLength = Len(Text1)
End Sub

Private Sub Text1_KeyPress(KeyAscii As Integer)
If KeyAscii = Asc("'") Then KeyAscii = 0
End Sub

Private Sub Text2_KeyPress(KeyAscii As Integer)
If KeyAscii = Asc("'") Then KeyAscii = 0
End Sub

Private Sub Timer1_Timer()
  Dim I As Integer
  Static c%
  c = c + 1
  lblTiempo.Caption = Str(20 - c) & " segundo(s)"
  If c = 20 Then
     CmdSalir_Click
  End If
End Sub
Private Sub CmdGuardar_Click()
If (Text2) = "" Then
MsgBox "Ingresar Usuario...!", vbExclamation
Text2.Text = ""
Text2.SetFocus
Exit Sub
End If
If (Text1) = "" Then
MsgBox "Ingresar Clave...!", vbExclamation
Text1.Text = ""
Text1.SetFocus
Exit Sub
End If
On Local Error GoTo L
Dim rs As New ADODB.Recordset
rs.Open "SELECT TipoUsua.Destipo,Usuarios.idusuario FROM TipoUsua INNER JOIN Usuarios ON TipoUsua.idtipo = Usuarios.idtipo where passwo='" + Trim(Text1) + "' and nomusu='" + Trim(Text2) + "'", cn, adOpenForwardOnly, adLockReadOnly
REFRESCAR rs
If rs.RecordCount = 0 Then
  Set rs = Nothing
  MsgBox "Incorrecto...!", vbInformation
  Text1 = ""
  Text2 = ""
  Text2.SetFocus
  Exit Sub
End If
TIPO = rs!Destipo
IdUsu = rs!idusuario
Set rs = Nothing
FrmCarga.Show
Unload Me
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
  RedondearVentanita Me, 50, 50
End Sub

Private Sub Form_MouseMove(Button As Integer, Shift As Integer, x As Single, Y As Single)
    If Button = vbLeftButton Then
      Call MoverVentana(Me)
    End If
End Sub

Private Sub Label3_Click()
WindowState = vbMinimized
End Sub

Private Sub Timer2_Timer()
    Const Letrero = "CLAVE DEL SISTEMA"
    Static Anterior As Boolean
    Static tamañoLetrero As Single
    Static x As Single
    If Not Anterior Then
        tamañoLetrero = Picture1.TextWidth(Letrero)
        Anterior = True
        x = Picture1.ScaleWidth
    End If
    Picture1.Cls
    Picture1.CurrentX = x
    Picture1.CurrentY = 0
    Picture1.FontName = "tahoma"
    Picture1.FontBold = True
    Picture1.FontSize = 13
    Picture1.Print Letrero
    x = x - 40
    If x < -tamañoLetrero Then x = Picture1.ScaleWidth
End Sub
