namespace FreelanceApp
{
    partial class FormSeekerDashboard
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
            this.dataGridViewListJob = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtpCreateday = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtComplexity = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.dataGridViewListProposal = new System.Windows.Forms.DataGridView();
            this.dataGridViewReceivedJobList = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btViewListJob = new System.Windows.Forms.Button();
            this.dtpExpedtedDay = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProposal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedJobList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListJob
            // 
            this.dataGridViewListJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListJob.Location = new System.Drawing.Point(23, 187);
            this.dataGridViewListJob.Name = "dataGridViewListJob";
            this.dataGridViewListJob.RowTemplate.Height = 25;
            this.dataGridViewListJob.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewListJob.TabIndex = 0;
            this.dataGridViewListJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListJob_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View submited proposal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtpCreateday
            // 
            this.dtpCreateday.Location = new System.Drawing.Point(452, 128);
            this.dtpCreateday.Name = "dtpCreateday";
            this.dtpCreateday.Size = new System.Drawing.Size(200, 23);
            this.dtpCreateday.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "payment amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "major";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "complexity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "create date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "expected duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "Project name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(128, 52);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 23);
            this.txtDescription.TabIndex = 42;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(128, 86);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 23);
            this.txtLocation.TabIndex = 41;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(128, 125);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 23);
            this.txtPaymentAmount.TabIndex = 40;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(452, 12);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 23);
            this.txtMajor.TabIndex = 38;
            // 
            // txtComplexity
            // 
            this.txtComplexity.Location = new System.Drawing.Point(452, 52);
            this.txtComplexity.Name = "txtComplexity";
            this.txtComplexity.Size = new System.Drawing.Size(100, 23);
            this.txtComplexity.TabIndex = 37;
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(128, 12);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(100, 23);
            this.txtProjectName.TabIndex = 36;
            // 
            // dataGridViewListProposal
            // 
            this.dataGridViewListProposal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProposal.Location = new System.Drawing.Point(45, 217);
            this.dataGridViewListProposal.Name = "dataGridViewListProposal";
            this.dataGridViewListProposal.RowTemplate.Height = 25;
            this.dataGridViewListProposal.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewListProposal.TabIndex = 52;
            this.dataGridViewListProposal.Visible = false;
            // 
            // dataGridViewReceivedJobList
            // 
            this.dataGridViewReceivedJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceivedJobList.Location = new System.Drawing.Point(71, 253);
            this.dataGridViewReceivedJobList.Name = "dataGridViewReceivedJobList";
            this.dataGridViewReceivedJobList.RowTemplate.Height = 25;
            this.dataGridViewReceivedJobList.Size = new System.Drawing.Size(481, 289);
            this.dataGridViewReceivedJobList.TabIndex = 54;
            this.dataGridViewReceivedJobList.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "View  received job";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btViewListJob
            // 
            this.btViewListJob.Location = new System.Drawing.Point(578, 187);
            this.btViewListJob.Name = "btViewListJob";
            this.btViewListJob.Size = new System.Drawing.Size(180, 23);
            this.btViewListJob.TabIndex = 2;
            this.btViewListJob.Text = "View List Job";
            this.btViewListJob.UseVisualStyleBackColor = true;
            this.btViewListJob.Click += new System.EventHandler(this.btViewListJob_Click);
            // 
            // dtpExpedtedDay
            // 
            this.dtpExpedtedDay.Location = new System.Drawing.Point(452, 89);
            this.dtpExpedtedDay.Name = "dtpExpedtedDay";
            this.dtpExpedtedDay.Size = new System.Drawing.Size(200, 23);
            this.dtpExpedtedDay.TabIndex = 55;
            // 
            // FormSeekerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.dtpExpedtedDay);
            this.Controls.Add(this.dataGridViewReceivedJobList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewListProposal);
            this.Controls.Add(this.dtpCreateday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtComplexity);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.btViewListJob);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewListJob);
            this.Name = "FormSeekerDashboard";
            this.Text = "FormSeekerDashboard";
            this.Load += new System.EventHandler(this.FormSeekerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProposal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceivedJobList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpCreateday;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtComplexity;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.DataGridView dataGridViewListProposal;
        private System.Windows.Forms.DataGridView dataGridViewReceivedJobList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btViewListJob;
        private System.Windows.Forms.DateTimePicker dtpExpedtedDay;
    }
}