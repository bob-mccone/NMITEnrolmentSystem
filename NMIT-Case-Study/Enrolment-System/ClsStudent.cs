// Class student file
// Usings
using System;

// Project name
namespace Enrolment_System
{
    // public class class student
    public class ClsStudent
    {
        // Variables
        private string _ID;
        private string _Name;
        private DateTime _DOB = DateTime.Today;
        private decimal _Balance;
        
        // Property construct
        public string ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public DateTime DOB { get => _DOB; set => _DOB = value; }
        public decimal Balance { get => _Balance; set => _Balance = value; }
        
        // Overrides standard class behaviour and returns a string
        public override string ToString()
        {
            return _ID + "\n" + _Name + " " + _DOB.ToShortDateString() + "\n" + _Balance;
        }
    }
}