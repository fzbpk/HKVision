using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
namespace EZUiKit 
{
    public class EZDVR
    {
        #region 定义
        private string sid = "";
        private IntPtr UserID = IntPtr.Zero;
        private bool m_disposed = false;
        private bool islive = false;
        private bool isplay = false;
        private bool isPause = false;
        #endregion

        #region 构造


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
                    EZSDK.OpenSDK_FiniLib();
                    m_disposed = true;
                }
            }
        }


        private void Error()
        {
            string mess = Marshal.PtrToStringAnsi(EZSDK.OpenSDK_GetLastErrorDesc());
            throw new Exception("Code:" + EZSDK.OpenSDK_GetLastErrorCode().ToString() + "\tMessage:"+ mess);
        }

        #endregion


        #region 属性  
        public bool IsConnected { get { return !string.IsNullOrEmpty(sid); } }
        public bool IsPlayBack { get { return isplay; } } 
        public bool IsPause { get { return isplay? isPause:false; } }
        public bool Preview { get { return islive; } }

        #endregion


        #region 连接

        private static int HandlerWork(string SID, uint iMsgType, uint iErrorCode, string pMessageInfo, IntPtr pUser)
        {
            return 0;//预留函数结构
        }
        public bool Connect(string authAddr, string openAddr, string szUrl, string AppId, string appSecret, Func<string, uint, uint, string, IntPtr,int> MessageHandler = null)
        {
            string Token = "";
            if (EZSDK.OpenSDK_InitLib(authAddr, openAddr, AppId) != 0)
                Error();
            if (File.Exists(System.Environment.CurrentDirectory + "\\token.ini"))
            {
                using (StreamReader writer = new StreamReader(System.Environment.CurrentDirectory + "\\token.ini"))
                {
                    string temp = writer.ReadToEnd();
                    dynamic tmp = JsonConvert.DeserializeObject<dynamic>(temp);
                    DateTime DT = tmp.expireTime;
                    if (DT > DateTime.Now)
                        Token = tmp.accessToken;
                    writer.Close();
                }
            }
            if (string.IsNullOrEmpty(Token))
            {
                IntPtr pBuf = new IntPtr();
                int iLength = 0;
                if (EZSDK.OpenSDK_HttpSendWithWait(szUrl, "appKey=" + AppId + "&appSecret=" + appSecret, "", ref pBuf, ref iLength) != 0)
                    Error();
                byte[] Data = new byte[iLength];
                Marshal.Copy(pBuf, Data, 0, iLength);
                var Tokenstr = Encoding.Default.GetString(Data, 0, iLength);
                dynamic json = JsonConvert.DeserializeObject<dynamic>(Tokenstr);
                long ms = json.data.expireTime;
                Token = json.data.accessToken;
                using (StreamWriter writer = new StreamWriter(System.Environment.CurrentDirectory + "\\token.ini", false))
                {
                    writer.WriteLine(JsonConvert.SerializeObject(new
                    {
                        expireTime = DateTime.Now.AddMilliseconds(ms),
                        accessToken = Token
                    }));
                    writer.Close();
                }
            }
            if (string.IsNullOrEmpty(Token))
                throw new Exception("Token获取失败");
            EZSDK.OpenSDK_SetAccessToken(Token);
            EZSDK.OpenSDK_MessageHandler Handler = null;
            if(MessageHandler==null)
                Handler= new EZSDK.OpenSDK_MessageHandler(HandlerWork);
            else
                Handler = new EZSDK.OpenSDK_MessageHandler(MessageHandler); 
            UserID = Marshal.StringToHGlobalAnsi(AppId);
            IntPtr pSession = new IntPtr();
            int iSessionLen = 0;
            if (EZSDK.OpenSDK_AllocSessionEx(Handler, UserID, ref pSession, ref iSessionLen) != 0)
                Error();
            byte[] pData = new byte[iSessionLen];
            Marshal.Copy(pSession, pData, 0, iSessionLen);
            sid = Encoding.Default.GetString(pData, 0, iSessionLen);
            return true;
        }

        public void DisConnect()
        {
            if (!string.IsNullOrEmpty(sid))
            {
                EZSDK.OpenSDK_FreeSession(sid);
                Marshal.FreeHGlobal(UserID);
            }
            sid = "";
            UserID = IntPtr.Zero;
        }
        #endregion

        #region 预览

        private static void CallBackWork(int enType, IntPtr pData, int iLen, IntPtr pUser)
        { 
        }

        public void RealPlay(string DevID, int CH, IntPtr Handle, string SafeKey = "ABCDEF", Action<int,  IntPtr, int, IntPtr> RealDataCallBack = null,int StreamType = 1 )
        {
            EZSDK.OpenSDK_DataCallBack Handler = null;
            if (RealDataCallBack == null)
                Handler = new EZSDK.OpenSDK_DataCallBack(CallBackWork);
            else
                Handler = new EZSDK.OpenSDK_DataCallBack(RealDataCallBack);
            if (EZSDK.OpenSDK_SetDataCallBack(sid, Handler, UserID) != 0)
                Error();
            if (EZSDK.OpenSDK_StartPlayWithStreamType(sid,Handle, DevID,CH, SafeKey, StreamType) != 0)
                Error();
            islive = true;
        }

        /// <summary>
        /// 停止预览
        /// </summary>
        public void RealStop()
        {
            EZSDK.OpenSDK_StopRealPlayEx(sid);
            islive = false;
        }

        #endregion

        #region 回放

        /// <summary>
        /// 是否有记录
        /// </summary>
        /// <param name="DevID"></param>
        /// <param name="CH"></param>
        /// <param name="SDT"></param>
        /// <param name="EDT"></param>
        /// <returns></returns>
        public bool PlayBackSearch(string DevID, int CH, DateTime SDT, DateTime EDT)
        {
            return EZSDK.OpenSDK_StartSearchEx(sid, DevID, CH, SDT.ToString("yyyy-MM-dd hh:mm:ss"), EDT.ToString("yyyy-MM-dd hh:mm:ss")) == 0;
        }

        /// <summary>
        /// 回放
        /// </summary>
        /// <param name="DevID"></param>
        /// <param name="CH"></param>
        /// <param name="Handle"></param>
        /// <param name="SDT"></param>
        /// <param name="EDT"></param>
        /// <param name="SafeKey"></param>
        public void PlayBackPlay(string DevID, int CH, IntPtr Handle, DateTime SDT, DateTime EDT, string SafeKey = "ABCDEF")
        { 
            if (EZSDK.OpenSDK_StartPlayBackEx(sid, Handle, DevID, CH, SafeKey, SDT.ToString("yyyy-MM-dd hh:mm:ss"), EDT.ToString("yyyy-MM-dd hh:mm:ss")) != 0)
                Error();
            isplay = true;
        }

        /// <summary>
        /// 停止回放
        /// </summary>
        public void PlayBackStop()
        {
            EZSDK.OpenSDK_StopPlayBackEx(sid);
            isplay = false;
        }

        /// <summary>
        /// 恢复
        /// </summary>
        public void PlayBackResume()
        {
            EZSDK.OpenSDK_PlayBackResume(sid);
            isPause = false;
        }

        /// <summary>
        /// 暂停
        /// </summary>
        public void PlayBackPause()
        {
            EZSDK.OpenSDK_PlayBackPause(sid);
            isPause = true;
        }

        #endregion

    }
}
