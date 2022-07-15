
namespace NotePaper
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.navigationBar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.anaPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalNote = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.addTxtFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton8 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton7 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.nightPicOpenMenu = new System.Windows.Forms.PictureBox();
            this.toggleOpenMenu = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.closedMenu = new System.Windows.Forms.Panel();
            this.menuOpenButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton12 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton11 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton10 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton9 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.menuOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.navigationBar.SuspendLayout();
            this.anaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightPicOpenMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.closedMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            resources.ApplyResources(this.guna2CircleButton1, "guna2CircleButton1");
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2CircleButton2
            // 
            resources.ApplyResources(this.guna2CircleButton2, "guna2CircleButton2");
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // guna2CircleButton3
            // 
            resources.ApplyResources(this.guna2CircleButton3, "guna2CircleButton3");
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton3.Image")));
            this.guna2CircleButton3.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Click += new System.EventHandler(this.guna2CircleButton3_Click);
            // 
            // guna2CircleButton4
            // 
            resources.ApplyResources(this.guna2CircleButton4, "guna2CircleButton4");
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton4.Image")));
            this.guna2CircleButton4.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.Click += new System.EventHandler(this.guna2CircleButton4_Click);
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.Transparent;
            this.navigationBar.Controls.Add(this.navPanel);
            this.navigationBar.Controls.Add(this.guna2CircleButton4);
            this.navigationBar.Controls.Add(this.guna2CircleButton1);
            this.navigationBar.Controls.Add(this.guna2CircleButton3);
            this.navigationBar.Controls.Add(this.guna2CircleButton2);
            resources.ApplyResources(this.navigationBar, "navigationBar");
            this.navigationBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.navigationBar.ShadowShift = 4;
            // 
            // navPanel
            // 
            resources.ApplyResources(this.navPanel, "navPanel");
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.navPanel.Name = "navPanel";
            // 
            // anaPanel
            // 
            resources.ApplyResources(this.anaPanel, "anaPanel");
            this.anaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(115)))));
            this.anaPanel.Controls.Add(this.pictureBox3);
            this.anaPanel.Controls.Add(this.pictureBox2);
            this.anaPanel.Controls.Add(this.pictureBox1);
            this.anaPanel.Controls.Add(this.totalNote);
            this.anaPanel.Controls.Add(this.dateLabel);
            this.anaPanel.Controls.Add(this.guna2ToggleSwitch1);
            this.anaPanel.Controls.Add(this.guna2Button2);
            this.anaPanel.Controls.Add(this.guna2Button1);
            this.anaPanel.Name = "anaPanel";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // totalNote
            // 
            resources.ApplyResources(this.totalNote, "totalNote");
            this.totalNote.BackColor = System.Drawing.Color.Transparent;
            this.totalNote.ForeColor = System.Drawing.Color.White;
            this.totalNote.Name = "totalNote";
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.dateLabel, "dateLabel");
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Name = "dateLabel";
            // 
            // guna2ToggleSwitch1
            // 
            resources.ApplyResources(this.guna2ToggleSwitch1, "guna2ToggleSwitch1");
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.navPanel;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.guna2Button5);
            this.menuPanel.Controls.Add(this.addTxtFileButton);
            this.menuPanel.Controls.Add(this.guna2Button4);
            this.menuPanel.Controls.Add(this.guna2CircleButton8);
            this.menuPanel.Controls.Add(this.guna2CircleButton7);
            this.menuPanel.Controls.Add(this.guna2CircleButton6);
            this.menuPanel.Controls.Add(this.guna2CircleButton5);
            this.menuPanel.Controls.Add(this.nightPicOpenMenu);
            this.menuPanel.Controls.Add(this.toggleOpenMenu);
            this.menuPanel.Controls.Add(this.pictureBox5);
            this.menuPanel.Controls.Add(this.guna2HtmlLabel2);
            this.menuPanel.Controls.Add(this.pictureBox4);
            this.menuPanel.Controls.Add(this.menuDateLabel);
            this.menuPanel.Name = "menuPanel";
            // 
            // guna2Button5
            // 
            resources.ApplyResources(this.guna2Button5, "guna2Button5");
            this.guna2Button5.BorderRadius = 10;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // addTxtFileButton
            // 
            this.addTxtFileButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addTxtFileButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addTxtFileButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addTxtFileButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.addTxtFileButton, "addTxtFileButton");
            this.addTxtFileButton.ForeColor = System.Drawing.Color.White;
            this.addTxtFileButton.Image = ((System.Drawing.Image)(resources.GetObject("addTxtFileButton.Image")));
            this.addTxtFileButton.Name = "addTxtFileButton";
            this.addTxtFileButton.Click += new System.EventHandler(this.addTxtFileButton_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.guna2Button4, "guna2Button4");
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2CircleButton8
            // 
            resources.ApplyResources(this.guna2CircleButton8, "guna2CircleButton8");
            this.guna2CircleButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton8.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton8.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton8.Image")));
            this.guna2CircleButton8.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton8.Name = "guna2CircleButton8";
            this.guna2CircleButton8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton8.Click += new System.EventHandler(this.guna2CircleButton8_Click);
            // 
            // guna2CircleButton7
            // 
            resources.ApplyResources(this.guna2CircleButton7, "guna2CircleButton7");
            this.guna2CircleButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton7.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton7.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton7.Image")));
            this.guna2CircleButton7.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton7.Name = "guna2CircleButton7";
            this.guna2CircleButton7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton7.Click += new System.EventHandler(this.guna2CircleButton7_Click);
            // 
            // guna2CircleButton6
            // 
            resources.ApplyResources(this.guna2CircleButton6, "guna2CircleButton6");
            this.guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton6.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton6.Image")));
            this.guna2CircleButton6.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton6.Name = "guna2CircleButton6";
            this.guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton6.Click += new System.EventHandler(this.guna2CircleButton6_Click);
            // 
            // guna2CircleButton5
            // 
            resources.ApplyResources(this.guna2CircleButton5, "guna2CircleButton5");
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton5.Image")));
            this.guna2CircleButton5.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // nightPicOpenMenu
            // 
            resources.ApplyResources(this.nightPicOpenMenu, "nightPicOpenMenu");
            this.nightPicOpenMenu.Name = "nightPicOpenMenu";
            this.nightPicOpenMenu.TabStop = false;
            // 
            // toggleOpenMenu
            // 
            resources.ApplyResources(this.toggleOpenMenu, "toggleOpenMenu");
            this.toggleOpenMenu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleOpenMenu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleOpenMenu.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleOpenMenu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleOpenMenu.Name = "toggleOpenMenu";
            this.toggleOpenMenu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleOpenMenu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleOpenMenu.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleOpenMenu.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleOpenMenu.CheckedChanged += new System.EventHandler(this.toggleOpenMenu_CheckedChanged);
            // 
            // pictureBox5
            // 
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // menuDateLabel
            // 
            this.menuDateLabel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menuDateLabel, "menuDateLabel");
            this.menuDateLabel.ForeColor = System.Drawing.Color.White;
            this.menuDateLabel.Name = "menuDateLabel";
            // 
            // closedMenu
            // 
            resources.ApplyResources(this.closedMenu, "closedMenu");
            this.closedMenu.Controls.Add(this.menuOpenButton);
            this.closedMenu.Controls.Add(this.guna2CircleButton12);
            this.closedMenu.Controls.Add(this.guna2CircleButton11);
            this.closedMenu.Controls.Add(this.guna2CircleButton10);
            this.closedMenu.Controls.Add(this.guna2CircleButton9);
            this.closedMenu.Name = "closedMenu";
            // 
            // menuOpenButton
            // 
            this.menuOpenButton.BackColor = System.Drawing.Color.Transparent;
            this.menuOpenButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menuOpenButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menuOpenButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menuOpenButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menuOpenButton.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menuOpenButton, "menuOpenButton");
            this.menuOpenButton.ForeColor = System.Drawing.Color.White;
            this.menuOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("menuOpenButton.Image")));
            this.menuOpenButton.ImageSize = new System.Drawing.Size(24, 25);
            this.menuOpenButton.Name = "menuOpenButton";
            this.menuOpenButton.Click += new System.EventHandler(this.menuOpenButton_Click);
            // 
            // guna2CircleButton12
            // 
            resources.ApplyResources(this.guna2CircleButton12, "guna2CircleButton12");
            this.guna2CircleButton12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton12.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton12.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton12.Image")));
            this.guna2CircleButton12.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton12.Name = "guna2CircleButton12";
            this.guna2CircleButton12.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton12.Click += new System.EventHandler(this.guna2CircleButton12_Click);
            // 
            // guna2CircleButton11
            // 
            resources.ApplyResources(this.guna2CircleButton11, "guna2CircleButton11");
            this.guna2CircleButton11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton11.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton11.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton11.Image")));
            this.guna2CircleButton11.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton11.Name = "guna2CircleButton11";
            this.guna2CircleButton11.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton11.Click += new System.EventHandler(this.guna2CircleButton11_Click);
            // 
            // guna2CircleButton10
            // 
            resources.ApplyResources(this.guna2CircleButton10, "guna2CircleButton10");
            this.guna2CircleButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton10.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton10.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton10.Image")));
            this.guna2CircleButton10.ImageOffset = new System.Drawing.Point(1, 1);
            this.guna2CircleButton10.Name = "guna2CircleButton10";
            this.guna2CircleButton10.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton10.Click += new System.EventHandler(this.guna2CircleButton10_Click);
            // 
            // guna2CircleButton9
            // 
            resources.ApplyResources(this.guna2CircleButton9, "guna2CircleButton9");
            this.guna2CircleButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton9.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton9.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton9.Image")));
            this.guna2CircleButton9.ImageOffset = new System.Drawing.Point(1, 0);
            this.guna2CircleButton9.Name = "guna2CircleButton9";
            this.guna2CircleButton9.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton9.Click += new System.EventHandler(this.guna2CircleButton9_Click);
            // 
            // menuOpenTimer
            // 
            this.menuOpenTimer.Interval = 10;
            this.menuOpenTimer.Tick += new System.EventHandler(this.menuOpenTimer_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(40)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.anaPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.closedMenu);
            this.Name = "Form1";
            this.Opacity = 0.97D;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.navigationBar.ResumeLayout(false);
            this.anaPanel.ResumeLayout(false);
            this.anaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nightPicOpenMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.closedMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2ShadowPanel navigationBar;
        private System.Windows.Forms.Panel anaPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalNote;
        private Guna.UI2.WinForms.Guna2HtmlLabel dateLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private System.Windows.Forms.Panel navPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton8;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton7;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton6;
        public Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
        private System.Windows.Forms.PictureBox nightPicOpenMenu;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleOpenMenu;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel menuDateLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button addTxtFileButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Panel closedMenu;
        private Guna.UI2.WinForms.Guna2Button menuOpenButton;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton12;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton11;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton10;
        public Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton9;
        private System.Windows.Forms.Timer menuOpenTimer;
    }
}

