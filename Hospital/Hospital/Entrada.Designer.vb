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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Vero = New System.Windows.Forms.Button()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.Usua = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cANCELAR = New System.Windows.Forms.Button()
        Me.cONECTAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Vero)
        Me.GroupBox1.Controls.Add(Me.Contraseña)
        Me.GroupBox1.Controls.Add(Me.Usua)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cANCELAR)
        Me.GroupBox1.Controls.Add(Me.cONECTAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(526, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'Vero
        '
        Me.Vero.Enabled = False
        Me.Vero.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vero.Location = New System.Drawing.Point(436, 81)
        Me.Vero.Name = "Vero"
        Me.Vero.Size = New System.Drawing.Size(84, 29)
        Me.Vero.TabIndex = 6
        Me.Vero.Text = "Ver"
        Me.Vero.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.Contraseña.Enabled = False
        Me.Contraseña.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contraseña.Location = New System.Drawing.Point(107, 82)
        Me.Contraseña.Multiline = True
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Contraseña.Size = New System.Drawing.Size(323, 28)
        Me.Contraseña.TabIndex = 5
        '
        'Usua
        '
        Me.Usua.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usua.Location = New System.Drawing.Point(85, 34)
        Me.Usua.Multiline = True
        Me.Usua.Name = "Usua"
        Me.Usua.Size = New System.Drawing.Size(435, 27)
        Me.Usua.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'cANCELAR
        '
        Me.cANCELAR.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cANCELAR.Location = New System.Drawing.Point(331, 127)
        Me.cANCELAR.Name = "cANCELAR"
        Me.cANCELAR.Size = New System.Drawing.Size(189, 53)
        Me.cANCELAR.TabIndex = 1
        Me.cANCELAR.Text = "Salir"
        Me.cANCELAR.UseVisualStyleBackColor = True
        '
        'cONECTAR
        '
        Me.cONECTAR.Enabled = False
        Me.cONECTAR.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cONECTAR.Location = New System.Drawing.Point(6, 131)
        Me.cONECTAR.Name = "cONECTAR"
        Me.cONECTAR.Size = New System.Drawing.Size(190, 49)
        Me.cONECTAR.TabIndex = 0
        Me.cONECTAR.Text = "Conectar"
        Me.cONECTAR.UseVisualStyleBackColor = True
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 210)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Entrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cANCELAR As System.Windows.Forms.Button
    Friend WithEvents cONECTAR As System.Windows.Forms.Button
    Friend WithEvents Contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Usua As System.Windows.Forms.TextBox
    Friend WithEvents Vero As System.Windows.Forms.Button

End Class
