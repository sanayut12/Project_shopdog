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
using System.Threading;

namespace ShopdogV1
{
    public partial class Edit_pass_form : Form
    {
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public Edit_pass_form(string user)
        {
            InitializeComponent();
            textBox2.Tag = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox3.Text)
            {
                MessageBox.Show("Password not match");
            }
            else if (check_pass())
            {
                update_profile();
            }
            else
            {
                MessageBox.Show("Password not corect");
            }
        }
        private void update_profile()
        {
            connection.Open();
            //"UPDATE table_name SET column1 = value1, column2 = value2, ...WHERE condition; ";
            MySqlCommand command;
            String SelectQuery = "UPDATE users SET Password = @Password WHERE UserName = '" + textBox2.Tag + "'";
            command = new MySqlCommand(SelectQuery, connection);

            command.Parameters.Add("@Password", MySqlDbType.VarChar, 200);

            command.Parameters["@Password"].Value = textBox1.Text;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data inserted");
            }

            connection.Close();
        }
        private Boolean check_pass()
        {
            connection.Open();
            MySqlCommand command;
            String SelectQuery = "SELECT Password FROM users WHERE UserName ='" + textBox2.Tag + "'";
            command = new MySqlCommand(SelectQuery, connection);
            MySqlDataReader myReader = command.ExecuteReader();

            Boolean result = false;
            while (myReader.Read())
            {
                if (myReader.GetString("Password") == textBox2.Text)
                {
                    result = true;
                }
            }
            connection.Close();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_pass_form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
