using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Forms
{
    public partial class MenuPage : Form
    {
        private readonly string HvBSNumber;
        private readonly IUserService _userService;
        public MenuPage(string hvBSNumber,IUserService userService)
        {
            InitializeComponent();
            HvBSNumber = hvBSNumber;
            _userService = userService;
        }

        private void MenuPage_Load(object sender, EventArgs e)
        {
            User user = _userService.GetByHvBSNumber(HvBSNumber).Data;
            label_name.Text = user.FirstName + @" " + user.LastName.ToUpper();
            label_rank.Text = user.Rank;
            label_HvBS.Text = $"HvBS No: {user.HvBSNumber}";
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button_emergency_record_Click(object sender, EventArgs e)
        {
            DashboardPage dashboardPage = new DashboardPage(HvBSNumber,_userService);
            Hide();
            dashboardPage.ShowDialog();
            Close();
        }
    }
}
