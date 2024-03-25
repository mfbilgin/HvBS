using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;

namespace FormUI.UserControls.ViewControls
{
    public partial class EmergencyRecordControl : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly Base _base;
        public EmergencyRecordControl(IRecordService recordService,Base @base)
        {
            InitializeComponent();
            _recordService = recordService;
            _base = @base;  
        }

        private void EmergencyRecordControl_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            var records = _recordService.GetAllEmergencyRecord(_base.BaseId).Data;
            if (records.Count > 0)
            {


                flowLayoutPanel.Controls.Clear();
                foreach (var record in records)
                {
                    var groupBox = new GroupBox()
                    {
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    var button = new Button()
                    {
                        BackColor = Color.Red,
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(20, groupBox.Size.Height / 2),
                        Width = 21,
                        Height = 21,
                        Text = ""
                    };
                    var labelAircraftNumber = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelTrouble = new TextBox()
                    {
                        Multiline = true,
                        BorderStyle = BorderStyle.None,
                        ReadOnly = true,
                        Size = new Size(181,21),
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
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelIdentifyStaff = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    labelAircraftNumber.Text = record.AircraftSerialNumber;
                    SetLocation(labelAircraftNumber, label_aircraft_title, groupBox);

                    labelTrouble.Text = record.Trouble;
                    SetLocation(labelTrouble, label_trouble_title, groupBox);

                    labelRegisterDate.Text = record.RegisterDate.ToString("dd.MM.yy");
                    SetLocation(labelRegisterDate, label_register_date_title, groupBox);

                    labelEstimatedDate.Text = record.EstimatedEndDate == DateTime.MinValue ? "Belirtilmemiş" : record.EstimatedEndDate.ToString("dd.MM.yy");
                    SetLocation(labelEstimatedDate, label_estimated_date_title, groupBox);

                    labelPartsNeed.Text = record.PartsNeed ?? "YOK";
                    SetLocation(labelPartsNeed, label_parts_need_title, groupBox);
                    labelRegisterStaff.Text = record.StaffOfRecording;
                    SetLocation(labelRegisterStaff, label_register_staff_title, groupBox);
                    labelIdentifyStaff.Text = record.StaffOfIdentifyTrouble ?? "Belirtilmemiş";
                    SetLocation(labelIdentifyStaff, label_identify_staff_title, groupBox);



                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(labelAircraftNumber);
                    groupBox.Controls.Add(labelTrouble);
                    groupBox.Controls.Add(labelRegisterDate);
                    groupBox.Controls.Add(labelEstimatedDate);
                    groupBox.Controls.Add(labelPartsNeed);
                    groupBox.Controls.Add(labelRegisterStaff);
                    groupBox.Controls.Add(labelIdentifyStaff);
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
            content.Location = new Point(title.Location.X, container.Height / 2);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            EmergencyRecordControl_Load(sender, e);
        }
    }
}
