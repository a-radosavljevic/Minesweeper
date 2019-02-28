using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true || string.IsNullOrEmpty(textBox3.Text) == true)
            {
                MessageBox.Show("Please enter values ​​for all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.Parse(textBox1.Text) < 9 || int.Parse(textBox2.Text) < 9)
            {
                MessageBox.Show("The minimum field dimensions are 9x9, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(textBox1.Text) > 30 || int.Parse(textBox2.Text) > 30)
            {
                MessageBox.Show("The maximum field dimensions are 30x30, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (int.Parse(textBox3.Text) > int.Parse(textBox1.Text) * int.Parse(textBox2.Text))
            {
                MessageBox.Show("The number of bombs can not be greater than the number of places, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Podaci.poljeMina.DimenzijaX = int.Parse(textBox1.Text);
            Podaci.poljeMina.DimenzijaY = int.Parse(textBox2.Text);
            Podaci.poljeMina.BrojBombi = int.Parse(textBox3.Text);

            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
