Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click
        OpenFileDialog1.Filter = "Imagenes(*.jpg) |* .jpg| (*.png) |* .png "
        OpenFileDialog1.ShowDialog()
        PictureBox1.ImageLocation = OpenFileDialog1.FileName

        txtRuta.Text = OpenFileDialog1.FileName
        CbRutas.Items.Add(OpenFileDialog1.FileName)




    End Sub
    Private Sub CbRutas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbRutas.SelectedIndexChanged
        PictureBox1.ImageLocation = CbRutas.Text
        txtRuta.Text = CbRutas.Text

    End Sub
End Class