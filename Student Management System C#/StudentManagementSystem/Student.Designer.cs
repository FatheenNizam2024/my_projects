namespace StudentManagementSystem
{
    partial class frmStudent
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
            this.student = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateofBirth = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.txtstudent = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dtbdob = new System.Windows.Forms.DateTimePicker();
            this.rtbaddress = new System.Windows.Forms.RichTextBox();
            this.rdbmale = new System.Windows.Forms.RadioButton();
            this.rdbfemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btndisplayall = new System.Windows.Forms.Button();
            this.btnclear1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.BackColor = System.Drawing.Color.Black;
            this.student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.ForeColor = System.Drawing.Color.White;
            this.student.Location = new System.Drawing.Point(21, 106);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(169, 34);
            this.student.TabIndex = 0;
            this.student.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateofBirth
            // 
            this.DateofBirth.AutoSize = true;
            this.DateofBirth.BackColor = System.Drawing.Color.Black;
            this.DateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofBirth.ForeColor = System.Drawing.Color.White;
            this.DateofBirth.Location = new System.Drawing.Point(21, 267);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(174, 36);
            this.DateofBirth.TabIndex = 1;
            this.DateofBirth.Text = "DateofBirth";
            this.DateofBirth.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.AutoSize = true;
            this.txtaddress.BackColor = System.Drawing.Color.Black;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.White;
            this.txtaddress.Location = new System.Drawing.Point(21, 364);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(133, 36);
            this.txtaddress.TabIndex = 1;
            this.txtaddress.Text = "Address";
            this.txtaddress.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Black;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.ForeColor = System.Drawing.Color.White;
            this.lblgender.Location = new System.Drawing.Point(21, 565);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(120, 36);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Gender";
            this.lblgender.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtstudent
            // 
            this.txtstudent.Location = new System.Drawing.Point(267, 119);
            this.txtstudent.Name = "txtstudent";
            this.txtstudent.Size = new System.Drawing.Size(259, 22);
            this.txtstudent.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(267, 200);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(259, 22);
            this.txtname.TabIndex = 4;
            // 
            // dtbdob
            // 
            this.dtbdob.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbdob.Location = new System.Drawing.Point(267, 278);
            this.dtbdob.Name = "dtbdob";
            this.dtbdob.Size = new System.Drawing.Size(159, 22);
            this.dtbdob.TabIndex = 5;
            // 
            // rtbaddress
            // 
            this.rtbaddress.Location = new System.Drawing.Point(190, 377);
            this.rtbaddress.Name = "rtbaddress";
            this.rtbaddress.Size = new System.Drawing.Size(378, 161);
            this.rtbaddress.TabIndex = 6;
            this.rtbaddress.Text = "";
            // 
            // rdbmale
            // 
            this.rdbmale.AutoSize = true;
            this.rdbmale.BackColor = System.Drawing.Color.Transparent;
            this.rdbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbmale.Location = new System.Drawing.Point(223, 569);
            this.rdbmale.Name = "rdbmale";
            this.rdbmale.Size = new System.Drawing.Size(91, 33);
            this.rdbmale.TabIndex = 7;
            this.rdbmale.TabStop = true;
            this.rdbmale.Text = "Male";
            this.rdbmale.UseVisualStyleBackColor = false;
            // 
            // rdbfemale
            // 
            this.rdbfemale.AutoSize = true;
            this.rdbfemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfemale.Location = new System.Drawing.Point(393, 569);
            this.rdbfemale.Name = "rdbfemale";
            this.rdbfemale.Size = new System.Drawing.Size(122, 33);
            this.rdbfemale.TabIndex = 8;
            this.rdbfemale.TabStop = true;
            this.rdbfemale.Text = "Female";
            this.rdbfemale.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(954, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 45);
            this.label6.TabIndex = 9;
            this.label6.Text = "STUDENT FORM";
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(617, 191);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(117, 40);
            this.btninsert.TabIndex = 10;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1767, 720);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(117, 40);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(617, 632);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(117, 40);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(617, 526);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(117, 40);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 636);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 36);
            this.label7.TabIndex = 21;
            this.label7.Text = "ContactNo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(267, 650);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(259, 22);
            this.txtcontact.TabIndex = 22;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(617, 292);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(117, 37);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(617, 403);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(117, 40);
            this.btnview.TabIndex = 26;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 720);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 27;
            this.label1.Text = "Class";
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(267, 733);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(259, 22);
            this.txtclass.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(782, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 326);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btndisplay
            // 
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(800, 553);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(136, 65);
            this.btndisplay.TabIndex = 30;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btndisplayall
            // 
            this.btndisplayall.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplayall.Location = new System.Drawing.Point(1053, 553);
            this.btndisplayall.Name = "btndisplayall";
            this.btndisplayall.Size = new System.Drawing.Size(180, 65);
            this.btndisplayall.TabIndex = 31;
            this.btndisplayall.Text = "Display All";
            this.btndisplayall.UseVisualStyleBackColor = true;
            this.btndisplayall.Click += new System.EventHandler(this.btndisplayall_Click);
            // 
            // btnclear1
            // 
            this.btnclear1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear1.Location = new System.Drawing.Point(1358, 553);
            this.btnclear1.Name = "btnclear1";
            this.btnclear1.Size = new System.Drawing.Size(117, 65);
            this.btnclear1.TabIndex = 32;
            this.btnclear1.Text = "Clear";
            this.btnclear1.UseVisualStyleBackColor = true;
            this.btnclear1.Click += new System.EventHandler(this.btnclear1_Click);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 792);
            this.Controls.Add(this.btnclear1);
            this.Controls.Add(this.btndisplayall);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbfemale);
            this.Controls.Add(this.rdbmale);
            this.Controls.Add(this.rtbaddress);
            this.Controls.Add(this.dtbdob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtstudent);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.student);
            this.Name = "frmStudent";
            this.Text = "Studentform";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DateofBirth;
        private System.Windows.Forms.Label txtaddress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.TextBox txtstudent;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker dtbdob;
        private System.Windows.Forms.RichTextBox rtbaddress;
        private System.Windows.Forms.RadioButton rdbmale;
        private System.Windows.Forms.RadioButton rdbfemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btndisplayall;
        private System.Windows.Forms.Button btnclear1;
    }
}