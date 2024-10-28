
namespace StudentGradeManagerView
{
    partial class LoginForm
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
            this.btnAdmiN = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmiN
            // 
            this.btnAdmiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmiN.Location = new System.Drawing.Point(66, 233);
            this.btnAdmiN.Name = "btnAdmiN";
            this.btnAdmiN.Size = new System.Drawing.Size(118, 23);
            this.btnAdmiN.TabIndex = 6;
            this.btnAdmiN.Text = "ADMIN";
            this.btnAdmiN.UseVisualStyleBackColor = true;
            this.btnAdmiN.Click += new System.EventHandler(this.btnAdmiN_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.Location = new System.Drawing.Point(281, 233);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(118, 23);
            this.btnTeacher.TabIndex = 8;
            this.btnTeacher.Text = "TEACHER";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(492, 233);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(118, 23);
            this.btnStudent.TabIndex = 10;
            this.btnStudent.Text = "STUDENT";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StudentGradeManagerView.Properties.Resources.icons8_admin_48__2_;
            this.pictureBox3.Location = new System.Drawing.Point(482, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 127);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentGradeManagerView.Properties.Resources.icons8_admin_48;
            this.pictureBox1.Location = new System.Drawing.Point(270, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StudentGradeManagerView.Properties.Resources.icons8_administrator_male_26;
            this.pictureBox2.Location = new System.Drawing.Point(54, 91);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(679, 301);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmiN);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAdmiN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnStudent;
    }
}