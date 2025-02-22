using System.IO;
using Newtonsoft.Json;

namespace EzyBackup
{
    public partial class MainForm : Form
    {
        ApplicationData applicationData;
        InitializedDevicesListForm? deviceListForm;
        NewDeviceInitializeForm? newDeviceInitializeForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            applicationData = ApplicationData.Load();
            autoBackupCheckbox.CheckState = applicationData.AutoBackup ? CheckState.Checked : CheckState.Unchecked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            applicationData.Save();
        }

        private void autoBackupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            applicationData.AutoBackup = autoBackupCheckbox.Checked;
        }

        private void initializedDevicesVieButton_Click(object sender, EventArgs e)
        {
            if (deviceListForm != null)
            {

                deviceListForm.Show();
            }
            else
            {
                deviceListForm = new InitializedDevicesListForm();
                deviceListForm.Show();
            }
        }

        private void newDeviceInitializeButton_Click(object sender, EventArgs e)
        {
            if (newDeviceInitializeForm != null)
            {

                newDeviceInitializeForm.Show();
            }
            else
            {
                newDeviceInitializeForm = new NewDeviceInitializeForm();
                newDeviceInitializeForm.Show();
            }
        }
    }
}
