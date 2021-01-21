
namespace Insta_Downloader
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNext.Image = global::Insta_Downloader.Properties.Resources.Right;
            this.pictureBoxNext.Location = new System.Drawing.Point(720, 187);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(68, 67);
            this.pictureBoxNext.TabIndex = 4;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            this.pictureBoxNext.MouseEnter += new System.EventHandler(this.pictureBoxNext_MouseEnter);
            this.pictureBoxNext.MouseLeave += new System.EventHandler(this.pictureBoxNext_MouseLeave);
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPrevious.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrevious.BackgroundImage = global::Insta_Downloader.Properties.Resources.Left;
            this.pictureBoxPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPrevious.Location = new System.Drawing.Point(12, 187);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(68, 67);
            this.pictureBoxPrevious.TabIndex = 3;
            this.pictureBoxPrevious.TabStop = false;
            this.pictureBoxPrevious.Click += new System.EventHandler(this.pictureBoxPrevious_Click);
            this.pictureBoxPrevious.MouseLeave += new System.EventHandler(this.pictureBoxPrevious_MouseLeave);
            this.pictureBoxPrevious.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPrevious_MouseMove);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp.BackgroundImage")));
            this.pictureBoxHelp.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(803, 453);
            this.pictureBoxHelp.TabIndex = 2;
            this.pictureBoxHelp.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPrevious);
            this.Controls.Add(this.pictureBoxHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Instagram Downloader Helper";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HelpForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.PictureBox pictureBoxNext;
    }
}