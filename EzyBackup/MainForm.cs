using System.IO;
using Newtonsoft.Json;

namespace EzyBackup
{
    public partial class MainForm : Form
    {
        ApplicationData applicationData = new ApplicationData();
        InitializedDevicesListForm? deviceListForm;
        NewDeviceInitializeForm? newDeviceInitializeForm;

        public MainForm()
        {
            InitializeComponent();
            autoBackupCheckbox.CheckState = CheckState.Checked;
        }

        private void autoBackupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            applicationData.AutoBackup = autoBackupCheckbox.Checked;
            //textBox1.Text = autoBackupCheckbox.CheckState.ToString();
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
