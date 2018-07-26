// Class student file
// Usings
using System;

// Project name
namespace Enrolment_System
{
    // Saving
    [Serializable]
    // public class class student
    // V2 edit, this is now abstract, basically there are no ClsStudent objects
    public abstract class ClsStudent
    {
        // Setting the variables in the combo box, we are creating an array of strings
        // V3 edit, moving from form main to reduce coupling, make it public static and readonly because pubic variables are a no-no in object oriented programing, also we drop the _ prefix
        public static readonly string[] StudentType = { "MOE (local)", "International" };
        // Static factory method, static methods are always accessible, its job is to return an MOE student if choice was 0, otherwise an international student
        public static ClsStudent NewStudent(int prChoice)
        {
            // If choice was 0
            if (prChoice == 0)
                // Create an MOE student
                return new ClsMOEStudent();
            else
                // Else create an international student
                return new ClsInternationalStudent();
        }

        // Public abstract method, this returns a boolean or true/false as a signal of whether editing was successful, abstract methods don't have code
        public abstract bool ViewEdit();

        // Protected abstract method that returns a string
        protected abstract string TypeOfStudent();
        
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
        // V4 edit, As we have gone to a list we need to tab the data rather than put it on a new line
        // V5 edit, we want to display name first as we are sorting by name
        public override string ToString()
        {
            return _Name + "\t" + _ID + "\t" + TypeOfStudent();
        }
    }
}