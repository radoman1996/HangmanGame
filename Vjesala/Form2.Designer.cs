namespace Vjesala
{
    partial class Form2
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
            this.lblUkupno = new System.Windows.Forms.Label();
            this.lblPobjeda = new System.Windows.Forms.Label();
            this.lblPoraz = new System.Windows.Forms.Label();
            this.lblProcenat = new System.Windows.Forms.Label();
            this.lblUkupnoBodovi = new System.Windows.Forms.Label();
            this.lblPobjedeBodovi = new System.Windows.Forms.Label();
            this.lblIzgubljeniBodovi = new System.Windows.Forms.Label();
            this.lblProcPob = new System.Windows.Forms.Label();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(26, 20);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(97, 13);
            this.lblUkupno.TabIndex = 0;
            this.lblUkupno.Text = "Ukupno odigranih: ";
            // 
            // lblPobjeda
            // 
            this.lblPobjeda.AutoSize = true;
            this.lblPobjeda.Location = new System.Drawing.Point(26, 49);
            this.lblPobjeda.Name = "lblPobjeda";
            this.lblPobjeda.Size = new System.Drawing.Size(52, 13);
            this.lblPobjeda.TabIndex = 1;
            this.lblPobjeda.Text = "Pobjede: ";
            // 
            // lblPoraz
            // 
            this.lblPoraz.AutoSize = true;
            this.lblPoraz.Location = new System.Drawing.Point(26, 78);
            this.lblPoraz.Name = "lblPoraz";
            this.lblPoraz.Size = new System.Drawing.Size(63, 13);
            this.lblPoraz.TabIndex = 2;
            this.lblPoraz.Text = "Izgubljenih: ";
            // 
            // lblProcenat
            // 
            this.lblProcenat.AutoSize = true;
            this.lblProcenat.Location = new System.Drawing.Point(26, 107);
            this.lblProcenat.Name = "lblProcenat";
            this.lblProcenat.Size = new System.Drawing.Size(97, 13);
            this.lblProcenat.TabIndex = 3;
            this.lblProcenat.Text = "Procenat pobjeda: ";
            // 
            // lblUkupnoBodovi
            // 
            this.lblUkupnoBodovi.AutoSize = true;
            this.lblUkupnoBodovi.Location = new System.Drawing.Point(162, 21);
            this.lblUkupnoBodovi.Name = "lblUkupnoBodovi";
            this.lblUkupnoBodovi.Size = new System.Drawing.Size(13, 13);
            this.lblUkupnoBodovi.TabIndex = 4;
            this.lblUkupnoBodovi.Text = "0";
            // 
            // lblPobjedeBodovi
            // 
            this.lblPobjedeBodovi.AutoSize = true;
            this.lblPobjedeBodovi.Location = new System.Drawing.Point(162, 50);
            this.lblPobjedeBodovi.Name = "lblPobjedeBodovi";
            this.lblPobjedeBodovi.Size = new System.Drawing.Size(13, 13);
            this.lblPobjedeBodovi.TabIndex = 5;
            this.lblPobjedeBodovi.Text = "0";
            // 
            // lblIzgubljeniBodovi
            // 
            this.lblIzgubljeniBodovi.AutoSize = true;
            this.lblIzgubljeniBodovi.Location = new System.Drawing.Point(162, 79);
            this.lblIzgubljeniBodovi.Name = "lblIzgubljeniBodovi";
            this.lblIzgubljeniBodovi.Size = new System.Drawing.Size(13, 13);
            this.lblIzgubljeniBodovi.TabIndex = 6;
            this.lblIzgubljeniBodovi.Text = "0";
            // 
            // lblProcPob
            // 
            this.lblProcPob.AutoSize = true;
            this.lblProcPob.Location = new System.Drawing.Point(162, 108);
            this.lblProcPob.Name = "lblProcPob";
            this.lblProcPob.Size = new System.Drawing.Size(13, 13);
            this.lblProcPob.TabIndex = 7;
            this.lblProcPob.Text = "0";
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(26, 140);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(141, 25);
            this.btnPonisti.TabIndex = 8;
            this.btnPonisti.Text = "Poništi";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(188, 140);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(141, 25);
            this.btnIzadji.TabIndex = 9;
            this.btnIzadji.Text = "Izađi";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.lblProcPob);
            this.Controls.Add(this.lblIzgubljeniBodovi);
            this.Controls.Add(this.lblPobjedeBodovi);
            this.Controls.Add(this.lblUkupnoBodovi);
            this.Controls.Add(this.lblProcenat);
            this.Controls.Add(this.lblPoraz);
            this.Controls.Add(this.lblPobjeda);
            this.Controls.Add(this.lblUkupno);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 210);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.Label lblPobjeda;
        private System.Windows.Forms.Label lblPoraz;
        private System.Windows.Forms.Label lblProcenat;
        private System.Windows.Forms.Label lblUkupnoBodovi;
        private System.Windows.Forms.Label lblPobjedeBodovi;
        private System.Windows.Forms.Label lblIzgubljeniBodovi;
        private System.Windows.Forms.Label lblProcPob;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Button btnIzadji;
    }
}