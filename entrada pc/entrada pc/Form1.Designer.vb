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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.verlo = New System.Windows.Forms.Button()
        Me.apagando = New System.Windows.Forms.Button()
        Me.reinicio = New System.Windows.Forms.Button()
        Me.Acepto = New System.Windows.Forms.Button()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rut = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.verlo)
        Me.GroupBox1.Controls.Add(Me.apagando)
        Me.GroupBox1.Controls.Add(Me.reinicio)
        Me.GroupBox1.Controls.Add(Me.Acepto)
        Me.GroupBox1.Controls.Add(Me.clave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.apellido)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rut)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(477, 424)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrada Pc"
        '
        'verlo
        '
        Me.verlo.Location = New System.Drawing.Point(391, 236)
        Me.verlo.Name = "verlo"
        Me.verlo.Size = New System.Drawing.Size(75, 26)
        Me.verlo.TabIndex = 2
        Me.verlo.Text = "Ver"
        Me.verlo.UseVisualStyleBackColor = True
        '
        'apagando
        '
        Me.apagando.Location = New System.Drawing.Point(150, 352)
        Me.apagando.Name = "apagando"
        Me.apagando.Size = New System.Drawing.Size(184, 49)
        Me.apagando.TabIndex = 5
        Me.apagando.Text = "Apagar"
        Me.apagando.UseVisualStyleBackColor = True
        '
        'reinicio
        '
        Me.reinicio.Location = New System.Drawing.Point(275, 284)
        Me.reinicio.Name = "reinicio"
        Me.reinicio.Size = New System.Drawing.Size(184, 49)
        Me.reinicio.TabIndex = 4
        Me.reinicio.Text = "Reiniciar"
        Me.reinicio.UseVisualStyleBackColor = True
        '
        'Acepto
        '
        Me.Acepto.Location = New System.Drawing.Point(28, 284)
        Me.Acepto.Name = "Acepto"
        Me.Acepto.Size = New System.Drawing.Size(184, 49)
        Me.Acepto.TabIndex = 3
        Me.Acepto.Text = "Entrar"
        Me.Acepto.UseVisualStyleBackColor = True
        '
        'clave
        '
        Me.clave.Location = New System.Drawing.Point(88, 236)
        Me.clave.Name = "clave"
        Me.clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.clave.Size = New System.Drawing.Size(297, 26)
        Me.clave.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Clave:"
        '
        'apellido
        '
        Me.apellido.Enabled = False
        Me.apellido.Location = New System.Drawing.Point(88, 167)
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Size = New System.Drawing.Size(371, 26)
        Me.apellido.TabIndex = 5
        '
        'nombre
        '
        Me.nombre.Enabled = False
        Me.nombre.Location = New System.Drawing.Point(88, 99)
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Size = New System.Drawing.Size(371, 26)
        Me.nombre.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rut:"
        '
        'rut
        '
        Me.rut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rut.FormattingEnabled = True
        Me.rut.Location = New System.Drawing.Point(88, 39)
        Me.rut.Name = "rut"
        Me.rut.Size = New System.Drawing.Size(371, 27)
        Me.rut.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(88, 444)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(336, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Copyright 2016 @ Nicolas Rodrigo Avila Biskupovic"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrar A Pc"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents verlo As Button
    Friend WithEvents apagando As Button
    Friend WithEvents reinicio As Button
    Friend WithEvents Acepto As Button
    Friend WithEvents clave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents apellido As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rut As ComboBox
    Friend WithEvents Label5 As Label
End Class
