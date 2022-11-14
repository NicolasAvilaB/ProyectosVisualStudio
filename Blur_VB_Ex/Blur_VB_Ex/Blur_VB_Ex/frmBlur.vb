Public Class frmBlur

    Private Function ColourAvg(ByVal szAvgSize As Size, ByVal szfImageSize As SizeF, ByVal intX As Integer, ByVal intY As Integer) As Color

        Dim arrlPixels As New ArrayList 'Host All Pixels

        Dim x As Integer 'X Location
        Dim y As Integer 'Y Location

        Dim bmpBlurDest As Bitmap = picBlurDest.Image.Clone 'Image To Be Cloned

        'Find Each Pixel's Color And Add To ArrayList
        For x = intX - CInt(szAvgSize.Width / 2) To intX + CInt(szAvgSize.Width / 2) 'Left To Right

            For y = intY - CInt(szAvgSize.Height / 2) To intY + CInt(szAvgSize.Height / 2) 'Up To Down

                If (x > 0 And x < szfImageSize.Width) And (y > 0 And y < szfImageSize.Height) Then 'If Not Out Of Bounds

                    arrlPixels.Add(bmpBlurDest.GetPixel(x, y)) 'Add To ArrayList

                End If

            Next

        Next

        Dim clrCurrColour As Color 'Current Colour

        Dim intAlpha As Integer = 0 'Alpha Channel
        Dim intRed As Integer = 0 'Red Channel
        Dim intGreen As Integer = 0 'Green Channel
        Dim intBlue As Integer = 0 'Blue Channel

        For Each clrCurrColour In arrlPixels 'Loop Through Each Colour

            'Store Each Colour
            intAlpha += clrCurrColour.A
            intRed += clrCurrColour.R
            intGreen += clrCurrColour.G
            intBlue += clrCurrColour.B

        Next

        ' Return Average A, R, G, B  
        Return Color.FromArgb(intAlpha / arrlPixels.Count, intRed / arrlPixels.Count, intGreen / arrlPixels.Count, intBlue / arrlPixels.Count)

    End Function

    'Blur Sub
    Private Sub GaussianBlur(ByVal blnAlphaEdges As Boolean, ByVal szBlurSize As Size)

        Dim Y As Integer 'Y
        Dim X As Integer 'X

        Dim bmpBlurDest As Bitmap = picBlurDest.Image.Clone 'Clone Of Image

        'Show Progress
        lblProgress.Text = "Applying Gaussian Blur " & szBlurSize.ToString

        prgBlurProgress.Maximum = bmpBlurDest.Height * bmpBlurDest.Width 'Set Max

        prgBlurProgress.Minimum = 0 'Set Min

        prgBlurProgress.Value = 0 'Initialize Value

        'Loop Through Image
        For Y = 0 To bmpBlurDest.Width - 1 'Top To Bottom

            ' Left To Right
            For X = 0 To bmpBlurDest.Height - 1

                If Not blnAlphaEdges Then 'AlphaEdges Not Chosen

                    bmpBlurDest.SetPixel(X, Y, ColourAvg(szBlurSize, bmpBlurDest.PhysicalDimension, X, Y)) 'Do Blur

                ElseIf bmpBlurDest.GetPixel(X, Y).A <> 255 Then 'Alpha Isw Not Set To 255

                    bmpBlurDest.SetPixel(X, Y, ColourAvg(szBlurSize, bmpBlurDest.PhysicalDimension, X, Y)) 'Do Blur

                End If

                prgBlurProgress.Value += 1 'Updeate Progress

                Application.DoEvents() 'Ensure App Doesn't Hang

            Next

        Next

        picBlurDest.Image = bmpBlurDest.Clone 'Update Blurred Image

        bmpBlurDest.Dispose() 'Remove From Memory

    End Sub

    Private Sub btnBlur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlur.Click

        GaussianBlur(chkAlphaEdges.Checked, New Size(8, 8)) 'Call Blur Function

    End Sub

End Class
