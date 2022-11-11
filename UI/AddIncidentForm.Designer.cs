
namespace UI
{
    partial class AddIncidentForm
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelReportedBy = new System.Windows.Forms.Label();
            this.labelCreateIncident = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_IncidentType = new System.Windows.Forms.ComboBox();
            this.comboBox_ReportedBy = new System.Windows.Forms.ComboBox();
            this.comboBox_Priority = new System.Windows.Forms.ComboBox();
            this.comboBox_Deadline = new System.Windows.Forms.ComboBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDateTimeValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AllowDrop = true;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(418, 322);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(401, 50);
            this.textBoxDescription.TabIndex = 44;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(163, 334);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(88, 20);
            this.labelDescription.TabIndex = 39;
            this.labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadline.Location = new System.Drawing.Point(163, 296);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(141, 20);
            this.labelDeadline.TabIndex = 38;
            this.labelDeadline.Text = "Deadline/follow up:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(163, 261);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(59, 20);
            this.labelPriority.TabIndex = 37;
            this.labelPriority.Text = "Priority:";
            // 
            // labelReportedBy
            // 
            this.labelReportedBy.AutoSize = true;
            this.labelReportedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReportedBy.Location = new System.Drawing.Point(163, 190);
            this.labelReportedBy.Name = "labelReportedBy";
            this.labelReportedBy.Size = new System.Drawing.Size(125, 20);
            this.labelReportedBy.TabIndex = 36;
            this.labelReportedBy.Text = "Reported by user:";
            // 
            // labelCreateIncident
            // 
            this.labelCreateIncident.AutoSize = true;
            this.labelCreateIncident.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateIncident.Location = new System.Drawing.Point(311, 53);
            this.labelCreateIncident.Name = "labelCreateIncident";
            this.labelCreateIncident.Size = new System.Drawing.Size(236, 28);
            this.labelCreateIncident.TabIndex = 32;
            this.labelCreateIncident.Text = "Create new incident ticket";
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
            this.menuStrip1.TabIndex = 48;
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
            // comboBox_IncidentType
            // 
            this.comboBox_IncidentType.FormattingEnabled = true;
            this.comboBox_IncidentType.Location = new System.Drawing.Point(418, 217);
            this.comboBox_IncidentType.Name = "comboBox_IncidentType";
            this.comboBox_IncidentType.Size = new System.Drawing.Size(189, 28);
            this.comboBox_IncidentType.TabIndex = 49;
            // 
            // comboBox_ReportedBy
            // 
            this.comboBox_ReportedBy.FormattingEnabled = true;
            this.comboBox_ReportedBy.Location = new System.Drawing.Point(418, 183);
            this.comboBox_ReportedBy.Name = "comboBox_ReportedBy";
            this.comboBox_ReportedBy.Size = new System.Drawing.Size(189, 28);
            this.comboBox_ReportedBy.TabIndex = 50;
            // 
            // comboBox_Priority
            // 
            this.comboBox_Priority.FormattingEnabled = true;
            this.comboBox_Priority.Location = new System.Drawing.Point(418, 253);
            this.comboBox_Priority.Name = "comboBox_Priority";
            this.comboBox_Priority.Size = new System.Drawing.Size(189, 28);
            this.comboBox_Priority.TabIndex = 51;
            // 
            // comboBox_Deadline
            // 
            this.comboBox_Deadline.FormattingEnabled = true;
            this.comboBox_Deadline.Location = new System.Drawing.Point(418, 288);
            this.comboBox_Deadline.Name = "comboBox_Deadline";
            this.comboBox_Deadline.Size = new System.Drawing.Size(189, 28);
            this.comboBox_Deadline.TabIndex = 52;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubject.Location = new System.Drawing.Point(418, 148);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(189, 27);
            this.textBoxSubject.TabIndex = 45;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(163, 227);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(118, 20);
            this.labelType.TabIndex = 35;
            this.labelType.Text = "Type of incident:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubject.Location = new System.Drawing.Point(163, 155);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(136, 20);
            this.labelSubject.TabIndex = 34;
            this.labelSubject.Text = "Subject of incident:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTime.Location = new System.Drawing.Point(163, 123);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(145, 20);
            this.labelDateTime.TabIndex = 33;
            this.labelDateTime.Text = "Date/Time reported:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(173, 407);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 59);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(622, 407);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(146, 59);
            this.buttonSubmit.TabIndex = 47;
            this.buttonSubmit.Text = "SUBMIT TICKET";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelDateTimeValue
            // 
            this.labelDateTimeValue.AutoSize = true;
            this.labelDateTimeValue.Location = new System.Drawing.Point(418, 117);
            this.labelDateTimeValue.Name = "labelDateTimeValue";
            this.labelDateTimeValue.Size = new System.Drawing.Size(50, 20);
            this.labelDateTimeValue.TabIndex = 53;
            this.labelDateTimeValue.Text = "label1";
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.labelDateTimeValue);
            this.Controls.Add(this.comboBox_Deadline);
            this.Controls.Add(this.comboBox_Priority);
            this.Controls.Add(this.comboBox_ReportedBy);
            this.Controls.Add(this.comboBox_IncidentType);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelReportedBy);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.labelCreateIncident);
            this.Name = "AddIncidentForm";
            this.Text = "AddIncidentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelReportedBy;
        private System.Windows.Forms.Label labelCreateIncident;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_IncidentType;
        private System.Windows.Forms.ComboBox comboBox_ReportedBy;
        private System.Windows.Forms.ComboBox comboBox_Priority;
        private System.Windows.Forms.ComboBox comboBox_Deadline;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDateTimeValue;
    }
}