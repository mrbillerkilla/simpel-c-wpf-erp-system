namespace p1c_fk
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.emailtxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.voornaamTxtBox = new System.Windows.Forms.TextBox();
            this.AchternaamTxtBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.KlasTxtBox = new System.Windows.Forms.TextBox();
            this.errorTxt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.wachtwoord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "regristratie";
            // 
            // emailtxtBox
            // 
            this.emailtxtBox.Location = new System.Drawing.Point(88, 78);
            this.emailtxtBox.Multiline = true;
            this.emailtxtBox.Name = "emailtxtBox";
            this.emailtxtBox.Size = new System.Drawing.Size(138, 32);
            this.emailtxtBox.TabIndex = 1;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(88, 116);
            this.PasswordTxtBox.Multiline = true;
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(138, 25);
            this.PasswordTxtBox.TabIndex = 2;
            // 
            // voornaamTxtBox
            // 
            this.voornaamTxtBox.Location = new System.Drawing.Point(88, 147);
            this.voornaamTxtBox.Multiline = true;
            this.voornaamTxtBox.Name = "voornaamTxtBox";
            this.voornaamTxtBox.Size = new System.Drawing.Size(138, 25);
            this.voornaamTxtBox.TabIndex = 3;
            // 
            // AchternaamTxtBox
            // 
            this.AchternaamTxtBox.Location = new System.Drawing.Point(88, 178);
            this.AchternaamTxtBox.Multiline = true;
            this.AchternaamTxtBox.Name = "AchternaamTxtBox";
            this.AchternaamTxtBox.Size = new System.Drawing.Size(138, 25);
            this.AchternaamTxtBox.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(118, 240);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 5;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click_1);
            // 
            // KlasTxtBox
            // 
            this.KlasTxtBox.Location = new System.Drawing.Point(88, 209);
            this.KlasTxtBox.Multiline = true;
            this.KlasTxtBox.Name = "KlasTxtBox";
            this.KlasTxtBox.Size = new System.Drawing.Size(138, 25);
            this.KlasTxtBox.TabIndex = 6;
            // 
            // errorTxt
            // 
            this.errorTxt.Location = new System.Drawing.Point(361, 116);
            this.errorTxt.Multiline = true;
            this.errorTxt.Name = "errorTxt";
            this.errorTxt.ReadOnly = true;
            this.errorTxt.Size = new System.Drawing.Size(317, 203);
            this.errorTxt.TabIndex = 7;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(12, 81);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 16);
            this.email.TabIndex = 8;
            this.email.Text = "email";
            // 
            // wachtwoord
            // 
            this.wachtwoord.AutoSize = true;
            this.wachtwoord.Location = new System.Drawing.Point(4, 119);
            this.wachtwoord.Name = "wachtwoord";
            this.wachtwoord.Size = new System.Drawing.Size(78, 16);
            this.wachtwoord.TabIndex = 9;
            this.wachtwoord.Text = "wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "naam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "achternaam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "klas";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wachtwoord);
            this.Controls.Add(this.email);
            this.Controls.Add(this.errorTxt);
            this.Controls.Add(this.KlasTxtBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.AchternaamTxtBox);
            this.Controls.Add(this.voornaamTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.emailtxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox voornaamTxtBox;
        private System.Windows.Forms.TextBox AchternaamTxtBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox KlasTxtBox;
        private System.Windows.Forms.TextBox errorTxt;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label wachtwoord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}