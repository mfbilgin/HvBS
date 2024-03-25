using System;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;

namespace FormUI.UserControls.SettingControls
{
    public partial class BaseManagementControl : UserControl
    {
        private readonly IBaseService _baseService;
        private readonly IUserService _userService;
        private readonly Base _baseForCreate = new Base();
        private readonly Base _baseFromLogin;
        private readonly int _claimId;
        private string _selectedName;
        public BaseManagementControl(IBaseService baseService,int claimId, Base @base, IUserService userService)
        {
            InitializeComponent();
            _baseService = baseService;
            _claimId = claimId;
            _baseFromLogin = @base;
            _userService = userService;
        }
        private void BaseManagementControl_Load(object sender, EventArgs e)
        {
            _baseForCreate.BaseId = 0;
            ClearTextBox();
            comboBox_base.DataSource= _baseService.GetAllBaseName();
            comboBox1.DataSource = _userService.GetAllUserName();
        }
        private void button_create_Click(object sender, EventArgs e)
        {
            SetValues();
            var result = _baseService.Add(_baseForCreate,_claimId);
            MessageBox.Show(result.Message);
            BaseManagementControl_Load(sender, e);
        }

        private void SetValues()
        {
            _baseForCreate.BaseName = textBox_base_name.Text;
            _baseForCreate.AuthorizedStaffOnBase = comboBox1.SelectedValue.ToString();
            _baseForCreate.AircraftOnBase = textBox_will_aircrafts.Text;

        }

        private void comboBox_base_SelectedIndexChanged(object sender, EventArgs e)
        {
            var @base = _baseService.GetByBaseName(comboBox_base.SelectedValue.ToString()).Data;
            _selectedName = @base.BaseName;
            textBox_aircraft_on_base.Text = @base.AircraftOnBase;
            textBox_authorized_staff.Text = @base.AuthorizedStaffOnBase;
        }
        private void ClearTextBox()
        {
            textBox_base_name.Text = "";
            comboBox1.DataSource = null;
            textBox_will_aircrafts.Text = "";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var @base = _baseService.GetByBaseName(_selectedName).Data;
            if (@base.BaseId == _baseFromLogin.BaseId)
            {
                MessageBox.Show(@"İşlem yapılan üs silinemez.");
            }
            else
            {
                
                var result = _baseService.Delete(@base, _claimId);
                MessageBox.Show(result.Message);
                BaseManagementControl_Load(sender, e);
            }
        }
    }
}
