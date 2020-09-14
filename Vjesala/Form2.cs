using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjesala
{
    public partial class Form2 : Form
    {

        hangman hnm = new hangman();

        int[] statistika = new int[3];

        #region FORMA
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            statistika = hnm.UcitajStatistiku();
            lblUkupnoBodovi.Text = statistika[0].ToString();
            lblPobjedeBodovi.Text = statistika[1].ToString();
            lblIzgubljeniBodovi.Text = statistika[2].ToString();
            int proc = Int32.Parse(hnm.Obracunaj());
            lblProcPob.Text = proc.ToString() + " %";
        }
        #endregion

        #region DUGMAD
        private void btnPonisti_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni?", "Poništi statistiku", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                lblUkupnoBodovi.Text = "0";
                lblPobjedeBodovi.Text = "0";
                lblIzgubljeniBodovi.Text = "0";
                lblProcPob.Text = "0 %";
                hnm.SetujSveNaNulu();
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
