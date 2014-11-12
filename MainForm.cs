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
        /// ѡ���ļ��洢·��
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
        /// ѡ����Ƶ�ļ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChooseFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "�����б�(*.wpl;*.asx)|*.wpl;*.asx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPlaylist.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// ��ʼ�������ļ��������̣߳���ʼ��dtContent
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
        /// ��֤��������Ϣ
        /// </summary>
        /// <returns></returns>
        private bool ValidateDetails()
        {
            if (string.IsNullOrEmpty(txtPlaylist.Text) || txtPlaylist.Text == null)
            {
                KryptonMessageBox.Show("��ѡ����Ƶ�ļ���");
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// ��ʼ����
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