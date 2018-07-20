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
        // Declaring a member variable called _Student of type class student, as this is a class type it is a reference variable and allocates enough memory to hold an address to an object, is null unless instantiated
        private ClsStudent _Student;
        // V3 edit, no longer need the student form variables as they are npw handeled by the appripriate classes, student type/combo box is now handeled by ClsStudent

        // Form constructor
        public FrmMain()
        {
            InitializeComponent();
            // Initialise the combo box
            // V3 edit, this is now handeled by ClsStudent
            CboStudentType.DataSource = ClsStudent.StudentType;
            CboStudentType.SelectedIndex = 0;
        }
        // Button close method
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // Closes the program
            Close();
        }

        // Button create student method
        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            // Calling create student method
            CreateStudent();
        }

        // Button edit student method
        // V3 edit, this is now accepting a student parameter, it assigns the new student to the member variable _Student if it is not null, also stops creating students when user clicks cancel
        private void EditStudent(ClsStudent prStudent)
        {
            // if _student isn't null (empty) and user clicked on ok in the student form
            if (prStudent != null && prStudent.ViewEdit())
            {
                // Assign prStudent as the _Student
                _Student = prStudent;
                // Display student details on the main form
                LblStudentDetails.Text = "Student:\n" + _Student.ToString();
            }
        }

        // Button modify student method
        private void BtnModifyStudent_Click(object sender, EventArgs e)
        {
            // if student id isn't null
            if (_Student != null)
            {
                // Calling edit student method
                EditStudent(_Student);
            }
            else
            {
                // Display a message box called no student
                DialogResult NoStudent = MessageBox.Show("Student doesn't exist, would you like to create one now?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                // If user clicked on yes
                if (NoStudent == DialogResult.Yes)
                {
                    // Call create student method
                    CreateStudent();
                }
                else
                {
                    // Closing the message box
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        // Create student method
        private void CreateStudent()
        {
            // V3 edit, since the responsibility of creating the appropriate student and form is now done by the student classes it is no longer here
            // We pass the index user choice to the new factory method in ClsStudent, then pass the created student to the edit method
            ClsStudent lcStudent = ClsStudent.NewStudent(CboStudentType.SelectedIndex);
            // Calling edit student that opens the student form
            EditStudent(lcStudent);
        }
    }
}