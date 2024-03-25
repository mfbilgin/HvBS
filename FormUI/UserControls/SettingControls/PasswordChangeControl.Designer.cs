namespace FormUI.UserControls.SettingControls
{
    partial class PasswordChangeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordChangeControl));
            this.label_change_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_old_password = new System.Windows.Forms.TextBox();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_new_password_confirm = new System.Windows.Forms.TextBox();
            this.button_update = new System.Windows.Forms.Button();
            this.button_show_old_password = new System.Windows.Forms.Button();
            this.button_show_new_password = new System.Windows.Forms.Button();
            this.button_show_new_password_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_change_title
            // 
            this.label_change_title.AutoSize = true;
            this.label_change_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_change_title.Location = new System.Drawing.Point(691, 61);
            this.label_change_title.Name = "label_change_title";
            this.label_change_title.Size = new System.Drawing.Size(248, 37);
            this.label_change_title.TabIndex = 0;
            this.label_change_title.Text = "Parola Değiştirme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eski Şifreniz";
            // 
            // textBox_old_password
            // 
            this.textBox_old_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_old_password.ForeColor = System.Drawing.Color.White;
            this.textBox_old_password.Location = new System.Drawing.Point(165, 232);
            this.textBox_old_password.Name = "textBox_old_password";
            this.textBox_old_password.Size = new System.Drawing.Size(259, 27);
            this.textBox_old_password.TabIndex = 0;
            this.textBox_old_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_old_password.UseSystemPasswordChar = true;
            this.textBox_old_password.TextChanged += new System.EventHandler(this.textBox_old_password_TextChanged);
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_new_password.ForeColor = System.Drawing.Color.White;
            this.textBox_new_password.Location = new System.Drawing.Point(686, 232);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.Size = new System.Drawing.Size(259, 27);
            this.textBox_new_password.TabIndex = 1;
            this.textBox_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_new_password.UseSystemPasswordChar = true;
            this.textBox_new_password.TextChanged += new System.EventHandler(this.textBox_new_password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(755, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yeni Şifreniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1235, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şifrenizi Doğrulayın";
            // 
            // textBox_new_password_confirm
            // 
            this.textBox_new_password_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_new_password_confirm.ForeColor = System.Drawing.Color.White;
            this.textBox_new_password_confirm.Location = new System.Drawing.Point(1200, 232);
            this.textBox_new_password_confirm.Name = "textBox_new_password_confirm";
            this.textBox_new_password_confirm.Size = new System.Drawing.Size(259, 27);
            this.textBox_new_password_confirm.TabIndex = 2;
            this.textBox_new_password_confirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_new_password_confirm.UseSystemPasswordChar = true;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(686, 436);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(259, 68);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Güncelle";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_show_old_password
            // 
            this.button_show_old_password.BackColor = System.Drawing.SystemColors.Control;
            this.button_show_old_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_old_password.BackgroundImage")));
            this.button_show_old_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_show_old_password.FlatAppearance.BorderSize = 0;
            this.button_show_old_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_old_password.Location = new System.Drawing.Point(394, 235);
            this.button_show_old_password.Name = "button_show_old_password";
            this.button_show_old_password.Size = new System.Drawing.Size(28, 23);
            this.button_show_old_password.TabIndex = 7;
            this.button_show_old_password.UseVisualStyleBackColor = false;
            this.button_show_old_password.Click += new System.EventHandler(this.button_show_old_password_Click);
            // 
            // button_show_new_password
            // 
            this.button_show_new_password.BackColor = System.Drawing.SystemColors.Control;
            this.button_show_new_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_new_password.BackgroundImage")));
            this.button_show_new_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_show_new_password.FlatAppearance.BorderSize = 0;
            this.button_show_new_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_new_password.Location = new System.Drawing.Point(917, 234);
            this.button_show_new_password.Name = "button_show_new_password";
            this.button_show_new_password.Size = new System.Drawing.Size(28, 23);
            this.button_show_new_password.TabIndex = 7;
            this.button_show_new_password.UseVisualStyleBackColor = false;
            this.button_show_new_password.Click += new System.EventHandler(this.button_show_new_password_Click);
            // 
            // button_show_new_password_confirm
            // 
            this.button_show_new_password_confirm.BackColor = System.Drawing.SystemColors.Control;
            this.button_show_new_password_confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_show_new_password_confirm.BackgroundImage")));
            this.button_show_new_password_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_show_new_password_confirm.FlatAppearance.BorderSize = 0;
            this.button_show_new_password_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_show_new_password_confirm.Location = new System.Drawing.Point(1431, 234);
            this.button_show_new_password_confirm.Name = "button_show_new_password_confirm";
            this.button_show_new_password_confirm.Size = new System.Drawing.Size(28, 23);
            this.button_show_new_password_confirm.TabIndex = 7;
            this.button_show_new_password_confirm.UseVisualStyleBackColor = false;
            this.button_show_new_password_confirm.Click += new System.EventHandler(this.button_show_new_password_confirm_Click);
            // 
            // PasswordChangeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_show_new_password_confirm);
            this.Controls.Add(this.button_show_new_password);
            this.Controls.Add(this.button_show_old_password);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_new_password_confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_new_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_old_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_change_title);
            this.Name = "PasswordChangeControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.PasswordChangeControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_change_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_old_password;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_new_password_confirm;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_show_old_password;
        private System.Windows.Forms.Button button_show_new_password;
        private System.Windows.Forms.Button button_show_new_password_confirm;
    }
}
