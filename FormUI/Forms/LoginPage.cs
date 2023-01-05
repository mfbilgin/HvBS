using Business.Abstract;
using Entities.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class LoginPage : Form
    {
        private readonly IAuthService _authService;
        private readonly IUserService _userService;
        public LoginPage(IAuthService authService, IUserService userService)
        {
            _authService = authService;
            _userService = userService;
            InitializeComponent();
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
            PasswordResetPage passwordResetPage = new PasswordResetPage(_authService);
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
            UserForLoginDto user = new UserForLoginDto()
            {
                HvBSNumber = textBox_HvBS.Text,
                Password = textBox_password.Text
            };
            var result = _authService.Login(user);
            if (result.Success)
            {
                MenuPage menuPage = new MenuPage(user.HvBSNumber,_userService);
                Hide();
                menuPage.ShowDialog();
                Close();

            }
            else
            {
                MessageBox.Show(result.Message,"Giriş Hatalı", icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.OK);
            }
        }

        private void button_show_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;
        }

        private void label_is_register_Click(object sender, EventArgs e)
        {
            RegisterPage registerPage = new RegisterPage(_authService);
            registerPage.Show();
        }
        private void SetPlaceHolder(TextBox textBox, string text)
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
    }
}
