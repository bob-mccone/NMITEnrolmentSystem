// Form main file
// Usings
using System;
using System.Windows.Forms;

// Project name
namespace Enrolment_System
{
    // Public partial class, meaning another file with additional code, Frm main inherits from form class
    public partial class FrmMain : Form
    {
        // V4 edit, As we have moved creating students over to the FrmStudentList we no longer need all that code in here, just code to open that form
        private FrmStudentList _StudentListForm = new FrmStudentList();

        // Form constructor
        public FrmMain()
        {
            InitializeComponent();
            // Try catch method
            try
            { 
                // Attempt to retrieve the student list
                ClsInstitute.Retrieve();
                // Update the total balance
                UpdateTotalStudents();

            }
            // If failed catch the error
            catch (Exception ex)
            {
                // And display message box
                MessageBox.Show(ex.Message);
            }
            
        }

        // Button close method
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Try catch method
            try
            {
                // Attempt to save
                ClsInstitute.Save();
            }
            // If failed catch the error
            catch (Exception ex)
            {
                // And display message box
                MessageBox.Show(ex.Message);
            }
            // Closes the program
            Close();
        }

        // Button manage students method
        private void BtnManageStudents_Click(object sender, EventArgs e)
        {
            // Opening the student list form
            _StudentListForm.ShowDialog();
            // Updating total students and balances
            UpdateTotalStudents();
        }

        private void UpdateTotalStudents()
        {
            // Displaying the total students and the total balance in currenct format, 0 is the student count, 1 is the total balance, we use the C to show the balance in the country specific currency format
            LblStudentDetails.Text = string.Format("{0} Student(s)\nTotal Balance: {1:C}", ClsInstitute.StudentList.Count, ClsInstitute.TotalBalance());
        }
    }
}