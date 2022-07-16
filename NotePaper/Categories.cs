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
    public partial class Categories : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");

        int totalNotes = 0;
        public int languageIndex = 0;
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();
        bool thumb = false;
        bool media = false;
        public bool nightMode = false;
        public string mediaId = "";
        public string addNoteText = "";
        public string addNoteHeaderText = "";
        public string deleteNoteHeaderText = "";
        public string deleteNoteMessageText = "";
        public string searchBoxText = "";
        public string searchText = "";
        public string categoriesText = "";
        public string thumbailButtonText = "";
        public string mediaButtonText = "";
        public string cleanButtonText = "";
        public string backgroundcolor = "";
        public string open = "";
        public string thumbText = "";
        public string clone = "";
        public string DeleteThumbnail = "";
        public string DefaultColor = "";
        public string back = "";
        public Categories()
        {
            InitializeComponent();
        }
        private void SearchNotesFilter()
        {
            flowLayoutPanel1.Controls.Clear();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    if(reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && !thumb && !media)
                    {
                        totalNotes++;
                        totalResponse.Text = totalNotes.ToString();
                        home_notes_card notesCard = new home_notes_card();
                        notesCard.btn = btn;
                        notesCard.TopLevel = false;
                        notesCard.titleLabel.Text = reader["header"].ToString();
                        notesCard.noteShortLabel.Text = reader["note"].ToString();
                        notesCard.datetimeLabel.Text = reader["date"].ToString();
                        notesCard.id = Convert.ToInt32(reader["Id"]);
                        notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                        notesCard.bold = reader["bold"].ToString();
                        notesCard.underline = reader["underline"].ToString();
                        notesCard.mediaId = reader["mediaId"].ToString();
                        notesCard.date = Convert.ToDateTime(reader["date"]);
                        notesCard.addNoteText = addNoteText;
                        notesCard.addNoteTextHeader = addNoteHeaderText;
                        notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                        notesCard.deleteNoteMessageText = deleteNoteMessageText;
                        notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                        notesCard.açToolStripMenuItem.Text = open;
                        notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                        notesCard.guna2Button1.Text = clone;
                        notesCard.guna2Button2.Text = DeleteThumbnail;
                        notesCard.guna2Button3.Text = DefaultColor;
                        notesCard.guna2Button4.Text = back;
                        notesCard.languageIndex = languageIndex;
                        if (Convert.ToInt32(reader["favorites"]) == 1)
                        {
                            notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                            notesCard.favorites = true;
                        }
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            notesCard.thumb = reader["thumb"].ToString();
                            notesCard.pictureBox1.Visible = true;
                            notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                        }
                        if (reader["color"] != null && reader["color"].ToString() != "")
                        {
                            notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                            notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                            notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                            notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                            notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                        }
                        if (nightMode)
                        {
                            notesCard.nightMode=nightMode;
                        }
                        flowLayoutPanel1.Controls.Add(notesCard);
                        notesCard.Show();
                    }
                    else if (reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && !thumb && media)
                    {
                        if (reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]); 
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && thumb && !media)
                    {
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString(); 
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && thumb && media)
                    {
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "" && reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (searchTextBox.Text=="" && thumb && !media)
                    {
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (searchTextBox.Text == "" && thumb && media)
                    {
                        if (reader["thumb"] != null && reader["thumb"].ToString() != "" && reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (searchTextBox.Text == "" && !thumb && media)
                    {
                        if (reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                }
            }
            totalNotes = 0;
            sqlConnection.Close();
        }

        private void searchTextBox_IconRightClick(object sender, EventArgs e)
        {
                SearchNotesFilter();
        }

        private void thumbailButton_Click(object sender, EventArgs e)
        {
            if (thumb)
            {
                thumb = false;
                thumbailButton.FillColor = Color.FromArgb(94, 148, 255);
            }
            else
            {
                thumb = true;
                thumbailButton.FillColor = Color.FromArgb(54, 148, 255);
            }
        }

        private void mediaButton_Click(object sender, EventArgs e)
        {
            if (media)
            {
                media = false;
                mediaButton.FillColor = Color.FromArgb(94, 148, 255);

            }
            else
            {
                media = true;
                mediaButton.FillColor = Color.FromArgb(54, 148, 255);

            }
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
            flowLayoutPanel1.Controls.Clear();
            media = false;
            thumb = false;
            totalNotes = 0;
            totalResponse.Text = "0";
            thumbailButton.FillColor = Color.FromArgb(94, 148, 255);
            mediaButton.FillColor = Color.FromArgb(94, 148, 255);
            categoriesComboBox.Text = "";
            categoriesComboBox.SelectedIndex = 0;
        }

        private void categoriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    if (reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && !thumb && !media && categoriesComboBox.SelectedItem.ToString() != "" && categoriesComboBox.SelectedItem.ToString() != "Filtre yok")
                    {
                        if (Convert.ToInt32(reader["categorie"]) == categoriesComboBox.SelectedIndex)
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (reader["header"].ToString().ToLower() == searchTextBox.Text.ToLower() && thumb && !media && categoriesComboBox.SelectedItem.ToString() != "" && categoriesComboBox.SelectedItem.ToString() != "Filtre yok")
                    {
                        if (Convert.ToInt32(reader["categorie"]) == categoriesComboBox.SelectedIndex && reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (searchTextBox.Text=="" && thumb && !media && categoriesComboBox.SelectedItem.ToString() != "" && categoriesComboBox.SelectedItem.ToString() != "Filtre yok")
                    {
                        if (Convert.ToInt32(reader["categorie"]) == categoriesComboBox.SelectedIndex && reader["thumb"] != null && reader["thumb"].ToString() != "")
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                    else if (searchTextBox.Text == "" && !thumb && !media && categoriesComboBox.SelectedItem.ToString() != "" && categoriesComboBox.SelectedItem.ToString() != "Filtre yok")
                    {
                        if (Convert.ToInt32(reader["categorie"]) == categoriesComboBox.SelectedIndex)
                        {
                            totalNotes++;
                            totalResponse.Text = totalNotes.ToString();
                            home_notes_card notesCard = new home_notes_card();
                            notesCard.btn = btn;
                            notesCard.TopLevel = false;
                            notesCard.titleLabel.Text = reader["header"].ToString();
                            notesCard.noteShortLabel.Text = reader["note"].ToString();
                            notesCard.datetimeLabel.Text = reader["date"].ToString();
                            notesCard.id = Convert.ToInt32(reader["Id"]);
                            notesCard.categorie = Convert.ToInt32(reader["categorie"]);
                            notesCard.bold = reader["bold"].ToString();
                            notesCard.underline = reader["underline"].ToString();
                            notesCard.mediaId = reader["mediaId"].ToString();
                            notesCard.date = Convert.ToDateTime(reader["date"]);
                            notesCard.addNoteText = addNoteText;
                            notesCard.addNoteTextHeader = addNoteHeaderText;
                            notesCard.deleteNoteHeaderText = deleteNoteHeaderText;
                            notesCard.deleteNoteMessageText = deleteNoteMessageText;
                            notesCard.arkaplanRengiToolStripMenuItem.Text = backgroundcolor;
                            notesCard.açToolStripMenuItem.Text = open;
                            notesCard.küçükResimToolStripMenuItem.Text = thumbText;
                            notesCard.guna2Button1.Text = clone;
                            notesCard.guna2Button2.Text = DeleteThumbnail;
                            notesCard.guna2Button3.Text = DefaultColor;
                            notesCard.guna2Button4.Text = back;
                            notesCard.languageIndex = languageIndex;
                            if (Convert.ToInt32(reader["favorites"]) == 1)
                            {
                                notesCard.addFavorites.Image = Image.FromFile("icons/heart_red.png");
                                notesCard.favorites = true;
                            }
                            if (reader["thumb"] != null && reader["thumb"].ToString() != "")
                            {
                                notesCard.thumb = reader["thumb"].ToString();
                                notesCard.pictureBox1.Visible = true;
                                notesCard.pictureBox1.Image = Image.FromFile(@"" + reader["thumb"].ToString());
                            }
                            if (reader["color"] != null && reader["color"].ToString() != "")
                            {
                                notesCard.colorA = Convert.ToInt32(reader["color"].ToString().Split(',')[0]);
                                notesCard.colorR = Convert.ToInt32(reader["color"].ToString().Split(',')[1]);
                                notesCard.colorB = Convert.ToInt32(reader["color"].ToString().Split(',')[2]);
                                notesCard.color = reader["color"].ToString().Split(',')[0] + "," + reader["color"].ToString().Split(',')[1] + "," + reader["color"].ToString().Split(',')[2];
                                notesCard.guna2Panel1.BackColor = Color.FromArgb(Convert.ToInt32(reader["color"].ToString().Split(',')[0]), Convert.ToInt32(reader["color"].ToString().Split(',')[1]), Convert.ToInt32(reader["color"].ToString().Split(',')[2]));
                            }
                            if (nightMode)
                            {
                                notesCard.nightMode = nightMode;
                            }
                            flowLayoutPanel1.Controls.Add(notesCard);
                            notesCard.Show();
                        }
                    }
                }
            }
            totalNotes = 0;
            sqlConnection.Close();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            searchTextBox.PlaceholderText = searchBoxText;
            searchLabelstateles.Text = searchText;
            categoriesLabelstateles.Text = categoriesText;
            thumbailButton.Text = thumbailButtonText;
            mediaButton.Text = mediaButtonText;
            clearFilterButton.Text = cleanButtonText;
            CategoriesLanguage c = new CategoriesLanguage();
            List<string[]> categoriesLanguageList = new List<string[]>();
            categoriesLanguageList.Add(c.english);
            categoriesLanguageList.Add(c.russian);
            categoriesLanguageList.Add(c.korea);
            categoriesLanguageList.Add(c.chineese);
            categoriesLanguageList.Add(c.turkish);
            categoriesLanguageList.Add(c.Azerbaycan);
            categoriesLanguageList.Add(c.German);
            categoriesLanguageList.Add(c.french);
            categoriesLanguageList.Add(c.italy);
            categoriesLanguageList.Add(c.arabic);
            categoriesLanguageList.Add(c.espanol);
            categoriesComboBox.Items.AddRange(categoriesLanguageList[languageIndex]);
        }
    }
}
