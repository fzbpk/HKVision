using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HKDriver;
using EZUiKit;
namespace HKVision
{
    public partial class Form1 : Form
    {
        EZDVR ez = new EZDVR();
        HKDVR hik = new HKDVR();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            hik.Connect("192.168.2.88", 8000, "admin", "1qaz2wsX");  
        }

        private void Hik_StdDataEvent(int lRealHandle, int dwDataType, ref byte[] pBuffer, uint dwBufSize, IntPtr dwUser)
        {
            switch (dwDataType)
            {

            }
        }

        private void Hik_RealDataCallBack(int lRealHandle, int dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr pUser)
        {
            switch (dwDataType)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hik.StopRec();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hik.StartRec(1, "f:\\xx.mp4", this.pictureBox1.Handle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hik.DisConnect();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image ss = hik.CaptureJPG(1);
            this.pictureBox2.Image = ss;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hik.RealPlay(1, this.pictureBox1.Handle);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hik.RealStop();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ez.Connect("https://auth.ys7.com", "https://open.ys7.com", "https://open.ys7.com/api/lapp/token/get", "a9559906141646bf960e8fcacfc002ed", "9ee3cbd1c00f89a302aab3a437f1766d");
             ez.RealPlay("771781477", 1, this.pictureBox1.Handle);
           // ez.PlayBackPlay("771781477", 1, this.pictureBox1.Handle, DateTime.Now.AddDays(-1), DateTime.Now);
        }
    }
}
