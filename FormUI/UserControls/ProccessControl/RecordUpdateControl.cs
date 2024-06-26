﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;
using FormUI.Forms;
using FormUI.Properties;

namespace FormUI.UserControls.ProccessControl
{
    public partial class RecordUpdateControl : UserControl
    {

        private readonly IRecordService _recordService;
        private readonly IUserService _userService;
        private readonly IPlaneService _planeService;
        private readonly IPartService _partService;
        private readonly Base _base;

        public RecordUpdateControl(IRecordService recordService, Base @base, IUserService userService, IPartService partService, IPlaneService planeService)
        {
            InitializeComponent();
            _recordService = recordService;
            _base = @base;
            _userService = userService;
            _partService = partService;
            _planeService = planeService;
        }

        private void RecordUpdateControl_Load(object sender, EventArgs e)
        {
            var records = _recordService.GetAll(_base.BaseId).Data;


            if (records.Count != 0)
            {
                flowLayoutPanel.Controls.Clear();
                foreach (Record record in records)
                {
                    var index = records.IndexOf(record);

                    var groupBox = new GroupBox()
                    {
                        Name = $"groupBox_{index}",
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    var button = new Button()
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
                    var buttonUpdate = new Button()
                    {
                        Image = Resources.icons8_update_32,
                        Height = 38,
                        Width = 38,
                        Location = new Point(1559, groupBox.Size.Height / 2 - 15),
                        Text = $@"{index}",
                        ForeColor = Color.Snow,
                        Font = new Font(FontFamily.GenericSansSerif, 1.0F)
                    };
                    var labelAircraftNumber = new Label()
                    {
                        Name = $"label_aircraft_number_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelTrouble = new TextBox()
                    {
                        Name = $"label_trouble_{index}",
                        Multiline = true,
                        BorderStyle = BorderStyle.None,
                        ReadOnly = true,
                        Size = new Size(181, 21),
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        BackColor = Color.Snow,
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelRegisterDate = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelEstimatedDate = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelPartsNeed = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelRegisterStaff = new Label()
                    {
                        Name = $"label_register_staff_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelIdentifyStaff = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152)
                    };

                    labelAircraftNumber.Text = record.AircraftSerialNumber;
                    SetLocation(labelAircraftNumber, label_aircraft_title, groupBox);

                    labelTrouble.Text = record.Trouble;
                    SetLocation(labelTrouble, label_trouble_title, groupBox);

                    labelRegisterDate.Text = record.RegisterDate.ToString("dd.MM.yy");
                    SetLocation(labelRegisterDate, label_register_date_title, groupBox);

                    labelEstimatedDate.Text = record.EstimatedEndDate == DateTime.MinValue
                        ? "Belirtilmemiş"
                        : record.EstimatedEndDate.ToString("dd.MM.yy");
                    SetLocation(labelEstimatedDate, label_estimated_date_title, groupBox);

                    labelPartsNeed.Text = record.PartsNeed ?? "YOK";
                    SetLocation(labelPartsNeed, label_parts_need_title, groupBox);

                    labelRegisterStaff.Text = record.StaffOfRecording;
                    SetLocation(labelRegisterStaff, label_register_staff_title, groupBox);
                    labelIdentifyStaff.Text = record.StaffOfIdentifyTrouble ?? "Belirtilmemiş";
                    SetLocation(labelIdentifyStaff, label_identify_staff_title, groupBox);

                    buttonUpdate.Click += button_update_click;


                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(labelAircraftNumber);
                    groupBox.Controls.Add(labelTrouble);
                    groupBox.Controls.Add(labelRegisterDate);
                    groupBox.Controls.Add(labelEstimatedDate);
                    groupBox.Controls.Add(labelPartsNeed);
                    groupBox.Controls.Add(labelRegisterStaff);
                    groupBox.Controls.Add(labelIdentifyStaff);
                    groupBox.Controls.Add(buttonUpdate);
                }
            }
            else
            {
                flowLayoutPanel.Visible = false;
                var groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 897,
                };
                var labelNotFound = new Label()
                {
                    Text = @"Herhangi Bir Kayıt Bulunamadı",
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 40.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                    Location = new Point(339, 407)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(labelNotFound);
            }
        }

        private static void SetLocation(Control content, Control title, Control container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Size.Width - content.Size.Width) / 2,
                    container.Height / 2 - 12);
            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Size.Width - title.Size.Width) / 2,
                    container.Height / 2 - 12);
            }
        }

        private void button_update_click(object sender, EventArgs e)
        {
            var senderAsString = sender.ToString();
            var name = sender.ToString()!.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var aircraftNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"]
                .Controls[$"label_aircraft_number_{name}"].Text;
            var trouble = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"].Controls[$"label_trouble_{name}"]
                .Text;
            var recordUpdateForm = new RecordUpdateForm(aircraftNumber, trouble, _recordService,_base,_userService,_partService,_planeService);
            recordUpdateForm.ShowDialog();
            RecordUpdateControl_Load(sender, e);
        }
    }
}