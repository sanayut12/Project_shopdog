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
    public partial class Home_form : Form
    {
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public Home_form(string user)
        {
            InitializeComponent();
            listView_dog.Tag = user;
            addColum();
        }

        private void Home_form_Load(object sender, EventArgs e)
        {
            data_into_listview();
        }

        private void listView_dog_Click(object sender, EventArgs e)
        {
            string id = listView_dog.SelectedItems[0].SubItems[0].Text;
            string sellname = listView_dog.SelectedItems[0].SubItems[1].Text;

            sell_dog_Form sdf = new sell_dog_Form(listView_dog.Tag.ToString(), sellname,id);

            sdf.Show();

            /*            MessageBox.Show(selected);
                        MessageBox.Show(selected1);*/
            /*            Buy_sell_form bf = new Buy_sell_form(shopdog_user.Text, selected1, selected);
                        bf.Show();*/
        }
        private void add(string Photo, string Sellby, string Types, string Sex, string Birthday, string Detail, string Cost, int i)
        {
            string[] item = { Photo, Sellby, Types, Sex, Birthday, Detail, Cost };
            ListViewItem items = new ListViewItem(item, i);
            listView_dog.Items.Add(items);
        }
        private void addColum()
        {
            listView_dog.View = View.Details;
            listView_dog.Columns.Add("Photo", 100);
            listView_dog.Columns.Add("Sell by", 100);
            listView_dog.Columns.Add("Types", 100);
            listView_dog.Columns.Add("Sex", 100);
            listView_dog.Columns.Add("Birthday", 100);
            listView_dog.Columns.Add("Detail", 380);
            listView_dog.Columns.Add("Cost", 100);
        }
        private void data_into_listview()
        {
            MySqlCommand command;
            connection.Open();



            //set scale
            ImageList img_scale = new ImageList();
            img_scale.ImageSize = new Size(100, 100);
            //image to view1
            String SelectQuery = "SELECT * FROM dog_info WHERE UserName !='"+listView_dog.Tag+"'AND Sell != 'selled'  ORDER BY id DESC";
            command = new MySqlCommand(SelectQuery, connection);
            byte[] img;
            MemoryStream ms;            
            MySqlDataReader myReader = command.ExecuteReader();
            //input image
            int i = 0;
            while (myReader.Read())
            {
                img = (byte[])(myReader["image"]);
                ms = new MemoryStream(img);
                img_scale.Images.Add(Image.FromStream(ms));
                add(myReader.GetString("id"), myReader.GetString("UserName"), myReader.GetString("Type"), myReader.GetString("Sex"), myReader.GetString("Birthday"), myReader.GetString("Detail"), myReader.GetString("Cost")+"  บาท", i);

                i = i + 1;
            }
            listView_dog.SmallImageList = img_scale;
            connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
