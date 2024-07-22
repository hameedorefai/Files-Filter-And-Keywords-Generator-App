namespace FilesFilterApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCourseListForm = new System.Windows.Forms.Button();
            this.txtboxCoursesPath = new System.Windows.Forms.TextBox();
            this.txtboxSourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveSource = new System.Windows.Forms.Button();
            this.btnSaveCoursePath = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLoadingOnFiltering = new System.Windows.Forms.Label();
            this.btnFilterFiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCourseListForm
            // 
            this.btnCourseListForm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCourseListForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseListForm.ForeColor = System.Drawing.Color.Red;
            this.btnCourseListForm.Location = new System.Drawing.Point(270, 25);
            this.btnCourseListForm.Name = "btnCourseListForm";
            this.btnCourseListForm.Size = new System.Drawing.Size(252, 96);
            this.btnCourseListForm.TabIndex = 2;
            this.btnCourseListForm.Text = "Courses";
            this.btnCourseListForm.UseVisualStyleBackColor = false;
            this.btnCourseListForm.Click += new System.EventHandler(this.btnCourseListForm_Click);
            // 
            // txtboxCoursesPath
            // 
            this.txtboxCoursesPath.Enabled = false;
            this.txtboxCoursesPath.Location = new System.Drawing.Point(141, 186);
            this.txtboxCoursesPath.Name = "txtboxCoursesPath";
            this.txtboxCoursesPath.ReadOnly = true;
            this.txtboxCoursesPath.Size = new System.Drawing.Size(247, 20);
            this.txtboxCoursesPath.TabIndex = 3;
            // 
            // txtboxSourcePath
            // 
            this.txtboxSourcePath.Enabled = false;
            this.txtboxSourcePath.Location = new System.Drawing.Point(141, 160);
            this.txtboxSourcePath.Name = "txtboxSourcePath";
            this.txtboxSourcePath.ReadOnly = true;
            this.txtboxSourcePath.Size = new System.Drawing.Size(247, 20);
            this.txtboxSourcePath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source Path   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Courses Path :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveSource
            // 
            this.btnSaveSource.Location = new System.Drawing.Point(475, 160);
            this.btnSaveSource.Name = "btnSaveSource";
            this.btnSaveSource.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSource.TabIndex = 9;
            this.btnSaveSource.Text = "Save";
            this.btnSaveSource.UseVisualStyleBackColor = true;
            this.btnSaveSource.Visible = false;
            this.btnSaveSource.Click += new System.EventHandler(this.btnSaveSource_Click);
            // 
            // btnSaveCoursePath
            // 
            this.btnSaveCoursePath.Location = new System.Drawing.Point(475, 184);
            this.btnSaveCoursePath.Name = "btnSaveCoursePath";
            this.btnSaveCoursePath.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCoursePath.TabIndex = 10;
            this.btnSaveCoursePath.Text = "Save";
            this.btnSaveCoursePath.UseVisualStyleBackColor = true;
            this.btnSaveCoursePath.Visible = false;
            this.btnSaveCoursePath.Click += new System.EventHandler(this.btnSaveCoursePath_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Violet;
            this.button3.Location = new System.Drawing.Point(19, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(531, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblLoadingOnFiltering
            // 
            this.lblLoadingOnFiltering.AutoSize = true;
            this.lblLoadingOnFiltering.Location = new System.Drawing.Point(105, 124);
            this.lblLoadingOnFiltering.Name = "lblLoadingOnFiltering";
            this.lblLoadingOnFiltering.Size = new System.Drawing.Size(54, 13);
            this.lblLoadingOnFiltering.TabIndex = 12;
            this.lblLoadingOnFiltering.Text = "Loading...";
            this.lblLoadingOnFiltering.Visible = false;
            // 
            // btnFilterFiles
            // 
            this.btnFilterFiles.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilterFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterFiles.ForeColor = System.Drawing.Color.Red;
            this.btnFilterFiles.Location = new System.Drawing.Point(12, 25);
            this.btnFilterFiles.Name = "btnFilterFiles";
            this.btnFilterFiles.Size = new System.Drawing.Size(252, 96);
            this.btnFilterFiles.TabIndex = 13;
            this.btnFilterFiles.Text = "Filter Files";
            this.btnFilterFiles.UseVisualStyleBackColor = false;
            this.btnFilterFiles.Click += new System.EventHandler(this.btnFilterFiles_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 284);
            this.Controls.Add(this.btnFilterFiles);
            this.Controls.Add(this.lblLoadingOnFiltering);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSaveCoursePath);
            this.Controls.Add(this.btnSaveSource);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxSourcePath);
            this.Controls.Add(this.txtboxCoursesPath);
            this.Controls.Add(this.btnCourseListForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Files Filter App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCourseListForm;
        private System.Windows.Forms.TextBox txtboxCoursesPath;
        private System.Windows.Forms.TextBox txtboxSourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnSaveSource;
        private System.Windows.Forms.Button btnSaveCoursePath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLoadingOnFiltering;
        private System.Windows.Forms.Button btnFilterFiles;
    }
}

