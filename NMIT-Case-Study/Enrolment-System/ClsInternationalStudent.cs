// International student class file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project name
namespace Enrolment_System
{
    // Making ClsInternationalStudent inherit from ClsStudent as we inherited the forms and ClsInternationalStudent needs that info
    class ClsInternationalStudent : ClsStudent
    {
        // Member variables exclusive to international students
        private string _Country;
        private float _IELTS;

        // Property construct for international students
        public string Country { get => _Country; set => _Country = value; }
        public float IELTS { get => _IELTS; set => _IELTS = value; }
    }
}
