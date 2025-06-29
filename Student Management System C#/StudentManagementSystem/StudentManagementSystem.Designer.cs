namespace StudentManagementSystem
{
    partial class frmSMS
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
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.btnsubjects = new System.Windows.Forms.Button();
            this.btnpayments = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.Transparent;
            this.btnstudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnstudent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.Location = new System.Drawing.Point(231, 129);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(155, 51);
            this.btnstudent.TabIndex = 6;
            this.btnstudent.Text = "STUDENT";
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.BackColor = System.Drawing.Color.Transparent;
            this.btnteacher.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.Location = new System.Drawing.Point(421, 130);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(155, 51);
            this.btnteacher.TabIndex = 7;
            this.btnteacher.Text = "TEACHER";
            this.btnteacher.UseVisualStyleBackColor = false;
            this.btnteacher.Click += new System.EventHandler(this.btnteacher_Click);
            // 
            // btnsubjects
            // 
            this.btnsubjects.BackColor = System.Drawing.Color.Transparent;
            this.btnsubjects.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubjects.Location = new System.Drawing.Point(617, 129);
            this.btnsubjects.Name = "btnsubjects";
            this.btnsubjects.Size = new System.Drawing.Size(155, 51);
            this.btnsubjects.TabIndex = 8;
            this.btnsubjects.Text = "SUBJECTS";
            this.btnsubjects.UseVisualStyleBackColor = false;
            this.btnsubjects.Click += new System.EventHandler(this.btnsubjects_Click);
            // 
            // btnpayments
            // 
            this.btnpayments.BackColor = System.Drawing.Color.Transparent;
            this.btnpayments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayments.Location = new System.Drawing.Point(231, 230);
            this.btnpayments.Name = "btnpayments";
            this.btnpayments.Size = new System.Drawing.Size(155, 51);
            this.btnpayments.TabIndex = 9;
            this.btnpayments.Text = "PAYMENTS";
            this.btnpayments.UseVisualStyleBackColor = false;
            this.btnpayments.Click += new System.EventHandler(this.btnpayments_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(617, 316);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(155, 51);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentManagementSystem.Properties.Resources.resize;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 501);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpayments);
            this.Controls.Add(this.btnsubjects);
            this.Controls.Add(this.btnteacher);
            this.Controls.Add(this.btnstudent);
            this.Name = "frmSMS";
            this.Text = "StudentManagementSystem";
            this.Load += new System.EventHandler(this.frmSMS_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.Button btnsubjects;
        private System.Windows.Forms.Button btnpayments;
        private System.Windows.Forms.Button btnexit;
    }
}