using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HKDriver.API;
using System.IO;
using System.Drawing;

namespace HKDriver 
{
    public class HKDVR:IDisposable
    {

        #region 定义
        private bool m_disposed = false;
        private int lUserID = -1;
        private int m_lRealHandle = -1;
        private bool mRec = false;
        #endregion
         
        #region 构造

        public HKDVR()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_Init();
            else
                HCNetSDK.NET_DVR_Init();
            this.BufferSize = 1024 * 1024;
            this.BufferFrame = 15;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 释放连接
        /// </summary>
        /// <param name="disposing">是否释放</param>
        protected virtual void Dispose(bool disposing)
        {
            lock (this)
            {
                if (disposing && !m_disposed)
                {
                    if (Environment.Is64BitProcess)
                        HCNetSDKia64.NET_DVR_Cleanup();
                    else
                        HCNetSDK.NET_DVR_Cleanup();
                    m_disposed = true;
                }
            }
        }

        private void Error()
        {
            int error = 0;
            string errs = "";
            if (Environment.Is64BitProcess)
                errs = HCNetSDKia64.NET_DVR_GetErrorMsg(out error);
            else
                errs = HCNetSDK.NET_DVR_GetErrorMsg(out error);
            throw new Exception(string.Format("ErrorCode:{0}\r\nErrorMess:{1}\r\n", error.ToString(), errs));
        }

        #endregion

        #region 属性
        public int BufferSize { get; set; }
        public int BufferFrame { get; set; }
        public int Channel { get; private set; }
        public DevType Mode { get; private set; }
        public bool IsConnected { get { return lUserID > 1; } }
        public bool IsRec { get { return mRec; } }
        public bool Preview { get { return m_lRealHandle>-1; } }

        #endregion
         
        #region 设备操作

        /// <summary>
        /// 按键
        /// </summary>
        /// <param name="Key">
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
        public bool Panel(int Key)
        {
            if (Environment.Is64BitProcess)
              return   HCNetSDKia64.NET_DVR_ClickKey(this.lUserID, Key);
            else
                return HCNetSDK.NET_DVR_ClickKey(this.lUserID, Key);
        }

        /// <summary>
        /// 禁用设备本地面板控制
        /// </summary>
        public void LockPanel()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_LockPanel(this.lUserID);
            else
                HCNetSDK.NET_DVR_LockPanel(this.lUserID);
        }

        /// <summary>
        /// 恢复设备本地面板控制
        /// </summary>
        public void UnLockPanel()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_UnLockPanel(this.lUserID);
            else
                HCNetSDK.NET_DVR_UnLockPanel(this.lUserID);
        }

        /// <summary>
        /// 重启
        /// </summary>
        public void ReBoot()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_RebootDVR(this.lUserID);
            else
                HCNetSDK.NET_DVR_RebootDVR(this.lUserID);
            lUserID = -1;
            this.m_lRealHandle = -1;
        }

        /// <summary>
        /// 关机
        /// </summary>
        public void ShutDown()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_ShutDownDVR(this.lUserID);
            else
                HCNetSDK.NET_DVR_ShutDownDVR(this.lUserID);
            lUserID = -1;
            this.m_lRealHandle = -1;
        }

        #endregion

        #region 连接

        public bool Connect(string DVRIPAddress, ushort DVRPortNumber, string DVRUserName, string DVRPassword)
        {
            NET_DVR_DEVICEINFO_V30 lpDeviceInfo;
            if (Environment.Is64BitProcess)
                lUserID = HCNetSDKia64.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, out lpDeviceInfo);
            else
                lUserID = HCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, out lpDeviceInfo);
            if (lUserID == -1) Error(); 
            if (lpDeviceInfo.byIPChanNum > 0)
            {
                this.Mode = DevType.NVR;
            }
            else
            {
                this.Mode = DevType.IPC;
                Channel = lpDeviceInfo.byChanNum;
            }
            return true;
        }

        public void DisConnect()
        {
            if (mRec)
                StopRec();
            if (this.m_lRealHandle > -1)
                RealStop();
            if (lUserID > -1)
            {
                if (Environment.Is64BitProcess)
                    HCNetSDKia64.NET_DVR_Logout(lUserID);
                else
                    HCNetSDK.NET_DVR_Logout(lUserID);
            }
            this.lUserID = -1;
        }

        #endregion

        #region 抓拍

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="CH">通道</param>
        /// <param name="Quality">质量</param>
        /// <param name="Size">
        /// 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA
        /// IPCAM专用{3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA(640x480) , 7=XVGA, 8=HD900p
        /// </param>
        /// <returns></returns>
        public Image CaptureJPG(int CH, ushort Quality =2,ushort Size=0xff)
        {
            bool res = false;
            NET_DVR_JPEGPARA jpeginfo;
            jpeginfo.wPicQuality = Quality;
            jpeginfo.wPicSize = Size;  
            byte[] data = new byte[this.BufferSize]; 
            uint ret = 0; 
            if (Environment.Is64BitProcess)
                res = HCNetSDKia64.NET_DVR_CaptureJPEGPicture_NEW(this.lUserID, CH,ref jpeginfo,  data, (uint)data.Length, out ret);
            else
                res = HCNetSDK.NET_DVR_CaptureJPEGPicture_NEW(this.lUserID, CH, jpeginfo, data, (uint)data.Length, out ret);
            if (!res) Error();
            MemoryStream ms = new MemoryStream(data);
            Image image = System.Drawing.Image.FromStream(ms);
            ms.Close();
            ms.Dispose();
            ms = null;
            System.GC.Collect();
            return image;
        }

        #endregion

        #region 预览
         
        /// <summary>
        /// 预览
        /// </summary>
        /// <param name="CH">通道</param>
        /// <param name="Handle">句柄</param>
        /// <param name="StreamType">码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推</param>
        /// <param name="Mode">连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP </param>
        /// <param name="Blocked">0- 非阻塞取流，1- 阻塞取流</param>
        public void RealPlay(int CH, IntPtr Handle, Action<int, int, IntPtr, uint, IntPtr> RealDataCallBack = null, Action<int, int, IntPtr, uint, IntPtr> StdDataEvent = null, Action<int, int, IntPtr, uint, IntPtr> RealDataEvent = null, int StreamType=0,LinkMode Mode= LinkMode.TCP,bool Blocked=true)
        {
            NET_DVR_PREVIEWINFO lpPreviewInfo =new NET_DVR_PREVIEWINFO();
            lpPreviewInfo.hPlayWnd = Handle; 
            lpPreviewInfo.lChannel = CH; 
            lpPreviewInfo.dwStreamType = (uint)StreamType;
            lpPreviewInfo.dwLinkMode = (uint)Mode;
            lpPreviewInfo.bBlocked = Blocked;  
            lpPreviewInfo.dwDisplayBufNum = (uint)this.BufferFrame;  
            IntPtr pUser = new IntPtr();
            REALDATACALLBACK RealData = null;
            if(RealDataCallBack!=null)
                RealData = new REALDATACALLBACK(RealDataCallBack);
            System.Threading.Thread.Sleep(1000);
            if (Environment.Is64BitProcess)
                m_lRealHandle = HCNetSDKia64.NET_DVR_RealPlay_V40(this.lUserID, ref lpPreviewInfo, RealData, pUser);
            else
                m_lRealHandle = HCNetSDK.NET_DVR_RealPlay_V40(this.lUserID, ref lpPreviewInfo, RealData, pUser);
            if (m_lRealHandle < 0) Error();
            if (StdDataEvent != null)
            {
                if (Environment.Is64BitProcess)
                    HCNetSDKia64.NET_DVR_SetStandardDataCallBack(this.lUserID, new StdDataCallBack(StdDataEvent), pUser);
                else
                    HCNetSDK.NET_DVR_SetStandardDataCallBack(this.lUserID, new StdDataCallBack(StdDataEvent), pUser);
            }
            if (RealDataEvent != null)
            {
                if (Environment.Is64BitProcess)
                    HCNetSDKia64.NET_DVR_SetRealDataCallBack(this.lUserID,new RealDataCallBack(RealDataEvent), pUser);
                else
                    HCNetSDK.NET_DVR_SetRealDataCallBack(this.lUserID, new RealDataCallBack(RealDataEvent), pUser);
            }

        }

        /// <summary>
        /// 停止预览
        /// </summary>
        public void RealStop()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_StopRealPlay(this.m_lRealHandle);
            else
                HCNetSDK.NET_DVR_StopRealPlay(this.m_lRealHandle);

            this.m_lRealHandle = -1;
        }
       
        #endregion

        #region 本地录像

        /// <summary>
        /// 本地录像
        /// </summary>
        /// <param name="CH"></param>
        /// <param name="FilePath"></param>
        /// <param name="Handle"></param>
        /// <param name="StreamType"></param>
        /// <param name="Mode"></param>
        /// <param name="Blocked"></param>
        public void StartRec(int CH,string FilePath, IntPtr Handle, int StreamType = 0, LinkMode Mode = LinkMode.TCP, bool Blocked = true)
        {
            if (m_lRealHandle < 0)
                RealPlay(CH, Handle,null,null,null, StreamType, Mode, Blocked);
            if (m_lRealHandle < 0) Error();
            if (Environment.Is64BitProcess)
                mRec=HCNetSDKia64.NET_DVR_SaveRealData(this.m_lRealHandle, FilePath);
            else
                mRec= HCNetSDK.NET_DVR_SaveRealData(this.m_lRealHandle, FilePath);

        }

        public void StopRec()
        {
            if (Environment.Is64BitProcess)
                HCNetSDKia64.NET_DVR_StopSaveRealData(this.m_lRealHandle);
            else
                HCNetSDK.NET_DVR_StopSaveRealData(this.m_lRealHandle);
            mRec = false;
        }

        #endregion

    }
}
