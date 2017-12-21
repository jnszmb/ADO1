using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationDB1
{
    public partial class FormUpdate : Form
    {
        private Artikel selArtikel;
        private DialogResult result = DialogResult.OK;

        public DialogResult Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public Artikel SelArtikel
        {
            get
            {
                return selArtikel;
            }

            private set
            {
                selArtikel = value;
            }
        }

        public FormUpdate()
        {
            InitializeComponent();
        }
        public FormUpdate(Artikel artikel) : this()
        {
            
            SelArtikel = artikel;
            InitializeControls();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }
        public void InitializeControls()
        {
            textBoxArtikelOid.Text = SelArtikel.ArtikelOid.ToString();
            textBoxArtikelNr.Text = SelArtikel.ArtikelNr.ToString();
            textBoxArtikelGruppe.Text = SelArtikel.ArtikelGruppe.ToString();
            textBoxBezeichnung.Text = SelArtikel.Bezeichnung.ToString();
            textBoxBestand.Text = SelArtikel.Bestand.ToString();
            textBoxMeldebestand.Text = SelArtikel.Meldebestand.ToString();
            textBoxVerpackung.Text = SelArtikel.Verpackung.ToString();
            textBoxVkPreis.Text = SelArtikel.Vkpreis.ToString();
            textBoxLetzteEntnahme.Text = SelArtikel.LetzteEntnahme.ToShortDateString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SelArtikel.ArtikelNr = textBoxArtikelNr.Text;
            SelArtikel.Bezeichnung = textBoxBezeichnung.Text;
            SelArtikel.Bestand = Convert.ToByte(textBoxBestand.Text);
            SelArtikel.Meldebestand = Convert.ToInt16(textBoxMeldebestand.Text);
            SelArtikel.Vkpreis = Convert.ToDecimal(textBoxVkPreis.Text);
            SelArtikel.LetzteEntnahme = Convert.ToDateTime(textBoxLetzteEntnahme.Text);
            this.Close();
        }
    }
}
