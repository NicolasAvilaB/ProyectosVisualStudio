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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Ejercicio1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercico1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ejercicio4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercicio1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Ejercicio1ToolStripMenuItem
        '
        Me.Ejercicio1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ejercico1ToolStripMenuItem, Me.Ejercicio2ToolStripMenuItem, Me.Ejercicio3ToolStripMenuItem, Me.Ejercicio4ToolStripMenuItem})
        Me.Ejercicio1ToolStripMenuItem.Name = "Ejercicio1ToolStripMenuItem"
        Me.Ejercicio1ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.Ejercicio1ToolStripMenuItem.Text = "EJERCICIOS"
        '
        'Ejercico1ToolStripMenuItem
        '
        Me.Ejercico1ToolStripMenuItem.Name = "Ejercico1ToolStripMenuItem"
        Me.Ejercico1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Ejercico1ToolStripMenuItem.Text = "Ejercicio 1"
        '
        'Ejercicio2ToolStripMenuItem
        '
        Me.Ejercicio2ToolStripMenuItem.Name = "Ejercicio2ToolStripMenuItem"
        Me.Ejercicio2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Ejercicio2ToolStripMenuItem.Text = "Ejercicio 2"
        '
        'Ejercicio3ToolStripMenuItem
        '
        Me.Ejercicio3ToolStripMenuItem.Name = "Ejercicio3ToolStripMenuItem"
        Me.Ejercicio3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Ejercicio3ToolStripMenuItem.Text = "Ejercicio 3"
        '
        'Ejercicio4ToolStripMenuItem
        '
        Me.Ejercicio4ToolStripMenuItem.Name = "Ejercicio4ToolStripMenuItem"
        Me.Ejercicio4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Ejercicio4ToolStripMenuItem.Text = "Ejercicio 4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Ejercicio1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejercico1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejercicio2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejercicio3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ejercicio4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
