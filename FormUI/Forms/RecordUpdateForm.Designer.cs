namespace FormUI.Forms
{
    partial class RecordUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordUpdateForm));
            this.label_aircraft_title = new System.Windows.Forms.Label();
            this.textBox_trouble = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reason_of_waiting = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_register_staff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_emergency = new System.Windows.Forms.CheckBox();
            this.checkBox_waiting = new System.Windows.Forms.CheckBox();
            this.checkBox_completed = new System.Windows.Forms.CheckBox();
            this.button_mini = new System.Windows.Forms.Button();
            this.button_close_dashboard = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.comboBox_aircraft = new System.Windows.Forms.ComboBox();
            this.comboBox_parts_need = new System.Windows.Forms.ComboBox();
            this.comboBox_identity_staff = new System.Windows.Forms.ComboBox();
            this.comboBox_maintenance_cheif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_aircraft_title
            // 
            this.label_aircraft_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_aircraft_title.AutoSize = true;
            this.label_aircraft_title.Location = new System.Drawing.Point(82, 52);
            this.label_aircraft_title.Name = "label_aircraft_title";
            this.label_aircraft_title.Size = new System.Drawing.Size(132, 20);
            this.label_aircraft_title.TabIndex = 110;
            this.label_aircraft_title.Text = "Uçak seri numarası";
            // 
            // textBox_trouble
            // 
            this.textBox_trouble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_trouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_trouble.ForeColor = System.Drawing.Color.White;
            this.textBox_trouble.Location = new System.Drawing.Point(382, 78);
            this.textBox_trouble.Name = "textBox_trouble";
            this.textBox_trouble.Size = new System.Drawing.Size(245, 27);
            this.textBox_trouble.TabIndex = 111;
            this.textBox_trouble.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_trouble.TextChanged += new System.EventHandler(this.textBox_trouble_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 112;
            this.label1.Text = "Arıza";
            // 
            // textBox_reason_of_waiting
            // 
            this.textBox_reason_of_waiting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_reason_of_waiting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_reason_of_waiting.ForeColor = System.Drawing.Color.White;
            this.textBox_reason_of_waiting.Location = new System.Drawing.Point(735, 78);
            this.textBox_reason_of_waiting.Name = "textBox_reason_of_waiting";
            this.textBox_reason_of_waiting.Size = new System.Drawing.Size(245, 27);
            this.textBox_reason_of_waiting.TabIndex = 113;
            this.textBox_reason_of_waiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_reason_of_waiting.TextChanged += new System.EventHandler(this.textBox_reason_of_waiting_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(799, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 114;
            this.label2.Text = "Bekleme Sebebi";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 116;
            this.label3.Text = "Parça İhtiyacı";
            // 
            // textBox_register_staff
            // 
            this.textBox_register_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_register_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.textBox_register_staff.Enabled = false;
            this.textBox_register_staff.ForeColor = System.Drawing.Color.White;
            this.textBox_register_staff.Location = new System.Drawing.Point(382, 206);
            this.textBox_register_staff.Name = "textBox_register_staff";
            this.textBox_register_staff.Size = new System.Drawing.Size(245, 27);
            this.textBox_register_staff.TabIndex = 117;
            this.textBox_register_staff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_register_staff.TextChanged += new System.EventHandler(this.textBox_register_staff_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 118;
            this.label4.Text = "Kayıt Yapan Kişi";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Arızayı Tespit Eden";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 116;
            this.label6.Text = "Bakım Şefi";
            // 
            // checkBox_emergency
            // 
            this.checkBox_emergency.AutoSize = true;
            this.checkBox_emergency.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_emergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.checkBox_emergency.Location = new System.Drawing.Point(73, 459);
            this.checkBox_emergency.Name = "checkBox_emergency";
            this.checkBox_emergency.Size = new System.Drawing.Size(150, 32);
            this.checkBox_emergency.TabIndex = 120;
            this.checkBox_emergency.Text = "Acil Kayıt";
            this.checkBox_emergency.UseVisualStyleBackColor = true;
            this.checkBox_emergency.CheckedChanged += new System.EventHandler(this.checkBox_emergency_CheckedChanged);
            // 
            // checkBox_waiting
            // 
            this.checkBox_waiting.AutoSize = true;
            this.checkBox_waiting.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_waiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.checkBox_waiting.Location = new System.Drawing.Point(356, 459);
            this.checkBox_waiting.Name = "checkBox_waiting";
            this.checkBox_waiting.Size = new System.Drawing.Size(296, 32);
            this.checkBox_waiting.TabIndex = 121;
            this.checkBox_waiting.Text = "Bakım İçin Beklemede";
            this.checkBox_waiting.UseVisualStyleBackColor = true;
            this.checkBox_waiting.CheckedChanged += new System.EventHandler(this.checkBox_waiting_CheckedChanged);
            // 
            // checkBox_completed
            // 
            this.checkBox_completed.AutoSize = true;
            this.checkBox_completed.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_completed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.checkBox_completed.Location = new System.Drawing.Point(723, 459);
            this.checkBox_completed.Name = "checkBox_completed";
            this.checkBox_completed.Size = new System.Drawing.Size(269, 32);
            this.checkBox_completed.TabIndex = 121;
            this.checkBox_completed.Text = "Tamamlanmış Kayıt";
            this.checkBox_completed.UseVisualStyleBackColor = true;
            this.checkBox_completed.CheckedChanged += new System.EventHandler(this.checkBox_completed_CheckedChanged);
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
            this.button_mini.Location = new System.Drawing.Point(930, 12);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(36, 37);
            this.button_mini.TabIndex = 123;
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
            this.button_close_dashboard.Location = new System.Drawing.Point(972, 12);
            this.button_close_dashboard.Name = "button_close_dashboard";
            this.button_close_dashboard.Size = new System.Drawing.Size(36, 37);
            this.button_close_dashboard.TabIndex = 122;
            this.button_close_dashboard.UseVisualStyleBackColor = false;
            this.button_close_dashboard.Click += new System.EventHandler(this.button_close_dashboard_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(382, 517);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(245, 58);
            this.button_update.TabIndex = 124;
            this.button_update.Text = "GÜNCELLE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // comboBox_aircraft
            // 
            this.comboBox_aircraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_aircraft.ForeColor = System.Drawing.Color.White;
            this.comboBox_aircraft.FormattingEnabled = true;
            this.comboBox_aircraft.Location = new System.Drawing.Point(26, 78);
            this.comboBox_aircraft.Name = "comboBox_aircraft";
            this.comboBox_aircraft.Size = new System.Drawing.Size(245, 28);
            this.comboBox_aircraft.TabIndex = 125;
            // 
            // comboBox_parts_need
            // 
            this.comboBox_parts_need.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_parts_need.ForeColor = System.Drawing.Color.White;
            this.comboBox_parts_need.FormattingEnabled = true;
            this.comboBox_parts_need.Location = new System.Drawing.Point(26, 206);
            this.comboBox_parts_need.Name = "comboBox_parts_need";
            this.comboBox_parts_need.Size = new System.Drawing.Size(245, 28);
            this.comboBox_parts_need.TabIndex = 125;
            // 
            // comboBox_identity_staff
            // 
            this.comboBox_identity_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_identity_staff.ForeColor = System.Drawing.Color.White;
            this.comboBox_identity_staff.FormattingEnabled = true;
            this.comboBox_identity_staff.Location = new System.Drawing.Point(735, 206);
            this.comboBox_identity_staff.Name = "comboBox_identity_staff";
            this.comboBox_identity_staff.Size = new System.Drawing.Size(245, 28);
            this.comboBox_identity_staff.TabIndex = 125;
            // 
            // comboBox_maintenance_cheif
            // 
            this.comboBox_maintenance_cheif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_maintenance_cheif.ForeColor = System.Drawing.Color.White;
            this.comboBox_maintenance_cheif.FormattingEnabled = true;
            this.comboBox_maintenance_cheif.Location = new System.Drawing.Point(382, 363);
            this.comboBox_maintenance_cheif.Name = "comboBox_maintenance_cheif";
            this.comboBox_maintenance_cheif.Size = new System.Drawing.Size(245, 28);
            this.comboBox_maintenance_cheif.TabIndex = 125;
            // 
            // RecordUpdateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1020, 597);
            this.Controls.Add(this.comboBox_maintenance_cheif);
            this.Controls.Add(this.comboBox_identity_staff);
            this.Controls.Add(this.comboBox_parts_need);
            this.Controls.Add(this.comboBox_aircraft);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_mini);
            this.Controls.Add(this.button_close_dashboard);
            this.Controls.Add(this.checkBox_completed);
            this.Controls.Add(this.checkBox_waiting);
            this.Controls.Add(this.checkBox_emergency);
            this.Controls.Add(this.textBox_register_staff);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_reason_of_waiting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_trouble);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_aircraft_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordUpdateForm";
            this.Load += new System.EventHandler(this.RecordUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_aircraft_title;
        private System.Windows.Forms.TextBox textBox_trouble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_reason_of_waiting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_register_staff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_emergency;
        private System.Windows.Forms.CheckBox checkBox_waiting;
        private System.Windows.Forms.CheckBox checkBox_completed;
        private System.Windows.Forms.Button button_mini;
        private System.Windows.Forms.Button button_close_dashboard;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.ComboBox comboBox_aircraft;
        private System.Windows.Forms.ComboBox comboBox_parts_need;
        private System.Windows.Forms.ComboBox comboBox_identity_staff;
        private System.Windows.Forms.ComboBox comboBox_maintenance_cheif;
    }
}