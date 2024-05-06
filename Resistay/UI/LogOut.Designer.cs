﻿namespace Resistay.UI
{
    partial class LogOut
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
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutBtn2 = new Guna.UI2.WinForms.Guna2Button();
            this.logoutlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.FillColor = System.Drawing.Color.Silver;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogOutBtn.Location = new System.Drawing.Point(316, 223);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(132, 43);
            this.LogOutBtn.TabIndex = 47;
            this.LogOutBtn.Text = "No";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // LogoutBtn2
            // 
            this.LogoutBtn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBtn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBtn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBtn2.FillColor = System.Drawing.Color.Silver;
            this.LogoutBtn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LogoutBtn2.ForeColor = System.Drawing.Color.Black;
            this.LogoutBtn2.Location = new System.Drawing.Point(68, 223);
            this.LogoutBtn2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogoutBtn2.Name = "LogoutBtn2";
            this.LogoutBtn2.Size = new System.Drawing.Size(142, 43);
            this.LogoutBtn2.TabIndex = 48;
            this.LogoutBtn2.Text = "Yes";
            this.LogoutBtn2.Click += new System.EventHandler(this.LogoutBtn2_Click);
            // 
            // logoutlabel
            // 
            this.logoutlabel.AutoSize = true;
            this.logoutlabel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutlabel.ForeColor = System.Drawing.Color.White;
            this.logoutlabel.Location = new System.Drawing.Point(97, 64);
            this.logoutlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoutlabel.Name = "logoutlabel";
            this.logoutlabel.Size = new System.Drawing.Size(322, 80);
            this.logoutlabel.TabIndex = 49;
            this.logoutlabel.Text = "Are you sure to \r\nlog out?";
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(535, 369);
            this.Controls.Add(this.logoutlabel);
            this.Controls.Add(this.LogoutBtn2);
            this.Controls.Add(this.LogOutBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V";
            this.Load += new System.EventHandler(this.LogOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LogOutBtn;
        private Guna.UI2.WinForms.Guna2Button LogoutBtn2;
        private System.Windows.Forms.Label logoutlabel;
    }
}