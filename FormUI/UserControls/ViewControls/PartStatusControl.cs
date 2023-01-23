using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FormUI.UserControls.ViewControls
{
    public partial class PartStatusControl : UserControl
    {
        private readonly IPartStatusService _partStatusService;
        public PartStatusControl(IPartStatusService partStatusService)
        {
            InitializeComponent();
            _partStatusService = partStatusService;
        }

        private void PartStatusControl_Load(object sender, EventArgs e)
        {
            List<PartStatus> partStatuses = _partStatusService.GetAll().Data;
            if (partStatuses.Count > 0)
            {


                flowLayoutPanel.Controls.Clear();
                foreach (PartStatus partStatus in partStatuses)
                {
                    GroupBox groupBox = new GroupBox()
                    {
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    Label label_waiting_aircraft_number = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_part_number = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    Label label_stock_status = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };



                    label_waiting_aircraft.Text = partStatus.WaitingAircraftNumber;
                    SetLocation(label_waiting_aircraft, label_waiting_aircraft_title, groupBox);

                    label_part_number.Text = partStatus.PartNumber;
                    SetLocation(label_part_number, label_part_number_title, groupBox);

                    label_stock_status.Text = partStatus.StockStatus ? "VAR" : "YOK";
                    SetLocation(label_stock_status, label_stock_status_title, groupBox);

                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(label_waiting_aircraft);
                    groupBox.Controls.Add(label_part_number);
                    groupBox.Controls.Add(label_stock_status);
                }
            }
            else
            {
                flowLayoutPanel.Visible = false;
                GroupBox groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 897,
                };
                Label label_not_found = new Label()
                {
                    Text = "Herhangi Bir Kayıt Bulunamadı",
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 40.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                    Location = new Point(339, 407)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(label_not_found);
            }

        }
        private void SetLocation(Label content, Label title, GroupBox container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Width - content.Width) / 2, container.Height / 2);

            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Width - title.Width) / 2, container.Height / 2);
            }
        }
    }
}
