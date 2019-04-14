using System;

namespace mod01_self_assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var MariaPequina = new Student("Maria", "Pequina", "Jan 13 2000");
            var AdamShaddam = new Student("Adam", "Shaddam", "Dec 13 1999");

            var JaneSame = new Teacher("Jane", "Same", "Computer Science");

            var IntroToCSharp = new Course("Intro to C#");

            var Bachelors = new Degree("Bachelors");

            var ComputerScience = new UProgram("Computer Science");

            ComputerScience.AddDegree(Bachelors);
            Bachelors.AddCourse(IntroToCSharp);
            IntroToCSharp.AddStudent(MariaPequina);
            IntroToCSharp.AddStudent(AdamShaddam);
            IntroToCSharp.AddTeacher(JaneSame);

            Console.WriteLine(ComputerScience.ShowProgramInfo());

            Console.WriteLine("Degrees in the Computer Science Program:");

            foreach (var degree in ComputerScience.Degrees)
            {
                Console.WriteLine(degree.Name);
            }

            Console.WriteLine("The Courses in the Bachelor of Computer Science Degree: ");

            foreach (var course in Bachelors.Courses)
            {
                Console.WriteLine(course.Name);
            }

            Console.WriteLine("Number of students in the Intro to C# course: " + Student.StudentCount);

        }
    }
}
