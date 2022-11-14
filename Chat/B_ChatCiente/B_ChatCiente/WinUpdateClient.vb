Imports GTOServerClient
Imports System.IO

Public Class WinUpdateClient
    Dim WithEvents uptClient As New GTOServerClient.Cliente()

    Private isSendFile As Boolean
    Private _PathFiles() As String


  
    Private Sub WinUpdateClient_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        uptClient.Cerrar()

    End Sub

    Private Sub WinUpdateClient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        uptClient.PathDirectoryTemp = Application.StartupPath & "\Temp"
        uptClient.PuertoDelHost = 5055
        uptClient.IPDelHost = txtIP.Text

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClient.Click
        If uptClient.IsConnected Then
            uptClient.Cerrar()
        Else
            uptClient.IPDelHost = txtIP.Text
            uptClient.Conectar()
        End If

    End Sub



    Private Sub uptClient_FileEnviado(ByVal file As String, ByVal sizeByte As Integer) Handles uptClient.FileEnviado
        addText("File enviado: " & file & ", Tamaño en byte: " & sizeByte.ToString, False)
    End Sub

    Private Sub uptClient_FileRecibido(ByVal Pathfile As String, ByVal recbSize As Integer) Handles uptClient.FileRecibido
        Try
            Dim file As New IO.FileInfo(Pathfile)
            addText("File recibido: " & file.Name & ", Tamaño en byte: " & recbSize.ToString, False)
        Catch ex As Exception
            addText("Evento File recibido:" & ex.Message, True)
        End Try

    End Sub

    Private Sub uptClient_ObjetoEnviado(ByVal dato As Object) Handles uptClient.ObjetoEnviado
        addText("Objeto enviado: " & dato.ToString, False)

    End Sub

    Private Sub uptClient_ObjetoRecibido(ByVal dato As Object) Handles uptClient.ObjetoRecibido
        addText("Objeto recibido: " & dato.ToString, False)
    End Sub

    Private Sub uptClient_ConexionIniciada() Handles uptClient.ConexionIniciada
        addText("Conexion iniciada...: ", False)
        TextButtonClient("Desconectar")
    End Sub

    Private Sub uptClient_ConexionTerminada() Handles uptClient.ConexionTerminada
        addText("Conexion terminada.... ", False)
        TextButtonClient("Conectar")
    End Sub


    Private Sub uptClient_ErrorCliente(ByVal ErrorMensaje As String) Handles uptClient.ErrorCliente
        addText(ErrorMensaje, True)
    End Sub


    Private Sub btnMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsg.Click
        If uptClient.IsConnected Then
            If txtMensaje.Text <> "" And Not txtMensaje.Text Is Nothing Then
                If isSendFile Then
                    uptClient.EnviarFile(_PathFiles)
                    lblArchivo.Text = "..."
                    isSendFile = False
                    _PathFiles = Nothing
                Else
                    uptClient.EnviarMensaje(txtMensaje.Text)
                End If
                txtMensaje.Text = ""
            End If
        End If

    End Sub

    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad de texto en un control TextBox.
    Delegate Sub TextButtonClient_Callback(ByVal value As String)
    Private Sub TextButtonClient(ByVal value As String)
        Try
            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.btnClient.InvokeRequired Then
                Dim d As New TextButtonClient_Callback(AddressOf TextButtonClient)
                Me.Invoke(d, New Object() {value})
            Else
                Me.btnClient.Text = value
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad de texto en un control TextBox.
    Delegate Sub EnableButtonSend_Callback(ByVal value As Boolean)
    Private Sub EnableButtonSend(ByVal value As Boolean)
        Try
            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.btnMsg.InvokeRequired Then
                Dim d As New EnableButtonSend_Callback(AddressOf EnableButtonSend)
                Me.Invoke(d, New Object() {value})
            Else
                Me.btnMsg.Enabled = value
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
                Me.lstPanelMensajes.Invoke(d, New Object() {[text], IsError})
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

    Private Sub btnSendFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendFile.Click
        Using oFDFiles As New OpenFileDialog
            oFDFiles.Filter = "Todos los archivos|*.*|Comprimido|*.zip|Ejecutable|*.exe|Libreria de clases|*.dll|Archivos Txt|*.txt"
            oFDFiles.Multiselect = True
            oFDFiles.Title = "Files Update"
            oFDFiles.AutoUpgradeEnabled = False
            If oFDFiles.ShowDialog = Windows.Forms.DialogResult.OK Then
                For k As Integer = 0 To oFDFiles.SafeFileNames.Length - 1
                    lblArchivo.Text = lblArchivo.Text & ", " & oFDFiles.SafeFileNames(k)
                    txtMensaje.Text = lblArchivo.Text
                Next
                _PathFiles = oFDFiles.FileNames
                isSendFile = True
            End If
        End Using
    End Sub

    Private Sub txtMensaje_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMensaje.TextChanged
        If txtMensaje.Focused Then
            If txtMensaje.Text = "" Then
                If lblArchivo.Text <> "..." Then
                    lblArchivo.Text = "..."
                    isSendFile = False
                    _PathFiles = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub uptClient_MensajeEnviado(ByVal msj As String) Handles uptClient.MensajeEnviado
        addText(msj, False)
    End Sub

    Private Sub uptClient_MensajeRecibido(ByVal msj As String) Handles uptClient.MensajeRecibido
        addText(msj, False)
    End Sub

    Private Sub uptClient_IsSocketBusyChanged(ByVal _IsSocketBusy As Boolean) Handles uptClient.IsSocketBusyChanged
        EnableButtonSend(Not _IsSocketBusy)
    End Sub

 
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub uptClient_StartTransactionData(ByVal SizeBytes As Integer, ByVal TypeData As GTOServerClient.TypeData) Handles uptClient.StartTransactionData
        addControlPrgBar(SizeBytes / 100, 1)
    End Sub

    Private Sub uptClient_ProcessTransactionData(ByVal CountPackage As Integer, ByVal SizeBytes As Integer) Handles uptClient.ProcessTransactionData
        addValuePrgBar(SizeBytes / 100)
    End Sub

    Private Sub uptClient_EndTransactionData(ByVal SizeBytes As Integer, ByVal TypeData As GTOServerClient.TypeData) Handles uptClient.EndTransactionData
        addVisiblePrgBar(False)
    End Sub


    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad  .
    Delegate Sub SetControlPrgBarCallback(ByVal maxValue As Integer, ByVal minValue As Integer)
    Private Sub addControlPrgBar(ByVal maxValue As Integer, ByVal minValue As Integer)
        Try


            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.pgbLoadFile.InvokeRequired Then
                Dim d As New SetControlPrgBarCallback(AddressOf addControlPrgBar)
                Me.pgbLoadFile.Invoke(d, New Object() {maxValue, minValue})
            Else
                Me.pgbLoadFile.Maximum = maxValue
                Me.pgbLoadFile.Minimum = minValue
                Me.pgbLoadFile.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad  .
    Delegate Sub SetValuePrgBarCallback(ByVal Value As Integer)
    Private Sub addValuePrgBar(ByVal Value As Integer)
        Try
 
            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.pgbLoadFile.InvokeRequired Then
                Dim d As New SetValuePrgBarCallback(AddressOf addValuePrgBar)
                Me.pgbLoadFile.Invoke(d, New Object() {Value})
            Else

                Me.pgbLoadFile.Value = Value
          
                Me.pgbLoadFile.Invalidate()
            End If
        Catch ex As Exception

        End Try
    End Sub
    'Este delegado permite realizar llamadas asíncronas para establecer la propiedad  .
    Delegate Sub SetVisiblePrgBarCallback(ByVal Value As Boolean)
    Private Sub addVisiblePrgBar(ByVal Value As Boolean)
        Try

            ' InvokeRequired required compares the thread ID of the
            ' calling thread to the thread ID of the creating thread.
            ' If these threads are different, it returns true.
            If Me.pgbLoadFile.InvokeRequired Then
                Dim d As New SetVisiblePrgBarCallback(AddressOf addVisiblePrgBar)
                Me.pgbLoadFile.Invoke(d, New Object() {Value})
            Else

                Me.pgbLoadFile.Visible = Value

                Me.pgbLoadFile.Invalidate()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
