﻿namespace FormUI.Forms
{
    partial class DashboardPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            this.panel_top = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_mini = new System.Windows.Forms.Button();
            this.button_close_dashboard = new System.Windows.Forms.Button();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_dropdown = new System.Windows.Forms.Panel();
            this.button_record_proccess = new System.Windows.Forms.Button();
            this.button_delete_record = new System.Windows.Forms.Button();
            this.button_update_record = new System.Windows.Forms.Button();
            this.button_add_record = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_maintance_settings = new System.Windows.Forms.Button();
            this.button_completed_record = new System.Windows.Forms.Button();
            this.button_parts_status = new System.Windows.Forms.Button();
            this.button_waiting_record = new System.Windows.Forms.Button();
            this.button_countuing = new System.Windows.Forms.Button();
            this.button_emergency_record = new System.Windows.Forms.Button();
            this.label_rank = new System.Windows.Forms.TextBox();
            this.label_HvBS = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.basic_picture = new System.Windows.Forms.PictureBox();
            this.panel_controls = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_part_need = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            this.panel_left.SuspendLayout();
            this.panel_dropdown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.button_logout);
            this.panel_top.Controls.Add(this.label_title);
            this.panel_top.Controls.Add(this.button_mini);
            this.panel_top.Controls.Add(this.button_close_dashboard);
            this.panel_top.Controls.Add(this.pictureBox_top);
            this.panel_top.Controls.Add(this.button_minimize);
            this.panel_top.Controls.Add(this.button_close);
            this.panel_top.Location = new System.Drawing.Point(305, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1613, 125);
            this.panel_top.TabIndex = 4;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.Location = new System.Drawing.Point(1483, 8);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(36, 37);
            this.button_logout.TabIndex = 21;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Century", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(403, 85);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(839, 38);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "Hv.K.K 3. ANA JET ÜSSÜ BAKIM ONARIM SİSTEMİ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_mini
            // 
            this.button_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_mini.BackColor = System.Drawing.Color.Transparent;
            this.button_mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_mini.BackgroundImage")));
            this.button_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_mini.FlatAppearance.BorderSize = 0;
            this.button_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mini.Location = new System.Drawing.Point(1525, 8);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(36, 37);
            this.button_mini.TabIndex = 11;
            this.button_mini.UseVisualStyleBackColor = false;
            this.button_mini.Click += new System.EventHandler(this.button_mini_Click);
            // 
            // button_close_dashboard
            // 
            this.button_close_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.button_close_dashboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close_dashboard.BackgroundImage")));
            this.button_close_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close_dashboard.FlatAppearance.BorderSize = 0;
            this.button_close_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_dashboard.Location = new System.Drawing.Point(1567, 8);
            this.button_close_dashboard.Name = "button_close_dashboard";
            this.button_close_dashboard.Size = new System.Drawing.Size(36, 37);
            this.button_close_dashboard.TabIndex = 10;
            this.button_close_dashboard.UseVisualStyleBackColor = false;
            this.button_close_dashboard.Click += new System.EventHandler(this.button_close_dashboard_Click);
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_top.Image")));
            this.pictureBox_top.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(1670, 125);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 0;
            this.pictureBox_top.TabStop = false;
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(1587, 8);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(0, 37);
            this.button_minimize.TabIndex = 9;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1629, 8);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(0, 37);
            this.button_close.TabIndex = 8;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_left.BackgroundImage")));
            this.panel_left.Controls.Add(this.panel_dropdown);
            this.panel_left.Controls.Add(this.button_reports);
            this.panel_left.Controls.Add(this.button_maintance_settings);
            this.panel_left.Controls.Add(this.button_completed_record);
            this.panel_left.Controls.Add(this.button_parts_status);
            this.panel_left.Controls.Add(this.button_waiting_record);
            this.panel_left.Controls.Add(this.button_countuing);
            this.panel_left.Controls.Add(this.button_emergency_record);
            this.panel_left.Controls.Add(this.label_rank);
            this.panel_left.Controls.Add(this.label_HvBS);
            this.panel_left.Controls.Add(this.label_name);
            this.panel_left.Controls.Add(this.basic_picture);
            this.panel_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel_left.Location = new System.Drawing.Point(5, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(297, 1080);
            this.panel_left.TabIndex = 5;
            // 
            // panel_dropdown
            // 
            this.panel_dropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel_dropdown.Controls.Add(this.button_record_proccess);
            this.panel_dropdown.Controls.Add(this.button_part_need);
            this.panel_dropdown.Controls.Add(this.button_delete_record);
            this.panel_dropdown.Controls.Add(this.button_update_record);
            this.panel_dropdown.Controls.Add(this.button_add_record);
            this.panel_dropdown.Location = new System.Drawing.Point(12, 738);
            this.panel_dropdown.MaximumSize = new System.Drawing.Size(274, 275);
            this.panel_dropdown.MinimumSize = new System.Drawing.Size(274, 55);
            this.panel_dropdown.Name = "panel_dropdown";
            this.panel_dropdown.Size = new System.Drawing.Size(274, 275);
            this.panel_dropdown.TabIndex = 19;
            // 
            // button_record_proccess
            // 
            this.button_record_proccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_record_proccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_record_proccess.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_record_proccess.ForeColor = System.Drawing.Color.White;
            this.button_record_proccess.Location = new System.Drawing.Point(0, 0);
            this.button_record_proccess.Name = "button_record_proccess";
            this.button_record_proccess.Size = new System.Drawing.Size(274, 49);
            this.button_record_proccess.TabIndex = 17;
            this.button_record_proccess.Text = "・Kayıt İşlemleri";
            this.button_record_proccess.UseVisualStyleBackColor = false;
            this.button_record_proccess.Click += new System.EventHandler(this.button_record_proccess_Click);
            // 
            // button_delete_record
            // 
            this.button_delete_record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_delete_record.FlatAppearance.BorderSize = 0;
            this.button_delete_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete_record.ForeColor = System.Drawing.Color.White;
            this.button_delete_record.Location = new System.Drawing.Point(95, 168);
            this.button_delete_record.Name = "button_delete_record";
            this.button_delete_record.Size = new System.Drawing.Size(170, 50);
            this.button_delete_record.TabIndex = 15;
            this.button_delete_record.Text = "・Kayıt Sil";
            this.button_delete_record.UseVisualStyleBackColor = false;
            this.button_delete_record.Click += new System.EventHandler(this.button_delete_record_Click);
            // 
            // button_update_record
            // 
            this.button_update_record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_update_record.FlatAppearance.BorderSize = 0;
            this.button_update_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update_record.ForeColor = System.Drawing.Color.White;
            this.button_update_record.Location = new System.Drawing.Point(95, 112);
            this.button_update_record.Name = "button_update_record";
            this.button_update_record.Size = new System.Drawing.Size(170, 50);
            this.button_update_record.TabIndex = 16;
            this.button_update_record.Text = "・Kayıt Güncelle";
            this.button_update_record.UseVisualStyleBackColor = false;
            this.button_update_record.Click += new System.EventHandler(this.button_update_record_Click);
            // 
            // button_add_record
            // 
            this.button_add_record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_add_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_add_record.FlatAppearance.BorderSize = 0;
            this.button_add_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add_record.ForeColor = System.Drawing.Color.White;
            this.button_add_record.Location = new System.Drawing.Point(95, 59);
            this.button_add_record.Name = "button_add_record";
            this.button_add_record.Size = new System.Drawing.Size(170, 47);
            this.button_add_record.TabIndex = 14;
            this.button_add_record.Text = "・Kayıt Ekle";
            this.button_add_record.UseVisualStyleBackColor = false;
            this.button_add_record.Click += new System.EventHandler(this.button_add_record_Click);
            // 
            // button_reports
            // 
            this.button_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_reports.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reports.ForeColor = System.Drawing.Color.White;
            this.button_reports.Location = new System.Drawing.Point(12, 683);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(274, 49);
            this.button_reports.TabIndex = 12;
            this.button_reports.Text = "   ・Raporlar";
            this.button_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reports.UseVisualStyleBackColor = false;
            // 
            // button_maintance_settings
            // 
            this.button_maintance_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_maintance_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_maintance_settings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_maintance_settings.ForeColor = System.Drawing.Color.White;
            this.button_maintance_settings.Location = new System.Drawing.Point(12, 628);
            this.button_maintance_settings.Name = "button_maintance_settings";
            this.button_maintance_settings.Size = new System.Drawing.Size(274, 49);
            this.button_maintance_settings.TabIndex = 13;
            this.button_maintance_settings.Text = "   ・Bakım Onarım Ayarları";
            this.button_maintance_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_maintance_settings.UseVisualStyleBackColor = false;
            // 
            // button_completed_record
            // 
            this.button_completed_record.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_completed_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_completed_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_completed_record.ForeColor = System.Drawing.Color.White;
            this.button_completed_record.Location = new System.Drawing.Point(12, 573);
            this.button_completed_record.Name = "button_completed_record";
            this.button_completed_record.Size = new System.Drawing.Size(274, 49);
            this.button_completed_record.TabIndex = 14;
            this.button_completed_record.Text = "   ・Tamamlanmış Kayıtlar";
            this.button_completed_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_completed_record.UseVisualStyleBackColor = false;
            this.button_completed_record.Click += new System.EventHandler(this.button_completed_record_Click);
            // 
            // button_parts_status
            // 
            this.button_parts_status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_parts_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_parts_status.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_parts_status.ForeColor = System.Drawing.Color.White;
            this.button_parts_status.Location = new System.Drawing.Point(12, 518);
            this.button_parts_status.Name = "button_parts_status";
            this.button_parts_status.Size = new System.Drawing.Size(274, 49);
            this.button_parts_status.TabIndex = 15;
            this.button_parts_status.Text = "   ・Yedek Parça Durumu";
            this.button_parts_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_parts_status.UseVisualStyleBackColor = false;
            // 
            // button_waiting_record
            // 
            this.button_waiting_record.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_waiting_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_waiting_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_waiting_record.ForeColor = System.Drawing.Color.White;
            this.button_waiting_record.Location = new System.Drawing.Point(12, 463);
            this.button_waiting_record.Name = "button_waiting_record";
            this.button_waiting_record.Size = new System.Drawing.Size(274, 49);
            this.button_waiting_record.TabIndex = 16;
            this.button_waiting_record.Text = "   ・Bakım İçin Bekleyen Kayıtlar";
            this.button_waiting_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_waiting_record.UseVisualStyleBackColor = false;
            this.button_waiting_record.Click += new System.EventHandler(this.button_waiting_record_Click);
            // 
            // button_countuing
            // 
            this.button_countuing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_countuing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_countuing.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_countuing.ForeColor = System.Drawing.Color.White;
            this.button_countuing.Location = new System.Drawing.Point(12, 408);
            this.button_countuing.Name = "button_countuing";
            this.button_countuing.Size = new System.Drawing.Size(274, 49);
            this.button_countuing.TabIndex = 17;
            this.button_countuing.Text = "   ・Bakımı Devam Eden Kayıtlar";
            this.button_countuing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_countuing.UseVisualStyleBackColor = false;
            this.button_countuing.Click += new System.EventHandler(this.button_countuing_Click);
            // 
            // button_emergency_record
            // 
            this.button_emergency_record.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_emergency_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_emergency_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_emergency_record.ForeColor = System.Drawing.Color.White;
            this.button_emergency_record.Location = new System.Drawing.Point(12, 353);
            this.button_emergency_record.Name = "button_emergency_record";
            this.button_emergency_record.Size = new System.Drawing.Size(274, 49);
            this.button_emergency_record.TabIndex = 18;
            this.button_emergency_record.Text = "   ・ACİL Kodlu Kayıtlar";
            this.button_emergency_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_emergency_record.UseVisualStyleBackColor = false;
            this.button_emergency_record.Click += new System.EventHandler(this.button_emergency_record_Click);
            // 
            // label_rank
            // 
            this.label_rank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.label_rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_rank.Enabled = false;
            this.label_rank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_rank.Location = new System.Drawing.Point(48, 191);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(194, 25);
            this.label_rank.TabIndex = 11;
            this.label_rank.Text = "Hv.Uck.Bkm.Tğm";
            this.label_rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_HvBS
            // 
            this.label_HvBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_HvBS.AutoSize = true;
            this.label_HvBS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.label_HvBS.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_HvBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_HvBS.Location = new System.Drawing.Point(55, 216);
            this.label_HvBS.Name = "label_HvBS";
            this.label_HvBS.Size = new System.Drawing.Size(183, 26);
            this.label_HvBS.TabIndex = 9;
            this.label_HvBS.Text = "HvBS No: 813762";
            // 
            // label_name
            // 
            this.label_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_name.Location = new System.Drawing.Point(55, 163);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(185, 26);
            this.label_name.TabIndex = 10;
            this.label_name.Text = "Musa GÖKDENİZ";
            // 
            // basic_picture
            // 
            this.basic_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.basic_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.basic_picture.Image = ((System.Drawing.Image)(resources.GetObject("basic_picture.Image")));
            this.basic_picture.Location = new System.Drawing.Point(72, 33);
            this.basic_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basic_picture.Name = "basic_picture";
            this.basic_picture.Size = new System.Drawing.Size(157, 127);
            this.basic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basic_picture.TabIndex = 1;
            this.basic_picture.TabStop = false;
            // 
            // panel_controls
            // 
            this.panel_controls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_controls.Location = new System.Drawing.Point(308, 131);
            this.panel_controls.Name = "panel_controls";
            this.panel_controls.Size = new System.Drawing.Size(1610, 949);
            this.panel_controls.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_part_need
            // 
            this.button_part_need.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_part_need.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_part_need.FlatAppearance.BorderSize = 0;
            this.button_part_need.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_part_need.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_part_need.ForeColor = System.Drawing.Color.White;
            this.button_part_need.Location = new System.Drawing.Point(95, 222);
            this.button_part_need.Name = "button_part_need";
            this.button_part_need.Size = new System.Drawing.Size(170, 50);
            this.button_part_need.TabIndex = 15;
            this.button_part_need.Text = "・Parça Ekle";
            this.button_part_need.UseVisualStyleBackColor = false;
            this.button_part_need.Click += new System.EventHandler(this.button_part_need_Click);
            // 
            // DashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel_controls);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.Load += new System.EventHandler(this.DashboardPage_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.panel_dropdown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.PictureBox basic_picture;
        private System.Windows.Forms.TextBox label_rank;
        private System.Windows.Forms.Label label_HvBS;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_maintance_settings;
        private System.Windows.Forms.Button button_completed_record;
        private System.Windows.Forms.Button button_parts_status;
        private System.Windows.Forms.Button button_waiting_record;
        private System.Windows.Forms.Button button_countuing;
        private System.Windows.Forms.Button button_emergency_record;
        private System.Windows.Forms.Button button_mini;
        private System.Windows.Forms.Button button_close_dashboard;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_controls;
        private System.Windows.Forms.Panel panel_dropdown;
        private System.Windows.Forms.Button button_delete_record;
        private System.Windows.Forms.Button button_update_record;
        private System.Windows.Forms.Button button_add_record;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_record_proccess;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_part_need;
    }
}