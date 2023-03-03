namespace School_System
{
    partial class Attendances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendances));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.AttStatusCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.AttDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StIdCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.AttendancesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(461, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Список посещаемости:";
            // 
            // BackBtn
            // 
            this.BackBtn.Animated = true;
            this.BackBtn.AutoRoundedCorners = true;
            this.BackBtn.BorderRadius = 17;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.BackBtn.Location = new System.Drawing.Point(776, 196);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 37);
            this.BackBtn.TabIndex = 42;
            this.BackBtn.Text = "Назад";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Animated = true;
            this.DeleteBtn.AutoRoundedCorners = true;
            this.DeleteBtn.BorderRadius = 17;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.DeleteBtn.Location = new System.Drawing.Point(581, 196);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 37);
            this.DeleteBtn.TabIndex = 41;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Animated = true;
            this.EditBtn.AutoRoundedCorners = true;
            this.EditBtn.BorderRadius = 17;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.EditBtn.Location = new System.Drawing.Point(376, 196);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(135, 37);
            this.EditBtn.TabIndex = 40;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Animated = true;
            this.AddBtn.AutoRoundedCorners = true;
            this.AddBtn.BorderRadius = 17;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddBtn.Location = new System.Drawing.Point(184, 196);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 37);
            this.AddBtn.TabIndex = 39;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(797, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Статус:";
            // 
            // AttStatusCb
            // 
            this.AttStatusCb.BackColor = System.Drawing.Color.Transparent;
            this.AttStatusCb.BorderRadius = 12;
            this.AttStatusCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AttStatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttStatusCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AttStatusCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AttStatusCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AttStatusCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.AttStatusCb.ItemHeight = 30;
            this.AttStatusCb.Items.AddRange(new object[] {
            "Присутствующий ",
            "Отсутствующий ",
            "По справке"});
            this.AttStatusCb.Location = new System.Drawing.Point(801, 119);
            this.AttStatusCb.Name = "AttStatusCb";
            this.AttStatusCb.Size = new System.Drawing.Size(246, 36);
            this.AttStatusCb.TabIndex = 37;
            // 
            // StNameTb
            // 
            this.StNameTb.Animated = true;
            this.StNameTb.AutoRoundedCorners = true;
            this.StNameTb.BorderRadius = 17;
            this.StNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StNameTb.DefaultText = "";
            this.StNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StNameTb.Enabled = false;
            this.StNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StNameTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StNameTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.StNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StNameTb.Location = new System.Drawing.Point(244, 119);
            this.StNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.PlaceholderText = "";
            this.StNameTb.SelectedText = "";
            this.StNameTb.Size = new System.Drawing.Size(330, 36);
            this.StNameTb.TabIndex = 33;
            // 
            // AttDate
            // 
            this.AttDate.Animated = true;
            this.AttDate.AutoRoundedCorners = true;
            this.AttDate.BorderRadius = 17;
            this.AttDate.Checked = true;
            this.AttDate.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.AttDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AttDate.ForeColor = System.Drawing.SystemColors.Info;
            this.AttDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.AttDate.Location = new System.Drawing.Point(581, 119);
            this.AttDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.AttDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.AttDate.Name = "AttDate";
            this.AttDate.Size = new System.Drawing.Size(200, 36);
            this.AttDate.TabIndex = 32;
            this.AttDate.Value = new System.DateTime(2022, 11, 29, 12, 31, 17, 893);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID Учащегося:";
            // 
            // StIdCb
            // 
            this.StIdCb.BackColor = System.Drawing.Color.Transparent;
            this.StIdCb.BorderRadius = 12;
            this.StIdCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StIdCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StIdCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StIdCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StIdCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.StIdCb.ItemHeight = 30;
            this.StIdCb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.StIdCb.Location = new System.Drawing.Point(58, 119);
            this.StIdCb.Name = "StIdCb";
            this.StIdCb.Size = new System.Drawing.Size(168, 36);
            this.StIdCb.TabIndex = 30;
            this.StIdCb.SelectionChangeCommitted += new System.EventHandler(this.StIdCb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(240, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "ФИО учащегося:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПОСЕЩАЕМОСТЬ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(577, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Дата:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1126, 62);
            this.panel1.TabIndex = 28;
            // 
            // guna2Button5
            // 
            this.guna2Button5.Animated = true;
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.Crimson;
            this.guna2Button5.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(1074, 12);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(40, 40);
            this.guna2Button5.TabIndex = 17;
            this.guna2Button5.Text = "X";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // AttendancesDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttendancesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttendancesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttendancesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttendancesDGV.ColumnHeadersHeight = 4;
            this.AttendancesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttendancesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AttendancesDGV.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.AttendancesDGV.Location = new System.Drawing.Point(58, 286);
            this.AttendancesDGV.Name = "AttendancesDGV";
            this.AttendancesDGV.RowHeadersVisible = false;
            this.AttendancesDGV.Size = new System.Drawing.Size(989, 382);
            this.AttendancesDGV.TabIndex = 45;
            this.AttendancesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendancesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AttendancesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AttendancesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AttendancesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AttendancesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AttendancesDGV.ThemeStyle.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.AttendancesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AttendancesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.AttendancesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttendancesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttendancesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AttendancesDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.AttendancesDGV.ThemeStyle.ReadOnly = false;
            this.AttendancesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttendancesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttendancesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttendancesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendancesDGV.ThemeStyle.RowsStyle.Height = 22;
            this.AttendancesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AttendancesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AttendancesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendancesDGV_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1046, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // Attendances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 680);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AttendancesDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AttStatusCb);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.AttDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Attendances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendances";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox AttStatusCb;
        private Guna.UI2.WinForms.Guna2TextBox StNameTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker AttDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox StIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2DataGridView AttendancesDGV;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}