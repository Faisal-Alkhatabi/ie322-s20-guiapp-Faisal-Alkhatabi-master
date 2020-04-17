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
    public partial class Combo : Form
    {
        public Combo()
        {
            InitializeComponent();
            comboBox1.Items.Add("Saturday");
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");
            comboBox1.Items.Add("Wednesday");
            comboBox1.Items.Add("Thursday");
            comboBox1.Items.Add("Friday");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 2)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Cant remove 2nd last item");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            MessageBox.Show(item);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Remove("Friday");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count >= 1)
            {
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Cant remove last item");
            }
        }
    }
}
