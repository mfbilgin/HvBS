using Business.Abstract;
using Entities.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.UserControls.ViewControls
{
    public partial class CompletedRecordControl : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly Base _base;
        public CompletedRecordControl(IRecordService recordService, Base @base)
        {
            InitializeComponent();
            _recordService = recordService;
            _base = @base;
        }

        private void CompletedRecordControl_Load(object sender, EventArgs e)
        {

            timer1.Start();
            var records = _recordService.GetAllCompletedRecord(_base.BaseId).Data;
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
                        BackColor = record.IsEmergency ? Color.Red : Color.Snow,
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(10, groupBox.Size.Height / 2),
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
                    var labelCompletedDate = new Label()
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
                    var labelMaintenanceCheif = new Label()
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

                    labelCompletedDate.Text = record.CompleteDate.ToString("dd.MM.yy");
                    SetLocation(labelCompletedDate, label_completed_date_title, groupBox);

                    labelPartsNeed.Text = record.PartsNeed ?? "YOK";
                    SetLocation(labelPartsNeed, label_parts_need_title, groupBox);

                    labelRegisterStaff.Text = record.StaffOfRecording;
                    SetLocation(labelRegisterStaff, label_register_staff_title, groupBox);

                    labelIdentifyStaff.Text = record.StaffOfIdentifyTrouble != string.Empty ? record.StaffOfIdentifyTrouble : "Belirtilmemiş";
                    SetLocation(labelIdentifyStaff, label_identify_staff_title, groupBox);

                    labelMaintenanceCheif.Text = record.MaintenanceChief;
                    SetLocation(labelMaintenanceCheif, label_maintenance_cheif_title, groupBox);

                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(labelAircraftNumber);
                    groupBox.Controls.Add(labelTrouble);
                    groupBox.Controls.Add(labelRegisterDate);
                    groupBox.Controls.Add(labelCompletedDate);
                    groupBox.Controls.Add(labelPartsNeed);
                    groupBox.Controls.Add(labelRegisterStaff);
                    groupBox.Controls.Add(labelIdentifyStaff);
                    groupBox.Controls.Add(labelMaintenanceCheif);
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
                content.Location = new Point(title.Location.X ,container.Height / 2);
        }
    }
}
