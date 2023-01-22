using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class RecordUpdateForm : Form
    {
        private readonly IRecordService _recordService;
        private Record _record = new Record();
        private readonly string _aircraftNumber;
        private readonly string _trouble;
        private readonly int _claimId;
        public RecordUpdateForm(string aircraftNumber, string trouble, IRecordService recordService, int claimId)
        {
            InitializeComponent();
            _aircraftNumber = aircraftNumber;
            _trouble = trouble;
            _recordService = recordService;
            _claimId = claimId;
        }

        private void RecordUpdateForm_Load(object sender, EventArgs e)
        {
            _record = _recordService.GetByAircraftNumberAndTrouble(_aircraftNumber, _trouble).Data;

            textBox_aircraft.Text = _record.AircraftSerialNumber;
            textBox_trouble.Text = _record.Trouble;
            textBox_reason_of_waiting.Text = _record.ReasonOfWaiting;
            textBox_parts_need.Text = _record.PartsNeed;
            textBox_register_staff.Text = _record.StaffOfRecording;
            textBox_identity_staff.Text = _record.StaffOfIdentifyTrouble;
            textBox_maintenance_cheif.Text = _record.MaintenanceChief;
            checkBox_emergency.Checked = _record.IsEmergency;
            checkBox_completed.Checked = _record.IsCompleted;
            checkBox_waiting.Checked = _record.IsWaiting;
        }

        private void textBox_aircraft_TextChanged(object sender, EventArgs e)
        {
            _record.AircraftSerialNumber = textBox_aircraft.Text;
        }

        private void textBox_trouble_TextChanged(object sender, EventArgs e)
        {
            _record.Trouble = textBox_trouble.Text;
        }

        private void textBox_reason_of_waiting_TextChanged(object sender, EventArgs e)
        {
            _record.ReasonOfWaiting = textBox_reason_of_waiting.Text;
        }

        private void textBox_parts_need_TextChanged(object sender, EventArgs e)
        {
            _record.PartsNeed = textBox_parts_need.Text;
        }

        private void textBox_register_staff_TextChanged(object sender, EventArgs e)
        {
            _record.StaffOfRecording = textBox_register_staff.Text;
        }

        private void textBox_identity_staff_TextChanged(object sender, EventArgs e)
        {
            _record.StaffOfIdentifyTrouble = textBox_identity_staff.Text;
        }

        private void textBox_maintenance_cheif_TextChanged(object sender, EventArgs e)
        {
            _record.MaintenanceChief = textBox_maintenance_cheif.Text;
        }

        private void checkBox_emergency_CheckedChanged(object sender, EventArgs e)
        {
            _record.IsEmergency = checkBox_emergency.Checked;
        }

        private void checkBox_waiting_CheckedChanged(object sender, EventArgs e)
        {
            _record.IsWaiting = checkBox_waiting.Checked;
            checkBox_completed.Checked = checkBox_waiting.Checked ? false : checkBox_completed.Checked;
            _record.IsCompleted = checkBox_completed.Checked;
        }

        private void checkBox_completed_CheckedChanged(object sender, EventArgs e)
        {
            _record.IsCompleted = checkBox_completed.Checked;
            checkBox_waiting.Checked = checkBox_completed.Checked ? false : checkBox_waiting.Checked;
            _record.IsWaiting = checkBox_waiting.Checked;

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
            if ((checkBox_completed.Checked && textBox_maintenance_cheif.Text != string.Empty)|| !checkBox_completed.Checked)
            {
                var result = _recordService.Update(_record, _claimId);
                MessageBox.Show(result.Message);
                Close();
            }
            else
            {
                MessageBox.Show("Lütfen bakım şefini giriniz!");
            }

        }

    }
}
