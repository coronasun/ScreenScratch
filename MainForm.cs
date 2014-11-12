using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Configuration;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Threading;

namespace ScreenScratch
{
    public partial class MainForm : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 选择文件存储路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fb.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = fb.SelectedPath.EndsWith("\\") ? fb.SelectedPath : fb.SelectedPath + "\\";
            }
            
        }
        /// <summary>
        /// 选择视频文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "播放列表(*.wpl;*.asx)|*.wpl;*.asx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPlaylist.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// 初始化配置文件，启动线程，初始化dtContent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.FilePath.Text) && !Directory.Exists(this.FilePath.Text))
            {
                Directory.CreateDirectory(this.FilePath.Text);
            }
        }
        /// <summary>
        /// 验证输入框的信息
        /// </summary>
        /// <returns></returns>
        private bool ValidateDetails()
        {
            if (string.IsNullOrEmpty(txtPlaylist.Text) || txtPlaylist.Text == null)
            {
                KryptonMessageBox.Show("请选择视频文件！");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// 开始启动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Startbutton_Click(object sender, EventArgs e)
        {
            if (!ValidateDetails()) return;
            Mediaplayer med = new Mediaplayer(this, txtPlaylist.Text.ToString());
        }
    }
}