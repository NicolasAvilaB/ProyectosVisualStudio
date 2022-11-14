Imports System.Runtime.InteropServices
Public Class Form1
    <DllImport("user32.dll")>
    Private Shared Function FindWindow(className As String, windowText As String) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hwnd As IntPtr, command As Integer) As Boolean
    End Function
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 1

    Private Sub ButtonOCULTA_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOCULTA.Click
        OCULTABARRA()
        OCULTAINICIO()

    End Sub
    Private Sub ButtonMUESTRA_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMUESTRA.Click
        MUESTRABARRA()
        MUESTRAINICIO()
    End Sub

    Public Function OCULTABARRA() As Boolean
        Dim retval = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval = ShowWindow(hwndTaskBar, SW_HIDE)
        End If
        Return retval
    End Function

    Public Function OCULTAINICIO() As Boolean
        Dim retval = False
        OCULTABARRA()
        Dim hwndStartButton = FindWindow("Button", "Start")
        If hwndStartButton <> IntPtr.Zero Then
            retval = ShowWindow(hwndStartButton, SW_HIDE)
        End If
        Return retval
    End Function

    Public Function MUESTRABARRA() As Boolean
        Dim retval2 = False
        Dim hwndTaskBar = FindWindow("Shell_TrayWnd", "")
        If hwndTaskBar <> IntPtr.Zero Then
            retval2 = ShowWindow(hwndTaskBar, SW_SHOW)
        End If
        Return retval2
    End Function

    Public Function MUESTRAINICIO() As Boolean
        Dim retval1 = False
        MUESTRABARRA()
        Dim hwndstartbutton = FindWindow("Button", "Start")
        If hwndstartbutton <> IntPtr.Zero Then
            retval1 = ShowWindow(hwndstartbutton, SW_SHOW)
        End If
        Return retval1
    End Function

    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MUESTRABARRA()
        MUESTRAINICIO()
    End Sub

End Class
