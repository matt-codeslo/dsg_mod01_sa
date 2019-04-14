using System;
using System.Collections.Generic;

namespace mod01_self_assessment
{
    class Degree
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Degree(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public string AddCourse(Course c)
        {
            Courses.Add(c);
            return "Course Added";
        }

        public string ShowDegreeInfo() => $"Degree ID: {ID}, Degree Name: {Name}, Number of Courses in Degree: {Courses.Count}";

    }
}