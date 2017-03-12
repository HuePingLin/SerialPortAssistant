using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;

namespace SerialPortAssistant
{
    public partial class MainForm : Form
    {

        #region Variables and Objects
        /// <summary>
        /// Serial port used to communicate with RF dungle
        /// </summary>
        private SerialPort comSerialPort = new SerialPort();
        /// <summary>
        /// Text buffer containing characters printed to terminal
        /// </summary>
        private TextBoxBuffer txtBoxBuffer = new TextBoxBuffer(8192);
        /// <summary>
        /// Data wanna sent to remote device or host
        /// </summary>
        private byte[] sentByte = new byte[1024];
        /// <summary>
        /// 
        /// </summary>
        private string sentString;
        
        #endregion

        #region .NET functions
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize parameters of Serial Port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAvailableSerialPort();
            if (this.comBoxSerialPortNo.Items.Count > 1)
            {
                this.comBoxSerialPortNo.Text = this.comBoxSerialPortNo.Items[1].ToString();
                InitializeCOMcomBox();
                if (this.btnOpenSerialPort.Enabled == false)
                    this.btnOpenSerialPort.Enabled = true;
            }
            else
            {
                MessageBox.Show("沒有可用的串列埠");
                return;
            }
        }

        /// <summary>
        /// Set properties of serial port according to the value
        /// selected in combobox controls and open this specified port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenSerialPort_Click(object sender, EventArgs e)
        {
            string serialPortInfo = string.Empty;
            if (string.IsNullOrEmpty(this.comBoxSerialPortNo.Text))
            {
                MessageBox.Show("No available com port!");
            }
            if (!comSerialPort.IsOpen)
            {
                try
                {
                    SetSerialPort();
                    comSerialPort.Open();
                    serialPortInfo = comSerialPort.PortName.ToString() + Environment.NewLine;
                    serialPortInfo += comSerialPort.DataBits.ToString() + Environment.NewLine;
                    serialPortInfo += comSerialPort.Parity.ToString() + Environment.NewLine;
                    serialPortInfo += comSerialPort.StopBits.ToString();
                    if (string.IsNullOrEmpty(serialPortInfo))
                    {
                        MessageBox.Show("Please select artibutes of serial port accordingly!");
                        return;
                    }
                    else
                        MessageBox.Show(serialPortInfo);
                }
                catch
                {
                    MessageBox.Show("Fail to open serial port!");
                }
            }
            else
            {
                try
                {
                    comSerialPort.Close();
                }
                catch
                {
                    MessageBox.Show("Fail to close serial port!");
                }
                ChangeBtnControlText();
            }
        }

        /// <summary>
        /// Close serial port and application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminateApp_Click(object sender, EventArgs e)
        {
            if (comSerialPort.IsOpen)
                comSerialPort.Close();
            Application.Exit();
            this.Close();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// Send data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendData_Click(object sender, EventArgs e)
        {
            string strData = CollectSentData();
            if (this.rdoBtnCharFormat.Checked)
            {
                MessageBox.Show("The sent data is :" + strData);
                //comSerialPort.Write(strData);
                MessageBox.Show("Data will be sent in text format!");
                comSerialPort.Write(strData);
            }
            if (this.rdoBtnHexFormat.Checked)
            {
                sentByte = Encoding.UTF8.GetBytes(strData);
                //comSerialPort.Write(sentByte, 0, sentByte.Length);
                MessageBox.Show("Data will be sent in hex format!");
            }
        }

        /// <summary>
        /// Method that process received data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region self defined objects and sub functions
        /// <summary>
        /// Sorting the available serial port and display in the comboBox control
        /// </summary>
        public void GetAvailableSerialPort()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                MessageBox.Show("沒有可用的串列埠!");
                this.btnOpenSerialPort.Enabled = false;
            }
            else
            {
                MessageBox.Show(ports.Length.ToString());
                List<string> portList = new List<string>(ports);
                // Sorting
                Comparison<string> comparer = (string port1, string port2) =>
                {
                    int p1 = Convert.ToInt32(port1.Remove(0, 3));
                    int p2 = Convert.ToInt32(port2.Remove(0, 3));
                    return p1 - p2;
                };
                portList.Sort(comparer);
                // display on the combo box control
                this.comBoxSerialPortNo.Items.AddRange(portList.ToArray());
                this.btnOpenSerialPort.Enabled = true;
            }
        }

        public void InitializeCOMcomBox()
        {
            // set Baud
            this.comBoxBaudRate.Items.Add("4800");
            this.comBoxBaudRate.Items.Add("9600");
            this.comBoxBaudRate.Items.Add("19200");
            this.comBoxBaudRate.Items.Add("38400");
            this.comBoxBaudRate.Items.Add("57600");
            this.comBoxBaudRate.Items.Add("115200");
            this.comBoxBaudRate.Items.ToString();
            // get 4800 as default value in comboBox
            this.comBoxBaudRate.Text = this.comBoxBaudRate.Items[0].ToString();
            // set data length
            this.comBoxDataLength.Items.Add("7");
            this.comBoxDataLength.Items.Add("8");
            // get 8 bits as default value in comboBox
            this.comBoxDataLength.Text = this.comBoxDataLength.Items[1].ToString();
            // set parity check bits
            this.comBoxCheckBit.DataSource = Enum.GetValues(typeof(Parity));
            // get None as default value in comboBox
            this.comBoxCheckBit.Text = this.comBoxCheckBit.Items[0].ToString();
            // set stop bit
            //this.comBoxStopBit.DataSource = Enum.GetValues(typeof(StopBits));
            this.comBoxStopBit.Items.Add("One");
            this.comBoxStopBit.Items.Add("OnePointFive");
            this.comBoxStopBit.Items.Add("Two");
            // get 1 stop bit as default value in comboBox
            this.comBoxStopBit.Text = this.comBoxStopBit.Items[0].ToString();
        }

        public void SetSerialPort()
        {
            // big logical problems here~
            if (this.comBoxSerialPortNo.Items.Count == 0)
            {
                MessageBox.Show("沒有可用的串列埠");
                //this.btnOpenSerialPort.Enabled = false;
                return;
            }
            comSerialPort.PortName = this.comBoxSerialPortNo.SelectedItem.ToString();
            comSerialPort.BaudRate = Convert.ToInt32(this.comBoxBaudRate.SelectedItem.ToString());
            comSerialPort.DataBits = Convert.ToInt32(this.comBoxDataLength.SelectedItem.ToString());
            //comSerialPort.StopBits = (StopBits)this.comBoxStopBit.SelectedItem;
            comSerialPort.StopBits = GetStopBits();
            comSerialPort.Parity = (Parity)this.comBoxCheckBit.SelectedItem;
        }

        public StopBits GetStopBits()
        {
            switch (this.comBoxStopBit.Text)
            {
                case "One":
                    return StopBits.One;
                case "OnePointFive":
                    return StopBits.OnePointFive;
                case "Two":
                    return StopBits.Two;
                default:
                    return StopBits.None;
            }
        }

        public string CollectSentData()
        {
            if (this.rdoBtnSendSingleString.Checked)
            {
                if (!string.IsNullOrEmpty(this.txtBoxSingleString.Text))
                {
                    return this.txtBoxSingleString.Text;
                }
                else
                {
                    MessageBox.Show("Sent data filed cannot be empty!");
                    return string.Empty;
                }
            }
            else if (this.rdoBtnSendATCommand.Checked)
            {
                if (!string.IsNullOrEmpty(this.comBoxATCommandList.SelectedText))
                {
                    return this.txtBoxSingleString.Text;
                }
                else
                {
                    MessageBox.Show("Sent data filed cannot be empty!");
                    return string.Empty;
                }
            }
            else if (this.rdoBtnSendTxtFile.Checked)
            {
                return string.Empty;
            }
            else
            {
                return null;
            }
        }

        public void ChangeBtnControlText()
        {
            if (comSerialPort.IsOpen)
            {
                this.btnOpenSerialPort.Text = "關閉串列埠";
            }
            else
            {
                this.btnOpenSerialPort.Text = "開啟串列埠";
            }
        }

        #endregion

    }

}
