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
    public partial class Register_form : Form
    {
        //connect database
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");
        MySqlCommand command;

        public Register_form()
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

        private void Upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                Image_profile.Image = Image.FromFile(opf.FileName);
            }
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            if (Password_box.Text != Password_box2.Text)
            {
                error_label.Text = "Password not match";
            }
            else if (Password_box.Text == Password_box2.Text)
            {
                error_label.Text = " ";
            }
            else if (Phone_box.Text.Length != 10)
            {
                error_phone.Text = "phone not correct";
            }
            else if (Phone_box.Text.Length == 10)
            {
                error_phone.Text = " ";
            }

            if (Password_box.Text == Password_box2.Text && Phone_box.Text.Length == 10) //insert to database
            {
                insert_register_to_database();
            }
           
        }
        private void insert_register_to_database()
        {
            MemoryStream ms = new MemoryStream();

            Image_profile.Image.Save(ms, Image_profile.Image.RawFormat);
            byte[] img = ms.ToArray();

            string insertQuery = "INSERT INTO users(UserName,Password,Name,Email,Phone,Facebook,Line,Address,image) VALUE(@UserName,@Password,@Name,@Email,@Phone,@Facebook,@Line,@Address,@image)";

            connection.Open();

            command = new MySqlCommand(insertQuery, connection);

            command.Parameters.Add("@UserName", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Password", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Name", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Email", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Phone", MySqlDbType.VarChar, 10);
            command.Parameters.Add("@Facebook", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Line", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Address", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@image", MySqlDbType.LongBlob);

            command.Parameters["@UserName"].Value = UserName_box.Text;
            command.Parameters["@Password"].Value = Password_box.Text;
            command.Parameters["@Name"].Value = Name_box.Text;
            command.Parameters["@Email"].Value = Email_box.Text;
            command.Parameters["@Phone"].Value = Phone_box.Text;
            command.Parameters["@Facebook"].Value = Facebook_box.Text;
            command.Parameters["@Line"].Value = Line_box.Text;
            command.Parameters["@Address"].Value = Address_box.Text;
            command.Parameters["@image"].Value = img;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Succesed");
            }

            connection.Close();

            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
