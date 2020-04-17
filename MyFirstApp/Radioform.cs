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
    public partial class Radioform : Form
    {
        public Radioform()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
                radioButton3.ForeColor = Color.FromArgb(255, 0, 0);
            else
                radioButton3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
                radioButton4.ForeColor = Color.FromArgb(0, 255, 0);
            else
                radioButton4.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
                radioButton5.ForeColor = Color.FromArgb(0, 0, 255);
            else
                radioButton5.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
                radioButton7.ForeColor = Color.FromName("Yellow");
            else
                radioButton7.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton3.ForeColor = Color.FromArgb(0, 0, 0);
            radioButton4.ForeColor = Color.FromArgb(0, 0, 0);
            radioButton5.ForeColor = Color.FromArgb(0, 0, 0);
            radioButton7.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
