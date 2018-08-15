using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace HKDriver.API
{
    internal class HCNetSDKia64
    {
        #region 宏定义
        /// <summary>
        /// DVR本地登陆名
        /// </summary>
        public const int MAX_NAMELEN = 16;
        /// <summary>
        /// 设备支持的权限（1-12表示本地权限，13-32表示远程权限）
        /// </summary>
        public const int MAX_RIGHT = 32;
        /// <summary>
        /// 用户名长度
        /// </summary>
        public const int NAME_LEN = 32;
        /// <summary>
        /// /密码长度
        /// </summary>
        public const int PASSWD_LEN = 16;
        /// <summary>
        /// 序列号长度
        /// </summary>
        public const int SERIALNO_LEN = 48;
        /// <summary>
        /// mac地址长度
        /// </summary>
        public const int MACADDR_LEN = 6;
        /// <summary>
        /// 设备可配以太网络
        /// </summary>
        public const int MAX_ETHERNET = 2;
        /// <summary>
        /// 路径长度
        /// </summary>
        public const int PATHNAME_LEN = 128;

        /// <summary>
        /// 9000设备最大时间段数
        /// </summary>
        public const int MAX_TIMESEGMENT_V30 = 8;
        /// <summary>
        /// 8000设备最大时间段数
        /// </summary>
        public const int MAX_TIMESEGMENT = 4;

        /// <summary>
        /// 8000设备最大遮挡区域数
        /// </summary>
        public const int MAX_SHELTERNUM = 4;
        /// <summary>
        /// 每周天数
        /// </summary>
        public const int MAX_DAYS = 7;
        /// <summary>
        /// pppoe拨号号码最大长度
        /// </summary>
        public const int PHONENUMBER_LEN = 32;

        /// <summary>
        /// 9000设备最大硬盘数/* 最多33个硬盘(包括16个内置SATA硬盘、1个eSATA硬盘和16个NFS盘) */
        /// </summary>
        public const int MAX_DISKNUM_V30 = 33;
        /// <summary>
        /// 8000设备最大硬盘数
        /// </summary>
        public const int MAX_DISKNUM = 16;
        /// <summary>
        /// 1.2版本之前版本
        /// </summary>
        public const int MAX_DISKNUM_V10 = 8;

        /// <summary>
        /// 9000设备本地显示最大播放窗口数
        /// </summary>
        public const int MAX_WINDOW_V30 = 32;
        /// <summary>
        /// 8000设备最大硬盘数
        /// </summary>
        public const int MAX_WINDOW = 16;
        /// <summary>
        /// 9000设备最大可接VGA数
        /// </summary>
        public const int MAX_VGA_V30 = 4;
        /// <summary>
        /// 8000设备最大可接VGA数
        /// </summary>
        public const int MAX_VGA = 1;

        /// <summary>
        /// 9000设备最大用户数
        /// </summary>
        public const int MAX_USERNUM_V30 = 32;
        /// <summary>
        /// 8000设备最大用户数
        /// </summary>
        public const int MAX_USERNUM = 16;
        /// <summary>
        /// 9000设备最大异常处理数
        /// </summary>
        public const int MAX_EXCEPTIONNUM_V30 = 32;
        /// <summary>
        /// 8000设备最大异常处理数
        /// </summary>
        public const int MAX_EXCEPTIONNUM = 16;
        /// <summary>
        /// 8000设备单通道最大视频流连接数
        /// </summary>
        public const int MAX_LINK = 6;

        /// <summary>
        /// 单路解码器每个解码通道最大可循环解码数
        /// </summary>
        public const int MAX_DECPOOLNUM = 4;
        /// <summary>
        /// 单路解码器的最大解码通道数（实际只有一个，其他三个保留）
        /// </summary>
        public const int MAX_DECNUM = 4;
        /// <summary>
        /// 单路解码器可配置最大透明通道数
        /// </summary>
        public const int MAX_TRANSPARENTNUM = 2;
        /// <summary>
        /// 单路解码器最大轮循通道数
        /// </summary>
        public const int MAX_CYCLE_CHAN = 16;
        /// <summary>
        /// 最大目录长度
        /// </summary>
        public const int MAX_DIRNAME_LENGTH = 80;
        /// <summary>
        /// 9000设备最大OSD字符行数数
        /// </summary>
        public const int MAX_STRINGNUM_V30 = 8;
        /// <summary>
        /// 8000设备最大OSD字符行数数
        /// </summary>
        public const int MAX_STRINGNUM = 4;
        /// <summary>
        /// 8000定制扩展
        /// </summary>
        public const int MAX_STRINGNUM_EX = 8;
        /// <summary>
        /// 9000设备最大辅助输出数
        /// </summary>
        public const int MAX_AUXOUT_V30 = 16;
        /// <summary>
        /// 8000设备最大辅助输出数
        /// </summary>
        public const int MAX_AUXOUT = 4;
        /// <summary>
        /// 9000设备最大硬盘组数
        /// </summary>
        public const int MAX_HD_GROUP = 16;
        /// <summary>
        /// 8000设备最大NFS硬盘数
        /// </summary>
        public const int MAX_NFS_DISK = 8;

        /// <summary>
        /// WIFI的SSID号长度
        /// </summary>
        public const int IW_ESSID_MAX_SIZE = 32;
        /// <summary>
        /// WIFI密锁最大字节数
        /// </summary>
        public const int IW_ENCODING_TOKEN_MAX = 32;
        /// <summary>
        /// 最多支持的透明通道路数
        /// </summary>
        public const int MAX_SERIAL_NUM = 64;
        /// <summary>
        /// 9000设备最大可配ddns数
        /// </summary>
        public const int MAX_DDNS_NUMS = 10;
        /// <summary>
        /// /* 最大域名长度 */
        /// </summary>
        public const int MAX_DOMAIN_NAME = 64;
        /// <summary>
        /// 最大email地址长度
        /// </summary>
        public const int MAX_EMAIL_ADDR_LEN = 48;
        /// <summary>
        /// 最大email密码长度
        /// </summary>
        public const int MAX_EMAIL_PWD_LEN = 32;

        /// <summary>
        /// 回放时的最大百分率
        /// </summary>
        public const int MAXPROGRESS = 100;
        /// <summary>
        /// 8000设备支持的串口数 1-232， 2-485
        /// </summary>
        public const int MAX_SERIALNUM = 2;
        /// <summary>
        /// 卡号长度
        /// </summary>
        public const int CARDNUM_LEN = 20;
        /// <summary>
        /// 9000设备的视频输出数
        /// </summary>
        public const int MAX_VIDEOOUT_V30 = 4;
        /// <summary>
        /// 8000设备的视频输出数
        /// </summary>
        public const int MAX_VIDEOOUT = 2;
        #region 对外结构
        /// <summary>
        /// 9000设备支持的云台预置点数
        /// </summary>
        public const int MAX_PRESET_V30 = 256;
        /// <summary>
        /// 9000设备支持的云台轨迹数
        /// </summary>
        public const int MAX_TRACK_V30 = 256;
        /// <summary>
        /// 9000设备支持的云台巡航数
        /// </summary>
        public const int MAX_CRUISE_V30 = 256;
        /// <summary>
        /// 8000设备支持的云台预置点数
        /// </summary>
        public const int MAX_PRESET = 128;
        /// <summary>
        /// 8000设备支持的云台轨迹数
        /// </summary>
        public const int MAX_TRACK = 128;
        /// <summary>
        /// 8000设备支持的云台巡航数
        /// </summary>
        public const int MAX_CRUISE = 128;

        /// <summary>
        /// 一条巡航最多的巡航点
        /// </summary>
        public const int CRUISE_MAX_PRESET_NUMS = 32;

        /// <summary>
        /// 9000设备支持232串口数
        /// </summary>
        public const int MAX_SERIAL_PORT = 8;
        /// <summary>
        /// 设备支持最大预览模式数目 1画面,4画面,9画面,16画面....
        /// </summary>
        public const int MAX_PREVIEW_MODE = 8;
        /// <summary>
        /// 最大模拟矩阵输出个数
        /// </summary>
        public const int MAX_MATRIXOUT = 16;
        /// <summary>
        /// 日志附加信息
        /// </summary>
        public const int LOG_INFO_LEN = 11840;
        /// <summary>
        /// 云台描述字符串长度
        /// </summary>
        public const int DESC_LEN = 16;
        /// <summary>
        /// 9000最大支持的云台协议数
        /// </summary>
        public const int PTZ_PROTOCOL_NUM = 200;

        /// <summary>
        /// 8000语音对讲通道数
        /// </summary>
        public const int MAX_AUDIO = 1;
        /// <summary>
        /// 9000语音对讲通道数
        /// </summary>
        public const int MAX_AUDIO_V30 = 2;
        /// <summary>
        /// 8000设备最大通道数
        /// </summary>
        public const int MAX_CHANNUM = 16;
        /// <summary>
        /// 8000设备最大报警输入数
        /// </summary>
        public const int MAX_ALARMIN = 16;
        /// <summary>
        /// 8000设备最大报警输出数
        /// </summary>
        public const int MAX_ALARMOUT = 4;
        #endregion
        #region 9000 IPC接入
        /// <summary>
        /// 最大32个模拟通道
        /// </summary>
        public const int MAX_ANALOG_CHANNUM = 32;
        /// <summary>
        /// 最大32路模拟报警输出 
        /// </summary>
        public const int MAX_ANALOG_ALARMOUT = 32;
        /// <summary>
        /// 最大32路模拟报警输入
        /// </summary>
        public const int MAX_ANALOG_ALARMIN = 32;
        /// <summary>
        /// 允许接入的最大IP设备数
        /// </summary>
        public const int MAX_IP_DEVICE = 32;
        /// <summary>
        /// 允许加入的最多IP通道数
        /// </summary>
        public const int MAX_IP_CHANNEL = 32;
        /// <summary>
        /// 允许加入的最多报警输入数
        /// </summary>
        public const int MAX_IP_ALARMIN = 128;
        /// <summary>
        /// 允许加入的最多报警输出数
        /// </summary>
        public const int MAX_IP_ALARMOUT = 64;

        /* 最大支持的通道数 最大模拟加上最大IP支持 */
        public const int MAX_CHANNUM_V30 = (MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL);//64
        public const int MAX_ALARMOUT_V30 = (MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT);//96
        public const int MAX_ALARMIN_V30 = (MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN);//160
        #endregion


        #endregion
        #region 1.     初始化
        #region 1.1   初始化
        /// <summary>
        /// 1.1.1      初始化SDK
        /// </summary>
        /// <returns>TRUE表示成功，FALSE表示失败</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();
        /// <summary>
        /// 1.1.2     释放SDK资源
        /// </summary>
        /// <returns>TRUE表示成功，FALSE表示失败</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();
        #region 1.1.3 NET_DVR_IsSupport
        /*************************************************
        NET_DVR_IsSupport()返回值
        1－9位分别表示以下信息（位与是TRUE)表示支持；
        **************************************************/
        /// <summary>
        /// 支持DIRECTDRAW，如果不支持，则播放器不能工作；
        /// </summary>
        public const int NET_DVR_SUPPORT_DDRAW = 0x01;//
        /// <summary>
        /// 显卡支持BLT操作，如果不支持，则播放器不能工作；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLT = 0x02;//
        /// <summary>
        /// 显卡BLT支持颜色转换，如果不支持，播放器会用软件方法作RGB转换；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLTFOURCC = 0x04;//
        /// <summary>
        /// 显卡BLT支持X轴缩小；如果不支持，系统会用软件方法转换；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 0x08;//
        /// <summary>
        /// 显卡BLT支持Y轴缩小；如果不支持，系统会用软件方法转换；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 0x10;//
        /// <summary>
        /// 显卡BLT支持X轴放大；如果不支持，系统会用软件方法转换；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 0x20;//
        /// <summary>
        /// 显卡BLT支持Y轴放大；如果不支持，系统会用软件方法转换；
        /// </summary>
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 0x40;//
        /// <summary>
        /// CPU支持SSE指令，Intel Pentium3以上支持SSE指令；
        /// </summary>
        public const int NET_DVR_SUPPORT_SSE = 0x80;//
        /// <summary>
        /// CPU支持MMX指令集，Intel Pentium3以上支持SSE指令；
        /// </summary>
        public const int NET_DVR_SUPPORT_MMX = 0x100;//
        /// <summary>
        /// 1.1.3    判断运行客户端的PC配置是否符合要求(保留不使用)
        ///     NET_DVR_API int __stdcall NET_DVR_IsSupport();
        /// </summary>
        /// <returns>
        /// 1～9位分别表示以下信息（位与是TRUE，表示支持）
        /// #define  NET_DVR_SUPPORT_DDRAW          0x01    支持DIRECTDRAW，如果不支持，则播放器不能工作
        /// #define  NET_DVR_SUPPORT_BLT            0x02    显卡支持BLT操作，如果不支持，则播放器不能工作
        /// #define  NET_DVR_SUPPORT_BLTFOURCC      0x04    显卡BLT支持颜色转换，如果不支持，播放器会用软件方法作RGB转换
        /// #define  NET_DVR_SUPPORT_BLTSHRINKX     0x08    显卡BLT支持X轴缩小；如果不支持，系统会用软件方法转换
        /// #define  NET_DVR_SUPPORT_BLTSHRINKY     0x10    显卡BLT支持Y轴缩小；如果不支持，系统会用软件方法转换
        /// #define  NET_DVR_SUPPORT_BLTSTRETCHX    0x20    显卡BLT支持X轴放大；如果不支持，系统会用软件方法转换
        /// #define  NET_DVR_SUPPORT_BLTSTRETCHY    0x40    显卡BLT支持Y轴放大；如果不支持，系统会用软件方法转换
        /// #define  NET_DVR_SUPPORT_SSE            0x80    CPU支持SSE指令，Intel Pentium3以上支持SSE指令
        /// #define  NET_DVR_SUPPORT_MMX            0x100   CPU支持MMX指令集，Intel Pentium3以上支持SSE指令
        /// </returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_IsSupport();
        #endregion
        /// <summary>
        /// 1.1.4   设置连接超时时间和连接尝试次数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetConnectTime(DWORD dwWaitTime = 5000, DWORD dwTryTimes = 3);
        /// </summary>
        /// <param name="dwWaitTime">[in]超时时间，单位：毫秒 ，取值范围（大于300，小于60*1000）</param>
        /// <param name="dwTryTimes">[in]连接尝试次数（暂时保留）</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);
        /// <summary>
        /// 1.1.5   通过IPServer获取设备动态IP地址
        ///     注意
        ///         设备名称和设备序列号不能同时为空。
        ///         IPServer是海康威视提供的一款域名解析服务器软件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDVRIPByResolveSvr(char *sServerIP, WORD wServerPort, BYTE *sDVRName,WORD wDVRNameLen,BYTE *sDVRSerialNumber,WORD wDVRSerialLen,char* sGetIP);
        /// </summary>
        /// <param name="sServerIP">[in]解析服务器的IP地址</param>
        /// <param name="wServerPort">[in]解析服务器的端口号，我们提供的解析服务器（IPServer）端口号为7071</param>
        /// <param name="sDVRName">[in]设备名称，可以为NULL</param>
        /// <param name="wDVRNameLen">[in]设备名称的长度</param>
        /// <param name="sDVRSerialNumber">[in]设备的序列号，可以为NULL</param>
        /// <param name="wDVRSerialLen">[in]设备序列号的长度</param>
        /// <param name="sGetIP">[out]保存获取到的IP地址的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, StringBuilder sGetIP);
        #endregion
        #region 1.2   异常消息回调
        #region 1.2.1   异常类型宏定义
        /// <summary>
        /// 用户交互时异常
        /// </summary>
        public const int EXCEPTION_EXCHANGE = 0x8000;
        /// <summary>
        /// 语音对讲异常
        /// </summary>
        public const int EXCEPTION_AUDIOEXCHANGE = 0x8001;
        /// <summary>
        /// 报警异常
        /// </summary>
        public const int EXCEPTION_ALARM = 0x8002;
        /// <summary>
        /// 网络预览异常
        /// </summary>
        public const int EXCEPTION_PREVIEW = 0x8003;
        /// <summary>
        /// 透明通道异常
        /// </summary>
        public const int EXCEPTION_SERIAL = 0x8004;
        /// <summary>
        /// 预览时重连
        /// </summary>
        public const int EXCEPTION_RECONNECT = 0x8005;
        /// <summary>
        /// 报警时重连
        /// </summary>
        public const int EXCEPTION_ALARMRECONNECT = 0x8006;
        /// <summary>
        /// 透明通道重连
        /// </summary>
        public const int EXCEPTION_SERIALRECONNECT = 0x8007;
        /// <summary>
        /// 回放异常
        /// </summary>
        public const int EXCEPTION_PLAYBACK = 0x8010;
        /// <summary>
        /// 硬盘格式化
        /// </summary>
        public const int EXCEPTION_DISKFMT = 0x8011;
        #endregion
        /// <summary>
        /// 接收消息回调函数
        ///     void (CALLBACK* fExceptionCallBack)(uint dwType, int lUserID, int lHandle, void *pUser)
        /// </summary>
        /// <param name="dwType">异常或重连等消息的类型</param>
        /// <param name="lUserID">登陆ID</param>
        /// <param name="lHandle">出现异常的相应类型的句柄</param>
        /// <param name="pUser">输入的用户数据</param>
        public delegate void ExceptionCallBack(uint dwType, int lUserID, int lHandle, int pUser);
        /// <summary>
        /// 1.2.2   注册接收异常、重连等消息的窗口句柄或回调函数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetExceptionCallBack_V30(UINT nMessage, HWND hWnd, void (CALLBACK* fExceptionCallBack)(DWORD dwType, LONG lUserID, LONG lHandle, void *pUser), void *pUser);
        /// </summary>
        /// <param name="nMessage">[in]窗口消息值，如WM_USER + 1</param>
        /// <param name="hWnd">[in]接收消息的窗口句柄</param>
        /// <param name="fExceptionCallBack">[in]接收消息回调函数</param>
        /// <param name="pUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, ExceptionCallBack fExceptionCallBack, IntPtr pUser);
        /// <summary>
        /// 1.2.3   设置设备异常消息接收的窗口句柄
        ///    NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessage(UINT nMessage,HWND hWnd);
        /// </summary>
        /// <param name="nMessage">[in]消息</param>
        /// <param name="hWnd">[in]接收异常信息消息的窗口句柄</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

        #endregion
        #endregion
        #region 2.     用户注册
        #region 2.1    用户注册
        #region 2.1.1       注册用户
        /// <summary>
        /// 2.1.1   注册用户(用户登录)
        ///     NET_DVR_API LONG __stdcall NET_DVR_Login_V30(char *sDVRIP, WORD wDVRPort, char *sUserName, char *sPassword, LPNET_DVR_DEVICEINFO_V30 lpDeviceInfo);
        /// </summary>
        /// <param name="sDVRIP">[in]设备的IP地址</param>
        /// <param name="wDVRPort">[in]设备的端口号</param>
        /// <param name="sUserName">[in]登录的用户名</param>
        /// <param name="sPassword">[in]用户密码</param>
        /// <param name="lpDeviceInfo">[out]指向NET_DVR_DEVICEINFO_V30结构</param>
        /// <returns>获得的用户ID号</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_Login_V30(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, out NET_DVR_DEVICEINFO_V30 lpDeviceInfo);
        /// <summary>
        /// 注册用户(用户登录)
        ///     NET_DVR_API LONG __stdcall NET_DVR_Login(char *sDVRIP,WORD wDVRPort,char *sUserName,char *sPassword,LPNET_DVR_DEVICEINFO lpDeviceInfo);
        /// </summary>
        /// <param name="sDVRIP">[in]设备的IP地址</param>
        /// <param name="wDVRPort">[in]设备的端口号</param>
        /// <param name="sUserName">[in]登录的用户名</param>
        /// <param name="sPassword">[in]用户密码</param>
        /// <param name="lpDeviceInfo">[out]指向NET_DVR_DEVICEINFO结构</param>
        /// <returns>-1表示失败，其他值表示返回的用户ID值，该ID值是由SDK分配，每个用户ID值在客户端是唯一的</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, out NET_DVR_DEVICEINFO lpDeviceInfo);
        #endregion
        #region 2.1.2       注销用户
        /// <summary>
        /// 2.1.2   注销用户
        ///     说明
        ///         强制停止该用户的所有操作和释放所有的资源，确保该ID对应的线程都安全退出，资源得到释放。
        ///     注意
        ///         NET_DVR_Logout_V30会等待或者强制将该用户的所有资源释放或者退出（如线程等），
        ///         而 NET_DVR_Logout则不会，仅仅将当前的用户从设备上注销了。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_Logout_V30(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30(int lUserID);
        /// <summary>
        /// 注销用户
        ///     NET_DVR_API BOOL __stdcall NET_DVR_Logout(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]用户ID值，由NET_DVR_Login或者NET_DVR_Login_V30返回的ID值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout(int lUserID);
        #endregion
        #endregion
        #endregion
        #region 3.     SDK信息
        #region 3.1         SDK信息
        /// <summary>
        /// 3.1.1   获取SDK版本号
        ///     NET_DVR_API DWORD __stdcall NET_DVR_GetSDKVersion();
        /// </summary>
        /// <returns>2个高字节表示主版本，2个低字节表示次版本，比如0x00020001代表版本2.1</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();
        /// <summary>
        /// 3.1.2   获取SDK build号
        ///     NET_DVR_API DWORD __stdcall NET_DVR_GetSDKBuildVersion();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKBuildVersion();
        /// <summary>
        /// 3.1.3   获取当前SDK的状态
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetSDKState(LPNET_DVR_SDKSTATE pSDKState);
        /// </summary>
        /// <param name="pSDKState">[out]指向NET_DVR_SDKSTATE状态结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKState(out NET_DVR_SDKSTATE pSDKState);
        /// <summary>
        /// 3.1.4   获取SDK的功能信息
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetSDKAbility(LPNET_DVR_SDKABL pSDKAbl);
        /// </summary>
        /// <param name="pSDKAbl">[out]指向NET_DVR_SDKABL功能结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKAbility(out NET_DVR_SDKABL pSDKAbl);
        /// <summary>
        /// 3.1.5   SDK日志设置，启用写入日志文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetLogToFile(BOOL bLogEnable = FALSE, char * strLogDir = NULL, BOOL bAutoDel = TRUE);
        ///     说明
        ///         设置日志打印目录， 该目录最好在设置前由用户自己手动建立。
        ///         目录字符串必须是绝对路径，且以"\\"结尾, 例如"C:\\SdkLog\\"
        ///         更改目录时到下一次写文件时才会使用新的目录写文件。
        ///         如果参数strLogDir为NULL，则采用默认路径"C:\\SdkLog\\"
        ///         该接口可以重复调用以设置新的日志目录，不调用则不启动日志打印功能。重新设置新的日志目录之后，要等当前日志文件写完，才会进入新目录写日志
        ///         设定每个SDK实例最多打开10个日志文件，如果bAutoDel为TRUE时，将自动删除超出的文件
        /// </summary>
        /// <param name="bLogEnable">[in]是否使能</param>
        /// <param name="strLogDir">[in]目录路径字符串</param>
        /// <param name="bAutoDel">[in]是否删除超出的文件数</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLogToFile(bool bLogEnable, string strLogDir, bool bAutoDel);
        #endregion
        #endregion
        #region 4.     错误信息获取
        #region 4.1    错误信息获取
        /// <summary>
        /// 4.1.1   获取错误代码
        ///     返回值参照[4.2.1   网络通讯库错误码]
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();
        /// <summary>
        /// 4.1.2   获取错误码信息
        ///     NET_DVR_API char* __stdcall NET_DVR_GetErrorMsg(LONG *pErrorNo = NULL);
        /// </summary>
        /// <param name="pErrorNo">[out]错误码数值的指针，空指针则返回当前错误码描述信息</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern string NET_DVR_GetErrorMsg(out int pErrorNo);
        #endregion
        #region 4.2    错误代码
        #region 4.2.1   网络通讯库错误码
        public const int NET_DVR_FAIL = -1;
        /// <summary>
        /// 没有错误
        /// </summary>
        public const int NET_DVR_NOERROR = 0;
        /// <summary>
        /// 用户名密码错误
        /// </summary>
        public const int NET_DVR_PASSWORD_ERROR = 1;
        /// <summary>
        /// 权限不足
        /// </summary>
        public const int NET_DVR_NOENOUGHPRI = 2;
        /// <summary>
        /// 没有初始化
        /// </summary>
        public const int NET_DVR_NOINIT = 3;
        /// <summary>
        /// 通道号错误
        /// </summary>
        public const int NET_DVR_CHANNEL_ERROR = 4;
        /// <summary>
        /// 连接到DVR的客户端个数超过最大
        /// </summary>
        public const int NET_DVR_OVER_MAXLINK = 5;
        /// <summary>
        /// 版本不匹配
        /// </summary>
        public const int NET_DVR_VERSIONNOMATCH = 6;
        /// <summary>
        /// 连接服务器失败
        /// </summary>
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;
        /// <summary>
        /// 向服务器发送失败
        /// </summary>
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;
        /// <summary>
        /// 从服务器接收数据失败
        /// </summary>
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;
        /// <summary>
        /// 从服务器接收数据超时
        /// </summary>
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;
        /// <summary>
        /// 传送的数据有误
        /// </summary>
        public const int NET_DVR_NETWORK_ERRORDATA = 11;
        /// <summary>
        /// 调用次序错误
        /// </summary>
        public const int NET_DVR_ORDER_ERROR = 12;
        /// <summary>
        /// 无此权限
        /// </summary>
        public const int NET_DVR_OPERNOPERMIT = 13;
        /// <summary>
        /// DVR命令执行超时
        /// </summary>
        public const int NET_DVR_COMMANDTIMEOUT = 14;
        /// <summary>
        /// 串口号错误
        /// </summary>
        public const int NET_DVR_ERRORSERIALPORT = 15;
        /// <summary>
        /// 报警端口错误
        /// </summary>
        public const int NET_DVR_ERRORALARMPORT = 16;
        /// <summary>
        /// 参数错误
        /// </summary>
        public const int NET_DVR_PARAMETER_ERROR = 17;
        /// <summary>
        /// 服务器通道处于错误状态
        /// </summary>
        public const int NET_DVR_CHAN_EXCEPTION = 18;
        /// <summary>
        /// 没有硬盘
        /// </summary>
        public const int NET_DVR_NODISK = 19;
        /// <summary>
        /// 硬盘号错误
        /// </summary>
        public const int NET_DVR_ERRORDISKNUM = 20;
        /// <summary>
        /// 服务器硬盘满
        /// </summary>
        public const int NET_DVR_DISK_FULL = 21;
        /// <summary>
        /// 服务器硬盘出错
        /// </summary>
        public const int NET_DVR_DISK_ERROR = 22;
        /// <summary>
        /// 服务器不支持
        /// </summary>
        public const int NET_DVR_NOSUPPORT = 23;
        /// <summary>
        /// 服务器忙
        /// </summary>
        public const int NET_DVR_BUSY = 24;
        /// <summary>
        /// 服务器修改不成功
        /// </summary>
        public const int NET_DVR_MODIFY_FAIL = 25;
        /// <summary>
        /// 密码输入格式不正确
        /// </summary>
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;
        /// <summary>
        /// 硬盘正在格式化，不能启动操作
        /// </summary>
        public const int NET_DVR_DISK_FORMATING = 27;
        /// <summary>
        /// DVR资源不足
        /// </summary>
        public const int NET_DVR_DVRNORESOURCE = 28;
        /// <summary>
        /// DVR操作失败
        /// </summary>
        public const int NET_DVR_DVROPRATEFAILED = 29;
        /// <summary>
        /// 打开PC声音失败
        /// </summary>
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;
        /// <summary>
        /// 服务器语音对讲被占用
        /// </summary>
        public const int NET_DVR_DVRVOICEOPENED = 31;
        /// <summary>
        /// 时间输入不正确
        /// </summary>
        public const int NET_DVR_TIMEINPUTERROR = 32;
        /// <summary>
        /// 回放时服务器没有指定的文件
        /// </summary>
        public const int NET_DVR_NOSPECFILE = 33;
        /// <summary>
        /// 创建文件出错
        /// </summary>
        public const int NET_DVR_CREATEFILE_ERROR = 34;
        /// <summary>
        /// 打开文件出错
        /// </summary>
        public const int NET_DVR_FILEOPENFAIL = 35;
        /// <summary>
        /// 上次的操作还没有完成
        /// </summary>
        public const int NET_DVR_OPERNOTFINISH = 36;
        /// <summary>
        /// 获取当前播放的时间出错
        /// </summary>
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;
        /// <summary>
        /// 播放出错
        /// </summary>
        public const int NET_DVR_PLAYFAIL = 38;
        /// <summary>
        /// 文件格式不正确
        /// </summary>
        public const int NET_DVR_FILEFORMAT_ERROR = 39;
        /// <summary>
        /// 路径错误
        /// </summary>
        public const int NET_DVR_DIR_ERROR = 40;
        /// <summary>
        /// 资源分配错误
        /// </summary>
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;
        /// <summary>
        /// 声卡模式错误
        /// </summary>
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;
        /// <summary>
        /// 缓冲区太小
        /// </summary>
        public const int NET_DVR_NOENOUGH_BUF = 43;
        /// <summary>
        /// 创建SOCKET出错
        /// </summary>
        public const int NET_DVR_CREATESOCKET_ERROR = 44;
        /// <summary>
        /// 设置SOCKET出错
        /// </summary>
        public const int NET_DVR_SETSOCKET_ERROR = 45;
        /// <summary>
        /// 个数达到最大
        /// </summary>
        public const int NET_DVR_MAX_NUM = 46;
        /// <summary>
        /// 用户不存在
        /// </summary>
        public const int NET_DVR_USERNOTEXIST = 47;
        /// <summary>
        /// 写FLASH出错
        /// </summary>
        public const int NET_DVR_WRITEFLASHERROR = 48;
        /// <summary>
        /// DVR升级失败
        /// </summary>
        public const int NET_DVR_UPGRADEFAIL = 49;
        /// <summary>
        /// 解码卡已经初始化过
        /// </summary>
        public const int NET_DVR_CARDHAVEINIT = 50;
        /// <summary>
        /// 调用播放库中某个函数失败
        /// </summary>
        public const int NET_DVR_PLAYERFAILED = 51;
        /// <summary>
        /// 设备端用户数达到最大
        /// </summary>
        public const int NET_DVR_MAX_USERNUM = 52;
        /// <summary>
        /// 获得客户端的IP地址或物理地址失败
        /// </summary>
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;
        /// <summary>
        /// 该通道没有编码
        /// </summary>
        public const int NET_DVR_NOENCODEING = 54;
        /// <summary>
        /// IP地址不匹配
        /// </summary>
        public const int NET_DVR_IPMISMATCH = 55;
        /// <summary>
        /// MAC地址不匹配
        /// </summary>
        public const int NET_DVR_MACMISMATCH = 56;
        /// <summary>
        /// 升级文件语言不匹配
        /// </summary>
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;
        /// <summary>
        /// 播放器路数达到最大
        /// </summary>
        public const int NET_DVR_MAX_PLAYERPORT = 58;
        /// <summary>
        /// 备份设备中没有足够空间进行备份
        /// </summary>
        public const int NET_DVR_NOSPACEBACKUP = 59;
        /// <summary>
        /// 没有找到指定的备份设备
        /// </summary>
        public const int NET_DVR_NODEVICEBACKUP = 60;
        /// <summary>
        /// 图像素位数不符，限24色
        /// </summary>
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;
        /// <summary>
        /// 图片高*宽超限， 限128*256
        /// </summary>
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;
        /// <summary>
        /// 图片大小超限，限100K
        /// </summary>
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;
        /// <summary>
        /// 载入当前目录下Player Sdk出错
        /// </summary>
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;
        /// <summary>
        /// 找不到Player Sdk中某个函数入口
        /// </summary>
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;
        /// <summary>
        /// 载入当前目录下DSsdk出错
        /// </summary>
        public const int NET_DVR_LOADDSSDKFAILED = 66;
        /// <summary>
        /// 找不到DsSdk中某个函数入口
        /// </summary>
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;
        /// <summary>
        /// 调用硬解码库DsSdk中某个函数失败
        /// </summary>
        public const int NET_DVR_DSSDK_ERROR = 68;
        /// <summary>
        /// 声卡被独占
        /// </summary>
        public const int NET_DVR_VOICEMONOPOLIZE = 69;
        /// <summary>
        /// 加入多播组失败
        /// </summary>
        public const int NET_DVR_JOINMULTICASTFAILED = 70;
        /// <summary>
        /// 建立日志文件目录失败
        /// </summary>
        public const int NET_DVR_CREATEDIR_ERROR = 71;
        /// <summary>
        /// 绑定套接字失败
        /// </summary>
        public const int NET_DVR_BINDSOCKET_ERROR = 72;
        /// <summary>
        /// socket连接中断，此错误通常是由于连接中断或目的地不可达
        /// </summary>
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;
        /// <summary>
        /// 注销时用户ID正在进行某操作
        /// </summary>
        public const int NET_DVR_USERID_ISUSING = 74;
        /// <summary>
        /// 监听失败
        /// </summary>
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;
        /// <summary>
        /// 程序异常
        /// </summary>
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;
        /// <summary>
        /// 写文件失败
        /// </summary>
        public const int NET_DVR_WRITEFILE_FAILED = 77;
        /// <summary>
        /// 禁止格式化只读硬盘
        /// </summary>
        public const int NET_DVR_FORMAT_READONLY = 78;
        /// <summary>
        /// 用户配置结构中存在相同的用户名
        /// </summary>
        public const int NET_DVR_WITHSAMEUSERNAME = 79;
        /// <summary>
        /// 导入参数时设备型号不匹配
        /// </summary>
        public const int NET_DVR_DEVICETYPE_ERROR = 80;
        /// <summary>
        /// 导入参数时语言不匹配
        /// </summary>
        public const int NET_DVR_LANGUAGE_ERROR = 81;
        /// <summary>
        /// 导入参数时软件版本不匹配
        /// </summary>
        public const int NET_DVR_PARAVERSION_ERROR = 82;
        /// <summary>
        /// 预览时外接IP通道不在线
        /// </summary>
        public const int NET_DVR_IPCHAN_NOTALIVE = 83;
        /// <summary>
        /// 加载高清IPC通讯库StreamTransClient失败
        /// </summary>
        public const int NET_DVR_RTSP_SDK_ERROR = 84;
        /// <summary>
        /// 加载转码库CVT_StdToHik失败
        /// </summary>
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;
        /// <summary>
        /// 超出最大的ip接入通道数
        /// </summary>
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;
        #endregion
        #region 4.2.1   软解码库错误码
        /// <summary>
        /// no error.
        /// </summary>
        public const int NET_PLAYM4_NOERROR = 500;
        /// <summary>
        /// input parameter is invalid.
        /// </summary>
        public const int NET_PLAYM4_PARA_OVER = 501;
        /// <summary>
        /// The order of the function to be called is error.
        /// </summary>
        public const int NET_PLAYM4_ORDER_ERROR = 502;
        /// <summary>
        /// Create multimedia clock failed.
        /// </summary>
        public const int NET_PLAYM4_TIMER_ERROR = 503;
        /// <summary>
        /// Decode video data failed.
        /// </summary>
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;
        /// <summary>
        /// Decode audio data failed.
        /// </summary>
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;
        /// <summary>
        /// Allocate memory failed.
        /// </summary>
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;
        /// <summary>
        /// Open the file failed.
        /// </summary>
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;
        /// <summary>
        /// Create thread or event failed.
        /// </summary>
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;
        /// <summary>
        /// Create DirectDraw object failed.
        /// </summary>
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;
        /// <summary>
        /// failed when creating off-screen surface.
        /// </summary>
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;
        /// <summary>
        /// buffer is overflow.
        /// </summary>
        public const int NET_PLAYM4_BUF_OVER = 511;
        /// <summary>
        /// failed when creating audio device.
        /// </summary>
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;
        /// <summary>
        /// Set volume failed.
        /// </summary>
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;
        /// <summary>
        /// The function only support play file.
        /// </summary>
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;
        /// <summary>
        /// The function only support play stream.
        /// </summary>
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;
        /// <summary>
        /// System not support.
        /// </summary>
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;
        /// <summary>
        /// No file header.
        /// </summary>
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;
        /// <summary>
        /// The version of decoder and encoder is not adapted.
        /// </summary>
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;
        /// <summary>
        /// Initialize decoder failed.
        /// </summary>
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;
        /// <summary>
        /// The file data is unknown.
        /// </summary>
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;
        /// <summary>
        /// Initialize multimedia clock failed.
        /// </summary>
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;
        /// <summary>
        /// Blt failed.
        /// </summary>
        public const int NET_PLAYM4_BLT_ERROR = 522;
        /// <summary>
        /// Update failed.
        /// </summary>
        public const int NET_PLAYM4_UPDATE_ERROR = 523;
        /// <summary>
        /// openfile error, streamtype is multi.
        /// </summary>
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;
        /// <summary>
        /// openfile error, streamtype is video.
        /// </summary>
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;
        /// <summary>
        /// JPEG compress error
        /// </summary>
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;
        /// <summary>
        /// Don't support the version of this file.
        /// </summary>
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;
        /// <summary>
        /// extract video data failed.
        /// </summary>
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;
        #endregion
        #endregion
        #endregion
        #region 5.     客户端预览
        #region 5.1    客户端预览
        /// <summary>
        /// 显示模式
        /// </summary>
        public enum DISPLAY_MODE : uint
        {
            /// <summary>
            /// 可以同时显示多窗口，但是对显卡有一定的要求
            /// </summary>
            NORMALMODE = 0,
            /// <summary>
            /// 只能同时显示一个窗口，但是对显卡基本没有要求
            /// </summary>
            OVERLAYMODE
        }
        /// <summary>
        /// 5.1.1   设置预览显示模式
        ///     注意
        ///         透明色相当于一层透视膜，显示的画面只能穿过这种颜色，而其他的颜色将挡住显示的画面，用户应该在显示窗口中涂上这种颜色才能看到显示画面，一般应该使用一种
        ///         不常用的颜色作为透明色，colorKey是一个32位的值0x00rrggbb，最高字节为0，后三个字节分别表示r、g、b的值。
        ///         设置播放器显示模式，需在播放之前设置。播放器有两种显示模式：普通模式和OVERLAY方式，使用OVERLAY模式的优点是：大部分显卡都支持OVERLAY，在一些不支持BLT硬件缩放和颜色转换的显卡上(如SIS系列显卡)使用OVERLAY模式，可以大大降低CPU利用率并提高画面质量(相对于软件实现缩放、颜色转换)。缺点是：同时只能播放一路图象，不能实现大规模集中监控。
        ///         在一块显卡中同一时刻只能有一个OVERLAY表面处于活动状态，如果此时系统中已经有程序使用了OVERLAY，那么播放器就不能再创建OVERLAY表面，它将自动改成普通的模式，并不返回FALSE，一些常用的播放器，例如我们卡的预览都可能使用了OVERLAY表面，同样，如果我们的SDK中使用了OVERALY表面，那么其他的程序将不能再使用OVERLAY表面。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetShowMode(DWORD dwShowType,COLORREF colorKey);
        /// </summary>
        /// <param name="dwShowType">[in]显示模式，详见显示模式类型定义{NORMALMODE = 0,OVERLAYMODE}</param>
        /// <param name="colorKey">[in]用户设置的透明色，在OVERLAY模式下需要设置</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode(DISPLAY_MODE dwShowType, int colorKey);
        #region 启停客户端预览
        /// <summary>
        /// 系统头数据
        /// </summary>
        public const int NET_DVR_SYSHEAD = 1;
        /// <summary>
        /// 视频流数据（包括复合流和音视频分开的视频流数据）
        /// </summary>
        public const int NET_DVR_STREAMDATA = 2;
        /// <summary>
        /// 音频流数据
        /// </summary>
        public const int NET_DVR_AUDIOSTREAMDATA = 3;
       
        /// <summary>
        /// 5.1.2   启动客户端实时预览[可选connect是否在线程中处理]
        ///     说明
        ///         不阻塞：设备应答请求连接就认为连接成功，如果发生码流接收失败、播放失败等情况以预览异常的方式告知应用层。在循环播放的时候可以减短停顿的时间。与原来的NET_DVR_RealPlay功能一致。
        ///         阻塞：直到播放成功才返回成功给应用层。
        ///     NET_DVR_API LONG __stdcall NET_DVR_RealPlay_V30(LONG lUserID, LPNET_DVR_CLIENTINFO lpClientInfo, void(CALLBACK *fRealDataCallBack_V30) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer, DWORD dwBufSize, void* pUser) = NULL, void* pUser = NULL, BOOL bBlocked = FALSE);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpClientInfo">[in]NET_DVR_CLIENTINFO结构的指针</param>
        /// <param name="fRealDataCallBack_V30">[in]视频数据回调函数</param>
        /// <param name="pUser">[in]用户数据</param>
        /// <param name="bBlocked">[in]请求视频过程是否阻塞：0－否；1－是</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_StopRealPlay等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser);
        /// <summary>
        /// 启动客户端实时预览
        ///     NET_DVR_API LONG __stdcall NET_DVR_RealPlay(LONG lUserID,LPNET_DVR_CLIENTINFO lpClientInfo);
        /// </summary>
        /// <param name="lUserID">[in]用户登录ID，NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpClientInfo">[in]指向NET_DVR_CLIENTINFO结构</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_StopRealPlay等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay(int lUserID, ref NET_DVR_PREVIEWINFO lpClientInfo);
        /// <summary>
        /// 5.1.3   关闭预览功能
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopRealPlay(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay(int lRealHandle);
        #endregion
        #region 获取预览时播放器句柄
        /// <summary>
        /// 5.1.4   获取预览时用来解码和显示的播放器句柄
        ///     说明
        ///         可以通过返回的句柄来调用播放器SDK接口实现特定的功能。
        ///         例如使用PlayM4_GetBMP(LONG nPort,……)、PlayM4_GetJPEG(LONG nPort,……)这两个接口时，作如下调用，即可实现将此时预览图像抓图BMP或JPEG保存到内存中：
        ///         PlayM4_GetBMP(NET_DVR_GetRealPlayerIndex(),……)
        ///         PlayM4_GetJPEG(NET_DVR_GetRealPlayerIndex(),……)
        ///     NET_DVR_API int __stdcall NET_DVR_GetRealPlayerIndex(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        #endregion
        #region 设置/获取视频参数
        /// <summary>
        /// 5.1.5   设置视频参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientSetVideoEffect(LONG lRealHandle,DWORD dwBrightValue,DWORD dwContrastValue, DWORD dwSaturationValue,DWORD dwHueValue);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwBrightValue">[in]亮度(取值为1-10)</param>
        /// <param name="dwContrastValue">[in]对比度(取值为1-10)</param>
        /// <param name="dwSaturationValue">[in]饱和度(取值为1-10)</param>
        /// <param name="dwHueValue">[in]色度(取值为1-10)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);
        /// <summary>
        /// 5.1.6   获取视频参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientGetVideoEffect(LONG lRealHandle,DWORD *pBrightValue,DWORD *pContrastValue, DWORD *pSaturationValue,DWORD *pHueValue);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="pBrightValue">[out]存放亮度值的指针(值为1-10)</param>
        /// <param name="pContrastValue">[out]存放对比度值的指针(值为1-10)</param>
        /// <param name="pSaturationValue">[out]存放饱和度值的指针(值为1-10)</param>
        /// <param name="pHueValue">[out]存放色度值的指针(值为1-10)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, out uint pBrightValue, out uint pContrastValue, out uint pSaturationValue, out uint pHueValue);

        #endregion
        #region 预览界面叠加字符
        /// <summary>
        /// 画图回调函数
        ///     void (CALLBACK* fDrawFun)(LONG lRealHandle,HDC hDc,DWORD dwUser)
        /// </summary>
        /// <param name="lRealHandle">NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="hDc">OffScreen表面设备上下文，可以像操作显示窗口客户区DC一样操作它</param>
        /// <param name="dwUser">用户数据，输入的用户数据</param>
        public delegate void DrawFun(int lRealHandle, IntPtr hDc, uint dwUser);
        /// <summary>
        /// 5.1.7   客户端预览界面上叠加字符图像
        ///     说明
        ///         注册一个回调函数，获得当前表面的device context，用户可以在这个DC上画图或写字，就好像在窗口的客户区DC上绘图，
        ///         但这个DC不是窗口客户区的DC，而是播放器DirectDraw里的Off-Screen表面的DC。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_RigisterDrawFun(LONG lRealHandle,void (CALLBACK* fDrawFun)(LONG lRealHandle,HDC hDc,DWORD dwUser),DWORD dwUser);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="fDrawFun">[in]画图回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DrawFun fDrawFun, uint dwUser);
        #endregion
        #region 播放控制与操作
        /// <summary>
        /// 5.1.8   设置播放器帧缓冲区的个数
        ///     说明
        ///         设置网络延时和流畅度可以通过此函数来进行调节，如果dwBufNum 值越大，播放的流畅性越好，相应的延时比较大，dwBufNum 值越小，
        ///         播放的延时很小，但是当网络不太顺畅的时候，会有丢帧现象，感觉播放不会很流畅。一般设置的帧缓冲大于等于6帧时，
        ///         音频预览才会正常，如果不需要音频预览，只需要视频实时性则这个值可以设置的更小。此函数要紧跟在NET_DVR_RealPlay后使用，
        ///         在图像播放之后设置则不起作用！硬解码时则通过相应的硬解码的函数来调整延时和流畅程度。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetPlayerBufNumber(LONG lRealHandle,DWORD dwBufNum);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwBufNum">[in]播放器帧缓冲区缓存的最大帧数，取值为（1－50），缓冲区越大，播放越流畅；缓冲区越小，实时性越好。若是复合流建议最小值设置成6</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber(int lRealHandle, uint dwBufNum);
        /// <summary>
        /// 5.1.9   设置解码时丢弃B帧的个数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ThrowBFrame(LONG lRealHandle,DWORD dwNum);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwNum">[in]丢弃B帧的个数，取值：0－不丢；1－丢1个B帧；2－丢2个B帧。在多路播放时，将B帧丢弃可以降低CPU的利用率，不过当单路播放时，最好不丢弃B帧</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame(int lRealHandle, uint dwNum);
        /// <summary>
        /// 5.1.10 网络预览时设备端主码流动态产生一个关键帧
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MakeKeyFrame(LONG lUserID, LONG lChannel);
        /// </summary>
        /// <param name="lUserID">[in]用户ID，NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame(int lUserID, int lChannel);//主码流
        /// <summary>
        /// 5.1.11 网络预览时设备端子码流动态产生一个关键帧
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MakeKeyFrameSub(LONG lUserID, LONG lChannel);
        /// </summary>
        /// <param name="lUserID">[in]用户ID，NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrameSub(int lUserID, int lChannel);//子码流
        #endregion
        #region 声音控制
        /// <summary>
        /// 5.1.12 设置声音播放模式（独享/共享）
        ///     说明
        ///         选择声音预览是采用独占声卡模式还是共享声卡模式。该函数要在图像预览前设置。如果不设置，SDK默认设置为独占声卡模式。
        ///         当设置成独占模时，每一路的声音默认是关闭的；当设置成共享模式时，每一路的声音默认是打开的
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetAudioMode(DWORD dwMode);
        /// </summary>
        /// <param name="dwMode">[in]设置声音播放模式：1－独占声卡，单路音频模式；2－共享声卡，多路音频模式</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);
        /// <summary>
        /// 5.1.13 独占声卡模式下开启声音
        ///     注意
        ///         当有多路时，调用这个函数会停掉其他路的声音，一次只能预览一路声音
        ///     NET_DVR_API BOOL __stdcall NET_DVR_OpenSound(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound(int lRealHandle);
        /// <summary>
        /// 5.1.14 独占声卡模式下关闭声音
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseSound();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();
        /// <summary>
        /// 5.1.15 共享声卡模式下开启一路声音
        ///     NET_DVR_API BOOL __stdcall NET_DVR_OpenSoundShare(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare(int lRealHandle);
        /// <summary>
        /// 5.1.16 共享声卡模式下关闭一路声音
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseSoundShare(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare(int lRealHandle);
        /// <summary>
        /// 5.1.17 调节音量
        ///     NET_DVR_API BOOL __stdcall NET_DVR_Volume(LONG lRealHandle,WORD wVolume);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="wVolume">[in]设置音量，取值范围：0~0xffff</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume(int lRealHandle, ushort wVolume);
        #endregion
        #endregion
        #region 5.3    多屏显示
        /// <summary>
        /// 5.3.1   枚举系统中的显示设备
        ///     NET_DVR_API BOOL __stdcall NET_DVR_InitDDrawDevice();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDrawDevice();
        /// <summary>
        /// 5.3.2   释放枚举显示设备的过程中分配的资源
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ReleaseDDrawDevice();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDrawDevice();
        /// <summary>
        /// 5.3.3   获得系统中与windows桌面绑定的总的显示设备数，主要是指显卡
        ///     NET_DVR_API LONG __stdcall NET_DVR_GetDDrawDeviceTotalNums();
        /// </summary>
        /// <returns>如果返回0，则表示系统中只有主显示设备；如果返回1，则表示系统中安装了多块显卡，但只有一块显卡与Windows桌面绑定；
        /// 返回其他值，则表示系统中与桌面绑定的显卡数目。
        /// 在多显卡的系统中可以通过设置显示属性，而指定任意一块显卡作为主显示设备。
        /// </returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();
        /// <summary>
        /// 5.3.4   设置播放窗口使用的显卡
        ///     注意
        ///         该窗口必须在该显卡所对应的监视器上才能显示播放画面。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDDrawDevice(LONG lPlayPort, DWORD nDeviceNum);
        /// </summary>
        /// <param name="lPlayPort">[in]播放器句柄, NET_DVR_GetRealPlayerIndex、NET_DVR_GetPlayBackPlayerIndex</param>
        /// <param name="nDeviceNum">[in]显示设备的设备号，如果是0，则表示使用主显示设备。</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);
        #endregion
        #endregion
        #region 6.     客户端数据捕获
        #region 6.1    客户端数据捕获
        #region 码流捕获与保存
        /// <summary>
        /// 标准视频流数据
        /// </summary>
        public const int NET_DVR_STD_VIDEODATA = 4;
        /// <summary>
        /// 标准音频流数据
        /// </summary>
        public const int NET_DVR_STD_AUDIODATA = 5; 
        /// <summary>
        /// 6.1.1   实时码流数据捕获
        ///     设置回调函数，获取实时的数据码流，客户可自己处理（存储、解码等）此数据
        ///     注意
        ///         此函数包括开始和停止用户处理客户端收到的数据，当fRealDataCallBack不为NULL时，开始用户处理客户端收到的数据，
        ///         当设置为NULL表示停止用户处理客户端收到的数据.当用户开始接收数据时，第一个包是40个字节的文件头,用户可以用这个头来打开播放器,以后回调的就是压缩的码流。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetRealDataCallBack(LONG lRealHandle,void(CALLBACK *fRealDataCallBack) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser),DWORD dwUser);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="fRealDataCallBack">[in]回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, RealDataCallBack fRealDataCallBack, IntPtr dwUser);
      
        /// <summary>
        /// 6.1.2   标准码流捕获
        ///     设置回调函数，用户自己处理客户端收到的数据，此处获取的标准码流带RTP标准头（12字节）
        ///     注意
        ///         此函数包括开始和停止用户处理客户端收到的数据，当fStdDataCallBack不为NULL时，开始用户处理客户端收到的数据，
        ///         当设置为NULL表示停止用户处理客户端收到的数据.当用户开始接收数据时，第一个包是40个字节的文件头,
        ///         用户可以用这个头来打开播放器,以后回调的就是压缩的标准码流。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetStandardDataCallBack(LONG lRealHandle,void(CALLBACK *fStdDataCallBack) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser),DWORD dwUser);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="fStdDataCallBack">[in]回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, StdDataCallBack fStdDataCallBack, IntPtr dwUser);
        /// <summary>
        /// 6.1.3   保存捕获到的数据到指定的文件(*.mp4)中
        ///     可用本函数实现客户端录像功能
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SaveRealData(LONG lRealHandle,char *sFileName);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="sFileName">[in]文件名，后缀为 .mp4/param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData(int lRealHandle, string sFileName);
        /// <summary>
        /// 6.1.4   停止数据捕获
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopSaveRealData(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData(int lRealHandle);
        #endregion
        #region 单帧数据捕获与保存
        /// <summary>
        /// 6.1.5   抓图并转换成32位真彩色BMP位图
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CapturePicture(LONG lRealHandle,char *sPicFileName);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="sPicFileName">[in]保存BMP图象的文件名后缀为 .bmp，文件的长度小于等于100字节。</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture(int lRealHandle, string sPicFileName);//bmp
        /// <summary>
        /// 6.1.6   抓JPEG图,保存成文件
        ///     注意
        ///         高清IPCAM抓图，当图像压缩分辨率为VGA时，支持0=CIF, 1=QCIF, 2=4CIF抓图，
        ///         当分辨率为3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720)仅支持当前分辨率的抓图。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CaptureJPEGPicture(LONG lUserID, LONG lChannel, LPNET_DVR_JPEGPARA lpJpegPara, char *sPicFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpJpegPara">[in]指向NET_DVR_JPEGPARA结构</param>
        /// <param name="sPicFileName">[in]保存JPEG数据的文件的文件名</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);
        //JPEG抓图到内存
        /// <summary>
        /// 6.1.7   抓JPEG图, 保存在内存中
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CaptureJPEGPicture_NEW(LONG lUserID, LONG lChannel, LPNET_DVR_JPEGPARA lpJpegPara, char *sJpegPicBuffer, DWORD dwPicSize,  LPDWORD lpSizeReturned);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpJpegPara">[in]指向NET_DVR_JPEGPARA结构</param>
        /// <param name="sJpegPicBuffer">[in]保存JPEG数据的缓冲区</param>
        /// <param name="dwPicSize">[in]输入缓冲区大小</param>
        /// <param name="lpSizeReturned">[out]返回图片数据的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara,   byte[] sJpegPicBuffer, uint dwPicSize, out uint lpSizeReturned);
        #endregion
        #endregion 
        #endregion
        #region 7.     录像操作
        #region 7.1    远程手动录像
        /// <summary>
        /// 7.1.1   远程启动硬盘录像机手动录像
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StartDVRRecord(LONG lUserID,LONG lChannel,LONG lRecordType);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lRecordType">[in]录像类型(此参数暂时无效)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);
        /// <summary>
        /// 7.1.2   远程停止硬盘录像机录像
        ///    NET_DVR_API BOOL __stdcall NET_DVR_StopDVRRecord(LONG lUserID,LONG lChannel);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);
        #endregion
        #region 7.2    远程锁定/解锁录像文件
        /// <summary>
        /// 7.2.1   按文件名锁定录像文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_LockFileByName(LONG lUserID, char *sLockFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sLockFileName">[in]要锁定的文件名</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);
        /// <summary>
        /// 7.2.2   按文件名解锁
        ///     NET_DVR_API BOOL __stdcall NET_DVR_UnlockFileByName(LONG lUserID, char *sUnlockFileName);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sUnlockFileName">[in]要解锁的文件名</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);
        #endregion
        #region 7.3    查询、回放与下载
        #region 查找录像文件
        /// <summary>
        /// 7.3.1   根据文件类型、时间查找硬盘录像机存储文件
        ///     NET_DVR_API LONG __stdcall NET_DVR_FindFile(LONG lUserID,LONG lChannel,DWORD dwFileType, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="dwFileType">[in]要查找的文件类型：0xff－全部；0－定时录像；1—移动侦测；2－报警触发；3－报警|动测；4—报警&动测；5—命令触发；6－手动录像</param>
        /// <param name="lpStartTime">[in]文件的开始时间</param>
        /// <param name="lpStopTime">[in]文件的结束时间</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_FindClose等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime);
        /// <summary>
        /// 7.3.2   根据文件类型、时间、卡号查找硬盘录像机存储文件
        ///    注意
        ///        当该接口返回成功后,就可以调用NET_DVR_FindNextFile接口来获取文件信息
        ///     NET_DVR_API LONG __stdcall NET_DVR_FindFileByCard(LONG lUserID,LONG lChannel,DWORD dwFileType, int nFindType, BYTE *sCardNumber, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="dwFileType">[in]要查找的文件类型：0xFF－全部；0－定时录像；1—移动侦测；2－接近报警；3－出钞报警；4－进钞报警；5—命令触发；6－手动录像,；7－震动报警</param>
        /// <param name="nFindType">[in]是否需要卡号信息 TRUE：需要；FALSE：不需要</param>
        /// <param name="sCardNumber">[in]卡号信息</param>
        /// <param name="lpStartTime">[in]文件的开始时间</param>
        /// <param name="lpStopTime">[in]文件的结束时间</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_FindClose等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, byte[] sCardNumber, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime);
        /// <summary>
        /// 7.3.3   文件查找
        ///     NET_DVR_API LONG __stdcall NET_DVR_FindFile_V30(LONG lUserID, LPNET_DVR_FILECOND pFindCond);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_30的返回值</param>
        /// <param name="pFindCond">[in]文件查找结构，是否选中卡号</param>
        /// <returns>-1表示失败,其他值作为NET_DVR_FindNextFile_V30等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30(int lUserID, NET_DVR_FILECOND pFindCond);
        /// <summary>
        /// 获得文件信息
        /// </summary>
        public const int NET_DVR_FILE_SUCCESS = 1000;
        /// <summary>
        /// 没有文件
        /// </summary>
        public const int NET_DVR_FILE_NOFIND = 1001;
        /// <summary>
        /// 正在查找文件
        /// </summary>
        public const int NET_DVR_ISFINDING = 1002;
        /// <summary>
        /// 查找文件时没有更多的文件
        /// </summary>
        public const int NET_DVR_NOMOREFILE = 1003;
        /// <summary>
        /// 查找文件时异常
        /// </summary>
        public const int NET_DVR_FILE_EXCEPTION = 1004;
        /// <summary>
        /// 7.3.4   文件信息获取
        ///     NET_DVR_API LONG __stdcall NET_DVR_FindNextFile_V30(LONG lFindHandle, LPNET_DVR_FINDDATA_V30 lpFindData);
        /// </summary>
        /// <param name="lFindHandle">[in]文件查找句柄,NET_DVR_FindFile_V30的返回值</param>
        /// <param name="lpFindData">[out]保存文件信息的指针</param>
        /// <returns>
        ///     -1   表示失败
        ///     #define NET_DVR_FILE_SUCCESS    1000    表示获取文件信息成功
        ///     #define NET_DVR_FILE_NOFIND     1001    表示没有找到文件
        ///     #define NET_DVR_ISFINDING       1002    表示正在查找请等待
        ///     #define NET_DVR_NOMOREFILE      1003    表示没有更多的文件，查找结束
        ///     #define NET_DVR_FILE_EXCEPTION  1004    查找文件时异常
        /// </returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, NET_DVR_FINDDATA_V30 lpFindData);
        /// <summary>
        /// 文件信息获取
        ///     NET_DVR_API LONG __stdcall NET_DVR_FindNextFile(LONG lFindHandle,LPNET_DVR_FIND_DATA lpFindData);
        /// </summary>
        /// <param name="lFindHandle">[in]文件查找句柄，由NET_DVR_FindFile返回</param>
        /// <param name="lpFindData">[out]保存文件信息的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, out NET_DVR_FIND_DATA lpFindData);
        /// <summary>
        /// 7.3.5   关闭文件查找，释放资源
        ///     NET_DVR_API BOOL __stdcall NET_DVR_FindClose_V30(LONG lFindHandle);
        /// </summary>
        /// <param name="lFindHandle">[in]文件查找句柄NET_DVR_FindFile_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose_V30(int lFindHandle);
        /// <summary>
        /// 关闭文件查找，释放资源
        ///     NET_DVR_API BOOL __stdcall NET_DVR_FindClose(LONG lFindHandle);
        /// </summary>
        /// <param name="lFindHandle">[in]文件查找句柄，由NET_DVR_FindFile返回</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);
        #endregion
        #region 回放录像文件
        /// <summary>
        /// 7.3.6   按文件名回放
        ///     NET_DVR_API LONG __stdcall NET_DVR_PlayBackByName(LONG lUserID,char *sPlayBackFileName, HWND hWnd);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_30的返回值</param>
        /// <param name="sPlayBackFileName">[in]要回放的文件名</param>
        /// <param name="hWnd">[in]回放文件的窗口句柄</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_StopPlayBack等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);
        /// <summary>
        /// 7.3.7   按时间回放
        ///     NET_DVR_API LONG __stdcall NET_DVR_PlayBackByTime(LONG lUserID,LONG lChannel, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime, HWND hWnd);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpStartTime">[in]文件的开始时间</param>
        /// <param name="lpStopTime">[in]文件的结束时间</param>
        /// <param name="hWnd">[in]回放的窗口句柄</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime, IntPtr hWnd);
        /// <summary>
        /// 7.3.8   停止回放
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopPlayBack(LONG lPlayHandle);
        /// </summary>
        /// <param name="lPlayHandle"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);
        /// <summary>
        /// 7.3.9   获取回放时用来解码和显示的播放器句柄
        ///     NET_DVR_API int __stdcall NET_DVR_GetPlayBackPlayerIndex(LONG lPlayHandle);
        /// </summary>
        /// <param name="lPlayHandle">[in]NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回值</param>
        /// <returns>
        ///     播放器句柄
        ///         可以通过该句柄来调用播放器SDK接口实现特定的功能
        ///         例如使用PlayM4_GetBMP(LONG nPort,……)、PlayM4_GetJPEG(LONG nPort,……)这两个接口时，作如下调用，即可实现将此时回放录像的图像抓图BMP或JPEG保存到内存中：
        ///         PlayM4_GetBMP(NET_DVR_GetPlayBackPlayerIndex (),……)
        ///         PlayM4_GetJPEG(NET_DVR_GetPlayBackPlayerIndex (),……)
        /// </returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);
        #region 回放状态命令/文件播放命令(1-12)
        /// <summary>
        /// 开始播放
        /// </summary>
        public const int NET_DVR_PLAYSTART = 1;
        /// <summary>
        /// 停止播放
        /// </summary>
        public const int NET_DVR_PLAYSTOP = 2;
        /// <summary>
        /// 暂停播放
        /// </summary>
        public const int NET_DVR_PLAYPAUSE = 3;
        /// <summary>
        /// 恢复播放
        /// </summary>
        public const int NET_DVR_PLAYRESTART = 4;
        /// <summary>
        /// 快放
        /// </summary>
        public const int NET_DVR_PLAYFAST = 5;
        /// <summary>
        /// 慢放
        /// </summary>
        public const int NET_DVR_PLAYSLOW = 6;
        /// <summary>
        /// 正常速度
        /// </summary>
        public const int NET_DVR_PLAYNORMAL = 7;
        /// <summary>
        /// 单帧放
        /// </summary>
        public const int NET_DVR_PLAYFRAME = 8;
        /// <summary>
        /// 打开声音
        /// </summary>
        public const int NET_DVR_PLAYSTARTAUDIO = 9;
        /// <summary>
        /// 关闭声音
        /// </summary>
        public const int NET_DVR_PLAYSTOPAUDIO = 10;
        /// <summary>
        /// 调节音量
        /// </summary>
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;
        /// <summary>
        /// 改变文件回放的进度
        /// </summary>
        public const int NET_DVR_PLAYSETPOS = 12;
        /// <summary>
        /// 获取文件回放的进度
        /// </summary>
        public const int NET_DVR_PLAYGETPOS = 13;
        /// <summary>
        /// 获取当前已经播放的时间(按文件回放的时候有效)
        /// </summary>
        public const int NET_DVR_PLAYGETTIME = 14;
        /// <summary>
        /// 获取当前已经播放的帧数(按文件回放的时候有效)
        /// </summary>
        public const int NET_DVR_PLAYGETFRAME = 15;
        /// <summary>
        /// 获取当前播放文件总的帧数(按文件回放的时候有效)
        /// </summary>
        public const int NET_DVR_GETTOTALFRAMES = 16;
        /// <summary>
        /// 获取当前播放文件总的时间(按文件回放的时候有效)
        /// </summary>
        public const int NET_DVR_GETTOTALTIME = 17;
        /// <summary>
        /// 丢B帧
        /// </summary>
        public const int NET_DVR_THROWBFRAME = 20;
        #endregion
        /// <summary>
        /// 7.3.10 控制录像回放状态
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PlayBackControl(LONG lPlayHandle,DWORD dwControlCode,DWORD dwInValue,DWORD *LPOutValue);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <param name="dwControlCode">in]控制录像回放状态命令，见下表，如#define NET_DVR_PLAYSTART    1   开始播放</param>
        /// <param name="dwInValue">[in]比如设置文件回放的进度(NET_DVR_PLAYSETPOS)时，此参数表示进度值；比如开始播放 (NET_DVR_PLAYSTART)时，此参数表示断点续传的文件位置（Byte）</param>
        /// <param name="LPOutValue">[out]比如获取当前播放文件总的时间，此参数就是得到的总时间</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, out uint LPOutValue);
        /// <summary>
        /// 7.3.11 刷新显示
        ///     说明
        ///         当用户暂停或者单帧回放时，如果刷新了窗口，则窗口中的图像因为刷新而消失，此时调用这个接口可以重新把图像重新显示出来。
        ///         此接口只在暂停和单帧播放时有效。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_RefreshPlay(LONG lPlayHandle);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);
        /// <summary>
        /// 7.3.12 保存所回放的录像数据
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PlayBackSaveData(LONG lPlayHandle,char *sFileName);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <param name="sFileName">[in]保存的文件名</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);
        /// <summary>
        /// 7.3.13 停止保存录像数据
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopPlayBackSave(LONG lPlayHandle);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);
        /// <summary>
        ///     void(CALLBACK *fPlayDataCallBack) (LONG lPlayHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser)
        /// </summary>
        /// <param name="lPlayHandle">播放句柄</param>
        /// <param name="dwDataType">数据类型
        ///     #define NET_DVR_SYSHEAD     1       系统头数据
        ///     #define NET_DVR_STREAMDATA  2       流数据
        /// </param>
        /// <param name="pBuffer">存放数据的缓冲区指针</param>
        /// <param name="dwBufSize">缓冲区的大小</param>
        /// <param name="dwUser">输入的用户数据</param>
        public delegate void PlayDataCallBack(int lPlayHandle, uint dwDataType, byte[] pBuffer, uint dwBufSize, uint dwUser);
        /// <summary>
        /// 7.3.14 录像码流数据获取
        ///     注意
        ///         此函数包括开始和停止用户处理码流数据，当fPlayDataCallBack不为NULL时，开始用户处理收到的数据，
        ///         当设置为NULL表示停止用户处理收到的数据.当用户开始接收数据时，第一个包是40个字节的文件头,用户可以用这个头来打开播放器,
        ///         以后回调的就是音视频数据.
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetPlayDataCallBack(LONG lPlayHandle,void(CALLBACK *fPlayDataCallBack) (LONG lPlayHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser),DWORD dwUser);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <param name="fPlayDataCallBack">[in]回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PlayDataCallBack fPlayDataCallBack, uint dwUser);
        /// <summary>
        /// 7.3.15 获取录像回放时显示的OSD时间
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetPlayBackOsdTime(LONG lPlayHandle, LPNET_DVR_TIME lpOsdTime);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <param name="lpOsdTime">[out]获取的OSD时间，指向NET_DVR_TIME结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, out NET_DVR_TIME lpOsdTime);
        /// <summary>
        /// 7.3.16 录像回放时抓图
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PlayBackCaptureFile(LONG lPlayHandle,char *sFileName);
        /// </summary>
        /// <param name="lPlayHandle">[in]播放句柄，由NET_DVR_PlayBackByName或者NET_DVR_PlayBackByTime的返回</param>
        /// <param name="sFileName">[in]保存图片的文件名，文件名的长度小于等于100字节</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);
        #endregion
        #region 下载录像文件
        /// <summary>
        /// 7.3.17 按文件名下载
        ///     NET_DVR_API LONG __stdcall NET_DVR_GetFileByName(LONG lUserID,char *sDVRFileName,char *sSavedFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sDVRFileName">[in]要下载的文件名</param>
        /// <param name="sSavedFileName">[in]下载后保存到PC机的文件名</param>
        /// <returns>-1表示失败，其他值表示成功，作为NET_DVR_StopGetFile等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);
        /// <summary>
        /// 7.3.18 按时间下载
        ///     NET_DVR_API LONG __stdcall NET_DVR_GetFileByTime(LONG lUserID,LONG lChannel, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime, char *sSavedFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpStartTime">[in]开始时间</param>
        /// <param name="lpStopTime">[in]结束时间</param>
        /// <param name="sSavedFileName">[in]下载后保存到PC机的文件名</param>
        /// <returns>-1表示失败，其他值表示成功，作为NET_DVR_StopGetFile等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime, string sSavedFileName);
        /// <summary>
        /// 7.3.19 停止下载
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopGetFile(LONG lFileHandle);
        /// </summary>
        /// <param name="lFileHandle">[in]下载句柄，由NET_DVR_GetFileByName 或者NET_DVR_GetFileByTime 的返回</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);
        /// <summary>
        /// 7.3.20 获取录像文件下载的进度
        ///     NET_DVR_API int __stdcall NET_DVR_GetDownloadPos(LONG lFileHandle);
        /// </summary>
        /// <param name="lFileHandle">[in]下载句柄，由NET_DVR_GetFileByName或者NET_DVR_GetFileByTime的返回</param>
        /// <returns>-1表示失败；0～100表示下载的进度；100表示下载结束；正常范围0-100，如返回200表明出现网络异常。</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);
        #endregion
        #endregion
        #region 7.4    录像文件信息
        /// <summary>
        /// 7.4.1   录像文件时间信息结构体
        ///     相关函数
        ///         NET_DVR_FindFile、NET_DVR_FindFileByCard、
        ///         NET_DVR_PlayBackByTime、
        ///         NET_DVR_GetPlayBackOsdTime、
        ///         NET_DVR_GetFileByTime、
        ///         NET_DVR_UnlockFileByTime
        ///    NET_DVR_TIME, *LPNET_DVR_TIME;
        /// </summary>
        public struct NET_DVR_TIME
        {
            /// <summary>
            /// 年
            /// </summary>
            public uint dwYear;
            /// <summary>
            /// 月
            /// </summary>
            public uint dwMonth;
            /// <summary>
            /// 日
            /// </summary>
            public uint dwDay;
            /// <summary>
            /// 时
            /// </summary>
            public uint dwHour;
            /// <summary>
            /// 分
            /// </summary>
            public uint dwMinute;
            /// <summary>
            /// 秒
            /// </summary>
            public uint dwSecond;
        }
        /// <summary>
        /// 7.4.2   文件查找结构体
        ///     NET_DVR_FILECOND, *LPNET_DVR_FILECOND;
        /// </summary>
        public struct NET_DVR_FILECOND
        {
            /// <summary>
            /// 通道号
            /// </summary>
            public int lChannel;
            /// <summary>
            /// 录象文件类型0xff－全部，0－定时录像,1-移动侦测 ，2－报警触发，3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像
            /// </summary>
            public uint dwFileType;
            /// <summary>
            /// 是否锁定 0-正常文件,1-锁定文件, 0xff表示所有文件
            /// </summary>
            public uint dwIsLocked;
            /// <summary>
            /// 是否使用卡号
            /// </summary>
            public uint dwUseCardNo;
            /// <summary>
            /// 卡号
            ///     byte sCardNumber[32];
            /// </summary>
            public string sCardNumber;
            /// <summary>
            /// 开始时间
            /// </summary>
            public NET_DVR_TIME struStartTime;
            /// <summary>
            /// 结束时间
            /// </summary>
            public NET_DVR_TIME struStopTime;
        }
        /// <summary>
        /// 7.4.3   文件信息结构体（卡号、文件锁定）
        /// 录象文件参数(9000)
        ///     NET_DVR_FINDDATA_V30, *LPNET_DVR_FINDDATA_V30;
        /// </summary>
        public struct NET_DVR_FINDDATA_V30
        {
            /// <summary>
            /// 文件名
            ///     char sFileName[100];
            /// </summary>
            public string sFileName;
            /// <summary>
            /// 文件的开始时间
            /// </summary>
            public NET_DVR_TIME struStartTime;
            /// <summary>
            /// 文件的结束时间
            /// </summary>
            public NET_DVR_TIME struStopTime;
            /// <summary>
            /// 文件的大小
            /// </summary>
            public uint dwFileSize;
            /// <summary>
            /// 卡号
            ///     char sCardNum[32];
            /// </summary>
            public string sCardNum;
            /// <summary>
            /// 文件是否被锁定，9000设备支持，1－此文件已经被锁定；0－正常的文件
            /// </summary>
            public byte byLocked;
            /// <summary>
            ///     public byte byRes[3];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes;
        }
        /// <summary>
        /// 文件信息结构体
        ///     NET_DVR_FIND_DATA, *LPNET_DVR_FIND_DATA;
        /// </summary>
        public struct NET_DVR_FIND_DATA
        {
            /// <summary>
            /// 文件名
            ///     char sFileName[100];
            /// </summary>
            public string sFileName;
            /// <summary>
            /// 文件的开始时间
            /// </summary>
            public NET_DVR_TIME struStartTime;
            /// <summary>
            /// 文件的结束时间
            /// </summary>
            public NET_DVR_TIME struStopTime;
            /// <summary>
            /// 文件的大小
            /// </summary>
            public uint dwFileSize;
        }
        #endregion
        #endregion

        #region 8.     报警等信息上传
        #region 8.1    报警等信息上传
        #region 8.1.1   lCommand报警消息类型
        /// <summary>
        /// 上传报警信息(8000报警信息主动上传)
        /// </summary>
        public const int COMM_ALARM = 0x1100;
        /// <summary>
        /// iDS上传行为分析报警信息
        /// </summary>
        public const int COMM_ALARM_RULE = 0x1102;
        /// <summary>
        /// ATM DVR上传交易信息(ATMDVR主动上传交易信息)
        /// </summary>
        public const int COMM_TRADEINFO = 0x1500;
        /// <summary>
        /// 9000报警信息主动上传(9000报警信息主动上传)
        /// </summary>
        public const int COMM_ALARM_V30 = 0x4000;
        /// <summary>
        /// 9000设备IPC接入配置改变报警信息主动上传
        /// </summary>
        public const int COMM_IPCCFG = 0x4001;
        #endregion
        #region 8.1.2   设置（注册）设备消息接收回调函数
        /// <summary>
        /// typedef void (CALLBACK *MSGCallBack)(LONG lCommand, NET_DVR_ALARMER *pAlarmer, char *pAlarmInfo, DWORD dwBufLen, void* pUser);
        /// </summary>
        /// <param name="lCommand">报警消息类型</param>
        /// <param name="pAlarmer">报警设备信息，指向NET_DVR_ALARMER结构</param>
        /// <param name="pAlarmInfo">报警信息</param>
        /// <param name="dwBufLen">报警信息长度</param>
        /// <param name="pUser">输入的用户数据</param>
        public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, string pAlarmInfo, uint dwBufLen, IntPtr pUser);
        /// <summary>
        /// 8.1.2   设置（注册）设备消息接收回调函数
        ///     回调信息中包含设备详细信息
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, void* pUser);
        /// </summary>
        /// <param name="fMessageCallBack">回调函数</param>
        /// <param name="pUser">用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser);
        /// <summary>
        /// [in]消息回调函数，硬盘录像机主动发起的请求、通过报警上传通道收到的报警信息，都通过此函数回调
        ///     BOOL (CALLBACK *fMessCallBack)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen)
        /// </summary>
        /// <param name="lCommand">消息类型</param>
        /// <param name="sDVRIP">设备的IP地址</param>
        /// <param name="pBuf">存放信息的缓冲区，不同的消息类型分别指向不同的结构</param>
        /// <param name="dwBufLen">缓冲区的大小</param>
        /// <returns></returns>
        public delegate bool MessCallBack(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);
        /// <summary>
        /// 设置（注册）设备消息接收回调函数
        ///     以IP地址区分设备
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessCallBack(BOOL (CALLBACK *fMessCallBack)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen));
        /// </summary>
        /// <param name="fMessCallBack">[in]消息回调函数，硬盘录像机主动发起的请求、通过报警上传通道收到的报警信息，都通过此函数回调</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack(MessCallBack fMessCallBack);
        /// <summary>
        /// 
        ///     BOOL (CALLBACK *fMessCallBack_EX)(LONG lCommand,LONG lUserID,char *pBuf,DWORD dwBufLen)
        /// </summary>
        /// <param name="lCommand"></param>
        /// <param name="lUserID">用户登录ID，NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="pBuf"></param>
        /// <param name="dwBufLen"></param>
        /// <returns></returns>
        public delegate bool MessCallBack_EX(int lCommand, int lUserID, string pBuf, uint dwBufLen);
        /// <summary>
        /// 设置（注册）设备消息接收回调函数
        ///     以ID号区分设备
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessCallBack_EX(BOOL (CALLBACK *fMessCallBack_EX)(LONG lCommand,LONG lUserID,char *pBuf,DWORD dwBufLen));
        /// </summary>
        /// <param name="fMessCallBack_EX"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX(MessCallBack_EX fMessCallBack_EX);
        /// <summary>
        ///     BOOL (CALLBACK *fMessCallBack_NEW)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen, WORD dwLinkDVRPort)
        /// </summary>
        /// <param name="lCommand"></param>
        /// <param name="sDVRIP">设备的IP地址</param>
        /// <param name="pBuf"></param>
        /// <param name="dwBufLen"></param>
        /// <param name="dwLinkDVRPort">设备连接端口号，默认为8000端口</param>
        /// <returns></returns>
        public delegate bool MessCallBack_NEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);
        /// <summary>
        /// 设置（注册）设备消息接收回调函数
        ///     以DVR IP地址和连接DVR端口区分设备
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessCallBack_NEW(BOOL (CALLBACK *fMessCallBack_NEW)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen, WORD dwLinkDVRPort));
        /// </summary>
        /// <param name="fMessCallBack_NEW"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MessCallBack_NEW fMessCallBack_NEW);
        /// <summary>
        ///     BOOL (CALLBACK *fMessageCallBack)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen, DWORD dwUser)
        /// </summary>
        /// <param name="lCommand"></param>
        /// <param name="sDVRIP"></param>
        /// <param name="pBuf"></param>
        /// <param name="dwBufLen"></param>
        /// <param name="dwUser"></param>
        /// <returns></returns>
        public delegate bool MessageCallBack(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, uint dwUser);
        /// <summary>
        /// 设置（注册）设备消息接收回调函数
        ///     回调函数中带有用户数据
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRMessageCallBack(BOOL (CALLBACK *fMessageCallBack)(LONG lCommand,char *sDVRIP,char *pBuf,DWORD dwBufLen, DWORD dwUser), DWORD dwUser);
        /// </summary>
        /// <param name="fMessageCallBack"></param>
        /// <param name="dwUser">[in]用户自定义数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack(MessageCallBack fMessageCallBack, uint dwUser);
        #endregion
        #region 监听方式获取报警等上传信息（主动方式）
        /// <summary>
        /// 启动监听程序[支持多线程]
        ///     注：该函数中的回调函数与上述8.1.2节中的5类回调函数是独立的，该处若回调函数设置为非空，即使不调用8.1.2节中的接口也能回调报警信息；若此处的回调函数设置为空，
        ///     那么就必须调用8.1.2节中的设置回调函数才能回调报警信息。
        ///     NET_DVR_API LONG __stdcall NET_DVR_StartListen_V30(char *sLocalIP, WORD wLocalPort, MSGCallBack DataCallback = NULL, void* pUserData = NULL);
        /// </summary>
        /// <param name="sLocalIP">[in]PC本地IP地址</param>
        /// <param name="wLocalPort">[im]PC本地监听端口号，由用户设置，和设备端的一致</param>
        /// <param name="DataCallback">[in]回调函数</param>
        /// <param name="pUserData">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_StartListen_V30(string sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);
        /// <summary>
        /// 启动监听程序，监听硬盘录像机发起的请求，接收硬盘录像机的信息
        ///     注意
        ///         要使客户端PC能够收到硬盘录像机主动发过来的信息，必须将硬盘录像机的网络配置中的“远程管理主机地址”
        ///         或者“远程报警主机地址”设置成PC机的IP地址，“远程管理主机端口号”或者“远程报警主机端口号”
        ///         设置成PC机的监听端口号。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StartListen(char *sLocalIP,WORD wLocalPort);
        /// </summary>
        /// <param name="sLocalIP">[in]PC机的IP地址，如果为NULL，SDK将自动获取PC机的IP地址，如果PC机有多个IP地址，可以指定一个IP地址进行监听。</param>
        /// <param name="wLocalPort">[in]本地监听端口号，由用户设置，</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);
        /// <summary>
        /// 停止监听程序[支持多线程]
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopListen_V30(LONG lListenHandle);
        /// </summary>
        /// <param name="lListenHandle">[in]NET_DVR_StartListen_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen_V30(int lListenHandle);
        /// <summary>
        /// 停止监听程序
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopListen();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();
        #endregion
        #region 建立通道方式获取报警等上传信息(布防方式)
        /// <summary>
        /// 8.1.5       建立报警上传通道
        ///     注意
        ///         只有用这个接口布防才能接收到9000的报警信息，对应告警接收的命令码：COMM_ALARM_V30
        ///     NET_DVR_API LONG __stdcall NET_DVR_SetupAlarmChan_V30(LONG lUserID);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);
        /// <summary>
        /// 建立报警上传通道
        ///     NET_DVR_API LONG __stdcall NET_DVR_SetupAlarmChan(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_CloseAlarmChan等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);
        /// <summary>
        /// 8.1.6   断开报警上传通道
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseAlarmChan_V30(LONG lAlarmHandle);
        /// </summary>
        /// <param name="lAlarmHandle">[in]NET_DVR_SetupAlarmChan_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);
        /// <summary>
        /// 断开报警上传通道
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseAlarmChan(LONG lAlarmHandle);
        /// </summary>
        /// <param name="lAlarmHandle">[in]NET_DVR_SetupAlarmChan的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);
        #endregion
        #endregion
        #region 8.2    报警信息
        /// <summary>
        /// 8.2.1   发生报警的设备信息结构体
        ///     NET_DVR_ALARMER, *LPNET_DVR_ALARMER;
        /// </summary>
        public struct NET_DVR_ALARMER
        {
            /// <summary>
            /// userid是否有效 0-无效，1-有效
            /// </summary>
            public byte byUserIDValid;
            /// <summary>
            /// 序列号是否有效 0-无效，1-有效
            /// </summary>
            public byte bySerialValid;
            /// <summary>
            /// 版本号是否有效 0-无效，1-有效
            /// </summary>
            public byte byVersionValid;
            /// <summary>
            /// 设备名字是否有效 0-无效，1-有效
            /// </summary>
            public byte byDeviceNameValid;
            /// <summary>
            /// MAC地址是否有效 0-无效，1-有效
            /// </summary>
            public byte byMacAddrValid;
            /// <summary>
            /// login端口是否有效 0-无效，1-有效
            /// </summary>
            public byte byLinkPortValid;
            /// <summary>
            /// 设备IP是否有效 0-无效，1-有效
            /// </summary>
            public byte byDeviceIPValid;
            /// <summary>
            /// socket ip是否有效 0-无效，1-有效
            /// </summary>
            public byte bySocketIPValid;
            /// <summary>
            /// NET_DVR_Login()返回值, 布防时有效
            /// </summary>
            public int lUserID;
            /// <summary>
            /// 序列号
            ///     public byte sSerialNumber[SERIALNO_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.SERIALNO_LEN)]
            public byte[] sSerialNumber;
            /// <summary>
            /// 版本信息 高16位表示主版本，低16位表示次版本
            /// </summary>
            public uint dwDeviceVersion;
            /// <summary>
            /// 设备名字
            ///     char sDeviceName[NAME_LEN];
            /// </summary>
            public string sDeviceName;
            /// <summary>
            /// MAC地址
            ///     public byte byMacAddr[MACADDR_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMacAddr;
            /// <summary>
            /// 设备通讯端口
            /// </summary>
            public ushort wLinkPort;
            /// <summary>
            /// IP地址
            ///     char sDeviceIP[128];
            /// </summary>
            public string sDeviceIP;
            /// <summary>
            /// 报警主动上传时的socket IP地址
            ///     char sSocketIP[128];
            /// </summary>
            public string sSocketIP;
            /// <summary>
            /// Ip协议 0-IPV4, 1-IPV6
            /// </summary>
            public byte byIpProtocol;
            /// <summary>
            ///     public byte byRes2[11];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
            public byte[] byRes2;
        }
        /// <summary>
        /// 8.2.1   上传的报警信息(9000扩展)
        ///     注意
        ///         当dwAlarmType为5时，dwDiskNumber[]数组全部为0，则表示当前未接硬盘
        ///     NET_DVR_ALARMINFO_V30, *LPNET_DVR_ALARMINFO_V30;
        /// </summary>
        public struct NET_DVR_ALARMINFO_V30
        {
            /// <summary>
            /// 0－信号量报警
            /// 1－硬盘满
            /// 2－信号丢失
            /// 3－移动侦测
            /// 4－硬盘未格式化
            /// 5－读写硬盘出错
            /// 6－遮挡报警
            /// 7－制式不匹配
            /// 8－非法访问
            /// 0xa-GPS定位信息(车载定制)
            /// </summary>
            public uint dwAlarmType;
            /// <summary>
            /// 报警输入端口
            /// </summary>
            public uint dwAlarmInputNumber;
            /// <summary>
            /// 触发的输出端口，为1表示对应输出
            ///     public byte byAlarmOutputNumber[MAX_ALARMOUT_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT_V30)]
            public byte[] byAlarmOutputNumber;
            /// <summary>
            /// 触发的录像通道，为1表示对应录像, dwAlarmRelateChannel[0]对应第1个通道
            ///     public byte byAlarmRelateChannel[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byAlarmRelateChannel;
            /// <summary>
            /// dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]对应第1个通道
            ///     public byte byChannel[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byChannel;
            /// <summary>
            /// dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]对应第1个硬盘
            ///     public byte byDiskNumber[MAX_DISKNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_DISKNUM_V30)]
            public byte[] byDiskNumber;
        }
        /// <summary>
        /// 上传的报警信息
        ///     注意
        ///         当dwAlarmType为5时，dwDiskNumber[]数组全部为0，则表示当前未接硬盘
        ///     NET_DVR_ALARMINFO, *LPNET_DVR_ALARMINFO;
        /// </summary>
        public struct NET_DVR_ALARMINFO
        {
            /// <summary>
            /// 0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问, 9-串口状态, 0xa-GPS定位信息(车载定制)
            /// </summary>
            public uint dwAlarmType;
            /// <summary>
            /// 报警输入端口, 当报警类型为9时该变量表示串口状态0表示正常， -1表示错误
            /// </summary>
            public uint dwAlarmInputNumber;
            /// <summary>
            /// 触发的输出端口，哪一位为1表示对应哪一个输出
            ///     public uint dwAlarmOutputNumber[MAX_ALARMOUT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT)]
            public uint[] dwAlarmOutputNumber;
            /// <summary>
            /// 触发的录像通道，哪一位为1表示对应哪一路录像, dwAlarmRelateChannel[0]对应第1个通道
            ///     public uint dwAlarmRelateChannel[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public uint[] dwAlarmRelateChannel;
            /// <summary>
            /// dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]位对应第1个通道
            ///     public uint dwChannel[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public uint[] dwChannel;
            /// <summary>
            /// dwDiskNumber[MAX_DISKNUM]
            /// dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]位对应第1个硬盘
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_DISKNUM)]
            public uint[] dwDiskNumber;
        }
        #endregion
        #region 8.3    ATM DVR上传的交易信息
        /// <summary>
        /// 8.3.1   ATM DVR上传的交易信息
        ///     NET_DVR_TRADEINFO, *LPNET_DVR_TRADEINFO;
        /// </summary>
        public struct NET_DVR_TRADEINFO
        {
            /// <summary>
            /// 年
            /// </summary>
            public ushort m_Year;
            /// <summary>
            /// 月
            /// </summary>
            public ushort m_Month;
            /// <summary>
            /// 日
            /// </summary>
            public ushort m_Day;
            /// <summary>
            /// 时
            /// </summary>
            public ushort m_Hour;
            /// <summary>
            /// 分
            /// </summary>
            public ushort m_Minute;
            /// <summary>
            /// 秒
            /// </summary>
            public ushort m_Second;
            /// <summary>
            /// 设备名称
            /// 	public byte DeviceName[24];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] DeviceName;
            /// <summary>
            /// 通道号
            /// </summary>
            public uint dwChannelNumer;
            /// <summary>
            /// 卡号
            /// 	public byte CardNumber[32];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] CardNumber;
            /// <summary>
            /// 交易类型
            ///     char cTradeType[12];
            /// </summary>
            public string cTradeType;
            /// <summary>
            /// 交易金额
            /// </summary>
            public uint dwCash;
        }
        /// <summary>
        /// 8.4.1   IPC接入配置改变报警结构
        ///     NET_DVR_IPALARMINFO, *LPNET_DVR_IPALARMINFO;
        /// </summary>
        public struct NET_DVR_IPALARMINFO
        {
            /// <summary>
            /// IP设备
            ///     NET_DVR_IPDEVINFO  struIPDevInfo[MAX_IP_DEVICE];
            /// </summary>
            public NET_DVR_IPDEVINFO[] struIPDevInfo;
            /// <summary>
            /// 模拟通道是否启用，0-未启用 1-启用
            ///     public byte byAnalogChanEnable[MAX_ANALOG_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ANALOG_CHANNUM)]
            public byte[] byAnalogChanEnable;
            /// <summary>
            /// IP通道
            ///     NET_DVR_IPCHANINFO struIPChanInfo[MAX_IP_CHANNEL];
            /// </summary>
            public NET_DVR_IPCHANINFO[] struIPChanInfo;
            /// <summary>
            /// IP报警输入
            ///     NET_DVR_IPALARMININFO struIPAlarmInInfo[MAX_IP_ALARMIN];
            /// </summary>
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;
            /// <summary>
            /// IP报警输出
            ///     NET_DVR_IPALARMOUTINFO struIPAlarmOutInfo[MAX_IP_ALARMOUT];
            /// </summary>
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;
        }
        #endregion
        #region 8.4    IP摄像机接入配置改变报警结构
        #endregion
        #endregion
        #region 9.     远程面板控制
        #region 9.1    远程面板控制
        /// <summary>
        /// 9.1.1   远程控制面板上的按键
        ///    NET_DVR_API BOOL __stdcall NET_DVR_ClickKey(LONG lUserID, LONG lKeyIndex);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lKeyIndex">
        ///    1－按钮1；       2－按钮2……9－按钮9；10－按钮0，
        ///    11－POWER     12－MENU    13－ENTER    14－"ESC"
        ///    15－"上"或者"云台上开始"      16－"下"或者"云台下开始"
        ///    17－"左"或者"云台左开始"      18－"右"或者"云台右开始"
        ///    19－"EDIT"或者"光圈+开始"   22－"PLAY"
        ///    23－"REC"                             24－"PAN"或者"光圈-开始"
        ///    25－"多画面"或者"聚焦-开始"  26－"输入法"或者"聚焦+开始"
        ///    27－"对讲"    28－"系统信息"     29－"快进"    30－"快退"
        ///    32－"云台上结束"     33－"云台下结束"       34－"云台左结束"
        ///    35－"云台右结束"     36－"光圈+结束"        37－"光圈-结束"
        ///    38－"聚焦+结束"      39－"聚焦-结束"         40－"变倍+开始"
        ///    41－"变倍+结束"       42－"变倍-开始"       43－"变倍-结束"
        ///    44－按钮11              45－按钮12            46－按钮13
        ///    47－按钮14              48－按钮15            49－按钮16
        /// </param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);
        /// <summary>
        /// 9.1.2   禁用设备本地面板控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_LockPanel(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockPanel(int lUserID);
        /// <summary>
        /// 9.1.3   恢复设备本地面板控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_UnLockPanel(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值 </param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnLockPanel(int lUserID);
        #endregion
        #endregion
        #region 10.   云台控制
        #region 10.1          云台控制
        #region 云台控制命令
        /// <summary>
        /// 接通灯光电源
        /// </summary>
        public const int LIGHT_PWRON = 2;
        /// <summary>
        /// 接通雨刷开关
        /// </summary>
        public const int WIPER_PWRON = 3;
        /// <summary>
        /// 接通风扇开关
        /// </summary>
        public const int FAN_PWRON = 4;
        /// <summary>
        /// 接通加热器开关
        /// </summary>
        public const int HEATER_PWRON = 5;
        /// <summary>
        /// 接通辅助设备开关
        /// </summary>
        public const int AUX_PWRON1 = 6;
        /// <summary>
        /// 接通辅助设备开关
        /// </summary>
        public const int AUX_PWRON2 = 7;
        #region 云台预置位命令
        /// <summary>
        /// 设置预置点
        /// </summary>
        public const int SET_PRESET = 8;
        /// <summary>
        /// 清除预置点
        /// </summary>
        public const int CLE_PRESET = 9;
        /// <summary>
        /// 快球转到预置点
        /// </summary>
        public const int GOTO_PRESET = 39;
        #endregion
        /// <summary>
        /// 焦距以速度SS变大(倍率变大) 
        /// </summary>
        public const int ZOOM_IN = 11;
        /// <summary>
        /// 焦距以速度SS变小(倍率变小)
        /// </summary>
        public const int ZOOM_OUT = 12;
        /// <summary>
        /// 焦点以速度SS前调 
        /// </summary>
        public const int FOCUS_NEAR = 13;
        /// <summary>
        /// 焦点以速度SS后调
        /// </summary>
        public const int FOCUS_FAR = 14;
        /// <summary>
        /// 光圈以速度SS扩大
        /// </summary>
        public const int IRIS_OPEN = 15;
        /// <summary>
        /// 光圈以速度SS缩小
        /// </summary>
        public const int IRIS_CLOSE = 16;
        /// <summary>
        /// 云台以SS的速度上仰
        /// </summary>
        public const int TILT_UP = 21;
        /// <summary>
        /// 云台以SS的速度下俯
        /// </summary>
        public const int TILT_DOWN = 22;
        /// <summary>
        /// 云台以SS的速度左转
        /// </summary>
        public const int PAN_LEFT = 23;
        /// <summary>
        /// 云台以SS的速度右转
        /// </summary>
        public const int PAN_RIGHT = 24;
        /// <summary>
        /// 云台以SS的速度上仰和左转
        /// </summary>
        public const int UP_LEFT = 25;
        /// <summary>
        /// 云台以SS的速度上仰和右转
        /// </summary>
        public const int UP_RIGHT = 26;
        /// <summary>
        /// 云台以SS的速度下俯和左转
        /// </summary>
        public const int DOWN_LEFT = 27;
        /// <summary>
        /// 云台以SS的速度下俯和右转
        /// </summary>
        public const int DOWN_RIGHT = 28;
        /// <summary>
        /// 云台以SS的速度左右自动扫描
        /// </summary>
        public const int PAN_AUTO = 29;
        /// <summary>
        /// 10.1.1         当前预览通道的云台控制操作
        ///     注意
        ///         云台的每一个动作都要调用该接口两次，前面两个参数一样，dwStop参数一次取值为0，一次取值为1
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControl(LONG lRealHandle,DWORD dwPTZCommand,DWORD dwStop);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwPTZCommand">[in]云台控制命令 如#define TILT_DOWN</param>
        /// <param name="dwStop">[in]云台停止动作或开始动作：0－开始；1－停止</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl(int lRealHandle, uint dwPTZCommand, uint dwStop);
        /// <summary>
        /// 10.1.2         当前预览通道的云台控制操作_EX 
        ///     性能比NET_DVR_PTZControl好，只能控制V1.4以及以上版本的设备。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControl_EX(LONG lRealHandle,DWORD dwPTZCommand,DWORD dwStop);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZCommand"></param>
        /// <param name="dwStop"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);
        /// <summary>
        /// 10.1.3         云台控制操作，无需预览图像
        ///     注意
        ///         云台的每一个动作都要调用该接口两次，前面三个参数一样，dwStop参数一次取值为0，一次取值为1
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControl_Other(LONG lUserID,LONG lChannel,DWORD dwPTZCommand,DWORD dwStop);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号</param>
        /// <param name="dwPTZCommand">[in]云台控制命令，见上表</param>
        /// <param name="dwStop">[in]云台停止动作或开始动作：0－开始；1－停止。</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop);
        /// <summary>
        /// 10.1.4         当前预览通道的带速度云台控制操作
        ///     注意
        ///         带速度云台控制操作需要设备支持
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControlWithSpeed(LONG lRealHandle, DWORD dwPTZCommand, DWORD dwStop, DWORD dwSpeed);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwPTZCommand">[in]云台控制命令</param>
        /// <param name="dwStop">[in]云台停止动作或者开始动作：0－开始；1－停止。云台的每一个动作都要调用该接口两次，前面两个参数一样，dwStop参数一次为0，一次为1</param>
        /// <param name="dwSpeed">[in]云台控制的速度，用户按不同解码器的速度控制值设置。取值为1～7</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        /// <summary>
        /// 10.1.5         带速度云台控制操作，无需预览图像
        ///     注意
        ///         带速度云台控制操作需要设备支持
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControlWithSpeed_Other(LONG lUserID, LONG lChannel, DWORD dwPTZCommand, DWORD dwStop, DWORD dwSpeed);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号</param>
        /// <param name="dwPTZCommand">in]云台控制命令</param>
        /// <param name="dwStop">[in]是让云台停止动作还是开始动作：0－开始，1－停止，云台的每一个动作都要调用该接口两次，前面两个参数一样，只是dwStop一次为0，一次为1</param>
        /// <param name="dwSpeed">[in]云台控制的速度，用户按不同解码器的速度控制值设置。取值为1～7</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        #endregion
        #region 云台预置位命令
        /// <summary>
        /// 10.1.6         当前预览通道的云台预置位操作
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZPreset(LONG lRealHandle,DWORD dwPTZPresetCmd,DWORD dwPresetIndex);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwPTZPresetCmd">[in]云台预置位命令，见上表</param>
        /// <param name="dwPresetIndex">[in]预置点的序号，最多支持255个预置点（具体数目和球机有关）</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        /// <summary>
        /// 10.1.7         当前预览通道的云台预置位操作_EX
        ///     性能比NET_DVR_PTZPreset好，只能控制V1.4以及以上版本的设备。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZPreset_EX(LONG lRealHandle,DWORD dwPTZPresetCmd,DWORD dwPresetIndex);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZPresetCmd"></param>
        /// <param name="dwPresetIndex"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);
        /// <summary>
        /// 10.1.8         云台预置位操作，无需预览图像
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZPreset_Other(LONG lUserID,LONG lChannel,DWORD dwPTZPresetCmd,DWORD dwPresetIndex);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号</param>
        /// <param name="dwPTZPresetCmd">[in]云台预置位命令，见上表</param>
        /// <param name="dwPresetIndex">[in]预置点的序号,最多支持255个预置点（具体数目和球机有关）</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);
        #endregion
        #region 巡航控制命令
        /// <summary>
        /// 将预置点加入巡航序列
        /// </summary>
        public const int FILL_PRE_SEQ = 30;
        /// <summary>
        /// 设置巡航点停顿时间
        /// </summary>
        public const int SET_SEQ_DWELL = 31;
        /// <summary>
        /// 设置巡航速度
        /// </summary>
        public const int SET_SEQ_SPEED = 32;
        /// <summary>
        /// 将预置点从巡航序列中删除
        /// </summary>
        public const int CLE_PRE_SEQ = 33;
        /// <summary>
        /// 开始巡航
        /// </summary>
        public const int RUN_SEQ = 37;
        /// <summary>
        /// 停止巡航
        /// </summary>
        public const int STOP_SEQ = 38;
        /// <summary>
        /// 10.1.9         当前预览通道的云台巡航控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZCruise(LONG lRealHandle,DWORD dwPTZCruiseCmd,BYTE byCruiseRoute, BYTE byCruisePoint, WORD wInput);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwPTZCruiseCmd">[in]云台巡航控制命令，见上表</param>
        /// <param name="byCruiseRoute">[in]巡航路径,最多支持32条路径</param>
        /// <param name="byCruisePoint">[in]巡航点，最多支持32个点</param>
        /// <param name="wInput">[in]不同巡航命令时的值不同，预置点(最大128)、时间(最大255)、速度(最大15)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        /// <summary>
        /// 10.1.10    当前预览通道的云台巡航控制_EX 
        ///     性能比NET_DVR_ PTZCruise好，只能控制V1.4以及以上版本的设备。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZCruise_EX(LONG lRealHandle,DWORD dwPTZCruiseCmd,BYTE byCruiseRoute, BYTE byCruisePoint, WORD wInput);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZCruiseCmd"></param>
        /// <param name="byCruiseRoute"></param>
        /// <param name="byCruisePoint"></param>
        /// <param name="wInput"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        /// <summary>
        /// 10.1.11    云台巡航控制，无需预览图像
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZCruise_Other(LONG lUserID,LONG lChannel,DWORD dwPTZCruiseCmd,BYTE byCruiseRoute, BYTE byCruisePoint, WORD wInput);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号</param>
        /// <param name="dwPTZCruiseCmd">[in]云台巡航控制命令</param>
        /// <param name="byCruiseRoute">[in]巡航路径,最多支持32条路径</param>
        /// <param name="byCruisePoint">[in]巡航点，最多支持32个点</param>
        /// <param name="wInput">[in]不同巡航命令时的值不同，预置点(最大128)、时间(最大255)、速度(最大15)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);
        #endregion
        #region 云台轨迹命令
        /// <summary>
        /// 开始记录轨迹
        /// </summary>
        public const int STA_MEM_CRUISE = 34;
        /// <summary>
        /// 停止记录轨迹
        /// </summary>
        public const int STO_MEM_CRUISE = 35;
        /// <summary>
        /// 开始轨迹
        /// </summary>
        public const int RUN_CRUISE = 36;
        /// <summary>
        /// 10.1.12    当前预览通道的云台轨迹操作
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZTrack(LONG lRealHandle, DWORD dwPTZTrackCmd);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="dwPTZTrackCmd">[in] 云台轨迹命令 如 #define STA_MEM_CRUISE 34 开始记录轨迹</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);
        /// <summary>
        /// 10.1.13    当前预览通道的云台轨迹操作_EX 
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZTrack_EX(LONG lRealHandle, DWORD dwPTZTrackCmd);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZTrackCmd"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);
        /// <summary>
        /// 10.1.14    云台轨迹操作, 无需预览图像
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZTrack_Other(LONG lUserID, LONG lChannel, DWORD dwPTZTrackCmd);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号</param>
        /// <param name="dwPTZTrackCmd">[in]云台轨迹命令，见上表</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);
        #endregion
        /*
        注意
            以上的云台控制接口都是由设备来确定给云台发送什么云台控制码,而客户端只需要调用相应的宏定义即可,
            设备会根据目前设置的解码器种类和解码器地址向云台发送控制码,如果目前设置的解码器不是需要的,则需要在设备端修改,
            如果用的解码器设备端不支持,则无法用这几个接口来控制.
            而以下NET_DVR_TransPTZ/_Other/_EX()这三个接口则是由客户端向云台发送控制码,不需要设置设备端的解码器,
            设备只是将收到的云台控制码传送给解码器,不做任何处理
         */
        #region 透明云台控制
        /// <summary>
        /// 10.1.15    当前预览通道的透明云台控制操作
        ///     NET_DVR_API BOOL __stdcall NET_DVR_TransPTZ(LONG lRealHandle,char *pPTZCodeBuf,DWORD dwBufSize);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="pPTZCodeBuf">[in]存放云台控制码缓冲区的指针</param>
        /// <param name="dwBufSize">[in]云台控制码的长度</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);
        /// <summary>
        /// 10.1.16    当前预览通道的透明云台控制_EX 
        ///     性能比NET_DVR_TransPTZ好，只能控制V1.4以及以上版本的设备。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_TransPTZ_EX(LONG lRealHandle,char *pPTZCodeBuf,DWORD dwBufSize);
        /// </summary>
        /// <param name="lRealHandle">[in] NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="pPTZCodeBuf">[in]存放云台控制码缓冲区的指针</param>
        /// <param name="dwBufSize">[in]云台控制码的长度</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);
        /// <summary>
        /// 10.1.17    透明云台控制，不需要预览图像
        ///     NET_DVR_API BOOL __stdcall NET_DVR_TransPTZ_Other(LONG lUserID,LONG lChannel,char *pPTZCodeBuf,DWORD dwBufSize);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]硬盘录像机的通道号, 指明是往哪个云台解码器发送数据</param>
        /// <param name="pPTZCodeBuf">[in]存放云台控制码缓冲区的指针</param>
        /// <param name="dwBufSize">[in]云台控制码的长度</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);
        #endregion
        #endregion
        #endregion
        #region 11.   语音对讲和转发
        #region 11.1          语音对讲和转发
        #region 语音对讲
        /// <summary>
        /// 音频数据回调函数/语音数据回调函数
        ///     void(CALLBACK *fVoiceDataCallBack)(LONG lVoiceComHandle, char *pRecvDataBuffer, DWORD dwBufSize, BYTE byAudioFlag, DWORD dwUser)
        ///     注意
        ///         回调参数byAudioFlag=2, pRecvDataBuffer=NULL时，表示语音对讲收发线程退出
        /// </summary>
        /// <param name="lVoiceComHandle">NET_DVR_StartVoiceCom 的返回值</param>
        /// <param name="pRecvDataBuffer">存放数据的缓冲区指针</param>
        /// <param name="dwBufSize">缓冲区的大小,为80的整数倍</param>
        /// <param name="byAudioFlag">数据类型：0－客户端采集的音频数据；1－设备端发送过来的音频数据</param>
        /// <param name="dwUser">输入的用户数据</param>
        public delegate void VoiceDataCallBack(int lVoiceComHandle, IntPtr pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);
        /// <summary>
        /// 实时语音数据回调函数
        ///     void(CALLBACK *fVoiceDataCallBack)(string pRecvDataBuffer, uint dwBufSize, void * pUser)
        /// </summary>
        /// <param name="pRecvDataBuffer">返回的pc端获取到的音频数据</param>
        /// <param name="dwBufSize">pc端获取到的音频数据的大小</param>
        /// <param name="pUser">用户数据</param>
        public delegate void VoiceDataCallBackForAudioStart(IntPtr pRecvDataBuffer, uint dwBufSize, IntPtr pUser);
        /// <summary>
        /// 11.1.1   开始语音对讲
        ///     NET_DVR_API LONG __stdcall NET_DVR_StartVoiceCom_V30(LONG lUserID, DWORD dwVoiceChan, BOOL bNeedCBNoEncData, void(CALLBACK *fVoiceDataCallBack)(LONG lVoiceComHandle, char *pRecvDataBuffer, DWORD dwBufSize, BYTE byAudioFlag, void* pUser), void* pUser);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwVoiceChan">[in]语音通道号（从1开始，9000取值1， 2）</param>
        /// <param name="bNeedCBNoEncData">[in]需要回调的语音数据类型 ：0－G722编码后的语音数据，1－编码前的PCM原始数据</param>
        /// <param name="fVoiceDataCallBack">[in]音频数据回调函数</param>
        /// <param name="pUser">[in]用户数据指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VoiceDataCallBack fVoiceDataCallBack, IntPtr pUser);
        /// <summary>
        /// 开始语音对讲
        ///     NET_DVR_API LONG __stdcall NET_DVR_StartVoiceCom(LONG lUserID, void(CALLBACK *fVoiceDataCallBack)(LONG lVoiceComHandle, char *pRecvDataBuffer, DWORD dwBufSize, BYTE byAudioFlag, DWORD dwUser), DWORD dwUser);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="fVoiceDataCallBack">[in]音频数据回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, VoiceDataCallBack fVoiceDataCallBack, uint dwUser);
        /// <summary>
        /// 11.1.2   设置语音对讲客户端的音量
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetVoiceComClientVolume(LONG lVoiceComHandle, WORD wVolume);
        /// </summary>
        /// <param name="lVoiceComHandle">[in]NET_DVR_StartVoiceCom的返回值</param>
        /// <param name="wVolume">[in]设置音量，取值0～0xffff</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);
        #endregion
        #region 语音转发
        /// <summary>
        /// 11.1.3   开启语音转发，获取编码后的语音数据
        ///     注意
        ///         回调参数byAudioFlag=2, pRecvDataBuffer=NULL时，表示语音对讲收发线程退出
        ///     NET_DVR_API LONG __stdcall NET_DVR_StartVoiceCom_MR_V30(LONG lUserID, DWORD dwVoiceChan, void(CALLBACK *fVoiceDataCallBack)(LONG lVoiceComHandle, char *pRecvDataBuffer, DWORD dwBufSize, BYTE byAudioFlag, void* pUser), void* pUser);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwVoiceChan">[in]语音通道号（从1开始，9000取值1， 2）</param>
        /// <param name="fVoiceDataCallBack">[in]语音数据回调函数</param>
        /// <param name="pUser">[in]用户数据指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VoiceDataCallBack fVoiceDataCallBack, IntPtr pUser);
        /// <summary>
        /// 开启语音转发，获取编码后的语音数据
        ///     NET_DVR_API LONG __stdcall NET_DVR_StartVoiceCom_MR(LONG lUserID, void(CALLBACK *fVoiceDataCallBack)(LONG lVoiceComHandle, char *pRecvDataBuffer, DWORD dwBufSize, BYTE byAudioFlag, DWORD dwUser), DWORD dwUser);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="fVoiceDataCallBack">[in]语音数据回调函数，得到的数据是编码以后的音频数据，需调用我们提供的音频解码函数（详见音频编解码章节的说明）后方可得到PCM数据。</param>
        /// <param name="dwUser">用户数据</param>
        /// <returns>-1表示失败,其他值作为NET_DVR_VoiceComSendData、NET_DVR_StopVoiceCom等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VoiceDataCallBack fVoiceDataCallBack, uint dwUser);
        /// <summary>
        /// 11.1.4   转发语音数据
        ///     将客户端获取的数据转发给某台DVR，发送编码以后的音频数据（详见音频编解码）
        ///     NET_DVR_API BOOL __stdcall NET_DVR_VoiceComSendData(LONG lVoiceComHandle, char *pSendBuf, DWORD dwBufSize);
        /// </summary>
        /// <param name="lVoiceComHandle"></param>
        /// <param name="pSendBuf"></param>
        /// <param name="dwBufSize"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);
        /// <summary>
        /// 11.1.5   停止语音对讲或者语音转发
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopVoiceCom(LONG lVoiceComHandle);
        /// </summary>
        /// <param name="lVoiceComHandle">[in]NET_DVR_StartVoiceCom、NET_DVR_StartVoiceCom_V30、NET_DVR_StartVoiceCom_MR、NET_DVR_StartVoiceCom_MR_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

        ///     注意
        ///         语音转发的音频数据采样格式和音频播放格式必须符合以下标准：采样频率为16000，16位采样，单通道。
        ///         采样标准：
        ///         const int SAMPLES_PER_SECOND = 16000： 
        ///         const int CHANNEL = 1：
        ///         const int BITS_PER_SAMPLE = 16：
        ///         WAVEFORMATEX m_wavFormatEx： 
        ///         m_wavFormatEx.cbSize = sizeof(m_wavFormatEx)： 
        ///         m_wavFormatEx.nBlockAlign = CHANNEL * BITS_PER_SAMPLE / 8： 
        ///         m_wavFormatEx.nChannels = CHANNEL： 
        ///         m_wavFormatEx.nSamplesPerSec = SAMPLES_PER_SECOND： 
        ///         m_wavFormatEx.wBitsPerSample = BITS_PER_SAMPLE： 
        ///         m_wavFormatEx.nAvgBytesPerSec=SAMPLES_PER_SECOND*m_wavFormatEx.nBlockAlign

        #endregion
        #region 语音广播
        //现语音广播功能需先调用NET_DVR_ClientAudioStart，再调用NET_DVR_AddDVR来实现
        /// <summary>
        /// 11.1.6   启动PC端声音捕获
        ///     注意
        ///         本函数与DS9000版本无关，主要是增加回调函数允许用户录音，回调数据为所采集的PCM数据
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientAudioStart_V30(void(CALLBACK *fVoiceDataCallBack)(char *pRecvDataBuffer, DWORD dwBufSize, void * pUser), void *pUser);
        /// </summary>
        /// <param name="fVoiceDataCallBack">[in]实时语音数据回调函数</param>
        /// <param name="pUser">[in]用户数据指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart_V30(VoiceDataCallBackForAudioStart fVoiceDataCallBack, IntPtr pUser);
        /// <summary>
        /// 启动PC端声音捕获
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientAudioStart();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();
        /// <summary>
        /// 11.1.7   停止PC端声音捕获
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientAudioStop();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();
        /// <summary>
        /// 11.1.8   添加DVR的某个语音通道到可以接收PC端声音的组里
        ///     NET_DVR_API LONG __stdcall NET_DVR_AddDVR_V30(LONG lUserID, DWORD dwVoiceChan);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwVoiceChan">[in]语音通道号(从1开始，9000支持1，2两个语音通道)</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);
        /// <summary>
        /// 11.1.9   添加一台DVR到可以接收PC机声音的组里
        ///     NET_DVR_API BOOL __stdcall NET_DVR_AddDVR(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR(int lUserID);
        /// <summary>
        /// 11.1.10   从可接收PC机声音的组里删除某台DVR
        ///     NET_DVR_API BOOL __stdcall NET_DVR_DelDVR_V30(LONG lVoiceHandle);
        /// </summary>
        /// <param name="lVoiceHandle">[in] NET_DVR_AddDVR_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);
        /// <summary>
        /// 从可接收PC机声音的组里删除某台DVR 
        ///     NET_DVR_API BOOL __stdcall NET_DVR_DelDVR(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR(int lUserID);
        #endregion
        #region 音频编解码
        //此章的函数主要为配合语音对讲、转发功能而设定，客户端获取设备端发送过来的压缩码流，可调用音频解码函数进行数据解码，当需将客户端的原始音频数据发送至设备端，可采用音频编码函数将原始数据压缩编码后再发往设备端
        /// <summary>
        /// 11.1.11   初始化音频解码
        ///    NET_DVR_API void* __stdcall NET_DVR_InitG722Decoder(int nBitrate = 16000);
        /// </summary>
        /// <param name="nBitrate">[in]码率nBitrate = 16000</param>
        /// <returns>音频解码句柄</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Decoder(int nBitrate);
        /// <summary>
        /// 11.1.12   音频解码
        ///    NET_DVR_API BOOL __stdcall NET_DVR_DecodeG722Frame(void *pDecHandle, unsigned char* pInBuffer, unsigned char* pOutBuffer);
        /// </summary>
        /// <param name="pDecHandle">[in]音频解码句柄</param>
        /// <param name="pInBuffer">[in]输入缓冲区，编码数据size = 80</param>
        /// <param name="pOutBuffer">[out]输出缓冲区，解码后数据size = 1280</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, sbyte[] pInBuffer, sbyte[] pOutBuffer);
        /// <summary>
        /// 11.1.13   释放音频解码资源
        ///    NET_DVR_API void __stdcall NET_DVR_ReleaseG722Decoder(void *pDecHandle);
        /// </summary>
        /// <param name="pDecHandle">[in]音频解码句柄</param>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);
        /// <summary>
        /// 11.1.14   初始化音频编码
        ///    NET_DVR_API void* __stdcall NET_DVR_InitG722Encoder();
        /// </summary>
        /// <returns>音频编码句柄</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Encoder();
        /// <summary>
        /// 11.1.15   音频编码
        ///    NET_DVR_API BOOL __stdcall NET_DVR_EncodeG722Frame(void *pEncodeHandle,unsigned char* pInBuffer, unsigned char* pOutBuffer);
        /// </summary>
        /// <param name="pEncodeHandle">[in]音频编码句柄</param>
        /// <param name="pInBuffer">[in]输入缓冲区，按采样标准（采样频率为16000，16位采样，单通道）获取的原始音频数据size = 1280</param>
        /// <param name="pOutBuffer">[out]输出缓冲区，编码后的数据size = 80</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, sbyte[] pInBuffer, sbyte[] pOutBuffer);
        /// <summary>
        /// 11.1.16   释放音频编码资源
        ///    NET_DVR_API void __stdcall NET_DVR_ReleaseG722Encoder(void *pEncodeHandle);
        /// </summary>
        /// <param name="pEncodeHandle">[in] 音频编码句柄</param>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);
        #endregion
        #endregion
        #region 11.2语音对讲参数配置
        /// <summary>
        /// 语音对讲参数
        ///     相关函数
        ///         NET_DVR_GetDVRConfig    NET_DVR_SetDVRConfig
        ///     NET_DVR_COMPRESSION_AUDIO, *LPNET_DVR_COMPRESSION_AUDIO;
        /// </summary>
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            /// <summary>
            /// 音频编码类型 0-G722; 1-G711
            /// </summary>
            public byte byAudioEncType;
            /// <summary>
            /// 这里保留音频的压缩参数
            ///     public byte  byres[7];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] byres;
        }
        #endregion
        #endregion
        #region 12.   透明通道
        #region 12.1          透明通道
        /// <summary>
        ///     void(CALLBACK *fSerialDataCallBack)(LONG lSerialHandle,char *pRecvDataBuffer,DWORD dwBufSize,DWORD dwUser)
        /// </summary>
        /// <param name="lSerialHandle">NET_DVR_SerialStart的返回值</param>
        /// <param name="pRecvDataBuffer">存放接收到数据的缓冲区指针</param>
        /// <param name="dwBufSize">缓冲区的大小</param>
        /// <param name="dwUser">输入的用户数据</param>
        public delegate void SerialDataCallBack(int lSerialHandle, IntPtr pRecvDataBuffer, uint dwBufSize, uint dwUser);

        /// <summary>
        /// 12.1.1 建立透明通道
        ///     注意
        ///         需要从回调函数得到数据解码器必须支持数据回传，否则发送成功，回调依然不会有返回。
        ///     NET_DVR_API LONG __stdcall NET_DVR_SerialStart(LONG lUserID,LONG lSerialPort,void(CALLBACK *fSerialDataCallBack)(LONG lSerialHandle,char *pRecvDataBuffer,DWORD dwBufSize,DWORD dwUser),DWORD dwUser);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lSerialPort">[in]串口号：1－232串口；2－485串口</param>
        /// <param name="SerialDataCallBack">[in]回调函数</param>
        /// <param name="dwUser">[in]用户数据</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_SerialSend等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_SerialStart(int lUserID, int lSerialPort, SerialDataCallBack fSerialDataCallBack, uint dwUser);
        //485作为透明通道时，需要指明通道号，因为不同通道号485的设置可以不同(比如波特率)
        /// <summary>
        /// 12.1.2 通过透明通道向DVR串口发送数据
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SerialSend(LONG lSerialHandle, LONG lChannel, char *pSendBuf,DWORD dwBufSize);
        /// </summary>
        /// <param name="lSerialHandle">[in]NET_DVR_SerialStart的返回值</param>
        /// <param name="lChannel">[in] 对232无效, 以232建立透明通道时设置成0， 以485建立透明通道时有效,指明往哪个通道送数据，编号从1开始。</param>
        /// <param name="pSendBuf">[in]要发送的缓冲区的指针</param>
        /// <param name="dwBufSize">[in]缓冲区的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);
        /// <summary>
        /// 12.1.3 断开透明通道
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SerialStop(LONG lSerialHandle);
        /// </summary>
        /// <param name="lSerialHandle">[in]NET_DVR_SerialStart的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);
        /// <summary>
        /// 12.1.4 直接向串口发送数据,不需要建立透明通道
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SendToSerialPort(LONG lUserID, DWORD dwSerialPort, DWORD dwSerialIndex, char *pSendBuf, DWORD dwBufSize);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login或者_V30的返回值</param>
        /// <param name="dwSerialPort">[in]1-232, 2-485</param>
        /// <param name="dwSerialIndex">[in]表示第几个232或者485，从1开始</param>
        /// <param name="pSendBuf">[in]要发送的缓冲区的指针</param>
        /// <param name="dwBufSize">[in]缓冲区的大小，最多1016字节</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);
        /// <summary>
        /// (本方法文档中并未找到，但HCNetSDK.h中有)
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SendTo232Port(LONG lUserID, char *pSendBuf, DWORD dwBufSize);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="pSendBuf"></param>
        /// <param name="dwBufSize"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);
        #endregion
        #endregion
        #region 13.   硬盘管理
        #region 13.1          远程格式化硬盘
        /// <summary>
        /// 13.1.1 远程格式化硬盘
        ///     注意
        ///         格式化过程中如果网络断了,但是设备上的格式化进程依然会继续,只是客户端无法收到状态。
        ///     NET_DVR_API LONG __stdcall NET_DVR_FormatDisk(LONG lUserID,LONG lDiskNumber);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lDiskNumber">[in]硬盘号，从0开始，0xff表示所有硬盘</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_CloseFormatHandle等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);
        /// <summary>
        /// 13.1.2 关闭NET_DVR_FormatDisk接口所创建的句柄，释放资源
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseFormatHandle(LONG lFormatHandle);
        /// </summary>
        /// <param name="lFormatHandle">[in]NET_DVR_ FormatDisk的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);
        /// <summary>
        /// 13.1.3 获取格式化的进度
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetFormatProgress(LONG lFormatHandle, LONG *pCurrentFormatDisk,LONG *pCurrentDiskPos,LONG *pFormatStatic);
        /// </summary>
        /// <param name="lFormatHandle">[in]调用NET_DVR_FormatDisk的返回值</param>
        /// <param name="pCurrentFormatDisk">[out]指向保存当前正在格式化的硬盘号的指针，硬盘号从0开始，-1为初始状态</param>
        /// <param name="pCurrentDiskPos">[out]指向保存当前正在格式化的硬盘的进度的指针，进度是0～100 </param>
        /// <param name="pFormatStatic">[out]指向保存硬盘格式化状态的指针，
        /// 1表示硬盘全部格式化完成，
        /// 0表示正在格式化；
        /// 2表示格式化当前硬盘出错，不能继续格式化此硬盘，本地和网络硬盘都会出现此错误；
        /// 3表示由于网络异常造成网络硬盘丢失而不能开始格式化当前硬盘</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, out int pCurrentFormatDisk, out int pCurrentDiskPos, out int pFormatStatic);

        #endregion
        #endregion
        #region 14.   维护管理
        #region 14.1          获取设备状态
        /// <summary>
        /// 14.1.1 获取硬盘录像机工作状态
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDVRWorkState_V30(LONG lUserID, LPNET_DVR_WORKSTATE_V30 lpWorkState);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpWorkState">[out]指向NET_DVR_WORKSTATE_V30结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, out NET_DVR_WORKSTATE_V30 lpWorkState);
        /// <summary>
        /// 获取硬盘录像机工作状态
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDVRWorkState(LONG lUserID, LPNET_DVR_WORKSTATE lpWorkState);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpWorkState">[out]存放获得工作状态信息</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState(int lUserID, out NET_DVR_WORKSTATE lpWorkState);
        #endregion
        #region 14.2          设备状态信息
        /// <summary>
        /// 14.2.1 硬盘信息结构体
        ///     NET_DVR_DISKSTATE, *LPNET_DVR_DISKSTATE;
        /// </summary>
        public struct NET_DVR_DISKSTATE
        {
            /// <summary>
            /// 硬盘的容量
            /// </summary>
            public uint dwVolume;
            /// <summary>
            /// 硬盘的剩余空间
            /// </summary>
            public uint dwFreeSpace;
            /// <summary>
            /// 硬盘的状态,0-活动,1-休眠,2-不正常
            /// </summary>
            public uint dwHardDiskStatic;
        }
        /// <summary>
        /// 14.2.2 通道信息(9000扩展)
        ///     NET_DVR_CHANNELSTATE_V30, *LPNET_DVR_CHANNELSTATE_V30;
        /// </summary>
        public struct NET_DVR_CHANNELSTATE_V30
        {
            /// <summary>
            /// 通道是否在录像,0-不录像,1-录像
            /// </summary>
            public byte byRecordStatic;
            /// <summary>
            /// 连接的信号状态,0-正常,1-信号丢失
            /// </summary>
            public byte bySignalStatic;
            /// <summary>
            /// 通道硬件状态,0-正常,1-异常,例如DSP死掉
            /// </summary>
            public byte byHardwareStatic;
            /// <summary>
            /// 保留
            /// </summary>
            public byte byRes1;
            /// <summary>
            /// 实际码率
            /// </summary>
            public uint dwBitRate;
            /// <summary>
            /// 客户端连接的个数
            /// </summary>
            public uint dwLinkNum;
            /// <summary>
            /// 客户端的IP地址
            ///     public NET_DVR_IPADDR struClientIP[MAX_LINK];
            /// </summary>
            public NET_DVR_IPADDR[] struClientIP;
            /// <summary>
            /// 如果该通道为IP接入，那么表示IP接入当前的连接数
            /// </summary>
            public uint dwIPLinkNum;
            /// <summary>
            ///     public byte byRes[12];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byRes;
        }
        /// <summary>
        /// 通道信息(通道状态)
        ///     NET_DVR_CHANNELSTATE, *LPNET_DVR_CHANNELSTATE;
        /// </summary>
        public struct NET_DVR_CHANNELSTATE
        {
            /// <summary>
            /// 通道是否在录像,0-不录像,1-录像
            /// </summary>
            public byte byRecordStatic;
            /// <summary>
            /// 连接的信号状态,0-正常,1-信号丢失
            /// </summary>
            public byte bySignalStatic;
            /// <summary>
            /// 通道硬件状态,0-正常,1-异常,例如DSP死掉
            /// </summary>
            public byte byHardwareStatic;
            /// <summary>
            /// 保留
            /// </summary>
            public char reservedData;
            /// <summary>
            /// 实际码率
            /// </summary>
            public uint dwBitRate;
            /// <summary>
            /// 客户端连接的个数
            /// </summary>
            public uint dwLinkNum;
            /// <summary>
            /// 客户端的IP地址
            ///     public uint dwClientIP[MAX_LINK];
            /// </summary>
            public uint dwClientIP;
        }
        /// <summary>
        /// 14.2.3 设备状态信息结构体(DVR工作状态(9000扩展))
        ///     NET_DVR_WORKSTATE_V30, *LPNET_DVR_WORKSTATE_V30;
        /// </summary>
        public struct NET_DVR_WORKSTATE_V30
        {
            /// <summary>
            /// 设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
            /// </summary>
            public uint dwDeviceStatic;
            /// <summary>
            /// 硬盘状态
            ///     NET_DVR_DISKSTATE  struHardDiskStatic[MAX_DISKNUM_V30];
            /// </summary>
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            /// <summary>
            /// 通道状态
            ///     NET_DVR_CHANNELSTATE_V30 struChanStatic[MAX_CHANNUM_V30];
            /// </summary>
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;
            /// <summary>
            /// 报警端口的状态,0-没有报警,1-有报警
            ///     public byte  byAlarmInStatic[MAX_ALARMIN_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMIN_V30)]
            public byte[] byAlarmInStatic;
            /// <summary>
            /// 报警输出端口的状态,0-没有输出,1-有报警输出
            ///     public byte  byAlarmOutStatic[MAX_ALARMOUT_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT_V30)]
            public byte[] byAlarmOutStatic;
            /// <summary>
            /// 本地显示状态,0-正常,1-不正常
            /// </summary>
            public uint dwLocalDisplay;
            /// <summary>
            /// 表示语音通道的状态 0-未使用，1-使用中, 0xff无效
            ///     public byte  byAudioChanStatus[MAX_AUDIO_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMIN)]
            public byte[] byAudioChanStatus;
            /// <summary>
            /// public byte  byRes[10];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] byRes;
        }
        /// <summary>
        /// 设备状态信息结构体(DVR工作状态)
        ///     NET_DVR_WORKSTATE, *LPNET_DVR_WORKSTATE;
        /// </summary>
        public struct NET_DVR_WORKSTATE
        {
            /// <summary>
            /// 设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
            /// </summary>
            public uint dwDeviceStatic;
            /// <summary>
            /// 硬盘状态
            ///     NET_DVR_DISKSTATE  struHardDiskStatic[MAX_DISKNUM];
            /// </summary>
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            /// <summary>
            /// 通道状态
            ///     NET_DVR_CHANNELSTATE struChanStatic[MAX_CHANNUM];
            /// </summary>
            public NET_DVR_CHANNELSTATE[] struChanStatic;
            /// <summary>
            /// 报警端口的状态,0-没有报警,1-有报警
            ///     public byte  byAlarmInStatic[MAX_ALARMIN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMIN)]
            public byte[] byAlarmInStatic;
            /// <summary>
            /// 报警输出端口的状态,0-没有输出,1-有报警输出
            ///     public byte  byAlarmOutStatic[MAX_ALARMOUT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT)]
            public byte[] byAlarmOutStatic;
            /// <summary>
            /// 本地显示状态,0-正常,1-不正常
            /// </summary>
            public uint dwLocalDisplay;
        }
        #endregion
        #region 14.3          远程升级
        /// <summary>
        /// sdk网络环境枚举变量，用于远程升级
        ///     SDK_NETWORK_ENVIRONMENT;
        ///     _SDK_NET_ENV
        /// </summary>
        public enum SDK_NETWORK_ENVIRONMENT
        {
            /// <summary>
            /// 局域网(网络环境好，通讯流畅)
            /// </summary>
            LOCAL_AREA_NETWORK = 0,
            /// <summary>
            /// 广域网(网络环境差，易阻塞)
            /// </summary>
            WIDE_AREA_NETWORK
        }
        /// <summary>
        /// 14.3.1 设置远程升级时网络环境
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetNetworkEnvironment(DWORD dwEnvironmentLevel);
        /// </summary>
        /// <param name="dwEnvironmentLevel">
        ///     [in]enum {LOCAL_AREA_NETWORK = 0, WIDE_AREA_NETWORK}
        ///     环境级别：
        ///         LOCAL_AREA_NETWORK-局域网(网络环境好，通讯流畅)，
        ///         WIDE_AREA_NETWORK-广域网(网络环境差，易阻塞)
        /// </param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);
        /// <summary>
        /// 14.3.2 远程升级
        ///     NET_DVR_API LONG __stdcall NET_DVR_Upgrade(LONG lUserID, char *sFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sFileName">[in]升级文件的文件名, 文件名长度小于等于100个字节</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_GetUpgradeState等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);
        /// <summary>
        /// 14.3.3 关闭NET_DVR_Upgrade接口所创建的句柄，释放资源
        ///     NET_DVR_API BOOL __stdcall NET_DVR_CloseUpgradeHandle(LONG lUpgradeHandle);
        /// </summary>
        /// <param name="lUpgradeHandle">[in]NET_DVR_Upgrade的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);
        /// <summary>
        /// 14.3.4 获取远程升级的进度
        ///     NET_DVR_API int __stdcall NET_DVR_GetUpgradeProgress(LONG lUpgradeHandle);
        /// </summary>
        /// <param name="lUpgradeHandle">[in]NET_DVR_Upgrade的返回值</param>
        /// <returns>升级进度：0～100</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);
        /// <summary>
        /// 14.3.5 获取升级的状态
        ///     NET_DVR_API int __stdcall NET_DVR_GetUpgradeState(LONG lUpgradeHandle);
        ///     -1表示失败，其他值如下定义：
        ///         1－升级成功
        ///         2－正在升级
        ///         3－升级失败
        ///         4－网络断开,状态未知
        ///         5－升级文件语言版本不匹配
        /// </summary>
        /// <param name="lUpgradeHandle">[in]NET_DVR_Upgrade的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);
        #endregion
        #region 14.4          日志查询
        /// <summary>
        /// 14.4.1 查找硬盘录像机日志信息
        ///    注意
        ///        该接口用于搜索普通日志信息支持2000条，而搜索带S.M.A.R.T信息的日志最大只支持500条，通常不需要搜索详细的S.M.A.R.T信息时，置bOnlySmart为FALSE即可完成所有日志信息的搜索。S.M.A.R.T信息：硬盘运行日志记录。
        ///    NET_DVR_API LONG __stdcall NET_DVR_FindDVRLog_V30(LONG lUserID, LONG lSelectMode, DWORD dwMajorType,DWORD dwMinorType, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime, BOOL bOnlySmart = FALSE);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lSelectMode">[in]查询方式：0－全部；1－按类型；2－按时间；3－按时间和类型</param>
        /// <param name="dwMajorType">[in]主类型(S.M.A.R.T搜索时无效)：0－全部；1－报警；2-异常；3－操作</param>
        /// <param name="dwMinorType">[in]次类型(S.M.A.R.T搜索时无效)</param>
        /// <param name="lpStartTime">[in]开始的时间</param>
        /// <param name="lpStopTime">[in]结束的时间</param>
        /// <param name="bOnlySmart">[in]是否只搜索带S.M.A.R.T信息的日志，bOnlySmart为TRUE，只搜索S.M.A.R.T信息的硬盘运行日志记录。</param>
        /// <returns>-1表示失败,其他值作为NET_DVR_FindNextLog_V30等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime, bool bOnlySmart);
        /// <summary>
        /// 查找硬盘录像机日志信息
        ///    注意
        ///        该接口用于搜索普通日志信息支持2000条。
        ///    NET_DVR_API LONG __stdcall NET_DVR_FindDVRLog(LONG lUserID, LONG lSelectMode, DWORD dwMajorType,DWORD dwMinorType, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lSelectMode">[in]查询方式：0－全部，1－按类型，2－按时间，3－按时间和类型</param>
        /// <param name="dwMajorType">[in]主类型  #define MAJOR_ALARM     0x1   报警（主类型）</param>
        /// <param name="dwMinorType">[in]次类型  #define MINOR_ALARM_IN   0x1   报警输入</param>
        /// <param name="lpStartTime">[in]开始的时间，见录像章节结构体定义</param>
        /// <param name="lpStopTime">[in]结束的时间</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_FindNextLog等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime);
        /// <summary>
        /// 14.4.2 获取硬盘录像机日志信息
        ///    NET_DVR_API LONG __stdcall NET_DVR_FindNextLog_V30(LONG lLogHandle, LPNET_DVR_LOG_V30 lpLogData);
        /// </summary>
        /// <param name="lLogHandle">[in]NET_DVR_FindDVRLog_V30的返回值</param>
        /// <param name="lpLogData">[out]指向NET_DVR_LOG_V30结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, out NET_DVR_LOG_V30 lpLogData);
        /// <summary>
        /// 获取硬盘录像机日志信息
        ///    NET_DVR_API LONG __stdcall NET_DVR_FindNextLog(LONG lLogHandle, LPNET_DVR_LOG lpLogData);
        /// </summary>
        /// <param name="lLogHandle">[in]NET_DVR_FindDVRLog的返回值</param>
        /// <param name="lpLogData">[out] 指向NET_DVR_LOG结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog(int lLogHandle, out NET_DVR_LOG lpLogData);
        /// <summary>
        /// 14.4.3 释放查找日志的资源
        ///    NET_DVR_API BOOL __stdcall NET_DVR_FindLogClose_V30(LONG lLogHandle);
        /// </summary>
        /// <param name="lLogHandle">[in]NET_DVR_FindDVRLog_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);
        /// <summary>
        /// 释放查找日志的资源
        ///    NET_DVR_API BOOL __stdcall NET_DVR_FindLogClose(LONG lLogHandle);
        /// </summary>
        /// <param name="lLogHandle">[in]NET_DVR_FindDVRLog的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose(int lLogHandle);
        #endregion
        #region 14.5          日志信息
        #region 14.5.1 日志类型
        #region 报警
        //主类型
        public const int MAJOR_ALARM = 0x1;
        //次类型
        /// <summary>
        /// 报警输入
        /// </summary>
        public const int MINOR_ALARM_IN = 0x1;
        /// <summary>
        /// 报警输出
        /// </summary>
        public const int MINOR_ALARM_OUT = 0x2;
        /// <summary>
        /// 移动侦测报警开始
        /// </summary>
        public const int MINOR_MOTDET_START = 0x3;
        /// <summary>
        /// 移动侦测报警结束
        /// </summary>
        public const int MINOR_MOTDET_STOP = 0x4;
        /// <summary>
        /// 遮挡报警开始
        /// </summary>
        public const int MINOR_HIDE_ALARM_START = 0x5;
        /// <summary>
        /// 遮挡报警结束
        /// </summary>
        public const int MINOR_HIDE_ALARM_STOP = 0x6;
        #endregion
        #region   异常
        //主类型
        public const int MAJOR_EXCEPTION = 0x2;
        //次类型
        /// <summary>
        /// 视频信号丢失
        /// </summary>
        public const int MINOR_VI_LOST = 0x21;
        /// <summary>
        /// 非法访问
        /// </summary>
        public const int MINOR_ILLEGAL_ACCESS = 0x22;
        /// <summary>
        /// 硬盘满
        /// </summary>
        public const int MINOR_HD_FULL = 0x23;
        /// <summary>
        /// 硬盘错误
        /// </summary>
        public const int MINOR_HD_ERROR = 0x24;
        /// <summary>
        /// MODEM 掉线(保留不使用)
        /// </summary>
        public const int MINOR_DCD_LOST = 0x25;
        /// <summary>
        /// IP地址冲突
        /// </summary>
        public const int MINOR_IP_CONFLICT = 0x26;
        /// <summary>
        /// 网络断开
        /// </summary>
        public const int MINOR_NET_BROKEN = 0x27;
        /// <summary>
        /// 录像出错
        /// </summary>
        public const int MINOR_REC_ERROR = 0x28;
        /// <summary>
        /// IPC连接异常
        /// </summary>
        public const int MINOR_IPC_NO_LINK = 0x29;
        /// <summary>
        /// 视频输入异常(只针对模拟通道)
        /// </summary>
        public const int MINOR_VI_EXCEPTION = 0x2a;
        #endregion
        #region 操作
        //主类型
        public const int MAJOR_OPERATION = 0x3;
        //次类型
        /// <summary>
        /// 开机
        /// </summary>
        public const int MINOR_START_DVR = 0x41;
        /// <summary>
        /// 关机
        /// </summary>
        public const int MINOR_STOP_DVR = 0x42;
        /// <summary>
        /// 异常关机
        /// </summary>
        public const int MINOR_STOP_ABNORMAL = 0x43;
        /// <summary>
        /// 本地重启设备
        /// </summary>
        public const int MINOR_REBOOT_DVR = 0x44;
        /// <summary>
        /// 本地登陆
        /// </summary>
        public const int MINOR_LOCAL_LOGIN = 0x50;
        /// <summary>
        /// 本地注销登陆
        /// </summary>
        public const int MINOR_LOCAL_LOGOUT = 0x51;
        /// <summary>
        /// 本地配置参数
        /// </summary>
        public const int MINOR_LOCAL_CFG_PARM = 0x52;
        /// <summary>
        /// 本地按文件回放或下载
        /// </summary>
        public const int MINOR_LOCAL_PLAYBYFILE = 0x53;
        /// <summary>
        /// 本地按时间回放或下载
        /// </summary>
        public const int MINOR_LOCAL_PLAYBYTIME = 0x54;
        /// <summary>
        /// 本地开始录像
        /// </summary>
        public const int MINOR_LOCAL_START_REC = 0x55;
        /// <summary>
        /// 本地停止录像
        /// </summary>
        public const int MINOR_LOCAL_STOP_REC = 0x56;
        /// <summary>
        /// 本地云台控制
        /// </summary>
        public const int MINOR_LOCAL_PTZCTRL = 0x57;
        /// <summary>
        /// 本地预览 (保留不使用)
        /// </summary>
        public const int MINOR_LOCAL_PREVIEW = 0x58;
        /// <summary>
        /// 本地修改时间(保留不使用)
        /// </summary>
        public const int MINOR_LOCAL_MODIFY_TIME = 0x59;
        /// <summary>
        /// 本地升级
        /// </summary>
        public const int MINOR_LOCAL_UPGRADE = 0x5a;
        /// <summary>
        /// 本地备份录象文件
        /// </summary>
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 0x5b;
        /// <summary>
        /// 本地初始化硬盘
        /// </summary>
        public const int MINOR_LOCAL_FORMAT_HDD = 0x5c;
        /// <summary>
        /// 导出本地配置文件
        /// </summary>
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 0x5d;
        /// <summary>
        /// 导入本地配置文件
        /// </summary>
        public const int MINOR_LOCAL_CFGFILE_INPUT = 0x5e;
        /// <summary>
        /// 本地备份文件
        /// </summary>
        public const int MINOR_LOCAL_COPYFILE = 0x5f;
        /// <summary>
        /// 本地锁定录像文件
        /// </summary>
        public const int MINOR_LOCAL_LOCKFILE = 0x60;
        /// <summary>
        /// 本地解锁录像文件
        /// </summary>
        public const int MINOR_LOCAL_UNLOCKFILE = 0x61;
        /// <summary>
        /// 本地手动清除和触发报警
        /// </summary>
        public const int MINOR_LOCAL_DVR_ALARM = 0x62;
        /// <summary>
        /// 本地添加IPC
        /// </summary>
        public const int MINOR_IPC_ADD = 0x63;
        /// <summary>
        /// 本地删除IPC
        /// </summary>
        public const int MINOR_IPC_DEL = 0x64;
        /// <summary>
        /// 本地设置IPC
        /// </summary>
        public const int MINOR_IPC_SET = 0x65;
        /// <summary>
        /// 本地开始备份
        /// </summary>
        public const int MINOR_LOCAL_START_BACKUP = 0x66;
        /// <summary>
        /// 本地停止备份
        /// </summary>
        public const int MINOR_LOCAL_STOP_BACKUP = 0x67;
        /// <summary>
        /// 本地备份开始时间
        /// </summary>
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 0x68;
        /// <summary>
        /// 本地备份结束时间
        /// </summary>
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 0x69;
        /// <summary>
        /// 远程登录
        /// </summary>
        public const int MINOR_REMOTE_LOGIN = 0x70;
        /// <summary>
        /// 远程注销登陆
        /// </summary>
        public const int MINOR_REMOTE_LOGOUT = 0x71;
        /// <summary>
        /// 远程开始录像
        /// </summary>
        public const int MINOR_REMOTE_START_REC = 0x72;
        /// <summary>
        /// 远程停止录像
        /// </summary>
        public const int MINOR_REMOTE_STOP_REC = 0x73;
        /// <summary>
        /// 开始透明传输
        /// </summary>
        public const int MINOR_START_TRANS_CHAN = 0x74;
        /// <summary>
        /// 停止透明传输
        /// </summary>
        public const int MINOR_STOP_TRANS_CHAN = 0x75;
        /// <summary>
        /// 远程获取参数
        /// </summary>
        public const int MINOR_REMOTE_GET_PARM = 0x76;
        /// <summary>
        /// 远程配置参数
        /// </summary>
        public const int MINOR_REMOTE_CFG_PARM = 0x77;
        /// <summary>
        /// 远程获取状态
        /// </summary>
        public const int MINOR_REMOTE_GET_STATUS = 0x78;
        /// <summary>
        /// 远程布防
        /// </summary>
        public const int MINOR_REMOTE_ARM = 0x79;
        /// <summary>
        /// 远程撤防
        /// </summary>
        public const int MINOR_REMOTE_DISARM = 0x7a;
        /// <summary>
        /// 远程重启
        /// </summary>
        public const int MINOR_REMOTE_REBOOT = 0x7b;
        /// <summary>
        /// 开始语音对讲
        /// </summary>
        public const int MINOR_START_VT = 0x7c;
        /// <summary>
        /// 停止语音对讲
        /// </summary>
        public const int MINOR_STOP_VT = 0x7d;
        /// <summary>
        /// 远程升级
        /// </summary>
        public const int MINOR_REMOTE_UPGRADE = 0x7e;
        /// <summary>
        /// 远程按文件回放
        /// </summary>
        public const int MINOR_REMOTE_PLAYBYFILE = 0x7f;
        /// <summary>
        /// 远程按时间回放
        /// </summary>
        public const int MINOR_REMOTE_PLAYBYTIME = 0x80;
        /// <summary>
        /// 远程云台控制
        /// </summary>
        public const int MINOR_REMOTE_PTZCTRL = 0x81;
        /// <summary>
        /// 远程格式化硬盘
        /// </summary>
        public const int MINOR_REMOTE_FORMAT_HDD = 0x82;
        /// <summary>
        /// 远程关机
        /// </summary>
        public const int MINOR_REMOTE_STOP = 0x83;
        /// <summary>
        /// 远程锁定文件
        /// </summary>
        public const int MINOR_REMOTE_LOCKFILE = 0x84;
        /// <summary>
        /// 远程解锁文件
        /// </summary>
        public const int MINOR_REMOTE_UNLOCKFILE = 0x85;
        /// <summary>
        /// 远程导出配置文件
        /// </summary>
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 0x86;
        /// <summary>
        /// 远程导入配置文件
        /// </summary>
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 0x87;
        /// <summary>
        /// 远程导出录象文件
        /// </summary>
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 0x88;
        /// <summary>
        /// 远程手动清除和触发报警
        /// </summary>
        public const int MINOR_REMOTE_DVR_ALARM = 0x89;
        /// <summary>
        /// 远程添加IPC
        /// </summary>
        public const int MINOR_REMOTE_IPC_ADD = 0x8a;
        /// <summary>
        /// 远程删除IPC
        /// </summary>
        public const int MINOR_REMOTE_IPC_DEL = 0x8b;
        /// <summary>
        /// 远程设置IPC
        /// </summary>
        public const int MINOR_REMOTE_IPC_SET = 0x8c;
        #endregion
        #region 日志附加信息
        //主类型
        /// <summary>
        /// 附加信息
        /// </summary>
        public const int MAJOR_INFORMATION = 0x4;
        //次类型
        /// <summary>
        /// 硬盘信息
        /// </summary>
        public const int MINOR_HDD_INFO = 0xa1;
        /// <summary>
        /// SMART信息
        /// </summary>
        public const int MINOR_SMART_INFO = 0xa2;
        /// <summary>
        /// 开始录像
        /// </summary>
        public const int MINOR_REC_START = 0xa3;
        /// <summary>
        /// 停止录像
        /// </summary>
        public const int MINOR_REC_STOP = 0xa4;
        /// <summary>
        /// 过期录像删除
        /// </summary>
        public const int MINOR_REC_OVERDUE = 0xa5;

        //当日志的主类型为MAJOR_OPERATION=03，次类型为MINOR_LOCAL_CFG_PARM=0x52或者MINOR_REMOTE_GET_PARM=0x76
        //或者MINOR_REMOTE_CFG_PARM=0x77时，dwParaType:参数类型有效，其含义如下：
        /// <summary>
        /// 视频输出结构配置
        /// </summary>
        public const int PARA_VIDEOOUT = 0x1;
        /// <summary>
        /// 图像参数结构配置
        /// </summary>
        public const int PARA_IMAGE = 0x2;
        /// <summary>
        /// 压缩参数结构配置
        /// </summary>
        public const int PARA_ENCODE = 0x4;
        /// <summary>
        /// 网络参数结构配置
        /// </summary>
        public const int PARA_NETWORK = 0x8;
        /// <summary>
        /// 报警参数结构配置
        /// </summary>
        public const int PARA_ALARM = 0x10;
        /// <summary>
        /// 异常参数结构配置
        /// </summary>
        public const int PARA_EXCEPTION = 0x20;
        /// <summary>
        /// 解码器参数结构配置
        /// </summary>
        public const int PARA_DECODER = 0x40;
        /// <summary>
        /// RS232参数结构配置
        /// </summary>
        public const int PARA_RS232 = 0x80;
        /// <summary>
        /// 本地预览参数结构配置
        /// </summary>
        public const int PARA_PREVIEW = 0x100;
        /// <summary>
        /// 用户权限参数结构配置
        /// </summary>
        public const int PARA_SECURITY = 0x200;
        /// <summary>
        /// 本地系统配置
        /// </summary>
        public const int PARA_DATETIME = 0x400;
        /// <summary>
        /// 帧信息参数结构配置
        /// </summary>
        public const int PARA_FRAMETYPE = 0x800;
        #endregion
        #endregion
        /// <summary>
        /// 14.5.2 日志信息结构体(日志信息(9000扩展))
        ///     NET_DVR_LOG_V30, *LPNET_DVR_LOG_V30;
        /// </summary>
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            /// <summary>
            /// 主类型 1-报警; 2-异常; 3-操作; 0xff-全部
            /// </summary>
            public uint dwMajorType;
            /// <summary>
            /// 次类型 0-全部;
            /// </summary>
            public uint dwMinorType;
            /// <summary>
            /// 操作面板的用户名
            /// 	public byte	sPanelUser[MAX_NAMELEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_NAMELEN)]
            public byte[] sPanelUser;
            /// <summary>
            /// 网络操作的用户名
            /// 	public byte	sNetUser[MAX_NAMELEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_NAMELEN)]
            public byte[] sNetUser;
            /// <summary>
            /// 远程主机地址
            /// </summary>
            public NET_DVR_IPADDR struRemoteHostAddr;
            /// <summary>
            /// 参数类型
            /// </summary>
            public uint dwParaType;
            /// <summary>
            /// 通道号
            /// </summary>
            public uint dwChannel;
            /// <summary>
            /// 硬盘号
            /// </summary>
            public uint dwDiskNumber;
            /// <summary>
            /// 报警输入端口
            /// </summary>
            public uint dwAlarmInPort;
            /// <summary>
            /// 报警输出端口
            /// </summary>
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            /// <summary>
            ///     char    sInfo[LOG_INFO_LEN];
            /// </summary>
            public string sInfo;
        }
        /// <summary>
        /// 日志信息
        ///     NET_DVR_LOG, *LPNET_DVR_LOG;
        /// </summary>
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            /// <summary>
            /// 主类型 1-报警; 2-异常; 3-操作; 0xff-全部
            /// </summary>
            public uint dwMajorType;
            /// <summary>
            /// 次类型 0-全部;
            /// </summary>
            public uint dwMinorType;
            /// <summary>
            /// 操作面板的用户名
            /// 	public byte	sPanelUser[MAX_NAMELEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_NAMELEN)]
            public byte[] sPanelUser;
            /// <summary>
            /// 网络操作的用户名
            /// 	public byte	sNetUser[MAX_NAMELEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_NAMELEN)]
            public byte[] sNetUser;
            /// <summary>
            /// 远程主机地址
            ///     char	sRemoteHostAddr[16]
            /// </summary>
            public string sRemoteHostAddr;
            /// <summary>
            /// 参数类型
            /// </summary>
            public uint dwParaType;
            /// <summary>
            /// 通道号
            /// </summary>
            public uint dwChannel;
            /// <summary>
            /// 硬盘号
            /// </summary>
            public uint dwDiskNumber;
            /// <summary>
            /// 报警输入端口
            /// </summary>
            public uint dwAlarmInPort;
            /// <summary>
            /// 报警输出端口
            /// </summary>
            public uint dwAlarmOutPort;
        }
        #endregion
        #region 14.6          缺省配置，恢复出厂默认
        /// <summary>
        /// 14.6.1 恢复DVR默认参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_RestoreConfig(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);
        #endregion
        #region 14.7           导入/导出配置文件
        /// <summary>
        /// 14.7.1 获取所有的配置文件
        ///     注意
        ///         可以只单独获取配置文件的长度，即sOutBuffer可以为NULL；DS9016导入参数后将自动重启。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetConfigFile_V30(LONG lUserID, char *sOutBuffer, DWORD dwOutSize, DWORD *pReturnSize);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sOutBuffer">[in]传入的缓冲区大小</param>
        /// <param name="dwOutSize">[out]存放配置参数的缓冲区</param>
        /// <param name="pReturnSize">[out]获得的缓冲区的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, out uint dwOutSize, out uint pReturnSize);
        /// <summary>
        /// 获取所有的配置文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetConfigFile(LONG lUserID, char *sFileName);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sFileName">[in]存放保存配置文件的文件名（二进制文件）</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);
        /// <summary>
        /// 获取所有的配置文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetConfigFile_EX(LONG lUserID, char *sOutBuffer, DWORD dwOutSize);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sOutBuffer">[in]存放配置参数的缓冲区</param>
        /// <param name="dwOutSize">[in]缓冲区大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);
        /// <summary>
        /// 14.7.2 设置所有的配置文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetConfigFile(LONG lUserID, char *sFileName);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sFileName">[in]存放保存配置文件的文件名（二进制文件）</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);
        /// <summary>
        /// 设置所有的配置文件
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetConfigFile_EX(LONG lUserID, char *sInBuffer, DWORD dwInSize);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="sInBuffer">[in]存放配置参数的缓冲区</param>
        /// <param name="dwInSize">[in]缓冲区大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);
        #endregion
        #endregion
        #region 15.   关机或重启
        #region 15.1    关机或重启
        /// <summary>
        /// 15.1.1 重启硬盘录像机
        ///     NET_DVR_API BOOL __stdcall NET_DVR_RebootDVR(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR(int lUserID);
        /// <summary>
        /// 15.1.1 重启硬盘录像机
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ShutDownDVR(LONG lUserID);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);
        #endregion
        #endregion
        #region 16.   解码卡和硬解码
        #region 16.1    解码卡硬解码
        /// <summary>
        /// 16.1.1 初始化解码卡
        ///    NET_DVR_API BOOL __stdcall NET_DVR_InitDevice_Card(long *pDeviceTotalChan);
        /// </summary>
        /// <param name="pDeviceTotalChan">[out]保存解码卡通道个数的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);
        /// <summary>
        /// 16.1.2 释放解码卡资源
        ///    NET_DVR_API BOOL __stdcall NET_DVR_ReleaseDevice_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDevice_Card();
        /// <summary>
        /// 16.1.3 初始化解码卡OVERLAY表面
        ///    NET_DVR_API BOOL __stdcall NET_DVR_InitDDraw_Card(HWND hParent,COLORREF colorKey);
        /// </summary>
        /// <param name="hParent">[in]父窗口句柄</param>
        /// <param name="colorKey">[in]用户设置的透明色</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, int colorKey);
        /// <summary>
        /// 16.1.4 释放解码卡使用的OVERLAY表面
        ///    NET_DVR_API BOOL __stdcall NET_DVR_ReleaseDDraw_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDraw_Card();
        /// <summary>
        /// 16.1.5 使用解码卡预览图像
        ///    NET_DVR_API LONG __stdcall NET_DVR_RealPlay_Card(LONG lUserID,LPNET_DVR_CARDINFO lpCardInfo,long lChannelNum);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpCardInfo">[in]指向NET_DVR_CARDINFO结构</param>
        /// <param name="lChannelNum">[in]使用解码卡的哪个通道来解码,从0开始</param>
        /// <returns>-1表示失败，其他值作为NET_DVR_ResetPara_Card 等函数的参数</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_Card(int lUserID, NET_DVR_CARDINFO lpCardInfo, int lChannelNum);
        /// <summary>
        /// 16.1.6 重置解码卡显示参数
        ///    NET_DVR_API BOOL __stdcall NET_DVR_ResetPara_Card(LONG lRealHandle,LPNET_DVR_DISPLAY_PARA lpDisplayPara);
        /// </summary>
        /// <param name="lRealHandle">[in]播放句柄，NET_DVR_RealPlay_Card的返回值</param>
        /// <param name="lpDisplayPara">[in]指向DISPLAY_PARA结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, NET_DVR_DISPLAY_PARA lpDisplayPara);
        /// <summary>
        /// 16.1.7 刷新解码卡使用的OVERLAY表面
        ///    NET_DVR_API BOOL __stdcall NET_DVR_RefreshSurface_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshSurface_Card();
        /// <summary>
        /// 16.1.8 清除解码卡使用的OVERLAY表面
        ///    NET_DVR_API BOOL __stdcall NET_DVR_ClearSurface_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClearSurface_Card();
        /// <summary>
        /// 16.1.9 恢复解码卡使用的OVERLAY表面
        ///    NET_DVR_API BOOL __stdcall NET_DVR_RestoreSurface_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreSurface_Card();
        /// <summary>
        /// 16.1.10          在PC机上预览板卡解码的声音
        ///    NET_DVR_API BOOL __stdcall NET_DVR_AudioPreview_Card(LONG lRealHandle,BOOL bEnable);
        /// </summary>
        /// <param name="lRealHandle">[in]播放句柄，NET_DVR_RealPlay_Card的返回值</param>
        /// <param name="bEnable">[in]TRUE表示打开声音预览，FALSE表示关闭声音</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, bool bEnable);
        /// <summary>
        /// 16.1.11          输出某一路的模拟音频
        ///    NET_DVR_API BOOL __stdcall NET_DVR_OpenSound_Card(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);
        /// <summary>
        /// 16.1.12          关闭某一路的模拟音频
        ///    NET_DVR_API BOOL __stdcall NET_DVR_CloseSound_Card(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in]播放句柄，NET_DVR_RealPlay_Card的返回值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);
        /// <summary>
        /// 16.1.13          调节某一路的模拟音频的音量
        ///    NET_DVR_API BOOL __stdcall NET_DVR_SetVolume_Card(LONG lRealHandle,WORD wVolume);
        /// </summary>
        /// <param name="lRealHandle">[in]播放句柄，NET_DVR_RealPlay_Card的返回值</param>
        /// <param name="wVolume">[in]设置的音量，取值范围取值范围0-0xffff </param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);
        /// <summary>
        /// 16.1.14          获取解码卡的通道句柄
        ///    NET_DVR_API HANDLE __stdcall NET_DVR_GetChanHandle_Card(LONG lRealHandle);
        /// </summary>
        /// <param name="lRealHandle">[in]播放句柄，NET_DVR_RealPlay_Card的返回值</param>
        /// <returns>0失败，其他为解码卡的句柄，可使用此句柄直接作为解码卡相关函数的操作句柄</returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);
        /// <summary>
        /// 16.1.15          获取解码卡序列号
        ///    NET_DVR_API BOOL __stdcall NET_DVR_GetSerialNum_Card(long lChannelNum,DWORD *pDeviceSerialNo);
        /// </summary>
        /// <param name="lChannelNum">[in]解码卡通道号</param>
        /// <param name="pDeviceSerialNo">[out]保存解码卡序列号的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);
        /// <summary>
        /// 16.1.16          设置解码卡DSP死掉后向主机发送的消息
        ///     注意
        ///         我们可以通过 #define WM_MYCOMMAND WM_USER+1 定义一个用户自定义的消息，
        ///         这个消息对应的消息处理函数为void OnMyCommand(WPARAM wParam, LPARAM lParam)，wParam返回解码卡的通道号，
        ///         它们之间的映射关系由ON_MESSAGE(WM_MYCOMMAND,OnMyCommand)来实现，此时，我们可以这样调用该函数，
        ///         NET_DVR_SetDspErrMsg_Card (WM_MYCOMMAND,hWnd)。 
        ///     BOOL NET_DVR_SetDspErrMsg_Card (UINT  nMessage,HWND  hWnd) 
        /// </summary>
        /// <param name="nMessage">[in]DSP死掉向主机发送的消息</param>
        /// <param name="hWnd">[in]发送消息的窗口</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDspErrMsg_Card(uint nMessage, IntPtr hWnd);
        /// <summary>
        /// 16.1.17          重置解码卡DSP
        ///     当用户收到DSP死掉的消息后,可以调用这个接口来重置DSP
        ///     BOOL NET_DVR_ResetDSP_Card (long  lChannelNum) 
        /// </summary>
        /// <param name="lChannelNum">[in]解码卡通道号</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetDSP_Card(int lChannelNum);
        /// <summary>
        /// 16.1.18          硬解码抓图
        ///    NET_DVR_API BOOL __stdcall NET_DVR_CapturePicture_Card(LONG lRealHandle, char *sPicFileName);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay_Card的返回值</param>
        /// <param name="sPicFileName">[in]图片文件保存为的文件名</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);
        /// <summary>
        /// API文档没有，HCNetSDK.h头文件中有
        ///    NET_DVR_API LONG __stdcall NET_DVR_GetCardLastError_Card();
        /// </summary>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetCardLastError_Card();
        #endregion
        #region 16.2          硬解码结构体
        /// <summary>
        /// 硬解码预览参数
        ///     NET_DVR_CARDINFO, *LPNET_DVR_CARDINFO;
        /// </summary>
        public struct NET_DVR_CARDINFO
        {
            /// <summary>
            /// 通道号
            /// </summary>
            public int lChannel;
            /// <summary>
            /// 最高位(31)为0表示主码流，为1表示子，0－30位表示码流连接方式:0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-电话线，5－128k宽带，6－256k宽带，7－384k宽带，8－512k宽带；
            /// </summary>
            public int lLinkMode;
            /// <summary>
            /// 多播组地址，取值为D类IP地址，即224.0.0.0到239.255.255.255之间，采用多播方式需要所在网络（交换机）支持。
            ///     char* sMultiCastIP;
            /// </summary>
            public string sMultiCastIP;
            /// <summary>
            /// 硬解码显示参数
            /// </summary>
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }
        /// <summary>
        /// 硬解码显示区域参数(子结构)
        ///     NET_DVR_DISPLAY_PARA, *LPNET_DVR_DISPLAY_PARA;
        /// </summary>
        public struct NET_DVR_DISPLAY_PARA
        {
            /// <summary>
            /// 是否输出到PC显示器屏幕上：1－是；0－否
            /// </summary>
            public int bToScreen;
            /// <summary>
            /// 是否输出到监视器上：1－是；0－否
            /// </summary>
            public int bToVideoOut;
            /// <summary>
            /// lToScreen取值为1时，输出位置的左上点的横坐标，相对与父窗口而言
            /// </summary>
            public int nLeft;
            /// <summary>
            /// lToScreen取值为1时，输出位置的左上点的纵坐标，相对与父窗口而言
            /// </summary>
            public int nTop;
            /// <summary>
            /// ToScreen取值为1时，输出图象的宽度
            /// </summary>
            public int nWidth;
            /// <summary>
            /// lToScreen取值为1时，输出图象的高度
            /// </summary>
            public int nHeight;
            /// <summary>
            /// 保留
            /// </summary>
            public int nReserved;
        }
        #endregion
        #endregion
        #region 17.   解码器
        #region 17.1              多路解码器
        /// <summary>
        /// 17.1.1 启动动态连接测试
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixStartDynamic(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpDynamicInfo">[in]指向NET_MATRIX_DYNAMIC_DEC结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);
        /// <summary>
        /// 17.1.2 停止动态连接测试
        ///     注意
        ///         配置多路解码器某一解码通道连接前端dvr设备的某一通道，持续进行解码，直到调用停止动态解码接口或者关闭解码通道解码开关。
        ///         解码过程中若因出现网络中断等原因造成解码中断的情况，多路解码器将自动向前端dvr发起重连，直到连接成功或者停止解码接口被调用，其间该解码通道处于黑屏状态。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixStopDynamic(LONG lUserID, DWORD dwDecChanNum); 
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);
        /// <summary>
        /// 17.1.3 设置轮循解码通道参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetLoopDecChanInfo(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_LOOP_DECINFO lpInter);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpInter">[in]指向NET_MATRIX_LOOP_DECINFO结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, NET_DVR_MATRIX_LOOP_DECINFO lpInter);
        /// <summary>
        /// 17.1.4 获取轮循解码通道参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetLoopDecChanInfo(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_LOOP_DECINFO lpInter);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpInter">[out]指向NET_MATRIX_LOOP_DECINFO结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, out NET_DVR_MATRIX_LOOP_DECINFO lpInter);
        /// <summary>
        /// 17.1.5 设置解码通道轮循开关
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetLoopDecChanEnable(LONG lUserID, DWORD dwDecChanNum, DWORD dwEnable);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="dwEnable">[in]0表示关闭 1表示打开</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);
        /// <summary>
        /// 17.1.6 获取解码通道轮循开关值
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetLoopDecChanEnable(LONG lUserID, DWORD dwDecChanNum, LPDWORD lpdwEnable);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpdwEnable">[out]0表示关闭 1表示打开</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, out uint lpdwEnable);
        /// <summary>
        /// 17.1.7 获取所有解码通道轮循开关值
        ///     注意
        ///         轮循开关用于控制轮循过程的启停，而不是控制解码的启停，当设置解码器当前正在轮循的解码通道的轮循开关为关时，
        ///         该解码通道停止循环，停留在当前所连接的前端dvr通道继续解码，退为动态解码，当设置轮循开关为开时，解码器恢复该解码通道的循环。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetLoopDecEnable(LONG lUserID, LPDWORD lpdwEnable);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpdwEnable">[out]按位表示，0表示关闭 1表示打开</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, out uint lpdwEnable);
        /// <summary>
        /// 17.1.8 获取当前解码通道信息
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetDecChanInfo(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_DEC_CHAN_INFO lpInter);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpInter">[out]指向NET_DVR_MATRIX_DEC_CHAN_INFO结构的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, out NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);
        /// <summary>
        /// 17.1.9 获取当前解码通道状态
        ///     注意
        ///         获取解码器某一解码通道的当前状态包括解码通道状态和解码通道信息两部分，解码通道状态用于获取当前解码通道的连接状态，码流拷贝率等，解码通道信息用于获取当前解码通道的解码状态以及所连接的前端dvr通道相关信息。
        ///     提示
        ///         这一部分的内容主要是查询多路解码器各解码通道的连接和解码状态，建议只作为参考信息使用，不建议作为解码器设备工作状态的判定依据，也不建议过于频繁的获取解码通道状态。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetDecChanStatus(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpInter">[out]指向NET_DVR_MATRIX_DEC_CHAN_STATUS结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, out NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);
        /// <summary>
        /// 17.1.10 设置解码通道开关
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetDecChanEnable(LONG lUserID, DWORD dwDecChanNum, DWORD dwEnable);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="dwEnable">[in]0表示关闭 1表示打开</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);
        /// <summary>
        /// 17.1.11 获取解码通道开关值
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetDecChanEnable(LONG lUserID, DWORD dwDecChanNum, LPDWORD lpdwEnable);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpdwEnable">[out]指向DWORD的指针，取出的值0表示关闭，1表示打开</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, out uint lpdwEnable);
        /// <summary>
        /// 17.1.12          设置透明通道信息
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetTranInfo(LONG lUserID, LPNET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpTranInfo">[in]指向NET_DVR_MATRIX_TRAN_CHAN_CONFIG结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        /// <summary>
        /// 17.1.13          获取透明通道信息
        ///     注意
        ///         此处透明通道配置是配置解码器与前端设备之间建立网络透明通道，而不是客户端与解码器之间建立透明通道，多路解码器本身不支持与客户端建立232透明通道和485透明通道，多路解码器本地串口只能作为串口控制台接入（通过RS232）或是控制键盘等输入性设备接入（通过RS232/RS485）。
        ///     提示
        ///         目前多路解码器支持最多建立64条透明通道，包括232透明通道和485透明通道，但其中只有最多一条232全双工透明通道和最多一条485全双工透明通道，可以不设置全双工透明通道。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetTranInfo(LONG lUserID, LPNET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpTranInfo">[out]指向NET_DVR_MATRIX_TRAN_CHAN_CONFIG结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);
        /// <summary>
        /// 17.1.14          设置解码设备远程回放文件配置
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetRemotePlay(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpInter">[in]指向结构NET_DVR_MATRIX_DEC_REMOTE_PLAY</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);
        /// <summary>
        /// 17.1.15          远程回放文件控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixSetRemotePlayControl(LONG lUserID, DWORD dwDecChanNum, DWORD dwControlCode, DWORD dwInValue, DWORD *LPOutValue);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="dwControlCode">[in]控制码，见控制码列表</param>
        /// <param name="dwInValue">[in]设置的参数</param>
        /// <param name="LPOutValue">[out]返回的值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, out uint LPOutValue);
        /// <summary>
        /// 17.1.16          获取回放状态
        ///     注意
        ///         多路解码器远程连接前端设备完成按文件名/时间回放文件，并能够获取相应回放状态，进行回放控制等。按时间回放不支持进度控制；
        ///         由于回放控制命令是转发实现，存在一定的延迟，因此，回放控制命令不宜过于频繁调用，具体视网络状况而定，
        ///         当把获取的状态作为客户端处理依据时应考虑网络转发的延迟因素；按时间回放时，获取回放状态所得到的文件信息是当前播放的单个片段的信息，
        ///         并非整个时间范围内全部片段的信息，判断播放是否结束使用NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS结构中的dwCurDataType成员。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_MatrixGetRemotePlayStatus(LONG lUserID, DWORD dwDecChanNum, LPNET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwDecChanNum">[in]解码通道</param>
        /// <param name="lpOuter">[out]返回的回放状态</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);
        #endregion
        #region 17.2              多路解码器结构体
        /// <summary>
        /// 17.2.1 动态链接参数
        ///     NET_DVR_MATRIX_DYNAMIC_DEC, *LPNET_DVR_MATRIX_DYNAMIC_DEC;
        /// </summary>
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 动态解码通道信息
            /// </summary>
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;
        }
        /// <summary>
        /// 17.2.2 解码通道参数（子结构）
        ///     NET_DVR_MATRIX_DECINFO, *LPNET_DVR_MATRIX_DECINFO;
        /// </summary>
        public struct NET_DVR_MATRIX_DECINFO
        {
            /// <summary>
            /// DVR IP地址
            ///     char 	sDVRIP[16];
            /// </summary>
            public string sDVRIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 通道号
            /// </summary>
            public byte byChannel;
            /// <summary>
            /// 传输协议类型 0-TCP, 1-UDP
            /// </summary>
            public byte byTransProtocol;
            /// <summary>
            /// 传输码流模式 0－主码流 1－子码流
            /// </summary>
            public byte byTransMode;
            /// <summary>
            ///     public byte	byRes[3];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes;
            /// <summary>
            /// 监控主机登陆帐号
            ///     public byte	sUserName[NAME_LEN];
            /// </summary>
            public string sUserName;
            /// <summary>
            /// 监控主机密码
            ///     public byte	sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
        }
        /// <summary>
        /// 17.2.3 轮循解码通道的配置
        ///     2007-11-05 新增每个解码通道的配置
        ///     NET_DVR_MATRIX_LOOP_DECINFO, *LPNET_DVR_MATRIX_LOOP_DECINFO;
        /// </summary>
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            /// <summary>
            /// 轮巡时间
            /// </summary>
            public uint dwPoolTime;
            /// <summary>
            ///     NET_DVR_MATRIX_DECCHANINFO struchanConInfo[MAX_CYCLE_CHAN];
            /// </summary>
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }
        /// <summary>
        /// 17.2.4 连接的通道配置（子结构）  [HCNetSDK.h没有!]
        ///     NET_DVR_MATRIX_CHAN_INFO,*LPNET_DVR_MATRIX_CHAN_INFO;
        /// </summary>
        public struct NET_DVR_MATRIX_CHAN_INFO
        {
            /// <summary>
            /// 是否启用：0－否；1－启用
            /// </summary>
            public int dwEnable;
            /// <summary>
            /// 轮循解码通道信息，详见NET_DVR_MATRIX_DECINFO
            ///     NET_DVR_MATRIX_DECINFO  struDecChanInfo;
            /// </summary>
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;
        }
        /// <summary>
        /// 17.2.5 多路解码器解码通道信息
        ///     NET_DVR_MATRIX_DEC_CHAN_INFO, *LPNET_DVR_MATRIX_DEC_CHAN_INFO;
        /// </summary>
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            /// <summary>
            /// 解码通道信息
            /// </summary>
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;
            /// <summary>
            /// 0-动态解码 1－循环解码 2－按时间回放 3－按文件回放
            /// </summary>
            public uint dwDecState;
            /// <summary>
            /// 按时间回放开始时间
            /// </summary>
            public NET_DVR_TIME StartTime;
            /// <summary>
            /// 按时间回放停止时间
            /// </summary>
            public NET_DVR_TIME StopTime;
            /// <summary>
            /// 按文件回放文件名
            ///     char    sFileName[128];
            /// </summary>
            public string sFileName;
        }
        /// <summary>
        /// 17.2.6 多路解码器解码通道状态
        ///     NET_DVR_MATRIX_DEC_CHAN_STATUS, *LPNET_DVR_MATRIX_DEC_CHAN_STATUS;
        ///     
        /// </summary>
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            /// <summary>
            /// 解码通道状态 0－休眠 1－正在连接 2－已连接 3-正在解码
            /// </summary>
            public uint dwIsLinked;
            /// <summary>
            /// Stream copy rate, X kbits/second
            /// </summary>
            public uint dwStreamCpRate;
            /// <summary>
            /// 保留
            ///     char    cRes[64];
            /// </summary>
            public string cRes;
        }
        /// <summary>
        /// 17.2.7 透明通道配置结构体
        ///     NET_DVR_MATRIX_TRAN_CHAN_CONFIG, *LPNET_DVR_MATRIX_TRAN_CHAN_CONFIG;
        /// </summary>
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 设置哪路232透明通道是全双工的 取值1到MAX_SERIAL_NUM
            /// </summary>
            public byte by232IsDualChan;
            /// <summary>
            /// 设置哪路485透明通道是全双工的 取值1到MAX_SERIAL_NUM
            /// </summary>
            public byte by485IsDualChan;
            /// <summary>
            /// 保留
            ///     public byte	res[2];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] res;
            /// <summary>
            /// 同时支持建立MAX_SERIAL_NUM个透明通道
            ///     NET_DVR_MATRIX_TRAN_CHAN_INFO struTranInfo[MAX_SERIAL_NUM];
            /// </summary>
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;
        }
        /// <summary>
        /// 17.2.8 透明通道参数结构体（子结构）
        ///     NET_DVR_MATRIX_TRAN_CHAN_INFO, *LPNET_DVR_MATRIX_TRAN_CHAN_INFO;
        /// </summary>
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            /// <summary>
            /// 当前透明通道是否打开：0－关闭；1－打开多路解码器本地有1个485串口、1个232串口都可以作为透明通道,设备号分配如下：0－RS485；1－RS232 Console
            /// </summary>
            public byte byTranChanEnable;	/*  */
            /// <summary>
            /// Local serial device远程串口输出还是两个,一个RS232，一个RS485， 1表示232串口；2表示485串口
            /// </summary>
            public byte byLocalSerialDevice;			/* Local serial device */
            /// <summary>
            /// Remote output serial device 
            /// </summary>
            public byte byRemoteSerialDevice;
            /// <summary>
            /// 保留
            /// </summary>
            public byte res1;
            /// <summary>
            /// Remote Device IP
            ///     char	sRemoteDevIP[16];
            /// </summary>
            public string sRemoteDevIP;
            /// <summary>
            /// Remote Net Communication Port
            /// </summary>
            public ushort wRemoteDevPort;
            /// <summary>
            /// 保留
            ///     public byte	res2[2];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] res2;
            /// <summary>
            /// 
            /// </summary>
            public TTY_CONFIG RemoteSerialDevCfg;
        }
        /// <summary>
        /// 17.2.9 串口参数配置（子结构）
        ///     TTY_CONFIG, *LPTTY_CONFIG;
        /// </summary>
        public struct TTY_CONFIG
        {
            /// <summary>
            /// 波特率
            /// </summary>
            public byte baudrate;
            /// <summary>
            /// 数据位
            /// </summary>
            public byte databits;
            /// <summary>
            /// 停止位
            /// </summary>
            public byte stopbits;
            /// <summary>
            /// 奇偶校验位
            /// </summary>
            public byte parity;
            /// <summary>
            /// 流控
            /// </summary>
            public byte flowcontrol;
            /// <summary>
            ///     public byte	res[3];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] res;
        }
        /// <summary>
        /// 17.2.10          远程文件回放
        ///     NET_DVR_MATRIX_DEC_REMOTE_PLAY, *LPNET_DVR_MATRIX_DEC_REMOTE_PLAY;
        /// </summary>
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            /// <summary>
            /// DVR IP地址
            ///     char	sDVRIP[16];
            /// </summary>
            public string sDVRIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 通道号
            /// </summary>
            public byte byChannel;
            /// <summary>
            /// 保留参数
            /// </summary>
            public byte byReserve;
            /// <summary>
            /// 用户名
            ///     public byte	sUserName[NAME_LEN];
            /// </summary>
            public string sUserName;
            /// <summary>
            /// 密码
            ///     public byte	sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
            /// <summary>
            /// 0－按文件 1－按时间
            /// </summary>
            public uint dwPlayMode;
            /// <summary>
            /// 
            /// </summary>
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            /// <summary>
            /// 文件名
            ///     char sFileName[128];
            /// </summary>
            public string sFileName;
        }
        /// <summary>
        /// 17.2.11          远程文件播放控制
        ///     NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL, *LPNET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL;
        /// </summary>
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            /// <summary>
            /// 播放命令 见文件播放命令
            /// </summary>
            public uint dwPlayCmd;
            /// <summary>
            /// 播放命令参数
            /// </summary>
            public uint dwCmdParam;
        }
        /// <summary>
        /// 17.2.12          远程文件播放状态
        ///     NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS, *LPNET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS;
        /// </summary>
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            /// <summary>
            /// 当前播放的媒体文件长度
            /// </summary>
            public uint dwCurMediaFileLen;
            /// <summary>
            /// 当前播放文件的播放位置
            /// </summary>
            public uint dwCurMediaFilePosition;
            /// <summary>
            /// 当前播放文件的总时间
            /// </summary>
            public uint dwCurMediaFileDuration;
            /// <summary>
            /// 当前已经播放的时间
            /// </summary>
            public uint dwCurPlayTime;
            /// <summary>
            /// 当前播放文件的总帧数
            /// </summary>
            public uint dwCurMediaFIleFrames;
            /// <summary>
            /// 当前传输的数据类型，19-文件头，20-流数据， 21-播放结束标志
            /// </summary>
            public uint dwCurDataType;
            /// <summary>
            ///     public byte res[72];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 72)]
            public byte[] res;
        }
        #endregion
        #region 17.3          单路解码器
        /// <summary>
        /// 17.3.1 配置解码设备参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDecInfo(LONG lUserID, LONG lChannel, LPNET_DVR_DECCFG lpDecoderinfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpDecoderinfo">[in]指向NET_DVR_DECCFG结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, NET_DVR_DECCFG lpDecoderinfo);
        /// <summary>
        /// 17.3.2 获取解码设备参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDecInfo(LONG lUserID, LONG lChannel, LPNET_DVR_DECCFG lpDecoderinfo);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpDecoderinfo">[out]指向NET_DVR_DECCFG结构的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, out NET_DVR_DECCFG lpDecoderinfo);
        /// <summary>
        /// 17.3.3 设置解码设备透明通道参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDecTransPort(LONG lUserID, LPNET_DVR_PORTCFG lpTransPort);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpTransPort">[in]指向NET_DVR_PORTCFG结构的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecTransPort(int lUserID, NET_DVR_PORTCFG lpTransPort);
        /// <summary>
        /// 17.3.4 获取解码设备透明通道参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDecTransPort(LONG lUserID, LPNET_DVR_PORTCFG lpTransPort);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpTransPort">[out]指向NET_DVR_PORTCFG结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecTransPort(int lUserID, out NET_DVR_PORTCFG lpTransPort);
        /// <summary>
        /// 17.3.5 解码设备远程回放文件控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_DecPlayBackCtrl(LONG lUserID, LONG lChannel, DWORD dwControlCode, DWORD dwInValue,DWORD *LPOutValue, LPNET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="dwControlCode">[in]控制码，见下表  #define NET_DVR_PLAYSTART   1   开始播放</param>
        /// <param name="dwInValue">[in]设置的参数</param>
        /// <param name="LPOutValue">[out]返回的值</param>
        /// <param name="lpRemoteFileInfo">[in]指向NET_DVR_PLAYREMOTEFILE结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, out uint LPOutValue, NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);
        /// <summary>
        /// 17.3.6 启动解码设备动态控制解码连接
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StartDecSpecialCon(LONG lUserID, LONG lChannel, LPNET_DVR_DECCHANINFO lpDecChanInfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpDecChanInfo">[in]指向NET_DVR_DECCHANINFO结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, NET_DVR_DECCHANINFO lpDecChanInfo);
        /// <summary>
        /// 17.3.7 停止解码设备动态控制解码连接
        ///     NET_DVR_API BOOL __stdcall NET_DVR_StopDecSpecialCon(LONG lUserID, LONG lChannel, LPNET_DVR_DECCHANINFO lpDecChanInfo);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号，0xffffffff表示所有的解码通道</param>
        /// <param name="lpDecChanInfo">[in]指向NET_DVR_DECCHANINFO结构的指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, NET_DVR_DECCHANINFO lpDecChanInfo);
        /// <summary>
        /// 17.3.8 解码设备运行状态控制
        ///     NET_DVR_API BOOL __stdcall NET_DVR_DecCtrlDec(LONG lUserID, LONG lChannel, DWORD dwControlCode);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号 0xffffffff表示所有的通道</param>
        /// <param name="dwControlCode">[in]控制状态1－启动解码；2－停止解码；3－停止当前轮循；4－继续轮循</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);
        /// <summary>
        /// 17.3.9 解码设备解码窗口放大还原
        ///     NET_DVR_API BOOL __stdcall NET_DVR_DecCtrlScreen(LONG lUserID, LONG lChannel, DWORD dwControl);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="dwControl">[in]全屏还是还原 1－全屏；2－还原</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);
        /// <summary>
        /// 17.3.10          获取解码设备当前连接状态
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDecCurLinkStatus(LONG lUserID, LONG lChannel, LPNET_DVR_DECSTATUS lpDecStatus);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="lpDecStatus">[out]指向NET_DVR_DECSTATUS结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, out NET_DVR_DECSTATUS lpDecStatus);
        #endregion
        #region 17.4          单路解码器结构体
        /// <summary>
        /// 17.4.1 整个解码设备的配置结构体
        ///     NET_DVR_DECCFG, *LPNET_DVR_DECCFG;
        /// </summary>
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            /// <summary>
            /// 解码通道的数量
            /// </summary>
            public uint dwDecChanNum;
            /// <summary>
            /// 解码通道信息
            ///     NET_DVR_DECINFO struDecInfo[MAX_DECNUM];
            /// </summary>
            public NET_DVR_DECINFO[] struDecInfo;
        }
        /// <summary>
        /// 17.4.2 每个解码通道的配置结构体（子结构）
        ///     NET_DVR_DECINFO, *LPNET_DVR_DECINFO;
        /// </summary>
        public struct NET_DVR_DECINFO
        {
            /// <summary>
            /// 每路解码通道上的循环通道数量, 最多4通道 0表示没有解码
            /// </summary>
            public byte byPoolChans;
            /// <summary>
            /// 解码通道参数
            ///     NET_DVR_DECCHANINFO struchanConInfo[MAX_DECPOOLNUM];
            /// </summary>
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            /// <summary>
            /// 是否轮巡 0-否 1-是
            /// </summary>
            public byte byEnablePoll;
            /// <summary>
            /// 轮巡时间 0-保留 1-10秒 2-15秒 3-20秒 4-30秒 5-45秒 6-1分钟 7-2分钟 8-5分钟
            /// </summary>
            public byte byPoolTime;
        }
        /// <summary>
        /// 17.4.3 解码通道参数结构体（子结构）
        ///     NET_DVR_DECCHANINFO, *LPNET_DVR_DECCHANINFO;
        /// </summary>
        public struct NET_DVR_DECCHANINFO
        {
            /// <summary>
            /// DVR IP地址
            ///     char sDVRIP[16];
            /// </summary>
            public string sDVRIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 用户名
            /// 	public byte sUserName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sUserName;
            /// <summary>
            /// 密码
            /// 	public byte sPassword[PASSWD_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
            public byte[] sPassword;
            /// <summary>
            /// 通道号
            /// </summary>
            public byte byChannel;
            /// <summary>
            /// 连接模式
            /// </summary>
            public byte byLinkMode;
            /// <summary>
            /// 连接类型 0－主码流 1－子码流
            /// </summary>
            public byte byLinkType;
        }
        /// <summary>
        /// 17.4.4 解码设备透明通道串口配置结构体
        ///     NET_DVR_PORTCFG, *LPNET_DVR_PORTCFG;
        /// </summary>
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            /// <summary>
            /// 数组0表示232 数组1表示485
            ///     NET_DVR_PORTINFO struTransPortInfo[MAX_TRANSPARENTNUM];
            /// </summary>
            public NET_DVR_PORTINFO[] struTransPortInfo;
        }
        /// <summary>
        /// 17.4.5 解码设备透明通道串口参数结构体（子结构）
        ///     NET_DVR_PORTINFO, *LPNET_DVR_PORTINFO;
        /// </summary>
        public struct NET_DVR_PORTINFO
        {
            /// <summary>
            /// 是否启动透明通道 0－不启用 1－启用
            /// </summary>
            public uint dwEnableTransPort;
            /// <summary>
            /// DVR IP地址
            ///     char sDecoderIP[16];
            /// </summary>
            public string sDecoderIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDecoderPort;
            /// <summary>
            /// 配置前端DVR是从485/232输出，1表示232串口,2表示485串口
            /// </summary>
            public ushort wDVRTransPort;
            /// <summary>
            ///     char cReserve[4];
            /// </summary>
            public string cReserve;
        }
        /// <summary>
        /// 17.4.6 单路解码器控制网络文件按时间回放(控制网络文件回放)
        ///     注意：本结构体并未翻译完
        ///     可参考文章：http://www.cnblogs.com/allenlooplee/archive/2004/12/25/81917.html
        ///     NET_DVR_PLAYREMOTEFILE, *LPNET_DVR_PLAYREMOTEFILE;
        /// </summary>
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            /// <summary>
            /// DVR IP地址
            ///     char sDecoderIP[16];
            /// </summary>
            public string sDecoderIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDecoderPort;
            /// <summary>
            /// 回放下载模式 1－按名字 2－按时间
            /// </summary>
            public ushort wLoadMode;

            [StructLayout(LayoutKind.Explicit)]
            public struct mode_size
            {
                /// <summary>
                /// 回放的文件名
                /// 	public byte byFile[100];
                /// </summary>
                [FieldOffset(0)]
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
                public byte[] byFile;
                [FieldOffset(0)]
                public ByTime bytime;
                public struct ByTime
                {
                    public uint dwChannel;
                    /// <summary>
                    /// 请求视频用户名
                    /// 	public byte sUserName[NAME_LEN];
                    /// </summary>
                    [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
                    public byte[] sUserName;
                    /// <summary>
                    /// 密码
                    /// 	public byte sPassword[PASSWD_LEN];
                    /// </summary>
                    [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
                    public byte[] sPassword;
                    /// <summary>
                    /// 按时间回放的开始时间
                    /// </summary>
                    public NET_DVR_TIME struStartTime;
                    /// <summary>
                    /// 按时间回放的结束时间
                    /// </summary>
                    public NET_DVR_TIME struStopTime;
                }
            }
            //union
            //{
            //	public byte byFile[100];		/* 回放的文件名 */
            //    struct
            //    {
            //        uint dwChannel;
            //    	public byte sUserName[NAME_LEN];	/*请求视频用户名*/
            //    	public byte sPassword[PASSWD_LEN];	/* 密码 */
            //        NET_DVR_TIME struStartTime;	/* 按时间回放的开始时间 */
            //        NET_DVR_TIME struStopTime;	/* 按时间回放的结束时间 */
            //    }bytime;
            //}mode_size;
        }
        /// <summary>
        /// 17.4.7 当前设备解码连接状态(当前设备解码连接状态)
        ///     NET_DVR_DECSTATUS, *LPNET_DVR_DECSTATUS;
        /// </summary>
        public struct NET_DVR_DECSTATUS
        {
            public uint dwSize;
            /// <summary>
            /// NET_DVR_DECCHANSTATUS struDecState[MAX_DECNUM];
            /// </summary>
            public NET_DVR_DECCHANSTATUS[] struDecState;
        }
        /// <summary>
        /// 17.4.8 解码通道状态结构体（子结构）(当前设备解码连接状态)
        ///     NET_DVR_DECCHANSTATUS, *LPNET_DVR_DECCHANSTATUS;
        /// </summary>
        public struct NET_DVR_DECCHANSTATUS
        {
            /// <summary>
            /// 工作方式：1：轮巡、2：动态连接解码、3：文件回放下载 4：按时间回放下载
            /// </summary>
            public uint dwWorkType;
            /// <summary>
            /// 连接的设备ip
            ///     char sDVRIP[16];
            /// </summary>
            public string sDVRIP;
            /// <summary>
            /// 连接端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 通道号
            /// </summary>
            public byte byChannel;
            /// <summary>
            /// 连接模式
            /// </summary>
            public byte byLinkMode;
            /// <summary>
            /// 连接类型 0－主码流 1－子码流
            /// </summary>
            public uint dwLinkType;
            /*union
            {
                struct
                {
                   public byte sUserName[NAME_LEN];	//请求视频用户名
                   public byte sPassword[PASSWD_LEN];	// 密码
                    char cReserve[52];
                }userInfo;
                struct
                {
                   public byte   fileName[100];
                }fileInfo;
                struct
                {
                   public uint dwChannel;
                   public byte sUserName[NAME_LEN];	//请求视频用户名
                   public byte sPassword[PASSWD_LEN];	// 密码
                    NET_DVR_TIME struStartTime;		// 按时间回放的开始时间
                    NET_DVR_TIME struStopTime;		// 按时间回放的结束时间
                }timeInfo;
            }objectInfo;*/
        }
        #endregion
        #endregion
        #region 远程参数配置
        #region 通用参数配置命令
        #region 远程参数配置与获取
        /// <summary>
        /// 获取硬盘录像机的参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetDVRConfig(LONG lUserID, DWORD dwCommand,LONG lChannel, LPVOID lpOutBuffer, DWORD dwOutBufferSize, LPDWORD lpBytesReturned);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwCommand">[in]参数类型，见下表宏定义</param>
        /// <param name="lChannel">[in]通道号，如果不是通道参数，lChannel不用,置为-1即可</param>
        /// <param name="lpOutBuffer">[out]存放输出参数的缓冲区</param>
        /// <param name="dwOutBufferSize">[out]缓冲区的大小</param>
        /// <param name="lpBytesReturned">[out]实际返回的缓冲区大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, byte[] lpOutBuffer, out uint dwOutBufferSize, out uint lpBytesReturned);
        /// <summary>
        /// 设置硬盘录像机的参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetDVRConfig(LONG lUserID, DWORD dwCommand,LONG lChannel, LPVOID lpInBuffer, DWORD dwInBufferSize);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwCommand">[in]参数类型,详见下表</param>
        /// <param name="lChannel">[in]通道号，如果不是通道参数，lChannel不用,置为0即可</param>
        /// <param name="lpInBuffer">[in]存放输入参数的缓冲区</param>
        /// <param name="dwInBufferSize">[in]缓冲区的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, byte[] lpInBuffer, uint dwInBufferSize);

        //注：以获取设备的参数和设置设备的参数为例，代码如下：
        ////获取设备的参数
        //NET_DVR_DEVICECFG devicecfg;
        //DWORD BytesReturned;
        //NET_DVR_GetDVRConfig(lUserID, NET_DVR_GET_DEVICECFG, 0, &devicecfg, sizeof(NET_DVR_DEVICECFG), &BytesReturned)
        ////设置设备的参数
        //NET_DVR_DEVICECFG devicecfg;
        //NET_DVR_SetDVRConfig(lUserID, NET_DVR_SET_DEVICECFG, 0, &devicecfg, sizeof(NET_DVR_DEVICECFG))

        #region dwCommand的类型定义
        #region 设备参数配置
        //NET_DVR_DEVICECFG结构
        /// <summary>
        /// 获取设备参数
        /// </summary>
        public const int NET_DVR_GET_DEVICECFG = 100;
        /// <summary>
        /// 设置设备参数
        /// </summary>
        public const int NET_DVR_SET_DEVICECFG = 101;
        /// <summary>
        /// 获取DVR时间
        /// </summary>
        public const int NET_DVR_GET_TIMECFG = 118;
        /// <summary>
        /// 设置DVR时间
        /// </summary>
        public const int NET_DVR_SET_TIMECFG = 119;
        #endregion
        #region 网络参数配置
        //NET_DVR_NETCFG结构
        /// <summary>
        /// 获取网络参数
        /// </summary>
        public const int NET_DVR_GET_NETCFG = 102;
        /// <summary>
        /// 设置网络参数
        /// </summary>
        public const int NET_DVR_SET_NETCFG = 103;
        //NET_DVR_NETCFG_OTHER结构
        /// <summary>
        /// 获取网络参数
        /// </summary>
        public const int NET_DVR_GET_NETCFG_OTHER = 244;
        /// <summary>
        /// 设置网络参数
        /// </summary>
        public const int NET_DVR_SET_NETCFG_OTHER = 245;
        //NET_DVR_NETCFG_V30结构
        /// <summary>
        /// 获取网络参数
        /// </summary>
        public const int NET_DVR_GET_NETCFG_V30 = 1000;
        /// <summary>
        /// 设置网络参数
        /// </summary>
        public const int NET_DVR_SET_NETCFG_V30 = 1001;
        #endregion
        #region 图像参数配置
        //NET_DVR_PICCFG结构
        /// <summary>
        /// 获取图象参数
        /// </summary>
        public const int NET_DVR_GET_PICCFG = 104;
        /// <summary>
        /// 设置图象参数
        /// </summary>
        public const int NET_DVR_SET_PICCFG = 105;
        //NET_DVR_PICCFG_EX结构
        /// <summary>
        /// 获取图象参数(SDK_V14扩展命令)
        /// </summary>
        public const int NET_DVR_GET_PICCFG_EX = 200;
        /// <summary>
        /// 设置图象参数(SDK_V14扩展命令)
        /// </summary>
        public const int NET_DVR_SET_PICCFG_EX = 201;
        //NET_DVR_PICCFG_V30结构
        /// <summary>
        /// 获取图象参数
        /// </summary>
        public const int NET_DVR_GET_PICCFG_V30 = 1002;
        /// <summary>
        /// 设置图象参数
        /// </summary>
        public const int NET_DVR_SET_PICCFG_V30 = 1003;
        #endregion
        #region 压缩参数配置
        //NET_DVR_COMPRESSIONCFG结构
        /// <summary>
        /// 获取压缩参数
        /// </summary>
        public const int NET_DVR_GET_COMPRESSCFG = 106;
        /// <summary>
        /// 设置压缩参数
        /// </summary>
        public const int NET_DVR_SET_COMPRESSCFG = 107;
        /// <summary>
        /// 获取事件触发录像参数
        /// </summary>
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;
        /// <summary>
        /// 设置事件触发录像参数
        /// </summary>
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;
        //NET_DVR_COMPRESSIONCFG_EX结构
        /// <summary>
        /// 获取压缩参数(SDK_V15扩展命令2006-05-15)
        /// </summary>
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;
        /// <summary>
        /// 设置压缩参数(SDK_V15扩展命令2006-05-15)
        /// </summary>
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;
        //NET_DVR_COMPRESSIONCFG_V30结构
        /// <summary>
        /// 获取压缩参数
        /// </summary>
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        /// <summary>
        /// 设置压缩参数
        /// </summary>
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;
        #endregion
        #region 录像参数配置
        //NET_DVR_RECORD结构
        /// <summary>
        /// 获取录像时间参数
        /// </summary>
        public const int NET_DVR_GET_RECORDCFG = 108;
        /// <summary>
        /// 设置录像时间参数
        /// </summary>
        public const int NET_DVR_SET_RECORDCFG = 109;
        //NET_DVR_RECORD_V30结构
        /// <summary>
        /// 获取录像参数
        /// </summary>
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;
        /// <summary>
        /// 设置录像参数
        /// </summary>
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;
        #endregion
        #region (云台)解码器参数配置
        //NET_DVR_DECODERCFG结构
        /// <summary>
        /// 获取解码器参数
        /// </summary>
        public const int NET_DVR_GET_DECODERCFG = 110;
        /// <summary>
        /// 设置解码器参数
        /// </summary>
        public const int NET_DVR_SET_DECODERCFG = 111;
        //NET_DVR_DECODERCFG_V30结构
        /// <summary>
        /// 获取解码器参数
        /// </summary>
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;
        /// <summary>
        /// 设置解码器参数
        /// </summary>
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;
        #endregion
        #region 232串口参数配置
        //NET_DVR_RS232CFG结构
        /// <summary>
        /// 获取232串口参数
        /// </summary>
        public const int NET_DVR_GET_RS232CFG = 112;
        /// <summary>
        /// 设置232串口参数
        /// </summary>
        public const int NET_DVR_SET_RS232CFG = 113;
        //NET_DVR_RS232CFG_V30结构
        /// <summary>
        /// 获取232串口参数
        /// </summary>
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        /// <summary>
        /// 设置232串口参数
        /// </summary>
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;
        #endregion
        #region 报警输入参数配置
        //NET_DVR_ALARMINCFG结构
        /// <summary>
        /// 获取报警输入参数
        /// </summary>
        public const int NET_DVR_GET_ALARMINCFG = 114;
        /// <summary>
        /// 设置报警输入参数
        /// </summary>
        public const int NET_DVR_SET_ALARMINCFG = 115;
        //NET_DVR_ALARMINCFG_V30结构
        /// <summary>
        /// 获取报警输入参数
        /// </summary>
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        /// <summary>
        /// 设置报警输入参数
        /// </summary>
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;
        #endregion
        #region 报警输出参数配置
        //NET_DVR_ALARMOUTCFG结构
        /// <summary>
        /// 获取报警输出参数
        /// </summary>
        public const int NET_DVR_GET_ALARMOUTCFG = 116;
        /// <summary>
        /// 设置报警输出参数
        /// </summary>
        public const int NET_DVR_SET_ALARMOUTCFG = 117;
        //NET_DVR_ALARMOUTCFG_V30结构
        /// <summary>
        /// 获取报警输出参数
        /// </summary>
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        /// <summary>
        /// 设置报警输出参数
        /// </summary>
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;
        #endregion
        #region 本地预览参数配置
        //NET_DVR_PREVIEWCFG结构
        /// <summary>
        /// 获取本地预览参数
        /// </summary>
        public const int NET_DVR_GET_PREVIEWCFG = 120;
        /// <summary>
        /// 设置本地预览参数
        /// </summary>
        public const int NET_DVR_SET_PREVIEWCFG = 121;
        /// <summary>
        /// 获取-s系列双输出预览参数(-s系列双输出2006-04-13)
        /// </summary>
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;
        /// <summary>
        /// 设置-s系列双输出预览参数(-s系列双输出2006-04-13)
        /// </summary>
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;
        //NET_DVR_PREVIEWCFG_V30结构
        /// <summary>
        /// 获取预览参数
        /// </summary>
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;
        /// <summary>
        /// 设置预览参数
        /// </summary>
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;
        /// <summary>
        /// 获取辅助预览参数
        /// </summary>
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;
        /// <summary>
        /// 设置辅助预览参数
        /// </summary>
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;
        #endregion
        #region 视频输出参数配置
        //NET_DVR_VIDEOOUT结构
        /// <summary>
        /// 获取视频输出参数
        /// </summary>
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;
        /// <summary>
        /// 设置视频输出参数
        /// </summary>
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;
        //NET_DVR_VIDEOOUT_V30结构
        /// <summary>
        /// 获取视频输出参数
        /// </summary>
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        /// <summary>
        /// 设置视频输出参数
        /// </summary>
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;
        #endregion
        #region 用户参数配置
        //NET_DVR_USER结构
        /// <summary>
        /// 获取用户参数
        /// </summary>
        public const int NET_DVR_GET_USERCFG = 124;
        /// <summary>
        /// 设置用户参数
        /// </summary>
        public const int NET_DVR_SET_USERCFG = 125;
        //NET_DVR_USER_EX结构
        /// <summary>
        /// 获取用户参数(SDK_V15扩展命令)
        /// </summary>
        public const int NET_DVR_GET_USERCFG_EX = 202;
        /// <summary>
        /// 设置用户参数(SDK_V15扩展命令)
        /// </summary>
        public const int NET_DVR_SET_USERCFG_EX = 203;
        //NET_DVR_USER_V30结构
        /// <summary>
        /// 获取用户参数
        /// </summary>
        public const int NET_DVR_GET_USERCFG_V30 = 1006;
        /// <summary>
        /// 设置用户参数
        /// </summary>
        public const int NET_DVR_SET_USERCFG_V30 = 1007;
        #endregion
        #region 异常参数配置
        //NET_DVR_EXCEPTION结构
        /// <summary>
        /// 获取异常参数
        /// </summary>
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;
        /// <summary>
        /// 设置异常参数
        /// </summary>
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;
        //NET_DVR_EXCEPTION_V30结构
        /// <summary>
        /// 获取异常参数
        /// </summary>
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        /// <summary>
        /// 设置异常参数
        /// </summary>
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        #endregion
        #region 时区和夏时制参数配置
        //NET_DVR_ZONEANDDST 结构
        /// <summary>
        /// 获取时区和夏时制参数
        /// </summary>
        public const int NET_DVR_GET_ZONEANDDST = 128;
        /// <summary>
        /// 设置时区和夏时制参数
        /// </summary>
        public const int NET_DVR_SET_ZONEANDDST = 129;
        #endregion
        #region 叠加字符结构参数
        //NET_DVR_SHOWSTRING结构
        /// <summary>
        /// 获取叠加字符参数
        /// </summary>
        public const int NET_DVR_GET_SHOWSTRING = 130;
        /// <summary>
        /// 设置叠加字符参数
        /// </summary>
        public const int NET_DVR_SET_SHOWSTRING = 131;
        //NET_DVR_SHOWSTRING_EX结构
        /// <summary>
        /// 获取叠加字符参数扩展(支持8条字符)
        /// </summary>
        public const int NET_DVR_GET_SHOWSTRING_EX = 238;
        /// <summary>
        /// 设置叠加字符参数扩展(支持8条字符)
        /// </summary>
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;
        //NET_DVR_SHOWSTRING_V30结构
        /// <summary>
        /// 获取叠加字符参数
        /// </summary>
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        /// <summary>
        /// 设置叠加字符参数
        /// </summary>
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;
        #endregion
        #region 报警触发辅助输出配置
        //NET_DVR_AUXOUTCFG结构
        /// <summary>
        /// 获取报警触发辅助输出设置(HS设备辅助输出2006-02-28)
        /// </summary>
        public const int NET_DVR_GET_AUXOUTCFG = 140;
        /// <summary>
        /// 设置报警触发辅助输出设置(HS设备辅助输出2006-02-28)
        /// </summary>
        public const int NET_DVR_SET_AUXOUTCFG = 141;
        //NET_DVR_AUXOUTCFG_V30结构
        /// <summary>
        /// 获取报警触发辅助输出设置
        /// </summary>
        public const int NET_DVR_GET_AUXOUTCFG_V30 = 1032;
        /// <summary>
        /// 设置报警触发辅助输出设置
        /// </summary>
        public const int NET_DVR_SET_AUXOUTCFG_V30 = 1033;
        #endregion
        #region 网络应用参数配置
        //NET_DVR_NETAPPCFG结构
        /// <summary>
        /// 获取网络应用参数 NTP/DDNS/EMAIL
        /// </summary>
        public const int NET_DVR_GET_NETAPPCFG = 222;
        /// <summary>
        /// 设置网络应用参数 NTP/DDNS/EMAIL
        /// </summary>
        public const int NET_DVR_SET_NETAPPCFG = 223;
        #endregion
        #region NTP配置
        //NET_DVR_NTPPARA结构
        /// <summary>
        /// 获取网络应用参数 NTP
        /// </summary>
        public const int NET_DVR_GET_NTPCFG = 224;
        /// <summary>
        /// 设置网络应用参数 NTP
        /// </summary>
        public const int NET_DVR_SET_NTPCFG = 225;
        #endregion
        #region DDNS配置
        //NET_DVR_DDNSPARA结构
        /// <summary>
        /// 获取网络应用参数 DDNS
        /// </summary>
        public const int NET_DVR_GET_DDNSCFG = 226;
        /// <summary>
        /// 设置网络应用参数 DDNS
        /// </summary>
        public const int NET_DVR_SET_DDNSCFG = 227;
        //NET_DVR_DDNSPARA_EX结构
        /// <summary>
        /// 获取扩展DDNS参数
        /// </summary>
        public const int NET_DVR_GET_DDNSCFG_EX = 274;
        /// <summary>
        /// 设置扩展DDNS参数
        /// </summary>
        public const int NET_DVR_SET_DDNSCFG_EX = 275;
        //NET_DVR_DDNSPARA_V30结构
        /// <summary>
        /// 获取DDNS(9000扩展)
        /// </summary>
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;
        /// <summary>
        /// 设置DDNS(9000扩展)
        /// </summary>
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;
        #endregion
        #region EMAIL配置
        //NET_DVR_EMAILCFG结构
        /// <summary>
        /// 获取EMAIL配置
        /// </summary>
        public const int NET_DVR_GET_EMAILPARACFG = 250;
        /// <summary>
        /// 设置EMAIL配置
        /// </summary>
        public const int NET_DVR_SET_EMAILPARACFG = 251;
        //NET_DVR_EMAILCFG_V30结构
        /// <summary>
        /// 获取EMAIL参数 
        /// </summary>
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;
        /// <summary>
        /// 设置EMAIL参数 
        /// </summary>
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;
        #endregion
        #region NFS（网络文件系统）配置
        //NET_DVR_NFSCFG结构
        /// <summary>
        /// 获取NFS 配置
        /// </summary>
        public const int NET_DVR_GET_NFSCFG = 230;
        /// <summary>
        /// 设置NFS 配置
        /// </summary>
        public const int NET_DVR_SET_NFSCFG = 231;
        #endregion
        #region IPC相关配置
        //IP接入配置参数NET_DVR_IPPARACFG结构
        /// <summary>
        /// 获取IP接入配置信息 
        /// </summary>
        public const int NET_DVR_GET_IPPARACFG = 1048;
        /// <summary>
        /// 设置IP接入配置信息
        /// </summary>
        public const int NET_DVR_SET_IPPARACFG = 1049;
        //IP 报警输入接入配置参数NET_DVR_IPALARMINCFG结构
        /// <summary>
        /// 获取IP报警输入接入配置信息 
        /// </summary>
        public const int NET_DVR_GET_IPALARMINCFG = 1050;
        /// <summary>
        /// 设置IP报警输入接入配置信息
        /// </summary>
        public const int NET_DVR_SET_IPALARMINCFG = 1051;
        //IP 报警输出接入配置参数NET_DVR_IPALARMOUTCFG结构
        /// <summary>
        /// 获取IP报警输出接入配置信息 
        /// </summary>
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;
        /// <summary>
        /// 设置IP报警输出接入配置信息
        /// </summary>
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;
        #endregion
        #region 硬盘管理的参数配置
        //NET_DVR_HDCFG结构
        /// <summary>
        /// 获取硬盘管理配置参数
        /// </summary>
        public const int NET_DVR_GET_HDCFG = 1054;
        /// <summary>
        /// 设置硬盘管理配置参数
        /// </summary>
        public const int NET_DVR_SET_HDCFG = 1055;
        #endregion
        #region 盘组管理参数配置
        //NET_DVR_HDGROUP_CFG结构
        /// <summary>
        /// 获取盘组配置参数
        /// </summary>
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;
        /// <summary>
        /// 设置盘组管理配置参数
        /// </summary>
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;
        #endregion
        #region IP快球参数配置
        //位置参数NET_DVR_PTZPOS结构
        /// <summary>
        /// 云台设置PTZ位置
        /// </summary>
        public const int NET_DVR_SET_PTZPOS = 292;
        /// <summary>
        /// 云台获取PTZ位置
        /// </summary>
        public const int NET_DVR_GET_PTZPOS = 293;
        //范围参数NET_DVR_PTZSCOPE结构
        /// <summary>
        /// 云台获取PTZ范围
        /// </summary>
        public const int NET_DVR_GET_PTZSCOPE = 294;
        #endregion
        #region 巡航参数
        //NET_DVR_CRUISE_PARA结构
        //巡航参数 (NET_DVR_CRUISE_PARA结构)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;
        #endregion
        #endregion
        #endregion
        #region 参数配置结构体定义
        #region 设备参数配置
        #region 设备类型定义(DVR类型)
        /// <summary>
        /// 对尚未定义的dvr类型返回NETRET_DVR
        /// </summary>
        public const int DVR = 1;
        /// <summary>
        /// atm dvr
        /// </summary>
        public const int ATMDVR = 2;
        /// <summary>
        /// DVS
        /// </summary>
        public const int DVS = 3;
        /// <summary>
        /// 6001D
        /// </summary>
        public const int DEC = 4;
        /// <summary>
        /// 6001F
        /// </summary>
        public const int ENC_DEC = 5;
        /// <summary>
        /// 8000HC
        /// </summary>
        public const int DVR_HC = 6;
        /// <summary>
        /// 8000HT
        /// </summary>
        public const int DVR_HT = 7;
        /// <summary>
        /// 8000HF
        /// </summary>
        public const int DVR_HF = 8;
        /// <summary>
        /// 8000HS DVR(no audio) 
        /// </summary>
        public const int DVR_HS = 9;
        /// <summary>
        /// 8016HTS DVR(no audio)
        /// </summary>
        public const int DVR_HTS = 10;
        /// <summary>
        /// HB DVR(SATA HD)
        /// </summary>
        public const int DVR_HB = 11;
        /// <summary>
        /// 8000HCS DVR
        /// </summary>
        public const int DVR_HCS = 12;
        /// <summary>
        /// 带ATA硬盘的DVS
        /// </summary>
        public const int DVS_A = 13;
        /// <summary>
        /// 8000HC-S
        /// </summary>
        public const int DVR_HC_S = 14;
        /// <summary>
        /// 8000HT-S
        /// </summary>
        public const int DVR_HT_S = 15;
        /// <summary>
        /// 8000HF-S
        /// </summary>
        public const int DVR_HF_S = 16;
        /// <summary>
        /// 8000HS-S
        /// </summary>
        public const int DVR_HS_S = 17;
        /// <summary>
        /// ATM-S
        /// </summary>
        public const int ATMDVR_S = 18;
        /// <summary>
        /// 7000H系列
        /// </summary>
        public const int LOWCOST_DVR = 19;
        /// <summary>
        /// 多路解码器
        /// </summary>
        public const int DEC_MAT = 20;
        /// <summary>
        /// mobile DVR
        /// </summary>
        public const int DVR_MOBILE = 21;
        /// <summary>
        /// 8000HD-S
        /// </summary>
        public const int DVR_HD_S = 22;
        /// <summary>
        /// 8000HD-SL
        /// </summary>
        public const int DVR_HD_SL = 23;
        /// <summary>
        /// 8000HC-SL
        /// </summary>
        public const int DVR_HC_SL = 24;
        /// <summary>
        /// 8000HS_ST
        /// </summary>
        public const int DVR_HS_ST = 25;
        /// <summary>
        /// 6000HW
        /// </summary>
        public const int DVS_HW = 26;
        /// <summary>
        /// IP 摄像机
        /// </summary>
        public const int IPCAM = 30;
        /// <summary>
        /// X52MF系列,752MF,852MF
        /// </summary>
        public const int MEGA_IPCAM = 31;
        /// <summary>
        /// X62MF系列可接入9000设备,762MF,862MF
        /// </summary>
        public const int IPCAM_X62MF = 32;
        /// <summary>
        /// IP标清快球
        /// </summary>
        public const int IPDOME = 40;
        /// <summary>
        /// IP高清快球
        /// </summary>
        public const int MEGA_IPDOME = 41;
        /// <summary>
        /// IP 模块
        /// </summary>
        public const int IPMOD = 50;
        /// <summary>
        /// DS71XXH_S
        /// </summary>
        public const int DS71XX_H = 71;
        /// <summary>
        /// DS72XXH_S
        /// </summary>
        public const int DS72XX_H_S = 72;
        /// <summary>
        /// DS73XXH_S
        /// </summary>
        public const int DS73XX_H_S = 73;
        /// <summary>
        /// DS81XX_HS_S
        /// </summary>
        public const int DS81XX_HS_S = 81;
        /// <summary>
        /// DS81XX_HL_S
        /// </summary>
        public const int DS81XX_HL_S = 82;
        /// <summary>
        /// DS81XX_HC_S
        /// </summary>
        public const int DS81XX_HC_S = 83;
        /// <summary>
        /// DS81XX_HD_S
        /// </summary>
        public const int DS81XX_HD_S = 84;
        /// <summary>
        /// DS81XX_HE_S
        /// </summary>
        public const int DS81XX_HE_S = 85;
        /// <summary>
        /// DS81XX_HF_S
        /// </summary>
        public const int DS81XX_HF_S = 86;
        /// <summary>
        /// DS81XX_AH_S
        /// </summary>
        public const int DS81XX_AH_S = 87;
        /// <summary>
        /// DS81XX_AHF_S
        /// </summary>
        public const int DS81XX_AHF_S = 88;
        /// <summary>
        /// DS90XX_HF_S
        /// </summary>
        public const int DS90XX_HF_S = 90;
        /// <summary>
        /// DS91XX_HF_S
        /// </summary>
        public const int DS91XX_HF_S = 91;
        /// <summary>
        /// 91XXHD-S(MD)
        /// </summary>
        public const int DS91XX_HD_S = 92;
        #endregion
        /// <summary>
        /// 设备参数配置结构
        /// DVR设备参数
        ///    NET_DVR_DEVICECFG, *LPNET_DVR_DEVICECFG;
        /// </summary>
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            /// <summary>
            /// DVR名称
            ///     public byte sDVRName[NAME_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sDVRName;
            /// <summary>
            /// DVR ID,用于遥控器 //V1.4(0-99), V1.5(0-255)
            /// </summary>
            public uint dwDVRID;
            /// <summary>
            /// 是否循环录像,0:不是; 1:是
            /// </summary>
            public uint dwRecycleRecord;
            //以下不可更改
            /// <summary>
            /// 序列号
            ///     public byte sSerialNumber[SERIALNO_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.SERIALNO_LEN)]
            public byte[] sSerialNumber;
            /// <summary>
            /// 软件版本号,高16位是主版本,低16位是次版本
            /// </summary>
            public uint dwSoftwareVersion;
            /// <summary>
            /// 软件生成日期,0xYYYYMMDD
            /// </summary>
            public uint dwSoftwareBuildDate;
            /// <summary>
            /// DSP软件版本,高16位是主版本,低16位是次版本
            /// </summary>
            public uint dwDSPSoftwareVersion;
            /// <summary>
            /// DSP软件生成日期,0xYYYYMMDD
            /// </summary>
            public uint dwDSPSoftwareBuildDate;
            /// <summary>
            /// 前面板版本,高16位是主版本,低16位是次版本
            /// </summary>
            public uint dwPanelVersion;
            /// <summary>
            /// 硬件版本,高16位是主版本,低16位是次版本
            /// </summary>
            public uint dwHardwareVersion;
            /// <summary>
            /// DVR报警输入个数
            /// </summary>
            public byte byAlarmInPortNum;
            /// <summary>
            /// DVR报警输出个数
            /// </summary>
            public byte byAlarmOutPortNum;
            /// <summary>
            /// DVR 232串口个数
            /// </summary>
            public byte byRS232Num;
            /// <summary>
            /// DVR 485串口个数
            /// </summary>
            public byte byRS485Num;
            /// <summary>
            /// 网络口个数
            /// </summary>
            public byte byNetworkPortNum;
            /// <summary>
            /// DVR 硬盘控制器个数
            /// </summary>
            public byte byDiskCtrlNum;
            /// <summary>
            /// DVR 硬盘个数
            /// </summary>
            public byte byDiskNum;
            /// <summary>
            /// DVR类型, 1:DVR 2:ATM DVR 3:DVS ......
            /// </summary>
            public byte byDVRType;
            /// <summary>
            /// DVR 通道个数
            /// </summary>
            public byte byChanNum;
            /// <summary>
            /// 起始通道号,例如DVS-1,DVR - 1
            /// </summary>
            public byte byStartChan;
            /// <summary>
            /// DVR 解码路数
            /// </summary>
            public byte byDecordChans;
            /// <summary>
            /// VGA口的个数
            /// </summary>
            public byte byVGANum;
            /// <summary>
            /// USB口的个数
            /// </summary>
            public byte byUSBNum;
            /// <summary>
            /// 辅口的个数
            /// </summary>
            public byte byAuxoutNum;
            /// <summary>
            /// 语音口的个数
            /// </summary>
            public byte byAudioNum;
            /// <summary>
            /// 最大数字通道数
            /// </summary>
            public byte byIPChanNum;
        }
        #endregion
        #region 网络参数配置
        /// <summary>
        /// 以太网口定义(增加MTU设置)
        ///     网络数据结构(子结构)(9000扩展)
        ///    NET_DVR_ETHERNET_V30, *LPNET_DVR_ETHERNET_V30;
        /// </summary>
        public struct NET_DVR_ETHERNET_V30
        {
            /// <summary>
            /// DVR IP地址
            /// </summary>
            public NET_DVR_IPADDR struDVRIP;
            /// <summary>
            /// DVR IP地址掩码
            /// </summary>
            public NET_DVR_IPADDR struDVRIPMask;
            /// <summary>
            /// 网络接口1-10MBase-T 2-10MBase-T全双工 3-100MBase-TX 4-100M全双工 5-10M/100M自适应
            /// </summary>
            public uint dwNetInterface;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 增加MTU设置，默认1500。
            /// </summary>
            public ushort wMTU;
            /// <summary>
            /// 物理地址
            ///     public byte byMACAddr[MACADDR_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMACAddr;
        }
        /// <summary>
        /// 以太网口定义
        ///     网络数据结构(子结构)
        /// </summary>
        public struct NET_DVR_ETHERNET
        {
            /// <summary>
            /// DVR IP地址
            ///    public char sDVRIP[16];
            /// </summary>
            public string sDVRIP;
            /// <summary>
            /// DVR IP地址掩码
            ///    public char sDVRIPMask[16];
            /// </summary>
            public string sDVRIPMask;
            /// <summary>
            /// 网络接口 1-10MBase-T 2-10MBase-T全双工 3-100MBase-TX 4-100M全双工 5-10M/100M自适应
            /// </summary>
            public uint dwNetInterface;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 服务器的物理地址
            ///     public byte byMACAddr[MACADDR_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMACAddr;
        }
        /// <summary>
        /// IP地址结构体
        ///    NET_DVR_IPADDR, *LPNET_DVR_IPADDR;
        /// </summary>
        public struct NET_DVR_IPADDR
        {
            /// <summary>
            /// IPv4地址
            ///    char	sIpV4[16];
            /// </summary>
            public string sIpV4;
            /// <summary>
            /// 保留
            ///     public byte byRes[128]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] byRes;
        }
        /// <summary>
        /// PPPoE结构
        ///    NET_DVR_PPPOECFG, *LPNET_DVR_PPPOECFG;
        /// </summary>
        public struct NET_DVR_PPPOECFG
        {
            /// <summary>
            /// 0-不启用,1-启用
            /// </summary>
            public uint dwPPPOE;
            /// <summary>
            /// PPPoE用户名
            ///    public byte sPPPoEUser[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sPPPoEUser;
            /// <summary>
            ///  PPPoE密码
            ///    char	sPPPoEPassword[PASSWD_LEN];
            /// </summary>
            public string sPPPoEPassword;
            /// <summary>
            /// PPPoE IP地址
            /// </summary>
            public NET_DVR_IPADDR struPPPoEIP;
        }
        /// <summary>
        /// 网络参数结构结构体(9000扩展)
        ///    NET_DVR_NETCFG_V30, *LPNET_DVR_NETCFG_V30;
        /// </summary>
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            /// <summary>
            /// 以太网口
            ///     NET_DVR_ETHERNET_V30 struEtherNet[MAX_ETHERNET]
            /// </summary>
            public NET_DVR_ETHERNET_V30[] struEtherNet;
            /// <summary>
            /// 保留
            ///     public NET_DVR_IPADDR struRes1[2]
            /// </summary>
            public NET_DVR_IPADDR[] struRes1;
            /// <summary>
            /// 报警主机IP地址
            /// </summary>
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            /// <summary>
            /// 保留
            ///     public ushort wRes2[2]
            /// </summary>
            public ushort[] wRes2;
            /// <summary>
            /// 报警主机端口号
            /// </summary>
            public ushort wAlarmHostIpPort;
            /// <summary>
            /// 是否启用DHCP 0xff-无效 0-不启用 1-启用
            /// </summary>
            public byte byUseDhcp;
            /// <summary>
            /// 保留
            /// </summary>
            public byte byRes3;
            /// <summary>
            /// 域名服务器1的IP地址
            /// </summary>
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            /// <summary>
            /// 域名服务器2的IP地址 
            /// </summary>
            public NET_DVR_IPADDR struDnsServer2IpAddr;
            /// <summary>
            /// IP解析服务器域名或IP地址
            ///     public byte byIpResolver[MAX_DOMAIN_NAME]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_DOMAIN_NAME)]
            public byte[] byIpResolver;
            /// <summary>
            /// IP解析服务器端口号
            /// </summary>
            public ushort wIpResolverPort;
            /// <summary>
            ///  HTTP端口号
            /// </summary>
            public ushort wHttpPortNo;
            /// <summary>
            /// 多播组地址
            /// </summary>
            public NET_DVR_IPADDR struMulticastIpAddr;
            /// <summary>
            /// 网关地址
            /// </summary>
            public NET_DVR_IPADDR struGatewayIpAddr;
            /// <summary>
            /// 详见 NET_DVR_PPPOECFG
            /// </summary>
            public NET_DVR_PPPOECFG struPPPoE;
            /// <summary>
            /// 保留
            ///     public byte byRes[64]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] byRes;
        }
        /// <summary>
        /// 网络配置结构
        ///    NET_DVR_NETCFG, *LPNET_DVR_NETCFG;
        /// </summary>
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            /// <summary>
            /// 以太网口
            ///     NET_DVR_ETHERNET struEtherNet[MAX_ETHERNET]
            /// </summary>
            public NET_DVR_ETHERNET[] struEtherNet;
            /// <summary>
            /// 远程管理主机地址
            ///    public char sManageHostIP[16];
            /// </summary>
            public string sManageHostIP;
            /// <summary>
            /// 远程管理主机端口号
            /// </summary>
            public ushort wManageHostPort;
            /// <summary>
            /// IPServer服务器地址
            ///    public char sIPServerIP[16];
            /// </summary>
            public string sIPServerIP;
            /// <summary>
            /// 多播组地址
            ///    public char sMultiCastIP[16];
            /// </summary>
            public string sMultiCastIP;
            /// <summary>
            /// 网关地址
            ///    public char sGatewayIP[16];
            /// </summary>
            public string sGatewayIP;
            /// <summary>
            /// NFS主机IP地址
            ///    public char sNFSIP[16];
            /// </summary>
            public string sNFSIP;
            /// <summary>
            /// NFS目录
            ///     public byte sNFSDirectory[PATHNAME_LEN]
            /// </summary>
            public byte[] sNFSDirectory;
            /// <summary>
            /// 0-不启用,1-启用
            /// </summary>
            public uint dwPPPOE;
            /// <summary>
            /// PPPoE用户名
            ///     public byte sPPPoEUser[NAME_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sPPPoEUser;
            /// <summary>
            /// PPPoE密码
            ///    public char sPPPoEPassword[PASSWD_LEN];
            /// </summary>
            public string sPPPoEPassword;
            /// <summary>
            /// PPPoE IP地址(只读)
            ///    public char sPPPoEIP[16];
            /// </summary>
            public string sPPPoEIP;
            /// <summary>
            /// HTTP端口号
            /// </summary>
            public ushort wHttpPort;
        }
        #endregion
        #region 图像参数配置
        #region 设备报警和异常处理方式
        /// <summary>
        /// 无响应
        /// </summary>
        public int NOACTION = 0x0;
        /// <summary>
        /// 监视器上警告
        /// </summary>
        public int WARNONMONITOR = 0x1;
        /// <summary>
        /// 声音警告
        /// </summary>
        public int WARNONAUDIOOUT = 0x2;
        /// <summary>
        /// 上传中心
        /// </summary>
        public int UPTOCENTER = 0x4;
        /// <summary>
        /// 触发报警输出
        /// </summary>
        public int TRIGGERALARMOUT = 0x8;
        #endregion
        /// <summary>
        /// 报警和异常处理结构(子结构)(多处使用)(9000扩展)
        ///    NET_DVR_HANDLEEXCEPTION_V30, *LPNET_DVR_HANDLEEXCEPTION_V30;
        /// </summary>
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            /// <summary>
            /// 处理方式,处理方式的"或"结果
            ///     0x00: 无响应
            ///     0x01: 监视器上警告
            ///     0x02: 声音警告
            ///     0x04: 上传中心
            ///     0x08: 触发报警输出
            ///     0x10: Jpeg抓图并上传EMail
            /// </summary>
            public uint dwHandleType;
            /// <summary>
            /// 报警触发的输出通道，数组元素值为1表示触发该路报警输出
            ///     public byte byRelAlarmOut[MAX_ALARMOUT_V30];  
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT_V30)]
            public byte[] byRelAlarmOut;
        }
        /// <summary>
        /// 报警和异常处理结构(子结构)(多处使用)
        ///    NET_DVR_HANDLEEXCEPTION, *LPNET_DVR_HANDLEEXCEPTION;
        /// </summary>
        public struct NET_DVR_HANDLEEXCEPTION
        {
            /// <summary>
            /// 处理方式,处理方式的"或"结果
            ///       0x00: 无响应
            ///       0x01: 监视器上警告
            ///       0x02: 声音警告
            ///       0x04: 上传中心
            ///       0x08: 触发报警输出
            ///       0x10: Jpeg抓图并上传EMail
            /// </summary>
            public uint dwHandleType;
            /// <summary>
            /// 报警触发的输出通道,报警触发的输出,为1表示触发该输出
            ///     public byte byRelAlarmOut[MAX_ALARMOUT]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT)]
            public byte[] byRelAlarmOut;
        }
        /// <summary>
        /// 布防时间
        ///     时间段(子结构)
        ///    NET_DVR_SCHEDTIME, *LPNET_DVR_SCHEDTIME;
        /// </summary>
        public struct NET_DVR_SCHEDTIME
        {
            /// <summary>
            /// 录像开始时间：时
            /// </summary>
            public byte byStartHour;
            /// <summary>
            /// 录像开始时间：分
            /// </summary>
            public byte byStartMin;
            /// <summary>
            /// 录像结束时间：时
            /// </summary>
            public byte byStopHour;
            /// <summary>
            /// 录像结束时间：分
            /// </summary>
            public byte byStopMin;
        }
        /// <summary>
        /// 视频丢失
        ///     信号丢失报警(子结构)(9000扩展)
        ///     NET_DVR_VILOST_V30, *LPNET_DVR_VILOST_V30;
        /// </summary>
        public struct NET_DVR_VILOST_V30
        {
            /// <summary>
            /// 是否处理信号丢失报警
            /// </summary>
            public byte byEnableHandleVILost;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT_V30];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
        }

        /// <summary>
        /// 视频丢失
        ///     信号丢失报警(子结构)
        ///     NET_DVR_VILOST, *LPNET_DVR_VILOST;
        /// </summary>
        public struct NET_DVR_VILOST
        {
            /// <summary>
            /// 是否处理信号丢失报警
            /// </summary>
            public byte byEnableHandleVILost;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
        }
        /// <summary>
        /// 移动侦测(通道图象结构)
        /// 移动侦测(子结构)(9000扩展)
        ///    NET_DVR_MOTION_V30, *LPNET_DVR_MOTION_V30;
        /// </summary>
        public struct NET_DVR_MOTION_V30
        {
            /// <summary>
            /// 侦测区域,0-96位,表示64行,共有96*64个小宏块,为1表示是移动侦测区域,0-表示不是
            ///    public byte byMotionScope[64][96];
            /// </summary>
            public byte[,] byMotionScope;
            /// <summary>
            /// 移动侦测灵敏度, 0 - 5,越高越灵敏,oxff关闭
            /// </summary>
            public byte byMotionSensitive;
            /// <summary>
            /// 是否处理移动侦测 0－否 1－是
            /// </summary>
            public byte byEnableHandleMotion;
            /// <summary>
            /// 移动侦测算法的进度: 0--16*16, 1--32*32, 2--64*64 ...
            /// </summary>
            public byte byPrecision;
            public char reservedData;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT_V30];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
            /// <summary>
            /// 报警触发的录象通道
            ///     public byte byRelRecordChan[MAX_CHANNUM_V30]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byRelRecordChan;
        }
        /// <summary>
        /// 移动侦测(子结构)
        ///    NET_DVR_MOTION, *LPNET_DVR_MOTION;
        /// </summary>
        public struct NET_DVR_MOTION
        {
            /// <summary>
            /// 侦测区域,共有22*18个小宏块,为1表示改宏块是移动侦测区域,0-表示不是
            ///    public byte byMotionScope[18][22];	
            /// </summary>
            public byte[,] byMotionScope;
            /// <summary>
            /// 移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭
            /// </summary>
            public byte byMotionSensitive;
            /// <summary>
            /// 是否处理移动侦测
            /// </summary>
            public byte byEnableHandleMotion;
            /// <summary>
            /// 保留参数
            ///    public char reservedData[2];
            /// </summary>
            public string reservedData;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
            /// <summary>
            /// 报警触发的录象通道,为1表示触发该通道
            ///    public byte byRelRecordChan[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byRelRecordChan;
        }
        /// <summary>
        /// 遮挡报警(子结构)(9000扩展)  区域大小704*576
        ///    NET_DVR_HIDEALARM_V30, *LPNET_DVR_HIDEALARM_V30;
        /// </summary>
        public struct NET_DVR_HIDEALARM_V30
        {
            /// <summary>
            /// 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度
            /// </summary>
            public uint dwEnableHideAlarm;
            /// <summary>
            /// 遮挡区域的x坐标
            /// </summary>
            public ushort wHideAlarmAreaTopLeftX;
            /// <summary>
            /// 遮挡区域的y坐标
            /// </summary>
            public ushort wHideAlarmAreaTopLeftY;
            /// <summary>
            /// 遮挡区域的宽
            /// </summary>
            public ushort wHideAlarmAreaWidth;
            /// <summary>
            /// 遮挡区域的高
            /// </summary>
            public ushort wHideAlarmAreaHeight;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT_V30];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
        }
        /// <summary>
        /// 遮挡报警(子结构)  区域大小704*576
        ///    NET_DVR_HIDEALARM, *LPNET_DVR_HIDEALARM;
        /// </summary>
        public struct NET_DVR_HIDEALARM
        {
            /// <summary>
            /// 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度
            /// </summary>
            public uint dwEnableHideAlarm;
            /// <summary>
            /// 遮挡区域的x坐标
            /// </summary>
            public ushort wHideAlarmAreaTopLeftX;
            /// <summary>
            /// 遮挡区域的y坐标
            /// </summary>
            public ushort wHideAlarmAreaTopLeftY;
            /// <summary>
            /// 遮挡区域的宽
            /// </summary>
            public ushort wHideAlarmAreaWidth;
            /// <summary>
            /// 遮挡区域的高
            /// </summary>
            public ushort wHideAlarmAreaHeight;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;
            /// <summary>
            /// 布防时间
            ///    NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
        }
        /// <summary>
        /// 遮蔽区域，以色块屏蔽视频中的某部分信息
        ///    NET_DVR_SHELTER, *LPNET_DVR_SHELTER;
        /// </summary>
        public struct NET_DVR_SHELTER
        {
            /// <summary>
            /// 遮挡区域的x坐标
            /// </summary>
            public ushort wHideAreaTopLeftX;
            /// <summary>
            /// 遮挡区域的y坐标
            /// </summary>
            public ushort wHideAreaTopLeftY;
            /// <summary>
            /// 遮挡区域的宽
            /// </summary>
            public ushort wHideAreaWidth;
            /// <summary>
            /// 遮挡区域的高
            /// </summary>
            public ushort wHideAreaHeight;
        }

        /// <summary>
        /// 视频色彩参数
        ///    NET_DVR_COLOR, *LPNET_DVR_COLOR;
        /// </summary>
        public struct NET_DVR_COLOR
        {
            /// <summary>
            /// 亮度,0-255
            /// </summary>
            public byte byBrightness;
            /// <summary>
            /// 对比度,0-255
            /// </summary>
            public byte byContrast;
            /// <summary>
            /// 饱和度,0-255
            /// </summary>
            public byte bySaturation;
            /// <summary>
            /// 色调,0-255
            /// </summary>
            public byte byHue;
        }
        /// <summary>
        /// 图像参数(9000扩展)
        ///    NET_DVR_PICCFG_V30, *LPNET_DVR_PICCFG_V30;
        /// </summary>
        public struct NET_DVR_PICCFG_V30
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 通道名称
            ///    public byte sChanName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sChanName;
            /// <summary>
            /// 只读 视频制式 1-NTSC 2-PAL
            /// </summary>
            public uint dwVideoFormat;
            /// <summary>
            /// 图像参数
            /// </summary>
            public NET_DVR_COLOR struColor;
            /// <summary>
            /// 保留
            ///    public char reservedData [60];
            /// </summary>
            public string reservedData;
            //显示通道名
            /// <summary>
            /// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            /// </summary>
            public uint dwShowChanName;
            /// <summary>
            /// 通道名称显示位置的x坐标 
            /// </summary>
            public ushort wShowNameTopLeftX;
            /// <summary>
            /// 通道名称显示位置的y坐标
            /// </summary>
            public ushort wShowNameTopLeftY;
            /// <summary>
            /// 视频信号丢失报警
            /// </summary>
            public NET_DVR_VILOST_V30 struVILost;
            /// <summary>
            /// 保留
            /// </summary>
            public NET_DVR_VILOST_V30 struRes;
            /// <summary>
            /// 移动侦测
            /// </summary>
            public NET_DVR_MOTION_V30 struMotion;
            /// <summary>
            /// 遮挡报警
            /// </summary>
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            /// <summary>
            /// 是否启动区域遮蔽（以色块盖住图像中需隐藏部分）：0－否；1－是，区域范围大小704*576
            /// </summary>
            public uint dwEnableHide;
            /// <summary>
            /// 遮蔽区域
            ///    NET_DVR_SHELTER struShelter[MAX_SHELTERNUM];
            /// </summary>
            public NET_DVR_SHELTER[] struShelter;
            /// <summary>
            /// 预览的图象上是否显示OSD，0－不显示；1－显示，区域大小704*576
            /// </summary>
            public uint dwShowOsd;
            /// <summary>
            /// OSD的x坐标
            /// </summary>
            public ushort wOSDTopLeftX;
            /// <summary>
            /// OSD的y坐标
            /// </summary>
            public ushort wOSDTopLeftY;
            /// <summary>
            /// OSD类型(主要是年月日格式) 
            ///    0: XXXX-XX-XX 年月日
            ///    1: XX-XX-XXXX 月日年
            ///    2: XXXX年XX月XX日
            ///    3: XX月XX日XXXX年
            ///    4: XX-XX-XXXX 日月年
            ///    5: XX日XX月XXXX年
            /// </summary>
            public byte byOSDType;
            /// <summary>
            /// 是否显示星期
            /// </summary>
            public byte byDispWeek;
            /// <summary>
            /// OSD属性:透明，闪烁
            ///    0: 不显示OSD
            ///    1: 透明,闪烁
            ///    2: 透明,不闪烁
            ///    3: 闪烁,不透明
            ///    4: 不透明,不闪烁
            /// </summary>
            public byte byOSDAttrib;
            /// <summary>
            /// OSD小时制:0-24小时制,1-12小时制
            /// </summary>
            public byte byHourOSDType;
            /// <summary>
            /// public byte byRes[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] byRes;
        }
        /// <summary>
        /// 通道图象结构(SDK_V13及之前版本)
        ///    NET_DVR_PICCFG, *LPNET_DVR_PICCFG;
        /// </summary>
        public struct NET_DVR_PICCFG
        {
            /// <summary>
            /// 此结构的大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 通道名称
            ///    public byte sChanName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sChanName;
            /// <summary>
            ///  只读 视频制式 1-NTSC 2-PAL
            /// </summary>
            public uint dwVideoFormat;
            /// <summary>
            /// 亮度,0-255
            /// </summary>
            public byte byBrightness;
            /// <summary>
            /// 对比度,0-255
            /// </summary>
            public byte byContrast;
            /// <summary>
            /// 饱和度,0-255
            /// </summary>
            public byte bySaturation;
            /// <summary>
            /// 色调,0-255
            /// </summary>
            public byte byHue;
            /// <summary>
            /// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            /// </summary>
            public uint dwShowChanName;
            /// <summary>
            /// 通道名称显示位置的x坐标
            /// </summary>
            public ushort wShowNameTopLeftX;
            /// <summary>
            /// 通道名称显示位置的y坐标
            /// </summary>
            public ushort wShowNameTopLeftY;
            /// <summary>
            /// 信号丢失报警
            /// </summary>
            public NET_DVR_VILOST struVILost;
            /// <summary>
            /// 移动侦测
            /// </summary>
            public NET_DVR_MOTION struMotion;
            /// <summary>
            /// 遮挡报警
            /// </summary>
            public NET_DVR_HIDEALARM struHideAlarm;
            /// <summary>
            /// 是否启动区域遮蔽（以色块盖住图像中需隐藏部分）：0－否，1－是    ?区域大小704*576[注释中没有说明该大小]
            /// </summary>
            public uint dwEnableHide;
            /// <summary>
            /// 遮挡区域的x坐标
            /// </summary>
            public ushort wHideAreaTopLeftX;
            /// <summary>
            /// 遮挡区域的y坐标
            /// </summary>
            public ushort wHideAreaTopLeftY;
            /// <summary>
            /// 遮挡区域的宽
            /// </summary>
            public ushort wHideAreaWidth;
            /// <summary>
            /// 遮挡区域的高
            /// </summary>
            public ushort wHideAreaHeight;
            /// <summary>
            /// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
            /// </summary>
            public uint dwShowOsd;
            /// <summary>
            /// OSD的x坐标
            /// </summary>
            public ushort wOSDTopLeftX;
            /// <summary>
            /// OSD的y坐标
            /// </summary>
            public ushort wOSDTopLeftY;
            /// <summary>
            /// OSD类型(主要是年月日格式)
            ///    0: XXXX-XX-XX 年月日
            ///    1: XX-XX-XXXX 月日年
            ///    2: XXXX年XX月XX日
            ///    3: XX月XX日XXXX年
            ///    4: XX-XX-XXXX 日月年
            ///    5: XX日XX月XXXX年
            /// </summary>
            public byte byOSDType;
            /// <summary>
            /// 是否显示星期
            /// </summary>
            public byte byDispWeek;
            /// <summary>
            /// OSD属性:透明，闪烁
            ///    0: 不显示OSD
            ///    1: 透明,闪烁
            ///    2: 透明,不闪烁
            ///    3: 闪烁,不透明
            ///    4: 不透明,不闪烁
            /// </summary>
            public byte byOSDAttrib;
            public char reservedData2;
        }
        /// <summary>
        /// 通道图象结构SDK_V14扩展
        ///     注意
        ///         修改移动侦测报警、遮挡报警和视频丢失报警的布防时间段后需要重启设备。
        ///    NET_DVR_PICCFG_EX, *LPNET_DVR_PICCFG_EX;
        /// </summary>
        public struct NET_DVR_PICCFG_EX
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 通道名称
            ///     public byte sChanName[NAME_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sChanName;
            /// <summary>
            /// 只读 视频制式 1-NTSC 2-PAL
            /// </summary>
            public uint dwVideoFormat;
            /// <summary>
            /// 亮度,0-255
            /// </summary>
            public byte byBrightness;
            /// <summary>
            /// 对比度,0-255
            /// </summary>
            public byte byContrast;
            /// <summary>
            /// 饱和度,0-255
            /// </summary>
            public byte bySaturation;
            /// <summary>
            /// 色调,0-255
            /// </summary>
            public byte byHue;
            /// <summary>
            /// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
            /// </summary>
            public uint dwShowChanName;
            /// <summary>
            /// 通道名称显示位置的x坐标
            /// </summary>
            public ushort wShowNameTopLeftX;
            /// <summary>
            /// 通道名称显示位置的y坐标
            /// </summary>
            public ushort wShowNameTopLeftY;
            /// <summary>
            /// 信号丢失报警
            /// </summary>
            public NET_DVR_VILOST struVILost;
            /// <summary>
            /// 移动侦测
            /// </summary>
            public NET_DVR_MOTION struMotion;
            /// <summary>
            /// 遮挡报警
            /// </summary>
            public NET_DVR_HIDEALARM struHideAlarm;
            /// <summary>
            /// 是否启用遮蔽功能（以色块盖住图像中需隐藏部分）：0－否，1－是，视频区域范围704*576
            /// </summary>
            public uint dwEnableHide;
            /// <summary>
            /// 遮蔽区域
            ///    NET_DVR_SHELTER struShelter[MAX_SHELTERNUM];
            /// </summary>
            public NET_DVR_SHELTER[] struShelter;
            /// <summary>
            /// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
            /// </summary>
            public uint dwShowOsd;
            /// <summary>
            /// OSD的x坐标
            /// </summary>
            public ushort wOSDTopLeftX;
            /// <summary>
            /// OSD的y坐标
            /// </summary>
            public ushort wOSDTopLeftY;
            /// <summary>
            ///  OSD类型(主要是年月日格式)
            ///    0: XXXX-XX-XX 年月日
            ///    1: XX-XX-XXXX 月日年
            ///    2: XXXX年XX月XX日
            ///    3: XX月XX日XXXX年
            ///    4: XX-XX-XXXX 日月年
            ///    5: XX日XX月XXXX年 
            /// </summary>
            public byte byOSDType;
            /// <summary>
            /// 是否显示星期
            /// </summary>
            public byte byDispWeek;
            /// <summary>
            /// OSD属性:透明，闪烁
            ///    0: 不显示OSD
            ///    1: 透明,闪烁
            ///    2: 透明,不闪烁
            ///    3: 闪烁,不透明
            ///    4: 不透明,不闪烁
            /// </summary>
            public byte byOSDAttrib;
            /// <summary>
            /// OSD小时制:0-24小时制,1-12小时制
            /// </summary>
            public byte byHourOsdType;
        }
        #endregion
        #region 压缩参数配置
        /// <summary>
        /// 码流压缩参数(子结构)(9000扩展)
        ///    NET_DVR_COMPRESSION_INFO_V30, *LPNET_DVR_COMPRESSION_INFO_V30;
        /// </summary>
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            /// <summary>
            /// 码流类型 0-视频流, 1-复合流, 表示事件压缩参数时最高位表示是否启用压缩参数
            /// </summary>
            public byte byStreamType;
            /// <summary>
            /// 分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）16-VGA（640*480） 17-UXGA（1600*1200） 18-SVGA （800*600）19-HD720p（1280*720）20-XVGA  21-HD900p
            /// </summary>
            public byte byResolution;
            /// <summary>
            /// 码率类型 0:定码率，1:变码率
            /// </summary>
            public byte byBitrateType;
            /// <summary>
            /// 图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            /// </summary>
            public byte byPicQuality;
            /// <summary>
            /// 视频码率 0-保留 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            /// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            /// 最高位(31位)置成1表示是自定义码流, 0-30位表示码流值。
            /// </summary>
            public uint dwVideoBitrate;
            /// <summary>
            /// 帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0版本中新加14-15; 15-18; 16-22;
            /// </summary>
            public uint dwVideoFrameRate;
            /// <summary>
            /// I帧间隔
            /// </summary>
            public ushort wIntervalFrameI;
            /// <summary>
            /// 0-BBP帧; 1-BP帧; 2-单P帧
            /// 2006-08-11 增加单P帧的配置接口，可以改善实时流延时问题
            /// </summary>
            public byte byIntervalBPFrame;
            /// <summary>
            /// 保留
            /// </summary>
            public byte byres1;
            /// <summary>
            /// 视频编码类型 0 hik264;1标准h264; 2标准mpeg4;
            /// </summary>
            public byte byVideoEncType;
            /// <summary>
            /// 音频编码类型 0－OggVorbis
            /// </summary>
            public byte byAudioEncType;
            /// <summary>
            /// 这里保留音频的压缩参数
            ///    public byte  byres[10];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] byres;
        }
        /// <summary>
        /// 码流压缩参数(子结构)
        ///     NET_DVR_COMPRESSION_INFO, *LPNET_DVR_COMPRESSION_INFO;
        /// </summary>
        public struct NET_DVR_COMPRESSION_INFO
        {
            /// <summary>
            /// 码流类型0-视频流,1-复合流,表示压缩参数时最高位表示是否启用压缩参数
            /// </summary>
            public byte byStreamType;
            /// <summary>
            /// 分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
            /// </summary>
            public byte byResolution;
            /// <summary>
            /// 码率类型0:变码率，1:定码率
            /// </summary>
            public byte byBitrateType;
            /// <summary>
            /// 图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            /// </summary>
            public byte byPicQuality;
            /// <summary>
            /// 视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            /// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            /// 最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
            /// </summary>
            public uint dwVideoBitrate;
            /// <summary>
            /// 帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
            /// </summary>
            public uint dwVideoFrameRate;
        }
        /// <summary>
        /// 码流压缩参数(子结构)(扩展) 增加I帧间隔
        ///     NET_DVR_COMPRESSION_INFO_EX, *LPNET_DVR_COMPRESSION_INFO_EX;
        /// </summary>
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            /// <summary>
            /// 码流类型0-视频流, 1-复合流
            /// </summary>
            public byte byStreamType;
            /// <summary>
            /// 分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
            /// </summary>
            public byte byResolution;
            /// <summary>
            /// 码率类型0:变码率，1:定码率
            /// </summary>
            public byte byBitrateType;
            /// <summary>
            /// 图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
            /// </summary>
            public byte byPicQuality;
            /// <summary>
            /// 视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            /// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            /// 最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
            /// </summary>
            public uint dwVideoBitrate; 	//
            /// <summary>
            /// 帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0增加14-15, 15-18, 16-22;
            /// </summary>
            public uint dwVideoFrameRate;
            /// <summary>
            /// I帧间隔
            /// </summary>
            public ushort wIntervalFrameI;
            /// <summary>
            /// 单P帧的配置接口，可以改善实时流延时问题0－BBP帧；1－BP帧；2－单P帧， BP帧设置暂不支持
            /// </summary>
            public byte byIntervalBPFrame;
            /// <summary>
            /// #此字段和文档中不一样[public byte byENumber E帧数量]
            /// </summary>
            public byte byRes;
        }
        /// <summary>
        /// 压缩参数(9000扩展)
        ///    NET_DVR_COMPRESSIONCFG_V30, *LPNET_DVR_COMPRESSIONCFG_V30;
        /// </summary>
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 主码流(录像) 对应8000的普通
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;
            /// <summary>
            /// 保留 public char reserveData[28];
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_V30 struRes;
            /// <summary>
            /// 事件触发录像压缩参数
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;
            /// <summary>
            /// 网传(子码流)
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;
        }
        /// <summary>
        /// 通道压缩参数
        ///     NET_DVR_COMPRESSIONCFG, *LPNET_DVR_COMPRESSIONCFG;
        /// </summary>
        public struct NET_DVR_COMPRESSIONCFG
        {
            /// <summary>
            /// 此结构的大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 录像/事件触发录像
            /// </summary>
            public NET_DVR_COMPRESSION_INFO struRecordPara;
            /// <summary>
            /// 网传/保留
            /// </summary>
            public NET_DVR_COMPRESSION_INFO struNetPara;
        }
        /// <summary>
        /// 通道压缩参数(扩展)
        ///     注意
        ///         在网传（子码流）中的分辨率只能设置成CIF和QCIF；在设置码流类型（Stream Type）后需要重启设备；部分设备（8路和16路的7000以及8000HS-S）修改分辨率后也需要重启设备。
        ///     NET_DVR_COMPRESSIONCFG_EX, *LPNET_DVR_COMPRESSIONCFG_EX;
        /// </summary>
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            /// <summary>
            /// 此结构的大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 录像
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;
            /// <summary>
            /// 网传
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;
        }
        #endregion
        #region 录像参数配置
        /// <summary>
        /// 全天录像(子结构)
        ///     NET_DVR_RECORDDAY, *LPNET_DVR_RECORDDAY;
        /// </summary>
        public struct NET_DVR_RECORDDAY
        {
            /// <summary>
            /// 是否全天录像 0-否 1-是
            /// </summary>
            public ushort wAllDayRecord;
            /// <summary>
            /// 录象类型 0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警 5:命令触发, 6: 手动录像
            /// </summary>
            public byte byRecordType;
            /// <summary>
            /// 保留
            /// </summary>
            public char reservedData;
        }
        /// <summary>
        /// 时间段录像(子结构)
        ///     NET_DVR_RECORDSCHED, *LPNET_DVR_RECORDSCHED;
        /// </summary>
        public struct NET_DVR_RECORDSCHED
        {
            /// <summary>
            /// 录像时间
            /// </summary>
            public NET_DVR_SCHEDTIME struRecordTime;
            /// <summary>
            /// 0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警, 5:命令触发, 6: 手动录像
            /// </summary>
            public byte byRecordType;
            /// <summary>
            /// 保留
            ///     public char reservedData[3];
            /// </summary>
            public string reservedData;
        }
        /// <summary>
        /// 录像参数(9000扩展)
        ///     NET_DVR_RECORD_V30, *LPNET_DVR_RECORD_V30;
        /// </summary>
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            /// <summary>
            /// 是否录像 0-否 1-是
            /// </summary>
            public uint dwRecord;
            /// <summary>
            /// 全天录像布防
            ///     NET_DVR_RECORDDAY	struRecAllDay[MAX_DAYS];
            /// </summary>
            public NET_DVR_RECORDDAY[] struRecAllDay;
            /// <summary>
            /// 时间段录像布防
            ///     struRecordSched[MAX_DAYS][MAX_TIMESEGMENT_V30]
            /// </summary>
            public NET_DVR_RECORDSCHED[,] struRecordSched;
            /// <summary>
            /// 录象延时长度 0-5秒， 1-20秒， 2-30秒， 3-1分钟， 4-2分钟， 5-5分钟， 6-10分钟
            /// </summary>
            public uint dwRecordTime;
            /// <summary>
            /// 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录)
            /// </summary>
            public uint dwPreRecordTime;
            /// <summary>
            /// 录像保存的最长时间
            /// </summary>
            public uint dwRecorderDuration;
            /// <summary>
            /// 是否冗余录像,重要数据双备份：0/1
            /// </summary>
            public byte byRedundancyRec;
            ///录像时复合流编码时是否记录音频数据：国外有此法规
            public byte byAudioRec;
            /// <summary>
            /// 保留参数
            /// 	public byte	byReserve[10];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] byReserve;
        }
        /// <summary>
        /// 通道录像参数配置
        ///     NET_DVR_RECORD, *LPNET_DVR_RECORD;
        /// </summary>
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            /// <summary>
            /// 是否录像 0-否 1-是
            /// </summary>
            public uint dwRecord;
            /// <summary>
            /// 全天录像布防
            ///     NET_DVR_RECORDDAY struRecAllDay[MAX_DAYS];
            /// </summary>
            public NET_DVR_RECORDDAY[] struRecAllDay;
            /// <summary>
            /// 录像布防
            ///     NET_DVR_RECORDSCHED struRecordSched[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_RECORDSCHED[,] struRecordSched;
            /// <summary>
            /// 录象时间长度
            /// </summary>
            public uint dwRecordTime;
            /// <summary>
            /// 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录)
            /// </summary>
            public uint dwPreRecordTime;
        }
        #endregion
        #region 云台解码器参数配置
        /// <summary>
        /// 云台解码器参数(9000扩展)
        ///     NET_DVR_DECODERCFG_V30, *LPNET_DVR_DECODERCFG_V30;
        /// </summary>
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            /// <summary>
            /// 波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            /// </summary>
            public uint dwBaudRate;
            /// <summary>
            /// 数据有几位 0－5位，1－6位，2－7位，3－8位;
            /// </summary>
            public byte byDataBit;
            /// <summary>
            /// 停止位 0－1位，1－2位;
            /// </summary>
            public byte byStopBit;
            /// <summary>
            /// 校验 0－无校验，1－奇校验，2－偶校验;
            /// </summary>
            public byte byParity;
            /// <summary>
            /// 0－无，1－软流控,2-硬流控
            /// </summary>
            public byte byFlowcontrol;
            /// <summary>
            /// 解码器类型, 从0开始，对应ptz协议列表
            /// </summary>
            public ushort wDecoderType;
            /// <summary>
            /// 解码器地址:0 - 255
            /// </summary>
            public ushort wDecoderAddress;
            /// <summary>
            /// 预置点是否设置,0-没有设置,1-设置
            ///     public byte bySetPreset[MAX_PRESET_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_PRESET_V30)]
            public byte[] bySetPreset;
            /// <summary>
            /// 巡航是否设置: 0-没有设置,1-设置
            ///     public byte bySetCruise[MAX_CRUISE_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CRUISE_V30)]
            public byte[] bySetCruise;
            /// <summary>
            /// 轨迹是否设置,0-没有设置,1-设置
            ///     public byte bySetTrack[MAX_TRACK_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_TRACK_V30)]
            public byte[] bySetTrack;
        }
        /// <summary>
        /// 通道解码器(云台)参数配置
        ///     NET_DVR_DECODERCFG, *LPNET_DVR_DECODERCFG;
        /// </summary>
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            /// <summary>
            /// 波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            /// </summary>
            public uint dwBaudRate;
            /// <summary>
            /// 数据有几位 0－5位，1－6位，2－7位，3－8位;
            /// </summary>
            public byte byDataBit;
            /// <summary>
            /// 停止位 0－1位，1－2位;
            /// </summary>
            public byte byStopBit;
            /// <summary>
            /// 校验 0－无校验，1－奇校验，2－偶校验;
            /// </summary>
            public byte byParity;
            /// <summary>
            /// 0－无，1－软流控,2-硬流控
            /// </summary>
            public byte byFlowcontrol;
            /// <summary>
            /// 解码器类型, 0－YouLi，1－LiLin-1016，2－LiLin-820，3－Pelco-p，4－DM DynaColor，5－HD600，6－JC-4116，7－Pelco-d WX，8－Pelco-d PICO
            /// </summary>
            public ushort wDecoderType;
            /// <summary>
            /// 解码器地址:0 - 255
            /// </summary>
            public ushort wDecoderAddress;
            /// <summary>
            /// 预置点是否设置,0-没有设置,1-设置
            ///     public byte bySetPreset[MAX_PRESET];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_PRESET)]
            public byte[] bySetPreset;
            /// <summary>
            /// 巡航是否设置: 0-没有设置,1-设置
            ///     public byte bySetCruise[MAX_CRUISE];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CRUISE)]
            public byte[] bySetCruise;
            /// <summary>
            /// 轨迹是否设置,0-没有设置,1-设置
            ///     public byte bySetTrack[MAX_TRACK];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_TRACK)]
            public byte[] bySetTrack;
        }
        #endregion
        #region 232串口参数配置
        /// <summary>
        /// ppp参数配置(子结构)
        ///     NET_DVR_PPPCFG_V30, *LPNET_DVR_PPPCFG_V30;
        /// </summary>
        public struct NET_DVR_PPPCFG_V30
        {
            /// <summary>
            /// 远端IP地址
            /// </summary>
            public NET_DVR_IPADDR struRemoteIP;
            /// <summary>
            /// 本地IP地址
            /// </summary>
            public NET_DVR_IPADDR struLocalIP;
            /// <summary>
            /// 本地IP地址掩码
            ///     public char sLocalIPMask[16];
            /// </summary>
            public string sLocalIPMask;
            /// <summary>
            /// 用户名
            ///     public byte sUsername[NAME_LEN];
            /// </summary>
            public string sUsername;
            /// <summary>
            /// 密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
            /// <summary>
            /// PPP模式, 0－主动，1－被动
            /// </summary>
            public byte byPPPMode;
            /// <summary>
            /// 是否回拨 ：0-否,1-是
            /// </summary>
            public byte byRedial;
            /// <summary>
            /// 回拨模式,0-由拨入者指定,1-预置回拨号码
            /// </summary>
            public byte byRedialMode;
            /// <summary>
            /// 数据加密,0-否,1-是
            /// </summary>
            public byte byDataEncrypt;
            /// <summary>
            /// MTU
            /// </summary>
            public uint dwMTU;
            /// <summary>
            /// 电话号码
            ///     public char sTelephoneNumber[PHONENUMBER_LEN];
            /// </summary>
            public string sTelephoneNumber;
        }

        /// <summary>
        /// ppp参数配置(子结构)
        ///     NET_DVR_PPPCFG, *LPNET_DVR_PPPCFG;
        /// </summary>
        public struct NET_DVR_PPPCFG
        {
            /// <summary>
            /// 远端IP地址
            ///     public char sRemoteIP[16];
            /// </summary>
            public string sRemoteIP;
            /// <summary>
            /// 本地IP地址
            ///     public char sLocalIP[16];
            /// </summary>
            public string sLocalIP;
            /// <summary>
            /// 本地IP地址掩码
            ///     public char sLocalIPMask[16];
            /// </summary>
            public string sLocalIPMask;
            /// <summary>
            /// 用户名
            ///     public byte sUsername[NAME_LEN];
            /// </summary>
            public string sUsername;
            /// <summary>
            /// 密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
            /// <summary>
            /// PPP模式, 0－主动，1－被动
            /// </summary>
            public byte byPPPMode;
            /// <summary>
            /// 是否回拨 ：0-否,1-是
            /// </summary>
            public byte byRedial;
            /// <summary>
            /// 回拨模式,0-由拨入者指定,1-预置回拨号码
            /// </summary>
            public byte byRedialMode;
            /// <summary>
            /// 数据加密,0-否,1-是
            /// </summary>
            public byte byDataEncrypt;
            /// <summary>
            /// MTU
            /// </summary>
            public uint dwMTU;
            /// <summary>
            /// 电话号码
            ///     public char sTelephoneNumber[PHONENUMBER_LEN];
            /// </summary>
            public string sTelephoneNumber;
        }
        /// <summary>
        /// RS232串口参数配置(9000扩展)
        ///     NET_DVR_SINGLE_RS232;
        /// </summary>
        public struct NET_DVR_SINGLE_RS232
        {
            /// <summary>
            /// 波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            /// </summary>
            public uint dwBaudRate;
            /// <summary>
            /// 数据有几位 0－5位，1－6位，2－7位，3－8位
            /// </summary>
            public byte byDataBit;
            /// <summary>
            /// 停止位 0－1位，1－2位
            /// </summary>
            public byte byStopBit;
            /// <summary>
            /// 校验 0－无校验，1－奇校验，2－偶校验
            /// </summary>
            public byte byParity;
            /// <summary>
            /// 0－无，1－软流控,2-硬流控
            /// </summary>
            public byte byFlowcontrol;
            /// <summary>
            /// 工作模式，0－232串口用于PPP拨号，1－232串口用于参数控制，2－透明通道
            /// </summary>
            public uint dwWorkMode;
        }

        /// <summary>
        /// RS232串口参数配置(9000扩展)
        ///     NET_DVR_RS232CFG_V30, *LPNET_DVR_RS232CFG_V30;
        /// </summary>
        public struct NET_DVR_RS232CFG_V30
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 9016只有一个232串口，采用第一个
            /// </summary>
            public NET_DVR_SINGLE_RS232 struRs232;
            /// <summary>
            /// 保留
            ///     public byte byRes[84]; 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 84)]
            public byte[] byRes;
            /// <summary>
            /// 默认对应第0个通道
            /// </summary>
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }
        /// <summary>
        /// RS232串口参数配置
        ///     注意
        ///         修改RS232串口使用方式后需要重启设备
        ///     NET_DVR_RS232CFG, *LPNET_DVR_RS232CFG;
        /// </summary>
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            /// <summary>
            /// 波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
            /// </summary>
            public uint dwBaudRate;
            /// <summary>
            /// 数据有几位 0－5位，1－6位，2－7位，3－8位;
            /// </summary>
            public byte byDataBit;
            /// <summary>
            /// 停止位 0－1位，1－2位;
            /// </summary>
            public byte byStopBit;
            /// <summary>
            /// 校验 0－无校验，1－奇校验，2－偶校验;
            /// </summary>
            public byte byParity;
            /// <summary>
            /// 0－无，1－软流控,2-硬流控
            /// </summary>
            public byte byFlowcontrol;
            /// <summary>
            /// 工作模式，0－窄带传输(232串口用于PPP拨号)，1－控制台(232串口用于参数控制)，2－透明通道
            /// </summary>
            public uint dwWorkMode;
            /// <summary>
            /// 图像通道参数
            /// </summary>
            public NET_DVR_PPPCFG struPPPConfig;
        }
        #endregion
        #region 报警输入参数配置
        /// <summary>
        /// 报警输入参数(9000扩展)
        ///     NET_DVR_ALARMINCFG_V30, *LPNET_DVR_ALARMINCFG_V30;
        /// </summary>
        public struct NET_DVR_ALARMINCFG_V30
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 名称(32位)
            ///     public byte sAlarmInName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public string sAlarmInName;
            /// <summary>
            /// 报警器类型,0：常开,1：常闭
            /// </summary>
            public byte byAlarmType;
            /// <summary>
            /// 是否处理 0-不处理 1-处理
            /// </summary>
            public byte byAlarmInHandle;
            /// <summary>
            /// 保留
            ///     public byte byRes1[2];	
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes1;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;
            /// <summary>
            /// 布防时间
            ///     NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT_V30];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
            /// <summary>
            /// 报警触发的录象通道,为1表示触发该通道
            ///     public byte byRelRecordChan[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byRelRecordChan;
            /// <summary>
            /// 是否调用预置点 0-否,1-是
            ///     public byte byEnablePreset[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byEnablePreset;
            /// <summary>
            /// 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。
            ///     public byte byPresetNo[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byPresetNo;
            /// <summary>
            /// 保留
            ///     public byte byRes2[192];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
            public byte[] byRes2;
            /// <summary>
            /// 是否调用巡航 0-否,1-是
            ///     public byte byEnableCruise[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byEnableCruise;
            /// <summary>
            /// 巡航
            ///     public byte byCruiseNo[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byCruiseNo;
            /// <summary>
            /// 是否调用轨迹 0-否,1-是
            ///     public byte byEnablePtzTrack[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byEnablePtzTrack;
            /// <summary>
            /// 调用的云台的轨迹序号
            ///     public byte byPTZTrack[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byPTZTrack;
            /// <summary>
            /// 保留
            ///     public byte byRes3[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes3;
        }
        /// <summary>
        /// 报警输入参数配置
        ///     NET_DVR_ALARMINCFG, *LPNET_DVR_ALARMINCFG;
        /// </summary>
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            /// <summary>
            /// 名称
            ///     public byte sAlarmInName[NAME_LEN];
            /// </summary>
            public string sAlarmInName;
            /// <summary>
            /// 报警器类型,0：常开,1：常闭
            /// </summary>
            public byte byAlarmType;
            /// <summary>
            /// 是否处理 0-不处理 1-处理
            /// </summary>
            public byte byAlarmInHandle;
            /// <summary>
            /// 处理方式
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;
            /// <summary>
            /// 布防时间
            ///     NET_DVR_SCHEDTIME struAlarmTime[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmTime;
            /// <summary>
            /// 报警触发的录象通道,为1表示触发该通道
            ///     public byte byRelRecordChan[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byRelRecordChan;
            /// <summary>
            /// 是否调用预置点 0-否,1-是
            ///     public byte byEnablePreset[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byEnablePreset;
            /// <summary>
            /// 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。
            ///     public byte byPresetNo[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byPresetNo;
            /// <summary>
            /// 是否调用巡航 0-否,1-是
            ///     public byte byEnableCruise[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byEnableCruise;
            /// <summary>
            /// 巡航
            ///     public byte byCruiseNo[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byCruiseNo;
            /// <summary>
            /// 是否调用轨迹 0-否,1-是
            ///     public byte byEnablePtzTrack[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byEnablePtzTrack;
            /// <summary>
            /// 调用的云台的轨迹序号
            ///     public byte byPTZTrack[MAX_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM)]
            public byte[] byPTZTrack;
        }
        #endregion
        #region 报警输出参数配置
        /// <summary>
        /// DVR报警输出(9000扩展)
        ///     NET_DVR_ALARMOUTCFG_V30, *LPNET_DVR_ALARMOUTCFG_V30;
        /// </summary>
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            /// <summary>
            /// 名称
            ///     public byte sAlarmOutName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sAlarmOutName;
            /// <summary>
            /// 输出保持时间(-1为无限，手动关闭)
            /// 0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
            /// </summary>
            public uint dwAlarmOutDelay;
            /// <summary>
            /// 报警输出激活时间段
            ///     NET_DVR_SCHEDTIME struAlarmOutTime[MAX_DAYS][MAX_TIMESEGMENT_V30];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmOutTime;
            /// <summary>
            ///     public byte byRes[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes;
        }
        /// <summary>
        /// DVR报警输出
        ///     NET_DVR_ALARMOUTCFG, *LPNET_DVR_ALARMOUTCFG;
        /// </summary>
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            /// <summary>
            /// 名称
            ///     public byte sAlarmOutName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sAlarmOutName;
            /// <summary>
            /// 输出保持时间(-1为无限，手动关闭)
            /// 0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
            /// </summary>
            public uint dwAlarmOutDelay;
            /// <summary>
            /// 报警输出激活时间段
            ///     NET_DVR_SCHEDTIME struAlarmOutTime[MAX_DAYS][MAX_TIMESEGMENT];
            /// </summary>
            public NET_DVR_SCHEDTIME[,] struAlarmOutTime;
        }
        #endregion
        #region 本地预览参数配置
        /// <summary>
        /// DVR本地预览参数(9000扩展)
        ///     NET_DVR_PREVIEWCFG_V30, *LPNET_DVR_PREVIEWCFG_V30;
        /// </summary>
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            /// <summary>
            /// 预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
            /// </summary>
            public byte byPreviewNumber;
            /// <summary>
            /// 是否声音预览,0-不预览,1-预览
            /// </summary>
            public byte byEnableAudio;
            /// <summary>
            /// 切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            /// </summary>
            public ushort wSwitchTime;
            /// <summary>
            /// 切换顺序,如果lSwitchSeq[i]为 0xff表示不用
            ///     public byte bySwitchSeq[MAX_PREVIEW_MODE][MAX_WINDOW_V30];
            /// </summary>
            public byte[,] bySwitchSeq;
            /// <summary>
            ///     public byte byRes[24];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] byRes;
        }
        /// <summary>
        /// DVR本地预览参数
        ///     NET_DVR_PREVIEWCFG, *LPNET_DVR_PREVIEWCFG;
        /// </summary>
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            /// <summary>
            /// 预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
            /// </summary>
            public byte byPreviewNumber;
            /// <summary>
            /// 是否声音预览,0-不预览,1-预览
            /// </summary>
            public byte byEnableAudio;
            /// <summary>
            /// 切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            /// </summary>
            public ushort wSwitchTime;
            /// <summary>
            /// 切换顺序,如果lSwitchSeq[i]为 0xff表示不用
            ///     public byte bySwitchSeq[MAX_WINDOW];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_WINDOW)]
            public byte[] bySwitchSeq;
        }
        #endregion
        #region 视频输出参数配置
        /// <summary>
        /// VideoOut输出参数
        ///     NET_DVR_VOOUT;
        /// </summary>
        public struct NET_DVR_VOOUT
        {
            /// <summary>
            /// 输出制式,0-PAL,1-NTSC
            /// </summary>
            public byte byVideoFormat;
            /// <summary>
            /// 菜单与背景图象对比度
            /// </summary>
            public byte byMenuAlphaValue;
            /// <summary>
            /// 屏幕保护时间 0-从不,1-1分钟,2-2分钟,3-5分钟,4-10分钟,5-20分钟,6-30分钟
            /// </summary>
            public ushort wScreenSaveTime;
            /// <summary>
            /// 视频输出偏移
            /// </summary>
            public ushort wVOffset;
            /// <summary>
            /// 视频输出亮度
            /// </summary>
            public ushort wBrightness;
            /// <summary>
            /// 启动后视频输出模式(0:菜单,1:预览)
            /// </summary>
            public byte byStartMode;
            /// <summary>
            /// 是否启动缩放 (0-不启动, 1-启动)
            /// </summary>
            public byte byEnableScaler;
        }
        /// <summary>
        /// DVR视频输出
        ///     NET_DVR_VGAPARA;
        /// </summary>
        public struct NET_DVR_VGAPARA
        {
            /// <summary>
            /// 分辨率
            /// </summary>
            public ushort wResolution;
            /// <summary>
            /// 刷新频率
            /// </summary>
            public ushort wFreq;
            /// <summary>
            /// 亮度
            /// </summary>
            public uint dwBrightness;
        }
        /// <summary>
        /// MATRIX输出参数结构
        ///     NET_DVR_MATRIXPARA_V30, *LPNET_DVR_MATRIXPARA_V30;
        /// </summary>
        public struct NET_DVR_MATRIXPARA_V30
        {
            /// <summary>
            /// 预览顺序, 0xff表示相应的窗口不预览
            ///     ushort	public ushorter[MAX_ANALOG_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ANALOG_CHANNUM)]
            public ushort[] wOrder;
            /// <summary>
            /// 预览切换时间
            /// </summary>
            public ushort wSwitchTime;
            /// <summary>
            /// 	public byte res[14];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
            public byte[] res;
        }
        /// <summary>
        /// MATRIX输出参数
        ///     NET_DVR_MATRIXPARA;
        /// </summary>
        public struct NET_DVR_MATRIXPARA
        {
            /// <summary>
            /// 显示视频通道号
            /// </summary>
            public ushort wDisplayLogo;
            /// <summary>
            /// 显示时间
            /// </summary>
            public ushort wDisplayOsd;
        }
        /// <summary>
        /// DVR视频输出(9000扩展)
        ///     NET_DVR_VIDEOOUT_V30, *LPNET_DVR_VIDEOOUT_V30;
        /// </summary>
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            /// <summary>
            /// BNC输出接口参数
            ///     NET_DVR_VOOUT struVOOut[MAX_VIDEOOUT_V30];
            /// </summary>
            public NET_DVR_VOOUT[] struVOOut;
            /// <summary>
            /// VGA参数
            ///     NET_DVR_VGAPARA struVGAPara[MAX_VGA_V30];
            /// </summary>
            public NET_DVR_VGAPARA[] struVGAPara;
            /// <summary>
            /// MATRIX参数
            ///     NET_DVR_MATRIXPARA_V30 struMatrixPara[MAX_MATRIXOUT];
            /// </summary>
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;
            /// <summary>
            ///     public byte byRes[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes;
        }
        /// <summary>
        /// DVR视频输出
        ///     NET_DVR_VIDEOOUT, *LPNET_DVR_VIDEOOUT;
        /// </summary>
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            /// <summary>
            /// BNC输出接口参数
            ///     NET_DVR_VOOUT struVOOut[MAX_VIDEOOUT];
            /// </summary>
            public NET_DVR_VOOUT[] struVOOut;
            /// <summary>
            /// VGA参数
            ///     NET_DVR_VGAPARA struVGAPara[MAX_VGA];
            /// </summary>
            public NET_DVR_VGAPARA[] struVGAPara;
            /// <summary>
            /// MATRIX参数
            /// </summary>
            public NET_DVR_MATRIXPARA struMatrixPara;
        }

        #endregion
        #region 用户参数配置
        /// <summary>
        /// 单用户参数(子结构)(9000扩展)
        ///     NET_DVR_USER_INFO_V30, *LPNET_DVR_USER_INFO_V30;
        /// </summary>
        public struct NET_DVR_USER_INFO_V30
        {
            /// <summary>
            /// 用户名
            ///     public byte sUserName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sUserName;
            /// <summary>
            /// 密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
            public byte[] sPassword;
            /// <summary>
            /// 本地权限
            ///     数组0: 本地控制云台
            ///     数组1: 本地手动录象
            ///     数组2: 本地回放
            ///     数组3: 本地设置参数
            ///     数组4: 本地查看状态、日志
            ///     数组5: 本地高级操作(升级，格式化，重启，关机)
            ///     数组6: 本地查看参数
            ///     数组7: 本地管理模拟和IP camera
            ///     数组8: 本地备份
            ///     数组9: 本地关机/重启
            ///     public byte byLocalRight[MAX_RIGHT];
            /// </summary>
            public byte byLocalRight;
            /// <summary>
            /// 远程权限
            ///     数组0: 远程控制云台
            ///     数组1: 远程手动录象
            ///     数组2: 远程回放
            ///     数组3: 远程设置参数
            ///     数组4: 远程查看状态、日志
            ///     数组5: 远程高级操作(升级，格式化，重启，关机)
            ///     数组6: 远程发起语音对讲
            ///     数组7: 远程预览
            ///     数组8: 远程请求报警上传、报警输出
            ///     数组9: 远程控制，本地输出
            ///     数组10: 远程控制串口
            ///     数组11: 远程查看参数
            ///     数组12: 远程管理模拟和IP camera
            ///     数组13: 远程关机/重启
            ///     public byte byRemoteRight[MAX_RIGHT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_RIGHT)]
            public byte[] byRemoteRight;
            /// <summary>
            /// 远程可以预览的通道 0-有权限，1-无权限
            ///     public byte byNetPreviewRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byNetPreviewRight;
            /// <summary>
            /// 本地可以回放的通道 0-有权限，1-无权限
            ///     public byte byLocalPlaybackRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byLocalPlaybackRight;
            /// <summary>
            /// 远程可以回放的通道 0-有权限，1-无权限
            ///     public byte byNetPlaybackRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byNetPlaybackRight;
            /// <summary>
            /// 本地可以录像的通道 0-有权限，1-无权限
            ///     public byte byLocalRecordRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byLocalRecordRight;
            /// <summary>
            /// 远程可以录像的通道 0-有权限，1-无权限
            ///     public byte byNetRecordRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byNetRecordRight;
            /// <summary>
            /// 本地可以PTZ的通道 0-有权限，1-无权限
            ///     public byte byLocalPTZRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byLocalPTZRight;
            /// <summary>
            /// 远程可以PTZ的通道 0-有权限，1-无权限
            ///     public byte byNetPTZRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byNetPTZRight;
            /// <summary>
            /// 本地备份权限通道 0-有权限，1-无权限
            ///     public byte byLocalBackupRight[MAX_CHANNUM_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_CHANNUM_V30)]
            public byte[] byLocalBackupRight;
            /// <summary>
            /// 用户IP地址(为0时表示允许任何地址)
            /// </summary>
            public NET_DVR_IPADDR struUserIP;
            /// <summary>
            /// 物理地址
            ///     public byte byMACAddr[MACADDR_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMACAddr;
            /// <summary>
            /// 优先级，0xff-无，0--低，1--中，2--高
            /// 无……表示不支持优先级的设置
            /// 低……默认权限:包括本地和远程回放,本地和远程查看日志和状态,本地和远程关机/重启
            /// 中……包括本地和远程控制云台,本地和远程手动录像,本地和远程回放,语音对讲和远程预览本地备份,本地/远程关机/重启
            /// 高……管理员
            /// </summary>
            public byte byPriority;
            /// <summary>
            ///     public byte byRes[17];	
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
            public byte[] byRes;
        }
        /// <summary>
        /// 单用户参数(子结构)
        ///     NET_DVR_USER_INFO, *LPNET_DVR_USER_INFO;
        /// </summary>
        public struct NET_DVR_USER_INFO
        {
            /// <summary>
            /// 用户名
            ///     public byte sUserName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sUserName;
            /// <summary>
            /// 密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
            public byte[] sPassword;
            /// <summary>
            /// 本地权限
            ///     数组0: 本地控制云台
            ///     数组1: 本地手动录象
            ///     数组2: 本地回放
            ///     数组3: 本地设置参数
            ///     数组4: 本地查看状态、日志
            ///     数组5: 本地高级操作(升级，格式化，重启，关机)
            ///     public uint dwLocalRight[MAX_RIGHT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_RIGHT)]
            public uint[] dwLocalRight;
            /// <summary>
            /// 远程权限
            ///     数组0: 远程控制云台
            ///     数组1: 远程手动录象
            ///     数组2: 远程回放
            ///     数组3: 远程设置参数
            ///     数组4: 远程查看状态、日志
            ///     数组5: 远程高级操作(升级，格式化，重启，关机)
            ///     数组6: 远程发起语音对讲
            ///     数组7: 远程预览
            ///     数组8: 远程请求报警上传、报警输出
            ///     数组9: 远程控制，本地输出
            ///     数组10: 远程控制串口
            ///     public uint dwRemoteRight[MAX_RIGHT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_RIGHT)]
            public uint[] dwRemoteRight;
            /// <summary>
            /// 用户IP地址(为0时表示允许任何地址)
            ///     public char sUserIP[16];
            /// </summary>
            public string sUserIP;
            /// <summary>
            /// 物理地址
            ///     public byte byMACAddr[MACADDR_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMACAddr;
        }
        /// <summary>
        /// 单用户参数(SDK_V15扩展)(子结构)
        ///     NET_DVR_USER_INFO_EX, *LPNET_DVR_USER_INFO_EX;
        /// </summary>
        public struct NET_DVR_USER_INFO_EX
        {
            /// <summary>
            /// 用户名
            ///     public byte sUserName[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sUserName;
            /// <summary>
            /// 密码
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
            public byte[] sPassword;
            /// <summary>
            /// 权限
            ///     数组0: 本地控制云台
            ///     数组1: 本地手动录象
            ///     数组2: 本地回放
            ///     数组3: 本地设置参数
            ///     数组4: 本地查看状态、日志
            ///     数组5: 本地高级操作(升级，格式化，重启，关机)
            ///     public uint dwLocalRight[MAX_RIGHT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_RIGHT)]
            public uint[] dwLocalRight;
            /// <summary>
            /// 本地可以回放的通道 bit0 -- channel 1
            /// </summary>
            public uint dwLocalPlaybackRight;
            /// <summary>
            /// 权限
            ///     数组0: 远程控制云台
            ///     数组1: 远程手动录象
            ///     数组2: 远程回放
            ///     数组3: 远程设置参数
            ///     数组4: 远程查看状态、日志
            ///     数组5: 远程高级操作(升级，格式化，重启，关机)
            ///     数组6: 远程发起语音对讲
            ///     数组7: 远程预览
            ///     数组8: 远程请求报警上传、报警输出
            ///     数组9: 远程控制，本地输出
            ///     数组10: 远程控制串口
            ///     public uint dwRemoteRight[MAX_RIGHT];
            /// </summary>
            public uint[] dwRemoteRight;
            /// <summary>
            /// 远程可以预览的通道 bit0 -- channel 1
            /// </summary>
            public uint dwNetPreviewRight;
            /// <summary>
            /// 远程可以回放的通道 bit0 -- channel 1
            /// </summary>
            public uint dwNetPlaybackRight;
            /// <summary>
            /// 用户IP地址(为0时表示允许任何地址) 
            ///     public char sUserIP[16];
            /// </summary>
            public string sUserIP;
            /// <summary>
            /// 物理地址
            ///     public byte byMACAddr[MACADDR_LEN]
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MACADDR_LEN)]
            public byte[] byMACAddr;
        }
        /// <summary>
        /// DVR用户参数(9000扩展)
        ///     NET_DVR_USER_V30, *LPNET_DVR_USER_V30;
        /// </summary>
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            /// <summary>
            /// 单用户参数
            ///     NET_DVR_USER_INFO_V30 struUser[MAX_USERNUM_V30];
            /// </summary>
            public NET_DVR_USER_INFO_V30[] struUser;
        }
        /// <summary>
        /// DVR用户参数
        ///     NET_DVR_USER, *LPNET_DVR_USER;
        /// </summary>
        public struct NET_DVR_USER
        {
            public uint dwSize;
            /// <summary>
            ///     NET_DVR_USER_INFO struUser[MAX_USERNUM];
            /// </summary>
            public NET_DVR_USER_INFO[] struUser;
        }
        /// <summary>
        /// DVR用户参数(SDK_V15扩展)
        ///     NET_DVR_USER_EX, *LPNET_DVR_USER_EX;
        /// </summary>
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            /// <summary>
            ///     NET_DVR_USER_INFO_EX struUser[MAX_USERNUM];
            /// </summary>
            public NET_DVR_USER_INFO_EX[] struUser;
        }
        #endregion
        #region 异常参数配置
        /// <summary>
        /// DVR异常参数(9000扩展)
        ///     NET_DVR_EXCEPTION_V30, *LPNET_DVR_EXCEPTION_V30;
        /// </summary>
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            /// <summary>
            /// 数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突, 4-非法访问, 9-输入/输出视频制式不匹配, 10-视频信号异常
            ///     public NET_DVR_HANDLEEXCEPTION_V30 struExceptionHandleType[MAX_EXCEPTIONNUM_V30];
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
        }
        /// <summary>
        /// DVR异常参数
        ///     NET_DVR_EXCEPTION, *LPNET_DVR_EXCEPTION;
        /// </summary>
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            /// <summary>
            /// 数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突,4-非法访问, 5-视频信号异常, 6-输入/输出视频制式不匹配
            ///     NET_DVR_HANDLEEXCEPTION struExceptionHandleType[MAX_EXCEPTIONNUM];
            /// </summary>
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
        }
        #endregion
        #region 时区和夏时制参数配置
        /// <summary>
        /// 夏令时参数
        ///     NET_DVR_ZONEANDDST, *LPNET_DVR_ZONEANDDST;
        /// </summary>
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            /// <summary>
            /// 保留
            ///     public byte byRes1[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes1;
            /// <summary>
            /// 是否启用夏时制 0－不启用 1－启用
            /// </summary>
            public uint dwEnableDST;
            /// <summary>
            /// 夏令时偏移值，30min, 60min, 90min, 120min, 以分钟计，传递原始数值
            /// </summary>
            public byte byDSTBias;
            /// <summary>
            ///     public byte byRes2[3];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes2;
            /// <summary>
            /// 夏时制开始时间
            /// </summary>
            public NET_DVR_TIMEPOINT struBeginPoint;
            /// <summary>
            /// 夏时制停止时间
            /// </summary>
            public NET_DVR_TIMEPOINT struEndPoint;
        }
        /// <summary>
        /// 时间点
        ///     NET_DVR_TIMEPOINT;
        /// </summary>
        public struct NET_DVR_TIMEPOINT
        {
            /// <summary>
            /// 月 0-11表示1-12个月
            /// </summary>
            public uint dwMonth;
            /// <summary>
            /// 第几周 0－第1周 1－第2周 2－第3周 3－第4周 4－最后一周
            /// </summary>
            public uint dwWeekNo;
            /// <summary>
            /// 星期几 0－星期日 1－星期一 2－星期二 3－星期三 4－星期四 5－星期五 6－星期六
            /// </summary>
            public uint dwWeekDate;
            /// <summary>
            /// 小时	开始时间0－23 结束时间1－23
            /// </summary>
            public uint dwHour;
            /// <summary>
            /// 分	0－59
            /// </summary>
            public uint dwMin;
        }

        #endregion
        #region 字符叠加参数配置
        /// <summary>
        /// 字符叠加参数子结构
        ///     单字符参数(子结构)
        ///     NET_DVR_SHOWSTRINGINFO, *LPNET_DVR_SHOWSTRINGINFO;
        /// </summary>
        public struct NET_DVR_SHOWSTRINGINFO
        {
            /// <summary>
            /// 预览的图象上是否显示字符,0-不显示,1-显示 区域大小704*576,单个字符的大小为32*32
            /// </summary>
            public ushort wShowString;
            /// <summary>
            /// 该行字符的长度，不能大于44个字符
            /// </summary>
            public ushort wStringSize;
            /// <summary>
            /// 字符显示位置的x坐标
            /// </summary>
            public ushort wShowStringTopLeftX;
            /// <summary>
            /// 字符名称显示位置的y坐标
            /// </summary>
            public ushort wShowStringTopLeftY;
            /// <summary>
            /// 要显示的字符内容
            ///     char sString[44];
            /// </summary>
            public string sString;
        }
        /// <summary>
        /// 字符叠加参数
        ///     叠加字符(9000扩展)
        ///     NET_DVR_SHOWSTRING_V30, *LPNET_DVR_SHOWSTRING_V30;
        /// </summary>
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            /// <summary>
            /// 要显示的字符内容
            ///     NET_DVR_SHOWSTRINGINFO struStringInfo[MAX_STRINGNUM_V30];
            /// </summary>
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
        }
        /// <summary>
        /// 叠加字符
        ///     NET_DVR_SHOWSTRING, *LPNET_DVR_SHOWSTRING;
        /// </summary>
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            /// <summary>
            /// 要显示的字符内容
            ///     NET_DVR_SHOWSTRINGINFO struStringInfo[MAX_STRINGNUM];
            /// </summary>
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
        }
        /// <summary>
        /// 叠加字符扩展(8条字符)
        ///     NET_DVR_SHOWSTRING_EX, *LPNET_DVR_SHOWSTRING_EX;
        /// </summary>
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            /// <summary>
            /// 要显示的字符内容
            ///     NET_DVR_SHOWSTRINGINFO struStringInfo[MAX_STRINGNUM_EX];
            /// </summary>
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;
        }
        #endregion
        #region 报警触发辅助输出参数配置
        /// <summary>
        /// 报警辅助输出[!HCNetSDK.h中并未定义此函数]
        ///     NET_DVR_AUXOUTCFG_V30, *LPNET_DVR_AUXOUTCFG_V30;
        /// </summary>
        public struct NET_DVR_AUXOUTCFG_V30
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 选择报警弹出大画面的输出通道：0－主输出；1－辅1；2－辅2；3－辅3；4－辅4 
            /// </summary>
            public uint dwAlarmOutChan;
            /// <summary>
            /// 通道切换时间：1（秒）～10（秒）
            /// </summary>
            public uint dwAlarmChanSwitchTime;
            /// <summary>
            /// 辅助输出切换时间：0－不切换；1－5s；2－10s；3－20s；4－30s；5－60s；6－120s；7－300s
            ///     DWORD  dwAuxSwitchTime[MAX_AUXOUT_V30];  
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_AUXOUT_V30)]
            public uint[] dwAuxSwitchTime;
            /// <summary>
            /// 辅助输出预览顺序, 0xff表示相应的窗口不预览
            ///     BYTE   byAuxOrder[MAX_AUXOUT_V30][MAX_WINDOW];
            /// </summary>
            public byte[,] byAuxOrder;
            /// <summary>
            ///     BYTE   byRes[24];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] byRes;
        }
        /// <summary>
        /// 报警辅助输出(HS设备)
        ///     NET_DVR_AUXOUTCFG, *LPNET_DVR_AUXOUTCFG;
        /// </summary>
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            /// <summary>
            /// 选择报警弹出大报警通道切换时间：1画面的输出通道: 0:主输出/1:辅1/2:辅2/3:辅3/4:辅4
            /// </summary>
            public uint dwAlarmOutChan;
            /// <summary>
            /// 报警通道切换时间，取值范围1（秒）～10（秒）
            /// </summary>
            public uint dwAlarmChanSwitchTime;
            /// <summary>
            /// 辅助输出切换时间: 0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            ///     public uint dwAuxSwitchTime[MAX_AUXOUT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_AUXOUT)]
            public uint[] dwAuxSwitchTime;
            /// <summary>
            /// 辅助输出预览顺序, 0xff表示相应的窗口不预览
            ///     public byte  byAuxOrder[MAX_AUXOUT][MAX_WINDOW];
            /// </summary>
            public byte[,] byAuxOrder;
        }

        #endregion
        #region 网络应用参数配置
        //注意:修改DDNS、NTP和EMAIL参数后需要重启设备

        /// <summary>
        /// 网络校时NTP
        ///     NET_DVR_NTPPARA, *LPNET_DVR_NTPPARA;
        ///     cTimeDifferenceH和cTimeDifferenceM 为时区与UTC（协调世界时）之间的时分偏移
        ///     GMT（格林尼治平时）列表如下：
        ///     0--GMT-12:00,1--GMT-11:00,2--GMT-10:00,3--GMT-9:00,4--GMT-8:00,5--GMT-7:00,6--GMT-6:00,7--GMT-5:00,8--GMT-4:30,9--GMT-4:00,10--GMT-3:30,11--GMT-3:00,12--GMT-2:00,13--GMT-1:00,14--GMT-0:00,
        ///     15--GMT+1:00,16--GMT+2:00,17--GMT+3:00,18--GMT+3:30,19--GMT+4:00,20--GMT+4:30,21--GMT+5:00,22--GMT+5:30,23--GMT+5:45,24--GMT+6:00,25--GMT+6:30,26--GMT+7:00,27--GMT+8:00,28--GMT+9:00,29--GMT+9:30,30--GMT+10:00,31--GMT+11:00,32--GMT+12:00,33--GMT+13:00
        ///     用户可以创建自己的索引,如美国的可以如下：
        ///     0--AST -04:00 大西洋标准时间
        ///     1--EST -05:00 东部标准时间
        ///     2--CST -06:00 中部标准时间
        ///     3--MST -07:00 山区标准时间
        ///     4--PST -08:00 太平洋标准时间
        ///     5--AKST-09:00 阿拉斯加标准时间 
        ///     6--HST -10:00 夏威夷标准时间
        /// </summary>
        public struct NET_DVR_NTPPARA
        {
            /// <summary>
            /// 计算机时间同步化协议，NTP服务器域名或者IP地址
            ///     public byte sNTPServer[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] sNTPServer;
            /// <summary>
            /// 校时间隔时间adjust time interval(hours)
            /// </summary>
            public ushort wInterval;
            /// <summary>
            /// NPT校时是否启用： 0－否；1－是
            /// </summary>
            public byte byEnableNTP;
            /// <summary>
            /// 与国际标准时间的 小时偏移-12 ... +13
            ///     signed char 有符号的char，取值范围是-128到127
            ///     signed char cTimeDifferenceH;
            /// </summary>   
            public sbyte cTimeDifferenceH;
            /// <summary>
            /// 与国际标准时间的 分钟偏移0, 30, 45
            /// </summary>
            public sbyte cTimeDifferenceM;
            /// <summary>
            /// 保留
            /// </summary>
            public byte res1;
            /// <summary>
            /// ntp server port （9000新增），设备默认为123
            /// </summary>
            public ushort wNtpPort;
            /// <summary>
            ///     public byte res2[8];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] res2;
        }
        /// <summary>
        /// 域名解析，9000扩展
        ///     NET_DVR_DDNSPARA_V30, *LPNET_DVR_DDNSPARA_V30;
        /// </summary>
        public struct NET_DVR_DDNSPARA_V30
        {
            /// <summary>
            /// 是否启用
            /// </summary>
            public byte byEnableDDNS;
            /// <summary>
            /// 0-Hikvision DNS(保留) 1－Dyndns 2－PeanutHull(花生壳) 3-希网3322
            /// </summary>
            public byte byHostIndex;
            /// <summary>
            /// 保留参数
            ///     public byte byRes1[2];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byRes1;
            /// <summary>
            /// public byte byRes2[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes2;
            /// <summary>
            /// struDDNS[MAX_DDNS_NUMS];
            /// </summary>
            public DDNS[] struDDNS;
            #region struct
            /*
            struct
            {    
                public byte sUsername[NAME_LEN];			// DDNS账号用户名
                public byte sPassword[PASSWD_LEN];			// 密码
                public byte sDomainName[MAX_DOMAIN_NAME];	// 设备配备的域名地址
                public byte sServerName[MAX_DOMAIN_NAME];	// DDNS协议对应的服务器地址，可以是IP地址或域名
                public ushort wDDNSPort;						// 端口号
                public byte byRes[10];
            } struDDNS[MAX_DDNS_NUMS];
            */
            public struct DDNS
            {
                /// <summary>
                /// DDNS账号用户名
                ///     public byte sUsername[NAME_LEN];
                /// </summary>
                public string sUsername;
                /// <summary>
                /// 密码
                ///     public byte sPassword[PASSWD_LEN];
                /// </summary>
                public string sPassword;
                /// <summary>
                /// 设备配备的域名地址
                ///     public byte sDomainName[MAX_DOMAIN_NAME];
                /// </summary>
                public string sDomainName;
                /// <summary>
                /// DDNS协议对应的服务器地址，可以是IP地址或域名
                ///     public byte sServerName[MAX_DOMAIN_NAME];
                /// </summary>
                public string sServerName;
                /// <summary>
                /// 端口号
                /// </summary>
                public ushort wDDNSPort;
                /// <summary>
                ///     public byte byRes[10];
                /// </summary>
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
                public byte[] byRes;
            }

            #endregion
        }
        /// <summary>
        /// 域名解析
        ///     NET_DVR_DDNSPARA, *LPNET_DVR_DDNSPARA;
        /// </summary>
        public struct NET_DVR_DDNSPARA
        {
            /// <summary>
            /// 动态域名解析，DDNS账号用户名
            ///     public byte sUsername[NAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.NAME_LEN)]
            public byte[] sUsername;
            /// <summary>
            /// DDNS账号密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PASSWD_LEN)]
            public byte[] sPassword;
            /// <summary>
            /// 动态域名
            ///     public byte sDomainName[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] sDomainName;
            /// <summary>
            /// DDNS是否应用：0－否；1－是
            /// </summary>
            public byte byEnableDDNS;
            /// <summary>
            ///     public byte res[15];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] res;
        }
        /// <summary>
        /// 域名解析
        ///     NET_DVR_DDNSPARA_EX, *LPNET_DVR_DDNSPARA_EX;
        /// </summary>
        public struct NET_DVR_DDNSPARA_EX
        {
            /// <summary>
            /// 域名解析类型：0－Hikvision DNS；1－Dyndns； 2－PeanutHull（花生壳）；3—希网3322
            /// </summary>
            public byte byHostIndex;
            /// <summary>
            /// DDNS是否应用：0－否；1－是
            /// </summary>
            public byte byEnableDDNS;
            /// <summary>
            /// DDNS端口号
            /// </summary>
            public ushort wDDNSPort;
            /// <summary>
            /// DDNS用户名
            ///     public byte sUsername[NAME_LEN];
            /// </summary>
            public string sUsername;
            /// <summary>
            /// DDNS密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
            /// <summary>
            /// 设备配备的域名地址
            ///     public byte sDomainName[MAX_DOMAIN_NAME];
            /// </summary>
            public string sDomainName;
            /// <summary>
            /// DDNS 对应的服务器地址，可以是IP地址或域名
            ///     public byte sServerName[MAX_DOMAIN_NAME];
            /// </summary>
            public string sServerName;
            /// <summary>
            ///     public byte byRes[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byRes;
        }
        /// <summary>
        /// 网络应用配置（NTP、DDNS）
        ///     NET_DVR_NETAPPCFG, *LPNET_DVR_NETAPPCFG;
        /// </summary>
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            /// <summary>
            /// DNS服务器地址
            ///     char  sDNSIp[16];
            /// </summary>
            public string sDNSIp;
            /// <summary>
            /// NTP参数
            /// </summary>
            public NET_DVR_NTPPARA struNtpClientParam;
            /// <summary>
            /// DDNS参数
            /// </summary>
            public NET_DVR_DDNSPARA struDDNSClientParam;
            /// <summary>
            /// 保留
            ///     public byte res[464];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 464)]
            public byte[] res;
        }
        /// <summary>
        /// EMAIL参数结构
        ///     NET_DVR_EMAILCFG_V30, *LPNET_DVR_EMAILCFG_V30;
        /// </summary>
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            /// <summary>
            /// 账号
            ///     public byte sAccount[NAME_LEN];
            /// </summary>
            public string sAccount;
            /// <summary>
            /// 密码
            ///     public byte sPassword[MAX_EMAIL_PWD_LEN];
            /// </summary>
            public string sPassword;
            public Sender struSender;
            /// <summary>
            /// smtp服务器
            ///     public byte sSmtpServer[MAX_EMAIL_ADDR_LEN];
            /// </summary>
            public string sSmtpServer;
            /// <summary>
            /// pop3服务器
            ///     public byte sPop3Server[MAX_EMAIL_ADDR_LEN];
            /// </summary>
            public string sPop3Server;
            /// <summary>
            /// 最多可以设置3个收件人
            /// </summary>
            public Receiver[] struReceiver;
            /// <summary>
            /// 是否带附件
            /// </summary>
            public byte byAttachment;
            /// <summary>
            /// 发送服务器要求身份验证
            /// </summary>
            public byte bySmtpServerVerify;
            /// <summary>
            /// mail interval，0－2秒；1－3秒；2－4秒；3－5秒
            /// </summary>
            public byte byMailInterval;
            /// <summary>
            ///     public byte        res[77];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 77)]
            public byte[] res;

            #region struct

            /// <summary>
            /// struct
            /// {
            /// 	public byte	sName[NAME_LEN];				/* 收件人姓名 */
            ///     public byte	sAddress[MAX_EMAIL_ADDR_LEN];		/* 收件人地址 */
            /// }struReceiver[3];		
            /// </summary>
            public struct Receiver
            {
                /// <summary>
                /// 收件人姓名
                ///     public byte	sName[NAME_LEN];
                /// </summary>
                public string sName;
                /// <summary>
                /// 收件人地址
                ///     public byte	sAddress[MAX_EMAIL_ADDR_LEN];
                /// </summary>
                public string sAddress;
            }

            /// <summary>
            /// 	struct
            /// 	{
            /// 	    public byte	sName[NAME_LEN];				/* 发件人姓名 */
            /// 	    public byte	sAddress[MAX_EMAIL_ADDR_LEN];		/* 发件人地址 */
            /// 	}struSender;
            /// </summary>
            public struct Sender
            {
                /// <summary>
                /// 发件人姓名
                ///     public byte	sName[NAME_LEN];
                /// </summary>
                public string sName;
                /// <summary>
                /// 发件人地址
                ///     public byte	sAddress[MAX_EMAIL_ADDR_LEN];
                /// </summary>
                public string sAddress;
            }

            #endregion
        }
        /// <summary>
        /// 电子邮件
        ///     NET_DVR_EMAILCFG, *LPNET_DVR_EMAILCFG;
        /// </summary>
        public struct NET_DVR_EMAILCFG
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;/* 12 bytes */
            /// <summary>
            /// Email用户名
            ///     char	sUserName[32];
            /// </summary>
            public string sUserName;
            /// <summary>
            /// Email密码
            ///     char 	sPassWord[32];
            /// </summary>
            public string sPassWord;
            /// <summary>
            /// 发件人Sender 
            ///     char 	sFromName[32];
            /// </summary>
            public string sFromName;
            /// <summary>
            /// 件人地址Sender address，字符串中的第一个字符和最后一个字符不能是"@",并且字符串中要有"@"字符
            ///     char 	sFromAddr[48];
            /// </summary>
            public string sFromAddr;
            /// <summary>
            /// 收件人1
            ///     char 	sToName1[32];
            /// </summary>
            public string sToName1;
            /// <summary>
            /// 收件人2
            ///     char 	sToName2[32];
            /// </summary>
            public string sToName2;
            /// <summary>
            /// 收件人地址1
            ///     public char 	sToAddr1[48];
            /// </summary>
            public string sToAddr1;
            /// <summary>
            /// 收件人地址2
            ///     char 	sToAddr2[48];
            /// </summary>
            public string sToAddr2;
            /// <summary>
            /// Email服务器地址
            ///     char	sEmailServer[32];
            /// </summary>
            public string sEmailServer;
            /// <summary>
            /// mail服务器类型server type：0－SMTP, 1-POP, 2-IMTP…
            /// </summary>
            public byte byServerType;
            /// <summary>
            /// 是否启动Email服务器验证server authentication method：1－是；0－否
            /// </summary>
            public byte byUseAuthen;
            /// <summary>
            /// enable attachment
            /// </summary>
            public byte byAttachment;
            /// <summary>
            /// mail interval：0－2秒；1－3秒；2－4秒；3－5秒
            /// </summary>
            public byte byMailinterval;
        }
        #endregion
        #region 网络文件系统参数配置
        /// <summary>
        /// NFS配置子结构
        ///     NET_DVR_SINGLE_NFS, *LPNET_DVR_SINGLE_NFS;
        /// </summary>
        public struct NET_DVR_SINGLE_NFS
        {
            /// <summary>
            /// 网络文件系统主机IP地址
            ///     char sNfsHostIPAddr[16];
            /// </summary>
            public string sNfsHostIPAddr;
            /// <summary>
            /// NFS路径，PATHNAME_LEN = 128
            ///     public byte sNfsDirectory[PATHNAME_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.PATHNAME_LEN)]
            public byte[] sNfsDirectory;
        }
        /// <summary>
        /// 网络文件系统参数
        ///     NET_DVR_NFSCFG, *LPNET_DVR_NFSCFG;
        /// </summary>
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            /// <summary>
            ///     NET_DVR_SINGLE_NFS struNfsDiskParam[MAX_NFS_DISK];
            /// </summary>
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;
        }
        #endregion
        #region IP设备接入资源参数配置
        /// <summary>
        /// IP设备结构
        ///     NET_DVR_IPDEVINFO, *LPNET_DVR_IPDEVINFO;
        /// </summary>
        public struct NET_DVR_IPDEVINFO
        {
            /// <summary>
            /// 该IP设备是否启用
            /// </summary>
            public uint dwEnable;
            /// <summary>
            /// 用户名
            ///     public byte sUserName[NAME_LEN];
            /// </summary>
            public string sUserName;
            /// <summary>
            /// 密码
            ///     public byte sPassword[PASSWD_LEN];
            /// </summary>
            public string sPassword;
            /// <summary>
            /// IP地址
            /// </summary>
            public NET_DVR_IPADDR struIP;
            /// <summary>
            /// 端口号
            /// </summary>
            public ushort wDVRPort;
            /// <summary>
            /// 保留
            ///     public byte byRes[34];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 34)]
            public byte[] byRes;
        }
        /// <summary>
        /// IP通道匹配参数
        ///     NET_DVR_IPCHANINFO, *LPNET_DVR_IPCHANINFO;
        /// </summary>
        public struct NET_DVR_IPCHANINFO
        {
            /// <summary>
            /// 0表示9000设备的数字通道连接对应的IPC或DVS失败，该通道不在线；1表示连接成功，该通道在线
            /// </summary>
            public byte byEnable;
            /// <summary>
            /// IP设备ID 取值1- MAX_IP_DEVICE
            /// </summary>
            public byte byIPID;
            /// <summary>
            /// 通道号
            /// </summary>
            public byte byChannel;
            /// <summary>
            /// 保留
            ///     public byte byRes[33];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public byte[] byRes;
        }
        /// <summary>
        /// IP设备资源及IP通道资源
        ///     IP接入配置结构
        ///     NET_DVR_IPPARACFG, *LPNET_DVR_IPPARACFG;
        /// </summary>
        public struct NET_DVR_IPPARACFG
        {
            /// <summary>
            /// 结构大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// IP设备
            ///     NET_DVR_IPDEVINFO  struIPDevInfo[MAX_IP_DEVICE];
            /// </summary>
            public NET_DVR_IPDEVINFO[] struIPDevInfo;
            /// <summary>
            /// 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效
            ///     public byte byAnalogChanEnable[MAX_ANALOG_CHANNUM];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ANALOG_CHANNUM)]
            public byte[] byAnalogChanEnable;
            /// <summary>
            /// IP通道
            ///     NET_DVR_IPCHANINFO struIPChanInfo[MAX_IP_CHANNEL];
            /// </summary>
            public NET_DVR_IPCHANINFO[] struIPChanInfo;
        }
        /// <summary>
        /// 报警输入参数
        ///     NET_DVR_IPALARMININFO, *LPNET_DVR_IPALARMININFO;
        /// </summary>
        public struct NET_DVR_IPALARMININFO
        {
            /// <summary>
            /// IP设备ID取值1- MAX_IP_DEVICE
            /// </summary>
            public byte byIPID;
            /// <summary>
            /// 报警输入号
            /// </summary>
            public byte byAlarmIn;
            /// <summary>
            /// 保留
            ///     public byte byRes[18];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public byte[] byRes;
        }
        /// <summary>
        /// IP报警输入配置结构
        ///     NET_DVR_IPALARMINCFG, *LPNET_DVR_IPALARMINCFG;
        /// </summary>
        public struct NET_DVR_IPALARMINCFG
        {
            /// <summary>
            /// 结构大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// IP报警输入
            ///     NET_DVR_IPALARMININFO struIPAlarmInInfo[MAX_IP_ALARMIN];
            /// </summary>
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;
        }
        /// <summary>
        /// 报警输出参数
        ///     NET_DVR_IPALARMOUTINFO, *LPNET_DVR_IPALARMOUTINFO;
        /// </summary>
        public struct NET_DVR_IPALARMOUTINFO
        {
            /// <summary>
            /// IP设备ID取值1- MAX_IP_DEVICE
            /// </summary>
            public byte byIPID;
            /// <summary>
            /// 报警输出号
            /// </summary>
            public byte byAlarmOut;
            /// <summary>
            /// 保留
            ///     public byte byRes[18];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public byte[] byRes;
        }
        /// <summary>
        /// IP报警输出配置结构
        ///     NET_DVR_IPALARMOUTCFG, *LPNET_DVR_IPALARMOUTCFG;
        /// </summary>
        public struct NET_DVR_IPALARMOUTCFG
        {
            /// <summary>
            /// 结构大小
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// IP报警输出
            ///     NET_DVR_IPALARMOUTINFO struIPAlarmOutInfo[MAX_IP_ALARMOUT];
            /// </summary>
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;
        }

        //注意
        //1.IP报警输入资源、IP报警输出资源：只读，9000设备从IP设备资源获取对应的报警参数后进行紧凑排列，然后传给设备。
        //2.IP报警输入资源的下标索引值（0到MAX_IP_ALARMIN -1）加上MAX_ANALOG_ALARMIN对应的是报警输出相关参数（报警输出配置结构等）的下标索引值（MAX_ANALOG_ALARMIN到MAX_ALARMIN_V30-1）。
        //3.IP报警输出资源的下标索引值（0到MAX_IP_ALARMOUT -1）加上MAX_ANALOG_ALARMOUT对应的是报警输出相关参数（报警输出配置结构、联动触发报警输出等）的下标索引值（MAX_ANALOG_ALARMOUT到MAX_ALARMOUT_V30-1）。

        #endregion
        #region 硬盘参数配置
        /// <summary>
        /// 本地硬盘信息配置
        ///     NET_DVR_SINGLE_HD, *LPNET_DVR_SINGLE_HD;
        /// </summary>
        public struct NET_DVR_SINGLE_HD
        {
            /// <summary>
            /// 硬盘号, 取值0~MAX_DISKNUM_V30-1
            /// </summary>
            public uint dwHDNo;
            /// <summary>
            /// 硬盘容量(不可设置)
            /// </summary>
            public uint dwCapacity;
            /// <summary>
            /// 硬盘剩余空间(不可设置)
            /// </summary>
            public uint dwFreeSpace;
            /// <summary>
            /// 硬盘状态(不可设置) 0-正常, 1-未格式化, 2-错误, 3-SMART状态, 4-不匹配, 5-休眠
            /// </summary>
            public uint dwHdStatus;
            /// <summary>
            /// 0-默认, 1-冗余; 2-只读
            /// </summary>
            public byte byHDAttr;
            /// <summary>
            /// 保留参数
            ///     public byte  byRes1[3];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes1;
            /// <summary>
            /// 属于哪个盘组 1-MAX_HD_GROUP
            /// </summary>
            public uint dwHdGroup;
            /// <summary>
            /// 保留
            ///     public byte  byRes2[120];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
            public byte[] byRes2;
        }
        /// <summary>
        /// 本地硬盘信息配置
        ///     NET_DVR_HDCFG, *LPNET_DVR_HDCFG;
        /// </summary>
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            /// <summary>
            /// 硬盘数(不可设置)
            /// </summary>
            public uint dwHDCount;
            /// <summary>
            /// 硬盘相关操作都需要重启才能生效
            ///     NET_DVR_SINGLE_HD struHDInfo[MAX_DISKNUM_V30];
            /// </summary>
            public NET_DVR_SINGLE_HD[] struHDInfo;
        }

        /// <summary>
        /// 单个盘组信息
        ///     NET_DVR_SINGLE_HDGROUP, *LPNET_DVR_SINGLE_HDGROUP;
        /// </summary>
        public struct NET_DVR_SINGLE_HDGROUP
        {
            /// <summary>
            /// 盘组号(不可设置) 1-MAX_HD_GROUP
            /// </summary>
            public uint dwHDGroupNo;
            /// <summary>
            /// 盘组对应的录像通道, 0-表示该通道不录象到该盘组，1-表示录象到该盘组
            ///     public byte byHDGroupChans[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] byHDGroupChans;
            /// <summary>
            ///     public byte byRes[8];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] byRes;
        }
        /// <summary>
        /// 本地盘组信息配置
        ///     NET_DVR_HDGROUP_CFG, *LPNET_DVR_HDGROUP_CFG;
        /// </summary>
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            /// <summary>
            /// 盘组总数(不可设置)
            /// </summary>
            public uint dwHDGroupCount;
            /// <summary>
            /// 硬盘相关操作都需要重启才能生效
            ///     NET_DVR_SINGLE_HDGROUP struHDGroupAttr[MAX_HD_GROUP];
            /// </summary>
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;
        }
        #endregion
        #region 球机位置信息
        /// <summary>
        /// 球机位置信息
        ///     NET_DVR_PTZPOS, *LPNET_DVR_PTZPOS;
        /// </summary>
        public struct NET_DVR_PTZPOS
        {
            /// <summary>
            /// 获取时该字段无效
            /// </summary>
            public ushort wAction;
            /// <summary>
            /// 水平参数
            /// </summary>
            public ushort wPanPos;
            /// <summary>
            /// 垂直参数
            /// </summary>
            public ushort wTiltPos;
            /// <summary>
            /// 变倍参数
            /// </summary>
            public ushort wZoomPos;
        }
        #endregion
        #region 球机参数范围
        /// <summary>
        /// 球机范围信息
        ///     NET_DVR_PTZSCOPE, *LPNET_DVR_PTZSCOPE;
        /// </summary>
        public struct NET_DVR_PTZSCOPE
        {
            /// <summary>
            /// 水平参数min
            /// </summary>
            public ushort wPanPosMin;
            /// <summary>
            /// 水平参数max
            /// </summary>
            public ushort wPanPosMax;
            /// <summary>
            /// 垂直参数min
            /// </summary>
            public ushort wTiltPosMin;
            /// <summary>
            /// 垂直参数max
            /// </summary>
            public ushort wTiltPosMax;
            /// <summary>
            /// 变倍参数min
            /// </summary>
            public ushort wZoomPosMin;
            /// <summary>
            /// 变倍参数max
            /// </summary>
            public ushort wZoomPosMax;
        }
        #endregion
        #region 巡航参数
        /// <summary>
        /// DVR实现巡航数据结构
        ///     NET_DVR_CRUISE_PARA, *LPNET_DVR_CRUISE_PARA; 
        /// </summary>
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            /// <summary>
            /// 预置点号
            ///     public byte	byPresetNo[CRUISE_MAX_PRESET_NUMS];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.CRUISE_MAX_PRESET_NUMS)]
            public byte[] byPresetNo;
            /// <summary>
            /// 巡航速度
            ///     public byte 	byCruiseSpeed[CRUISE_MAX_PRESET_NUMS];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.CRUISE_MAX_PRESET_NUMS)]
            public byte[] byCruiseSpeed;
            /// <summary>
            /// 停留时间
            ///     public ushort	wDwellTime[CRUISE_MAX_PRESET_NUMS];
            /// </summary>
            public ushort[] wDwellTime;
            /// <summary>
            /// 是否启用
            /// </summary>
            public byte byEnableThisCruise;
            /// <summary>
            ///     public byte	res[15];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] res;
        }
        #endregion
        #endregion
        #endregion
        #region 特定函数参数配置
        #region 报警输出设置
        #region 报警输出设置
        /// <summary>
        /// 设置报警输出
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetAlarmOut(LONG lUserID, LONG lAlarmOutPort,LONG lAlarmOutStatic);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lAlarmOutPort">[in] 报警输出端口,从0开始,0x00ff表示全部模拟输出,0xff00表示全部数字输出，9000同时支持对IP接入的报警输出进行处理处理，对应32-95为数字报警输出</param>
        /// <param name="lAlarmOutStatic">[in]报警输出状态：0－停止输出；1－输出</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);
        /// <summary>
        /// 获取报警输出
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetAlarmOut_V30(LONG lUserID, LPNET_DVR_ALARMOUTSTATUS_V30 lpAlarmOutState);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_30的返回值</param>
        /// <param name="lpAlarmOutState">[in]指向NET_DVR_ALARMOUTSTATUS_V30结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, NET_DVR_ALARMOUTSTATUS_V30 lpAlarmOutState);
        /// <summary>
        /// 获取报警输出
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetAlarmOut(LONG lUserID, LPNET_DVR_ALARMOUTSTATUS lpAlarmOutState);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_30的返回值</param>
        /// <param name="lpAlarmOutState">[in]指向NET_DVR_ALARMOUTSTATUS结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, NET_DVR_ALARMOUTSTATUS lpAlarmOutState);
        #endregion
        #region 报警输出状态
        /// <summary>
        /// 报警输出状态(9000扩展)
        ///     NET_DVR_ALARMOUTSTATUS_V30, *LPNET_DVR_ALARMOUTSTATUS_V30;
        /// </summary>
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            /// <summary>
            /// 报警输出的状态：0－无效；1－有效
            /// 	public byte Output[MAX_ALARMOUT_V30];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT_V30)]
            public byte[] Output;
        }

        /// <summary>
        /// 报警输出状态
        ///     NET_DVR_ALARMOUTSTATUS, *LPNET_DVR_ALARMOUTSTATUS;
        /// </summary>
        public struct NET_DVR_ALARMOUTSTATUS
        {
            /// <summary>
            /// 报警输出的状态：0－无效；1－有效
            /// 	public byte Output[MAX_ALARMOUT];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.MAX_ALARMOUT)]
            public byte[] Output;
        }
        #endregion
        #endregion
        #region IP快球参数配置
        #region IP快球参数配置
        /// <summary>
        /// 云台图象区域选择放大或缩小
        ///     规定：假设当前预览显示图像的框为352*288，原点即该显示框的左上角的顶点。参数pStruPointFrame中各坐标值的计算方法
        ///     （以X轴方向上为例）：xTop=鼠标当前所选区域的左上点的值*255/352。缩小条件：xBottom减去xTop的值大于2。
        ///     放大条件：xBottom减去xTop的值大于0，且yBottom减去yTop的值大于0。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZSelZoomIn(LONG lRealHandle, LPNET_DVR_POINT_FRAME pStruPointFrame);
        /// </summary>
        /// <param name="lRealHandle">[in]NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
        /// <param name="pStruPointFrame">[in]指向NET_DVR_POINT_FRAME结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, NET_DVR_POINT_FRAME pStruPointFrame);
        /// <summary>
        /// 云台图象区域选择放大或缩小
        ///     规定：原点为图像的左上角的顶点，参数pStruPointFrame中的坐标值是原图像框的绝对值/255所得。
        ///     缩小条件：x的结束坐标/255减去x的起始坐标/255的值大于2。
        ///     放大条件：x的结束坐标/255减去x的起始坐标/255的值大于0，且y的结束坐标/255减去y的起始坐标/255的值大于0。
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZSelZoomIn_EX(LONG lUserID, LONG lChannel, LPNET_DVR_POINT_FRAME pStruPointFrame);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lChannel">[in]通道号</param>
        /// <param name="pStruPointFrame">[in]指向NET_DVR_POINT_FRAME结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, NET_DVR_POINT_FRAME pStruPointFrame);
        /// <summary>
        /// 获取云台巡航路径（IP快球）
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetPTZCruise(LONG lUserID,LONG lChannel,LONG lCruiseRoute, LPNET_DVR_CRUISE_RET lpCruiseRet);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login()的返回值</param>
        /// <param name="lChannel">[in]DVR的通道号</param>
        /// <param name="lCruiseRoute">[in]巡航路径,最多支持32条路径</param>
        /// <param name="lpCruiseRet">[out]返回的NET_DVR_CRUISE_RET结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, out NET_DVR_CRUISE_RET lpCruiseRet);
        #endregion
        #region IP快球参数配置结构体
        /// <summary>
        /// 云台区域选择放大缩小(HIK 快球专用)
        ///     NET_DVR_POINT_FRAME, *LPNET_DVR_POINT_FRAME;
        /// </summary>
        public struct NET_DVR_POINT_FRAME
        {
            /// <summary>
            /// 方框起始点的x坐标
            /// </summary>
            public int xTop;
            /// <summary>
            /// 方框结束点的y坐标
            /// </summary>
            public int yTop;
            /// <summary>
            /// 方框结束点的x坐标
            /// </summary>
            public int xBottom;
            /// <summary>
            /// 方框结束点的y坐标
            /// </summary>
            public int yBottom;
            /// <summary>
            /// 保留
            /// </summary>
            public int bCounter;
        }
        /// <summary>
        /// 巡航点配置(HIK IP快球专用)
        ///     NET_DVR_CRUISE_POINT, *LPNET_DVR_CRUISE_POINT;
        /// </summary>
        public struct NET_DVR_CRUISE_POINT
        {
            /// <summary>
            /// 预置点
            /// </summary>
            public byte PresetNum;
            /// <summary>
            /// 停留时间
            /// </summary>
            public byte Dwell;
            /// <summary>
            /// 速度
            /// </summary>
            public byte Speed;
            /// <summary>
            /// 保留
            /// </summary>
            public byte Reserve;
        }
        /// <summary>
        /// 巡航轨迹
        ///     NET_DVR_CRUISE_RET, *LPNET_DVR_CRUISE_RET;
        /// </summary>
        public struct NET_DVR_CRUISE_RET
        {
            /// <summary>
            /// 最大支持32个巡航点
            ///     NET_DVR_CRUISE_POINT struCruisePoint[32];
            /// </summary>
            public NET_DVR_CRUISE_POINT[] struCruisePoint;
        }
        #endregion
        #endregion
        #region ATM参数配置
        #region ATM参数设置
        /// <summary>
        /// 获取ATM硬盘录像机的帧格式
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientGetframeformat_V30(LONG lUserID, LPNET_DVR_FRAMEFORMAT_V30 lpFrameFormat);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpFrameFormat">[out]指向NET_DVR_FRAMEFORMAT_V30结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat_V30(int lUserID, out NET_DVR_FRAMEFORMAT_V30 lpFrameFormat);
        /// <summary>
        /// 获取ATM硬盘录像机的帧格式
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientGetframeformat(LONG lUserID, LPNET_DVR_FRAMEFORMAT lpFrameFormat);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpFrameFormat">[out]指向NET_DVR_FRAMEFORMAT结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat(int lUserID, out NET_DVR_FRAMEFORMAT lpFrameFormat);
        /// <summary>
        /// 获取ATM硬盘录像机的帧格式
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetATMPortCFG(LONG lUserID, WORD *LPOutATMPort);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="LPOutATMPort">[out]ATM 端口值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetATMPortCFG(int lUserID, out ushort LPOutATMPort);
        /// <summary>
        /// 设置ATM硬盘录像机的帧格式
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientSetframeformat_V30(LONG lUserID, LPNET_DVR_FRAMEFORMAT_V30 lpFrameFormat);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpFrameFormat">[in]指向NET_DVR_FRAMEFORMAT_V30结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat_V30(int lUserID, NET_DVR_FRAMEFORMAT_V30 lpFrameFormat);
        /// <summary>
        /// 设置ATM硬盘录像机的帧格式
        ///     NET_DVR_API BOOL __stdcall NET_DVR_ClientSetframeformat(LONG lUserID, LPNET_DVR_FRAMEFORMAT lpFrameFormat);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="lpFrameFormat">[in]指向NET_DVR_FRAMEFORMAT 结构</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat(int lUserID, NET_DVR_FRAMEFORMAT lpFrameFormat);
        /// <summary>
        /// 设置ATM 端口
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetATMPortCFG(LONG lUserID, WORD wATMPort);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="wATMPort">[in]ATM 端口值</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);

        #endregion
        #region ATM信息参数
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;
        /// <summary>
        /// 帧格式
        ///     NET_DVR_FRAMETYPECODE;
        /// </summary>
        public struct NET_DVR_FRAMETYPECODE
        {
            /// <summary>
            /// 代码
            /// 	public byte code[12];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] code;
        }
        /// <summary>
        /// ATM参数(9000扩展)
        ///     NET_DVR_FRAMEFORMAT_V30, *LPNET_DVR_FRAMEFORMAT_V30;
        /// </summary>
        public struct NET_DVR_FRAMEFORMAT_V30
        {
            public uint dwSize;
            /// <summary>
            /// ATM IP地址
            /// </summary>
            public NET_DVR_IPADDR struATMIP;
            /// <summary>
            /// ATM类型
            /// </summary>
            public uint dwATMType;
            /// <summary>
            /// 输入方式	0-网络侦听 1-网络接收 2-串口直接输入 3-串口ATM命令输入
            /// </summary>
            public uint dwInputMode;
            /// <summary>
            /// 报文标志位的起始位置
            /// </summary>
            public uint dwFrameSignBeginPos;
            /// <summary>
            /// 报文标志位的长度
            /// </summary>
            public uint dwFrameSignLength;
            /// <summary>
            /// 报文标志位的内容
            /// 	public byte byFrameSignContent[12];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byFrameSignContent;
            /// <summary>
            /// 卡号长度信息的起始位置
            /// </summary>
            public uint dwCardLengthInfoBeginPos;
            /// <summary>
            /// 卡号长度信息的长度
            /// </summary>
            public uint dwCardLengthInfoLength;
            /// <summary>
            /// 卡号信息的起始位置
            /// </summary>
            public uint dwCardNumberInfoBeginPos;
            /// <summary>
            /// 卡号信息的长度
            /// </summary>
            public uint dwCardNumberInfoLength;
            /// <summary>
            /// 交易类型的起始位置
            /// </summary>
            public uint dwBusinessTypeBeginPos;
            /// <summary>
            /// 交易类型的长度
            /// </summary>
            public uint dwBusinessTypeLength;
            /// <summary>
            /// 类型
            ///     NET_DVR_FRAMETYPECODE	frameTypeCode[10];
            /// </summary>
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;
            /// <summary>
            /// 卡号捕捉端口号(网络协议方式)
            /// </summary>
            public ushort wATMPort;
            /// <summary>
            /// 网络协议类型
            /// </summary>
            public ushort wProtocolType;
            /// <summary>
            /// 
            /// 	public byte    byRes[24];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public byte[] byRes;
        }

        /// <summary>
        /// ATM参数
        ///     NET_DVR_FRAMEFORMAT, *LPNET_DVR_FRAMEFORMAT;
        /// </summary>
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            /// <summary>
            /// ATM IP地址
            ///     char sATMIP[16];
            /// </summary>
            public string sATMIP;
            /// <summary>
            /// ATM类型
            /// </summary>
            public uint dwATMType;
            /// <summary>
            /// 输入方式	0-网络侦听 1-网络接收 2-串口直接输入 3-串口ATM命令输入
            /// </summary>
            public uint dwInputMode;
            /// <summary>
            /// 报文标志位的起始位置
            /// </summary>
            public uint dwFrameSignBeginPos;
            /// <summary>
            /// 报文标志位的长度
            /// </summary>
            public uint dwFrameSignLength;
            /// <summary>
            /// 报文标志位的内容
            /// 	public byte  byFrameSignContent[12];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] byFrameSignContent;
            /// <summary>
            /// 卡号长度信息的起始位置
            /// </summary>
            public uint dwCardLengthInfoBeginPos;
            /// <summary>
            /// 卡号长度信息的长度
            /// </summary>
            public uint dwCardLengthInfoLength;
            /// <summary>
            /// 卡号信息的起始位置
            /// </summary>
            public uint dwCardNumberInfoBeginPos;
            /// <summary>
            /// 卡号信息的长度
            /// </summary>
            public uint dwCardNumberInfoLength;
            /// <summary>
            /// 交易类型的起始位置
            /// </summary>
            public uint dwBusinessTypeBeginPos;
            /// <summary>
            /// 交易类型的长度
            /// </summary>
            public uint dwBusinessTypeLength;
            /// <summary>
            /// 类型
            ///     NET_DVR_FRAMETYPECODE frameTypeCode[10];
            /// </summary>
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;
        }
        #endregion
        #endregion
        #region RTSP协议参数配置
        #region RTSP协议设置
        /// <summary>
        /// 设置rtsp协议端口
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetRtspConfig(LONG lUserID, DWORD dwCommand, LPNET_DVR_RTSPCFG lpInBuffer, DWORD dwInBufferSize);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwCommand">[in]参数类型</param>
        /// <param name="lpInBuffer">[in]输入缓存</param>
        /// <param name="dwInBufferSize">[in]输入缓存的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);
        /// <summary>
        /// 获取rtsp协议端口
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetRtspConfig(LONG lUserID, DWORD dwCommand, LPNET_DVR_RTSPCFG lpOutBuffer, DWORD dwOutBufferSize);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwCommand">[in]参数类型</param>
        /// <param name="lpOutBuffer">[out]输出缓存</param>
        /// <param name="dwOutBufferSize">[out]输出缓存的大小</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, out NET_DVR_RTSPCFG lpOutBuffer, out uint dwOutBufferSize);
        #endregion
        #region RTSP协议参数配置结构体
        /// <summary>
        /// RTSP协议参数配置结构体 ipcamera专用
        ///     NET_DVR_RTSPCFG, *LPNET_DVR_RTSPCFG;
        /// </summary>
        public struct NET_DVR_RTSPCFG
        {
            /// <summary>
            /// 长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// rtsp服务器侦听端口
            /// </summary>
            public ushort wPort;
            /// <summary>
            /// 预留
            ///     public byte  byReserve[54];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 54)]
            public byte[] byReserve;
        }
        #endregion
        #endregion
        #region 获取设备支持的云台协议
        #region 获取设备支持的云台协议表
        /// <summary>
        /// 获取设备支持的云台协议表
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetPTZProtocol(LONG lUserID, NET_DVR_PTZCFG *pPtzcfg);
        ///     注意
        ///         原先8000的云台协议中有较多协议不是常用的，9000设备中去除掉了，通过该接口重新建立协议列表
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login或者NET_DVR_Login_V30的返回值</param>
        /// <param name="pPtzcfg">[in]DVR的云台协议结构NET_DVR_PTZCFG指针</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZProtocol(int lUserID, NET_DVR_PTZCFG pPtzcfg);
        #endregion
        #region 云台协议表结构体
        /// <summary>
        /// 云台协议表结构配置
        ///     NET_DVR_PTZ_PROTOCOL;
        /// </summary>
        public struct NET_DVR_PTZ_PROTOCOL
        {
            /// <summary>
            /// 解码器类型值，从1开始连续递增
            /// </summary>
            public uint dwType;
            /// <summary>
            /// 解码器的描述符，和8000中的一致
            ///     public byte  byDescribe[DESC_LEN];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.DESC_LEN)]
            public byte[] byDescribe;
        }
        /// <summary>
        /// 解码器协议列表
        ///     NET_DVR_PTZCFG, *LPNET_DVR_PTZCFG;
        /// </summary>
        public struct NET_DVR_PTZCFG
        {
            /// <summary>
            /// 本结构长度
            /// </summary>
            public uint dwSize;
            /// <summary>
            /// 最大200中PTZ协议
            ///     NET_DVR_PTZ_PROTOCOL struPtz[PTZ_PROTOCOL_NUM]; 
            /// </summary>
            public NET_DVR_PTZ_PROTOCOL[] struPtz;
            /// <summary>
            /// 有效的ptz协议数目，从0开始(即计算时加1)
            /// </summary>
            public uint dwPtzNum;
            /// <summary>
            /// 保留参数
            ///     public byte    byRes[8];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] byRes;
        }
        #endregion
        #endregion
        #region 视频输出缩放参数配置
        #region 设置缩放
        /// <summary>
        /// 获取是否设置缩放
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetScaleCFG_V30(LONG lUserID, LPNET_DVR_SCALECFG pScalecfg);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login的返回值</param>
        /// <param name="pScalecfg">[in]缩放参数，详见LPNET_DVR_SCALECFG</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, NET_DVR_SCALECFG pScalecfg);
        /// <summary>
        /// 获取是否设置缩放
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetScaleCFG(LONG lUserID, DWORD *lpOutScale);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login的返回值</param>
        /// <param name="lpOutScale">[in]缩放参数，详见LPNET_DVR_SCALECFG</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);
        /// <summary>
        /// 设置缩放
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetScaleCFG_V30(LONG lUserID, LPNET_DVR_SCALECFG pScalecfg);
        /// </summary>
        /// <param name="lUserID">[in] NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="pScalecfg">[in]缩放参数 0－否；1－是</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, NET_DVR_SCALECFG pScalecfg);
        /// <summary>
        /// 设置缩放
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetScaleCFG(LONG lUserID, DWORD dwScale);
        /// </summary>
        /// <param name="lUserID">[in]NET_DVR_Login 或者NET_DVR_Login_V30的返回值</param>
        /// <param name="dwScale">[in]是否缩放：0—否；1—是</param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);
        #endregion
        #region 配置缩放参数的结构
        /// <summary>
        /// 配置缩放参数的结构
        ///     NET_DVR_SCALECFG, *LPNET_DVR_SCALECFG;
        /// </summary>
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            /// <summary>
            /// 主显示 0-不缩放，1-缩放
            /// </summary>
            public uint dwMajorScale;
            /// <summary>
            /// 辅显示 0-不缩放，1-缩放
            /// </summary>
            public uint dwMinorScale;
            /// <summary>
            ///     public uint dwRes[2];
            /// </summary>
            public uint[] dwRes;
        }
        #endregion
        #endregion
        #endregion
        #endregion

        #region 其他文档中没有，但是HCNetSDK.h中有的定义

        /// 设置码流速度
        /// </summary>
        public const int NET_DVR_SETSPEED = 24;
        /// <summary>
        /// 保持与设备的心跳(如果回调阻塞，建议2秒发送一次)
        /// </summary>
        public const int NET_DVR_KEEPALIVE = 25;

        //远程按键定义如下：
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;

        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        /// <summary>
        /// 光圈+
        /// </summary>
        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT; /* 光圈+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        /// <summary>
        /// 光圈-
        /// </summary>
        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN; /* 光圈- */
        public const int KEY_PTZ_AP2_STOP = 37;

        /// <summary>
        /// 聚焦+
        /// </summary>
        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A; /* 聚焦+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        /// <summary>
        /// 聚焦-
        /// </summary>
        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* 聚焦- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        /// <summary>
        /// 变倍+
        /// </summary>
        public const int KEY_PTZ_B1_START = 40; /* 变倍+ */
        public const int KEY_PTZ_B1_STOP = 41;

        /// <summary>
        /// 变倍-
        /// </summary>
        public const int KEY_PTZ_B2_START = 42; /* 变倍- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000新增
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /// <summary>
        /// 获取网络应用参数 EMAIL
        /// </summary>
        public const int NET_DVR_GET_EMAILCFG = 228;//
        /// <summary>
        /// 设置网络应用参数 EMAIL
        /// </summary>
        public const int NET_DVR_SET_EMAILCFG = 229;	//
        //对应NET_DVR_EMAILCFG结构
        //
        public const int NET_DVR_GET_ALLHDCFG = 300;		//
        #region DS9000新增命令(_V30)
        //设备编码类型配置(NET_DVR_COMPRESSION_AUDIO结构)
        /// <summary>
        /// 获取设备语音对讲编码参数
        /// </summary>
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;     //
        /// <summary>
        /// 设置设备语音对讲编码参数
        /// </summary>
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;      //
        #endregion
        /// <summary>
        /// 预览异常
        /// </summary>
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//
        /// <summary>
        /// 预览时连接断开
        /// </summary>
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//
        /// <summary>
        /// 预览5s没有收到数据
        /// </summary>
        public const int NET_DVR_REALPLAY5SNODATA = 113;	//
        /// <summary>
        /// 预览重连
        /// </summary>
        public const int NET_DVR_REALPLAYRECONNECT = 114;	//
        /// <summary>
        /// 回放数据播放完毕
        /// </summary>
        public const int NET_DVR_PLAYBACKOVER = 101;//
        /// <summary>
        /// 回放异常
        /// </summary>
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//
        /// <summary>
        /// 回放时候连接断开
        /// </summary>
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//
        /// <summary>
        /// 回放5s没有收到数据
        /// </summary>
        public const int NET_DVR_PLAYBACK5SNODATA = 104;

        #region DS-6001D/F
        /// <summary>
        /// DS-6001D Decoder
        ///     NET_DVR_DECODERINFO, *LPNET_DVR_DECODERINFO;
        /// </summary>
        public struct NET_DVR_DECODERINFO
        {
            /// <summary>
            /// 解码设备连接的服务器IP
            /// 	public byte byEncoderIP[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderIP;
            /// <summary>
            /// 解码设备连接的服务器的用户名
            /// 	public byte byEncoderUser[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderUser;
            /// <summary>
            /// 解码设备连接的服务器的密码
            /// 	public byte byEncoderPasswd[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderPasswd;
            /// <summary>
            /// 解码设备连接服务器的连接模式
            /// </summary>
            public byte bySendMode;
            /// <summary>
            /// 解码设备连接的服务器的通道号
            /// </summary>
            public byte byEncoderChannel;
            /// <summary>
            /// 解码设备连接的服务器的端口号
            /// </summary>
            public ushort wEncoderPort;
            /// <summary>
            /// 保留
            /// 	public byte reservedData[4];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reservedData;
        }

        /// <summary>
        /// NET_DVR_DECODERSTATE, *LPNET_DVR_DECODERSTATE;
        /// </summary>
        public struct NET_DVR_DECODERSTATE
        {
            /// <summary>
            /// 解码设备连接的服务器IP
            /// 	public byte byEncoderIP[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderIP;
            /// <summary>
            /// 解码设备连接的服务器的用户名
            /// 	public byte byEncoderUser[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderUser;
            /// <summary>
            /// 解码设备连接的服务器的密码
            /// 	public byte byEncoderPasswd[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byEncoderPasswd;
            /// <summary>
            /// 解码设备连接的服务器的通道号
            /// </summary>
            public byte byEncoderChannel;
            /// <summary>
            /// 解码设备连接的服务器的连接模式
            /// </summary>
            public byte bySendMode;
            /// <summary>
            /// 解码设备连接的服务器的端口号
            /// </summary>
            public ushort wEncoderPort;
            /// <summary>
            /// 解码设备连接服务器的状态
            /// </summary>
            public uint dwConnectState;
            /// <summary>
            /// 保留
            /// 	public byte reservedData[4];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reservedData;
        }

        #region 解码设备控制码定义
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;
        #endregion


        #endregion

        /// <summary>
        /// Email
        ///     NET_DVR_EMAILPARA, *LPNET_DVR_EMAILPARA;
        /// </summary>
        public struct NET_DVR_EMAILPARA
        {
            /// <summary>
            /// 邮件账号
            ///     public byte sUsername[64];
            /// </summary>
            public string sUsername;
            /// <summary>
            /// 邮件密码
            ///     public byte sPassword[64];
            /// </summary>
            public string sPassword;
            /// <summary>
            ///     public byte sSmtpServer[64];
            /// </summary>
            public string sSmtpServer;
            /// <summary>
            ///     public byte sPop3Server[64];
            /// </summary>
            public string sPop3Server;
            /// <summary>
            /// 邮件地址
            ///     public byte sMailAddr[64];
            /// </summary>
            public string sMailAddr;
            /// <summary>
            /// 上传报警/异常等的email
            ///     public byte sEventMailAddr1[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] sEventMailAddr1;
            /// <summary>
            ///     public byte sEventMailAddr2[64];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] sEventMailAddr2;
            /// <summary>
            ///     public byte res[16];
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] res;
        }

        /// <summary>
        /// NET_DVR_NETCFG_OTHER, *LPNET_DVR_NETCFG_OTHER;
        /// </summary>
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            /// <summary>
            ///     char	sFirstDNSIP[16];
            /// </summary>
            public string sFirstDNSIP;
            /// <summary>
            ///     char	sSecondDNSIP[16];
            /// </summary>
            public string sSecondDNSIP;
            /// <summary>
            /// char	sRes[32];
            /// </summary>
            public string sRes;
        }

        /// <summary>
        /// 连接的通道配置 2007-11-05
        ///     NET_DVR_MATRIX_DECCHANINFO, *LPNET_DVR_MATRIX_DECCHANINFO;
        /// </summary>
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            /// <summary>
            /// 是否启用 0－否 1－启用
            /// </summary>
            public uint dwEnable;
            /// <summary>
            /// 轮循解码通道信息
            /// </summary>
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;
        }
        /// <summary>
        /// 压缩参数?
        ///     NET_DVR_COMPRESSIONCFG_NEW, *LPNET_DVR_COMPRESSIONCFG_NEW;
        /// </summary>
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            /// <summary>
            /// 定时录像
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;
            /// <summary>
            /// 事件触发录像
            /// </summary>
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;
        }
        /// <summary>
        /// 抓图模式
        /// </summary>
        public enum CAPTURE_MODE
        {
            /// <summary>
            /// BMP模式
            /// </summary>
            BMP_MODE = 0,		//
            /// <summary>
            /// JPEG模式 
            /// </summary>
            JPEG_MODE = 1		//
        }
        /// <summary>
        /// 实时声音模式
        /// </summary>
        public enum REALSOUND_MODE
        {
            /// <summary>
            /// 独占模式
            /// </summary>
            MONOPOLIZE_MODE = 1,
            /// <summary>
            /// 共享模式
            /// </summary>
            SHARE_MODE = 2
        }
        /// <summary>
        /// 录象文件参数(带卡号)
        ///     NET_DVR_FINDDATA_CARD, *LPNET_DVR_FINDDATA_CARD;
        /// </summary>
        public struct NET_DVR_FINDDATA_CARD
        {
            /// <summary>
            /// 文件名
            ///     char sFileName[100];
            /// </summary>
            public string sFileName;
            /// <summary>
            /// 文件的开始时间
            /// </summary>
            public NET_DVR_TIME struStartTime;
            /// <summary>
            /// 文件的结束时间
            /// </summary>
            public NET_DVR_TIME struStopTime;
            /// <summary>
            /// 文件的大小
            /// </summary>
            public uint dwFileSize;
            /// <summary>
            /// 卡号?
            ///     char sCardNum[32];
            /// </summary>
            public char sCardNum;
        }

        /// <summary>
        /// 设置重新连接间隔
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetReconnect(DWORD dwInterval = 30000, BOOL bEnableRecon = TRUE);
        /// </summary>
        /// <param name="dwInterval"></param>
        /// <param name="bEnableRecon"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetReconnect(uint dwInterval, bool bEnableRecon);
        /// <summary>
        /// 通过IPSever获取设备动态IP地址[Ex]
        ///     NET_DVR_API BOOL  __stdcall NET_DVR_GetDVRIPByResolveSvr_EX(char *sServerIP, WORD wServerPort, unsigned char *sDVRName, WORD wDVRNameLen, BYTE *sDVRSerialNumber, WORD wDVRSerialLen, char* sGetIP, DWORD *dwPort);
        /// </summary>
        /// <param name="sServerIP"></param>
        /// <param name="wServerPort"></param>
        /// <param name="sDVRName"></param>
        /// <param name="wDVRNameLen"></param>
        /// <param name="sDVRSerialNumber"></param>
        /// <param name="wDVRSerialLen"></param>
        /// <param name="sGetIP"></param>
        /// <param name="dwPort"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, StringBuilder sGetIP, ref uint dwPort);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZControlWithSpeed_EX(LONG lRealHandle, DWORD dwPTZCommand, DWORD dwStop, DWORD dwSpeed);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZCommand"></param>
        /// <param name="dwStop"></param>
        /// <param name="dwSpeed"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZMltTrack(LONG lRealHandle,DWORD dwPTZTrackCmd, DWORD dwTrackIndex);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZTrackCmd"></param>
        /// <param name="dwTrackIndex"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZMltTrack_Other(LONG lUserID,LONG lChannel,DWORD dwPTZTrackCmd, DWORD dwTrackIndex);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="dwPTZTrackCmd"></param>
        /// <param name="dwTrackIndex"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_PTZMltTrack_EX(LONG lRealHandle,DWORD dwPTZTrackCmd, DWORD dwTrackIndex);
        /// </summary>
        /// <param name="lRealHandle"></param>
        /// <param name="dwPTZTrackCmd"></param>
        /// <param name="dwTrackIndex"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);
        /// <summary>
        /// NET_DVR_API LONG __stdcall NET_DVR_FindNextFile_Card(LONG lFindHandle, LPNET_DVR_FINDDATA_CARD lpFindData);
        /// </summary>
        /// <param name="lFindHandle"></param>
        /// <param name="lpFindData"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, NET_DVR_FINDDATA_CARD lpFindData);
        /// <summary>
        /// NET_DVR_API LONG __stdcall NET_DVR_FindFile_Card(LONG lUserID, LONG lChannel, DWORD dwFileType, LPNET_DVR_TIME lpStartTime, LPNET_DVR_TIME lpStopTime);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="dwFileType"></param>
        /// <param name="lpStartTime"></param>
        /// <param name="lpStopTime"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, NET_DVR_TIME lpStartTime, NET_DVR_TIME lpStopTime);
        /// <summary>
        /// NET_DVR_API int	__stdcall NET_DVR_GetPlayBackPos(LONG lPlayHandle);
        /// </summary>
        /// <param name="lPlayHandle"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);
        //解码设备DS-6001D/DS-6001F
        /// <summary>
        /// NET_DVR_API BOOL __stdcall NET_DVR_StartDecode(LONG lUserID, LONG lChannel, LPNET_DVR_DECODERINFO lpDecoderinfo);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="lpDecoderinfo"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, NET_DVR_DECODERINFO lpDecoderinfo);
        /// <summary>
        /// NET_DVR_API BOOL __stdcall NET_DVR_StopDecode(LONG lUserID, LONG lChannel);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);
        /// <summary>
        /// NET_DVR_API BOOL __stdcall NET_DVR_GetDecoderState(LONG lUserID, LONG lChannel, LPNET_DVR_DECODERSTATE lpDecoderState);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="lpDecoderState"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, NET_DVR_DECODERSTATE lpDecoderState);
        /// <summary>
        /// 保存参数
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SaveConfig(LONG lUserID);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig(int lUserID);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_SetVideoEffect(LONG lUserID, LONG lChannel, DWORD dwBrightValue, DWORD dwContrastValue, DWORD dwSaturationValue, DWORD dwHueValue);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="dwBrightValue"></param>
        /// <param name="dwContrastValue"></param>
        /// <param name="dwSaturationValue"></param>
        /// <param name="dwHueValue"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);
        /// <summary>
        ///     NET_DVR_API BOOL __stdcall NET_DVR_GetVideoEffect(LONG lUserID, LONG lChannel, DWORD *pBrightValue, DWORD *pContrastValue, DWORD *pSaturationValue, DWORD *pHueValue);
        /// </summary>
        /// <param name="lUserID"></param>
        /// <param name="lChannel"></param>
        /// <param name="pBrightValue"></param>
        /// <param name="pContrastValue"></param>
        /// <param name="pSaturationValue"></param>
        /// <param name="pHueValue"></param>
        /// <returns></returns>
        [DllImport("ia64\\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, out uint pBrightValue, out uint pContrastValue, out uint pSaturationValue, out uint pHueValue);

        #endregion

    }
}
