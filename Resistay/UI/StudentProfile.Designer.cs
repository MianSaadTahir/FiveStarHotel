namespace Resistay.UI
{
    partial class StudentProfile
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
            Guna.UI2.WinForms.Guna2Button BackToMenubtn;
            this.Profile = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.studentage = new System.Windows.Forms.Label();
            this.studentcnic = new System.Windows.Forms.Label();
            this.hostell = new System.Windows.Forms.Label();
            this.roomno = new System.Windows.Forms.Label();
            this.Studentgendr = new System.Windows.Forms.Label();
            BackToMenubtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // BackToMenubtn
            // 
            BackToMenubtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BackToMenubtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BackToMenubtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            BackToMenubtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            BackToMenubtn.FillColor = System.Drawing.Color.Silver;
            BackToMenubtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            BackToMenubtn.ForeColor = System.Drawing.Color.Black;
            BackToMenubtn.Location = new System.Drawing.Point(538, 590);
            BackToMenubtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BackToMenubtn.Name = "BackToMenubtn";
            BackToMenubtn.Size = new System.Drawing.Size(165, 35);
            BackToMenubtn.TabIndex = 64;
            BackToMenubtn.Text = "Back To Menu";
            BackToMenubtn.Click += new System.EventHandler(this.BackToMenubtn_Click);
            // 
            // Profile
            // 
            this.Profile.AutoSize = true;
            this.Profile.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.White;
            this.Profile.Location = new System.Drawing.Point(135, 29);
            this.Profile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(492, 61);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Student Profile";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(50, 125);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(104, 29);
            this.name.TabIndex = 22;
            this.name.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 482);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 422);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hostel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "CNIC\r\n";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.White;
            this.age.Location = new System.Drawing.Point(50, 275);
            this.age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(48, 29);
            this.age.TabIndex = 26;
            this.age.Text = "Age";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.Location = new System.Drawing.Point(50, 202);
            this.gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(84, 29);
            this.gender.TabIndex = 27;
            this.gender.Text = "Gender ";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(303, 125);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(18, 29);
            this.username.TabIndex = 28;
            this.username.Text = " ";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // studentage
            // 
            this.studentage.AutoSize = true;
            this.studentage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentage.ForeColor = System.Drawing.Color.White;
            this.studentage.Location = new System.Drawing.Point(300, 275);
            this.studentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentage.Name = "studentage";
            this.studentage.Size = new System.Drawing.Size(18, 29);
            this.studentage.TabIndex = 30;
            this.studentage.Text = " ";
            this.studentage.Click += new System.EventHandler(this.studentage_Click);
            // 
            // studentcnic
            // 
            this.studentcnic.AutoSize = true;
            this.studentcnic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentcnic.ForeColor = System.Drawing.Color.White;
            this.studentcnic.Location = new System.Drawing.Point(303, 351);
            this.studentcnic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentcnic.Name = "studentcnic";
            this.studentcnic.Size = new System.Drawing.Size(0, 29);
            this.studentcnic.TabIndex = 31;
            this.studentcnic.Click += new System.EventHandler(this.studentcnic_Click);
            // 
            // hostell
            // 
            this.hostell.AutoSize = true;
            this.hostell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostell.ForeColor = System.Drawing.Color.White;
            this.hostell.Location = new System.Drawing.Point(300, 422);
            this.hostell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hostell.Name = "hostell";
            this.hostell.Size = new System.Drawing.Size(0, 29);
            this.hostell.TabIndex = 32;
            this.hostell.Click += new System.EventHandler(this.hostell_Click);
            // 
            // roomno
            // 
            this.roomno.AutoSize = true;
            this.roomno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomno.ForeColor = System.Drawing.Color.White;
            this.roomno.Location = new System.Drawing.Point(300, 482);
            this.roomno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomno.Name = "roomno";
            this.roomno.Size = new System.Drawing.Size(0, 29);
            this.roomno.TabIndex = 33;
            this.roomno.Click += new System.EventHandler(this.roomno_Click);
            // 
            // Studentgendr
            // 
            this.Studentgendr.AutoSize = true;
            this.Studentgendr.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentgendr.ForeColor = System.Drawing.Color.White;
            this.Studentgendr.Location = new System.Drawing.Point(300, 202);
            this.Studentgendr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Studentgendr.Name = "Studentgendr";
            this.Studentgendr.Size = new System.Drawing.Size(18, 29);
            this.Studentgendr.TabIndex = 34;
            this.Studentgendr.Text = " ";
            this.Studentgendr.Click += new System.EventHandler(this.Studentgendr_Click);
            // 
            // StudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(765, 685);
            this.Controls.Add(BackToMenubtn);
            this.Controls.Add(this.Studentgendr);
            this.Controls.Add(this.roomno);
            this.Controls.Add(this.hostell);
            this.Controls.Add(this.studentcnic);
            this.Controls.Add(this.studentage);
            this.Controls.Add(this.username);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Profile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentProfile";
            this.Load += new System.EventHandler(this.StudentProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Profile;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label studentage;
        private System.Windows.Forms.Label studentcnic;
        private System.Windows.Forms.Label hostell;
        private System.Windows.Forms.Label roomno;
        private System.Windows.Forms.Label Studentgendr;
    }
}