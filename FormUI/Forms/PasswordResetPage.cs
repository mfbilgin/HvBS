using Business.Abstract;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class PasswordResetPage : Form
    {
        private readonly IAuthService _authService;

        public PasswordResetPage(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }


        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox_HvBS_Enter(object sender, EventArgs e)
        {
            if (textBox_HvBS.Text == "HvBS No")
            {
                textBox_HvBS.Text = "";
                textBox_HvBS.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_HvBS_Leave(object sender, EventArgs e)
        {
            if (textBox_HvBS.Text == "")
            {
                textBox_HvBS.Text = "HvBS No";
                textBox_HvBS.ForeColor = SystemColors.GrayText;
            }

        }

        private void button_login_Click(object sender, EventArgs e)
        {

            var result = _authService.PasswordReset(new Entities.DTOs.UserForPasswordResetDto()
            { 
                HvBSNumber = textBox_HvBS.Text 
            });
            MessageBox.Show(result.Message,result.Success ? "Parola Sıfırlandı" : "Hata");
            if (result.Success) Close();

        }
    }
}
 