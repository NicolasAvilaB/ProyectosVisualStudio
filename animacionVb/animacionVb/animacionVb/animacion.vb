Public Class animacion

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Size = New Size(height:=88, width:=90)
        Call misonido()
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(height:=74, width:=64)
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        PictureBox2.Size = New Size(height:=88, width:=90)
        Call misonido()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(height:=74, width:=64)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Size = New Size(height:=88, width:=90)
        Call misonido()
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(height:=74, width:=64)
    End Sub


    Private Sub misonido()
        Dim r As String
        r = My.Application.Info.DirectoryPath
        Dim sonido As System.Media.SoundPlayer
        sonido = New System.Media.SoundPlayer(r + "\button-09.WAV")
        sonido.Play()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Width = 1000
        Button2.Visible = True
        Button1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Width = 700
        Button1.Visible = True
        Button2.Visible = False
    End Sub

    Private Sub animacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class