using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manger
{
    public partial class Form_show_mng : Form
    {
        public string cs_h;
        public Form_show_mng(string cs_h)
        {
            this.cs_h = cs_h;   
            InitializeComponent();
            SqlConnection con = new SqlConnection(this.cs_h);
            SqlCommand com = new SqlCommand("select * from home_mng_db ", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            _dataGridView1.DataSource = dt;

        }

        private void go_enter(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                this.Close();
            }
        }

        private void textbox_search_mng_form2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs_h);
            con.Open();
            string query = "select * from home_mng_db ";
            if (_textbox_search_name_mng_form2.Text != "")
                query += "where name_mng like '%" + _textbox_search_name_mng_form2.Text + "%'";
            SqlCommand com = new SqlCommand(query,con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            _dataGridView1.DataSource = dt;


        }

        private void textbox_search_id_mng_form2_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs_h);
            con.Open();
            string query = "select * from home_mng_db ";
            if (_textbox_search_id_mng_form2.Text != "")
                query += "where id_mng like '%" + _textbox_search_id_mng_form2.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            _dataGridView1.DataSource = dt;
            
            
        }

        private void _dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1._name_mng.Text  = _dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            f1._id_mng.Text    = _dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            f1._price_mng.Text = _dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            f1._number_mng.Text = 1.ToString();
            this.Close();

        }

        private void _dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
           
            //_textbox_search_name_mng_form2.Text = _dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            //_textbox_search_id_mng_form2.Text = _dataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            //_textbox_search_price_mng_form2.Text = _dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void textbox_search_price_mng_form2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs_h);
            con.Open();
            string query = "select * from home_mng_db ";
            if (_textbox_search_price_mng_form2.Text != "")
                query += "where price_mng like '%" + _textbox_search_price_mng_form2.Text + "%'";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            _dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        public void clear_text()
        {
            _textbox_search_name_mng_form2.Clear();
            _textbox_search_id_mng_form2.Clear();
            _textbox_search_price_mng_form2.Clear();
        }

       
    }
}
