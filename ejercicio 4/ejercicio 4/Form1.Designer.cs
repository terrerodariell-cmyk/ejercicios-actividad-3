namespace ejercicio_4
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
            this.comboBoxEntrada = new System.Windows.Forms.ComboBox();
            this.comboBoxSalida = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxEntrada
            // 
            this.comboBoxEntrada.FormattingEnabled = true;
            this.comboBoxEntrada.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Pulgadas"});
            this.comboBoxEntrada.Location = new System.Drawing.Point(35, 51);
            this.comboBoxEntrada.Name = "comboBoxEntrada";
            this.comboBoxEntrada.Size = new System.Drawing.Size(158, 21);
            this.comboBoxEntrada.TabIndex = 0;
            this.comboBoxEntrada.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntrada_SelectedIndexChanged);
            // 
            // comboBoxSalida
            // 
            this.comboBoxSalida.FormattingEnabled = true;
            this.comboBoxSalida.Items.AddRange(new object[] {
            "Metros",
            "Centímetros",
            "Pulgadas"});
            this.comboBoxSalida.Location = new System.Drawing.Point(213, 51);
            this.comboBoxSalida.Name = "comboBoxSalida";
            this.comboBoxSalida.Size = new System.Drawing.Size(149, 21);
            this.comboBoxSalida.TabIndex = 1;
            this.comboBoxSalida.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalida_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(65, 97);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(244, 97);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(164, 140);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 190);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.comboBoxSalida);
            this.Controls.Add(this.comboBoxEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEntrada;
        private System.Windows.Forms.ComboBox comboBoxSalida;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnConvertir;
    }
}

