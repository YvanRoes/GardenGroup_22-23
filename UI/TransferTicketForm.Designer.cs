namespace UI
{
    partial class TransferTicketForm
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
            this.Departments_cmboBox = new System.Windows.Forms.ComboBox();
            this.comment_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Transfer_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Employee_lbl = new System.Windows.Forms.Label();
            this.Employee_cmboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cancel_bttn = new System.Windows.Forms.Button();
            this.transferTicketDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferTicketDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Departments_cmboBox
            // 
            this.Departments_cmboBox.FormattingEnabled = true;
            this.Departments_cmboBox.Location = new System.Drawing.Point(137, 96);
            this.Departments_cmboBox.Name = "Departments_cmboBox";
            this.Departments_cmboBox.Size = new System.Drawing.Size(193, 28);
            this.Departments_cmboBox.TabIndex = 0;
            this.Departments_cmboBox.SelectedIndexChanged += new System.EventHandler(this.Departments_cmboBox_SelectedIndexChanged);
            // 
            // comment_txtBox
            // 
            this.comment_txtBox.Location = new System.Drawing.Point(24, 233);
            this.comment_txtBox.Multiline = true;
            this.comment_txtBox.Name = "comment_txtBox";
            this.comment_txtBox.Size = new System.Drawing.Size(326, 131);
            this.comment_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department :";
            // 
            // Transfer_bttn
            // 
            this.Transfer_bttn.Location = new System.Drawing.Point(189, 396);
            this.Transfer_bttn.Name = "Transfer_bttn";
            this.Transfer_bttn.Size = new System.Drawing.Size(161, 43);
            this.Transfer_bttn.TabIndex = 3;
            this.Transfer_bttn.Text = "Transfer";
            this.Transfer_bttn.UseVisualStyleBackColor = true;
            this.Transfer_bttn.Click += new System.EventHandler(this.Transfer_bttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transfer Ticket";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comment :";
            // 
            // Employee_lbl
            // 
            this.Employee_lbl.AutoSize = true;
            this.Employee_lbl.Location = new System.Drawing.Point(24, 153);
            this.Employee_lbl.Name = "Employee_lbl";
            this.Employee_lbl.Size = new System.Drawing.Size(82, 20);
            this.Employee_lbl.TabIndex = 7;
            this.Employee_lbl.Text = "Employee :";
            // 
            // Employee_cmboBox
            // 
            this.Employee_cmboBox.FormattingEnabled = true;
            this.Employee_cmboBox.Location = new System.Drawing.Point(137, 150);
            this.Employee_cmboBox.Name = "Employee_cmboBox";
            this.Employee_cmboBox.Size = new System.Drawing.Size(193, 28);
            this.Employee_cmboBox.TabIndex = 8;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Model.User);
            // 
            // Cancel_bttn
            // 
            this.Cancel_bttn.Location = new System.Drawing.Point(39, 396);
            this.Cancel_bttn.Name = "Cancel_bttn";
            this.Cancel_bttn.Size = new System.Drawing.Size(123, 43);
            this.Cancel_bttn.TabIndex = 9;
            this.Cancel_bttn.Text = "Cancel";
            this.Cancel_bttn.UseVisualStyleBackColor = true;
            this.Cancel_bttn.Click += new System.EventHandler(this.Cancel_bttn_Click);
            // 
            // transferTicketDAOBindingSource
            // 
            this.transferTicketDAOBindingSource.DataSource = typeof(DAL.TransferTicketDAO);
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(Model.User);
            // 
            // TransferTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 464);
            this.Controls.Add(this.Cancel_bttn);
            this.Controls.Add(this.Employee_cmboBox);
            this.Controls.Add(this.Employee_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Transfer_bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment_txtBox);
            this.Controls.Add(this.Departments_cmboBox);
            this.Name = "TransferTicketForm";
            this.Text = "Transfer Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferTicketDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Departments_cmboBox;
        private System.Windows.Forms.TextBox comment_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Transfer_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Employee_lbl;
        private System.Windows.Forms.ComboBox Employee_cmboBox;
        private System.Windows.Forms.Button Cancel_bttn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource transferTicketDAOBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}