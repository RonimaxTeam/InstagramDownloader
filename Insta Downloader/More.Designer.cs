
namespace Insta_Downloader
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBoxOk = new System.Windows.Forms.PictureBox();
            this.linkLabelTelegram = new System.Windows.Forms.LinkLabel();
            this.linkLabelInstagram = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOk
            // 
            this.pictureBoxOk.BackgroundImage = global::Insta_Downloader.Properties.Resources.OK_button2;
            this.pictureBoxOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOk.Location = new System.Drawing.Point(127, 449);
            this.pictureBoxOk.Name = "pictureBoxOk";
            this.pictureBoxOk.Size = new System.Drawing.Size(160, 45);
            this.pictureBoxOk.TabIndex = 0;
            this.pictureBoxOk.TabStop = false;
            this.pictureBoxOk.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxOk.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBoxOk.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // linkLabelTelegram
            // 
            this.linkLabelTelegram.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelTelegram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabelTelegram.Location = new System.Drawing.Point(91, 293);
            this.linkLabelTelegram.Name = "linkLabelTelegram";
            this.linkLabelTelegram.Size = new System.Drawing.Size(203, 25);
            this.linkLabelTelegram.TabIndex = 1;
            this.linkLabelTelegram.TabStop = true;
            this.linkLabelTelegram.Text = "https://t.me/RonimaxTeam";
            this.linkLabelTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelInstagram
            // 
            this.linkLabelInstagram.AutoSize = true;
            this.linkLabelInstagram.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelInstagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.linkLabelInstagram.Location = new System.Drawing.Point(91, 344);
            this.linkLabelInstagram.Name = "linkLabelInstagram";
            this.linkLabelInstagram.Size = new System.Drawing.Size(282, 18);
            this.linkLabelInstagram.TabIndex = 2;
            this.linkLabelInstagram.TabStop = true;
            this.linkLabelInstagram.Text = "https://www.instagram.com/ronimaxteam/";
            this.linkLabelInstagram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInstagram_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Insta_Downloader.Properties.Resources.About;
            this.ClientSize = new System.Drawing.Size(404, 501);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabelInstagram);
            this.Controls.Add(this.linkLabelTelegram);
            this.Controls.Add(this.pictureBoxOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "About";
            this.Text = "About Instagram Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOk;
        private System.Windows.Forms.LinkLabel linkLabelTelegram;
        private System.Windows.Forms.LinkLabel linkLabelInstagram;
    }
}