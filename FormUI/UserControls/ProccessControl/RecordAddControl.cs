using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.UserControls
{
    public partial class RecordAddControl : UserControl
    {
        private Record record = new Record();
        private readonly IRecordService _recordService;
        private readonly IUserService _userService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        User user = new User();
        private readonly string _hVbsNumber;
        public RecordAddControl(IRecordService recordService, string hVbsNumber, IUserService userService, IUserOperationClaimService userOperationClaimService)
        {
            InitializeComponent();
            _recordService = recordService;
            _hVbsNumber = hVbsNumber;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
        }
        private void RecordAddControl_Load(object sender, EventArgs e)
        {
            ClearTextBox();
            user = _userService.GetByHvBSNumber(_hVbsNumber).Data;
            textBox_register_staff.Text = user.FirstName + " " + user.LastName;
            record = new Record();
        }


        private void button_add_control_Click(object sender, EventArgs e)
        {
            SetValues();
            var result = _recordService.Add(record, GetClaim());
            MessageBox.Show(result.Message);
            RecordAddControl_Load(sender,e);
        }

        private void textBox_aircraft_TextChanged(object sender, EventArgs e)
        {
            record.AircraftSerialNumber = textBox_aircraft.Text;
        }

        private void textBox_trouble_TextChanged(object sender, EventArgs e)
        {
            record.Trouble = textBox_trouble.Text;
        }

        private void textBox_parts_need_TextChanged(object sender, EventArgs e)
        {
            record.PartsNeed = textBox_parts_need.Text;
        }

        private void textBox_identify_staff_TextChanged(object sender, EventArgs e)
        {
            record.StaffOfIdentifyTrouble = textBox_identify_staff.Text;
        }

        private void checkBox_emergency_CheckedChanged(object sender, EventArgs e)
        {
            record.IsEmergency = checkBox_emergency.Checked;
        }

        private void SetValues()
        {
            record.ReasonOfWaiting = "Yeni Kayıt";
            record.StaffOfRecording = user.FirstName + " " + user.LastName;
            record.RegisterDate = DateTime.Now;
            record.IsWaiting = true;
            record.IsCompleted = false;
        }
        private int GetClaim()
        {
            return _userOperationClaimService.GetByUserId(user.UserId).Data.OperationClaimId;

        }
        private void ClearTextBox()
        {
            textBox_aircraft.Text = "";
            textBox_trouble.Text = "";
            textBox_parts_need.Text = "";
            textBox_identify_staff.Text = "";
            checkBox_emergency.Checked = false;
        }

    }
}
