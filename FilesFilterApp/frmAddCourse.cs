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
    public partial class frmAddCourse : Form
    {

        private string _CourseName = "";
        private int _CourseNo = -1;




        public frmAddCourse()
        {
            InitializeComponent();
            textboxCourseNo.KeyPress += new KeyPressEventHandler(textboxCourseNo_KeyPress);
            textboxCourseNo.TextChanged += new EventHandler(textboxCourseNo_TextChanged);
        }

        private void frmAddUpdateCourse_Load(object sender, EventArgs e)
        {

        }
        private void ValidateInputs()
        {
            // Check if both text boxes are not empty
            if (!string.IsNullOrWhiteSpace(textboxCourseNo.Text) && !string.IsNullOrWhiteSpace(txtboxCourseName.Text))
            {
                btnSaveAddingCourse.Enabled = true;
            }
            else
            {
                btnSaveAddingCourse.Enabled = false;
            }

        }

        private void txtboxCourseName_TextChanged(object sender, EventArgs e)
        {
            _CourseName = txtboxCourseName.Text;
            ValidateInputs();
        }

        private void textboxCourseNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit or control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, ignore the key press
                e.Handled = true;
            }
        }

        private void textboxCourseNo_TextChanged(object sender, EventArgs e)
        {
            string CourseNo = textboxCourseNo.Text;
            int.TryParse(CourseNo, out _CourseNo);

            ValidateInputs();
        }

        private void btnSaveAddingCourse_Click(object sender, EventArgs e)
        {





            var result = MessageBox.Show("Are you sure you want to save the course?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int CourseID = clsCourse.AddNewCourse(_CourseName, _CourseNo);
                if(CourseID > 0)
               MessageBox.Show("Saved Succefully with CourseID = " + CourseID, "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to save.\n Please try again = ", "ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
