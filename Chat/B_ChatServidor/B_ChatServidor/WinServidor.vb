Imports System.IO
Imports GTOServerClient

Public Class WinServidor
    Dim WithEvents uptServidor As New Servidor(5055, "192.168.1.50")

    Private Sub btnServerUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServerUpdate.Click
        If uptServidor.IsConnected Then
            If uptServidor.Stopping Then
                lblState.Text = "..."
                btnServerUpdate.Text = "Iniciar Servidor"
            Else
                lblState.Text = "Error"
            End If
        Else
            If uptServidor.Begin() Then
                lblState.Text = "Iniciado"
                btnServerUpdate.Text = "Detener"
            Else
                lblState.Text = "Error"
            End If
        End If
    End Sub

    Private Sub WinUpdateServidor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        uptServidor.Stopping()

    End Sub


    Private Sub WinUpdateServidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad de texto en un control TextBox.
    Delegate Sub SetTextCallback_CountClient(ByVal [text] As String)
    Private Sub addText_CountClient(ByVal [text] As String)
        Try


            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.lblCountClientes.InvokeRequired Then
                Dim d As New SetTextCallback_CountClient(AddressOf addText_CountClient)
                Me.Invoke(d, New Object() {[text]})
            Else
                Me.lblCountClientes.Text = text
                '  Me.lstPanelMensajes1.Items.Add([text])
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad de texto en un control TextBox.
    Delegate Sub SetTextCallback(ByVal [text] As String, ByVal IsError As Boolean)
    Private Sub addText(ByVal [text] As String, ByVal IsError As Boolean)
        Try


            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.lstPanelMensajes.InvokeRequired Then
                Dim d As New SetTextCallback(AddressOf addText)
                Me.Invoke(d, New Object() {[text], IsError})
            Else
                Dim el As New ListViewItem([text])
                If IsError Then
                    el.ForeColor = Color.Red
                End If

                Me.lstPanelMensajes.Items.Add(el)
                '  Me.lstPanelMensajes1.Items.Add([text])
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ClearText()
        Me.lstPanelMensajes.Items.Clear()
    End Sub

    Private Sub uptServidor_FileRecibido(ByVal IPTerminal As String, ByVal Pathfile As String, ByVal recbSize As Integer) Handles uptServidor.FileRecibido
        Try
            Dim file As New FileInfo(Pathfile)
            addText("File recibido: " & file.Name & ", Tamaño en byte: " & recbSize.ToString, False)
        Catch ex As Exception
            addText("Evento File recibido:" & ex.Message, True)
        End Try
    End Sub
    Private Sub uptServidor_MensajeRecibido(ByVal IPTerminal As String, ByVal msj As String) Handles uptServidor.MensajeRecibido
        addText("Mensaje recibido: " & IPTerminal & ",  " & msj, False)
    End Sub


    Private Sub uptServidor_IniciarServidor() Handles uptServidor.IniciarServidor
        addText("Servidor iniciado.... ", False)
    End Sub
    Private Sub uptServidor_NuevaConexion(ByVal IPCliente As String, ByVal port As String) Handles uptServidor.NuevaConexion
        addText("Nueva conexion : IP:" & IPCliente & ",  Puerto:" & port, False)

    End Sub
    Private Sub uptServidor_DetenerServidor() Handles uptServidor.DetenerServidor
        addText("Servidor detenido.... ", False)
    End Sub
    Private Sub uptServidor_ConexionTerminada(ByVal IPCliente As String) Handles uptServidor.ConexionTerminada
        addText("Conexion terminada.... " & IPCliente, False)
    End Sub
    Private Sub uptServidor_ChangueCountConnection(ByVal count As Integer) Handles uptServidor.ChangueCountConnection
        addText_CountClient(uptServidor.CountCliente.ToString)
    End Sub
    Private Sub uptServidor_ObjetoRecibidos(ByVal IPCliente As String, ByVal obj As Object) Handles uptServidor.ObjetoRecibido
        addText("Objeto recibido: " & IPCliente & " ," & obj.ToString, False)

    End Sub
    Private Sub uptServidor_ErrorServidor(ByVal ErrorMensaje As String) Handles uptServidor.ErrorServidor
        addText(ErrorMensaje, True)
    End Sub


    Private Sub btnTransData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransData.Click
        Dim WinChat As New WinChat
        WinChat.uptServidor = uptServidor
        WinChat.ShowDialog()
    End Sub


    Private Sub uptServidor_ObjetoEnviado(ByVal IPTerminal As String, ByVal obj As Object) Handles uptServidor.ObjetoEnviado

    End Sub
End Class
