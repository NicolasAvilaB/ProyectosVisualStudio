<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_Clave_Acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestion_Clave_Acceso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ver2 = New System.Windows.Forms.Button()
        Me.contra = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.cierre = New System.Windows.Forms.Button()
        Me.ingreso = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Ver2)
        Me.GroupBox1.Controls.Add(Me.contra)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Controls.Add(Me.cierre)
        Me.GroupBox1.Controls.Add(Me.ingreso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clave de Acceso"
        '
        'Ver2
        '
        Me.Ver2.BackColor = System.Drawing.SystemColors.Control
        Me.Ver2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Ver2.Enabled = False
        Me.Ver2.Location = New System.Drawing.Point(406, 102)
        Me.Ver2.Name = "Ver2"
        Me.Ver2.Size = New System.Drawing.Size(103, 37)
        Me.Ver2.TabIndex = 2
        Me.Ver2.Text = "Mostrar"
        Me.Mensajes.SetToolTip(Me.Ver2, "Visualiza tu Contraseña o Clave Digitada")
        Me.Ver2.UseVisualStyleBackColor = False
        '
        'contra
        '
        Me.contra.Enabled = False
        Me.contra.Location = New System.Drawing.Point(224, 70)
        Me.contra.MaxLength = 45
        Me.contra.Name = "contra"
        Me.contra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.contra.ReadOnly = True
        Me.contra.Size = New System.Drawing.Size(285, 26)
        Me.contra.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.contra, "Ingrese su Clave o Contraseña")
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(279, 25)
        Me.nombre.MaxLength = 30
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(230, 26)
        Me.nombre.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.nombre, "Ingresa Nombre/Alias Registrado")
        '
        'cierre
        '
        Me.cierre.BackColor = System.Drawing.SystemColors.Control
        Me.cierre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cierre.Location = New System.Drawing.Point(349, 171)
        Me.cierre.Name = "cierre"
        Me.cierre.Size = New System.Drawing.Size(156, 46)
        Me.cierre.TabIndex = 4
        Me.cierre.Text = "Cerrar"
        Me.Mensajes.SetToolTip(Me.cierre, "Cierre la Ventana Actual")
        Me.cierre.UseVisualStyleBackColor = False
        '
        'ingreso
        '
        Me.ingreso.BackColor = System.Drawing.SystemColors.Control
        Me.ingreso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ingreso.Enabled = False
        Me.ingreso.Location = New System.Drawing.Point(171, 171)
        Me.ingreso.Name = "ingreso"
        Me.ingreso.Size = New System.Drawing.Size(153, 46)
        Me.ingreso.TabIndex = 3
        Me.ingreso.Text = "Aceptar"
        Me.Mensajes.SetToolTip(Me.ingreso, "Procede a la Siguiente Ventana")
        Me.ingreso.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(171, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(171, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre/Alias:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(14, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 207)
        Me.Panel1.TabIndex = 4
        Me.Mensajes.SetToolTip(Me.Panel1, "Municipalidad de Peralillo")
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 33)
        Me.Panel2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Municipalidad de Peralillo"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(474, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DimGray
        Me.Button6.Location = New System.Drawing.Point(507, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Gestion_Clave_Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 279)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Gestion_Clave_Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents contra As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents cierre As Button
    Friend WithEvents ingreso As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Ver2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Mensajes As ToolTip
End Class
