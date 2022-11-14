<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nuevos_Admins
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ultimo = New System.Windows.Forms.Button()
        Me.Siguiente = New System.Windows.Forms.Button()
        Me.Anterior = New System.Windows.Forms.Button()
        Me.Primero = New System.Windows.Forms.Button()
        Me.GrillaAdmins = New System.Windows.Forms.DataGridView()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Terminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Agre_Usuarios = New System.Windows.Forms.Button()
        Me.Clave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Administradores = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ultimo)
        Me.GroupBox1.Controls.Add(Me.Siguiente)
        Me.GroupBox1.Controls.Add(Me.Anterior)
        Me.GroupBox1.Controls.Add(Me.Primero)
        Me.GroupBox1.Controls.Add(Me.GrillaAdmins)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Terminar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Agre_Usuarios)
        Me.GroupBox1.Controls.Add(Me.Clave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Administradores)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 403)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administradores"
        '
        'Ultimo
        '
        Me.Ultimo.Location = New System.Drawing.Point(334, 134)
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(49, 31)
        Me.Ultimo.TabIndex = 27
        Me.Ultimo.Text = ">>"
        Me.Ultimo.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(279, 134)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(49, 31)
        Me.Siguiente.TabIndex = 26
        Me.Siguiente.Text = ">"
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Location = New System.Drawing.Point(224, 134)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(49, 31)
        Me.Anterior.TabIndex = 25
        Me.Anterior.Text = "<"
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Primero
        '
        Me.Primero.Location = New System.Drawing.Point(169, 134)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(49, 31)
        Me.Primero.TabIndex = 24
        Me.Primero.Text = "<<"
        Me.Primero.UseVisualStyleBackColor = True
        '
        'GrillaAdmins
        '
        Me.GrillaAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaAdmins.Location = New System.Drawing.Point(10, 171)
        Me.GrillaAdmins.Name = "GrillaAdmins"
        Me.GrillaAdmins.Size = New System.Drawing.Size(383, 224)
        Me.GrillaAdmins.TabIndex = 23
        '
        'Guardar
        '
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(212, 97)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(84, 30)
        Me.Guardar.TabIndex = 22
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Location = New System.Drawing.Point(10, 134)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(152, 31)
        Me.Terminar.TabIndex = 21
        Me.Terminar.Text = "Terminar"
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(307, 97)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(86, 31)
        Me.Eliminar.TabIndex = 20
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(105, 97)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(92, 30)
        Me.Modificar.TabIndex = 19
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agre_Usuarios
        '
        Me.Agre_Usuarios.Location = New System.Drawing.Point(10, 97)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(86, 30)
        Me.Agre_Usuarios.TabIndex = 18
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'Clave
        '
        Me.Clave.Enabled = False
        Me.Clave.Location = New System.Drawing.Point(105, 60)
        Me.Clave.Name = "Clave"
        Me.Clave.Size = New System.Drawing.Size(288, 26)
        Me.Clave.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Clave Admin:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Admin:"
        '
        'Administradores
        '
        Me.Administradores.Enabled = False
        Me.Administradores.Location = New System.Drawing.Point(121, 25)
        Me.Administradores.Name = "Administradores"
        Me.Administradores.Size = New System.Drawing.Size(272, 26)
        Me.Administradores.TabIndex = 0
        '
        'Nuevos_Admins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(425, 427)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Nuevos_Admins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevos Admins"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Clave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Administradores As System.Windows.Forms.TextBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Terminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Agre_Usuarios As System.Windows.Forms.Button
    Friend WithEvents GrillaAdmins As System.Windows.Forms.DataGridView
    Friend WithEvents Anterior As System.Windows.Forms.Button
    Friend WithEvents Primero As System.Windows.Forms.Button
    Friend WithEvents Ultimo As System.Windows.Forms.Button
    Friend WithEvents Siguiente As System.Windows.Forms.Button
End Class
