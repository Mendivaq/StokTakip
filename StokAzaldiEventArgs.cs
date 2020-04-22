using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    class StokAzaldiEventArgs:EventArgs
    {
        private int guncelStokMiktari;
        public int GuncelStokMiktari
        {
            get { return guncelStokMiktari; }
            set { guncelStokMiktari = value; }
        }
        public StokAzaldiEventArgs(int gStk)
        {
            GuncelStokMiktari = gStk;
        }
    }
}
