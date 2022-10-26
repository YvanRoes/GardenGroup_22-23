namespace UI
{
    partial class AddUserView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cancel_bttn = new System.Windows.Forms.Button();
            this.Add_bttn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TypeUser_cmbBox = new System.Windows.Forms.ComboBox();
            this.Location_cmbBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type of User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location Branch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Send Password?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(181, 339);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(334, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Yes, a password e-mail will be sent to the user";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cancel_bttn
            // 
            this.Cancel_bttn.Location = new System.Drawing.Point(114, 401);
            this.Cancel_bttn.Name = "Cancel_bttn";
            this.Cancel_bttn.Size = new System.Drawing.Size(126, 50);
            this.Cancel_bttn.TabIndex = 7;
            this.Cancel_bttn.Text = "CANCEL";
            this.Cancel_bttn.UseVisualStyleBackColor = true;
            this.Cancel_bttn.Click += new System.EventHandler(this.Cancel_bttn_Click);
            // 
            // Add_bttn
            // 
            this.Add_bttn.Location = new System.Drawing.Point(304, 401);
            this.Add_bttn.Name = "Add_bttn";
            this.Add_bttn.Size = new System.Drawing.Size(115, 50);
            this.Add_bttn.TabIndex = 8;
            this.Add_bttn.Text = "ADD USER";
            this.Add_bttn.UseVisualStyleBackColor = true;
            this.Add_bttn.Click += new System.EventHandler(this.Add_bttn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(114, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "Create new user";
            // 
            // TypeUser_cmbBox
            // 
            this.TypeUser_cmbBox.FormattingEnabled = true;
            this.TypeUser_cmbBox.Location = new System.Drawing.Point(181, 136);
            this.TypeUser_cmbBox.Name = "TypeUser_cmbBox";
            this.TypeUser_cmbBox.Size = new System.Drawing.Size(238, 28);
            this.TypeUser_cmbBox.TabIndex = 10;
            // 
            // Location_cmbBox
            // 
            this.Location_cmbBox.FormattingEnabled = true;
            this.Location_cmbBox.Location = new System.Drawing.Point(181, 282);
            this.Location_cmbBox.Name = "Location_cmbBox";
            this.Location_cmbBox.Size = new System.Drawing.Size(238, 28);
            this.Location_cmbBox.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 27);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 27);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(238, 27);
            this.textBox3.TabIndex = 14;
            // 
            // AddUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Location_cmbBox);
            this.Controls.Add(this.TypeUser_cmbBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_bttn);
            this.Controls.Add(this.Cancel_bttn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUserView";
            this.Text = "AddUserView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Cancel_bttn;
        private System.Windows.Forms.Button Add_bttn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TypeUser_cmbBox;
        private System.Windows.Forms.ComboBox Location_cmbBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}