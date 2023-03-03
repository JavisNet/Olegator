namespace School_System
{
    partial class Fees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.PeriodDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StIdCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AmountTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FeesDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
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
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ОПЛАТА ОБУЧЕНИЯ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.ForestGreen;
            this.label7.Location = new System.Drawing.Point(461, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Список оплаты:";
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
            this.BackBtn.Location = new System.Drawing.Point(558, 196);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 37);
            this.BackBtn.TabIndex = 60;
            this.BackBtn.Text = "Назад";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.AddBtn.Location = new System.Drawing.Point(397, 196);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(134, 37);
            this.AddBtn.TabIndex = 57;
            this.AddBtn.Text = "Оплатить";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(859, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 56;
            this.label6.Text = "Сумма:";
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
            this.StNameTb.Location = new System.Drawing.Point(266, 119);
            this.StNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.PasswordChar = '\0';
            this.StNameTb.PlaceholderText = "";
            this.StNameTb.SelectedText = "";
            this.StNameTb.Size = new System.Drawing.Size(306, 36);
            this.StNameTb.TabIndex = 53;
            // 
            // PeriodDate
            // 
            this.PeriodDate.Animated = true;
            this.PeriodDate.AutoRoundedCorners = true;
            this.PeriodDate.BorderRadius = 17;
            this.PeriodDate.Checked = true;
            this.PeriodDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PeriodDate.FillColor = System.Drawing.Color.DarkSeaGreen;
            this.PeriodDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.PeriodDate.ForeColor = System.Drawing.SystemColors.Info;
            this.PeriodDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.PeriodDate.Location = new System.Drawing.Point(599, 119);
            this.PeriodDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.PeriodDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.PeriodDate.Name = "PeriodDate";
            this.PeriodDate.Size = new System.Drawing.Size(200, 36);
            this.PeriodDate.TabIndex = 52;
            this.PeriodDate.Value = new System.DateTime(2022, 11, 29, 12, 31, 17, 893);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID Учащегося:";
            // 
            // StIdCb
            // 
            this.StIdCb.AutoRoundedCorners = true;
            this.StIdCb.BackColor = System.Drawing.Color.Transparent;
            this.StIdCb.BorderRadius = 17;
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
            this.StIdCb.Location = new System.Drawing.Point(58, 121);
            this.StIdCb.Name = "StIdCb";
            this.StIdCb.Size = new System.Drawing.Size(168, 36);
            this.StIdCb.TabIndex = 50;
            this.StIdCb.SelectionChangeCommitted += new System.EventHandler(this.StIdCb_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(262, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 24);
            this.label3.TabIndex = 49;
            this.label3.Text = "Имя учащегося:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(595, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Период:";
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
            this.panel1.TabIndex = 48;
            // 
            // AmountTb
            // 
            this.AmountTb.Animated = true;
            this.AmountTb.AutoRoundedCorners = true;
            this.AmountTb.BorderRadius = 17;
            this.AmountTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AmountTb.DefaultText = "";
            this.AmountTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AmountTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AmountTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AmountTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AmountTb.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AmountTb.ForeColor = System.Drawing.Color.ForestGreen;
            this.AmountTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AmountTb.Location = new System.Drawing.Point(863, 121);
            this.AmountTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.PasswordChar = '\0';
            this.AmountTb.PlaceholderText = "";
            this.AmountTb.SelectedText = "";
            this.AmountTb.Size = new System.Drawing.Size(184, 36);
            this.AmountTb.TabIndex = 64;
            // 
            // FeesDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeesDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FeesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FeesDGV.ColumnHeadersHeight = 4;
            this.FeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeesDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.FeesDGV.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.FeesDGV.Location = new System.Drawing.Point(58, 286);
            this.FeesDGV.Name = "FeesDGV";
            this.FeesDGV.RowHeadersVisible = false;
            this.FeesDGV.Size = new System.Drawing.Size(989, 336);
            this.FeesDGV.TabIndex = 65;
            this.FeesDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FeesDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FeesDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FeesDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FeesDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FeesDGV.ThemeStyle.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.FeesDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.FeesDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.FeesDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeesDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FeesDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FeesDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.FeesDGV.ThemeStyle.ReadOnly = false;
            this.FeesDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FeesDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FeesDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeesDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeesDGV.ThemeStyle.RowsStyle.Height = 22;
            this.FeesDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeesDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1046, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 680);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.FeesDGV);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.PeriodDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StIdCb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Fees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button AddBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox StNameTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox StIdCb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox AmountTb;
        private Guna.UI2.WinForms.Guna2DataGridView FeesDGV;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}