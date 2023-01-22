using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class MenuPage : Form
    {
        private readonly string _hvBsNumber;
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IPartStatusService _partStatusService;
        private readonly IAuthService _authService;
        public MenuPage(string hvBsNumber,IUserService userService, IRecordService recordService, IUserOperationClaimService userOperationClaimService, IAuthService authService,IPartStatusService partStatusService)
        {
            InitializeComponent();
            _hvBsNumber = hvBsNumber;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _recordService = recordService;
            _authService = authService;
            _partStatusService = partStatusService;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            User user = _userService.GetByHvBSNumber(_hvBsNumber).Data;
            label_name.Text = user.FirstName + @" " + user.LastName.ToUpper();
            label_rank.Text = user.Rank;
            label_HvBS.Text = $@"HvBS No: {user.HvBSNumber}";
            label_emergency_record_number.Text = _recordService.GetAllEmergencyRecord().Data.Count.ToString();
            label_ongoing_care_record_number.Text = _recordService.GetAllContinuingRecord().Data.Count.ToString();
            label_waiting_care_record_number.Text = _recordService.GetAllWaitingRecord().Data.Count.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_emergency_record_Click(object sender, EventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage(_hvBsNumber,_userService,_recordService,_userOperationClaimService,_authService,_partStatusService);
            Hide();
            dashboardPage.ShowDialog();
            Close();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(_authService, _userService, _userOperationClaimService, _recordService, _partStatusService);
            Hide();
            loginPage.ShowDialog();
            Close();
        }
    }
}
