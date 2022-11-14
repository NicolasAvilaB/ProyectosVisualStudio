VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmNotaIngreso 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "NOTA DE INGRESO"
   ClientHeight    =   8550
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   13185
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
   Icon            =   "FrmNotaIngreso.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8550
   ScaleWidth      =   13185
   StartUpPosition =   2  'CenterScreen
   Begin VB.TextBox txttotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   285
      Left            =   8400
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   46
      Text            =   "0"
      Top             =   8160
      Width           =   1575
   End
   Begin VB.TextBox txtigv 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   285
      Left            =   8400
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   45
      Text            =   "0"
      Top             =   7800
      Width           =   1575
   End
   Begin VB.CommandButton CMDNUEVO1 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Enabled         =   0   'False
      Height          =   735
      Left            =   6720
      Picture         =   "FrmNotaIngreso.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   39
      Top             =   3000
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   1215
      Left            =   120
      TabIndex        =   31
      Top             =   2520
      Width           =   6495
      Begin VB.TextBox txtNITEM 
         Height          =   285
         Left            =   120
         TabIndex        =   40
         Text            =   "Text1"
         Top             =   960
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.TextBox txtttotal 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   5160
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   37
         Top             =   600
         Width           =   1215
      End
      Begin VB.TextBox txtcantidad 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   960
         MaxLength       =   50
         TabIndex        =   7
         Top             =   600
         Width           =   1215
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6000
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaIngreso.frx":0944
         Style           =   1  'Graphical
         TabIndex        =   34
         ToolTipText     =   "BUSCAR PRODUCTO"
         Top             =   240
         Width           =   375
      End
      Begin VB.TextBox txtidproducto 
         Height          =   285
         Left            =   0
         TabIndex        =   33
         Text            =   "Text1"
         Top             =   120
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.ComboBox cmbproducto 
         Height          =   315
         Left            =   960
         Sorted          =   -1  'True
         TabIndex        =   6
         Top             =   240
         Width           =   5055
      End
      Begin VB.TextBox TXTprecio 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   3000
         MaxLength       =   50
         TabIndex        =   8
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label13 
         BackStyle       =   0  'Transparent
         Caption         =   "Total"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   4560
         TabIndex        =   38
         Top             =   720
         Width           =   615
      End
      Begin VB.Label Label12 
         BackStyle       =   0  'Transparent
         Caption         =   "Cantidad"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   36
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Precio"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   2400
         TabIndex        =   35
         Top             =   720
         Width           =   615
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "Producto"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   32
         Top             =   240
         Width           =   855
      End
   End
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&BUSCAR"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaIngreso.frx":0E76
      Style           =   1  'Graphical
      TabIndex        =   30
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaIngreso.frx":1180
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   2040
      Width           =   1455
   End
   Begin VB.TextBox txtsubtotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   285
      Left            =   8400
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   25
      Text            =   "0"
      Top             =   7440
      Width           =   1575
   End
   Begin VB.CommandButton cmdquitar 
      BackColor       =   &H80000013&
      Caption         =   "&QUITAR"
      Enabled         =   0   'False
      Height          =   735
      Left            =   8880
      Picture         =   "FrmNotaIngreso.frx":148A
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   3000
      Width           =   1095
   End
   Begin VB.CommandButton cmdagregar 
      BackColor       =   &H80000013&
      Caption         =   "&AGREGAR"
      Enabled         =   0   'False
      Height          =   735
      Left            =   7800
      Picture         =   "FrmNotaIngreso.frx":1794
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   3000
      Width           =   1095
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaIngreso.frx":1A9E
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaIngreso.frx":1EE0
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaIngreso.frx":27AA
      Style           =   1  'Graphical
      TabIndex        =   19
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   11520
      Picture         =   "FrmNotaIngreso.frx":383C
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   7560
      Width           =   1455
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaIngreso.frx":3B46
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   1080
      Width           =   1455
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2295
      Left            =   120
      ScaleHeight     =   2235
      ScaleWidth      =   9795
      TabIndex        =   9
      Top             =   120
      Width           =   9855
      Begin VB.CommandButton Command2 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6480
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaIngreso.frx":3E50
         Style           =   1  'Graphical
         TabIndex        =   42
         ToolTipText     =   "BUSCAR PROVEEDOR"
         Top             =   1270
         Width           =   375
      End
      Begin VB.ComboBox cmbproveedor 
         Height          =   315
         Left            =   1440
         Sorted          =   -1  'True
         TabIndex        =   2
         Top             =   1270
         Width           =   5055
      End
      Begin VB.TextBox txtGUIA 
         Height          =   405
         Left            =   4560
         MaxLength       =   50
         TabIndex        =   4
         Top             =   1680
         Width           =   1935
      End
      Begin VB.TextBox txtNK 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   12
         Top             =   120
         Width           =   1815
      End
      Begin VB.TextBox txtNDocumento 
         BackColor       =   &H80000014&
         Height          =   405
         Left            =   1440
         MaxLength       =   15
         TabIndex        =   3
         Top             =   1635
         Width           =   2175
      End
      Begin VB.TextBox txtFECHA 
         BackColor       =   &H80000018&
         Height          =   405
         Left            =   8040
         Locked          =   -1  'True
         MaxLength       =   20
         TabIndex        =   11
         Top             =   600
         Width           =   1455
      End
      Begin VB.CommandButton cmdMOTIVO 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6480
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaIngreso.frx":4382
         Style           =   1  'Graphical
         TabIndex        =   10
         ToolTipText     =   "BUSCAR MOTIVO"
         Top             =   550
         Width           =   375
      End
      Begin VB.ComboBox cmbmotivo 
         Height          =   315
         Left            =   1440
         Sorted          =   -1  'True
         TabIndex        =   0
         Top             =   550
         Width           =   5055
      End
      Begin VB.ComboBox cmbdocumento 
         Height          =   315
         Left            =   1440
         Sorted          =   -1  'True
         TabIndex        =   1
         Top             =   910
         Width           =   5055
      End
      Begin VB.TextBox txtdescuento 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000014&
         Height          =   405
         Left            =   8040
         MaxLength       =   20
         TabIndex        =   5
         Top             =   1080
         Width           =   1455
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Descuento%"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   44
         Top             =   1140
         Width           =   1215
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "Proveedor"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   41
         Top             =   1270
         Width           =   1215
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "G/RMS"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   3840
         TabIndex        =   28
         Top             =   1680
         Width           =   1455
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Documento"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   27
         Top             =   910
         Width           =   1215
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Motivo"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   550
         Width           =   1215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Ingreso"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   15
         Top             =   180
         Width           =   1215
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Documento"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   14
         Top             =   1635
         Width           =   1335
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   13
         Top             =   600
         Width           =   735
      End
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3495
      Left            =   120
      TabIndex        =   24
      Top             =   3840
      Width           =   9855
      _ExtentX        =   17383
      _ExtentY        =   6165
      _Version        =   393216
      BackColor       =   -2147483629
      ForeColor       =   -2147483647
      BackColorFixed  =   11563629
      ForeColorFixed  =   -2147483628
      BackColorSel    =   11563629
      ForeColorSel    =   65535
      BackColorBkg    =   -2147483629
      BackColorUnpopulated=   -2147483629
      GridColor       =   11563629
      FocusRect       =   0
      FillStyle       =   1
      SelectionMode   =   1
      AllowUserResizing=   3
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      BeginProperty FontFixed {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _NumberOfBands  =   1
      _Band(0).Cols   =   2
   End
   Begin VB.Label Label15 
      BackStyle       =   0  'Transparent
      Caption         =   "Total"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7440
      TabIndex        =   48
      Top             =   8160
      Width           =   1215
   End
   Begin VB.Label Label6 
      BackStyle       =   0  'Transparent
      Caption         =   "Descuento"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7440
      TabIndex        =   47
      Top             =   7800
      Width           =   975
   End
   Begin VB.Label lblletras 
      BackStyle       =   0  'Transparent
      ForeColor       =   &H8000000E&
      Height          =   975
      Left            =   120
      TabIndex        =   43
      Top             =   7440
      Width           =   7215
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Total"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7440
      TabIndex        =   26
      Top             =   7440
      Width           =   975
   End
End
Attribute VB_Name = "FrmNotaIngreso"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text

Public Nuevok As Boolean
Public Nuevokd As Boolean
Dim Capa1 As New ClsMonedaALetras



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
Public Sub cmbproducto_Click()
If cmbproducto = "" Then Exit Sub
txtidproducto = DevuelveIdProducto(cmbproducto)
TXTprecio = Format$(precioPRO(txtidproducto), "###.00")
txtcantidad = "0.00"
End Sub

Private Sub cmbproducto_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbproducto, KeyAscii
End Sub

Public Sub cmbproducto_LostFocus()
BuscarEnCombito cmbproducto
End Sub

Private Sub cmbproveedor_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbproveedor, KeyAscii
End Sub

Private Sub cmbproveedor_LostFocus()
BuscarEnCombito cmbproveedor
End Sub

Private Sub cmdagregar_Click()
On Local Error GoTo L
Dim T As New ADODB.Recordset, c As Double, estock As Double, estockmax As Double, alma As Double
If Nuevokd = True Then
  If MSHFlexGrid1.TextMatrix(1, 1) <> "" Then
  For I = 1 To MSHFlexGrid1.Rows - 1
    If cmbproducto = MSHFlexGrid1.TextMatrix(I, 4) Then
      MsgBox "El Producto Ya Esta Registrado ...!", vbInformation
      Exit Sub
    End If
  Next I
  End If
  If cmbproducto = "" Then
    MsgBox "Ingrese Producto ...!", vbInformation
    Exit Sub
  End If
  If Val(txtcantidad) <= 0 Then
    MsgBox "Ingrese Cantidad ...!", vbInformation
    Exit Sub
  End If
  If STOCK_INGRESAR(txtidproducto, Val(txtcantidad), estockmax, estock) >= 0 Then
    MsgBox "La Cantidad Ingresada Supera el Stock Máximo ...!" + Chr(13) + "Stock Máximo :" + CStr(estockmax) + Chr(13) + "Stock Actual:" + CStr(estock) + Chr(13), vbInformation
    Exit Sub
  End If
  XX = GenerarCodigo("SELECT MAX(NITEM) FROM DETALLEKARDEX WHERE nkardex='I" + txtNK + "'", 3)
  'AGREGA DETALLEKARDEX
  T.Open "DETALLEKARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!nkardex = "I" + txtNK
  T!nitem = XX
  T!idproducto = txtidproducto
  T!CANTIDAD = txtcantidad
  T!precio = TXTprecio
  T!subtotal = txtttotal
  T!saldo = estock + Val(txtcantidad)
  T!inicial = estock
  T.Update
  If T.State = adStateOpen Then T.Close
  'ACTUALIZA PRODUCTOS
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  T!CANTIDAD = T!CANTIDAD + Val(txtcantidad)
  T!subtotal = T!CANTIDAD * T!precio
  T.Update
  If T.State = adStateOpen Then T.Close
  frmMensajeNuevo.Show 1
Else
  If MSHFlexGrid1.TextMatrix(1, 1) <> "" Then
    For I = 1 To MSHFlexGrid1.Rows - 1
      If cmbproducto = MSHFlexGrid1.TextMatrix(I, 4) And txtNITEM <> MSHFlexGrid1.TextMatrix(I, 2) Then
        MsgBox "El Producto Ya Esta Registrado ...!", vbInformation
        Exit Sub
      End If
    Next I
  End If
  If cmbproducto = "" Then
    MsgBox "Ingrese Producto ...!", vbInformation
    Exit Sub
  End If
  If Val(txtcantidad) <= 0 Then
    MsgBox "Ingrese Cantidad ...!", vbInformation
    Exit Sub
  End If
  If STOCK_INGRESAR(txtidproducto, Val(txtcantidad), estockmax, estock) >= 0 Then
    MsgBox "La Cantidad Ingresada Supera el Stock Máximo ...!" + Chr(13) + "Stock Máximo :" + CStr(estockmax) + Chr(13) + "Stock Actual:" + CStr(estock) + Chr(13), vbInformation
    Exit Sub
  End If
  'ELIMINAR DETALLE KARDEX
  cn.Execute "DELETE * FROM DETALLEKARDEX WHERE NKARDEX='I" + txtNK + "' AND NITEM='" + txtNITEM + "'"
  'ACTUALIZAR STOCK
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
  T!CANTIDAD = T!CANTIDAD - Val(txtcantidad)
  Else
  T!CANTIDAD = T!CANTIDAD - Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5))
  End If
  T!subtotal = T!precio * T!CANTIDAD
  T.Update
  If T.State = adStateOpen Then T.Close
  'AGREGA DETALLEKARDEX
  T.Open "DETALLEKARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!nkardex = "I" + txtNK
  T!nitem = txtNITEM
  T!idproducto = txtidproducto
  T!CANTIDAD = txtcantidad
  T!precio = TXTprecio
  T!subtotal = txtttotal
  T!saldo = estock + Val(txtcantidad)
  T!inicial = estock
  T.Update
  If T.State = adStateOpen Then T.Close
  'ACTUALIZA PRODUCTOS
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  T!CANTIDAD = T!CANTIDAD + Val(txtcantidad)
  T!subtotal = T!CANTIDAD * T!precio
  T.Update
  If T.State = adStateOpen Then T.Close
  frmMensajeEditar.Show 1
End If
  txtsubtotal = Format$(P_RELLENADETALLEKARDEX(MSHFlexGrid1, "I" + txtNK), "###.00")
If T.State = adStateOpen Then Set T = Nothing
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdAnular_Click()
If txtNK = "" Then Exit Sub
Set LIMPIAR = Me
ACTIVAR False
MSHFlexGrid1.Clear
MSHFlexGrid1.Rows = 2
MSHFlexGrid1.Cols = 2
End Sub
Private Sub CmdBuscar_Click()
FrmNotaIngresoBuscar.Show 1
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtNK) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  If EliminarTabla("I" + txtNK, "kardex", "nkardex") > 0 Then
    frmMensajeEliminado.Show 1
    Set LIMPIAR = Me
    ACTIVAR False
    MSHFlexGrid1.Rows = 2
    MSHFlexGrid1.Cols = 2
    MSHFlexGrid1.Clear
  End If
Exit Sub
Errlinea:
    If Err.Number = -2147467259 Then
      MsgBox "No Se Puede Eliminar El Registro Porque Esta Relacionado Con Una o Más Tablas...!", vbInformation
      Exit Sub
    End If
    MsgBox "Error # " & Str(Err.Number) & " Fué Generado Por " & Err.Source & Chr(13) & Err.Description, vbCritical
End Sub
Private Sub CmdGuardar_Click()
On Local Error GoTo L
  If txtNK = "" Then Exit Sub
  If CMBMOTIVO = "" Then
    MsgBox "Ingrese Motivo ...!", vbExclamation
    Exit Sub
  End If
  If cmbdocumento = "" Then
    MsgBox "Ingrese Documento ...!", vbExclamation
    Exit Sub
  End If
  If cmbproveedor = "" Then
    MsgBox "Ingrese Proveedor ...!", vbExclamation
    Exit Sub
  End If
  If Trim$(txtndocumento) = "" Then
    MsgBox "Ingrese Nº Documento ...!", vbExclamation
    Exit Sub
  End If
  Dim T As New ADODB.Recordset
  If Nuevok = True Then
    T.Open "KARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
    T.AddNew
    T!nkardex = "I" + txtNK
  Else
    T.Open "SELECT * FROM KARDEX WHERE NKARDEX='I" + txtNK + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
  End If
  T!idmotivo = DevuelveIdMotivo(CMBMOTIVO)
  T!tipo_mov = "I"
  T!iddocumento = DevuelveIdDocumento(cmbdocumento)
  T!ndocumento = Trim$(txtndocumento)
  T!fechamovin = CDate(txtFECHA)
  T!guia = Trim$(txtGUIA)
  T!idproveedor = Devuelve_IdProveedor(cmbproveedor)
  T!descuento = Val(txtDescuento)
  T.Update
  If Nuevok = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  Nuevok = False
  Nuevokd = True
  ACTIVAR True
  P_RELLENADETALLEKARDEX MSHFlexGrid1, "I" + txtNK
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub cmdMOTIVO_Click()
FrmMotivo.Show 1
End Sub

Private Sub CmdNuevo_Click()
Nuevok = True
Set LIMPIAR = Me
txtFECHA = Format$(Now, "DD/MM/YYYY HH:MM:SS")
txtNK = DevuelveSerie() + "-" + GenerarCodigo("SELECT max(right(nkardex,7)) From Kardex where tipo_mov='I'", 7)
ACTIVAR False
CMBMOTIVO = "Compras"
MSHFlexGrid1.Clear
MSHFlexGrid1.Rows = 2
MSHFlexGrid1.Cols = 2
End Sub
Sub ACTIVAR(VALORCITO As Boolean)
cmdquitar.Enabled = VALORCITO
cmdagregar.Enabled = VALORCITO
CMDNUEVO1.Enabled = VALORCITO
End Sub
Public Sub CMDNUEVO1_Click()
Nuevokd = True
cmbproducto = ""
txtcantidad = "0.00"
TXTprecio = "0.00"
txtttotal = "0.00"
txtidproducto = ""
txtNITEM = ""
End Sub
Private Sub cmdquitar_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  If MsgBox("¿Desea Eliminar El Elemento Seleccionado ...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
On Local Error GoTo L
    Dim T As New ADODB.Recordset
    'ELIMINAR DETALLE KARDEX
    cn.Execute "DELETE * FROM DETALLEKARDEX WHERE NKARDEX='I" + txtNK + "' AND NITEM='" + txtNITEM + "'"
    'ACTUALIZAR STOCK
    T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
    T!CANTIDAD = T!CANTIDAD - Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5))
    T!subtotal = T!precio * T!CANTIDAD
    T.Update
    If T.State = adStateOpen Then Set T = Nothing
    cmbproducto = ""
  txtcantidad = "0.00"
  TXTprecio = "0.00"
  txtttotal = "0.00"
  txtidproducto = ""
  txtNITEM = ""
    txtsubtotal = Format$(P_RELLENADETALLEKARDEX(MSHFlexGrid1, "I" + txtNK), "###.00")
  End If
Exit Sub
L:
If Err.Number = 3021 Then
  MsgBox "Para Quitar Un Detalle Seleccione Un Registro...!", vbInformation
  Exit Sub
End If
MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub CmdVImprimir_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
FrmReportes.Show 1
End Sub

Private Sub Command1_Click()
FrmProductos.Show 1
End Sub

Private Sub Command2_Click()
FrmProveedores.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then CmdSalir_Click
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_NOTAINGR = True
P_RellenaCombo "MOT", CMBMOTIVO
P_RellenaCombo "DOC", cmbdocumento
P_RellenaCombo "PROD", cmbproducto
P_RellenaCombo "PROV", cmbproveedor
CmdNuevo_Click
End Sub
Private Sub Form_Unload(Cancel As Integer)
V_NOTAINGR = False
Set Capa1 = Nothing
End Sub
Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
With MSHFlexGrid1
  txtNITEM = .TextMatrix(.RowSel, 2)
  cmbproducto = .TextMatrix(.RowSel, 4)
  txtidproducto = .TextMatrix(.RowSel, 3)
  txtcantidad = .TextMatrix(.RowSel, 5)
  TXTprecio = .TextMatrix(.RowSel, 6)
  txtttotal = .TextMatrix(.RowSel, 7)
End With
Nuevokd = False
End Sub
Private Sub txtcantidad_Change()
  txtttotal = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
End Sub
Private Sub txtcantidad_GotFocus()
txtcantidad.SelStart = 0
txtcantidad.SelLength = Len(txtcantidad)
End Sub
Private Sub txtdescuento_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Moneda
End Sub
Private Sub txtdescuento_LostFocus()
If Not (Val(txtDescuento) >= 1 And Val(txtDescuento) <= 100) Then
txtDescuento = "0.00"
End If
txtsubtotal_Change
End Sub
Private Sub txtGUIA_KeyPress(KeyAscii As Integer)
  xRestringir KeyAscii, ndocumento
End Sub
Private Sub txtNDocumento_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, ndocumento
End Sub
Private Sub txtprecio_Change()
txtttotal = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
End Sub
Private Sub txtsubtotal_Change()
txtIGV = Format$((Val(txtDescuento) * Val(txtsubtotal)) / 100, "###.00")
If Val(txtIGV) = 0 Then txtIGV = "0.00"
txttotal = Format$(Val(txtsubtotal) - Val(txtIGV), "###.00")
LBLIGV = Format$(Val(txtDescuento), "###.00") + " %"
lblletras.Caption = "Son: " + Trim$(Capa1.olpol(Val(txttotal))) + " Nuevos Soles"
End Sub

