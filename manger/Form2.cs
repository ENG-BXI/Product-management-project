using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace manger
{
    public partial class Form_setting : Form
    {
        public Form_setting()
        {
            InitializeComponent();
        }

        private void _setting_buttom_Click(object sender, EventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms["form1"] as Form1;
            this.Hide();
            f1.Show();
        }

        private void Form_setting_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void add_mng_set_Click(object sender, EventArgs e)
        {
            _add_mng_form amf = new _add_mng_form();
            amf.Show();
        }
    }
}
