using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsHomework.Enums;

namespace GenericsHomework.Classes
{
    public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public string FavoriteFood { get; set; }
        public override string PrintInfo()
        {
            return $"{Name} | {Age} | {Type} |{IsGoodBoi}| {FavoriteFood}";
        }
        public Dog() { }
        public Dog(string name, int age, Enums.Type type, bool isGoodBoi, string faveFood) : base(name, age, type)
        {
            isGoodBoi = IsGoodBoi;
            FavoriteFood = faveFood;
        }
    }
}