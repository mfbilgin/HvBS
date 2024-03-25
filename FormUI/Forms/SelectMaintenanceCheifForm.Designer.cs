namespace FormUI.Forms
{
    partial class SelectMaintenanceCheifForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectMaintenanceCheifForm));
            this.comboBox_maintenance_cheif = new System.Windows.Forms.ComboBox();
            this.label_cheif = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_select = new System.Windows.Forms.Button();
            this.button_close_dashboard = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_end_date_title = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_maintenance_cheif
            // 
            this.comboBox_maintenance_cheif.FormattingEnabled = true;
            this.comboBox_maintenance_cheif.Location = new System.Drawing.Point(12, 100);
            this.comboBox_maintenance_cheif.Name = "comboBox_maintenance_cheif";
            this.comboBox_maintenance_cheif.Size = new System.Drawing.Size(331, 28);
            this.comboBox_maintenance_cheif.TabIndex = 0;
            // 
            // label_cheif
            // 
            this.label_cheif.AutoSize = true;
            this.label_cheif.Location = new System.Drawing.Point(138, 80);
            this.label_cheif.Name = "label_cheif";
            this.label_cheif.Size = new System.Drawing.Size(79, 20);
            this.label_cheif.TabIndex = 1;
            this.label_cheif.Text = "Bakım Şefi";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.label_title.Location = new System.Drawing.Point(240, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(314, 38);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Bilgileri Seçiniz Seçiniz";
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_select.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_select.ForeColor = System.Drawing.Color.White;
            this.button_select.Location = new System.Drawing.Point(275, 153);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(245, 58);
            this.button_select.TabIndex = 125;
            this.button_select.Text = "SEÇ";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_close_dashboard
            // 
            this.button_close_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.button_close_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close_dashboard.FlatAppearance.BorderSize = 0;
            this.button_close_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_dashboard.Location = new System.Drawing.Point(749, 9);
            this.button_close_dashboard.Name = "button_close_dashboard";
            this.button_close_dashboard.Size = new System.Drawing.Size(36, 37);
            this.button_close_dashboard.TabIndex = 126;
            this.button_close_dashboard.UseVisualStyleBackColor = false;
            this.button_close_dashboard.Click += new System.EventHandler(this.button_close_dashboard_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 27);
            this.dateTimePicker1.TabIndex = 128;
            this.dateTimePicker1.Value = new System.DateTime(2023, 4, 9, 15, 4, 29, 0);
            // 
            // label_end_date_title
            // 
            this.label_end_date_title.AutoSize = true;
            this.label_end_date_title.Location = new System.Drawing.Point(528, 80);
            this.label_end_date_title.Name = "label_end_date_title";
            this.label_end_date_title.Size = new System.Drawing.Size(133, 20);
            this.label_end_date_title.TabIndex = 129;
            this.label_end_date_title.Text = "Tahmini Çıkış Tarihi";
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(749, 10);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(36, 37);
            this.button_close.TabIndex = 130;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // SelectMaintenanceCheifForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(797, 223);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_end_date_title);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_close_dashboard);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_cheif);
            this.Controls.Add(this.comboBox_maintenance_cheif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectMaintenanceCheifForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SelectMaintenanceCheifForm";
            this.Load += new System.EventHandler(this.SelectMaintenanceCheifForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_maintenance_cheif;
        private System.Windows.Forms.Label label_cheif;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_close_dashboard;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_end_date_title;
        private System.Windows.Forms.Button button_close;
    }
}