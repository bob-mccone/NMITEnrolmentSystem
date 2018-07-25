// Class institute file
// Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Project name
namespace Enrolment_System
{
    // Class institute
    class ClsInstitute
    {
        // Creating a static list of students
        // V5 edit, we are now using a dictionary instead of a list
        private static Dictionary<string, ClsStudent> _StudentList = new Dictionary<string, ClsStudent>();

        // Public property construct, this is read only as we have removed the set accessor
        public static Dictionary<string, ClsStudent> StudentList { get => _StudentList; }

        // Calculating the total student balances
        public static decimal TotalBalance()
        {
            // Currently total is set as zero
            decimal lcTotal = 0;
            // For each student in student list we will add their balance to the total balance
            // V5 edit, as we are using a dictionary we have to add .values after _StudentList
            foreach (ClsStudent lcStudent in _StudentList.Values) lcTotal += lcStudent.Balance;
            // Then return the total balance of all the students
            return lcTotal;
        }
    }
}
