using Business.Abstract;
using Core.Entities.Concrete;
using FormUI.UserControls.ProccessControl;
using FormUI.UserControls.ViewControls;
using System;
using System.Drawing;
using System.Windows.Forms;
using FormUI.UserControls.SettingControls;
using Entities.Concrete;

namespace FormUI.Forms
{
    public partial class DashboardPage : Form
    {
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IPartService _partService;
        private readonly IAuthService _authService;
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly IBaseService _baseService;
        private readonly IPlaneService _planeService;
        private User _user = new User();
        private readonly Base _base;
        private readonly int _claimId;
        private bool _isCollapsedProccess = true;
        private bool _isCollapsedMaintenance = true;
        private readonly string _hvBsNumber;
        private readonly string _clickedButtonName;
        public DashboardPage(string clickedButtonName, string hvBsNumber, IUserService userService, IRecordService recordService, IUserOperationClaimService userOperationClaimService, IAuthService authService, IPartService partStatusService, IMaintenanceTypeService maintenanceTypeService, IBaseService baseService, Base @base, IPlaneService planeService)
        {
            InitializeComponent();
            _clickedButtonName = clickedButtonName;
            _hvBsNumber = hvBsNumber;
            _userService = userService;
            _recordService = recordService;
            _userOperationClaimService = userOperationClaimService;
            _authService = authService;
            _claimId = _userOperationClaimService.GetByUserId(_userService.GetByHvBsNumber(hvBsNumber).Data.UserId).Data.OperationClaimId;
            _partService = partStatusService;
            _maintenanceTypeService = maintenanceTypeService;
            _baseService = baseService;
            _base = @base;
            _planeService = planeService;
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
            label_selected_base.Text = @$"Seçili üs : {_base.BaseName}";

            _user = _userService.GetByHvBsNumber(_hvBsNumber).Data;
            label_name.Text = _user.FirstName + @" " + _user.LastName.ToUpper();
            label_rank.Text = _user.Rank;
            label_HvBS.Text = $@"HvBS No: {_user.HvBSNumber}";
            var clickedButton = (Button) flowLayoutPanel1.Controls[_clickedButtonName];
            clickedButton.PerformClick();

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
            AddControls(new EmergencyRecordControl(_recordService,_base));
        }
        private void AddControls(UserControl userControl)
        {
            panel_controls.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel_controls.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void button_record_proccess_Click(object sender, EventArgs e)
        {
            timer_proccess.Start();
        }

        private void button_add_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_add_record);
            AddControls(new RecordAddControl(_recordService, _hvBsNumber, _userService, _userOperationClaimService,_maintenanceTypeService,_base,_partService,_planeService));
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage(_authService, _userService, _userOperationClaimService, _recordService, _partService,_maintenanceTypeService,_baseService, _planeService);
            Hide();
            loginPage.ShowDialog();
            Close();
        }

        private void button_continuing_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_countuing);
            AddControls(new OngoingMaintenanceRecordControl(_recordService,_user.UserId, _base));
        }


        private void button_waiting_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_waiting_record);
            AddControls(new WaitingRecordControl(_recordService,_userService,_base));
        }
        private void SetButtonColor(Button selectedButton)
        {
            var mainButtonColor = Color.FromArgb(53, 67, 137);
            var underButtonColor = Color.FromArgb(67, 86, 181);

            button_emergency_record.BackColor = mainButtonColor;
            button_countuing.BackColor = mainButtonColor;
            button_waiting_record.BackColor = mainButtonColor;
            button_completed_record.BackColor = mainButtonColor;
            button_parts_status.BackColor = mainButtonColor;
            button_maintance_settings.BackColor = mainButtonColor;
            button_reports.BackColor = mainButtonColor;
            button_user_proccess.BackColor = mainButtonColor;

            button_add_record.BackColor = underButtonColor;
            button_plane_add.BackColor = underButtonColor;
            button_update_record.BackColor = underButtonColor;
            button_delete_record.BackColor = underButtonColor;
            button_part_add.BackColor = underButtonColor;
            button_base_management.BackColor = underButtonColor;
            button_type_of_maintenance.BackColor = underButtonColor;
            selectedButton.BackColor = Color.Black;
        }

        private void button_update_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_update_record);
            AddControls(new RecordUpdateControl(_recordService, _base,_userService,_partService, _planeService));
        }

        private void button_delete_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_delete_record);
            AddControls(new RecordDeleteControl(_recordService,_base));
        }

        private void button_completed_record_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_completed_record);
            AddControls(new CompletedRecordControl(_recordService,_base));
        }

        private void button_part_add_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_part_add);
            AddControls(new PartAddControl(_partService, _claimId,_base));
        }

        private void button_parts_status_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_parts_status);
            AddControls(new PartStatusControl(_partService,_claimId,_base));
        }

        private void button_maintenance_settings_Click(object sender, EventArgs e)
        {
            timer_maintenance.Start();
        }

        private void timer_maintenance_Tick(object sender, EventArgs e)
        {
            if (_isCollapsedMaintenance)
            {
                panel_dropdown_maintenance_setting.Height += 10;
                if (panel_dropdown_maintenance_setting.Size != panel_dropdown_maintenance_setting.MaximumSize) return;
                timer_maintenance.Stop();
                _isCollapsedMaintenance = false;
            }
            else
            {
                panel_dropdown_maintenance_setting.Height -= 10;
                if (panel_dropdown_maintenance_setting.Size != panel_dropdown_maintenance_setting.MinimumSize) return;
                timer_maintenance.Stop();
                _isCollapsedMaintenance = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isCollapsedProccess)
            {
                panel_dropdown_record_proccess.Height += 10;
                if (panel_dropdown_record_proccess.Size != panel_dropdown_record_proccess.MaximumSize) return;
                timer_proccess.Stop();
                _isCollapsedProccess = false;
            }
            else
            {
                panel_dropdown_record_proccess.Height -= 10;
                if (panel_dropdown_record_proccess.Size != panel_dropdown_record_proccess.MinimumSize) return;
                timer_proccess.Stop();
                _isCollapsedProccess = true;
            }
        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_reports);
            AddControls(new ReportControl(_recordService,_base,_userService));
        }

        private void button_base_management_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_base_management);
            AddControls(new BaseManagementControl(_baseService,_claimId,_base,_userService));
        }

        private void button_type_of_maintenance_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_type_of_maintenance);
            AddControls(new MaintenanceTypeControl(_maintenanceTypeService,_claimId,_base));
        }

        private void button_user_proccess_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_user_proccess);
            AddControls(new PasswordChangeControl(_authService,_hvBsNumber));
        }

        private void button_plane_add_Click(object sender, EventArgs e)
        {
            SetButtonColor(button_plane_add);
            AddControls(new PlaneAddControl(_planeService,_base,_baseService,_claimId));
        }

        private void label_selected_base_Click(object sender, EventArgs e)
        {

        }
    }
}
