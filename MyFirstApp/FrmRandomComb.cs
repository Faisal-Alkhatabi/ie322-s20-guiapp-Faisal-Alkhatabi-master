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
    public partial class FrmRandomComb : Form
    {
        Random y = new Random();
        public FrmRandomComb()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            comboBox2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(2, 9) - 1; i++)
            {
                comboBox2.Items.Add(r.Next(10, 99));
            }
            label1.Text = Convert.ToString(comboBox2.Items.Count);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.Text) > 499)
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                comboBox1.Items.Add(r.Next(100, 999));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            comboBox2.Items.Clear();
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            label1.Text = Convert.ToString(comboBox2.Items.Count);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.Text) > 49)
            {
                radioButton4.Checked = true;
            }
            else
            {
                radioButton3.Checked = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 51); i++)
            {
                comboBox1.Items.Add(r.Next(100, 999));
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
