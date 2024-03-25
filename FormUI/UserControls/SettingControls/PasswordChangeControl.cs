using System;
using System.Windows.Forms;
using Business.Abstract;
using Entities.DTOs;

namespace FormUI.UserControls.SettingControls
{
    public partial class PasswordChangeControl : UserControl
    {
        private readonly IAuthService _authService;
        private readonly string _hVbsNumber;
        private readonly UserForPasswordChangeDto _userForPasswordChangeDto = new UserForPasswordChangeDto();
        public PasswordChangeControl(IAuthService authService,string hVbsNumber)
        {
            InitializeComponent();
            _authService = authService;
            _hVbsNumber = hVbsNumber;
        }

        private void PasswordChangeControl_Load(object sender, EventArgs e)
        {
            _userForPasswordChangeDto.HvBSNumber = _hVbsNumber;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_new_password.Text != textBox_new_password_confirm.Text)
            {
                MessageBox.Show(@"Şifreler Uyuşmuyor");
            }
            else
            {
                var result = _authService.ChangePassword(_userForPasswordChangeDto);
                MessageBox.Show(result.Message);
            }
            
        }

        private void textBox_old_password_TextChanged(object sender, EventArgs e)
        {
            _userForPasswordChangeDto.OldPassword = textBox_old_password.Text;
        }

        private void textBox_new_password_TextChanged(object sender, EventArgs e)
        {
            _userForPasswordChangeDto.NewPassword = textBox_new_password.Text;
        }

        private void button_show_old_password_Click(object sender, EventArgs e)
        {
            textBox_old_password.UseSystemPasswordChar = !textBox_old_password.UseSystemPasswordChar;
        }

        private void button_show_new_password_Click(object sender, EventArgs e)
        {
            textBox_new_password.UseSystemPasswordChar = !textBox_new_password.UseSystemPasswordChar;

        }

        private void button_show_new_password_confirm_Click(object sender, EventArgs e)
        {
            textBox_new_password_confirm.UseSystemPasswordChar = !textBox_new_password_confirm.UseSystemPasswordChar;
        }
    }
}
