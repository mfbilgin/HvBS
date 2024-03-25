namespace FormUI.Forms
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.basic_picture = new System.Windows.Forms.PictureBox();
            this.textBox_HvBS = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_password_change = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_show_password = new System.Windows.Forms.Button();
            this.label_is_register = new System.Windows.Forms.Label();
            this.comboBox_bases = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // basic_picture
            // 
            this.basic_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basic_picture.Image = ((System.Drawing.Image)(resources.GetObject("basic_picture.Image")));
            this.basic_picture.Location = new System.Drawing.Point(318, 69);
            this.basic_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basic_picture.Name = "basic_picture";
            this.basic_picture.Size = new System.Drawing.Size(312, 252);
            this.basic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basic_picture.TabIndex = 0;
            this.basic_picture.TabStop = false;
            // 
            // textBox_HvBS
            // 
            this.textBox_HvBS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_HvBS.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_HvBS.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_HvBS.Location = new System.Drawing.Point(318, 399);
            this.textBox_HvBS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_HvBS.Name = "textBox_HvBS";
            this.textBox_HvBS.Size = new System.Drawing.Size(312, 28);
            this.textBox_HvBS.TabIndex = 0;
            this.textBox_HvBS.Text = "HvBS No";
            this.textBox_HvBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_HvBS.Enter += new System.EventHandler(this.textBox_HvBS_Enter);
            this.textBox_HvBS.Leave += new System.EventHandler(this.textBox_HvBS_Leave);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_password.Location = new System.Drawing.Point(318, 455);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(312, 28);
            this.textBox_password.TabIndex = 1;
            this.textBox_password.Text = "Parola";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.Enter += new System.EventHandler(this.textBox_password_Enter);
            this.textBox_password.Leave += new System.EventHandler(this.textBox_password_Leave);
            // 
            // label_password_change
            // 
            this.label_password_change.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password_change.AutoSize = true;
            this.label_password_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_password_change.Location = new System.Drawing.Point(415, 569);
            this.label_password_change.Name = "label_password_change";
            this.label_password_change.Size = new System.Drawing.Size(118, 16);
            this.label_password_change.TabIndex = 3;
            this.label_password_change.Text = "Parola Sıfırlama";
            this.label_password_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_password_change.Click += new System.EventHandler(this.label_password_change_Click);
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(232)))));
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(381, 601);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(187, 64);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Giriş";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(155, 345);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(639, 27);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Hava Kuvvetleri Komutanlığı Uçak Bakım Onarım Sistemi";
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
            this.button_minimize.TabIndex = 5;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_show_password
            // 
            this.button_show_password.BackColor = System.Drawing.SystemColors.Control;
            this.button_show_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_password.BackgroundImage")));
            this.button_show_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_show_password.FlatAppearance.BorderSize = 0;
            this.button_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_password.Location = new System.Drawing.Point(602, 455);
            this.button_show_password.Name = "button_show_password";
            this.button_show_password.Size = new System.Drawing.Size(28, 23);
            this.button_show_password.TabIndex = 6;
            this.button_show_password.UseVisualStyleBackColor = false;
            this.button_show_password.Click += new System.EventHandler(this.button_show_password_Click);
            // 
            // label_is_register
            // 
            this.label_is_register.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_is_register.AutoSize = true;
            this.label_is_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_is_register.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label_is_register.Location = new System.Drawing.Point(372, 669);
            this.label_is_register.Name = "label_is_register";
            this.label_is_register.Size = new System.Drawing.Size(204, 16);
            this.label_is_register.TabIndex = 8;
            this.label_is_register.Text = "Hesabınız Yoksa Şimdi Oluşturun";
            this.label_is_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_is_register.Click += new System.EventHandler(this.label_is_register_Click);
            // 
            // comboBox_bases
            // 
            this.comboBox_bases.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_bases.FormattingEnabled = true;
            this.comboBox_bases.Location = new System.Drawing.Point(318, 513);
            this.comboBox_bases.Name = "comboBox_bases";
            this.comboBox_bases.Size = new System.Drawing.Size(312, 29);
            this.comboBox_bases.TabIndex = 9;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 763);
            this.Controls.Add(this.comboBox_bases);
            this.Controls.Add(this.label_is_register);
            this.Controls.Add(this.button_show_password);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password_change);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_HvBS);
            this.Controls.Add(this.basic_picture);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button_show_password;

        #endregion

        private System.Windows.Forms.PictureBox basic_picture;
        private System.Windows.Forms.TextBox textBox_HvBS;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_password_change;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Label label_is_register;
        private System.Windows.Forms.ComboBox comboBox_bases;
    }
}

