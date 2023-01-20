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
        private readonly string HvBSNumber;
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IAuthService _authService;
        public MenuPage(string hvBSNumber,IUserService userService, IRecordService recordService, IUserOperationClaimService userOperationClaimService, IAuthService authService)
        {
            InitializeComponent();
            HvBSNumber = hvBSNumber;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _recordService = recordService;
            _authService = authService;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            User user = _userService.GetByHvBSNumber(HvBSNumber).Data;
            label_name.Text = user.FirstName + @" " + user.LastName.ToUpper();
            label_rank.Text = user.Rank;
            label_HvBS.Text = $"HvBS No: {user.HvBSNumber}";
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
            DashboardPage dashboardPage = new DashboardPage(HvBSNumber,_userService,_recordService,_userOperationClaimService,_authService);
            Hide();
            dashboardPage.ShowDialog();
            Close();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(_authService, _userService, _userOperationClaimService, _recordService);
            Hide();
            loginPage.ShowDialog();
            Close();
        }
    }
}
