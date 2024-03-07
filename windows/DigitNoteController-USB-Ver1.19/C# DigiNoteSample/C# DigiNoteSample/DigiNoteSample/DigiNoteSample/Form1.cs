using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForConnectDeviceSuccess([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForConnectDeviceSuccess stProgressCallbackForConnectDeviceSuccess);
        
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForRealTimePenDatas(int x, int y, int pressure);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForRealTimePenDatas([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForRealTimePenDatas stProgressCallbackForRealTimePenDatas);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForEraseRealTimePenDatas(int x, int y, int pressure);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForEraseRealTimePenDatas([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForEraseRealTimePenDatas stProgressCallbackForEraseRealTimePenDatas);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForUploadFileStatus(int speed, int percentage, int totalSize);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForUploadFileStatus([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForUploadFileStatus stProgressCallbackForUploadFileStatus);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForUploadFilePenData(int x, int y, int pressure);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForEraseUploadFilePenData(int x, int y, int pressure);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForEraseUploadFilePenData([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForEraseUploadFilePenData stProgressCallbackForEraseUploadFilePenData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForBreakConnected();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForBreakConnected([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForBreakConnected stProgressCallbackForBreakConnected);


        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForPluginDevice();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForPluginDevice([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForPluginDevice stProgressCallbackForPluginDevice);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForPulloutDevice();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForPulloutDevice([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForPulloutDevice stProgressCallbackForPulloutDevice);


        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForUploadFilePenData([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForUploadFilePenData stProgressCallbackForUploadFilePenData);
        
        [DllImport("DigitNoteUSBController.dll")]
        public static extern int switchToRealTimeMode();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int switchToUploadMode();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int transferOldestFile();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int queryFileConut(ref int fileConut);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int transferNewestFile();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getUploadFileInfo(ref int fileSize, ref int fileDateTime);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int stopTransfer();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int GetUploadFile();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int deleteUploadFile();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int connectDevice();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int disconnectDevice();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceDataTimeWithSecond(ref int deviceDataTime);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceName(ref byte deviceName);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceFirmwareVersion(ref byte bleVersion, ref byte mcuVersion);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceBatteryState(ref int batteryPercentage, ref int batteryState);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int setDeviceDateTimeWithSecond(ref int dataTimeWithSeconde);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int setDeviceName(ref byte deviceName);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceMacAddr(ref byte deviceMacAddr);
        

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int hardwareReset();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int factoryReset();

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int openFileEncryptionWithKey(ref byte key);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int closeFileEncryptionByKey(ref byte key);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int verifyFileEncryptionByKey(ref byte key);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int queryFileEncryptionStatus(ref int FileEncryptStatus);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int scanBinaryCode(ref int iBinaryCode);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceRatio(ref int length, ref int widht);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceDataRange(ref int length, ref int widht, ref int pressureRange);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceBleInfo(ref byte deviceBleMac, ref byte deviceBleName);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int getDeviceSN(ref byte deviceSN);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int setDeviceSN(ref byte deviceSN);

        [DllImport("DigitNoteUSBController.dll")]
        public static extern int GetUploadFileBinaryCode(ref int iBinaryCode);


        [DllImport("DigitNoteUSBController.dll")]
        public static extern void SetCallBackForButton([MarshalAs(UnmanagedType.FunctionPtr)]  ProgressCallbackForButton stProgressCallbackForButton);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void ProgressCallbackForButton(int buttonValue);

        public void ProgressCallbackForConnectDeviceSuccesskCSharp(string deviceBleMac, string deviceBleName)
        {
            //string stdeviceBleMac = System.Text.Encoding.Default.GetString(deviceBleMac);
            //string stdeviceBleName = System.Text.Encoding.Default.GetString(deviceBleName);
            deviceBleMac = deviceBleMac.TrimEnd('\0');
            deviceBleName = deviceBleName.TrimEnd('\0');
            digiNoteTextBox.Text = "deviceBleMac: " + deviceBleMac + " deviceBleName: " + deviceBleName;
        }


        public void ProgressCallbackForBreakConnectedCSharp()
        {

            digiNoteTextBox.Text = "BreakConnected";
        }

        static void ThreadconnectDevice()
        {
            int ret = connectDevice();
            digiNoteTextBox.Text = "connectDevice ret: " + ret;
        }

        public void ProgressCallbackForPluginDeviceCSharp()
        {
            digiNoteTextBox.Text = "PluginDevice";
          //  Thread t = new Thread(ThreadconnectDevice);
         //   t.Start();
        }

        public void ProgressCallbackForPulloutDeviceCSharp()
        {
            digiNoteTextBox.Text = "PulloutDevice";
        }

        static FileStream fs = new FileStream("./a.txt", FileMode.Create);
        static StreamWriter sw = new StreamWriter(fs);
        public static int GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return (int)ts.TotalSeconds;
        }
        static int time = 0, tmpsum = 0, sum = 0;
        static int drawPreX = 0, drawPreY = 0, drawPreP = 0, drawCurrX = 0, drawCurrY = 0, drawCurrP = 0;

        public void ProgressCallbackForRealTimePenDatasCSharp(int x, int y, int pressure)
        {
            if (GetTimeStamp() == time)
            {
                ++tmpsum;
            }
            else
            {
                time = GetTimeStamp();
                sum = tmpsum;
                tmpsum = 0;
            }
            sw.WriteLine(x + " " + y + " " + pressure);
            digiNoteTextBox.Text = "x: " + x + "y: " + y + "pressure: " + pressure + " sum: " + sum;

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

        public void ProgressCallbackForEraseRealTimePenDatasCSharp(int x, int y, int pressure)
        {
            digiNoteTextBox.Text = "Erase x: " + x + "y: " + y + "pressure: " + pressure;
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

        public void ProgressCallbackForEraseUploadFilePenDataCSharp(int x, int y, int pressure)
        {
            digiNoteTextBox.Text = "Erase  x: " + x + "y: " + y + "pressure: " + pressure;
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

        static int tot = 0;
        public void ProgressCallbackForUploadFilePenDataCSharp(int x, int y, int pressure)
        {
            ++tot;
            sw.WriteLine(x + " " + y + " " + pressure);
            digiNoteTextBox.Text = "x: " + x + "y: " + y + "pressure: " + pressure + "tot: " + tot;
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

        public void ProgressCallbackForButtonCSharp(int buttonValue)
        {
            digiNoteTextBox.Text = "buttonValue: " + buttonValue;
        }

        static ProgressCallbackForConnectDeviceSuccess stProgressCallbackForConnectDeviceSuccess;
        static ProgressCallbackForRealTimePenDatas stProgressCallbackForRealTimePenDatas;
        static ProgressCallbackForUploadFileStatus stProgressCallbackForUploadFileStatus;
        static ProgressCallbackForUploadFilePenData stProgressCallbackForUploadFilePenData;
        static ProgressCallbackForBreakConnected stProgressCallbackForBreakConnected;
        static ProgressCallbackForPluginDevice stProgressCallbackForPluginDevice;
        static ProgressCallbackForPulloutDevice stProgressCallbackForPulloutDevice;
        static ProgressCallbackForButton stProgressCallbackForButton;
        static ProgressCallbackForEraseUploadFilePenData stProgressCallbackForEraseUploadFilePenData;
        static ProgressCallbackForEraseRealTimePenDatas stProgressCallbackForEraseRealTimePenDatas;

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

            stProgressCallbackForBreakConnected = new ProgressCallbackForBreakConnected(ProgressCallbackForBreakConnectedCSharp);
            SetCallBackForBreakConnected(stProgressCallbackForBreakConnected);

            stProgressCallbackForPluginDevice = new ProgressCallbackForPluginDevice(ProgressCallbackForPluginDeviceCSharp);
            SetCallBackForPluginDevice(stProgressCallbackForPluginDevice);

            stProgressCallbackForPulloutDevice = new ProgressCallbackForPulloutDevice(ProgressCallbackForPulloutDeviceCSharp);
            SetCallBackForPulloutDevice(stProgressCallbackForPulloutDevice);

            stProgressCallbackForButton = new ProgressCallbackForButton(ProgressCallbackForButtonCSharp);
            SetCallBackForButton(stProgressCallbackForButton);

            stProgressCallbackForEraseRealTimePenDatas = new ProgressCallbackForEraseRealTimePenDatas(ProgressCallbackForEraseRealTimePenDatasCSharp);
            SetCallBackForEraseRealTimePenDatas(stProgressCallbackForEraseRealTimePenDatas);

            stProgressCallbackForEraseUploadFilePenData = new ProgressCallbackForEraseUploadFilePenData(ProgressCallbackForEraseUploadFilePenDataCSharp);
            SetCallBackForEraseUploadFilePenData(stProgressCallbackForEraseUploadFilePenData);
        }
        
        private void openPort_Click(object sender, EventArgs e)
        {
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
        }

        private void getDGVersion_Click(object sender, EventArgs e)
        {
        }

        private void setDGBleName_Click(object sender, EventArgs e)
        {
        }

        private void disconnectDevice_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int ret = disconnectDevice();
            digiNoteTextBox.Text = "ret: " + ret;
        }

        private void getDeviceBleInfo_Click(object sender, EventArgs e)
        {   
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

        private void button1_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int iBinaryCode = 0;
            int ret = scanBinaryCode(ref iBinaryCode);
            digiNoteTextBox.Text = "ret: " + ret + "BinaryCode: " + iBinaryCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int length = 0, widht = 0;
            int ret = getDeviceRatio(ref length, ref widht);
            digiNoteTextBox.Text = "ret: " + ret + " length: " + length + " widht: " + widht;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int length = 0, widht = 0, pressure = 0;
            int ret = getDeviceDataRange(ref length, ref widht, ref pressure);
            digiNoteTextBox.Text = "ret: " + ret + " length: " + length + " widht: " + widht + " pressure: " + pressure;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            byte[] deviceBleMac = new byte[50];
            byte[] deviceBleName = new byte[50];
            int ret = getDeviceBleInfo(ref deviceBleMac[0], ref deviceBleName[0]);
            string stdeviceBleMac = System.Text.Encoding.Default.GetString(deviceBleMac).TrimEnd('\0');
            string stdeviceBleName = System.Text.Encoding.Default.GetString(deviceBleName).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceBleMac: " + stdeviceBleMac + " deviceBleName: " + stdeviceBleName;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] deviceSN = new byte[50];
            int ret = getDeviceSN(ref deviceSN[0]);
            string stdeviceSN = System.Text.Encoding.Default.GetString(deviceSN).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceSN: " + stdeviceSN;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] deviceSN = Encoding.Default.GetBytes(digiNoteTextBox.Text);
            digiNoteTextBox.Text = "waiting...";
            int ret = setDeviceSN(ref deviceSN[0]);
            string stdeviceSN = System.Text.Encoding.Default.GetString(deviceSN).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceSN: " + stdeviceSN;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] deviceMacAddr = new byte[50];

            int ret = getDeviceMacAddr(ref deviceMacAddr[0]);
            string stDeviceMacAddr = System.Text.Encoding.Default.GetString(deviceMacAddr).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceMacAddr: " + stDeviceMacAddr;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            int iBinaryCode = 0;
            int ret = GetUploadFileBinaryCode(ref iBinaryCode);
            digiNoteTextBox.Text = "ret: " + ret + "BinaryCode: " + iBinaryCode;
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
            int ret = setDeviceDateTimeWithSecond(ref deviceDataTime);
            digiNoteTextBox.Text = "ret: " + ret + " deviceDataTime: " + deviceDataTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void digiNoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void getDeviceSN_Click(object sender, EventArgs e)
        {
            digiNoteTextBox.Text = "waiting...";
            byte[] deviceSN = new byte[50];
            int ret = getDeviceSN(ref deviceSN[0]);
            string stdeviceSN = System.Text.Encoding.Default.GetString(deviceSN).TrimEnd('\0');
            digiNoteTextBox.Text = "ret: " + ret + " deviceSN: " + stdeviceSN;
        }
    }
}
