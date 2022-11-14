<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.AlphaBlendTextBox1 = New ZBobb.AlphaBlendTextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "efecto explosion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 43)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "fade in"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "animaciuon de costado"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(251, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 41)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "animacion diagonal"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(333, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 53)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "animacion diagonal inferior derecha"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(432, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 44)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "animacion central"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 84)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 44)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "carga otra ventana animada"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(130, 84)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 44)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "cerrar ventana actual"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'AlphaBlendTextBox1
        '
        Me.AlphaBlendTextBox1.BackAlpha = 10
        Me.AlphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AlphaBlendTextBox1.Location = New System.Drawing.Point(194, 134)
        Me.AlphaBlendTextBox1.Name = "AlphaBlendTextBox1"
        Me.AlphaBlendTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AlphaBlendTextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1024, 371)
        Me.Controls.Add(Me.AlphaBlendTextBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents AlphaBlendTextBox1 As ZBobb.AlphaBlendTextBox
End Class
