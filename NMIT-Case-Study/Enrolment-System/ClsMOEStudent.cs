// MOE student class file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project name
namespace Enrolment_System
{
    // Making ClsMOEStudent inherit from ClsStudent as we inherited the forms and ClsMOEStudent needs that info
    class ClsMOEStudent : ClsStudent
    {
        // Private member variable, make it static so there is only one form for all instances of ClsMOEStudent created
        private static FrmMOEStudent _Form = new FrmMOEStudent();

        // Overriding the abstract method from ClsStudent
        public override bool ViewEdit()
        {
            // Return MOE student form
            return _Form.ShowDialog(this);
        }

        // Overriding the type of student method in ClsStudent do that it returns MOE
        protected override string TypeOfStudent()
        {
            return "MOE";
        }

        // Member variables exclusive to MOE students
        private decimal _LoanAmount;
        private bool _FullTime;

        // Property construct for MOE students
        public decimal LoanAmount { get => _LoanAmount; set => _LoanAmount = value; }
        public bool FullTime { get => _FullTime; set => _FullTime = value; }
    }
}
