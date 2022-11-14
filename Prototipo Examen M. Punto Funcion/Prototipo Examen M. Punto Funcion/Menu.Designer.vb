<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.suc = New System.Windows.Forms.Button()
        Me.ord = New System.Windows.Forms.Button()
        Me.cli = New System.Windows.Forms.Button()
        Me.rep = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ped = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 33)
        Me.Panel2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "PANADERIA"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(183, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(217, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.suc)
        Me.Panel1.Controls.Add(Me.ord)
        Me.Panel1.Controls.Add(Me.cli)
        Me.Panel1.Controls.Add(Me.rep)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ped)
        Me.Panel1.Location = New System.Drawing.Point(5, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 348)
        Me.Panel1.TabIndex = 17
        '
        'suc
        '
        Me.suc.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.suc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.suc.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suc.ForeColor = System.Drawing.Color.White
        Me.suc.Location = New System.Drawing.Point(47, 286)
        Me.suc.Name = "suc"
        Me.suc.Size = New System.Drawing.Size(146, 38)
        Me.suc.TabIndex = 118
        Me.suc.Text = "SUCURSALES"
        Me.suc.UseVisualStyleBackColor = False
        '
        'ord
        '
        Me.ord.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ord.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ord.ForeColor = System.Drawing.Color.White
        Me.ord.Location = New System.Drawing.Point(47, 241)
        Me.ord.Name = "ord"
        Me.ord.Size = New System.Drawing.Size(146, 38)
        Me.ord.TabIndex = 117
        Me.ord.Text = "ORDEN TRABAJO"
        Me.ord.UseVisualStyleBackColor = False
        '
        'cli
        '
        Me.cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cli.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cli.ForeColor = System.Drawing.Color.White
        Me.cli.Location = New System.Drawing.Point(47, 197)
        Me.cli.Name = "cli"
        Me.cli.Size = New System.Drawing.Size(146, 38)
        Me.cli.TabIndex = 116
        Me.cli.Text = "CLIENTES"
        Me.cli.UseVisualStyleBackColor = False
        '
        'rep
        '
        Me.rep.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rep.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rep.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rep.ForeColor = System.Drawing.Color.White
        Me.rep.Location = New System.Drawing.Point(47, 153)
        Me.rep.Name = "rep"
        Me.rep.Size = New System.Drawing.Size(146, 38)
        Me.rep.TabIndex = 115
        Me.rep.Text = "REPARTIDORES"
        Me.rep.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(12, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 58)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "      BIENVENIDO A " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SISTEMA PANADERIA"
        '
        'ped
        '
        Me.ped.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ped.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ped.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ped.ForeColor = System.Drawing.Color.White
        Me.ped.Location = New System.Drawing.Point(47, 109)
        Me.ped.Name = "ped"
        Me.ped.Size = New System.Drawing.Size(146, 38)
        Me.ped.TabIndex = 0
        Me.ped.Text = "PEDIDOS"
        Me.ped.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(157, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(248, 384)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents ped As Button
    Friend WithEvents ord As Button
    Friend WithEvents cli As Button
    Friend WithEvents rep As Button
    Friend WithEvents suc As Button
End Class
