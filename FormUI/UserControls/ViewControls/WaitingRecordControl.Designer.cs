namespace FormUI.UserControls.ViewControls
{
    partial class WaitingRecordControl
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label_estimated_date = new System.Windows.Forms.Label();
            this.label_identify_staff = new System.Windows.Forms.Label();
            this.label_register_staff = new System.Windows.Forms.Label();
            this.label_parts_need = new System.Windows.Forms.Label();
            this.label_register_date = new System.Windows.Forms.Label();
            this.label_trouble = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label_reason_of_waiting = new System.Windows.Forms.Label();
            this.label_aircraft_number = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label_parts_need_title = new System.Windows.Forms.Label();
            this.label_estimated_date_title = new System.Windows.Forms.Label();
            this.label_register_date_title = new System.Windows.Forms.Label();
            this.label_trouble_title = new System.Windows.Forms.Label();
            this.label_aircraft_title = new System.Windows.Forms.Label();
            this.label_identify_staff_title = new System.Windows.Forms.Label();
            this.label_reason_of_waiting_title = new System.Windows.Forms.Label();
            this.label_register_staff_title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 21);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_estimated_date
            // 
            this.label_estimated_date.AutoSize = true;
            this.label_estimated_date.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_estimated_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_estimated_date.Location = new System.Drawing.Point(565, 30);
            this.label_estimated_date.Name = "label_estimated_date";
            this.label_estimated_date.Size = new System.Drawing.Size(118, 21);
            this.label_estimated_date.TabIndex = 0;
            this.label_estimated_date.Text = "Belirtilmemiş";
            // 
            // label_identify_staff
            // 
            this.label_identify_staff.AutoSize = true;
            this.label_identify_staff.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_identify_staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_identify_staff.Location = new System.Drawing.Point(1195, 30);
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
            this.label_register_staff.Location = new System.Drawing.Point(974, 30);
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
            this.label_parts_need.Location = new System.Drawing.Point(794, 30);
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
            this.label_register_date.Location = new System.Drawing.Point(356, 30);
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
            this.label_trouble.Location = new System.Drawing.Point(217, 30);
            this.label_trouble.Name = "label_trouble";
            this.label_trouble.Size = new System.Drawing.Size(52, 21);
            this.label_trouble.TabIndex = 0;
            this.label_trouble.Text = "Arıza";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label_estimated_date);
            this.groupBox1.Controls.Add(this.label_reason_of_waiting);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.BackgroundImage = global::FormUI.Properties.Resources.icons8_job_32;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1144, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 21);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label_reason_of_waiting
            // 
            this.label_reason_of_waiting.AutoSize = true;
            this.label_reason_of_waiting.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_reason_of_waiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_reason_of_waiting.Location = new System.Drawing.Point(1377, 30);
            this.label_reason_of_waiting.Name = "label_reason_of_waiting";
            this.label_reason_of_waiting.Size = new System.Drawing.Size(141, 21);
            this.label_reason_of_waiting.TabIndex = 0;
            this.label_reason_of_waiting.Text = "Bekleme Nedeni";
            // 
            // label_aircraft_number
            // 
            this.label_aircraft_number.AutoSize = true;
            this.label_aircraft_number.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_aircraft_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_aircraft_number.Location = new System.Drawing.Point(69, 30);
            this.label_aircraft_number.Name = "label_aircraft_number";
            this.label_aircraft_number.Size = new System.Drawing.Size(79, 21);
            this.label_aircraft_number.TabIndex = 0;
            this.label_aircraft_number.Text = "Uçak No";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel.Controls.Add(this.groupBox1);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1610, 908);
            this.flowLayoutPanel.TabIndex = 20;
            // 
            // label_parts_need_title
            // 
            this.label_parts_need_title.AutoSize = true;
            this.label_parts_need_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_parts_need_title.Location = new System.Drawing.Point(761, 20);
            this.label_parts_need_title.Name = "label_parts_need_title";
            this.label_parts_need_title.Size = new System.Drawing.Size(120, 18);
            this.label_parts_need_title.TabIndex = 17;
            this.label_parts_need_title.Text = "Parça İhtiyacı";
            // 
            // label_estimated_date_title
            // 
            this.label_estimated_date_title.AutoSize = true;
            this.label_estimated_date_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_estimated_date_title.Location = new System.Drawing.Point(546, 20);
            this.label_estimated_date_title.Name = "label_estimated_date_title";
            this.label_estimated_date_title.Size = new System.Drawing.Size(176, 18);
            this.label_estimated_date_title.TabIndex = 18;
            this.label_estimated_date_title.Text = "Tahmini Çıkış Tarihi";
            // 
            // label_register_date_title
            // 
            this.label_register_date_title.AutoSize = true;
            this.label_register_date_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_register_date_title.Location = new System.Drawing.Point(349, 20);
            this.label_register_date_title.Name = "label_register_date_title";
            this.label_register_date_title.Size = new System.Drawing.Size(107, 18);
            this.label_register_date_title.TabIndex = 19;
            this.label_register_date_title.Text = "Kayıt Tarihi";
            // 
            // label_trouble_title
            // 
            this.label_trouble_title.AutoSize = true;
            this.label_trouble_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_trouble_title.Location = new System.Drawing.Point(157, 20);
            this.label_trouble_title.Name = "label_trouble_title";
            this.label_trouble_title.Size = new System.Drawing.Size(51, 18);
            this.label_trouble_title.TabIndex = 14;
            this.label_trouble_title.Text = "Arıza";
            // 
            // label_aircraft_title
            // 
            this.label_aircraft_title.AutoSize = true;
            this.label_aircraft_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_aircraft_title.Location = new System.Drawing.Point(29, 20);
            this.label_aircraft_title.Name = "label_aircraft_title";
            this.label_aircraft_title.Size = new System.Drawing.Size(122, 18);
            this.label_aircraft_title.TabIndex = 13;
            this.label_aircraft_title.Text = "Uçak Seri NO.";
            // 
            // label_identify_staff_title
            // 
            this.label_identify_staff_title.AutoSize = true;
            this.label_identify_staff_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_identify_staff_title.Location = new System.Drawing.Point(1161, 20);
            this.label_identify_staff_title.Name = "label_identify_staff_title";
            this.label_identify_staff_title.Size = new System.Drawing.Size(168, 18);
            this.label_identify_staff_title.TabIndex = 15;
            this.label_identify_staff_title.Text = "Arızayı Tespit Eden";
            // 
            // label_reason_of_waiting_title
            // 
            this.label_reason_of_waiting_title.AutoSize = true;
            this.label_reason_of_waiting_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_reason_of_waiting_title.Location = new System.Drawing.Point(1378, 20);
            this.label_reason_of_waiting_title.Name = "label_reason_of_waiting_title";
            this.label_reason_of_waiting_title.Size = new System.Drawing.Size(139, 18);
            this.label_reason_of_waiting_title.TabIndex = 15;
            this.label_reason_of_waiting_title.Text = "Bekleme Nedeni";
            // 
            // label_register_staff_title
            // 
            this.label_register_staff_title.AutoSize = true;
            this.label_register_staff_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_register_staff_title.Location = new System.Drawing.Point(930, 20);
            this.label_register_staff_title.Name = "label_register_staff_title";
            this.label_register_staff_title.Size = new System.Drawing.Size(182, 18);
            this.label_register_staff_title.TabIndex = 16;
            this.label_register_staff_title.Text = "Kayıt Yapan Personel";
            // 
            // WaitingRecordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.label_register_staff_title);
            this.Controls.Add(this.label_parts_need_title);
            this.Controls.Add(this.label_estimated_date_title);
            this.Controls.Add(this.label_register_date_title);
            this.Controls.Add(this.label_trouble_title);
            this.Controls.Add(this.label_aircraft_title);
            this.Controls.Add(this.label_reason_of_waiting_title);
            this.Controls.Add(this.label_identify_staff_title);
            this.Name = "WaitingRecordControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.WaitingRecordControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_estimated_date;
        private System.Windows.Forms.Label label_identify_staff;
        private System.Windows.Forms.Label label_register_staff;
        private System.Windows.Forms.Label label_parts_need;
        private System.Windows.Forms.Label label_register_date;
        private System.Windows.Forms.Label label_trouble;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_aircraft_number;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label_parts_need_title;
        private System.Windows.Forms.Label label_estimated_date_title;
        private System.Windows.Forms.Label label_register_date_title;
        private System.Windows.Forms.Label label_trouble_title;
        private System.Windows.Forms.Label label_aircraft_title;
        private System.Windows.Forms.Label label_identify_staff_title;
        private System.Windows.Forms.Label label_reason_of_waiting;
        private System.Windows.Forms.Label label_reason_of_waiting_title;
        private System.Windows.Forms.Label label_register_staff_title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
