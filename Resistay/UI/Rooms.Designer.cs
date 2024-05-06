namespace Resistay.UI
{
    partial class Rooms
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
            Guna.UI2.WinForms.Guna2Button BackToMenu;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dltroom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RoomAddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.RemoveHostelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelsDataLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomnamelabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Hostellabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RoomNumberLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.removebtn = new System.Windows.Forms.Label();
            this.AddHostel = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelByroom = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMenu
            // 
            BackToMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BackToMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BackToMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            BackToMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            BackToMenu.FillColor = System.Drawing.Color.Silver;
            BackToMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            BackToMenu.ForeColor = System.Drawing.Color.Black;
            BackToMenu.Location = new System.Drawing.Point(1118, 674);
            BackToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(165, 35);
            BackToMenu.TabIndex = 48;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // dltroom
            // 
            this.dltroom.BackColor = System.Drawing.Color.Transparent;
            this.dltroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dltroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dltroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltroom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dltroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dltroom.ItemHeight = 30;
            this.dltroom.Items.AddRange(new object[] {
            " "});
            this.dltroom.Location = new System.Drawing.Point(297, 296);
            this.dltroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dltroom.Name = "dltroom";
            this.dltroom.Size = new System.Drawing.Size(233, 36);
            this.dltroom.TabIndex = 51;
            this.dltroom.SelectedIndexChanged += new System.EventHandler(this.dltroom_SelectedIndexChanged);
            // 
            // RoomGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RoomGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomGrid.ColumnHeadersHeight = 4;
            this.RoomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.Location = new System.Drawing.Point(180, 442);
            this.RoomGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomGrid.Name = "RoomGrid";
            this.RoomGrid.RowHeadersVisible = false;
            this.RoomGrid.RowHeadersWidth = 62;
            this.RoomGrid.Size = new System.Drawing.Size(982, 209);
            this.RoomGrid.TabIndex = 50;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.RoomGrid.ThemeStyle.ReadOnly = false;
            this.RoomGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RoomGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoomGrid_CellContentClick);
            // 
            // RoomAddbtn
            // 
            this.RoomAddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomAddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomAddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomAddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomAddbtn.FillColor = System.Drawing.Color.Silver;
            this.RoomAddbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomAddbtn.ForeColor = System.Drawing.Color.Black;
            this.RoomAddbtn.Location = new System.Drawing.Point(1118, 106);
            this.RoomAddbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomAddbtn.Name = "RoomAddbtn";
            this.RoomAddbtn.Size = new System.Drawing.Size(117, 40);
            this.RoomAddbtn.TabIndex = 49;
            this.RoomAddbtn.Text = "Add";
            this.RoomAddbtn.Click += new System.EventHandler(this.RoomAddbtn_Click);
            // 
            // RemoveHostelBtn
            // 
            this.RemoveHostelBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveHostelBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveHostelBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveHostelBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveHostelBtn.FillColor = System.Drawing.Color.Silver;
            this.RemoveHostelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveHostelBtn.ForeColor = System.Drawing.Color.Black;
            this.RemoveHostelBtn.Location = new System.Drawing.Point(1122, 288);
            this.RemoveHostelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveHostelBtn.Name = "RemoveHostelBtn";
            this.RemoveHostelBtn.Size = new System.Drawing.Size(120, 49);
            this.RemoveHostelBtn.TabIndex = 47;
            this.RemoveHostelBtn.Text = "Remove";
            this.RemoveHostelBtn.Click += new System.EventHandler(this.RemoveHostelBtn_Click);
            // 
            // HostelsDataLabel
            // 
            this.HostelsDataLabel.AutoSize = false;
            this.HostelsDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostelsDataLabel.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelsDataLabel.ForeColor = System.Drawing.Color.White;
            this.HostelsDataLabel.Location = new System.Drawing.Point(542, 383);
            this.HostelsDataLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelsDataLabel.Name = "HostelsDataLabel";
            this.HostelsDataLabel.Size = new System.Drawing.Size(260, 31);
            this.HostelsDataLabel.TabIndex = 46;
            this.HostelsDataLabel.Text = "All Available Rooms";
            this.HostelsDataLabel.Click += new System.EventHandler(this.HostelsDataLabel_Click);
            // 
            // roomnamelabel
            // 
            this.roomnamelabel.AutoSize = false;
            this.roomnamelabel.BackColor = System.Drawing.Color.Transparent;
            this.roomnamelabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomnamelabel.ForeColor = System.Drawing.Color.White;
            this.roomnamelabel.Location = new System.Drawing.Point(58, 296);
            this.roomnamelabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomnamelabel.Name = "roomnamelabel";
            this.roomnamelabel.Size = new System.Drawing.Size(145, 29);
            this.roomnamelabel.TabIndex = 45;
            this.roomnamelabel.Text = "Select Room";
            this.roomnamelabel.Click += new System.EventHandler(this.roomnamelabel_Click);
            // 
            // Hostellabel
            // 
            this.Hostellabel.AutoSize = false;
            this.Hostellabel.BackColor = System.Drawing.Color.Transparent;
            this.Hostellabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hostellabel.ForeColor = System.Drawing.Color.White;
            this.Hostellabel.Location = new System.Drawing.Point(642, 109);
            this.Hostellabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Hostellabel.Name = "Hostellabel";
            this.Hostellabel.Size = new System.Drawing.Size(148, 29);
            this.Hostellabel.TabIndex = 44;
            this.Hostellabel.Text = "Select Hostel ";
            this.Hostellabel.Click += new System.EventHandler(this.Hostellabel_Click);
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = false;
            this.RoomNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNumberLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNumberLabel.Location = new System.Drawing.Point(36, 111);
            this.RoomNumberLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(228, 29);
            this.RoomNumberLabel.TabIndex = 43;
            this.RoomNumberLabel.Text = "Enter Room Number";
            this.RoomNumberLabel.Click += new System.EventHandler(this.RoomNumberLabel_Click);
            // 
            // HostelName
            // 
            this.HostelName.BackColor = System.Drawing.Color.Transparent;
            this.HostelName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HostelName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostelName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HostelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HostelName.ItemHeight = 30;
            this.HostelName.Items.AddRange(new object[] {
            " "});
            this.HostelName.Location = new System.Drawing.Point(852, 108);
            this.HostelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelName.Name = "HostelName";
            this.HostelName.Size = new System.Drawing.Size(208, 36);
            this.HostelName.TabIndex = 42;
            this.HostelName.SelectedIndexChanged += new System.EventHandler(this.HostelName_SelectedIndexChanged);
            // 
            // RoomNumber
            // 
            this.RoomNumber.AutoRoundedCorners = true;
            this.RoomNumber.BorderRadius = 19;
            this.RoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNumber.DefaultText = "";
            this.RoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomNumber.ForeColor = System.Drawing.Color.Black;
            this.RoomNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNumber.Location = new System.Drawing.Point(297, 111);
            this.RoomNumber.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.PasswordChar = '\0';
            this.RoomNumber.PlaceholderText = "";
            this.RoomNumber.SelectedText = "";
            this.RoomNumber.Size = new System.Drawing.Size(233, 40);
            this.RoomNumber.TabIndex = 41;
            this.RoomNumber.TextChanged += new System.EventHandler(this.RoomNumber_TextChanged);
            // 
            // removebtn
            // 
            this.removebtn.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.Location = new System.Drawing.Point(547, 211);
            this.removebtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(267, 43);
            this.removebtn.TabIndex = 40;
            this.removebtn.Text = "Remove Room";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // AddHostel
            // 
            this.AddHostel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHostel.ForeColor = System.Drawing.Color.White;
            this.AddHostel.Location = new System.Drawing.Point(563, 18);
            this.AddHostel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddHostel.Name = "AddHostel";
            this.AddHostel.Size = new System.Drawing.Size(195, 43);
            this.AddHostel.TabIndex = 39;
            this.AddHostel.Text = "Add Room";
            this.AddHostel.Click += new System.EventHandler(this.AddHostel_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(646, 292);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(148, 29);
            this.guna2HtmlLabel1.TabIndex = 52;
            this.guna2HtmlLabel1.Text = "Select Hostel ";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // HostelByroom
            // 
            this.HostelByroom.BackColor = System.Drawing.Color.Transparent;
            this.HostelByroom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HostelByroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostelByroom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelByroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelByroom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HostelByroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HostelByroom.ItemHeight = 30;
            this.HostelByroom.Items.AddRange(new object[] {
            " "});
            this.HostelByroom.Location = new System.Drawing.Point(852, 289);
            this.HostelByroom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelByroom.Name = "HostelByroom";
            this.HostelByroom.Size = new System.Drawing.Size(208, 36);
            this.HostelByroom.TabIndex = 53;
            this.HostelByroom.SelectedIndexChanged += new System.EventHandler(this.HostelByroom_SelectedIndexChanged);
            // 
            // Rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1288, 728);
            this.Controls.Add(this.HostelByroom);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dltroom);
            this.Controls.Add(this.RoomGrid);
            this.Controls.Add(this.RoomAddbtn);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveHostelBtn);
            this.Controls.Add(this.HostelsDataLabel);
            this.Controls.Add(this.roomnamelabel);
            this.Controls.Add(this.Hostellabel);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.HostelName);
            this.Controls.Add(this.RoomNumber);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.AddHostel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox dltroom;
        private Guna.UI2.WinForms.Guna2DataGridView RoomGrid;
        private Guna.UI2.WinForms.Guna2Button RoomAddbtn;
        private Guna.UI2.WinForms.Guna2Button RemoveHostelBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelsDataLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel roomnamelabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Hostellabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel RoomNumberLabel;
        private Guna.UI2.WinForms.Guna2ComboBox HostelName;
        private Guna.UI2.WinForms.Guna2TextBox RoomNumber;
        private System.Windows.Forms.Label removebtn;
        private System.Windows.Forms.Label AddHostel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox HostelByroom;
    }
}