using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiNoteSample
{
    public partial class Form1 : Form
    {
        static int xx = 0;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForConnectDeviceSuccess(string deviceBleMac, string deviceBleName);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForConnectDeviceSuccess([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForConnectDeviceSuccess stProgressCallbackForConnectDeviceSuccess);
        
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForRealTimePenDatas(int x, int y, int pressure);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForRealTimePenDatas([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForRealTimePenDatas stProgressCallbackForRealTimePenDatas);

        
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForUploadFileStatus(int speed, int percentage, int totalSize);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForUploadFileStatus([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForUploadFileStatus stProgressCallbackForUploadFileStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForUploadFilePenData(int x, int y, int pressure);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForUploadFilePenData([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForUploadFilePenData stProgressCallbackForUploadFilePenData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForSearchDevice(string deviceBleMac, string deviceBleName, int rssi);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForSearchDevice([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForSearchDevice stProgressCallbackForSearchDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForButton(int buttonValue);

        [DllImport("DigitNoteController.dll")]
        public static extern void SetCallBackForButton([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForButton stProgressCallbackForButton);

        [DllImport("DigitNoteController.dll")]
        public static extern int openPort();

        [DllImport("DigitNoteController.dll")]
        public static extern int switchToRealTimeMode();

        [DllImport("DigitNoteController.dll")]
        public static extern int switchToUploadMode();

        [DllImport("DigitNoteController.dll")]
        public static extern int transferOldestFile();

        [DllImport("DigitNoteController.dll")]
        public static extern int queryFileConut(ref int fileConut);

        [DllImport("DigitNoteController.dll")]
        public static extern int transferNewestFile();

        [DllImport("DigitNoteController.dll")]
        public static extern int getUploadFileInfo(ref int fileSize, ref int fileDateTime);

        [DllImport("DigitNoteController.dll")]
        public static extern int stopTransfer();

        [DllImport("DigitNoteController.dll")]
        public static extern int GetUploadFile();

        [DllImport("DigitNoteController.dll")]
        public static extern int deleteUploadFile();

        [DllImport("DigitNoteController.dll")]
        public static extern int getDGBleInfo(ref byte dgBleName, ref byte dgBleMac);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDGVersion(ref byte dgVersion);

        [DllImport("DigitNoteController.dll")]
        public static extern int setDGBleName(ref byte deBleName);

        [DllImport("DigitNoteController.dll")]
        public static extern int connectDevice();

        [DllImport("DigitNoteController.dll")]
        public static extern int disconnectDevice(ref byte deviceBleMac, ref byte deviceBleName);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceBleInfo(ref byte deviceBleMac, ref byte deviceBleName);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceDataTimeWithSecond(ref int deviceDataTime);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceName(ref byte deviceName);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceFirmwareVersion(ref byte bleVersion, ref byte mcuVersion);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceBatteryState(ref int batteryPercentage, ref int batteryState);

        [DllImport("DigitNoteController.dll")]
        public static extern int setDeviceDateTimeWithSecond(int dataTimeWithSeconde);

        [DllImport("DigitNoteController.dll")]
        public static extern int setDeviceName(ref byte deviceName);

        [DllImport("DigitNoteController.dll")]
        public static extern int hardwareReset();

        [DllImport("DigitNoteController.dll")]
        public static extern int factoryReset();

        [DllImport("DigitNoteController.dll")]
        public static extern int openFileEncryptionWithKey(ref byte key);

        [DllImport("DigitNoteController.dll")]
        public static extern int closeFileEncryptionByKey(ref byte key);

        [DllImport("DigitNoteController.dll")]
        public static extern int verifyFileEncryptionByKey(ref byte key);

        [DllImport("DigitNoteController.dll")]
        public static extern int queryFileEncryptionStatus(ref int FileEncryptStatus);

        [DllImport("DigitNoteController.dll")]
        public static extern int connectDeviceByMac(ref byte macAddr);

        [DllImport("DigitNoteController.dll")]
        public static extern int searchDevice();

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceSN(ref byte deviceSN);

        [DllImport("DigitNoteController.dll")]
        public static extern int setDeviceSN(ref byte deviceSN);

        [DllImport("DigitNoteController.dll")]
        public static extern int getDeviceRatio(ref int length, ref int widht);

        [DllImport("DigitNoteController.dll")]
        public static extern int setMonitorNum(ref int value);

        [DllImport("DigitNoteController.dll")]
        public static extern int scanBinaryCode(ref int iBinaryCode);

        [DllImport("DigitNoteController.dll")]
        public static extern int testOnLigh();

        [DllImport("DigitNoteController.dll")]
        public static extern int testOffLigh();

        [DllImport("DigitNoteController.dll")]
        public static extern int testOnA5BlueLigh();

        [DllImport("DigitNoteController.dll")]
        public static extern int testOnA5WhiteLigh();

        [DllImport("DigitNoteController.dll")]
        public static extern int testOffA5Ligh();

        public void ProgressCallbackForConnectDeviceSuccesskCSharp(string deviceBleMac, string deviceBleName)
        {
            //string stdeviceBleMac = System.Text.Encoding.Default.GetString(deviceBleMac);
            //string stdeviceBleName = System.Text.Encoding.Default.GetString(deviceBleName);
            deviceBleMac = deviceBleMac.TrimEnd('\0');
            deviceBleName = deviceBleName.TrimEnd('\0');
            digiNoteTextBox.Text = "deviceBleMac: " + deviceBleMac + " deviceBleName: " + deviceBleName;
        }

        static int drawPreX = 0, drawPreY = 0, drawPreP = 0, drawCurrX = 0, drawCurrY = 0, drawCurrP = 0;

        public void ProgressCallbackForRealTimePenDatasCSharp(int x, int y, int pressure)
        {
           digiNoteTextBox.Text = "x: " + x + "y: " + y + "pressure: " + pressure;
            drawCurrX = x / 75;
            drawCurrY = y / 75;
            drawCurrP = pressure;
            if (drawCurrP > 0 && drawPreP > 0)
            {
                Graphics gfx = pictureBox1.CreateGraphics();
                gfx.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gfx.DrawLine(Pens.Black, new Point(drawPreX, drawPreY), new Point(drawCurrX, drawCurrY));
                gfx.Dispose();
            }
            drawPreX = drawCurrX;
            drawPreY = drawCurrY;
            drawPreP = drawCurrP;
        }

        public void ProgressCallbackForUploadFileStatusCSharp(int speed, int percentage, int totalSize)
        {
            digiNoteTextBox.Text = "speed: " + speed + "percentage: " + percentage + "totalSize: " + totalSize;
        }

        public void ProgressCallbackForUploadFilePenDataCSharp(int x, int y, int pressure)
        {
            digiNoteTextBox.Text = "x: " + x + "y: " + y + "pressure: " + pressure;
        }

        public void ProgressCallbackForSearchDeviceCSharp(string deviceBleMac, string deviceBleName, int rssi)
        {
            digiNoteTextBox.Text += Environment.NewLine + "deviceBleMac: " + deviceBleMac + "deviceBleName: " + deviceBleName + " rssi: " + rssi;
        }

        static int buttonTot = 0;
        public void ProgressCallbackForButtonCSharp(int buttonValue)
        {
            ++buttonTot;
            digiNoteTextBox.Text = "buttonValue: " + buttonValue + "Buttontot: " + buttonTot;
        }


        static ProgressCallbackForConnectDeviceSuccess stProgressCallbackForConnectDeviceSuccess;
        static ProgressCallbackForRealTimePenDatas stProgressCallbackForRealTimePenDatas;
        static ProgressCallbackForUploadFileStatus stProgressCallbackForUploadFileStatus;
        static ProgressCallbackForUploadFilePenData stProgressCallbackForUploadFilePenData;
        static ProgressCallbackForSearchDevice stProgressCallbackForSearchDevice;
        static ProgressCallbackForButton stProgressCallbackForButton;

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            
            stProgressCallbackForConnectDeviceSuccess = new ProgressCallbackForConnectDeviceSuccess(ProgressCallbackForConnectDeviceSuccesskCSharp);
            SetCallBackForConnectDeviceSuccess(stProgressCallbackForConnectDeviceSuccess);
            
            stProgressCallbackForRealTimePenDatas = new ProgressCallbackForRealTimePenDatas(ProgressCallbackForRealTimePenDatasCSharp);
            SetCallBackForRealTimePenDatas(stProgressCallbackForRealTimePenDatas);

            
            stProgressCallbackForUploadFileStatus = new ProgressCallbackForUploadFileStatus(ProgressCallbackForUploadFileStatusCSharp);
            SetCallBackForUploadFileStatus(stProgressCallbackForUploadFileStatus);

            stProgressCallbackForUploadFilePenData = new ProgressCallbackForUploadFilePenData(ProgressCallbackForUploadFilePenDataCSharp);
            SetCallBackForUploadFilePenData(stProgressCallbackForUploadFilePenData);

            stProgressCallbackForSearchDevice = new ProgressCallbackForSearchDevice(ProgressCallbackForSearchDeviceCSharp);
            SetCallBackForSearchDevice(stProgressCallbackForSearchDevice);

            stProgressCallbackForButton = new ProgressCallbackForButton(ProgressCallbackForButtonCSharp);
            SetCallBackForButton(stProgressCallbackForButton);
        }
        
        private void openPort_Click(object sender, EventArgs e)
        {
           digiNoteTextBox.Text = "waiting...";
           int ret = openPort();
           digiNoteTextBox.Text = "ret: " + ret;
        }

        private void switchToRealTimeMode_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = switchToRealTimeMode();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void switchToUploadMode_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = switchToUploadMode();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void transferOldestFile_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = transferOldestFile();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void transferNewestFile_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = transferNewestFile();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void connectDevice_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = connectDevice();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void getUploadFileInfo_Click(object sender, EventArgs e)
        {
            int fileSize = 0;
            int fileDateTime = 0;
            digiNoteTextBox.Text = "waiting...";
            int ret = getUploadFileInfo(ref fileSize, ref fileDateTime);
            digiNoteTextBox.Text = "ret: " + ret + " fileSize: " + fileSize + " fileDateTime: " + fileDateTime;
        }

        private void queryFileConut_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int fileConut = 0;
            int ret = queryFileConut(ref fileConut);
            digiNoteTextBox.Text = "ret: " + ret + " fileConut: " + fileConut;
        }

        private void stopTransfer_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = stopTransfer();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void GetUploadFile_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = GetUploadFile();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void deleteUploadFile_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = deleteUploadFile();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void getDGBleInfo_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] dgBleName = new byte[50];
            byte[] dgBleMac = new byte[50];
            int ret = getDGBleInfo(ref dgBleName[0], ref dgBleMac[0]);
            string stdgBleName = Encoding.Default.GetString(dgBleName).TrimEnd('\0');
            string stdgBleMac = Encoding.Default.GetString(dgBleMac).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " dgBleName: " + stdgBleName + " dgBleMac: " + stdgBleMac;
        }

        private void getDGVersion_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] dgVersion = new byte[50];
            int ret = getDGVersion(ref dgVersion[0]);
            string stdgVersion = System.Text.Encoding.Default.GetString(dgVersion).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " dgVersion: " + stdgVersion;
        }

        private void setDGBleName_Click(object sender, EventArgs e)
        {
            byte[] deBleName = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = setDGBleName(ref deBleName[0]);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void disconnectDevice_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] deviceBleMac = new byte[50];
            byte[] deviceBleName = new byte[50];
            int ret = disconnectDevice(ref deviceBleMac[0], ref deviceBleName[0]);
            string stdeviceBleMac = System.Text.Encoding.Default.GetString(deviceBleMac).TrimEnd('\0');
            string stdeviceBleName = System.Text.Encoding.Default.GetString(deviceBleName).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceBleMac: " + stdeviceBleMac + " deviceBleName: " + stdeviceBleName;
        }

        private void getDeviceBleInfo_Click(object sender, EventArgs e)
        {
            byte[] deviceBleMac = new byte[50];
            byte[] deviceBleName = new byte[50];
            int ret = getDeviceBleInfo(ref deviceBleMac[0], ref deviceBleName[0]);
            string stdeviceBleMac = System.Text.Encoding.Default.GetString(deviceBleMac).TrimEnd('\0');
            string stdeviceBleName = System.Text.Encoding.Default.GetString(deviceBleName).TrimEnd('\0');

        }

        private void getDeviceName_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] deviceName = new byte[50];
            int ret = getDeviceName(ref deviceName[0]);
            string stdeviceName = System.Text.Encoding.Default.GetString(deviceName).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceName: " + stdeviceName;
        }

        private void setDeviceName_Click(object sender, EventArgs e)
        {
            byte[] deviceName = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = setDeviceName(ref deviceName[0]);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void getDeviceBatteryState_Click(object sender, EventArgs e)
        {
            int batteryPercentage = 0;
            int batteryState = 0;
            digiNoteTextBox.Text = "waiting...";
            int ret = getDeviceBatteryState(ref batteryPercentage, ref batteryState);
            digiNoteTextBox.Text = "ret: " + ret + " batteryPercentage: " + batteryPercentage + " batteryState: " + batteryState;
        }

        private void getDeviceFirmwareVersion_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] bleVersion = new byte[50];
            byte[] mcuVersion = new byte[50];
            int ret = getDeviceFirmwareVersion(ref bleVersion[0], ref mcuVersion[0]);
            string stbleVersion = System.Text.Encoding.Default.GetString(bleVersion).TrimEnd('\0');
            string stmcuVersion = System.Text.Encoding.Default.GetString(mcuVersion).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " bleVersion: " + stbleVersion + " mcuVersion: " + stmcuVersion;
        }

        private void hardwareReset_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = hardwareReset();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void factoryReset_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = factoryReset();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void openFileEncryptionWithKey_Click(object sender, EventArgs e)
        {
            byte[] key = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = openFileEncryptionWithKey(ref key[0]);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void closeFileEncryptionByKey_Click(object sender, EventArgs e)
        {
            byte[] key = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = closeFileEncryptionByKey(ref key[0]);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void verifyFileEncryptionByKey_Click(object sender, EventArgs e)
        {
            byte[] key = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = verifyFileEncryptionByKey(ref key[0]);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void queryFileEncryptionStatus_Click(object sender, EventArgs e)
        {
            int FileEncryptStatus = 0;
            digiNoteTextBox.Text = "waiting...";
            int ret = queryFileEncryptionStatus(ref FileEncryptStatus);
            digiNoteTextBox.Text = "ret: " + ret + " FileEncryptStatus: " + FileEncryptStatus;

        }

        private void getDeviceDataTimeWithSecond_Click(object sender, EventArgs e)
        {
            int deviceDataTime = 0;
            digiNoteTextBox.Text = "waiting...";
            int ret = getDeviceDataTimeWithSecond(ref deviceDataTime);
            digiNoteTextBox.Text = "ret: " + ret + " deviceDataTime: " + deviceDataTime;
        }

        private void setDeviceDateTimeWithSecond_Click(object sender, EventArgs e)
        {
            int deviceDataTime = 0;
            deviceDataTime =   Convert.ToInt32(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = setDeviceDateTimeWithSecond(deviceDataTime);
            digiNoteTextBox.Text = "ret: " + ret + " deviceDataTime: " + deviceDataTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int length = 0, widht = 0;
            int ret = getDeviceRatio(ref length, ref widht);
            digiNoteTextBox.Text = "ret: " + ret + " length: " + length + " widht: " + widht;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] cValue = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            int iValue = 0;
            for (int i = 0; i < cValue.Length; i++)
            {
                iValue = iValue * 10 + cValue[i] - '0';
            }
            int ret = setMonitorNum(ref iValue);
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int iBinaryCode = 0;
            int ret = scanBinaryCode(ref iBinaryCode);
            digiNoteTextBox.Text = "ret: " + ret + "BinaryCode: " + iBinaryCode;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = testOnLigh();
            digiNoteTextBox.Text = "ret: " + ret;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = testOffLigh();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = testOnA5BlueLigh();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = testOffA5Ligh();
            digiNoteTextBox.Text = "ret: " + ret;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = testOnA5WhiteLigh();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void digiNoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = searchDevice();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] macAddr = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = connectDeviceByMac(ref macAddr[0]);
            string stmacAddr = System.Text.Encoding.Default.GetString(macAddr).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] deviceSN = new byte[50];
            int ret = getDeviceSN(ref deviceSN[0]);
            string stdeviceSN = System.Text.Encoding.Default.GetString(deviceSN).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceSN: " + stdeviceSN;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] deviceSN = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = setDeviceSN(ref deviceSN[0]);
            string stdeviceSN = System.Text.Encoding.Default.GetString(deviceSN).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceSN: " + stdeviceSN;
        }
    }
}
