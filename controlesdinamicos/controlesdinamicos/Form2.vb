Public Class Form2
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        pre.Enabled = True
        cantop.Enabled = True
        pre.ReadOnly = False
        cantop.ReadOnly = False
        nuevo.Enabled = False
        Consulta2("Call codigoencuesta")
        If TypeOf (DS2.Tables(DT2.TableName).Rows(0).Item("codigo")) Is DBNull Then
            cod.Text = "1"
        Else
            cod.Text = DS2.Tables(DT2.TableName).Rows(0).Item("codigo") + 1
            Conexion.Close()
        End If
        guardar.Enabled = True
        cancelar.Enabled = True
        agregar.Enabled = True
        Panel1.Controls.Clear()
        cantop.Text = "1"
        pre.Clear()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        Panel1.Controls.Clear()
        cod.Text = "0"
        cantop.Clear()
        pre.Clear()
        pre.Enabled = False
        cantop.Enabled = False
        pre.ReadOnly = True
        cantop.ReadOnly = True
        nuevo.Enabled = True
        guardar.Enabled = False
        cancelar.Enabled = False
        agregar.Enabled = False
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Panel1.Controls.Clear()
        Dim i As Integer
        Dim x As Integer
        Dim y As Integer
        x = 10
        y = 20
        For i = 1 To CInt(cantop.Text)
            Dim mitextbox As TextBox = New TextBox
            Dim milabel As Label = New Label
            milabel.Name = "lbl_Opcion" & i
            milabel.Text = "Opcion:" & i
            milabel.Location = New Point(x, y)
            milabel.Width = 60
            mitextbox.Name = "txt_opcion" & i
            mitextbox.Location = New Point(70, y)
            Panel1.Controls.Add(milabel)
            Panel1.Controls.Add(mitextbox)
            y += 22
        Next
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = "Database=bdencuestas;Data Source=127.0.0.1;User Id=root;Password=aiep"
        f.Text = FormatDateTime(Now, DateFormat.ShortDate)
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        'guardar encuesta
        Dim mifecha As Date = FormatDateTime(Now, DateFormat.ShortDate)
        Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
        Consulta("insert into encuesta values ('" & (cod.Text) & "','" & (pre.Text) & "','" & (mifecha2) & "')")
        'guardar opciones
        Dim n As Integer = 1
        Dim texto_opcion As String
        For Each misobjetos As Control In Panel1.Controls
            If misobjetos.Name = "txt_opcion" & n Then
                texto_opcion = CType(misobjetos, TextBox).Text
                Consulta("insert into opciones_encuestas (codigoencuesta, opcion) values('" & (cod.Text) & "','" & (texto_opcion) & "')")
            End If
        Next
        Panel1.Controls.Clear()
        cod.Text = "0"
        cantop.Clear()
        pre.Clear()
        pre.Enabled = False
        cantop.Enabled = False
        pre.ReadOnly = True
        cantop.ReadOnly = True
        nuevo.Enabled = True
        guardar.Enabled = False
        cancelar.Enabled = False
        agregar.Enabled = False
        MsgBox("Datos Ingresados Correctamente", vbInformation, "Ingreso Exitoso")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class