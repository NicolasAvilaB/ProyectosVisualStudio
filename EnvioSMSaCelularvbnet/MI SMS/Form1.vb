
Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ButtonENVIAR.Visible = False 'PARA EVITAR ERRORES (ENVIO SIN  CONEXION)
        CheckForIllegalCrossThreadCalls = False 'PARA PODER UTILIZAR EL TEXTBOX MODEM
    End Sub
    Private Sub ButtonCONECTAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCONECTAR.Click
        Try
            SerialPort1.PortName = TextBoxPUERTO.Text 'DEFINE EL PUERTO DE CONEXION
            SerialPort1.Open() 'ABRE EL PUERTO
            ButtonCONECTAR.Visible = False 'PARA EVITAR ERRORES (DOBLE CONEXION)
            ButtonENVIAR.Visible = True 'PARA EVITAR ERRORES (ENVIO SIN  CONEXION)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ButtonENVIAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonENVIAR.Click
        Try
            TextBoxMODEM.Clear() 'NUEVO MENSAJE
            SerialPort1.Write("AT" & vbCrLf) 'COMPRUEBA LA CONEXION CON EL MODEM
            Threading.Thread.Sleep(100)
            SerialPort1.Write("AT+CMGF=1" & vbCrLf) 'INDICA QUE VA A ENVIAR SMS
            Threading.Thread.Sleep(100)
            SerialPort1.Write("AT+CMGS=" & Chr(34) & TextBoxNUMERO.Text & Chr(34) & vbCrLf) 'ENVIARA EL MENSAJE SIN ALMACENAMIENTO
            Threading.Thread.Sleep(100)
            SerialPort1.Write(TextBoxTEXTO.Text & Chr(26)) ' ENVIA EL MENSAJE
            MsgBox("ENVIADO")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TextBoxTEXTO_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxTEXTO.TextChanged
        'COMPRUEBA QUE EL TEXTO NO SUPERE LOS 140 CARACTERES
        Dim RESTO As Integer = 140 - TextBoxTEXTO.TextLength
        LabelRESTO.Text = RESTO
        If RESTO < 0 Then
            MsgBox("TEXTO MAYOR DE 140 CARACTERES")
        End If
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'RECIBE LA INFORMACION DEL MODEM Y LA PONE EN EL TEXTBOX
        Dim RECIBIDO As String = Convert.ToString(SerialPort1.ReadExisting)
        TextBoxMODEM.Text += RECIBIDO & vbCrLf
    End Sub
End Class
