
namespace Insta_Downloader
{
    partial class LoginChallengeRequied
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
            this.SelectMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioVerifyWithPhoneNumber = new System.Windows.Forms.RadioButton();
            this.RadioVerifyWithEmail = new System.Windows.Forms.RadioButton();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.VerifyCodeGroupBox = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.txtVerifyCode = new System.Windows.Forms.TextBox();
            this.SelectMethodGroupBox.SuspendLayout();
            this.VerifyCodeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectMethodGroupBox
            // 
            this.SelectMethodGroupBox.Controls.Add(this.RadioVerifyWithPhoneNumber);
            this.SelectMethodGroupBox.Controls.Add(this.RadioVerifyWithEmail);
            this.SelectMethodGroupBox.Controls.Add(this.SendCodeButton);
            this.SelectMethodGroupBox.Location = new System.Drawing.Point(12, 9);
            this.SelectMethodGroupBox.Name = "SelectMethodGroupBox";
            this.SelectMethodGroupBox.Size = new System.Drawing.Size(204, 100);
            this.SelectMethodGroupBox.TabIndex = 46;
            this.SelectMethodGroupBox.TabStop = false;
            this.SelectMethodGroupBox.Text = "Method";
            // 
            // RadioVerifyWithPhoneNumber
            // 
            this.RadioVerifyWithPhoneNumber.AutoSize = true;
            this.RadioVerifyWithPhoneNumber.Location = new System.Drawing.Point(6, 19);
            this.RadioVerifyWithPhoneNumber.Name = "RadioVerifyWithPhoneNumber";
            this.RadioVerifyWithPhoneNumber.Size = new System.Drawing.Size(55, 17);
            this.RadioVerifyWithPhoneNumber.TabIndex = 46;
            this.RadioVerifyWithPhoneNumber.TabStop = true;
            this.RadioVerifyWithPhoneNumber.Text = "phone";
            this.RadioVerifyWithPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // RadioVerifyWithEmail
            // 
            this.RadioVerifyWithEmail.AutoSize = true;
            this.RadioVerifyWithEmail.Location = new System.Drawing.Point(7, 45);
            this.RadioVerifyWithEmail.Name = "RadioVerifyWithEmail";
            this.RadioVerifyWithEmail.Size = new System.Drawing.Size(49, 17);
            this.RadioVerifyWithEmail.TabIndex = 45;
            this.RadioVerifyWithEmail.TabStop = true;
            this.RadioVerifyWithEmail.Text = "email";
            this.RadioVerifyWithEmail.UseVisualStyleBackColor = true;
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SendCodeButton.Location = new System.Drawing.Point(6, 65);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(192, 30);
            this.SendCodeButton.TabIndex = 44;
            this.SendCodeButton.Text = "send";
            this.SendCodeButton.UseVisualStyleBackColor = true;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // VerifyCodeGroupBox
            // 
            this.VerifyCodeGroupBox.Controls.Add(this.label13);
            this.VerifyCodeGroupBox.Controls.Add(this.VerifyButton);
            this.VerifyCodeGroupBox.Controls.Add(this.txtVerifyCode);
            this.VerifyCodeGroupBox.Location = new System.Drawing.Point(235, 9);
            this.VerifyCodeGroupBox.Name = "VerifyCodeGroupBox";
            this.VerifyCodeGroupBox.Size = new System.Drawing.Size(204, 100);
            this.VerifyCodeGroupBox.TabIndex = 45;
            this.VerifyCodeGroupBox.TabStop = false;
            this.VerifyCodeGroupBox.Text = "Code";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "Code:";
            // 
            // VerifyButton
            // 
            this.VerifyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VerifyButton.Location = new System.Drawing.Point(6, 63);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(192, 31);
            this.VerifyButton.TabIndex = 40;
            this.VerifyButton.Text = "verify code";
            this.VerifyButton.UseVisualStyleBackColor = true;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // txtVerifyCode
            // 
            this.txtVerifyCode.Location = new System.Drawing.Point(51, 25);
            this.txtVerifyCode.Multiline = true;
            this.txtVerifyCode.Name = "txtVerifyCode";
            this.txtVerifyCode.PasswordChar = '*';
            this.txtVerifyCode.Size = new System.Drawing.Size(147, 27);
            this.txtVerifyCode.TabIndex = 41;
            // 
            // LoginChallengeRequied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 120);
            this.Controls.Add(this.SelectMethodGroupBox);
            this.Controls.Add(this.VerifyCodeGroupBox);
            this.Name = "LoginChallengeRequied";
            this.Text = "LoginChallengeRequied";
            this.SelectMethodGroupBox.ResumeLayout(false);
            this.SelectMethodGroupBox.PerformLayout();
            this.VerifyCodeGroupBox.ResumeLayout(false);
            this.VerifyCodeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectMethodGroupBox;
        private System.Windows.Forms.RadioButton RadioVerifyWithPhoneNumber;
        private System.Windows.Forms.RadioButton RadioVerifyWithEmail;
        private System.Windows.Forms.Button SendCodeButton;
        private System.Windows.Forms.GroupBox VerifyCodeGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button VerifyButton;
        private System.Windows.Forms.TextBox txtVerifyCode;
    }
}