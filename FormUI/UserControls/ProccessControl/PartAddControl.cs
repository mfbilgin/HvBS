using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.UserControls.ProccessControl
{
    public partial class PartAddControl : UserControl
    {
        private readonly IPartStatusService _partStatusService;
        private PartStatus _partStatus = new PartStatus();
        private readonly int _claimId;
        public PartAddControl(IPartStatusService partStatusService, int claimId)
        {
            InitializeComponent();
            _partStatusService = partStatusService;
            _claimId = claimId;
        }

        private void PartAddControl_Load(object sender, EventArgs e)
        {
            textBox_part_number.Text = "";
            textBox_waiting_aircraft_number.Text = "";
            checkBox_stock_status.Checked = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var result = _partStatusService.Add(_partStatus, _claimId);
            MessageBox.Show(result.Message);
            PartAddControl_Load(sender, e);
        }

        private void textBox_waiting_aircraft_number_TextChanged(object sender, EventArgs e)
        {
            _partStatus.WaitingAircraftNumber = textBox_waiting_aircraft_number.Text;
        }

        private void textBox_part_number_TextChanged(object sender, EventArgs e)
        {
            _partStatus.PartNumber = textBox_part_number.Text;
        }

        private void checkBox_stock_status_CheckedChanged(object sender, EventArgs e)
        {
            _partStatus.StockStatus = checkBox_stock_status.Checked;
        }
    }
}
