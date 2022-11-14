Imports GTOServerClient

Public Class WinChat

    Private isSendFile As Boolean
    Private _uptServidor As Servidor
    Private _PathFiles() As String

    Public Property uptServidor() As Servidor
        Get
            Return _uptServidor
        End Get
        Set(ByVal value As Servidor)
            _uptServidor = value
            AddHandler _uptServidor.ObjetoEnviado, AddressOf ObjetoEnviado
            AddHandler _uptServidor.ObjetosEnviados, AddressOf ObjetosEnviados
            AddHandler _uptServidor.ObjetoRecibido, AddressOf ObjetoRecibido

            AddHandler _uptServidor.FileEnviado, AddressOf FileEnviado
            AddHandler _uptServidor.FileEnviados, AddressOf FileEnviados
            AddHandler _uptServidor.FileRecibido, AddressOf FileRecibido

            AddHandler _uptServidor.MensajeEnviado, AddressOf MensajeEnviado
            AddHandler _uptServidor.MensajesEnviados, AddressOf MensajesEnviados
            AddHandler _uptServidor.MensajeRecibido, AddressOf MensajeRecibido

        End Set
    End Property

    Private Sub ObjetoEnviado(ByVal IPTerminal As String, ByVal obj As Object)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPTerminal = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    addText(obj.ToString, False)
                End If

            End If

        End If

    End Sub

    Private Sub ObjetosEnviados(ByVal obj As Object)
        If Me.Visible Then
            addText(obj.ToString, False)
        End If

    End Sub

    Private Sub ObjetoRecibido(ByVal IPCliente As String, ByVal obj As Object)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPCliente = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    addText(obj.ToString, False)
                End If
            End If

        End If


    End Sub

    Private Sub FileEnviado(ByVal IPTerminal As String, ByVal Pathfile As String, ByVal recbSize As Integer)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPTerminal = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    addText("File enviado: " & Pathfile & ", Tamaño en byte: " & recbSize.ToString, False)
                End If
            End If


        End If

    End Sub

    Private Sub FileEnviados(ByVal file As String, ByVal sizeByte As Integer)
        If Me.Visible Then
            addText("File enviado a todos: " & file & ", Tamaño en byte: " & sizeByte.ToString, False)
        End If

    End Sub

    Private Sub FileRecibido(ByVal IPCliente As String, ByVal Pathfile As String, ByVal recbSize As Integer)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPCliente = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    Try
                        Dim file As New IO.FileInfo(Pathfile)
                        addText("File recibido: " & file.Name & ", Tamaño en byte: " & recbSize.ToString, False)
                    Catch ex As Exception
                        addText("Evento File recibido:" & ex.Message, True)
                    End Try

                End If
            End If

        End If


    End Sub

    Private Sub MensajeEnviado(ByVal IPTerminal As String, ByVal msj As String)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPTerminal = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    addText(msj, False)
                End If
            End If


        End If

    End Sub

    Private Sub MensajesEnviados(ByVal msj As String)
        If Me.Visible Then
            addText(msj, False)
        End If

    End Sub

    Private Sub MensajeRecibido(ByVal IPCliente As String, ByVal msj As String)
        If Me.Visible Then
            If dtgClientes.RowCount > 0 Then
                If IPCliente = dtgClientes.SelectedRows(0).Cells(0).Value.ToString Then
                    addText(msj, False)
                End If
            End If

        End If


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

    Private Sub btnMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMsg.Click
        If _uptServidor.IsConnected Then

            If _uptServidor.Clientes.Count > 0 Then
                If txtMensaje.Text <> "" And Not txtMensaje.Text Is Nothing Then

                    If chbAll.Checked Then
                        If isSendFile Then
                            _uptServidor.EnviarFiles(_PathFiles)
                            lblArchivo.Text = "..."
                            isSendFile = False
                            _PathFiles = Nothing
                        Else
                            _uptServidor.EnviarMensajes(txtMensaje.Text)
                        End If
                    Else
                        If dtgClientes.RowCount > 0 Then
                            Dim IPCliente As String = dtgClientes.SelectedRows(0).Cells(0).Value.ToString
                            If isSendFile Then
                                _uptServidor.EnviarFile(IPCliente, _PathFiles, True)
                                lblArchivo.Text = "..."
                                isSendFile = False
                                _PathFiles = Nothing
                            Else
                                _uptServidor.EnviarMensaje(IPCliente, txtMensaje.Text)
                            End If
                        End If


                    End If
                    txtMensaje.Text = ""
                End If


            End If
        End If

    End Sub




    Private Sub WinTransactionData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDataGridView(_uptServidor.Clientes)
    End Sub


    Public Sub BindDataGridView(ByVal ht As Hashtable)
        Dim dt As New DataTable("TestValues")
        'now build our table
        dt.Columns.Add("IP", System.Type.GetType("System.String"))
        dt.Columns.Add("value", System.Type.GetType("System.String"))
        'use iDictionaryEnumerator to get an enumerator for the Hashtable
        Dim enumerator As IDictionaryEnumerator = ht.GetEnumerator()
        Dim row As DataRow
        'now make sure we have records in our enumerator

        While (enumerator.MoveNext())
            'populate our DataTable

            Dim index As String = enumerator.Key.ToString

            Dim value As String = enumerator.Value.ToString

            row = dt.NewRow()
            row("IP") = index
            row("value") = value

            dt.Rows.Add(row)

        End While

        'bind our DataGridView

        dtgClientes.DataSource = dt
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        BindDataGridView(_uptServidor.Clientes)
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
                End If
            End If
        End If
    End Sub
End Class