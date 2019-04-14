using System;
using System.Collections.Generic;

namespace mod01_self_assessment
{
    class UProgram
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Degree> Degrees { get; set; }

        public UProgram(string name)
        {
            Name = name;
            Degrees = new List<Degree>();
        }

        public string AddDegree(Degree d)
        {
            Degrees.Add(d);
            return "Degree added";
        }

        public string ShowProgramInfo() => $"Program ID: {ID}, Program Name: {Name}, Number of Degrees in Program: {Degrees.Count}";

    }
}