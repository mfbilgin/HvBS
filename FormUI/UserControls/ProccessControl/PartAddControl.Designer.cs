namespace FormUI.UserControls.ProccessControl
{
    partial class PartAddControl
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
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_part_name = new System.Windows.Forms.TextBox();
            this.label_waiting_aircraft_number_title = new System.Windows.Forms.Label();
            this.textBox_part_number = new System.Windows.Forms.TextBox();
            this.label_parts_number_title = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.checkBox_stock_status = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(737, 412);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(245, 66);
            this.button_add.TabIndex = 129;
            this.button_add.Text = "Kayıt Ekle";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_part_name
            // 
            this.textBox_part_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_part_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_part_name.ForeColor = System.Drawing.Color.White;
            this.textBox_part_name.Location = new System.Drawing.Point(737, 218);
            this.textBox_part_name.Name = "textBox_part_name";
            this.textBox_part_name.Size = new System.Drawing.Size(245, 27);
            this.textBox_part_name.TabIndex = 125;
            this.textBox_part_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_waiting_aircraft_number_title
            // 
            this.label_waiting_aircraft_number_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_waiting_aircraft_number_title.AutoSize = true;
            this.label_waiting_aircraft_number_title.Location = new System.Drawing.Point(824, 192);
            this.label_waiting_aircraft_number_title.Name = "label_waiting_aircraft_number_title";
            this.label_waiting_aircraft_number_title.Size = new System.Drawing.Size(71, 20);
            this.label_waiting_aircraft_number_title.TabIndex = 126;
            this.label_waiting_aircraft_number_title.Text = "Parça Adı";
            // 
            // textBox_part_number
            // 
            this.textBox_part_number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_part_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.textBox_part_number.ForeColor = System.Drawing.Color.White;
            this.textBox_part_number.Location = new System.Drawing.Point(153, 218);
            this.textBox_part_number.Name = "textBox_part_number";
            this.textBox_part_number.Size = new System.Drawing.Size(245, 27);
            this.textBox_part_number.TabIndex = 122;
            this.textBox_part_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_parts_number_title
            // 
            this.label_parts_number_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_parts_number_title.AutoSize = true;
            this.label_parts_number_title.Location = new System.Drawing.Point(205, 192);
            this.label_parts_number_title.Name = "label_parts_number_title";
            this.label_parts_number_title.Size = new System.Drawing.Size(140, 20);
            this.label_parts_number_title.TabIndex = 123;
            this.label_parts_number_title.Text = "Parça Seri Numarası";
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(718, 76);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(282, 33);
            this.label_title.TabIndex = 124;
            this.label_title.Text = "Yeni Parça Ekleme";
            // 
            // checkBox_stock_status
            // 
            this.checkBox_stock_status.AutoSize = true;
            this.checkBox_stock_status.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox_stock_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.checkBox_stock_status.Location = new System.Drawing.Point(1247, 213);
            this.checkBox_stock_status.Name = "checkBox_stock_status";
            this.checkBox_stock_status.Size = new System.Drawing.Size(190, 32);
            this.checkBox_stock_status.TabIndex = 130;
            this.checkBox_stock_status.Text = "Stok Durumu";
            this.checkBox_stock_status.UseVisualStyleBackColor = true;
            // 
            // PartAddControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_stock_status);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_part_name);
            this.Controls.Add(this.label_waiting_aircraft_number_title);
            this.Controls.Add(this.textBox_part_number);
            this.Controls.Add(this.label_parts_number_title);
            this.Controls.Add(this.label_title);
            this.Name = "PartAddControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.PartAddControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_part_name;
        private System.Windows.Forms.Label label_waiting_aircraft_number_title;
        private System.Windows.Forms.TextBox textBox_part_number;
        private System.Windows.Forms.Label label_parts_number_title;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.CheckBox checkBox_stock_status;
    }
}
