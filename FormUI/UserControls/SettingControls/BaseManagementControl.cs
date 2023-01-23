using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.SettingControls
{
    public partial class BaseManagementControl : UserControl
    {
        public BaseManagementControl()
        {
            InitializeComponent();
        }
        private void BaseManagementControl_Load(object sender, EventArgs e)
        {
            List<int> ints = new List<int>() { 1,2,3,4,5,6,7,8,9};
            comboBox_base.DataSource = ints;
        }
        private void textBox_base_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_will_autorized_staff_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_will_aircrafts_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {

        }



        private void comboBox_base_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
