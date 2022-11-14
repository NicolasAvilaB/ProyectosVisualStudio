Imports System.IO

Public Class Form1
    Dim dtsect As Integer
    Dim Dato1 As String
    Public Sub conexiones()
        Try
            Conexion.ConnectionString = "Data Source=" & (Server.Text) & ";User Id=" & (IDUsuario.Text) & ";Password=" & (Password.Text) & ""
        Catch ex As Exception
            MsgBox("Conexion Fallida, Revise Bien si Escribió algo Erroneo", vbCritical, "Error")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server.Focus()
        Server.Select()

    End Sub

    Private Sub Server_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Server.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Server_LostFocus(sender As Object, e As EventArgs) Handles Server.LostFocus


    End Sub


    Private Sub Server_TextChanged(sender As Object, e As EventArgs) Handles Server.TextChanged

    End Sub
    Sub actualizar_tabla_clientes()

        Consulta("show databases;")

    End Sub

    Sub mostrar_grilla()
        DataGridView1.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub

    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        If (Server.Text = "") Then
            MsgBox("Error Campo del Servidor Vacio, Especifique Uno", vbCritical, "Error")
            Server.Focus()
        ElseIf (IDUsuario.Text = "") Then
            MsgBox("Error Campo del Usuario Vacio, Especifique Un Usuario Valido", vbCritical, "Error")
            IDUsuario.Focus()
        ElseIf (Password.Text = "") Then
            MsgBox("Error Campo de la Contraseña(Password) Vacia, Especifique Una Contraseña Valida", vbCritical, "Error")
            Password.Focus()
        Else

            Try
                conexiones()

                actualizar_tabla_clientes()
                mostrar_grilla()
                DA.SelectCommand = SC
                DA.Fill(DT)


               
                Conectar.Enabled = False
                GroupBox1.Enabled = False
                Server.ReadOnly = True
                IDUsuario.ReadOnly = True
                Password.ReadOnly = True
                GroupBox2.Enabled = True

            Catch ex As Exception
                MsgBox("Conexion Fallida, Revise Bien si Escribió algo Erroneo", vbCritical, "Error")

                Server.Clear()
                IDUsuario.Clear()
                Password.Clear()
                Server.Focus()
            End Try
        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub IDUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub IDUsuario_TextChanged(sender As Object, e As EventArgs) Handles IDUsuario.TextChanged

    End Sub

    Private Sub Crear_Click(sender As Object, e As EventArgs) Handles Crear.Click
        If (NOMBREBD.Text = "") Then
            MsgBox("Error, No ha especificado el Nombre de la Base de Datos", vbCritical, "Error Fatal")
            NOMBREBD.Focus()
            NOMBREBD.Select()
        Else
            Try
                Consulta("Create Database " & (NOMBREBD.Text) & ";")
                MsgBox("Base de Datos Creada Correctamente")
                Consulta("Show databases;")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            NOMBREBD.Clear()
            NOMBREBD.Focus()
            NOMBREBD.Select()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Guardar_Click_1(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim dbfile As String
       
        Try
            SaveFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            SaveFileDialog1.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                conexiones()
                dbfile = SaveFileDialog1.FileName
                Dim backuppro As New Process
                backuppro.StartInfo.FileName = "cmd.exe"
                backuppro.StartInfo.UseShellExecute = False
                backuppro.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin"
                backuppro.StartInfo.RedirectStandardInput = True
                backuppro.StartInfo.RedirectStandardOutput = True
                backuppro.Start()

                Dim backupstream As StreamWriter = backuppro.StandardInput
                Dim mystreamreader As StreamReader = backuppro.StandardOutput
                backupstream.WriteLine("mysqldump --user=" & IDUsuario.Text & " --password=" & Password.Text & " -h " & Server.Text & "--database " & Dato1 & " > """ + dbfile + """")
                backupstream.Close()
                backuppro.WaitForExit()
                backuppro.Close()
                MsgBox("Base de Datos Guardada y Creada", vbInformation, "Backup Exitoso")
            End If
        Catch ex As Exception
            MsgBox("Error de Creado" + ex.ToString + "", vbCritical, "Error")
        End Try
    End Sub

    Private Sub Restaurar_Click_1(sender As Object, e As EventArgs) Handles Restaurar.Click
        Dim DbFile1 As String

        Try
            ' create svaFileDialog and OpenFileDialog Component to our project
            OpenFileDialog1.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                conexiones() ' open our connections
                DbFile1 = OpenFileDialog1.FileName
                Dim BackupProccess As New Process
                BackupProccess.StartInfo.FileName = "cmd.exe"
                BackupProccess.StartInfo.UseShellExecute = False
                BackupProccess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin"
                BackupProccess.StartInfo.RedirectStandardInput = True
                BackupProccess.StartInfo.RedirectStandardOutput = True
                BackupProccess.Start()

                Dim BackupStream As StreamWriter = BackupProccess.StandardInput
                Dim myStreamReader As StreamReader = BackupProccess.StandardOutput
                BackupStream.WriteLine("mysqldump --user=" & IDUsuario.Text & " --password=" & Password.Text & " -h " & Server.Text & " " & Dato1 & " < """ + DbFile1 + """")

                BackupStream.Close()
                BackupProccess.WaitForExit()
                BackupProccess.Close()

                MsgBox("Base de Datos Restaurada", vbInformation, "Restauracion Exitosa")
            End If

        Catch ex As Exception
            MsgBox("Error" + ex.ToString + "", vbCritical, "Error")
        End Try
    End Sub

    Private Sub BD_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
