using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace EZUiKit 
{
    public class EZSDK
    {
        private const string DLLPath= @"EZUiKit\OpenNetStream.dll";

        [DllImport(DLLPath)]
        public static extern int OpenSDK_GetLastErrorCode();

        [DllImport(DLLPath)]
        public static extern IntPtr OpenSDK_GetLastErrorDesc();

        [DllImport(DLLPath)]
        public static extern int OpenSDK_InitLib(string AuthAddr, string Platform, string AppId);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_FiniLib();

        [DllImport(DLLPath)]
        public static extern int OpenSDK_Mid_Login(ref IntPtr pToken, ref int TokenLth);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_HttpSendWithWait(string szUri, string szHeaderParam,string szBody, ref IntPtr pBuf, ref int iLength);


        [DllImport(DLLPath)]
        public static extern int OpenSDK_SetAccessToken(string szAccessToken);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_AllocSessionEx(OpenSDK_MessageHandler pHandle, IntPtr pUser, ref IntPtr pSession, ref int iSessionLen);
          
        [DllImport(DLLPath)] 
        public static extern int OpenSDK_FreeSession(string SID);

        [DllImport(DLLPath)] 
        public static extern int OpenSDK_StartPlayWithStreamType(string SID, IntPtr PlayWnd,  string szDevSerial, int iChannelNo,string szSafeKey,int iStreamType);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_StartRealPlayEx(string SID, IntPtr PlayWnd, string szDevSerial, int iChannelNo, string szSafeKey);


        [DllImport(DLLPath)] 
        public static extern int OpenSDK_StopRealPlayEx(string SID);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_StartSearchEx(string SID, string szDevSerial, int iChannelNo, string szStartTime,string szStopTime);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_StartPlayBackEx(string SID, IntPtr PlayWnd, string szDevSerial, int iChannelNo, string szSafeKey, string szStartTime, string szStopTime);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_PlayBackResume(string SID);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_PlayBackPause(string SID);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_StopPlayBackEx(string SID);

        [DllImport(DLLPath)]
        public static extern int OpenSDK_SetDataCallBack(string SID , OpenSDK_DataCallBack pDataCallBack, IntPtr pUser);

        public delegate int OpenSDK_MessageHandler(string SID, uint iMsgType, uint iErrorCode, string pMessageInfo, IntPtr pUser);

        public delegate void OpenSDK_DataCallBack(int enType,IntPtr pData, int iLen, IntPtr pUser);

    }
}
