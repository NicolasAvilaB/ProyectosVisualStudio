<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_menu
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
        Me.btn_clientes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_clientes
        '
        Me.btn_clientes.Location = New System.Drawing.Point(96, 69)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(162, 43)
        Me.btn_clientes.TabIndex = 0
        Me.btn_clientes.Text = "CLIENTES"
        Me.btn_clientes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(96, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "USUARIOS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 286)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_clientes)
        Me.Name = "Form_menu"
        Me.Text = "Form_menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_clientes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
