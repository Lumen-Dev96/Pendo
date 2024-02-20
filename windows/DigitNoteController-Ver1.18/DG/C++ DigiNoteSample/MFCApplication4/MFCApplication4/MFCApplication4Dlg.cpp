
// MFCApplication4Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "MFCApplication4.h"
#include "MFCApplication4Dlg.h"
#include "afxdialogex.h"
#include<stdio.h>
#include <string>
#include <cstring>

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

typedef int(WINAPI *PconnectDevice)();
typedef int(WINAPI *PdisconnectDevice)(char * deviceBleMac, char * deviceBleName);
typedef int(WINAPI *PswitchToRealTimeMode)();
typedef int(WINAPI *PswitchToUploadMode)();
typedef int(WINAPI *PqueryFileConut)(int & fileCount);
typedef int(WINAPI *PgetUploadFileInfo)(int & fileSize, int & fileDataTime);
typedef int(WINAPI *PstopTransfer)();
typedef int(WINAPI *PgetDeviceName)(char * deviceName);
typedef int(WINAPI *PgetDeviceSN)(char * deviceSN);
typedef int(WINAPI *PGetUploadFile)();
typedef int(WINAPI *PscanBinaryCode)(int & binaryCode);
typedef int(WINAPI *PtransferNewestFile)();
typedef int(WINAPI *PdeleteUploadFile)();
typedef int(WINAPI *PopenPort)();
typedef int(WINAPI *PgetDeviceBatteryState)(int & batteryPercentage, int & batteryState);
typedef void(WINAPI *PCallBackForRealTimePenDatas)(int x, int y, int pressure);
typedef void(WINAPI *PSetCallBackForRealTimePenDatas)(PCallBackForRealTimePenDatas CallBackfun);
typedef void(WINAPI *PCallBackForUploadFilePenData)(int x, int y, int pressure);
typedef void(WINAPI *PSetCallBackForUploadFilePenData)(PCallBackForUploadFilePenData CallBackfun);
typedef void(WINAPI *PCallBackForUploadFileStatus)(int speed, int percentage, int totalSize);
typedef void(WINAPI *PSetCallBackForUploadFileStatus)(PCallBackForUploadFileStatus CallBackfun);
typedef void(WINAPI *PCallBackForConnectDeviceSuccess)(char * deviceBleMac, char * deviceBleName);
typedef void(WINAPI *PSetCallBackForConnectDeviceSuccess)(PCallBackForConnectDeviceSuccess CallBackfun);

HINSTANCE hDll;

PconnectDevice connectDevice;
PSetCallBackForRealTimePenDatas SetCallBackForRealTimePenDatas;
PSetCallBackForUploadFilePenData SetCallBackForUploadFilePenData;
PswitchToRealTimeMode switchToRealTimeMode;
PswitchToUploadMode switchToUploadMode;
PqueryFileConut queryFileConut;
PgetUploadFileInfo getUploadFileInfo;
PstopTransfer stopTransfer;
PdisconnectDevice disconnectDevice;
PgetDeviceName getDeviceName;
PgetDeviceSN getDeviceSN;
PGetUploadFile GetUploadFile;
PscanBinaryCode scanBinaryCode;
PtransferNewestFile transferNewestFile;
PdeleteUploadFile deleteUploadFile;
PgetDeviceBatteryState getDeviceBatteryState;
PSetCallBackForUploadFileStatus SetCallBackForUploadFileStatus;
PSetCallBackForConnectDeviceSuccess SetCallBackForConnectDeviceSuccess;
PopenPort openPort;

CRect rect;
int width;
int height;
CWnd *pWin;
CWnd *pEditContralWin;
CDC *pDc;


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


// CMFCApplication4Dlg dialog


#pragma packed(1)
struct Point
{
	int x, y, pressure;
};
int prex = 0, prey = 0, prep = 0;
int ThreadFunc(LPVOID pParam)
{
	Point * pPoint = (Point *)pParam;
	int x, y, pressure;
	x = pPoint->x; y = pPoint->y; pressure = pPoint->pressure;
	x = x * width / 21000; y = y * height / 29800;

	
	if (pressure != 0 && prep != 0)
	{
		//pDc = pWin->GetDC();//获取该控件的画布
		//pDc->Rectangle(rect);

			pDc->MoveTo(prex, prey);
			POINT cur;
			cur.x = x;
			cur.y = y;
			pDc->LineTo(cur);
		
		//	ReleaseDC(pWin,pDc);
	}
	prex = x; prey = y; prep = pressure;
	delete pParam;
	return 0;
}

void WINAPI  ProgressCallBackForRealTimePenDatas(int x, int y, int pressure)
{

	CString str;
	str.Format(_T("x:%d y:%d pressure:%d"), x, y, pressure);
	pEditContralWin->SetWindowText(str);
	//SetDlgItemText(IDC_EDIT1, str);

	x = x * width / 21000; y = y * height / 29800;


	if (pressure != 0 && prep != 0)
	{


		pDc->MoveTo(prex, prey);
		POINT cur;
		cur.x = x;
		cur.y = y;
		pDc->LineTo(cur);
	}

	prex = x; prey = y; prep = pressure;

}
// CMFCApplication4Dlg message handlers


void WINAPI ProgressCallBackForUploadFilePenDatas(int x, int y, int pressure)
{
	CString str;
	str.Format(_T("x:%d y:%d pressure:%d"), x, y, pressure);
	pEditContralWin->SetWindowText(str);

	x = x * width / 21000; y = y * height / 29800;
	if (pressure != 0 && prep != 0)
	{
		pDc->MoveTo(prex, prey);
		POINT cur;
		cur.x = x;
		cur.y = y;
		pDc->LineTo(cur);
	}
	prex = x; prey = y; prep = pressure;
}

void WINAPI ProgressCallBackForUploadFileStatusCSharp(int speed, int percentage, int totalSize)
{
	CString str;
	str.Format(_T("speed:%d percentage:%d totalSize:%d"), speed, percentage, totalSize);
	pEditContralWin->SetWindowText(str);
}

void WINAPI ProgressCallBackForConnectDeviceSuccess(char * deviceBleMac, char * deviceBleName)
{
	char buf[1024] = { 0 };
	snprintf(buf, sizeof(buf), "deviceBleMac:%s deviceBleName : %s", deviceBleMac, deviceBleName);
	CString cstr(buf);
	pEditContralWin->SetWindowTextW(cstr);

}

CMFCApplication4Dlg::CMFCApplication4Dlg(CWnd* pParent /*=NULL*/)
	: CDialogEx(IDD_MFCAPPLICATION4_DIALOG, pParent)
{
	hDll = LoadLibrary(L"DigitNoteController.dll");
	SetCallBackForRealTimePenDatas = (PSetCallBackForRealTimePenDatas)GetProcAddress(hDll, "_SetCallBackForRealTimePenDatas@4");
	SetCallBackForRealTimePenDatas((PCallBackForRealTimePenDatas)ProgressCallBackForRealTimePenDatas);
	SetCallBackForUploadFilePenData = (PSetCallBackForUploadFilePenData)GetProcAddress(hDll, "_SetCallBackForUploadFilePenData@4");
	SetCallBackForUploadFilePenData((PCallBackForUploadFilePenData)ProgressCallBackForUploadFilePenDatas);
	SetCallBackForUploadFileStatus = (PSetCallBackForUploadFileStatus)GetProcAddress(hDll, "_SetCallBackForUploadFileStatus@4");
	SetCallBackForUploadFileStatus((PCallBackForUploadFileStatus)ProgressCallBackForUploadFileStatusCSharp);
	SetCallBackForConnectDeviceSuccess = (PSetCallBackForConnectDeviceSuccess)GetProcAddress(hDll, "_SetCallBackForConnectDeviceSuccess@4");
	SetCallBackForConnectDeviceSuccess((PCallBackForConnectDeviceSuccess)ProgressCallBackForConnectDeviceSuccess);
	

	connectDevice = (PconnectDevice)GetProcAddress(hDll, "_connectDevice@0");
	switchToUploadMode = (PswitchToUploadMode)GetProcAddress(hDll, "_switchToUploadMode@0");
	switchToRealTimeMode = (PswitchToRealTimeMode)GetProcAddress(hDll, "_switchToRealTimeMode@0");
	deleteUploadFile = (PdeleteUploadFile)GetProcAddress(hDll, "_deleteUploadFile@0");
	switchToUploadMode = (PswitchToUploadMode)GetProcAddress(hDll, "_switchToUploadMode@0");
	queryFileConut = (PqueryFileConut)GetProcAddress(hDll, "_queryFileConut@4");
	getUploadFileInfo = (PgetUploadFileInfo)GetProcAddress(hDll, "_getUploadFileInfo@8");
	stopTransfer = (PstopTransfer)GetProcAddress(hDll, "_stopTransfer@0");
	disconnectDevice = (PdisconnectDevice)GetProcAddress(hDll, "_disconnectDevice@8");
	getDeviceName = (PgetDeviceName)GetProcAddress(hDll, "_getDeviceName@4");
	getDeviceSN = (PgetDeviceSN)GetProcAddress(hDll, "_getDeviceSN@4");
	GetUploadFile = (PGetUploadFile)GetProcAddress(hDll, "_GetUploadFile@0");
	scanBinaryCode = (PscanBinaryCode)GetProcAddress(hDll, "_scanBinaryCode@4");
	transferNewestFile = (PtransferNewestFile)GetProcAddress(hDll, "_transferNewestFile@0");
	getDeviceBatteryState = (PgetDeviceBatteryState)GetProcAddress(hDll, "_getDeviceBatteryState@8");
	openPort = (PopenPort)GetProcAddress(hDll, "_openPort@0");
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMFCApplication4Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CMFCApplication4Dlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, &CMFCApplication4Dlg::OnBnClickedButton1)
	ON_BN_CLICKED(IDC_BUTTON2, &CMFCApplication4Dlg::OnBnClickedButton2)
	ON_BN_CLICKED(IDC_BUTTON3, &CMFCApplication4Dlg::OnBnClickedButton3)
	ON_BN_CLICKED(IDC_BUTTON4, &CMFCApplication4Dlg::OnBnClickedButton4)
	ON_EN_CHANGE(IDC_EDIT1, &CMFCApplication4Dlg::OnEnChangeEdit1)
	ON_BN_CLICKED(IDC_BUTTON7, &CMFCApplication4Dlg::OnBnClickedButton7)
	ON_BN_CLICKED(IDC_BUTTON5, &CMFCApplication4Dlg::OnBnClickedButton5)
	ON_BN_CLICKED(IDC_BUTTON11, &CMFCApplication4Dlg::OnBnClickedButton11)
	ON_BN_CLICKED(IDC_BUTTON9, &CMFCApplication4Dlg::OnBnClickedButton9)
	ON_BN_CLICKED(IDC_BUTTON14, &CMFCApplication4Dlg::OnBnClickedButton14)
	ON_BN_CLICKED(IDC_BUTTON8, &CMFCApplication4Dlg::OnBnClickedButton8)
	ON_BN_CLICKED(IDC_BUTTON10, &CMFCApplication4Dlg::OnBnClickedButton10)
	ON_BN_CLICKED(IDC_BUTTON6, &CMFCApplication4Dlg::OnBnClickedButton6)
	ON_BN_CLICKED(IDC_BUTTON13, &CMFCApplication4Dlg::OnBnClickedButton13)
	ON_BN_CLICKED(IDC_BUTTON12, &CMFCApplication4Dlg::OnBnClickedButton12)
	ON_BN_CLICKED(IDC_BUTTON15, &CMFCApplication4Dlg::OnBnClickedButton15)
END_MESSAGE_MAP()




BOOL CMFCApplication4Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here


	pWin = GetDlgItem(IDC_PIC);//获取该控件的指针，就可以对该控件直接操作了
	pWin->GetClientRect(rect);//把控件的长宽、坐标等信息保存在rect里
	width = rect.Width();//可以获取宽和高
	height = rect.Height();

	pDc = pWin->GetDC();//获取该控件的画布
	pDc->Rectangle(rect);

	pEditContralWin = GetDlgItem(IDC_EDIT1);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CMFCApplication4Dlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CMFCApplication4Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CMFCApplication4Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}



void CMFCApplication4Dlg::OnBnClickedButton1()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = connectDevice();
	str.Format(_T("ret: %d"), ret);
	SetDlgItemText(IDC_EDIT1, str);
}


void CMFCApplication4Dlg::OnBnClickedButton2()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = switchToRealTimeMode();
	str.Format(_T("ret: %d"), ret);
	SetDlgItemText(IDC_EDIT1, str);
}



void CMFCApplication4Dlg::OnBnClickedButton3()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	char deviceBleMac[1024] = { 0 };
	char deviceBleName[1024] = { 0 };

	int ret = disconnectDevice(deviceBleMac, deviceBleName);
	char buf[1024] = { 0 };
	snprintf(buf, sizeof(buf), "ret:%d deviceBleMac:%s deviceBleName:%s", ret, deviceBleMac, deviceBleName);
	CString cstr(buf);
	pEditContralWin->SetWindowTextW(cstr);

	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton4()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = switchToUploadMode();
	str.Format(_T("ret: %d"), ret);
	SetDlgItemText(IDC_EDIT1, str);


	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnEnChangeEdit1()
{
	// TODO:  如果该控件是 RICHEDIT 控件，它将不
	// 发送此通知，除非重写 CDialogEx::OnInitDialog()
	// 函数并调用 CRichEditCtrl().SetEventMask()，
	// 同时将 ENM_CHANGE 标志“或”运算到掩码中。

	// TODO:  在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton7()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int fileCount;
	int ret = queryFileConut(fileCount);
	str.Format(_T("ret: %d fileCount:%d"), ret, fileCount);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton5()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = transferNewestFile();
	str.Format(_T("ret: %d"), ret);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton11()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int fileSize, fileDataTime;
	int ret = getUploadFileInfo(fileSize, fileDataTime);
	str.Format(_T("ret: %d fileSize:%d fileDataTime:%d"), ret, fileSize, fileDataTime);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton9()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = GetUploadFile();
	str.Format(_T("ret: %d "), ret);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton14()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = deleteUploadFile();
	str.Format(_T("ret: %d "), ret);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton8()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int ret = stopTransfer();
	str.Format(_T("ret: %d "), ret);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton10()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int batteryPercentage, batteryState;
	int ret = getDeviceBatteryState(batteryPercentage, batteryState);
	str.Format(_T("ret: %d batteryPercentage:%d batteryState:%d"), ret, batteryPercentage, batteryState);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton6()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	char deviceSN[1024];
	int ret = getDeviceSN(deviceSN);
	str.Format(_T("ret: %d deviceSN:%s"), ret, deviceSN);
	SetDlgItemText(IDC_EDIT1, str);

	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton13()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);
	int binaryCode;
	int ret = scanBinaryCode(binaryCode);
	str.Format(_T("ret: %d binaryCode:%d"), ret, binaryCode);
	SetDlgItemText(IDC_EDIT1, str);

	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton12()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);

	char deviceName[1024] = { 0 };
	int ret = getDeviceName(deviceName);

	char buf[1024] = { 0 };
	snprintf(buf, sizeof(buf), "ret:%d deviceMac:%s", ret, deviceName);
	CString cstr(buf);
	pEditContralWin->SetWindowTextW(cstr);

	// TODO: 在此添加控件通知处理程序代码
}


void CMFCApplication4Dlg::OnBnClickedButton15()
{
	CString str;
	str.Format(_T("waitting..."));
	SetDlgItemText(IDC_EDIT1, str);

	int ret = openPort();
	str.Format(_T("ret: %d"), ret);
	SetDlgItemText(IDC_EDIT1, str);
	// TODO: 在此添加控件通知处理程序代码
}
