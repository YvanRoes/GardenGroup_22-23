namespace UI
{
    partial class TicketView
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
            this.listView_Tickets = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.User = new System.Windows.Forms.ColumnHeader();
            this.Subject = new System.Windows.Forms.ColumnHeader();
            this.label_overview = new System.Windows.Forms.Label();
            this.button_CreateIncident = new System.Windows.Forms.Button();
            this.button_Filter = new System.Windows.Forms.Button();
            this.textBox_Filter = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.Status = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
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
            // listView_Tickets
            // 
            this.listView_Tickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.User,
            this.Subject,
            this.Date,
            this.Status});
            this.listView_Tickets.HideSelection = false;
            this.listView_Tickets.Location = new System.Drawing.Point(12, 158);
            this.listView_Tickets.Name = "listView_Tickets";
            this.listView_Tickets.Size = new System.Drawing.Size(908, 292);
            this.listView_Tickets.TabIndex = 2;
            this.listView_Tickets.UseCompatibleStateImageBehavior = false;
            this.listView_Tickets.View = System.Windows.Forms.View.Details;
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
            // label_overview
            // 
            this.label_overview.AutoSize = true;
            this.label_overview.Location = new System.Drawing.Point(12, 85);
            this.label_overview.Name = "label_overview";
            this.label_overview.Size = new System.Drawing.Size(113, 20);
            this.label_overview.TabIndex = 3;
            this.label_overview.Text = "Ticket Overview";
            // 
            // button_CreateIncident
            // 
            this.button_CreateIncident.Location = new System.Drawing.Point(777, 85);
            this.button_CreateIncident.Name = "button_CreateIncident";
            this.button_CreateIncident.Size = new System.Drawing.Size(98, 51);
            this.button_CreateIncident.TabIndex = 4;
            this.button_CreateIncident.Text = "Create Incident";
            this.button_CreateIncident.UseVisualStyleBackColor = true;
            // 
            // button_Filter
            // 
            this.button_Filter.Location = new System.Drawing.Point(309, 108);
            this.button_Filter.Name = "button_Filter";
            this.button_Filter.Size = new System.Drawing.Size(94, 29);
            this.button_Filter.TabIndex = 6;
            this.button_Filter.Text = "Filter";
            this.button_Filter.UseVisualStyleBackColor = true;
            this.button_Filter.Click += new System.EventHandler(this.button_Filter_Click);
            // 
            // textBox_Filter
            // 
            this.textBox_Filter.Location = new System.Drawing.Point(12, 109);
            this.textBox_Filter.Name = "textBox_Filter";
            this.textBox_Filter.Size = new System.Drawing.Size(279, 27);
            this.textBox_Filter.TabIndex = 5;
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
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.button_Filter);
            this.Controls.Add(this.textBox_Filter);
            this.Controls.Add(this.button_CreateIncident);
            this.Controls.Add(this.label_overview);
            this.Controls.Add(this.listView_Tickets);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TicketView";
            this.Text = "TicketView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Tickets;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.Label label_overview;
        private System.Windows.Forms.Button button_CreateIncident;
        private System.Windows.Forms.Button button_Filter;
        private System.Windows.Forms.TextBox textBox_Filter;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
    }
}