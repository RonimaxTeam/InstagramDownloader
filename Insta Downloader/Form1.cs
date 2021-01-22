using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Net;
using System.Diagnostics;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.API;
namespace Insta_Downloader
{
    public partial class Form1 : Form
    {

        #region Fields

        WebClient webClient = new WebClient();
        Stopwatch stopWatch = new Stopwatch();
        static string URL;
        static Form1 obj = new Form1();
        string LinkDownloadSingleData;
        List<string> ListDownload = new List<string>();
        string startupPath2 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        Thread thread;
        private static IInstaApi InstaApi;
        #endregion

        #region Constractor

        public Form1()
        {

            InitializeComponent();
            lblStatus.Text = "Stop";
            lblStatus.ForeColor = Color.Red;
            btnStart.Enabled = false;
            btnBrowse.Enabled = false;
            txtSaveLocation.Enabled = false;
            labelPerc.Text = "0" + " %";
            TimerState.State = false;
            comboboxLinkDownload.Enabled = false;


        }

        #endregion

        #region Methods and Events

        #region Events

        #region Load Form Event

        //Form1 Load Enent
        private void Form1_Load(object sender, EventArgs e)
        {

           

            
        }

        #endregion

        #region Closed Form Event

        //Form1 Closed Form Event
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #endregion

        #region Closing Form Event
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Click Events

        //Button Login Click Event
        private void button1_Click_1(object sender, EventArgs e)
        {
            loginInsta();
        }

        //Picture box Insta Click Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InstagramWeb instagramWeb = new InstagramWeb();
            instagramWeb.Show();
            
        }
     
        //Picture box More Click Event
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            About more = new About();
            more.Show();
        }

        //Button Logout Click Event
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
           System.IO.File.Delete(startupPath2 + @"/Cookie.txt");
            

           System.Diagnostics.Process.Start("CMD.exe", "/C RunDll32.exe InetCpl.cpl,ClearMyTracksByProcess 2");

            InstagramWeb instagramWeb = new InstagramWeb();
            instagramWeb.Hide();

            FormLogin formLogin = new FormLogin();
            this.Hide();

            TimerState.State = true;
            formLogin.Show();

        }

        //Button Start Download Click Event
        private void button1_Click(object sender, EventArgs e)
        {
            switch (btnStart.Text)
            {
                case "Start Download":
                    StartDownload();
                    break;


                case "Stop Download":
                    StopDownload();
                    break;

            }

        }

        //Button Browse File Click Event
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                //Show Save File Dialog and get the file name from the URL and set to txtSaveLocation
                saveFileDialog.Filter = "All File|*.*";
                if (!string.IsNullOrEmpty(LinkDownloadSingleData))
                {
                    Uri uri = new Uri(LinkDownloadSingleData);
                    string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    saveFileDialog.FileName = filename;
                    saveFileDialog.InitialDirectory = @"C:\";
                    saveFileDialog.ShowDialog();
                    string selectedPath = saveFileDialog.FileName;
                    txtSaveLocation.Text = selectedPath;
                    btnStart.Enabled = true;
                }
                else
                {

                    Uri uri = new Uri(ListDownload[comboboxLinkDownload.SelectedIndex]);

                    string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    saveFileDialog.FileName = filename;
                    saveFileDialog.InitialDirectory = @"C:\";
                    saveFileDialog.ShowDialog();
                    string selectedPath = saveFileDialog.FileName;
                    txtSaveLocation.Text = selectedPath;
                    btnStart.Enabled = true;
                }


            }
            catch
            {

                MessageBox.Show("Please check your URL!", "Error Location", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Check URL Click Event
        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckStructureURL();
        }

        #endregion

        #region Mouse Events

        //Picture Box More Events
        
        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        //Picture Box Insta Events
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInsta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInsta.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(pictureBoxInsta, "Click to open the Instagram ");


        }

        #endregion

        #region Download Progeress Changed Event

        // Download Progeress Changed Event
        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} Kb/s", (e.BytesReceived / 1024d / stopWatch.Elapsed.TotalSeconds).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));

            // Update the progressbar percentage only when the value is not the same.
            progressBar1.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + " %";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB / {1} MB",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        #endregion

        #region Download File Completed Event

        // Download File Completed Event
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            stopWatch.Reset();

            if (e.Cancelled == true)
            {

            }
            else
            {
                btnStart.Enabled = false;
                labelPerc.Text = String.Empty;
                btnBrowse.Enabled = false;
                btnStart.Text = "Start Download";
                labelSpeed.Text = String.Empty;
                labelDownloaded.Text = String.Empty;
                lblStatus.ForeColor = Color.SeaGreen;
                labelPerc.Text = "100" + " %";
                comboboxLinkDownload.Text = String.Empty;
                comboboxLinkDownload.Enabled = false;
                txtUrl.Enabled = true;
                btnCheck.Enabled = true;
                txtSaveLocation.Enabled = false;
                txtSaveLocation.Text = String.Empty;
                LinkDownloadSingleData = String.Empty;
                btnStart.Enabled = false;
                ListDownload.Clear();
                comboboxLinkDownload.Items.Clear();
                lblStatus.Text = "Download Complete";
                
            }
        }

        #endregion

        #endregion

        #region Methods
        
        //Button Start Download Method
        private void StartDownload()
        {

            //check the type of data and pass link download to downloader method
            if (!string.IsNullOrEmpty(LinkDownloadSingleData))
            {
                DownloaderMethod(LinkDownloadSingleData);
                btnStart.Text = "Stop Download";
                btnStart.BackColor = Color.Red;
            }
            else
            {
                DownloaderMethod(ListDownload[comboboxLinkDownload.SelectedIndex]);
                btnStart.Text = "Stop Download";
                btnStart.BackColor = Color.Red;

            }

        }

        //Button Stop Download Method
        private void StopDownload()
        {

            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
            }

            lblStatus.ForeColor = Color.Red;
            lblStatus.Text = "Stop";
            labelPerc.Text = "0" + "%";
            progressBar1.Value = 0;
            labelSpeed.Text = String.Empty;
            labelPerc.Text = String.Empty;
            labelDownloaded.Text = String.Empty;
            comboboxLinkDownload.Text = String.Empty;
            btnBrowse.Enabled = false;
            txtSaveLocation.Enabled = false;
            btnStart.Text = "Start Download";
            comboboxLinkDownload.Enabled = false;
            txtUrl.Enabled = true;
            btnCheck.Enabled = true;
            txtSaveLocation.Text = String.Empty;
            LinkDownloadSingleData = String.Empty;
            btnStart.Enabled = false;
            ListDownload.Clear();
            comboboxLinkDownload.Items.Clear();

        }

        //Downloader Method
        public void DownloaderMethod(string URL)
        {
            try
            {


                labelDownloadSpeed.Enabled = true;
                labelDownloadedAndTotal.Enabled = true;
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
                lblStatus.ForeColor = Color.DodgerBlue;
                lblStatus.Text = "Downloading...";

                // Start the stopwatch which we will be using to calculate the download speed
                stopWatch.Start();



                Uri imguri = new Uri(URL);
                webClient.DownloadFileAsync(imguri, txtSaveLocation.Text);

            }
            catch
            {
                MessageBox.Show("Connection Lost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Apply the rule on the URL and Check the input URL Structure by CheckStructureURL Method
        public void CheckStructureURL()
        {

            // Apply the rule on the URL
            string patternUrl1 = "^(https://www.instagram.com/p/)";
            System.Text.RegularExpressions.Regex expression1 = new System.Text.RegularExpressions.Regex(patternUrl1);
            string patternUrl2 = "^(https://www.instagram.com/tv/)";
            System.Text.RegularExpressions.Regex expression2 = new System.Text.RegularExpressions.Regex(patternUrl2);
            //Check the input URL Structure
            if (expression1.IsMatch(txtUrl.Text) || expression2.IsMatch(txtUrl.Text))
            {
                URL = txtUrl.Text;
                btnCheck.Enabled = false;
                txtUrl.Enabled = false;
                comboboxLinkDownload.Items.Clear();
                txtSaveLocation.Enabled = false;
                comboboxLinkDownload.Enabled = false;
                comboboxLinkDownload.Text = String.Empty;
                btnBrowse.Enabled = false;
                txtSaveLocation.Text = String.Empty;
                lblStatus.ForeColor = Color.DarkOrange;
                lblStatus.Text = "Checking URL";
                progressBar1.Value = 0;
                thread = new Thread(new ThreadStart(GetInfo));
                thread.Start();
                

            }
            else
            {
                MessageBox.Show("Invalid URL", "URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //Get Info from the URL And Set to Property by GetInfo Method
        public async void GetInfo()
        {
            LinkDownloadSingleData = String.Empty;
            ListDownload.Clear();

            HttpClientHandler handler = new HttpClientHandler() { UseCookies = false };
            HttpClient client = new HttpClient(handler);
            client.BaseAddress = new Uri(URL);

           

            //try to connect and get information from the url
            try
            {

                //set URLdownload to combo box link download
                try
                {
                    Uri uri = new Uri(URL);
                    var mediaid = await InstaApi.MediaProcessor.GetMediaIdFromUrlAsync(uri);
                    var media = await InstaApi.MediaProcessor.GetMediaByIdsAsync(mediaid.Value);
                    //get link download as property IGTV
                    if (media.Value[0].ProductType == "igtv")
                    {
                        
                        LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (one IGTV)"));
                        txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                        btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                        btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                        txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                        lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.DarkGreen));
                        lblStatus.Invoke(new Action(() => lblStatus.Text = "Checking URL Complete"));

                    }

                    //get link download as property single display video
                    else if (media.Value[0].MediaType.ToString() == "Video")
                    {
                        
                        LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (One Video)"));
                        txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                        btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                        btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                        txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                        lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.DarkGreen));
                        lblStatus.Invoke(new Action(() => lblStatus.Text = "Checking URL Complete"));

                    }

                    //get link download as property single display Image
                    else if (media.Value[0].MediaType.ToString() == "Image")
                    {
                        
                        LinkDownloadSingleData = media.Value[0].Images[0].Uri.ToString();
                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "This page has a slide (one Image)"));
                        txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                        btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                        btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                        txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                        lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.DarkGreen));
                        lblStatus.Invoke(new Action(() => lblStatus.Text = "Checking URL Complete"));
                        
                    }


                    //get as property multi display picture and Video
                    else if (media.Value[0].MediaType.ToString() == "Carousel")
                    {
                        
                        

                        for (int i = 0; i < media.Value[0].Carousel.Count; i++)
                        {


                            if (media.Value[0].Carousel[i].MediaType.ToString() == "Image")
                            {

                                ListDownload.Add(media.Value[0].Carousel[i].Images[0].Uri.ToString());
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Image )")));

                            }
                            else
                            {
                                ListDownload.Add(media.Value[0].Carousel[i].Videos[i].Uri.ToString());
                                comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Video )")));

                            }

                            comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Text = "The Pages added"));
                            txtSaveLocation.Invoke(new Action(() => txtSaveLocation.Enabled = true));
                            comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Enabled = true));
                            btnBrowse.Invoke(new Action(() => btnBrowse.Enabled = true));
                            btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                            txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                            lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.DarkGreen));
                            lblStatus.Invoke(new Action(() => lblStatus.Text = "Checking URL Complete"));


                        }








                    }
                }
                catch
                {
                    string errortypechoice = "Invalid URL";
                    lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.Red));
                    lblStatus.Invoke(new Action(() => lblStatus.Text = "Stop"));
                    labelPerc.Invoke(new Action(() => labelPerc.Text = "0" + "%"));
                    txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                    btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                    MessageBox.Show(errortypechoice, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                lblStatus.Invoke(new Action(() => lblStatus.ForeColor = Color.Red));
                lblStatus.Invoke(new Action(() => lblStatus.Text = "Stop"));
                labelPerc.Invoke(new Action(() => labelPerc.Text = "0" + "%"));
                txtUrl.Invoke(new Action(() => txtUrl.Enabled = true));
                btnCheck.Invoke(new Action(() => btnCheck.Enabled = true));
                MessageBox.Show("can not connect in the server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }





        }

        public async void loginInsta()
        {
            var userSession = new UserSessionData
            {
                UserName = UsernameText.Text,
                Password = PasswordText.Text,
            };
            InstaApi = InstaApiBuilder.CreateBuilder()
                .SetUser(userSession)
                .UseLogger(new DebugLogger(LogLevel.All))
                .Build();
            var loginResult = await InstaApi.LoginAsync();
            if (loginResult.Succeeded == true)
            {
                loginStatus.Text = "Succeess";
            }

        }
       


        #endregion

        #endregion


        
    }
    
}

