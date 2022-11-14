<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceso))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UsuariosMysql = New System.Windows.Forms.Button()
        Me.ClientesMysql = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UsuariosMysql)
        Me.GroupBox1.Controls.Add(Me.ClientesMysql)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 207)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienvenido"
        '
        'UsuariosMysql
        '
        Me.UsuariosMysql.Location = New System.Drawing.Point(17, 140)
        Me.UsuariosMysql.Name = "UsuariosMysql"
        Me.UsuariosMysql.Size = New System.Drawing.Size(328, 61)
        Me.UsuariosMysql.TabIndex = 3
        Me.UsuariosMysql.Text = "Usuarios"
        Me.UsuariosMysql.UseVisualStyleBackColor = True
        '
        'ClientesMysql
        '
        Me.ClientesMysql.Location = New System.Drawing.Point(17, 27)
        Me.ClientesMysql.Name = "ClientesMysql"
        Me.ClientesMysql.Size = New System.Drawing.Size(328, 61)
        Me.ClientesMysql.TabIndex = 2
        Me.ClientesMysql.Text = "Clientes"
        Me.ClientesMysql.UseVisualStyleBackColor = True
        '
        'Acceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(389, 233)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Acceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UsuariosMysql As System.Windows.Forms.Button
    Friend WithEvents ClientesMysql As System.Windows.Forms.Button
End Class
