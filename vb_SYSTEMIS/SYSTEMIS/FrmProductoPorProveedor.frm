VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmProductoPorProveedor 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "PRODUCTO POR PROVEEDOR"
   ClientHeight    =   10320
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   14280
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
   Icon            =   "FrmProductoPorProveedor.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   10320
   ScaleWidth      =   14280
   StartUpPosition =   3  'Windows Default
   Begin VB.Frame Frame1 
      BackColor       =   &H00B0726D&
      ForeColor       =   &H8000000E&
      Height          =   10215
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   14055
      Begin VB.CommandButton Command4 
         BackColor       =   &H80000013&
         Caption         =   "Quitar"
         Height          =   375
         Left            =   8760
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton Command3 
         BackColor       =   &H80000013&
         Cancel          =   -1  'True
         Caption         =   "Salir"
         Height          =   375
         Left            =   9840
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   240
         Width           =   975
      End
      Begin VB.CommandButton Command1 
         BackColor       =   &H80000013&
         Caption         =   "Buscar Productos"
         Height          =   375
         Left            =   6960
         Style           =   1  'Graphical
         TabIndex        =   4
         Top             =   240
         Width           =   1695
      End
      Begin VB.ComboBox cmbproveedor 
         Height          =   315
         Left            =   1200
         Sorted          =   -1  'True
         TabIndex        =   2
         Top             =   240
         Width           =   4935
      End
      Begin VB.CommandButton Command2 
         BackColor       =   &H80000017&
         Height          =   350
         Left            =   6120
         MaskColor       =   &H00FFFFFF&
         Picture         =   "FrmProductoPorProveedor.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   1
         ToolTipText     =   "BUSCAR PROVEEDOR"
         Top             =   240
         Width           =   375
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   9375
         Left            =   120
         TabIndex        =   7
         Top             =   720
         Width           =   13815
         _ExtentX        =   24368
         _ExtentY        =   16536
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
      Begin VB.Label Label14 
         BackStyle       =   0  'Transparent
         Caption         =   "Proveedor"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   240
         Width           =   1215
      End
   End
End
Attribute VB_Name = "FrmProductoPorProveedor"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Public Sub cmbproveedor_Click()
  If cmbproveedor = "" Then Exit Sub
  RelleNAlISTAproveedorporprdocuto Devuelve_IdProveedor(FrmProductoPorProveedor.cmbproveedor), FrmProductoPorProveedor.MSHFlexGrid1
End Sub

Private Sub cmbproveedor_KeyPress(KeyAscii As Integer)
ValidarIngreso1 cmbproveedor, KeyAscii
End Sub

Public Sub cmbproveedor_LostFocus()
BuscarEnCombito cmbproveedor
End Sub

Private Sub Command1_Click()
If cmbproveedor = "" Then Exit Sub
FrmProductos.Show 1
End Sub

Private Sub Command2_Click()
FrmProveedores.Show 1
End Sub

Private Sub Command3_Click()
Unload Me
End Sub

Private Sub Command4_Click()
If MSHFlexGrid1.TextMatrix(1, 1) = "" Then Exit Sub
If MsgBox("¿Desea Quitar El Producto Seleccionado ...?", vbQuestion + vbYesNo + vbDefaultButton2) = vbNo Then Exit Sub
cn.Execute "delete * from ProveedorXProducto where idproducto='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1) + "' and idproveedor='" + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + "'", I
If I > 0 Then
  RelleNAlISTAproveedorporprdocuto Devuelve_IdProveedor(FrmProductoPorProveedor.cmbproveedor), FrmProductoPorProveedor.MSHFlexGrid1
  frmMensajeEliminado.Show 1
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
V_PROVEEDORXPRODUCTO = True
P_RellenaCombo "PROV", cmbproveedor
Centrar_Objeto Me
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_PROVEEDORXPRODUCTO = False
End Sub


