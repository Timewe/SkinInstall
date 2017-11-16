using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Loading
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int i = 0;
        private void Loading_Load(object sender, EventArgs e)
        {
            //检查更新
            CheckNewVersion();
            if(i==0)
            {
                //初始化
                Initialize();
                Process.Start("SkinInstall.exe");
                this.Close();
                this.Dispose();
            }

        }

        private void Initialize()
        {
            Process[] s = Process.GetProcessesByName("SkinInstall");
            if (s.Length > 0)
            {
                foreach (Process p1 in s)
                {
                    p1.Kill();
                    p1.Dispose();
                }
            }
            Process[] m = Process.GetProcessesByName("Monitor");
            if (m.Length > 0)
            {
                foreach (Process p2 in m)
                {
                    p2.Kill();
                    p2.Dispose();
                }
            }
           
          
        }

        private bool CheckUpdateServerState(string host)
        {
            try
            {
                Ping ping = new Ping();
                return (ping.Send(host).Status == IPStatus.Success);
            }
            catch
            {
                return false;
            }
        }
        private void CheckNewVersion()
        {
            if (this.CheckUpdateServerState("www.timeweii.com"))
            {
                //Version version = Assembly.GetExecutingAssembly().GetName().Version;
                try
                {
                    new WebClient();
                    XmlDocument document = new XmlDocument();
                    document.Load("http://www.timeweii.com/BatchRenameVersion.xml");
                    Version version2 = new Version(document.SelectSingleNode("/ver/newVer").InnerText);
                    Version version = new Version(document.SelectSingleNode("/ver/nowVer").InnerText);

                    //if ((version2 > version) && (MessageBox.Show(string.Format("当前程序版本：{0}\r\n发现有新版本：{1}\r\n新版特性：\r\n{2}\r\n\r\n是否下载？", version.ToString(), version2.ToString(), document.SelectSingleNode("/ver/updateInfo").InnerText), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    if (version2 > version)
                      {
                        MessageBox.Show(string.Format("当前程序版本：{0}\r\n发现有新版本：{1}\r\n新版特性：\r\n{2}\r\n\r\n是否下载？", version.ToString(), version2.ToString(), document.SelectSingleNode("/ver/updateInfo").InnerText));
                        Process.Start(document.SelectSingleNode("/ver/downloadUrl").InnerText);
                        this.Close();
                        this.Dispose();
                        i = 1;
                       }
                   
                 }
                catch (Exception)
                 {
                 }
             
            }

          

           

        }

      


    }
}
