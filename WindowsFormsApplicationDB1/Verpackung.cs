using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationDB1
{
    class Verpackung
    {
        Int32 verpackungsId;
        String verpackung;

        public int VerpackungsId
        {
            get
            {
                return verpackungsId;
            }

            set
            {
                verpackungsId = value;
            }
        }

        public string Bezeichnung
        {
            get
            {
                return verpackung;
            }

            set
            {
                verpackung = value;
            }
        }

        public override string ToString()
        {
            return this.Bezeichnung;
        }
    }
}
