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
    public partial class PicForm : Form
    {
        public PicForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\IE322\\MyFirstApp\\KAU.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void PicForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\DELL\\Desktop\\IE322\\MyFirstApp\\Pic1.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
