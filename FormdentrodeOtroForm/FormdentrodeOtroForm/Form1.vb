Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form2.MdiParent = Me
        SplitContainer1.Panel2.Controls.Add(Form2)
        Form2.Show()
    End Sub

    Private Sub Form1_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate


    End Sub
End Class
