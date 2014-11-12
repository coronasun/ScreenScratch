namespace ScreenScratch
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.FilePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnFilePath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Cancelbutton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Startbutton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtPlaylist = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnChoosePlaylist = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(236, 143);
            this.kryptonPanel.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.FilePath);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnFilePath);
            this.kryptonGroupBox2.Panel.Controls.Add(this.Cancelbutton);
            this.kryptonGroupBox2.Panel.Controls.Add(this.Startbutton);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txtPlaylist);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnChoosePlaylist);
            this.kryptonGroupBox2.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(236, 143);
            this.kryptonGroupBox2.TabIndex = 6;
            this.kryptonGroupBox2.Text = "设置";
            this.kryptonGroupBox2.Values.Heading = "设置";
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(90, 11);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(103, 24);
            this.FilePath.TabIndex = 0;
            this.FilePath.Text = "D:\\Images\\";
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(188, 11);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(31, 24);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Values.Text = "...";
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelbutton.Location = new System.Drawing.Point(129, 81);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(90, 25);
            this.Cancelbutton.TabIndex = 4;
            this.Cancelbutton.Values.Text = "停止";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(25, 81);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(90, 25);
            this.Startbutton.TabIndex = 4;
            this.Startbutton.Values.Text = "开始";
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "存储路径：";
            // 
            // txtPlaylist
            // 
            this.txtPlaylist.Location = new System.Drawing.Point(90, 42);
            this.txtPlaylist.Multiline = true;
            this.txtPlaylist.Name = "txtPlaylist";
            this.txtPlaylist.ReadOnly = true;
            this.txtPlaylist.Size = new System.Drawing.Size(103, 24);
            this.txtPlaylist.TabIndex = 5;
            // 
            // btnChoosePlaylist
            // 
            this.btnChoosePlaylist.Location = new System.Drawing.Point(188, 42);
            this.btnChoosePlaylist.Name = "btnChoosePlaylist";
            this.btnChoosePlaylist.Size = new System.Drawing.Size(31, 24);
            this.btnChoosePlaylist.TabIndex = 6;
            this.btnChoosePlaylist.Values.Text = "...";
            this.btnChoosePlaylist.Click += new System.EventHandler(this.btnChooseFiles_Click);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(11, 45);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel5.TabIndex = 4;
            this.kryptonLabel5.Values.Text = "播放列表：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelbutton;
            this.ClientSize = new System.Drawing.Size(236, 143);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "截图";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private System.Windows.Forms.Timer timer;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Cancelbutton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Startbutton;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPlaylist;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChoosePlaylist;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox FilePath;
    }
}

