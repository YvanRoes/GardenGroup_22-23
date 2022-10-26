namespace UI
{
    partial class UserManagementView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filter_bttn = new System.Windows.Forms.Button();
            this.User_lstView = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.EmailHeader1 = new System.Windows.Forms.ColumnHeader();
            this.locationHeader = new System.Windows.Forms.ColumnHeader();
            this.AddUser_bttn = new System.Windows.Forms.Button();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TicketsHeader = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.ticketManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // ticketManagementToolStripMenuItem
            // 
            this.ticketManagementToolStripMenuItem.Name = "ticketManagementToolStripMenuItem";
            this.ticketManagementToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.ticketManagementToolStripMenuItem.Text = "Ticket Management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.userManagementToolStripMenuItem.Text = "User Management";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Filter_bttn);
            this.panel1.Controls.Add(this.User_lstView);
            this.panel1.Controls.Add(this.AddUser_bttn);
            this.panel1.Controls.Add(this.filter_txtbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 407);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Filter_bttn
            // 
            this.Filter_bttn.Location = new System.Drawing.Point(314, 54);
            this.Filter_bttn.Name = "Filter_bttn";
            this.Filter_bttn.Size = new System.Drawing.Size(94, 29);
            this.Filter_bttn.TabIndex = 4;
            this.Filter_bttn.Text = "Filter";
            this.Filter_bttn.UseVisualStyleBackColor = true;
            this.Filter_bttn.Click += new System.EventHandler(this.Filter_bttn_Click);
            // 
            // User_lstView
            // 
            this.User_lstView.BackgroundImageTiled = true;
            this.User_lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.EmailHeader1,
            this.nameHeader,
            this.locationHeader,
            this.TicketsHeader});
            this.User_lstView.HideSelection = false;
            this.User_lstView.Location = new System.Drawing.Point(12, 102);
            this.User_lstView.MultiSelect = false;
            this.User_lstView.Name = "User_lstView";
            this.User_lstView.Size = new System.Drawing.Size(776, 305);
            this.User_lstView.TabIndex = 3;
            this.User_lstView.UseCompatibleStateImageBehavior = false;
            this.User_lstView.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            this.IdHeader.Width = 80;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 140;
            // 
            // EmailHeader1
            // 
            this.EmailHeader1.Text = "Email";
            this.EmailHeader1.Width = 250;
            // 
            // locationHeader
            // 
            this.locationHeader.Text = "Location";
            this.locationHeader.Width = 150;
            // 
            // AddUser_bttn
            // 
            this.AddUser_bttn.Location = new System.Drawing.Point(660, 67);
            this.AddUser_bttn.Name = "AddUser_bttn";
            this.AddUser_bttn.Size = new System.Drawing.Size(94, 29);
            this.AddUser_bttn.TabIndex = 2;
            this.AddUser_bttn.Text = "Add User";
            this.AddUser_bttn.UseVisualStyleBackColor = true;
            this.AddUser_bttn.Click += new System.EventHandler(this.AddUser_bttn_Click);
            // 
            // filter_txtbox
            // 
            this.filter_txtbox.Location = new System.Drawing.Point(17, 55);
            this.filter_txtbox.Name = "filter_txtbox";
            this.filter_txtbox.Size = new System.Drawing.Size(279, 27);
            this.filter_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // TicketsHeader
            // 
            this.TicketsHeader.Text = "# Tickets";
            this.TicketsHeader.Width = 90;
            // 
            // UserManagementView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserManagementView";
            this.Text = "UserManagementView";
            this.Load += new System.EventHandler(this.UserManagementView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Filter_bttn;
        private System.Windows.Forms.ListView User_lstView;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader1;
        private System.Windows.Forms.ColumnHeader locationHeader;
        private System.Windows.Forms.Button AddUser_bttn;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader TicketsHeader;
    }
}