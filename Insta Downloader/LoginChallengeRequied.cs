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
    public partial class LoginChallengeRequied : Form
    {
        

        public LoginChallengeRequied()
        {
            InitializeComponent();
        }

        private async void SendCodeButton_Click(object sender, EventArgs e)
        {
            bool isEmail = RadioVerifyWithEmail.Checked;

            try
            {

                if (isEmail)
                {

                    var email = await Form1.InstaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
                    if (email.Succeeded)
                    {
                        VerifyCodeGroupBox.Visible = true;
                        SelectMethodGroupBox.Visible = false;
                    }
                    else
                        MessageBox.Show(email.Info.Message, "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var phoneNumber = await Form1.InstaApi.RequestVerifyCodeToSMSForChallengeRequireAsync();
                    if (phoneNumber.Succeeded)
                    {
                        VerifyCodeGroupBox.Visible = true;
                        SelectMethodGroupBox.Visible = false;
                    }
                    else
                        MessageBox.Show(phoneNumber.Info.Message, "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void VerifyButton_Click(object sender, EventArgs e)
        {
            txtVerifyCode.Text = txtVerifyCode.Text.Trim();
            txtVerifyCode.Text = txtVerifyCode.Text.Replace(" ", "");
            var regex = new Regex(@"^-*[0-9,\.]+$");
            if (!regex.IsMatch(txtVerifyCode.Text))
            {
                MessageBox.Show("Verification code is numeric!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtVerifyCode.Text.Length != 6)
            {
                MessageBox.Show("Verification code must be 6 digits!!!", "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Note: calling VerifyCodeForChallengeRequireAsync function, 
                // if user has two factor enabled, will wait 15 seconds and it will try to
                // call LoginAsync.

                var verifyLogin = await Form1.InstaApi.VerifyCodeForChallengeRequireAsync(txtVerifyCode.Text);
                if (verifyLogin.Succeeded)
                {
                    // you are logged in sucessfully.
                    VerifyCodeGroupBox.Visible = SelectMethodGroupBox.Visible = false;
                    // Size = challengereq;
                    //  GetFeedButton.Visible = true;
                    // Save session
                    //SaveSession();
                    //Text = $"{AppName} Connected";
                    MessageBox.Show("challenge passed", "status");
                }
                else
                {
                    VerifyCodeGroupBox.Visible = SelectMethodGroupBox.Visible = false;
                    // two factor is required
                    if (verifyLogin.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        MessageBox.Show("two factor req", "status");
                    }
                    else
                        MessageBox.Show(verifyLogin.Info.Message, "ERR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "EX", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
