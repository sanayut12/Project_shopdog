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
    public partial class Push_form : Form
    {
        // connect Database
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");
        MySqlCommand command;

        public Push_form(string user)
        {
            InitializeComponent();
            panel1.Tag = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get id from dog_info
            int id = 1;

            string sql2 = "SELECT id FROM dog_info";
            MySqlConnection con2 = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();

            MySqlDataReader reader2 = cmd2.ExecuteReader();


            int[] a = new int[1000000];
            int x = 0;


            while (reader2.Read())
            {
                a[x] = int.Parse(reader2.GetString("id"));
                x = x + 1;

            }
            int z = a.Max();

            id = id + z;
            //end get id from dog_info


            //pic dog
            MemoryStream ms = new MemoryStream();
            picture_dog.Image.Save(ms, picture_dog.Image.RawFormat);
            byte[] img = ms.ToArray();
            //pic dog1
            MemoryStream ms1 = new MemoryStream();
            picture_dog1.Image.Save(ms1, picture_dog1.Image.RawFormat);
            byte[] img1 = ms1.ToArray();
            //pic dog2
            MemoryStream ms2 = new MemoryStream();
            picture_dog2.Image.Save(ms2, picture_dog2.Image.RawFormat);
            byte[] img2 = ms2.ToArray();
            //pic dog3
            MemoryStream ms3 = new MemoryStream();
            picture_dog3.Image.Save(ms3, picture_dog3.Image.RawFormat);
            byte[] img3 = ms3.ToArray();

            string insertQuery = "INSERT INTO dog_info(id,UserName,Type,Cost,Sex,Birthday,Detail,image,image1,image2,image3,sell) VALUE(@ids,@UserName,@Type,@Cost,@Sex,@Birthday,@Detail,@image,@image1,@image2,@image3,@sell)";
            connection.Open();
            command = new MySqlCommand(insertQuery, connection);


            //(@UserName, , , , , , , , , )
            command.Parameters.Add("@ids", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@UserName", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Type", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Cost", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Sex", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Birthday", MySqlDbType.VarChar, 200);
            command.Parameters.Add("@Detail", MySqlDbType.VarChar, 1000);
            command.Parameters.Add("@image", MySqlDbType.LongBlob);
            command.Parameters.Add("@image1", MySqlDbType.LongBlob);
            command.Parameters.Add("@image2", MySqlDbType.LongBlob);
            command.Parameters.Add("@image3", MySqlDbType.LongBlob);
            command.Parameters.Add("@sell", MySqlDbType.VarChar, 200);


            command.Parameters["@ids"].Value = id.ToString();
            command.Parameters["@UserName"].Value = panel1.Tag;
            command.Parameters["@Type"].Value = type_box.Text;
            command.Parameters["@Cost"].Value = cost_box.Text;
            command.Parameters["@Sex"].Value = sex_box.Text;
            command.Parameters["@Birthday"].Value = birthday_box.Value.ToString("dd-mm-yyyy");
            command.Parameters["@Detail"].Value = detail_box.Text;
            command.Parameters["@image"].Value = img;
            command.Parameters["@image1"].Value = img1;
            command.Parameters["@image2"].Value = img2;
            command.Parameters["@image3"].Value = img3;
            command.Parameters["@sell"].Value = "sell";


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Successed");
            }

            connection.Close();

            this.Refresh();
            this.Close();
        }

        private void image_dog_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_dog.Image = Image.FromFile(opf.FileName);
            }
        }

        private void image_dog1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_dog1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void image_dog2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_dog2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void image_dog3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_dog3.Image = Image.FromFile(opf.FileName);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

