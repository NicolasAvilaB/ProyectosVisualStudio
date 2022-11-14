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
        Me.Nom_Pizza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cod_Pizza = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IMp = New System.Windows.Forms.Button()
        Me.Nueva = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BUsca = New System.Windows.Forms.Button()
        Me.Busca_Cos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Ingre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quitar = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Nom_Pizza)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cod_Pizza)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(182, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Pizzas"
        '
        'Nom_Pizza
        '
        Me.Nom_Pizza.Location = New System.Drawing.Point(10, 126)
        Me.Nom_Pizza.Name = "Nom_Pizza"
        Me.Nom_Pizza.Size = New System.Drawing.Size(154, 26)
        Me.Nom_Pizza.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Pizza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo Pizza"
        '
        'Cod_Pizza
        '
        Me.Cod_Pizza.Location = New System.Drawing.Point(10, 60)
        Me.Cod_Pizza.Name = "Cod_Pizza"
        Me.Cod_Pizza.Size = New System.Drawing.Size(154, 26)
        Me.Cod_Pizza.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IMp)
        Me.GroupBox2.Controls.Add(Me.Nueva)
        Me.GroupBox2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(200, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'IMp
        '
        Me.IMp.Location = New System.Drawing.Point(21, 116)
        Me.IMp.Name = "IMp"
        Me.IMp.Size = New System.Drawing.Size(122, 36)
        Me.IMp.TabIndex = 1
        Me.IMp.Text = "Imprimir Pizza"
        Me.IMp.UseVisualStyleBackColor = True
        '
        'Nueva
        '
        Me.Nueva.Location = New System.Drawing.Point(21, 36)
        Me.Nueva.Name = "Nueva"
        Me.Nueva.Size = New System.Drawing.Size(122, 36)
        Me.Nueva.TabIndex = 0
        Me.Nueva.Text = "Nueva Pizza"
        Me.Nueva.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BUsca)
        Me.GroupBox3.Controls.Add(Me.Busca_Cos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(371, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 170)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Busca Pïzza"
        '
        'BUsca
        '
        Me.BUsca.Location = New System.Drawing.Point(40, 91)
        Me.BUsca.Name = "BUsca"
        Me.BUsca.Size = New System.Drawing.Size(150, 32)
        Me.BUsca.TabIndex = 5
        Me.BUsca.Text = "Buscar"
        Me.BUsca.UseVisualStyleBackColor = True
        '
        'Busca_Cos
        '
        Me.Busca_Cos.Location = New System.Drawing.Point(110, 33)
        Me.Busca_Cos.Name = "Busca_Cos"
        Me.Busca_Cos.Size = New System.Drawing.Size(117, 26)
        Me.Busca_Cos.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo Pizza"
        '
        'Cantidad
        '
        Me.Cantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cantidad.Location = New System.Drawing.Point(462, 460)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Size = New System.Drawing.Size(136, 26)
        Me.Cantidad.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(279, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Cantidad de Ingredientes"
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(12, 458)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(151, 29)
        Me.Guardar.TabIndex = 12
        Me.Guardar.Text = "Guardar Pizza"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Borrar)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.Nombre_Ingre)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Agregar)
        Me.GroupBox4.Controls.Add(Me.grilla)
        Me.GroupBox4.Controls.Add(Me.Quitar)
        Me.GroupBox4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(603, 229)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ingredientes"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(470, 150)
        Me.DataGridView1.TabIndex = 9
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre Ingrediente"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Nombre_Ingre
        '
        Me.Nombre_Ingre.Location = New System.Drawing.Point(157, 25)
        Me.Nombre_Ingre.Name = "Nombre_Ingre"
        Me.Nombre_Ingre.Size = New System.Drawing.Size(179, 26)
        Me.Nombre_Ingre.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Nombre Ingrediente"
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(342, 22)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(125, 31)
        Me.Agregar.TabIndex = 6
        Me.Agregar.Text = "Agregar Ingrediente"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.grilla.Location = New System.Drawing.Point(17, 70)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.RowHeadersVisible = False
        Me.grilla.Size = New System.Drawing.Size(470, 143)
        Me.grilla.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "Ingredientes"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Quitar
        '
        Me.Quitar.Location = New System.Drawing.Point(493, 173)
        Me.Quitar.Name = "Quitar"
        Me.Quitar.Size = New System.Drawing.Size(93, 47)
        Me.Quitar.TabIndex = 4
        Me.Quitar.Text = "Quitar Ingrediente"
        Me.Quitar.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.Location = New System.Drawing.Point(493, 70)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(93, 66)
        Me.Borrar.TabIndex = 10
        Me.Borrar.Text = "Borrar Registros"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 497)
        Me.Controls.Add(Me.Cantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BDCONTROL2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Nom_Pizza As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cod_Pizza As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IMp As System.Windows.Forms.Button
    Friend WithEvents Nueva As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BUsca As System.Windows.Forms.Button
    Friend WithEvents Busca_Cos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre_Ingre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quitar As System.Windows.Forms.Button
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Borrar As System.Windows.Forms.Button

End Class
