VERSION 5.00
Begin VB.Form FrmKA 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "KARDEX"
   ClientHeight    =   5145
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   9945
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
   Icon            =   "FrmKA.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   ScaleHeight     =   5145
   ScaleWidth      =   9945
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txtcantidadactual 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   7680
      Locked          =   -1  'True
      MaxLength       =   20
      TabIndex        =   24
      Top             =   2400
      Width           =   1815
   End
   Begin VB.TextBox txtcantidadingresada 
      Alignment       =   1  'Right Justify
      BackColor       =   &H8000000E&
      Height          =   315
      Left            =   7680
      MaxLength       =   20
      TabIndex        =   22
      Top             =   2040
      Width           =   1815
   End
   Begin VB.TextBox txtstock 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   7680
      Locked          =   -1  'True
      MaxLength       =   20
      TabIndex        =   20
      Top             =   1680
      Width           =   1815
   End
   Begin VB.Frame Frame2 
      BackColor       =   &H00B0726D&
      Caption         =   "Documento"
      ForeColor       =   &H8000000E&
      Height          =   1095
      Left            =   120
      TabIndex        =   15
      Top             =   1800
      Width           =   5175
      Begin VB.TextBox txtndocumento 
         BackColor       =   &H80000014&
         Height          =   315
         Left            =   1080
         MaxLength       =   20
         TabIndex        =   18
         Top             =   600
         Width           =   2895
      End
      Begin VB.ComboBox cmbdocumento 
         Height          =   315
         Left            =   1080
         TabIndex        =   17
         Top             =   240
         Width           =   3975
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Doc."
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   600
         Width           =   735
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Tipo Doc."
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   1680
      Picture         =   "FrmKA.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   14
      Top             =   4200
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Height          =   855
      Left            =   1680
      Picture         =   "FrmKA.frx":0614
      Style           =   1  'Graphical
      TabIndex        =   13
      Top             =   3240
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Height          =   855
      Left            =   120
      Picture         =   "FrmKA.frx":16A6
      Style           =   1  'Graphical
      TabIndex        =   12
      Top             =   4200
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   120
      Picture         =   "FrmKA.frx":1F70
      Style           =   1  'Graphical
      TabIndex        =   11
      Top             =   3240
      Width           =   1455
   End
   Begin VB.TextBox txtFECHA 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   840
      Locked          =   -1  'True
      MaxLength       =   20
      TabIndex        =   9
      Top             =   1200
      Width           =   1455
   End
   Begin VB.ComboBox CMBMOTIVO 
      Height          =   315
      Left            =   3960
      TabIndex        =   8
      Top             =   720
      Width           =   5535
   End
   Begin VB.CommandButton Command1 
      BackColor       =   &H80000017&
      Height          =   350
      Left            =   9120
      MaskColor       =   &H00FFFFFF&
      Picture         =   "FrmKA.frx":23B2
      Style           =   1  'Graphical
      TabIndex        =   7
      ToolTipText     =   "BUSCAR PRODUCTO"
      Top             =   240
      Width           =   375
   End
   Begin VB.TextBox txtidproducto 
      BackColor       =   &H80000018&
      Height          =   375
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   -240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox txtdesproducto 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3960
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   240
      Width           =   5175
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Caption         =   "Movimiento"
      ForeColor       =   &H8000000E&
      Height          =   975
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   2655
      Begin VB.OptionButton optsalida 
         BackColor       =   &H00B0726D&
         Caption         =   "Salida"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   1440
         TabIndex        =   2
         Top             =   360
         Width           =   1095
      End
      Begin VB.OptionButton optentrada 
         BackColor       =   &H00B0726D&
         Caption         =   "Entrada"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   240
         TabIndex        =   1
         Top             =   360
         Value           =   -1  'True
         Width           =   1215
      End
   End
   Begin VB.Label Label8 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad Actual"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5880
      TabIndex        =   25
      Top             =   2400
      Width           =   1695
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad Ingresada"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5880
      TabIndex        =   23
      Top             =   2040
      Width           =   1695
   End
   Begin VB.Label Label5 
      BackStyle       =   0  'Transparent
      Caption         =   "Cantidad Sistema"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   5880
      TabIndex        =   21
      Top             =   1680
      Width           =   1695
   End
   Begin VB.Label Label7 
      BackStyle       =   0  'Transparent
      Caption         =   "Fecha"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   120
      TabIndex        =   10
      Top             =   1200
      Width           =   735
   End
   Begin VB.Label Label2 
      BackStyle       =   0  'Transparent
      Caption         =   "Poducto"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3120
      TabIndex        =   4
      Top             =   240
      Width           =   855
   End
   Begin VB.Label Label1 
      BackStyle       =   0  'Transparent
      Caption         =   "Motivo"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   3120
      TabIndex        =   3
      Top             =   720
      Width           =   855
   End
End
Attribute VB_Name = "FrmKA"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean

Private Sub cmbdocumento_Click()
If cmbdocumento = "" Then Exit Sub
If cmbdocumento = "Boleta" Or cmbdocumento = "Factura" Or cmbdocumento = "Recibo" Then
txtndocumento = GenerarNDocumento(cmbdocumento)
txtndocumento.Locked = True
txtndocumento.BackColor = &H80000018
Else
txtndocumento.Locked = False
txtndocumento.BackColor = vbWhite
txtndocumento = Empty
End If
End Sub

Private Sub cmbdocumento_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbdocumento, KeyAscii
End Sub

Private Sub cmbdocumento_LostFocus()
BuscarEnCombito cmbdocumento
End Sub

Private Sub CMBMOTIVO_KeyPress(KeyAscii As Integer)
ValidarIngreso1 CMBMOTIVO, KeyAscii
End Sub

Private Sub CMBMOTIVO_LostFocus()
BuscarEnCombito CMBMOTIVO
End Sub

Private Sub CmdAnular_Click()
Set LIMPIAR = Me
txtFECHA = Format(Now, "DD/MM/YYYY HH:MM:SS")
End Sub

Private Sub CmdGuardar_Click()
If optentrada.Value = False And optsalida.Value = False Then
  MsgBox "Activar Opción de Movimiento Entrada ó Salida ...!", vbExclamation
  Exit Sub
End If
If txtdesproducto = "" Then
MsgBox "Buscar Producto ...!", vbExclamation
Exit Sub
End If
If CMBMOTIVO = "" Then
MsgBox "Ingrese Motivo ...!", vbExclamation
CMBMOTIVO.SetFocus
Exit Sub
End If
If cmbdocumento = "" Then
MsgBox "Falta Tipo Documento ...!", vbExclamation
cmbdocumento.SetFocus
Exit Sub
End If
If Val(txtcantidadingresada) <= 0 Then
MsgBox "Ingresar Cantidad ...!", vbExclamation
txtcantidadingresada.SetFocus
Exit Sub
End If
If MsgBox("¿Desea Guardar El Movimiento ...?", vbYesNo + vbDefaultButton2 + vbQuestion) = vbNo Then Exit Sub
If NUEVO = True Then
  If optentrada.Value = True Then
    txtNK = "I" + DevuelveSerie() + "-" + GenerarCodigo("SELECT max(right(nkardex,7)) From Kardex where tipo_mov='I'", 7)
  ElseIf optsalida.Value = True Then
    txtNK = "S" + DevuelveSerie("S") + "-" + GenerarCodigo("SELECT max(right(nkardex,7)) From Kardex where tipo_mov='S'", 7)
  End If
  Dim T As New ADODB.Recordset
  T.Open "SELECT * from kardex", cn, adOpenDynamic, adLockOptimistic
  T.AddNew
  T!nkardex = txtNK
  T!idmotivo = DevuelveIdMotivo(CMBMOTIVO)
  If optentrada.Value = True Then T!tipo_mov = "I"
  If optsalida.Value = True Then T!tipo_mov = "S"
  T!iddocumento = DevuelveIdDocumento(cmbdocumento)
  T!ndocumento = txtndocumento
  T!fechamovin = CDate(txtFECHA)
  T!descuento = 0
  T!anulado = 0
  T.Update
  If T.State = adStateOpen Then T.Close
  T.Open "select * from detallekardex", cn, adOpenDynamic, adLockOptimistic
  T.AddNew
  T!nkardex = txtNK
  T!nitem = GenerarCodigo("SELECT MAX(NITEM) FROM DETALLEKARDEX WHERE nkardex='" + txtNK + "'", 3)
  T!idproducto = txtidproducto
  T!CANTIDAD = Val(txtcantidadingresada)
  T!precio = 0
  T!subtotal = 0
  T!saldo = Val(txtcantidadactual)
  T!inicial = Val(txtstock)
  T.Update
  If optentrada.Value = True Then
    cn.Execute "UPDATE PRODUCTOS SET cantidad=cantidad+" + txtcantidadingresada + " where idproducto='" + txtidproducto + "'", j
  ElseIf optsalida.Value = True Then
    cn.Execute "UPDATE PRODUCTOS SET cantidad=cantidad-" + txtcantidadingresada + " where idproducto='" + txtidproducto + "'", j
  End If
  If j > 0 Then
  If cmbdocumento = "Boleta" Or cmbdocumento = "Fatura" Or cmbdocumento = "Recibo" Then
    cn.Execute "UPDATE TABSERIES SET SERIE2='" + txtndocumento + "' WHERE Documento='" + cmbdocumento + "'"
  End If
  frmMensajeNuevo.Show 1
  End If
  CmdNuevo_Click
Else

End If
End Sub

Private Sub CmdNuevo_Click()
Set LIMPIAR = Me
NUEVO = True
CMBMOTIVO = "Inventario Ajustado"
txtFECHA = Format(Now, "DD/MM/YYYY HH:MM:SS")
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Command1_Click()
FrmBuscarProducto.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_KA = True
P_RellenaCombo "MOT", CMBMOTIVO
P_RellenaCombo "DOC", cmbdocumento
CmdNuevo_Click
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_KA = False
End Sub




Private Sub optentrada_Click()
txtcantidadingresada_Change
End Sub

Private Sub optsalida_Click()
txtcantidadingresada_Change
End Sub

Private Sub txtcantidadingresada_Change()
If optsalida.Value = True Then
  txtcantidadactual = Val(txtstock) - Val(txtcantidadingresada)
ElseIf optentrada.Value = True Then
  txtcantidadactual = Val(txtstock) + Val(txtcantidadingresada)
End If
End Sub

Private Sub txtstock_Change()
If optsalida.Value = True Then
  txtcantidadactual = Val(txtstock) - Val(txtcantidadingresada)
ElseIf optentrada.Value = True Then
  txtcantidadactual = Val(txtstock) + Val(txtcantidadingresada)
End If
End Sub
