// Form student file
// Usings
using System;
using System.Windows.Forms;

// Project name
namespace Enrolment_System
{
    // Public partial class, meaning another file with additional code, Frm student inherits from form class
    public partial class FrmStudent : Form
    {
        // Declaring a member variable called _Student of type class student, as this is a class type it is a reference variable and allocates enough memory to hold an address to an object, is null unless instantiated
        // V2 edit: the variable _Student must become protected because of inhertiance
        protected ClsStudent _Student;

        // Form constructor
        public FrmStudent()
        {
            InitializeComponent();
        }

        // Display FrmStudent
        // V3, Show dialog now returns a boolinstead of dialog result, as ClsMOEStudent and ClsInternationalStudent are calling show dialog we don't want classes to concern themselves with windows specific items, change is good style
        public bool ShowDialog(ClsStudent prStudent)
        {
            // Creating and storing the parameter value in our member variable
            _Student = prStudent;
            // Calling the update display method so it will populate the form
            UpdateDisplay();
            // Returnung the values to the form and display them
            // V3, now just returns a bool
            return ShowDialog() == DialogResult.OK;
        }

        // Update display method
        // V2 edit: update display must become protected and virtual for inhertied forms to override them
        protected virtual void UpdateDisplay()
        {
            // The item in the text box is getting stored into the member variable in our class file and so on, in this case the ID variable
            TxtID.Text = _Student.ID;
            TxtName.Text = _Student.Name;
            DtpDOB.Value = _Student.DOB;
            // As balance is a numeric we have to convert it to a string before we display it
            TxtBalance.Text = Convert.ToString(_Student.Balance);
            // Assigning a true or false to the ID of a student, if the ID box is empty we can edit it, otherwise it becomes read only
            TxtID.Enabled = String.IsNullOrEmpty(_Student.ID);
        }

        // Button ok method
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // V5 edit, as dictionarys are capable of detecting existing keys we might as well use it, here we check if the ID exists
            if (TxtID.Enabled && ClsInstitute.StudentList.ContainsKey(TxtID.Text))
                MessageBox.Show("Student with that ID already exists", "Duplicate ID");
            else
            {
                // Calling push data method
                PushData();
                // Setting the dialog result to ok, this closes the form and the show dialog method to return ok to the caller
                DialogResult = DialogResult.OK;
            }
        }

        // V2 edit: push data must become protected and virtual for inhertied forms to override them
        protected virtual void PushData()
        {
            // When the user clicks on ok it assigns the contents of the textboxes on the form to the student object properties
            _Student.ID = TxtID.Text;
            _Student.Name = TxtName.Text;
            _Student.DOB = DtpDOB.Value;
            // As balance is a numeric we need to convert it back
            _Student.Balance = Convert.ToDecimal(TxtBalance.Text);
        }

        // Button cancel method
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // When user clicks on cancel it cancels the operation without storing any data and returns cancel to the caller in the show dialog method
            DialogResult = DialogResult.Cancel;
        }
    }
}