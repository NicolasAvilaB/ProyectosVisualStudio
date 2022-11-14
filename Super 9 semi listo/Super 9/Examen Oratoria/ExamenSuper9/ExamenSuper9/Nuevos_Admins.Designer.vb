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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevos_Admins))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ocultar4 = New System.Windows.Forms.Button()
        Me.Ultimo = New System.Windows.Forms.Button()
        Me.Ver4 = New System.Windows.Forms.Button()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrillaAdmins, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Ocultar4)
        Me.GroupBox1.Controls.Add(Me.Ultimo)
        Me.GroupBox1.Controls.Add(Me.Ver4)
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
        Me.GroupBox1.Size = New System.Drawing.Size(402, 436)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Administradores"
        '
        'Ocultar4
        '
        Me.Ocultar4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ocultar4.Enabled = False
        Me.Ocultar4.Location = New System.Drawing.Point(291, 97)
        Me.Ocultar4.Name = "Ocultar4"
        Me.Ocultar4.Size = New System.Drawing.Size(102, 31)
        Me.Ocultar4.TabIndex = 23
        Me.Ocultar4.Text = "Ocultar"
        Me.ToolTip1.SetToolTip(Me.Ocultar4, "Oculta La Clave del Administrador si Todo esta Correcto")
        Me.Ocultar4.UseVisualStyleBackColor = True
        '
        'Ultimo
        '
        Me.Ultimo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ultimo.Location = New System.Drawing.Point(247, 401)
        Me.Ultimo.Name = "Ultimo"
        Me.Ultimo.Size = New System.Drawing.Size(49, 31)
        Me.Ultimo.TabIndex = 27
        Me.Ultimo.Text = ">>"
        Me.ToolTip1.SetToolTip(Me.Ultimo, "Desplazate Hacia el Ultimo Admin")
        Me.Ultimo.UseVisualStyleBackColor = True
        '
        'Ver4
        '
        Me.Ver4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver4.Location = New System.Drawing.Point(203, 97)
        Me.Ver4.Name = "Ver4"
        Me.Ver4.Size = New System.Drawing.Size(82, 30)
        Me.Ver4.TabIndex = 22
        Me.Ver4.Text = "Ver"
        Me.ToolTip1.SetToolTip(Me.Ver4, "Vizualiza la Clave del Nuevo Administrador en Caso de Alguna Falla")
        Me.Ver4.UseVisualStyleBackColor = True
        '
        'Siguiente
        '
        Me.Siguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Siguiente.Location = New System.Drawing.Point(192, 401)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(49, 31)
        Me.Siguiente.TabIndex = 26
        Me.Siguiente.Text = ">"
        Me.ToolTip1.SetToolTip(Me.Siguiente, "Desplazate Hacia el Siguiente Admin")
        Me.Siguiente.UseVisualStyleBackColor = True
        '
        'Anterior
        '
        Me.Anterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Anterior.Location = New System.Drawing.Point(137, 401)
        Me.Anterior.Name = "Anterior"
        Me.Anterior.Size = New System.Drawing.Size(49, 31)
        Me.Anterior.TabIndex = 25
        Me.Anterior.Text = "<"
        Me.ToolTip1.SetToolTip(Me.Anterior, "Desplazate Hacia el Anterior Admin")
        Me.Anterior.UseVisualStyleBackColor = True
        '
        'Primero
        '
        Me.Primero.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Primero.Location = New System.Drawing.Point(82, 401)
        Me.Primero.Name = "Primero"
        Me.Primero.Size = New System.Drawing.Size(49, 31)
        Me.Primero.TabIndex = 24
        Me.Primero.Text = "<<"
        Me.ToolTip1.SetToolTip(Me.Primero, "Desplazate Hacia el Primer Admin")
        Me.Primero.UseVisualStyleBackColor = True
        '
        'GrillaAdmins
        '
        Me.GrillaAdmins.AllowUserToAddRows = False
        Me.GrillaAdmins.AllowUserToDeleteRows = False
        Me.GrillaAdmins.AllowUserToResizeColumns = False
        Me.GrillaAdmins.AllowUserToResizeRows = False
        Me.GrillaAdmins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaAdmins.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GrillaAdmins.Enabled = False
        Me.GrillaAdmins.Location = New System.Drawing.Point(10, 171)
        Me.GrillaAdmins.Name = "GrillaAdmins"
        Me.GrillaAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaAdmins.ShowCellToolTips = False
        Me.GrillaAdmins.Size = New System.Drawing.Size(383, 224)
        Me.GrillaAdmins.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.GrillaAdmins, "Vizualiza Los Administradores Registrados")
        '
        'Guardar
        '
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(203, 134)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(190, 30)
        Me.Guardar.TabIndex = 22
        Me.Guardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar y Registra el Nuevo Administrador")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Terminar.Location = New System.Drawing.Point(10, 134)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(86, 31)
        Me.Terminar.TabIndex = 21
        Me.Terminar.Text = "Terminar"
        Me.ToolTip1.SetToolTip(Me.Terminar, "Puedes Terminar Con este Modo")
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Location = New System.Drawing.Point(105, 133)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(92, 31)
        Me.Eliminar.TabIndex = 20
        Me.Eliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Elimina un Administrador Existente")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Location = New System.Drawing.Point(105, 97)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(92, 30)
        Me.Modificar.TabIndex = 19
        Me.Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.Modificar, "Modifique Administrador Existente")
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Agre_Usuarios
        '
        Me.Agre_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agre_Usuarios.Location = New System.Drawing.Point(10, 97)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(86, 30)
        Me.Agre_Usuarios.TabIndex = 18
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Agre_Usuarios, "Ingrese un Nuevo Administrador")
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'Clave
        '
        Me.Clave.Enabled = False
        Me.Clave.Location = New System.Drawing.Point(105, 60)
        Me.Clave.Name = "Clave"
        Me.Clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Clave.Size = New System.Drawing.Size(288, 26)
        Me.Clave.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Clave, "Escriba la Clave del Nuevo Administrador")
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
        Me.ToolTip1.SetToolTip(Me.Administradores, "Escribe El Nombre del Nuevo Administrador")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 451)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Nuevos_Admins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(425, 474)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Nuevos_Admins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevos Admins"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GrillaAdmins, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Ocultar4 As System.Windows.Forms.Button
    Friend WithEvents Ver4 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
