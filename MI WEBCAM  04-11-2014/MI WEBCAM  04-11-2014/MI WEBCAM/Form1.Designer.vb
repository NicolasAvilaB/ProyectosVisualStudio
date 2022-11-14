<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.VISOR = New System.Windows.Forms.PictureBox()
        Me.INICIAR = New System.Windows.Forms.Button()
        Me.CAPTURAR = New System.Windows.Forms.Button()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.GRABAR = New System.Windows.Forms.Button()
        Me.FGRABAR = New System.Windows.Forms.Button()
        Me.FORMATO = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSERIEDIARIA = New System.Windows.Forms.Button()
        Me.ButtonFINSERIEDIARIA = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VISOR
        '
        Me.VISOR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VISOR.Location = New System.Drawing.Point(12, 9)
        Me.VISOR.Name = "VISOR"
        Me.VISOR.Size = New System.Drawing.Size(751, 496)
        Me.VISOR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VISOR.TabIndex = 0
        Me.VISOR.TabStop = False
        '
        'INICIAR
        '
        Me.INICIAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.INICIAR.BackColor = System.Drawing.Color.Black
        Me.INICIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.INICIAR.ForeColor = System.Drawing.Color.Aqua
        Me.INICIAR.Location = New System.Drawing.Point(792, 12)
        Me.INICIAR.Name = "INICIAR"
        Me.INICIAR.Size = New System.Drawing.Size(139, 42)
        Me.INICIAR.TabIndex = 1
        Me.INICIAR.Text = "INICIAR"
        Me.INICIAR.UseVisualStyleBackColor = False
        '
        'CAPTURAR
        '
        Me.CAPTURAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CAPTURAR.BackColor = System.Drawing.Color.Black
        Me.CAPTURAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CAPTURAR.ForeColor = System.Drawing.Color.Aqua
        Me.CAPTURAR.Location = New System.Drawing.Point(792, 122)
        Me.CAPTURAR.Name = "CAPTURAR"
        Me.CAPTURAR.Size = New System.Drawing.Size(139, 42)
        Me.CAPTURAR.TabIndex = 4
        Me.CAPTURAR.Text = "CAPTURAR"
        Me.CAPTURAR.UseVisualStyleBackColor = False
        '
        'GUARDAR
        '
        Me.GUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GUARDAR.BackColor = System.Drawing.Color.Black
        Me.GUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GUARDAR.ForeColor = System.Drawing.Color.Aqua
        Me.GUARDAR.Location = New System.Drawing.Point(792, 168)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(139, 42)
        Me.GUARDAR.TabIndex = 5
        Me.GUARDAR.Text = "GUARDAR CAPTURA"
        Me.GUARDAR.UseVisualStyleBackColor = False
        '
        'GRABAR
        '
        Me.GRABAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRABAR.BackColor = System.Drawing.Color.Black
        Me.GRABAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GRABAR.ForeColor = System.Drawing.Color.Aqua
        Me.GRABAR.Location = New System.Drawing.Point(792, 309)
        Me.GRABAR.Name = "GRABAR"
        Me.GRABAR.Size = New System.Drawing.Size(139, 42)
        Me.GRABAR.TabIndex = 9
        Me.GRABAR.Text = "GRABAR VIDEO"
        Me.GRABAR.UseVisualStyleBackColor = False
        '
        'FGRABAR
        '
        Me.FGRABAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FGRABAR.BackColor = System.Drawing.Color.Black
        Me.FGRABAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FGRABAR.ForeColor = System.Drawing.Color.Aqua
        Me.FGRABAR.Location = New System.Drawing.Point(792, 356)
        Me.FGRABAR.Name = "FGRABAR"
        Me.FGRABAR.Size = New System.Drawing.Size(139, 42)
        Me.FGRABAR.TabIndex = 10
        Me.FGRABAR.Text = "FIN GRABAR   VIDEO"
        Me.FGRABAR.UseVisualStyleBackColor = False
        '
        'FORMATO
        '
        Me.FORMATO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FORMATO.BackColor = System.Drawing.Color.Black
        Me.FORMATO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FORMATO.ForeColor = System.Drawing.Color.Aqua
        Me.FORMATO.Location = New System.Drawing.Point(792, 74)
        Me.FORMATO.Name = "FORMATO"
        Me.FORMATO.Size = New System.Drawing.Size(139, 42)
        Me.FORMATO.TabIndex = 11
        Me.FORMATO.Text = "RESOLUCION"
        Me.FORMATO.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ButtonSERIEDIARIA
        '
        Me.ButtonSERIEDIARIA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSERIEDIARIA.BackColor = System.Drawing.Color.Black
        Me.ButtonSERIEDIARIA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSERIEDIARIA.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonSERIEDIARIA.Location = New System.Drawing.Point(792, 215)
        Me.ButtonSERIEDIARIA.Name = "ButtonSERIEDIARIA"
        Me.ButtonSERIEDIARIA.Size = New System.Drawing.Size(139, 42)
        Me.ButtonSERIEDIARIA.TabIndex = 17
        Me.ButtonSERIEDIARIA.Text = "SERIE IMAGENES"
        Me.ButtonSERIEDIARIA.UseVisualStyleBackColor = False
        '
        'ButtonFINSERIEDIARIA
        '
        Me.ButtonFINSERIEDIARIA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFINSERIEDIARIA.BackColor = System.Drawing.Color.Black
        Me.ButtonFINSERIEDIARIA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFINSERIEDIARIA.ForeColor = System.Drawing.Color.Aqua
        Me.ButtonFINSERIEDIARIA.Location = New System.Drawing.Point(792, 262)
        Me.ButtonFINSERIEDIARIA.Name = "ButtonFINSERIEDIARIA"
        Me.ButtonFINSERIEDIARIA.Size = New System.Drawing.Size(139, 42)
        Me.ButtonFINSERIEDIARIA.TabIndex = 18
        Me.ButtonFINSERIEDIARIA.Text = "FIN SERIE IMAGENES"
        Me.ButtonFINSERIEDIARIA.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Aqua
        Me.Button1.Location = New System.Drawing.Point(792, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "DETECCION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(769, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 45)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ALARMA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.ForeColor = System.Drawing.Color.Aqua
        Me.Button2.Location = New System.Drawing.Point(792, 547)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 42)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "DETALLES ALARMA"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(792, 572)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(139, 11)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(769, 432)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 45)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "NO HAY NUEVA AMENAZA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(969, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonFINSERIEDIARIA)
        Me.Controls.Add(Me.ButtonSERIEDIARIA)
        Me.Controls.Add(Me.FORMATO)
        Me.Controls.Add(Me.FGRABAR)
        Me.Controls.Add(Me.GRABAR)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.CAPTURAR)
        Me.Controls.Add(Me.INICIAR)
        Me.Controls.Add(Me.VISOR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MI WEBCAM"
        CType(Me.VISOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VISOR As System.Windows.Forms.PictureBox
    Friend WithEvents INICIAR As System.Windows.Forms.Button
    Friend WithEvents CAPTURAR As System.Windows.Forms.Button
    Friend WithEvents GUARDAR As System.Windows.Forms.Button
    Friend WithEvents GRABAR As System.Windows.Forms.Button
    Friend WithEvents FGRABAR As System.Windows.Forms.Button
    Friend WithEvents FORMATO As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents ButtonFINSERIEDIARIA As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
