using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace FormUI.UserControls.ProccessControl
{
    public partial class PartAddControl : UserControl
    {
        private readonly IPartService _partService;
        private readonly Base _base;
        private readonly Part _part = new Part();
        private readonly int _claimId;
        public PartAddControl(IPartService partStatusService, int claimId, Base @base)
        {
            InitializeComponent();
            _partService = partStatusService;
            _claimId = claimId;
            _base = @base;
        }

        private void PartAddControl_Load(object sender, EventArgs e)
        {
            textBox_part_number.Text = "";
            textBox_part_name.Text = "";
            checkBox_stock_status.Checked = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            SetValues();
            var result = _partService.Add(_part, _claimId);
            MessageBox.Show(result.Message);
            PartAddControl_Load(sender, e);
        }

        private void SetValues()
        {
            _part.PartId = 0;
            _part.PartNumber = textBox_part_number.Text;
            _part.PartName = textBox_part_name.Text;
            _part.StockStatus = checkBox_stock_status.Checked;
            _part.BaseId = _base.BaseId;
        }

    }
}
