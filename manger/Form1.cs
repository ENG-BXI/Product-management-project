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
using System.Globalization;

namespace manger
{
    
    public partial class Form1 : Form
    {
      
        Form_setting _form_setting = new Form_setting();
        
        //مجموع الحساب الذي سيعرض للمستخدم
        
        public Form1()
        {
            InitializeComponent();
            // تم وضع المسح هنا حتى ينظف قاعدة البيانات الفرعية 
            BXI_tool. cls();

        }
        public void _add_Click(object sender, EventArgs e)
        {
            // حتى يسهل الاسخدام لتحريك التاب من مكان الكتابة الى زر add وهذا كلة بزر enter
            _name_mng.TabIndex += 1;
            // اتصال بيانات لتعبة الجدول الفرعي
            string cs_h = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cs_h);
            //يعطي اشارة اذا اراد المستخدم الاضافة ومربع النص فاضي 
            if (_name_mng.Text != "" && _id_mng.Text != "")
            {
                try
                { //تحويل القيم من مربع النص الى  المتغيرات لاضافتها في قواعد البيانات 
                    BXI_tool.id = Convert.ToInt32(_id_mng.Text);
                    BXI_tool.name = _name_mng.Text;
                    BXI_tool.price = Convert.ToDouble(_price_mng.Text);
                    BXI_tool._number_mng_v = Convert.ToInt16(_number_mng.Text);
                    BXI_tool.price = BXI_tool.price * BXI_tool._number_mng_v;
                }
                catch
                {
                    MessageBox.Show("تاكد من كتابة اسم المنتج بشكل صحيح \nاذا اردك معرفة اسم المنتجات اكتب ( . )ثم الضغط على انتر  ");
                    goto error;

                } // catch 1
                try
                {
                    string query = "insert into home_tb (name_h_mng,id_h_mng,price_h_mng,number_mng) values (" + "'" +BXI_tool.name + "'," + BXI_tool.id + "," + BXI_tool.price + "," + BXI_tool._number_mng_v + ")";
                    
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();  
                    com.ExecuteNonQuery();
                    BXI_tool._can_delete = true;
                    BXI_tool._v_to_stop_delete += 1;
                }
                catch (Exception)
                {
                    MessageBox.Show("هنالك مشكلة في الاتصال بالبيانات ");
                    //الانتقال الى error اذا وجد خطا 
                    goto error;
                }// catch 2
                    error:
                // خاصة بالجدول الفرعي 
                _refresh();
                _sum_total();
                
            }
            else
                MessageBox.Show("قم بادخال العنصر اولا");

        } //_add_Click

        private void _delete_Click(object sender, EventArgs e)
        {
            string cs_h = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cs_h);
            
            // 
            BXI_tool._can_delete = BXI_tool._v_to_stop_delete == 0 ? false :  true;

            try
            {

                if (BXI_tool._can_delete)
                {
                    // يقوم بحدف المنتج المحدد من الجدول الفرعي باستخدام 
                    //_dataGridView_home.CurrentRow.Cells[1].Value
                    //يحدف رقم المنتج المتوافق مع المحدد

                    string query = "delete from home_tb where id_h_mng = " + _dataGridView_home.CurrentRow.Cells[1].Value.ToString() + "";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    // انقاص واحد لكي يعمل على ايقاف الحدف بعد حدف الكل 
                    BXI_tool._v_to_stop_delete -= 1;
                    if (BXI_tool._v_to_stop_delete == 0)
                        BXI_tool._can_delete = false;
                }
                else
                    MessageBox.Show("لايوجد شي لحدفة"); 
            }
            catch (Exception)
            {
                MessageBox.Show("هنالك مشكلة في الاتصال بالبيانات ");
            }
            
            _refresh();
            _sum_total();

        }//_delete_Click
        private void _delete_all_Click(object sender, EventArgs e)
        {
            if (BXI_tool._can_delete)
            {
                string cs_h = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(cs_h);
                //متغيرات للاضافة

                try
                {
                    string query = "delete from home_tb";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    com.ExecuteNonQuery();
                    // بعد حدف الجميع يمنع الحدف وذلك بجعل المتغير الخاصة به ب
                    //false
                    BXI_tool._can_delete = false;
                    //حتى يتم تفعيل الشرط في الاعلى 
                    //_can_delete = false becouse _v_to_stop_delete = 0
                    BXI_tool._v_to_stop_delete = 0; 
                }
                catch (Exception)
                {
                    MessageBox.Show("هنالك مشكلة في الاتصال بالبيانات ");
                }
                _refresh();
                _sum_total();

            }
            else
            {
                MessageBox.Show("لايوجد شي لحدفة");
            }

        }
        //الدالة الخاصة بالتحديث للجدول الفرعي
        public void _refresh()
        {
            string cs_h = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cs_h);
            //لاضافة البيانات الى القاعدة الثانية الخاصة بالمشتري 
            SqlCommand com = new SqlCommand("select * from home_tb ", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            _dataGridView_home.DataSource = dt;
            //تغير اسامي الاعمدة الى هذه الاسامي
            this._dataGridView_home.Columns[0].HeaderText = "اسم المنتج";
            this._dataGridView_home.Columns[1].HeaderText = "رقم المنتج ";
            this._dataGridView_home.Columns[2].HeaderText = "سعر المنتج";
            //ضبط المسافات للاعمده 
            this._dataGridView_home.Columns[0].Width = 300;
            this._dataGridView_home.Columns[1].Width = 100;
            this._dataGridView_home.Columns[2].Width = 240;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-ye");
            this._dataGridView_home.Columns[2].DefaultCellStyle.Format = "c";


            //مسح النصوص لتسريع العملية 
            _clear_text();

            SendKeys.Send("{tab}");
        }
        
        public void _clear_text()
        {
            _name_mng.Clear();
            _id_mng.Clear();
            _price_mng.Clear();
        }
        private void _Settings_home_Click(object sender, EventArgs e)
        {
            // نافذة الاعدادات
            _form_setting.Show();
        }
        private void _ok_Click(object sender, EventArgs e)
        {
            Form_buy _form_buy = new Form_buy();
            //نافذة المحاسبة الاخيرة والدفع 
            _form_buy.Show();
        }
        private void _id_mng_Leave(object sender, EventArgs e)
        {
            if (_id_mng.Text != ".")
            {
                // يستخدم القاعدة العامة
                string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection con = new SqlConnection(cs);
                SqlCommand com = new SqlCommand("SELECT * from home_mng_db where id_mng like '%" + _id_mng.Text + "%'", con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                //بقوم بتبئة مربعات النص الخاصة بالاسم والرقم والسعر من خلال كتابة احرف الاسم الاولى
                _name_mng.Text = dr["name_mng"].ToString();
                _id_mng.Text = dr["id_mng"].ToString();
                _price_mng.Text = dr["price_mng"].ToString();
                con.Close();
            }
            else
            {
                //اذا تم الضغط على "." ستظهر نافدة المنتجات لتحديد الاسم المناسب
                Form_show_mng _show_Mng = new Form_show_mng();
                _show_Mng.Show();
                _name_mng.Clear();
            }

        }
        private void _name_mng_KeyPress(object sender, KeyPressEventArgs e)
        {
            //هل الزر المضغوط هو انتر
            if (e.KeyChar == 13)
            {
                if (_name_mng.Text == ".")
                {
                    //اذا تم الضغط على "." ستظهر نافدة المنتجات لتحديد الاسم المناسب
                    Form_show_mng _show_Mng = new Form_show_mng();
                    _show_Mng.Show();
                    _name_mng.Clear();
                }
                else
                {
                    if(_name_mng.Text != "")
                    {
                        try
                        {
                            // يستخدم القاعدة العامة
                            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
                            SqlConnection con = new SqlConnection(cs);
                            SqlCommand com = new SqlCommand("SELECT * from home_mng_db where name_mng like '%" + _name_mng.Text + "%'", con);
                            con.Open();
                            SqlDataReader dr = com.ExecuteReader();
                            dr.Read();
                            // بقوم بتبئة مربعات النص الخاصة بالاسم والرقم والسعر من خلال كتابة احرف الاسم الاولى
                            _name_mng.Text = dr["name_mng"].ToString();
                            _id_mng.Text = dr["id_mng"].ToString();
                            _price_mng.Text = dr["price_mng"].ToString();
                            con.Close();
                            //اذا لم يحدد رقم يجعل الرقم التلقائي 1 
                            _number_mng.Text = "1";

                            //تعمل على الانتقال الى زر الاضافة 
                            SendKeys.Send("{tab}");


                        }
                        catch
                        {
                            MessageBox.Show("تاكد من كتابة المنتج بشكل صحيح");
                        }
                    }//if != ""
                    else
                    {
                        MessageBox.Show("لايمكن ان يكون الحقل فارغا");
                    }
                }//if != "."
            }
        }//_name_mng_KeyPress
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BXI_tool.cls();
            _refresh();
        }
        private void _dataGridView_home_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //تعبئة مربعات النص من خلال تحديد المنتج في الجدول الفرعي
                _name_mng.Text = _dataGridView_home.Rows[e.RowIndex].Cells["name_h_mng"].Value.ToString().Trim();
                _id_mng.Text = _dataGridView_home.Rows[e.RowIndex].Cells["id_h_mng"].Value.ToString().Trim();
                _price_mng.Text = _dataGridView_home.Rows[e.RowIndex].Cells["price_h_mng"].Value.ToString().Trim();
            }
            catch
            {}
            
           
        }
        private void _id_mng_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == 13)
            {
                if (_id_mng.Text != ".")
                {
                    // يستخدم القاعدة العامة
                    string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand com = new SqlCommand("SELECT * from home_mng_db where id_mng like '%" + _id_mng.Text + "%'", con);
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    dr.Read();
                    // بقوم بتبئة مربعات النص الخاصة بالاسم والرقم والسعر من خلال كتابة احرف الاسم الاولى
                    _name_mng.Text = dr["name_mng"].ToString();
                    _id_mng.Text = dr["id_mng"].ToString();
                    _price_mng.Text = dr["price_mng"].ToString();
                    con.Close();
                    //تعمل على الانتقال الى زر الاضافة 
                    SendKeys.Send("{tab}");
                }
                else
                {
                    if(_id_mng.Text != "")
                    {
                        //اذا تم الضغط على "." ستظهر نافدة المنتجات لتحديد الاسم المناسب
                        Form_show_mng _show_Mng = new Form_show_mng();
                        _show_Mng.Show();
                        _name_mng.Clear(); 
                    }
                    else
                        MessageBox.Show("لايمكن ان يكون الحقل فارغا");
                }
            }
        }
        void _sum_total()
        {
            //يقوم بحساب المجموع لوضعة في مربع المجموع من الجدول 
            double _total_local = 0; 

            for(int i = 0; i < _dataGridView_home.Rows.Count; i++)
            {
                _total_local += Convert.ToDouble(_dataGridView_home.Rows[i].Cells[2].Value);
            }
            _price_all.Text = _total_local.ToString();
            BXI_tool._total = _total_local;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //مربع الخروج
            Application.Exit();
        }
        private void _setting_buttom_Click(object sender, EventArgs e)
        {
            Form_setting _form_setting = new Form_setting();
            Form1 f1 = Application.OpenForms["Form1"] as Form1;
            f1.Hide();
            _form_setting.Show();
        }

        private void _dataGridView_home_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }//Form1

    // كلاس خاص بالمتغيرات والدوال الخارجية
    public class BXI_tool
    {
      static  public int        id;
      static  public string     name;
      static  public double     price;
      static  public bool       _can_delete = false;
      static  public int        _v_to_stop_delete = 0;
      static  public int        _number_price_all;
      static  public int        _number_del = -1;
      static  public double     _total;
      static  public int        _number_mng_v;

        //لسته لاضافة الاسعار للمشتري حتى يتم جمعها وحسا الناتج النهائي
        static public List<string> _v_use_sum_all = new List<string>();
        static public void go_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{tab}");
            }
        }
        static public void cls()
        {
            string cs_h = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+Application.StartupPath+@"\mng_db.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cs_h);
            //متغيرات للاضافة
            try
            {
                string query = "delete from home_tb";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("هنالك مشكلة في الاتصال بالبيانات ");
            }

        }
       
    }
}