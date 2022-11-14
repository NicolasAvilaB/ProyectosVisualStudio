Public Class Bienvenido9

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Dim esult As String
        esult = MsgBox("¡Advertencia Saldras sin Haber Cerrado la Caja, ¿Seguro Que Quieres Salir?", vbExclamation + vbOKCancel, "Salir")
        If esult = vbOK Then
            Entrada.Ver.Enabled = False
            Entrada.TxtClave.Enabled = False
            Entrada.Aceptar.Enabled = False
            Conexion.Close()
            Entrada.Ver.Text = "Ver"
            Entrada.TxtClave.PasswordChar = "*"
            Me.Close()
            Entrada.Show()
        Else
        End If

    End Sub

    Private Sub Emitir_Boletas_Click(sender As Object, e As EventArgs) Handles Emitir_Boletas.Click
        Me.Hide()
        EmitirBoletas.Show()
        EmitirBoletas.Tabaco.Enabled = True
        EmitirBoletas.Agregue_Productos.Focus()
    End Sub

    Private Sub Bienvenido9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CierreCajero_Click(sender As Object, e As EventArgs) Handles CierreCajero.Click
        Dim esult As String
        esult = MsgBox("Estas a Punto de Cerrar La Caja, ¿La Cerraras?", vbExclamation + vbOKCancel, "Cierre Caja")
        If esult = vbOK Then
            Entrada.Ver.Text = "Ver"
            Entrada.TxtClave.PasswordChar = "*"
            Me.Close()
            ModoCierre.Show()
        Else
        End If

    End Sub

   
End Class