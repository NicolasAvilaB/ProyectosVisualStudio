<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Entrar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.ProInformes = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Clave_Entrada = New System.Windows.Forms.TextBox()
        Me.N_Usuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supermercado El 9"
        '
        'Ventas
        '
        Me.Ventas.AutoSize = True
        Me.Ventas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Ventas.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ventas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ventas.Location = New System.Drawing.Point(372, 19)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(227, 53)
        Me.Ventas.TabIndex = 1
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = False
        '
        'ProInformes
        '
        Me.ProInformes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ProInformes.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProInformes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProInformes.Location = New System.Drawing.Point(372, 121)
        Me.ProInformes.Name = "ProInformes"
        Me.ProInformes.Size = New System.Drawing.Size(227, 53)
        Me.ProInformes.TabIndex = 2
        Me.ProInformes.Text = "Procesos Informes"
        Me.ProInformes.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Salir.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Salir.Location = New System.Drawing.Point(372, 222)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(227, 53)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.mantenedor.My.Resources.Resources.BannerTurismo_gif
        Me.Panel1.Location = New System.Drawing.Point(14, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(326, 256)
        Me.Panel1.TabIndex = 6
        '
        'Clave_Entrada
        '
        Me.Clave_Entrada.Enabled = False
        Me.Clave_Entrada.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clave_Entrada.Location = New System.Drawing.Point(143, 70)
        Me.Clave_Entrada.Name = "Clave_Entrada"
        Me.Clave_Entrada.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Clave_Entrada.Size = New System.Drawing.Size(456, 26)
        Me.Clave_Entrada.TabIndex = 24
        '
        'N_Usuario
        '
        Me.N_Usuario.Enabled = False
        Me.N_Usuario.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.N_Usuario.Location = New System.Drawing.Point(168, 33)
        Me.N_Usuario.Name = "N_Usuario"
        Me.N_Usuario.Size = New System.Drawing.Size(431, 26)
        Me.N_Usuario.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Clave de Entrada"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nombre de Usuario"
        '
        'Cancelar
        '
        Me.Cancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Cancelar.Enabled = False
        Me.Cancelar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancelar.Location = New System.Drawing.Point(434, 107)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(165, 39)
        Me.Cancelar.TabIndex = 20
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = False
        '
        'Aceptar
        '
        Me.Aceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Aceptar.Enabled = False
        Me.Aceptar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(10, 107)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(191, 39)
        Me.Aceptar.TabIndex = 19
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cancelar)
        Me.GroupBox1.Controls.Add(Me.Clave_Entrada)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.N_Usuario)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 351)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 158)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Salir)
        Me.GroupBox2.Controls.Add(Me.Ventas)
        Me.GroupBox2.Controls.Add(Me.ProInformes)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 293)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        '
        'Form_Entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Entrar"
        Me.Text = "Form_Entrar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ventas As System.Windows.Forms.Button
    Friend WithEvents ProInformes As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Clave_Entrada As System.Windows.Forms.TextBox
    Friend WithEvents N_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
