﻿// Form main file
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
        // Declaring a member variable called _StudentForm of type form student, as this is a class type it is a reference variable and allocates enough memory to hold an address to an object, is null unless instantiated, new means it instantiates a new form object
        private FrmStudent _StudentForm = new FrmStudent();
        
        // Form constructor
        public FrmMain()
        {
            InitializeComponent();
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
        private void EditStudent()
        {
            // if _student isn't null (empty) and user clicked on ok in the student form
            if (_Student != null && _StudentForm.ShowDialog(_Student) == DialogResult.OK)
            {
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
                EditStudent();
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
            // Creates a class student object and assigns it to the member variable _Student
            _Student = new ClsStudent();
            // Calling edit student that opens the student form
            EditStudent();
        }
    }
}