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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            SqlConnection sss = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            sss.Open();
            string query = "UPDATE students SET phone_number='" + phone + "' WHERE name='" + name + "'";
            SqlCommand command = new SqlCommand(query,sss);
            command.ExecuteNonQuery();
            sss.Close();
            if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else
            {
                MessageBox.Show("تغییر اطلاعات با موفقیت انجام شد");
                textBox1.Text = textBox2.Text = "";
                this.Hide();
            }
        }
    }
}
