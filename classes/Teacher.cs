using System;

namespace mod01_self_assessment
{
    class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Teacher(string fn, string ln, string s)
        {
            FirstName = fn;
            LastName = ln;
            Subject = s;
        }

        public string ShowTeacherInfo() => $"Teacher name: {FirstName + ' ' + LastName}, Subject: {Subject}";
    }
}