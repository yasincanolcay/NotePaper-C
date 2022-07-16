using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using System.Xml.Linq;

namespace NotePaper
{
    /*
     * Licence by DevoneSoft
     * Copyright 2022 Notepaper
     */
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\csharp projelerim\\NotePaper\\NotePaper\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");
        public int totalNotes = 0;
        int openMenuwidth = 0;
        int timerWeatherDateControl = 0;
        int languageIndex = 0;
        string mediaId = "";
        bool categoriesPage = false;
        bool settingsPage = false;
        bool isopenMenu = true;
        bool showMenu = false;
        bool autoNightMode = false;
        bool weather = false;
        bool isWeather = false;

        Color categoriesBackColor = Color.FromArgb(15,48,115);
        Color categoriesBackColorLayout = Color.FromArgb(20,45,99);

        Color newNoteColor = Color.FromArgb(20,45,99);
        Color newNoteTextboxColor = Color.FromArgb(22,50,110);

        string weatherStatu = "";
        string weatherCity= "";
        string addNoteHeaderText = "";
        string addNoteText = "";
        string deleteNoteHeaderText = "";
        string deleteNoteMessageText = "";
        public string searchBoxText = "";
        public string searchText = "";
        public string categoriesText = "";
        public string thumbailButtonText = "";
        public string mediaButtonText = "";
        public string cleanButtonText = "";
        public string backgroundcolor = "";
        public string open = "";
        public string thumb = "";
        public string clone = "";
        public string DeleteThumbnail = "";
        public string DefaultColor = "";
        public string back = "";
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GetTxtFiles();
        }
        private void GetTxtFiles()
        {
            openFileDialog1.Filter = ("Txt Files (*.txt)|*.txt");
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "openFileDialog1" && openFileDialog1.FileName != "")
            {
                string text = "\n";
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    while ((reader.ReadLine()) != null)
                    {
                        text += reader.ReadLine();
                    }
                    Thread.Sleep(1000);
                }
                if (guna2ToggleSwitch1.Checked)
                {
                    newNoteColor = Color.FromArgb(20, 20, 20);
                    newNoteTextboxColor = Color.FromArgb(30, 30, 30);
                }
                addNotes addNewNotes = new addNotes();
                addNewNotes.Text = guna2Button1.Text;
                addNewNotes.BackColor = newNoteColor;
                addNewNotes.guna2TextBox1.FillColor = newNoteTextboxColor;
                addNewNotes.guna2TextBox2.FillColor = newNoteTextboxColor;
                addNewNotes.guna2ComboBox1.FillColor = newNoteTextboxColor;
                addNewNotes.mode = "new";
                addNewNotes.btn = guna2CircleButton4;
                addNewNotes.guna2TextBox2.Text = text;
                addNewNotes.guna2TextBox1.Text = guna2Button1.Text;
                addNewNotes.guna2TextBox1.PlaceholderText = addNoteHeaderText;
                addNewNotes.guna2TextBox2.PlaceholderText = addNoteText;
                addNewNotes.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettingsData();
            timer1.Enabled = true;
            timer1.Start();
        }
        //Get All Notes  // Tum notlari getir
        private void spawnNote()
        {
            categoriesPage = false;
            settingsPage = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            totalNotes = 0;
            navPanel.Width = guna2CircleButton4.Width;
            navPanel.Left = guna2CircleButton4.Left;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    totalNotes++;
                    totalNote.Text = totalNotes.ToString();
                    home_notes_card notesCard = new home_notes_card();
                    notesCard.btn = guna2CircleButton4;
                    notesCard.TopLevel = false;
                    notesCard.titleLabel.Text = reader["header"].ToString();
                    notesCard.noteShortLabel.Text = reader["note"].ToString();
                    notesCard.datetimeLabel.Text = reader["date"].ToString();
                    notesCard.id = Convert.ToInt32(reader["Id"]);
                    notesCard.categorie = reader["categorie"].ToString();
                    notesCard.bold = reader["bold"].ToString();
                    notesCard.underline = reader["underline"].ToString();
                    notesCard.date = Convert.ToDateTime(reader["date"]);
                    notesCard.addNoteTextHeader = addNoteHeaderText;
                    notesCard.addNoteText = addNoteText;
                    notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                    notesCard.deleteNoteMessageText = deleteNoteMessageText;
                    notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                    notesCard.açToolStripMenuItem.Text = open;
                    notesCard.küçükResimToolStripMenuItem.Text = thumb;
                    notesCard.guna2Button1.Text = clone;
                    notesCard.guna2Button2.Text = DeleteThumbnail;
                    notesCard.guna2Button3.Text = DefaultColor;
                    notesCard.guna2Button4.Text = back;
                    notesCard.languageIndex = languageIndex;
                    if (reader["mediaId"] != null && reader["mediaId"].ToString()!="")
                    {
                        notesCard.mediaId = reader["mediaId"].ToString();
                        mediaId = reader["mediaId"].ToString();
                    }
                    if (Convert.ToInt32(reader["favorites"]) == 1)
                    {
                        notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                        notesCard.favorites = true;
                    }
                    if (reader["thumb"] != null && reader["thumb"].ToString()!="")
                    {
                        notesCard.thumb = reader["thumb"].ToString();
                        notesCard.pictureBox1.Visible = true;
                        notesCard.pictureBox1.Image = Image.FromFile(@""+ reader["thumb"].ToString());
                    }
                    if (reader["color"] != null && reader["color"].ToString() != "")
                    {
                        notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                        notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                        notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                        notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                        notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                    }
                    if (guna2ToggleSwitch1.Checked)
                    {
                        notesCard.nightMode = true;
                    }
                    flowLayoutPanel1.Controls.Add(notesCard);
                    notesCard.Show();
                }
            }
            sqlConnection.Close();
        }
        //User Settings Data  // Ayarlar verisi
        private void GetSettingsData()
        {
            Languages ln = new Languages();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Settings]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    if (Convert.ToInt32(reader["startedNightmode"]) == 1)
                    {
                        guna2ToggleSwitch1.Checked = true;
                        guna2CircleButton4.PerformClick();
                    }
                    if (Convert.ToInt32(reader["autoNightmode"]) == 1)
                    {
                        autoNightMode = true;
                    }
                    if (Convert.ToInt32(reader["weather"]) == 1)
                    {
                        weather = true;
                        weatherCity = ln.weatherCityList[Convert.ToInt32(reader["weatherCity"])];
                        GetWeather();
                    }
                    guna2Button1.Text = ln.addNotesLanguage[Convert.ToInt32(reader["language"])];
                    guna2Button4.Text = ln.addNotesLanguage[Convert.ToInt32(reader["language"])];
                    openFileDialog1.Title = ln.getTxtFiles[Convert.ToInt32(reader["language"])];
                    addNoteHeaderText = ln.addNoteHeaderTextLanguage[Convert.ToInt32(reader["language"])];
                    addNoteText = ln.addNoteTextLanguage[Convert.ToInt32(reader["language"])];
                    deleteNoteHeaderText = ln.deleteNoteWarningHeader[Convert.ToInt32(reader["language"])];
                    deleteNoteMessageText = ln.deleteNoteMessage[Convert.ToInt32(reader["language"])];
                    searchText = ln.Search[Convert.ToInt32(reader["language"])];
                    searchBoxText = ln.SearchTitle[Convert.ToInt32(reader["language"])];
                    categoriesText = ln.categories[Convert.ToInt32(reader["language"])];
                    thumbailButtonText = ln.Thumbnail[Convert.ToInt32(reader["language"])];
                    mediaButtonText = ln.Media[Convert.ToInt32(reader["language"])];
                    cleanButtonText = ln.Clean[Convert.ToInt32(reader["language"])];
                    backgroundcolor = ln.BackgroundColor[Convert.ToInt32(reader["language"])];
                    open = ln.Open[Convert.ToInt32(reader["language"])];
                    thumb = ln.Thumbnail[Convert.ToInt32(reader["language"])];
                    guna2Button5.Text = ln.Back[Convert.ToInt32(reader["language"])];
                    back = ln.Back[Convert.ToInt32(reader["language"])];
                    clone = ln.Clone[Convert.ToInt32(reader["language"])];
                    DeleteThumbnail = ln.DeleteThumbnail[Convert.ToInt32(reader["language"])];
                    DefaultColor = ln.DefaultColor[Convert.ToInt32(reader["language"])];
                    languageIndex = Convert.ToInt32(reader["language"]);
                }
            }
            sqlConnection.Close();
            spawnNote();
        }
        //Get Favorites Notes  // Favori notları getir
        private void spawnFavoritesNotes()
        {
            categoriesPage = false;
            settingsPage = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.AutoScroll = true;
            totalNotes = 0;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            navPanel.Width = guna2CircleButton1.Width;
            navPanel.Left = guna2CircleButton1.Left;
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    if (Convert.ToInt32(reader["favorites"]) == 1)
                    {
                        totalNotes++;
                        totalNote.Text = totalNotes.ToString();
                        home_notes_card notesCard = new home_notes_card();
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            notesCard.pictureBox1.Visible = true;
                            notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                        }
                        if (reader["color"] != null && reader["color"].ToString() != "")
                        {
                            notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                            notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                            notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                            notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                        }
                        notesCard.btn = guna2CircleButton1;
                        notesCard.TopLevel = false;
                        notesCard.titleLabel.Text = reader["header"].ToString();
                        notesCard.noteShortLabel.Text = reader["note"].ToString();
                        notesCard.datetimeLabel.Text = reader["date"].ToString();
                        notesCard.id = Convert.ToInt32(reader["Id"]);
                        notesCard.categorie = reader["categorie"].ToString();
                        notesCard.bold = reader["bold"].ToString();
                        notesCard.underline = reader["underline"].ToString();
                        notesCard.mediaId = reader["mediaId"].ToString();
                        mediaId = reader["mediaId"].ToString();
                        notesCard.date = Convert.ToDateTime(reader["date"]);
                        notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                        notesCard.favorites = true;
                        notesCard.addNoteTextHeader = addNoteHeaderText;
                        notesCard.addNoteText = addNoteText;
                        notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                        notesCard.deleteNoteMessageText = deleteNoteMessageText;
                        notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                        notesCard.açToolStripMenuItem.Text = open;
                        notesCard.küçükResimToolStripMenuItem.Text = thumb;
                        notesCard.guna2Button1.Text = clone;
                        notesCard.guna2Button2.Text = DeleteThumbnail;
                        notesCard.guna2Button3.Text = DefaultColor;
                        notesCard.guna2Button4.Text = back;
                        notesCard.languageIndex = languageIndex;
                        if (guna2ToggleSwitch1.Checked)
                        {
                            notesCard.nightMode = true;
                        }
                        flowLayoutPanel1.Controls.Add(notesCard);
                        notesCard.Show();
                    }
                }
            }
            sqlConnection.Close();

        }
        private void JumpFilterPage()
        {
            settingsPage = false;
            categoriesPage = true;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            Categories categoriesFrm = new Categories();
            categoriesFrm.TopLevel = false;
            categoriesFrm.Dock = DockStyle.Fill;
            categoriesFrm.BackColor = categoriesBackColor;
            categoriesFrm.panel1.BackColor = categoriesBackColor;
            categoriesFrm.flowLayoutPanel1.BackColor = categoriesBackColorLayout;
            categoriesFrm.btn = guna2CircleButton2;
            categoriesFrm.addNoteText = addNoteText;
            categoriesFrm.addNoteHeaderText = addNoteHeaderText;
            categoriesFrm.deleteNoteHeaderText = deleteNoteHeaderText;
            categoriesFrm.deleteNoteMessageText = deleteNoteMessageText;
            categoriesFrm.searchText = searchText;
            categoriesFrm.searchBoxText = searchBoxText;
            categoriesFrm.categoriesText = categoriesText;
            categoriesFrm.thumbailButtonText = thumbailButtonText;
            categoriesFrm.mediaButtonText = mediaButtonText;
            categoriesFrm.cleanButtonText = cleanButtonText;
            categoriesFrm.mediaId = mediaId;
            categoriesFrm.backgroundcolor = backgroundcolor;
            categoriesFrm.open = open;
            categoriesFrm.thumbText = thumb;
            categoriesFrm.clone = clone;
            categoriesFrm.DeleteThumbnail = DeleteThumbnail;
            categoriesFrm.DefaultColor = DefaultColor;
            categoriesFrm.back = back;
            categoriesFrm.languageIndex = languageIndex;
            if (guna2ToggleSwitch1.Checked)
            {
                categoriesFrm.nightMode = true;
            }
            flowLayoutPanel1.Controls.Add(categoriesFrm);
            categoriesFrm.Show();
            navPanel.Width = guna2CircleButton2.Width;
            navPanel.Left = guna2CircleButton2.Left;
        }
        private void JumpSettingsPage()
        {
            categoriesPage = false;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            Settings settings = new Settings();
            settings.panel1.BackColor = categoriesBackColorLayout;
            settings.TopLevel = false;
            settings.Dock = DockStyle.Fill;
            settings.btn = guna2CircleButton4;
            settings.btnSettings = guna2CircleButton3;
            flowLayoutPanel1.Controls.Add(settings);
            settings.Show();
            navPanel.Width = guna2CircleButton3.Width;
            navPanel.Left = guna2CircleButton3.Left;
            settingsPage = true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewNote();
        }
        private void NewNote()
        {
            if (guna2ToggleSwitch1.Checked)
            {
                newNoteColor = Color.FromArgb(20, 20, 20);
                newNoteTextboxColor = Color.FromArgb(30, 30, 30);
            }
            addNotes addNewNotes = new addNotes();
            addNewNotes.Text = guna2Button1.Text;
            addNewNotes.BackColor = newNoteColor;
            addNewNotes.guna2TextBox1.FillColor = newNoteTextboxColor;
            addNewNotes.guna2TextBox2.FillColor = newNoteTextboxColor;
            addNewNotes.guna2ComboBox1.FillColor = newNoteTextboxColor;
            addNewNotes.mode = "new";
            addNewNotes.btn = guna2CircleButton4;
            addNewNotes.guna2TextBox1.PlaceholderText = addNoteHeaderText;
            addNewNotes.guna2TextBox2.PlaceholderText = addNoteText;
            addNewNotes.languageIndex = languageIndex;
            addNewNotes.Show();
        }
        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            GetSettingsData();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            spawnFavoritesNotes();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            JumpFilterPage();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            JumpSettingsPage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (weather)
            {
                timerWeatherDateControl++;

                if (timerWeatherDateControl < 15)
                {
                    dateLabel.Text = weatherStatu;
                    menuDateLabel.Text = weatherStatu;
                }
                if(timerWeatherDateControl>15&&timerWeatherDateControl<30)
                {
                    dateLabel.Text = DateTime.Now.ToString();
                    menuDateLabel.Text = DateTime.Now.ToString();
                }
                if(timerWeatherDateControl==30)
                {
                    timerWeatherDateControl = 0;
                    if (!isWeather)
                    {
                        GetWeather();
                    }
                }
            }
            else
            {
                dateLabel.Text = DateTime.Now.ToString();
            }
            if (autoNightMode)
            {
                if(DateTime.Now.Hour > 18 || DateTime.Now.Hour < 6)
                {
                    if (!guna2ToggleSwitch1.Checked)
                    {
                        guna2ToggleSwitch1.Checked = true;
                    }
                    if (!toggleOpenMenu.Checked)
                    {
                        toggleOpenMenu.Checked = true;
                    }
                }
                else
                {
                    if (guna2ToggleSwitch1.Checked)
                    {
                        guna2ToggleSwitch1.Checked = false;
                    }
                    if (toggleOpenMenu.Checked)
                    {
                        toggleOpenMenu.Checked = false;
                    }
                }
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CategoriesPageDraw();
            SettingsPageDraw();
            if (this.Width < 650)
            {
                if (!showMenu)
                {
                    toggleOpenMenu.Visible = true;
                    nightPicOpenMenu.Visible = true;
                    menuPanel.Width = 257;
                    menuPanel.Height = 425;
                    menuPanel.Dock = DockStyle.Left;
                    menuPanel.Visible = true;
                    anaPanel.Visible = false;
                    navigationBar.Visible = false;
                    anaPanel.Dock = DockStyle.None;
                    navigationBar.Dock = DockStyle.None;
                    flowLayoutPanel1.Dock = DockStyle.Fill;
                    showMenu = true;
                }
            }
            else
            {
                if (toggleOpenMenu.Checked)
                {
                    closedMenu.BackColor = Color.FromArgb(20, 20, 20);
                    menuPanel.BackColor = Color.FromArgb(20, 20, 20);
                }
                else
                {
                    closedMenu.BackColor = Color.FromArgb(18, 48, 115);
                    menuPanel.BackColor = Color.FromArgb(18, 48, 115);
                }
                menuPanel.Width = 0;
                menuPanel.Height = 0;
                menuPanel.Visible = false;
                menuPanel.Dock = DockStyle.None;
                closedMenu.Width = 0;
                closedMenu.Height = 0;
                closedMenu.Visible = false;
                closedMenu.Dock = DockStyle.None;
                anaPanel.Dock = DockStyle.Top;
                navigationBar.Dock = DockStyle.Bottom;
                anaPanel.Visible = true;
                navigationBar.Visible = true;
                flowLayoutPanel1.Dock = DockStyle.Fill;
                showMenu = false;
                NightMode();
            }
        }

        private void CategoriesPageDraw()
        {
            if (categoriesPage)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.PerformLayout();
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                Categories categoriesFrm = new Categories();
                categoriesFrm.panel1.BackColor = categoriesBackColor;
                categoriesFrm.flowLayoutPanel1.BackColor = categoriesBackColorLayout;
                categoriesFrm.TopLevel = false;
                categoriesFrm.Dock = DockStyle.Fill;
                categoriesFrm.btn = guna2CircleButton2;
                categoriesFrm.addNoteText = addNoteText;
                categoriesFrm.addNoteHeaderText = addNoteHeaderText;
                categoriesFrm.deleteNoteHeaderText = deleteNoteHeaderText;
                categoriesFrm.deleteNoteMessageText = deleteNoteMessageText;
                categoriesFrm.searchText = searchText;
                categoriesFrm.searchBoxText = searchBoxText;
                categoriesFrm.categoriesText = categoriesText;
                categoriesFrm.thumbailButtonText = thumbailButtonText;
                categoriesFrm.mediaButtonText = mediaButtonText;
                categoriesFrm.cleanButtonText = cleanButtonText;
                flowLayoutPanel1.Controls.Add(categoriesFrm);
                categoriesFrm.Show();
                navPanel.Width = guna2CircleButton2.Width;
                navPanel.Left = guna2CircleButton2.Left;
            }
        }
        private void SettingsPageDraw()
        {
            if (settingsPage)
            {
                flowLayoutPanel1.AutoScroll = false;
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.PerformLayout();
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
                Settings settings = new Settings();
                settings.panel1.BackColor = categoriesBackColorLayout;
                settings.TopLevel = false;
                settings.Dock = DockStyle.Fill;
                flowLayoutPanel1.Controls.Add(settings);
                settings.Show();
                navPanel.Width = guna2CircleButton3.Width;
                navPanel.Left = guna2CircleButton3.Left;
            }
        }
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            NightMode();
        }
        private void NightMode()
        {
            try
            {
                if (guna2ToggleSwitch1.Checked)
                {
                    if (!showMenu)
                    {
                        anaPanel.BackColor = Color.FromArgb(20, 20, 20);
                        navigationBar.FillColor = Color.FromArgb(20, 20, 20);
                        navigationBar.BackColor = Color.FromArgb(20, 20, 20);
                    }
                    flowLayoutPanel1.BackColor = Color.FromArgb(30, 30, 30);
                    categoriesBackColor = Color.FromArgb(20, 20, 20);
                    categoriesBackColorLayout = Color.FromArgb(30, 30, 30);
                    newNoteColor = Color.FromArgb(20, 20, 20);
                    newNoteTextboxColor = Color.FromArgb(30, 30, 30);
                }
                else
                {
                    if (!showMenu)
                    {
                        anaPanel.BackColor = Color.FromArgb(18, 48, 115);
                        navigationBar.FillColor = Color.FromArgb(22, 40, 105);
                        navigationBar.BackColor = Color.Transparent;
                    }
                    flowLayoutPanel1.BackColor = Color.FromArgb(20, 45, 99);
                    categoriesBackColor = Color.FromArgb(18, 48, 115);
                    categoriesBackColorLayout = Color.FromArgb(20, 45, 99);
                    newNoteColor = Color.FromArgb(20, 45, 99);
                    newNoteTextboxColor = Color.FromArgb(22, 50, 110);
                }
                if (categoriesPage)
                {
                    CategoriesPageDraw();
                }
                if (settingsPage)
                {
                    SettingsPageDraw();
                }
            }
            catch
            {
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            openMenuwidth = 0;
            isopenMenu = false;
            menuOpenTimer.Enabled = true;
            menuOpenTimer.Start();
        }

        private void menuOpenButton_Click(object sender, EventArgs e)
        {
            openMenuwidth = 0;
            isopenMenu = true;
            menuOpenTimer.Enabled = true;
            menuOpenTimer.Start();
        }

        private void menuOpenTimer_Tick(object sender, EventArgs e)
        {
            if (isopenMenu)
            {
                closedMenu.Width = 0;
                closedMenu.Height = 0;
                closedMenu.Dock = DockStyle.None;
                closedMenu.Visible = false;
                menuPanel.Dock = DockStyle.Left;
                if (openMenuwidth < 257)
                {
                    openMenuwidth+=2;
                    menuPanel.Width = openMenuwidth;
                    menuPanel.Height = 425;
                    menuPanel.Visible = true;
                    anaPanel.Visible = false;
                    navigationBar.Visible = false;
                    anaPanel.Dock = DockStyle.None;
                    navigationBar.Dock = DockStyle.None;
                    flowLayoutPanel1.Dock = DockStyle.Fill;
                }
                else
                {
                    toggleOpenMenu.Visible = true;
                    nightPicOpenMenu.Visible = true;
                    menuOpenTimer.Enabled = false;
                    menuOpenTimer.Stop();
                }
            }
            else
            {
                toggleOpenMenu.Visible = false;
                nightPicOpenMenu.Visible = false;
                menuPanel.Width = 0;
                menuPanel.Height = 0;
                menuPanel.Dock = DockStyle.None;
                menuPanel.Visible = false;
                closedMenu.Dock = DockStyle.Left;
                if (openMenuwidth < 64)
                {
                    openMenuwidth++;
                    closedMenu.Width = openMenuwidth;
                    closedMenu.Height = 425;
                    closedMenu.Visible = true;
                    anaPanel.Visible = false;
                    navigationBar.Visible = false;
                    anaPanel.Dock = DockStyle.None;
                    navigationBar.Dock = DockStyle.None;
                    flowLayoutPanel1.Dock = DockStyle.Fill;
                }
                else
                {
                    menuOpenTimer.Enabled = false;
                    menuOpenTimer.Stop();
                }
            }
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            spawnNote();
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            spawnFavoritesNotes();
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            JumpFilterPage();
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            JumpSettingsPage();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {

            spawnNote();
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            spawnFavoritesNotes();
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            JumpFilterPage();
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            JumpSettingsPage();
        }

        private void toggleOpenMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (showMenu)
            {
                NightMode();
                if (toggleOpenMenu.Checked)
                {
                    closedMenu.BackColor = Color.FromArgb(20,20,20);
                    menuPanel.BackColor = Color.FromArgb(20,20,20);
                }
                else
                {
                    closedMenu.BackColor = Color.FromArgb(18, 48, 115);
                    menuPanel.BackColor = Color.FromArgb(18, 48, 115);
                }
            }
        }

        //Open menu New note button
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            NewNote();
        }

        private void addTxtFileButton_Click(object sender, EventArgs e)
        {
            GetTxtFiles();
        }
        private void GetWeather()
        {
            try
            {
                //havadurumu kodları
                //http://api.openweathermap.org/data/2.5/weather?q=izmir&appid=
                //"e7d2c6c38b9ae7616ec4a3579c9313cf&lang=tr"
                string api = "e7d2c6c38b9ae7616ec4a3579c9313cf";
                string url = "https://api.openweathermap.org/data/2.5/weather?q="+weatherCity+"&mode=xml&lang=en&units=metric&appid=" + api;
                XDocument weather = XDocument.Load(url);
                var temp = weather.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                var weatherstatu = weather.Descendants("weather").ElementAt(0).Attribute("value").Value;
                var feels = weather.Descendants("feels_like").ElementAt(0).Attribute("value").Value;
                var hum = weather.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                var clouds = weather.Descendants("clouds").ElementAt(0).Attribute("value").Value;
                var wind_speed = weather.Descendants("speed").ElementAt(0).Attribute("value").Value;
                var precipitation = weather.Descendants("precipitation").ElementAt(0).Attribute("mode").Value;
                weatherStatu = weatherCity.ToLower() + " " + temp + " " + weatherstatu + " " + clouds;
                isWeather = true;
            }
            catch
            {
                //Diger dillerde cevrilecek
                weatherStatu = "BAGLANTI YOK";
                isWeather = false;
            }
        }
    }
}
