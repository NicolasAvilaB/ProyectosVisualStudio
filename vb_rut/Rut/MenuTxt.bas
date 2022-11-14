Attribute VB_Name = "MenuTxt"
Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hWnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
Private Declare Function CallWindowProc Lib "user32" Alias "CallWindowProcA" (ByVal lpPrevWndFunc As Long, ByVal hWnd As Long, ByVal Msg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
Private Const GWL_WNDPROC = (-4)
Private Const WM_CONTEXTMENU = &H7B
Private varPrevConf As Long
Private varHwnd As Long
Private varHooked As Boolean

Private Function funcWindowProc(ByVal prmHwnd As Long, ByVal prmObjMsg As Long, ByVal wParam As Long, ByVal lParam As Long) As Long
    If prmObjMsg = WM_CONTEXTMENU Then
     funcWindowProc = True
    Else
     funcWindowProc = CallWindowProc(varPrevConf, prmHwnd, prmObjMsg, wParam, lParam)
    End If
End Function

Public Sub funcHookText(ByVal prmCtrlText As TextBox)
    varHwnd = prmCtrlText.hWnd
    varPrevConf = SetWindowLong(varHwnd, GWL_WNDPROC, AddressOf funcWindowProc)
    varHooked = True
End Sub

Public Sub funcUnHookText()
    If varHooked Then
     Call SetWindowLong(varHwnd, GWL_WNDPROC, varPrevConf)
     varHooked = False
    End If
End Sub
