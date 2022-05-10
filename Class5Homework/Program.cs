using Class5Homework.Models;
using System;

namespace Class5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driverBob = new Driver("Bob Bobsky", 10);
            Driver driverJohn = new Driver("John Smith", 8);
            Driver driverMark = new Driver("Mark McKenna", 7);
            Driver driverBilly = new Driver("Billy Idol", 9);

            Car carSeat = new Car();
            Car carTransam = new Car();
            Car carFord = new Car();
            Car carHonda = new Car();

            Driver[] drivers = { driverBob, driverJohn, driverMark, driverBilly };
            Car[] cars = { carSeat, carTransam, carFord, carHonda };
            string[] models = { "Seat Leon", "TransAm", "Ford Mondeo", "Honda Civic" };
            int[] speed = { 240, 300, 220, 200 };

            for (int i = 0; i < 4; i++)
            {
                cars[i].Model = models[i];
                cars[i].Speed = speed[i];
            }

            selectOption();

            static void RaceCars(Car firstCar, Car secondCar)
            {
                int speed1 = firstCar.CalculateSpeed(firstCar, firstCar.Driver);
                int speed2 = secondCar.CalculateSpeed(firstCar, secondCar.Driver);

                if (speed1 > speed2)
                {
                    Console.WriteLine($"{firstCar.Model} won the race. It was going {firstCar.Speed} and was driven by {firstCar.Driver.Name}");
                }
                else if (speed2 > speed1)
                {
                    Console.WriteLine($"{secondCar.Model} won the race. It was going {secondCar.Speed} and was driven by {secondCar.Driver.Name}");
                }
                else Console.WriteLine("We have a draw!");
            }

            void selectOption()
            {
                Car firstCar = null;
                Car secondCar = null;

                Console.WriteLine($"Choose your first car by typing its name: \n {cars[0].Model} \n {cars[1].Model} \n {cars[2].Model} \n {cars[3].Model}");
                string carChoice1 = Console.ReadLine().ToLower();
                if (carChoice1 != "seat leon" && carChoice1 != "transam" && carChoice1 != "ford mondeo" && carChoice1 != "honda civic")
                {
                    Console.WriteLine("Wrong input. Select one of the offered options.");
                    selectOption();
                }
                else
                {
                    switch (carChoice1)
                    {
                        case "seat leon":
                            firstCar = cars[0];
                            break;
                        case "transam":
                            firstCar = cars[1];
                            break;
                        case "ford mondeo":
                            firstCar = cars[2];
                            break;
                        case "honda civic":
                            firstCar = cars[3];
                            break;
                        default:
                            firstCar = null;
                            break;
                    }
                }

                Console.WriteLine($"Choose your first driver by typing his name: \n {driverBob.Name} \n {driverJohn.Name} \n {driverMark.Name} \n {driverBilly.Name}");
                string driverChoice1 = Console.ReadLine().ToLower();
                if (driverChoice1 != "bob bobsky" && driverChoice1 != "john smith" && driverChoice1 != "mark mckenna" && driverChoice1 != "billy idol")
                {
                    Console.WriteLine("Wrong input. Select one of the offered options.");
                    selectOption();
                }
                else
                {
                    switch (driverChoice1)
                    {
                        case "bob bobsky":
                            firstCar.Driver = driverBob;
                            break;
                        case "john smith":
                            firstCar.Driver = driverJohn;
                            break;
                        case "mark mckenna":
                            firstCar.Driver = driverMark;
                            break;
                        case "billy idol":
                            firstCar.Driver = driverBilly;
                            break;
                        default:
                            firstCar.Driver = null;
                            break;
                    }
                }
                Console.WriteLine($"Choose your second car by typing its name: \n {cars[0].Model} \n {cars[1].Model} \n {cars[2].Model} \n {cars[3].Model}");
                string carChoice2 = Console.ReadLine().ToLower();
                if (carChoice2 != "seat leon" && carChoice2 != "transam" && carChoice2 != "ford mondeo" && carChoice2 != "honda civic")
                {
                    Console.WriteLine("Wrong input. Select one of the offered options.");
                    selectOption();
                }
                else
                {
                    switch (carChoice2)
                    {
                        case "seat leon":
                            secondCar = cars[0];
                            break;
                        case "transam":
                            secondCar = cars[1];
                            break;
                        case "ford mondeo":
                            secondCar = cars[2];
                            break;
                        case "honda civic":
                            secondCar = cars[3];
                            break;
                        default:
                            secondCar = null;
                            break;
                    }
                }

                Console.WriteLine($"Choose your second driver by typing his name: \n {driverBob.Name} \n {driverJohn.Name} \n {driverMark.Name} \n {driverBilly.Name}");
                string driverChoice2 = Console.ReadLine().ToLower();
                if (driverChoice2 != "bob bobsky" && driverChoice2 != "john smith" && driverChoice2 != "mark mckenna" && driverChoice2 != "billy idol")
                {
                    Console.WriteLine("Wrong input. Select one of the offered options.");
                    selectOption();
                }
                else
                {
                    switch (driverChoice2)
                    {
                        case "bob bobsky":
                            secondCar.Driver = driverBob;
                            break;
                        case "john smith":
                            secondCar.Driver = driverJohn;
                            break;
                        case "mark mckenna":
                            secondCar.Driver = driverMark;
                            break;
                        case "billy idol":
                            secondCar.Driver = driverBilly;
                            break;
                        default:
                            secondCar.Driver = null;
                            break;
                    }
                }

                RaceCars(firstCar, secondCar);
            }
        }
    }
}