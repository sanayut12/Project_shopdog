namespace ShopdogV1
{
    partial class Push_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Push_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.detail_box = new System.Windows.Forms.TextBox();
            this.image_dog = new System.Windows.Forms.Button();
            this.picture_dog = new System.Windows.Forms.PictureBox();
            this.sex_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthday_box = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.type_box = new System.Windows.Forms.ComboBox();
            this.cost_box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.image_dog3 = new System.Windows.Forms.Button();
            this.picture_dog3 = new System.Windows.Forms.PictureBox();
            this.image_dog1 = new System.Windows.Forms.Button();
            this.picture_dog1 = new System.Windows.Forms.PictureBox();
            this.image_dog2 = new System.Windows.Forms.Button();
            this.picture_dog2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.detail_box);
            this.panel1.Controls.Add(this.image_dog);
            this.panel1.Controls.Add(this.picture_dog);
            this.panel1.Controls.Add(this.sex_box);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.birthday_box);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.type_box);
            this.panel1.Controls.Add(this.cost_box);
            this.panel1.Location = new System.Drawing.Point(50, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(370, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register Dog";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detail_box
            // 
            this.detail_box.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_box.Location = new System.Drawing.Point(213, 305);
            this.detail_box.Multiline = true;
            this.detail_box.Name = "detail_box";
            this.detail_box.Size = new System.Drawing.Size(515, 120);
            this.detail_box.TabIndex = 42;
            // 
            // image_dog
            // 
            this.image_dog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.image_dog.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_dog.Location = new System.Drawing.Point(679, 57);
            this.image_dog.Name = "image_dog";
            this.image_dog.Size = new System.Drawing.Size(114, 34);
            this.image_dog.TabIndex = 41;
            this.image_dog.Text = "image";
            this.image_dog.UseVisualStyleBackColor = false;
            this.image_dog.Click += new System.EventHandler(this.image_dog_Click);
            // 
            // picture_dog
            // 
            this.picture_dog.BackColor = System.Drawing.Color.Silver;
            this.picture_dog.Location = new System.Drawing.Point(462, 57);
            this.picture_dog.Name = "picture_dog";
            this.picture_dog.Size = new System.Drawing.Size(211, 136);
            this.picture_dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dog.TabIndex = 40;
            this.picture_dog.TabStop = false;
            // 
            // sex_box
            // 
            this.sex_box.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_box.FormattingEnabled = true;
            this.sex_box.Items.AddRange(new object[] {
            "เพศผู้",
            "เพศเมีย"});
            this.sex_box.Location = new System.Drawing.Point(213, 185);
            this.sex_box.Name = "sex_box";
            this.sex_box.Size = new System.Drawing.Size(221, 27);
            this.sex_box.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(112, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "details :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(99, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "birthday :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // birthday_box
            // 
            this.birthday_box.CausesValidation = false;
            this.birthday_box.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_box.Location = new System.Drawing.Point(213, 241);
            this.birthday_box.Name = "birthday_box";
            this.birthday_box.Size = new System.Drawing.Size(323, 26);
            this.birthday_box.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(114, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(135, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "strain :";
            // 
            // type_box
            // 
            this.type_box.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_box.FormattingEnabled = true;
            this.type_box.Items.AddRange(new object[] {
            "Golden Retriever",
            "Labrador Retriever",
            "Pug",
            "Chihuahua",
            "Dalmatian",
            "Poodle",
            "Pit Bull",
            "Siberian Husky",
            "German Shepherd",
            "Pembroke Welsh Corgi",
            "Great Dane",
            "Dachshund",
            "English Bulldog",
            "Rough Collie",
            "Saint Bernard",
            "Australian Shepherd",
            "Shih Tzu",
            "Border Collie",
            "Boxer",
            "Cavalier King Charles Spaniel",
            "Chow Chow",
            "Greyhound",
            "Cairn Terrier",
            "Basset Hound",
            "Beagle",
            "Cocker Spaniel",
            "Chinese Shar-Pei",
            "Jack Russell Terrier",
            "French Bulldog",
            "Pomeranian"});
            this.type_box.Location = new System.Drawing.Point(213, 57);
            this.type_box.Name = "type_box";
            this.type_box.Size = new System.Drawing.Size(221, 27);
            this.type_box.TabIndex = 32;
            // 
            // cost_box
            // 
            this.cost_box.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_box.Location = new System.Drawing.Point(213, 121);
            this.cost_box.Name = "cost_box";
            this.cost_box.Size = new System.Drawing.Size(221, 26);
            this.cost_box.TabIndex = 31;
            this.cost_box.Tag = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.image_dog3);
            this.panel2.Controls.Add(this.picture_dog3);
            this.panel2.Controls.Add(this.image_dog1);
            this.panel2.Controls.Add(this.picture_dog1);
            this.panel2.Controls.Add(this.image_dog2);
            this.panel2.Controls.Add(this.picture_dog2);
            this.panel2.Location = new System.Drawing.Point(850, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 600);
            this.panel2.TabIndex = 1;
            // 
            // image_dog3
            // 
            this.image_dog3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.image_dog3.Location = new System.Drawing.Point(223, 372);
            this.image_dog3.Name = "image_dog3";
            this.image_dog3.Size = new System.Drawing.Size(114, 34);
            this.image_dog3.TabIndex = 32;
            this.image_dog3.Text = "image3";
            this.image_dog3.UseVisualStyleBackColor = false;
            this.image_dog3.Click += new System.EventHandler(this.image_dog3_Click);
            // 
            // picture_dog3
            // 
            this.picture_dog3.BackColor = System.Drawing.Color.Silver;
            this.picture_dog3.Location = new System.Drawing.Point(6, 372);
            this.picture_dog3.Name = "picture_dog3";
            this.picture_dog3.Size = new System.Drawing.Size(211, 136);
            this.picture_dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dog3.TabIndex = 31;
            this.picture_dog3.TabStop = false;
            // 
            // image_dog1
            // 
            this.image_dog1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.image_dog1.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_dog1.Location = new System.Drawing.Point(223, 60);
            this.image_dog1.Name = "image_dog1";
            this.image_dog1.Size = new System.Drawing.Size(114, 34);
            this.image_dog1.TabIndex = 30;
            this.image_dog1.Text = "image1";
            this.image_dog1.UseVisualStyleBackColor = false;
            this.image_dog1.Click += new System.EventHandler(this.image_dog1_Click);
            // 
            // picture_dog1
            // 
            this.picture_dog1.BackColor = System.Drawing.Color.Silver;
            this.picture_dog1.Location = new System.Drawing.Point(6, 60);
            this.picture_dog1.Name = "picture_dog1";
            this.picture_dog1.Size = new System.Drawing.Size(211, 136);
            this.picture_dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dog1.TabIndex = 29;
            this.picture_dog1.TabStop = false;
            // 
            // image_dog2
            // 
            this.image_dog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.image_dog2.Font = new System.Drawing.Font("Copperplate Gothic Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.image_dog2.Location = new System.Drawing.Point(223, 217);
            this.image_dog2.Name = "image_dog2";
            this.image_dog2.Size = new System.Drawing.Size(114, 34);
            this.image_dog2.TabIndex = 28;
            this.image_dog2.Text = "image2";
            this.image_dog2.UseVisualStyleBackColor = false;
            this.image_dog2.Click += new System.EventHandler(this.image_dog2_Click);
            // 
            // picture_dog2
            // 
            this.picture_dog2.BackColor = System.Drawing.Color.Silver;
            this.picture_dog2.Location = new System.Drawing.Point(6, 217);
            this.picture_dog2.Name = "picture_dog2";
            this.picture_dog2.Size = new System.Drawing.Size(211, 136);
            this.picture_dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_dog2.TabIndex = 27;
            this.picture_dog2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 84);
            this.label6.TabIndex = 2;
            this.label6.Text = "Sale";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Push_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 913);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Push_form";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox detail_box;
        private System.Windows.Forms.Button image_dog;
        private System.Windows.Forms.PictureBox picture_dog;
        private System.Windows.Forms.ComboBox sex_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthday_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_box;
        private System.Windows.Forms.TextBox cost_box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button image_dog3;
        private System.Windows.Forms.PictureBox picture_dog3;
        private System.Windows.Forms.Button image_dog1;
        private System.Windows.Forms.PictureBox picture_dog1;
        private System.Windows.Forms.Button image_dog2;
        private System.Windows.Forms.PictureBox picture_dog2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}