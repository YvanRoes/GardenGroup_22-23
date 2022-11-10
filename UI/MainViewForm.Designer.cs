namespace UI
{
    partial class MainViewForm
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
            this.DashBoardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.PieChartWrapper2 = new System.Windows.Forms.Panel();
            this.PieChartWrapper = new System.Windows.Forms.Panel();
            this.lblTest = new System.Windows.Forms.Label();
            this.UserManagement_Pnl = new System.Windows.Forms.Panel();
            this.FilterUsersByEmail_bttn = new System.Windows.Forms.Button();
            this.User_lstView = new System.Windows.Forms.ListView();
            this.IdHeader = new System.Windows.Forms.ColumnHeader();
            this.EmailHeader1 = new System.Windows.Forms.ColumnHeader();
            this.nameHeader = new System.Windows.Forms.ColumnHeader();
            this.locationHeader = new System.Windows.Forms.ColumnHeader();
            this.TicketsHeader = new System.Windows.Forms.ColumnHeader();
            this.AddUser_bttn = new System.Windows.Forms.Button();
            this.filter_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            this.UserManagement_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashBoardMenuItem,
            this.ticketManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1391, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DashBoardMenuItem
            // 
            this.DashBoardMenuItem.Name = "DashBoardMenuItem";
            this.DashBoardMenuItem.Size = new System.Drawing.Size(76, 20);
            this.DashBoardMenuItem.Text = "Dashboard";
            this.DashBoardMenuItem.Click += new System.EventHandler(this.DashBoardMenuItem_Click);
            // 
            // ticketManagementToolStripMenuItem
            // 
            this.ticketManagementToolStripMenuItem.Name = "ticketManagementToolStripMenuItem";
            this.ticketManagementToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.ticketManagementToolStripMenuItem.Text = "Ticket Management";
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.Controls.Add(this.PieChartWrapper2);
            this.pnlDashBoard.Controls.Add(this.PieChartWrapper);
            this.pnlDashBoard.Controls.Add(this.lblTest);
            this.pnlDashBoard.Location = new System.Drawing.Point(40, 73);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(812, 295);
            this.pnlDashBoard.TabIndex = 4;
            // 
            // PieChartWrapper2
            // 
            this.PieChartWrapper2.Location = new System.Drawing.Point(540, 62);
            this.PieChartWrapper2.Name = "PieChartWrapper2";
            this.PieChartWrapper2.Size = new System.Drawing.Size(201, 201);
            this.PieChartWrapper2.TabIndex = 4;
            // 
            // PieChartWrapper
            // 
            this.PieChartWrapper.Location = new System.Drawing.Point(218, 62);
            this.PieChartWrapper.Name = "PieChartWrapper";
            this.PieChartWrapper.Size = new System.Drawing.Size(201, 201);
            this.PieChartWrapper.TabIndex = 3;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(144, 62);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(38, 15);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "label1";
            // 
            // UserManagement_Pnl
            // 
            this.UserManagement_Pnl.Controls.Add(this.FilterUsersByEmail_bttn);
            this.UserManagement_Pnl.Controls.Add(this.User_lstView);
            this.UserManagement_Pnl.Controls.Add(this.AddUser_bttn);
            this.UserManagement_Pnl.Controls.Add(this.filter_txtbox);
            this.UserManagement_Pnl.Controls.Add(this.label1);
            this.UserManagement_Pnl.Location = new System.Drawing.Point(40, 407);
            this.UserManagement_Pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserManagement_Pnl.Name = "UserManagement_Pnl";
            this.UserManagement_Pnl.Size = new System.Drawing.Size(824, 345);
            this.UserManagement_Pnl.TabIndex = 5;
            // 
            // FilterUsersByEmail_bttn
            // 
            this.FilterUsersByEmail_bttn.Location = new System.Drawing.Point(298, 40);
            this.FilterUsersByEmail_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FilterUsersByEmail_bttn.Name = "FilterUsersByEmail_bttn";
            this.FilterUsersByEmail_bttn.Size = new System.Drawing.Size(82, 22);
            this.FilterUsersByEmail_bttn.TabIndex = 4;
            this.FilterUsersByEmail_bttn.Text = "Filter";
            this.FilterUsersByEmail_bttn.UseVisualStyleBackColor = true;
            this.FilterUsersByEmail_bttn.Click += new System.EventHandler(this.FilterUsersByEmail_bttn_Click);
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
            this.User_lstView.FullRowSelect = true;
            this.User_lstView.HideSelection = false;
            this.User_lstView.Location = new System.Drawing.Point(36, 76);
            this.User_lstView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_lstView.MultiSelect = false;
            this.User_lstView.Name = "User_lstView";
            this.User_lstView.Size = new System.Drawing.Size(751, 262);
            this.User_lstView.TabIndex = 3;
            this.User_lstView.UseCompatibleStateImageBehavior = false;
            this.User_lstView.View = System.Windows.Forms.View.Details;
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "Id";
            this.IdHeader.Width = 100;
            // 
            // EmailHeader1
            // 
            this.EmailHeader1.Text = "Email";
            this.EmailHeader1.Width = 270;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 190;
            // 
            // locationHeader
            // 
            this.locationHeader.Text = "Location";
            this.locationHeader.Width = 160;
            // 
            // TicketsHeader
            // 
            this.TicketsHeader.Text = "# Tickets";
            this.TicketsHeader.Width = 100;
            // 
            // AddUser_bttn
            // 
            this.AddUser_bttn.Location = new System.Drawing.Point(679, 36);
            this.AddUser_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUser_bttn.Name = "AddUser_bttn";
            this.AddUser_bttn.Size = new System.Drawing.Size(108, 31);
            this.AddUser_bttn.TabIndex = 2;
            this.AddUser_bttn.Text = "Add User";
            this.AddUser_bttn.UseVisualStyleBackColor = true;
            this.AddUser_bttn.Click += new System.EventHandler(this.AddUser_bttn_Click);
            // 
            // filter_txtbox
            // 
            this.filter_txtbox.Location = new System.Drawing.Point(36, 42);
            this.filter_txtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter_txtbox.Name = "filter_txtbox";
            this.filter_txtbox.Size = new System.Drawing.Size(245, 23);
            this.filter_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Management";
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 761);
            this.Controls.Add(this.UserManagement_Pnl);
            this.Controls.Add(this.pnlDashBoard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainViewForm";
            this.Text = "MainViewForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashBoard.ResumeLayout(false);
            this.pnlDashBoard.PerformLayout();
            this.UserManagement_Pnl.ResumeLayout(false);
            this.UserManagement_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DashBoardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Panel PieChartWrapper;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Panel UserManagement_Pnl;
        private System.Windows.Forms.Button FilterUsersByEmail_bttn;
        private System.Windows.Forms.ListView User_lstView;
        private System.Windows.Forms.ColumnHeader IdHeader;
        private System.Windows.Forms.ColumnHeader EmailHeader1;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader locationHeader;
        private System.Windows.Forms.ColumnHeader TicketsHeader;
        private System.Windows.Forms.Button AddUser_bttn;
        private System.Windows.Forms.TextBox filter_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PieChartWrapper2;
    }
}