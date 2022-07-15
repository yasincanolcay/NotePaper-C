using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePaper
{
    public partial class fontSize : Form
    {
        public Guna.UI2.WinForms.Guna2TextBox textbox1 = new Guna.UI2.WinForms.Guna2TextBox();
        public Guna.UI2.WinForms.Guna2TextBox textbox2 = new Guna.UI2.WinForms.Guna2TextBox();
        public int fontSizeValue = 8;
        public fontSize()
        {
            InitializeComponent();
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textbox1.Font = new Font(FontFamily.GenericSansSerif, float.Parse(guna2NumericUpDown1.Value.ToString()), FontStyle.Regular);
            textbox2.Font = new Font(FontFamily.GenericSansSerif, float.Parse(guna2NumericUpDown1.Value.ToString()), FontStyle.Regular);
        }

        private void fontSize_Load(object sender, EventArgs e)
        {
            guna2NumericUpDown1.Value = fontSizeValue;
        }
    }
}
