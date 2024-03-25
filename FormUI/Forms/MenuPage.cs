using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class MenuPage : Form
    {
        private readonly string _hvBsNumber;
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IPartService _partStatusService;
        private readonly IAuthService _authService;
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly IBaseService _baseService;
        private readonly IPlaneService _planeService;
        private readonly Base _base;
        public MenuPage(string hvBsNumber, IUserService userService, IRecordService recordService, IUserOperationClaimService userOperationClaimService, IAuthService authService, IPartService partStatusService, IMaintenanceTypeService maintenanceTypeService, IBaseService baseService, Base @base, IPlaneService planeService)
        {
            InitializeComponent();
            _hvBsNumber = hvBsNumber;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _recordService = recordService;
            _authService = authService;
            _partStatusService = partStatusService;
            _maintenanceTypeService = maintenanceTypeService;
            _baseService = baseService;
            _base = @base;
            _planeService = planeService;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            User user = _userService.GetByHvBsNumber(_hvBsNumber).Data;
            label_name.Text = user.FirstName + @" " + user.LastName.ToUpper();
            label_rank.Text = user.Rank;
            label_HvBS.Text = $@"HvBS No: {user.HvBSNumber}";
            label_emergency_record_number.Text = _recordService.GetAllEmergencyRecord(_base.BaseId).Data.Count.ToString();
            label_ongoing_care_record_number.Text = _recordService.GetAllContinuingRecord(_base.BaseId).Data.Count.ToString();
            label_waiting_care_record_number.Text = _recordService.GetAllWaitingRecord(_base.BaseId).Data.Count.ToString();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage(_authService, _userService, _userOperationClaimService, _recordService, _partStatusService,_maintenanceTypeService,_baseService, _planeService);
            Hide();
            loginPage.ShowDialog();
            Close();
        }
        private void button_emergency_record_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_emergency_record.Name);
        }

        private void button_countuing_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_countuing.Name);

        }

        private void button_waiting_record_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_waiting_record.Name);

        }

        private void button_parts_status_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_parts_status.Name);

        }

        private void button_completed_record_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_completed_record.Name);

        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            OpenDashboard(button_reports.Name);

        }
        private void OpenDashboard(string buttonName)
        {
            DashboardPage dashboardPage = new DashboardPage(buttonName, _hvBsNumber, _userService, _recordService, _userOperationClaimService, _authService, _partStatusService, _maintenanceTypeService, _baseService,_base,_planeService);
            Hide();
            dashboardPage.ShowDialog();
            Close();
        }
    }
}
