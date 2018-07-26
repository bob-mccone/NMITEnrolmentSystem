// Form student list file
// Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Project name
namespace Enrolment_System
{
    // Public partial class, meaning another file with additional code, Frm student list inherits from form class
    public partial class FrmStudentList : Form
    {
        // Form constructor
        public FrmStudentList()
        {
            InitializeComponent();
            // Initialise the combo box
            // V3 edit, this is now handeled by ClsStudent
            // V4 edit, combo box is now on the student form list
            CboStudentType.DataSource = ClsStudent.StudentType;
            CboStudentType.SelectedIndex = 0;
        }

        // Private void method update display, refreshes the listbox, easiest way to do this is to assign a (business) list to the data source, when we clear the data source we then assign the student list from the institute class
        private void UpdateDisplay()
        {
            LstStudents.DataSource = null;
            // V5 edit, because we are now using a dictionary we need to select the values column and convert it to a list before assigning it to the data source of the listbox
            LstStudents.DataSource = ClsInstitute.StudentList.Values.ToList<ClsStudent>();
        }

        // Create student button
        private void BtnCreateStudent_Click(object sender, EventArgs e)
        {
            CreateStudent();
        }

        // Create student method
        private void CreateStudent()
        {
            // We create a new student by calling the factory method NewStudent() in ClsStudent and storing it in the local variable lcStudent 
            ClsStudent lcStudent = ClsStudent.NewStudent(CboStudentType.SelectedIndex);
            // If it was successful 
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                // We add the student to the student list 
                // V5 edit, as we are using a dictionary this changes a little compared to the list one
                ClsInstitute.StudentList.Add(lcStudent.ID, lcStudent);
                // Then update the display to show the student in the list box
                UpdateDisplay();
            }
        }

        // Modify student button
        private void BtnModifyStudent_Click(object sender, EventArgs e)
        {
            // Locating the student that the user has highlighted
            ClsStudent lcStudent = (ClsStudent)LstStudents.SelectedItem;
            // If student exists and is selected
            if (lcStudent != null)
            {
                // We will edit them
                EditStudent();
            }
            else
            {
                // Else we will display a message box saying no students exists amd ask if they would like to create one instead
                DialogResult NoStudent = MessageBox.Show("No students exist would you like to create one now?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                // If user clicked on yes
                if (NoStudent == DialogResult.Yes)
                {
                    // We will create the student
                    CreateStudent();
                }
                else
                {
                    // Else we will cancel
                    return;
                }
            }
        }

        // Edit student method
        private void EditStudent()
        {
            // Locating the student that the user has highlighted
            ClsStudent lcStudent = (ClsStudent)LstStudents.SelectedItem;
            // If student details is not null and editing was successful
            if (lcStudent != null && lcStudent.ViewEdit())
            {
                // Then update display
                UpdateDisplay();
            }
        }
        
        // Edit student when double clicking on list box
        private void LstStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Edit student
            EditStudent();
        }

        // Button close
        private void BtnClose_Click(object sender, EventArgs e)
        {
            // closes the form
            this.Close();
        }

        // Button delete student
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Trying to find a student
            ClsStudent lcStudent = (ClsStudent)LstStudents.SelectedItem;
            // If list is empty
            if (lcStudent == null)
            {
                // Display Message box
                DialogResult CantDelete = MessageBox.Show("No students exist to delete", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // User clicks ok
                if (CantDelete == DialogResult.OK)
                {
                    // And messagebox closes
                    return;
                }
            }
            // Display message box asking user if they want to delete
            DialogResult DeleteStudent = MessageBox.Show("You are about to delete a student, are you sure?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // If user clicks yes
            if (DeleteStudent == DialogResult.Yes)
            {
                // Delete the student
                RemoveStudent();
            }
        }

        // Delete student method
        private void RemoveStudent()
        {
            // Find selected student
            ClsStudent lcStudent = (ClsStudent)LstStudents.SelectedItem;
            // Remove them
            // V5 edit, as this is a dictionary we need to find the ID
            ClsInstitute.StudentList.Remove(lcStudent.ID);
            // Then update the listbox
            UpdateDisplay();
        }

        // Button find student
        private void BtnFindStudent_Click(object sender, EventArgs e)
        {
            // ClsStudent is a local variable lcStudent
            ClsStudent lcStudent;
            // Try and find the student
            if (ClsInstitute.StudentList.TryGetValue(TxtFindStudentID.Text, out lcStudent))
            {
                LstStudents.SelectedItem = lcStudent;
            }
            // If the listbox is empty
            else if (LstStudents == null)
            {
                // Display message asking if they would like to create one first
                DialogResult EmptyList = MessageBox.Show("No student(s) exist, would you like to create one now?", "Find Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                // If yes is selected
                if (EmptyList == DialogResult.Yes)
                {
                    // Create student
                    CreateStudent();
                }
            }
        }

        // When form loads
        private void FrmStudentList_Load(object sender, EventArgs e)
        {
            // Displaying student details that we have loaded
            UpdateDisplay();
        }
    }
}
