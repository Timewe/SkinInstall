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
using System.Configuration;

namespace SkinInstall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        //string lolPath = "";



        string zipPath = "\\Game\\Zipdir";
        string skinPath = "\\Game\\Zipdir\\Skindir";

        ListViewItem item = new ListViewItem();

        private void Form1_Load(object sender, EventArgs e)
        {



            this.Hide();
            this.ShowInTaskbar = true;
            this.notifyIcon1.Visible = true;

            //初始化
            Unistall();

            //启动程序
            Process.Start("诗蓝LOL换肤盒子.exe");
            Process.Start("Monitor.exe");

            //安装皮肤
            Install();
          


        }


       
        private void Install()
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();

            #region  创建目录与初始化txt
            if (!Directory.Exists(lolPath + zipPath))
            {
                try
                {
                    Directory.CreateDirectory(lolPath + zipPath);
                }
                catch (Exception)
                {

                    throw new Exception("创建目标目录Zipdir失败！请以管理员身份重新运行！");
                }

            }
            if (!Directory.Exists(lolPath + skinPath))
            {
                try
                {
                    Directory.CreateDirectory(lolPath + skinPath);
                }
                catch (Exception)
                {

                    throw new Exception("创建目标目录Skindir失败！请以管理员身份重新运行！");
                }

            }

            //删除txt文件
            if (File.Exists(lolPath + @"\Game\ClientZips.txt"))
            {
                try
                {
                    File.Delete(lolPath + @"\Game\ClientZips.txt");
                }
                catch (Exception)
                {

                    throw new Exception("初始化ClientZips.txt文件失败，请以管理员身份重新运行！");
                }
            }

            #endregion


            #region//释放txt文件

            try
            {
                byte[] Save = global::SkinInstall.Properties.Resources.ClientZips;//A是dll文件的名称，不需要后缀  
                FileStream fsObj = new FileStream(lolPath + @"\Game\ClientZips.txt", FileMode.CreateNew);
                fsObj.Write(Save, 0, Save.Length);
                fsObj.Close();
            }
            catch (Exception)
            {

                throw new Exception("初始化ClientZips.txt文件失败，请以管理员身份重新运行！");
            }
            #endregion



            DirectoryInfo folderS = new DirectoryInfo(lolPath + skinPath);
            DirectoryInfo folderZ = new DirectoryInfo(lolPath + zipPath);
            int i = 1;
            string stat = "";

            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁  并大大提高加载速度
            #region 软件进入之后挂载已经标记"已挂载"的压缩包


            foreach (FileInfo fileS in folderS.GetFiles("*.zip"))
            {

                string sourcePathS = fileS.FullName;
                string skinName = sourcePathS.Substring(sourcePathS.LastIndexOf("\\") + 1, (sourcePathS.LastIndexOf(".") - sourcePathS.LastIndexOf("\\") - 1)); //文件名
                string skinExt = sourcePathS.Substring(sourcePathS.LastIndexOf(".") + 1, (sourcePathS.Length - sourcePathS.LastIndexOf(".") - 1)); //扩展名
                string skinFullName = skinName + "." + skinExt; //完整文件名扩展名

                //MessageBox.Show(skinFullName);

                try
                {
                    StreamWriter sw = new StreamWriter(lolPath + "\\Game\\ClientZips.txt", true, Encoding.Default);
                    sw.WriteLine("Zipdir\\Skindir\\" + skinFullName);
                    sw.Close();
                }
                catch (Exception)
                {

                    throw new Exception("挂载失败，请以管理员身份重新运行！");
                }

                stat = "已挂载";
                item = listView1.Items.Add(i.ToString());
                item.SubItems.Add(skinName);
                item.SubItems.Add(stat);
                item.SubItems.Add(stat);
                i++;


            }
            #endregion


            #region    #region 软件进入之后显示已经标记"未挂载"的压缩包

            int j = i;
            foreach (FileInfo fileZ in folderZ.GetFiles("*.zip"))
            {

                string sourcePathS = fileZ.FullName;
                string skinName = sourcePathS.Substring(sourcePathS.LastIndexOf("\\") + 1, (sourcePathS.LastIndexOf(".") - sourcePathS.LastIndexOf("\\") - 1)); //文件名
                string skinExt = sourcePathS.Substring(sourcePathS.LastIndexOf(".") + 1, (sourcePathS.Length - sourcePathS.LastIndexOf(".") - 1)); //扩展名
                string skinFullName = skinName + "." + skinExt; //完整文件名扩展名


                stat = "未挂载";
                item = listView1.Items.Add(j.ToString());
                item.SubItems.Add(skinName);
                item.SubItems.Add(stat);
                item.SubItems.Add(stat);
                j++;


            }
            #endregion
            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void Unistall()
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            //删除txt文件
            if (File.Exists(lolPath + @"\Game\ClientZips.txt"))
            {
                try
                {
                    File.Delete(lolPath + @"\Game\ClientZips.txt");
                }
                catch (Exception)
                {

                    throw new Exception("还原ClientZips.txt文件失败，请以管理员身份重新运行！");
                }
            }
            //还原txt
            try
            {
                byte[] Save = global::SkinInstall.Properties.Resources.ClientZips;//A是dll文件的名称，不需要后缀  
                FileStream fsObj = new FileStream(lolPath + @"\Game\ClientZips.txt", FileMode.CreateNew);
                fsObj.Write(Save, 0, Save.Length);
                fsObj.Close();
            }
            catch (Exception)
            {

                throw new Exception("还原ClientZips.txt文件失败，请以管理员身份重新运行！");
            }


            //删除hid文件
            if (File.Exists(lolPath + @"\Game\hid.dll"))
            {
                try
                {
                    File.Delete(lolPath + @"\Game\hid.dll");
                }
                catch (Exception)
                {

                    throw new Exception("清除残留文件失败，请以管理员身份重新运行！");
                }
            }



            }
        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();

            #region  压缩包挂载过程
            string sourcePath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();

            string skinName = sourcePath.Substring(sourcePath.LastIndexOf("\\") + 1, (sourcePath.LastIndexOf(".") - sourcePath.LastIndexOf("\\") - 1)); //文件名
            string skinExt = sourcePath.Substring(sourcePath.LastIndexOf(".") + 1, (sourcePath.Length - sourcePath.LastIndexOf(".") - 1)); //扩展名
            string skinFullName = skinName + "." + skinExt; //完整文件名扩展名


            try
            {
                bool isrewrite = true; // true=覆盖已存在的同名文件,false则反之
                if (File.Exists(lolPath + zipPath + "\\" + skinFullName))
                {
                    File.Delete(lolPath + zipPath + "\\" + skinFullName);
                }
                File.Copy(sourcePath, lolPath + skinPath + "\\" + skinFullName, isrewrite);//复制到指定目录
                this.listView1.Items.Clear();  //只移除所有的项。
                Install(); //挂载
            }
            catch (Exception)
            {

                throw new Exception("操作失败，请以管理员身份重新运行！");
            }
            #endregion
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.listView1.SelectedItems.Count > 0)
                {
                    this.contextMenuStrip2.Show(this, e.Location);

                }
                else
                {
                    this.contextMenuStrip2.Hide();
                }
            }
        }



        public void DeleteFile(string file)
        {
            //去除文件夹和子文件的只读属性
            //去除文件夹的只读属性
            System.IO.DirectoryInfo fileInfo = new DirectoryInfo(file);
            fileInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;
            //去除文件的只读属性
            System.IO.File.SetAttributes(file, System.IO.FileAttributes.Normal);
            //判断文件夹是否还存在
            if (Directory.Exists(file))
            {
                foreach (string f in Directory.GetFileSystemEntries(file))
                {
                    if (File.Exists(f))
                    {
                        //如果有子文件删除文件
                        File.Delete(f);
                    }
                    else
                    {
                        //循环递归删除子文件夹 
                        DeleteFile(f);
                    }
                }
                //删除空文件夹 
                Directory.Delete(file);
            }
        }


        //关闭窗口事件，释放资源
        //protected override void WndProc(ref Message msg)
        //{
        //    const int WM_SYSCOMMAND = 0x0112;
        //    const int SC_CLOSE = 0xF060;
        //    if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
        //    {
        //        // 点击winform右上关闭按钮 
        //        // 加入想要的逻辑处

        //        try
        //        {
        //            Process[] ps = Process.GetProcessesByName("Monitor");
        //            foreach (Process p in ps)
        //            {

        //                p.Kill();
        //                p.Dispose();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }

        //    }
        //    base.WndProc(ref msg);
        //}


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)    //最小化到系统托盘
            {
                notifyIcon1.Visible = true;    //显示托盘图标
                this.Hide();    //隐藏窗口
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //注意判断关闭事件Reason来源于窗体按钮，否则用菜单退出时无法退出!
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;    //取消"关闭窗口"事件
                this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
                notifyIcon1.Visible = true;
                this.Hide();
                return;
            }

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = true;

        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = true;

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = true;
            this.ShowInTaskbar = true;
            
                try
                {
                    Process[] ps = Process.GetProcessesByName("Monitor");
                    foreach (Process p in ps)
                    {
                        p.Kill();
                        p.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                //卸载残留
                Unistall();
                this.Dispose();
                this.Close();
         

        }

        private void 卸载当前皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            String selectName = listView1.SelectedItems[0].SubItems[1].Text; //获取选中压缩包文件名 
            string selectStat = listView1.SelectedItems[0].SubItems[2].Text; //获取选中压缩包文件名

            if (selectStat == "已挂载")
            {
                try
                {
                    if (File.Exists(lolPath + zipPath + "\\" + selectName + ".zip"))
                    {
                        File.Delete(lolPath + zipPath + "\\" + selectName + ".zip");
                    }

                    File.Move(lolPath + skinPath + "\\" + selectName + ".zip", lolPath + zipPath + "\\" + selectName + ".zip");//复制到指定目录
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            }
            else
            {
                MessageBox.Show("请勿重复卸载皮肤！！");
            }
        }

        private void 挂载当前皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {



            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            String selectName = listView1.SelectedItems[0].SubItems[1].Text; //获取选中压缩包文件名 
            string selectStat = listView1.SelectedItems[0].SubItems[2].Text; //获取选中压缩包文件名

            if (selectStat == "未挂载")
            {

                try
                {

                    File.Move(lolPath + zipPath + "\\" + selectName + ".zip", lolPath + skinPath + "\\" + selectName + ".zip");//复制到指定目录
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            }
            else
            {
                MessageBox.Show("请勿重复挂载皮肤！！");
            }
        }

        private void 删除当前皮肤ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            String selectName = listView1.SelectedItems[0].SubItems[1].Text; //获取选中压缩包文件名 
            string selectStat = listView1.SelectedItems[0].SubItems[2].Text; //获取选中压缩包文件名 
            if (selectStat == "已挂载")
            {
                try
                {

                    File.Delete(lolPath + skinPath + "\\" + selectName + ".zip");
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            }
            else
            {
                try
                {

                    File.Delete(lolPath + zipPath + "\\" + selectName + ".zip");
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            }
        }

        private void 卸载所有皮肤ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();

            List<string> files = new List<string>(Directory.GetFiles(lolPath + skinPath));
            files.ForEach(c =>
            {
                string destFile = Path.Combine(new string[] { lolPath + zipPath, Path.GetFileName(c) });
                try
                {
                    //覆盖模式  
                    if (File.Exists(destFile))
                    {
                        File.Delete(destFile);
                    }
                    File.Move(c, destFile);
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            });
        }

        private void 挂载所有皮肤ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            List<string> files = new List<string>(Directory.GetFiles(lolPath + zipPath));
            files.ForEach(c =>
            {
                string destFile = Path.Combine(new string[] { lolPath + skinPath, Path.GetFileName(c) });
                try
                {
                    //覆盖模式  
                    if (File.Exists(destFile))
                    {
                        File.Delete(destFile);
                    }
                    File.Move(c, destFile);
                    this.listView1.Items.Clear();  //只移除所有的项。
                    Install(); //挂载
                }
                catch (Exception)
                {

                    throw new Exception("操作失败，请以管理员身份重新运行！");
                }
            });
        }

        private void 删除所有皮肤ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Path.ini", Encoding.Default);
            String lolPath = sr.ReadLine().ToString();
            try
            {

                DeleteFile(lolPath + zipPath);
                Install(); //挂载
                this.listView1.Items.Clear();  //只移除所有的项。
            }
            catch (Exception)
            {

                throw new Exception("操作失败，请以管理员身份重新运行！");
            }
        }

        #region// 移动窗体
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // 窗体上鼠标按下时
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & this.WindowState == FormWindowState.Normal)
            {
                // 移动窗体
                this.Capture = false;
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("您确认退出吗？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Process[] ps = Process.GetProcessesByName("Monitor");
                    foreach (Process p in ps)
                    {
                        p.Kill();
                        p.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //卸载残留
                Unistall(); 
                this.Dispose();
                this.Close();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;    //使关闭时窗口向右下角缩小的效果
            notifyIcon1.Visible = true;
            this.Hide();
            return;
        }
    }
}
