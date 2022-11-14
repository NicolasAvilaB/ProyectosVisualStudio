VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmProductos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PRODUCTOS"
   ClientHeight    =   10365
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   15075
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
   Icon            =   "FrmProductos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10365
   ScaleWidth      =   15075
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton CmdNuevo 
      BackColor       =   &H80000013&
      Caption         =   "&NUEVO"
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProductos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   29
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdModificar 
      BackColor       =   &H80000013&
      Caption         =   "&MODIFICAR"
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProductos.frx":074C
      Style           =   1  'Graphical
      TabIndex        =   28
      Top             =   1080
      Width           =   1455
   End
   Begin VB.CommandButton CmdGuardar 
      BackColor       =   &H80000013&
      Caption         =   "&GUARDAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   9720
      Picture         =   "FrmProductos.frx":0B8E
      Style           =   1  'Graphical
      TabIndex        =   27
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CmdAnular 
      BackColor       =   &H80000013&
      Caption         =   "&CANCELAR"
      Enabled         =   0   'False
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProductos.frx":1458
      Style           =   1  'Graphical
      TabIndex        =   26
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProductos.frx":24EA
      Style           =   1  'Graphical
      TabIndex        =   25
      Top             =   2040
      Width           =   1455
   End
   Begin VB.CommandButton CMdELIMINAR 
      BackColor       =   &H80000013&
      Caption         =   "&ELIMINAR"
      Height          =   855
      Left            =   11280
      Picture         =   "FrmProductos.frx":27F4
      Style           =   1  'Graphical
      TabIndex        =   24
      Top             =   1080
      Width           =   1455
   End
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   7335
      Left            =   120
      ScaleHeight     =   7275
      ScaleWidth      =   14835
      TabIndex        =   17
      Top             =   3000
      Width           =   14895
      Begin VB.OptionButton optdescripcion 
         BackColor       =   &H00B0726D&
         Caption         =   "Descripción"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   4920
         TabIndex        =   23
         Top             =   120
         Width           =   1695
      End
      Begin VB.TextBox txtbuscar 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   315
         Left            =   6600
         TabIndex        =   20
         Top             =   120
         Width           =   6015
      End
      Begin VB.OptionButton optmarca 
         BackColor       =   &H00B0726D&
         Caption         =   "Marca"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   3840
         TabIndex        =   19
         Top             =   120
         Width           =   1095
      End
      Begin VB.OptionButton optcategoria 
         BackColor       =   &H00B0726D&
         Caption         =   "Categoría"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H80000014&
         Height          =   255
         Left            =   2400
         TabIndex        =   18
         Top             =   120
         Value           =   -1  'True
         Width           =   1455
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   6375
         Left            =   120
         TabIndex        =   21
         Top             =   600
         Width           =   14655
         _ExtentX        =   25850
         _ExtentY        =   11245
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
      Begin VB.Label LBLTOTAL 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000012&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "0"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   13440
         TabIndex        =   38
         Top             =   7000
         Width           =   1335
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "TOTAL:"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   12600
         TabIndex        =   37
         Top             =   7005
         Width           =   855
      End
      Begin VB.Label Label13 
         AutoSize        =   -1  'True
         BackColor       =   &H80000013&
         BackStyle       =   0  'Transparent
         Caption         =   "Buscar Producto Por:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H8000000E&
         Height          =   240
         Left            =   120
         TabIndex        =   22
         Top             =   120
         Width           =   2205
      End
   End
   Begin VB.PictureBox Picture1 
      BackColor       =   &H00B0726D&
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   2775
      Left            =   120
      ScaleHeight     =   2715
      ScaleWidth      =   9435
      TabIndex        =   9
      Top             =   120
      Width           =   9495
      Begin VB.ComboBox cmbsubcategoria 
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   35
         Top             =   900
         Width           =   5055
      End
      Begin VB.CommandButton cmdsubcategoria 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6360
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmProductos.frx":2AFE
         Style           =   1  'Graphical
         TabIndex        =   34
         ToolTipText     =   "BUSCAR SUB-CATEGORÍA"
         Top             =   900
         Width           =   375
      End
      Begin VB.TextBox txtstock 
         BackColor       =   &H80000018&
         Height          =   315
         Left            =   8280
         Locked          =   -1  'True
         MaxLength       =   50
         TabIndex        =   7
         Top             =   1680
         Width           =   1095
      End
      Begin VB.TextBox txtprecioventa 
         Height          =   315
         Left            =   8280
         MaxLength       =   50
         TabIndex        =   6
         Top             =   1320
         Width           =   1095
      End
      Begin VB.CommandButton cmdmarca 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6360
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmProductos.frx":3030
         Style           =   1  'Graphical
         TabIndex        =   31
         ToolTipText     =   "BUSCAR EDITORIAL"
         Top             =   1250
         Width           =   375
      End
      Begin VB.CommandButton cmdcategoria 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6360
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmProductos.frx":3562
         Style           =   1  'Graphical
         TabIndex        =   30
         ToolTipText     =   "BUSCAR CATEGORÍA"
         Top             =   550
         Width           =   375
      End
      Begin VB.TextBox txtobservacion 
         Height          =   645
         Left            =   1320
         MaxLength       =   50
         MultiLine       =   -1  'True
         ScrollBars      =   2  'Vertical
         TabIndex        =   3
         Top             =   1980
         Width           =   5055
      End
      Begin VB.TextBox txtstockmin 
         Height          =   315
         Left            =   8280
         MaxLength       =   50
         TabIndex        =   4
         Top             =   600
         Width           =   1095
      End
      Begin VB.TextBox txtstockmax 
         Height          =   315
         Left            =   8280
         MaxLength       =   50
         TabIndex        =   5
         Top             =   960
         Width           =   1095
      End
      Begin VB.ComboBox cmbmarca 
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   1
         Top             =   1250
         Width           =   5055
      End
      Begin VB.ComboBox cmbcategoria 
         Height          =   315
         Left            =   1320
         Sorted          =   -1  'True
         TabIndex        =   0
         Top             =   550
         Width           =   5055
      End
      Begin VB.TextBox txtcod 
         BackColor       =   &H80000018&
         Height          =   375
         Left            =   1320
         Locked          =   -1  'True
         TabIndex        =   8
         Top             =   120
         Width           =   1455
      End
      Begin VB.TextBox txtdes 
         Height          =   315
         Left            =   1320
         MaxLength       =   50
         TabIndex        =   2
         Top             =   1610
         Width           =   5055
      End
      Begin VB.Label Label7 
         BackStyle       =   0  'Transparent
         Caption         =   "SubCategoría"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   36
         Top             =   900
         Width           =   1215
      End
      Begin VB.Label Label10 
         BackStyle       =   0  'Transparent
         Caption         =   "Stock"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   33
         Top             =   1680
         Width           =   1215
      End
      Begin VB.Label Label9 
         BackStyle       =   0  'Transparent
         Caption         =   "Precio Venta"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   32
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label8 
         BackStyle       =   0  'Transparent
         Caption         =   "Observación"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   16
         Top             =   2000
         Width           =   1215
      End
      Begin VB.Label Label6 
         BackStyle       =   0  'Transparent
         Caption         =   "Stock Mínimo"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   15
         Top             =   600
         Width           =   1215
      End
      Begin VB.Label Label5 
         BackStyle       =   0  'Transparent
         Caption         =   "Stock Máximo"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   6960
         TabIndex        =   14
         Top             =   960
         Width           =   1215
      End
      Begin VB.Label Label4 
         BackStyle       =   0  'Transparent
         Caption         =   "Editorial"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   1245
         Width           =   855
      End
      Begin VB.Label Label3 
         BackStyle       =   0  'Transparent
         Caption         =   "Categoría"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   12
         Top             =   550
         Width           =   1215
      End
      Begin VB.Label Label1 
         BackStyle       =   0  'Transparent
         Caption         =   "Código"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   11
         Top             =   180
         Width           =   855
      End
      Begin VB.Label Label2 
         BackStyle       =   0  'Transparent
         Caption         =   "Descripción"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   1680
         Width           =   1215
      End
   End
End
Attribute VB_Name = "FrmProductos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim NUEVO As Boolean
Friend Sub habilitar()
  CmdAnular.Enabled = Not CmdAnular.Enabled
  CmdGuardar.Enabled = Not CmdGuardar.Enabled
  CmdModificar.Enabled = Not CmdModificar.Enabled
  CmdSalir.Enabled = Not CmdSalir.Enabled
  CmdNuevo.Enabled = Not CmdNuevo.Enabled
  Picture1.Enabled = Not Picture1.Enabled
  Picture2.Enabled = Not Picture2.Enabled
  CMdELIMINAR.Enabled = Not CMdELIMINAR.Enabled
End Sub
Private Sub cmbcategoria_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbcategoria, KeyAscii
End Sub

Private Sub cmbcategoria_LostFocus()
BuscarEnCombito cmbcategoria
End Sub

Private Sub cmbmarca_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbmarca, KeyAscii
End Sub

Private Sub cmbmarca_LostFocus()
BuscarEnCombito cmbmarca
End Sub

Private Sub cmbsubcategoria_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbsubcategoria, KeyAscii
End Sub

Private Sub cmbsubcategoria_LostFocus()
BuscarEnCombito cmbsubcategoria
End Sub

Private Sub CmdAnular_Click()
  habilitar
  Set LIMPIAR = Me
End Sub

Private Sub cmdcategoria_Click()
FrmCategorias.Show 1
End Sub

Private Sub CMdELIMINAR_Click()
On Local Error GoTo Errlinea
  If Trim$(txtcod) = "" Then
    MsgBox "Para Eliminar Seleccione Un Registro de la Lista..!", 48
    Exit Sub
  End If
  If MsgBox("Desea Eliminar El Registro Seleccionado...!", vbQuestion + vbDefaultButton2 + vbYesNo) = vbNo Then
    Exit Sub
  End If
  cn.Execute "delete from PRODUCTOS where IDPRODUCTO='" + txtcod + "'", XEliminar
  If XEliminar > 0 Then
    frmMensajeEliminado.Show 1
    ELIM = 0
    Set LIMPIAR = Me
    LBLTOTAL.Caption = Trim$(prellenaProdutos(MSHFlexGrid1))
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
If Trim(cmbcategoria) = "" Then
MsgBox "Ingrese Categoría...!", vbExclamation
cmbcategoria.SetFocus
Exit Sub
End If
If Trim(cmbmarca) = "" Then
MsgBox "Ingrese Categoría...!", vbExclamation
cmbmarca.SetFocus
Exit Sub
End If
If Trim(txtdes) = "" Then
MsgBox "Ingrese Descripción...!", vbExclamation
txtdes.SetFocus
Exit Sub
End If
If Val(txtstockmin) = 0 Then
MsgBox "Ingrese Stock Mínimo...!", vbExclamation
txtstockmin.SetFocus
Exit Sub
End If
If Val(txtstockmax) = 0 Then
MsgBox "Ingrese Stock Máximo...!", vbExclamation
txtstockmax.SetFocus
Exit Sub
End If
If Val(txtprecioventa) = 0 Then
  MsgBox "Ingrese Precio Venta ...!", vbExclamation
  Exit Sub
End If
If Val(txtstockmax) < Val(txtstockmin) Then
  MsgBox "Ingrese Stock Máximo ...!", vbExclamation
  Exit Sub
End If
Dim T As New ADODB.Recordset
If NUEVO = True Then
  If VerificarExisteProductoN = True Then
    MsgBox "El Producto Ya Esta Registrado ...!", vbInformation
    Set T = Nothing
    Exit Sub
  End If
  T.Open "SELECT * FROM PRODUCTOS", cn, adOpenDynamic, adLockOptimistic, adCmdText
  T.AddNew
  T!idproducto = Trim(txtcod)
Else
  If VerificarExisteProductoM = True Then
    MsgBox "El Producto Ya Esta Registrado ...!", vbInformation
    Set T = Nothing
    Exit Sub
  End If
  T.Open "SELECT * FROM PRODUCTOS WHERE IDPRODUCTO='" + txtcod + "'", cn, adOpenDynamic, adLockOptimistic, adCmdText
End If
  T!Nombre = Trim$(txtdes)
  T!IDcategoria = Devuelve_IdCategoria(cmbcategoria)
  T!IDMARCA = Devuelve_IdMarca(cmbmarca)
  T!idsubcategoria = Devuelve_IdSubCategoria(cmbsubcategoria)
  T!observacion = Trim$(txtobservacion)
  T!stockminimo = Val(txtstockmin)
  T!stockmaximo = Val(txtstockmax)
  T!precio = Val(txtprecioventa)
  T!subtotal = Val(txtprecioventa) * Val(txtstock)
  T.Update
  Set T = Nothing
  If NUEVO = True Then
     frmMensajeNuevo.Show 1
  Else
    frmMensajeEditar.Show 1
  End If
  habilitar
  LBLTOTAL.Caption = prellenaProdutos(MSHFlexGrid1)
  Set LIMPIAR = Me
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Friend Function VerificarExisteProductoN() As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT IDPRODUCTO FROM PRODUCTOS WHERE nombre='" + Trim$(txtdes) + "' AND idcategoria='" + Devuelve_IdCategoria(cmbcategoria) + "' AND idmarca='" + Devuelve_IdMarca(cmbmarca) + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    VerificarExisteProducto = False
    Set T = Nothing
    Exit Function
  End If
  Set T = Nothing
  VerificarExisteProducto = True
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function
Friend Function VerificarExisteProductoM() As Boolean
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  T.Open "SELECT IDPRODUCTO FROM PRODUCTOS WHERE nombre='" + Trim$(txtdes) + "' AND idcategoria='" + Devuelve_IdCategoria(cmbcategoria) + "' AND idmarca='" + Devuelve_IdMarca(cmbmarca) + "' AND IDPRODUCTO<>'" + txtcod + "'", cn, adOpenForwardOnly, adLockReadOnly, adCmdText
  REFRESCAR T
  If T.RecordCount = 0 Then
    VerificarExisteProducto = False
    Set T = Nothing
    Exit Function
  End If
  Set T = Nothing
  VerificarExisteProducto = True
Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function

Private Sub cmdmarca_Click()
FrmMarcas.Show 1
End Sub

Private Sub CmdModificar_Click()
If Trim(txtcod) = "" Then
  MsgBox "Buscar Productos ...!", vbInformation
  Exit Sub
End If
NUEVO = False
habilitar
cmbcategoria.SetFocus
End Sub

Private Sub CmdNuevo_Click()
NUEVO = True
habilitar
txtcod = GenerarCodigo(s_IDPRODUCTO, 8)
On Error Resume Next
cmbcategoria.SetFocus
On Error GoTo 0
End Sub

Private Sub cmdproveedor_Click()
FrmProveedores.Show 1
End Sub

Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub cmdsubcategoria_Click()
FrmSubCategoria.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_PRODUCTOS = True
P_RellenaCombo "MAR", cmbmarca
P_RellenaCombo "CAT", cmbcategoria
P_RellenaCombo "SUBC", cmbsubcategoria
LBLTOTAL.Caption = prellenaProdutos(MSHFlexGrid1)
Centrar_Objeto Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
If V_NOTAINGR = True Then
x = FrmNotaIngreso.cmbproducto
P_RellenaCombo "PROD", FrmNotaIngreso.cmbproducto
FrmNotaIngreso.cmbproducto = x
End If
If V_NOTASALI = True Then
x = FrmNotaSalida.cmbproducto
P_RellenaCombo "PROD", FrmNotaSalida.cmbproducto
FrmNotaSalida.cmbproducto = x
End If
If V_FACTURACION = True Then
x = FrmFacturacion.cmbproducto
P_RellenaCombo "PROD", FrmFacturacion.cmbproducto
FrmFacturacion.cmbproducto = x
End If
  V_PRODUCTOS = False
End Sub

Private Sub MSHFlexGrid1_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
txtcod = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
txtdes = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
cmbcategoria = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4)
cmbsubcategoria = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6)
cmbmarca = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 8)
txtstockmin = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 9)
txtstockmax = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 10)
txtstock = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
txtprecioventa = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)), "###.00")
txtobservacion = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 14)

End Sub

Private Sub MSHFlexGrid1_DblClick()
  If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
  If V_NOTAINGR = True Then
    With FrmNotaIngreso
    P_RellenaCombo "PROD", .cmbproducto
      .cmbproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
      .txtidproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
      .TXTprecio = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)), "###.00")
      .TXTprecio = Format$(precioPRO(.txtidproducto), "###.00")
      .txtcantidad = "0.00"
    End With
    Unload Me
  End If
  If V_NOTASALI = True Then
    With FrmNotaSalida
    P_RellenaCombo "PROD", .cmbproducto
      .cmbproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
      .txtidproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
      .TXTprecio = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)), "###.00")
      .TXTprecio = Format$(precioPRO(.txtidproducto), "###.00")
      If FrmNotaSalida.optdolares.Value = True Then
        .TXTprecio = Format$(Val(.TXTprecio) / Val(FrmNotaSalida.txttipocambio), "###.00")
      End If
 
      .txtcantidad = "0.00"
    End With
    Unload Me
  End If
  If V_FACTURACION = True Then
    With FrmFacturacion
       P_RellenaCombo "PROD", .cmbproducto
      .cmbproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
      .txtidproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
      .TXTprecio = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)), "###.00")
      .TXTprecio = Format$(precioPRO(.txtidproducto), "###.00")
      .txtcantidad = "0.00"
    End With
    Unload Me
  End If
  
  If V_PROVEEDORXPRODUCTO = True Then
    With FrmProductoPorProveedor
      GuardarProductoXProveedor MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1), Devuelve_IdProveedor(.cmbproveedor)
     .cmbproveedor_Click
    End With
    Unload Me
  End If
End Sub

Private Sub MSHFlexGrid1_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = 13 Then
MSHFlexGrid1_DblClick
  Exit Sub
End If
MSHFlexGrid1_Click
End Sub

Private Sub MSHFlexGrid1_KeyUp(KeyCode As Integer, Shift As Integer)
MSHFlexGrid1_Click
End Sub

Private Sub txtbuscar_Change()
If optcategoria.Value = True Then
LBLTOTAL.Caption = prellenaProdutos(MSHFlexGrid1, 1, Trim$(txtbuscar))
Exit Sub
End If
If optmarca.Value = True Then
LBLTOTAL.Caption = prellenaProdutos(MSHFlexGrid1, 2, Trim$(txtbuscar))
Exit Sub
End If
If optdescripcion.Value = True Then
LBLTOTAL.Caption = prellenaProdutos(MSHFlexGrid1, 3, Trim$(txtbuscar))
Exit Sub
End If

End Sub

Private Sub txtbuscar_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtdes_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtobservacion_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, Apostrofe
End Sub

Private Sub txtprecioventa_GotFocus()
txtprecioventa.SelStart = 0
txtprecioventa.SelLength = Len(txtprecioventa)
End Sub

Private Sub txtprecioventa_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
End Sub

Private Sub txtprecioventa_LostFocus()
txtprecioventa = Format$(Val(txtprecioventa), "###.00")
End Sub

Private Sub txtstockmax_GotFocus()
txtstockmax.SelStart = 0
txtstockmax.SelLength = Len(txtstockmax)
End Sub

Private Sub txtstockmax_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
End Sub

Private Sub txtstockmin_GotFocus()
txtstockmin.SelStart = 0
txtstockmin.SelLength = Len(txtstockmin)
End Sub

Private Sub txtstockmin_KeyPress(KeyAscii As Integer)
xRestringir KeyAscii, moneda
End Sub
