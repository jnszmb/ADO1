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
using System.Globalization;

namespace WindowsFormsApplicationDB1
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        List<Artikel> artikellist = null;
        public Form1()
        {
            InitializeComponent();
            artikellist = new List<Artikel>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Provider = Microsoft.ACE.OLEDB.12.0; Data SourceBestellung.accdb
            con = new OleDbConnection();
            //OleDbConnectionStringBuilder builder = new OleDbConnectionStringBuilder();
            //builder.Provider = "Microsoft.ACE.OLEDB.12.0";
            //builder.DataSource = "Bestellung.accdb";
            con.ConnectionString = Properties.Settings.Default.DBCon;
            try
            {
                con.Open();
                toolStripStatusLabel1.Text = "Verbindung erfolgreich";
            }
            catch (InvalidOperationException Inv)
            {
                MessageBox.Show("Verbindung bereits geöffnet");
            }
            catch (OleDbException ole)
            {
                MessageBox.Show(ole.Message);
            }
            

        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from tArtikel";
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                MessageBox.Show("Zugriff auf tArtikel nicht möglich");
            }
        }

        private void buttonReader_Click(object sender, EventArgs e)
        {
            while(reader.Read() == true)
            {
                //String bez = reader.GetString(3);
                Artikel a = MkArtikelObject(reader);
                //listBoxAusgabe.Items.Add(a);
                //listBoxAusgabe.Items.Add(reader["ArtikelNr"].ToString()+ " : "+ reader["Bezeichnung"]);
                artikellist.Add(a);
            }
            listBoxAusgabe.DataSource = artikellist;
            reader.Close();
        }

        private Artikel MkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            int i = 0;
            a.ArtikelOid = reader.GetInt32(i);
            i++;

            /*
            if (reader[i] != DBNull.Value) a.ArtikelNr = reader.GetString(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.ArtikelGruppe = reader.GetInt32(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.Bezeichnung = reader.GetString(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.Bestand = reader.GetByte(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.Meldebestand = reader.GetInt16(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.Verpackung = reader.GetInt32(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.Vkpreis = reader.GetDecimal(i++);
            else i++;
            if (reader[i] != DBNull.Value) a.LetzteEntnahme = reader.GetDateTime(i++);
            else i++;
            */

            // Mit Methode wird auf DBNull geprüft
            a.ArtikelNr = Convert.ToString(checkDBnull(reader[i++]));
            a.ArtikelGruppe = Convert.ToInt32(checkDBnull(reader[i++]));
            a.Bezeichnung = Convert.ToString(checkDBnull(reader[i++]));
            a.Bestand = Convert.ToByte(checkDBnull(reader[i++]));
            a.Meldebestand = Convert.ToInt16(checkDBnull(reader[i++]));
            a.Verpackung = Convert.ToInt32(checkDBnull(reader[i++]));
            a.Vkpreis = Convert.ToDecimal(checkDBnull(reader[i++]));
            a.LetzteEntnahme = Convert.ToDateTime(checkDBnull(reader[i++]));
            // 
            // TODO: Attribute aus DataReader gebildet werden
            return a;
            // GIT TEST
        }
        public Object checkDBnull(object o)
        {
            if (o == DBNull.Value) return null;
            else return o;
               
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(listBoxAusgabe.SelectedItem != null)
            {
                Artikel a = (Artikel)listBoxAusgabe.SelectedItem;
                FormUpdate frmUpdate = new FormUpdate(a);
                frmUpdate.ShowDialog(); // modales Fensters -> man kann nicht aufs andere Fenster klicken wenn das geöffnet
                if(frmUpdate.Result == DialogResult.OK)
                {
                    
                    updateArtikel(a);
                    listBoxAusgabe.DataSource = null;
                    listBoxAusgabe.DataSource = artikellist;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Änderung wurde abgebrochen";
                }
            }     
        }
        public void updateArtikel(Artikel a)
        {
            //TODO: Command-Objekt 
            OleDbCommand cmd = con.CreateCommand();
            //TODO: Parameter generieren
            cmd.Parameters.AddWithValue("ANR", a.ArtikelNr);
            cmd.Parameters.AddWithValue("BEZ", a.Bezeichnung);
            cmd.Parameters.AddWithValue("BEST", a.Bestand);
            cmd.Parameters.AddWithValue("MBEST", a.Meldebestand);
            cmd.Parameters.AddWithValue("VKP", a.Vkpreis);
            cmd.Parameters.AddWithValue("ENT", a.LetzteEntnahme);
            //TODO: Commandtext: SQL
            String sql = "UPDATE tArtikel SET ArtikelNr = ANR, Bezeichnung = BEZ, Bestand = BEST, Meldebestand = MBEST, VkPreis = VKP, letzteEntnahme = ENT ";
            sql += "WHERE ArtikelOid = " + a.ArtikelOid.ToString();
            cmd.CommandText = sql;
            //TODO: Conn open
            //con.Open();
            //TODO: Command ausführen
            try
            {
                cmd.ExecuteNonQuery();
                toolStripStatusLabel1.Text = "Update erfolgreich";
            }
            catch (Exception exc)
            {

                MessageBox.Show("Fehler beim Update");
                toolStripStatusLabel1.Text = exc.Message;
            }
        }

        private void buttonNeuerDatensatz_Click(object sender, EventArgs e)
        {
            Artikel a = new Artikel();
            FormInsert frmInsert = new FormInsert(con,a);
            frmInsert.ShowDialog();
            if(a != null)
            {
                InsertArtikel(a);
            }
        }
        private void InsertArtikel(Artikel a)
        {
            OleDbCommand cmd = con.CreateCommand();
            cmd.Parameters.AddWithValue("ANR", a.ArtikelNr);
            cmd.Parameters.AddWithValue("AGR", a.ArtikelGruppe);
            cmd.Parameters.AddWithValue("BEZ", a.Bezeichnung);
            cmd.Parameters.AddWithValue("BST", a.Bestand);
            cmd.Parameters.AddWithValue("MBST", a.Meldebestand);
            cmd.Parameters.AddWithValue("VERP", a.Verpackung);
            String vkp = a.Vkpreis.ToString();
            cmd.Parameters.AddWithValue("VKP", a.Vkpreis.ToString(new CultureInfo("de-DE")));
            cmd.Parameters.AddWithValue("LTZ", a.LetzteEntnahme);

            String sql = "INSERT INTO tArtikel(ArtikelNr,ArtikelGruppe,Bezeichnung,Bestand,Meldebestand,Verpackung,Vkpreis,LetzteEntnahme) ";
            sql += "VALUES(ANR,AGR,BEZ,BST,MBST,VERP,VKP,LTZ)";
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // GIT TEST
            }
        }
    }
}
