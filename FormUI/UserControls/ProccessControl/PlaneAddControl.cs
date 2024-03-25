using Business.Abstract;
using Entities.Concrete;
using FormUI.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormUI.UserControls.ProccessControl
{
    public partial class PlaneAddControl : UserControl
    {
        private readonly IPlaneService _planeService;
        private readonly IBaseService _baseService;
        private readonly int claimId;
        private readonly Base _base;
        public PlaneAddControl(IPlaneService planeService, Base @base, IBaseService baseService, int claimId)
        {
            InitializeComponent();
            _planeService = planeService;
            _base = @base;
            _baseService = baseService;
            this.claimId = claimId;
        }

        private void PlaneAddControl_Load(object sender, EventArgs e)
        {
            var planes = _planeService.GetAll(_base.BaseId).Data;
            var planeInBase = _baseService.GetPlaneNameByBase(_base);
            if (planeInBase.Count != 0)
            {
                comboBox1.DataSource = planeInBase;
                textBox1.Text = string.Empty;
            }
            if (planes.Count != 0)
            {

                flowLayoutPanel.Controls.Clear();
                flowLayoutPanel.Visible = true;
                foreach (var plane in planes)
                {
                    var index = planes.IndexOf(plane);

                    var groupBox = new GroupBox()
                    {
                        Name = $"groupBox_{index}",
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
                    var labelPlane = new Label()
                    {
                        Name = $"label_plane_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelPlaneType = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };


                    labelPlane.Text = plane.SerialNumber;
                    SetLocation(labelPlane, label_plane_title, groupBox);

                    labelPlaneType.Text = plane.PlaneType;
                    SetLocation(labelPlaneType, label_plane_type_title, groupBox);

                    buttonDelete.Click += button_delete_click;

                    flowLayoutPanel.Controls.Add(groupBox);
                    groupBox.Controls.Add(labelPlane);
                    groupBox.Controls.Add(labelPlaneType);
                    groupBox.Controls.Add(buttonDelete);
                }
            }
            else
            {
                flowLayoutPanel.Visible = false;
                var groupBox = new GroupBox()
                {
                    Text = "",
                    Width = 1604,
                    Height = 628,
                };
                var labelNotFound = new Label()
                {
                    Text = @"Herhangi Bir Kayıt Bulunamadı",
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 40.0F),
                    ForeColor = Color.FromArgb(152, 152, 152),
                    Location = new Point(339, 380)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(labelNotFound);
            }
        }
        private static void SetLocation(Control content, Control title, Control container)
        {
            if (title.Size.Width > content.Size.Width)
            {
                content.Location = new Point(title.Location.X + (title.Size.Width - content.Size.Width) / 2,
                    container.Height / 2 - 12);
            }
            else
            {
                content.Location = new Point(title.Location.X - (content.Size.Width - title.Size.Width) / 2,
                    container.Height / 2 - 12);
            }
        }

        private void button_delete_click(object sender, EventArgs e)
        {
            var index = sender.ToString()!.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var serialNumber = Controls["flowLayoutPanel"].Controls[$"groupBox_{index}"]
                .Controls[$"label_plane_{index}"].Text;
            var message = $@"{serialNumber} No'lu Uçağı Kayıtlardan Silmek İstediğinize Emin Misiniz?";
            var buttons = MessageBoxButtons.YesNo;
            var dialogResult = MessageBox.Show(message, "", buttons);
            if (dialogResult != DialogResult.Yes) return;
            var planeForDelete = _planeService.GetBySerialNumber(serialNumber, _base.BaseId).Data;
            var result = _planeService.Delete(planeForDelete.PlaneId, claimId);
            MessageBox.Show(result.Message);
            PlaneAddControl_Load(sender, e);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var plane = new Plane()
            {
                BaseId = _base.BaseId,
                PlaneType = comboBox1.SelectedValue.ToString(),
                SerialNumber = textBox1.Text
            };
            var result = _planeService.Add(plane, claimId);
            MessageBox.Show(result.Message);
            if(result.Success) PlaneAddControl_Load(sender,e);

        }
    }
}
