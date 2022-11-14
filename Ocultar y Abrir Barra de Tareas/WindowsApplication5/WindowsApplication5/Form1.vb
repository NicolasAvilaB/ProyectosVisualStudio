Imports System.Runtime.InteropServices
Public Class Form1
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 1
    <DllImport("user32.dll")>
    Private Shared Function FindWindow(className As String, windowText As String) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hwnd As IntPtr, command As Integer) As Boolean
    End Function
    Private Sub Ocultar_Click(sender As Object, e As EventArgs) Handles Ocultar.Click

        'Ocultar Barra
        Dim retval = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval = ShowWindow(hwndTaskBar, SW_HIDE)
        End If

        'Ocultar Inicio
        Dim retval1 = False
        Dim hwndStartButton = FindWindow("Button", "Start")
        If hwndStartButton <> IntPtr.Zero Then
            retval1 = ShowWindow(hwndStartButton, SW_HIDE)
        End If

    End Sub

    Private Sub Abrir_Click(sender As Object, e As EventArgs) Handles Abrir.Click

        'Muestre Barra
        Dim retval2 = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval2 = ShowWindow(hwndTaskBar, SW_SHOW)
        End If


        'Muestre Inicio
        Dim retval1 = False

        Dim hwndstartbutton = FindWindow("Button", "Start")
        If hwndstartbutton <> IntPtr.Zero Then
            retval1 = ShowWindow(hwndstartbutton, SW_SHOW)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Muestre Barra
        Dim retval2 = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval2 = ShowWindow(hwndTaskBar, SW_SHOW)
        End If


        'Muestre Inicio
        Dim retval1 = False

        Dim hwndstartbutton = FindWindow("Button", "Start")
        If hwndstartbutton <> IntPtr.Zero Then
            retval1 = ShowWindow(hwndstartbutton, SW_SHOW)
        End If
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
End Class
