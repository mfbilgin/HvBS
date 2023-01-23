using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using FormUI.Forms;
using FormUI.Properties;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormUI.UserControls
{
    public partial class RecordUpdateControl : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly int _claimId;
        public RecordUpdateControl(IRecordService recordService, int claimId)
        {
            InitializeComponent();
            _recordService = recordService;
            _claimId = claimId;
        }

        private void RecordUpdateControl_Load(object sender, EventArgs e)
        {
            List<Record> records = _recordService.GetAll().Data;

            
            if (records.Count != 0)
            {
                flowLayoutPanel.Controls.Clear();
                foreach (Record record in records)
                {
                    int index = records.IndexOf(record);
                    GroupBox groupBox = new GroupBox()
                    {
                        Name = $"groupBox_{index}",
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    Button button = new Button()
                    {
                        Name = $"button_emergency_{index}",
                        BackColor = record.IsEmergency ? Color.Red : Color.Snow,
                        FlatStyle = FlatStyle.Flat,
                        Width = 27,
                        Height = 27,
                        Location = new Point(20, groupBox.Size.Height / 2 - 15),
                        Enabled = false,
                        Text = ""
                    };
                    Button button_update = new Button()
                    {
                        Image = Resources.icons8_update_32,
                        Height = 38,
                        Width = 38,
                        Location = new System.Drawing.Point(1559, groupBox.Size.Height / 2 - 15),
                        Text = $"{index}",
                        ForeColor = Color.Snow,
                        Font = new Font(FontFamily.GenericSansSerif, 1.0F)

                    };
                    Label label_aircraft_number = new Label()
                    {
                        Name = $"label_aircraft_number_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_trouble = new Label()
                    {
                        Name = $"label_trouble_{index}",
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
                        Name = $"label_register_staff_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_identify_staff = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152)
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
                    SetLocation(label_identify_staff, label_identify_staff_title, groupBox);

                    button_update.Click += new EventHandler(button_update_click);


                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(label_aircraft_number);
                    groupBox.Controls.Add(label_trouble);
                    groupBox.Controls.Add(label_register_date);
                    groupBox.Controls.Add(label_estimated_date);
                    groupBox.Controls.Add(label_parts_need);
                    groupBox.Controls.Add(label_register_staff);
                    groupBox.Controls.Add(label_identify_staff);
                    groupBox.Controls.Add(button_update);
                }
            }
            else
            {
                flowLayoutPanel.Visible = false;
                GroupBox groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 897,
                };
                Label label_not_found = new Label()
                {
                    Text = "Herhangi Bir Kayıt Bulunamadı",
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 40.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                    Location = new Point(339, 407)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(label_not_found);
            }
        }
        private void SetLocation(Label content, Label title, GroupBox container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Size.Width - content.Size.Width) / 2, container.Height / 2 - 12);

            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Size.Width - title.Size.Width) / 2, container.Height / 2 - 12);
            }
        }

        private void button_update_click(object sender, EventArgs e)
        {
            string name = sender.ToString().ToCharArray()[sender.ToString().Length - 1].ToString();
            string aircraftNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"].Controls[$"label_aircraft_number_{name}"].Text;
            string trouble = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"].Controls[$"label_trouble_{name}"].Text;
            RecordUpdateForm recordUpdateForm = new RecordUpdateForm(aircraftNumber, trouble, _recordService, _claimId);
            recordUpdateForm.ShowDialog();
        }

    }
}
