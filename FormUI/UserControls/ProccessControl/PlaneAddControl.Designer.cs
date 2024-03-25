namespace FormUI.UserControls.ProccessControl
{
    partial class PlaneAddControl
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label_plane_title = new System.Windows.Forms.Label();
            this.label_plane_type_title = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_plane_type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1607, 628);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // label_plane_title
            // 
            this.label_plane_title.AutoSize = true;
            this.label_plane_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_plane_title.Location = new System.Drawing.Point(370, 20);
            this.label_plane_title.Name = "label_plane_title";
            this.label_plane_title.Size = new System.Drawing.Size(122, 18);
            this.label_plane_title.TabIndex = 14;
            this.label_plane_title.Text = "Uçak Seri NO.";
            // 
            // label_plane_type_title
            // 
            this.label_plane_type_title.AutoSize = true;
            this.label_plane_type_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_plane_type_title.Location = new System.Drawing.Point(1023, 20);
            this.label_plane_type_title.Name = "label_plane_type_title";
            this.label_plane_type_title.Size = new System.Drawing.Size(86, 18);
            this.label_plane_type_title.TabIndex = 14;
            this.label_plane_type_title.Text = "Uçak Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Location = new System.Drawing.Point(114, 779);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 15;
            // 
            // label_plane_type
            // 
            this.label_plane_type.AutoSize = true;
            this.label_plane_type.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_plane_type.Location = new System.Drawing.Point(160, 745);
            this.label_plane_type.Name = "label_plane_type";
            this.label_plane_type.Size = new System.Drawing.Size(124, 20);
            this.label_plane_type.TabIndex = 16;
            this.label_plane_type.Text = "Uçak Tipi Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(738, 746);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seri Numarası";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(683, 780);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 27);
            this.textBox1.TabIndex = 17;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_add.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(1168, 762);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(209, 62);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Kayıt Oluştur";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // PlaneAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_plane_type);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_plane_type_title);
            this.Controls.Add(this.label_plane_title);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "PlaneAddControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.PlaneAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label label_plane_title;
        private System.Windows.Forms.Label label_plane_type_title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_plane_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add;
    }
}
