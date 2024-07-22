namespace FilesFilterApp
{
    partial class frmManageKeywords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageKeywords));
            this.dgvKeywords = new System.Windows.Forms.DataGridView();
            this.cmsKeywords = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowKeywordstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblKeywordsCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtboxAddNewKeyword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGenerateKeywords = new System.Windows.Forms.Label();
            this.lblKeywordDeletedSuccefully = new System.Windows.Forms.Label();
            this.lblLoading1 = new System.Windows.Forms.Label();
            this.lblLoading2 = new System.Windows.Forms.Label();
            this.lblLoading3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbCheckedFalse = new System.Windows.Forms.PictureBox();
            this.pbCheckedTrue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).BeginInit();
            this.cmsKeywords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKeywords
            // 
            this.dgvKeywords.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKeywords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeywords.ContextMenuStrip = this.cmsKeywords;
            this.dgvKeywords.GridColor = System.Drawing.Color.Black;
            this.dgvKeywords.Location = new System.Drawing.Point(245, 202);
            this.dgvKeywords.Name = "dgvKeywords";
            this.dgvKeywords.Size = new System.Drawing.Size(533, 293);
            this.dgvKeywords.TabIndex = 0;
            this.dgvKeywords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeywords_CellContentClick);
            this.dgvKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvKeywords_KeyDown);
            // 
            // cmsKeywords
            // 
            this.cmsKeywords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.ShowKeywordstoolStripMenuItem,
            this.toolStripSeparator1});
            this.cmsKeywords.Name = "contextMenuStrip1";
            this.cmsKeywords.Size = new System.Drawing.Size(108, 38);
            this.cmsKeywords.Opening += new System.ComponentModel.CancelEventHandler(this.cmsKeywords_Opening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // ShowKeywordstoolStripMenuItem
            // 
            this.ShowKeywordstoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowKeywordstoolStripMenuItem.Name = "ShowKeywordstoolStripMenuItem";
            this.ShowKeywordstoolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.ShowKeywordstoolStripMenuItem.Text = "Delete";
            this.ShowKeywordstoolStripMenuItem.Click += new System.EventHandler(this.ShowKeywordstoolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // lblKeywordsCount
            // 
            this.lblKeywordsCount.AutoSize = true;
            this.lblKeywordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywordsCount.Location = new System.Drawing.Point(182, 169);
            this.lblKeywordsCount.Name = "lblKeywordsCount";
            this.lblKeywordsCount.Size = new System.Drawing.Size(30, 24);
            this.lblKeywordsCount.TabIndex = 99;
            this.lblKeywordsCount.Text = "??";
            this.lblKeywordsCount.Click += new System.EventHandler(this.lblKeywordsCount_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(6, 356);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(185, 67);
            this.btnRefresh.TabIndex = 107;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Crimson;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(6, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(185, 66);
            this.btnClose.TabIndex = 106;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(182, 131);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(40, 24);
            this.lblCourseName.TabIndex = 108;
            this.lblCourseName.Text = "null";
            this.lblCourseName.Click += new System.EventHandler(this.lblCourseName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 109;
            this.label3.Text = "Course Name     :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "Keywords Count :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 112;
            this.label4.Text = "Add New Keyword :";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(152, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(469, 48);
            this.lblTitle.TabIndex = 114;
            this.lblTitle.Text = "Manage Keywords";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxAddNewKeyword
            // 
            this.txtboxAddNewKeyword.ForeColor = System.Drawing.Color.Gray;
            this.txtboxAddNewKeyword.Location = new System.Drawing.Point(14, 252);
            this.txtboxAddNewKeyword.Name = "txtboxAddNewKeyword";
            this.txtboxAddNewKeyword.Size = new System.Drawing.Size(156, 20);
            this.txtboxAddNewKeyword.TabIndex = 115;
            this.txtboxAddNewKeyword.TextChanged += new System.EventHandler(this.txtboxAddNewKeyword_TextChanged);
            this.txtboxAddNewKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxAddNewKeyword_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(14, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 116;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGenerateKeywords
            // 
            this.lblGenerateKeywords.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblGenerateKeywords.AutoSize = true;
            this.lblGenerateKeywords.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGenerateKeywords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenerateKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateKeywords.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblGenerateKeywords.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblGenerateKeywords.Location = new System.Drawing.Point(5, 321);
            this.lblGenerateKeywords.Name = "lblGenerateKeywords";
            this.lblGenerateKeywords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGenerateKeywords.Size = new System.Drawing.Size(189, 13);
            this.lblGenerateKeywords.TabIndex = 101;
            this.lblGenerateKeywords.Text = "Generate Keywords Automaticlly";
            this.lblGenerateKeywords.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKeywordDeletedSuccefully
            // 
            this.lblKeywordDeletedSuccefully.AutoSize = true;
            this.lblKeywordDeletedSuccefully.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywordDeletedSuccefully.ForeColor = System.Drawing.Color.DimGray;
            this.lblKeywordDeletedSuccefully.Location = new System.Drawing.Point(250, 169);
            this.lblKeywordDeletedSuccefully.Name = "lblKeywordDeletedSuccefully";
            this.lblKeywordDeletedSuccefully.Size = new System.Drawing.Size(205, 20);
            this.lblKeywordDeletedSuccefully.TabIndex = 117;
            this.lblKeywordDeletedSuccefully.Text = "Keyword Deleted Succefully";
            // 
            // lblLoading1
            // 
            this.lblLoading1.AutoSize = true;
            this.lblLoading1.Location = new System.Drawing.Point(64, 334);
            this.lblLoading1.Name = "lblLoading1";
            this.lblLoading1.Size = new System.Drawing.Size(48, 13);
            this.lblLoading1.TabIndex = 118;
            this.lblLoading1.Text = "Loading.";
            // 
            // lblLoading2
            // 
            this.lblLoading2.AutoSize = true;
            this.lblLoading2.Location = new System.Drawing.Point(64, 334);
            this.lblLoading2.Name = "lblLoading2";
            this.lblLoading2.Size = new System.Drawing.Size(51, 13);
            this.lblLoading2.TabIndex = 119;
            this.lblLoading2.Text = "Loading.,";
            // 
            // lblLoading3
            // 
            this.lblLoading3.AutoSize = true;
            this.lblLoading3.Location = new System.Drawing.Point(64, 334);
            this.lblLoading3.Name = "lblLoading3";
            this.lblLoading3.Size = new System.Drawing.Size(54, 13);
            this.lblLoading3.TabIndex = 120;
            this.lblLoading3.Text = "Loading.,.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 121;
            this.label2.Text = "Has Checked      :";
            // 
            // pbCheckedFalse
            // 
            this.pbCheckedFalse.Image = ((System.Drawing.Image)(resources.GetObject("pbCheckedFalse.Image")));
            this.pbCheckedFalse.Location = new System.Drawing.Point(168, 202);
            this.pbCheckedFalse.Name = "pbCheckedFalse";
            this.pbCheckedFalse.Size = new System.Drawing.Size(54, 24);
            this.pbCheckedFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheckedFalse.TabIndex = 122;
            this.pbCheckedFalse.TabStop = false;
            this.pbCheckedFalse.Click += new System.EventHandler(this.pbCheckedFalse_Click);
            // 
            // pbCheckedTrue
            // 
            this.pbCheckedTrue.Image = global::FilesFilterApp.Properties.Resources.Checked;
            this.pbCheckedTrue.Location = new System.Drawing.Point(168, 202);
            this.pbCheckedTrue.Name = "pbCheckedTrue";
            this.pbCheckedTrue.Size = new System.Drawing.Size(54, 24);
            this.pbCheckedTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCheckedTrue.TabIndex = 123;
            this.pbCheckedTrue.TabStop = false;
            this.pbCheckedTrue.Click += new System.EventHandler(this.pbCheckedTrue_Click);
            // 
            // frmManageKeywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.pbCheckedTrue);
            this.Controls.Add(this.pbCheckedFalse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLoading3);
            this.Controls.Add(this.lblLoading2);
            this.Controls.Add(this.lblLoading1);
            this.Controls.Add(this.lblKeywordDeletedSuccefully);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxAddNewKeyword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblGenerateKeywords);
            this.Controls.Add(this.lblKeywordsCount);
            this.Controls.Add(this.dgvKeywords);
            this.Name = "frmManageKeywords";
            this.Text = "Keywords";
            this.Load += new System.EventHandler(this.frmAddKeyword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeywords)).EndInit();
            this.cmsKeywords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheckedTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKeywords;
        private System.Windows.Forms.Label lblKeywordsCount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtboxAddNewKeyword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip cmsKeywords;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShowKeywordstoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblGenerateKeywords;
        private System.Windows.Forms.Label lblKeywordDeletedSuccefully;
        private System.Windows.Forms.Label lblLoading1;
        private System.Windows.Forms.Label lblLoading2;
        private System.Windows.Forms.Label lblLoading3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbCheckedFalse;
        private System.Windows.Forms.PictureBox pbCheckedTrue;
    }
}