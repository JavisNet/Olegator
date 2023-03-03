namespace School_System
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.StGenCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DOBPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.StNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FeesTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClassCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.EditBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.AddresTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "УЧАЩИЕСЯ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(54, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "ФИО:";
            // 
            // StGenCb
            // 
            this.StGenCb.BackColor = System.Drawing.Color.Transparent;
            this.StGenCb.BorderRadius = 12;
            this.StGenCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StGenCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StGenCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StGenCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StGenCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StGenCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.StGenCb.ItemHeight = 30;
            this.StGenCb.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.StGenCb.Location = new System.Drawing.Point(340, 103);
            this.StGenCb.Name = "StGenCb";
            this.StGenCb.Size = new System.Drawing.Size(145, 36);
            this.StGenCb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(339, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пол:";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Animated = true;
            this.DOBPicker.AutoRoundedCorners = true;
            this.DOBPicker.BorderRadius = 17;
            this.DOBPicker.Checked = true;
            this.DOBPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOBPicker.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.DOBPicker.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DOBPicker.ForeColor = System.Drawing.SystemColors.Info;
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DOBPicker.Location = new System.Drawing.Point(847, 103);
            this.DOBPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOBPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(200, 36);
            this.DOBPicker.TabIndex = 12;
            this.DOBPicker.Value = new System.DateTime(2022, 11, 29, 12, 31, 17, 893);
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
            this.StNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StNameTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.StNameTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.StNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StNameTb.Location = new System.Drawing.Point(58, 103);
            this.StNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.PlaceholderText = "";
            this.StNameTb.SelectedText = "";
            this.StNameTb.Size = new System.Drawing.Size(275, 36);
            this.StNameTb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(843, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Дата рождения:";
            // 
            // FeesTb
            // 
            this.FeesTb.Animated = true;
            this.FeesTb.AutoRoundedCorners = true;
            this.FeesTb.BorderRadius = 17;
            this.FeesTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FeesTb.DefaultText = "";
            this.FeesTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FeesTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FeesTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FeesTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FeesTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.FeesTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FeesTb.Location = new System.Drawing.Point(58, 178);
            this.FeesTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.PasswordChar = '\0';
            this.FeesTb.PlaceholderText = "";
            this.FeesTb.SelectedText = "";
            this.FeesTb.Size = new System.Drawing.Size(242, 36);
            this.FeesTb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(54, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Оплата обучения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(313, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Класс:";
            // 
            // ClassCb
            // 
            this.ClassCb.BackColor = System.Drawing.Color.Transparent;
            this.ClassCb.BorderRadius = 12;
            this.ClassCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClassCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClassCb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ClassCb.ForeColor = System.Drawing.Color.ForestGreen;
            this.ClassCb.ItemHeight = 30;
            this.ClassCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.ClassCb.Location = new System.Drawing.Point(317, 179);
            this.ClassCb.Name = "ClassCb";
            this.ClassCb.Size = new System.Drawing.Size(168, 36);
            this.ClassCb.TabIndex = 17;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.AutoRoundedCorners = true;
            this.SaveBtn.BorderRadius = 17;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SaveBtn.Location = new System.Drawing.Point(186, 232);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(134, 37);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Добавить";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.EditBtn.Location = new System.Drawing.Point(378, 232);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(135, 37);
            this.EditBtn.TabIndex = 20;
            this.EditBtn.Text = "Изменить";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(583, 232);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(134, 37);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(778, 232);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 37);
            this.BackBtn.TabIndex = 22;
            this.BackBtn.Text = "Назад";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // StudentsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDGV.ColumnHeadersHeight = 4;
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentsDGV.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.StudentsDGV.Location = new System.Drawing.Point(58, 308);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersVisible = false;
            this.StudentsDGV.Size = new System.Drawing.Size(989, 336);
            this.StudentsDGV.TabIndex = 23;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.StudentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.StudentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.StudentsDGV.ThemeStyle.ReadOnly = false;
            this.StudentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(461, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Список учащихся:";
            // 
            // AddresTb
            // 
            this.AddresTb.Animated = true;
            this.AddresTb.BorderRadius = 12;
            this.AddresTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddresTb.DefaultText = "";
            this.AddresTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddresTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddresTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddresTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddresTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddresTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AddresTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.AddresTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddresTb.Location = new System.Drawing.Point(514, 102);
            this.AddresTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddresTb.Name = "AddresTb";
            this.AddresTb.PasswordChar = '\0';
            this.AddresTb.PlaceholderText = "";
            this.AddresTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AddresTb.SelectedText = "";
            this.AddresTb.Size = new System.Drawing.Size(326, 114);
            this.AddresTb.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(510, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Адрес:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1046, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 680);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddresTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClassCb);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StGenCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox StNameTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBPicker;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox StGenCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox ClassCb;
        private Guna.UI2.WinForms.Guna2TextBox FeesTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView StudentsDGV;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2TextBox AddresTb;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}