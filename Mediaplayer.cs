using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Diagnostics;

namespace ScreenScratch
{
    public partial class Mediaplayer : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        DataSet ds = new DataSet();
        DataTable dtContent = new DataTable();
        private MainForm mainform;
        private bool flag = false;
        public int count = 0;


        public Mediaplayer()
        {
            InitializeComponent();
        }

        public Mediaplayer(MainForm mainform,string playlist)
        {
            InitializeComponent();
            this.mainform = mainform;
            dtContent.Columns.Add("time", typeof(Double));
            dtContent.Columns.Add("Contents", typeof(string));
            dtContent.TableName = "dtContent";
            MediaControl.URL = playlist;
            
        }
        /// <summary>
        /// 初始化xml文件
        /// </summary>
        /// <param name="xmlfilepath"></param>
        /// <returns></returns>
        private bool IntialXml(string xmlfilepath)
        {
            ds.Clear();
            dtContent.Clear();
            if (!File.Exists(xmlfilepath))
            {
                KryptonMessageBox.Show("xml文件不存在请检查!");
                return false;
            }
            ds.ReadXml(xmlfilepath);
            DataRow item;
            for (int i = 0; i < ds.Tables["d"].Rows.Count; i++)
            {
                item = ds.Tables["d"].Rows[i];
                if (item["d_Text"].ToString().StartsWith("%"))
                {
                    DataRow row = dtContent.NewRow();
                    row["time"] = Convert.ToDouble(item["p"].ToString().Substring(0, item["p"].ToString().IndexOf(",")));
                    row["Contents"] = item["d_Text"].ToString().Substring(1);
                    dtContent.Rows.Add(row);
                }
            }
            return true;
        }

        private void StartScratch(string filepath)
        {
            flag = true;
            string filename = "";
            try
            {
                for (int i = 0; i < dtContent.Rows.Count; i++)
                {
                    float timeposition = float.Parse(dtContent.Rows[i]["time"].ToString());
                    MediaControl.Ctlcontrols.currentPosition = timeposition;
                    MediaControl.Ctlcontrols.pause();
                    for (int j = 0; j < 1000000000; j++ )
                    {
                        ;
                    }
                    filename = GetFileName(filepath.Substring(0, filepath.LastIndexOf(".")), timeposition);
                    AddText(filename, dtContent.Rows[i]["Contents"].ToString());
                    MediaControl.Ctlcontrols.play();
                }
                flag = false;
                MediaControl.Ctlcontrols.next();
                count++;
            }
            catch (System.Exception ex)
            {
                KryptonMessageBox.Show("截图过程中出现错误");
            }
        }
        /// <summary>
        /// 为图片添加文字
        /// </summary>
        /// <param name="filepath"></param>
        private bool AddText(string picturename, string contents)
        {
            Screen scr = Screen.PrimaryScreen;
            Rectangle rc = scr.Bounds;
            int iWidth = rc.Width;
            int iHeight = rc.Height;
            Image myImage = new Bitmap(iWidth, iHeight);
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
            Font font = new Font("微软雅黑", RandomFontsize(9999));
            SolidBrush sbrush = new SolidBrush(Color.Red);
            SizeF sizeF = g.MeasureString(contents, font);
            string str = contents;
            if (Convert.ToInt32(iWidth - Convert.ToInt32(sizeF.Width)) < 0)
            {
                string str1 = str.Substring(0, (int)(str.Length / 2));
                string str2 = str.Substring((int)(str.Length / 2));
                int i = RandomNum(iHeight - Convert.ToInt32(sizeF.Height * 2));

                g.DrawString(str1, font, sbrush, new PointF(10, i));
                g.DrawString(str2, font, sbrush, new PointF(10, i + Convert.ToInt32(sizeF.Height) + 10));
            }
            else
            {
                g.DrawString(str, font, sbrush, new PointF(RandomNum(iWidth - Convert.ToInt32(sizeF.Width)), RandomNum(iHeight - Convert.ToInt32(sizeF.Height))));
            }
            myImage.Save(picturename);
            return true;
        }

        private static string GetFileName(string filepath, float TimePostion)
        {
            string str = "";
            if (File.Exists(filepath + ((int)(TimePostion / 60)).ToString("00") + "：" + ((int)(TimePostion % 60)).ToString("00") + ".jpg"))
                str = filepath + ((int)(TimePostion / 60)).ToString("00") + "：" + ((int)(TimePostion % 60) + 1).ToString("00") + ".jpg";
            else
                str = filepath + ((int)(TimePostion / 60)).ToString("00") + "：" + ((int)(TimePostion % 60)).ToString("00") + ".jpg";

            return str;
        }
        /// <summary>
        /// 随机数
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        private int RandomNum(int range)
        {
            int i = 0;
            Random random = new Random(System.DateTime.Now.Millisecond);
            i = random.Next(range);
            return i;
        }
        /// <summary>
        /// 随机字体大小
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        private int RandomFontsize(int range)
        {
            int i = 0;
            Random random = new Random(System.DateTime.Now.Millisecond);
            i = random.Next(range);
            switch (i % 3)
            {
                case 0:
                    i = 34;
                    break;
                case 1:
                    i = 36;
                    break;
                case 2:
                    i = 38;
                    break;
            }
            return i;
        }

        private void MediaControl_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MediaControl.playState == WMPLib.WMPPlayState.wmppsPlaying && !flag)
            {
                String str = MediaControl.currentMedia.getItemInfo("sourceURL");
                if (File.Exists(str.Substring(0, str.LastIndexOf(".")) + ".Xml"))
                {
                    if (IntialXml(str.Substring(0, str.LastIndexOf(".")) + ".Xml"))
                    {
                        StartScratch(mainform.FilePath.Text + str.Substring(str.LastIndexOf("\\") + 1));
                    }
                }
            }
            else if (MediaControl.currentPlaylist.count == count)
            {
                this.Close();
                this.Dispose();
                string path = mainform.FilePath.Text;
                System.Diagnostics.Process.Start("explorer.exe", path);
            }
        }
    }
}