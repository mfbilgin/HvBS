namespace FormUI.Forms
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.basic_picture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_phone_number = new System.Windows.Forms.TextBox();
            this.textBox_HvBS = new System.Windows.Forms.TextBox();
            this.textBox_rank = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_show_password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // basic_picture
            // 
            this.basic_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.basic_picture.Image = ((System.Drawing.Image)(resources.GetObject("basic_picture.Image")));
            this.basic_picture.Location = new System.Drawing.Point(318, 69);
            this.basic_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basic_picture.Name = "basic_picture";
            this.basic_picture.Size = new System.Drawing.Size(312, 252);
            this.basic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basic_picture.TabIndex = 1;
            this.basic_picture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(165, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hava Kuvvetleri Komutanlığı Uçak Bakım Onarım Sistemi";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_first_name.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_first_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_first_name.Location = new System.Drawing.Point(318, 399);
            this.textBox_first_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(312, 28);
            this.textBox_first_name.TabIndex = 0;
            this.textBox_first_name.Text = "Ad";
            this.textBox_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_first_name.Enter += new System.EventHandler(this.textBox_first_name_Enter);
            this.textBox_first_name.Leave += new System.EventHandler(this.textBox_first_name_Leave);
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_last_name.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_last_name.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_last_name.Location = new System.Drawing.Point(318, 435);
            this.textBox_last_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(312, 28);
            this.textBox_last_name.TabIndex = 1;
            this.textBox_last_name.Text = "Soy Ad";
            this.textBox_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_last_name.Enter += new System.EventHandler(this.textBox_last_name_Enter);
            this.textBox_last_name.Leave += new System.EventHandler(this.textBox_last_name_Leave);
            // 
            // textBox_phone_number
            // 
            this.textBox_phone_number.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_phone_number.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_phone_number.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_phone_number.Location = new System.Drawing.Point(318, 471);
            this.textBox_phone_number.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_phone_number.MaxLength = 13;
            this.textBox_phone_number.Name = "textBox_phone_number";
            this.textBox_phone_number.Size = new System.Drawing.Size(312, 28);
            this.textBox_phone_number.TabIndex = 2;
            this.textBox_phone_number.Text = "Telefon Numarası";
            this.textBox_phone_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_phone_number.TextChanged += new System.EventHandler(this.textBox_phone_number_TextChanged);
            this.textBox_phone_number.Enter += new System.EventHandler(this.textBox_phone_number_Enter);
            this.textBox_phone_number.Leave += new System.EventHandler(this.textBox_phone_number_Leave);
            // 
            // textBox_HvBS
            // 
            this.textBox_HvBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_HvBS.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_HvBS.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_HvBS.Location = new System.Drawing.Point(318, 507);
            this.textBox_HvBS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_HvBS.Name = "textBox_HvBS";
            this.textBox_HvBS.Size = new System.Drawing.Size(312, 28);
            this.textBox_HvBS.TabIndex = 3;
            this.textBox_HvBS.Text = "HvBS No";
            this.textBox_HvBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_HvBS.Enter += new System.EventHandler(this.textBox_HvBS_Enter);
            this.textBox_HvBS.Leave += new System.EventHandler(this.textBox_HvBS_Leave);
            // 
            // textBox_rank
            // 
            this.textBox_rank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_rank.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_rank.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_rank.Location = new System.Drawing.Point(318, 543);
            this.textBox_rank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_rank.Name = "textBox_rank";
            this.textBox_rank.Size = new System.Drawing.Size(312, 28);
            this.textBox_rank.TabIndex = 4;
            this.textBox_rank.Text = "Rütbe";
            this.textBox_rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_rank.Enter += new System.EventHandler(this.textBox_rank_Enter);
            this.textBox_rank.Leave += new System.EventHandler(this.textBox_rank_Leave);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_password.Location = new System.Drawing.Point(318, 579);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(312, 28);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "Parola";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(232)))));
            this.button_register.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_register.ForeColor = System.Drawing.Color.White;
            this.button_register.Location = new System.Drawing.Point(379, 615);
            this.button_register.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(187, 64);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Kayıt Ol";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_minimize.BackColor = System.Drawing.Color.Transparent;
            this.button_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_minimize.BackgroundImage")));
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Location = new System.Drawing.Point(894, 12);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(36, 37);
            this.button_minimize.TabIndex = 7;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(936, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(36, 37);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_show_password
            // 
            this.button_show_password.BackColor = System.Drawing.SystemColors.Control;
            this.button_show_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_password.BackgroundImage")));
            this.button_show_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_show_password.FlatAppearance.BorderSize = 0;
            this.button_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_password.Location = new System.Drawing.Point(602, 580);
            this.button_show_password.Name = "button_show_password";
            this.button_show_password.Size = new System.Drawing.Size(28, 23);
            this.button_show_password.TabIndex = 9;
            this.button_show_password.UseVisualStyleBackColor = false;
            this.button_show_password.Click += new System.EventHandler(this.button_show_password_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 763);
            this.Controls.Add(this.button_show_password);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_rank);
            this.Controls.Add(this.textBox_HvBS);
            this.Controls.Add(this.textBox_phone_number);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.basic_picture);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterPage";
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox basic_picture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_phone_number;
        private System.Windows.Forms.TextBox textBox_HvBS;
        private System.Windows.Forms.TextBox textBox_rank;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_show_password;
    }
}