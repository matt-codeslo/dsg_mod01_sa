using System;
using System.Collections.Generic;

namespace mod01_self_assessment
{
    class Degree
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Degree(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public void AddCourse(Course c) => Courses.Add(c);

        public string ShowDegreeInfo() => $"Degree Name: {Name}, Number of Courses in Degree: {Courses.Count}";

    }
}