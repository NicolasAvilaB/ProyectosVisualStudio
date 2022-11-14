<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTConsultaLibro = New System.Windows.Forms.Button()
        Me.BTSalir = New System.Windows.Forms.Button()
        Me.BTReservas = New System.Windows.Forms.Button()
        Me.BTClientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTConsultaLibro
        '
        Me.BTConsultaLibro.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTConsultaLibro.Location = New System.Drawing.Point(12, 115)
        Me.BTConsultaLibro.Name = "BTConsultaLibro"
        Me.BTConsultaLibro.Size = New System.Drawing.Size(305, 51)
        Me.BTConsultaLibro.TabIndex = 12
        Me.BTConsultaLibro.Text = "Consulta Libro Registrado"
        Me.BTConsultaLibro.UseVisualStyleBackColor = True
        '
        'BTSalir
        '
        Me.BTSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTSalir.Location = New System.Drawing.Point(12, 227)
        Me.BTSalir.Name = "BTSalir"
        Me.BTSalir.Size = New System.Drawing.Size(305, 49)
        Me.BTSalir.TabIndex = 11
        Me.BTSalir.Text = "Salir"
        Me.BTSalir.UseVisualStyleBackColor = True
        '
        'BTReservas
        '
        Me.BTReservas.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTReservas.Location = New System.Drawing.Point(12, 63)
        Me.BTReservas.Name = "BTReservas"
        Me.BTReservas.Size = New System.Drawing.Size(305, 45)
        Me.BTReservas.TabIndex = 10
        Me.BTReservas.Text = "Stock"
        Me.BTReservas.UseVisualStyleBackColor = True
        '
        'BTClientes
        '
        Me.BTClientes.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTClientes.Location = New System.Drawing.Point(12, 12)
        Me.BTClientes.Name = "BTClientes"
        Me.BTClientes.Size = New System.Drawing.Size(305, 45)
        Me.BTClientes.TabIndex = 9
        Me.BTClientes.Text = "Clientes"
        Me.BTClientes.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 288)
        Me.Controls.Add(Me.BTConsultaLibro)
        Me.Controls.Add(Me.BTSalir)
        Me.Controls.Add(Me.BTReservas)
        Me.Controls.Add(Me.BTClientes)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTConsultaLibro As System.Windows.Forms.Button
    Friend WithEvents BTSalir As System.Windows.Forms.Button
    Friend WithEvents BTReservas As System.Windows.Forms.Button
    Friend WithEvents BTClientes As System.Windows.Forms.Button
End Class
