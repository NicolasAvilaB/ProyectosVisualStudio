<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formm1
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nodos = New System.Windows.Forms.Label()
        Me.txt_aristas = New System.Windows.Forms.Label()
        Me.txt_nodosP = New System.Windows.Forms.Label()
        Me.txt_complejidad = New System.Windows.Forms.Label()
        Me.lbl_nodos = New System.Windows.Forms.Label()
        Me.lbl_aristas = New System.Windows.Forms.Label()
        Me.lbl_tot_aristas_m_nodos = New System.Windows.Forms.Label()
        Me.txt_cod = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chk_C = New System.Windows.Forms.RadioButton()
        Me.chk_Java = New System.Windows.Forms.RadioButton()
        Me.chk_VB = New System.Windows.Forms.RadioButton()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.limpieza = New System.Windows.Forms.Button()
        Me.calcular = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(184, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "+ 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(142, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(120, 230)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "+ 1"
        '
        'txt_nodos
        '
        Me.txt_nodos.AutoSize = True
        Me.txt_nodos.BackColor = System.Drawing.Color.Transparent
        Me.txt_nodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nodos.ForeColor = System.Drawing.Color.Black
        Me.txt_nodos.Location = New System.Drawing.Point(66, 152)
        Me.txt_nodos.Name = "txt_nodos"
        Me.txt_nodos.Size = New System.Drawing.Size(15, 16)
        Me.txt_nodos.TabIndex = 5
        Me.txt_nodos.Text = "0"
        '
        'txt_aristas
        '
        Me.txt_aristas.AutoSize = True
        Me.txt_aristas.BackColor = System.Drawing.Color.Transparent
        Me.txt_aristas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aristas.ForeColor = System.Drawing.Color.Black
        Me.txt_aristas.Location = New System.Drawing.Point(66, 178)
        Me.txt_aristas.Name = "txt_aristas"
        Me.txt_aristas.Size = New System.Drawing.Size(15, 16)
        Me.txt_aristas.TabIndex = 6
        Me.txt_aristas.Text = "0"
        '
        'txt_nodosP
        '
        Me.txt_nodosP.AutoSize = True
        Me.txt_nodosP.BackColor = System.Drawing.Color.Transparent
        Me.txt_nodosP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nodosP.ForeColor = System.Drawing.Color.Black
        Me.txt_nodosP.Location = New System.Drawing.Point(91, 230)
        Me.txt_nodosP.Name = "txt_nodosP"
        Me.txt_nodosP.Size = New System.Drawing.Size(29, 16)
        Me.txt_nodosP.TabIndex = 10
        Me.txt_nodosP.Text = "000"
        Me.txt_nodosP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_complejidad
        '
        Me.txt_complejidad.BackColor = System.Drawing.Color.Transparent
        Me.txt_complejidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_complejidad.ForeColor = System.Drawing.Color.Black
        Me.txt_complejidad.Location = New System.Drawing.Point(81, 272)
        Me.txt_complejidad.Name = "txt_complejidad"
        Me.txt_complejidad.Size = New System.Drawing.Size(46, 22)
        Me.txt_complejidad.TabIndex = 11
        Me.txt_complejidad.Text = "0"
        Me.txt_complejidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_nodos
        '
        Me.lbl_nodos.AutoSize = True
        Me.lbl_nodos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nodos.ForeColor = System.Drawing.Color.Black
        Me.lbl_nodos.Location = New System.Drawing.Point(156, 325)
        Me.lbl_nodos.Name = "lbl_nodos"
        Me.lbl_nodos.Size = New System.Drawing.Size(29, 16)
        Me.lbl_nodos.TabIndex = 15
        Me.lbl_nodos.Text = "000"
        Me.lbl_nodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_aristas
        '
        Me.lbl_aristas.AutoSize = True
        Me.lbl_aristas.BackColor = System.Drawing.Color.Transparent
        Me.lbl_aristas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_aristas.ForeColor = System.Drawing.Color.Black
        Me.lbl_aristas.Location = New System.Drawing.Point(113, 325)
        Me.lbl_aristas.Name = "lbl_aristas"
        Me.lbl_aristas.Size = New System.Drawing.Size(29, 16)
        Me.lbl_aristas.TabIndex = 16
        Me.lbl_aristas.Text = "000"
        Me.lbl_aristas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_tot_aristas_m_nodos
        '
        Me.lbl_tot_aristas_m_nodos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tot_aristas_m_nodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tot_aristas_m_nodos.ForeColor = System.Drawing.Color.Black
        Me.lbl_tot_aristas_m_nodos.Location = New System.Drawing.Point(98, 375)
        Me.lbl_tot_aristas_m_nodos.Name = "lbl_tot_aristas_m_nodos"
        Me.lbl_tot_aristas_m_nodos.Size = New System.Drawing.Size(38, 24)
        Me.lbl_tot_aristas_m_nodos.TabIndex = 17
        Me.lbl_tot_aristas_m_nodos.Text = "0"
        Me.lbl_tot_aristas_m_nodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_cod
        '
        Me.txt_cod.Location = New System.Drawing.Point(10, 21)
        Me.txt_cod.Multiline = True
        Me.txt_cod.Name = "txt_cod"
        Me.txt_cod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_cod.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cod.Size = New System.Drawing.Size(303, 127)
        Me.txt_cod.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(491, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 30)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_tot_aristas_m_nodos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_aristas)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbl_nodos)
        Me.GroupBox1.Controls.Add(Me.txt_nodosP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.chk_C)
        Me.GroupBox1.Controls.Add(Me.txt_complejidad)
        Me.GroupBox1.Controls.Add(Me.txt_nodos)
        Me.GroupBox1.Controls.Add(Me.chk_Java)
        Me.GroupBox1.Controls.Add(Me.txt_aristas)
        Me.GroupBox1.Controls.Add(Me.chk_VB)
        Me.GroupBox1.Controls.Add(Me.cerrar)
        Me.GroupBox1.Controls.Add(Me.limpieza)
        Me.GroupBox1.Controls.Add(Me.calcular)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.txt_cod)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(855, 425)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "cc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(35, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "final:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(20, 325)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "arita - nodo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(20, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "final:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "nodo predi:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(8, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 16)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Aristas:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(8, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Nodos:"
        '
        'chk_C
        '
        Me.chk_C.AutoSize = True
        Me.chk_C.Location = New System.Drawing.Point(354, 80)
        Me.chk_C.Name = "chk_C"
        Me.chk_C.Size = New System.Drawing.Size(78, 20)
        Me.chk_C.TabIndex = 40
        Me.chk_C.TabStop = True
        Me.chk_C.Text = "c sharpp"
        Me.chk_C.UseVisualStyleBackColor = True
        '
        'chk_Java
        '
        Me.chk_Java.AutoSize = True
        Me.chk_Java.Location = New System.Drawing.Point(354, 47)
        Me.chk_Java.Name = "chk_Java"
        Me.chk_Java.Size = New System.Drawing.Size(128, 20)
        Me.chk_Java.TabIndex = 39
        Me.chk_Java.TabStop = True
        Me.chk_Java.Text = "la java  netbeans"
        Me.chk_Java.UseVisualStyleBackColor = True
        '
        'chk_VB
        '
        Me.chk_VB.AutoSize = True
        Me.chk_VB.Location = New System.Drawing.Point(354, 21)
        Me.chk_VB.Name = "chk_VB"
        Me.chk_VB.Size = New System.Drawing.Size(41, 20)
        Me.chk_VB.TabIndex = 38
        Me.chk_VB.TabStop = True
        Me.chk_VB.Text = "vb"
        Me.chk_VB.UseVisualStyleBackColor = True
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.Color.Transparent
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.Location = New System.Drawing.Point(590, 109)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(138, 39)
        Me.cerrar.TabIndex = 35
        Me.cerrar.Text = "cerrarrr"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'limpieza
        '
        Me.limpieza.BackColor = System.Drawing.Color.Transparent
        Me.limpieza.Cursor = System.Windows.Forms.Cursors.Hand
        Me.limpieza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpieza.Location = New System.Drawing.Point(527, 38)
        Me.limpieza.Name = "limpieza"
        Me.limpieza.Size = New System.Drawing.Size(171, 39)
        Me.limpieza.TabIndex = 15
        Me.limpieza.Text = "borreidion"
        Me.limpieza.UseVisualStyleBackColor = False
        '
        'calcular
        '
        Me.calcular.BackColor = System.Drawing.Color.Transparent
        Me.calcular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcular.Location = New System.Drawing.Point(336, 109)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(171, 39)
        Me.calcular.TabIndex = 14
        Me.calcular.Text = "aceptar"
        Me.calcular.UseVisualStyleBackColor = False
        '
        'Formm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(747, 399)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Formm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "complejidad"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_nodos As System.Windows.Forms.Label
    Friend WithEvents txt_aristas As System.Windows.Forms.Label
    Friend WithEvents txt_nodosP As System.Windows.Forms.Label
    Friend WithEvents txt_complejidad As System.Windows.Forms.Label
    Friend WithEvents lbl_nodos As System.Windows.Forms.Label
    Friend WithEvents lbl_aristas As System.Windows.Forms.Label
    Friend WithEvents lbl_tot_aristas_m_nodos As System.Windows.Forms.Label
    Friend WithEvents txt_cod As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calcular As Button
    Friend WithEvents limpieza As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chk_C As RadioButton
    Friend WithEvents chk_Java As RadioButton
    Friend WithEvents chk_VB As RadioButton
End Class
