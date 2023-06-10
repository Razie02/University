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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 for3 = new Form3();
            for3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 for4 = new Form4();
            for4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 for5 = new Form5();
            for5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 for6 = new Form6();
            for6.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\برنامه نویسی\database\database\Database1.mdf;Integrated Security=True");
            sc.Open();
            string query = "SELECT * FROM students" ;
            SqlCommand command = new SqlCommand(query, sc);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["name"].ToString());
            }

            sc.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fo1 = new Form1();
            fo1.Show();
            this.Hide();
        }
    }
}
