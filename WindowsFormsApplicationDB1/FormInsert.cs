using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplicationDB1
{
    public partial class FormInsert : Form
    {
        OleDbConnection con;
        Artikel a;
        DialogResult result = DialogResult.OK;

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

        public FormInsert()
        {
            InitializeComponent();
        }
        public FormInsert(OleDbConnection con, Artikel artikel) : this()
        {
            this.con = con; // Connection übergeben
            InitializeControls();
        }
        public void InitializeControls()
        {
            OleDbCommand cmd = con.CreateCommand();  // Command aus der Connection erzeugen
            cmd.CommandText = "SELECT * FROM tVerpackung"; // das eigentliche Commando für die Datenbankabfrage
            OleDbDataReader reader = cmd.ExecuteReader(); // Reader aus dem Command-Objeckt erstellen
            while(reader.Read())
            {
                Verpackung ver = new Verpackung();
                ver.VerpackungsId = reader.GetInt32(0);
                ver.Bezeichnung = reader.GetString(1);
                comboBoxVerpackung.Items.Add(ver);
            }
            reader.Close(); // Reader schließen für 2. Abfrage
            cmd.CommandText = "Select * FROM tArtGruppe";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Artikelgruppe arg = new Artikelgruppe();
                arg.ArtGruppe = reader.GetInt32(0);
                arg.Bezeichnung = reader.GetString(1);
                comboBoxArtikelGruppe.Items.Add(arg);
            }
            reader.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Result = DialogResult.Cancel;
            this.Close();
        }
    }
}
