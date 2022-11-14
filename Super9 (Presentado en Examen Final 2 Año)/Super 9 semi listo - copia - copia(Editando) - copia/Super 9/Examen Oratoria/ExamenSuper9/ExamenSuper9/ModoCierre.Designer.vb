<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModoCierre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModoCierre))
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Volver = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Modo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aceptar
        '
        Me.Aceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Aceptar.Enabled = False
        Me.Aceptar.Location = New System.Drawing.Point(26, 84)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(292, 48)
        Me.Aceptar.TabIndex = 1
        Me.Aceptar.Text = "Aceptar"
        Me.ToolTip1.SetToolTip(Me.Aceptar, "Acepta el Cierre de Caja")
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Volver
        '
        Me.Volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Volver.Location = New System.Drawing.Point(26, 152)
        Me.Volver.Name = "Volver"
        Me.Volver.Size = New System.Drawing.Size(292, 48)
        Me.Volver.TabIndex = 2
        Me.Volver.Text = "Volver"
        Me.ToolTip1.SetToolTip(Me.Volver, "Vuelve a la Pantalla Anterior")
        Me.Volver.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Modo)
        Me.GroupBox1.Controls.Add(Me.Volver)
        Me.GroupBox1.Controls.Add(Me.Aceptar)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 222)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selección Modo Cierre"
        '
        'Modo
        '
        Me.Modo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Modo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Modo.FormattingEnabled = True
        Me.Modo.Items.AddRange(New Object() {"Cambio de Dinero", "Hora Colación", "Productos Fuera Stock", "Necesidades Basicas", "Reponer Productos", "Otra Petición", "Cierre Caja del Dia"})
        Me.Modo.Location = New System.Drawing.Point(26, 35)
        Me.Modo.Name = "Modo"
        Me.Modo.Size = New System.Drawing.Size(292, 29)
        Me.Modo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.Modo, "Especifique Modo Cierre de la Caja")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "CopyRight 2016 @ S.T.A.R.S Enterprise"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'ModoCierre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(375, 255)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModoCierre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modo Cierre"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Volver As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Modo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
