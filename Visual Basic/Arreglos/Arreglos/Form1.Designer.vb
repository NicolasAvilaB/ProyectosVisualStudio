﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnArreglo = New System.Windows.Forms.Button()
        Me.LtbNumeros = New System.Windows.Forms.ListBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Arreglos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tamaño de Arreglo"
        '
        'BtnArreglo
        '
        Me.BtnArreglo.Location = New System.Drawing.Point(24, 74)
        Me.BtnArreglo.Name = "BtnArreglo"
        Me.BtnArreglo.Size = New System.Drawing.Size(88, 23)
        Me.BtnArreglo.TabIndex = 2
        Me.BtnArreglo.Text = "Crear Arreglo"
        Me.BtnArreglo.UseVisualStyleBackColor = True
        '
        'LtbNumeros
        '
        Me.LtbNumeros.FormattingEnabled = True
        Me.LtbNumeros.Location = New System.Drawing.Point(12, 104)
        Me.LtbNumeros.Name = "LtbNumeros"
        Me.LtbNumeros.Size = New System.Drawing.Size(111, 199)
        Me.LtbNumeros.TabIndex = 3
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(12, 47)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(111, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(136, 316)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.LtbNumeros)
        Me.Controls.Add(Me.BtnArreglo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnArreglo As System.Windows.Forms.Button
    Friend WithEvents LtbNumeros As System.Windows.Forms.ListBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox

End Class
