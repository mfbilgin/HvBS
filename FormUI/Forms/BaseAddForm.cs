using Business.Abstract;
using Entities.Concrete;
using System;
using System.Windows.Forms;
namespace FormUI.Forms
{
    public partial class BaseAddForm : Form
    {
        private readonly IBaseService _baseService;
        private readonly Base _base = new Base();
        private readonly IUserService _userService;
        public BaseAddForm(IBaseService baseService, IUserService userService)
        {
            InitializeComponent();
            _baseService = baseService;
            _userService = userService;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            _base.BaseName = textBox_base_name.Text;
            _base.AuthorizedStaffOnBase = comboBox1.SelectedValue.ToString();
            _base.AircraftOnBase = textBox_aircrafts.Text;

            var result = _baseService.AddWithoutAuthentication(_base);
            MessageBox.Show(result.Message);
            if (result.Success) Close();

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Hide();
            Close();
            
            
        }

        private void BaseAddForm_Load(object sender, EventArgs e)
        {
            var users = _userService.GetAllUserName();
            comboBox1.DataSource = users;
        }
    }
}
