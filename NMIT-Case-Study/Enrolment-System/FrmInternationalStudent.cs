// International student form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Project name
namespace Enrolment_System
{
    // Public partial class, meaning another file with additional code, form international student inherits from form student
    public partial class FrmInternationalStudent : Enrolment_System.FrmStudent
    {
        // Form constructor
        public FrmInternationalStudent()
        {
            InitializeComponent();
        }

        // Overriding the superclass update display method in form student
        protected override void UpdateDisplay()
        {
            // Calling the overridden method, we are reusing the student types
            base.UpdateDisplay();
            // Need the student variable _student, it is declared as clsstudent in the superclass form student, as cls student doesn't contain the country or IELTS properties we expect from an international student we typecast _student into clsinternationalstudent in order to use those properties
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            // The item in the text box is getting stored into the member variable in our class file and so on, in this case the country variable, remember we need to convert to string
            TxtCountry.Text = lcStudent.Country;
            TxtIELTS.Text = Convert.ToString(lcStudent.IELTS);
        }

        // Overriding the superclass update display method in form student
        protected override void PushData()
        {
            // Calling the overridden method, we are reusing the student types
            base.PushData();
            // Need the student variable _student, it is declared as clsstudent in the superclass form student, as cls student doesn't contain the loan amount or fulltime properties we expect from a MOE student we typecast _student into clsMOEstudent in order to use those properties
            ClsInternationalStudent lcStudent = (ClsInternationalStudent)_Student;
            // When the user clicks on ok it assigns the contents of the textboxes on the form to the student object properties, remember we need to conver it back to float, as it is a float we will do float.Parse
            lcStudent.Country = TxtCountry.Text;
            lcStudent.IELTS = float.Parse(TxtIELTS.Text);
        }
    }
}
