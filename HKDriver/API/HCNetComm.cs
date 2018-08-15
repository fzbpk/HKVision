using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace HKDriver.API
{
    public class APICFG {

        public const int STREAM_ID_LEN = 32;
    }
  

    #region 2.2      设备信息
    /// <summary>
    /// 2.2.1   设备信息结构体
    ///     NET_DVR_Login_V30()参数结构
    ///     NET_DVR_DEVICEINFO_V30, *LPNET_DVR_DEVICEINFO_V30;
    /// </summary>
    public struct NET_DVR_DEVICEINFO_V30
    {
        /// <summary>
        /// 序列号
        ///     public byte sSerialNumber[SERIALNO_LEN];
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.SERIALNO_LEN)]
        public byte[] sSerialNumber;
        /// <summary>
        /// 报警输入个数
        /// </summary>
        public byte byAlarmInPortNum;
        /// <summary>
        /// 报警输出个数
        /// </summary>
        public byte byAlarmOutPortNum;
        /// <summary>
        /// 硬盘个数
        /// </summary>
        public byte byDiskNum;
        /// <summary>
        /// 设备类型, 1:DVR 2:ATM DVR 3:DVS ......
        /// </summary>
        public byte byDVRType;
        /// <summary>
        /// 模拟通道个数
        /// </summary>
        public byte byChanNum;
        /// <summary>
        /// 起始通道号,例如DVS-1,DVR - 1
        /// </summary>
        public byte byStartChan;
        /// <summary>
        /// 语音通道数
        /// </summary>
        public byte byAudioChanNum;
        /// <summary>
        /// 最大数字通道个数
        /// </summary>
        public byte byIPChanNum;
        /// <summary>
        /// 保留
        ///     public byte byRes1[24];
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        public byte[] byRes1;
    }
    /// <summary>
    /// 设备信息结构体
    ///     NET_DVR_Login()参数结构
    ///     NET_DVR_DEVICEINFO, *LPNET_DVR_DEVICEINFO;
    /// </summary>
    public struct NET_DVR_DEVICEINFO
    {
        /// <summary>
        /// 序列号
        ///     public byte sSerialNumber[SERIALNO_LEN];
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = HCNetSDK.SERIALNO_LEN)]
        public byte[] sSerialNumber;
        /// <summary>
        /// DVR报警输入个数
        /// </summary>
        public byte byAlarmInPortNum;
        /// <summary>
        /// DVR报警输出个数
        /// </summary>
        public byte byAlarmOutPortNum;
        /// <summary>
        /// DVR硬盘个数
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
    }
    #endregion
    #region 3.2        SDK信息
    /// <summary>
    /// 3.2.1   SDK状态信息结构体(9000新增)
    ///     NET_DVR_SDKSTATE, *LPNET_DVR_SDKSTATE;
    /// </summary>
    public struct NET_DVR_SDKSTATE
    {
        /// <summary>
        /// 当前login用户数
        /// </summary>
        public uint dwTotalLoginNum;
        /// <summary>
        /// 当前realplay路数
        /// </summary>
        public uint dwTotalRealPlayNum;
        /// <summary>
        /// 当前回放或下载路数
        /// </summary>
        public uint dwTotalPlayBackNum;
        /// <summary>
        /// 当前建立报警通道路数
        /// </summary>
        public uint dwTotalAlarmChanNum;
        /// <summary>
        /// 当前硬盘格式化路数
        /// </summary>
        public uint dwTotalFormatNum;
        /// <summary>
        /// 当前日志或文件搜索路数
        /// </summary>
        public uint dwTotalFileSearchNum;
        /// <summary>
        /// 当前日志或文件搜索路数
        /// </summary>
        public uint dwTotalLogSearchNum;
        /// <summary>
        /// 当前透明通道路数
        /// </summary>
        public uint dwTotalSerialNum;
        /// <summary>
        /// 当前升级路数
        /// </summary>
        public uint dwTotalUpgradeNum;
        /// <summary>
        /// 当前语音转发路数
        /// </summary>
        public uint dwTotalVoiceComNum;
        /// <summary>
        /// 当前语音广播路数
        /// </summary>
        public uint dwTotalBroadCastNum;
        /// <summary>
        /// 保留
        /// public uint dwRes[10];
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] dwRes;
    }
    /// <summary>
    /// 3.2.2   SDK功能支持信息结构体(9000新增)
    ///     NET_DVR_SDKABL, *LPNET_DVR_SDKABL;
    /// </summary>
    public struct NET_DVR_SDKABL
    {
        /// <summary>
        /// 最大login用户数 MAX_LOGIN_USERS
        /// </summary>
        public uint dwMaxLoginNum;
        /// <summary>
        /// 最大realplay路数 WATCH_NUM
        /// </summary>
        public uint dwMaxRealPlayNum;
        /// <summary>
        /// 最大回放或下载路数 WATCH_NUM
        /// </summary>
        public uint dwMaxPlayBackNum;
        /// <summary>
        /// 最大建立报警通道路数 ALARM_NUM
        /// </summary>
        public uint dwMaxAlarmChanNum;
        /// <summary>
        /// 最大硬盘格式化路数 SERVER_NUM
        /// </summary>
        public uint dwMaxFormatNum;
        /// <summary>
        /// 最大文件搜索路数 SERVER_NUM
        /// </summary>
        public uint dwMaxFileSearchNum;
        /// <summary>
        /// 最大日志搜索路数 SERVER_NUM
        /// </summary>
        public uint dwMaxLogSearchNum;
        /// <summary>
        /// 最大透明通道路数 SERVER_NUM
        /// </summary>
        public uint dwMaxSerialNum;
        /// <summary>
        /// 最大升级路数 SERVER_NUM
        /// </summary>
        public uint dwMaxUpgradeNum;
        /// <summary>
        /// 最大语音转发路数 SERVER_NUM
        /// </summary>
        public uint dwMaxVoiceComNum;
        /// <summary>
        /// 最大语音广播路数 MAX_CASTNUM
        /// </summary>
        public uint dwMaxBroadCastNum;
        /// <summary>
        /// 保留
        /// public uint dwRes[10];
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
        public uint[] dwRes;
    }
    #endregion
    #region 5.2    预览信息
    /// <summary>
    /// 5.2.1   预览信息结构体
    ///     注意
    ///         如果将hPlayWnd参数设置为NULL，则客户端收到数据后不进行解码显示，但仍可以录像。
    ///     NET_DVR_CLIENTINFO, *LPNET_DVR_CLIENTINFO;
    /// </summary>
    //预览V40接口
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct NET_DVR_PREVIEWINFO
    {
        public Int32 lChannel;//通道号
        public uint dwStreamType;   // 码流类型，0-主码流，1-子码流，2-码流3，3-码流4 等以此类推
        public uint dwLinkMode;// 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-RTP/RTSP,5-RSTP/HTTP 
        public IntPtr hPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
        public bool bBlocked;  //0-非阻塞取流, 1-阻塞取流, 如果阻塞SDK内部connect失败将会有5s的超时才能够返回,不适合于轮询取流操作.
        public bool bPassbackRecord; //0-不启用录像回传,1启用录像回传
        public byte byPreviewMode;//预览模式，0-正常预览，1-延迟预览
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = APICFG.STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
        public byte[] byStreamID;//流ID，lChannel为0xffffffff时启用此参数
        public byte byProtoType; //应用层取流协议，0-私有协议，1-RTSP协议
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
        public byte[] byRes1;
        public uint dwDisplayBufNum;
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 216, ArraySubType = UnmanagedType.I1)]
        public byte[] byRes;
    }
    /// <summary>
    /// 发送模式
    /// </summary>
    public enum SEND_MODE
    {
        /// <summary>
        /// TCP 方式
        /// </summary>
        PTOPTCPMODE = 0,
        /// <summary>
        /// UDP 方式
        /// </summary>
        PTOPUDPMODE,
        /// <summary>
        /// 多播方式
        /// </summary>
        MULTIMODE,
        /// <summary>
        /// RTP方式
        /// </summary>
        RTPMODE,
        /// <summary>
        /// 保留
        /// </summary>
        RESERVEDMODE
    }
    /// <summary>
    /// 6.2.1   JPEG图像信息结构体
    ///     NET_DVR_JPEGPARA, *LPNET_DVR_JPEGPARA;
    ///     相关函数：
    ///         NET_DVR_CaptureJPEGPicture、NET_DVR_CaptureJPEGPicture_NEW
    ///     注意：当图像压缩分辨率为VGA时，支持0=CIF, 1=QCIF, 2=D1抓图，
    ///     当分辨率为3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
    ///     仅支持当前分辨率的抓图
    /// </summary>
    public struct NET_DVR_JPEGPARA
    {
        /// <summary>
        /// 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA
        /// IPCAM专用{3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA(640x480) , 7=XVGA, 8=HD900p }
        /// </summary>
        public int wPicSize;
        /// <summary>
        /// 图片质量系数 0-最好 1-较好 2-一般
        /// </summary>
        public int wPicQuality;
    }
    /// <summary>
    /// void(CALLBACK *fRealDataCallBack_V30) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer, DWORD dwBufSize, void* pUser)
    /// </summary>
    /// <param name="lRealHandle">NET_DVR_RealPlay_V30返回值</param>
    /// <param name="dwDataType">
    ///     数据类型
    ///     #define NET_DVR_SYSHEAD     1       系统头数据
    ///     #define NET_DVR_STREAMDATA  2       流数据/视频数据
    ///     #define NET_DVR_AUDIODATA   3       音频数据
    /// </param>
    /// <param name="pBuffer">存放数据的缓冲区指针</param>
    /// <param name="dwBufSize">缓冲区的大小</param>
    /// <param name="pUser">输入的用户数据</param>
    public delegate void REALDATACALLBACK(int lRealHandle, int dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr pUser);
    /// <summary>
    /// void(CALLBACK *fStdDataCallBack) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser)
    /// </summary>
    /// <param name="lRealHandle">NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
    /// <param name="dwDataType">
    ///     数据类型
    ///     #define NET_DVR_SYSHEAD     1       系统头数据
    ///     #define NET_DVR_STREAMDATA  2       流数据/视频数据
    ///     #define NET_DVR_AUDIODATA   3       音频数据
    /// </param>
    /// <param name="pBuffer">存放数据的缓冲区指针</param>
    /// <param name="dwBufSize">缓冲区的大小</param>
    /// <param name="dwUser">输入的用户数据</param>
    public delegate void StdDataCallBack(int lRealHandle, int dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr dwUser);
    /// <summary>
    ///     void(CALLBACK *fRealDataCallBack) (LONG lRealHandle, DWORD dwDataType, BYTE *pBuffer,DWORD dwBufSize,DWORD dwUser)
    /// </summary>
    /// <param name="lRealHandle">NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值</param>
    /// <param name="dwDataType">
    ///     数据类型
    ///     #define NET_DVR_SYSHEAD     1       系统头数据
    ///     #define NET_DVR_STREAMDATA  2       流数据/视频数据
    ///     #define NET_DVR_AUDIODATA   3       音频数据
    /// </param>
    /// <param name="pBuffer">存放数据的缓冲区指针</param>
    /// <param name="dwBufSize">缓冲区的大小</param>
    /// <param name="dwUser">输入的用户数据</param>
    public delegate void RealDataCallBack(int lRealHandle, int dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr dwUser);
    #endregion
}
