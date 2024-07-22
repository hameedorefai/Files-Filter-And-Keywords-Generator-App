using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesFilterApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtboxSourcePath.Text = clsPath.GetSourceFolderPath();
            txtboxCoursesPath.Text = clsPath.GetFilteredFolderPath();
        }
        private void _RefreshMainForm()
        {
            txtboxCoursesPath.Enabled = false;
            txtboxCoursesPath.ReadOnly = true;
            btnSaveCoursePath.Visible = false;

            txtboxSourcePath.Enabled = false;
            txtboxSourcePath.ReadOnly = true;
            btnSaveSource.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //int KeywordsCount = clsKeyword.ProcessCourse(8);

            //if (KeywordsCount == -1)
            //{
            //    MessageBox.Show("Generate Process Was Failed");
            //}
            //else
            //{
            //    MessageBox.Show("Done Generating with Keywords Count : " + KeywordsCount);
            //}
            int FilteredFilesCount = clsFilteringProcess.FilterFiles();

            if (FilteredFilesCount == -1)
            {
                MessageBox.Show("Filter Process Was Failed");
            }
            else
            {
                MessageBox.Show("Done Filtering with Files Count : " + FilteredFilesCount);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCourseListForm_Click(object sender, EventArgs e)
        {
            frmListCourses frm = new frmListCourses();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtboxSourcePath.Enabled = true;
            txtboxSourcePath.ReadOnly = false;
            btnSaveSource.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxCoursesPath.Enabled = true;
            txtboxCoursesPath.ReadOnly = false;
            btnSaveCoursePath.Visible = true;
        }

        private void btnSaveSource_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Save?", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Save and refresh
                if (clsPath.SetSourceFolderPath(txtboxSourcePath.Text))
                {
                    MessageBox.Show("New Path saved Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshMainForm();
                }

                else
                    MessageBox.Show("Course was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSaveCoursePath_Click(object sender, EventArgs e)
        {
            //Perform Save and refresh
            if (clsPath.SetFilteredFolderPath(txtboxCoursesPath.Text))
            {
                MessageBox.Show("New Path saved Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _RefreshMainForm();
            }

            else
                MessageBox.Show("Course was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilterFiles_Click(object sender, EventArgs e)
        {
            lblLoadingOnFiltering.Visible = true;
            int FilteredFilesCount = clsFilteringProcess.FilterFiles();
         //   lblLoadingOnFiltering.Visible = false;

            if (FilteredFilesCount == -1)
            {
                MessageBox.Show("Filter Process Was Failed","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Done Filtering with Files Count : " + FilteredFilesCount, "Done Succefully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
