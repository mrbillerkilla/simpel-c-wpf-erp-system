using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace p1c_fk
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
            this.loginEmail = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rolgegevens = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginEmail
            // 
            this.loginEmail.Location = new System.Drawing.Point(12, 44);
            this.loginEmail.Name = "loginEmail";
            this.loginEmail.Size = new System.Drawing.Size(148, 22);
            this.loginEmail.TabIndex = 0;
            // 
            // loginPassword
            // 
            this.loginPassword.Location = new System.Drawing.Point(12, 72);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.Size = new System.Drawing.Size(148, 22);
            this.loginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "inloggen";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(41, 100);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "log in";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "inlog gegevens";
            // 
            // rolgegevens
            // 
            this.rolgegevens.Location = new System.Drawing.Point(166, 28);
            this.rolgegevens.Multiline = true;
            this.rolgegevens.Name = "rolgegevens";
            this.rolgegevens.ReadOnly = true;
            this.rolgegevens.Size = new System.Drawing.Size(627, 225);
            this.rolgegevens.TabIndex = 6;
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(41, 153);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(99, 23);
            this.regButton.TabIndex = 7;
            this.regButton.Text = "regristratie";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.rolgegevens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginEmail;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit;
        private Label label2;
        private TextBox rolgegevens;
        private Button regButton;
    }
}

