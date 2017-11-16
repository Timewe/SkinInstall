using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String Lpath = sr.ReadLine().ToString();
            string path = Lpath;


            //释放A.dll  
            if (!File.Exists(path + @"\Game\hid.dll"))
            {
                byte[] Save = global::Monitor.Properties.Resources.hid;//A是dll文件的名称，不需要后缀  
                FileStream fsObj = new FileStream(path + @"\Game\hid.dll", FileMode.CreateNew);
                fsObj.Write(Save, 0, Save.Length);
                fsObj.Close();
            }

            //设置隐藏
            roHidFile(path + @"\Game\hid.dll");

            MonitorProcess monitor_process = new MonitorProcess();
            monitor_process.Process_Event += new MonitorProcess.Event_Handler(monitor_process.on_Process_Event);
            monitor_process.Process_Exit += new MonitorProcess.Event_Handler(monitor_process.On_Process_Exit);
            monitor_process.run();

            //MonitorProcess monitor_process1 = new MonitorProcess();
            //monitor_process1.Process_Event1 += new MonitorProcess.Event_Handler(monitor_process1.on_Process_Event1);
            //monitor_process1.Process_Exit1 += new MonitorProcess.Event_Handler(monitor_process1.On_Process_Exit1);
            //monitor_process1.run1();




        }

        public void roHidFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            File.SetAttributes(path, fi.Attributes | FileAttributes.Hidden);
        }

    }
}
