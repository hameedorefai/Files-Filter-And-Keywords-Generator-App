using System.Windows.Forms;

namespace FilesFilterApp
{
    partial class frmAddCourse
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
            this.txtboxCourseName = new System.Windows.Forms.TextBox();
            this.textboxCourseNo = new System.Windows.Forms.TextBox();
            this.btnSaveAddingCourse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxCourseName
            // 
            this.txtboxCourseName.Location = new System.Drawing.Point(120, 89);
            this.txtboxCourseName.Name = "txtboxCourseName";
            this.txtboxCourseName.Size = new System.Drawing.Size(180, 20);
            this.txtboxCourseName.TabIndex = 2;
            this.txtboxCourseName.TextChanged += new System.EventHandler(this.txtboxCourseName_TextChanged);
            // 
            // textboxCourseNo
            // 
            this.textboxCourseNo.Location = new System.Drawing.Point(120, 127);
            this.textboxCourseNo.Name = "textboxCourseNo";
            this.textboxCourseNo.Size = new System.Drawing.Size(180, 20);
            this.textboxCourseNo.TabIndex = 3;
            this.textboxCourseNo.TextChanged += new System.EventHandler(this.textboxCourseNo_TextChanged);
            // 
            // btnSaveAddingCourse
            // 
            this.btnSaveAddingCourse.Enabled = false;
            this.btnSaveAddingCourse.Location = new System.Drawing.Point(306, 129);
            this.btnSaveAddingCourse.Name = "btnSaveAddingCourse";
            this.btnSaveAddingCourse.Size = new System.Drawing.Size(125, 22);
            this.btnSaveAddingCourse.TabIndex = 4;
            this.btnSaveAddingCourse.Text = "Save";
            this.btnSaveAddingCourse.UseVisualStyleBackColor = true;
            this.btnSaveAddingCourse.Click += new System.EventHandler(this.btnSaveAddingCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Course Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Course Number:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(306, 162);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 102;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(84, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 69);
            this.lblTitle.TabIndex = 103;
            this.lblTitle.Text = "Add New Course";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 210);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveAddingCourse);
            this.Controls.Add(this.textboxCourseNo);
            this.Controls.Add(this.txtboxCourseName);
            this.Name = "frmAddCourse";
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.frmAddUpdateCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtboxCourseName;
        private TextBox textboxCourseNo;
        private Button btnSaveAddingCourse;
        private Label label1;
        private Label label3;
        private Button btnClose;
        private Label lblTitle;
    }
}