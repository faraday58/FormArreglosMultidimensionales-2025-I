namespace FormArreglosMultidimensionales_2025_I
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
            this.txtbDisplay = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbOperando1 = new System.Windows.Forms.Label();
            this.lbOperando2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnAgregarOperando = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbDisplay
            // 
            this.txtbDisplay.Location = new System.Drawing.Point(127, 48);
            this.txtbDisplay.Name = "txtbDisplay";
            this.txtbDisplay.Size = new System.Drawing.Size(284, 20);
            this.txtbDisplay.TabIndex = 0;
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(113, 281);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 69);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(272, 281);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 69);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(403, 281);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(75, 69);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operando 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbOperando1
            // 
            this.lbOperando1.AutoSize = true;
            this.lbOperando1.Location = new System.Drawing.Point(135, 122);
            this.lbOperando1.Name = "lbOperando1";
            this.lbOperando1.Size = new System.Drawing.Size(25, 26);
            this.lbOperando1.TabIndex = 2;
            this.lbOperando1.Text = "0  0\r\n0  0";
            // 
            // lbOperando2
            // 
            this.lbOperando2.AutoSize = true;
            this.lbOperando2.Location = new System.Drawing.Point(387, 122);
            this.lbOperando2.Name = "lbOperando2";
            this.lbOperando2.Size = new System.Drawing.Size(34, 26);
            this.lbOperando2.TabIndex = 2;
            this.lbOperando2.Text = "2  1\r\n3   10";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(558, 122);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(31, 26);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "2  1\r\n3  10";
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Location = new System.Drawing.Point(127, 13);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(45, 17);
            this.rdbDeg.TabIndex = 3;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "Deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Location = new System.Drawing.Point(263, 12);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(45, 17);
            this.rdbRad.TabIndex = 3;
            this.rdbRad.TabStop = true;
            this.rdbRad.Text = "Rad";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(528, 281);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(119, 69);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "Seno";
            this.btnSin.UseVisualStyleBackColor = true;
            // 
            // btnAgregarOperando
            // 
            this.btnAgregarOperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOperando.Location = new System.Drawing.Point(113, 184);
            this.btnAgregarOperando.Name = "btnAgregarOperando";
            this.btnAgregarOperando.Size = new System.Drawing.Size(131, 69);
            this.btnAgregarOperando.TabIndex = 1;
            this.btnAgregarOperando.Text = "Agregar Operando";
            this.btnAgregarOperando.UseVisualStyleBackColor = true;
            this.btnAgregarOperando.Click += new System.EventHandler(this.btnAgregarOperando_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 379);
            this.Controls.Add(this.rdbRad);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbOperando2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbOperando1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAgregarOperando);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.txtbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbDisplay;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbOperando1;
        private System.Windows.Forms.Label lbOperando2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.RadioButton rdbRad;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnAgregarOperando;
    }
}

