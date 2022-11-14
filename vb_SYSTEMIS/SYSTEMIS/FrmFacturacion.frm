VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmFacturacion 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "VENTA "
   ClientHeight    =   8625
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   14250
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
   Icon            =   "FrmFacturacion.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   8625
   ScaleWidth      =   14250
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      BorderStyle     =   0  'None
      Height          =   4095
      Left            =   11040
      ScaleHeight     =   4095
      ScaleWidth      =   3135
      TabIndex        =   55
      Top             =   4440
      Width           =   3135
      Begin VB.CommandButton CmdSalir 
         BackColor       =   &H80000013&
         Cancel          =   -1  'True
         Caption         =   "&SALIR"
         Height          =   855
         Left            =   1560
         Picture         =   "FrmFacturacion.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   57
         Top             =   3120
         Width           =   1455
      End
      Begin VB.CommandButton Command2 
         BackColor       =   &H80000013&
         Caption         =   "&ANULAR DOCUMENTO"
         Height          =   855
         Left            =   120
         Picture         =   "FrmFacturacion.frx":0614
         Style           =   1  'Graphical
         TabIndex        =   56
         Top             =   120
         Visible         =   0   'False
         Width           =   2295
      End
   End
   Begin VB.PictureBox PICT 
      BackColor       =   &H00B0726D&
      BorderStyle     =   0  'None
      Height          =   8415
      Left            =   120
      ScaleHeight     =   8415
      ScaleWidth      =   14055
      TabIndex        =   0
      Top             =   120
      Width           =   14055
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
         Height          =   1960
         Left            =   0
         ScaleHeight     =   1905
         ScaleWidth      =   10635
         TabIndex        =   27
         Top             =   0
         Width           =   10695
         Begin VB.TextBox txttipocambio 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   7080
            Locked          =   -1  'True
            TabIndex        =   64
            Top             =   840
            Visible         =   0   'False
            Width           =   975
         End
         Begin VB.Frame Frame4 
            BackColor       =   &H00B0726D&
            Caption         =   "Moneda"
            ForeColor       =   &H8000000E&
            Height          =   615
            Left            =   8160
            TabIndex        =   61
            Top             =   600
            Width           =   2415
            Begin VB.OptionButton optsoles 
               BackColor       =   &H00B0726D&
               Caption         =   "Soles"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   240
               TabIndex        =   63
               Top             =   240
               Value           =   -1  'True
               Width           =   975
            End
            Begin VB.OptionButton optdolares 
               BackColor       =   &H00B0726D&
               Caption         =   "Dolares"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   1200
               TabIndex        =   62
               Top             =   240
               Width           =   1095
            End
         End
         Begin VB.CommandButton cmdpromotor 
            BackColor       =   &H80000017&
            Height          =   350
            Left            =   6480
            MaskColor       =   &H00FFFFFF&
            Picture         =   "FrmFacturacion.frx":091E
            Style           =   1  'Graphical
            TabIndex        =   60
            ToolTipText     =   "BUSCAR PROMOTOR"
            Top             =   1520
            Visible         =   0   'False
            Width           =   375
         End
         Begin VB.ComboBox cmbpromotor 
            Height          =   315
            Left            =   1440
            Sorted          =   -1  'True
            TabIndex        =   58
            Top             =   1520
            Visible         =   0   'False
            Width           =   5055
         End
         Begin VB.TextBox txtFecha 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   1440
            Locked          =   -1  'True
            MaxLength       =   20
            TabIndex        =   42
            Top             =   80
            Width           =   1575
         End
         Begin VB.TextBox txtNDocumento 
            Alignment       =   2  'Center
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   8880
            Locked          =   -1  'True
            MaxLength       =   15
            TabIndex        =   41
            Top             =   75
            Width           =   1695
         End
         Begin VB.TextBox txtidventa 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   1440
            Locked          =   -1  'True
            TabIndex        =   40
            Top             =   440
            Width           =   1575
         End
         Begin VB.TextBox txtDescuento 
            Height          =   315
            Left            =   1440
            MaxLength       =   50
            TabIndex        =   39
            Top             =   1150
            Width           =   1095
         End
         Begin VB.ComboBox cmbcliente 
            Height          =   315
            Left            =   1440
            Sorted          =   -1  'True
            TabIndex        =   38
            Top             =   800
            Width           =   5055
         End
         Begin VB.CommandButton cmdcliente 
            BackColor       =   &H80000017&
            Height          =   350
            Left            =   6480
            MaskColor       =   &H00FFFFFF&
            Picture         =   "FrmFacturacion.frx":0E50
            Style           =   1  'Graphical
            TabIndex        =   37
            ToolTipText     =   "BUSCAR CLIENTE"
            Top             =   800
            Width           =   375
         End
         Begin VB.Frame Frame2 
            BackColor       =   &H00B0726D&
            Caption         =   "Tipo Venta"
            ForeColor       =   &H8000000E&
            Height          =   615
            Left            =   3120
            TabIndex        =   34
            Top             =   0
            Width           =   2415
            Begin VB.OptionButton optcontado 
               BackColor       =   &H00B0726D&
               Caption         =   "Contado"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   120
               TabIndex        =   36
               Top             =   240
               Value           =   -1  'True
               Width           =   1095
            End
            Begin VB.OptionButton optcredito 
               BackColor       =   &H00B0726D&
               Caption         =   "Crédito"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   1200
               TabIndex        =   35
               Top             =   240
               Width           =   1095
            End
         End
         Begin VB.Frame Frame3 
            BackColor       =   &H00B0726D&
            Caption         =   "Tipo Documento"
            ForeColor       =   &H8000000E&
            Height          =   615
            Left            =   5640
            TabIndex        =   31
            Top             =   0
            Width           =   2415
            Begin VB.OptionButton optboleta 
               BackColor       =   &H00B0726D&
               Caption         =   "Boleta"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   1200
               TabIndex        =   33
               Top             =   240
               Width           =   1095
            End
            Begin VB.OptionButton optfactura 
               BackColor       =   &H00B0726D&
               Caption         =   "Factura"
               ForeColor       =   &H80000014&
               Height          =   255
               Left            =   120
               TabIndex        =   32
               Top             =   240
               Value           =   -1  'True
               Width           =   1095
            End
         End
         Begin VB.TextBox txtusuario 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   7800
            Locked          =   -1  'True
            TabIndex        =   30
            Top             =   1560
            Visible         =   0   'False
            Width           =   735
         End
         Begin VB.TextBox txtcancelado 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   8760
            Locked          =   -1  'True
            TabIndex        =   29
            Top             =   1560
            Visible         =   0   'False
            Width           =   1575
         End
         Begin VB.TextBox Text1 
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   8520
            Locked          =   -1  'True
            TabIndex        =   28
            Top             =   1560
            Visible         =   0   'False
            Width           =   255
         End
         Begin VB.Label Label2 
            BackStyle       =   0  'Transparent
            Caption         =   "Promotor"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   59
            Top             =   1520
            Visible         =   0   'False
            Width           =   1215
         End
         Begin VB.Label Label7 
            BackStyle       =   0  'Transparent
            Caption         =   "Fecha"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   47
            Top             =   80
            Width           =   735
         End
         Begin VB.Label Label4 
            BackStyle       =   0  'Transparent
            Caption         =   "Nº Doc."
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   8160
            TabIndex        =   46
            Top             =   120
            Width           =   855
         End
         Begin VB.Label Label9 
            BackStyle       =   0  'Transparent
            Caption         =   "Descuento %"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   45
            Top             =   1150
            Width           =   1215
         End
         Begin VB.Label Label14 
            BackStyle       =   0  'Transparent
            Caption         =   "Cliente"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   44
            Top             =   800
            Width           =   1215
         End
         Begin VB.Label Label1 
            BackStyle       =   0  'Transparent
            Caption         =   "Id Venta"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   43
            Top             =   440
            Width           =   735
         End
      End
      Begin VB.CommandButton CMdELIMINAR 
         BackColor       =   &H80000013&
         Caption         =   "&ELIMINAR"
         Height          =   855
         Left            =   12360
         Picture         =   "FrmFacturacion.frx":1382
         Style           =   1  'Graphical
         TabIndex        =   26
         Top             =   960
         Width           =   1455
      End
      Begin VB.CommandButton CmdAnular 
         BackColor       =   &H80000013&
         Caption         =   "&CANCELAR"
         Height          =   855
         Left            =   12360
         Picture         =   "FrmFacturacion.frx":168C
         Style           =   1  'Graphical
         TabIndex        =   25
         Top             =   0
         Width           =   1455
      End
      Begin VB.CommandButton CmdGuardar 
         BackColor       =   &H80000013&
         Caption         =   "&GUARDAR"
         Height          =   855
         Left            =   10800
         Picture         =   "FrmFacturacion.frx":271E
         Style           =   1  'Graphical
         TabIndex        =   24
         Top             =   960
         Width           =   1455
      End
      Begin VB.CommandButton CmdNuevo 
         BackColor       =   &H80000013&
         Caption         =   "&NUEVO"
         Height          =   855
         Left            =   10800
         Picture         =   "FrmFacturacion.frx":2FE8
         Style           =   1  'Graphical
         TabIndex        =   23
         Top             =   0
         Width           =   1455
      End
      Begin VB.CommandButton cmdagregar 
         BackColor       =   &H80000013&
         Caption         =   "&AGREGAR"
         Enabled         =   0   'False
         Height          =   735
         Left            =   8520
         Picture         =   "FrmFacturacion.frx":342A
         Style           =   1  'Graphical
         TabIndex        =   22
         Top             =   2400
         Width           =   1095
      End
      Begin VB.CommandButton cmdquitar 
         BackColor       =   &H80000013&
         Caption         =   "&QUITAR"
         Enabled         =   0   'False
         Height          =   735
         Left            =   9600
         Picture         =   "FrmFacturacion.frx":3734
         Style           =   1  'Graphical
         TabIndex        =   21
         Top             =   2400
         Width           =   1095
      End
      Begin VB.TextBox TSUBTOTAL 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   285
         Left            =   9120
         Locked          =   -1  'True
         MaxLength       =   60
         TabIndex        =   20
         Text            =   "0"
         Top             =   6840
         Width           =   1575
      End
      Begin VB.TextBox TIGV 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   285
         Left            =   9120
         Locked          =   -1  'True
         MaxLength       =   60
         TabIndex        =   19
         Text            =   "0"
         Top             =   7560
         Width           =   1575
      End
      Begin VB.TextBox TTOTAL 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   285
         Left            =   9120
         Locked          =   -1  'True
         MaxLength       =   60
         TabIndex        =   18
         Text            =   "0"
         Top             =   7920
         Width           =   1575
      End
      Begin VB.CommandButton CmdVImprimir 
         BackColor       =   &H80000013&
         Caption         =   "&IMPRIMIR"
         Height          =   855
         Left            =   12360
         Picture         =   "FrmFacturacion.frx":3A3E
         Style           =   1  'Graphical
         TabIndex        =   17
         Top             =   1920
         Width           =   1455
      End
      Begin VB.CommandButton CmdBuscar 
         BackColor       =   &H80000013&
         Caption         =   "&BUSCAR"
         Height          =   855
         Left            =   10800
         Picture         =   "FrmFacturacion.frx":3D48
         Style           =   1  'Graphical
         TabIndex        =   16
         Top             =   1920
         Width           =   1455
      End
      Begin VB.Frame Frame1 
         BackColor       =   &H00B0726D&
         Height          =   1095
         Left            =   0
         TabIndex        =   4
         Top             =   2040
         Width           =   6495
         Begin VB.TextBox TXTprecio 
            Alignment       =   1  'Right Justify
            Height          =   315
            Left            =   3000
            MaxLength       =   50
            TabIndex        =   11
            Top             =   600
            Width           =   1215
         End
         Begin VB.ComboBox cmbproducto 
            Height          =   315
            Left            =   960
            Sorted          =   -1  'True
            TabIndex        =   10
            Top             =   240
            Width           =   5055
         End
         Begin VB.TextBox txtidproducto 
            Height          =   285
            Left            =   0
            TabIndex        =   9
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
            Picture         =   "FrmFacturacion.frx":4052
            Style           =   1  'Graphical
            TabIndex        =   8
            ToolTipText     =   "BUSCAR PRODUCTO"
            Top             =   240
            Width           =   375
         End
         Begin VB.TextBox txtcantidad 
            Alignment       =   1  'Right Justify
            Height          =   315
            Left            =   960
            MaxLength       =   50
            TabIndex        =   7
            Top             =   600
            Width           =   1215
         End
         Begin VB.TextBox txtttotal 
            Alignment       =   1  'Right Justify
            BackColor       =   &H80000018&
            Height          =   315
            Left            =   5160
            Locked          =   -1  'True
            MaxLength       =   50
            TabIndex        =   6
            Top             =   600
            Width           =   1215
         End
         Begin VB.TextBox txtNITEM 
            Height          =   285
            Left            =   0
            TabIndex        =   5
            Text            =   "Text1"
            Top             =   840
            Visible         =   0   'False
            Width           =   105
         End
         Begin VB.Label Label11 
            BackStyle       =   0  'Transparent
            Caption         =   "Producto"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   15
            Top             =   240
            Width           =   855
         End
         Begin VB.Label Label10 
            BackStyle       =   0  'Transparent
            Caption         =   "Precio"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   2400
            TabIndex        =   14
            Top             =   720
            Width           =   615
         End
         Begin VB.Label Label12 
            BackStyle       =   0  'Transparent
            Caption         =   "Cantidad"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   120
            TabIndex        =   13
            Top             =   720
            Width           =   855
         End
         Begin VB.Label Label13 
            BackStyle       =   0  'Transparent
            Caption         =   "Total"
            ForeColor       =   &H8000000E&
            Height          =   255
            Left            =   4560
            TabIndex        =   12
            Top             =   720
            Width           =   615
         End
      End
      Begin VB.CommandButton CMDNUEVO1 
         BackColor       =   &H80000013&
         Caption         =   "&NUEVO"
         Enabled         =   0   'False
         Height          =   735
         Left            =   7440
         Picture         =   "FrmFacturacion.frx":4584
         Style           =   1  'Graphical
         TabIndex        =   3
         Top             =   2400
         Width           =   1095
      End
      Begin VB.TextBox TDESCUENTO 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000018&
         Height          =   285
         Left            =   9120
         Locked          =   -1  'True
         MaxLength       =   60
         TabIndex        =   2
         Text            =   "0"
         Top             =   7200
         Width           =   1575
      End
      Begin VB.CommandButton cmdcuotas 
         BackColor       =   &H80000013&
         Caption         =   "&CUOTAS"
         Height          =   855
         Left            =   10800
         Picture         =   "FrmFacturacion.frx":4BBE
         Style           =   1  'Graphical
         TabIndex        =   1
         Top             =   2880
         Width           =   1455
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   3495
         Left            =   0
         TabIndex        =   48
         Top             =   3240
         Width           =   10695
         _ExtentX        =   18865
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
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Sub-Total"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   8040
         TabIndex        =   54
         Top             =   6840
         Width           =   1215
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "I.G.V"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   8040
         TabIndex        =   53
         Top             =   7560
         Width           =   495
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Total"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   8040
         TabIndex        =   52
         Top             =   7920
         Width           =   1215
      End
      Begin VB.Label LBLIGV 
         Alignment       =   1  'Right Justify
         BackStyle       =   0  'Transparent
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6360
         TabIndex        =   51
         Top             =   7800
         Width           =   855
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Descuento"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   8040
         TabIndex        =   50
         Top             =   7200
         Width           =   1215
      End
      Begin VB.Label lblletras 
         BackStyle       =   0  'Transparent
         ForeColor       =   &H8000000E&
         Height          =   375
         Left            =   0
         TabIndex        =   49
         Top             =   6840
         Width           =   7815
      End
   End
End
Attribute VB_Name = "FrmFacturacion"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public NUEVO As Boolean
Public NuevoDetalle As Boolean
Dim CapaVenta As New ClsFacturacion
Dim CapaL As New ClsMonedaALetras

Friend Sub ACTIVAR(ByVal VALORCITO As Boolean)
cmdquitar.Enabled = VALORCITO
cmdagregar.Enabled = VALORCITO
CMDNUEVO1.Enabled = VALORCITO
End Sub

Private Sub cmbcliente_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbcliente, KeyAscii
End Sub

Private Sub cmbcliente_LostFocus()
BuscarEnCombito cmbcliente
End Sub

Private Sub cmbproducto_Click()
If cmbproducto = "" Then
Exit Sub
End If
txtidproducto = DevuelveIdProducto(cmbproducto)
TXTprecio = Format$(precioPRO(txtidproducto), "###.00")
txtcantidad = "0"
End Sub

Private Sub cmbproducto_KeyPress(KeyAscii As Integer)
 ValidarIngreso1 cmbproducto, KeyAscii
End Sub

Private Sub cmbproducto_LostFocus()
  BuscarEnCombito cmbproducto
End Sub
Private Sub cmdagregar_Click()
On Local Error GoTo L
Dim T As New ADODB.Recordset, c As Double, estockmin As Double, estock As Double
If NuevoDetalle = True Then
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
  XX = GenerarCodigo("SELECT MAX(NITEM) FROM DETALLEventa  WHERE idventa='" + txtidventa + "'", 3)
  'AGREGA DETALLE
  T.Open "DETALLEventa", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!idventa = txtidventa
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
  'ELIMINAR DETALLE
  cn.Execute "DELETE * FROM detalleventa WHERE idventa='" + txtidventa + "' AND NITEM='" + txtNITEM + "'"
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
  'AGREGA DETALLE
  T.Open "detalleventa", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!idventa = txtidventa
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
  TSUBTOTAL = Format$(CapaVenta.P_RellenarListaDetalle(MSHFlexGrid1, txtidventa, cn), "###.00")
  Call ActualizarKardex
  If T.State = adStateOpen Then Set T = Nothing
Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub
Private Sub CmdAnular_Click()
  If txtidventa = "" Then Exit Sub
  Set LIMPIAR = Me
  ACTIVAR False
  MSHFlexGrid1.Clear
  MSHFlexGrid1.Rows = 2
  MSHFlexGrid1.Cols = 2
End Sub

Private Sub CmdBuscar_Click()
FrmFacturacionBuscar.Show 1
End Sub

Private Sub cmdcliente_Click()
  frmRegistroDueño.Show 1
End Sub

Private Sub cmdcuotas_Click()
If optcredito.Value = True Then
  FrmCuotas.Show 1
End If
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtidventa) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  If EliminarTabla(txtidventa, "Ventas", "idventa") > 0 Then
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
  If txtidventa = "" Then Exit Sub
  If optcontado.Value = False And optcredito.Value = False Then
    MsgBox "Seleccione Tipo de Pago Contado ó Crédito...!", vbExclamation
    Exit Sub
  End If
  If OPTBOLETA.Value = False And OPTFACTURA.Value = False Then
    MsgBox "Seleccione Tipo de Pago Fatura o Boleta...!", vbExclamation
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
  If NUEVO = True Then
    T.Open "ventas", cn, adOpenDynamic, adLockOptimistic, adCmdTable
    T.AddNew
    T!idventa = txtidventa
    T!cancelado = IIf(optcontado.Value = True, 0, 1)
    T!anulado = 0
  Else
    T.Open "SELECT * FROM ventas WHERE idventa='" + txtidventa + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
  End If
  T!CodDueño = Devuelve_IdCliente(cmbcliente)
  T!idusuario = CapaVenta.DevuelveIdUsuario(txtusuario)
  T!Fecha = CDate(txtFECHA.Text)
  T!tipo_venta = IIf(optcontado.Value = True, 0, 1)
  T!iddocumento = DevuelveIdDocumento(IIf(OPTBOLETA.Value = True, "Boleta", "Factura"))
  T!ndocumento = txtndocumento
  T!igv = DevuelveIGV
  T!descuento = Val(txtDescuento)
  T!MONTO = Val(TTOTAL)
  T!idpromotor = Devuelve_IdPromotor(cmbpromotor)
  T!Moneda = IIf(optsoles.Value = True, "1", "2")
  T!tipcam = Val(txttipocambio)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     cn.Execute "UPDATE TABSERIES SET serie2='" + Right(txtndocumento, Len(txtndocumento) - 4) + "' WHERE Documento='" + IIf(OPTBOLETA.Value = True, "Boleta", "Factura") + "'"
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  NUEVO = False
  NuevoDetalle = True
  ACTIVAR True
  CapaVenta.P_RellenarListaDetalle MSHFlexGrid1, txtidventa, cn
  Call ActualizarKardex
  TSUBTOTAL_Change
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Friend Sub ActualizarKardex()
On Local Error GoTo L
  Dim T As New ADODB.Recordset, IdNkardex As String, idDOCS As String, totDet As Double
    idDOCS = DevuelveIdDocumento(IIf(OPTBOLETA.Value = True, "Boleta", "Factura"))
  T.Open "select nkardex from kardex where IDDOCUMENTO='" + idDOCS + "' and NDOCUMENTO='" + txtndocumento + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
  IdNkardex = ""
  Else
  IdNkardex = T(0)
  End If
  If T.State = adStateOpen Then T.Close
  cn.Execute "delete * from detallekardex where nkardex='" + IdNkardex + "'"
  cn.Execute "delete * FROM KARDEX where nkardex='" + IdNkardex + "'"
  If Trim$(IdNkardex) = "" Then
    IdNkardex = "S" + DevuelveSerie("S") + "-" + GenerarCodigo("SELECT max(right(nkardex,7)) From Kardex where tipo_mov='S'", 7)
  End If
  T.Open "KARDEX", cn, adOpenDynamic, adLockOptimistic, adCmdTable
  T.AddNew
  T!nkardex = IdNkardex
  T!idmotivo = DevuelveIdMotivo("Ventas")
  T!tipo_mov = "S"
  T!iddocumento = idDOCS
  T!ndocumento = Trim$(txtndocumento)
  T!fechamovin = CDate(txtFECHA)
  T!CodDueño = Devuelve_IdCliente(cmbcliente)
  T!idpromotor = Devuelve_IdPromotor(cmbpromotor)
  T!Moneda = IIf(optsoles.Value = True, "1", "2")
  T!tipcam = Val(txttipocambio)
  T.Update
  If T.State = adStateOpen Then T.Close
  T.Open "select count(*) from detalleventa where idventa='" + txtidventa + "'", cn, adOpenForwardOnly, adLockReadOnly
  totDet = T(0)
  If T.State = adStateOpen Then T.Close
    T.Open "Select nkardex,nitem,idproducto,cantidad,precio,subtotal,saldo,inicial from DetalleKardex", cn, adOpenDynamic, adLockOptimistic
  For I = 1 To totDet
    T.AddNew
    T!nkardex = IdNkardex
    T!nitem = MSHFlexGrid1.TextMatrix(I, 2)
    T!idproducto = MSHFlexGrid1.TextMatrix(I, 3)
    T!CANTIDAD = MSHFlexGrid1.TextMatrix(I, 5)
    T!precio = MSHFlexGrid1.TextMatrix(I, 6)
    T!subtotal = MSHFlexGrid1.TextMatrix(I, 7)
    T!saldo = MSHFlexGrid1.TextMatrix(I, 8)
    T!inicial = MSHFlexGrid1.TextMatrix(I, 9)
    T.Update
  Next I
  Set T = Nothing
  Exit Sub
L:
  If Err.Number = 3021 Then
    Exit Sub
  End If
  MsgBox Err.Description, vbCritical
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
Set LIMPIAR = Me
txtFECHA = Format$(Now, "DD/MM/YYYY HH:MM:SS")
txtidventa = GenerarCodigo(S_IDVENTAS, 10)
ACTIVAR False
MSHFlexGrid1.Clear
MSHFlexGrid1.Rows = 2
MSHFlexGrid1.Cols = 2
txtusuario = CapaVenta.XNomUsu(IdUsu, cn)
txttipocambio = Devuelve_TipoCambio
optsoles.Value = True
End Sub

Public Sub CMDNUEVO1_Click()
NuevoDetalle = True
cmbproducto = Empty
txtcantidad = "0"
TXTprecio = "0.00"
txtttotal = "0.00"
txtidproducto = Empty
txtNITEM = Empty
End Sub

Private Sub cmdpromotor_Click()
FrmPromotores.Show 1
End Sub

Private Sub cmdquitar_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  If MsgBox("¿Desea Eliminar El Elemento Seleccionado ...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbYes Then
On Local Error GoTo L
    Dim T As New ADODB.Recordset
    'ELIMINAR DETALLE
    cn.Execute "DELETE * FROM DetalleVenta WHERE idventa='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1) + "' AND nitem='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2) + "'", K
    'ACTUALIZAR STOCK
    T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 3) + "'", cn, adOpenDynamic, adLockOptimistic
    T!CANTIDAD = T!CANTIDAD + Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 5))
    T!subtotal = T!precio * T!CANTIDAD
    T.Update
    If T.State = adStateOpen Then Set T = Nothing
    txtcantidad = "0.00"
    TXTprecio = "0.00"
    txtttotal = "0.00"
    txtidproducto = Empty
    txtNITEM = Empty
    TSUBTOTAL = Format$(CapaVenta.P_RellenarListaDetalle(MSHFlexGrid1, txtidventa, cn), "###.00")
    End If
  Call ActualizarKardex
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
FrmBuscarProducto.Show 1
End Sub

Private Sub Command2_Click()
If MsgBox("¿Desea Anular El Documento ...?", vbYesNo + vbQuestion + vbDefaultButton2) = vbYes Then
  cn.Execute "UPDATE VENTAS SET ANULADO=1 WHERE IDVENTA='" + txtidventa + "' and ANULADO=0", I
  cn.Execute "UPDATE KARDEX SET ANULADO=1 WHERE NDOCUMENTO='" + txtndocumento + "' AND TIPO_MOV='S' AND IDDOCUMENTO='" + DevuelveIdDocumento(IIf(OPTBOLETA.Value = True, "Boleta", "Factura")) + "' and ANULADO=0", I
  If I > 0 Then
    For j = 1 To MSHFlexGrid1.Rows - 1
      cn.Execute "UPDATE PRODUCTOS SET CANTIDAD=CANTIDAD+" + MSHFlexGrid1.TextMatrix(j, 5) + " WHERE IDPRODUCTO='" + MSHFlexGrid1.TextMatrix(j, 3) + "'"
      cn.Execute "update productos set subtotal=cantidad*precio where idproducto='" + MSHFlexGrid1.TextMatrix(j, 3) + "'"
    Next
   FrmMensajeAnulado.Show 1
   Else
   MsgBox "El Comprobante Ya Esta Anulado ..", vbInformation
  End If
  cn.Execute "UPDATE tb_deuda SET ANULADO=1 WHERE NDOCUMENTO='" + txtndocumento + "' AND IDDOCUMENTO='" + DevuelveIdDocumento(IIf(OPTBOLETA.Value = True, "Boleta", "Factura")) + "' and ANULADO=0"

  Command2.Enabled = False
End If
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
If V_ANULAR = True Then
Command2.Visible = True
  MuesstraVENTAS
  TSUBTOTAL.Text = CapaVenta.P_RellenarListaDetalle(MSHFlexGrid1, txtidventa, cn)
  PICT.Enabled = False
  Exit Sub
End If
V_FACTURACION = True
P_RellenaCombo "PROD", cmbproducto
P_RellenaCombo "CLI", cmbcliente
P_RellenaCombo "promotor", cmbpromotor
CmdNuevo_Click
End Sub
Public Sub MuesstraVENTAS()
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  If Form1.OPTFACTURA.Value = True Then
        T.Open "SELECT * FROM VENTAS INNER JOIN DOCUMENTOS ON DOCUMENTOS.IDDOCUMENTO=VENTAS.IDDOCUMENTO WHERE DOCUMENTOS.DESDOCUMENTO='Factura' and ndocumento='" + Form1.Text1 + "'", cn, adOpenForwardOnly, adLockReadOnly
        OPTFACTURA.Value = True
    ElseIf Form1.OPTBOLETA.Value = True Then
        T.Open "SELECT * FROM VENTAS INNER JOIN DOCUMENTOS ON DOCUMENTOS.IDDOCUMENTO=VENTAS.IDDOCUMENTO WHERE DOCUMENTOS.DESDOCUMENTO='Boleta' and ndocumento='" + Form1.Text1 + "'", cn, adOpenForwardOnly, adLockReadOnly
        OPTBOLETA.Value = True
  End If
  REFRESCAR T
  If T.RecordCount = 0 Then
  MsgBox "No Existe ...!", vbInformation
  Exit Sub
  End If
  txtFECHA = T!Fecha
  txtidventa = T!idventa
  If T!tipo_venta = 0 Then optcontado.Value = True
  If T!tipo_venta = 1 Then optcredito.Value = True
  cmbcliente = Devuelve_NomApeCliente(T!CodDueño)
  txtDescuento = T!descuento
  Dim XU As String, XNOMU As String
  Devuelve_NomUsuas T!idusuario, XU, XNOMU
  txtusuario = XU
  Text1 = XNOMU
  txtcancelado = T!cancelado
  txtndocumento = T!ndocumento
  Set T = Nothing
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub Form_Unload(Cancel As Integer)
Set CapaVenta = Nothing
Set CapaL = Nothing
V_FACTURACION = False
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
NuevoDetalle = False
End Sub

Private Sub optboleta_Click()
If OPTBOLETA.Value = True Then
    txtndocumento = GenerarNDocumento("Boleta")
End If
End Sub

Private Sub OPTFACTURA_Click()
  If OPTFACTURA.Value = True Then
      txtndocumento = GenerarNDocumento("Factura")
  End If
End Sub

Private Sub TSUBTOTAL_Change()
  TSUBTOTAL = Format$(Val(TSUBTOTAL), "###.00")
  TDESCUENTO = Format$((Val(txtDescuento) * Val(TSUBTOTAL)) / 100, "###.00")
  If Val(TDESCUENTO) <= 1 Then TDESCUENTO = "0" + TDESCUENTO
  If Val(TDESCUENTO) = 0 Then TDESCUENTO = "0.00"
  TIGV = Format$((DevuelveIGV() * Val(TSUBTOTAL)) / 100, "###.00")
  If Val(TIGV) = 0 Then TIGV = "0.00"
  TTOTAL = Format$(Val(TSUBTOTAL) + Val(TIGV) - Val(TDESCUENTO), "###.00")
  lblletras.Caption = "Son: " + CapaL.olpol(TTOTAL) + " " + IIf(optsoles.Value = True, "Nuevos Soles", "Dolares Americanos")
  If Val(TIGV) <= 1 Then TIGV = "0" + TIGV
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
  If Not (Val(txtDescuento) >= 0 And Val(txtDescuento) <= 100) Then
    txtDescuento = 0
    Exit Sub
  End If
  
End Sub

Private Sub txtprecio_Change()
  txtttotal = Format$(Val(txtcantidad) * Val(TXTprecio), "###.00")

End Sub

Private Sub TXTprecio_GotFocus()
TXTprecio.SelStart = 0
TXTprecio.SelLength = Len(TXTprecio)
End Sub

Private Sub txtusuario_Change()
If txtusuario = "" Then Exit Sub
Text1 = DevuelveNombresusuario(txtusuario)
End Sub

