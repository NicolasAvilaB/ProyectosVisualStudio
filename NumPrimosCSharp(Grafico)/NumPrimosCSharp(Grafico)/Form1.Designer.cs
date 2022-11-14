namespace NumPrimosCSharp_Grafico_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.calculador = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.TextBox();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.Button2);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(361, 33);
            this.Panel2.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(4, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(114, 20);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Numeros Primos";
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.SystemColors.Control;
            this.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.DimGray;
            this.Button2.Location = new System.Drawing.Point(298, 4);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(27, 27);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "---";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.BackColor = System.Drawing.SystemColors.Control;
            this.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.DimGray;
            this.Button3.Location = new System.Drawing.Point(331, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(27, 27);
            this.Button3.TabIndex = 0;
            this.Button3.Text = "X";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.calculador);
            this.GroupBox1.Controls.Add(this.num1);
            this.GroupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(4, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(352, 116);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label2.Location = new System.Drawing.Point(8, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(122, 22);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Ingreso Numero 1";
            // 
            // calculador
            // 
            this.calculador.BackColor = System.Drawing.SystemColors.Control;
            this.calculador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculador.Location = new System.Drawing.Point(144, 69);
            this.calculador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calculador.Name = "calculador";
            this.calculador.Size = new System.Drawing.Size(191, 35);
            this.calculador.TabIndex = 0;
            this.calculador.Text = "Calcular";
            this.calculador.UseVisualStyleBackColor = false;
            this.calculador.Click += new System.EventHandler(this.calculador_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(144, 25);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(191, 26);
            this.num1.TabIndex = 1;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 147);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button calculador;
        internal System.Windows.Forms.TextBox num1;
    }
}

