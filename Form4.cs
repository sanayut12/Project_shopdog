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
    public partial class Profile_form : Form
    {
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public Profile_form(string user)
        {
            InitializeComponent();
            
            profile(user);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = false;

            textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = true;
            textBox2.Enabled = textBox3.Enabled = textBox4.Enabled = textBox5.Enabled = textBox6.Enabled = textBox7.Enabled = false;
            update_profile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            Edit_pass_form pf = new Edit_pass_form(textBox1.Text);
            pf.Show();
        }
        private void profile(string data)
        {
            connection.Open();
            MySqlCommand command;

            textBox1.Text = data;
            //Picture_profilr
            String SelectQuery = "SELECT Name,Email,Phone,Facebook,Line,Address,image FROM users WHERE UserName = '" + data + "'";
            command = new MySqlCommand(SelectQuery, connection);
            byte[] img;
            MemoryStream ms;

            MySqlDataReader myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                img = (byte[])(myReader["image"]);
                ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);

                textBox2.Text = myReader.GetString("Name");
                textBox3.Text = myReader.GetString("Email");
                textBox4.Text = myReader.GetString("Phone");
                textBox5.Text = myReader.GetString("Facebook");
                textBox6.Text = myReader.GetString("Line");
                textBox7.Text = myReader.GetString("Address");

            }
            connection.Close();
        }
        private void update_profile()
        {
            connection.Open();
            //"UPDATE table_name SET column1 = value1, column2 = value2, ...WHERE condition; ";
            MySqlCommand command;
            String SelectQuery = "UPDATE users SET Name = @Name, Email = @Email , Phone = @Phone,Facebook = @Facebook,Line = @Line ,Address = @Address WHERE UserName = '" + textBox1.Text + "'";
            command = new MySqlCommand(SelectQuery, connection);

            command.Parameters.Add("@Name", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Email", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Phone", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@Facebook", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Line", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Address", MySqlDbType.VarChar, 200);

            command.Parameters["@Name"].Value = textBox2.Text;
            command.Parameters["@Email"].Value = textBox3.Text;
            command.Parameters["@Phone"].Value = textBox4.Text;
            command.Parameters["@Facebook"].Value = textBox5.Text;
            command.Parameters["@Line"].Value = textBox6.Text;
            command.Parameters["@Address"].Value = textBox7.Text;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successed");
            }

            connection.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
