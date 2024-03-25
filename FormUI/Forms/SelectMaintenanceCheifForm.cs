using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class SelectMaintenanceCheifForm : Form
    {
        private readonly IUserService _userService;
        private readonly IRecordService _recordService;
        private readonly Record _record;
        public SelectMaintenanceCheifForm(IUserService userService,IRecordService recordService, Record record)
        {
            InitializeComponent();
            _userService = userService;
            _recordService = recordService;
            _record = record;
        }

        private void button_close_dashboard_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void SelectMaintenanceCheifForm_Load(object sender, EventArgs e)
        {
            List<String> names = new List<string>();
            List<User> users = _userService.GetAll().Data;
            dateTimePicker1.MinDate = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy"));
            foreach (User user in users)
            {
                names.Add(user.FirstName + " " + user.LastName.ToUpper());
            }
            comboBox_maintenance_cheif.DataSource = names;
        }

        private void button_select_Click(object sender, EventArgs e)
        { 
            _record.IsWaiting = false;
            _record.EstimatedEndDate = dateTimePicker1.Value;
            _record.MaintenanceChief = comboBox_maintenance_cheif.SelectedValue.ToString();
            _recordService.Update(_record);
            MessageBox.Show(@"Bakıma alındı.");
            Close();

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
