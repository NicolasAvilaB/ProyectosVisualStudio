<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txtTELEFONO = New System.Windows.Forms.TextBox()
        Me.txtDIRECCION = New System.Windows.Forms.TextBox()
        Me.txtNOMBRE = New System.Windows.Forms.TextBox()
        Me.txtRUT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTSalir = New System.Windows.Forms.Button()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTGuardar = New System.Windows.Forms.Button()
        Me.BTImprimir = New System.Windows.Forms.Button()
        Me.BTEliminar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.BTNuevo = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBUSCAR = New System.Windows.Forms.TextBox()
        Me.cbBUSCAR = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BTUltimo = New System.Windows.Forms.Button()
        Me.BTSiguiente = New System.Windows.Forms.Button()
        Me.BTAnterior = New System.Windows.Forms.Button()
        Me.BTPrimero = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTELEFONO)
        Me.GroupBox1.Controls.Add(Me.txtDIRECCION)
        Me.GroupBox1.Controls.Add(Me.txtNOMBRE)
        Me.GroupBox1.Controls.Add(Me.txtRUT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 156)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE CLIENTES"
        '
        'txtTELEFONO
        '
        Me.txtTELEFONO.Location = New System.Drawing.Point(78, 115)
        Me.txtTELEFONO.Name = "txtTELEFONO"
        Me.txtTELEFONO.ReadOnly = True
        Me.txtTELEFONO.Size = New System.Drawing.Size(100, 20)
        Me.txtTELEFONO.TabIndex = 7
        '
        'txtDIRECCION
        '
        Me.txtDIRECCION.Location = New System.Drawing.Point(78, 85)
        Me.txtDIRECCION.Name = "txtDIRECCION"
        Me.txtDIRECCION.ReadOnly = True
        Me.txtDIRECCION.Size = New System.Drawing.Size(100, 20)
        Me.txtDIRECCION.TabIndex = 6
        '
        'txtNOMBRE
        '
        Me.txtNOMBRE.Location = New System.Drawing.Point(77, 56)
        Me.txtNOMBRE.Name = "txtNOMBRE"
        Me.txtNOMBRE.ReadOnly = True
        Me.txtNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.txtNOMBRE.TabIndex = 5
        '
        'txtRUT
        '
        Me.txtRUT.Location = New System.Drawing.Point(54, 27)
        Me.txtRUT.Name = "txtRUT"
        Me.txtRUT.ReadOnly = True
        Me.txtRUT.Size = New System.Drawing.Size(100, 20)
        Me.txtRUT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELEFONO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DIRECCION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RUT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTSalir)
        Me.GroupBox2.Controls.Add(Me.BTCancelar)
        Me.GroupBox2.Controls.Add(Me.BTGuardar)
        Me.GroupBox2.Controls.Add(Me.BTImprimir)
        Me.GroupBox2.Controls.Add(Me.BTEliminar)
        Me.GroupBox2.Controls.Add(Me.BTModificar)
        Me.GroupBox2.Controls.Add(Me.BTNuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(268, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(90, 241)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTSalir
        '
        Me.BTSalir.Location = New System.Drawing.Point(6, 206)
        Me.BTSalir.Name = "BTSalir"
        Me.BTSalir.Size = New System.Drawing.Size(75, 23)
        Me.BTSalir.TabIndex = 3
        Me.BTSalir.Text = "Salir"
        Me.BTSalir.UseVisualStyleBackColor = True
        '
        'BTCancelar
        '
        Me.BTCancelar.Enabled = False
        Me.BTCancelar.Location = New System.Drawing.Point(6, 177)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BTCancelar.TabIndex = 2
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = True
        '
        'BTGuardar
        '
        Me.BTGuardar.Enabled = False
        Me.BTGuardar.Location = New System.Drawing.Point(6, 148)
        Me.BTGuardar.Name = "BTGuardar"
        Me.BTGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BTGuardar.TabIndex = 2
        Me.BTGuardar.Text = "Guardar"
        Me.BTGuardar.UseVisualStyleBackColor = True
        '
        'BTImprimir
        '
        Me.BTImprimir.Location = New System.Drawing.Point(6, 108)
        Me.BTImprimir.Name = "BTImprimir"
        Me.BTImprimir.Size = New System.Drawing.Size(75, 23)
        Me.BTImprimir.TabIndex = 2
        Me.BTImprimir.Text = "Imprimir"
        Me.BTImprimir.UseVisualStyleBackColor = True
        '
        'BTEliminar
        '
        Me.BTEliminar.Location = New System.Drawing.Point(6, 78)
        Me.BTEliminar.Name = "BTEliminar"
        Me.BTEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BTEliminar.TabIndex = 2
        Me.BTEliminar.Text = "Eliminar"
        Me.BTEliminar.UseVisualStyleBackColor = True
        '
        'BTModificar
        '
        Me.BTModificar.Location = New System.Drawing.Point(6, 49)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(75, 23)
        Me.BTModificar.TabIndex = 2
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = True
        '
        'BTNuevo
        '
        Me.BTNuevo.Location = New System.Drawing.Point(7, 20)
        Me.BTNuevo.Name = "BTNuevo"
        Me.BTNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BTNuevo.TabIndex = 0
        Me.BTNuevo.Text = "Nuevo"
        Me.BTNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtBUSCAR)
        Me.GroupBox3.Controls.Add(Me.cbBUSCAR)
        Me.GroupBox3.Location = New System.Drawing.Point(397, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 94)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BUSCAR POR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "VALOR DE BUSQUEDA"
        '
        'txtBUSCAR
        '
        Me.txtBUSCAR.Location = New System.Drawing.Point(6, 68)
        Me.txtBUSCAR.Name = "txtBUSCAR"
        Me.txtBUSCAR.Size = New System.Drawing.Size(160, 20)
        Me.txtBUSCAR.TabIndex = 1
        '
        'cbBUSCAR
        '
        Me.cbBUSCAR.FormattingEnabled = True
        Me.cbBUSCAR.Items.AddRange(New Object() {"Rut", "Nombre", "Direccion ", "Telefono"})
        Me.cbBUSCAR.Location = New System.Drawing.Point(7, 20)
        Me.cbBUSCAR.Name = "cbBUSCAR"
        Me.cbBUSCAR.Size = New System.Drawing.Size(160, 21)
        Me.cbBUSCAR.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(397, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(303, 132)
        Me.DataGridView1.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTUltimo)
        Me.GroupBox4.Controls.Add(Me.BTSiguiente)
        Me.GroupBox4.Controls.Add(Me.BTAnterior)
        Me.GroupBox4.Controls.Add(Me.BTPrimero)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 78)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'BTUltimo
        '
        Me.BTUltimo.Location = New System.Drawing.Point(150, 14)
        Me.BTUltimo.Name = "BTUltimo"
        Me.BTUltimo.Size = New System.Drawing.Size(42, 37)
        Me.BTUltimo.TabIndex = 5
        Me.BTUltimo.Text = ">>"
        Me.BTUltimo.UseVisualStyleBackColor = True
        '
        'BTSiguiente
        '
        Me.BTSiguiente.Location = New System.Drawing.Point(102, 14)
        Me.BTSiguiente.Name = "BTSiguiente"
        Me.BTSiguiente.Size = New System.Drawing.Size(42, 37)
        Me.BTSiguiente.TabIndex = 2
        Me.BTSiguiente.Text = ">"
        Me.BTSiguiente.UseVisualStyleBackColor = True
        '
        'BTAnterior
        '
        Me.BTAnterior.Location = New System.Drawing.Point(54, 14)
        Me.BTAnterior.Name = "BTAnterior"
        Me.BTAnterior.Size = New System.Drawing.Size(42, 37)
        Me.BTAnterior.TabIndex = 1
        Me.BTAnterior.Text = "<"
        Me.BTAnterior.UseVisualStyleBackColor = True
        '
        'BTPrimero
        '
        Me.BTPrimero.Location = New System.Drawing.Point(5, 14)
        Me.BTPrimero.Name = "BTPrimero"
        Me.BTPrimero.Size = New System.Drawing.Size(43, 37)
        Me.BTPrimero.TabIndex = 0
        Me.BTPrimero.Text = "<<"
        Me.BTPrimero.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 257)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(687, 126)
        Me.DataGridView2.TabIndex = 5
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 395)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents txtDIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents txtRUT As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTSalir As System.Windows.Forms.Button
    Friend WithEvents BTCancelar As System.Windows.Forms.Button
    Friend WithEvents BTGuardar As System.Windows.Forms.Button
    Friend WithEvents BTImprimir As System.Windows.Forms.Button
    Friend WithEvents BTEliminar As System.Windows.Forms.Button
    Friend WithEvents BTModificar As System.Windows.Forms.Button
    Friend WithEvents BTNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBUSCAR As System.Windows.Forms.TextBox
    Friend WithEvents cbBUSCAR As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BTUltimo As System.Windows.Forms.Button
    Friend WithEvents BTSiguiente As System.Windows.Forms.Button
    Friend WithEvents BTAnterior As System.Windows.Forms.Button
    Friend WithEvents BTPrimero As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
