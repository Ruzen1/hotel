namespace hotel
{
    partial class browser
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapBtn = new System.Windows.Forms.Button();
            this.tabelogBtn = new System.Windows.Forms.Button();
            this.takyubinBtn = new System.Windows.Forms.Button();
            this.weatherBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.trainStateBtn = new System.Windows.Forms.Button();
            this.goBTn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.temairazuBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.googleBtn = new System.Windows.Forms.Button();
            this.goForwardBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(301, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 568);
            this.panel1.TabIndex = 0;
            // 
            // mapBtn
            // 
            this.mapBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.mapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mapBtn.Location = new System.Drawing.Point(44, 163);
            this.mapBtn.Name = "mapBtn";
            this.mapBtn.Size = new System.Drawing.Size(223, 60);
            this.mapBtn.TabIndex = 1;
            this.mapBtn.Text = "マップ";
            this.mapBtn.UseVisualStyleBackColor = false;
            this.mapBtn.Click += new System.EventHandler(this.mapBtn_Click);
            // 
            // tabelogBtn
            // 
            this.tabelogBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.tabelogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabelogBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabelogBtn.Location = new System.Drawing.Point(44, 325);
            this.tabelogBtn.Name = "tabelogBtn";
            this.tabelogBtn.Size = new System.Drawing.Size(223, 60);
            this.tabelogBtn.TabIndex = 2;
            this.tabelogBtn.Text = "食べログ";
            this.tabelogBtn.UseVisualStyleBackColor = false;
            this.tabelogBtn.Click += new System.EventHandler(this.tabelogBtn_Click);
            // 
            // takyubinBtn
            // 
            this.takyubinBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.takyubinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.takyubinBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.takyubinBtn.Location = new System.Drawing.Point(44, 402);
            this.takyubinBtn.Name = "takyubinBtn";
            this.takyubinBtn.Size = new System.Drawing.Size(223, 75);
            this.takyubinBtn.TabIndex = 3;
            this.takyubinBtn.Text = "宅急便運賃";
            this.takyubinBtn.UseVisualStyleBackColor = false;
            this.takyubinBtn.Click += new System.EventHandler(this.takyubinBtn_Click);
            // 
            // weatherBtn
            // 
            this.weatherBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.weatherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.weatherBtn.Location = new System.Drawing.Point(44, 492);
            this.weatherBtn.Name = "weatherBtn";
            this.weatherBtn.Size = new System.Drawing.Size(223, 60);
            this.weatherBtn.TabIndex = 4;
            this.weatherBtn.Text = "天気";
            this.weatherBtn.UseVisualStyleBackColor = false;
            this.weatherBtn.Click += new System.EventHandler(this.weather_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(572, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(538, 37);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "www.google.com";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // trainStateBtn
            // 
            this.trainStateBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.trainStateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainStateBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.trainStateBtn.Location = new System.Drawing.Point(44, 567);
            this.trainStateBtn.Name = "trainStateBtn";
            this.trainStateBtn.Size = new System.Drawing.Size(223, 60);
            this.trainStateBtn.TabIndex = 6;
            this.trainStateBtn.Text = "電車状況";
            this.trainStateBtn.UseVisualStyleBackColor = false;
            this.trainStateBtn.Click += new System.EventHandler(this.trainStateBtn_Click);
            // 
            // goBTn
            // 
            this.goBTn.BackColor = System.Drawing.Color.GhostWhite;
            this.goBTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBTn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBTn.Location = new System.Drawing.Point(1129, 13);
            this.goBTn.Name = "goBTn";
            this.goBTn.Size = new System.Drawing.Size(80, 37);
            this.goBTn.TabIndex = 7;
            this.goBTn.Text = "GO";
            this.goBTn.UseVisualStyleBackColor = false;
            this.goBTn.Click += new System.EventHandler(this.goBTn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "楽天",
            "じゃらん",
            "Expedia",
            "一休",
            "Agoda",
            "Ctrip",
            "自社"});
            this.comboBox1.Location = new System.Drawing.Point(370, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 37);
            this.comboBox1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.comboBox1, "管理画面一覧");
            // 
            // temairazuBtn
            // 
            this.temairazuBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.temairazuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temairazuBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.temairazuBtn.Location = new System.Drawing.Point(44, 248);
            this.temairazuBtn.Name = "temairazuBtn";
            this.temairazuBtn.Size = new System.Drawing.Size(223, 60);
            this.temairazuBtn.TabIndex = 9;
            this.temairazuBtn.Text = "手間いらず";
            this.temairazuBtn.UseVisualStyleBackColor = false;
            this.temairazuBtn.Click += new System.EventHandler(this.temairazuBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(552, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // googleBtn
            // 
            this.googleBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.googleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.googleBtn.Font = new System.Drawing.Font("MS PMincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.googleBtn.Location = new System.Drawing.Point(44, 82);
            this.googleBtn.Name = "googleBtn";
            this.googleBtn.Size = new System.Drawing.Size(223, 60);
            this.googleBtn.TabIndex = 12;
            this.googleBtn.Text = "Google";
            this.googleBtn.UseVisualStyleBackColor = false;
            this.googleBtn.Click += new System.EventHandler(this.googleBtn_Click);
            // 
            // goForwardBtn
            // 
            this.goForwardBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.goForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goForwardBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goForwardBtn.Image = global::hotel.Properties.Resources.if_circle_arrow_right_173182;
            this.goForwardBtn.Location = new System.Drawing.Point(187, 10);
            this.goForwardBtn.Name = "goForwardBtn";
            this.goForwardBtn.Size = new System.Drawing.Size(80, 37);
            this.goForwardBtn.TabIndex = 13;
            this.goForwardBtn.UseVisualStyleBackColor = false;
            this.goForwardBtn.Click += new System.EventHandler(this.goForwardBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackColor = System.Drawing.Color.GhostWhite;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackBtn.Image = global::hotel.Properties.Resources.if_circle_arrow_left_173181;
            this.goBackBtn.Location = new System.Drawing.Point(44, 10);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(80, 37);
            this.goBackBtn.TabIndex = 14;
            this.goBackBtn.UseVisualStyleBackColor = false;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1350, 639);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.goForwardBtn);
            this.Controls.Add(this.googleBtn);
            this.Controls.Add(this.goBTn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.temairazuBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trainStateBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.weatherBtn);
            this.Controls.Add(this.takyubinBtn);
            this.Controls.Add(this.tabelogBtn);
            this.Controls.Add(this.mapBtn);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "browser";
            this.Text = "browser";
            this.Load += new System.EventHandler(this.browser_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.browser_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button mapBtn;
        private System.Windows.Forms.Button tabelogBtn;
        private System.Windows.Forms.Button takyubinBtn;
        private System.Windows.Forms.Button weatherBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button trainStateBtn;
        private System.Windows.Forms.Button goBTn;
        private System.Windows.Forms.Button temairazuBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button googleBtn;
        private System.Windows.Forms.Button goForwardBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}