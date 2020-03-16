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
    public partial class sell_dog_Form : Form
    {
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public sell_dog_Form(string user,string sellname,string id)
        {
            InitializeComponent();
            button1.Tag = user;
            profile_dog(id);
            profile_sell_by(sellname);
            pictureBox1.Tag = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            //"UPDATE table_name SET column1 = value1, column2 = value2, ...WHERE condition; ";
            MySqlCommand command;
            String SelectQuery = "UPDATE dog_info SET sell = @selled, Shop_by = @Shop_by ,Date_buy = @Date_buy WHERE id = '" + pictureBox1.Tag + "'";
            command = new MySqlCommand(SelectQuery, connection);

            command.Parameters.Add("@selled", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Shop_by", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Date_buy", MySqlDbType.VarChar, 200);

            command.Parameters["@selled"].Value = "selled";
            command.Parameters["@Shop_by"].Value = button1.Tag;
            command.Parameters["@Date_buy"].Value = date1.Value;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Selled");
            }

            connection.Close();
            this.Close();
        }

        private void profile_sell_by(string dataa)
        {
            connection.Open();
            MySqlCommand command;

            sell_by_label.Text = dataa;
            //Picture_profilr
            String SelectQuery = "SELECT Phone,Facebook,Line,image FROM users WHERE UserName = '" + dataa + "'";
            command = new MySqlCommand(SelectQuery, connection);
            byte[] img;
            MemoryStream ms;

            MySqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                img = (byte[])(myReader["image"]);
                ms = new MemoryStream(img);
                sell_by_pic.Image = Image.FromStream(ms);

                label20.Text = myReader.GetString("Phone");
                label21.Text = myReader.GetString("Facebook");
                label22.Text = myReader.GetString("Line");
            }
            connection.Close();
            //end Pic_profile
        }
        private void profile_dog(string id)
        {
            connection.Open();
            MySqlCommand command;

            //Picture_profilr
            String SelectQuery = "SELECT Type,Cost,Sex,Birthday,Detail,image,image1,image2,image3 FROM dog_info WHERE id = '" + id + "'";
            command = new MySqlCommand(SelectQuery, connection);
            byte[] img;
            MemoryStream ms;

            MySqlDataReader myReader = command.ExecuteReader();


            while (myReader.Read())
            {
                img = (byte[])(myReader["image"]);
                ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox2.Image = Image.FromStream(ms);

                img = (byte[])(myReader["image1"]);
                ms = new MemoryStream(img);
                pictureBox3.Image = Image.FromStream(ms);

                img = (byte[])(myReader["image2"]);
                ms = new MemoryStream(img);
                pictureBox4.Image = Image.FromStream(ms);

                img = (byte[])(myReader["image3"]);
                ms = new MemoryStream(img);
                pictureBox5.Image = Image.FromStream(ms);

                label11.Text = myReader.GetString("Type");
                label12.Text = myReader.GetString("Sex");
                label13.Text = myReader.GetString("Birthday");
                label14.Text= myReader.GetString("Detail");
                label15.Text = myReader.GetString("Cost");
                /*add(myReader.GetString("id"), myReader.GetString("UserName"), myReader.GetString("Type"), myReader.GetString("Sex"), myReader.GetString("Birthday"), myReader.GetString("Detail"), myReader.GetString("Cost"), i);
*/
            }
            connection.Close();
            //end Pic_profile
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox4.Image;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox5.Image;
        }

        private void sell_dog_Form_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
