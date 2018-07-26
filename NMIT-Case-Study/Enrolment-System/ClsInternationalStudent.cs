// International student class file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project name
namespace Enrolment_System
{
    // Saving
    [Serializable]
    // Making ClsInternationalStudent inherit from ClsStudent as we inherited the forms and ClsInternationalStudent needs that info
    class ClsInternationalStudent : ClsStudent
    {
        // Private member variable, make it static so there is only one form for all instances of ClsInternationalStudent created
        private static FrmInternationalStudent _Form = new FrmInternationalStudent();

        // Overriding the abstract method from ClsStudent
        public override bool ViewEdit()
        {
            // Return international student form
            return _Form.ShowDialog(this);
        }

        // Overriding the type of student method in ClsStudent do that it returns Intl
        protected override string TypeOfStudent()
        {
            return "Intl";
        }
        // Member variables exclusive to international students
        private string _Country;
        private float _IELTS;

        // Property construct for international students
        public string Country { get => _Country; set => _Country = value; }
        public float IELTS { get => _IELTS; set => _IELTS = value; }
    }
}
