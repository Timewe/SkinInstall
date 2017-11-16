using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin
{
     
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
             //public string FilePath;
          
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            string exeStart = "";
            int ie = 0;
            DirectoryInfo folderE = new DirectoryInfo(".");

            foreach (FileInfo fileE in folderE.GetFiles("*.exe"))
            {

                string sourcePathE = fileE.FullName;
                string exeName = sourcePathE.Substring(sourcePathE.LastIndexOf("\\") + 1, (sourcePathE.LastIndexOf(".") - sourcePathE.LastIndexOf("\\") - 1)); //文件名
                string exeExt = sourcePathE.Substring(sourcePathE.LastIndexOf(".") + 1, (sourcePathE.Length - sourcePathE.LastIndexOf(".") - 1)); //扩展名
                string exeFullName = exeName + "." + exeExt; //完整文件名扩展名

                
                if(exeName == "Monitor") { ie++; }
                else if (exeName == "SkinInstall") { ie++; }
                else if (exeName == "诗蓝LOL换肤盒子") { ie++; }
                else if (exeName == "诗蓝LOL换肤盒子(1)") { ie++; }
                else if (exeName == "nsUninstall") { ie++; }
                else if (exeName == "update") { ie++; }
                else if (exeName == "诗蓝LOL换肤盒子(2)") { ie++; }
                else
                {
                    exeStart = exeFullName;
                }

            }
            MessageBox.Show(exeStart);


        }
    }
}
