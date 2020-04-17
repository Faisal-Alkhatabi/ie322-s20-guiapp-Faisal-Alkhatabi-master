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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtPw_TextChanged(object sender, EventArgs e)
        {

            TxtPw.PasswordChar = '*';
        }

        private void LplPw_Click(object sender, EventArgs e)
        {

        }

        private void LplUser_Click(object sender, EventArgs e)
        {

        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Faisal" && TxtPw.Text == "1234") {
                MessageBox.Show("Login Successful");

            }
            else if (TxtUser.Text != "Faisal" && TxtPw.Text != "1234")
            {
                MessageBox.Show("Password and Username is incorrect");
            }
            else if (TxtPw.Text != "1234")
            {
                MessageBox.Show("Password is incorrect");
            }
            else if (TxtUser.Text != "Faisal")
            {
                MessageBox.Show("Username is incorrect");
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check frm = new Check();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Radioform frm = new Radioform();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Combo frm = new Combo();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            PicForm frm = new PicForm();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RandomFrm frm = new RandomFrm();
            frm.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            FrmRandomComb frm = new FrmRandomComb();
            frm.ShowDialog();
        }
    }
}
