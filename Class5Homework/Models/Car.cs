using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class5Homework.Models
{
    public class Car
    {
        public string Model { get; set; }
        public Driver Driver { get; set; }
        public int Speed { get; set; }
     

        public int CalculateSpeed(Car car, Driver driver)
        {
            int speed = car.Speed * driver.Skill;
            return speed;
        }

    }
}