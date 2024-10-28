
namespace StudentGradeManagerView
{
    partial class Teacher
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
            this.dgvTecaherCourse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecaherCourse)).BeginInit();
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
            this.panel2.Controls.Add(this.dgvTecaherCourse);
            this.panel2.Location = new System.Drawing.Point(330, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 448);
            this.panel2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Teacher ID:";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(354, 34);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtAdmin.TabIndex = 34;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(460, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "SEARCH ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvTecaherCourse
            // 
            this.dgvTecaherCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecaherCourse.Location = new System.Drawing.Point(73, 98);
            this.dgvTecaherCourse.Name = "dgvTecaherCourse";
            this.dgvTecaherCourse.Size = new System.Drawing.Size(442, 320);
            this.dgvTecaherCourse.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnViewGrades);
            this.panel1.Controls.Add(this.btnInput);
            this.panel1.Controls.Add(this.btnUpdateAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 448);
            this.panel1.TabIndex = 6;
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(32, 146);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(118, 23);
            this.btnCourse.TabIndex = 9;
            this.btnCourse.Text = "Course List";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(32, 266);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(118, 23);
            this.btnViewGrades.TabIndex = 8;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(32, 224);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(118, 23);
            this.btnInput.TabIndex = 7;
            this.btnInput.Text = "Input Grades";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(32, 185);
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
            this.label1.Location = new System.Drawing.Point(111, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TEACHER";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentGradeManagerView.Properties.Resources.icons8_admin_48;
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
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacher";
            this.Text = "Teacher";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecaherCourse)).EndInit();
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
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvTecaherCourse;
        private System.Windows.Forms.Label label5;
    }
}