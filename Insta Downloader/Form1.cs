using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using System.Diagnostics;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using InstagramApiSharp.API;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Insta_Downloader
{
    public partial class Form1 : Form
    {

        #region Fields

        WebClient webClient = new WebClient();
        Stopwatch stopWatch = new Stopwatch();
        LoginChallengeRequied loginChallengeRequied = new LoginChallengeRequied();
        static string URL;
        string LinkDownloadSingleData;
        List<string> ListDownload = new List<string>();
        private string startupPath2 = Application.StartupPath;
        Thread thread;
        public static IInstaApi InstaApi;
        private string URLDownload;

        #endregion

        #region Constractor

        public Form1()
        {
            InitializeComponent();
            rememberLogin();
        }

        #endregion

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

        //Button Logout Click Event
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            File.Delete(startupPath2 + "//user.txt");
            File.Delete(startupPath2 + "//pass.txt");
            btnLogout.Enabled = false;
            loginStatus.Text = "Logout Successfuly";
        }

        //Button Help Click Event
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        //Button Login Click Event
        private void button1_Click_1(object sender, EventArgs e)
        {

            loginInsta();

        }

        //Picture box Insta Click Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://instagram.com");

        }

        //Picture box More Click Event
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            About more = new About();
            more.Show();
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
                    progressBar1.Value = 0;
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

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                // Calculate download speed and output it to labelSpeed.
                labelSpeed.Text = string.Format($"{(e.BytesReceived / 1024d / stopWatch.Elapsed.TotalSeconds).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)} Kb/s");
                
                // Update the progressbar percentage only when the value is not the same.
                progressBar1.Value = e.ProgressPercentage;

                // Show the percentage on our label.
                labelPerc.Text = e.ProgressPercentage.ToString() + " %";

                // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
                labelDownloaded.Text = string.Format($"{ (e.BytesReceived / 1024d / 1024d).ToString("0.00")} MB / {(e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00")} MB");
            });

        }

        #endregion

        #region Download File Completed Event

        // Download File Completed Event
        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            stopWatch.Reset();

            if (e.Cancelled == false)
            {
                DownloadCompletedDesign();
            }
            
        }

        #endregion

        #endregion

        #region Methods

        private void StartDownload()
        {

            //check the type of data and pass link download to downloader method
            if (!string.IsNullOrEmpty(LinkDownloadSingleData))
            {
                URLDownload = LinkDownloadSingleData;
                Task.Run(DownloaderMethod);
                btnStart.Text = "Stop Download";
                btnStart.BackColor = Color.Red;
            }
            else
            {
                URLDownload = ListDownload[comboboxLinkDownload.SelectedIndex];
                Task.Run(DownloaderMethod);
                btnStart.Text = "Stop Download";
                btnStart.BackColor = Color.Red;

            }

        }

        private void StopDownload()
        {
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
            }

            StopDownladDesign();
        }

        public void DownloaderMethod()
        {
            try
            {

                DownloadingDesign();

                // Start the stopwatch which we will be using to calculate the download speed
                stopWatch.Start();

                Uri InformationURI = new Uri(URLDownload);
                webClient.DownloadFileAsync(InformationURI, txtSaveLocation.Text);

            }
            catch
            {
                MessageBox.Show("Connection Lost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                thread = new Thread(GetInfo);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Invalid URL", "URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public async void GetInfo()
        {
            CheckingURLDesign();
            LinkDownloadSingleData = String.Empty;
            ListDownload.Clear();

            //try to connect and get information from the url
            try
            {
                if (loginStatus.Text == "Succeess")
                {
                    //detail of design
                    URL = txtUrl.Text;
                    
                    //set URLdownload to combo box link download
                    try
                    {
                        Uri uri = new Uri(URL);
                        var mediaid = await InstaApi.MediaProcessor.GetMediaIdFromUrlAsync(uri);
                        var media = await InstaApi.MediaProcessor.GetMediaByIdsAsync(mediaid.Value);
                        string mediatype = media.Value[0].MediaType.ToString();
                        
                        //get link download as property IGTV

                        if (media.Value[0].ProductType == "igtv")
                        {
                            LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                            CheckingURLCompleteDesign("This page has a slide (IGTV)");
                        }

                        switch (mediatype)
                        {
                            case "Video":
                                LinkDownloadSingleData = media.Value[0].Videos[0].Uri.ToString();
                                CheckingURLCompleteDesign("This page has a slide (One Video)");
                                break;

                            case "Image":
                                LinkDownloadSingleData = media.Value[0].Images[0].Uri.ToString();
                                CheckingURLCompleteDesign("This page has a slide (one Image)");
                                break;

                            case "Carousel":

                                for (int i = 0; i < media.Value[0].Carousel.Count; i++)
                                {

                                    if (media.Value[0].Carousel[i].MediaType.ToString() == "Image")
                                    {

                                        ListDownload.Add(media.Value[0].Carousel[i].Images[0].Uri.ToString());
                                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Image )")));

                                    }
                                    else
                                    {
                                        ListDownload.Add(media.Value[0].Carousel[i].Videos[0].Uri.ToString());
                                        comboboxLinkDownload.Invoke(new Action(() => comboboxLinkDownload.Items.Add("Slide " + (i + 1) + " ( Video )")));

                                    }
                                    
                                }
                                CheckingURLCompleteDesign("The Pages added");
                                break;
                        }

                        
                        
                    }
                    catch
                    {
                        InvalidURLDesign();
                        MessageBox.Show("Invalid URL", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please login first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("can not connect in the server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public async void loginInsta()
        {
            try
            {
                if (File.Exists(startupPath2 + "//user.txt") == true && File.Exists(startupPath2 + "//pass.txt") == true)
                {
                    File.Delete(startupPath2 + "//user.txt");
                    File.Delete(startupPath2 + "//pass.txt");
                    loginStatus.Text = "Logging...";
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
                        if (checkBoxRemember.Checked == true)
                        {
                            File.WriteAllText(startupPath2 + "//user.txt", UsernameText.Text);
                            File.WriteAllText(startupPath2 + "//pass.txt", PasswordText.Text);
                            loginStatus.ForeColor = Color.DarkGreen;
                            btnLogout.Enabled = true;
                            loginStatus.Text = "Succeess";
                        }
                        else
                        {
                            loginStatus.ForeColor = Color.DarkGreen;
                            btnLogout.Enabled = true;
                            loginStatus.Text = "Succeess";
                        }

                    }
                    else if (loginResult.Value.ToString() == "ChallengeRequired")
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Challenge Required";
                        loginChallengeRequied.ShowDialog();



                    }
                    else
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Invalid User";
                    }
                }
                else
                {
                    loginStatus.Text = "Logging...";
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
                        if (checkBoxRemember.Checked == true)
                        {
                            File.WriteAllText(startupPath2 + "//user.txt", UsernameText.Text);
                            File.WriteAllText(startupPath2 + "//pass.txt", PasswordText.Text);
                            loginStatus.ForeColor = Color.DarkGreen;
                            btnLogout.Enabled = true;
                            loginStatus.Text = "Succeess";
                        }
                        else
                        {
                            loginStatus.ForeColor = Color.DarkGreen;
                            btnLogout.Enabled = true;
                            loginStatus.Text = "Succeess";
                        }

                    }
                    else if (loginResult.Value.ToString() == "ChallengeRequired")
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Challenge Required";
                        loginChallengeRequied.ShowDialog();



                    }
                    else
                    {
                        loginStatus.ForeColor = Color.Red;
                        loginStatus.Text = "Invalid User";
                    }
                }


            }
            catch
            {
                loginStatus.ForeColor = Color.Red;
                loginStatus.Text = "Connection Faild";
            }

        }

        public async void rememberLogin()
        {
            try
            {
                
                if (File.Exists(startupPath2 + "//user.txt") == true && File.Exists(startupPath2 + "//pass.txt") == true)
                {
                    loginStatus.Text = "Logging...";
                    var userSession = new UserSessionData
                    {
                        UserName = File.ReadAllText(startupPath2 + "//user.txt"),
                        Password = File.ReadAllText(startupPath2 + "//pass.txt"),
                    };
                    InstaApi = InstaApiBuilder.CreateBuilder()
                        .SetUser(userSession)
                        .UseLogger(new DebugLogger(LogLevel.All))
                        .Build();

                    var loginResult = await InstaApi.LoginAsync();

                    if (loginResult.Succeeded == true)
                    {
                        loginStatus.ForeColor = Color.DarkGreen;
                        btnLogout.Enabled = true;
                        loginStatus.Text = "Succeess";
                    }
                    else if (loginResult.Value.ToString() == "ChallengeRequired")
                    {

                        MessageBox.Show("ChallengeRequired please try to login again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        File.Delete(startupPath2 + "//user.txt");
                        File.Delete(startupPath2 + "//pass.txt");
                        btnLogout.Enabled = false;
                        loginStatus.Text = "Not Login";
                        loginChallengeRequied.ShowDialog();

                    }
                    else if (loginResult.Value.ToString() == "Invalid User")
                    {

                        File.Delete(startupPath2 + "//user.txt");
                        File.Delete(startupPath2 + "//pass.txt");
                        MessageBox.Show("Invalid User please try to login again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnLogout.Enabled = false;
                        loginStatus.Text = "Not Login";

                    }


                }

                else
                {
                    loginStatus.Text = "Not Login";
                    btnLogout.Enabled = false;
                }
            }
            catch
            {
                loginStatus.ForeColor = Color.Red;
                loginStatus.Text = "Connection Faild";
            }
        }



        #endregion

        
        //private async void SendCodeButton_Click(object sender, EventArgs e)
        //{
        //    bool isEmail = RadioVerifyWithEmail.Checked;

        //    try
        //    {

        //        if (isEmail)
        //        {

        //            var email = await InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
        //            if (email.Succeeded)
        //            {
        //                VerifyCodeGroupBox.Visible = true;
        //                SelectMethodGroupBox.Visible = false;
        //            }
        //            else
        //                MessageBox.Show(email.Info.Message, "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //        {
        //            var phoneNumber = await InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync();
        //            if (phoneNumber.Succeeded)
        //            {
        //                VerifyCodeGroupBox.Visible = true;
        //                SelectMethodGroupBox.Visible = false;
        //            }
        //            else
        //                MessageBox.Show(phoneNumber.Info.Message, "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //}

        //private async void VerifyButton_Click(object sender, EventArgs e)
        //{
        //    txtVerifyCode.Text = txtVerifyCode.Text.Trim();
        //    txtVerifyCode.Text = txtVerifyCode.Text.Replace(" ", "");
        //    var regex = new Regex(@"^-*[0-9,\.]+$");
        //    if (!regex.IsMatch(txtVerifyCode.Text))
        //    {
        //        MessageBox.Show("Verification code is numeric!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    if (txtVerifyCode.Text.Length != 6)
        //    {
        //        MessageBox.Show("Verification code must be 6 digits!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    try
        //    {
        //        // Note: calling VerifyCodeForChallengeRequireAsync function, 
        //        // if user has two factor enabled, will wait 15 seconds and it will try to
        //        // call LoginAsync.

        //        var verifyLogin = await InstaApi.VerifyCodeForChallengeRequireAsync(txtVerifyCode.Text);
        //        if (verifyLogin.Succeeded)
        //        {
        //            // you are logged in sucessfully.
        //            VerifyCodeGroupBox.Visible = SelectMethodGroupBox.Visible = false;
        //            // Size = challengereq;
        //            //  GetFeedButton.Visible = true;
        //            // Save session
        //            //SaveSession();
        //            //Text = $"{AppName} Connected";
        //            MessageBox.Show("challenge passed", "status");
        //        }
        //        else
        //        {
        //            VerifyCodeGroupBox.Visible = SelectMethodGroupBox.Visible = false;
        //            // two factor is required
        //            if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
        //            {
        //                MessageBox.Show("two factor req", "status");
        //            }
        //            else
        //                MessageBox.Show(verifyLogin.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }
        //    catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        //}

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
        private void tab_page1(object sender, EventArgs e)
        {
            MessageBox.Show("ddd");
            this.Size = new Size(200, 300);
        }

    }

}

