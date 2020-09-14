using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vjesala
{
    public partial class Form1 : Form
    {

        hangman hnm = new hangman();
        Form2 f2 = new Form2();

        #region PODACI
        Button[,] tastatura = new Button[3, 10];
        TextBox[] polje = new TextBox[100];
        int index = 0;
        #endregion

        #region FORMA
        public Form1()
        {
            InitializeComponent();
            Kreiraj();

            #region POZIV KLIKA NA TASTATURU
            for (int i = 0; i < tastatura.GetLength(0); i++)
            {
                for (int j = 0; j < tastatura.GetLength(1); j++)
                {
                    this.tastatura[i, j].Click += new EventHandler(this.taster_Click);
                }
            }
            #endregion

            PocetnaSlikaVjesala();
            UpisiIndex(index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        

        #region NASLOVNA DUGMAD
        private void lblNovaIgra_Click(object sender, EventArgs e)
        {
            panelCPUGame.Visible = true;
            ubaciRijec();
            UpisiIndex(index);
            lblTrazeniPojam.Text = "Traženi pojam je: " + Pojam();
        }

        private void lblIgrac_Click(object sender, EventArgs e)
        {

        }

        private void lblPravila_Click(object sender, EventArgs e)
        {
            panelInstrukcije.Visible = true;
        }

        private void lblIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region ZA NOVU IGRU PREKO MENUa
        public void Postavi()
        {
            panelPolja.Controls.Clear();
            PocetnaSlikaVjesala();
            UpisiIndex(index);
            ubaciRijec();
            lblKliknuliNa.Text = "Kliknuli ste na slova: ";
            lblTrazeniPojam.Text = "Traženi pojam je: " + Pojam();
        }
        #endregion

        #region MENU STAVKA
        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelCPUGame.Visible == true)
            {
                DialogResult dr = MessageBox.Show("Igra će se računati kao poraz u statistici.\n" + "Da li ste sigurni da želite novu igru?", "Obavještenje", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    hnm.UkupnoIPorazi();
                    Postavi();
                }
            }
            else
            {
                panelCPUGame.Visible = true;
                Postavi();
            }
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region KLIK MISEM NA TASTATURU

        private void taster_Click(object sender, EventArgs e)
        {
            Image[] nizNazivaSlika = hnm.nazivSlikaMetod();
            int pozicija = UcitajIndex();
            string kliknutoSlovo = ((Button)sender).Text;
            string[] slovaLab = Labela();
            int br = 0;
            for (int i = 0; i < slovaLab.Length; i++)
            {
                if (slovaLab[i] == kliknutoSlovo)
                {
                    br = 1;
                    break;
                }
            }
            if (br == 0)
            {
                lblKliknuliNa.Text = lblKliknuliNa.Text + " " + kliknutoSlovo;

                string rijecZaKontrolu = hnm.GetPostavi();
                string[] slovaTrazeneRijeci = hnm.vratiNoviNiz(rijecZaKontrolu);
                int brojac = 0;
                for (int i = 0; i < slovaTrazeneRijeci.Length; i++)
                {
                    if (slovaTrazeneRijeci[i] == kliknutoSlovo)
                    {
                        polje[i].Text = kliknutoSlovo;
                    }
                    else
                    {
                        brojac++;
                    }
                }
                if (brojac == slovaTrazeneRijeci.Length)
                {
                    if (pozicija < nizNazivaSlika.Length - 1)
                    {
                        pictureBoxSlicica.Image = nizNazivaSlika[pozicija];
                        pozicija += 1;
                        UpisiIndex(pozicija);
                    }
                    else
                    {
                        pictureBoxSlicica.Image = nizNazivaSlika[pozicija];
                        pozicija += 1;
                        DialogResult diRez = MessageBox.Show("Izgubili ste. Tražena riječ je " + rijecZaKontrolu.ToUpper() + ". Želite li da nastavite? ", "Poraz", MessageBoxButtons.YesNo);
                        if (diRez == DialogResult.Yes)
                        {
                            hnm.UkupnoIPorazi();

                            if (panelCPUGame.Visible == false)
                            {
                                panelCPUGame.Visible = true;
                            }
                            panelPolja.Controls.Clear();
                            PocetnaSlikaVjesala();
                            UpisiIndex(index);
                            ubaciRijec();
                            lblKliknuliNa.Text = "Kliknuli ste na slova: ";
                            lblTrazeniPojam.Text = "Traženi pojam je: " + Pojam();
                        }
                        else if (diRez == DialogResult.No)
                        {
                            hnm.UkupnoIPorazi();

                            Application.Exit();
                        }
                    }
                }

                #region RJESENJE
                string odgovor = "";
                int duzinaResenja = slovaTrazeneRijeci.Length;
                for (int i = 0; i < duzinaResenja; i++)
                {
                    odgovor += polje[i].Text;
                }
                if (odgovor == rijecZaKontrolu)
                {
                    DialogResult diRez = MessageBox.Show("Pogodili ste riječ. Želite li da nastavite? ", "Pobjeda", MessageBoxButtons.YesNo);
                    if (diRez == DialogResult.Yes)
                    {
                        hnm.UkupnoIPobjede();

                        if (panelCPUGame.Visible == false)
                        {
                            panelCPUGame.Visible = true;
                        }
                        panelPolja.Controls.Clear();
                        PocetnaSlikaVjesala();
                        UpisiIndex(index);
                        ubaciRijec();
                        lblKliknuliNa.Text = "Kliknuli ste na slova: ";
                        lblTrazeniPojam.Text = "Traženi pojam je: " + Pojam();
                    }
                    else if (diRez == DialogResult.No)
                    {
                        hnm.UkupnoIPobjede();

                        Application.Exit();
                    }
                }
                #endregion

            }




        }

        #endregion

        #region KREIRAJ
        public void Kreiraj()
        {
            panelTastatura.BackColor = Color.White;
            string[] nizSlova = hnm.nizSlovaMetod();
            int x = 0;
            int y = 0;
            int w = 40;
            int h = 40;
            int taster = 0;
            for (int i = 0; i < tastatura.GetLength(0); i++)
            {
                for (int j = 0; j < tastatura.GetLength(1); j++)
                {
                    tastatura[i, j] = new Button();
                    tastatura[i, j].SetBounds(x, y, w, h);
                    tastatura[i, j].Font = new Font("Times Now Roman", 12, FontStyle.Bold);
                    tastatura[i, j].Text = nizSlova[taster];
                    tastatura[i, j].BackColor = Color.GreenYellow;
                    taster++;
                    this.panelTastatura.Controls.Add(tastatura[i, j]);
                    x += 40;
                }
                x = 0;
                y += 40;
            }
        }
        #endregion

        #region METODE

        #region KREIRANJE TEKSTUALNIH POLJA
        public void kreiranjePolja()
        {
            string izbor = hnm.GetPostavi();
            string[] noviNizSlova = hnm.vratiNoviNiz(izbor);
            int pozX = 0;
            int pozY = 0;
            int w = 40;
            int h = 40;
            for (int i = 0; i < noviNizSlova.Length; i++)
            {
                polje[i] = new TextBox();
                polje[i].SetBounds(pozX, pozY, w, h);
                polje[i].Multiline = true;
                polje[i].Font = new Font("Times New Roman", 20, FontStyle.Regular);
                polje[i].TextAlign = HorizontalAlignment.Center;
                polje[i].ReadOnly = true;

                this.panelPolja.Controls.Add(polje[i]);
                pozX += 40;
            }
        }
        #endregion

        #region UBACIVANJE ILI IZBOR RIJECI

        public void ubaciRijec()
        {
            hnm.ubaciRijec2();
            kreiranjePolja();
        }

        #endregion

        #region NIZ SLOVA LABELE
        public string[] Labela()
        {
            string niz = lblKliknuliNa.Text;
            string[] konacno = niz.Split(' ');
            return konacno;
        }

        #endregion

        #region POJAM
        public string Pojam()
        {
            string p = hnm.GetPostaviPojam();
            string pom = p.ToUpper();
            return pom;
        }
        #endregion

        #region UCITAVANJE I UPIS INDEKSA
        public void UpisiIndex(int ind)
        {
            System.IO.File.WriteAllText("..\\..\\index.txt", ind.ToString());
        }
        public int UcitajIndex()
        {
            StreamReader str = File.OpenText("..\\..\\index.txt");
            int ind = Int32.Parse(str.ReadLine());
            str.Close();
            return ind;
        }
        #endregion

        #endregion

        #region INSTRUKCIJE PANEL
        private void lblDalje_Click(object sender, EventArgs e)
        {
            panelInstrukcije.Visible = false;
            panelCPUGame.Visible = true;
            ubaciRijec();
            UpisiIndex(index);
            lblTrazeniPojam.Text = "Traženi pojam je: " + Pojam();
        }

        private void lblNazad_Click(object sender, EventArgs e)
        {
            panelInstrukcije.Visible = false;
        }
        #endregion

        public void PocetnaSlikaVjesala()
        {
            pictureBoxSlicica.Image = Vjesala.Properties.Resources.vjesala;
        }
    }
}
