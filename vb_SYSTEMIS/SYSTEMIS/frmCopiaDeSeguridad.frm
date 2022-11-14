VERSION 5.00
Begin VB.Form frmCopiaDeSeguridad 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "COPIA DE SEGURIDAD"
   ClientHeight    =   5235
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4800
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
   Icon            =   "frmCopiaDeSeguridad.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   5235
   ScaleWidth      =   4800
   StartUpPosition =   2  'CenterScreen
   Begin VB.Timer Timer1 
      Interval        =   5000
      Left            =   3600
      Top             =   120
   End
   Begin VB.CommandButton Cmd 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&Salir"
      Height          =   855
      Index           =   2
      Left            =   3480
      Picture         =   "frmCopiaDeSeguridad.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   6
      ToolTipText     =   "Hacer Click Para Crear Nueva Carpeta En El Directorio Seleccionado"
      Top             =   4200
      Width           =   1215
   End
   Begin VB.CommandButton Cmd 
      BackColor       =   &H80000013&
      Caption         =   "&Copiar"
      Height          =   855
      Index           =   0
      Left            =   3480
      Picture         =   "frmCopiaDeSeguridad.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   3
      ToolTipText     =   "Hacer Click Para Generar Backup en el Directorio Seleccionado"
      Top             =   1200
      Width           =   1215
   End
   Begin VB.DirListBox Dir1 
      ForeColor       =   &H80000007&
      Height          =   3915
      Left            =   120
      MouseIcon       =   "frmCopiaDeSeguridad.frx":091E
      MousePointer    =   99  'Custom
      TabIndex        =   2
      ToolTipText     =   "Seleccionar Directorio de Destino"
      Top             =   1200
      Width           =   3135
   End
   Begin VB.DriveListBox Drive1 
      BackColor       =   &H80000009&
      ForeColor       =   &H80000007&
      Height          =   315
      Left            =   120
      TabIndex        =   1
      ToolTipText     =   "Seleccionar Unidad de Destino"
      Top             =   360
      Width           =   2775
   End
   Begin VB.CommandButton Cmd 
      BackColor       =   &H80000013&
      Caption         =   "&Crear Carpeta"
      Height          =   855
      Index           =   1
      Left            =   3480
      Picture         =   "frmCopiaDeSeguridad.frx":0C28
      Style           =   1  'Graphical
      TabIndex        =   0
      ToolTipText     =   "Hacer Click Para Crear Nueva Carpeta En El Directorio Seleccionado"
      Top             =   2160
      Width           =   1215
   End
   Begin VB.Label Label4 
      BackStyle       =   0  'Transparent
      Caption         =   "Seleccionar Unidad de Destino"
      ForeColor       =   &H80000009&
      Height          =   255
      Index           =   7
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   3015
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Seleccionar Directorio de Destino"
      ForeColor       =   &H80000009&
      Height          =   255
      Index           =   1
      Left            =   120
      TabIndex        =   4
      Top             =   960
      Width           =   3135
   End
End
Attribute VB_Name = "frmCopiaDeSeguridad"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
DefLng A
Friend Sub CMD_Click(Index As Integer)
On Local Error GoTo ELI
  If Index = 0 Then
    If MsgBox("¿Desea Crear Copia de Seguridad de la Base de Datos...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then
    Exit Sub
  End If
    Screen.MousePointer = vbHourglass
    A = CopyFile(IIf(Right(App.Path, 1) = "\", App.Path, App.Path + "\") + "mela.mdb", IIf(Right(Dir1.Path, 1) = "\", Dir1.Path, Dir1.Path + "\") + "COPIAmela.mdb", 0)
    Screen.MousePointer = vbDefault
    If A <> 0 Then MsgBox "La Copia de Seguridad Se Realizó Satisfactoriamente...!", 64
  ElseIf Index = 1 Then
    Dim N As String
    N = InputBox("Ingrese Nombre Para Crear Una Nueva Carpeta...!", "Crear Nueva Carpeta", , 2000, 1000)
    If InStr(1, N, "\") > 0 Then MsgBox "Prohibido Ingresar==>   \", 64: N = "": Exit Sub
    If N <> "" Then
      MkDir IIf(Right(Dir1.Path, 1) = "\", Dir1.Path, Dir1.Path & "\") + N
      Dir1.Refresh
    End If
  ElseIf Index = 2 Then
    Unload Me
  End If
Exit Sub
ELI:
   MsgBox "Descripción=> " + Err.Description + Chr(13) + "Error Nº " + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "Cmd_Click", vbCritical, "ERROR=> " + Name
  Screen.MousePointer = ccDefault
End Sub
Private Sub Drive1_Change()
On Local Error GoTo L
  Dir1.Path = Drive1.Drive
Exit Sub
L:
   MsgBox "Descripción=> " + Err.Description + Chr(13) + "Error Nº " + Trim$(Err.Number) + Chr(13) + "Procedimiento=> " + "Drive1_Change", vbCritical, "ERROR=> " + Name
End Sub
Private Sub Form_Activate()
  Screen.MousePointer = ccDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me

End Sub

Private Sub Form_Load()
  Screen.MousePointer = ccHourglass
End Sub
Private Sub Timer1_Timer()
  Drive1.Refresh
End Sub
