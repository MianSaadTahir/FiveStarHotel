namespace Resistay.UI
{
    partial class Ruleform
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
            this.RulesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Rules1label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RemoveRuleBtn = new Guna.UI2.WinForms.Guna2Button();
            this.RulesGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Rule = new Guna.UI2.WinForms.Guna2TextBox();
            this.DltRuleLabel = new System.Windows.Forms.Label();
            this.RulesLabel1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RulesDate = new System.Windows.Forms.DateTimePicker();
            this.RulesDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rulesId = new Guna.UI2.WinForms.Guna2ComboBox();
            BackToMenu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).BeginInit();
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
            BackToMenu.Location = new System.Drawing.Point(1124, 723);
            BackToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BackToMenu.Name = "BackToMenu";
            BackToMenu.Size = new System.Drawing.Size(158, 35);
            BackToMenu.TabIndex = 60;
            BackToMenu.Text = "Back To Menu";
            BackToMenu.Click += new System.EventHandler(this.BackToMenu_Click);
            // 
            // RulesBtn
            // 
            this.RulesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RulesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RulesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RulesBtn.FillColor = System.Drawing.Color.Silver;
            this.RulesBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RulesBtn.ForeColor = System.Drawing.Color.Black;
            this.RulesBtn.Location = new System.Drawing.Point(1086, 177);
            this.RulesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesBtn.Name = "RulesBtn";
            this.RulesBtn.Size = new System.Drawing.Size(120, 47);
            this.RulesBtn.TabIndex = 62;
            this.RulesBtn.Text = "Add";
            this.RulesBtn.Click += new System.EventHandler(this.RulesBtn_Click);
            // 
            // Rules1label
            // 
            this.Rules1label.AutoSize = false;
            this.Rules1label.BackColor = System.Drawing.Color.Transparent;
            this.Rules1label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules1label.ForeColor = System.Drawing.Color.White;
            this.Rules1label.Location = new System.Drawing.Point(45, 98);
            this.Rules1label.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rules1label.Name = "Rules1label";
            this.Rules1label.Size = new System.Drawing.Size(248, 29);
            this.Rules1label.TabIndex = 61;
            this.Rules1label.Text = "Enter a new Rule here";
            // 
            // RemoveRuleBtn
            // 
            this.RemoveRuleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRuleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveRuleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveRuleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveRuleBtn.FillColor = System.Drawing.Color.Silver;
            this.RemoveRuleBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveRuleBtn.ForeColor = System.Drawing.Color.Black;
            this.RemoveRuleBtn.Location = new System.Drawing.Point(663, 369);
            this.RemoveRuleBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RemoveRuleBtn.Name = "RemoveRuleBtn";
            this.RemoveRuleBtn.Size = new System.Drawing.Size(120, 51);
            this.RemoveRuleBtn.TabIndex = 58;
            this.RemoveRuleBtn.Text = "Remove";
            this.RemoveRuleBtn.Click += new System.EventHandler(this.RemoveRuleBtn_Click);
            // 
            // RulesGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RulesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RulesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RulesGrid.ColumnHeadersHeight = 4;
            this.RulesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RulesGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.RulesGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.Location = new System.Drawing.Point(117, 528);
            this.RulesGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesGrid.Name = "RulesGrid";
            this.RulesGrid.RowHeadersVisible = false;
            this.RulesGrid.RowHeadersWidth = 62;
            this.RulesGrid.Size = new System.Drawing.Size(982, 209);
            this.RulesGrid.TabIndex = 57;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RulesGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RulesGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RulesGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.RulesGrid.ThemeStyle.ReadOnly = false;
            this.RulesGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RulesGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RulesGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RulesGrid.ThemeStyle.RowsStyle.Height = 22;
            this.RulesGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RulesGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Rule
            // 
            this.Rule.AutoRoundedCorners = true;
            this.Rule.BorderRadius = 45;
            this.Rule.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Rule.DefaultText = "";
            this.Rule.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Rule.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Rule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rule.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Rule.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Rule.ForeColor = System.Drawing.Color.Black;
            this.Rule.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rule.Location = new System.Drawing.Point(24, 142);
            this.Rule.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Rule.Name = "Rule";
            this.Rule.PasswordChar = '\0';
            this.Rule.PlaceholderText = "";
            this.Rule.SelectedText = "";
            this.Rule.Size = new System.Drawing.Size(681, 92);
            this.Rule.TabIndex = 56;
            this.Rule.TextChanged += new System.EventHandler(this.RulesDescription_TextChanged);
            // 
            // DltRuleLabel
            // 
            this.DltRuleLabel.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DltRuleLabel.ForeColor = System.Drawing.Color.White;
            this.DltRuleLabel.Location = new System.Drawing.Point(570, 279);
            this.DltRuleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DltRuleLabel.Name = "DltRuleLabel";
            this.DltRuleLabel.Size = new System.Drawing.Size(243, 43);
            this.DltRuleLabel.TabIndex = 55;
            this.DltRuleLabel.Text = "Delete Rule";
            // 
            // RulesLabel1
            // 
            this.RulesLabel1.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesLabel1.ForeColor = System.Drawing.Color.White;
            this.RulesLabel1.Location = new System.Drawing.Point(437, 19);
            this.RulesLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RulesLabel1.Name = "RulesLabel1";
            this.RulesLabel1.Size = new System.Drawing.Size(450, 43);
            this.RulesLabel1.TabIndex = 54;
            this.RulesLabel1.Text = "Rules and Regulations";
            this.RulesLabel1.Click += new System.EventHandler(this.RulesLabel1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(512, 468);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(96, 29);
            this.guna2HtmlLabel3.TabIndex = 64;
            this.guna2HtmlLabel3.Text = "All Rules";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 384);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(142, 29);
            this.guna2HtmlLabel2.TabIndex = 63;
            this.guna2HtmlLabel2.Text = "Give Rule Id";
            // 
            // RulesDate
            // 
            this.RulesDate.Location = new System.Drawing.Point(753, 198);
            this.RulesDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesDate.Name = "RulesDate";
            this.RulesDate.Size = new System.Drawing.Size(298, 26);
            this.RulesDate.TabIndex = 65;
            // 
            // RulesDateLabel
            // 
            this.RulesDateLabel.AutoSize = false;
            this.RulesDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.RulesDateLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesDateLabel.ForeColor = System.Drawing.Color.White;
            this.RulesDateLabel.Location = new System.Drawing.Point(753, 155);
            this.RulesDateLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesDateLabel.Name = "RulesDateLabel";
            this.RulesDateLabel.Size = new System.Drawing.Size(59, 29);
            this.RulesDateLabel.TabIndex = 66;
            this.RulesDateLabel.Text = "Date";
            // 
            // rulesId
            // 
            this.rulesId.BackColor = System.Drawing.Color.Transparent;
            this.rulesId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.rulesId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rulesId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rulesId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rulesId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rulesId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.rulesId.ItemHeight = 30;
            this.rulesId.Items.AddRange(new object[] {
            "Boys",
            "Girls"});
            this.rulesId.Location = new System.Drawing.Point(309, 384);
            this.rulesId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rulesId.Name = "rulesId";
            this.rulesId.Size = new System.Drawing.Size(208, 36);
            this.rulesId.TabIndex = 67;
            this.rulesId.SelectedIndexChanged += new System.EventHandler(this.rulesId_SelectedIndexChanged);
            // 
            // Ruleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1312, 788);
            this.Controls.Add(this.rulesId);
            this.Controls.Add(this.RulesDateLabel);
            this.Controls.Add(this.RulesDate);
            this.Controls.Add(this.RulesBtn);
            this.Controls.Add(this.Rules1label);
            this.Controls.Add(BackToMenu);
            this.Controls.Add(this.RemoveRuleBtn);
            this.Controls.Add(this.RulesGrid);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.DltRuleLabel);
            this.Controls.Add(this.RulesLabel1);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ruleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RulesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button RulesBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Rules1label;
        private Guna.UI2.WinForms.Guna2Button RemoveRuleBtn;
        private Guna.UI2.WinForms.Guna2DataGridView RulesGrid;
        private Guna.UI2.WinForms.Guna2TextBox Rule;
        private System.Windows.Forms.Label DltRuleLabel;
        private System.Windows.Forms.Label RulesLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DateTimePicker RulesDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel RulesDateLabel;
        private Guna.UI2.WinForms.Guna2ComboBox rulesId;
    }
}