namespace calculadoraGeometrica
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPerimetroTriangulo = new System.Windows.Forms.TextBox();
            this.txtAreaTriangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.btnCalcularPerimetroTrin = new System.Windows.Forms.Button();
            this.btnCalcularAreaTrian = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPerimetroCuadrilatero = new System.Windows.Forms.TextBox();
            this.txtAreaCuadrilatero = new System.Windows.Forms.TextBox();
            this.txtAlturaCuadrilatero = new System.Windows.Forms.TextBox();
            this.txtBaseCuadrilatero = new System.Windows.Forms.TextBox();
            this.btnPerimetroCuadrilatero = new System.Windows.Forms.Button();
            this.btnAreaCuadrilatero = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPerimetroTriangulo);
            this.groupBox1.Controls.Add(this.txtAreaTriangulo);
            this.groupBox1.Controls.Add(this.txtAlturaTriangulo);
            this.groupBox1.Controls.Add(this.txtBaseTriangulo);
            this.groupBox1.Controls.Add(this.btnCalcularPerimetroTrin);
            this.groupBox1.Controls.Add(this.btnCalcularAreaTrian);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRIANGULO EQUILATERO";
            // 
            // txtPerimetroTriangulo
            // 
            this.txtPerimetroTriangulo.Location = new System.Drawing.Point(478, 32);
            this.txtPerimetroTriangulo.Name = "txtPerimetroTriangulo";
            this.txtPerimetroTriangulo.Size = new System.Drawing.Size(105, 20);
            this.txtPerimetroTriangulo.TabIndex = 9;
            // 
            // txtAreaTriangulo
            // 
            this.txtAreaTriangulo.Location = new System.Drawing.Point(302, 32);
            this.txtAreaTriangulo.Name = "txtAreaTriangulo";
            this.txtAreaTriangulo.Size = new System.Drawing.Size(105, 20);
            this.txtAreaTriangulo.TabIndex = 8;
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(71, 78);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(105, 20);
            this.txtAlturaTriangulo.TabIndex = 7;
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(71, 32);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(105, 20);
            this.txtBaseTriangulo.TabIndex = 6;
            // 
            // btnCalcularPerimetroTrin
            // 
            this.btnCalcularPerimetroTrin.Location = new System.Drawing.Point(478, 81);
            this.btnCalcularPerimetroTrin.Name = "btnCalcularPerimetroTrin";
            this.btnCalcularPerimetroTrin.Size = new System.Drawing.Size(105, 38);
            this.btnCalcularPerimetroTrin.TabIndex = 5;
            this.btnCalcularPerimetroTrin.Text = "CALCULAR PERIMETRO";
            this.btnCalcularPerimetroTrin.UseVisualStyleBackColor = true;
            this.btnCalcularPerimetroTrin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcularAreaTrian
            // 
            this.btnCalcularAreaTrian.Location = new System.Drawing.Point(296, 81);
            this.btnCalcularAreaTrian.Name = "btnCalcularAreaTrian";
            this.btnCalcularAreaTrian.Size = new System.Drawing.Size(111, 34);
            this.btnCalcularAreaTrian.TabIndex = 4;
            this.btnCalcularAreaTrian.Text = "CALCULAR AREA ";
            this.btnCalcularAreaTrian.UseVisualStyleBackColor = true;
            this.btnCalcularAreaTrian.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perimetro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPerimetroCuadrilatero);
            this.groupBox2.Controls.Add(this.txtAreaCuadrilatero);
            this.groupBox2.Controls.Add(this.txtAlturaCuadrilatero);
            this.groupBox2.Controls.Add(this.txtBaseCuadrilatero);
            this.groupBox2.Controls.Add(this.btnPerimetroCuadrilatero);
            this.groupBox2.Controls.Add(this.btnAreaCuadrilatero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(76, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 174);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CUADRILATERO";
            // 
            // txtPerimetroCuadrilatero
            // 
            this.txtPerimetroCuadrilatero.Location = new System.Drawing.Point(478, 35);
            this.txtPerimetroCuadrilatero.Name = "txtPerimetroCuadrilatero";
            this.txtPerimetroCuadrilatero.Size = new System.Drawing.Size(105, 20);
            this.txtPerimetroCuadrilatero.TabIndex = 9;
            // 
            // txtAreaCuadrilatero
            // 
            this.txtAreaCuadrilatero.Location = new System.Drawing.Point(302, 32);
            this.txtAreaCuadrilatero.Name = "txtAreaCuadrilatero";
            this.txtAreaCuadrilatero.Size = new System.Drawing.Size(105, 20);
            this.txtAreaCuadrilatero.TabIndex = 8;
            // 
            // txtAlturaCuadrilatero
            // 
            this.txtAlturaCuadrilatero.Location = new System.Drawing.Point(71, 78);
            this.txtAlturaCuadrilatero.Name = "txtAlturaCuadrilatero";
            this.txtAlturaCuadrilatero.Size = new System.Drawing.Size(105, 20);
            this.txtAlturaCuadrilatero.TabIndex = 7;
            // 
            // txtBaseCuadrilatero
            // 
            this.txtBaseCuadrilatero.Location = new System.Drawing.Point(71, 32);
            this.txtBaseCuadrilatero.Name = "txtBaseCuadrilatero";
            this.txtBaseCuadrilatero.Size = new System.Drawing.Size(105, 20);
            this.txtBaseCuadrilatero.TabIndex = 6;
            // 
            // btnPerimetroCuadrilatero
            // 
            this.btnPerimetroCuadrilatero.Location = new System.Drawing.Point(478, 77);
            this.btnPerimetroCuadrilatero.Name = "btnPerimetroCuadrilatero";
            this.btnPerimetroCuadrilatero.Size = new System.Drawing.Size(81, 21);
            this.btnPerimetroCuadrilatero.TabIndex = 5;
            this.btnPerimetroCuadrilatero.Text = "Calcular";
            this.btnPerimetroCuadrilatero.UseVisualStyleBackColor = true;
            this.btnPerimetroCuadrilatero.Click += new System.EventHandler(this.btnPerimetroCuadrilatero_Click);
            // 
            // btnAreaCuadrilatero
            // 
            this.btnAreaCuadrilatero.Location = new System.Drawing.Point(279, 77);
            this.btnAreaCuadrilatero.Name = "btnAreaCuadrilatero";
            this.btnAreaCuadrilatero.Size = new System.Drawing.Size(81, 21);
            this.btnAreaCuadrilatero.TabIndex = 4;
            this.btnAreaCuadrilatero.Text = "Calcular";
            this.btnAreaCuadrilatero.UseVisualStyleBackColor = true;
            this.btnAreaCuadrilatero.Click += new System.EventHandler(this.btnAreaCuadrilatero_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Perimetro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Altura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Base";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPerimetroTriangulo;
        private System.Windows.Forms.TextBox txtAreaTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.Button btnCalcularPerimetroTrin;
        private System.Windows.Forms.Button btnCalcularAreaTrian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPerimetroCuadrilatero;
        private System.Windows.Forms.TextBox txtAreaCuadrilatero;
        private System.Windows.Forms.TextBox txtAlturaCuadrilatero;
        private System.Windows.Forms.TextBox txtBaseCuadrilatero;
        private System.Windows.Forms.Button btnPerimetroCuadrilatero;
        private System.Windows.Forms.Button btnAreaCuadrilatero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

