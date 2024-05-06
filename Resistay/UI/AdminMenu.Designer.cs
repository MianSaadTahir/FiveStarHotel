namespace Resistay.UI
{
    partial class AdminMenu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ResuistayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.addrtbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Removalrtbtn = new Guna.UI2.WinForms.Guna2Button();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RukesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Roombtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResuistayLabel
            // 
            this.ResuistayLabel.AutoSize = true;
            this.ResuistayLabel.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold);
            this.ResuistayLabel.ForeColor = System.Drawing.Color.Black;
            this.ResuistayLabel.Location = new System.Drawing.Point(867, 73);
            this.ResuistayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResuistayLabel.Name = "ResuistayLabel";
            this.ResuistayLabel.Size = new System.Drawing.Size(574, 71);
            this.ResuistayLabel.TabIndex = 2;
            this.ResuistayLabel.Text = "FIVE STAR HOSTEL";
            this.ResuistayLabel.Click += new System.EventHandler(this.ResuistayLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Navigator Bar";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfileLabel.Location = new System.Drawing.Point(30, 129);
            this.ProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(0, 29);
            this.ProfileLabel.TabIndex = 45;
            this.ProfileLabel.Click += new System.EventHandler(this.ProfileLabel_Click);
            // 
            // addrtbtn
            // 
            this.addrtbtn.BackColor = System.Drawing.Color.Silver;
            this.addrtbtn.BorderRadius = 26;
            this.addrtbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addrtbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.addrtbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addrtbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addrtbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addrtbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addrtbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addrtbtn.FillColor = System.Drawing.Color.Silver;
            this.addrtbtn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrtbtn.ForeColor = System.Drawing.Color.Black;
            this.addrtbtn.Image = global::Resistay.Properties.Resources.new_student;
            this.addrtbtn.Location = new System.Drawing.Point(55, 564);
            this.addrtbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addrtbtn.Name = "addrtbtn";
            this.addrtbtn.Size = new System.Drawing.Size(239, 65);
            this.addrtbtn.TabIndex = 14;
            this.addrtbtn.Text = "Add Resident Tutor";
            this.addrtbtn.Click += new System.EventHandler(this.addrtbtn_Click);
            // 
            // Removalrtbtn
            // 
            this.Removalrtbtn.BackColor = System.Drawing.Color.Silver;
            this.Removalrtbtn.BorderRadius = 26;
            this.Removalrtbtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Removalrtbtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Removalrtbtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Removalrtbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Removalrtbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Removalrtbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Removalrtbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Removalrtbtn.FillColor = System.Drawing.Color.Silver;
            this.Removalrtbtn.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removalrtbtn.ForeColor = System.Drawing.Color.Black;
            this.Removalrtbtn.Image = global::Resistay.Properties.Resources.new_student;
            this.Removalrtbtn.Location = new System.Drawing.Point(55, 683);
            this.Removalrtbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Removalrtbtn.Name = "Removalrtbtn";
            this.Removalrtbtn.Size = new System.Drawing.Size(239, 65);
            this.Removalrtbtn.TabIndex = 13;
            this.Removalrtbtn.Text = "Remove Rt or Student ";
            this.Removalrtbtn.Click += new System.EventHandler(this.Removalrtbtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Silver;
            this.LogOutBtn.BorderRadius = 26;
            this.LogOutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.LogOutBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.LogOutBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogOutBtn.FillColor = System.Drawing.Color.Silver;
            this.LogOutBtn.Font = new System.Drawing.Font("Stencil", 11F);
            this.LogOutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogOutBtn.Image = global::Resistay.Properties.Resources.logout;
            this.LogOutBtn.Location = new System.Drawing.Point(55, 920);
            this.LogOutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(239, 62);
            this.LogOutBtn.TabIndex = 12;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // RukesBtn
            // 
            this.RukesBtn.BackColor = System.Drawing.Color.Silver;
            this.RukesBtn.BorderRadius = 26;
            this.RukesBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.RukesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.RukesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RukesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RukesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RukesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RukesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RukesBtn.FillColor = System.Drawing.Color.Silver;
            this.RukesBtn.Font = new System.Drawing.Font("Stencil", 11F);
            this.RukesBtn.ForeColor = System.Drawing.Color.Black;
            this.RukesBtn.Image = global::Resistay.Properties.Resources.rules_removebg_preview;
            this.RukesBtn.Location = new System.Drawing.Point(55, 804);
            this.RukesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RukesBtn.Name = "RukesBtn";
            this.RukesBtn.Size = new System.Drawing.Size(239, 62);
            this.RukesBtn.TabIndex = 11;
            this.RukesBtn.Text = "Rules";
            this.RukesBtn.Click += new System.EventHandler(this.RukesBtn_Click);
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
            this.ExitBtn.Location = new System.Drawing.Point(1980, 29);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.PressedDepth = 20;
            this.ExitBtn.Size = new System.Drawing.Size(50, 62);
            this.ExitBtn.TabIndex = 9;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.BackColor = System.Drawing.Color.Silver;
            this.StudentsBtn.BorderRadius = 26;
            this.StudentsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.StudentsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.StudentsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.StudentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentsBtn.FillColor = System.Drawing.Color.Silver;
            this.StudentsBtn.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsBtn.ForeColor = System.Drawing.Color.Black;
            this.StudentsBtn.Image = global::Resistay.Properties.Resources.new_student;
            this.StudentsBtn.Location = new System.Drawing.Point(55, 205);
            this.StudentsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(239, 65);
            this.StudentsBtn.TabIndex = 8;
            this.StudentsBtn.Text = "Allot Students";
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // HostelBtn
            // 
            this.HostelBtn.BackColor = System.Drawing.Color.Silver;
            this.HostelBtn.BorderRadius = 26;
            this.HostelBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HostelBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.HostelBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HostelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HostelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HostelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HostelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HostelBtn.FillColor = System.Drawing.Color.Silver;
            this.HostelBtn.Font = new System.Drawing.Font("Stencil", 11F);
            this.HostelBtn.ForeColor = System.Drawing.Color.Black;
            this.HostelBtn.Image = global::Resistay.Properties.Resources.all_student_living1;
            this.HostelBtn.Location = new System.Drawing.Point(55, 443);
            this.HostelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelBtn.Name = "HostelBtn";
            this.HostelBtn.Size = new System.Drawing.Size(239, 62);
            this.HostelBtn.TabIndex = 7;
            this.HostelBtn.Text = "Manage Hostels";
            this.HostelBtn.Click += new System.EventHandler(this.HostelBtn_Click);
            // 
            // Roombtn
            // 
            this.Roombtn.BackColor = System.Drawing.Color.Silver;
            this.Roombtn.BorderRadius = 26;
            this.Roombtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Roombtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Roombtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Roombtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Roombtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Roombtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Roombtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Roombtn.FillColor = System.Drawing.Color.Silver;
            this.Roombtn.Font = new System.Drawing.Font("Stencil", 11F);
            this.Roombtn.ForeColor = System.Drawing.Color.Black;
            this.Roombtn.Image = global::Resistay.Properties.Resources.room;
            this.Roombtn.Location = new System.Drawing.Point(55, 327);
            this.Roombtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Roombtn.Name = "Roombtn";
            this.Roombtn.Size = new System.Drawing.Size(239, 62);
            this.Roombtn.TabIndex = 3;
            this.Roombtn.Text = "Manage Rooms";
            this.Roombtn.Click += new System.EventHandler(this.Roombtn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2PictureBox1.BorderRadius = 30;
            this.guna2PictureBox1.Image = global::Resistay.Properties.Resources.download;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(377, 205);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1626, 986);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.addrtbtn);
            this.Controls.Add(this.Removalrtbtn);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.RukesBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StudentsBtn);
            this.Controls.Add(this.HostelBtn);
            this.Controls.Add(this.Roombtn);
            this.Controls.Add(this.ResuistayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Roombtn;
        private Guna.UI2.WinForms.Guna2Button HostelBtn;
        private Guna.UI2.WinForms.Guna2Button StudentsBtn;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button RukesBtn;
        private Guna.UI2.WinForms.Guna2Button LogOutBtn;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private System.Windows.Forms.Label ResuistayLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Removalrtbtn;
        private Guna.UI2.WinForms.Guna2Button addrtbtn;
        private System.Windows.Forms.Label ProfileLabel;
    }
}