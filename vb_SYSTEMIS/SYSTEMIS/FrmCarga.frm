VERSION 5.00
Begin VB.Form FrmCarga 
   Appearance      =   0  'Flat
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "Form1"
   ClientHeight    =   990
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   7575
   FillColor       =   &H80000012&
   Icon            =   "FrmCarga.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   990
   ScaleWidth      =   7575
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      AutoRedraw      =   -1  'True
      BackColor       =   &H00B0726D&
      DragMode        =   1  'Automatic
      DrawWidth       =   3
      FillColor       =   &H80000007&
      Height          =   735
      Left            =   120
      ScaleHeight     =   675
      ScaleWidth      =   7275
      TabIndex        =   0
      Top             =   120
      Width           =   7335
   End
End
Attribute VB_Name = "FrmCarga"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Activate()
    For I = 0 To 100
        actualizaprogress Picture1, I
        pausa
    Next I
    Picture1.Cls ' limpia la barra al final
    MDIPrincipal.Show
    Unload Me
End Sub
Friend Sub pausa()
    Dim controlar
    Dim comenzar
    comenzar = Timer
    Do Until controlar >= comenzar + 0.005
        controlar = Timer
    DoEvents
    Loop
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
End Sub
Friend Sub actualizaprogress(ByRef pb As Control, ByVal percent)
    Dim num$
    pb.Cls
    pb.ScaleWidth = 100
    pb.DrawMode = 10
    num$ = Format$(percent, "##") + "%"
    pb.FontSize = 18
    pb.CurrentX = 50 - pb.TextWidth(num$) / 2
    pb.CurrentY = (pb.ScaleHeight - pb.TextHeight(num$)) / 2
    pb.Print num$
    pb.Line (0, 0)-(percent, pb.ScaleHeight), QBColor(0), BF
    pb.Refresh
End Sub

