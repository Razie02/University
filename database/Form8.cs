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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string nc = textBox3.Text;
            string education = textBox4.Text;
            string gender = textBox5.Text;
            SqlConnection cc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            cc.Open();
            string query = "INSERT INTO teachers (name,last_name,national_code,degree_of_educatin,gender) VALUES ('" + name + "','" + lastname + "','" + nc + "','" + education + "','" + gender + "')";
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
                MessageBox.Show("اطلاعات استاد جدید با موفقیت اضافه شد");
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                this.Hide();
            }
        }
    }
}
