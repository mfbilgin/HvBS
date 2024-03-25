namespace FormUI.UserControls.ViewControls
{
    partial class PartStatusControl
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_stock_status = new System.Windows.Forms.Label();
            this.label_stock_status_title = new System.Windows.Forms.Label();
            this.label_waiting_aircraft = new System.Windows.Forms.Label();
            this.label_part_number_title = new System.Windows.Forms.Label();
            this.label_part_number = new System.Windows.Forms.Label();
            this.groupBox12651 = new System.Windows.Forms.GroupBox();
            this.label_waiting_aircraft_title = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox12651.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // label_stock_status
            // 
            this.label_stock_status.AutoSize = true;
            this.label_stock_status.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_stock_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_stock_status.Location = new System.Drawing.Point(551, 18);
            this.label_stock_status.Name = "label_stock_status";
            this.label_stock_status.Size = new System.Drawing.Size(92, 21);
            this.label_stock_status.TabIndex = 0;
            this.label_stock_status.Text = "19.10.2023";
            // 
            // label_stock_status_title
            // 
            this.label_stock_status_title.AutoSize = true;
            this.label_stock_status_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_stock_status_title.Location = new System.Drawing.Point(545, 10);
            this.label_stock_status_title.Name = "label_stock_status_title";
            this.label_stock_status_title.Size = new System.Drawing.Size(114, 18);
            this.label_stock_status_title.TabIndex = 11;
            this.label_stock_status_title.Text = "Stok Durumu";
            // 
            // label_waiting_aircraft
            // 
            this.label_waiting_aircraft.AutoSize = true;
            this.label_waiting_aircraft.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_waiting_aircraft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_waiting_aircraft.Location = new System.Drawing.Point(336, 18);
            this.label_waiting_aircraft.Name = "label_waiting_aircraft";
            this.label_waiting_aircraft.Size = new System.Drawing.Size(52, 21);
            this.label_waiting_aircraft.TabIndex = 0;
            this.label_waiting_aircraft.Text = "Arıza";
            // 
            // label_part_number_title
            // 
            this.label_part_number_title.AutoSize = true;
            this.label_part_number_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_part_number_title.Location = new System.Drawing.Point(101, 10);
            this.label_part_number_title.Name = "label_part_number_title";
            this.label_part_number_title.Size = new System.Drawing.Size(89, 18);
            this.label_part_number_title.TabIndex = 6;
            this.label_part_number_title.Text = "Parça NO.";
            // 
            // label_part_number
            // 
            this.label_part_number.AutoSize = true;
            this.label_part_number.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_part_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.label_part_number.Location = new System.Drawing.Point(123, 18);
            this.label_part_number.Name = "label_part_number";
            this.label_part_number.Size = new System.Drawing.Size(79, 21);
            this.label_part_number.TabIndex = 0;
            this.label_part_number.Text = "Uçak No";
            // 
            // groupBox12651
            // 
            this.groupBox12651.Controls.Add(this.label_stock_status);
            this.groupBox12651.Controls.Add(this.label_waiting_aircraft);
            this.groupBox12651.Controls.Add(this.label_part_number);
            this.groupBox12651.Location = new System.Drawing.Point(3, 3);
            this.groupBox12651.Name = "groupBox12651";
            this.groupBox12651.Size = new System.Drawing.Size(1604, 60);
            this.groupBox12651.TabIndex = 0;
            this.groupBox12651.TabStop = false;
            // 
            // label_waiting_aircraft_title
            // 
            this.label_waiting_aircraft_title.AutoSize = true;
            this.label_waiting_aircraft_title.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_waiting_aircraft_title.Location = new System.Drawing.Point(306, 10);
            this.label_waiting_aircraft_title.Name = "label_waiting_aircraft_title";
            this.label_waiting_aircraft_title.Size = new System.Drawing.Size(154, 18);
            this.label_waiting_aircraft_title.TabIndex = 7;
            this.label_waiting_aircraft_title.Text = "Bekleyen Uçak No";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Snow;
            this.flowLayoutPanel.Controls.Add(this.groupBox12651);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 31);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1610, 908);
            this.flowLayoutPanel.TabIndex = 5;
            // 
            // PartStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_stock_status_title);
            this.Controls.Add(this.label_part_number_title);
            this.Controls.Add(this.label_waiting_aircraft_title);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "PartStatusControl";
            this.Size = new System.Drawing.Size(1610, 949);
            this.Load += new System.EventHandler(this.PartStatusControl_Load);
            this.groupBox12651.ResumeLayout(false);
            this.groupBox12651.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_stock_status;
        private System.Windows.Forms.Label label_stock_status_title;
        private System.Windows.Forms.Label label_waiting_aircraft;
        private System.Windows.Forms.Label label_part_number_title;
        private System.Windows.Forms.Label label_part_number;
        private System.Windows.Forms.GroupBox groupBox12651;
        private System.Windows.Forms.Label label_waiting_aircraft_title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
