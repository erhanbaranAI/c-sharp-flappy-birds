using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        Form1 fr1;

        private void pbBaslat_Click(object sender, EventArgs e)
        {
            fr1 = new Form1();
            this.Hide();
            fr1.Show();
        }

        private void pbCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            lblHighScoreValue.Text = Settings1.Default.HighScore.ToString();
        }
    }
}
