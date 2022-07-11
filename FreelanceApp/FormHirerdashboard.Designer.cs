namespace FreelanceApp
{
    partial class FormHirerdashboard
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
            this.dataGridViewListPostedJob = new System.Windows.Forms.DataGridView();
            this.buttonPostAJob = new System.Windows.Forms.Button();
            this.dataGridViewAcceptedJob = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPostedJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceptedJob)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListPostedJob
            // 
            this.dataGridViewListPostedJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListPostedJob.Location = new System.Drawing.Point(22, 143);
            this.dataGridViewListPostedJob.Name = "dataGridViewListPostedJob";
            this.dataGridViewListPostedJob.ReadOnly = true;
            this.dataGridViewListPostedJob.RowTemplate.Height = 25;
            this.dataGridViewListPostedJob.Size = new System.Drawing.Size(575, 368);
            this.dataGridViewListPostedJob.TabIndex = 1;
            // 
            // buttonPostAJob
            // 
            this.buttonPostAJob.Location = new System.Drawing.Point(504, 26);
            this.buttonPostAJob.Name = "buttonPostAJob";
            this.buttonPostAJob.Size = new System.Drawing.Size(75, 23);
            this.buttonPostAJob.TabIndex = 2;
            this.buttonPostAJob.Text = "Post A Job";
            this.buttonPostAJob.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAcceptedJob
            // 
            this.dataGridViewAcceptedJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAcceptedJob.Location = new System.Drawing.Point(55, 184);
            this.dataGridViewAcceptedJob.Name = "dataGridViewAcceptedJob";
            this.dataGridViewAcceptedJob.ReadOnly = true;
            this.dataGridViewAcceptedJob.RowTemplate.Height = 25;
            this.dataGridViewAcceptedJob.Size = new System.Drawing.Size(575, 368);
            this.dataGridViewAcceptedJob.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "View Accepted Job";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(834, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Posted Job";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormHirerdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPostAJob);
            this.Controls.Add(this.dataGridViewAcceptedJob);
            this.Controls.Add(this.dataGridViewListPostedJob);
            this.Name = "FormHirerdashboard";
            this.Text = "FormHirerdashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListPostedJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcceptedJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewListPostedJob;
        private System.Windows.Forms.Button buttonPostAJob;
        private System.Windows.Forms.DataGridView dataGridViewAcceptedJob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}