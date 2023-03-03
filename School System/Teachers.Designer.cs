namespace School_System
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SubCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TAddTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TGenCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.TPhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TeachersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(461, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Список учителей:";
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
            this.BackBtn.Location = new System.Drawing.Point(778, 245);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 37);
            this.BackBtn.TabIndex = 39;
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
            this.DeleteBtn.Location = new System.Drawing.Point(583, 245);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 37);
            this.DeleteBtn.TabIndex = 38;
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
            this.EditBtn.Location = new System.Drawing.Point(378, 245);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(135, 37);
            this.EditBtn.TabIndex = 37;
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
            this.AddBtn.Location = new System.Drawing.Point(186, 245);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 37);
            this.AddBtn.TabIndex = 36;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(792, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Предмет:";
            // 
            // SubCb
            // 
            this.SubCb.BackColor = System.Drawing.Color.Transparent;
            this.SubCb.BorderRadius = 12;
            this.SubCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.SubCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.SubCb.ItemHeight = 30;
            this.SubCb.Items.AddRange(new object[] {
            "Математика",
            "Физика",
            "География",
            "Иностранный язык",
            "Русский язык",
            "Искусство",
            "История",
            "Общество",
            "Химия",
            "Биология",
            "Труды ",
            "ОБЖ"});
            this.SubCb.Location = new System.Drawing.Point(796, 108);
            this.SubCb.Name = "SubCb";
            this.SubCb.Size = new System.Drawing.Size(247, 36);
            this.SubCb.TabIndex = 34;
            // 
            // TAddTb
            // 
            this.TAddTb.BorderRadius = 12;
            this.TAddTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TAddTb.DefaultText = "";
            this.TAddTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TAddTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TAddTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TAddTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TAddTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TAddTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TAddTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.TAddTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TAddTb.Location = new System.Drawing.Point(518, 110);
            this.TAddTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TAddTb.Name = "TAddTb";
            this.TAddTb.PasswordChar = '\0';
            this.TAddTb.PlaceholderText = "";
            this.TAddTb.SelectedText = "";
            this.TAddTb.Size = new System.Drawing.Size(271, 114);
            this.TAddTb.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(514, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Адрес:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(301, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Дата рождения:";
            // 
            // TDOB
            // 
            this.TDOB.Animated = true;
            this.TDOB.AutoRoundedCorners = true;
            this.TDOB.BorderRadius = 17;
            this.TDOB.Checked = true;
            this.TDOB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TDOB.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.TDOB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TDOB.ForeColor = System.Drawing.SystemColors.Info;
            this.TDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TDOB.Location = new System.Drawing.Point(295, 188);
            this.TDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(200, 36);
            this.TDOB.TabIndex = 29;
            this.TDOB.Value = new System.DateTime(2022, 11, 29, 12, 31, 17, 893);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(341, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Пол:";
            // 
            // TGenCb
            // 
            this.TGenCb.BackColor = System.Drawing.Color.Transparent;
            this.TGenCb.BorderRadius = 12;
            this.TGenCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TGenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TGenCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TGenCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TGenCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TGenCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.TGenCb.ItemHeight = 30;
            this.TGenCb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.TGenCb.Location = new System.Drawing.Point(345, 109);
            this.TGenCb.Name = "TGenCb";
            this.TGenCb.Size = new System.Drawing.Size(150, 36);
            this.TGenCb.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(90, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "ФИО:";
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
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "УЧИТЕЛЯ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TNameTb
            // 
            this.TNameTb.Animated = true;
            this.TNameTb.AutoRoundedCorners = true;
            this.TNameTb.BorderRadius = 17;
            this.TNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TNameTb.DefaultText = "";
            this.TNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TNameTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TNameTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.TNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TNameTb.Location = new System.Drawing.Point(94, 108);
            this.TNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TNameTb.Name = "TNameTb";
            this.TNameTb.PasswordChar = '\0';
            this.TNameTb.PlaceholderText = "";
            this.TNameTb.SelectedText = "";
            this.TNameTb.Size = new System.Drawing.Size(244, 36);
            this.TNameTb.TabIndex = 30;
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
            this.panel1.TabIndex = 25;
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
            // TPhoneTb
            // 
            this.TPhoneTb.Animated = true;
            this.TPhoneTb.AutoRoundedCorners = true;
            this.TPhoneTb.BorderRadius = 17;
            this.TPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPhoneTb.DefaultText = "";
            this.TPhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TPhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TPhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TPhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TPhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TPhoneTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.TPhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TPhoneTb.Location = new System.Drawing.Point(94, 186);
            this.TPhoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TPhoneTb.Name = "TPhoneTb";
            this.TPhoneTb.PasswordChar = '\0';
            this.TPhoneTb.PlaceholderText = "";
            this.TPhoneTb.SelectedText = "";
            this.TPhoneTb.Size = new System.Drawing.Size(194, 36);
            this.TPhoneTb.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(90, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "Телефон:";
            // 
            // TeachersDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeachersDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeachersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeachersDGV.ColumnHeadersHeight = 4;
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeachersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeachersDGV.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.TeachersDGV.Location = new System.Drawing.Point(94, 341);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.RowHeadersVisible = false;
            this.TeachersDGV.Size = new System.Drawing.Size(949, 319);
            this.TeachersDGV.TabIndex = 44;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TeachersDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.TeachersDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.TeachersDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeachersDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.TeachersDGV.ThemeStyle.ReadOnly = false;
            this.TeachersDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TeachersDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeachersDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeachersDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.Height = 22;
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeachersDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeachersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeachersDGV_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1046, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 680);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.TeachersDGV);
            this.Controls.Add(this.TPhoneTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubCb);
            this.Controls.Add(this.TAddTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TGenCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TNameTb);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ComboBox SubCb;
        private Guna.UI2.WinForms.Guna2TextBox TAddTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker TDOB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox TGenCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2TextBox TNameTb;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TPhoneTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2DataGridView TeachersDGV;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}