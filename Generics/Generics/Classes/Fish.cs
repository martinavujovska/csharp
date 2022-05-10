using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsHomework.Enums;


namespace GenericsHomework.Classes
{
    public class Fish : Pet
    {
        public string Color { get; set; }

        public string Size { get; set; }

        public override string PrintInfo()
        {
            return $" {Name} | {Age} | {Type} | {Color} | {Size}";
        }
        public Fish() { }
        public Fish(string name, int age, Enums.Type type, string color, string size) : base(name, age, type)
        {
            Color = color;
            Size = size;
        }

    }
}