using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;
using FormUI.Properties;

namespace FormUI.UserControls.ViewControls
{
    public partial class OngoingMaintenanceRecordControl : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly Base _base;
        private readonly int _userId;
        public OngoingMaintenanceRecordControl(IRecordService recordService, int userId, Base @base)
        {
            InitializeComponent();
            _recordService = recordService;
            _userId = userId;
            _base = @base;
        }

        private void OngoingMaintenanceRecordControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            List<Record> records = _recordService.GetAllContinuingRecord(_base.BaseId).Data;
            if (records.Count > 0)
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
                        BackColor = record.IsEmergency ? Color.Red : Color.Snow,
                        FlatStyle = FlatStyle.Flat,
                        Location = new Point(20, groupBox.Size.Height / 2),
                        Width = 21,
                        Height = 21,
                        Text = ""
                    };
                    var buttonMoveToCompleted = new Button()
                    {
                        Image = Resources.icons8_task_completed_32,
                        Height = 38,
                        Width = 38,
                        Location = new Point(1559, groupBox.Size.Height / 2 - 15),
                        Text = $@"{index}",
                        ForeColor = Color.Snow,
                        Font = new Font(FontFamily.GenericSansSerif, 1.0F),
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
                    var labelMaintenanceCheif = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    toolTip1.SetToolTip(buttonMoveToCompleted, "Tamamla");

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

                    labelMaintenanceCheif.Text = record.MaintenanceChief;
                    SetLocation(labelMaintenanceCheif, label_identify_staff_title, groupBox);

                    buttonMoveToCompleted.Click += button_move_to_completed_Click;

                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(labelAircraftNumber);
                    groupBox.Controls.Add(labelTrouble);
                    groupBox.Controls.Add(labelRegisterDate);
                    groupBox.Controls.Add(labelEstimatedDate);
                    groupBox.Controls.Add(labelPartsNeed);
                    groupBox.Controls.Add(labelRegisterStaff);
                    groupBox.Controls.Add(labelMaintenanceCheif);
                    groupBox.Controls.Add(buttonMoveToCompleted);
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

        private void button_move_to_completed_Click(object sender, EventArgs e)
        {
            var name = sender.ToString()?.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var aircraftNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"].Controls[$"label_aircraft_number_{name}"].Text;
            var trouble = Controls["flowLayoutPanel"].Controls[$"groupBox_{name}"].Controls[$"label_trouble_{name}"].Text;
            var record = _recordService.GetByAircraftNumberAndTrouble(aircraftNumber, trouble).Data;
            record.IsCompleted = true;
            record.CompleteDate = DateTime.Now;
            record.CompletedUserId = _userId;
            _recordService.Update(record);
            MessageBox.Show(@"Tamamlanmış Kayıtlara Taşındı");
            OngoingMaintenanceRecordControl_Load(sender, e);
        }

        private static void SetLocation(Control content, Control title, Control container)
        {
            content.Location = new Point(title.Location.X, container.Height / 2);
        }
    }
}
