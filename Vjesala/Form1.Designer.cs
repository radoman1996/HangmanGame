namespace Vjesala
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.igraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaIgraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCPUGame = new System.Windows.Forms.Panel();
            this.lblSpisakSlova = new System.Windows.Forms.Label();
            this.panelTastatura = new System.Windows.Forms.Panel();
            this.pictureBoxSlicica = new System.Windows.Forms.PictureBox();
            this.lblKliknuliNa = new System.Windows.Forms.Label();
            this.panelPolja = new System.Windows.Forms.Panel();
            this.lblTrazeniPojam = new System.Windows.Forms.Label();
            this.panelInstrukcije = new System.Windows.Forms.Panel();
            this.lblNazad = new System.Windows.Forms.Label();
            this.lblDalje = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelNaslovna = new System.Windows.Forms.Panel();
            this.lblIzlaz = new System.Windows.Forms.Label();
            this.lblPravila = new System.Windows.Forms.Label();
            this.lblIgrac = new System.Windows.Forms.Label();
            this.lblNovaIgra = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelCPUGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlicica)).BeginInit();
            this.panelInstrukcije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelNaslovna.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // igraToolStripMenuItem
            // 
            this.igraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaIgraToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.igraToolStripMenuItem.Name = "igraToolStripMenuItem";
            this.igraToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.igraToolStripMenuItem.Text = "Igra";
            // 
            // novaIgraToolStripMenuItem
            // 
            this.novaIgraToolStripMenuItem.Name = "novaIgraToolStripMenuItem";
            this.novaIgraToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.novaIgraToolStripMenuItem.Text = "Nova Igra";
            this.novaIgraToolStripMenuItem.Click += new System.EventHandler(this.novaIgraToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // panelCPUGame
            // 
            this.panelCPUGame.BackColor = System.Drawing.Color.Green;
            this.panelCPUGame.Controls.Add(this.lblSpisakSlova);
            this.panelCPUGame.Controls.Add(this.panelTastatura);
            this.panelCPUGame.Controls.Add(this.pictureBoxSlicica);
            this.panelCPUGame.Controls.Add(this.lblKliknuliNa);
            this.panelCPUGame.Controls.Add(this.panelPolja);
            this.panelCPUGame.Controls.Add(this.lblTrazeniPojam);
            this.panelCPUGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCPUGame.Location = new System.Drawing.Point(0, 24);
            this.panelCPUGame.Name = "panelCPUGame";
            this.panelCPUGame.Size = new System.Drawing.Size(694, 457);
            this.panelCPUGame.TabIndex = 4;
            this.panelCPUGame.Visible = false;
            // 
            // lblSpisakSlova
            // 
            this.lblSpisakSlova.AutoSize = true;
            this.lblSpisakSlova.Location = new System.Drawing.Point(170, 196);
            this.lblSpisakSlova.Name = "lblSpisakSlova";
            this.lblSpisakSlova.Size = new System.Drawing.Size(0, 13);
            this.lblSpisakSlova.TabIndex = 5;
            // 
            // panelTastatura
            // 
            this.panelTastatura.Location = new System.Drawing.Point(27, 239);
            this.panelTastatura.Name = "panelTastatura";
            this.panelTastatura.Size = new System.Drawing.Size(400, 120);
            this.panelTastatura.TabIndex = 4;
            // 
            // pictureBoxSlicica
            // 
            this.pictureBoxSlicica.Location = new System.Drawing.Point(463, 115);
            this.pictureBoxSlicica.Name = "pictureBoxSlicica";
            this.pictureBoxSlicica.Size = new System.Drawing.Size(217, 265);
            this.pictureBoxSlicica.TabIndex = 3;
            this.pictureBoxSlicica.TabStop = false;
            // 
            // lblKliknuliNa
            // 
            this.lblKliknuliNa.AutoSize = true;
            this.lblKliknuliNa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKliknuliNa.Location = new System.Drawing.Point(24, 191);
            this.lblKliknuliNa.Name = "lblKliknuliNa";
            this.lblKliknuliNa.Size = new System.Drawing.Size(132, 17);
            this.lblKliknuliNa.TabIndex = 2;
            this.lblKliknuliNa.Text = "Kliknuli ste na slova: ";
            // 
            // panelPolja
            // 
            this.panelPolja.Location = new System.Drawing.Point(27, 70);
            this.panelPolja.Name = "panelPolja";
            this.panelPolja.Size = new System.Drawing.Size(657, 39);
            this.panelPolja.TabIndex = 1;
            // 
            // lblTrazeniPojam
            // 
            this.lblTrazeniPojam.AutoSize = true;
            this.lblTrazeniPojam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrazeniPojam.Location = new System.Drawing.Point(23, 38);
            this.lblTrazeniPojam.Name = "lblTrazeniPojam";
            this.lblTrazeniPojam.Size = new System.Drawing.Size(45, 19);
            this.lblTrazeniPojam.TabIndex = 0;
            this.lblTrazeniPojam.Text = "label1";
            // 
            // panelInstrukcije
            // 
            this.panelInstrukcije.Controls.Add(this.lblNazad);
            this.panelInstrukcije.Controls.Add(this.lblDalje);
            this.panelInstrukcije.Controls.Add(this.pictureBox2);
            this.panelInstrukcije.Controls.Add(this.pictureBox1);
            this.panelInstrukcije.Controls.Add(this.groupBox3);
            this.panelInstrukcije.Controls.Add(this.groupBox2);
            this.panelInstrukcije.Controls.Add(this.groupBox1);
            this.panelInstrukcije.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInstrukcije.Location = new System.Drawing.Point(0, 24);
            this.panelInstrukcije.Name = "panelInstrukcije";
            this.panelInstrukcije.Size = new System.Drawing.Size(694, 457);
            this.panelInstrukcije.TabIndex = 6;
            this.panelInstrukcije.Visible = false;
            // 
            // lblNazad
            // 
            this.lblNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNazad.Image = global::Vjesala.Properties.Resources.nazad;
            this.lblNazad.Location = new System.Drawing.Point(27, 304);
            this.lblNazad.Name = "lblNazad";
            this.lblNazad.Size = new System.Drawing.Size(107, 27);
            this.lblNazad.TabIndex = 6;
            this.lblNazad.Click += new System.EventHandler(this.lblNazad_Click);
            // 
            // lblDalje
            // 
            this.lblDalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDalje.Image = global::Vjesala.Properties.Resources.dalje;
            this.lblDalje.Location = new System.Drawing.Point(564, 302);
            this.lblDalje.Name = "lblDalje";
            this.lblDalje.Size = new System.Drawing.Size(100, 31);
            this.lblDalje.TabIndex = 5;
            this.lblDalje.Click += new System.EventHandler(this.lblDalje_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vjesala.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(18, 293);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 152);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vjesala.Properties.Resources.next;
            this.pictureBox1.Location = new System.Drawing.Point(550, 293);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 152);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PRAVILA IGRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kliknite na slovo po želji. Ako slovo postoji u riječi pojaviće se u odgovarajuće" +
    "m polju.\r\nAko ne postoji slovo ostaje vam sve manje pokušaja do kraja igre.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CILJ IGRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pogodite riječ prije nego što naš junak završi na vješalima.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPIS IGRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tražite izazov!!! Na pravom ste mjestu. \r\nPogodite uspješno što više riječi i pos" +
    "tanite šampion u zanimljivoj igri Vješala.";
            // 
            // panelNaslovna
            // 
            this.panelNaslovna.BackgroundImage = global::Vjesala.Properties.Resources.pozadina;
            this.panelNaslovna.Controls.Add(this.lblIzlaz);
            this.panelNaslovna.Controls.Add(this.lblPravila);
            this.panelNaslovna.Controls.Add(this.lblIgrac);
            this.panelNaslovna.Controls.Add(this.lblNovaIgra);
            this.panelNaslovna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNaslovna.Location = new System.Drawing.Point(0, 24);
            this.panelNaslovna.Name = "panelNaslovna";
            this.panelNaslovna.Size = new System.Drawing.Size(694, 457);
            this.panelNaslovna.TabIndex = 0;
            // 
            // lblIzlaz
            // 
            this.lblIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIzlaz.Image = global::Vjesala.Properties.Resources.izlaz;
            this.lblIzlaz.Location = new System.Drawing.Point(547, 319);
            this.lblIzlaz.Name = "lblIzlaz";
            this.lblIzlaz.Size = new System.Drawing.Size(134, 55);
            this.lblIzlaz.TabIndex = 3;
            this.lblIzlaz.Click += new System.EventHandler(this.lblIzlaz_Click);
            // 
            // lblPravila
            // 
            this.lblPravila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPravila.Image = global::Vjesala.Properties.Resources.pravila;
            this.lblPravila.Location = new System.Drawing.Point(414, 314);
            this.lblPravila.Name = "lblPravila";
            this.lblPravila.Size = new System.Drawing.Size(126, 64);
            this.lblPravila.TabIndex = 2;
            this.lblPravila.Click += new System.EventHandler(this.lblPravila_Click);
            // 
            // lblIgrac
            // 
            this.lblIgrac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIgrac.Image = global::Vjesala.Properties.Resources.igrac;
            this.lblIgrac.Location = new System.Drawing.Point(261, 317);
            this.lblIgrac.Name = "lblIgrac";
            this.lblIgrac.Size = new System.Drawing.Size(134, 58);
            this.lblIgrac.TabIndex = 1;
            this.lblIgrac.Click += new System.EventHandler(this.lblIgrac_Click);
            // 
            // lblNovaIgra
            // 
            this.lblNovaIgra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovaIgra.Image = global::Vjesala.Properties.Resources.novaIgra;
            this.lblNovaIgra.Location = new System.Drawing.Point(130, 312);
            this.lblNovaIgra.Name = "lblNovaIgra";
            this.lblNovaIgra.Size = new System.Drawing.Size(118, 65);
            this.lblNovaIgra.TabIndex = 0;
            this.lblNovaIgra.Click += new System.EventHandler(this.lblNovaIgra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 481);
            this.Controls.Add(this.panelCPUGame);
            this.Controls.Add(this.panelInstrukcije);
            this.Controls.Add(this.panelNaslovna);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(710, 520);
            this.MinimumSize = new System.Drawing.Size(710, 520);
            this.Name = "Form1";
            this.Text = "VJEŠALA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCPUGame.ResumeLayout(false);
            this.panelCPUGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlicica)).EndInit();
            this.panelInstrukcije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelNaslovna.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNaslovna;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem igraToolStripMenuItem;
        private System.Windows.Forms.Label lblNovaIgra;
        private System.Windows.Forms.Label lblIgrac;
        private System.Windows.Forms.Label lblPravila;
        private System.Windows.Forms.Label lblIzlaz;
        private System.Windows.Forms.ToolStripMenuItem novaIgraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Panel panelCPUGame;
        private System.Windows.Forms.Panel panelTastatura;
        private System.Windows.Forms.PictureBox pictureBoxSlicica;
        private System.Windows.Forms.Label lblKliknuliNa;
        private System.Windows.Forms.Panel panelPolja;
        private System.Windows.Forms.Label lblTrazeniPojam;
        private System.Windows.Forms.Label lblSpisakSlova;
        private System.Windows.Forms.Panel panelInstrukcije;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblDalje;
        private System.Windows.Forms.Label lblNazad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

