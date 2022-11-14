<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvenido9
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
        Me.Emitir_Boletas = New System.Windows.Forms.Button()
        Me.CierreCajero = New System.Windows.Forms.Button()
        Me.DotacionyRetiro = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Emitir_Boletas
        '
        Me.Emitir_Boletas.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emitir_Boletas.Location = New System.Drawing.Point(299, 14)
        Me.Emitir_Boletas.Name = "Emitir_Boletas"
        Me.Emitir_Boletas.Size = New System.Drawing.Size(193, 53)
        Me.Emitir_Boletas.TabIndex = 0
        Me.Emitir_Boletas.Text = "Emitir Boletas"
        Me.Emitir_Boletas.UseVisualStyleBackColor = True
        '
        'CierreCajero
        '
        Me.CierreCajero.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CierreCajero.Location = New System.Drawing.Point(299, 73)
        Me.CierreCajero.Name = "CierreCajero"
        Me.CierreCajero.Size = New System.Drawing.Size(193, 53)
        Me.CierreCajero.TabIndex = 1
        Me.CierreCajero.Text = "Cierre Cajero"
        Me.CierreCajero.UseVisualStyleBackColor = True
        '
        'DotacionyRetiro
        '
        Me.DotacionyRetiro.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DotacionyRetiro.Location = New System.Drawing.Point(299, 132)
        Me.DotacionyRetiro.Name = "DotacionyRetiro"
        Me.DotacionyRetiro.Size = New System.Drawing.Size(193, 53)
        Me.DotacionyRetiro.TabIndex = 2
        Me.DotacionyRetiro.Text = "Dotacion y Retiro"
        Me.DotacionyRetiro.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(299, 191)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(193, 53)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Volver"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 219)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 329)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Salir)
        Me.GroupBox1.Controls.Add(Me.Emitir_Boletas)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.CierreCajero)
        Me.GroupBox1.Controls.Add(Me.DotacionyRetiro)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 250)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Que Es Lo Que Desea Hacer?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(498, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Modo Prueba Cajeros/as"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bienvenido9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(520, 357)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Bienvenido9"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenido al Supermercado El 9"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Emitir_Boletas As System.Windows.Forms.Button
    Friend WithEvents CierreCajero As System.Windows.Forms.Button
    Friend WithEvents DotacionyRetiro As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
