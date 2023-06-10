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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            SqlConnection ccc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            ccc.Open();
            string query = "DELETE FROM teachers WHERE name ='" + name + "'";
            SqlCommand command = new SqlCommand(query, ccc);
            command.ExecuteNonQuery();
            ccc.Close();
            if (textBox1.Text == "")
            {
                MessageBox.Show("اطلاعات وارد نشده است");
            }
            else
            {
                MessageBox.Show("استاد مورد نظر با موفقیت حذف شد");
                textBox1.Text = "";
                this.Hide();
            }
        }
    }
}
