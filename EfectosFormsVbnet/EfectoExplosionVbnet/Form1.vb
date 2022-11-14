Public Class Form1
    Private Declare Function AnimateWindow Lib "user32" (
    ByVal hwnd As Long,
    ByVal dwTime As Long,
    ByVal dwFlags As Long) As Long
    'importa librerias de windows
    Sub EfectoExplosion(ByRef frmFormulario As Form)
        Dim lngA As Long
        Dim Pausa As Long
        With frmFormulario
            .Width = 0
            .Height = 0
            .Show()
            For lngA = 0 To 6000 Step 150
                For Pausa = 1 To 500
                    'Si es muy rápido, incrementar esta cantidad
                Next Pausa
                .SetDesktopBounds((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - .Width) / 2, (System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - .Height) / 2.5, lngA / 5, lngA / 10)
            Next lngA
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EfectoExplosion(Me)
        ' Me.Opacity = 0.9
        Button1.BackColor = Color.FromArgb(255, 255, 255, 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EfectoExplosion(Me)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Const AW_ACTIVATE = &H20000 'Activa la ventana cuando finaliza el efecto  
        Const AW_BLEND = &H80000
        Me.Hide()
        Dim ret As Long
        ret = AnimateWindow(Me.Handle, 250, AW_BLEND Or AW_ACTIVATE)
        Me.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Const AW_ACTIVATE = &H20000
        Const AW_HOR_POSITIVE = &O1
        'constante para animacion desde costado ademas de la constante AW_ACTIVATE considerada
        'Private Const AW_HOR_NEGATIVE = &H2 ' Derecha a izquierda
        'Private Const AW_VER_POSITIVE = &H4 ' Arriba abajo
        'Private Const AW_VER_NEGATIVE = &H8 ' Abajo hacia arriba
        'Private Const AW_HOR_POSITIVE = &O1 ' Izquierda a derecha
        Me.Hide()
        Dim ret As Long
        ret = AnimateWindow(Me.Handle, 100, AW_HOR_POSITIVE Or AW_ACTIVATE)
        Me.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const AW_HOR_POSITIVE = &O1
        Const AW_HOR_NEGATIVE = &H2
        Const AW_VER_POSITIVE = &H4
        Const AW_VER_NEGATIVE = &H8
        Const AW_ACTIVATE = &H20000
        Me.Hide()
        Dim ret As Long
        ret = AnimateWindow(Me.Handle, 200, AW_HOR_POSITIVE Or AW_VER_POSITIVE Or AW_ACTIVATE)
        Me.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Const AW_HOR_POSITIVE = &O1
        Const AW_HOR_NEGATIVE = &H2
        Const AW_VER_POSITIVE = &H4
        Const AW_VER_NEGATIVE = &H8
        Const AW_ACTIVATE = &H20000
        Me.Hide()
        Dim Flags As Long
        ' Combinación de valores para los flags de la animación  
        Flags = AW_HOR_NEGATIVE Or AW_VER_POSITIVE Or AW_ACTIVATE
        AnimateWindow(Me.Handle, 200, Flags)
        Me.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Const AW_HOR_POSITIVE = &O1
        Const AW_HOR_NEGATIVE = &H2
        Const AW_VER_POSITIVE = &H4
        Const AW_VER_NEGATIVE = &H8
        Const AW_CENTER = &H10
        Const AW_ACTIVATE = &H20000
        Me.Hide()
        Dim Flags As Long
        Flags = AW_CENTER Or AW_ACTIVATE
        AnimateWindow(Me.Handle, 100, Flags)
        Me.Show()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Const AW_CENTER = &H10
        Const AW_ACTIVATE = &H20000
        AnimateWindow(Form2.Handle, 300, AW_CENTER Or AW_ACTIVATE)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Const AW_HIDE = &H10000
        Const AW_BLEND = &H80000
        AnimateWindow(Me.Handle, 350, AW_HIDE Or AW_BLEND)
    End Sub
End Class
