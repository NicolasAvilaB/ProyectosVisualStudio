Imports System.Runtime.InteropServices
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Class AdvRichTextBox
        Inherits RichTextBox
        ''' <summary>
        ''' Maintains performance while updating.
        ''' </summary>
        ''' <remarks>
        ''' <para>
        ''' It is recommended to call this method before doing
        ''' any major updates that you do not wish the user to
        ''' see. Remember to call EndUpdate when you are finished
        ''' with the update. Nested calls are supported.
        ''' </para>
        ''' <para>
        ''' Calling this method will prevent redrawing. It will
        ''' also setup the event mask of the underlying richedit
        ''' control so that no events are sent.
        ''' </para>
        ''' </remarks>
        Public Sub BeginUpdate()
            ' Deal with nested calls.
            updating += 1

            If updating > 1 Then
                Return
            End If

            ' Prevent the control from raising any events.
            oldEventMask = SendMessage(New HandleRef(Me, Handle), EM_SETEVENTMASK, 0, 0)

            ' Prevent the control from redrawing itself.
            SendMessage(New HandleRef(Me, Handle), WM_SETREDRAW, 0, 0)
        End Sub
        Public Sub EndUpdate()
            ' Deal with nested calls.
            updating -= 1

            If updating > 0 Then
                Return
            End If

            ' Allow the control to redraw itself.
            SendMessage(New HandleRef(Me, Handle), WM_SETREDRAW, 1, 0)

            ' Allow the control to raise event messages.
            SendMessage(New HandleRef(Me, Handle), EM_SETEVENTMASK, 0, oldEventMask)
        End Sub

        ''' <summary>
        ''' Gets or sets the alignment to apply to the current
        ''' selection or insertion point.
        ''' </summary>
        ''' <remarks>
        ''' Replaces the SelectionAlignment from
        ''' <see cref="RichTextBox"/>.
        ''' </remarks>
        Public Shadows Property SelectionAlignment() As TextAlign
            Get
                Dim fmt As New PARAFORMAT()
                fmt.cbSize = Marshal.SizeOf(fmt)

                ' Get the alignment.
                SendMessage(New HandleRef(Me, Handle), EM_GETPARAFORMAT, SCF_SELECTION, fmt)

                ' Default to Left align.
                If (fmt.dwMask And PFM_ALIGNMENT) = 0 Then
                    Return TextAlign.Left
                End If

                Return CType(fmt.wAlignment, TextAlign)
            End Get

            Set(value As TextAlign)
                Dim fmt As New PARAFORMAT()
                fmt.cbSize = Marshal.SizeOf(fmt)
                fmt.dwMask = PFM_ALIGNMENT
                fmt.wAlignment = CShort(value)

                ' Set the alignment.
                SendMessage(New HandleRef(Me, Handle), EM_SETPARAFORMAT, SCF_SELECTION, fmt)
            End Set
        End Property

        ''' <summary>
        ''' This member overrides
        ''' <see cref="Control"/>.OnHandleCreated.
        ''' </summary>
        Protected Overrides Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)

            ' Enable support for justification.
            SendMessage(New HandleRef(Me, Handle), EM_SETTYPOGRAPHYOPTIONS, TO_ADVANCEDTYPOGRAPHY, TO_ADVANCEDTYPOGRAPHY)
        End Sub

        Private updating As Integer = 0
        Private oldEventMask As Integer = 0

        ' Constants from the Platform SDK.
        Private Const EM_SETEVENTMASK As Integer = 1073
        Private Const EM_GETPARAFORMAT As Integer = 1085
        Private Const EM_SETPARAFORMAT As Integer = 1095
        Private Const EM_SETTYPOGRAPHYOPTIONS As Integer = 1226
        Private Const WM_SETREDRAW As Integer = 11
        Private Const TO_ADVANCEDTYPOGRAPHY As Integer = 1
        Private Const PFM_ALIGNMENT As Integer = 8
        Private Const SCF_SELECTION As Integer = 1

        ' It makes no difference if we use PARAFORMAT or
        ' PARAFORMAT2 here, so I have opted for PARAFORMAT2.
        <StructLayout(LayoutKind.Sequential)>
        Private Structure PARAFORMAT
            Public cbSize As Integer
            Public dwMask As UInteger
            Public wNumbering As Short
            Public wReserved As Short
            Public dxStartIndent As Integer
            Public dxRightIndent As Integer
            Public dxOffset As Integer
            Public wAlignment As Short
            Public cTabCount As Short
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)>
            Public rgxTabs As Integer()

            ' PARAFORMAT2 from here onwards.
            Public dySpaceBefore As Integer
            Public dySpaceAfter As Integer
            Public dyLineSpacing As Integer
            Public sStyle As Short
            Public bLineSpacingRule As Byte
            Public bOutlineLevel As Byte
            Public wShadingWeight As Short
            Public wShadingStyle As Short
            Public wNumberingStart As Short
            Public wNumberingStyle As Short
            Public wNumberingTab As Short
            Public wBorderSpace As Short
            Public wBorderWidth As Short
            Public wBorders As Short
        End Structure

        <DllImport("user32", CharSet:=CharSet.Auto)>
        Private Shared Function SendMessage(hWnd As HandleRef, msg As Integer, wParam As Integer, lParam As Integer) As Integer
        End Function

        <DllImport("user32", CharSet:=CharSet.Auto)>
        Private Shared Function SendMessage(hWnd As HandleRef, msg As Integer, wParam As Integer, ByRef lp As PARAFORMAT) As Integer
        End Function

    End Class
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.SelectionAlignment = TextAlign.Justify
    End Sub
End Class

''' <summary>
''' Specifies how text in a <see cref="RichTextBox"/> is
''' horizontally aligned.
''' </summary>
Public Enum TextAlign
    ''' <summary>
    ''' The text is aligned to the left.
    ''' </summary>
    Left = 1

    ''' <summary>
    ''' The text is aligned to the right.
    ''' </summary>
    Right = 2

    ''' <summary>
    ''' The text is aligned in the center.
    ''' </summary>
    Center = 3

    ''' <summary>
    ''' The text is justified.
    ''' </summary>
    Justify = 4
End Enum
