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
    public partial class Main_form : Form
    {
        //http://192.168.137.10/
        // connect Database 
        MySqlConnection connection = new MySqlConnection("host=192.168.137.10;user=shopdog;password=zJzauavfbROjNVKd;database=shopdog");

        public Main_form(string user)
        {
            InitializeComponent();
            user_name_label.Text = user;
            profile(user);
            home_start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
                
        private void home_start()
        {
            //panel clear
            panel_main.Controls.Clear();

            Home_form hf = new Home_form(user_name_label.Text);
            hf.TopLevel = false;
            panel_main.Controls.Add(hf);
            hf.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            Home_form hf = new Home_form(user_name_label.Text);
            hf.TopLevel = false;
            panel_main.Controls.Add(hf);
            hf.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            Profile_form pf = new Profile_form(user_name_label.Text);
            pf.TopLevel = false;
            panel_main.Controls.Add(pf);
            pf.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            selling_form sf = new selling_form(user_name_label.Text);
            sf.TopLevel = false;
            panel_main.Controls.Add(sf);
            sf.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            Push_form pf = new Push_form(user_name_label.Text);
            pf.TopLevel = false;
            panel_main.Controls.Add(pf);
            pf.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            Hestrory_sell_form hsf = new Hestrory_sell_form(user_name_label.Text);
            hsf.TopLevel = false;
            panel_main.Controls.Add(hsf);
            hsf.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //panel clear
            panel_main.Controls.Clear();

            Histrory_buy_form hbf = new Histrory_buy_form(user_name_label.Text);
            hbf.TopLevel = false;
            panel_main.Controls.Add(hbf);
            hbf.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void profile(string data)
        {
            MySqlCommand command;
            MySqlDataAdapter da;

            //Picture_profilr
            String SelectQuery_pro = "SELECT image FROM users WHERE UserName = '" + data + "'";
            command = new MySqlCommand(SelectQuery_pro, connection);
            da = new MySqlDataAdapter(command);
            DataTable table_pro = new DataTable();
            da.Fill(table_pro);

            byte[] img_pro = (byte[])table_pro.Rows[0][0];

            MemoryStream ms_pro = new MemoryStream(img_pro);
            imageUser_pic.Image = Image.FromStream(ms_pro);
            da.Dispose();

            //end Pic_profile
        }
    }
}
