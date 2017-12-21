using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationDB1
{
    class Artikelgruppe
    {
        Int32 artikelgruppe;
        String bezeichnung;

        public int ArtGruppe
        {
            get
            {
                return artikelgruppe;
            }

            set
            {
                artikelgruppe = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return bezeichnung;
            }

            set
            {
                bezeichnung = value;
            }
        }
        public override string ToString()
        {
            return this.Bezeichnung;
        }
    }
}
