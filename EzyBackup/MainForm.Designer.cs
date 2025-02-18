namespace EzyBackup
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            initializedDevicesVieButton = new Button();
            newDeviceInitializeButton = new Button();
            autoBackupCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // initializedDevicesVieButton
            // 
            initializedDevicesVieButton.Location = new Point(12, 48);
            initializedDevicesVieButton.Name = "initializedDevicesVieButton";
            initializedDevicesVieButton.Size = new Size(160, 23);
            initializedDevicesVieButton.TabIndex = 1;
            initializedDevicesVieButton.Text = "Check initialized devices";
            initializedDevicesVieButton.UseVisualStyleBackColor = true;
            initializedDevicesVieButton.Click += initializedDevicesVieButton_Click;
            // 
            // newDeviceInitializeButton
            // 
            newDeviceInitializeButton.Location = new Point(12, 88);
            newDeviceInitializeButton.Name = "newDeviceInitializeButton";
            newDeviceInitializeButton.Size = new Size(160, 23);
            newDeviceInitializeButton.TabIndex = 2;
            newDeviceInitializeButton.Text = "Initialize a new device";
            newDeviceInitializeButton.UseVisualStyleBackColor = true;
            newDeviceInitializeButton.Click += newDeviceInitializeButton_Click;
            // 
            // autoBackupCheckbox
            // 
            autoBackupCheckbox.AutoSize = true;
            autoBackupCheckbox.Location = new Point(12, 12);
            autoBackupCheckbox.Name = "autoBackupCheckbox";
            autoBackupCheckbox.RightToLeft = RightToLeft.Yes;
            autoBackupCheckbox.Size = new Size(94, 19);
            autoBackupCheckbox.TabIndex = 3;
            autoBackupCheckbox.Text = "Auto Backup";
            autoBackupCheckbox.UseVisualStyleBackColor = true;
            autoBackupCheckbox.CheckedChanged += autoBackupCheckbox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 131);
            Controls.Add(autoBackupCheckbox);
            Controls.Add(newDeviceInitializeButton);
            Controls.Add(initializedDevicesVieButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button initializedDevicesVieButton;
        private Button newDeviceInitializeButton;
        private CheckBox autoBackupCheckbox;
    }
}
