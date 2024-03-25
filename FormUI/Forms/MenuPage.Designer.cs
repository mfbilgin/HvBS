namespace FormUI.Forms
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.basic_picture = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox_rapor = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_waiting_care = new System.Windows.Forms.Label();
            this.label_waiting_care_record_number = new System.Windows.Forms.Label();
            this.groupBox_ongoing_care = new System.Windows.Forms.GroupBox();
            this.label_ongoing_care = new System.Windows.Forms.Label();
            this.label_ongoing_care_record_number = new System.Windows.Forms.Label();
            this.groupBox_emergency = new System.Windows.Forms.GroupBox();
            this.label_emergency = new System.Windows.Forms.Label();
            this.label_emergency_record_number = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_HvBS = new System.Windows.Forms.Label();
            this.button_emergency_record = new System.Windows.Forms.Button();
            this.button_countuing = new System.Windows.Forms.Button();
            this.button_waiting_record = new System.Windows.Forms.Button();
            this.button_parts_status = new System.Windows.Forms.Button();
            this.button_completed_record = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_rank = new System.Windows.Forms.TextBox();
            this.button_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).BeginInit();
            this.groupBox_rapor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_ongoing_care.SuspendLayout();
            this.groupBox_emergency.SuspendLayout();
            this.SuspendLayout();
            // 
            // basic_picture
            // 
            this.basic_picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.basic_picture.Image = ((System.Drawing.Image)(resources.GetObject("basic_picture.Image")));
            this.basic_picture.Location = new System.Drawing.Point(425, 260);
            this.basic_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basic_picture.Name = "basic_picture";
            this.basic_picture.Size = new System.Drawing.Size(162, 166);
            this.basic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basic_picture.TabIndex = 1;
            this.basic_picture.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(245, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(523, 27);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Hv.K.K 3. ANA JET ÜSSÜ BAKIM ONARIM SİSTEMİ";
            // 
            // groupBox_rapor
            // 
            this.groupBox_rapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.groupBox_rapor.Controls.Add(this.groupBox2);
            this.groupBox_rapor.Controls.Add(this.groupBox_ongoing_care);
            this.groupBox_rapor.Controls.Add(this.groupBox_emergency);
            this.groupBox_rapor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_rapor.Location = new System.Drawing.Point(39, 64);
            this.groupBox_rapor.Name = "groupBox_rapor";
            this.groupBox_rapor.Size = new System.Drawing.Size(934, 189);
            this.groupBox_rapor.TabIndex = 3;
            this.groupBox_rapor.TabStop = false;
            this.groupBox_rapor.Text = "GÜNLÜK RAPORLAR";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label_waiting_care);
            this.groupBox2.Controls.Add(this.label_waiting_care_record_number);
            this.groupBox2.Location = new System.Drawing.Point(643, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label_waiting_care
            // 
            this.label_waiting_care.AutoSize = true;
            this.label_waiting_care.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_waiting_care.Location = new System.Drawing.Point(6, 84);
            this.label_waiting_care.Name = "label_waiting_care";
            this.label_waiting_care.Size = new System.Drawing.Size(270, 19);
            this.label_waiting_care.TabIndex = 1;
            this.label_waiting_care.Text = "BAKIM İÇİN BEKLEYEN KAYITLAR";
            // 
            // label_waiting_care_record_number
            // 
            this.label_waiting_care_record_number.AutoSize = true;
            this.label_waiting_care_record_number.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_waiting_care_record_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(229)))));
            this.label_waiting_care_record_number.Location = new System.Drawing.Point(6, 24);
            this.label_waiting_care_record_number.Name = "label_waiting_care_record_number";
            this.label_waiting_care_record_number.Size = new System.Drawing.Size(31, 34);
            this.label_waiting_care_record_number.TabIndex = 0;
            this.label_waiting_care_record_number.Text = "0";
            // 
            // groupBox_ongoing_care
            // 
            this.groupBox_ongoing_care.BackColor = System.Drawing.Color.White;
            this.groupBox_ongoing_care.Controls.Add(this.label_ongoing_care);
            this.groupBox_ongoing_care.Controls.Add(this.label_ongoing_care_record_number);
            this.groupBox_ongoing_care.Location = new System.Drawing.Point(334, 27);
            this.groupBox_ongoing_care.Name = "groupBox_ongoing_care";
            this.groupBox_ongoing_care.Size = new System.Drawing.Size(285, 125);
            this.groupBox_ongoing_care.TabIndex = 2;
            this.groupBox_ongoing_care.TabStop = false;
            // 
            // label_ongoing_care
            // 
            this.label_ongoing_care.AutoSize = true;
            this.label_ongoing_care.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ongoing_care.Location = new System.Drawing.Point(6, 84);
            this.label_ongoing_care.Name = "label_ongoing_care";
            this.label_ongoing_care.Size = new System.Drawing.Size(264, 19);
            this.label_ongoing_care.TabIndex = 1;
            this.label_ongoing_care.Text = "BAKIMI DEVAM EDEN KAYITLAR";
            // 
            // label_ongoing_care_record_number
            // 
            this.label_ongoing_care_record_number.AutoSize = true;
            this.label_ongoing_care_record_number.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ongoing_care_record_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(229)))));
            this.label_ongoing_care_record_number.Location = new System.Drawing.Point(6, 24);
            this.label_ongoing_care_record_number.Name = "label_ongoing_care_record_number";
            this.label_ongoing_care_record_number.Size = new System.Drawing.Size(31, 34);
            this.label_ongoing_care_record_number.TabIndex = 0;
            this.label_ongoing_care_record_number.Text = "0";
            // 
            // groupBox_emergency
            // 
            this.groupBox_emergency.BackColor = System.Drawing.Color.White;
            this.groupBox_emergency.Controls.Add(this.label_emergency);
            this.groupBox_emergency.Controls.Add(this.label_emergency_record_number);
            this.groupBox_emergency.Location = new System.Drawing.Point(26, 27);
            this.groupBox_emergency.Name = "groupBox_emergency";
            this.groupBox_emergency.Size = new System.Drawing.Size(285, 125);
            this.groupBox_emergency.TabIndex = 0;
            this.groupBox_emergency.TabStop = false;
            // 
            // label_emergency
            // 
            this.label_emergency.AutoSize = true;
            this.label_emergency.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_emergency.Location = new System.Drawing.Point(6, 84);
            this.label_emergency.Name = "label_emergency";
            this.label_emergency.Size = new System.Drawing.Size(188, 19);
            this.label_emergency.TabIndex = 1;
            this.label_emergency.Text = "ACİL KODLU KAYITLAR";
            // 
            // label_emergency_record_number
            // 
            this.label_emergency_record_number.AutoSize = true;
            this.label_emergency_record_number.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_emergency_record_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(229)))));
            this.label_emergency_record_number.Location = new System.Drawing.Point(6, 24);
            this.label_emergency_record_number.Name = "label_emergency_record_number";
            this.label_emergency_record_number.Size = new System.Drawing.Size(31, 34);
            this.label_emergency_record_number.TabIndex = 0;
            this.label_emergency_record_number.Text = "0";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_name.Location = new System.Drawing.Point(454, 427);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(212, 29);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Musa GÖKDENİZ";
            // 
            // label_HvBS
            // 
            this.label_HvBS.AutoSize = true;
            this.label_HvBS.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_HvBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_HvBS.Location = new System.Drawing.Point(409, 486);
            this.label_HvBS.Name = "label_HvBS";
            this.label_HvBS.Size = new System.Drawing.Size(194, 27);
            this.label_HvBS.TabIndex = 4;
            this.label_HvBS.Text = "HvBS No: 813762";
            // 
            // button_emergency_record
            // 
            this.button_emergency_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_emergency_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_emergency_record.ForeColor = System.Drawing.Color.White;
            this.button_emergency_record.Location = new System.Drawing.Point(360, 516);
            this.button_emergency_record.Name = "button_emergency_record";
            this.button_emergency_record.Size = new System.Drawing.Size(292, 49);
            this.button_emergency_record.TabIndex = 5;
            this.button_emergency_record.Text = "   ・ACİL Kodlu Kayıtlar";
            this.button_emergency_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_emergency_record.UseVisualStyleBackColor = false;
            this.button_emergency_record.Click += new System.EventHandler(this.button_emergency_record_Click);
            // 
            // button_countuing
            // 
            this.button_countuing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_countuing.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_countuing.ForeColor = System.Drawing.Color.White;
            this.button_countuing.Location = new System.Drawing.Point(360, 626);
            this.button_countuing.Name = "button_countuing";
            this.button_countuing.Size = new System.Drawing.Size(292, 49);
            this.button_countuing.TabIndex = 5;
            this.button_countuing.Text = "   ・Bakımı Devam Eden Kayıtlar";
            this.button_countuing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_countuing.UseVisualStyleBackColor = false;
            this.button_countuing.Click += new System.EventHandler(this.button_countuing_Click);
            // 
            // button_waiting_record
            // 
            this.button_waiting_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_waiting_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_waiting_record.ForeColor = System.Drawing.Color.White;
            this.button_waiting_record.Location = new System.Drawing.Point(360, 571);
            this.button_waiting_record.Name = "button_waiting_record";
            this.button_waiting_record.Size = new System.Drawing.Size(292, 49);
            this.button_waiting_record.TabIndex = 5;
            this.button_waiting_record.Text = "   ・Bakım İçin Bekleyen Kayıtlar";
            this.button_waiting_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_waiting_record.UseVisualStyleBackColor = false;
            this.button_waiting_record.Click += new System.EventHandler(this.button_waiting_record_Click);
            // 
            // button_parts_status
            // 
            this.button_parts_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_parts_status.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_parts_status.ForeColor = System.Drawing.Color.White;
            this.button_parts_status.Location = new System.Drawing.Point(360, 736);
            this.button_parts_status.Name = "button_parts_status";
            this.button_parts_status.Size = new System.Drawing.Size(292, 49);
            this.button_parts_status.TabIndex = 5;
            this.button_parts_status.Text = "   ・Yedek Parça Durumu";
            this.button_parts_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_parts_status.UseVisualStyleBackColor = false;
            this.button_parts_status.Click += new System.EventHandler(this.button_parts_status_Click);
            // 
            // button_completed_record
            // 
            this.button_completed_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_completed_record.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_completed_record.ForeColor = System.Drawing.Color.White;
            this.button_completed_record.Location = new System.Drawing.Point(360, 681);
            this.button_completed_record.Name = "button_completed_record";
            this.button_completed_record.Size = new System.Drawing.Size(292, 49);
            this.button_completed_record.TabIndex = 5;
            this.button_completed_record.Text = "   ・Tamamlanmış Kayıtlar";
            this.button_completed_record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_completed_record.UseVisualStyleBackColor = false;
            this.button_completed_record.Click += new System.EventHandler(this.button_completed_record_Click);
            // 
            // button_reports
            // 
            this.button_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_reports.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reports.ForeColor = System.Drawing.Color.White;
            this.button_reports.Location = new System.Drawing.Point(360, 791);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(292, 49);
            this.button_reports.TabIndex = 5;
            this.button_reports.Text = "   ・Raporlar";
            this.button_reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reports.UseVisualStyleBackColor = false;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(894, 9);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(36, 37);
            this.button_minimize.TabIndex = 7;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(936, 9);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(36, 37);
            this.button_close.TabIndex = 6;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_rank
            // 
            this.label_rank.BackColor = System.Drawing.Color.White;
            this.label_rank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_rank.Enabled = false;
            this.label_rank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_rank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.label_rank.Location = new System.Drawing.Point(409, 459);
            this.label_rank.Name = "label_rank";
            this.label_rank.Size = new System.Drawing.Size(194, 25);
            this.label_rank.TabIndex = 8;
            this.label_rank.Text = "Hv.Uck.Bkm.Tğm";
            this.label_rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Image = ((System.Drawing.Image)(resources.GetObject("button_logout.Image")));
            this.button_logout.Location = new System.Drawing.Point(852, 12);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(36, 37);
            this.button_logout.TabIndex = 22;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 935);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_rank);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_reports);
            this.Controls.Add(this.button_completed_record);
            this.Controls.Add(this.button_parts_status);
            this.Controls.Add(this.button_waiting_record);
            this.Controls.Add(this.button_countuing);
            this.Controls.Add(this.button_emergency_record);
            this.Controls.Add(this.label_HvBS);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.groupBox_rapor);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.basic_picture);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).EndInit();
            this.groupBox_rapor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_ongoing_care.ResumeLayout(false);
            this.groupBox_ongoing_care.PerformLayout();
            this.groupBox_emergency.ResumeLayout(false);
            this.groupBox_emergency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox basic_picture;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox_rapor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_waiting_care;
        private System.Windows.Forms.Label label_waiting_care_record_number;
        private System.Windows.Forms.GroupBox groupBox_ongoing_care;
        private System.Windows.Forms.Label label_ongoing_care;
        private System.Windows.Forms.Label label_ongoing_care_record_number;
        private System.Windows.Forms.GroupBox groupBox_emergency;
        private System.Windows.Forms.Label label_emergency;
        private System.Windows.Forms.Label label_emergency_record_number;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_HvBS;
        private System.Windows.Forms.Button button_emergency_record;
        private System.Windows.Forms.Button button_countuing;
        private System.Windows.Forms.Button button_waiting_record;
        private System.Windows.Forms.Button button_parts_status;
        private System.Windows.Forms.Button button_completed_record;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox label_rank;
        private System.Windows.Forms.Button button_logout;
    }
}