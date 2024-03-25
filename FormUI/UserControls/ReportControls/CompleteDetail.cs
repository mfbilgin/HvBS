using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace FormUI.UserControls.ReportControls
{
    public partial class CompleteDetail : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly IUserService _userService;
        private readonly Base _base;
        private List<User> _users;

        public CompleteDetail(IRecordService recordService, Base @base, IUserService userService)
        {
            InitializeComponent();
            _recordService = recordService;
            _base = @base;
            _userService = userService;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CompleteDetail_Load(sender, e);
        }

        private void CompleteDetail_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            _users = _userService.GetAll().Data;
            GenerateCompletedRecordView();
            GenerateCompleteCountByUser();
            GenerateCompleteCountByChef();
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            var form = FindForm();
            var panelControls = (Panel)Parent;
            panelControls.Controls.Clear();
            var button = (Button)form!.Controls.Find("button_reports", true)[0];
            button.PerformClick();
        }

        private void SetLocation(Control content, Label title, GroupBox container)
        {
            content.Location = new Point(title.Location.X, container.Height / 2);
        }

        private void GenerateCompletedRecordView()
        {
            var records = _recordService.GetAllCompletedRecordInLastTime(_base.BaseId, 24).Data;
            if (records.Count > 0)
            {
                flowLayoutPanel_Complete.Controls.Clear();
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
                        Location = new Point(0, groupBox.Size.Height / 2),
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
                        Size = new Size(181, 21),
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        BackColor = Color.Snow,
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelCompletedDate = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelMaintenanceTime = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    var labelCompleteStaff = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelMaintenanceChef = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    labelAircraftNumber.Text = record.AircraftSerialNumber;
                    SetLocation(labelAircraftNumber, label_aircraft_title, groupBox);

                    labelTrouble.Text = record.Trouble;
                    SetLocation(labelTrouble, label_trouble_title, groupBox);

                    labelCompletedDate.Text = record.RegisterDate.ToString("dd.MM.yy");
                    SetLocation(labelCompletedDate, label_completed_date_title, groupBox);

                    labelMaintenanceTime.Text = (record.CompleteDate - record.RegisterDate).ToString();
                    SetLocation(labelMaintenanceTime, label_maintenance_time_title, groupBox);

                    var user = _userService.GetByUserId(record.CompletedUserId).Data;
                    labelCompleteStaff.Text = user.FirstName + @" " + user.LastName;
                    SetLocation(labelCompleteStaff, label_complete_staff_title, groupBox);

                    labelMaintenanceChef.Text = record.MaintenanceChief;
                    SetLocation(labelMaintenanceChef, label_maintenance_cheif_title, groupBox);

                    flowLayoutPanel_Complete.Controls.Add(groupBox);
                    groupBox.Controls.Add(button);
                    groupBox.Controls.Add(labelAircraftNumber);
                    groupBox.Controls.Add(labelTrouble);
                    groupBox.Controls.Add(labelCompletedDate);
                    groupBox.Controls.Add(labelMaintenanceTime);
                    groupBox.Controls.Add(labelCompleteStaff);
                    groupBox.Controls.Add(labelMaintenanceChef);
                }
            }
            else
            {
                CreateNotFoundLabel(flowLayoutPanel_Complete, 1575, 500);
            }
        }

        private void GenerateCompleteCountByUser()
        {
            var records = _recordService.GetAllCompletedRecord(_base.BaseId).Data;
            flowLayoutPanel_Complete_Count.Controls.Clear();

            //Kayıt var mı kontrolü
            if (records.Count > 0)
            {
                //Her bir kullanıcı için kayıt sayısını al ve 0'dan büyükse göster
                foreach (var user in _users)
                {
                    var count = _recordService.GetAllCompletedRecordByCompletedUser(_base.BaseId, user.UserId).Data
                        .Count;

                    if (count <= 0) continue;
                    //Generate controls
                    var groupBox = new GroupBox()
                    {
                        Text = "",
                        Width = 470,
                        Height = 60,
                    };
                    var labelUserName = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelCompleteCount = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    // Set controls
                    labelUserName.Text = user.FirstName + @" " + user.LastName;
                    SetLocation(labelUserName, label_user_name_title, groupBox);

                    labelCompleteCount.Text = count.ToString();
                    labelCompleteCount.Location = new Point(307, 23);
                    // Add controls
                    flowLayoutPanel_Complete_Count.Controls.Add(groupBox);
                    groupBox.Controls.Add(labelUserName);
                    groupBox.Controls.Add(labelCompleteCount);
                }
            }
            else
            {
                CreateNotFoundLabel(flowLayoutPanel_Complete_Count, 470, 360);
            }
        }

        private void GenerateCompleteCountByChef()
        {
            var records = _recordService.GetAllCompletedRecord(_base.BaseId).Data;

            flowLayoutPanel_Chef_Count.Controls.Clear();

            //Kayıt var mı kontrolü
            if (records.Count > 0)
            {
                //Her bir kullanıcı için kayıt sayısını al ve 0'dan büyükse göster
                foreach (var user in _users)
                {
                    var name = user.FirstName + @" " + user.LastName.ToUpper();
                    var count = _recordService.GetAllCompletedRecordByMaintenanceChef(_base.BaseId, name).Data
                        .Count;

                    if (count <= 0) continue;
                    //Generate controls
                    var groupBox = new GroupBox()
                    {
                        Text = "",
                        Width = 470,
                        Height = 60,
                    };
                    var labelChefName = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelRecordCount = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    // Set controls
                    labelChefName.Text = name;
                    labelChefName.Location = new Point(54, 23);

                    labelRecordCount.Text = count.ToString();
                    labelRecordCount.Location = new Point(307, 23);
                    // Add controls
                    flowLayoutPanel_Chef_Count.Controls.Add(groupBox);
                    groupBox.Controls.Add(labelChefName);
                    groupBox.Controls.Add(labelRecordCount);
                }
            }
            else
            {
                CreateNotFoundLabel(flowLayoutPanel_Chef_Count, 470, 360);
            }
        }

        private static void CreateNotFoundLabel(FlowLayoutPanel flowLayoutPanel, int width, int height)
        {
            flowLayoutPanel.Controls.Clear();
            var groupBox = new GroupBox()
            {
                Text = "",
                Width = width,
                Height = height,
            };
            var labelNotFound = new Label()
            {
                Text = @"Herhangi Bir Kayıt Bulunamadı",
                AutoSize = true,
                Font = new Font(FontFamily.GenericSansSerif, 16.0F),
                ForeColor = Color.FromArgb(152, 152, 152),
                Location = new Point(groupBox.Size.Width / 2 - 200, groupBox.Size.Height / 2 - 20)
            };
            flowLayoutPanel.Controls.Add(groupBox);
            groupBox.Controls.Add(labelNotFound);
        }
    }
}