using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HKDriver 
{
    /// <summary>
    /// 设备类型
    /// </summary>
    public enum DevType:int
    {
        None=0,
        IPC,
        NVR
    }

    /// <summary>
    /// 连接方式
    /// </summary>
    public enum LinkMode : int
    {
        TCP = 0,
        UDP,
        Multicast,
        RTP,
        RTSP,
        HTTP
    }

}
