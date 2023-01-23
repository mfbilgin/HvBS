using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.SettingControls
{
    public partial class MaintenanceTypeControl : UserControl
    {
        public MaintenanceTypeControl()
        {
            InitializeComponent();
        }

        private void MaintenanceTypeControl_Load(object sender, EventArgs e)
        {
            List<string> strings = new List<string>() { "a", "b", "c", "d" };
            if (strings.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
               
                    GroupBox groupBox = new GroupBox()
                    {
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    Label label_maintenance_name = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_maintenance_periot = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_definition = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_to_do_during_maintenance = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                label_maintenance_name.Text = strings[0];
                SetLocation(label_maintenance_name, label_maintenance_name_title,groupBox);

                label_maintenance_periot.Text = strings[1];
                SetLocation(label_maintenance_periot, label_maintenance_periot_title, groupBox)
                    ;
                label_definition.Text = strings[2];
                SetLocation(label_definition, label_definition_title, groupBox);

                label_to_do_during_maintenance.Text = strings[3];
                SetLocation(label_to_do_during_maintenance, label_to_do_during_maintenance_title, groupBox);

                flowLayoutPanel1.Controls.Add(groupBox);
                groupBox.Controls.Add(label_maintenance_name);
                groupBox.Controls.Add(label_maintenance_periot);
                groupBox.Controls.Add(label_definition);
                groupBox.Controls.Add(label_to_do_during_maintenance);

            }
        }
        private void SetLocation(Label content, Label title, GroupBox container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Width - content.Width) - 10, container.Height / 2);

            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Width - title.Width) / 2, container.Height / 2);
            }
        }
    }
}
