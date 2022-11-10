namespace UI
{
    partial class DashboardViewForm
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
            this.lblTest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PieChartWrapper = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PieChartWrapper);
            this.panel1.Controls.Add(this.lblTest);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(64, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 423);
            this.panel1.TabIndex = 3;
            // 
            // PieChartWrapper
            // 
            this.PieChartWrapper.Location = new System.Drawing.Point(597, 62);
            this.PieChartWrapper.Name = "PieChartWrapper";
            this.PieChartWrapper.Size = new System.Drawing.Size(201, 201);
            this.PieChartWrapper.TabIndex = 3;
            // 
            // DashboardViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 829);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "DashboardViewForm";
            this.Text = "DashboardView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PieChartWrapper;
    }
}