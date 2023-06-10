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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nc = textBox1.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT phone_number FROM students WHERE student_code='" + nc + "'";
            SqlCommand command = new SqlCommand(query, sc);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                MessageBox.Show(reader["phone_number"].ToString(),"شماره موبایل دانشجو");
                this.Hide();
            }

            sc.Close();
        }
    }
}
