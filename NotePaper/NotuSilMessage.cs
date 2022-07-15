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
    public partial class NotuSilMessage : Form
    {
        public int id = 0;
        public Guna.UI2.WinForms.Guna2CircleButton btn = new Guna.UI2.WinForms.Guna2CircleButton();
        SqlConnection sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = 'C:\\csharp projelerim\\NotePaper\\NotePaper\\Database1.mdf'; Integrated Security = True; Connect Timeout = 30");
        public string mediaId = "";
        public List<int> mediaTableId = new List<int>();
        public string headerText = "";
        public string messageText = "";
        public NotuSilMessage()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sqlConnection;
            command.CommandText = "delete Notes where Id='" + id + "'";
            command.ExecuteNonQuery();

            if (mediaId != "")
            {
                for(int i = 0; i < mediaTableId.Count; i++)
                {
                    SqlCommand mediaDelete = new SqlCommand();
                    mediaDelete.Connection = sqlConnection;
                    mediaDelete.CommandText = "delete Media where Id='" + mediaTableId[i] + "'";
                    mediaDelete.ExecuteNonQuery();
                }
            }


            btn.PerformClick();
            guna2ControlBox1.PerformClick();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2ControlBox1.PerformClick();
        }
    }
}
