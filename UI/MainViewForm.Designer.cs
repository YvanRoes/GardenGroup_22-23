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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPastDeadline = new System.Windows.Forms.PictureBox();
            this.pbWithinDeadline = new System.Windows.Forms.PictureBox();
            this.pnlChartWrapperSecondary = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResolved = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblunResolved = new System.Windows.Forms.Label();
            this.pbResolved = new System.Windows.Forms.PictureBox();
            this.pbInProgress = new System.Windows.Forms.PictureBox();
            this.pbunResolved = new System.Windows.Forms.PictureBox();
            this.pnlChartWrapperMain = new System.Windows.Forms.Panel();
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
            this.TicketView_Pnl = new System.Windows.Forms.Panel();
            this.TransferTicket_bttn = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.listView_Tickets = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.label_overview = new System.Windows.Forms.Label();
            this.button_CreateIncident = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.pnlDashBoard.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPastDeadline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWithinDeadline)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResolved)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbunResolved)).BeginInit();
            this.UserManagement_Pnl.SuspendLayout();
            this.TicketView_Pnl.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1684, 24);
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
            this.ticketManagementToolStripMenuItem.Click += new System.EventHandler(this.ticketManagementToolStripMenuItem_Click);
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
            this.pnlDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDashBoard.Controls.Add(this.groupBox2);
            this.pnlDashBoard.Controls.Add(this.groupBox1);
            this.pnlDashBoard.Location = new System.Drawing.Point(10, 73);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(812, 385);
            this.pnlDashBoard.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbPastDeadline);
            this.groupBox2.Controls.Add(this.pbWithinDeadline);
            this.groupBox2.Controls.Add(this.pnlChartWrapperSecondary);
            this.groupBox2.Location = new System.Drawing.Point(407, 62);
            this.groupBox2.MaximumSize = new System.Drawing.Size(382, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 235);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket deadlines";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(265, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Past deadline";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(265, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Within deadline";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPastDeadline
            // 
            this.pbPastDeadline.Location = new System.Drawing.Point(234, 77);
            this.pbPastDeadline.Name = "pbPastDeadline";
            this.pbPastDeadline.Size = new System.Drawing.Size(25, 25);
            this.pbPastDeadline.TabIndex = 6;
            this.pbPastDeadline.TabStop = false;
            // 
            // pbWithinDeadline
            // 
            this.pbWithinDeadline.Location = new System.Drawing.Point(234, 46);
            this.pbWithinDeadline.Name = "pbWithinDeadline";
            this.pbWithinDeadline.Size = new System.Drawing.Size(25, 25);
            this.pbWithinDeadline.TabIndex = 5;
            this.pbWithinDeadline.TabStop = false;
            // 
            // pnlChartWrapperSecondary
            // 
            this.pnlChartWrapperSecondary.Location = new System.Drawing.Point(6, 19);
            this.pnlChartWrapperSecondary.Name = "pnlChartWrapperSecondary";
            this.pnlChartWrapperSecondary.Size = new System.Drawing.Size(201, 201);
            this.pnlChartWrapperSecondary.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.lblResolved);
            this.groupBox1.Controls.Add(this.lblInProgress);
            this.groupBox1.Controls.Add(this.lblunResolved);
            this.groupBox1.Controls.Add(this.pbResolved);
            this.groupBox1.Controls.Add(this.pbInProgress);
            this.groupBox1.Controls.Add(this.pbunResolved);
            this.groupBox1.Controls.Add(this.pnlChartWrapperMain);
            this.groupBox1.Location = new System.Drawing.Point(19, 62);
            this.groupBox1.MaximumSize = new System.Drawing.Size(382, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 235);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets";
            // 
            // lblResolved
            // 
            this.lblResolved.Location = new System.Drawing.Point(265, 108);
            this.lblResolved.Name = "lblResolved";
            this.lblResolved.Size = new System.Drawing.Size(111, 25);
            this.lblResolved.TabIndex = 10;
            this.lblResolved.Text = "Resolved";
            this.lblResolved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInProgress
            // 
            this.lblInProgress.Location = new System.Drawing.Point(265, 77);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(111, 25);
            this.lblInProgress.TabIndex = 9;
            this.lblInProgress.Text = "In progress";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblunResolved
            // 
            this.lblunResolved.Location = new System.Drawing.Point(265, 46);
            this.lblunResolved.Name = "lblunResolved";
            this.lblunResolved.Size = new System.Drawing.Size(111, 25);
            this.lblunResolved.TabIndex = 8;
            this.lblunResolved.Text = "Unresolved";
            this.lblunResolved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbResolved
            // 
            this.pbResolved.Location = new System.Drawing.Point(234, 108);
            this.pbResolved.Name = "pbResolved";
            this.pbResolved.Size = new System.Drawing.Size(25, 25);
            this.pbResolved.TabIndex = 7;
            this.pbResolved.TabStop = false;
            // 
            // pbInProgress
            // 
            this.pbInProgress.Location = new System.Drawing.Point(234, 77);
            this.pbInProgress.Name = "pbInProgress";
            this.pbInProgress.Size = new System.Drawing.Size(25, 25);
            this.pbInProgress.TabIndex = 6;
            this.pbInProgress.TabStop = false;
            // 
            // pbunResolved
            // 
            this.pbunResolved.Location = new System.Drawing.Point(234, 46);
            this.pbunResolved.Name = "pbunResolved";
            this.pbunResolved.Size = new System.Drawing.Size(25, 25);
            this.pbunResolved.TabIndex = 5;
            this.pbunResolved.TabStop = false;
            // 
            // pnlChartWrapperMain
            // 
            this.pnlChartWrapperMain.Location = new System.Drawing.Point(6, 19);
            this.pnlChartWrapperMain.Name = "pnlChartWrapperMain";
            this.pnlChartWrapperMain.Size = new System.Drawing.Size(201, 201);
            this.pnlChartWrapperMain.TabIndex = 4;
            // 
            // UserManagement_Pnl
            // 
            this.UserManagement_Pnl.Controls.Add(this.FilterUsersByEmail_bttn);
            this.UserManagement_Pnl.Controls.Add(this.User_lstView);
            this.UserManagement_Pnl.Controls.Add(this.AddUser_bttn);
            this.UserManagement_Pnl.Controls.Add(this.filter_txtbox);
            this.UserManagement_Pnl.Controls.Add(this.label1);
            this.UserManagement_Pnl.Location = new System.Drawing.Point(12, 473);
            this.UserManagement_Pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserManagement_Pnl.Name = "UserManagement_Pnl";
            this.UserManagement_Pnl.Size = new System.Drawing.Size(798, 345);
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
            this.AddUser_bttn.Click += new System.EventHandler(this.AddUser_btn_Click);
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
            // TicketView_Pnl
            // 
            this.TicketView_Pnl.Controls.Add(this.TransferTicket_bttn);
            this.TicketView_Pnl.Controls.Add(this.button_Filter);
            this.TicketView_Pnl.Controls.Add(this.listView_Tickets);
            this.TicketView_Pnl.Controls.Add(this.textBox_Filter);
            this.TicketView_Pnl.Controls.Add(this.label_overview);
            this.TicketView_Pnl.Controls.Add(this.button_CreateIncident);
            this.TicketView_Pnl.Location = new System.Drawing.Point(828, 87);
            this.TicketView_Pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketView_Pnl.Name = "TicketView_Pnl";
            this.TicketView_Pnl.Size = new System.Drawing.Size(871, 371);
            this.TicketView_Pnl.TabIndex = 14;
            // 
            // TransferTicket_bttn
            // 
            this.TransferTicket_bttn.Location = new System.Drawing.Point(640, 30);
            this.TransferTicket_bttn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TransferTicket_bttn.Name = "TransferTicket_bttn";
            this.TransferTicket_bttn.Size = new System.Drawing.Size(82, 38);
            this.TransferTicket_bttn.TabIndex = 13;
            this.TransferTicket_bttn.Text = "Transfer Ticket";
            this.TransferTicket_bttn.UseVisualStyleBackColor = true;
            this.TransferTicket_bttn.Click += new System.EventHandler(this.TransferTicket_bttn_Click);
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(315, 48);
            this.button_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(82, 22);
            this.button_Filter.TabIndex = 12;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            // 
            // listView_Tickets
            // 
            this.listView_Tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.User,
            this.Subject,
            this.Date,
            this.Status});
            this.listView_Tickets.FullRowSelect = true;
            this.listView_Tickets.HideSelection = false;
            this.listView_Tickets.Location = new System.Drawing.Point(32, 94);
            this.listView_Tickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView_Tickets.MultiSelect = false;
            this.listView_Tickets.Name = "listView_Tickets";
            this.listView_Tickets.Size = new System.Drawing.Size(795, 220);
            this.listView_Tickets.TabIndex = 8;
            this.listView_Tickets.UseCompatibleStateImageBehavior = false;
            this.listView_Tickets.View = System.Windows.Forms.View.Details;
            this.listView_Tickets.SelectedIndexChanged += new System.EventHandler(this.listView_Tickets_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 200;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 150;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 100;
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Location = new System.Drawing.Point(45, 48);
            this.textBox_Filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(245, 23);
            this.textBox_Filter.TabIndex = 11;
            // 
            // label_overview
            // 
            this.label_overview.AutoSize = true;
            this.label_overview.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_overview.Location = new System.Drawing.Point(32, 18);
            this.label_overview.Name = "label_overview";
            this.label_overview.Size = new System.Drawing.Size(34, 25);
            this.label_overview.TabIndex = 9;
            this.label_overview.Text = ". . .";
            // 
            // button_CreateIncident
            // 
            this.button_CreateIncident.Location = new System.Drawing.Point(740, 30);
            this.button_CreateIncident.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_CreateIncident.Name = "button_CreateIncident";
            this.button_CreateIncident.Size = new System.Drawing.Size(86, 38);
            this.button_CreateIncident.TabIndex = 10;
            this.button_CreateIncident.Text = "Create . . .";
            this.button_CreateIncident.UseVisualStyleBackColor = true;
            this.button_CreateIncident.Click += new System.EventHandler(this.button_CreateIncident_Click_1);
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 851);
            this.Controls.Add(this.TicketView_Pnl);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPastDeadline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWithinDeadline)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResolved)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbunResolved)).EndInit();
            this.UserManagement_Pnl.ResumeLayout(false);
            this.UserManagement_Pnl.PerformLayout();
            this.TicketView_Pnl.ResumeLayout(false);
            this.TicketView_Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DashBoardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashBoard;
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
        private System.Windows.Forms.Panel TicketView_Pnl;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.ListView listView_Tickets;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.TextBox textBox_Filter;
        private System.Windows.Forms.Label label_overview;
        private System.Windows.Forms.Button button_CreateIncident;
        private System.Windows.Forms.Button TransferTicket_bttn;
        private System.Windows.Forms.Panel pnlChartWrapperMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResolved;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblunResolved;
        private System.Windows.Forms.PictureBox pbResolved;
        private System.Windows.Forms.PictureBox pbInProgress;
        private System.Windows.Forms.PictureBox pbunResolved;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbPastDeadline;
        private System.Windows.Forms.PictureBox pbWithinDeadline;
        private System.Windows.Forms.Panel pnlChartWrapperSecondary;
    }
}