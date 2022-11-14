<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.Txtclave = New System.Windows.Forms.TextBox()
        Me.Ingreso = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ocultar = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(85, 34)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(202, 26)
        Me.Txtusuario.TabIndex = 0
        '
        'Txtclave
        '
        Me.Txtclave.Location = New System.Drawing.Point(85, 66)
        Me.Txtclave.Name = "Txtclave"
        Me.Txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtclave.Size = New System.Drawing.Size(202, 26)
        Me.Txtclave.TabIndex = 1
        '
        'Ingreso
        '
        Me.Ingreso.Location = New System.Drawing.Point(17, 141)
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.Size = New System.Drawing.Size(132, 28)
        Me.Ingreso.TabIndex = 2
        Me.Ingreso.Text = "Ingreso"
        Me.Ingreso.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ocultar)
        Me.GroupBox1.Controls.Add(Me.Ver)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Salir)
        Me.GroupBox1.Controls.Add(Me.Txtusuario)
        Me.GroupBox1.Controls.Add(Me.Ingreso)
        Me.GroupBox1.Controls.Add(Me.Txtclave)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 184)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada"
        '
        'Ocultar
        '
        Me.Ocultar.Enabled = False
        Me.Ocultar.Location = New System.Drawing.Point(155, 104)
        Me.Ocultar.Name = "Ocultar"
        Me.Ocultar.Size = New System.Drawing.Size(132, 27)
        Me.Ocultar.TabIndex = 7
        Me.Ocultar.Text = "Ocultar"
        Me.Ocultar.UseVisualStyleBackColor = True
        '
        'Ver
        '
        Me.Ver.Location = New System.Drawing.Point(17, 104)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(132, 27)
        Me.Ver.TabIndex = 6
        Me.Ver.Text = "Ver"
        Me.Ver.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(155, 141)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(132, 28)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 208)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents Txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Ingreso As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ver As System.Windows.Forms.Button
    Friend WithEvents Ocultar As System.Windows.Forms.Button

End Class
