namespace OpenWeatherAPI
{
    partial class FrmWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeather));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.pcboxIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDeg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbllon = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCloud = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblFeels_like = new System.Windows.Forms.Label();
            this.lblMin_temp = new System.Windows.Forms.Label();
            this.lblMax_temp = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(32, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(78, 53);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(109, 20);
            this.txtCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 22);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCondition.Location = new System.Drawing.Point(147, 22);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(47, 23);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sunrise:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sunset:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescription.Location = new System.Drawing.Point(147, 65);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(47, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "N/A";
            this.lblDescription.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lblSunrise.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSunrise.Location = new System.Drawing.Point(114, 105);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(47, 23);
            this.lblSunrise.TabIndex = 7;
            this.lblSunrise.Text = "N/A";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.BackColor = System.Drawing.Color.Transparent;
            this.lblSunset.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSunset.Location = new System.Drawing.Point(109, 150);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(47, 23);
            this.lblSunset.TabIndex = 8;
            this.lblSunset.Text = "N/A";
            // 
            // pcboxIcon
            // 
            this.pcboxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcboxIcon.Location = new System.Drawing.Point(36, 100);
            this.pcboxIcon.Name = "pcboxIcon";
            this.pcboxIcon.Size = new System.Drawing.Size(145, 88);
            this.pcboxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcboxIcon.TabIndex = 9;
            this.pcboxIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Wind speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(211, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pressure: ";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWindSpeed.Location = new System.Drawing.Point(130, 83);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(47, 23);
            this.lblWindSpeed.TabIndex = 12;
            this.lblWindSpeed.Text = "N/A";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.BackColor = System.Drawing.Color.Transparent;
            this.lblPressure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPressure.Location = new System.Drawing.Point(297, 21);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(47, 23);
            this.lblPressure.TabIndex = 13;
            this.lblPressure.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(245, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Degree:";
            // 
            // lblDeg
            // 
            this.lblDeg.AutoSize = true;
            this.lblDeg.BackColor = System.Drawing.Color.Transparent;
            this.lblDeg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeg.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDeg.Location = new System.Drawing.Point(322, 84);
            this.lblDeg.Name = "lblDeg";
            this.lblDeg.Size = new System.Drawing.Size(47, 23);
            this.lblDeg.TabIndex = 15;
            this.lblDeg.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(434, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(520, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 23);
            this.lblFecha.TabIndex = 17;
            // 
            // lbllon
            // 
            this.lbllon.AutoSize = true;
            this.lbllon.BackColor = System.Drawing.Color.Transparent;
            this.lbllon.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllon.ForeColor = System.Drawing.SystemColors.Control;
            this.lbllon.Location = new System.Drawing.Point(127, 44);
            this.lbllon.Name = "lbllon";
            this.lbllon.Size = new System.Drawing.Size(47, 23);
            this.lbllon.TabIndex = 18;
            this.lbllon.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(21, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Longitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(42, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Coords:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(21, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Latitude:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BackColor = System.Drawing.Color.Transparent;
            this.lblLat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLat.Location = new System.Drawing.Point(106, 82);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(47, 23);
            this.lblLat.TabIndex = 22;
            this.lblLat.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(20, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Clouds:";
            // 
            // lblCloud
            // 
            this.lblCloud.AutoSize = true;
            this.lblCloud.BackColor = System.Drawing.Color.Transparent;
            this.lblCloud.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloud.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCloud.Location = new System.Drawing.Point(94, 21);
            this.lblCloud.Name = "lblCloud";
            this.lblCloud.Size = new System.Drawing.Size(47, 23);
            this.lblCloud.TabIndex = 24;
            this.lblCloud.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 26;
            this.label13.Text = "Min Temp:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(17, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 27;
            this.label14.Text = "Humidity:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(5, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "Feels Like:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 23);
            this.label16.TabIndex = 29;
            this.label16.Text = "Max Temp:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHumidity.Location = new System.Drawing.Point(120, 142);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 23);
            this.lblHumidity.TabIndex = 30;
            this.lblHumidity.Text = "N/A";
            // 
            // lblFeels_like
            // 
            this.lblFeels_like.AutoSize = true;
            this.lblFeels_like.BackColor = System.Drawing.Color.Transparent;
            this.lblFeels_like.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeels_like.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFeels_like.Location = new System.Drawing.Point(113, 99);
            this.lblFeels_like.Name = "lblFeels_like";
            this.lblFeels_like.Size = new System.Drawing.Size(47, 23);
            this.lblFeels_like.TabIndex = 31;
            this.lblFeels_like.Text = "N/A";
            // 
            // lblMin_temp
            // 
            this.lblMin_temp.AutoSize = true;
            this.lblMin_temp.BackColor = System.Drawing.Color.Transparent;
            this.lblMin_temp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMin_temp.Location = new System.Drawing.Point(113, 57);
            this.lblMin_temp.Name = "lblMin_temp";
            this.lblMin_temp.Size = new System.Drawing.Size(47, 23);
            this.lblMin_temp.TabIndex = 32;
            this.lblMin_temp.Text = "N/A";
            // 
            // lblMax_temp
            // 
            this.lblMax_temp.AutoSize = true;
            this.lblMax_temp.BackColor = System.Drawing.Color.Transparent;
            this.lblMax_temp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax_temp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMax_temp.Location = new System.Drawing.Point(121, 10);
            this.lblMax_temp.Name = "lblMax_temp";
            this.lblMax_temp.Size = new System.Drawing.Size(47, 23);
            this.lblMax_temp.TabIndex = 33;
            this.lblMax_temp.Text = "N/A";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblTemp.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTemp.Location = new System.Drawing.Point(187, 131);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 44);
            this.lblTemp.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblSunset);
            this.panel1.Controls.Add(this.lblSunrise);
            this.panel1.Controls.Add(this.lblCondition);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(15, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 190);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblCloud);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblDeg);
            this.panel2.Controls.Add(this.lblHumidity);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblPressure);
            this.panel2.Controls.Add(this.lblWindSpeed);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(357, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 176);
            this.panel2.TabIndex = 36;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblMax_temp);
            this.panel3.Controls.Add(this.lblMin_temp);
            this.panel3.Controls.Add(this.lblFeels_like);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(346, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 132);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.lblLat);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.lbllon);
            this.panel4.Location = new System.Drawing.Point(581, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 124);
            this.panel4.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(30, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Condition:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(30, 65);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 23);
            this.label17.TabIndex = 10;
            this.label17.Text = "Description:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(687, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Country:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCountry.Location = new System.Drawing.Point(780, 21);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(47, 23);
            this.lblCountry.TabIndex = 39;
            this.lblCountry.Text = "N/A";
            // 
            // FrmWeather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OpenWeatherAPI.Properties.Resources.photo_1475274047050_1d0c0975c63e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 424);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcboxIcon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWeather";
            this.Text = "Current Weather";
            this.Load += new System.EventHandler(this.FrmWeather_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.PictureBox pcboxIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblDeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lbllon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCloud;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblFeels_like;
        private System.Windows.Forms.Label lblMin_temp;
        private System.Windows.Forms.Label lblMax_temp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblCountry;
    }
}

