using Microsoft.Win32;
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
    public partial class Settings : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");

        bool started = false;
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();
        public Guna.UI2.WinForms.Guna2CircleButton btnSettings = new Guna.UI2.WinForms.Guna2CircleButton();
        List<int> id = new List<int>();
        List<int> mediaTableId = new List<int>();
        public Settings()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (started)
                {
                    if (guna2ToggleSwitch1.Checked)        // program oto başlatma işaretlenirse
                    {

                        //işaretlendi ise Regedit e açılışta çalıştır olarak ekle
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                        key.SetValue("NotePaper", "\"" + Application.ExecutablePath + "\"");
                        sqlConnection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = sqlConnection;
                        command.CommandText = "UPDATE Settings SET started = @start";
                        command.Parameters.AddWithValue("@start", 1);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                    }
                    else              //program oto çalıştırma iptal edilirse
                    {

                        //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                        RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                        key.DeleteValue("NotePaper");
                        sqlConnection.Open();
                        SqlCommand command = new SqlCommand();
                        command.Connection = sqlConnection;
                        command.CommandText = "UPDATE Settings SET started = @start";
                        command.Parameters.AddWithValue("@start", 0);
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                    }
                }
            }
            catch 
            {
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            GetSettingsData();
        }
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
                    if (Convert.ToInt32(reader["started"]) == 1)
                    {
                        guna2ToggleSwitch1.Checked = true;
                    }
                    if (Convert.ToInt32(reader["startedNightmode"]) == 1)
                    {
                        guna2ToggleSwitch2.Checked = true;
                    }
                    if (Convert.ToInt32(reader["autoNightmode"]) == 1)
                    {
                        guna2ToggleSwitch3.Checked = true;
                    }
                    if (Convert.ToInt32(reader["autoSave"]) == 1)
                    {
                        guna2ToggleSwitch4.Checked = true;
                    }
                    if (Convert.ToInt32(reader["weather"]) == 1)
                    {
                        guna2ToggleSwitch5.Checked = true;
                    }
                    if (reader["weatherCity"] != null)
                    {
                        guna2ComboBox2.SelectedIndex = Convert.ToInt32(reader["weatherCity"]);
                    }
                    if (reader["language"] != null)
                    {
                        guna2ComboBox1.SelectedIndex = Convert.ToInt32(reader["language"]);
                        guna2HtmlLabel22.Text = ln.settings[Convert.ToInt32(reader["language"])];
                        startLabel.Text = ln.RunatStartup[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel1.Text = ln.RunatStartupDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel3.Text = ln.NightModeatStartup[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel2.Text = ln.NightModeatStartupDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel7.Text = ln.AutoNightMode[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel6.Text = ln.AutoNightModeDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel9.Text = ln.AutoSave[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel8.Text = ln.AutoSaveDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel11.Text = ln.Weatherforecast[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel10.Text = ln.WeatherforecastDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel13.Text = ln.WeatherCity[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel12.Text = ln.WeatherCityDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel5.Text = ln.Languageoptions[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel4.Text = ln.LanguageoptionsDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel15.Text = ln.DeleteNotes[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel14.Text = ln.DeleteNotesDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel17.Text = ln.DeleteFavorites[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel16.Text = ln.DeleteFavoritesDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel19.Text = ln.Reset[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel18.Text = ln.ResetDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel24.Text = ln.ApplyNow[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel23.Text = ln.ApplyNowDetail[Convert.ToInt32(reader["language"])];
                        guna2HtmlLabel25.Text = ln.ApplyNowWarning[Convert.ToInt32(reader["language"])];
                        guna2TileButton1.Text = ln.Clean[Convert.ToInt32(reader["language"])];
                        guna2TileButton2.Text = ln.Clean[Convert.ToInt32(reader["language"])];
                        guna2TileButton3.Text = ln.Reset[Convert.ToInt32(reader["language"])];
                        guna2TileButton4.Text = ln.Apply[Convert.ToInt32(reader["language"])];
                        linkLabel1.Text = ln.Help[Convert.ToInt32(reader["language"])];
                        linkLabel2.Text = ln.Feedback[Convert.ToInt32(reader["language"])];
                        linkLabel3.Text = ln.About[Convert.ToInt32(reader["language"])];
                        linkLabel5.Text = ln.Backup[Convert.ToInt32(reader["language"])];
                        linkLabel6.Text = ln.Donation[Convert.ToInt32(reader["language"])];
                    }
                }
            }
            sqlConnection.Close();
            started = true;
        }

        private void guna2ToggleSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (started)
            {
                if (guna2ToggleSwitch2.Checked)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET startedNightmode = @night";
                    command.Parameters.AddWithValue("@night", 1);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET startedNightmode = @night";
                    command.Parameters.AddWithValue("@night", 0);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        private void guna2ToggleSwitch4_CheckedChanged(object sender, EventArgs e)
        {
            if (started)
            {
                if (guna2ToggleSwitch4.Checked)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET autoSave = @save";
                    command.Parameters.AddWithValue("@save", 1);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET autoSave = @save";
                    command.Parameters.AddWithValue("@save", 0);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        private void guna2ToggleSwitch5_CheckedChanged(object sender, EventArgs e)
        {
            if (started)
            {
                if (guna2ToggleSwitch5.Checked)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET weather = @wt";
                    command.Parameters.AddWithValue("@wt", 1);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET weather = @wt";
                    command.Parameters.AddWithValue("@wt", 0);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (started)
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "UPDATE Settings SET weatherCity = @ct";
                command.Parameters.AddWithValue("@ct", guna2ComboBox2.SelectedIndex);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (started)
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "UPDATE Settings SET language = @lan";
                command.Parameters.AddWithValue("@lan", guna2ComboBox1.SelectedIndex);
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void guna2ToggleSwitch3_CheckedChanged(object sender, EventArgs e)
        {
            if (started)
            {
                if (guna2ToggleSwitch3.Checked)
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET autoNightmode = @night";
                    command.Parameters.AddWithValue("@night", 1);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "UPDATE Settings SET autoNightmode = @night";
                    command.Parameters.AddWithValue("@night", 0);
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            guna2TileButton4.Visible = false;
            guna2ProgressIndicator1.Visible = true;
            guna2ProgressIndicator1.Start();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn.PerformClick();
            guna2ProgressIndicator1.Stop();
            guna2ProgressIndicator1.Dispose();
            timer1.Enabled = false;
            timer1.Stop();
            timer1.Dispose();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/yasincanolcay");
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = ("Select * From [Notes]");
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader != null)
                {
                    id.Add(Convert.ToInt32(reader["Id"]));
                    if (reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                    {
                        mediaTableId.Add(Convert.ToInt32(reader["mediaId"]));
                    }
                }
            }
            sqlConnection.Close();
            if (id.Count != 0)
            {
                DeleteAllNotesWarning deleteWarning = new DeleteAllNotesWarning();
                deleteWarning.id = id;
                deleteWarning.mediaTableId = mediaTableId;
                deleteWarning.btn = btnSettings;
                deleteWarning.Show();
            }
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
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
                        id.Add(Convert.ToInt32(reader["Id"]));
                        if (reader["mediaId"] != null && reader["mediaId"].ToString() != "")
                        {
                            mediaTableId.Add(Convert.ToInt32(reader["mediaId"]));
                        }
                    }
                }
            }
            sqlConnection.Close();
            if (id.Count != 0)
            {
                DeleteAllNotesWarning deleteWarning = new DeleteAllNotesWarning();
                deleteWarning.id = id;
                deleteWarning.mediaTableId = mediaTableId;
                deleteWarning.btn = btnSettings;
                deleteWarning.Show();
            }
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "UPDATE Settings SET started = @started,startedNightmode=@ng,autoNightmode=@autonight,autoSave=@aSave,weather=@w,weatherCity=@wc,language=@lan";
            command.Parameters.AddWithValue("@started", 0);
            command.Parameters.AddWithValue("@ng", 0);
            command.Parameters.AddWithValue("@autonight", 0);
            command.Parameters.AddWithValue("@aSave", 0);
            command.Parameters.AddWithValue("@w", 0);
            command.Parameters.AddWithValue("@wc", 0);
            command.Parameters.AddWithValue("@lan", 0);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            btnSettings.PerformClick();
        }
    }
}
