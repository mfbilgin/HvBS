namespace FormUI.Forms
{
    partial class PasswordResetPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordResetPage));
            this.basic_picture = new System.Windows.Forms.PictureBox();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_HvBS = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // basic_picture
            // 
            this.basic_picture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.basic_picture.Image = ((System.Drawing.Image)(resources.GetObject("basic_picture.Image")));
            this.basic_picture.Location = new System.Drawing.Point(328, 82);
            this.basic_picture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.basic_picture.Name = "basic_picture";
            this.basic_picture.Size = new System.Drawing.Size(299, 240);
            this.basic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.basic_picture.TabIndex = 1;
            this.basic_picture.TabStop = false;
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
            this.button_minimize.TabIndex = 6;
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
            this.button_close.TabIndex = 7;
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parola Sıfırlama";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(284, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "HvBS numaranızı girdikten sonra telefonunuza gelen \r\nparola ile giriş yapabilirsi" +
    "niz.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_HvBS
            // 
            this.textBox_HvBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox_HvBS.BackColor = System.Drawing.Color.White;
            this.textBox_HvBS.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_HvBS.Location = new System.Drawing.Point(268, 442);
            this.textBox_HvBS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_HvBS.Name = "textBox_HvBS";
            this.textBox_HvBS.Size = new System.Drawing.Size(417, 28);
            this.textBox_HvBS.TabIndex = 9;
            this.textBox_HvBS.Text = "HvBS No";
            this.textBox_HvBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_HvBS.Enter += new System.EventHandler(this.textBox_HvBS_Enter);
            this.textBox_HvBS.Leave += new System.EventHandler(this.textBox_HvBS_Leave);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(87)))), ((int)(((byte)(232)))));
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(376, 487);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 50);
            this.button_login.TabIndex = 10;
            this.button_login.Text = "Şifre Gönder";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // PasswordResetPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 763);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_HvBS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.basic_picture);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswordResetPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordResetPage";
            ((System.ComponentModel.ISupportInitialize)(this.basic_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox basic_picture;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_HvBS;
        private System.Windows.Forms.Button button_login;
    }
}