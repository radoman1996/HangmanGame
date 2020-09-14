using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Vjesala
{
    class hangman
    {
        #region PODACI

        string rijeci = "biljka,boja,država,mjesec u godini,obuća,odjeća,planina,stvar,prevozno sredstvo,rijeka,voće,životinja";

        string slova = "a,b,c,č,ć,d,dž,đ,e,f,g,h,i,j,k,l,lj,m,n,nj,o,p,r,s,š,t,u,v,z,ž";

        string postavi = "";

        string postaviPojam = "";

        Random r = new Random();

        Image[] img = {Vjesala.Properties.Resources.vjesala1,
                        Vjesala.Properties.Resources.vjesala2,
                        Vjesala.Properties.Resources.vjesala3,
                        Vjesala.Properties.Resources.vjesala4,
                        Vjesala.Properties.Resources.vjesala5,
                        Vjesala.Properties.Resources.vjesala6};

        #endregion

        #region PRISTUPNE METODE
        public string GetPostavi()
        {
            return postavi;
        }
        public string SetPostavi(string postavii)
        {
            return this.postavi = postavii;
        }

        public string GetPostaviPojam()
        {
            return postaviPojam;
        }
        public string SetPostaviPojam(string postaviP)
        {
            return this.postaviPojam = postaviP;
        }
        #endregion

        #region METODE

        public string vratiPojam()
        {
            string[] trazeniPojmovi = rijeci.Split(',');
            string trazeniPojam = trazeniPojmovi[r.Next(trazeniPojmovi.Length)];
            SetPostaviPojam(trazeniPojam);
            return trazeniPojam;
        }

        public string ucitajIVratiRijec()
        {
            string pojam = vratiPojam();
            StreamReader str = File.OpenText("..\\..\\rijeci\\" + pojam + ".txt");
            string sviPojmovi = str.ReadLine();
            string[] nizPojmova = sviPojmovi.Split(',');
            string konacno = nizPojmova[r.Next(nizPojmova.Length)];
            return konacno;
        }

        public string[] nizRijeciMetod()
        {
            string[] nizRijeci = rijeci.Split(',');
            return nizRijeci;
        }

        public string[] vratiNoviNiz(string s)
        {
            char[] nizKaraktera = s.ToCharArray();
            int novaDuzina = 0;
            for (int i = 0; i < nizKaraktera.Length; i++)
            {
                if (i + 1 < nizKaraktera.Length)
                {
                    if ((nizKaraktera[i] == 'n' && nizKaraktera[i + 1] == 'j') || (nizKaraktera[i] == 'l' && nizKaraktera[i + 1] == 'j') || (nizKaraktera[i] == 'd' && nizKaraktera[i + 1] == 'ž'))
                    {
                        i++;
                        novaDuzina++;
                    }
                    else
                    {
                        novaDuzina++;
                    }
                }
                else
                {
                    novaDuzina++;
                }
            }
            Console.WriteLine(novaDuzina);

            string[] noviNizSlova = new string[novaDuzina];
            int br = 0;
            for (int i = 0; i < noviNizSlova.Length; i++)
            {
                if (br + 1 < nizKaraktera.Length)
                {
                    if ((nizKaraktera[br] == 'n' && nizKaraktera[br + 1] == 'j') || (nizKaraktera[br] == 'l' && nizKaraktera[br + 1] == 'j') || (nizKaraktera[br] == 'd' && nizKaraktera[br + 1] == 'ž'))
                    {
                        noviNizSlova[i] = nizKaraktera[br].ToString() + nizKaraktera[br + 1].ToString();
                        br += 2;
                    }
                    else
                    {
                        noviNizSlova[i] = nizKaraktera[br].ToString();
                        br += 1;
                    }
                }
                else
                {
                    noviNizSlova[i] = nizKaraktera[br].ToString();
                }
            }
            return noviNizSlova;
        }

        public void ubaciRijec2()
        {
            string izbor = ucitajIVratiRijec();
            Console.WriteLine(izbor);
            string trazenaRijec = SetPostavi(izbor); //rijec koju cemo uzeti preko GET
        }

        public string[] nizSlovaMetod()
        {
            string[] nizSlova = slova.Split(',');
            return nizSlova;
        }

        public Image[] nazivSlikaMetod()
        {
            return img;
        }

        public int[] izFajla()
        {
            int[] sve = new int[3];
            StreamReader str = File.OpenText("..\\..\\Statistika\\pobjeda.txt");
            int pobjede = Int32.Parse(str.ReadLine());
            str.Close();
            str = File.OpenText("..\\..\\Statistika\\izgubljenih.txt");
            int poraz = Int32.Parse(str.ReadLine());
            str.Close();
            str = File.OpenText("..\\..\\Statistika\\ukupno.txt");
            int ukupno = Int32.Parse(str.ReadLine());
            str.Close();
            sve[0] = ukupno;
            sve[1] = pobjede;
            sve[2] = poraz;
            return sve;
        }

        public void UkupnoIPobjede()
        {
            int[] up = izFajla();
            int ukupno = up[0] + 1;
            int pobjede = up[1] + 1;
            System.IO.File.WriteAllText("..\\..\\Statistika\\ukupno.txt", ukupno.ToString());
            System.IO.File.WriteAllText("..\\..\\Statistika\\pobjeda.txt", pobjede.ToString());
        }

        public void UkupnoIPorazi()
        {
            int[] up = izFajla();
            int ukupno = up[0] + 1;
            int porazi = up[2] + 1;
            System.IO.File.WriteAllText("..\\..\\Statistika\\ukupno.txt", ukupno.ToString());
            System.IO.File.WriteAllText("..\\..\\Statistika\\izgubljenih.txt", porazi.ToString());
        }

        public int[] UcitajStatistiku()
        {
            int[] odigrano = izFajla();
            return odigrano;
        }

        public string Obracunaj()
        {
            string procenti = "";
            int[] obracun = izFajla();
            int pob = obracun[1];
            int uk = obracun[0];
            if (uk == 0)
            {
                procenti = "0";
            }
            else
            {
                procenti = ((100 * pob) / uk).ToString();
            }
            return procenti;
        }

        public void SetujSveNaNulu()
        {
            System.IO.File.WriteAllText("..\\..\\Statistika\\ukupno.txt", "0");
            System.IO.File.WriteAllText("..\\..\\Statistika\\pobjeda.txt", "0");
            System.IO.File.WriteAllText("..\\..\\Statistika\\izgubljenih.txt", "0");
        }
        #endregion
    }
}
