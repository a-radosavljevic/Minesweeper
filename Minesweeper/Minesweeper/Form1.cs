using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        int neotvoreneMine;
        Button[,] dugmici;
        poljeMina p;
        bool igraZapoceta = false;
        //int brojBombi = 10;

        //public int BrojBombi
        //{
        //    get
        //    {
        //        return brojBombi;
        //    }
        //    set
        //    {
        //        brojBombi = value;
        //    }
        //}

        //int dimenzijaX = 9;

        //public int DimenzijaX
        //{
        //    get
        //    {
        //        return dimenzijaX;
        //    }
        //    set
        //    {
        //        dimenzijaX = value;
        //    }
        //}

        //int dimenzijaY = 9;

        //public int DimenzijaY
        //{
        //    get
        //    {
        //        return dimenzijaY;
        //    }
        //    set
        //    {
        //        dimenzijaY = value;
        //    }
        //}

        int vreme;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (igraZapoceta == false)
            {
                p = new poljeMina();
                //lblBombeBroj.Text = poljeMina.BrojBombi.ToString();
                //vreme = 0;
                //tmrTime.Start();
                //postaviKontrole();
                //igraZapoceta = true;
                //btnStart.Text = "FINISH THE GAME";
                //neotvoreneMine = poljeMina.BrojBombi;
                zapocniIgru();
            }
            else
                zavrsiIgru();
        }

        private void zapocniIgru()
        {
            lblBombeBroj.Text = poljeMina.BrojBombi.ToString();
            vreme = 0;
            tmrTime.Start();
            postaviKontrole();
            igraZapoceta = true;
            btnStart.Text = "FINISH THE GAME";
            neotvoreneMine = poljeMina.BrojBombi;
        }

        private void zavrsiIgru()
        {
            otvoriPolja();
            igraZapoceta = false;
            btnStart.Text = "START NEW GAME";
            tmrTime.Stop();
        }

        private void otvoriPolja()
        {
            if (pnlTabla.Controls.Count == 0)
                return;
            for(int i=0;i<poljeMina.DimenzijaX; i++)
                for(int j=0;j<poljeMina.DimenzijaY;j++)
                    foreach(Button b in pnlTabla.Controls)
                        if (b.Name == dugmici[i, j].Name)
                        {
                            b.Text = poljeMina.Mine[i, j].Sadrzaj.ToString();
                            if(b.Text=="-1")
                            {
                                b.Text="X";
                                b.ForeColor=Color.Red;
                            }
                            if (b.Text == "0")
                            {
                                b.Text = "";
                                b.BackColor = Color.White;
                            }
                        }
        }

        private void postaviKontrole()
        {
            dugmici = new Button[poljeMina.DimenzijaX, poljeMina.DimenzijaY];
            //tlpTabla.ColumnCount = poljeMina.DimenzijaX;
            //tlpTabla.RowCount = poljeMina.DimenzijaY;
            //tlpTabla.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;

            pnlTabla.Controls.Clear();
            pnlTabla.Width = 25 * poljeMina.DimenzijaY;
            pnlTabla.Height = 25 * poljeMina.DimenzijaX;
            
            for(int i=0; i<poljeMina.DimenzijaX; i++)
                for (int j = 0; j < poljeMina.DimenzijaY; j++)
                {
                    Button b = new Button()
                    {
                        //Dock = System.Windows.Forms.DockStyle.Fill,
                        //Location = new System.Drawing.Point(0, 0),
                        Name = i.ToString() + " " + j.ToString(),
                        //Size = new System.Drawing.Size(20, 20),
                        Width=25,
                        Height=25,
                        Left = j * 25,
                        Top = i * 25,
                        Text = "",
                        //Margin.All = 0,
                        //Tag = i * 10 + j,
                    };
                    //b.Click += dugmeKlik;
                    //b.MouseClick += klik;
                    b.MouseUp += klik;
                    //tlpTabla.Controls.Add(b, j, i);
                    pnlTabla.Controls.Add(b);
                    dugmici[i, j] = b;
                }
        }

        private void klik(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b == null)
            {
                return;
            }
            string[] split = b.Name.Split(new Char[] { ' ' });

            int x = System.Convert.ToInt32(split[0]);
            int y = System.Convert.ToInt32(split[1]);

            if (e.Button == MouseButtons.Left)
            {
                if (poljeMina.Mine[x, y].Sadrzaj == -1)
                {
                    tmrTime.Stop();
                    b.Text = "X";
                    b.ForeColor = Color.Red;
                    zavrsiIgru();
                    MessageBox.Show("You hit a mine\nElapsed time: " + vreme + "s", "GAMEOVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (poljeMina.Mine[x, y].Sadrzaj == 0)
                {
                    b.Text = "";
                    b.Enabled = false;
                    b.BackColor = Color.White;
                    //otvaranjeNula(x, y);
                }
                else
                {
                    b.Text = poljeMina.Mine[x, y].Sadrzaj.ToString();
                    if (b.Text == "1")
                        b.ForeColor = Color.Blue;
                    else if (b.Text == "2")
                        b.ForeColor = Color.Green;
                    else if (b.Text == "3")
                        b.ForeColor = Color.Yellow;
                    else if (b.Text == "4")
                        b.ForeColor = Color.DarkCyan;
                    else if (b.Text == "5")
                        b.ForeColor = Color.DarkGray;
                    else if (b.Text == "6")
                        b.ForeColor = Color.LightSkyBlue;
                    else if (b.Text == "7")
                        b.ForeColor = Color.Navy;
                    else
                        b.ForeColor = Color.Orange;
                    b.Enabled = false;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                b.BackColor = Color.Yellow;
                foreach (Button bu in pnlTabla.Controls)
                    if (b.Name == bu.Name && poljeMina.Mine[x, y].Sadrzaj == -1)
                    {
                        neotvoreneMine--;
                        break;
                    }
                if(neotvoreneMine==0)
                {
                    MessageBox.Show("Congratulations, you found all the mines\nElaspsed time: " + lblVremeVreme.Text, "GAMEOVER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    zavrsiIgru();
                }
            }
            else
                return;
        }


        //private void otvaranjeNula(int i, int j)
        //{
        //    if (poljeMina.Mine[i, j].Sadrzaj != 0 && poljeMina.Mine[i, j].Sadrzaj != -1)
        //    {
        //        if (pnlTabla.Controls.Count == 0)
        //            return;
        //        foreach (Button b in pnlTabla.Controls)
        //            if (b.Name == dugmici[i, j].Name)
        //                b.Text = poljeMina.Mine[i, j].Sadrzaj.ToString();
        //        return;
        //    }
        //    if (poljeMina.Mine[i, j].Sadrzaj == -1)
        //        return;
        //    if (poljeMina.Mine[i, j].Sadrzaj == 0)
        //    {
        //        if (pnlTabla.Controls.Count == 0)
        //            return;
        //        foreach (Button b in pnlTabla.Controls)
        //            if (b.Name == dugmici[i, j].Name)
        //            {
        //                b.Text = "";
        //                b.Enabled = false;
        //            }
        //        if (i > 0 && poljeMina.Mine[i - 1, j].Sadrzaj == 0)
        //            otvaranjeNula(i - 1, j);
        //        if (i > 0 && j > 0 && poljeMina.Mine[i - 1, j - 1].Sadrzaj == 0)
        //            otvaranjeNula(i - 1, j - 1);
        //        if (i > 0 && j < poljeMina.DimenzijaY - 1 && poljeMina.Mine[i - 1, j + 1].Sadrzaj == 0)
        //            otvaranjeNula(i - 1, j + 1);
        //        if (j > 0 && poljeMina.Mine[i, j - 1].Sadrzaj == 0)
        //            otvaranjeNula(i, j - 1);
        //        if (j < poljeMina.DimenzijaY - 1 && poljeMina.Mine[i, j + 1].Sadrzaj == 0)
        //            otvaranjeNula(i, j + 1);
        //        if (i < poljeMina.DimenzijaX - 1 && j > 0 && poljeMina.Mine[i + 1, j - 1].Sadrzaj == 0)
        //            otvaranjeNula(i + 1, j - 1);
        //        if (i < poljeMina.DimenzijaX - 1 && poljeMina.Mine[i + 1, j].Sadrzaj == 0)
        //            otvaranjeNula(i + 1, j);
        //        if (i < poljeMina.DimenzijaX - 1 && j < poljeMina.DimenzijaY - 1 && poljeMina.Mine[i + 1, j + 1].Sadrzaj == 0)
        //            otvaranjeNula(i + 1, j + 1);
        //    }
        //}
        
        private void cUSTOMIZEFIELDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (igraZapoceta==true && DialogResult.No == MessageBox.Show("This action will finish current game. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            zavrsiIgru();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            vreme++;
            lblVremeVreme.Text = vreme + "s";
        }

        private void sAVEGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();

            if (s.ShowDialog() == DialogResult.OK)
                p.Save(s.FileName);
        }

        private void lOADGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            if (o.ShowDialog() == DialogResult.OK)
            {
                poljeMina.Load(o.FileName);
                zapocniIgru();
            }
        }
    }
}
