namespace Resistay.UI
{
    partial class HostelManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddHostel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HostelName = new Guna.UI2.WinForms.Guna2TextBox();
            this.HostelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HostelNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelTypeLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelNameLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.HostelsDataLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RemoveHostelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelAddbtn = new Guna.UI2.WinForms.Guna2Button();
            this.HostelGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dltHostel = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.HostelGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(1130, 734);
            BackToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(165, 35);
            BackToMenu.TabIndex = 35;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // AddHostel
            // 
            this.AddHostel.AutoSize = true;
            this.AddHostel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddHostel.ForeColor = System.Drawing.Color.White;
            this.AddHostel.Location = new System.Drawing.Point(534, 41);
            this.AddHostel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddHostel.Name = "AddHostel";
            this.AddHostel.Size = new System.Drawing.Size(306, 40);
            this.AddHostel.TabIndex = 0;
            this.AddHostel.Text = "Add New Hostel";
            this.AddHostel.Click += new System.EventHandler(this.AddHostel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(535, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Hostel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HostelName
            // 
            this.HostelName.AutoRoundedCorners = true;
            this.HostelName.BorderRadius = 17;
            this.HostelName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HostelName.DefaultText = "";
            this.HostelName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HostelName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HostelName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HostelName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HostelName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HostelName.ForeColor = System.Drawing.Color.Black;
            this.HostelName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelName.Location = new System.Drawing.Point(260, 140);
            this.HostelName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.HostelName.Name = "HostelName";
            this.HostelName.PasswordChar = '\0';
            this.HostelName.PlaceholderText = "";
            this.HostelName.SelectedText = "";
            this.HostelName.Size = new System.Drawing.Size(300, 36);
            this.HostelName.TabIndex = 2;
            this.HostelName.TextChanged += new System.EventHandler(this.HostelName_TextChanged);
            // 
            // HostelType
            // 
            this.HostelType.BackColor = System.Drawing.Color.Transparent;
            this.HostelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HostelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HostelType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HostelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HostelType.ItemHeight = 30;
            this.HostelType.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.HostelType.Location = new System.Drawing.Point(864, 140);
            this.HostelType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelType.Name = "HostelType";
            this.HostelType.Size = new System.Drawing.Size(208, 36);
            this.HostelType.TabIndex = 3;
            this.HostelType.SelectedIndexChanged += new System.EventHandler(this.HostelType_SelectedIndexChanged);
            // 
            // HostelNameLabel
            // 
            this.HostelNameLabel.AutoSize = false;
            this.HostelNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostelNameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelNameLabel.ForeColor = System.Drawing.Color.White;
            this.HostelNameLabel.Location = new System.Drawing.Point(13, 140);
            this.HostelNameLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelNameLabel.Name = "HostelNameLabel";
            this.HostelNameLabel.Size = new System.Drawing.Size(210, 29);
            this.HostelNameLabel.TabIndex = 4;
            this.HostelNameLabel.Text = "Enter Hostel Name";
            this.HostelNameLabel.Click += new System.EventHandler(this.HostelNameLabel_Click);
            // 
            // HostelTypeLabel
            // 
            this.HostelTypeLabel.AutoSize = false;
            this.HostelTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostelTypeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelTypeLabel.ForeColor = System.Drawing.Color.White;
            this.HostelTypeLabel.Location = new System.Drawing.Point(617, 140);
            this.HostelTypeLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelTypeLabel.Name = "HostelTypeLabel";
            this.HostelTypeLabel.Size = new System.Drawing.Size(209, 29);
            this.HostelTypeLabel.TabIndex = 5;
            this.HostelTypeLabel.Text = "Select Hostel Type";
            this.HostelTypeLabel.Click += new System.EventHandler(this.HostelTypeLabel_Click);
            // 
            // HostelNameLabel2
            // 
            this.HostelNameLabel2.AutoSize = false;
            this.HostelNameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.HostelNameLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelNameLabel2.ForeColor = System.Drawing.Color.White;
            this.HostelNameLabel2.Location = new System.Drawing.Point(377, 354);
            this.HostelNameLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelNameLabel2.Name = "HostelNameLabel2";
            this.HostelNameLabel2.Size = new System.Drawing.Size(148, 29);
            this.HostelNameLabel2.TabIndex = 6;
            this.HostelNameLabel2.Text = "Hostel Name";
            this.HostelNameLabel2.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // HostelsDataLabel
            // 
            this.HostelsDataLabel.BackColor = System.Drawing.Color.Transparent;
            this.HostelsDataLabel.Font = new System.Drawing.Font("Stencil", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelsDataLabel.ForeColor = System.Drawing.Color.White;
            this.HostelsDataLabel.Location = new System.Drawing.Point(603, 450);
            this.HostelsDataLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelsDataLabel.Name = "HostelsDataLabel";
            this.HostelsDataLabel.Size = new System.Drawing.Size(140, 28);
            this.HostelsDataLabel.TabIndex = 10;
            this.HostelsDataLabel.Text = "All Hostels";
            this.HostelsDataLabel.Click += new System.EventHandler(this.HostelsDataLabel_Click);
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
            this.RemoveHostelBtn.Location = new System.Drawing.Point(893, 350);
            this.RemoveHostelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveHostelBtn.Name = "RemoveHostelBtn";
            this.RemoveHostelBtn.Size = new System.Drawing.Size(120, 43);
            this.RemoveHostelBtn.TabIndex = 12;
            this.RemoveHostelBtn.Text = "Remove";
            this.RemoveHostelBtn.Click += new System.EventHandler(this.RemoveHostelBtn_Click);
            // 
            // HostelAddbtn
            // 
            this.HostelAddbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HostelAddbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HostelAddbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HostelAddbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HostelAddbtn.FillColor = System.Drawing.Color.Silver;
            this.HostelAddbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HostelAddbtn.ForeColor = System.Drawing.Color.Black;
            this.HostelAddbtn.Location = new System.Drawing.Point(1139, 131);
            this.HostelAddbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelAddbtn.Name = "HostelAddbtn";
            this.HostelAddbtn.Size = new System.Drawing.Size(120, 45);
            this.HostelAddbtn.TabIndex = 36;
            this.HostelAddbtn.Text = "Add";
            this.HostelAddbtn.Click += new System.EventHandler(this.HostelAddbtn_Click);
            // 
            // HostelGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.HostelGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HostelGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.HostelGrid.ColumnHeadersHeight = 4;
            this.HostelGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HostelGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.HostelGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HostelGrid.Location = new System.Drawing.Point(198, 497);
            this.HostelGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HostelGrid.Name = "HostelGrid";
            this.HostelGrid.RowHeadersVisible = false;
            this.HostelGrid.RowHeadersWidth = 62;
            this.HostelGrid.Size = new System.Drawing.Size(982, 209);
            this.HostelGrid.TabIndex = 37;
            this.HostelGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.HostelGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HostelGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HostelGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HostelGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HostelGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HostelGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HostelGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.HostelGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HostelGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HostelGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HostelGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.HostelGrid.ThemeStyle.ReadOnly = false;
            this.HostelGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HostelGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HostelGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HostelGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HostelGrid.ThemeStyle.RowsStyle.Height = 22;
            this.HostelGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HostelGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HostelGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HostelGrid_CellContentClick);
            // 
            // dltHostel
            // 
            this.dltHostel.BackColor = System.Drawing.Color.Transparent;
            this.dltHostel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dltHostel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dltHostel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltHostel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dltHostel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dltHostel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dltHostel.ItemHeight = 30;
            this.dltHostel.Items.AddRange(new object[] {
            " "});
            this.dltHostel.Location = new System.Drawing.Point(582, 350);
            this.dltHostel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dltHostel.Name = "dltHostel";
            this.dltHostel.Size = new System.Drawing.Size(208, 36);
            this.dltHostel.TabIndex = 38;
            this.dltHostel.SelectedIndexChanged += new System.EventHandler(this.dltHostel_SelectedIndexChanged);
            // 
            // HostelManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 788);
            this.Controls.Add(this.HostelNameLabel);
            this.Controls.Add(this.HostelTypeLabel);
            this.Controls.Add(this.HostelNameLabel2);
            this.Controls.Add(this.dltHostel);
            this.Controls.Add(this.HostelGrid);
            this.Controls.Add(this.HostelAddbtn);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveHostelBtn);
            this.Controls.Add(this.HostelsDataLabel);
            this.Controls.Add(this.HostelType);
            this.Controls.Add(this.HostelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddHostel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HostelManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HostelManage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HostelManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HostelGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddHostel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox HostelName;
        private Guna.UI2.WinForms.Guna2ComboBox HostelType;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelNameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelTypeLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelNameLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel HostelsDataLabel;
        private Guna.UI2.WinForms.Guna2Button RemoveHostelBtn;
        private Guna.UI2.WinForms.Guna2Button HostelAddbtn;
        private Guna.UI2.WinForms.Guna2DataGridView HostelGrid;
        private Guna.UI2.WinForms.Guna2ComboBox dltHostel;
    }
}