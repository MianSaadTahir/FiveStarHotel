namespace Resistay.UI
{
    partial class StudentComplain
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
            Guna.UI2.WinForms.Guna2Button BackToMenu;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Complainlabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComplainIdCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RemoveComplainBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ComplainGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComplainDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.Complainlabel3 = new System.Windows.Forms.Label();
            this.Complainlabel1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.ComplainDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ComplainDate = new System.Windows.Forms.DateTimePicker();
            this.Complainlabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Complainlabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(1112, 723);
            BackToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(165, 35);
            BackToMenu.TabIndex = 62;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // ComplainBtn
            // 
            this.ComplainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ComplainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ComplainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ComplainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ComplainBtn.FillColor = System.Drawing.Color.Silver;
            this.ComplainBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComplainBtn.ForeColor = System.Drawing.Color.White;
            this.ComplainBtn.Location = new System.Drawing.Point(1112, 193);
            this.ComplainBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainBtn.Name = "ComplainBtn";
            this.ComplainBtn.Size = new System.Drawing.Size(120, 35);
            this.ComplainBtn.TabIndex = 64;
            this.ComplainBtn.Text = "Add";
            this.ComplainBtn.Click += new System.EventHandler(this.ComplainBtn_Click);
            // 
            // Complainlabel2
            // 
            this.Complainlabel2.AutoSize = false;
            this.Complainlabel2.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel2.ForeColor = System.Drawing.Color.White;
            this.Complainlabel2.Location = new System.Drawing.Point(33, 85);
            this.Complainlabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Complainlabel2.Name = "Complainlabel2";
            this.Complainlabel2.Size = new System.Drawing.Size(157, 29);
            this.Complainlabel2.TabIndex = 63;
            this.Complainlabel2.Text = "Set Complain";
            // 
            // ComplainIdCombo
            // 
            this.ComplainIdCombo.BackColor = System.Drawing.Color.Transparent;
            this.ComplainIdCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComplainIdCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComplainIdCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainIdCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainIdCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComplainIdCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComplainIdCombo.ItemHeight = 30;
            this.ComplainIdCombo.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.ComplainIdCombo.Location = new System.Drawing.Point(650, 369);
            this.ComplainIdCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainIdCombo.Name = "ComplainIdCombo";
            this.ComplainIdCombo.Size = new System.Drawing.Size(208, 36);
            this.ComplainIdCombo.TabIndex = 61;
            // 
            // RemoveComplainBtn
            // 
            this.RemoveComplainBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveComplainBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveComplainBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveComplainBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveComplainBtn.FillColor = System.Drawing.Color.Silver;
            this.RemoveComplainBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveComplainBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveComplainBtn.Location = new System.Drawing.Point(1112, 369);
            this.RemoveComplainBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveComplainBtn.Name = "RemoveComplainBtn";
            this.RemoveComplainBtn.Size = new System.Drawing.Size(120, 36);
            this.RemoveComplainBtn.TabIndex = 60;
            this.RemoveComplainBtn.Text = "Remove";
            this.RemoveComplainBtn.Click += new System.EventHandler(this.RemoveComplainBtn_Click);
            // 
            // ComplainGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ComplainGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ComplainGrid.ColumnHeadersHeight = 4;
            this.ComplainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ComplainGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ComplainGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.Location = new System.Drawing.Point(105, 528);
            this.ComplainGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainGrid.Name = "ComplainGrid";
            this.ComplainGrid.RowHeadersVisible = false;
            this.ComplainGrid.RowHeadersWidth = 62;
            this.ComplainGrid.Size = new System.Drawing.Size(982, 209);
            this.ComplainGrid.TabIndex = 59;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ComplainGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ComplainGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ComplainGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.ComplainGrid.ThemeStyle.ReadOnly = false;
            this.ComplainGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ComplainGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ComplainGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ComplainGrid.ThemeStyle.RowsStyle.Height = 22;
            this.ComplainGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ComplainGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ComplainGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComplainGrid_CellContentClick);
            // 
            // ComplainDetails
            // 
            this.ComplainDetails.AutoRoundedCorners = true;
            this.ComplainDetails.BorderRadius = 63;
            this.ComplainDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ComplainDetails.DefaultText = "";
            this.ComplainDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ComplainDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ComplainDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComplainDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ComplainDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComplainDetails.ForeColor = System.Drawing.Color.Black;
            this.ComplainDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComplainDetails.Location = new System.Drawing.Point(12, 142);
            this.ComplainDetails.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ComplainDetails.Name = "ComplainDetails";
            this.ComplainDetails.PasswordChar = '\0';
            this.ComplainDetails.PlaceholderText = "";
            this.ComplainDetails.SelectedText = "";
            this.ComplainDetails.Size = new System.Drawing.Size(604, 129);
            this.ComplainDetails.TabIndex = 58;
            // 
            // Complainlabel3
            // 
            this.Complainlabel3.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel3.ForeColor = System.Drawing.Color.White;
            this.Complainlabel3.Location = new System.Drawing.Point(510, 295);
            this.Complainlabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Complainlabel3.Name = "Complainlabel3";
            this.Complainlabel3.Size = new System.Drawing.Size(325, 40);
            this.Complainlabel3.TabIndex = 57;
            this.Complainlabel3.Text = "Delete Complain";
            // 
            // Complainlabel1
            // 
            this.Complainlabel1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel1.ForeColor = System.Drawing.Color.White;
            this.Complainlabel1.Location = new System.Drawing.Point(562, 33);
            this.Complainlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Complainlabel1.Name = "Complainlabel1";
            this.Complainlabel1.Size = new System.Drawing.Size(207, 40);
            this.Complainlabel1.TabIndex = 56;
            this.Complainlabel1.Text = "Complains";
            this.Complainlabel1.Click += new System.EventHandler(this.Complainlabel1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // ComplainDateLabel
            // 
            this.ComplainDateLabel.AutoSize = false;
            this.ComplainDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ComplainDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplainDateLabel.ForeColor = System.Drawing.Color.White;
            this.ComplainDateLabel.Location = new System.Drawing.Point(685, 163);
            this.ComplainDateLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainDateLabel.Name = "ComplainDateLabel";
            this.ComplainDateLabel.Size = new System.Drawing.Size(59, 29);
            this.ComplainDateLabel.TabIndex = 68;
            this.ComplainDateLabel.Text = "Date";
            // 
            // ComplainDate
            // 
            this.ComplainDate.Location = new System.Drawing.Point(716, 202);
            this.ComplainDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComplainDate.Name = "ComplainDate";
            this.ComplainDate.Size = new System.Drawing.Size(298, 26);
            this.ComplainDate.TabIndex = 67;
            // 
            // Complainlabel5
            // 
            this.Complainlabel5.AutoSize = false;
            this.Complainlabel5.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel5.ForeColor = System.Drawing.Color.White;
            this.Complainlabel5.Location = new System.Drawing.Point(585, 475);
            this.Complainlabel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Complainlabel5.Name = "Complainlabel5";
            this.Complainlabel5.Size = new System.Drawing.Size(161, 29);
            this.Complainlabel5.TabIndex = 66;
            this.Complainlabel5.Text = "All Complains";
            // 
            // Complainlabel4
            // 
            this.Complainlabel4.AutoSize = false;
            this.Complainlabel4.BackColor = System.Drawing.Color.Transparent;
            this.Complainlabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complainlabel4.ForeColor = System.Drawing.Color.White;
            this.Complainlabel4.Location = new System.Drawing.Point(213, 376);
            this.Complainlabel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Complainlabel4.Name = "Complainlabel4";
            this.Complainlabel4.Size = new System.Drawing.Size(207, 29);
            this.Complainlabel4.TabIndex = 65;
            this.Complainlabel4.Text = "Give Complain Id\r\n";
            this.Complainlabel4.Click += new System.EventHandler(this.Complainlabel4_Click);
            // 
            // StudentComplain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1355, 875);
            this.Controls.Add(this.ComplainBtn);
            this.Controls.Add(this.Complainlabel2);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.ComplainIdCombo);
            this.Controls.Add(this.RemoveComplainBtn);
            this.Controls.Add(this.ComplainGrid);
            this.Controls.Add(this.ComplainDetails);
            this.Controls.Add(this.Complainlabel3);
            this.Controls.Add(this.Complainlabel1);
            this.Controls.Add(this.ComplainDateLabel);
            this.Controls.Add(this.ComplainDate);
            this.Controls.Add(this.Complainlabel5);
            this.Controls.Add(this.Complainlabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentComplain";
            this.Text = "StudentComplain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentComplain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComplainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button ComplainBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel2;
        private Guna.UI2.WinForms.Guna2ComboBox ComplainIdCombo;
        private Guna.UI2.WinForms.Guna2Button RemoveComplainBtn;
        private Guna.UI2.WinForms.Guna2DataGridView ComplainGrid;
        private Guna.UI2.WinForms.Guna2TextBox ComplainDetails;
        private System.Windows.Forms.Label Complainlabel3;
        private System.Windows.Forms.Label Complainlabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel ComplainDateLabel;
        private System.Windows.Forms.DateTimePicker ComplainDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel Complainlabel4;
    }
}