namespace FormUI.UserControls.SettingControls
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
            this.textBox_to_do_during_maintenance = new System.Windows.Forms.TextBox();
            this.label_to_do_during_maintenance = new System.Windows.Forms.Label();
            this.textBox_definition = new System.Windows.Forms.TextBox();
            this.label_definition = new System.Windows.Forms.Label();
            this.textBox_maintenance_periot = new System.Windows.Forms.TextBox();
            this.label_add_periot_title = new System.Windows.Forms.Label();
            this.textBox_maintenance_name = new System.Windows.Forms.TextBox();
            this.label_add_maintenance_name_title = new System.Windows.Forms.Label();
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
            this.label_to_do_during_maintenance_title.Location = new System.Drawing.Point(1113, 20);
            this.label_to_do_during_maintenance_title.Name = "label_to_do_during_maintenance_title";
            this.label_to_do_during_maintenance_title.Size = new System.Drawing.Size(320, 31);
            this.label_to_do_during_maintenance_title.TabIndex = 0;
            this.label_to_do_during_maintenance_title.Text = "Bakım Sırasında Yapılacaklar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.textBox_to_do_during_maintenance);
            this.groupBox1.Controls.Add(this.label_to_do_during_maintenance);
            this.groupBox1.Controls.Add(this.textBox_definition);
            this.groupBox1.Controls.Add(this.label_definition);
            this.groupBox1.Controls.Add(this.textBox_maintenance_periot);
            this.groupBox1.Controls.Add(this.label_add_periot_title);
            this.groupBox1.Controls.Add(this.textBox_maintenance_name);
            this.groupBox1.Controls.Add(this.label_add_maintenance_name_title);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 705);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1569, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Üs Kaydı Oluştur";
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(142)))), ((int)(((byte)(149)))));
            this.button_create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.button_create.Location = new System.Drawing.Point(1410, 71);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(153, 58);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "OLUŞTUR";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_to_do_during_maintenance
            // 
            this.textBox_to_do_during_maintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_to_do_during_maintenance.ForeColor = System.Drawing.Color.Black;
            this.textBox_to_do_during_maintenance.Location = new System.Drawing.Point(1097, 95);
            this.textBox_to_do_during_maintenance.Name = "textBox_to_do_during_maintenance";
            this.textBox_to_do_during_maintenance.Size = new System.Drawing.Size(266, 34);
            this.textBox_to_do_during_maintenance.TabIndex = 3;
            this.textBox_to_do_during_maintenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_to_do_during_maintenance
            // 
            this.label_to_do_during_maintenance.AutoSize = true;
            this.label_to_do_during_maintenance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_to_do_during_maintenance.Location = new System.Drawing.Point(1124, 64);
            this.label_to_do_during_maintenance.Name = "label_to_do_during_maintenance";
            this.label_to_do_during_maintenance.Size = new System.Drawing.Size(213, 28);
            this.label_to_do_during_maintenance.TabIndex = 3;
            this.label_to_do_during_maintenance.Text = "Bakımda Yapılacaklar";
            // 
            // textBox_definition
            // 
            this.textBox_definition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_definition.ForeColor = System.Drawing.Color.Black;
            this.textBox_definition.Location = new System.Drawing.Point(757, 95);
            this.textBox_definition.Name = "textBox_definition";
            this.textBox_definition.Size = new System.Drawing.Size(266, 34);
            this.textBox_definition.TabIndex = 2;
            this.textBox_definition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_definition
            // 
            this.label_definition.AutoSize = true;
            this.label_definition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_definition.Location = new System.Drawing.Point(856, 64);
            this.label_definition.Name = "label_definition";
            this.label_definition.Size = new System.Drawing.Size(69, 28);
            this.label_definition.TabIndex = 3;
            this.label_definition.Text = "Tanım";
            // 
            // textBox_maintenance_periot
            // 
            this.textBox_maintenance_periot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_maintenance_periot.ForeColor = System.Drawing.Color.Black;
            this.textBox_maintenance_periot.Location = new System.Drawing.Point(396, 95);
            this.textBox_maintenance_periot.Name = "textBox_maintenance_periot";
            this.textBox_maintenance_periot.Size = new System.Drawing.Size(266, 34);
            this.textBox_maintenance_periot.TabIndex = 1;
            this.textBox_maintenance_periot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_add_periot_title
            // 
            this.label_add_periot_title.AutoSize = true;
            this.label_add_periot_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_add_periot_title.Location = new System.Drawing.Point(440, 64);
            this.label_add_periot_title.Name = "label_add_periot_title";
            this.label_add_periot_title.Size = new System.Drawing.Size(178, 28);
            this.label_add_periot_title.TabIndex = 3;
            this.label_add_periot_title.Text = "Bakımın Periyodu";
            // 
            // textBox_maintenance_name
            // 
            this.textBox_maintenance_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.textBox_maintenance_name.ForeColor = System.Drawing.Color.Black;
            this.textBox_maintenance_name.Location = new System.Drawing.Point(41, 95);
            this.textBox_maintenance_name.Name = "textBox_maintenance_name";
            this.textBox_maintenance_name.Size = new System.Drawing.Size(266, 34);
            this.textBox_maintenance_name.TabIndex = 0;
            this.textBox_maintenance_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_add_maintenance_name_title
            // 
            this.label_add_maintenance_name_title.AutoSize = true;
            this.label_add_maintenance_name_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_add_maintenance_name_title.Location = new System.Drawing.Point(86, 64);
            this.label_add_maintenance_name_title.Name = "label_add_maintenance_name_title";
            this.label_add_maintenance_name_title.Size = new System.Drawing.Size(177, 28);
            this.label_add_maintenance_name_title.TabIndex = 3;
            this.label_add_maintenance_name_title.Text = "Bakım Adı Giriniz";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1607, 627);
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
        private System.Windows.Forms.TextBox textBox_definition;
        private System.Windows.Forms.Label label_definition;
        private System.Windows.Forms.TextBox textBox_maintenance_periot;
        private System.Windows.Forms.Label label_add_periot_title;
        private System.Windows.Forms.TextBox textBox_maintenance_name;
        private System.Windows.Forms.Label label_add_maintenance_name_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_to_do_during_maintenance;
        private System.Windows.Forms.Label label_to_do_during_maintenance;
    }
}
