Public Class ModoCierre

    Private Sub Modo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Modo.SelectedIndexChanged
        If (Modo.SelectedIndex = -1) Then
        Else

        End If

        If (Modo.SelectedItem = "Cambio de Dinero") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Hora Colación") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Productos Fuera Stock") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Necesidades Basicas") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Reponer Productos") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Otra Petición") Then
            Aceptar.Enabled = True
        ElseIf (Modo.SelectedItem = "Cierre Caja del Dia") Then
            Aceptar.Enabled = True
        Else
            Aceptar.Enabled = False
        End If

    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        Consulta("Call GrabaCierre ('" & (Entrada.TxtUsuarios.Text) & "','" & (Modo.Text) & "','" & (Format(Now, "dd/MM/yyyy")) & "','" & (Now.ToLongTimeString) & "')")
        MsgBox("Cierre de Caja Exitoso, Gracias por Preferirnos", vbInformation, "Cierre Caja")

        Me.Close()
        Entrada.Ver.Enabled = False
        Entrada.TxtClave.Enabled = False
        Entrada.Aceptar.Enabled = False
        Entrada.Show()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()

        Bienvenido9.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class