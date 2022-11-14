<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cambio_Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cambio_Contraseña))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.envio = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.busqueda_clavee = New System.Windows.Forms.TextBox()
        Me.Con_Contr = New System.Windows.Forms.TextBox()
        Me.Nueva_Cont = New System.Windows.Forms.TextBox()
        Me.confirmar = New System.Windows.Forms.Button()
        Me.muestre = New System.Windows.Forms.Button()
        Me.cancel = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.muestre1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ProcesoEmail = New System.Windows.Forms.ProgressBar()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 33)
        Me.Panel2.TabIndex = 6
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
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(627, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "---"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(660, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Mensajes
        '
        Me.Mensajes.AutoPopDelay = 5000
        Me.Mensajes.InitialDelay = 100
        Me.Mensajes.ReshowDelay = 100
        Me.Mensajes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Mensajes.ToolTipTitle = "Mensaje"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(411, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(246, 40)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Ya Tengo un Codigo de Verificación"
        Me.Mensajes.SetToolTip(Me.Button3, "Si tienes un codigo de verificación, usted puede introducir el codigo aqui, sin r" &
        "eenviar uno nuevo")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'envio
        '
        Me.envio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.envio.BackColor = System.Drawing.SystemColors.Control
        Me.envio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.envio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.envio.Location = New System.Drawing.Point(164, 234)
        Me.envio.Name = "envio"
        Me.envio.Size = New System.Drawing.Size(241, 40)
        Me.envio.TabIndex = 1
        Me.envio.Text = "Enviar Codigo de Verificación"
        Me.Mensajes.SetToolTip(Me.envio, "Envia un codigo de verificación, para luego poder cambiar su contraseña")
        Me.envio.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.SystemColors.Control
        Me.Salir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Salir.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(17, 234)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(141, 40)
        Me.Salir.TabIndex = 0
        Me.Salir.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.Salir, "Vuelva a la pantalla anterior")
        Me.Salir.UseVisualStyleBackColor = False
        '
        'busqueda_clavee
        '
        Me.busqueda_clavee.Location = New System.Drawing.Point(220, 117)
        Me.busqueda_clavee.MaxLength = 45
        Me.busqueda_clavee.Name = "busqueda_clavee"
        Me.busqueda_clavee.Size = New System.Drawing.Size(438, 26)
        Me.busqueda_clavee.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.busqueda_clavee, "Ingrese la codigo de verificación aqui, automaticamente el codigo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "verificara si" &
        " esta bien digitado o no.")
        '
        'Con_Contr
        '
        Me.Con_Contr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Con_Contr.Enabled = False
        Me.Con_Contr.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Con_Contr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Con_Contr.Location = New System.Drawing.Point(313, 156)
        Me.Con_Contr.MaxLength = 12
        Me.Con_Contr.Name = "Con_Contr"
        Me.Con_Contr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Con_Contr.ReadOnly = True
        Me.Con_Contr.Size = New System.Drawing.Size(255, 29)
        Me.Con_Contr.TabIndex = 3
        Me.Mensajes.SetToolTip(Me.Con_Contr, "Ingrese la confirmacion de su contraseña.")
        '
        'Nueva_Cont
        '
        Me.Nueva_Cont.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Nueva_Cont.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nueva_Cont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Nueva_Cont.Location = New System.Drawing.Point(313, 85)
        Me.Nueva_Cont.MaxLength = 12
        Me.Nueva_Cont.Name = "Nueva_Cont"
        Me.Nueva_Cont.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.Nueva_Cont.Size = New System.Drawing.Size(255, 29)
        Me.Nueva_Cont.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.Nueva_Cont, "Ingrese su contraseña.")
        '
        'confirmar
        '
        Me.confirmar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.confirmar.BackColor = System.Drawing.SystemColors.Control
        Me.confirmar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmar.Enabled = False
        Me.confirmar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmar.Location = New System.Drawing.Point(311, 171)
        Me.confirmar.Name = "confirmar"
        Me.confirmar.Size = New System.Drawing.Size(241, 40)
        Me.confirmar.TabIndex = 1
        Me.confirmar.Text = "Aceptar"
        Me.Mensajes.SetToolTip(Me.confirmar, "Proceda a la siguiente ventana clickeando aqui.")
        Me.confirmar.UseVisualStyleBackColor = False
        '
        'muestre
        '
        Me.muestre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.muestre.BackColor = System.Drawing.SystemColors.Control
        Me.muestre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.muestre.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muestre.Location = New System.Drawing.Point(574, 84)
        Me.muestre.Name = "muestre"
        Me.muestre.Size = New System.Drawing.Size(87, 34)
        Me.muestre.TabIndex = 1
        Me.muestre.Text = "Mostrar"
        Me.Mensajes.SetToolTip(Me.muestre, "Visualise su nueva contraseña.")
        Me.muestre.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.cancel.AutoSize = True
        Me.cancel.Enabled = False
        Me.cancel.Location = New System.Drawing.Point(313, 188)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(63, 20)
        Me.cancel.TabIndex = 5
        Me.cancel.TabStop = True
        Me.cancel.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancel, "Cancele todas las operaciones si esque se equivoco de contraseña o si no esta seg" &
        "uro de ella.")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(313, 117)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(130, 20)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Aceptar Contraseña"
        Me.Mensajes.SetToolTip(Me.LinkLabel1, "Proceda a confirmar su contraseña una vez asegurado de haberla escrito correctame" &
        "nte.")
        '
        'Aceptar
        '
        Me.Aceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aceptar.BackColor = System.Drawing.SystemColors.Control
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Enabled = False
        Me.Aceptar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aceptar.Location = New System.Drawing.Point(272, 234)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(345, 40)
        Me.Aceptar.TabIndex = 6
        Me.Aceptar.Text = "Confirmar Nueva Contraseña"
        Me.Mensajes.SetToolTip(Me.Aceptar, "Acepte el cambio de contraseña.")
        Me.Aceptar.UseVisualStyleBackColor = False
        '
        'muestre1
        '
        Me.muestre1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.muestre1.BackColor = System.Drawing.SystemColors.Control
        Me.muestre1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.muestre1.Enabled = False
        Me.muestre1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muestre1.Location = New System.Drawing.Point(574, 152)
        Me.muestre1.Name = "muestre1"
        Me.muestre1.Size = New System.Drawing.Size(87, 34)
        Me.muestre1.TabIndex = 4
        Me.muestre1.Text = "Mostrar"
        Me.Mensajes.SetToolTip(Me.muestre1, "Visualise la confirmacion de la contraseña.")
        Me.muestre1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.envio)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Salir)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(-3, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 291)
        Me.Panel1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(15, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cambio de Contraseña"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RichTextBox1.Location = New System.Drawing.Point(165, 21)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(493, 207)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Location = New System.Drawing.Point(18, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(141, 207)
        Me.Panel5.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.busqueda_clavee)
        Me.Panel3.Controls.Add(Me.RichTextBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.confirmar)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(-2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 291)
        Me.Panel3.TabIndex = 22
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RichTextBox2.Location = New System.Drawing.Point(165, 42)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(493, 66)
        Me.RichTextBox2.TabIndex = 18
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(165, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Clave:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Location = New System.Drawing.Point(18, 41)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(141, 207)
        Me.Panel6.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Controls.Add(Me.muestre)
        Me.Panel4.Controls.Add(Me.cancel)
        Me.Panel4.Controls.Add(Me.LinkLabel1)
        Me.Panel4.Controls.Add(Me.Con_Contr)
        Me.Panel4.Controls.Add(Me.Nueva_Cont)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.RichTextBox3)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Aceptar)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.muestre1)
        Me.Panel4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(5, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(679, 288)
        Me.Panel4.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(160, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Repita Contraseña:"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RichTextBox3.Location = New System.Drawing.Point(160, 30)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(493, 34)
        Me.RichTextBox3.TabIndex = 25
        Me.RichTextBox3.Text = "Ahora puede ingresar su nueva contraseña de inicio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(160, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nueva Contraseña:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.BackgroundImage = CType(resources.GetObject("Panel7.BackgroundImage"), System.Drawing.Image)
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Location = New System.Drawing.Point(18, 30)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(141, 207)
        Me.Panel7.TabIndex = 22
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.ProcesoEmail)
        Me.Panel8.Location = New System.Drawing.Point(5, 321)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(678, 29)
        Me.Panel8.TabIndex = 24
        '
        'ProcesoEmail
        '
        Me.ProcesoEmail.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProcesoEmail.Location = New System.Drawing.Point(2, 1)
        Me.ProcesoEmail.Name = "ProcesoEmail"
        Me.ProcesoEmail.Size = New System.Drawing.Size(670, 23)
        Me.ProcesoEmail.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProcesoEmail.TabIndex = 0
        '
        'Cambio_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 355)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cambio_Contraseña"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio_Contraseña"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents envio As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Salir As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents busqueda_clavee As TextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents confirmar As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents muestre1 As Button
    Friend WithEvents muestre As Button
    Friend WithEvents cancel As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Con_Contr As TextBox
    Friend WithEvents Nueva_Cont As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Aceptar As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ProcesoEmail As ProgressBar
End Class
