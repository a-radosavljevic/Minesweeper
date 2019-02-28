using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Podaci
{
    [Serializable]
    public class poljeMina
    {
        static int brojBombi = 10;

        public static int BrojBombi
        {
            get
            {
                return brojBombi;
            }
            set
            {
                brojBombi = value;
            }
        }

        static int dimenzijaX = 9;

        public static int DimenzijaX
        {
            get
            {
                return dimenzijaX;
            }
            set
            {
                dimenzijaX = value;
            }
        }

        static int dimenzijaY = 9;

        public static int DimenzijaY
        {
            get
            {
                return dimenzijaY;
            }
            set
            {
                dimenzijaY = value;
            }
        }

        static Mina[,] mine;

        public static Mina[,] Mine
        {
            get
            {
                return mine;
            }
            set
            {
                mine = value;
            }
        }

        public poljeMina()
        {
            mine = new Mina[dimenzijaX, dimenzijaY];
            for (int i = 0; i < dimenzijaX; i++)
                for (int j = 0; j < dimenzijaY; j++)
                    mine[i, j] = new Mina();
            postaviBombe();
            postaviBrojOkolnihMina();
        }

        private void postaviBombe()
        {
            Random ranX = new Random();
            int bombe = brojBombi;

            while(bombe>0)
            {
                int x=ranX.Next(dimenzijaX);
                int y = ranX.Next(dimenzijaY);
                if (mine[x, y].Sadrzaj == -2)
                {
                    mine[x, y].Sadrzaj = -1;
                    bombe--;
                }
            }
        }

        private void postaviBrojOkolnihMina()
        {
            for(int i=0; i<DimenzijaX; i++)
                for (int j = 0; j < DimenzijaY; j++)
                {
                    mine[i, j].PozicijaX = i;
                    mine[i, j].PozicijaY = j;
                    if (mine[i, j].Sadrzaj != -1)
                    {
                        int broj = 0;
                        if (i > 0 && mine[i - 1, j].Sadrzaj == -1)
                            broj++;
                        if (i > 0 && j > 0 && mine[i - 1, j - 1].Sadrzaj == -1)
                            broj++;
                        if (i > 0 && j < DimenzijaY - 1 && mine[i - 1, j + 1].Sadrzaj == -1)
                            broj++;
                        if (j > 0 && mine[i, j - 1].Sadrzaj == -1)
                            broj++;
                        if (j < DimenzijaY - 1 && mine[i, j + 1].Sadrzaj == -1)
                            broj++;
                        if (i < DimenzijaX - 1 && j > 0 && mine[i + 1, j - 1].Sadrzaj == -1)
                            broj++;
                        if (i < DimenzijaX - 1 && mine[i + 1, j].Sadrzaj == -1)
                            broj++;
                        if (i < DimenzijaX - 1 && j < DimenzijaY - 1 && mine[i + 1, j + 1].Sadrzaj == -1)
                            broj++;
                        mine[i, j].Sadrzaj = broj;
                    }
                }
        }

        public void Save(string fileName)
        {
            XmlTextWriter wr = null;
            try
            {
                /// napravi se objekat koji je u stanju da upisuje u fajl
                wr = new XmlTextWriter(fileName, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da serijalizuje 
                /// objekte klase student
                XmlSerializer sr = new XmlSerializer(typeof(poljeMina));

                ///poziva se serijalizacija
                sr.Serialize(wr, this);
            }
            catch
            {
            }
            finally
            {
                /// na kraju se writer objekat zatvara
                wr.Close();
            }
        }

        public static poljeMina Load(string fileName)
        {
            StreamReader rd = null;
            try
            {
                /// napravi se objekat koji je u stanju da cita podatke iz fajla
                rd = new StreamReader(fileName, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da deserijalizuje 
                /// objekte klase student
                XmlSerializer sr = new XmlSerializer(typeof(poljeMina));

                ///poziva se deserijalizacija
                poljeMina loadedData = (poljeMina)sr.Deserialize(rd);

                /// vraca se restaurirani objekat
                return loadedData;
            }
            catch
            {
                return null;
            }
            finally
            {
                rd.Close();
            }

        }
    }
}
