namespace SeleniumFF_Nano
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
            this.btnClaimAndContinue = new System.Windows.Forms.Button();
            this.btnCheckBoxCaptcha = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEarn = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClaimAndContinue
            // 
            this.btnClaimAndContinue.Location = new System.Drawing.Point(579, 38);
            this.btnClaimAndContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnClaimAndContinue.Name = "btnClaimAndContinue";
            this.btnClaimAndContinue.Size = new System.Drawing.Size(132, 28);
            this.btnClaimAndContinue.TabIndex = 11;
            this.btnClaimAndContinue.Text = "ClaimAndContinue";
            this.btnClaimAndContinue.UseVisualStyleBackColor = true;
            this.btnClaimAndContinue.Click += new System.EventHandler(this.btnClaimAndContinue_Click);
            // 
            // btnCheckBoxCaptcha
            // 
            this.btnCheckBoxCaptcha.Location = new System.Drawing.Point(449, 38);
            this.btnCheckBoxCaptcha.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckBoxCaptcha.Name = "btnCheckBoxCaptcha";
            this.btnCheckBoxCaptcha.Size = new System.Drawing.Size(110, 28);
            this.btnCheckBoxCaptcha.TabIndex = 10;
            this.btnCheckBoxCaptcha.Text = "CheckCaptcha";
            this.btnCheckBoxCaptcha.UseVisualStyleBackColor = true;
            this.btnCheckBoxCaptcha.Click += new System.EventHandler(this.btnCheckBoxCaptcha_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(306, 38);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEarn
            // 
            this.btnEarn.Location = new System.Drawing.Point(162, 38);
            this.btnEarn.Margin = new System.Windows.Forms.Padding(4);
            this.btnEarn.Name = "btnEarn";
            this.btnEarn.Size = new System.Drawing.Size(100, 28);
            this.btnEarn.TabIndex = 8;
            this.btnEarn.Text = "Earn";
            this.btnEarn.UseVisualStyleBackColor = true;
            this.btnEarn.Click += new System.EventHandler(this.btnEarn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(25, 38);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 176);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 404);
            this.Controls.Add(this.btnClaimAndContinue);
            this.Controls.Add(this.btnCheckBoxCaptcha);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnEarn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClaimAndContinue;
        private System.Windows.Forms.Button btnCheckBoxCaptcha;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEarn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
    }
}

