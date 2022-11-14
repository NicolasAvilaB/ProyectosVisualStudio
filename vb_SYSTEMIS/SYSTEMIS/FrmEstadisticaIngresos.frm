VERSION 5.00
Begin VB.Form FrmEstadisticaIngresos 
   BackColor       =   &H00B0726D&
   BorderStyle     =   1  'Fixed Single
   Caption         =   "ESTADÍSTICAS DE INGRESOS"
   ClientHeight    =   2205
   ClientLeft      =   45
   ClientTop       =   435
   ClientWidth     =   4545
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
   Icon            =   "FrmEstadisticaIngresos.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2205
   ScaleWidth      =   4545
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox cmbanio 
      Height          =   315
      Left            =   840
      Sorted          =   -1  'True
      Style           =   2  'Dropdown List
      TabIndex        =   2
      Top             =   1800
      Width           =   1575
   End
   Begin VB.CommandButton CMD1 
      BackColor       =   &H80000013&
      Caption         =   "GRAFICO BARRAS"
      Height          =   1455
      Left            =   120
      Picture         =   "FrmEstadisticaIngresos.frx":030A
      Style           =   1  'Graphical
      TabIndex        =   1
      Top             =   120
      Width           =   1935
   End
   Begin VB.CommandButton CMD2 
      BackColor       =   &H80000013&
      Caption         =   "GRAFICO TARTA"
      Height          =   1455
      Left            =   2520
      Picture         =   "FrmEstadisticaIngresos.frx":5F60
      Style           =   1  'Graphical
      TabIndex        =   0
      Top             =   120
      Width           =   1935
   End
   Begin VB.Label Label6 
      AutoSize        =   -1  'True
      BackColor       =   &H80000013&
      BackStyle       =   0  'Transparent
      Caption         =   "Año:"
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
      Left            =   240
      TabIndex        =   3
      Top             =   1800
      Width           =   480
   End
End
Attribute VB_Name = "FrmEstadisticaIngresos"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Friend Function GRAFICAR() As Long
If cmbanio = "" Then
  MsgBox "Ingrese Año...!", vbInformation
  Exit Function
End If
On Local Error GoTo L
  Dim T As New ADODB.Recordset
  Dim rs As New ADODB.Recordset
  T.Open "SELECT format(Month(FechaEmision),'00'), Sum(SumaDeTotal), Year(FechaEmision) From listaingresos GROUP BY FechaEmision,format(Month(FechaEmision),'00'), Year(FechaEmision) HAVING YEAR(FechaEmision)=" + cmbanio + " order by 1", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  If T.RecordCount = 0 Then
    Set T = Nothing
    Set rs = Nothing
    MsgBox "No Registros...!", vbInformation
    Exit Function
  End If
  cn.Execute "DELETE * FROM t1"
  cn.Execute "delete from IngresoEstadistico"
  rs.Open "select It,me,inc,an from T1", cn, adOpenDynamic, adLockOptimistic
   Do While T.EOF = False
    rs.AddNew
    rs!It = T(0)
    rs!Me = MonthName(Val(T(0)))
    rs!inc = T(1)
    rs!an = T(2)
    rs.Update
    T.MoveNext
  Loop
  If T.State = adStateOpen Then T.Close
  If rs.State = adStateOpen Then rs.Close
  T.Open "SELECT It,me,sum(inc),an From T1 group by It,me,an", cn, adOpenForwardOnly, adLockReadOnly
  REFRESCAR T
  rs.Open "SELECT item,mes,ingreso,año FROM IngresoEstadistico", cn, adOpenDynamic, adLockOptimistic
  Do While T.EOF = False
    rs.AddNew
    rs!Item = T(0)
    rs!mes = T(1)
    rs!ingreso = T(2)
    rs("año") = T(3)
    rs.Update
    T.MoveNext
  Loop
  Set T = Nothing
  Set rs = Nothing
  GRAFICAR = 1
  Exit Function
L:
  MsgBox Err.Description, vbCritical
End Function

Private Sub CMD1_Click()
  V_GRAFICOINGRESS = 1
  If GRAFICAR = 1 Then
    FrmReportes.Show 1
  End If
End Sub

Private Sub CMD2_Click()
  V_GRAFICOINGRESS = 2
  If GRAFICAR = 1 Then
    FrmReportes.Show 1
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
  P_RellenaCombo "ANIOS", cmbanio
End Sub

Private Sub Form_Unload(Cancel As Integer)
  V_GRAFICOINGRESS = 0
End Sub

