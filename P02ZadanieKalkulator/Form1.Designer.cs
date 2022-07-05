namespace P02ZadanieKalkulator
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
            this.txtWyswietlacz = new System.Windows.Forms.TextBox();
            this.btnSiedem = new System.Windows.Forms.Button();
            this.btnOsiem = new System.Windows.Forms.Button();
            this.btnPrzemnoz = new System.Windows.Forms.Button();
            this.btnDziewiec = new System.Windows.Forms.Button();
            this.btnPodziel = new System.Windows.Forms.Button();
            this.btnSZesc = new System.Windows.Forms.Button();
            this.btnPiec = new System.Windows.Forms.Button();
            this.btnCztery = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnRownaSie = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.bntCzysc = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnTrzy = new System.Windows.Forms.Button();
            this.btnDwa = new System.Windows.Forms.Button();
            this.btnJeden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWyswietlacz
            // 
            this.txtWyswietlacz.Location = new System.Drawing.Point(12, 19);
            this.txtWyswietlacz.Name = "txtWyswietlacz";
            this.txtWyswietlacz.Size = new System.Drawing.Size(230, 20);
            this.txtWyswietlacz.TabIndex = 0;
            // 
            // btnSiedem
            // 
            this.btnSiedem.Location = new System.Drawing.Point(12, 45);
            this.btnSiedem.Name = "btnSiedem";
            this.btnSiedem.Size = new System.Drawing.Size(53, 55);
            this.btnSiedem.TabIndex = 1;
            this.btnSiedem.Text = "7";
            this.btnSiedem.UseVisualStyleBackColor = true;
            this.btnSiedem.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnOsiem
            // 
            this.btnOsiem.Location = new System.Drawing.Point(71, 45);
            this.btnOsiem.Name = "btnOsiem";
            this.btnOsiem.Size = new System.Drawing.Size(53, 55);
            this.btnOsiem.TabIndex = 2;
            this.btnOsiem.Text = "8";
            this.btnOsiem.UseVisualStyleBackColor = true;
            this.btnOsiem.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnPrzemnoz
            // 
            this.btnPrzemnoz.Location = new System.Drawing.Point(189, 45);
            this.btnPrzemnoz.Name = "btnPrzemnoz";
            this.btnPrzemnoz.Size = new System.Drawing.Size(53, 55);
            this.btnPrzemnoz.TabIndex = 4;
            this.btnPrzemnoz.Text = "*";
            this.btnPrzemnoz.UseVisualStyleBackColor = true;
            this.btnPrzemnoz.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnDziewiec
            // 
            this.btnDziewiec.Location = new System.Drawing.Point(130, 45);
            this.btnDziewiec.Name = "btnDziewiec";
            this.btnDziewiec.Size = new System.Drawing.Size(53, 55);
            this.btnDziewiec.TabIndex = 3;
            this.btnDziewiec.Text = "9";
            this.btnDziewiec.UseVisualStyleBackColor = true;
            this.btnDziewiec.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnPodziel
            // 
            this.btnPodziel.Location = new System.Drawing.Point(189, 106);
            this.btnPodziel.Name = "btnPodziel";
            this.btnPodziel.Size = new System.Drawing.Size(53, 55);
            this.btnPodziel.TabIndex = 8;
            this.btnPodziel.Text = "/";
            this.btnPodziel.UseVisualStyleBackColor = true;
            this.btnPodziel.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnSZesc
            // 
            this.btnSZesc.Location = new System.Drawing.Point(130, 106);
            this.btnSZesc.Name = "btnSZesc";
            this.btnSZesc.Size = new System.Drawing.Size(53, 55);
            this.btnSZesc.TabIndex = 7;
            this.btnSZesc.Text = "6";
            this.btnSZesc.UseVisualStyleBackColor = true;
            this.btnSZesc.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnPiec
            // 
            this.btnPiec.Location = new System.Drawing.Point(71, 106);
            this.btnPiec.Name = "btnPiec";
            this.btnPiec.Size = new System.Drawing.Size(53, 55);
            this.btnPiec.TabIndex = 6;
            this.btnPiec.Text = "5";
            this.btnPiec.UseVisualStyleBackColor = true;
            this.btnPiec.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnCztery
            // 
            this.btnCztery.Location = new System.Drawing.Point(12, 106);
            this.btnCztery.Name = "btnCztery";
            this.btnCztery.Size = new System.Drawing.Size(53, 55);
            this.btnCztery.TabIndex = 5;
            this.btnCztery.Text = "4";
            this.btnCztery.UseVisualStyleBackColor = true;
            this.btnCztery.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(189, 228);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 55);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnRownaSie
            // 
            this.btnRownaSie.Location = new System.Drawing.Point(130, 228);
            this.btnRownaSie.Name = "btnRownaSie";
            this.btnRownaSie.Size = new System.Drawing.Size(53, 55);
            this.btnRownaSie.TabIndex = 15;
            this.btnRownaSie.Text = "=";
            this.btnRownaSie.UseVisualStyleBackColor = true;
            this.btnRownaSie.Click += new System.EventHandler(this.btnRownaSie_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(71, 228);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(53, 55);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // bntCzysc
            // 
            this.bntCzysc.Location = new System.Drawing.Point(12, 228);
            this.bntCzysc.Name = "bntCzysc";
            this.bntCzysc.Size = new System.Drawing.Size(53, 55);
            this.bntCzysc.TabIndex = 13;
            this.bntCzysc.Text = "C";
            this.bntCzysc.UseVisualStyleBackColor = true;
            this.bntCzysc.Click += new System.EventHandler(this.bntCzysc_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(189, 167);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 55);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnTrzy
            // 
            this.btnTrzy.Location = new System.Drawing.Point(130, 167);
            this.btnTrzy.Name = "btnTrzy";
            this.btnTrzy.Size = new System.Drawing.Size(53, 55);
            this.btnTrzy.TabIndex = 11;
            this.btnTrzy.Text = "3";
            this.btnTrzy.UseVisualStyleBackColor = true;
            this.btnTrzy.Click += new System.EventHandler(this.btnPrzyciskKalkulatora_Click);
            // 
            // btnDwa
            // 
            this.btnDwa.Location = new System.Drawing.Point(71, 167);
            this.btnDwa.Name = "btnDwa";
            this.btnDwa.Size = new System.Drawing.Size(53, 55);
            this.btnDwa.TabIndex = 10;
            this.btnDwa.Text = "2";
            this.btnDwa.UseVisualStyleBackColor = true;
            this.btnDwa.Click += new System.EventHandler(this.btnDwa_Click);
            // 
            // btnJeden
            // 
            this.btnJeden.Location = new System.Drawing.Point(12, 167);
            this.btnJeden.Name = "btnJeden";
            this.btnJeden.Size = new System.Drawing.Size(53, 55);
            this.btnJeden.TabIndex = 9;
            this.btnJeden.Text = "1";
            this.btnJeden.UseVisualStyleBackColor = true;
            this.btnJeden.Click += new System.EventHandler(this.btnJeden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 298);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnRownaSie);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.bntCzysc);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnTrzy);
            this.Controls.Add(this.btnDwa);
            this.Controls.Add(this.btnJeden);
            this.Controls.Add(this.btnPodziel);
            this.Controls.Add(this.btnSZesc);
            this.Controls.Add(this.btnPiec);
            this.Controls.Add(this.btnCztery);
            this.Controls.Add(this.btnPrzemnoz);
            this.Controls.Add(this.btnDziewiec);
            this.Controls.Add(this.btnOsiem);
            this.Controls.Add(this.btnSiedem);
            this.Controls.Add(this.txtWyswietlacz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWyswietlacz;
        private System.Windows.Forms.Button btnSiedem;
        private System.Windows.Forms.Button btnOsiem;
        private System.Windows.Forms.Button btnPrzemnoz;
        private System.Windows.Forms.Button btnDziewiec;
        private System.Windows.Forms.Button btnPodziel;
        private System.Windows.Forms.Button btnSZesc;
        private System.Windows.Forms.Button btnPiec;
        private System.Windows.Forms.Button btnCztery;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnRownaSie;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button bntCzysc;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnTrzy;
        private System.Windows.Forms.Button btnDwa;
        private System.Windows.Forms.Button btnJeden;
    }
}

