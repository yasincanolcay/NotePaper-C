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
    public partial class videoCard : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\csharp projelerim\\NotePaper\\NotePaper\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");
        public String videoUrl = "";
        public FlowLayoutPanel flowPanel = new FlowLayoutPanel();
        public List<string> videosList = new List<string>();
        public List<string> docType = new List<string>();
        public int index = 0;
        public Guna.UI2.WinForms.Guna2TextBox textbox2 = new Guna.UI2.WinForms.Guna2TextBox();
        public bool isAddFile = false;
        public string type = "";
        public int mediaTableId = 0;
        public int id = 0;
        public int languageIndex = 0;
        public string mediaId = "";
        public string header = "";
        public string notes = "";
        public string categorie = "";
        public int favorites = 0;
        public string color = "";
        public string thumb = "";

        public videoCard()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox1.Visible = true;
        }

        private void axWindowsMediaPlayer1_KeyDownEvent(object sender, AxWMPLib._WMPOCXEvents_KeyDownEvent e)
        {
            if(e.nKeyCode == Convert.ToInt32(Keys.F10))
            {
                //kodlar yazılacak
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (type != "resim" && type!="pdf")
            {
                pictureBox1.Visible = false;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            if (type == "pdf")
            {
                try
                {
                    System.Diagnostics.Process.Start(videoUrl);
                }
                catch {}
            }
        }

        private void kaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videosList.Remove(videoUrl);
            docType.Remove(type);
            flowPanel.Controls.Clear();
            for(int i = 0; i < videosList.Count; i++)
            {
                videoCard videos = new videoCard();
                videos.TopLevel = false;
                videos.videoUrl = videosList[i];
                videos.flowPanel = flowPanel;
                videos.videosList = videosList;
                videos.index = i;
                videos.textbox2 = textbox2;
                videos.isAddFile = isAddFile;
                videos.docType = docType;
                videos.type = docType[i];
                videos.header = header;
                videos.notes = notes;
                videos.categorie = categorie;
                videos.favorites = favorites;
                videos.color = color;
                videos.thumb = thumb;
                flowPanel.Controls.Add(videos);
                videos.Show();
            }
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand();
            command2.Connection = sqlConnection;
            command2.CommandText = "delete Media where Id='" + mediaTableId + "'";
            command2.ExecuteNonQuery();
            if (videosList.Count == 0)
            {
                textbox2.Height = textbox2.Height + 70;
                flowPanel.Visible = false;
                isAddFile = false;
            }
            sqlConnection.Close();

        }

        private void videoCard_Load(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            kaldırToolStripMenuItem.Text = ln.remove[languageIndex];
            duraklatToolStripMenuItem.Text = ln.Pause[languageIndex];
            durdurToolStripMenuItem.Text = ln.Stop[languageIndex];
            oynatToolStripMenuItem.Text = ln.Play[languageIndex];
            toolStripMenuItem1.Text = ln.remove[languageIndex];
            tamEkranToolStripMenuItem.Text = ln.FullScreen[languageIndex];
            if (type == "audio")
            {
                axWindowsMediaPlayer1.URL = videoUrl;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                pictureBox1.Image = Image.FromFile("icons/audio_wave_30px.png");
            }
            else if (type == "resim")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(videoUrl);
                guna2ContextMenuStrip1.Enabled = false;
                this.ContextMenuStrip = guna2ContextMenuStrip2;
                pictureBox1.ContextMenuStrip = guna2ContextMenuStrip2;
            }
            else if(type == "video")
            {
                axWindowsMediaPlayer1.URL = videoUrl;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                pictureBox1.Image = Image.FromFile("icons/video_30px.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("icons/document_30px.png");
                tamEkranToolStripMenuItem.Enabled = false;
                guna2ContextMenuStrip1.Enabled = false;
                this.ContextMenuStrip = guna2ContextMenuStrip2;
                pictureBox1.ContextMenuStrip = guna2ContextMenuStrip2;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            videosList.Remove(videoUrl);
            docType.Remove(type);
            flowPanel.Controls.Clear();
            for (int i = 0; i < videosList.Count; i++)
            {
                videoCard videos = new videoCard();
                videos.TopLevel = false;
                videos.videoUrl = videosList[i];
                videos.flowPanel = flowPanel;
                videos.videosList = videosList;
                videos.index = i;
                videos.textbox2 = textbox2;
                videos.isAddFile = isAddFile;
                videos.docType = docType;
                videos.type = docType[i];
                flowPanel.Controls.Add(videos);
                videos.Show();
            }
            sqlConnection.Open();
            SqlCommand command2 = new SqlCommand();
            command2.Connection = sqlConnection;
            command2.CommandText = "delete Media where Id='" + mediaTableId + "'";
            command2.ExecuteNonQuery();
            sqlConnection.Close();
            if (videosList.Count == 0)
            {
                textbox2.Height = textbox2.Height + 70;
                flowPanel.Visible = false;
                isAddFile = false;
            }
        }

        private void duraklatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            pictureBox1.Visible = true;
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            pictureBox1.Visible = true;
        }

        private void oynatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
            pictureBox1.Visible = false;
        }

        private void tamEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type != "pdf")
            {
                fullScreenImage fullScreen = new fullScreenImage();
                fullScreen.pictureBox1.Image = Image.FromFile(videoUrl);
                fullScreen.Show();
            }
        }
    }
}
