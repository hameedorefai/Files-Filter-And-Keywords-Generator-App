namespace FilesFilterApp
{
    partial class frmListCourses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCourses));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.cmsCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageKeywordsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pbCoursesList = new System.Windows.Forms.PictureBox();
            this.pbAddNewCourse = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKeywordsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cbNotCheckedCourses = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.cmsCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoursesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewCourse)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(739, 578);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 36);
            this.btnClose.TabIndex = 101;
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
            this.lblTitle.Location = new System.Drawing.Point(308, 88);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 47);
            this.lblTitle.TabIndex = 99;
            this.lblTitle.Text = "Manage Courses";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(212, 580);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(24, 18);
            this.lblRecordsCount.TabIndex = 98;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 97;
            this.label2.Text = "# Courses Count  :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Course ID",
            "Course No.",
            "Course Name",
            "Course Path",
            "Checked Courses"});
            this.cbFilterBy.Location = new System.Drawing.Point(149, 152);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(159, 21);
            this.cbFilterBy.TabIndex = 96;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(315, 153);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(131, 20);
            this.txtFilterValue.TabIndex = 95;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-71, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 94;
            this.label1.Text = "Filter By:";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.ContextMenuStrip = this.cmsCourses;
            this.dgvCourses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCourses.Location = new System.Drawing.Point(61, 197);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(803, 371);
            this.dgvCourses.TabIndex = 93;
            this.dgvCourses.TabStop = false;
            this.dgvCourses.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCourses_CellMouseDoubleClick);
            // 
            // cmsCourses
            // 
            this.cmsCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.ManageKeywordsStripMenuItem,
            this.toolStripSeparator1});
            this.cmsCourses.Name = "contextMenuStrip1";
            this.cmsCourses.Size = new System.Drawing.Size(172, 38);
            this.cmsCourses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsCourses_Opening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // ManageKeywordsStripMenuItem
            // 
            this.ManageKeywordsStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageKeywordsStripMenuItem.Name = "ManageKeywordsStripMenuItem";
            this.ManageKeywordsStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ManageKeywordsStripMenuItem.Text = "Manage Keywords";
            this.ManageKeywordsStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // pbCoursesList
            // 
            this.pbCoursesList.Image = ((System.Drawing.Image)(resources.GetObject("pbCoursesList.Image")));
            this.pbCoursesList.Location = new System.Drawing.Point(407, -1);
            this.pbCoursesList.Margin = new System.Windows.Forms.Padding(1);
            this.pbCoursesList.Name = "pbCoursesList";
            this.pbCoursesList.Size = new System.Drawing.Size(125, 89);
            this.pbCoursesList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoursesList.TabIndex = 102;
            this.pbCoursesList.TabStop = false;
            // 
            // pbAddNewCourse
            // 
            this.pbAddNewCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAddNewCourse.Image = ((System.Drawing.Image)(resources.GetObject("pbAddNewCourse.Image")));
            this.pbAddNewCourse.Location = new System.Drawing.Point(798, 153);
            this.pbAddNewCourse.Name = "pbAddNewCourse";
            this.pbAddNewCourse.Size = new System.Drawing.Size(66, 36);
            this.pbAddNewCourse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewCourse.TabIndex = 103;
            this.pbAddNewCourse.TabStop = false;
            this.toolTip1.SetToolTip(this.pbAddNewCourse, "Add New Course");
            this.pbAddNewCourse.Click += new System.EventHandler(this.pbAddNewCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Filter By:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(593, 578);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 36);
            this.btnRefresh.TabIndex = 105;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(315, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 36);
            this.button1.TabIndex = 106;
            this.button1.Text = "Generate keywords for all courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKeywordsCount
            // 
            this.lblKeywordsCount.AutoSize = true;
            this.lblKeywordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywordsCount.Location = new System.Drawing.Point(212, 600);
            this.lblKeywordsCount.Name = "lblKeywordsCount";
            this.lblKeywordsCount.Size = new System.Drawing.Size(24, 18);
            this.lblKeywordsCount.TabIndex = 109;
            this.lblKeywordsCount.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 108;
            this.label5.Text = "# Keywords Count :";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(212, 603);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(54, 13);
            this.lblLoading.TabIndex = 110;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // cbNotCheckedCourses
            // 
            this.cbNotCheckedCourses.AutoSize = true;
            this.cbNotCheckedCourses.Location = new System.Drawing.Point(61, 179);
            this.cbNotCheckedCourses.Name = "cbNotCheckedCourses";
            this.cbNotCheckedCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNotCheckedCourses.Size = new System.Drawing.Size(182, 17);
            this.cbNotCheckedCourses.TabIndex = 111;
            this.cbNotCheckedCourses.Text = "Show only Not Checked Courses";
            this.cbNotCheckedCourses.UseVisualStyleBackColor = true;
            this.cbNotCheckedCourses.CheckedChanged += new System.EventHandler(this.cbNotCheckedCourses_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmListCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 624);
            this.Controls.Add(this.cbNotCheckedCourses);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblKeywordsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddNewCourse);
            this.Controls.Add(this.pbCoursesList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCourses);
            this.Name = "frmListCourses";
            this.Text = "Courses";
            this.toolTip1.SetToolTip(this, "Add New Course");
            this.Load += new System.EventHandler(this.frmListCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.cmsCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCoursesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewCourse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.PictureBox pbCoursesList;
        private System.Windows.Forms.PictureBox pbAddNewCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsCourses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ManageKeywordsStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblKeywordsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.CheckBox cbNotCheckedCourses;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}