VERSION 5.00
Object = "{0ECD9B60-23AA-11D0-B351-00A0C9055D8E}#6.0#0"; "MSHFLXGD.OCX"
Begin VB.Form FrmBuscarProducto 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "BUSCAR PRODUCTOS"
   ClientHeight    =   9810
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   14970
   Icon            =   "FrmBuscarProducto.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   9810
   ScaleWidth      =   14970
   StartUpPosition =   3  'Windows Default
   Begin VB.PictureBox Picture2 
      BackColor       =   &H00B0726D&
      Height          =   9855
      Left            =   0
      ScaleHeight     =   9795
      ScaleWidth      =   14940
      TabIndex        =   0
      Top             =   0
      Width           =   15000
      Begin VB.CommandButton CmdSalir 
         BackColor       =   &H80000013&
         Cancel          =   -1  'True
         Caption         =   "&SALIR"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   855
         Left            =   13320
         Picture         =   "FrmBuscarProducto.frx":030A
         Style           =   1  'Graphical
         TabIndex        =   9
         Top             =   120
         Width           =   1455
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
         TabIndex        =   4
         Top             =   120
         Value           =   -1  'True
         Width           =   1455
      End
      Begin VB.OptionButton optmarca 
         BackColor       =   &H00B0726D&
         Caption         =   "Editorial"
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
         TabIndex        =   3
         Top             =   120
         Width           =   1215
      End
      Begin VB.TextBox txtbuscar 
         DataField       =   "E-mail"
         DataMember      =   "RegistroDueño"
         DataSource      =   "DataEnvironment1"
         Height          =   315
         Left            =   6600
         TabIndex        =   2
         Top             =   120
         Width           =   6015
      End
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
         Left            =   5040
         TabIndex        =   1
         Top             =   120
         Width           =   1575
      End
      Begin MSHierarchicalFlexGridLib.MSHFlexGrid MSHFlexGrid1 
         Height          =   8535
         Left            =   120
         TabIndex        =   5
         Top             =   1080
         Width           =   14655
         _ExtentX        =   25850
         _ExtentY        =   15055
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
         TabIndex        =   8
         Top             =   120
         Width           =   2205
      End
      Begin VB.Label Label11 
         BackStyle       =   0  'Transparent
         Caption         =   "TOTAL:"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   12600
         TabIndex        =   7
         Top             =   7005
         Width           =   855
      End
      Begin VB.Label LBLTOTAL 
         Alignment       =   1  'Right Justify
         BackColor       =   &H80000012&
         BorderStyle     =   1  'Fixed Single
         Caption         =   "0"
         ForeColor       =   &H8000000E&
         Height          =   255
         Left            =   13440
         TabIndex        =   6
         Top             =   7000
         Width           =   1335
      End
   End
End
Attribute VB_Name = "FrmBuscarProducto"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub CmdSalir_Click()
Unload Me
End Sub

Private Sub Form_KeyDown(KeyCode As Integer, Shift As Integer)
If KeyCode = vbKeyEscape Then Unload Me
End Sub

Private Sub Form_Load()
Centrar_Objeto Me
x = prellenaProdutos(MSHFlexGrid1)
End Sub

Private Sub Form_Unload(Cancel As Integer)
If V_FACTURACION = True Then
x = FrmFacturacion.cmbproducto
P_RellenaCombo "PROD", FrmFacturacion.cmbproducto
FrmFacturacion.cmbproducto = x
End If
End Sub

Private Sub MSHFlexGrid1_DblClick()
  If V_FACTURACION = True Then
    With FrmFacturacion
       P_RellenaCombo "PROD", .cmbproducto
      .cmbproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
      .txtidproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
      .TXTprecio = Format$(Val(MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 12)), "###.00")
      .TXTprecio = Format$(precioPRO(.txtidproducto), "###.00")
      If FrmFacturacion.optdolares.Value = True Then
        .TXTprecio = Format$(Val(.TXTprecio) / Val(FrmFacturacion.txttipocambio), "###.00")
      End If
      .txtcantidad = "0.00"
    End With
    Unload Me
  End If
  If V_KA = True Then
      With FrmKA
      .txtdesproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 4) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 6) + " " + MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 2)
      .txtidproducto = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 1)
      .txtstock = MSHFlexGrid1.TextMatrix(MSHFlexGrid1.RowSel, 11)
      End With
    Unload Me
  End If
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
