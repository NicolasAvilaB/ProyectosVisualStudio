﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.preci = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Grilla_Productos = New System.Windows.Forms.DataGridView()
        Me.busqueda_productos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.regresar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.categoria = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Mensajes = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grilla_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(14, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 207)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.preci)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Grilla_Productos)
        Me.GroupBox1.Controls.Add(Me.busqueda_productos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.regresar)
        Me.GroupBox1.Controls.Add(Me.cancelar)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.eliminar)
        Me.GroupBox1.Controls.Add(Me.guardar)
        Me.GroupBox1.Controls.Add(Me.nuevo)
        Me.GroupBox1.Controls.Add(Me.categoria)
        Me.GroupBox1.Controls.Add(Me.cantidad)
        Me.GroupBox1.Controls.Add(Me.codigo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(599, 443)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 19)
        Me.Label8.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(161, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "ID:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(165, 237)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 41)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Compra Stock"
        Me.Mensajes.SetToolTip(Me.Button3, "Puedes reabastecer el stock comprando nuevos articulos")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'preci
        '
        Me.preci.Enabled = False
        Me.preci.Location = New System.Drawing.Point(238, 80)
        Me.preci.Name = "preci"
        Me.preci.ReadOnly = True
        Me.preci.Size = New System.Drawing.Size(348, 26)
        Me.preci.TabIndex = 1
        Me.Mensajes.SetToolTip(Me.preci, "Ingreso de precio de articulo")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(161, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 19)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Precio:"
        '
        'Grilla_Productos
        '
        Me.Grilla_Productos.AllowUserToAddRows = False
        Me.Grilla_Productos.AllowUserToDeleteRows = False
        Me.Grilla_Productos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Grilla_Productos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grilla_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Grilla_Productos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Grilla_Productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Grilla_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla_Productos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Grilla_Productos.EnableHeadersVisualStyles = False
        Me.Grilla_Productos.Location = New System.Drawing.Point(14, 284)
        Me.Grilla_Productos.MultiSelect = False
        Me.Grilla_Productos.Name = "Grilla_Productos"
        Me.Grilla_Productos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grilla_Productos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grilla_Productos.RowHeadersVisible = False
        Me.Grilla_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Grilla_Productos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Grilla_Productos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grilla_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla_Productos.ShowCellToolTips = False
        Me.Grilla_Productos.ShowEditingIcon = False
        Me.Grilla_Productos.Size = New System.Drawing.Size(572, 119)
        Me.Grilla_Productos.TabIndex = 21
        Me.Grilla_Productos.TabStop = False
        Me.Mensajes.SetToolTip(Me.Grilla_Productos, "Visualiza todos los articulos registrados en el programa")
        '
        'busqueda_productos
        '
        Me.busqueda_productos.Location = New System.Drawing.Point(117, 409)
        Me.busqueda_productos.Name = "busqueda_productos"
        Me.busqueda_productos.Size = New System.Drawing.Size(469, 26)
        Me.busqueda_productos.TabIndex = 11
        Me.Mensajes.SetToolTip(Me.busqueda_productos, "Haslo facil, busca el codigo del articulo aqui")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 412)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Buscar Codigo: "
        '
        'regresar
        '
        Me.regresar.BackColor = System.Drawing.SystemColors.Control
        Me.regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.regresar.Location = New System.Drawing.Point(14, 237)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(141, 41)
        Me.regresar.TabIndex = 7
        Me.regresar.Text = "<- Regresar"
        Me.Mensajes.SetToolTip(Me.regresar, "Vuelve a la pantalla anterior")
        Me.regresar.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelar.Enabled = False
        Me.cancelar.Location = New System.Drawing.Point(449, 237)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(137, 41)
        Me.cancelar.TabIndex = 10
        Me.cancelar.Text = "Cancelar"
        Me.Mensajes.SetToolTip(Me.cancelar, "Cancele las operaciones")
        Me.cancelar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.SystemColors.Control
        Me.modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modificar.Location = New System.Drawing.Point(308, 237)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(137, 41)
        Me.modificar.TabIndex = 9
        Me.modificar.Text = "Modificar"
        Me.Mensajes.SetToolTip(Me.modificar, "Modifica algun dato mal digitado")
        Me.modificar.UseVisualStyleBackColor = False
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.SystemColors.Control
        Me.eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eliminar.Location = New System.Drawing.Point(449, 184)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(137, 41)
        Me.eliminar.TabIndex = 6
        Me.eliminar.Text = "Eliminar"
        Me.Mensajes.SetToolTip(Me.eliminar, "Elimine algun articulo existente")
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'guardar
        '
        Me.guardar.BackColor = System.Drawing.SystemColors.Control
        Me.guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.guardar.Enabled = False
        Me.guardar.Location = New System.Drawing.Point(308, 184)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(137, 41)
        Me.guardar.TabIndex = 5
        Me.guardar.Text = "Guardar"
        Me.Mensajes.SetToolTip(Me.guardar, "Guarde todos los datos ingresados")
        Me.guardar.UseVisualStyleBackColor = False
        '
        'nuevo
        '
        Me.nuevo.BackColor = System.Drawing.SystemColors.Control
        Me.nuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nuevo.Location = New System.Drawing.Point(165, 184)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(137, 41)
        Me.nuevo.TabIndex = 4
        Me.nuevo.Text = "Nuevo"
        Me.Mensajes.SetToolTip(Me.nuevo, "Agrega nuevo articulo ingresando los datos en los campos")
        Me.nuevo.UseVisualStyleBackColor = False
        '
        'categoria
        '
        Me.categoria.Enabled = False
        Me.categoria.Location = New System.Drawing.Point(238, 146)
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Size = New System.Drawing.Size(348, 26)
        Me.categoria.TabIndex = 3
        Me.Mensajes.SetToolTip(Me.categoria, "Ingreso de categoria de articulo")
        '
        'cantidad
        '
        Me.cantidad.Enabled = False
        Me.cantidad.Location = New System.Drawing.Point(238, 113)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Size = New System.Drawing.Size(348, 26)
        Me.cantidad.TabIndex = 2
        Me.Mensajes.SetToolTip(Me.cantidad, "Ingreso de cantidad de articulo")
        '
        'codigo
        '
        Me.codigo.Enabled = False
        Me.codigo.Location = New System.Drawing.Point(238, 48)
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Size = New System.Drawing.Size(348, 26)
        Me.codigo.TabIndex = 0
        Me.Mensajes.SetToolTip(Me.codigo, "Ingreso de codigo de articulo")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Codigo:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(613, 33)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Municipalidad de Peralillo"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DimGray
        Me.Button2.Location = New System.Drawing.Point(550, 4)
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
        Me.Button1.Location = New System.Drawing.Point(583, 3)
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
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(613, 481)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Municipalidad de Peralillo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grilla_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents categoria As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents regresar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents guardar As Button
    Friend WithEvents nuevo As Button
    Friend WithEvents busqueda_productos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Grilla_Productos As DataGridView
    Friend WithEvents preci As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Mensajes As ToolTip
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
