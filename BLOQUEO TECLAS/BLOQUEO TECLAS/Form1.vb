Public Class Form1

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

    'CAMBIA EL COLOR SI ES PULSADO
    Private Sub ButtonALTTAB_Click(sender As System.Object, e As System.EventArgs) Handles ButtonALTTAB.Click
        If ButtonALTTAB.BackColor = Color.Black Then
            COLORES()
            ButtonALTTAB.BackColor = Color.Red
            TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
        Else
            ButtonALTTAB.BackColor = Color.Black
        End If
    End Sub
    'CAMBIA EL COLOR SI ES PULSADO
    Private Sub ButtonALTESC_Click(sender As System.Object, e As System.EventArgs) Handles ButtonALTESC.Click
        If ButtonALTESC.BackColor = Color.Black Then
            COLORES()
            ButtonALTESC.BackColor = Color.Red
            TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
        Else
            ButtonALTESC.BackColor = Color.Black
        End If
    End Sub
    'CAMBIA EL COLOR SI ES PULSADO
    Private Sub ButtonCTRLESC_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCTRLESC.Click
        If ButtonCTRLESC.BackColor = Color.Black Then
            COLORES()
            ButtonCTRLESC.BackColor = Color.Red
            TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
        Else
            ButtonCTRLESC.BackColor = Color.Black
        End If
    End Sub
    'CAMBIA EL COLOR SI ES PULSADO
    Private Sub ButtonWIN_Click(sender As System.Object, e As System.EventArgs) Handles ButtonWIN.Click
        If ButtonWIN.BackColor = Color.Black Then
            COLORES()
            ButtonWIN.BackColor = Color.Red
            TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
        Else
            ButtonWIN.BackColor = Color.Black
        End If
    End Sub
    'CAMBIA EL COLOR SI ES PULSADO
    Private Sub ButtonTODAS_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTODAS.Click
        If ButtonTODAS.BackColor = Color.Black Then
            COLORES()
            ButtonTODAS.BackColor = Color.Red
            TECLEADO = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
        Else
            ButtonTODAS.BackColor = Color.Black
        End If
    End Sub

    'BORRA LOS ROJOS ANTERIORES
    Public Sub COLORES()
        ButtonALTTAB.BackColor = Color.Black
        ButtonALTESC.BackColor = Color.Black
        ButtonCTRLESC.BackColor = Color.Black
        ButtonWIN.BackColor = Color.Black
        ButtonTODAS.BackColor = Color.Black
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
        If ALTTAB = True And ButtonALTTAB.BackColor = Color.Red Then
            Return 1
            'BLOQUEA ALT+ESC
        ElseIf ALTESC = True And ButtonALTESC.BackColor = Color.Red Then
            Return 1
            'BLOQUEA CTRL+ESC
        ElseIf CTRLESC = True And ButtonCTRLESC.BackColor = Color.Red Then
            Return 1
            'BLOQUEA WIN L Y WIN R
        ElseIf WIN = True And ButtonWIN.BackColor = Color.Red Then
            Return 1
            'BLOQUEA TODAS LAS ANTERIORES
        ElseIf TODAS = True And ButtonTODAS.BackColor = Color.Red Then
            Return 1
        Else
            Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
        End If
    End Function
    'PARA ASEGURAR QUE NO QUEDE NADA BLOQUEADO EN EL TECLADO AL CERRAR LA APLICACION
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnhookWindowsHookEx(TECLEADO) 'PARA ASEGURAR QUE NO QUEDE NADA BLOQUEADO EN EL TECLADO AL CERRAR LA APLICACION
    End Sub

End Class
