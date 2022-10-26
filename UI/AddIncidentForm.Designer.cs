
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
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.listBoxDeadline = new System.Windows.Forms.ListBox();
            this.listBoxPriority = new System.Windows.Forms.ListBox();
            this.listBoxReportedBy = new System.Windows.Forms.ListBox();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelReportedBy = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelCreateIncident = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSubject.Location = new System.Drawing.Point(292, 168);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(189, 27);
            this.textBoxSubject.TabIndex = 29;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.AllowDrop = true;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(292, 312);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(401, 50);
            this.textBoxDescription.TabIndex = 28;
            // 
            // listBoxDeadline
            // 
            this.listBoxDeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxDeadline.FormattingEnabled = true;
            this.listBoxDeadline.ItemHeight = 20;
            this.listBoxDeadline.Location = new System.Drawing.Point(711, 237);
            this.listBoxDeadline.Name = "listBoxDeadline";
            this.listBoxDeadline.Size = new System.Drawing.Size(189, 24);
            this.listBoxDeadline.TabIndex = 27;
            // 
            // listBoxPriority
            // 
            this.listBoxPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPriority.FormattingEnabled = true;
            this.listBoxPriority.ItemHeight = 20;
            this.listBoxPriority.Location = new System.Drawing.Point(711, 171);
            this.listBoxPriority.Name = "listBoxPriority";
            this.listBoxPriority.Size = new System.Drawing.Size(189, 24);
            this.listBoxPriority.TabIndex = 26;
            // 
            // listBoxReportedBy
            // 
            this.listBoxReportedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxReportedBy.FormattingEnabled = true;
            this.listBoxReportedBy.ItemHeight = 20;
            this.listBoxReportedBy.Location = new System.Drawing.Point(711, 106);
            this.listBoxReportedBy.Name = "listBoxReportedBy";
            this.listBoxReportedBy.Size = new System.Drawing.Size(189, 24);
            this.listBoxReportedBy.TabIndex = 25;
            // 
            // listBoxType
            // 
            this.listBoxType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 20;
            this.listBoxType.Location = new System.Drawing.Point(292, 237);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(189, 24);
            this.listBoxType.TabIndex = 24;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(88, 325);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(88, 20);
            this.labelDescription.TabIndex = 23;
            this.labelDescription.Text = "Description:";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDeadline.Location = new System.Drawing.Point(521, 237);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(141, 20);
            this.labelDeadline.TabIndex = 22;
            this.labelDeadline.Text = "Deadline/follow up:";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriority.Location = new System.Drawing.Point(521, 175);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(59, 20);
            this.labelPriority.TabIndex = 21;
            this.labelPriority.Text = "Priority:";
            // 
            // labelReportedBy
            // 
            this.labelReportedBy.AutoSize = true;
            this.labelReportedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReportedBy.Location = new System.Drawing.Point(521, 106);
            this.labelReportedBy.Name = "labelReportedBy";
            this.labelReportedBy.Size = new System.Drawing.Size(125, 20);
            this.labelReportedBy.TabIndex = 20;
            this.labelReportedBy.Text = "Reported by user:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(88, 237);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(118, 20);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Type of incident:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubject.Location = new System.Drawing.Point(88, 171);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(136, 20);
            this.labelSubject.TabIndex = 18;
            this.labelSubject.Text = "Subject of incident:";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateTime.Location = new System.Drawing.Point(88, 106);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(145, 20);
            this.labelDateTime.TabIndex = 17;
            this.labelDateTime.Text = "Date/Time reported:";
            // 
            // labelCreateIncident
            // 
            this.labelCreateIncident.AutoSize = true;
            this.labelCreateIncident.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCreateIncident.Location = new System.Drawing.Point(391, 54);
            this.labelCreateIncident.Name = "labelCreateIncident";
            this.labelCreateIncident.Size = new System.Drawing.Size(180, 20);
            this.labelCreateIncident.TabIndex = 16;
            this.labelCreateIncident.Text = "Create new incident ticket";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(626, 412);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(146, 59);
            this.buttonSubmit.TabIndex = 31;
            this.buttonSubmit.Text = "SUBMIT TICKET";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(86, 423);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(126, 37);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.listBoxDeadline);
            this.Controls.Add(this.listBoxPriority);
            this.Controls.Add(this.listBoxReportedBy);
            this.Controls.Add(this.listBoxType);
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
            this.Load += new System.EventHandler(this.AddIncidentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ListBox listBoxDeadline;
        private System.Windows.Forms.ListBox listBoxPriority;
        private System.Windows.Forms.ListBox listBoxReportedBy;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelReportedBy;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelCreateIncident;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}