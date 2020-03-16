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
    public partial class Histrory_buy_form : Form
    {
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public Histrory_buy_form(string user)
        {
            InitializeComponent();
            panel1.Tag = user;
            data_into_listview();

        }
        private void data_into_listview()
        {
            MySqlCommand command;
            connection.Open();

            listView_dog.View = View.Details;

            listView_dog.Columns.Add("Photo", 150);
            listView_dog.Columns.Add("Types", 150);
            listView_dog.Columns.Add("Sex", 100);
            listView_dog.Columns.Add("Birthday", 150);
            listView_dog.Columns.Add("Detail", 300);
            listView_dog.Columns.Add("Cost", 80);
            listView_dog.Columns.Add("", 80);
            listView_dog.Columns.Add("Date Buy", 80);

            //set scale
            ImageList img_scale = new ImageList();
            img_scale.ImageSize = new Size(150, 150);

            //image to view1
            String SelectQuery = "SELECT * FROM dog_info WHERE Shop_by ='" + panel1.Tag + "'AND Sell= 'selled' ORDER BY id DESC";
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

                add(myReader.GetString("id"), myReader.GetString("Type"), myReader.GetString("Sex"), myReader.GetString("Birthday"), myReader.GetString("Detail"), myReader.GetString("Cost"), myReader.GetString("Date_buy"), i);

                i = i + 1;

            }

            listView_dog.SmallImageList = img_scale;
            connection.Close();

        }
        private void add(string Photo, string Types, string Sex, string Birthday, string Detail, string Cost, string date, int i)
        {
            string[] item = { Photo, Types, Sex, Birthday, Detail, Cost, date };
            ListViewItem items = new ListViewItem(item, i);
            listView_dog.Items.Add(items);
        }

    }
}
