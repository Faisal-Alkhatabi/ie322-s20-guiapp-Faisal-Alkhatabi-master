using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class RandomFrm : Form
    {
        Random y = new Random();
        public RandomFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = y.Next(0,255);
            int g = y.Next(0,255);
            int b = y.Next(0,255);

            label1.Text = Convert.ToString(r)+ "-" + Convert.ToString(g) + "=" + Convert.ToString(b);
            button1.BackColor = Color.FromArgb(r, g, b);

        }

        private void label1_Click(object sender, EventArgs e)

        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Convert.ToString(y.Next(1, 100));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
