namespace SerialPortAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxSerialPortSetting = new System.Windows.Forms.GroupBox();
            this.lblStopBit = new System.Windows.Forms.Label();
            this.comBoxStopBit = new System.Windows.Forms.ComboBox();
            this.lblCheckBit = new System.Windows.Forms.Label();
            this.comBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.lblDataLength = new System.Windows.Forms.Label();
            this.comBoxDataLength = new System.Windows.Forms.ComboBox();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.comBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lblSerialPortNo = new System.Windows.Forms.Label();
            this.comBoxSerialPortNo = new System.Windows.Forms.ComboBox();
            this.grpBoxSerialPortSendData = new System.Windows.Forms.GroupBox();
            this.comBoxATCommandList = new System.Windows.Forms.ComboBox();
            this.rdoBtnSendTxtFile = new System.Windows.Forms.RadioButton();
            this.rdoBtnSendATCommand = new System.Windows.Forms.RadioButton();
            this.rdoBtnSendSingleString = new System.Windows.Forms.RadioButton();
            this.txtBoxSingleString = new System.Windows.Forms.TextBox();
            this.openTxtFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpBoxSendFormat = new System.Windows.Forms.GroupBox();
            this.rdoBtnCharFormat = new System.Windows.Forms.RadioButton();
            this.rdoBtnHexFormat = new System.Windows.Forms.RadioButton();
            this.btnSendData = new System.Windows.Forms.Button();
            this.grpBoxReceiveData = new System.Windows.Forms.GroupBox();
            this.grpBoxDisplayFormat = new System.Windows.Forms.GroupBox();
            this.rdoBtnCharDisplayFormat = new System.Windows.Forms.RadioButton();
            this.rdoBtnHexDisplayFormat = new System.Windows.Forms.RadioButton();
            this.txtBoxDataDisplay = new System.Windows.Forms.TextBox();
            this.btnOpenSerialPort = new System.Windows.Forms.Button();
            this.btnClearReceivedData = new System.Windows.Forms.Button();
            this.btnTerminateApp = new System.Windows.Forms.Button();
            this.lblSerialPortStatus = new System.Windows.Forms.Label();
            this.lblSerialPortCurrentStatus = new System.Windows.Forms.Label();
            this.grpBoxSerialPortSetting.SuspendLayout();
            this.grpBoxSerialPortSendData.SuspendLayout();
            this.grpBoxSendFormat.SuspendLayout();
            this.grpBoxReceiveData.SuspendLayout();
            this.grpBoxDisplayFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSerialPortSetting
            // 
            this.grpBoxSerialPortSetting.Controls.Add(this.lblStopBit);
            this.grpBoxSerialPortSetting.Controls.Add(this.comBoxStopBit);
            this.grpBoxSerialPortSetting.Controls.Add(this.lblCheckBit);
            this.grpBoxSerialPortSetting.Controls.Add(this.comBoxCheckBit);
            this.grpBoxSerialPortSetting.Controls.Add(this.lblDataLength);
            this.grpBoxSerialPortSetting.Controls.Add(this.comBoxDataLength);
            this.grpBoxSerialPortSetting.Controls.Add(this.lblBaudRate);
            this.grpBoxSerialPortSetting.Controls.Add(this.comBoxBaudRate);
            this.grpBoxSerialPortSetting.Controls.Add(this.lblSerialPortNo);
            this.grpBoxSerialPortSetting.Controls.Add(this.comBoxSerialPortNo);
            this.grpBoxSerialPortSetting.Location = new System.Drawing.Point(28, 25);
            this.grpBoxSerialPortSetting.Name = "grpBoxSerialPortSetting";
            this.grpBoxSerialPortSetting.Size = new System.Drawing.Size(249, 185);
            this.grpBoxSerialPortSetting.TabIndex = 0;
            this.grpBoxSerialPortSetting.TabStop = false;
            this.grpBoxSerialPortSetting.Text = "串列埠設置";
            // 
            // lblStopBit
            // 
            this.lblStopBit.AutoSize = true;
            this.lblStopBit.Location = new System.Drawing.Point(11, 147);
            this.lblStopBit.Name = "lblStopBit";
            this.lblStopBit.Size = new System.Drawing.Size(53, 12);
            this.lblStopBit.TabIndex = 9;
            this.lblStopBit.Text = "停止字元";
            // 
            // comBoxStopBit
            // 
            this.comBoxStopBit.FormattingEnabled = true;
            this.comBoxStopBit.Location = new System.Drawing.Point(86, 140);
            this.comBoxStopBit.Name = "comBoxStopBit";
            this.comBoxStopBit.Size = new System.Drawing.Size(138, 20);
            this.comBoxStopBit.TabIndex = 8;
            // 
            // lblCheckBit
            // 
            this.lblCheckBit.AutoSize = true;
            this.lblCheckBit.Location = new System.Drawing.Point(9, 120);
            this.lblCheckBit.Name = "lblCheckBit";
            this.lblCheckBit.Size = new System.Drawing.Size(53, 12);
            this.lblCheckBit.TabIndex = 7;
            this.lblCheckBit.Text = "校驗字元";
            // 
            // comBoxCheckBit
            // 
            this.comBoxCheckBit.FormattingEnabled = true;
            this.comBoxCheckBit.Location = new System.Drawing.Point(86, 113);
            this.comBoxCheckBit.Name = "comBoxCheckBit";
            this.comBoxCheckBit.Size = new System.Drawing.Size(138, 20);
            this.comBoxCheckBit.TabIndex = 6;
            // 
            // lblDataLength
            // 
            this.lblDataLength.AutoSize = true;
            this.lblDataLength.Location = new System.Drawing.Point(7, 94);
            this.lblDataLength.Name = "lblDataLength";
            this.lblDataLength.Size = new System.Drawing.Size(53, 12);
            this.lblDataLength.TabIndex = 5;
            this.lblDataLength.Text = "資料長度";
            // 
            // comBoxDataLength
            // 
            this.comBoxDataLength.FormattingEnabled = true;
            this.comBoxDataLength.Location = new System.Drawing.Point(86, 86);
            this.comBoxDataLength.Name = "comBoxDataLength";
            this.comBoxDataLength.Size = new System.Drawing.Size(138, 20);
            this.comBoxDataLength.TabIndex = 4;
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(7, 67);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(53, 12);
            this.lblBaudRate.TabIndex = 3;
            this.lblBaudRate.Text = "傳送速率";
            // 
            // comBoxBaudRate
            // 
            this.comBoxBaudRate.FormattingEnabled = true;
            this.comBoxBaudRate.Location = new System.Drawing.Point(86, 59);
            this.comBoxBaudRate.Name = "comBoxBaudRate";
            this.comBoxBaudRate.Size = new System.Drawing.Size(138, 20);
            this.comBoxBaudRate.TabIndex = 2;
            // 
            // lblSerialPortNo
            // 
            this.lblSerialPortNo.AutoSize = true;
            this.lblSerialPortNo.Location = new System.Drawing.Point(7, 40);
            this.lblSerialPortNo.Name = "lblSerialPortNo";
            this.lblSerialPortNo.Size = new System.Drawing.Size(65, 12);
            this.lblSerialPortNo.TabIndex = 1;
            this.lblSerialPortNo.Text = "串列埠編號";
            // 
            // comBoxSerialPortNo
            // 
            this.comBoxSerialPortNo.FormattingEnabled = true;
            this.comBoxSerialPortNo.Location = new System.Drawing.Point(86, 32);
            this.comBoxSerialPortNo.Name = "comBoxSerialPortNo";
            this.comBoxSerialPortNo.Size = new System.Drawing.Size(138, 20);
            this.comBoxSerialPortNo.TabIndex = 0;
            // 
            // grpBoxSerialPortSendData
            // 
            this.grpBoxSerialPortSendData.Controls.Add(this.comBoxATCommandList);
            this.grpBoxSerialPortSendData.Controls.Add(this.rdoBtnSendTxtFile);
            this.grpBoxSerialPortSendData.Controls.Add(this.rdoBtnSendATCommand);
            this.grpBoxSerialPortSendData.Controls.Add(this.rdoBtnSendSingleString);
            this.grpBoxSerialPortSendData.Controls.Add(this.txtBoxSingleString);
            this.grpBoxSerialPortSendData.Location = new System.Drawing.Point(306, 25);
            this.grpBoxSerialPortSendData.Name = "grpBoxSerialPortSendData";
            this.grpBoxSerialPortSendData.Size = new System.Drawing.Size(409, 119);
            this.grpBoxSerialPortSendData.TabIndex = 1;
            this.grpBoxSerialPortSendData.TabStop = false;
            this.grpBoxSerialPortSendData.Text = "串列埠傳送資料";
            // 
            // comBoxATCommandList
            // 
            this.comBoxATCommandList.FormattingEnabled = true;
            this.comBoxATCommandList.Location = new System.Drawing.Point(114, 58);
            this.comBoxATCommandList.Name = "comBoxATCommandList";
            this.comBoxATCommandList.Size = new System.Drawing.Size(282, 20);
            this.comBoxATCommandList.TabIndex = 6;
            // 
            // rdoBtnSendTxtFile
            // 
            this.rdoBtnSendTxtFile.AutoSize = true;
            this.rdoBtnSendTxtFile.Location = new System.Drawing.Point(19, 94);
            this.rdoBtnSendTxtFile.Name = "rdoBtnSendTxtFile";
            this.rdoBtnSendTxtFile.Size = new System.Drawing.Size(95, 16);
            this.rdoBtnSendTxtFile.TabIndex = 5;
            this.rdoBtnSendTxtFile.TabStop = true;
            this.rdoBtnSendTxtFile.Text = "發送文字檔案";
            this.rdoBtnSendTxtFile.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSendATCommand
            // 
            this.rdoBtnSendATCommand.AutoSize = true;
            this.rdoBtnSendATCommand.Location = new System.Drawing.Point(19, 62);
            this.rdoBtnSendATCommand.Name = "rdoBtnSendATCommand";
            this.rdoBtnSendATCommand.Size = new System.Drawing.Size(86, 16);
            this.rdoBtnSendATCommand.TabIndex = 4;
            this.rdoBtnSendATCommand.TabStop = true;
            this.rdoBtnSendATCommand.Text = "發送AT指令";
            this.rdoBtnSendATCommand.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSendSingleString
            // 
            this.rdoBtnSendSingleString.AutoSize = true;
            this.rdoBtnSendSingleString.Location = new System.Drawing.Point(19, 30);
            this.rdoBtnSendSingleString.Name = "rdoBtnSendSingleString";
            this.rdoBtnSendSingleString.Size = new System.Drawing.Size(95, 16);
            this.rdoBtnSendSingleString.TabIndex = 3;
            this.rdoBtnSendSingleString.TabStop = true;
            this.rdoBtnSendSingleString.Text = "發送單筆字串";
            this.rdoBtnSendSingleString.UseVisualStyleBackColor = true;
            // 
            // txtBoxSingleString
            // 
            this.txtBoxSingleString.Location = new System.Drawing.Point(114, 29);
            this.txtBoxSingleString.Name = "txtBoxSingleString";
            this.txtBoxSingleString.Size = new System.Drawing.Size(282, 22);
            this.txtBoxSingleString.TabIndex = 1;
            // 
            // openTxtFileDialog
            // 
            this.openTxtFileDialog.FileName = "openFileDialog1";
            // 
            // grpBoxSendFormat
            // 
            this.grpBoxSendFormat.Controls.Add(this.rdoBtnCharFormat);
            this.grpBoxSendFormat.Controls.Add(this.rdoBtnHexFormat);
            this.grpBoxSendFormat.Location = new System.Drawing.Point(306, 151);
            this.grpBoxSendFormat.Name = "grpBoxSendFormat";
            this.grpBoxSendFormat.Size = new System.Drawing.Size(227, 59);
            this.grpBoxSendFormat.TabIndex = 2;
            this.grpBoxSendFormat.TabStop = false;
            this.grpBoxSendFormat.Text = "資料傳送格式";
            // 
            // rdoBtnCharFormat
            // 
            this.rdoBtnCharFormat.AutoSize = true;
            this.rdoBtnCharFormat.Location = new System.Drawing.Point(139, 21);
            this.rdoBtnCharFormat.Name = "rdoBtnCharFormat";
            this.rdoBtnCharFormat.Size = new System.Drawing.Size(71, 16);
            this.rdoBtnCharFormat.TabIndex = 1;
            this.rdoBtnCharFormat.TabStop = true;
            this.rdoBtnCharFormat.Text = "字元格式";
            this.rdoBtnCharFormat.UseVisualStyleBackColor = true;
            // 
            // rdoBtnHexFormat
            // 
            this.rdoBtnHexFormat.AutoSize = true;
            this.rdoBtnHexFormat.Location = new System.Drawing.Point(7, 22);
            this.rdoBtnHexFormat.Name = "rdoBtnHexFormat";
            this.rdoBtnHexFormat.Size = new System.Drawing.Size(83, 16);
            this.rdoBtnHexFormat.TabIndex = 0;
            this.rdoBtnHexFormat.TabStop = true;
            this.rdoBtnHexFormat.Text = "16進位格式";
            this.rdoBtnHexFormat.UseVisualStyleBackColor = true;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(572, 166);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(75, 23);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "傳送資料";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // grpBoxReceiveData
            // 
            this.grpBoxReceiveData.Controls.Add(this.grpBoxDisplayFormat);
            this.grpBoxReceiveData.Controls.Add(this.txtBoxDataDisplay);
            this.grpBoxReceiveData.Location = new System.Drawing.Point(28, 235);
            this.grpBoxReceiveData.Name = "grpBoxReceiveData";
            this.grpBoxReceiveData.Size = new System.Drawing.Size(687, 228);
            this.grpBoxReceiveData.TabIndex = 4;
            this.grpBoxReceiveData.TabStop = false;
            this.grpBoxReceiveData.Text = "接收資料";
            // 
            // grpBoxDisplayFormat
            // 
            this.grpBoxDisplayFormat.Controls.Add(this.rdoBtnCharDisplayFormat);
            this.grpBoxDisplayFormat.Controls.Add(this.rdoBtnHexDisplayFormat);
            this.grpBoxDisplayFormat.Location = new System.Drawing.Point(13, 161);
            this.grpBoxDisplayFormat.Name = "grpBoxDisplayFormat";
            this.grpBoxDisplayFormat.Size = new System.Drawing.Size(189, 46);
            this.grpBoxDisplayFormat.TabIndex = 1;
            this.grpBoxDisplayFormat.TabStop = false;
            this.grpBoxDisplayFormat.Text = "顯示格式";
            // 
            // rdoBtnCharDisplayFormat
            // 
            this.rdoBtnCharDisplayFormat.AutoSize = true;
            this.rdoBtnCharDisplayFormat.Location = new System.Drawing.Point(107, 21);
            this.rdoBtnCharDisplayFormat.Name = "rdoBtnCharDisplayFormat";
            this.rdoBtnCharDisplayFormat.Size = new System.Drawing.Size(71, 16);
            this.rdoBtnCharDisplayFormat.TabIndex = 1;
            this.rdoBtnCharDisplayFormat.TabStop = true;
            this.rdoBtnCharDisplayFormat.Text = "字元格式";
            this.rdoBtnCharDisplayFormat.UseVisualStyleBackColor = true;
            // 
            // rdoBtnHexDisplayFormat
            // 
            this.rdoBtnHexDisplayFormat.AutoSize = true;
            this.rdoBtnHexDisplayFormat.Location = new System.Drawing.Point(18, 21);
            this.rdoBtnHexDisplayFormat.Name = "rdoBtnHexDisplayFormat";
            this.rdoBtnHexDisplayFormat.Size = new System.Drawing.Size(83, 16);
            this.rdoBtnHexDisplayFormat.TabIndex = 0;
            this.rdoBtnHexDisplayFormat.TabStop = true;
            this.rdoBtnHexDisplayFormat.Text = "16進位格式";
            this.rdoBtnHexDisplayFormat.UseVisualStyleBackColor = true;
            // 
            // txtBoxDataDisplay
            // 
            this.txtBoxDataDisplay.Location = new System.Drawing.Point(13, 33);
            this.txtBoxDataDisplay.Multiline = true;
            this.txtBoxDataDisplay.Name = "txtBoxDataDisplay";
            this.txtBoxDataDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDataDisplay.Size = new System.Drawing.Size(643, 122);
            this.txtBoxDataDisplay.TabIndex = 0;
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(28, 485);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(84, 23);
            this.btnOpenSerialPort.TabIndex = 5;
            this.btnOpenSerialPort.Text = "開啟串列埠";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // btnClearReceivedData
            // 
            this.btnClearReceivedData.Location = new System.Drawing.Point(144, 485);
            this.btnClearReceivedData.Name = "btnClearReceivedData";
            this.btnClearReceivedData.Size = new System.Drawing.Size(86, 23);
            this.btnClearReceivedData.TabIndex = 6;
            this.btnClearReceivedData.Text = "清除接收資料";
            this.btnClearReceivedData.UseVisualStyleBackColor = true;
            // 
            // btnTerminateApp
            // 
            this.btnTerminateApp.Location = new System.Drawing.Point(267, 485);
            this.btnTerminateApp.Name = "btnTerminateApp";
            this.btnTerminateApp.Size = new System.Drawing.Size(75, 23);
            this.btnTerminateApp.TabIndex = 7;
            this.btnTerminateApp.Text = "結束程式";
            this.btnTerminateApp.UseVisualStyleBackColor = true;
            this.btnTerminateApp.Click += new System.EventHandler(this.btnTerminateApp_Click);
            // 
            // lblSerialPortStatus
            // 
            this.lblSerialPortStatus.AutoSize = true;
            this.lblSerialPortStatus.Location = new System.Drawing.Point(26, 527);
            this.lblSerialPortStatus.Name = "lblSerialPortStatus";
            this.lblSerialPortStatus.Size = new System.Drawing.Size(100, 12);
            this.lblSerialPortStatus.TabIndex = 8;
            this.lblSerialPortStatus.Text = "串列埠狀態(開/關)";
            // 
            // lblSerialPortCurrentStatus
            // 
            this.lblSerialPortCurrentStatus.AutoSize = true;
            this.lblSerialPortCurrentStatus.Location = new System.Drawing.Point(142, 527);
            this.lblSerialPortCurrentStatus.Name = "lblSerialPortCurrentStatus";
            this.lblSerialPortCurrentStatus.Size = new System.Drawing.Size(0, 12);
            this.lblSerialPortCurrentStatus.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblSerialPortCurrentStatus);
            this.Controls.Add(this.lblSerialPortStatus);
            this.Controls.Add(this.btnTerminateApp);
            this.Controls.Add(this.btnClearReceivedData);
            this.Controls.Add(this.btnOpenSerialPort);
            this.Controls.Add(this.grpBoxReceiveData);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.grpBoxSendFormat);
            this.Controls.Add(this.grpBoxSerialPortSendData);
            this.Controls.Add(this.grpBoxSerialPortSetting);
            this.Name = "MainForm";
            this.Text = "SerialPortAssistant";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxSerialPortSetting.ResumeLayout(false);
            this.grpBoxSerialPortSetting.PerformLayout();
            this.grpBoxSerialPortSendData.ResumeLayout(false);
            this.grpBoxSerialPortSendData.PerformLayout();
            this.grpBoxSendFormat.ResumeLayout(false);
            this.grpBoxSendFormat.PerformLayout();
            this.grpBoxReceiveData.ResumeLayout(false);
            this.grpBoxReceiveData.PerformLayout();
            this.grpBoxDisplayFormat.ResumeLayout(false);
            this.grpBoxDisplayFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSerialPortSetting;
        private System.Windows.Forms.Label lblDataLength;
        private System.Windows.Forms.ComboBox comBoxDataLength;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox comBoxBaudRate;
        private System.Windows.Forms.Label lblSerialPortNo;
        private System.Windows.Forms.ComboBox comBoxSerialPortNo;
        private System.Windows.Forms.Label lblStopBit;
        private System.Windows.Forms.ComboBox comBoxStopBit;
        private System.Windows.Forms.Label lblCheckBit;
        private System.Windows.Forms.ComboBox comBoxCheckBit;
        private System.Windows.Forms.GroupBox grpBoxSerialPortSendData;
        private System.Windows.Forms.TextBox txtBoxSingleString;
        private System.Windows.Forms.ComboBox comBoxATCommandList;
        private System.Windows.Forms.RadioButton rdoBtnSendTxtFile;
        private System.Windows.Forms.RadioButton rdoBtnSendATCommand;
        private System.Windows.Forms.RadioButton rdoBtnSendSingleString;
        private System.Windows.Forms.OpenFileDialog openTxtFileDialog;
        private System.Windows.Forms.GroupBox grpBoxSendFormat;
        private System.Windows.Forms.RadioButton rdoBtnCharFormat;
        private System.Windows.Forms.RadioButton rdoBtnHexFormat;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.GroupBox grpBoxReceiveData;
        private System.Windows.Forms.GroupBox grpBoxDisplayFormat;
        private System.Windows.Forms.RadioButton rdoBtnCharDisplayFormat;
        private System.Windows.Forms.RadioButton rdoBtnHexDisplayFormat;
        private System.Windows.Forms.TextBox txtBoxDataDisplay;
        private System.Windows.Forms.Button btnOpenSerialPort;
        private System.Windows.Forms.Button btnClearReceivedData;
        private System.Windows.Forms.Button btnTerminateApp;
        private System.Windows.Forms.Label lblSerialPortStatus;
        private System.Windows.Forms.Label lblSerialPortCurrentStatus;
    }
}

