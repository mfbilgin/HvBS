namespace FormUI.UserControls.ViewControls
{
    partial class ReportControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_emergency = new System.Windows.Forms.Label();
            this.label_ongoing = new System.Windows.Forms.Label();
            this.label_completed = new System.Windows.Forms.Label();
            this.label_waiting = new System.Windows.Forms.Label();
            this.label_complete_title = new System.Windows.Forms.Label();
            this.label_emergency_title = new System.Windows.Forms.Label();
            this.label_ongonig_title = new System.Windows.Forms.Label();
            this.label_waiting_title = new System.Windows.Forms.Label();
            this.button_complete_detail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button_complete_detail);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1610, 949);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_emergency);
            this.groupBox1.Controls.Add(this.label_ongoing);
            this.groupBox1.Controls.Add(this.label_completed);
            this.groupBox1.Controls.Add(this.label_waiting);
            this.groupBox1.Controls.Add(this.label_complete_title);
            this.groupBox1.Controls.Add(this.label_emergency_title);
            this.groupBox1.Controls.Add(this.label_ongonig_title);
            this.groupBox1.Controls.Add(this.label_waiting_title);
            this.groupBox1.Location = new System.Drawing.Point(147, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label_emergency
            // 
            this.label_emergency.AutoSize = true;
            this.label_emergency.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_emergency.Location = new System.Drawing.Point(1133, 85);
            this.label_emergency.Name = "label_emergency";
            this.label_emergency.Size = new System.Drawing.Size(76, 31);
            this.label_emergency.TabIndex = 5;
            this.label_emergency.Text = "label5";
            // 
            // label_ongoing
            // 
            this.label_ongoing.AutoSize = true;
            this.label_ongoing.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ongoing.Location = new System.Drawing.Point(821, 85);
            this.label_ongoing.Name = "label_ongoing";
            this.label_ongoing.Size = new System.Drawing.Size(76, 31);
            this.label_ongoing.TabIndex = 5;
            this.label_ongoing.Text = "label5";
            // 
            // label_completed
            // 
            this.label_completed.AutoSize = true;
            this.label_completed.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_completed.Location = new System.Drawing.Point(472, 101);
            this.label_completed.Name = "label_completed";
            this.label_completed.Size = new System.Drawing.Size(76, 31);
            this.label_completed.TabIndex = 4;
            this.label_completed.Text = "label4";
            // 
            // label_waiting
            // 
            this.label_waiting.AutoSize = true;
            this.label_waiting.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_waiting.Location = new System.Drawing.Point(135, 96);
            this.label_waiting.Name = "label_waiting";
            this.label_waiting.Size = new System.Drawing.Size(76, 31);
            this.label_waiting.TabIndex = 3;
            this.label_waiting.Text = "label3";
            // 
            // label_complete_title
            // 
            this.label_complete_title.AutoSize = true;
            this.label_complete_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_complete_title.Location = new System.Drawing.Point(411, 32);
            this.label_complete_title.Name = "label_complete_title";
            this.label_complete_title.Size = new System.Drawing.Size(199, 38);
            this.label_complete_title.TabIndex = 2;
            this.label_complete_title.Text = "Tamamlanmış";
            // 
            // label_emergency_title
            // 
            this.label_emergency_title.AutoSize = true;
            this.label_emergency_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_emergency_title.Location = new System.Drawing.Point(1105, 21);
            this.label_emergency_title.Name = "label_emergency_title";
            this.label_emergency_title.Size = new System.Drawing.Size(141, 38);
            this.label_emergency_title.TabIndex = 1;
            this.label_emergency_title.Text = "Acil Kayıt";
            // 
            // label_ongonig_title
            // 
            this.label_ongonig_title.AutoSize = true;
            this.label_ongonig_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ongonig_title.Location = new System.Drawing.Point(793, 21);
            this.label_ongonig_title.Name = "label_ongonig_title";
            this.label_ongonig_title.Size = new System.Drawing.Size(132, 38);
            this.label_ongonig_title.TabIndex = 1;
            this.label_ongonig_title.Text = "Bakımda";
            // 
            // label_waiting_title
            // 
            this.label_waiting_title.AutoSize = true;
            this.label_waiting_title.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_waiting_title.Location = new System.Drawing.Point(33, 32);
            this.label_waiting_title.Name = "label_waiting_title";
            this.label_waiting_title.Size = new System.Drawing.Size(281, 38);
            this.label_waiting_title.TabIndex = 0;
            this.label_waiting_title.Text = "Bakım için Bekleyen";
            // 
            // button_complete_detail
            // 
            this.button_complete_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(137)))));
            this.button_complete_detail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_complete_detail.ForeColor = System.Drawing.SystemColors.Window;
            this.button_complete_detail.Location = new System.Drawing.Point(701, 593);
            this.button_complete_detail.Name = "button_complete_detail";
            this.button_complete_detail.Size = new System.Drawing.Size(209, 89);
            this.button_complete_detail.TabIndex = 1;
            this.button_complete_detail.Text = "Kayıt Tamamlama Detayları";
            this.button_complete_detail.UseVisualStyleBackColor = false;
            this.button_complete_detail.Click += new System.EventHandler(this.button_complete_detail_Click);
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_complete_detail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_ongoing;
        private System.Windows.Forms.Label label_completed;
        private System.Windows.Forms.Label label_waiting;
        private System.Windows.Forms.Label label_complete_title;
        private System.Windows.Forms.Label label_ongonig_title;
        private System.Windows.Forms.Label label_waiting_title;
        private System.Windows.Forms.Label label_emergency;
        private System.Windows.Forms.Label label_emergency_title;
    }
}
