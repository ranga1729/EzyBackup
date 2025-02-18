namespace EzyBackup
{
    public partial class MainForm : Form
    {
        private bool autoBackup = true;
        InitializedDevicesListForm deviceListForm = new InitializedDevicesListForm();

        public MainForm()
        {
            InitializeComponent();
            autoBackupCheckbox.CheckState = CheckState.Checked;
        }

        private void initializedDevicesVieButton_Click(object sender, EventArgs e)
        {
            if(deviceListForm != null)
            {
                deviceListForm.Show();
            }
            
        }

        private void autoBackupCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            autoBackup = autoBackupCheckbox.Checked;
            //textBox1.Text = autoBackupCheckbox.CheckState.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
