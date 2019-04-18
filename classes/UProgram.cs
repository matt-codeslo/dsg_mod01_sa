using System;
using System.Collections.Generic;

namespace mod01_self_assessment
{
    class UProgram
    {
        public string Name { get; set; }
        public List<Degree> Degrees { get; set; }

        public UProgram(string name)
        {
            Name = name;
            Degrees = new List<Degree>();
        }

        public void AddDegree(Degree d) => Degrees.Add(d);

        public string ShowProgramInfo() => $"Program Name: {Name}, Number of Degrees in Program: {Degrees.Count}";

    }
}