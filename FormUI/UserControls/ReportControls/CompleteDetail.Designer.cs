namespace FormUI.UserControls.ReportControls
{
    partial class CompleteDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteDetail));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_complete_staff_title = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.label_maintenance_cheif_title = new System.Windows.Forms.Label();
            this.label_maintenance_time_title = new System.Windows.Forms.Label();
            this.label_completed_date_title = new System.Windows.Forms.Label();
            this.label_trouble_title = new System.Windows.Forms.Label();
            this.label_aircraft_title = new System.Windows.Forms.Label();
            this.label_user_name_title = new System.Windows.Forms.Label();
            this.label_complete_count_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Complete = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Complete_Count = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label_cheif_name_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Chef_Count = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_record_count_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Complete_Count.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel_Chef_Count.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_complete_staff_title
            // 
            this.label_complete_staff_title.AutoSize = true;
            this.label_complete_staff_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_complete_staff_title.Location = new System.Drawing.Point(1080, 20);
            this.label_complete_staff_title.Name = "label_complete_staff_title";
            this.label_complete_staff_title.Size = new System.Drawing.Size(183, 18);
            this.label_complete_staff_title.TabIndex = 8;
            this.label_complete_staff_title.Text = "Tamamlayan Personel";
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1571, 0);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(36, 37);
            this.button_close.TabIndex = 12;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_maintenance_cheif_title
            // 
            this.label_maintenance_cheif_title.AutoSize = true;
            this.label_maintenance_cheif_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maintenance_cheif_title.Location = new System.Drawing.Point(880, 20);
            this.label_maintenance_cheif_title.Name = "label_maintenance_cheif_title";
            this.label_maintenance_cheif_title.Size = new System.Drawing.Size(95, 18);
            this.label_maintenance_cheif_title.TabIndex = 9;
            this.label_maintenance_cheif_title.Text = "Bakım Şefi";
            // 
            // label_maintenance_time_title
            // 
            this.label_maintenance_time_title.AutoSize = true;
            this.label_maintenance_time_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maintenance_time_title.Location = new System.Drawing.Point(624, 20);
            this.label_maintenance_time_title.Name = "label_maintenance_time_title";
            this.label_maintenance_time_title.Size = new System.Drawing.Size(115, 18);
            this.label_maintenance_time_title.TabIndex = 10;
            this.label_maintenance_time_title.Text = "Bakım Süresi";
            // 
            // label_completed_date_title
            // 
            this.label_completed_date_title.AutoSize = true;
            this.label_completed_date_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_completed_date_title.Location = new System.Drawing.Point(397, 20);
            this.label_completed_date_title.Name = "label_completed_date_title";
            this.label_completed_date_title.Size = new System.Drawing.Size(168, 18);
            this.label_completed_date_title.TabIndex = 11;
            this.label_completed_date_title.Text = "Tamamlanma Tarihi";
            // 
            // label_trouble_title
            // 
            this.label_trouble_title.AutoSize = true;
            this.label_trouble_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_trouble_title.Location = new System.Drawing.Point(202, 20);
            this.label_trouble_title.Name = "label_trouble_title";
            this.label_trouble_title.Size = new System.Drawing.Size(51, 18);
            this.label_trouble_title.TabIndex = 7;
            this.label_trouble_title.Text = "Arıza";
            // 
            // label_aircraft_title
            // 
            this.label_aircraft_title.AutoSize = true;
            this.label_aircraft_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_aircraft_title.Location = new System.Drawing.Point(31, 20);
            this.label_aircraft_title.Name = "label_aircraft_title";
            this.label_aircraft_title.Size = new System.Drawing.Size(122, 18);
            this.label_aircraft_title.TabIndex = 6;
            this.label_aircraft_title.Text = "Uçak Seri NO.";
            // 
            // label_user_name_title
            // 
            this.label_user_name_title.AutoSize = true;
            this.label_user_name_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_user_name_title.Location = new System.Drawing.Point(42, 559);
            this.label_user_name_title.Name = "label_user_name_title";
            this.label_user_name_title.Size = new System.Drawing.Size(141, 18);
            this.label_user_name_title.TabIndex = 13;
            this.label_user_name_title.Text = "Tamamlayan Adı";
            // 
            // label_complete_count_title
            // 
            this.label_complete_count_title.AutoSize = true;
            this.label_complete_count_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_complete_count_title.Location = new System.Drawing.Point(244, 559);
            this.label_complete_count_title.Name = "label_complete_count_title";
            this.label_complete_count_title.Size = new System.Drawing.Size(155, 18);
            this.label_complete_count_title.TabIndex = 14;
            this.label_complete_count_title.Text = "Tamamlama Adedi";
            // 
            // flowLayoutPanel_Complete
            // 
            this.flowLayoutPanel_Complete.AutoScroll = true;
            this.flowLayoutPanel_Complete.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Complete.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel_Complete.Name = "flowLayoutPanel_Complete";
            this.flowLayoutPanel_Complete.Size = new System.Drawing.Size(1610, 515);
            this.flowLayoutPanel_Complete.TabIndex = 5;
            // 
            // flowLayoutPanel_Complete_Count
            // 
            this.flowLayoutPanel_Complete_Count.AutoScroll = true;
            this.flowLayoutPanel_Complete_Count.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Complete_Count.Controls.Add(this.groupBox2);
            this.flowLayoutPanel_Complete_Count.Location = new System.Drawing.Point(0, 580);
            this.flowLayoutPanel_Complete_Count.Name = "flowLayoutPanel_Complete_Count";
            this.flowLayoutPanel_Complete_Count.Size = new System.Drawing.Size(478, 369);
            this.flowLayoutPanel_Complete_Count.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label67);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 60);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label5.Location = new System.Drawing.Point(307, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "25";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label67.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label67.Location = new System.Drawing.Point(54, 28);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(117, 21);
            this.label67.TabIndex = 0;
            this.label67.Text = "İsim Soy isim";
            // 
            // label_cheif_name_title
            // 
            this.label_cheif_name_title.AutoSize = true;
            this.label_cheif_name_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cheif_name_title.Location = new System.Drawing.Point(1195, 559);
            this.label_cheif_name_title.Name = "label_cheif_name_title";
            this.label_cheif_name_title.Size = new System.Drawing.Size(95, 18);
            this.label_cheif_name_title.TabIndex = 16;
            this.label_cheif_name_title.Text = "Bakım Şefi";
            // 
            // flowLayoutPanel_Chef_Count
            // 
            this.flowLayoutPanel_Chef_Count.AutoScroll = true;
            this.flowLayoutPanel_Chef_Count.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel_Chef_Count.Controls.Add(this.groupBox1);
            this.flowLayoutPanel_Chef_Count.Location = new System.Drawing.Point(1129, 580);
            this.flowLayoutPanel_Chef_Count.Name = "flowLayoutPanel_Chef_Count";
            this.flowLayoutPanel_Chef_Count.Size = new System.Drawing.Size(478, 369);
            this.flowLayoutPanel_Chef_Count.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(307, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(54, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "İsim Soy isim";
            // 
            // label_record_count_title
            // 
            this.label_record_count_title.AutoSize = true;
            this.label_record_count_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_record_count_title.Location = new System.Drawing.Point(1373, 559);
            this.label_record_count_title.Name = "label_record_count_title";
            this.label_record_count_title.Size = new System.Drawing.Size(155, 18);
            this.label_record_count_title.TabIndex = 17;
            this.label_record_count_title.Text = "Tamamlama Adedi";
            // 
            // CompleteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_cheif_name_title);
            this.Controls.Add(this.flowLayoutPanel_Chef_Count);
            this.Controls.Add(this.label_record_count_title);
            this.Controls.Add(this.label_user_name_title);
            this.Controls.Add(this.flowLayoutPanel_Complete_Count);
            this.Controls.Add(this.label_complete_count_title);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_complete_staff_title);
            this.Controls.Add(this.label_maintenance_cheif_title);
            this.Controls.Add(this.label_maintenance_time_title);
            this.Controls.Add(this.label_completed_date_title);
            this.Controls.Add(this.label_aircraft_title);
            this.Controls.Add(this.label_trouble_title);
            this.Controls.Add(this.flowLayoutPanel_Complete);
            this.Name = "CompleteDetail";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.CompleteDetail_Load);
            this.flowLayoutPanel_Complete_Count.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel_Chef_Count.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_complete_staff_title;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_maintenance_cheif_title;
        private System.Windows.Forms.Label label_maintenance_time_title;
        private System.Windows.Forms.Label label_completed_date_title;
        private System.Windows.Forms.Label label_trouble_title;
        private System.Windows.Forms.Label label_aircraft_title;
        private System.Windows.Forms.Label label_user_name_title;
        private System.Windows.Forms.Label label_complete_count_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Complete;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Complete_Count;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label_cheif_name_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Chef_Count;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_record_count_title;
    }
}
