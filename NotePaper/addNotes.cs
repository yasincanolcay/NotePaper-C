using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePaper
{
    public partial class addNotes : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");

        public bool bold = false;
        public bool underline = false;
        public bool nightMode = false;
        public string mode = "";
        public string mediaId = "";
        public string thumb = "";
        //public int mediaTableId = 0;
        public int favorites = 0;
        public int id = 0;
        public int languageIndex = 0;
        public string color = "";
        public DateTime date=DateTime.Now;
        List<string> readCount = new List<string>(0);
        List<string> videoUrl = new List<string>();
        List<string> type = new List<string>();
        public List<int> mediaTableId = new List<int>();
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();
        bool isAddFile = false;
        bool isReadySaved = false;
        bool autoSave = false;
        bool isClosed = false;
        public addNotes()
        {
            InitializeComponent();
        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Clear();
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            if (underline == false)
            {
                guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Underline);
                underline = true;
            }
            else
            {
                if (bold == true)
                {
                    guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Bold);
                }
                else
                {
                    guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Regular);
                }
                underline = false;
            }
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            if (bold == false)
            {
                guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Bold);
                bold = true;
            }
            else
            {
                if (underline == true)
                {
                    guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Underline);
                }
                else
                {
                    guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Regular);
                }
                bold = false;
            }
        }

        private void lowercaseButton_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.SelectedText!="")
            {
                guna2TextBox2.SelectedText = guna2TextBox2.SelectedText.ToLower();
            }
            else
            {
                guna2TextBox2.Text = guna2TextBox2.Text.ToLower();
            }
        }

        private void uppercaseButton_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.SelectedText != "")
            {
                guna2TextBox2.SelectedText = guna2TextBox2.SelectedText.ToUpper();
            }
            else
            {
                guna2TextBox2.Text = guna2TextBox2.Text.ToUpper();
            }
        }

        private void fontsizeButton_Click(object sender, EventArgs e)
        {
            fontSize fontSizefrm = new fontSize();
            fontSizefrm.textbox1 = guna2TextBox1;
            fontSizefrm.textbox2 = guna2TextBox2;
            fontSizefrm.fontSizeValue = Convert.ToInt32(guna2TextBox2.Font.Size);
            fontSizefrm.ShowDialog();
        }
        private void SaveNote()
        {
            if (mode != "read")
            {
                Random r = new Random();
                string randomId = r.Next(10, 90).ToString() + "-" + r.Next(100, 1000).ToString() + "-" + r.Next(1000, 5000).ToString() + "-" + r.Next(10000, 20000).ToString() + "-" + r.Next(100000, 300000).ToString();
                mediaId = randomId;
                sqlConnection.Open();
                if (videoUrl.Count == 0)
                {
                    SqlCommand command = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,color,mediaId,thumb) values ('" + guna2TextBox2.Text + "','" + guna2ComboBox1.SelectedIndex + "','" + DateTime.Now + "','" + guna2TextBox1.Text + "','" + favorites + "','" + color + "','" + null + "','" + thumb + "')", sqlConnection);
                    command.ExecuteNonQuery();


                    SqlCommand command2 = new SqlCommand();
                    command2.Connection = sqlConnection;
                    command2.CommandText = ("Select * From [Notes]");
                    SqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                    }
                    reader.Close();
                }
                guna2CircleButton12.Visible = false;
                guna2ProgressIndicator1.Visible = true;
                guna2ProgressIndicator1.Start();
                timer1.Enabled = true;
                timer1.Start();

                if (videoUrl.Count != 0)
                {
                    SqlCommand Withmedia = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,color,mediaId,thumb) values ('" + guna2TextBox2.Text + "','" + guna2ComboBox1.SelectedIndex + "','" + DateTime.Now + "','" + guna2TextBox1.Text + "','" + favorites + "','" + color + "','" + randomId + "','" + thumb + "')", sqlConnection);
                    Withmedia.ExecuteNonQuery();

                    SqlCommand command2 = new SqlCommand();
                    command2.Connection = sqlConnection;
                    command2.CommandText = ("Select * From [Notes]");
                    SqlDataReader reader = command2.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["Id"]);
                    }
                    reader.Close();
                    for (int i = 0; i < videoUrl.Count; i++)
                    {
                        SqlCommand addMedia = new SqlCommand("insert into Media(type,mediaId,path) values ('" + type[i] + "','" + randomId + "','" + videoUrl[i] + "')", sqlConnection);
                        addMedia.ExecuteNonQuery();
                    }

                }
                mode = "read";
                sqlConnection.Close();

            }
            else
            {
                sqlConnection.Open();

                SqlCommand command2 = new SqlCommand();
                command2.Connection = sqlConnection;
                command2.CommandText = "delete Notes where Id='" + id + "'";
                command2.ExecuteNonQuery();

                if (videoUrl.Count == 0)
                {
                    SqlCommand command = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,color,mediaId,thumb) values ('" + guna2TextBox2.Text + "','" + guna2ComboBox1.SelectedIndex + "','" + DateTime.Now + "','" + guna2TextBox1.Text + "','" + favorites + "','" + color + "','" + null + "','" + thumb + "')", sqlConnection);
                    command.ExecuteNonQuery();


                    SqlCommand writer = new SqlCommand();
                    writer.Connection = sqlConnection;
                    writer.CommandText = ("Select * From [Notes]");
                    SqlDataReader idReader = writer.ExecuteReader();

                    while (idReader.Read())
                    {
                        id = Convert.ToInt32(idReader["Id"]);
                    }
                    idReader.Close();
                }
                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Notes]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    mediaId = id.ToString();
                }
                reader.Close();
                if (videoUrl.Count != 0)
                {
                    for (int i = 0; i < mediaTableId.Count; i++)
                    {
                        SqlCommand deleteMedia = new SqlCommand();
                        deleteMedia.Connection = sqlConnection;
                        deleteMedia.CommandText = "delete Media where Id='" + mediaTableId[i] + "'";
                        deleteMedia.ExecuteNonQuery();
                    }

                    SqlCommand Withmedia = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,color,mediaId,thumb) values ('" + guna2TextBox2.Text + "','" + guna2ComboBox1.SelectedIndex + "','" + DateTime.Now + "','" + guna2TextBox1.Text + "','" + favorites + "','" + color + "','" + mediaId + "','" + thumb + "')", sqlConnection);
                    Withmedia.ExecuteNonQuery();

                    SqlCommand idReadercommand = new SqlCommand();
                    idReadercommand.Connection = sqlConnection;
                    idReadercommand.CommandText = ("Select * From [Notes]");
                    SqlDataReader idReader = idReadercommand.ExecuteReader();

                    while (idReader.Read())
                    {
                        id = Convert.ToInt32(idReader["Id"]);
                    }
                    idReader.Close();
                    for (int i = 0; i < videoUrl.Count; i++)
                    {
                        SqlCommand addMedia = new SqlCommand("insert into Media(type,mediaId,path) values ('" + type[i] + "','" + mediaId + "','" + videoUrl[i] + "')", sqlConnection);
                        addMedia.ExecuteNonQuery();
                    }


                }
                sqlConnection.Close();
                guna2CircleButton12.Visible = false;
                guna2ProgressIndicator1.Visible = true;
                guna2ProgressIndicator1.Start();
                timer1.Enabled = true;
                timer1.Start();
            }
            btn.PerformClick();
            this.Focus();
            if (isClosed)
            {
                this.Close();
            }
        }
        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void addNotes_Load(object sender, EventArgs e)
        {
            if (mode == "read")
            {
                guna2CircleButton1.Visible = false;
                guna2CircleButton2.Visible = false;
                guna2CircleButton3.Visible = false;
                guna2CircleButton4.Visible = false;
                guna2CircleButton5.Visible = false;
                guna2CircleButton12.Visible = false;
                uppercaseButton.Visible = false;
                lowercaseButton.Visible = false;
                fontsizeButton.Visible = false;
                fonttypeButton.Visible = false;
                boldButton.Visible = false;
                underlineButton.Visible = false;
                editModeButton.Visible = true;
                if (mediaId != "")
                {
                    sqlConnection.Open();
                    SqlCommand command1 = new SqlCommand();
                    command1.Connection = sqlConnection;
                    command1.CommandText = ("Select * From [Media]");
                    SqlDataReader reader = command1.ExecuteReader();
                    int readIndex = 0;
                    if (!isAddFile)
                    {
                        guna2TextBox2.Height = guna2TextBox2.Height - 70;
                        isAddFile = true;
                    }
                    flowLayoutPanel1.Visible = true;
                    while (reader.Read())
                    {
                        if (reader["mediaId"].ToString() == mediaId)
                        {
                            mediaTableId.Add(Convert.ToInt32(reader["Id"]));
                            videoUrl.Add(reader["path"].ToString());
                            type.Add(reader["type"].ToString());
                            videoCard videos = new videoCard();
                            videos.TopLevel = false;
                            videos.videoUrl = reader["path"].ToString();
                            videos.flowPanel = flowLayoutPanel1;
                            videos.videosList = videoUrl;
                            videos.index = readIndex;
                            videos.textbox2 = guna2TextBox2;
                            videos.isAddFile = isAddFile;
                            videos.type = reader["type"].ToString();
                            videos.docType = type;
                            videos.mediaTableId = Convert.ToInt32(reader["Id"]);
                            videos.header = guna2TextBox1.Text;
                            videos.notes = guna2TextBox2.Text;
                            videos.categorie = guna2ComboBox1.SelectedIndex;
                            videos.favorites = favorites;
                            videos.thumb = thumb;
                            videos.color = color;
                            videos.id = id;
                            videos.mediaId = mediaId;
                            videos.languageIndex = languageIndex;
                            flowLayoutPanel1.Controls.Add(videos);
                            videos.Show();
                            readIndex++;
                        }
                    }
                    sqlConnection.Close();
                }
            }
            GetSettingsData();
        }
        private void GetSettingsData()
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Settings]");
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (reader != null)
                {
                    if (Convert.ToInt32(reader["autoSave"]) == 1)
                    {
                        autoSave = true;
                    }
                }
            }
            sqlConnection.Close();
        }
        private void editModeButton_Click(object sender, EventArgs e)
        {
            this.Text = "Edit Note";
            guna2TextBox1.ReadOnly = false;
            guna2TextBox2.ReadOnly = false;
            guna2CircleButton1.Visible = true;
            guna2CircleButton2.Visible = true;
            guna2CircleButton3.Visible = true;
            guna2CircleButton4.Visible = true;
            guna2CircleButton5.Visible = true;
            guna2CircleButton12.Visible = true;
            uppercaseButton.Visible = true;
            lowercaseButton.Visible = true;
            fontsizeButton.Visible = true;
            fonttypeButton.Visible = true;
            boldButton.Visible = true;
            underlineButton.Visible = true;
            editModeButton.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2CircleButton12.Visible = true;
            guna2ProgressIndicator1.Visible = false;
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void renklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void fonttypeButton_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            guna2TextBox1.Font = fontDialog1.Font;
            guna2TextBox2.Font = fontDialog1.Font;
            guna2ComboBox1.Font = fontDialog1.Font;
        }

        private void addNotes_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                guna2CircleButton12.PerformClick();
            }
            if (e.KeyCode == Keys.F10)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void addNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    this.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void geceGündüzModuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nightMode)
            {
                this.BackColor = Color.FromArgb(20, 20, 20);
                guna2TextBox1.FillColor = Color.FromArgb(30, 30, 30);
                guna2TextBox2.FillColor = Color.FromArgb(30, 30, 30);
                guna2ComboBox1.FillColor = Color.FromArgb(30, 30, 30);
                nightMode = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(20, 45, 99);
                guna2TextBox1.FillColor = Color.FromArgb(22, 50, 110);
                guna2TextBox2.FillColor = Color.FromArgb(22, 50, 110);
                guna2ComboBox1.FillColor = Color.FromArgb(22, 50, 110);
                nightMode = false;
            }
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            addFileDialog.Filter = (ln.VideoFiles[languageIndex]+"(*.mp4)|*.mp4|avi (*.avi)|*.avi");
            addFileDialog.Title = ln.SelectVideos[languageIndex];
            addFileDialog.ShowDialog();
            if(addFileDialog.FileName != "openFileDialog1")
            {
                if (!isAddFile)
                {
                    guna2TextBox2.Height = guna2TextBox2.Height - 70;
                    isAddFile = true;
                }
                flowLayoutPanel1.Visible = true;
                for(int i=0; i < addFileDialog.FileNames.Length; i++)
                {
                    videoUrl.Add(addFileDialog.FileNames[i]);
                    type.Add("video");
                    videoCard videos = new videoCard();
                    videos.TopLevel = false;
                    videos.videoUrl = addFileDialog.FileNames[i];
                    videos.flowPanel = flowLayoutPanel1;
                    videos.videosList = videoUrl;
                    videos.index = i;
                    videos.textbox2 = guna2TextBox2;
                    videos.isAddFile = isAddFile;
                    videos.type = "video";
                    videos.header = guna2TextBox1.Text;
                    videos.notes = guna2TextBox2.Text;
                    videos.categorie = guna2ComboBox1.SelectedIndex;
                    videos.docType = type;
                    videos.favorites = favorites;
                    videos.thumb = thumb;
                    videos.color = color;
                    videos.id = id;
                    videos.mediaId = mediaId;
                    videos.languageIndex = languageIndex;
                    flowLayoutPanel1.Controls.Add(videos);
                    videos.Show();
                }

            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            addFileDialog.Filter = (ln.AudioFiles[languageIndex]+"(*.mp3)|*.mp3|wav (*.wav)|*.wav|m4a (*.m4a)|*.m4a");
            addFileDialog.Title = ln.ChooseAudioFiles[languageIndex];
            addFileDialog.ShowDialog();
            if (addFileDialog.FileName != "openFileDialog1")
            {
                if (!isAddFile)
                {
                    guna2TextBox2.Height = guna2TextBox2.Height - 70;
                    isAddFile = true;
                }
                flowLayoutPanel1.Visible = true;
                for (int i = 0; i < addFileDialog.FileNames.Length; i++)
                {
                    videoUrl.Add(addFileDialog.FileNames[i]);
                    type.Add("audio");
                    videoCard videos = new videoCard();
                    videos.TopLevel = false;
                    videos.videoUrl = addFileDialog.FileNames[i];
                    videos.flowPanel = flowLayoutPanel1;
                    videos.videosList = videoUrl;
                    videos.index = i;
                    videos.textbox2 = guna2TextBox2;
                    videos.isAddFile = isAddFile;
                    videos.type = "audio";
                    videos.docType = type;
                    videos.header = guna2TextBox1.Text;
                    videos.notes = guna2TextBox2.Text;
                    videos.categorie = guna2ComboBox1.SelectedIndex;
                    videos.favorites = favorites;
                    videos.thumb = thumb;
                    videos.color = color;
                    videos.id = id;
                    videos.mediaId = mediaId;
                    videos.languageIndex = languageIndex;
                    flowLayoutPanel1.Controls.Add(videos);
                    videos.Show();
                }

            }
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            addFileDialog.Filter = (ln.Imagefiles[languageIndex]+" (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif");
            addFileDialog.Title = ln.SelectPictures[languageIndex];
            addFileDialog.ShowDialog();
            if (addFileDialog.FileName != "openFileDialog1")
            {
                if (!isAddFile)
                {
                    guna2TextBox2.Height = guna2TextBox2.Height - 70;
                    isAddFile = true;
                }
                flowLayoutPanel1.Visible = true;
                for (int i = 0; i < addFileDialog.FileNames.Length; i++)
                {
                    videoUrl.Add(addFileDialog.FileNames[i]);
                    type.Add("resim");
                    videoCard videos = new videoCard();
                    videos.TopLevel = false;
                    videos.videoUrl = addFileDialog.FileNames[i];
                    videos.flowPanel = flowLayoutPanel1;
                    videos.videosList = videoUrl;
                    videos.index = i;
                    videos.textbox2 = guna2TextBox2;
                    videos.isAddFile = isAddFile;
                    videos.type = "resim";
                    videos.docType = type;
                    videos.header = guna2TextBox1.Text;
                    videos.notes = guna2TextBox2.Text;
                    videos.categorie = guna2ComboBox1.SelectedIndex;
                    videos.favorites = favorites;
                    videos.thumb = thumb;
                    videos.color = color;
                    videos.id = id;
                    videos.mediaId = mediaId;
                    videos.languageIndex = languageIndex;

                    flowLayoutPanel1.Controls.Add(videos);
                    videos.Show();
                }

            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            addFileDialog.Filter = (ln.Document[languageIndex]+" (*.pdf)|*.pdf");
            addFileDialog.Title = ln.SelectDocuments[languageIndex];
            addFileDialog.ShowDialog();
            if (addFileDialog.FileName != "openFileDialog1")
            {
                if (!isAddFile)
                {
                    guna2TextBox2.Height = guna2TextBox2.Height - 70;
                    isAddFile = true;
                }
                flowLayoutPanel1.Visible = true;
                for (int i = 0; i < addFileDialog.FileNames.Length; i++)
                {
                    videoUrl.Add(addFileDialog.FileNames[i]);
                    type.Add("pdf");
                    videoCard videos = new videoCard();
                    videos.TopLevel = false;
                    videos.videoUrl = addFileDialog.FileNames[i];
                    videos.flowPanel = flowLayoutPanel1;
                    videos.videosList = videoUrl;
                    videos.index = i;
                    videos.textbox2 = guna2TextBox2;
                    videos.isAddFile = isAddFile;
                    videos.type = "pdf";
                    videos.docType = type;
                    videos.header = guna2TextBox1.Text;
                    videos.notes = guna2TextBox2.Text;
                    videos.categorie = guna2ComboBox1.SelectedIndex;
                    videos.favorites = favorites;
                    videos.thumb = thumb;
                    videos.color = color;
                    videos.id = id;
                    videos.mediaId = mediaId;
                    videos.languageIndex = languageIndex;
                    flowLayoutPanel1.Controls.Add(videos);
                    videos.Show();
                }

            }
        }

        private void flowLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Visible == false)
            {
                videoUrl.Clear();
                type.Clear();
                mediaTableId.Clear();
                sqlConnection.Open();
                isAddFile = false;
                SqlCommand deleteNote = new SqlCommand();
                deleteNote.Connection = sqlConnection;
                deleteNote.CommandText = "delete Notes where Id='" + id + "'";
                deleteNote.ExecuteNonQuery();
                SqlCommand command = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,color,mediaId,thumb) values ('" + guna2TextBox2.Text + "','" + guna2ComboBox1.SelectedIndex + "','" + DateTime.Now + "','" + guna2TextBox1.Text + "','" + favorites + "','" + color + "','" + null + "','" + thumb + "')", sqlConnection);
                command.ExecuteNonQuery();
                SqlCommand idReadercommand = new SqlCommand();
                idReadercommand.Connection = sqlConnection;
                idReadercommand.CommandText = ("Select * From [Notes]");
                SqlDataReader idReader = idReadercommand.ExecuteReader();
                while (idReader.Read())
                {
                    id = Convert.ToInt32(idReader["Id"]);
                }
                idReader.Close();
                sqlConnection.Close();
                btn.PerformClick();
                this.Focus();
            }
        }

        private void AutosaveTimer_Tick(object sender, EventArgs e)
        {
            if (isReadySaved)
            {
                SaveNote();
                isReadySaved = false;
                AutosaveTimer.Enabled = false;
                AutosaveTimer.Stop();
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (autoSave)
            {
                isReadySaved = true;
                AutosaveTimer.Dispose();
                AutosaveTimer.Enabled = true;
                AutosaveTimer.Start();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            if (isReadySaved)
            {
                isClosed = true;
                SaveNote();
            }
            else
            {
                this.Close();
            }
        }
        //kopyala - copy
        private void kopyalactrlcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{c}");
        }
        //kes - cut
        private void kesctrlxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{x}");
        }
        //yapıştır - paste
        private void yapıştırctrlvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{v}");
        }
        //tümünü seç - select all
        private void seçctrlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{a}");
        }
    }
}
