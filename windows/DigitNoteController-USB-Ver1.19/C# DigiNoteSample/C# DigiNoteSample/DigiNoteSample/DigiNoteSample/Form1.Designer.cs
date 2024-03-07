namespace DigiNoteSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_switchToRealTimeMode = new System.Windows.Forms.Button();
            this.m_switchToUploadMode = new System.Windows.Forms.Button();
            this.m_transferOldestFile = new System.Windows.Forms.Button();
            this.m_transferNewestFile = new System.Windows.Forms.Button();
            this.m_connectDevice = new System.Windows.Forms.Button();
            this.m_queryFileConut = new System.Windows.Forms.Button();
            this.m_getUploadFileInfo = new System.Windows.Forms.Button();
            this.m_stopTransfer = new System.Windows.Forms.Button();
            this.m_GetUploadFile = new System.Windows.Forms.Button();
            this.m_deleteUploadFile = new System.Windows.Forms.Button();
            this.m_disconnectDevice = new System.Windows.Forms.Button();
            this.m_getDeviceName = new System.Windows.Forms.Button();
            this.m_getDeviceFirmwareVersion = new System.Windows.Forms.Button();
            this.m_getDeviceBatteryState = new System.Windows.Forms.Button();
            this.m_setDeviceName = new System.Windows.Forms.Button();
            this.m_hardwareReset = new System.Windows.Forms.Button();
            this.m_factoryReset = new System.Windows.Forms.Button();
            this.m_openFileEncryptionWithKey = new System.Windows.Forms.Button();
            this.m_closeFileEncryptionByKey = new System.Windows.Forms.Button();
            this.m_verifyFileEncryptionByKey = new System.Windows.Forms.Button();
            this.m_queryFileEncryptionStatus = new System.Windows.Forms.Button();
            this.m_getDeviceDataTimeWithSecond = new System.Windows.Forms.Button();
            this.m_setDeviceDateTimeWithSecond = new System.Windows.Forms.Button();
            digiNoteTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_switchToRealTimeMode
            // 
            this.m_switchToRealTimeMode.Location = new System.Drawing.Point(401, 49);
            this.m_switchToRealTimeMode.Name = "m_switchToRealTimeMode";
            this.m_switchToRealTimeMode.Size = new System.Drawing.Size(210, 37);
            this.m_switchToRealTimeMode.TabIndex = 1;
            this.m_switchToRealTimeMode.Text = "switchToRealTimeMode";
            this.m_switchToRealTimeMode.UseVisualStyleBackColor = true;
            this.m_switchToRealTimeMode.Click += new System.EventHandler(this.switchToRealTimeMode_Click);
            // 
            // m_switchToUploadMode
            // 
            this.m_switchToUploadMode.Location = new System.Drawing.Point(658, 49);
            this.m_switchToUploadMode.Name = "m_switchToUploadMode";
            this.m_switchToUploadMode.Size = new System.Drawing.Size(210, 37);
            this.m_switchToUploadMode.TabIndex = 2;
            this.m_switchToUploadMode.Text = "switchToUploadMode";
            this.m_switchToUploadMode.UseVisualStyleBackColor = true;
            this.m_switchToUploadMode.Click += new System.EventHandler(this.switchToUploadMode_Click);
            // 
            // m_transferOldestFile
            // 
            this.m_transferOldestFile.Location = new System.Drawing.Point(255, 109);
            this.m_transferOldestFile.Name = "m_transferOldestFile";
            this.m_transferOldestFile.Size = new System.Drawing.Size(210, 37);
            this.m_transferOldestFile.TabIndex = 3;
            this.m_transferOldestFile.Text = "transferOldestFile";
            this.m_transferOldestFile.UseVisualStyleBackColor = true;
            this.m_transferOldestFile.Click += new System.EventHandler(this.transferOldestFile_Click);
            // 
            // m_transferNewestFile
            // 
            this.m_transferNewestFile.Location = new System.Drawing.Point(24, 109);
            this.m_transferNewestFile.Name = "m_transferNewestFile";
            this.m_transferNewestFile.Size = new System.Drawing.Size(210, 37);
            this.m_transferNewestFile.TabIndex = 4;
            this.m_transferNewestFile.Text = "transferNewestFile";
            this.m_transferNewestFile.UseVisualStyleBackColor = true;
            this.m_transferNewestFile.Click += new System.EventHandler(this.transferNewestFile_Click);
            // 
            // m_connectDevice
            // 
            this.m_connectDevice.Location = new System.Drawing.Point(12, 49);
            this.m_connectDevice.Name = "m_connectDevice";
            this.m_connectDevice.Size = new System.Drawing.Size(145, 37);
            this.m_connectDevice.TabIndex = 5;
            this.m_connectDevice.Text = "connectDevice";
            this.m_connectDevice.UseVisualStyleBackColor = true;
            this.m_connectDevice.Click += new System.EventHandler(this.connectDevice_Click);
            // 
            // m_queryFileConut
            // 
            this.m_queryFileConut.Location = new System.Drawing.Point(433, 170);
            this.m_queryFileConut.Name = "m_queryFileConut";
            this.m_queryFileConut.Size = new System.Drawing.Size(178, 37);
            this.m_queryFileConut.TabIndex = 6;
            this.m_queryFileConut.Text = "queryFileConut";
            this.m_queryFileConut.UseVisualStyleBackColor = true;
            this.m_queryFileConut.Click += new System.EventHandler(this.queryFileConut_Click);
            // 
            // m_getUploadFileInfo
            // 
            this.m_getUploadFileInfo.Location = new System.Drawing.Point(28, 170);
            this.m_getUploadFileInfo.Name = "m_getUploadFileInfo";
            this.m_getUploadFileInfo.Size = new System.Drawing.Size(178, 37);
            this.m_getUploadFileInfo.TabIndex = 7;
            this.m_getUploadFileInfo.Text = "getUploadFileInfo";
            this.m_getUploadFileInfo.UseVisualStyleBackColor = true;
            this.m_getUploadFileInfo.Click += new System.EventHandler(this.getUploadFileInfo_Click);
            // 
            // m_stopTransfer
            // 
            this.m_stopTransfer.Location = new System.Drawing.Point(482, 109);
            this.m_stopTransfer.Name = "m_stopTransfer";
            this.m_stopTransfer.Size = new System.Drawing.Size(178, 37);
            this.m_stopTransfer.TabIndex = 8;
            this.m_stopTransfer.Text = "stopTransfer";
            this.m_stopTransfer.UseVisualStyleBackColor = true;
            this.m_stopTransfer.Click += new System.EventHandler(this.stopTransfer_Click);
            // 
            // m_GetUploadFile
            // 
            this.m_GetUploadFile.Location = new System.Drawing.Point(232, 170);
            this.m_GetUploadFile.Name = "m_GetUploadFile";
            this.m_GetUploadFile.Size = new System.Drawing.Size(178, 37);
            this.m_GetUploadFile.TabIndex = 9;
            this.m_GetUploadFile.Text = "GetUploadFile";
            this.m_GetUploadFile.UseVisualStyleBackColor = true;
            this.m_GetUploadFile.Click += new System.EventHandler(this.GetUploadFile_Click);
            // 
            // m_deleteUploadFile
            // 
            this.m_deleteUploadFile.Location = new System.Drawing.Point(644, 170);
            this.m_deleteUploadFile.Name = "m_deleteUploadFile";
            this.m_deleteUploadFile.Size = new System.Drawing.Size(178, 37);
            this.m_deleteUploadFile.TabIndex = 10;
            this.m_deleteUploadFile.Text = "deleteUploadFile";
            this.m_deleteUploadFile.UseVisualStyleBackColor = true;
            this.m_deleteUploadFile.Click += new System.EventHandler(this.deleteUploadFile_Click);
            // 
            // m_disconnectDevice
            // 
            this.m_disconnectDevice.Location = new System.Drawing.Point(188, 49);
            this.m_disconnectDevice.Name = "m_disconnectDevice";
            this.m_disconnectDevice.Size = new System.Drawing.Size(168, 37);
            this.m_disconnectDevice.TabIndex = 14;
            this.m_disconnectDevice.Text = "disconnectDevice";
            this.m_disconnectDevice.UseVisualStyleBackColor = true;
            this.m_disconnectDevice.Click += new System.EventHandler(this.disconnectDevice_Click);
            // 
            // m_getDeviceName
            // 
            this.m_getDeviceName.Location = new System.Drawing.Point(499, 243);
            this.m_getDeviceName.Name = "m_getDeviceName";
            this.m_getDeviceName.Size = new System.Drawing.Size(170, 37);
            this.m_getDeviceName.TabIndex = 16;
            this.m_getDeviceName.Text = "getDeviceName";
            this.m_getDeviceName.UseVisualStyleBackColor = true;
            this.m_getDeviceName.Click += new System.EventHandler(this.getDeviceName_Click);
            // 
            // m_getDeviceFirmwareVersion
            // 
            this.m_getDeviceFirmwareVersion.Location = new System.Drawing.Point(12, 320);
            this.m_getDeviceFirmwareVersion.Name = "m_getDeviceFirmwareVersion";
            this.m_getDeviceFirmwareVersion.Size = new System.Drawing.Size(243, 37);
            this.m_getDeviceFirmwareVersion.TabIndex = 17;
            this.m_getDeviceFirmwareVersion.Text = "getDeviceFirmwareVersion";
            this.m_getDeviceFirmwareVersion.UseVisualStyleBackColor = true;
            this.m_getDeviceFirmwareVersion.Click += new System.EventHandler(this.getDeviceFirmwareVersion_Click);
            // 
            // m_getDeviceBatteryState
            // 
            this.m_getDeviceBatteryState.Location = new System.Drawing.Point(12, 243);
            this.m_getDeviceBatteryState.Name = "m_getDeviceBatteryState";
            this.m_getDeviceBatteryState.Size = new System.Drawing.Size(243, 37);
            this.m_getDeviceBatteryState.TabIndex = 18;
            this.m_getDeviceBatteryState.Text = "getDeviceBatteryState";
            this.m_getDeviceBatteryState.UseVisualStyleBackColor = true;
            this.m_getDeviceBatteryState.Click += new System.EventHandler(this.getDeviceBatteryState_Click);
            // 
            // m_setDeviceName
            // 
            this.m_setDeviceName.Location = new System.Drawing.Point(596, 320);
            this.m_setDeviceName.Name = "m_setDeviceName";
            this.m_setDeviceName.Size = new System.Drawing.Size(204, 37);
            this.m_setDeviceName.TabIndex = 19;
            this.m_setDeviceName.Text = "setDeviceName";
            this.m_setDeviceName.UseVisualStyleBackColor = true;
            this.m_setDeviceName.Click += new System.EventHandler(this.setDeviceName_Click);
            // 
            // m_hardwareReset
            // 
            this.m_hardwareReset.Location = new System.Drawing.Point(261, 243);
            this.m_hardwareReset.Name = "m_hardwareReset";
            this.m_hardwareReset.Size = new System.Drawing.Size(204, 37);
            this.m_hardwareReset.TabIndex = 20;
            this.m_hardwareReset.Text = "hardwareReset";
            this.m_hardwareReset.UseVisualStyleBackColor = true;
            this.m_hardwareReset.Click += new System.EventHandler(this.hardwareReset_Click);
            // 
            // m_factoryReset
            // 
            this.m_factoryReset.Location = new System.Drawing.Point(996, 228);
            this.m_factoryReset.Name = "m_factoryReset";
            this.m_factoryReset.Size = new System.Drawing.Size(204, 37);
            this.m_factoryReset.TabIndex = 21;
            this.m_factoryReset.Text = "factoryReset";
            this.m_factoryReset.UseVisualStyleBackColor = true;
            this.m_factoryReset.Click += new System.EventHandler(this.factoryReset_Click);
            // 
            // m_openFileEncryptionWithKey
            // 
            this.m_openFileEncryptionWithKey.Location = new System.Drawing.Point(12, 391);
            this.m_openFileEncryptionWithKey.Name = "m_openFileEncryptionWithKey";
            this.m_openFileEncryptionWithKey.Size = new System.Drawing.Size(261, 37);
            this.m_openFileEncryptionWithKey.TabIndex = 22;
            this.m_openFileEncryptionWithKey.Text = "openFileEncryptionWithKey";
            this.m_openFileEncryptionWithKey.UseVisualStyleBackColor = true;
            this.m_openFileEncryptionWithKey.Click += new System.EventHandler(this.openFileEncryptionWithKey_Click);
            // 
            // m_closeFileEncryptionByKey
            // 
            this.m_closeFileEncryptionByKey.Location = new System.Drawing.Point(303, 391);
            this.m_closeFileEncryptionByKey.Name = "m_closeFileEncryptionByKey";
            this.m_closeFileEncryptionByKey.Size = new System.Drawing.Size(253, 37);
            this.m_closeFileEncryptionByKey.TabIndex = 23;
            this.m_closeFileEncryptionByKey.Text = "closeFileEncryptionByKey";
            this.m_closeFileEncryptionByKey.UseVisualStyleBackColor = true;
            this.m_closeFileEncryptionByKey.Click += new System.EventHandler(this.closeFileEncryptionByKey_Click);
            // 
            // m_verifyFileEncryptionByKey
            // 
            this.m_verifyFileEncryptionByKey.Location = new System.Drawing.Point(585, 391);
            this.m_verifyFileEncryptionByKey.Name = "m_verifyFileEncryptionByKey";
            this.m_verifyFileEncryptionByKey.Size = new System.Drawing.Size(270, 37);
            this.m_verifyFileEncryptionByKey.TabIndex = 24;
            this.m_verifyFileEncryptionByKey.Text = "verifyFileEncryptionByKey";
            this.m_verifyFileEncryptionByKey.UseVisualStyleBackColor = true;
            this.m_verifyFileEncryptionByKey.Click += new System.EventHandler(this.verifyFileEncryptionByKey_Click);
            // 
            // m_queryFileEncryptionStatus
            // 
            this.m_queryFileEncryptionStatus.Location = new System.Drawing.Point(303, 320);
            this.m_queryFileEncryptionStatus.Name = "m_queryFileEncryptionStatus";
            this.m_queryFileEncryptionStatus.Size = new System.Drawing.Size(271, 37);
            this.m_queryFileEncryptionStatus.TabIndex = 25;
            this.m_queryFileEncryptionStatus.Text = "queryFileEncryptionStatus";
            this.m_queryFileEncryptionStatus.UseVisualStyleBackColor = true;
            this.m_queryFileEncryptionStatus.Click += new System.EventHandler(this.queryFileEncryptionStatus_Click);
            // 
            // m_getDeviceDataTimeWithSecond
            // 
            this.m_getDeviceDataTimeWithSecond.Location = new System.Drawing.Point(12, 462);
            this.m_getDeviceDataTimeWithSecond.Name = "m_getDeviceDataTimeWithSecond";
            this.m_getDeviceDataTimeWithSecond.Size = new System.Drawing.Size(261, 37);
            this.m_getDeviceDataTimeWithSecond.TabIndex = 26;
            this.m_getDeviceDataTimeWithSecond.Text = "getDeviceDataTimeWithSecond";
            this.m_getDeviceDataTimeWithSecond.UseVisualStyleBackColor = true;
            this.m_getDeviceDataTimeWithSecond.Click += new System.EventHandler(this.getDeviceDataTimeWithSecond_Click);
            // 
            // m_setDeviceDateTimeWithSecond
            // 
            this.m_setDeviceDateTimeWithSecond.Location = new System.Drawing.Point(303, 462);
            this.m_setDeviceDateTimeWithSecond.Name = "m_setDeviceDateTimeWithSecond";
            this.m_setDeviceDateTimeWithSecond.Size = new System.Drawing.Size(261, 37);
            this.m_setDeviceDateTimeWithSecond.TabIndex = 27;
            this.m_setDeviceDateTimeWithSecond.Text = "setDeviceDateTimeWithSecond";
            this.m_setDeviceDateTimeWithSecond.UseVisualStyleBackColor = true;
            this.m_setDeviceDateTimeWithSecond.Click += new System.EventHandler(this.setDeviceDateTimeWithSecond_Click);
            // 
            // digiNoteTextBox
            // 
            digiNoteTextBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            digiNoteTextBox.Location = new System.Drawing.Point(28, 701);
            digiNoteTextBox.Multiline = true;
            digiNoteTextBox.Name = "digiNoteTextBox";
            digiNoteTextBox.Size = new System.Drawing.Size(808, 243);
            digiNoteTextBox.TabIndex = 28;
            digiNoteTextBox.TextChanged += new System.EventHandler(this.digiNoteTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(912, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 976);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "scanBinaryCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 37);
            this.button2.TabIndex = 34;
            this.button2.Text = "getDeviceRatio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(303, 536);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 37);
            this.button3.TabIndex = 35;
            this.button3.Text = "getDeviceDataRange";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(596, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 37);
            this.button4.TabIndex = 36;
            this.button4.Text = "getDeviceSN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 610);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(261, 37);
            this.button5.TabIndex = 37;
            this.button5.Text = "setDeviceSN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(675, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(210, 37);
            this.button6.TabIndex = 38;
            this.button6.Text = "getDeviceMacAddr";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(675, 109);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(231, 37);
            this.button7.TabIndex = 39;
            this.button7.Text = "GetUploadFileBinaryCode";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 1071);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(digiNoteTextBox);
            this.Controls.Add(this.m_setDeviceDateTimeWithSecond);
            this.Controls.Add(this.m_getDeviceDataTimeWithSecond);
            this.Controls.Add(this.m_queryFileEncryptionStatus);
            this.Controls.Add(this.m_verifyFileEncryptionByKey);
            this.Controls.Add(this.m_closeFileEncryptionByKey);
            this.Controls.Add(this.m_openFileEncryptionWithKey);
            this.Controls.Add(this.m_factoryReset);
            this.Controls.Add(this.m_hardwareReset);
            this.Controls.Add(this.m_setDeviceName);
            this.Controls.Add(this.m_getDeviceBatteryState);
            this.Controls.Add(this.m_getDeviceFirmwareVersion);
            this.Controls.Add(this.m_getDeviceName);
            this.Controls.Add(this.m_disconnectDevice);
            this.Controls.Add(this.m_deleteUploadFile);
            this.Controls.Add(this.m_GetUploadFile);
            this.Controls.Add(this.m_stopTransfer);
            this.Controls.Add(this.m_getUploadFileInfo);
            this.Controls.Add(this.m_queryFileConut);
            this.Controls.Add(this.m_connectDevice);
            this.Controls.Add(this.m_transferNewestFile);
            this.Controls.Add(this.m_transferOldestFile);
            this.Controls.Add(this.m_switchToUploadMode);
            this.Controls.Add(this.m_switchToRealTimeMode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_switchToRealTimeMode;
        private System.Windows.Forms.Button m_switchToUploadMode;
        private System.Windows.Forms.Button m_transferOldestFile;
        private System.Windows.Forms.Button m_transferNewestFile;
        private System.Windows.Forms.Button m_connectDevice;
        private System.Windows.Forms.Button m_queryFileConut;
        private System.Windows.Forms.Button m_getUploadFileInfo;
        private System.Windows.Forms.Button m_stopTransfer;
        private System.Windows.Forms.Button m_GetUploadFile;
        private System.Windows.Forms.Button m_deleteUploadFile;
        private System.Windows.Forms.Button m_disconnectDevice;
        private System.Windows.Forms.Button m_getDeviceName;
        private System.Windows.Forms.Button m_getDeviceFirmwareVersion;
        private System.Windows.Forms.Button m_getDeviceBatteryState;
        private System.Windows.Forms.Button m_setDeviceName;
        private System.Windows.Forms.Button m_hardwareReset;
        private System.Windows.Forms.Button m_factoryReset;
        private System.Windows.Forms.Button m_openFileEncryptionWithKey;
        private System.Windows.Forms.Button m_closeFileEncryptionByKey;
        private System.Windows.Forms.Button m_verifyFileEncryptionByKey;
        private System.Windows.Forms.Button m_queryFileEncryptionStatus;
        private System.Windows.Forms.Button m_getDeviceDataTimeWithSecond;
        private System.Windows.Forms.Button m_setDeviceDateTimeWithSecond;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        static private System.Windows.Forms.TextBox digiNoteTextBox;
    }
}

    