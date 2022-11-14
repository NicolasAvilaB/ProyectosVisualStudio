<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompraProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompraProductos))
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GrillaCantidad = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GrillaCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Enabled = False
        Me.Guardar.Location = New System.Drawing.Point(12, 156)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(276, 50)
        Me.Guardar.TabIndex = 0
        Me.Guardar.Text = "Guardar Stock"
        Me.ToolTip1.SetToolTip(Me.Guardar, "Guardar Tu Stock de Productos")
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Location = New System.Drawing.Point(542, 156)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(276, 50)
        Me.Volver.TabIndex = 1
        Me.Volver.Text = "Volver"
        Me.ToolTip1.SetToolTip(Me.Volver, "Vuelve a la Pantalla Anterior")
        Me.Volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Buscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.Volver)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(830, 479)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Abastecimiento de Productos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GrillaCantidad)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(818, 261)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecciona un Producto"
        '
        'GrillaCantidad
        '
        Me.GrillaCantidad.AllowUserToAddRows = False
        Me.GrillaCantidad.AllowUserToDeleteRows = False
        Me.GrillaCantidad.AllowUserToResizeRows = False
        Me.GrillaCantidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrillaCantidad.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GrillaCantidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GrillaCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCantidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GrillaCantidad.Location = New System.Drawing.Point(6, 27)
        Me.GrillaCantidad.Name = "GrillaCantidad"
        Me.GrillaCantidad.ReadOnly = True
        Me.GrillaCantidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaCantidad.ShowCellToolTips = False
        Me.GrillaCantidad.Size = New System.Drawing.Size(806, 228)
        Me.GrillaCantidad.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.GrillaCantidad, "Selecciona el Producto Que Quieras Abastecer Nuevamente")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Busqueda de Producto :"
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(203, 107)
        Me.Buscar.MaxLength = 45
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(610, 28)
        Me.Buscar.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Buscar, "Escribe El Nombre del Producto Que Buscas")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad Stock :"
        '
        'Cantidad
        '
        Me.Cantidad.Enabled = False
        Me.Cantidad.Location = New System.Drawing.Point(154, 73)
        Me.Cantidad.MaxLength = 5
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(140, 28)
        Me.Cantidad.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.Cantidad, "Modifica la Cantidad de Stock del Producto")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre de Producto :"
        '
        'Nombre
        '
        Me.Nombre.Enabled = False
        Me.Nombre.Location = New System.Drawing.Point(194, 39)
        Me.Nombre.MaxLength = 45
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(619, 28)
        Me.Nombre.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Nombre, "Indica Nombre de Producto Seleccionado")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Mensaje"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(311, 495)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'CompraProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(855, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CompraProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GrillaCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.TextBox
    Friend WithEvents GrillaCantidad As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Buscar As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
