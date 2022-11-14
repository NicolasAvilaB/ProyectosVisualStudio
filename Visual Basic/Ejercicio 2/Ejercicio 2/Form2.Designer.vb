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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rd_Suspendido = New System.Windows.Forms.RadioButton()
        Me.Rd_Habilitado = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidadBloques = New System.Windows.Forms.TextBox()
        Me.txtClaveAcceso = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bt_Imprimir = New System.Windows.Forms.Button()
        Me.Bt_Buscar = New System.Windows.Forms.Button()
        Me.Bt_Eliminar = New System.Windows.Forms.Button()
        Me.Bt_Modificar = New System.Windows.Forms.Button()
        Me.Bt_Nuevo = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Bt_Ultimo = New System.Windows.Forms.Button()
        Me.Bt_Anterior = New System.Windows.Forms.Button()
        Me.Bt_Siguiente = New System.Windows.Forms.Button()
        Me.Bt_Primero = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Bt_Cancelar = New System.Windows.Forms.Button()
        Me.Bt_Aceptar = New System.Windows.Forms.Button()
        Me.Bt_Salir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCantidadBloques)
        Me.GroupBox1.Controls.Add(Me.txtClaveAcceso)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtRut)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 310)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rd_Suspendido)
        Me.GroupBox3.Controls.Add(Me.Rd_Habilitado)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Estado Actual del Alumno"
        '
        'Rd_Suspendido
        '
        Me.Rd_Suspendido.AutoSize = True
        Me.Rd_Suspendido.Location = New System.Drawing.Point(104, 20)
        Me.Rd_Suspendido.Name = "Rd_Suspendido"
        Me.Rd_Suspendido.Size = New System.Drawing.Size(81, 17)
        Me.Rd_Suspendido.TabIndex = 1
        Me.Rd_Suspendido.TabStop = True
        Me.Rd_Suspendido.Text = "Suspendido"
        Me.Rd_Suspendido.UseVisualStyleBackColor = True
        '
        'Rd_Habilitado
        '
        Me.Rd_Habilitado.AutoSize = True
        Me.Rd_Habilitado.Location = New System.Drawing.Point(7, 20)
        Me.Rd_Habilitado.Name = "Rd_Habilitado"
        Me.Rd_Habilitado.Size = New System.Drawing.Size(72, 17)
        Me.Rd_Habilitado.TabIndex = 0
        Me.Rd_Habilitado.TabStop = True
        Me.Rd_Habilitado.Text = "Habilitado"
        Me.Rd_Habilitado.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cantidad de Bloques por Dia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Clave Acceso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ciudad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Rut"
        '
        'txtCantidadBloques
        '
        Me.txtCantidadBloques.Enabled = False
        Me.txtCantidadBloques.Location = New System.Drawing.Point(153, 210)
        Me.txtCantidadBloques.Name = "txtCantidadBloques"
        Me.txtCantidadBloques.Size = New System.Drawing.Size(67, 20)
        Me.txtCantidadBloques.TabIndex = 6
        '
        'txtClaveAcceso
        '
        Me.txtClaveAcceso.Enabled = False
        Me.txtClaveAcceso.Location = New System.Drawing.Point(74, 166)
        Me.txtClaveAcceso.Name = "txtClaveAcceso"
        Me.txtClaveAcceso.Size = New System.Drawing.Size(146, 20)
        Me.txtClaveAcceso.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(72, 121)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(148, 20)
        Me.txtTelefono.TabIndex = 4
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Location = New System.Drawing.Point(64, 95)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(156, 20)
        Me.txtCiudad.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(76, 69)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(144, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(68, 43)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtRut
        '
        Me.txtRut.Enabled = False
        Me.txtRut.Location = New System.Drawing.Point(48, 17)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(172, 20)
        Me.txtRut.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bt_Imprimir)
        Me.GroupBox2.Controls.Add(Me.Bt_Buscar)
        Me.GroupBox2.Controls.Add(Me.Bt_Eliminar)
        Me.GroupBox2.Controls.Add(Me.Bt_Modificar)
        Me.GroupBox2.Controls.Add(Me.Bt_Nuevo)
        Me.GroupBox2.Location = New System.Drawing.Point(291, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 169)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'Bt_Imprimir
        '
        Me.Bt_Imprimir.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Imprimir.Location = New System.Drawing.Point(19, 135)
        Me.Bt_Imprimir.Name = "Bt_Imprimir"
        Me.Bt_Imprimir.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Imprimir.TabIndex = 4
        Me.Bt_Imprimir.Text = "Imprimir"
        Me.Bt_Imprimir.UseVisualStyleBackColor = False
        '
        'Bt_Buscar
        '
        Me.Bt_Buscar.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Buscar.Location = New System.Drawing.Point(19, 106)
        Me.Bt_Buscar.Name = "Bt_Buscar"
        Me.Bt_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Buscar.TabIndex = 3
        Me.Bt_Buscar.Text = "Buscar"
        Me.Bt_Buscar.UseVisualStyleBackColor = False
        '
        'Bt_Eliminar
        '
        Me.Bt_Eliminar.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Eliminar.Location = New System.Drawing.Point(19, 77)
        Me.Bt_Eliminar.Name = "Bt_Eliminar"
        Me.Bt_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Eliminar.TabIndex = 2
        Me.Bt_Eliminar.Text = "Eliminar"
        Me.Bt_Eliminar.UseVisualStyleBackColor = False
        '
        'Bt_Modificar
        '
        Me.Bt_Modificar.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Modificar.Location = New System.Drawing.Point(18, 48)
        Me.Bt_Modificar.Name = "Bt_Modificar"
        Me.Bt_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Modificar.TabIndex = 1
        Me.Bt_Modificar.Text = "Modificar"
        Me.Bt_Modificar.UseVisualStyleBackColor = False
        '
        'Bt_Nuevo
        '
        Me.Bt_Nuevo.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Nuevo.Location = New System.Drawing.Point(19, 19)
        Me.Bt_Nuevo.Name = "Bt_Nuevo"
        Me.Bt_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Nuevo.TabIndex = 0
        Me.Bt_Nuevo.Text = "Nuevo"
        Me.Bt_Nuevo.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Bt_Ultimo)
        Me.GroupBox4.Controls.Add(Me.Bt_Anterior)
        Me.GroupBox4.Controls.Add(Me.Bt_Siguiente)
        Me.GroupBox4.Controls.Add(Me.Bt_Primero)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 329)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 61)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Desplazamiento de Registros"
        '
        'Bt_Ultimo
        '
        Me.Bt_Ultimo.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Ultimo.Location = New System.Drawing.Point(187, 19)
        Me.Bt_Ultimo.Name = "Bt_Ultimo"
        Me.Bt_Ultimo.Size = New System.Drawing.Size(47, 23)
        Me.Bt_Ultimo.TabIndex = 6
        Me.Bt_Ultimo.Text = ">>!"
        Me.Bt_Ultimo.UseVisualStyleBackColor = False
        '
        'Bt_Anterior
        '
        Me.Bt_Anterior.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Anterior.Location = New System.Drawing.Point(66, 19)
        Me.Bt_Anterior.Name = "Bt_Anterior"
        Me.Bt_Anterior.Size = New System.Drawing.Size(45, 23)
        Me.Bt_Anterior.TabIndex = 5
        Me.Bt_Anterior.Text = "<<"
        Me.Bt_Anterior.UseVisualStyleBackColor = False
        '
        'Bt_Siguiente
        '
        Me.Bt_Siguiente.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Siguiente.Location = New System.Drawing.Point(134, 19)
        Me.Bt_Siguiente.Name = "Bt_Siguiente"
        Me.Bt_Siguiente.Size = New System.Drawing.Size(47, 23)
        Me.Bt_Siguiente.TabIndex = 4
        Me.Bt_Siguiente.Text = ">>"
        Me.Bt_Siguiente.UseVisualStyleBackColor = False
        '
        'Bt_Primero
        '
        Me.Bt_Primero.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Primero.Location = New System.Drawing.Point(10, 19)
        Me.Bt_Primero.Name = "Bt_Primero"
        Me.Bt_Primero.Size = New System.Drawing.Size(46, 23)
        Me.Bt_Primero.TabIndex = 3
        Me.Bt_Primero.Text = "!<<"
        Me.Bt_Primero.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Bt_Cancelar)
        Me.GroupBox5.Controls.Add(Me.Bt_Aceptar)
        Me.GroupBox5.Location = New System.Drawing.Point(291, 238)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 85)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'Bt_Cancelar
        '
        Me.Bt_Cancelar.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Cancelar.Enabled = False
        Me.Bt_Cancelar.Location = New System.Drawing.Point(19, 48)
        Me.Bt_Cancelar.Name = "Bt_Cancelar"
        Me.Bt_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Cancelar.TabIndex = 2
        Me.Bt_Cancelar.Text = "Cancelar"
        Me.Bt_Cancelar.UseVisualStyleBackColor = False
        '
        'Bt_Aceptar
        '
        Me.Bt_Aceptar.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Aceptar.Enabled = False
        Me.Bt_Aceptar.Location = New System.Drawing.Point(19, 19)
        Me.Bt_Aceptar.Name = "Bt_Aceptar"
        Me.Bt_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Bt_Aceptar.TabIndex = 1
        Me.Bt_Aceptar.Text = "Aceptar"
        Me.Bt_Aceptar.UseVisualStyleBackColor = False
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.LimeGreen
        Me.Bt_Salir.Location = New System.Drawing.Point(310, 348)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(104, 23)
        Me.Bt_Salir.TabIndex = 4
        Me.Bt_Salir.Text = "Salir Completo"
        Me.Bt_Salir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Location = New System.Drawing.Point(309, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Salir solo Form"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 402)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bt_Imprimir As System.Windows.Forms.Button
    Friend WithEvents Bt_Buscar As System.Windows.Forms.Button
    Friend WithEvents Bt_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Bt_Modificar As System.Windows.Forms.Button
    Friend WithEvents Bt_Nuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rd_Suspendido As System.Windows.Forms.RadioButton
    Friend WithEvents Rd_Habilitado As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadBloques As System.Windows.Forms.TextBox
    Friend WithEvents txtClaveAcceso As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Bt_Ultimo As System.Windows.Forms.Button
    Friend WithEvents Bt_Anterior As System.Windows.Forms.Button
    Friend WithEvents Bt_Siguiente As System.Windows.Forms.Button
    Friend WithEvents Bt_Primero As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Bt_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
