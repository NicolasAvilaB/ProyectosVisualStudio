Imports System.IO
'OBTENIDO, CONVERTIDO Y ADAPTADO DESDE :https://gist.github.com/darkfall/1656050
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ButtonCARGAR_Click(sender As Object, e As EventArgs) Handles ButtonCARGAR.Click
       
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub ButtonCONVERTIR_Click(sender As Object, e As EventArgs) Handles ButtonCONVERTIR.Click

        Dim DESTINO As String = String.Empty

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            DESTINO = SaveFileDialog1.FileName
        End If

        Dim TAMAÑO As Integer = Nothing

        If RadioButton16.Checked Then
            TAMAÑO = 16
        ElseIf RadioButton32.Checked Then
            TAMAÑO = 32
        ElseIf RadioButton48.Checked Then
            TAMAÑO = 48
        ElseIf RadioButton64.Checked Then
            TAMAÑO = 64
        ElseIf RadioButton100.Checked Then
            TAMAÑO = 100
        ElseIf RadioButton200.Checked Then
            TAMAÑO = 150
        End If
        Convert(OpenFileDialog1.FileName, DESTINO, TAMAÑO, False)
        MsgBox("CONVERSION REALIZADA")
    End Sub
    ' input image with width = height is suggested to get the best result 

    ' png support in icon was introduced in Windows Vista 

    Public Shared Function Convert(input_stream As System.IO.Stream, output_stream As System.IO.Stream, size As Integer, Optional keep_aspect_ratio As Boolean = False) As Boolean
        Dim input_bit As System.Drawing.Bitmap = DirectCast(System.Drawing.Bitmap.FromStream(input_stream), System.Drawing.Bitmap)
        If input_bit IsNot Nothing Then
            Dim width As Integer, height As Integer
            If keep_aspect_ratio Then
                width = size
                height = input_bit.Height / input_bit.Width * size
            Else
                width = InlineAssignHelper(height, size)
            End If
            Dim new_bit As New System.Drawing.Bitmap(input_bit, New System.Drawing.Size(width, height))
            If new_bit IsNot Nothing Then
                ' save the resized png into a memory stream for future use
                Dim mem_data As New System.IO.MemoryStream()
                new_bit.Save(mem_data, System.Drawing.Imaging.ImageFormat.Png)

                Dim icon_writer As New System.IO.BinaryWriter(output_stream)
                If output_stream IsNot Nothing AndAlso icon_writer IsNot Nothing Then
                    ' 0-1 reserved, 0
                    icon_writer.Write(CByte(0))
                    icon_writer.Write(CByte(0))

                    ' 2-3 image type, 1 = icon, 2 = cursor
                    icon_writer.Write(CShort(1))

                    ' 4-5 number of images
                    icon_writer.Write(CShort(1))

                    ' image entry 1
                    ' 0 image width
                    icon_writer.Write(CByte(width))
                    ' 1 image height
                    icon_writer.Write(CByte(height))

                    ' 2 number of colors
                    icon_writer.Write(CByte(0))

                    ' 3 reserved
                    icon_writer.Write(CByte(0))

                    ' 4-5 color planes
                    icon_writer.Write(CShort(0))

                    ' 6-7 bits per pixel
                    icon_writer.Write(CShort(32))

                    ' 8-11 size of image data
                    icon_writer.Write(CInt(mem_data.Length))

                    ' 12-15 offset of image data
                    icon_writer.Write(CInt(6 + 16))

                    ' write image data
                    ' png data must contain the whole png data file
                    icon_writer.Write(mem_data.ToArray())

                    icon_writer.Flush()

                    Return True
                End If
            End If
            Return False
        End If
        Return False
    End Function

    Public Function Convert(input_image As String, output_icon As String, size As Integer, Optional keep_aspect_ratio As Boolean = False) As Boolean
        PictureBox1.Image.Dispose()
        Dim input_stream As New System.IO.FileStream(input_image, System.IO.FileMode.Open)
        Dim output_stream As New System.IO.FileStream(output_icon, System.IO.FileMode.OpenOrCreate)

        Dim result As Boolean = Convert(input_stream, output_stream, size, keep_aspect_ratio)

        input_stream.Close()
        output_stream.Close()

        Return result
    End Function
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton200_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton200.CheckedChanged

    End Sub
End Class
