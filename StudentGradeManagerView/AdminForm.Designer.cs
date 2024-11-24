
namespace StudentGradeManagerView
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourseAssigned = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnTeacherAcc = new System.Windows.Forms.Button();
            this.btnStudentAcc = new System.Windows.Forms.Button();
            this.btnAdminAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdminList = new System.Windows.Forms.Button();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAdminAcc = new System.Windows.Forms.DataGridView();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAcc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPerformance);
            this.panel1.Controls.Add(this.btnCourseAssigned);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnTeacherAcc);
            this.panel1.Controls.Add(this.btnStudentAcc);
            this.panel1.Controls.Add(this.btnAdminAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(1, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 448);
            this.panel1.TabIndex = 0;
            // 
            // btnCourseAssigned
            // 
            this.btnCourseAssigned.Location = new System.Drawing.Point(28, 328);
            this.btnCourseAssigned.Name = "btnCourseAssigned";
            this.btnCourseAssigned.Size = new System.Drawing.Size(118, 23);
            this.btnCourseAssigned.TabIndex = 9;
            this.btnCourseAssigned.Text = "Assigned Course";
            this.btnCourseAssigned.UseVisualStyleBackColor = true;
            this.btnCourseAssigned.Click += new System.EventHandler(this.btnCourseAssigned_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(28, 287);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(84, 23);
            this.btnCourse.TabIndex = 8;
            this.btnCourse.Text = "Course List";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnTeacherAcc
            // 
            this.btnTeacherAcc.Location = new System.Drawing.Point(28, 249);
            this.btnTeacherAcc.Name = "btnTeacherAcc";
            this.btnTeacherAcc.Size = new System.Drawing.Size(118, 23);
            this.btnTeacherAcc.TabIndex = 7;
            this.btnTeacherAcc.Text = "Teacher Accounts";
            this.btnTeacherAcc.UseVisualStyleBackColor = true;
            this.btnTeacherAcc.Click += new System.EventHandler(this.btnTeacherAcc_Click);
            // 
            // btnStudentAcc
            // 
            this.btnStudentAcc.Location = new System.Drawing.Point(28, 170);
            this.btnStudentAcc.Name = "btnStudentAcc";
            this.btnStudentAcc.Size = new System.Drawing.Size(118, 23);
            this.btnStudentAcc.TabIndex = 6;
            this.btnStudentAcc.Text = "Student Accounts";
            this.btnStudentAcc.UseVisualStyleBackColor = true;
            this.btnStudentAcc.Click += new System.EventHandler(this.btnStudentAcc_Click);
            // 
            // btnAdminAcc
            // 
            this.btnAdminAcc.Location = new System.Drawing.Point(28, 131);
            this.btnAdminAcc.Name = "btnAdminAcc";
            this.btnAdminAcc.Size = new System.Drawing.Size(118, 23);
            this.btnAdminAcc.TabIndex = 5;
            this.btnAdminAcc.Text = "Admin Accounts";
            this.btnAdminAcc.UseVisualStyleBackColor = true;
            this.btnAdminAcc.Click += new System.EventHandler(this.btnAdminAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADMIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentGradeManagerView.Properties.Resources.icons8_administrator_male_26;
            this.pictureBox2.Location = new System.Drawing.Point(105, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdminList);
            this.panel2.Controls.Add(this.lblAdminID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtAdmin);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dgvAdminAcc);
            this.panel2.Location = new System.Drawing.Point(329, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 448);
            this.panel2.TabIndex = 1;
            // 
            // btnAdminList
            // 
            this.btnAdminList.Location = new System.Drawing.Point(425, 392);
            this.btnAdminList.Name = "btnAdminList";
            this.btnAdminList.Size = new System.Drawing.Size(118, 23);
            this.btnAdminList.TabIndex = 32;
            this.btnAdminList.Text = "Admin Accounts";
            this.btnAdminList.UseVisualStyleBackColor = true;
            this.btnAdminList.Click += new System.EventHandler(this.btnAdminList_Click);
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(116, 96);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(73, 16);
            this.lblAdminID.TabIndex = 22;
            this.lblAdminID.Text = "Admin ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Admin ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(119, 252);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(119, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Full Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(119, 155);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(174, 22);
            this.txtFullName.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 315);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE ADMIN";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(157, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE ADMIN";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(425, 29);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtAdmin.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "SEARCH ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvAdminAcc
            // 
            this.dgvAdminAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAcc.Location = new System.Drawing.Point(339, 56);
            this.dgvAdminAcc.Name = "dgvAdminAcc";
            this.dgvAdminAcc.Size = new System.Drawing.Size(276, 320);
            this.dgvAdminAcc.TabIndex = 0;
            // 
            // btnPerformance
            // 
            this.btnPerformance.Location = new System.Drawing.Point(28, 204);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(118, 23);
            this.btnPerformance.TabIndex = 10;
            this.btnPerformance.Text = "Student Peformance";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAcc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnTeacherAcc;
        private System.Windows.Forms.Button btnStudentAcc;
        private System.Windows.Forms.Button btnAdminAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAdminAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Button btnAdminList;
        private System.Windows.Forms.Button btnCourseAssigned;
        private System.Windows.Forms.Button btnPerformance;
    }
}