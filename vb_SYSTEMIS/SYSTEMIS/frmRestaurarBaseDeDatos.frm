VERSION 5.00
Begin VB.Form frmRestaurarBaseDeDatos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "RESTAURAR BASE DE DATOS"
   ClientHeight    =   5610
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   6345
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
   Icon            =   "frmRestaurarBaseDeDatos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   5610
   ScaleWidth      =   6345
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Cmd 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&Salir"
      Height          =   855
      Index           =   1
      Left            =   4920
      Picture         =   "frmRestaurarBaseDeDatos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   7
      ToolTipText     =   "Hacer Click Para Crear Nueva Carpeta En El Directorio Seleccionado"
      Top             =   4560
      Width           =   1215
   End
   Begin VB.FileListBox File1 
      BackColor       =   &H8000000E&
      ForeColor       =   &H80000007&
      Height          =   3600
      Left            =   3360
      MouseIcon       =   "frmRestaurarBaseDeDatos.frx":0614
      MousePointer    =   99  'Custom
      Pattern         =   "*.mdb"
      TabIndex        =   3
      ToolTipText     =   "Seleccione La Base de Datos"
      Top             =   840
      Width           =   2895
   End
   Begin VB.DriveListBox Drive1 
      BackColor       =   &H8000000E&
      ForeColor       =   &H80000007&
      Height          =   315
      Left            =   2880
      TabIndex        =   2
      ToolTipText     =   "Seleccionar Ruta Origen En La Se Encuentra El Backup "
      Top             =   120
      Width           =   3375
   End
   Begin VB.DirListBox Dir1 
      BackColor       =   &H8000000E&
      ForeColor       =   &H80000007&
      Height          =   4590
      Left            =   120
      MouseIcon       =   "frmRestaurarBaseDeDatos.frx":091E
      MousePointer    =   99  'Custom
      TabIndex        =   1
      ToolTipText     =   "Seleccionar Directorio En En Cual Se Encuentra La Base de Datos (B01031981)"
      Top             =   840
      Width           =   3135
   End
   Begin VB.CommandButton Cmd 
      BackColor       =   &H80000013&
      Caption         =   "&Restaurar"
      Height          =   870
      Index           =   0
      Left            =   3480
      Picture         =   "frmRestaurarBaseDeDatos.frx":0C28
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   4560
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Seleccionar Unidad de Origen"
      ForeColor       =   &H80000014&
      Height          =   375
      Index           =   0
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   2775
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Seleccionar Directorio de Origen"
      ForeColor       =   &H80000014&
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   5
      Top             =   600
      Width           =   2895
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Seleccionar Base de Datos"
      ForeColor       =   &H80000014&
      Height          =   255
      Index           =   2
      Left            =   3360
      TabIndex        =   4
      Top             =   600
      Width           =   2415
   End
End
Attribute VB_Name = "frmRestaurarBaseDeDatos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Private Declare Function CopyFile Lib "kernel32" Alias "CopyFileA" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal bFailIfExists As Long) As Long

Private Sub CMD_Click(Index As Integer)
On Local Error GoTo P
If Index = 0 Then
  If MsgBox("¿Desea Restaurar Base de Datos...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
    Exit Sub
  End If
  If Right(IIf(Right(File1.Path, 1) = "\", File1.Path, File1.Path + "\") + File1.FileName, 13) = "COPIAmela.mdb" Then
      Screen.MousePointer = vbHourglass
        Dim I As Long
        I = CopyFile(IIf(Right(File1.Path, 1) = "\", File1.Path, File1.Path + "\") + File1.FileName, App.Path + "\mela.mdb", 0)
        Screen.MousePointer = vbDefault
        If I <> 0 Then MsgBox "La Base de Datos Se Restauró Satisfactoriamente...!", 64
        If I = 0 Then MsgBox "No Se Realizó La Restauración...!", 64
        Screen.MousePointer = vbDefault
        Exit Sub
  End If
End If
If Index = 1 Then
  Unload Me
End If
Exit Sub
P:
  MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
  Screen.MousePointer = ccDefault
End Sub
Private Sub Dir1_Change()
On Local Error GoTo LineaError
    File1.Path = Dir1.Path
Exit Sub
LineaError:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub Drive1_Change()
On Local Error GoTo LineaError
    Dir1.Path = Drive1.Drive
Exit Sub
LineaError:
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub Form_Activate()
  Screen.MousePointer = ccDefault
End Sub
Private Sub Form_Load()
  Screen.MousePointer = ccHourglass
  cn.Close
End Sub
Private Sub Form_Unload(Cancel As Integer)
  cn.Open App.Path + "\mela.mdb"
End Sub

