<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.f = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cantop = New System.Windows.Forms.TextBox()
        Me.agregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pre = New System.Windows.Forms.TextBox()
        Me.cod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.f)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.cantop)
        Me.GroupBox1.Controls.Add(Me.agregar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pre)
        Me.GroupBox1.Controls.Add(Me.cod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 404)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'f
        '
        Me.f.Enabled = False
        Me.f.Location = New System.Drawing.Point(566, 24)
        Me.f.Name = "f"
        Me.f.ReadOnly = True
        Me.f.Size = New System.Drawing.Size(144, 26)
        Me.f.TabIndex = 11
        Me.f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(10, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 233)
        Me.Panel1.TabIndex = 10
        '
        'cantop
        '
        Me.cantop.Enabled = False
        Me.cantop.Location = New System.Drawing.Point(566, 92)
        Me.cantop.Name = "cantop"
        Me.cantop.ReadOnly = True
        Me.cantop.Size = New System.Drawing.Size(144, 26)
        Me.cantop.TabIndex = 9
        Me.cantop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.SystemColors.Control
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.Location = New System.Drawing.Point(566, 121)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(144, 35)
        Me.agregar.TabIndex = 8
        Me.agregar.Text = "CREAR OPCIONES"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(562, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CANTIDAD OPCIONES:"
        '
        'pre
        '
        Me.pre.Enabled = False
        Me.pre.Location = New System.Drawing.Point(101, 92)
        Me.pre.Multiline = True
        Me.pre.Name = "pre"
        Me.pre.ReadOnly = True
        Me.pre.Size = New System.Drawing.Size(455, 64)
        Me.pre.TabIndex = 6
        '
        'cod
        '
        Me.cod.Enabled = False
        Me.cod.Location = New System.Drawing.Point(81, 60)
        Me.cod.Name = "cod"
        Me.cod.ReadOnly = True
        Me.cod.Size = New System.Drawing.Size(475, 26)
        Me.cod.TabIndex = 5
        Me.cod.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PREGUNTA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CODIGO:"
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(264, 19)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(129, 37)
        Me.cancelar.TabIndex = 2
        Me.cancelar.Text = "CANCELAR"
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(135, 19)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(123, 37)
        Me.guardar.TabIndex = 1
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(10, 19)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(119, 37)
        Me.nuevo.TabIndex = 0
        Me.nuevo.Text = "NUEVO"
        Me.nuevo.UseVisualStyleBackColor = False
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
        Me.Panel2.Size = New System.Drawing.Size(730, 33)
        Me.Panel2.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "NUEVA ENCUESTA"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DimGray
        Me.Button5.Location = New System.Drawing.Point(666, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 27)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "---"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DimGray
        Me.Button6.Location = New System.Drawing.Point(699, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(27, 27)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(399, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "DATOS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nuevo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents pre As TextBox
    Friend WithEvents cod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cancelar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cantop As TextBox
    Friend WithEvents agregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents f As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
