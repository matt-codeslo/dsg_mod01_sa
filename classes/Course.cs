using System;
using System.Collections.Generic;

namespace mod01_self_assessment
{
    class Course
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new List<Student>();
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher t) => Teachers.Add(t);

        public void AddStudent(Student s) => Students.Add(s);

        public string ShowCourseInfo() => $"Course Name: {Name}, Number of Teachers for course: {Teachers.Count}, Number of Students in course: {Students.Count}";
    }
}