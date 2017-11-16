using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertExe
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        exetowinform fr = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog Oppf = new OpenFileDialog();
            //Oppf.ShowDialog();
            //if (Oppf.FileName != "")
            //{
            //    panel1.Controls.Clear();
            //    fr = new exetowinform(panel1, "");
            //    fr.Start(Oppf.FileName);
   
        }

        /// <summary>  
        /// 用鼠标将某项拖动到该工作区时  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件  
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>  
        /// 拖放完成时  
        /// </summary>  
        /// <param name="sender"></param>  
        /// <param name="e"></param>  
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);//拖放的多个文件的路径列表  
            this.textBox1.Text = filePaths[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
      
      
 }


