namespace FormUI.SettingControls
{
    partial class MaintenanceTypeControl
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
            this.label_maintenance_name_title = new System.Windows.Forms.Label();
            this.label_maintenance_periot_title = new System.Windows.Forms.Label();
            this.label_definition_title = new System.Windows.Forms.Label();
            this.label_to_do_during_maintenance_title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_will_aircrafts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_will_autorized_staff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_base_name = new System.Windows.Forms.TextBox();
            this.label_new_base_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_maintenance_name_title
            // 
            this.label_maintenance_name_title.AutoSize = true;
            this.label_maintenance_name_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maintenance_name_title.Location = new System.Drawing.Point(101, 20);
            this.label_maintenance_name_title.Name = "label_maintenance_name_title";
            this.label_maintenance_name_title.Size = new System.Drawing.Size(146, 31);
            this.label_maintenance_name_title.TabIndex = 0;
            this.label_maintenance_name_title.Text = "Bakımın Adı";
            // 
            // label_maintenance_periot_title
            // 
            this.label_maintenance_periot_title.AutoSize = true;
            this.label_maintenance_periot_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_maintenance_periot_title.Location = new System.Drawing.Point(388, 20);
            this.label_maintenance_periot_title.Name = "label_maintenance_periot_title";
            this.label_maintenance_periot_title.Size = new System.Drawing.Size(204, 31);
            this.label_maintenance_periot_title.TabIndex = 0;
            this.label_maintenance_periot_title.Text = "Bakımın Periyodu";
            // 
            // label_definition_title
            // 
            this.label_definition_title.AutoSize = true;
            this.label_definition_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_definition_title.Location = new System.Drawing.Point(738, 20);
            this.label_definition_title.Name = "label_definition_title";
            this.label_definition_title.Size = new System.Drawing.Size(79, 31);
            this.label_definition_title.TabIndex = 0;
            this.label_definition_title.Text = "Tanım";
            // 
            // label_to_do_during_maintenance_title
            // 
            this.label_to_do_during_maintenance_title.AutoSize = true;
            this.label_to_do_during_maintenance_title.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_to_do_during_maintenance_title.Location = new System.Drawing.Point(965, 20);
            this.label_to_do_during_maintenance_title.Name = "label_to_do_during_maintenance_title";
            this.label_to_do_during_maintenance_title.Size = new System.Drawing.Size(320, 31);
            this.label_to_do_during_maintenance_title.TabIndex = 0;
            this.label_to_do_during_maintenance_title.Text = "Bakım Sırasında Yapılacaklar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.textBox_will_aircrafts);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_will_autorized_staff);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_base_name);
            this.groupBox1.Controls.Add(this.label_new_base_title);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(174, 678);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Üs Kaydı Oluştur";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.button_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.button_create.Location = new System.Drawing.Point(1086, 71);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(153, 58);
            this.button_create.TabIndex = 5;
            this.button_create.Text = "OLUŞTUR";
            this.button_create.UseVisualStyleBackColor = false;
            // 
            // textBox_will_aircrafts
            // 
            this.textBox_will_aircrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_will_aircrafts.ForeColor = System.Drawing.Color.Black;
            this.textBox_will_aircrafts.Location = new System.Drawing.Point(806, 95);
            this.textBox_will_aircrafts.Name = "textBox_will_aircrafts";
            this.textBox_will_aircrafts.Size = new System.Drawing.Size(266, 34);
            this.textBox_will_aircrafts.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(832, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Üste Bulunan Uçaklar";
            // 
            // textBox_will_autorized_staff
            // 
            this.textBox_will_autorized_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_will_autorized_staff.ForeColor = System.Drawing.Color.Black;
            this.textBox_will_autorized_staff.Location = new System.Drawing.Point(429, 95);
            this.textBox_will_autorized_staff.Name = "textBox_will_autorized_staff";
            this.textBox_will_autorized_staff.Size = new System.Drawing.Size(266, 34);
            this.textBox_will_autorized_staff.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yetkili Olacak Personel";
            // 
            // textBox_base_name
            // 
            this.textBox_base_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_base_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_base_name.Location = new System.Drawing.Point(41, 95);
            this.textBox_base_name.Name = "textBox_base_name";
            this.textBox_base_name.Size = new System.Drawing.Size(266, 34);
            this.textBox_base_name.TabIndex = 4;
            // 
            // label_new_base_title
            // 
            this.label_new_base_title.AutoSize = true;
            this.label_new_base_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_new_base_title.Location = new System.Drawing.Point(121, 64);
            this.label_new_base_title.Name = "label_new_base_title";
            this.label_new_base_title.Size = new System.Drawing.Size(106, 28);
            this.label_new_base_title.TabIndex = 3;
            this.label_new_base_title.Text = "Üssün Adı";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1607, 596);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // MaintenanceTypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_to_do_during_maintenance_title);
            this.Controls.Add(this.label_definition_title);
            this.Controls.Add(this.label_maintenance_periot_title);
            this.Controls.Add(this.label_maintenance_name_title);
            this.Name = "MaintenanceTypeControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.MaintenanceTypeControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_maintenance_name_title;
        private System.Windows.Forms.Label label_maintenance_periot_title;
        private System.Windows.Forms.Label label_definition_title;
        private System.Windows.Forms.Label label_to_do_during_maintenance_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_will_aircrafts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_will_autorized_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_base_name;
        private System.Windows.Forms.Label label_new_base_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
