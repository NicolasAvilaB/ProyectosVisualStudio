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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Codigo = New System.Windows.Forms.ComboBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.NOmbreLibro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DevueltoLibro = New System.Windows.Forms.Button()
        Me.Prestamo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nomin = New System.Windows.Forms.TextBox()
        Me.Rutes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Libreria"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 234)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(821, 180)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Libros Prestados"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(784, 136)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Codigo)
        Me.GroupBox4.Controls.Add(Me.Estado)
        Me.GroupBox4.Controls.Add(Me.NOmbreLibro)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 127)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(821, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos Libros"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(639, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(170, 33)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Borrar Prestamo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(575, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Label6"
        Me.Label6.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(639, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Eliminar Libros"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Codigo
        '
        Me.Codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Codigo.FormattingEnabled = True
        Me.Codigo.Location = New System.Drawing.Point(25, 57)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(204, 27)
        Me.Codigo.TabIndex = 5
        '
        'Estado
        '
        Me.Estado.Enabled = False
        Me.Estado.Location = New System.Drawing.Point(433, 57)
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Size = New System.Drawing.Size(192, 26)
        Me.Estado.TabIndex = 4
        '
        'NOmbreLibro
        '
        Me.NOmbreLibro.Enabled = False
        Me.NOmbreLibro.Location = New System.Drawing.Point(235, 57)
        Me.NOmbreLibro.Name = "NOmbreLibro"
        Me.NOmbreLibro.ReadOnly = True
        Me.NOmbreLibro.Size = New System.Drawing.Size(192, 26)
        Me.NOmbreLibro.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(231, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DevueltoLibro)
        Me.GroupBox3.Controls.Add(Me.Prestamo)
        Me.GroupBox3.Location = New System.Drawing.Point(512, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(325, 96)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'DevueltoLibro
        '
        Me.DevueltoLibro.Location = New System.Drawing.Point(177, 34)
        Me.DevueltoLibro.Name = "DevueltoLibro"
        Me.DevueltoLibro.Size = New System.Drawing.Size(136, 43)
        Me.DevueltoLibro.TabIndex = 1
        Me.DevueltoLibro.Text = "Devolver Libro"
        Me.DevueltoLibro.UseVisualStyleBackColor = True
        '
        'Prestamo
        '
        Me.Prestamo.Location = New System.Drawing.Point(15, 34)
        Me.Prestamo.Name = "Prestamo"
        Me.Prestamo.Size = New System.Drawing.Size(136, 43)
        Me.Prestamo.TabIndex = 0
        Me.Prestamo.Text = "Prestar Libro"
        Me.Prestamo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Nomin)
        Me.GroupBox2.Controls.Add(Me.Rutes)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 96)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Usuarios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Rut"
        '
        'Nomin
        '
        Me.Nomin.Enabled = False
        Me.Nomin.Location = New System.Drawing.Point(235, 51)
        Me.Nomin.Name = "Nomin"
        Me.Nomin.ReadOnly = True
        Me.Nomin.Size = New System.Drawing.Size(237, 26)
        Me.Nomin.TabIndex = 1
        '
        'Rutes
        '
        Me.Rutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rutes.FormattingEnabled = True
        Me.Rutes.Location = New System.Drawing.Point(25, 51)
        Me.Rutes.Name = "Rutes"
        Me.Rutes.Size = New System.Drawing.Size(204, 27)
        Me.Rutes.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestamo y Devoluciones de Libros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Codigo As ComboBox
    Friend WithEvents Estado As TextBox
    Friend WithEvents NOmbreLibro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DevueltoLibro As Button
    Friend WithEvents Prestamo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Nomin As TextBox
    Friend WithEvents Rutes As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
End Class
