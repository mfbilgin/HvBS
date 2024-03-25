using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class RecordUpdateForm : Form
    {
        private readonly IRecordService _recordService;
        private readonly IPlaneService _planeService;
        private readonly IUserService _userService;
        private readonly IPartService _partService;
        private readonly Base _base;
        private Record _record = new Record();
        private readonly string _aircraftNumber;
        private readonly string _trouble;

        public RecordUpdateForm(string aircraftNumber, string trouble, IRecordService recordService,
             Base @base, IUserService userService, IPartService partService, IPlaneService planeService)
        {
            InitializeComponent();
            _aircraftNumber = aircraftNumber;
            _trouble = trouble;
            _recordService = recordService;
            _base = @base;
            _userService = userService;
            _partService = partService;
            _planeService = planeService;
        }

        private void RecordUpdateForm_Load(object sender, EventArgs e)
        {
            _record = _recordService.GetByAircraftNumberAndTrouble(_aircraftNumber, _trouble).Data;
            SetComboBoxData();

            textBox_register_staff.Text = _record.StaffOfRecording;
            textBox_trouble.Text = _record.Trouble;
            textBox_reason_of_waiting.Text = _record.ReasonOfWaiting;

            comboBox_aircraft.Text = _record.AircraftSerialNumber;
            comboBox_parts_need.Text = _record.PartsNeed;
            comboBox_identity_staff.Text = _record.StaffOfIdentifyTrouble;
            comboBox_maintenance_cheif.Text = _record.MaintenanceChief;

            checkBox_emergency.Checked = _record.IsEmergency;
            checkBox_completed.Checked = _record.IsCompleted;
            checkBox_waiting.Checked = _record.IsWaiting;
        }

        private void SetComboBoxData()
        {
            var users = _userService.GetAllUserName();
            comboBox_aircraft.DataSource = _planeService.GetAllSerialNumber(_base.BaseId).Data;
            comboBox_parts_need.DataSource = _partService.GetAllPartNames(_base.BaseId);
            comboBox_identity_staff.DataSource = users;
            comboBox_maintenance_cheif.DataSource = users;
        }


        private void textBox_trouble_TextChanged(object sender, EventArgs e)
        {
            _record.Trouble = textBox_trouble.Text;
        }

        private void textBox_reason_of_waiting_TextChanged(object sender, EventArgs e)
        {
            _record.ReasonOfWaiting = textBox_reason_of_waiting.Text;
        }


        private void textBox_register_staff_TextChanged(object sender, EventArgs e)
        {
            _record.StaffOfRecording = textBox_register_staff.Text;
        }


        private void checkBox_emergency_CheckedChanged(object sender, EventArgs e)
        {
            _record.IsEmergency = checkBox_emergency.Checked;
        }

        private void checkBox_waiting_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_completed.Checked = !checkBox_waiting.Checked && checkBox_completed.Checked;
        }

        private void checkBox_completed_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_waiting.Checked = !checkBox_completed.Checked && checkBox_waiting.Checked;
        }

        private void button_close_dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (_record.IsCompleted)
                MessageBox.Show(@"Tamamlanmış kayıtlar güncellenemez!");

            else if (checkBox_completed.Checked && _record.IsWaiting)
                MessageBox.Show(@"Kayıt bakıma alınmadan tamamlanamaz!");

            else if (!checkBox_waiting.Checked && comboBox_maintenance_cheif.Text == string.Empty)
                MessageBox.Show(@"Lütfen bakım şefini giriniz!");

            else
            {
                _record.IsWaiting = checkBox_waiting.Checked;
                _record.IsCompleted = checkBox_completed.Checked;
                _record.AircraftSerialNumber = comboBox_aircraft.Text;
                _record.PartsNeed = comboBox_parts_need.Text;
                _record.StaffOfIdentifyTrouble = comboBox_identity_staff.Text;
                _record.MaintenanceChief = comboBox_maintenance_cheif.Text;
                
                if (!_record.IsWaiting && !_record.IsCompleted)
                    _record.RegisterDate = DateTime.Now;
                if (_record.IsCompleted)
                {
                    _record.CompleteDate = DateTime.Now;
                }

                var result = _recordService.Update(_record);
                MessageBox.Show(result.Message);
                Close();
            }
        }

        // private void comboBox_aircraft_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     _record.AircraftSerialNumber = comboBox_aircraft.SelectedValue.ToString();
        // }
        //
        // private void comboBox_parts_need_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     _record.PartsNeed = comboBox_parts_need.SelectedValue.ToString();
        // }
        //
        // private void comboBox_identity_staff_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     _record.StaffOfIdentifyTrouble = comboBox_identity_staff.SelectedValue.ToString();
        // }
        //
        // private void comboBox_maintenance_cheif_SelectedIndexChanged(object sender, EventArgs e)
        // {
        //     _record.MaintenanceChief = comboBox_maintenance_cheif.SelectedValue.ToString();
        // }
    }
}