using Business.Abstract;
using Core.Entities.Concrete;
using FormUI.UserControls;
using FormUI.UserControls.ProccessControl;
using FormUI.UserControls.ViewControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class DashboardPage : Form
    {
        private readonly string HvBSNumber;
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IPartStatusService _partStatusService;
        private readonly IAuthService _authService;
        private readonly int _claimId;
        private bool isCollapsed = true;
        public DashboardPage(string hvBSNumber, IUserService userService, IRecordService recordService,IUserOperationClaimService userOperationClaimService, IAuthService authService, IPartStatusService partStatusService)
        {
            InitializeComponent();
            HvBSNumber = hvBSNumber;
            _userService = userService;
            _recordService = recordService;
            _userOperationClaimService = userOperationClaimService;
            _authService = authService;
            _claimId = _userOperationClaimService.GetByUserId(_userService.GetByHvBSNumber(hvBSNumber).Data.UserId).Data.OperationClaimId;
            _partStatusService = partStatusService;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            User user = _userService.GetByHvBSNumber(HvBSNumber).Data;
            label_name.Text = user.FirstName + @" " + user.LastName.ToUpper();
            label_rank.Text = user.Rank;
            label_HvBS.Text = $"HvBS No: {user.HvBSNumber}";
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_close_dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_emergency_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_emergency_record);
            AddControls(new EmergencyRecordControl(_recordService));
        }
        private void AddControls(UserControl userControl)
        {
            panel_controls.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel_controls.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_dropdown.Height += 10;
                if (panel_dropdown.Size == panel_dropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                panel_dropdown.Height -= 10;
                if (panel_dropdown.Size == panel_dropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            } 
        }

        private void button_record_proccess_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button_add_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_add_record);
            AddControls(new RecordAddControl(_recordService,HvBSNumber,_userService,_userOperationClaimService));
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(_authService, _userService, _userOperationClaimService, _recordService,_partStatusService);
            Hide();
            loginPage.ShowDialog();
            Close();
        }

        private void button_countuing_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_countuing);
            AddControls(new OngoingMaintenanceRecordControl(_recordService));
        }
       

        private void button_waiting_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_waiting_record);
            AddControls(new WaitingRecordControl(_recordService));
        }
        private void SetButtonColor(Button selectedButton)
        {
            button_emergency_record.BackColor = Color.FromArgb(53, 67, 137);
            button_countuing.BackColor = Color.FromArgb(53, 67, 137);
            button_waiting_record.BackColor = Color.FromArgb(53, 67, 137);
            button_parts_status.BackColor = Color.FromArgb(53, 67, 137);
            button_completed_record.BackColor = Color.FromArgb(53, 67, 137);
            button_maintance_settings.BackColor = Color.FromArgb(53, 67, 137);
            button_reports.BackColor = Color.FromArgb(53, 67, 137);
            button_add_record.BackColor = Color.FromArgb(53, 67, 137);
            button_update_record.BackColor = Color.FromArgb(53, 67, 137);
            button_delete_record.BackColor = Color.FromArgb(53, 67, 137);
            selectedButton.BackColor = Color.Black;
        }

        private void button_update_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_update_record);
            AddControls(new RecordUpdateControl(_recordService,_claimId));
        }

        private void button_delete_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_delete_record);
            AddControls(new RecordDeleteControl(_recordService, _claimId));
        }

        private void button_completed_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_completed_record);
            AddControls(new CompletedRecordControl(_recordService));
        }

        private void button_part_need_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_part_need);
            AddControls(new PartAddControl(_partStatusService,_claimId));
        }
    }
}
