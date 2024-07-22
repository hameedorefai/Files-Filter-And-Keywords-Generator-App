using BusinessLogic;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace FilesFilterApp
{
    public partial class frmManageKeywords : Form
    {
        static private int _courseId = -1;
        private DataTable _dtAllKeywordsForCourse;
        private DataView _dvKeywords;
        private clsCourse Course;

        public frmManageKeywords(int courseId)
        {
            _courseId = courseId;
            Course = clsCourse.Find(_courseId);
            InitializeComponent();
            lblCourseName.Text = Course.CourseName;
            lblKeywordDeletedSuccefully.Visible = false;
            lblLoading1.Visible = false;
            lblLoading2.Visible = false;
            lblLoading3.Visible = false;

            if(Course.HasChecked())
            {
                pbCheckedFalse.Visible = false;
                pbCheckedTrue.Visible = true;
            }
            else
            {
                pbCheckedFalse.Visible = true;
                pbCheckedTrue.Visible = false;

            }

        }

        private void frmAddKeyword_Load(object sender, EventArgs e)
        {
            LoadKeywords();
            ConfigureDataGridView();
        }

        private void LoadKeywords()
        {
            // احصل على جميع الكلمات المفتاحية للدورة
            _dtAllKeywordsForCourse = Course.GetAllKeywordsDT();

            // تحقق إذا كانت البيانات غير فارغة
            if (_dtAllKeywordsForCourse != null)
            {
                // إنشاء DataView جديد من البيانات المسترجعة
                _dvKeywords = new DataView(_dtAllKeywordsForCourse);

                // تعيين DataSource لـ DataGridView
                dgvKeywords.DataSource = _dvKeywords;

                // تحديث عدد الكلمات المفتاحية في الملصق
                lblKeywordsCount.Text = dgvKeywords.Rows.Count.ToString();
              //  lblTotalKeywordsCount.Text = clsKeyword.GetAllKeywordsCount().ToString();
            }
            else
            {
                // في حالة عدم وجود بيانات، قم بإجراءات مناسبة مثل إظهار رسالة
                lblKeywordsCount.Text = "0";
                MessageBox.Show("No keywords found for the course.");
            }
        }

        private void ConfigureDataGridView()
        {
            if (dgvKeywords.Columns.Count > 0)
            {
                dgvKeywords.Columns[0].HeaderText = "Keyword ID";
                dgvKeywords.Columns[0].Width = 85;

                dgvKeywords.Columns[1].HeaderText = "Keyword";
                dgvKeywords.Columns[1].Width = 220;

                dgvKeywords.Columns[2].HeaderText = "Course ID";
                dgvKeywords.Columns[2].Width = 79;
            }
        }

        private void _RefreshKeywordsList()
        {
            LoadKeywords();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          //  var loadingTask = Task.Run(() => LoadingLabel());

            Course = clsCourse.Find(_courseId);

            if (Course != null)
            {
                Course.Keyword.GenerateKeywords();
                _RefreshKeywordsList();
            }
         //   await loadingTask;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshKeywordsList();
        }

        private void dgvKeywords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void txtboxAddNewKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string newKeyword = txtboxAddNewKeyword.Text;
            if (newKeyword != "" && newKeyword != null)
            {
                clsKeyword keyword = new clsKeyword(_courseId);
                keyword.AddNewKeyword(newKeyword);
                _RefreshKeywordsList();
            }

        }
        private async void LoadingLabel()
        {
            while (true)
            {
                lblLoading1.Visible = true;
                await Task.Delay(300);
                lblLoading2.Visible = true;
                await Task.Delay(300);
                lblLoading3.Visible = true;
                await Task.Delay(500);
                lblLoading2.Visible = false;
                lblLoading3.Visible = false;
                await Task.Delay(300);
                lblLoading2.Visible = true;
                await Task.Delay(300);
                lblLoading3.Visible = true;
                await Task.Delay(500);
            }
        }

        private void ShowKeywordstoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void ShowKeywordstoolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                //if (MessageBox.Show("Are you sure you want to delete Keyword [" + dgvKeywords.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                //Perform Delele and refresh
                if (clsKeyword.DeleteKeyword((int)dgvKeywords.CurrentRow.Cells[0].Value))
                {
                    // MessageBox.Show("Keyword Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // await Task.Run(ShowKeywordDeletedSuccessfullyLabel);
                    await Task.Run(() => this.Invoke(new Action( ShowKeywordDeletedSuccessfullyLabel)));
                    _RefreshKeywordsList();
                }
                else
                    MessageBox.Show("Keyword was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Keyword was not deleted because of an ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("The Exception is :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void cmsKeywords_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCourseName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblKeywordsCount_Click(object sender, EventArgs e)
        {

        }

        private void ShowKeywordDeletedSuccessfullyLabel()
        {
            lblKeywordDeletedSuccefully.Visible = true;
            Task.Delay(100).Wait();
            lblKeywordDeletedSuccefully.Visible = false;
            Task.Delay(100).Wait();
            lblKeywordDeletedSuccefully.Visible = true;
            Task.Delay(100).Wait();
            lblKeywordDeletedSuccefully.Visible = false;
            Task.Delay(100).Wait();
            lblKeywordDeletedSuccefully.Visible = true;
            Task.Delay(500).Wait();
            lblKeywordDeletedSuccefully.Visible = false;

        }

        private void txtboxAddNewKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(this, new EventArgs());
            }

        }

        private void dgvKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                try
                {
                    if (dgvKeywords.CurrentRow.Cells[0].Value != DBNull.Value)
                    {
                        if (clsKeyword.DeleteKeyword((int)dgvKeywords.CurrentRow.Cells[0].Value))
                        {
                            _RefreshKeywordsList();
                        }
                        else
                            MessageBox.Show("Keyword was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Keyword was not deleted because of an ERROR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("The Exception is :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void pbCheckedFalse_Click(object sender, EventArgs e)
        {
            if (Course.SetCheckStatus(true))
            {
                pbCheckedFalse.Visible = false;
                pbCheckedTrue.Visible = true;

            }
        }

        private void pbCheckedTrue_Click(object sender, EventArgs e)
        {
            if (Course.SetCheckStatus(false))
            {
                pbCheckedFalse.Visible = true;
                pbCheckedTrue.Visible = false;

            }

        }
    }
}
