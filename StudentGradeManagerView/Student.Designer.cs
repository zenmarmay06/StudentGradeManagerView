
namespace StudentGradeManagerView
{
    partial class Student
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudentCourse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourse)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAdmin);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.dgvStudentCourse);
            this.panel2.Location = new System.Drawing.Point(330, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 448);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Student ID:";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(358, 33);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtAdmin.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(464, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "SEARCH ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvStudentCourse
            // 
            this.dgvStudentCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentCourse.Location = new System.Drawing.Point(77, 97);
            this.dgvStudentCourse.Name = "dgvStudentCourse";
            this.dgvStudentCourse.Size = new System.Drawing.Size(442, 320);
            this.dgvStudentCourse.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnUpdateAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 448);
            this.panel1.TabIndex = 3;
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(28, 152);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(118, 23);
            this.btnCourse.TabIndex = 8;
            this.btnCourse.Text = "Course List";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(28, 230);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(118, 23);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View Grades";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(28, 191);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(159, 23);
            this.btnUpdateAcc.TabIndex = 6;
            this.btnUpdateAcc.Text = "Update  Accounts";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENT";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentGradeManagerView.Properties.Resources.icons8_admin_48__2_;
            this.pictureBox2.Location = new System.Drawing.Point(115, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 87);
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
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Text = "Student";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentCourse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudentCourse;
    }
}