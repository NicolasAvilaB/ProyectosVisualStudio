<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservas1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Totales = New System.Windows.Forms.TextBox()
        Me.Acep = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rutis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nomi = New System.Windows.Forms.ComboBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Doctor = New System.Windows.Forms.TextBox()
        Me.Dias = New System.Windows.Forms.ComboBox()
        Me.Volver = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.limpio = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.limpio)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Totales)
        Me.GroupBox1.Controls.Add(Me.Acep)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rutis)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Nomi)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Doctor)
        Me.GroupBox1.Controls.Add(Me.Dias)
        Me.GroupBox1.Controls.Add(Me.Volver)
        Me.GroupBox1.Controls.Add(Me.dg)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 546)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reservas"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(429, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 42)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Guardar Reserva"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(680, 371)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 26)
        Me.TextBox1.TabIndex = 25
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Totales
        '
        Me.Totales.Location = New System.Drawing.Point(640, 403)
        Me.Totales.Name = "Totales"
        Me.Totales.Size = New System.Drawing.Size(100, 26)
        Me.Totales.TabIndex = 24
        '
        'Acep
        '
        Me.Acep.Enabled = False
        Me.Acep.Location = New System.Drawing.Point(21, 447)
        Me.Acep.Name = "Acep"
        Me.Acep.Size = New System.Drawing.Size(402, 42)
        Me.Acep.TabIndex = 23
        Me.Acep.Text = "Aceptar"
        Me.Acep.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(589, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(646, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "N°"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Rut Paciente: "
        '
        'rutis
        '
        Me.rutis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.rutis.FormattingEnabled = True
        Me.rutis.Location = New System.Drawing.Point(127, 388)
        Me.rutis.Name = "rutis"
        Me.rutis.Size = New System.Drawing.Size(151, 27)
        Me.rutis.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 391)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nombre Paciente: "
        '
        'Nomi
        '
        Me.Nomi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nomi.FormattingEnabled = True
        Me.Nomi.Location = New System.Drawing.Point(423, 388)
        Me.Nomi.Name = "Nomi"
        Me.Nomi.Size = New System.Drawing.Size(151, 27)
        Me.Nomi.TabIndex = 16
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(450, 33)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(54, 19)
        Me.Nombre.TabIndex = 15
        Me.Nombre.Text = "nombre"
        Me.Nombre.Visible = False
        '
        'Doctor
        '
        Me.Doctor.Location = New System.Drawing.Point(293, 30)
        Me.Doctor.Name = "Doctor"
        Me.Doctor.Size = New System.Drawing.Size(142, 26)
        Me.Doctor.TabIndex = 14
        '
        'Dias
        '
        Me.Dias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Dias.FormattingEnabled = True
        Me.Dias.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Me.Dias.Location = New System.Drawing.Point(58, 29)
        Me.Dias.Name = "Dias"
        Me.Dias.Size = New System.Drawing.Size(218, 27)
        Me.Dias.TabIndex = 4
        '
        'Volver
        '
        Me.Volver.Location = New System.Drawing.Point(19, 495)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(719, 41)
        Me.Volver.TabIndex = 3
        Me.Volver.Text = "Volver"
        Me.Volver.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dg.Location = New System.Drawing.Point(21, 73)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(719, 292)
        Me.dg.TabIndex = 2
        '
        'Column2
        '
        Me.Column2.HeaderText = "N°"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Rut Cliente"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Nombre Cliente"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dia:"
        '
        'limpio
        '
        Me.limpio.Location = New System.Drawing.Point(535, 25)
        Me.limpio.Name = "limpio"
        Me.limpio.Size = New System.Drawing.Size(203, 36)
        Me.limpio.TabIndex = 27
        Me.limpio.Text = "Limpiar Reservas"
        Me.limpio.UseVisualStyleBackColor = True
        '
        'Reservas1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 567)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Reservas1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Volver As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Dias As ComboBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Doctor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Nomi As ComboBox
    Friend WithEvents Totales As TextBox
    Friend WithEvents Acep As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rutis As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents limpio As Button
End Class
