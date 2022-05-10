using GenericsHomework.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsHomework.Enums;

namespace Generics.Classes
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; }
        public int LivesLeft { get; set; }

        public override string PrintInfo()
        {
            return $"{Name} | {Age} | {Type} | {IsLazy} | {LivesLeft}";
        }
        public Cat() { }
        public Cat(string name, int age, GenericsHomework.Enums.Type type, int livesLeft, bool isLazy) : base(name, age, type)
        {
            livesLeft = livesLeft;
            isLazy = isLazy;
        }
    }
}
    
