using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOO2
{
    internal class Student
    {
        public string Name { get; set; }
        public string University { get; set; }
        public int RollNumber { get; set; }

        public Student()
        {

        }
        public Student(string Name, string University, int number)
        {
            Name = Name;
            University = University;
            RollNumber = number;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {University} - {RollNumber}");
        }
    }
}
