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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 add = new Form3();
            add.db = db;
            DialogResult dr = add.ShowDialog();

            if (dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = db.Drivers.ToList();
                Update();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivers dv = (Drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show("Вы действительно хотите удалить запись? -" + dv.ID.ToString(), "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Drivers.Remove(dv);
                try
                {
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
