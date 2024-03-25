﻿namespace FormUI.UserControls.ViewControls
{
    partial class EmergencyRecordControl
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_estimated_date = new System.Windows.Forms.Label();
            this.label_identify_staff = new System.Windows.Forms.Label();
            this.label_register_staff = new System.Windows.Forms.Label();
            this.label_parts_need = new System.Windows.Forms.Label();
            this.label_register_date = new System.Windows.Forms.Label();
            this.label_trouble = new System.Windows.Forms.Label();
            this.label_aircraft_number = new System.Windows.Forms.Label();
            this.label_aircraft_title = new System.Windows.Forms.Label();
            this.label_trouble_title = new System.Windows.Forms.Label();
            this.label_register_date_title = new System.Windows.Forms.Label();
            this.label_estimated_date_title = new System.Windows.Forms.Label();
            this.label_parts_need_title = new System.Windows.Forms.Label();
            this.label_register_staff_title = new System.Windows.Forms.Label();
            this.label_identify_staff_title = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel.Controls.Add(this.groupBox1);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 41);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1610, 908);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_estimated_date);
            this.groupBox1.Controls.Add(this.label_identify_staff);
            this.groupBox1.Controls.Add(this.label_register_staff);
            this.groupBox1.Controls.Add(this.label_parts_need);
            this.groupBox1.Controls.Add(this.label_register_date);
            this.groupBox1.Controls.Add(this.label_trouble);
            this.groupBox1.Controls.Add(this.label_aircraft_number);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1604, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_estimated_date
            // 
            this.label_estimated_date.AutoSize = true;
            this.label_estimated_date.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_estimated_date.ForeColor = System.Drawing.Color.Black;
            this.label_estimated_date.Location = new System.Drawing.Point(763, 18);
            this.label_estimated_date.Name = "label_estimated_date";
            this.label_estimated_date.Size = new System.Drawing.Size(16, 21);
            this.label_estimated_date.TabIndex = 0;
            this.label_estimated_date.Text = "-";
            // 
            // label_identify_staff
            // 
            this.label_identify_staff.AutoSize = true;
            this.label_identify_staff.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_identify_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_identify_staff.Location = new System.Drawing.Point(1435, 18);
            this.label_identify_staff.Name = "label_identify_staff";
            this.label_identify_staff.Size = new System.Drawing.Size(101, 21);
            this.label_identify_staff.TabIndex = 0;
            this.label_identify_staff.Text = "Tespit Pers";
            // 
            // label_register_staff
            // 
            this.label_register_staff.AutoSize = true;
            this.label_register_staff.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_register_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_register_staff.Location = new System.Drawing.Point(1183, 18);
            this.label_register_staff.Name = "label_register_staff";
            this.label_register_staff.Size = new System.Drawing.Size(94, 21);
            this.label_register_staff.TabIndex = 0;
            this.label_register_staff.Text = "Kayıt Pers";
            // 
            // label_parts_need
            // 
            this.label_parts_need.AutoSize = true;
            this.label_parts_need.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_parts_need.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_parts_need.Location = new System.Drawing.Point(972, 18);
            this.label_parts_need.Name = "label_parts_need";
            this.label_parts_need.Size = new System.Drawing.Size(55, 21);
            this.label_parts_need.TabIndex = 0;
            this.label_parts_need.Text = "Parça";
            // 
            // label_register_date
            // 
            this.label_register_date.AutoSize = true;
            this.label_register_date.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_register_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_register_date.Location = new System.Drawing.Point(472, 18);
            this.label_register_date.Name = "label_register_date";
            this.label_register_date.Size = new System.Drawing.Size(92, 21);
            this.label_register_date.TabIndex = 0;
            this.label_register_date.Text = "19.10.2023";
            // 
            // label_trouble
            // 
            this.label_trouble.AutoSize = true;
            this.label_trouble.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_trouble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_trouble.Location = new System.Drawing.Point(282, 18);
            this.label_trouble.Name = "label_trouble";
            this.label_trouble.Size = new System.Drawing.Size(52, 21);
            this.label_trouble.TabIndex = 0;
            this.label_trouble.Text = "Arıza";
            // 
            // label_aircraft_number
            // 
            this.label_aircraft_number.AutoSize = true;
            this.label_aircraft_number.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_aircraft_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_aircraft_number.Location = new System.Drawing.Point(123, 18);
            this.label_aircraft_number.Name = "label_aircraft_number";
            this.label_aircraft_number.Size = new System.Drawing.Size(79, 21);
            this.label_aircraft_number.TabIndex = 0;
            this.label_aircraft_number.Text = "Uçak No";
            // 
            // label_aircraft_title
            // 
            this.label_aircraft_title.AutoSize = true;
            this.label_aircraft_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_aircraft_title.Location = new System.Drawing.Point(83, 20);
            this.label_aircraft_title.Name = "label_aircraft_title";
            this.label_aircraft_title.Size = new System.Drawing.Size(122, 18);
            this.label_aircraft_title.TabIndex = 2;
            this.label_aircraft_title.Text = "Uçak Seri NO.";
            // 
            // label_trouble_title
            // 
            this.label_trouble_title.AutoSize = true;
            this.label_trouble_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_trouble_title.Location = new System.Drawing.Point(240, 20);
            this.label_trouble_title.Name = "label_trouble_title";
            this.label_trouble_title.Size = new System.Drawing.Size(51, 18);
            this.label_trouble_title.TabIndex = 3;
            this.label_trouble_title.Text = "Arıza";
            // 
            // label_register_date_title
            // 
            this.label_register_date_title.AutoSize = true;
            this.label_register_date_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_register_date_title.Location = new System.Drawing.Point(434, 20);
            this.label_register_date_title.Name = "label_register_date_title";
            this.label_register_date_title.Size = new System.Drawing.Size(169, 18);
            this.label_register_date_title.TabIndex = 4;
            this.label_register_date_title.Text = "Bakıma Giriş Tarihi";
            // 
            // label_estimated_date_title
            // 
            this.label_estimated_date_title.AutoSize = true;
            this.label_estimated_date_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_estimated_date_title.Location = new System.Drawing.Point(683, 20);
            this.label_estimated_date_title.Name = "label_estimated_date_title";
            this.label_estimated_date_title.Size = new System.Drawing.Size(176, 18);
            this.label_estimated_date_title.TabIndex = 4;
            this.label_estimated_date_title.Text = "Tahmini Çıkış Tarihi";
            // 
            // label_parts_need_title
            // 
            this.label_parts_need_title.AutoSize = true;
            this.label_parts_need_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_parts_need_title.Location = new System.Drawing.Point(939, 20);
            this.label_parts_need_title.Name = "label_parts_need_title";
            this.label_parts_need_title.Size = new System.Drawing.Size(120, 18);
            this.label_parts_need_title.TabIndex = 4;
            this.label_parts_need_title.Text = "Parça İhtiyacı";
            // 
            // label_register_staff_title
            // 
            this.label_register_staff_title.AutoSize = true;
            this.label_register_staff_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_register_staff_title.Location = new System.Drawing.Point(1139, 20);
            this.label_register_staff_title.Name = "label_register_staff_title";
            this.label_register_staff_title.Size = new System.Drawing.Size(182, 18);
            this.label_register_staff_title.TabIndex = 4;
            this.label_register_staff_title.Text = "Kayıt Yapan Personel";
            // 
            // label_identify_staff_title
            // 
            this.label_identify_staff_title.AutoSize = true;
            this.label_identify_staff_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_identify_staff_title.Location = new System.Drawing.Point(1401, 20);
            this.label_identify_staff_title.Name = "label_identify_staff_title";
            this.label_identify_staff_title.Size = new System.Drawing.Size(168, 18);
            this.label_identify_staff_title.TabIndex = 4;
            this.label_identify_staff_title.Text = "Arızayı Tespit Eden";
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EmergencyRecordControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label_identify_staff_title);
            this.Controls.Add(this.label_register_staff_title);
            this.Controls.Add(this.label_parts_need_title);
            this.Controls.Add(this.label_estimated_date_title);
            this.Controls.Add(this.label_register_date_title);
            this.Controls.Add(this.label_trouble_title);
            this.Controls.Add(this.label_aircraft_title);
            this.Controls.Add(this.flowLayoutPanel);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "EmergencyRecordControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.EmergencyRecordControl_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label_aircraft_title;
        private System.Windows.Forms.Label label_trouble_title;
        private System.Windows.Forms.Label label_register_date_title;
        private System.Windows.Forms.Label label_estimated_date_title;
        private System.Windows.Forms.Label label_parts_need_title;
        private System.Windows.Forms.Label label_register_staff_title;
        private System.Windows.Forms.Label label_identify_staff_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_estimated_date;
        private System.Windows.Forms.Label label_identify_staff;
        private System.Windows.Forms.Label label_register_staff;
        private System.Windows.Forms.Label label_parts_need;
        private System.Windows.Forms.Label label_register_date;
        private System.Windows.Forms.Label label_trouble;
        private System.Windows.Forms.Label label_aircraft_number;
        private System.Windows.Forms.Timer timer1;
    }
}
