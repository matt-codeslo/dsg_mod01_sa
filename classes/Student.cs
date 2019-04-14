using System;

namespace mod01_self_assessment
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static int StudentCount { get; set; }

        public Student(string fn, string ln, string dob)
        {
            FirstName = fn;
            LastName = ln;
            DateOfBirth = DateTime.Parse(dob);
            StudentCount++;
        }

        public string ShowStudentInfo()
        {
            var dob = DateOfBirth.ToShortDateString();
            return $"Student Name: {FirstName + ' ' + LastName}, DOB: {dob}";
        }
    }
}