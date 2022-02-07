using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variant2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "inspector" && textBox2.Text == "inspector")
            {
                Form2 drn = new Form2();
                this.Hide();
                drn.Show();
            }
            else if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Необходимо ввести логин и пароль");
            }
            else
            {
                MessageBox.Show("Вы указали неверный логин или пароль");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
