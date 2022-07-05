namespace P03ZadaniePogoda
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
            this.btnPodajTemperature = new System.Windows.Forms.Button();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.rbCelcjusz = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbKelvin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMiasto = new System.Windows.Forms.ComboBox();
            this.btnWczytajMiasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPodajTemperature
            // 
            this.btnPodajTemperature.Location = new System.Drawing.Point(12, 12);
            this.btnPodajTemperature.Name = "btnPodajTemperature";
            this.btnPodajTemperature.Size = new System.Drawing.Size(160, 23);
            this.btnPodajTemperature.TabIndex = 0;
            this.btnPodajTemperature.Text = "Podaj temperature";
            this.btnPodajTemperature.UseVisualStyleBackColor = true;
            this.btnPodajTemperature.Click += new System.EventHandler(this.btnPodajTemperature_Click);
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(175, 71);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(35, 13);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "label1";
            // 
            // rbCelcjusz
            // 
            this.rbCelcjusz.AutoSize = true;
            this.rbCelcjusz.Checked = true;
            this.rbCelcjusz.Location = new System.Drawing.Point(12, 71);
            this.rbCelcjusz.Name = "rbCelcjusz";
            this.rbCelcjusz.Size = new System.Drawing.Size(64, 17);
            this.rbCelcjusz.TabIndex = 3;
            this.rbCelcjusz.TabStop = true;
            this.rbCelcjusz.Text = "Celcjusz";
            this.rbCelcjusz.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(12, 94);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbFahrenheit.TabIndex = 4;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbKelvin
            // 
            this.rbKelvin.AutoSize = true;
            this.rbKelvin.Location = new System.Drawing.Point(12, 117);
            this.rbKelvin.Name = "rbKelvin";
            this.rbKelvin.Size = new System.Drawing.Size(54, 17);
            this.rbKelvin.TabIndex = 5;
            this.rbKelvin.Text = "Kelvin";
            this.rbKelvin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jednostka";
            // 
            // cbMiasto
            // 
            this.cbMiasto.FormattingEnabled = true;
            this.cbMiasto.Location = new System.Drawing.Point(178, 14);
            this.cbMiasto.Name = "cbMiasto";
            this.cbMiasto.Size = new System.Drawing.Size(230, 21);
            this.cbMiasto.TabIndex = 7;
            // 
            // btnWczytajMiasta
            // 
            this.btnWczytajMiasta.Location = new System.Drawing.Point(415, 11);
            this.btnWczytajMiasta.Name = "btnWczytajMiasta";
            this.btnWczytajMiasta.Size = new System.Drawing.Size(75, 23);
            this.btnWczytajMiasta.TabIndex = 8;
            this.btnWczytajMiasta.Text = "Wczytaj";
            this.btnWczytajMiasta.UseVisualStyleBackColor = true;
            this.btnWczytajMiasta.Click += new System.EventHandler(this.btnWczytajMiasta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 149);
            this.Controls.Add(this.btnWczytajMiasta);
            this.Controls.Add(this.cbMiasto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbKelvin);
            this.Controls.Add(this.rbFahrenheit);
            this.Controls.Add(this.rbCelcjusz);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.btnPodajTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPodajTemperature;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.RadioButton rbCelcjusz;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbKelvin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMiasto;
        private System.Windows.Forms.Button btnWczytajMiasta;
    }
}

