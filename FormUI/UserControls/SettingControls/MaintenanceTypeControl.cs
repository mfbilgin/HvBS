using System;
using System.Drawing;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;
using FormUI.Properties;

namespace FormUI.UserControls.SettingControls
{
    public partial class MaintenanceTypeControl : UserControl
    {
        private readonly IMaintenanceTypeService _maintenanceTypeService;
        private readonly int _claimId;
        private readonly Base _base;
        private readonly MaintenanceType _maintenanceType = new MaintenanceType();

        public MaintenanceTypeControl(IMaintenanceTypeService maintenanceTypeService, int claimId, Base @base)
        {
            InitializeComponent();
            _maintenanceTypeService = maintenanceTypeService;
            _claimId = claimId;
            _base = @base;
        }

        private void MaintenanceTypeControl_Load(object sender, EventArgs e)
        {
            _maintenanceType.MaintenanceTypeId = 0;
            TextBoxValueClear();

            var types = _maintenanceTypeService.GetAll(_base.BaseId).Data;
            if (types.Count > 0)
            {
                flowLayoutPanel1.Visible = true;
                flowLayoutPanel1.Controls.Clear();
                foreach (var maintenanceType in types)
                {
                    var index = types.IndexOf(maintenanceType);
                    var groupBox = new GroupBox()
                    {
                        Name = $@"groupBox_{index}",
                        Text = "",
                        Width = 1604,
                        Height = 100,
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
                    var labelMaintenanceName = new Label()
                    {
                        Name = $@"label_maintenance_name_{index}",
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelMaintenancePeriot = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelDefinition = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };
                    var labelToDoDuringMaintenance = new Label()
                    {
                        AutoSize = true,
                        Font = new Font(FontFamily.GenericSansSerif, 10.0F),
                        ForeColor = Color.FromArgb(152, 152, 152),
                    };

                    buttonDelete.Click += button_delete_Click;

                    labelMaintenanceName.Text = maintenanceType.MaintenanceName;
                    SetLocation(labelMaintenanceName, label_maintenance_name_title, groupBox);

                    labelMaintenancePeriot.Text = maintenanceType.MaintenancePeriot;
                    SetLocation(labelMaintenancePeriot, label_maintenance_periot_title, groupBox)
                        ;
                    labelDefinition.Text = maintenanceType.Definition;
                    SetLocation(labelDefinition, label_definition_title, groupBox);

                    labelToDoDuringMaintenance.Text = maintenanceType.ToDoDuringMaintenance ?? "Belirtilmemiş";
                    SetLocation(labelToDoDuringMaintenance, label_to_do_during_maintenance_title, groupBox);

                    flowLayoutPanel1.Controls.Add(groupBox);
                    groupBox.Controls.Add(labelMaintenanceName);
                    groupBox.Controls.Add(labelMaintenancePeriot);
                    groupBox.Controls.Add(labelDefinition);
                    groupBox.Controls.Add(labelToDoDuringMaintenance);
                    groupBox.Controls.Add(buttonDelete);
                }
            }
            else
            {
                flowLayoutPanel1.Visible = false;
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
                    Location = new Point(339, 313)
                };
                Controls.Add(groupBox);
                groupBox.Controls.Add(labelNotFound);
            }
        }

        private static void SetLocation(Label content, Label title, GroupBox container)
        {

            content.Location = new Point(title.Location.X, container.Height / 2);

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            SetValues();
            var result = _maintenanceTypeService.Add(_maintenanceType, _claimId);
            MessageBox.Show(result.Message);
            MaintenanceTypeControl_Load(sender, e);
        }

        private void SetValues()
        {
            _maintenanceType.MaintenanceName = textBox_maintenance_name.Text;
            _maintenanceType.MaintenancePeriot = textBox_maintenance_periot.Text;
            _maintenanceType.Definition = textBox_definition.Text;
            _maintenanceType.ToDoDuringMaintenance = textBox_to_do_during_maintenance.Text;
            _maintenanceType.BaseId = _base.BaseId;
        }
        private void TextBoxValueClear()
        {
            textBox_definition.Text = "";
            textBox_maintenance_name.Text = "";
            textBox_maintenance_periot.Text = "";
            textBox_to_do_during_maintenance.Text = "";
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            var index = sender.ToString()?.ToCharArray()[sender.ToString()!.Length - 1].ToString();
            var flow = Controls["flowLayoutPanel1"];
            var groupBox = flow.Controls[$@"groupBox_{index}"];
            var maintenanceName = groupBox.Controls[$@"label_maintenance_name_{index}"].Text;
            var message = $@"{maintenanceName} İsimli Kaydı Silmek İstediğinizden Emin Misiniz?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var dialogResult = MessageBox.Show(message, "", buttons);
            if (dialogResult != DialogResult.Yes) return;
            var type = _maintenanceTypeService.GetByMaintenanceName(maintenanceName).Data;
            var result = _maintenanceTypeService.Delete(type, _claimId);
            MessageBox.Show(result.Message);
            MaintenanceTypeControl_Load(sender, e);


        }
    }
}