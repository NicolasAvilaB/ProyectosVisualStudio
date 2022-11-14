VERSION 5.00
Object = "{86CF1D34-0C5F-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCT2.OCX"
Begin VB.Form frmventasporpromotor 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "VENTAS POR PROMOTOR"
   ClientHeight    =   2055
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5685
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
   Icon            =   "frmventasporpromotor.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   2055
   ScaleWidth      =   5685
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      BackColor       =   &H80000013&
      Caption         =   "Cerrar"
      Height          =   375
      Left            =   240
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   1560
      Width           =   1095
   End
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   1815
      Left            =   1800
      ScaleHeight     =   1755
      ScaleWidth      =   3675
      TabIndex        =   4
      Top             =   120
      Visible         =   0   'False
      Width           =   3735
      Begin VB.TextBox txtfecha1 
         Height          =   285
         Left            =   720
         TabIndex        =   16
         Top             =   720
         Width           =   1335
      End
      Begin VB.TextBox txtfecha2 
         Height          =   285
         Left            =   720
         TabIndex        =   15
         Top             =   1080
         Width           =   1335
      End
      Begin VB.ComboBox cmbpromotor 
         Height          =   315
         Left            =   120
         Sorted          =   -1  'True
         TabIndex        =   7
         Top             =   360
         Width           =   3495
      End
      Begin VB.CommandButton Command3 
         BackColor       =   &H80000013&
         Caption         =   "Visualizar"
         Height          =   375
         Left            =   2520
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   1320
         Width           =   1095
      End
      Begin MSComCtl2.DTPicker dtfefcha1 
         Height          =   285
         Left            =   2040
         TabIndex        =   14
         Top             =   720
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   503
         _Version        =   393216
         Format          =   21037057
         CurrentDate     =   39353
      End
      Begin MSComCtl2.DTPicker dtfecha2 
         Height          =   285
         Left            =   2040
         TabIndex        =   17
         Top             =   1080
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   503
         _Version        =   393216
         Format          =   21037057
         CurrentDate     =   39353
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Desde"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   720
         Width           =   1095
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Hasta"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   1080
         Width           =   1095
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Promotor"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   120
         Width           =   975
      End
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      Height          =   1815
      Left            =   1800
      ScaleHeight     =   1755
      ScaleWidth      =   3675
      TabIndex        =   2
      Top             =   120
      Width           =   3735
      Begin MSComCtl2.DTPicker DTPicker1 
         Height          =   285
         Left            =   2640
         TabIndex        =   12
         Top             =   120
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   503
         _Version        =   393216
         Format          =   21037057
         CurrentDate     =   39353
      End
      Begin VB.TextBox txtf2 
         Height          =   285
         Left            =   1320
         TabIndex        =   11
         Top             =   480
         Width           =   1335
      End
      Begin VB.TextBox txtf1 
         Height          =   285
         Left            =   1320
         TabIndex        =   10
         Top             =   120
         Width           =   1335
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H80000013&
         Caption         =   "Visualizar"
         Height          =   375
         Left            =   1440
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   1200
         Width           =   1095
      End
      Begin MSComCtl2.DTPicker DTPicker2 
         Height          =   285
         Left            =   2640
         TabIndex        =   13
         Top             =   480
         Width           =   255
         _ExtentX        =   450
         _ExtentY        =   503
         _Version        =   393216
         Format          =   21037057
         CurrentDate     =   39353
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Hasta"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   720
         TabIndex        =   9
         Top             =   480
         Width           =   1095
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Desde"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   720
         TabIndex        =   8
         Top             =   120
         Width           =   1095
      End
   End
   Begin VB.OptionButton Option2 
      BackColor       =   &H00B0726D&
      Caption         =   "Por Promotor"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   720
      Width           =   1575
   End
   Begin VB.OptionButton Option1 
      BackColor       =   &H00B0726D&
      Caption         =   "Todos"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Value           =   -1  'True
      Width           =   1095
   End
End
Attribute VB_Name = "frmventasporpromotor"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False


Private Sub Command1_Click()
If Trim$(txtf1) = "" Then
MsgBox "Ingresar Fecha Desde ...!", vbExclamation
Exit Sub
End If
If Trim$(txtf2) = "" Then
MsgBox "Ingresar Fecha Hasta ...!", vbExclamation
Exit Sub
End If
FrmReportes.Show 1
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command3_Click()
If Trim$(cmbpromotor) = "" Then
MsgBox "Ingrese Promotor ...!", vbExclamation
Exit Sub
End If
If Trim$(txtfecha1) = "" Then
MsgBox "Ingrese Fecha Desde ...!", vbExclamation
Exit Sub
End If
If Trim$(txtfecha2) = "" Then
MsgBox "Ingrese Fecha Hasta ...!", vbExclamation
Exit Sub
End If
FrmReportes.Show 1
End Sub
Private Sub dtfecha2_Change()
txtfecha2 = Format$(CDate(dtfecha2.Value), "dd/mm/yyyy")
End Sub
Private Sub dtfefcha1_Change()
txtfecha1 = Format$(CDate(dtfefcha1.Value), "dd/mm/yyyy")
End Sub

Private Sub DTPicker1_Change()
txtf1 = Format$(CDate(DTPicker1.Value), "dd/mm/yyyy")
End Sub
Private Sub DTPicker2_Change()
txtf2 = Format$(CDate(DTPicker2.Value), "dd/mm/yyyy")
End Sub
Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_PROMOTORVENTAS = True
P_RellenaCombo "promotor", cmbpromotor
DTPicker1.Value = DateAdd("d", -1, CDate(DTPicker1.Value))
DTPicker2.Value = DateAdd("d", 1, CDate(DTPicker2.Value))
txtf1.Text = Format$(CDate(DTPicker1.Value), "dd/mm/yyyy")
txtf2.Text = Format$(CDate(DTPicker2.Value), "dd/mm/yyyy")
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_PROMOTORVENTAS = False
End Sub

Private Sub Option1_Click()
Picture1.Visible = True
Picture2.Visible = False
End Sub

Private Sub Option2_Click()
Picture1.Visible = False
Picture2.Visible = True
End Sub

Private Sub txtf1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtf1_LostFocus()
If IsDate(txtf1) = True Then
    txtf1 = Format(CDate(txtf1), "dd/mm/yyyy")
Else
    txtf1.Text = ""
End If
End Sub

Private Sub txtf2_LostFocus()
If IsDate(txtf2) = True Then
    txtf2 = Format(CDate(txtf2), "dd/mm/yyyy")
Else
    txtf2.Text = ""
End If
End Sub

Private Sub txtf2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtfecha1_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtfecha1_LostFocus()
If IsDate(txtfecha1) = True Then
    txtfecha1 = Format(CDate(txtfecha1), "dd/mm/yyyy")
Else
    txtfecha1.Text = ""
End If
End Sub
Private Sub txtfecha2_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Fecha
End Sub

Private Sub txtfecha2_LostFocus()
If IsDate(txtfecha2) = True Then
    txtfecha2 = Format(CDate(txtfecha2), "dd/mm/yyyy")
Else
    txtfecha2.Text = ""
End If
End Sub
