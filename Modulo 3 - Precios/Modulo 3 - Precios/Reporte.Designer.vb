<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte))
        Me.Tabla_CoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPrecios = New Modulo_3___Precios.DsPrecios()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.minimizar = New System.Windows.Forms.Button()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.visual = New System.Windows.Forms.ComboBox()
        Me.preder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.volver = New System.Windows.Forms.Button()
        Me.sel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reportes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Tabla_CoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabla_CoBindingSource
        '
        Me.Tabla_CoBindingSource.DataMember = "Tabla_Co"
        Me.Tabla_CoBindingSource.DataSource = Me.DsPrecios
        '
        'DsPrecios
        '
        Me.DsPrecios.DataSetName = "DsPrecios"
        Me.DsPrecios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.minimizar)
        Me.Panel2.Controls.Add(Me.cerrar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(873, 33)
        Me.Panel2.TabIndex = 185
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "MODULO 2 - NOTA DE VENTAS"
        '
        'minimizar
        '
        Me.minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizar.ForeColor = System.Drawing.Color.White
        Me.minimizar.Location = New System.Drawing.Point(808, 3)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(27, 27)
        Me.minimizar.TabIndex = 1
        Me.minimizar.Text = "---"
        Me.minimizar.UseVisualStyleBackColor = False
        '
        'cerrar
        '
        Me.cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.White
        Me.cerrar.Location = New System.Drawing.Point(842, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(27, 27)
        Me.cerrar.TabIndex = 0
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'visual
        '
        Me.visual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visual.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.visual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.visual.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.visual.FormattingEnabled = True
        Me.visual.Location = New System.Drawing.Point(219, 13)
        Me.visual.Name = "visual"
        Me.visual.Size = New System.Drawing.Size(631, 31)
        Me.visual.TabIndex = 191
        '
        'preder
        '
        Me.preder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.preder.Enabled = False
        Me.preder.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preder.Location = New System.Drawing.Point(261, 52)
        Me.preder.MaxLength = 45
        Me.preder.Name = "preder"
        Me.preder.ReadOnly = True
        Me.preder.Size = New System.Drawing.Size(589, 32)
        Me.preder.TabIndex = 190
        Me.preder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 22)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "IMPRESORAS PREDETERMINADA:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Label40.Font = New System.Drawing.Font("Arial Narrow", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(10, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(203, 22)
        Me.Label40.TabIndex = 188
        Me.Label40.Text = "IMPRESORAS INSTALADAS:"
        '
        'volver
        '
        Me.volver.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.volver.BackColor = System.Drawing.Color.White
        Me.volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.volver.FlatAppearance.BorderSize = 0
        Me.volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.volver.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.volver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.volver.Location = New System.Drawing.Point(14, 90)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(170, 39)
        Me.volver.TabIndex = 187
        Me.volver.Text = " Volver"
        Me.volver.UseVisualStyleBackColor = False
        '
        'sel
        '
        Me.sel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.sel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sel.BackColor = System.Drawing.Color.White
        Me.sel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sel.FlatAppearance.BorderSize = 0
        Me.sel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.sel.Location = New System.Drawing.Point(644, 90)
        Me.sel.Name = "sel"
        Me.sel.Size = New System.Drawing.Size(206, 39)
        Me.sel.TabIndex = 186
        Me.sel.Text = "Seleccionar Impresora"
        Me.sel.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.Panel1.Controls.Add(Me.reportes)
        Me.Panel1.Controls.Add(Me.Label40)
        Me.Panel1.Controls.Add(Me.sel)
        Me.Panel1.Controls.Add(Me.visual)
        Me.Panel1.Controls.Add(Me.volver)
        Me.Panel1.Controls.Add(Me.preder)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(5, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 457)
        Me.Panel1.TabIndex = 192
        '
        'reportes
        '
        ReportDataSource1.Name = "DatosPre"
        ReportDataSource1.Value = Me.Tabla_CoBindingSource
        Me.reportes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.reportes.LocalReport.ReportEmbeddedResource = "Modulo_3___Precios.Reporte_Datos.rdlc"
        Me.reportes.Location = New System.Drawing.Point(14, 135)
        Me.reportes.Name = "reportes"
        Me.reportes.Size = New System.Drawing.Size(836, 306)
        Me.reportes.TabIndex = 192
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(232, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 20)
        Me.Label1.TabIndex = 193
        Me.Label1.Text = "COPYRIGHT © 2019 PERSIANAS EXTERIORES PYM"
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(873, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte"
        CType(Me.Tabla_CoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents minimizar As Button
    Friend WithEvents cerrar As Button
    Friend WithEvents visual As ComboBox
    Friend WithEvents preder As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents volver As Button
    Friend WithEvents sel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DsPrecios As DsPrecios
    Friend WithEvents reportes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tabla_CoBindingSource As BindingSource
End Class
