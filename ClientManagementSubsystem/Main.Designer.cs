namespace ClientManagementSubsystem
{
    partial class Main
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
            this.containerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.bookingsBtn = new FontAwesome.Sharp.IconButton();
            this.personalBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.headerPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.containerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.containerPanel.BorderThickness = 5;
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(5, 87);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1622, 943);
            this.containerPanel.TabIndex = 2;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.headerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.headerPanel.BorderThickness = 5;
            this.headerPanel.Controls.Add(this.statusLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1632, 82);
            this.headerPanel.TabIndex = 3;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(19, 26);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(147, 31);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Dashboard";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dashboardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(9, 104);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(248, 71);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            this.dashboardBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.dashboardBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // bookingsBtn
            // 
            this.bookingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bookingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookingsBtn.FlatAppearance.BorderSize = 0;
            this.bookingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bookingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookingsBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.bookingsBtn.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.bookingsBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.bookingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bookingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookingsBtn.Location = new System.Drawing.Point(9, 181);
            this.bookingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bookingsBtn.Name = "bookingsBtn";
            this.bookingsBtn.Size = new System.Drawing.Size(248, 71);
            this.bookingsBtn.TabIndex = 2;
            this.bookingsBtn.Text = "Bookings";
            this.bookingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookingsBtn.UseVisualStyleBackColor = false;
            this.bookingsBtn.Click += new System.EventHandler(this.bookingsBtn_Click);
            this.bookingsBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.bookingsBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // personalBtn
            // 
            this.personalBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.personalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.personalBtn.FlatAppearance.BorderSize = 0;
            this.personalBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.personalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalBtn.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.personalBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.personalBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.personalBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.personalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.personalBtn.Location = new System.Drawing.Point(9, 335);
            this.personalBtn.Margin = new System.Windows.Forms.Padding(0);
            this.personalBtn.Name = "personalBtn";
            this.personalBtn.Size = new System.Drawing.Size(248, 71);
            this.personalBtn.TabIndex = 3;
            this.personalBtn.Text = "Agent Stats";
            this.personalBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.personalBtn.UseVisualStyleBackColor = false;
            this.personalBtn.Click += new System.EventHandler(this.personalBtn_Click);
            this.personalBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.personalBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logoutBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 30;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 993);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(260, 42);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.logoutBtn.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.sidebarPanel.Controls.Add(this.iconButton1);
            this.sidebarPanel.Controls.Add(this.logoutBtn);
            this.sidebarPanel.Controls.Add(this.personalBtn);
            this.sidebarPanel.Controls.Add(this.bookingsBtn);
            this.sidebarPanel.Controls.Add(this.dashboardBtn);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebarPanel.Location = new System.Drawing.Point(3, 3);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(260, 1035);
            this.sidebarPanel.TabIndex = 1;
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.layoutPanel.Controls.Add(this.sidebarPanel, 0, 0);
            this.layoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 1;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Size = new System.Drawing.Size(1904, 1041);
            this.layoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.containerPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.headerPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(269, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1632, 1035);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(9, 258);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(248, 71);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Unit Inspection";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.layoutPanel);
            this.Name = "Main";
            this.RightToLeftLayout = true;
            this.Text = "Client Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.sidebarPanel.ResumeLayout(false);
            this.layoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel containerPanel;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private System.Windows.Forms.Label statusLabel;
        private FontAwesome.Sharp.IconButton dashboardBtn;
        private FontAwesome.Sharp.IconButton bookingsBtn;
        private FontAwesome.Sharp.IconButton personalBtn;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

