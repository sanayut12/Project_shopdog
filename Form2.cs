using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ShopdogV1
{
    public partial class login_form : Form
    {
        //connect database
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");
        MySqlCommand command;

        public login_form()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_form Ref = new Register_form();
            Ref.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "SELECT UserName , Password FROM users WHERE UserName ='" + User_box.Text + "'AND Password = '" + Pass_box.Text + "'";

            connection.Open();

            command = new MySqlCommand(insertQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            int x = 0;
            while (reader.Read())
            {
                if (reader.GetString("UserName") == User_box.Text && reader.GetString("Password") == Pass_box.Text)
                {
                    Main_form mf = new Main_form(this.User_box.Text);
                    mf.Show();
                    this.Hide();
                    x = 1;
                }
            }
            if (x == 0)
            {
                MessageBox.Show("Username or Password not correct");
            }


            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
