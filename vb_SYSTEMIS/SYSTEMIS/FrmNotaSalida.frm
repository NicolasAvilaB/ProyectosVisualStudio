VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmNotaSalida 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "NOTA DE SALIDA"
   ClientHeight    =   7845
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
   Icon            =   "FrmNotaSalida.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   7845
   ScaleWidth      =   13185
   StartUpPosition =   2  'CenterScreen
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
      TabIndex        =   27
      Top             =   120
      Width           =   9855
      Begin VB.Frame Frame4 
         BackColor       =   &H00B0726D&
         Caption         =   "Moneda"
         ForeColor       =   &H8000000E&
         Height          =   615
         Left            =   7200
         TabIndex        =   47
         Top             =   1080
         Width           =   2415
         Begin VB.OptionButton optdolares 
            BackColor       =   &H00B0726D&
            Caption         =   "Dolares"
            ForeColor       =   &H80000014&
            Height          =   255
            Left            =   1200
            TabIndex        =   49
            Top             =   240
            Width           =   1095
         End
         Begin VB.OptionButton optsoles 
            BackColor       =   &H00B0726D&
            Caption         =   "Soles"
            ForeColor       =   &H80000014&
            Height          =   255
            Left            =   240
            TabIndex        =   48
            Top             =   240
            Value           =   -1  'True
            Width           =   975
         End
      End
      Begin VB.TextBox txttipocambio 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   7200
         Locked          =   -1  'True
         TabIndex        =   46
         Top             =   1800
         Visible         =   0   'False
         Width           =   975
      End
      Begin VB.CommandButton cmdpromotor 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   9360
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaSalida.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   45
         ToolTipText     =   "BUSCAR CLIENTE"
         Top             =   120
         Width           =   375
      End
      Begin VB.ComboBox cmbpromotor 
         Height          =   315
         Left            =   4320
         Sorted          =   -1  'True
         TabIndex        =   43
         Top             =   120
         Width           =   5055
      End
      Begin VB.ComboBox cmbmotivo 
         Height          =   315
         Left            =   1440
         Sorted          =   -1  'True
         TabIndex        =   32
         Top             =   550
         Width           =   5055
      End
      Begin VB.CommandButton cmdMOTIVO 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6480
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaSalida.frx":083C
         Style           =   1  'Graphical
         TabIndex        =   31
         ToolTipText     =   "BUSCAR MOTIVO"
         Top             =   550
         Width           =   375
      End
      Begin VB.TextBox txtFECHA 
         BackColor       =   &H80000018&
         Height          =   405
         Left            =   7800
         Locked          =   -1  'True
         MaxLength       =   20
         TabIndex        =   30
         Top             =   600
         Width           =   1575
      End
      Begin VB.TextBox txtNDocumento 
         BackColor       =   &H80000018&
         Height          =   405
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   15
         TabIndex        =   2
         Top             =   1635
         Width           =   1935
      End
      Begin VB.TextBox txtNK 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   29
         Top             =   120
         Width           =   1815
      End
      Begin VB.ComboBox cmbdocumento 
         Height          =   315
         ItemData        =   "FrmNotaSalida.frx":0D6E
         Left            =   1440
         List            =   "FrmNotaSalida.frx":0D78
         Sorted          =   -1  'True
         TabIndex        =   0
         Top             =   910
         Width           =   5055
      End
      Begin VB.TextBox txtGUIA 
         Height          =   405
         Left            =   4560
         MaxLength       =   50
         TabIndex        =   3
         Top             =   1680
         Width           =   1935
      End
      Begin VB.ComboBox cmbcliente 
         Height          =   315
         Left            =   1440
         Sorted          =   -1  'True
         TabIndex        =   1
         Top             =   1270
         Width           =   5055
      End
      Begin VB.CommandButton Command2 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6480
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaSalida.frx":0D8D
         Style           =   1  'Graphical
         TabIndex        =   28
         ToolTipText     =   "BUSCAR CLIENTE"
         Top             =   1270
         Width           =   375
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Promotor"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   3480
         TabIndex        =   44
         Top             =   120
         Width           =   1215
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "Fecha"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   39
         Top             =   600
         Width           =   735
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Documento"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   120
         TabIndex        =   38
         Top             =   1635
         Width           =   1455
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Nº Salida"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   37
         Top             =   180
         Width           =   1215
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Motivo"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   36
         Top             =   550
         Width           =   1215
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Documento"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   35
         Top             =   910
         Width           =   1215
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "G/RMS"
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   3840
         TabIndex        =   34
         Top             =   1680
         Width           =   735
      End
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "Cliente"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   33
         Top             =   1270
         Width           =   1215
      End
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaSalida.frx":12BF
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaSalida.frx":15C9
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   6840
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaSalida.frx":18D3
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaSalida.frx":2965
      Style           =   1  'Graphical
      TabIndex        =   23
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaSalida.frx":322F
      Style           =   1  'Graphical
      TabIndex        =   22
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton cmdagregar 
      BackColor       =   &H80000013&
      Caption         =   "&AGREGAR"
      Enabled         =   0   'False
      Height          =   735
      Left            =   7800
      Picture         =   "FrmNotaSalida.frx":3671
      Style           =   1  'Graphical
      TabIndex        =   21
      Top             =   3000
      Width           =   1095
   End
   Begin VB.CommandButton cmdquitar 
      BackColor       =   &H80000013&
      Caption         =   "&QUITAR"
      Enabled         =   0   'False
      Height          =   735
      Left            =   8880
      Picture         =   "FrmNotaSalida.frx":397B
      Style           =   1  'Graphical
      TabIndex        =   20
      Top             =   3000
      Width           =   1095
   End
   Begin VB.TextBox txtsubtotal 
      Alignment       =   1  'Right Justify
      BackColor       =   &H80000018&
      Height          =   285
      Left            =   8400
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   19
      Text            =   "0"
      Top             =   7440
      Width           =   1575
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   11640
      Picture         =   "FrmNotaSalida.frx":3C85
      Style           =   1  'Graphical
      TabIndex        =   18
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdBuscar 
      BackColor       =   &H80000013&
      Caption         =   "&BUSCAR"
      Height          =   855
      Left            =   10080
      Picture         =   "FrmNotaSalida.frx":3F8F
      Style           =   1  'Graphical
      TabIndex        =   17
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      Height          =   1215
      Left            =   120
      TabIndex        =   9
      Top             =   2520
      Width           =   6495
      Begin VB.ComboBox cmbproducto 
         Height          =   315
         Left            =   960
         Sorted          =   -1  'True
         TabIndex        =   4
         Top             =   240
         Width           =   5055
      End
      Begin VB.TextBox txtidproducto 
         Height          =   285
         Left            =   0
         TabIndex        =   12
         Text            =   "Text1"
         Top             =   120
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6000
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmNotaSalida.frx":4299
         Style           =   1  'Graphical
         TabIndex        =   11
         ToolTipText     =   "BUSCAR PRODUCTO"
         Top             =   240
         Width           =   375
      End
      Begin VB.TextBox txtcantidad 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   960
         MaxLength       =   50
         TabIndex        =   5
         Top             =   600
         Width           =   1215
      End
      Begin VB.TextBox txtttotal 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   5160
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   7
         Top             =   600
         Width           =   1215
      End
      Begin VB.TextBox txtNITEM 
         Height          =   285
         Left            =   120
         TabIndex        =   10
         Text            =   "Text1"
         Top             =   960
         Visible         =   0   'False
         Width           =   105
      End
      Begin VB.TextBox TXTprecio 
         Alignment       =   1  'Right Justify
         Height          =   375
         Left            =   3000
         MaxLength       =   50
         TabIndex        =   6
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "Producto"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   240
         Width           =   855
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Precio"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   2400
         TabIndex        =   15
         Top             =   720
         Width           =   615
      End
      Begin VB.Label Label12 
         BackStyle       =   0  'Transparent
         Caption         =   "Cantidad"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label13 
         BackStyle       =   0  'Transparent
         Caption         =   "Total"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   4560
         TabIndex        =   13
         Top             =   720
         Width           =   615
      End
   End
   Begin VB.CommandButton CMDNUEVO1 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Enabled         =   0   'False
      Height          =   735
      Left            =   6720
      Picture         =   "FrmNotaSalida.frx":47CB
      Style           =   1  'Graphical
      TabIndex        =   8
      Top             =   3000
      Width           =   1095
   End
   Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
      Height          =   3495
      Left            =   120
      TabIndex        =   40
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
   Begin VB.Label lblletras 
      BackStyle       =   0  'Transparent
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   120
      TabIndex        =   42
      Top             =   7440
      Width           =   6975
   End
   Begin VB.Label Label3 
      BackStyle       =   0  'Transparent
      Caption         =   "Total"
      ForeColor       =   &H8000000E&
      Height          =   255
      Left            =   7440
      TabIndex        =   41
      Top             =   7440
      Width           =   735
   End
End
Attribute VB_Name = "FrmNotaSalida"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Public Nuevok As Boolean
Public Nuevokd As Boolean
Dim Capa1 As New ClsMonedaALetras
Private Sub cmbcliente_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbcliente, KeyAscii
End Sub

Private Sub cmbcliente_LostFocus()
BuscarEnCombito cmbcliente
End Sub

Private Sub cmbdocumento_Click()
If Nuevok = True Then
  If cmbdocumento = "Boleta" Then
    txtndocumento = GenerarNDocumento("Boleta")
  End If
  If cmbdocumento = "Factura" Then
    txtndocumento = GenerarNDocumento("Factura")
  End If
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

Private Sub cmdagregar_Click()
On Local Error GoTo L
Dim T As New ADODB.Recordset, c As Double, estockmin As Double, estock As Double
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
  If STOCK_SALIR(txtidproducto, Val(txtcantidad), estockmin, estock) >= 0 Then
    MsgBox "La Cantidad Solicitada Es Mayor Al Stock ...!" + Chr(13) + "Stock Mínimo :" + CStr(estockmin) + Chr(13) + "Stock Actual:" + CStr(estock) + Chr(13), vbInformation
    Exit Sub
  End If
  XX = GenerarCodigo("SELECT MAX(NITEM) FROM DETALLEKARDEX WHERE nkardex='S" + txtNK + "'", 3)
  'AGREGA DETALLEKARDEX
  T.Open "DETALLEKARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!nkardex = "S" + txtNK
  T!nitem = XX
  T!idproducto = txtidproducto
  T!CANTIDAD = txtcantidad
  T!precio = TXTprecio
  T!subtotal = txtttotal
  T!saldo = estock - Val(txtcantidad)
  T!inicial = estock
  T.Update
  If T.State = adStateOpen Then T.Close
  'ACTUALIZA PRODUCTOS
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  T!CANTIDAD = T!CANTIDAD - Val(txtcantidad)
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
  If STOCK_SALIR(txtidproducto, Val(txtcantidad), estockmin, estock) >= 0 Then
    MsgBox "La Cantidad Solicitada Es Mayor Al Stock ...!" + Chr(13) + "Stock Mínimo :" + CStr(estockmin) + Chr(13) + "Stock Actual:" + CStr(estock) + Chr(13), vbInformation
    Exit Sub
  End If
  'ELIMINAR DETALLE KARDEX
  cn.Execute "DELETE * FROM DETALLEKARDEX WHERE NKARDEX='S" + txtNK + "' AND NITEM='" + txtNITEM + "'"
  'ACTUALIZAR STOCK
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then
  T!CANTIDAD = T!CANTIDAD + Val(txtcantidad)
  Else
  T!CANTIDAD = T!CANTIDAD + Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5))
  End If
  T!subtotal = T!CANTIDAD * T!precio
  T.Update
  If T.State = adStateOpen Then T.Close
  'AGREGA DETALLEKARDEX
  T.Open "DETALLEKARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!nkardex = "S" + txtNK
  T!nitem = txtNITEM
  T!idproducto = txtidproducto
  T!CANTIDAD = Val(txtcantidad)
  T!precio = Val(TXTprecio)
  T!subtotal = Val(txtttotal)
  T!saldo = estock - Val(txtcantidad)
  T!inicial = estock
  T.Update
  If T.State = adStateOpen Then T.Close
  'ACTUALIZA PRODUCTOS
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtidproducto + "'", cn, adOpenDynamic, adLockOptimistic
  T!CANTIDAD = T!CANTIDAD - Val(txtcantidad)
  T!subtotal = T!CANTIDAD * T!precio
  T.Update
  If T.State = adStateOpen Then T.Close
  frmMensajeEditar.Show 1
End If
  txtsubtotal = Format$(P_RELLENADETALLEKARDEX(MSHFlexGrid1, "S" + txtNK), "###.00")
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
FrmNotaSalidaBuscar.Show 1
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
  If EliminarTabla("S" + txtNK, "kardex", "nkardex") > 0 Then
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
  If cmbcliente = "" Then
    MsgBox "Ingrese Cliente ...!", vbExclamation
    Exit Sub
  End If
    If cmbpromotor = "" Then
    MsgBox "Ingrese Promotor ...!", vbExclamation
    Exit Sub
  End If
  Dim T As New ADODB.Recordset
  If Nuevok = True Then
    T.Open "KARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
    T.AddNew
    T!nkardex = "S" + txtNK
  Else
    T.Open "SELECT * FROM KARDEX WHERE NKARDEX='S" + txtNK + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
  End If
  T!idmotivo = DevuelveIdMotivo(CMBMOTIVO)
  T!tipo_mov = "S"
  T!iddocumento = DevuelveIdDocumento(cmbdocumento)
  T!ndocumento = Trim$(txtndocumento)
  T!fechamovin = CDate(txtFECHA)
  T!guia = Trim$(txtGUIA)
  T!CodDueño = Devuelve_IdCliente(cmbcliente)
  T!idpromotor = Devuelve_IdPromotor(cmbpromotor)
  T!moneda = IIf(optsoles.Value = True, "1", "2")
  T!tipcam = Val(txttipocambio)
  T.Update
  Set T = Nothing
  If Nuevok = True Then
      cn.Execute "UPDATE TABSERIES SET serie2='" + Right(txtndocumento, Len(txtndocumento) - 4) + "' WHERE Documento='" + cmbdocumento + "'"
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  Nuevok = False
  Nuevokd = True
  ACTIVAR True
   P_RELLENADETALLEKARDEX MSHFlexGrid1, "S" + txtNK
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
txtNK = DevuelveSerie("S") + "-" + GenerarCodigo("SELECT max(right(nkardex,7)) From Kardex where tipo_mov='S'", 7)
ACTIVAR False
CMBMOTIVO = "Ventas"
MSHFlexGrid1.Clear
MSHFlexGrid1.Rows = 2
MSHFlexGrid1.Cols = 2
txttipocambio = Devuelve_TipoCambio
optsoles.Value = True
End Sub
Friend Sub ACTIVAR(ByVal VALORCITO As Boolean)
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
    cn.Execute "DELETE * FROM DETALLEKARDEX WHERE NKARDEX='S" + txtNK + "' AND NITEM='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "'", K
    'ACTUALIZAR STOCK
    T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3) + "'", cn, adOpenDynamic, adLockOptimistic
    T!CANTIDAD = T!CANTIDAD + Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5))
    T!subtotal = T!precio * T!CANTIDAD
    T.Update
    If T.State = adStateOpen Then Set T = Nothing
    
 
  txtcantidad = "0.00"
  TXTprecio = "0.00"
  txtttotal = "0.00"
  txtidproducto = ""
  txtNITEM = ""
  txtsubtotal = Format$(P_RELLENADETALLEKARDEX(MSHFlexGrid1, "S" + txtNK), "###.00")
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
frmRegistroDueño.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub
Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then CmdSalir_Click
End Sub
Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_NOTASALI = True
P_RellenaCombo "MOT", CMBMOTIVO
P_RellenaCombo "promotor", cmbpromotor
P_RellenaCombo "PROD", cmbproducto
P_RellenaCombo "CLI", cmbcliente
CmdNuevo_Click
End Sub

Private Sub Form_Unload(Cancel As Integer)
  V_NOTASALI = False
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
  txtttotal.Text = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")
End Sub

Private Sub txtcantidad_GotFocus()
txtcantidad.SelStart = 0
txtcantidad.SelLength = Len(txtcantidad)
End Sub

Private Sub txtcantidad_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
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

Private Sub TXTprecio_GotFocus()
TXTprecio.SelStart = 0
TXTprecio.SelLength = Len(TXTprecio)
End Sub

Private Sub txtprecio_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
End Sub

Private Sub txtsubtotal_Change()
lblletras.Caption = "Son: " + Trim$(Capa1.olpol(Val(txtsubtotal))) + " " + IIf(optsoles.Value = True, "Nuevos Soles", "Dolares Americanos")
End Sub
