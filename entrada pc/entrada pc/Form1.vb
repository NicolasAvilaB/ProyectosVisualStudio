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
    Private Function start_Up(ByVal bCrear As Boolean) As String

        ' clave del registro para   
        ' colocar el path del ejecutable para iniciar con windows  
        Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"

        'ProductName : el nombre del programa.  
        Dim subClave As String = Application.ProductName.ToString
        ' Mensaje para retornar el resultado  
        Dim msg As String = ""

        Try
            ' Abre la clave del usuario actual (CurrentUser) para poder extablecer el dato  
            ' si la clave CurrentVersion\Run no existe la crea  
            Dim Registro As RegistryKey = CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)

            With Registro

                .OpenSubKey(CLAVE, True)

                Select Case bCrear
                    ' Crear  
                    ''''''''''''''''''''''  
                    Case True
                        ' Escribe el path con SetValue   
                        'Valores : ProductName el nombre del programa y ExecutablePath : la ruta del exe  
                        .SetValue(subClave,
                                  Application.ExecutablePath.ToString)
                        Return "Ok .. clave añadida"
                        ' Eliminar  
                        ''''''''''''''''''''''  
                        'Elimina la entrada con DeleteValue  
                    Case False
                        If .GetValue(subClave, "").ToString <> "" Then
                            .DeleteValue(subClave) ' eliminar  
                            msg = "Ok .. clave eliminada"
                        Else

                            msg = "No se eliminó , por que el programa" &
                                   " no iniciaba con windows"
                        End If
                End Select
            End With
            ' Error  
            ''''''''''''''''''''''  
        Catch ex As Exception
            msg = ex.Message.ToString
        End Try
        'retorno  
        Return msg
    End Function
    Private Sub verlo_Click(sender As Object, e As EventArgs) Handles verlo.Click
        If (clave.Text = "") Then
            MsgBox("Campo Clave Vacio, Escriba su Contraseña", vbCritical, "Error Fatal")

        ElseIf (verlo.Text = "Ver") Then
            verlo.Text = "Ocultar"
            clave.PasswordChar = ""
            clave.Focus()
            clave.Select()
        Else
            verlo.Text = "Ver"
            clave.PasswordChar = "*"
            verlo.Enabled = True
            clave.Focus()
            clave.Select()
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        start_Up(True)
        Conexion.ConnectionString = "Database=entrada;Data Source=localhost;User Id=root;Password=root"

        Try
            Consulta("SELECT DISTINCT rut FROM usuario")
            rut.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("usuario")
            DA.Fill(dt)
            With rut
                .DataSource = dt
                .DisplayMember = "rut"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        rut.SelectedIndex = -1
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

        TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated


    End Sub

    Private Sub rut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rut.SelectedIndexChanged
        If (rut.SelectedIndex = -1) Then
            MsgBox("Error Fatal: Porfavor Rellene El Campo Consulta Para Continuar", vbCritical, "Error")

        Else
            Consulta("select usuario.nombre, usuario.apellido from usuario where rut ='" & (rut.Text) & "'")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                nombre.Text = CStr(row("nombre"))
                apellido.Text = CStr(row("apellido"))

            End If
        End If
    End Sub

    Private Sub Acepto_Click(sender As Object, e As EventArgs) Handles Acepto.Click
        If (rut.SelectedIndex = -1) Then
            MsgBox("Seleccione un Rut de Alguna Persona Registrada", vbCritical, "Error")
        ElseIf (clave.Text = "") Then
            MsgBox("Escriba la Contraseña de la Persona Registrada", vbCritical, "Error")
            clave.Focus()
            clave.Select()
        End If
        Consulta("select usuario.nombre, usuario.clave from usuario where nombre='" & (nombre.Text) & "'and clave'" & (clave.Text) & "'")

        If DS.Tables(DT.TableName).Rows.Count = 1 Then
            MsgBox("Bienvenido/a : " + nombre.Text, vbInformation, "Entrada Correcta")
            Hdesk = FindWindow("Progman", vbNullString)

            EnableWindow(CInt(Hdesk), 1)
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
            UnhookWindowsHookEx(TECLEADO) 'PARA ASEGURAR QUE NO QUEDE NADA BLOQUEADO EN EL TECLADO AL CERRAR LA APLICACION
            Me.Close()

        Else
            MsgBox("Clave Incorrecta, Verifique que la Escribio Correctamente", vbCritical, "Error")
            clave.Focus()
            clave.Select()
        End If
    End Sub

    Private Sub apagando_Click(sender As Object, e As EventArgs) Handles apagando.Click
        Process.Start("shutdown.exe", " -s -t 0 -f")
    End Sub

    Private Sub reinicio_Click(sender As Object, e As EventArgs) Handles reinicio.Click
        Process.Start("shutdown.exe", " -r -f")
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

    Declare Function EnableWindow Lib "user32" (ByVal hwnd As Int32, ByVal nOption As Int32) As Int32
    Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hwnd As Int32, ByVal nclass As Int32, ByVal spz1 As String, ByVal spz2 As String) As Int32
    Declare Function ShowWindow Lib "user32" (ByVal hwnd As Int32, ByVal nCmd As Int32) As Int32
    Declare Function SendMessageA Lib "user32" (ByVal hwnd As Int32, ByVal msg As Int32, ByVal wParam As Int32, ByVal TextStart As String) As Int32
    Dim Hdesk, TaskbarWnd, StartWnd, Traynotify, clockwnd As Int64, StartText As String

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProcDelegate,
                                                                              ByVal hMod As IntPtr, ByVal dwThreadId As Integer) As Integer
    Declare Function UnhookWindowsHookEx Lib "user32" Alias "UnhookWindowsHookEx" (ByVal hHook As IntPtr) As Boolean
    Declare Function CallNextHookEx Lib "user32" Alias "CallNextHookEx" (ByVal hHook As IntPtr, ByVal nCode As Integer, ByVal wParam As Integer,
                                                                         ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    Delegate Function LowLevelKeyboardProcDelegate(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

    Const WH_KEYBOARD_LL As Integer = 13 'CONTROLA LOS INPUTS DEL TECLADO
    'NECESARIA PARA LA FUNCION CallNextHookEx
    Structure KBDLLHOOKSTRUCT
        Dim vkCode As Integer
        Dim scanCode As Integer
        Dim flags As Integer
        Dim time As Integer
        Dim dwExtraInfo As Integer
    End Structure

    Dim TECLEADO As Integer 'RESULTADO DE LA FUNCION SetWindowsHookEx
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
    Private Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer

        Dim ALTTAB As Boolean = ((lParam.vkCode = 9) AndAlso (lParam.flags = 32))  'PARA BLOQUEAR ALT+TAB
        Dim ALTESC As Boolean = ((lParam.vkCode = 27) AndAlso (lParam.flags = 32)) 'PARA BLOQUEAR ALT+ESC
        Dim CTRLESC As Boolean = ((lParam.vkCode = 27) AndAlso (lParam.flags = 0)) 'PARA BLOQUEAR CTRL+ESC
        Dim WIN As Boolean = ((lParam.vkCode = 91) AndAlso (lParam.flags = 1)) Or ((lParam.vkCode = 92) AndAlso (lParam.flags = 1)) 'PARA BLOQUEAR WIN L Y WIN R

        'PARA BLOQUEAR TODAS LAS ANTERIORES
        Dim TODAS As Boolean = ((lParam.vkCode = 9) AndAlso (lParam.flags = 32)) Or ((lParam.vkCode = 27) AndAlso (lParam.flags = 32)) Or
      ((lParam.vkCode = 27) AndAlso (lParam.flags = 0)) Or ((lParam.vkCode = 91) AndAlso (lParam.flags = 1)) Or ((lParam.vkCode = 92) AndAlso (lParam.flags = 1))

        'BLOQUEA ALT+TAB
        If ALTTAB = True Then
            Return 1
            ''BLOQUEA ALT+ESC
        ElseIf ALTESC = True Then
            Return 1
            ''BLOQUEA CTRL+ESC
        ElseIf CTRLESC = True Then
            Return 1
            'BLOQUEA WIN L Y WIN R
        ElseIf WIN = True Then
            Return 1
            'BLOQUEA TODAS LAS ANTERIORES
        ElseIf TODAS = True Then
            Return 1
        Else
            Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
        End If
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub

End Class
