VERSION 5.00
Begin VB.Form Form1 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR DOCUMENTO - ANULAR"
   ClientHeight    =   1800
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   5940
   ForeColor       =   &H00B0726D&
   Icon            =   "frmbuscarboletas.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   1800
   ScaleWidth      =   5940
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "Salir"
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
      Left            =   4200
      Style           =   1  'Graphical
      TabIndex        =   7
      Top             =   960
      Width           =   1575
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H80000013&
      Caption         =   "Buscar"
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
      Left            =   4200
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   360
      Width           =   1575
   End
   Begin VB.TextBox Text1 
      Height          =   375
      Left            =   1800
      TabIndex        =   5
      Top             =   1320
      Width           =   1815
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Caption         =   "Elige Documento"
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
      Height          =   1095
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3855
      Begin VB.OptionButton OPTRECIBO 
         BackColor       =   &H00B0726D&
         Caption         =   "RECIBO"
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
         Left            =   2640
         TabIndex        =   3
         Top             =   480
         Width           =   1095
      End
      Begin VB.OptionButton OPTBOLETA 
         BackColor       =   &H00B0726D&
         Caption         =   "BOLETA"
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
         Left            =   1440
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
      Begin VB.OptionButton OPTFACTURA 
         BackColor       =   &H00B0726D&
         Caption         =   "FACTURA"
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
         TabIndex        =   1
         Top             =   480
         Value           =   -1  'True
         Width           =   1215
      End
   End
   Begin VB.Label Label1 
      BackColor       =   &H00B0726D&
      Caption         =   "Ingrese Nº Doc."
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
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   1320
      Width           =   1575
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Function EXISTE_BOLA(NDOC) As Boolean
On Error GoTo L
Dim T As New ADODB.Recordset
If OPTFACTURA.Value = True Then
  T.Open "SELECT * FROM VENTAS INNER JOIN DOCUMENTOS ON VENTAS.IDDOCUMENTO=DOCUMENTOS.IDDOCUMENTO WHERE DOCUMENTOS.desdocumento='Factura' and NDOCUMENTO='" + NDOC + "' and anulado=0", cn, adOpenForwardOnly, adLockReadOnly
ElseIf OPTBOLETA.Value = True Then
  T.Open "SELECT * FROM VENTAS INNER JOIN DOCUMENTOS ON VENTAS.IDDOCUMENTO=DOCUMENTOS.IDDOCUMENTO WHERE DOCUMENTOS.desdocumento='Boleta' and NDOCUMENTO='" + NDOC + "' and anulado=0", cn, adOpenForwardOnly, adLockReadOnly
ElseIf OPTRECIBO.Value = True Then
  T.Open "select * from tb_pagos where anulado=0 and nrecibo='" + NDOC + "'", cn, adOpenForwardOnly, adLockReadOnly
End If
REFRESCAR T
If T.RecordCount = 0 Then
  EXISTE_BOLA = 1
  Set T = Nothing
  Exit Function
End If
If T!anulado = 1 Then
  EXISTE_BOLA = 2
End If
Set T = Nothing
Exit Function
L:
MsgBox Err.Description, vbCritical
End Function

Private Sub Command1_Click()
If Trim(Text1.Text) = "" Then Exit Sub

fff = EXISTE_BOLA(Text1)
If fff = 1 Then
  MsgBox "Nº Documento No Existe ...!", vbInformation
  Exit Sub
End If
If fff = 2 Then
  MsgBox "El Documento Ya Fué Anulado ...!", vbInformation
  Exit Sub
End If
If OPTBOLETA.Value = True Or OPTFACTURA.Value = True Then
  FrmFacturacion.Show 1
End If
If OPTRECIBO.Value = True Then FrmPagos.Show 1
End Sub

Private Sub Command2_Click()
Unload Me
End Sub

Private Sub Command2_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
V_ANULAR = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
Screen.MousePointer = vbDefault
V_ANULAR = False
End Sub

