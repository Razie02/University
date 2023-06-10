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

namespace database
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string fathername = textBox2.Text;
            string phone = textBox3.Text;
            string nc = textBox4.Text;
            string sc = textBox5.Text;
            SqlConnection cc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            cc.Open();
            string query = "INSERT INTO students (name,father_name,phone_number,national_code,student_code) VALUES ('" + name + "','" + fathername + "','" + phone + "','" + nc + "','" + sc + "')";
            SqlCommand com = new SqlCommand(query, cc);
            com.ExecuteNonQuery();
            cc.Close();

            if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else
            {
                MessageBox.Show("اطلاعات دانشجوی جدید با موفقیت اضافه شد");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                this.Hide();
            }
        }
        

    }
}
