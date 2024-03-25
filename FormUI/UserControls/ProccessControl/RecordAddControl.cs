using System;
using System.Windows.Forms;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace FormUI.UserControls.ProccessControl
{
    public partial class RecordAddControl : UserControl
    {
        private Record _record = new Record();
        private User _user = new User();
        private readonly IRecordService _recordService;
        private readonly IUserService _userService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly IPlaneService _planeService;
        private readonly IPartService _partService;
        private readonly Base _base;
        private readonly string _hVbsNumber;
        public RecordAddControl(IRecordService recordService, string hVbsNumber, IUserService userService, IUserOperationClaimService userOperationClaimService, IMaintenanceTypeService maintenanceTypeService, Base @base, IPartService partService, IPlaneService planeService)
        {
            InitializeComponent();
            _recordService = recordService;
            _hVbsNumber = hVbsNumber;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _maintenanceTypeService = maintenanceTypeService;
            _base = @base;

            _partService = partService;
            _planeService = planeService;
        }
        private void RecordAddControl_Load(object sender, EventArgs e)
        {
            ClearValue();
            _user = _userService.GetByHvBsNumber(_hVbsNumber).Data;

            comboBox_staff.DataSource = _userService.GetAllUserName();
            comboBox_maintenance_type.DataSource = _maintenanceTypeService.GetAllName(_base.BaseId);
            comboBox_aircraft_no.DataSource = _planeService.GetAllSerialNumber(_base.BaseId).Data;
            comboBox_part_needs.DataSource = _partService.GetAllPartNames(_base.BaseId);
            textBox_register_user.Text = _user.FirstName + @" " + _user.LastName.ToUpper();
            _record = new Record();
        }


        private void button_add_control_Click(object sender, EventArgs e)
        {
            SetValues();

            var result = _recordService.Add(_record, GetClaim());
            MessageBox.Show(result.Message);
            RecordAddControl_Load(sender, e);
        }




        private void checkBox_emergency_CheckedChanged(object sender, EventArgs e)
        {
            _record.IsEmergency = checkBox_emergency.Checked;
        }

        private void SetValues()
        {
           
            _record.BaseId = _base.BaseId;
            _record.AircraftSerialNumber = comboBox_aircraft_no.SelectedValue.ToString();
            _record.Trouble = textBox_trouble.Text;
            _record.PartsNeed = comboBox_part_needs.SelectedValue.ToString();
            _record.StaffOfRecording = textBox_register_user.Text;
            _record.ReasonOfWaiting = "Yeni Kayıt";
            _record.StaffOfIdentifyTrouble = comboBox_staff.SelectedValue.ToString();
            _record.MaintenanceTypes = comboBox_maintenance_type.SelectedValue.ToString();
            _record.RegisterDate = DateTime.Now;
            _record.IsWaiting = true;
            _record.IsCompleted = false;
        }
        private int GetClaim()
        {
            return _userOperationClaimService.GetByUserId(_user.UserId).Data.OperationClaimId;

        }
        private void ClearValue()
        {
            textBox_trouble.Text = "";
            comboBox_aircraft_no.DataSource = null;
            comboBox_part_needs.DataSource = null;
            comboBox_maintenance_type.DataSource = null;
            comboBox_staff.DataSource = null;
            checkBox_emergency.Checked = false;
        }
    }
}
