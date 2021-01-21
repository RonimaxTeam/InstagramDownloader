using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Insta_Downloader
{
    public partial class InstagramWeb : Form
    {


        #region Constractor

        public InstagramWeb()
        {
            InitializeComponent();
            //webBrowser1.Document.ExecCommand("ClearAuthenticationCache", false, null);
            webBrowser1.Url = new System.Uri("https://www.instagram.com/", System.UriKind.Absolute);
        }



        #endregion

        private void InstagramWeb_Load(object sender, EventArgs e)
        {

        }
    }
}
