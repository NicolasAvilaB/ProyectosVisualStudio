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
        Me.ButtonCONVERTIR = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton200 = New System.Windows.Forms.RadioButton()
        Me.ButtonCARGAR = New System.Windows.Forms.Button()
        Me.RadioButton100 = New System.Windows.Forms.RadioButton()
        Me.RadioButton48 = New System.Windows.Forms.RadioButton()
        Me.RadioButton64 = New System.Windows.Forms.RadioButton()
        Me.RadioButton32 = New System.Windows.Forms.RadioButton()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonCONVERTIR
        '
        Me.ButtonCONVERTIR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCONVERTIR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCONVERTIR.ForeColor = System.Drawing.Color.Black
        Me.ButtonCONVERTIR.Location = New System.Drawing.Point(103, 152)
        Me.ButtonCONVERTIR.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCONVERTIR.Name = "ButtonCONVERTIR"
        Me.ButtonCONVERTIR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCONVERTIR.TabIndex = 0
        Me.ButtonCONVERTIR.Text = "CONVERTIR"
        Me.ButtonCONVERTIR.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "ico"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.Location = New System.Drawing.Point(12, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.RadioButton200)
        Me.GroupBox1.Controls.Add(Me.ButtonCARGAR)
        Me.GroupBox1.Controls.Add(Me.RadioButton100)
        Me.GroupBox1.Controls.Add(Me.ButtonCONVERTIR)
        Me.GroupBox1.Controls.Add(Me.RadioButton48)
        Me.GroupBox1.Controls.Add(Me.RadioButton64)
        Me.GroupBox1.Controls.Add(Me.RadioButton32)
        Me.GroupBox1.Controls.Add(Me.RadioButton16)
        Me.GroupBox1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(418, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 400)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑOS"
        '
        'RadioButton200
        '
        Me.RadioButton200.AutoSize = True
        Me.RadioButton200.Location = New System.Drawing.Point(6, 283)
        Me.RadioButton200.Name = "RadioButton200"
        Me.RadioButton200.Size = New System.Drawing.Size(84, 23)
        Me.RadioButton200.TabIndex = 8
        Me.RadioButton200.Text = "200X200"
        Me.RadioButton200.UseVisualStyleBackColor = True
        '
        'ButtonCARGAR
        '
        Me.ButtonCARGAR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCARGAR.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCARGAR.ForeColor = System.Drawing.Color.Black
        Me.ButtonCARGAR.Location = New System.Drawing.Point(103, 21)
        Me.ButtonCARGAR.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonCARGAR.Name = "ButtonCARGAR"
        Me.ButtonCARGAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonCARGAR.TabIndex = 5
        Me.ButtonCARGAR.Text = "CARGAR"
        Me.ButtonCARGAR.UseVisualStyleBackColor = False
        '
        'RadioButton100
        '
        Me.RadioButton100.AutoSize = True
        Me.RadioButton100.Checked = True
        Me.RadioButton100.Location = New System.Drawing.Point(6, 234)
        Me.RadioButton100.Name = "RadioButton100"
        Me.RadioButton100.Size = New System.Drawing.Size(84, 23)
        Me.RadioButton100.TabIndex = 7
        Me.RadioButton100.TabStop = True
        Me.RadioButton100.Text = "100X100"
        Me.RadioButton100.UseVisualStyleBackColor = True
        '
        'RadioButton48
        '
        Me.RadioButton48.AutoSize = True
        Me.RadioButton48.Location = New System.Drawing.Point(6, 114)
        Me.RadioButton48.Name = "RadioButton48"
        Me.RadioButton48.Size = New System.Drawing.Size(68, 23)
        Me.RadioButton48.TabIndex = 6
        Me.RadioButton48.Text = "48X48"
        Me.RadioButton48.UseVisualStyleBackColor = True
        '
        'RadioButton64
        '
        Me.RadioButton64.AutoSize = True
        Me.RadioButton64.Location = New System.Drawing.Point(6, 189)
        Me.RadioButton64.Name = "RadioButton64"
        Me.RadioButton64.Size = New System.Drawing.Size(68, 23)
        Me.RadioButton64.TabIndex = 5
        Me.RadioButton64.Text = "64X64"
        Me.RadioButton64.UseVisualStyleBackColor = True
        '
        'RadioButton32
        '
        Me.RadioButton32.AutoSize = True
        Me.RadioButton32.Location = New System.Drawing.Point(6, 66)
        Me.RadioButton32.Name = "RadioButton32"
        Me.RadioButton32.Size = New System.Drawing.Size(68, 23)
        Me.RadioButton32.TabIndex = 4
        Me.RadioButton32.Text = "32X32"
        Me.RadioButton32.UseVisualStyleBackColor = True
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Location = New System.Drawing.Point(6, 21)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(68, 23)
        Me.RadioButton16.TabIndex = 3
        Me.RadioButton16.Text = "16X16"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(689, 33)
        Me.Panel2.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(4, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Convertidor ICO"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DimGray
        Me.Button1.Location = New System.Drawing.Point(659, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(689, 464)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONVERSOR A ICO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonCONVERTIR As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton200 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton100 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton48 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton64 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton32 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonCARGAR As System.Windows.Forms.Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
