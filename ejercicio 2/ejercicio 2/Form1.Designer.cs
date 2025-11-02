namespace ejercicio_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.chkMayusculas = new System.Windows.Forms.CheckBox();
            this.chkNumeros = new System.Windows.Forms.CheckBox();
            this.chkEspeciales = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(309, 272);
            this.txtLongitud.Multiline = true;
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(163, 31);
            this.txtLongitud.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(508, 384);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(88, 40);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // chkMayusculas
            // 
            this.chkMayusculas.AutoSize = true;
            this.chkMayusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMayusculas.Location = new System.Drawing.Point(309, 184);
            this.chkMayusculas.Name = "chkMayusculas";
            this.chkMayusculas.Size = new System.Drawing.Size(157, 24);
            this.chkMayusculas.TabIndex = 3;
            this.chkMayusculas.Text = "Incluir Mayusculas";
            this.chkMayusculas.UseVisualStyleBackColor = true;
            // 
            // chkNumeros
            // 
            this.chkNumeros.AutoSize = true;
            this.chkNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumeros.Location = new System.Drawing.Point(309, 204);
            this.chkNumeros.Name = "chkNumeros";
            this.chkNumeros.Size = new System.Drawing.Size(136, 24);
            this.chkNumeros.TabIndex = 4;
            this.chkNumeros.Text = "Incluir números";
            this.chkNumeros.UseVisualStyleBackColor = true;
            this.chkNumeros.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkEspeciales
            // 
            this.chkEspeciales.AutoSize = true;
            this.chkEspeciales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEspeciales.Location = new System.Drawing.Point(309, 227);
            this.chkEspeciales.Name = "chkEspeciales";
            this.chkEspeciales.Size = new System.Drawing.Size(228, 24);
            this.chkEspeciales.TabIndex = 5;
            this.chkEspeciales.Text = "Incluir caracteres especiales";
            this.chkEspeciales.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(51, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 368);
            this.listBox1.TabIndex = 7;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(309, 319);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(163, 31);
            this.txtResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chkEspeciales);
            this.Controls.Add(this.chkNumeros);
            this.Controls.Add(this.chkMayusculas);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtLongitud);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLongitud;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox chkMayusculas;
        private System.Windows.Forms.CheckBox chkNumeros;
        private System.Windows.Forms.CheckBox chkEspeciales;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

