using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Mina
    {
        private int sadrzaj;

        public int Sadrzaj
        {
            get { return sadrzaj; }
            set { sadrzaj = value; }
        }

        private int pozicijaX;

        public int PozicijaX
        {
            get { return pozicijaX; }
            set { pozicijaX = value; }
        }

        private int pozicijaY;

        public int PozicijaY
        {
            get { return pozicijaY; }
            set { pozicijaY = value; }
        }

        public Mina()
        {
            sadrzaj = -2;//     -2: NEPOSTAVLJENO, -1: MINA
            pozicijaX = -1;
            pozicijaY = -1;
        }

        public Mina(int sadrzaj, int pozX, int pozY)
        {
            this.sadrzaj=sadrzaj;
            this.pozicijaX = pozX;
            this.pozicijaY = pozY;
        }
    }
}
