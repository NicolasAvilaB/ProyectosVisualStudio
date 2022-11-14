<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNventa = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.BtAgregarProducto = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtNuevaVenta = New System.Windows.Forms.Button()
        Me.BtGrabarVenta = New System.Windows.Forms.Button()
        Me.BtImprimir = New System.Windows.Forms.Button()
        Me.BtCancelar = New System.Windows.Forms.Button()
        Me.BtBuscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtQuitar = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Venta"
        '
        'TxtNventa
        '
        Me.TxtNventa.Location = New System.Drawing.Point(13, 30)
        Me.TxtNventa.Multiline = True
        Me.TxtNventa.Name = "TxtNventa"
        Me.TxtNventa.Size = New System.Drawing.Size(100, 20)
        Me.TxtNventa.TabIndex = 2
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(160, 30)
        Me.TxtFecha.Multiline = True
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.TxtFecha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre del Producto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio Unitario Producto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(343, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cantidad a Vender"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(19, 136)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(169, 136)
        Me.TxtPrecio.Multiline = True
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrecio.TabIndex = 8
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(338, 136)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidad.TabIndex = 9
        '
        'BtAgregarProducto
        '
        Me.BtAgregarProducto.Enabled = False
        Me.BtAgregarProducto.Location = New System.Drawing.Point(316, 61)
        Me.BtAgregarProducto.Name = "BtAgregarProducto"
        Me.BtAgregarProducto.Size = New System.Drawing.Size(153, 33)
        Me.BtAgregarProducto.TabIndex = 10
        Me.BtAgregarProducto.Text = "Agregar Producto"
        Me.BtAgregarProducto.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 162)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(470, 150)
        Me.DataGridView1.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre Producto"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio Unitario"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Total"
        Me.Column4.Name = "Column4"
        '
        'BtNuevaVenta
        '
        Me.BtNuevaVenta.Location = New System.Drawing.Point(17, 10)
        Me.BtNuevaVenta.Name = "BtNuevaVenta"
        Me.BtNuevaVenta.Size = New System.Drawing.Size(95, 23)
        Me.BtNuevaVenta.TabIndex = 12
        Me.BtNuevaVenta.Text = "Nueva Venta"
        Me.BtNuevaVenta.UseVisualStyleBackColor = True
        '
        'BtGrabarVenta
        '
        Me.BtGrabarVenta.Enabled = False
        Me.BtGrabarVenta.Location = New System.Drawing.Point(5, 42)
        Me.BtGrabarVenta.Name = "BtGrabarVenta"
        Me.BtGrabarVenta.Size = New System.Drawing.Size(117, 40)
        Me.BtGrabarVenta.TabIndex = 13
        Me.BtGrabarVenta.Text = "Guardar o Grabar Venta "
        Me.BtGrabarVenta.UseVisualStyleBackColor = True
        '
        'BtImprimir
        '
        Me.BtImprimir.Enabled = False
        Me.BtImprimir.Location = New System.Drawing.Point(6, 88)
        Me.BtImprimir.Name = "BtImprimir"
        Me.BtImprimir.Size = New System.Drawing.Size(117, 23)
        Me.BtImprimir.TabIndex = 14
        Me.BtImprimir.Text = "Imprimir"
        Me.BtImprimir.UseVisualStyleBackColor = True
        '
        'BtCancelar
        '
        Me.BtCancelar.Enabled = False
        Me.BtCancelar.Location = New System.Drawing.Point(6, 117)
        Me.BtCancelar.Name = "BtCancelar"
        Me.BtCancelar.Size = New System.Drawing.Size(117, 23)
        Me.BtCancelar.TabIndex = 15
        Me.BtCancelar.Text = "Cancelar"
        Me.BtCancelar.UseVisualStyleBackColor = True
        '
        'BtBuscar
        '
        Me.BtBuscar.Enabled = False
        Me.BtBuscar.Location = New System.Drawing.Point(6, 209)
        Me.BtBuscar.Name = "BtBuscar"
        Me.BtBuscar.Size = New System.Drawing.Size(116, 23)
        Me.BtBuscar.TabIndex = 16
        Me.BtBuscar.Text = "Buscar"
        Me.BtBuscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Buscar Venta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Numero de Venta"
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(12, 183)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.TxtBuscar.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtBuscar)
        Me.GroupBox1.Controls.Add(Me.TxtBuscar)
        Me.GroupBox1.Controls.Add(Me.BtNuevaVenta)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.BtGrabarVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtImprimir)
        Me.GroupBox1.Controls.Add(Me.BtCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 261)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'BtQuitar
        '
        Me.BtQuitar.Enabled = False
        Me.BtQuitar.Location = New System.Drawing.Point(12, 319)
        Me.BtQuitar.Name = "BtQuitar"
        Me.BtQuitar.Size = New System.Drawing.Size(153, 33)
        Me.BtQuitar.TabIndex = 21
        Me.BtQuitar.Text = "Quitar Producto"
        Me.BtQuitar.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(437, 329)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 22
        Me.TxtTotal.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Total Venta"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 361)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.BtQuitar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtAgregarProducto)
        Me.Controls.Add(Me.TxtCantidad)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.TxtNventa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNventa As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents TxtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BtAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtNuevaVenta As System.Windows.Forms.Button
    Friend WithEvents BtGrabarVenta As System.Windows.Forms.Button
    Friend WithEvents BtImprimir As System.Windows.Forms.Button
    Friend WithEvents BtCancelar As System.Windows.Forms.Button
    Friend WithEvents BtBuscar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtQuitar As System.Windows.Forms.Button
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
