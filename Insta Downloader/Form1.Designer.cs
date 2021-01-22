
namespace Insta_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDownloadSpeed = new System.Windows.Forms.Label();
            this.labelDownloadedAndTotal = new System.Windows.Forms.Label();
            this.labelDownloaded = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxInsta = new System.Windows.Forms.PictureBox();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxLinkDownload = new System.Windows.Forms.ComboBox();
            this.labelPerc = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDownloader = new System.Windows.Forms.TabPage();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.loginStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDownloader.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxInsta);
            this.panel1.Controls.Add(this.txtSaveLocation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboboxLinkDownload);
            this.panel1.Controls.Add(this.labelPerc);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Location = new System.Drawing.Point(9, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 451);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Insta_Downloader.Properties.Resources.info;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(498, 417);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 32);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter_1);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Version 1.0";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogOut.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogOut.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Location = new System.Drawing.Point(167, 355);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(357, 55);
            this.btnLogOut.TabIndex = 40;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(171, 405);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(289, 51);
            this.panel6.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Peru;
            this.label8.Location = new System.Drawing.Point(222, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Team";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(135, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ronimax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(107, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 27);
            this.label6.TabIndex = 1;
            this.label6.Text = "by";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(32, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Created";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblStatus);
            this.panel5.Location = new System.Drawing.Point(92, 104);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 26);
            this.panel5.TabIndex = 38;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(-1, -1);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(435, 26);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelSpeed);
            this.panel3.Controls.Add(this.labelDownloadSpeed);
            this.panel3.Controls.Add(this.labelDownloadedAndTotal);
            this.panel3.Controls.Add(this.labelDownloaded);
            this.panel3.Location = new System.Drawing.Point(9, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(518, 88);
            this.panel3.TabIndex = 36;
            // 
            // labelSpeed
            // 
            this.labelSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelSpeed.Font = new System.Drawing.Font("Goudy Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(134, 48);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(0, 16);
            this.labelSpeed.TabIndex = 26;
            // 
            // labelDownloadSpeed
            // 
            this.labelDownloadSpeed.AutoSize = true;
            this.labelDownloadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadSpeed.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadSpeed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDownloadSpeed.Location = new System.Drawing.Point(3, 53);
            this.labelDownloadSpeed.Name = "labelDownloadSpeed";
            this.labelDownloadSpeed.Size = new System.Drawing.Size(129, 21);
            this.labelDownloadSpeed.TabIndex = 29;
            this.labelDownloadSpeed.Text = "Download Speed :";
            // 
            // labelDownloadedAndTotal
            // 
            this.labelDownloadedAndTotal.AutoSize = true;
            this.labelDownloadedAndTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloadedAndTotal.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadedAndTotal.Location = new System.Drawing.Point(3, 18);
            this.labelDownloadedAndTotal.Name = "labelDownloadedAndTotal";
            this.labelDownloadedAndTotal.Size = new System.Drawing.Size(150, 21);
            this.labelDownloadedAndTotal.TabIndex = 28;
            this.labelDownloadedAndTotal.Text = "Downloaded / Total :";
            // 
            // labelDownloaded
            // 
            this.labelDownloaded.AutoSize = true;
            this.labelDownloaded.BackColor = System.Drawing.Color.Transparent;
            this.labelDownloaded.Font = new System.Drawing.Font("Goudy Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloaded.Location = new System.Drawing.Point(155, 20);
            this.labelDownloaded.Name = "labelDownloaded";
            this.labelDownloaded.Size = new System.Drawing.Size(0, 16);
            this.labelDownloaded.TabIndex = 27;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(167, 286);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(357, 55);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Download";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUrl.Location = new System.Drawing.Point(92, 3);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrl.Size = new System.Drawing.Size(356, 26);
            this.txtUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instagram Link";
            // 
            // pictureBoxInsta
            // 
            this.pictureBoxInsta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxInsta.BackgroundImage = global::Insta_Downloader.Properties.Resources._1024px_Instagram_icon;
            this.pictureBoxInsta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInsta.ErrorImage = null;
            this.pictureBoxInsta.Location = new System.Drawing.Point(10, 277);
            this.pictureBoxInsta.Name = "pictureBoxInsta";
            this.pictureBoxInsta.Size = new System.Drawing.Size(149, 149);
            this.pictureBoxInsta.TabIndex = 30;
            this.pictureBoxInsta.TabStop = false;
            this.pictureBoxInsta.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxInsta.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxInsta.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBoxInsta.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaveLocation.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSaveLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSaveLocation.Location = new System.Drawing.Point(92, 72);
            this.txtSaveLocation.Multiline = true;
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.Size = new System.Drawing.Size(402, 21);
            this.txtSaveLocation.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Save Location";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBrowse.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBrowse.Location = new System.Drawing.Point(500, 68);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(27, 29);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 245);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(485, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Slides";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 8.25F);
            this.label3.Location = new System.Drawing.Point(4, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status";
            // 
            // comboboxLinkDownload
            // 
            this.comboboxLinkDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxLinkDownload.BackColor = System.Drawing.Color.Gainsboro;
            this.comboboxLinkDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxLinkDownload.FormattingEnabled = true;
            this.comboboxLinkDownload.Location = new System.Drawing.Point(92, 37);
            this.comboboxLinkDownload.Name = "comboboxLinkDownload";
            this.comboboxLinkDownload.Size = new System.Drawing.Size(435, 21);
            this.comboboxLinkDownload.TabIndex = 21;
            // 
            // labelPerc
            // 
            this.labelPerc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPerc.AutoSize = true;
            this.labelPerc.BackColor = System.Drawing.Color.Transparent;
            this.labelPerc.Font = new System.Drawing.Font("Goudy Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerc.Location = new System.Drawing.Point(497, 246);
            this.labelPerc.Name = "labelPerc";
            this.labelPerc.Size = new System.Drawing.Size(0, 17);
            this.labelPerc.TabIndex = 11;
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheck.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheck.Font = new System.Drawing.Font("Footlight MT Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCheck.Location = new System.Drawing.Point(452, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 26);
            this.btnCheck.TabIndex = 20;
            this.btnCheck.Text = "Check URL";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDownloader);
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 501);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPageDownloader
            // 
            this.tabPageDownloader.Controls.Add(this.panel1);
            this.tabPageDownloader.Location = new System.Drawing.Point(4, 22);
            this.tabPageDownloader.Name = "tabPageDownloader";
            this.tabPageDownloader.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDownloader.Size = new System.Drawing.Size(551, 475);
            this.tabPageDownloader.TabIndex = 0;
            this.tabPageDownloader.Text = "Downloader";
            this.tabPageDownloader.UseVisualStyleBackColor = true;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.loginStatus);
            this.tabPageLogin.Controls.Add(this.button1);
            this.tabPageLogin.Controls.Add(this.PasswordText);
            this.tabPageLogin.Controls.Add(this.UsernameText);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(551, 475);
            this.tabPageLogin.TabIndex = 1;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            this.tabPageLogin.Click += new System.EventHandler(this.tabPageLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(218, 216);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(100, 20);
            this.PasswordText.TabIndex = 18;
            // 
            // UsernameText
            // 
            this.UsernameText.Location = new System.Drawing.Point(218, 174);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(100, 20);
            this.UsernameText.TabIndex = 17;
            // 
            // loginStatus
            // 
            this.loginStatus.AutoSize = true;
            this.loginStatus.Location = new System.Drawing.Point(54, 287);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(0, 13);
            this.loginStatus.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(571, 514);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Instagram Downloader ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInsta)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDownloader.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDownloadSpeed;
        private System.Windows.Forms.Label labelDownloadedAndTotal;
        private System.Windows.Forms.Label labelDownloaded;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxInsta;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboboxLinkDownload;
        private System.Windows.Forms.Label labelPerc;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDownloader;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.Label loginStatus;
    }
}

