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
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.direccion = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hist = New System.Windows.Forms.DataGridView()
        Me.Cod_Prestamo = New System.Windows.Forms.TextBox()
        Me.Patente = New System.Windows.Forms.TextBox()
        Me.Marca = New System.Windows.Forms.TextBox()
        Me.Modelo = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Cod_producto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RUT = New System.Windows.Forms.ComboBox()
        Me.Patente_1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.marca1 = New System.Windows.Forms.TextBox()
        Me.Modelo1 = New System.Windows.Forms.TextBox()
        Me.Estado1 = New System.Windows.Forms.TextBox()
        Me.devolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fecha = New System.Windows.Forms.Label()
        Me.hi2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.hist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hi2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.hi2)
        Me.GroupBox1.Controls.Add(Me.fecha)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.devolver)
        Me.GroupBox1.Controls.Add(Me.Estado1)
        Me.GroupBox1.Controls.Add(Me.Modelo1)
        Me.GroupBox1.Controls.Add(Me.marca1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Patente_1)
        Me.GroupBox1.Controls.Add(Me.RUT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cod_producto)
        Me.GroupBox1.Controls.Add(Me.Estado)
        Me.GroupBox1.Controls.Add(Me.Modelo)
        Me.GroupBox1.Controls.Add(Me.Marca)
        Me.GroupBox1.Controls.Add(Me.Patente)
        Me.GroupBox1.Controls.Add(Me.Cod_Prestamo)
        Me.GroupBox1.Controls.Add(Me.hist)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.telefono)
        Me.GroupBox1.Controls.Add(Me.direccion)
        Me.GroupBox1.Controls.Add(Me.nombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso Datos"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(198, 44)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 1
        '
        'direccion
        '
        Me.direccion.Location = New System.Drawing.Point(333, 44)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(100, 20)
        Me.direccion.TabIndex = 2
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(464, 44)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(100, 20)
        Me.telefono.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rut"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "telefono"
        '
        'hist
        '
        Me.hist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hist.Location = New System.Drawing.Point(23, 85)
        Me.hist.Name = "hist"
        Me.hist.Size = New System.Drawing.Size(487, 126)
        Me.hist.TabIndex = 8
        '
        'Cod_Prestamo
        '
        Me.Cod_Prestamo.Location = New System.Drawing.Point(617, 108)
        Me.Cod_Prestamo.Name = "Cod_Prestamo"
        Me.Cod_Prestamo.Size = New System.Drawing.Size(100, 20)
        Me.Cod_Prestamo.TabIndex = 9
        '
        'Patente
        '
        Me.Patente.Location = New System.Drawing.Point(617, 148)
        Me.Patente.Name = "Patente"
        Me.Patente.Size = New System.Drawing.Size(100, 20)
        Me.Patente.TabIndex = 10
        '
        'Marca
        '
        Me.Marca.Location = New System.Drawing.Point(627, 191)
        Me.Marca.Name = "Marca"
        Me.Marca.Size = New System.Drawing.Size(100, 20)
        Me.Marca.TabIndex = 11
        '
        'Modelo
        '
        Me.Modelo.Location = New System.Drawing.Point(627, 230)
        Me.Modelo.Name = "Modelo"
        Me.Modelo.Size = New System.Drawing.Size(100, 20)
        Me.Modelo.TabIndex = 12
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(617, 275)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(100, 20)
        Me.Estado.TabIndex = 13
        '
        'Cod_producto
        '
        Me.Cod_producto.AutoSize = True
        Me.Cod_producto.Location = New System.Drawing.Point(532, 108)
        Me.Cod_producto.Name = "Cod_producto"
        Me.Cod_producto.Size = New System.Drawing.Size(75, 13)
        Me.Cod_producto.TabIndex = 14
        Me.Cod_producto.Text = "Cod_Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Patente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(541, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Tag = ""
        Me.Label6.Text = "Marca"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(541, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Tag = ""
        Me.Label7.Text = "Modelo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(541, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Tag = ""
        Me.Label8.Text = "Estado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RUT
        '
        Me.RUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RUT.FormattingEnabled = True
        Me.RUT.Location = New System.Drawing.Point(23, 42)
        Me.RUT.Name = "RUT"
        Me.RUT.Size = New System.Drawing.Size(121, 21)
        Me.RUT.TabIndex = 19
        '
        'Patente_1
        '
        Me.Patente_1.FormattingEnabled = True
        Me.Patente_1.Location = New System.Drawing.Point(26, 364)
        Me.Patente_1.Name = "Patente_1"
        Me.Patente_1.Size = New System.Drawing.Size(121, 21)
        Me.Patente_1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Patente Vehiculo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(180, 345)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Marca"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(293, 345)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Modelo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(420, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Estado"
        '
        'marca1
        '
        Me.marca1.Location = New System.Drawing.Point(183, 364)
        Me.marca1.Name = "marca1"
        Me.marca1.Size = New System.Drawing.Size(100, 20)
        Me.marca1.TabIndex = 25
        '
        'Modelo1
        '
        Me.Modelo1.Location = New System.Drawing.Point(302, 365)
        Me.Modelo1.Name = "Modelo1"
        Me.Modelo1.Size = New System.Drawing.Size(100, 20)
        Me.Modelo1.TabIndex = 26
        '
        'Estado1
        '
        Me.Estado1.Location = New System.Drawing.Point(427, 365)
        Me.Estado1.Name = "Estado1"
        Me.Estado1.Size = New System.Drawing.Size(100, 20)
        Me.Estado1.TabIndex = 27
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(608, 318)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(130, 23)
        Me.devolver.TabIndex = 28
        Me.devolver.Text = "devolver"
        Me.devolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "prestamo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fecha
        '
        Me.fecha.AutoSize = True
        Me.fecha.Location = New System.Drawing.Point(624, 45)
        Me.fecha.Name = "fecha"
        Me.fecha.Size = New System.Drawing.Size(65, 13)
        Me.fecha.TabIndex = 30
        Me.fecha.Text = "00/00/0000"
        '
        'hi2
        '
        Me.hi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hi2.Location = New System.Drawing.Point(23, 230)
        Me.hi2.Name = "hi2"
        Me.hi2.Size = New System.Drawing.Size(487, 94)
        Me.hi2.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 426)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.hist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hi2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents hist As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.TextBox
    Friend WithEvents direccion As System.Windows.Forms.TextBox
    Friend WithEvents nombre As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents devolver As System.Windows.Forms.Button
    Friend WithEvents Estado1 As System.Windows.Forms.TextBox
    Friend WithEvents Modelo1 As System.Windows.Forms.TextBox
    Friend WithEvents marca1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Patente_1 As System.Windows.Forms.ComboBox
    Friend WithEvents RUT As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cod_producto As System.Windows.Forms.Label
    Friend WithEvents Estado As System.Windows.Forms.TextBox
    Friend WithEvents Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Marca As System.Windows.Forms.TextBox
    Friend WithEvents Patente As System.Windows.Forms.TextBox
    Friend WithEvents Cod_Prestamo As System.Windows.Forms.TextBox
    Friend WithEvents fecha As System.Windows.Forms.Label
    Friend WithEvents hi2 As System.Windows.Forms.DataGridView

End Class
