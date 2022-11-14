Public Class Bienvenido9

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Dim esult As String
        esult = MsgBox("¡Advertencia Saldras sin Haber Cerrado la Caja, ¿Seguro Que Quieres Salir?", vbOKCancel, "Salir")
        If esult = vbOK Then
            Conexion.Close()
            Me.Close()
            Entrada.Show()
        Else
        End If

    End Sub

    Private Sub Emitir_Boletas_Click(sender As Object, e As EventArgs) Handles Emitir_Boletas.Click
        Me.Hide()
        EmitirBoletas.Show()

    End Sub

    Private Sub Bienvenido9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CierreCajero_Click(sender As Object, e As EventArgs) Handles CierreCajero.Click
        Dim esult As String
        esult = MsgBox("Estas a Punto de Cerrar La Caja, ¿La Cerraras?", vbOKCancel, "Cierre Caja")
        If esult = vbOK Then
            MsgBox("Caja Cerrada, Gracias Por Trabajar Con Nosotros", vbInformation, "Cierre Exitoso")
            Conexion.Close()
            Me.Close()
            Entrada.Show()
        Else
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim esult As String
        esult = MsgBox("Iniciaras el Modo de Cajeros Experimental, ¿Deseas Continuar?", vbOKCancel, "Modo Prueba Experimental")
        If esult = vbOK Then
            MsgBox("Bienvenido Porfavor Proceda Con Cuidado A Continuacion", vbExclamation, "Modo Prueba Experimental")
            Conexion.Close()
            Me.Close()
            ModoPrueba.Show()
        Else
            MsgBox("A Cancelado La Operacion", vbExclamation, "Cancelado")
        End If
    End Sub
End Class