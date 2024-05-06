namespace Resistay.UI
{
    partial class StudentMenu
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
            this.components = new System.ComponentModel.Container();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ResuistayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePassword = new Guna.UI2.WinForms.Guna2Button();
            this.leaveroombtn = new Guna.UI2.WinForms.Guna2Button();
            this.feesbtn = new Guna.UI2.WinForms.Guna2Button();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RulesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ComplainsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabel.Location = new System.Drawing.Point(46, 132);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(0, 29);
            this.ProfileLabel.TabIndex = 59;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(926, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 51);
            this.label2.TabIndex = 58;
            this.label2.Text = " ";
            // 
            // ResuistayLabel
            // 
            this.ResuistayLabel.AutoSize = true;
            this.ResuistayLabel.Font = new System.Drawing.Font("Stencil", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResuistayLabel.ForeColor = System.Drawing.Color.Black;
            this.ResuistayLabel.Location = new System.Drawing.Point(854, 65);
            this.ResuistayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResuistayLabel.Name = "ResuistayLabel";
            this.ResuistayLabel.Size = new System.Drawing.Size(554, 67);
            this.ResuistayLabel.TabIndex = 48;
            this.ResuistayLabel.Text = "FIVESTAR HOSTELS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(85, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 47;
            this.label1.Text = "ST. MENU";
            // 
            // UpdatePassword
            // 
            this.UpdatePassword.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UpdatePassword.CheckedState.FillColor = System.Drawing.Color.White;
            this.UpdatePassword.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpdatePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdatePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdatePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdatePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdatePassword.FillColor = System.Drawing.Color.Silver;
            this.UpdatePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePassword.ForeColor = System.Drawing.Color.Black;
            this.UpdatePassword.Image = global::Resistay.Properties.Resources.new_student;
            this.UpdatePassword.Location = new System.Drawing.Point(51, 805);
            this.UpdatePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdatePassword.Name = "UpdatePassword";
            this.UpdatePassword.Size = new System.Drawing.Size(248, 62);
            this.UpdatePassword.TabIndex = 61;
            this.UpdatePassword.Text = "Change Password";
            this.UpdatePassword.Click += new System.EventHandler(this.UpdatePassword_Click);
            // 
            // leaveroombtn
            // 
            this.leaveroombtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.leaveroombtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.leaveroombtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.leaveroombtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.leaveroombtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.leaveroombtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.leaveroombtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.leaveroombtn.FillColor = System.Drawing.Color.Silver;
            this.leaveroombtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveroombtn.ForeColor = System.Drawing.Color.Black;
            this.leaveroombtn.Image = global::Resistay.Properties.Resources.logout;
            this.leaveroombtn.Location = new System.Drawing.Point(53, 598);
            this.leaveroombtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leaveroombtn.Name = "leaveroombtn";
            this.leaveroombtn.Size = new System.Drawing.Size(248, 65);
            this.leaveroombtn.TabIndex = 60;
            this.leaveroombtn.Text = "Leave Room";
            this.leaveroombtn.Click += new System.EventHandler(this.leaveroombtn_Click);
            // 
            // feesbtn
            // 
            this.feesbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.feesbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.feesbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.feesbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.feesbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.feesbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.feesbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.feesbtn.FillColor = System.Drawing.Color.Silver;
            this.feesbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesbtn.ForeColor = System.Drawing.Color.Black;
            this.feesbtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.feesbtn.Location = new System.Drawing.Point(51, 488);
            this.feesbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.feesbtn.Name = "feesbtn";
            this.feesbtn.Size = new System.Drawing.Size(248, 65);
            this.feesbtn.TabIndex = 57;
            this.feesbtn.Text = "Submit Fees";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LogOutBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.LogOutBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.FillColor = System.Drawing.Color.Silver;
            this.LogOutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogOutBtn.Image = global::Resistay.Properties.Resources.logout;
            this.LogOutBtn.Location = new System.Drawing.Point(51, 911);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(250, 62);
            this.LogOutBtn.TabIndex = 55;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RulesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.RulesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RulesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RulesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RulesBtn.FillColor = System.Drawing.Color.Silver;
            this.RulesBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.RulesBtn.ForeColor = System.Drawing.Color.Black;
            this.RulesBtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.RulesBtn.Location = new System.Drawing.Point(51, 705);
            this.RulesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(248, 62);
            this.RulesBtn.TabIndex = 54;
            this.RulesBtn.Text = "Rules";
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // ComplainsBtn
            // 
            this.ComplainsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ComplainsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ComplainsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComplainsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ComplainsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ComplainsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ComplainsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ComplainsBtn.FillColor = System.Drawing.Color.Silver;
            this.ComplainsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ComplainsBtn.ForeColor = System.Drawing.Color.Black;
            this.ComplainsBtn.Image = global::Resistay.Properties.Resources.List_of_Paid___Dues_Students1;
            this.ComplainsBtn.Location = new System.Drawing.Point(51, 383);
            this.ComplainsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainsBtn.Name = "ComplainsBtn";
            this.ComplainsBtn.Size = new System.Drawing.Size(248, 62);
            this.ComplainsBtn.TabIndex = 53;
            this.ComplainsBtn.Text = "Complains";
            this.ComplainsBtn.Click += new System.EventHandler(this.ComplainsBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.BorderRadius = 26;
            this.ExitBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ExitBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ExitBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ExitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ExitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ExitBtn.FillColor = System.Drawing.SystemColors.Control;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Image = global::Resistay.Properties.Resources.Close_all_jframe;
            this.ExitBtn.Location = new System.Drawing.Point(1996, 32);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.PressedDepth = 20;
            this.ExitBtn.Size = new System.Drawing.Size(50, 62);
            this.ExitBtn.TabIndex = 52;
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ProfileBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.ProfileBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ProfileBtn.FillColor = System.Drawing.Color.Silver;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.ProfileBtn.Image = global::Resistay.Properties.Resources.new_student;
            this.ProfileBtn.Location = new System.Drawing.Point(51, 263);
            this.ProfileBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(248, 65);
            this.ProfileBtn.TabIndex = 51;
            this.ProfileBtn.Text = "Check Profile";
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = global::Resistay.Properties.Resources.download3;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(360, 177);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1659, 1017);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 46;
            this.guna2PictureBox1.TabStop = false;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.UpdatePassword);
            this.Controls.Add(this.leaveroombtn);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feesbtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.RulesBtn);
            this.Controls.Add(this.ComplainsBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ProfileBtn);
            this.Controls.Add(this.ResuistayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button feesbtn;
        private Guna.UI2.WinForms.Guna2Button LogOutBtn;
        private Guna.UI2.WinForms.Guna2Button RulesBtn;
        private Guna.UI2.WinForms.Guna2Button ComplainsBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button ProfileBtn;
        private System.Windows.Forms.Label ResuistayLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button leaveroombtn;
        private Guna.UI2.WinForms.Guna2Button UpdatePassword;
    }
}