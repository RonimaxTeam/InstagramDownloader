using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insta_Downloader
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxOk.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxOk.BorderStyle = BorderStyle.None;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/RonimaxTeam");
        }

        private void linkLabelInstagram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/ronimaxteam/");
        }
    }
}
