using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;
using FormUI.UserControls.ReportControls;

namespace FormUI.UserControls.ViewControls
{
    public partial class ReportControl : UserControl
    {
        private readonly IRecordService _recordService;
        private readonly IUserService _userService;
        private readonly Base _base;
        public ReportControl(IRecordService recordService, Base @base, IUserService userService)
        {
            InitializeComponent();
            _recordService = recordService;
            _base = @base;
            _userService = userService;
        }

        private void button_complete_detail_Click(object sender, EventArgs e)
        {
            AddControls(new CompleteDetail(_recordService,_base, _userService));
        }

        private void AddControls(UserControl userControl)
        {
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ReportControl_Load(object sender, EventArgs e)
        {
            var waitingRecordCount = _recordService.GetAllWaitingRecordInLastTime(_base.BaseId,24).Data.Count;
            var completedRecordCount = _recordService.GetAllCompletedRecordInLastTime(_base.BaseId,24).Data.Count;
            var ongoingRecordCount = _recordService.GetAllContinuingRecordInLastTime(_base.BaseId,24).Data.Count;
            var emergencyRecordCount = _recordService.GetAllEmergencyRecordInLastTime(_base.BaseId, 24).Data.Count;

            label_waiting.Text = waitingRecordCount.ToString();
            label_completed.Text = completedRecordCount.ToString();
            label_ongoing.Text = ongoingRecordCount.ToString();
            label_emergency.Text = emergencyRecordCount.ToString();
        }


    }
}
