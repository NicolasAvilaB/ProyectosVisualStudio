

Public Class Ficha_Atencion

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Volv.Click
        Me.Close()
        Menu2.Show()
    End Sub


    ' Sub muestre()

    'Consulta("select * from reservas where rut_cliente='" & (Rutes.Text) & "'")
    'If DS.Tables(DT.TableName).Rows.Count = 1 Then
    'Dim row As DataRow = DT.Rows(0)
    '   Fecha.Text = CStr(row("fecha_reserva"))
    '   Horar.Text = CStr(row("hora"))
    'End If

    ' End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Rutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Rutes.SelectedIndexChanged
        If (Rutes.Text = "") Then
            Nombre.Text = Nothing
            Edad.Text = Nothing
            Telefono.Text = Nothing
            Fecha.Text = Nothing
            N_Hijos.Text = Nothing
            Ciudad.Text = Nothing
            Email.Text = Nothing
        Else
            Consulta("select * from pacientes where rut='" & (Rutes.Text) & "'")

            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)
                Nombre.Text = CStr(row("nombre"))
                Edad.Text = CStr(row("edad"))
                Telefono.Text = CStr(row("telefono"))
                N_Hijos.Text = CStr(row("nhijos"))
                Ciudad.Text = CStr(row("ciudad"))
                Email.Text = CStr(row("email"))

            End If
            Consulta("select * from reservas where rut_cliente='" & (Rutes.Text) & "'")
            If DS.Tables(DT.TableName).Rows.Count = 1 Then
                Dim row As DataRow = DT.Rows(0)

                Fecha.Text = CStr(row("fecha_reserva"))
                Horar.Text = CStr(row("hora"))
            Else
                Fecha.Text = Nothing
                Horar.Text = Nothing

            End If
        End If
    End Sub

    Private Sub Ficha_Atencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Consulta("SELECT DISTINCT rut FROM pacientes where medico ='" & (SeleccionMedico.Label3.Text) & "'")
            Rutes.SelectedIndex = -1
            Dim dt As DataTable = New DataTable("pacientes")
            DA.Fill(dt)
            With Rutes
                .DataSource = dt
                .DisplayMember = "rut"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Rutes.SelectedIndex = -1
        Horar.Text = Nothing
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click


        If (Fecha.Text = "") Then
            MsgBox("Porfavor Haga la Reserva de Fecha Correspondiente", vbCritical, "Error Fatal")
            Enfermedad.Focus()
            Enfermedad.Select()
        ElseIf (Horar.Text = "") Then
            MsgBox("Porfavor Haga la Reserva de Hora Correspondiente", vbCritical, "Error Fatal")
            Enfermedad.Focus()
            Enfermedad.Select()
        ElseIf (Enfermedad.Text = "") Then
            MsgBox("Error: Enfermedad No Especificada", vbCritical, "Error Fatal")
            Enfermedad.Focus()
            Enfermedad.Select()
        ElseIf (Medicamentos.Text = "") Then
            MsgBox("Error: Medicamentos No Especificados", vbCritical, "Error Fatal")
            Medicamentos.Focus()
            Medicamentos.Select()
        ElseIf (Antecedentes.Text = "") Then
            MsgBox("Error: Antecedentes No Especificados", vbCritical, "Error Fatal")
            Antecedentes.Focus()
            Antecedentes.Select()
        ElseIf (Tratamiento.Text = "") Then
            MsgBox("Error: Tratamiento No Especificado", vbCritical, "Error Fatal")
            Tratamiento.Focus()
            Tratamiento.Select()
        ElseIf (MotivodeConsulta.Text = "") Then
            MsgBox("Error: El Motivo de la Consulta No Esta Especificado", vbCritical, "Error Fatal")
            MotivodeConsulta.Focus()
            MotivodeConsulta.Select()
        Else
            Try
                Consulta("insert into fichas (rut, nombre_paciente, edad, telefono, fecha , hora ,numero_hijos,ciudad,email,enfermedad,medicamentos,antecedentes,tratamiento,consulta) values ('" & (Rutes.Text) & "','" & (Nombre.Text) & "', '" & (Edad.Text) & "','" & (Telefono.Text) & "','" & (Fecha.Text) & "','" & (Horar.Text) & "','" & (N_Hijos.Text) & "','" & (Ciudad.Text) & "','" & (Email.Text) & "','" & (Enfermedad.Text) & "','" & (Medicamentos.Text) & "','" & (Antecedentes.Text) & "','" & (Tratamiento.Text) & "','" & (MotivodeConsulta.Text) & "') ")
                MsgBox("Datos Guardados Correctamente", vbInformation, "Inserto Exitoso")
            Catch ex As Exception
                DA.SelectCommand = SC
                DA.Fill(DT)
            End Try
            Guardar.Enabled = False
            Consulta("delete from reservas where rut_cliente='" & (Rutes.Text) & "'")
            Me.Close()
            Menu2.Show()
        End If
    End Sub
End Class