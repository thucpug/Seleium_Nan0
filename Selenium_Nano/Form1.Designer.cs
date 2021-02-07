namespace Selenium_Nano
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnEarn = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCheckBoxCaptcha = new System.Windows.Forms.Button();
            this.btnClaimAndContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(23, 29);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnEarn
            // 
            this.btnEarn.Location = new System.Drawing.Point(126, 29);
            this.btnEarn.Name = "btnEarn";
            this.btnEarn.Size = new System.Drawing.Size(75, 23);
            this.btnEarn.TabIndex = 2;
            this.btnEarn.Text = "Earn";
            this.btnEarn.UseVisualStyleBackColor = true;
            this.btnEarn.Click += new System.EventHandler(this.btnEarn_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(234, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCheckBoxCaptcha
            // 
            this.btnCheckBoxCaptcha.Location = new System.Drawing.Point(341, 29);
            this.btnCheckBoxCaptcha.Name = "btnCheckBoxCaptcha";
            this.btnCheckBoxCaptcha.Size = new System.Drawing.Size(82, 23);
            this.btnCheckBoxCaptcha.TabIndex = 4;
            this.btnCheckBoxCaptcha.Text = "CheckCaptcha";
            this.btnCheckBoxCaptcha.UseVisualStyleBackColor = true;
            this.btnCheckBoxCaptcha.Click += new System.EventHandler(this.btnCheckBoxCaptcha_Click);
            // 
            // btnClaimAndContinue
            // 
            this.btnClaimAndContinue.Location = new System.Drawing.Point(439, 29);
            this.btnClaimAndContinue.Name = "btnClaimAndContinue";
            this.btnClaimAndContinue.Size = new System.Drawing.Size(99, 23);
            this.btnClaimAndContinue.TabIndex = 5;
            this.btnClaimAndContinue.Text = "ClaimAndContinue";
            this.btnClaimAndContinue.UseVisualStyleBackColor = true;
            this.btnClaimAndContinue.Click += new System.EventHandler(this.btnClaimAndContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 261);
            this.Controls.Add(this.btnClaimAndContinue);
            this.Controls.Add(this.btnCheckBoxCaptcha);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnEarn);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnEarn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCheckBoxCaptcha;
        private System.Windows.Forms.Button btnClaimAndContinue;
    }
}

