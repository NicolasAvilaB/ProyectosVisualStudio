Imports System.Runtime.InteropServices
Imports System.Drawing

Public Class NativeMethods

    <DllImport("user32.dll")> _
    Public Shared Function GetDCEx(ByVal hWnd As IntPtr, ByVal hrgnClip As IntPtr, ByVal flags As DCXFlags) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("gdi32.dll")> _
    Public Shared Function ExcludeClipRect(ByVal hDc As IntPtr, ByVal nLectRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer) As Integer
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Boolean
    End Function
    <DllImport("user32.dll")> _
    Public Shared Function RedrawWindow(ByVal hWnd As IntPtr, ByVal lprcUpdate As IntPtr, ByVal hrgnUpdate As IntPtr, ByVal flags As UInteger) As Boolean
    End Function

    ''' <summary>Values to pass to the GetDCEx method.</summary>
    <Flags()> _
    Public Enum DCXFlags As UInteger
        ''' <summary>DCX_WINDOW: Returns a DC that corresponds to the window rectangle rather 
        ''' than the client rectangle.</summary>
        DCX_WINDOW = &H1
        ''' <summary>DCX_CACHE: Returns a DC from the cache, rather than the OWNDC or CLASSDC 
        ''' window. Essentially overrides CS_OWNDC and CS_CLASSDC.</summary>
        DCX_CACHE = &H2
        ''' <summary>DCX_NORESETATTRS: Does not reset the attributes of this DC to the 
        ''' default attributes when this DC is released.</summary>
        DCX_NORESETATTRS = &H4
        ''' <summary>DCX_CLIPCHILDREN: Excludes the visible regions of all child windows 
        ''' below the window identified by hWnd.</summary>
        DCX_CLIPCHILDREN = &H8
        ''' <summary>DCX_CLIPSIBLINGS: Excludes the visible regions of all sibling windows 
        ''' above the window identified by hWnd.</summary>
        DCX_CLIPSIBLINGS = &H10
        ''' <summary>DCX_PARENTCLIP: Uses the visible region of the parent window. The 
        ''' parent's WS_CLIPCHILDREN and CS_PARENTDC style bits are ignored. The origin is 
        ''' set to the upper-left corner of the window identified by hWnd.</summary>
        DCX_PARENTCLIP = &H20
        ''' <summary>DCX_EXCLUDERGN: The clipping region identified by hrgnClip is excluded 
        ''' from the visible region of the returned DC.</summary>
        DCX_EXCLUDERGN = &H40
        ''' <summary>DCX_INTERSECTRGN: The clipping region identified by hrgnClip is 
        ''' intersected with the visible region of the returned DC.</summary>
        DCX_INTERSECTRGN = &H80
        ''' <summary>DCX_EXCLUDEUPDATE: Unknown...Undocumented</summary>
        DCX_EXCLUDEUPDATE = &H100
        ''' <summary>DCX_INTERSECTUPDATE: Unknown...Undocumented</summary>
        DCX_INTERSECTUPDATE = &H200
        ''' <summary>DCX_LOCKWINDOWUPDATE: Allows drawing even if there is a LockWindowUpdate 
        ''' call in effect that would otherwise exclude this window. Used for drawing during 
        ''' tracking.</summary>
        DCX_LOCKWINDOWUPDATE = &H400
        ''' <summary>DCX_VALIDATE When specified with DCX_INTERSECTUPDATE, causes the DC to 
        ''' be completely validated. Using this function with both DCX_INTERSECTUPDATE and 
        ''' DCX_VALIDATE is identical to using the BeginPaint function.</summary>
        DCX_VALIDATE = &H200000
    End Enum
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RECT
        Private _Left As Integer, _Top As Integer, _Right As Integer, _Bottom As Integer

        Public Sub New(ByVal Rectangle As Rectangle)
            Me.New(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom)
        End Sub
        Public Sub New(ByVal Left As Integer, ByVal Top As Integer, ByVal Right As Integer, ByVal Bottom As Integer)
            _Left = Left
            _Top = Top
            _Right = Right
            _Bottom = Bottom
        End Sub

        Public Property X() As Integer
            Get
                Return _Left
            End Get
            Set(ByVal value As Integer)
                _Right = _Right - _Left + value
                _Left = value
            End Set
        End Property
        Public Property Y() As Integer
            Get
                Return _Top
            End Get
            Set(ByVal value As Integer)
                _Bottom = _Bottom - _Top + value
                _Top = value
            End Set
        End Property
        Public Property Left() As Integer
            Get
                Return _Left
            End Get
            Set(ByVal value As Integer)
                _Left = value
            End Set
        End Property
        Public Property Top() As Integer
            Get
                Return _Top
            End Get
            Set(ByVal value As Integer)
                _Top = value
            End Set
        End Property
        Public Property Right() As Integer
            Get
                Return _Right
            End Get
            Set(ByVal value As Integer)
                _Right = value
            End Set
        End Property
        Public Property Bottom() As Integer
            Get
                Return _Bottom
            End Get
            Set(ByVal value As Integer)
                _Bottom = value
            End Set
        End Property
        Public Property Height() As Integer
            Get
                Return _Bottom - _Top
            End Get
            Set(ByVal value As Integer)
                _Bottom = value + _Top
            End Set
        End Property
        Public Property Width() As Integer
            Get
                Return _Right - _Left
            End Get
            Set(ByVal value As Integer)
                _Right = value + _Left
            End Set
        End Property
        Public Property Location() As Point
            Get
                Return New Point(Left, Top)
            End Get
            Set(ByVal value As Point)
                _Right = _Right - _Left + value.X
                _Bottom = _Bottom - _Top + value.Y
                _Left = value.X
                _Top = value.Y
            End Set
        End Property
        Public Property Size() As Size
            Get
                Return New Size(Width, Height)
            End Get
            Set(ByVal value As Size)
                _Right = value.Width + _Left
                _Bottom = value.Height + _Top
            End Set
        End Property

        Public Shared Widening Operator CType(ByVal Rectangle As RECT) As Rectangle
            Return New Rectangle(Rectangle.Left, Rectangle.Top, Rectangle.Width, Rectangle.Height)
        End Operator
        Public Shared Widening Operator CType(ByVal Rectangle As Rectangle) As RECT
            Return New RECT(Rectangle.Left, Rectangle.Top, Rectangle.Right, Rectangle.Bottom)
        End Operator
        Public Shared Operator =(ByVal Rectangle1 As RECT, ByVal Rectangle2 As RECT) As Boolean
            Return Rectangle1.Equals(Rectangle2)
        End Operator
        Public Shared Operator <>(ByVal Rectangle1 As RECT, ByVal Rectangle2 As RECT) As Boolean
            Return Not Rectangle1.Equals(Rectangle2)
        End Operator

        Public Overrides Function ToString() As String
            Return "{Left: " & _Left & "; " & "Top: " & _Top & "; Right: " & _Right & "; Bottom: " & _Bottom & "}"
        End Function

        Public Overloads Function Equals(ByVal Rectangle As RECT) As Boolean
            Return Rectangle.Left = _Left AndAlso Rectangle.Top = _Top AndAlso Rectangle.Right = _Right AndAlso Rectangle.Bottom = _Bottom
        End Function
        Public Overloads Overrides Function Equals(ByVal [Object] As Object) As Boolean
            If TypeOf [Object] Is RECT Then
                Return Equals(DirectCast([Object], RECT))
            ElseIf TypeOf [Object] Is Rectangle Then
                Return Equals(New RECT(DirectCast([Object], Rectangle)))
            End If

            Return False
        End Function
    End Structure

    Public Const WM_PAINT As Integer = &HF
    Public Const WM_NCPAINT As Integer = &H85

    Public Const RDW_INVALIDATE As UInteger = &H1
    Public Const RDW_FRAME As UInteger = &H400
    Public Const RDW_INTERNALPAINT As UInteger = &H2
    Public Const RDW_UPDATENOW As UInteger = &H100
End Class
