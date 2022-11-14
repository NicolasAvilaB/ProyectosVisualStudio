Imports System.Net
Public Class CierreSesion
    Private Sub gr_Click(sender As Object, e As EventArgs) Handles gr.Click
        If (descr.Text = "") Then
            MsgBox("Error: Describa en el Campo Descripcion sobre Porque esta Cerrando la Sesion", vbCritical, "Error de Descripcion Vacia")
            descr.Focus()
            descr.Select()
        Else
            Dim mifecha As Date = Format(Now, "dd/MM/yyyy")
            Dim mifecha2 As String = mifecha.ToString("yyyy-MM-dd")
            Dim i2 As Integer
            Consulta2("Call GeneradorIDautomaticoCierre")
            If TypeOf (DS2.Tables(DT2.TableName).Rows(0).Item("ID")) Is DBNull Then
                i2 = 1
            Else
                i2 = DS2.Tables(DT2.TableName).Rows(0).Item("ID") + 1
                Conexion.Close()
            End If
            Dim valorIp As String
            valorIp = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString()
            Consulta2("Call Ingreso_Cierre_Sesion ('" & (i2) & "','" & (InicioSesion.nombre.Text) & "','" & (descr.Text) & "','" & (valorIp) & "','" & (My.Computer.Name.ToString) & "','" & (Now.ToLongTimeString) & "','" & (mifecha2) & "')")
            MsgBox("Has Cerrado Sesion Exitosamente", vbInformation, "Cierre de Sesion Exitoso")
            MsgBox("Gracias por Preferir Software Bodega Municipalidad de Peralillo", vbInformation, "Cierre de Sesion Exitoso")
            descr.Clear()
            Me.Close()
            RegistrosFichas.Close()
            InicioSesion.nombre.Clear()
            InicioSesion.clave.Clear()
            InicioSesion.Ver.Text = "Mostrar"
            InicioSesion.clave.PasswordChar = "*"
            InicioSesion.nombre.Focus()
            InicioSesion.nombre.Select()
            InicioSesion.Show()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
        descr.Clear()
        Me.Close()
    End Sub
    Private Sub vuo_Click(sender As Object, e As EventArgs) Handles vuo.Click
        MsgBox("Cancelaste la Operacion", vbExclamation, "Operacion Cancelada")
        descr.Clear()
        Me.Close()
    End Sub
    Private Sub descr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles descr.KeyPress
        If InStr(1, "'" & Chr(8), e.KeyChar) = 1 Then
            e.KeyChar = ""
        End If
    End Sub
End Class