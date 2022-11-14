Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class TextBoxEx
    Inherits System.Windows.Forms.TextBox

    Private vBorderColor As Color = Color.Empty
    <Category("Appearance"), DefaultValue(GetType(Color), "")> _
    Public Property BorderColor() As Color
        Get
            Return Me.vBorderColor
        End Get
        Set(ByVal value As Color)
            If Not value = Me.BorderColor Then
                Me.vBorderColor = value
                Me.RedrawBorder()
            End If
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If CallDefault(m) Then _
            MyBase.WndProc(m)
    End Sub
    Private Function CallDefault(ByRef m As System.Windows.Forms.Message) As Boolean
        Select Case m.Msg
            Case NativeMethods.WM_PAINT
                Return Me.WmPaint(m)
            Case NativeMethods.WM_NCPAINT
                Return Me.WmNCPaint(m)
            Case Else
                Return True
        End Select
    End Function
    Private Function WmPaint(ByRef m As Message) As Boolean
        If Not Me.BorderStyle = BorderStyle.FixedSingle Or _
               Me.BorderColor.IsEmpty Then _
            Return True

        MyBase.DefWndProc(m)

        Using g As Graphics = Me.CreateGraphics()
            Me.OnNCPaint(g, Me.ClientRectangle)
        End Using

        Return False
    End Function
    Private Function WmNCPaint(ByRef m As Message) As Boolean

        If Not Me.IsHandleCreated Or _
               Me.IsDisposed Or _
               Me.BorderColor.IsEmpty Or _
               Not Me.BorderStyle = BorderStyle.Fixed3D Then _
            Return True

        Dim rECT As NativeMethods.RECT = Nothing
        NativeMethods.GetWindowRect(Me.Handle, rECT)
        If rECT.Width = 0 Or rECT.Height = 0 Then _
            Return True

        Dim bounds As Rectangle = New Rectangle(0, 0, rECT.Width, rECT.Height)
        Dim hDC As IntPtr = NativeMethods.GetDCEx _
                ( _
                    Me.Handle, _
                    IntPtr.Zero, _
                    NativeMethods.DCXFlags.DCX_CACHE Or _
                    NativeMethods.DCXFlags.DCX_CLIPSIBLINGS Or _
                    NativeMethods.DCXFlags.DCX_WINDOW _
                )
        If Not hDC = IntPtr.Zero Then

            NativeMethods.ExcludeClipRect(hDC, 2, 2, bounds.Right - 2, bounds.Bottom - 2)
            Using bg As BufferedGraphics = BufferedGraphicsManager.Current.Allocate(hDC, bounds)
                Using brush As SolidBrush = New SolidBrush(Me.BackColor)
                    bg.Graphics.FillRectangle(brush, bounds)
                End Using
                Me.OnNCPaint(bg.Graphics, bounds)
                bg.Render(hDC)
            End Using

            NativeMethods.ReleaseDC(Me.Handle, hDC)
        End If

    End Function
    Private Sub OnNCPaint(ByVal g As Graphics, ByVal bounds As Rectangle)
        ControlPaint.DrawBorder(g, bounds, Me.BorderColor, ButtonBorderStyle.Solid)
    End Sub
    Private Sub RedrawBorder()
        NativeMethods.RedrawWindow _
        ( _
            Me.Handle, _
            IntPtr.Zero, _
            IntPtr.Zero, _
            NativeMethods.RDW_FRAME Or _
            NativeMethods.RDW_INTERNALPAINT Or _
            NativeMethods.RDW_UPDATENOW Or _
            NativeMethods.RDW_INVALIDATE _
        )
    End Sub

End Class
