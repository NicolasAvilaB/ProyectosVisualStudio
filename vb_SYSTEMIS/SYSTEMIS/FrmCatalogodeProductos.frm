VERSION 5.00
Begin VB.Form FrmCatalogodeProductos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "CATÁLOGO DE PRODUCTOS"
   ClientHeight    =   3180
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   7995
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
   Icon            =   "FrmCatalogodeProductos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3180
   ScaleWidth      =   7995
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdproveedor 
      BackColor       =   &H80000017&
      Height          =   315
      Left            =   7440
      MaskColor       =   &H00FFFFFF&
      Picture         =   "FrmCatalogodeProductos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   14
      ToolTipText     =   "BUSCAR PROVEEDOR"
      Top             =   1560
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdmarca 
      BackColor       =   &H80000017&
      Height          =   315
      Left            =   7440
      MaskColor       =   &H00FFFFFF&
      Picture         =   "FrmCatalogodeProductos.frx":083C
      Style           =   1  'Graphical
      TabIndex        =   13
      ToolTipText     =   "BUSCAR MARCA"
      Top             =   1200
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdsubcategoria 
      BackColor       =   &H80000017&
      Height          =   315
      Left            =   7440
      MaskColor       =   &H00FFFFFF&
      Picture         =   "FrmCatalogodeProductos.frx":0D6E
      Style           =   1  'Graphical
      TabIndex        =   12
      ToolTipText     =   "BUSCAR SUB CATEGORÍA"
      Top             =   840
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdcategoria 
      BackColor       =   &H80000017&
      Height          =   315
      Left            =   7440
      MaskColor       =   &H00FFFFFF&
      Picture         =   "FrmCatalogodeProductos.frx":12A0
      Style           =   1  'Graphical
      TabIndex        =   11
      ToolTipText     =   "BUSCAR CATEGORÍA"
      Top             =   480
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.TextBox txtproveedor 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3240
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   10
      Top             =   1560
      Width           =   4215
   End
   Begin VB.TextBox txtmarca 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3240
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   9
      Top             =   1200
      Width           =   4215
   End
   Begin VB.TextBox txtsubcategoria 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3240
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   8
      Top             =   840
      Width           =   4215
   End
   Begin VB.TextBox txtcategoria 
      BackColor       =   &H80000018&
      Height          =   315
      Left            =   3240
      Locked          =   -1  'True
      MaxLength       =   60
      TabIndex        =   7
      Top             =   480
      Width           =   4215
   End
   Begin VB.CommandButton CmdSalir 
      BackColor       =   &H80000013&
      Cancel          =   -1  'True
      Caption         =   "&SALIR"
      Height          =   855
      Left            =   5280
      Picture         =   "FrmCatalogodeProductos.frx":17D2
      Style           =   1  'Graphical
      TabIndex        =   6
      Top             =   2160
      Width           =   1455
   End
   Begin VB.CommandButton CmdVImprimir 
      BackColor       =   &H80000013&
      Caption         =   "&IMPRIMIR"
      Height          =   855
      Left            =   3720
      Picture         =   "FrmCatalogodeProductos.frx":1ADC
      Style           =   1  'Graphical
      TabIndex        =   5
      Top             =   2160
      Width           =   1455
   End
   Begin VB.OptionButton opttodos 
      BackColor       =   &H00B0726D&
      Caption         =   "Todos Los Productos"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   120
      Value           =   -1  'True
      Width           =   2895
   End
   Begin VB.OptionButton optporsubcategoria 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Sub-Categoría"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   3
      Top             =   840
      Width           =   2895
   End
   Begin VB.OptionButton optporproveedor 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Proveedor"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   2
      Top             =   1560
      Width           =   2895
   End
   Begin VB.OptionButton optpomarca 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Editorial"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   1
      Top             =   1200
      Width           =   2535
   End
   Begin VB.OptionButton optporcategoria 
      BackColor       =   &H00B0726D&
      Caption         =   "Productos Por Categoría"
      ForeColor       =   &H8000000E&
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   480
      Width           =   2655
   End
End
Attribute VB_Name = "FrmCatalogodeProductos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Sub lim()
  txtcategoria = "": txtmarca = ""
  txtproveedor = "": txtsubcategoria = ""
End Sub

Private Sub cmdcategoria_Click()
FrmCategorias.Show 1
End Sub

Private Sub cmdmarca_Click()
FrmMarcas.Show 1
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

Private Sub CmdVImprimir_Click()
FrmReportes.Show 1
End Sub

Private Sub Form_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Screen.MousePointer = vbHourglass
V_FrmCatalogodeProductos = True
End Sub

Private Sub Form_Unload(Cancel As Integer)
V_FrmCatalogodeProductos = False
End Sub

Private Sub optpomarca_Click()
  lim
  cmdcategoria.Visible = False
  cmdmarca.Visible = True
  cmdproveedor.Visible = False
  cmdsubcategoria.Visible = False
End Sub

Private Sub optporcategoria_Click()
  lim
  cmdcategoria.Visible = True
  cmdmarca.Visible = False
  cmdproveedor.Visible = False
  cmdsubcategoria.Visible = False
End Sub

Private Sub optporproveedor_Click()
  lim
  cmdcategoria.Visible = False
  cmdmarca.Visible = False
  cmdproveedor.Visible = True
  cmdsubcategoria.Visible = False
End Sub

Private Sub optporsubcategoria_Click()
  lim
  cmdcategoria.Visible = False
  cmdmarca.Visible = False
  cmdproveedor.Visible = False
  cmdsubcategoria.Visible = True
End Sub

Private Sub opttodos_Click()
  lim
  cmdcategoria.Visible = False
  cmdmarca.Visible = False
  cmdproveedor.Visible = False
  cmdsubcategoria.Visible = False
End Sub
