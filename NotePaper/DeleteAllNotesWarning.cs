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
    public partial class DeleteAllNotesWarning : Form
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = '|DataDirectory|\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");

        public List<int> id = new List<int>();
        string securityKey = "";
        public string mediaId = "";
        public List<int> mediaTableId = new List<int>();
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();

        public DeleteAllNotesWarning()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_IconRightClick(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == guna2HtmlLabel17.Text)
            {
                sqlConnection.Open();
                for(int i = 0; i < id.Count; i++)
                {
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlConnection;
                    command.CommandText = "delete Notes where Id='" + id[i] + "'";
                    command.ExecuteNonQuery();
                }

                if (mediaTableId.Count!=0)
                {
                    for (int i = 0; i < mediaTableId.Count; i++)
                    {
                        SqlCommand mediaDelete = new SqlCommand();
                        mediaDelete.Connection = sqlConnection;
                        mediaDelete.CommandText = "delete Media where Id='" + mediaTableId[i] + "'";
                        mediaDelete.ExecuteNonQuery();
                    }
                }
                guna2TextBox1.Visible = false;
                guna2ProgressIndicator1.Start();
                timer1.Enabled = true;
                timer1.Start();
                sqlConnection.Close();
                mediaTableId.Clear();
                id.Clear();
            }
            else
            {
                securityKey = CreatePassword(17);
                guna2HtmlLabel17.Text = securityKey;
            }
        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void DeleteAllNotesWarning_Load(object sender, EventArgs e)
        {
            securityKey = CreatePassword(17);
            guna2HtmlLabel17.Text = securityKey;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressIndicator1.Stop();
            guna2ProgressIndicator1.Dispose();
            timer1.Enabled = false;
            timer1.Stop();
            timer1.Dispose();
            btn.PerformClick();
            this.Close();
        }
    }
}
