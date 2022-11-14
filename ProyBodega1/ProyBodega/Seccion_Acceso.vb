Public Class Seccion_Acceso
    Dim VarSeleccion As Integer
    Dim Dato1, Dato2, Dato3 As String
    Dim nomm As String
    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        Me.Close()
    End Sub
    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        VarSeleccion = 1
        nomali.Enabled = True
        clav.Enabled = True
        nomali.ReadOnly = False
        clav.ReadOnly = False
        guardar.Enabled = True
        busque_alias.Enabled = False
        busque_alias.ReadOnly = True
        guardar.Enabled = True
        nuevo.Enabled = False
        eliminar.Enabled = False
        Grilla_Acceso.Enabled = False
        Grilla_Acceso.ReadOnly = True
        nomali.Clear()
        clav.Clear()
        nomali.Focus()
        nomali.Select()
        SendKeys.Send("{BACKSPACE}")
        cancelar.Enabled = True
        nuevo.Focus()
        nuevo.Select()
        Consulta("Call GeneradorIDautomatico2")
        If TypeOf (DS.Tables(DT.TableName).Rows(0).Item("ID")) Is DBNull Then
            Label6.Text = 1
        Else
            Label6.Text = DS.Tables(DT.TableName).Rows(0).Item("ID") + 1
            Conexion.Close()
        End If
        Actualizacion_Tabla()
        Mostrar_Grilla()
    End Sub
    Sub Actualizacion_Tabla()
        Consulta("Call Grilla_Acceso")
    End Sub
    Sub Mostrar()
        If (DS.Tables(DT.TableName).Rows.Count > 0) Then
            Dato1 = Grilla_Acceso.CurrentRow.Cells(1).EditedFormattedValue.ToString
            Dato2 = Grilla_Acceso.CurrentRow.Cells(2).EditedFormattedValue.ToString
            Dato3 = Grilla_Acceso.CurrentRow.Cells(0).EditedFormattedValue.ToString
            nomali.Text = Dato1
            clav.Text = Dato2
            Label6.Text = Dato3
        Else
            nomali.Clear()
            clav.Clear()
            Label6.Text = "0"
        End If
    End Sub
    Sub Mostrar_Grilla()
        Grilla_Acceso.DataSource = DS.Tables(DT.TableName)
        Conexion.Close()
    End Sub
    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        nomali.Enabled = False
        clav.Enabled = False
        nomali.ReadOnly = True
        clav.ReadOnly = True
        guardar.Enabled = False
        busque_alias.Enabled = True
        busque_alias.ReadOnly = False
        guardar.Enabled = False
        nuevo.Enabled = True
        eliminar.Enabled = True
        Grilla_Acceso.Enabled = True
        Grilla_Acceso.ReadOnly = True
        cancelar.Enabled = False
        clav.PasswordChar = "*"
        nuevo.Focus()
        nuevo.Select()
        Mostrar()
        If (Me.Grilla_Acceso.Rows.Count = 0) Then
            nomali.Clear()
            clav.Clear()
        End If
    End Sub
    Private Sub Seccion_Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizacion_Tabla()
        Mostrar_Grilla()
        Mostrar()
        nuevo.Focus()
        nuevo.Select()
        If Me.Grilla_Acceso.Rows.Count = 0 Then
            eliminar.Enabled = False
        Else
            eliminar.Enabled = True
        End If
    End Sub
    Private Sub busque_alias_TextChanged(sender As Object, e As EventArgs) Handles busque_alias.TextChanged
        If (busque_alias.Text = "") Then
            Actualizacion_Tabla()
            Mostrar_Grilla()
            Mostrar()
        Else
            Consulta("Call Busque_Alias('" & (busque_alias.Text & "%") & "')")
            If DS.Tables(DT.TableName).Rows.Count > 0 Then
                Grilla_Acceso.DataSource = DS.Tables(DT.TableName)
                Mostrar()
            Else
                nomali.Clear()
                clav.Clear()
            End If
        End If
    End Sub
    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        If (nomali.Text = "") Then
            MsgBox("Error: No se ha Describido un Nombre o Alias Valido", vbCritical, "¡Error, Alias no Especificado!")
            nomali.Focus()
            nomali.Select()
        ElseIf (clav.Text = "") Then
            MsgBox("Error: No se ha Describido una Clave Valida", vbCritical, "¡Error, Clave no Describida!")
            clav.Focus()
            clav.Select()
        Else
            If (Me.Grilla_Acceso.Rows.Count = 0) Then
                Dato1 = Nothing
            Else
                Dato1 = Grilla_Acceso.CurrentRow.Cells(1).EditedFormattedValue.ToString
            End If
            For Each row As DataGridViewRow In Grilla_Acceso.Rows
                nomm = row.Cells(1).Value
            Next
            If (nomm = nomali.Text) Then
                MsgBox("El Alias: " + nomali.Text + " Ya Existe En El Registro.", vbCritical, "Error Alias Ya Existente")
                nomali.Clear()
                nomali.Focus()
                nomali.Select()
            ElseIf (Dato1 = nomali.Text) Then
                MsgBox("El Alias: " + nomali.Text + " Ya Existe En El Registro.", vbCritical, "Error Alias Ya Existente")
                nomali.Clear()
                nomali.Focus()
                nomali.Select()
            ElseIf VarSeleccion = 1 Then
                Try
                    Consulta("Call Ingreso_Alias ('" & (Label6.Text) & "','" & (nomali.Text) & "','" & (clav.Text) & "')")
                    MsgBox("Datos Ingresados Exitosamente", vbInformation, "Ingreso de Datos Exitoso")
                    nomali.Enabled = False
                    clav.Enabled = False
                    nomali.ReadOnly = True
                    clav.ReadOnly = True
                    guardar.Enabled = False
                    nuevo.Enabled = True
                    eliminar.Enabled = True
                    busque_alias.Enabled = True
                    busque_alias.ReadOnly = False
                    Grilla_Acceso.Enabled = True
                    cancelar.Enabled = False
                    nomali.Enabled = False
                    clav.Enabled = False
                    nomali.ReadOnly = True
                    clav.ReadOnly = True
                    nuevo.Focus()
                    nuevo.Select()
                    clav.PasswordChar = "*"
                    Grilla_Acceso.ReadOnly = True
                Catch ex As Exception
                    DA.SelectCommand = SC
                    DA.Fill(DT)
                End Try
                Actualizacion_Tabla()
                Mostrar_Grilla()
                Mostrar()
            End If
        End If
    End Sub
    Private Sub busque_alias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busque_alias.KeyPress
        busque_alias.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub Grilla_Acceso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grilla_Acceso.CellClick
        Mostrar()
    End Sub
    Private Sub nomali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nomali.KeyPress
        nomali.CharacterCasing = CharacterCasing.Upper
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            clav.Focus()
            clav.Select()
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        SolictudContraseña_Admin2.Owner = Me
        SolictudContraseña_Admin2.ShowDialog()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Grilla_Acceso_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles Grilla_Acceso.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub clav_KeyPress(sender As Object, e As KeyPressEventArgs) Handles clav.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            guardar.Focus()
            guardar.Select()
            SendKeys.Send("{ENTER}")
        End If
    End Sub
    Private Sub Grilla_Acceso_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Grilla_Acceso.CellFormatting
        If e.ColumnIndex = 2 Then
            On Error Resume Next
            e.Value = New String("*"c, e.Value.ToString.Length)
        End If
    End Sub
    Private Sub Grilla_Acceso_Click(sender As Object, e As EventArgs) Handles Grilla_Acceso.Click
        Mostrar()
    End Sub
    Private Sub Seccion_Acceso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Administrador.nombr.Enabled = False
        Administrador.cla.Enabled = False
        Administrador.nombr.ReadOnly = True
        Administrador.cla.ReadOnly = True
        Administrador.busque_admin.Enabled = True
        Administrador.busque_admin.ReadOnly = False
        Administrador.guardar.Enabled = False
        Administrador.nuevo.Enabled = True
        Administrador.eliminar.Enabled = True
        Administrador.Grilla_Administrador.Enabled = True
        Administrador.Grilla_Administrador.ReadOnly = True
        Administrador.cancelar.Enabled = False
        Administrador.nuevo.Focus()
        Administrador.nuevo.Select()
        Administrador.Actualizacion_Tabla()
        Administrador.Mostrar_Grilla()
        Administrador.Mostrar()
    End Sub
End Class