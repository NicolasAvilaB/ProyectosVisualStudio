VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form FrmKardex 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "KARDEX DE ALMACÉN"
   ClientHeight    =   3045
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7845
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
   Icon            =   "FrmKardex.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3045
   ScaleWidth      =   7845
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture4 
      BackColor       =   &H00B0726D&
      Height          =   1575
      Left            =   3120
      ScaleHeight     =   1515
      ScaleWidth      =   4275
      TabIndex        =   33
      Top             =   120
      Visible         =   0   'False
      Width           =   4335
      Begin VB.CommandButton cmdmarca 
         BackColor       =   &H80000017&
         Height          =   315
         Left            =   3840
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmKardex.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   37
         ToolTipText     =   "BUSCAR MARCA"
         Top             =   1080
         Width           =   375
      End
      Begin VB.TextBox txtmarca 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   120
         Locked          =   -1  'True
         MaxLength       =   10
         TabIndex        =   36
         Top             =   1080
         Width           =   3735
      End
      Begin VB.TextBox tm1 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   35
         Top             =   120
         Width           =   1455
      End
      Begin VB.TextBox tm2 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   34
         Top             =   480
         Width           =   1455
      End
      Begin MSComCtl2.DTPicker dtm1 
         Height          =   315
         Left            =   2520
         TabIndex        =   38
         Top             =   120
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin MSComCtl2.DTPicker dtm2 
         Height          =   315
         Left            =   2520
         TabIndex        =   39
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "Marca"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   42
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   41
         Top             =   120
         Width           =   1095
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   40
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.PictureBox Picture3 
      BackColor       =   &H00B0726D&
      Height          =   1575
      Left            =   3120
      ScaleHeight     =   1515
      ScaleWidth      =   4275
      TabIndex        =   23
      Top             =   120
      Visible         =   0   'False
      Width           =   4335
      Begin VB.TextBox t2 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   27
         Top             =   480
         Width           =   1455
      End
      Begin VB.TextBox t1 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   26
         Top             =   120
         Width           =   1455
      End
      Begin VB.TextBox txtsubcategoria 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   120
         Locked          =   -1  'True
         MaxLength       =   10
         TabIndex        =   25
         Top             =   1080
         Width           =   3735
      End
      Begin VB.CommandButton cmdsubcaategoria 
         BackColor       =   &H80000017&
         Height          =   315
         Left            =   3840
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmKardex.frx":083C
         Style           =   1  'Graphical
         TabIndex        =   24
         ToolTipText     =   "BUSCAR SUB-CATEGORÍA"
         Top             =   1080
         Width           =   375
      End
      Begin MSComCtl2.DTPicker dt1 
         Height          =   315
         Left            =   2520
         TabIndex        =   28
         Top             =   120
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin MSComCtl2.DTPicker dt2 
         Height          =   315
         Left            =   2520
         TabIndex        =   29
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   32
         Top             =   480
         Width           =   1095
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   31
         Top             =   120
         Width           =   1095
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Sub-Categoría"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   30
         Top             =   840
         Width           =   1815
      End
   End
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   1575
      Left            =   3120
      ScaleHeight     =   1515
      ScaleWidth      =   4275
      TabIndex        =   13
      Top             =   120
      Visible         =   0   'False
      Width           =   4335
      Begin VB.CommandButton cmdcategoria 
         BackColor       =   &H80000017&
         Height          =   315
         Left            =   3840
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmKardex.frx":0D6E
         Style           =   1  'Graphical
         TabIndex        =   22
         ToolTipText     =   "BUSCAR CATEGORÍA"
         Top             =   1080
         Width           =   375
      End
      Begin VB.TextBox txtcategoria 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   120
         Locked          =   -1  'True
         MaxLength       =   10
         TabIndex        =   20
         Top             =   1080
         Width           =   3735
      End
      Begin VB.TextBox txtf1 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   16
         Top             =   120
         Width           =   1455
      End
      Begin VB.TextBox txtf2 
         Height          =   315
         Left            =   1080
         MaxLength       =   10
         TabIndex        =   15
         Top             =   480
         Width           =   1455
      End
      Begin MSComCtl2.DTPicker dtpick1 
         Height          =   315
         Left            =   2520
         TabIndex        =   14
         Top             =   120
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin MSComCtl2.DTPicker dtpick2 
         Height          =   315
         Left            =   2520
         TabIndex        =   19
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Categoría"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   21
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   18
         Top             =   120
         Width           =   1095
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   17
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.OptionButton optporcategoria 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Categoría"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   10
      Top             =   480
      Width           =   2655
   End
   Begin VB.OptionButton optpomarca 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Marca"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   9
      Top             =   1200
      Width           =   2295
   End
   Begin VB.OptionButton optporsubcategoria 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Sub-Categoría"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   840
      Width           =   2895
   End
   Begin VB.OptionButton opttodos 
      BackColor       =   &H00B0726D&
      Caption         =   "Todos Los Productos"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Value           =   -1  'True
      Width           =   2895
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   3720
      Picture         =   "FrmKardex.frx":12A0
      Style           =   1  'Graphical
      TabIndex        =   2
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   5280
      Picture         =   "FrmKardex.frx":15AA
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   2040
      Width           =   1455
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      Height          =   1575
      Left            =   3120
      ScaleHeight     =   1515
      ScaleWidth      =   4275
      TabIndex        =   0
      Top             =   120
      Width           =   4335
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   315
         Left            =   3120
         TabIndex        =   12
         Top             =   720
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   315
         Left            =   3120
         TabIndex        =   11
         Top             =   240
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   556
         _Version        =   393216
         Format          =   48234497
         CurrentDate     =   39318
      End
      Begin VB.TextBox txtfecha2 
         Height          =   315
         Left            =   1680
         MaxLength       =   10
         TabIndex        =   6
         Top             =   720
         Width           =   1455
      End
      Begin VB.TextBox txtfecha1 
         Height          =   315
         Left            =   1680
         MaxLength       =   10
         TabIndex        =   4
         Top             =   240
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 2"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   720
         TabIndex        =   5
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha 1"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   720
         TabIndex        =   3
         Top             =   240
         Width           =   1095
      End
   End
End
Attribute VB_Name = "FrmKardex"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdcategoria_Click()
FrmCategorias.Show 1
End Sub

Private Sub cmdmarca_Click()
FrmMarcas.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub cmdsubcaategoria_Click()
FrmSubCategoria.Show 1
End Sub

Private Sub CmdVImprimir_Click()
If opttodos.Value = True Then
  If txtfecha1 = "" Then
    MsgBox "Ingrese Fecha 1 ...!", vbInformation
    Exit Sub
  End If
  If txtfecha2 = "" Then
    MsgBox "Ingrese Fecha 2 ...!", vbInformation
    Exit Sub
  End If
End If
If optporcategoria.Value = True Then
  If txtf1 = "" Then
    MsgBox "Ingrese Fecha 1 ...!", vbInformation
    Exit Sub
  End If
  If txtf2 = "" Then
    MsgBox "Ingrese Fecha 2 ...!", vbInformation
    Exit Sub
  End If
  If txtcategoria = "" Then
    MsgBox "Buscar Categoría ...!", vbInformation
    Exit Sub
  End If
End If
If optporsubcategoria.Value = True Then
  If t1 = "" Then
    MsgBox "Ingrese Fecha 1 ...!", vbInformation
    Exit Sub
  End If
  If t2 = "" Then
    MsgBox "Ingrese Fecha 2 ...!", vbInformation
    Exit Sub
  End If
  If txtsubcategoria = "" Then
    MsgBox "Buscar Sub-Categoría ...!", vbInformation
    Exit Sub
  End If
End If
If optpomarca.Value = True Then
  If tm1 = "" Then
    MsgBox "Ingrese Fecha 1 ...!", vbInformation
    Exit Sub
  End If
  If tm2 = "" Then
    MsgBox "Ingrese Fecha 2 ...!", vbInformation
    Exit Sub
  End If
  If txtmarca = "" Then
    MsgBox "Buscar Marca ...!", vbInformation
    Exit Sub
  End If
End If
FrmReportes.Show 1
End Sub
Private Sub dt1_Change()
t1 = Format$(CDate(dt1.Value), "dd/mm/yyyy")
End Sub
Private Sub dt2_Change()
t2 = Format$(CDate(dt2.Value), "dd/mm/yyyy")
End Sub

Private Sub dtm1_Change()
tm1 = Format$(CDate(dtm1.Value), "dd/mm/yyyy")
End Sub
Private Sub dtm2_Change()
tm2 = Format$(CDate(dtm2.Value), "dd/mm/yyyy")
End Sub
Private Sub dtpick1_Change()
txtf1 = Format$(CDate(dtpick1.Value), "dd/mm/yyyy")
End Sub
Private Sub dtpick2_Change()
txtf2 = Format$(CDate(dtpick2.Value), "dd/mm/yyyy")
End Sub
Private Sub DTPicker1_Change()
txtfecha1 = Format$(CDate(DTPicker1.Value), "dd/mm/yyyy")
End Sub
Private Sub DTPicker2_Change()
txtfecha2 = Format$(CDate(DTPicker2.Value), "dd/mm/yyyy")
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_KARDEX = True
DTPicker1.Value = DateAdd("d", -1, CDate(DTPicker1.Value))
DTPicker2.Value = DateAdd("d", 1, CDate(DTPicker2.Value))
txtfecha1 = Format$(CDate(DTPicker1.Value), "dd/mm/yyyy")
txtfecha2 = Format$(CDate(DTPicker2.Value), "dd/mm/yyyy")
dtpick1.Value = DateAdd("d", -1, CDate(dtpick1.Value))
dtpick2.Value = DateAdd("d", 1, CDate(dtpick2.Value))
txtf1 = Format$(CDate(dtpick1.Value), "dd/mm/yyyy")
txtf2 = Format$(CDate(dtpick2.Value), "dd/mm/yyyy")
dt1.Value = DateAdd("d", -1, CDate(dt1.Value))
dt2.Value = DateAdd("d", 1, CDate(dt2.Value))
t1 = Format$(CDate(dt1.Value), "dd/mm/yyyy")
t2 = Format$(CDate(dt2.Value), "dd/mm/yyyy")
dtm1.Value = DateAdd("d", -1, CDate(dtm1.Value))
dtm2.Value = DateAdd("d", 1, CDate(dtm2.Value))
tm1 = Format$(CDate(dtm1.Value), "dd/mm/yyyy")
tm2 = Format$(CDate(dtm2.Value), "dd/mm/yyyy")
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_KARDEX = False
End Sub

Private Sub optpomarca_Click()
Picture1.Visible = False
Picture2.Visible = False
Picture3.Visible = False
Picture4.Visible = True
End Sub

Private Sub optporcategoria_Click()
Picture1.Visible = False
Picture2.Visible = True
Picture3.Visible = False
Picture4.Visible = False
End Sub

Private Sub optporsubcategoria_Click()
Picture1.Visible = False
Picture2.Visible = False
Picture3.Visible = True
Picture4.Visible = False
End Sub

Private Sub opttodos_Click()
Picture1.Visible = True
Picture2.Visible = False
Picture3.Visible = False
Picture4.Visible = False
End Sub

Private Sub t1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub t1_LostFocus()
If IsDate(t1) = False Then
    t1 = ""
  Else
    t1 = Format(CDate(t1), "dd/mm/yyyy")
End If
End Sub
Private Sub t2_LostFocus()
If IsDate(t2) = False Then
    t2 = ""
  Else
    t2 = Format(CDate(t2), "dd/mm/yyyy")
End If
End Sub
Private Sub t2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub tm1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub tm1_LostFocus()
If IsDate(tm1) = False Then
    tm1 = ""
  Else
    tm1 = Format(CDate(tm1), "dd/mm/yyyy")
End If
End Sub
Private Sub tm2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub tm2_LostFocus()
If IsDate(tm2) = False Then
    tm2 = ""
  Else
    tm2 = Format(CDate(tm2), "dd/mm/yyyy")
End If
End Sub
Private Sub txtf1_LostFocus()
If IsDate(txtf1) = False Then
    txtf1 = ""
  Else
    txtf1 = Format(CDate(txtf1), "dd/mm/yyyy")
End If
End Sub

Private Sub txtf2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub


Private Sub txtf1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtf2_LostFocus()
If IsDate(txtf2) = False Then
    txtf2 = ""
  Else
    txtf2 = Format(CDate(txtf2), "dd/mm/yyyy")
End If
End Sub

Private Sub txtfecha1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub
Private Sub txtfecha2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub
Private Sub txtfecha1_LostFocus()
If IsDate(txtfecha1) = False Then
    txtfecha1 = ""
  Else
    txtfecha1 = Format(CDate(txtfecha1), "dd/mm/yyyy")
End If
End Sub
Private Sub txtfecha2_LostFocus()
If IsDate(txtfecha2) = False Then
    txtfecha2 = ""
  Else
    txtfecha2 = Format(CDate(txtfecha2), "dd/mm/yyyy")
End If
End Sub
