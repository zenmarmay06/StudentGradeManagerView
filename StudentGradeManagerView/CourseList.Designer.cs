
namespace StudentGradeManagerView
{
    partial class CourseList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvAdminAcc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnTeacherAcc = new System.Windows.Forms.Button();
            this.btnStudentAcc = new System.Windows.Forms.Button();
            this.btnAdminAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAcc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCourseID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFullName);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtAdmin);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dgvAdminAcc);
            this.panel2.Location = new System.Drawing.Point(330, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 448);
            this.panel2.TabIndex = 4;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.Location = new System.Drawing.Point(132, 169);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(74, 16);
            this.lblCourseID.TabIndex = 31;
            this.lblCourseID.Text = "Admin ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Course ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Course Name:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(145, 205);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(164, 22);
            this.txtFullName.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE COURSE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(165, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE COURSE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD COURSE";
            this.btnAdd.UseVisualStyleBackColor = true;
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
            // 
            // dgvAdminAcc
            // 
            this.dgvAdminAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAcc.Location = new System.Drawing.Point(338, 55);
            this.dgvAdminAcc.Name = "dgvAdminAcc";
            this.dgvAdminAcc.Size = new System.Drawing.Size(276, 320);
            this.dgvAdminAcc.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnTeacherAcc);
            this.panel1.Controls.Add(this.btnStudentAcc);
            this.panel1.Controls.Add(this.btnAdminAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 448);
            this.panel1.TabIndex = 3;
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(28, 247);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(84, 23);
            this.btnCourse.TabIndex = 8;
            this.btnCourse.Text = "Course List";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnTeacherAcc
            // 
            this.btnTeacherAcc.Location = new System.Drawing.Point(28, 209);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentGradeManagerView.Properties.Resources.z241;
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CourseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CourseList";
            this.Text = "CourseList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAcc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvAdminAcc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnTeacherAcc;
        private System.Windows.Forms.Button btnStudentAcc;
        private System.Windows.Forms.Button btnAdminAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label label5;
    }
}