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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source =.; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Пользователи where Пользователь = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }

            else
            {
                MessageBox.Show("Пожалуйста введите логин или пароль");
            }
        }
    }
}
