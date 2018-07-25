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
        private static List<ClsStudent> _StudentList = new List<ClsStudent>();

        // Public property construct, this is read only as we have removed the set accessor
        public static List<ClsStudent> StudentList { get => _StudentList; }

        // Calculating the total student balances
        public static decimal TotalBalance()
        {
            // Currently total is set as zero
            decimal lcTotal = 0;
            // For each student in student list we will add their balance to the total balance
            foreach (ClsStudent lcStudent in _StudentList) lcTotal += lcStudent.Balance;
            // Then return the total balance of all the students
            return lcTotal;
        }
    }
}
