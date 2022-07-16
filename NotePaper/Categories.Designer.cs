
namespace NotePaper
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.fillPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadingEffectIndicator = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.clearFilterButton = new Guna.UI2.WinForms.Guna2Button();
            this.mediaButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.categoriesLabelstateles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.totalResponse = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchLabelstateles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.categoriesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.thumbailButton = new Guna.UI2.WinForms.Guna2Button();
            this.fillPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillPanel
            // 
            this.fillPanel.Controls.Add(this.flowLayoutPanel1);
            this.fillPanel.Controls.Add(this.panel1);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 0);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.Size = new System.Drawing.Size(723, 326);
            this.fillPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(211, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(512, 326);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.loadingEffectIndicator);
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.mediaButton);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.categoriesLabelstateles);
            this.panel1.Controls.Add(this.totalResponse);
            this.panel1.Controls.Add(this.searchLabelstateles);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.categoriesComboBox);
            this.panel1.Controls.Add(this.thumbailButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 326);
            this.panel1.TabIndex = 0;
            // 
            // loadingEffectIndicator
            // 
            this.loadingEffectIndicator.BackColor = System.Drawing.Color.Transparent;
            this.loadingEffectIndicator.Location = new System.Drawing.Point(91, 289);
            this.loadingEffectIndicator.Name = "loadingEffectIndicator";
            this.loadingEffectIndicator.Size = new System.Drawing.Size(30, 30);
            this.loadingEffectIndicator.TabIndex = 13;
            this.loadingEffectIndicator.Visible = false;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BorderRadius = 15;
            this.clearFilterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearFilterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearFilterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearFilterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearFilterButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearFilterButton.ForeColor = System.Drawing.Color.White;
            this.clearFilterButton.Location = new System.Drawing.Point(4, 246);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(202, 35);
            this.clearFilterButton.TabIndex = 12;
            this.clearFilterButton.Text = "Temizle";
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // mediaButton
            // 
            this.mediaButton.BorderRadius = 15;
            this.mediaButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mediaButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mediaButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mediaButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mediaButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mediaButton.ForeColor = System.Drawing.Color.White;
            this.mediaButton.Location = new System.Drawing.Point(4, 205);
            this.mediaButton.Name = "mediaButton";
            this.mediaButton.Size = new System.Drawing.Size(202, 35);
            this.mediaButton.TabIndex = 11;
            this.mediaButton.Text = "Medya";
            this.mediaButton.Click += new System.EventHandler(this.mediaButton_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.guna2Separator1.Location = new System.Drawing.Point(5, 144);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 10;
            // 
            // categoriesLabelstateles
            // 
            this.categoriesLabelstateles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesLabelstateles.BackColor = System.Drawing.Color.Transparent;
            this.categoriesLabelstateles.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.categoriesLabelstateles.ForeColor = System.Drawing.Color.White;
            this.categoriesLabelstateles.Location = new System.Drawing.Point(14, 66);
            this.categoriesLabelstateles.Name = "categoriesLabelstateles";
            this.categoriesLabelstateles.Size = new System.Drawing.Size(95, 23);
            this.categoriesLabelstateles.TabIndex = 9;
            this.categoriesLabelstateles.Text = "Kategoriler";
            // 
            // totalResponse
            // 
            this.totalResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalResponse.BackColor = System.Drawing.Color.Transparent;
            this.totalResponse.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.totalResponse.ForeColor = System.Drawing.Color.White;
            this.totalResponse.Location = new System.Drawing.Point(165, 2);
            this.totalResponse.Name = "totalResponse";
            this.totalResponse.Size = new System.Drawing.Size(15, 23);
            this.totalResponse.TabIndex = 8;
            this.totalResponse.Text = "0";
            // 
            // searchLabelstateles
            // 
            this.searchLabelstateles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabelstateles.BackColor = System.Drawing.Color.Transparent;
            this.searchLabelstateles.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold);
            this.searchLabelstateles.ForeColor = System.Drawing.Color.White;
            this.searchLabelstateles.Location = new System.Drawing.Point(14, 1);
            this.searchLabelstateles.Name = "searchLabelstateles";
            this.searchLabelstateles.Size = new System.Drawing.Size(32, 23);
            this.searchLabelstateles.TabIndex = 7;
            this.searchLabelstateles.Text = "Ara";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextBox.BorderRadius = 15;
            this.searchTextBox.BorderThickness = 0;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextBox.IconRight")));
            this.searchTextBox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTextBox.Location = new System.Drawing.Point(5, 26);
            this.searchTextBox.MaximumSize = new System.Drawing.Size(400, 36);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderText = "Başlık Ara...";
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.ShadowDecoration.BorderRadius = 18;
            this.searchTextBox.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.searchTextBox.ShadowDecoration.Depth = 5;
            this.searchTextBox.ShadowDecoration.Enabled = true;
            this.searchTextBox.Size = new System.Drawing.Size(200, 36);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.IconRightClick += new System.EventHandler(this.searchTextBox_IconRightClick);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categoriesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoriesComboBox.BorderRadius = 15;
            this.categoriesComboBox.BorderThickness = 0;
            this.categoriesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.categoriesComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoriesComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoriesComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriesComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoriesComboBox.ItemHeight = 30;
            this.categoriesComboBox.Location = new System.Drawing.Point(5, 95);
            this.categoriesComboBox.MaximumSize = new System.Drawing.Size(200, 0);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.ShadowDecoration.BorderRadius = 15;
            this.categoriesComboBox.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.categoriesComboBox.ShadowDecoration.Depth = 5;
            this.categoriesComboBox.ShadowDecoration.Enabled = true;
            this.categoriesComboBox.Size = new System.Drawing.Size(200, 36);
            this.categoriesComboBox.TabIndex = 5;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // thumbailButton
            // 
            this.thumbailButton.BorderRadius = 15;
            this.thumbailButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thumbailButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thumbailButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thumbailButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thumbailButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thumbailButton.ForeColor = System.Drawing.Color.White;
            this.thumbailButton.Location = new System.Drawing.Point(4, 164);
            this.thumbailButton.Name = "thumbailButton";
            this.thumbailButton.Size = new System.Drawing.Size(202, 35);
            this.thumbailButton.TabIndex = 1;
            this.thumbailButton.Text = "Küçük Resim";
            this.thumbailButton.Click += new System.EventHandler(this.thumbailButton_Click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(45)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(723, 326);
            this.Controls.Add(this.fillPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Categories";
            this.Text = "Categories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Categories_Load);
            this.fillPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fillPanel;
        private Guna.UI2.WinForms.Guna2Button thumbailButton;
        public Guna.UI2.WinForms.Guna2ComboBox categoriesComboBox;
        public Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private Guna.UI2.WinForms.Guna2ProgressIndicator loadingEffectIndicator;
        private Guna.UI2.WinForms.Guna2Button clearFilterButton;
        private Guna.UI2.WinForms.Guna2Button mediaButton;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel categoriesLabelstateles;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalResponse;
        private Guna.UI2.WinForms.Guna2HtmlLabel searchLabelstateles;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}