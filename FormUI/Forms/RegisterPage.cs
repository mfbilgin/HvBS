using Business.Abstract;
using Entities.DTOs;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class RegisterPage : Form
    {
        private readonly IAuthService _authService;

        public RegisterPage(IAuthService authService)
        {
            _authService = authService;
            InitializeComponent();
        }
        private void button_register_Click(object sender, EventArgs e)
        {
            UserForRegisterDto user = new UserForRegisterDto()
            {
                FirstName = textBox_first_name.Text,
                LastName = textBox_last_name.Text,
                HvBSNumber = textBox_HvBS.Text,
                Password = textBox_password.Text,
                PhoneNumber = GetPhoneNumberWithoutSpace(),
                Rank = textBox_rank.Text
            };
            var result = _authService.Register(user);
            if (result.Success)
            {
                MessageBox.Show(result.Message, @"Başarılı");
                Close();
            }
            else
            {
                MessageBox.Show(result.Message, @"Hata");
            }
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

        private void textBox_first_name_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_first_name, "Ad");
        }

        private void textBox_first_name_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_first_name, "Ad");
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void textBox_last_name_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_last_name, "Soy Ad");
        }

        private void textBox_last_name_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_last_name, "Soy Ad");
        }

        private void textBox_phone_number_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_phone_number, "Telefon Numarası");
        }

        private void textBox_phone_number_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_phone_number, "Telefon Numarası");
        }

        private void textBox_HvBS_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_HvBS, "HvBS No");
        }

        private void textBox_HvBS_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_HvBS, "HvBS No");
        }

        private void textBox_rank_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_rank, "Rütbe");
        }

        private void textBox_rank_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_rank, "Rütbe");
        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_password, "Parola");
            textBox_password.UseSystemPasswordChar = true;
        }
        private void textBox_password_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(textBox_password, "Parola");
        }
        private void button_show_password_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = !textBox_password.UseSystemPasswordChar;

        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {
            if (textBox_phone_number.Text.Length == 4 || textBox_phone_number.Text.Length == 8)
            {
                textBox_phone_number.Text += @" ";
                textBox_phone_number.SelectionStart = textBox_phone_number.Text.Length;
                textBox_phone_number.SelectionLength = 0;
            }

           
        }
        private string GetPhoneNumberWithoutSpace()
        {
            string[] strings = textBox_phone_number.Text.Split(' ');
            string phoneNumber = string.Empty;
            foreach (string str in strings)
            {
                phoneNumber += str;
            }
            return phoneNumber;
        }
    }
}
