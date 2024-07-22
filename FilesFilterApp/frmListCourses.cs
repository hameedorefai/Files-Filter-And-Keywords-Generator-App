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
using System.Threading;
namespace FilesFilterApp
{
    public partial class frmListCourses : Form
    {
        Thread threadCountKeywords;
        private static DataTable _dtAllCourses = clsCourse.GetAllCoursesInfo();
        private static DataTable _dtAllNotCheckedCourses = clsCourse.GetAllNotCheckedCoursesInfo();

        //only select the columns that you want to show in the grid
        private DataTable _dtCourses = _dtAllCourses.DefaultView.ToTable(false, "CourseID", "CourseName", "CourseNumber", "HasChecked");
        private DataTable _dtNotCheckedCourses = _dtAllCourses.DefaultView.ToTable(false, "CourseID", "CourseName", "CourseNumber", "HasChecked");
  //      toolTip1_Popup.SetToolTip(pbAddNewCourse_Click, "Text to display on hover");

         public void _RefreshCoursesList()
        {
            _dtAllCourses = clsCourse.GetAllCoursesInfo();
            _dtCourses = _dtAllCourses.DefaultView.ToTable(false, "CourseID", "CourseName", "CourseNumber", "HasChecked");
            _dtNotCheckedCourses = _dtAllNotCheckedCourses.DefaultView.ToTable(false, "CourseID", "CourseName", "CourseNumber", "HasChecked");

            dgvCourses.DataSource = _dtCourses;
            lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
            lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();
            cbNotCheckedCoursesRefresh();
        }
        
        public frmListCourses()
        {
            InitializeComponent();
        }

        private void frmListCourses_Load(object sender, EventArgs e)
        {

            dgvCourses.DataSource = _dtCourses;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
            if (dgvCourses.Rows.Count > 0)
            {

                dgvCourses.Columns[0].HeaderText = "Course ID";
                dgvCourses.Columns[0].Width = 110;

                dgvCourses.Columns[1].HeaderText = "Course Name";
                dgvCourses.Columns[1].Width = 240;


                dgvCourses.Columns[2].HeaderText = "Course Number.";
                dgvCourses.Columns[2].Width = 110;

                dgvCourses.Columns[3].HeaderText = "Checked";
                dgvCourses.Columns[3].Width = 300;
            }
            lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();

        }
        private void frmListNotCheckedCourses_Load(object sender, EventArgs e)
        {

            dgvCourses.DataSource = _dtNotCheckedCourses;
            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
            if (dgvCourses.Rows.Count > 0)
            {

                dgvCourses.Columns[0].HeaderText = "Course ID";
                dgvCourses.Columns[0].Width = 110;

                dgvCourses.Columns[1].HeaderText = "Course Name";
                dgvCourses.Columns[1].Width = 240;


                dgvCourses.Columns[2].HeaderText = "Course Number.";
                dgvCourses.Columns[2].Width = 110;

                dgvCourses.Columns[3].HeaderText = "Checked";
                dgvCourses.Columns[3].Width = 300;
            }
            lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();

        }
        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Course ID":
                    FilterColumn = "CourseID";
                    break;

                case "Course No.":
                    FilterColumn = "CourseNo";
                    break;

                case "Course Name":
                    FilterColumn = "CourseName";
                    break;

                case "Course Path":
                    FilterColumn = "CoursePath";
                    break;
                case "Checked Courses":
                    FilterColumn = "HasChecked";
                    break;
                default:
                    FilterColumn = "None";
                    break;

            }

            //Reset the filters in case nothing selected or filter value contains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtCourses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
                lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();
            }


            if (FilterColumn == "CourseID" || FilterColumn == "CourseNo")
                //in this case we deal with integer not string.
                _dtCourses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtCourses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            //if (FilterColumn == "CourseID" || FilterColumn == "CourseNo")
            //{
            //    // تحقق من أن المدخلات عبارة عن عدد صحيح
            //    if (int.TryParse(txtFilterValue.Text.Trim(), out int filterValue))
            //    {
            //        _dtCourses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, filterValue);
            //    }
            //}
            //else
            //{
            //    _dtCourses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());
            //}


            if (FilterColumn == "HasChecked")
            {
                dgvCourses.DataSource = _dtNotCheckedCourses;
                cbFilterBy.SelectedIndex = 0;
                lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
                if (dgvCourses.Rows.Count > 0)
                {

                    dgvCourses.Columns[0].HeaderText = "Course ID";
                    dgvCourses.Columns[0].Width = 110;

                    dgvCourses.Columns[1].HeaderText = "Course Name";
                    dgvCourses.Columns[1].Width = 240;


                    dgvCourses.Columns[2].HeaderText = "Course Number.";
                    dgvCourses.Columns[2].Width = 110;

                    dgvCourses.Columns[3].HeaderText = "Checked";
                    dgvCourses.Columns[3].Width = 300;
                }
                lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString(); lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
                lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();
            }







            lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();
         /*   lblKeywordsCount.Text = */ ThreadCalculateDGVKeywordsCount();


        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterValue.Visible = (cbFilterBy.Text != "None");

            if (txtFilterValue.Visible)
            {
                txtFilterValue.Text = "";
                txtFilterValue.Focus();
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lblLoading.Visible == true)
            {
                if (MessageBox.Show("keywords generator operation are running for now, are you sure you want to cancel it?", "Confirm Cancelling", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
                this.Close();

        }



        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

 
        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  int CourseID = (int)dgvCourses.CurrentRow.Cells[0].Value;
         //   Form frm2 = new frmShowCourseInfo(1);
         //   frm2.ShowDialog();

        }

        private void pbAddNewCourse_Click(object sender, EventArgs e)
        {
            frmAddCourse frm = new frmAddCourse();
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshCoursesList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Course [" + dgvCourses.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsCourse.DeleteCourse((int)dgvCourses.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Course Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshCoursesList();
                }

                else
                    MessageBox.Show("Course was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int courseId = (int)dgvCourses.CurrentRow.Cells[0].Value;
            frmManageKeywords frm = new frmManageKeywords(courseId);
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    lblLoading.Visible = true;
        //    int Counter = 0;
        //    clsKeyword keyword;
        //    foreach (DataRow row in _dtAllCourses.Rows)
        //    {
        //        Counter++;

        //        int courseID = (int)row["CourseID"];
        //        clsCourse Course = clsCourse.Find(courseID);

        //        keyword = new clsKeyword(Course.CourseID);
        //        keyword.GenerateKeywords();
        //    }
        //    lblLoading.Visible = false;
        //}
        private async void button1_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            lblKeywordsCount.Visible = false;
            await Task.Run(GenerateKeywordsForCourses);
            lblKeywordsCount.Visible = true;
            lblLoading.Visible = false;
        }

        private void GenerateKeywordsForCourses()
        {
            int Counter = 0;
            foreach (DataRow row in _dtAllCourses.Rows)
            {
                Counter++;

                int courseID = (int)row["CourseID"];
                clsCourse Course = clsCourse.Find(courseID);

                Course.Keyword.GenerateKeywords();
            }
        }
        private int GetDGVKeywordsCount()
        {
            int keywordsCount = 0;
            foreach (DataGridViewRow row in dgvCourses.Rows)
            {
                if (!row.IsNewRow)
                {
                    keywordsCount += clsCourse.GetKeywordsConutByCourseID(Convert.ToInt32(row.Cells[0].Value));
                }
            }
            return keywordsCount;
       //     lblKeywordsCount.Visible = true;
        }
        private void ThreadCalculateDGVKeywordsCount()
        {
            Thread threadCountKeywords = new Thread(() =>
            {
                int keywordsCount = GetDGVKeywordsCount();

                if (lblKeywordsCount.InvokeRequired)
                {
                    lblKeywordsCount.Invoke(new Action(() =>
                    {
                        lblKeywordsCount.Text = keywordsCount.ToString();
                        lblKeywordsCount.Visible = true;
                    }));
                }
                else
                {
                    lblKeywordsCount.Text = keywordsCount.ToString();
                    lblKeywordsCount.Visible = true;
                }
            });
            threadCountKeywords.Start();
        }

        private void cmsCourses_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cbNotCheckedCourses_CheckedChanged(object sender, EventArgs e)
        {
            cbNotCheckedCoursesRefresh();
        }
        private void cbNotCheckedCoursesRefresh()
        {
            if (cbNotCheckedCourses.Checked)
            {
                dgvCourses.DataSource = _dtNotCheckedCourses;
            }
            else
            {
                dgvCourses.DataSource = _dtCourses;
            }

            cbFilterBy.SelectedIndex = 0;
            lblRecordsCount.Text = dgvCourses.Rows.Count.ToString();

            if (dgvCourses.Rows.Count > 0)
            {
                // Ensure the DataGridView has the expected columns
                if (dgvCourses.Columns.Count >= 4)
                {
                    dgvCourses.Columns[0].HeaderText = "Course ID";
                    dgvCourses.Columns[0].Width = 110;

                    dgvCourses.Columns[1].HeaderText = "Course Name";
                    dgvCourses.Columns[1].Width = 240;

                    dgvCourses.Columns[2].HeaderText = "Course Number.";
                    dgvCourses.Columns[2].Width = 110;

                    dgvCourses.Columns[3].HeaderText = "Checked";
                    dgvCourses.Columns[3].Width = 300;
                }
                else
                {
                    MessageBox.Show("The DataTable does not have the expected number of columns.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            lblKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();

        }

        private void dgvCourses_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int courseId = (int)dgvCourses.CurrentRow.Cells[0].Value;
            frmManageKeywords frm = new frmManageKeywords(courseId);
            frm.Show();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
