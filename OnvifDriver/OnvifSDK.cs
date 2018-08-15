using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using Ozeki.Media;
using Ozeki.Media.IPCamera;
using Ozeki.Media.MediaHandlers;
using Ozeki.Media.MediaHandlers.Video;
using Ozeki.Media.Video.Controls;

namespace OnvifDriver
{
    public class OnvifSDK
    {

        private IIPCamera _camera=null;
        private DrawingImageProvider _imageProvider = new DrawingImageProvider();
        private MediaConnector _connector = new MediaConnector();
        private VideoViewerWF _videoViewerWF1;

        public Panel VideoPanel { get; set; }

        #region 连接

        public bool Connect(string DVRIPAddress, ushort DVRPortNumber, string DVRUserName, string DVRPassword)
        {
            _videoViewerWF1 = new VideoViewerWF();
            _videoViewerWF1.Name = "OnvifPreview";
            _videoViewerWF1.Size = VideoPanel.Size;
            VideoPanel.Controls.Add(_videoViewerWF1);  
            _videoViewerWF1.SetImageProvider(_imageProvider);
            _camera = IPCameraFactory.GetCamera(string.Format("{0}:{1}", DVRIPAddress, DVRPortNumber.ToString()), DVRUserName, DVRPassword);
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _camera.Start();
            _videoViewerWF1.Start();
            return true;
        }

        public void DisConnect()
        {
             
        }

        #endregion

        #region 抓拍

        /// <summary>
        /// 抓图
        /// </summary> 
        /// </param>
        /// <returns></returns>
        public Image CaptureJPG()
        {
           
            return null;
        }

        #endregion

    }
}
