using System;
using System.Collections.Generic;
using System.Text;

namespace Class5Homework.Models
{
    public class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }

        public Driver(string Name, int skill)
        {
            Name = Name;
            Skill = skill;

        }
    }
}
