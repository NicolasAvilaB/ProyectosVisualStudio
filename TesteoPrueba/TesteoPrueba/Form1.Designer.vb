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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRUT = New System.Windows.Forms.TextBox()
        Me.TxtNOMBRE = New System.Windows.Forms.TextBox()
        Me.TxtTELEFONO = New System.Windows.Forms.TextBox()
        Me.BTAgregar = New System.Windows.Forms.Button()
        Me.BTACEPTAR = New System.Windows.Forms.Button()
        Me.BTANTERIOR = New System.Windows.Forms.Button()
        Me.BTSIGUIENTE = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.BTELIMINAR = New System.Windows.Forms.Button()
        Me.BTCANCELAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RDBTMUJER = New System.Windows.Forms.RadioButton()
        Me.RDBTHOMBRE = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CHBHABILITADO = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BTPRIMER = New System.Windows.Forms.Button()
        Me.BTULTIMO = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "RUT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELEFONO"
        '
        'TxtRUT
        '
        Me.TxtRUT.Location = New System.Drawing.Point(80, 20)
        Me.TxtRUT.Name = "TxtRUT"
        Me.TxtRUT.ReadOnly = True
        Me.TxtRUT.Size = New System.Drawing.Size(200, 20)
        Me.TxtRUT.TabIndex = 4
        '
        'TxtNOMBRE
        '
        Me.TxtNOMBRE.Location = New System.Drawing.Point(80, 49)
        Me.TxtNOMBRE.Name = "TxtNOMBRE"
        Me.TxtNOMBRE.ReadOnly = True
        Me.TxtNOMBRE.Size = New System.Drawing.Size(200, 20)
        Me.TxtNOMBRE.TabIndex = 5
        '
        'TxtTELEFONO
        '
        Me.TxtTELEFONO.Location = New System.Drawing.Point(80, 75)
        Me.TxtTELEFONO.Name = "TxtTELEFONO"
        Me.TxtTELEFONO.ReadOnly = True
        Me.TxtTELEFONO.Size = New System.Drawing.Size(200, 20)
        Me.TxtTELEFONO.TabIndex = 6
        '
        'BTAgregar
        '
        Me.BTAgregar.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAgregar.Location = New System.Drawing.Point(6, 19)
        Me.BTAgregar.Name = "BTAgregar"
        Me.BTAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BTAgregar.TabIndex = 7
        Me.BTAgregar.Text = "Agregar"
        Me.BTAgregar.UseVisualStyleBackColor = True
        '
        'BTACEPTAR
        '
        Me.BTACEPTAR.Enabled = False
        Me.BTACEPTAR.Location = New System.Drawing.Point(6, 132)
        Me.BTACEPTAR.Name = "BTACEPTAR"
        Me.BTACEPTAR.Size = New System.Drawing.Size(75, 23)
        Me.BTACEPTAR.TabIndex = 8
        Me.BTACEPTAR.Text = "Aceptar"
        Me.BTACEPTAR.UseVisualStyleBackColor = True
        '
        'BTANTERIOR
        '
        Me.BTANTERIOR.Enabled = False
        Me.BTANTERIOR.Location = New System.Drawing.Point(44, 10)
        Me.BTANTERIOR.Name = "BTANTERIOR"
        Me.BTANTERIOR.Size = New System.Drawing.Size(29, 23)
        Me.BTANTERIOR.TabIndex = 9
        Me.BTANTERIOR.Text = "<"
        Me.BTANTERIOR.UseVisualStyleBackColor = True
        '
        'BTSIGUIENTE
        '
        Me.BTSIGUIENTE.Enabled = False
        Me.BTSIGUIENTE.Location = New System.Drawing.Point(79, 10)
        Me.BTSIGUIENTE.Name = "BTSIGUIENTE"
        Me.BTSIGUIENTE.Size = New System.Drawing.Size(29, 23)
        Me.BTSIGUIENTE.TabIndex = 10
        Me.BTSIGUIENTE.Text = ">"
        Me.BTSIGUIENTE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtTELEFONO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtRUT)
        Me.GroupBox1.Controls.Add(Me.TxtNOMBRE)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 135)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Personal"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(80, 103)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(202, 20)
        Me.TxtDireccion.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "DIRECCION"
        '
        'BTModificar
        '
        Me.BTModificar.Location = New System.Drawing.Point(6, 49)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(75, 23)
        Me.BTModificar.TabIndex = 16
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = True
        '
        'BTELIMINAR
        '
        Me.BTELIMINAR.Enabled = False
        Me.BTELIMINAR.Location = New System.Drawing.Point(6, 80)
        Me.BTELIMINAR.Name = "BTELIMINAR"
        Me.BTELIMINAR.Size = New System.Drawing.Size(75, 23)
        Me.BTELIMINAR.TabIndex = 17
        Me.BTELIMINAR.Text = "Eliminar"
        Me.BTELIMINAR.UseVisualStyleBackColor = True
        '
        'BTCANCELAR
        '
        Me.BTCANCELAR.Enabled = False
        Me.BTCANCELAR.Location = New System.Drawing.Point(6, 162)
        Me.BTCANCELAR.Name = "BTCANCELAR"
        Me.BTCANCELAR.Size = New System.Drawing.Size(75, 23)
        Me.BTCANCELAR.TabIndex = 18
        Me.BTCANCELAR.Text = "Cancelar"
        Me.BTCANCELAR.UseVisualStyleBackColor = True
        '
        'BTSALIR
        '
        Me.BTSALIR.Enabled = False
        Me.BTSALIR.Location = New System.Drawing.Point(6, 192)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(75, 23)
        Me.BTSALIR.TabIndex = 19
        Me.BTSALIR.Text = "Salir"
        Me.BTSALIR.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTSALIR)
        Me.GroupBox2.Controls.Add(Me.BTAgregar)
        Me.GroupBox2.Controls.Add(Me.BTCANCELAR)
        Me.GroupBox2.Controls.Add(Me.BTACEPTAR)
        Me.GroupBox2.Controls.Add(Me.BTELIMINAR)
        Me.GroupBox2.Controls.Add(Me.BTModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(94, 285)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RDBTMUJER)
        Me.GroupBox3.Controls.Add(Me.RDBTHOMBRE)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 153)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 51)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sexo"
        '
        'RDBTMUJER
        '
        Me.RDBTMUJER.AutoSize = True
        Me.RDBTMUJER.Enabled = False
        Me.RDBTMUJER.Location = New System.Drawing.Point(231, 28)
        Me.RDBTMUJER.Name = "RDBTMUJER"
        Me.RDBTMUJER.Size = New System.Drawing.Size(51, 17)
        Me.RDBTMUJER.TabIndex = 17
        Me.RDBTMUJER.TabStop = True
        Me.RDBTMUJER.Text = "Mujer"
        Me.RDBTMUJER.UseVisualStyleBackColor = True
        '
        'RDBTHOMBRE
        '
        Me.RDBTHOMBRE.AutoSize = True
        Me.RDBTHOMBRE.Enabled = False
        Me.RDBTHOMBRE.Location = New System.Drawing.Point(6, 28)
        Me.RDBTHOMBRE.Name = "RDBTHOMBRE"
        Me.RDBTHOMBRE.Size = New System.Drawing.Size(62, 17)
        Me.RDBTHOMBRE.TabIndex = 0
        Me.RDBTHOMBRE.TabStop = True
        Me.RDBTHOMBRE.Text = "Hombre"
        Me.RDBTHOMBRE.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CHBHABILITADO)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(299, 41)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Estado"
        '
        'CHBHABILITADO
        '
        Me.CHBHABILITADO.AutoSize = True
        Me.CHBHABILITADO.Enabled = False
        Me.CHBHABILITADO.Location = New System.Drawing.Point(9, 20)
        Me.CHBHABILITADO.Name = "CHBHABILITADO"
        Me.CHBHABILITADO.Size = New System.Drawing.Size(73, 17)
        Me.CHBHABILITADO.TabIndex = 0
        Me.CHBHABILITADO.Text = "Habilitado"
        Me.CHBHABILITADO.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BTPRIMER)
        Me.GroupBox5.Controls.Add(Me.BTULTIMO)
        Me.GroupBox5.Controls.Add(Me.BTANTERIOR)
        Me.GroupBox5.Controls.Add(Me.BTSIGUIENTE)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(299, 39)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'BTPRIMER
        '
        Me.BTPRIMER.Enabled = False
        Me.BTPRIMER.Location = New System.Drawing.Point(9, 10)
        Me.BTPRIMER.Name = "BTPRIMER"
        Me.BTPRIMER.Size = New System.Drawing.Size(29, 23)
        Me.BTPRIMER.TabIndex = 19
        Me.BTPRIMER.Text = "<<"
        Me.BTPRIMER.UseVisualStyleBackColor = True
        '
        'BTULTIMO
        '
        Me.BTULTIMO.Enabled = False
        Me.BTULTIMO.Location = New System.Drawing.Point(114, 10)
        Me.BTULTIMO.Name = "BTULTIMO"
        Me.BTULTIMO.Size = New System.Drawing.Size(29, 23)
        Me.BTULTIMO.TabIndex = 19
        Me.BTULTIMO.Text = ">>"
        Me.BTULTIMO.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 305)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtRUT As System.Windows.Forms.TextBox
    Friend WithEvents TxtNOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents BTAgregar As System.Windows.Forms.Button
    Friend WithEvents BTACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTANTERIOR As System.Windows.Forms.Button
    Friend WithEvents BTSIGUIENTE As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTModificar As System.Windows.Forms.Button
    Friend WithEvents BTELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTSALIR As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDBTMUJER As System.Windows.Forms.RadioButton
    Friend WithEvents RDBTHOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CHBHABILITADO As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BTPRIMER As System.Windows.Forms.Button
    Friend WithEvents BTULTIMO As System.Windows.Forms.Button

End Class
