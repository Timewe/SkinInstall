using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monitor
{
    class MonitorProcess
    {
        bool finished = false;//用于标识进程开启与否
                              //委托的声明
        public delegate void Event_Handler(object sender, EventArgs strEventArg);
        //用委托声明两个事件
        public event Event_Handler Process_Event;
        public event Event_Handler Process_Exit;
        //public event Event_Handler Process_Event1;
        //public event Event_Handler Process_Exit1;



        public void run()
        {
            int flag = 0;
            do
            {
                if (finished == false)
                {
                    //获取系统的所有进程
                    System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        if (String.Compare(processes[i].ProcessName, "League of Legends", true) == 0)
                        {
                            Process_Event(this, new EventArgs());//产生事件
                            finished = true;
                            break;
                        }
                    }
                }
                if (finished == true)
                {
                    System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        if (String.Compare(processes[i].ProcessName, "League of Legends", true) == 0)
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        Process_Exit(this, new EventArgs());//产生事件
                        finished = false;
                    }
                    else flag = 0;
                }

            }
            while (true);


        }

        //public void run1()
        //{

        //    string exeStart = "";
        //    int ie = 0;
        //    DirectoryInfo folderE = new DirectoryInfo(".");

        //    foreach (FileInfo fileE in folderE.GetFiles("*.exe"))
        //    {

        //        string sourcePathE = fileE.FullName;
        //        string exeName = sourcePathE.Substring(sourcePathE.LastIndexOf("\\") + 1, (sourcePathE.LastIndexOf(".") - sourcePathE.LastIndexOf("\\") - 1)); //文件名
        //        string exeExt = sourcePathE.Substring(sourcePathE.LastIndexOf(".") + 1, (sourcePathE.Length - sourcePathE.LastIndexOf(".") - 1)); //扩展名
        //        string exeFullName = exeName + "." + exeExt; //完整文件名扩展名


        //        if (exeName == "Monitor") { ie++; }
        //        else if (exeName == "SkinInstall") { ie++; }
        //        else if (exeName == "诗蓝LOL换肤盒子") { ie++; }
        //        else if (exeName == "诗蓝LOL换肤盒子(1)") { ie++; }
        //        else if (exeName == "nsUninstall") { ie++; }
        //        else if (exeName == "update") { ie++; }
        //        else if (exeName == "诗蓝LOL换肤盒子(2)") { ie++; }
        //        else
        //        {
        //            exeStart = exeFullName;
        //        }

        //    }



        //    int flag = 0;
        //    do
        //    {
        //        if (finished == false)
        //        {
        //            //获取系统的所有进程
        //            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
        //            for (int i = 0; i < processes.Length; i++)
        //            {
        //                if (String.Compare(processes[i].ProcessName, exeStart, true) == 0)
        //                {
        //                    Process_Event1(this, new EventArgs());//产生事件
        //                    finished = true;
        //                    break;
        //                }
        //            }
        //        }
        //        if (finished == true)
        //        {
        //            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
        //            for (int i = 0; i < processes.Length; i++)
        //            {
        //                if (String.Compare(processes[i].ProcessName, exeStart, true) == 0)
        //                {
        //                    flag = 1;
        //                    break;
        //                }
        //            }
        //            if (flag == 0)
        //            {
        //                Process_Exit1(this, new EventArgs());//产生事件
        //                finished = false;
        //            }
        //            else flag = 0;
        //        }

        //    }
        //    while (true);


        //}
        //进程启动时的处理函数
        public void on_Process_Event(object sender, EventArgs strEventArg)
        {
          

        }
        //进程结束时的处理函数
        public void On_Process_Exit(object sender, EventArgs strEventArg)
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

        }


        //public void on_Process_Event1(object sender, EventArgs strEventArg)
        //{


        //}
        ////进程结束时的处理函数
        //public void On_Process_Exit1(object sender, EventArgs strEventArg)
        //{

        //    //MessageBox.Show("123");
        //    //Process[] ps = Process.GetProcessesByName("SkinInstall");
        //    //foreach (Process p in ps)
        //    //{
        //    //    p.Kill();
        //    //    p.Dispose();
        //    //}
        //    Process.Start("nsUninstall.exe");

        //}

        public void roHidFile(string path)
        {
            FileInfo fi = new FileInfo(path);
            File.SetAttributes(path, fi.Attributes | FileAttributes.Hidden);
        }



    }
}
