VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Begin VB.MDIForm MDIPrincipal 
   BackColor       =   &H8000000C&
   Caption         =   "SISTEMA DE VENTAS - SYSTEMIS"
   ClientHeight    =   3975
   ClientLeft      =   165
   ClientTop       =   855
   ClientWidth     =   10005
   Icon            =   "MDIPrincipal.frx":0000
   LinkTopic       =   "MDIForm1"
   StartUpPosition =   3  'Windows Default
   WindowState     =   2  'Maximized
   Begin VB.PictureBox Picture1 
      Align           =   1  'Align Top
      Height          =   1575
      Left            =   0
      ScaleHeight     =   1515
      ScaleWidth      =   9945
      TabIndex        =   0
      Top             =   0
      Width           =   10005
      Begin VB.Timer Timer1 
         Interval        =   50
         Left            =   3600
         Top             =   1080
      End
      Begin MSComDlg.CommonDialog CommonDialog1 
         Left            =   2520
         Top             =   0
         _ExtentX        =   847
         _ExtentY        =   847
         _Version        =   393216
      End
      Begin MSComctlLib.ImageList imgMenu 
         Left            =   3600
         Top             =   120
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   11
         ImageHeight     =   10
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   41
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":030A
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":04C4
               Key             =   ""
            EndProperty
            BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":07BA
               Key             =   ""
            EndProperty
            BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":0910
               Key             =   ""
            EndProperty
            BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":0BCA
               Key             =   ""
            EndProperty
            BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":0F1C
               Key             =   ""
            EndProperty
            BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":114E
               Key             =   ""
            EndProperty
            BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":15D8
               Key             =   ""
            EndProperty
            BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":1892
               Key             =   ""
            EndProperty
            BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":1BF4
               Key             =   ""
            EndProperty
            BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":1E86
               Key             =   ""
            EndProperty
            BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":2280
               Key             =   ""
            EndProperty
            BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":248A
               Key             =   ""
            EndProperty
            BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":2784
               Key             =   ""
            EndProperty
            BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":29B6
               Key             =   ""
            EndProperty
            BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":2CD8
               Key             =   ""
            EndProperty
            BeginProperty ListImage17 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":2DDA
               Key             =   ""
            EndProperty
            BeginProperty ListImage18 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":30FC
               Key             =   ""
            EndProperty
            BeginProperty ListImage19 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":32B6
               Key             =   ""
            EndProperty
            BeginProperty ListImage20 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":34DC
               Key             =   ""
            EndProperty
            BeginProperty ListImage21 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":35CE
               Key             =   ""
            EndProperty
            BeginProperty ListImage22 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":3888
               Key             =   ""
            EndProperty
            BeginProperty ListImage23 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":3B16
               Key             =   ""
            EndProperty
            BeginProperty ListImage24 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":41E0
               Key             =   ""
            EndProperty
            BeginProperty ListImage25 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":448A
               Key             =   ""
            EndProperty
            BeginProperty ListImage26 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":485C
               Key             =   ""
            EndProperty
            BeginProperty ListImage27 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":4936
               Key             =   ""
            EndProperty
            BeginProperty ListImage28 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":4E68
               Key             =   ""
            EndProperty
            BeginProperty ListImage29 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":539A
               Key             =   ""
            EndProperty
            BeginProperty ListImage30 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":574C
               Key             =   ""
            EndProperty
            BeginProperty ListImage31 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":5956
               Key             =   ""
            EndProperty
            BeginProperty ListImage32 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":5B58
               Key             =   ""
            EndProperty
            BeginProperty ListImage33 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":5E7A
               Key             =   ""
            EndProperty
            BeginProperty ListImage34 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":60A0
               Key             =   ""
            EndProperty
            BeginProperty ListImage35 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":635A
               Key             =   ""
            EndProperty
            BeginProperty ListImage36 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":688C
               Key             =   ""
            EndProperty
            BeginProperty ListImage37 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":6B1E
               Key             =   ""
            EndProperty
            BeginProperty ListImage38 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":6FA8
               Key             =   ""
            EndProperty
            BeginProperty ListImage39 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":732A
               Key             =   ""
            EndProperty
            BeginProperty ListImage40 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":75B8
               Key             =   ""
            EndProperty
            BeginProperty ListImage41 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":7AEA
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin MSComctlLib.ImageList ImageList1 
         Left            =   4320
         Top             =   120
         _ExtentX        =   1005
         _ExtentY        =   1005
         BackColor       =   -2147483643
         ImageWidth      =   16
         ImageHeight     =   16
         MaskColor       =   12632256
         _Version        =   393216
         BeginProperty Images {2C247F25-8591-11D1-B16A-00C0F0283628} 
            NumListImages   =   32
            BeginProperty ListImage1 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":801C
               Key             =   ""
            EndProperty
            BeginProperty ListImage2 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":8172
               Key             =   "configurar"
            EndProperty
            BeginProperty ListImage3 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":8704
               Key             =   ""
            EndProperty
            BeginProperty ListImage4 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":8C36
               Key             =   ""
            EndProperty
            BeginProperty ListImage5 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":8EF0
               Key             =   ""
            EndProperty
            BeginProperty ListImage6 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":92EA
               Key             =   ""
            EndProperty
            BeginProperty ListImage7 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":96E4
               Key             =   ""
            EndProperty
            BeginProperty ListImage8 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":999E
               Key             =   ""
            EndProperty
            BeginProperty ListImage9 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":9B7C
               Key             =   ""
            EndProperty
            BeginProperty ListImage10 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":9D5A
               Key             =   "programacionpresupuestal"
            EndProperty
            BeginProperty ListImage11 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":9F8C
               Key             =   "saldos"
            EndProperty
            BeginProperty ListImage12 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":A1B2
               Key             =   "reportes"
            EndProperty
            BeginProperty ListImage13 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":A4D4
               Key             =   "salir"
            EndProperty
            BeginProperty ListImage14 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":A706
               Key             =   ""
            EndProperty
            BeginProperty ListImage15 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":A808
               Key             =   ""
            EndProperty
            BeginProperty ListImage16 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":AA3A
               Key             =   ""
            EndProperty
            BeginProperty ListImage17 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":ACF4
               Key             =   ""
            EndProperty
            BeginProperty ListImage18 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":AF9E
               Key             =   "cadenadegasto"
            EndProperty
            BeginProperty ListImage19 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":B258
               Key             =   ""
            EndProperty
            BeginProperty ListImage20 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":B5BA
               Key             =   ""
            EndProperty
            BeginProperty ListImage21 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":B874
               Key             =   ""
            EndProperty
            BeginProperty ListImage22 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":BB2E
               Key             =   ""
            EndProperty
            BeginProperty ListImage23 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":BDE8
               Key             =   ""
            EndProperty
            BeginProperty ListImage24 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":C092
               Key             =   ""
            EndProperty
            BeginProperty ListImage25 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":C34C
               Key             =   ""
            EndProperty
            BeginProperty ListImage26 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":C506
               Key             =   ""
            EndProperty
            BeginProperty ListImage27 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":C6C0
               Key             =   ""
            EndProperty
            BeginProperty ListImage28 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":C91A
               Key             =   ""
            EndProperty
            BeginProperty ListImage29 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":CA68
               Key             =   ""
            EndProperty
            BeginProperty ListImage30 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":CB62
               Key             =   ""
            EndProperty
            BeginProperty ListImage31 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":CCB0
               Key             =   ""
            EndProperty
            BeginProperty ListImage32 {2C247F27-8591-11D1-B16A-00C0F0283628} 
               Picture         =   "MDIPrincipal.frx":CDAA
               Key             =   ""
            EndProperty
         EndProperty
      End
      Begin VB.Image Image1 
         Height          =   1815
         Left            =   0
         Picture         =   "MDIPrincipal.frx":CEDC
         Stretch         =   -1  'True
         Top             =   0
         Width           =   2415
      End
   End
   Begin VB.Menu BtRegistar 
      Caption         =   "Registrar"
      Begin VB.Menu BtDueño 
         Caption         =   "Clientes"
      End
      Begin VB.Menu BtMscota 
         Caption         =   "Mascotas"
         Enabled         =   0   'False
         Visible         =   0   'False
      End
      Begin VB.Menu DDDDD 
         Caption         =   "-"
      End
      Begin VB.Menu mnuproductos 
         Caption         =   "Productos"
      End
   End
   Begin VB.Menu mnuventas 
      Caption         =   "Ventas"
      Begin VB.Menu mnuacturacion 
         Caption         =   "Venta Directa"
      End
      Begin VB.Menu YYYYYYYYYYYYYYYYYYYYYYY 
         Caption         =   "-"
      End
      Begin VB.Menu mnupagos 
         Caption         =   "Pagos de Créditos"
      End
      Begin VB.Menu FHFGHFHG 
         Caption         =   "-"
      End
      Begin VB.Menu mnubuscardocumento 
         Caption         =   "Buscar Documento"
      End
      Begin VB.Menu mnucuentacorriente 
         Caption         =   "Cuenta Corriente"
      End
   End
   Begin VB.Menu mnualmacen 
      Caption         =   "Almacén"
      Begin VB.Menu mnunotadeingreso 
         Caption         =   "Nota de Ingreso"
      End
      Begin VB.Menu dgdggff 
         Caption         =   "-"
      End
      Begin VB.Menu mnunotadesalida 
         Caption         =   "Nota de Salida"
      End
      Begin VB.Menu FGHFGHGFH 
         Caption         =   "-"
      End
      Begin VB.Menu mnukardex 
         Caption         =   "Kardex"
      End
   End
   Begin VB.Menu BtMantenimiento 
      Caption         =   "Mantenimiento -  Actualizacion"
      Begin VB.Menu mnuprofesion 
         Caption         =   "Profesión"
      End
      Begin VB.Menu mnudistrito 
         Caption         =   "Distrito"
      End
      Begin VB.Menu mnucargos 
         Caption         =   "Cargos"
      End
      Begin VB.Menu mnuproveedores 
         Caption         =   "Proveedores"
      End
      Begin VB.Menu mnumarcas 
         Caption         =   "Editorial"
      End
      Begin VB.Menu mnucategorias 
         Caption         =   "Categorías"
      End
      Begin VB.Menu mnusubcategorias 
         Caption         =   "Sub-Categorías"
      End
      Begin VB.Menu mnumotivo 
         Caption         =   "Motivo"
      End
      Begin VB.Menu SDGDFGDFGDFG 
         Caption         =   "-"
      End
      Begin VB.Menu mnuproveedorporproducto 
         Caption         =   "Producto Por Proveedor"
      End
      Begin VB.Menu mnudocumentos 
         Caption         =   "Documentos"
      End
      Begin VB.Menu sdfsdsds 
         Caption         =   "-"
      End
      Begin VB.Menu mnupromotores 
         Caption         =   "Promotores"
         Visible         =   0   'False
      End
      Begin VB.Menu mnucomisiones 
         Caption         =   "Comisiones"
         Visible         =   0   'False
      End
   End
   Begin VB.Menu BtInformes 
      Caption         =   "Informes"
      Begin VB.Menu BtEstadisticaClienteDistrito 
         Caption         =   "Estadisticas Clientes por Distrito"
      End
      Begin VB.Menu SSDFFSF 
         Caption         =   "-"
      End
      Begin VB.Menu mnuListadeclientes 
         Caption         =   "Lista de Clientes"
      End
      Begin VB.Menu hhhhhhhhhhhhhhhh 
         Caption         =   "-"
      End
      Begin VB.Menu mnucatalogodeproductos 
         Caption         =   "Catálogo de Productos"
      End
      Begin VB.Menu mnukardexdealmacen 
         Caption         =   "Kardex de Almacén"
      End
      Begin VB.Menu mnuregistrodecompras 
         Caption         =   "Registro de Compras"
      End
      Begin VB.Menu mnuregistrodeventas 
         Caption         =   "Registro de Ventas"
      End
      Begin VB.Menu mnucuentasporcobrarclientes 
         Caption         =   "Cuentas Por Cobrar (Clientes)"
      End
      Begin VB.Menu mnuventasporpromotor 
         Caption         =   "Ventas Por Promotor"
         Visible         =   0   'False
      End
   End
   Begin VB.Menu BtUtilitario 
      Caption         =   "Utilitario"
      Begin VB.Menu mnuseguridad 
         Caption         =   "Seguridad"
         Begin VB.Menu BtBackup 
            Caption         =   "Backup"
         End
         Begin VB.Menu mnurestor 
            Caption         =   "Restaurar "
         End
         Begin VB.Menu mnuregistrodeusuario 
            Caption         =   "Registro de Usuarios"
         End
         Begin VB.Menu adasdsadd 
            Caption         =   "-"
         End
         Begin VB.Menu SSDSSFDSF 
            Caption         =   "Tablas"
            Begin VB.Menu mnulimpiezadetablas 
               Caption         =   "Limpieza de Tablas"
            End
         End
      End
      Begin VB.Menu JJJJJJJJJJJJ 
         Caption         =   "-"
      End
      Begin VB.Menu mnuempresa 
         Caption         =   "Empresa"
      End
      Begin VB.Menu BtCalculadora 
         Caption         =   "Calculadora"
      End
      Begin VB.Menu BtModificacionPassword 
         Caption         =   "Modificacion de Password"
      End
      Begin VB.Menu mnuimagndefondo 
         Caption         =   "Imagen de Fondo"
      End
      Begin VB.Menu kkkkkkkkkkkkkkkkkkk 
         Caption         =   "-"
      End
      Begin VB.Menu mnuigv 
         Caption         =   "I.G.V "
      End
      Begin VB.Menu mnuseriess 
         Caption         =   "Series"
      End
      Begin VB.Menu mnuinteres 
         Caption         =   "Interés de Crédito"
      End
      Begin VB.Menu mnumora 
         Caption         =   "Mora de Crédito"
      End
      Begin VB.Menu gfhfghfghfgh 
         Caption         =   "-"
      End
      Begin VB.Menu BtAyuda 
         Caption         =   "Ayuda"
         Shortcut        =   {F1}
      End
   End
   Begin VB.Menu SSSSSSSSSSSSS 
      Caption         =   ""
      Enabled         =   0   'False
   End
   Begin VB.Menu DDDDDDDDDDDDDDDD 
      Caption         =   ""
      Enabled         =   0   'False
   End
   Begin VB.Menu FFFFFFFFFFFFFFFFF 
      Caption         =   ""
      Enabled         =   0   'False
   End
   Begin VB.Menu GGGGGGGGGGGGGGGGGGG 
      Caption         =   ""
      Enabled         =   0   'False
   End
   Begin VB.Menu FSDSSSD 
      Caption         =   ""
   End
   Begin VB.Menu HHHGHGHGHGH 
      Caption         =   ""
   End
   Begin VB.Menu KJHKJHKJHKJHKJHK 
      Caption         =   ""
   End
   Begin VB.Menu RRRRRRRRRRRRRRRRRRRRRR 
      Caption         =   ""
      Enabled         =   0   'False
   End
   Begin VB.Menu BtSalir 
      Caption         =   "Salir"
   End
End
Attribute VB_Name = "MDIPrincipal"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Compare Text
Private Declare Function FindWindow Lib "user32" Alias "FindWindowA" (ByVal lpszClassName As String, ByVal lpszWindow As String) As Long
Private Declare Function GM Lib "user32" Alias "GetMenu" (ByVal hwnd As Long) As Long
Private Declare Function GSM Lib "user32" Alias "GetSubMenu" (ByVal hMenu As Long, ByVal nPos As Long) As Long
Private Declare Function SMIB Lib "user32" Alias "SetMenuItemBitmaps" (ByVal hMenu As Long, ByVal nPosition As Long, ByVal wFlags As Long, ByVal hBitmapUnchecked As Long, ByVal hBitmapChecked As Long) As Long
Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
Dim letrero1  As String
Dim letrero2 As String
Dim puchtit As String
Dim ultimo1 As Double
Dim ultimo2 As Double

Private Property Let IconoEnMenu(ByRef mdi As Object)
  SMIB GSM(GM(mdi.hwnd), 0), 0, 1024, imgMenu.ListImages(3).Picture, 0 'MENU CLIENTES
  SMIB GSM(GM(mdi.hwnd), 0), 2, 1024, imgMenu.ListImages(7).Picture, 0 'MENU PRODUCTOS
  SMIB GSM(GM(mdi.hwnd), 1), 0, 1024, imgMenu.ListImages(34).Picture, 0 'MENU VENTA DIRECTA
  SMIB GSM(GM(mdi.hwnd), 1), 2, 1024, ImageList1.ListImages(14).Picture, 0 'MENU PAGO DE CREDITOS
  SMIB GSM(GM(mdi.hwnd), 1), 4, 1024, imgMenu.ListImages(22).Picture, 0 'MENU BUSCAR DOCUMENTOS
  SMIB GSM(GM(mdi.hwnd), 1), 5, 1024, imgMenu.ListImages(36).Picture, 0 'MENU CUENTA CORRIENTE
  SMIB GSM(GM(mdi.hwnd), 2), 0, 1024, ImageList1.ListImages(8).Picture, 0 'MENU NOTA DE INGRESO
  SMIB GSM(GM(mdi.hwnd), 2), 2, 1024, ImageList1.ListImages(9).Picture, 0 'MENU NOTA DE SALIDA
  SMIB GSM(GM(mdi.hwnd), 2), 4, 1024, imgMenu.ListImages(4).Picture, 0 'MENU KARDEX
  
  SMIB GSM(GM(mdi.hwnd), 3), 0, 1024, ImageList1.ListImages(26).Picture, 0 'MENU PROFESION
  SMIB GSM(GM(mdi.hwnd), 3), 1, 1024, ImageList1.ListImages(25).Picture, 0 'MENU DISTRITO
  SMIB GSM(GM(mdi.hwnd), 3), 2, 1024, imgMenu.ListImages(23).Picture, 0 'MENU RAZA
  SMIB GSM(GM(mdi.hwnd), 3), 3, 1024, ImageList1.ListImages(6).Picture, 0 'MENU SERVICIOS
  SMIB GSM(GM(mdi.hwnd), 3), 4, 1024, ImageList1.ListImages(21).Picture, 0 'MENU CARGOS
  SMIB GSM(GM(mdi.hwnd), 3), 5, 1024, ImageList1.ListImages(24).Picture, 0 'MENU PROVEEDORES
  SMIB GSM(GM(mdi.hwnd), 3), 6, 1024, ImageList1.ListImages(20).Picture, 0 'MENU MARCAS
  SMIB GSM(GM(mdi.hwnd), 3), 7, 1024, ImageList1.ListImages(22).Picture, 0 'MENU CATEGORIAS
  SMIB GSM(GM(mdi.hwnd), 3), 8, 1024, imgMenu.ListImages(31).Picture, 0 'MENU SUBCATEGORIAS
  SMIB GSM(GM(mdi.hwnd), 3), 9, 1024, ImageList1.ListImages(7).Picture, 0 'MENU MOTIVO
  SMIB GSM(GM(mdi.hwnd), 3), 10, 1024, ImageList1.ListImages(5).Picture, 0 'MENU PRODUCTO X PROVEEDOR
  SMIB GSM(GM(mdi.hwnd), 3), 11, 1024, imgMenu.ListImages(15).Picture, 0 'MENU DOCUMENTOS
  SMIB GSM(GM(mdi.hwnd), 3), 12, 1024, imgMenu.ListImages(27).Picture, 0 'PROMOTORES
  SMIB GSM(GM(mdi.hwnd), 3), 13, 1024, imgMenu.ListImages(28).Picture, 0 'COMISIONES
  
  For I = 0 To 8
    SMIB GSM(GM(mdi.hwnd), 4), I, 1024, imgMenu.ListImages(27).Picture, 0 'TODOS LOS INFORMES
  Next
  SMIB GSM(GM(mdi.hwnd), 5), 0, 1024, imgMenu.ListImages(21).Picture, 0 'MENU SEGURIDAD
  SMIB GSM(GSM(GM(mdi.hwnd), 5), 0), 0, 1024, imgMenu.ListImages(18).Picture, 0 'MENU BACKUP
  SMIB GSM(GSM(GM(mdi.hwnd), 5), 0), 1, 1024, imgMenu.ListImages(14).Picture, 0 'MENU RESTAURAR
  SMIB GSM(GSM(GM(mdi.hwnd), 5), 0), 2, 1024, imgMenu.ListImages(17).Picture, 0 'MENU REGISTRO DE USUARIOS
  SMIB GSM(GSM(GM(mdi.hwnd), 5), 0), 4, 1024, ImageList1.ListImages(4).Picture, 0 'MENU TABLAS
  SMIB GSM(GSM(GSM(GM(mdi.hwnd), 5), 0), 4), 0, 1024, imgMenu.ListImages(38).Picture, 0 'LIMPIEZA DE TABLAS
  SMIB GSM(GM(mdi.hwnd), 5), 2, 1024, ImageList1.ListImages(27).Picture, 0 'MENU MENU EMPRESA
  SMIB GSM(GM(mdi.hwnd), 5), 3, 1024, imgMenu.ListImages(30).Picture, 0 'MENU MENU EMPRESA
  SMIB GSM(GM(mdi.hwnd), 5), 4, 1024, imgMenu.ListImages(19).Picture, 0 'MENU MODIFICACION DE PASSWORD
  SMIB GSM(GM(mdi.hwnd), 5), 5, 1024, imgMenu.ListImages(39).Picture, 0 'MENU IMAGEN DE FONDO
  SMIB GSM(GM(mdi.hwnd), 5), 7, 1024, ImageList1.ListImages(29).Picture, 0 'MENU IGV
  SMIB GSM(GM(mdi.hwnd), 5), 8, 1024, ImageList1.ListImages(30).Picture, 0 'MENU SERIES
  SMIB GSM(GM(mdi.hwnd), 5), 9, 1024, ImageList1.ListImages(31).Picture, 0 'MENU INTERES
  SMIB GSM(GM(mdi.hwnd), 5), 10, 1024, ImageList1.ListImages(32).Picture, 0 'MENU MORA
  SMIB GSM(GM(mdi.hwnd), 5), 12, 1024, imgMenu.ListImages(16).Picture, 0 'MENU AYUDA
  
End Property

Private Sub MDIForm_Load()
Screen.MousePointer = vbHourglass
  mnuseguridad.Enabled = False
  If TIPO = "ADMINISTRADOR" Then
    mnuseguridad.Enabled = True
  End If
  IconoEnMenu = MDIPrincipal
  puchtit = " | SISTEMA DE VENTAS - SYSTEMIS | "
  letrero1 = " `·.,¸¸,.·´¯`·.,¸¸,.·´¯`·.,¸¸,.·´¯ "
  letrero2 = " ¯`·.,¸¸,.·´¯`·.,¸¸,.·´¯`·.,¸¸,.·´ "
  ultimo1 = Len(letrero1)
  ultimo2 = Len(letrero2)
End Sub

Private Sub BtAyuda_Click()
On Local Error GoTo L
'        If FindWindow(vbNullString, "manualsystemis - Microsoft Word") Then
'            MsgBox "La Ayuda Ya Esta En Uso...!", 64
'            Exit Sub
'        End If
' Call ShellExecute(hwnd, "OPEN", App.Path + "\manualsystemis.doc", "", "", 1)
 Call ShellExecute(hwnd, "OPEN", App.Path + "\manualsystemis.pdf", "", "", 1)
Exit Sub
L:
MsgBox Err.Description, vbInformation
End Sub

Private Sub BtBackup_Click()
  frmCopiaDeSeguridad.Show 1
End Sub
Private Sub BtBlockNotas_Click()
On Error GoTo L
        If FindWindow(vbNullString, "Serie - Bloc de notas") Then
            MsgBox "La Ventana Serie Ya Esta En Uso...!", 64
            Exit Sub
        End If
        Call Shell("notepad " + App.Path + "\serie.txt", vbNormalFocus)
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub
Private Sub BtCalculadora_Click()
On Local Error GoTo L
        If FindWindow(vbNullString, "calculadora") Then
            MsgBox "La Calculadora Ya Esta En Uso...!", 64
            Exit Sub
        End If
        Call Shell("calc", vbNormalFocus)
  Exit Sub
L:
  MsgBox Err.Description, vbCritical
End Sub

Private Sub BtCitas_Click()
frmCitas.Show 1
End Sub

Private Sub BtDueño_Click()
  frmRegistroDueño.Show 1
End Sub

Private Sub BtEstadisticaClienteDistrito_Click()
Frmestadiscliexdist.Show 1
End Sub

Private Sub BtEstadisticasIngresos_Click()
FrmEstadisticaIngresos.Show 1
End Sub

Private Sub BtExamenesComplemetarios_Click()
FrmExamenesCom.Show 1
End Sub

Private Sub BtHojaActualizada_Click()
    FrmHojaActualizada.Show 1
End Sub

Private Sub BtHojaClinica_Click()
frmEmisionHC.Show 1
End Sub

Private Sub BtInformeDeudaCredito_Click()
FrmDeudas.Show 1
End Sub

Private Sub BtListaCitas_Click()
FrmInformeListaCitas.Show 1
End Sub

Private Sub BtListaMascotaAVacunar_Click()
FRMlisademascotasavacuna.Show 1
End Sub

Private Sub BtModificacionPassword_Click()
FrmModiPass.Show 1
End Sub

Private Sub BtMscota_Click()
  V_MASCOTA = True
  frmRegistroMascota.Show 1
End Sub

Private Sub BtPago_Click()
FrmRegistrarPago.Show 1
End Sub

Private Sub BtReporteEnfermedades_Click()
V_INFORMDEENFERMEDEDAS = True
FrmReportes.Show 1
End Sub

Private Sub BtReporteIngreso_Click()
FrmIngresos.Show 1
End Sub

Private Sub BtSalir_Click()
  Unload Me
End Sub

Private Sub MDIForm_Activate()
Screen.MousePointer = vbDefault
End Sub

Private Sub MDIForm_QueryUnload(Cancel As Integer, UnloadMode As Integer)
  Dim bMsg As Long
  bMsg = MsgBox("Desea Salir del Sistema......?", vbQuestion + vbYesNo + vbDefaultButton2, "Cerrar Ventana")
  If bMsg = vbNo Then
    Cancel = 1
    Exit Sub
  End If
  Call EliminarTemporales(App.Path)
End Sub

Friend Sub EliminarTemporales(Ruta As String)
    On Error GoTo ERROR
    If Trim(Dir$(Ruta & "\*.tmp")) <> "" Then
    Dim Cad As String
    Cad = Trim(Ruta) & Trim("\*.tmp")
        Kill (Cad)
    End If
    Exit Sub
ERROR:
End Sub

Private Sub MDIForm_Resize()
Picture1.Height = Height

End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
  End
End Sub

Private Sub mnuacturacion_Click()
FrmFacturacion.Show 1
End Sub

Private Sub mnubuscardocumento_Click()
Form1.Show 1
End Sub

Private Sub mnucancelaciondedeudas_Click()
Frmcancelacion.Show 1
End Sub

Private Sub mnucargos_Click()
FrmCargos.Show 1
End Sub

Private Sub mnucatalogodeproductos_Click()
FrmCatalogodeProductos.Show 1
End Sub

Private Sub mnucategorias_Click()
FrmCategorias.Show 1
End Sub

Private Sub mnucomisiones_Click()
FrmComosiones.Show 1
End Sub

Private Sub mnucuentacorriente_Click()
FrmCuentaCorriente.Show 1
End Sub

Private Sub mnucuentasporcobrarclientes_Click()
V_CUENTASPORCOBRARCLIENTES = True
FrmReportes.Show 1
End Sub

Private Sub mnudistrito_Click()
frmdistrito.Show 1
End Sub

Private Sub mnuDocumentos_Click()
FrmDocumentos.Show 1
End Sub

Private Sub mnuempresa_Click()
FrmEmpresa.Show 1
End Sub

Private Sub mnuigv_Click()
FrmIGV.Show 1
End Sub

Private Sub mnuimagndefondo_Click()
On Local Error GoTo L
  CommonDialog1.DialogTitle = "Selecionar Una Imagen"
  CommonDialog1.Filter = "Imagen JPG|*.jpg|Imagen GIF|*.gif|IMAGEN BMP|*.bmp|Imagen JPEG|*.jpeg"
  CommonDialog1.ShowOpen
  Dim XC As String
  XC = CommonDialog1.FileName
  If XC <> "" Then
    Image1.Picture = LoadPicture(XC)
  End If
  Exit Sub
L:
MsgBox Err.Description, vbCritical
End Sub

Private Sub mnuinteres_Click()
FrmInteres.Show 1
End Sub

Private Sub mnukardex_Click()
FrmKA.Show 1
End Sub

Private Sub mnukardexdealmacen_Click()
FrmKardex.Show 1
End Sub

Private Sub mnulimpiezadetablas_Click()
  If MsgBox("¿Desea Eliminar Los Registros de las Tablas del Sistema...?", vbYesNo + vbDefaultButton2 + vbQuestion) = vbYes Then
    Screen.MousePointer = vbHourglass
    On Error GoTo L
    CopyFile IIf(Right(App.Path, 1) = "\", App.Path, App.Path + "\") + "mela.mdb", "C:\COPIAmela.mdb", 0
    cn.Execute "DELETE * FROM [DUEÑO]"
    cn.Execute "DELETE * FROM DETALLEVENTA"
    cn.Execute "DELETE * FROM VENTAS"
    cn.Execute "DELETE * FROM DETALLEKARDEX"
    cn.Execute "DELETE * FROM KARDEX"
    cn.Execute "DELETE * FROM ProveedorXProducto"
    cn.Execute "DELETE * FROM PRODUCTOS"
    cn.Execute "DELETE * FROM MARCAS"
    cn.Execute "DELETE * FROM CATEGORIAS"
    cn.Execute "DELETE * FROM SUBCATEGORIAS"
    cn.Execute "DELETE * FROM PROVEEDORES"
    cn.Execute "DELETE * FROM tb_pagos"
    cn.Execute "DELETE * FROM fechaxcuotas"
    cn.Execute "DELETE * FROM tb_deuda"
    cn.Execute "DELETE * FROM comisiones"
    cn.Execute "DELETE * FROM suscripcion"
    cn.Execute "DELETE * FROM promotores"
    MsgBox "Por Seguridad Se Ha Creado Una Copia en la Unidad 'C' ...!", vbInformation
    Screen.MousePointer = vbDefault
  End If
  Exit Sub
L:
    Screen.MousePointer = vbDefault
  MsgBox Err.Description, vbCritical
End Sub

Private Sub mnuListadeclientes_Click()
V_CLIENE = True
FrmReportes.Show 1
End Sub

Private Sub mnulistadeexamenenescomplementarios_Click()
V_EXAMEN = True
FrmReportes.Show 1
End Sub

Private Sub mnulistadeservicios_Click()
V_SERVICIOS = True
FrmReportes.Show 1
End Sub

Private Sub mnulistamorosos_Click()
V_MOROS = 1
FrmReportes.Show 1
End Sub

Private Sub mnumarcas_Click()
FrmMarcas.Show 1
End Sub

Private Sub mnumora_Click()
FrmMora.Show 1
End Sub

Private Sub mnumotivo_Click()
FrmMotivo.Show 1
End Sub

Private Sub mnunotadeingreso_Click()
FrmNotaIngreso.Show 1
End Sub

Private Sub mnunotadesalida_Click()
FrmNotaSalida.Show 1
End Sub

Private Sub mnupagos_Click()
FrmPagos.Show 1
End Sub

Private Sub mnuproductos_Click()
FrmProductos.Show 1
End Sub

Private Sub mnuprofesion_Click()
frmprofesion.Show 1
End Sub


Private Sub mnupromotores_Click()
FrmPromotores.Show 1
End Sub

Private Sub mnuproveedores_Click()
FrmProveedores.Show 1
End Sub

Private Sub mnuproveedorporproducto_Click()
FrmProductoPorProveedor.Show 1
End Sub

Private Sub mnuraza_Click()
Frmraza.Show 1
End Sub


Private Sub mnuregistrodecompras_Click()
FrmRegCompras.Show 1
End Sub

Private Sub mnuregistrodeusuario_Click()
FrmRegUsuarios.Show 1
End Sub

Private Sub mnuregistrodeventas_Click()
FrmRegVentas.Show 1
End Sub

Private Sub mnurestor_Click()
frmRestaurarBaseDeDatos.Show 1
End Sub

Private Sub mnuseriess_Click()
FrmSeries.Show 1
End Sub

Private Sub mnuservicios_Click()
Frmservicios.Show 1
End Sub

Private Sub mnuventadirecta_Click()

End Sub

Private Sub mnusubcategorias_Click()
FrmSubCategoria.Show 1
End Sub

Private Sub mnuventasporpromotor_Click()
frmventasporpromotor.Show 1
End Sub

Private Sub Picture1_Resize()
Image1.Width = Picture1.ScaleWidth
Image1.Height = Picture1.ScaleHeight
End Sub

Private Sub Timer1_Timer()
  aux1 = Mid(letrero1, ultimo1, 1)
  letrero1 = aux1 + Mid(letrero1, 1, ultimo1)
  aux2 = Mid(letrero2, ultimo2, 1)
  letrero2 = aux2 + Mid(letrero2, 1, ultimo2)
  Caption = "][" + letrero2 + puchtit + letrero1 + "]["
End Sub
