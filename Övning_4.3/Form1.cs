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

namespace Övning_4._3
{
    public partial class FrmKontakt : Form
    {
        public FrmKontakt()
        {
            InitializeComponent();
        }




        private void btnSparaSom_Click(object sender, EventArgs e)
        {
            //Visa dialogruta där man kan ange ett filnamn
            DialogResult resultat = dlgSparaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //ÖppnaStröm
                FileStream utStröm = new FileStream(dlgSparaFil.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                //Öppna skrivare
                StreamWriter skrivare = new StreamWriter(utStröm);

                //Skriv en kontakt i taget
                foreach (Kontakt k in lbxKontakter.Items)
                {
                    //Skriv en rad text i taget.
                    skrivare.WriteLine(tbxFörnamn.Text);
                    skrivare.WriteLine(tbxEfternamn.Text);
                    skrivare.WriteLine(tbxEpost.Text);
                    skrivare.WriteLine(tbxTelefonnummer.Text);
                }

                //Stäng filen
                skrivare.Dispose();
            }
        }

        private void btnÖppna_Click(object sender, EventArgs e)
        {
            //Visa dialogruta där man kan ange ett filnamn för öppning
            DialogResult resultat = dlgÖppnaFil.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                //ÖppnaStröm
                FileStream inStröm = new FileStream(dlgÖppnaFil.FileName, FileMode.Open, FileAccess.Read);

                //Öppna skrivare
                StreamReader läsare = new StreamReader(inStröm);

                //Läs en rad text i taget.
                tbxFörnamn.Text = läsare.ReadLine();
                tbxEfternamn.Text = läsare.ReadLine();
                tbxEpost.Text = läsare.ReadLine();
                tbxTelefonnummer.Text = läsare.ReadLine();

                //Stäng filen
                läsare.Dispose();
            }

        }

        private void btnLäggtill_Click(object sender, EventArgs e)
        {
            //Skapa kontakt
            Kontakt k = new Kontakt(tbxFörnamn.Text, tbxEfternamn.Text, tbxEpost.Text, tbxTelefonnummer.Text);
            //Lägg till kontakt
            lbxKontakter.Items.Add(k);
        }

        private void btnTabort_Click(object sender, EventArgs e)
        {
            if (lbxKontakter.SelectedItem != null)
            {
                // Ta bort den valda kontakten
                lbxKontakter.Items.RemoveAt(lbxKontakter.SelectedIndex);
            }
        }
        private void lbxKontakter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxKontakter.SelectedItem != null)
            {
                //Gör ett objekt av den valda kontakten
                Kontakt K = lbxKontakter.SelectedItem as Kontakt;
                //Skriv de olika delarna av kontakten i respektive textbox
                tbxFörnamn.Text = K.Förnamn;
                tbxEfternamn.Text = K.Efternamn;
                tbxEpost.Text = K.Epost;
                tbxTelefonnummer.Text = K.Telefonnr;
            }
            else
            {
                //Skriv de olika delarna av kontakten i respektive textbox
                tbxFörnamn.Text = "";
                tbxEfternamn.Text = "";
                tbxEpost.Text = "";
                tbxTelefonnummer.Text = "";
            }
        }



    }

    class Kontakt
    {
        /// <summary>
        /// KOnstruktor som skapar en kontakt med alla världen.
        /// </summary>
        /// <param name="förnamn">Kontaktens förnamn</param>
        /// <param name="efternamn">Kontaktens efternamn</param>
        /// <param name="epost">Kontaktens e-postadress</param>
        /// <param name="telefonnr">Kontaktens telefonnummer</param>

        public Kontakt(string förnamn, string efternamn, string epost, string telefonnr)
        {
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
            this.Epost = epost;
            this.Telefonnr = telefonnr;
        }

        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefonnr { get; set; }
        /// <summary>
        /// Skriver kontaktens namn
        /// </summary>
        /// <returns>Retunerar kontaktens för- och efternman</returns>
        public override string ToString()
        {
            return Förnamn + " " + Efternamn;
        }

    }
}