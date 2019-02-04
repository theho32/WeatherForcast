namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.picture_Main = new System.Windows.Forms.PictureBox();
            this.lbl_Temp = new System.Windows.Forms.Label();
            this.pic_1 = new System.Windows.Forms.PictureBox();
            this.lbl_Days = new System.Windows.Forms.Label();
            this.lbl_Conditions = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_windspeed = new System.Windows.Forms.Label();
            this.lbl_Temp2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Temp3 = new System.Windows.Forms.Label();
            this.lbl_windspeed2 = new System.Windows.Forms.Label();
            this.lbl_description2 = new System.Windows.Forms.Label();
            this.lbl_Conditions2 = new System.Windows.Forms.Label();
            this.lbl_Days2 = new System.Windows.Forms.Label();
            this.pic_2 = new System.Windows.Forms.PictureBox();
            this.txt_cityname = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cityName.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_cityName.Location = new System.Drawing.Point(4, 102);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(144, 46);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "Seattle";
            this.lbl_cityName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_country.Location = new System.Drawing.Point(6, 148);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(52, 31);
            this.lbl_country.TabIndex = 1;
            this.lbl_country.Text = "US";
            // 
            // picture_Main
            // 
            this.picture_Main.Image = ((System.Drawing.Image)(resources.GetObject("picture_Main.Image")));
            this.picture_Main.Location = new System.Drawing.Point(12, 224);
            this.picture_Main.Name = "picture_Main";
            this.picture_Main.Size = new System.Drawing.Size(108, 76);
            this.picture_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Main.TabIndex = 2;
            this.picture_Main.TabStop = false;
            this.picture_Main.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_Temp
            // 
            this.lbl_Temp.AutoSize = true;
            this.lbl_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Temp.Location = new System.Drawing.Point(140, 224);
            this.lbl_Temp.Name = "lbl_Temp";
            this.lbl_Temp.Size = new System.Drawing.Size(204, 76);
            this.lbl_Temp.TabIndex = 3;
            this.lbl_Temp.Text = "Temp";
            this.lbl_Temp.Click += new System.EventHandler(this.label3_Click);
            // 
            // pic_1
            // 
            this.pic_1.Image = ((System.Drawing.Image)(resources.GetObject("pic_1.Image")));
            this.pic_1.Location = new System.Drawing.Point(638, 131);
            this.pic_1.Name = "pic_1";
            this.pic_1.Size = new System.Drawing.Size(118, 76);
            this.pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_1.TabIndex = 4;
            this.pic_1.TabStop = false;
            this.pic_1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbl_Days
            // 
            this.lbl_Days.AutoSize = true;
            this.lbl_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Days.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Days.Location = new System.Drawing.Point(762, 131);
            this.lbl_Days.Name = "lbl_Days";
            this.lbl_Days.Size = new System.Drawing.Size(40, 17);
            this.lbl_Days.TabIndex = 5;
            this.lbl_Days.Text = "Days";
            // 
            // lbl_Conditions
            // 
            this.lbl_Conditions.AutoSize = true;
            this.lbl_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conditions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Conditions.Location = new System.Drawing.Point(762, 148);
            this.lbl_Conditions.Name = "lbl_Conditions";
            this.lbl_Conditions.Size = new System.Drawing.Size(74, 17);
            this.lbl_Conditions.TabIndex = 6;
            this.lbl_Conditions.Text = "Conditions";
            this.lbl_Conditions.Click += new System.EventHandler(this.lbl_Conditions_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_description.Location = new System.Drawing.Point(762, 165);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(79, 17);
            this.lbl_description.TabIndex = 7;
            this.lbl_description.Text = "Description";
            this.lbl_description.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbl_windspeed
            // 
            this.lbl_windspeed.AutoSize = true;
            this.lbl_windspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windspeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_windspeed.Location = new System.Drawing.Point(883, 131);
            this.lbl_windspeed.Name = "lbl_windspeed";
            this.lbl_windspeed.Size = new System.Drawing.Size(85, 17);
            this.lbl_windspeed.TabIndex = 8;
            this.lbl_windspeed.Text = "Wind Speed";
            this.lbl_windspeed.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Temp2
            // 
            this.lbl_Temp2.AutoSize = true;
            this.lbl_Temp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Temp2.Location = new System.Drawing.Point(883, 148);
            this.lbl_Temp2.Name = "lbl_Temp2";
            this.lbl_Temp2.Size = new System.Drawing.Size(44, 17);
            this.lbl_Temp2.TabIndex = 9;
            this.lbl_Temp2.Text = "Temp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(630, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forcast";
            // 
            // lbl_Temp3
            // 
            this.lbl_Temp3.AutoSize = true;
            this.lbl_Temp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Temp3.Location = new System.Drawing.Point(883, 241);
            this.lbl_Temp3.Name = "lbl_Temp3";
            this.lbl_Temp3.Size = new System.Drawing.Size(44, 17);
            this.lbl_Temp3.TabIndex = 16;
            this.lbl_Temp3.Text = "Temp";
            // 
            // lbl_windspeed2
            // 
            this.lbl_windspeed2.AutoSize = true;
            this.lbl_windspeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_windspeed2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_windspeed2.Location = new System.Drawing.Point(883, 224);
            this.lbl_windspeed2.Name = "lbl_windspeed2";
            this.lbl_windspeed2.Size = new System.Drawing.Size(85, 17);
            this.lbl_windspeed2.TabIndex = 15;
            this.lbl_windspeed2.Text = "Wind Speed";
            // 
            // lbl_description2
            // 
            this.lbl_description2.AutoSize = true;
            this.lbl_description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_description2.Location = new System.Drawing.Point(762, 258);
            this.lbl_description2.Name = "lbl_description2";
            this.lbl_description2.Size = new System.Drawing.Size(79, 17);
            this.lbl_description2.TabIndex = 14;
            this.lbl_description2.Text = "Description";
            // 
            // lbl_Conditions2
            // 
            this.lbl_Conditions2.AutoSize = true;
            this.lbl_Conditions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conditions2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Conditions2.Location = new System.Drawing.Point(762, 241);
            this.lbl_Conditions2.Name = "lbl_Conditions2";
            this.lbl_Conditions2.Size = new System.Drawing.Size(74, 17);
            this.lbl_Conditions2.TabIndex = 13;
            this.lbl_Conditions2.Text = "Conditions";
            this.lbl_Conditions2.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lbl_Days2
            // 
            this.lbl_Days2.AutoSize = true;
            this.lbl_Days2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Days2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Days2.Location = new System.Drawing.Point(762, 224);
            this.lbl_Days2.Name = "lbl_Days2";
            this.lbl_Days2.Size = new System.Drawing.Size(40, 17);
            this.lbl_Days2.TabIndex = 12;
            this.lbl_Days2.Text = "Days";
            // 
            // pic_2
            // 
            this.pic_2.Image = ((System.Drawing.Image)(resources.GetObject("pic_2.Image")));
            this.pic_2.Location = new System.Drawing.Point(638, 224);
            this.pic_2.Name = "pic_2";
            this.pic_2.Size = new System.Drawing.Size(118, 76);
            this.pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_2.TabIndex = 11;
            this.pic_2.TabStop = false;
            // 
            // txt_cityname
            // 
            this.txt_cityname.Location = new System.Drawing.Point(27, 46);
            this.txt_cityname.Name = "txt_cityname";
            this.txt_cityname.Size = new System.Drawing.Size(142, 20);
            this.txt_cityname.TabIndex = 17;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(204, 33);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 33);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1040, 618);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_cityname);
            this.Controls.Add(this.lbl_Temp3);
            this.Controls.Add(this.lbl_windspeed2);
            this.Controls.Add(this.lbl_description2);
            this.Controls.Add(this.lbl_Conditions2);
            this.Controls.Add(this.lbl_Days2);
            this.Controls.Add(this.pic_2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Temp2);
            this.Controls.Add(this.lbl_windspeed);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_Conditions);
            this.Controls.Add(this.lbl_Days);
            this.Controls.Add(this.pic_1);
            this.Controls.Add(this.lbl_Temp);
            this.Controls.Add(this.picture_Main);
            this.Controls.Add(this.lbl_country);
            this.Controls.Add(this.lbl_cityName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.PictureBox picture_Main;
        private System.Windows.Forms.Label lbl_Temp;
        private System.Windows.Forms.PictureBox pic_1;
        private System.Windows.Forms.Label lbl_Days;
        private System.Windows.Forms.Label lbl_Conditions;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_windspeed;
        private System.Windows.Forms.Label lbl_Temp2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Temp3;
        private System.Windows.Forms.Label lbl_windspeed2;
        private System.Windows.Forms.Label lbl_description2;
        private System.Windows.Forms.Label lbl_Conditions2;
        private System.Windows.Forms.Label lbl_Days2;
        private System.Windows.Forms.PictureBox pic_2;
        private System.Windows.Forms.TextBox txt_cityname;
        private System.Windows.Forms.Button btn_Search;
    }
}

