using Business.Abstract;
using Entities.Concrete;
using FormUI.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.UserControls.ViewControls
{
    public partial class PartStatusControl : UserControl
    {
        private readonly IPartService _partService;
        private readonly Base _base;
        private readonly int _claimId;

        public PartStatusControl(IPartService partStatusService, int claimId, Base @base)
        {
            InitializeComponent();
            _partService = partStatusService;
            _claimId = claimId;
            _base = @base;
        }

        private void PartStatusControl_Load(object sender, EventArgs e)
        {
            var partStatuses = _partService.GetAll(_base.BaseId).Data;
            if (partStatuses.Count > 0)
            {
                flowLayoutPanel.Controls.Clear();
                foreach (var partStatus in partStatuses)
                {
                    var index = partStatuses.IndexOf(partStatus);
                    var groupBox = new GroupBox()
                    {
                        Name = $@"groupBox_{index}",
                        Text = "",
                        Width = 1604,
                        Height = 60,
                    };
                    var buttonDelete = new Button()
                    {
                        Image = Resources.icons8_Delete_Key_32,
                        Height = 38,
                        Width = 38,
                        Location = new Point(1559, groupBox.Size.Height / 2 - 15),
                        Text = $@"{index}",
                        ForeColor = Color.Snow,
                        Font = new Font(FontFamily.GenericSansSerif, 1.0F)
                    };
                    var buttonChangeStatus = new Button()
                    {
                        Image = partStatus.StockStatus? Resources.icons8_close_32 : Resources.icons8_done_32,
                        Height = 38,
                        Width = 38,
                        Location = new Point(1519, groupBox.Size.Height / 2 - 15),
                        Text = $@"{index}",
                        ForeColor = Color.Snow,
                        Font = new Font(FontFamily.GenericSansSerif, 1.0F)
                    };
                    var labelWaitingAircraftNumber = new Label()
                    {
                        Name = $@"label_waiting_aircraft_number_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelPartNumber = new Label()
                    {
                        Name = $@"label_part_number_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelStockStatus = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    buttonDelete.Click += ButtonDeleteClick;
                    
                    buttonChangeStatus.Click += ButtonChangeStatusClick; 
                    toolTip1.SetToolTip(buttonChangeStatus, "Stok Durumunu Değiştir.");

                    labelWaitingAircraftNumber.Text = partStatus.PartName;
                    SetLocation(labelWaitingAircraftNumber, label_waiting_aircraft_title, groupBox);

                    labelPartNumber.Text = partStatus.PartNumber;
                    SetLocation(labelPartNumber, label_part_number_title, groupBox);

                    labelStockStatus.Text = partStatus.StockStatus ? "VAR" : "YOK";
                    SetLocation(labelStockStatus, label_stock_status_title, groupBox);

                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(labelWaitingAircraftNumber);
                    groupBox.Controls.Add(labelPartNumber);
                    groupBox.Controls.Add(labelStockStatus);
                    groupBox.Controls.Add(buttonDelete);
                    groupBox.Controls.Add(buttonChangeStatus);
                }
            }
            else
            {
                flowLayoutPanel.Visible = false;
                var groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 897,
                };
                var labelNotFound = new Label()
                {
                    Text = @"Herhangi Bir Kayıt Bulunamadı",
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 40.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                    Location = new Point(339, 407)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(labelNotFound);
            }
        }

        private static void SetLocation(Control content, Control title, Control container)
        {
            content.Location = new Point(title.Location.X, container.Height / 2);
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            var index = sender.ToString()?.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var waitingAircraftNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{index}"]
                .Controls[$"label_waiting_aircraft_number_{index}"].Text;
            var partNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{index}"]
                .Controls[$"label_part_number_{index}"].Text;
            var message = $@"{partNumber} No'lu Parçaya Ait Durum Kaydını Silmek İstediğinizden Emin Misiniz?";
            const MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var dialogResult = MessageBox.Show(message, "", buttons);
            if (dialogResult != DialogResult.Yes) return;
            var part = _partService.GetByPartNumberAndWaitingAircraftNumber(partNumber, waitingAircraftNumber).Data;
            var result = _partService.Delete(part, _claimId);
            MessageBox.Show(result.Message);
            PartStatusControl_Load(sender,e);
        }

        private void ButtonChangeStatusClick(object sender, EventArgs e)
        {
            var index = sender.ToString()?.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var waitingAircraftNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{index}"]
                .Controls[$"label_waiting_aircraft_number_{index}"].Text;
            var partNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{index}"]
                .Controls[$"label_part_number_{index}"].Text;
            var part = _partService.GetByPartNumberAndWaitingAircraftNumber(partNumber, waitingAircraftNumber).Data;
            part.StockStatus = !part.StockStatus;
            var result = _partService.Update(part, _claimId);
            MessageBox.Show(result.Message);
            PartStatusControl_Load(sender,e);
        }
    }
}