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
using System.Security.Permissions;
namespace Insta_Downloader
{
    public partial class FormLogin : Form
    {

        #region Fields
        public string cookieData;
        string startupPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        #endregion


        #region Constractor
        public FormLogin()
        {
            InitializeComponent();
            
            webBrowser.Url = new System.Uri("https://www.instagram.com/accounts/login/", System.UriKind.Absolute);
            timer1.Start();
        }
        #endregion


        #region Methods and Events

        #region Events

        #region Form Load Event

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //get Cookie and write To File
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (true && TimerState.State == true)
            {
                cookieData = Cookies.GetCookies(webBrowser?.Document?.Url, this.GetFlags());
                if (cookieData != null)
                {
                    if (cookieData.Contains("urlgen") && cookieData.Contains("sessionid"))
                    {
                        cookieData = Cookies.GetCookies(webBrowser?.Document?.Url, this.GetFlags());
                        File.WriteAllText(startupPath + "\\Cookie.txt", cookieData);
                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.ShowDialog();
                        timer1.Stop();

                    }


                }
            }


        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        #endregion

        #region Methods

        private CookieRetrievalFlags GetFlags()
        {
            CookieRetrievalFlags flags;

            flags = CookieRetrievalFlags.None;

            flags |= CookieRetrievalFlags.HttpOnly;

            return flags;
        }

        #endregion

        #endregion


    }
}
