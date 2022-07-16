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
    public partial class home_notes_card : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\csharp projelerim\\NotePaper\\NotePaper\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");
        public string mediaId = "";
        public string addNoteTextHeader = "";
        public string addNoteText = "";
        public string deleteNoteHeaderText = "";
        public string deleteNoteMessageText = "";
        public int id = 0;
        public int colorA = 20;
        public int colorR = 57;
        public int colorB = 100;
        public int languageIndex = 0;
        public bool favorites = false;
        public bool nightMode = false;
        public string categorie = "";
        public string bold = "";
        public string underline = "";
        public string thumb = "";
        public string color = "";
        public List<string> type = new List<string>();
        public List<string> videoUrl= new List<string>();
        public DateTime date = DateTime.Now;
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();
        public List<int> mediaTableId = new List<int>();
        List<string> categoriesList = new List<string>();
        string[] categoriesArray = {
                  "Hatırlatma",
            "Okul",
            "İş",
            "Ev ihtiyaçları",
            "İhtiyaçlar",
            "İstekler",
            "Kişisel gereksinim",
            "Spor",
            "Seyahat",
            "Tatil planı",
            "Randevular",
            "Sağlık",
            "Yemek",
            "Blog",
            "Özel",
            "Hediye",
            "Doğum günü",
            "Bayramlar",
            "Alınacaklar",
            "Ödemeler",
            "Şiir",
            "Yazılar",
            "Teknoloji",
            "Hayaller",
            "Hedefler",
            "Motivasyon",
            "Müzik",
            "Doğa",
            "Yapay zeka",
            "Sosyal",
            "Aşk",
            "Romantizm",
            "Para",
            "Arkadaş",
            "Diğer"
            };

        public home_notes_card()
        {
            InitializeComponent();
        }

        private void guna2Panel1_MouseHover(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(30, 77, 155);
            guna2Panel1.BackColor = Color.FromArgb(30, 77, 155);
            titleLabel.BackColor = Color.FromArgb(30, 77, 155);
            noteShortLabel.BackColor = Color.FromArgb(30, 77, 155);
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(colorA,colorR,colorB);
            guna2Panel1.BackColor = Color.FromArgb(colorA, colorR, colorB);
            titleLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);
            noteShortLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);

        }

        private void titleLabel_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 77, 155);
            titleLabel.BackColor = Color.FromArgb(30, 77, 155);
            guna2Panel1.BackColor = Color.FromArgb(30, 77, 155);
            noteShortLabel.BackColor = Color.FromArgb(30, 77, 155);
        }

        private void titleLabel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(colorA, colorR, colorB);
            titleLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);
            guna2Panel1.BackColor = Color.FromArgb(colorA, colorR, colorB);
            noteShortLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);
        }

        private void noteShortLabel_MouseHover(object sender, EventArgs e)
        {
           
            this.BackColor = Color.FromArgb(30, 77, 155);
            noteShortLabel.BackColor = Color.FromArgb(30, 77, 155);
            guna2Panel1.BackColor = Color.FromArgb(30, 77, 155);
            titleLabel.BackColor = Color.FromArgb(30, 77, 155);

        }

        private void noteShortLabel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(colorA, colorR, colorB);
            noteShortLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);
            guna2Panel1.BackColor = Color.FromArgb(colorA, colorR, colorB);
            titleLabel.BackColor = Color.FromArgb(colorA, colorR, colorB);

        }

        private void home_notes_card_Load(object sender, EventArgs e)
        {
            categoriesList.AddRange(categoriesArray);

            if (mediaId != "")
            {
                sqlConnection.Open();
                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Media]");
                SqlDataReader mediaTableIdReader = command1.ExecuteReader();
                while (mediaTableIdReader.Read())
                {
                    if (mediaTableIdReader != null)
                    {
                        if (mediaTableIdReader["mediaId"].ToString() == mediaId)
                        {
                            mediaTableId.Add(Convert.ToInt32(mediaTableIdReader["Id"]));
                        }
                    }
                }
                sqlConnection.Close();
            }
        }

        private void addFavorites_Click(object sender, EventArgs e)
        {
            //veri tabanına favorilere ekleme kodları yazılacak
            if (favorites == true)
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "delete Notes where Id='" + id + "'";
                command.ExecuteNonQuery();
                //-------
                SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('"+noteShortLabel.Text+"','"+categorie+"','"+date+"','"+titleLabel.Text+"','"+0+"','"+thumb+"','"+color+ "','" + mediaId + "')", sqlConnection);
                command2.CommandType = System.Data.CommandType.Text;
                command2.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Notes]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                }
                sqlConnection.Close();
                addFavorites.Image = Image.FromFile("icons/heart_30px.png");
                favorites = false;
      
            }
            else
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "delete Notes where Id='" + id + "'";
                command.ExecuteNonQuery();
                //-------
                SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + 1 + "','" + thumb + "','" + color + "','" + mediaId + "')", sqlConnection);
                command2.CommandType = System.Data.CommandType.Text;

                command2.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Notes]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                }
                sqlConnection.Close();
                addFavorites.Image = Image.FromFile("icons/heart_red.png");
                favorites = true;
       
            }
        }

        private void deleteNote_Click(object sender, EventArgs e)
        {
            Languages ln = new Languages();
            NotuSilMessage sil = new NotuSilMessage();
            sil.mediaTableId = mediaTableId;
            sil.mediaId = mediaId;
            sil.id = id;
            sil.btn = btn;
            sil.guna2HtmlLabel1.Text = deleteNoteHeaderText;
            sil.guna2HtmlLabel2.Text = deleteNoteMessageText;
            sil.deleteButtonText = ln.Delete[languageIndex];
            sil.cancelButtonText = ln.Cancel[languageIndex];
            sil.ShowDialog();
            
        }

        private void showNote_Click(object sender, EventArgs e)
        {
            addNotes note = new addNotes();
            note.Text = "Read Note";
            note.mode = "read";
            note.guna2TextBox1.Text = titleLabel.Text;
            note.guna2TextBox2.Text = noteShortLabel.Text;
            note.guna2TextBox1.ReadOnly = true;
            note.guna2TextBox2.ReadOnly = true;
            note.guna2ComboBox1.SelectedIndex = categoriesList.IndexOf(categorie);
            note.id = id;
            note.mediaId = mediaId;
            note.color = color;
            note.date = date;
            note.btn = btn;
            note.thumb = thumb;
            note.guna2TextBox1.PlaceholderText = addNoteTextHeader;
            note.guna2TextBox2.PlaceholderText = addNoteText;
            note.languageIndex = languageIndex;
            if (favorites == true)
                note.favorites = 1;
            if (bold == "true")
                note.guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Bold);
            if (underline == "true")
                note.bold = true;
            if (nightMode)
            {
                //newNoteColor = Color.FromArgb(20, 20, 20);
                //newNoteTextboxColor = Color.FromArgb(30, 30, 30);
                note.BackColor = Color.FromArgb(20, 20, 20);
                note.guna2TextBox1.FillColor = Color.FromArgb(30, 30, 30);
                note.guna2TextBox2.FillColor = Color.FromArgb(30, 30, 30);
                note.guna2ComboBox1.FillColor = Color.FromArgb(30, 30, 30);
            }
            if (mediaId != "")
            {
                note.mediaTableId = mediaTableId;
            }
            note.Show();
        }

        private void küçükResimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fav = 0;
            if (favorites == true)
            {
                fav = 1;
            }
            else
            {
                fav = 0;
            }
            openFileDialog1.Filter = ("Image files (*.jpg)|*.jpg|png (*.png)|*.png|gif (*.gif)|*.gif");
            openFileDialog1.Title = "Bir Küçük resim Seçin";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!="openFileDialog1")
            {
                thumb = openFileDialog1.FileName;
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "delete Notes where Id='" + id + "'";
                command.ExecuteNonQuery();
                //-------
                SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,bold,underline,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + fav + "','"+bold+ "','" + underline + "','" + thumb+"','"+color+ "','" + mediaId + "')", sqlConnection);
                command2.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Notes]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                }
                sqlConnection.Close();
                btn.PerformClick();
            }
        }

        private void arkaplanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int fav = 0;
            if (favorites == true)
            {
                fav = 1;
            }
            else
            {
                fav = 0;
            }
            colorDialog1.ShowDialog();
            if (!colorDialog1.Color.IsEmpty)
            {
                colorA = colorDialog1.Color.R;
                colorB = colorDialog1.Color.G;
                colorR = colorDialog1.Color.B;
                color = colorA.ToString() + "," + colorB.ToString() + "," + colorR.ToString();
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "delete Notes where Id='" + id + "'";
                command.ExecuteNonQuery();
                //-------
                SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + fav + "','" + thumb + "','"+color+ "','" + mediaId + "')", sqlConnection);
                command2.ExecuteNonQuery();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Notes]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);

                }
                sqlConnection.Close();
                btn.PerformClick();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNotes note = new addNotes();
            note.mode = "read";
            note.guna2TextBox1.Text = titleLabel.Text;
            note.guna2TextBox2.Text = noteShortLabel.Text;
            note.guna2TextBox1.ReadOnly = true;
            note.guna2TextBox2.ReadOnly = true;
            note.guna2ComboBox1.SelectedIndex = categoriesList.IndexOf(categorie);
            note.id = id;
            note.mediaId = mediaId;
            note.color = color;
            note.date = date;
            note.btn = btn;
            note.thumb = thumb;
            if (favorites == true)
                note.favorites = 1;
            if (bold == "true")
                note.guna2TextBox2.Font = new Font(DefaultFont.FontFamily, 9, FontStyle.Bold);
            if (underline == "true")
                note.bold = true;
            if (nightMode)
            {
                //newNoteColor = Color.FromArgb(20, 20, 20);
                //newNoteTextboxColor = Color.FromArgb(30, 30, 30);
                note.BackColor = Color.FromArgb(20, 20, 20);
                note.guna2TextBox1.FillColor = Color.FromArgb(30, 30, 30);
                note.guna2TextBox2.FillColor = Color.FromArgb(30, 30, 30);
                note.guna2ComboBox1.FillColor = Color.FromArgb(30, 30, 30);
            }
            if (mediaId != "")
            {
                note.mediaTableId = mediaTableId;
            }
            note.Show();
        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            panel1.Width = 126;
            panel1.Height = 120;
            panel1.Visible = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            panel1.Width = 0;
            panel1.Height = 0;
            panel1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            int fav = 0;
            if (favorites)
            {
                fav = 1;
            }
            else
            {
                fav = 0;
            }
            if (mediaId != "")
            {
                Random r = new Random();
                string randomId = r.Next(10, 90).ToString() + "-" + r.Next(100, 1000).ToString() + "-" + r.Next(1000, 5000).ToString() + "-" + r.Next(10000, 20000).ToString() + "-" + r.Next(100000, 300000).ToString();
                SqlCommand command1 = new SqlCommand();
                command1.Connection = sqlConnection;
                command1.CommandText = ("Select * From [Media]");
                SqlDataReader reader = command1.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["mediaId"].ToString() == mediaId)
                    {
                        type.Add(reader["type"].ToString());
                        videoUrl.Add(reader["path"].ToString());
                    }
                }
                reader.Close();
                for (int i = 0; i < videoUrl.Count; i++)
                {
                    SqlCommand addMedia = new SqlCommand("insert into Media(type,mediaId,path) values ('" + type[i] + "','" + randomId + "','" + videoUrl[i] + "')", sqlConnection);
                    addMedia.ExecuteNonQuery();
                }
                mediaId = randomId;
            }
            SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + fav + "','" + thumb + "','" + color + "','" + mediaId + "')", sqlConnection);
            command2.CommandType = System.Data.CommandType.Text;
            command2.ExecuteNonQuery();
            sqlConnection.Close();
            btn.PerformClick();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int fav = 0;
            if (favorites)
            {
                fav = 1;
            }
            else
            {
                fav = 0;
            }
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "delete Notes where Id='" + id + "'";
            command.ExecuteNonQuery();
            //-------
            SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + fav + "','" + null + "','" + color + "','" + mediaId + "')", sqlConnection);
            command2.CommandType = System.Data.CommandType.Text;
            command2.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand();
            command1.Connection = sqlConnection;
            command1.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["Id"]);

            }
            sqlConnection.Close();
            btn.PerformClick();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int fav = 0;
            if (favorites)
            {
                fav = 1;
            }
            else
            {
                fav = 0;
            }
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "delete Notes where Id='" + id + "'";
            command.ExecuteNonQuery();
            //-------
            SqlCommand command2 = new SqlCommand("insert into Notes(note,categorie,date,header,favorites,thumb,color,mediaId) values ('" + noteShortLabel.Text + "','" + categorie + "','" + date + "','" + titleLabel.Text + "','" + fav + "','" + thumb + "','" + null + "','" + mediaId + "')", sqlConnection);
            command2.CommandType = System.Data.CommandType.Text;
            command2.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand();
            command1.Connection = sqlConnection;
            command1.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                id = Convert.ToInt32(reader["Id"]);

            }
            sqlConnection.Close();
            btn.PerformClick();
        }
    }
}
