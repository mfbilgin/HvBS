namespace FormUI.Forms
{
    partial class BaseAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseAddForm));
            this.label_title = new System.Windows.Forms.Label();
            this.textBox_base_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_aircrafts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.label_title.Location = new System.Drawing.Point(267, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(314, 38);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Bilgileri Seçiniz Seçiniz";
            // 
            // textBox_base_name
            // 
            this.textBox_base_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_base_name.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_base_name.Location = new System.Drawing.Point(12, 102);
            this.textBox_base_name.Name = "textBox_base_name";
            this.textBox_base_name.Size = new System.Drawing.Size(239, 27);
            this.textBox_base_name.TabIndex = 0;
            this.textBox_base_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(105, 74);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Üs Adı";
            // 
            // textBox_aircrafts
            // 
            this.textBox_aircrafts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_aircrafts.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_aircrafts.Location = new System.Drawing.Point(598, 102);
            this.textBox_aircrafts.Name = "textBox_aircrafts";
            this.textBox_aircrafts.Size = new System.Drawing.Size(239, 27);
            this.textBox_aircrafts.TabIndex = 1;
            this.textBox_aircrafts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üste Bulunan Uçaklar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Üste Yetkili Kişi";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_add.ForeColor = System.Drawing.SystemColors.Window;
            this.button_add.Location = new System.Drawing.Point(340, 188);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(168, 64);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "EKLE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(801, 10);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(36, 37);
            this.button_close.TabIndex = 4;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(308, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // BaseAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 281);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_aircrafts);
            this.Controls.Add(this.textBox_base_name);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectBaseForm";
            this.Load += new System.EventHandler(this.BaseAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_base_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_aircrafts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}