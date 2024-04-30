using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manger
{
    public partial class Form_buy : Form
    {
        public Form_buy()
        {
            InitializeComponent();
         
        }

        private void Form_buy_Load(object sender, EventArgs e)
        {
            _price_all_form_buy.Text = My_tool._total.ToString();
        }

        private void _paid_up_form_buy_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double _paid_up = Convert.ToDouble(_paid_up_form_buy.Text);
                _paid_up -= Convert.ToDouble(_price_all_form_buy.Text);
                _Residual_form_buy.Text = _paid_up.ToString();
            }catch
            {
                _paid_up_form_buy.Clear();
            }
            
        }

        private void _ok_form_buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("لاتنسى الفاتورة");
            this.Close();
           
        }

        private void _paid_up_form_buy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                _ok_form_buy_Click(null, null);
            }
        }
    }
}
