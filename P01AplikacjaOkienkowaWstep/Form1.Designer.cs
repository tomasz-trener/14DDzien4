namespace P01AplikacjaOkienkowaWstep
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
            this.btnPowitanieDwa = new System.Windows.Forms.Button();
            this.txtPoleTekstowe = new System.Windows.Forms.TextBox();
            this.btnWyswietlTekst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPowitanieDwa
            // 
            this.btnPowitanieDwa.Location = new System.Drawing.Point(47, 45);
            this.btnPowitanieDwa.Name = "btnPowitanieDwa";
            this.btnPowitanieDwa.Size = new System.Drawing.Size(116, 38);
            this.btnPowitanieDwa.TabIndex = 0;
            this.btnPowitanieDwa.Text = "Powitanie";
            this.btnPowitanieDwa.UseVisualStyleBackColor = true;
            this.btnPowitanieDwa.Click += new System.EventHandler(this.btnPowitanieDwa_Click);
            // 
            // txtPoleTekstowe
            // 
            this.txtPoleTekstowe.Location = new System.Drawing.Point(324, 55);
            this.txtPoleTekstowe.Name = "txtPoleTekstowe";
            this.txtPoleTekstowe.Size = new System.Drawing.Size(195, 20);
            this.txtPoleTekstowe.TabIndex = 1;
            // 
            // btnWyswietlTekst
            // 
            this.btnWyswietlTekst.Location = new System.Drawing.Point(324, 26);
            this.btnWyswietlTekst.Name = "btnWyswietlTekst";
            this.btnWyswietlTekst.Size = new System.Drawing.Size(75, 23);
            this.btnWyswietlTekst.TabIndex = 2;
            this.btnWyswietlTekst.Text = "Wyświetl";
            this.btnWyswietlTekst.UseVisualStyleBackColor = true;
            this.btnWyswietlTekst.Click += new System.EventHandler(this.btnWyswietlTekst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnWyswietlTekst);
            this.Controls.Add(this.txtPoleTekstowe);
            this.Controls.Add(this.btnPowitanieDwa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowitanieDwa;
        private System.Windows.Forms.TextBox txtPoleTekstowe;
        private System.Windows.Forms.Button btnWyswietlTekst;
    }
}

