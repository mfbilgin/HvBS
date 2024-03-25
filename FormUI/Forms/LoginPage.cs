using Business.Abstract;
using Entities.DTOs;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class LoginPage : Form
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IRecordService _recordService;
        private readonly IPartService _partStatusService;
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly IBaseService _baseService;
        private readonly IPlaneService _planeService;

        public LoginPage(IAuthService authService, IUserService userService,
            IUserOperationClaimService userOperationClaimService, IRecordService recordService,
            IPartService partStatusService, IMaintenanceTypeService maintenanceTypeService, IBaseService baseService, IPlaneService planeService)
        {
            InitializeComponent();
            _authService = authService;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _recordService = recordService;
            _partStatusService = partStatusService;
            _maintenanceTypeService = maintenanceTypeService;
            _baseService = baseService;
            _planeService = planeService;
        }

        private void textBox_HvBS_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_HvBS, "HvBS No");
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_password, "Parola");
            textBox_password.UseSystemPasswordChar = true;
        }

        private void textBox_HvBS_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_HvBS, "HvBS No");
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_password, "Parola");
        }

        private void label_password_change_Click(object sender, EventArgs e)
        {
            var passwordResetPage = new PasswordResetPage(_authService);
            passwordResetPage.ShowDialog();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            var user = new UserForLoginDto()
            {
                HvBSNumber = textBox_HvBS.Text.Trim(),
                Password = textBox_password.Text.Trim()
            };
            var result = _authService.Login(user);
            if (result.Success)
            {
                var name = comboBox_bases.SelectedValue.ToString();
                var @base = _baseService.GetByBaseName(name).Data;
                var menuPage = new MenuPage(user.HvBSNumber, _userService, _recordService,
                    _userOperationClaimService, _authService, _partStatusService, _maintenanceTypeService, _baseService,
                    @base, _planeService);
                Hide();
                menuPage.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(result.Message, @"Giriş Hatalı", icon: MessageBoxIcon.Warning,
                    buttons: MessageBoxButtons.OK);
            }
        }

        private void button_show_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
        }

        private void label_is_register_Click(object sender, EventArgs e)
        {
            var registerPage = new RegisterPage(_authService);
            registerPage.Show();
        }

        private static void SetPlaceHolder(TextBox textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
            else if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            var bases = _baseService.GetAll().Data;
            var userCount = _userService.GetAll().Data.Count;
            if (userCount == 0)
            {
                MessageBox.Show(@"Kayıtlı herhangi bir kullanıcı bulunamadı. Kayıt sayfasına yönlendiriliyorsunuz.");
                var registerPage = new RegisterPage(_authService);
                registerPage.ShowDialog();
               
            }
            if (bases.Count == 0)
            {
                MessageBox.Show(
                    @"Kayıtlı herhangi bir üs bulunamadı. Üs ekleme sayfasına yönlendiriliyorsunuz. Ekledikten sonra yeniden giriş yapınız.");
                var baseAddForm = new BaseAddForm(_baseService, _userService);
                baseAddForm.ShowDialog();
                Close();
                return;
            }

            bases = _baseService.GetAll().Data;
            var baseNames = bases.Select(@base => @base.BaseName).ToList();

            comboBox_bases.DataSource = baseNames;
            comboBox_bases.Text = comboBox_bases.Items[0].ToString();
        }
    }
}