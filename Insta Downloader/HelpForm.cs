using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Insta_Downloader
{
    public partial class HelpForm : Form
    {
        #region Fields

        string startupPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        List<Image> images = new List<Image>();

        #endregion

        #region Constractor

        public HelpForm()
        {
            InitializeComponent();
            Image Introduction = new Bitmap(Insta_Downloader.Properties.Resources.Introduction);
            
            
            Image Amoozeshedownloader = new Bitmap(Insta_Downloader.Properties.Resources.downloader_helper);
            Image Welcome = new Bitmap(Insta_Downloader.Properties.Resources.Welcome);

            pictureBoxPrevious.Enabled = false;
            images.Add(Introduction);
            images.Add(Amoozeshedownloader);
            images.Add(Welcome);
            pictureBoxHelp.Image = images[0];
        }

        #endregion

        #region Events and Methods

        #region Events

        #region Form Load Event
        private void HelpForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }

        #endregion

        #region Click Events
        private void pictureBoxNext_Click(object sender, EventArgs e)
        {


            if (pictureBoxHelp.Image == images[0])
            {
                pictureBoxPrevious.Enabled = true;
                pictureBoxHelp.Image = images[1];
            }
            else if (pictureBoxHelp.Image == images[1])
            {
                pictureBoxPrevious.Enabled = true;
                pictureBoxHelp.Image = images[2];
            }
            else
            {      
                this.Hide();
            }





        }
        private void pictureBoxPrevious_Click(object sender, EventArgs e)
        {


            if (pictureBoxHelp.Image == images[1])
            {
                pictureBoxPrevious.Enabled = false;
                pictureBoxHelp.Image = images[0];
            }
            else if (pictureBoxHelp.Image == images[2])
            {
                pictureBoxHelp.Image = images[1];
            }
            

        }

        #endregion

        #region Mouse Enents
        private void pictureBoxNext_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxNext.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBoxNext_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxNext.BorderStyle = BorderStyle.None;
        }
        private void pictureBoxPrevious_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxPrevious.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBoxPrevious_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPrevious.BorderStyle = BorderStyle.None;
        }
        private void HelpForm_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxNext.BorderStyle = BorderStyle.None;
            pictureBoxPrevious.BorderStyle = BorderStyle.None;
        }

        #endregion

        #endregion

        #region Methods

        #endregion

        #endregion


    }
}
