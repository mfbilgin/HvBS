namespace FormUI.UserControls.ProccessControl
{
    partial class RecordAddControl
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_aircraft_title = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_register_staff = new System.Windows.Forms.Label();
            this.checkBox_emergency = new System.Windows.Forms.CheckBox();
            this.button_add_control = new System.Windows.Forms.Button();
            this.label_maintenance_type = new System.Windows.Forms.Label();
            this.comboBox_maintenance_type = new System.Windows.Forms.ComboBox();
            this.textBox_register_user = new System.Windows.Forms.TextBox();
            this.comboBox_aircraft_no = new System.Windows.Forms.ComboBox();
            this.comboBox_part_needs = new System.Windows.Forms.ComboBox();
            this.comboBox_staff = new System.Windows.Forms.ComboBox();
            this.textBox_trouble = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1232, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 115;
            this.label3.Text = "Arızayı Tespit Eden";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(909, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 113;
            this.label2.Text = "Parça İhtiyacı";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 111;
            this.label1.Text = "Arıza";
            // 
            // label_aircraft_title
            // 
            this.label_aircraft_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_aircraft_title.AutoSize = true;
            this.label_aircraft_title.Location = new System.Drawing.Point(185, 199);
            this.label_aircraft_title.Name = "label_aircraft_title";
            this.label_aircraft_title.Size = new System.Drawing.Size(192, 23);
            this.label_aircraft_title.TabIndex = 108;
            this.label_aircraft_title.Text = "Uçak seri numarası";
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(673, 92);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(280, 33);
            this.label_title.TabIndex = 109;
            this.label_title.Text = "Yeni Kayıt Ekleme";
            // 
            // label_register_staff
            // 
            this.label_register_staff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_register_staff.AutoSize = true;
            this.label_register_staff.Location = new System.Drawing.Point(756, 397);
            this.label_register_staff.Name = "label_register_staff";
            this.label_register_staff.Size = new System.Drawing.Size(127, 23);
            this.label_register_staff.TabIndex = 117;
            this.label_register_staff.Text = "Kayıt Yapan";
            // 
            // checkBox_emergency
            // 
            this.checkBox_emergency.AutoSize = true;
            this.checkBox_emergency.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_emergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.checkBox_emergency.Location = new System.Drawing.Point(1093, 423);
            this.checkBox_emergency.Name = "checkBox_emergency";
            this.checkBox_emergency.Size = new System.Drawing.Size(150, 32);
            this.checkBox_emergency.TabIndex = 6;
            this.checkBox_emergency.Text = "Acil Kayıt";
            this.checkBox_emergency.UseVisualStyleBackColor = true;
            this.checkBox_emergency.CheckedChanged += new System.EventHandler(this.checkBox_emergency_CheckedChanged);
            // 
            // button_add_control
            // 
            this.button_add_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_add_control.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add_control.ForeColor = System.Drawing.Color.White;
            this.button_add_control.Location = new System.Drawing.Point(673, 528);
            this.button_add_control.Name = "button_add_control";
            this.button_add_control.Size = new System.Drawing.Size(280, 59);
            this.button_add_control.TabIndex = 7;
            this.button_add_control.Text = "Kayıt Oluştur";
            this.button_add_control.UseVisualStyleBackColor = false;
            this.button_add_control.Click += new System.EventHandler(this.button_add_control_Click);
            // 
            // label_maintenance_type
            // 
            this.label_maintenance_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_maintenance_type.AutoSize = true;
            this.label_maintenance_type.Location = new System.Drawing.Point(407, 395);
            this.label_maintenance_type.Name = "label_maintenance_type";
            this.label_maintenance_type.Size = new System.Drawing.Size(123, 23);
            this.label_maintenance_type.TabIndex = 117;
            this.label_maintenance_type.Text = "Bakım Türü";
            // 
            // comboBox_maintenance_type
            // 
            this.comboBox_maintenance_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_maintenance_type.ForeColor = System.Drawing.Color.White;
            this.comboBox_maintenance_type.FormattingEnabled = true;
            this.comboBox_maintenance_type.Location = new System.Drawing.Point(348, 423);
            this.comboBox_maintenance_type.Name = "comboBox_maintenance_type";
            this.comboBox_maintenance_type.Size = new System.Drawing.Size(245, 31);
            this.comboBox_maintenance_type.TabIndex = 4;
            // 
            // textBox_register_user
            // 
            this.textBox_register_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_register_user.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox_register_user.Enabled = false;
            this.textBox_register_user.ForeColor = System.Drawing.Color.White;
            this.textBox_register_user.Location = new System.Drawing.Point(697, 422);
            this.textBox_register_user.Name = "textBox_register_user";
            this.textBox_register_user.Size = new System.Drawing.Size(245, 32);
            this.textBox_register_user.TabIndex = 118;
            this.textBox_register_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_aircraft_no
            // 
            this.comboBox_aircraft_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_aircraft_no.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox_aircraft_no.FormattingEnabled = true;
            this.comboBox_aircraft_no.Location = new System.Drawing.Point(159, 226);
            this.comboBox_aircraft_no.Name = "comboBox_aircraft_no";
            this.comboBox_aircraft_no.Size = new System.Drawing.Size(245, 31);
            this.comboBox_aircraft_no.TabIndex = 119;
            // 
            // comboBox_part_needs
            // 
            this.comboBox_part_needs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_part_needs.ForeColor = System.Drawing.Color.White;
            this.comboBox_part_needs.FormattingEnabled = true;
            this.comboBox_part_needs.Location = new System.Drawing.Point(857, 226);
            this.comboBox_part_needs.Name = "comboBox_part_needs";
            this.comboBox_part_needs.Size = new System.Drawing.Size(245, 31);
            this.comboBox_part_needs.TabIndex = 121;
            // 
            // comboBox_staff
            // 
            this.comboBox_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox_staff.ForeColor = System.Drawing.Color.White;
            this.comboBox_staff.FormattingEnabled = true;
            this.comboBox_staff.Location = new System.Drawing.Point(1206, 226);
            this.comboBox_staff.Name = "comboBox_staff";
            this.comboBox_staff.Size = new System.Drawing.Size(245, 31);
            this.comboBox_staff.TabIndex = 122;
            // 
            // textBox_trouble
            // 
            this.textBox_trouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_trouble.ForeColor = System.Drawing.Color.White;
            this.textBox_trouble.Location = new System.Drawing.Point(504, 225);
            this.textBox_trouble.Name = "textBox_trouble";
            this.textBox_trouble.Size = new System.Drawing.Size(245, 32);
            this.textBox_trouble.TabIndex = 123;
            // 
            // RecordAddControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox_trouble);
            this.Controls.Add(this.comboBox_staff);
            this.Controls.Add(this.comboBox_part_needs);
            this.Controls.Add(this.comboBox_aircraft_no);
            this.Controls.Add(this.textBox_register_user);
            this.Controls.Add(this.comboBox_maintenance_type);
            this.Controls.Add(this.button_add_control);
            this.Controls.Add(this.label_maintenance_type);
            this.Controls.Add(this.checkBox_emergency);
            this.Controls.Add(this.label_register_staff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_aircraft_title);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RecordAddControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.RecordAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_aircraft_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_register_staff;
        private System.Windows.Forms.CheckBox checkBox_emergency;
        private System.Windows.Forms.Button button_add_control;
        private System.Windows.Forms.Label label_maintenance_type;
        private System.Windows.Forms.ComboBox comboBox_maintenance_type;
        private System.Windows.Forms.TextBox textBox_register_user;
        private System.Windows.Forms.ComboBox comboBox_aircraft_no;
        private System.Windows.Forms.ComboBox comboBox_part_needs;
        private System.Windows.Forms.ComboBox comboBox_staff;
        private System.Windows.Forms.TextBox textBox_trouble;
    }
}
