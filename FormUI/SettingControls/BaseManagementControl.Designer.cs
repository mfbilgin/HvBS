namespace FormUI.SettingControls
{
    partial class BaseManagementControl
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
            this.comboBox_base = new System.Windows.Forms.ComboBox();
            this.label_base_select_title = new System.Windows.Forms.Label();
            this.textBox_authorized_staff = new System.Windows.Forms.TextBox();
            this.label_authorized_staff = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_aircraft_on_base = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_base_name = new System.Windows.Forms.TextBox();
            this.label_new_base_title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_will_autorized_staff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_will_aircrafts = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_base
            // 
            this.comboBox_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.comboBox_base.ForeColor = System.Drawing.Color.Black;
            this.comboBox_base.FormattingEnabled = true;
            this.comboBox_base.Location = new System.Drawing.Point(235, 145);
            this.comboBox_base.Name = "comboBox_base";
            this.comboBox_base.Size = new System.Drawing.Size(243, 28);
            this.comboBox_base.TabIndex = 0;
            // 
            // label_base_select_title
            // 
            this.label_base_select_title.AutoSize = true;
            this.label_base_select_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_base_select_title.Location = new System.Drawing.Point(303, 115);
            this.label_base_select_title.Name = "label_base_select_title";
            this.label_base_select_title.Size = new System.Drawing.Size(107, 28);
            this.label_base_select_title.TabIndex = 1;
            this.label_base_select_title.Text = "Üs Seçiniz";
            // 
            // textBox_authorized_staff
            // 
            this.textBox_authorized_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox_authorized_staff.Enabled = false;
            this.textBox_authorized_staff.ForeColor = System.Drawing.Color.Black;
            this.textBox_authorized_staff.Location = new System.Drawing.Point(725, 146);
            this.textBox_authorized_staff.Name = "textBox_authorized_staff";
            this.textBox_authorized_staff.Size = new System.Drawing.Size(266, 27);
            this.textBox_authorized_staff.TabIndex = 2;
            // 
            // label_authorized_staff
            // 
            this.label_authorized_staff.AutoSize = true;
            this.label_authorized_staff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_authorized_staff.Location = new System.Drawing.Point(739, 115);
            this.label_authorized_staff.Name = "label_authorized_staff";
            this.label_authorized_staff.Size = new System.Drawing.Size(239, 28);
            this.label_authorized_staff.TabIndex = 1;
            this.label_authorized_staff.Text = "Bu Üste Yetkili Olan Kişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1224, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bu Üste Bulunan Uçaklar";
            // 
            // textBox_aircraft_on_base
            // 
            this.textBox_aircraft_on_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.textBox_aircraft_on_base.Enabled = false;
            this.textBox_aircraft_on_base.ForeColor = System.Drawing.Color.Black;
            this.textBox_aircraft_on_base.Location = new System.Drawing.Point(1214, 146);
            this.textBox_aircraft_on_base.Name = "textBox_aircraft_on_base";
            this.textBox_aircraft_on_base.Size = new System.Drawing.Size(266, 27);
            this.textBox_aircraft_on_base.TabIndex = 2;
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
            this.groupBox1.Location = new System.Drawing.Point(235, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 189);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Üs Kaydı Oluştur";
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
            // textBox_will_autorized_staff
            // 
            this.textBox_will_autorized_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_will_autorized_staff.ForeColor = System.Drawing.Color.Black;
            this.textBox_will_autorized_staff.Location = new System.Drawing.Point(429, 95);
            this.textBox_will_autorized_staff.Name = "textBox_will_autorized_staff";
            this.textBox_will_autorized_staff.Size = new System.Drawing.Size(266, 34);
            this.textBox_will_autorized_staff.TabIndex = 4;
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
            // textBox_will_aircrafts
            // 
            this.textBox_will_aircrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_will_aircrafts.ForeColor = System.Drawing.Color.Black;
            this.textBox_will_aircrafts.Location = new System.Drawing.Point(806, 95);
            this.textBox_will_aircrafts.Name = "textBox_will_aircrafts";
            this.textBox_will_aircrafts.Size = new System.Drawing.Size(266, 34);
            this.textBox_will_aircrafts.TabIndex = 4;
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
            // BaseManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_aircraft_on_base);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_authorized_staff);
            this.Controls.Add(this.label_authorized_staff);
            this.Controls.Add(this.label_base_select_title);
            this.Controls.Add(this.comboBox_base);
            this.Name = "BaseManagementControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_base;
        private System.Windows.Forms.Label label_base_select_title;
        private System.Windows.Forms.TextBox textBox_authorized_staff;
        private System.Windows.Forms.Label label_authorized_staff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_aircraft_on_base;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_will_aircrafts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_will_autorized_staff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_base_name;
        private System.Windows.Forms.Label label_new_base_title;
    }
}
