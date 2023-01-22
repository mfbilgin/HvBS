using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.UserControls
{
    public partial class EmergencyRecordControl : UserControl
    {
        private IRecordService _recordService;
        public EmergencyRecordControl(IRecordService recordService)
        {
            InitializeComponent();
            _recordService = recordService;
        }

        private void EmergencyRecordControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            List<Record> records = _recordService.GetAllEmergencyRecord().Data;

            flowLayoutPanel.Controls.Clear();
            foreach (Record record in records)
            {
                GroupBox groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 60,
                };
                Button button = new Button()
                {
                    BackColor = Color.Red,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(20, groupBox.Size.Height/2),
                    Width = 21,
                    Height = 21,
                    Text = ""
                };
                Label label_aircraft_number = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152,152,152),
                };
                Label label_trouble = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };
                Label label_register_date = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };
                Label label_estimated_date = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };
                Label label_parts_need = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };
                Label label_register_staff = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };
                Label label_identify_staff = new Label()
                {
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                };

                label_aircraft_number.Text = record.AircraftSerialNumber;
                SetLocation(label_aircraft_number, label_aircraft_title, groupBox);

                label_trouble.Text = record.Trouble;
                SetLocation(label_trouble, label_trouble_title, groupBox);

                label_register_date.Text = record.RegisterDate.ToString("dd.MM.yy");
                SetLocation(label_register_date, label_register_date_title, groupBox);

                label_estimated_date.Text = record.EstimatedEndDate == DateTime.MinValue ? "Belirtilmemiş" : record.EstimatedEndDate.ToString("dd.MM.yy");
                SetLocation(label_estimated_date, label_estimated_date_title, groupBox);

                label_parts_need.Text = record.PartsNeed != null ? record.PartsNeed : "YOK";
                SetLocation(label_parts_need, label_parts_need_title, groupBox);
                label_register_staff.Text = record.StaffOfRecording;
                SetLocation(label_register_staff, label_register_staff_title, groupBox);
                label_identify_staff.Text = record.StaffOfIdentifyTrouble != null ? record.StaffOfIdentifyTrouble : "Belirtilmemiş";
                SetLocation(label_identify_staff, label_identify_staff_title,groupBox);



                flowLayoutPanel.Controls.Add(groupBox);
                groupBox.Controls.Add(button);
                groupBox.Controls.Add(label_aircraft_number);
                groupBox.Controls.Add(label_trouble);
                groupBox.Controls.Add(label_register_date);
                groupBox.Controls.Add(label_estimated_date);
                groupBox.Controls.Add(label_parts_need);
                groupBox.Controls.Add(label_register_staff);
                groupBox.Controls.Add(label_identify_staff);
            }
        }
        private void SetLocation(Label content, Label title,GroupBox container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Width - content.Width) / 2, container.Height/2);

            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Width - title.Width) / 2, container.Height / 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EmergencyRecordControl_Load(new object(),new EventArgs());
        }
    }
}
