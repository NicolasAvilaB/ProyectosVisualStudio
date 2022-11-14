<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personas_Exteriores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personas_Exteriores))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Empresa = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Terminar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Grilla_Empresarios = New System.Windows.Forms.DataGridView()
        Me.Agre_Usuarios = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Direccion = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.Rut = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Empresarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Busqueda)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Empresa)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Terminar)
        Me.GroupBox1.Controls.Add(Me.Eliminar)
        Me.GroupBox1.Controls.Add(Me.Modificar)
        Me.GroupBox1.Controls.Add(Me.Grilla_Empresarios)
        Me.GroupBox1.Controls.Add(Me.Agre_Usuarios)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Telefono)
        Me.GroupBox1.Controls.Add(Me.Direccion)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Rut)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1173, 364)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personas Exteriores"
        '
        'Empresa
        '
        Me.Empresa.Enabled = False
        Me.Empresa.Location = New System.Drawing.Point(72, 193)
        Me.Empresa.Name = "Empresa"
        Me.Empresa.Size = New System.Drawing.Size(269, 26)
        Me.Empresa.TabIndex = 10
        '
        'Guardar
        '
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(227, 279)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(115, 30)
        Me.Guardar.TabIndex = 7
        Me.Guardar.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar y Registrar la Nueva Persona Ingresada")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Terminar
        '
        Me.Terminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Terminar.Location = New System.Drawing.Point(159, 323)
        Me.Terminar.Name = "Terminar"
        Me.Terminar.Size = New System.Drawing.Size(183, 33)
        Me.Terminar.TabIndex = 9
        Me.Terminar.Text = "Terminar"
        Me.ToolTip1.SetToolTip(Me.Terminar, "Vuelva a la Pantalla Anterior Terminando este Modo")
        Me.Terminar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Eliminar.Location = New System.Drawing.Point(10, 323)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(143, 33)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.ToolTip1.SetToolTip(Me.Eliminar, "Eliminar Persona Existente")
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modificar.Location = New System.Drawing.Point(123, 279)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(98, 30)
        Me.Modificar.TabIndex = 6
        Me.Modificar.Text = "Modificar"
        Me.ToolTip1.SetToolTip(Me.Modificar, "Modifique a Alguien Existente")
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Grilla_Empresarios
        '
        Me.Grilla_Empresarios.AllowUserToAddRows = False
        Me.Grilla_Empresarios.AllowUserToDeleteRows = False
        Me.Grilla_Empresarios.AllowUserToResizeRows = False
        Me.Grilla_Empresarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Empresarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Empresarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Empresarios.Location = New System.Drawing.Point(347, 25)
        Me.Grilla_Empresarios.Name = "Grilla_Empresarios"
        Me.Grilla_Empresarios.ReadOnly = True
        Me.Grilla_Empresarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Empresarios.ShowCellToolTips = False
        Me.Grilla_Empresarios.Size = New System.Drawing.Size(820, 333)
        Me.Grilla_Empresarios.TabIndex = 1
        '
        'Agre_Usuarios
        '
        Me.Agre_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agre_Usuarios.Location = New System.Drawing.Point(10, 279)
        Me.Agre_Usuarios.Name = "Agre_Usuarios"
        Me.Agre_Usuarios.Size = New System.Drawing.Size(107, 30)
        Me.Agre_Usuarios.TabIndex = 5
        Me.Agre_Usuarios.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Agre_Usuarios, "Ingrese un Nuevo Encargado de los Suministros de los Productos")
        Me.Agre_Usuarios.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Empresa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Telefono :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Direccion :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rut :"
        '
        'Telefono
        '
        Me.Telefono.Enabled = False
        Me.Telefono.Location = New System.Drawing.Point(89, 152)
        Me.Telefono.MaxLength = 9
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(252, 26)
        Me.Telefono.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Telefono, "Escriba el Telefono de la Persona ")
        '
        'Direccion
        '
        Me.Direccion.Enabled = False
        Me.Direccion.Location = New System.Drawing.Point(93, 110)
        Me.Direccion.MaxLength = 45
        Me.Direccion.Name = "Direccion"
        Me.Direccion.Size = New System.Drawing.Size(248, 26)
        Me.Direccion.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Direccion, "Escriba la Direccion de la Persona")
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(83, 66)
        Me.Nombre.MaxLength = 45
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(258, 26)
        Me.Nombre.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Nombre, "Escriba el Nombre de la Persona")
        '
        'Rut
        '
        Me.Rut.Enabled = False
        Me.Rut.Location = New System.Drawing.Point(62, 25)
        Me.Rut.MaxLength = 9
        Me.Rut.Name = "Rut"
        Me.Rut.Size = New System.Drawing.Size(280, 26)
        Me.Rut.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Rut, "Escriba Rut de la Nueva Persona")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(272, 19)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Buscar Proveedor:"
        '
        'Busqueda
        '
        Me.Busqueda.Location = New System.Drawing.Point(135, 235)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(206, 26)
        Me.Busqueda.TabIndex = 12
        '
        'Personas_Exteriores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1197, 404)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Personas_Exteriores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personas Exteriores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Empresarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Direccion As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Rut As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Terminar As System.Windows.Forms.Button
    Friend WithEvents Eliminar As System.Windows.Forms.Button
    Friend WithEvents Modificar As System.Windows.Forms.Button
    Friend WithEvents Agre_Usuarios As System.Windows.Forms.Button
    Friend WithEvents Grilla_Empresarios As System.Windows.Forms.DataGridView
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Empresa As TextBox
    Friend WithEvents Busqueda As TextBox
    Friend WithEvents Label7 As Label
End Class
