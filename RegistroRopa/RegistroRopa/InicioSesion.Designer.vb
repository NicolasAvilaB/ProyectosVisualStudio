<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clave = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.nombre = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ver = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.aceptar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 33)
        Me.Panel2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "REGISTROS DE ROPAS"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(275, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Mensaje.SetToolTip(Me.Button5, "Minimiza la ventana")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(308, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Mensaje.SetToolTip(Me.Button6, "Salga del programa")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.clave)
        Me.Panel1.Controls.Add(Me.nombre)
        Me.Panel1.Controls.Add(Me.ver)
        Me.Panel1.Controls.Add(Me.salir)
        Me.Panel1.Controls.Add(Me.aceptar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(5, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 435)
        Me.Panel1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 29)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "CONTROL ROPAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 402)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "CLAVE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 365)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "NOMBRE:"
        '
        'clave
        '
        Me.clave.Cursor = System.Windows.Forms.Cursors.Default
        Me.clave.Depth = 0
        Me.clave.Enabled = False
        Me.clave.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clave.ForeColor = System.Drawing.Color.Black
        Me.clave.Hint = "INGRESE SU CLAVE..."
        Me.clave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.clave.Location = New System.Drawing.Point(64, 403)
        Me.clave.MaxLength = 45
        Me.clave.MouseState = MaterialSkin.MouseState.HOVER
        Me.clave.Name = "clave"
        Me.clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.clave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.clave.SelectedText = ""
        Me.clave.SelectionLength = 0
        Me.clave.SelectionStart = 0
        Me.clave.Size = New System.Drawing.Size(217, 23)
        Me.clave.TabIndex = 37
        Me.clave.TabStop = False
        Me.Mensaje.SetToolTip(Me.clave, "Ingrese su clave o contraseña")
        Me.clave.UseSystemPasswordChar = False
        '
        'nombre
        '
        Me.nombre.Cursor = System.Windows.Forms.Cursors.Default
        Me.nombre.Depth = 0
        Me.nombre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.Black
        Me.nombre.Hint = "INGRESE SU NOMBRE..."
        Me.nombre.Location = New System.Drawing.Point(77, 366)
        Me.nombre.MaxLength = 45
        Me.nombre.MouseState = MaterialSkin.MouseState.HOVER
        Me.nombre.Name = "nombre"
        Me.nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.nombre.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nombre.SelectedText = ""
        Me.nombre.SelectionLength = 0
        Me.nombre.SelectionStart = 0
        Me.nombre.Size = New System.Drawing.Size(245, 23)
        Me.nombre.TabIndex = 36
        Me.nombre.TabStop = False
        Me.Mensaje.SetToolTip(Me.nombre, "Ingrese usuario o nombre registrado")
        Me.nombre.UseSystemPasswordChar = False
        '
        'ver
        '
        Me.ver.BackColor = System.Drawing.Color.White
        Me.ver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ver.Enabled = False
        Me.ver.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ver.ForeColor = System.Drawing.Color.White
        Me.ver.Location = New System.Drawing.Point(287, 398)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(36, 30)
        Me.ver.TabIndex = 35
        Me.ver.Text = "•"
        Me.Mensaje.SetToolTip(Me.ver, "Visualiza tu contraseña o clave")
        Me.ver.UseVisualStyleBackColor = False
        '
        'salir
        '
        Me.salir.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.salir.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.salir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.Color.White
        Me.salir.Location = New System.Drawing.Point(199, 440)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(124, 35)
        Me.salir.TabIndex = 34
        Me.salir.Text = "SALIR"
        Me.Mensaje.SetToolTip(Me.salir, "Salga del programa")
        Me.salir.UseVisualStyleBackColor = False
        '
        'aceptar
        '
        Me.aceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.aceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aceptar.ForeColor = System.Drawing.Color.White
        Me.aceptar.Location = New System.Drawing.Point(5, 440)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(124, 35)
        Me.aceptar.TabIndex = 33
        Me.aceptar.Text = "ACEPTAR"
        Me.Mensaje.SetToolTip(Me.aceptar, "Inicie sesión desde este boton")
        Me.aceptar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.RegistroRopa.My.Resources.Resources.icon_ropa_basico___copia1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(5, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(318, 317)
        Me.Panel3.TabIndex = 31
        '
        'Mensaje
        '
        Me.Mensaje.AutoPopDelay = 5000
        Me.Mensaje.InitialDelay = 100
        Me.Mensaje.ReshowDelay = 100
        Me.Mensaje.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensaje.ToolTipTitle = "Mensaje"
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(339, 473)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents clave As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents nombre As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ver As Button
    Friend WithEvents salir As Button
    Friend WithEvents aceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mensaje As ToolTip
End Class
